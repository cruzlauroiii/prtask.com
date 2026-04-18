namespace WillowMaze.Wasm.Decompiled;

public class P01f4ef3f : Signature, Pa9584cb0
{
    private p364bf33a F055ab066;
    private p364bf33a F334f0b46;
    private p364bf33a F42c28003;
    private p364bf33a F432f406e;
    private System.Security.Cryptography.RandomNumberGenerator F4c3cda53;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private pe5cfc515 F7ef86715;
    private System.Security.Cryptography.RandomNumberGenerator F82277aba;
    private System.Security.Cryptography.RandomNumberGenerator F99687e58;
    private pe5cfc515 Fa736063b;
    private pe5cfc515 Fc10f7796;
    private pe5cfc515 Fca0325c5;
    private pe5cfc515 Fcac3fb2c;
    private pac63e525 Fcfa7cf6d;
    private p364bf33a Fd72e7075;
    private pac63e525 Fdb56a74d;

    private object EngineGetParameter(string P0)
    {
        // str: "engineSetParameter unsupported"
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
        return default!;
    }

    private void EngineInitSign(PrivateKey P0)
    {
        // str: "unknown private key passed to XMSS"
        // call: p4715f007.<init>
        // call: InvalidKeyException.<init>
        // call: pe5cfc515.reset
        // call: pac63e525.init
        // call: pe11c47f8.getKeyParams
        // call: pe11c47f8.getTreeDigestOID
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p01f4ef3f.fc10f7796
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p01f4ef3f.f42c28003
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p01f4ef3f.f7ddf32e1
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p01f4ef3f.fdb56a74d
        // type: InvalidKeyException
        // type: p4715f007
    }

    private void EngineInitSign(PrivateKey P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // call: p01f4ef3f.engineInitSign
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p01f4ef3f.f7ddf32e1
    }

    private void EngineInitVerify(PublicKey P0)
    {
        // str: "unknown public key passed to XMSS"
        // call: p46415c23.getKeyParams
        // call: pe5cfc515.reset
        // call: InvalidKeyException.<init>
        // call: pac63e525.init
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p01f4ef3f.f42c28003
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p01f4ef3f.fc10f7796
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p01f4ef3f.fdb56a74d
        // type: InvalidKeyException
    }

    private void EngineSetParameter(string P0, object P1)
    {
        // str: "engineSetParameter unsupported"
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
    }

    private void EngineSetParameter(AlgorithmParameterSpec P0)
    {
        // str: "engineSetParameter unsupported"
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
    }

    private byte[] EngineSign()
    {
        // call: p69279707.meca8e3f6
        // call: pac63e525.generateSignature
        // call: Exception.toString
        // call: SignatureException.<init>
        // call: Exception.getMessage
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p01f4ef3f.fdb56a74d
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p01f4ef3f.fc10f7796
        // type: SignatureException
        return default!;
    }

    private void EngineUpdate(byte P0)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p01f4ef3f.fc10f7796
    }

    private void EngineUpdate(byte[] P0, int P1, int P2)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p01f4ef3f.fc10f7796
    }

    private bool EngineVerify(byte[] P0)
    {
        // call: pac63e525.verifySignature
        // call: p69279707.meca8e3f6
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p01f4ef3f.fc10f7796
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p01f4ef3f.fdb56a74d
        return false;
    }

    public PrivateKey GetUpdatedPrivateKey()
    {
        // str: "signature object not in a signing state"
        // call: IllegalStateException.<init>
        // call: pe11c47f8.<init>
        // call: pac63e525.getUpdatedPrivateKey
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p01f4ef3f.f42c28003
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p01f4ef3f.fdb56a74d
        // type: IllegalStateException
        // type: pe11c47f8
        return default!;
    }

    public bool IsSigningCapable()
    {
        // call: pac63e525.getUsagesRemaining
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p01f4ef3f.f42c28003
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p01f4ef3f.fdb56a74d
        return false;
    }

}
