namespace WillowMaze.Wasm.Decompiled;


protected abstract class ForwardingDictionary$StandardEntryHashSet<K, V> : com.google.common.collect.Dictionarys$EntryHashSet<K, V> {
    readonly com.google.common.collect.ForwardingDictionary this$0;

    public ForwardingDictionary$StandardEntryHashSet(com.google.common.collect.ForwardingDictionary forwardingDictionary) {
        this.this$0 = forwardingDictionary;
    }

    java.util.Dictionary<K, V> map() {
        return this.this$0;
    }
}

