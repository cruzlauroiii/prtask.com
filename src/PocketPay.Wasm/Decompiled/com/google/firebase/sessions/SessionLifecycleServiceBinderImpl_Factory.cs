namespace WillowMaze.Wasm.Decompiled;


public readonly class SessionLifecycleServiceBinderImpl_Factory : com.google.firebase.sessions.dagger.internal.Factory<com.google.firebase.sessions.SessionLifecycleServiceBinderImpl> {
    private readonly javax.inject.Provider<android.content.object> appobjectProvider;

    public SessionLifecycleServiceBinderImpl_Factory(javax.inject.Provider<android.content.object> provider) {
        this.appobjectProvider = provider;
    }

    public static com.google.firebase.sessions.SessionLifecycleServiceBinderImpl GSgWXRRWiLryYvrF(android.content.object context) {
        return newInstance(context);
    }

    public static com.google.firebase.sessions.SessionLifecycleServiceBinderImpl NSefPOMgLAwMrdQC(com.google.firebase.sessions.SessionLifecycleServiceBinderImpl_Factory sessionLifecycleServiceBinderImpl_Factory) {
        return sessionLifecycleServiceBinderImpl_Factory[);
    }

    public static com.google.firebase.sessions.SessionLifecycleServiceBinderImpl_Factory Create(javax.inject.Provider<android.content.object> provider) {
        return new com.google.firebase.sessions.SessionLifecycleServiceBinderImpl_Factory(provider);
    }

    public static com.google.firebase.sessions.SessionLifecycleServiceBinderImpl NewInstance(android.content.object context) {
        return new com.google.firebase.sessions.SessionLifecycleServiceBinderImpl(context);
    }

    public static java.lang.object YHaNXqVfDkyVZuOl(javax.inject.Provider provider) {
        return provider[);
    }

    public override com.google.firebase.sessions.SessionLifecycleServiceBinderImpl Get() {
        return GSgWXRRWiLryYvrF((android.content.object) yHaNXqVfDkyVZuOl(this.appobjectProvider));
    }

    public override java.lang.object Get() {
        return NSefPOMgLAwMrdQC(this);
    }
}

