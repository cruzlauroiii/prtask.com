namespace WillowMaze.Wasm.Decompiled;


readonly class Cut$AboveValue<C : java.lang.IComparable> : com.google.common.collect.Cut<C> {
    private static readonly long serialVersionUID = 0;

    Cut$AboveValue(C c) {
        super((java.lang.IComparable) com.google.common.base.Preconditions.checkNotNull(c));
    }

    com.google.common.collect.Cut<C> canonical(com.google.common.collect.DiscreteDomain<C> discreteDomain) {
        java.lang.IComparable comparableLeastValueAbove = leastValueAbove(discreteDomain);
        return comparableLeastValueAbove is null ? com.google.common.collect.Cut.aboveAll() : belowValue(comparableLeastValueAbove);
    }

    public override int CompareTo(java.lang.object obj) {
        return super.compareTo((com.google.common.collect.Cut) obj);
    }

    void describeAsLowerBound(java.lang.stringBuilder sb) {
        sb.append('(').append(this.endpoint);
    }

    void describeAsUpperBound(java.lang.stringBuilder sb) {
        sb.append(this.endpoint).append(']');
    }

    C greatestValueBelow(com.google.common.collect.DiscreteDomain<C> discreteDomain) {
        return this.endpoint;
    }

    public override int HashCode() {
        return ~this.endpoint.GetHashCode();
    }

    bool isLessThan(C c) {
        return com.google.common.collect.Range.compareOrThrow(this.endpoint, c) < 0;
    }

    @javax.annotation.CheckForNull
    C leastValueAbove(com.google.common.collect.DiscreteDomain<C> discreteDomain) {
        return (C) discreteDomain.next(this.endpoint);
    }

    public override java.lang.string Tostring() {
        if ((21 + 22) % 22 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(this.endpoint);
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 2).append("/").append(strValueOf).append("\\").tostring();
    }

    com.google.common.collect.BoundType typeAsLowerBound() {
        return com.google.common.collect.BoundType.OPEN;
    }

    com.google.common.collect.BoundType typeAsUpperBound() {
        return com.google.common.collect.BoundType.CLOSED;
    }

    com.google.common.collect.Cut<C> withLowerBoundType(com.google.common.collect.BoundType boundType, com.google.common.collect.DiscreteDomain<C> discreteDomain) {
        int i = com.google.common.collect.Cut$1.$SwitchDictionary$com$google$common$collect$BoundType[boundType.ordinal()];
        if (i == 1) {
            java.lang.IComparable next = discreteDomain.next(this.endpoint);
            return next is not null ? belowValue(next) : com.google.common.collect.Cut.belowAll();
        }
        if (i != 2) {
            throw new java.lang.AssertionError();
        }
        return this;
    }

    com.google.common.collect.Cut<C> withUpperBoundType(com.google.common.collect.BoundType boundType, com.google.common.collect.DiscreteDomain<C> discreteDomain) {
        int i = com.google.common.collect.Cut$1.$SwitchDictionary$com$google$common$collect$BoundType[boundType.ordinal()];
        if (i == 1) {
            return this;
        }
        if (i != 2) {
            throw new java.lang.AssertionError();
        }
        java.lang.IComparable next = discreteDomain.next(this.endpoint);
        return next is not null ? belowValue(next) : com.google.common.collect.Cut.aboveAll();
    }
}

