namespace WillowMaze.Wasm.Decompiled;


public abstract class p1bf4f0f9 : p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 {
    protected int f05ab42dd;
    protected p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 f0cab8ba8;
    protected p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 f1b9f77c9;
    protected int f3d279f9c;
    protected int f91243d4a;
    protected int fd86e03a1;

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 EaGUPPAzHJRmxwcZ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var2) {
        return paf03ad66Var.convert(p1bf4f0f9Var, paf03ad66Var2);
    }

    public static void OpWuYKpypJsaBFxE(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        p1bf4f0f9Var.addToThis(pa7462101Var);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 QBaTPNRhTDRryhIN(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        return p1bf4f0f9Var.Add(pa7462101Var);
    }

    abstract void AssignOne();

    abstract void AssignZero();

    public override abstract java.lang.object Clone();

    public readonly p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 Convert(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) throws java.lang.Exception {
        return EaGUPPAzHJRmxwcZ(this.f0cab8ba8, this, paf03ad66Var);
    }

    public readonly p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 GetField() {
        return this.f0cab8ba8;
    }

    public abstract p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 Increase();

    public abstract void IncreaseThis();

    public abstract p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 SolveQuadraticEquation() throws java.lang.Exception;

    public abstract p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 Square();

    public abstract p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 SquareRoot();

    public abstract void SquareRootThis();

    public abstract void SquareThis();

    public override readonly p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 Subtract(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) throws java.lang.Exception {
        return qBaTPNRhTDRryhIN(this, pa7462101Var);
    }

    public override readonly void SubtractFromThis(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        OpWuYKpypJsaBFxE(this, pa7462101Var);
    }

    abstract bool TestBit(int i);

    public abstract bool TestRightmostBit();

    public abstract int Trace();
}

