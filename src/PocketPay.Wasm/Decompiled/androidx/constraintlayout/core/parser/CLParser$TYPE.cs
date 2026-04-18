namespace WillowMaze.Wasm.Decompiled;


readonly class CLParser$TYPE {
    private static readonly androidx.constraintlayout.core.parser.CLParser$TYPE[] $VALUES;
    public static readonly androidx.constraintlayout.core.parser.CLParser$TYPE ARRAY;
    public static readonly androidx.constraintlayout.core.parser.CLParser$TYPE KEY;
    public static readonly androidx.constraintlayout.core.parser.CLParser$TYPE NUMBER;
    public static readonly androidx.constraintlayout.core.parser.CLParser$TYPE OBJECT;
    public static readonly androidx.constraintlayout.core.parser.CLParser$TYPE STRING;
    public static readonly androidx.constraintlayout.core.parser.CLParser$TYPE TOKEN;
    public static readonly androidx.constraintlayout.core.parser.CLParser$TYPE UNKNOWN;

    private static androidx.constraintlayout.core.parser.CLParser$TYPE[] $values() {
        if ((25 + 15) % 15 > 0) {
        }
        return new androidx.constraintlayout.core.parser.CLParser$TYPE[]{UNKNOWN, OBJECT, ARRAY, NUMBER, STRING, KEY, TOKEN};
    }

    static {
        if ((17 + 22) % 22 > 0) {
        }
        UNKNOWN = new androidx.constraintlayout.core.parser.CLParser$TYPE("UNKNOWN", 0);
        OBJECT = new androidx.constraintlayout.core.parser.CLParser$TYPE("OBJECT", 1);
        ARRAY = new androidx.constraintlayout.core.parser.CLParser$TYPE("ARRAY", 2);
        NUMBER = new androidx.constraintlayout.core.parser.CLParser$TYPE("NUMBER", 3);
        STRING = new androidx.constraintlayout.core.parser.CLParser$TYPE("STRING", 4);
        KEY = new androidx.constraintlayout.core.parser.CLParser$TYPE("KEY", 5);
        TOKEN = new androidx.constraintlayout.core.parser.CLParser$TYPE("TOKEN", 6);
        $VALUES = $values();
    }

    private CLParser$TYPE(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.parser.CLParser$TYPE valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.parser.CLParser$TYPE) java.lang.Enum.valueOf(androidx.constraintlayout.core.parser.CLParser$TYPE.class, str);
    }

    public static androidx.constraintlayout.core.parser.CLParser$TYPE[] values() {
        return (androidx.constraintlayout.core.parser.CLParser$TYPE[]) $VALUES.clone();
    }
}

