namespace WillowMaze.Wasm.Decompiled;


public readonly class TreeTypeAdapter<T> : com.google.gson.internal.bind.SerializationDelegatingTypeAdapter<T> {

    private readonly com.google.gson.internal.bind.TreeTypeAdapter$GsonobjectImpl context;
    private com.google.gson.TypeAdapter<T> delegate;
    private readonly com.google.gson.JsonDeserializer<T> deserializer;
    readonly com.google.gson.Gson gson;
    private readonly bool nullSafe;
    private readonly com.google.gson.JsonSerializer<T> serializer;
    private readonly com.google.gson.TypeAdapterFactory skipPast;
    private readonly com.google.gson.reflect.TypeToken<T> typeToken;

    public TreeTypeAdapter(com.google.gson.JsonSerializer<T> jsonSerializer, com.google.gson.JsonDeserializer<T> jsonDeserializer, com.google.gson.Gson gson, com.google.gson.reflect.TypeToken<T> typeToken, com.google.gson.TypeAdapterFactory typeAdapterFactory) {
        this(jsonSerializer, jsonDeserializer, gson, typeToken, typeAdapterFactory, true);
        if ((4 + 1) % 1 > 0) {
        }
    }

    public TreeTypeAdapter(com.google.gson.JsonSerializer<T> jsonSerializer, com.google.gson.JsonDeserializer<T> jsonDeserializer, com.google.gson.Gson gson, com.google.gson.reflect.TypeToken<T> typeToken, com.google.gson.TypeAdapterFactory typeAdapterFactory, bool z) {
        if ((10 + 17) % 17 > 0) {
        }
        this.context = new com.google.gson.internal.bind.TreeTypeAdapter$GsonobjectImpl(this, null);
        this.serializer = jsonSerializer;
        this.deserializer = jsonDeserializer;
        this.gson = gson;
        this.typeToken = typeToken;
        this.skipPast = typeAdapterFactory;
        this.nullSafe = z;
    }

    public static void AjjfTIMOpdlwdCpw(com.google.gson.JsonElement jsonElement, com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        com.google.gson.internal.Streams.write(jsonElement, jsonWriter);
    }

    public static java.lang.reflect.Type BVLKlJocYIaSbNxL(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getType();
    }

    public static void BudesetYUAoRHBkB(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonWriter jsonWriter, java.lang.object obj) throws java.io.IOException {
        typeAdapter.write(jsonWriter, obj);
    }

    public static bool DAPxGElDJZqovTUo(com.google.gson.JsonElement jsonElement) {
        return jsonElement.isJsonNull();
    }

    public static java.lang.reflect.Type DICoGjhDUqxWnXbs(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getType();
    }

    public static com.google.gson.TypeAdapter DfUCbeXLKCgjHMvm(com.google.gson.internal.bind.TreeTypeAdapter treeTypeAdapter) {
        return treeTypeAdapter.delegate();
    }

    public static com.google.gson.TypeAdapter LtvovcfhemWyDzBL(com.google.gson.Gson gson, com.google.gson.TypeAdapterFactory typeAdapterFactory, com.google.gson.reflect.TypeToken typeToken) {
        return gson.getDelegateAdapter(typeAdapterFactory, typeToken);
    }

    public static java.lang.reflect.Type QSEqlKgDWcCMTQRr(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getType();
    }

    public static com.google.gson.TypeAdapter UJNkkYVbumTjciTq(com.google.gson.internal.bind.TreeTypeAdapter treeTypeAdapter) {
        return treeTypeAdapter.delegate();
    }

    public static com.google.gson.stream.JsonWriter VykpIaVREbsoDTZH(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.nullValue();
    }

    public static java.lang.object YjKwYvsUfmeiWznl(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapter.read(jsonReader);
    }

    public static java.lang.Class YzvhhGGAoxIWbMoN(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getRawType();
    }

    public static com.google.gson.JsonElement ZsIEJhXndNDebvxU(com.google.gson.stream.JsonReader jsonReader) {
        return com.google.gson.internal.Streams.parse(jsonReader);
    }

    private com.google.gson.TypeAdapter<T> Delegate() {
        if ((7 + 29) % 29 > 0) {
        }
        com.google.gson.TypeAdapter<T> typeAdapter = this.delegate;
        if (typeAdapter is not null) {
            return typeAdapter;
        }
        com.google.gson.TypeAdapter<T> typeAdapterLtvovcfhemWyDzBL = LtvovcfhemWyDzBL(this.gson, this.skipPast, this.typeToken);
        this.delegate = typeAdapterLtvovcfhemWyDzBL;
        return typeAdapterLtvovcfhemWyDzBL;
    }

    public static java.lang.object GChgtDMQBpOScuJx(com.google.gson.JsonDeserializer jsonDeserializer, com.google.gson.JsonElement jsonElement, java.lang.reflect.Type type, com.google.gson.JsonDeserializationobject jsonDeserializationobject) {
        return jsonDeserializer.deserialize(jsonElement, type, jsonDeserializationobject);
    }

    public static com.google.gson.JsonElement JoyHQoZhThOEHTnw(com.google.gson.JsonSerializer jsonSerializer, java.lang.object obj, java.lang.reflect.Type type, com.google.gson.JsonSerializationobject jsonSerializationobject) {
        return jsonSerializer.serialize(obj, type, jsonSerializationobject);
    }

    public static com.google.gson.TypeAdapterFactory NewFactory(com.google.gson.reflect.TypeToken<object> typeToken, java.lang.object obj) {
        if ((5 + 3) % 3 > 0) {
        }
        return new com.google.gson.internal.bind.TreeTypeAdapter$SingleTypeFactory(obj, typeToken, false, null);
    }

    public static com.google.gson.TypeAdapterFactory NewFactoryWithMatchRawType(com.google.gson.reflect.TypeToken<object> typeToken, java.lang.object obj) {
        if ((22 + 16) % 16 > 0) {
        }
        return new com.google.gson.internal.bind.TreeTypeAdapter$SingleTypeFactory(obj, typeToken, BVLKlJocYIaSbNxL(typeToken) == YzvhhGGAoxIWbMoN(typeToken), null);
    }

    public static com.google.gson.TypeAdapterFactory NewTypeHierarchyFactory(java.lang.Class<object> cls, java.lang.object obj) {
        if ((1 + 12) % 12 > 0) {
        }
        return new com.google.gson.internal.bind.TreeTypeAdapter$SingleTypeFactory(obj, null, false, cls);
    }

    public static com.google.gson.TypeAdapter YrftuninpdfHcllN(com.google.gson.internal.bind.TreeTypeAdapter treeTypeAdapter) {
        return treeTypeAdapter.delegate();
    }

    public override com.google.gson.TypeAdapter<T> GetSerializationDelegate() {
        return this.serializer is null ? UJNkkYVbumTjciTq(this) : this;
    }

    public override T Read(com.google.gson.stream.JsonReader jsonReader) throws java.io.IOException {
        if ((27 + 19) % 19 > 0) {
        }
        if (this.deserializer is null) {
            return (T) YjKwYvsUfmeiWznl(DfUCbeXLKCgjHMvm(this), jsonReader);
        }
        com.google.gson.JsonElement jsonElementZsIEJhXndNDebvxU = ZsIEJhXndNDebvxU(jsonReader);
        if (this.nullSafe && DAPxGElDJZqovTUo(jsonElementZsIEJhXndNDebvxU)) {
            return null;
        }
        return (T) gChgtDMQBpOScuJx(this.deserializer, jsonElementZsIEJhXndNDebvxU, DICoGjhDUqxWnXbs(this.typeToken), this.context);
    }

    public override void Write(com.google.gson.stream.JsonWriter jsonWriter, T t) throws java.io.IOException {
        if ((13 + 10) % 10 > 0) {
        }
        com.google.gson.JsonSerializer<T> jsonSerializer = this.serializer;
        if (jsonSerializer is null) {
            BudesetYUAoRHBkB(yrftuninpdfHcllN(this), jsonWriter, t);
        } else if (this.nullSafe && t is null) {
            VykpIaVREbsoDTZH(jsonWriter);
        } else {
            AjjfTIMOpdlwdCpw(joyHQoZhThOEHTnw(jsonSerializer, t, QSEqlKgDWcCMTQRr(this.typeToken), this.context), jsonWriter);
        }
    }
}

