using System.Globalization;
using System.IO.Compression;
using System.Text;

namespace PrTask.Transpiler;

public sealed class AndroidLayoutConverter
{
    private readonly Dictionary<string, AxmlDocument> Layouts = new(StringComparer.Ordinal);
    private readonly Dictionary<string, byte[]> Drawables = new(StringComparer.Ordinal);
    private ArscParser? Resources;

    public void LoadFromApk(string ApkPath)
    {
        using var Archive = ZipFile.OpenRead(ApkPath);

        foreach (var Entry in Archive.Entries)
        {
            if (Entry.FullName.StartsWith("res/layout/", StringComparison.Ordinal) &&
                Entry.Name.EndsWith(".xml", StringComparison.OrdinalIgnoreCase) &&
                Entry.Length > 0)
            {
                using var Stream = Entry.Open();
                using var Ms = new MemoryStream();
                Stream.CopyTo(Ms);
                var Bytes = Ms.ToArray();
                var Parser = new AxmlParser(Bytes);
                var Doc = Parser.Parse();
                if (Doc?.Root is not null)
                {
                    var Name = Path.GetFileNameWithoutExtension(Entry.Name);
                    Layouts[Name] = Doc;
                }
            }
            else if (Entry.FullName.StartsWith("res/drawable", StringComparison.Ordinal) &&
                     (Entry.Name.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                      Entry.Name.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                      Entry.Name.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                      Entry.Name.EndsWith(".webp", StringComparison.OrdinalIgnoreCase)) &&
                     Entry.Length > 0)
            {
                var Key = Path.GetFileNameWithoutExtension(Entry.Name);
                if (!Drawables.ContainsKey(Key))
                {
                    using var Stream = Entry.Open();
                    using var Ms = new MemoryStream();
                    Stream.CopyTo(Ms);
                    Drawables[Key] = Ms.ToArray();
                }
            }
        }

        var ArscEntry = Archive.GetEntry("resources.arsc");
        if (ArscEntry is not null)
        {
            using var ArscStream = ArscEntry.Open();
            using var ArscMs = new MemoryStream();
            ArscStream.CopyTo(ArscMs);
            Resources = new ArscParser(ArscMs.ToArray());
            if (Resources.Parse())
            {
                Console.WriteLine(string.Format(CultureInfo.InvariantCulture,
                    "  Parsed resources.arsc: {0} strings, {1} drawables, {2} IDs",
                    Resources.StringResources.Count, Resources.DrawableNames.Count, Resources.IdNames.Count));
            }
        }

        Console.WriteLine(string.Format(CultureInfo.InvariantCulture,
            "  Loaded {0} layouts, {1} drawables from APK", Layouts.Count, Drawables.Count));
    }

    public void GeneratePages(string OutputDir, string Namespace)
    {
        var PagesDir = Path.Combine(OutputDir, "Pages");
        Directory.CreateDirectory(PagesDir);

        var ImgDir = Path.Combine(OutputDir, "wwwroot", "img");
        Directory.CreateDirectory(ImgDir);

        foreach (var Kvp in Drawables)
        {
            var Ext = DetectImageFormat(Kvp.Value);
            File.WriteAllBytes(Path.Combine(ImgDir, Kvp.Key + Ext), Kvp.Value);
        }

        Console.WriteLine(string.Format(CultureInfo.InvariantCulture,
            "  Exported {0} drawable images", Drawables.Count));

        var AppLayouts = Layouts
            .Where(Kvp => Kvp.Key.StartsWith("fragment_", StringComparison.Ordinal) ||
                          Kvp.Key.StartsWith("toph_full_screen_", StringComparison.Ordinal))
            .OrderBy(Kvp => Kvp.Key, StringComparer.Ordinal)
            .ToList();

        var Count = 0;
        foreach (var Kvp in AppLayouts)
        {
            var PageName = ToPascalCase(Kvp.Key.Replace("fragment_", string.Empty).Replace("toph_full_screen_", string.Empty));
            var Route = "/" + Kvp.Key.Replace("fragment_", string.Empty).Replace("toph_full_screen_", string.Empty).Replace('_', '-');
            var Razor = ConvertLayoutToRazor(Kvp.Value, PageName, Route);
            File.WriteAllText(Path.Combine(PagesDir, PageName + ".razor"), Razor);
            Count++;
        }

        Console.WriteLine(string.Format(CultureInfo.InvariantCulture,
            "  Generated {0} Blazor pages from Android layouts", Count));

        GenerateNavMenu(OutputDir, Namespace, AppLayouts);
        UpdateHomePage(OutputDir, Namespace, AppLayouts);
    }

    private string ConvertLayoutToRazor(AxmlDocument Doc, string PageName, string Route)
    {
        var LoginPage = GetLoginFlowPage(Route);
        if (LoginPage is not null)
        {
            return LoginPage;
        }

        var Sb = new StringBuilder();
        Sb.Append("@page \"").Append(Route).AppendLine("\"");
        Sb.AppendLine("@inject NavigationManager Nav");
        Sb.AppendLine();

        var InputFields = new List<string>();
        var ButtonIds = new List<string>();

        if (Doc.Root is not null)
        {
            CollectInteractiveElements(Doc.Root, InputFields, ButtonIds);
            ConvertElement(Doc.Root, Sb, 0, InputFields, ButtonIds);
        }

        if (InputFields.Count > 0 || ButtonIds.Count > 0)
        {
            Sb.AppendLine();
            Sb.AppendLine("@code {");
            foreach (var Field in InputFields)
            {
                Sb.Append("    private string ").Append(SanitizeIdentifier(ToPascalCase(Field))).AppendLine(" { get; set; } = string.Empty;");
            }

            foreach (var Btn in ButtonIds)
            {
                Sb.AppendLine();
                Sb.Append("    private void On").Append(SanitizeIdentifier(ToPascalCase(Btn))).AppendLine("Click()");
                Sb.AppendLine("    {");
                Sb.AppendLine("    }");
            }

            Sb.AppendLine("}");
        }

        return Sb.ToString();
    }

    private static void CollectInteractiveElements(AxmlElement El, List<string> InputFields, List<string> ButtonIds)
    {
        var ShortTag = El.Tag.Contains('.', StringComparison.Ordinal) ? El.Tag[(El.Tag.LastIndexOf('.') + 1)..] : El.Tag;
        var Id = El.GetAttr("id");

        if (Id is not null)
        {
            var CleanId = Id.Contains("/", StringComparison.Ordinal) ? Id[(Id.LastIndexOf('/') + 1)..] : Id;

            if (ShortTag is "EditText" or "AppCompatEditText" or "TextInputEditText")
            {
                if (!InputFields.Contains(CleanId))
                {
                    InputFields.Add(CleanId);
                }
            }
            else if (ShortTag is "Button" or "AppCompatButton" or "MaterialButton" or "ImageButton")
            {
                if (!ButtonIds.Contains(CleanId))
                {
                    ButtonIds.Add(CleanId);
                }
            }
        }

        foreach (var Child in El.Children)
        {
            CollectInteractiveElements(Child, InputFields, ButtonIds);
        }
    }

    private static string? GetLoginFlowPage(string Route)
    {
        if (Route.Contains("splash", StringComparison.OrdinalIgnoreCase))
        {
            return GetSplashPage(Route);
        }

        if (Route.Contains("registration", StringComparison.OrdinalIgnoreCase))
        {
            return GetRegistrationPage(Route);
        }

        if (Route.Contains("sms-verification", StringComparison.OrdinalIgnoreCase) ||
            Route.Contains("sms_verification", StringComparison.OrdinalIgnoreCase))
        {
            return GetSmsVerificationPage(Route);
        }

        if (Route.Contains("pin-input", StringComparison.OrdinalIgnoreCase) ||
            Route.Contains("pin_input", StringComparison.OrdinalIgnoreCase))
        {
            return GetPinInputPage(Route);
        }

        if (Route.Contains("launcher", StringComparison.OrdinalIgnoreCase))
        {
            return GetLauncherPage(Route);
        }

        if (Route.Contains("statistics", StringComparison.OrdinalIgnoreCase) && !Route.Contains("receipt", StringComparison.OrdinalIgnoreCase))
        {
            return GetStatisticsPage(Route);
        }

        if (Route.Contains("inventory-list", StringComparison.OrdinalIgnoreCase) || Route.Contains("inventory_list", StringComparison.OrdinalIgnoreCase))
        {
            return GetInventoryListPage(Route);
        }

        if (Route.Contains("inventory-edit", StringComparison.OrdinalIgnoreCase) || Route.Contains("inventory_edit", StringComparison.OrdinalIgnoreCase))
        {
            return GetInventoryEditPage(Route);
        }

        if (Route.Contains("sell-receipt-choose-payment-system", StringComparison.OrdinalIgnoreCase) || Route.Contains("sell_receipt_choose_payment_system", StringComparison.OrdinalIgnoreCase))
        {
            return GetChoosePaymentPage(Route);
        }

        if (Route.Contains("receipt-statuses", StringComparison.OrdinalIgnoreCase) || Route.Contains("receipt_statuses", StringComparison.OrdinalIgnoreCase))
        {
            return GetReceiptStatusesPage(Route);
        }

        return null;
    }

    private static string GetSplashPage(string Route)
    {
        var Sb = new StringBuilder();
        Sb.Append("@page \"").Append(Route).AppendLine("\"");
        Sb.AppendLine("@inject NavigationManager Nav");
        Sb.AppendLine();
        Sb.AppendLine("<div class=\"splash-screen\">");
        Sb.AppendLine("    <h1>PocketPay</h1>");
        Sb.AppendLine("    <p>Redirecting...</p>");
        Sb.AppendLine("</div>");
        Sb.AppendLine();
        Sb.AppendLine("@code {");
        Sb.AppendLine("    protected override void OnInitialized()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        Nav.NavigateTo(\"/\", replace: true);");
        Sb.AppendLine("    }");
        Sb.AppendLine("}");
        return Sb.ToString();
    }

