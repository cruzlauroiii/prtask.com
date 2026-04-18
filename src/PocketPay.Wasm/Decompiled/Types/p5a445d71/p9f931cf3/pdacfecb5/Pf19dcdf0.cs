namespace WillowMaze.Wasm.Decompiled;

public class Pf19dcdf0
{
    private p234a7530 F0b7cb7ca;
    private string F0c3d482a;
    private p67cc0eb6 F211abb1e;
    private readonly pb3b7fb02 F3903f708;
    private p234a7530 F4ddf4fb6;
    private p8001ce84 F4f0d65e6;
    private p67cc0eb6 F518c552d;
    private p364bf33a F6ce4b77a;
    private readonly pb3b7fb02 F723435f3;
    private p234a7530 Fa1d0c57e;
    private readonly pb3b7fb02 Fa21ff7b4;
    private p364bf33a Fb0a16070;
    private p8001ce84 Fba27904f;
    private string Fbdb3a6e1;
    private p67cc0eb6 Ff063abc9;
    private p67cc0eb6 Ff337b412;

    private p5944520d M7ddfe275()
    {
        // call: p8001ce84.setExtensions
        // call: p67cc0eb6.generate
        // call: p67cc0eb6.isEmpty
        // call: p8001ce84.generateTBSCertList
        // field: p5a445d71.p9f931cf3.pdacfecb5.pf19dcdf0.f4f0d65e6
        // field: p5a445d71.p9f931cf3.pdacfecb5.pf19dcdf0.f211abb1e
        return default!;
    }

    private X509CRL Mff2c9a73(p5944520d P0, byte[] P1)
    {
        // call: pd6ccb7fc.add
        // call: pe7f120ea.m8bab0102
        // call: pd6ccb7fc.<init>
        // call: p1522cc54.<init>
        // call: pb840b7ef.<init>
        // call: pe307c42c.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.pf19dcdf0.f4ddf4fb6
        // type: pe307c42c
        // type: pb840b7ef
        // type: p1522cc54
        // type: pd6ccb7fc
        return default!;
    }

    public void AddCRL(X509CRL P0)
    {
        // str: "exception processing encoding of CRL: "
        // call: X509CRL.getRevokedCertificates
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: X509CRLEntry.getEncoded
        // call: HashSet<object>.iterator
        // call: pd1c2953c.<init>
        // call: pd1c2953c.readObject
        // call: p80f8c729.m8bab0102
        // call: p8001ce84.addCRLEntry
        // call: StringBuilder.toString
        // call: IEnumerator<object>.next
        // call: IOException.toString
        // call: CRLException.<init>
        // call: IEnumerator<object>.hasNext
        // field: p5a445d71.p9f931cf3.pdacfecb5.pf19dcdf0.f4f0d65e6
        // type: CRLException
        // type: pd1c2953c
        // type: StringBuilder
    }

    public void AddCRLEntry(System.Numerics.BigInteger P0, DateTime P1, int P2)
    {
        // call: pf391b73d.<init>
        // call: p8001ce84.addCRLEntry
        // call: pa76d4ef5.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.pf19dcdf0.f4f0d65e6
        // type: pf391b73d
        // type: pa76d4ef5
    }

    public void AddCRLEntry(System.Numerics.BigInteger P0, DateTime P1, int P2, DateTime P3)
    {
        // call: pb907b377.<init>
        // call: pa76d4ef5.<init>
        // call: p8001ce84.addCRLEntry
        // call: pf391b73d.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.pf19dcdf0.f4f0d65e6
        // type: pb907b377
        // type: pa76d4ef5
        // type: pf391b73d
    }

    public void AddCRLEntry(System.Numerics.BigInteger P0, DateTime P1, pb7e3050b P2)
    {
        // call: p8001ce84.addCRLEntry
        // call: pf391b73d.<init>
        // call: pa76d4ef5.<init>
        // call: p5e2f5f3c.m8bab0102
        // field: p5a445d71.p9f931cf3.pdacfecb5.pf19dcdf0.f4f0d65e6
        // type: pf391b73d
        // type: pa76d4ef5
    }

    public void AddExtension(string P0, bool P1, p0fd1bdf1 P2)
    {
        // call: pf19dcdf0.addExtension
        // call: p364bf33a.<init>
        // type: p364bf33a
    }

    public void AddExtension(string P0, bool P1, byte[] P2)
    {
        // call: p364bf33a.<init>
        // call: pf19dcdf0.addExtension
        // type: p364bf33a
    }

    public void AddExtension(p364bf33a P0, bool P1, p0fd1bdf1 P2)
    {
        // call: p364bf33a.getId
        // call: p67cc0eb6.addExtension
        // call: p364bf33a.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.pf19dcdf0.f211abb1e
        // type: p364bf33a
    }

    public void AddExtension(p364bf33a P0, bool P1, byte[] P2)
    {
        // call: p364bf33a.getId
        // call: p67cc0eb6.addExtension
        // call: p364bf33a.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.pf19dcdf0.f211abb1e
        // type: p364bf33a
    }

