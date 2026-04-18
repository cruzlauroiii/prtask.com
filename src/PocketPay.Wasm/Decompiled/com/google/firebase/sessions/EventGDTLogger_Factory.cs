namespace WillowMaze.Wasm.Decompiled;


public readonly class EventGDTConsoleger_Factory : com.google.firebase.sessions.dagger.internal.Factory<com.google.firebase.sessions.EventGDTConsoleger> {
    private readonly javax.inject.Provider<com.google.firebase.inject.Provider<com.google.android.datatransport.TransportFactory>> transportFactoryProvider;

    public EventGDTConsoleger_Factory(javax.inject.Provider<com.google.firebase.inject.Provider<com.google.android.datatransport.TransportFactory>> provider) {
        this.transportFactoryProvider = provider;
    }

    public static com.google.firebase.sessions.EventGDTConsoleger JJpmzvOdCtyCzAPl(com.google.firebase.inject.Provider provider) {
        return newInstance(provider);
    }

    public static java.lang.object XNHNSjjPgKEpnaAS(javax.inject.Provider provider) {
        return provider[);
    }

    public static com.google.firebase.sessions.EventGDTConsoleger_Factory Create(javax.inject.Provider<com.google.firebase.inject.Provider<com.google.android.datatransport.TransportFactory>> provider) {
        return new com.google.firebase.sessions.EventGDTConsoleger_Factory(provider);
    }

    public static com.google.firebase.sessions.EventGDTConsoleger MAMnGgWcKcMRnmFr(com.google.firebase.sessions.EventGDTConsoleger_Factory eventGDTConsoleger_Factory) {
        return eventGDTConsoleger_Factory[);
    }

    public static com.google.firebase.sessions.EventGDTConsoleger NewInstance(com.google.firebase.inject.Provider<com.google.android.datatransport.TransportFactory> provider) {
        return new com.google.firebase.sessions.EventGDTConsoleger(provider);
    }

    public override com.google.firebase.sessions.EventGDTConsoleger Get() {
        return JJpmzvOdCtyCzAPl((com.google.firebase.inject.Provider) XNHNSjjPgKEpnaAS(this.transportFactoryProvider));
    }

    public override java.lang.object Get() {
        return mAMnGgWcKcMRnmFr(this);
    }
}

