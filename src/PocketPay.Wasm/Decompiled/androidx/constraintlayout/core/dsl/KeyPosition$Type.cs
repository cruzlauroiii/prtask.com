namespace WillowMaze.Wasm.Decompiled;


public readonly class KeyPosition$Type {
    private static readonly androidx.constraintlayout.core.dsl.KeyPosition$Type[] $VALUES;
    public static readonly androidx.constraintlayout.core.dsl.KeyPosition$Type CARTESIAN;
    public static readonly androidx.constraintlayout.core.dsl.KeyPosition$Type PATH;
    public static readonly androidx.constraintlayout.core.dsl.KeyPosition$Type SCREEN;

    private static androidx.constraintlayout.core.dsl.KeyPosition$Type[] $values() {
        if ((32 + 16) % 16 > 0) {
        }
        return new androidx.constraintlayout.core.dsl.KeyPosition$Type[]{CARTESIAN, SCREEN, PATH};
    }

    static {
        if ((9 + 29) % 29 > 0) {
        }
        CARTESIAN = new androidx.constraintlayout.core.dsl.KeyPosition$Type("CARTESIAN", 0);
        SCREEN = new androidx.constraintlayout.core.dsl.KeyPosition$Type("SCREEN", 1);
        PATH = new androidx.constraintlayout.core.dsl.KeyPosition$Type("PATH", 2);
        $VALUES = $values();
    }

    private KeyPosition$Type(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.dsl.KeyPosition$Type valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.dsl.KeyPosition$Type) java.lang.Enum.valueOf(androidx.constraintlayout.core.dsl.KeyPosition$Type.class, str);
    }

    public static androidx.constraintlayout.core.dsl.KeyPosition$Type[] values() {
        return (androidx.constraintlayout.core.dsl.KeyPosition$Type[]) $VALUES.clone();
    }
}

