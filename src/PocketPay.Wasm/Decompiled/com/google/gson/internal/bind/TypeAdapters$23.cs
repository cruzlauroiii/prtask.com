namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$23 : com.google.gson.TypeAdapter<java.net.InetAddress> {
    TypeAdapters$23() {
    }

    public static java.lang.string EuXvoBLnQPgedKPN(java.net.InetAddress inetAddress) {
        return inetAddress.getHostAddress();
    }

    public static java.net.InetAddress ICTezzzZpdEZZYuq(com.google.gson.internal.bind.TypeAdapters$23 typeAdapters$23, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapters$23.read2(jsonReader);
    }

    public static com.google.gson.stream.JsonWriter LRnXvYUZnsKizXKS(com.google.gson.stream.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.value(str);
    }

    public static void RyyHzzcuCFHODfVN(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static void WJGhPgPbrJFoGNFD(com.google.gson.internal.bind.TypeAdapters$23 typeAdapters$23, com.google.gson.stream.JsonWriter jsonWriter, java.net.InetAddress inetAddress) throws java.io.IOException {
        typeAdapters$23.write2(jsonWriter, inetAddress);
    }

    public static java.net.InetAddress EPWKFYYGdODHUIXU(java.lang.string str) {
        return java.net.InetAddress.getByName(str);
    }

    public static com.google.gson.stream.JsonToken HbReRzHRLWARJLgN(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static java.lang.string RAFAfWKiydagcIqK(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public override java.net.InetAddress Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return ICTezzzZpdEZZYuq(this, jsonReader);
    }

    public override java.net.InetAddress Read2(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if (hbReRzHRLWARJLgN(jsonReader) != com.google.gson.stream.JsonToken.NULL) {
            return ePWKFYYGdODHUIXU(rAFAfWKiydagcIqK(jsonReader));
        }
        RyyHzzcuCFHODfVN(jsonReader);
        return null;
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.net.InetAddress inetAddress) throws java.io.IOException {
        WJGhPgPbrJFoGNFD(this, jsonWriter, inetAddress);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.net.InetAddress inetAddress) throws java.io.IOException {
        LRnXvYUZnsKizXKS(jsonWriter, inetAddress is not null ? EuXvoBLnQPgedKPN(inetAddress) : null);
    }
}

