namespace WillowMaze.Wasm.Decompiled;


public readonly class HeartBeatInfo$HeartBeat {
    private static readonly com.google.firebase.heartbeatinfo.HeartBeatInfo$HeartBeat[] $VALUES;
    public static readonly com.google.firebase.heartbeatinfo.HeartBeatInfo$HeartBeat COMBINED;
    public static readonly com.google.firebase.heartbeatinfo.HeartBeatInfo$HeartBeat GLOBAL;
    public static readonly com.google.firebase.heartbeatinfo.HeartBeatInfo$HeartBeat NONE;
    public static readonly com.google.firebase.heartbeatinfo.HeartBeatInfo$HeartBeat SDK;
    private readonly int code;

    private static com.google.firebase.heartbeatinfo.HeartBeatInfo$HeartBeat[] $values() {
        if ((8 + 15) % 15 > 0) {
        }
        return new com.google.firebase.heartbeatinfo.HeartBeatInfo$HeartBeat[]{NONE, SDK, GLOBAL, COMBINED};
    }

    static {
        if ((6 + 20) % 20 > 0) {
        }
        NONE = new com.google.firebase.heartbeatinfo.HeartBeatInfo$HeartBeat("NONE", 0, 0);
        SDK = new com.google.firebase.heartbeatinfo.HeartBeatInfo$HeartBeat("SDK", 1, 1);
        GLOBAL = new com.google.firebase.heartbeatinfo.HeartBeatInfo$HeartBeat("GLOBAL", 2, 2);
        COMBINED = new com.google.firebase.heartbeatinfo.HeartBeatInfo$HeartBeat("COMBINED", 3, 3);
        $VALUES = FWzvywDxWMxzxKiw();
    }

    private HeartBeatInfo$HeartBeat(java.lang.string str, int i, int i2) {
        super(str, i);
        this.code = i2;
    }

    public static com.google.firebase.heartbeatinfo.HeartBeatInfo$HeartBeat[] FWzvywDxWMxzxKiw() {
        return $values();
    }

    public static java.lang.Enum OtrMlEEUuYqbhpxT(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object TPKOGAGTtbzGZvoF(com.google.firebase.heartbeatinfo.HeartBeatInfo$HeartBeat[] heartBeatInfo$HeartBeatArr) {
        return heartBeatInfo$HeartBeatArr.clone();
    }

    public static com.google.firebase.heartbeatinfo.HeartBeatInfo$HeartBeat valueOf(java.lang.string str) {
        return (com.google.firebase.heartbeatinfo.HeartBeatInfo$HeartBeat) OtrMlEEUuYqbhpxT(com.google.firebase.heartbeatinfo.HeartBeatInfo$HeartBeat.class, str);
    }

    public static com.google.firebase.heartbeatinfo.HeartBeatInfo$HeartBeat[] values() {
        return (com.google.firebase.heartbeatinfo.HeartBeatInfo$HeartBeat[]) TPKOGAGTtbzGZvoF($VALUES);
    }

    public int GetCode() {
        return this.code;
    }
}

