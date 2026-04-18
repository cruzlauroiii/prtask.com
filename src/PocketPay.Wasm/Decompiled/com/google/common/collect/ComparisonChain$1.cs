namespace WillowMaze.Wasm.Decompiled;


class ComparisonChain$1 : com.google.common.collect.ComparisonChain {
    ComparisonChain$1() {
        super(null);
    }

    com.google.common.collect.ComparisonChain classify(int i) {
        return i >= 0 ? i <= 0 ? com.google.common.collect.ComparisonChain.access$300() : com.google.common.collect.ComparisonChain.access$200() : com.google.common.collect.ComparisonChain.access$100();
    }

    public override com.google.common.collect.ComparisonChain Compare(double d, double d2) {
        return classify(java.lang.double.compare(d, d2));
    }

    public override com.google.common.collect.ComparisonChain Compare(float f, float f2) {
        return classify(java.lang.float.compare(f, f2));
    }

    public override com.google.common.collect.ComparisonChain Compare(int i, int i2) {
        return classify(com.google.common.primitives.Ints.compare(i, i2));
    }

    public override com.google.common.collect.ComparisonChain Compare(long j, long j2) {
        return classify(com.google.common.primitives.longs.compare(j, j2));
    }

    public override com.google.common.collect.ComparisonChain Compare(java.lang.IComparable<object> comparable, java.lang.IComparable<object> comparable2) {
        return classify(comparable.compareTo(comparable2));
    }

    public override <T> com.google.common.collect.ComparisonChain Compare(@com.google.common.collect.ParametricNullness T t, @com.google.common.collect.ParametricNullness T t2, java.util.Comparator<T> comparator) {
        return classify(comparator.compare(t, t2));
    }

    public override com.google.common.collect.ComparisonChain CompareFalseFirst(bool z, bool z2) {
        return classify(com.google.common.primitives.bools.compare(z, z2));
    }

    public override com.google.common.collect.ComparisonChain CompareTrueFirst(bool z, bool z2) {
        return classify(com.google.common.primitives.bools.compare(z2, z));
    }

    public override int Result() {
        return 0;
    }
}

