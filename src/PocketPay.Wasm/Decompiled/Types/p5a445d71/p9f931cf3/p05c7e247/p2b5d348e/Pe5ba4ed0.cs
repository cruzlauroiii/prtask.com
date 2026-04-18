namespace WillowMaze.Wasm.Decompiled;

public class Pe5ba4ed0 : P87d487f6
{
    private readonly byte[] F047681ef;
    private readonly byte[] F35e622e6;
    private readonly byte[] F4b5b9f25;
    private readonly byte[] F4e869004;
    private byte F55324463;
    private byte F9be0f2d7;
    private readonly byte[] Faa87eae2;
    private byte Fb70cdb87;
    private readonly byte[] Fd1bac126;
    private readonly byte[] Fe05a73b4;
    private readonly byte[] Fee195d61;

    private int M1b2f6150(Stream P0, char P1, char P2, char P3, char P4)
    {
        // str: "invalid characters encountered at end of base64 data"
        // call: Stream.write
        // call: IOException.<init>
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pe5ba4ed0.fee195d61
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pe5ba4ed0.fb70cdb87
        // type: IOException
        return 0;
    }

    private bool M567bc1d2(char P0)
    {
        return false;
    }

    private int Ma94903b3(string P0, int P1, int P2)
    {
        // call: string.charAt
        // call: pe5ba4ed0.m567bc1d2
        return 0;
    }

    private int Ma94903b3(byte[] P0, int P1, int P2)
    {
        // call: pe5ba4ed0.m567bc1d2
        return 0;
    }

    public int Decode(string P0, Stream P1)
    {
        // str: "invalid characters encountered in base64 data"
        // call: pe5ba4ed0.m567bc1d2
        // call: string.charAt
        // call: Stream.write
        // call: pe5ba4ed0.ma94903b3
        // call: pe5ba4ed0.m1b2f6150
        // call: string.length
        // call: IOException.<init>
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pe5ba4ed0.fee195d61
        // type: IOException
        return 0;
    }

    public int Decode(byte[] P0, int P1, int P2, Stream P3)
    {
        // str: "invalid characters encountered in base64 data"
        // call: pe5ba4ed0.ma94903b3
        // call: pe5ba4ed0.m1b2f6150
        // call: Stream.write
        // call: IOException.<init>
        // call: pe5ba4ed0.m567bc1d2
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pe5ba4ed0.fee195d61
        // type: IOException
        return 0;
    }

    public int Encode(byte[] P0, int P1, int P2, Stream P3)
    {
        // call: Stream.write
        // call: Math.min
        // call: pe5ba4ed0.encode
        return 0;
    }

    public int Encode(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pe5ba4ed0.f4e869004
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pe5ba4ed0.fb70cdb87
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
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pe5ba4ed0.fee195d61
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pe5ba4ed0.f4e869004
    }

}
