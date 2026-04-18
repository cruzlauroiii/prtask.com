namespace WillowMaze.Wasm.Decompiled;


class MutableClassToInstanceDictionary$1<B> : com.google.common.collect.ForwardingDictionaryEntry<java.lang.Class<? : B>, B> {
    readonly java.util.Dictionary$Entry val$entry;

    MutableClassToInstanceDictionary$1(java.util.Dictionary$Entry map$Entry) {
        this.val$entry = map$Entry;
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected java.util.Dictionary$Entry<java.lang.Class<? : B>, B> delegate() {
        return this.val$entry;
    }

    public override B SetValue(B b) {
        return (B) super.setValue(com.google.common.collect.MutableClassToInstanceDictionary.access$000(getKey(), b));
    }
}

