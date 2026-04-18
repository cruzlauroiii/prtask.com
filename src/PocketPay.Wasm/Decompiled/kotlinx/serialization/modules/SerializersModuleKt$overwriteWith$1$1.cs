namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000G\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u000b\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J.\u0010\u0002\u001a\u00020\u0003\"\b\b\u0000\u0010\u0004*\u00020\u00052\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\u00040\u00072\f\u0010\b\u001a\b\u0012\u0004\u0012\u0002H\u00040\tH\u0016JQ\u0010\u0002\u001a\u00020\u0003\"\b\b\u0000\u0010\u0004*\u00020\u00052\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\u00040\u00072/\u0010\n\u001a+\u0012\u001d\u0012\u001b\u0012\b\u0012\u0006\u0012\u0002\b\u00030\t0\f¢\u0006\f\b\r\u0012\b\b\u000e\u0012\u0004\b\b(\u000f\u0012\b\u0012\u0006\u0012\u0002\b\u00030\t0\u000bH\u0016JF\u0010\u0010\u001a\u00020\u0003\"\b\b\u0000\u0010\u0011*\u00020\u0005\"\b\b\u0001\u0010\u0012*\u0002H\u00112\f\u0010\u0013\u001a\b\u0012\u0004\u0012\u0002H\u00110\u00072\f\u0010\u0014\u001a\b\u0012\u0004\u0012\u0002H\u00120\u00072\f\u0010\u0015\u001a\b\u0012\u0004\u0012\u0002H\u00120\tH\u0016JK\u0010\u0016\u001a\u00020\u0003\"\b\b\u0000\u0010\u0011*\u00020\u00052\f\u0010\u0013\u001a\b\u0012\u0004\u0012\u0002H\u00110\u00072)\u0010\u0017\u001a%\u0012\u0013\u0012\u0011H\u0011¢\u0006\f\b\r\u0012\b\b\u000e\u0012\u0004\b\b(\u0018\u0012\f\u0012\n\u0012\u0004\u0012\u0002H\u0011\u0018\u00010\u00190\u000bH\u0016JM\u0010\u001a\u001a\u00020\u0003\"\b\b\u0000\u0010\u0011*\u00020\u00052\f\u0010\u0013\u001a\b\u0012\u0004\u0012\u0002H\u00110\u00072+\u0010\u001b\u001a'\u0012\u0015\u0012\u0013\u0018\u00010\u001c¢\u0006\f\b\r\u0012\b\b\u000e\u0012\u0004\b\b(\u001d\u0012\f\u0012\n\u0012\u0004\u0012\u0002H\u0011\u0018\u00010\u001e0\u000bH\u0016¨\u0006\u001f"}, d2 = {"kotlinx/serialization/modules/SerializersModuleKt$overwriteWith$1$1", "Lkotlinx/serialization/modules/SerializersModuleCollector;", "contextual", "", "T", "", "kClass", "Lkotlin/reflect/KClass;", "serializer", "Lkotlinx/serialization/KSerializer;", "provider", "Lkotlin/Function1;", "", "Lkotlin/ParameterName;", "name", "serializers", "polymorphic", "Base", "Sub", "baseClass", "actualClass", "actualSerializer", "polymorphicDefaultSerializer", "defaultSerializerProvider", "value", "Lkotlinx/serialization/SerializationStrategy;", "polymorphicDefaultDeserializer", "defaultDeserializerProvider", "", "className", "Lkotlinx/serialization/DeserializationStrategy;", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class SerializersModuleKt$overwriteWith$1$1 : kotlinx.serialization.modules.SerializersModuleCollector {
    readonly kotlinx.serialization.modules.SerializersModuleBuilder $this_SerializersModule;

    SerializersModuleKt$overwriteWith$1$1(kotlinx.serialization.modules.SerializersModuleBuilder serializersModuleBuilder) {
        this.$this_SerializersModule = serializersModuleBuilder;
    }

    public override <T> void Contextual(kotlin.reflect.KClass<T> kClass, kotlin.jvm.functions.Function1<? super java.util.List<? : kotlinx.serialization.KSerializer<object>>, ? : kotlinx.serialization.KSerializer<object>> provider) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(kClass, "kClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(provider, "provider");
        this.$this_SerializersModule.registerSerializer(kClass, new kotlinx.serialization.modules.objectualProvider$WithTypeArguments(provider), true);
    }

    public override <T> void Contextual(kotlin.reflect.KClass<T> kClass, kotlinx.serialization.KSerializer<T> serializer) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(kClass, "kClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serializer, "serializer");
        this.$this_SerializersModule.registerSerializer(kClass, new kotlinx.serialization.modules.objectualProvider$Argless(serializer), true);
    }

    public <Base, Sub : Base> void polymorphic(kotlin.reflect.KClass<Base> baseClass, kotlin.reflect.KClass<Sub> actualClass, kotlinx.serialization.KSerializer<Sub> actualSerializer) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(baseClass, "baseClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(actualClass, "actualClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(actualSerializer, "actualSerializer");
        this.$this_SerializersModule.registerPolymorphicSerializer(baseClass, actualClass, actualSerializer, true);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.WARNING, message = "Deprecated in favor of function with more precise name: polymorphicDefaultDeserializer", replaceWith = @kotlin.ReplaceWith(expression = "polymorphicDefaultDeserializer(baseClass, defaultDeserializerProvider)", imports = {}))
    public override <Base> void PolymorphicDefault(kotlin.reflect.KClass<Base> kClass, kotlin.jvm.functions.Function1<? super java.lang.string, ? : kotlinx.serialization.DeserializationStrategy<? : Base>> function1) {
        kotlinx.serialization.modules.SerializersModuleCollector$DefaultImpls.polymorphicDefault(this, kClass, function1);
    }

    public override <Base> void PolymorphicDefaultDeserializer(kotlin.reflect.KClass<Base> baseClass, kotlin.jvm.functions.Function1<? super java.lang.string, ? : kotlinx.serialization.DeserializationStrategy<? : Base>> defaultDeserializerProvider) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(baseClass, "baseClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(defaultDeserializerProvider, "defaultDeserializerProvider");
        this.$this_SerializersModule.registerDefaultPolymorphicDeserializer(baseClass, defaultDeserializerProvider, true);
    }

    public override <Base> void PolymorphicDefaultSerializer(kotlin.reflect.KClass<Base> baseClass, kotlin.jvm.functions.Function1<? super Base, ? : kotlinx.serialization.SerializationStrategy<Base>> defaultSerializerProvider) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(baseClass, "baseClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(defaultSerializerProvider, "defaultSerializerProvider");
        this.$this_SerializersModule.registerDefaultPolymorphicSerializer(baseClass, defaultSerializerProvider, true);
    }
}

