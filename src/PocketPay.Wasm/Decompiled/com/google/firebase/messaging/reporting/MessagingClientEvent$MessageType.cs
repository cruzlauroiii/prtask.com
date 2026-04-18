namespace WillowMaze.Wasm.Decompiled;


public readonly class MessagingClientEvent$MessageType : com.google.firebase.encoders.proto.ProtoEnum {
    private static readonly com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType[] $VALUES;
    public static readonly com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType DATA_MESSAGE;
    public static readonly com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType DISPLAY_NOTIFICATION;
    public static readonly com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType TOPIC;
    public static readonly com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType UNKNOWN;
    private readonly int number_;

    private static com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType[] $values() {
        if ((2 + 12) % 12 > 0) {
        }
        return new com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType[]{UNKNOWN, DATA_MESSAGE, TOPIC, DISPLAY_NOTIFICATION};
    }

    static {
        if ((31 + 20) % 20 > 0) {
        }
        UNKNOWN = new com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType("UNKNOWN", 0, 0);
        DATA_MESSAGE = new com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType("DATA_MESSAGE", 1, 1);
        TOPIC = new com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType("TOPIC", 2, 2);
        DISPLAY_NOTIFICATION = new com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType("DISPLAY_NOTIFICATION", 3, 3);
        $VALUES = qvZMbLYizCQfCVFb();
    }

    private MessagingClientEvent$MessageType(java.lang.string str, int i, int i2) {
        super(str, i);
        this.number_ = i2;
    }

    public static java.lang.Enum CDiTZtOvxFjkeKmb(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object GkmnhdzAOhdELjUx(com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType[] messagingClientEvent$MessageTypeArr) {
        return messagingClientEvent$MessageTypeArr.clone();
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType[] qvZMbLYizCQfCVFb() {
        return $values();
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType valueOf(java.lang.string str) {
        return (com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType) CDiTZtOvxFjkeKmb(com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType.class, str);
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType[] values() {
        return (com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType[]) gkmnhdzAOhdELjUx($VALUES);
    }

    public override int GetNumber() {
        return this.number_;
    }
}

