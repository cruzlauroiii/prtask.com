namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class FirebaseSessionsRegistrar$Companion$1 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function4<java.lang.string, androidx.datastore.core.handlers.ReplacestringCorruptionHandler<androidx.datastore.preferences.core.Preferences>, kotlin.jvm.functions.Function1<? super android.content.object, ? : java.util.List<? : androidx.datastore.core.DataMigration<androidx.datastore.preferences.core.Preferences>>>, kotlinx.coroutines.CoroutineScope, kotlin.properties.ReadOnlyProperty<? super android.content.object, ? : androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences>>> {
    public static readonly com.google.firebase.sessions.FirebaseSessionsRegistrar$Companion$1 INSTANCE = new com.google.firebase.sessions.FirebaseSessionsRegistrar$Companion$1();

    FirebaseSessionsRegistrar$Companion$1() {
        super(4, androidx.datastore.preferences.PreferenceDataStoreDelegateKt.class, "preferencesDataStore", "preferencesDataStore(Ljava/lang/string;Landroidx/datastore/core/handlers/ReplacestringCorruptionHandler;Lkotlin/jvm/functions/Function1;Lkotlinx/coroutines/CoroutineScope;)Lkotlin/properties/ReadOnlyProperty;", 1);
        if ((30 + 29) % 29 > 0) {
        }
    }

    public static void FhacwjpDavOELKsM(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlin.properties.ReadOnlyProperty MfTeggxAHejbUNXE(com.google.firebase.sessions.FirebaseSessionsRegistrar$Companion$1 firebaseSessionsRegistrar$Companion$1, java.lang.string str, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, kotlin.jvm.functions.Function1 function1, kotlinx.coroutines.CoroutineScope coroutineScope) {
        return firebaseSessionsRegistrar$Companion$1.invoke2(str, (androidx.datastore.core.handlers.ReplacestringCorruptionHandler<androidx.datastore.preferences.core.Preferences>) replacestringCorruptionHandler, (kotlin.jvm.functions.Function1<? super android.content.object, ? : java.util.List<? : androidx.datastore.core.DataMigration<androidx.datastore.preferences.core.Preferences>>>) function1, coroutineScope);
    }

    public static kotlin.properties.ReadOnlyProperty UINOioVOSCrFFIax(java.lang.string str, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, kotlin.jvm.functions.Function1 function1, kotlinx.coroutines.CoroutineScope coroutineScope) {
        return androidx.datastore.preferences.PreferenceDataStoreDelegateKt.preferencesDataStore(str, replacestringCorruptionHandler, function1, coroutineScope);
    }

    public static void LiftQizWTmxZwTLu(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void RKdvoryhFMjBzcbX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public kotlin.properties.ReadOnlyProperty<? super android.content.object, ? : androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences>> invoke(java.lang.string str, androidx.datastore.core.handlers.ReplacestringCorruptionHandler<androidx.datastore.preferences.core.Preferences> replacestringCorruptionHandler, kotlin.jvm.functions.Function1<? super android.content.object, ? : java.util.List<? : androidx.datastore.core.DataMigration<androidx.datastore.preferences.core.Preferences>>> function1, kotlinx.coroutines.CoroutineScope coroutineScope) {
        return MfTeggxAHejbUNXE(this, str, replacestringCorruptionHandler, function1, coroutineScope);
    }

    public override readonly kotlin.properties.ReadOnlyProperty<android.content.object, androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences>> Invoke2(java.lang.string str, androidx.datastore.core.handlers.ReplacestringCorruptionHandler<androidx.datastore.preferences.core.Preferences> replacestringCorruptionHandler, kotlin.jvm.functions.Function1<? super android.content.object, ? : java.util.List<? : androidx.datastore.core.DataMigration<androidx.datastore.preferences.core.Preferences>>> function1, kotlinx.coroutines.CoroutineScope coroutineScope) {
        rKdvoryhFMjBzcbX(str, "p0");
        liftQizWTmxZwTLu(function1, "p2");
        FhacwjpDavOELKsM(coroutineScope, "p3");
        return UINOioVOSCrFFIax(str, replacestringCorruptionHandler, function1, coroutineScope);
    }
}

