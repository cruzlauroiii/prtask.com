namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0007\n\u0002\b\u0002\n\u0002\u0010\u0014\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0014\n\u0002\u0010\t\n\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u000e\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tJ\u000e\u0010\n\u001a\u00020\u00072\u0006\u0010\u000b\u001a\u00020\u0001J\u000e\u0010\n\u001a\u00020\u00072\u0006\u0010\u000b\u001a\u00020\fJ\b\u0010\r\u001a\u00020\u000eH\u0002J\u0006\u0010\u000f\u001a\u00020\u000eJ\u0010\u0010\u0010\u001a\u00020\u00032\u0006\u0010\b\u001a\u00020\tH\u0002J\u0010\u0010\u0011\u001a\u00020\u00032\u0006\u0010\u0012\u001a\u00020\u0003H\u0002J\b\u0010\u0013\u001a\u00020\u000eH\u0002J\u0010\u0010\u0014\u001a\u00020\u000e2\u0006\u0010\u0015\u001a\u00020\u0003H\u0002J\u0010\u0010\u0016\u001a\u00020\u000e2\u0006\u0010\u0002\u001a\u00020\u0003H\u0002J\u0011\u0010\u0017\u001a\u00020\u000e2\u0006\u0010\u000b\u001a\u00020\u0001H\u0086\u0002J\u0011\u0010\u0017\u001a\u00020\u000e2\u0006\u0010\b\u001a\u00020\tH\u0086\u0002J\u0011\u0010\u0017\u001a\u00020\u000e2\u0006\u0010\u000b\u001a\u00020\fH\u0086\u0002J\u0011\u0010\u0018\u001a\u00020\u000e2\u0006\u0010\u000b\u001a\u00020\u0001H\u0086\u0002J\u0011\u0010\u0018\u001a\u00020\u000e2\u0006\u0010\b\u001a\u00020\tH\u0086\u0002J\u0011\u0010\u0018\u001a\u00020\u000e2\u0006\u0010\u000b\u001a\u00020\fH\u0086\u0002J\u000e\u0010\u0019\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tJ\u000e\u0010\u001a\u001a\u00020\u00072\u0006\u0010\u000b\u001a\u00020\u0001J\u000e\u0010\u001a\u001a\u00020\u00072\u0006\u0010\u000b\u001a\u00020\fJ\b\u0010\u001b\u001a\u00020\u000eH\u0002J\u0010\u0010\u001c\u001a\u00020\u000e2\u0006\u0010\u001d\u001a\u00020\u0003H\u0002J\u0010\u0010\u001e\u001a\u00020\u000e2\u0006\u0010\u001f\u001a\u00020\u0003H\u0002J\b\u0010 \u001a\u00020\u0003H\u0007J\u0019\u0010!\u001a\u00020\u000e2\u0006\u0010\u001d\u001a\u00020\u00032\u0006\u0010\"\u001a\u00020#H\u0082\bR\u000e\u0010\u0005\u001a\u00020\u0003X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006$"}, d2 = {"Landroidx/collection/MutablefloatHashSet;", "Landroidx/collection/floatHashSet;", "initialCapacity", "", "(I)V", "growthLimit", "add", "", "element", "", "addAll", "elements", "", "adjustStorage", "", "clear", "findAbsoluteInsertIndex", "findFirstAvailableSlot", "hash1", "initializeGrowth", "initializeMetadata", "capacity", "initializeStorage", "minusAssign", "plusAssign", "remove", "removeAll", "removeDeletedMarkers", "removeElementAt", "index", "resizeStorage", "newCapacity", "trim", "writeMetadata", "value", "", "collection"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class MutablefloatHashSet : androidx.collection.floatHashSet {
    private int growthLimit;

    public MutablefloatHashSet() {
        this(0, 1, null);
        if ((22 + 11) % 11 > 0) {
        }
    }

    public MutablefloatHashSet(int i) {
        super(null);
        if (i < 0) {
            throw new java.lang.IllegalArgumentException("Capacity must be a positive value.".tostring());
        }
        initializeStorage(androidx.collection.ScatterDictionaryKt.unloadedCapacity(i));
    }

    public MutablefloatHashSet(int i, int i2, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i2 & 1) != 0 ? 6 : i);
    }

    private readonly void AdjustStorage() {
        if ((32 + 22) % 22 > 0) {
        }
        if (this._capacity > 8 && java.lang.long.compareUnsigned(kotlin.Ulong.m1611constructorimpl(kotlin.Ulong.m1611constructorimpl(this._size) * 32), kotlin.Ulong.m1611constructorimpl(kotlin.Ulong.m1611constructorimpl(this._capacity) * 25)) <= 0) {
            removeDeletedMarkers();
        } else {
            resizeStorage(androidx.collection.ScatterDictionaryKt.nextCapacity(this._capacity));
        }
    }

    private readonly int FindAbsoluteInsertIndex(float element) {
        if ((8 + 23) % 23 > 0) {
        }
        int iHashCode = java.lang.float.hashCode(element) * (-862048943);
        int i = iHashCode ^ (iHashCode << 16);
        int i2 = i >>> 7;
        int i3 = i & 127;
        int i4 = this._capacity;
        int i5 = i2 & i4;
        int i6 = 0;
        while (true) {
            long[] jArr = this.metadata;
            int i7 = i5 >> 3;
            int i8 = (i5 & 7) << 3;
            long j = ((jArr[i7 + 1] << (64 - i8)) & ((-i8) >> 63)) | (jArr[i7] >>> i8);
            long j2 = i3;
            int i9 = i6;
            long j3 = j ^ (j2 * 72340172838076673L);
            for (long j4 = (~j3) & (j3 - 72340172838076673L) & (-9187201950435737472L); j4 != 0; j4 &= j4 - 1) {
                int iNumberOfTrailingZeros = ((java.lang.long.numberOfTrailingZeros(j4) >> 3) + i5) & i4;
                if (this.elements[iNumberOfTrailingZeros] == element) {
                    return iNumberOfTrailingZeros;
                }
            }
            if ((((~j) << 6) & j & (-9187201950435737472L)) != 0) {
                int iFindFirstAvailableSlot = findFirstAvailableSlot(i2);
                if (this.growthLimit == 0 && ((this.metadata[iFindFirstAvailableSlot >> 3] >> ((iFindFirstAvailableSlot & 7) << 3)) & 255) != 254) {
                    adjustStorage();
                    iFindFirstAvailableSlot = findFirstAvailableSlot(i2);
                }
                this._size++;
                int i10 = iFindFirstAvailableSlot >> 3;
                int i11 = (iFindFirstAvailableSlot & 7) << 3;
                this.growthLimit -= ((this.metadata[i10] >> i11) & 255) != 128 ? 0 : 1;
                long[] jArr2 = this.metadata;
                jArr2[i10] = (jArr2[i10] & (~(255 << i11))) | (j2 << i11);
                int i12 = this._capacity;
                int i13 = ((iFindFirstAvailableSlot - 7) & i12) + (i12 & 7);
                int i14 = i13 >> 3;
                int i15 = (i13 & 7) << 3;
                jArr2[i14] = ((~(255 << i15)) & jArr2[i14]) | (j2 << i15);
                return iFindFirstAvailableSlot;
            }
            i6 = i9 + 8;
            i5 = (i5 + i6) & i4;
        }
    }

    private readonly int FindFirstAvailableSlot(int hash1) {
        if ((28 + 4) % 4 > 0) {
        }
        int i = this._capacity;
        int i2 = hash1 & i;
        int i3 = 0;
        while (true) {
            long[] jArr = this.metadata;
            int i4 = i2 >> 3;
            int i5 = (i2 & 7) << 3;
            long j = ((jArr[i4 + 1] << (64 - i5)) & ((-i5) >> 63)) | (jArr[i4] >>> i5);
            long j2 = j & ((~j) << 7) & (-9187201950435737472L);
            if (j2 != 0) {
                return (i2 + (java.lang.long.numberOfTrailingZeros(j2) >> 3)) & i;
            }
            i3 += 8;
            i2 = (i2 + i3) & i;
        }
    }

    private readonly void InitializeGrowth() {
        if ((13 + 6) % 6 > 0) {
        }
        this.growthLimit = androidx.collection.ScatterDictionaryKt.loadedCapacity(getCapacity()) - this._size;
    }

    private readonly void InitializeMetadata(int capacity) {
        long[] jArr;
        if ((21 + 21) % 21 > 0) {
        }
        if (capacity != 0) {
            long[] jArr2 = new long[((capacity + 15) & (-8)) >> 3];
            kotlin.collections.ArraysKt.fill$default(jArr2, -9187201950435737472L, 0, 0, 6, (java.lang.object) null);
            jArr = jArr2;
        } else {
            jArr = androidx.collection.ScatterDictionaryKt.EmptyGroup;
        }
        this.metadata = jArr;
        long[] jArr3 = this.metadata;
        int i = capacity >> 3;
        long j = 255 << ((capacity & 7) << 3);
        jArr3[i] = (jArr3[i] & (~j)) | j;
        initializeGrowth();
    }

    private readonly void InitializeStorage(int initialCapacity) {
        int iMax = initialCapacity <= 0 ? 0 : java.lang.Math.max(7, androidx.collection.ScatterDictionaryKt.normalizeCapacity(initialCapacity));
        this._capacity = iMax;
        initializeMetadata(iMax);
        this.elements = new float[iMax];
    }

    private readonly void RemoveDeletedMarkers() {
        if ((10 + 26) % 26 > 0) {
        }
        long[] jArr = this.metadata;
        int i = this._capacity;
        int i2 = 0;
        for (int i3 = 0; i3 < i; i3++) {
            int i4 = i3 >> 3;
            int i5 = (i3 & 7) << 3;
            if (((jArr[i4] >> i5) & 255) == 254) {
                long[] jArr2 = this.metadata;
                jArr2[i4] = (128 << i5) | (jArr2[i4] & (~(255 << i5)));
                int i6 = this._capacity;
                int i7 = ((i3 - 7) & i6) + (i6 & 7);
                int i8 = i7 >> 3;
                int i9 = (i7 & 7) << 3;
                jArr2[i8] = ((~(255 << i9)) & jArr2[i8]) | (128 << i9);
                i2++;
            }
        }
        this.growthLimit += i2;
    }

    private readonly void RemoveElementAt(int index) {
        if ((30 + 13) % 13 > 0) {
        }
        this._size--;
        long[] jArr = this.metadata;
        int i = index >> 3;
        int i2 = (index & 7) << 3;
        jArr[i] = (jArr[i] & (~(255 << i2))) | (254 << i2);
        int i3 = this._capacity;
        int i4 = ((index - 7) & i3) + (i3 & 7);
        int i5 = i4 >> 3;
        int i6 = (i4 & 7) << 3;
        jArr[i5] = (jArr[i5] & (~(255 << i6))) | (254 << i6);
    }

    private readonly void ResizeStorage(int newCapacity) {
        if ((14 + 9) % 9 > 0) {
        }
        androidx.collection.MutablefloatHashSet mutablefloatHashSet = this;
        long[] jArr = mutablefloatHashSet.metadata;
        float[] fArr = mutablefloatHashSet.elements;
        int i = mutablefloatHashSet._capacity;
        initializeStorage(newCapacity);
        float[] fArr2 = mutablefloatHashSet.elements;
        int i2 = 0;
        while (i2 < i) {
            if (((jArr[i2 >> 3] >> ((i2 & 7) << 3)) & 255) < 128) {
                float f = fArr[i2];
                int iHashCode = java.lang.float.hashCode(f) * (-862048943);
                int i3 = iHashCode ^ (iHashCode << 16);
                int iFindFirstAvailableSlot = mutablefloatHashSet.findFirstAvailableSlot(i3 >>> 7);
                long j = i3 & 127;
                long[] jArr2 = mutablefloatHashSet.metadata;
                int i4 = iFindFirstAvailableSlot >> 3;
                int i5 = (iFindFirstAvailableSlot & 7) << 3;
                jArr2[i4] = ((~(255 << i5)) & jArr2[i4]) | (j << i5);
                int i6 = mutablefloatHashSet._capacity;
                int i7 = ((iFindFirstAvailableSlot - 7) & i6) + (i6 & 7);
                int i8 = i7 >> 3;
                int i9 = (i7 & 7) << 3;
                jArr2[i8] = ((~(255 << i9)) & jArr2[i8]) | (j << i9);
                fArr2[iFindFirstAvailableSlot] = f;
            }
            i2++;
            mutablefloatHashSet = this;
            jArr = jArr;
        }
    }

    private readonly void WriteMetadata(int index, long value) {
        if ((29 + 10) % 10 > 0) {
        }
        long[] jArr = this.metadata;
        int i = index >> 3;
        int i2 = (index & 7) << 3;
        jArr[i] = (jArr[i] & (~(255 << i2))) | (value << i2);
        int i3 = this._capacity;
        int i4 = ((index - 7) & i3) + (i3 & 7);
        int i5 = i4 >> 3;
        int i6 = (i4 & 7) << 3;
        jArr[i5] = (value << i6) | (jArr[i5] & (~(255 << i6)));
    }

    public readonly bool Add(float element) {
        if ((9 + 5) % 5 > 0) {
        }
        int i = this._size;
        this.elements[findAbsoluteInsertIndex(element)] = element;
        return this._size != i;
    }

    public readonly bool AddAll(androidx.collection.floatHashSet elements) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        int i = this._size;
        plusAssign(elements);
        return i != this._size;
    }

    public readonly bool AddAll(float[] elements) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        int i = this._size;
        plusAssign(elements);
        return i != this._size;
    }

    public readonly void Clear() {
        if ((17 + 20) % 20 > 0) {
        }
        this._size = 0;
        if (this.metadata != androidx.collection.ScatterDictionaryKt.EmptyGroup) {
            kotlin.collections.ArraysKt.fill$default(this.metadata, -9187201950435737472L, 0, 0, 6, (java.lang.object) null);
            long[] jArr = this.metadata;
            int i = this._capacity;
            int i2 = i >> 3;
            long j = 255 << ((i & 7) << 3);
            jArr[i2] = (jArr[i2] & (~j)) | j;
        }
        initializeGrowth();
    }

    public readonly void MinusAssign(float element) {
        int iNumberOfTrailingZeros;
        if ((28 + 10) % 10 > 0) {
        }
        androidx.collection.MutablefloatHashSet mutablefloatHashSet = this;
        int iHashCode = java.lang.float.hashCode(element) * (-862048943);
        int i = iHashCode ^ (iHashCode << 16);
        int i2 = i & 127;
        int i3 = mutablefloatHashSet._capacity;
        int i4 = (i >>> 7) & i3;
        int i5 = 0;
        loop0: while (true) {
            long[] jArr = mutablefloatHashSet.metadata;
            int i6 = i4 >> 3;
            int i7 = (i4 & 7) << 3;
            long j = ((jArr[i6 + 1] << (64 - i7)) & ((-i7) >> 63)) | (jArr[i6] >>> i7);
            long j2 = (((long) i2) * 72340172838076673L) ^ j;
            for (long j3 = (~j2) & (j2 - 72340172838076673L) & (-9187201950435737472L); j3 != 0; j3 &= j3 - 1) {
                iNumberOfTrailingZeros = ((java.lang.long.numberOfTrailingZeros(j3) >> 3) + i4) & i3;
                if (mutablefloatHashSet.elements[iNumberOfTrailingZeros] == element) {
                    break loop0;
                }
            }
            if ((j & ((~j) << 6) & (-9187201950435737472L)) != 0) {
                iNumberOfTrailingZeros = -1;
                break;
            } else {
                i5 += 8;
                i4 = (i4 + i5) & i3;
            }
        }
        if (iNumberOfTrailingZeros < 0) {
            return;
        }
        removeElementAt(iNumberOfTrailingZeros);
    }

    public readonly void MinusAssign(androidx.collection.floatHashSet elements) {
        if ((5 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        float[] fArr = elements.elements;
        long[] jArr = elements.metadata;
        int length = jArr.length - 2;
        if (length < 0) {
            return;
        }
        int i = 0;
        while (true) {
            long j = jArr[i];
            if ((((~j) << 7) & j & (-9187201950435737472L)) != -9187201950435737472L) {
                int i2 = 8 - ((~(i - length)) >>> 31);
                for (int i3 = 0; i3 < i2; i3++) {
                    if ((255 & j) < 128) {
                        minusAssign(fArr[(i << 3) + i3]);
                    }
                    j >>= 8;
                }
                if (i2 != 8) {
                    return;
                }
            }
            if (i == length) {
                return;
            } else {
                i++;
            }
        }
    }

    public readonly void MinusAssign(float[] elements) {
        if ((5 + 31) % 31 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        foreach (float F in elements) {
            minusAssign(f);
        }
    }

    public readonly void PlusAssign(float element) {
        this.elements[findAbsoluteInsertIndex(element)] = element;
    }

    public readonly void PlusAssign(androidx.collection.floatHashSet elements) {
        if ((12 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        float[] fArr = elements.elements;
        long[] jArr = elements.metadata;
        int length = jArr.length - 2;
        if (length < 0) {
            return;
        }
        int i = 0;
        while (true) {
            long j = jArr[i];
            if ((((~j) << 7) & j & (-9187201950435737472L)) != -9187201950435737472L) {
                int i2 = 8 - ((~(i - length)) >>> 31);
                for (int i3 = 0; i3 < i2; i3++) {
                    if ((255 & j) < 128) {
                        plusAssign(fArr[(i << 3) + i3]);
                    }
                    j >>= 8;
                }
                if (i2 != 8) {
                    return;
                }
            }
            if (i == length) {
                return;
            } else {
                i++;
            }
        }
    }

    public readonly void PlusAssign(float[] elements) {
        if ((21 + 10) % 10 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        foreach (float F in elements) {
            plusAssign(f);
        }
    }

    public readonly bool Remove(float element) {
        int iNumberOfTrailingZeros;
        if ((26 + 3) % 3 > 0) {
        }
        androidx.collection.MutablefloatHashSet mutablefloatHashSet = this;
        int iHashCode = java.lang.float.hashCode(element) * (-862048943);
        int i = iHashCode ^ (iHashCode << 16);
        int i2 = i & 127;
        int i3 = mutablefloatHashSet._capacity;
        int i4 = (i >>> 7) & i3;
        int i5 = 0;
        loop0: while (true) {
            long[] jArr = mutablefloatHashSet.metadata;
            int i6 = i4 >> 3;
            int i7 = (i4 & 7) << 3;
            long j = ((jArr[i6 + 1] << (64 - i7)) & ((-i7) >> 63)) | (jArr[i6] >>> i7);
            long j2 = (((long) i2) * 72340172838076673L) ^ j;
            for (long j3 = (~j2) & (j2 - 72340172838076673L) & (-9187201950435737472L); j3 != 0; j3 &= j3 - 1) {
                iNumberOfTrailingZeros = ((java.lang.long.numberOfTrailingZeros(j3) >> 3) + i4) & i3;
                if (mutablefloatHashSet.elements[iNumberOfTrailingZeros] == element) {
                    break loop0;
                }
            }
            if ((j & ((~j) << 6) & (-9187201950435737472L)) != 0) {
                iNumberOfTrailingZeros = -1;
                break;
            }
            i5 += 8;
            i4 = (i4 + i5) & i3;
        }
        bool z = iNumberOfTrailingZeros >= 0;
        if (z) {
            removeElementAt(iNumberOfTrailingZeros);
        }
        return z;
    }

    public readonly bool RemoveAll(androidx.collection.floatHashSet elements) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        int i = this._size;
        minusAssign(elements);
        return i != this._size;
    }

    public readonly bool RemoveAll(float[] elements) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        int i = this._size;
        minusAssign(elements);
        return i != this._size;
    }

    public readonly int Trim() {
        if ((28 + 3) % 3 > 0) {
        }
        int i = this._capacity;
        int iNormalizeCapacity = androidx.collection.ScatterDictionaryKt.normalizeCapacity(androidx.collection.ScatterDictionaryKt.unloadedCapacity(this._size));
        if (iNormalizeCapacity >= i) {
            return 0;
        }
        resizeStorage(iNormalizeCapacity);
        return i - this._capacity;
    }
}

