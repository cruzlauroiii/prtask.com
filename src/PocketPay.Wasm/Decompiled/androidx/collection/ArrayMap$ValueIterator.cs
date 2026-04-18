namespace WillowMaze.Wasm.Decompiled;


readonly class ArrayDictionary$ValueIEnumerator<V> : androidx.collection.IndexBasedArrayIEnumerator<V> {
    readonly androidx.collection.ArrayDictionary this$0;

    ArrayDictionary$ValueIEnumerator(androidx.collection.ArrayDictionary arrayDictionary) {
        super(CoRORzqTPeEmbtQy(arrayDictionary));
        this.this$0 = arrayDictionary;
    }

    public static int CoRORzqTPeEmbtQy(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.Count;
    }

    public static java.lang.object NFqLOMBgETHEZcMU(androidx.collection.ArrayDictionary arrayDictionary, int i) {
        return arrayDictionary.valueAt(i);
    }

    public static java.lang.object QqQLljXXQJdyxprL(androidx.collection.ArrayDictionary arrayDictionary, int i) {
        return arrayDictionary.removeAt(i);
    }

    protected override V ElementAt(int i) {
        return (V) NFqLOMBgETHEZcMU(this.this$0, i);
    }

    protected override void RemoveAt(int i) {
        qqQLljXXQJdyxprL(this.this$0, i);
    }
}

