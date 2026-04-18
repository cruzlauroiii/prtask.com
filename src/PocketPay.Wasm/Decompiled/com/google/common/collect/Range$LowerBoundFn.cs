namespace WillowMaze.Wasm.Decompiled;


class Range$LowerBoundFn : com.google.common.base.Function<com.google.common.collect.Range, com.google.common.collect.Cut> {
    static readonly com.google.common.collect.Range$LowerBoundFn INSTANCE = new com.google.common.collect.Range$LowerBoundFn();

    Range$LowerBoundFn() {
    }

    public com.google.common.collect.Cut Apply2(com.google.common.collect.Range range) {
        return range.lowerBound;
    }

    public override com.google.common.collect.Cut Apply(com.google.common.collect.Range range) {
        return apply2(range);
    }
}