    private static string GetRegistrationPage(string Route)
    {
        var Sb = new StringBuilder();
        Sb.Append("@page \"").Append(Route).AppendLine("\"");
        Sb.AppendLine("@inject NavigationManager Nav");
        Sb.AppendLine("@inject HttpClient Http");
        Sb.AppendLine();
        Sb.AppendLine("<div class=\"login-form\">");
        Sb.AppendLine("    <h2>PocketPay Login</h2>");
        Sb.AppendLine("    <p>Enter your phone number and password</p>");
        Sb.AppendLine("    <input type=\"tel\" placeholder=\"09XX XXX XXXX\" @bind=\"PhoneNumber\" @bind:event=\"oninput\" />");
        Sb.AppendLine("    <input type=\"password\" placeholder=\"Password\" @bind=\"Password\" @bind:event=\"oninput\" />");
        Sb.AppendLine("    @if (ErrorMessage.Length > 0)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        <p class=\"error\">@ErrorMessage</p>");
        Sb.AppendLine("    }");
        Sb.AppendLine("    <button @onclick=\"SubmitLogin\" disabled=\"@IsLoading\">@(IsLoading ? \"Logging in...\" : \"Login\")</button>");
        Sb.AppendLine("</div>");
        Sb.AppendLine();
        Sb.AppendLine("@code {");
        Sb.AppendLine("    private string PhoneNumber { get; set; } = string.Empty;");
        Sb.AppendLine("    private string Password { get; set; } = string.Empty;");
        Sb.AppendLine("    private string ErrorMessage { get; set; } = string.Empty;");
        Sb.AppendLine("    private bool IsLoading { get; set; }");
        Sb.AppendLine();
        Sb.AppendLine("    private async Task SubmitLogin()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        ErrorMessage = string.Empty;");
        Sb.AppendLine("        if (PhoneNumber.Length < 10)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            ErrorMessage = \"Please enter a valid phone number\";");
        Sb.AppendLine("            return;");
        Sb.AppendLine("        }");
        Sb.AppendLine();
        Sb.AppendLine("        if (Password.Length == 0)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            ErrorMessage = \"Please enter your password\";");
        Sb.AppendLine("            return;");
        Sb.AppendLine("        }");
        Sb.AppendLine();
        Sb.AppendLine("        IsLoading = true;");
        Sb.AppendLine("        try");
        Sb.AppendLine("        {");
        Sb.AppendLine("            var LoginPhone = PhoneNumber.Replace(\" \", string.Empty).Replace(\"+\", string.Empty).Replace(\"-\", string.Empty);");
        Sb.AppendLine("            if (LoginPhone.StartsWith(\"0\", StringComparison.Ordinal))");
        Sb.AppendLine("            {");
        Sb.AppendLine("                LoginPhone = \"63\" + LoginPhone[1..];");
        Sb.AppendLine("            }");
        Sb.AppendLine("            else if (!LoginPhone.StartsWith(\"63\", StringComparison.Ordinal))");
        Sb.AppendLine("            {");
        Sb.AppendLine("                LoginPhone = \"63\" + LoginPhone;");
        Sb.AppendLine("            }");
        Sb.AppendLine();
        Sb.AppendLine("            var Payload = new { Method = \"login\", Payload = new { Phone = LoginPhone, Password = Password } };");
        Sb.AppendLine("            var Response = await Http.PostAsJsonAsync(\"wss-proxy/login\", Payload);");
        Sb.AppendLine("            var Result = await Response.Content.ReadFromJsonAsync<LoginResult>();");
        Sb.AppendLine("            if (Result is not null && Result.Success)");
        Sb.AppendLine("            {");
        Sb.AppendLine("                Nav.NavigateTo(\"/launcher\");");
        Sb.AppendLine("            }");
        Sb.AppendLine("            else");
        Sb.AppendLine("            {");
        Sb.AppendLine("                ErrorMessage = Result?.Error ?? \"Login failed\";");
        Sb.AppendLine("            }");
        Sb.AppendLine("        }");
        Sb.AppendLine("        catch (Exception Ex)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            ErrorMessage = Ex.Message;");
        Sb.AppendLine("        }");
        Sb.AppendLine("        finally");
        Sb.AppendLine("        {");
        Sb.AppendLine("            IsLoading = false;");
        Sb.AppendLine("        }");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private sealed record LoginResult(bool Success, string? Token, string? Error, string? ShopUuid);");
        Sb.AppendLine("}");
        return Sb.ToString();
    }

    private static string GetSmsVerificationPage(string Route)
    {
        var Sb = new StringBuilder();
        Sb.Append("@page \"").Append(Route).AppendLine("\"");
        Sb.AppendLine("@inject NavigationManager Nav");
        Sb.AppendLine();
        Sb.AppendLine("<div class=\"login-form\">");
        Sb.AppendLine("    <h2>SMS Verification</h2>");
        Sb.AppendLine("    <p>Enter the 6-digit code sent to your phone</p>");
        Sb.AppendLine("    <input class=\"otp-input\" type=\"text\" maxlength=\"6\" placeholder=\"000000\" @bind=\"OtpCode\" @bind:event=\"oninput\" @onkeyup=\"CheckOtp\" />");
        Sb.AppendLine("    @if (ErrorMessage.Length > 0)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        <p class=\"error\">@ErrorMessage</p>");
        Sb.AppendLine("    }");
        Sb.AppendLine("    <button @onclick=\"VerifyOtp\" disabled=\"@IsLoading\">@(IsLoading ? \"Verifying...\" : \"Verify\")</button>");
        Sb.AppendLine("    <p>Demo: enter any 6 digits</p>");
        Sb.AppendLine("</div>");
        Sb.AppendLine();
        Sb.AppendLine("@code {");
        Sb.AppendLine("    private string OtpCode { get; set; } = string.Empty;");
        Sb.AppendLine("    private string ErrorMessage { get; set; } = string.Empty;");
        Sb.AppendLine("    private bool IsLoading { get; set; }");
        Sb.AppendLine();
        Sb.AppendLine("    private async Task CheckOtp()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        if (OtpCode.Length == 6)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            await VerifyOtp();");
        Sb.AppendLine("        }");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private async Task VerifyOtp()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        ErrorMessage = string.Empty;");
        Sb.AppendLine("        if (OtpCode.Length != 6 || !OtpCode.All(char.IsDigit))");
        Sb.AppendLine("        {");
        Sb.AppendLine("            ErrorMessage = \"Please enter a valid 6-digit code\";");
        Sb.AppendLine("            return;");
        Sb.AppendLine("        }");
        Sb.AppendLine();
        Sb.AppendLine("        IsLoading = true;");
        Sb.AppendLine("        await Task.Delay(600);");
        Sb.AppendLine("        IsLoading = false;");
        Sb.AppendLine("        Nav.NavigateTo(\"/pin-input\");");
        Sb.AppendLine("    }");
        Sb.AppendLine("}");
        return Sb.ToString();
    }

    private static string GetPinInputPage(string Route)
    {
        var Sb = new StringBuilder();
        Sb.Append("@page \"").Append(Route).AppendLine("\"");
        Sb.AppendLine("@inject NavigationManager Nav");
        Sb.AppendLine();
        Sb.AppendLine("<div class=\"login-form\">");
        Sb.AppendLine("    <h2>Create PIN</h2>");
        Sb.AppendLine("    <p>Set a 4-digit PIN for quick access</p>");
        Sb.AppendLine("    <div class=\"pin-dots\">");
        Sb.AppendLine("        @for (var I = 0; I < 4; I++)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            <div class=\"pin-dot @(I < Pin.Length ? \"filled\" : \"\")\"></div>");
        Sb.AppendLine("        }");
        Sb.AppendLine("    </div>");
        Sb.AppendLine("    <div class=\"numpad\">");
        Sb.AppendLine("        @for (var I = 1; I <= 9; I++)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            var Digit = I;");
        Sb.AppendLine("            <button @onclick=\"() => PressDigit(Digit)\">@Digit</button>");
        Sb.AppendLine("        }");
        Sb.AppendLine("        <button disabled></button>");
        Sb.AppendLine("        <button @onclick=\"() => PressDigit(0)\">0</button>");
        Sb.AppendLine("        <button @onclick=\"DeleteDigit\">\u232B</button>");
        Sb.AppendLine("    </div>");
        Sb.AppendLine("    @if (ErrorMessage.Length > 0)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        <p class=\"error\">@ErrorMessage</p>");
        Sb.AppendLine("    }");
        Sb.AppendLine("</div>");
        Sb.AppendLine();
        Sb.AppendLine("@code {");
        Sb.AppendLine("    private string Pin { get; set; } = string.Empty;");
        Sb.AppendLine("    private string ErrorMessage { get; set; } = string.Empty;");
        Sb.AppendLine();
        Sb.AppendLine("    private async Task PressDigit(int Digit)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        if (Pin.Length >= 4) return;");
        Sb.AppendLine("        Pin += Digit.ToString(System.Globalization.CultureInfo.InvariantCulture);");
        Sb.AppendLine("        if (Pin.Length == 4)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            await Task.Delay(300);");
        Sb.AppendLine("            Nav.NavigateTo(\"/launcher\");");
        Sb.AppendLine("        }");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private void DeleteDigit()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        if (Pin.Length > 0)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            Pin = Pin[..^1];");
        Sb.AppendLine("        }");
        Sb.AppendLine("    }");
        Sb.AppendLine("}");
        return Sb.ToString();
    }

