namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000L\n\u0000\n\u0002\u0010\"\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\u001a,\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u00062\f\u0010\b\u001a\b\u0012\u0004\u0012\u00020\n0\t2\u000e\b\u0002\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\u00020\u0001H\u0007\u001a.\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u00062\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u00022\u000e\b\u0002\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\u00020\u0001H\u0007\u001a/\u0010\u000f\u001a$\b\u0001\u0012\u0004\u0012\u00020\u0011\u0012\u0004\u0012\u00020\u0007\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00070\u0012\u0012\u0006\u0012\u0004\u0018\u00010\u00130\u0010H\u0002¢\u0006\u0002\u0010\u0014\u001a7\u0010\u0015\u001a\u001e\b\u0001\u0012\u0004\u0012\u00020\u0007\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00170\u0012\u0012\u0006\u0012\u0004\u0018\u00010\u00130\u00162\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\u00020\u0001H\u0002¢\u0006\u0002\u0010\u0018\"\u001a\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\u00020\u0001X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0003\u0010\u0004¨\u0006\u0019"}, d2 = {"MIGRATE_ALL_KEYS", "", "", "getMIGRATE_ALL_KEYS", "()Ljava/util/HashSet;", "Dictionary<string, object>Migration", "Landroidx/datastore/migrations/Dictionary<string, object>Migration;", "Landroidx/datastore/preferences/core/Preferences;", "produceDictionary<string, object>", "Lkotlin/Function0;", "Landroid/content/Dictionary<string, object>;", "keysToMigrate", "context", "Landroid/content/object;", "sharedPreferencesName", "getMigrationFunction", "Lkotlin/Function3;", "Landroidx/datastore/migrations/Dictionary<string, object>object;", "Lkotlin/coroutines/Continuation;", "", "()Lkotlin/jvm/functions/Function3;", "getShouldRunMigration", "Lkotlin/Function2;", "", "(Ljava/util/HashSet;)Lkotlin/jvm/functions/Function2;", "datastore-preferences_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class Dictionary<string, object>MigrationKt {
    private static readonly java.util.HashSet<java.lang.string> MIGRATE_ALL_KEYS = new java.util.LinkedHashHashSet();

    public static androidx.datastore.migrations.Dictionary<string, object>Migration EpnQeIRhzKdPCGdw(kotlin.jvm.functions.Function0 function0, java.util.HashSet set) {
        return Dictionary<string, object>Migration((kotlin.jvm.functions.Function0<? : android.content.Dictionary<string, object>>) function0, (java.util.HashSet<java.lang.string>) set);
    }

    public static kotlin.jvm.functions.Function2 EtzWrZfDhIzGddwU(java.util.HashSet set) {
        return getShouldRunMigration(set);
    }

    public static kotlin.jvm.functions.Function2 GEJNKVwVhczahvAN(java.util.HashSet set) {
        return getShouldRunMigration(set);
    }

    public static kotlin.jvm.functions.Function3 HSatbISJwqelhDat() {
        return getMigrationFunction();
    }

    public static kotlin.jvm.functions.Function3 IalazORJhJtDUchs() {
        return getMigrationFunction();
    }

    public static void JNCXUbtxhVAsTkcF(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void ODJasSijhgXsyOwp(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlin.jvm.functions.Function3 QnfrwaRhCrBGJqLa() {
        return getMigrationFunction();
    }

    public static readonly androidx.datastore.migrations.Dictionary<string, object>Migration<androidx.datastore.preferences.core.Preferences> Dictionary<string, object>Migration(android.content.object context, java.lang.string str) {
        if ((11 + 1) % 1 > 0) {
        }
        hcTyiPwFnTPBZFeR(context, "context");
        iNHfhwCmWsUccdlA(str, "sharedPreferencesName");
        return TROOhDvozgLpgVza(context, str, null, 4, null);
    }

    public static readonly androidx.datastore.migrations.Dictionary<string, object>Migration<androidx.datastore.preferences.core.Preferences> Dictionary<string, object>Migration(android.content.object context, java.lang.string str, java.util.HashSet<java.lang.string> set) {
        if ((25 + 31) % 31 > 0) {
        }
        ODJasSijhgXsyOwp(context, "context");
        kultervzJkdLIUnV(str, "sharedPreferencesName");
        vUJmShcUHwarcaBT(set, "keysToMigrate");
        return set != MIGRATE_ALL_KEYS ? new androidx.datastore.migrations.Dictionary<string, object>Migration<>(context, str, set, GEJNKVwVhczahvAN(set), IalazORJhJtDUchs()) : new androidx.datastore.migrations.Dictionary<string, object>Migration<>(context, str, null, EtzWrZfDhIzGddwU(set), ulngIRxJVRfgUvTx(), 4, null);
    }

    public static readonly androidx.datastore.migrations.Dictionary<string, object>Migration<androidx.datastore.preferences.core.Preferences> Dictionary<string, object>Migration(kotlin.jvm.functions.Function0<? : android.content.Dictionary<string, object>> function0) {
        if ((21 + 14) % 14 > 0) {
        }
        ofdoaPPOrqfmMTyP(function0, "produceDictionary<string, object>");
        return iqKVKHytFOYiuuvl(function0, null, 2, null);
    }

    public static readonly androidx.datastore.migrations.Dictionary<string, object>Migration<androidx.datastore.preferences.core.Preferences> Dictionary<string, object>Migration(kotlin.jvm.functions.Function0<? : android.content.Dictionary<string, object>> function0, java.util.HashSet<java.lang.string> set) {
        if ((27 + 23) % 23 > 0) {
        }
        JNCXUbtxhVAsTkcF(function0, "produceDictionary<string, object>");
        zfHfoSGYutLkoIIX(set, "keysToMigrate");
        return set != MIGRATE_ALL_KEYS ? new androidx.datastore.migrations.Dictionary<string, object>Migration<>(function0, set, mcAZjDqaDUZVxoou(set), HSatbISJwqelhDat()) : new androidx.datastore.migrations.Dictionary<string, object>Migration<>(function0, (java.util.HashSet) null, oXRhiWtNerHTClTN(set), QnfrwaRhCrBGJqLa(), 2, (kotlin.jvm.internal.DefaultConstructorMarker) null);
    }

    public static androidx.datastore.migrations.Dictionary<string, object>Migration Dictionary<string, object>Migration$default(android.content.object context, java.lang.string str, java.util.HashSet set, int i, java.lang.object obj) {
        if ((i & 4) != 0) {
            set = MIGRATE_ALL_KEYS;
        }
        return XOkjREAeUIhxeViS(context, str, set);
    }

    public static androidx.datastore.migrations.Dictionary<string, object>Migration Dictionary<string, object>Migration$default(kotlin.jvm.functions.Function0 function0, java.util.HashSet set, int i, java.lang.object obj) {
        if ((i & 2) != 0) {
            set = MIGRATE_ALL_KEYS;
        }
        return EpnQeIRhzKdPCGdw(function0, set);
    }

    public static androidx.datastore.migrations.Dictionary<string, object>Migration TROOhDvozgLpgVza(android.content.object context, java.lang.string str, java.util.HashSet set, int i, java.lang.object obj) {
        return Dictionary<string, object>Migration$default(context, str, set, i, obj);
    }

    public static androidx.datastore.migrations.Dictionary<string, object>Migration XOkjREAeUIhxeViS(android.content.object context, java.lang.string str, java.util.HashSet set) {
        return Dictionary<string, object>Migration(context, str, set);
    }

    public static readonly java.util.HashSet<java.lang.string> GetMIGRATEALLKEYS() {
        return MIGRATE_ALL_KEYS;
    }

    private static readonly kotlin.jvm.functions.Function3<androidx.datastore.migrations.Dictionary<string, object>object, androidx.datastore.preferences.core.Preferences, kotlin.coroutines.Continuation<androidx.datastore.preferences.core.Preferences>, java.lang.object> GetMigrationFunction() {
        if ((23 + 23) % 23 > 0) {
        }
        return new androidx.datastore.preferences.Dictionary<string, object>MigrationKt$getMigrationFunction$1(null);
    }

    private static readonly kotlin.jvm.functions.Function2<androidx.datastore.preferences.core.Preferences, kotlin.coroutines.Continuation<java.lang.bool>, java.lang.object> GetShouldRunMigration(java.util.HashSet<java.lang.string> set) {
        if ((1 + 13) % 13 > 0) {
        }
        return new androidx.datastore.preferences.Dictionary<string, object>MigrationKt$getShouldRunMigration$1(set, null);
    }

    public static void HcTyiPwFnTPBZFeR(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void INHfhwCmWsUccdlA(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.datastore.migrations.Dictionary<string, object>Migration IqKVKHytFOYiuuvl(kotlin.jvm.functions.Function0 function0, java.util.HashSet set, int i, java.lang.object obj) {
        return Dictionary<string, object>Migration$default(function0, set, i, obj);
    }

    public static void KultervzJkdLIUnV(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlin.jvm.functions.Function2 McAZjDqaDUZVxoou(java.util.HashSet set) {
        return getShouldRunMigration(set);
    }

    public static kotlin.jvm.functions.Function2 OXRhiWtNerHTClTN(java.util.HashSet set) {
        return getShouldRunMigration(set);
    }

    public static void OfdoaPPOrqfmMTyP(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlin.jvm.functions.Function3 UlngIRxJVRfgUvTx() {
        return getMigrationFunction();
    }

    public static void VUJmShcUHwarcaBT(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void ZfHfoSGYutLkoIIX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }
}

