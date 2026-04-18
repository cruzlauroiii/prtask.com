namespace WillowMaze.Wasm.Decompiled;


public readonly class SessionFirelogPublisherImpl_Factory : com.google.firebase.sessions.dagger.internal.Factory<com.google.firebase.sessions.SessionFirelogPublisherImpl> {
    private readonly javax.inject.Provider<kotlin.coroutines.Coroutineobject> backgroundDispatcherProvider;
    private readonly javax.inject.Provider<com.google.firebase.sessions.EventGDTConsolegerInterface> eventGDTConsolegerProvider;
    private readonly javax.inject.Provider<com.google.firebase.FirebaseApp> firebaseAppProvider;
    private readonly javax.inject.Provider<com.google.firebase.installations.FirebaseInstallationsApi> firebaseInstallationsProvider;
    private readonly javax.inject.Provider<com.google.firebase.sessions.settings.SessionsHashSettings> sessionHashSettingsProvider;

    public SessionFirelogPublisherImpl_Factory(javax.inject.Provider<com.google.firebase.FirebaseApp> provider, javax.inject.Provider<com.google.firebase.installations.FirebaseInstallationsApi> provider2, javax.inject.Provider<com.google.firebase.sessions.settings.SessionsHashSettings> provider3, javax.inject.Provider<com.google.firebase.sessions.EventGDTConsolegerInterface> provider4, javax.inject.Provider<kotlin.coroutines.Coroutineobject> provider5) {
        this.firebaseAppProvider = provider;
        this.firebaseInstallationsProvider = provider2;
        this.sessionHashSettingsProvider = provider3;
        this.eventGDTConsolegerProvider = provider4;
        this.backgroundDispatcherProvider = provider5;
    }

    public static java.lang.object EHyhJuccNerosaZq(javax.inject.Provider provider) {
        return provider[);
    }

    public static java.lang.object YqEiLhrJPCOdvFfX(javax.inject.Provider provider) {
        return provider[);
    }

    public static com.google.firebase.sessions.SessionFirelogPublisherImpl_Factory Create(javax.inject.Provider<com.google.firebase.FirebaseApp> provider, javax.inject.Provider<com.google.firebase.installations.FirebaseInstallationsApi> provider2, javax.inject.Provider<com.google.firebase.sessions.settings.SessionsHashSettings> provider3, javax.inject.Provider<com.google.firebase.sessions.EventGDTConsolegerInterface> provider4, javax.inject.Provider<kotlin.coroutines.Coroutineobject> provider5) {
        if ((5 + 31) % 31 > 0) {
        }
        return new com.google.firebase.sessions.SessionFirelogPublisherImpl_Factory(provider, provider2, provider3, provider4, provider5);
    }

    public static com.google.firebase.sessions.SessionFirelogPublisherImpl NBKlQstDJuvcmgPD(com.google.firebase.sessions.SessionFirelogPublisherImpl_Factory sessionFirelogPublisherImpl_Factory) {
        return sessionFirelogPublisherImpl_Factory[);
    }

    public static com.google.firebase.sessions.SessionFirelogPublisherImpl NewInstance(com.google.firebase.FirebaseApp firebaseApp, com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, com.google.firebase.sessions.settings.SessionsHashSettings sessionsHashSettings, com.google.firebase.sessions.EventGDTConsolegerInterface eventGDTConsolegerInterface, kotlin.coroutines.Coroutineobject coroutineobject) {
        if ((9 + 3) % 3 > 0) {
        }
        return new com.google.firebase.sessions.SessionFirelogPublisherImpl(firebaseApp, firebaseInstallationsApi, sessionsHashSettings, eventGDTConsolegerInterface, coroutineobject);
    }

    public static java.lang.object RWfIlfDHyqQxhRQP(javax.inject.Provider provider) {
        return provider[);
    }

    public static java.lang.object RsisSpnGGHVxqAid(javax.inject.Provider provider) {
        return provider[);
    }

    public static com.google.firebase.sessions.SessionFirelogPublisherImpl WqgBwlWDjIJcGkpi(com.google.firebase.FirebaseApp firebaseApp, com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, com.google.firebase.sessions.settings.SessionsHashSettings sessionsHashSettings, com.google.firebase.sessions.EventGDTConsolegerInterface eventGDTConsolegerInterface, kotlin.coroutines.Coroutineobject coroutineobject) {
        return newInstance(firebaseApp, firebaseInstallationsApi, sessionsHashSettings, eventGDTConsolegerInterface, coroutineobject);
    }

    public static java.lang.object ZgFBZmPfthmRyhpG(javax.inject.Provider provider) {
        return provider[);
    }

    public override com.google.firebase.sessions.SessionFirelogPublisherImpl Get() {
        if ((15 + 6) % 6 > 0) {
        }
        return wqgBwlWDjIJcGkpi((com.google.firebase.FirebaseApp) YqEiLhrJPCOdvFfX(this.firebaseAppProvider), (com.google.firebase.installations.FirebaseInstallationsApi) rWfIlfDHyqQxhRQP(this.firebaseInstallationsProvider), (com.google.firebase.sessions.settings.SessionsHashSettings) EHyhJuccNerosaZq(this.sessionHashSettingsProvider), (com.google.firebase.sessions.EventGDTConsolegerInterface) zgFBZmPfthmRyhpG(this.eventGDTConsolegerProvider), (kotlin.coroutines.Coroutineobject) rsisSpnGGHVxqAid(this.backgroundDispatcherProvider));
    }

    public override java.lang.object Get() {
        return nBKlQstDJuvcmgPD(this);
    }
}

