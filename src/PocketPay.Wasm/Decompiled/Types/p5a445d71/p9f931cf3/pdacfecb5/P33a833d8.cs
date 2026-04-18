namespace WillowMaze.Wasm.Decompiled;

public class P33a833d8
{
    private string F0c3d482a;
    private p364bf33a F177454c3;
    private string F1aafc666;
    private p364bf33a F1b026454;
    private p67cc0eb6 F205c7c8a;
    private p67cc0eb6 F211abb1e;
    private p234a7530 F21cffe5d;
    private p67cc0eb6 F2666acb5;
    private p364bf33a F4d1b7e57;
    private p234a7530 F4ddf4fb6;
    private p750f32f9 F4f0d65e6;
    private readonly pc1bfd7d6 F5df9c6b9;
    private readonly pb3b7fb02 F723435f3;
    private p67cc0eb6 F81f9d3f0;
    private p234a7530 F8bed30e5;
    private readonly pc1bfd7d6 Fa72b2d43;
    private readonly pc1bfd7d6 Faeaf11bd;
    private p364bf33a Fb0a16070;
    private p750f32f9 Fd003bc62;
    private readonly pb3b7fb02 Fd3b7d13a;
    private string Fe5f89b07;
    private p67cc0eb6 Fe6634c46;

    private p8420911c M198da49a()
    {
        // call: p67cc0eb6.isEmpty
        // call: p67cc0eb6.generate
        // call: p750f32f9.setExtensions
        // call: p750f32f9.generateTBSCertificate
        // field: p5a445d71.p9f931cf3.pdacfecb5.p33a833d8.f4f0d65e6
        // field: p5a445d71.p9f931cf3.pdacfecb5.p33a833d8.f211abb1e
        return default!;
    }

    private p1522cc54 M37af9c40(bool[] P0)
    {
        // call: p1522cc54.<init>
        // type: p1522cc54
        return default!;
    }

    private X509Certificate Mff2c9a73(p8420911c P0, byte[] P1)
    {
        // str: "d269bda96910f2be86186a56c2a9109dc3191e847f40cb98657c64367a5e9e"
        // call: pb840b7ef.<init>
        // call: pb840b7ef.getEncoded
        // call: DecryptString.decryptString
        // call: pd6ccb7fc.<init>
        // call: pd6ccb7fc.add
        // call: p1522cc54.<init>
        // call: MemoryStream.<init>
        // call: pc1bfd7d6.engineGenerateCertificate
        // field: p5a445d71.p9f931cf3.pdacfecb5.p33a833d8.faeaf11bd
        // field: p5a445d71.p9f931cf3.pdacfecb5.p33a833d8.f4ddf4fb6
        // type: pd6ccb7fc
        // type: p1522cc54
        // type: pb840b7ef
        // type: MemoryStream
        return default!;
    }

    public void AddExtension(string P0, bool P1, p0fd1bdf1 P2)
    {
        // call: p364bf33a.<init>
        // call: p33a833d8.addExtension
        // type: p364bf33a
    }

    public void AddExtension(string P0, bool P1, byte[] P2)
    {
        // call: p364bf33a.<init>
        // call: p33a833d8.addExtension
        // type: p364bf33a
    }

    public void AddExtension(p364bf33a P0, bool P1, p0fd1bdf1 P2)
    {
        // call: p364bf33a.getId
        // call: p67cc0eb6.addExtension
        // call: p364bf33a.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.p33a833d8.f211abb1e
        // type: p364bf33a
    }

    public void AddExtension(p364bf33a P0, bool P1, byte[] P2)
    {
        // call: p364bf33a.getId
        // call: p67cc0eb6.addExtension
        // call: p364bf33a.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.p33a833d8.f211abb1e
        // type: p364bf33a
    }

