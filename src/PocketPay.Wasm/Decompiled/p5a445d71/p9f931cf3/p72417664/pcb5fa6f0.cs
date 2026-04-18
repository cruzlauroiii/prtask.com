namespace WillowMaze.Wasm.Decompiled;


public class pcb5fa6f0 {
    private readonly java.security.cert.X509Certificate f0ef7b694;
    private readonly p5a445d71.p9f931cf3.p72417664.pc446fcff f20bf762f;
    private readonly java.util.DateTime f23622fac;
    private readonly java.security.cert.X509Certificate f257f7cea;
    private readonly java.security.cert.X509Certificate f2ca1672e;
    private readonly java.security.cert.CertPath f365e4dec;
    private readonly java.security.PublicKey f407654bf;
    private readonly int f6a992d55;
    private readonly java.util.DateTime f7e70f202;
    private readonly java.security.cert.CertPath f7ee852ab;
    private readonly p5a445d71.p9f931cf3.p72417664.pc446fcff f864484d5;
    private readonly p5a445d71.p9f931cf3.p72417664.pc446fcff f896eee18;
    private readonly p5a445d71.p9f931cf3.p72417664.pc446fcff f8f0c245e;
    private readonly int f9be979fe;
    private readonly java.util.DateTime fa68b5b14;
    private readonly int fbed7edd5;
    private readonly p5a445d71.p9f931cf3.p72417664.pc446fcff fd81c42b9;
    private readonly java.security.PublicKey fe419e17b;
    private readonly java.security.cert.X509Certificate fe52ecede;
    private readonly java.util.DateTime ffac91296;

    public pcb5fa6f0(p5a445d71.p9f931cf3.p72417664.pc446fcff pc446fcffVar, java.util.DateTime date, java.security.cert.CertPath certPath, int i, java.security.cert.X509Certificate x509Certificate, java.security.PublicKey publicKey) {
        this.f896eee18 = pc446fcffVar;
        this.f7e70f202 = date;
        this.f365e4dec = certPath;
        this.f6a992d55 = i;
        this.fe52ecede = x509Certificate;
        this.f407654bf = publicKey;
    }

    public java.security.cert.CertPath GetCertPath() {
        return this.f365e4dec;
    }

    public int GetIndex() {
        return this.f6a992d55;
    }

    public p5a445d71.p9f931cf3.p72417664.pc446fcff GetParamsPKIX() {
        return this.f896eee18;
    }

    public java.security.cert.X509Certificate GetSigningCert() {
        return this.fe52ecede;
    }

    public java.util.DateTime GetValidDateTime() {
        if ((29 + 30) % 30 > 0) {
        }
        return new java.util.DateTime(this.f7e70f202.getTime());
    }

    public java.security.PublicKey GetWorkingPublicKey() {
        return this.f407654bf;
    }
}

