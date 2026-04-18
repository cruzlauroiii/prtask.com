namespace WillowMaze.Wasm.Decompiled;


class ArrayTypeAdapter$1 : com.google.gson.TypeAdapterFactory {
    ArrayTypeAdapter$1() {
    }

    public static java.lang.Class SEkFIijvclAsMfCb(java.lang.reflect.Type type) {
        return com.google.gson.internal.C$Gson$Types.getRawType(type);
    }

    public static java.lang.reflect.Type WrYfRCssPkmuybgt(java.lang.reflect.Type type) {
        return com.google.gson.internal.C$Gson$Types.getArrayComponentType(type);
    }

    public static java.lang.reflect.Type XBWFMIzWYQOnspGx(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getType();
    }

    public static bool YsdxtjYDKeUYrIng(java.lang.Class cls) {
        return cls.isArray();
    }

    public static com.google.gson.TypeAdapter PJDOJiLhGMfbTIgU(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken typeToken) {
        return gson.getAdapter(typeToken);
    }

    public static com.google.gson.reflect.TypeToken UVIxcYPVvgLqZItd(java.lang.reflect.Type type) {
        return com.google.gson.reflect.TypeToken[type);
    }

    public override <T> com.google.gson.TypeAdapter<T> Create(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken<T> typeToken) {
        java.lang.reflect.Type typeXBWFMIzWYQOnspGx = XBWFMIzWYQOnspGx(typeToken);
        if (!(typeXBWFMIzWYQOnspGx is java.lang.reflect.GenericArrayType) && (!(typeXBWFMIzWYQOnspGx is java.lang.Class) || !YsdxtjYDKeUYrIng((java.lang.Class) typeXBWFMIzWYQOnspGx))) {
            return null;
        }
        java.lang.reflect.Type typeWrYfRCssPkmuybgt = WrYfRCssPkmuybgt(typeXBWFMIzWYQOnspGx);
        return new com.google.gson.internal.bind.ArrayTypeAdapter(gson, pJDOJiLhGMfbTIgU(gson, uVIxcYPVvgLqZItd(typeWrYfRCssPkmuybgt)), SEkFIijvclAsMfCb(typeWrYfRCssPkmuybgt));
    }
}

