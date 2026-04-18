namespace WillowMaze.Wasm.Decompiled;

public class Pc346e9ef : P4803ba84
{
    private static int F2c717e8e;
    private static int F5ab7af99;
    private static int Fc75e2054;
    private static int Fcf90e493;
    private static int Ff895cbcb;
    private int[] F1300a5f6;
    private int[] F1a40a188;
    private int[] F27c25663;
    private int[] F28992b48;
    private int[] F3e994088;
    private int[] F531658ba;
    private int[] F74e0526b;
    private int[] F7d2d7318;
    private int[] F872ad824;
    private bool F9301aa9b;
    private int[] Faf4694ab;
    private bool Fb7c07b8b;
    private int[] Ff9e50d9a;
    private int[] Ffd1a92bd;

    public string GetAlgorithmName()
    {
        // str: "DESede"
        return string.Empty;
    }

    public int GetBlockSize()
    {
        return 0;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "invalid parameter passed to DESede init - "
        // str: "key size must be 16 or 24 bytes."
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: System.arraycopy
        // call: pc346e9ef.generateWorkingKey
        // call: Type.getName
        // call: p94919be6.getKey
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.toString
        // call: object.getClass
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pc346e9ef.f872ad824
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pc346e9ef.f1300a5f6
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pc346e9ef.f1a40a188
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pc346e9ef.f9301aa9b
        // type: StringBuilder
        // type: IllegalArgumentException
    }

    public int ProcessBlock(byte[] P0, int P1, byte[] P2, int P3)
    {
        // str: "input buffer too short"
        // str: "output buffer too short"
        // str: "DESede engine not initialised"
        // call: pc346e9ef.desFunc
        // call: p2500579c.<init>
        // call: IllegalStateException.<init>
        // call: p96068848.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pc346e9ef.f872ad824
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pc346e9ef.f1300a5f6
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pc346e9ef.f1a40a188
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pc346e9ef.f9301aa9b
        // type: p2500579c
        // type: IllegalStateException
        // type: p96068848
        return 0;
    }

    public void Reset()
    {
    }

}
