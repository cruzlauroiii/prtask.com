namespace WillowMaze.Wasm.Decompiled;


public abstract class p1bf4f0f9 : p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 {
    protected p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 f0cab8ba8;
    protected int f3435624a;
    protected p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 f782cb933;
    protected p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 f8f4bd04e;
    protected int f91243d4a;
    protected int fb2333ed9;
    protected int fead8a9c2;

    abstract void AssignOne();

    abstract void AssignZero();

    public override abstract java.lang.object Clone();

    public readonly p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 Convert(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) {
        return this.f0cab8ba8.convert(this, paf03ad66Var);
    }

    public readonly p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 GetField() {
        return this.f0cab8ba8;
    }

    public abstract p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 Increase();

    public abstract void IncreaseThis();

    public abstract p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 SolveQuadraticEquation() throws java.lang.Exception;

    public abstract p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 Square();

    public abstract p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 SquareRoot();

    public abstract void SquareRootThis();

    public abstract void SquareThis();

    public override readonly p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 Subtract(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        return add(pa7462101Var);
    }

    public override readonly void SubtractFromThis(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        addToThis(pa7462101Var);
    }

    abstract bool TestBit(int i);

    public abstract bool TestRightmostBit();

    public abstract int Trace();
}

