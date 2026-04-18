namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\b\u0006\u001a\r\u0010\u0000\u001a\u00020\u0001H\u0007¢\u0006\u0002\b\u0002\u001a+\u0010\u0003\u001a\u00020\u00042\u001a\u0010\u0005\u001a\u000e\u0012\n\b\u0001\u0012\u0006\u0012\u0002\b\u00030\u00070\u0006\"\u0006\u0012\u0002\b\u00030\u0007H\u0007¢\u0006\u0004\b\b\u0010\t\u001a+\u0010\n\u001a\u00020\u00012\u001a\u0010\u0005\u001a\u000e\u0012\n\b\u0001\u0012\u0006\u0012\u0002\b\u00030\u00070\u0006\"\u0006\u0012\u0002\b\u00030\u0007H\u0007¢\u0006\u0004\b\u000b\u0010\f¨\u0006\r"}, d2 = {"emptyPreferences", "Landroidx/datastore/preferences/core/Preferences;", "createEmpty", "mutablePreferencesOf", "Landroidx/datastore/preferences/core/MutablePreferences;", "pairs", "", "Landroidx/datastore/preferences/core/Preferences$ValueTuple;", "createMutable", "([Landroidx/datastore/preferences/core/Preferences$ValueTuple;)Landroidx/datastore/preferences/core/MutablePreferences;", "preferencesOf", "create", "([Landroidx/datastore/preferences/core/Preferences$ValueTuple;)Landroidx/datastore/preferences/core/Preferences;", "datastore-preferences-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class PreferencesFactory {
    public static java.lang.object[] BTXYgESRouHnTOzt(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static void UZAEOkndvhRQxStU(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static readonly androidx.datastore.preferences.core.Preferences Create(androidx.datastore.preferences.core.Preferences$ValueTuple<object>... preferences$ValueTupleArr) {
        UZAEOkndvhRQxStU(preferences$ValueTupleArr, "pairs");
        return xnyPZklijNvQzmDr((androidx.datastore.preferences.core.Preferences$ValueTuple[]) tJxOdFQdUPMuhKyY(preferences$ValueTupleArr, preferences$ValueTupleArr.length));
    }

    public static readonly androidx.datastore.preferences.core.Preferences CreateEmpty() {
        if ((25 + 5) % 5 > 0) {
        }
        return new androidx.datastore.preferences.core.MutablePreferences(null, true, 1, null);
    }

    public static readonly androidx.datastore.preferences.core.MutablePreferences CreateMutable(androidx.datastore.preferences.core.Preferences$ValueTuple<object>... preferences$ValueTupleArr) {
        if ((16 + 22) % 22 > 0) {
        }
        ivYwnJzjMPfluGFU(preferences$ValueTupleArr, "pairs");
        androidx.datastore.preferences.core.MutablePreferences mutablePreferences = new androidx.datastore.preferences.core.MutablePreferences(null, false, 1, null);
        dEKUlSPaypZEPnNP(mutablePreferences, (androidx.datastore.preferences.core.Preferences$ValueTuple[]) BTXYgESRouHnTOzt(preferences$ValueTupleArr, preferences$ValueTupleArr.length));
        return mutablePreferences;
    }

    public static void DEKUlSPaypZEPnNP(androidx.datastore.preferences.core.MutablePreferences mutablePreferences, androidx.datastore.preferences.core.Preferences$ValueTuple[] preferences$ValueTupleArr) {
        mutablePreferences.putAll(preferences$ValueTupleArr);
    }

    public static void IvYwnJzjMPfluGFU(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object[] TJxOdFQdUPMuhKyY(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static androidx.datastore.preferences.core.MutablePreferences XnyPZklijNvQzmDr(androidx.datastore.preferences.core.Preferences$ValueTuple[] preferences$ValueTupleArr) {
        return createMutable(preferences$ValueTupleArr);
    }
}

