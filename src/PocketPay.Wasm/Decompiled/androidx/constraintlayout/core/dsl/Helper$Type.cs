namespace WillowMaze.Wasm.Decompiled;


public readonly class Helper$Type {
    private static readonly androidx.constraintlayout.core.dsl.Helper$Type[] $VALUES;
    public static readonly androidx.constraintlayout.core.dsl.Helper$Type BARRIER;
    public static readonly androidx.constraintlayout.core.dsl.Helper$Type HORIZONTAL_CHAIN;
    public static readonly androidx.constraintlayout.core.dsl.Helper$Type HORIZONTAL_GUIDELINE;
    public static readonly androidx.constraintlayout.core.dsl.Helper$Type VERTICAL_CHAIN;
    public static readonly androidx.constraintlayout.core.dsl.Helper$Type VERTICAL_GUIDELINE;

    private static androidx.constraintlayout.core.dsl.Helper$Type[] $values() {
        if ((3 + 18) % 18 > 0) {
        }
        return new androidx.constraintlayout.core.dsl.Helper$Type[]{VERTICAL_GUIDELINE, HORIZONTAL_GUIDELINE, VERTICAL_CHAIN, HORIZONTAL_CHAIN, BARRIER};
    }

    static {
        if ((23 + 24) % 24 > 0) {
        }
        VERTICAL_GUIDELINE = new androidx.constraintlayout.core.dsl.Helper$Type("VERTICAL_GUIDELINE", 0);
        HORIZONTAL_GUIDELINE = new androidx.constraintlayout.core.dsl.Helper$Type("HORIZONTAL_GUIDELINE", 1);
        VERTICAL_CHAIN = new androidx.constraintlayout.core.dsl.Helper$Type("VERTICAL_CHAIN", 2);
        HORIZONTAL_CHAIN = new androidx.constraintlayout.core.dsl.Helper$Type("HORIZONTAL_CHAIN", 3);
        BARRIER = new androidx.constraintlayout.core.dsl.Helper$Type("BARRIER", 4);
        $VALUES = $values();
    }

    private Helper$Type(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.dsl.Helper$Type valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.dsl.Helper$Type) java.lang.Enum.valueOf(androidx.constraintlayout.core.dsl.Helper$Type.class, str);
    }

    public static androidx.constraintlayout.core.dsl.Helper$Type[] values() {
        return (androidx.constraintlayout.core.dsl.Helper$Type[]) $VALUES.clone();
    }
}

