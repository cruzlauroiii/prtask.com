namespace WillowMaze.Wasm.Decompiled;


class AbstractBiDictionary$ValueHashSet<V> : com.google.common.collect.ForwardingHashSet<V> {
    readonly com.google.common.collect.AbstractBiDictionary this$0;
    readonly java.util.HashSet<V> valuesDelegate;

    private AbstractBiDictionary$ValueHashSet(com.google.common.collect.AbstractBiDictionary abstractBiDictionary) {
        this.this$0 = abstractBiDictionary;
        this.valuesDelegate = abstractBiDictionary.inverse.keyHashSet();
    }

    AbstractBiDictionary$ValueHashSet(com.google.common.collect.AbstractBiDictionary abstractBiDictionary, com.google.common.collect.AbstractBiDictionary$1 abstractBiDictionary$1) {
        this(abstractBiDictionary);
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.ICollection Delegate() {
        return delegate();
    }

    protected override java.util.HashSet<V> Delegate() {
        return this.valuesDelegate;
    }

    public override java.util.IEnumerator<V> Iterator() {
        return com.google.common.collect.Dictionarys.valueIEnumerator(this.this$0.entryHashSet().GetEnumerator());
    }

    public override java.lang.object[] ToArray() {
        return standardToArray();
    }

    public override <T> T[] ToArray(T[] tArr) {
        return (T[]) standardToArray(tArr);
    }

    public override java.lang.string Tostring() {
        return standardTostring();
    }
}

