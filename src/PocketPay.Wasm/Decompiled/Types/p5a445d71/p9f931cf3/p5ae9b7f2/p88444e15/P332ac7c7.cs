namespace WillowMaze.Wasm.Decompiled;

public class P332ac7c7 : P80d89765, P591e4022
{
    private static int Md0c2b66e(int P0)
    {
        // str: " not supported for SHAKE"
        // str: "'bitLength' "
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.toString
        // type: StringBuilder
        // type: IllegalArgumentException
        return 0;
    }

    public int DoFinal(byte[] P0, int P1)
    {
        // call: p332ac7c7.getDigestSize
        // call: p332ac7c7.doFinal
        return 0;
    }

    private int DoFinal(byte[] P0, int P1, byte P2, int P3)
    {
        // call: p332ac7c7.doFinal
        // call: p332ac7c7.getDigestSize
        return 0;
    }

    public int DoFinal(byte[] P0, int P1, int P2)
    {
        // call: p332ac7c7.reset
        // call: p332ac7c7.doOutput
        return 0;
    }

    private int DoFinal(byte[] P0, int P1, int P2, byte P3, int P4)
    {
        // str: "'partialBits' must be in the range [0,7]"
        // call: p332ac7c7.absorbBits
        // call: IllegalArgumentException.<init>
        // call: p332ac7c7.reset
        // call: p332ac7c7.absorb
        // call: p332ac7c7.squeeze
        // type: IllegalArgumentException
        return 0;
    }

    public int DoOutput(byte[] P0, int P1, int P2)
    {
        // call: p332ac7c7.absorbBits
        // call: p332ac7c7.squeeze
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p332ac7c7.fce4bb0f9
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "SHAKE"
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p332ac7c7.f808f248f
        // type: StringBuilder
        return string.Empty;
    }

    public int GetDigestSize()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p332ac7c7.f808f248f
        return 0;
    }

}
