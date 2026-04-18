namespace WillowMaze.Wasm.Decompiled;

public class P18a65ced : SignatureSpi, P03c3d84c, P756b0dc3
{
    private pae380b4d F0cf1049d;
    private pe5cfc515 F59ef9f6a;
    private int F5cb8e83e;
    private int F61545e5c;
    private pe5cfc515 Fae30d7f0;
    private pe5cfc515 Fc10f7796;
    private pae380b4d Fdb56a74d;
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
        // str: "key too weak for ECGOST-2012-512"
        // str: "cannot recognise key type in ECGOST-2012-512 signer"
        // call: System.Numerics.BigInteger.bitLength
        // call: pae380b4d.init
        // call: pe5cfc515.reset
        // call: p4715f007.<init>
        // call: p21c2eb74.getN
        // call: p1235ff36.getParameters
        // call: p37c4833e.m02ea6360
        // call: InvalidKeyException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p18a65ced.fc10f7796
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p18a65ced.appRandom
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p18a65ced.fdb56a74d
        // type: p4715f007
        // type: InvalidKeyException
    }

    private void EngineInitVerify(PublicKey P0)
    {
        // str: "key too weak for ECGOST-2012-512"
        // str: "cannot recognise key type in ECGOST-2012-512 signer"
        // call: pae380b4d.init
        // call: InvalidKeyException.<init>
        // call: p1235ff36.getParameters
        // call: System.Numerics.BigInteger.bitLength
        // call: p21c2eb74.getN
        // call: p18a65ced.mc2499d21
        // call: PublicKey.getEncoded
        // call: p3cdccfc9.m8bab0102
        // call: p63d19d11.m1367c17c
        // call: p37c4833e.mc2499d21
        // call: pe5cfc515.reset
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p18a65ced.fdb56a74d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p18a65ced.fc10f7796
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
        // call: pe5cfc515.getDigestSize
        // call: pe5cfc515.doFinal
        // call: pae380b4d.generateSignature
        // call: System.Numerics.BigInteger.toByteArray
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p18a65ced.fc10f7796
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p18a65ced.ff7bd60b7
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p18a65ced.fdb56a74d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p18a65ced.ffa63da8e
        // type: SignatureException
        return default!;
    }

    private void EngineUpdate(byte P0)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p18a65ced.fc10f7796
    }

    private void EngineUpdate(byte[] P0, int P1, int P2)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p18a65ced.fc10f7796
    }

    private bool EngineVerify(byte[] P0)
    {
        // str: "error decoding signature bytes."
        // call: SignatureException.<init>
        // call: pe5cfc515.doFinal
        // call: System.arraycopy
        // call: System.Numerics.BigInteger.<init>
        // call: pe5cfc515.getDigestSize
        // call: pae380b4d.verifySignature
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p18a65ced.fc10f7796
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p18a65ced.fdb56a74d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p18a65ced.ffa63da8e
        // type: System.Numerics.BigInteger
        // type: SignatureException
        return false;
    }

}
