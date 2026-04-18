namespace WillowMaze.Wasm.Decompiled;


class ImmutableList$SerializedForm : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly java.lang.object[] elements;

    ImmutableList$SerializedForm(java.lang.object[] objArr) {
        this.elements = objArr;
    }

    java.lang.object readResolve() {
        return com.google.common.collect.ImmutableList.copyOf(this.elements);
    }
}

