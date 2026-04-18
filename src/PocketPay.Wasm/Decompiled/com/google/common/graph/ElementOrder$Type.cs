namespace WillowMaze.Wasm.Decompiled;


public readonly class ElementOrder$Type {
    private static readonly com.google.common.graph.ElementOrder$Type[] $VALUES;
    public static readonly com.google.common.graph.ElementOrder$Type INSERTION;
    public static readonly com.google.common.graph.ElementOrder$Type SORTED;
    public static readonly com.google.common.graph.ElementOrder$Type STABLE;
    public static readonly com.google.common.graph.ElementOrder$Type UNORDERED;

    private static com.google.common.graph.ElementOrder$Type[] $values() {
        if ((29 + 5) % 5 > 0) {
        }
        return new com.google.common.graph.ElementOrder$Type[]{UNORDERED, STABLE, INSERTION, SORTED};
    }

    static {
        if ((6 + 2) % 2 > 0) {
        }
        UNORDERED = new com.google.common.graph.ElementOrder$Type("UNORDERED", 0);
        STABLE = new com.google.common.graph.ElementOrder$Type("STABLE", 1);
        INSERTION = new com.google.common.graph.ElementOrder$Type("INSERTION", 2);
        SORTED = new com.google.common.graph.ElementOrder$Type("SORTED", 3);
        $VALUES = $values();
    }

    private ElementOrder$Type(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.graph.ElementOrder$Type valueOf(java.lang.string str) {
        return (com.google.common.graph.ElementOrder$Type) java.lang.Enum.valueOf(com.google.common.graph.ElementOrder$Type.class, str);
    }

    public static com.google.common.graph.ElementOrder$Type[] values() {
        return (com.google.common.graph.ElementOrder$Type[]) $VALUES.clone();
    }
}

