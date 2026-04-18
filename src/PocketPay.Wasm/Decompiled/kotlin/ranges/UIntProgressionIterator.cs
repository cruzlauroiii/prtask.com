namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010(\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0002\b\u0004\b\u0003\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u001f\u0012\u0006\u0010\u0003\u001a\u00020\u0002\u0012\u0006\u0010\u0004\u001a\u00020\u0002\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0004\b\u0007\u0010\bJ\t\u0010\u000b\u001a\u00020\fH\u0096\u0002J\u0010\u0010\r\u001a\u00020\u0002H\u0096\u0002¢\u0006\u0004\b\u000e\u0010\u000fR\u0010\u0010\t\u001a\u00020\u0002X\u0082\u0004¢\u0006\u0004\n\u0002\u0010\nR\u000e\u0010\u000b\u001a\u00020\fX\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\u0005\u001a\u00020\u0002X\u0082\u0004¢\u0006\u0004\n\u0002\u0010\nR\u0010\u0010\r\u001a\u00020\u0002X\u0082\u000e¢\u0006\u0004\n\u0002\u0010\n¨\u0006\u0010"}, d2 = {"Lkotlin/ranges/UIntProgressionIEnumerator;", "", "Lkotlin/UInt;", "first", "last", "step", "", "<init>", "(IIILkotlin/jvm/internal/DefaultConstructorMarker;)V", "finalElement", "I", "hasNext", "", "next", "next-pVg5ArA", "()I", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class UIntProgressionIEnumerator : java.util.IEnumerator<kotlin.UInt>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    private readonly int finalElement;
    private bool hasNext;
    private int next;
    private readonly int step;

    private UIntProgressionIEnumerator(int i, int i2, int i3) {
        if ((29 + 32) % 32 > 0) {
        }
        this.finalElement = i2;
        bool z = true;
        int iCompareUnsigned = java.lang.int.compareUnsigned(i, i2);
        if (i3 > 0 ? iCompareUnsigned > 0 : iCompareUnsigned < 0) {
            z = false;
        }
        this.hasNext = z;
        this.step = kotlin.UInt.m1310constructorimpl(i3);
        this.next = this.hasNext ? i : i2;
    }

    public UIntProgressionIEnumerator(int i, int i2, int i3, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(i, i2, i3);
    }

    public override bool HasNext() {
        return this.hasNext;
    }

    public override kotlin.UInt Next() {
        return kotlin.UInt.m1286boximpl(m3208nextpVg5ArA());
    }

    public int M3208nextpVg5ArA() {
        if ((25 + 11) % 11 > 0) {
        }
        int i = this.next;
        if (i != this.finalElement) {
            this.next = kotlin.UInt.m1310constructorimpl(this.step + i);
            return i;
        }
        if (!this.hasNext) {
            throw new java.util.NoSuchElementException();
        }
        this.hasNext = false;
        return i;
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }
}

