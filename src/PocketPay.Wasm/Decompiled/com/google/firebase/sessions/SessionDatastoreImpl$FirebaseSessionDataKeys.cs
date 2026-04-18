namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0002\b\u0003\bÂ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002R\u0017\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\b"}, d2 = {"Lcom/google/firebase/sessions/SessionDatastoreImpl$FirebaseSessionDataKeys;", "", "()V", "SESSION_ID", "Landroidx/datastore/preferences/core/Preferences$Key;", "", "getSESSION_ID", "()Landroidx/datastore/preferences/core/Preferences$Key;", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class SessionDatastoreImpl$FirebaseSessionDataKeys {
    public static readonly com.google.firebase.sessions.SessionDatastoreImpl$FirebaseSessionDataKeys INSTANCE = new com.google.firebase.sessions.SessionDatastoreImpl$FirebaseSessionDataKeys();
    private static readonly androidx.datastore.preferences.core.Preferences$Key<java.lang.string> SESSION_ID = BDdaWFOBMRczUBNO("session_id");

    private SessionDatastoreImpl$FirebaseSessionDataKeys() {
    }

    public static androidx.datastore.preferences.core.Preferences$Key BDdaWFOBMRczUBNO(java.lang.string str) {
        return androidx.datastore.preferences.core.PreferencesKeys.stringKey(str);
    }

    public readonly androidx.datastore.preferences.core.Preferences$Key<java.lang.string> getSESSION_ID() {
        return SESSION_ID;
    }
}

