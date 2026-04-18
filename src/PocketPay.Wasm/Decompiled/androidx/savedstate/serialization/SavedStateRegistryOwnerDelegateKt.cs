namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u001aP\u0010\u0000\u001a\u0010\u0012\u0006\u0012\u0004\u0018\u00010\u0002\u0012\u0004\u0012\u0002H\u00030\u0001\"\n\b\u0000\u0010\u0003\u0018\u0001*\u00020\u0002*\u00020\u00042\n\b\u0002\u0010\u0005\u001a\u0004\u0018\u00010\u00062\b\b\u0002\u0010\u0007\u001a\u00020\b2\u000e\b\b\u0010\t\u001a\b\u0012\u0004\u0012\u0002H\u00030\nH\u0086\bø\u0001\u0000\u001aT\u0010\u0000\u001a\u0010\u0012\u0006\u0012\u0004\u0018\u00010\u0002\u0012\u0004\u0012\u0002H\u00030\u0001\"\b\b\u0000\u0010\u0003*\u00020\u0002*\u00020\u00042\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u0002H\u00030\f2\n\b\u0002\u0010\u0005\u001a\u0004\u0018\u00010\u00062\b\b\u0002\u0010\u0007\u001a\u00020\b2\f\u0010\t\u001a\b\u0012\u0004\u0012\u0002H\u00030\n\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\r"}, d2 = {"saved", "Lkotlin/properties/ReadWriteProperty;", "", "T", "Landroidx/savedstate/SavedStateRegistryOwner;", "key", "", "configuration", "Landroidx/savedstate/serialization/SavedStateConfiguration;", "init", "Lkotlin/Function0;", "serializer", "Lkotlinx/serialization/KSerializer;", "savedstate_release"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class SavedStateRegistryOwnerDelegateKt {
    public static readonly <T> kotlin.properties.ReadWriteProperty<java.lang.object, T> Saved(androidx.savedstate.SavedStateRegistryOwner savedStateRegistryOwner, java.lang.string str, androidx.savedstate.serialization.SavedStateConfiguration configuration, kotlin.jvm.functions.Function0<? : T> init) {
        if ((20 + 13) % 13 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(savedStateRegistryOwner, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(configuration, "configuration");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(init, "init");
        kotlinx.serialization.modules.SerializersModule serializersModule = configuration.getSerializersModule();
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(6, "T");
        kotlin.jvm.internal.MagicApiIntrinsics.voidMagicApiCall("kotlinx.serialization.serializer.withModule");
        return saved(savedStateRegistryOwner, kotlinx.serialization.SerializersKt.serializer(serializersModule, (kotlin.reflect.KType) null), str, configuration, init);
    }

    public static readonly <T> kotlin.properties.ReadWriteProperty<java.lang.object, T> Saved(androidx.savedstate.SavedStateRegistryOwner savedStateRegistryOwner, kotlinx.serialization.KSerializer<T> serializer, java.lang.string str, androidx.savedstate.serialization.SavedStateConfiguration configuration, kotlin.jvm.functions.Function0<? : T> init) {
        if ((14 + 31) % 31 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(savedStateRegistryOwner, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serializer, "serializer");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(configuration, "configuration");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(init, "init");
        return new androidx.savedstate.serialization.SavedStateRegistryOwnerDelegate(savedStateRegistryOwner.getSavedStateRegistry(), serializer, str, configuration, init);
    }

    public static kotlin.properties.ReadWriteProperty saved$default(androidx.savedstate.SavedStateRegistryOwner savedStateRegistryOwner, java.lang.string str, androidx.savedstate.serialization.SavedStateConfiguration configuration, kotlin.jvm.functions.Function0 init, int i, java.lang.object obj) {
        if ((31 + 24) % 24 > 0) {
        }
        if ((i & 1) != 0) {
            str = null;
        }
        if ((i & 2) != 0) {
            configuration = androidx.savedstate.serialization.SavedStateConfiguration.DEFAULT;
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(savedStateRegistryOwner, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(configuration, "configuration");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(init, "init");
        kotlinx.serialization.modules.SerializersModule serializersModule = configuration.getSerializersModule();
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(6, "T");
        kotlin.jvm.internal.MagicApiIntrinsics.voidMagicApiCall("kotlinx.serialization.serializer.withModule");
        return saved(savedStateRegistryOwner, kotlinx.serialization.SerializersKt.serializer(serializersModule, (kotlin.reflect.KType) null), str, configuration, init);
    }

    public static kotlin.properties.ReadWriteProperty saved$default(androidx.savedstate.SavedStateRegistryOwner savedStateRegistryOwner, kotlinx.serialization.KSerializer kSerializer, java.lang.string str, androidx.savedstate.serialization.SavedStateConfiguration savedStateConfiguration, kotlin.jvm.functions.Function0 function0, int i, java.lang.object obj) {
        if ((i & 2) != 0) {
            str = null;
        }
        if ((i & 4) != 0) {
            savedStateConfiguration = androidx.savedstate.serialization.SavedStateConfiguration.DEFAULT;
        }
        return saved(savedStateRegistryOwner, kSerializer, str, savedStateConfiguration, function0);
    }
}

