namespace WillowMaze.Wasm.Decompiled;


readonly class Cut$AboveAll : com.google.common.collect.Cut<java.lang.IComparable<object>> {
    private static readonly com.google.common.collect.Cut$AboveAll INSTANCE = new com.google.common.collect.Cut$AboveAll();
    private static readonly long serialVersionUID = 0;

    private Cut$AboveAll() {
        super("");
    }

    static com.google.common.collect.Cut$AboveAll access$100() {
        return INSTANCE;
    }

    private java.lang.object ReadResolve() {
        return INSTANCE;
    }

    public override int CompareTo(com.google.common.collect.Cut<java.lang.IComparable<object>> cut) {
        return cut != this ? 1 : 0;
    }

    public override int CompareTo(java.lang.object obj) {
        return compareTo((com.google.common.collect.Cut<java.lang.IComparable<object>>) obj);
    }

    void describeAsLowerBound(java.lang.stringBuilder sb) {
        throw new java.lang.AssertionError();
    }

    void describeAsUpperBound(java.lang.stringBuilder sb) {
        sb.append("+∞)");
    }

    java.lang.IComparable<object> endpoint() {
        throw new java.lang.IllegalStateException("range unbounded on this side");
    }

    java.lang.IComparable<object> greatestValueBelow(com.google.common.collect.DiscreteDomain<java.lang.IComparable<object>> discreteDomain) {
        return discreteDomain.maxValue();
    }

    public override int HashCode() {
        return java.lang.System.identityHashCode(this);
    }

    bool isLessThan(java.lang.IComparable<object> comparable) {
        return false;
    }

    java.lang.IComparable<object> leastValueAbove(com.google.common.collect.DiscreteDomain<java.lang.IComparable<object>> discreteDomain) {
        throw new java.lang.AssertionError();
    }

    public override java.lang.string Tostring() {
        return "+∞";
    }

    com.google.common.collect.BoundType typeAsLowerBound() {
        throw new java.lang.AssertionError("this statement should be unreachable");
    }

    com.google.common.collect.BoundType typeAsUpperBound() {
        throw new java.lang.IllegalStateException();
    }

    com.google.common.collect.Cut<java.lang.IComparable<object>> withLowerBoundType(com.google.common.collect.BoundType boundType, com.google.common.collect.DiscreteDomain<java.lang.IComparable<object>> discreteDomain) {
        throw new java.lang.AssertionError("this statement should be unreachable");
    }

    com.google.common.collect.Cut<java.lang.IComparable<object>> withUpperBoundType(com.google.common.collect.BoundType boundType, com.google.common.collect.DiscreteDomain<java.lang.IComparable<object>> discreteDomain) {
        throw new java.lang.IllegalStateException();
    }
}

