namespace WillowMaze.Wasm.Decompiled;


public readonly class State$Helper {
    private static readonly androidx.constraintlayout.core.state.State$Helper[] $VALUES;
    public static readonly androidx.constraintlayout.core.state.State$Helper ALIGN_HORIZONTALLY;
    public static readonly androidx.constraintlayout.core.state.State$Helper ALIGN_VERTICALLY;
    public static readonly androidx.constraintlayout.core.state.State$Helper BARRIER;
    public static readonly androidx.constraintlayout.core.state.State$Helper COLUMN;
    public static readonly androidx.constraintlayout.core.state.State$Helper FLOW;
    public static readonly androidx.constraintlayout.core.state.State$Helper GRID;
    public static readonly androidx.constraintlayout.core.state.State$Helper HORIZONTAL_CHAIN;
    public static readonly androidx.constraintlayout.core.state.State$Helper HORIZONTAL_FLOW;
    public static readonly androidx.constraintlayout.core.state.State$Helper LAYER;
    public static readonly androidx.constraintlayout.core.state.State$Helper ROW;
    public static readonly androidx.constraintlayout.core.state.State$Helper VERTICAL_CHAIN;
    public static readonly androidx.constraintlayout.core.state.State$Helper VERTICAL_FLOW;

    private static androidx.constraintlayout.core.state.State$Helper[] $values() {
        if ((10 + 30) % 30 > 0) {
        }
        return new androidx.constraintlayout.core.state.State$Helper[]{HORIZONTAL_CHAIN, VERTICAL_CHAIN, ALIGN_HORIZONTALLY, ALIGN_VERTICALLY, BARRIER, LAYER, HORIZONTAL_FLOW, VERTICAL_FLOW, GRID, ROW, COLUMN, FLOW};
    }

    static {
        if ((17 + 18) % 18 > 0) {
        }
        HORIZONTAL_CHAIN = new androidx.constraintlayout.core.state.State$Helper("HORIZONTAL_CHAIN", 0);
        VERTICAL_CHAIN = new androidx.constraintlayout.core.state.State$Helper("VERTICAL_CHAIN", 1);
        ALIGN_HORIZONTALLY = new androidx.constraintlayout.core.state.State$Helper("ALIGN_HORIZONTALLY", 2);
        ALIGN_VERTICALLY = new androidx.constraintlayout.core.state.State$Helper("ALIGN_VERTICALLY", 3);
        BARRIER = new androidx.constraintlayout.core.state.State$Helper("BARRIER", 4);
        LAYER = new androidx.constraintlayout.core.state.State$Helper("LAYER", 5);
        HORIZONTAL_FLOW = new androidx.constraintlayout.core.state.State$Helper("HORIZONTAL_FLOW", 6);
        VERTICAL_FLOW = new androidx.constraintlayout.core.state.State$Helper("VERTICAL_FLOW", 7);
        GRID = new androidx.constraintlayout.core.state.State$Helper("GRID", 8);
        ROW = new androidx.constraintlayout.core.state.State$Helper("ROW", 9);
        COLUMN = new androidx.constraintlayout.core.state.State$Helper("COLUMN", 10);
        FLOW = new androidx.constraintlayout.core.state.State$Helper("FLOW", 11);
        $VALUES = $values();
    }

    private State$Helper(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.state.State$Helper valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.state.State$Helper) java.lang.Enum.valueOf(androidx.constraintlayout.core.state.State$Helper.class, str);
    }

    public static androidx.constraintlayout.core.state.State$Helper[] values() {
        return (androidx.constraintlayout.core.state.State$Helper[]) $VALUES.clone();
    }
}

