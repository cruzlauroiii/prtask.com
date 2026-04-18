namespace WillowMaze.Wasm.Decompiled;

public class P85d33963 : SignatureSpi, P03c3d84c, P756b0dc3
{
    private pae380b4d F0d113c4a;
    private pe5cfc515 F135bc2a9;
    private pa8ad1191 F2059e15f;
    private pae380b4d F28fb9739;
    private pae380b4d F34b83328;
    private pa8ad1191 F583532c7;
    private System.Security.Cryptography.RandomNumberGenerator F6fd7ff20;
    private pa8ad1191 F78ceb7d1;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private pa8ad1191 F84bea1f0;
    private pe5cfc515 Fba7d20d1;
    private pe5cfc515 Fc10f7796;
    private pa8ad1191 Fce43b2ad;
    private pae380b4d Fdb56a74d;

    private object EngineGetParameter(string P0)
    {
        // str: "engineGetParameter unsupported"
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
        // call: pae380b4d.init
        // call: p4715f007.<init>
        // call: pe5cfc515.reset
        // call: pff72be26.m02ea6360
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p85d33963.fdb56a74d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p85d33963.f7ddf32e1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p85d33963.fc10f7796
        // type: p4715f007
    }

    private void EngineInitSign(PrivateKey P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // call: p85d33963.engineInitSign
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p85d33963.f7ddf32e1
    }

    private void EngineInitVerify(PublicKey P0)
    {
        // call: pae380b4d.init
        // call: pff72be26.mc2499d21
        // call: pe5cfc515.reset
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p85d33963.fc10f7796
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p85d33963.fdb56a74d
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
        // call: pae380b4d.getOrder
        // call: pa8ad1191.encode
        // call: SignatureException.<init>
        // call: pe5cfc515.getDigestSize
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p85d33963.fc10f7796
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p85d33963.fdb56a74d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p85d33963.f84bea1f0
        // type: SignatureException
        return default!;
    }

    private void EngineUpdate(byte P0)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p85d33963.fc10f7796
    }

    private void EngineUpdate(byte[] P0, int P1, int P2)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p85d33963.fc10f7796
    }

    private bool EngineVerify(byte[] P0)
    {
        // str: "error decoding signature bytes."
        // call: pae380b4d.verifySignature
        // call: pe5cfc515.getDigestSize
        // call: SignatureException.<init>
        // call: pe5cfc515.doFinal
        // call: pae380b4d.getOrder
        // call: pa8ad1191.decode
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p85d33963.fdb56a74d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p85d33963.f84bea1f0
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p85d33963.fc10f7796
        // type: SignatureException
        return false;
    }

}
