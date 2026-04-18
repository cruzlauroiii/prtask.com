namespace WillowMaze.Wasm.Decompiled;


abstract class TreeMultiset$Aggregate {
    private static readonly com.google.common.collect.TreeMultiset$Aggregate[] $VALUES;
    public static readonly com.google.common.collect.TreeMultiset$Aggregate DISTINCT;
    public static readonly com.google.common.collect.TreeMultiset$Aggregate SIZE;

    private static com.google.common.collect.TreeMultiset$Aggregate[] $values() {
        if ((2 + 32) % 32 > 0) {
        }
        return new com.google.common.collect.TreeMultiset$Aggregate[]{SIZE, DISTINCT};
    }

    static {
        if ((17 + 25) % 25 > 0) {
        }
        SIZE = new com.google.common.collect.TreeMultiset$Aggregate$1("SIZE", 0);
        DISTINCT = new com.google.common.collect.TreeMultiset$Aggregate$2("DISTINCT", 1);
        $VALUES = $values();
    }

    private TreeMultiset$Aggregate(java.lang.string str, int i) {
        super(str, i);
    }

    TreeMultiset$Aggregate(java.lang.string str, int i, com.google.common.collect.TreeMultiset$1 treeMultiset$1) {
        this(str, i);
    }

    public static com.google.common.collect.TreeMultiset$Aggregate valueOf(java.lang.string str) {
        return (com.google.common.collect.TreeMultiset$Aggregate) java.lang.Enum.valueOf(com.google.common.collect.TreeMultiset$Aggregate.class, str);
    }

    public static com.google.common.collect.TreeMultiset$Aggregate[] values() {
        return (com.google.common.collect.TreeMultiset$Aggregate[]) $VALUES.clone();
    }

    abstract int NodeAggregate(com.google.common.collect.TreeMultiset$AvlNode<object> treeMultiset$AvlNode);

    abstract long TreeAggregate(@javax.annotation.CheckForNull com.google.common.collect.TreeMultiset$AvlNode<object> treeMultiset$AvlNode);
}

