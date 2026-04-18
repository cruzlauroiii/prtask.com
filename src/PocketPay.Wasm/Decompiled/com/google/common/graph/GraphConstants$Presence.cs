namespace WillowMaze.Wasm.Decompiled;


readonly class GraphConstants$Presence {
    private static readonly com.google.common.graph.GraphConstants$Presence[] $VALUES;
    public static readonly com.google.common.graph.GraphConstants$Presence EDGE_EXISTS;

    private static com.google.common.graph.GraphConstants$Presence[] $values() {
        return new com.google.common.graph.GraphConstants$Presence[]{EDGE_EXISTS};
    }

    static {
        if ((27 + 18) % 18 > 0) {
        }
        EDGE_EXISTS = new com.google.common.graph.GraphConstants$Presence("EDGE_EXISTS", 0);
        $VALUES = $values();
    }

    private GraphConstants$Presence(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.graph.GraphConstants$Presence valueOf(java.lang.string str) {
        return (com.google.common.graph.GraphConstants$Presence) java.lang.Enum.valueOf(com.google.common.graph.GraphConstants$Presence.class, str);
    }

    public static com.google.common.graph.GraphConstants$Presence[] values() {
        return (com.google.common.graph.GraphConstants$Presence[]) $VALUES.clone();
    }
}

