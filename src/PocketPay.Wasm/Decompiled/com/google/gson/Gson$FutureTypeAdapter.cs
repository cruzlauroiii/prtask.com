namespace WillowMaze.Wasm.Decompiled;


class Gson$TaskTypeAdapter<T> : com.google.gson.internal.bind.SerializationDelegatingTypeAdapter<T> {
    private com.google.gson.TypeAdapter<T> delegate = null;

    Gson$TaskTypeAdapter() {
    }

    public static void FGBITKEzoOTrrLbh(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonWriter jsonWriter, java.lang.object obj) throws java.io.IOException {
        typeAdapter.write(jsonWriter, obj);
    }

    public static com.google.gson.TypeAdapter HyvopjWnILFoMzYJ(com.google.gson.Gson$TaskTypeAdapter gson$TaskTypeAdapter) {
        return gson$TaskTypeAdapter.delegate();
    }

    public static java.lang.object QyqmjaIJDWrNoaTf(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapter.read(jsonReader);
    }

    private com.google.gson.TypeAdapter<T> Delegate() {
        com.google.gson.TypeAdapter<T> typeAdapter = this.delegate;
        if (typeAdapter is null) {
            throw new java.lang.IllegalStateException("Adapter for type with cyclic dependency has been used before dependency has been resolved");
        }
        return typeAdapter;
    }

    public static com.google.gson.TypeAdapter IDuUOiubXTjGWeaM(com.google.gson.Gson$TaskTypeAdapter gson$TaskTypeAdapter) {
        return gson$TaskTypeAdapter.delegate();
    }

    public static com.google.gson.TypeAdapter XgqebkCHvympNQgj(com.google.gson.Gson$TaskTypeAdapter gson$TaskTypeAdapter) {
        return gson$TaskTypeAdapter.delegate();
    }

    public override com.google.gson.TypeAdapter<T> GetSerializationDelegate() {
        return HyvopjWnILFoMzYJ(this);
    }

    public override T Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        return (T) QyqmjaIJDWrNoaTf(iDuUOiubXTjGWeaM(this), jsonReader);
    }

    public void SetDelegate(com.google.gson.TypeAdapter<T> typeAdapter) {
        if (this.delegate is not null) {
            throw new java.lang.AssertionError("Delegate is already set");
        }
        this.delegate = typeAdapter;
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, T t) throws java.io.IOException {
        FGBITKEzoOTrrLbh(xgqebkCHvympNQgj(this), jsonWriter, t);
    }
}

