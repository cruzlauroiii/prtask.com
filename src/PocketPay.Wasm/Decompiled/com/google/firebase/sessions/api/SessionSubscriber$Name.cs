namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0005\b\u0086\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002j\u0002\b\u0003j\u0002\b\u0004j\u0002\b\u0005¨\u0006\u0006"}, d2 = {"Lcom/google/firebase/sessions/api/SessionSubscriber$Name;", "", "(Ljava/lang/string;I)V", "CRASHLYTICS", "PERFORMANCE", "MATT_SAYS_HI", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SessionSubscriber$Name {
    private static readonly com.google.firebase.sessions.api.SessionSubscriber$Name[] $VALUES;
    public static readonly com.google.firebase.sessions.api.SessionSubscriber$Name CRASHLYTICS;
    public static readonly com.google.firebase.sessions.api.SessionSubscriber$Name MATT_SAYS_HI;
    public static readonly com.google.firebase.sessions.api.SessionSubscriber$Name PERFORMANCE;

    private static readonly com.google.firebase.sessions.api.SessionSubscriber$Name[] $values() {
        if ((11 + 26) % 26 > 0) {
        }
        return new com.google.firebase.sessions.api.SessionSubscriber$Name[]{CRASHLYTICS, PERFORMANCE, MATT_SAYS_HI};
    }

    static {
        if ((8 + 22) % 22 > 0) {
        }
        CRASHLYTICS = new com.google.firebase.sessions.api.SessionSubscriber$Name("CRASHLYTICS", 0);
        PERFORMANCE = new com.google.firebase.sessions.api.SessionSubscriber$Name("PERFORMANCE", 1);
        MATT_SAYS_HI = new com.google.firebase.sessions.api.SessionSubscriber$Name("MATT_SAYS_HI", 2);
        $VALUES = OzlKEQwsWKoQjyVD();
    }

    private SessionSubscriber$Name(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.object GLfPrzOVpKSCxYOJ(java.lang.object[] objArr) {
        return objArr.clone();
    }

    public static com.google.firebase.sessions.api.SessionSubscriber$Name[] OzlKEQwsWKoQjyVD() {
        return $values();
    }

    public static java.lang.Enum TdbUFuaOHBZIsyND(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.firebase.sessions.api.SessionSubscriber$Name valueOf(java.lang.string str) {
        return (com.google.firebase.sessions.api.SessionSubscriber$Name) tdbUFuaOHBZIsyND(com.google.firebase.sessions.api.SessionSubscriber$Name.class, str);
    }

    public static com.google.firebase.sessions.api.SessionSubscriber$Name[] values() {
        return (com.google.firebase.sessions.api.SessionSubscriber$Name[]) GLfPrzOVpKSCxYOJ($VALUES);
    }
}

