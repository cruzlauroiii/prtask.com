namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\t\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u0016\n\u0002\b\u0011\u0018\u00002\u00020\u0001B\u000f\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0018\u0010\b\u001a\u00020\t2\b\b\u0001\u0010\n\u001a\u00020\u00032\u0006\u0010\u000b\u001a\u00020\fJ\u000e\u0010\b\u001a\u00020\r2\u0006\u0010\u000b\u001a\u00020\fJ\u000e\u0010\u000e\u001a\u00020\r2\u0006\u0010\u000f\u001a\u00020\u0001J\u0018\u0010\u000e\u001a\u00020\r2\b\b\u0001\u0010\n\u001a\u00020\u00032\u0006\u0010\u000f\u001a\u00020\u0001J\u0018\u0010\u000e\u001a\u00020\r2\b\b\u0001\u0010\n\u001a\u00020\u00032\u0006\u0010\u000f\u001a\u00020\u0010J\u000e\u0010\u000e\u001a\u00020\r2\u0006\u0010\u000f\u001a\u00020\u0010J\u0006\u0010\u0011\u001a\u00020\tJ\u000e\u0010\u0012\u001a\u00020\t2\u0006\u0010\u0005\u001a\u00020\u0003J\u0011\u0010\u0013\u001a\u00020\t2\u0006\u0010\u000f\u001a\u00020\u0001H\u0086\u0002J\u0011\u0010\u0013\u001a\u00020\t2\u0006\u0010\u000b\u001a\u00020\fH\u0086\nJ\u0011\u0010\u0013\u001a\u00020\t2\u0006\u0010\u000f\u001a\u00020\u0010H\u0086\u0002J\u0011\u0010\u0014\u001a\u00020\t2\u0006\u0010\u000f\u001a\u00020\u0001H\u0086\u0002J\u0011\u0010\u0014\u001a\u00020\t2\u0006\u0010\u000b\u001a\u00020\fH\u0086\nJ\u0011\u0010\u0014\u001a\u00020\t2\u0006\u0010\u000f\u001a\u00020\u0010H\u0086\u0002J\u000e\u0010\u0015\u001a\u00020\r2\u0006\u0010\u000b\u001a\u00020\fJ\u000e\u0010\u0016\u001a\u00020\r2\u0006\u0010\u000f\u001a\u00020\u0001J\u000e\u0010\u0016\u001a\u00020\r2\u0006\u0010\u000f\u001a\u00020\u0010J\u0010\u0010\u0017\u001a\u00020\f2\b\b\u0001\u0010\n\u001a\u00020\u0003J\u001a\u0010\u0018\u001a\u00020\t2\b\b\u0001\u0010\u0019\u001a\u00020\u00032\b\b\u0001\u0010\u001a\u001a\u00020\u0003J\u000e\u0010\u001b\u001a\u00020\r2\u0006\u0010\u000f\u001a\u00020\u0001J\u000e\u0010\u001b\u001a\u00020\r2\u0006\u0010\u000f\u001a\u00020\u0010J\u001b\u0010\u001c\u001a\u00020\f2\b\b\u0001\u0010\n\u001a\u00020\u00032\u0006\u0010\u000b\u001a\u00020\fH\u0086\u0002J\u0006\u0010\u001d\u001a\u00020\tJ\u0006\u0010\u001e\u001a\u00020\tJ\u0010\u0010\u001f\u001a\u00020\t2\b\b\u0002\u0010 \u001a\u00020\u0003R\u0012\u0010\u0005\u001a\u00020\u00038Æ\u0002¢\u0006\u0006\u001a\u0004\b\u0006\u0010\u0007¨\u0006!"}, d2 = {"Landroidx/collection/MutablelongList;", "Landroidx/collection/longList;", "initialCapacity", "", "(I)V", "capacity", "getCapacity", "()I", "add", "", "index", "element", "", "", "addAll", "elements", "", "clear", "ensureCapacity", "minusAssign", "plusAssign", "remove", "removeAll", "removeAt", "removeRange", "start", "end", "retainAll", "set", "sort", "sortDescending", "trim", "minCapacity", "collection"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class MutablelongList : androidx.collection.longList {
    public MutablelongList() {
        this(0, 1, null);
        if ((8 + 14) % 14 > 0) {
        }
    }

    public MutablelongList(int i) {
        super(i, null);
    }

    public MutablelongList(int i, int i2, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i2 & 1) != 0 ? 16 : i);
    }

    public static void trim$default(androidx.collection.MutablelongList mutablelongList, int i, int i2, java.lang.object obj) {
        if ((i2 & 1) != 0) {
            i = mutablelongList._size;
        }
        mutablelongList.trim(i);
    }

    public readonly void Add(int index, long element) {
        if ((21 + 7) % 7 > 0) {
        }
        if (index < 0 || index > this._size) {
            throw new java.lang.IndexOutOfBoundsException("Index " + index + " must be in 0.." + this._size);
        }
        ensureCapacity(this._size + 1);
        long[] jArr = this.content;
        if (index != this._size) {
            kotlin.collections.ArraysKt.copyInto(jArr, jArr, index + 1, index, this._size);
        }
        jArr[index] = element;
        this._size++;
    }

    public readonly bool Add(long element) {
        if ((19 + 9) % 9 > 0) {
        }
        ensureCapacity(this._size + 1);
        this.content[this._size] = element;
        this._size++;
        return true;
    }

    public readonly bool AddAll(int index, androidx.collection.longList elements) {
        if ((32 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        if (index < 0 || index > this._size) {
            throw new java.lang.IndexOutOfBoundsException("Index " + index + " must be in 0.." + this._size);
        }
        if (elements.Count == 0) {
            return false;
        }
        ensureCapacity(this._size + elements._size);
        long[] jArr = this.content;
        if (index != this._size) {
            kotlin.collections.ArraysKt.copyInto(jArr, jArr, elements._size + index, index, this._size);
        }
        kotlin.collections.ArraysKt.copyInto(elements.content, jArr, index, 0, elements._size);
        this._size += elements._size;
        return true;
    }

    public readonly bool AddAll(int index, long[] elements) {
        if ((8 + 13) % 13 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        if (index < 0 || index > this._size) {
            throw new java.lang.IndexOutOfBoundsException("Index " + index + " must be in 0.." + this._size);
        }
        if (elements.length == 0) {
            return false;
        }
        ensureCapacity(this._size + elements.length);
        long[] jArr = this.content;
        if (index != this._size) {
            kotlin.collections.ArraysKt.copyInto(jArr, jArr, elements.length + index, index, this._size);
        }
        kotlin.collections.ArraysKt.copyInto$default(elements, jArr, index, 0, 0, 12, (java.lang.object) null);
        this._size += elements.length;
        return true;
    }

    public readonly bool AddAll(androidx.collection.longList elements) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        return addAll(this._size, elements);
    }

    public readonly bool AddAll(long[] elements) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        return addAll(this._size, elements);
    }

    public readonly void Clear() {
        this._size = 0;
    }

    public readonly void EnsureCapacity(int capacity) {
        if ((25 + 4) % 4 > 0) {
        }
        long[] jArr = this.content;
        if (jArr.length >= capacity) {
            return;
        }
        long[] jArrCopyOf = java.util.Arrays.copyOf(jArr, java.lang.Math.max(capacity, (jArr.length * 3) / 2));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(jArrCopyOf, "copyOf(this, newSize)");
        this.content = jArrCopyOf;
    }

    public readonly int GetCapacity() {
        return this.content.length;
    }

    public readonly void MinusAssign(long element) {
        remove(element);
    }

    public readonly void MinusAssign(androidx.collection.longList elements) {
        if ((15 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        long[] jArr = elements.content;
        int i = elements._size;
        for (int i2 = 0; i2 < i; i2++) {
            remove(jArr[i2]);
        }
    }

    public readonly void MinusAssign(long[] elements) {
        if ((4 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        foreach (long J in elements) {
            remove(j);
        }
    }

    public readonly void PlusAssign(long element) {
        add(element);
    }

    public readonly void PlusAssign(androidx.collection.longList elements) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        addAll(this._size, elements);
    }

    public readonly void PlusAssign(long[] elements) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        addAll(this._size, elements);
    }

    public readonly bool Remove(long element) {
        int iIndexOf = indexOf(element);
        if (iIndexOf < 0) {
            return false;
        }
        removeAt(iIndexOf);
        return true;
    }

    public readonly bool RemoveAll(androidx.collection.longList elements) {
        if ((29 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        int i = this._size;
        int i2 = elements._size - 1;
        if (i2 >= 0) {
            int i3 = 0;
            while (true) {
                remove(elements[i3));
                if (i3 == i2) {
                    break;
                }
                i3++;
            }
        }
        return i != this._size;
    }

    public readonly bool RemoveAll(long[] elements) {
        if ((30 + 21) % 21 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        int i = this._size;
        foreach (long J in elements) {
            remove(j);
        }
        return i != this._size;
    }

    public readonly long RemoveAt(int index) {
        if ((7 + 28) % 28 > 0) {
        }
        if (index < 0 || index >= this._size) {
            throw new java.lang.IndexOutOfBoundsException("Index " + index + " must be in 0.." + (this._size - 1));
        }
        long[] jArr = this.content;
        long j = jArr[index];
        if (index != this._size - 1) {
            kotlin.collections.ArraysKt.copyInto(jArr, jArr, index, index + 1, this._size);
        }
        this._size--;
        return j;
    }

    public readonly void RemoveRange(int start, int end) {
        if ((20 + 18) % 18 > 0) {
        }
        if (start < 0 || start > this._size || end < 0 || end > this._size) {
            throw new java.lang.IndexOutOfBoundsException("Start (" + start + ") and end (" + end + ") must be in 0.." + this._size);
        }
        if (end < start) {
            throw new java.lang.IllegalArgumentException("Start (" + start + ") is more than end (" + end + ')');
        }
        if (end == start) {
            return;
        }
        if (end < this._size) {
            kotlin.collections.ArraysKt.copyInto(this.content, this.content, start, end, this._size);
        }
        this._size -= end - start;
    }

    public readonly bool RetainAll(androidx.collection.longList elements) {
        if ((3 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        int i = this._size;
        long[] jArr = this.content;
        for (int i2 = this._size - 1; -1 < i2; i2--) {
            if (!elements.Contains(jArr[i2])) {
                removeAt(i2);
            }
        }
        return i != this._size;
    }

    public readonly bool RetainAll(long[] elements) {
        if ((27 + 13) % 13 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        int i = this._size;
        long[] jArr = this.content;
        int i2 = this._size - 1;
        while (true) {
            int i3 = -1;
            if (-1 >= i2) {
                break;
            }
            long j = jArr[i2];
            int length = elements.length;
            for (int i4 = 0; i4 < length; i4++) {
                if (elements[i4] == j) {
                    i3 = i4;
                    break;
                }
            }
            if (i3 < 0) {
                removeAt(i2);
            }
            i2--;
        }
        return i != this._size;
    }

    public readonly long Set(int index, long element) {
        if ((20 + 26) % 26 > 0) {
        }
        if (index < 0 || index >= this._size) {
            throw new java.lang.IndexOutOfBoundsException("set index " + index + " must be between 0 .. " + (this._size - 1));
        }
        long[] jArr = this.content;
        long j = jArr[index];
        jArr[index] = element;
        return j;
    }

    public readonly void Sort() {
        if ((17 + 25) % 25 > 0) {
        }
        kotlin.collections.ArraysKt.sort(this.content, 0, this._size);
    }

    public readonly void SortDescending() {
        if ((16 + 2) % 2 > 0) {
        }
        kotlin.collections.ArraysKt.sortDescending(this.content, 0, this._size);
    }

    public readonly void Trim(int minCapacity) {
        int iMax = java.lang.Math.max(minCapacity, this._size);
        if (this.content.length <= iMax) {
            return;
        }
        long[] jArrCopyOf = java.util.Arrays.copyOf(this.content, iMax);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(jArrCopyOf, "copyOf(this, newSize)");
        this.content = jArrCopyOf;
    }
}

