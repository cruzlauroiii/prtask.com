using PrTask.Cdp;
namespace PrTask.E2E;

/// <summary>
/// Helper methods that bridge between Playwright-style API usage and native PrTask.Cdp.
/// All methods use CdpPage (which wraps Runtime.evaluate, DOM.querySelector, etc.).
/// </summary>
internal static class CdpHelpers
{
    /// <summary>
    /// Gets the text content of the first element matching the selector via JS.
    /// Equivalent to Playwright's Page.TextContentAsync(selector) or Locator("sel").TextContentAsync().
    /// </summary>
    public static async Task<string> GetTextContentAsync(CdpPage Page, string Selector)
    {
        var Result = await Page.EvaluateAsync(
            $"document.querySelector('{EscapeJs(Selector)}')?.textContent ?? ''");
        return Result?.ToString() ?? string.Empty;
    }

    /// <summary>
    /// Gets an attribute value from the first element matching the selector.
    /// Equivalent to Playwright's Locator("sel").GetAttributeAsync(attr).
    /// </summary>
    public static async Task<string> GetAttributeAsync(CdpPage Page, string Selector, string Attribute)
    {
        var Result = await Page.EvaluateAsync(
            $"document.querySelector('{EscapeJs(Selector)}')?.getAttribute('{EscapeJs(Attribute)}') ?? ''");
        return Result?.ToString() ?? string.Empty;
    }

    /// <summary>
    /// Gets the page title via document.title.
    /// Equivalent to Playwright's Page.TitleAsync().
    /// </summary>
    public static async Task<string> GetTitleAsync(CdpPage Page)
    {
        var Result = await Page.EvaluateAsync("document.title");
        return Result?.ToString() ?? string.Empty;
    }

    /// <summary>
    /// Gets the current URL via JS.
    /// Equivalent to Playwright's Page.Url property.
    /// </summary>
    public static async Task<string> GetUrlAsync(CdpPage Page)
    {
        var Result = await Page.EvaluateAsync("window.location.href");
        return Result?.ToString() ?? string.Empty;
    }

    /// <summary>
    /// Counts elements matching the selector.
    /// Equivalent to Playwright's Locator("sel").CountAsync().
    /// </summary>
    public static async Task<int> CountAsync(CdpPage Page, string Selector)
    {
        var Nodes = await Page.QuerySelectorAllAsync(Selector);
        return Nodes.Length;
    }

    /// <summary>
    /// Waits for a selector to appear in the DOM (polling).
    /// Equivalent to Playwright's Page.WaitForSelectorAsync(selector, options).
    /// </summary>
    public static async Task WaitForSelectorAsync(CdpPage Page, string Selector, int TimeoutMs = 30000)
    {
        var Deadline = DateTime.UtcNow.AddMilliseconds(TimeoutMs);
        while (DateTime.UtcNow < Deadline)
        {
            var Nodes = await Page.QuerySelectorAllAsync(Selector);
            if (Nodes.Length > 0)
            {
                return;
            }
            await Task.Delay(250);
        }
    }

    /// <summary>
    /// Waits for a JS function to return true (polling).
    /// Equivalent to Playwright's Page.WaitForFunctionAsync(expression).
    /// </summary>
    public static async Task WaitForFunctionAsync(CdpPage Page, string Expression, int TimeoutMs = 30000)
    {
        var Deadline = DateTime.UtcNow.AddMilliseconds(TimeoutMs);
        while (DateTime.UtcNow < Deadline)
        {
            try
            {
                var Result = await Page.EvaluateAsync(Expression);
                if (Result is true or "true" or "True")
                {
                    return;
                }
            }
            catch
            {
                // Evaluation may fail while page is loading
            }
            await Task.Delay(250);
        }
    }

    /// <summary>
    /// Clicks the first element matching the selector by evaluating its bounding rect and dispatching click.
    /// Equivalent to Playwright's Locator("sel").ClickAsync().
    /// </summary>
    public static async Task ClickSelectorAsync(CdpPage Page, string Selector)
    {
        var Result = await Page.EvaluateAsync(
            $"(() => {{ var El = document.querySelector('{EscapeJs(Selector)}'); if (!El) return null; var R = El.getBoundingClientRect(); return {{ X: Math.floor(R.x + R.width/2), Y: Math.floor(R.y + R.height/2) }}; }})()");
        if (Result is string Json && Json.Contains("X"))
        {
            var Doc = System.Text.Json.JsonDocument.Parse(Json);
            var X = Doc.RootElement.GetProperty("X").GetInt32();
            var Y = Doc.RootElement.GetProperty("Y").GetInt32();
            await Page.ClickAsync(X, Y);
        }
        else
        {
            // Fallback: use JS click
            await Page.EvaluateAsync(
                $"document.querySelector('{EscapeJs(Selector)}')?.click()");
        }
    }

