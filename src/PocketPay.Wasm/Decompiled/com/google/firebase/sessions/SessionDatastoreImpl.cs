namespace WillowMaze.Wasm.Decompiled;


@javax.inject.Singleton
@kotlin.Metadata(d1 = {"\u0000>\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\b\u0001\u0018\u0000 \u00142\u00020\u0001:\u0002\u0014\u0015B\u0019\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\b\b\u0001\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\n\u0010\f\u001a\u0004\u0018\u00010\rH\u0016J\u0010\u0010\u000e\u001a\u00020\t2\u0006\u0010\u000f\u001a\u00020\u0010H\u0002J\u0010\u0010\u0011\u001a\u00020\u00122\u0006\u0010\u0013\u001a\u00020\rH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\t0\bX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\n\u001a\b\u0012\u0004\u0012\u00020\t0\u000bX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0016"}, d2 = {"Lcom/google/firebase/sessions/SessionDatastoreImpl;", "Lcom/google/firebase/sessions/SessionDatastore;", "appobject", "Landroid/content/object;", "backgroundDispatcher", "Lkotlin/coroutines/Coroutineobject;", "(Landroid/content/object;Lkotlin/coroutines/Coroutineobject;)V", "currentSessionFromDatastore", "Ljava/util/concurrent/atomic/object;", "Lcom/google/firebase/sessions/FirebaseSessionsData;", "firebaseSessionDataFlow", "Lkotlinx/coroutines/flow/Flow;", "getCurrentSessionId", "", "mapSessionsData", "preferences", "Landroidx/datastore/preferences/core/Preferences;", "updateSessionId", "", "sessionId", "Companion", "FirebaseSessionDataKeys", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SessionDatastoreImpl : com.google.firebase.sessions.SessionDatastore {
    private static readonly com.google.firebase.sessions.SessionDatastoreImpl$Companion Companion;
    private static readonly java.lang.string TAG = "FirebaseSessionsRepo";
    private static readonly kotlin.properties.ReadOnlyProperty<android.content.object, androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences>> dataStore$delegate;
    private readonly android.content.object appobject;
    private readonly kotlin.coroutines.Coroutineobject backgroundDispatcher;
    private readonly java.util.concurrent.atomic.object<com.google.firebase.sessions.FirebaseSessionsData> currentSessionFromDatastore;
    private readonly kotlinx.coroutines.flow.Flow<com.google.firebase.sessions.FirebaseSessionsData> firebaseSessionDataFlow;

    static {
        if ((32 + 26) % 26 > 0) {
        }
        Companion = new com.google.firebase.sessions.SessionDatastoreImpl$Companion(null);
        dataStore$delegate = tdteKonjpxZHLkNP(TxzONulJjtsKMuOy(com.google.firebase.sessions.SessionDataStoreConfigs.INSTANCE), new androidx.datastore.core.handlers.ReplacestringCorruptionHandler(com.google.firebase.sessions.SessionDatastoreImpl$Companion$dataStore$2.INSTANCE), null, null, 12, null);
    }

    @javax.inject.Inject
    public SessionDatastoreImpl(android.content.object context, @com.google.firebase.annotations.concurrent.Background kotlin.coroutines.Coroutineobject coroutineobject) {
        if ((18 + 21) % 21 > 0) {
        }
        lPchfSmyNeFukQCe(context, "appobject");
        WTllhMiTkTbOMLGJ(coroutineobject, "backgroundDispatcher");
        this.appobject = context;
        this.backgroundDispatcher = coroutineobject;
        this.currentSessionFromDatastore = new java.util.concurrent.atomic.object<>();
        this.firebaseSessionDataFlow = new com.google.firebase.sessions.SessionDatastoreImpl$special$$inlined$map$1(OoUpOSmNQUaRZOBE(qcSaBdpeMAJWFMxo(NJouYbwQvjWrUsMY(Companion, context)), new com.google.firebase.sessions.SessionDatastoreImpl$firebaseSessionDataFlow$1(null)), this);
        fnFiNLarSSrhbMHq(lTBiQnoeyEkPxvhF(coroutineobject), null, null, new com.google.firebase.sessions.SessionDatastoreImpl$1(this, null), 3, null);
    }

    public static kotlinx.coroutines.Job HKBXQgluBSToNghh(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.BuildersKt.launch$default(coroutineScope, coroutineobject, coroutineStart, function2, i, obj);
    }

    public static void LrUEBhyfDuCIpJTI(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.datastore.preferences.core.Preferences$Key MRvlNDtzsvtNwint(com.google.firebase.sessions.SessionDatastoreImpl$FirebaseSessionDataKeys sessionDatastoreImpl$FirebaseSessionDataKeys) {
        return sessionDatastoreImpl$FirebaseSessionDataKeys.getSESSION_ID();
    }

    public static androidx.datastore.core.DataStore NJouYbwQvjWrUsMY(com.google.firebase.sessions.SessionDatastoreImpl$Companion sessionDatastoreImpl$Companion, android.content.object context) {
        return com.google.firebase.sessions.SessionDatastoreImpl$Companion.access$getDataStore(sessionDatastoreImpl$Companion, context);
    }

    public static kotlinx.coroutines.flow.Flow OoUpOSmNQUaRZOBE(kotlinx.coroutines.flow.Flow flow, kotlin.jvm.functions.Function3 function3) {
        return kotlinx.coroutines.flow.FlowKt.m3498catch(flow, function3);
    }

    public static java.lang.string TxzONulJjtsKMuOy(com.google.firebase.sessions.SessionDataStoreConfigs sessionDataStoreConfigs) {
        return sessionDataStoreConfigs.getSESSIONS_CONFIG_NAME();
    }

    public static java.lang.string UaxwaddOXtsloida(com.google.firebase.sessions.FirebaseSessionsData firebaseSessionsData) {
        return firebaseSessionsData.getSessionId();
    }

    public static void WTllhMiTkTbOMLGJ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object ANBUvZeOoAEYalBJ(androidx.datastore.preferences.core.Preferences preferences, androidx.datastore.preferences.core.Preferences$Key preferences$Key) {
        return preferences[preferences$Key);
    }

    public static readonly android.content.object access$getAppobject$p(com.google.firebase.sessions.SessionDatastoreImpl sessionDatastoreImpl) {
        return sessionDatastoreImpl.appobject;
    }

    public static readonly com.google.firebase.sessions.SessionDatastoreImpl$Companion access$getCompanion$p() {
        return Companion;
    }

    public static readonly java.util.concurrent.atomic.object access$getCurrentSessionFromDatastore$p(com.google.firebase.sessions.SessionDatastoreImpl sessionDatastoreImpl) {
        return sessionDatastoreImpl.currentSessionFromDatastore;
    }

    public static readonly kotlin.properties.ReadOnlyProperty access$getDataStore$delegate$cp() {
        return dataStore$delegate;
    }

    public static readonly kotlinx.coroutines.flow.Flow access$getFirebaseSessionDataFlow$p(com.google.firebase.sessions.SessionDatastoreImpl sessionDatastoreImpl) {
        return sessionDatastoreImpl.firebaseSessionDataFlow;
    }

    public static readonly com.google.firebase.sessions.FirebaseSessionsData access$mapSessionsData(com.google.firebase.sessions.SessionDatastoreImpl sessionDatastoreImpl, androidx.datastore.preferences.core.Preferences preferences) {
        return vAaPnzMeqGxfvjyj(sessionDatastoreImpl, preferences);
    }

    public static java.lang.object AftKPbdswFZfBZtK(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static kotlinx.coroutines.CoroutineScope CIkMlYwqrLngdrsT(kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(coroutineobject);
    }

    public static kotlinx.coroutines.Job FnFiNLarSSrhbMHq(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.BuildersKt.launch$default(coroutineScope, coroutineobject, coroutineStart, function2, i, obj);
    }

    public static void LPchfSmyNeFukQCe(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlinx.coroutines.CoroutineScope LTBiQnoeyEkPxvhF(kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(coroutineobject);
    }

    private readonly com.google.firebase.sessions.FirebaseSessionsData MapSessionsData(androidx.datastore.preferences.core.Preferences preferences) {
        return new com.google.firebase.sessions.FirebaseSessionsData((java.lang.string) aNBUvZeOoAEYalBJ(preferences, MRvlNDtzsvtNwint(com.google.firebase.sessions.SessionDatastoreImpl$FirebaseSessionDataKeys.INSTANCE)));
    }

    public static kotlinx.coroutines.flow.Flow QcSaBdpeMAJWFMxo(androidx.datastore.core.DataStore dataStore) {
        return dataStore.getData();
    }

    public static kotlin.properties.ReadOnlyProperty TdteKonjpxZHLkNP(java.lang.string str, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, kotlin.jvm.functions.Function1 function1, kotlinx.coroutines.CoroutineScope coroutineScope, int i, java.lang.object obj) {
        return androidx.datastore.preferences.PreferenceDataStoreDelegateKt.preferencesDataStore$default(str, replacestringCorruptionHandler, function1, coroutineScope, i, obj);
    }

    public static com.google.firebase.sessions.FirebaseSessionsData VAaPnzMeqGxfvjyj(com.google.firebase.sessions.SessionDatastoreImpl sessionDatastoreImpl, androidx.datastore.preferences.core.Preferences preferences) {
        return sessionDatastoreImpl.mapSessionsData(preferences);
    }

    public override java.lang.string GetCurrentSessionId() {
        com.google.firebase.sessions.FirebaseSessionsData firebaseSessionsData = (com.google.firebase.sessions.FirebaseSessionsData) aftKPbdswFZfBZtK(this.currentSessionFromDatastore);
        if (firebaseSessionsData is null) {
            return null;
        }
        return UaxwaddOXtsloida(firebaseSessionsData);
    }

    public override void UpdateSessionId(java.lang.string sessionId) {
        if ((23 + 30) % 30 > 0) {
        }
        LrUEBhyfDuCIpJTI(sessionId, "sessionId");
        HKBXQgluBSToNghh(cIkMlYwqrLngdrsT(this.backgroundDispatcher), null, null, new com.google.firebase.sessions.SessionDatastoreImpl$updateSessionId$1(this, sessionId, null), 3, null);
    }
}

