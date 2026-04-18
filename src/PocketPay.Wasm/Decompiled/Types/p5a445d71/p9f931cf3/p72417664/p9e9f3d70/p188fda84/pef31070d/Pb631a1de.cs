namespace WillowMaze.Wasm.Decompiled;

public class Pb631a1de : SignatureSpi
{
    private pe2c0fb97 F167319e0;
    private pe2c0fb97 F7c2c00fc;
    private pe2c0fb97 Fdb56a74d;

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
        // call: pe2c0fb97.init
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pb631a1de.fdb56a74d
    }

    private void EngineInitVerify(PublicKey P0)
    {
        // call: pe2c0fb97.init
        // call: pf3488fc4.mc2499d21
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pb631a1de.fdb56a74d
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
        // call: pe2c0fb97.generateSignature
        // call: Exception.toString
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pb631a1de.fdb56a74d
        // type: SignatureException
        return default!;
    }

    private void EngineUpdate(byte P0)
    {
        // call: pe2c0fb97.update
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pb631a1de.fdb56a74d
    }

    private void EngineUpdate(byte[] P0, int P1, int P2)
    {
        // call: pe2c0fb97.update
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pb631a1de.fdb56a74d
    }

    private bool EngineVerify(byte[] P0)
    {
        // call: pe2c0fb97.verifySignature
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pb631a1de.fdb56a74d
        return false;
    }

}
