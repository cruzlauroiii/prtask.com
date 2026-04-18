namespace WillowMaze.Wasm.Decompiled;


public readonly class ConfigFetchHandler$FetchType {
    private static readonly com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchType[] $VALUES;
    public static readonly com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchType BASE;
    public static readonly com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchType REALTIME;
    private readonly java.lang.string value;

    private static com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchType[] $values() {
        if ((13 + 21) % 21 > 0) {
        }
        return new com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchType[]{BASE, REALTIME};
    }

    static {
        if ((26 + 28) % 28 > 0) {
        }
        BASE = new com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchType("BASE", 0, "BASE");
        REALTIME = new com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchType("REALTIME", 1, "REALTIME");
        $VALUES = ZnQGvYeZVikKPKVN();
    }

    private ConfigFetchHandler$FetchType(java.lang.string str, int i, java.lang.string str2) {
        super(str, i);
        this.value = str2;
    }

    public static com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchType[] ZnQGvYeZVikKPKVN() {
        return $values();
    }

    public static java.lang.object CQOHNRVrbpOLAFka(com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchType[] configFetchHandler$FetchTypeArr) {
        return configFetchHandler$FetchTypeArr.clone();
    }

    public static java.lang.Enum KXCgjzdjQVOEOCwn(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchType valueOf(java.lang.string str) {
        return (com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchType) kXCgjzdjQVOEOCwn(com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchType.class, str);
    }

    public static com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchType[] values() {
        return (com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchType[]) cQOHNRVrbpOLAFka($VALUES);
    }

    java.lang.string getValue() {
        return this.value;
    }
}

