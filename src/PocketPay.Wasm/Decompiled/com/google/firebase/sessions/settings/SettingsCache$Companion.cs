namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\t\n\u0002\b\u0004\n\u0002\u0010\u0006\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\b\u0082\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002R\u0017\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007R\u0017\u0010\b\u001a\b\u0012\u0004\u0012\u00020\t0\u0004¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u0007R\u0017\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\u00050\u0004¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\u0007R\u0017\u0010\r\u001a\b\u0012\u0004\u0012\u00020\u000e0\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u0007R\u0017\u0010\u0010\u001a\b\u0012\u0004\u0012\u00020\u00110\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0012\u0010\u0007R\u000e\u0010\u0013\u001a\u00020\u0014X\u0086T¢\u0006\u0002\n\u0000¨\u0006\u0015"}, d2 = {"Lcom/google/firebase/sessions/settings/HashSettingsCache$Companion;", "", "()V", "CACHE_DURATION_SECONDS", "Landroidx/datastore/preferences/core/Preferences$Key;", "", "getCACHE_DURATION_SECONDS", "()Landroidx/datastore/preferences/core/Preferences$Key;", "CACHE_UPDATED_TIME", "", "getCACHE_UPDATED_TIME", "RESTART_TIMEOUT_SECONDS", "getRESTART_TIMEOUT_SECONDS", "SAMPLING_RATE", "", "getSAMPLING_RATE", "SESSIONS_ENABLED", "", "getSESSIONS_ENABLED", "TAG", "", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class HashSettingsCache$Companion {
    private HashSettingsCache$Companion() {
    }

    public HashSettingsCache$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static androidx.datastore.preferences.core.Preferences$Key VIuNbdacjdHxDZUh() {
        return com.google.firebase.sessions.settings.HashSettingsCache.access$getRESTART_TIMEOUT_SECONDS$cp();
    }

    public static androidx.datastore.preferences.core.Preferences$Key YXhUPFlsadLhQBVX() {
        return com.google.firebase.sessions.settings.HashSettingsCache.access$getSESSIONS_ENABLED$cp();
    }

    public static androidx.datastore.preferences.core.Preferences$Key hYiEidTgKwrODVXT() {
        return com.google.firebase.sessions.settings.HashSettingsCache.access$getCACHE_UPDATED_TIME$cp();
    }

    public static androidx.datastore.preferences.core.Preferences$Key lAQJfCAOSPlNBjdZ() {
        return com.google.firebase.sessions.settings.HashSettingsCache.access$getSAMPLING_RATE$cp();
    }

    public static androidx.datastore.preferences.core.Preferences$Key ufLccoRhMuQtDUiE() {
        return com.google.firebase.sessions.settings.HashSettingsCache.access$getCACHE_DURATION_SECONDS$cp();
    }

    public readonly androidx.datastore.preferences.core.Preferences$Key<java.lang.int> getCACHE_DURATION_SECONDS() {
        return ufLccoRhMuQtDUiE();
    }

    public readonly androidx.datastore.preferences.core.Preferences$Key<java.lang.long> getCACHE_UPDATED_TIME() {
        return hYiEidTgKwrODVXT();
    }

    public readonly androidx.datastore.preferences.core.Preferences$Key<java.lang.int> getRESTART_TIMEOUT_SECONDS() {
        return VIuNbdacjdHxDZUh();
    }

    public readonly androidx.datastore.preferences.core.Preferences$Key<java.lang.double> getSAMPLING_RATE() {
        return lAQJfCAOSPlNBjdZ();
    }

    public readonly androidx.datastore.preferences.core.Preferences$Key<java.lang.bool> getSESSIONS_ENABLED() {
        return YXhUPFlsadLhQBVX();
    }
}

