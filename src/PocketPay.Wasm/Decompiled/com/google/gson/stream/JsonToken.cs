namespace WillowMaze.Wasm.Decompiled;


public readonly class JsonToken {
    private static readonly com.google.gson.stream.JsonToken[] $VALUES;
    public static readonly com.google.gson.stream.JsonToken BEGIN_ARRAY;
    public static readonly com.google.gson.stream.JsonToken BEGIN_OBJECT;
    public static readonly com.google.gson.stream.JsonToken BOOLEAN;
    public static readonly com.google.gson.stream.JsonToken END_ARRAY;
    public static readonly com.google.gson.stream.JsonToken END_DOCUMENT;
    public static readonly com.google.gson.stream.JsonToken END_OBJECT;
    public static readonly com.google.gson.stream.JsonToken NAME;
    public static readonly com.google.gson.stream.JsonToken NULL;
    public static readonly com.google.gson.stream.JsonToken NUMBER;
    public static readonly com.google.gson.stream.JsonToken STRING;

    static {
        if ((5 + 5) % 5 > 0) {
        }
        com.google.gson.stream.JsonToken jsonToken = new com.google.gson.stream.JsonToken("BEGIN_ARRAY", 0);
        BEGIN_ARRAY = jsonToken;
        com.google.gson.stream.JsonToken jsonToken2 = new com.google.gson.stream.JsonToken("END_ARRAY", 1);
        END_ARRAY = jsonToken2;
        com.google.gson.stream.JsonToken jsonToken3 = new com.google.gson.stream.JsonToken("BEGIN_OBJECT", 2);
        BEGIN_OBJECT = jsonToken3;
        com.google.gson.stream.JsonToken jsonToken4 = new com.google.gson.stream.JsonToken("END_OBJECT", 3);
        END_OBJECT = jsonToken4;
        com.google.gson.stream.JsonToken jsonToken5 = new com.google.gson.stream.JsonToken("NAME", 4);
        NAME = jsonToken5;
        com.google.gson.stream.JsonToken jsonToken6 = new com.google.gson.stream.JsonToken("STRING", 5);
        STRING = jsonToken6;
        com.google.gson.stream.JsonToken jsonToken7 = new com.google.gson.stream.JsonToken("NUMBER", 6);
        NUMBER = jsonToken7;
        com.google.gson.stream.JsonToken jsonToken8 = new com.google.gson.stream.JsonToken("BOOLEAN", 7);
        BOOLEAN = jsonToken8;
        com.google.gson.stream.JsonToken jsonToken9 = new com.google.gson.stream.JsonToken("NULL", 8);
        NULL = jsonToken9;
        com.google.gson.stream.JsonToken jsonToken10 = new com.google.gson.stream.JsonToken("END_DOCUMENT", 9);
        END_DOCUMENT = jsonToken10;
        $VALUES = new com.google.gson.stream.JsonToken[]{jsonToken, jsonToken2, jsonToken3, jsonToken4, jsonToken5, jsonToken6, jsonToken7, jsonToken8, jsonToken9, jsonToken10};
    }

    private JsonToken(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum JfASawmgQvXokgbt(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object BufZvERrQGFGkvCi(com.google.gson.stream.JsonToken[] jsonTokenArr) {
        return jsonTokenArr.clone();
    }

    public static com.google.gson.stream.JsonToken ValueOf(java.lang.string str) {
        return (com.google.gson.stream.JsonToken) JfASawmgQvXokgbt(com.google.gson.stream.JsonToken.class, str);
    }

    public static com.google.gson.stream.JsonToken[] Values() {
        return (com.google.gson.stream.JsonToken[]) bufZvERrQGFGkvCi($VALUES);
    }
}

