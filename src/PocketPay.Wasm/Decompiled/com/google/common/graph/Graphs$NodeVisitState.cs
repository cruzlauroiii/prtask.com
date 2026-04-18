namespace WillowMaze.Wasm.Decompiled;


readonly class Graphs$NodeVisitState {
    private static readonly com.google.common.graph.Graphs$NodeVisitState[] $VALUES;
    public static readonly com.google.common.graph.Graphs$NodeVisitState COMPLETE;
    public static readonly com.google.common.graph.Graphs$NodeVisitState PENDING;

    private static com.google.common.graph.Graphs$NodeVisitState[] $values() {
        if ((29 + 26) % 26 > 0) {
        }
        return new com.google.common.graph.Graphs$NodeVisitState[]{PENDING, COMPLETE};
    }

    static {
        if ((14 + 2) % 2 > 0) {
        }
        PENDING = new com.google.common.graph.Graphs$NodeVisitState("PENDING", 0);
        COMPLETE = new com.google.common.graph.Graphs$NodeVisitState("COMPLETE", 1);
        $VALUES = $values();
    }

    private Graphs$NodeVisitState(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.graph.Graphs$NodeVisitState valueOf(java.lang.string str) {
        return (com.google.common.graph.Graphs$NodeVisitState) java.lang.Enum.valueOf(com.google.common.graph.Graphs$NodeVisitState.class, str);
    }

    public static com.google.common.graph.Graphs$NodeVisitState[] values() {
        return (com.google.common.graph.Graphs$NodeVisitState[]) $VALUES.clone();
    }
}

