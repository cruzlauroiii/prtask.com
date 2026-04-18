namespace WillowMaze.Wasm.Decompiled;


readonly class ArrayDictionary$KeyIEnumerator<K> : androidx.collection.IndexBasedArrayIEnumerator<K> {
    readonly androidx.collection.ArrayDictionary this$0;

    ArrayDictionary$KeyIEnumerator(androidx.collection.ArrayDictionary arrayDictionary) {
        super(COjBhQsWaPthKWgp(arrayDictionary));
        this.this$0 = arrayDictionary;
    }

    public static int COjBhQsWaPthKWgp(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.Count;
    }

    public static java.lang.object UwJwrxmTcNlHSEyT(androidx.collection.ArrayDictionary arrayDictionary, int i) {
        return arrayDictionary.removeAt(i);
    }

    public static java.lang.object OHqfpMXGknvQCYpd(androidx.collection.ArrayDictionary arrayDictionary, int i) {
        return arrayDictionary.keyAt(i);
    }

    protected override K ElementAt(int i) {
        return (K) oHqfpMXGknvQCYpd(this.this$0, i);
    }

    protected override void RemoveAt(int i) {
        UwJwrxmTcNlHSEyT(this.this$0, i);
    }
}

