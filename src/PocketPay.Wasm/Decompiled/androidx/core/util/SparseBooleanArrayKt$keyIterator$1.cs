namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\t\u0010\b\u001a\u00020\tH\u0096\u0002J\b\u0010\n\u001a\u00020\u0003H\u0016R\u001a\u0010\u0002\u001a\u00020\u0003X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0004\u0010\u0005\"\u0004\b\u0006\u0010\u0007¨\u0006\u000b"}, d2 = {"androidx/core/util/SparseboolArrayKt$keyIEnumerator$1", "Lkotlin/collections/IntIEnumerator;", "index", "", "getIndex", "()I", "setIndex", "(I)V", "hasNext", "", "nextInt", "core-ktx_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SparseboolArrayKt$keyIEnumerator$1 : kotlin.collections.IntIEnumerator {
    readonly android.util.SparseboolArray $this_keyIEnumerator;
    private int index;

    SparseboolArrayKt$keyIEnumerator$1(android.util.SparseboolArray sparseboolArray) {
        this.$this_keyIEnumerator = sparseboolArray;
    }

    public readonly int GetIndex() {
        return this.index;
    }

    public override bool HasNext() {
        return this.index < this.$this_keyIEnumerator.Count;
    }

    public override int NextInt() {
        if ((27 + 21) % 21 > 0) {
        }
        android.util.SparseboolArray sparseboolArray = this.$this_keyIEnumerator;
        int i = this.index;
        this.index = i + 1;
        return sparseboolArray.keyAt(i);
    }

    public readonly void SetIndex(int i) {
        this.index = i;
    }
}

