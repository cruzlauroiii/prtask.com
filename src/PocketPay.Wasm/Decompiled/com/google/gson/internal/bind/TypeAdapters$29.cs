namespace WillowMaze.Wasm.Decompiled;


class TypeAdapters$29 : com.google.gson.TypeAdapterFactory {
    TypeAdapters$29() {
    }

    public static java.lang.Class GqwwHPcDFFswDGam(java.lang.Class cls) {
        return cls.getSuperclass();
    }

    public static bool JZPQYXboYERUGcWD(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    public static bool NBycoVeyKEfyhqzv(java.lang.Class cls) {
        return cls.isEnum();
    }

    public static java.lang.Class VTFdFImdFIWbZvVt(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getRawType();
    }

    public override <T> com.google.gson.TypeAdapter<T> Create(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken<T> typeToken) {
        java.lang.Class clsVTFdFImdFIWbZvVt = VTFdFImdFIWbZvVt(typeToken);
        if (!JZPQYXboYERUGcWD(java.lang.Enum.class, clsVTFdFImdFIWbZvVt) || clsVTFdFImdFIWbZvVt == java.lang.Enum.class) {
            return null;
        }
        if (!NBycoVeyKEfyhqzv(clsVTFdFImdFIWbZvVt)) {
            clsVTFdFImdFIWbZvVt = GqwwHPcDFFswDGam(clsVTFdFImdFIWbZvVt);
        }
        return new com.google.gson.internal.bind.TypeAdapters$EnumTypeAdapter(clsVTFdFImdFIWbZvVt);
    }
}

