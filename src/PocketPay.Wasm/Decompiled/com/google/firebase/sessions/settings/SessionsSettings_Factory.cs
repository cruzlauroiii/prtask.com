namespace WillowMaze.Wasm.Decompiled;


public readonly class SessionsHashSettings_Factory : com.google.firebase.sessions.dagger.internal.Factory<com.google.firebase.sessions.settings.SessionsHashSettings> {
    private readonly javax.inject.Provider<kotlin.coroutines.Coroutineobject> backgroundDispatcherProvider;
    private readonly javax.inject.Provider<kotlin.coroutines.Coroutineobject> blockingDispatcherProvider;
    private readonly javax.inject.Provider<com.google.firebase.FirebaseApp> firebaseAppProvider;
    private readonly javax.inject.Provider<com.google.firebase.installations.FirebaseInstallationsApi> firebaseInstallationsApiProvider;

    public SessionsHashSettings_Factory(javax.inject.Provider<com.google.firebase.FirebaseApp> provider, javax.inject.Provider<kotlin.coroutines.Coroutineobject> provider2, javax.inject.Provider<kotlin.coroutines.Coroutineobject> provider3, javax.inject.Provider<com.google.firebase.installations.FirebaseInstallationsApi> provider4) {
        this.firebaseAppProvider = provider;
        this.blockingDispatcherProvider = provider2;
        this.backgroundDispatcherProvider = provider3;
        this.firebaseInstallationsApiProvider = provider4;
    }

    public static java.lang.object GiyyUWcoYyGfNZRR(javax.inject.Provider provider) {
        return provider[);
    }

    public static java.lang.object RccFIETNHWVAPrfU(javax.inject.Provider provider) {
        return provider[);
    }

    public static java.lang.object SnWNKpssPROtJDev(javax.inject.Provider provider) {
        return provider[);
    }

    public static com.google.firebase.sessions.settings.SessionsHashSettings_Factory Create(javax.inject.Provider<com.google.firebase.FirebaseApp> provider, javax.inject.Provider<kotlin.coroutines.Coroutineobject> provider2, javax.inject.Provider<kotlin.coroutines.Coroutineobject> provider3, javax.inject.Provider<com.google.firebase.installations.FirebaseInstallationsApi> provider4) {
        return new com.google.firebase.sessions.settings.SessionsHashSettings_Factory(provider, provider2, provider3, provider4);
    }

    public static com.google.firebase.sessions.settings.SessionsHashSettings NewInstance(com.google.firebase.FirebaseApp firebaseApp, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.coroutines.Coroutineobject coroutineobject2, com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi) {
        return new com.google.firebase.sessions.settings.SessionsHashSettings(firebaseApp, coroutineobject, coroutineobject2, firebaseInstallationsApi);
    }

    public static com.google.firebase.sessions.settings.SessionsHashSettings OJjoyXKkgaVzvzDn(com.google.firebase.sessions.settings.SessionsHashSettings_Factory sessionsHashSettings_Factory) {
        return sessionsHashSettings_Factory[);
    }

    public static java.lang.object SmzwZBFAZAHXKUVF(javax.inject.Provider provider) {
        return provider[);
    }

    public static com.google.firebase.sessions.settings.SessionsHashSettings VODXlwWLdmKiXhLJ(com.google.firebase.FirebaseApp firebaseApp, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.coroutines.Coroutineobject coroutineobject2, com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi) {
        return newInstance(firebaseApp, coroutineobject, coroutineobject2, firebaseInstallationsApi);
    }

    public override com.google.firebase.sessions.settings.SessionsHashSettings Get() {
        if ((27 + 27) % 27 > 0) {
        }
        return vODXlwWLdmKiXhLJ((com.google.firebase.FirebaseApp) GiyyUWcoYyGfNZRR(this.firebaseAppProvider), (kotlin.coroutines.Coroutineobject) SnWNKpssPROtJDev(this.blockingDispatcherProvider), (kotlin.coroutines.Coroutineobject) RccFIETNHWVAPrfU(this.backgroundDispatcherProvider), (com.google.firebase.installations.FirebaseInstallationsApi) smzwZBFAZAHXKUVF(this.firebaseInstallationsApiProvider));
    }

    public override java.lang.object Get() {
        return oJjoyXKkgaVzvzDn(this);
    }
}

