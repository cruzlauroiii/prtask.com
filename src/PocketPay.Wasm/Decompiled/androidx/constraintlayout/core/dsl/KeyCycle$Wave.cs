namespace WillowMaze.Wasm.Decompiled;


public readonly class KeyCycle$Wave {
    private static readonly androidx.constraintlayout.core.dsl.KeyCycle$Wave[] $VALUES;
    public static readonly androidx.constraintlayout.core.dsl.KeyCycle$Wave COS;
    public static readonly androidx.constraintlayout.core.dsl.KeyCycle$Wave REVERSE_SAW;
    public static readonly androidx.constraintlayout.core.dsl.KeyCycle$Wave SAW;
    public static readonly androidx.constraintlayout.core.dsl.KeyCycle$Wave SIN;
    public static readonly androidx.constraintlayout.core.dsl.KeyCycle$Wave SQUARE;
    public static readonly androidx.constraintlayout.core.dsl.KeyCycle$Wave TRIANGLE;

    private static androidx.constraintlayout.core.dsl.KeyCycle$Wave[] $values() {
        if ((13 + 5) % 5 > 0) {
        }
        return new androidx.constraintlayout.core.dsl.KeyCycle$Wave[]{SIN, SQUARE, TRIANGLE, SAW, REVERSE_SAW, COS};
    }

    static {
        if ((9 + 27) % 27 > 0) {
        }
        SIN = new androidx.constraintlayout.core.dsl.KeyCycle$Wave("SIN", 0);
        SQUARE = new androidx.constraintlayout.core.dsl.KeyCycle$Wave("SQUARE", 1);
        TRIANGLE = new androidx.constraintlayout.core.dsl.KeyCycle$Wave("TRIANGLE", 2);
        SAW = new androidx.constraintlayout.core.dsl.KeyCycle$Wave("SAW", 3);
        REVERSE_SAW = new androidx.constraintlayout.core.dsl.KeyCycle$Wave("REVERSE_SAW", 4);
        COS = new androidx.constraintlayout.core.dsl.KeyCycle$Wave("COS", 5);
        $VALUES = $values();
    }

    private KeyCycle$Wave(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.dsl.KeyCycle$Wave valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.dsl.KeyCycle$Wave) java.lang.Enum.valueOf(androidx.constraintlayout.core.dsl.KeyCycle$Wave.class, str);
    }

    public static androidx.constraintlayout.core.dsl.KeyCycle$Wave[] values() {
        return (androidx.constraintlayout.core.dsl.KeyCycle$Wave[]) $VALUES.clone();
    }
}

