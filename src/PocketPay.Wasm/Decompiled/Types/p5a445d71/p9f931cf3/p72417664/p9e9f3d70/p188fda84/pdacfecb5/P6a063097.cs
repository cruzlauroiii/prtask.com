namespace WillowMaze.Wasm.Decompiled;

public class P6a063097 : Pe5c9818a, Pc7effecb
{
    private PublicKey F047b2b56;
    private p510a4454 F1751642c;
    private bool F1a74383f;
    private int F1dfa5bfa;
    private pc7effecb F201da641;
    private X500Principal F22e12151;
    private long[] F2a70cc83;
    private X500Principal F33ddd61f;
    private long[] F35cdadcd;
    private p510a4454 F3983bfb6;
    private int F491de0d7;
    private X500Principal F50bd04fa;
    private readonly object F574c04d3;
    private PublicKey F608a7a0d;
    private long[] F6625c008;
    private readonly object F684ece30;
    private pc7effecb F68622eef;
    private p510a4454 F6c90e3fe;
    private readonly object F85864305;
    private int F89e25c8a;
    private bool F93b0200a;
    private bool F9f651ec5;
    private readonly object Fa19d97df;
    private int Fa4069d38;
    private pc7effecb Fc1aa0632;
    private p510a4454 Fcac9c5d9;
    private pc7effecb Fdf4b272d;
    private bool Fe2011431;
    private X500Principal Ff125dffb;
    private readonly object Ffc505465;

    private static bool[] M0354c228(peb0f48a1 P0)
    {
        // str: "2.5.29.15"
        // str: "cannot construct KeyUsage: "
        // call: p6a063097.getExtensionOctets
        // call: p301c7ed4.m89e75c46
        // call: p1522cc54.m8bab0102
        // call: p29d19857.getBytes
        // call: p29d19857.getPadBits
        // call: CertificateParsingException.<init>
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // type: CertificateParsingException
        // type: StringBuilder
        return default!;
    }

    private static p44f86c11 M149188ef(peb0f48a1 P0)
    {
        // str: "cannot construct BasicConstraints: "
        // str: "2.5.29.19"
        // call: CertificateParsingException.<init>
        // call: StringBuilder.toString
        // call: p6a063097.getExtensionOctets
        // call: p301c7ed4.m89e75c46
        // call: p44f86c11.m8bab0102
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // type: CertificateParsingException
        // type: StringBuilder
        return default!;
    }

    private p510a4454 M3ff6ddc5()
    {
        // str: "ffdda26cedc437534c55ee9300d68a8f5d9e4f2e8e8ce7e8e3537573c564c8"
        // call: p6a063097$p3393e2e6.<init>
        // call: DecryptString.decryptString
        // call: peb0f48a1.getEncoded
        // call: p510a4454.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097.f8966d166
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097.fcac9c5d9
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097.f723435f3
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097.f684ece30
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097.f2505866c
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097.fd5edbddb
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097.f4a8a08f0
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097.fdfef16e0
        // type: p510a4454
        // type: p6a063097$p3393e2e6
        return default!;
    }

    private static string M83af66ea(peb0f48a1 P0)
    {
        // str: "cannot construct SigAlgName: "
        // call: StringBuilder.toString
        // call: CertificateParsingException.<init>
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: peb0f48a1.getSignatureAlgorithm
        // call: p63daa24a.m6d7cc104
        // type: CertificateParsingException
        // type: StringBuilder
        return string.Empty;
    }

    private static byte[] Mbabc5ce6(peb0f48a1 P0)
    {
        // str: "04fd2c49aa53b66f7282b937adbfd10638ba1e1af688dc3bcd958948d3fa1f"
        // str: "cannot construct SigAlgParams: "
        // call: StringBuilder.<init>
        // call: peb0f48a1.getSignatureAlgorithm
        // call: p234a7530.getParameters
        // call: p0fd1bdf1.toASN1Primitive
        // call: DecryptString.decryptString
        // call: p301c7ed4.getEncoded
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: CertificateParsingException.<init>
        // type: StringBuilder
        // type: CertificateParsingException
        return default!;
    }

    public void CheckValidity(DateTime P0)
    {
        // str: "certificate expired on "
        // str: "certificate not valid till "
        // call: p6a063097.getValidityValues
        // call: peb0f48a1.getEndDate
        // call: StringBuilder.append
        // call: pa76d4ef5.getTime
        // call: CertificateExpiredException.<init>
        // call: DateTime.getTime
        // call: StringBuilder.toString
        // call: peb0f48a1.getStartDate
        // call: StringBuilder.<init>
        // call: CertificateNotYetValidException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097.f4a8a08f0
        // type: CertificateExpiredException
        // type: StringBuilder
        // type: CertificateNotYetValidException
    }

    public bool Equals(object P0)
    {
        // call: p6a063097.m3ff6ddc5
        // call: p510a4454.equals
        // call: p29d19857.equals
        // call: peb0f48a1.getSignature
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097.f491de0d7
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097.fe2011431
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097.f4a8a08f0
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097.fcac9c5d9
        return false;
    }

    public p0fd1bdf1 GetBagAttribute(p364bf33a P0)
    {
        // call: pc7effecb.getBagAttribute
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097.f201da641
        return default!;
    }

    public Enumeration GetBagAttributeKeys()
    {
        // call: pc7effecb.getBagAttributeKeys
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097.f201da641
        return default!;
    }

    public byte[] GetEncoded()
    {
        // call: pff43b8de.md329fd77
        // call: p6a063097.m3ff6ddc5
        // call: p510a4454.getEncoded
        return default!;
    }

    public X500Principal GetIssuerX500Principal()
    {
        // call: pe5c9818a.getIssuerX500Principal
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097.f684ece30
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097.f33ddd61f
        return default!;
    }

    public PublicKey GetPublicKey()
    {
        // call: pe5c9818a.getPublicKey
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097.f047b2b56
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097.f684ece30
        return default!;
    }

    public X500Principal GetSubjectX500Principal()
    {
        // call: pe5c9818a.getSubjectX500Principal
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097.f684ece30
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097.f50bd04fa
        return default!;
    }

    public long[] GetValidityValues()
    {
        // call: DateTime.getTime
        // call: pe5c9818a.getNotAfter
        // call: pe5c9818a.getNotBefore
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097.f6625c008
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097.f684ece30
        return default!;
    }

    public int HashCode()
    {
        // call: p6a063097.m3ff6ddc5
        // call: p510a4454.hashCode
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097.f491de0d7
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097.fe2011431
        return 0;
    }

    public int OriginalHashCode()
    {
        // call: p6a063097.m3ff6ddc5
        // call: p510a4454.getEncoded
        return 0;
    }

    public void SetBagAttribute(p364bf33a P0, p0fd1bdf1 P1)
    {
        // call: pc7effecb.setBagAttribute
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097.f201da641
    }

}
