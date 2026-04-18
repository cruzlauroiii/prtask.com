namespace WillowMaze.Wasm.Decompiled;

public class Pe307c42c : P0b7b2d36
{
    private int F14dbff8f;
    private p7226ba32 F1eec9e2b;
    private bool F265dced1;
    private int F491de0d7;
    private p7226ba32 F51f3874e;
    private readonly object F673aab65;
    private readonly object F684ece30;
    private int F8a6340cc;
    private bool Fab8ecab3;
    private readonly object Fc5254125;
    private readonly object Fdd4f525e;
    private bool Fe2011431;

    private p7226ba32 M21474a8a()
    {
        // str: "ee35a60b716e32a9b32d09ce6d5f4286f4354eeebd5935b1c710df2bc55790"
        // call: pe307c42c$p95ec8069.<init>
        // call: DecryptString.decryptString
        // call: pe7f120ea.getEncoded
        // call: p7226ba32.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe307c42c.f4a8a08f0
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe307c42c.f1eec9e2b
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe307c42c.f684ece30
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe307c42c.f723435f3
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe307c42c.f06d51118
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe307c42c.f2505866c
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe307c42c.fdfef16e0
        // type: pe307c42c$p95ec8069
        // type: p7226ba32
        return default!;
    }

    private static string M83af66ea(pe7f120ea P0)
    {
        // str: "CRL contents invalid: "
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: Exception.getMessage
        // call: pe307c42c$p95ec8069.<init>
        // call: pe7f120ea.getSignatureAlgorithm
        // call: p63daa24a.m6d7cc104
        // type: pe307c42c$p95ec8069
        // type: StringBuilder
        return string.Empty;
    }

    private static bool Ma1dcd3d9(pe7f120ea P0)
    {
        // str: "Exception reading IssuingDistributionPoint"
        // call: p364bf33a.getId
        // call: pe307c42c.getExtensionOctets
        // call: p781d85ab.m8bab0102
        // call: p781d85ab.isIndirectCRL
        // call: pc05b9619.<init>
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f214c30d1
        // type: pc05b9619
        return false;
    }

    private static byte[] Mbabc5ce6(pe7f120ea P0)
    {
        // str: "CRL contents invalid: "
        // str: "29dfeb6bf95c06aea3b3d893b70632a88255169deb8b986a7538b29bf06949"
        // call: StringBuilder.append
        // call: CRLException.<init>
        // call: pe7f120ea.getSignatureAlgorithm
        // call: p234a7530.getParameters
        // call: p0fd1bdf1.toASN1Primitive
        // call: DecryptString.decryptString
        // call: p301c7ed4.getEncoded
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // type: CRLException
        // type: StringBuilder
        return default!;
    }

    public bool Equals(object P0)
    {
        // call: pe307c42c.m21474a8a
        // call: p7226ba32.equals
        // call: pe7f120ea.getSignature
        // call: p29d19857.equals
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe307c42c.f1eec9e2b
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe307c42c.fe2011431
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe307c42c.f4a8a08f0
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe307c42c.f491de0d7
        return false;
    }

    public byte[] GetEncoded()
    {
        // call: pff43b8de.md329fd77
        // call: pe307c42c.m21474a8a
        // call: p7226ba32.getEncoded
        return default!;
    }

    public int HashCode()
    {
        // call: p7226ba32.hashCode
        // call: pe307c42c.m21474a8a
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe307c42c.f491de0d7
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe307c42c.fe2011431
        return 0;
    }

}
