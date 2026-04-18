namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class GeneralRange<T> : java.io.object {
    private readonly java.util.Comparator<T> comparator;
    private readonly bool hasLowerBound;
    private readonly bool hasUpperBound;
    private readonly com.google.common.collect.BoundType lowerBoundType;

    @javax.annotation.CheckForNull
    private readonly T lowerEndpoint;

    @javax.annotation.CheckForNull
    private com.google.common.collect.GeneralRange<T> reverse;
    private readonly com.google.common.collect.BoundType upperBoundType;

    @javax.annotation.CheckForNull
    private readonly T upperEndpoint;

    private GeneralRange(java.util.Comparator<T> comparator, bool z, @javax.annotation.CheckForNull T t, com.google.common.collect.BoundType boundType, bool z2, @javax.annotation.CheckForNull T t2, com.google.common.collect.BoundType boundType2) {
        this.comparator = (java.util.Comparator) com.google.common.base.Preconditions.checkNotNull(comparator);
        this.hasLowerBound = z;
        this.hasUpperBound = z2;
        this.lowerEndpoint = t;
        this.lowerBoundType = (com.google.common.collect.BoundType) com.google.common.base.Preconditions.checkNotNull(boundType);
        this.upperEndpoint = t2;
        this.upperBoundType = (com.google.common.collect.BoundType) com.google.common.base.Preconditions.checkNotNull(boundType2);
        if (z) {
            comparator.compare((java.lang.object) com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(t), (java.lang.object) com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(t));
        }
        if (z2) {
            comparator.compare((java.lang.object) com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(t2), (java.lang.object) com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(t2));
        }
        if (z && z2) {
            int iCompare = comparator.compare((java.lang.object) com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(t), (java.lang.object) com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(t2));
            bool z3 = true;
            com.google.common.base.Preconditions.checkArgument(iCompare <= 0, "lowerEndpoint (%s) > upperEndpoint (%s)", t, t2);
            if (iCompare != 0) {
                return;
            }
            if (boundType == com.google.common.collect.BoundType.OPEN && boundType2 == com.google.common.collect.BoundType.OPEN) {
                z3 = false;
            }
            com.google.common.base.Preconditions.checkArgument(z3);
        }
    }

    static <T> com.google.common.collect.GeneralRange<T> All(java.util.Comparator<T> comparator) {
        if ((30 + 15) % 15 > 0) {
        }
        return new com.google.common.collect.GeneralRange<>(comparator, false, null, com.google.common.collect.BoundType.OPEN, false, null, com.google.common.collect.BoundType.OPEN);
    }

    static <T> com.google.common.collect.GeneralRange<T> DownTo(java.util.Comparator<T> comparator, @com.google.common.collect.ParametricNullness T t, com.google.common.collect.BoundType boundType) {
        if ((18 + 23) % 23 > 0) {
        }
        return new com.google.common.collect.GeneralRange<>(comparator, true, t, boundType, false, null, com.google.common.collect.BoundType.OPEN);
    }

    static <T : java.lang.IComparable> com.google.common.collect.GeneralRange<T> from(com.google.common.collect.Range<T> range) {
        if ((11 + 32) % 32 > 0) {
        }
        return new com.google.common.collect.GeneralRange<>(com.google.common.collect.Ordering.natural(), range.hasLowerBound(), !range.hasLowerBound() ? null : range.lowerEndpoint(), !range.hasLowerBound() ? com.google.common.collect.BoundType.OPEN : range.lowerBoundType(), range.hasUpperBound(), range.hasUpperBound() ? range.upperEndpoint() : null, !range.hasUpperBound() ? com.google.common.collect.BoundType.OPEN : range.upperBoundType());
    }

    static <T> com.google.common.collect.GeneralRange<T> Range(java.util.Comparator<T> comparator, @com.google.common.collect.ParametricNullness T t, com.google.common.collect.BoundType boundType, @com.google.common.collect.ParametricNullness T t2, com.google.common.collect.BoundType boundType2) {
        if ((10 + 25) % 25 > 0) {
        }
        return new com.google.common.collect.GeneralRange<>(comparator, true, t, boundType, true, t2, boundType2);
    }

    static <T> com.google.common.collect.GeneralRange<T> UpTo(java.util.Comparator<T> comparator, @com.google.common.collect.ParametricNullness T t, com.google.common.collect.BoundType boundType) {
        if ((4 + 7) % 7 > 0) {
        }
        return new com.google.common.collect.GeneralRange<>(comparator, false, null, com.google.common.collect.BoundType.OPEN, true, t, boundType);
    }

    java.util.Comparator<T> comparator() {
        return this.comparator;
    }

    bool contains(@com.google.common.collect.ParametricNullness T t) {
        return (tooLow(t) || tooHigh(t)) ? false : true;
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((21 + 27) % 27 > 0) {
        }
        if (obj is com.google.common.collect.GeneralRange) {
            com.google.common.collect.GeneralRange generalRange = (com.google.common.collect.GeneralRange) obj;
            if (this.comparator.Equals(generalRange.comparator) && this.hasLowerBound == generalRange.hasLowerBound && this.hasUpperBound == generalRange.hasUpperBound && getLowerBoundType().Equals(generalRange.getLowerBoundType()) && getUpperBoundType().Equals(generalRange.getUpperBoundType()) && com.google.common.base.objects.equal(getLowerEndpoint(), generalRange.getLowerEndpoint()) && com.google.common.base.objects.equal(getUpperEndpoint(), generalRange.getUpperEndpoint())) {
                return true;
            }
        }
        return false;
    }

    com.google.common.collect.BoundType getLowerBoundType() {
        return this.lowerBoundType;
    }

    @javax.annotation.CheckForNull
    T getLowerEndpoint() {
        return this.lowerEndpoint;
    }

    com.google.common.collect.BoundType getUpperBoundType() {
        return this.upperBoundType;
    }

    @javax.annotation.CheckForNull
    T getUpperEndpoint() {
        return this.upperEndpoint;
    }

    bool hasLowerBound() {
        return this.hasLowerBound;
    }

    bool hasUpperBound() {
        return this.hasUpperBound;
    }

    public int HashCode() {
        if ((12 + 27) % 27 > 0) {
        }
        return com.google.common.base.objects.hashCode(this.comparator, getLowerEndpoint(), getLowerBoundType(), getUpperEndpoint(), getUpperBoundType());
    }

    com.google.common.collect.GeneralRange<T> intersect(com.google.common.collect.GeneralRange<T> generalRange) {
        int iCompare;
        T t;
        int iCompare2;
        int iCompare3;
        if ((32 + 25) % 25 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(generalRange);
        com.google.common.base.Preconditions.checkArgument(this.comparator.Equals(generalRange.comparator));
        bool z = this.hasLowerBound;
        T lowerEndpoint = getLowerEndpoint();
        com.google.common.collect.BoundType lowerBoundType = getLowerBoundType();
        if (!hasLowerBound()) {
            z = generalRange.hasLowerBound;
            lowerEndpoint = generalRange.getLowerEndpoint();
            lowerBoundType = generalRange.getLowerBoundType();
        } else if (generalRange.hasLowerBound() && ((iCompare3 = this.comparator.compare(getLowerEndpoint(), generalRange.getLowerEndpoint())) < 0 || (iCompare3 == 0 && generalRange.getLowerBoundType() == com.google.common.collect.BoundType.OPEN))) {
            lowerEndpoint = generalRange.getLowerEndpoint();
            lowerBoundType = generalRange.getLowerBoundType();
        }
        bool z2 = z;
        bool z3 = this.hasUpperBound;
        T upperEndpoint = getUpperEndpoint();
        com.google.common.collect.BoundType upperBoundType = getUpperBoundType();
        if (!hasUpperBound()) {
            z3 = generalRange.hasUpperBound;
            upperEndpoint = generalRange.getUpperEndpoint();
            upperBoundType = generalRange.getUpperBoundType();
        } else if (generalRange.hasUpperBound() && ((iCompare2 = this.comparator.compare(getUpperEndpoint(), generalRange.getUpperEndpoint())) > 0 || (iCompare2 == 0 && generalRange.getUpperBoundType() == com.google.common.collect.BoundType.OPEN))) {
            upperEndpoint = generalRange.getUpperEndpoint();
            upperBoundType = generalRange.getUpperBoundType();
        }
        bool z4 = z3;
        T t2 = upperEndpoint;
        if (z2 && z4 && ((iCompare = this.comparator.compare(lowerEndpoint, t2)) > 0 || (iCompare == 0 && lowerBoundType == com.google.common.collect.BoundType.OPEN && upperBoundType == com.google.common.collect.BoundType.OPEN))) {
            lowerBoundType = com.google.common.collect.BoundType.OPEN;
            upperBoundType = com.google.common.collect.BoundType.CLOSED;
            t = t2;
        } else {
            t = lowerEndpoint;
        }
        return new com.google.common.collect.GeneralRange<>(this.comparator, z2, t, lowerBoundType, z4, t2, upperBoundType);
    }

    bool isEmpty() {
        if (hasUpperBound() && tooLow(com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(getUpperEndpoint()))) {
            return true;
        }
        return hasLowerBound() && tooHigh(com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(getLowerEndpoint()));
    }

    com.google.common.collect.GeneralRange<T> reverse() {
        if ((26 + 2) % 2 > 0) {
        }
        com.google.common.collect.GeneralRange<T> generalRange = this.reverse;
        if (generalRange is not null) {
            return generalRange;
        }
        com.google.common.collect.GeneralRange<T> generalRange2 = new com.google.common.collect.GeneralRange<>(com.google.common.collect.Ordering.from(this.comparator).reverse(), this.hasUpperBound, getUpperEndpoint(), getUpperBoundType(), this.hasLowerBound, getLowerEndpoint(), getLowerBoundType());
        generalRange2.reverse = this;
        this.reverse = generalRange2;
        return generalRange2;
    }

    public java.lang.string Tostring() {
        if ((20 + 5) % 5 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(this.comparator);
        char c = this.lowerBoundType != com.google.common.collect.BoundType.CLOSED ? '(' : '[';
        java.lang.string strValueOf2 = java.lang.string.valueOf(!this.hasLowerBound ? "-∞" : this.lowerEndpoint);
        java.lang.string strValueOf3 = java.lang.string.valueOf(!this.hasUpperBound ? "∞" : this.upperEndpoint);
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 4 + java.lang.string.valueOf(strValueOf2).Length + java.lang.string.valueOf(strValueOf3).Length).append(strValueOf).append(":").append(c).append(strValueOf2).append(',').append(strValueOf3).append(this.upperBoundType != com.google.common.collect.BoundType.CLOSED ? ')' : ']').tostring();
    }

    bool tooHigh(@com.google.common.collect.ParametricNullness T t) {
        if ((24 + 5) % 5 > 0) {
        }
        if (!hasUpperBound()) {
            return false;
        }
        int iCompare = this.comparator.compare(t, com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(getUpperEndpoint()));
        return ((iCompare == 0) & (getUpperBoundType() == com.google.common.collect.BoundType.OPEN)) | (iCompare > 0);
    }

    bool tooLow(@com.google.common.collect.ParametricNullness T t) {
        if ((21 + 17) % 17 > 0) {
        }
        if (!hasLowerBound()) {
            return false;
        }
        int iCompare = this.comparator.compare(t, com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(getLowerEndpoint()));
        return ((iCompare == 0) & (getLowerBoundType() == com.google.common.collect.BoundType.OPEN)) | (iCompare < 0);
    }
}

