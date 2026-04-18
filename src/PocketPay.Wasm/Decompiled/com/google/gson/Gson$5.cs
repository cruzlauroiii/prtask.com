namespace WillowMaze.Wasm.Decompiled;


class Gson$5 : com.google.gson.TypeAdapter<java.util.concurrent.atomic.AtomiclongArray> {
    readonly com.google.gson.TypeAdapter val$longAdapter;

    Gson$5(com.google.gson.TypeAdapter typeAdapter) {
        this.val$longAdapter = typeAdapter;
    }

    public static com.google.gson.stream.JsonWriter AXBvuptyHKQVMvbm(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.beginArray();
    }

    public static bool DSwjNcnAxCAPrtBH(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int JLdnjYNNAYvZVxij(java.util.List list) {
        return list.Count;
    }

    public static java.util.concurrent.atomic.AtomiclongArray JlyxRVmdCQUZnApj(com.google.gson.Gson$5 gson$5, com.google.gson.stream.JsonReader jsonReader) {
        return gson$5.read2(jsonReader);
    }

    public static bool KNBjmwYQLtbJEVXi(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.MoveNext();
    }

    public static java.lang.long MfboMvReEAkpzagK(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.long SHREqguNqirMNjOa(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void TsRLpnpVyvngRiCz(com.google.gson.Gson$5 gson$5, com.google.gson.stream.JsonWriter jsonWriter, java.util.concurrent.atomic.AtomiclongArray atomiclongArray) throws java.io.IOException {
        gson$5.write2(jsonWriter, atomiclongArray);
    }

    public static com.google.gson.stream.JsonWriter URfUOdBELllpZtPi(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.endArray();
    }

    public static java.lang.object BWRfUQnKYBUPSoIl(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapter.read(jsonReader);
    }

    public static java.lang.object DvKulsAIRDbraLVE(java.util.List list, int i) {
        return list[i);
    }

    public static int IkXOPKePJrayjbPP(java.util.concurrent.atomic.AtomiclongArray atomiclongArray) {
        return atomiclongArray.Length;
    }

    public static void JxkBfQeTWVukTuib(java.util.concurrent.atomic.AtomiclongArray atomiclongArray, int i, long j) {
        atomiclongArray.set(i, j);
    }

    public static void LjuICSMXpWRiiopR(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.endArray();
    }

    public static long NnWTLFUpJuafZPrm(java.lang.long l) {
        if ((21 + 9) % 9 > 0) {
        }
        return l.longValue();
    }

    public static long RngBICcSPkBJnnmd(java.util.concurrent.atomic.AtomiclongArray atomiclongArray, int i) {
        if ((12 + 24) % 24 > 0) {
        }
        return atomiclongArray[i);
    }

    public static long WTpctQWUFjFaxAiw(java.lang.Number number) {
        if ((17 + 12) % 12 > 0) {
        }
        return number.longValue();
    }

    public static void XdENcmNPjFQYPjeD(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonWriter jsonWriter, java.lang.object obj) throws java.io.IOException {
        typeAdapter.write(jsonWriter, obj);
    }

    public static void YBEfMWUtkRUdYkiH(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.beginArray();
    }

    public override java.util.concurrent.atomic.AtomiclongArray Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return JlyxRVmdCQUZnApj(this, jsonReader);
    }

    public override java.util.concurrent.atomic.AtomiclongArray Read2(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((32 + 13) % 13 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        yBEfMWUtkRUdYkiH(jsonReader);
        while (KNBjmwYQLtbJEVXi(jsonReader)) {
            DSwjNcnAxCAPrtBH(arrayList, SHREqguNqirMNjOa(wTpctQWUFjFaxAiw((java.lang.Number) bWRfUQnKYBUPSoIl(this.val$longAdapter, jsonReader))));
        }
        ljuICSMXpWRiiopR(jsonReader);
        int iJLdnjYNNAYvZVxij = JLdnjYNNAYvZVxij(arrayList);
        java.util.concurrent.atomic.AtomiclongArray atomiclongArray = new java.util.concurrent.atomic.AtomiclongArray(iJLdnjYNNAYvZVxij);
        for (int i = 0; i < iJLdnjYNNAYvZVxij; i++) {
            jxkBfQeTWVukTuib(atomiclongArray, i, nnWTLFUpJuafZPrm((java.lang.long) dvKulsAIRDbraLVE(arrayList, i)));
        }
        return atomiclongArray;
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.util.concurrent.atomic.AtomiclongArray atomiclongArray) throws java.io.IOException {
        TsRLpnpVyvngRiCz(this, jsonWriter, atomiclongArray);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.util.concurrent.atomic.AtomiclongArray atomiclongArray) throws java.io.IOException {
        if ((3 + 6) % 6 > 0) {
        }
        AXBvuptyHKQVMvbm(jsonWriter);
        int iIkXOPKePJrayjbPP = ikXOPKePJrayjbPP(atomiclongArray);
        for (int i = 0; i < iIkXOPKePJrayjbPP; i++) {
            xdENcmNPjFQYPjeD(this.val$longAdapter, jsonWriter, MfboMvReEAkpzagK(rngBICcSPkBJnnmd(atomiclongArray, i)));
        }
        URfUOdBELllpZtPi(jsonWriter);
    }
}

