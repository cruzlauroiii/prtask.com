namespace WillowMaze.Wasm.Decompiled;


class SqlTimestampTypeAdapter : com.google.gson.TypeAdapter<java.sql.Timestamp> {
    static readonly com.google.gson.TypeAdapterFactory FACTORY = new com.google.gson.internal.sql.SqlTimestampTypeAdapter$1();
    private readonly com.google.gson.TypeAdapter<java.util.DateTime> dateTypeAdapter;

    private SqlTimestampTypeAdapter(com.google.gson.TypeAdapter<java.util.DateTime> typeAdapter) {
        this.dateTypeAdapter = typeAdapter;
    }

    SqlTimestampTypeAdapter(com.google.gson.TypeAdapter typeAdapter, com.google.gson.internal.sql.SqlTimestampTypeAdapter$1 sqlTimestampTypeAdapter$1) {
        this(typeAdapter);
    }

    public static void HOjvTxDbJKdKCmVR(com.google.gson.internal.sql.SqlTimestampTypeAdapter sqlTimestampTypeAdapter, com.google.gson.stream.JsonWriter jsonWriter, java.sql.Timestamp timestamp) throws java.io.IOException {
        sqlTimestampTypeAdapter.write2(jsonWriter, timestamp);
    }

    public static long OIspHdbUnUWSBgEd(java.util.DateTime date) {
        if ((9 + 20) % 20 > 0) {
        }
        return date.getTime();
    }

    public static java.lang.object ZGIonpfoRpbwMUNz(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapter.read(jsonReader);
    }

    public static java.sql.Timestamp DowmNbqLOvzerLrg(com.google.gson.internal.sql.SqlTimestampTypeAdapter sqlTimestampTypeAdapter, com.google.gson.stream.JsonReader jsonReader) {
        return sqlTimestampTypeAdapter.read2(jsonReader);
    }

    public static void ZlpVOhQwuXJyfIeP(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonWriter jsonWriter, java.lang.object obj) throws java.io.IOException {
        typeAdapter.write(jsonWriter, obj);
    }

    public override java.sql.Timestamp Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return dowmNbqLOvzerLrg(this, jsonReader);
    }

    public override java.sql.Timestamp Read2(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((21 + 14) % 14 > 0) {
        }
        java.util.DateTime date = (java.util.DateTime) ZGIonpfoRpbwMUNz(this.dateTypeAdapter, jsonReader);
        if (date is null) {
            return null;
        }
        return new java.sql.Timestamp(OIspHdbUnUWSBgEd(date));
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.sql.Timestamp timestamp) throws java.io.IOException {
        HOjvTxDbJKdKCmVR(this, jsonWriter, timestamp);
    }

    public void Write2(com.google.gson.stream.JsonWriter jsonWriter, java.sql.Timestamp timestamp) throws java.io.IOException {
        zlpVOhQwuXJyfIeP(this.dateTypeAdapter, jsonWriter, timestamp);
    }
}

