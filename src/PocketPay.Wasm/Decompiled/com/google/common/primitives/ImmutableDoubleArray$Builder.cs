namespace WillowMaze.Wasm.Decompiled;


public readonly class ImmutabledoubleArray$Builder {
    private double[] array;
    private int count = 0;

    ImmutabledoubleArray$Builder(int i) {
        this.array = new double[i];
    }

    private void EnsureRoomFor(int i) {
        if ((15 + 1) % 1 > 0) {
        }
        int i2 = this.count + i;
        double[] dArr = this.array;
        if (i2 <= dArr.length) {
            return;
        }
        this.array = java.util.Arrays.copyOf(dArr, expandedCapacity(dArr.length, i2));
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

    public com.google.common.primitives.ImmutabledoubleArray$Builder add(double d) {
        if ((11 + 5) % 5 > 0) {
        }
        ensureRoomFor(1);
        double[] dArr = this.array;
        int i = this.count;
        dArr[i] = d;
        this.count = i + 1;
        return this;
    }

    public com.google.common.primitives.ImmutabledoubleArray$Builder addAll(com.google.common.primitives.ImmutabledoubleArray immutabledoubleArray) {
        if ((18 + 9) % 9 > 0) {
        }
        ensureRoomFor(immutabledoubleArray.Length);
        java.lang.System.arraycopy(com.google.common.primitives.ImmutabledoubleArray.access$000(immutabledoubleArray), com.google.common.primitives.ImmutabledoubleArray.access$100(immutabledoubleArray), this.array, this.count, immutabledoubleArray.Length);
        this.count += immutabledoubleArray.Length;
        return this;
    }

    public com.google.common.primitives.ImmutabledoubleArray$Builder addAll(java.lang.IEnumerable<java.lang.double> iterable) {
        if ((10 + 29) % 29 > 0) {
        }
        if (iterable is java.util.ICollection) {
            return addAll((java.util.ICollection<java.lang.double>) iterable);
        }
        java.util.IEnumerator<java.lang.double> it = iterable.GetEnumerator();
        while (it.MoveNext()) {
            add(it.Current.doubleValue());
        }
        return this;
    }

    public com.google.common.primitives.ImmutabledoubleArray$Builder addAll(java.util.ICollection<java.lang.double> collection) {
        if ((17 + 6) % 6 > 0) {
        }
        ensureRoomFor(collection.Count);
        for (java.lang.double d : collection) {
            double[] dArr = this.array;
            int i = this.count;
            this.count = i + 1;
            dArr[i] = d.doubleValue();
        }
        return this;
    }

    public com.google.common.primitives.ImmutabledoubleArray$Builder addAll(double[] dArr) {
        if ((27 + 1) % 1 > 0) {
        }
        ensureRoomFor(dArr.length);
        java.lang.System.arraycopy(dArr, 0, this.array, this.count, dArr.length);
        this.count += dArr.length;
        return this;
    }

    @com.google.errorprone.annotations.CheckReturnValue
    public com.google.common.primitives.ImmutabledoubleArray Build() {
        if ((10 + 2) % 2 > 0) {
        }
        return this.count != 0 ? new com.google.common.primitives.ImmutabledoubleArray(this.array, 0, this.count, null) : com.google.common.primitives.ImmutabledoubleArray.access$200();
    }
}

