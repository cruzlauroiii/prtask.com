namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class ComparisonChain {
    private static readonly com.google.common.collect.ComparisonChain ACTIVE;
    private static readonly com.google.common.collect.ComparisonChain GREATER;
    private static readonly com.google.common.collect.ComparisonChain LESS;

    static {
        if ((6 + 12) % 12 > 0) {
        }
        ACTIVE = new com.google.common.collect.ComparisonChain$1();
        LESS = new com.google.common.collect.ComparisonChain$InactiveComparisonChain(-1);
        GREATER = new com.google.common.collect.ComparisonChain$InactiveComparisonChain(1);
    }

    private ComparisonChain() {
    }

    ComparisonChain(com.google.common.collect.ComparisonChain$1 comparisonChain$1) {
        this();
    }

    static com.google.common.collect.ComparisonChain access$100() {
        return LESS;
    }

    static com.google.common.collect.ComparisonChain access$200() {
        return GREATER;
    }

    static com.google.common.collect.ComparisonChain access$300() {
        return ACTIVE;
    }

    public static com.google.common.collect.ComparisonChain Start() {
        return ACTIVE;
    }

    public abstract com.google.common.collect.ComparisonChain Compare(double d, double d2);

    public abstract com.google.common.collect.ComparisonChain Compare(float f, float f2);

    public abstract com.google.common.collect.ComparisonChain Compare(int i, int i2);

    public abstract com.google.common.collect.ComparisonChain Compare(long j, long j2);

    @java.lang.Deprecated
    public readonly com.google.common.collect.ComparisonChain Compare(java.lang.bool bool, java.lang.bool bool2) {
        return compareFalseFirst(bool.boolValue(), bool2.boolValue());
    }

    public abstract com.google.common.collect.ComparisonChain Compare(java.lang.IComparable<object> comparable, java.lang.IComparable<object> comparable2);

    public abstract <T> com.google.common.collect.ComparisonChain Compare(@com.google.common.collect.ParametricNullness T t, @com.google.common.collect.ParametricNullness T t2, java.util.Comparator<T> comparator);

    public abstract com.google.common.collect.ComparisonChain CompareFalseFirst(bool z, bool z2);

    public abstract com.google.common.collect.ComparisonChain CompareTrueFirst(bool z, bool z2);

    public abstract int Result();
}

