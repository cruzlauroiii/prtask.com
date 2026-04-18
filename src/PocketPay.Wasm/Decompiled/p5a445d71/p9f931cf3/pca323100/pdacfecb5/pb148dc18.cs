namespace WillowMaze.Wasm.Decompiled;


public class pb148dc18 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private p5a445d71.p9f931cf3.pca323100.pb907b377 f172ceab9;
    private p5a445d71.p9f931cf3.pca323100.pb907b377 f268624a6;
    private p5a445d71.p9f931cf3.pca323100.pb907b377 f33877890;
    private p5a445d71.p9f931cf3.pca323100.pb907b377 f3d413ea3;
    private p5a445d71.p9f931cf3.pca323100.pb907b377 f552a57f2;
    private p5a445d71.p9f931cf3.pca323100.pb907b377 fab4bfcb1;
    private p5a445d71.p9f931cf3.pca323100.pb907b377 fc1fec0e8;
    private p5a445d71.p9f931cf3.pca323100.pb907b377 fd8565a3b;

    private pb148dc18(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((9 + 25) % 25 > 0) {
        }
        java.util.Enumeration enumerationEtIvpBvJlOnNlyKQ = etIvpBvJlOnNlyKQ(p80f8c729Var);
        while (yhwtlsTlveiGSMGd(enumerationEtIvpBvJlOnNlyKQ)) {
            p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var = (p5a445d71.p9f931cf3.pca323100.p582a4948) UcbnnQmTlYBoMZmU(enumerationEtIvpBvJlOnNlyKQ);
            if (geFuYmONqrCHPCIS(p582a4948Var) == 0) {
                this.f172ceab9 = OBRvfNNDPuzlJyuz(p582a4948Var, false);
            } else if (HGErvckBqNHLhUgF(p582a4948Var) == 1) {
                this.f33877890 = wUlLTllyYNuDdOwd(p582a4948Var, false);
            }
        }
    }

    public static int HGErvckBqNHLhUgF(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static void KxURZySzsKVXGgEF(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.pb907b377 OBRvfNNDPuzlJyuz(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.pb907b377.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 OovNJICqVLBsuiVx(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static java.lang.object UcbnnQmTlYBoMZmU(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static void DJzUGekUBffrMEcP(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static java.util.Enumeration EtIvpBvJlOnNlyKQ(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public static int GeFuYmONqrCHPCIS(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pb148dc18 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.pdacfecb5.pb148dc18) {
            return (p5a445d71.p9f931cf3.pca323100.pdacfecb5.pb148dc18) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pb148dc18(OovNJICqVLBsuiVx(obj));
    }

    public static p5a445d71.p9f931cf3.pca323100.pb907b377 WUlLTllyYNuDdOwd(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.pb907b377.m8bab0102(p582a4948Var, z);
    }

    public static bool YhwtlsTlveiGSMGd(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public p5a445d71.p9f931cf3.pca323100.pb907b377 GetNotAfter() {
        return this.f33877890;
    }

    public p5a445d71.p9f931cf3.pca323100.pb907b377 GetNotBefore() {
        return this.f172ceab9;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((9 + 9) % 9 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        if (this.f172ceab9 is not null) {
            dJzUGekUBffrMEcP(pd6ccb7fcVar, new p5a445d71.p9f931cf3.pca323100.p87af127c(false, 0, (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) this.f172ceab9));
        }
        if (this.f33877890 is not null) {
            KxURZySzsKVXGgEF(pd6ccb7fcVar, new p5a445d71.p9f931cf3.pca323100.p87af127c(false, 1, (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) this.f33877890));
        }
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

