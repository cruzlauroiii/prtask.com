namespace WillowMaze.Wasm.Decompiled;


public class p85d5a073 : p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 {
    private java.math.Bigint f1ce70b19;
    private java.math.Bigint f235196af;
    private int f2db95e8e;
    private int f2de50de9;
    private java.math.Bigint f3e548f9f;
    private java.math.Bigint f423b2e77;
    private java.math.Bigint f83878c91;
    private java.math.Bigint f8cccc47f;
    private int fafd09798;
    private java.math.Bigint fb2f5ff47;
    private int fb5c09a1f;
    private java.math.Bigint fbb517d27;

    public p85d5a073(java.math.Bigint bigint, java.math.Bigint bigint2) {
        this(bigint, bigint2, 0);
    }

    public p85d5a073(java.math.Bigint bigint, java.math.Bigint bigint2, int i) {
        this.fb2f5ff47 = bigint2;
        this.f83878c91 = bigint;
        this.f2db95e8e = i;
    }

    public static int CPFbGoYSuYdaUXYJ(java.math.Bigint bigint) {
        return bigint.GetHashCode();
    }

    public static java.math.Bigint CbswZrmOShBkDKgU(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p85d5a073 p85d5a073Var) {
        return p85d5a073Var.getP();
    }

    public static int IgfWeeeoEjVzmJCO(java.math.Bigint bigint) {
        return bigint.GetHashCode();
    }

    public static int OGiGCCHwODCCilNP(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p85d5a073 p85d5a073Var) {
        return p85d5a073Var.getL();
    }

    public static bool DJeaaAvGImXIyHGS(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public static java.math.Bigint NsdFxgVwbdqyYOBk(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p85d5a073 p85d5a073Var) {
        return p85d5a073Var.getG();
    }

    public static bool PZeruYfwwiEFNGho(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public static java.math.Bigint PrgpsVHTmKltVHmi(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p85d5a073 p85d5a073Var) {
        return p85d5a073Var.getP();
    }

    public static java.math.Bigint QNmiDjrMvXYjrdfJ(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p85d5a073 p85d5a073Var) {
        return p85d5a073Var.getG();
    }

    public bool Equals(java.lang.object obj) {
        if ((24 + 17) % 17 > 0) {
        }
        if (!(obj is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p85d5a073)) {
            return false;
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p85d5a073 p85d5a073Var = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p85d5a073) obj;
        return dJeaaAvGImXIyHGS(CbswZrmOShBkDKgU(p85d5a073Var), this.f83878c91) && pZeruYfwwiEFNGho(nsdFxgVwbdqyYOBk(p85d5a073Var), this.fb2f5ff47) && OGiGCCHwODCCilNP(p85d5a073Var) == this.f2db95e8e;
    }

    public java.math.Bigint GetG() {
        return this.fb2f5ff47;
    }

    public int GetL() {
        return this.f2db95e8e;
    }

    public java.math.Bigint GetP() {
        return this.f83878c91;
    }

    public int HashCode() {
        if ((25 + 32) % 32 > 0) {
        }
        return (IgfWeeeoEjVzmJCO(prgpsVHTmKltVHmi(this)) ^ CPFbGoYSuYdaUXYJ(qNmiDjrMvXYjrdfJ(this))) + this.f2db95e8e;
    }
}