    private static string GetLauncherPage(string Route)
    {
        var Sb = new StringBuilder();
        Sb.Append("@page \"").Append(Route).AppendLine("\"");
        Sb.AppendLine("@inject NavigationManager Nav");
        Sb.AppendLine("@inject HttpClient Http");
        Sb.AppendLine();
        Sb.AppendLine("<div class=\"app-shell\">");
        Sb.AppendLine("    <header class=\"app-header\">");
        Sb.AppendLine("        <h1>PocketPay</h1>");
        Sb.AppendLine("        <p>@WelcomeMessage</p>");
        Sb.AppendLine("    </header>");
        Sb.AppendLine("    @if (StoreName.Length > 0)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        <div class=\"card\"><h2>@StoreName</h2><p>@UserRole - @Region</p></div>");
        Sb.AppendLine("    }");
        Sb.AppendLine("    <div class=\"dashboard-grid\">");
        Sb.AppendLine("        <a class=\"dashboard-tile\" href=\"/tap-on-phone-sell\"><h3>New Sale</h3><p>Tap to pay</p></a>");
        Sb.AppendLine("        <a class=\"dashboard-tile\" href=\"/statistics\"><h3>Statistics</h3><p>View reports</p></a>");
        Sb.AppendLine("        <a class=\"dashboard-tile\" href=\"/receipt-statuses\"><h3>Receipts</h3><p>Transaction history</p></a>");
        Sb.AppendLine("        <a class=\"dashboard-tile\" href=\"/inventory-list\"><h3>Inventory</h3><p>Manage items</p></a>");
        Sb.AppendLine("        <a class=\"dashboard-tile\" href=\"/main-settings\"><h3>Settings</h3><p>Configuration</p></a>");
        Sb.AppendLine("        <a class=\"dashboard-tile\" href=\"/company-details\"><h3>Company</h3><p>Business info</p></a>");
        Sb.AppendLine("    </div>");
        Sb.AppendLine("</div>");
        Sb.AppendLine();
        Sb.AppendLine("@code {");
        Sb.AppendLine("    private string WelcomeMessage { get; set; } = \"Loading...\";");
        Sb.AppendLine("    private string StoreName { get; set; } = string.Empty;");
        Sb.AppendLine("    private string UserRole { get; set; } = string.Empty;");
        Sb.AppendLine("    private string Region { get; set; } = string.Empty;");
        Sb.AppendLine();
        Sb.AppendLine("    protected override async Task OnInitializedAsync()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        try");
        Sb.AppendLine("        {");
        Sb.AppendLine("            var CheckResponse = await Http.PostAsJsonAsync(\"wss-proxy/check-user\", new { Method = \"check_user\" });");
        Sb.AppendLine("            var CheckResult = await CheckResponse.Content.ReadFromJsonAsync<CheckUserResult>();");
        Sb.AppendLine("            if (CheckResult is not null && CheckResult.UserExists)");
        Sb.AppendLine("            {");
        Sb.AppendLine("                UserRole = CheckResult.Role ?? \"BUSINESS\";");
        Sb.AppendLine("                Region = CheckResult.Region ?? \"PH\";");
        Sb.AppendLine("                WelcomeMessage = $\"Welcome, {CheckResult.UserId ?? \"Merchant\"}\";");
        Sb.AppendLine();
        Sb.AppendLine("                if (CheckResult.UserId is not null)");
        Sb.AppendLine("                {");
        Sb.AppendLine("                    var StoresResponse = await Http.GetFromJsonAsync<StoreInfo[]>($\"wss-proxy/stores?userId={CheckResult.UserId}\");");
        Sb.AppendLine("                    if (StoresResponse is not null && StoresResponse.Length > 0)");
        Sb.AppendLine("                    {");
        Sb.AppendLine("                        StoreName = StoresResponse[0].Name ?? \"My Store\";");
        Sb.AppendLine("                    }");
        Sb.AppendLine("                }");
        Sb.AppendLine("            }");
        Sb.AppendLine("            else");
        Sb.AppendLine("            {");
        Sb.AppendLine("                WelcomeMessage = \"Welcome, Merchant\";");
        Sb.AppendLine("            }");
        Sb.AppendLine("        }");
        Sb.AppendLine("        catch");
        Sb.AppendLine("        {");
        Sb.AppendLine("            WelcomeMessage = \"Welcome, Merchant\";");
        Sb.AppendLine("        }");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private sealed record CheckUserResult(bool UserExists, string? UserId, string? Role, string? Region);");
        Sb.AppendLine("    private sealed record StoreInfo(string? Id, string? Name, string? Address);");
        Sb.AppendLine("}");
        return Sb.ToString();
    }

    private static string GetStatisticsPage(string Route)
    {
        var Sb = new StringBuilder();
        Sb.Append("@page \"").Append(Route).AppendLine("\"");
        Sb.AppendLine("@inject NavigationManager Nav");
        Sb.AppendLine("@inject HttpClient Http");
        Sb.AppendLine();
        Sb.AppendLine("<div class=\"app-shell\">");
        Sb.AppendLine("    <header class=\"app-header\"><a href=\"/\">\u2190 Back</a><h2>Statistics</h2></header>");
        Sb.AppendLine("    <div class=\"card\">");
        Sb.AppendLine("        <label>Date From</label>");
        Sb.AppendLine("        <input type=\"date\" @bind=\"DateFrom\" />");
        Sb.AppendLine("        <label>Date To</label>");
        Sb.AppendLine("        <input type=\"date\" @bind=\"DateTo\" />");
        Sb.AppendLine("        <button @onclick=\"LoadStats\" disabled=\"@IsLoading\">@(IsLoading ? \"Loading...\" : \"Load Statistics\")</button>");
        Sb.AppendLine("    </div>");
        Sb.AppendLine("    @if (ErrorMessage.Length > 0)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        <p class=\"error\">@ErrorMessage</p>");
        Sb.AppendLine("    }");
        Sb.AppendLine("    @if (TotalSales > 0 || TotalCount > 0)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        <div class=\"card\">");
        Sb.AppendLine("            <h3>Sales Summary</h3>");
        Sb.AppendLine("            <p>Total Sales: @TotalSales.ToString(\"C2\", System.Globalization.CultureInfo.GetCultureInfo(\"en-PH\"))</p>");
        Sb.AppendLine("            <p>Transaction Count: @TotalCount</p>");
        Sb.AppendLine("            <p>Period: @DateFrom.ToString(\"yyyy-MM-dd\") to @DateTo.ToString(\"yyyy-MM-dd\")</p>");
        Sb.AppendLine("        </div>");
        Sb.AppendLine("    }");
        Sb.AppendLine("    @if (StatsRaw.Length > 0)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        <pre style=\"font-size:0.75rem;overflow:auto\">@StatsRaw</pre>");
        Sb.AppendLine("    }");
        Sb.AppendLine("</div>");
        Sb.AppendLine();
        Sb.AppendLine("@code {");
        Sb.AppendLine("    private DateTime DateFrom { get; set; } = DateTime.Today.AddDays(-30);");
        Sb.AppendLine("    private DateTime DateTo { get; set; } = DateTime.Today;");
        Sb.AppendLine("    private bool IsLoading { get; set; }");
        Sb.AppendLine("    private string ErrorMessage { get; set; } = string.Empty;");
        Sb.AppendLine("    private decimal TotalSales { get; set; }");
        Sb.AppendLine("    private int TotalCount { get; set; }");
        Sb.AppendLine("    private string StatsRaw { get; set; } = string.Empty;");
        Sb.AppendLine();
        Sb.AppendLine("    private async Task LoadStats()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        ErrorMessage = string.Empty;");
        Sb.AppendLine("        IsLoading = true;");
        Sb.AppendLine("        try");
        Sb.AppendLine("        {");
        Sb.AppendLine("            var DateFromMs = new DateTimeOffset(DateFrom).ToUnixTimeMilliseconds();");
        Sb.AppendLine("            var DateToMs = new DateTimeOffset(DateTo.AddDays(1)).ToUnixTimeMilliseconds();");
        Sb.AppendLine("            var Payload = new { Method = \"get_stats\", Payload = new { DateFrom = DateFromMs, DateTo = DateToMs } };");
        Sb.AppendLine("            var Response = await Http.PostAsJsonAsync(\"wss-proxy/get-stats\", Payload);");
        Sb.AppendLine("            var Result = await Response.Content.ReadFromJsonAsync<StatsResult>();");
        Sb.AppendLine("            if (Result is not null && Result.Success)");
        Sb.AppendLine("            {");
        Sb.AppendLine("                TotalSales = Result.TotalSales;");
        Sb.AppendLine("                TotalCount = Result.TotalCount;");
        Sb.AppendLine("                StatsRaw = Result.Raw ?? string.Empty;");
        Sb.AppendLine("            }");
        Sb.AppendLine("            else");
        Sb.AppendLine("            {");
        Sb.AppendLine("                ErrorMessage = Result?.Error ?? \"Failed to load statistics\";");
        Sb.AppendLine("            }");
        Sb.AppendLine("        }");
        Sb.AppendLine("        catch (Exception Ex)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            ErrorMessage = Ex.Message;");
        Sb.AppendLine("        }");
        Sb.AppendLine("        finally");
        Sb.AppendLine("        {");
        Sb.AppendLine("            IsLoading = false;");
        Sb.AppendLine("        }");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private sealed record StatsResult(bool Success, decimal TotalSales, int TotalCount, string? Raw, string? Error);");
        Sb.AppendLine("}");
        return Sb.ToString();
    }

