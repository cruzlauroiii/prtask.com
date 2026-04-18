namespace WillowMaze.Wasm.Decompiled;

public class P23638c61 : SignatureSpi
{
    private readonly pb3b7fb02 F1d987523;
    private p66e08786 F1fde040b;
    private AlgorithmParameters F20c904fb;
    private p66e08786 F303fde02;
    private AlgorithmParameters F509a9e5d;
    private readonly pb3b7fb02 F81e0dee8;
    private readonly p4942c8b7 F8d4d414e;
    private AlgorithmParameters Fa564b737;
    private AlgorithmParameters Fb6981c90;
    private readonly pb3b7fb02 Fc3ab12ec;
    private readonly p4942c8b7 Fc9487809;
    private readonly p4942c8b7 Fdb56a74d;
    private p66e08786 Fe339fd5d;
    private readonly p4942c8b7 Ff1b16c1c;
    private AlgorithmParameters Ffbc745bd;
    private readonly pb3b7fb02 Ffde5d67b;

    private object EngineGetParameter(string P0)
    {
        // str: "engineGetParameter unsupported"
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
        return default!;
    }

    private AlgorithmParameters EngineGetParameters()
    {
        // str: "PSS"
        // call: pb3b7fb02.createAlgorithmParameters
        // call: AlgorithmParameters.init
        // call: Exception.<init>
        // call: Exception.toString
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p23638c61.ffde5d67b
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p23638c61.f20c904fb
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p23638c61.f303fde02
        // type: Exception
        return default!;
    }

    private void EngineInitSign(PrivateKey P0)
    {
        // call: p4942c8b7.init
        // call: p37c4833e.m02ea6360
        // call: p66e08786.getID
        // call: pdf34a1dd.<init>
        // call: p4715f007.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p23638c61.fdb56a74d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p23638c61.appRandom
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p23638c61.f303fde02
        // type: pdf34a1dd
        // type: p4715f007
    }

    private void EngineInitVerify(PublicKey P0)
    {
        // call: pdf34a1dd.<init>
        // call: p4942c8b7.init
        // call: p1fb7a8a1.mc2499d21
        // call: p66e08786.getID
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p23638c61.fdb56a74d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p23638c61.f303fde02
        // type: pdf34a1dd
    }

    private void EngineSetParameter(string P0, object P1)
    {
        // str: "engineSetParameter unsupported"
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
    }

    private void EngineSetParameter(AlgorithmParameterSpec P0)
    {
        // str: "only SM2ParameterSpec supported"
        // call: InvalidAlgorithmParameterException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p23638c61.f303fde02
        // type: InvalidAlgorithmParameterException
    }

    private byte[] EngineSign()
    {
        // str: "unable to create signature: "
        // call: SignatureException.<init>
        // call: p4942c8b7.generateSignature
        // call: p48d8e57f.getMessage
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p23638c61.fdb56a74d
        // type: SignatureException
        // type: StringBuilder
        return default!;
    }

    private void EngineUpdate(byte P0)
    {
        // call: p4942c8b7.update
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p23638c61.fdb56a74d
    }

    private void EngineUpdate(byte[] P0, int P1, int P2)
    {
        // call: p4942c8b7.update
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p23638c61.fdb56a74d
    }

    private bool EngineVerify(byte[] P0)
    {
        // call: p4942c8b7.verifySignature
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p23638c61.fdb56a74d
        return false;
    }

}
