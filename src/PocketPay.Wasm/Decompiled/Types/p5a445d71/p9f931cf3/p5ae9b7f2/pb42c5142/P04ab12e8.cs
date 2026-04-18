namespace WillowMaze.Wasm.Decompiled;

public class P04ab12e8 : Pd1977c1b
{
    private bool F39c7e2db;
    private readonly p42a46bbe F56aad448;
    private bool F5e6b87b8;
    private bool F72109cdd;
    private readonly p42a46bbe Fad1943a9;
    private readonly pe5cfc515 Fb01f1160;
    private readonly pe5cfc515 Fc10f7796;

    public byte[] GenerateSignature()
    {
        // str: "GenericSigner not initialised for signature generation."
        // call: pe5cfc515.doFinal
        // call: pe5cfc515.getDigestSize
        // call: p42a46bbe.processBlock
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p04ab12e8.f39c7e2db
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p04ab12e8.fad1943a9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p04ab12e8.fc10f7796
        // type: IllegalStateException
        return default!;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "verification requires public key"
        // str: "signing requires private key"
        // call: pcfffbc4a.isPrivate
        // call: p42a46bbe.init
        // call: IllegalArgumentException.<init>
        // call: p04ab12e8.reset
        // call: p4715f007.getParameters
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p04ab12e8.fad1943a9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p04ab12e8.f39c7e2db
        // type: IllegalArgumentException
    }

    public void Reset()
    {
        // call: pe5cfc515.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p04ab12e8.fc10f7796
    }

    public void Update(byte P0)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p04ab12e8.fc10f7796
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p04ab12e8.fc10f7796
    }

    public bool VerifySignature(byte[] P0)
    {
        // str: "GenericSigner not initialised for verification"
        // call: pe5cfc515.doFinal
        // call: p42a46bbe.processBlock
        // call: System.arraycopy
        // call: pff43b8de.m66e765de
        // call: IllegalStateException.<init>
        // call: pe5cfc515.getDigestSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p04ab12e8.fad1943a9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p04ab12e8.fc10f7796
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p04ab12e8.f39c7e2db
        // type: IllegalStateException
        return false;
    }

}
