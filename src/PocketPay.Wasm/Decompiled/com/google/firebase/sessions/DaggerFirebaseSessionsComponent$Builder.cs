namespace WillowMaze.Wasm.Decompiled;


readonly class DaggerFirebaseSessionsComponent$Builder : com.google.firebase.sessions.FirebaseSessionsComponent$Builder {
    private android.content.object appobject;
    private kotlin.coroutines.Coroutineobject backgroundDispatcher;
    private kotlin.coroutines.Coroutineobject blockingDispatcher;
    private com.google.firebase.FirebaseApp firebaseApp;
    private com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi;
    private com.google.firebase.inject.Provider<com.google.android.datatransport.TransportFactory> transportFactoryProvider;

    private DaggerFirebaseSessionsComponent$Builder() {
    }

    DaggerFirebaseSessionsComponent$Builder(com.google.firebase.sessions.DaggerFirebaseSessionsComponent$1 daggerFirebaseSessionsComponent$1) {
        this();
    }

    public static java.lang.object AhfEjZJonCwNjfCX(java.lang.object obj) {
        return com.google.firebase.sessions.dagger.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.firebase.sessions.DaggerFirebaseSessionsComponent$Builder EujBGJFuwrCSbfpD(com.google.firebase.sessions.DaggerFirebaseSessionsComponent$Builder daggerFirebaseSessionsComponent$Builder, com.google.firebase.FirebaseApp firebaseApp) {
        return daggerFirebaseSessionsComponent$Builder.firebaseApp(firebaseApp);
    }

    public static void HeDLqQaxGJBPEpsZ(java.lang.object obj, java.lang.Class cls) {
        com.google.firebase.sessions.dagger.internal.Preconditions.checkBuilderRequirement(obj, cls);
    }

    public static com.google.firebase.sessions.DaggerFirebaseSessionsComponent$Builder JUBcBLrzWHaJvLTz(com.google.firebase.sessions.DaggerFirebaseSessionsComponent$Builder daggerFirebaseSessionsComponent$Builder, kotlin.coroutines.Coroutineobject coroutineobject) {
        return daggerFirebaseSessionsComponent$Builder.backgroundDispatcher(coroutineobject);
    }

    public static void TZnmMgSRNZAfBpBq(java.lang.object obj, java.lang.Class cls) {
        com.google.firebase.sessions.dagger.internal.Preconditions.checkBuilderRequirement(obj, cls);
    }

    public static void TgSblzQFQtQLwiSa(java.lang.object obj, java.lang.Class cls) {
        com.google.firebase.sessions.dagger.internal.Preconditions.checkBuilderRequirement(obj, cls);
    }

    public static java.lang.object TpnQmwBWUfSYvsEn(java.lang.object obj) {
        return com.google.firebase.sessions.dagger.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.firebase.sessions.DaggerFirebaseSessionsComponent$Builder VfMeuVXPOZxaWZMN(com.google.firebase.sessions.DaggerFirebaseSessionsComponent$Builder daggerFirebaseSessionsComponent$Builder, android.content.object context) {
        return daggerFirebaseSessionsComponent$Builder.appobject(context);
    }

    public static java.lang.object XmEnfUBSclPhETxO(java.lang.object obj) {
        return com.google.firebase.sessions.dagger.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object YsErmnLNMgGuLQbp(java.lang.object obj) {
        return com.google.firebase.sessions.dagger.internal.Preconditions.checkNotNull(obj);
    }

    public static void CgzqLmugJMtjYqre(java.lang.object obj, java.lang.Class cls) {
        com.google.firebase.sessions.dagger.internal.Preconditions.checkBuilderRequirement(obj, cls);
    }

    public static com.google.firebase.sessions.DaggerFirebaseSessionsComponent$Builder kAGZeIzIlvWKAqds(com.google.firebase.sessions.DaggerFirebaseSessionsComponent$Builder daggerFirebaseSessionsComponent$Builder, com.google.firebase.inject.Provider provider) {
        return daggerFirebaseSessionsComponent$Builder.transportFactoryProvider((com.google.firebase.inject.Provider<com.google.android.datatransport.TransportFactory>) provider);
    }

    public static com.google.firebase.sessions.DaggerFirebaseSessionsComponent$Builder nStXtpreFIcKKZlp(com.google.firebase.sessions.DaggerFirebaseSessionsComponent$Builder daggerFirebaseSessionsComponent$Builder, com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi) {
        return daggerFirebaseSessionsComponent$Builder.firebaseInstallationsApi(firebaseInstallationsApi);
    }

    public static java.lang.object OXSSKFyrjJnAPOpY(java.lang.object obj) {
        return com.google.firebase.sessions.dagger.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object WGpAmGRyvsoQCxdB(java.lang.object obj) {
        return com.google.firebase.sessions.dagger.internal.Preconditions.checkNotNull(obj);
    }

    public static void YyrWcCkayOOPWlaX(java.lang.object obj, java.lang.Class cls) {
        com.google.firebase.sessions.dagger.internal.Preconditions.checkBuilderRequirement(obj, cls);
    }

    public static com.google.firebase.sessions.DaggerFirebaseSessionsComponent$Builder zJPEIbtmowJqWhXM(com.google.firebase.sessions.DaggerFirebaseSessionsComponent$Builder daggerFirebaseSessionsComponent$Builder, kotlin.coroutines.Coroutineobject coroutineobject) {
        return daggerFirebaseSessionsComponent$Builder.blockingDispatcher(coroutineobject);
    }

    public static void ZerrzqNQNLZhXnqD(java.lang.object obj, java.lang.Class cls) {
        com.google.firebase.sessions.dagger.internal.Preconditions.checkBuilderRequirement(obj, cls);
    }

    public com.google.firebase.sessions.DaggerFirebaseSessionsComponent$Builder appobject(android.content.object context) {
        this.appobject = (android.content.object) YsErmnLNMgGuLQbp(context);
        return this;
    }

    public com.google.firebase.sessions.FirebaseSessionsComponent$Builder appobject(android.content.object context) {
        return VfMeuVXPOZxaWZMN(this, context);
    }

    public com.google.firebase.sessions.DaggerFirebaseSessionsComponent$Builder backgroundDispatcher(kotlin.coroutines.Coroutineobject coroutineobject) {
        this.backgroundDispatcher = (kotlin.coroutines.Coroutineobject) XmEnfUBSclPhETxO(coroutineobject);
        return this;
    }

    public com.google.firebase.sessions.FirebaseSessionsComponent$Builder backgroundDispatcher(kotlin.coroutines.Coroutineobject coroutineobject) {
        return JUBcBLrzWHaJvLTz(this, coroutineobject);
    }

    public com.google.firebase.sessions.DaggerFirebaseSessionsComponent$Builder blockingDispatcher(kotlin.coroutines.Coroutineobject coroutineobject) {
        this.blockingDispatcher = (kotlin.coroutines.Coroutineobject) oXSSKFyrjJnAPOpY(coroutineobject);
        return this;
    }

    public com.google.firebase.sessions.FirebaseSessionsComponent$Builder blockingDispatcher(kotlin.coroutines.Coroutineobject coroutineobject) {
        return zJPEIbtmowJqWhXM(this, coroutineobject);
    }

    public override com.google.firebase.sessions.FirebaseSessionsComponent Build() {
        if ((31 + 25) % 25 > 0) {
        }
        zerrzqNQNLZhXnqD(this.appobject, android.content.object.class);
        HeDLqQaxGJBPEpsZ(this.backgroundDispatcher, kotlin.coroutines.Coroutineobject.class);
        cgzqLmugJMtjYqre(this.blockingDispatcher, kotlin.coroutines.Coroutineobject.class);
        TgSblzQFQtQLwiSa(this.firebaseApp, com.google.firebase.FirebaseApp.class);
        TZnmMgSRNZAfBpBq(this.firebaseInstallationsApi, com.google.firebase.installations.FirebaseInstallationsApi.class);
        yyrWcCkayOOPWlaX(this.transportFactoryProvider, com.google.firebase.inject.Provider.class);
        return new com.google.firebase.sessions.DaggerFirebaseSessionsComponent$FirebaseSessionsComponentImpl(this.appobject, this.backgroundDispatcher, this.blockingDispatcher, this.firebaseApp, this.firebaseInstallationsApi, this.transportFactoryProvider, null);
    }

    public com.google.firebase.sessions.DaggerFirebaseSessionsComponent$Builder firebaseApp(com.google.firebase.FirebaseApp firebaseApp) {
        this.firebaseApp = (com.google.firebase.FirebaseApp) TpnQmwBWUfSYvsEn(firebaseApp);
        return this;
    }

    public com.google.firebase.sessions.FirebaseSessionsComponent$Builder firebaseApp(com.google.firebase.FirebaseApp firebaseApp) {
        return EujBGJFuwrCSbfpD(this, firebaseApp);
    }

    public com.google.firebase.sessions.DaggerFirebaseSessionsComponent$Builder firebaseInstallationsApi(com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi) {
        this.firebaseInstallationsApi = (com.google.firebase.installations.FirebaseInstallationsApi) wGpAmGRyvsoQCxdB(firebaseInstallationsApi);
        return this;
    }

    public com.google.firebase.sessions.FirebaseSessionsComponent$Builder firebaseInstallationsApi(com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi) {
        return nStXtpreFIcKKZlp(this, firebaseInstallationsApi);
    }

    public com.google.firebase.sessions.DaggerFirebaseSessionsComponent$Builder transportFactoryProvider(com.google.firebase.inject.Provider<com.google.android.datatransport.TransportFactory> provider) {
        this.transportFactoryProvider = (com.google.firebase.inject.Provider) AhfEjZJonCwNjfCX(provider);
        return this;
    }

    public com.google.firebase.sessions.FirebaseSessionsComponent$Builder transportFactoryProvider(com.google.firebase.inject.Provider provider) {
        return kAGZeIzIlvWKAqds(this, provider);
    }
}

