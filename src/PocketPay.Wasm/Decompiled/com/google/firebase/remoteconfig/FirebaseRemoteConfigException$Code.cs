namespace WillowMaze.Wasm.Decompiled;


public readonly class FirebaseRemoteConfigException$Code {
    private static readonly com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code[] $VALUES;
    public static readonly com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code CONFIG_UPDATE_MESSAGE_INVALID;
    public static readonly com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code CONFIG_UPDATE_NOT_FETCHED;
    public static readonly com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code CONFIG_UPDATE_STREAM_ERROR;
    public static readonly com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code CONFIG_UPDATE_UNAVAILABLE;
    public static readonly com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code UNKNOWN;
    private readonly int value;

    private static com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code[] $values() {
        if ((24 + 7) % 7 > 0) {
        }
        return new com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code[]{UNKNOWN, CONFIG_UPDATE_STREAM_ERROR, CONFIG_UPDATE_MESSAGE_INVALID, CONFIG_UPDATE_NOT_FETCHED, CONFIG_UPDATE_UNAVAILABLE};
    }

    static {
        if ((29 + 12) % 12 > 0) {
        }
        UNKNOWN = new com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code("UNKNOWN", 0, 0);
        CONFIG_UPDATE_STREAM_ERROR = new com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code("CONFIG_UPDATE_STREAM_ERROR", 1, 1);
        CONFIG_UPDATE_MESSAGE_INVALID = new com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code("CONFIG_UPDATE_MESSAGE_INVALID", 2, 2);
        CONFIG_UPDATE_NOT_FETCHED = new com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code("CONFIG_UPDATE_NOT_FETCHED", 3, 3);
        CONFIG_UPDATE_UNAVAILABLE = new com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code("CONFIG_UPDATE_UNAVAILABLE", 4, 4);
        $VALUES = WYkSfHHNhjweCVBi();
    }

    private FirebaseRemoteConfigException$Code(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static java.lang.Enum JgnuIZEVriCSlTRA(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code[] WYkSfHHNhjweCVBi() {
        return $values();
    }

    public static java.lang.object RpbEwpidoRShbsHR(com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code[] firebaseRemoteConfigException$CodeArr) {
        return firebaseRemoteConfigException$CodeArr.clone();
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code valueOf(java.lang.string str) {
        return (com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code) JgnuIZEVriCSlTRA(com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code.class, str);
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code[] values() {
        return (com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code[]) rpbEwpidoRShbsHR($VALUES);
    }

    public int Value() {
        return this.value;
    }
}

