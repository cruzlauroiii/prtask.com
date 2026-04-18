namespace WillowMaze.Wasm.Decompiled;

public class P2ea986bb
{
    private p8e179b6d F091b7e9e;
    private p234a7530 F0b499025;
    private string F0c3d482a;
    private string F1e7609bc;
    private p234a7530 F40fd6aa3;
    private p8e179b6d F41451554;
    private p234a7530 F4ddf4fb6;
    private p8e179b6d F4f0d65e6;
    private readonly pc1bfd7d6 F542559cf;
    private p8e179b6d F6ceb1e5e;
    private readonly pb3b7fb02 F723435f3;
    private readonly pb3b7fb02 F8ac132df;
    private string Fa8149da9;
    private string Fa8ef9cd1;
    private p364bf33a Fab69b999;
    private readonly pc1bfd7d6 Faeaf11bd;
    private p364bf33a Fb0a16070;
    private readonly pc1bfd7d6 Fb8d2c99a;
    private readonly pb3b7fb02 Fc5f7a23a;
    private readonly pc1bfd7d6 Fd40019d1;
    private p8e179b6d Fd58d1e80;
    private readonly pb3b7fb02 Fd6ca6106;
    private readonly pc1bfd7d6 Fe2e27430;
    private p364bf33a Fe84c87ff;
    private readonly pb3b7fb02 Fef588c92;
    private string Ff181a8e9;

    private X509Certificate Mff2c9a73(p8420911c P0, byte[] P1)
    {
        // str: "exception producing certificate object"
        // str: "c1e920dc348c3190f341b358621440de540ac7aee2f179efdc5347b79d65cb"
        // call: pd6ccb7fc.add
        // call: pb840b7ef.<init>
        // call: DecryptString.decryptString
        // call: pb840b7ef.getEncoded
        // call: MemoryStream.<init>
        // call: pc1bfd7d6.engineGenerateCertificate
        // call: p1522cc54.<init>
        // call: pd6ccb7fc.<init>
        // call: p59cc75e6.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.p2ea986bb.f4ddf4fb6
        // field: p5a445d71.p9f931cf3.pdacfecb5.p2ea986bb.faeaf11bd
        // type: p59cc75e6
        // type: pd6ccb7fc
        // type: p1522cc54
        // type: MemoryStream
        // type: pb840b7ef
        return default!;
    }

    public X509Certificate Generate(PrivateKey P0)
    {
        // call: p2ea986bb.generate
        return default!;
    }

    public X509Certificate Generate(PrivateKey P0, string P1)
    {
        // call: p2ea986bb.generate
        return default!;
    }

    public X509Certificate Generate(PrivateKey P0, string P1, System.Security.Cryptography.RandomNumberGenerator P2)
    {
        // str: "exception encoding TBS cert"
        // call: p8e179b6d.generateTBSCertificate
        // call: pbdeb4310.ma899ffcb
        // call: p2ea986bb.mff2c9a73
        // call: p59cc75e6.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.p2ea986bb.fb0a16070
        // field: p5a445d71.p9f931cf3.pdacfecb5.p2ea986bb.f0c3d482a
        // field: p5a445d71.p9f931cf3.pdacfecb5.p2ea986bb.f4f0d65e6
        // type: p59cc75e6
        return default!;
    }

    public X509Certificate Generate(PrivateKey P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "exception encoding TBS cert"
        // call: p8e179b6d.generateTBSCertificate
        // call: pbdeb4310.ma899ffcb
        // call: p59cc75e6.<init>
        // call: p2ea986bb.mff2c9a73
        // field: p5a445d71.p9f931cf3.pdacfecb5.p2ea986bb.f4f0d65e6
        // field: p5a445d71.p9f931cf3.pdacfecb5.p2ea986bb.fb0a16070
        // field: p5a445d71.p9f931cf3.pdacfecb5.p2ea986bb.f0c3d482a
        // type: p59cc75e6
        return default!;
    }

    public X509Certificate GenerateX509Certificate(PrivateKey P0)
    {
        // str: "BC provider not installed!"
        // str: "2ab784f96ee430f0f27a6a95f32e9aea5bec34ab13340cf1b07c065c5297"
        // call: SecurityException.<init>
        // call: DecryptString.decryptString
        // call: p2ea986bb.generateX509Certificate
        // type: SecurityException
        return default!;
    }

