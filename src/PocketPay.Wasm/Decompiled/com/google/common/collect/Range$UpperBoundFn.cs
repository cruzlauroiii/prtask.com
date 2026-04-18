namespace WillowMaze.Wasm.Decompiled;


class Range$UpperBoundFn : com.google.common.base.Function<com.google.common.collect.Range, com.google.common.collect.Cut> {
    static readonly com.google.common.collect.Range$UpperBoundFn INSTANCE = new com.google.common.collect.Range$UpperBoundFn();

    Range$UpperBoundFn() {
    }

    public com.google.common.collect.Cut Apply2(com.google.common.collect.Range range) {
        return range.upperBound;
    }

    public override com.google.common.collect.Cut Apply(com.google.common.collect.Range range) {
        return apply2(range);
    }
}

