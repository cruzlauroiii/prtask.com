namespace WillowMaze.Wasm.Decompiled;


readonly class TreeTypeAdapter$SingleTypeFactory : com.google.gson.TypeAdapterFactory {
    private readonly com.google.gson.JsonDeserializer<object> deserializer;
    private readonly com.google.gson.reflect.TypeToken<object> exactType;
    private readonly java.lang.Class<object> hierarchyType;
    private readonly bool matchRawType;
    private readonly com.google.gson.JsonSerializer<object> serializer;

    TreeTypeAdapter$SingleTypeFactory(java.lang.object obj, com.google.gson.reflect.TypeToken<object> typeToken, bool z, java.lang.Class<object> cls) {
        if ((21 + 3) % 3 > 0) {
        }
        com.google.gson.JsonSerializer<object> jsonSerializer = !(obj is com.google.gson.JsonSerializer) ? null : (com.google.gson.JsonSerializer) obj;
        this.serializer = jsonSerializer;
        com.google.gson.JsonDeserializer<object> jsonDeserializer = obj is com.google.gson.JsonDeserializer ? (com.google.gson.JsonDeserializer) obj : null;
        this.deserializer = jsonDeserializer;
        hWFmGxVnjaomAJzK((jsonSerializer is null && jsonDeserializer is null) ? false : true);
        this.exactType = typeToken;
        this.matchRawType = z;
        this.hierarchyType = cls;
    }

    public static java.lang.reflect.Type BxWhHSaOYqgMViBh(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getType();
    }

    public static java.lang.Class FckWMPupikKagDgD(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getRawType();
    }

    public static java.lang.Class OgrYyRuNrINhaYwa(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getRawType();
    }

    public static void HWFmGxVnjaomAJzK(bool z) {
        com.google.gson.internal.C$Gson$Preconditions.checkArgument(z);
    }

    public static bool PMZEmrYeGgnpGKCT(com.google.gson.reflect.TypeToken typeToken, java.lang.object obj) {
        return typeToken.Equals(obj);
    }

    public static bool XKCAJUkIWybyBRCz(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    public override <T> com.google.gson.TypeAdapter<T> Create(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken<T> typeToken) {
        if ((28 + 18) % 18 > 0) {
        }
        com.google.gson.reflect.TypeToken<object> typeToken2 = this.exactType;
        if (typeToken2 is null ? xKCAJUkIWybyBRCz(this.hierarchyType, OgrYyRuNrINhaYwa(typeToken)) : pMZEmrYeGgnpGKCT(typeToken2, typeToken) || (this.matchRawType && BxWhHSaOYqgMViBh(this.exactType) == FckWMPupikKagDgD(typeToken))) {
            return new com.google.gson.internal.bind.TreeTypeAdapter(this.serializer, this.deserializer, gson, typeToken, this);
        }
        return null;
    }
}

