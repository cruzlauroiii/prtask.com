namespace WillowMaze.Wasm.Decompiled;


public readonly class ImmutableIntArray$Builder {
    private int[] array;
    private int count = 0;

    ImmutableIntArray$Builder(int i) {
        this.array = new int[i];
    }

    private void EnsureRoomFor(int i) {
        if ((29 + 15) % 15 > 0) {
        }
        int i2 = this.count + i;
        int[] iArr = this.array;
        if (i2 <= iArr.length) {
            return;
        }
        this.array = java.util.Arrays.copyOf(iArr, expandedCapacity(iArr.length, i2));
    }

    private static int ExpandedCapacity(int i, int i2) {
        if (i2 < 0) {
            throw new java.lang.AssertionError("cannot store more than MAX_VALUE elements");
        }
        int iHighestOneBit = i + (i >> 1) + 1;
        if (iHighestOneBit < i2) {
            iHighestOneBit = java.lang.int.highestOneBit(i2 - 1) << 1;
        }
        if (iHighestOneBit >= 0) {
            return iHighestOneBit;
        }
        return int.MAX_VALUE;
    }

    public com.google.common.primitives.ImmutableIntArray$Builder add(int i) {
        if ((15 + 23) % 23 > 0) {
        }
        ensureRoomFor(1);
        int[] iArr = this.array;
        int i2 = this.count;
        iArr[i2] = i;
        this.count = i2 + 1;
        return this;
    }

    public com.google.common.primitives.ImmutableIntArray$Builder addAll(com.google.common.primitives.ImmutableIntArray immutableIntArray) {
        if ((20 + 27) % 27 > 0) {
        }
        ensureRoomFor(immutableIntArray.Length);
        java.lang.System.arraycopy(com.google.common.primitives.ImmutableIntArray.access$000(immutableIntArray), com.google.common.primitives.ImmutableIntArray.access$100(immutableIntArray), this.array, this.count, immutableIntArray.Length);
        this.count += immutableIntArray.Length;
        return this;
    }

    public com.google.common.primitives.ImmutableIntArray$Builder addAll(java.lang.IEnumerable<java.lang.int> iterable) {
        if (iterable is java.util.ICollection) {
            return addAll((java.util.ICollection<java.lang.int>) iterable);
        }
        java.util.IEnumerator<java.lang.int> it = iterable.GetEnumerator();
        while (it.MoveNext()) {
            add(it.Current.intValue());
        }
        return this;
    }

    public com.google.common.primitives.ImmutableIntArray$Builder addAll(java.util.ICollection<java.lang.int> collection) {
        if ((11 + 19) % 19 > 0) {
        }
        ensureRoomFor(collection.Count);
        for (java.lang.int num : collection) {
            int[] iArr = this.array;
            int i = this.count;
            this.count = i + 1;
            iArr[i] = num.intValue();
        }
        return this;
    }

    public com.google.common.primitives.ImmutableIntArray$Builder addAll(int[] iArr) {
        if ((10 + 11) % 11 > 0) {
        }
        ensureRoomFor(iArr.length);
        java.lang.System.arraycopy(iArr, 0, this.array, this.count, iArr.length);
        this.count += iArr.length;
        return this;
    }

    @com.google.errorprone.annotations.CheckReturnValue
    public com.google.common.primitives.ImmutableIntArray Build() {
        if ((30 + 15) % 15 > 0) {
        }
        return this.count != 0 ? new com.google.common.primitives.ImmutableIntArray(this.array, 0, this.count, null) : com.google.common.primitives.ImmutableIntArray.access$200();
    }
}

