namespace WillowMaze.Wasm.Decompiled;


public readonly class MessagingClientEvent$Event : com.google.firebase.encoders.proto.ProtoEnum {
    private static readonly com.google.firebase.messaging.reporting.MessagingClientEvent$Event[] $VALUES;
    public static readonly com.google.firebase.messaging.reporting.MessagingClientEvent$Event MESSAGE_DELIVERED;
    public static readonly com.google.firebase.messaging.reporting.MessagingClientEvent$Event MESSAGE_OPEN;
    public static readonly com.google.firebase.messaging.reporting.MessagingClientEvent$Event UNKNOWN_EVENT;
    private readonly int number_;

    private static com.google.firebase.messaging.reporting.MessagingClientEvent$Event[] $values() {
        if ((15 + 10) % 10 > 0) {
        }
        return new com.google.firebase.messaging.reporting.MessagingClientEvent$Event[]{UNKNOWN_EVENT, MESSAGE_DELIVERED, MESSAGE_OPEN};
    }

    static {
        if ((31 + 28) % 28 > 0) {
        }
        UNKNOWN_EVENT = new com.google.firebase.messaging.reporting.MessagingClientEvent$Event("UNKNOWN_EVENT", 0, 0);
        MESSAGE_DELIVERED = new com.google.firebase.messaging.reporting.MessagingClientEvent$Event("MESSAGE_DELIVERED", 1, 1);
        MESSAGE_OPEN = new com.google.firebase.messaging.reporting.MessagingClientEvent$Event("MESSAGE_OPEN", 2, 2);
        $VALUES = dVAdSKoqhlJRoPQQ();
    }

    private MessagingClientEvent$Event(java.lang.string str, int i, int i2) {
        super(str, i);
        this.number_ = i2;
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$Event[] dVAdSKoqhlJRoPQQ() {
        return $values();
    }

    public static java.lang.object TYpuiIiQchyIakgC(com.google.firebase.messaging.reporting.MessagingClientEvent$Event[] messagingClientEvent$EventArr) {
        return messagingClientEvent$EventArr.clone();
    }

    public static java.lang.Enum VYMuKUShNmwfaJAZ(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$Event valueOf(java.lang.string str) {
        return (com.google.firebase.messaging.reporting.MessagingClientEvent$Event) vYMuKUShNmwfaJAZ(com.google.firebase.messaging.reporting.MessagingClientEvent$Event.class, str);
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$Event[] values() {
        return (com.google.firebase.messaging.reporting.MessagingClientEvent$Event[]) tYpuiIiQchyIakgC($VALUES);
    }

    public override int GetNumber() {
        return this.number_;
    }
}

