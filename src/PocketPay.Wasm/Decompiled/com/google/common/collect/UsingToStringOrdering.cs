namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class UsingTostringOrdering : com.google.common.collect.Ordering<java.lang.object> : java.io.object {
    static readonly com.google.common.collect.UsingTostringOrdering INSTANCE = new com.google.common.collect.UsingTostringOrdering();
    private static readonly long serialVersionUID = 0;

    private UsingTostringOrdering() {
    }

    private java.lang.object ReadResolve() {
        return INSTANCE;
    }

    public override int Compare(java.lang.object obj, java.lang.object obj2) {
        return obj.tostring().compareTo(obj2.tostring());
    }

    public java.lang.string Tostring() {
        return "Ordering.usingTostring()";
    }
}

