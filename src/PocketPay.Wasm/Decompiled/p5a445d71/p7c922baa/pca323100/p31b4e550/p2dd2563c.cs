namespace WillowMaze.Wasm.Decompiled;


public class p2dd2563c : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f2aa51e85;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f8a2b9fb0;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f9a0364b9;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 fd87fdacf;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 fe26c9c97;

    public p2dd2563c(p5a445d71.p7c922baa.pca323100.p31b4e550.p7e9fc7f8 p7e9fc7f8Var) {
        this.f9a0364b9 = new p5a445d71.p7c922baa.pca323100.pb840b7ef(p7e9fc7f8Var);
    }

    private p2dd2563c(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f9a0364b9 = p80f8c729Var;
    }

    public p2dd2563c(p5a445d71.p7c922baa.pca323100.p31b4e550.p7e9fc7f8[] p7e9fc7f8VarArr) {
        if ((3 + 28) % 28 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        for (p5a445d71.p7c922baa.pca323100.p31b4e550.p7e9fc7f8 p7e9fc7f8Var : p7e9fc7f8VarArr) {
            uRtjgDkXKBiMXxhS(pd6ccb7fcVar, p7e9fc7f8Var);
        }
        this.f9a0364b9 = new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 AvXDnDhqVVxsMXdw(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p31b4e550.p7e9fc7f8 UdNtDvohGpiEiNQk(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p31b4e550.p7e9fc7f8.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 VbcgWqavtgziGquC(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p31b4e550.p2dd2563c M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p31b4e550.p2dd2563c) {
            return (p5a445d71.p7c922baa.pca323100.p31b4e550.p2dd2563c) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p31b4e550.p2dd2563c(AvXDnDhqVVxsMXdw(obj));
    }

    public static void URtjgDkXKBiMXxhS(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static int VuaBztLHxmyUxCBI(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.f9a0364b9;
    }

    public p5a445d71.p7c922baa.pca323100.p31b4e550.p7e9fc7f8[] ToInfoTypeAndValueArray() {
        if ((32 + 22) % 22 > 0) {
        }
        int iVuaBztLHxmyUxCBI = vuaBztLHxmyUxCBI(this.f9a0364b9);
        p5a445d71.p7c922baa.pca323100.p31b4e550.p7e9fc7f8[] p7e9fc7f8VarArr = new p5a445d71.p7c922baa.pca323100.p31b4e550.p7e9fc7f8[iVuaBztLHxmyUxCBI];
        for (int i = 0; i != iVuaBztLHxmyUxCBI; i++) {
            p7e9fc7f8VarArr[i] = UdNtDvohGpiEiNQk(VbcgWqavtgziGquC(this.f9a0364b9, i));
        }
        return p7e9fc7f8VarArr;
    }
}

