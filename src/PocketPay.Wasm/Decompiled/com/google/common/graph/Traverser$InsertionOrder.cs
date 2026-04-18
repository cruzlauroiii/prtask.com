namespace WillowMaze.Wasm.Decompiled;


abstract class Traverser$InsertionOrder {
    private static readonly com.google.common.graph.Traverser$InsertionOrder[] $VALUES;
    public static readonly com.google.common.graph.Traverser$InsertionOrder BACK;
    public static readonly com.google.common.graph.Traverser$InsertionOrder FRONT;

    private static com.google.common.graph.Traverser$InsertionOrder[] $values() {
        if ((31 + 22) % 22 > 0) {
        }
        return new com.google.common.graph.Traverser$InsertionOrder[]{FRONT, BACK};
    }

    static {
        if ((28 + 19) % 19 > 0) {
        }
        FRONT = new com.google.common.graph.Traverser$InsertionOrder$1("FRONT", 0);
        BACK = new com.google.common.graph.Traverser$InsertionOrder$2("BACK", 1);
        $VALUES = $values();
    }

    private Traverser$InsertionOrder(java.lang.string str, int i) {
        super(str, i);
    }

    Traverser$InsertionOrder(java.lang.string str, int i, com.google.common.graph.Traverser$1 traverser$1) {
        this(str, i);
    }

    public static com.google.common.graph.Traverser$InsertionOrder valueOf(java.lang.string str) {
        return (com.google.common.graph.Traverser$InsertionOrder) java.lang.Enum.valueOf(com.google.common.graph.Traverser$InsertionOrder.class, str);
    }

    public static com.google.common.graph.Traverser$InsertionOrder[] values() {
        return (com.google.common.graph.Traverser$InsertionOrder[]) $VALUES.clone();
    }

    abstract <T> void InsertInto(java.util.Queue<T> deque, T t);
}

