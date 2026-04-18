namespace WillowMaze.Wasm.Decompiled;

public class P26a1a997 : SignatureSpi
{
    private System.Security.Cryptography.RandomNumberGenerator F0f2950bb;
    private pe5cfc515 F15932261;
    private System.Security.Cryptography.RandomNumberGenerator F3f0de32d;
    private pe5cfc515 F46d71033;
    private p3935a66f F5291674e;
    private pe5cfc515 F6c7f0ab1;
    private p3935a66f F706f16a6;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private p3935a66f F9e4fdf9b;
    private pe5cfc515 Fc10f7796;
    private p3935a66f Fdb56a74d;

    private object EngineGetParameter(string P0)
    {
        // str: "engineSetParameter unsupported"
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
        return default!;
    }

    private void EngineInitSign(PrivateKey P0)
    {
        // call: p3935a66f.init
        // call: p5cb06cc5.m02ea6360
        // call: p4715f007.<init>
        // call: pe5cfc515.reset
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p26a1a997.f7ddf32e1
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p26a1a997.fc10f7796
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p26a1a997.fdb56a74d
        // type: p4715f007
    }

    private void EngineInitSign(PrivateKey P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // call: p26a1a997.engineInitSign
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p26a1a997.f7ddf32e1
    }

    private void EngineInitVerify(PublicKey P0)
    {
        // call: p5cb06cc5.mc2499d21
        // call: pe5cfc515.reset
        // call: p3935a66f.init
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p26a1a997.fc10f7796
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p26a1a997.fdb56a74d
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
        // call: pe5cfc515.doFinal
        // call: p3935a66f.generateSignature
        // call: pe5cfc515.getDigestSize
        // call: Exception.toString
        // call: SignatureException.<init>
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p26a1a997.fc10f7796
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p26a1a997.fdb56a74d
        // type: SignatureException
        return default!;
    }

    private void EngineUpdate(byte P0)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p26a1a997.fc10f7796
    }

    private void EngineUpdate(byte[] P0, int P1, int P2)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p26a1a997.fc10f7796
    }

    private bool EngineVerify(byte[] P0)
    {
        // call: pe5cfc515.getDigestSize
        // call: p3935a66f.verifySignature
        // call: pe5cfc515.doFinal
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p26a1a997.fc10f7796
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p26a1a997.fdb56a74d
        return false;
    }

}
