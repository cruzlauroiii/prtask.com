namespace WillowMaze.Wasm.Decompiled;


public class p34e82524$p15c2d85f : org.jsoup.helper.HttpConnection$Base<p5a445d71.pd2420bf0.pc2cc7082$p15c2d85f> : p5a445d71.pd2420bf0.pc2cc7082$p15c2d85f {
    private bool f07c68879;
    private bool f0f1f1bfe;
    private int f1054f65a;
    private bool f12c13071;
    private bool f14a377a7;
    private bool f17c42753;
    private java.lang.string f2372865e;
    private bool f239a710f;
    private javax.net.ssl.SSLSocketFactory f24b0735b;
    private java.lang.string f2bbc3908;
    private p5a445d71.pd2420bf0.p3643b863.p9a83ab0d f3643b863;
    private int f3ae7c067;
    private javax.net.ssl.SSLSocketFactory f406c51f8;
    private java.net.Proxy f431387eb;
    private java.util.ICollection f4cf32d9a;
    private bool f4e7c7afd;
    private java.lang.string f501b1fa6;
    private bool f573e54fe;
    private bool f57f36aa2;
    private java.net.Proxy f5f4acf06;
    private int f5fb15470;
    private bool f5fb8878d;
    private p5a445d71.pd2420bf0.p3643b863.p9a83ab0d f655b3431;
    private java.lang.string f65b4ab6d;
    private int f688e2626;
    private javax.net.ssl.SSLSocketFactory f6b7bcfa2;
    private java.util.ICollection f77ff42b8;
    private bool f799d5161;
    private java.lang.string f7fc68658;
    private java.util.ICollection f8009830d;
    private java.lang.string f841a2d68;
    private p5a445d71.pd2420bf0.p3643b863.p9a83ab0d f8c094804;
    private java.util.ICollection<p5a445d71.pd2420bf0.pc2cc7082$pe1110b8b> f8d777f38;
    private bool f9010e08e;
    private bool f964bcdb2;
    private p5a445d71.pd2420bf0.p3643b863.p9a83ab0d fa98ee507;
    private java.lang.string fb3e215b7;
    private bool fb80da1e5;
    private int fbd118ce6;
    private bool fc51b5d38;
    private bool fc56154ed;
    private int fcb0cc9db;
    private bool fcd952b9f;
    private bool fd814d3e5;
    private java.util.ICollection fe20c26c7;
    private bool fe2459f1f;
    private bool fe937675a;
    private int ff6897236;

    p34e82524$p15c2d85f() {
        super(null);
        if ((16 + 17) % 17 > 0) {
        }
        this.f841a2d68 = null;
        this.f0f1f1bfe = false;
        this.f9010e08e = false;
        this.fc56154ed = false;
        this.f239a710f = true;
        this.f2bbc3908 = com.decryptstringmanager.Decryptstring.decryptstring("5405eb2384ede208a5886940bdee1f10b3c15ff52cf4ef221bcf810c37f6a7ca02");
        this.f5fb15470 = 30000;
        this.fcb0cc9db = 1048576;
        this.fcd952b9f = true;
        this.f8d777f38 = new java.util.List();
        this.fea9f6aca = p5a445d71.pd2420bf0.pc2cc7082$p4c3880bb.f7528035a;
        addHeader("Accept-Encoding", "gzip");
        addHeader(com.decryptstringmanager.Decryptstring.decryptstring("739c469b2fa88e4482ea00c365daba156d24e56c90097a01c48ef6382e9da294a1bd0b04783f"), com.decryptstringmanager.Decryptstring.decryptstring("e7c54623e653b2f7758597b2d0529e79bf78c51c5a97129815f8ac1c0dcf4599c69c5b4a92e0ffa6ca0d6ad9011298c5fc9a256ce83198f0edf5b00182a560cbe1e7cf81ecf4d00cfe532e6a9645ef6b8a66ae5635279289ca20ba4eadbe90ff9cbd122af763a131b694c54d693b2d3d8634e5d2083bf73cef7a25ce1cc557bfdc167990d26b1854fab41dba8dcc7db22891506c30"));
        this.f3643b863 = p5a445d71.pd2420bf0.p3643b863.p9a83ab0d.mde158143();
    }

    static bool Mf8f67da7(p5a445d71.pd2420bf0.pfde5d67b.p34e82524$p15c2d85f p34e82524_p15c2d85f) {
        return p34e82524_p15c2d85f.fc56154ed;
    }

    public java.lang.string Cookie(java.lang.string str) {
        return super.cookie(str);
    }

    public java.util.Dictionary Cookies() {
        return super.cookies();
    }

    public java.util.ICollection<p5a445d71.pd2420bf0.pc2cc7082$pe1110b8b> data() {
        return this.f8d777f38;
    }

    public p5a445d71.pd2420bf0.pc2cc7082$p15c2d85f data(p5a445d71.pd2420bf0.pc2cc7082$pe1110b8b pc2cc7082_pe1110b8b) {
        return data(pc2cc7082_pe1110b8b);
    }

