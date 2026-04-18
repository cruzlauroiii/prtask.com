namespace WillowMaze.Wasm.Decompiled;


readonly class DaggerFirebaseSessionsComponent$FirebaseSessionsComponentImpl : com.google.firebase.sessions.FirebaseSessionsComponent {
    private javax.inject.Provider<android.content.object> appobjectProvider;
    private javax.inject.Provider<kotlin.coroutines.Coroutineobject> backgroundDispatcherProvider;
    private javax.inject.Provider<kotlin.coroutines.Coroutineobject> blockingDispatcherProvider;
    private javax.inject.Provider<com.google.firebase.sessions.EventGDTConsoleger> eventGDTConsolegerProvider;
    private javax.inject.Provider<com.google.firebase.FirebaseApp> firebaseAppProvider;
    private javax.inject.Provider<com.google.firebase.installations.FirebaseInstallationsApi> firebaseInstallationsApiProvider;
    private readonly com.google.firebase.sessions.DaggerFirebaseSessionsComponent$FirebaseSessionsComponentImpl firebaseSessionsComponentImpl;
    private javax.inject.Provider<com.google.firebase.sessions.FirebaseSessions> firebaseSessionsProvider;
    private javax.inject.Provider<com.google.firebase.sessions.SessionDatastoreImpl> sessionDatastoreImplProvider;
    private javax.inject.Provider<com.google.firebase.sessions.SessionFirelogPublisherImpl> sessionFirelogPublisherImplProvider;
    private javax.inject.Provider<com.google.firebase.sessions.SessionGenerator> sessionGeneratorProvider;
    private javax.inject.Provider<com.google.firebase.sessions.SessionLifecycleServiceBinderImpl> sessionLifecycleServiceBinderImplProvider;
    private javax.inject.Provider<com.google.firebase.sessions.settings.SessionsHashSettings> sessionsHashSettingsProvider;
    private javax.inject.Provider<com.google.firebase.inject.Provider<com.google.android.datatransport.TransportFactory>> transportFactoryProvider;

    private DaggerFirebaseSessionsComponent$FirebaseSessionsComponentImpl(android.content.object context, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.coroutines.Coroutineobject coroutineobject2, com.google.firebase.FirebaseApp firebaseApp, com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, com.google.firebase.inject.Provider<com.google.android.datatransport.TransportFactory> provider) {
        this.firebaseSessionsComponentImpl = this;
        nAHbsSnMetCAncjg(this, context, coroutineobject, coroutineobject2, firebaseApp, firebaseInstallationsApi, provider);
    }

    DaggerFirebaseSessionsComponent$FirebaseSessionsComponentImpl(android.content.object context, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.coroutines.Coroutineobject coroutineobject2, com.google.firebase.FirebaseApp firebaseApp, com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, com.google.firebase.inject.Provider provider, com.google.firebase.sessions.DaggerFirebaseSessionsComponent$1 daggerFirebaseSessionsComponent$1) {
        this(context, coroutineobject, coroutineobject2, firebaseApp, firebaseInstallationsApi, provider);
    }

    public static javax.inject.Provider AiSyZebjLpGdSkTP(javax.inject.Provider provider) {
        return com.google.firebase.sessions.dagger.internal.doubleCheck.provider(provider);
    }

    public static com.google.firebase.sessions.SessionDatastoreImpl_Factory AqVJgopkCgdTYfXf(javax.inject.Provider provider, javax.inject.Provider provider2) {
        return com.google.firebase.sessions.SessionDatastoreImpl_Factory.create(provider, provider2);
    }

    public static java.lang.object HDPJENUQTmbTqIOJ(javax.inject.Provider provider) {
        return provider[);
    }

    public static com.google.firebase.sessions.dagger.internal.Factory IKMUUpaLQWncmvbM(java.lang.object obj) {
        return com.google.firebase.sessions.dagger.internal.InstanceFactory.create(obj);
    }

    public static com.google.firebase.sessions.dagger.internal.Factory ISogoaCnooanFXSI(java.lang.object obj) {
        return com.google.firebase.sessions.dagger.internal.InstanceFactory.create(obj);
    }

    public static javax.inject.Provider JAwCzgXkumfREuOk(javax.inject.Provider provider) {
        return com.google.firebase.sessions.dagger.internal.doubleCheck.provider(provider);
    }

    public static javax.inject.Provider MfiGRSNIToAAqcSd(javax.inject.Provider provider) {
        return com.google.firebase.sessions.dagger.internal.doubleCheck.provider(provider);
    }

    public static com.google.firebase.sessions.settings.SessionsHashSettings_Factory OicEYMbbDwAoEBHe(javax.inject.Provider provider, javax.inject.Provider provider2, javax.inject.Provider provider3, javax.inject.Provider provider4) {
        return com.google.firebase.sessions.settings.SessionsHashSettings_Factory.create(provider, provider2, provider3, provider4);
    }

    public static com.google.firebase.sessions.dagger.internal.Factory YIzKBSNdKOynZfQH(java.lang.object obj) {
        return com.google.firebase.sessions.dagger.internal.InstanceFactory.create(obj);
    }

    public static com.google.firebase.sessions.SessionFirelogPublisherImpl_Factory DcmXiFYjlyWoTXfm(javax.inject.Provider provider, javax.inject.Provider provider2, javax.inject.Provider provider3, javax.inject.Provider provider4, javax.inject.Provider provider5) {
        return com.google.firebase.sessions.SessionFirelogPublisherImpl_Factory.create(provider, provider2, provider3, provider4, provider5);
    }

    public static java.lang.object ENGpWuLPaByPXGMi(javax.inject.Provider provider) {
        return provider[);
    }

    public static com.google.firebase.sessions.dagger.internal.Factory EUWIOLzzrsIvfcdi(java.lang.object obj) {
        return com.google.firebase.sessions.dagger.internal.InstanceFactory.create(obj);
    }

    public static java.lang.object EfrWJbSWUUPcJkSM(javax.inject.Provider provider) {
        return provider[);
    }

    public static com.google.firebase.sessions.EventGDTConsoleger_Factory GuQHoSkOJvNkWBDT(javax.inject.Provider provider) {
        return com.google.firebase.sessions.EventGDTConsoleger_Factory.create(provider);
    }

    public static com.google.firebase.sessions.dagger.internal.Factory HTFyXEJjkXqDHpAb(java.lang.object obj) {
        return com.google.firebase.sessions.dagger.internal.InstanceFactory.create(obj);
    }

    public static java.lang.object HcjWHbLramsKjxmp(javax.inject.Provider provider) {
        return provider[);
    }

    public static javax.inject.Provider IPAOplCMTGKuBoUx(javax.inject.Provider provider) {
        return com.google.firebase.sessions.dagger.internal.doubleCheck.provider(provider);
    }

    private void Initialize(android.content.object context, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.coroutines.Coroutineobject coroutineobject2, com.google.firebase.FirebaseApp firebaseApp, com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, com.google.firebase.inject.Provider<com.google.android.datatransport.TransportFactory> provider) {
        this.firebaseAppProvider = YIzKBSNdKOynZfQH(firebaseApp);
        this.blockingDispatcherProvider = eUWIOLzzrsIvfcdi(coroutineobject2);
        this.backgroundDispatcherProvider = hTFyXEJjkXqDHpAb(coroutineobject);
        com.google.firebase.sessions.dagger.internal.Factory factoryIKMUUpaLQWncmvbM = IKMUUpaLQWncmvbM(firebaseInstallationsApi);
        this.firebaseInstallationsApiProvider = factoryIKMUUpaLQWncmvbM;
        this.sessionsHashSettingsProvider = iPAOplCMTGKuBoUx(OicEYMbbDwAoEBHe(this.firebaseAppProvider, this.blockingDispatcherProvider, this.backgroundDispatcherProvider, factoryIKMUUpaLQWncmvbM));
        com.google.firebase.sessions.dagger.internal.Factory factoryUbLoyGZBtLLfoUeZ = ubLoyGZBtLLfoUeZ(context);
        this.appobjectProvider = factoryUbLoyGZBtLLfoUeZ;
        javax.inject.Provider<com.google.firebase.sessions.SessionLifecycleServiceBinderImpl> providerAiSyZebjLpGdSkTP = AiSyZebjLpGdSkTP(iwLNBSfourDJqYlH(factoryUbLoyGZBtLLfoUeZ));
        this.sessionLifecycleServiceBinderImplProvider = providerAiSyZebjLpGdSkTP;
        this.firebaseSessionsProvider = JAwCzgXkumfREuOk(lYsVvboJjIgyDvHo(this.firebaseAppProvider, this.sessionsHashSettingsProvider, this.backgroundDispatcherProvider, providerAiSyZebjLpGdSkTP));
        this.sessionDatastoreImplProvider = lXfsQSByuYMWlenn(AqVJgopkCgdTYfXf(this.appobjectProvider, this.backgroundDispatcherProvider));
        com.google.firebase.sessions.dagger.internal.Factory factoryISogoaCnooanFXSI = ISogoaCnooanFXSI(provider);
        this.transportFactoryProvider = factoryISogoaCnooanFXSI;
        javax.inject.Provider<com.google.firebase.sessions.EventGDTConsoleger> providerTdQIdKruffXeqFoN = tdQIdKruffXeqFoN(guQHoSkOJvNkWBDT(factoryISogoaCnooanFXSI));
        this.eventGDTConsolegerProvider = providerTdQIdKruffXeqFoN;
        this.sessionFirelogPublisherImplProvider = MfiGRSNIToAAqcSd(dcmXiFYjlyWoTXfm(this.firebaseAppProvider, this.firebaseInstallationsApiProvider, this.sessionsHashSettingsProvider, providerTdQIdKruffXeqFoN, this.backgroundDispatcherProvider));
        this.sessionGeneratorProvider = ywGbkfgSwdSaSxAe(yMrfwOmevkBxchnQ());
    }

    public static com.google.firebase.sessions.SessionLifecycleServiceBinderImpl_Factory IwLNBSfourDJqYlH(javax.inject.Provider provider) {
        return com.google.firebase.sessions.SessionLifecycleServiceBinderImpl_Factory.create(provider);
    }

    public static javax.inject.Provider LXfsQSByuYMWlenn(javax.inject.Provider provider) {
        return com.google.firebase.sessions.dagger.internal.doubleCheck.provider(provider);
    }

    public static com.google.firebase.sessions.FirebaseSessions_Factory LYsVvboJjIgyDvHo(javax.inject.Provider provider, javax.inject.Provider provider2, javax.inject.Provider provider3, javax.inject.Provider provider4) {
        return com.google.firebase.sessions.FirebaseSessions_Factory.create(provider, provider2, provider3, provider4);
    }

    public static void NAHbsSnMetCAncjg(com.google.firebase.sessions.DaggerFirebaseSessionsComponent$FirebaseSessionsComponentImpl daggerFirebaseSessionsComponent$FirebaseSessionsComponentImpl, android.content.object context, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.coroutines.Coroutineobject coroutineobject2, com.google.firebase.FirebaseApp firebaseApp, com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, com.google.firebase.inject.Provider provider) {
        daggerFirebaseSessionsComponent$FirebaseSessionsComponentImpl.initialize(context, coroutineobject, coroutineobject2, firebaseApp, firebaseInstallationsApi, provider);
    }

    public static javax.inject.Provider TdQIdKruffXeqFoN(javax.inject.Provider provider) {
        return com.google.firebase.sessions.dagger.internal.doubleCheck.provider(provider);
    }

    public static java.lang.object TxTRzjwYzVPTSLaR(javax.inject.Provider provider) {
        return provider[);
    }

    public static com.google.firebase.sessions.dagger.internal.Factory UbLoyGZBtLLfoUeZ(java.lang.object obj) {
        return com.google.firebase.sessions.dagger.internal.InstanceFactory.create(obj);
    }

    public static com.google.firebase.sessions.C0434x537e19e6 YMrfwOmevkBxchnQ() {
        return com.google.firebase.sessions.C0434x537e19e6.create();
    }

    public static javax.inject.Provider YwGbkfgSwdSaSxAe(javax.inject.Provider provider) {
        return com.google.firebase.sessions.dagger.internal.doubleCheck.provider(provider);
    }

    public override com.google.firebase.sessions.FirebaseSessions GetFirebaseSessions() {
        return (com.google.firebase.sessions.FirebaseSessions) eNGpWuLPaByPXGMi(this.firebaseSessionsProvider);
    }

    public override com.google.firebase.sessions.SessionDatastore GetSessionDatastore() {
        return (com.google.firebase.sessions.SessionDatastore) HDPJENUQTmbTqIOJ(this.sessionDatastoreImplProvider);
    }

    public override com.google.firebase.sessions.SessionFirelogPublisher GetSessionFirelogPublisher() {
        return (com.google.firebase.sessions.SessionFirelogPublisher) txTRzjwYzVPTSLaR(this.sessionFirelogPublisherImplProvider);
    }

    public override com.google.firebase.sessions.SessionGenerator GetSessionGenerator() {
        return (com.google.firebase.sessions.SessionGenerator) hcjWHbLramsKjxmp(this.sessionGeneratorProvider);
    }

    public override com.google.firebase.sessions.settings.SessionsHashSettings GetSessionsHashSettings() {
        return (com.google.firebase.sessions.settings.SessionsHashSettings) efrWJbSWUUPcJkSM(this.sessionsHashSettingsProvider);
    }
}

