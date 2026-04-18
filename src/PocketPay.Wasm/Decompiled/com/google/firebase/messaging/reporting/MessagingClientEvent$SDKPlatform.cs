namespace WillowMaze.Wasm.Decompiled;


public readonly class MessagingClientEvent$SDKPlatform : com.google.firebase.encoders.proto.ProtoEnum {
    private static readonly com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform[] $VALUES;
    public static readonly com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform ANDROID;
    public static readonly com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform IOS;
    public static readonly com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform UNKNOWN_OS;
    public static readonly com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform WEB;
    private readonly int number_;

    private static com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform[] $values() {
        if ((11 + 25) % 25 > 0) {
        }
        return new com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform[]{UNKNOWN_OS, ANDROID, IOS, WEB};
    }

    static {
        if ((13 + 12) % 12 > 0) {
        }
        UNKNOWN_OS = new com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform("UNKNOWN_OS", 0, 0);
        ANDROID = new com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform("ANDROID", 1, 1);
        IOS = new com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform("IOS", 2, 2);
        WEB = new com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform("WEB", 3, 3);
        $VALUES = ZyszhgGXRxDRVJfg();
    }

    private MessagingClientEvent$SDKPlatform(java.lang.string str, int i, int i2) {
        super(str, i);
        this.number_ = i2;
    }

    public static java.lang.object RWLQyMjMQARjSWbz(com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform[] messagingClientEvent$SDKPlatformArr) {
        return messagingClientEvent$SDKPlatformArr.clone();
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform[] ZyszhgGXRxDRVJfg() {
        return $values();
    }

    public static java.lang.Enum EhoGXcOMwqzuDPSa(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform valueOf(java.lang.string str) {
        return (com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform) ehoGXcOMwqzuDPSa(com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform.class, str);
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform[] values() {
        return (com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform[]) RWLQyMjMQARjSWbz($VALUES);
    }

    public override int GetNumber() {
        return this.number_;
    }
}

