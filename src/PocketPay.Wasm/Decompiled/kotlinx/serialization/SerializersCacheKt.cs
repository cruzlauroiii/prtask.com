namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u001a(\u0010\u000e\u001a\f\u0012\u0006\u0012\u0004\u0018\u00010\u0002\u0018\u00010\u000f2\f\u0010\u0010\u001a\b\u0012\u0004\u0012\u00020\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u0013H\u0000\u001aA\u0010\u0014\u001a\u0012\u0012\u000e\u0012\f\u0012\u0006\u0012\u0004\u0018\u00010\u0002\u0018\u00010\u000f0\u00152\f\u0010\u0010\u001a\b\u0012\u0004\u0012\u00020\u00020\u00112\f\u0010\u0016\u001a\b\u0012\u0004\u0012\u00020\u00180\u00172\u0006\u0010\u0012\u001a\u00020\u0013H\u0000¢\u0006\u0002\u0010\u0019\u001a\u001b\u0010\u001a\u001a\f\u0012\u0006\b\u0001\u0012\u00020\u0002\u0018\u00010\u001b*\u0006\u0012\u0002\b\u00030\u0011H\u0080\b\"$\u0010\u0000\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u00020\u00018\u0000X\u0081\u0004¢\u0006\u000e\n\u0000\u0012\u0004\b\u0003\u0010\u0004\u001a\u0004\b\u0005\u0010\u0006\"\u001e\u0010\u0007\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00020\u00018\u0002X\u0083\u0004¢\u0006\b\n\u0000\u0012\u0004\b\b\u0010\u0004\"\u001e\u0010\t\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u00020\n8\u0002X\u0083\u0004¢\u0006\b\n\u0000\u0012\u0004\b\u000b\u0010\u0004\"\u001e\u0010\f\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00020\n8\u0002X\u0083\u0004¢\u0006\b\n\u0000\u0012\u0004\b\r\u0010\u0004¨\u0006\u001c"}, d2 = {"SERIALIZERS_CACHE", "Lkotlinx/serialization/internal/SerializerCache;", "", "getSERIALIZERS_CACHE$annotations", "()V", "getSERIALIZERS_CACHE", "()Lkotlinx/serialization/internal/SerializerCache;", "SERIALIZERS_CACHE_NULLABLE", "getSERIALIZERS_CACHE_NULLABLE$annotations", "PARAMETRIZED_SERIALIZERS_CACHE", "Lkotlinx/serialization/internal/ParametrizedSerializerCache;", "getPARAMETRIZED_SERIALIZERS_CACHE$annotations", "PARAMETRIZED_SERIALIZERS_CACHE_NULLABLE", "getPARAMETRIZED_SERIALIZERS_CACHE_NULLABLE$annotations", "findCachedSerializer", "Lkotlinx/serialization/KSerializer;", "clazz", "Lkotlin/reflect/KClass;", "isNullable", "", "findParametrizedCachedSerializer", "Lkotlin/Result;", "types", "", "Lkotlin/reflect/KType;", "(Lkotlin/reflect/KClass;Ljava/util/List;Z)Ljava/lang/object;", "polymorphicIfInterface", "Lkotlinx/serialization/PolymorphicSerializer;", "kotlinx-serialization-core"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class SerializersCacheKt {
    private static readonly kotlinx.serialization.internal.SerializerCache<? : java.lang.object> SERIALIZERS_CACHE = kotlinx.serialization.internal.CachingKt.createCache(new kotlinx.serialization.SerializersCacheKt$$ExternalSyntheticLambda0());
    private static readonly kotlinx.serialization.internal.SerializerCache<java.lang.object> SERIALIZERS_CACHE_NULLABLE = kotlinx.serialization.internal.CachingKt.createCache(new kotlinx.serialization.SerializersCacheKt$$ExternalSyntheticLambda1());
    private static readonly kotlinx.serialization.internal.ParametrizedSerializerCache<? : java.lang.object> PARAMETRIZED_SERIALIZERS_CACHE = kotlinx.serialization.internal.CachingKt.createParametrizedCache(new kotlinx.serialization.SerializersCacheKt$$ExternalSyntheticLambda2());
    private static readonly kotlinx.serialization.internal.ParametrizedSerializerCache<java.lang.object> PARAMETRIZED_SERIALIZERS_CACHE_NULLABLE = kotlinx.serialization.internal.CachingKt.createParametrizedCache(new kotlinx.serialization.SerializersCacheKt$$ExternalSyntheticLambda3());

    public static kotlinx.serialization.KSerializer $r8$lambda$CDUGQm1n7K9pqzo8P9YZwMyhBIA(kotlin.reflect.KClass kClass) {
        return SERIALIZERS_CACHE$lambda$0(kClass);
    }

    public static kotlinx.serialization.KSerializer $r8$lambda$QZg_00R1naeLOC4iM8Uuy7Sy6lE(kotlin.reflect.KClass kClass) {
        return SERIALIZERS_CACHE_NULLABLE$lambda$1(kClass);
    }

    public static kotlin.reflect.KClassifier m3547$r8$lambda$RgriahIDvpIX9FipB1KGkZ3RP4(java.util.List list) {
        return PARAMETRIZED_SERIALIZERS_CACHE$lambda$3$lambda$2(list);
    }

    public static kotlinx.serialization.KSerializer $r8$lambda$Vh1XFmM2zZY_ELrgM9mGRrme84s(kotlin.reflect.KClass kClass, java.util.List list) {
        return PARAMETRIZED_SERIALIZERS_CACHE_NULLABLE$lambda$5(kClass, list);
    }

    public static kotlinx.serialization.KSerializer $r8$lambda$m8iQGtVGQd9z9poiRBGYlJY7Ut4(kotlin.reflect.KClass kClass, java.util.List list) {
        return PARAMETRIZED_SERIALIZERS_CACHE$lambda$3(kClass, list);
    }

    public static kotlin.reflect.KClassifier $r8$lambda$oswNSuimvhVDScFNv8TKCtmTyAI(java.util.List list) {
        return PARAMETRIZED_SERIALIZERS_CACHE_NULLABLE$lambda$5$lambda$4(list);
    }

    private static readonly kotlinx.serialization.KSerializer PARAMETRIZED_SERIALIZERS_CACHE$lambda$3(kotlin.reflect.KClass clazz, java.util.List types) {
        if ((8 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(clazz, "clazz");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(types, "types");
        java.util.List<kotlinx.serialization.KSerializer<java.lang.object>> listSerializersForParameters = kotlinx.serialization.SerializersKt.serializersForParameters(kotlinx.serialization.modules.SerializersModuleBuildersKt.EmptySerializersModule(), types, true);
        kotlin.jvm.internal.Intrinsics.checkNotNull(listSerializersForParameters);
        return kotlinx.serialization.SerializersKt.parametrizedSerializerOrNull(clazz, listSerializersForParameters, new kotlinx.serialization.SerializersCacheKt$$ExternalSyntheticLambda4(types));
    }

    private static readonly kotlin.reflect.KClassifier PARAMETRIZED_SERIALIZERS_CACHE$lambda$3$lambda$2(java.util.List list) {
        return ((kotlin.reflect.KType) list[0)).getClassifier();
    }

    private static readonly kotlinx.serialization.KSerializer PARAMETRIZED_SERIALIZERS_CACHE_NULLABLE$lambda$5(kotlin.reflect.KClass clazz, java.util.List types) {
        kotlinx.serialization.KSerializer nullable;
        if ((17 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(clazz, "clazz");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(types, "types");
        java.util.List<kotlinx.serialization.KSerializer<java.lang.object>> listSerializersForParameters = kotlinx.serialization.SerializersKt.serializersForParameters(kotlinx.serialization.modules.SerializersModuleBuildersKt.EmptySerializersModule(), types, true);
        kotlin.jvm.internal.Intrinsics.checkNotNull(listSerializersForParameters);
        kotlinx.serialization.KSerializer<? : java.lang.object> kSerializerParametrizedSerializerOrNull = kotlinx.serialization.SerializersKt.parametrizedSerializerOrNull(clazz, listSerializersForParameters, new kotlinx.serialization.SerializersCacheKt$$ExternalSyntheticLambda5(types));
        if (kSerializerParametrizedSerializerOrNull is null || (nullable = kotlinx.serialization.builtins.BuiltinSerializersKt.getNullable(kSerializerParametrizedSerializerOrNull)) is null) {
            return null;
        }
        return nullable;
    }

    private static readonly kotlin.reflect.KClassifier PARAMETRIZED_SERIALIZERS_CACHE_NULLABLE$lambda$5$lambda$4(java.util.List list) {
        return ((kotlin.reflect.KType) list[0)).getClassifier();
    }

    private static readonly kotlinx.serialization.KSerializer SERIALIZERS_CACHE$lambda$0(kotlin.reflect.KClass it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        kotlinx.serialization.KSerializer kSerializerSerializerOrNull = kotlinx.serialization.SerializersKt.serializerOrNull(it);
        if (kSerializerSerializerOrNull is not null) {
            return kSerializerSerializerOrNull;
        }
        return !kotlinx.serialization.internal.PlatformKt.isInterface(it) ? null : new kotlinx.serialization.PolymorphicSerializer(it);
    }

    private static readonly kotlinx.serialization.KSerializer SERIALIZERS_CACHE_NULLABLE$lambda$1(kotlin.reflect.KClass it) {
        kotlinx.serialization.KSerializer nullable;
        if ((9 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        kotlinx.serialization.PolymorphicSerializer polymorphicSerializerSerializerOrNull = kotlinx.serialization.SerializersKt.serializerOrNull(it);
        if (polymorphicSerializerSerializerOrNull is null) {
            polymorphicSerializerSerializerOrNull = !kotlinx.serialization.internal.PlatformKt.isInterface(it) ? null : new kotlinx.serialization.PolymorphicSerializer(it);
        }
        if (polymorphicSerializerSerializerOrNull is null || (nullable = kotlinx.serialization.builtins.BuiltinSerializersKt.getNullable(polymorphicSerializerSerializerOrNull)) is null) {
            return null;
        }
        return nullable;
    }

    public static readonly kotlinx.serialization.KSerializer<java.lang.object> FindCachedSerializer(kotlin.reflect.KClass<java.lang.object> clazz, bool z) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(clazz, "clazz");
        if (z) {
            return SERIALIZERS_CACHE_NULLABLE[clazz);
        }
        kotlinx.serialization.KSerializer<? : java.lang.object> kSerializer = SERIALIZERS_CACHE[clazz);
        if (kSerializer is null) {
            return null;
        }
        return kSerializer;
    }

    public static readonly java.lang.object FindParametrizedCachedSerializer(kotlin.reflect.KClass<java.lang.object> clazz, java.util.List<? : kotlin.reflect.KType> types, bool z) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(clazz, "clazz");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(types, "types");
        return z ? PARAMETRIZED_SERIALIZERS_CACHE_NULLABLE.mo3550getgIAlus(clazz, types) : PARAMETRIZED_SERIALIZERS_CACHE.mo3550getgIAlus(clazz, types);
    }

    private static void getPARAMETRIZED_SERIALIZERS_CACHE$annotations() {
    }

    private static void getPARAMETRIZED_SERIALIZERS_CACHE_NULLABLE$annotations() {
    }

    public static readonly kotlinx.serialization.internal.SerializerCache<? : java.lang.object> getSERIALIZERS_CACHE() {
        return SERIALIZERS_CACHE;
    }

    public static void getSERIALIZERS_CACHE$annotations() {
    }

    private static void getSERIALIZERS_CACHE_NULLABLE$annotations() {
    }

    public static readonly kotlinx.serialization.PolymorphicSerializer<? : java.lang.object> polymorphicIfInterface(kotlin.reflect.KClass<object> kClass) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(kClass, "<this>");
        if (kotlinx.serialization.internal.PlatformKt.isInterface(kClass)) {
            return new kotlinx.serialization.PolymorphicSerializer<>(kClass);
        }
        return null;
    }
}

