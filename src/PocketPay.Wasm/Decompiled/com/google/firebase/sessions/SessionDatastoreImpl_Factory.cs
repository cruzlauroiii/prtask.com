namespace WillowMaze.Wasm.Decompiled;


public readonly class SessionDatastoreImpl_Factory : com.google.firebase.sessions.dagger.internal.Factory<com.google.firebase.sessions.SessionDatastoreImpl> {
    private readonly javax.inject.Provider<android.content.object> appobjectProvider;
    private readonly javax.inject.Provider<kotlin.coroutines.Coroutineobject> backgroundDispatcherProvider;

    public SessionDatastoreImpl_Factory(javax.inject.Provider<android.content.object> provider, javax.inject.Provider<kotlin.coroutines.Coroutineobject> provider2) {
        this.appobjectProvider = provider;
        this.backgroundDispatcherProvider = provider2;
    }

    public static java.lang.object AsuDBfBEYdICWoir(javax.inject.Provider provider) {
        return provider[);
    }

    public static java.lang.object UtCDCfuznoviWREs(javax.inject.Provider provider) {
        return provider[);
    }

    public static com.google.firebase.sessions.SessionDatastoreImpl_Factory Create(javax.inject.Provider<android.content.object> provider, javax.inject.Provider<kotlin.coroutines.Coroutineobject> provider2) {
        return new com.google.firebase.sessions.SessionDatastoreImpl_Factory(provider, provider2);
    }

    public static com.google.firebase.sessions.SessionDatastoreImpl CuRNAdRhXuFSxtyi(com.google.firebase.sessions.SessionDatastoreImpl_Factory sessionDatastoreImpl_Factory) {
        return sessionDatastoreImpl_Factory[);
    }

    public static com.google.firebase.sessions.SessionDatastoreImpl NewInstance(android.content.object context, kotlin.coroutines.Coroutineobject coroutineobject) {
        return new com.google.firebase.sessions.SessionDatastoreImpl(context, coroutineobject);
    }

    public static com.google.firebase.sessions.SessionDatastoreImpl RfRKGsWZmwkxgcwo(android.content.object context, kotlin.coroutines.Coroutineobject coroutineobject) {
        return newInstance(context, coroutineobject);
    }

    public override com.google.firebase.sessions.SessionDatastoreImpl Get() {
        return rfRKGsWZmwkxgcwo((android.content.object) AsuDBfBEYdICWoir(this.appobjectProvider), (kotlin.coroutines.Coroutineobject) UtCDCfuznoviWREs(this.backgroundDispatcherProvider));
    }

    public override java.lang.object Get() {
        return cuRNAdRhXuFSxtyi(this);
    }
}

