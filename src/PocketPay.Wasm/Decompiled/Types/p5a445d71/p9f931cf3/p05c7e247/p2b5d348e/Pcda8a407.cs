namespace WillowMaze.Wasm.Decompiled;

public class Pcda8a407 : P87d487f6
{
    private static byte[] F562f2f91;
    private static byte[] F9b63fa4a;
    private static byte[] Fd6fffbed;
    private static byte[] Fea656a39;
    private static byte Fee3932bd;
    private static byte Ffcbb3479;
    private readonly byte[] F4e869004;
    private readonly byte F5a2c1ed6;
    private readonly byte[] Fa2413f0b;
    private readonly byte Fb70cdb87;
    private readonly byte[] Fd08675ca;
    private readonly byte[] Fee195d61;
    private readonly byte[] Ff732809a;

    private int M1b2f6150(Stream P0, char P1, char P2, char P3, char P4, char P5, char P6, char P7, char P8)
    {
        // str: "invalid characters encountered at end of base32 data"
        // call: Stream.write
        // call: IOException.<init>
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pcda8a407.fee195d61
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pcda8a407.fb70cdb87
        // type: IOException
        return 0;
    }

    private bool M567bc1d2(char P0)
    {
        return false;
    }

    private void M7e820b64(byte[] P0, int P1, byte[] P2, int P3)
    {
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pcda8a407.f4e869004
    }

    private int Ma94903b3(byte[] P0, int P1, int P2)
    {
        // call: pcda8a407.m567bc1d2
        return 0;
    }

    public int Decode(string P0, Stream P1)
    {
        // call: pcda8a407.decode
        // call: p89be9433.md6c3dad7
        return 0;
    }

    public int Decode(byte[] P0, int P1, int P2, Stream P3)
    {
        // str: "invalid characters encountered in base32 data"
        // call: pcda8a407.ma94903b3
        // call: pcda8a407.m567bc1d2
        // call: IOException.<init>
        // call: pcda8a407.m1b2f6150
        // call: Stream.write
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pcda8a407.fee195d61
        // type: IOException
        return 0;
    }

    public int Encode(byte[] P0, int P1, int P2, Stream P3)
    {
        // call: Stream.write
        // call: pcda8a407.encode
        // call: Math.min
        return 0;
    }

    public int Encode(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // call: pcda8a407.m7e820b64
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pcda8a407.fb70cdb87
        return 0;
    }

    public int GetEncodedLength(int P0)
    {
        return 0;
    }

    public int GetMaxDecodedLength(int P0)
    {
        return 0;
    }

    private void InitialiseDecodingTable()
    {
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pcda8a407.f4e869004
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pcda8a407.fee195d61
    }

}
