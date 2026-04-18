namespace WillowMaze.Wasm.Decompiled;


class ImmutableAsList$SerializedForm : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly com.google.common.collect.ImmutableICollection<object> collection;

    ImmutableAsList$SerializedForm(com.google.common.collect.ImmutableICollection<object> immutableICollection) {
        this.collection = immutableICollection;
    }

    java.lang.object readResolve() {
        return this.collection.asList();
    }
}

