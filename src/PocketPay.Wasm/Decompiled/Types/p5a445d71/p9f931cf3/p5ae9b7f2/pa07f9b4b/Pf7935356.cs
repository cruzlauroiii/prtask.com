namespace WillowMaze.Wasm.Decompiled;

public class Pf7935356 : Pe229a672
{
    private static int F1b6b95da;
    private static int F97ec501e;
    private static int F9833a99f;
    private static int Fabdd6ff2;
    private static int Fe7f124fc;
    private bool F0321831c;
    private p48fd26f6 F0562171b;
    private byte[] F0dfef751;
    private byte[] F175d622f;
    private p48fd26f6 F1a0725d1;
    private byte[] F1f769c89;
    private p48fd26f6 F23bc3bcf;
    private bool F2cd48358;
    private byte[] F4700a657;
    private byte[] F4f5010cc;
    private byte[] F5894f6fa;
    private byte[] F66df0ef0;
    private byte[] F74f70377;
    private byte[] F76e55cf8;
    private p48fd26f6 F8b2fced6;
    private byte[] F9449347b;
    private byte[] F9d5ed678;
    private bool Fa4a3dffa;
    private byte[] Faaf196d2;
    private p48fd26f6 Fad1943a9;
    private byte[] Fbf182e76;
    private bool Fc32ba6c2;
    private List<object> Fc99f0ea2;
    private List<object> Fd1a8fad7;
    private bool Fe468b4bf;
    private byte[] Ff92a4991;

    private void Mf6821602(int P0, byte[] P1, int P2)
    {
    }

    public string GetAlgorithmName()
    {
        // str: "DSTU7624WrapEngine"
        return string.Empty;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "invalid parameters passed to DSTU7624WrapEngine"
        // call: IllegalArgumentException.<init>
        // call: p48fd26f6.init
        // call: p4715f007.getParameters
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf7935356.fe468b4bf
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf7935356.fad1943a9
        // type: IllegalArgumentException
    }

    public byte[] Unwrap(byte[] P0, int P1, int P2)
    {
        // str: "not set for unwrapping"
        // str: "unwrap data must be a multiple of "
        // str: " bytes"
        // str: "checksum failed"
        // call: p48fd26f6.getBlockSize
        // call: System.arraycopy
        // call: IllegalStateException.<init>
        // call: List<object>.get
        // call: List<object>.clear
        // call: StringBuilder.append
        // call: p48fd26f6.processBlock
        // call: StringBuilder.toString
        // call: p96068848.<init>
        // call: StringBuilder.<init>
        // call: List<object>.add
        // call: pff43b8de.m2a3f81d2
        // call: p21c8c989.<init>
        // call: pf7935356.mf6821602
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf7935356.f66df0ef0
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf7935356.fad1943a9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf7935356.f76e55cf8
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf7935356.fc99f0ea2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf7935356.fe468b4bf
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf7935356.ff92a4991
        // type: StringBuilder
        // type: p96068848
        // type: IllegalStateException
        // type: p21c8c989
        return default!;
    }

    public byte[] Wrap(byte[] P0, int P1, int P2)
    {
        // str: "not set for wrapping"
        // str: "wrap data must be a multiple of "
        // str: " bytes"
        // str: "input buffer too short"
        // call: p48fd26f6.getBlockSize
        // call: p96068848.<init>
        // call: System.arraycopy
        // call: StringBuilder.<init>
        // call: IllegalStateException.<init>
        // call: List<object>.get
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: List<object>.clear
        // call: p48fd26f6.processBlock
        // call: pf7935356.mf6821602
        // call: List<object>.add
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf7935356.fad1943a9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf7935356.fc99f0ea2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf7935356.f76e55cf8
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf7935356.f9d5ed678
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf7935356.fe468b4bf
        // type: StringBuilder
        // type: p96068848
        // type: IllegalStateException
        return default!;
    }

}
