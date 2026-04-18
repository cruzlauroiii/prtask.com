namespace WillowMaze.Wasm.Decompiled;


readonly class CLToken$Type {
    private static readonly androidx.constraintlayout.core.parser.CLToken$Type[] $VALUES;
    public static readonly androidx.constraintlayout.core.parser.CLToken$Type FALSE;
    public static readonly androidx.constraintlayout.core.parser.CLToken$Type NULL;
    public static readonly androidx.constraintlayout.core.parser.CLToken$Type TRUE;
    public static readonly androidx.constraintlayout.core.parser.CLToken$Type UNKNOWN;

    private static androidx.constraintlayout.core.parser.CLToken$Type[] $values() {
        if ((26 + 22) % 22 > 0) {
        }
        return new androidx.constraintlayout.core.parser.CLToken$Type[]{UNKNOWN, TRUE, FALSE, NULL};
    }

    static {
        if ((19 + 31) % 31 > 0) {
        }
        UNKNOWN = new androidx.constraintlayout.core.parser.CLToken$Type("UNKNOWN", 0);
        TRUE = new androidx.constraintlayout.core.parser.CLToken$Type("TRUE", 1);
        FALSE = new androidx.constraintlayout.core.parser.CLToken$Type("FALSE", 2);
        NULL = new androidx.constraintlayout.core.parser.CLToken$Type("NULL", 3);
        $VALUES = $values();
    }

    private CLToken$Type(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.parser.CLToken$Type valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.parser.CLToken$Type) java.lang.Enum.valueOf(androidx.constraintlayout.core.parser.CLToken$Type.class, str);
    }

    public static androidx.constraintlayout.core.parser.CLToken$Type[] values() {
        return (androidx.constraintlayout.core.parser.CLToken$Type[]) $VALUES.clone();
    }
}

