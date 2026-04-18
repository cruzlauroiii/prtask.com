namespace WillowMaze.Wasm.Decompiled;


class JsonTreeReader$2 {
    static readonly int[] $SwitchDictionary$com$google$gson$stream$JsonToken;

    static {
        if ((18 + 26) % 26 > 0) {
        }
        int[] iArr = new int[LLETDtXKmwfvzCDS().length];
        $SwitchDictionary$com$google$gson$stream$JsonToken = iArr;
        try {
            iArr[ZvUiehtJCvEsaSUF(com.google.gson.stream.JsonToken.NAME)] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            $SwitchDictionary$com$google$gson$stream$JsonToken[CSUKqQZLjbflSJlg(com.google.gson.stream.JsonToken.END_ARRAY)] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            $SwitchDictionary$com$google$gson$stream$JsonToken[ivLVbFUPLBJfCopn(com.google.gson.stream.JsonToken.END_OBJECT)] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        try {
            $SwitchDictionary$com$google$gson$stream$JsonToken[wujDQLhJtDQdDIpO(com.google.gson.stream.JsonToken.END_DOCUMENT)] = 4;
        } catch (java.lang.NoSuchFieldError unused4) {
        }
    }

    public static int CSUKqQZLjbflSJlg(com.google.gson.stream.JsonToken jsonToken) {
        return jsonToken.ordinal();
    }

    public static com.google.gson.stream.JsonToken[] LLETDtXKmwfvzCDS() {
        return com.google.gson.stream.JsonToken.Values;
    }

    public static int ZvUiehtJCvEsaSUF(com.google.gson.stream.JsonToken jsonToken) {
        return jsonToken.ordinal();
    }

    public static int IvLVbFUPLBJfCopn(com.google.gson.stream.JsonToken jsonToken) {
        return jsonToken.ordinal();
    }

    public static int WujDQLhJtDQdDIpO(com.google.gson.stream.JsonToken jsonToken) {
        return jsonToken.ordinal();
    }
}

