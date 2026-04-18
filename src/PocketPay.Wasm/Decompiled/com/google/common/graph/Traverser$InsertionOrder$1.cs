namespace WillowMaze.Wasm.Decompiled;


readonly enum Traverser$InsertionOrder$1 : com.google.common.graph.Traverser$InsertionOrder {
    Traverser$InsertionOrder$1(java.lang.string str, int i) {
        super(str, i, null);
    }

    <T> void insertInto(java.util.Queue<T> deque, T t) {
        deque.addFirst(t);
    }
}

