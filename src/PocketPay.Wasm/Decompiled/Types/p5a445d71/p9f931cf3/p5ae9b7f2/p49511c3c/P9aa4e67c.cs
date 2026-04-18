namespace WillowMaze.Wasm.Decompiled;

public class P9aa4e67c : P07d32999
{
    private int F52f9790e;
    private byte[] F5b6c1b66;
    private byte[] F90870c2c;
    private byte[] Fa367d463;
    private int Fb0013e59;
    private pe5cfc515 Fc10f7796;
    private pe5cfc515 Fdc08e631;
    private int Fdccb2ef2;
    private byte[] Ffe4c0f30;

    private void M634ed66f(int P0, byte[] P1)
    {
    }

    public int GenerateBytes(byte[] P0, int P1, int P2)
    {
        // str: "output buffer too small"
        // call: pe5cfc515.update
        // call: p9aa4e67c.m634ed66f
        // call: pe5cfc515.reset
        // call: System.arraycopy
        // call: p2500579c.<init>
        // call: pe5cfc515.doFinal
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p9aa4e67c.fb0013e59
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p9aa4e67c.fc10f7796
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p9aa4e67c.ffe4c0f30
        // type: p2500579c
        return 0;
    }

    public pe5cfc515 GetDigest()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p9aa4e67c.fc10f7796
        return default!;
    }

    public void Init(p873e950b P0)
    {
        // str: "MGF parameters required for MGF1Generator"
        // call: p2fcfd194.getSeed
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p9aa4e67c.ffe4c0f30
        // type: IllegalArgumentException
    }

}
