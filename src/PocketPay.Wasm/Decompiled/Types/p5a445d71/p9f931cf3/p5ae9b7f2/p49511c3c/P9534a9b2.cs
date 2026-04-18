namespace WillowMaze.Wasm.Decompiled;

public class P9534a9b2
{
    private static string F00356fe2;
    private static HashSet<object> F12e3bbde;
    private static byte[] F1abfd274;
    private static byte[] F1b949f2c;
    private static byte[] F3c2d8f3a;
    private static HashSet<object> F448b2638;
    private static byte[] F4e869004;
    private static string F75098dc1;
    private static byte[] F89181dae;
    private static byte[] Fa66627c4;
    private static byte[] Faf423a2e;
    private static HashSet<object> Fbe42043d;
    private static HashSet<object> Fc398be1c;
    private static string Fd1a5dee0;
    private static string Fd569f92e;
    private static byte[] Fee195d61;
    private static HashSet<object> Ff4893986;

    public static string M15117b28(string P0, byte[] P1, byte[] P2, int P3)
    {
        // str: "Password required."
        // call: IllegalArgumentException.<init>
        // call: p9534a9b2.m4253860e
        // call: pff43b8de.md329fd77
        // type: IllegalArgumentException
        return string.Empty;
    }

    public static string M15117b28(string P0, char[] P1, byte[] P2, int P3)
    {
        // str: "Password required."
        // call: p9534a9b2.m4253860e
        // call: p89be9433.m48fbf2cf
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
        return string.Empty;
    }

    public static string M15117b28(byte[] P0, byte[] P1, int P2)
    {
        // str: "a5bc1a18ee2b96d01272ebad17bd6de3c9db94801cf432c53e30556ee0c1"
        // call: DecryptString.decryptString
        // call: p9534a9b2.m15117b28
        return string.Empty;
    }

    public static string M15117b28(char[] P0, byte[] P1, int P2)
    {
        // str: "e6eed81c633166697bdf215165764c5b896497e8d495e833a4d1037e5af9"
        // call: DecryptString.decryptString
        // call: p9534a9b2.m15117b28
        return string.Empty;
    }

    private static string M2883890f(string P0, byte[] P1, byte[] P2, int P3)
    {
        // str: "30b15dd9e47e4d433480ed2d33404d7db9371ea1f1307789df5ecc8ee9"
        // str: " is not accepted by this implementation."
        // str: "Version "
        // call: StringBuilder.append
        // call: DecryptString.decryptString
        // call: p9534a9b2.m366b1322
        // call: HashSet<object>.contains
        // call: p251df3ad.m15117b28
        // call: int.toString
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p9534a9b2.ff4893986
        // type: StringBuilder
        // type: IllegalArgumentException
        return string.Empty;
    }

    private static void M366b1322(StringBuilder P0, byte[] P1)
    {
        // str: "Invalid length: "
        // str: ", 24 for key or 16 for salt expected"
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: p96068848.<init>
        // call: StringBuilder.length
        // call: System.arraycopy
        // call: StringBuilder.setLength
        // call: StringBuilder.toString
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p9534a9b2.f4e869004
        // type: p96068848
        // type: StringBuilder
    }

    private static string M4253860e(string P0, byte[] P1, byte[] P2, int P3)
    {
        // str: "Salt required."
        // str: "Version "
        // str: " is not accepted by this implementation."
        // str: "Invalid cost factor."
        // str: "16 byte salt required: "
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: IllegalArgumentException.<init>
        // call: p96068848.<init>
        // call: HashSet<object>.contains
        // call: pff43b8de.ma552c747
        // call: StringBuilder.toString
        // call: System.arraycopy
        // call: p9534a9b2.m2883890f
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p9534a9b2.ff4893986
        // type: p96068848
        // type: IllegalArgumentException
        // type: StringBuilder
        return string.Empty;
    }

    private static byte[] M616b7d10(string P0)
    {
        // str: "Salt string contains invalid character: "
        // str: " , 22 required."
        // str: "Invalid base64 salt length: "
        // call: StringBuilder.<init>
        // call: MemoryStream.write
        // call: StringBuilder.toString
        // call: IllegalArgumentException.<init>
        // call: System.arraycopy
        // call: StringBuilder.append
        // call: string.toCharArray
        // call: MemoryStream.<init>
        // call: MemoryStream.toByteArray
        // call: p96068848.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p9534a9b2.fee195d61
        // type: p96068848
        // type: StringBuilder
        // type: IllegalArgumentException
        // type: MemoryStream
        return default!;
    }

    public static bool Md2b73efd(string P0, byte[] P1)
    {
        // str: "Missing password."
        // call: IllegalArgumentException.<init>
        // call: p9534a9b2.mf95f77ad
        // call: pff43b8de.md329fd77
        // type: IllegalArgumentException
        return false;
    }

    public static bool Md2b73efd(string P0, char[] P1)
    {
        // str: "Missing password."
        // call: p89be9433.m48fbf2cf
        // call: p9534a9b2.mf95f77ad
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
        return false;
    }

    private static bool Mf95f77ad(string P0, byte[] P1)
    {
        // str: "Bcrypt String length: "
        // str: "not a Bcrypt string"
        // str: ", 60 required."
        // str: ", 4 < cost < 31 expected."
        // str: "' is not supported by this implementation"
        // str: "Invalid cost factor: "
        // str: "Invalid Bcrypt String format."
        // str: "Bcrypt version '"
        // str: "Missing bcryptString."
        // call: StringBuilder.toString
        // call: string.charAt
        // call: StringBuilder.append
        // call: IllegalArgumentException.<init>
        // call: string.length
        // call: string.lastIndexOf
        // call: string.substring
        // call: int.parseInt
        // call: p9534a9b2.m616b7d10
        // call: StringBuilder.<init>
        // call: p9534a9b2.m4253860e
        // call: p89be9433.m66e765de
        // call: HashSet<object>.contains
        // call: p96068848.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p9534a9b2.ff4893986
        // type: IllegalArgumentException
        // type: StringBuilder
        // type: p96068848
        return false;
    }

}
