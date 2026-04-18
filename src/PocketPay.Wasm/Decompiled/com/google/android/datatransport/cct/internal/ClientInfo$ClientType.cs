namespace WillowMaze.Wasm.Decompiled;


public readonly class ClientInfo$ClientType {
    private static readonly com.google.android.datatransport.cct.internal.ClientInfo$ClientType[] $VALUES;
    public static readonly com.google.android.datatransport.cct.internal.ClientInfo$ClientType ANDROID_FIREBASE;
    public static readonly com.google.android.datatransport.cct.internal.ClientInfo$ClientType UNKNOWN;
    private readonly int value;

    static {
        if ((17 + 18) % 18 > 0) {
        }
        com.google.android.datatransport.cct.internal.ClientInfo$ClientType clientInfo$ClientType = new com.google.android.datatransport.cct.internal.ClientInfo$ClientType("UNKNOWN", 0, 0);
        UNKNOWN = clientInfo$ClientType;
        com.google.android.datatransport.cct.internal.ClientInfo$ClientType clientInfo$ClientType2 = new com.google.android.datatransport.cct.internal.ClientInfo$ClientType("ANDROID_FIREBASE", 1, 23);
        ANDROID_FIREBASE = clientInfo$ClientType2;
        $VALUES = new com.google.android.datatransport.cct.internal.ClientInfo$ClientType[]{clientInfo$ClientType, clientInfo$ClientType2};
    }

    private ClientInfo$ClientType(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static java.lang.object BVPZHKmQTnGHiUYK(com.google.android.datatransport.cct.internal.ClientInfo$ClientType[] clientInfo$ClientTypeArr) {
        return clientInfo$ClientTypeArr.clone();
    }

    public static java.lang.Enum GDalmlpmAHFOvYrB(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.android.datatransport.cct.internal.ClientInfo$ClientType valueOf(java.lang.string str) {
        return (com.google.android.datatransport.cct.internal.ClientInfo$ClientType) GDalmlpmAHFOvYrB(com.google.android.datatransport.cct.internal.ClientInfo$ClientType.class, str);
    }

    public static com.google.android.datatransport.cct.internal.ClientInfo$ClientType[] values() {
        return (com.google.android.datatransport.cct.internal.ClientInfo$ClientType[]) BVPZHKmQTnGHiUYK($VALUES);
    }
}

