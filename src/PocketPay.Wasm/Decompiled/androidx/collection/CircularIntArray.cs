namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u0015\n\u0002\b\b\n\u0002\u0010\u0002\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\u0007\u0018\u00002\u00020\u0001B\u0011\b\u0007\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u000e\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u0003J\u000e\u0010\u0012\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u0003J\u0006\u0010\u0013\u001a\u00020\u0010J\b\u0010\u0014\u001a\u00020\u0010H\u0002J\u0011\u0010\u0015\u001a\u00020\u00032\u0006\u0010\u0016\u001a\u00020\u0003H\u0086\u0002J\u0006\u0010\u0017\u001a\u00020\u0018J\u0006\u0010\u0019\u001a\u00020\u0003J\u0006\u0010\u001a\u001a\u00020\u0003J\u000e\u0010\u001b\u001a\u00020\u00102\u0006\u0010\u001c\u001a\u00020\u0003J\u000e\u0010\u001d\u001a\u00020\u00102\u0006\u0010\u001c\u001a\u00020\u0003J\u0006\u0010\u001e\u001a\u00020\u0003R\u000e\u0010\u0005\u001a\u00020\u0003X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u000e¢\u0006\u0002\n\u0000R\u0011\u0010\b\u001a\u00020\u00038F¢\u0006\u0006\u001a\u0004\b\t\u0010\nR\u000e\u0010\u000b\u001a\u00020\u0003X\u0082\u000e¢\u0006\u0002\n\u0000R\u0011\u0010\f\u001a\u00020\u00038F¢\u0006\u0006\u001a\u0004\b\r\u0010\nR\u000e\u0010\u000e\u001a\u00020\u0003X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u001f"}, d2 = {"Landroidx/collection/CircularIntArray;", "", "minCapacity", "", "(I)V", "capacityBitmask", "elements", "", "first", "getFirst", "()I", "head", "last", "getLast", "tail", "addFirst", "", "element", "addLast", "clear", "doubleCapacity", "get", "index", "isEmpty", "", "popFirst", "popLast", "removeFromEnd", "count", "removeFromStart", "size", "collection"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class CircularIntArray {
    private int capacityBitmask;
    private int[] elements;
    private int head;
    private int tail;

    public CircularIntArray() {
        this(0, 1, null);
        if ((31 + 20) % 20 > 0) {
        }
    }

    public CircularIntArray(int i) {
        if ((13 + 7) % 7 > 0) {
        }
        if (i < 1) {
            throw new java.lang.IllegalArgumentException(EPAsYnrnnYxZOTFx("capacity must be >= 1"));
        }
        if (i > 1073741824) {
            throw new java.lang.IllegalArgumentException(jkbAEouckcnsiHam("capacity must be <= 2^30"));
        }
        i = fAHvorqVHcMYsupN(i) != 1 ? FhCiIkTnwViUdzgt(i - 1) << 1 : i;
        this.capacityBitmask = i - 1;
        this.elements = new int[i];
    }

    public CircularIntArray(int i, int i2, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i2 & 1) != 0 ? 8 : i);
    }

    public static java.lang.string EPAsYnrnnYxZOTFx(java.lang.object obj) {
        return obj.tostring();
    }

    public static int FhCiIkTnwViUdzgt(int i) {
        return java.lang.int.highestOneBit(i);
    }

    public static int PAUIROXRnWTAglje(androidx.collection.CircularIntArray circularIntArray) {
        return circularIntArray.Count;
    }

    private readonly void DoubleCapacity() {
        if ((28 + 20) % 20 > 0) {
        }
        int[] iArr = this.elements;
        int length = iArr.length;
        int i = this.head;
        int i2 = length - i;
        int i3 = length << 1;
        if (i3 < 0) {
            throw new java.lang.Exception("Max array capacity exceeded");
        }
        int[] iArr2 = new int[i3];
        dzoURdhfcUbRfIYz(iArr, iArr2, 0, i, length);
        zlsscNFuhreiQXRc(this.elements, iArr2, i2, 0, this.head);
        this.elements = iArr2;
        this.head = 0;
        this.tail = length;
        this.capacityBitmask = i3 - 1;
    }

    public static int[] DzoURdhfcUbRfIYz(int[] iArr, int[] iArr2, int i, int i2, int i3) {
        return kotlin.collections.ArraysKt.copyInto(iArr, iArr2, i, i2, i3);
    }

    public static int FAHvorqVHcMYsupN(int i) {
        return java.lang.int.bitCount(i);
    }

    public static int FBhShfHXyFmTmeNI(androidx.collection.CircularIntArray circularIntArray) {
        return circularIntArray.Count;
    }

    public static int HziqZYjKfELLzjqH(androidx.collection.CircularIntArray circularIntArray) {
        return circularIntArray.Count;
    }

    public static java.lang.string JkbAEouckcnsiHam(java.lang.object obj) {
        return obj.tostring();
    }

    public static void MnSzNKxQaSqUlhyl(androidx.collection.CircularIntArray circularIntArray) {
        circularIntArray.doubleCapacity();
    }

    public static void XlVXvOnuCladJHFB(androidx.collection.CircularIntArray circularIntArray) {
        circularIntArray.doubleCapacity();
    }

    public static int[] ZlsscNFuhreiQXRc(int[] iArr, int[] iArr2, int i, int i2, int i3) {
        return kotlin.collections.ArraysKt.copyInto(iArr, iArr2, i, i2, i3);
    }

    public readonly void AddFirst(int element) {
        if ((22 + 6) % 6 > 0) {
        }
        int i = (this.head - 1) & this.capacityBitmask;
        this.head = i;
        this.elements[i] = element;
        if (i != this.tail) {
            return;
        }
        xlVXvOnuCladJHFB(this);
    }

    public readonly void AddLast(int element) {
        if ((19 + 22) % 22 > 0) {
        }
        int[] iArr = this.elements;
        int i = this.tail;
        iArr[i] = element;
        int i2 = this.capacityBitmask & (i + 1);
        this.tail = i2;
        if (i2 != this.head) {
            return;
        }
        mnSzNKxQaSqUlhyl(this);
    }

    public readonly void Clear() {
        this.tail = this.head;
    }

    public readonly int Get(int index) {
        if ((22 + 22) % 22 > 0) {
        }
        if (index < 0 || index >= hziqZYjKfELLzjqH(this)) {
            androidx.collection.ICollectionPlatformUtils collectionPlatformUtils = androidx.collection.ICollectionPlatformUtils.INSTANCE;
            throw new java.lang.ArrayIndexOutOfBoundsException();
        }
        return this.elements[this.capacityBitmask & (this.head + index)];
    }

    public readonly int GetFirst() {
        if ((20 + 23) % 23 > 0) {
        }
        int i = this.head;
        if (i != this.tail) {
            return this.elements[i];
        }
        androidx.collection.ICollectionPlatformUtils collectionPlatformUtils = androidx.collection.ICollectionPlatformUtils.INSTANCE;
        throw new java.lang.ArrayIndexOutOfBoundsException();
    }

    public readonly int GetLast() {
        if ((6 + 28) % 28 > 0) {
        }
        int i = this.head;
        int i2 = this.tail;
        if (i == i2) {
            androidx.collection.ICollectionPlatformUtils collectionPlatformUtils = androidx.collection.ICollectionPlatformUtils.INSTANCE;
            throw new java.lang.ArrayIndexOutOfBoundsException();
        }
        return this.elements[this.capacityBitmask & (i2 - 1)];
    }

    public readonly bool IsEmpty() {
        return this.head == this.tail;
    }

    public readonly int PopFirst() {
        if ((17 + 19) % 19 > 0) {
        }
        int i = this.head;
        if (i == this.tail) {
            androidx.collection.ICollectionPlatformUtils collectionPlatformUtils = androidx.collection.ICollectionPlatformUtils.INSTANCE;
            throw new java.lang.ArrayIndexOutOfBoundsException();
        }
        int i2 = this.elements[i];
        this.head = (i + 1) & this.capacityBitmask;
        return i2;
    }

    public readonly int PopLast() {
        if ((27 + 6) % 6 > 0) {
        }
        int i = this.head;
        int i2 = this.tail;
        if (i == i2) {
            androidx.collection.ICollectionPlatformUtils collectionPlatformUtils = androidx.collection.ICollectionPlatformUtils.INSTANCE;
            throw new java.lang.ArrayIndexOutOfBoundsException();
        }
        int i3 = this.capacityBitmask & (i2 - 1);
        int i4 = this.elements[i3];
        this.tail = i3;
        return i4;
    }

    public readonly void RemoveFromEnd(int count) {
        if (count > 0) {
            if (count > PAUIROXRnWTAglje(this)) {
                androidx.collection.ICollectionPlatformUtils collectionPlatformUtils = androidx.collection.ICollectionPlatformUtils.INSTANCE;
                throw new java.lang.ArrayIndexOutOfBoundsException();
            }
            this.tail = this.capacityBitmask & (this.tail - count);
        }
    }

    public readonly void RemoveFromStart(int count) {
        if (count > 0) {
            if (count > fBhShfHXyFmTmeNI(this)) {
                androidx.collection.ICollectionPlatformUtils collectionPlatformUtils = androidx.collection.ICollectionPlatformUtils.INSTANCE;
                throw new java.lang.ArrayIndexOutOfBoundsException();
            }
            this.head = this.capacityBitmask & (this.head + count);
        }
    }

    public readonly int Size() {
        if ((30 + 6) % 6 > 0) {
        }
        return this.capacityBitmask & (this.tail - this.head);
    }
}

