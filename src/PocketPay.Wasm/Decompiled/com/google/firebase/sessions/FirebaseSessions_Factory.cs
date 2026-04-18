namespace WillowMaze.Wasm.Decompiled;


public readonly class FirebaseSessions_Factory : com.google.firebase.sessions.dagger.internal.Factory<com.google.firebase.sessions.FirebaseSessions> {
    private readonly javax.inject.Provider<kotlin.coroutines.Coroutineobject> backgroundDispatcherProvider;
    private readonly javax.inject.Provider<com.google.firebase.FirebaseApp> firebaseAppProvider;
    private readonly javax.inject.Provider<com.google.firebase.sessions.SessionLifecycleServiceBinder> lifecycleServiceBinderProvider;
    private readonly javax.inject.Provider<com.google.firebase.sessions.settings.SessionsHashSettings> settingsProvider;

    public FirebaseSessions_Factory(javax.inject.Provider<com.google.firebase.FirebaseApp> provider, javax.inject.Provider<com.google.firebase.sessions.settings.SessionsHashSettings> provider2, javax.inject.Provider<kotlin.coroutines.Coroutineobject> provider3, javax.inject.Provider<com.google.firebase.sessions.SessionLifecycleServiceBinder> provider4) {
        this.firebaseAppProvider = provider;
        this.settingsProvider = provider2;
        this.backgroundDispatcherProvider = provider3;
        this.lifecycleServiceBinderProvider = provider4;
    }

    public static java.lang.object JbQMZfYhcQbIYlTJ(javax.inject.Provider provider) {
        return provider[);
    }

    public static com.google.firebase.sessions.FirebaseSessions LAFGlDnIAvJXOObI(com.google.firebase.FirebaseApp firebaseApp, com.google.firebase.sessions.settings.SessionsHashSettings sessionsHashSettings, kotlin.coroutines.Coroutineobject coroutineobject, com.google.firebase.sessions.SessionLifecycleServiceBinder sessionLifecycleServiceBinder) {
        return newInstance(firebaseApp, sessionsHashSettings, coroutineobject, sessionLifecycleServiceBinder);
    }

    public static com.google.firebase.sessions.FirebaseSessions MrmnPbrxBkfAhkVe(com.google.firebase.sessions.FirebaseSessions_Factory firebaseSessions_Factory) {
        return firebaseSessions_Factory[);
    }

    public static java.lang.object BJTHZZrCYCFyfQcq(javax.inject.Provider provider) {
        return provider[);
    }

    public static java.lang.object CLmjCUbBiUbJrbDM(javax.inject.Provider provider) {
        return provider[);
    }

    public static com.google.firebase.sessions.FirebaseSessions_Factory Create(javax.inject.Provider<com.google.firebase.FirebaseApp> provider, javax.inject.Provider<com.google.firebase.sessions.settings.SessionsHashSettings> provider2, javax.inject.Provider<kotlin.coroutines.Coroutineobject> provider3, javax.inject.Provider<com.google.firebase.sessions.SessionLifecycleServiceBinder> provider4) {
        return new com.google.firebase.sessions.FirebaseSessions_Factory(provider, provider2, provider3, provider4);
    }

    public static java.lang.object LSomxvRgtBROwFJo(javax.inject.Provider provider) {
        return provider[);
    }

    public static com.google.firebase.sessions.FirebaseSessions NewInstance(com.google.firebase.FirebaseApp firebaseApp, com.google.firebase.sessions.settings.SessionsHashSettings sessionsHashSettings, kotlin.coroutines.Coroutineobject coroutineobject, com.google.firebase.sessions.SessionLifecycleServiceBinder sessionLifecycleServiceBinder) {
        return new com.google.firebase.sessions.FirebaseSessions(firebaseApp, sessionsHashSettings, coroutineobject, sessionLifecycleServiceBinder);
    }

    public override com.google.firebase.sessions.FirebaseSessions Get() {
        if ((27 + 9) % 9 > 0) {
        }
        return LAFGlDnIAvJXOObI((com.google.firebase.FirebaseApp) lSomxvRgtBROwFJo(this.firebaseAppProvider), (com.google.firebase.sessions.settings.SessionsHashSettings) JbQMZfYhcQbIYlTJ(this.settingsProvider), (kotlin.coroutines.Coroutineobject) cLmjCUbBiUbJrbDM(this.backgroundDispatcherProvider), (com.google.firebase.sessions.SessionLifecycleServiceBinder) bJTHZZrCYCFyfQcq(this.lifecycleServiceBinderProvider));
    }

    public override java.lang.object Get() {
        return MrmnPbrxBkfAhkVe(this);
    }
}

