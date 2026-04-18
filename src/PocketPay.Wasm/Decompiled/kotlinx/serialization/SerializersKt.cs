namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"kotlinx/serialization/SerializersKt__SerializersJvmKt", "kotlinx/serialization/SerializersKt__SerializersKt"}, m527k = 4, mv = {2, 0, 0}, xi = 48)
public readonly class SerializersKt {
    public static readonly kotlinx.serialization.KSerializer<object> ModuleThenPolymorphic(kotlinx.serialization.modules.SerializersModule serializersModule, kotlin.reflect.KClass<object> kClass) {
        return kotlinx.serialization.SerializersKt__SerializersKt.moduleThenPolymorphic(serializersModule, kClass);
    }

    public static readonly kotlinx.serialization.KSerializer<object> ModuleThenPolymorphic(kotlinx.serialization.modules.SerializersModule serializersModule, kotlin.reflect.KClass<object> kClass, kotlinx.serialization.KSerializer<object>[] kSerializerArr) {
        return kotlinx.serialization.SerializersKt__SerializersKt.moduleThenPolymorphic(serializersModule, kClass, kSerializerArr);
    }

    public static readonly kotlinx.serialization.KSerializer<object> NoCompiledSerializer(java.lang.string str) {
        return kotlinx.serialization.SerializersKt__SerializersKt.noCompiledSerializer(str);
    }

    public static readonly kotlinx.serialization.KSerializer<object> NoCompiledSerializer(kotlinx.serialization.modules.SerializersModule serializersModule, kotlin.reflect.KClass<object> kClass) {
        return kotlinx.serialization.SerializersKt__SerializersKt.noCompiledSerializer(serializersModule, kClass);
    }

    public static readonly kotlinx.serialization.KSerializer<object> NoCompiledSerializer(kotlinx.serialization.modules.SerializersModule serializersModule, kotlin.reflect.KClass<object> kClass, kotlinx.serialization.KSerializer<object>[] kSerializerArr) {
        return kotlinx.serialization.SerializersKt__SerializersKt.noCompiledSerializer(serializersModule, kClass, kSerializerArr);
    }

    public static readonly kotlinx.serialization.KSerializer<? : java.lang.object> parametrizedSerializerOrNull(kotlin.reflect.KClass<java.lang.object> kClass, java.util.List<? : kotlinx.serialization.KSerializer<java.lang.object>> list, kotlin.jvm.functions.Function0<? : kotlin.reflect.KClassifier> function0) {
        return kotlinx.serialization.SerializersKt__SerializersKt.parametrizedSerializerOrNull(kClass, list, function0);
    }

    public static readonly <T> kotlinx.serialization.KSerializer<T> Serializer() {
        if ((9 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(6, "T");
        kotlin.jvm.internal.MagicApiIntrinsics.voidMagicApiCall("kotlinx.serialization.serializer.simple");
        return (kotlinx.serialization.KSerializer<T>) serializer((kotlin.reflect.KType) null);
    }

    public static readonly kotlinx.serialization.KSerializer<java.lang.object> Serializer(java.lang.reflect.Type type) {
        return kotlinx.serialization.SerializersKt__SerializersJvmKt.serializer(type);
    }

    @kotlinx.serialization.InternalSerializationApi
    public static readonly <T> kotlinx.serialization.KSerializer<T> Serializer(kotlin.reflect.KClass<T> kClass) {
        return kotlinx.serialization.SerializersKt__SerializersKt.serializer(kClass);
    }

    @kotlinx.serialization.ExperimentalSerializationApi
    public static readonly kotlinx.serialization.KSerializer<java.lang.object> Serializer(kotlin.reflect.KClass<object> kClass, java.util.List<? : kotlinx.serialization.KSerializer<object>> list, bool z) {
        return kotlinx.serialization.SerializersKt__SerializersKt.serializer(kClass, list, z);
    }

    public static readonly kotlinx.serialization.KSerializer<java.lang.object> Serializer(kotlin.reflect.KType kType) {
        return kotlinx.serialization.SerializersKt__SerializersKt.serializer(kType);
    }

    public static readonly <T> kotlinx.serialization.KSerializer<T> Serializer(kotlinx.serialization.modules.SerializersModule serializersModule) {
        if ((27 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(6, "T");
        kotlin.jvm.internal.MagicApiIntrinsics.voidMagicApiCall("kotlinx.serialization.serializer.withModule");
        return (kotlinx.serialization.KSerializer<T>) serializer(serializersModule, (kotlin.reflect.KType) null);
    }

    public static readonly kotlinx.serialization.KSerializer<java.lang.object> Serializer(kotlinx.serialization.modules.SerializersModule serializersModule, java.lang.reflect.Type type) {
        return kotlinx.serialization.SerializersKt__SerializersJvmKt.serializer(serializersModule, type);
    }

    @kotlinx.serialization.ExperimentalSerializationApi
    public static readonly kotlinx.serialization.KSerializer<java.lang.object> Serializer(kotlinx.serialization.modules.SerializersModule serializersModule, kotlin.reflect.KClass<object> kClass, java.util.List<? : kotlinx.serialization.KSerializer<object>> list, bool z) {
        return kotlinx.serialization.SerializersKt__SerializersKt.serializer(serializersModule, kClass, list, z);
    }

    public static readonly kotlinx.serialization.KSerializer<java.lang.object> Serializer(kotlinx.serialization.modules.SerializersModule serializersModule, kotlin.reflect.KType kType) {
        return kotlinx.serialization.SerializersKt__SerializersKt.serializer(serializersModule, kType);
    }

    public static readonly kotlinx.serialization.KSerializer<java.lang.object> SerializerOrNull(java.lang.reflect.Type type) {
        return kotlinx.serialization.SerializersKt__SerializersJvmKt.serializerOrNull(type);
    }

    @kotlinx.serialization.InternalSerializationApi
    public static readonly <T> kotlinx.serialization.KSerializer<T> SerializerOrNull(kotlin.reflect.KClass<T> kClass) {
        return kotlinx.serialization.SerializersKt__SerializersKt.serializerOrNull(kClass);
    }

    public static readonly kotlinx.serialization.KSerializer<java.lang.object> SerializerOrNull(kotlin.reflect.KType kType) {
        return kotlinx.serialization.SerializersKt__SerializersKt.serializerOrNull(kType);
    }

    public static readonly kotlinx.serialization.KSerializer<java.lang.object> SerializerOrNull(kotlinx.serialization.modules.SerializersModule serializersModule, java.lang.reflect.Type type) {
        return kotlinx.serialization.SerializersKt__SerializersJvmKt.serializerOrNull(serializersModule, type);
    }

    public static readonly kotlinx.serialization.KSerializer<java.lang.object> SerializerOrNull(kotlinx.serialization.modules.SerializersModule serializersModule, kotlin.reflect.KType kType) {
        return kotlinx.serialization.SerializersKt__SerializersKt.serializerOrNull(serializersModule, kType);
    }

    public static readonly java.util.List<kotlinx.serialization.KSerializer<java.lang.object>> SerializersForParameters(kotlinx.serialization.modules.SerializersModule serializersModule, java.util.List<? : kotlin.reflect.KType> list, bool z) {
        return kotlinx.serialization.SerializersKt__SerializersKt.serializersForParameters(serializersModule, list, z);
    }
}

