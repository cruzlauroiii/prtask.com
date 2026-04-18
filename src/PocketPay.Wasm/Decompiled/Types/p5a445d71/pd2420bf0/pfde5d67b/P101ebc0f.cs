namespace WillowMaze.Wasm.Decompiled;

public class P101ebc0f
{
    private static ThreadLocal F0b6463de;
    private static string[] F383be30e;
    private static int F7aaa761f;
    private static int F7ceff321;
    private static string[] Fb70cdb87;
    private static string[] Fb968e74e;
    private static ThreadLocal Fc968f610;
    private static ThreadLocal Fdc985312;

    public static bool M13b5bfe9(string P0, string[] P1)
    {
        // call: string.equals
        return false;
    }

    public static bool M30f4de7b(int P0)
    {
        return false;
    }

    public static bool M59d0cd68(string P0, string[] P1)
    {
        // call: Arrays.binarySearch
        return false;
    }

    public static string M731b886d(ICollection<object> P0, string P1)
    {
        // call: p101ebc0f.m731b886d
        // call: ICollection<object>.iterator
        return string.Empty;
    }

    public static string M731b886d(IEnumerator<object> P0, string P1)
    {
        // str: ""
        // call: IEnumerator<object>.next
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: IEnumerator<object>.hasNext
        // call: StringBuilder.<init>
        // call: object.toString
        // type: StringBuilder
        return string.Empty;
    }

    public static string M731b886d(string[] P0, string P1)
    {
        // call: p101ebc0f.m731b886d
        // call: Arrays.asList
        return string.Empty;
    }

    public static StringBuilder M75031929()
    {
        // call: StringBuilder.delete
        // call: ThreadLocal.get
        // call: ThreadLocal.set
        // call: StringBuilder.length
        // call: StringBuilder.<init>
        // field: p5a445d71.pd2420bf0.pfde5d67b.p101ebc0f.fdc985312
        // type: StringBuilder
        return default!;
    }

    public static string M785e254f(string P0, string P1)
    {
        // str: ""
        // call: Uri.<init>
        // call: p101ebc0f.m785e254f
        // call: Uri.toExternalForm
        // type: Uri
        return string.Empty;
    }

    public static Uri M785e254f(Uri P0, string P1)
    {
        // str: "/"
        // str: "?"
        // call: string.indexOf
        // call: StringBuilder.toString
        // call: Uri.getProtocol
        // call: StringBuilder.<init>
        // call: Uri.getFile
        // call: StringBuilder.append
        // call: Uri.<init>
        // call: Uri.getHost
        // call: Uri.getPort
        // call: string.startsWith
        // call: Uri.getPath
        // type: StringBuilder
        // type: Uri
        return default!;
    }

    public static void M7a9c7943(StringBuilder P0, string P1, bool P2)
    {
        // call: p101ebc0f.m30f4de7b
        // call: string.codePointAt
        // call: StringBuilder.append
        // call: p101ebc0f.me2953c5f
        // call: string.length
        // call: char.charCount
        // call: StringBuilder.appendCodePoint
    }

    public static bool M7b5edca9(string P0)
    {
        // call: string.length
        // call: char.isDigit
        // call: string.codePointAt
        return false;
    }

    public static bool Ma1c77c5a(string P0)
    {
        // call: string.length
        // call: string.codePointAt
        // call: p101ebc0f.mfdbe2c32
        return false;
    }

    public static string Mb70cdb87(int P0)
    {
        // str: "width must be > 0"
        // call: IllegalArgumentException.<init>
        // call: string.valueOf
        // field: p5a445d71.pd2420bf0.pfde5d67b.p101ebc0f.fb70cdb87
        // type: IllegalArgumentException
        return string.Empty;
    }

    public static string Mbb11ede4(string P0)
    {
        // call: p101ebc0f.m7a9c7943
        // call: StringBuilder.toString
        // call: p101ebc0f.m75031929
        return string.Empty;
    }

    public static bool Me2953c5f(int P0)
    {
        // call: char.getType
        return false;
    }

    public static bool Mfdbe2c32(int P0)
    {
        return false;
    }

}
