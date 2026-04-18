namespace WillowMaze.Wasm.Decompiled;


class Gson$4 : com.google.gson.TypeAdapter<java.util.concurrent.atomic.Atomiclong> {
    readonly com.google.gson.TypeAdapter val$longAdapter;

    Gson$4(com.google.gson.TypeAdapter typeAdapter) {
        this.val$longAdapter = typeAdapter;
    }

    public static void GONmJsxXsSKyqxyV(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonWriter jsonWriter, java.lang.object obj) throws java.io.IOException {
        typeAdapter.write(jsonWriter, obj);
    }

    public static java.lang.object ZWJKJDDEtHsDaXiF(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapter.read(jsonReader);
    }

    public static java.util.concurrent.atomic.Atomiclong LhfJYJnfvRtrQwgt(com.google.gson.Gson$4 gson$4, com.google.gson.stream.JsonReader jsonReader) {
        return gson$4.read2(jsonReader);
    }

    public static void OfIQWvZKdLjMfAPv(com.google.gson.Gson$4 gson$4, com.google.gson.stream.JsonWriter jsonWriter, java.util.concurrent.atomic.Atomiclong atomiclong) throws java.io.IOException {
        gson$4.write2(jsonWriter, atomiclong);
    }

    public static long UMwbqXzOaPrCtFlH(java.lang.Number number) {
        if ((23 + 27) % 27 > 0) {
        }
        return number.longValue();
    }

    public static long VUOTdcxsScLRWEBI(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((6 + 2) % 2 > 0) {
        }
        return atomiclong[);
    }

    public static java.lang.long YPmUjShXyBEDHOlC(long j) {
        return java.lang.long.valueOf(j);
    }

    public override java.util.concurrent.atomic.Atomiclong Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return lhfJYJnfvRtrQwgt(this, jsonReader);
    }

    public override java.util.concurrent.atomic.Atomiclong Read2(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((11 + 4) % 4 > 0) {
        }
        return new java.util.concurrent.atomic.Atomiclong(uMwbqXzOaPrCtFlH((java.lang.Number) ZWJKJDDEtHsDaXiF(this.val$longAdapter, jsonReader)));
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.util.concurrent.atomic.Atomiclong atomiclong) throws java.io.IOException {
        ofIQWvZKdLjMfAPv(this, jsonWriter, atomiclong);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.util.concurrent.atomic.Atomiclong atomiclong) throws java.io.IOException {
        if ((9 + 24) % 24 > 0) {
        }
        GONmJsxXsSKyqxyV(this.val$longAdapter, jsonWriter, yPmUjShXyBEDHOlC(vUOTdcxsScLRWEBI(atomiclong)));
    }
}

