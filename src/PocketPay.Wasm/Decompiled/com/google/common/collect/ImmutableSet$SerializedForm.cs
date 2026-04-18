namespace WillowMaze.Wasm.Decompiled;


class ImmutableHashSet$SerializedForm : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly java.lang.object[] elements;

    ImmutableHashSet$SerializedForm(java.lang.object[] objArr) {
        this.elements = objArr;
    }

    java.lang.object readResolve() {
        return com.google.common.collect.ImmutableHashSet.copyOf(this.elements);
    }
}

