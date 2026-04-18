namespace WillowMaze.Wasm.Decompiled;

public class P2282326c : Pd1977c1b
{
    private p070794c1 F018912f1;
    private readonly byte[] F18f0cf2d;
    private p070794c1 F2180a145;
    private pe1b9a0e1 F3428c3db;
    private bool F3965a4cc;
    private bool F39c7e2db;
    private readonly byte[] F5c18ef72;
    private p070794c1 F5d9913f8;
    private bool F7b67b68e;
    private bool F94796e32;
    private readonly pe5cfc515 F994491eb;
    private pe1b9a0e1 Fbd0c8e3b;
    private readonly pe5cfc515 Fc1923255;
    private p070794c1 Fc36853ea;
    private readonly byte[] Fcb6e9f07;
    private bool Fd2c354eb;
    private readonly pe5cfc515 Fee323746;

    public byte[] GenerateSignature()
    {
        // str: "Ed25519phSigner not initialised for signature generation."
        // str: "Prehash digest failed"
        // call: pe1b9a0e1.sign
        // call: pe5cfc515.doFinal
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2282326c.fc1923255
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2282326c.f5c18ef72
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2282326c.fbd0c8e3b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2282326c.f39c7e2db
        // type: IllegalStateException
        return default!;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // call: p2282326c.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2282326c.f39c7e2db
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2282326c.fbd0c8e3b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2282326c.fc36853ea
    }

    public void Reset()
    {
        // call: pe5cfc515.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2282326c.fc1923255
    }

    public void Update(byte P0)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2282326c.fc1923255
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2282326c.fc1923255
    }

    public bool VerifySignature(byte[] P0)
    {
        // str: "Ed25519phSigner not initialised for verification"
        // call: IllegalStateException.<init>
        // call: p9edc4d6f.m8724e252
        // call: p070794c1.getEncoded
        // call: pe5cfc515.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2282326c.fc1923255
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2282326c.f5c18ef72
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2282326c.f39c7e2db
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2282326c.fc36853ea
        // type: IllegalStateException
        return false;
    }

}