    public X509Certificate GenerateX509Certificate(PrivateKey P0, string P1)
    {
        // call: p2ea986bb.generateX509Certificate
        return default!;
    }

    public X509Certificate GenerateX509Certificate(PrivateKey P0, string P1, System.Security.Cryptography.RandomNumberGenerator P2)
    {
        // str: "exception: "
        // call: SecurityException.<init>
        // call: StringBuilder.<init>
        // call: p2ea986bb.generate
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // type: SecurityException
        // type: StringBuilder
        return default!;
    }

    public X509Certificate GenerateX509Certificate(PrivateKey P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "BC provider not installed!"
        // str: "3066de328aff314c28a41e66c82258083db7efe172848a39424c975355c6"
        // call: DecryptString.decryptString
        // call: p2ea986bb.generateX509Certificate
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
        // call: p8e179b6d.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.p2ea986bb.f4f0d65e6
        // type: p8e179b6d
    }

    public void SetIssuerDN(X500Principal P0)
    {
        // str: "can't process principal: "
        // call: StringBuilder.<init>
        // call: X500Principal.getEncoded
        // call: pe2c8c969.<init>
        // call: p8e179b6d.setIssuer
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // field: p5a445d71.p9f931cf3.pdacfecb5.p2ea986bb.f4f0d65e6
        // type: pe2c8c969
        // type: StringBuilder
        // type: IllegalArgumentException
    }

    public void SetIssuerDN(p22ab0bb1 P0)
    {
        // call: p8e179b6d.setIssuer
        // field: p5a445d71.p9f931cf3.pdacfecb5.p2ea986bb.f4f0d65e6
    }

    public void SetNotAfter(DateTime P0)
    {
        // call: pa76d4ef5.<init>
        // call: p8e179b6d.setEndDate
        // field: p5a445d71.p9f931cf3.pdacfecb5.p2ea986bb.f4f0d65e6
        // type: pa76d4ef5
    }

    public void SetNotBefore(DateTime P0)
    {
        // call: p8e179b6d.setStartDate
        // call: pa76d4ef5.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.p2ea986bb.f4f0d65e6
        // type: pa76d4ef5
    }

    public void SetPublicKey(PublicKey P0)
    {
        // str: "unable to process key - "
        // call: StringBuilder.<init>
        // call: Exception.toString
        // call: StringBuilder.toString
        // call: IllegalArgumentException.<init>
        // call: PublicKey.getEncoded
        // call: p3cdccfc9.m8bab0102
        // call: p8e179b6d.setSubjectPublicKeyInfo
        // call: StringBuilder.append
        // field: p5a445d71.p9f931cf3.pdacfecb5.p2ea986bb.f4f0d65e6
        // type: StringBuilder
        // type: IllegalArgumentException
    }

    public void SetSerialNumber(System.Numerics.BigInteger P0)
    {
        // str: "serial number must be a positive integer"
        // call: pf391b73d.<init>
        // call: p8e179b6d.setSerialNumber
        // call: System.Numerics.BigInteger.compareTo
        // call: IllegalArgumentException.<init>
        // field: java.math.BigInteger.ZERO
        // field: p5a445d71.p9f931cf3.pdacfecb5.p2ea986bb.f4f0d65e6
        // type: IllegalArgumentException
        // type: pf391b73d
    }

    public void SetSignatureAlgorithm(string P0)
    {
        // str: "Unknown signature type requested"
        // call: pbdeb4310.me47e5a52
        // call: IllegalArgumentException.<init>
        // call: pbdeb4310.m55c09d0e
        // call: p8e179b6d.setSignature
        // field: p5a445d71.p9f931cf3.pdacfecb5.p2ea986bb.f4ddf4fb6
        // field: p5a445d71.p9f931cf3.pdacfecb5.p2ea986bb.f0c3d482a
        // field: p5a445d71.p9f931cf3.pdacfecb5.p2ea986bb.fb0a16070
        // field: p5a445d71.p9f931cf3.pdacfecb5.p2ea986bb.f4f0d65e6
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
        // call: p8e179b6d.setSubject
        // call: StringBuilder.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.p2ea986bb.f4f0d65e6
        // type: pe2c8c969
        // type: IllegalArgumentException
        // type: StringBuilder
    }

    public void SetSubjectDN(p22ab0bb1 P0)
    {
        // call: p8e179b6d.setSubject
        // field: p5a445d71.p9f931cf3.pdacfecb5.p2ea986bb.f4f0d65e6
    }

}
