namespace WillowMaze.Wasm.Decompiled;

public class P2efb026d : Pd1977c1b
{
    private bool F04a715a4;
    private bool F39c7e2db;
    private readonly byte[] F43ef6e52;
    private readonly p591e4022 F4d3af419;
    private readonly byte[] F5c18ef72;
    private pb29053ed F68d47b6d;
    private pf1c3b35e F6cd6bbaa;
    private bool F76b09d00;
    private pb29053ed F7ea9d177;
    private pb29053ed F81639e6f;
    private bool F990beaa5;
    private readonly p591e4022 Fae23d2c8;
    private pf1c3b35e Fbd0c8e3b;
    private readonly p591e4022 Fc1923255;
    private pb29053ed Fc36853ea;
    private readonly p591e4022 Fe930ee5f;
    private bool Fef2bd5d8;
    private pb29053ed Fef4ca3a2;
    private readonly p591e4022 Fff4af3cf;

    public byte[] GenerateSignature()
    {
        // str: "Ed448phSigner not initialised for signature generation."
        // str: "Prehash digest failed"
        // call: IllegalStateException.<init>
        // call: p591e4022.doFinal
        // call: pf1c3b35e.sign
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2efb026d.f39c7e2db
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2efb026d.fbd0c8e3b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2efb026d.f5c18ef72
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2efb026d.fc1923255
        // type: IllegalStateException
        return default!;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // call: p2efb026d.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2efb026d.fbd0c8e3b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2efb026d.f39c7e2db
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2efb026d.fc36853ea
    }

    public void Reset()
    {
        // call: p591e4022.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2efb026d.fc1923255
    }

    public void Update(byte P0)
    {
        // call: p591e4022.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2efb026d.fc1923255
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // call: p591e4022.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2efb026d.fc1923255
    }

    public bool VerifySignature(byte[] P0)
    {
        // str: "Ed448phSigner not initialised for verification"
        // call: pe7c4a998.m8724e252
        // call: pb29053ed.getEncoded
        // call: IllegalStateException.<init>
        // call: p591e4022.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2efb026d.fc1923255
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2efb026d.f5c18ef72
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2efb026d.fc36853ea
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p2efb026d.f39c7e2db
        // type: IllegalStateException
        return false;
    }

}
