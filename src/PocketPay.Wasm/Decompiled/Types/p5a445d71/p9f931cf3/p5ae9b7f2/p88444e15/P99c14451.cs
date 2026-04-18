namespace WillowMaze.Wasm.Decompiled;

public class P99c14451 : P80d89765
{
    private static int Md0c2b66e(int P0)
    {
        // str: " not supported for SHA-3"
        // str: "'bitLength' "
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: IllegalArgumentException.<init>
        // type: StringBuilder
        // type: IllegalArgumentException
        return 0;
    }

    public int DoFinal(byte[] P0, int P1)
    {
        // call: p99c14451.absorbBits
        // call: p80d89765.doFinal
        return 0;
    }

    private int DoFinal(byte[] P0, int P1, byte P2, int P3)
    {
        // str: "'partialBits' must be in the range [0,7]"
        // call: p99c14451.absorb
        // call: IllegalArgumentException.<init>
        // call: p80d89765.doFinal
        // type: IllegalArgumentException
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "SHA3-"
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p99c14451.f808f248f
        // type: StringBuilder
        return string.Empty;
    }

}
