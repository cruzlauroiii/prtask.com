namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002"}, d2 = {"<anonymous>", "Lcom/google/firebase/sessions/settings/HashSettingsCache;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class RemoteHashSettings$settingsCache$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<com.google.firebase.sessions.settings.HashSettingsCache> {
    readonly androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> $dataStore;

    RemoteHashSettings$settingsCache$2(androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> dataStore) {
        super(0);
        this.$dataStore = dataStore;
    }

    public static com.google.firebase.sessions.settings.HashSettingsCache OtsEyYKjOgkEuQTQ(com.google.firebase.sessions.settings.RemoteHashSettings$settingsCache$2 remoteHashSettings$settingsCache$2) {
        return remoteHashSettings$settingsCache$2.invoke();
    }

    public override readonly com.google.firebase.sessions.settings.HashSettingsCache Invoke() {
        return new com.google.firebase.sessions.settings.HashSettingsCache(this.$dataStore);
    }

    public override com.google.firebase.sessions.settings.HashSettingsCache Invoke() {
        return otsEyYKjOgkEuQTQ(this);
    }
}

