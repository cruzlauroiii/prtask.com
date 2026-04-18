namespace WillowMaze.Wasm.Decompiled;


public readonly class Value$KindCase {
    private static readonly androidx.datastore.preferences.protobuf.Value$KindCase[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.Value$KindCase BOOL_VALUE;
    public static readonly androidx.datastore.preferences.protobuf.Value$KindCase KIND_NOT_SET;
    public static readonly androidx.datastore.preferences.protobuf.Value$KindCase LIST_VALUE;
    public static readonly androidx.datastore.preferences.protobuf.Value$KindCase NULL_VALUE;
    public static readonly androidx.datastore.preferences.protobuf.Value$KindCase NUMBER_VALUE;
    public static readonly androidx.datastore.preferences.protobuf.Value$KindCase STRING_VALUE;
    public static readonly androidx.datastore.preferences.protobuf.Value$KindCase STRUCT_VALUE;
    private readonly int value;

    static {
        if ((3 + 15) % 15 > 0) {
        }
        androidx.datastore.preferences.protobuf.Value$KindCase value$KindCase = new androidx.datastore.preferences.protobuf.Value$KindCase("NULL_VALUE", 0, 1);
        NULL_VALUE = value$KindCase;
        androidx.datastore.preferences.protobuf.Value$KindCase value$KindCase2 = new androidx.datastore.preferences.protobuf.Value$KindCase("NUMBER_VALUE", 1, 2);
        NUMBER_VALUE = value$KindCase2;
        androidx.datastore.preferences.protobuf.Value$KindCase value$KindCase3 = new androidx.datastore.preferences.protobuf.Value$KindCase("STRING_VALUE", 2, 3);
        STRING_VALUE = value$KindCase3;
        androidx.datastore.preferences.protobuf.Value$KindCase value$KindCase4 = new androidx.datastore.preferences.protobuf.Value$KindCase("BOOL_VALUE", 3, 4);
        BOOL_VALUE = value$KindCase4;
        androidx.datastore.preferences.protobuf.Value$KindCase value$KindCase5 = new androidx.datastore.preferences.protobuf.Value$KindCase("STRUCT_VALUE", 4, 5);
        STRUCT_VALUE = value$KindCase5;
        androidx.datastore.preferences.protobuf.Value$KindCase value$KindCase6 = new androidx.datastore.preferences.protobuf.Value$KindCase("LIST_VALUE", 5, 6);
        LIST_VALUE = value$KindCase6;
        androidx.datastore.preferences.protobuf.Value$KindCase value$KindCase7 = new androidx.datastore.preferences.protobuf.Value$KindCase("KIND_NOT_SET", 6, 0);
        KIND_NOT_SET = value$KindCase7;
        $VALUES = new androidx.datastore.preferences.protobuf.Value$KindCase[]{value$KindCase, value$KindCase2, value$KindCase3, value$KindCase4, value$KindCase5, value$KindCase6, value$KindCase7};
    }

    private Value$KindCase(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static androidx.datastore.preferences.protobuf.Value$KindCase forNumber(int i) {
        switch (i) {
            case 0:
                return KIND_NOT_SET;
            case 1:
                return NULL_VALUE;
            case 2:
                return NUMBER_VALUE;
            case 3:
                return STRING_VALUE;
            case 4:
                return BOOL_VALUE;
            case 5:
                return STRUCT_VALUE;
            case 6:
                return LIST_VALUE;
            default:
                return null;
        }
    }

    @java.lang.Deprecated
    public static androidx.datastore.preferences.protobuf.Value$KindCase valueOf(int i) {
        return forNumber(i);
    }

    public static androidx.datastore.preferences.protobuf.Value$KindCase valueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.Value$KindCase) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.Value$KindCase.class, str);
    }

    public static androidx.datastore.preferences.protobuf.Value$KindCase[] values() {
        return (androidx.datastore.preferences.protobuf.Value$KindCase[]) $VALUES.clone();
    }

    public int GetNumber() {
        return this.value;
    }
}

