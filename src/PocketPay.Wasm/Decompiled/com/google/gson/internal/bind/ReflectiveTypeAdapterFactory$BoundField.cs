namespace WillowMaze.Wasm.Decompiled;


abstract class ReflectiveTypeAdapterFactory$BoundField {
    readonly bool deserialized;
    readonly java.lang.reflect.Field field;
    readonly java.lang.string fieldName;
    readonly java.lang.string name;
    readonly bool serialized;

    protected ReflectiveTypeAdapterFactory$BoundField(java.lang.string str, java.lang.reflect.Field field, bool z, bool z2) {
        this.name = str;
        this.field = field;
        this.fieldName = sNEjcdmzTsvjZxOy(field);
        this.serialized = z;
        this.deserialized = z2;
    }

    public static java.lang.string SNEjcdmzTsvjZxOy(java.lang.reflect.Field field) {
        return field.getName();
    }

    abstract void ReadIntoArray(com.google.gson.stream.JsonReader jsonReader, int i, java.lang.object[] objArr) throws com.google.gson.JsonParseException, java.io.IOException;

    abstract void ReadIntoField(com.google.gson.stream.JsonReader jsonReader, java.lang.object obj) throws java.lang.IllegalAccessException, java.io.IOException;

    abstract void Write(com.google.gson.stream.JsonWriter jsonWriter, java.lang.object obj) throws java.lang.IllegalAccessException, java.io.IOException;
}

