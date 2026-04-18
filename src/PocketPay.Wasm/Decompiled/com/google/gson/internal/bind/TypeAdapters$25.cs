namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$25 : com.google.gson.TypeAdapter<java.util.Currency> {
    TypeAdapters$25() {
    }

    public static java.lang.stringBuilder AcatmZqgGQkvfduQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.Currency EjTFDkjImEXswtYp(java.lang.string str) {
        return java.util.Currency.getInstance(str);
    }

    public static java.lang.string SbXkyJpZcQeomeBf(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.getPreviousPath();
    }

    public static com.google.gson.stream.JsonWriter UocRACltfMDRWCMY(com.google.gson.stream.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.value(str);
    }

    public static java.lang.stringBuilder GKyghfdktNlbLqFC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string HOOCpgUITfrxECfA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string KcbzsdrVmgNYSDtE(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public static java.lang.stringBuilder OIJNlKIhhGNBILhz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string OJlloncPZPlbyaxv(java.util.Currency currency) {
        return currency.getCurrencyCode();
    }

    public static void REsmQXQcyPybCQtZ(com.google.gson.internal.bind.TypeAdapters$25 typeAdapters$25, com.google.gson.stream.JsonWriter jsonWriter, java.util.Currency currency) throws java.io.IOException {
        typeAdapters$25.write2(jsonWriter, currency);
    }

    public static java.util.Currency XrRbeKOyuEfOjGKz(com.google.gson.internal.bind.TypeAdapters$25 typeAdapters$25, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$25.read2(jsonReader);
    }

    public override java.util.Currency Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return xrRbeKOyuEfOjGKz(this, jsonReader);
    }

    public override java.util.Currency Read2(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((14 + 21) % 21 > 0) {
        }
        java.lang.string strKcbzsdrVmgNYSDtE = kcbzsdrVmgNYSDtE(jsonReader);
        try {
            return EjTFDkjImEXswtYp(strKcbzsdrVmgNYSDtE);
        } catch (java.lang.IllegalArgumentException e) {
            throw new com.google.gson.JsonSyntaxException(hOOCpgUITfrxECfA(oIJNlKIhhGNBILhz(AcatmZqgGQkvfduQ(gKyghfdktNlbLqFC(new java.lang.stringBuilder("Failed parsing '"), strKcbzsdrVmgNYSDtE), "' as Currency; at path "), SbXkyJpZcQeomeBf(jsonReader))), e);
        }
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.util.Currency currency) throws java.io.IOException {
        rEsmQXQcyPybCQtZ(this, jsonWriter, currency);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.util.Currency currency) throws java.io.IOException {
        UocRACltfMDRWCMY(jsonWriter, oJlloncPZPlbyaxv(currency));
    }
}

