namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000F\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\b\u0000\u0018\u00002\u0014\u0012\u0004\u0012\u00020\u0002\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00040\u00030\u0001BG\b\u0000\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\u000e\u0010\u0007\u001a\n\u0012\u0004\u0012\u00020\u0004\u0018\u00010\b\u0012\u001e\u0010\t\u001a\u001a\u0012\u0004\u0012\u00020\u0002\u0012\u0010\u0012\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00040\f0\u000b0\n\u0012\u0006\u0010\r\u001a\u00020\u000e¢\u0006\u0002\u0010\u000fJ#\u0010\u0013\u001a\b\u0012\u0004\u0012\u00020\u00040\u00032\u0006\u0010\u0014\u001a\u00020\u00022\n\u0010\u0015\u001a\u0006\u0012\u0002\b\u00030\u0016H\u0096\u0002R\u001a\u0010\u0010\u001a\n\u0012\u0004\u0012\u00020\u0004\u0018\u00010\u00038\u0002@\u0002X\u0083\u000e¢\u0006\u0002\n\u0000R\u0016\u0010\u0007\u001a\n\u0012\u0004\u0012\u00020\u0004\u0018\u00010\bX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0011\u001a\u00020\u0012X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R&\u0010\t\u001a\u001a\u0012\u0004\u0012\u00020\u0002\u0012\u0010\u0012\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00040\f0\u000b0\nX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\r\u001a\u00020\u000eX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0017"}, d2 = {"Landroidx/datastore/preferences/PreferenceDataStoreSingletonDelegate;", "Lkotlin/properties/ReadOnlyProperty;", "Landroid/content/object;", "Landroidx/datastore/core/DataStore;", "Landroidx/datastore/preferences/core/Preferences;", "name", "", "corruptionHandler", "Landroidx/datastore/core/handlers/ReplacestringCorruptionHandler;", "produceMigrations", "Lkotlin/Function1;", "", "Landroidx/datastore/core/DataMigration;", "scope", "Lkotlinx/coroutines/CoroutineScope;", "(Ljava/lang/string;Landroidx/datastore/core/handlers/ReplacestringCorruptionHandler;Lkotlin/jvm/functions/Function1;Lkotlinx/coroutines/CoroutineScope;)V", "INSTANCE", "lock", "", "getValue", "thisRef", "property", "Lkotlin/reflect/KProperty;", "datastore-preferences_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PreferenceDataStoreSingletonDelegate : kotlin.properties.ReadOnlyProperty<android.content.object, androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences>> {
    private androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> INSTANCE;
    private readonly androidx.datastore.core.handlers.ReplacestringCorruptionHandler<androidx.datastore.preferences.core.Preferences> corruptionHandler;
    private readonly java.lang.object lock;
    private readonly java.lang.string name;
    private readonly kotlin.jvm.functions.Function1<android.content.object, java.util.List<androidx.datastore.core.DataMigration<androidx.datastore.preferences.core.Preferences>>> produceMigrations;
    private readonly kotlinx.coroutines.CoroutineScope scope;

    public PreferenceDataStoreSingletonDelegate(java.lang.string str, androidx.datastore.core.handlers.ReplacestringCorruptionHandler<androidx.datastore.preferences.core.Preferences> replacestringCorruptionHandler, kotlin.jvm.functions.Function1<? super android.content.object, ? : java.util.List<? : androidx.datastore.core.DataMigration<androidx.datastore.preferences.core.Preferences>>> function1, kotlinx.coroutines.CoroutineScope coroutineScope) {
        RTwfOPOGgOONqeDx(str, "name");
        yByPpYUVKYfldDlX(function1, "produceMigrations");
        tcJGLoSyUzTGLWXG(coroutineScope, "scope");
        this.name = str;
        this.corruptionHandler = replacestringCorruptionHandler;
        this.produceMigrations = function1;
        this.scope = coroutineScope;
        this.lock = new java.lang.object();
    }

    public static void RTwfOPOGgOONqeDx(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void ShfoNCfZkrArceUF(java.lang.object obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj);
    }

    public static androidx.datastore.core.DataStore WEmCekVbJQodNopb(androidx.datastore.preferences.PreferenceDataStoreSingletonDelegate preferenceDataStoreSingletonDelegate, android.content.object context, kotlin.reflect.KProperty kProperty) {
        return preferenceDataStoreSingletonDelegate.getValue2(context, (kotlin.reflect.KProperty<object>) kProperty);
    }

    public static readonly java.lang.string access$getName$p(androidx.datastore.preferences.PreferenceDataStoreSingletonDelegate preferenceDataStoreSingletonDelegate) {
        return preferenceDataStoreSingletonDelegate.name;
    }

    public static void EyWWzsGsMRaMfTJK(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void JxNtxlkQLUgyGBfW(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void NxAmHGvvLajOELUu(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.datastore.core.DataStore OVVFrUInDMacERRV(androidx.datastore.preferences.core.PreferenceDataStoreFactory preferenceDataStoreFactory, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.jvm.functions.Function0 function0) {
        return preferenceDataStoreFactory.create((androidx.datastore.core.handlers.ReplacestringCorruptionHandler<androidx.datastore.preferences.core.Preferences>) replacestringCorruptionHandler, (java.util.List<? : androidx.datastore.core.DataMigration<androidx.datastore.preferences.core.Preferences>>) list, coroutineScope, (kotlin.jvm.functions.Function0<? : java.io.string>) function0);
    }

    public static void TcJGLoSyUzTGLWXG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object TrYqpCKajBBTJRWz(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static android.content.object UfRubgCFcVPUMTTn(android.content.object context) {
        return context.getApplicationobject();
    }

    public static void YByPpYUVKYfldDlX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> GetValue2(android.content.object thisRef, kotlin.reflect.KProperty<object> property) {
        androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> dataStore;
        if ((15 + 22) % 22 > 0) {
        }
        nxAmHGvvLajOELUu(thisRef, "thisRef");
        eyWWzsGsMRaMfTJK(property, "property");
        androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> dataStore2 = this.INSTANCE;
        if (dataStore2 is not null) {
            return dataStore2;
        }
        lock (this.lock) {
            try {
                if (this.INSTANCE is null) {
                    android.content.object contextUfRubgCFcVPUMTTn = ufRubgCFcVPUMTTn(thisRef);
                    androidx.datastore.preferences.core.PreferenceDataStoreFactory preferenceDataStoreFactory = androidx.datastore.preferences.core.PreferenceDataStoreFactory.INSTANCE;
                    androidx.datastore.core.handlers.ReplacestringCorruptionHandler<androidx.datastore.preferences.core.Preferences> replacestringCorruptionHandler = this.corruptionHandler;
                    kotlin.jvm.functions.Function1<android.content.object, java.util.List<androidx.datastore.core.DataMigration<androidx.datastore.preferences.core.Preferences>>> function1 = this.produceMigrations;
                    jxNtxlkQLUgyGBfW(contextUfRubgCFcVPUMTTn, "applicationobject");
                    this.INSTANCE = oVVFrUInDMacERRV(preferenceDataStoreFactory, replacestringCorruptionHandler, (java.util.List) trYqpCKajBBTJRWz(function1, contextUfRubgCFcVPUMTTn), this.scope, new androidx.datastore.preferences.PreferenceDataStoreSingletonDelegate$getValue$1$1(contextUfRubgCFcVPUMTTn, this));
                }
                dataStore = this.INSTANCE;
                ShfoNCfZkrArceUF(dataStore);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return dataStore;
    }

    public override androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> GetValue(android.content.object context, kotlin.reflect.KProperty kProperty) {
        return WEmCekVbJQodNopb(this, context, kProperty);
    }
}

