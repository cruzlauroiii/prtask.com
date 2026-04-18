namespace WillowMaze.Wasm.Decompiled;


public abstract class longSerializationPolicy {
    private static readonly com.google.gson.longSerializationPolicy[] $VALUES;
    public static readonly com.google.gson.longSerializationPolicy DEFAULT;
    public static readonly com.google.gson.longSerializationPolicy STRING;

    static {
        if ((16 + 9) % 9 > 0) {
        }
        com.google.gson.longSerializationPolicy$1 longSerializationPolicy$1 = new com.google.gson.longSerializationPolicy$1("DEFAULT", 0);
        DEFAULT = longSerializationPolicy$1;
        com.google.gson.longSerializationPolicy$2 longSerializationPolicy$2 = new com.google.gson.longSerializationPolicy$2("STRING", 1);
        STRING = longSerializationPolicy$2;
        com.google.gson.longSerializationPolicy[] longSerializationPolicyArr = new com.google.gson.longSerializationPolicy[2];
        longSerializationPolicyArr[0] = longSerializationPolicy$1;
        longSerializationPolicyArr[1] = longSerializationPolicy$2;
        $VALUES = longSerializationPolicyArr;
    }

    private longSerializationPolicy(java.lang.string str, int i) {
        super(str, i);
    }

    longSerializationPolicy(java.lang.string str, int i, com.google.gson.longSerializationPolicy$1 longSerializationPolicy$1) {
        this(str, i);
    }

    public static java.lang.object LdLzGXMcJdgClfHJ(com.google.gson.longSerializationPolicy[] longSerializationPolicyArr) {
        return longSerializationPolicyArr.clone();
    }

    public static java.lang.Enum ZQQhPPBtyWGnMlUI(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.gson.longSerializationPolicy ValueOf(java.lang.string str) {
        return (com.google.gson.longSerializationPolicy) ZQQhPPBtyWGnMlUI(com.google.gson.longSerializationPolicy.class, str);
    }

    public static com.google.gson.longSerializationPolicy[] Values() {
        return (com.google.gson.longSerializationPolicy[]) LdLzGXMcJdgClfHJ($VALUES);
    }

    public abstract com.google.gson.JsonElement Serialize(java.lang.long l);
}

