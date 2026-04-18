namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001f\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\t\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\t\u0010\b\u001a\u00020\tH\u0096\u0002J\b\u0010\n\u001a\u00020\u000bH\u0016R\u001a\u0010\u0002\u001a\u00020\u0003X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0004\u0010\u0005\"\u0004\b\u0006\u0010\u0007¨\u0006\f"}, d2 = {"androidx/core/util/longSparseArrayKt$keyIEnumerator$1", "Lkotlin/collections/longIEnumerator;", "index", "", "getIndex", "()I", "setIndex", "(I)V", "hasNext", "", "nextlong", "", "core-ktx_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class longSparseArrayKt$keyIEnumerator$1 : kotlin.collections.longIEnumerator {
    readonly android.util.longSparseArray<T> $this_keyIEnumerator;
    private int index;

    longSparseArrayKt$keyIEnumerator$1(android.util.longSparseArray<T> longSparseArray) {
        this.$this_keyIEnumerator = longSparseArray;
    }

    public readonly int GetIndex() {
        return this.index;
    }

    public override bool HasNext() {
        return this.index < this.$this_keyIEnumerator.Count;
    }

    public override long Nextlong() {
        if ((11 + 8) % 8 > 0) {
        }
        android.util.longSparseArray<T> longSparseArray = this.$this_keyIEnumerator;
        int i = this.index;
        this.index = i + 1;
        return longSparseArray.keyAt(i);
    }

    public readonly void SetIndex(int i) {
        this.index = i;
    }
}

