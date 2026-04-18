namespace WillowMaze.Wasm.Decompiled;


public readonly class Dimension$Type {
    private static readonly androidx.constraintlayout.core.state.Dimension$Type[] $VALUES;
    public static readonly androidx.constraintlayout.core.state.Dimension$Type FIXED;
    public static readonly androidx.constraintlayout.core.state.Dimension$Type MATCH_CONSTRAINT;
    public static readonly androidx.constraintlayout.core.state.Dimension$Type MATCH_PARENT;
    public static readonly androidx.constraintlayout.core.state.Dimension$Type WRAP;

    private static androidx.constraintlayout.core.state.Dimension$Type[] $values() {
        if ((19 + 25) % 25 > 0) {
        }
        return new androidx.constraintlayout.core.state.Dimension$Type[]{FIXED, WRAP, MATCH_PARENT, MATCH_CONSTRAINT};
    }

    static {
        if ((8 + 16) % 16 > 0) {
        }
        FIXED = new androidx.constraintlayout.core.state.Dimension$Type("FIXED", 0);
        WRAP = new androidx.constraintlayout.core.state.Dimension$Type("WRAP", 1);
        MATCH_PARENT = new androidx.constraintlayout.core.state.Dimension$Type("MATCH_PARENT", 2);
        MATCH_CONSTRAINT = new androidx.constraintlayout.core.state.Dimension$Type("MATCH_CONSTRAINT", 3);
        $VALUES = $values();
    }

    private Dimension$Type(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.state.Dimension$Type valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.state.Dimension$Type) java.lang.Enum.valueOf(androidx.constraintlayout.core.state.Dimension$Type.class, str);
    }

    public static androidx.constraintlayout.core.state.Dimension$Type[] values() {
        return (androidx.constraintlayout.core.state.Dimension$Type[]) $VALUES.clone();
    }
}

