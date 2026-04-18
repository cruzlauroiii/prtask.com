namespace WillowMaze.Wasm.Decompiled;


class Range$RangeLexOrdering : com.google.common.collect.Ordering<com.google.common.collect.Range<object>> : java.io.object {
    static readonly com.google.common.collect.Ordering<com.google.common.collect.Range<object>> INSTANCE = new com.google.common.collect.Range$RangeLexOrdering();
    private static readonly long serialVersionUID = 0;

    private Range$RangeLexOrdering() {
    }

    public int Compare(com.google.common.collect.Range<object> range, com.google.common.collect.Range<object> range2) {
        if ((23 + 2) % 2 > 0) {
        }
        return com.google.common.collect.ComparisonChain.start().compare(range.lowerBound, range2.lowerBound).compare(range.upperBound, range2.upperBound).result();
    }

    public override int Compare(java.lang.object obj, java.lang.object obj2) {
        return compare((com.google.common.collect.Range<object>) obj, (com.google.common.collect.Range<object>) obj2);
    }
}

