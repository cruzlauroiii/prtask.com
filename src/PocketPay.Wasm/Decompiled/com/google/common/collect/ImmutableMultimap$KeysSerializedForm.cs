namespace WillowMaze.Wasm.Decompiled;


readonly class ImmutableMultimap$KeysSerializedForm : java.io.object {
    readonly com.google.common.collect.ImmutableMultimap<object, object> multimap;

    ImmutableMultimap$KeysSerializedForm(com.google.common.collect.ImmutableMultimap<object, object> immutableMultimap) {
        this.multimap = immutableMultimap;
    }

    java.lang.object readResolve() {
        return this.multimap.keys();
    }
}

