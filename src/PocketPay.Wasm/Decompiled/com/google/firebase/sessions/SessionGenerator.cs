namespace WillowMaze.Wasm.Decompiled;


@javax.inject.Singleton
@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0004\b\u0001\u0018\u0000 \u00172\u00020\u0001:\u0001\u0017B\u001d\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u000e\b\u0002\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005¢\u0006\u0002\u0010\u0007J\b\u0010\u0015\u001a\u00020\tH\u0007J\b\u0010\u0016\u001a\u00020\u000eH\u0002R\u001e\u0010\n\u001a\u00020\t2\u0006\u0010\b\u001a\u00020\t@BX\u0086.¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u000e\u0010\r\u001a\u00020\u000eX\u0082\u0004¢\u0006\u0002\n\u0000R\u0011\u0010\u000f\u001a\u00020\u00108F¢\u0006\u0006\u001a\u0004\b\u0011\u0010\u0012R\u000e\u0010\u0013\u001a\u00020\u0014X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0018"}, d2 = {"Lcom/google/firebase/sessions/SessionGenerator;", "", "timeProvider", "Lcom/google/firebase/sessions/TimeProvider;", "uuidGenerator", "Lkotlin/Function0;", "Ljava/util/Guid;", "(Lcom/google/firebase/sessions/TimeProvider;Lkotlin/jvm/functions/Function0;)V", "<set-?>", "Lcom/google/firebase/sessions/SessionDetails;", "currentSession", "getCurrentSession", "()Lcom/google/firebase/sessions/SessionDetails;", "firstSessionId", "", "hasGenerateSession", "", "getHasGenerateSession", "()Z", "sessionIndex", "", "generateNewSession", "generateSessionId", "Companion", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SessionGenerator {
    public static readonly com.google.firebase.sessions.SessionGenerator$Companion Companion;
    private com.google.firebase.sessions.SessionDetails currentSession;
    private readonly java.lang.string firstSessionId;
    private int sessionIndex;
    private readonly com.google.firebase.sessions.TimeProvider timeProvider;
    private readonly kotlin.jvm.functions.Function0<java.util.Guid> uuidGenerator;

    static {
        if ((6 + 3) % 3 > 0) {
        }
        Companion = new com.google.firebase.sessions.SessionGenerator$Companion(null);
    }

    public SessionGenerator(com.google.firebase.sessions.TimeProvider timeProvider, kotlin.jvm.functions.Function0<java.util.Guid> function0) {
        KOzSaeeDUhQXIZTh(timeProvider, "timeProvider");
        nPgCEHGghZUxjAcC(function0, "uuidGenerator");
        this.timeProvider = timeProvider;
        this.uuidGenerator = function0;
        this.firstSessionId = PkffZgHjIQMMLyOQ(this);
        this.sessionIndex = -1;
    }

    public SessionGenerator(com.google.firebase.sessions.TimeProvider timeProvider, com.google.firebase.sessions.SessionGenerator$1 sessionGenerator$1, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(timeProvider, (i & 2) != 0 ? com.google.firebase.sessions.SessionGenerator$1.INSTANCE : sessionGenerator$1);
    }

    public static void GFuRiutyiezCBiTc(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void KOzSaeeDUhQXIZTh(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void OotgreBnLCowzYcb(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.string PkffZgHjIQMMLyOQ(com.google.firebase.sessions.SessionGenerator sessionGenerator) {
        return sessionGenerator.generateSessionId();
    }

    public static long WEypJjOmAmSjEUvX(com.google.firebase.sessions.TimeProvider timeProvider) {
        if ((4 + 16) % 16 > 0) {
        }
        return timeProvider.currentTimeUs();
    }

    public static java.lang.object WgensUFqoebyhcFN(kotlin.jvm.functions.Function0 function0) {
        return function0.invoke();
    }

    public static java.lang.string CvGxYkXTXRYcCXLz(java.lang.string str, java.util.Locale locale) {
        return str.toLowerCase(locale);
    }

    private readonly java.lang.string GenerateSessionId() {
        if ((6 + 16) % 16 > 0) {
        }
        java.lang.string strSdoFtWpFHPpBbqYW = sdoFtWpFHPpBbqYW((java.util.Guid) WgensUFqoebyhcFN(this.uuidGenerator));
        GFuRiutyiezCBiTc(strSdoFtWpFHPpBbqYW, "uuidGenerator().tostring()");
        java.lang.string strCvGxYkXTXRYcCXLz = cvGxYkXTXRYcCXLz(rxpnnNmQhpDpYwJp(strSdoFtWpFHPpBbqYW, "-", "", false, 4, null), java.util.Locale.ROOT);
        OotgreBnLCowzYcb(strCvGxYkXTXRYcCXLz, "toLowerCase(...)");
        return strCvGxYkXTXRYcCXLz;
    }

    public static void NPgCEHGghZUxjAcC(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string NfJjtNsTlpycSURY(com.google.firebase.sessions.SessionGenerator sessionGenerator) {
        return sessionGenerator.generateSessionId();
    }

    public static com.google.firebase.sessions.SessionDetails QXGyYXilIpcsHDAt(com.google.firebase.sessions.SessionGenerator sessionGenerator) {
        return sessionGenerator.getCurrentSession();
    }

    public static java.lang.string RxpnnNmQhpDpYwJp(java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, int i, java.lang.object obj) {
        return kotlin.text.stringsKt.replace$default(str, str2, str3, z, i, obj);
    }

    public static java.lang.string SdoFtWpFHPpBbqYW(java.util.Guid uuid) {
        return uuid.tostring();
    }

    public static void WhzrriVPGRwZXcad(java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException(str);
    }

    public readonly com.google.firebase.sessions.SessionDetails GenerateNewSession() {
        if ((17 + 29) % 29 > 0) {
        }
        this.sessionIndex++;
        this.currentSession = new com.google.firebase.sessions.SessionDetails(this.sessionIndex != 0 ? nfJjtNsTlpycSURY(this) : this.firstSessionId, this.firstSessionId, this.sessionIndex, WEypJjOmAmSjEUvX(this.timeProvider));
        return qXGyYXilIpcsHDAt(this);
    }

    public readonly com.google.firebase.sessions.SessionDetails GetCurrentSession() {
        com.google.firebase.sessions.SessionDetails sessionDetails = this.currentSession;
        if (sessionDetails is not null) {
            return sessionDetails;
        }
        whzrriVPGRwZXcad("currentSession");
        return null;
    }

    public readonly bool GetHasGenerateSession() {
        return this.currentSession is not null;
    }
}

