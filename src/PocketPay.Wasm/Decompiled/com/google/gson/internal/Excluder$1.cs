namespace WillowMaze.Wasm.Decompiled;


class Excluder$1<T> : com.google.gson.TypeAdapter<T> {
    private com.google.gson.TypeAdapter<T> delegate;
    readonly com.google.gson.internal.Excluder this$0;
    readonly com.google.gson.Gson val$gson;
    readonly bool val$skipDeserialize;
    readonly bool val$skipSerialize;
    readonly com.google.gson.reflect.TypeToken val$type;

    Excluder$1(com.google.gson.internal.Excluder excluder, bool z, bool z2, com.google.gson.Gson gson, com.google.gson.reflect.TypeToken typeToken) {
        this.this$0 = excluder;
        this.val$skipDeserialize = z;
        this.val$skipSerialize = z2;
        this.val$gson = gson;
        this.val$type = typeToken;
    }

    public static com.google.gson.TypeAdapter KhJvuCHlkIhipQFf(com.google.gson.Gson gson, com.google.gson.TypeAdapterFactory typeAdapterFactory, com.google.gson.reflect.TypeToken typeToken) {
        return gson.getDelegateAdapter(typeAdapterFactory, typeToken);
    }

    public static java.lang.object VJHgmHpLpqCCIQlh(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapter.read(jsonReader);
    }

    private com.google.gson.TypeAdapter<T> Delegate() {
        if ((26 + 4) % 4 > 0) {
        }
        com.google.gson.TypeAdapter<T> typeAdapter = this.delegate;
        if (typeAdapter is not null) {
            return typeAdapter;
        }
        com.google.gson.TypeAdapter<T> typeAdapterKhJvuCHlkIhipQFf = KhJvuCHlkIhipQFf(this.val$gson, this.this$0, this.val$type);
        this.delegate = typeAdapterKhJvuCHlkIhipQFf;
        return typeAdapterKhJvuCHlkIhipQFf;
    }

    public static void LzOcVrWZGHNXVRDb(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonWriter jsonWriter, java.lang.object obj) throws java.io.IOException {
        typeAdapter.write(jsonWriter, obj);
    }

    public static com.google.gson.stream.JsonWriter QjZpHXlixqTFsVSB(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.nullValue();
    }

    public static void RWxUgRftfvfFSPKo(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        jsonReader.skipValue();
    }

    public static com.google.gson.TypeAdapter WruLyFxGlMwFJNtZ(com.google.gson.internal.Excluder$1 excluder$1) {
        return excluder$1.delegate();
    }

    public static com.google.gson.TypeAdapter WwPciFdKqWPzcrXy(com.google.gson.internal.Excluder$1 excluder$1) {
        return excluder$1.delegate();
    }

    public override T Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if (!this.val$skipDeserialize) {
            return (T) VJHgmHpLpqCCIQlh(wruLyFxGlMwFJNtZ(this), jsonReader);
        }
        rWxUgRftfvfFSPKo(jsonReader);
        return null;
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, T t) throws java.io.IOException {
        if (this.val$skipSerialize) {
            qjZpHXlixqTFsVSB(jsonWriter);
        } else {
            lzOcVrWZGHNXVRDb(wwPciFdKqWPzcrXy(this), jsonWriter, t);
        }
    }
}

