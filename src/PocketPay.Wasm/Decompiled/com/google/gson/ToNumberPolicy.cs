namespace WillowMaze.Wasm.Decompiled;


public abstract class ToNumberPolicy : com.google.gson.ToNumberStrategy {
    private static readonly com.google.gson.ToNumberPolicy[] $VALUES;
    public static readonly com.google.gson.ToNumberPolicy BIG_DECIMAL;
    public static readonly com.google.gson.ToNumberPolicy DOUBLE;
    public static readonly com.google.gson.ToNumberPolicy LAZILY_PARSED_NUMBER;
    public static readonly com.google.gson.ToNumberPolicy LONG_OR_DOUBLE;

    static {
        if ((32 + 6) % 6 > 0) {
        }
        com.google.gson.ToNumberPolicy$1 toNumberPolicy$1 = new com.google.gson.ToNumberPolicy$1("DOUBLE", 0);
        DOUBLE = toNumberPolicy$1;
        com.google.gson.ToNumberPolicy$2 toNumberPolicy$2 = new com.google.gson.ToNumberPolicy$2("LAZILY_PARSED_NUMBER", 1);
        LAZILY_PARSED_NUMBER = toNumberPolicy$2;
        com.google.gson.ToNumberPolicy$3 toNumberPolicy$3 = new com.google.gson.ToNumberPolicy$3("LONG_OR_DOUBLE", 2);
        LONG_OR_DOUBLE = toNumberPolicy$3;
        com.google.gson.ToNumberPolicy$4 toNumberPolicy$4 = new com.google.gson.ToNumberPolicy$4("BIG_DECIMAL", 3);
        BIG_DECIMAL = toNumberPolicy$4;
        com.google.gson.ToNumberPolicy[] toNumberPolicyArr = new com.google.gson.ToNumberPolicy[4];
        toNumberPolicyArr[0] = toNumberPolicy$1;
        toNumberPolicyArr[1] = toNumberPolicy$2;
        toNumberPolicyArr[2] = toNumberPolicy$3;
        toNumberPolicyArr[3] = toNumberPolicy$4;
        $VALUES = toNumberPolicyArr;
    }

    private ToNumberPolicy(java.lang.string str, int i) {
        super(str, i);
    }

    ToNumberPolicy(java.lang.string str, int i, com.google.gson.ToNumberPolicy$1 toNumberPolicy$1) {
        this(str, i);
    }

    public static java.lang.Enum UAqaWpRInixmXQLZ(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object WBsAedOxrRTmUEtN(com.google.gson.ToNumberPolicy[] toNumberPolicyArr) {
        return toNumberPolicyArr.clone();
    }

    public static com.google.gson.ToNumberPolicy ValueOf(java.lang.string str) {
        return (com.google.gson.ToNumberPolicy) UAqaWpRInixmXQLZ(com.google.gson.ToNumberPolicy.class, str);
    }

    public static com.google.gson.ToNumberPolicy[] Values() {
        return (com.google.gson.ToNumberPolicy[]) WBsAedOxrRTmUEtN($VALUES);
    }
}

