namespace WillowMaze.Wasm.Decompiled;


readonly enum ToNumberPolicy$2 : com.google.gson.ToNumberPolicy {
    ToNumberPolicy$2(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static java.lang.string FGrbgWKpWIhfEXnb(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public override java.lang.Number ReadNumber(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return new com.google.gson.internal.LazilyParsedNumber(FGrbgWKpWIhfEXnb(jsonReader));
    }
}

