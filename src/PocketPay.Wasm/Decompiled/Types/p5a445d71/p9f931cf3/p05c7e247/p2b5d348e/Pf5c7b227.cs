namespace WillowMaze.Wasm.Decompiled;

public class Pf5c7b227 : P87d487f6
{
    private readonly byte[] F05ea4ed4;
    private readonly byte[] F4e869004;
    private readonly byte[] Fad8be112;
    private readonly byte[] Fee195d61;

    private static bool M567bc1d2(char P0)
    {
        return false;
    }

    public int Decode(string P0, Stream P1)
    {
        // str: "invalid characters encountered in Hex string"
        // call: string.charAt
        // call: string.length
        // call: pf5c7b227.m567bc1d2
        // call: Stream.write
        // call: IOException.<init>
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pf5c7b227.fee195d61
        // type: IOException
        return 0;
    }

    public int Decode(byte[] P0, int P1, int P2, Stream P3)
    {
        // str: "invalid characters encountered in Hex data"
        // call: pf5c7b227.m567bc1d2
        // call: Stream.write
        // call: IOException.<init>
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pf5c7b227.fee195d61
        // type: IOException
        return 0;
    }

    private byte[] DecodeStrict(string P0, int P1, int P2)
    {
        // str: "invalid offset and/or length specified"
        // str: "invalid characters encountered in Hex string"
        // str: "'str' cannot be null"
        // str: "a hexadecimal encoding must have an even number of characters"
        // call: string.length
        // call: IOException.<init>
        // call: string.charAt
        // call: NullPointerException.<init>
        // call: IndexOutOfBoundsException.<init>
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pf5c7b227.fee195d61
        // type: IOException
        // type: NullPointerException
        // type: IndexOutOfBoundsException
        return default!;
    }

    public int Encode(byte[] P0, int P1, int P2, Stream P3)
    {
        // call: pf5c7b227.encode
        // call: Stream.write
        // call: Math.min
        return 0;
    }

    public int Encode(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pf5c7b227.f4e869004
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
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pf5c7b227.fee195d61
        // field: p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pf5c7b227.f4e869004
    }

}
