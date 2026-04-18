namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001f\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\t\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\t\u0010\b\u001a\u00020\tH\u0096\u0002J\b\u0010\n\u001a\u00020\u000bH\u0016R\u001a\u0010\u0002\u001a\u00020\u0003X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0004\u0010\u0005\"\u0004\b\u0006\u0010\u0007¨\u0006\f"}, d2 = {"androidx/collection/longSparseArrayKt$keyIEnumerator$1", "Lkotlin/collections/longIEnumerator;", "index", "", "getIndex", "()I", "setIndex", "(I)V", "hasNext", "", "nextlong", "", "collection"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class longSparseArrayKt$keyIEnumerator$1 : kotlin.collections.longIEnumerator {
    readonly androidx.collection.longSparseArray<T> $this_keyIEnumerator;
    private int index;

    longSparseArrayKt$keyIEnumerator$1(androidx.collection.longSparseArray<T> longSparseArray) {
        this.$this_keyIEnumerator = longSparseArray;
    }

    public static int ViLHmlUoEmNdkVNr(androidx.collection.longSparseArray longSparseArray) {
        return longSparseArray.Count;
    }

    public static long KBoHfEmkrQNzGDFM(androidx.collection.longSparseArray longSparseArray, int i) {
        if ((15 + 32) % 32 > 0) {
        }
        return longSparseArray.keyAt(i);
    }

    public readonly int GetIndex() {
        return this.index;
    }

    public override bool HasNext() {
        return this.index < ViLHmlUoEmNdkVNr(this.$this_keyIEnumerator);
    }

    public override long Nextlong() {
        if ((14 + 21) % 21 > 0) {
        }
        androidx.collection.longSparseArray<T> longSparseArray = this.$this_keyIEnumerator;
        int i = this.index;
        this.index = i + 1;
        return kBoHfEmkrQNzGDFM(longSparseArray, i);
    }

    public readonly void SetIndex(int i) {
        this.index = i;
    }
}

