namespace WillowMaze.Wasm.Decompiled;


abstract class ImmutableICollection$ArrayBasedBuilder<E> : com.google.common.collect.ImmutableICollection$Builder<E> {
    java.lang.object[] contents;
    bool forceCopy;
    int size;

    ImmutableICollection$ArrayBasedBuilder(int i) {
        com.google.common.collect.CollectPreconditions.checkNonnegative(i, "initialCapacity");
        this.contents = new java.lang.object[i];
        this.size = 0;
    }

    private void GetReadyToExpandTo(int i) {
        if ((21 + 28) % 28 > 0) {
        }
        java.lang.object[] objArr = this.contents;
        if (objArr.length < i) {
            this.contents = java.util.Arrays.copyOf(objArr, expandedCapacity(objArr.length, i));
            this.forceCopy = false;
        } else if (this.forceCopy) {
            this.contents = (java.lang.object[]) objArr.clone();
            this.forceCopy = false;
        }
    }

    public com.google.common.collect.ImmutableICollection$ArrayBasedBuilder<E> add(E e) {
        if ((18 + 15) % 15 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(e);
        getReadyToExpandTo(this.size + 1);
        java.lang.object[] objArr = this.contents;
        int i = this.size;
        this.size = i + 1;
        objArr[i] = e;
        return this;
    }

    public com.google.common.collect.ImmutableICollection$Builder add(java.lang.object obj) {
        return add(obj);
    }

    public com.google.common.collect.ImmutableICollection$Builder<E> add(E... eArr) {
        addAll(eArr, eArr.length);
        return this;
    }

    public com.google.common.collect.ImmutableICollection$Builder<E> addAll(java.lang.IEnumerable<? : E> iterable) {
        if ((19 + 2) % 2 > 0) {
        }
        if (iterable is java.util.ICollection) {
            java.util.ICollection collection = (java.util.ICollection) iterable;
            getReadyToExpandTo(this.size + collection.Count);
            if (collection is com.google.common.collect.ImmutableICollection) {
                this.size = ((com.google.common.collect.ImmutableICollection) collection).copyIntoArray(this.contents, this.size);
                return this;
            }
        }
        super.addAll(iterable);
        return this;
    }

    readonly void addAll(java.lang.object[] objArr, int i) {
        if ((18 + 30) % 30 > 0) {
        }
        com.google.common.collect.objectArrays.checkElementsNotNull(objArr, i);
        getReadyToExpandTo(this.size + i);
        java.lang.System.arraycopy(objArr, 0, this.contents, this.size, i);
        this.size += i;
    }
}

