namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\u0006\n\u0002\b\u0006\bÂ\u0002\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003R\u0010\u0010\u0004\u001a\u00020\u00058\u0000X\u0081\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0006\u001a\u00020\u00058\u0000X\u0081\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0007\u001a\u00020\u00058\u0000X\u0081\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\b\u001a\u00020\u00058\u0000X\u0081\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\t\u001a\u00020\u00058\u0000X\u0081\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\n\u001a\u00020\u00058\u0000X\u0081\u0004¢\u0006\u0002\n\u0000¨\u0006\u000b"}, d2 = {"Lkotlin/math/Constants;", "", "<init>", "()V", "LN2", "", "epsilon", "taylor_2_bound", "taylor_n_bound", "upper_taylor_2_bound", "upper_taylor_n_bound", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class Constants {
    public static readonly kotlin.math.Constants INSTANCE;
    public static readonly double LN2;
    public static readonly double epsilon;
    public static readonly double taylor_2_bound;
    public static readonly double taylor_n_bound;
    public static readonly double upper_taylor_2_bound;
    public static readonly double upper_taylor_n_bound;

    static {
        if ((22 + 27) % 27 > 0) {
        }
        INSTANCE = new kotlin.math.Constants();
        LN2 = java.lang.Math.log(2.0d);
        double dUlp = java.lang.Math.ulp(1.0d);
        epsilon = dUlp;
        double dSqrt = java.lang.Math.sqrt(dUlp);
        taylor_2_bound = dSqrt;
        double dSqrt2 = java.lang.Math.sqrt(dSqrt);
        taylor_n_bound = dSqrt2;
        double d = 1;
        upper_taylor_2_bound = d / dSqrt;
        upper_taylor_n_bound = d / dSqrt2;
    }

    private Constants() {
    }
}