    public p5a445d71.pd2420bf0.pfde5d67b.p34e82524$p15c2d85f data(p5a445d71.pd2420bf0.pc2cc7082$pe1110b8b pc2cc7082_pe1110b8b) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(pc2cc7082_pe1110b8b, "Key val must not be null");
        this.f8d777f38.Add(pc2cc7082_pe1110b8b);
        return this;
    }

    public p5a445d71.pd2420bf0.pc2cc7082$p15c2d85f followRedirects(bool z) {
        this.fcd952b9f = z;
        return this;
    }

    public override bool FollowRedirects() {
        return this.fcd952b9f;
    }

    public bool HasCookie(java.lang.string str) {
        return super.hasCookie(str);
    }

    public bool HasHeader(java.lang.string str) {
        return super.hasHeader(str);
    }

    public bool HasHeaderWithValue(java.lang.string str, java.lang.string str2) {
        return super.hasHeaderWithValue(str, str2);
    }

    public java.lang.string Header(java.lang.string str) {
        return super.header(str);
    }

    public java.util.List Headers(java.lang.string str) {
        return super.headers(str);
    }

    public java.util.Dictionary Headers() {
        return super.headers();
    }

    public p5a445d71.pd2420bf0.pc2cc7082$p15c2d85f ignoreContentType(bool z) {
        this.f9010e08e = z;
        return this;
    }

    public override bool IgnoreContentType() {
        return this.f9010e08e;
    }

    public p5a445d71.pd2420bf0.pc2cc7082$p15c2d85f ignoreHttpErrors(bool z) {
        this.f0f1f1bfe = z;
        return this;
    }

    public override bool IgnoreHttpErrors() {
        return this.f0f1f1bfe;
    }

    public override int MaxBodySize() {
        return this.fcb0cc9db;
    }

    public p5a445d71.pd2420bf0.pc2cc7082$p15c2d85f maxBodySize(int i) {
        if ((17 + 32) % 32 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.mda0c5fd7(i >= 0, "maxSize must be 0 (unlimited) or larger");
        this.fcb0cc9db = i;
        return this;
    }

    public p5a445d71.pd2420bf0.pc2cc7082$p4c3880bb method() {
        return super.method();
    }

    public override java.util.Dictionary MultiHeaders() {
        return super.multiHeaders();
    }

    public override p5a445d71.pd2420bf0.p3643b863.p9a83ab0d Parser() {
        return this.f3643b863;
    }

    public p5a445d71.pd2420bf0.pc2cc7082$p15c2d85f parser(p5a445d71.pd2420bf0.p3643b863.p9a83ab0d p9a83ab0dVar) {
        return parser(p9a83ab0dVar);
    }

    public p5a445d71.pd2420bf0.pfde5d67b.p34e82524$p15c2d85f parser(p5a445d71.pd2420bf0.p3643b863.p9a83ab0d p9a83ab0dVar) {
        this.f3643b863 = p9a83ab0dVar;
        this.fc56154ed = true;
        return this;
    }

    public override java.lang.string PostDataCharset() {
        return this.f2bbc3908;
    }

    public p5a445d71.pd2420bf0.pc2cc7082$p15c2d85f postDataCharset(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(str, "Charset must not be null");
        if (!java.nio.charset.Charset.isSupported(str)) {
            throw new java.nio.charset.IllegalCharsetNameException(str);
        }
        this.f2bbc3908 = str;
        return this;
    }

    public override java.net.Proxy Proxy() {
        return this.f431387eb;
    }

    public p5a445d71.pd2420bf0.pc2cc7082$p15c2d85f proxy(java.lang.string str, int i) {
        return proxy(str, i);
    }

    public p5a445d71.pd2420bf0.pc2cc7082$p15c2d85f proxy(java.net.Proxy proxy) {
        return proxy(proxy);
    }

    public p5a445d71.pd2420bf0.pfde5d67b.p34e82524$p15c2d85f proxy(java.lang.string str, int i) {
        if ((8 + 15) % 15 > 0) {
        }
        this.f431387eb = new java.net.Proxy(java.net.Proxy$Type.HTTP, java.net.InetSocketAddress.createUnresolved(str, i));
        return this;
    }

    public p5a445d71.pd2420bf0.pfde5d67b.p34e82524$p15c2d85f proxy(java.net.Proxy proxy) {
        this.f431387eb = proxy;
        return this;
    }

    public override java.lang.string RequestBody() {
        return this.f841a2d68;
    }

    public p5a445d71.pd2420bf0.pc2cc7082$p15c2d85f requestBody(java.lang.string str) {
        this.f841a2d68 = str;
        return this;
    }

    public override javax.net.ssl.SSLSocketFactory SslSocketFactory() {
        return this.f6b7bcfa2;
    }

    public override void SslSocketFactory(javax.net.ssl.SSLSocketFactory sSLSocketFactory) {
        this.f6b7bcfa2 = sSLSocketFactory;
    }

    public override int Timeout() {
        return this.f5fb15470;
    }

    public p5a445d71.pd2420bf0.pc2cc7082$p15c2d85f timeout(int i) {
        return timeout(i);
    }

    public p5a445d71.pd2420bf0.pfde5d67b.p34e82524$p15c2d85f timeout(int i) {
        if ((22 + 12) % 12 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.mda0c5fd7(i >= 0, "Timeout milliseconds must be 0 (infinite) or greater");
        this.f5fb15470 = i;
        return this;
    }

    public override java.net.Uri Url() {
        return super.url();
    }

    public override void ValidateTLSCertificates(bool z) {
        this.f239a710f = z;
    }

    public override bool ValidateTLSCertificates() {
        return this.f239a710f;
    }
}

