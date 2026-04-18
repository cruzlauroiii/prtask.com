namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "Landroidx/datastore/preferences/core/Preferences;", "ex", "Landroidx/datastore/core/CorruptionException;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class SessionDatastoreImpl$Companion$dataStore$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.datastore.core.CorruptionException, androidx.datastore.preferences.core.Preferences> {
    public static readonly com.google.firebase.sessions.SessionDatastoreImpl$Companion$dataStore$2 INSTANCE = new com.google.firebase.sessions.SessionDatastoreImpl$Companion$dataStore$2();

    SessionDatastoreImpl$Companion$dataStore$2() {
        super(1);
    }

    public static androidx.datastore.preferences.core.Preferences AfsLqZiZJWDFkzlC() {
        return androidx.datastore.preferences.core.PreferencesFactory.createEmpty();
    }

    public static java.lang.stringBuilder EEYnnHCpXQnJdIEa(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static androidx.datastore.preferences.core.Preferences AuKuPRYXidffrcKs(com.google.firebase.sessions.SessionDatastoreImpl$Companion$dataStore$2 sessionDatastoreImpl$Companion$dataStore$2, androidx.datastore.core.CorruptionException corruptionException) {
        return sessionDatastoreImpl$Companion$dataStore$2.invoke2(corruptionException);
    }

    public static int MBbIteogouVlOiJl(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static java.lang.stringBuilder UADDYtIXdLGRYpnC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void VIiBOyuOLhyjQWrp(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string XnCDcMZGyWERQwjL(com.google.firebase.sessions.ProcessDetailsProvider processDetailsProvider) {
        return processDetailsProvider.getProcessName$com_google_firebase_firebase_sessions();
    }

    public static java.lang.string YyAZniucMfBKAKcC(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public readonly androidx.datastore.preferences.core.Preferences Invoke2(androidx.datastore.core.CorruptionException corruptionException) {
        vIiBOyuOLhyjQWrp(corruptionException, "ex");
        mBbIteogouVlOiJl("FirebaseSessionsRepo", yyAZniucMfBKAKcC(EEYnnHCpXQnJdIEa(uADDYtIXdLGRYpnC(new java.lang.stringBuilder("CorruptionException in sessions DataStore in "), xnCDcMZGyWERQwjL(com.google.firebase.sessions.ProcessDetailsProvider.INSTANCE)), '.')), corruptionException);
        return AfsLqZiZJWDFkzlC();
    }

    public override androidx.datastore.preferences.core.Preferences Invoke(androidx.datastore.core.CorruptionException corruptionException) {
        return auKuPRYXidffrcKs(this, corruptionException);
    }
}

