namespace WillowMaze.Wasm.Decompiled;

public class Pe069db76 : P07d32999
{
    private pe5cfc515 F08abf8a4;
    private byte[] F117c55e6;
    private byte[] F2effb287;
    private pe5cfc515 F626c59b9;
    private byte[] F63641252;
    private byte[] F9e81e7b9;
    private int F9fb997de;
    private int Fb0013e59;
    private pe5cfc515 Fc10f7796;
    private byte[] Ffdce7a34;

    private void M634ed66f(int P0, byte[] P1)
    {
    }

    public int GenerateBytes(byte[] P0, int P1, int P2)
    {
        // str: "output buffer too small"
        // call: pe5cfc515.update
        // call: System.arraycopy
        // call: pe5cfc515.doFinal
        // call: pe5cfc515.reset
        // call: p2500579c.<init>
        // call: pe069db76.m634ed66f
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p168e7cba.pe069db76.f9e81e7b9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p168e7cba.pe069db76.fc10f7796
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p168e7cba.pe069db76.fb0013e59
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p168e7cba.pe069db76.ffdce7a34
        // type: p2500579c
        return 0;
    }

    public pe5cfc515 GetDigest()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p168e7cba.pe069db76.fc10f7796
        return default!;
    }

    public void Init(p873e950b P0)
    {
        // str: "KDF parameters required for generator"
        // call: pc03b0fe3.getIV
        // call: pc03b0fe3.getSharedSecret
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p168e7cba.pe069db76.f9e81e7b9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p168e7cba.pe069db76.ffdce7a34
        // type: IllegalArgumentException
    }

}
