namespace WillowMaze.Wasm.Decompiled;

public class Pa29df92a : Signature, Pa9584cb0
{
    private p364bf33a F1ae0077d;
    private p364bf33a F357642bb;
    private System.Security.Cryptography.RandomNumberGenerator F42b7cc57;
    private p364bf33a F42c28003;
    private p8b800ddd F579fae5f;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private p364bf33a F892fa0bc;
    private pe5cfc515 F96ba7695;
    private pe5cfc515 Faa1240c2;
    private p8b800ddd Fbf6d10d9;
    private pe5cfc515 Fc10f7796;
    private p8b800ddd Fdb56a74d;
    private System.Security.Cryptography.RandomNumberGenerator Fdd3823d6;
    private p364bf33a Fe63cbf95;

    private object EngineGetParameter(string P0)
    {
        // str: "engineSetParameter unsupported"
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
        return default!;
    }

    private void EngineInitSign(PrivateKey P0)
    {
        // str: "unknown private key passed to XMSSMT"
        // call: pe5cfc515.reset
        // call: p8b800ddd.init
        // call: peca3a970.getTreeDigestOID
        // call: peca3a970.getKeyParams
        // call: InvalidKeyException.<init>
        // call: p4715f007.<init>
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pa29df92a.f7ddf32e1
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pa29df92a.fc10f7796
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pa29df92a.f42c28003
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pa29df92a.fdb56a74d
        // type: InvalidKeyException
        // type: p4715f007
    }

    private void EngineInitSign(PrivateKey P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // call: pa29df92a.engineInitSign
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pa29df92a.f7ddf32e1
    }

    private void EngineInitVerify(PublicKey P0)
    {
        // str: "unknown public key passed to XMSSMT"
        // call: pe5cfc515.reset
        // call: pfc9dc6a3.getKeyParams
        // call: p8b800ddd.init
        // call: InvalidKeyException.<init>
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pa29df92a.fc10f7796
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pa29df92a.fdb56a74d
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pa29df92a.f42c28003
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
        // call: Exception.getMessage
        // call: SignatureException.<init>
        // call: p69279707.meca8e3f6
        // call: p8b800ddd.generateSignature
        // call: Exception.toString
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pa29df92a.fc10f7796
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pa29df92a.fdb56a74d
        // type: SignatureException
        return default!;
    }

    private void EngineUpdate(byte P0)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pa29df92a.fc10f7796
    }

    private void EngineUpdate(byte[] P0, int P1, int P2)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pa29df92a.fc10f7796
    }

    private bool EngineVerify(byte[] P0)
    {
        // call: p69279707.meca8e3f6
        // call: p8b800ddd.verifySignature
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pa29df92a.fdb56a74d
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pa29df92a.fc10f7796
        return false;
    }

    public PrivateKey GetUpdatedPrivateKey()
    {
        // str: "signature object not in a signing state"
        // call: peca3a970.<init>
        // call: IllegalStateException.<init>
        // call: p8b800ddd.getUpdatedPrivateKey
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pa29df92a.fdb56a74d
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pa29df92a.f42c28003
        // type: peca3a970
        // type: IllegalStateException
        return default!;
    }

    public bool IsSigningCapable()
    {
        // call: p8b800ddd.getUsagesRemaining
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pa29df92a.fdb56a74d
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pa29df92a.f42c28003
        return false;
    }

}
