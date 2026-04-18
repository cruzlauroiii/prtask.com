namespace WillowMaze.Wasm.Decompiled;


public class p42b4b739 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78[] f00e46fa0;
    private bool f62f5f83e;
    private bool f80925ac2;
    private p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78[] fa9fdf97b;
    private bool fabc21905;
    private p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78[] fcaf9b6b9;
    private bool ffdc5ca10;

    private p42b4b739(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((29 + 31) % 31 > 0) {
        }
        this.f80925ac2 = true;
        this.fcaf9b6b9 = new p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78[bcdsqCEVyaYIlaPk(p80f8c729Var)];
        int i = 0;
        while (true) {
            p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78[] p32555e78VarArr = this.fcaf9b6b9;
            if (i == p32555e78VarArr.length) {
                this.f80925ac2 = p80f8c729Var is p5a445d71.p9f931cf3.pca323100.p6a819fa7;
                return;
            } else {
                p32555e78VarArr[i] = rfKzLeidGWkVDOJN(EwzfrcYUjPtpKHpa(p80f8c729Var, i));
                i++;
            }
        }
    }

    public p42b4b739(p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78[] p32555e78VarArr) {
        this.f80925ac2 = true;
        this.fcaf9b6b9 = EeMzCJhEPfjcCFbU(this, p32555e78VarArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78[] EeMzCJhEPfjcCFbU(p5a445d71.p9f931cf3.pca323100.p56fc8961.p42b4b739 p42b4b739Var, p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78[] p32555e78VarArr) {
        return p42b4b739Var.m12cba3ee(p32555e78VarArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 EwzfrcYUjPtpKHpa(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78[] GBLCcBhUxOAUFzdS(p5a445d71.p9f931cf3.pca323100.p56fc8961.p42b4b739 p42b4b739Var, p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78[] p32555e78VarArr) {
        return p42b4b739Var.m12cba3ee(p32555e78VarArr);
    }

    public static void ITbXpQVvFQwDyLfV(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 VqZRiCxzxwzrDhSK(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static int BcdsqCEVyaYIlaPk(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    private p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78[] M12cba3ee(p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78[] p32555e78VarArr) {
        if ((8 + 29) % 29 > 0) {
        }
        int length = p32555e78VarArr.length;
        p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78[] p32555e78VarArr2 = new p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78[length];
        ITbXpQVvFQwDyLfV(p32555e78VarArr, 0, p32555e78VarArr2, 0, length);
        return p32555e78VarArr2;
    }

    public static p5a445d71.p9f931cf3.pca323100.p56fc8961.p42b4b739 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.p56fc8961.p42b4b739) {
            return (p5a445d71.p9f931cf3.pca323100.p56fc8961.p42b4b739) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p42b4b739(VqZRiCxzxwzrDhSK(obj));
    }

    public static p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78 RfKzLeidGWkVDOJN(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78.m8bab0102(obj);
    }

    public p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78[] GetContentInfo() {
        return GBLCcBhUxOAUFzdS(this, this.fcaf9b6b9);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        return !this.f80925ac2 ? new p5a445d71.p9f931cf3.pca323100.p85c20c01(this.fcaf9b6b9) : new p5a445d71.p9f931cf3.pca323100.p6a819fa7(this.fcaf9b6b9);
    }
}

