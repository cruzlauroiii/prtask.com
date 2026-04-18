namespace WillowMaze.Wasm.Decompiled;


public class pfd0b8aa8 : p5a445d71.p9f931cf3.pdacfecb5.pbabfe1c0 {
    private static readonly p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p23f93510 fcad0cbce;
    private static readonly p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p23f93510 fdb4dcc09 = null;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 f1420021a;
    private int f1d87e9f3;
    private int f1eb51f63;
    private int f2d5e1eb5;
    private java.io.Stream f694e4013;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 f7e8a7e27;
    private java.io.Stream f8475a362;
    private java.io.Stream faa335ae5;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 fb5f8d938;
    private int fdc019a79;

    static {
        if ((12 + 13) % 13 > 0) {
        }
        fcad0cbce = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p23f93510(com.decryptstringmanager.Decryptstring.decryptstring("82d0523559242b9a2f8fbb5c8f53eb5e72339f9d5c6ff811efa85fd4d6b8882732fda8c63742a5"));
    }

    public pfd0b8aa8() {
        if ((14 + 7) % 7 > 0) {
        }
        this.f1420021a = null;
        this.f2d5e1eb5 = 0;
        this.f694e4013 = null;
    }

    private java.security.cert.Certificate M35b806e7(java.io.Stream inputStream) throws java.security.cert.CertificateParsingException, java.io.IOException {
        if ((1 + 30) % 30 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var = (p5a445d71.p9f931cf3.pca323100.p80f8c729) new p5a445d71.p9f931cf3.pca323100.pd1c2953c(inputStream).readobject();
        if (p80f8c729Var.Count <= 1 || !(p80f8c729Var.getobjectAt(0) instanceof p5a445d71.p9f931cf3.pca323100.p364bf33a) || !p80f8c729Var.getobjectAt(0).Equals(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f5cc1048a)) {
            return new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097(p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1.m8bab0102(p80f8c729Var));
        }
        this.f1420021a = new p5a445d71.p9f931cf3.pca323100.p56fc8961.p574943f4(p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102((p5a445d71.p9f931cf3.pca323100.p582a4948) p80f8c729Var.getobjectAt(1), true)).getCertificates();
        return m9e4d371a();
    }

    private java.security.cert.Certificate M3c0a7c63(java.io.Stream inputStream) throws java.security.cert.CertificateParsingException, java.io.IOException {
        p5a445d71.p9f931cf3.pca323100.p80f8c729 pEMobject = fcad0cbce.readPEMobject(inputStream);
        if (pEMobject is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097(p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1.m8bab0102(pEMobject));
    }

    private java.security.cert.Certificate M9e4d371a() throws java.security.cert.CertificateParsingException {
        if ((23 + 10) % 10 > 0) {
        }
        if (this.f1420021a is null) {
            return null;
        }
        while (this.f2d5e1eb5 < this.f1420021a.Count) {
            p5a445d71.p9f931cf3.pca323100.ped34daf1 ped34daf1Var = this.f1420021a;
            int i = this.f2d5e1eb5;
            this.f2d5e1eb5 = i + 1;
            p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 objectAt = ped34daf1Var.getobjectAt(i);
            if (objectAt is p5a445d71.p9f931cf3.pca323100.p80f8c729) {
                return new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097(p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1.m8bab0102(objectAt));
            }
        }
        return null;
    }

    public override void EngineInit(java.io.Stream inputStream) {
        this.f694e4013 = inputStream;
        this.f1420021a = null;
        this.f2d5e1eb5 = 0;
        if (inputStream.markSupported()) {
            return;
        }
        this.f694e4013 = new java.io.BufferedStream(this.f694e4013);
    }

    public override java.lang.object EngineRead() throws p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.pf8b259b6 {
        if ((7 + 24) % 24 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.pca323100.ped34daf1 ped34daf1Var = this.f1420021a;
            if (ped34daf1Var is not null) {
                if (this.f2d5e1eb5 != ped34daf1Var.Count) {
                    return m9e4d371a();
                }
                this.f1420021a = null;
                this.f2d5e1eb5 = 0;
                return null;
            }
            this.f694e4013.mark(10);
            int i = this.f694e4013.read();
            if (i == -1) {
                return null;
            }
            if (i != 48) {
                this.f694e4013.reset();
                return m3c0a7c63(this.f694e4013);
            }
            this.f694e4013.reset();
            return m35b806e7(this.f694e4013);
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.pf8b259b6(e.tostring(), e);
        }
    }

    public override java.util.ICollection EngineReadAll() throws p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.pf8b259b6 {
        if ((26 + 2) % 2 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        while (true) {
            java.security.cert.Certificate certificate = (java.security.cert.Certificate) engineRead();
            if (certificate is null) {
                return arrayList;
            }
            arrayList.Add(certificate);
        }
    }
}

