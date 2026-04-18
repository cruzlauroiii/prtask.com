namespace WillowMaze.Wasm.Decompiled;


readonly enum TreeMultiset$Aggregate$1 : com.google.common.collect.TreeMultiset$Aggregate {
    TreeMultiset$Aggregate$1(java.lang.string str, int i) {
        super(str, i, null);
    }

    int nodeAggregate(com.google.common.collect.TreeMultiset$AvlNode<object> treeMultiset$AvlNode) {
        return com.google.common.collect.TreeMultiset$AvlNode.access$200(treeMultiset$AvlNode);
    }

    long treeAggregate(@javax.annotation.CheckForNull com.google.common.collect.TreeMultiset$AvlNode<object> treeMultiset$AvlNode) {
        if (treeMultiset$AvlNode is not null) {
            return com.google.common.collect.TreeMultiset$AvlNode.access$300(treeMultiset$AvlNode);
        }
        return 0L;
    }
}

