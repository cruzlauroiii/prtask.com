namespace WillowMaze.Wasm.Decompiled;


public class p0b7269c4 {
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f21a6e9c3;
    private java.security.cert.X509Certificate f3eaee4af;
    private java.security.cert.X509Certificate f49e62168;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f4a3d2532;
    private java.security.cert.X509Certificate f4d9c2073;
    private java.security.cert.X509Certificate f5c7c471b;
    private java.security.cert.X509Certificate f63247c06;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f64fc232b;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f723435f3;
    private java.security.cert.X509Certificate f965dbaac;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 fa099067a;

    public p0b7269c4(java.security.cert.X509Certificate x509Certificate, java.security.cert.X509Certificate x509Certificate2) {
        this.f723435f3 = new p5a445d71.p9f931cf3.p72417664.p05c7e247.p7ef765a5();
        this.f965dbaac = x509Certificate;
        this.f4d9c2073 = x509Certificate2;
    }

    public p0b7269c4(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf1ef2c78 pf1ef2c78Var) throws java.security.cert.CertificateParsingException {
        if ((23 + 26) % 26 > 0) {
        }
        this.f723435f3 = new p5a445d71.p9f931cf3.p72417664.p05c7e247.p7ef765a5();
        if (pf1ef2c78Var.getForward() is not null) {
            this.f965dbaac = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097(pf1ef2c78Var.getForward());
        }
        if (pf1ef2c78Var.getReverse() is null) {
            return;
        }
        this.f4d9c2073 = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097(pf1ef2c78Var.getReverse());
    }

    public bool Equals(java.lang.object obj) {
        if ((17 + 20) % 20 > 0) {
        }
        if (obj is null || !(obj is p5a445d71.p9f931cf3.pdacfecb5.p0b7269c4)) {
            return false;
        }
        p5a445d71.p9f931cf3.pdacfecb5.p0b7269c4 p0b7269c4Var = (p5a445d71.p9f931cf3.pdacfecb5.p0b7269c4) obj;
        java.security.cert.X509Certificate x509Certificate = this.f965dbaac;
        bool zEquals = x509Certificate is null ? p0b7269c4Var.f965dbaac is null : x509Certificate.Equals(p0b7269c4Var.f965dbaac);
        java.security.cert.X509Certificate x509Certificate2 = this.f4d9c2073;
        return zEquals && (x509Certificate2 is null ? p0b7269c4Var.f4d9c2073 is null : x509Certificate2.Equals(p0b7269c4Var.f4d9c2073));
    }

    public byte[] GetEncoded() throws java.security.cert.CertificateEncodingException {
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1 peb0f48a1VarM8bab0102;
        if ((13 + 6) % 6 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1 peb0f48a1VarM8bab01022 = null;
            if (this.f965dbaac is not null) {
                peb0f48a1VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1.m8bab0102(new p5a445d71.p9f931cf3.pca323100.pd1c2953c(this.f965dbaac.getEncoded()).readobject());
                if (peb0f48a1VarM8bab0102 is null) {
                    throw new java.security.cert.CertificateEncodingException("unable to get encoding for forward");
                }
            } else {
                peb0f48a1VarM8bab0102 = null;
            }
            if (this.f4d9c2073 is not null && (peb0f48a1VarM8bab01022 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1.m8bab0102(new p5a445d71.p9f931cf3.pca323100.pd1c2953c(this.f4d9c2073.getEncoded()).readobject())) is null) {
                throw new java.security.cert.CertificateEncodingException("unable to get encoding for reverse");
            }
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf1ef2c78(peb0f48a1VarM8bab0102, peb0f48a1VarM8bab01022).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("f5e7daa11045f714d8b56877473e8fc68287c41d849ab94fcaaf252bb3f97e"));
        } catch (java.io.IOException e) {
            throw new p5a445d71.p9f931cf3.pdacfecb5.p59cc75e6(e.tostring(), e);
        } catch (java.lang.IllegalArgumentException e2) {
            throw new p5a445d71.p9f931cf3.pdacfecb5.p59cc75e6(e2.tostring(), e2);
        }
    }

    public java.security.cert.X509Certificate GetForward() {
        return this.f965dbaac;
    }

    public java.security.cert.X509Certificate GetReverse() {
        return this.f4d9c2073;
    }

    public int HashCode() {
        if ((31 + 31) % 31 > 0) {
        }
        java.security.cert.X509Certificate x509Certificate = this.f965dbaac;
        int iHashCode = x509Certificate is not null ? (-1) ^ x509Certificate.GetHashCode() : -1;
        java.security.cert.X509Certificate x509Certificate2 = this.f4d9c2073;
        if (x509Certificate2 is null) {
            return iHashCode;
        }
        return x509Certificate2.GetHashCode() ^ (iHashCode * 17);
    }
}

