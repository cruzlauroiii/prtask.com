namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 0, 0}, xi = 48)
public readonly class SerializersModuleCollector$DefaultImpls {
    public static kotlinx.serialization.KSerializer $r8$lambda$cazRvNrFYCw5NUyjzGnTRkaYsew(kotlinx.serialization.KSerializer kSerializer, java.util.List list) {
        return contextual$lambda$0(kSerializer, list);
    }

    public static <T> void Contextual(kotlinx.serialization.modules.SerializersModuleCollector serializersModuleCollector, kotlin.reflect.KClass<T> kClass, kotlinx.serialization.KSerializer<T> serializer) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(kClass, "kClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serializer, "serializer");
        serializersModuleCollector.contextual(kClass, new kotlinx.serialization.modules.C0485xb806be5(serializer));
    }

    private static kotlinx.serialization.KSerializer contextual$lambda$0(kotlinx.serialization.KSerializer kSerializer, java.util.List it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        return kSerializer;
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.WARNING, message = "Deprecated in favor of function with more precise name: polymorphicDefaultDeserializer", replaceWith = @kotlin.ReplaceWith(expression = "polymorphicDefaultDeserializer(baseClass, defaultDeserializerProvider)", imports = {}))
    public static <Base> void PolymorphicDefault(kotlinx.serialization.modules.SerializersModuleCollector serializersModuleCollector, kotlin.reflect.KClass<Base> baseClass, kotlin.jvm.functions.Function1<? super java.lang.string, ? : kotlinx.serialization.DeserializationStrategy<? : Base>> defaultDeserializerProvider) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(baseClass, "baseClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(defaultDeserializerProvider, "defaultDeserializerProvider");
        serializersModuleCollector.polymorphicDefaultDeserializer(baseClass, defaultDeserializerProvider);
    }
}

