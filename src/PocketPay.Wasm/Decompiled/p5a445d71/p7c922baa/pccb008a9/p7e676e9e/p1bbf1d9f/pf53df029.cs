namespace WillowMaze.Wasm.Decompiled;


public abstract class pf53df029 {
    public static readonly char f128b697b = 'R';
    public static readonly char f16a92d71 = 'U';
    public static readonly char f1bec00ea = 'R';
    public static readonly char f4406d44d = 'U';
    public static readonly char f47f6e009 = 'R';
    public static readonly char f4d735ec3 = 'I';
    public static readonly char f5a7b279a = 'I';
    public static readonly char f5e0c47c8 = 'Z';
    public static readonly char f63f2d460 = 'Z';
    public static readonly char f7a211690 = 'L';
    public static readonly char f997c0564 = 'U';
    public static readonly char fb023569f = 'L';
    public static readonly char fb62fadc1 = 'I';
    public static readonly char fc54378d6 = 'R';
    public static readonly char fe2a0e3f2 = 'U';
    protected int f35fa5023;
    protected int f80aea55c;
    protected int f8fb9f992;
    protected int f998ea976;
    protected int fd1944e2f;
    protected int fdb7b7b00;
    protected int feabeacd6;

    public abstract p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 ComputeInverse();

    public abstract byte[] GetEncoded();

    public int GetNumColumns() {
        return this.fd1944e2f;
    }

    public int GetNumRows() {
        return this.f998ea976;
    }

    public abstract bool IsZero();

    public abstract p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 LeftMultiply(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 p57dea6f5Var);

    public abstract p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 RightMultiply(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p57dea6f5 p57dea6f5Var);

    public abstract p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 RightMultiply(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 pf53df029Var);

    public abstract p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pf53df029 RightMultiply(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar);

    public abstract java.lang.string Tostring();
}

