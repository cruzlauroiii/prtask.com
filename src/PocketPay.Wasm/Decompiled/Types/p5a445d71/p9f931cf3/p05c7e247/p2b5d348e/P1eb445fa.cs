namespace WillowMaze.Wasm.Decompiled;

public class P1eb445fa
{
    private static p87d487f6 F724a00e3;
    private static p87d487f6 F73659c7f;

    public static int M5b936250(string P0, Stream P1)
    {
        // call: p87d487f6.decode
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p1eb445fa.f724a00e3
        return 0;
    }

    public static int M5b936250(byte[] P0, int P1, int P2, Stream P3)
    {
        // str: "unable to decode base64 data: "
        // call: Exception.getMessage
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: p87d487f6.decode
        // call: pe774851d.<init>
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p1eb445fa.f724a00e3
        // type: StringBuilder
        // type: pe774851d
        return 0;
    }

    public static byte[] M5b936250(string P0)
    {
        // str: "unable to decode base64 string: "
        // call: StringBuilder.<init>
        // call: Exception.getMessage
        // call: pe774851d.<init>
        // call: MemoryStream.<init>
        // call: p87d487f6.decode
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: string.length
        // call: MemoryStream.toByteArray
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p1eb445fa.f724a00e3
        // type: pe774851d
        // type: MemoryStream
        // type: StringBuilder
        return default!;
    }

    public static byte[] M5b936250(byte[] P0)
    {
        // str: "unable to decode base64 data: "
        // call: Exception.getMessage
        // call: MemoryStream.<init>
        // call: p87d487f6.decode
        // call: StringBuilder.<init>
        // call: pe774851d.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: MemoryStream.toByteArray
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p1eb445fa.f724a00e3
        // type: MemoryStream
        // type: pe774851d
        // type: StringBuilder
        return default!;
    }

    public static string M8d6ea934(byte[] P0)
    {
        // call: p1eb445fa.m8d6ea934
        return string.Empty;
    }

    public static string M8d6ea934(byte[] P0, int P1, int P2)
    {
        // call: p1eb445fa.m97a57645
        // call: p89be9433.m89e75c46
        return string.Empty;
    }

    public static int M97a57645(byte[] P0, int P1, int P2, Stream P3)
    {
        // call: p87d487f6.encode
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p1eb445fa.f724a00e3
        return 0;
    }

    public static int M97a57645(byte[] P0, Stream P1)
    {
        // call: p87d487f6.encode
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p1eb445fa.f724a00e3
        return 0;
    }

    public static byte[] M97a57645(byte[] P0)
    {
        // call: p1eb445fa.m97a57645
        return default!;
    }

    public static byte[] M97a57645(byte[] P0, int P1, int P2)
    {
        // str: "exception encoding base64 string: "
        // call: Exception.getMessage
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: p87d487f6.getEncodedLength
        // call: MemoryStream.<init>
        // call: p87d487f6.encode
        // call: p1f246bea.<init>
        // call: MemoryStream.toByteArray
        // call: StringBuilder.append
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p1eb445fa.f724a00e3
        // type: StringBuilder
        // type: p1f246bea
        // type: MemoryStream
        return default!;
    }

}
