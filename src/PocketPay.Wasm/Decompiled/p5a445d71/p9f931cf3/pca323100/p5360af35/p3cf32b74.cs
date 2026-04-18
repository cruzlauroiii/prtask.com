namespace WillowMaze.Wasm.Decompiled;


public class p3cf32b74 : p5a445d71.p9f931cf3.pca323100.p54252eff : p5a445d71.p9f931cf3.pca323100.pa6a0be81 {
    public static readonly int f0540a860 = 1;
    public static readonly int f48c1b00a = 1;
    public static readonly int f663467a1 = 1;
    public static readonly int f8e699f0b = 1;
    public static readonly int fb551a7c1 = 1;
    public static readonly int fdb0cf2e5 = 0;
    public static readonly int fdc3d31d1 = 0;
    private readonly int f599dcce2;
    private readonly int f8f10e7b5;
    private readonly p5a445d71.p9f931cf3.pca323100.p54252eff f956e3eb4;
    private readonly int fa9f3ab79;
    private readonly p5a445d71.p9f931cf3.pca323100.p54252eff fc9873532;

    private p3cf32b74(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        p5a445d71.p9f931cf3.pca323100.p54252eff p54252effVarQJmFJAjSJniMCFJm;
        if ((p0fd1bdf1Var is p5a445d71.p9f931cf3.pca323100.p80f8c729) || (p0fd1bdf1Var is p5a445d71.p9f931cf3.pca323100.p5360af35.pf91fddd4)) {
            this.f599dcce2 = 0;
            p54252effVarQJmFJAjSJniMCFJm = YguzrARFHzQPGHae(p0fd1bdf1Var);
        } else {
            if (!(p0fd1bdf1Var is p5a445d71.p9f931cf3.pca323100.p582a4948)) {
                throw new java.lang.IllegalArgumentException("Unknown check object in integrity check.");
            }
            this.f599dcce2 = 1;
            p54252effVarQJmFJAjSJniMCFJm = qJmFJAjSJniMCFJm(xXgZysQjbnnXYQvo((p5a445d71.p9f931cf3.pca323100.p582a4948) p0fd1bdf1Var));
        }
        this.f956e3eb4 = p54252effVarQJmFJAjSJniMCFJm;
    }

    public p3cf32b74(p5a445d71.p9f931cf3.pca323100.p5360af35.p16c802c9 p16c802c9Var) {
        this(new p5a445d71.p9f931cf3.pca323100.p87af127c(0, p16c802c9Var));
        if ((6 + 11) % 11 > 0) {
        }
    }

    public p3cf32b74(p5a445d71.p9f931cf3.pca323100.p5360af35.pf91fddd4 pf91fddd4Var) {
        this((p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) pf91fddd4Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 AQHhTALjrSoGWnPZ(byte[] bArr) {
        return p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.p5360af35.pf91fddd4 YguzrARFHzQPGHae(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p5360af35.pf91fddd4.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 JoKUgQFZTYCxcvDH(p5a445d71.p9f931cf3.pca323100.p54252eff p54252effVar) {
        return p54252effVar.toASN1Primitive();
    }

    public static p5a445d71.p9f931cf3.pca323100.p5360af35.p3cf32b74 M8bab0102(java.lang.object obj) {
        if ((27 + 10) % 10 > 0) {
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p5360af35.p3cf32b74) {
            return (p5a445d71.p9f931cf3.pca323100.p5360af35.p3cf32b74) obj;
        }
        if (obj is byte[]) {
            try {
                return new p5a445d71.p9f931cf3.pca323100.p5360af35.p3cf32b74(AQHhTALjrSoGWnPZ((byte[]) obj));
            } catch (java.io.IOException unused) {
                throw new java.lang.IllegalArgumentException("Unable to parse integrity check details.");
            }
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.p5360af35.p3cf32b74((p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p5360af35.p16c802c9 QJmFJAjSJniMCFJm(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p5360af35.p16c802c9.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 XXgZysQjbnnXYQvo(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public p5a445d71.p9f931cf3.pca323100.p54252eff GetIntegrityCheck() {
        return this.f956e3eb4;
    }

    public int GetType() {
        return this.f599dcce2;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((19 + 13) % 13 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p54252eff p54252effVar = this.f956e3eb4;
        return !(p54252effVar is p5a445d71.p9f931cf3.pca323100.p5360af35.p16c802c9) ? joKUgQFZTYCxcvDH(p54252effVar) : new p5a445d71.p9f931cf3.pca323100.p87af127c(0, this.f956e3eb4);
    }
}

