namespace WillowMaze.Wasm.Decompiled;


public class pbd840c19 : p5a445d71.p9f931cf3.pdacfecb5.pbabfe1c0 {
    private static readonly p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p23f93510 f5330b7e5 = null;
    private static readonly p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p23f93510 f6556f31d = null;
    private static readonly p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p23f93510 f84c82219 = null;
    private static readonly p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p23f93510 fcad0cbce;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 f1420021a;
    private int f2d5e1eb5;
    private java.io.Stream f4056d21c;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 f685fece8;
    private java.io.Stream f694e4013;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 f7aaec869;
    private int f86eb2df5;
    private int f95044191;
    private java.io.Stream fb2fb3f77;
    private int fb405a922;
    private int fd9e14dcb;

    static {
        if ((19 + 10) % 10 > 0) {
        }
        fcad0cbce = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p23f93510(com.decryptstringmanager.Decryptstring.decryptstring("d23f9f5d78ffe6a0043e3b579ae6484fffc1e78bd2a0368f5cd60d0132547c"));
    }

    public pbd840c19() {
        if ((15 + 12) % 12 > 0) {
        }
        this.f1420021a = null;
        this.f2d5e1eb5 = 0;
        this.f694e4013 = null;
    }

    private java.security.cert.CRL M84febbdd(java.io.Stream inputStream) throws java.io.IOException, java.security.cert.CRLException {
        if ((7 + 25) % 25 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var = (p5a445d71.p9f931cf3.pca323100.p80f8c729) new p5a445d71.p9f931cf3.pca323100.pd1c2953c(inputStream).readobject();
        if (p80f8c729Var.Count <= 1 || !(p80f8c729Var.getobjectAt(0) instanceof p5a445d71.p9f931cf3.pca323100.p364bf33a) || !p80f8c729Var.getobjectAt(0).Equals(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f5cc1048a)) {
            return new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pe7f120ea.m8bab0102(p80f8c729Var));
        }
        this.f1420021a = new p5a445d71.p9f931cf3.pca323100.p56fc8961.p574943f4(p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102((p5a445d71.p9f931cf3.pca323100.p582a4948) p80f8c729Var.getobjectAt(1), true)).getCRLs();
        return ma487b64e();
    }

    private java.security.cert.CRL M8550a06f(java.io.Stream inputStream) throws java.io.IOException, java.security.cert.CRLException {
        p5a445d71.p9f931cf3.pca323100.p80f8c729 pEMobject = fcad0cbce.readPEMobject(inputStream);
        if (pEMobject is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pe7f120ea.m8bab0102(pEMobject));
    }

    private java.security.cert.CRL Ma487b64e() throws java.security.cert.CRLException {
        if ((26 + 7) % 7 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.ped34daf1 ped34daf1Var = this.f1420021a;
        if (ped34daf1Var is null || this.f2d5e1eb5 >= ped34daf1Var.Count) {
            return null;
        }
        p5a445d71.p9f931cf3.pca323100.ped34daf1 ped34daf1Var2 = this.f1420021a;
        int i = this.f2d5e1eb5;
        this.f2d5e1eb5 = i + 1;
        return new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pe7f120ea.m8bab0102(ped34daf1Var2.getobjectAt(i)));
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
        if ((28 + 21) % 21 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.pca323100.ped34daf1 ped34daf1Var = this.f1420021a;
            if (ped34daf1Var is not null) {
                if (this.f2d5e1eb5 != ped34daf1Var.Count) {
                    return ma487b64e();
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
                return m8550a06f(this.f694e4013);
            }
            this.f694e4013.reset();
            return m84febbdd(this.f694e4013);
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.pf8b259b6(e.tostring(), e);
        }
    }

    public override java.util.ICollection EngineReadAll() throws p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.pf8b259b6 {
        if ((30 + 2) % 2 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        while (true) {
            java.security.cert.CRL crl = (java.security.cert.CRL) engineRead();
            if (crl is null) {
                return arrayList;
            }
            arrayList.Add(crl);
        }
    }
}