    public void CopyAndAddExtension(string P0, bool P1, X509Certificate P2)
    {
        // str: "extension "
        // str: " not present"
        // call: StringBuilder.append
        // call: CertificateParsingException.<init>
        // call: StringBuilder.toString
        // call: IOException.toString
        // call: p59853fe6.m2d877539
        // call: p33a833d8.addExtension
        // call: X509Certificate.getExtensionValue
        // call: StringBuilder.<init>
        // type: CertificateParsingException
        // type: StringBuilder
    }

    public void CopyAndAddExtension(p364bf33a P0, bool P1, X509Certificate P2)
    {
        // call: p364bf33a.getId
        // call: p33a833d8.copyAndAddExtension
    }

    public X509Certificate Generate(PrivateKey P0)
    {
        // call: p33a833d8.generate
        return default!;
    }

    public X509Certificate Generate(PrivateKey P0, string P1)
    {
        // call: p33a833d8.generate
        return default!;
    }

    public X509Certificate Generate(PrivateKey P0, string P1, System.Security.Cryptography.RandomNumberGenerator P2)
    {
        // str: "exception encoding TBS cert"
        // str: "exception producing certificate object"
        // call: p33a833d8.m198da49a
        // call: pbdeb4310.ma899ffcb
        // call: p33a833d8.mff2c9a73
        // call: p59cc75e6.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.p33a833d8.fb0a16070
        // field: p5a445d71.p9f931cf3.pdacfecb5.p33a833d8.f0c3d482a
        // type: p59cc75e6
        return default!;
    }

    public X509Certificate Generate(PrivateKey P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "exception producing certificate object"
        // str: "exception encoding TBS cert"
        // call: p33a833d8.m198da49a
        // call: pbdeb4310.ma899ffcb
        // call: p33a833d8.mff2c9a73
        // call: p59cc75e6.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.p33a833d8.fb0a16070
        // field: p5a445d71.p9f931cf3.pdacfecb5.p33a833d8.f0c3d482a
        // type: p59cc75e6
        return default!;
    }

    public X509Certificate GenerateX509Certificate(PrivateKey P0)
    {
        // str: "BC provider not installed!"
        // str: "20d5f70a406fe6abce93dc39ebedfc2a9ffa653495c03bef63ed50b1bb34"
        // call: DecryptString.decryptString
        // call: p33a833d8.generateX509Certificate
        // call: SecurityException.<init>
        // type: SecurityException
        return default!;
    }

    public X509Certificate GenerateX509Certificate(PrivateKey P0, string P1)
    {
        // call: p33a833d8.generateX509Certificate
        return default!;
    }

    public X509Certificate GenerateX509Certificate(PrivateKey P0, string P1, System.Security.Cryptography.RandomNumberGenerator P2)
    {
        // str: "exception: "
        // call: StringBuilder.<init>
        // call: SecurityException.<init>
        // call: StringBuilder.append
        // call: p33a833d8.generate
        // call: StringBuilder.toString
        // type: SecurityException
        // type: StringBuilder
        return default!;
    }

    public X509Certificate GenerateX509Certificate(PrivateKey P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "BC provider not installed!"
        // str: "726a96cb288971dc9d274d2ae3058d65bc2b0a8f2085fc832baf50b19a74"
        // call: DecryptString.decryptString
        // call: p33a833d8.generateX509Certificate
        // call: SecurityException.<init>
        // type: SecurityException
        return default!;
    }

    public IEnumerator<object> GetSignatureAlgNames()
    {
        // call: pbdeb4310.me0ccbc40
        return default!;
    }

    public void Reset()
    {
        // call: p750f32f9.<init>
        // call: p67cc0eb6.reset
        // field: p5a445d71.p9f931cf3.pdacfecb5.p33a833d8.f211abb1e
        // field: p5a445d71.p9f931cf3.pdacfecb5.p33a833d8.f4f0d65e6
        // type: p750f32f9
    }

    public void SetIssuerDN(X500Principal P0)
    {
        // str: "can't process principal: "
        // call: StringBuilder.toString
        // call: X500Principal.getEncoded
        // call: pe2c8c969.<init>
        // call: p750f32f9.setIssuer
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // field: p5a445d71.p9f931cf3.pdacfecb5.p33a833d8.f4f0d65e6
        // type: StringBuilder
        // type: pe2c8c969
        // type: IllegalArgumentException
    }