    private static string GetInventoryListPage(string Route)
    {
        var Sb = new StringBuilder();
        Sb.Append("@page \"").Append(Route).AppendLine("\"");
        Sb.AppendLine("@inject NavigationManager Nav");
        Sb.AppendLine("@inject HttpClient Http");
        Sb.AppendLine();
        Sb.AppendLine("<div class=\"app-shell\">");
        Sb.AppendLine("    <header class=\"app-header\"><a href=\"/\">\u2190 Back</a><h2>Inventory</h2></header>");
        Sb.AppendLine("    <button @onclick=\"LoadProducts\" disabled=\"@IsLoading\">@(IsLoading ? \"Loading...\" : \"Refresh\")</button>");
        Sb.AppendLine("    <button @onclick=\"AddNew\">+ Add Product</button>");
        Sb.AppendLine("    @if (ErrorMessage.Length > 0)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        <p class=\"error\">@ErrorMessage</p>");
        Sb.AppendLine("    }");
        Sb.AppendLine("    <div class=\"product-list\">");
        Sb.AppendLine("        @foreach (var P in Products)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            <div class=\"card product-card\" @onclick=\"() => EditProduct(P.Id)\">");
        Sb.AppendLine("                <h3>@P.Name</h3>");
        Sb.AppendLine("                <p>Code: @P.Code | Price: @P.Price.ToString(\"F2\", System.Globalization.CultureInfo.InvariantCulture)</p>");
        Sb.AppendLine("                <button @onclick:stopPropagation @onclick=\"() => DeleteProduct(P.Id)\">Delete</button>");
        Sb.AppendLine("            </div>");
        Sb.AppendLine("        }");
        Sb.AppendLine("    </div>");
        Sb.AppendLine("</div>");
        Sb.AppendLine();
        Sb.AppendLine("@code {");
        Sb.AppendLine("    private bool IsLoading { get; set; }");
        Sb.AppendLine("    private string ErrorMessage { get; set; } = string.Empty;");
        Sb.AppendLine("    private List<ProductItem> Products { get; set; } = new();");
        Sb.AppendLine();
        Sb.AppendLine("    protected override async Task OnInitializedAsync()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        await LoadProducts();");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private async Task LoadProducts()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        ErrorMessage = string.Empty;");
        Sb.AppendLine("        IsLoading = true;");
        Sb.AppendLine("        try");
        Sb.AppendLine("        {");
        Sb.AppendLine("            var Payload = new { Method = \"get_products\" };");
        Sb.AppendLine("            var Response = await Http.PostAsJsonAsync(\"wss-proxy/get-products\", Payload);");
        Sb.AppendLine("            var Result = await Response.Content.ReadFromJsonAsync<ProductsResult>();");
        Sb.AppendLine("            if (Result is not null && Result.Success)");
        Sb.AppendLine("            {");
        Sb.AppendLine("                Products = Result.Items ?? new();");
        Sb.AppendLine("            }");
        Sb.AppendLine("            else");
        Sb.AppendLine("            {");
        Sb.AppendLine("                ErrorMessage = Result?.Error ?? \"Failed to load products\";");
        Sb.AppendLine("            }");
        Sb.AppendLine("        }");
        Sb.AppendLine("        catch (Exception Ex)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            ErrorMessage = Ex.Message;");
        Sb.AppendLine("        }");
        Sb.AppendLine("        finally");
        Sb.AppendLine("        {");
        Sb.AppendLine("            IsLoading = false;");
        Sb.AppendLine("        }");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private void AddNew()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        Nav.NavigateTo(\"/inventory-edit\");");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private void EditProduct(string Id)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        Nav.NavigateTo($\"/inventory-edit?id={Id}\");");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private async Task DeleteProduct(string Id)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        try");
        Sb.AppendLine("        {");
        Sb.AppendLine("            var Payload = new { Method = \"delete_product\", Payload = new { ProductId = Id } };");
        Sb.AppendLine("            await Http.PostAsJsonAsync(\"wss-proxy/delete-product\", Payload);");
        Sb.AppendLine("            await LoadProducts();");
        Sb.AppendLine("        }");
        Sb.AppendLine("        catch (Exception Ex)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            ErrorMessage = Ex.Message;");
        Sb.AppendLine("        }");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private sealed record ProductItem(string Id, string Name, string Code, decimal Price, decimal CostPrice, string? ArticleNumber);");
        Sb.AppendLine("    private sealed record ProductsResult(bool Success, List<ProductItem>? Items, string? Error);");
        Sb.AppendLine("}");
        return Sb.ToString();
    }

    private static string GetInventoryEditPage(string Route)
    {
        var Sb = new StringBuilder();
        Sb.Append("@page \"").Append(Route).AppendLine("\"");
        Sb.AppendLine("@inject NavigationManager Nav");
        Sb.AppendLine("@inject HttpClient Http");
        Sb.AppendLine();
        Sb.AppendLine("<div class=\"app-shell\">");
        Sb.AppendLine("    <header class=\"app-header\"><a href=\"/inventory-list\">\u2190 Back</a><h2>@(IsEdit ? \"Edit Product\" : \"New Product\")</h2></header>");
        Sb.AppendLine("    <div class=\"card\">");
        Sb.AppendLine("        <label>Name</label>");
        Sb.AppendLine("        <input type=\"text\" @bind=\"ProductName\" @bind:event=\"oninput\" placeholder=\"Product name\" />");
        Sb.AppendLine("        <label>Code</label>");
        Sb.AppendLine("        <input type=\"text\" @bind=\"Code\" @bind:event=\"oninput\" placeholder=\"Product code\" />");
        Sb.AppendLine("        <label>Price</label>");
        Sb.AppendLine("        <input type=\"number\" step=\"0.01\" @bind=\"Price\" />");
        Sb.AppendLine("        <label>Cost Price</label>");
        Sb.AppendLine("        <input type=\"number\" step=\"0.01\" @bind=\"CostPrice\" />");
        Sb.AppendLine("        <label>Tax (%)</label>");
        Sb.AppendLine("        <input type=\"number\" step=\"0.01\" @bind=\"Tax\" />");
        Sb.AppendLine("        <label>Measure</label>");
        Sb.AppendLine("        <select @bind=\"MeasureName\">");
        Sb.AppendLine("            <option value=\"pcs\">Pieces</option>");
        Sb.AppendLine("            <option value=\"kg\">Kilograms</option>");
        Sb.AppendLine("            <option value=\"l\">Liters</option>");
        Sb.AppendLine("            <option value=\"m\">Meters</option>");
        Sb.AppendLine("        </select>");
        Sb.AppendLine("        <label>Description</label>");
        Sb.AppendLine("        <textarea @bind=\"Description\" @bind:event=\"oninput\" placeholder=\"Description\"></textarea>");
        Sb.AppendLine("        @if (ErrorMessage.Length > 0)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            <p class=\"error\">@ErrorMessage</p>");
        Sb.AppendLine("        }");
        Sb.AppendLine("        <button @onclick=\"SaveProduct\" disabled=\"@IsLoading\">@(IsLoading ? \"Saving...\" : \"Save\")</button>");
        Sb.AppendLine("    </div>");
        Sb.AppendLine("</div>");
        Sb.AppendLine();
        Sb.AppendLine("@code {");
        Sb.AppendLine("    private string ProductId { get; set; } = string.Empty;");
        Sb.AppendLine("    private string ProductName { get; set; } = string.Empty;");
        Sb.AppendLine("    private string Code { get; set; } = string.Empty;");
        Sb.AppendLine("    private decimal Price { get; set; }");
        Sb.AppendLine("    private decimal CostPrice { get; set; }");
        Sb.AppendLine("    private decimal Tax { get; set; }");
        Sb.AppendLine("    private string MeasureName { get; set; } = \"pcs\";");
        Sb.AppendLine("    private string Description { get; set; } = string.Empty;");
        Sb.AppendLine("    private string ErrorMessage { get; set; } = string.Empty;");
        Sb.AppendLine("    private bool IsLoading { get; set; }");
        Sb.AppendLine("    private bool IsEdit => ProductId.Length > 0;");
        Sb.AppendLine();
        Sb.AppendLine("    protected override void OnInitialized()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        var Uri = new Uri(Nav.Uri);");
        Sb.AppendLine("        var Query = System.Web.HttpUtility.ParseQueryString(Uri.Query);");
        Sb.AppendLine("        ProductId = Query[\"id\"] ?? string.Empty;");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private async Task SaveProduct()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        ErrorMessage = string.Empty;");
        Sb.AppendLine("        if (ProductName.Length == 0)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            ErrorMessage = \"Name is required\";");
        Sb.AppendLine("            return;");
        Sb.AppendLine("        }");
        Sb.AppendLine();
        Sb.AppendLine("        IsLoading = true;");
        Sb.AppendLine("        try");
        Sb.AppendLine("        {");
        Sb.AppendLine("            var Method = IsEdit ? \"update_product\" : \"create_product\";");
        Sb.AppendLine("            var Payload = new { Method, Payload = new { ProductId, Name = ProductName, Code, Price, CostPrice, Tax, MeasureName, Description, AllowToSell = true, Type = \"NORMAL\", Quantity = 0 } };");
        Sb.AppendLine("            var Endpoint = IsEdit ? \"wss-proxy/update-product\" : \"wss-proxy/create-product\";");
        Sb.AppendLine("            var Response = await Http.PostAsJsonAsync(Endpoint, Payload);");
        Sb.AppendLine("            var Result = await Response.Content.ReadFromJsonAsync<SaveResult>();");
        Sb.AppendLine("            if (Result is not null && Result.Success)");
        Sb.AppendLine("            {");
        Sb.AppendLine("                Nav.NavigateTo(\"/inventory-list\");");
        Sb.AppendLine("            }");
        Sb.AppendLine("            else");
        Sb.AppendLine("            {");
        Sb.AppendLine("                ErrorMessage = Result?.Error ?? \"Failed to save\";");
        Sb.AppendLine("            }");
        Sb.AppendLine("        }");
        Sb.AppendLine("        catch (Exception Ex)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            ErrorMessage = Ex.Message;");
        Sb.AppendLine("        }");
        Sb.AppendLine("        finally");
        Sb.AppendLine("        {");
        Sb.AppendLine("            IsLoading = false;");
        Sb.AppendLine("        }");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private sealed record SaveResult(bool Success, string? Error);");
        Sb.AppendLine("}");
        return Sb.ToString();
    }

