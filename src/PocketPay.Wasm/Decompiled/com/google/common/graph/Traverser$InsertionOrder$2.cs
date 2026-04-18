namespace WillowMaze.Wasm.Decompiled;


readonly enum Traverser$InsertionOrder$2 : com.google.common.graph.Traverser$InsertionOrder {
    Traverser$InsertionOrder$2(java.lang.string str, int i) {
        super(str, i, null);
    }

    <T> void insertInto(java.util.Queue<T> deque, T t) {
        deque.addLast(t);
    }
}

