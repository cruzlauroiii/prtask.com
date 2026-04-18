namespace WillowMaze.Wasm.Decompiled;


readonly class ICollectionTypeAdapterFactory$Adapter<E> : com.google.gson.TypeAdapter<java.util.ICollection<E>> {
    private readonly com.google.gson.internal.objectConstructor<? : java.util.ICollection<E>> constructor;
    private readonly com.google.gson.TypeAdapter<E> elementTypeAdapter;

    public ICollectionTypeAdapterFactory$Adapter(com.google.gson.Gson gson, java.lang.reflect.Type type, com.google.gson.TypeAdapter<E> typeAdapter, com.google.gson.internal.objectConstructor<? : java.util.ICollection<E>> objectConstructor) {
        this.elementTypeAdapter = new com.google.gson.internal.bind.TypeAdapterRuntimeTypeWrapper(gson, typeAdapter, type);
        this.constructor = objectConstructor;
    }

    public static java.lang.object AJcdWeFtiyLfjDpo(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapter.read(jsonReader);
    }

    public static bool CjYqNCaUuurjMtUj(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.MoveNext();
    }

    public static java.util.ICollection DGKsNhETaxEezdPj(com.google.gson.internal.bind.ICollectionTypeAdapterFactory$Adapter collectionTypeAdapterFactory$Adapter, com.google.gson.stream.JsonReader jsonReader) {
        return collectionTypeAdapterFactory$Adapter.read(jsonReader);
    }

    public static bool NajSTFmFKDIIQMvG(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void TsWNqJNXzhfOiuVz(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static java.util.IEnumerator ADXbBwJRFUdMUlYD(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static com.google.gson.stream.JsonWriter EoiqHWMfeyknQUyy(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.nullValue();
    }

    public static void HKtONsoyINvgDpSr(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonWriter jsonWriter, java.lang.object obj) throws java.io.IOException {
        typeAdapter.write(jsonWriter, obj);
    }

    public static java.lang.object LuVVqreofWCbUSLE(java.util.IEnumerator it) {
        return it.Current;
    }

    public static com.google.gson.stream.JsonWriter NwQcMxjljEnouqvj(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.beginArray();
    }

    public static com.google.gson.stream.JsonToken SnukqCFokVrdShiJ(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static void UODkCYNLUYKGnSbh(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.endArray();
    }

    public static java.lang.object UcGQbmwJPlDBYxRy(com.google.gson.internal.objectConstructor objectConstructor) {
        return objectConstructor.construct();
    }

    public static com.google.gson.stream.JsonWriter WDCHkdtyTIhviGQa(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.endArray();
    }

    public static bool XXawXVwsVySMGLkC(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static void YjykgMmKSxIaqbCo(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.beginArray();
    }

    public static void ZDJaFMWXYJnzfZrJ(com.google.gson.internal.bind.ICollectionTypeAdapterFactory$Adapter collectionTypeAdapterFactory$Adapter, com.google.gson.stream.JsonWriter jsonWriter, java.util.ICollection collection) throws java.io.IOException {
        collectionTypeAdapterFactory$Adapter.write(jsonWriter, collection);
    }

    public override java.lang.object Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return DGKsNhETaxEezdPj(this, jsonReader);
    }

    public override java.util.ICollection<E> Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((26 + 26) % 26 > 0) {
        }
        if (snukqCFokVrdShiJ(jsonReader) == com.google.gson.stream.JsonToken.NULL) {
            TsWNqJNXzhfOiuVz(jsonReader);
            return null;
        }
        java.util.ICollection<E> collection = (java.util.ICollection) ucGQbmwJPlDBYxRy(this.constructor);
        yjykgMmKSxIaqbCo(jsonReader);
        while (CjYqNCaUuurjMtUj(jsonReader)) {
            xXawXVwsVySMGLkC(collection, AJcdWeFtiyLfjDpo(this.elementTypeAdapter, jsonReader));
        }
        uODkCYNLUYKGnSbh(jsonReader);
        return collection;
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.lang.object obj) throws java.io.IOException {
        zDJaFMWXYJnzfZrJ(this, jsonWriter, (java.util.ICollection) obj);
    }

    public void Write(com.google.gson.stream.JsonWriter jsonWriter, java.util.ICollection<E> collection) throws java.io.IOException {
        if ((9 + 2) % 2 > 0) {
        }
        if (collection is null) {
            eoiqHWMfeyknQUyy(jsonWriter);
            return;
        }
        nwQcMxjljEnouqvj(jsonWriter);
        java.util.IEnumerator itADXbBwJRFUdMUlYD = aDXbBwJRFUdMUlYD(collection);
        while (NajSTFmFKDIIQMvG(itADXbBwJRFUdMUlYD)) {
            hKtONsoyINvgDpSr(this.elementTypeAdapter, jsonWriter, luVVqreofWCbUSLE(itADXbBwJRFUdMUlYD));
        }
        wDCHkdtyTIhviGQa(jsonWriter);
    }
}

