namespace WillowMaze.Wasm.Decompiled;

public class P939cc645 : P6886463d
{
    private readonly pe5cfc515 F1ea205ce;
    private readonly System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private readonly int F9bc4a6db;
    private readonly int Fb4300c77;
    private readonly pe5cfc515 Fc10f7796;
    private readonly System.Security.Cryptography.RandomNumberGenerator Fd47a3e96;
    private readonly System.Security.Cryptography.RandomNumberGenerator Febc69742;

    private byte[] Me326816e(byte[] P0, byte[] P1)
    {
        // call: pe5cfc515.update
        // call: pe5cfc515.getDigestSize
        // call: pe5cfc515.doFinal
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p1941b12d.p939cc645.fc10f7796
        return default!;
    }

    public p905a4f24 Commit(byte[] P0)
    {
        // str: "Message to be committed to too large for digest."
        // call: p939cc645.me326816e
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // call: p96068848.<init>
        // call: p905a4f24.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p1941b12d.p939cc645.f9bc4a6db
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p1941b12d.p939cc645.f7ddf32e1
        // type: p96068848
        // type: p905a4f24
        return default!;
    }

    public bool IsRevealed(p905a4f24 P0, byte[] P1)
    {
        // str: "Message and witness secret lengths do not match."
        // call: p939cc645.me326816e
        // call: p905a4f24.getSecret
        // call: pff43b8de.m66e765de
        // call: p96068848.<init>
        // call: p905a4f24.getCommitment
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p1941b12d.p939cc645.f9bc4a6db
        // type: p96068848
        return false;
    }

}
