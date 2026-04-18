namespace WillowMaze.Wasm.Decompiled;

public class Pac77befd : P07d32999
{
    private pe5cfc515 F3ccf58a4;
    private byte[] F4ed90ad5;
    private pe5cfc515 F563c516c;
    private byte[] F9e81e7b9;
    private byte[] Fa0756122;
    private byte[] Fa4cf2cfc;
    private pe5cfc515 Fbe39fe70;
    private byte[] Fbff915b7;
    private pe5cfc515 Fc10f7796;
    private byte[] Ff0b53b2d;

    public int GenerateBytes(byte[] P0, int P1, int P2)
    {
        // str: "output buffer too small"
        // str: "Output length too large"
        // call: pe5cfc515.doFinal
        // call: pe5cfc515.reset
        // call: pe5cfc515.update
        // call: p2500579c.<init>
        // call: pe5cfc515.getDigestSize
        // call: IllegalArgumentException.<init>
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pac77befd.fc10f7796
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pac77befd.f9e81e7b9
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pac77befd.ff0b53b2d
        // type: IllegalArgumentException
        // type: p2500579c
        return 0;
    }

    public pe5cfc515 GetDigest()
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pac77befd.fc10f7796
        return default!;
    }

    public void Init(p873e950b P0)
    {
        // str: "KDF parameters required for generator"
        // call: pc03b0fe3.getIV
        // call: pc03b0fe3.getSharedSecret
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pac77befd.f9e81e7b9
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pac77befd.ff0b53b2d
        // type: IllegalArgumentException
    }

}
