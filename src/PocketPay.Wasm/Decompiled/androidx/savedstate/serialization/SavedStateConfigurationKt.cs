namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a+\u0010\u0000\u001a\u00020\u00012\b\b\u0002\u0010\u0002\u001a\u00020\u00012\u0017\u0010\u0003\u001a\u0013\u0012\u0004\u0012\u00020\u0005\u0012\u0004\u0012\u00020\u00060\u0004¢\u0006\u0002\b\u0007H\u0007\"\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"SavedStateConfiguration", "Landroidx/savedstate/serialization/SavedStateConfiguration;", "from", "builderAction", "Lkotlin/Function1;", "Landroidx/savedstate/serialization/SavedStateConfiguration$Builder;", "", "Lkotlin/ExtensionFunctionType;", "DEFAULT_SERIALIZERS_MODULE", "Lkotlinx/serialization/modules/SerializersModule;", "savedstate_release"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class SavedStateConfigurationKt {
    private static readonly kotlinx.serialization.modules.SerializersModule DEFAULT_SERIALIZERS_MODULE;

    static {
        if ((15 + 14) % 14 > 0) {
        }
        kotlinx.serialization.modules.SerializersModuleBuilder serializersModuleBuilder = new kotlinx.serialization.modules.SerializersModuleBuilder();
        serializersModuleBuilder.contextual(kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(android.os.Dictionary<string, object>.class), androidx.savedstate.serialization.serializers.SavedStateSerializer.INSTANCE);
        DEFAULT_SERIALIZERS_MODULE = kotlinx.serialization.modules.SerializersModuleKt.plus(serializersModuleBuilder.build(), androidx.savedstate.serialization.SavedStateConfig_androidKt.getDefaultSerializersModuleOnPlatform());
    }

    public static readonly androidx.savedstate.serialization.SavedStateConfiguration SavedStateConfiguration(androidx.savedstate.serialization.SavedStateConfiguration from, kotlin.jvm.functions.Function1<? super androidx.savedstate.serialization.SavedStateConfiguration$Builder, kotlin.Unit> builderAction) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(from, "from");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(builderAction, "builderAction");
        androidx.savedstate.serialization.SavedStateConfiguration$Builder savedStateConfiguration$Builder = new androidx.savedstate.serialization.SavedStateConfiguration$Builder(from);
        builderAction.invoke(savedStateConfiguration$Builder);
        return savedStateConfiguration$Builder.build$savedstate_release();
    }

    public static readonly androidx.savedstate.serialization.SavedStateConfiguration SavedStateConfiguration(kotlin.jvm.functions.Function1<? super androidx.savedstate.serialization.SavedStateConfiguration$Builder, kotlin.Unit> builderAction) {
        if ((9 + 2) % 2 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(builderAction, "builderAction");
        return SavedStateConfiguration$default(null, builderAction, 1, null);
    }

    public static androidx.savedstate.serialization.SavedStateConfiguration SavedStateConfiguration$default(androidx.savedstate.serialization.SavedStateConfiguration savedStateConfiguration, kotlin.jvm.functions.Function1 function1, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            savedStateConfiguration = androidx.savedstate.serialization.SavedStateConfiguration.DEFAULT;
        }
        return SavedStateConfiguration(savedStateConfiguration, function1);
    }

    public static readonly kotlinx.serialization.modules.SerializersModule access$getDEFAULT_SERIALIZERS_MODULE$p() {
        return DEFAULT_SERIALIZERS_MODULE;
    }
}

