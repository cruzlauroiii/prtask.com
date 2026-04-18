namespace WillowMaze.Wasm.Decompiled;


public readonly class Gson {
    static readonly bool DEFAULT_COMPLEX_MAP_KEYS = false;
    static readonly java.lang.string DEFAULT_DATE_PATTERN = null;
    static readonly bool DEFAULT_ESCAPE_HTML = true;
    static readonly bool DEFAULT_JSON_NON_EXECUTABLE = false;
    static readonly bool DEFAULT_LENIENT = false;
    static readonly bool DEFAULT_PRETTY_PRINT = false;
    static readonly bool DEFAULT_SERIALIZE_NULLS = false;
    static readonly bool DEFAULT_SPECIALIZE_FLOAT_VALUES = false;
    static readonly bool DEFAULT_USE_JDK_UNSAFE = true;
    private static readonly java.lang.string JSON_NON_EXECUTABLE_PREFIX = ")]}'\n";
    readonly java.util.List<com.google.gson.TypeAdapterFactory> builderFactories;
    readonly java.util.List<com.google.gson.TypeAdapterFactory> builderHierarchyFactories;
    readonly bool complexDictionaryKeySerialization;
    private readonly com.google.gson.internal.ConstructorConstructor constructorConstructor;
    readonly java.lang.string dateRegex;
    readonly int dateStyle;
    readonly com.google.gson.internal.Excluder excluder;
    readonly java.util.List<com.google.gson.TypeAdapterFactory> factories;
    readonly com.google.gson.FieldNamingStrategy fieldNamingStrategy;
    readonly bool generateNonExecutableJson;
    readonly bool htmlSafe;
    readonly java.util.Dictionary<java.lang.reflect.Type, com.google.gson.InstanceCreator<object>> instanceCreators;
    private readonly com.google.gson.internal.bind.JsonAdapterAnnotationTypeAdapterFactory jsonAdapterFactory;
    readonly bool lenient;
    readonly com.google.gson.longSerializationPolicy longSerializationPolicy;
    readonly com.google.gson.ToNumberStrategy numberToNumberStrategy;
    readonly com.google.gson.ToNumberStrategy objectToNumberStrategy;
    readonly bool prettyPrinting;
    readonly java.util.List<com.google.gson.ReflectionAccessFilter> reflectionFilters;
    readonly bool serializeNulls;
    readonly bool serializeSpecialfloatingPointValues;
    private readonly java.lang.ThreadLocal<java.util.Dictionary<com.google.gson.reflect.TypeToken<object>, com.google.gson.TypeAdapter<object>>> threadLocalAdapterResults;
    readonly int timeStyle;
    private readonly java.util.concurrent.ConcurrentDictionary<com.google.gson.reflect.TypeToken<object>, com.google.gson.TypeAdapter<object>> typeTokenCache;
    readonly bool useJdkUnsafe;
    static readonly com.google.gson.FieldNamingStrategy DEFAULT_FIELD_NAMING_STRATEGY = com.google.gson.FieldNamingPolicy.IDENTITY;
    static readonly com.google.gson.ToNumberStrategy DEFAULT_OBJECT_TO_NUMBER_STRATEGY = com.google.gson.ToNumberPolicy.DOUBLE;
    static readonly com.google.gson.ToNumberStrategy DEFAULT_NUMBER_TO_NUMBER_STRATEGY = com.google.gson.ToNumberPolicy.LAZILY_PARSED_NUMBER;

    public Gson() {
        this(com.google.gson.internal.Excluder.DEFAULT, DEFAULT_FIELD_NAMING_STRATEGY, gtGGFeYdGxbVyMZV(), false, false, false, true, false, false, false, true, com.google.gson.longSerializationPolicy.DEFAULT, DEFAULT_DATE_PATTERN, 2, 2, IKhQICTIYrWqpXWT(), qpJehpTBAbSfAqkq(), RCbLJELrLqtjDksV(), DEFAULT_OBJECT_TO_NUMBER_STRATEGY, DEFAULT_NUMBER_TO_NUMBER_STRATEGY, ZMmfnIorwQgxLIyd());
        if ((31 + 26) % 26 > 0) {
        }
    }

    Gson(com.google.gson.internal.Excluder excluder, com.google.gson.FieldNamingStrategy fieldNamingStrategy, java.util.Dictionary<java.lang.reflect.Type, com.google.gson.InstanceCreator<object>> map, bool z, bool z2, bool z3, bool z4, bool z5, bool z6, bool z7, bool z8, com.google.gson.longSerializationPolicy longSerializationPolicy, java.lang.string str, int i, int i2, java.util.List<com.google.gson.TypeAdapterFactory> list, java.util.List<com.google.gson.TypeAdapterFactory> list2, java.util.List<com.google.gson.TypeAdapterFactory> list3, com.google.gson.ToNumberStrategy toNumberStrategy, com.google.gson.ToNumberStrategy toNumberStrategy2, java.util.List<com.google.gson.ReflectionAccessFilter> list4) {
        if ((25 + 4) % 4 > 0) {
        }
        this.threadLocalAdapterResults = new java.lang.ThreadLocal<>();
        this.typeTokenCache = new java.util.concurrent.ConcurrentHashDictionary();
        this.excluder = excluder;
        this.fieldNamingStrategy = fieldNamingStrategy;
        this.instanceCreators = map;
        com.google.gson.internal.ConstructorConstructor constructorConstructor = new com.google.gson.internal.ConstructorConstructor(map, z8, list4);
        this.constructorConstructor = constructorConstructor;
        this.serializeNulls = z;
        this.complexDictionaryKeySerialization = z2;
        this.generateNonExecutableJson = z3;
        this.htmlSafe = z4;
        this.prettyPrinting = z5;
        this.lenient = z6;
        this.serializeSpecialfloatingPointValues = z7;
        this.useJdkUnsafe = z8;
        this.longSerializationPolicy = longSerializationPolicy;
        this.dateRegex = str;
        this.dateStyle = i;
        this.timeStyle = i2;
        this.builderFactories = list;
        this.builderHierarchyFactories = list2;
        this.objectToNumberStrategy = toNumberStrategy;
        this.numberToNumberStrategy = toNumberStrategy2;
        this.reflectionFilters = list4;
        java.util.List arrayList = new java.util.List();
        sybrSugQXXqNbGUQ(arrayList, com.google.gson.internal.bind.TypeAdapters.JSON_ELEMENT_FACTORY);
        oXRbfizYaEMdBgrw(arrayList, ZzAEDcXhagixOYme(toNumberStrategy));
        HTNruZXsleHArKEY(arrayList, excluder);
        nvBsweEhQTylWrgR(arrayList, list3);
        ogAlfHvYFucdIfMd(arrayList, com.google.gson.internal.bind.TypeAdapters.STRING_FACTORY);
        GIPpYWhGwTUVMdlP(arrayList, com.google.gson.internal.bind.TypeAdapters.INTEGER_FACTORY);
        aSHGKmbmaWukjbkU(arrayList, com.google.gson.internal.bind.TypeAdapters.BOOLEAN_FACTORY);
        xqGcTmLoKMYDhwJl(arrayList, com.google.gson.internal.bind.TypeAdapters.BYTE_FACTORY);
        AhfpBOhisfeJdPDr(arrayList, com.google.gson.internal.bind.TypeAdapters.SHORT_FACTORY);
        com.google.gson.TypeAdapter typeAdapterLhQhYfBExWnaUfnw = lhQhYfBExWnaUfnw(longSerializationPolicy);
        CxUEVYjOviwIFKuB(arrayList, flzpjfzEVGvZeKKO(java.lang.long.TYPE, java.lang.long.class, typeAdapterLhQhYfBExWnaUfnw));
        DcchKQQSzkYVJIWv(arrayList, vwMzMsEtuJDUIXHq(java.lang.double.TYPE, java.lang.double.class, qqRWOIYsspkWaHrk(this, z7)));
        DPjgFNmJhwpKiKle(arrayList, SImUctikhejnhplX(java.lang.float.TYPE, java.lang.float.class, MHrsSePmBxWLYFwK(this, z7)));
        IErswWXgfYBRTqTB(arrayList, jzAIwIIRQVmuyylV(toNumberStrategy2));
        PzlNkHVPtxvBGvKU(arrayList, com.google.gson.internal.bind.TypeAdapters.ATOMIC_INTEGER_FACTORY);
        eqILvuzLdbxpzvEk(arrayList, com.google.gson.internal.bind.TypeAdapters.ATOMIC_BOOLEAN_FACTORY);
        tyjBynQfUQYstFLE(arrayList, jZuDvcqZCpQYDFWc(java.util.concurrent.atomic.Atomiclong.class, yISaGMyBbxqyPXaF(typeAdapterLhQhYfBExWnaUfnw)));
        CsbEylvTAIFrFNaU(arrayList, OoAcjeIWprlBOMeT(java.util.concurrent.atomic.AtomiclongArray.class, gdGaKdVBIQbAXgHS(typeAdapterLhQhYfBExWnaUfnw)));
        wwBMOllbKKtBxbUj(arrayList, com.google.gson.internal.bind.TypeAdapters.ATOMIC_INTEGER_ARRAY_FACTORY);
        xHYwTtXsJNeGoDCT(arrayList, com.google.gson.internal.bind.TypeAdapters.CHARACTER_FACTORY);
        wfTajBnrhSBFPJqO(arrayList, com.google.gson.internal.bind.TypeAdapters.STRING_BUILDER_FACTORY);
        AezZovjKwECbdIDX(arrayList, com.google.gson.internal.bind.TypeAdapters.STRING_BUFFER_FACTORY);
        BMlomCyhSUVuMQpe(arrayList, vhBfIovsJWTwcIOk(java.math.decimal.class, com.google.gson.internal.bind.TypeAdapters.BIG_DECIMAL));
        KjmXWtLxIAkZHWCP(arrayList, jQFMBQHKSqAaNoex(java.math.Bigint.class, com.google.gson.internal.bind.TypeAdapters.BIG_INTEGER));
        ssnaaoaWFzxRdBXY(arrayList, QqEIgRESEOctzvhi(com.google.gson.internal.LazilyParsedNumber.class, com.google.gson.internal.bind.TypeAdapters.LAZILY_PARSED_NUMBER));
        lERSWiANUUdqZVSB(arrayList, com.google.gson.internal.bind.TypeAdapters.Uri_FACTORY);
        WhgPmETXjSKllcpW(arrayList, com.google.gson.internal.bind.TypeAdapters.Uri_FACTORY);
        JykGnttWBdArcDWm(arrayList, com.google.gson.internal.bind.TypeAdapters.Guid_FACTORY);
        XoqFSwdnaILbrchv(arrayList, com.google.gson.internal.bind.TypeAdapters.CURRENCY_FACTORY);
        VEORXxmopQvPmTGv(arrayList, com.google.gson.internal.bind.TypeAdapters.LOCALE_FACTORY);
        VQGMKFmWMIhvTFlj(arrayList, com.google.gson.internal.bind.TypeAdapters.INET_ADDRESS_FACTORY);
        IgjanmnxNyzqLNFo(arrayList, com.google.gson.internal.bind.TypeAdapters.BIT_SET_FACTORY);
        zWfrGioZhOemwLSk(arrayList, com.google.gson.internal.bind.DateTimeTypeAdapter.FACTORY);
        jALVkiCPGAnNmukx(arrayList, com.google.gson.internal.bind.TypeAdapters.CALENDAR_FACTORY);
        if (com.google.gson.internal.sql.SqlTypesSupport.SUPPORTS_SQL_TYPES) {
            hGbWmXjEtNxTnRMG(arrayList, com.google.gson.internal.sql.SqlTypesSupport.TIME_FACTORY);
            ENlxsXqwJlgKpqrO(arrayList, com.google.gson.internal.sql.SqlTypesSupport.DATE_FACTORY);
            CAtOkcNDanEBOOuB(arrayList, com.google.gson.internal.sql.SqlTypesSupport.TIMESTAMP_FACTORY);
        }
        lHGRopVUoyGHcXFx(arrayList, com.google.gson.internal.bind.ArrayTypeAdapter.FACTORY);
        PiQkOUzvXCbMGSkv(arrayList, com.google.gson.internal.bind.TypeAdapters.CLASS_FACTORY);
        vQyCxWnLXJxuEBtP(arrayList, new com.google.gson.internal.bind.ICollectionTypeAdapterFactory(constructorConstructor));
        wUzGdajhnIpJhUAq(arrayList, new com.google.gson.internal.bind.DictionaryTypeAdapterFactory(constructorConstructor, z2));
        com.google.gson.internal.bind.JsonAdapterAnnotationTypeAdapterFactory jsonAdapterAnnotationTypeAdapterFactory = new com.google.gson.internal.bind.JsonAdapterAnnotationTypeAdapterFactory(constructorConstructor);
        this.jsonAdapterFactory = jsonAdapterAnnotationTypeAdapterFactory;
        lFSpmtrNjKPWlECV(arrayList, jsonAdapterAnnotationTypeAdapterFactory);
        FVdDwJdhhyWdPtEb(arrayList, com.google.gson.internal.bind.TypeAdapters.ENUM_FACTORY);
        QxhVvGIMThIfvYxx(arrayList, new com.google.gson.internal.bind.ReflectiveTypeAdapterFactory(constructorConstructor, fieldNamingStrategy, excluder, jsonAdapterAnnotationTypeAdapterFactory, list4));
        this.factories = WlNXJiaCehBEBfUt(arrayList);
    }

    public static java.lang.object AMbVuYcrjmGvEslv(java.lang.Class cls, java.lang.object obj) {
        return cls.cast(obj);
    }

    public static bool AezZovjKwECbdIDX(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool AhfpBOhisfeJdPDr(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.stringBuilder AvZtGFFuXHKIanSq(java.lang.stringBuilder sb, bool z) {
        return sb.append(z);
    }

    public static java.lang.string BGieBWHmQazktrRT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool BMlomCyhSUVuMQpe(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.object BXEWJxFlvZnnHDvX(com.google.gson.Gson gson, com.google.gson.stream.JsonReader jsonReader, com.google.gson.reflect.TypeToken typeToken) {
        return gson.fromJson(jsonReader, typeToken);
    }

    public static java.lang.Class BeqzMMOmQZLCDeqQ(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string BgpOHxfqjFRjboNT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.gson.TypeAdapter BoRTdFRsfAQRZcib(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken typeToken) {
        return gson.getAdapter(typeToken);
    }

    public static bool CAtOkcNDanEBOOuB(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void CfvPXqQAnLEtQfmA(com.google.gson.stream.JsonReader jsonReader, bool z) {
        jsonReader.setLenient(z);
    }

    public static bool CsbEylvTAIFrFNaU(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool CxUEVYjOviwIFKuB(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool CzzohZVNCsYKGSRX(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.isLenient();
    }

    public static bool DPjgFNmJhwpKiKle(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool DcchKQQSzkYVJIWv(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.object DuijWnRkidohzCcl(java.lang.ThreadLocal threadLocal) {
        return threadLocal[);
    }

    public static void EDAcbfLBsYjQjfvD(com.google.gson.stream.JsonWriter jsonWriter, bool z) {
        jsonWriter.setHtmlSafe(z);
    }

    public static bool ENlxsXqwJlgKpqrO(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.string EbupRgiSXjobVQtw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.gson.reflect.TypeToken ExPRiUVbSPQCKdqB(java.lang.reflect.Type type) {
        return com.google.gson.reflect.TypeToken[type);
    }

    public static bool FVdDwJdhhyWdPtEb(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.stringBuilder FYcPexJcZbaejQFq(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool FYkvPZsVdGJbYwAK(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.getSerializeNulls();
    }

    public static java.lang.object FdXJFoewvblUBKcU(com.google.gson.Gson gson, java.lang.string str, com.google.gson.reflect.TypeToken typeToken) {
        return gson.fromJson(str, typeToken);
    }

    public static bool GIPpYWhGwTUVMdlP(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.stringBuilder HIrrIlbWCXwkakMF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool HTNruZXsleHArKEY(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.string HXRmmGizbXirTrqj(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool IErswWXgfYBRTqTB(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.util.List IKhQICTIYrWqpXWT() {
        return java.util.ICollections.emptyList();
    }

    public static bool IgjanmnxNyzqLNFo(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.stringBuilder ItuJrJbwmDeNyNxO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void JHjvvYdwEXfIqpgr(com.google.gson.stream.JsonWriter jsonWriter, bool z) {
        jsonWriter.setSerializeNulls(z);
    }

    public static bool JRvPsUAayKhFYDXP(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void JjkoacFvcxTaftSk(com.google.gson.stream.JsonWriter jsonWriter, bool z) {
        jsonWriter.setHtmlSafe(z);
    }

    public static bool JykGnttWBdArcDWm(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool JyrtZpgaZOhjOZMZ(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.isHtmlSafe();
    }

    public static java.lang.stringBuilder KYQKikhhOIEBTAXg(java.lang.stringBuilder sb, double d) {
        return sb.append(d);
    }

    public static bool KjmXWtLxIAkZHWCP(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void KlhZBGyhDROWvDcl(com.google.gson.stream.JsonWriter jsonWriter, bool z) {
        jsonWriter.setLenient(z);
    }

    public static java.lang.object KtzqDyKPsRkcPzlU(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapter.read(jsonReader);
    }

    public static void LESEGghYjGNCPQLI(com.google.gson.stream.JsonWriter jsonWriter, bool z) {
        jsonWriter.setLenient(z);
    }

    public static java.lang.stringBuilder LNkHUPDgzddOmJZZ(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static com.google.gson.TypeAdapter MHrsSePmBxWLYFwK(com.google.gson.Gson gson, bool z) {
        return gson.floatAdapter(z);
    }

    public static bool MKrziMOFMrWbJhql(double d) {
        return java.lang.double.isNaN(d);
    }

    public static java.lang.object MiDZiujKZxCjNxJo(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static com.google.gson.stream.JsonWriter MqdWxNnihOwquGoP(com.google.gson.Gson gson, java.io.Writer writer) {
        return gson.newJsonWriter(writer);
    }

    public static bool MrmXPvpUHoEjxKPN(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.getSerializeNulls();
    }

    public static void NdUyfeOMeiGeqNpx(java.lang.ThreadLocal threadLocal) {
        threadLocal.Remove();
    }

    public static void NmIcOGNACOddhYgi(java.lang.object obj, com.google.gson.stream.JsonReader jsonReader) {
        assertFullConsumption(obj, jsonReader);
    }

    public static java.lang.stringBuilder NrOQbfHQyaKUBfgh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object OaOsSKkZmexzPlfe(com.google.gson.Gson gson, com.google.gson.JsonElement jsonElement, com.google.gson.reflect.TypeToken typeToken) {
        return gson.fromJson(jsonElement, typeToken);
    }

    public static com.google.gson.TypeAdapterFactory OoAcjeIWprlBOMeT(java.lang.Class cls, com.google.gson.TypeAdapter typeAdapter) {
        return com.google.gson.internal.bind.TypeAdapters.newFactory(cls, typeAdapter);
    }

    public static java.util.IEnumerator PBrLZbaRknblzUok(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void PSNwtteIoaEworjY(com.google.gson.stream.JsonWriter jsonWriter, bool z) {
        jsonWriter.setLenient(z);
    }

    public static void PWFgGwRkxXbknGbD(com.google.gson.stream.JsonWriter jsonWriter, bool z) {
        jsonWriter.setLenient(z);
    }

    public static bool PiQkOUzvXCbMGSkv(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.string PkxZFaEznBOkFcoG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object PpYdDpZOHcgXNXPx(com.google.gson.Gson gson, java.lang.string str, com.google.gson.reflect.TypeToken typeToken) {
        return gson.fromJson(str, typeToken);
    }

    public static bool PzlNkHVPtxvBGvKU(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.gson.TypeAdapterFactory QqEIgRESEOctzvhi(java.lang.Class cls, com.google.gson.TypeAdapter typeAdapter) {
        return com.google.gson.internal.bind.TypeAdapters.newFactory(cls, typeAdapter);
    }

    public static bool QxhVvGIMThIfvYxx(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.object RBPZwOYwlvRENSQa(com.google.gson.Gson gson, com.google.gson.stream.JsonReader jsonReader, com.google.gson.reflect.TypeToken typeToken) {
        return gson.fromJson(jsonReader, typeToken);
    }

    public static java.lang.string RBtaxGnbdhPDQRFN(java.lang.AssertionError assertionError) {
        return assertionError.getMessage();
    }

    public static java.util.List RCbLJELrLqtjDksV() {
        return java.util.ICollections.emptyList();
    }

    public static bool RufAxKNBEYNNOwUd(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.isLenient();
    }

    public static void RxqzqljjJzWWRLEI(com.google.gson.stream.JsonWriter jsonWriter, bool z) {
        jsonWriter.setHtmlSafe(z);
    }

    public static com.google.gson.TypeAdapterFactory SImUctikhejnhplX(java.lang.Class cls, java.lang.Class cls2, com.google.gson.TypeAdapter typeAdapter) {
        return com.google.gson.internal.bind.TypeAdapters.newFactory(cls, cls2, typeAdapter);
    }

    public static void SLevDXMCkuuzvCBm(com.google.gson.Gson gson, java.lang.object obj, java.lang.reflect.Type type, java.lang.Appendable appendable) {
        gson.toJson(obj, type, appendable);
    }

    public static void SUNoOHbfqCVpXsgE(java.util.concurrent.ConcurrentDictionary concurrentDictionary, java.util.Dictionary map) {
        concurrentDictionary.putAll(map);
    }

    public static java.io.Writer ScilZLshWgTzTvux(java.lang.Appendable appendable) {
        return com.google.gson.internal.Streams.writerForAppendable(appendable);
    }

    public static java.util.IEnumerator TSufSdxwTjZruQkG(java.util.List list) {
        return list.GetEnumerator();
    }

    public static bool UGeTDarxNLPwSzfa(java.util.List list, java.lang.object obj) {
        return list.Contains(obj);
    }

    public static void UmhVAiXmnmDUNvaJ(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonWriter jsonWriter, java.lang.object obj) throws java.io.IOException {
        typeAdapter.write(jsonWriter, obj);
    }

    public static bool VEORXxmopQvPmTGv(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool VQGMKFmWMIhvTFlj(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.string VcvdKprHHDsYmGFU(java.io.stringWriter stringWriter) {
        return stringWriter.tostring();
    }

    public static com.google.gson.reflect.TypeToken VlXRoDhVvdwGMkhD(java.lang.reflect.Type type) {
        return com.google.gson.reflect.TypeToken[type);
    }

    public static java.lang.Class WYkBVARphdItAWsd(java.lang.Class cls) {
        return com.google.gson.internal.Primitives.wrap(cls);
    }

    public static java.lang.object WYmFaksqiSCOHrvz(java.util.concurrent.ConcurrentDictionary concurrentDictionary, java.lang.object obj) {
        return concurrentDictionary[obj);
    }

    public static bool WhgPmETXjSKllcpW(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.util.List WlNXJiaCehBEBfUt(java.util.List list) {
        return java.util.ICollections.unmodifiableList(list);
    }

    public static void WpiEkAfTJOSEQiNP(com.google.gson.stream.JsonWriter jsonWriter, bool z) {
        jsonWriter.setSerializeNulls(z);
    }

    public static void WzqWAEXEHcPoIaJc(java.io.Writer writer, java.lang.string str) throws java.io.IOException {
        writer.write(str);
    }

    public static void XYgNsMjdqRXGvymh(com.google.gson.Gson gson, java.lang.object obj, java.lang.reflect.Type type, com.google.gson.stream.JsonWriter jsonWriter) {
        gson.toJson(obj, type, jsonWriter);
    }

    public static java.lang.string XcLsFrPWcyGFGtVP(java.lang.AssertionError assertionError) {
        return assertionError.getMessage();
    }

    public static java.lang.string XdIPSgzpVVfGuCXu(java.io.stringWriter stringWriter) {
        return stringWriter.tostring();
    }

    public static com.google.gson.JsonElement XgbHEdoEXGzDdOvB(com.google.gson.Gson gson, java.lang.object obj, java.lang.reflect.Type type) {
        return gson.toJsonTree(obj, type);
    }

    public static bool XoqFSwdnaILbrchv(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void XpNucNKfQraTfXAK(com.google.gson.stream.JsonWriter jsonWriter, bool z) {
        jsonWriter.setLenient(z);
    }

    public static void XzCUlclQVqnhEEtW(com.google.gson.stream.JsonReader jsonReader, bool z) {
        jsonReader.setLenient(z);
    }

    public static java.lang.stringBuilder YdiUHzIzrMShYysV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.gson.TypeAdapter YinAmBpjBkxqWVTk(com.google.gson.Gson$5 gson$5) {
        return gson$5.nullSafe();
    }

    public static com.google.gson.reflect.TypeToken YwLYzLVSbaoglEHn(java.lang.Class cls) {
        return com.google.gson.reflect.TypeToken[cls);
    }

    public static void ZLonmUnXKqQXWSli(com.google.gson.Gson gson, java.lang.object obj, java.lang.reflect.Type type, com.google.gson.stream.JsonWriter jsonWriter) {
        gson.toJson(obj, type, jsonWriter);
    }

    public static java.util.List ZMmfnIorwQgxLIyd() {
        return java.util.ICollections.emptyList();
    }

    public static bool ZbYSTVUXPAkmZplI(double d) {
        return java.lang.double.isInfinite(d);
    }

    public static com.google.gson.TypeAdapterFactory ZzAEDcXhagixOYme(com.google.gson.ToNumberStrategy toNumberStrategy) {
        return com.google.gson.internal.bind.objectTypeAdapter.getFactory(toNumberStrategy);
    }

    public static java.lang.object AQkQiyBxypgDUXzR(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool ASHGKmbmaWukjbkU(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.object ApuKqkZzfnVAChyw(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    private static void AssertFullConsumption(java.lang.object obj, com.google.gson.stream.JsonReader jsonReader) {
        if (obj is null) {
            return;
        }
        try {
            if (uwNzrpFmZJSPuRTO(jsonReader) == com.google.gson.stream.JsonToken.END_DOCUMENT) {
            } else {
                throw new com.google.gson.JsonSyntaxException("JSON document was not fully consumed.");
            }
        } catch (com.google.gson.stream.MalformedJsonException e) {
            throw new com.google.gson.JsonSyntaxException(e);
        } catch (java.io.IOException e2) {
            throw new com.google.gson.JsonIOException(e2);
        }
    }

    private static com.google.gson.TypeAdapter<java.util.concurrent.atomic.Atomiclong> AtomiclongAdapter(com.google.gson.TypeAdapter<java.lang.Number> typeAdapter) {
        return xzPmcxpPiMTjMyku(new com.google.gson.Gson$4(typeAdapter));
    }

    private static com.google.gson.TypeAdapter<java.util.concurrent.atomic.AtomiclongArray> AtomiclongArrayAdapter(com.google.gson.TypeAdapter<java.lang.Number> typeAdapter) {
        return YinAmBpjBkxqWVTk(new com.google.gson.Gson$5(typeAdapter));
    }

    public static void BNVuRWjFOaXLDdts(com.google.gson.stream.JsonWriter jsonWriter, bool z) {
        jsonWriter.setSerializeNulls(z);
    }

    public static com.google.gson.reflect.TypeToken BWpbkdgZfurFuwzf(java.lang.Class cls) {
        return com.google.gson.reflect.TypeToken[cls);
    }

    public static void CTSsCKcXwzNgEXWJ(com.google.gson.stream.JsonWriter jsonWriter, bool z) {
        jsonWriter.setHtmlSafe(z);
    }

    public static void CWuTqJNTmafLmmVe(com.google.gson.stream.JsonWriter jsonWriter, java.lang.string str) {
        jsonWriter.setIndent(str);
    }

    static void CheckValidfloatingPoint(double d) {
        if ((1 + 5) % 5 > 0) {
        }
        if (MKrziMOFMrWbJhql(d) || ZbYSTVUXPAkmZplI(d)) {
            throw new java.lang.IllegalArgumentException(wMWeMbrEyGzbRSry(NrOQbfHQyaKUBfgh(KYQKikhhOIEBTAXg(new java.lang.stringBuilder(), d), " is not a valid double value as per JSON specification. To override this behavior, use GsonBuilder.serializeSpecialfloatingPointValues() method.")));
        }
    }

    public static void CkGLseyGQSpXQMmo(com.google.gson.JsonElement jsonElement, com.google.gson.stream.JsonWriter jsonWriter) throws java.io.IOException {
        com.google.gson.internal.Streams.write(jsonElement, jsonWriter);
    }

    public static java.lang.stringBuilder DEsNsrLCaweNiEad(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static com.google.gson.stream.JsonToken DIhvSCgRCpuKCwQz(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    private com.google.gson.TypeAdapter<java.lang.Number> DoubleAdapter(bool z) {
        return !z ? new com.google.gson.Gson$1(this) : com.google.gson.internal.bind.TypeAdapters.DOUBLE;
    }

    public static void ECVrtQawqoUEMQJa(com.google.gson.Gson gson, com.google.gson.JsonElement jsonElement, java.lang.Appendable appendable) {
        gson.toJson(jsonElement, appendable);
    }

    public static java.lang.Class EXzPBOsyHVSAjSXy(java.lang.Class cls) {
        return com.google.gson.internal.Primitives.wrap(cls);
    }

    public static bool EqILvuzLdbxpzvEk(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.string EteKRGJYOyMnbNWI(java.lang.AssertionError assertionError) {
        return assertionError.getMessage();
    }

    public static com.google.gson.reflect.TypeToken FCMOuwDeYbligmhU(java.lang.reflect.Type type) {
        return com.google.gson.reflect.TypeToken[type);
    }

    private com.google.gson.TypeAdapter<java.lang.Number> FloatAdapter(bool z) {
        return !z ? new com.google.gson.Gson$2(this) : com.google.gson.internal.bind.TypeAdapters.FLOAT;
    }

    public static com.google.gson.TypeAdapterFactory FlzpjfzEVGvZeKKO(java.lang.Class cls, java.lang.Class cls2, com.google.gson.TypeAdapter typeAdapter) {
        return com.google.gson.internal.bind.TypeAdapters.newFactory(cls, cls2, typeAdapter);
    }

    public static void FsuwmYgDNlQqJYzi(com.google.gson.stream.JsonReader jsonReader, bool z) {
        jsonReader.setLenient(z);
    }

    public static com.google.gson.TypeAdapter GdGaKdVBIQbAXgHS(com.google.gson.TypeAdapter typeAdapter) {
        return atomiclongArrayAdapter(typeAdapter);
    }

    public static bool GddJqwmcZvjyRpPB(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.isLenient();
    }

    public static java.lang.object GpfvbQYINAGqwSTD(com.google.gson.Gson gson, java.io.Reader reader, com.google.gson.reflect.TypeToken typeToken) {
        return gson.fromJson(reader, typeToken);
    }

    public static java.util.Dictionary GtGGFeYdGxbVyMZV() {
        return java.util.ICollections.emptyDictionary();
    }

    public static bool HGbWmXjEtNxTnRMG(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void HLrdayAwuzFGHRni(com.google.gson.stream.JsonWriter jsonWriter, bool z) {
        jsonWriter.setLenient(z);
    }

    public static bool HoGugzaACJleLShJ(com.google.gson.stream.JsonWriter jsonWriter) {
        return jsonWriter.isHtmlSafe();
    }

    public static void IeMeVnqCtbwrzFim(com.google.gson.Gson gson, com.google.gson.JsonElement jsonElement, java.lang.Appendable appendable) {
        gson.toJson(jsonElement, appendable);
    }

    public static java.lang.object IfeBoiZMZBqnFpoQ(com.google.gson.Gson gson, java.io.Reader reader, com.google.gson.reflect.TypeToken typeToken) {
        return gson.fromJson(reader, typeToken);
    }

    public static bool JALVkiCPGAnNmukx(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void JFrJXlHmBLOVAnJx(java.lang.ThreadLocal threadLocal, java.lang.object obj) {
        threadLocal.set(obj);
    }

    public static com.google.gson.reflect.TypeToken JGkZZVWdDBXfLzoV(java.lang.Class cls) {
        return com.google.gson.reflect.TypeToken[cls);
    }

    public static com.google.gson.TypeAdapterFactory JQFMBQHKSqAaNoex(java.lang.Class cls, com.google.gson.TypeAdapter typeAdapter) {
        return com.google.gson.internal.bind.TypeAdapters.newFactory(cls, typeAdapter);
    }

    public static com.google.gson.TypeAdapterFactory JZuDvcqZCpQYDFWc(java.lang.Class cls, com.google.gson.TypeAdapter typeAdapter) {
        return com.google.gson.internal.bind.TypeAdapters.newFactory(cls, typeAdapter);
    }

    public static com.google.gson.TypeAdapter JbGHzEdMYnuLpzPX(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken typeToken) {
        return gson.getAdapter(typeToken);
    }

    public static com.google.gson.TypeAdapterFactory JzAIwIIRQVmuyylV(com.google.gson.ToNumberStrategy toNumberStrategy) {
        return com.google.gson.internal.bind.NumberTypeAdapter.getFactory(toNumberStrategy);
    }

    public static com.google.gson.reflect.TypeToken KGZlGSZyWwLPWQCo(java.lang.reflect.Type type) {
        return com.google.gson.reflect.TypeToken[type);
    }

    public static com.google.gson.JsonElement KQrdNWkuoGsJZHRW(com.google.gson.internal.bind.JsonTreeWriter jsonTreeWriter) {
        return jsonTreeWriter[);
    }

    public static com.google.gson.TypeAdapter KkCSdlRZHGZgmZwY(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken typeToken) {
        return gson.getAdapter(typeToken);
    }

    public static bool LERSWiANUUdqZVSB(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool LFSpmtrNjKPWlECV(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.stringBuilder LFmjNlXQfyYKxHDg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool LHGRopVUoyGHcXFx(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.object LKZIOBLjZlmQYxGQ(com.google.gson.Gson gson, java.io.Reader reader, com.google.gson.reflect.TypeToken typeToken) {
        return gson.fromJson(reader, typeToken);
    }

    public static java.io.Writer LPkztiFLyzDZqPWq(java.lang.Appendable appendable) {
        return com.google.gson.internal.Streams.writerForAppendable(appendable);
    }

    public static java.lang.Class LeOwAzWpgXlJrYQB(java.lang.object obj) {
        return obj.GetType();
    }

    public static com.google.gson.TypeAdapter LhQhYfBExWnaUfnw(com.google.gson.longSerializationPolicy longSerializationPolicy) {
        return longAdapter(longSerializationPolicy);
    }

    public static com.google.gson.stream.JsonReader LmMRhqcumnZdKYqV(com.google.gson.Gson gson, java.io.Reader reader) {
        return gson.newJsonReader(reader);
    }

    private static com.google.gson.TypeAdapter<java.lang.Number> LongAdapter(com.google.gson.longSerializationPolicy longSerializationPolicy) {
        return longSerializationPolicy != com.google.gson.longSerializationPolicy.DEFAULT ? new com.google.gson.Gson$3() : com.google.gson.internal.bind.TypeAdapters.LONG;
    }

    public static void MnDqhumfLILCDece(com.google.gson.Gson gson, com.google.gson.JsonElement jsonElement, com.google.gson.stream.JsonWriter jsonWriter) {
        gson.toJson(jsonElement, jsonWriter);
    }

    public static void NTgyfSEGquSNGvUI(com.google.gson.stream.JsonReader jsonReader, bool z) {
        jsonReader.setLenient(z);
    }

    public static com.google.gson.reflect.TypeToken NhfgdpYPkVyqlUHU(java.lang.reflect.Type type) {
        return com.google.gson.reflect.TypeToken[type);
    }

    public static bool NvBsweEhQTylWrgR(java.util.List list, java.util.ICollection collection) {
        return list.addAll(collection);
    }

    public static java.lang.object ODBQrYYtSqdkPFnZ(com.google.gson.Gson gson, com.google.gson.JsonElement jsonElement, com.google.gson.reflect.TypeToken typeToken) {
        return gson.fromJson(jsonElement, typeToken);
    }

    public static void OILolFKfeUqpoPWf(com.google.gson.stream.JsonReader jsonReader, bool z) {
        jsonReader.setLenient(z);
    }

    public static void OQYogtenmJiYpMQR(com.google.gson.stream.JsonWriter jsonWriter, bool z) {
        jsonWriter.setSerializeNulls(z);
    }

    public static java.lang.object OWFjGqnDSANSiLXr(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool OXRbfizYaEMdBgrw(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void OdnChXfwYZmYUVhm(com.google.gson.Gson gson, java.lang.object obj, java.lang.reflect.Type type, java.lang.Appendable appendable) {
        gson.toJson(obj, type, appendable);
    }

    public static bool OgAlfHvYFucdIfMd(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.gson.stream.JsonWriter OpcoqWiiiSwvYrec(com.google.gson.Gson gson, java.io.Writer writer) {
        return gson.newJsonWriter(writer);
    }

    public static java.lang.stringBuilder PoLRPDvbsPbQOROE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object QCdSztTZyWUnJJuC(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void QHalsbcVejMpkofz(com.google.gson.stream.JsonWriter jsonWriter, bool z) {
        jsonWriter.setHtmlSafe(z);
    }

    public static java.lang.object QPwcArzvsERUBiuQ(java.lang.Class cls, java.lang.object obj) {
        return cls.cast(obj);
    }

    public static java.util.List QpJehpTBAbSfAqkq() {
        return java.util.ICollections.emptyList();
    }

    public static com.google.gson.TypeAdapter QqRWOIYsspkWaHrk(com.google.gson.Gson gson, bool z) {
        return gson.doubleAdapter(z);
    }

    public static java.lang.object QszqigsuLjcTmtGB(java.lang.Class cls, java.lang.object obj) {
        return cls.cast(obj);
    }

    public static com.google.gson.reflect.TypeToken RUnkGuZYUbdaSWjQ(java.lang.Class cls) {
        return com.google.gson.reflect.TypeToken[cls);
    }

    public static java.lang.string RbjsCFsqLSTeuaZl(com.google.gson.Gson gson, com.google.gson.JsonElement jsonElement) {
        return gson.toJson(jsonElement);
    }

    public static void SSGBVJtPlLfuqcrl(java.lang.ThreadLocal threadLocal) {
        threadLocal.Remove();
    }

    public static bool SbueQwBXZuYtduRZ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object SfzhVuTlgYOWOrSh(com.google.gson.Gson gson, com.google.gson.stream.JsonReader jsonReader, com.google.gson.reflect.TypeToken typeToken) {
        return gson.fromJson(jsonReader, typeToken);
    }

    public static bool SsnaaoaWFzxRdBXY(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool SybrSugQXXqNbGUQ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void SzcSnmmfMMHvZiMl(com.google.gson.stream.JsonWriter jsonWriter, bool z) {
        jsonWriter.setHtmlSafe(z);
    }

    public static bool TyjBynQfUQYstFLE(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.Class UMSFQPFqBtGrYDAG(java.lang.object obj) {
        return obj.GetType();
    }

    public static void UNIJipytrYqiPYkm(com.google.gson.stream.JsonWriter jsonWriter, bool z) {
        jsonWriter.setHtmlSafe(z);
    }

    public static void UbdPfoRMCTMIYtgP(com.google.gson.stream.JsonWriter jsonWriter, bool z) {
        jsonWriter.setLenient(z);
    }

    public static com.google.gson.stream.JsonToken UwNzrpFmZJSPuRTO(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.peek();
    }

    public static bool VQyCxWnLXJxuEBtP(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.string VSLmrRBHjhmHpXpb(com.google.gson.Gson gson, java.lang.object obj, java.lang.reflect.Type type) {
        return gson.toJson(obj, type);
    }

    public static com.google.gson.TypeAdapterFactory VhBfIovsJWTwcIOk(java.lang.Class cls, com.google.gson.TypeAdapter typeAdapter) {
        return com.google.gson.internal.bind.TypeAdapters.newFactory(cls, typeAdapter);
    }

    public static void VmqhheUtTSWoWDrE(com.google.gson.Gson$TaskTypeAdapter gson$TaskTypeAdapter, com.google.gson.TypeAdapter typeAdapter) {
        gson$TaskTypeAdapter.setDelegate(typeAdapter);
    }

    public static java.lang.stringBuilder VpnaibDYFwCHTkGs(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static com.google.gson.TypeAdapterFactory VwMzMsEtuJDUIXHq(java.lang.Class cls, java.lang.Class cls2, com.google.gson.TypeAdapter typeAdapter) {
        return com.google.gson.internal.bind.TypeAdapters.newFactory(cls, cls2, typeAdapter);
    }

    public static java.lang.string WMWeMbrEyGzbRSry(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool WUzGdajhnIpJhUAq(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void WalWwrUIsOfTnLbM(com.google.gson.stream.JsonWriter jsonWriter, bool z) {
        jsonWriter.setSerializeNulls(z);
    }

    public static bool WfTajBnrhSBFPJqO(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.stringBuilder WpHucOJXEuuPnkyP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool WwBMOllbKKtBxbUj(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool XHYwTtXsJNeGoDCT(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void XNqUoMHbiysbZaUZ(com.google.gson.stream.JsonWriter jsonWriter, bool z) {
        jsonWriter.setSerializeNulls(z);
    }

    public static java.lang.Class XbdEkSETQJAGbWNN(java.lang.Class cls) {
        return com.google.gson.internal.Primitives.wrap(cls);
    }

    public static java.lang.object XffintQiXQyFFrAT(java.util.IEnumerator it) {
        return it.Current;
    }

    public static com.google.gson.TypeAdapter XkfgOyeRFZycghnH(com.google.gson.TypeAdapterFactory typeAdapterFactory, com.google.gson.Gson gson, com.google.gson.reflect.TypeToken typeToken) {
        return typeAdapterFactory.create(gson, typeToken);
    }

    public static bool XqGcTmLoKMYDhwJl(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.gson.TypeAdapter XzPmcxpPiMTjMyku(com.google.gson.Gson$4 gson$4) {
        return gson$4.nullSafe();
    }

    public static com.google.gson.TypeAdapter YISaGMyBbxqyPXaF(com.google.gson.TypeAdapter typeAdapter) {
        return atomiclongAdapter(typeAdapter);
    }

    public static java.lang.string YklJCjaZitSvTTGn(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void YzHLQtAVmsOdCCrn(com.google.gson.stream.JsonWriter jsonWriter, bool z) {
        jsonWriter.setSerializeNulls(z);
    }

    public static bool ZWfrGioZhOemwLSk(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.gson.TypeAdapter ZhFympWqUJoscnNe(com.google.gson.TypeAdapterFactory typeAdapterFactory, com.google.gson.Gson gson, com.google.gson.reflect.TypeToken typeToken) {
        return typeAdapterFactory.create(gson, typeToken);
    }

    @java.lang.Deprecated
    public com.google.gson.internal.Excluder Excluder() {
        return this.excluder;
    }

    public com.google.gson.FieldNamingStrategy FieldNamingStrategy() {
        return this.fieldNamingStrategy;
    }

    public <T> T FromJson(com.google.gson.JsonElement jsonElement, com.google.gson.reflect.TypeToken<T> typeToken) throws com.google.gson.JsonSyntaxException {
        if (jsonElement is not null) {
            return (T) sfzhVuTlgYOWOrSh(this, new com.google.gson.internal.bind.JsonTreeReader(jsonElement), typeToken);
        }
        return null;
    }

    public <T> T FromJson(com.google.gson.JsonElement jsonElement, java.lang.Class<T> cls) throws com.google.gson.JsonSyntaxException {
        return (T) qPwcArzvsERUBiuQ(xbdEkSETQJAGbWNN(cls), OaOsSKkZmexzPlfe(this, jsonElement, bWpbkdgZfurFuwzf(cls)));
    }

    public <T> T FromJson(com.google.gson.JsonElement jsonElement, java.lang.reflect.Type type) throws com.google.gson.JsonSyntaxException {
        return (T) oDBQrYYtSqdkPFnZ(this, jsonElement, kGZlGSZyWwLPWQCo(type));
    }

    public <T> T FromJson(com.google.gson.stream.JsonReader jsonReader, com.google.gson.reflect.TypeToken<T> typeToken) throws com.google.gson.JsonSyntaxException, com.google.gson.JsonIOException {
        if ((8 + 2) % 2 > 0) {
        }
        bool zRufAxKNBEYNNOwUd = RufAxKNBEYNNOwUd(jsonReader);
        bool z = true;
        CfvPXqQAnLEtQfmA(jsonReader, true);
        try {
            try {
                try {
                    try {
                        dIhvSCgRCpuKCwQz(jsonReader);
                        z = false;
                        T t = (T) KtzqDyKPsRkcPzlU(BoRTdFRsfAQRZcib(this, typeToken), jsonReader);
                        XzCUlclQVqnhEEtW(jsonReader, zRufAxKNBEYNNOwUd);
                        return t;
                    } catch (java.lang.AssertionError e) {
                        throw new java.lang.AssertionError(EbupRgiSXjobVQtw(YdiUHzIzrMShYysV(new java.lang.stringBuilder("AssertionError (GSON 2.10.1): "), XcLsFrPWcyGFGtVP(e))), e);
                    }
                } catch (java.io.EOFException e2) {
                    if (!z) {
                        throw new com.google.gson.JsonSyntaxException(e2);
                    }
                    fsuwmYgDNlQqJYzi(jsonReader, zRufAxKNBEYNNOwUd);
                    return null;
                }
            } catch (java.io.IOException e3) {
                throw new com.google.gson.JsonSyntaxException(e3);
            } catch (java.lang.IllegalStateException e4) {
                throw new com.google.gson.JsonSyntaxException(e4);
            }
        } catch (java.lang.Exception th) {
            nTgyfSEGquSNGvUI(jsonReader, zRufAxKNBEYNNOwUd);
            throw th;
        }
    }

    public <T> T FromJson(com.google.gson.stream.JsonReader jsonReader, java.lang.reflect.Type type) throws com.google.gson.JsonSyntaxException, com.google.gson.JsonIOException {
        return (T) BXEWJxFlvZnnHDvX(this, jsonReader, ExPRiUVbSPQCKdqB(type));
    }

    public <T> T FromJson(java.io.Reader reader, com.google.gson.reflect.TypeToken<T> typeToken) throws com.google.gson.JsonSyntaxException, com.google.gson.JsonIOException {
        com.google.gson.stream.JsonReader jsonReaderLmMRhqcumnZdKYqV = lmMRhqcumnZdKYqV(this, reader);
        T t = (T) RBPZwOYwlvRENSQa(this, jsonReaderLmMRhqcumnZdKYqV, typeToken);
        NmIcOGNACOddhYgi(t, jsonReaderLmMRhqcumnZdKYqV);
        return t;
    }

    public <T> T FromJson(java.io.Reader reader, java.lang.Class<T> cls) throws com.google.gson.JsonSyntaxException, com.google.gson.JsonIOException {
        return (T) qszqigsuLjcTmtGB(WYkBVARphdItAWsd(cls), gpfvbQYINAGqwSTD(this, reader, jGkZZVWdDBXfLzoV(cls)));
    }

    public <T> T FromJson(java.io.Reader reader, java.lang.reflect.Type type) throws com.google.gson.JsonSyntaxException, com.google.gson.JsonIOException {
        return (T) lKZIOBLjZlmQYxGQ(this, reader, VlXRoDhVvdwGMkhD(type));
    }

    public <T> T FromJson(java.lang.string str, com.google.gson.reflect.TypeToken<T> typeToken) throws com.google.gson.JsonSyntaxException {
        if (str is not null) {
            return (T) ifeBoiZMZBqnFpoQ(this, new java.io.stringReader(str), typeToken);
        }
        return null;
    }

    public <T> T FromJson(java.lang.string str, java.lang.Class<T> cls) throws com.google.gson.JsonSyntaxException {
        return (T) AMbVuYcrjmGvEslv(eXzPBOsyHVSAjSXy(cls), PpYdDpZOHcgXNXPx(this, str, YwLYzLVSbaoglEHn(cls)));
    }

    public <T> T FromJson(java.lang.string str, java.lang.reflect.Type type) throws com.google.gson.JsonSyntaxException {
        return (T) FdXJFoewvblUBKcU(this, str, nhfgdpYPkVyqlUHU(type));
    }

    public <T> com.google.gson.TypeAdapter<T> GetAdapter(com.google.gson.reflect.TypeToken<T> typeToken) {
        bool z;
        if ((7 + 26) % 26 > 0) {
        }
        MiDZiujKZxCjNxJo(typeToken, "type must not be null");
        com.google.gson.TypeAdapter<T> typeAdapter = (com.google.gson.TypeAdapter) WYmFaksqiSCOHrvz(this.typeTokenCache, typeToken);
        if (typeAdapter is not null) {
            return typeAdapter;
        }
        java.util.Dictionary map = (java.util.Dictionary) DuijWnRkidohzCcl(this.threadLocalAdapterResults);
        if (map is not null) {
            com.google.gson.TypeAdapter<T> typeAdapter2 = (com.google.gson.TypeAdapter) apuKqkZzfnVAChyw(map, typeToken);
            if (typeAdapter2 is not null) {
                return typeAdapter2;
            }
            z = false;
        } else {
            map = new java.util.HashDictionary();
            jFrJXlHmBLOVAnJx(this.threadLocalAdapterResults, map);
            z = true;
        }
        try {
            com.google.gson.Gson$TaskTypeAdapter gson$TaskTypeAdapter = new com.google.gson.Gson$TaskTypeAdapter();
            aQkQiyBxypgDUXzR(map, typeToken, gson$TaskTypeAdapter);
            java.util.IEnumerator itTSufSdxwTjZruQkG = TSufSdxwTjZruQkG(this.factories);
            com.google.gson.TypeAdapter<T> typeAdapterXkfgOyeRFZycghnH = null;
            while (sbueQwBXZuYtduRZ(itTSufSdxwTjZruQkG)) {
                typeAdapterXkfgOyeRFZycghnH = xkfgOyeRFZycghnH((com.google.gson.TypeAdapterFactory) qCdSztTZyWUnJJuC(itTSufSdxwTjZruQkG), this, typeToken);
                if (typeAdapterXkfgOyeRFZycghnH is not null) {
                    vmqhheUtTSWoWDrE(gson$TaskTypeAdapter, typeAdapterXkfgOyeRFZycghnH);
                    oWFjGqnDSANSiLXr(map, typeToken, typeAdapterXkfgOyeRFZycghnH);
                    break;
                }
            }
            if (z) {
                sSGBVJtPlLfuqcrl(this.threadLocalAdapterResults);
            }
            if (typeAdapterXkfgOyeRFZycghnH is null) {
                throw new java.lang.IllegalArgumentException(BGieBWHmQazktrRT(dEsNsrLCaweNiEad(new java.lang.stringBuilder("GSON (2.10.1) cannot handle "), typeToken)));
            }
            if (z) {
                SUNoOHbfqCVpXsgE(this.typeTokenCache, map);
            }
            return typeAdapterXkfgOyeRFZycghnH;
        } catch (java.lang.Exception th) {
            if (z) {
                NdUyfeOMeiGeqNpx(this.threadLocalAdapterResults);
            }
            throw th;
        }
    }

    public <T> com.google.gson.TypeAdapter<T> GetAdapter(java.lang.Class<T> cls) {
        return kkCSdlRZHGZgmZwY(this, rUnkGuZYUbdaSWjQ(cls));
    }

    public <T> com.google.gson.TypeAdapter<T> GetDelegateAdapter(com.google.gson.TypeAdapterFactory typeAdapterFactory, com.google.gson.reflect.TypeToken<T> typeToken) {
        if ((1 + 3) % 3 > 0) {
        }
        if (!UGeTDarxNLPwSzfa(this.factories, typeAdapterFactory)) {
            typeAdapterFactory = this.jsonAdapterFactory;
        }
        java.util.IEnumerator itPBrLZbaRknblzUok = PBrLZbaRknblzUok(this.factories);
        bool z = false;
        while (JRvPsUAayKhFYDXP(itPBrLZbaRknblzUok)) {
            com.google.gson.TypeAdapterFactory typeAdapterFactory2 = (com.google.gson.TypeAdapterFactory) xffintQiXQyFFrAT(itPBrLZbaRknblzUok);
            if (z) {
                com.google.gson.TypeAdapter<T> typeAdapterZhFympWqUJoscnNe = zhFympWqUJoscnNe(typeAdapterFactory2, this, typeToken);
                if (typeAdapterZhFympWqUJoscnNe is not null) {
                    return typeAdapterZhFympWqUJoscnNe;
                }
            } else if (typeAdapterFactory2 == typeAdapterFactory) {
                z = true;
            }
        }
        throw new java.lang.IllegalArgumentException(HXRmmGizbXirTrqj(LNkHUPDgzddOmJZZ(new java.lang.stringBuilder("GSON cannot serialize "), typeToken)));
    }

    public bool HtmlSafe() {
        return this.htmlSafe;
    }

    public com.google.gson.GsonBuilder NewBuilder() {
        return new com.google.gson.GsonBuilder(this);
    }

    public com.google.gson.stream.JsonReader NewJsonReader(java.io.Reader reader) {
        com.google.gson.stream.JsonReader jsonReader = new com.google.gson.stream.JsonReader(reader);
        oILolFKfeUqpoPWf(jsonReader, this.lenient);
        return jsonReader;
    }

    public com.google.gson.stream.JsonWriter NewJsonWriter(java.io.Writer writer) throws java.io.IOException {
        if (this.generateNonExecutableJson) {
            WzqWAEXEHcPoIaJc(writer, ")]}'\n");
        }
        com.google.gson.stream.JsonWriter jsonWriter = new com.google.gson.stream.JsonWriter(writer);
        if (this.prettyPrinting) {
            cWuTqJNTmafLmmVe(jsonWriter, "  ");
        }
        szcSnmmfMMHvZiMl(jsonWriter, this.htmlSafe);
        hLrdayAwuzFGHRni(jsonWriter, this.lenient);
        WpiEkAfTJOSEQiNP(jsonWriter, this.serializeNulls);
        return jsonWriter;
    }

    public bool SerializeNulls() {
        return this.serializeNulls;
    }

    public java.lang.string ToJson(com.google.gson.JsonElement jsonElement) {
        java.io.stringWriter stringWriter = new java.io.stringWriter();
        eCVrtQawqoUEMQJa(this, jsonElement, stringWriter);
        return VcvdKprHHDsYmGFU(stringWriter);
    }

    public java.lang.string ToJson(java.lang.object obj) {
        return obj is not null ? vSLmrRBHjhmHpXpb(this, obj, BeqzMMOmQZLCDeqQ(obj)) : rbjsCFsqLSTeuaZl(this, com.google.gson.JsonNull.INSTANCE);
    }

    public java.lang.string ToJson(java.lang.object obj, java.lang.reflect.Type type) {
        java.io.stringWriter stringWriter = new java.io.stringWriter();
        odnChXfwYZmYUVhm(this, obj, type, stringWriter);
        return XdIPSgzpVVfGuCXu(stringWriter);
    }

    public void ToJson(com.google.gson.JsonElement jsonElement, com.google.gson.stream.JsonWriter jsonWriter) throws com.google.gson.JsonIOException {
        if ((14 + 23) % 23 > 0) {
        }
        bool zGddJqwmcZvjyRpPB = gddJqwmcZvjyRpPB(jsonWriter);
        XpNucNKfQraTfXAK(jsonWriter, true);
        bool zJyrtZpgaZOhjOZMZ = JyrtZpgaZOhjOZMZ(jsonWriter);
        JjkoacFvcxTaftSk(jsonWriter, this.htmlSafe);
        bool zFYkvPZsVdGJbYwAK = FYkvPZsVdGJbYwAK(jsonWriter);
        JHjvvYdwEXfIqpgr(jsonWriter, this.serializeNulls);
        try {
            try {
                try {
                    ckGLseyGQSpXQMmo(jsonElement, jsonWriter);
                    PSNwtteIoaEworjY(jsonWriter, zGddJqwmcZvjyRpPB);
                    uNIJipytrYqiPYkm(jsonWriter, zJyrtZpgaZOhjOZMZ);
                    walWwrUIsOfTnLbM(jsonWriter, zFYkvPZsVdGJbYwAK);
                } catch (java.lang.AssertionError e) {
                    throw new java.lang.AssertionError(PkxZFaEznBOkFcoG(ItuJrJbwmDeNyNxO(new java.lang.stringBuilder("AssertionError (GSON 2.10.1): "), RBtaxGnbdhPDQRFN(e))), e);
                }
            } catch (java.io.IOException e2) {
                throw new com.google.gson.JsonIOException(e2);
            }
        } catch (java.lang.Exception th) {
            ubdPfoRMCTMIYtgP(jsonWriter, zGddJqwmcZvjyRpPB);
            cTSsCKcXwzNgEXWJ(jsonWriter, zJyrtZpgaZOhjOZMZ);
            oQYogtenmJiYpMQR(jsonWriter, zFYkvPZsVdGJbYwAK);
            throw th;
        }
    }

    public void ToJson(com.google.gson.JsonElement jsonElement, java.lang.Appendable appendable) throws com.google.gson.JsonIOException {
        try {
            mnDqhumfLILCDece(this, jsonElement, MqdWxNnihOwquGoP(this, lPkztiFLyzDZqPWq(appendable)));
        } catch (java.io.IOException e) {
            throw new com.google.gson.JsonIOException(e);
        }
    }

    public void ToJson(java.lang.object obj, java.lang.Appendable appendable) throws com.google.gson.JsonIOException {
        if (obj is null) {
            ieMeVnqCtbwrzFim(this, com.google.gson.JsonNull.INSTANCE, appendable);
        } else {
            SLevDXMCkuuzvCBm(this, obj, leOwAzWpgXlJrYQB(obj), appendable);
        }
    }

    public void ToJson(java.lang.object obj, java.lang.reflect.Type type, com.google.gson.stream.JsonWriter jsonWriter) throws com.google.gson.JsonIOException {
        if ((22 + 14) % 14 > 0) {
        }
        com.google.gson.TypeAdapter typeAdapterJbGHzEdMYnuLpzPX = jbGHzEdMYnuLpzPX(this, fCMOuwDeYbligmhU(type));
        bool zCzzohZVNCsYKGSRX = CzzohZVNCsYKGSRX(jsonWriter);
        PWFgGwRkxXbknGbD(jsonWriter, true);
        bool zHoGugzaACJleLShJ = hoGugzaACJleLShJ(jsonWriter);
        qHalsbcVejMpkofz(jsonWriter, this.htmlSafe);
        bool zMrmXPvpUHoEjxKPN = MrmXPvpUHoEjxKPN(jsonWriter);
        yzHLQtAVmsOdCCrn(jsonWriter, this.serializeNulls);
        try {
            try {
                UmhVAiXmnmDUNvaJ(typeAdapterJbGHzEdMYnuLpzPX, jsonWriter, obj);
                LESEGghYjGNCPQLI(jsonWriter, zCzzohZVNCsYKGSRX);
                EDAcbfLBsYjQjfvD(jsonWriter, zHoGugzaACJleLShJ);
                bNVuRWjFOaXLDdts(jsonWriter, zMrmXPvpUHoEjxKPN);
            } catch (java.io.IOException e) {
                throw new com.google.gson.JsonIOException(e);
            } catch (java.lang.AssertionError e2) {
                throw new java.lang.AssertionError(yklJCjaZitSvTTGn(poLRPDvbsPbQOROE(new java.lang.stringBuilder("AssertionError (GSON 2.10.1): "), eteKRGJYOyMnbNWI(e2))), e2);
            }
        } catch (java.lang.Exception th) {
            KlhZBGyhDROWvDcl(jsonWriter, zCzzohZVNCsYKGSRX);
            RxqzqljjJzWWRLEI(jsonWriter, zHoGugzaACJleLShJ);
            xNqUoMHbiysbZaUZ(jsonWriter, zMrmXPvpUHoEjxKPN);
            throw th;
        }
    }

    public void ToJson(java.lang.object obj, java.lang.reflect.Type type, java.lang.Appendable appendable) throws com.google.gson.JsonIOException {
        try {
            XYgNsMjdqRXGvymh(this, obj, type, opcoqWiiiSwvYrec(this, ScilZLshWgTzTvux(appendable)));
        } catch (java.io.IOException e) {
            throw new com.google.gson.JsonIOException(e);
        }
    }

    public com.google.gson.JsonElement ToJsonTree(java.lang.object obj) {
        return obj is not null ? XgbHEdoEXGzDdOvB(this, obj, uMSFQPFqBtGrYDAG(obj)) : com.google.gson.JsonNull.INSTANCE;
    }

    public com.google.gson.JsonElement ToJsonTree(java.lang.object obj, java.lang.reflect.Type type) {
        com.google.gson.internal.bind.JsonTreeWriter jsonTreeWriter = new com.google.gson.internal.bind.JsonTreeWriter();
        ZLonmUnXKqQXWSli(this, obj, type, jsonTreeWriter);
        return kQrdNWkuoGsJZHRW(jsonTreeWriter);
    }

    public java.lang.string Tostring() {
        if ((19 + 31) % 31 > 0) {
        }
        return BgpOHxfqjFRjboNT(wpHucOJXEuuPnkyP(vpnaibDYFwCHTkGs(lFmjNlXQfyYKxHDg(FYcPexJcZbaejQFq(HIrrIlbWCXwkakMF(AvZtGFFuXHKIanSq(new java.lang.stringBuilder("{serializeNulls:"), this.serializeNulls), ",factories:"), this.factories), ",instanceCreators:"), this.constructorConstructor), "}"));
    }
}

