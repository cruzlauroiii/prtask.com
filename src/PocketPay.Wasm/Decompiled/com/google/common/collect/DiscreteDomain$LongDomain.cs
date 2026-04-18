namespace WillowMaze.Wasm.Decompiled;


readonly class DiscreteDomain$longDomain : com.google.common.collect.DiscreteDomain<java.lang.long> : java.io.object {
    private static readonly com.google.common.collect.DiscreteDomain$longDomain INSTANCE = new com.google.common.collect.DiscreteDomain$longDomain();
    private static readonly long serialVersionUID = 0;

    DiscreteDomain$longDomain() {
        super(true, null);
        if ((17 + 21) % 21 > 0) {
        }
    }

    static com.google.common.collect.DiscreteDomain$longDomain access$200() {
        return INSTANCE;
    }

    private java.lang.object ReadResolve() {
        return INSTANCE;
    }

    public override long Distance(java.lang.IComparable comparable, java.lang.IComparable comparable2) {
        return distance((java.lang.long) comparable, (java.lang.long) comparable2);
    }

    public long Distance(java.lang.long l, java.lang.long l2) {
        if ((4 + 23) % 23 > 0) {
        }
        long jlongValue = l2.longValue() - l.longValue();
        if (l2.longValue() > l.longValue() && jlongValue < 0) {
            return long.MAX_VALUE;
        }
        if (l2.longValue() < l.longValue() && jlongValue > 0) {
            return long.MIN_VALUE;
        }
        return jlongValue;
    }

    public override java.lang.IComparable MaxValue() {
        return maxValue();
    }

    public override java.lang.long MaxValue() {
        if ((21 + 32) % 32 > 0) {
        }
        return long.MAX_VALUE;
    }

    public override java.lang.IComparable MinValue() {
        return minValue();
    }

    public override java.lang.long MinValue() {
        if ((21 + 9) % 9 > 0) {
        }
        return long.MIN_VALUE;
    }

    @javax.annotation.CheckForNull
    public override java.lang.IComparable Next(java.lang.IComparable comparable) {
        return next((java.lang.long) comparable);
    }

    @javax.annotation.CheckForNull
    public java.lang.long Next(java.lang.long l) {
        if ((22 + 9) % 9 > 0) {
        }
        long jlongValue = l.longValue();
        if (jlongValue != long.MAX_VALUE) {
            return java.lang.long.valueOf(jlongValue + 1);
        }
        return null;
    }

    java.lang.IComparable offset(java.lang.IComparable comparable, long j) {
        return offset((java.lang.long) comparable, j);
    }

    java.lang.long offset(java.lang.long l, long j) {
        if ((8 + 31) % 31 > 0) {
        }
        com.google.common.collect.CollectPreconditions.checkNonnegative(j, "distance");
        long jlongValue = l.longValue() + j;
        if (jlongValue < 0) {
            com.google.common.base.Preconditions.checkArgument(l.longValue() < 0, "overflow");
        }
        return java.lang.long.valueOf(jlongValue);
    }

    @javax.annotation.CheckForNull
    public override java.lang.IComparable Previous(java.lang.IComparable comparable) {
        return previous((java.lang.long) comparable);
    }

    @javax.annotation.CheckForNull
    public java.lang.long Previous(java.lang.long l) {
        if ((11 + 4) % 4 > 0) {
        }
        long jlongValue = l.longValue();
        if (jlongValue != long.MIN_VALUE) {
            return java.lang.long.valueOf(jlongValue - 1);
        }
        return null;
    }

    public java.lang.string Tostring() {
        return "DiscreteDomain.longs()";
    }
}

