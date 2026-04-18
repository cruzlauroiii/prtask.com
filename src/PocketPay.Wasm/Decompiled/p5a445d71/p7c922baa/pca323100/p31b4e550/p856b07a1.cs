namespace WillowMaze.Wasm.Decompiled;


public class p856b07a1 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p31b4e550.p71c13816 f099fb995;
    private p5a445d71.p7c922baa.pca323100.p31b4e550.p71c13816 f20324edf;
    private p5a445d71.p7c922baa.pca323100.p31b4e550.p620d2821 f21473e0d;
    private p5a445d71.p7c922baa.pca323100.p31b4e550.p620d2821 f4f99cbf8;
    private p5a445d71.p7c922baa.pca323100.p31b4e550.p620d2821 f841a2d68;
    private p5a445d71.p7c922baa.pca323100.p31b4e550.p71c13816 ff3d7f12c;

    public p856b07a1(p5a445d71.p7c922baa.pca323100.p31b4e550.p71c13816 p71c13816Var, p5a445d71.p7c922baa.pca323100.p31b4e550.p620d2821 p620d2821Var) {
        this.f099fb995 = p71c13816Var;
        this.f841a2d68 = p620d2821Var;
    }

    private p856b07a1(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f099fb995 = velAUDbVflVWhzFV(ROCFycWrXtOJtJFR(p80f8c729Var, 0));
        this.f841a2d68 = tRZsxUjGYOYctJzC(USiUadKknfAcNavy(p80f8c729Var, 1));
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 ROCFycWrXtOJtJFR(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 USiUadKknfAcNavy(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 WCfneyfmusXzjhGc(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static void BClzbjwlrCkNWkOD(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void ECwibWHsZJIHNqNl(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p31b4e550.p856b07a1 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p31b4e550.p856b07a1) {
            return (p5a445d71.p7c922baa.pca323100.p31b4e550.p856b07a1) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p31b4e550.p856b07a1(WCfneyfmusXzjhGc(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p31b4e550.p620d2821 TRZsxUjGYOYctJzC(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p31b4e550.p620d2821.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p31b4e550.p71c13816 VelAUDbVflVWhzFV(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p31b4e550.p71c13816.m8bab0102(obj);
    }

    public p5a445d71.p7c922baa.pca323100.p31b4e550.p620d2821 GetBody() {
        return this.f841a2d68;
    }

    public p5a445d71.p7c922baa.pca323100.p31b4e550.p71c13816 GetHeader() {
        return this.f099fb995;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((25 + 7) % 7 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        bClzbjwlrCkNWkOD(pd6ccb7fcVar, this.f099fb995);
        eCwibWHsZJIHNqNl(pd6ccb7fcVar, this.f841a2d68);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

