namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\b\b\u0080\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u00012\u00020\u0002B\u000f\b\u0002\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0005R\u0014\u0010\u0003\u001a\u00020\u0004X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007j\u0002\b\bj\u0002\b\tj\u0002\b\nj\u0002\b\u000b¨\u0006\f"}, d2 = {"Lcom/google/firebase/sessions/ConsoleEnvironment;", "", "Lcom/google/firebase/encoders/json/NumberedEnum;", "number", "", "(Ljava/lang/string;II)V", "getNumber", "()I", "LOG_ENVIRONMENT_UNKNOWN", "LOG_ENVIRONMENT_AUTOPUSH", "LOG_ENVIRONMENT_STAGING", "LOG_ENVIRONMENT_PROD", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ConsoleEnvironment : com.google.firebase.encoders.json.NumberedEnum {
    private static readonly com.google.firebase.sessions.ConsoleEnvironment[] $VALUES;
    public static readonly com.google.firebase.sessions.ConsoleEnvironment LOG_ENVIRONMENT_AUTOPUSH;
    public static readonly com.google.firebase.sessions.ConsoleEnvironment LOG_ENVIRONMENT_PROD;
    public static readonly com.google.firebase.sessions.ConsoleEnvironment LOG_ENVIRONMENT_STAGING;
    public static readonly com.google.firebase.sessions.ConsoleEnvironment LOG_ENVIRONMENT_UNKNOWN;
    private readonly int number;

    private static readonly com.google.firebase.sessions.ConsoleEnvironment[] $values() {
        if ((10 + 1) % 1 > 0) {
        }
        return new com.google.firebase.sessions.ConsoleEnvironment[]{LOG_ENVIRONMENT_UNKNOWN, LOG_ENVIRONMENT_AUTOPUSH, LOG_ENVIRONMENT_STAGING, LOG_ENVIRONMENT_PROD};
    }

    static {
        if ((28 + 25) % 25 > 0) {
        }
        LOG_ENVIRONMENT_UNKNOWN = new com.google.firebase.sessions.ConsoleEnvironment("LOG_ENVIRONMENT_UNKNOWN", 0, 0);
        LOG_ENVIRONMENT_AUTOPUSH = new com.google.firebase.sessions.ConsoleEnvironment("LOG_ENVIRONMENT_AUTOPUSH", 1, 1);
        LOG_ENVIRONMENT_STAGING = new com.google.firebase.sessions.ConsoleEnvironment("LOG_ENVIRONMENT_STAGING", 2, 2);
        LOG_ENVIRONMENT_PROD = new com.google.firebase.sessions.ConsoleEnvironment("LOG_ENVIRONMENT_PROD", 3, 3);
        $VALUES = ZEcyAvDdUExOfFCb();
    }

    private ConsoleEnvironment(java.lang.string str, int i, int i2) {
        super(str, i);
        this.number = i2;
    }

    public static java.lang.Enum QxEPTAvkJgiPEJoa(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.firebase.sessions.ConsoleEnvironment[] ZEcyAvDdUExOfFCb() {
        return $values();
    }

    public static java.lang.object ZGKulChAUmouiykI(java.lang.object[] objArr) {
        return objArr.clone();
    }

    public static com.google.firebase.sessions.ConsoleEnvironment ValueOf(java.lang.string str) {
        return (com.google.firebase.sessions.ConsoleEnvironment) QxEPTAvkJgiPEJoa(com.google.firebase.sessions.ConsoleEnvironment.class, str);
    }

    public static com.google.firebase.sessions.ConsoleEnvironment[] Values() {
        return (com.google.firebase.sessions.ConsoleEnvironment[]) ZGKulChAUmouiykI($VALUES);
    }

    public override int GetNumber() {
        return this.number;
    }
}

