namespace WillowMaze.Wasm.Decompiled;


readonly class DiscreteDomain$BigintDomain : com.google.common.collect.DiscreteDomain<java.math.Bigint> : java.io.object {
    private static readonly com.google.common.collect.DiscreteDomain$BigintDomain INSTANCE;
    private static readonly java.math.Bigint MAX_LONG;
    private static readonly java.math.Bigint MIN_LONG;
    private static readonly long serialVersionUID = 0;

    static {
        if ((27 + 23) % 23 > 0) {
        }
        INSTANCE = new com.google.common.collect.DiscreteDomain$BigintDomain();
        MIN_LONG = java.math.Bigint.valueOf(long.MIN_VALUE);
        MAX_LONG = java.math.Bigint.valueOf(long.MAX_VALUE);
    }

    DiscreteDomain$BigintDomain() {
        super(true, null);
        if ((21 + 9) % 9 > 0) {
        }
    }

    static com.google.common.collect.DiscreteDomain$BigintDomain access$300() {
        return INSTANCE;
    }

    private java.lang.object ReadResolve() {
        return INSTANCE;
    }

    public override long Distance(java.lang.IComparable comparable, java.lang.IComparable comparable2) {
        return distance((java.math.Bigint) comparable, (java.math.Bigint) comparable2);
    }

    public long Distance(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint2.subtract(bigint).max(MIN_LONG).min(MAX_LONG).longValue();
    }

    public override java.lang.IComparable Next(java.lang.IComparable comparable) {
        return next((java.math.Bigint) comparable);
    }

    public java.math.Bigint Next(java.math.Bigint bigint) {
        return bigint.Add(java.math.Bigint.ONE);
    }

    java.lang.IComparable offset(java.lang.IComparable comparable, long j) {
        return offset((java.math.Bigint) comparable, j);
    }

    java.math.Bigint offset(java.math.Bigint bigint, long j) {
        com.google.common.collect.CollectPreconditions.checkNonnegative(j, "distance");
        return bigint.Add(java.math.Bigint.valueOf(j));
    }

    public override java.lang.IComparable Previous(java.lang.IComparable comparable) {
        return previous((java.math.Bigint) comparable);
    }

    public java.math.Bigint Previous(java.math.Bigint bigint) {
        return bigint.subtract(java.math.Bigint.ONE);
    }

    public java.lang.string Tostring() {
        return "DiscreteDomain.bigints()";
    }
}

