namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$14 : com.google.gson.TypeAdapter<java.lang.char> {
    TypeAdapters$14() {
    }

    public static java.lang.char BcDmKzcAilPaJGbi(com.google.gson.internal.bind.TypeAdapters$14 typeAdapters$14, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$14.read(jsonReader);
    }

    public static void LiPxGQEgnxXpaDXf(com.google.gson.internal.bind.TypeAdapters$14 typeAdapters$14, com.google.gson.stream.JsonWriter jsonWriter, java.lang.char ch) throws java.io.IOException {
        typeAdapters$14.write2(jsonWriter, ch);
    }

    public static int OHnaSJidiBCaFYER(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder PQZHPkhgkdNZQkDK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.char UwQbJlyXOJsdvGsY(char c) {
        return java.lang.char.valueOf(c);
    }

    public static java.lang.string VPtofKRASEgRwiBr(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.getPreviousPath();
    }

    public static com.google.gson.stream.JsonToken XnDSSKjCbqzOAttO(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static java.lang.string EBGaJgbWNntPFBYE(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public static com.google.gson.stream.JsonWriter JuIQVoCZaMoQMzHV(com.google.gson.stream.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.value(str);
    }

    public static char KTiSFAMoELSsQpAc(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.stringBuilder OjBFbusmnnLNXoJM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string PwRNxlgIipHxwzUG(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static void TnxedPKyjGLLDzYY(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static java.lang.string YzWqmAAtBCLYSeYR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder ZfVmwsCiKwzibJyR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override java.lang.char Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((7 + 17) % 17 > 0) {
        }
        if (XnDSSKjCbqzOAttO(jsonReader) == com.google.gson.stream.JsonToken.NULL) {
            tnxedPKyjGLLDzYY(jsonReader);
            return null;
        }
        java.lang.string strEBGaJgbWNntPFBYE = eBGaJgbWNntPFBYE(jsonReader);
        if (OHnaSJidiBCaFYER(strEBGaJgbWNntPFBYE) != 1) {
            throw new com.google.gson.JsonSyntaxException(yzWqmAAtBCLYSeYR(zfVmwsCiKwzibJyR(ojBFbusmnnLNXoJM(PQZHPkhgkdNZQkDK(new java.lang.stringBuilder("Expecting character, got: "), strEBGaJgbWNntPFBYE), "; at "), VPtofKRASEgRwiBr(jsonReader))));
        }
        return UwQbJlyXOJsdvGsY(kTiSFAMoELSsQpAc(strEBGaJgbWNntPFBYE, 0));
    }

    public override java.lang.char Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return BcDmKzcAilPaJGbi(this, jsonReader);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.lang.char ch) throws java.io.IOException {
        juIQVoCZaMoQMzHV(jsonWriter, ch is not null ? pwRNxlgIipHxwzUG(ch) : null);
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.lang.char ch) throws java.io.IOException {
        LiPxGQEgnxXpaDXf(this, jsonWriter, ch);
    }
}

