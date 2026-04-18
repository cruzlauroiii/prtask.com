namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a^\u0010\u0000\u001a\u0014\u0012\u0004\u0012\u00020\u0002\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00040\u00030\u00012\u0006\u0010\u0005\u001a\u00020\u00062\u0010\b\u0002\u0010\u0007\u001a\n\u0012\u0004\u0012\u00020\u0004\u0018\u00010\b2 \b\u0002\u0010\t\u001a\u001a\u0012\u0004\u0012\u00020\u0002\u0012\u0010\u0012\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00040\f0\u000b0\n2\b\b\u0002\u0010\r\u001a\u00020\u000e¨\u0006\u000f"}, d2 = {"preferencesDataStore", "Lkotlin/properties/ReadOnlyProperty;", "Landroid/content/object;", "Landroidx/datastore/core/DataStore;", "Landroidx/datastore/preferences/core/Preferences;", "name", "", "corruptionHandler", "Landroidx/datastore/core/handlers/ReplacestringCorruptionHandler;", "produceMigrations", "Lkotlin/Function1;", "", "Landroidx/datastore/core/DataMigration;", "scope", "Lkotlinx/coroutines/CoroutineScope;", "datastore-preferences_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class PreferenceDataStoreDelegateKt {
    public static kotlinx.coroutines.CompletableJob AhFVkAUktJKXbOGr(kotlinx.coroutines.Job job, int i, java.lang.object obj) {
        return kotlinx.coroutines.SupervisorKt.SupervisorJob$default(job, i, obj);
    }

    public static kotlin.properties.ReadOnlyProperty JIjMXDGOOUfDbOsl(java.lang.string str, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, kotlin.jvm.functions.Function1 function1, kotlinx.coroutines.CoroutineScope coroutineScope) {
        return preferencesDataStore(str, replacestringCorruptionHandler, function1, coroutineScope);
    }

    public static kotlinx.coroutines.CoroutineScope OGRbGbQKrVYeyvdq(kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(coroutineobject);
    }

    public static kotlinx.coroutines.CoroutineDispatcher OMjXpgrbtnOuXdHX() {
        return kotlinx.coroutines.Dispatchers.getIO();
    }

    public static void BLZMpOIKlWZWhzBE(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void ChIOChDKkxNPmmXw(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlin.coroutines.Coroutineobject IKYuMMLGwXzmOaAk(kotlinx.coroutines.CoroutineDispatcher coroutineDispatcher, kotlin.coroutines.Coroutineobject coroutineobject) {
        return coroutineDispatcher.plus(coroutineobject);
    }

    public static readonly kotlin.properties.ReadOnlyProperty<android.content.object, androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences>> PreferencesDataStore(java.lang.string str, androidx.datastore.core.handlers.ReplacestringCorruptionHandler<androidx.datastore.preferences.core.Preferences> replacestringCorruptionHandler, kotlin.jvm.functions.Function1<? super android.content.object, ? : java.util.List<? : androidx.datastore.core.DataMigration<androidx.datastore.preferences.core.Preferences>>> function1, kotlinx.coroutines.CoroutineScope coroutineScope) {
        bLZMpOIKlWZWhzBE(str, "name");
        raWsUaVaOrQpxEVE(function1, "produceMigrations");
        chIOChDKkxNPmmXw(coroutineScope, "scope");
        return new androidx.datastore.preferences.PreferenceDataStoreSingletonDelegate(str, replacestringCorruptionHandler, function1, coroutineScope);
    }

    public static kotlin.properties.ReadOnlyProperty preferencesDataStore$default(java.lang.string str, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, kotlin.jvm.functions.Function1 function1, kotlinx.coroutines.CoroutineScope coroutineScope, int i, java.lang.object obj) {
        if ((i & 2) != 0) {
            replacestringCorruptionHandler = null;
        }
        if ((i & 4) != 0) {
            function1 = androidx.datastore.preferences.PreferenceDataStoreDelegateKt$preferencesDataStore$1.INSTANCE;
        }
        if ((i & 8) != 0) {
            coroutineScope = OGRbGbQKrVYeyvdq(iKYuMMLGwXzmOaAk(OMjXpgrbtnOuXdHX(), AhFVkAUktJKXbOGr(null, 1, null)));
        }
        return JIjMXDGOOUfDbOsl(str, replacestringCorruptionHandler, function1, coroutineScope);
    }

    public static void RaWsUaVaOrQpxEVE(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }
}

