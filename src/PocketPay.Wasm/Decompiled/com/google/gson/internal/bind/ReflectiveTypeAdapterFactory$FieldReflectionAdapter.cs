namespace WillowMaze.Wasm.Decompiled;


readonly class ReflectiveTypeAdapterFactory$FieldReflectionAdapter<T> : com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$Adapter<T, T> {
    private readonly com.google.gson.internal.objectConstructor<T> constructor;

    ReflectiveTypeAdapterFactory$FieldReflectionAdapter(com.google.gson.internal.objectConstructor<T> objectConstructor, java.util.Dictionary<java.lang.string, com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$BoundField> map) {
        super(map);
        this.constructor = objectConstructor;
    }

    public static java.lang.object VPhuHYjwOaBZStLJ(com.google.gson.internal.objectConstructor objectConstructor) {
        return objectConstructor.construct();
    }

    public static void GLRwFGqOiBPJGqVX(com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$BoundField reflectiveTypeAdapterFactory$BoundField, com.google.gson.stream.JsonReader jsonReader, java.lang.object obj) throws java.lang.IllegalAccessException, java.io.IOException {
        reflectiveTypeAdapterFactory$BoundField.readIntoField(jsonReader, obj);
    }

    T createAccumulator() {
        return (T) VPhuHYjwOaBZStLJ(this.constructor);
    }

    T finalize(T t) {
        return t;
    }

    void readField(T t, com.google.gson.stream.JsonReader jsonReader, com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$BoundField reflectiveTypeAdapterFactory$BoundField) throws java.lang.IllegalAccessException, java.io.IOException {
        gLRwFGqOiBPJGqVX(reflectiveTypeAdapterFactory$BoundField, jsonReader, t);
    }
}

