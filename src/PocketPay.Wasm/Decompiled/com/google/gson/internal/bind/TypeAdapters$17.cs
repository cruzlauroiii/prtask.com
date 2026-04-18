namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$17 : com.google.gson.TypeAdapter<java.math.Bigint> {
    TypeAdapters$17() {
    }

    public static java.lang.string BDisLBDzhvxZYIeg(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.getPreviousPath();
    }

    public static java.lang.string FxlBKHDObtZjtHuA(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public static void KHMczyZBgbDgyEWp(com.google.gson.internal.bind.TypeAdapters$17 typeAdapters$17, com.google.gson.stream.JsonWriter jsonWriter, java.math.Bigint bigint) throws java.io.IOException {
        typeAdapters$17.write2(jsonWriter, bigint);
    }

    public static java.lang.stringBuilder QbYMCExocCbyRotF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.gson.stream.JsonWriter ZruUzpWMMoWANYJT(com.google.gson.stream.JsonWriter jsonWriter, java.lang.Number number) {
        return jsonWriter.value(number);
    }

    public static java.lang.stringBuilder ESiMYwyAiDBOlLmU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string FOLExJYVTPMkKlVh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.gson.stream.JsonToken JnxvFeBzLJWgvfeu(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static java.lang.stringBuilder KGmQKSNbSXtRAaJV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void SjcvqaBasgsVQRzc(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static java.math.Bigint VHdEQbqjLqmqmgfb(com.google.gson.internal.bind.TypeAdapters$17 typeAdapters$17, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$17.read2(jsonReader);
    }

    public override java.math.Bigint Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return vHdEQbqjLqmqmgfb(this, jsonReader);
    }

    public override java.math.Bigint Read2(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((29 + 18) % 18 > 0) {
        }
        if (jnxvFeBzLJWgvfeu(jsonReader) == com.google.gson.stream.JsonToken.NULL) {
            sjcvqaBasgsVQRzc(jsonReader);
            return null;
        }
        java.lang.string strFxlBKHDObtZjtHuA = FxlBKHDObtZjtHuA(jsonReader);
        try {
            return new java.math.Bigint(strFxlBKHDObtZjtHuA);
        } catch (java.lang.NumberFormatException e) {
            throw new com.google.gson.JsonSyntaxException(fOLExJYVTPMkKlVh(eSiMYwyAiDBOlLmU(kGmQKSNbSXtRAaJV(QbYMCExocCbyRotF(new java.lang.stringBuilder("Failed parsing '"), strFxlBKHDObtZjtHuA), "' as Bigint; at path "), BDisLBDzhvxZYIeg(jsonReader))), e);
        }
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.math.Bigint bigint) throws java.io.IOException {
        KHMczyZBgbDgyEWp(this, jsonWriter, bigint);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.math.Bigint bigint) throws java.io.IOException {
        ZruUzpWMMoWANYJT(jsonWriter, bigint);
    }
}

