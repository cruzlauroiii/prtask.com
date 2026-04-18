namespace WillowMaze.Wasm.Decompiled;

public class LibraryInformation
{
    private static LibraryInformation C;
    private static ConfigurationInterface E$35932c37;
    private string A;
    private string B;
    private string D;
    private string F;
    private string G;
    private string H;
    private string I;
    private string J;

    private string A()
    {
        // str: ""
        // str: ", 238"
        // str: ", 239"
        // str: "c"
        // str: "h"
        // str: "f"
        // call: Type.getField
        // call: Exception.getCause
        // call: string.concat
        // call: Field.get
        // call: q.b
        // call: Type.getMethod
        // call: Method.invoke
        // call: bool.booleanValue
        // field: com.mastercard.terminalsdk.objects.LibraryInformation.e$35932c37
        return string.Empty;
    }

    private string D()
    {
        // str: "j"
        // str: "\n    Magstripe\n    M/Chip QR Version     : "
        // str: "c"
        // str: "\n    Contactless\n        Reader Version    : "
        // str: "\n        C2 Kernel Version : "
        // str: "\n    Contact\n        EMV Version       : "
        // call: Exception.getCause
        // call: StringBuilder.append
        // call: q.b
        // call: Type.getField
        // call: LibraryInformation.a
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: Field.get
        // call: Type.getMethod
        // call: Method.invoke
        // call: bool.booleanValue
        // field: com.mastercard.terminalsdk.objects.LibraryInformation.e$35932c37
        // field: com.mastercard.terminalsdk.objects.LibraryInformation.b
        // field: com.mastercard.terminalsdk.objects.LibraryInformation.j
        // field: com.mastercard.terminalsdk.objects.LibraryInformation.h
        // field: com.mastercard.terminalsdk.objects.LibraryInformation.i
        // type: StringBuilder
        return string.Empty;
    }

    public static LibraryInformation GetInstance()
    {
        // call: LibraryInformation.<init>
        // call: TerminalSdk.getConfiguration
        // call: TerminalSdk.getInstance
        // field: com.mastercard.terminalsdk.objects.LibraryInformation.c
        // field: com.mastercard.terminalsdk.objects.LibraryInformation.e$35932c37
        // type: LibraryInformation
        return default!;
    }

    public void RefreshLibraryInformation()
    {
        // str: "d"
        // str: "h"
        // str: "b"
        // str: "None"
        // call: q.b
        // call: Type.getMethod
        // call: Method.invoke
        // call: Exception.getCause
        // call: CardCommunicationProvider.getDescription
        // field: com.mastercard.terminalsdk.objects.LibraryInformation.f
        // field: com.mastercard.terminalsdk.objects.LibraryInformation.e$35932c37
        // field: com.mastercard.terminalsdk.objects.LibraryInformation.g
    }

    public string ToString()
    {
        // str: "\n"
        // str: "\nSupported functionality: "
        // str: "\nReader Profile in use: "
        // str: "\nActive Card Communication Channel: "
        // str: "\nBuild Info: "
        // str: "\nTerminal SDK Version: "
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: LibraryInformation.d
        // field: com.mastercard.terminalsdk.objects.LibraryInformation.g
        // field: com.mastercard.terminalsdk.objects.LibraryInformation.d
        // field: com.mastercard.terminalsdk.objects.LibraryInformation.a
        // field: com.mastercard.terminalsdk.objects.LibraryInformation.f
        // type: StringBuilder
        return string.Empty;
    }

}
