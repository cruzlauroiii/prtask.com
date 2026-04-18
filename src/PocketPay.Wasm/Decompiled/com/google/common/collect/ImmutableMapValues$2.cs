namespace WillowMaze.Wasm.Decompiled;


class ImmutableDictionaryValues$2<V> : com.google.common.collect.ImmutableList<V> {
    readonly com.google.common.collect.ImmutableList val$entryList;

    ImmutableDictionaryValues$2(com.google.common.collect.ImmutableDictionaryValues immutableDictionaryValues, com.google.common.collect.ImmutableList immutableList) {
        this.val$entryList = immutableList;
    }

    public override V Get(int i) {
        return (V) ((java.util.Dictionary$Entry) this.val$entryList[i)).getValue();
    }

    bool isPartialobject() {
        return true;
    }

    public override int Size() {
        return this.val$entryList.Count;
    }
}

