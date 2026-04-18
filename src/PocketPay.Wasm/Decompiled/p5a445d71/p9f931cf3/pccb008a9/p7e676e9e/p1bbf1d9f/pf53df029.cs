namespace WillowMaze.Wasm.Decompiled;


public abstract class pf53df029 {
    public static readonly char f0fbb33d2 = 'L';
    public static readonly char f15229927 = 'I';
    public static readonly char f21a2cfa6 = 'R';
    public static readonly char f2392e8fc = 'L';
    public static readonly char f239c61ef = 'I';
    public static readonly char f3a364328 = 'Z';
    public static readonly char f4772d0c7 = 'I';
    public static readonly char f47f6e009 = 'R';
    public static readonly char f5268dc3e = 'R';
    public static readonly char f5a7b279a = 'I';
    public static readonly char f63f2d460 = 'Z';
    public static readonly char f7a211690 = 'L';
    public static readonly char f80cbe963 = 'U';
    public static readonly char f997c0564 = 'U';
    public static readonly char fe32cdb56 = 'Z';
    protected int f6c3c60d8;
    protected int f998ea976;
    protected int fd1944e2f;
    protected int fef210cbe;

    public abstract p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 ComputeInverse();

    public abstract byte[] GetEncoded();

    public int GetNumColumns() {
        return this.fd1944e2f;
    }

    public int GetNumRows() {
        return this.f998ea976;
    }

    public abstract bool IsZero();

    public abstract p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 LeftMultiply(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 p57dea6f5Var);

    public abstract p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 RightMultiply(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 p57dea6f5Var);

    public abstract p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 RightMultiply(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 pf53df029Var);

    public abstract p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 RightMultiply(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar);

    public abstract java.lang.string Tostring();
}

