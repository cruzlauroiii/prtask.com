namespace WillowMaze.Wasm.Decompiled;

public class Pd75946e5 : P6886463d
{
    private readonly pe5cfc515 F501e666b;
    private readonly System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private readonly pe5cfc515 F9797d872;
    private readonly System.Security.Cryptography.RandomNumberGenerator F97b916d9;
    private readonly int F9bc4a6db;
    private readonly int Fa11b34da;
    private readonly pe5cfc515 Faa41f54b;
    private readonly pe5cfc515 Fc10f7796;
    private readonly System.Security.Cryptography.RandomNumberGenerator Fee623e8f;

    private byte[] Me326816e(byte[] P0, byte[] P1)
    {
        // call: pe5cfc515.doFinal
        // call: pe5cfc515.update
        // call: pe5cfc515.getDigestSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p1941b12d.pd75946e5.fc10f7796
        return default!;
    }

    public p905a4f24 Commit(byte[] P0)
    {
        // str: "Message to be committed to too large for digest."
        // call: p96068848.<init>
        // call: p905a4f24.<init>
        // call: pd75946e5.me326816e
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p1941b12d.pd75946e5.f9bc4a6db
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p1941b12d.pd75946e5.f7ddf32e1
        // type: p905a4f24
        // type: p96068848
        return default!;
    }

    public bool IsRevealed(p905a4f24 P0, byte[] P1)
    {
        // str: "Message and witness secret lengths do not match."
        // call: p905a4f24.getSecret
        // call: pd75946e5.me326816e
        // call: p905a4f24.getCommitment
        // call: pff43b8de.m66e765de
        // call: p96068848.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p1941b12d.pd75946e5.f9bc4a6db
        // type: p96068848
        return false;
    }

}
