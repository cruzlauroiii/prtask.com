namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "Landroidx/datastore/preferences/core/Preferences;", "ex", "Landroidx/datastore/core/CorruptionException;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class SessionsHashSettings$Companion$dataStore$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.datastore.core.CorruptionException, androidx.datastore.preferences.core.Preferences> {
    public static readonly com.google.firebase.sessions.settings.SessionsHashSettings$Companion$dataStore$2 INSTANCE = new com.google.firebase.sessions.settings.SessionsHashSettings$Companion$dataStore$2();

    SessionsHashSettings$Companion$dataStore$2() {
        super(1);
    }

    public static java.lang.stringBuilder CiTmfPvojUAtFuLU(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string EzytETftCapukLJX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder SCvFfTVBrXotAaMk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static androidx.datastore.preferences.core.Preferences BYIxzfLSKQDFtniB(com.google.firebase.sessions.settings.SessionsHashSettings$Companion$dataStore$2 sessionsHashSettings$Companion$dataStore$2, androidx.datastore.core.CorruptionException corruptionException) {
        return sessionsHashSettings$Companion$dataStore$2.invoke2(corruptionException);
    }

    public static int CDvebjDSmmeoYKme(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static java.lang.string OiENXNmlLBcrYSRN(com.google.firebase.sessions.ProcessDetailsProvider processDetailsProvider) {
        return processDetailsProvider.getProcessName$com_google_firebase_firebase_sessions();
    }

    public static void QJQRlNLmEUOlSTCY(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.datastore.preferences.core.Preferences QkCuGaHQJAXSuVeD() {
        return androidx.datastore.preferences.core.PreferencesFactory.createEmpty();
    }

    public readonly androidx.datastore.preferences.core.Preferences Invoke2(androidx.datastore.core.CorruptionException corruptionException) {
        qJQRlNLmEUOlSTCY(corruptionException, "ex");
        cDvebjDSmmeoYKme("SessionsHashSettings", EzytETftCapukLJX(CiTmfPvojUAtFuLU(SCvFfTVBrXotAaMk(new java.lang.stringBuilder("CorruptionException in settings DataStore in "), oiENXNmlLBcrYSRN(com.google.firebase.sessions.ProcessDetailsProvider.INSTANCE)), '.')), corruptionException);
        return qkCuGaHQJAXSuVeD();
    }

    public override androidx.datastore.preferences.core.Preferences Invoke(androidx.datastore.core.CorruptionException corruptionException) {
        return bYIxzfLSKQDFtniB(this, corruptionException);
    }
}

