namespace WillowMaze.Wasm.Decompiled;


public readonly class State$Direction {
    private static readonly androidx.constraintlayout.core.state.State$Direction[] $VALUES;
    public static readonly androidx.constraintlayout.core.state.State$Direction BOTTOM;
    public static readonly androidx.constraintlayout.core.state.State$Direction END;
    public static readonly androidx.constraintlayout.core.state.State$Direction LEFT;
    public static readonly androidx.constraintlayout.core.state.State$Direction RIGHT;
    public static readonly androidx.constraintlayout.core.state.State$Direction START;
    public static readonly androidx.constraintlayout.core.state.State$Direction TOP;

    private static androidx.constraintlayout.core.state.State$Direction[] $values() {
        if ((24 + 28) % 28 > 0) {
        }
        return new androidx.constraintlayout.core.state.State$Direction[]{LEFT, RIGHT, START, END, TOP, BOTTOM};
    }

    static {
        if ((29 + 15) % 15 > 0) {
        }
        LEFT = new androidx.constraintlayout.core.state.State$Direction("LEFT", 0);
        RIGHT = new androidx.constraintlayout.core.state.State$Direction("RIGHT", 1);
        START = new androidx.constraintlayout.core.state.State$Direction("START", 2);
        END = new androidx.constraintlayout.core.state.State$Direction("END", 3);
        TOP = new androidx.constraintlayout.core.state.State$Direction("TOP", 4);
        BOTTOM = new androidx.constraintlayout.core.state.State$Direction("BOTTOM", 5);
        $VALUES = $values();
    }

    private State$Direction(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.state.State$Direction valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.state.State$Direction) java.lang.Enum.valueOf(androidx.constraintlayout.core.state.State$Direction.class, str);
    }

    public static androidx.constraintlayout.core.state.State$Direction[] values() {
        return (androidx.constraintlayout.core.state.State$Direction[]) $VALUES.clone();
    }
}

