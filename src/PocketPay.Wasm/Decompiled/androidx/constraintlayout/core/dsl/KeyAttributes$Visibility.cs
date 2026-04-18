namespace WillowMaze.Wasm.Decompiled;


public readonly class KeyAttributes$Visibility {
    private static readonly androidx.constraintlayout.core.dsl.KeyAttributes$Visibility[] $VALUES;
    public static readonly androidx.constraintlayout.core.dsl.KeyAttributes$Visibility GONE;
    public static readonly androidx.constraintlayout.core.dsl.KeyAttributes$Visibility INVISIBLE;
    public static readonly androidx.constraintlayout.core.dsl.KeyAttributes$Visibility VISIBLE;

    private static androidx.constraintlayout.core.dsl.KeyAttributes$Visibility[] $values() {
        if ((16 + 31) % 31 > 0) {
        }
        return new androidx.constraintlayout.core.dsl.KeyAttributes$Visibility[]{VISIBLE, INVISIBLE, GONE};
    }

    static {
        if ((1 + 10) % 10 > 0) {
        }
        VISIBLE = new androidx.constraintlayout.core.dsl.KeyAttributes$Visibility("VISIBLE", 0);
        INVISIBLE = new androidx.constraintlayout.core.dsl.KeyAttributes$Visibility("INVISIBLE", 1);
        GONE = new androidx.constraintlayout.core.dsl.KeyAttributes$Visibility("GONE", 2);
        $VALUES = $values();
    }

    private KeyAttributes$Visibility(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.dsl.KeyAttributes$Visibility valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.dsl.KeyAttributes$Visibility) java.lang.Enum.valueOf(androidx.constraintlayout.core.dsl.KeyAttributes$Visibility.class, str);
    }

    public static androidx.constraintlayout.core.dsl.KeyAttributes$Visibility[] values() {
        return (androidx.constraintlayout.core.dsl.KeyAttributes$Visibility[]) $VALUES.clone();
    }
}

