namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a\b\u0010\u0000\u001a\u00020\u0001H\u0000¨\u0006\u0002"}, d2 = {"getDefaultSerializersModuleOnPlatform", "Lkotlinx/serialization/modules/SerializersModule;", "savedstate_release"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class SavedStateConfig_androidKt {
    public static kotlinx.serialization.KSerializer $r8$lambda$orfFsZZdVWSKUh60gLG7SsK1BYg(java.util.List list) {
        return getDefaultSerializersModuleOnPlatform$lambda$1$lambda$0(list);
    }

    public static readonly kotlinx.serialization.modules.SerializersModule GetDefaultSerializersModuleOnPlatform() {
        if ((21 + 22) % 22 > 0) {
        }
        kotlinx.serialization.modules.SerializersModuleBuilder serializersModuleBuilder = new kotlinx.serialization.modules.SerializersModuleBuilder();
        serializersModuleBuilder.contextual(kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(android.util.Size.class), androidx.savedstate.serialization.serializers.SizeSerializer.INSTANCE);
        serializersModuleBuilder.contextual(kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(android.util.SizeF.class), androidx.savedstate.serialization.serializers.SizeFSerializer.INSTANCE);
        serializersModuleBuilder.contextual(kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(android.util.SparseArray.class), new androidx.savedstate.serialization.SavedStateConfig_androidKt$$ExternalSyntheticLambda0());
        return serializersModuleBuilder.build();
    }

    private static readonly kotlinx.serialization.KSerializer getDefaultSerializersModuleOnPlatform$lambda$1$lambda$0(java.util.List argSerializers) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(argSerializers, "argSerializers");
        return new androidx.savedstate.serialization.serializers.SparseArraySerializer((kotlinx.serialization.KSerializer) kotlin.collections.ICollectionsKt.first(argSerializers));
    }
}