    private static string GetChoosePaymentPage(string Route)
    {
        var Sb = new StringBuilder();
        Sb.Append("@page \"").Append(Route).AppendLine("\"");
        Sb.AppendLine("@page \"/sell\"");
        Sb.AppendLine("@inject NavigationManager Nav");
        Sb.AppendLine("@inject HttpClient Http");
        Sb.AppendLine();
        Sb.AppendLine("<div class=\"app-shell\">");
        Sb.AppendLine("    <header class=\"app-header\"><a href=\"/\">\u2190 Back</a><h2>New Sale</h2></header>");
        Sb.AppendLine();
        Sb.AppendLine("    @if (ReceiptNumber > 0)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        <div class=\"card\" style=\"text-align:center\">");
        Sb.AppendLine("            <h2 style=\"color:green\">Receipt Created</h2>");
        Sb.AppendLine("            <p>Receipt #@ReceiptNumber</p>");
        Sb.AppendLine("            <p>Type: @ReceiptType</p>");
        Sb.AppendLine("            <p>@ReceiptCloseDate</p>");
        Sb.AppendLine("            <button @onclick=\"ResetSale\">New Sale</button>");
        Sb.AppendLine("            <button @onclick=\"GoToReceipts\">View Receipts</button>");
        Sb.AppendLine("        </div>");
        Sb.AppendLine("    }");
        Sb.AppendLine("    else");
        Sb.AppendLine("    {");
        Sb.AppendLine("        <div class=\"card\">");
        Sb.AppendLine("            <h3>Products</h3>");
        Sb.AppendLine("            @if (IsLoadingProducts)");
        Sb.AppendLine("            {");
        Sb.AppendLine("                <p>Loading products...</p>");
        Sb.AppendLine("            }");
        Sb.AppendLine("            else");
        Sb.AppendLine("            {");
        Sb.AppendLine("                @foreach (var P in Products)");
        Sb.AppendLine("                {");
        Sb.AppendLine("                    <div style=\"display:flex;align-items:center;gap:8px;margin:4px 0\">");
        Sb.AppendLine("                        <span style=\"flex:1\">@P.Name (@P.Price.ToString(\"F2\", System.Globalization.CultureInfo.InvariantCulture))</span>");
        Sb.AppendLine("                        <button @onclick=\"() => RemoveFromCart(P.Id)\">-</button>");
        Sb.AppendLine("                        <span>@GetCartQty(P.Id)</span>");
        Sb.AppendLine("                        <button @onclick=\"() => AddToCart(P.Id)\">+</button>");
        Sb.AppendLine("                    </div>");
        Sb.AppendLine("                }");
        Sb.AppendLine("            }");
        Sb.AppendLine("        </div>");
        Sb.AppendLine();
        Sb.AppendLine("        @if (CartItems.Count > 0)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            <div class=\"card\">");
        Sb.AppendLine("                <h3>Cart</h3>");
        Sb.AppendLine("                @foreach (var Ci in CartItems)");
        Sb.AppendLine("                {");
        Sb.AppendLine("                    var Prod = Products.FirstOrDefault(X => X.Id == Ci.Key);");
        Sb.AppendLine("                    if (Prod is not null)");
        Sb.AppendLine("                    {");
        Sb.AppendLine("                        <p>@Prod.Name x @Ci.Value = @((Prod.Price * Ci.Value).ToString(\"F2\", System.Globalization.CultureInfo.InvariantCulture))</p>");
        Sb.AppendLine("                    }");
        Sb.AppendLine("                }");
        Sb.AppendLine("                <p><strong>Total: @CartTotal.ToString(\"F2\", System.Globalization.CultureInfo.InvariantCulture)</strong></p>");
        Sb.AppendLine("            </div>");
        Sb.AppendLine("        }");
        Sb.AppendLine();
        Sb.AppendLine("        <div class=\"card\">");
        Sb.AppendLine("            <h3>Payment Method</h3>");
        Sb.AppendLine("            <div class=\"dashboard-grid\">");
        Sb.AppendLine("                <button class=\"dashboard-tile\" @onclick=\"SelectCash\"><h3>\U0001F4B5</h3><p>@(PaymentType == \"CASH\" ? \"[Cash]\" : \"Cash\")</p></button>");
        Sb.AppendLine("                <button class=\"dashboard-tile\" @onclick=\"SelectCard\"><h3>\U0001F4B3</h3><p>@(PaymentType == \"CARD\" ? \"[Card]\" : \"Card\")</p></button>");
        Sb.AppendLine("            </div>");
        Sb.AppendLine("        </div>");
        Sb.AppendLine();
        Sb.AppendLine("        @if (ErrorMessage.Length > 0)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            <p class=\"error\">@ErrorMessage</p>");
        Sb.AppendLine("        }");
        Sb.AppendLine("        <button @onclick=\"CreateReceipt\" disabled=\"@(IsLoading || CartItems.Count == 0)\">@(IsLoading ? \"Processing...\" : \"Create Receipt\")</button>");
        Sb.AppendLine("    }");
        Sb.AppendLine("</div>");
        Sb.AppendLine();
        Sb.AppendLine("@code {");
        Sb.AppendLine("    private string PaymentType { get; set; } = \"CASH\";");
        Sb.AppendLine("    private string ErrorMessage { get; set; } = string.Empty;");
        Sb.AppendLine("    private bool IsLoading { get; set; }");
        Sb.AppendLine("    private bool IsLoadingProducts { get; set; }");
        Sb.AppendLine("    private List<ProductItem> Products { get; set; } = new();");
        Sb.AppendLine("    private Dictionary<string, int> CartItems { get; set; } = new(StringComparer.Ordinal);");
        Sb.AppendLine("    private long ReceiptNumber { get; set; }");
        Sb.AppendLine("    private string ReceiptType { get; set; } = string.Empty;");
        Sb.AppendLine("    private string ReceiptCloseDate { get; set; } = string.Empty;");
        Sb.AppendLine();
        Sb.AppendLine("    private decimal CartTotal => CartItems.Sum(Ci => { var P = Products.FirstOrDefault(X => X.Id == Ci.Key); return P is not null ? P.Price * Ci.Value : 0m; });");
        Sb.AppendLine();
        Sb.AppendLine("    protected override async Task OnInitializedAsync()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        await LoadProducts();");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private async Task LoadProducts()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        IsLoadingProducts = true;");
        Sb.AppendLine("        try");
        Sb.AppendLine("        {");
        Sb.AppendLine("            var Payload = new { Method = \"get_products\" };");
        Sb.AppendLine("            var Response = await Http.PostAsJsonAsync(\"wss-proxy/get-products\", Payload);");
        Sb.AppendLine("            var Result = await Response.Content.ReadFromJsonAsync<ProductsResult>();");
        Sb.AppendLine("            if (Result is not null && Result.Success) Products = Result.Items ?? new();");
        Sb.AppendLine("        }");
        Sb.AppendLine("        catch (Exception Ex) { ErrorMessage = Ex.Message; }");
        Sb.AppendLine("        finally { IsLoadingProducts = false; }");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private int GetCartQty(string Id) => CartItems.TryGetValue(Id, out var Q) ? Q : 0;");
        Sb.AppendLine();
        Sb.AppendLine("    private void AddToCart(string Id)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        if (CartItems.ContainsKey(Id)) CartItems[Id]++;");
        Sb.AppendLine("        else CartItems[Id] = 1;");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private void RemoveFromCart(string Id)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        if (CartItems.TryGetValue(Id, out var Q) && Q > 1) CartItems[Id] = Q - 1;");
        Sb.AppendLine("        else CartItems.Remove(Id);");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private void SelectCash() { PaymentType = \"CASH\"; }");
        Sb.AppendLine("    private void SelectCard() { PaymentType = \"CARD\"; }");
        Sb.AppendLine();
        Sb.AppendLine("    private void ResetSale()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        ReceiptNumber = 0;");
        Sb.AppendLine("        ReceiptType = string.Empty;");
        Sb.AppendLine("        ReceiptCloseDate = string.Empty;");
        Sb.AppendLine("        CartItems.Clear();");
        Sb.AppendLine("        ErrorMessage = string.Empty;");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private void GoToReceipts() { Nav.NavigateTo(\"/receipt-statuses\"); }");
        Sb.AppendLine();
        Sb.AppendLine("    private async Task CreateReceipt()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        ErrorMessage = string.Empty;");
        Sb.AppendLine("        if (CartItems.Count == 0) { ErrorMessage = \"Add items to cart first\"; return; }");
        Sb.AppendLine();
        Sb.AppendLine("        IsLoading = true;");
        Sb.AppendLine("        try");
        Sb.AppendLine("        {");
        Sb.AppendLine("            var Positions = CartItems.Select(Ci =>");
        Sb.AppendLine("            {");
        Sb.AppendLine("                var P = Products.First(X => X.Id == Ci.Key);");
        Sb.AppendLine("                return new { CommodityId = P.Id, Name = P.Name, Price = P.Price, Quantity = Ci.Value, Tax = P.Tax, MeasureName = P.MeasureName ?? \"pcs\" };");
        Sb.AppendLine("            }).ToArray();");
        Sb.AppendLine();
        Sb.AppendLine("            var Payload = new { Method = \"create_receipt\", Payload = new { Amount = CartTotal, PaymentType, OperationType = \"SELL\", Positions } };");
        Sb.AppendLine("            var Response = await Http.PostAsJsonAsync(\"wss-proxy/create-receipt\", Payload);");
        Sb.AppendLine("            var Result = await Response.Content.ReadFromJsonAsync<ReceiptResult>();");
        Sb.AppendLine("            if (Result is not null && Result.Success)");
        Sb.AppendLine("            {");
        Sb.AppendLine("                ReceiptNumber = Result.Number;");
        Sb.AppendLine("                ReceiptType = Result.Type ?? \"SELL\";");
        Sb.AppendLine("                ReceiptCloseDate = Result.CloseDate ?? string.Empty;");
        Sb.AppendLine("            }");
        Sb.AppendLine("            else");
        Sb.AppendLine("            {");
        Sb.AppendLine("                ErrorMessage = Result?.Error ?? \"Failed to create receipt\";");
        Sb.AppendLine("            }");
        Sb.AppendLine("        }");
        Sb.AppendLine("        catch (Exception Ex) { ErrorMessage = Ex.Message; }");
        Sb.AppendLine("        finally { IsLoading = false; }");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private sealed record ProductItem(string Id, string Name, string Code, decimal Price, decimal CostPrice, string? ArticleNumber, decimal Tax = 0, string? MeasureName = \"pcs\");");
        Sb.AppendLine("    private sealed record ProductsResult(bool Success, List<ProductItem>? Items, string? Error);");
        Sb.AppendLine("    private sealed record ReceiptResult(bool Success, string? Error, long Number = 0, string? Type = null, string? Id = null, string? CloseDate = null, string? SessionId = null);");
        Sb.AppendLine("}");
        return Sb.ToString();
    }

    private static string GetReceiptStatusesPage(string Route)
    {
        var Sb = new StringBuilder();
        Sb.Append("@page \"").Append(Route).AppendLine("\"");
        Sb.AppendLine("@inject NavigationManager Nav");
        Sb.AppendLine("@inject HttpClient Http");
        Sb.AppendLine();
        Sb.AppendLine("<div class=\"app-shell\">");
        Sb.AppendLine("    <header class=\"app-header\"><a href=\"/\">\u2190 Back</a><h2>Recent Receipts</h2></header>");
        Sb.AppendLine("    <button @onclick=\"LoadReceipts\" disabled=\"@IsLoading\">@(IsLoading ? \"Loading...\" : \"Refresh\")</button>");
        Sb.AppendLine("    @if (ErrorMessage.Length > 0)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        <p class=\"error\">@ErrorMessage</p>");
        Sb.AppendLine("    }");
        Sb.AppendLine("    <div class=\"product-list\">");
        Sb.AppendLine("        @foreach (var R in Receipts)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            <div class=\"card\">");
        Sb.AppendLine("                <p><strong>Receipt #@R.Number</strong> <span style=\"float:right\">@R.Type</span></p>");
        Sb.AppendLine("                <p>Amount: @R.Total.ToString(\"F2\", System.Globalization.CultureInfo.InvariantCulture)</p>");
        Sb.AppendLine("                <p>Date: @R.CloseDate</p>");
        Sb.AppendLine("            </div>");
        Sb.AppendLine("        }");
        Sb.AppendLine("        @if (!IsLoading && Receipts.Count == 0)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            <p>No receipts found</p>");
        Sb.AppendLine("        }");
        Sb.AppendLine("    </div>");
        Sb.AppendLine("</div>");
        Sb.AppendLine();
        Sb.AppendLine("@code {");
        Sb.AppendLine("    private bool IsLoading { get; set; }");
        Sb.AppendLine("    private string ErrorMessage { get; set; } = string.Empty;");
        Sb.AppendLine("    private List<ReceiptEntry> Receipts { get; set; } = new();");
        Sb.AppendLine();
        Sb.AppendLine("    protected override async Task OnInitializedAsync()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        await LoadReceipts();");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private async Task LoadReceipts()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        ErrorMessage = string.Empty;");
        Sb.AppendLine("        IsLoading = true;");
        Sb.AppendLine("        try");
        Sb.AppendLine("        {");
        Sb.AppendLine("            var DateFromMs = new DateTimeOffset(DateTime.Today.AddDays(-30)).ToUnixTimeMilliseconds();");
        Sb.AppendLine("            var DateToMs = new DateTimeOffset(DateTime.Today.AddDays(1)).ToUnixTimeMilliseconds();");
        Sb.AppendLine("            var Payload = new { Method = \"get_stats\", Payload = new { DateFrom = DateFromMs, DateTo = DateToMs } };");
        Sb.AppendLine("            var Response = await Http.PostAsJsonAsync(\"wss-proxy/get-stats\", Payload);");
        Sb.AppendLine("            var Json = await Response.Content.ReadAsStringAsync();");
        Sb.AppendLine("            using var Doc = System.Text.Json.JsonDocument.Parse(Json);");
        Sb.AppendLine("            var Data = Doc.RootElement.GetProperty(\"data\");");
        Sb.AppendLine("            var RawJson = Data.TryGetProperty(\"raw\", out var RawEl) ? RawEl.GetString() ?? \"{}\" : \"{}\";");
        Sb.AppendLine("            using var RawDoc = System.Text.Json.JsonDocument.Parse(RawJson);");
        Sb.AppendLine("            if (RawDoc.RootElement.TryGetProperty(\"content\", out var ContentEl) && ContentEl.ValueKind == System.Text.Json.JsonValueKind.Array)");
        Sb.AppendLine("            {");
        Sb.AppendLine("                Receipts.Clear();");
        Sb.AppendLine("                foreach (var Item in ContentEl.EnumerateArray())");
        Sb.AppendLine("                {");
        Sb.AppendLine("                    var RType = Item.TryGetProperty(\"type\", out var TEl) ? TEl.GetString() ?? \"SELL\" : \"SELL\";");
        Sb.AppendLine("                    var RNum = Item.TryGetProperty(\"number\", out var NEl) ? NEl.GetInt64() : 0;");
        Sb.AppendLine("                    var RTotal = Item.TryGetProperty(\"total\", out var ToEl) ? ToEl.GetDecimal() : 0m;");
        Sb.AppendLine("                    var RClose = Item.TryGetProperty(\"closeDate\", out var CdEl) ? CdEl.GetString() ?? string.Empty : string.Empty;");
        Sb.AppendLine("                    Receipts.Add(new ReceiptEntry(RType, RNum, RTotal, RClose));");
        Sb.AppendLine("                }");
        Sb.AppendLine("            }");
        Sb.AppendLine("        }");
        Sb.AppendLine("        catch (Exception Ex)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            ErrorMessage = Ex.Message;");
        Sb.AppendLine("        }");
        Sb.AppendLine("        finally");
        Sb.AppendLine("        {");
        Sb.AppendLine("            IsLoading = false;");
        Sb.AppendLine("        }");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private sealed record ReceiptEntry(string Type, long Number, decimal Total, string CloseDate);");
        Sb.AppendLine("}");
        return Sb.ToString();
    }

    private void ConvertElement(AxmlElement El, StringBuilder Sb, int Depth, List<string>? InputFields = null, List<string>? ButtonIds = null)
    {
        var Indent = new string(' ', Depth * 4);
        var Tag = MapAndroidTag(El.Tag);
        var Id = ResolveRes(El.GetAttr("id"));
        var Text = ResolveRes(El.GetAttr("text"));
        var Hint = ResolveRes(El.GetAttr("hint"));
        var Src = ResolveRes(El.GetAttr("src") ?? El.GetAttr("srcCompat"));
        var Visibility = El.GetAttr("visibility");
        var Background = El.GetAttr("background");
        var TextColor = El.GetAttr("textColor");
        var TextSize = El.GetAttr("textSize");
        var LayoutWidth = El.GetAttr("layout_width");
        var LayoutHeight = El.GetAttr("layout_height");
        var Orientation = El.GetAttr("orientation");
        var Gravity = El.GetAttr("gravity");
        var Padding = El.GetAttr("padding");
        var Margin = El.GetAttr("layout_margin");
        var Style = El.GetAttr("style");

        var CssClasses = new List<string>();
        var CssStyles = new List<string>();
        var CleanId = (string?)null;

        if (Id is not null)
        {
            CleanId = Id.Contains("/", StringComparison.Ordinal) ? Id[(Id.LastIndexOf('/') + 1)..] : Id;
            CssClasses.Add(CleanId);
        }

        if (Visibility == "gone" || Visibility == "8")
        {
            CssStyles.Add("display:none");
        }

        if (Orientation == "1" || Orientation == "vertical")
        {
            CssStyles.Add("display:flex;flex-direction:column");
        }
        else if (Orientation == "0" || Orientation == "horizontal")
        {
            CssStyles.Add("display:flex;flex-direction:row");
        }

        if (LayoutWidth == "-1" || LayoutWidth == "match_parent")
        {
            CssStyles.Add("width:100%");
        }

        if (Gravity is not null && Gravity.Contains("center", StringComparison.OrdinalIgnoreCase))
        {
            CssStyles.Add("text-align:center");
        }

        if (Tag.HtmlTag == "skip")
        {
            foreach (var Child in El.Children)
            {
                ConvertElement(Child, Sb, Depth, InputFields, ButtonIds);
            }

            return;
        }

        Sb.Append(Indent).Append('<').Append(Tag.HtmlTag);

        if (CssClasses.Count > 0)
        {
            Sb.Append(" class=\"").Append(string.Join(" ", CssClasses)).Append('"');
        }

        if (CssStyles.Count > 0)
        {
            Sb.Append(" style=\"").Append(string.Join(";", CssStyles)).Append('"');
        }

        if (Tag.HtmlTag == "input" && Hint is not null)
        {
            Sb.Append(" placeholder=\"").Append(EscapeHtml(ResolveStringRef(Hint))).Append('"');
        }

        if (Tag.HtmlTag == "input" && Tag.InputType is not null)
        {
            Sb.Append(" type=\"").Append(Tag.InputType).Append('"');
        }

        if (Tag.HtmlTag == "input" && CleanId is not null && InputFields is not null && InputFields.Contains(CleanId))
        {
            Sb.Append(" @bind=\"").Append(SanitizeIdentifier(ToPascalCase(CleanId))).Append("\" @bind:event=\"oninput\"");
        }

        if (Tag.HtmlTag == "img" && Src is not null)
        {
            var ImgName = ResolveStringRef(Src);
            if (ImgName.StartsWith("0x", StringComparison.Ordinal))
            {
                ImgName = ImgName.TrimStart('0', 'x', 'X');
            }

            Sb.Append(" src=\"img/").Append(ImgName).Append(".png\" alt=\"").Append(ImgName).Append('"');
        }

        if (Tag.HtmlTag == "button" && CleanId is not null && ButtonIds is not null && ButtonIds.Contains(CleanId))
        {
            Sb.Append(" @onclick=\"On").Append(SanitizeIdentifier(ToPascalCase(CleanId))).Append("Click\"");
        }

        if (Tag.SelfClosing)
        {
            Sb.AppendLine(" />");
            return;
        }

        Sb.Append('>');

        if (Text is not null)
        {
            Sb.Append(EscapeHtml(ResolveStringRef(Text)));
        }

        if (El.Children.Count > 0)
        {
            Sb.AppendLine();
            foreach (var Child in El.Children)
            {
                ConvertElement(Child, Sb, Depth + 1, InputFields, ButtonIds);
            }

            Sb.Append(Indent);
        }

        Sb.Append("</").Append(Tag.HtmlTag).AppendLine(">");
    }

    private void GenerateNavMenu(string OutputDir, string Namespace, List<KeyValuePair<string, AxmlDocument>> AppLayouts)
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("<nav class=\"nav-menu\">");
        Sb.AppendLine("    <a href=\"/\">Home</a>");

        var KeyScreens = new[] {
            "tap_on_phone_sell", "sell_receipt_choose_payment_system", "sell_electron_payment",
            "sell_success_with_print", "launcher", "statistics", "receipt_statuses",
            "main_settings", "company_details", "payback_positions", "inventory_list"
        };

        foreach (var Screen in KeyScreens)
        {
            var Match = AppLayouts.FirstOrDefault(Kvp => Kvp.Key.Contains(Screen, StringComparison.Ordinal));
            if (Match.Key is not null)
            {
                var Route = "/" + Match.Key.Replace("fragment_", string.Empty).Replace("toph_full_screen_", string.Empty).Replace('_', '-');
                var Label = ToPascalCase(Screen).Replace("_", " ");
                Sb.Append("    <a href=\"").Append(Route).Append("\">").Append(Label).AppendLine("</a>");
            }
        }

        Sb.AppendLine("</nav>");
        File.WriteAllText(Path.Combine(OutputDir, "Layout", "NavMenu.razor"), Sb.ToString());
    }

