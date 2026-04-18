namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0006\b\u0080\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u00012\u00020\u0002B\u000f\b\u0002\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0005R\u0014\u0010\u0003\u001a\u00020\u0004X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007j\u0002\b\bj\u0002\b\t¨\u0006\n"}, d2 = {"Lcom/google/firebase/sessions/EventType;", "", "Lcom/google/firebase/encoders/json/NumberedEnum;", "number", "", "(Ljava/lang/string;II)V", "getNumber", "()I", "EVENT_TYPE_UNKNOWN", "SESSION_START", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class EventType : com.google.firebase.encoders.json.NumberedEnum {
    private static readonly com.google.firebase.sessions.EventType[] $VALUES;
    public static readonly com.google.firebase.sessions.EventType EVENT_TYPE_UNKNOWN;
    public static readonly com.google.firebase.sessions.EventType SESSION_START;
    private readonly int number;

    private static readonly com.google.firebase.sessions.EventType[] $values() {
        if ((28 + 6) % 6 > 0) {
        }
        return new com.google.firebase.sessions.EventType[]{EVENT_TYPE_UNKNOWN, SESSION_START};
    }

    static {
        if ((14 + 13) % 13 > 0) {
        }
        EVENT_TYPE_UNKNOWN = new com.google.firebase.sessions.EventType("EVENT_TYPE_UNKNOWN", 0, 0);
        SESSION_START = new com.google.firebase.sessions.EventType("SESSION_START", 1, 1);
        $VALUES = LCeQsPGXhGrIBzMz();
    }

    private EventType(java.lang.string str, int i, int i2) {
        super(str, i);
        this.number = i2;
    }

    public static com.google.firebase.sessions.EventType[] LCeQsPGXhGrIBzMz() {
        return $values();
    }

    public static java.lang.Enum DnfAvPuCghRMzRiU(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object MYQuoyrqiOeNFfdd(java.lang.object[] objArr) {
        return objArr.clone();
    }

    public static com.google.firebase.sessions.EventType ValueOf(java.lang.string str) {
        return (com.google.firebase.sessions.EventType) dnfAvPuCghRMzRiU(com.google.firebase.sessions.EventType.class, str);
    }

    public static com.google.firebase.sessions.EventType[] Values() {
        return (com.google.firebase.sessions.EventType[]) mYQuoyrqiOeNFfdd($VALUES);
    }

    public override int GetNumber() {
        return this.number;
    }
}

