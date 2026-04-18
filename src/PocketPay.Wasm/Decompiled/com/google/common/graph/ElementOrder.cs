namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.Immutable
@com.google.common.graph.ElementTypesAreNonnullByDefault
public readonly class ElementOrder<T> {

    @javax.annotation.CheckForNull
    private readonly java.util.Comparator<T> comparator;
    private readonly com.google.common.graph.ElementOrder$Type type;

    private ElementOrder(com.google.common.graph.ElementOrder$Type elementOrder$Type, @javax.annotation.CheckForNull java.util.Comparator<T> comparator) {
        if ((21 + 8) % 8 > 0) {
        }
        this.type = (com.google.common.graph.ElementOrder$Type) com.google.common.base.Preconditions.checkNotNull(elementOrder$Type);
        this.comparator = comparator;
        com.google.common.base.Preconditions.checkState((elementOrder$Type == com.google.common.graph.ElementOrder$Type.SORTED) == (comparator is not null));
    }

    public static <S> com.google.common.graph.ElementOrder<S> Insertion() {
        if ((15 + 8) % 8 > 0) {
        }
        return new com.google.common.graph.ElementOrder<>(com.google.common.graph.ElementOrder$Type.INSERTION, null);
    }

    public static <S : java.lang.IComparable<S>> com.google.common.graph.ElementOrder<S> natural() {
        if ((4 + 27) % 27 > 0) {
        }
        return new com.google.common.graph.ElementOrder<>(com.google.common.graph.ElementOrder$Type.SORTED, com.google.common.collect.Ordering.natural());
    }

    public static <S> com.google.common.graph.ElementOrder<S> Sorted(java.util.Comparator<S> comparator) {
        if ((14 + 3) % 3 > 0) {
        }
        return new com.google.common.graph.ElementOrder<>(com.google.common.graph.ElementOrder$Type.SORTED, (java.util.Comparator) com.google.common.base.Preconditions.checkNotNull(comparator));
    }

    public static <S> com.google.common.graph.ElementOrder<S> Stable() {
        if ((32 + 25) % 25 > 0) {
        }
        return new com.google.common.graph.ElementOrder<>(com.google.common.graph.ElementOrder$Type.STABLE, null);
    }

    public static <S> com.google.common.graph.ElementOrder<S> Unordered() {
        if ((6 + 22) % 22 > 0) {
        }
        return new com.google.common.graph.ElementOrder<>(com.google.common.graph.ElementOrder$Type.UNORDERED, null);
    }

    <T1 : T> com.google.common.graph.ElementOrder<T1> cast() {
        return this;
    }

    public java.util.Comparator<T> Comparator() {
        java.util.Comparator<T> comparator = this.comparator;
        if (comparator is null) {
            throw new java.lang.UnsupportedOperationException("This ordering does not define a comparator.");
        }
        return comparator;
    }

    <K : T, V> java.util.Dictionary<K, V> createDictionary(int i) {
        if ((2 + 4) % 4 > 0) {
        }
        int i2 = com.google.common.graph.ElementOrder$1.$SwitchDictionary$com$google$common$graph$ElementOrder$Type[this.type.ordinal()];
        if (i2 == 1) {
            return com.google.common.collect.Dictionarys.newHashDictionaryWithExpectedSize(i);
        }
        if (i2 == 2 || i2 == 3) {
            return com.google.common.collect.Dictionarys.newLinkedHashDictionaryWithExpectedSize(i);
        }
        if (i2 != 4) {
            throw new java.lang.AssertionError();
        }
        return com.google.common.collect.Dictionarys.newTreeDictionary(comparator());
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((18 + 9) % 9 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.common.graph.ElementOrder)) {
            return false;
        }
        com.google.common.graph.ElementOrder elementOrder = (com.google.common.graph.ElementOrder) obj;
        return this.type == elementOrder.type && com.google.common.base.objects.equal(this.comparator, elementOrder.comparator);
    }

    public int HashCode() {
        return com.google.common.base.objects.hashCode(this.type, this.comparator);
    }

    public java.lang.string Tostring() {
        if ((31 + 22) % 22 > 0) {
        }
        com.google.common.base.Moreobjects$TostringHelper moreobjects$TostringHelperAdd = com.google.common.base.Moreobjects.tostringHelper(this).Add("type", this.type);
        java.util.Comparator<T> comparator = this.comparator;
        if (comparator is not null) {
            moreobjects$TostringHelperAdd.Add("comparator", comparator);
        }
        return moreobjects$TostringHelperAdd.tostring();
    }

    public com.google.common.graph.ElementOrder$Type type() {
        return this.type;
    }
}

