namespace WillowMaze.Wasm.Decompiled;

public abstract class P93c606b8 : SignatureSpi, P03c3d84c, P756b0dc3
{
    private pae380b4d F0d357d31;
    private pae380b4d F15360c6e;
    private pe5cfc515 F400bd658;
    private pe5cfc515 F44d0d17a;
    private pa8ad1191 F4bca121a;
    private pe5cfc515 F584e656a;
    private pae380b4d F61bebf21;
    private pa8ad1191 F84bea1f0;
    private pa8ad1191 F886c9c50;
    private pa8ad1191 Fa4a82a74;
    private pe5cfc515 Fc10f7796;
    private pae380b4d Fdb56a74d;
    private pae380b4d Fdf2c34cb;
    private pe5cfc515 Fe2911a31;

    private object EngineGetParameter(string P0)
    {
        // str: "engineSetParameter unsupported"
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
        return default!;
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
        // call: Exception.toString
        // call: pe5cfc515.getDigestSize
        // call: pe5cfc515.doFinal
        // call: pae380b4d.generateSignature
        // call: pae380b4d.getOrder
        // call: pa8ad1191.encode
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p93c606b8.fc10f7796
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p93c606b8.fdb56a74d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p93c606b8.f84bea1f0
        // type: SignatureException
        return default!;
    }

    private void EngineUpdate(byte P0)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p93c606b8.fc10f7796
    }

    private void EngineUpdate(byte[] P0, int P1, int P2)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p93c606b8.fc10f7796
    }

    private bool EngineVerify(byte[] P0)
    {
        // str: "error decoding signature bytes."
        // call: pe5cfc515.doFinal
        // call: pae380b4d.getOrder
        // call: pa8ad1191.decode
        // call: pae380b4d.verifySignature
        // call: pe5cfc515.getDigestSize
        // call: SignatureException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p93c606b8.f84bea1f0
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p93c606b8.fdb56a74d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p93c606b8.fc10f7796
        // type: SignatureException
        return false;
    }

}
