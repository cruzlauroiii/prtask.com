namespace WillowMaze.Wasm.Decompiled;

public class P26a1a997 : SignatureSpi
{
    private pe5cfc515 F031d1119;
    private p8c48781e F2967b63b;
    private System.Security.Cryptography.RandomNumberGenerator F3a1a77df;
    private readonly p364bf33a F42c28003;
    private p8c48781e F7134266c;
    private p8c48781e F7bba929c;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private System.Security.Cryptography.RandomNumberGenerator Fa576776d;
    private System.Security.Cryptography.RandomNumberGenerator Fa7555cd6;
    private pe5cfc515 Fc10f7796;
    private readonly p364bf33a Fd3f2d9aa;
    private p8c48781e Fdb56a74d;
    private p8c48781e Ff150767a;
    private System.Security.Cryptography.RandomNumberGenerator Ff9b28744;

    private object EngineGetParameter(string P0)
    {
        // str: "engineSetParameter unsupported"
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
        return default!;
    }

    private void EngineInitSign(PrivateKey P0)
    {
        // str: "SPHINCS-256 signature for tree digest: "
        // str: "unknown private key passed to SPHINCS-256"
        // call: StringBuilder.append
        // call: p364bf33a.equals
        // call: p98e7d2a2.getKeyParams
        // call: p8c48781e.init
        // call: StringBuilder.toString
        // call: pe5cfc515.reset
        // call: p98e7d2a2.getTreeDigest
        // call: InvalidKeyException.<init>
        // call: StringBuilder.<init>
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p26a1a997.fc10f7796
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p26a1a997.f42c28003
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p26a1a997.fdb56a74d
        // type: InvalidKeyException
        // type: StringBuilder
    }

    private void EngineInitSign(PrivateKey P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // call: p26a1a997.engineInitSign
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p26a1a997.f7ddf32e1
    }

    private void EngineInitVerify(PublicKey P0)
    {
        // str: "unknown public key passed to SPHINCS-256"
        // str: "SPHINCS-256 signature for tree digest: "
        // call: pe5cfc515.reset
        // call: p364bf33a.equals
        // call: p038797a3.getTreeDigest
        // call: p038797a3.getKeyParams
        // call: p8c48781e.init
        // call: InvalidKeyException.<init>
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p26a1a997.fc10f7796
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p26a1a997.f42c28003
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p26a1a997.fdb56a74d
        // type: StringBuilder
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
        // call: Exception.toString
        // call: SignatureException.<init>
        // call: pe5cfc515.doFinal
        // call: p8c48781e.generateSignature
        // call: pe5cfc515.getDigestSize
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p26a1a997.fdb56a74d
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p26a1a997.fc10f7796
        // type: SignatureException
        return default!;
    }

    private void EngineUpdate(byte P0)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p26a1a997.fc10f7796
    }

    private void EngineUpdate(byte[] P0, int P1, int P2)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p26a1a997.fc10f7796
    }

    private bool EngineVerify(byte[] P0)
    {
        // call: pe5cfc515.doFinal
        // call: p8c48781e.verifySignature
        // call: pe5cfc515.getDigestSize
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p26a1a997.fc10f7796
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p26a1a997.fdb56a74d
        return false;
    }

}
