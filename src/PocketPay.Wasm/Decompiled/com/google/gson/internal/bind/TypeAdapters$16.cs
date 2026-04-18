namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$16 : com.google.gson.TypeAdapter<java.math.decimal> {
    TypeAdapters$16() {
    }

    public static com.google.gson.stream.JsonWriter BNmoomuFZyaNbUpI(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) {
        return jsonWriter.value(number);
    }

    public static void BUwDxMCZWlSVyjvT(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static java.lang.stringBuilder LHxZNUDdOEwgzdFw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void NcQbuhjrivIoJSbB(com.google.gson.internal.bind.TypeAdapters$16 typeAdapters$16, com.google.gson.stream.JsonWriter jsonWriter, java.math.decimal bigDecimal) throws java.io.IOException {
        typeAdapters$16.write2(jsonWriter, bigDecimal);
    }

    public static java.lang.stringBuilder VrYbttDWxrOBpCJv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ZeetCrTnwayXpySA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string GGbyQskybZzhcCPu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string HNGlzhjlJMEuWzlj(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.getPreviousPath();
    }

    public static java.lang.string IWaalBKbZxsRkBtm(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public static com.google.gson.stream.JsonToken OUQmrDWRALpnylio(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static java.math.decimal UGDdUMdasVmCxWOt(com.google.gson.internal.bind.TypeAdapters$16 typeAdapters$16, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$16.read2(jsonReader);
    }

    public override java.math.decimal Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return uGDdUMdasVmCxWOt(this, jsonReader);
    }

    public override java.math.decimal Read2(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((15 + 19) % 19 > 0) {
        }
        if (oUQmrDWRALpnylio(jsonReader) == com.google.gson.stream.JsonToken.NULL) {
            BUwDxMCZWlSVyjvT(jsonReader);
            return null;
        }
        java.lang.string strIWaalBKbZxsRkBtm = iWaalBKbZxsRkBtm(jsonReader);
        try {
            return new java.math.decimal(strIWaalBKbZxsRkBtm);
        } catch (java.lang.NumberFormatException e) {
            throw new com.google.gson.JsonSyntaxException(gGbyQskybZzhcCPu(ZeetCrTnwayXpySA(VrYbttDWxrOBpCJv(LHxZNUDdOEwgzdFw(new java.lang.stringBuilder("Failed parsing '"), strIWaalBKbZxsRkBtm), "' as decimal; at path "), hNGlzhjlJMEuWzlj(jsonReader))), e);
        }
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.math.decimal bigDecimal) throws java.io.IOException {
        NcQbuhjrivIoJSbB(this, jsonWriter, bigDecimal);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.math.decimal bigDecimal) throws java.io.IOException {
        BNmoomuFZyaNbUpI(jsonWriter, bigDecimal);
    }
}