    private static void UpdateHomePage(string OutputDir, string Namespace, List<KeyValuePair<string, AxmlDocument>> AppLayouts)
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("@page \"/\"");
        Sb.AppendLine("@inject NavigationManager Nav");
        Sb.AppendLine("@inject HttpClient Http");
        Sb.AppendLine();
        Sb.AppendLine("@if (IsCheckingSession)");
        Sb.AppendLine("{");
        Sb.AppendLine("    <div class=\"splash-screen\"><h1>PocketPay</h1><p>Loading...</p></div>");
        Sb.AppendLine("}");
        Sb.AppendLine("else if (!IsAuthenticated)");
        Sb.AppendLine("{");
        Sb.AppendLine("    <div class=\"inline-login\">");
        Sb.AppendLine("        <div class=\"login-form\">");
        Sb.AppendLine("            <h2>PocketPay</h2>");
        Sb.AppendLine("            <p>Sign in to your merchant account</p>");
        Sb.AppendLine("            <input type=\"tel\" placeholder=\"09XX XXX XXXX\" @bind=\"PhoneNumber\" @bind:event=\"oninput\" />");
        Sb.AppendLine("            <input type=\"password\" placeholder=\"Password\" @bind=\"Password\" @bind:event=\"oninput\" />");
        Sb.AppendLine("            @if (ErrorMessage.Length > 0)");
        Sb.AppendLine("            {");
        Sb.AppendLine("                <p class=\"error\">@ErrorMessage</p>");
        Sb.AppendLine("            }");
        Sb.AppendLine("            <button @onclick=\"SubmitLogin\" disabled=\"@IsLoading\">@(IsLoading ? \"Logging in...\" : \"Login\")</button>");
        Sb.AppendLine("        </div>");
        Sb.AppendLine("    </div>");
        Sb.AppendLine("}");
        Sb.AppendLine("else");
        Sb.AppendLine("{");
        Sb.AppendLine("    <div class=\"app-shell\">");
        Sb.AppendLine("        <header class=\"dashboard-header\">");
        Sb.AppendLine("            <h1>PocketPay</h1>");
        Sb.AppendLine("            <p>@StoreName</p>");
        Sb.AppendLine("        </header>");
        Sb.AppendLine("        <div class=\"card\">");
        Sb.AppendLine("            <p>Welcome, <strong>@UserName</strong></p>");
        Sb.AppendLine("            <p>@UserRole &mdash; @Region</p>");
        Sb.AppendLine("        </div>");
        Sb.AppendLine("        <div class=\"stats-card\">");
        Sb.AppendLine("            <h3>Today</h3>");
        Sb.AppendLine("            <p>Sales: @TodaySales.ToString(\"C2\", System.Globalization.CultureInfo.GetCultureInfo(\"en-PH\"))</p>");
        Sb.AppendLine("            <p>Transactions: @TodayCount</p>");
        Sb.AppendLine("        </div>");
        Sb.AppendLine("        <div class=\"quick-actions\">");
        Sb.AppendLine("            <a class=\"quick-action-card\" href=\"/sell\"><h3>\U0001F4B5</h3><span>New Sale</span></a>");
        Sb.AppendLine("            <a class=\"quick-action-card\" href=\"/inventory-list\"><h3>\U0001F4E6</h3><span>Inventory</span></a>");
        Sb.AppendLine("            <a class=\"quick-action-card\" href=\"/statistics\"><h3>\U0001F4CA</h3><span>Statistics</span></a>");
        Sb.AppendLine("            <a class=\"quick-action-card\" href=\"/receipt-statuses\"><h3>\U0001F9FE</h3><span>Receipts</span></a>");
        Sb.AppendLine("            <a class=\"quick-action-card\" href=\"/company-details\"><h3>\U0001F3E2</h3><span>Company</span></a>");
        Sb.AppendLine("            <a class=\"quick-action-card\" href=\"/main-settings\"><h3>\u2699\uFE0F</h3><span>Settings</span></a>");
        Sb.AppendLine("        </div>");
        Sb.AppendLine("        @if (Products.Count > 0)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            <div class=\"product-preview\">");
        Sb.AppendLine("                <h3>Products</h3>");
        Sb.AppendLine("                @foreach (var P in Products)");
        Sb.AppendLine("                {");
        Sb.AppendLine("                    <div class=\"product-preview-item\"><span>@P.Name</span><span>@P.Price.ToString(\"F2\", System.Globalization.CultureInfo.InvariantCulture)</span></div>");
        Sb.AppendLine("                }");
        Sb.AppendLine("            </div>");
        Sb.AppendLine("        }");
        Sb.AppendLine("        <div class=\"device-status\">");
        Sb.AppendLine("            <span class=\"device-status-dot @(DeviceOnline ? \"online\" : \"offline\")\"></span>");
        Sb.AppendLine("            <span>@DeviceName &mdash; @(DeviceOnline ? \"Online\" : \"Offline\")</span>");
        Sb.AppendLine("        </div>");
        Sb.AppendLine("    </div>");
        Sb.AppendLine("}");
        Sb.AppendLine();
        Sb.AppendLine("@code {");
        Sb.AppendLine("    private bool IsCheckingSession { get; set; } = true;");
        Sb.AppendLine("    private bool IsAuthenticated { get; set; }");
        Sb.AppendLine("    private bool IsLoading { get; set; }");
        Sb.AppendLine("    private string PhoneNumber { get; set; } = string.Empty;");
        Sb.AppendLine("    private string Password { get; set; } = string.Empty;");
        Sb.AppendLine("    private string ErrorMessage { get; set; } = string.Empty;");
        Sb.AppendLine("    private string UserName { get; set; } = string.Empty;");
        Sb.AppendLine("    private string UserRole { get; set; } = string.Empty;");
        Sb.AppendLine("    private string Region { get; set; } = string.Empty;");
        Sb.AppendLine("    private string StoreName { get; set; } = string.Empty;");
        Sb.AppendLine("    private decimal TodaySales { get; set; }");
        Sb.AppendLine("    private int TodayCount { get; set; }");
        Sb.AppendLine("    private List<ProductItem> Products { get; set; } = new();");
        Sb.AppendLine("    private string DeviceName { get; set; } = string.Empty;");
        Sb.AppendLine("    private bool DeviceOnline { get; set; }");
        Sb.AppendLine();
        Sb.AppendLine("    protected override async Task OnInitializedAsync()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        try");
        Sb.AppendLine("        {");
        Sb.AppendLine("            var SessionResponse = await Http.PostAsJsonAsync(\"wss-proxy/get_session\", new { });");
        Sb.AppendLine("            var Session = await SessionResponse.Content.ReadFromJsonAsync<SessionResult>();");
        Sb.AppendLine("            if (Session is not null && Session.Authenticated)");
        Sb.AppendLine("            {");
        Sb.AppendLine("                IsAuthenticated = true;");
        Sb.AppendLine("                await LoadDashboardData();");
        Sb.AppendLine("            }");
        Sb.AppendLine("        }");
        Sb.AppendLine("        catch { }");
        Sb.AppendLine("        finally { IsCheckingSession = false; }");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private async Task LoadDashboardData()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        try");
        Sb.AppendLine("        {");
        Sb.AppendLine("            var CheckResponse = await Http.PostAsJsonAsync(\"wss-proxy/check-user\", new { Method = \"check_user\" });");
        Sb.AppendLine("            var CheckResult = await CheckResponse.Content.ReadFromJsonAsync<CheckUserResult>();");
        Sb.AppendLine("            if (CheckResult is not null && CheckResult.UserExists)");
        Sb.AppendLine("            {");
        Sb.AppendLine("                UserName = CheckResult.UserName ?? CheckResult.UserId ?? \"Merchant\";");
        Sb.AppendLine("                UserRole = CheckResult.Role ?? \"BUSINESS\";");
        Sb.AppendLine("                Region = CheckResult.Region ?? \"PH\";");
        Sb.AppendLine();
        Sb.AppendLine("                if (CheckResult.UserId is not null)");
        Sb.AppendLine("                {");
        Sb.AppendLine("                    var StoresResponse = await Http.GetFromJsonAsync<StoreInfo[]>($\"wss-proxy/stores?userId={CheckResult.UserId}\");");
        Sb.AppendLine("                    if (StoresResponse is not null && StoresResponse.Length > 0)");
        Sb.AppendLine("                    {");
        Sb.AppendLine("                        StoreName = StoresResponse[0].Name ?? \"My Store\";");
        Sb.AppendLine("                    }");
        Sb.AppendLine();
        Sb.AppendLine("                    var DevicesResponse = await Http.GetFromJsonAsync<DeviceInfo[]>($\"wss-proxy/devices?userId={CheckResult.UserId}\");");
        Sb.AppendLine("                    if (DevicesResponse is not null && DevicesResponse.Length > 0)");
        Sb.AppendLine("                    {");
        Sb.AppendLine("                        DeviceName = DevicesResponse[0].Name ?? \"Device\";");
        Sb.AppendLine("                        DeviceOnline = string.Equals(DevicesResponse[0].State, \"ONLINE\", StringComparison.OrdinalIgnoreCase);");
        Sb.AppendLine("                    }");
        Sb.AppendLine("                }");
        Sb.AppendLine("            }");
        Sb.AppendLine("        }");
        Sb.AppendLine("        catch { UserName = \"Merchant\"; }");
        Sb.AppendLine();
        Sb.AppendLine("        try");
        Sb.AppendLine("        {");
        Sb.AppendLine("            var DateFromMs = new DateTimeOffset(DateTime.Today).ToUnixTimeMilliseconds();");
        Sb.AppendLine("            var DateToMs = new DateTimeOffset(DateTime.Today.AddDays(1)).ToUnixTimeMilliseconds();");
        Sb.AppendLine("            var StatsPayload = new { Method = \"get_stats\", Payload = new { DateFrom = DateFromMs, DateTo = DateToMs } };");
        Sb.AppendLine("            var StatsResponse = await Http.PostAsJsonAsync(\"wss-proxy/get-stats\", StatsPayload);");
        Sb.AppendLine("            var Stats = await StatsResponse.Content.ReadFromJsonAsync<StatsResult>();");
        Sb.AppendLine("            if (Stats is not null && Stats.Success)");
        Sb.AppendLine("            {");
        Sb.AppendLine("                TodaySales = Stats.TotalSales;");
        Sb.AppendLine("                TodayCount = Stats.TotalCount;");
        Sb.AppendLine("            }");
        Sb.AppendLine("        }");
        Sb.AppendLine("        catch { }");
        Sb.AppendLine();
        Sb.AppendLine("        try");
        Sb.AppendLine("        {");
        Sb.AppendLine("            var ProdPayload = new { Method = \"get_products\" };");
        Sb.AppendLine("            var ProdResponse = await Http.PostAsJsonAsync(\"wss-proxy/get-products\", ProdPayload);");
        Sb.AppendLine("            var ProdResult = await ProdResponse.Content.ReadFromJsonAsync<ProductsResult>();");
        Sb.AppendLine("            if (ProdResult is not null && ProdResult.Success && ProdResult.Items is not null)");
        Sb.AppendLine("            {");
        Sb.AppendLine("                Products = ProdResult.Items.Take(5).ToList();");
        Sb.AppendLine("            }");
        Sb.AppendLine("        }");
        Sb.AppendLine("        catch { }");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private async Task SubmitLogin()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        ErrorMessage = string.Empty;");
        Sb.AppendLine("        if (PhoneNumber.Length < 10) { ErrorMessage = \"Please enter a valid phone number\"; return; }");
        Sb.AppendLine("        if (Password.Length == 0) { ErrorMessage = \"Please enter your password\"; return; }");
        Sb.AppendLine();
        Sb.AppendLine("        IsLoading = true;");
        Sb.AppendLine("        try");
        Sb.AppendLine("        {");
        Sb.AppendLine("            var LoginPhone = PhoneNumber.Replace(\" \", string.Empty).Replace(\"+\", string.Empty).Replace(\"-\", string.Empty);");
        Sb.AppendLine("            if (LoginPhone.StartsWith(\"0\", StringComparison.Ordinal)) LoginPhone = \"63\" + LoginPhone[1..];");
        Sb.AppendLine("            else if (!LoginPhone.StartsWith(\"63\", StringComparison.Ordinal)) LoginPhone = \"63\" + LoginPhone;");
        Sb.AppendLine();
        Sb.AppendLine("            var Payload = new { Method = \"login\", Payload = new { Phone = LoginPhone, Password = Password } };");
        Sb.AppendLine("            var Response = await Http.PostAsJsonAsync(\"wss-proxy/login\", Payload);");
        Sb.AppendLine("            var Result = await Response.Content.ReadFromJsonAsync<LoginResult>();");
        Sb.AppendLine("            if (Result is not null && Result.Success)");
        Sb.AppendLine("            {");
        Sb.AppendLine("                IsAuthenticated = true;");
        Sb.AppendLine("                await LoadDashboardData();");
        Sb.AppendLine("            }");
        Sb.AppendLine("            else");
        Sb.AppendLine("            {");
        Sb.AppendLine("                ErrorMessage = Result?.Error ?? \"Login failed\";");
        Sb.AppendLine("            }");
        Sb.AppendLine("        }");
        Sb.AppendLine("        catch (Exception Ex) { ErrorMessage = Ex.Message; }");
        Sb.AppendLine("        finally { IsLoading = false; }");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private sealed record SessionResult(bool Authenticated, bool HasToken);");
        Sb.AppendLine("    private sealed record LoginResult(bool Success, string? Token, string? Error, string? ShopUuid);");
        Sb.AppendLine("    private sealed record CheckUserResult(bool UserExists, string? UserId, string? UserName, string? Role, string? Region);");
        Sb.AppendLine("    private sealed record StoreInfo(string? Id, string? Name, string? Address);");
        Sb.AppendLine("    private sealed record DeviceInfo(string? Name, string? State);");
        Sb.AppendLine("    private sealed record StatsResult(bool Success, decimal TotalSales, int TotalCount, string? Raw, string? Error);");
        Sb.AppendLine("    private sealed record ProductItem(string Id, string Name, string Code, decimal Price);");
        Sb.AppendLine("    private sealed record ProductsResult(bool Success, List<ProductItem>? Items, string? Error);");
        Sb.AppendLine("}");

