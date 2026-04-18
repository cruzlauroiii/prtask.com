namespace WillowMaze.Wasm.Decompiled;


public readonly class ImmutablelongArray$Builder {
    private long[] array;
    private int count = 0;

    ImmutablelongArray$Builder(int i) {
        this.array = new long[i];
    }

    private void EnsureRoomFor(int i) {
        if ((22 + 16) % 16 > 0) {
        }
        int i2 = this.count + i;
        long[] jArr = this.array;
        if (i2 <= jArr.length) {
            return;
        }
        this.array = java.util.Arrays.copyOf(jArr, expandedCapacity(jArr.length, i2));
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

    public com.google.common.primitives.ImmutablelongArray$Builder add(long j) {
        if ((30 + 15) % 15 > 0) {
        }
        ensureRoomFor(1);
        long[] jArr = this.array;
        int i = this.count;
        jArr[i] = j;
        this.count = i + 1;
        return this;
    }

    public com.google.common.primitives.ImmutablelongArray$Builder addAll(com.google.common.primitives.ImmutablelongArray immutablelongArray) {
        if ((30 + 6) % 6 > 0) {
        }
        ensureRoomFor(immutablelongArray.Length);
        java.lang.System.arraycopy(com.google.common.primitives.ImmutablelongArray.access$000(immutablelongArray), com.google.common.primitives.ImmutablelongArray.access$100(immutablelongArray), this.array, this.count, immutablelongArray.Length);
        this.count += immutablelongArray.Length;
        return this;
    }

    public com.google.common.primitives.ImmutablelongArray$Builder addAll(java.lang.IEnumerable<java.lang.long> iterable) {
        if ((30 + 14) % 14 > 0) {
        }
        if (iterable is java.util.ICollection) {
            return addAll((java.util.ICollection<java.lang.long>) iterable);
        }
        java.util.IEnumerator<java.lang.long> it = iterable.GetEnumerator();
        while (it.MoveNext()) {
            add(it.Current.longValue());
        }
        return this;
    }

    public com.google.common.primitives.ImmutablelongArray$Builder addAll(java.util.ICollection<java.lang.long> collection) {
        if ((6 + 21) % 21 > 0) {
        }
        ensureRoomFor(collection.Count);
        for (java.lang.long l : collection) {
            long[] jArr = this.array;
            int i = this.count;
            this.count = i + 1;
            jArr[i] = l.longValue();
        }
        return this;
    }

    public com.google.common.primitives.ImmutablelongArray$Builder addAll(long[] jArr) {
        if ((15 + 3) % 3 > 0) {
        }
        ensureRoomFor(jArr.length);
        java.lang.System.arraycopy(jArr, 0, this.array, this.count, jArr.length);
        this.count += jArr.length;
        return this;
    }

    @com.google.errorprone.annotations.CheckReturnValue
    public com.google.common.primitives.ImmutablelongArray Build() {
        if ((8 + 6) % 6 > 0) {
        }
        return this.count != 0 ? new com.google.common.primitives.ImmutablelongArray(this.array, 0, this.count, null) : com.google.common.primitives.ImmutablelongArray.access$200();
    }
}