    public X509CRL Generate(PrivateKey P0)
    {
        // call: pf19dcdf0.generate
        return default!;
    }

    public X509CRL Generate(PrivateKey P0, string P1)
    {
        // call: pf19dcdf0.generate
        return default!;
    }

    public X509CRL Generate(PrivateKey P0, string P1, System.Security.Cryptography.RandomNumberGenerator P2)
    {
        // str: "cannot generate CRL encoding"
        // call: pf19dcdf0.mff2c9a73
        // call: pf19dcdf0.m7ddfe275
        // call: pbdeb4310.ma899ffcb
        // call: pf19dcdf0$pc05b9619.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.pf19dcdf0.fb0a16070
        // field: p5a445d71.p9f931cf3.pdacfecb5.pf19dcdf0.f0c3d482a
        // type: pf19dcdf0$pc05b9619
        return default!;
    }

    public X509CRL Generate(PrivateKey P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "cannot generate CRL encoding"
        // call: pf19dcdf0.mff2c9a73
        // call: pf19dcdf0$pc05b9619.<init>
        // call: pf19dcdf0.m7ddfe275
        // call: pbdeb4310.ma899ffcb
        // field: p5a445d71.p9f931cf3.pdacfecb5.pf19dcdf0.fb0a16070
        // field: p5a445d71.p9f931cf3.pdacfecb5.pf19dcdf0.f0c3d482a
        // type: pf19dcdf0$pc05b9619
        return default!;
    }

    public X509CRL GenerateX509CRL(PrivateKey P0)
    {
        // str: "0f0a2c64898ad184c43a5b6c28798dcd7aa6024bb7ed39dee09e02a1d645"
        // str: "BC provider not installed!"
        // call: DecryptString.decryptString
        // call: pf19dcdf0.generateX509CRL
        // call: SecurityException.<init>
        // type: SecurityException
        return default!;
    }

    public X509CRL GenerateX509CRL(PrivateKey P0, string P1)
    {
        // call: pf19dcdf0.generateX509CRL
        return default!;
    }

    public X509CRL GenerateX509CRL(PrivateKey P0, string P1, System.Security.Cryptography.RandomNumberGenerator P2)
    {
        // str: "exception: "
        // call: StringBuilder.<init>
        // call: pf19dcdf0.generate
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: SecurityException.<init>
        // type: StringBuilder
        // type: SecurityException
        return default!;
    }

    public X509CRL GenerateX509CRL(PrivateKey P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "267f677b138736ad9279a91fc249237828232c5d167d016b56e02e9d28a1"
        // str: "BC provider not installed!"
        // call: SecurityException.<init>
        // call: DecryptString.decryptString
        // call: pf19dcdf0.generateX509CRL
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
        // call: p8001ce84.<init>
        // call: p67cc0eb6.reset
        // field: p5a445d71.p9f931cf3.pdacfecb5.pf19dcdf0.f4f0d65e6
        // field: p5a445d71.p9f931cf3.pdacfecb5.pf19dcdf0.f211abb1e
        // type: p8001ce84
    }

    public void SetIssuerDN(X500Principal P0)
    {
        // str: "can't process principal: "
        // call: IllegalArgumentException.<init>
        // call: X500Principal.getEncoded
        // call: pe2c8c969.<init>
        // call: p8001ce84.setIssuer
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // field: p5a445d71.p9f931cf3.pdacfecb5.pf19dcdf0.f4f0d65e6
        // type: pe2c8c969
        // type: StringBuilder
        // type: IllegalArgumentException
    }

    public void SetIssuerDN(p22ab0bb1 P0)
    {
        // call: p8001ce84.setIssuer
        // field: p5a445d71.p9f931cf3.pdacfecb5.pf19dcdf0.f4f0d65e6
    }

    public void SetNextUpdate(DateTime P0)
    {
        // call: pa76d4ef5.<init>
        // call: p8001ce84.setNextUpdate
        // field: p5a445d71.p9f931cf3.pdacfecb5.pf19dcdf0.f4f0d65e6
        // type: pa76d4ef5
    }

    public void SetSignatureAlgorithm(string P0)
    {
        // str: "Unknown signature type requested"
        // call: pbdeb4310.m55c09d0e
        // call: pbdeb4310.me47e5a52
        // call: IllegalArgumentException.<init>
        // call: p8001ce84.setSignature
        // field: p5a445d71.p9f931cf3.pdacfecb5.pf19dcdf0.f4ddf4fb6
        // field: p5a445d71.p9f931cf3.pdacfecb5.pf19dcdf0.f0c3d482a
        // field: p5a445d71.p9f931cf3.pdacfecb5.pf19dcdf0.fb0a16070
        // field: p5a445d71.p9f931cf3.pdacfecb5.pf19dcdf0.f4f0d65e6
        // type: IllegalArgumentException
    }

    public void SetThisUpdate(DateTime P0)
    {
        // call: pa76d4ef5.<init>
        // call: p8001ce84.setThisUpdate
        // field: p5a445d71.p9f931cf3.pdacfecb5.pf19dcdf0.f4f0d65e6
        // type: pa76d4ef5
    }

}
