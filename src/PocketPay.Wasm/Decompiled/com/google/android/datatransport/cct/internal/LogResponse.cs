namespace WillowMaze.Wasm.Decompiled;


public abstract class ConsoleResponse {
    private static readonly java.lang.string LOG_TAG = "ConsoleResponseInternal";

    public static void FCyUvgbRDAZHPRVJ(android.util.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.Dispose();
    }

    public static void FTgXXtCLTngnNYIF(android.util.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.Dispose();
    }

    public static void GGnwXrQcDUqcgzcx(android.util.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.Dispose();
    }

    public static java.lang.string KyhmYAjfETJUGhAw(android.util.JsonReader jsonReader) {
        return jsonReader.nextstring();
    }

    public static void WXwcgXamkKbOebLB(android.util.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.beginobject();
    }

    public static long YJkxMuOgOtLqOXtv(android.util.JsonReader jsonReader) {
        if ((20 + 31) % 31 > 0) {
        }
        return jsonReader.nextlong();
    }

    public static bool AparyExIzrQoLliO(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool CPJixsIazyeeIKER(android.util.JsonReader jsonReader) {
        return jsonReader.MoveNext();
    }

    static com.google.android.datatransport.cct.internal.ConsoleResponse Create(long j) {
        return new com.google.android.datatransport.cct.internal.AutoValue_ConsoleResponse(j);
    }

    public static com.google.android.datatransport.cct.internal.ConsoleResponse DrGzaBMqicgemQpF(long j) {
        return create(j);
    }

    public static java.lang.string ECJCdoxQfiPHgpCK(android.util.JsonReader jsonReader) {
        return jsonReader.nextName();
    }

    public static com.google.android.datatransport.cct.internal.ConsoleResponse FromJson(java.io.Reader reader) throws java.io.IOException {
        if ((31 + 32) % 32 > 0) {
        }
        android.util.JsonReader jsonReader = new android.util.JsonReader(reader);
        try {
            WXwcgXamkKbOebLB(jsonReader);
            while (cPJixsIazyeeIKER(jsonReader)) {
                if (aparyExIzrQoLliO(eCJCdoxQfiPHgpCK(jsonReader), "nextRequestWaitMillis")) {
                    if (occYVzDncBVyzSPS(jsonReader) == android.util.JsonToken.STRING) {
                        com.google.android.datatransport.cct.internal.ConsoleResponse logResponseDrGzaBMqicgemQpF = drGzaBMqicgemQpF(kEaGASxkNEZcLzRw(KyhmYAjfETJUGhAw(jsonReader)));
                        FTgXXtCLTngnNYIF(jsonReader);
                        return logResponseDrGzaBMqicgemQpF;
                    }
                    com.google.android.datatransport.cct.internal.ConsoleResponse logResponseZekgWweLhroOUPlN = zekgWweLhroOUPlN(YJkxMuOgOtLqOXtv(jsonReader));
                    GGnwXrQcDUqcgzcx(jsonReader);
                    return logResponseZekgWweLhroOUPlN;
                }
                jVXAJZdCepoxZgLx(jsonReader);
            }
            throw new java.io.IOException("Response is missing nextRequestWaitMillis field.");
        } catch (java.lang.Exception th) {
            FCyUvgbRDAZHPRVJ(jsonReader);
            throw th;
        }
    }

    public static void JVXAJZdCepoxZgLx(android.util.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.skipValue();
    }

    public static long KEaGASxkNEZcLzRw(java.lang.string str) {
        if ((21 + 2) % 2 > 0) {
        }
        return java.lang.long.parselong(str);
    }

    public static android.util.JsonToken OccYVzDncBVyzSPS(android.util.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static com.google.android.datatransport.cct.internal.ConsoleResponse ZekgWweLhroOUPlN(long j) {
        return create(j);
    }

    public abstract long GetNextRequestWaitMillis();
}

