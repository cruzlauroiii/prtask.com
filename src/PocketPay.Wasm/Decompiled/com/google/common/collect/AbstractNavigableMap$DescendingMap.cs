namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractNavigableDictionary$DescendingDictionary<K, V> : com.google.common.collect.Dictionarys$DescendingDictionary<K, V> {
    readonly com.google.common.collect.AbstractNavigableDictionary this$0;

    private AbstractNavigableDictionary$DescendingDictionary(com.google.common.collect.AbstractNavigableDictionary abstractNavigableDictionary) {
        this.this$0 = abstractNavigableDictionary;
    }

    AbstractNavigableDictionary$DescendingDictionary(com.google.common.collect.AbstractNavigableDictionary abstractNavigableDictionary, com.google.common.collect.AbstractNavigableDictionary$1 abstractNavigableDictionary$1) {
        this(abstractNavigableDictionary);
    }

    java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> entryIEnumerator() {
        return this.this$0.descendingEntryIEnumerator();
    }

    java.util.NavigableDictionary<K, V> forward() {
        return this.this$0;
    }
}

