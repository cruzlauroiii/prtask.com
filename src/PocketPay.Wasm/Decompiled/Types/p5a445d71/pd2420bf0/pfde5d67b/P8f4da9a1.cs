namespace WillowMaze.Wasm.Decompiled;

public class P8f4da9a1
{
    private static char[] F08b1b2f3;
    private static System.Text.RegularExpressions.Regex F0fd69eca;
    private static int F2380df7b;
    private static int F25256fb2;
    private static System.Text.RegularExpressions.Regex F349016b4;
    private static char[] F468df2ee;
    private static int F497d890d;
    private static int F58d05a54;
    private static int F6d8a4783;
    private static string F7c218562;
    private static char[] F89723e61;
    private static char[] F8a4dfc71;
    private static int F8fb36a71;
    private static string F9743c559;
    private static string Fb7b3fbec;
    private static System.Text.RegularExpressions.Regex Fc3fbd713;
    private static int Fcdee5967;
    private static System.Text.RegularExpressions.Regex Fd9e038b5;
    private static System.Text.RegularExpressions.Regex Fe07f17b5;
    private static int Ff6a3e5a3;
    private static string Ffe6aa19a;

    private static byte[] M1478700e()
    {
        // call: byte[].allocate
        return default!;
    }

    private static byte[] M33919f21(Stream P0)
    {
        // call: p8f4da9a1.m33919f21
        return default!;
    }

    public static byte[] M33919f21(Stream P0, int P1)
    {
        // str: "maxSize must be 0 (unlimited) or larger"
        // call: p4377c794.readToByteBuffer
        // call: p4377c794.mccfc59a5
        // call: pad3d06d0.mda0c5fd7
        return default!;
    }

    private static p8f4da9a1$p7e7660e1 M3955ee3b(byte[] P0)
    {
        // str: "UTF-32"
        // str: "463238a7ff3a401be417e45f7aff7cba55cab5dc92d22c390a0127c0057a2513af"
        // str: "UTF-16"
        // call: p8f4da9a1$p7e7660e1.<init>
        // call: Buffer.mark
        // call: DecryptString.decryptString
        // call: Buffer.rewind
        // call: byte[].remaining
        // call: byte[].get
        // type: p8f4da9a1$p7e7660e1
        return default!;
    }

    private static p09453598 M585bd234(Stream P0, string P1, string P2, p9a83ab0d P3)
    {
        // str: "xml"
        // str: ""
        // str: "meta[http-equiv=content-type], meta[charset]"
        // str: "http-equiv"
        // str: "Must set charset arg to character set of file to parse. Set to null to attempt to detect from HTML"
        // str: "[\"']"
        // str: "charset"
        // str: "content"
        // str: "750dcfa830256121215bc5d28f1d1626f04f0c223125e180a60d67d897d197fdd4"
        // str: "0fc82758d3cd088fdbc1208a04c022f8dffcfce9454cf1d82e680f032cf61c0a8c08930b"
        // call: StreamReader.<init>
        // call: Stream.close
        // call: p4377c794.mccfc59a5
        // call: p231afe47.attr
        // call: p09453598.childNode
        // call: p8f4da9a1.m3955ee3b
        // call: IEnumerator<object>.next
        // call: p09453598$p98e1d1af.charset
        // call: Stream.reset
        // call: string.replaceAll
        // call: p231afe47.hasAttr
        // call: IEnumerator<object>.hasNext
        // call: DecryptString.decryptString
        // call: p09453598.<init>
        // call: Stream.read
        // call: string.trim
        // call: p8f4da9a1.m991540fa
        // call: string.equals
        // call: System.Text.Encoding.decode
        // call: p9a83ab0d.parseInput
        // type: p09453598
        // type: StreamReader
        // type: StreamReader
        return default!;
    }

    private static string M8067f055()
    {
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: Random.<init>
        // call: Random.nextInt
        // field: p5a445d71.pd2420bf0.pfde5d67b.p8f4da9a1.f08b1b2f3
        // type: Random
        // type: StringBuilder
        return string.Empty;
    }

    private static string M991540fa(string P0)
    {
        // str: ""
        // str: "charset="
        // call: System.Text.RegularExpressions.Regex.matcher
        // call: string.trim
        // call: string.replace
        // call: Matcher.find
        // call: p8f4da9a1.mc6f073ae
        // call: Matcher.group
        // field: p5a445d71.pd2420bf0.pfde5d67b.p8f4da9a1.fd9e038b5
        return string.Empty;
    }

    private static void Mbcaca301(Stream P0, Stream P1)
    {
        // call: Stream.read
        // call: Stream.write
    }

    private static byte[] Mc009f453(string P0)
    {
        // str: "r"
        // call: RandomAccessFile.close
        // call: RandomAccessFile.<init>
        // call: RandomAccessFile.length
        // call: RandomAccessFile.readFully
        // call: byte[].wrap
        // type: RandomAccessFile
        return default!;
    }

    private static string Mc6f073ae(string P0)
    {
        // str: "[\"']"
        // str: ""
        // call: string.trim
        // call: string.length
        // call: string.replaceAll
        // call: System.Text.Encoding.isSupported
        // call: string.toUpperCase
        // field: java.util.Locale.ENGLISH
        return string.Empty;
    }

    public static p09453598 Mec4d1eb3(string P0, string P1, string P2)
    {
        // call: p9a83ab0d.mde158143
        // call: FileInputStream.<init>
        // call: p8f4da9a1.m585bd234
        // type: FileInputStream
        return default!;
    }

    public static p09453598 Mec4d1eb3(Stream P0, string P1, string P2)
    {
        // call: p8f4da9a1.m585bd234
        // call: p9a83ab0d.mde158143
        return default!;
    }

    public static p09453598 Mec4d1eb3(Stream P0, string P1, string P2, p9a83ab0d P3)
    {
        // call: p8f4da9a1.m585bd234
        return default!;
    }

}
