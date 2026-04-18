namespace WillowMaze.Wasm.Decompiled;

public class Pff72be26
{
    public static p364bf33a[] F7f90ebf3;
    public static p364bf33a[] F9992f3eb;

    public static pcfffbc4a M02ea6360(PrivateKey P0)
    {
        // str: "can't identify DSA private key."
        // call: InvalidKeyException.<init>
        // call: DSAPrivateKey.getParams
        // call: DSAPrivateKey.getX
        // call: DSAParams.getQ
        // call: pe0946edd.<init>
        // call: DSAParams.getP
        // call: DSAParams.getG
        // call: pacb8a170.<init>
        // type: pacb8a170
        // type: InvalidKeyException
        // type: pe0946edd
        return default!;
    }

    public static bool M0b4dfdc0(p364bf33a P0)
    {
        // call: p364bf33a.equals
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pff72be26.f9992f3eb
        return false;
    }

    private static string M718ba5d4(System.Numerics.BigInteger P0, DSAParams P1)
    {
        // call: System.Numerics.BigInteger.toByteArray
        // call: p536c0c9b.<init>
        // call: p536c0c9b.toString
        // call: pff43b8de.md844b504
        // call: DSAParams.getP
        // call: DSAParams.getG
        // call: DSAParams.getQ
        // type: p536c0c9b
        return string.Empty;
    }

    public static pcfffbc4a Mc2499d21(PublicKey P0)
    {
        // str: "can't identify DSA public key: "
        // call: PublicKey.getEncoded
        // call: p3cdccfc9.m8bab0102
        // call: p84e9a1d3.<init>
        // call: p84e9a1d3.engineGetKeyParameters
        // call: StringBuilder.<init>
        // call: Type.getName
        // call: StringBuilder.append
        // call: InvalidKeyException.<init>
        // call: StringBuilder.toString
        // call: object.getClass
        // type: p84e9a1d3
        // type: StringBuilder
        // type: InvalidKeyException
        return default!;
    }

    private static pe0946edd Md905cd57(DSAParams P0)
    {
        // call: DSAParams.getG
        // call: DSAParams.getQ
        // call: DSAParams.getP
        // call: pe0946edd.<init>
        // type: pe0946edd
        return default!;
    }

}
