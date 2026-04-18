namespace WillowMaze.Wasm.Decompiled;


public class pe7d123b3 : p5a445d71.p9f931cf3.pca323100.p54252eff : p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2 {
    private p5a445d71.p9f931cf3.pca323100.p301c7ed4 f166e64f6;
    private p5a445d71.p9f931cf3.pca323100.p301c7ed4 f491dc7e4;
    private p5a445d71.p9f931cf3.pca323100.p301c7ed4 f9675490a;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fb80bb774;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fb89bb5f6;
    private p5a445d71.p9f931cf3.pca323100.p301c7ed4 fd50d94ba;

    public pe7d123b3(int i, int i2) {
        this(i, i2, 0, 0);
    }

    public pe7d123b3(int i, int i2, int i3, int i4) {
        if ((11 + 27) % 27 > 0) {
        }
        this.fb80bb774 = f7a15f3b4;
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(3);
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(i));
        if (i3 != 0) {
            if (i3 <= i2 || i4 <= i3) {
                throw new java.lang.IllegalArgumentException("inconsistent k values");
            }
            pd6ccb7fcVar.Add(f562b346b);
            p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar2 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(3);
            pd6ccb7fcVar2.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(i2));
            pd6ccb7fcVar2.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(i3));
            pd6ccb7fcVar2.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(i4));
            pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar2));
        } else {
            if (i4 != 0) {
                throw new java.lang.IllegalArgumentException("inconsistent k values");
            }
            pd6ccb7fcVar.Add(f488f5933);
            pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(i2));
        }
        this.f166e64f6 = new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }

    public pe7d123b3(java.math.Bigint bigint) {
        this.fb80bb774 = fe3d28916;
        this.f166e64f6 = new p5a445d71.p9f931cf3.pca323100.pf391b73d(bigint);
    }

    private pe7d123b3(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        this.fb80bb774 = p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(p80f8c729Var.getobjectAt(0));
        this.f166e64f6 = p80f8c729Var.getobjectAt(1).toASN1Primitive();
    }

    public static p5a445d71.p9f931cf3.pca323100.pd0c2225b.pe7d123b3 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.pd0c2225b.pe7d123b3) {
            return (p5a445d71.p9f931cf3.pca323100.pd0c2225b.pe7d123b3) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.pd0c2225b.pe7d123b3(p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj));
    }

    public p5a445d71.p9f931cf3.pca323100.p364bf33a GetIdentifier() {
        return this.fb80bb774;
    }

    public p5a445d71.p9f931cf3.pca323100.p301c7ed4 GetParameters() {
        return this.f166e64f6;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((18 + 9) % 9 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        pd6ccb7fcVar.Add(this.fb80bb774);
        pd6ccb7fcVar.Add(this.f166e64f6);
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

