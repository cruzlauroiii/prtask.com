namespace WillowMaze.Wasm.Decompiled;

public class P6897111f : Pd1977c1b
{
    private readonly pa8ad1191 F0c5b23a6;
    private readonly p89320dbd F20b1f213;
    private readonly pe5cfc515 F329ba86b;
    private readonly pa8ad1191 F371d44c2;
    private readonly pe5cfc515 F3936393b;
    private bool F39c7e2db;
    private readonly pa8ad1191 F4bc26f64;
    private readonly p89320dbd F5f039b4e;
    private readonly p89320dbd F82638b9b;
    private readonly pa8ad1191 F84bea1f0;
    private readonly p89320dbd Fa04974c0;
    private readonly pe5cfc515 Fa73e127e;
    private readonly pe5cfc515 Fc10f7796;
    private bool Ffac765d1;

    public byte[] GenerateSignature()
    {
        // str: "DSADigestSigner not initialised for signature generation."
        // str: "unable to encode signature"
        // call: IllegalStateException.<init>
        // call: pe5cfc515.doFinal
        // call: pe5cfc515.getDigestSize
        // call: p89320dbd.generateSignature
        // call: p6897111f.getOrder
        // call: pa8ad1191.encode
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p6897111f.f5f039b4e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p6897111f.fc10f7796
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p6897111f.f39c7e2db
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p6897111f.f84bea1f0
        // type: IllegalStateException
        return default!;
    }

    private System.Numerics.BigInteger GetOrder()
    {
        // call: pae380b4d.getOrder
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p6897111f.f5f039b4e
        return default!;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "Signing Requires Private Key."
        // str: "Verification Requires Public Key."
        // call: IllegalArgumentException.<init>
        // call: p6897111f.reset
        // call: p4715f007.getParameters
        // call: pcfffbc4a.isPrivate
        // call: p89320dbd.init
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p6897111f.f5f039b4e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p6897111f.f39c7e2db
        // type: IllegalArgumentException
    }

    public void Reset()
    {
        // call: pe5cfc515.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p6897111f.fc10f7796
    }

    public void Update(byte P0)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p6897111f.fc10f7796
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p6897111f.fc10f7796
    }

    public bool VerifySignature(byte[] P0)
    {
        // str: "DSADigestSigner not initialised for verification"
        // call: pe5cfc515.doFinal
        // call: p6897111f.getOrder
        // call: pa8ad1191.decode
        // call: p89320dbd.verifySignature
        // call: IllegalStateException.<init>
        // call: pe5cfc515.getDigestSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p6897111f.fc10f7796
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p6897111f.f39c7e2db
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p6897111f.f84bea1f0
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p6897111f.f5f039b4e
        // type: IllegalStateException
        return false;
    }

}
