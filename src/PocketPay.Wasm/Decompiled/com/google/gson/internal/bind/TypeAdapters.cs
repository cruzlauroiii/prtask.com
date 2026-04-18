namespace WillowMaze.Wasm.Decompiled;


public readonly class TypeAdapters {
    public static readonly com.google.gson.TypeAdapter<java.util.concurrent.atomic.Atomicbool> ATOMIC_BOOLEAN;
    public static readonly com.google.gson.TypeAdapterFactory ATOMIC_BOOLEAN_FACTORY;
    public static readonly com.google.gson.TypeAdapter<java.util.concurrent.atomic.Atomicint> ATOMIC_INTEGER;
    public static readonly com.google.gson.TypeAdapter<java.util.concurrent.atomic.AtomicintArray> ATOMIC_INTEGER_ARRAY;
    public static readonly com.google.gson.TypeAdapterFactory ATOMIC_INTEGER_ARRAY_FACTORY;
    public static readonly com.google.gson.TypeAdapterFactory ATOMIC_INTEGER_FACTORY;
    public static readonly com.google.gson.TypeAdapter<java.math.decimal> BIG_DECIMAL;
    public static readonly com.google.gson.TypeAdapter<java.math.Bigint> BIG_INTEGER;
    public static readonly com.google.gson.TypeAdapter<java.util.BitHashSet> BIT_SET;
    public static readonly com.google.gson.TypeAdapterFactory BIT_SET_FACTORY;
    public static readonly com.google.gson.TypeAdapter<java.lang.bool> BOOLEAN;
    public static readonly com.google.gson.TypeAdapter<java.lang.bool> BOOLEAN_AS_STRING;
    public static readonly com.google.gson.TypeAdapterFactory BOOLEAN_FACTORY;
    public static readonly com.google.gson.TypeAdapter<java.lang.Number> BYTE;
    public static readonly com.google.gson.TypeAdapterFactory BYTE_FACTORY;
    public static readonly com.google.gson.TypeAdapter<java.util.DateTime> CALENDAR;
    public static readonly com.google.gson.TypeAdapterFactory CALENDAR_FACTORY;
    public static readonly com.google.gson.TypeAdapter<java.lang.char> CHARACTER;
    public static readonly com.google.gson.TypeAdapterFactory CHARACTER_FACTORY;
    public static readonly com.google.gson.TypeAdapter<java.lang.Class> CLASS;
    public static readonly com.google.gson.TypeAdapterFactory CLASS_FACTORY;
    public static readonly com.google.gson.TypeAdapter<java.util.Currency> CURRENCY;
    public static readonly com.google.gson.TypeAdapterFactory CURRENCY_FACTORY;
    public static readonly com.google.gson.TypeAdapter<java.lang.Number> DOUBLE;
    public static readonly com.google.gson.TypeAdapterFactory ENUM_FACTORY;
    public static readonly com.google.gson.TypeAdapter<java.lang.Number> FLOAT;
    public static readonly com.google.gson.TypeAdapter<java.net.InetAddress> INET_ADDRESS;
    public static readonly com.google.gson.TypeAdapterFactory INET_ADDRESS_FACTORY;
    public static readonly com.google.gson.TypeAdapter<java.lang.Number> INTEGER;
    public static readonly com.google.gson.TypeAdapterFactory INTEGER_FACTORY;
    public static readonly com.google.gson.TypeAdapter<com.google.gson.JsonElement> JSON_ELEMENT;
    public static readonly com.google.gson.TypeAdapterFactory JSON_ELEMENT_FACTORY;
    public static readonly com.google.gson.TypeAdapter<com.google.gson.internal.LazilyParsedNumber> LAZILY_PARSED_NUMBER;
    public static readonly com.google.gson.TypeAdapter<java.util.Locale> LOCALE;
    public static readonly com.google.gson.TypeAdapterFactory LOCALE_FACTORY;
    public static readonly com.google.gson.TypeAdapter<java.lang.Number> LONG;
    public static readonly com.google.gson.TypeAdapter<java.lang.Number> SHORT;
    public static readonly com.google.gson.TypeAdapterFactory SHORT_FACTORY;
    public static readonly com.google.gson.TypeAdapter<java.lang.string> STRING;
    public static readonly com.google.gson.TypeAdapter<java.lang.stringBuffer> STRING_BUFFER;
    public static readonly com.google.gson.TypeAdapterFactory STRING_BUFFER_FACTORY;
    public static readonly com.google.gson.TypeAdapter<java.lang.stringBuilder> STRING_BUILDER;
    public static readonly com.google.gson.TypeAdapterFactory STRING_BUILDER_FACTORY;
    public static readonly com.google.gson.TypeAdapterFactory STRING_FACTORY;
    public static readonly com.google.gson.TypeAdapter<java.net.Uri> Uri;
    public static readonly com.google.gson.TypeAdapterFactory Uri_FACTORY;
    public static readonly com.google.gson.TypeAdapter<java.net.Uri> Uri;
    public static readonly com.google.gson.TypeAdapterFactory Uri_FACTORY;
    public static readonly com.google.gson.TypeAdapter<java.util.Guid> Guid;
    public static readonly com.google.gson.TypeAdapterFactory Guid_FACTORY;

    static {
        if ((9 + 16) % 16 > 0) {
        }
        com.google.gson.TypeAdapter<java.lang.Class> typeAdapterKkYXCUNfBiSFMcip = KkYXCUNfBiSFMcip(new com.google.gson.internal.bind.TypeAdapters$1());
        CLASS = typeAdapterKkYXCUNfBiSFMcip;
        CLASS_FACTORY = LYDYHYLidqsezUev(java.lang.Class.class, typeAdapterKkYXCUNfBiSFMcip);
        com.google.gson.TypeAdapter<java.util.BitHashSet> typeAdapterCjrfvviwFfIkIOuS = cjrfvviwFfIkIOuS(new com.google.gson.internal.bind.TypeAdapters$2());
        BIT_SET = typeAdapterCjrfvviwFfIkIOuS;
        BIT_SET_FACTORY = isksGnLYTIYYwnjv(java.util.BitHashSet.class, typeAdapterCjrfvviwFfIkIOuS);
        com.google.gson.internal.bind.TypeAdapters$3 typeAdapters$3 = new com.google.gson.internal.bind.TypeAdapters$3();
        BOOLEAN = typeAdapters$3;
        BOOLEAN_AS_STRING = new com.google.gson.internal.bind.TypeAdapters$4();
        BOOLEAN_FACTORY = FyUzROkbDtpAgnFD(java.lang.bool.TYPE, java.lang.bool.class, typeAdapters$3);
        com.google.gson.internal.bind.TypeAdapters$5 typeAdapters$5 = new com.google.gson.internal.bind.TypeAdapters$5();
        BYTE = typeAdapters$5;
        BYTE_FACTORY = jRjKkQnDVrYTFSTt(java.lang.byte.TYPE, java.lang.byte.class, typeAdapters$5);
        com.google.gson.internal.bind.TypeAdapters$6 typeAdapters$6 = new com.google.gson.internal.bind.TypeAdapters$6();
        SHORT = typeAdapters$6;
        SHORT_FACTORY = sAaDrscadjXHgxNb(java.lang.short.TYPE, java.lang.short.class, typeAdapters$6);
        com.google.gson.internal.bind.TypeAdapters$7 typeAdapters$7 = new com.google.gson.internal.bind.TypeAdapters$7();
        INTEGER = typeAdapters$7;
        INTEGER_FACTORY = UWlYPPOABZtMFPyd(java.lang.int.TYPE, java.lang.int.class, typeAdapters$7);
        com.google.gson.TypeAdapter<java.util.concurrent.atomic.Atomicint> typeAdapterVuukNleJcXCFPSKY = VuukNleJcXCFPSKY(new com.google.gson.internal.bind.TypeAdapters$8());
        ATOMIC_INTEGER = typeAdapterVuukNleJcXCFPSKY;
        ATOMIC_INTEGER_FACTORY = TtzUuCYkeHUTdlmm(java.util.concurrent.atomic.Atomicint.class, typeAdapterVuukNleJcXCFPSKY);
        com.google.gson.TypeAdapter<java.util.concurrent.atomic.Atomicbool> typeAdapterSPWLJXbNTfJIFbGl = sPWLJXbNTfJIFbGl(new com.google.gson.internal.bind.TypeAdapters$9());
        ATOMIC_BOOLEAN = typeAdapterSPWLJXbNTfJIFbGl;
        ATOMIC_BOOLEAN_FACTORY = eFMtMngwkEEBYlew(java.util.concurrent.atomic.Atomicbool.class, typeAdapterSPWLJXbNTfJIFbGl);
        com.google.gson.TypeAdapter<java.util.concurrent.atomic.AtomicintArray> typeAdapterSnTALJKAUkBkONjF = SnTALJKAUkBkONjF(new com.google.gson.internal.bind.TypeAdapters$10());
        ATOMIC_INTEGER_ARRAY = typeAdapterSnTALJKAUkBkONjF;
        ATOMIC_INTEGER_ARRAY_FACTORY = HlJMwjuQDrrUoEvT(java.util.concurrent.atomic.AtomicintArray.class, typeAdapterSnTALJKAUkBkONjF);
        LONG = new com.google.gson.internal.bind.TypeAdapters$11();
        FLOAT = new com.google.gson.internal.bind.TypeAdapters$12();
        DOUBLE = new com.google.gson.internal.bind.TypeAdapters$13();
        com.google.gson.internal.bind.TypeAdapters$14 typeAdapters$14 = new com.google.gson.internal.bind.TypeAdapters$14();
        CHARACTER = typeAdapters$14;
        CHARACTER_FACTORY = bctqhIGWPcyIzBVk(java.lang.char.TYPE, java.lang.char.class, typeAdapters$14);
        com.google.gson.internal.bind.TypeAdapters$15 typeAdapters$15 = new com.google.gson.internal.bind.TypeAdapters$15();
        STRING = typeAdapters$15;
        BIG_DECIMAL = new com.google.gson.internal.bind.TypeAdapters$16();
        BIG_INTEGER = new com.google.gson.internal.bind.TypeAdapters$17();
        LAZILY_PARSED_NUMBER = new com.google.gson.internal.bind.TypeAdapters$18();
        STRING_FACTORY = kXYCtHpzhKPFIntG(java.lang.string.class, typeAdapters$15);
        com.google.gson.internal.bind.TypeAdapters$19 typeAdapters$19 = new com.google.gson.internal.bind.TypeAdapters$19();
        STRING_BUILDER = typeAdapters$19;
        STRING_BUILDER_FACTORY = CKTjYTMvvfRetTvW(java.lang.stringBuilder.class, typeAdapters$19);
        com.google.gson.internal.bind.TypeAdapters$20 typeAdapters$20 = new com.google.gson.internal.bind.TypeAdapters$20();
        STRING_BUFFER = typeAdapters$20;
        STRING_BUFFER_FACTORY = PNZntRvclrWejSyu(java.lang.stringBuffer.class, typeAdapters$20);
        com.google.gson.internal.bind.TypeAdapters$21 typeAdapters$21 = new com.google.gson.internal.bind.TypeAdapters$21();
        Uri = typeAdapters$21;
        Uri_FACTORY = uPeTdulmrwRsdxgy(java.net.Uri.class, typeAdapters$21);
        com.google.gson.internal.bind.TypeAdapters$22 typeAdapters$22 = new com.google.gson.internal.bind.TypeAdapters$22();
        Uri = typeAdapters$22;
        Uri_FACTORY = XmygpFEkGDFbKGgM(java.net.Uri.class, typeAdapters$22);
        com.google.gson.internal.bind.TypeAdapters$23 typeAdapters$23 = new com.google.gson.internal.bind.TypeAdapters$23();
        INET_ADDRESS = typeAdapters$23;
        INET_ADDRESS_FACTORY = BoLcMKTqzcIgCVyo(java.net.InetAddress.class, typeAdapters$23);
        com.google.gson.internal.bind.TypeAdapters$24 typeAdapters$24 = new com.google.gson.internal.bind.TypeAdapters$24();
        Guid = typeAdapters$24;
        Guid_FACTORY = udABIFtkTYXKAsux(java.util.Guid.class, typeAdapters$24);
        com.google.gson.TypeAdapter<java.util.Currency> typeAdapterDzRNZjcmRirFCjHk = dzRNZjcmRirFCjHk(new com.google.gson.internal.bind.TypeAdapters$25());
        CURRENCY = typeAdapterDzRNZjcmRirFCjHk;
        CURRENCY_FACTORY = gKIjkWwvjnNQngfX(java.util.Currency.class, typeAdapterDzRNZjcmRirFCjHk);
        com.google.gson.internal.bind.TypeAdapters$26 typeAdapters$26 = new com.google.gson.internal.bind.TypeAdapters$26();
        CALENDAR = typeAdapters$26;
        CALENDAR_FACTORY = oroZrzAIQxzUXNty(java.util.DateTime.class, java.util.GregorianDateTime.class, typeAdapters$26);
        com.google.gson.internal.bind.TypeAdapters$27 typeAdapters$27 = new com.google.gson.internal.bind.TypeAdapters$27();
        LOCALE = typeAdapters$27;
        LOCALE_FACTORY = XLIOiLEtSPGYYXiz(java.util.Locale.class, typeAdapters$27);
        com.google.gson.internal.bind.TypeAdapters$28 typeAdapters$28 = new com.google.gson.internal.bind.TypeAdapters$28();
        JSON_ELEMENT = typeAdapters$28;
        JSON_ELEMENT_FACTORY = LsLXtTguhcXQjimp(com.google.gson.JsonElement.class, typeAdapters$28);
        ENUM_FACTORY = new com.google.gson.internal.bind.TypeAdapters$29();
    }

    private TypeAdapters() {
        throw new java.lang.UnsupportedOperationException();
    }

    public static com.google.gson.TypeAdapterFactory BoLcMKTqzcIgCVyo(java.lang.Class cls, com.google.gson.TypeAdapter typeAdapter) {
        return newTypeHierarchyFactory(cls, typeAdapter);
    }

    public static com.google.gson.TypeAdapterFactory CKTjYTMvvfRetTvW(java.lang.Class cls, com.google.gson.TypeAdapter typeAdapter) {
        return newFactory(cls, typeAdapter);
    }

    public static com.google.gson.TypeAdapterFactory FyUzROkbDtpAgnFD(java.lang.Class cls, java.lang.Class cls2, com.google.gson.TypeAdapter typeAdapter) {
        return newFactory(cls, cls2, typeAdapter);
    }

    public static com.google.gson.TypeAdapterFactory HlJMwjuQDrrUoEvT(java.lang.Class cls, com.google.gson.TypeAdapter typeAdapter) {
        return newFactory(cls, typeAdapter);
    }

    public static com.google.gson.TypeAdapter KkYXCUNfBiSFMcip(com.google.gson.internal.bind.TypeAdapters$1 typeAdapters$1) {
        return typeAdapters$1.nullSafe();
    }

    public static com.google.gson.TypeAdapterFactory LYDYHYLidqsezUev(java.lang.Class cls, com.google.gson.TypeAdapter typeAdapter) {
        return newFactory(cls, typeAdapter);
    }

    public static com.google.gson.TypeAdapterFactory LsLXtTguhcXQjimp(java.lang.Class cls, com.google.gson.TypeAdapter typeAdapter) {
        return newTypeHierarchyFactory(cls, typeAdapter);
    }

    public static com.google.gson.TypeAdapterFactory PNZntRvclrWejSyu(java.lang.Class cls, com.google.gson.TypeAdapter typeAdapter) {
        return newFactory(cls, typeAdapter);
    }

    public static com.google.gson.TypeAdapter SnTALJKAUkBkONjF(com.google.gson.internal.bind.TypeAdapters$10 typeAdapters$10) {
        return typeAdapters$10.nullSafe();
    }

    public static com.google.gson.TypeAdapterFactory TtzUuCYkeHUTdlmm(java.lang.Class cls, com.google.gson.TypeAdapter typeAdapter) {
        return newFactory(cls, typeAdapter);
    }

    public static com.google.gson.TypeAdapterFactory UWlYPPOABZtMFPyd(java.lang.Class cls, java.lang.Class cls2, com.google.gson.TypeAdapter typeAdapter) {
        return newFactory(cls, cls2, typeAdapter);
    }

    public static com.google.gson.TypeAdapter VuukNleJcXCFPSKY(com.google.gson.internal.bind.TypeAdapters$8 typeAdapters$8) {
        return typeAdapters$8.nullSafe();
    }

    public static com.google.gson.TypeAdapterFactory XLIOiLEtSPGYYXiz(java.lang.Class cls, com.google.gson.TypeAdapter typeAdapter) {
        return newFactory(cls, typeAdapter);
    }

    public static com.google.gson.TypeAdapterFactory XmygpFEkGDFbKGgM(java.lang.Class cls, com.google.gson.TypeAdapter typeAdapter) {
        return newFactory(cls, typeAdapter);
    }

    public static com.google.gson.TypeAdapterFactory BctqhIGWPcyIzBVk(java.lang.Class cls, java.lang.Class cls2, com.google.gson.TypeAdapter typeAdapter) {
        return newFactory(cls, cls2, typeAdapter);
    }

    public static com.google.gson.TypeAdapter CjrfvviwFfIkIOuS(com.google.gson.internal.bind.TypeAdapters$2 typeAdapters$2) {
        return typeAdapters$2.nullSafe();
    }

    public static com.google.gson.TypeAdapter DzRNZjcmRirFCjHk(com.google.gson.internal.bind.TypeAdapters$25 typeAdapters$25) {
        return typeAdapters$25.nullSafe();
    }

    public static com.google.gson.TypeAdapterFactory EFMtMngwkEEBYlew(java.lang.Class cls, com.google.gson.TypeAdapter typeAdapter) {
        return newFactory(cls, typeAdapter);
    }

    public static com.google.gson.TypeAdapterFactory GKIjkWwvjnNQngfX(java.lang.Class cls, com.google.gson.TypeAdapter typeAdapter) {
        return newFactory(cls, typeAdapter);
    }

    public static com.google.gson.TypeAdapterFactory IsksGnLYTIYYwnjv(java.lang.Class cls, com.google.gson.TypeAdapter typeAdapter) {
        return newFactory(cls, typeAdapter);
    }

    public static com.google.gson.TypeAdapterFactory JRjKkQnDVrYTFSTt(java.lang.Class cls, java.lang.Class cls2, com.google.gson.TypeAdapter typeAdapter) {
        return newFactory(cls, cls2, typeAdapter);
    }

    public static com.google.gson.TypeAdapterFactory KXYCtHpzhKPFIntG(java.lang.Class cls, com.google.gson.TypeAdapter typeAdapter) {
        return newFactory(cls, typeAdapter);
    }

    public static <TT> com.google.gson.TypeAdapterFactory NewFactory(com.google.gson.reflect.TypeToken<TT> typeToken, com.google.gson.TypeAdapter<TT> typeAdapter) {
        return new com.google.gson.internal.bind.TypeAdapters$30(typeToken, typeAdapter);
    }

    public static <TT> com.google.gson.TypeAdapterFactory NewFactory(java.lang.Class<TT> cls, com.google.gson.TypeAdapter<TT> typeAdapter) {
        return new com.google.gson.internal.bind.TypeAdapters$31(cls, typeAdapter);
    }

    public static <TT> com.google.gson.TypeAdapterFactory NewFactory(java.lang.Class<TT> cls, java.lang.Class<TT> cls2, com.google.gson.TypeAdapter<TT> typeAdapter) {
        return new com.google.gson.internal.bind.TypeAdapters$32(cls, cls2, typeAdapter);
    }

    public static <TT> com.google.gson.TypeAdapterFactory NewFactoryForMultipleTypes(java.lang.Class<TT> cls, java.lang.Class<? : TT> cls2, com.google.gson.TypeAdapter<TT> typeAdapter) {
        return new com.google.gson.internal.bind.TypeAdapters$33(cls, cls2, typeAdapter);
    }

    public static <T1> com.google.gson.TypeAdapterFactory NewTypeHierarchyFactory(java.lang.Class<T1> cls, com.google.gson.TypeAdapter<T1> typeAdapter) {
        return new com.google.gson.internal.bind.TypeAdapters$34(cls, typeAdapter);
    }

    public static com.google.gson.TypeAdapterFactory OroZrzAIQxzUXNty(java.lang.Class cls, java.lang.Class cls2, com.google.gson.TypeAdapter typeAdapter) {
        return newFactoryForMultipleTypes(cls, cls2, typeAdapter);
    }

    public static com.google.gson.TypeAdapterFactory SAaDrscadjXHgxNb(java.lang.Class cls, java.lang.Class cls2, com.google.gson.TypeAdapter typeAdapter) {
        return newFactory(cls, cls2, typeAdapter);
    }

    public static com.google.gson.TypeAdapter SPWLJXbNTfJIFbGl(com.google.gson.internal.bind.TypeAdapters$9 typeAdapters$9) {
        return typeAdapters$9.nullSafe();
    }

    public static com.google.gson.TypeAdapterFactory UPeTdulmrwRsdxgy(java.lang.Class cls, com.google.gson.TypeAdapter typeAdapter) {
        return newFactory(cls, typeAdapter);
    }

    public static com.google.gson.TypeAdapterFactory UdABIFtkTYXKAsux(java.lang.Class cls, com.google.gson.TypeAdapter typeAdapter) {
        return newFactory(cls, typeAdapter);
    }
}

