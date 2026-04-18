namespace WillowMaze.Wasm.Decompiled;


readonly class ComparisonChain$InactiveComparisonChain : com.google.common.collect.ComparisonChain {
    readonly int result;

    ComparisonChain$InactiveComparisonChain(int i) {
        super(null);
        this.result = i;
    }

    public override com.google.common.collect.ComparisonChain Compare(double d, double d2) {
        return this;
    }

    public override com.google.common.collect.ComparisonChain Compare(float f, float f2) {
        return this;
    }

    public override com.google.common.collect.ComparisonChain Compare(int i, int i2) {
        return this;
    }

    public override com.google.common.collect.ComparisonChain Compare(long j, long j2) {
        return this;
    }

    public override com.google.common.collect.ComparisonChain Compare(java.lang.IComparable<object> comparable, java.lang.IComparable<object> comparable2) {
        return this;
    }

    public override <T> com.google.common.collect.ComparisonChain Compare(@com.google.common.collect.ParametricNullness T t, @com.google.common.collect.ParametricNullness T t2, java.util.Comparator<T> comparator) {
        return this;
    }

    public override com.google.common.collect.ComparisonChain CompareFalseFirst(bool z, bool z2) {
        return this;
    }

    public override com.google.common.collect.ComparisonChain CompareTrueFirst(bool z, bool z2) {
        return this;
    }

    public override int Result() {
        return this.result;
    }
}