    public void SetIssuerDN(p22ab0bb1 P0)
    {
        // call: p750f32f9.setIssuer
        // field: p5a445d71.p9f931cf3.pdacfecb5.p33a833d8.f4f0d65e6
    }

    public void SetIssuerUniqueID(bool[] P0)
    {
        // call: p750f32f9.setIssuerUniqueID
        // call: p33a833d8.m37af9c40
        // field: p5a445d71.p9f931cf3.pdacfecb5.p33a833d8.f4f0d65e6
    }

    public void SetNotAfter(DateTime P0)
    {
        // call: p750f32f9.setEndDate
        // call: pa76d4ef5.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.p33a833d8.f4f0d65e6
        // type: pa76d4ef5
    }

    public void SetNotBefore(DateTime P0)
    {
        // call: p750f32f9.setStartDate
        // call: pa76d4ef5.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.p33a833d8.f4f0d65e6
        // type: pa76d4ef5
    }

    public void SetPublicKey(PublicKey P0)
    {
        // str: "unable to process key - "
        // call: Exception.toString
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: IllegalArgumentException.<init>
        // call: PublicKey.getEncoded
        // call: pd1c2953c.<init>
        // call: pd1c2953c.readObject
        // call: p3cdccfc9.m8bab0102
        // call: p750f32f9.setSubjectPublicKeyInfo
        // call: StringBuilder.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.p33a833d8.f4f0d65e6
        // type: StringBuilder
        // type: pd1c2953c
        // type: IllegalArgumentException
    }

    public void SetSerialNumber(System.Numerics.BigInteger P0)
    {
        // str: "serial number must be a positive integer"
        // call: System.Numerics.BigInteger.compareTo
        // call: pf391b73d.<init>
        // call: IllegalArgumentException.<init>
        // call: p750f32f9.setSerialNumber
        // field: p5a445d71.p9f931cf3.pdacfecb5.p33a833d8.f4f0d65e6
        // field: java.math.BigInteger.ZERO
        // type: IllegalArgumentException
        // type: pf391b73d
    }

    public void SetSignatureAlgorithm(string P0)
    {
        // str: "Unknown signature type requested: "
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: pbdeb4310.m55c09d0e
        // call: pbdeb4310.me47e5a52
        // call: IllegalArgumentException.<init>
        // call: p750f32f9.setSignature
        // call: StringBuilder.append
        // field: p5a445d71.p9f931cf3.pdacfecb5.p33a833d8.f4f0d65e6
        // field: p5a445d71.p9f931cf3.pdacfecb5.p33a833d8.f0c3d482a
        // field: p5a445d71.p9f931cf3.pdacfecb5.p33a833d8.fb0a16070
        // field: p5a445d71.p9f931cf3.pdacfecb5.p33a833d8.f4ddf4fb6
        // type: StringBuilder
        // type: IllegalArgumentException
    }

    public void SetSubjectDN(X500Principal P0)
    {
        // str: "can't process principal: "
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: IllegalArgumentException.<init>
        // call: X500Principal.getEncoded
        // call: pe2c8c969.<init>
        // call: p750f32f9.setSubject
        // call: StringBuilder.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.p33a833d8.f4f0d65e6
        // type: IllegalArgumentException
        // type: StringBuilder
        // type: pe2c8c969
    }

    public void SetSubjectDN(p22ab0bb1 P0)
    {
        // call: p750f32f9.setSubject
        // field: p5a445d71.p9f931cf3.pdacfecb5.p33a833d8.f4f0d65e6
    }

    public void SetSubjectUniqueID(bool[] P0)
    {
        // call: p750f32f9.setSubjectUniqueID
        // call: p33a833d8.m37af9c40
        // field: p5a445d71.p9f931cf3.pdacfecb5.p33a833d8.f4f0d65e6
    }

}