    /// <summary>
    /// Fills an input/textarea field by clearing and setting its value.
    /// Equivalent to Playwright's Locator("sel").FillAsync(value).
    /// </summary>
    public static async Task FillFieldAsync(CdpPage Page, string Selector, string Value)
    {
        var EscapedValue = EscapeJs(Value);
        await Page.EvaluateAsync(
            $"(() => {{ var El = document.querySelector('{EscapeJs(Selector)}'); if (!El) return; El.value = '{EscapedValue}'; El.dispatchEvent(new Event('input', {{ bubbles: true }})); El.dispatchEvent(new Event('change', {{ bubbles: true }})); }})()");
    }

    /// <summary>
    /// Selects an option in a select element by value.
    /// Equivalent to Playwright's Locator("sel").SelectOptionAsync(value).
    /// </summary>
    public static async Task SelectOptionAsync(CdpPage Page, string Selector, string Value)
    {
        var EscapedValue = EscapeJs(Value);
        await Page.EvaluateAsync(
            $"(() => {{ var El = document.querySelector('{EscapeJs(Selector)}'); if (!El) return; El.value = '{EscapedValue}'; El.dispatchEvent(new Event('change', {{ bubbles: true }})); }})()");
    }

    /// <summary>
    /// Gets the input value of a form element.
    /// Equivalent to Playwright's Locator("sel").InputValueAsync().
    /// </summary>
    public static async Task<string> GetInputValueAsync(CdpPage Page, string Selector)
    {
        var Result = await Page.EvaluateAsync(
            $"document.querySelector('{EscapeJs(Selector)}')?.value ?? ''");
        return Result?.ToString() ?? string.Empty;
    }

    /// <summary>
    /// Gets all text contents from elements matching the selector.
    /// Equivalent to Playwright's Locator("sel").AllTextContentsAsync().
    /// </summary>
    public static async Task<string[]> AllTextContentsAsync(CdpPage Page, string Selector)
    {
        var Result = await Page.EvaluateAsync(
            $"JSON.stringify([...document.querySelectorAll('{EscapeJs(Selector)}')].map(el => el.textContent ?? ''))");
        if (Result is string Json)
        {
            return System.Text.Json.JsonSerializer.Deserialize<string[]>(Json) ?? [];
        }
        return [];
    }

    /// <summary>
    /// Checks if an element is visible (exists and has non-zero bounding rect).
    /// Equivalent to Playwright's Locator("sel").IsVisibleAsync().
    /// </summary>
    public static async Task<bool> IsVisibleAsync(CdpPage Page, string Selector)
    {
        var Result = await Page.EvaluateAsync(
            $"(() => {{ var El = document.querySelector('{EscapeJs(Selector)}'); if (!El) return false; var R = El.getBoundingClientRect(); return R.width > 0 && R.height > 0; }})()");
        return Result is true or "true" or "True";
    }

    /// <summary>
    /// Navigates to URL and waits for load. Returns the current page URL after navigation.
    /// Equivalent to Playwright's Page.GotoAsync(url, options).
    /// </summary>
    public static async Task<string> NavigateAsync(CdpPage Page, string Url, int TimeoutMs = 30000)
    {
        await Page.NavigateAsync(Url);
        try
        {
            using var Cts = new CancellationTokenSource(TimeoutMs);
            await Page.WaitForLoadAsync(Cts.Token);
        }
        catch (OperationCanceledException) { }
        catch (CdpTimeoutException) { }
        return await GetUrlAsync(Page);
    }

    /// <summary>
    /// Reloads the page by evaluating location.reload().
    /// Equivalent to Playwright's Page.ReloadAsync().
    /// </summary>
    public static async Task ReloadAsync(CdpPage Page, int TimeoutMs = 15000)
    {
        await Page.EvaluateAsync("location.reload()");
        await Task.Delay(500);
        try
        {
            using var Cts = new CancellationTokenSource(TimeoutMs);
            await Page.WaitForLoadAsync(Cts.Token);
        }
        catch (OperationCanceledException) { }
        catch (CdpTimeoutException) { }
    }

    /// <summary>
    /// Takes a screenshot and saves to the specified file path.
    /// Equivalent to Playwright's Page.ScreenshotAsync(options).
    /// </summary>
    public static async Task ScreenshotAsync(CdpPage Page, string FilePath)
    {
        Directory.CreateDirectory(Path.GetDirectoryName(FilePath)!);
        var Bytes = await Page.CaptureScreenshotAsync();
        await File.WriteAllBytesAsync(FilePath, Bytes);
    }

