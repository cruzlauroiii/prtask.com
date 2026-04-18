namespace WillowMaze.Wasm.Decompiled;

public class P26a1a997 : SignatureSpi, P03c3d84c, P756b0dc3
{
    private pae380b4d F254e7813;
    private pae380b4d F30fea5ff;
    private pae380b4d F5c6ea950;
    private pe5cfc515 Fc10f7796;
    private pe5cfc515 Fc40b9b67;
    private pae380b4d Fdb56a74d;

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
        // call: pd0c474c0.m743d8c12
        // call: p37c4833e.m02ea6360
        // call: p11735585.<init>
        // call: p26a1a997.expandSbox
        // call: pae380b4d.init
        // call: p4715f007.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p26a1a997.appRandom
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p26a1a997.fdb56a74d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p26a1a997.fc10f7796
        // type: p11735585
        // type: p4715f007
    }

    private void EngineInitVerify(PublicKey P0)
    {
        // call: p75258f69.getSbox
        // call: p11735585.<init>
        // call: pae380b4d.init
        // call: p75258f69.engineGetKeyParameters
        // call: pd0c474c0.m743d8c12
        // call: p26a1a997.expandSbox
        // call: p37c4833e.mc2499d21
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p26a1a997.fc10f7796
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p26a1a997.fdb56a74d
        // type: p11735585
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
        // call: pe5cfc515.getDigestSize
        // call: SignatureException.<init>
        // call: Exception.toString
        // call: pe5cfc515.doFinal
        // call: pae380b4d.generateSignature
        // call: System.Numerics.BigInteger.toByteArray
        // call: System.arraycopy
        // call: p6f0e511c.<init>
        // call: p6f0e511c.getEncoded
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p26a1a997.fc10f7796
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p26a1a997.fdb56a74d
        // type: SignatureException
        // type: p6f0e511c
        return default!;
    }

    private void EngineUpdate(byte P0)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p26a1a997.fc10f7796
    }

    private void EngineUpdate(byte[] P0, int P1, int P2)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p26a1a997.fc10f7796
    }

    private bool EngineVerify(byte[] P0)
    {
        // str: "error decoding signature bytes."
        // call: pae380b4d.verifySignature
        // call: SignatureException.<init>
        // call: pe5cfc515.getDigestSize
        // call: pe5cfc515.doFinal
        // call: p11b04310.fromByteArray
        // call: p11b04310.getOctets
        // call: System.arraycopy
        // call: System.Numerics.BigInteger.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p26a1a997.fc10f7796
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p26a1a997.fdb56a74d
        // type: SignatureException
        // type: System.Numerics.BigInteger
        return false;
    }

    private byte[] ExpandSbox(byte[] P0)
    {
        return default!;
    }

}
