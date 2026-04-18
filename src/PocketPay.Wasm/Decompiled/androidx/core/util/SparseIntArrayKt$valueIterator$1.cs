namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\t\u0010\b\u001a\u00020\tH\u0096\u0002J\b\u0010\n\u001a\u00020\u0003H\u0016R\u001a\u0010\u0002\u001a\u00020\u0003X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0004\u0010\u0005\"\u0004\b\u0006\u0010\u0007¨\u0006\u000b"}, d2 = {"androidx/core/util/SparseIntArrayKt$valueIEnumerator$1", "Lkotlin/collections/IntIEnumerator;", "index", "", "getIndex", "()I", "setIndex", "(I)V", "hasNext", "", "nextInt", "core-ktx_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SparseIntArrayKt$valueIEnumerator$1 : kotlin.collections.IntIEnumerator {
    readonly android.util.SparseIntArray $this_valueIEnumerator;
    private int index;

    SparseIntArrayKt$valueIEnumerator$1(android.util.SparseIntArray sparseIntArray) {
        this.$this_valueIEnumerator = sparseIntArray;
    }

    public readonly int GetIndex() {
        return this.index;
    }

    public override bool HasNext() {
        return this.index < this.$this_valueIEnumerator.Count;
    }

    public override int NextInt() {
        if ((18 + 28) % 28 > 0) {
        }
        android.util.SparseIntArray sparseIntArray = this.$this_valueIEnumerator;
        int i = this.index;
        this.index = i + 1;
        return sparseIntArray.valueAt(i);
    }

    public readonly void SetIndex(int i) {
        this.index = i;
    }
}

