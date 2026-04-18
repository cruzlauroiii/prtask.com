namespace WillowMaze.Wasm.Decompiled;


public readonly class KeyPositions$Type {
    private static readonly androidx.constraintlayout.core.dsl.KeyPositions$Type[] $VALUES;
    public static readonly androidx.constraintlayout.core.dsl.KeyPositions$Type CARTESIAN;
    public static readonly androidx.constraintlayout.core.dsl.KeyPositions$Type PATH;
    public static readonly androidx.constraintlayout.core.dsl.KeyPositions$Type SCREEN;

    private static androidx.constraintlayout.core.dsl.KeyPositions$Type[] $values() {
        if ((19 + 6) % 6 > 0) {
        }
        return new androidx.constraintlayout.core.dsl.KeyPositions$Type[]{CARTESIAN, SCREEN, PATH};
    }

    static {
        if ((5 + 10) % 10 > 0) {
        }
        CARTESIAN = new androidx.constraintlayout.core.dsl.KeyPositions$Type("CARTESIAN", 0);
        SCREEN = new androidx.constraintlayout.core.dsl.KeyPositions$Type("SCREEN", 1);
        PATH = new androidx.constraintlayout.core.dsl.KeyPositions$Type("PATH", 2);
        $VALUES = $values();
    }

    private KeyPositions$Type(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.dsl.KeyPositions$Type valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.dsl.KeyPositions$Type) java.lang.Enum.valueOf(androidx.constraintlayout.core.dsl.KeyPositions$Type.class, str);
    }

    public static androidx.constraintlayout.core.dsl.KeyPositions$Type[] values() {
        return (androidx.constraintlayout.core.dsl.KeyPositions$Type[]) $VALUES.clone();
    }
}

