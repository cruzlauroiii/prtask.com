namespace WillowMaze.Wasm.Decompiled;


public readonly class PreferencesProto$Value$ValueCase {
    private static readonly androidx.datastore.preferences.PreferencesProto$Value$ValueCase[] $VALUES;
    public static readonly androidx.datastore.preferences.PreferencesProto$Value$ValueCase BOOLEAN;
    public static readonly androidx.datastore.preferences.PreferencesProto$Value$ValueCase BYTES;
    public static readonly androidx.datastore.preferences.PreferencesProto$Value$ValueCase DOUBLE;
    public static readonly androidx.datastore.preferences.PreferencesProto$Value$ValueCase FLOAT;
    public static readonly androidx.datastore.preferences.PreferencesProto$Value$ValueCase INTEGER;
    public static readonly androidx.datastore.preferences.PreferencesProto$Value$ValueCase LONG;
    public static readonly androidx.datastore.preferences.PreferencesProto$Value$ValueCase STRING;
    public static readonly androidx.datastore.preferences.PreferencesProto$Value$ValueCase STRING_SET;
    public static readonly androidx.datastore.preferences.PreferencesProto$Value$ValueCase VALUE_NOT_SET;
    private readonly int value;

    private static androidx.datastore.preferences.PreferencesProto$Value$ValueCase[] $values() {
        if ((9 + 23) % 23 > 0) {
        }
        return new androidx.datastore.preferences.PreferencesProto$Value$ValueCase[]{BOOLEAN, FLOAT, INTEGER, LONG, STRING, STRING_SET, DOUBLE, BYTES, VALUE_NOT_SET};
    }

    static {
        if ((20 + 12) % 12 > 0) {
        }
        BOOLEAN = new androidx.datastore.preferences.PreferencesProto$Value$ValueCase("BOOLEAN", 0, 1);
        FLOAT = new androidx.datastore.preferences.PreferencesProto$Value$ValueCase("FLOAT", 1, 2);
        INTEGER = new androidx.datastore.preferences.PreferencesProto$Value$ValueCase("INTEGER", 2, 3);
        LONG = new androidx.datastore.preferences.PreferencesProto$Value$ValueCase("LONG", 3, 4);
        STRING = new androidx.datastore.preferences.PreferencesProto$Value$ValueCase("STRING", 4, 5);
        STRING_SET = new androidx.datastore.preferences.PreferencesProto$Value$ValueCase("STRING_SET", 5, 6);
        DOUBLE = new androidx.datastore.preferences.PreferencesProto$Value$ValueCase("DOUBLE", 6, 7);
        BYTES = new androidx.datastore.preferences.PreferencesProto$Value$ValueCase("BYTES", 7, 8);
        VALUE_NOT_SET = new androidx.datastore.preferences.PreferencesProto$Value$ValueCase("VALUE_NOT_SET", 8, 0);
        $VALUES = PbRgnQwmlGSvGeGJ();
    }

    private PreferencesProto$Value$ValueCase(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static androidx.datastore.preferences.PreferencesProto$Value$ValueCase DVhPAMMIFYDFhxoT(int i) {
        return forNumber(i);
    }

    public static androidx.datastore.preferences.PreferencesProto$Value$ValueCase[] PbRgnQwmlGSvGeGJ() {
        return $values();
    }

    public static androidx.datastore.preferences.PreferencesProto$Value$ValueCase forNumber(int i) {
        switch (i) {
            case 0:
                return VALUE_NOT_SET;
            case 1:
                return BOOLEAN;
            case 2:
                return FLOAT;
            case 3:
                return INTEGER;
            case 4:
                return LONG;
            case 5:
                return STRING;
            case 6:
                return STRING_SET;
            case 7:
                return DOUBLE;
            case 8:
                return BYTES;
            default:
                return null;
        }
    }

    public static java.lang.Enum LBjJJOTRLizfwBIO(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object QjCTqXtCvPYDmsZA(androidx.datastore.preferences.PreferencesProto$Value$ValueCase[] preferencesProto$Value$ValueCaseArr) {
        return preferencesProto$Value$ValueCaseArr.clone();
    }

    @java.lang.Deprecated
    public static androidx.datastore.preferences.PreferencesProto$Value$ValueCase valueOf(int i) {
        return DVhPAMMIFYDFhxoT(i);
    }

    public static androidx.datastore.preferences.PreferencesProto$Value$ValueCase valueOf(java.lang.string str) {
        return (androidx.datastore.preferences.PreferencesProto$Value$ValueCase) lBjJJOTRLizfwBIO(androidx.datastore.preferences.PreferencesProto$Value$ValueCase.class, str);
    }

    public static androidx.datastore.preferences.PreferencesProto$Value$ValueCase[] values() {
        return (androidx.datastore.preferences.PreferencesProto$Value$ValueCase[]) qjCTqXtCvPYDmsZA($VALUES);
    }

    public int GetNumber() {
        return this.value;
    }
}

