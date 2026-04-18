namespace WillowMaze.Wasm.Decompiled;

public class P26a1a997 : SignatureSpi, P03c3d84c, P756b0dc3
{
    private System.Security.Cryptography.RandomNumberGenerator F027511b4;
    private System.Security.Cryptography.RandomNumberGenerator F17e41a5d;
    private pae380b4d F63021b1d;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private pe5cfc515 F878999f4;
    private System.Security.Cryptography.RandomNumberGenerator Fb5479af2;
    private pe5cfc515 Fc10f7796;
    private pae380b4d Fdb56a74d;

    private object EngineGetParameter(string P0)
    {
        // str: "engineSetParameter unsupported"
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
        return default!;
    }

    private void EngineInitSign(PrivateKey P0)
    {
        // call: pae380b4d.init
        // call: p37c4833e.m02ea6360
        // call: pe5cfc515.reset
        // call: p7a5dfe3f.m02ea6360
        // call: p4715f007.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p26a1a997.fc10f7796
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p26a1a997.f7ddf32e1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p26a1a997.fdb56a74d
        // type: p4715f007
    }

    private void EngineInitSign(PrivateKey P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // call: p26a1a997.engineInitSign
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p26a1a997.f7ddf32e1
    }

    private void EngineInitVerify(PublicKey P0)
    {
        // str: "can't recognise key type in DSA based signer"
        // call: p7a5dfe3f.mc2499d21
        // call: pe5cfc515.reset
        // call: PublicKey.getEncoded
        // call: p3cdccfc9.m8bab0102
        // call: p63d19d11.m1367c17c
        // call: p37c4833e.mc2499d21
        // call: pae380b4d.init
        // call: InvalidKeyException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p26a1a997.fc10f7796
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p26a1a997.fdb56a74d
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
        // call: pae380b4d.generateSignature
        // call: System.Numerics.BigInteger.toByteArray
        // call: System.arraycopy
        // call: SignatureException.<init>
        // call: Exception.toString
        // call: pe5cfc515.doFinal
        // call: pe5cfc515.getDigestSize
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p26a1a997.fdb56a74d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p26a1a997.fc10f7796
        // type: SignatureException
        return default!;
    }

    private void EngineUpdate(byte P0)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p26a1a997.fc10f7796
    }

    private void EngineUpdate(byte[] P0, int P1, int P2)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p26a1a997.fc10f7796
    }

    private bool EngineVerify(byte[] P0)
    {
        // str: "error decoding signature bytes."
        // call: pae380b4d.verifySignature
        // call: SignatureException.<init>
        // call: System.arraycopy
        // call: System.Numerics.BigInteger.<init>
        // call: pe5cfc515.doFinal
        // call: pe5cfc515.getDigestSize
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p26a1a997.fc10f7796
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p26a1a997.fdb56a74d
        // type: SignatureException
        // type: System.Numerics.BigInteger
        return false;
    }

}
