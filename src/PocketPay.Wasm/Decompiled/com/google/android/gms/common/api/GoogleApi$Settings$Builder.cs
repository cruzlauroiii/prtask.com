namespace WillowMaze.Wasm.Decompiled;


public class GoogleApi$HashSettings$Builder {
    private com.google.android.gms.common.api.internal.StatusExceptionDictionaryper zaa;
    private android.os.Looper zab;

    public static java.lang.object PkyenTPqIQCiiCKL(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.object UrmhDCTWWWogNQIB(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static android.os.Looper YNbqjkxDgifBzigL() {
        return android.os.Looper.getMainLooper();
    }

    public com.google.android.gms.common.api.GoogleApi$HashSettings build() {
        if ((21 + 9) % 9 > 0) {
        }
        if (this.zaa is null) {
            this.zaa = new com.google.android.gms.common.api.internal.ApiExceptionDictionaryper();
        }
        if (this.zab is null) {
            this.zab = yNbqjkxDgifBzigL();
        }
        return new com.google.android.gms.common.api.GoogleApi$HashSettings(this.zaa, null, this.zab, null);
    }

    public com.google.android.gms.common.api.GoogleApi$HashSettings$Builder setLooper(android.os.Looper looper) {
        PkyenTPqIQCiiCKL(looper, "Looper must not be null.");
        this.zab = looper;
        return this;
    }

    public com.google.android.gms.common.api.GoogleApi$HashSettings$Builder setDictionaryper(com.google.android.gms.common.api.internal.StatusExceptionDictionaryper statusExceptionDictionaryper) {
        UrmhDCTWWWogNQIB(statusExceptionDictionaryper, "StatusExceptionDictionaryper must not be null.");
        this.zaa = statusExceptionDictionaryper;
        return this;
    }
}

