namespace WillowMaze.Wasm.Decompiled;


readonly enum ToNumberPolicy$4 : com.google.gson.ToNumberPolicy {
    ToNumberPolicy$4(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static java.lang.string CHyKhgJlWwuTrPdk(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public static java.lang.stringBuilder HPrOcPEfUgDQbelw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.math.decimal ISebmYMhtFkLEwQo(com.google.gson.ToNumberPolicy$4 toNumberPolicy$4, com.google.gson.stream.JsonReader jsonReader) {
        return toNumberPolicy$4.readNumber(jsonReader);
    }

    public static java.lang.string BNQHbQXLJFrRTCjt(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.getPreviousPath();
    }

    public static java.lang.stringBuilder HYEoFsHpMFHLISZN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder PgMAUuQVOIneqZup(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string ZuChOpclnlTnAthn(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override java.lang.Number ReadNumber(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return ISebmYMhtFkLEwQo(this, jsonReader);
    }

    public override java.math.decimal ReadNumber(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((22 + 27) % 27 > 0) {
        }
        java.lang.string strCHyKhgJlWwuTrPdk = CHyKhgJlWwuTrPdk(jsonReader);
        try {
            return new java.math.decimal(strCHyKhgJlWwuTrPdk);
        } catch (java.lang.NumberFormatException e) {
            throw new com.google.gson.JsonParseException(zuChOpclnlTnAthn(hYEoFsHpMFHLISZN(pgMAUuQVOIneqZup(HPrOcPEfUgDQbelw(new java.lang.stringBuilder("Cannot parse "), strCHyKhgJlWwuTrPdk), "; at path "), bNQHbQXLJFrRTCjt(jsonReader))), e);
        }
    }
}

