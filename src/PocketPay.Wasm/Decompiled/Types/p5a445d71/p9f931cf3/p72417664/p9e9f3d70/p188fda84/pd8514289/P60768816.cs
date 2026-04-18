namespace WillowMaze.Wasm.Decompiled;

public class P60768816 : SignatureSpi, P03c3d84c, P756b0dc3
{
    private int F013dcb3d;
    private pae380b4d F0498690e;
    private pe5cfc515 F0f1e5d1f;
    private pae380b4d F47bea8c7;
    private int F7e1902ca;
    private pae380b4d F94607716;
    private pe5cfc515 Fbfb40d79;
    private pe5cfc515 Fc10f7796;
    private int Fd52faf8c;
    private pae380b4d Fdb56a74d;
    private int Fe31d540b;
    private int Ff7bd60b7;
    private int Ffa63da8e;

    private static pcfffbc4a Mc2499d21(PublicKey P0)
    {
        // call: p37c4833e.mc2499d21
        // call: p5d6836ed.engineGetKeyParameters
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
        // str: "cannot recognise key type in ECGOST-2012-256 signer"
        // str: "key out of range for ECGOST-2012-256"
        // call: pe5cfc515.reset
        // call: pae380b4d.init
        // call: p21c2eb74.getN
        // call: p1235ff36.getParameters
        // call: InvalidKeyException.<init>
        // call: System.Numerics.BigInteger.bitLength
        // call: p4715f007.<init>
        // call: p37c4833e.m02ea6360
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p60768816.appRandom
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p60768816.fdb56a74d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p60768816.fc10f7796
        // type: InvalidKeyException
        // type: p4715f007
    }

    private void EngineInitVerify(PublicKey P0)
    {
        // str: "cannot recognise key type in ECGOST-2012-256 signer"
        // str: "key out of range for ECGOST-2012-256"
        // call: PublicKey.getEncoded
        // call: p3cdccfc9.m8bab0102
        // call: p63d19d11.m1367c17c
        // call: p37c4833e.mc2499d21
        // call: pe5cfc515.reset
        // call: p1235ff36.getParameters
        // call: p21c2eb74.getN
        // call: InvalidKeyException.<init>
        // call: System.Numerics.BigInteger.bitLength
        // call: pae380b4d.init
        // call: p60768816.mc2499d21
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p60768816.fdb56a74d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p60768816.fc10f7796
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
        // call: pe5cfc515.doFinal
        // call: pae380b4d.generateSignature
        // call: System.Numerics.BigInteger.toByteArray
        // call: System.arraycopy
        // call: pe5cfc515.getDigestSize
        // call: SignatureException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p60768816.fc10f7796
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p60768816.ff7bd60b7
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p60768816.fdb56a74d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p60768816.ffa63da8e
        // type: SignatureException
        return default!;
    }

    private void EngineUpdate(byte P0)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p60768816.fc10f7796
    }

    private void EngineUpdate(byte[] P0, int P1, int P2)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p60768816.fc10f7796
    }

    private bool EngineVerify(byte[] P0)
    {
        // str: "error decoding signature bytes."
        // call: pe5cfc515.getDigestSize
        // call: pe5cfc515.doFinal
        // call: System.arraycopy
        // call: System.Numerics.BigInteger.<init>
        // call: pae380b4d.verifySignature
        // call: SignatureException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p60768816.ffa63da8e
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p60768816.fc10f7796
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p60768816.fdb56a74d
        // type: SignatureException
        // type: System.Numerics.BigInteger
        return false;
    }

}
