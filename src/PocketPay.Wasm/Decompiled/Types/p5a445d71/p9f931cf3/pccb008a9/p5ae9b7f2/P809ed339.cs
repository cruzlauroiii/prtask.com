namespace WillowMaze.Wasm.Decompiled;

public class P809ed339 : Pd1977c1b
{
    private bool F09e396b4;
    private readonly pe5cfc515 F1b57951e;
    private readonly pe5cfc515 F1b8dde61;
    private readonly pe5cfc515 F33635839;
    private bool F39c7e2db;
    private readonly p240d858d F7aa19b8d;
    private readonly pe5cfc515 F88a49ecb;
    private bool F91f3baba;
    private bool Fab642273;
    private readonly p240d858d Fb074d6f5;
    private bool Fbc9767aa;

    public byte[] GenerateSignature()
    {
        // str: "DigestingMessageSigner not initialised for signature generation."
        // call: p240d858d.generateSignature
        // call: pe5cfc515.doFinal
        // call: pe5cfc515.getDigestSize
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p809ed339.f7aa19b8d
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p809ed339.f1b8dde61
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p809ed339.f39c7e2db
        // type: IllegalStateException
        return default!;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "Verification Requires Public Key."
        // str: "Signing Requires Private Key."
        // call: IllegalArgumentException.<init>
        // call: p4715f007.getParameters
        // call: pcfffbc4a.isPrivate
        // call: p809ed339.reset
        // call: p240d858d.init
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p809ed339.f39c7e2db
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p809ed339.f7aa19b8d
        // type: IllegalArgumentException
    }

    public void Reset()
    {
        // call: pe5cfc515.reset
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p809ed339.f1b8dde61
    }

    public void Update(byte P0)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p809ed339.f1b8dde61
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p809ed339.f1b8dde61
    }

    public bool VerifySignature(byte[] P0)
    {
        // str: "DigestingMessageSigner not initialised for verification"
        // call: p240d858d.verifySignature
        // call: pe5cfc515.doFinal
        // call: IllegalStateException.<init>
        // call: pe5cfc515.getDigestSize
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p809ed339.f1b8dde61
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p809ed339.f39c7e2db
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p809ed339.f7aa19b8d
        // type: IllegalStateException
        return false;
    }

}