    /// <summary>
    /// Evaluates a JS expression and returns the result as the specified type.
    /// Equivalent to Playwright's Page.EvaluateAsync{T}(expression).
    /// </summary>
    public static async Task<T> EvaluateAsync<T>(CdpPage Page, string Expression)
    {
        var Result = await Page.EvaluateAsync(Expression);
        if (Result is null)
        {
            return default!;
        }
        if (typeof(T) == typeof(string))
        {
            return (T)(object)(Result.ToString() ?? string.Empty);
        }
        if (typeof(T) == typeof(bool))
        {
            if (Result is bool B) return (T)(object)B;
            return (T)(object)(Result.ToString()?.Equals("true", StringComparison.OrdinalIgnoreCase) == true);
        }
        if (typeof(T) == typeof(int))
        {
            if (Result is double D) return (T)(object)(int)D;
            if (int.TryParse(Result.ToString(), out var I)) return (T)(object)I;
            return default!;
        }
        if (typeof(T) == typeof(double))
        {
            if (Result is double D) return (T)(object)D;
            if (double.TryParse(Result.ToString(), out var D2)) return (T)(object)D2;
            return default!;
        }
        if (typeof(T) == typeof(string[]))
        {
            var Json = Result.ToString() ?? "[]";
            return (T)(object)(System.Text.Json.JsonSerializer.Deserialize<string[]>(Json) ?? []);
        }
        if (typeof(T) == typeof(System.Text.Json.JsonElement))
        {
            var Json = Result.ToString() ?? "{}";
            using var Doc = System.Text.Json.JsonDocument.Parse(Json);
            return (T)(object)Doc.RootElement.Clone();
        }
        return default!;
    }

    /// <summary>
    /// Evaluates a JS expression with an argument, passing it as a string parameter.
    /// Equivalent to Playwright's Page.EvaluateAsync(expression, arg).
    /// </summary>
    public static async Task<object?> EvaluateWithArgAsync(CdpPage Page, string Expression, string Arg)
    {
        // Wrap the expression to pass the argument
        var Wrapped = $"(({Expression})({System.Text.Json.JsonSerializer.Serialize(Arg)}))";
        return await Page.EvaluateAsync(Wrapped);
    }

    /// <summary>
    /// Emulates network offline/online via Network.emulateNetworkConditions.
    /// Equivalent to Playwright's BrowserContext.SetOfflineAsync(offline).
    /// </summary>
    public static async Task SetOfflineAsync(CdpPage Page, bool Offline)
    {
        await CdpNetwork.EmulateNetworkConditionsAsync(
            GetClient(Page), Page.SessionId, Offline, 0, -1, -1);
    }

    /// <summary>
    /// Scrolls an element into view.
    /// Equivalent to Playwright's Locator("sel").ScrollIntoViewIfNeededAsync().
    /// </summary>
    public static async Task ScrollIntoViewAsync(CdpPage Page, string Selector)
    {
        await Page.EvaluateAsync(
            $"document.querySelector('{EscapeJs(Selector)}')?.scrollIntoView({{ block: 'center' }})");
    }

    /// <summary>
    /// Attaches a console error listener via Runtime.consoleAPICalled events.
    /// </summary>
    public static void AttachConsoleErrorListener(CdpPage Page, CdpClient Client, Action<string> OnError, Action<string> OnPageError)
    {
        CdpConsole.OnRuntimeConsoleApiCalled(Client, Call =>
        {
            if (Call.Type == "error")
            {
                var Text = string.Join(" ", Call.Args);
                OnError(Text);
            }
        });
        CdpConsole.OnRuntimeExceptionThrown(Client, Ex =>
        {
            OnPageError(Ex.Text);
        });
    }

    private static CdpClient GetClient(CdpPage Page)
    {
        // Access the CdpClient through the browser transport
        // CdpPage uses Client internally; we use reflection since it's internal
        var Field = typeof(CdpPage).GetField("Client", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        return (CdpClient)(Field?.GetValue(Page) ?? throw new InvalidOperationException("Cannot access CdpClient from CdpPage"));
    }

    /// <summary>
    /// Gets the CdpClient from a CdpPage for direct CDP protocol access.
    /// </summary>
    public static CdpClient GetTransport(CdpPage Page) => GetClient(Page);

    private static string EscapeJs(string Value) =>
        Value.Replace("\\", "\\\\").Replace("'", "\\'").Replace("\n", "\\n").Replace("\r", "\\r");
}
