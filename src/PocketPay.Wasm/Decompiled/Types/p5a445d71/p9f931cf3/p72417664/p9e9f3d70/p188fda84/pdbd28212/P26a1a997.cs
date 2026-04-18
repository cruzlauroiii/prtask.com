namespace WillowMaze.Wasm.Decompiled;

public class P26a1a997 : SignatureSpi
{
    private static byte[] F585c02fd;
    private static byte[] F6872d72b;
    private static byte[] F6c67955e;
    private static byte[] Fa5e896eb;
    private pd1977c1b F5c08a622;
    private pd1977c1b F80c9f1f0;
    private readonly string F87059776;
    private pd1977c1b Fba38d884;
    private readonly string Fc5728259;
    private pd1977c1b Fd6663514;
    private pd1977c1b Fdb56a74d;
    private readonly string Fed469618;

    private static pcfffbc4a M5e287205(Key P0)
    {
        // str: "cannot identify EdDSA public key"
        // call: p92e3c408.engineGetKeyParameters
        // call: InvalidKeyException.<init>
        // type: InvalidKeyException
        return default!;
    }

    private pd1977c1b Mb423450a(string P0)
    {
        // str: "inappropriate key for "
        // str: "1a071b98dec77a8e3761f10444eaca0560de9de39b121a5cab33650039e7e3a47a"
        // call: StringBuilder.toString
        // call: DecryptString.decryptString
        // call: InvalidKeyException.<init>
        // call: StringBuilder.append
        // call: string.equals
        // call: pd28dc116.<init>
        // call: StringBuilder.<init>
        // call: pbc7d2a82.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p26a1a997.fa5e896eb
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p26a1a997.fed469618
        // type: pbc7d2a82
        // type: StringBuilder
        // type: pd28dc116
        // type: InvalidKeyException
        return default!;
    }

    private static pcfffbc4a Mbbd91822(Key P0)
    {
        // str: "cannot identify EdDSA private key"
        // call: p7f2344f9.engineGetKeyParameters
        // call: InvalidKeyException.<init>
        // type: InvalidKeyException
        return default!;
    }

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
        // str: "2ef3c5cea378d4fed2b42d464d8baf9fd15f988f797d24b9b863caeec4548092222a63"
        // str: "unsupported private key type"
        // str: "2b1da0194c8a985c79764686fc462519b9f5c311cd61b0c9db360e8114f926940e"
        // call: p26a1a997.mb423450a
        // call: DecryptString.decryptString
        // call: p26a1a997.mbbd91822
        // call: pd1977c1b.init
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p26a1a997.fdb56a74d
        // type: IllegalStateException
    }

    private void EngineInitVerify(PublicKey P0)
    {
        // str: "unsupported public key type"
        // str: "de6b0ebe9c6b7eba8a10148f2c8bbf9bfc43587977f8a7ebd2c6b36956a58a686c"
        // str: "b0c0477fc637da9f1df5271bc8c906a11af8689c108c5120b7483eb9ddc56ba2240a2b"
        // call: IllegalStateException.<init>
        // call: DecryptString.decryptString
        // call: p26a1a997.mb423450a
        // call: p26a1a997.m5e287205
        // call: pd1977c1b.init
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p26a1a997.fdb56a74d
        // type: IllegalStateException
    }

    private void EngineSetParameter(string P0, object P1)
    {
        // str: "engineSetParameter unsupported"
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
    }

    private byte[] EngineSign()
    {
        // call: pd1977c1b.generateSignature
        // call: p48d8e57f.getMessage
        // call: SignatureException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p26a1a997.fdb56a74d
        // type: SignatureException
        return default!;
    }

    private void EngineUpdate(byte P0)
    {
        // call: pd1977c1b.update
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p26a1a997.fdb56a74d
    }

    private void EngineUpdate(byte[] P0, int P1, int P2)
    {
        // call: pd1977c1b.update
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p26a1a997.fdb56a74d
    }

    private bool EngineVerify(byte[] P0)
    {
        // call: pd1977c1b.verifySignature
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p26a1a997.fdb56a74d
        return false;
    }

}
