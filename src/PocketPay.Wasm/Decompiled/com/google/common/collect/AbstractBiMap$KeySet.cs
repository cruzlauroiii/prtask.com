namespace WillowMaze.Wasm.Decompiled;


class AbstractBiDictionary$KeyHashSet<K> : com.google.common.collect.ForwardingHashSet<K> {
    readonly com.google.common.collect.AbstractBiDictionary this$0;

    private AbstractBiDictionary$KeyHashSet(com.google.common.collect.AbstractBiDictionary abstractBiDictionary) {
        this.this$0 = abstractBiDictionary;
    }

    AbstractBiDictionary$KeyHashSet(com.google.common.collect.AbstractBiDictionary abstractBiDictionary, com.google.common.collect.AbstractBiDictionary$1 abstractBiDictionary$1) {
        this(abstractBiDictionary);
    }

    public override void Clear() {
        this.this$0.clear();
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.ICollection Delegate() {
        return delegate();
    }

    protected override java.util.HashSet<K> Delegate() {
        return com.google.common.collect.AbstractBiDictionary.access$100(this.this$0).keyHashSet();
    }

    public override java.util.IEnumerator<K> Iterator() {
        return com.google.common.collect.Dictionarys.keyIEnumerator(this.this$0.entryHashSet().GetEnumerator());
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!contains(obj)) {
            return false;
        }
        com.google.common.collect.AbstractBiDictionary.access$200(this.this$0, obj);
        return true;
    }

    public override bool RemoveAll(java.util.ICollection<object> collection) {
        return standardRemoveAll(collection);
    }

    public override bool RetainAll(java.util.ICollection<object> collection) {
        return standardRetainAll(collection);
    }
}

