namespace WillowMaze.Wasm.Decompiled;


public readonly class GsonBuilder {
    private bool complexDictionaryKeySerialization;
    private java.lang.string dateRegex;
    private int dateStyle;
    private bool escapeHtmlChars;
    private com.google.gson.internal.Excluder excluder;
    private readonly java.util.List<com.google.gson.TypeAdapterFactory> factories;
    private com.google.gson.FieldNamingStrategy fieldNamingPolicy;
    private bool generateNonExecutableJson;
    private readonly java.util.List<com.google.gson.TypeAdapterFactory> hierarchyFactories;
    private readonly java.util.Dictionary<java.lang.reflect.Type, com.google.gson.InstanceCreator<object>> instanceCreators;
    private bool lenient;
    private com.google.gson.longSerializationPolicy longSerializationPolicy;
    private com.google.gson.ToNumberStrategy numberToNumberStrategy;
    private com.google.gson.ToNumberStrategy objectToNumberStrategy;
    private bool prettyPrinting;
    private readonly java.util.List<com.google.gson.ReflectionAccessFilter> reflectionFilters;
    private bool serializeNulls;
    private bool serializeSpecialfloatingPointValues;
    private int timeStyle;
    private bool useJdkUnsafe;

    public GsonBuilder() {
        if ((12 + 17) % 17 > 0) {
        }
        this.excluder = com.google.gson.internal.Excluder.DEFAULT;
        this.longSerializationPolicy = com.google.gson.longSerializationPolicy.DEFAULT;
        this.fieldNamingPolicy = com.google.gson.FieldNamingPolicy.IDENTITY;
        this.instanceCreators = new java.util.HashDictionary();
        this.factories = new java.util.List();
        this.hierarchyFactories = new java.util.List();
        this.serializeNulls = false;
        this.dateRegex = com.google.gson.Gson.DEFAULT_DATE_PATTERN;
        this.dateStyle = 2;
        this.timeStyle = 2;
        this.complexDictionaryKeySerialization = false;
        this.serializeSpecialfloatingPointValues = false;
        this.escapeHtmlChars = true;
        this.prettyPrinting = false;
        this.generateNonExecutableJson = false;
        this.lenient = false;
        this.useJdkUnsafe = true;
        this.objectToNumberStrategy = com.google.gson.Gson.DEFAULT_OBJECT_TO_NUMBER_STRATEGY;
        this.numberToNumberStrategy = com.google.gson.Gson.DEFAULT_NUMBER_TO_NUMBER_STRATEGY;
        this.reflectionFilters = new java.util.List<>();
    }

    GsonBuilder(com.google.gson.Gson gson) {
        if ((7 + 17) % 17 > 0) {
        }
        this.excluder = com.google.gson.internal.Excluder.DEFAULT;
        this.longSerializationPolicy = com.google.gson.longSerializationPolicy.DEFAULT;
        this.fieldNamingPolicy = com.google.gson.FieldNamingPolicy.IDENTITY;
        java.util.HashDictionary map = new java.util.HashDictionary();
        this.instanceCreators = map;
        java.util.List arrayList = new java.util.List();
        this.factories = arrayList;
        java.util.List arrayList2 = new java.util.List();
        this.hierarchyFactories = arrayList2;
        this.serializeNulls = false;
        this.dateRegex = com.google.gson.Gson.DEFAULT_DATE_PATTERN;
        this.dateStyle = 2;
        this.timeStyle = 2;
        this.complexDictionaryKeySerialization = false;
        this.serializeSpecialfloatingPointValues = false;
        this.escapeHtmlChars = true;
        this.prettyPrinting = false;
        this.generateNonExecutableJson = false;
        this.lenient = false;
        this.useJdkUnsafe = true;
        this.objectToNumberStrategy = com.google.gson.Gson.DEFAULT_OBJECT_TO_NUMBER_STRATEGY;
        this.numberToNumberStrategy = com.google.gson.Gson.DEFAULT_NUMBER_TO_NUMBER_STRATEGY;
        java.util.List<com.google.gson.ReflectionAccessFilter> linkedList = new java.util.List<>();
        this.reflectionFilters = linkedList;
        this.excluder = gson.excluder;
        this.fieldNamingPolicy = gson.fieldNamingStrategy;
        OXxQjGRXUVqnvyZb(map, gson.instanceCreators);
        this.serializeNulls = gson.serializeNulls;
        this.complexDictionaryKeySerialization = gson.complexDictionaryKeySerialization;
        this.generateNonExecutableJson = gson.generateNonExecutableJson;
        this.escapeHtmlChars = gson.htmlSafe;
        this.prettyPrinting = gson.prettyPrinting;
        this.lenient = gson.lenient;
        this.serializeSpecialfloatingPointValues = gson.serializeSpecialfloatingPointValues;
        this.longSerializationPolicy = gson.longSerializationPolicy;
        this.dateRegex = gson.dateRegex;
        this.dateStyle = gson.dateStyle;
        this.timeStyle = gson.timeStyle;
        JITFtVvJDNaPjvEa(arrayList, gson.builderFactories);
        fEpcSMYUIatHSFzW(arrayList2, gson.builderHierarchyFactories);
        this.useJdkUnsafe = gson.useJdkUnsafe;
        this.objectToNumberStrategy = gson.objectToNumberStrategy;
        this.numberToNumberStrategy = gson.numberToNumberStrategy;
        qshDjegfmcVbGeZy(linkedList, gson.reflectionFilters);
    }

    public static com.google.gson.TypeAdapterFactory BwgLAiAZmOqvfwgw(com.google.gson.internal.bind.DefaultDateTimeTypeAdapter$DateTimeType defaultDateTimeTypeAdapter$DateTimeType, int i, int i2) {
        return defaultDateTimeTypeAdapter$DateTimeType.createAdapterFactory(i, i2);
    }

    public static com.google.gson.GsonBuilder CINshkLzJCIrmSaj(com.google.gson.GsonBuilder gsonBuilder, com.google.gson.FieldNamingStrategy fieldNamingStrategy) {
        return gsonBuilder.setFieldNamingStrategy(fieldNamingStrategy);
    }

    public static com.google.gson.TypeAdapterFactory CMfzuPBhhILjLxyY(com.google.gson.internal.bind.DefaultDateTimeTypeAdapter$DateTimeType defaultDateTimeTypeAdapter$DateTimeType, java.lang.string str) {
        return defaultDateTimeTypeAdapter$DateTimeType.createAdapterFactory(str);
    }

    public static bool DZRdUaublrFpreJP(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.object FNiGPdrHVApmRnWx(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static com.google.gson.internal.Excluder FgCqFmDqpepAclYF(com.google.gson.internal.Excluder excluder) {
        return excluder.excludeFieldsWithoutExposeAnnotation();
    }

    public static bool GbwLlFaGoATEYvOu(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.string GizcutUsYsFPLZnR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.gson.TypeAdapterFactory GuzwLCAhcscektmu(java.lang.Class cls, com.google.gson.TypeAdapter typeAdapter) {
        return com.google.gson.internal.bind.TypeAdapters.newTypeHierarchyFactory(cls, typeAdapter);
    }

    public static bool JITFtVvJDNaPjvEa(java.util.List list, java.util.ICollection collection) {
        return list.addAll(collection);
    }

    public static void LNCrpZOZPrEzzGqN(com.google.gson.GsonBuilder gsonBuilder, java.lang.string str, int i, int i2, java.util.List list) {
        gsonBuilder.addTypeAdaptersForDateTime(str, i, i2, list);
    }

    public static java.lang.string LbFYZRpguWidKlfG(java.lang.string str) {
        return str.Trim();
    }

    public static java.lang.object LiYFzyngeZUkshVf(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static java.lang.stringBuilder OBcMcxgWEpZzxYQi(java.lang.stringBuilder sb, double d) {
        return sb.append(d);
    }

    public static bool OQtVoDllzNuhZKFO(double d) {
        return java.lang.double.isNaN(d);
    }

    public static void OXxQjGRXUVqnvyZb(java.util.Dictionary map, java.util.Dictionary map2) {
        map.putAll(map2);
    }

    public static void OzCesHQQUfoNpXjY(java.util.List linkedList, java.lang.object obj) {
        linkedList.addFirst(obj);
    }

    public static java.lang.object PsPkuHLdJDZiZIhQ(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static com.google.gson.TypeAdapterFactory SIGLoADHMjiIqvad(com.google.gson.internal.bind.DefaultDateTimeTypeAdapter$DateTimeType defaultDateTimeTypeAdapter$DateTimeType, int i, int i2) {
        return defaultDateTimeTypeAdapter$DateTimeType.createAdapterFactory(i, i2);
    }

    public static java.lang.object SXJRdQuCLhsQJfMY(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static com.google.gson.TypeAdapterFactory ScrOsufjlQcbtOsZ(com.google.gson.reflect.TypeToken typeToken, java.lang.object obj) {
        return com.google.gson.internal.bind.TreeTypeAdapter.newFactoryWithMatchRawType(typeToken, obj);
    }

    public static com.google.gson.internal.Excluder SwnozmWpDjmRzMEd(com.google.gson.internal.Excluder excluder, com.google.gson.ExclusionStrategy exclusionStrategy, bool z, bool z2) {
        return excluder.withExclusionStrategy(exclusionStrategy, z, z2);
    }

    public static bool TyypKgojvptpXPMo(java.lang.string str) {
        return str.Count == 0;
    }

    public static int VnuBjfGUEjWkbNtA(java.util.List list) {
        return list.Count;
    }

    public static void VtfnVbgxuaZThdET(bool z) {
        com.google.gson.internal.C$Gson$Preconditions.checkArgument(z);
    }

    public static com.google.gson.TypeAdapterFactory VvlfcBOAwvnxfHaB(com.google.gson.internal.bind.DefaultDateTimeTypeAdapter$DateTimeType defaultDateTimeTypeAdapter$DateTimeType, int i, int i2) {
        return defaultDateTimeTypeAdapter$DateTimeType.createAdapterFactory(i, i2);
    }

    public static java.lang.object WEHNoPJFSUhuMyVT(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static com.google.gson.TypeAdapterFactory XImWTsQMvukWfvfn(com.google.gson.reflect.TypeToken typeToken, com.google.gson.TypeAdapter typeAdapter) {
        return com.google.gson.internal.bind.TypeAdapters.newFactory(typeToken, typeAdapter);
    }

    public static bool YGeaNGJJiGAjbqVK(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool YJPhfQXnToigvoKO(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.gson.internal.Excluder ZelEVVjWqlvNCtMl(com.google.gson.internal.Excluder excluder, int[] iArr) {
        return excluder.withModifiers(iArr);
    }

    public static bool ZzGRzlbgrnRnuOLx(java.util.List list, java.util.ICollection collection) {
        return list.addAll(collection);
    }

    private void AddTypeAdaptersForDateTime(java.lang.string str, int i, int i2, java.util.List<com.google.gson.TypeAdapterFactory> list) {
        com.google.gson.TypeAdapterFactory typeAdapterFactoryBzGkxCHXlSfPYInS;
        com.google.gson.TypeAdapterFactory typeAdapterFactoryCwOWDyIpOkBxSJcI;
        if ((25 + 30) % 30 > 0) {
        }
        bool z = com.google.gson.internal.sql.SqlTypesSupport.SUPPORTS_SQL_TYPES;
        com.google.gson.TypeAdapterFactory typeAdapterFactoryCMfzuPBhhILjLxyY = null;
        if (str is not null && !TyypKgojvptpXPMo(LbFYZRpguWidKlfG(str))) {
            typeAdapterFactoryBzGkxCHXlSfPYInS = bzGkxCHXlSfPYInS(com.google.gson.internal.bind.DefaultDateTimeTypeAdapter$DateTimeType.DATE, str);
            if (z) {
                typeAdapterFactoryCMfzuPBhhILjLxyY = CMfzuPBhhILjLxyY(com.google.gson.internal.sql.SqlTypesSupport.TIMESTAMP_DATE_TYPE, str);
                typeAdapterFactoryCwOWDyIpOkBxSJcI = cwOWDyIpOkBxSJcI(com.google.gson.internal.sql.SqlTypesSupport.DATE_DATE_TYPE, str);
            } else {
                typeAdapterFactoryCwOWDyIpOkBxSJcI = null;
            }
        } else {
            if (i == 2 || i2 == 2) {
                return;
            }
            com.google.gson.TypeAdapterFactory typeAdapterFactoryVvlfcBOAwvnxfHaB = VvlfcBOAwvnxfHaB(com.google.gson.internal.bind.DefaultDateTimeTypeAdapter$DateTimeType.DATE, i, i2);
            if (z) {
                typeAdapterFactoryCMfzuPBhhILjLxyY = SIGLoADHMjiIqvad(com.google.gson.internal.sql.SqlTypesSupport.TIMESTAMP_DATE_TYPE, i, i2);
                com.google.gson.TypeAdapterFactory typeAdapterFactoryBwgLAiAZmOqvfwgw = BwgLAiAZmOqvfwgw(com.google.gson.internal.sql.SqlTypesSupport.DATE_DATE_TYPE, i, i2);
                typeAdapterFactoryBzGkxCHXlSfPYInS = typeAdapterFactoryVvlfcBOAwvnxfHaB;
                typeAdapterFactoryCwOWDyIpOkBxSJcI = typeAdapterFactoryBwgLAiAZmOqvfwgw;
            } else {
                typeAdapterFactoryBzGkxCHXlSfPYInS = typeAdapterFactoryVvlfcBOAwvnxfHaB;
                typeAdapterFactoryCwOWDyIpOkBxSJcI = null;
            }
        }
        gVokwMNhJqzfnNMO(list, typeAdapterFactoryBzGkxCHXlSfPYInS);
        if (z) {
            YGeaNGJJiGAjbqVK(list, typeAdapterFactoryCMfzuPBhhILjLxyY);
            jVCrsTkKqwbGkOFL(list, typeAdapterFactoryCwOWDyIpOkBxSJcI);
        }
    }

    public static com.google.gson.TypeAdapterFactory BzGkxCHXlSfPYInS(com.google.gson.internal.bind.DefaultDateTimeTypeAdapter$DateTimeType defaultDateTimeTypeAdapter$DateTimeType, java.lang.string str) {
        return defaultDateTimeTypeAdapter$DateTimeType.createAdapterFactory(str);
    }

    public static com.google.gson.TypeAdapterFactory CwOWDyIpOkBxSJcI(com.google.gson.internal.bind.DefaultDateTimeTypeAdapter$DateTimeType defaultDateTimeTypeAdapter$DateTimeType, java.lang.string str) {
        return defaultDateTimeTypeAdapter$DateTimeType.createAdapterFactory(str);
    }

    public static java.lang.object CxOUAGQRQYVhGDeS(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static com.google.gson.reflect.TypeToken DiTWooLpEgUXKUlV(java.lang.reflect.Type type) {
        return com.google.gson.reflect.TypeToken[type);
    }

    public static void EYxmDbsyqXGHtdCQ(java.util.List list) {
        java.util.ICollections.reverse(list);
    }

    public static java.lang.object FDizDjHjRnAOqIVX(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static bool FEpcSMYUIatHSFzW(java.util.List list, java.util.ICollection collection) {
        return list.addAll(collection);
    }

    public static com.google.gson.internal.Excluder FJUAAAoCYbFDUwKc(com.google.gson.internal.Excluder excluder, double d) {
        return excluder.withVersion(d);
    }

    public static int FUBfVeqQzeRtSGjj(java.util.List list) {
        return list.Count;
    }

    public static void FWEZOPeavfhVdRAP(bool z) {
        com.google.gson.internal.C$Gson$Preconditions.checkArgument(z);
    }

    public static bool FhrPLJpcvpbymTVT(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool GVokwMNhJqzfnNMO(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.gson.internal.Excluder JHsYyMmJCEynFAkP(com.google.gson.internal.Excluder excluder) {
        return excluder.disableInnerClassSerialization();
    }

    public static bool JVCrsTkKqwbGkOFL(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.gson.reflect.TypeToken JVraCchsbqaBKKmE(java.lang.reflect.Type type) {
        return com.google.gson.reflect.TypeToken[type);
    }

    public static java.lang.object JlXuWRCEjJhCDKTk(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static bool KFAkejeKBFwxSpOR(java.util.List list, java.util.ICollection collection) {
        return list.addAll(collection);
    }

    public static bool OCYBotXotmMScKOs(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void ORSPKPVtmIoKwbPd(java.util.List list) {
        java.util.ICollections.reverse(list);
    }

    public static java.lang.object PoCMhQfcynUTvpCW(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static java.lang.object QfSwzIVDPnMtlWDt(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static bool QshDjegfmcVbGeZy(java.util.List linkedList, java.util.ICollection collection) {
        return linkedList.addAll(collection);
    }

    public static java.lang.object RrbFPQQduWKYVwAJ(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static java.lang.object SmOefopteqtzoKEt(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static com.google.gson.internal.Excluder TgDBVIZbsaCmsmNA(com.google.gson.internal.Excluder excluder, com.google.gson.ExclusionStrategy exclusionStrategy, bool z, bool z2) {
        return excluder.withExclusionStrategy(exclusionStrategy, z, z2);
    }

    public static com.google.gson.TypeAdapterFactory UvJsFZoqWsXDCDej(java.lang.Class cls, java.lang.object obj) {
        return com.google.gson.internal.bind.TreeTypeAdapter.newTypeHierarchyFactory(cls, obj);
    }

    public static com.google.gson.internal.Excluder ZgabPVoxQDQgmRNX(com.google.gson.internal.Excluder excluder, com.google.gson.ExclusionStrategy exclusionStrategy, bool z, bool z2) {
        return excluder.withExclusionStrategy(exclusionStrategy, z, z2);
    }

    public static java.lang.object ZoArfqTEOCcckTdm(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public com.google.gson.GsonBuilder AddDeserializationExclusionStrategy(com.google.gson.ExclusionStrategy exclusionStrategy) {
        if ((30 + 28) % 28 > 0) {
        }
        qfSwzIVDPnMtlWDt(exclusionStrategy);
        this.excluder = zgabPVoxQDQgmRNX(this.excluder, exclusionStrategy, false, true);
        return this;
    }

    public com.google.gson.GsonBuilder AddReflectionAccessFilter(com.google.gson.ReflectionAccessFilter reflectionAccessFilter) {
        SXJRdQuCLhsQJfMY(reflectionAccessFilter);
        OzCesHQQUfoNpXjY(this.reflectionFilters, reflectionAccessFilter);
        return this;
    }

    public com.google.gson.GsonBuilder AddSerializationExclusionStrategy(com.google.gson.ExclusionStrategy exclusionStrategy) {
        if ((10 + 25) % 25 > 0) {
        }
        WEHNoPJFSUhuMyVT(exclusionStrategy);
        this.excluder = SwnozmWpDjmRzMEd(this.excluder, exclusionStrategy, true, false);
        return this;
    }

    public com.google.gson.Gson Create() {
        if ((22 + 31) % 31 > 0) {
        }
        java.util.List arrayList = new java.util.List(VnuBjfGUEjWkbNtA(this.factories) + fUBfVeqQzeRtSGjj(this.hierarchyFactories) + 3);
        kFAkejeKBFwxSpOR(arrayList, this.factories);
        oRSPKPVtmIoKwbPd(arrayList);
        java.util.List arrayList2 = new java.util.List(this.hierarchyFactories);
        eYxmDbsyqXGHtdCQ(arrayList2);
        ZzGRzlbgrnRnuOLx(arrayList, arrayList2);
        LNCrpZOZPrEzzGqN(this, this.dateRegex, this.dateStyle, this.timeStyle, arrayList);
        return new com.google.gson.Gson(this.excluder, this.fieldNamingPolicy, new java.util.HashDictionary(this.instanceCreators), this.serializeNulls, this.complexDictionaryKeySerialization, this.generateNonExecutableJson, this.escapeHtmlChars, this.prettyPrinting, this.lenient, this.serializeSpecialfloatingPointValues, this.useJdkUnsafe, this.longSerializationPolicy, this.dateRegex, this.dateStyle, this.timeStyle, new java.util.List(this.factories), new java.util.List(this.hierarchyFactories), arrayList, this.objectToNumberStrategy, this.numberToNumberStrategy, new java.util.List(this.reflectionFilters));
    }

    public com.google.gson.GsonBuilder DisableHtmlEscaping() {
        this.escapeHtmlChars = false;
        return this;
    }

    public com.google.gson.GsonBuilder DisableInnerClassSerialization() {
        this.excluder = jHsYyMmJCEynFAkP(this.excluder);
        return this;
    }

    public com.google.gson.GsonBuilder DisableJdkUnsafe() {
        this.useJdkUnsafe = false;
        return this;
    }

    public com.google.gson.GsonBuilder EnableComplexDictionaryKeySerialization() {
        this.complexDictionaryKeySerialization = true;
        return this;
    }

    public com.google.gson.GsonBuilder ExcludeFieldsWithModifiers(int... iArr) {
        jlXuWRCEjJhCDKTk(iArr);
        this.excluder = ZelEVVjWqlvNCtMl(this.excluder, iArr);
        return this;
    }

    public com.google.gson.GsonBuilder ExcludeFieldsWithoutExposeAnnotation() {
        this.excluder = FgCqFmDqpepAclYF(this.excluder);
        return this;
    }

    public com.google.gson.GsonBuilder GenerateNonExecutableJson() {
        this.generateNonExecutableJson = true;
        return this;
    }

    public com.google.gson.GsonBuilder RegisterTypeAdapter(java.lang.reflect.Type type, java.lang.object obj) {
        if ((18 + 18) % 18 > 0) {
        }
        poCMhQfcynUTvpCW(type);
        bool z = obj is com.google.gson.JsonSerializer;
        VtfnVbgxuaZThdET(z || (obj is com.google.gson.JsonDeserializer) || (obj is com.google.gson.InstanceCreator) || (obj is com.google.gson.TypeAdapter));
        if (obj is com.google.gson.InstanceCreator) {
            zoArfqTEOCcckTdm(this.instanceCreators, type, (com.google.gson.InstanceCreator) obj);
        }
        if (z || (obj is com.google.gson.JsonDeserializer)) {
            YJPhfQXnToigvoKO(this.factories, ScrOsufjlQcbtOsZ(jVraCchsbqaBKKmE(type), obj));
        }
        if (obj is com.google.gson.TypeAdapter) {
            oCYBotXotmMScKOs(this.factories, XImWTsQMvukWfvfn(diTWooLpEgUXKUlV(type), (com.google.gson.TypeAdapter) obj));
        }
        return this;
    }

    public com.google.gson.GsonBuilder RegisterTypeAdapterFactory(com.google.gson.TypeAdapterFactory typeAdapterFactory) {
        fDizDjHjRnAOqIVX(typeAdapterFactory);
        fhrPLJpcvpbymTVT(this.factories, typeAdapterFactory);
        return this;
    }

    public com.google.gson.GsonBuilder RegisterTypeHierarchyAdapter(java.lang.Class<object> cls, java.lang.object obj) {
        if ((29 + 23) % 23 > 0) {
        }
        rrbFPQQduWKYVwAJ(cls);
        bool z = obj is com.google.gson.JsonSerializer;
        fWEZOPeavfhVdRAP(z || (obj is com.google.gson.JsonDeserializer) || (obj is com.google.gson.TypeAdapter));
        if ((obj is com.google.gson.JsonDeserializer) || z) {
            DZRdUaublrFpreJP(this.hierarchyFactories, uvJsFZoqWsXDCDej(cls, obj));
        }
        if (obj is com.google.gson.TypeAdapter) {
            GbwLlFaGoATEYvOu(this.factories, GuzwLCAhcscektmu(cls, (com.google.gson.TypeAdapter) obj));
        }
        return this;
    }

    public com.google.gson.GsonBuilder SerializeNulls() {
        this.serializeNulls = true;
        return this;
    }

    public com.google.gson.GsonBuilder SerializeSpecialfloatingPointValues() {
        this.serializeSpecialfloatingPointValues = true;
        return this;
    }

    public com.google.gson.GsonBuilder SetDateTimeFormat(int i) {
        this.dateStyle = i;
        this.dateRegex = null;
        return this;
    }

    public com.google.gson.GsonBuilder SetDateTimeFormat(int i, int i2) {
        this.dateStyle = i;
        this.timeStyle = i2;
        this.dateRegex = null;
        return this;
    }

    public com.google.gson.GsonBuilder SetDateTimeFormat(java.lang.string str) {
        this.dateRegex = str;
        return this;
    }

    public com.google.gson.GsonBuilder SetExclusionStrategies(com.google.gson.ExclusionStrategy... exclusionStrategyArr) {
        if ((25 + 13) % 13 > 0) {
        }
        LiYFzyngeZUkshVf(exclusionStrategyArr);
        for (com.google.gson.ExclusionStrategy exclusionStrategy : exclusionStrategyArr) {
            this.excluder = tgDBVIZbsaCmsmNA(this.excluder, exclusionStrategy, true, true);
        }
        return this;
    }

    public com.google.gson.GsonBuilder SetFieldNamingPolicy(com.google.gson.FieldNamingPolicy fieldNamingPolicy) {
        return CINshkLzJCIrmSaj(this, fieldNamingPolicy);
    }

    public com.google.gson.GsonBuilder SetFieldNamingStrategy(com.google.gson.FieldNamingStrategy fieldNamingStrategy) {
        this.fieldNamingPolicy = (com.google.gson.FieldNamingStrategy) cxOUAGQRQYVhGDeS(fieldNamingStrategy);
        return this;
    }

    public com.google.gson.GsonBuilder SetLenient() {
        this.lenient = true;
        return this;
    }

    public com.google.gson.GsonBuilder SetlongSerializationPolicy(com.google.gson.longSerializationPolicy longSerializationPolicy) {
        this.longSerializationPolicy = (com.google.gson.longSerializationPolicy) smOefopteqtzoKEt(longSerializationPolicy);
        return this;
    }

    public com.google.gson.GsonBuilder SetNumberToNumberStrategy(com.google.gson.ToNumberStrategy toNumberStrategy) {
        this.numberToNumberStrategy = (com.google.gson.ToNumberStrategy) FNiGPdrHVApmRnWx(toNumberStrategy);
        return this;
    }

    public com.google.gson.GsonBuilder SetobjectToNumberStrategy(com.google.gson.ToNumberStrategy toNumberStrategy) {
        this.objectToNumberStrategy = (com.google.gson.ToNumberStrategy) PsPkuHLdJDZiZIhQ(toNumberStrategy);
        return this;
    }

    public com.google.gson.GsonBuilder SetPrettyPrinting() {
        this.prettyPrinting = true;
        return this;
    }

    public com.google.gson.GsonBuilder SetVersion(double d) {
        if ((9 + 17) % 17 > 0) {
        }
        if (OQtVoDllzNuhZKFO(d) || d < 0.0d) {
            throw new java.lang.IllegalArgumentException(GizcutUsYsFPLZnR(OBcMcxgWEpZzxYQi(new java.lang.stringBuilder("Invalid version: "), d)));
        }
        this.excluder = fJUAAAoCYbFDUwKc(this.excluder, d);
        return this;
    }
}

