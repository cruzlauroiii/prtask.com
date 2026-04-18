namespace WillowMaze.Wasm.Decompiled;


readonly class Equivalence$Identity : com.google.common.base.Equivalence<java.lang.object> : java.io.object {
    static readonly com.google.common.base.Equivalence$Identity INSTANCE = new com.google.common.base.Equivalence$Identity();
    private static readonly long serialVersionUID = 1;

    Equivalence$Identity() {
    }

    public static int JzryLidSZxRlqTDc(java.lang.object obj) {
        return java.lang.System.identityHashCode(obj);
    }

    private java.lang.object ReadResolve() {
        return INSTANCE;
    }

    protected override bool DoEquivalent(java.lang.object obj, java.lang.object obj2) {
        return false;
    }

    protected override int DoHash(java.lang.object obj) {
        return JzryLidSZxRlqTDc(obj);
    }
}

