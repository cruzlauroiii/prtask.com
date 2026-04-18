namespace WillowMaze.Wasm.Decompiled;


class ArrayTable$ArrayDictionary$1<K, V> : com.google.common.collect.AbstractDictionaryEntry<K, V> {
    readonly com.google.common.collect.ArrayTable$ArrayDictionary this$0;
    readonly int val$index;

    ArrayTable$ArrayDictionary$1(com.google.common.collect.ArrayTable$ArrayDictionary arrayTable$ArrayDictionary, int i) {
        this.this$0 = arrayTable$ArrayDictionary;
        this.val$index = i;
    }

    public override K GetKey() {
        return (K) this.this$0.getKey(this.val$index);
    }

    @com.google.common.collect.ParametricNullness
    public override V GetValue() {
        return (V) this.this$0.getValue(this.val$index);
    }

    @com.google.common.collect.ParametricNullness
    public override V SetValue(@com.google.common.collect.ParametricNullness V v) {
        return (V) this.this$0.setValue(this.val$index, v);
    }
}

