namespace WillowMaze.Wasm.Decompiled;

public class P26a1a997 : SignatureSpi, P03c3d84c, P756b0dc3
{
    private pae380b4d F0a610942;
    private pae380b4d F4f409d7c;
    private pe5cfc515 F67bc193b;
    private pae380b4d F6fc9bfa0;
    private pae380b4d F7cb6b8ea;
    private pe5cfc515 Fc10f7796;
    private pe5cfc515 Fda4bbdf0;
    private pe5cfc515 Fdaf6abb7;
    private pae380b4d Fdb56a74d;

    private static pcfffbc4a Mc2499d21(PublicKey P0)
    {
        // call: pecf68685.engineGetKeyParameters
        // call: p37c4833e.mc2499d21
        return default!;
    }

    private object EngineGetParameter(string P0)
    {
        // str: "engineSetParameter unsupported"
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
        return default!;
    }

    private AlgorithmParameters EngineGetParameters()
    {
        return default!;
    }

    private void EngineInitSign(PrivateKey P0)
    {
        // call: p7a5dfe3f.m02ea6360
        // call: pae380b4d.init
        // call: p4715f007.<init>
        // call: pe5cfc515.reset
        // call: p37c4833e.m02ea6360
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p26a1a997.fdb56a74d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p26a1a997.appRandom
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p26a1a997.fc10f7796
        // type: p4715f007
    }

    private void EngineInitVerify(PublicKey P0)
    {
        // str: "can't recognise key type in DSA based signer"
        // call: pae380b4d.init
        // call: pe5cfc515.reset
        // call: p7a5dfe3f.mc2499d21
        // call: p26a1a997.mc2499d21
        // call: InvalidKeyException.<init>
        // call: PublicKey.getEncoded
        // call: p3cdccfc9.m8bab0102
        // call: p63d19d11.m1367c17c
        // call: p37c4833e.mc2499d21
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p26a1a997.fc10f7796
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p26a1a997.fdb56a74d
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
        // call: pe5cfc515.doFinal
        // call: pe5cfc515.getDigestSize
        // call: SignatureException.<init>
        // call: Exception.toString
        // call: pae380b4d.generateSignature
        // call: System.Numerics.BigInteger.toByteArray
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p26a1a997.fc10f7796
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p26a1a997.fdb56a74d
        // type: SignatureException
        return default!;
    }

    private void EngineUpdate(byte P0)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p26a1a997.fc10f7796
    }

    private void EngineUpdate(byte[] P0, int P1, int P2)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p26a1a997.fc10f7796
    }

    private bool EngineVerify(byte[] P0)
    {
        // str: "error decoding signature bytes."
        // call: pae380b4d.verifySignature
        // call: pe5cfc515.doFinal
        // call: SignatureException.<init>
        // call: System.arraycopy
        // call: System.Numerics.BigInteger.<init>
        // call: pe5cfc515.getDigestSize
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p26a1a997.fc10f7796
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p26a1a997.fdb56a74d
        // type: SignatureException
        // type: System.Numerics.BigInteger
        return false;
    }

}
