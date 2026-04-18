namespace WillowMaze.Wasm.Decompiled;


readonly enum ToNumberPolicy$1 : com.google.gson.ToNumberPolicy {
    ToNumberPolicy$1(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static java.lang.double JkIJVixnmhpFxzvl(com.google.gson.ToNumberPolicy$1 toNumberPolicy$1, com.google.gson.stream.JsonReader jsonReader) {
        return toNumberPolicy$1.readNumber(jsonReader);
    }

    public static double OrOUTaEDHhltHODp(com.google.gson.stream.JsonReader jsonReader) {
        if ((27 + 14) % 14 > 0) {
        }
        return jsonReader.nextdouble();
    }

    public static java.lang.double UbjgxdrLbUUEAfji(double d) {
        return java.lang.double.valueOf(d);
    }

    public override java.lang.double ReadNumber(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return ubjgxdrLbUUEAfji(OrOUTaEDHhltHODp(jsonReader));
    }

    public override java.lang.Number ReadNumber(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return JkIJVixnmhpFxzvl(this, jsonReader);
    }
}