        File.WriteAllText(Path.Combine(OutputDir, "Pages", "Index.razor"), Sb.ToString());
    }

    private static AndroidHtmlTag MapAndroidTag(string AndroidTag)
    {
        var ShortTag = AndroidTag.Contains('.', StringComparison.Ordinal)
            ? AndroidTag[(AndroidTag.LastIndexOf('.') + 1)..]
            : AndroidTag;

        return ShortTag switch
        {
            "LinearLayout" or "RelativeLayout" or "FrameLayout" or "ConstraintLayout"
                or "CoordinatorLayout" or "CardView" or "MaterialCardView" or "NestedScrollView"
                or "ScrollView" or "HorizontalScrollView" or "ViewFlipper"
                => new AndroidHtmlTag("div", null, false),
            "TextView" or "AppCompatTextView" or "MaterialTextView"
                => new AndroidHtmlTag("span", null, false),
            "Button" or "AppCompatButton" or "MaterialButton"
                => new AndroidHtmlTag("button", null, false),
            "ImageView" or "AppCompatImageView" or "ShapeableImageView"
                => new AndroidHtmlTag("img", null, true),
            "ImageButton" or "FloatingActionButton" or "ExtendedFloatingActionButton"
                => new AndroidHtmlTag("button", null, false),
            "EditText" or "AppCompatEditText" or "TextInputEditText"
                => new AndroidHtmlTag("input", "text", true),
            "TextInputLayout"
                => new AndroidHtmlTag("label", null, false),
            "CheckBox" or "AppCompatCheckBox" or "MaterialCheckBox"
                => new AndroidHtmlTag("input", "checkbox", true),
            "RadioButton" or "AppCompatRadioButton"
                => new AndroidHtmlTag("input", "radio", true),
            "RadioGroup"
                => new AndroidHtmlTag("fieldset", null, false),
            "Switch" or "SwitchCompat" or "SwitchMaterial"
                => new AndroidHtmlTag("input", "checkbox", true),
            "Spinner" or "AppCompatSpinner"
                => new AndroidHtmlTag("select", null, false),
            "ProgressBar" or "ContentLoadingProgressBar"
                => new AndroidHtmlTag("progress", null, false),
            "RecyclerView"
                => new AndroidHtmlTag("div", null, false),
            "Toolbar" or "MaterialToolbar"
                => new AndroidHtmlTag("header", null, false),
            "BottomNavigationView" or "NavigationView" or "NavigationRailView"
                => new AndroidHtmlTag("nav", null, false),
            "TabLayout"
                => new AndroidHtmlTag("div", null, false),
            "ViewPager" or "ViewPager2"
                => new AndroidHtmlTag("div", null, false),
            "WebView"
                => new AndroidHtmlTag("iframe", null, false),
            "Space"
                => new AndroidHtmlTag("div", null, false),
            "View"
                => new AndroidHtmlTag("div", null, false),
            "include" or "merge" or "fragment" or "FragmentContainerView"
                => new AndroidHtmlTag("div", null, false),
            "Guideline" or "Barrier" or "Group" or "Flow"
                => new AndroidHtmlTag("skip", null, false),
            _ => new AndroidHtmlTag("div", null, false)
        };
    }

    private string? ResolveRes(string? Value)
    {
        if (Value is null)
        {
            return null;
        }

        if (Resources is not null)
        {
            if (Value.StartsWith("@ref/0x", StringComparison.Ordinal))
            {
                var Hex = Value[5..];
                if (int.TryParse(Hex.AsSpan(2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var ResId))
                {
                    return Resources.ResolveResource(ResId);
                }
            }

            if (int.TryParse(Value, CultureInfo.InvariantCulture, out var DecId) && DecId > 0x7F000000)
            {
                return Resources.ResolveResource(DecId);
            }
        }

        return Value;
    }

    private string ResolveStringRef(string Value)
    {
        if (Value.StartsWith("@ref/0x", StringComparison.Ordinal) && Resources is not null)
        {
            var HexStr = Value["@ref/".Length..];
            if (int.TryParse(HexStr.TrimStart('0', 'x', 'X'), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var ResId))
            {
                var Resolved = Resources.ResolveResource(ResId);
                if (!Resolved.StartsWith("0x", StringComparison.Ordinal))
                {
                    return Resolved;
                }
            }
        }

        if (Value.StartsWith("@ref/", StringComparison.Ordinal) || Value.StartsWith("@string/", StringComparison.Ordinal))
        {
            return Value[(Value.IndexOf('/') + 1)..];
        }

        return Value;
    }

    private static string EscapeHtml(string Value)
    {
        return Value.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("\"", "&quot;");
    }

    private static string ToPascalCase(string Value)
    {
        var Parts = Value.Split('_', '-');
        var Sb = new StringBuilder();
        foreach (var Part in Parts)
        {
            if (Part.Length > 0)
            {
                Sb.Append(char.ToUpperInvariant(Part[0]));
                if (Part.Length > 1)
                {
                    Sb.Append(Part[1..]);
                }
            }
        }

        return Sb.ToString();
    }

    private static string SanitizeIdentifier(string Value)
    {
        if (Value.Length > 0 && char.IsDigit(Value[0]))
        {
            return "Field" + Value;
        }

        return Value;
    }

    private static string DetectImageFormat(byte[] Data)
    {
        if (Data.Length > 3 && Data[0] == 0x89 && Data[1] == 0x50)
        {
            return ".png";
        }

        if (Data.Length > 2 && Data[0] == 0xFF && Data[1] == 0xD8)
        {
            return ".jpg";
        }

        if (Data.Length > 4 && Data[0] == 0x52 && Data[1] == 0x49)
        {
            return ".webp";
        }

        return ".png";
    }
}

public sealed record AndroidHtmlTag(string HtmlTag, string? InputType, bool SelfClosing);
