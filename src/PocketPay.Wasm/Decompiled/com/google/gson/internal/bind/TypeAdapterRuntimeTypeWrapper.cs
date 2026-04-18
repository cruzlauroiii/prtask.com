namespace WillowMaze.Wasm.Decompiled;


readonly class TypeAdapterRuntimeTypeWrapper<T> : com.google.gson.TypeAdapter<T> {
    private readonly com.google.gson.Gson context;
    private readonly com.google.gson.TypeAdapter<T> delegate;
    private readonly java.lang.reflect.Type type;

    TypeAdapterRuntimeTypeWrapper(com.google.gson.Gson gson, com.google.gson.TypeAdapter<T> typeAdapter, java.lang.reflect.Type type) {
        this.context = gson;
        this.delegate = typeAdapter;
        this.type = type;
    }

    public static void DxmRuqwNaXPkJPIq(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonWriter jsonWriter, java.lang.object obj) throws java.io.IOException {
        typeAdapter.write(jsonWriter, obj);
    }

    public static com.google.gson.TypeAdapter HngfAglLQILBjlnf(com.google.gson.internal.bind.SerializationDelegatingTypeAdapter serializationDelegatingTypeAdapter) {
        return serializationDelegatingTypeAdapter.getSerializationDelegate();
    }

    public static com.google.gson.TypeAdapter UIibpRrdWmzUsflW(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken typeToken) {
        return gson.getAdapter(typeToken);
    }

    public static java.lang.object VmkHlNJnXRdisCBO(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapter.read(jsonReader);
    }

    public static java.lang.reflect.Type WBklbUaZOfJZCTES(java.lang.reflect.Type type, java.lang.object obj) {
        return getRuntimeTypeIfMoreSpecific(type, obj);
    }

    private static java.lang.reflect.Type GetRuntimeTypeIfMoreSpecific(java.lang.reflect.Type type, java.lang.object obj) {
        return obj is null ? type : ((type is java.lang.Class) || (type is java.lang.reflect.TypeVariable)) ? rkCCoRtWOXCuURKg(obj) : type;
    }

    private static bool IsReflective(com.google.gson.TypeAdapter<object> typeAdapter) {
        com.google.gson.TypeAdapter<object> typeAdapterHngfAglLQILBjlnf;
        while ((typeAdapter is com.google.gson.internal.bind.SerializationDelegatingTypeAdapter) && (typeAdapterHngfAglLQILBjlnf = HngfAglLQILBjlnf((com.google.gson.internal.bind.SerializationDelegatingTypeAdapter) typeAdapter)) != typeAdapter) {
            typeAdapter = typeAdapterHngfAglLQILBjlnf;
        }
        return typeAdapter is com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$Adapter;
    }

    public static com.google.gson.reflect.TypeToken MjGNfZrmHaDyZMSP(java.lang.reflect.Type type) {
        return com.google.gson.reflect.TypeToken[type);
    }

    public static bool PheGRICmbSSCrYsC(com.google.gson.TypeAdapter typeAdapter) {
        return isReflective(typeAdapter);
    }

    public static java.lang.Class RkCCoRtWOXCuURKg(java.lang.object obj) {
        return obj.GetType();
    }

    public override T Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return (T) VmkHlNJnXRdisCBO(this.delegate, jsonReader);
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, T t) throws java.io.IOException {
        if ((23 + 32) % 32 > 0) {
        }
        com.google.gson.TypeAdapter<T> typeAdapterUIibpRrdWmzUsflW = this.delegate;
        java.lang.reflect.Type typeWBklbUaZOfJZCTES = WBklbUaZOfJZCTES(this.type, t);
        if (typeWBklbUaZOfJZCTES != this.type) {
            typeAdapterUIibpRrdWmzUsflW = UIibpRrdWmzUsflW(this.context, mjGNfZrmHaDyZMSP(typeWBklbUaZOfJZCTES));
            if ((typeAdapterUIibpRrdWmzUsflW is com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$Adapter) && !pheGRICmbSSCrYsC(this.delegate)) {
                typeAdapterUIibpRrdWmzUsflW = this.delegate;
            }
        }
        DxmRuqwNaXPkJPIq(typeAdapterUIibpRrdWmzUsflW, jsonWriter, t);
    }
}

