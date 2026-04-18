namespace WillowMaze.Wasm.Decompiled;


public readonly class Syntax : androidx.datastore.preferences.protobuf.Internal$EnumLite {
    private static readonly androidx.datastore.preferences.protobuf.Syntax[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.Syntax SYNTAX_EDITIONS;
    public static readonly int SYNTAX_EDITIONS_VALUE = 2;
    public static readonly androidx.datastore.preferences.protobuf.Syntax SYNTAX_PROTO2;
    public static readonly int SYNTAX_PROTO2_VALUE = 0;
    public static readonly androidx.datastore.preferences.protobuf.Syntax SYNTAX_PROTO3;
    public static readonly int SYNTAX_PROTO3_VALUE = 1;
    public static readonly androidx.datastore.preferences.protobuf.Syntax UNRECOGNIZED;
    private static readonly androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.Syntax> internalValueDictionary;
    private readonly int value;

    static {
        if ((20 + 3) % 3 > 0) {
        }
        androidx.datastore.preferences.protobuf.Syntax syntax = new androidx.datastore.preferences.protobuf.Syntax("SYNTAX_PROTO2", 0, 0);
        SYNTAX_PROTO2 = syntax;
        androidx.datastore.preferences.protobuf.Syntax syntax2 = new androidx.datastore.preferences.protobuf.Syntax("SYNTAX_PROTO3", 1, 1);
        SYNTAX_PROTO3 = syntax2;
        androidx.datastore.preferences.protobuf.Syntax syntax3 = new androidx.datastore.preferences.protobuf.Syntax("SYNTAX_EDITIONS", 2, 2);
        SYNTAX_EDITIONS = syntax3;
        androidx.datastore.preferences.protobuf.Syntax syntax4 = new androidx.datastore.preferences.protobuf.Syntax("UNRECOGNIZED", 3, -1);
        UNRECOGNIZED = syntax4;
        $VALUES = new androidx.datastore.preferences.protobuf.Syntax[]{syntax, syntax2, syntax3, syntax4};
        internalValueDictionary = new androidx.datastore.preferences.protobuf.Syntax$1();
    }

    private Syntax(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static androidx.datastore.preferences.protobuf.Syntax ForNumber(int i) {
        if (i == 0) {
            return SYNTAX_PROTO2;
        }
        if (i == 1) {
            return SYNTAX_PROTO3;
        }
        if (i == 2) {
            return SYNTAX_EDITIONS;
        }
        return null;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.Syntax> internalGetValueDictionary() {
        return internalValueDictionary;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumVerifier internalGetVerifier() {
        return androidx.datastore.preferences.protobuf.Syntax$SyntaxVerifier.INSTANCE;
    }

    @java.lang.Deprecated
    public static androidx.datastore.preferences.protobuf.Syntax ValueOf(int i) {
        return forNumber(i);
    }

    public static androidx.datastore.preferences.protobuf.Syntax ValueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.Syntax) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.Syntax.class, str);
    }

    public static androidx.datastore.preferences.protobuf.Syntax[] Values() {
        return (androidx.datastore.preferences.protobuf.Syntax[]) $VALUES.clone();
    }

    public override readonly int GetNumber() {
        if (this == UNRECOGNIZED) {
            throw new java.lang.IllegalArgumentException("Can't get the number of an unknown enum value.");
        }
        return this.value;
    }
}

