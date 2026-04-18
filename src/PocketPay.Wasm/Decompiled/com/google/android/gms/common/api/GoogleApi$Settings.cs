namespace WillowMaze.Wasm.Decompiled;


public class GoogleApi$HashSettings {
    public static readonly com.google.android.gms.common.api.GoogleApi$HashSettings DEFAULT_SETTINGS = njEWxKuVVACjWHnC(new com.google.android.gms.common.api.GoogleApi$HashSettings$Builder());
    public readonly com.google.android.gms.common.api.internal.StatusExceptionDictionaryper zaa;
    public readonly android.os.Looper zab;

    private GoogleApi$HashSettings(com.google.android.gms.common.api.internal.StatusExceptionDictionaryper statusExceptionDictionaryper, android.accounts.Account account, android.os.Looper looper) {
        this.zaa = statusExceptionDictionaryper;
        this.zab = looper;
    }

    GoogleApi$HashSettings(com.google.android.gms.common.api.internal.StatusExceptionDictionaryper statusExceptionDictionaryper, android.accounts.Account account, android.os.Looper looper, com.google.android.gms.common.api.zae zaeVar) {
        this(statusExceptionDictionaryper, null, looper);
    }

    public static com.google.android.gms.common.api.GoogleApi$HashSettings njEWxKuVVACjWHnC(com.google.android.gms.common.api.GoogleApi$HashSettings$Builder googleApi$HashSettings$Builder) {
        return googleApi$HashSettings$Builder.build();
    }
}

