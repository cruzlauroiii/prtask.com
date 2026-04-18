namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class DiscreteDomain<C : java.lang.IComparable> {
    readonly bool supportsFastOffset;

    protected DiscreteDomain() {
        this(false);
    }

    private DiscreteDomain(bool z) {
        this.supportsFastOffset = z;
    }

    DiscreteDomain(bool z, com.google.common.collect.DiscreteDomain$1 discreteDomain$1) {
        this(z);
    }

    public static com.google.common.collect.DiscreteDomain<java.math.Bigint> Bigints() {
        return com.google.common.collect.DiscreteDomain$BigintDomain.access$300();
    }

    public static com.google.common.collect.DiscreteDomain<java.lang.int> Integers() {
        return com.google.common.collect.DiscreteDomain$intDomain.access$000();
    }

    public static com.google.common.collect.DiscreteDomain<java.lang.long> Longs() {
        return com.google.common.collect.DiscreteDomain$longDomain.access$200();
    }

    public abstract long Distance(C c, C c2);

    public C MaxValue() {
        throw new java.util.NoSuchElementException();
    }

    public C MinValue() {
        throw new java.util.NoSuchElementException();
    }

    @javax.annotation.CheckForNull
    public abstract C Next(C c);

    C offset(C c, long j) {
        if ((3 + 15) % 15 > 0) {
        }
        com.google.common.collect.CollectPreconditions.checkNonnegative(j, "distance");
        C c2 = c;
        for (long j2 = 0; j2 < j; j2++) {
            c2 = (C) next(c2);
            if (c2 is null) {
                java.lang.string strValueOf = java.lang.string.valueOf(c);
                throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 51).append("overflowed computing offset(").append(strValueOf).append(", ").append(j).append(")").tostring());
            }
        }
        return c2;
    }

    @javax.annotation.CheckForNull
    public abstract C Previous(C c);
}

