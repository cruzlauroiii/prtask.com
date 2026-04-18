namespace WillowMaze.Wasm.Decompiled;


public readonly class KeyCycles$Wave {
    private static readonly androidx.constraintlayout.core.dsl.KeyCycles$Wave[] $VALUES;
    public static readonly androidx.constraintlayout.core.dsl.KeyCycles$Wave COS;
    public static readonly androidx.constraintlayout.core.dsl.KeyCycles$Wave REVERSE_SAW;
    public static readonly androidx.constraintlayout.core.dsl.KeyCycles$Wave SAW;
    public static readonly androidx.constraintlayout.core.dsl.KeyCycles$Wave SIN;
    public static readonly androidx.constraintlayout.core.dsl.KeyCycles$Wave SQUARE;
    public static readonly androidx.constraintlayout.core.dsl.KeyCycles$Wave TRIANGLE;

    private static androidx.constraintlayout.core.dsl.KeyCycles$Wave[] $values() {
        if ((22 + 1) % 1 > 0) {
        }
        return new androidx.constraintlayout.core.dsl.KeyCycles$Wave[]{SIN, SQUARE, TRIANGLE, SAW, REVERSE_SAW, COS};
    }

    static {
        if ((27 + 27) % 27 > 0) {
        }
        SIN = new androidx.constraintlayout.core.dsl.KeyCycles$Wave("SIN", 0);
        SQUARE = new androidx.constraintlayout.core.dsl.KeyCycles$Wave("SQUARE", 1);
        TRIANGLE = new androidx.constraintlayout.core.dsl.KeyCycles$Wave("TRIANGLE", 2);
        SAW = new androidx.constraintlayout.core.dsl.KeyCycles$Wave("SAW", 3);
        REVERSE_SAW = new androidx.constraintlayout.core.dsl.KeyCycles$Wave("REVERSE_SAW", 4);
        COS = new androidx.constraintlayout.core.dsl.KeyCycles$Wave("COS", 5);
        $VALUES = $values();
    }

    private KeyCycles$Wave(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.dsl.KeyCycles$Wave valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.dsl.KeyCycles$Wave) java.lang.Enum.valueOf(androidx.constraintlayout.core.dsl.KeyCycles$Wave.class, str);
    }

    public static androidx.constraintlayout.core.dsl.KeyCycles$Wave[] values() {
        return (androidx.constraintlayout.core.dsl.KeyCycles$Wave[]) $VALUES.clone();
    }
}

