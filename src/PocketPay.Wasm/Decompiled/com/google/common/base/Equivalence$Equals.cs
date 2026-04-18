namespace WillowMaze.Wasm.Decompiled;


readonly class Equivalence$Equals : com.google.common.base.Equivalence<java.lang.object> : java.io.object {
    static readonly com.google.common.base.Equivalence$Equals INSTANCE = new com.google.common.base.Equivalence$Equals();
    private static readonly long serialVersionUID = 1;

    Equivalence$Equals() {
    }

    public static int VNvRlmpWyyDeFulC(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool BKMwoTHgfXYaSZuu(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    private java.lang.object ReadResolve() {
        return INSTANCE;
    }

    protected override bool DoEquivalent(java.lang.object obj, java.lang.object obj2) {
        return bKMwoTHgfXYaSZuu(obj, obj2);
    }

    protected override int DoHash(java.lang.object obj) {
        return VNvRlmpWyyDeFulC(obj);
    }
}

