namespace WillowMaze.Wasm.Decompiled;

public class P26a1a997 : Signature
{
    private System.Security.Cryptography.RandomNumberGenerator F3a330e60;
    private pe5cfc515 F48f2ba7e;
    private p21c106e2 F793621f7;
    private System.Security.Cryptography.RandomNumberGenerator F7a5d3577;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private p21c106e2 F967345d0;
    private pe5cfc515 Fbc26e92c;
    private pe5cfc515 Fc10f7796;
    private System.Security.Cryptography.RandomNumberGenerator Fd925e07e;
    private p21c106e2 Fdb56a74d;
    private System.Security.Cryptography.RandomNumberGenerator Ffff56050;

    private object EngineGetParameter(string P0)
    {
        // str: "engineSetParameter unsupported"
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
        return default!;
    }

    private void EngineInitSign(PrivateKey P0)
    {
        // str: "unknown private key passed to qTESLA"
        // call: InvalidKeyException.<init>
        // call: p4715f007.<init>
        // call: p21c106e2.init
        // call: p2f864b5d.getKeyParams
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.p26a1a997.f7ddf32e1
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.p26a1a997.fdb56a74d
        // type: p4715f007
        // type: InvalidKeyException
    }

    private void EngineInitSign(PrivateKey P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // call: p26a1a997.engineInitSign
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.p26a1a997.f7ddf32e1
    }

    private void EngineInitVerify(PublicKey P0)
    {
        // str: "unknown public key passed to qTESLA"
        // call: pe5cfc515.reset
        // call: InvalidKeyException.<init>
        // call: p21c106e2.init
        // call: pa074df52.getKeyParams
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.p26a1a997.fc10f7796
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.p26a1a997.fdb56a74d
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
        // call: SignatureException.<init>
        // call: p69279707.meca8e3f6
        // call: p21c106e2.generateSignature
        // call: Exception.toString
        // call: Exception.getMessage
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.p26a1a997.fc10f7796
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.p26a1a997.fdb56a74d
        // type: SignatureException
        return default!;
    }

    private void EngineUpdate(byte P0)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.p26a1a997.fc10f7796
    }

    private void EngineUpdate(byte[] P0, int P1, int P2)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.p26a1a997.fc10f7796
    }

    private bool EngineVerify(byte[] P0)
    {
        // call: p21c106e2.verifySignature
        // call: p69279707.meca8e3f6
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.p26a1a997.fc10f7796
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.p26a1a997.fdb56a74d
        return false;
    }

}
