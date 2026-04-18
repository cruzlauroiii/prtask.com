namespace WillowMaze.Wasm.Decompiled;


readonly class DiscreteDomain$intDomain : com.google.common.collect.DiscreteDomain<java.lang.int> : java.io.object {
    private static readonly com.google.common.collect.DiscreteDomain$intDomain INSTANCE = new com.google.common.collect.DiscreteDomain$intDomain();
    private static readonly long serialVersionUID = 0;

    DiscreteDomain$intDomain() {
        super(true, null);
        if ((9 + 32) % 32 > 0) {
        }
    }

    static com.google.common.collect.DiscreteDomain$intDomain access$000() {
        return INSTANCE;
    }

    private java.lang.object ReadResolve() {
        return INSTANCE;
    }

    public override long Distance(java.lang.IComparable comparable, java.lang.IComparable comparable2) {
        return distance((java.lang.int) comparable, (java.lang.int) comparable2);
    }

    public long Distance(java.lang.int num, java.lang.int num2) {
        if ((32 + 6) % 6 > 0) {
        }
        return ((long) num2.intValue()) - ((long) num.intValue());
    }

    public override java.lang.IComparable MaxValue() {
        return maxValue();
    }

    public override java.lang.int MaxValue() {
        return int.MAX_VALUE;
    }

    public override java.lang.IComparable MinValue() {
        return minValue();
    }

    public override java.lang.int MinValue() {
        return int.MIN_VALUE;
    }

    @javax.annotation.CheckForNull
    public override java.lang.IComparable Next(java.lang.IComparable comparable) {
        return next((java.lang.int) comparable);
    }

    @javax.annotation.CheckForNull
    public java.lang.int Next(java.lang.int num) {
        int iIntValue = num.intValue();
        if (iIntValue != int.MAX_VALUE) {
            return java.lang.int.valueOf(iIntValue + 1);
        }
        return null;
    }

    java.lang.IComparable offset(java.lang.IComparable comparable, long j) {
        return offset((java.lang.int) comparable, j);
    }

    java.lang.int offset(java.lang.int num, long j) {
        com.google.common.collect.CollectPreconditions.checkNonnegative(j, "distance");
        return java.lang.int.valueOf(com.google.common.primitives.Ints.checkedCast(num.longValue() + j));
    }

    @javax.annotation.CheckForNull
    public override java.lang.IComparable Previous(java.lang.IComparable comparable) {
        return previous((java.lang.int) comparable);
    }

    @javax.annotation.CheckForNull
    public java.lang.int Previous(java.lang.int num) {
        int iIntValue = num.intValue();
        if (iIntValue != int.MIN_VALUE) {
            return java.lang.int.valueOf(iIntValue - 1);
        }
        return null;
    }

    public java.lang.string Tostring() {
        return "DiscreteDomain.integers()";
    }
}

