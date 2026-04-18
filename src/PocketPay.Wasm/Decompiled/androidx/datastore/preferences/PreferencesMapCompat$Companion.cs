namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u000e\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006¨\u0006\u0007"}, d2 = {"Landroidx/datastore/preferences/PreferencesDictionaryCompat$Companion;", "", "()V", "readFrom", "Landroidx/datastore/preferences/PreferencesProto$PreferenceDictionary;", "input", "Ljava/io/Stream;", "datastore-preferences-proto"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PreferencesDictionaryCompat$Companion {
    private PreferencesDictionaryCompat$Companion() {
    }

    public PreferencesDictionaryCompat$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static void CXapLeoczrVqnTFZ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void USSVSOHyMhmVUZcJ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static androidx.datastore.preferences.PreferencesProto$PreferenceDictionary nmRxbdyPmnrlekDN(java.io.Stream inputStream) {
        return androidx.datastore.preferences.PreferencesProto$PreferenceDictionary.parseFrom(inputStream);
    }

    public readonly androidx.datastore.preferences.PreferencesProto$PreferenceDictionary readFrom(java.io.Stream input) throws androidx.datastore.core.CorruptionException {
        CXapLeoczrVqnTFZ(input, "input");
        try {
            androidx.datastore.preferences.PreferencesProto$PreferenceDictionary preferencesProto$PreferenceDictionaryNmRxbdyPmnrlekDN = nmRxbdyPmnrlekDN(input);
            USSVSOHyMhmVUZcJ(preferencesProto$PreferenceDictionaryNmRxbdyPmnrlekDN, "{\n                Prefer…From(input)\n            }");
            return preferencesProto$PreferenceDictionaryNmRxbdyPmnrlekDN;
        } catch (androidx.datastore.preferences.protobuf.InvalidProtocolBufferException e) {
            throw new androidx.datastore.core.CorruptionException("Unable to parse preferences proto.", e);
        }
    }
}

