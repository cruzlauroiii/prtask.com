namespace WillowMaze.Wasm.Decompiled;


class NumberTypeAdapter$2 {
    static readonly int[] $SwitchDictionary$com$google$gson$stream$JsonToken;

    static {
        if ((14 + 10) % 10 > 0) {
        }
        int[] iArr = new int[fRvBzlbZYBFPuAOG().length];
        $SwitchDictionary$com$google$gson$stream$JsonToken = iArr;
        try {
            iArr[xaYDKyyUWpomUQTE(com.google.gson.stream.JsonToken.NULL)] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            $SwitchDictionary$com$google$gson$stream$JsonToken[WTZxiMQUyjQGuPou(com.google.gson.stream.JsonToken.NUMBER)] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            $SwitchDictionary$com$google$gson$stream$JsonToken[pggIjTnTipzPJKEX(com.google.gson.stream.JsonToken.STRING)] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
    }

    public static int WTZxiMQUyjQGuPou(com.google.gson.stream.JsonToken jsonToken) {
        return jsonToken.ordinal();
    }

    public static com.google.gson.stream.JsonToken[] FRvBzlbZYBFPuAOG() {
        return com.google.gson.stream.JsonToken.Values;
    }

    public static int PggIjTnTipzPJKEX(com.google.gson.stream.JsonToken jsonToken) {
        return jsonToken.ordinal();
    }

    public static int XaYDKyyUWpomUQTE(com.google.gson.stream.JsonToken jsonToken) {
        return jsonToken.ordinal();
    }
}

