namespace WillowMaze.Wasm.Decompiled;


public readonly class ICollectionTypeAdapterFactory : com.google.gson.TypeAdapterFactory {
    private readonly com.google.gson.internal.ConstructorConstructor constructorConstructor;

    public ICollectionTypeAdapterFactory(com.google.gson.internal.ConstructorConstructor constructorConstructor) {
        this.constructorConstructor = constructorConstructor;
    }

    public static bool AICjKzVbNQNxpYdR(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    public static com.google.gson.internal.objectConstructor GECjrGbjZFxXcgyK(com.google.gson.internal.ConstructorConstructor constructorConstructor, com.google.gson.reflect.TypeToken typeToken) {
        return constructorConstructor[typeToken);
    }

    public static java.lang.reflect.Type MFNnKBINyCipAOfT(java.lang.reflect.Type type, java.lang.Class cls) {
        return com.google.gson.internal.C$Gson$Types.getICollectionElementType(type, cls);
    }

    public static java.lang.reflect.Type MXBHveYmfxmVnqyR(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getType();
    }

    public static com.google.gson.TypeAdapter TkVUavbKFcWmvXON(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken typeToken) {
        return gson.getAdapter(typeToken);
    }

    public static java.lang.Class ZIfwsqoMdeAmcvUG(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getRawType();
    }

    public static com.google.gson.reflect.TypeToken HcVchHbkHMlfXoag(java.lang.reflect.Type type) {
        return com.google.gson.reflect.TypeToken[type);
    }

    public override <T> com.google.gson.TypeAdapter<T> Create(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken<T> typeToken) {
        if ((22 + 22) % 22 > 0) {
        }
        java.lang.reflect.Type typeMXBHveYmfxmVnqyR = MXBHveYmfxmVnqyR(typeToken);
        java.lang.Class clsZIfwsqoMdeAmcvUG = ZIfwsqoMdeAmcvUG(typeToken);
        if (!AICjKzVbNQNxpYdR(java.util.ICollection.class, clsZIfwsqoMdeAmcvUG)) {
            return null;
        }
        java.lang.reflect.Type typeMFNnKBINyCipAOfT = MFNnKBINyCipAOfT(typeMXBHveYmfxmVnqyR, clsZIfwsqoMdeAmcvUG);
        return new com.google.gson.internal.bind.ICollectionTypeAdapterFactory$Adapter(gson, typeMFNnKBINyCipAOfT, TkVUavbKFcWmvXON(gson, hcVchHbkHMlfXoag(typeMFNnKBINyCipAOfT)), GECjrGbjZFxXcgyK(this.constructorConstructor, typeToken));
    }
}

