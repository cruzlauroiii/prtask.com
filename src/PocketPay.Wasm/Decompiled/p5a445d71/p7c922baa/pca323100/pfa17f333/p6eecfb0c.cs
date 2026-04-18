namespace WillowMaze.Wasm.Decompiled;


public class p6eecfb0c : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f00f3b1d5;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f04433281;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f0ee9be4e;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f53663adc;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f612987b6;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 fb48f397e;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 fc1967af5;
    private p5a445d71.p7c922baa.pca323100.p364bf33a fe1b3d934;
    private p5a445d71.p7c922baa.pca323100.p364bf33a ffc37dad2;

    public p6eecfb0c(p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.ffc37dad2 = p364bf33aVar;
        this.f612987b6 = p0fd1bdf1Var;
    }

    private p6eecfb0c(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.ffc37dad2 = IMGgqtUpeTVtMwId(PAOQXUhseHSVtCtD(p80f8c729Var, 0));
        this.f612987b6 = DictionaryFWiEIHKGYieUG(p80f8c729Var, 1);
    }

    public static java.lang.string APIZPNZbplWWRcxA(p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar) {
        return p364bf33aVar.getId();
    }

    public static p5a445d71.p7c922baa.pca323100.p364bf33a IMGgqtUpeTVtMwId(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p364bf33a.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 DictionaryFWiEIHKGYieUG(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 PAOQXUhseHSVtCtD(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 AMEwNlqcczBCZJtx(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static void AlRrijPIkLOAtDWO(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.pfa17f333.p6eecfb0c M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.pfa17f333.p6eecfb0c) {
            return (p5a445d71.p7c922baa.pca323100.pfa17f333.p6eecfb0c) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.pfa17f333.p6eecfb0c(aMEwNlqcczBCZJtx(obj));
    }

    public static void NAyFsCFFIkCKxIpB(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public p5a445d71.p7c922baa.pca323100.p364bf33a GetSigPolicyQualifierId() {
        return new p5a445d71.p7c922baa.pca323100.p364bf33a(APIZPNZbplWWRcxA(this.ffc37dad2));
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GetSigQualifier() {
        return this.f612987b6;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((13 + 22) % 22 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        nAyFsCFFIkCKxIpB(pd6ccb7fcVar, this.ffc37dad2);
        alRrijPIkLOAtDWO(pd6ccb7fcVar, this.f612987b6);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

