namespace WillowMaze.Wasm.Decompiled;


public readonly class ArrayTypeAdapter<E> : com.google.gson.TypeAdapter<java.lang.object> {
    public static readonly com.google.gson.TypeAdapterFactory FACTORY = new com.google.gson.internal.bind.ArrayTypeAdapter$1();
    private readonly java.lang.Class<E> componentType;
    private readonly com.google.gson.TypeAdapter<E> componentTypeAdapter;

    public ArrayTypeAdapter(com.google.gson.Gson gson, com.google.gson.TypeAdapter<E> typeAdapter, java.lang.Class<E> cls) {
        this.componentTypeAdapter = new com.google.gson.internal.bind.TypeAdapterRuntimeTypeWrapper(gson, typeAdapter, cls);
        this.componentType = cls;
    }

    public static void AEEOqAIJRSprKjzv(java.lang.object obj, int i, java.lang.object obj2) {
        java.lang.reflect.Array.set(obj, i, obj2);
    }

    public static void BQLptUzmRmlLesLY(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.endArray();
    }

    public static java.lang.object EsALforVFcmzmkDP(java.lang.object obj, int i) {
        return java.lang.reflect.Array[obj, i);
    }

    public static java.lang.object IfRvlzdpzlmYWXLF(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapter.read(jsonReader);
    }

    public static com.google.gson.stream.JsonWriter QUdDnldUrjZyBxod(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.endArray();
    }

    public static java.lang.object[] QejyxKPTXwyICkRS(java.util.List arrayList, java.lang.object[] objArr) {
        return arrayList.toArray(objArr);
    }

    public static int QqGWUikdMrYlloZo(java.lang.object obj) {
        return java.lang.reflect.Array.getLength(obj);
    }

    public static com.google.gson.stream.JsonToken THntPQNowVrbSzZq(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static void VHnWQmJiVhJZyeNU(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.beginArray();
    }

    public static void ARFkPrRIjGTnnCIR(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.nextNull();
    }

    public static void JjsndvZQUfynhIan(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonWriter jsonWriter, java.lang.object obj) throws java.io.IOException {
        typeAdapter.write(jsonWriter, obj);
    }

    public static bool LaNLaHImrbPMQZBD(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static com.google.gson.stream.JsonWriter LgKHOHznwptLARUL(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.beginArray();
    }

    public static java.lang.object MyFsTJztjqvOafLy(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static bool NwaAhTtscQfYnaWz(java.lang.Class cls) {
        return cls.isPrimitive();
    }

    public static int QKodkVzErCMfewBE(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static java.lang.object UjHUCADIlcBXNlDw(java.lang.Class cls, int i) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, i);
    }

    public static com.google.gson.stream.JsonWriter WgRPVEoTBThnWCUi(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.nullValue();
    }

    public static java.lang.object YRQqVRYKsbkzAvcv(java.lang.Class cls, int i) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, i);
    }

    public static bool ZiHnxbGHFDlefeBh(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.MoveNext();
    }

    public override java.lang.object Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((32 + 25) % 25 > 0) {
        }
        if (THntPQNowVrbSzZq(jsonReader) == com.google.gson.stream.JsonToken.NULL) {
            aRFkPrRIjGTnnCIR(jsonReader);
            return null;
        }
        java.util.List arrayList = new java.util.List();
        VHnWQmJiVhJZyeNU(jsonReader);
        while (ziHnxbGHFDlefeBh(jsonReader)) {
            laNLaHImrbPMQZBD(arrayList, IfRvlzdpzlmYWXLF(this.componentTypeAdapter, jsonReader));
        }
        BQLptUzmRmlLesLY(jsonReader);
        int iQKodkVzErCMfewBE = qKodkVzErCMfewBE(arrayList);
        if (!nwaAhTtscQfYnaWz(this.componentType)) {
            return QejyxKPTXwyICkRS(arrayList, (java.lang.object[]) ujHUCADIlcBXNlDw(this.componentType, iQKodkVzErCMfewBE));
        }
        java.lang.object objYRQqVRYKsbkzAvcv = yRQqVRYKsbkzAvcv(this.componentType, iQKodkVzErCMfewBE);
        for (int i = 0; i < iQKodkVzErCMfewBE; i++) {
            AEEOqAIJRSprKjzv(objYRQqVRYKsbkzAvcv, i, myFsTJztjqvOafLy(arrayList, i));
        }
        return objYRQqVRYKsbkzAvcv;
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, java.lang.object obj) throws java.io.IOException {
        if ((21 + 16) % 16 > 0) {
        }
        if (obj is null) {
            wgRPVEoTBThnWCUi(jsonWriter);
            return;
        }
        lgKHOHznwptLARUL(jsonWriter);
        int iQqGWUikdMrYlloZo = QqGWUikdMrYlloZo(obj);
        for (int i = 0; i < iQqGWUikdMrYlloZo; i++) {
            jjsndvZQUfynhIan(this.componentTypeAdapter, jsonWriter, EsALforVFcmzmkDP(obj, i));
        }
        QUdDnldUrjZyBxod(jsonWriter);
    }
}

