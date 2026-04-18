namespace WillowMaze.Wasm.Decompiled;

public class Paac4b1f5 : Signature
{
    private p64e649e3 F02a4dca0;
    private p64e649e3 F0445ad1d;
    private p240d858d F060310c7;
    private System.Security.Cryptography.RandomNumberGenerator F0c115c19;
    private pe5cfc515 F30fddcc1;
    private System.Security.Cryptography.RandomNumberGenerator F310b1d2d;
    private p64e649e3 F31d09ac8;
    private System.Security.Cryptography.RandomNumberGenerator F3395581c;
    private p64e649e3 F5f958d1a;
    private p240d858d F67676ef5;
    private p64e649e3 F6a78f174;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private pd9f65fa7 F9d6990db;
    private pd9f65fa7 Fb12071a1;
    private p240d858d Fbe142347;
    private pe5cfc515 Fc10f7796;
    private pe5cfc515 Fce6d9e05;
    private p240d858d Fdb56a74d;
    private p240d858d Fe55ad586;

    private pe5cfc515 Mb423450a()
    {
        // call: p88ef534c.getMessage
        // call: p64e649e3.generateLMSContext
        // call: SignatureException.<init>
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.paac4b1f5.f31d09ac8
        // type: SignatureException
        return default!;
    }

    private object EngineGetParameter(string P0)
    {
        // str: "engineSetParameter unsupported"
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
        return default!;
    }

    private void EngineInitSign(PrivateKey P0)
    {
        // str: "private key exhausted"
        // str: "unknown private key passed to LMS"
        // call: InvalidKeyException.<init>
        // call: p64e649e3.getUsagesRemaining
        // call: p241bd5c3.getKeyParams
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.paac4b1f5.f31d09ac8
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.paac4b1f5.fc10f7796
        // type: InvalidKeyException
    }

    private void EngineInitSign(PrivateKey P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // call: paac4b1f5.engineInitSign
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.paac4b1f5.f7ddf32e1
    }

    private void EngineInitVerify(PublicKey P0)
    {
        // str: "unknown public key passed to XMSS"
        // call: p42086fe7.<init>
        // call: pe5cfc515.reset
        // call: InvalidKeyException.<init>
        // call: pb98d31c4.getKeyParams
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.paac4b1f5.f9d6990db
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.paac4b1f5.fc10f7796
        // type: InvalidKeyException
        // type: p42086fe7
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
        // call: p64e649e3.generateSignature
        // call: SignatureException.<init>
        // call: Exception.getMessage
        // call: paac4b1f5.mb423450a
        // call: Exception.toString
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.paac4b1f5.fc10f7796
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.paac4b1f5.f31d09ac8
        // type: SignatureException
        return default!;
    }

    private void EngineUpdate(byte P0)
    {
        // call: pe5cfc515.update
        // call: paac4b1f5.mb423450a
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.paac4b1f5.fc10f7796
    }

    private void EngineUpdate(byte[] P0, int P1, int P2)
    {
        // call: pe5cfc515.update
        // call: paac4b1f5.mb423450a
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.paac4b1f5.fc10f7796
    }

    private bool EngineVerify(byte[] P0)
    {
        // call: pd9f65fa7.generateLMSContext
        // call: pd9f65fa7.verify
        // call: p69279707.meca8e3f6
        // call: pf502f530.update
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.paac4b1f5.f9d6990db
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.paac4b1f5.fc10f7796
        return false;
    }

}
