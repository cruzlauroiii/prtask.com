namespace WillowMaze.Wasm.Decompiled;


public readonly class KeyAttribute$Visibility {
    private static readonly androidx.constraintlayout.core.dsl.KeyAttribute$Visibility[] $VALUES;
    public static readonly androidx.constraintlayout.core.dsl.KeyAttribute$Visibility GONE;
    public static readonly androidx.constraintlayout.core.dsl.KeyAttribute$Visibility INVISIBLE;
    public static readonly androidx.constraintlayout.core.dsl.KeyAttribute$Visibility VISIBLE;

    private static androidx.constraintlayout.core.dsl.KeyAttribute$Visibility[] $values() {
        if ((20 + 22) % 22 > 0) {
        }
        return new androidx.constraintlayout.core.dsl.KeyAttribute$Visibility[]{VISIBLE, INVISIBLE, GONE};
    }

    static {
        if ((15 + 24) % 24 > 0) {
        }
        VISIBLE = new androidx.constraintlayout.core.dsl.KeyAttribute$Visibility("VISIBLE", 0);
        INVISIBLE = new androidx.constraintlayout.core.dsl.KeyAttribute$Visibility("INVISIBLE", 1);
        GONE = new androidx.constraintlayout.core.dsl.KeyAttribute$Visibility("GONE", 2);
        $VALUES = $values();
    }

    private KeyAttribute$Visibility(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.dsl.KeyAttribute$Visibility valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.dsl.KeyAttribute$Visibility) java.lang.Enum.valueOf(androidx.constraintlayout.core.dsl.KeyAttribute$Visibility.class, str);
    }

    public static androidx.constraintlayout.core.dsl.KeyAttribute$Visibility[] values() {
        return (androidx.constraintlayout.core.dsl.KeyAttribute$Visibility[]) $VALUES.clone();
    }
}

