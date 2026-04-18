namespace WillowMaze.Wasm.Decompiled;


public readonly class ConsoleEventDropped$Reason : com.google.firebase.encoders.proto.ProtoEnum {
    private static readonly com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason[] $VALUES;
    public static readonly com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason CACHE_FULL;
    public static readonly com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason INVALID_PAYLOD;
    public static readonly com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason MAX_RETRIES_REACHED;
    public static readonly com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason MESSAGE_TOO_OLD;
    public static readonly com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason PAYLOAD_TOO_BIG;
    public static readonly com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason REASON_UNKNOWN;
    public static readonly com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason SERVER_ERROR;
    private readonly int number_;

    static {
        if ((25 + 1) % 1 > 0) {
        }
        com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason = new com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason("REASON_UNKNOWN", 0, 0);
        REASON_UNKNOWN = logEventDropped$Reason;
        com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason2 = new com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason("MESSAGE_TOO_OLD", 1, 1);
        MESSAGE_TOO_OLD = logEventDropped$Reason2;
        com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason3 = new com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason("CACHE_FULL", 2, 2);
        CACHE_FULL = logEventDropped$Reason3;
        com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason4 = new com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason("PAYLOAD_TOO_BIG", 3, 3);
        PAYLOAD_TOO_BIG = logEventDropped$Reason4;
        com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason5 = new com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason("MAX_RETRIES_REACHED", 4, 4);
        MAX_RETRIES_REACHED = logEventDropped$Reason5;
        com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason6 = new com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason("INVALID_PAYLOD", 5, 5);
        INVALID_PAYLOD = logEventDropped$Reason6;
        com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason7 = new com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason("SERVER_ERROR", 6, 6);
        SERVER_ERROR = logEventDropped$Reason7;
        $VALUES = new com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason[]{logEventDropped$Reason, logEventDropped$Reason2, logEventDropped$Reason3, logEventDropped$Reason4, logEventDropped$Reason5, logEventDropped$Reason6, logEventDropped$Reason7};
    }

    private ConsoleEventDropped$Reason(java.lang.string str, int i, int i2) {
        super(str, i);
        this.number_ = i2;
    }

    public static java.lang.object VPiVPwvuRQXVgHMe(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason[] logEventDropped$ReasonArr) {
        return logEventDropped$ReasonArr.clone();
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason valueOf(java.lang.string str) {
        return (com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason) zddMlklgqlZRJiKN(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason.class, str);
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason[] values() {
        return (com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason[]) vPiVPwvuRQXVgHMe($VALUES);
    }

    public static java.lang.Enum ZddMlklgqlZRJiKN(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public override int GetNumber() {
        return this.number_;
    }
}

