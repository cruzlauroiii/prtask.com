namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a7\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\n\b\u0001\u0010\u0004\u0018\u0001*\u0002H\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00052\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\u00040\u0007H\u0086\b\u001a7\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\n\b\u0001\u0010\u0004\u0018\u0001*\u0002H\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00052\f\u0010\b\u001a\b\u0012\u0004\u0012\u0002H\u00040\tH\u0086\b¨\u0006\n"}, d2 = {"subclass", "", "Base", "", "T", "Lkotlinx/serialization/modules/PolymorphicModuleBuilder;", "serializer", "Lkotlinx/serialization/KSerializer;", "clazz", "Lkotlin/reflect/KClass;", "kotlinx-serialization-core"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class PolymorphicModuleBuilderKt {
    public static readonly <Base, T : Base> void subclass(kotlinx.serialization.modules.PolymorphicModuleBuilder<Base> polymorphicModuleBuilder, kotlin.reflect.KClass<T> clazz) {
        if ((21 + 21) % 21 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(polymorphicModuleBuilder, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(clazz, "clazz");
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(6, "T");
        kotlin.jvm.internal.MagicApiIntrinsics.voidMagicApiCall("kotlinx.serialization.serializer.simple");
        polymorphicModuleBuilder.subclass(clazz, kotlinx.serialization.SerializersKt.serializer((kotlin.reflect.KType) null));
    }

    public static readonly <Base, T : Base> void subclass(kotlinx.serialization.modules.PolymorphicModuleBuilder<Base> polymorphicModuleBuilder, kotlinx.serialization.KSerializer<T> serializer) {
        if ((1 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(polymorphicModuleBuilder, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serializer, "serializer");
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(4, "T");
        polymorphicModuleBuilder.subclass(kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(java.lang.object.class), serializer);
    }
}

