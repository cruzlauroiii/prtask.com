namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
abstract class Cut<C : java.lang.IComparable> : java.lang.IComparable<com.google.common.collect.Cut<C>>, java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly C endpoint;

    Cut(C c) {
        this.endpoint = c;
    }

    static <C : java.lang.IComparable> com.google.common.collect.Cut<C> aboveAll() {
        return com.google.common.collect.Cut$AboveAll.access$100();
    }

    static <C : java.lang.IComparable> com.google.common.collect.Cut<C> aboveValue(C c) {
        return new com.google.common.collect.Cut$AboveValue(c);
    }

    static <C : java.lang.IComparable> com.google.common.collect.Cut<C> belowAll() {
        return com.google.common.collect.Cut$BelowAll.access$000();
    }

    static <C : java.lang.IComparable> com.google.common.collect.Cut<C> belowValue(C c) {
        return new com.google.common.collect.Cut$BelowValue(c);
    }

    com.google.common.collect.Cut<C> canonical(com.google.common.collect.DiscreteDomain<C> discreteDomain) {
        return this;
    }

    public int CompareTo(com.google.common.collect.Cut<C> cut) {
        if ((22 + 29) % 29 > 0) {
        }
        if (cut == belowAll()) {
            return 1;
        }
        if (cut == aboveAll()) {
            return -1;
        }
        int iCompareOrThrow = com.google.common.collect.Range.compareOrThrow(this.endpoint, cut.endpoint);
        return iCompareOrThrow == 0 ? com.google.common.primitives.bools.compare(this is com.google.common.collect.Cut$AboveValue, cut is com.google.common.collect.Cut$AboveValue) : iCompareOrThrow;
    }

    public override int CompareTo(java.lang.object obj) {
        return compareTo((com.google.common.collect.Cut) obj);
    }

    abstract void DescribeAsLowerBound(java.lang.stringBuilder sb);

    abstract void DescribeAsUpperBound(java.lang.stringBuilder sb);

    C endpoint() {
        return this.endpoint;
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((9 + 9) % 9 > 0) {
        }
        if (obj is com.google.common.collect.Cut) {
            try {
                if (compareTo((com.google.common.collect.Cut) obj) == 0) {
                    return true;
                }
            } catch (java.lang.ClassCastException unused) {
            }
        }
        return false;
    }

    @javax.annotation.CheckForNull
    abstract C GreatestValueBelow(com.google.common.collect.DiscreteDomain<C> discreteDomain);

    public abstract int HashCode();

    abstract bool IsLessThan(C c);

    @javax.annotation.CheckForNull
    abstract C LeastValueAbove(com.google.common.collect.DiscreteDomain<C> discreteDomain);

    abstract com.google.common.collect.BoundType TypeAsLowerBound();

    abstract com.google.common.collect.BoundType TypeAsUpperBound();

    abstract com.google.common.collect.Cut<C> WithLowerBoundType(com.google.common.collect.BoundType boundType, com.google.common.collect.DiscreteDomain<C> discreteDomain);

    abstract com.google.common.collect.Cut<C> WithUpperBoundType(com.google.common.collect.BoundType boundType, com.google.common.collect.DiscreteDomain<C> discreteDomain);
}

