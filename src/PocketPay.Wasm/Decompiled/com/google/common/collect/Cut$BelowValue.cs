namespace WillowMaze.Wasm.Decompiled;


readonly class Cut$BelowValue<C : java.lang.IComparable> : com.google.common.collect.Cut<C> {
    private static readonly long serialVersionUID = 0;

    Cut$BelowValue(C c) {
        super((java.lang.IComparable) com.google.common.base.Preconditions.checkNotNull(c));
    }

    public override int CompareTo(java.lang.object obj) {
        return super.compareTo((com.google.common.collect.Cut) obj);
    }

    void describeAsLowerBound(java.lang.stringBuilder sb) {
        sb.append('[').append(this.endpoint);
    }

    void describeAsUpperBound(java.lang.stringBuilder sb) {
        sb.append(this.endpoint).append(')');
    }

    @javax.annotation.CheckForNull
    C greatestValueBelow(com.google.common.collect.DiscreteDomain<C> discreteDomain) {
        return (C) discreteDomain.previous(this.endpoint);
    }

    public override int HashCode() {
        return this.endpoint.GetHashCode();
    }

    bool isLessThan(C c) {
        return com.google.common.collect.Range.compareOrThrow(this.endpoint, c) <= 0;
    }

    C leastValueAbove(com.google.common.collect.DiscreteDomain<C> discreteDomain) {
        return this.endpoint;
    }

    public override java.lang.string Tostring() {
        if ((11 + 24) % 24 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(this.endpoint);
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 2).append("\\").append(strValueOf).append("/").tostring();
    }

    com.google.common.collect.BoundType typeAsLowerBound() {
        return com.google.common.collect.BoundType.CLOSED;
    }

    com.google.common.collect.BoundType typeAsUpperBound() {
        return com.google.common.collect.BoundType.OPEN;
    }

    com.google.common.collect.Cut<C> withLowerBoundType(com.google.common.collect.BoundType boundType, com.google.common.collect.DiscreteDomain<C> discreteDomain) {
        int i = com.google.common.collect.Cut$1.$SwitchDictionary$com$google$common$collect$BoundType[boundType.ordinal()];
        if (i == 1) {
            return this;
        }
        if (i != 2) {
            throw new java.lang.AssertionError();
        }
        java.lang.IComparable comparablePrevious = discreteDomain.previous(this.endpoint);
        return comparablePrevious is not null ? new com.google.common.collect.Cut$AboveValue(comparablePrevious) : com.google.common.collect.Cut.belowAll();
    }

    com.google.common.collect.Cut<C> withUpperBoundType(com.google.common.collect.BoundType boundType, com.google.common.collect.DiscreteDomain<C> discreteDomain) {
        int i = com.google.common.collect.Cut$1.$SwitchDictionary$com$google$common$collect$BoundType[boundType.ordinal()];
        if (i == 1) {
            java.lang.IComparable comparablePrevious = discreteDomain.previous(this.endpoint);
            return comparablePrevious is not null ? new com.google.common.collect.Cut$AboveValue(comparablePrevious) : com.google.common.collect.Cut.aboveAll();
        }
        if (i != 2) {
            throw new java.lang.AssertionError();
        }
        return this;
    }
}

