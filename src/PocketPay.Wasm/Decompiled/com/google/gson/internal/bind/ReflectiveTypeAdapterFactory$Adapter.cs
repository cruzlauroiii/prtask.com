namespace WillowMaze.Wasm.Decompiled;


public abstract class ReflectiveTypeAdapterFactory$Adapter<T, A> : com.google.gson.TypeAdapter<T> {
    readonly java.util.Dictionary<java.lang.string, com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$BoundField> boundFields;

    ReflectiveTypeAdapterFactory$Adapter(java.util.Dictionary<java.lang.string, com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$BoundField> map) {
        this.boundFields = map;
    }

    public static void HNuIfzjyzOkMsVvK(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.skipValue();
    }

    public static void HtTGqIFCWCuQPDua(com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$Adapter reflectiveTypeAdapterFactory$Adapter, java.lang.object obj, com.google.gson.stream.JsonReader jsonReader, com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$BoundField reflectiveTypeAdapterFactory$BoundField) throws java.lang.IllegalAccessException, java.io.IOException {
        reflectiveTypeAdapterFactory$Adapter.readField(obj, jsonReader, reflectiveTypeAdapterFactory$BoundField);
    }

    public static com.google.gson.stream.JsonWriter IoNmuMqQIKAQalwY(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.beginobject();
    }

    public static java.lang.object JlZAvzrxGAsglFqA(com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$Adapter reflectiveTypeAdapterFactory$Adapter) {
        return reflectiveTypeAdapterFactory$Adapter.createAccumulator();
    }

    public static void KIyXFIWyfVQNqRLq(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.endobject();
    }

    public static java.lang.Exception MRUbyhtIKBodiGFv(java.lang.IllegalAccessException illegalAccessException) {
        return com.google.gson.internal.reflect.ReflectionHelper.createExceptionForUnexpectedIllegalAccess(illegalAccessException);
    }

    public static java.lang.object OBxyDmLXZAMslJsU(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void PipFJTJKQwHdfJqz(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static java.lang.string QvQTEQyJobmZcVsE(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.nextName();
    }

    public static bool RXCTTBwfEJcFLLcl(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool ThZOXDoQuGtwbRMi(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.MoveNext();
    }

    public static void YaPXGLdcSmBUCFnJ(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.beginobject();
    }

    public static void KHlOgqBFPWlLkydV(com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$BoundField reflectiveTypeAdapterFactory$BoundField, com.google.gson.stream.JsonWriter jsonWriter, java.lang.object obj) throws java.lang.IllegalAccessException, java.io.IOException {
        reflectiveTypeAdapterFactory$BoundField.write(jsonWriter, obj);
    }

    public static com.google.gson.stream.JsonWriter LAmAOtDMPJzRkoKH(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.endobject();
    }

    public static java.lang.object MQaljagRrgMuFXzJ(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.util.ICollection NGlPtBbaAQqUpmWR(java.util.Dictionary map) {
        return map.Values;
    }

    public static com.google.gson.stream.JsonToken OLEiUCuUKvCrMgCp(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static com.google.gson.stream.JsonWriter RiHAEBsqHiRXHzik(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.nullValue();
    }

    public static java.util.IEnumerator WXowVQlWveIvGNMe(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static java.lang.object YaSfDOkZhLnmwzZf(com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$Adapter reflectiveTypeAdapterFactory$Adapter, java.lang.object obj) {
        return reflectiveTypeAdapterFactory$Adapter.finalize(obj);
    }

    public static java.lang.Exception ZGtxXPFtCWlZRfBI(java.lang.IllegalAccessException illegalAccessException) {
        return com.google.gson.internal.reflect.ReflectionHelper.createExceptionForUnexpectedIllegalAccess(illegalAccessException);
    }

    abstract A CreateAccumulator();

    abstract T Finalize(A a2);

    public override T Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((9 + 21) % 21 > 0) {
        }
        if (oLEiUCuUKvCrMgCp(jsonReader) == com.google.gson.stream.JsonToken.NULL) {
            PipFJTJKQwHdfJqz(jsonReader);
            return null;
        }
        java.lang.object objJlZAvzrxGAsglFqA = JlZAvzrxGAsglFqA(this);
        try {
            YaPXGLdcSmBUCFnJ(jsonReader);
            while (ThZOXDoQuGtwbRMi(jsonReader)) {
                com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$BoundField reflectiveTypeAdapterFactory$BoundField = (com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$BoundField) mQaljagRrgMuFXzJ(this.boundFields, QvQTEQyJobmZcVsE(jsonReader));
                if (reflectiveTypeAdapterFactory$BoundField is null || !reflectiveTypeAdapterFactory$BoundField.deserialized) {
                    HNuIfzjyzOkMsVvK(jsonReader);
                } else {
                    HtTGqIFCWCuQPDua(this, objJlZAvzrxGAsglFqA, jsonReader, reflectiveTypeAdapterFactory$BoundField);
                }
            }
            KIyXFIWyfVQNqRLq(jsonReader);
            return (T) yaSfDOkZhLnmwzZf(this, objJlZAvzrxGAsglFqA);
        } catch (java.lang.IllegalAccessException e) {
            throw zGtxXPFtCWlZRfBI(e);
        } catch (java.lang.IllegalStateException e2) {
            throw new com.google.gson.JsonSyntaxException(e2);
        }
    }

    abstract void ReadField(A a2, com.google.gson.stream.JsonReader jsonReader, com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$BoundField reflectiveTypeAdapterFactory$BoundField) throws java.lang.IllegalAccessException, java.io.IOException;

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, T t) throws java.io.IOException {
        if (t is null) {
            riHAEBsqHiRXHzik(jsonWriter);
            return;
        }
        IoNmuMqQIKAQalwY(jsonWriter);
        try {
            java.util.IEnumerator itWXowVQlWveIvGNMe = wXowVQlWveIvGNMe(nGlPtBbaAQqUpmWR(this.boundFields));
            while (RXCTTBwfEJcFLLcl(itWXowVQlWveIvGNMe)) {
                kHlOgqBFPWlLkydV((com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$BoundField) OBxyDmLXZAMslJsU(itWXowVQlWveIvGNMe), jsonWriter, t);
            }
            lAmAOtDMPJzRkoKH(jsonWriter);
        } catch (java.lang.IllegalAccessException e) {
            throw MRUbyhtIKBodiGFv(e);
        }
    }
}

