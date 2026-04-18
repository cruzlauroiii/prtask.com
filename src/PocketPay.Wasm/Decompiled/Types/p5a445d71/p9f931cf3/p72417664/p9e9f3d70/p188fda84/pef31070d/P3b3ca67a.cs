namespace WillowMaze.Wasm.Decompiled;

public class P3b3ca67a : SignatureSpi
{
    private p30f39bc5 Fbf97a783;
    private p30f39bc5 Fdb56a74d;

    private object EngineGetParameter(string P0)
    {
        // str: "engineSetParameter unsupported"
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
        return default!;
    }

    private void EngineInitSign(PrivateKey P0)
    {
        // call: pf3488fc4.m02ea6360
        // call: p30f39bc5.init
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p3b3ca67a.fdb56a74d
    }

    private void EngineInitVerify(PublicKey P0)
    {
        // call: p30f39bc5.init
        // call: pf3488fc4.mc2499d21
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p3b3ca67a.fdb56a74d
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
        // call: p30f39bc5.generateSignature
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p3b3ca67a.fdb56a74d
        // type: SignatureException
        return default!;
    }

    private void EngineUpdate(byte P0)
    {
        // call: p30f39bc5.update
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p3b3ca67a.fdb56a74d
    }

    private void EngineUpdate(byte[] P0, int P1, int P2)
    {
        // call: p30f39bc5.update
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p3b3ca67a.fdb56a74d
    }

    private bool EngineVerify(byte[] P0)
    {
        // call: p30f39bc5.verifySignature
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p3b3ca67a.fdb56a74d
        return false;
    }

}
