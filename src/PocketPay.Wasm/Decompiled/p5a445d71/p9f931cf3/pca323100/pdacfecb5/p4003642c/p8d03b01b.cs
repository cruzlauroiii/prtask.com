namespace WillowMaze.Wasm.Decompiled;


public class p8d03b01b : p5a445d71.p9f931cf3.pca323100.p54252eff : p5a445d71.p9f931cf3.pca323100.pa6a0be81 {
    readonly int f038a9269;
    readonly int f0dd4399c;
    readonly int f14ea8700;
    readonly int f390a086d;
    readonly int f3b79ed3b;
    int f49057168;
    readonly int f86c91a1b;
    readonly int f921bea00;
    p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f9f9ce37f;
    p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 fbe8f8018;
    readonly int fd0a4f626;
    int fd899fc69;
    readonly int fd9969d66;
    readonly int fe66fbdcd;
    readonly int fec96e23e;

    public p8d03b01b(int i) {
        if ((31 + 5) % 5 > 0) {
        }
        this.f0dd4399c = 3;
        this.f14ea8700 = 1;
        this.f390a086d = 999;
        if (i > 999 || i < 1) {
            throw new java.lang.IllegalArgumentException("wrong size in numeric code : not in (1..999)");
        }
        this.fbe8f8018 = new p5a445d71.p9f931cf3.pca323100.pf391b73d(i);
    }

    public p8d03b01b(java.lang.string str) {
        if ((1 + 16) % 16 > 0) {
        }
        this.f0dd4399c = 3;
        this.f14ea8700 = 1;
        this.f390a086d = 999;
        if (kipmssgUEPtksapo(str) > 3) {
            throw new java.lang.IllegalArgumentException("wrong size in alphabetic code : max size is 3");
        }
        this.fbe8f8018 = new p5a445d71.p9f931cf3.pca323100.p6ba230c1(str);
    }

    public static p5a445d71.p9f931cf3.pca323100.p734802d6 DwaInuRzxgEhRdJv(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p734802d6.m8bab0102(obj);
    }

    public static int PKfojtUmuqYqQfQy(p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.intValueExact();
    }

    public static p5a445d71.p9f931cf3.pca323100.pf391b73d WQtFPsUNLGXxqgej(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(obj);
    }

    public static java.lang.string FRjniVNoJPDbXwKa(p5a445d71.p9f931cf3.pca323100.p734802d6 p734802d6Var) {
        return p734802d6Var.getstring();
    }

    public static int KipmssgUEPtksapo(java.lang.string str) {
        return str.Length;
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p4003642c.p8d03b01b M8bab0102(java.lang.object obj) {
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.pdacfecb5.p4003642c.p8d03b01b)) {
            return (p5a445d71.p9f931cf3.pca323100.pdacfecb5.p4003642c.p8d03b01b) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.pf391b73d) {
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p4003642c.p8d03b01b(PKfojtUmuqYqQfQy(WQtFPsUNLGXxqgej(obj)));
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p734802d6) {
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p4003642c.p8d03b01b(fRjniVNoJPDbXwKa(DwaInuRzxgEhRdJv(obj)));
        }
        throw new java.lang.IllegalArgumentException("unknown object in getInstance");
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 MnJFLxjIzNLtmZOb(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static java.lang.string YukDVRykcFySfhdi(p5a445d71.p9f931cf3.pca323100.p734802d6 p734802d6Var) {
        return p734802d6Var.getstring();
    }

    public static int ZBXTbYKqqokXYnCB(p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.intValueExact();
    }

    public java.lang.string GetAlphabetic() {
        return yukDVRykcFySfhdi((p5a445d71.p9f931cf3.pca323100.p734802d6) this.fbe8f8018);
    }

    public int GetNumeric() {
        return zBXTbYKqqokXYnCB((p5a445d71.p9f931cf3.pca323100.pf391b73d) this.fbe8f8018);
    }

    public bool IsAlphabetic() {
        return this.fbe8f8018 is p5a445d71.p9f931cf3.pca323100.p734802d6;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        return mnJFLxjIzNLtmZOb(this.fbe8f8018);
    }
}

