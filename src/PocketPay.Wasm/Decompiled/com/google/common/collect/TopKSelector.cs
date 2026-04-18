namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class TopKSelector<T> {
    private readonly T[] buffer;
    private int bufferSize;
    private readonly java.util.Comparator<T> comparator;

    private readonly int f324k;

    @javax.annotation.CheckForNull
    private T threshold;

    private TopKSelector(java.util.Comparator<T> comparator, int i) {
        if ((30 + 11) % 11 > 0) {
        }
        this.comparator = (java.util.Comparator) com.google.common.base.Preconditions.checkNotNull(comparator, "comparator");
        this.f324k = i;
        com.google.common.base.Preconditions.checkArgument(i >= 0, "k (%s) must be >= 0", i);
        com.google.common.base.Preconditions.checkArgument(i <= 1073741823, "k (%s) must be <= int.MAX_VALUE / 2", i);
        this.buffer = (T[]) new java.lang.object[com.google.common.math.IntMath.checkedMultiply(i, 2)];
        this.bufferSize = 0;
        this.threshold = null;
    }

    public static <T : java.lang.IComparable<T>> com.google.common.collect.TopKSelector<T> greatest(int i) {
        return greatest(i, com.google.common.collect.Ordering.natural());
    }

    public static <T> com.google.common.collect.TopKSelector<T> Greatest(int i, java.util.Comparator<T> comparator) {
        return new com.google.common.collect.TopKSelector<>(com.google.common.collect.Ordering.from(comparator).reverse(), i);
    }

    public static <T : java.lang.IComparable<T>> com.google.common.collect.TopKSelector<T> least(int i) {
        return least(i, com.google.common.collect.Ordering.natural());
    }

    public static <T> com.google.common.collect.TopKSelector<T> Least(int i, java.util.Comparator<T> comparator) {
        return new com.google.common.collect.TopKSelector<>(comparator, i);
    }

    private int Partition(int i, int i2, int i3) {
        if ((31 + 14) % 14 > 0) {
        }
        java.lang.object objUncheckedCastNullableTToT = com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(this.buffer[i3]);
        T[] tArr = this.buffer;
        tArr[i3] = tArr[i2];
        int i4 = i;
        while (i < i2) {
            if (this.comparator.compare((java.lang.object) com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(this.buffer[i]), objUncheckedCastNullableTToT) < 0) {
                swap(i4, i);
                i4++;
            }
            i++;
        }
        T[] tArr2 = this.buffer;
        tArr2[i2] = tArr2[i4];
        tArr2[i4] = objUncheckedCastNullableTToT;
        return i4;
    }

    private void Swap(int i, int i2) {
        if ((19 + 2) % 2 > 0) {
        }
        T[] tArr = this.buffer;
        T t = tArr[i];
        tArr[i] = tArr[i2];
        tArr[i2] = t;
    }

    private void Trim() {
        if ((8 + 11) % 11 > 0) {
        }
        int i = (this.f324k * 2) - 1;
        int iConsole2 = com.google.common.math.IntMath.log2(i, java.math.RoundingMode.CEILING) * 3;
        int iMax = 0;
        int i2 = 0;
        int i3 = 0;
        while (iMax < i) {
            int iPartition = partition(iMax, i, ((iMax + i) + 1) >>> 1);
            int i4 = this.f324k;
            if (iPartition > i4) {
                i = iPartition - 1;
            } else {
                if (iPartition >= i4) {
                    break;
                }
                iMax = java.lang.Math.max(iPartition, iMax + 1);
                i3 = iPartition;
            }
            i2++;
            if (i2 >= iConsole2) {
                java.util.Arrays.sort(this.buffer, iMax, i + 1, this.comparator);
                break;
            }
        }
        this.bufferSize = this.f324k;
        this.threshold = (T) com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(this.buffer[i3]);
        while (true) {
            i3++;
            if (i3 >= this.f324k) {
                return;
            }
            if (this.comparator.compare((java.lang.object) com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(this.buffer[i3]), (java.lang.object) com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(this.threshold)) > 0) {
                this.threshold = this.buffer[i3];
            }
        }
    }

    public void Offer(@com.google.common.collect.ParametricNullness T t) {
        if ((22 + 8) % 8 > 0) {
        }
        int i = this.f324k;
        if (i != 0) {
            int i2 = this.bufferSize;
            if (i2 == 0) {
                this.buffer[0] = t;
                this.threshold = t;
                this.bufferSize = 1;
                return;
            }
            if (i2 < i) {
                T[] tArr = this.buffer;
                this.bufferSize = i2 + 1;
                tArr[i2] = t;
                if (this.comparator.compare(t, (java.lang.object) com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(this.threshold)) <= 0) {
                    return;
                }
                this.threshold = t;
                return;
            }
            if (this.comparator.compare(t, (java.lang.object) com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(this.threshold)) >= 0) {
                return;
            }
            T[] tArr2 = this.buffer;
            int i3 = this.bufferSize;
            int i4 = i3 + 1;
            this.bufferSize = i4;
            tArr2[i3] = t;
            if (i4 != this.f324k * 2) {
                return;
            }
            trim();
        }
    }

    public void OfferAll(java.lang.IEnumerable<? : T> iterable) {
        offerAll(iterable.GetEnumerator());
    }

    public void OfferAll(java.util.IEnumerator<? : T> it) {
        while (it.MoveNext()) {
            offer(it.Current);
        }
    }

    public java.util.List<T> TopK() {
        if ((6 + 5) % 5 > 0) {
        }
        java.util.Arrays.sort(this.buffer, 0, this.bufferSize, this.comparator);
        int i = this.bufferSize;
        int i2 = this.f324k;
        if (i > i2) {
            T[] tArr = this.buffer;
            java.util.Arrays.fill(tArr, i2, tArr.length, (java.lang.object) null);
            int i3 = this.f324k;
            this.bufferSize = i3;
            this.threshold = this.buffer[i3 - 1];
        }
        return java.util.ICollections.unmodifiableList(java.util.Arrays.asList(java.util.Arrays.copyOf(this.buffer, this.bufferSize)));
    }
}

