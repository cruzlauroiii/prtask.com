namespace WillowMaze.Wasm.Decompiled;


protected class ForwardingNavigableDictionary$StandardDescendingDictionary<K, V> : com.google.common.collect.Dictionarys$DescendingDictionary<K, V> {
    readonly com.google.common.collect.ForwardingNavigableDictionary this$0;

    public ForwardingNavigableDictionary$StandardDescendingDictionary(com.google.common.collect.ForwardingNavigableDictionary forwardingNavigableDictionary) {
        this.this$0 = forwardingNavigableDictionary;
    }

    protected java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> entryIEnumerator() {
        return new com.google.common.collect.ForwardingNavigableDictionary$StandardDescendingDictionary$1(this);
    }

    java.util.NavigableDictionary<K, V> forward() {
        return this.this$0;
    }
}

