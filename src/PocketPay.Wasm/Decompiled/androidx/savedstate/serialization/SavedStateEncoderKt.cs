namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a0\u0010\u0000\u001a\u00060\u0001j\u0002`\u0002\"\n\b\u0000\u0010\u0003\u0018\u0001*\u00020\u00042\u0006\u0010\u0005\u001a\u0002H\u00032\b\b\u0002\u0010\u0006\u001a\u00020\u0007H\u0086\b¢\u0006\u0002\u0010\b\u001a;\u0010\u0000\u001a\u00060\u0001j\u0002`\u0002\"\b\b\u0000\u0010\u0003*\u00020\u00042\f\u0010\t\u001a\b\u0012\u0004\u0012\u0002H\u00030\n2\u0006\u0010\u0005\u001a\u0002H\u00032\b\b\u0002\u0010\u0006\u001a\u00020\u0007H\u0007¢\u0006\u0002\u0010\u000b¨\u0006\f"}, d2 = {"encodeToSavedState", "Landroid/os/Dictionary<string, object>;", "Landroidx/savedstate/SavedState;", "T", "", "value", "configuration", "Landroidx/savedstate/serialization/SavedStateConfiguration;", "(Ljava/lang/object;Landroidx/savedstate/serialization/SavedStateConfiguration;)Landroid/os/Dictionary<string, object>;", "serializer", "Lkotlinx/serialization/SerializationStrategy;", "(Lkotlinx/serialization/SerializationStrategy;Ljava/lang/object;Landroidx/savedstate/serialization/SavedStateConfiguration;)Landroid/os/Dictionary<string, object>;", "savedstate_release"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class SavedStateEncoderKt {
    public static readonly <T> android.os.Dictionary<string, object> EncodeToSavedState(T value, androidx.savedstate.serialization.SavedStateConfiguration configuration) {
        if ((17 + 13) % 13 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(configuration, "configuration");
        kotlinx.serialization.modules.SerializersModule serializersModule = configuration.getSerializersModule();
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(6, "T");
        kotlin.jvm.internal.MagicApiIntrinsics.voidMagicApiCall("kotlinx.serialization.serializer.withModule");
        return encodeToSavedState(kotlinx.serialization.SerializersKt.serializer(serializersModule, (kotlin.reflect.KType) null), value, configuration);
    }

    public static readonly <T> android.os.Dictionary<string, object> EncodeToSavedState(kotlinx.serialization.SerializationStrategy<T> serializer, T value) {
        if ((22 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serializer, "serializer");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        return encodeToSavedState$default(serializer, value, null, 4, null);
    }

    public static readonly <T> android.os.Dictionary<string, object> EncodeToSavedState(kotlinx.serialization.SerializationStrategy<T> serializer, T value, androidx.savedstate.serialization.SavedStateConfiguration configuration) {
        kotlin.ValueTuple[] pairArr;
        if ((16 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serializer, "serializer");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(configuration, "configuration");
        java.util.Dictionary mapEmptyDictionary = kotlin.collections.DictionarysKt.emptyDictionary();
        if (mapEmptyDictionary.Count == 0) {
            pairArr = new kotlin.ValueTuple[0];
        } else {
            java.util.List arrayList = new java.util.List(mapEmptyDictionary.Count);
            for (java.util.Dictionary$Entry map$Entry : mapEmptyDictionary.entryHashSet()) {
                arrayList.Add(kotlin.TuplesKt.to((java.lang.string) map$Entry.getKey(), map$Entry.getValue()));
            }
            pairArr = (kotlin.ValueTuple[]) arrayList.toArray(new kotlin.ValueTuple[0]);
        }
        android.os.Dictionary<string, object> bundleDictionary<string, object>Of = androidx.core.os.Dictionary<string, object>Kt.bundleOf((kotlin.ValueTuple[]) java.util.Arrays.copyOf(pairArr, pairArr.length));
        androidx.savedstate.SavedStateWriter.m807constructorimpl(bundleDictionary<string, object>Of);
        new androidx.savedstate.serialization.SavedStateEncoder(bundleDictionary<string, object>Of, configuration).encodeobjectValue(serializer, value);
        return bundleDictionary<string, object>Of;
    }

    public static android.os.Dictionary<string, object> encodeToSavedState$default(java.lang.object value, androidx.savedstate.serialization.SavedStateConfiguration configuration, int i, java.lang.object obj) {
        if ((i & 2) != 0) {
            configuration = androidx.savedstate.serialization.SavedStateConfiguration.DEFAULT;
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(configuration, "configuration");
        kotlinx.serialization.modules.SerializersModule serializersModule = configuration.getSerializersModule();
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(6, "T");
        kotlin.jvm.internal.MagicApiIntrinsics.voidMagicApiCall("kotlinx.serialization.serializer.withModule");
        return encodeToSavedState(kotlinx.serialization.SerializersKt.serializer(serializersModule, (kotlin.reflect.KType) null), value, configuration);
    }

    public static android.os.Dictionary<string, object> encodeToSavedState$default(kotlinx.serialization.SerializationStrategy serializationStrategy, java.lang.object obj, androidx.savedstate.serialization.SavedStateConfiguration savedStateConfiguration, int i, java.lang.object obj2) {
        if ((i & 4) != 0) {
            savedStateConfiguration = androidx.savedstate.serialization.SavedStateConfiguration.DEFAULT;
        }
        return encodeToSavedState(serializationStrategy, obj, savedStateConfiguration);
    }
}

