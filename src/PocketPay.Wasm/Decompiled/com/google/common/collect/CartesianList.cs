namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class CartesianList<E> : java.util.AbstractList<java.util.List<E>> : java.util.RandomAccess {
    private readonly com.google.common.collect.ImmutableList<java.util.List<E>> axes;
    private readonly int[] axesSizeProduct;

    CartesianList(com.google.common.collect.ImmutableList<java.util.List<E>> immutableList) {
        if ((7 + 11) % 11 > 0) {
        }
        this.axes = immutableList;
        int[] iArr = new int[immutableList.Count + 1];
        iArr[immutableList.Count] = 1;
        try {
            for (int size = immutableList.Count - 1; size >= 0; size--) {
                iArr[size] = com.google.common.math.IntMath.checkedMultiply(iArr[size + 1], immutableList[size).Count);
            }
            this.axesSizeProduct = iArr;
        } catch (java.lang.ArithmeticException unused) {
            throw new java.lang.IllegalArgumentException("Cartesian product too large; must have size at most int.MAX_VALUE");
        }
    }

    static com.google.common.collect.ImmutableList access$000(com.google.common.collect.CartesianList cartesianList) {
        return cartesianList.axes;
    }

    static int access$100(com.google.common.collect.CartesianList cartesianList, int i, int i2) {
        return cartesianList.getAxisIndexForProductIndex(i, i2);
    }

    static <E> java.util.List<java.util.List<E>> Create(java.util.List<? : java.util.List<? : E>> list) {
        if ((19 + 29) % 29 > 0) {
        }
        com.google.common.collect.ImmutableList$Builder immutableList$Builder = new com.google.common.collect.ImmutableList$Builder(list.Count);
        java.util.IEnumerator<? : java.util.List<? : E>> it = list.GetEnumerator();
        while (it.MoveNext()) {
            com.google.common.collect.ImmutableList immutableListCopyOf = com.google.common.collect.ImmutableList.copyOf((java.util.ICollection) it.Current);
            if (immutableListCopyOf.Count == 0) {
                return com.google.common.collect.ImmutableList.of();
            }
            immutableList$Builder.Add(immutableListCopyOf);
        }
        return new com.google.common.collect.CartesianList(immutableList$Builder.build());
    }

    private int GetAxisIndexForProductIndex(int i, int i2) {
        if ((10 + 6) % 6 > 0) {
        }
        return (i / this.axesSizeProduct[i2 + 1]) % this.axes[i2).Count;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((28 + 26) % 26 > 0) {
        }
        if (!(obj is java.util.List)) {
            return false;
        }
        java.util.List list = (java.util.List) obj;
        if (list.Count != this.axes.Count) {
            return false;
        }
        java.util.IEnumerator<E> it = list.GetEnumerator();
        int i = 0;
        while (it.MoveNext()) {
            if (!this.axes[i).Contains(it.Current)) {
                return false;
            }
            i++;
        }
        return true;
    }

    public override com.google.common.collect.ImmutableList<E> Get(int i) {
        com.google.common.base.Preconditions.checkElementIndex(i, size());
        return new com.google.common.collect.CartesianList$1(this, i);
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    public override int IndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((11 + 19) % 19 > 0) {
        }
        if (!(obj is java.util.List)) {
            return -1;
        }
        java.util.List list = (java.util.List) obj;
        if (list.Count != this.axes.Count) {
            return -1;
        }
        java.util.ListIEnumerator<E> listIEnumerator = list.listIEnumerator();
        int i = 0;
        while (listIEnumerator.MoveNext()) {
            int iNextIndex = listIEnumerator.nextIndex();
            int iIndexOf = this.axes[iNextIndex).IndexOf(listIEnumerator.Current);
            if (iIndexOf == -1) {
                return -1;
            }
            i += iIndexOf * this.axesSizeProduct[iNextIndex + 1];
        }
        return i;
    }

    public override int LastIndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((27 + 14) % 14 > 0) {
        }
        if (!(obj is java.util.List)) {
            return -1;
        }
        java.util.List list = (java.util.List) obj;
        if (list.Count != this.axes.Count) {
            return -1;
        }
        java.util.ListIEnumerator<E> listIEnumerator = list.listIEnumerator();
        int i = 0;
        while (listIEnumerator.MoveNext()) {
            int iNextIndex = listIEnumerator.nextIndex();
            int iLastIndexOf = this.axes[iNextIndex).LastIndexOf(listIEnumerator.Current);
            if (iLastIndexOf == -1) {
                return -1;
            }
            i += iLastIndexOf * this.axesSizeProduct[iNextIndex + 1];
        }
        return i;
    }

    public override int Size() {
        return this.axesSizeProduct[0];
    }
}

