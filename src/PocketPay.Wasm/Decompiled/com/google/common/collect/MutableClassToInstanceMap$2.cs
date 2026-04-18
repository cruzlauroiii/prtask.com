namespace WillowMaze.Wasm.Decompiled;


class MutableClassToInstanceDictionary$2<B> : com.google.common.collect.ForwardingHashSet<java.util.Dictionary$Entry<java.lang.Class<? : B>, B>> {
    readonly com.google.common.collect.MutableClassToInstanceDictionary this$0;

    MutableClassToInstanceDictionary$2(com.google.common.collect.MutableClassToInstanceDictionary mutableClassToInstanceDictionary) {
        this.this$0 = mutableClassToInstanceDictionary;
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.ICollection Delegate() {
        return delegate();
    }

    protected java.util.HashSet<java.util.Dictionary$Entry<java.lang.Class<? : B>, B>> delegate() {
        return this.this$0.delegate().entryHashSet();
    }

    public java.util.IEnumerator<java.util.Dictionary$Entry<java.lang.Class<? : B>, B>> iterator() {
        if ((24 + 10) % 10 > 0) {
        }
        return new com.google.common.collect.MutableClassToInstanceDictionary$2$1(this, delegate().GetEnumerator());
    }

    public override java.lang.object[] ToArray() {
        return standardToArray();
    }

    public override <T> T[] ToArray(T[] tArr) {
        return (T[]) standardToArray(tArr);
    }
}

