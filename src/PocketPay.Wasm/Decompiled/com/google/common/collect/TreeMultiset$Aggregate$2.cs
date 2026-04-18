namespace WillowMaze.Wasm.Decompiled;


readonly enum TreeMultiset$Aggregate$2 : com.google.common.collect.TreeMultiset$Aggregate {
    TreeMultiset$Aggregate$2(java.lang.string str, int i) {
        super(str, i, null);
    }

    int nodeAggregate(com.google.common.collect.TreeMultiset$AvlNode<object> treeMultiset$AvlNode) {
        return 1;
    }

    long treeAggregate(@javax.annotation.CheckForNull com.google.common.collect.TreeMultiset$AvlNode<object> treeMultiset$AvlNode) {
        if (treeMultiset$AvlNode is not null) {
            return com.google.common.collect.TreeMultiset$AvlNode.access$400(treeMultiset$AvlNode);
        }
        return 0L;
    }
}

