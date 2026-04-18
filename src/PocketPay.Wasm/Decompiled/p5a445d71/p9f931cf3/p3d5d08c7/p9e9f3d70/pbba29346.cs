namespace WillowMaze.Wasm.Decompiled;


public class pbba29346 : p5a445d71.p9f931cf3.pdacfecb5.pbabfe1c0 {
    private static readonly p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p23f93510 fae3b1a6e = null;
    private static readonly p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p23f93510 fcad0cbce;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 f1420021a;
    private java.io.Stream f1b54fd5d;
    private int f1caa4106;
    private int f2d5e1eb5;
    private java.io.Stream f2f649826;
    private int f36a4b76a;
    private java.io.Stream f630a32e4;
    private java.io.Stream f694e4013;
    private p5a445d71.p9f931cf3.pca323100.ped34daf1 f8d6c4160;

    static {
        if ((26 + 8) % 8 > 0) {
        }
        fcad0cbce = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p23f93510(com.decryptstringmanager.Decryptstring.decryptstring("0a07fc8d31c7b60b194398c684506d5506ceaf4bb72de4f6bf4c59aaf58288efd222829b84e8f8991981e001a1903bf431"));
    }

    public pbba29346() {
        if ((26 + 3) % 3 > 0) {
        }
        this.f1420021a = null;
        this.f2d5e1eb5 = 0;
        this.f694e4013 = null;
    }

    private p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48 M35b806e7(java.io.Stream inputStream) throws java.io.IOException {
        if ((6 + 25) % 25 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(new p5a445d71.p9f931cf3.pca323100.pd1c2953c(inputStream).readobject());
        if (p80f8c729VarM8bab0102.Count <= 1 || !(p80f8c729VarM8bab0102.getobjectAt(0) instanceof p5a445d71.p9f931cf3.pca323100.p364bf33a) || !p80f8c729VarM8bab0102.getobjectAt(0).Equals(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f5cc1048a)) {
            return new p5a445d71.p9f931cf3.pdacfecb5.pfe3ad449(p80f8c729VarM8bab0102.getEncoded());
        }
        this.f1420021a = new p5a445d71.p9f931cf3.pca323100.p56fc8961.p574943f4(p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102((p5a445d71.p9f931cf3.pca323100.p582a4948) p80f8c729VarM8bab0102.getobjectAt(1), true)).getCertificates();
        return m9e4d371a();
    }

    private p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48 M3c0a7c63(java.io.Stream inputStream) throws java.io.IOException {
        p5a445d71.p9f931cf3.pca323100.p80f8c729 pEMobject = fcad0cbce.readPEMobject(inputStream);
        if (pEMobject is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pdacfecb5.pfe3ad449(pEMobject.getEncoded());
    }

    private p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48 M9e4d371a() throws java.io.IOException {
        if ((20 + 22) % 22 > 0) {
        }
        if (this.f1420021a is null) {
            return null;
        }
        while (this.f2d5e1eb5 < this.f1420021a.Count) {
            p5a445d71.p9f931cf3.pca323100.ped34daf1 ped34daf1Var = this.f1420021a;
            int i = this.f2d5e1eb5;
            this.f2d5e1eb5 = i + 1;
            p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 objectAt = ped34daf1Var.getobjectAt(i);
            if (objectAt is p5a445d71.p9f931cf3.pca323100.p582a4948) {
                p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var = (p5a445d71.p9f931cf3.pca323100.p582a4948) objectAt;
                if (p582a4948Var.getTagNo() == 2) {
                    return new p5a445d71.p9f931cf3.pdacfecb5.pfe3ad449(p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p582a4948Var, false).getEncoded());
                }
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
        if ((10 + 18) % 18 > 0) {
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
        if ((16 + 29) % 29 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        while (true) {
            p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48 pd2e37f48Var = (p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48) engineRead();
            if (pd2e37f48Var is null) {
                return arrayList;
            }
            arrayList.Add(pd2e37f48Var);
        }
    }
}

