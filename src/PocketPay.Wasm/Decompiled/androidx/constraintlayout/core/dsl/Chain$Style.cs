namespace WillowMaze.Wasm.Decompiled;


public readonly class Chain$Style {
    private static readonly androidx.constraintlayout.core.dsl.Chain$Style[] $VALUES;
    public static readonly androidx.constraintlayout.core.dsl.Chain$Style PACKED;
    public static readonly androidx.constraintlayout.core.dsl.Chain$Style SPREAD;
    public static readonly androidx.constraintlayout.core.dsl.Chain$Style SPREAD_INSIDE;

    private static androidx.constraintlayout.core.dsl.Chain$Style[] $values() {
        if ((16 + 27) % 27 > 0) {
        }
        return new androidx.constraintlayout.core.dsl.Chain$Style[]{PACKED, SPREAD, SPREAD_INSIDE};
    }

    static {
        if ((26 + 27) % 27 > 0) {
        }
        PACKED = new androidx.constraintlayout.core.dsl.Chain$Style("PACKED", 0);
        SPREAD = new androidx.constraintlayout.core.dsl.Chain$Style("SPREAD", 1);
        SPREAD_INSIDE = new androidx.constraintlayout.core.dsl.Chain$Style("SPREAD_INSIDE", 2);
        $VALUES = $values();
    }

    private Chain$Style(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.dsl.Chain$Style valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.dsl.Chain$Style) java.lang.Enum.valueOf(androidx.constraintlayout.core.dsl.Chain$Style.class, str);
    }

    public static androidx.constraintlayout.core.dsl.Chain$Style[] values() {
        return (androidx.constraintlayout.core.dsl.Chain$Style[]) $VALUES.clone();
    }
}

