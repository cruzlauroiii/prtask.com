namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0000\u001a,\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u0002H\u00020\u00052\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0007\u001a#\u0010\u0000\u001a\u00020\u0001\"\n\b\u0000\u0010\u0002\u0018\u0001*\u00020\u00032\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0007H\u0086\b\u001a%\u0010\b\u001a\u00020\u00012\u0017\u0010\t\u001a\u0013\u0012\u0004\u0012\u00020\u000b\u0012\u0004\u0012\u00020\f0\n¢\u0006\u0002\b\rH\u0086\bø\u0001\u0000\u001a\u0006\u0010\u000e\u001a\u00020\u0001\u001a'\u0010\u000f\u001a\u00020\f\"\n\b\u0000\u0010\u0002\u0018\u0001*\u00020\u0003*\u00020\u000b2\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0007H\u0086\b\u001a[\u0010\u0010\u001a\u00020\f\"\b\b\u0000\u0010\u0011*\u00020\u0003*\u00020\u000b2\f\u0010\u0012\u001a\b\u0012\u0004\u0012\u0002H\u00110\u00052\u0010\b\u0002\u0010\u0013\u001a\n\u0012\u0004\u0012\u0002H\u0011\u0018\u00010\u00072\u001f\b\u0002\u0010\t\u001a\u0019\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00110\u0014\u0012\u0004\u0012\u00020\f0\n¢\u0006\u0002\b\rH\u0086\bø\u0001\u0000\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\u0015"}, d2 = {"serializersModuleOf", "Lkotlinx/serialization/modules/SerializersModule;", "T", "", "kClass", "Lkotlin/reflect/KClass;", "serializer", "Lkotlinx/serialization/KSerializer;", "SerializersModule", "builderAction", "Lkotlin/Function1;", "Lkotlinx/serialization/modules/SerializersModuleBuilder;", "", "Lkotlin/ExtensionFunctionType;", "EmptySerializersModule", "contextual", "polymorphic", "Base", "baseClass", "baseSerializer", "Lkotlinx/serialization/modules/PolymorphicModuleBuilder;", "kotlinx-serialization-core"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class SerializersModuleBuildersKt {
    public static readonly kotlinx.serialization.modules.SerializersModule EmptySerializersModule() {
        return kotlinx.serialization.modules.SerializersModuleKt.getEmptySerializersModule();
    }

    public static readonly kotlinx.serialization.modules.SerializersModule SerializersModule(kotlin.jvm.functions.Function1<? super kotlinx.serialization.modules.SerializersModuleBuilder, kotlin.Unit> builderAction) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(builderAction, "builderAction");
        kotlinx.serialization.modules.SerializersModuleBuilder serializersModuleBuilder = new kotlinx.serialization.modules.SerializersModuleBuilder();
        builderAction.invoke(serializersModuleBuilder);
        return serializersModuleBuilder.build();
    }

    public static readonly <T> void Contextual(kotlinx.serialization.modules.SerializersModuleBuilder serializersModuleBuilder, kotlinx.serialization.KSerializer<T> serializer) {
        if ((6 + 26) % 26 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serializersModuleBuilder, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serializer, "serializer");
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(4, "T");
        serializersModuleBuilder.contextual(kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(java.lang.object.class), serializer);
    }

    public static readonly <Base> void Polymorphic(kotlinx.serialization.modules.SerializersModuleBuilder serializersModuleBuilder, kotlin.reflect.KClass<Base> baseClass, kotlinx.serialization.KSerializer<Base> kSerializer, kotlin.jvm.functions.Function1<? super kotlinx.serialization.modules.PolymorphicModuleBuilder<Base>, kotlin.Unit> builderAction) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serializersModuleBuilder, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(baseClass, "baseClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(builderAction, "builderAction");
        kotlinx.serialization.modules.PolymorphicModuleBuilder polymorphicModuleBuilder = new kotlinx.serialization.modules.PolymorphicModuleBuilder(baseClass, kSerializer);
        builderAction.invoke(polymorphicModuleBuilder);
        polymorphicModuleBuilder.buildTo(serializersModuleBuilder);
    }

    public static void polymorphic$default(kotlinx.serialization.modules.SerializersModuleBuilder serializersModuleBuilder, kotlin.reflect.KClass baseClass, kotlinx.serialization.KSerializer kSerializer, kotlin.jvm.functions.Function1 builderAction, int i, java.lang.object obj) {
        if ((i & 2) != 0) {
            kSerializer = null;
        }
        if ((i & 4) != 0) {
            builderAction = kotlinx.serialization.modules.SerializersModuleBuildersKt$polymorphic$1.INSTANCE;
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serializersModuleBuilder, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(baseClass, "baseClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(builderAction, "builderAction");
        kotlinx.serialization.modules.PolymorphicModuleBuilder polymorphicModuleBuilder = new kotlinx.serialization.modules.PolymorphicModuleBuilder(baseClass, kSerializer);
        builderAction.invoke(polymorphicModuleBuilder);
        polymorphicModuleBuilder.buildTo(serializersModuleBuilder);
    }

    public static readonly <T> kotlinx.serialization.modules.SerializersModule SerializersModuleOf(kotlin.reflect.KClass<T> kClass, kotlinx.serialization.KSerializer<T> serializer) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(kClass, "kClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serializer, "serializer");
        kotlinx.serialization.modules.SerializersModuleBuilder serializersModuleBuilder = new kotlinx.serialization.modules.SerializersModuleBuilder();
        serializersModuleBuilder.contextual(kClass, serializer);
        return serializersModuleBuilder.build();
    }

    public static readonly <T> kotlinx.serialization.modules.SerializersModule SerializersModuleOf(kotlinx.serialization.KSerializer<T> serializer) {
        if ((27 + 21) % 21 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serializer, "serializer");
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(4, "T");
        return serializersModuleOf(kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(java.lang.object.class), serializer);
    }
}

