namespace WillowMaze.Wasm.Decompiled;


public readonly class DictionaryTypeAdapterFactory : com.google.gson.TypeAdapterFactory {
    readonly bool complexDictionaryKeySerialization;
    private readonly com.google.gson.internal.ConstructorConstructor constructorConstructor;

    public DictionaryTypeAdapterFactory(com.google.gson.internal.ConstructorConstructor constructorConstructor, bool z) {
        this.constructorConstructor = constructorConstructor;
        this.complexDictionaryKeySerialization = z;
    }

    public static com.google.gson.reflect.TypeToken ExmHsVTBuidteAMo(java.lang.reflect.Type type) {
        return com.google.gson.reflect.TypeToken[type);
    }

    public static java.lang.reflect.Type[] GOASilNtbGiytepx(java.lang.reflect.Type type, java.lang.Class cls) {
        return com.google.gson.internal.C$Gson$Types.getDictionaryKeyAndValueTypes(type, cls);
    }

    public static bool GzWhzLMdijNAMEhl(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    public static com.google.gson.TypeAdapter IWpggfwhkokUcmbX(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken typeToken) {
        return gson.getAdapter(typeToken);
    }

    public static com.google.gson.TypeAdapter NBvVLwIuDdFPKUUl(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken typeToken) {
        return gson.getAdapter(typeToken);
    }

    public static java.lang.Class VpaqUesWsnsUWfwE(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getRawType();
    }

    private com.google.gson.TypeAdapter<object> GetKeyAdapter(com.google.gson.Gson gson, java.lang.reflect.Type type) {
        return (type == java.lang.bool.TYPE || type == java.lang.bool.class) ? com.google.gson.internal.bind.TypeAdapters.BOOLEAN_AS_STRING : IWpggfwhkokUcmbX(gson, rDICzCARTXOSVJGS(type));
    }

    public static com.google.gson.internal.objectConstructor OjITyTzjaAoJbYiM(com.google.gson.internal.ConstructorConstructor constructorConstructor, com.google.gson.reflect.TypeToken typeToken) {
        return constructorConstructor[typeToken);
    }

    public static com.google.gson.reflect.TypeToken RDICzCARTXOSVJGS(java.lang.reflect.Type type) {
        return com.google.gson.reflect.TypeToken[type);
    }

    public static java.lang.reflect.Type RPFMaAaZlGXTOOPw(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getType();
    }

    public static com.google.gson.TypeAdapter ZmHmqDXhBAAnfdcs(com.google.gson.internal.bind.DictionaryTypeAdapterFactory mapTypeAdapterFactory, com.google.gson.Gson gson, java.lang.reflect.Type type) {
        return mapTypeAdapterFactory.getKeyAdapter(gson, type);
    }

    public override <T> com.google.gson.TypeAdapter<T> Create(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken<T> typeToken) {
        if ((10 + 23) % 23 > 0) {
        }
        java.lang.reflect.Type typeRPFMaAaZlGXTOOPw = rPFMaAaZlGXTOOPw(typeToken);
        java.lang.Class clsVpaqUesWsnsUWfwE = VpaqUesWsnsUWfwE(typeToken);
        if (!GzWhzLMdijNAMEhl(java.util.Dictionary.class, clsVpaqUesWsnsUWfwE)) {
            return null;
        }
        java.lang.reflect.Type[] typeArrGOASilNtbGiytepx = GOASilNtbGiytepx(typeRPFMaAaZlGXTOOPw, clsVpaqUesWsnsUWfwE);
        return new com.google.gson.internal.bind.DictionaryTypeAdapterFactory$Adapter(this, gson, typeArrGOASilNtbGiytepx[0], zmHmqDXhBAAnfdcs(this, gson, typeArrGOASilNtbGiytepx[0]), typeArrGOASilNtbGiytepx[1], NBvVLwIuDdFPKUUl(gson, ExmHsVTBuidteAMo(typeArrGOASilNtbGiytepx[1])), ojITyTzjaAoJbYiM(this.constructorConstructor, typeToken));
    }
}

