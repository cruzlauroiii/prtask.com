namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
class HeartBeatInfoStorage {
    private static readonly java.lang.string GLOBAL = "fire-global";
    private static readonly java.lang.string HEARTBEAT_PREFERENCES_NAME = "FirebaseHeartBeat";
    private static readonly int HEART_BEAT_COUNT_LIMIT = 30;
    private static readonly java.lang.string HEART_BEAT_COUNT_TAG = "fire-count";
    private static readonly java.lang.string LAST_STORED_DATE = "last-used-date";
    private static readonly java.lang.string PREFERENCES_NAME = "FirebaseAppHeartBeat";
    private static com.google.firebase.heartbeatinfo.HeartBeatInfoStorage instance;
    private readonly android.content.Dictionary<string, object> firebaseDictionary<string, object>;

    static {
            goto L4
        L4:
            goto Lc
        L7:
            goto Lb
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
    }

    public HeartBeatInfoStorage(android.content.object r3, java.lang.string r4) {
            r2 = this;
            goto L13
        L4:
            r0 = 13
            goto L73
        Lb:
            return
        Lc:
            goto L20
        L10:
            goto L16
        L13:
            goto L23
        L16:
            goto L4
        L1a:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L27
        L20:
            goto L6f
        L23:
            goto L10
        L27:
            java.lang.string r1 = "FirebaseHeartBeat"
            goto L3b
        L2d:
            r2.firebaseDictionary<string, object> = r3
            goto Lb
        L33:
            java.lang.string r4 = RblSCRUugVSsDzOL(r4)
            goto L67
        L3b:
            r0.<init>(r1)
            goto L50
        L42:
            android.content.Dictionary<string, object> r3 = slIjCJELTMLWfkbv(r3, r4, r0)
            goto L2d
        L4a:
            int r0 = r0 + r1
            goto L58
        L50:
            java.lang.stringBuilder r4 = hWCGUkulImFlFuVP(r0, r4)
            goto L33
        L58:
            int r0 = r0 % r1
            goto L5e
        L5e:
            if (r0 <= 0) goto L63
            goto L6f
        L63:
            goto L6c
        L67:
            r0 = 0
            goto L42
        L6c:
            goto Lc
        L6f:
            goto L7a
        L73:
            r1 = 20
            goto L4a
        L7a:
            r2.<init>()
            goto L1a
    }

    HeartBeatInfoStorage(android.content.Dictionary<string, object> r1) {
            r0 = this;
            goto L19
        L4:
            return
        L5:
            goto L10
        L9:
            r0.<init>()
            goto L13
        L10:
            goto L1c
        L13:
            r0.firebaseDictionary<string, object> = r1
            goto L4
        L19:
            goto L5
        L1c:
            goto L9
    }

    public static java.lang.object ADWGMIIBLinzEFxn(java.util.IEnumerator r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.object r0 = r1.Current
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void ADWGMIIBLinzEFxn(java.util.IEnumerator r0, int r1, float r2, java.lang.string r3, byte r4) {
            goto L1d
        L4:
            goto L20
        L7:
            double r0 = (double) r3
            goto Lc
        Lc:
            return
        Ld:
            goto L4
        L11:
            int r3 = r2 + r1
            goto L7
        L17:
            r0 = 42
            goto L2a
        L1d:
            goto Ld
        L20:
            goto L17
        L24:
            int r2 = r0 * r1
            goto L11
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void ADWGMIIBLinzEFxn(java.util.IEnumerator r0, int r1, java.lang.string r2, byte r3, float r4) {
            goto L29
        L4:
            r0 = 42
            goto L10
        La:
            int r2 = r0 * r1
            goto L16
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            int r3 = r2 + r1
            goto L24
        L1c:
            goto L2c
        L1f:
            return
        L20:
            goto L1c
        L24:
            double r0 = (double) r3
            goto L1f
        L29:
            goto L20
        L2c:
            goto L4
    }

    public static void ADWGMIIBLinzEFxn(java.util.IEnumerator r0, java.lang.string r1, float r2, int r3, byte r4) {
            goto L18
        L4:
            goto L1b
        L7:
            return
        L8:
            goto L4
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L12:
            int r3 = r2 + r1
            goto L25
        L18:
            goto L8
        L1b:
            goto L2a
        L1f:
            int r2 = r0 * r1
            goto L12
        L25:
            double r0 = (double) r3
            goto L7
        L2a:
            r0 = 42
            goto Lc
    }

    public static java.time.Instant AQOqBwMPjdZBoopp(java.util.DateTime r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.time.Instant r0 = r1.toInstant()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void AQOqBwMPjdZBoopp(java.util.DateTime r0, float r1, int r2, short r3, bool r4) {
            goto L15
        L4:
            return
        L5:
            goto L2d
        L9:
            r0 = 42
            goto Lf
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L15:
            goto L5
        L18:
            goto L9
        L1c:
            int r3 = r2 + r1
            goto L22
        L22:
            double r0 = (double) r3
            goto L4
        L27:
            int r2 = r0 * r1
            goto L1c
        L2d:
            goto L18
    }

    public static void AQOqBwMPjdZBoopp(java.util.DateTime r0, int r1, bool r2, float r3, short r4) {
            goto L19
        L4:
            int r3 = r2 + r1
            goto L20
        La:
            goto L1c
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L13:
            int r2 = r0 * r1
            goto L4
        L19:
            goto L2c
        L1c:
            goto L25
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            r0 = 42
            goto Ld
        L2b:
            return
        L2c:
            goto La
    }

    public static void AQOqBwMPjdZBoopp(java.util.DateTime r0, bool r1, float r2, int r3, short r4) {
            goto L14
        L4:
            r0 = 42
            goto L1b
        La:
            return
        Lb:
            goto L2d
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            goto Lb
        L17:
            goto L4
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L21:
            int r2 = r0 * r1
            goto L27
        L27:
            int r3 = r2 + r1
            goto Lf
        L2d:
            goto L17
    }

    public static java.lang.string AguRFRdWHpPBEInY(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r1, long r2) {
            goto Lc
        L4:
            java.lang.string r0 = r1.getFormattedDateTime(r2)
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static void AguRFRdWHpPBEInY(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, long r1, char r3, int r4, byte r5, short r6) {
            goto L18
        L4:
            goto L1b
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        Ld:
            int r3 = r2 + r1
            goto L1f
        L13:
            return
        L14:
            goto L4
        L18:
            goto L14
        L1b:
            goto L24
        L1f:
            double r0 = (double) r3
            goto L13
        L24:
            r0 = 42
            goto L7
        L2a:
            int r2 = r0 * r1
            goto Ld
    }

    public static void AguRFRdWHpPBEInY(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, long r1, char r3, short r4, int r5, byte r6) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L23
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L2c
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L18:
            r0 = 42
            goto L12
        L1e:
            double r0 = (double) r3
            goto La
        L23:
            int r3 = r2 + r1
            goto L1e
        L29:
            goto Lb
        L2c:
            goto L18
    }

    public static void AguRFRdWHpPBEInY(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, long r1, int r3, byte r4, short r5, char r6) {
            goto L29
        L4:
            goto L2c
        L7:
            int r3 = r2 + r1
            goto L19
        Ld:
            int r2 = r0 * r1
            goto L7
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        L19:
            double r0 = (double) r3
            goto L1e
        L1e:
            return
        L1f:
            goto L4
        L23:
            r0 = 42
            goto L13
        L29:
            goto L1f
        L2c:
            goto L23
    }

    public static android.content.Dictionary<string, object>.Editor AjSJGXSIXEsQkBjE(android.content.Dictionary<string, object>.Editor r1, java.lang.string r2) {
            goto Lf
        L4:
            android.content.Dictionary<string, object>$Editor r0 = r1.Remove(r2)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static void AjSJGXSIXEsQkBjE(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, int r2, short r3, bool r4, byte r5) {
            goto L1a
        L4:
            return
        L5:
            goto L2d
        L9:
            int r2 = r0 * r1
            goto L21
        Lf:
            r0 = 42
            goto L27
        L15:
            double r0 = (double) r3
            goto L4
        L1a:
            goto L5
        L1d:
            goto Lf
        L21:
            int r3 = r2 + r1
            goto L15
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L2d:
            goto L1d
    }

    public static void AjSJGXSIXEsQkBjE(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, bool r2, byte r3, int r4, short r5) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            goto L12
        Ld:
            goto L16
        L11:
            return
        L12:
            goto L1c
        L16:
            r0 = 42
            goto L25
        L1c:
            goto Ld
        L1f:
            int r2 = r0 * r1
            goto L4
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L2b:
            double r0 = (double) r3
            goto L11
    }

    public static void AjSJGXSIXEsQkBjE(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, bool r2, short r3, byte r4, int r5) {
            goto L26
        L4:
            r0 = 42
            goto L20
        La:
            int r2 = r0 * r1
            goto L15
        L10:
            return
        L11:
            goto L2d
        L15:
            int r3 = r2 + r1
            goto L1b
        L1b:
            double r0 = (double) r3
            goto L10
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L26:
            goto L11
        L29:
            goto L4
        L2d:
            goto L29
    }

    public static java.util.HashSet BIKJiXwjYJUxyVmm(java.util.Dictionary r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.util.HashSet r0 = r1.entryHashSet()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void BIKJiXwjYJUxyVmm(java.util.Dictionary r0, byte r1, bool r2, java.lang.string r3, float r4) {
            goto L29
        L4:
            r0 = 42
            goto L15
        La:
            int r3 = r2 + r1
            goto L10
        L10:
            double r0 = (double) r3
            goto L24
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L1b:
            goto L2c
        L1e:
            int r2 = r0 * r1
            goto La
        L24:
            return
        L25:
            goto L1b
        L29:
            goto L25
        L2c:
            goto L4
    }

    public static void BIKJiXwjYJUxyVmm(java.util.Dictionary r0, float r1, java.lang.string r2, bool r3, byte r4) {
            goto L21
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            r0 = 42
            goto L4
        L15:
            int r2 = r0 * r1
            goto L1b
        L1b:
            int r3 = r2 + r1
            goto La
        L21:
            goto L2c
        L24:
            goto Lf
        L28:
            goto L24
        L2b:
            return
        L2c:
            goto L28
    }

    public static void BIKJiXwjYJUxyVmm(java.util.Dictionary r0, float r1, bool r2, byte r3, java.lang.string r4) {
            goto L1a
        L4:
            int r3 = r2 + r1
            goto L15
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            return
        L11:
            goto L2d
        L15:
            double r0 = (double) r3
            goto L10
        L1a:
            goto L11
        L1d:
            goto L27
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L27:
            r0 = 42
            goto L21
        L2d:
            goto L1d
    }

    public static long BZhHoKfqKiYmvkHY(android.content.Dictionary<string, object> r2, java.lang.string r3, long r4) {
            goto La
        L4:
            int r0 = r0 % r1
            goto L2e
        La:
            goto L17
        Ld:
            goto L45
        L11:
            goto Ld
        L14:
            goto L1e
        L17:
            goto L11
        L1b:
            goto L2a
        L1e:
            goto L37
        L22:
            r1 = 25
            goto L3f
        L29:
            return r0
        L2a:
            goto L14
        L2e:
            if (r0 <= 0) goto L33
            goto L1e
        L33:
            goto L1b
        L37:
            long r0 = r2.getlong(r3, r4)
            goto L29
        L3f:
            int r0 = r0 + r1
            goto L4
        L45:
            r0 = 20
            goto L22
    }

    public static void BZhHoKfqKiYmvkHY(android.content.Dictionary<string, object> r0, java.lang.string r1, long r2, char r4, short r5, bool r6, java.lang.string r7) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        La:
            int r3 = r2 + r1
            goto L16
        L10:
            r0 = 42
            goto L4
        L16:
            double r0 = (double) r3
            goto L21
        L1b:
            int r2 = r0 * r1
            goto La
        L21:
            return
        L22:
            goto L26
        L26:
            goto L2c
        L29:
            goto L22
        L2c:
            goto L10
    }

    public static void BZhHoKfqKiYmvkHY(android.content.Dictionary<string, object> r0, java.lang.string r1, long r2, short r4, bool r5, char r6, java.lang.string r7) {
            goto L15
        L4:
            return
        L5:
            goto L21
        L9:
            int r2 = r0 * r1
            goto L2a
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L15:
            goto L5
        L18:
            goto L24
        L1c:
            double r0 = (double) r3
            goto L4
        L21:
            goto L18
        L24:
            r0 = 42
            goto Lf
        L2a:
            int r3 = r2 + r1
            goto L1c
    }

    public static void BZhHoKfqKiYmvkHY(android.content.Dictionary<string, object> r0, java.lang.string r1, long r2, bool r4, short r5, char r6, java.lang.string r7) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto L1a
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L20
        L14:
            r0 = 42
            goto L2a
        L1a:
            int r3 = r2 + r1
            goto La
        L20:
            goto L26
        L23:
            goto L10
        L26:
            goto L14
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void BcnLxoYQPsLyfaUx(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, short r2, float r3, bool r4) {
            goto L1f
        L4:
            goto L22
        L7:
            int r3 = r2 + r1
            goto L2b
        Ld:
            r0 = 42
            goto L13
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L19:
            int r2 = r0 * r1
            goto L7
        L1f:
            goto L27
        L22:
            goto Ld
        L26:
            return
        L27:
            goto L4
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void BcnLxoYQPsLyfaUx(android.content.Dictionary<string, object>.Editor r0, short r1, float r2, bool r3, java.lang.string r4) {
            goto L10
        L4:
            r0 = 42
            goto L22
        La:
            int r2 = r0 * r1
            goto L1c
        L10:
            goto L18
        L13:
            goto L4
        L17:
            return
        L18:
            goto L28
        L1c:
            int r3 = r2 + r1
            goto L2b
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L28:
            goto L13
        L2b:
            double r0 = (double) r3
            goto L17
    }

    public static void BcnLxoYQPsLyfaUx(android.content.Dictionary<string, object>.Editor r0, short r1, bool r2, float r3, java.lang.string r4) {
            goto L4
        L4:
            goto L26
        L7:
            goto L14
        Lb:
            goto L7
        Le:
            int r3 = r2 + r1
            goto L20
        L14:
            r0 = 42
            goto L1a
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto Lb
        L2a:
            int r2 = r0 * r1
            goto Le
    }

    public static bool BcnLxoYQPsLyfaUx(android.content.Dictionary<string, object>.Editor r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            bool r0 = r1.commit()
            goto Le
    }

    public static android.content.Dictionary<string, object>.Editor BsGYregqFjrBSoCj(android.content.Dictionary<string, object> r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            android.content.Dictionary<string, object>$Editor r0 = r1.edit()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void BsGYregqFjrBSoCj(android.content.Dictionary<string, object> r0, byte r1, java.lang.string r2, float r3, short r4) {
            goto L1b
        L4:
            int r2 = r0 * r1
            goto L15
        La:
            r0 = 42
            goto L2a
        L10:
            double r0 = (double) r3
            goto L22
        L15:
            int r3 = r2 + r1
            goto L10
        L1b:
            goto L23
        L1e:
            goto La
        L22:
            return
        L23:
            goto L27
        L27:
            goto L1e
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void BsGYregqFjrBSoCj(android.content.Dictionary<string, object> r0, java.lang.string r1, short r2, byte r3, float r4) {
            goto L1d
        L4:
            goto L20
        L7:
            int r2 = r0 * r1
            goto L12
        Ld:
            return
        Le:
            goto L4
        L12:
            int r3 = r2 + r1
            goto L18
        L18:
            double r0 = (double) r3
            goto Ld
        L1d:
            goto Le
        L20:
            goto L2a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L2a:
            r0 = 42
            goto L24
    }

    public static void BsGYregqFjrBSoCj(android.content.Dictionary<string, object> r0, short r1, java.lang.string r2, float r3, byte r4) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L15
        L10:
            return
        L11:
            goto L1b
        L15:
            int r3 = r2 + r1
            goto L24
        L1b:
            goto L2c
        L1e:
            r0 = 42
            goto L4
        L24:
            double r0 = (double) r3
            goto L10
        L29:
            goto L11
        L2c:
            goto L1e
    }

    public static void BxNZFVdeItGczRYg(java.util.HashSet r0, java.lang.object r1, int r2, short r3, bool r4, java.lang.string r5) {
            goto L1c
        L4:
            int r3 = r2 + r1
            goto L23
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            r0 = 42
            goto L16
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L1c:
            goto L2c
        L1f:
            goto L10
        L23:
            double r0 = (double) r3
            goto L2b
        L28:
            goto L1f
        L2b:
            return
        L2c:
            goto L28
    }

    public static void BxNZFVdeItGczRYg(java.util.HashSet r0, java.lang.object r1, short r2, int r3, java.lang.string r4, bool r5) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        La:
            int r3 = r2 + r1
            goto L2b
        L10:
            goto L27
        L13:
            return
        L14:
            goto L10
        L18:
            int r2 = r0 * r1
            goto La
        L1e:
            r0 = 42
            goto L4
        L24:
            goto L14
        L27:
            goto L1e
        L2b:
            double r0 = (double) r3
            goto L13
    }

    public static void BxNZFVdeItGczRYg(java.util.HashSet r0, java.lang.object r1, short r2, java.lang.string r3, bool r4, int r5) {
            goto L10
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L22
        L10:
            goto L1e
        L13:
            goto L17
        L17:
            r0 = 42
            goto L4
        L1d:
            return
        L1e:
            goto L2d
        L22:
            int r3 = r2 + r1
            goto L28
        L28:
            double r0 = (double) r3
            goto L1d
        L2d:
            goto L13
    }

    public static bool BxNZFVdeItGczRYg(java.util.HashSet r1, java.lang.object r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            bool r0 = r1.Add(r2)
            goto Lb
    }

    public static java.util.HashSet CKwupIsHCciUHxLu(android.content.Dictionary<string, object> r1, java.lang.string r2, java.util.HashSet r3) {
            goto Lf
        L4:
            java.util.HashSet r0 = r1.getstringHashSet(r2, r3)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static void CKwupIsHCciUHxLu(android.content.Dictionary<string, object> r0, java.lang.string r1, java.util.HashSet r2, java.lang.string r3, short r4, byte r5, char r6) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L1e
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L19:
            double r0 = (double) r3
            goto Lb
        L1e:
            r0 = 42
            goto L13
        L24:
            int r3 = r2 + r1
            goto L19
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void CKwupIsHCciUHxLu(android.content.Dictionary<string, object> r0, java.lang.string r1, java.util.HashSet r2, short r3, byte r4, char r5, java.lang.string r6) {
            goto L18
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            goto L1b
        Lc:
            int r2 = r0 * r1
            goto L12
        L12:
            int r3 = r2 + r1
            goto L4
        L18:
            goto L26
        L1b:
            goto L1f
        L1f:
            r0 = 42
            goto L2a
        L25:
            return
        L26:
            goto L9
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
    }

    public static void CKwupIsHCciUHxLu(android.content.Dictionary<string, object> r0, java.lang.string r1, java.util.HashSet r2, short r3, byte r4, java.lang.string r5, char r6) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L27
        L10:
            r0 = 42
            goto L1c
        L16:
            int r3 = r2 + r1
            goto L22
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L22:
            double r0 = (double) r3
            goto Lb
        L27:
            goto L7
        L2a:
            int r2 = r0 * r1
            goto L16
    }

    public static void COfvwVMcTmUSTFgs(java.util.IEnumerator r0, char r1, int r2, short r3, float r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L16
        L11:
            double r0 = (double) r3
            goto L2b
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1c:
            int r3 = r2 + r1
            goto L11
        L22:
            goto L7
        L25:
            int r2 = r0 * r1
            goto L1c
        L2b:
            return
        L2c:
            goto L22
    }

    public static void COfvwVMcTmUSTFgs(java.util.IEnumerator r0, float r1, int r2, char r3, short r4) {
            goto L17
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L14
        Le:
            int r3 = r2 + r1
            goto L4
        L14:
            goto L1a
        L17:
            goto La
        L1a:
            goto L24
        L1e:
            int r2 = r0 * r1
            goto Le
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
    }

    public static void COfvwVMcTmUSTFgs(java.util.IEnumerator r0, int r1, short r2, char r3, float r4) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L10
        L9:
            goto L11
        Lc:
            goto L1b
        L10:
            return
        L11:
            goto L2d
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L1b:
            r0 = 42
            goto L15
        L21:
            int r3 = r2 + r1
            goto L4
        L27:
            int r2 = r0 * r1
            goto L21
        L2d:
            goto Lc
    }

    public static bool COfvwVMcTmUSTFgs(java.util.IEnumerator r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            bool r0 = r1.MoveNext()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static android.content.Dictionary<string, object>.Editor CQLxMPilTBZQeDTl(android.content.Dictionary<string, object>.Editor r1, java.lang.string r2, java.util.HashSet r3) {
            goto L14
        L4:
            goto L17
        L7:
            android.content.Dictionary<string, object>$Editor r0 = r1.putstringHashSet(r2, r3)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static void CQLxMPilTBZQeDTl(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, java.util.HashSet r2, byte r3, bool r4, int r5, short r6) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L27
        La:
            goto L12
        Ld:
            goto L21
        L11:
            return
        L12:
            goto L2d
        L16:
            double r0 = (double) r3
            goto L11
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L21:
            r0 = 42
            goto L1b
        L27:
            int r3 = r2 + r1
            goto L16
        L2d:
            goto Ld
    }

    public static void CQLxMPilTBZQeDTl(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, java.util.HashSet r2, byte r3, bool r4, short r5, int r6) {
            goto Lc
        L4:
            goto Lf
        L7:
            double r0 = (double) r3
            goto L1f
        Lc:
            goto L20
        Lf:
            goto L24
        L13:
            int r3 = r2 + r1
            goto L7
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1f:
            return
        L20:
            goto L4
        L24:
            r0 = 42
            goto L19
        L2a:
            int r2 = r0 * r1
            goto L13
    }

    public static void CQLxMPilTBZQeDTl(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, java.util.HashSet r2, int r3, bool r4, byte r5, short r6) {
            goto L1d
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            double r0 = (double) r3
            goto L15
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            return
        L16:
            goto L1a
        L1a:
            goto L20
        L1d:
            goto L16
        L20:
            goto L24
        L24:
            r0 = 42
            goto Lf
        L2a:
            int r3 = r2 + r1
            goto La
    }

    public static void CUComowOFPKFWYgq(java.util.IEnumerator r0, int r1, java.lang.string r2, bool r3, char r4) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L24
        L9:
            goto L2c
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L12:
            int r2 = r0 * r1
            goto L1e
        L18:
            r0 = 42
            goto Lc
        L1e:
            int r3 = r2 + r1
            goto L4
        L24:
            return
        L25:
            goto L9
        L29:
            goto L25
        L2c:
            goto L18
    }

    public static void CUComowOFPKFWYgq(java.util.IEnumerator r0, java.lang.string r1, char r2, bool r3, int r4) {
            goto L1e
        L4:
            goto L21
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        Ld:
            r0 = 42
            goto L7
        L13:
            int r2 = r0 * r1
            goto L2a
        L19:
            double r0 = (double) r3
            goto L25
        L1e:
            goto L26
        L21:
            goto Ld
        L25:
            return
        L26:
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L19
    }

    public static void CUComowOFPKFWYgq(java.util.IEnumerator r0, bool r1, char r2, int r3, java.lang.string r4) {
            goto L21
        L4:
            int r3 = r2 + r1
            goto L28
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            return
        L11:
            goto L2d
        L15:
            r0 = 42
            goto L1b
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L21:
            goto L11
        L24:
            goto L15
        L28:
            double r0 = (double) r3
            goto L10
        L2d:
            goto L24
    }

    public static bool CUComowOFPKFWYgq(java.util.IEnumerator r1) {
            goto L14
        L4:
            bool r0 = r1.MoveNext()
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static void CZOJyVJYdFTclgbZ(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, bool r2, float r3, short r4) {
            goto Lf
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        La:
            return
        Lb:
            goto L2d
        Lf:
            goto Lb
        L12:
            goto L27
        L16:
            int r2 = r0 * r1
            goto L1c
        L1c:
            int r3 = r2 + r1
            goto L22
        L22:
            double r0 = (double) r3
            goto La
        L27:
            r0 = 42
            goto L4
        L2d:
            goto L12
    }

    public static void CZOJyVJYdFTclgbZ(android.content.Dictionary<string, object>.Editor r0, short r1, java.lang.string r2, float r3, bool r4) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            goto L26
        Lc:
            goto L19
        L10:
            goto Lc
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L19:
            r0 = 42
            goto L13
        L1f:
            int r3 = r2 + r1
            goto L4
        L25:
            return
        L26:
            goto L10
        L2a:
            int r2 = r0 * r1
            goto L1f
    }

    public static void CZOJyVJYdFTclgbZ(android.content.Dictionary<string, object>.Editor r0, short r1, bool r2, java.lang.string r3, float r4) {
            goto L1a
        L4:
            double r0 = (double) r3
            goto L15
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L15:
            return
        L16:
            goto L27
        L1a:
            goto L16
        L1d:
            goto L2a
        L21:
            int r2 = r0 * r1
            goto L9
        L27:
            goto L1d
        L2a:
            r0 = 42
            goto Lf
    }

    public static bool CZOJyVJYdFTclgbZ(android.content.Dictionary<string, object>.Editor r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            bool r0 = r1.commit()
            goto L4
        L18:
            goto Lc
    }

    public static java.time.OffsetDateTimeTime CagzKYLlHFbnDVoO(java.time.Instant r1, java.time.ZoneOffset r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            java.time.OffsetDateTimeTime r0 = r1.atOffset(r2)
            goto L4
    }

    public static void CagzKYLlHFbnDVoO(java.time.Instant r0, java.time.ZoneOffset r1, float r2, short r3, bool r4, int r5) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L1e
        L9:
            goto L26
        Lc:
            int r3 = r2 + r1
            goto L4
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L18:
            int r2 = r0 * r1
            goto Lc
        L1e:
            return
        L1f:
            goto L9
        L23:
            goto L1f
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L12
    }

    public static void CagzKYLlHFbnDVoO(java.time.Instant r0, java.time.ZoneOffset r1, int r2, float r3, bool r4, short r5) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L18
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            goto L26
        L12:
            int r2 = r0 * r1
            goto L9
        L18:
            return
        L19:
            goto Lf
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L23:
            goto L19
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L1d
    }

    public static void CagzKYLlHFbnDVoO(java.time.Instant r0, java.time.ZoneOffset r1, short r2, bool r3, float r4, int r5) {
            goto L29
        L4:
            r0 = 42
            goto L1d
        La:
            int r2 = r0 * r1
            goto L23
        L10:
            double r0 = (double) r3
            goto L18
        L15:
            goto L2c
        L18:
            return
        L19:
            goto L15
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L23:
            int r3 = r2 + r1
            goto L10
        L29:
            goto L19
        L2c:
            goto L4
    }

    public static java.util.HashSet DYtDkBupgrPmfeYf(android.content.Dictionary<string, object> r1, java.lang.string r2, java.util.HashSet r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.util.HashSet r0 = r1.getstringHashSet(r2, r3)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void DYtDkBupgrPmfeYf(android.content.Dictionary<string, object> r0, java.lang.string r1, java.util.HashSet r2, char r3, short r4, float r5, bool r6) {
            goto L16
        L4:
            int r2 = r0 * r1
            goto L10
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            int r3 = r2 + r1
            goto L20
        L16:
            goto L2c
        L19:
            goto L25
        L1d:
            goto L19
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            r0 = 42
            goto La
        L2b:
            return
        L2c:
            goto L1d
    }

    public static void DYtDkBupgrPmfeYf(android.content.Dictionary<string, object> r0, java.lang.string r1, java.util.HashSet r2, short r3, bool r4, float r5, char r6) {
            goto L1e
        L4:
            goto L21
        L7:
            double r0 = (double) r3
            goto L2b
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L12:
            int r2 = r0 * r1
            goto L25
        L18:
            r0 = 42
            goto Lc
        L1e:
            goto L2c
        L21:
            goto L18
        L25:
            int r3 = r2 + r1
            goto L7
        L2b:
            return
        L2c:
            goto L4
    }

    public static void DYtDkBupgrPmfeYf(android.content.Dictionary<string, object> r0, java.lang.string r1, java.util.HashSet r2, bool r3, short r4, char r5, float r6) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L2a
        Lb:
            return
        Lc:
            goto L27
        L10:
            int r2 = r0 * r1
            goto L16
        L16:
            int r3 = r2 + r1
            goto L1c
        L1c:
            double r0 = (double) r3
            goto Lb
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L27:
            goto L7
        L2a:
            r0 = 42
            goto L21
    }

    public static java.util.Dictionary FNwbndsEtBbpgrVH(android.content.Dictionary<string, object> r1) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            java.util.Dictionary r0 = r1.getAll()
            goto L4
    }

    public static void FNwbndsEtBbpgrVH(android.content.Dictionary<string, object> r0, char r1, float r2, bool r3, int r4) {
            goto L29
        L4:
            goto L2c
        L7:
            int r2 = r0 * r1
            goto L13
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L13:
            int r3 = r2 + r1
            goto L19
        L19:
            double r0 = (double) r3
            goto L1e
        L1e:
            return
        L1f:
            goto L4
        L23:
            r0 = 42
            goto Ld
        L29:
            goto L1f
        L2c:
            goto L23
    }

    public static void FNwbndsEtBbpgrVH(android.content.Dictionary<string, object> r0, float r1, char r2, bool r3, int r4) {
            goto L13
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        La:
            goto L16
        Ld:
            int r2 = r0 * r1
            goto L2a
        L13:
            goto L21
        L16:
            goto L1a
        L1a:
            r0 = 42
            goto L4
        L20:
            return
        L21:
            goto La
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void FNwbndsEtBbpgrVH(android.content.Dictionary<string, object> r0, bool r1, float r2, char r3, int r4) {
            goto L26
        L4:
            double r0 = (double) r3
            goto L15
        L9:
            int r2 = r0 * r1
            goto Lf
        Lf:
            int r3 = r2 + r1
            goto L4
        L15:
            return
        L16:
            goto L2d
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L20:
            r0 = 42
            goto L1a
        L26:
            goto L16
        L29:
            goto L20
        L2d:
            goto L29
    }

    public static void FXonljurVNHncBOl(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, java.lang.string r1) {
            goto L10
        L4:
            r0.removeStoredDateTime(r1)
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public static void FXonljurVNHncBOl(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, java.lang.string r1, byte r2, bool r3, char r4, float r5) {
            goto L1b
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        La:
            int r3 = r2 + r1
            goto L25
        L10:
            return
        L11:
            goto L22
        L15:
            int r2 = r0 * r1
            goto La
        L1b:
            goto L11
        L1e:
            goto L2a
        L22:
            goto L1e
        L25:
            double r0 = (double) r3
            goto L10
        L2a:
            r0 = 42
            goto L4
    }

    public static void FXonljurVNHncBOl(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, java.lang.string r1, bool r2, char r3, float r4, byte r5) {
            goto Lf
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        La:
            double r0 = (double) r3
            goto L22
        Lf:
            goto L23
        L12:
            goto L16
        L16:
            r0 = 42
            goto L4
        L1c:
            int r2 = r0 * r1
            goto L2a
        L22:
            return
        L23:
            goto L27
        L27:
            goto L12
        L2a:
            int r3 = r2 + r1
            goto La
    }

    public static void FXonljurVNHncBOl(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, java.lang.string r1, bool r2, float r3, char r4, byte r5) {
            goto L1d
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r2 = r0 * r1
            goto L24
        Lf:
            return
        L10:
            goto L14
        L14:
            goto L20
        L17:
            r0 = 42
            goto L2a
        L1d:
            goto L10
        L20:
            goto L17
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
    }

    public static java.util.Dictionary FavOaTfMHRrelLUC(android.content.Dictionary<string, object> r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            java.util.Dictionary r0 = r1.getAll()
            goto L7
    }

    public static void FavOaTfMHRrelLUC(android.content.Dictionary<string, object> r0, char r1, short r2, float r3, int r4) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L21
        Lf:
            r0 = 42
            goto L1b
        L15:
            int r2 = r0 * r1
            goto L4
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L21:
            return
        L22:
            goto L26
        L26:
            goto L2c
        L29:
            goto L22
        L2c:
            goto Lf
    }

    public static void FavOaTfMHRrelLUC(android.content.Dictionary<string, object> r0, char r1, short r2, int r3, float r4) {
            goto Ld
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        La:
            goto L10
        Ld:
            goto L1b
        L10:
            goto L2a
        L14:
            int r2 = r0 * r1
            goto L24
        L1a:
            return
        L1b:
            goto La
        L1f:
            double r0 = (double) r3
            goto L1a
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            r0 = 42
            goto L4
    }

    public static void FavOaTfMHRrelLUC(android.content.Dictionary<string, object> r0, short r1, int r2, float r3, char r4) {
            goto L4
        L4:
            goto L12
        L7:
            goto L24
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L11:
            return
        L12:
            goto L16
        L16:
            goto L7
        L19:
            int r3 = r2 + r1
            goto L1f
        L1f:
            double r0 = (double) r3
            goto L11
        L24:
            r0 = 42
            goto Lb
        L2a:
            int r2 = r0 * r1
            goto L19
    }

    public static void FuLmzCfIsCxdMbAM(java.util.List r0, java.lang.object r1, java.lang.string r2, int r3, short r4, bool r5) {
            goto L29
        L4:
            r0 = 42
            goto L1e
        La:
            int r3 = r2 + r1
            goto L10
        L10:
            double r0 = (double) r3
            goto L24
        L15:
            int r2 = r0 * r1
            goto La
        L1b:
            goto L2c
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L24:
            return
        L25:
            goto L1b
        L29:
            goto L25
        L2c:
            goto L4
    }

    public static void FuLmzCfIsCxdMbAM(java.util.List r0, java.lang.object r1, java.lang.string r2, int r3, bool r4, short r5) {
            goto La
        L4:
            r0 = 42
            goto L11
        La:
            goto L1b
        Ld:
            goto L4
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L17:
            goto Ld
        L1a:
            return
        L1b:
            goto L17
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto L1a
        L2a:
            int r2 = r0 * r1
            goto L1f
    }

    public static void FuLmzCfIsCxdMbAM(java.util.List r0, java.lang.object r1, java.lang.string r2, bool r3, short r4, int r5) {
            goto L1a
        L4:
            return
        L5:
            goto L2d
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            int r3 = r2 + r1
            goto L9
        L14:
            r0 = 42
            goto L21
        L1a:
            goto L5
        L1d:
            goto L14
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L27:
            int r2 = r0 * r1
            goto Le
        L2d:
            goto L1d
    }

    public static bool FuLmzCfIsCxdMbAM(java.util.List r1, java.lang.object r2) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            bool r0 = r1.Add(r2)
            goto Le
    }

    public static void GWHVqBVGWCedcWnp(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, long r1, long r3, java.lang.string r5, int r6, bool r7, short r8) {
            goto L12
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L15
        L12:
            goto Lb
        L15:
            goto L1f
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1f:
            r0 = 42
            goto L19
        L25:
            int r2 = r0 * r1
            goto L4
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void GWHVqBVGWCedcWnp(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, long r1, long r3, java.lang.string r5, short r6, int r7, bool r8) {
            goto L29
        L4:
            goto L2c
        L7:
            return
        L8:
            goto L4
        Lc:
            int r3 = r2 + r1
            goto L24
        L12:
            r0 = 42
            goto L18
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L1e:
            int r2 = r0 * r1
            goto Lc
        L24:
            double r0 = (double) r3
            goto L7
        L29:
            goto L8
        L2c:
            goto L12
    }

    public static void GWHVqBVGWCedcWnp(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, long r1, long r3, short r5, int r6, bool r7, java.lang.string r8) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L24
        L9:
            goto L2c
        Lc:
            r0 = 42
            goto L18
        L12:
            int r3 = r2 + r1
            goto L4
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L1e:
            int r2 = r0 * r1
            goto L12
        L24:
            return
        L25:
            goto L9
        L29:
            goto L25
        L2c:
            goto Lc
    }

    public static bool GWHVqBVGWCedcWnp(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r1, long r2, long r4) {
            goto Lf
        L4:
            bool r0 = r1.isSameDateTimeUtc(r2, r4)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static android.content.Dictionary<string, object>.Editor GiLsqZxFhsISXBDb(android.content.Dictionary<string, object>.Editor r1, java.lang.string r2, java.lang.string r3) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            android.content.Dictionary<string, object>$Editor r0 = r1.putstring(r2, r3)
            goto Le
    }

    public static void GiLsqZxFhsISXBDb(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, java.lang.string r2, byte r3, float r4, bool r5, int r6) {
            goto L4
        L4:
            goto L18
        L7:
            goto L11
        Lb:
            int r3 = r2 + r1
            goto L1f
        L11:
            r0 = 42
            goto L2a
        L17:
            return
        L18:
            goto L1c
        L1c:
            goto L7
        L1f:
            double r0 = (double) r3
            goto L17
        L24:
            int r2 = r0 * r1
            goto Lb
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void GiLsqZxFhsISXBDb(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, java.lang.string r2, byte r3, bool r4, int r5, float r6) {
            goto L4
        L4:
            goto L1b
        L7:
            goto L2a
        Lb:
            goto L7
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L14:
            int r3 = r2 + r1
            goto L1f
        L1a:
            return
        L1b:
            goto Lb
        L1f:
            double r0 = (double) r3
            goto L1a
        L24:
            int r2 = r0 * r1
            goto L14
        L2a:
            r0 = 42
            goto Le
    }

    public static void GiLsqZxFhsISXBDb(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, java.lang.string r2, bool r3, byte r4, int r5, float r6) {
            goto L1b
        L4:
            int r3 = r2 + r1
            goto L28
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            r0 = 42
            goto L22
        L16:
            return
        L17:
            goto L2d
        L1b:
            goto L17
        L1e:
            goto L10
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L28:
            double r0 = (double) r3
            goto L16
        L2d:
            goto L1e
    }

    public static void GkDiTPSfZflzBRtf(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, java.lang.string r1) {
            goto L10
        L4:
            r0.removeStoredDateTime(r1)
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public static void GkDiTPSfZflzBRtf(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, java.lang.string r1, byte r2, float r3, short r4, char r5) {
            goto L23
        L4:
            goto L26
        L7:
            int r2 = r0 * r1
            goto L2a
        Ld:
            double r0 = (double) r3
            goto L1e
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L18:
            r0 = 42
            goto L12
        L1e:
            return
        L1f:
            goto L4
        L23:
            goto L1f
        L26:
            goto L18
        L2a:
            int r3 = r2 + r1
            goto Ld
    }

    public static void GkDiTPSfZflzBRtf(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, java.lang.string r1, short r2, byte r3, char r4, float r5) {
            goto L1b
        L4:
            int r3 = r2 + r1
            goto L25
        La:
            r0 = 42
            goto L2a
        L10:
            return
        L11:
            goto L22
        L15:
            int r2 = r0 * r1
            goto L4
        L1b:
            goto L11
        L1e:
            goto La
        L22:
            goto L1e
        L25:
            double r0 = (double) r3
            goto L10
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
    }

    public static void GkDiTPSfZflzBRtf(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, java.lang.string r1, short r2, float r3, byte r4, char r5) {
            goto L1d
        L4:
            return
        L5:
            goto Lf
        L9:
            r0 = 42
            goto L24
        Lf:
            goto L20
        L12:
            int r2 = r0 * r1
            goto L2a
        L18:
            double r0 = (double) r3
            goto L4
        L1d:
            goto L5
        L20:
            goto L9
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L2a:
            int r3 = r2 + r1
            goto L18
    }

    public static java.lang.object HNocGsIIbvmWHfik(java.util.Dictionary.Entry r1) {
            goto L14
        L4:
            java.lang.object r0 = r1.getKey()
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static void HNocGsIIbvmWHfik(java.util.Dictionary.Entry r0, char r1, java.lang.string r2, byte r3, bool r4) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L1f
        L9:
            goto L20
        Lc:
            goto L19
        L10:
            goto Lc
        L13:
            int r2 = r0 * r1
            goto L24
        L19:
            r0 = 42
            goto L2a
        L1f:
            return
        L20:
            goto L10
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
    }

    public static void HNocGsIIbvmWHfik(java.util.Dictionary.Entry r0, char r1, bool r2, java.lang.string r3, byte r4) {
            goto L10
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        La:
            r0 = 42
            goto L4
        L10:
            goto L29
        L13:
            goto La
        L17:
            int r2 = r0 * r1
            goto L22
        L1d:
            double r0 = (double) r3
            goto L28
        L22:
            int r3 = r2 + r1
            goto L1d
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L13
    }

    public static void HNocGsIIbvmWHfik(java.util.Dictionary.Entry r0, java.lang.string r1, char r2, byte r3, bool r4) {
            goto Lf
        L4:
            int r2 = r0 * r1
            goto L22
        La:
            return
        Lb:
            goto L28
        Lf:
            goto Lb
        L12:
            goto L1c
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1c:
            r0 = 42
            goto L16
        L22:
            int r3 = r2 + r1
            goto L2b
        L28:
            goto L12
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static java.lang.string HjElNiwxFENDWSPU(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r1, long r2) {
            goto L14
        L4:
            java.lang.string r0 = r1.getFormattedDateTime(r2)
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static void HjElNiwxFENDWSPU(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, long r1, bool r3, char r4, float r5, int r6) {
            goto Lf
        L4:
            r0 = 42
            goto L1c
        La:
            double r0 = (double) r3
            goto L22
        Lf:
            goto L23
        L12:
            goto L4
        L16:
            int r3 = r2 + r1
            goto La
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L22:
            return
        L23:
            goto L2d
        L27:
            int r2 = r0 * r1
            goto L16
        L2d:
            goto L12
    }

    public static void HjElNiwxFENDWSPU(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, long r1, bool r3, char r4, int r5, float r6) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L1e
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L10:
            r0 = 42
            goto La
        L16:
            goto L2c
        L19:
            return
        L1a:
            goto L16
        L1e:
            double r0 = (double) r3
            goto L19
        L23:
            int r2 = r0 * r1
            goto L4
        L29:
            goto L1a
        L2c:
            goto L10
    }

    public static void HjElNiwxFENDWSPU(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, long r1, bool r3, int r4, char r5, float r6) {
            goto L29
        L4:
            goto L2c
        L7:
            int r3 = r2 + r1
            goto L12
        Ld:
            return
        Le:
            goto L4
        L12:
            double r0 = (double) r3
            goto Ld
        L17:
            int r2 = r0 * r1
            goto L7
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L23:
            r0 = 42
            goto L1d
        L29:
            goto Le
        L2c:
            goto L23
    }

    public static void IBqVRUpsunYPfQPd(java.util.HashSet r0, char r1, short r2, float r3, int r4) {
            goto L1e
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            return
        Lb:
            goto L1b
        Lf:
            r0 = 42
            goto L15
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1b:
            goto L21
        L1e:
            goto Lb
        L21:
            goto Lf
        L25:
            int r2 = r0 * r1
            goto L4
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void IBqVRUpsunYPfQPd(java.util.HashSet r0, float r1, short r2, int r3, char r4) {
            goto Lf
        L4:
            r0 = 42
            goto L27
        La:
            double r0 = (double) r3
            goto L22
        Lf:
            goto L23
        L12:
            goto L4
        L16:
            int r2 = r0 * r1
            goto L1c
        L1c:
            int r3 = r2 + r1
            goto La
        L22:
            return
        L23:
            goto L2d
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L2d:
            goto L12
    }

    public static void IBqVRUpsunYPfQPd(java.util.HashSet r0, short r1, float r2, char r3, int r4) {
            goto L18
        L4:
            int r2 = r0 * r1
            goto L12
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L1b
        L12:
            int r3 = r2 + r1
            goto L2b
        L18:
            goto Lb
        L1b:
            goto L25
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L25:
            r0 = 42
            goto L1f
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static bool IBqVRUpsunYPfQPd(java.util.HashSet r1) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            bool r0 = r1.Count == 0
            goto L4
    }

    public static java.lang.object JbHiGbvkehAIyIwM(java.util.IEnumerator r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            java.lang.object r0 = r1.Current
            goto Lb
    }

    public static void JbHiGbvkehAIyIwM(java.util.IEnumerator r0, byte r1, java.lang.string r2, int r3, bool r4) {
            goto L1d
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            r0 = 42
            goto L2a
        L10:
            goto L20
        L13:
            double r0 = (double) r3
            goto L18
        L18:
            return
        L19:
            goto L10
        L1d:
            goto L19
        L20:
            goto La
        L24:
            int r3 = r2 + r1
            goto L13
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void JbHiGbvkehAIyIwM(java.util.IEnumerator r0, int r1, byte r2, java.lang.string r3, bool r4) {
            goto L15
        L4:
            return
        L5:
            goto L21
        L9:
            r0 = 42
            goto L2a
        Lf:
            int r3 = r2 + r1
            goto L1c
        L15:
            goto L5
        L18:
            goto L9
        L1c:
            double r0 = (double) r3
            goto L4
        L21:
            goto L18
        L24:
            int r2 = r0 * r1
            goto Lf
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void JbHiGbvkehAIyIwM(java.util.IEnumerator r0, java.lang.string r1, int r2, byte r3, bool r4) {
            goto L4
        L4:
            goto L15
        L7:
            goto L2a
        Lb:
            int r2 = r0 * r1
            goto L1f
        L11:
            goto L7
        L14:
            return
        L15:
            goto L11
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto L14
        L2a:
            r0 = 42
            goto L19
    }

    public static java.lang.string JtJUdZdFJAZRibLx(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r1, long r2) {
            goto Lf
        L4:
            java.lang.string r0 = r1.getFormattedDateTime(r2)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static void JtJUdZdFJAZRibLx(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, long r1, char r3, bool r4, short r5, byte r6) {
            goto L15
        L4:
            return
        L5:
            goto L27
        L9:
            int r3 = r2 + r1
            goto L1c
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L15:
            goto L5
        L18:
            goto L21
        L1c:
            double r0 = (double) r3
            goto L4
        L21:
            r0 = 42
            goto Lf
        L27:
            goto L18
        L2a:
            int r2 = r0 * r1
            goto L9
    }

    public static void JtJUdZdFJAZRibLx(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, long r1, short r3, char r4, byte r5, bool r6) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L19
        L9:
            goto L1a
        Lc:
            goto L10
        L10:
            r0 = 42
            goto L2a
        L16:
            goto Lc
        L19:
            return
        L1a:
            goto L16
        L1e:
            int r2 = r0 * r1
            goto L24
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
    }

    public static void JtJUdZdFJAZRibLx(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, long r1, bool r3, char r4, byte r5, short r6) {
            goto L29
        L4:
            r0 = 42
            goto L15
        La:
            int r2 = r0 * r1
            goto L23
        L10:
            return
        L11:
            goto L20
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L1b:
            double r0 = (double) r3
            goto L10
        L20:
            goto L2c
        L23:
            int r3 = r2 + r1
            goto L1b
        L29:
            goto L11
        L2c:
            goto L4
    }

    public static java.util.IEnumerator KmmdyQNOhcnDYedk(java.util.HashSet r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static void KmmdyQNOhcnDYedk(java.util.HashSet r0, char r1, float r2, bool r3, byte r4) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L24
        La:
            r0 = 42
            goto L10
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L16:
            goto L2c
        L19:
            return
        L1a:
            goto L16
        L1e:
            int r2 = r0 * r1
            goto L4
        L24:
            double r0 = (double) r3
            goto L19
        L29:
            goto L1a
        L2c:
            goto La
    }

    public static void KmmdyQNOhcnDYedk(java.util.HashSet r0, char r1, bool r2, byte r3, float r4) {
            goto L29
        L4:
            goto L2c
        L7:
            int r2 = r0 * r1
            goto Ld
        Ld:
            int r3 = r2 + r1
            goto L1f
        L13:
            r0 = 42
            goto L19
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L1f:
            double r0 = (double) r3
            goto L24
        L24:
            return
        L25:
            goto L4
        L29:
            goto L25
        L2c:
            goto L13
    }

    public static void KmmdyQNOhcnDYedk(java.util.HashSet r0, bool r1, float r2, byte r3, char r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L1f
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L11:
            goto L7
        L14:
            int r2 = r0 * r1
            goto L25
        L1a:
            double r0 = (double) r3
            goto L2b
        L1f:
            r0 = 42
            goto Lb
        L25:
            int r3 = r2 + r1
            goto L1a
        L2b:
            return
        L2c:
            goto L11
    }

    public static void KyptnLQHVnMZgfbW(java.lang.string r0, java.lang.object r1, java.lang.string r2, byte r3, char r4, int r5) {
            goto L15
        L4:
            r0 = 42
            goto L27
        La:
            int r2 = r0 * r1
            goto L21
        L10:
            return
        L11:
            goto L2d
        L15:
            goto L11
        L18:
            goto L4
        L1c:
            double r0 = (double) r3
            goto L10
        L21:
            int r3 = r2 + r1
            goto L1c
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L2d:
            goto L18
    }

    public static void KyptnLQHVnMZgfbW(java.lang.string r0, java.lang.object r1, java.lang.string r2, byte r3, int r4, char r5) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        La:
            double r0 = (double) r3
            goto L24
        Lf:
            goto L2c
        L12:
            int r3 = r2 + r1
            goto La
        L18:
            r0 = 42
            goto L4
        L1e:
            int r2 = r0 * r1
            goto L12
        L24:
            return
        L25:
            goto Lf
        L29:
            goto L25
        L2c:
            goto L18
    }

    public static void KyptnLQHVnMZgfbW(java.lang.string r0, java.lang.object r1, java.lang.string r2, char r3, byte r4, int r5) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L15
        La:
            return
        Lb:
            goto L1a
        Lf:
            r0 = 42
            goto L1d
        L15:
            double r0 = (double) r3
            goto La
        L1a:
            goto L2c
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L23:
            int r2 = r0 * r1
            goto L4
        L29:
            goto Lb
        L2c:
            goto Lf
    }

    public static bool KyptnLQHVnMZgfbW(java.lang.string r1, java.lang.object r2) {
            goto L14
        L4:
            goto L17
        L7:
            bool r0 = r1.Equals(r2)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static java.util.Dictionary LNIWwjnLDmaICPgm(android.content.Dictionary<string, object> r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.util.Dictionary r0 = r1.getAll()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void LNIWwjnLDmaICPgm(android.content.Dictionary<string, object> r0, float r1, java.lang.string r2, bool r3, short r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L17
        La:
            goto L1d
        Ld:
            goto L2a
        L11:
            int r2 = r0 * r1
            goto L4
        L17:
            double r0 = (double) r3
            goto L1c
        L1c:
            return
        L1d:
            goto L27
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L27:
            goto Ld
        L2a:
            r0 = 42
            goto L21
    }

    public static void LNIWwjnLDmaICPgm(android.content.Dictionary<string, object> r0, float r1, bool r2, java.lang.string r3, short r4) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L18
        L9:
            goto L2c
        Lc:
            int r3 = r2 + r1
            goto L4
        L12:
            r0 = 42
            goto L23
        L18:
            return
        L19:
            goto L9
        L1d:
            int r2 = r0 * r1
            goto Lc
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L29:
            goto L19
        L2c:
            goto L12
    }

    public static void LNIWwjnLDmaICPgm(android.content.Dictionary<string, object> r0, bool r1, float r2, java.lang.string r3, short r4) {
            goto L21
        L4:
            int r3 = r2 + r1
            goto L16
        La:
            r0 = 42
            goto L1b
        L10:
            int r2 = r0 * r1
            goto L4
        L16:
            double r0 = (double) r3
            goto L2b
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L21:
            goto L2c
        L24:
            goto La
        L28:
            goto L24
        L2b:
            return
        L2c:
            goto L28
    }

    public static void LSQZXTfTjfwtsERU(java.util.HashSet r0, java.lang.object r1, char r2, float r3, int r4, java.lang.string r5) {
            goto L4
        L4:
            goto L18
        L7:
            goto L11
        Lb:
            int r3 = r2 + r1
            goto L1c
        L11:
            r0 = 42
            goto L21
        L17:
            return
        L18:
            goto L27
        L1c:
            double r0 = (double) r3
            goto L17
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L27:
            goto L7
        L2a:
            int r2 = r0 * r1
            goto Lb
    }

    public static void LSQZXTfTjfwtsERU(java.util.HashSet r0, java.lang.object r1, java.lang.string r2, float r3, char r4, int r5) {
            goto L4
        L4:
            goto L15
        L7:
            goto L24
        Lb:
            goto L7
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L14:
            return
        L15:
            goto Lb
        L19:
            double r0 = (double) r3
            goto L14
        L1e:
            int r2 = r0 * r1
            goto L2a
        L24:
            r0 = 42
            goto Le
        L2a:
            int r3 = r2 + r1
            goto L19
    }

    public static void LSQZXTfTjfwtsERU(java.util.HashSet r0, java.lang.object r1, java.lang.string r2, int r3, char r4, float r5) {
            goto L23
        L4:
            r0 = 42
            goto L14
        La:
            return
        Lb:
            goto L20
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1a:
            int r3 = r2 + r1
            goto Lf
        L20:
            goto L26
        L23:
            goto Lb
        L26:
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L1a
    }

    public static bool LSQZXTfTjfwtsERU(java.util.HashSet r1, java.lang.object r2) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            bool r0 = r1.Remove(r2)
            goto Le
    }

    public static java.lang.string LdGCaTfjMxKbinIQ(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r1, long r2) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            java.lang.string r0 = r1.getFormattedDateTime(r2)
            goto L4
    }

    public static void LdGCaTfjMxKbinIQ(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, long r1, byte r3, float r4, short r5, char r6) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L16
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            goto L17
        L12:
            goto L2a
        L16:
            return
        L17:
            goto L1b
        L1b:
            goto L12
        L1e:
            int r2 = r0 * r1
            goto L9
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L2a:
            r0 = 42
            goto L24
    }

    public static void LdGCaTfjMxKbinIQ(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, long r1, byte r3, short r4, char r5, float r6) {
            goto L1b
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        La:
            return
        Lb:
            goto L2d
        Lf:
            r0 = 42
            goto L4
        L15:
            int r3 = r2 + r1
            goto L28
        L1b:
            goto Lb
        L1e:
            goto Lf
        L22:
            int r2 = r0 * r1
            goto L15
        L28:
            double r0 = (double) r3
            goto La
        L2d:
            goto L1e
    }

    public static void LdGCaTfjMxKbinIQ(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, long r1, float r3, byte r4, char r5, short r6) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L11
        La:
            goto L20
        Ld:
            goto L24
        L11:
            double r0 = (double) r3
            goto L1f
        L16:
            goto Ld
        L19:
            int r2 = r0 * r1
            goto L4
        L1f:
            return
        L20:
            goto L16
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
    }

    public static android.content.Dictionary<string, object>.Editor LeqaxpKTaacjpvHE(android.content.Dictionary<string, object>.Editor r1, java.lang.string r2, java.lang.string r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            android.content.Dictionary<string, object>$Editor r0 = r1.putstring(r2, r3)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void LeqaxpKTaacjpvHE(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, java.lang.string r2, short r3, float r4, bool r5, char r6) {
            goto L1d
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L14
        L14:
            goto L20
        L17:
            r0 = 42
            goto L2a
        L1d:
            goto L10
        L20:
            goto L17
        L24:
            int r3 = r2 + r1
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void LeqaxpKTaacjpvHE(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, java.lang.string r2, bool r3, float r4, short r5, char r6) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L21
        Lb:
            return
        Lc:
            goto L2d
        L10:
            double r0 = (double) r3
            goto Lb
        L15:
            int r2 = r0 * r1
            goto L1b
        L1b:
            int r3 = r2 + r1
            goto L10
        L21:
            r0 = 42
            goto L27
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L2d:
            goto L7
    }

    public static void LeqaxpKTaacjpvHE(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, java.lang.string r2, bool r3, short r4, char r5, float r6) {
            goto L23
        L4:
            return
        L5:
            goto L1b
        L9:
            int r3 = r2 + r1
            goto L1e
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L15:
            int r2 = r0 * r1
            goto L9
        L1b:
            goto L26
        L1e:
            double r0 = (double) r3
            goto L4
        L23:
            goto L5
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto Lf
    }

    public static android.content.Dictionary<string, object>.Editor LgdfCcilDFadBPnG(android.content.Dictionary<string, object>.Editor r1, java.lang.string r2, long r3) {
            goto L11
        L4:
            android.content.Dictionary<string, object>$Editor r0 = r1.putlong(r2, r3)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static void LgdfCcilDFadBPnG(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, long r2, float r4, bool r5, java.lang.string r6, int r7) {
            goto L12
        L4:
            goto L15
        L7:
            double r0 = (double) r3
            goto L25
        Lc:
            int r2 = r0 * r1
            goto L19
        L12:
            goto L26
        L15:
            goto L2a
        L19:
            int r3 = r2 + r1
            goto L7
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
        L25:
            return
        L26:
            goto L4
        L2a:
            r0 = 42
            goto L1f
    }

    public static void LgdfCcilDFadBPnG(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, long r2, int r4, float r5, java.lang.string r6, bool r7) {
            goto L4
        L4:
            goto L1a
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            double r0 = (double) r3
            goto L19
        L13:
            r0 = 42
            goto L1e
        L19:
            return
        L1a:
            goto Lb
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L24:
            int r3 = r2 + r1
            goto Le
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void LgdfCcilDFadBPnG(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, long r2, java.lang.string r4, float r5, int r6, bool r7) {
            goto L1b
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L28
        Lf:
            int r2 = r0 * r1
            goto L4
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L1b:
            goto L29
        L1e:
            goto L22
        L22:
            r0 = 42
            goto L15
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L1e
    }

    public static java.lang.object LtSPIZiRKfkLgsZp(java.util.Dictionary.Entry r1) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            java.lang.object r0 = r1.getValue()
            goto Le
    }

    public static void LtSPIZiRKfkLgsZp(java.util.Dictionary.Entry r0, float r1, byte r2, short r3, java.lang.string r4) {
            goto L1e
        L4:
            return
        L5:
            goto L15
        L9:
            int r2 = r0 * r1
            goto L25
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L15:
            goto L21
        L18:
            r0 = 42
            goto Lf
        L1e:
            goto L5
        L21:
            goto L18
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void LtSPIZiRKfkLgsZp(java.util.Dictionary.Entry r0, java.lang.string r1, byte r2, float r3, short r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto Lf
        La:
            double r0 = (double) r3
            goto L21
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1b:
            r0 = 42
            goto L15
        L21:
            return
        L22:
            goto L26
        L26:
            goto L2c
        L29:
            goto L22
        L2c:
            goto L1b
    }

    public static void LtSPIZiRKfkLgsZp(java.util.Dictionary.Entry r0, java.lang.string r1, float r2, byte r3, short r4) {
            goto La
        L4:
            r0 = 42
            goto L1c
        La:
            goto L18
        Ld:
            goto L4
        L11:
            int r2 = r0 * r1
            goto L2a
        L17:
            return
        L18:
            goto L27
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L22:
            double r0 = (double) r3
            goto L17
        L27:
            goto Ld
        L2a:
            int r3 = r2 + r1
            goto L22
    }

    public static void MMFbAGqFEJPCmlaL(android.content.Dictionary<string, object>.Editor r0, int r1, java.lang.string r2, short r3, byte r4) {
            goto L1f
        L4:
            goto L22
        L7:
            int r3 = r2 + r1
            goto L26
        Ld:
            r0 = 42
            goto L19
        L13:
            int r2 = r0 * r1
            goto L7
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L1f:
            goto L2c
        L22:
            goto Ld
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L4
    }

    public static void MMFbAGqFEJPCmlaL(android.content.Dictionary<string, object>.Editor r0, int r1, short r2, byte r3, java.lang.string r4) {
            goto Ld
        L4:
            goto L10
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        Ld:
            goto L20
        L10:
            goto L24
        L14:
            double r0 = (double) r3
            goto L1f
        L19:
            int r3 = r2 + r1
            goto L14
        L1f:
            return
        L20:
            goto L4
        L24:
            r0 = 42
            goto L7
        L2a:
            int r2 = r0 * r1
            goto L19
    }

    public static void MMFbAGqFEJPCmlaL(android.content.Dictionary<string, object>.Editor r0, short r1, java.lang.string r2, byte r3, int r4) {
            goto L16
        L4:
            r0 = 42
            goto L10
        La:
            int r2 = r0 * r1
            goto L22
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            goto L1e
        L19:
            goto L4
        L1d:
            return
        L1e:
            goto L2d
        L22:
            int r3 = r2 + r1
            goto L28
        L28:
            double r0 = (double) r3
            goto L1d
        L2d:
            goto L19
    }

    public static bool MMFbAGqFEJPCmlaL(android.content.Dictionary<string, object>.Editor r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            bool r0 = r1.commit()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static com.google.firebase.heartbeatinfo.HeartBeatResult MVlEYhvhGLuCfnIS(java.lang.string r1, java.util.List r2) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            com.google.firebase.heartbeatinfo.HeartBeatResult r0 = com.google.firebase.heartbeatinfo.HeartBeatResult.create(r1, r2)
            goto L4
    }

    public static void MVlEYhvhGLuCfnIS(java.lang.string r0, java.util.List r1, byte r2, java.lang.string r3, bool r4, short r5) {
            goto L4
        L4:
            goto L23
        L7:
            goto L1c
        Lb:
            int r2 = r0 * r1
            goto L11
        L11:
            int r3 = r2 + r1
            goto L17
        L17:
            double r0 = (double) r3
            goto L22
        L1c:
            r0 = 42
            goto L27
        L22:
            return
        L23:
            goto L2d
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L2d:
            goto L7
    }

    public static void MVlEYhvhGLuCfnIS(java.lang.string r0, java.util.List r1, java.lang.string r2, byte r3, bool r4, short r5) {
            goto Lf
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L1c
        Lf:
            goto L1d
        L12:
            goto L16
        L16:
            r0 = 42
            goto L2a
        L1c:
            return
        L1d:
            goto L27
        L21:
            int r2 = r0 * r1
            goto L4
        L27:
            goto L12
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
    }

    public static void MVlEYhvhGLuCfnIS(java.lang.string r0, java.util.List r1, bool r2, short r3, byte r4, java.lang.string r5) {
            goto L4
        L4:
            goto L12
        L7:
            goto L16
        Lb:
            int r3 = r2 + r1
            goto L2b
        L11:
            return
        L12:
            goto L1c
        L16:
            r0 = 42
            goto L25
        L1c:
            goto L7
        L1f:
            int r2 = r0 * r1
            goto Lb
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L2b:
            double r0 = (double) r3
            goto L11
    }

    public static android.content.Dictionary<string, object>.Editor MlAMAKYVEcAhgZjl(android.content.Dictionary<string, object> r1) {
            goto L14
        L4:
            goto L17
        L7:
            android.content.Dictionary<string, object>$Editor r0 = r1.edit()
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static void MlAMAKYVEcAhgZjl(android.content.Dictionary<string, object> r0, float r1, java.lang.string r2, int r3, char r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L12
        La:
            double r0 = (double) r3
            goto L18
        Lf:
            goto L2c
        L12:
            int r3 = r2 + r1
            goto La
        L18:
            return
        L19:
            goto Lf
        L1d:
            r0 = 42
            goto L23
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L29:
            goto L19
        L2c:
            goto L1d
    }

    public static void MlAMAKYVEcAhgZjl(android.content.Dictionary<string, object> r0, int r1, java.lang.string r2, char r3, float r4) {
            goto L4
        L4:
            goto L12
        L7:
            goto L21
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L11:
            return
        L12:
            goto L2d
        L16:
            double r0 = (double) r3
            goto L11
        L1b:
            int r3 = r2 + r1
            goto L16
        L21:
            r0 = 42
            goto Lb
        L27:
            int r2 = r0 * r1
            goto L1b
        L2d:
            goto L7
    }

    public static void MlAMAKYVEcAhgZjl(android.content.Dictionary<string, object> r0, java.lang.string r1, char r2, int r3, float r4) {
            goto L26
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        La:
            return
        Lb:
            goto L2d
        Lf:
            int r3 = r2 + r1
            goto L15
        L15:
            double r0 = (double) r3
            goto La
        L1a:
            r0 = 42
            goto L4
        L20:
            int r2 = r0 * r1
            goto Lf
        L26:
            goto Lb
        L29:
            goto L1a
        L2d:
            goto L29
    }

    public static android.content.Dictionary<string, object>.Editor OtMLIECSolFYIyBf(android.content.Dictionary<string, object>.Editor r1, java.lang.string r2, java.util.HashSet r3) {
            goto Lf
        L4:
            goto L12
        L7:
            android.content.Dictionary<string, object>$Editor r0 = r1.putstringHashSet(r2, r3)
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static void OtMLIECSolFYIyBf(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, java.util.HashSet r2, float r3, int r4, char r5, short r6) {
            goto L29
        L4:
            goto L2c
        L7:
            int r3 = r2 + r1
            goto Ld
        Ld:
            double r0 = (double) r3
            goto L1e
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L18:
            int r2 = r0 * r1
            goto L7
        L1e:
            return
        L1f:
            goto L4
        L23:
            r0 = 42
            goto L12
        L29:
            goto L1f
        L2c:
            goto L23
    }

    public static void OtMLIECSolFYIyBf(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, java.util.HashSet r2, int r3, char r4, short r5, float r6) {
            goto L1e
        L4:
            return
        L5:
            goto L1b
        L9:
            int r2 = r0 * r1
            goto Lf
        Lf:
            int r3 = r2 + r1
            goto L25
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1b:
            goto L21
        L1e:
            goto L5
        L21:
            goto L2a
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            r0 = 42
            goto L15
    }

    public static void OtMLIECSolFYIyBf(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, java.util.HashSet r2, short r3, char r4, int r5, float r6) {
            goto L13
        L4:
            r0 = 42
            goto Ld
        La:
            goto L16
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L13:
            goto L21
        L16:
            goto L4
        L1a:
            int r2 = r0 * r1
            goto L25
        L20:
            return
        L21:
            goto La
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static java.lang.string PpfvGPJdUrsVufNb(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.string r0 = r1.getStoredUserAgentstring(r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void PpfvGPJdUrsVufNb(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, java.lang.string r1, float r2, int r3, java.lang.string r4, char r5) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L1d
        La:
            goto L2c
        Ld:
            return
        Le:
            goto La
        L12:
            r0 = 42
            goto L23
        L18:
            double r0 = (double) r3
            goto Ld
        L1d:
            int r3 = r2 + r1
            goto L18
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L29:
            goto Le
        L2c:
            goto L12
    }

    public static void PpfvGPJdUrsVufNb(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, java.lang.string r1, int r2, float r3, java.lang.string r4, char r5) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L15
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            return
        L11:
            goto L26
        L15:
            int r3 = r2 + r1
            goto L1b
        L1b:
            double r0 = (double) r3
            goto L10
        L20:
            r0 = 42
            goto La
        L26:
            goto L2c
        L29:
            goto L11
        L2c:
            goto L20
    }

    public static void PpfvGPJdUrsVufNb(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, java.lang.string r1, java.lang.string r2, float r3, char r4, int r5) {
            goto L4
        L4:
            goto L27
        L7:
            goto L11
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L11:
            r0 = 42
            goto Lb
        L17:
            int r3 = r2 + r1
            goto L2b
        L1d:
            goto L7
        L20:
            int r2 = r0 * r1
            goto L17
        L26:
            return
        L27:
            goto L1d
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static java.lang.string QpjmvWRDpZVoRwYL(java.time.LocalDateTimeTime r1, java.time.format.DateTimeTimeFormatter r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.string r0 = r1.format(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void QpjmvWRDpZVoRwYL(java.time.LocalDateTimeTime r0, java.time.format.DateTimeTimeFormatter r1, int r2, bool r3, java.lang.string r4, char r5) {
            goto Lc
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            goto Lf
        Lc:
            goto L26
        Lf:
            goto L13
        L13:
            r0 = 42
            goto L2a
        L19:
            int r3 = r2 + r1
            goto L4
        L1f:
            int r2 = r0 * r1
            goto L19
        L25:
            return
        L26:
            goto L9
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
    }

    public static void QpjmvWRDpZVoRwYL(java.time.LocalDateTimeTime r0, java.time.format.DateTimeTimeFormatter r1, java.lang.string r2, int r3, bool r4, char r5) {
            goto L18
        L4:
            return
        L5:
            goto L15
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        Lf:
            r0 = 42
            goto L9
        L15:
            goto L1b
        L18:
            goto L5
        L1b:
            goto Lf
        L1f:
            int r2 = r0 * r1
            goto L25
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void QpjmvWRDpZVoRwYL(java.time.LocalDateTimeTime r0, java.time.format.DateTimeTimeFormatter r1, bool r2, java.lang.string r3, int r4, char r5) {
            goto L14
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            return
        L10:
            goto L1b
        L14:
            goto L10
        L17:
            goto L24
        L1b:
            goto L17
        L1e:
            int r2 = r0 * r1
            goto L9
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
    }

    public static java.util.HashSet RFxzocXvpzhFYdnL(android.content.Dictionary<string, object> r1, java.lang.string r2, java.util.HashSet r3) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            java.util.HashSet r0 = r1.getstringHashSet(r2, r3)
            goto L7
    }

    public static void RFxzocXvpzhFYdnL(android.content.Dictionary<string, object> r0, java.lang.string r1, java.util.HashSet r2, float r3, bool r4, char r5, java.lang.string r6) {
            goto L29
        L4:
            goto L2c
        L7:
            double r0 = (double) r3
            goto L18
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L12:
            int r3 = r2 + r1
            goto L7
        L18:
            return
        L19:
            goto L4
        L1d:
            int r2 = r0 * r1
            goto L12
        L23:
            r0 = 42
            goto Lc
        L29:
            goto L19
        L2c:
            goto L23
    }

    public static void RFxzocXvpzhFYdnL(android.content.Dictionary<string, object> r0, java.lang.string r1, java.util.HashSet r2, java.lang.string r3, char r4, bool r5, float r6) {
            goto L12
        L4:
            goto L15
        L7:
            int r2 = r0 * r1
            goto L2a
        Ld:
            double r0 = (double) r3
            goto L19
        L12:
            goto L1a
        L15:
            goto L24
        L19:
            return
        L1a:
            goto L4
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L24:
            r0 = 42
            goto L1e
        L2a:
            int r3 = r2 + r1
            goto Ld
    }

    public static void RFxzocXvpzhFYdnL(android.content.Dictionary<string, object> r0, java.lang.string r1, java.util.HashSet r2, bool r3, java.lang.string r4, char r5, float r6) {
            goto L29
        L4:
            r0 = 42
            goto L1b
        La:
            int r3 = r2 + r1
            goto L10
        L10:
            double r0 = (double) r3
            goto L24
        L15:
            int r2 = r0 * r1
            goto La
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L21:
            goto L2c
        L24:
            return
        L25:
            goto L21
        L29:
            goto L25
        L2c:
            goto L4
    }

    public static void RGaXjknJFGpYFWyf(java.lang.string r0, java.lang.object r1, char r2, float r3, int r4, java.lang.string r5) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L22
        L9:
            goto L23
        Lc:
            goto L1c
        L10:
            int r3 = r2 + r1
            goto L4
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L1c:
            r0 = 42
            goto L16
        L22:
            return
        L23:
            goto L2d
        L27:
            int r2 = r0 * r1
            goto L10
        L2d:
            goto Lc
    }

    public static void RGaXjknJFGpYFWyf(java.lang.string r0, java.lang.object r1, java.lang.string r2, float r3, char r4, int r5) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L1e
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            double r0 = (double) r3
            goto Lb
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1e:
            r0 = 42
            goto L18
        L24:
            int r3 = r2 + r1
            goto L13
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void RGaXjknJFGpYFWyf(java.lang.string r0, java.lang.object r1, java.lang.string r2, int r3, char r4, float r5) {
            goto L15
        L4:
            int r3 = r2 + r1
            goto L1c
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            return
        L11:
            goto L2d
        L15:
            goto L11
        L18:
            goto L27
        L1c:
            double r0 = (double) r3
            goto L10
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L27:
            r0 = 42
            goto L21
        L2d:
            goto L18
    }

    public static bool RGaXjknJFGpYFWyf(java.lang.string r1, java.lang.object r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            bool r0 = r1.Equals(r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.string RblSCRUugVSsDzOL(java.lang.stringBuilder r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.string r0 = r1.tostring()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void RblSCRUugVSsDzOL(java.lang.stringBuilder r0, float r1, bool r2, int r3, java.lang.string r4) {
            goto L10
        L4:
            r0 = 42
            goto L2a
        La:
            int r3 = r2 + r1
            goto L1c
        L10:
            goto L18
        L13:
            goto L4
        L17:
            return
        L18:
            goto L27
        L1c:
            double r0 = (double) r3
            goto L17
        L21:
            int r2 = r0 * r1
            goto La
        L27:
            goto L13
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
    }

    public static void RblSCRUugVSsDzOL(java.lang.stringBuilder r0, java.lang.string r1, int r2, float r3, bool r4) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        La:
            int r3 = r2 + r1
            goto L16
        L10:
            r0 = 42
            goto L4
        L16:
            double r0 = (double) r3
            goto L24
        L1b:
            int r2 = r0 * r1
            goto La
        L21:
            goto L2c
        L24:
            return
        L25:
            goto L21
        L29:
            goto L25
        L2c:
            goto L10
    }

    public static void RblSCRUugVSsDzOL(java.lang.stringBuilder r0, bool r1, float r2, int r3, java.lang.string r4) {
            goto L4
        L4:
            goto L12
        L7:
            goto L2a
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L11:
            return
        L12:
            goto L16
        L16:
            goto L7
        L19:
            int r2 = r0 * r1
            goto L1f
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto L11
        L2a:
            r0 = 42
            goto Lb
    }

    public static void RyHOZtbedRSbsIJy(java.util.IEnumerator r0, char r1, byte r2, bool r3, float r4) {
            goto L1b
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L15:
            r0 = 42
            goto Lf
        L1b:
            goto L2c
        L1e:
            goto L15
        L22:
            int r2 = r0 * r1
            goto L4
        L28:
            goto L1e
        L2b:
            return
        L2c:
            goto L28
    }

    public static void RyHOZtbedRSbsIJy(java.util.IEnumerator r0, float r1, byte r2, char r3, bool r4) {
            goto L14
        L4:
            return
        L5:
            goto L21
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            int r2 = r0 * r1
            goto L1b
        L14:
            goto L5
        L17:
            goto L24
        L1b:
            int r3 = r2 + r1
            goto L9
        L21:
            goto L17
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
    }

    public static void RyHOZtbedRSbsIJy(java.util.IEnumerator r0, bool r1, float r2, char r3, byte r4) {
            goto Ld
        L4:
            r0 = 42
            goto L2a
        La:
            goto L10
        Ld:
            goto L1a
        L10:
            goto L4
        L14:
            double r0 = (double) r3
            goto L19
        L19:
            return
        L1a:
            goto La
        L1e:
            int r3 = r2 + r1
            goto L14
        L24:
            int r2 = r0 * r1
            goto L1e
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static bool RyHOZtbedRSbsIJy(java.util.IEnumerator r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            bool r0 = r1.MoveNext()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void SFwMjhmfaBQtBpwJ(android.content.Dictionary<string, object>.Editor r0, char r1, short r2, byte r3, float r4) {
            goto L29
        L4:
            return
        L5:
            goto L1b
        L9:
            r0 = 42
            goto L23
        Lf:
            int r3 = r2 + r1
            goto L1e
        L15:
            int r2 = r0 * r1
            goto Lf
        L1b:
            goto L2c
        L1e:
            double r0 = (double) r3
            goto L4
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L29:
            goto L5
        L2c:
            goto L9
    }

    public static void SFwMjhmfaBQtBpwJ(android.content.Dictionary<string, object>.Editor r0, float r1, byte r2, char r3, short r4) {
            goto L13
        L4:
            r0 = 42
            goto L25
        La:
            goto L16
        Ld:
            int r3 = r2 + r1
            goto L1a
        L13:
            goto L2c
        L16:
            goto L4
        L1a:
            double r0 = (double) r3
            goto L2b
        L1f:
            int r2 = r0 * r1
            goto Ld
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L2b:
            return
        L2c:
            goto La
    }

    public static void SFwMjhmfaBQtBpwJ(android.content.Dictionary<string, object>.Editor r0, float r1, byte r2, short r3, char r4) {
            goto L26
        L4:
            int r3 = r2 + r1
            goto L15
        La:
            return
        Lb:
            goto L2d
        Lf:
            int r2 = r0 * r1
            goto L4
        L15:
            double r0 = (double) r3
            goto La
        L1a:
            r0 = 42
            goto L20
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L26:
            goto Lb
        L29:
            goto L1a
        L2d:
            goto L29
    }

    public static bool SFwMjhmfaBQtBpwJ(android.content.Dictionary<string, object>.Editor r1) {
            goto L14
        L4:
            bool r0 = r1.commit()
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static android.content.Dictionary<string, object>.Editor SJBdQBceqpSpqavv(android.content.Dictionary<string, object> r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            android.content.Dictionary<string, object>$Editor r0 = r1.edit()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void SJBdQBceqpSpqavv(android.content.Dictionary<string, object> r0, char r1, int r2, short r3, float r4) {
            goto L9
        L4:
            return
        L5:
            goto L22
        L9:
            goto L5
        Lc:
            goto L25
        L10:
            int r2 = r0 * r1
            goto L1c
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L1c:
            int r3 = r2 + r1
            goto L2b
        L22:
            goto Lc
        L25:
            r0 = 42
            goto L16
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void SJBdQBceqpSpqavv(android.content.Dictionary<string, object> r0, char r1, short r2, int r3, float r4) {
            goto L18
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            goto L1b
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L13:
            return
        L14:
            goto La
        L18:
            goto L14
        L1b:
            goto L1f
        L1f:
            r0 = 42
            goto Ld
        L25:
            int r2 = r0 * r1
            goto L4
        L2b:
            double r0 = (double) r3
            goto L13
    }

    public static void SJBdQBceqpSpqavv(android.content.Dictionary<string, object> r0, short r1, float r2, char r3, int r4) {
            goto L15
        L4:
            return
        L5:
            goto L2d
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        Lf:
            r0 = 42
            goto L9
        L15:
            goto L5
        L18:
            goto Lf
        L1c:
            double r0 = (double) r3
            goto L4
        L21:
            int r2 = r0 * r1
            goto L27
        L27:
            int r3 = r2 + r1
            goto L1c
        L2d:
            goto L18
    }

    public static void UOKksRlyLvQQSYLW(android.content.Dictionary<string, object>.Editor r0, float r1, byte r2, java.lang.string r3, bool r4) {
            goto Lf
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            return
        Lb:
            goto L1c
        Lf:
            goto Lb
        L12:
            goto L16
        L16:
            r0 = 42
            goto L4
        L1c:
            goto L12
        L1f:
            double r0 = (double) r3
            goto La
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void UOKksRlyLvQQSYLW(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, bool r2, float r3, byte r4) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L1b
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            return
        L11:
            goto L26
        L15:
            r0 = 42
            goto L20
        L1b:
            double r0 = (double) r3
            goto L10
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L26:
            goto L2c
        L29:
            goto L11
        L2c:
            goto L15
    }

    public static void UOKksRlyLvQQSYLW(android.content.Dictionary<string, object>.Editor r0, bool r1, java.lang.string r2, byte r3, float r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L25
        La:
            goto L12
        Ld:
            goto L1f
        L11:
            return
        L12:
            goto L1c
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1c:
            goto Ld
        L1f:
            r0 = 42
            goto L16
        L25:
            double r0 = (double) r3
            goto L11
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static bool UOKksRlyLvQQSYLW(android.content.Dictionary<string, object>.Editor r1) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            bool r0 = r1.commit()
            goto Le
    }

    public static java.lang.object UcuDneRrOTHssfwN(java.util.IEnumerator r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            java.lang.object r0 = r1.Current
            goto L7
    }

    public static void UcuDneRrOTHssfwN(java.util.IEnumerator r0, char r1, byte r2, short r3, float r4) {
            goto L13
        L4:
            int r3 = r2 + r1
            goto L1a
        La:
            goto L16
        Ld:
            r0 = 42
            goto L1f
        L13:
            goto L26
        L16:
            goto Ld
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L25:
            return
        L26:
            goto La
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void UcuDneRrOTHssfwN(java.util.IEnumerator r0, char r1, float r2, byte r3, short r4) {
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        La:
            r0 = 42
            goto L4
        L10:
            double r0 = (double) r3
            goto L1c
        L15:
            goto L1d
        L18:
            goto La
        L1c:
            return
        L1d:
            goto L2d
        L21:
            int r2 = r0 * r1
            goto L27
        L27:
            int r3 = r2 + r1
            goto L10
        L2d:
            goto L18
    }

    public static void UcuDneRrOTHssfwN(java.util.IEnumerator r0, float r1, char r2, short r3, byte r4) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        La:
            return
        Lb:
            goto L21
        Lf:
            r0 = 42
            goto L4
        L15:
            int r3 = r2 + r1
            goto L24
        L1b:
            int r2 = r0 * r1
            goto L15
        L21:
            goto L2c
        L24:
            double r0 = (double) r3
            goto La
        L29:
            goto Lb
        L2c:
            goto Lf
    }

    public static java.lang.object UeWOGIUHKDJpPLQY(java.util.Dictionary.Entry r1) {
            goto L11
        L4:
            java.lang.object r0 = r1.getValue()
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static void UeWOGIUHKDJpPLQY(java.util.Dictionary.Entry r0, byte r1, float r2, int r3, java.lang.string r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L19
        La:
            goto L15
        Ld:
            goto L1f
        L11:
            goto Ld
        L14:
            return
        L15:
            goto L11
        L19:
            int r3 = r2 + r1
            goto L2b
        L1f:
            r0 = 42
            goto L25
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2b:
            double r0 = (double) r3
            goto L14
    }

    public static void UeWOGIUHKDJpPLQY(java.util.Dictionary.Entry r0, int r1, byte r2, float r3, java.lang.string r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        La:
            goto L2c
        Ld:
            goto L19
        L11:
            double r0 = (double) r3
            goto L2b
        L16:
            goto Ld
        L19:
            r0 = 42
            goto L4
        L1f:
            int r2 = r0 * r1
            goto L25
        L25:
            int r3 = r2 + r1
            goto L11
        L2b:
            return
        L2c:
            goto L16
    }

    public static void UeWOGIUHKDJpPLQY(java.util.Dictionary.Entry r0, int r1, byte r2, java.lang.string r3, float r4) {
            goto Lf
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L22
        Lf:
            goto L23
        L12:
            goto L16
        L16:
            r0 = 42
            goto L27
        L1c:
            int r2 = r0 * r1
            goto L4
        L22:
            return
        L23:
            goto L2d
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L2d:
            goto L12
    }

    public static java.util.HashSet VAcAXaPPwVSfikdB(android.content.Dictionary<string, object> r1, java.lang.string r2, java.util.HashSet r3) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            java.util.HashSet r0 = r1.getstringHashSet(r2, r3)
            goto L7
    }

    public static void VAcAXaPPwVSfikdB(android.content.Dictionary<string, object> r0, java.lang.string r1, java.util.HashSet r2, byte r3, short r4, char r5, bool r6) {
            goto L18
        L4:
            int r2 = r0 * r1
            goto L1f
        La:
            goto L1b
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L13:
            return
        L14:
            goto La
        L18:
            goto L14
        L1b:
            goto L25
        L1f:
            int r3 = r2 + r1
            goto L2b
        L25:
            r0 = 42
            goto Ld
        L2b:
            double r0 = (double) r3
            goto L13
    }

    public static void VAcAXaPPwVSfikdB(android.content.Dictionary<string, object> r0, java.lang.string r1, java.util.HashSet r2, byte r3, short r4, bool r5, char r6) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            r0 = 42
            goto L19
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1f:
            int r2 = r0 * r1
            goto L25
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto Le
    }

    public static void VAcAXaPPwVSfikdB(android.content.Dictionary<string, object> r0, java.lang.string r1, java.util.HashSet r2, char r3, short r4, bool r5, byte r6) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto Lf
        La:
            return
        Lb:
            goto L15
        Lf:
            int r3 = r2 + r1
            goto L18
        L15:
            goto L2c
        L18:
            double r0 = (double) r3
            goto La
        L1d:
            r0 = 42
            goto L23
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L29:
            goto Lb
        L2c:
            goto L1d
    }

    public static java.util.HashSet VBVYeLrlEPXHhvoG(java.util.Dictionary r1) {
            goto L11
        L4:
            java.util.HashSet r0 = r1.entryHashSet()
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static void VBVYeLrlEPXHhvoG(java.util.Dictionary r0, char r1, int r2, java.lang.string r3, float r4) {
            goto L23
        L4:
            r0 = 42
            goto L1a
        La:
            return
        Lb:
            goto L20
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            int r2 = r0 * r1
            goto L2a
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L20:
            goto L26
        L23:
            goto Lb
        L26:
            goto L4
        L2a:
            int r3 = r2 + r1
            goto Lf
    }

    public static void VBVYeLrlEPXHhvoG(java.util.Dictionary r0, float r1, int r2, char r3, java.lang.string r4) {
            goto L29
        L4:
            goto L2c
        L7:
            return
        L8:
            goto L4
        Lc:
            int r2 = r0 * r1
            goto L12
        L12:
            int r3 = r2 + r1
            goto L1e
        L18:
            r0 = 42
            goto L23
        L1e:
            double r0 = (double) r3
            goto L7
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
        L29:
            goto L8
        L2c:
            goto L18
    }

    public static void VBVYeLrlEPXHhvoG(java.util.Dictionary r0, java.lang.string r1, int r2, float r3, char r4) {
            goto L9
        L4:
            return
        L5:
            goto L1c
        L9:
            goto L5
        Lc:
            goto L2a
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L16:
            int r2 = r0 * r1
            goto L1f
        L1c:
            goto Lc
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            r0 = 42
            goto L10
    }

    public static android.content.Dictionary<string, object>.Editor VFwvJnyzHeznEcTE(android.content.Dictionary<string, object>.Editor r1, java.lang.string r2, long r3) {
            goto L14
        L4:
            android.content.Dictionary<string, object>$Editor r0 = r1.putlong(r2, r3)
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static void VFwvJnyzHeznEcTE(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, long r2, char r4, int r5, short r6, java.lang.string r7) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L1e
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        Lf:
            int r3 = r2 + r1
            goto L4
        L15:
            int r2 = r0 * r1
            goto Lf
        L1b:
            goto L26
        L1e:
            return
        L1f:
            goto L1b
        L23:
            goto L1f
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L9
    }

    public static void VFwvJnyzHeznEcTE(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, long r2, char r4, short r5, java.lang.string r6, int r7) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        La:
            goto L18
        Ld:
            goto L1f
        L11:
            int r3 = r2 + r1
            goto L2b
        L17:
            return
        L18:
            goto L1c
        L1c:
            goto Ld
        L1f:
            r0 = 42
            goto L4
        L25:
            int r2 = r0 * r1
            goto L11
        L2b:
            double r0 = (double) r3
            goto L17
    }

    public static void VFwvJnyzHeznEcTE(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, long r2, int r4, char r5, java.lang.string r6, short r7) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L28
        L10:
            r0 = 42
            goto L1c
        L16:
            int r2 = r0 * r1
            goto L22
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L22:
            int r3 = r2 + r1
            goto L2b
        L28:
            goto L7
        L2b:
            double r0 = (double) r3
            goto Lb
    }

    public static java.lang.object VmHEjMLqazxZrUsz(java.util.Dictionary.Entry r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.object r0 = r1.getKey()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void VmHEjMLqazxZrUsz(java.util.Dictionary.Entry r0, char r1, float r2, byte r3, java.lang.string r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            goto L20
        Ld:
            goto L11
        L11:
            r0 = 42
            goto L24
        L17:
            double r0 = (double) r3
            goto L1f
        L1c:
            goto Ld
        L1f:
            return
        L20:
            goto L1c
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L17
    }

    public static void VmHEjMLqazxZrUsz(java.util.Dictionary.Entry r0, float r1, java.lang.string r2, char r3, byte r4) {
            goto L26
        L4:
            int r2 = r0 * r1
            goto L20
        La:
            double r0 = (double) r3
            goto L15
        Lf:
            r0 = 42
            goto L1a
        L15:
            return
        L16:
            goto L2d
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L20:
            int r3 = r2 + r1
            goto La
        L26:
            goto L16
        L29:
            goto Lf
        L2d:
            goto L29
    }

    public static void VmHEjMLqazxZrUsz(java.util.Dictionary.Entry r0, java.lang.string r1, char r2, float r3, byte r4) {
            goto L11
        L4:
            return
        L5:
            goto L9
        L9:
            goto L14
        Lc:
            double r0 = (double) r3
            goto L4
        L11:
            goto L5
        L14:
            goto L1e
        L18:
            int r3 = r2 + r1
            goto Lc
        L1e:
            r0 = 42
            goto L24
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L18
    }

    public static long WYEvSpXmjoxEojEa(android.content.Dictionary<string, object> r2, java.lang.string r3, long r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto Lb
        Lb:
            r0 = 27
            goto L30
        L12:
            if (r0 <= 0) goto L17
            goto L3f
        L17:
            goto L3c
        L1b:
            long r0 = r2.getlong(r3, r4)
            goto L37
        L23:
            int r0 = r0 % r1
            goto L12
        L29:
            goto L3f
        L2c:
            goto L49
        L30:
            r1 = 12
            goto L43
        L37:
            return r0
        L38:
            goto L29
        L3c:
            goto L38
        L3f:
            goto L1b
        L43:
            int r0 = r0 + r1
            goto L23
        L49:
            goto L7
    }

    public static void WYEvSpXmjoxEojEa(android.content.Dictionary<string, object> r0, java.lang.string r1, long r2, float r4, bool r5, int r6, short r7) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            goto L20
        Ld:
            goto L16
        L11:
            double r0 = (double) r3
            goto L1f
        L16:
            r0 = 42
            goto L24
        L1c:
            goto Ld
        L1f:
            return
        L20:
            goto L1c
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L11
    }

    public static void WYEvSpXmjoxEojEa(android.content.Dictionary<string, object> r0, java.lang.string r1, long r2, int r4, bool r5, float r6, short r7) {
            goto L15
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            return
        L11:
            goto L22
        L15:
            goto L11
        L18:
            goto L25
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L22:
            goto L18
        L25:
            r0 = 42
            goto L1c
        L2b:
            double r0 = (double) r3
            goto L10
    }

    public static void WYEvSpXmjoxEojEa(android.content.Dictionary<string, object> r0, java.lang.string r1, long r2, bool r4, short r5, int r6, float r7) {
            goto L4
        L4:
            goto L1a
        L7:
            goto L10
        Lb:
            double r0 = (double) r3
            goto L19
        L10:
            r0 = 42
            goto L2a
        L16:
            goto L7
        L19:
            return
        L1a:
            goto L16
        L1e:
            int r2 = r0 * r1
            goto L24
        L24:
            int r3 = r2 + r1
            goto Lb
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
    }

    public static java.util.HashSet WqEDxJVUlgXDWxHH(java.util.Dictionary r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            java.util.HashSet r0 = r1.entryHashSet()
            goto Le
    }

    public static void WqEDxJVUlgXDWxHH(java.util.Dictionary r0, byte r1, short r2, float r3, char r4) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto Lf
        La:
            return
        Lb:
            goto L14
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            goto L2c
        L17:
            int r2 = r0 * r1
            goto L4
        L1d:
            r0 = 42
            goto L23
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L29:
            goto Lb
        L2c:
            goto L1d
    }

    public static void WqEDxJVUlgXDWxHH(java.util.Dictionary r0, float r1, char r2, short r3, byte r4) {
            goto L23
        L4:
            goto L26
        L7:
            return
        L8:
            goto L4
        Lc:
            r0 = 42
            goto L12
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L18:
            double r0 = (double) r3
            goto L7
        L1d:
            int r3 = r2 + r1
            goto L18
        L23:
            goto L8
        L26:
            goto Lc
        L2a:
            int r2 = r0 * r1
            goto L1d
    }

    public static void WqEDxJVUlgXDWxHH(java.util.Dictionary r0, short r1, byte r2, float r3, char r4) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L21
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L15:
            r0 = 42
            goto Lf
        L1b:
            int r2 = r0 * r1
            goto L9
        L21:
            return
        L22:
            goto L26
        L26:
            goto L2c
        L29:
            goto L22
        L2c:
            goto L15
    }

    public static void XTvYNbxleRSQgYjj(java.lang.string r0, java.lang.object r1, float r2, short r3, int r4, byte r5) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L1d
        La:
            double r0 = (double) r3
            goto L12
        Lf:
            goto L2c
        L12:
            return
        L13:
            goto Lf
        L17:
            r0 = 42
            goto L23
        L1d:
            int r3 = r2 + r1
            goto La
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L29:
            goto L13
        L2c:
            goto L17
    }

    public static void XTvYNbxleRSQgYjj(java.lang.string r0, java.lang.object r1, short r2, byte r3, float r4, int r5) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            goto L26
        Ld:
            goto L1c
        L11:
            double r0 = (double) r3
            goto L25
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1c:
            r0 = 42
            goto L16
        L22:
            goto Ld
        L25:
            return
        L26:
            goto L22
        L2a:
            int r3 = r2 + r1
            goto L11
    }

    public static void XTvYNbxleRSQgYjj(java.lang.string r0, java.lang.object r1, short r2, byte r3, int r4, float r5) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L1f
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            int r2 = r0 * r1
            goto L19
        L19:
            int r3 = r2 + r1
            goto L25
        L1f:
            r0 = 42
            goto L2a
        L25:
            double r0 = (double) r3
            goto Le
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
    }

    public static bool XTvYNbxleRSQgYjj(java.lang.string r1, java.lang.object r2) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            bool r0 = r1.Equals(r2)
            goto L7
    }

    public static void YMukVaJjWcsehQVm(java.util.HashSet r0, java.lang.object r1, int r2, float r3, bool r4, java.lang.string r5) {
            goto L24
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L10:
            goto L27
        L13:
            int r2 = r0 * r1
            goto L4
        L19:
            r0 = 42
            goto La
        L1f:
            return
        L20:
            goto L10
        L24:
            goto L20
        L27:
            goto L19
        L2b:
            double r0 = (double) r3
            goto L1f
    }

    public static void YMukVaJjWcsehQVm(java.util.HashSet r0, java.lang.object r1, bool r2, float r3, int r4, java.lang.string r5) {
            goto L18
        L4:
            goto L1b
        L7:
            r0 = 42
            goto L24
        Ld:
            double r0 = (double) r3
            goto L1f
        L12:
            int r3 = r2 + r1
            goto Ld
        L18:
            goto L20
        L1b:
            goto L7
        L1f:
            return
        L20:
            goto L4
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L12
    }

    public static void YMukVaJjWcsehQVm(java.util.HashSet r0, java.lang.object r1, bool r2, int r3, float r4, java.lang.string r5) {
            goto L1e
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            int r2 = r0 * r1
            goto L9
        L15:
            goto L21
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L1e:
            goto L26
        L21:
            goto L2a
        L25:
            return
        L26:
            goto L15
        L2a:
            r0 = 42
            goto L18
    }

    public static bool YMukVaJjWcsehQVm(java.util.HashSet r1, java.lang.object r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            bool r0 = r1.Contains(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.object YeiYXeNtaItLaNeh(java.util.Dictionary.Entry r1) {
            goto L11
        L4:
            java.lang.object r0 = r1.getValue()
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static void YeiYXeNtaItLaNeh(java.util.Dictionary.Entry r0, float r1, byte r2, short r3, char r4) {
            goto L1e
        L4:
            int r2 = r0 * r1
            goto L25
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            r0 = 42
            goto La
        L16:
            goto L21
        L19:
            double r0 = (double) r3
            goto L2b
        L1e:
            goto L2c
        L21:
            goto L10
        L25:
            int r3 = r2 + r1
            goto L19
        L2b:
            return
        L2c:
            goto L16
    }

    public static void YeiYXeNtaItLaNeh(java.util.Dictionary.Entry r0, float r1, char r2, byte r3, short r4) {
            goto L29
        L4:
            goto L2c
        L7:
            double r0 = (double) r3
            goto L24
        Lc:
            r0 = 42
            goto L1e
        L12:
            int r2 = r0 * r1
            goto L18
        L18:
            int r3 = r2 + r1
            goto L7
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L24:
            return
        L25:
            goto L4
        L29:
            goto L25
        L2c:
            goto Lc
    }

    public static void YeiYXeNtaItLaNeh(java.util.Dictionary.Entry r0, float r1, char r2, short r3, byte r4) {
            goto L12
        L4:
            return
        L5:
            goto Lf
        L9:
            r0 = 42
            goto L1f
        Lf:
            goto L15
        L12:
            goto L5
        L15:
            goto L9
        L19:
            int r3 = r2 + r1
            goto L25
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L19
    }

    public static android.content.Dictionary<string, object>.Editor YhdLdnHCqSqiyDAB(android.content.Dictionary<string, object>.Editor r1, java.lang.string r2, long r3) {
            goto L14
        L4:
            android.content.Dictionary<string, object>$Editor r0 = r1.putlong(r2, r3)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static void YhdLdnHCqSqiyDAB(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, long r2, int r4, bool r5, short r6, byte r7) {
            goto L29
        L4:
            goto L2c
        L7:
            return
        L8:
            goto L4
        Lc:
            int r3 = r2 + r1
            goto L12
        L12:
            double r0 = (double) r3
            goto L7
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L1d:
            int r2 = r0 * r1
            goto Lc
        L23:
            r0 = 42
            goto L17
        L29:
            goto L8
        L2c:
            goto L23
    }

    public static void YhdLdnHCqSqiyDAB(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, long r2, short r4, int r5, byte r6, bool r7) {
            goto Lf
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L1f
        Lf:
            goto L20
        L12:
            goto L24
        L16:
            goto L12
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1f:
            return
        L20:
            goto L16
        L24:
            r0 = 42
            goto L19
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void YhdLdnHCqSqiyDAB(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, long r2, bool r4, int r5, short r6, byte r7) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L12
        L9:
            r0 = 42
            goto L17
        Lf:
            goto L2c
        L12:
            return
        L13:
            goto Lf
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L1d:
            int r2 = r0 * r1
            goto L23
        L23:
            int r3 = r2 + r1
            goto L4
        L29:
            goto L13
        L2c:
            goto L9
    }

    public static android.content.Dictionary<string, object>.Editor YjkBvKddiXerMxRN(android.content.Dictionary<string, object> r1) {
            goto L14
        L4:
            goto L17
        L7:
            android.content.Dictionary<string, object>$Editor r0 = r1.edit()
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static void YjkBvKddiXerMxRN(android.content.Dictionary<string, object> r0, java.lang.string r1, float r2, short r3, int r4) {
            goto L21
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L10:
            int r3 = r2 + r1
            goto L1c
        L16:
            int r2 = r0 * r1
            goto L10
        L1c:
            double r0 = (double) r3
            goto L2b
        L21:
            goto L2c
        L24:
            goto L4
        L28:
            goto L24
        L2b:
            return
        L2c:
            goto L28
    }

    public static void YjkBvKddiXerMxRN(android.content.Dictionary<string, object> r0, java.lang.string r1, int r2, short r3, float r4) {
            goto Lf
        L4:
            return
        L5:
            goto L2d
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        Lf:
            goto L5
        L12:
            goto L1b
        L16:
            double r0 = (double) r3
            goto L4
        L1b:
            r0 = 42
            goto L9
        L21:
            int r2 = r0 * r1
            goto L27
        L27:
            int r3 = r2 + r1
            goto L16
        L2d:
            goto L12
    }

    public static void YjkBvKddiXerMxRN(android.content.Dictionary<string, object> r0, short r1, int r2, java.lang.string r3, float r4) {
            goto L4
        L4:
            goto L20
        L7:
            goto L24
        Lb:
            goto L7
        Le:
            int r3 = r2 + r1
            goto L14
        L14:
            double r0 = (double) r3
            goto L1f
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1f:
            return
        L20:
            goto Lb
        L24:
            r0 = 42
            goto L19
        L2a:
            int r2 = r0 * r1
            goto Le
    }

    public static void ZIjAeYviMAorgnSG(java.util.HashSet r0, java.lang.object r1, int r2, char r3, bool r4, short r5) {
            goto L4
        L4:
            goto L23
        L7:
            goto L27
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L11:
            int r2 = r0 * r1
            goto L1c
        L17:
            double r0 = (double) r3
            goto L22
        L1c:
            int r3 = r2 + r1
            goto L17
        L22:
            return
        L23:
            goto L2d
        L27:
            r0 = 42
            goto Lb
        L2d:
            goto L7
    }

    public static void ZIjAeYviMAorgnSG(java.util.HashSet r0, java.lang.object r1, short r2, bool r3, char r4, int r5) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto L13
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            goto L26
        L13:
            double r0 = (double) r3
            goto L1e
        L18:
            r0 = 42
            goto L2a
        L1e:
            return
        L1f:
            goto L10
        L23:
            goto L1f
        L26:
            goto L18
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
    }

    public static void ZIjAeYviMAorgnSG(java.util.HashSet r0, java.lang.object r1, bool r2, short r3, int r4, char r5) {
            goto La
        L4:
            r0 = 42
            goto L24
        La:
            goto L15
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            return
        L15:
            goto L11
        L19:
            double r0 = (double) r3
            goto L14
        L1e:
            int r3 = r2 + r1
            goto L19
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L1e
    }

    public static bool ZIjAeYviMAorgnSG(java.util.HashSet r1, java.lang.object r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            bool r0 = r1.Add(r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static long AMGlZHPSRbveHoIs() {
            goto L16
        L4:
            int r0 = r0 % r1
            goto L3d
        La:
            return r0
        Lb:
            goto L1d
        Lf:
            r0 = 8
            goto L36
        L16:
            goto L20
        L19:
            goto Lf
        L1d:
            goto L2a
        L20:
            goto L24
        L24:
            goto L19
        L27:
            goto Lb
        L2a:
            goto L2e
        L2e:
            long r0 = java.lang.System.currentTimeMillis()
            goto La
        L36:
            r1 = 11
            goto L46
        L3d:
            if (r0 <= 0) goto L42
            goto L2a
        L42:
            goto L27
        L46:
            int r0 = r0 + r1
            goto L4
    }

    public static void AMGlZHPSRbveHoIs(float r0, int r1, java.lang.string r2, short r3) {
            goto L10
        L4:
            int r3 = r2 + r1
            goto L23
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L10:
            goto L29
        L13:
            goto L17
        L17:
            r0 = 42
            goto La
        L1d:
            int r2 = r0 * r1
            goto L4
        L23:
            double r0 = (double) r3
            goto L28
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L13
    }

    public static void AMGlZHPSRbveHoIs(float r0, short r1, int r2, java.lang.string r3) {
            goto L14
        L4:
            int r3 = r2 + r1
            goto Lf
        La:
            return
        Lb:
            goto L2d
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            goto Lb
        L17:
            goto L21
        L1b:
            int r2 = r0 * r1
            goto L4
        L21:
            r0 = 42
            goto L27
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L2d:
            goto L17
    }

    public static void AMGlZHPSRbveHoIs(java.lang.string r0, short r1, int r2, float r3) {
            goto L7
        L4:
            goto La
        L7:
            goto L15
        La:
            goto L2a
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L14:
            return
        L15:
            goto L4
        L19:
            int r2 = r0 * r1
            goto L1f
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto L14
        L2a:
            r0 = 42
            goto Le
    }

    public static android.content.Dictionary<string, object>.Editor ARxbEsUlfPuRLNPu(android.content.Dictionary<string, object>.Editor r1, java.lang.string r2, long r3) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            android.content.Dictionary<string, object>$Editor r0 = r1.putlong(r2, r3)
            goto Le
    }

    public static void ARxbEsUlfPuRLNPu(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, long r2, char r4, short r5, float r6, bool r7) {
            goto L1a
        L4:
            double r0 = (double) r3
            goto L15
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        Lf:
            int r3 = r2 + r1
            goto L4
        L15:
            return
        L16:
            goto L2d
        L1a:
            goto L16
        L1d:
            goto L21
        L21:
            r0 = 42
            goto L9
        L27:
            int r2 = r0 * r1
            goto Lf
        L2d:
            goto L1d
    }

    public static void ARxbEsUlfPuRLNPu(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, long r2, char r4, short r5, bool r6, float r7) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto L19
        La:
            r0 = 42
            goto L2a
        L10:
            goto L26
        L13:
            int r2 = r0 * r1
            goto L4
        L19:
            double r0 = (double) r3
            goto L1e
        L1e:
            return
        L1f:
            goto L10
        L23:
            goto L1f
        L26:
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
    }

    public static void ARxbEsUlfPuRLNPu(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, long r2, short r4, char r5, float r6, bool r7) {
            goto La
        L4:
            r0 = 42
            goto L25
        La:
            goto L2c
        Ld:
            goto L4
        L11:
            double r0 = (double) r3
            goto L2b
        L16:
            int r3 = r2 + r1
            goto L11
        L1c:
            goto Ld
        L1f:
            int r2 = r0 * r1
            goto L16
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L2b:
            return
        L2c:
            goto L1c
    }

    public static long AZIruyntsDYkRMRA(android.content.Dictionary<string, object> r2, java.lang.string r3, long r4) {
            goto L11
        L4:
            long r0 = r2.getlong(r3, r4)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L37
        L11:
            goto L3a
        L14:
            goto L45
        L18:
            int r0 = r0 % r1
            goto L2b
        L1e:
            int r0 = r0 + r1
            goto L18
        L24:
            goto Ld
        L27:
            goto L4
        L2b:
            if (r0 <= 0) goto L30
            goto L27
        L30:
            goto L24
        L34:
            goto L14
        L37:
            goto L27
        L3a:
            goto L34
        L3e:
            r1 = 16
            goto L1e
        L45:
            r0 = 30
            goto L3e
    }

    public static void AZIruyntsDYkRMRA(android.content.Dictionary<string, object> r0, java.lang.string r1, long r2, int r4, bool r5, byte r6, java.lang.string r7) {
            goto L23
        L4:
            goto L26
        L7:
            r0 = 42
            goto L18
        Ld:
            double r0 = (double) r3
            goto L1e
        L12:
            int r3 = r2 + r1
            goto Ld
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1e:
            return
        L1f:
            goto L4
        L23:
            goto L1f
        L26:
            goto L7
        L2a:
            int r2 = r0 * r1
            goto L12
    }

    public static void AZIruyntsDYkRMRA(android.content.Dictionary<string, object> r0, java.lang.string r1, long r2, int r4, bool r5, java.lang.string r6, byte r7) {
            goto L20
        L4:
            r0 = 42
            goto L2a
        La:
            return
        Lb:
            goto L27
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            int r3 = r2 + r1
            goto Lf
        L1a:
            int r2 = r0 * r1
            goto L14
        L20:
            goto Lb
        L23:
            goto L4
        L27:
            goto L23
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
    }

    public static void AZIruyntsDYkRMRA(android.content.Dictionary<string, object> r0, java.lang.string r1, long r2, bool r4, java.lang.string r5, int r6, byte r7) {
            goto L4
        L4:
            goto L29
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L11
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L17:
            int r2 = r0 * r1
            goto L1d
        L1d:
            int r3 = r2 + r1
            goto L23
        L23:
            double r0 = (double) r3
            goto L28
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L7
    }

    public static android.content.Dictionary<string, object>.Editor AeAInuGUMlqVsxxe(android.content.Dictionary<string, object>.Editor r1, java.lang.string r2, java.util.HashSet r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            android.content.Dictionary<string, object>$Editor r0 = r1.putstringHashSet(r2, r3)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void AeAInuGUMlqVsxxe(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, java.util.HashSet r2, int r3, char r4, java.lang.string r5, byte r6) {
            goto L26
        L4:
            int r2 = r0 * r1
            goto L20
        La:
            r0 = 42
            goto L10
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L16:
            double r0 = (double) r3
            goto L1b
        L1b:
            return
        L1c:
            goto L2d
        L20:
            int r3 = r2 + r1
            goto L16
        L26:
            goto L1c
        L29:
            goto La
        L2d:
            goto L29
    }

    public static void AeAInuGUMlqVsxxe(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, java.util.HashSet r2, java.lang.string r3, byte r4, char r5, int r6) {
            goto L4
        L4:
            goto L15
        L7:
            goto L19
        Lb:
            int r2 = r0 * r1
            goto L2a
        L11:
            goto L7
        L14:
            return
        L15:
            goto L11
        L19:
            r0 = 42
            goto L24
        L1f:
            double r0 = (double) r3
            goto L14
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    public static void AeAInuGUMlqVsxxe(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, java.util.HashSet r2, java.lang.string r3, int r4, char r5, byte r6) {
            goto L19
        L4:
            goto L1c
        L7:
            int r3 = r2 + r1
            goto L20
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L13:
            r0 = 42
            goto Ld
        L19:
            goto L2c
        L1c:
            goto L13
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            int r2 = r0 * r1
            goto L7
        L2b:
            return
        L2c:
            goto L4
    }

    public static void AqSSseaBYIwBzjTl(java.util.IEnumerator r0, byte r1, float r2, bool r3, char r4) {
            goto L20
        L4:
            r0 = 42
            goto L2a
        La:
            int r2 = r0 * r1
            goto L10
        L10:
            int r3 = r2 + r1
            goto L16
        L16:
            double r0 = (double) r3
            goto L1b
        L1b:
            return
        L1c:
            goto L27
        L20:
            goto L1c
        L23:
            goto L4
        L27:
            goto L23
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
    }

    public static void AqSSseaBYIwBzjTl(java.util.IEnumerator r0, char r1, byte r2, bool r3, float r4) {
            goto L1d
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            goto L20
        Ld:
            double r0 = (double) r3
            goto L12
        L12:
            return
        L13:
            goto La
        L17:
            r0 = 42
            goto L4
        L1d:
            goto L13
        L20:
            goto L17
        L24:
            int r3 = r2 + r1
            goto Ld
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void AqSSseaBYIwBzjTl(java.util.IEnumerator r0, char r1, bool r2, float r3, byte r4) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            goto L2c
        Lc:
            goto L25
        L10:
            goto Lc
        L13:
            int r3 = r2 + r1
            goto L4
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1f:
            int r2 = r0 * r1
            goto L13
        L25:
            r0 = 42
            goto L19
        L2b:
            return
        L2c:
            goto L10
    }

    public static bool AqSSseaBYIwBzjTl(java.util.IEnumerator r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            bool r0 = r1.MoveNext()
            goto L4
    }

    public static java.util.HashSet BfXXtKXdFUJexZSY(java.util.Dictionary r1) {
            goto Lc
        L4:
            java.util.HashSet r0 = r1.entryHashSet()
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static void BfXXtKXdFUJexZSY(java.util.Dictionary r0, byte r1, short r2, char r3, bool r4) {
            goto L21
        L4:
            r0 = 42
            goto L10
        La:
            int r2 = r0 * r1
            goto L1b
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            return
        L17:
            goto L2d
        L1b:
            int r3 = r2 + r1
            goto L28
        L21:
            goto L17
        L24:
            goto L4
        L28:
            double r0 = (double) r3
            goto L16
        L2d:
            goto L24
    }

    public static void BfXXtKXdFUJexZSY(java.util.Dictionary r0, char r1, byte r2, bool r3, short r4) {
            goto L1e
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        Lf:
            goto L21
        L12:
            r0 = 42
            goto L9
        L18:
            int r2 = r0 * r1
            goto L2a
        L1e:
            goto L26
        L21:
            goto L12
        L25:
            return
        L26:
            goto Lf
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void BfXXtKXdFUJexZSY(java.util.Dictionary r0, char r1, short r2, byte r3, bool r4) {
            goto Ld
        L4:
            goto L10
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        Ld:
            goto L2c
        L10:
            goto L25
        L14:
            double r0 = (double) r3
            goto L2b
        L19:
            int r3 = r2 + r1
            goto L14
        L1f:
            int r2 = r0 * r1
            goto L19
        L25:
            r0 = 42
            goto L7
        L2b:
            return
        L2c:
            goto L4
    }

    public static android.content.Dictionary<string, object>.Editor CcehMXDCresJsGwd(android.content.Dictionary<string, object> r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            android.content.Dictionary<string, object>$Editor r0 = r1.edit()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void CcehMXDCresJsGwd(android.content.Dictionary<string, object> r0, char r1, java.lang.string r2, int r3, bool r4) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            r0 = 42
            goto L2a
        L19:
            int r3 = r2 + r1
            goto L1f
        L1f:
            double r0 = (double) r3
            goto Le
        L24:
            int r2 = r0 * r1
            goto L19
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void CcehMXDCresJsGwd(android.content.Dictionary<string, object> r0, bool r1, int r2, char r3, java.lang.string r4) {
            goto L7
        L4:
            goto La
        L7:
            goto L1b
        La:
            goto L2a
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L14:
            int r3 = r2 + r1
            goto L25
        L1a:
            return
        L1b:
            goto L4
        L1f:
            int r2 = r0 * r1
            goto L14
        L25:
            double r0 = (double) r3
            goto L1a
        L2a:
            r0 = 42
            goto Le
    }

    public static void CcehMXDCresJsGwd(android.content.Dictionary<string, object> r0, bool r1, java.lang.string r2, char r3, int r4) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L10
        L9:
            goto L11
        Lc:
            goto L2a
        L10:
            return
        L11:
            goto L27
        L15:
            int r3 = r2 + r1
            goto L4
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L21:
            int r2 = r0 * r1
            goto L15
        L27:
            goto Lc
        L2a:
            r0 = 42
            goto L1b
    }

    private void CleanUpStoredHeartBeats() {
            r9 = this;
            goto L17
        L4:
            r0 = 21
            goto Lb9
        Lb:
            int r0 = r0 % r1
            goto Lc3
        L11:
            int r0 = r0 + r1
            goto Lb
        L17:
            goto L21
        L1a:
            goto L4
        L1e:
            goto Lcf
        L21:
            goto Lc0
        L25:
            monitor-enter(r9)
            android.content.Dictionary<string, object> r0 = r9.firebaseDictionary<string, object>     // Catch: java.lang.Exception -> Lb3
            java.lang.string r1 = "fire-count"
            r2 = 0
            long r0 = hjKgdvmKySKJPUIj(r0, r1, r2)     // Catch: java.lang.Exception -> Lb3
            java.lang.string r2 = ""
            android.content.Dictionary<string, object> r3 = r9.firebaseDictionary<string, object>     // Catch: java.lang.Exception -> Lb3
            java.util.Dictionary r3 = FavOaTfMHRrelLUC(r3)     // Catch: java.lang.Exception -> Lb3
            java.util.HashSet r3 = BIKJiXwjYJUxyVmm(r3)     // Catch: java.lang.Exception -> Lb3
            java.util.IEnumerator r3 = jMmMcXFMPbqdNtRL(r3)     // Catch: java.lang.Exception -> Lb3
            r4 = 0
        L41:
            bool r5 = CUComowOFPKFWYgq(r3)     // Catch: java.lang.Exception -> Lb3
            if (r5 == 0) goto L7b
            java.lang.object r5 = JbHiGbvkehAIyIwM(r3)     // Catch: java.lang.Exception -> Lb3
            java.util.Dictionary$Entry r5 = (java.util.Dictionary.Entry) r5     // Catch: java.lang.Exception -> Lb3
            java.lang.object r6 = uDtYeKIUfOklfAQf(r5)     // Catch: java.lang.Exception -> Lb3
            bool r6 = r6 is java.util.HashSet     // Catch: java.lang.Exception -> Lb3
            if (r6 == 0) goto L41
            java.lang.object r6 = YeiYXeNtaItLaNeh(r5)     // Catch: java.lang.Exception -> Lb3
            java.util.HashSet r6 = (java.util.HashSet) r6     // Catch: java.lang.Exception -> Lb3
            java.util.IEnumerator r6 = pMRRUqwWbYgLECFj(r6)     // Catch: java.lang.Exception -> Lb3
        L5f:
            bool r7 = COfvwVMcTmUSTFgs(r6)     // Catch: java.lang.Exception -> Lb3
            if (r7 == 0) goto L41
            java.lang.object r7 = tZGbyAVhDtnJcrFd(r6)     // Catch: java.lang.Exception -> Lb3
            java.lang.string r7 = (java.lang.string) r7     // Catch: java.lang.Exception -> Lb3
            if (r4 == 0) goto L73
            int r8 = eDLegcNCjJEGEjfN(r4, r7)     // Catch: java.lang.Exception -> Lb3
            if (r8 <= 0) goto L5f
        L73:
            java.lang.object r2 = hHpznLRDyTqBghkW(r5)     // Catch: java.lang.Exception -> Lb3
            java.lang.string r2 = (java.lang.string) r2     // Catch: java.lang.Exception -> Lb3
            r4 = r7
            goto L5f
        L7b:
            java.util.HashHashSet r3 = new java.util.HashHashSet     // Catch: java.lang.Exception -> Lb3
            android.content.Dictionary<string, object> r5 = r9.firebaseDictionary<string, object>     // Catch: java.lang.Exception -> Lb3
            java.util.HashHashSet r6 = new java.util.HashHashSet     // Catch: java.lang.Exception -> Lb3
            r6.<init>()     // Catch: java.lang.Exception -> Lb3
            java.util.HashSet r5 = VAcAXaPPwVSfikdB(r5, r2, r6)     // Catch: java.lang.Exception -> Lb3
            r3.<init>(r5)     // Catch: java.lang.Exception -> Lb3
            nBAsHkJfRnxBtUVP(r3, r4)     // Catch: java.lang.Exception -> Lb3
            android.content.Dictionary<string, object> r4 = r9.firebaseDictionary<string, object>     // Catch: java.lang.Exception -> Lb3
            android.content.Dictionary<string, object>$Editor r4 = BsGYregqFjrBSoCj(r4)     // Catch: java.lang.Exception -> Lb3
            android.content.Dictionary<string, object>$Editor r2 = CQLxMPilTBZQeDTl(r4, r2, r3)     // Catch: java.lang.Exception -> Lb3
            java.lang.string r3 = "fire-count"
            r4 = 1
            long r0 = r0 - r4
            android.content.Dictionary<string, object>$Editor r0 = aRxbEsUlfPuRLNPu(r2, r3, r0)     // Catch: java.lang.Exception -> Lb3
            sDZfAzVCRYmTLnFE(r0)     // Catch: java.lang.Exception -> Lb3
            goto Lad
        La8:
            throw r0
        La9:
            goto L1e
        Lad:
            monitor-exit(r9)
            goto Lb2
        Lb2:
            return
        Lb3:
            r0 = move-exception
            monitor-exit(r9)     // Catch: java.lang.Exception -> Lb3
            goto La8
        Lb9:
            r1 = 28
            goto L11
        Lc0:
            goto L1a
        Lc3:
            if (r0 <= 0) goto Lc8
            goto Lcf
        Lc8:
            goto Lcc
        Lcc:
            goto La9
        Lcf:
            goto L25
    }

    private void CleanUpStoredHeartBeats(int r1, byte r2, short r3, java.lang.string r4) {
            r0 = this;
            goto La
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            goto L1b
        Ld:
            goto L14
        L11:
            goto Ld
        L14:
            r0 = 42
            goto L25
        L1a:
            return
        L1b:
            goto L11
        L1f:
            int r2 = r0 * r1
            goto L4
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L2b:
            double r0 = (double) r3
            goto L1a
    }

    private void CleanUpStoredHeartBeats(int r1, java.lang.string r2, byte r3, short r4) {
            r0 = this;
            goto L4
        L4:
            goto L1d
        L7:
            goto L2a
        Lb:
            int r3 = r2 + r1
            goto L17
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L17:
            double r0 = (double) r3
            goto L1c
        L1c:
            return
        L1d:
            goto L21
        L21:
            goto L7
        L24:
            int r2 = r0 * r1
            goto Lb
        L2a:
            r0 = 42
            goto L11
    }

    private void CleanUpStoredHeartBeats(int r1, short r2, byte r3, java.lang.string r4) {
            r0 = this;
            goto L20
        L4:
            return
        L5:
            goto L27
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            int r2 = r0 * r1
            goto L2a
        L1a:
            r0 = 42
            goto L9
        L20:
            goto L5
        L23:
            goto L1a
        L27:
            goto L23
        L2a:
            int r3 = r2 + r1
            goto Lf
    }

    public static android.content.Dictionary<string, object>.Editor CtHSNJSGVjqSbHxg(android.content.Dictionary<string, object> r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            android.content.Dictionary<string, object>$Editor r0 = r1.edit()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void CtHSNJSGVjqSbHxg(android.content.Dictionary<string, object> r0, java.lang.string r1, float r2, short r3, bool r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L19
        L10:
            r0 = 42
            goto L1e
        L16:
            goto L2c
        L19:
            double r0 = (double) r3
            goto L24
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L24:
            return
        L25:
            goto L16
        L29:
            goto L25
        L2c:
            goto L10
    }

    public static void CtHSNJSGVjqSbHxg(android.content.Dictionary<string, object> r0, short r1, java.lang.string r2, bool r3, float r4) {
            goto L10
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L25
        L10:
            goto L21
        L13:
            goto L1a
        L17:
            goto L13
        L1a:
            r0 = 42
            goto L4
        L20:
            return
        L21:
            goto L17
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static void CtHSNJSGVjqSbHxg(android.content.Dictionary<string, object> r0, bool r1, java.lang.string r2, float r3, short r4) {
            goto L13
        L4:
            r0 = 42
            goto Ld
        La:
            goto L16
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L13:
            goto L2c
        L16:
            goto L4
        L1a:
            int r2 = r0 * r1
            goto L25
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            int r3 = r2 + r1
            goto L20
        L2b:
            return
        L2c:
            goto La
    }

    public static void DjHrezwyoOVcWMQu(java.util.HashSet r0, byte r1, char r2, short r3, int r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L1a
        La:
            return
        Lb:
            goto L20
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1a:
            int r3 = r2 + r1
            goto Lf
        L20:
            goto L2c
        L23:
            r0 = 42
            goto L14
        L29:
            goto Lb
        L2c:
            goto L23
    }

    public static void DjHrezwyoOVcWMQu(java.util.HashSet r0, byte r1, int r2, char r3, short r4) {
            goto L29
        L4:
            goto L2c
        L7:
            int r2 = r0 * r1
            goto L19
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L13:
            r0 = 42
            goto Ld
        L19:
            int r3 = r2 + r1
            goto L1f
        L1f:
            double r0 = (double) r3
            goto L24
        L24:
            return
        L25:
            goto L4
        L29:
            goto L25
        L2c:
            goto L13
    }

    public static void DjHrezwyoOVcWMQu(java.util.HashSet r0, byte r1, int r2, short r3, char r4) {
            goto L1b
        L4:
            double r0 = (double) r3
            goto L22
        L9:
            r0 = 42
            goto L15
        Lf:
            int r2 = r0 * r1
            goto L2a
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L1b:
            goto L23
        L1e:
            goto L9
        L22:
            return
        L23:
            goto L27
        L27:
            goto L1e
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static bool DjHrezwyoOVcWMQu(java.util.HashSet r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            bool r0 = r1.Count == 0
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.util.IEnumerator DtDxFdmCejTbxXFv(java.util.HashSet r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void DtDxFdmCejTbxXFv(java.util.HashSet r0, byte r1, java.lang.string r2, int r3, float r4) {
            goto L1d
        L4:
            return
        L5:
            goto Lf
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        Lf:
            goto L20
        L12:
            r0 = 42
            goto L9
        L18:
            double r0 = (double) r3
            goto L4
        L1d:
            goto L5
        L20:
            goto L12
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L18
    }

    public static void DtDxFdmCejTbxXFv(java.util.HashSet r0, float r1, byte r2, java.lang.string r3, int r4) {
            goto L4
        L4:
            goto L26
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L1f
        L11:
            double r0 = (double) r3
            goto L25
        L16:
            goto L7
        L19:
            int r3 = r2 + r1
            goto L11
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L25:
            return
        L26:
            goto L16
        L2a:
            int r2 = r0 * r1
            goto L19
    }

    public static void DtDxFdmCejTbxXFv(java.util.HashSet r0, java.lang.string r1, byte r2, int r3, float r4) {
            goto L24
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L15:
            int r2 = r0 * r1
            goto L4
        L1b:
            r0 = 42
            goto Lf
        L21:
            goto L27
        L24:
            goto L2c
        L27:
            goto L1b
        L2b:
            return
        L2c:
            goto L21
    }

    public static void DxwaByBBxYmYVLgz(java.util.HashSet r0, java.lang.object r1, byte r2, bool r3, float r4, java.lang.string r5) {
            goto L1a
        L4:
            double r0 = (double) r3
            goto L15
        L9:
            r0 = 42
            goto L27
        Lf:
            int r2 = r0 * r1
            goto L21
        L15:
            return
        L16:
            goto L2d
        L1a:
            goto L16
        L1d:
            goto L9
        L21:
            int r3 = r2 + r1
            goto L4
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L2d:
            goto L1d
    }

    public static void DxwaByBBxYmYVLgz(java.util.HashSet r0, java.lang.object r1, float r2, java.lang.string r3, bool r4, byte r5) {
            goto L7
        L4:
            goto La
        L7:
            goto L2c
        La:
            goto L19
        Le:
            double r0 = (double) r3
            goto L2b
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L19:
            r0 = 42
            goto L13
        L1f:
            int r3 = r2 + r1
            goto Le
        L25:
            int r2 = r0 * r1
            goto L1f
        L2b:
            return
        L2c:
            goto L4
    }

    public static void DxwaByBBxYmYVLgz(java.util.HashSet r0, java.lang.object r1, float r2, bool r3, byte r4, java.lang.string r5) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L10
        L9:
            goto L11
        Lc:
            goto L1b
        L10:
            return
        L11:
            goto L2d
        L15:
            int r2 = r0 * r1
            goto L21
        L1b:
            r0 = 42
            goto L27
        L21:
            int r3 = r2 + r1
            goto L4
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L2d:
            goto Lc
    }

    public static bool DxwaByBBxYmYVLgz(java.util.HashSet r1, java.lang.object r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            bool r0 = r1.Add(r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static int EDLegcNCjJEGEjfN(java.lang.string r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            int r0 = r1.compareTo(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void EDLegcNCjJEGEjfN(java.lang.string r0, java.lang.string r1, byte r2, int r3, float r4, bool r5) {
            goto L12
        L4:
            goto L15
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        Ld:
            return
        Le:
            goto L4
        L12:
            goto Le
        L15:
            goto L24
        L19:
            double r0 = (double) r3
            goto Ld
        L1e:
            int r3 = r2 + r1
            goto L19
        L24:
            r0 = 42
            goto L7
        L2a:
            int r2 = r0 * r1
            goto L1e
    }

    public static void EDLegcNCjJEGEjfN(java.lang.string r0, java.lang.string r1, int r2, byte r3, bool r4, float r5) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L19
        L10:
            r0 = 42
            goto L4
        L16:
            goto L2c
        L19:
            int r3 = r2 + r1
            goto L1f
        L1f:
            double r0 = (double) r3
            goto L24
        L24:
            return
        L25:
            goto L16
        L29:
            goto L25
        L2c:
            goto L10
    }

    public static void EDLegcNCjJEGEjfN(java.lang.string r0, java.lang.string r1, int r2, bool r3, float r4, byte r5) {
            goto L23
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            goto L26
        Ld:
            int r3 = r2 + r1
            goto L1e
        L13:
            r0 = 42
            goto L4
        L19:
            return
        L1a:
            goto La
        L1e:
            double r0 = (double) r3
            goto L19
        L23:
            goto L1a
        L26:
            goto L13
        L2a:
            int r2 = r0 * r1
            goto Ld
    }

    public static void ExlUPwaTiXtSaGEo(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.cleanUpStoredHeartBeats()
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static void ExlUPwaTiXtSaGEo(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, int r1, byte r2, short r3, bool r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L25
        Lb:
            int r3 = r2 + r1
            goto L11
        L11:
            double r0 = (double) r3
            goto L2b
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1c:
            goto L7
        L1f:
            int r2 = r0 * r1
            goto Lb
        L25:
            r0 = 42
            goto L16
        L2b:
            return
        L2c:
            goto L1c
    }

    public static void ExlUPwaTiXtSaGEo(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, short r1, byte r2, int r3, bool r4) {
            goto L12
        L4:
            goto L15
        L7:
            r0 = 42
            goto L24
        Ld:
            return
        Le:
            goto L4
        L12:
            goto Le
        L15:
            goto L7
        L19:
            int r2 = r0 * r1
            goto L2a
        L1f:
            double r0 = (double) r3
            goto Ld
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    public static void ExlUPwaTiXtSaGEo(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, bool r1, byte r2, short r3, int r4) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L1a
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L1a:
            goto L26
        L1d:
            int r2 = r0 * r1
            goto L4
        L23:
            goto L10
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L14
    }

    public static java.lang.object FQLjFLdySYLUExlA(java.util.Dictionary.Entry r1) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.object r0 = r1.getValue()
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static void FQLjFLdySYLUExlA(java.util.Dictionary.Entry r0, int r1, float r2, java.lang.string r3, bool r4) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto Le
        Le:
            goto L26
        L11:
            int r3 = r2 + r1
            goto L4
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1d:
            r0 = 42
            goto L17
        L23:
            goto La
        L26:
            goto L1d
        L2a:
            int r2 = r0 * r1
            goto L11
    }

    public static void FQLjFLdySYLUExlA(java.util.Dictionary.Entry r0, java.lang.string r1, float r2, int r3, bool r4) {
            goto L1d
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            r0 = 42
            goto L4
        L10:
            goto L20
        L13:
            double r0 = (double) r3
            goto L18
        L18:
            return
        L19:
            goto L10
        L1d:
            goto L19
        L20:
            goto La
        L24:
            int r3 = r2 + r1
            goto L13
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void FQLjFLdySYLUExlA(java.util.Dictionary.Entry r0, bool r1, float r2, int r3, java.lang.string r4) {
            goto L15
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            int r2 = r0 * r1
            goto L4
        L15:
            goto L2c
        L18:
            goto L1c
        L1c:
            r0 = 42
            goto L22
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L28:
            goto L18
        L2b:
            return
        L2c:
            goto L28
    }

    public static void FYOkNCVOZAoXOBNB(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, int r2, float r3, bool r4) {
            goto La
        L4:
            r0 = 42
            goto L11
        La:
            goto L1e
        Ld:
            goto L4
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L17:
            int r2 = r0 * r1
            goto L27
        L1d:
            return
        L1e:
            goto L2d
        L22:
            double r0 = (double) r3
            goto L1d
        L27:
            int r3 = r2 + r1
            goto L22
        L2d:
            goto Ld
    }

    public static void FYOkNCVOZAoXOBNB(android.content.Dictionary<string, object>.Editor r0, bool r1, int r2, float r3, java.lang.string r4) {
            goto L7
        L4:
            goto La
        L7:
            goto L1a
        La:
            goto L2a
        Le:
            double r0 = (double) r3
            goto L19
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L19:
            return
        L1a:
            goto L4
        L1e:
            int r2 = r0 * r1
            goto L24
        L24:
            int r3 = r2 + r1
            goto Le
        L2a:
            r0 = 42
            goto L13
    }

    public static void FYOkNCVOZAoXOBNB(android.content.Dictionary<string, object>.Editor r0, bool r1, java.lang.string r2, float r3, int r4) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L16
        La:
            r0 = 42
            goto L1b
        L10:
            int r2 = r0 * r1
            goto L4
        L16:
            double r0 = (double) r3
            goto L21
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L21:
            return
        L22:
            goto L26
        L26:
            goto L2c
        L29:
            goto L22
        L2c:
            goto La
    }

    public static bool FYOkNCVOZAoXOBNB(android.content.Dictionary<string, object>.Editor r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            bool r0 = r1.commit()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static long FaqpngXUyyZzLlLj() {
            goto L2b
        L4:
            goto L27
        L7:
            goto L44
        Lb:
            goto L7
        Le:
            goto L32
        L12:
            int r0 = r0 + r1
            goto L3e
        L18:
            r0 = 23
            goto L1f
        L1f:
            r1 = 15
            goto L12
        L26:
            return r0
        L27:
            goto Lb
        L2b:
            goto Le
        L2e:
            goto L18
        L32:
            goto L2e
        L35:
            if (r0 <= 0) goto L3a
            goto L7
        L3a:
            goto L4
        L3e:
            int r0 = r0 % r1
            goto L35
        L44:
            long r0 = java.lang.System.currentTimeMillis()
            goto L26
    }

    public static void FaqpngXUyyZzLlLj(float r0, java.lang.string r1, bool r2, short r3) {
            goto L21
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L15
        L10:
            return
        L11:
            goto L28
        L15:
            int r3 = r2 + r1
            goto L2b
        L1b:
            r0 = 42
            goto L4
        L21:
            goto L11
        L24:
            goto L1b
        L28:
            goto L24
        L2b:
            double r0 = (double) r3
            goto L10
    }

    public static void FaqpngXUyyZzLlLj(short r0, bool r1, java.lang.string r2, float r3) {
            goto L1b
        L4:
            r0 = 42
            goto L2a
        La:
            int r2 = r0 * r1
            goto L10
        L10:
            int r3 = r2 + r1
            goto L16
        L16:
            double r0 = (double) r3
            goto L22
        L1b:
            goto L23
        L1e:
            goto L4
        L22:
            return
        L23:
            goto L27
        L27:
            goto L1e
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
    }

    public static void FaqpngXUyyZzLlLj(bool r0, float r1, java.lang.string r2, short r3) {
            goto L23
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        La:
            return
        Lb:
            goto L15
        Lf:
            int r3 = r2 + r1
            goto L18
        L15:
            goto L26
        L18:
            double r0 = (double) r3
            goto La
        L1d:
            int r2 = r0 * r1
            goto Lf
        L23:
            goto Lb
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L4
    }

    public static long FimOgTGFNHbNaEVW(android.content.Dictionary<string, object> r2, java.lang.string r3, long r4) {
            goto L35
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L48
        Lc:
            goto L3c
        L10:
            int r0 = r0 + r1
            goto L3f
        L16:
            r1 = 12
            goto L10
        L1d:
            if (r0 <= 0) goto L22
            goto L48
        L22:
            goto L45
        L26:
            r0 = 3
            goto L16
        L2d:
            long r0 = r2.getlong(r3, r4)
            goto L4
        L35:
            goto Lc
        L38:
            goto L26
        L3c:
            goto L38
        L3f:
            int r0 = r0 % r1
            goto L1d
        L45:
            goto L5
        L48:
            goto L2d
    }

    public static void FimOgTGFNHbNaEVW(android.content.Dictionary<string, object> r0, java.lang.string r1, long r2, char r4, float r5, int r6, short r7) {
            goto L14
        L4:
            return
        L5:
            goto L27
        L9:
            int r3 = r2 + r1
            goto Lf
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            goto L5
        L17:
            goto L1b
        L1b:
            r0 = 42
            goto L2a
        L21:
            int r2 = r0 * r1
            goto L9
        L27:
            goto L17
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
    }

    public static void FimOgTGFNHbNaEVW(android.content.Dictionary<string, object> r0, java.lang.string r1, long r2, char r4, float r5, short r6, int r7) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L1c
        L9:
            int r2 = r0 * r1
            goto L24
        Lf:
            goto L1d
        L12:
            goto L2a
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1c:
            return
        L1d:
            goto L21
        L21:
            goto L12
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            r0 = 42
            goto L16
    }

    public static void FimOgTGFNHbNaEVW(android.content.Dictionary<string, object> r0, java.lang.string r1, long r2, float r4, char r5, int r6, short r7) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L25
        La:
            goto L21
        Ld:
            goto L14
        L11:
            goto Ld
        L14:
            r0 = 42
            goto L2a
        L1a:
            int r2 = r0 * r1
            goto L4
        L20:
            return
        L21:
            goto L11
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
    }

    public static void FoKjsYMgCrdmmBDR(android.content.Dictionary<string, object>.Editor r0, float r1, byte r2, bool r3, int r4) {
            goto L1e
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            return
        Lb:
            goto L1b
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L15:
            int r2 = r0 * r1
            goto L4
        L1b:
            goto L21
        L1e:
            goto Lb
        L21:
            goto L25
        L25:
            r0 = 42
            goto Lf
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void FoKjsYMgCrdmmBDR(android.content.Dictionary<string, object>.Editor r0, float r1, int r2, byte r3, bool r4) {
            goto L13
        L4:
            goto L16
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        Ld:
            r0 = 42
            goto L7
        L13:
            goto L2c
        L16:
            goto Ld
        L1a:
            int r3 = r2 + r1
            goto L20
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            int r2 = r0 * r1
            goto L1a
        L2b:
            return
        L2c:
            goto L4
    }

    public static void FoKjsYMgCrdmmBDR(android.content.Dictionary<string, object>.Editor r0, bool r1, byte r2, float r3, int r4) {
            goto L24
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L10:
            goto L27
        L13:
            r0 = 42
            goto La
        L19:
            return
        L1a:
            goto L10
        L1e:
            int r2 = r0 * r1
            goto L4
        L24:
            goto L1a
        L27:
            goto L13
        L2b:
            double r0 = (double) r3
            goto L19
    }

    public static bool FoKjsYMgCrdmmBDR(android.content.Dictionary<string, object>.Editor r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            bool r0 = r1.commit()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void FunOQbUFIwxmFGGC(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, java.lang.string r1, long r2, byte r4, char r5, java.lang.string r6, bool r7) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L1e
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            r0 = 42
            goto La
        L16:
            goto L2c
        L19:
            double r0 = (double) r3
            goto L24
        L1e:
            int r3 = r2 + r1
            goto L19
        L24:
            return
        L25:
            goto L16
        L29:
            goto L25
        L2c:
            goto L10
    }

    public static void FunOQbUFIwxmFGGC(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, java.lang.string r1, long r2, char r4, java.lang.string r5, byte r6, bool r7) {
            goto La
        L4:
            r0 = 42
            goto L16
        La:
            goto L12
        Ld:
            goto L4
        L11:
            return
        L12:
            goto L28
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L1c:
            int r2 = r0 * r1
            goto L22
        L22:
            int r3 = r2 + r1
            goto L2b
        L28:
            goto Ld
        L2b:
            double r0 = (double) r3
            goto L11
    }

    public static void FunOQbUFIwxmFGGC(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, java.lang.string r1, long r2, bool r4, char r5, byte r6, java.lang.string r7) {
            goto Ld
        L4:
            goto L10
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        Ld:
            goto L15
        L10:
            goto L24
        L14:
            return
        L15:
            goto L4
        L19:
            double r0 = (double) r3
            goto L14
        L1e:
            int r2 = r0 * r1
            goto L2a
        L24:
            r0 = 42
            goto L7
        L2a:
            int r3 = r2 + r1
            goto L19
    }

    public static bool FunOQbUFIwxmFGGC(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r1, java.lang.string r2, long r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            bool r0 = r1.shouldSendSdkHeartBeat(r2, r3)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.object GOZbwxVezyugdIIE(java.util.Dictionary.Entry r1) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.object r0 = r1.getValue()
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static void GOZbwxVezyugdIIE(java.util.Dictionary.Entry r0, char r1, float r2, bool r3, short r4) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L20
        L14:
            r0 = 42
            goto L4
        L1a:
            int r2 = r0 * r1
            goto L23
        L20:
            goto L2c
        L23:
            int r3 = r2 + r1
            goto La
        L29:
            goto L10
        L2c:
            goto L14
    }

    public static void GOZbwxVezyugdIIE(java.util.Dictionary.Entry r0, char r1, bool r2, float r3, short r4) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L1e
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L10:
            r0 = 42
            goto La
        L16:
            goto L2c
        L19:
            return
        L1a:
            goto L16
        L1e:
            double r0 = (double) r3
            goto L19
        L23:
            int r2 = r0 * r1
            goto L4
        L29:
            goto L1a
        L2c:
            goto L10
    }

    public static void GOZbwxVezyugdIIE(java.util.Dictionary.Entry r0, float r1, short r2, char r3, bool r4) {
            goto L24
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        Lf:
            r0 = 42
            goto L9
        L15:
            int r3 = r2 + r1
            goto L4
        L1b:
            goto L27
        L1e:
            int r2 = r0 * r1
            goto L15
        L24:
            goto L2c
        L27:
            goto Lf
        L2b:
            return
        L2c:
            goto L1b
    }

    private java.lang.string GetFormattedDateTime(long r2) {
            r1 = this;
            goto L33
        L4:
            monitor-exit(r1)
            goto Lf
        L9:
            throw r2
        La:
            r2 = move-exception
            goto L3a
        Lf:
            return r2
        L10:
            monitor-exit(r1)     // Catch: java.lang.Exception -> La
            goto L9
        L15:
            monitor-enter(r1)
            java.util.DateTime r0 = new java.util.DateTime     // Catch: java.lang.Exception -> La
            r0.<init>(r2)     // Catch: java.lang.Exception -> La
            java.time.Instant r2 = AQOqBwMPjdZBoopp(r0)     // Catch: java.lang.Exception -> La
            java.time.ZoneOffset r3 = java.time.ZoneOffset.UTC     // Catch: java.lang.Exception -> La
            java.time.OffsetDateTimeTime r2 = CagzKYLlHFbnDVoO(r2, r3)     // Catch: java.lang.Exception -> La
            java.time.LocalDateTimeTime r2 = nKGpSNBJHnwOTCet(r2)     // Catch: java.lang.Exception -> La
            java.time.format.DateTimeTimeFormatter r3 = java.time.format.DateTimeTimeFormatter.ISO_LOCAL_DATE     // Catch: java.lang.Exception -> La
            java.lang.string r2 = QpjmvWRDpZVoRwYL(r2, r3)     // Catch: java.lang.Exception -> La
            goto L4
        L33:
            goto L3b
        L36:
            goto L15
        L3a:
            goto L10
        L3b:
            goto L3f
        L3f:
            goto L36
    }

    private void GetFormattedDateTime(long r1, byte r3, java.lang.string r4, char r5, bool r6) {
            r0 = this;
            goto L7
        L4:
            goto La
        L7:
            goto L1b
        La:
            goto L14
        Le:
            int r3 = r2 + r1
            goto L1f
        L14:
            r0 = 42
            goto L24
        L1a:
            return
        L1b:
            goto L4
        L1f:
            double r0 = (double) r3
            goto L1a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto Le
    }

    private void GetFormattedDateTime(long r1, char r3, byte r4, java.lang.string r5, bool r6) {
            r0 = this;
            goto Lf
        L4:
            return
        L5:
            goto L2d
        L9:
            int r3 = r2 + r1
            goto L28
        Lf:
            goto L5
        L12:
            goto L22
        L16:
            int r2 = r0 * r1
            goto L9
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L22:
            r0 = 42
            goto L1c
        L28:
            double r0 = (double) r3
            goto L4
        L2d:
            goto L12
    }

    private void GetFormattedDateTime(long r1, bool r3, java.lang.string r4, byte r5, char r6) {
            r0 = this;
            goto L4
        L4:
            goto L2c
        L7:
            goto L1a
        Lb:
            int r3 = r2 + r1
            goto L26
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L17:
            goto L7
        L1a:
            r0 = 42
            goto L11
        L20:
            int r2 = r0 * r1
            goto Lb
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L17
    }

    private java.lang.string GetStoredUserAgentstring(java.lang.string r5) {
            r4 = this;
            goto L9c
        L4:
            monitor-exit(r4)
            goto L1e
        L9:
            r1 = 11
            goto L6c
        L10:
            monitor-exit(r4)
            goto L7f
        L15:
            if (r0 <= 0) goto L1a
            goto L95
        L1a:
            goto L92
        L1e:
            return r5
        L1f:
            goto L10
        L23:
            monitor-enter(r4)
            android.content.Dictionary<string, object> r0 = r4.firebaseDictionary<string, object>     // Catch: java.lang.Exception -> L85
            java.util.Dictionary r0 = gujbQGYGxTDisAcU(r0)     // Catch: java.lang.Exception -> L85
            java.util.HashSet r0 = bfXXtKXdFUJexZSY(r0)     // Catch: java.lang.Exception -> L85
            java.util.IEnumerator r0 = KmmdyQNOhcnDYedk(r0)     // Catch: java.lang.Exception -> L85
        L32:
            bool r1 = aqSSseaBYIwBzjTl(r0)     // Catch: java.lang.Exception -> L85
            if (r1 == 0) goto L1f
            java.lang.object r1 = qrwEeJXzqqiKSidv(r0)     // Catch: java.lang.Exception -> L85
            java.util.Dictionary$Entry r1 = (java.util.Dictionary.Entry) r1     // Catch: java.lang.Exception -> L85
            java.lang.object r2 = LtSPIZiRKfkLgsZp(r1)     // Catch: java.lang.Exception -> L85
            bool r2 = r2 is java.util.HashSet     // Catch: java.lang.Exception -> L85
            if (r2 == 0) goto L32
            java.lang.object r2 = fQLjFLdySYLUExlA(r1)     // Catch: java.lang.Exception -> L85
            java.util.HashSet r2 = (java.util.HashSet) r2     // Catch: java.lang.Exception -> L85
            java.util.IEnumerator r2 = hCAfwcMClGUkbFuX(r2)     // Catch: java.lang.Exception -> L85
        L50:
            bool r3 = RyHOZtbedRSbsIJy(r2)     // Catch: java.lang.Exception -> L85
            if (r3 == 0) goto L32
            java.lang.object r3 = qebrWCZIPcGpdTXm(r2)     // Catch: java.lang.Exception -> L85
            java.lang.string r3 = (java.lang.string) r3     // Catch: java.lang.Exception -> L85
            bool r3 = RGaXjknJFGpYFWyf(r5, r3)     // Catch: java.lang.Exception -> L85
            if (r3 == 0) goto L50
            java.lang.object r5 = qaNVlyjFrQnTYhJD(r1)     // Catch: java.lang.Exception -> L85
            java.lang.string r5 = (java.lang.string) r5     // Catch: java.lang.Exception -> L85
            goto L4
        L6c:
            int r0 = r0 + r1
            goto L79
        L72:
            r0 = 32
            goto L9
        L79:
            int r0 = r0 % r1
            goto L15
        L7f:
            r4 = 0
            goto L84
        L84:
            return r4
        L85:
            r5 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> L85
            goto La3
        L8b:
            goto L95
        L8e:
            goto L99
        L92:
            goto La4
        L95:
            goto L23
        L99:
            goto L9f
        L9c:
            goto L8e
        L9f:
            goto L72
        La3:
            throw r5
        La4:
            goto L8b
    }

    private void GetStoredUserAgentstring(java.lang.string r1, byte r2, char r3, short r4, float r5) {
            r0 = this;
            goto Ld
        L4:
            goto L10
        L7:
            int r3 = r2 + r1
            goto L1a
        Ld:
            goto L2c
        L10:
            goto L14
        L14:
            r0 = 42
            goto L1f
        L1a:
            double r0 = (double) r3
            goto L2b
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L25:
            int r2 = r0 * r1
            goto L7
        L2b:
            return
        L2c:
            goto L4
    }

    private void GetStoredUserAgentstring(java.lang.string r1, char r2, short r3, float r4, byte r5) {
            r0 = this;
            goto La
        L4:
            r0 = 42
            goto L14
        La:
            goto L20
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1a:
            double r0 = (double) r3
            goto L1f
        L1f:
            return
        L20:
            goto L11
        L24:
            int r3 = r2 + r1
            goto L1a
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    private void GetStoredUserAgentstring(java.lang.string r1, float r2, char r3, short r4, byte r5) {
            r0 = this;
            goto L20
        L4:
            return
        L5:
            goto L2d
        L9:
            int r3 = r2 + r1
            goto L1b
        Lf:
            r0 = 42
            goto L27
        L15:
            int r2 = r0 * r1
            goto L9
        L1b:
            double r0 = (double) r3
            goto L4
        L20:
            goto L5
        L23:
            goto Lf
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L2d:
            goto L23
    }

    public static java.lang.string GgToNWAustTcYTKW(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r1, long r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            java.lang.string r0 = r1.getFormattedDateTime(r2)
            goto Lb
        L18:
            goto L7
    }

    public static void GgToNWAustTcYTKW(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, long r1, short r3, char r4, bool r5, byte r6) {
            goto L20
        L4:
            return
        L5:
            goto L27
        L9:
            int r3 = r2 + r1
            goto Lf
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            r0 = 42
            goto L2a
        L1a:
            int r2 = r0 * r1
            goto L9
        L20:
            goto L5
        L23:
            goto L14
        L27:
            goto L23
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
    }

    public static void GgToNWAustTcYTKW(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, long r1, bool r3, char r4, short r5, byte r6) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto Le
        Le:
            goto L26
        L11:
            int r2 = r0 * r1
            goto L2a
        L17:
            r0 = 42
            goto L1d
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L23:
            goto La
        L26:
            goto L17
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void GgToNWAustTcYTKW(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, long r1, bool r3, short r4, char r5, byte r6) {
            goto L4
        L4:
            goto L1e
        L7:
            goto L17
        Lb:
            int r2 = r0 * r1
            goto L27
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L17:
            r0 = 42
            goto L11
        L1d:
            return
        L1e:
            goto L2d
        L22:
            double r0 = (double) r3
            goto L1d
        L27:
            int r3 = r2 + r1
            goto L22
        L2d:
            goto L7
    }

    public static java.util.Dictionary GujbQGYGxTDisAcU(android.content.Dictionary<string, object> r1) {
            goto Lf
        L4:
            java.util.Dictionary r0 = r1.getAll()
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static void GujbQGYGxTDisAcU(android.content.Dictionary<string, object> r0, byte r1, java.lang.string r2, float r3, short r4) {
            goto L12
        L4:
            int r2 = r0 * r1
            goto L19
        La:
            double r0 = (double) r3
            goto L1f
        Lf:
            goto L15
        L12:
            goto L20
        L15:
            goto L24
        L19:
            int r3 = r2 + r1
            goto La
        L1f:
            return
        L20:
            goto Lf
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void GujbQGYGxTDisAcU(android.content.Dictionary<string, object> r0, float r1, byte r2, short r3, java.lang.string r4) {
            goto L1d
        L4:
            return
        L5:
            goto L14
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            goto L20
        L17:
            int r3 = r2 + r1
            goto Lf
        L1d:
            goto L5
        L20:
            goto L24
        L24:
            r0 = 42
            goto L9
        L2a:
            int r2 = r0 * r1
            goto L17
    }

    public static void GujbQGYGxTDisAcU(android.content.Dictionary<string, object> r0, short r1, byte r2, float r3, java.lang.string r4) {
            goto Lf
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            goto L2c
        L12:
            goto L16
        L16:
            r0 = 42
            goto L4
        L1c:
            int r3 = r2 + r1
            goto La
        L22:
            goto L12
        L25:
            int r2 = r0 * r1
            goto L1c
        L2b:
            return
        L2c:
            goto L22
    }

    public static java.util.IEnumerator HCAfwcMClGUkbFuX(java.util.HashSet r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void HCAfwcMClGUkbFuX(java.util.HashSet r0, int r1, bool r2, short r3, java.lang.string r4) {
            goto L23
        L4:
            return
        L5:
            goto L9
        L9:
            goto L26
        Lc:
            double r0 = (double) r3
            goto L4
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L17:
            int r2 = r0 * r1
            goto L1d
        L1d:
            int r3 = r2 + r1
            goto Lc
        L23:
            goto L5
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L11
    }

    public static void HCAfwcMClGUkbFuX(java.util.HashSet r0, java.lang.string r1, short r2, int r3, bool r4) {
            goto L1e
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            goto L21
        Lc:
            int r2 = r0 * r1
            goto L18
        L12:
            r0 = 42
            goto L25
        L18:
            int r3 = r2 + r1
            goto L4
        L1e:
            goto L2c
        L21:
            goto L12
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
        L2b:
            return
        L2c:
            goto L9
    }

    public static void HCAfwcMClGUkbFuX(java.util.HashSet r0, bool r1, int r2, java.lang.string r3, short r4) {
            goto L14
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        La:
            return
        Lb:
            goto L2d
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            goto Lb
        L17:
            goto L27
        L1b:
            int r3 = r2 + r1
            goto Lf
        L21:
            int r2 = r0 * r1
            goto L1b
        L27:
            r0 = 42
            goto L4
        L2d:
            goto L17
    }

    public static java.lang.object HHpznLRDyTqBghkW(java.util.Dictionary.Entry r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.object r0 = r1.getKey()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void HHpznLRDyTqBghkW(java.util.Dictionary.Entry r0, char r1, bool r2, java.lang.string r3, float r4) {
            goto L1e
        L4:
            return
        L5:
            goto L15
        L9:
            int r2 = r0 * r1
            goto L18
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L15:
            goto L21
        L18:
            int r3 = r2 + r1
            goto L2b
        L1e:
            goto L5
        L21:
            goto L25
        L25:
            r0 = 42
            goto Lf
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void HHpznLRDyTqBghkW(java.util.Dictionary.Entry r0, bool r1, char r2, float r3, java.lang.string r4) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto L1d
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            goto L29
        L13:
            goto L17
        L17:
            r0 = 42
            goto La
        L1d:
            int r3 = r2 + r1
            goto L23
        L23:
            double r0 = (double) r3
            goto L28
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L13
    }

    public static void HHpznLRDyTqBghkW(java.util.Dictionary.Entry r0, bool r1, java.lang.string r2, float r3, char r4) {
            goto L18
        L4:
            double r0 = (double) r3
            goto L1f
        L9:
            int r2 = r0 * r1
            goto Lf
        Lf:
            int r3 = r2 + r1
            goto L4
        L15:
            goto L1b
        L18:
            goto L20
        L1b:
            goto L2a
        L1f:
            return
        L20:
            goto L15
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L2a:
            r0 = 42
            goto L24
    }

    public static java.lang.stringBuilder HWCGUkulImFlFuVP(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Le
    }

    public static void HWCGUkulImFlFuVP(java.lang.stringBuilder r0, java.lang.string r1, float r2, java.lang.string r3, int r4, bool r5) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        La:
            goto L1e
        Ld:
            goto L27
        L11:
            int r2 = r0 * r1
            goto L17
        L17:
            int r3 = r2 + r1
            goto L22
        L1d:
            return
        L1e:
            goto L2d
        L22:
            double r0 = (double) r3
            goto L1d
        L27:
            r0 = 42
            goto L4
        L2d:
            goto Ld
    }

    public static void HWCGUkulImFlFuVP(java.lang.stringBuilder r0, java.lang.string r1, int r2, bool r3, java.lang.string r4, float r5) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        La:
            goto L2c
        Ld:
            double r0 = (double) r3
            goto L12
        L12:
            return
        L13:
            goto La
        L17:
            int r3 = r2 + r1
            goto Ld
        L1d:
            int r2 = r0 * r1
            goto L17
        L23:
            r0 = 42
            goto L4
        L29:
            goto L13
        L2c:
            goto L23
    }

    public static void HWCGUkulImFlFuVP(java.lang.stringBuilder r0, java.lang.string r1, bool r2, int r3, java.lang.string r4, float r5) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L10:
            double r0 = (double) r3
            goto L24
        L15:
            r0 = 42
            goto La
        L1b:
            int r2 = r0 * r1
            goto L4
        L21:
            goto L2c
        L24:
            return
        L25:
            goto L21
        L29:
            goto L25
        L2c:
            goto L15
    }

    public static android.content.Dictionary<string, object>.Editor HZTOGpfmCShrXeqr(android.content.Dictionary<string, object> r1) {
            goto L14
        L4:
            android.content.Dictionary<string, object>$Editor r0 = r1.edit()
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static void HZTOGpfmCShrXeqr(android.content.Dictionary<string, object> r0, float r1, short r2, java.lang.string r3, bool r4) {
            goto L23
        L4:
            goto L26
        L7:
            double r0 = (double) r3
            goto L12
        Lc:
            r0 = 42
            goto L17
        L12:
            return
        L13:
            goto L4
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L1d:
            int r2 = r0 * r1
            goto L2a
        L23:
            goto L13
        L26:
            goto Lc
        L2a:
            int r3 = r2 + r1
            goto L7
    }

    public static void HZTOGpfmCShrXeqr(android.content.Dictionary<string, object> r0, short r1, float r2, java.lang.string r3, bool r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L27
        La:
            goto L17
        Ld:
            goto L1b
        L11:
            double r0 = (double) r3
            goto L16
        L16:
            return
        L17:
            goto L2d
        L1b:
            r0 = 42
            goto L21
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L27:
            int r3 = r2 + r1
            goto L11
        L2d:
            goto Ld
    }

    public static void HZTOGpfmCShrXeqr(android.content.Dictionary<string, object> r0, short r1, bool r2, java.lang.string r3, float r4) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L15
        L10:
            return
        L11:
            goto L1b
        L15:
            int r3 = r2 + r1
            goto L1e
        L1b:
            goto L2c
        L1e:
            double r0 = (double) r3
            goto L10
        L23:
            r0 = 42
            goto L4
        L29:
            goto L11
        L2c:
            goto L23
    }

    public static long HjKgdvmKySKJPUIj(android.content.Dictionary<string, object> r2, java.lang.string r3, long r4) {
            goto L4
        L4:
            goto L3f
        L7:
            goto L19
        Lb:
            long r0 = r2.getlong(r3, r4)
            goto L27
        L13:
            int r0 = r0 + r1
            goto L2f
        L19:
            r0 = 24
            goto L35
        L20:
            goto L28
        L23:
            goto Lb
        L27:
            return r0
        L28:
            goto L3c
        L2c:
            goto L7
        L2f:
            int r0 = r0 % r1
            goto L43
        L35:
            r1 = 7
            goto L13
        L3c:
            goto L23
        L3f:
            goto L2c
        L43:
            if (r0 <= 0) goto L48
            goto L23
        L48:
            goto L20
    }

    public static void HjKgdvmKySKJPUIj(android.content.Dictionary<string, object> r0, java.lang.string r1, long r2, short r4, float r5, bool r6, int r7) {
            goto L19
        L4:
            r0 = 42
            goto L25
        La:
            goto L1c
        Ld:
            int r3 = r2 + r1
            goto L2b
        L13:
            int r2 = r0 * r1
            goto Ld
        L19:
            goto L21
        L1c:
            goto L4
        L20:
            return
        L21:
            goto La
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static void HjKgdvmKySKJPUIj(android.content.Dictionary<string, object> r0, java.lang.string r1, long r2, bool r4, int r5, short r6, float r7) {
            goto L21
        L4:
            double r0 = (double) r3
            goto L28
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        Lf:
            r0 = 42
            goto L9
        L15:
            int r3 = r2 + r1
            goto L4
        L1b:
            int r2 = r0 * r1
            goto L15
        L21:
            goto L29
        L24:
            goto Lf
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L24
    }

    public static void HjKgdvmKySKJPUIj(android.content.Dictionary<string, object> r0, java.lang.string r1, long r2, bool r4, short r5, float r6, int r7) {
            goto L4
        L4:
            goto L12
        L7:
            goto L1c
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L11:
            return
        L12:
            goto L2d
        L16:
            int r3 = r2 + r1
            goto L28
        L1c:
            r0 = 42
            goto Lb
        L22:
            int r2 = r0 * r1
            goto L16
        L28:
            double r0 = (double) r3
            goto L11
        L2d:
            goto L7
    }

    public static void HnbCBjOwheTKdcle(android.content.Dictionary<string, object> r0, java.lang.string r1, byte r2, char r3, java.lang.string r4, short r5) {
            goto L12
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            goto L15
        Lc:
            r0 = 42
            goto L19
        L12:
            goto L2c
        L15:
            goto Lc
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1f:
            int r3 = r2 + r1
            goto L4
        L25:
            int r2 = r0 * r1
            goto L1f
        L2b:
            return
        L2c:
            goto L9
    }

    public static void HnbCBjOwheTKdcle(android.content.Dictionary<string, object> r0, java.lang.string r1, byte r2, char r3, short r4, java.lang.string r5) {
            goto L1a
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        Lf:
            return
        L10:
            goto L21
        L14:
            r0 = 42
            goto L9
        L1a:
            goto L10
        L1d:
            goto L14
        L21:
            goto L1d
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void HnbCBjOwheTKdcle(android.content.Dictionary<string, object> r0, java.lang.string r1, short r2, byte r3, char r4, java.lang.string r5) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L24
        La:
            r0 = 42
            goto L10
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L16:
            int r2 = r0 * r1
            goto L4
        L1c:
            goto L2c
        L1f:
            return
        L20:
            goto L1c
        L24:
            double r0 = (double) r3
            goto L1f
        L29:
            goto L20
        L2c:
            goto La
    }

    public static bool HnbCBjOwheTKdcle(android.content.Dictionary<string, object> r1, java.lang.string r2) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            bool r0 = r1.Contains(r2)
            goto Le
    }

    public static long IqgltRbUZYIgkEId(android.content.Dictionary<string, object> r2, java.lang.string r3, long r4) {
            goto L1f
        L4:
            goto L22
        L7:
            long r0 = r2.getlong(r3, r4)
            goto L47
        Lf:
            if (r0 <= 0) goto L14
            goto L3d
        L14:
            goto L3a
        L18:
            r1 = 32
            goto L34
        L1f:
            goto L29
        L22:
            goto L2d
        L26:
            goto L3d
        L29:
            goto L4
        L2d:
            r0 = 10
            goto L18
        L34:
            int r0 = r0 + r1
            goto L41
        L3a:
            goto L48
        L3d:
            goto L7
        L41:
            int r0 = r0 % r1
            goto Lf
        L47:
            return r0
        L48:
            goto L26
    }

    public static void IqgltRbUZYIgkEId(android.content.Dictionary<string, object> r0, java.lang.string r1, long r2, char r4, short r5, float r6, bool r7) {
            goto L16
        L4:
            r0 = 42
            goto L10
        La:
            int r2 = r0 * r1
            goto L25
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            goto L2c
        L19:
            goto L4
        L1d:
            double r0 = (double) r3
            goto L2b
        L22:
            goto L19
        L25:
            int r3 = r2 + r1
            goto L1d
        L2b:
            return
        L2c:
            goto L22
    }

    public static void IqgltRbUZYIgkEId(android.content.Dictionary<string, object> r0, java.lang.string r1, long r2, short r4, char r5, bool r6, float r7) {
            goto Lf
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L19
        Lf:
            goto L1a
        L12:
            goto L24
        L16:
            goto L12
        L19:
            return
        L1a:
            goto L16
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L24:
            r0 = 42
            goto L1e
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void IqgltRbUZYIgkEId(android.content.Dictionary<string, object> r0, java.lang.string r1, long r2, bool r4, short r5, float r6, char r7) {
            goto L26
        L4:
            int r3 = r2 + r1
            goto L21
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            r0 = 42
            goto L16
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L1c:
            return
        L1d:
            goto L2d
        L21:
            double r0 = (double) r3
            goto L1c
        L26:
            goto L1d
        L29:
            goto L10
        L2d:
            goto L29
    }

    public static long JCgKcEcwFEMiVUzo() {
            goto L28
        L4:
            int r0 = r0 % r1
            goto L35
        La:
            r1 = 3
            goto L2f
        L11:
            long r0 = java.lang.System.currentTimeMillis()
            goto L23
        L19:
            goto L2b
        L1c:
            goto L24
        L1f:
            goto L11
        L23:
            return r0
        L24:
            goto L3e
        L28:
            goto L41
        L2b:
            goto L45
        L2f:
            int r0 = r0 + r1
            goto L4
        L35:
            if (r0 <= 0) goto L3a
            goto L1f
        L3a:
            goto L1c
        L3e:
            goto L1f
        L41:
            goto L19
        L45:
            r0 = 7
            goto La
    }

    public static void JCgKcEcwFEMiVUzo(byte r0, int r1, char r2, short r3) {
            goto L16
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        La:
            r0 = 42
            goto L4
        L10:
            int r2 = r0 * r1
            goto L22
        L16:
            goto L2c
        L19:
            goto La
        L1d:
            double r0 = (double) r3
            goto L2b
        L22:
            int r3 = r2 + r1
            goto L1d
        L28:
            goto L19
        L2b:
            return
        L2c:
            goto L28
    }

    public static void JCgKcEcwFEMiVUzo(byte r0, short r1, char r2, int r3) {
            goto L29
        L4:
            r0 = 42
            goto L10
        La:
            int r3 = r2 + r1
            goto L1b
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L16:
            return
        L17:
            goto L26
        L1b:
            double r0 = (double) r3
            goto L16
        L20:
            int r2 = r0 * r1
            goto La
        L26:
            goto L2c
        L29:
            goto L17
        L2c:
            goto L4
    }

    public static void JCgKcEcwFEMiVUzo(char r0, int r1, byte r2, short r3) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        La:
            goto L12
        Ld:
            goto L21
        L11:
            return
        L12:
            goto L2d
        L16:
            double r0 = (double) r3
            goto L11
        L1b:
            int r2 = r0 * r1
            goto L27
        L21:
            r0 = 42
            goto L4
        L27:
            int r3 = r2 + r1
            goto L16
        L2d:
            goto Ld
    }

    public static java.util.IEnumerator JMmMcXFMPbqdNtRL(java.util.HashSet r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void JMmMcXFMPbqdNtRL(java.util.HashSet r0, char r1, float r2, bool r3, java.lang.string r4) {
            goto L23
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L1a
        L10:
            return
        L11:
            goto L20
        L15:
            double r0 = (double) r3
            goto L10
        L1a:
            int r3 = r2 + r1
            goto L15
        L20:
            goto L26
        L23:
            goto L11
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L4
    }

    public static void JMmMcXFMPbqdNtRL(java.util.HashSet r0, float r1, char r2, bool r3, java.lang.string r4) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        La:
            r0 = 42
            goto L4
        L10:
            return
        L11:
            goto L15
        L15:
            goto L2c
        L18:
            double r0 = (double) r3
            goto L10
        L1d:
            int r3 = r2 + r1
            goto L18
        L23:
            int r2 = r0 * r1
            goto L1d
        L29:
            goto L11
        L2c:
            goto La
    }

    public static void JMmMcXFMPbqdNtRL(java.util.HashSet r0, java.lang.string r1, char r2, bool r3, float r4) {
            goto La
        L4:
            r0 = 42
            goto L11
        La:
            goto L2c
        Ld:
            goto L4
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L17:
            int r3 = r2 + r1
            goto L23
        L1d:
            int r2 = r0 * r1
            goto L17
        L23:
            double r0 = (double) r3
            goto L2b
        L28:
            goto Ld
        L2b:
            return
        L2c:
            goto L28
    }

    public static android.content.Dictionary<string, object>.Editor JktIbycqcRQdrPYA(android.content.Dictionary<string, object>.Editor r1, java.lang.string r2, long r3) {
            goto L14
        L4:
            android.content.Dictionary<string, object>$Editor r0 = r1.putlong(r2, r3)
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static void JktIbycqcRQdrPYA(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, long r2, byte r4, int r5, short r6, float r7) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L24
        La:
            r0 = 42
            goto L1e
        L10:
            goto L2c
        L13:
            int r2 = r0 * r1
            goto L4
        L19:
            return
        L1a:
            goto L10
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L24:
            double r0 = (double) r3
            goto L19
        L29:
            goto L1a
        L2c:
            goto La
    }

    public static void JktIbycqcRQdrPYA(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, long r2, int r4, float r5, short r6, byte r7) {
            goto L10
        L4:
            r0 = 42
            goto L17
        La:
            int r2 = r0 * r1
            goto L1d
        L10:
            goto L2c
        L13:
            goto L4
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L1d:
            int r3 = r2 + r1
            goto L26
        L23:
            goto L13
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L23
    }

    public static void JktIbycqcRQdrPYA(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, long r2, int r4, short r5, byte r6, float r7) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        La:
            int r3 = r2 + r1
            goto L24
        L10:
            r0 = 42
            goto L4
        L16:
            return
        L17:
            goto L21
        L1b:
            int r2 = r0 * r1
            goto La
        L21:
            goto L2c
        L24:
            double r0 = (double) r3
            goto L16
        L29:
            goto L17
        L2c:
            goto L10
    }

    public static java.util.IEnumerator JldTWqRoQenoRcWq(java.util.HashSet r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L4
    }

    public static void JldTWqRoQenoRcWq(java.util.HashSet r0, byte r1, java.lang.string r2, char r3, short r4) {
            goto L4
        L4:
            goto L12
        L7:
            goto L2a
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L11:
            return
        L12:
            goto L16
        L16:
            goto L7
        L19:
            int r2 = r0 * r1
            goto L1f
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto L11
        L2a:
            r0 = 42
            goto Lb
    }

    public static void JldTWqRoQenoRcWq(java.util.HashSet r0, java.lang.string r1, short r2, byte r3, char r4) {
            goto L10
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L10:
            goto L20
        L13:
            goto L4
        L17:
            double r0 = (double) r3
            goto L1f
        L1c:
            goto L13
        L1f:
            return
        L20:
            goto L1c
        L24:
            int r3 = r2 + r1
            goto L17
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void JldTWqRoQenoRcWq(java.util.HashSet r0, short r1, byte r2, char r3, java.lang.string r4) {
            goto L18
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            r0 = 42
            goto L1f
        L10:
            goto L1b
        L13:
            double r0 = (double) r3
            goto L25
        L18:
            goto L26
        L1b:
            goto La
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L25:
            return
        L26:
            goto L10
        L2a:
            int r3 = r2 + r1
            goto L13
    }

    public static void KCPWnqHTEwKmksrl(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, java.lang.string r1, java.lang.string r2) {
            goto Lb
        L4:
            r0.updateStoredUserAgent(r1, r2)
            goto L12
        Lb:
            goto L13
        Le:
            goto L4
        L12:
            return
        L13:
            goto L17
        L17:
            goto Le
    }

    public static void KCPWnqHTEwKmksrl(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, java.lang.string r1, java.lang.string r2, byte r3, bool r4, short r5, float r6) {
            goto L29
        L4:
            goto L2c
        L7:
            return
        L8:
            goto L4
        Lc:
            int r2 = r0 * r1
            goto L12
        L12:
            int r3 = r2 + r1
            goto L1e
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
        L1e:
            double r0 = (double) r3
            goto L7
        L23:
            r0 = 42
            goto L18
        L29:
            goto L8
        L2c:
            goto L23
    }

    public static void KCPWnqHTEwKmksrl(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, java.lang.string r1, java.lang.string r2, float r3, bool r4, byte r5, short r6) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L18
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            int r2 = r0 * r1
            goto L9
        L15:
            goto L26
        L18:
            return
        L19:
            goto L15
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L23:
            goto L19
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L1d
    }

    public static void KCPWnqHTEwKmksrl(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, java.lang.string r1, java.lang.string r2, bool r3, float r4, short r5, byte r6) {
            goto L29
        L4:
            r0 = 42
            goto L1e
        La:
            return
        Lb:
            goto L1b
        Lf:
            int r2 = r0 * r1
            goto L15
        L15:
            int r3 = r2 + r1
            goto L24
        L1b:
            goto L2c
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L24:
            double r0 = (double) r3
            goto La
        L29:
            goto Lb
        L2c:
            goto L4
    }

    public static java.lang.object KbfDDdMxJyGyspPu(java.util.Dictionary.Entry r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            java.lang.object r0 = r1.getValue()
            goto Lb
        L18:
            goto L7
    }

    public static void KbfDDdMxJyGyspPu(java.util.Dictionary.Entry r0, float r1, char r2, short r3, bool r4) {
            goto L9
        L4:
            return
        L5:
            goto L21
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0 = 42
            goto L1b
        L16:
            double r0 = (double) r3
            goto L4
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L21:
            goto Lc
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L16
    }

    public static void KbfDDdMxJyGyspPu(java.util.Dictionary.Entry r0, short r1, float r2, char r3, bool r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            goto L21
        Ld:
            goto L1a
        L11:
            int r2 = r0 * r1
            goto L4
        L17:
            goto Ld
        L1a:
            r0 = 42
            goto L25
        L20:
            return
        L21:
            goto L17
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static void KbfDDdMxJyGyspPu(java.util.Dictionary.Entry r0, short r1, bool r2, char r3, float r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            goto L20
        Ld:
            goto L24
        L11:
            double r0 = (double) r3
            goto L1f
        L16:
            goto Ld
        L19:
            int r3 = r2 + r1
            goto L11
        L1f:
            return
        L20:
            goto L16
        L24:
            r0 = 42
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L19
    }

    public static android.content.Dictionary<string, object>.Editor MOZgPVbFvrKnoiew(android.content.Dictionary<string, object>.Editor r1, java.lang.string r2, long r3) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            android.content.Dictionary<string, object>$Editor r0 = r1.putlong(r2, r3)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void MOZgPVbFvrKnoiew(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, long r2, char r4, short r5, bool r6, int r7) {
            goto Ld
        L4:
            r0 = 42
            goto L14
        La:
            goto L10
        Ld:
            goto L2c
        L10:
            goto L4
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L1a:
            int r2 = r0 * r1
            goto L25
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            int r3 = r2 + r1
            goto L20
        L2b:
            return
        L2c:
            goto La
    }

    public static void MOZgPVbFvrKnoiew(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, long r2, char r4, bool r5, short r6, int r7) {
            goto L11
        L4:
            goto L14
        L7:
            double r0 = (double) r3
            goto Lc
        Lc:
            return
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            goto L24
        L18:
            int r2 = r0 * r1
            goto L1e
        L1e:
            int r3 = r2 + r1
            goto L7
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
    }

    public static void MOZgPVbFvrKnoiew(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, long r2, int r4, char r5, bool r6, short r7) {
            goto L16
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        La:
            int r3 = r2 + r1
            goto L23
        L10:
            r0 = 42
            goto L4
        L16:
            goto L29
        L19:
            goto L10
        L1d:
            int r2 = r0 * r1
            goto La
        L23:
            double r0 = (double) r3
            goto L28
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L19
    }

    public static void MhxyrFySyoxZhtKD(android.content.Dictionary<string, object>.Editor r0, byte r1, char r2, int r3, float r4) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto L1e
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            goto L26
        L13:
            return
        L14:
            goto L10
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L1e:
            double r0 = (double) r3
            goto L13
        L23:
            goto L14
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L18
    }

    public static void MhxyrFySyoxZhtKD(android.content.Dictionary<string, object>.Editor r0, float r1, int r2, byte r3, char r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            goto L12
        Ld:
            goto L1e
        L11:
            return
        L12:
            goto L16
        L16:
            goto Ld
        L19:
            double r0 = (double) r3
            goto L11
        L1e:
            r0 = 42
            goto L2a
        L24:
            int r3 = r2 + r1
            goto L19
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void MhxyrFySyoxZhtKD(android.content.Dictionary<string, object>.Editor r0, int r1, char r2, float r3, byte r4) {
            goto L4
        L4:
            goto L12
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L22
        L11:
            return
        L12:
            goto L28
        L16:
            int r3 = r2 + r1
            goto L2b
        L1c:
            int r2 = r0 * r1
            goto L16
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L28:
            goto L7
        L2b:
            double r0 = (double) r3
            goto L11
    }

    public static bool MhxyrFySyoxZhtKD(android.content.Dictionary<string, object>.Editor r1) {
            goto L14
        L4:
            bool r0 = r1.commit()
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static void NBAsHkJfRnxBtUVP(java.util.HashSet r0, java.lang.object r1, byte r2, bool r3, float r4, short r5) {
            goto L15
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            r0 = 42
            goto L1f
        L15:
            goto L2c
        L18:
            goto Lf
        L1c:
            goto L18
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L25:
            int r2 = r0 * r1
            goto L9
        L2b:
            return
        L2c:
            goto L1c
    }

    public static void NBAsHkJfRnxBtUVP(java.util.HashSet r0, java.lang.object r1, short r2, bool r3, byte r4, float r5) {
            goto L1d
        L4:
            return
        L5:
            goto Lf
        L9:
            int r2 = r0 * r1
            goto L24
        Lf:
            goto L20
        L12:
            double r0 = (double) r3
            goto L4
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1d:
            goto L5
        L20:
            goto L2a
        L24:
            int r3 = r2 + r1
            goto L12
        L2a:
            r0 = 42
            goto L17
    }

    public static void NBAsHkJfRnxBtUVP(java.util.HashSet r0, java.lang.object r1, bool r2, short r3, byte r4, float r5) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        La:
            return
        Lb:
            goto L1b
        Lf:
            r0 = 42
            goto L4
        L15:
            int r3 = r2 + r1
            goto L2b
        L1b:
            goto L27
        L1e:
            int r2 = r0 * r1
            goto L15
        L24:
            goto Lb
        L27:
            goto Lf
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static bool NBAsHkJfRnxBtUVP(java.util.HashSet r1, java.lang.object r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            bool r0 = r1.Remove(r2)
            goto L4
    }

    public static java.time.LocalDateTimeTime NKGpSNBJHnwOTCet(java.time.OffsetDateTimeTime r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.time.LocalDateTimeTime r0 = r1.toLocalDateTimeTime()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void NKGpSNBJHnwOTCet(java.time.OffsetDateTimeTime r0, int r1, java.lang.string r2, short r3, float r4) {
            goto L9
        L4:
            return
        L5:
            goto L27
        L9:
            goto L5
        Lc:
            goto L15
        L10:
            double r0 = (double) r3
            goto L4
        L15:
            r0 = 42
            goto L2a
        L1b:
            int r2 = r0 * r1
            goto L21
        L21:
            int r3 = r2 + r1
            goto L10
        L27:
            goto Lc
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
    }

    public static void NKGpSNBJHnwOTCet(java.time.OffsetDateTimeTime r0, java.lang.string r1, int r2, short r3, float r4) {
            goto Ld
        L4:
            goto L10
        L7:
            int r2 = r0 * r1
            goto L2a
        Ld:
            goto L26
        L10:
            goto L1f
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            r0 = 42
            goto L14
        L25:
            return
        L26:
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L1a
    }

    public static void NKGpSNBJHnwOTCet(java.time.OffsetDateTimeTime r0, short r1, float r2, int r3, java.lang.string r4) {
            goto L1a
        L4:
            return
        L5:
            goto L21
        L9:
            r0 = 42
            goto L2a
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            int r2 = r0 * r1
            goto L24
        L1a:
            goto L5
        L1d:
            goto L9
        L21:
            goto L1d
        L24:
            int r3 = r2 + r1
            goto Lf
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
    }

    public static void NLgNEfppBQTzogPL(java.util.HashSet r0, java.lang.object r1, byte r2, char r3, int r4, short r5) {
            goto L15
        L4:
            double r0 = (double) r3
            goto L22
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        Lf:
            int r2 = r0 * r1
            goto L27
        L15:
            goto L23
        L18:
            goto L1c
        L1c:
            r0 = 42
            goto L9
        L22:
            return
        L23:
            goto L2d
        L27:
            int r3 = r2 + r1
            goto L4
        L2d:
            goto L18
    }

    public static void NLgNEfppBQTzogPL(java.util.HashSet r0, java.lang.object r1, int r2, short r3, char r4, byte r5) {
            goto L7
        L4:
            goto La
        L7:
            goto L1b
        La:
            goto Le
        Le:
            r0 = 42
            goto L2a
        L14:
            int r3 = r2 + r1
            goto L1f
        L1a:
            return
        L1b:
            goto L4
        L1f:
            double r0 = (double) r3
            goto L1a
        L24:
            int r2 = r0 * r1
            goto L14
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void NLgNEfppBQTzogPL(java.util.HashSet r0, java.lang.object r1, short r2, char r3, int r4, byte r5) {
            goto L14
        L4:
            return
        L5:
            goto L21
        L9:
            r0 = 42
            goto L2a
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            goto L5
        L17:
            goto L9
        L1b:
            int r3 = r2 + r1
            goto Lf
        L21:
            goto L17
        L24:
            int r2 = r0 * r1
            goto L1b
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static bool NLgNEfppBQTzogPL(java.util.HashSet r1, java.lang.object r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            bool r0 = r1.Remove(r2)
            goto L4
        L18:
            goto Lc
    }

    public static long NzLUQthBykUIEDtf() {
            goto L23
        L4:
            int r0 = r0 % r1
            goto L1a
        La:
            goto L26
        Ld:
            r0 = 3
            goto L40
        L14:
            int r0 = r0 + r1
            goto L4
        L1a:
            if (r0 <= 0) goto L1f
            goto L35
        L1f:
            goto L32
        L23:
            goto L3c
        L26:
            goto Ld
        L2a:
            long r0 = java.lang.System.currentTimeMillis()
            goto L47
        L32:
            goto L48
        L35:
            goto L2a
        L39:
            goto L35
        L3c:
            goto La
        L40:
            r1 = 18
            goto L14
        L47:
            return r0
        L48:
            goto L39
    }

    public static void NzLUQthBykUIEDtf(int r0, java.lang.string r1, char r2, short r3) {
            goto L4
        L4:
            goto L23
        L7:
            goto L11
        Lb:
            int r2 = r0 * r1
            goto L17
        L11:
            r0 = 42
            goto L27
        L17:
            int r3 = r2 + r1
            goto L1d
        L1d:
            double r0 = (double) r3
            goto L22
        L22:
            return
        L23:
            goto L2d
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L2d:
            goto L7
    }

    public static void NzLUQthBykUIEDtf(int r0, short r1, char r2, java.lang.string r3) {
            goto L10
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L10:
            goto L21
        L13:
            goto L4
        L17:
            int r3 = r2 + r1
            goto L25
        L1d:
            goto L13
        L20:
            return
        L21:
            goto L1d
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            int r2 = r0 * r1
            goto L17
    }

    public static void NzLUQthBykUIEDtf(java.lang.string r0, char r1, int r2, short r3) {
            goto L29
        L4:
            r0 = 42
            goto L16
        La:
            int r2 = r0 * r1
            goto L10
        L10:
            int r3 = r2 + r1
            goto L1c
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L1c:
            double r0 = (double) r3
            goto L21
        L21:
            return
        L22:
            goto L26
        L26:
            goto L2c
        L29:
            goto L22
        L2c:
            goto L4
    }

    public static java.lang.string OCAdSIKNxPllrqQu(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r1, java.lang.string r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            java.lang.string r0 = r1.getStoredUserAgentstring(r2)
            goto L4
        L18:
            goto Lc
    }

    public static void OCAdSIKNxPllrqQu(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, java.lang.string r1, byte r2, java.lang.string r3, bool r4, float r5) {
            goto L29
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L10:
            double r0 = (double) r3
            goto L21
        L15:
            int r3 = r2 + r1
            goto L10
        L1b:
            int r2 = r0 * r1
            goto L15
        L21:
            return
        L22:
            goto L26
        L26:
            goto L2c
        L29:
            goto L22
        L2c:
            goto L4
    }

    public static void OCAdSIKNxPllrqQu(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, java.lang.string r1, byte r2, bool r3, float r4, java.lang.string r5) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L20
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L14:
            int r3 = r2 + r1
            goto L4
        L1a:
            int r2 = r0 * r1
            goto L14
        L20:
            goto L26
        L23:
            goto La
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto Le
    }

    public static void OCAdSIKNxPllrqQu(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, java.lang.string r1, float r2, bool r3, java.lang.string r4, byte r5) {
            goto L4
        L4:
            goto L12
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L21
        L11:
            return
        L12:
            goto L2d
        L16:
            double r0 = (double) r3
            goto L11
        L1b:
            int r3 = r2 + r1
            goto L16
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L27:
            int r2 = r0 * r1
            goto L1b
        L2d:
            goto L7
    }

    public static android.content.Dictionary<string, object>.Editor OuwKuncANjHFqEXT(android.content.Dictionary<string, object>.Editor r1, java.lang.string r2) {
            goto Lf
        L4:
            goto L12
        L7:
            android.content.Dictionary<string, object>$Editor r0 = r1.Remove(r2)
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static void OuwKuncANjHFqEXT(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, byte r2, short r3, bool r4, float r5) {
            goto L29
        L4:
            r0 = 42
            goto L23
        La:
            double r0 = (double) r3
            goto L15
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            return
        L16:
            goto L1a
        L1a:
            goto L2c
        L1d:
            int r2 = r0 * r1
            goto Lf
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L29:
            goto L16
        L2c:
            goto L4
    }

    public static void OuwKuncANjHFqEXT(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, float r2, byte r3, short r4, bool r5) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L24
        L13:
            double r0 = (double) r3
            goto L7
        L18:
            int r2 = r0 * r1
            goto L2a
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L24:
            r0 = 42
            goto L1e
        L2a:
            int r3 = r2 + r1
            goto L13
    }

    public static void OuwKuncANjHFqEXT(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, float r2, bool r3, byte r4, short r5) {
            goto L12
        L4:
            goto L15
        L7:
            int r2 = r0 * r1
            goto L19
        Ld:
            return
        Le:
            goto L4
        L12:
            goto Le
        L15:
            goto L1f
        L19:
            int r3 = r2 + r1
            goto L2b
        L1f:
            r0 = 42
            goto L25
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L2b:
            double r0 = (double) r3
            goto Ld
    }

    public static java.util.IEnumerator PMRRUqwWbYgLECFj(java.util.HashSet r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void PMRRUqwWbYgLECFj(java.util.HashSet r0, byte r1, char r2, java.lang.string r3, int r4) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L19
        Lb:
            return
        Lc:
            goto L16
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L16:
            goto L7
        L19:
            r0 = 42
            goto L10
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto Lb
        L2a:
            int r2 = r0 * r1
            goto L1f
    }

    public static void PMRRUqwWbYgLECFj(java.util.HashSet r0, int r1, char r2, java.lang.string r3, byte r4) {
            goto L10
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        La:
            r0 = 42
            goto L4
        L10:
            goto L18
        L13:
            goto La
        L17:
            return
        L18:
            goto L28
        L1c:
            int r2 = r0 * r1
            goto L22
        L22:
            int r3 = r2 + r1
            goto L2b
        L28:
            goto L13
        L2b:
            double r0 = (double) r3
            goto L17
    }

    public static void PMRRUqwWbYgLECFj(java.util.HashSet r0, java.lang.string r1, byte r2, int r3, char r4) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        La:
            goto L27
        Ld:
            int r3 = r2 + r1
            goto L2b
        L13:
            return
        L14:
            goto La
        L18:
            int r2 = r0 * r1
            goto Ld
        L1e:
            r0 = 42
            goto L4
        L24:
            goto L14
        L27:
            goto L1e
        L2b:
            double r0 = (double) r3
            goto L13
    }

    public static java.lang.string PtQxTwSUPsrQXMTx(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r1, long r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.getFormattedDateTime(r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void PtQxTwSUPsrQXMTx(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, long r1, char r3, java.lang.string r4, short r5, float r6) {
            goto L24
        L4:
            return
        L5:
            goto L21
        L9:
            r0 = 42
            goto L1b
        Lf:
            int r3 = r2 + r1
            goto L2b
        L15:
            int r2 = r0 * r1
            goto Lf
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L21:
            goto L27
        L24:
            goto L5
        L27:
            goto L9
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void PtQxTwSUPsrQXMTx(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, long r1, float r3, char r4, java.lang.string r5, short r6) {
            goto La
        L4:
            r0 = 42
            goto L24
        La:
            goto L1a
        Ld:
            goto L4
        L11:
            double r0 = (double) r3
            goto L19
        L16:
            goto Ld
        L19:
            return
        L1a:
            goto L16
        L1e:
            int r3 = r2 + r1
            goto L11
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L1e
    }

    public static void PtQxTwSUPsrQXMTx(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, long r1, short r3, java.lang.string r4, float r5, char r6) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L11
        La:
            goto L18
        Ld:
            goto L2a
        L11:
            int r3 = r2 + r1
            goto L25
        L17:
            return
        L18:
            goto L1c
        L1c:
            goto Ld
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L25:
            double r0 = (double) r3
            goto L17
        L2a:
            r0 = 42
            goto L1f
    }

    public static android.content.Dictionary<string, object>.Editor QJaJEXsGAHIMGtTz(android.content.Dictionary<string, object>.Editor r1, java.lang.string r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            android.content.Dictionary<string, object>$Editor r0 = r1.Remove(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void QJaJEXsGAHIMGtTz(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, int r2, char r3, bool r4, java.lang.string r5) {
            goto L1b
        L4:
            return
        L5:
            goto L22
        L9:
            r0 = 42
            goto L2a
        Lf:
            int r2 = r0 * r1
            goto L15
        L15:
            int r3 = r2 + r1
            goto L25
        L1b:
            goto L5
        L1e:
            goto L9
        L22:
            goto L1e
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
    }

    public static void QJaJEXsGAHIMGtTz(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, java.lang.string r2, int r3, bool r4, char r5) {
            goto L29
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L10:
            int r2 = r0 * r1
            goto L1e
        L16:
            double r0 = (double) r3
            goto L24
        L1b:
            goto L2c
        L1e:
            int r3 = r2 + r1
            goto L16
        L24:
            return
        L25:
            goto L1b
        L29:
            goto L25
        L2c:
            goto L4
    }

    public static void QJaJEXsGAHIMGtTz(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, java.lang.string r2, bool r3, int r4, char r5) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        La:
            int r3 = r2 + r1
            goto L1b
        L10:
            int r2 = r0 * r1
            goto La
        L16:
            return
        L17:
            goto L26
        L1b:
            double r0 = (double) r3
            goto L16
        L20:
            r0 = 42
            goto L4
        L26:
            goto L2c
        L29:
            goto L17
        L2c:
            goto L20
    }

    public static void QZhwVoAZttdtjNJb(java.util.IEnumerator r0, byte r1, java.lang.string r2, float r3, int r4) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto L18
        La:
            goto L26
        Ld:
            return
        Le:
            goto La
        L12:
            r0 = 42
            goto L2a
        L18:
            int r3 = r2 + r1
            goto L1e
        L1e:
            double r0 = (double) r3
            goto Ld
        L23:
            goto Le
        L26:
            goto L12
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void QZhwVoAZttdtjNJb(java.util.IEnumerator r0, int r1, float r2, java.lang.string r3, byte r4) {
            goto L14
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r2 = r0 * r1
            goto L1b
        Lf:
            return
        L10:
            goto L21
        L14:
            goto L10
        L17:
            goto L2a
        L1b:
            int r3 = r2 + r1
            goto L4
        L21:
            goto L17
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L2a:
            r0 = 42
            goto L24
    }

    public static void QZhwVoAZttdtjNJb(java.util.IEnumerator r0, java.lang.string r1, int r2, float r3, byte r4) {
            goto L18
        L4:
            return
        L5:
            goto L15
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        Lf:
            int r2 = r0 * r1
            goto L2a
        L15:
            goto L1b
        L18:
            goto L5
        L1b:
            goto L1f
        L1f:
            r0 = 42
            goto L9
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static bool QZhwVoAZttdtjNJb(java.util.IEnumerator r1) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            bool r0 = r1.MoveNext()
            goto L4
    }

    public static java.lang.object QaNVlyjFrQnTYhJD(java.util.Dictionary.Entry r1) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            java.lang.object r0 = r1.getKey()
            goto L4
    }

    public static void QaNVlyjFrQnTYhJD(java.util.Dictionary.Entry r0, short r1, byte r2, bool r3, java.lang.string r4) {
            goto L26
        L4:
            return
        L5:
            goto L2d
        L9:
            r0 = 42
            goto L20
        Lf:
            int r2 = r0 * r1
            goto L15
        L15:
            int r3 = r2 + r1
            goto L1b
        L1b:
            double r0 = (double) r3
            goto L4
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L26:
            goto L5
        L29:
            goto L9
        L2d:
            goto L29
    }

    public static void QaNVlyjFrQnTYhJD(java.util.Dictionary.Entry r0, short r1, java.lang.string r2, bool r3, byte r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L1a
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L11:
            int r2 = r0 * r1
            goto L25
        L17:
            goto L7
        L1a:
            r0 = 42
            goto Lb
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            int r3 = r2 + r1
            goto L20
        L2b:
            return
        L2c:
            goto L17
    }

    public static void QaNVlyjFrQnTYhJD(java.util.Dictionary.Entry r0, bool r1, java.lang.string r2, short r3, byte r4) {
            goto Ld
        L4:
            goto L10
        L7:
            int r2 = r0 * r1
            goto L14
        Ld:
            goto L1b
        L10:
            goto L1f
        L14:
            int r3 = r2 + r1
            goto L2b
        L1a:
            return
        L1b:
            goto L4
        L1f:
            r0 = 42
            goto L25
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L2b:
            double r0 = (double) r3
            goto L1a
    }

    public static java.lang.object QebrWCZIPcGpdTXm(java.util.IEnumerator r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            java.lang.object r0 = r1.Current
            goto Lb
        L18:
            goto L7
    }

    public static void QebrWCZIPcGpdTXm(java.util.IEnumerator r0, byte r1, short r2, java.lang.string r3, int r4) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        La:
            r0 = 42
            goto L4
        L10:
            double r0 = (double) r3
            goto L21
        L15:
            int r2 = r0 * r1
            goto L1b
        L1b:
            int r3 = r2 + r1
            goto L10
        L21:
            return
        L22:
            goto L26
        L26:
            goto L2c
        L29:
            goto L22
        L2c:
            goto La
    }

    public static void QebrWCZIPcGpdTXm(java.util.IEnumerator r0, java.lang.string r1, int r2, short r3, byte r4) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L28
        L9:
            goto L29
        Lc:
            goto L10
        L10:
            r0 = 42
            goto L22
        L16:
            int r3 = r2 + r1
            goto L4
        L1c:
            int r2 = r0 * r1
            goto L16
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto Lc
    }

    public static void QebrWCZIPcGpdTXm(java.util.IEnumerator r0, short r1, int r2, java.lang.string r3, byte r4) {
            goto La
        L4:
            r0 = 42
            goto L11
        La:
            goto L21
        Ld:
            goto L4
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L17:
            goto Ld
        L1a:
            int r2 = r0 * r1
            goto L25
        L20:
            return
        L21:
            goto L17
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static void QkIjKOwJOzqgvtLG(java.util.IEnumerator r0, float r1, short r2, bool r3, java.lang.string r4) {
            goto L20
        L4:
            return
        L5:
            goto L27
        L9:
            r0 = 42
            goto L2a
        Lf:
            int r2 = r0 * r1
            goto L15
        L15:
            int r3 = r2 + r1
            goto L1b
        L1b:
            double r0 = (double) r3
            goto L4
        L20:
            goto L5
        L23:
            goto L9
        L27:
            goto L23
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
    }

    public static void QkIjKOwJOzqgvtLG(java.util.IEnumerator r0, java.lang.string r1, float r2, bool r3, short r4) {
            goto L4
        L4:
            goto L1b
        L7:
            goto L2a
        Lb:
            goto L7
        Le:
            int r2 = r0 * r1
            goto L14
        L14:
            int r3 = r2 + r1
            goto L25
        L1a:
            return
        L1b:
            goto Lb
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
        L25:
            double r0 = (double) r3
            goto L1a
        L2a:
            r0 = 42
            goto L1f
    }

    public static void QkIjKOwJOzqgvtLG(java.util.IEnumerator r0, bool r1, short r2, java.lang.string r3, float r4) {
            goto L21
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L10:
            int r2 = r0 * r1
            goto L1b
        L16:
            double r0 = (double) r3
            goto L2b
        L1b:
            int r3 = r2 + r1
            goto L16
        L21:
            goto L2c
        L24:
            goto L4
        L28:
            goto L24
        L2b:
            return
        L2c:
            goto L28
    }

    public static bool QkIjKOwJOzqgvtLG(java.util.IEnumerator r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            bool r0 = r1.MoveNext()
            goto Lb
    }

    public static java.lang.object QrwEeJXzqqiKSidv(java.util.IEnumerator r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            java.lang.object r0 = r1.Current
            goto L4
    }

    public static void QrwEeJXzqqiKSidv(java.util.IEnumerator r0, float r1, java.lang.string r2, byte r3, bool r4) {
            goto L10
        L4:
            r0 = 42
            goto L17
        La:
            int r3 = r2 + r1
            goto L1d
        L10:
            goto L26
        L13:
            goto L4
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1d:
            double r0 = (double) r3
            goto L25
        L22:
            goto L13
        L25:
            return
        L26:
            goto L22
        L2a:
            int r2 = r0 * r1
            goto La
    }

    public static void QrwEeJXzqqiKSidv(java.util.IEnumerator r0, float r1, bool r2, byte r3, java.lang.string r4) {
            goto L13
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        La:
            int r3 = r2 + r1
            goto L1a
        L10:
            goto L16
        L13:
            goto L26
        L16:
            goto L2a
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            int r2 = r0 * r1
            goto La
        L25:
            return
        L26:
            goto L10
        L2a:
            r0 = 42
            goto L4
    }

    public static void QrwEeJXzqqiKSidv(java.util.IEnumerator r0, java.lang.string r1, bool r2, float r3, byte r4) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto Le
        Le:
            goto L2c
        L11:
            int r2 = r0 * r1
            goto L17
        L17:
            int r3 = r2 + r1
            goto L4
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L23:
            r0 = 42
            goto L1d
        L29:
            goto La
        L2c:
            goto L23
    }

    private void RemoveStoredDateTime(java.lang.string r5) {
            r4 = this;
            goto L33
        L4:
            throw r5
        L5:
            goto L12
        L9:
            if (r0 == 0) goto Le
            goto L4b
        Le:
            goto L19
        L12:
            goto L9c
        L15:
            goto L24
        L19:
            monitor-exit(r4)
            goto L4a
        L1e:
            int r0 = r0 + r1
            goto L83
        L24:
            goto L36
        L27:
            return
        L28:
            r5 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> L28
            goto L4
        L2e:
            monitor-exit(r4)
            goto L27
        L33:
            goto L15
        L36:
            goto L92
        L3a:
            monitor-enter(r4)
            java.lang.string r0 = PpfvGPJdUrsVufNb(r4, r5)     // Catch: java.lang.Exception -> L28
            goto L9
        L43:
            r1 = 25
            goto L1e
        L4a:
            return
        L4b:
            java.util.HashHashSet r1 = new java.util.HashHashSet     // Catch: java.lang.Exception -> L28
            android.content.Dictionary<string, object> r2 = r4.firebaseDictionary<string, object>     // Catch: java.lang.Exception -> L28
            java.util.HashHashSet r3 = new java.util.HashHashSet     // Catch: java.lang.Exception -> L28
            r3.<init>()     // Catch: java.lang.Exception -> L28
            java.util.HashSet r2 = RFxzocXvpzhFYdnL(r2, r0, r3)     // Catch: java.lang.Exception -> L28
            r1.<init>(r2)     // Catch: java.lang.Exception -> L28
            nLgNEfppBQTzogPL(r1, r5)     // Catch: java.lang.Exception -> L28
            bool r5 = IBqVRUpsunYPfQPd(r1)     // Catch: java.lang.Exception -> L28
            if (r5 == 0) goto L72
            android.content.Dictionary<string, object> r5 = r4.firebaseDictionary<string, object>     // Catch: java.lang.Exception -> L28
            android.content.Dictionary<string, object>$Editor r5 = hZTOGpfmCShrXeqr(r5)     // Catch: java.lang.Exception -> L28
            android.content.Dictionary<string, object>$Editor r5 = AjSJGXSIXEsQkBjE(r5, r0)     // Catch: java.lang.Exception -> L28
            foKjsYMgCrdmmBDR(r5)     // Catch: java.lang.Exception -> L28
            goto L7f
        L72:
            android.content.Dictionary<string, object> r5 = r4.firebaseDictionary<string, object>     // Catch: java.lang.Exception -> L28
            android.content.Dictionary<string, object>$Editor r5 = SJBdQBceqpSpqavv(r5)     // Catch: java.lang.Exception -> L28
            android.content.Dictionary<string, object>$Editor r5 = OtMLIECSolFYIyBf(r5, r0, r1)     // Catch: java.lang.Exception -> L28
            fYOkNCVOZAoXOBNB(r5)     // Catch: java.lang.Exception -> L28
        L7f:
            goto L2e
        L83:
            int r0 = r0 % r1
            goto L89
        L89:
            if (r0 <= 0) goto L8e
            goto L9c
        L8e:
            goto L99
        L92:
            r0 = 9
            goto L43
        L99:
            goto L5
        L9c:
            goto L3a
    }

    public static android.content.Dictionary<string, object>.Editor RgRDvsYUvwpxUPDt(android.content.Dictionary<string, object> r1) {
            goto Lc
        L4:
            android.content.Dictionary<string, object>$Editor r0 = r1.edit()
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static void RgRDvsYUvwpxUPDt(android.content.Dictionary<string, object> r0, int r1, char r2, short r3, bool r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L1d
        La:
            goto L2c
        Ld:
            r0 = 42
            goto L23
        L13:
            double r0 = (double) r3
            goto L18
        L18:
            return
        L19:
            goto La
        L1d:
            int r3 = r2 + r1
            goto L13
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L29:
            goto L19
        L2c:
            goto Ld
    }

    public static void RgRDvsYUvwpxUPDt(android.content.Dictionary<string, object> r0, int r1, bool r2, char r3, short r4) {
            goto L1b
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            return
        Lb:
            goto L27
        Lf:
            r0 = 42
            goto L15
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1b:
            goto Lb
        L1e:
            goto Lf
        L22:
            double r0 = (double) r3
            goto La
        L27:
            goto L1e
        L2a:
            int r3 = r2 + r1
            goto L22
    }

    public static void RgRDvsYUvwpxUPDt(android.content.Dictionary<string, object> r0, short r1, int r2, char r3, bool r4) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        La:
            r0 = 42
            goto L4
        L10:
            int r3 = r2 + r1
            goto L16
        L16:
            double r0 = (double) r3
            goto L21
        L1b:
            int r2 = r0 * r1
            goto L10
        L21:
            return
        L22:
            goto L26
        L26:
            goto L2c
        L29:
            goto L22
        L2c:
            goto La
    }

    public static void SDZfAzVCRYmTLnFE(android.content.Dictionary<string, object>.Editor r0, byte r1, int r2, float r3, char r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L15
        La:
            return
        Lb:
            goto L26
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            int r3 = r2 + r1
            goto L1b
        L1b:
            double r0 = (double) r3
            goto La
        L20:
            r0 = 42
            goto Lf
        L26:
            goto L2c
        L29:
            goto Lb
        L2c:
            goto L20
    }

    public static void SDZfAzVCRYmTLnFE(android.content.Dictionary<string, object>.Editor r0, char r1, float r2, byte r3, int r4) {
            goto L1d
        L4:
            return
        L5:
            goto L14
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            int r2 = r0 * r1
            goto L24
        L14:
            goto L20
        L17:
            r0 = 42
            goto L2a
        L1d:
            goto L5
        L20:
            goto L17
        L24:
            int r3 = r2 + r1
            goto L9
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
    }

    public static void SDZfAzVCRYmTLnFE(android.content.Dictionary<string, object>.Editor r0, char r1, int r2, byte r3, float r4) {
            goto L12
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L15
        L12:
            goto Lb
        L15:
            goto L19
        L19:
            r0 = 42
            goto L4
        L1f:
            int r3 = r2 + r1
            goto L2b
        L25:
            int r2 = r0 * r1
            goto L1f
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static bool SDZfAzVCRYmTLnFE(android.content.Dictionary<string, object>.Editor r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            bool r0 = r1.commit()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static android.content.Dictionary<string, object> SlIjCJELTMLWfkbv(android.content.object r1, java.lang.string r2, int r3) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            android.content.Dictionary<string, object> r0 = r1.getDictionary<string, object>(r2, r3)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void SlIjCJELTMLWfkbv(android.content.object r0, java.lang.string r1, int r2, byte r3, char r4, bool r5, int r6) {
            goto L10
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L1a
        L10:
            goto L26
        L13:
            goto L2a
        L17:
            goto L13
        L1a:
            int r3 = r2 + r1
            goto L20
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L17
        L2a:
            r0 = 42
            goto L4
    }

    public static void SlIjCJELTMLWfkbv(android.content.object r0, java.lang.string r1, int r2, byte r3, bool r4, char r5, int r6) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L19
        L10:
            goto L26
        L13:
            r0 = 42
            goto L2a
        L19:
            double r0 = (double) r3
            goto L1e
        L1e:
            return
        L1f:
            goto L10
        L23:
            goto L1f
        L26:
            goto L13
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void SlIjCJELTMLWfkbv(android.content.object r0, java.lang.string r1, int r2, byte r3, bool r4, int r5, char r6) {
            goto Le
        L4:
            return
        L5:
            goto L1b
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            goto L5
        L11:
            goto L24
        L15:
            int r3 = r2 + r1
            goto L9
        L1b:
            goto L11
        L1e:
            int r2 = r0 * r1
            goto L15
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
    }

    public static java.lang.object TZGbyAVhDtnJcrFd(java.util.IEnumerator r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.object r0 = r1.Current
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void TZGbyAVhDtnJcrFd(java.util.IEnumerator r0, int r1, char r2, short r3, bool r4) {
            goto L14
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L27
        L14:
            goto L10
        L17:
            goto L21
        L1b:
            int r2 = r0 * r1
            goto L4
        L21:
            r0 = 42
            goto L2a
        L27:
            goto L17
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
    }

    public static void TZGbyAVhDtnJcrFd(java.util.IEnumerator r0, bool r1, char r2, short r3, int r4) {
            goto La
        L4:
            r0 = 42
            goto L1e
        La:
            goto L1a
        Ld:
            goto L4
        L11:
            double r0 = (double) r3
            goto L19
        L16:
            goto Ld
        L19:
            return
        L1a:
            goto L16
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L11
    }

    public static void TZGbyAVhDtnJcrFd(java.util.IEnumerator r0, bool r1, short r2, char r3, int r4) {
            goto L1a
        L4:
            double r0 = (double) r3
            goto L15
        L9:
            r0 = 42
            goto Lf
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L15:
            return
        L16:
            goto L2d
        L1a:
            goto L16
        L1d:
            goto L9
        L21:
            int r2 = r0 * r1
            goto L27
        L27:
            int r3 = r2 + r1
            goto L4
        L2d:
            goto L1d
    }

    public static android.content.Dictionary<string, object>.Editor TZpCSWnDySPusySY(android.content.Dictionary<string, object> r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            android.content.Dictionary<string, object>$Editor r0 = r1.edit()
            goto L4
        L18:
            goto Lc
    }

    public static void TZpCSWnDySPusySY(android.content.Dictionary<string, object> r0, byte r1, float r2, char r3, java.lang.string r4) {
            goto L29
        L4:
            r0 = 42
            goto L13
        La:
            int r2 = r0 * r1
            goto L19
        L10:
            goto L2c
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L19:
            int r3 = r2 + r1
            goto L1f
        L1f:
            double r0 = (double) r3
            goto L24
        L24:
            return
        L25:
            goto L10
        L29:
            goto L25
        L2c:
            goto L4
    }

    public static void TZpCSWnDySPusySY(android.content.Dictionary<string, object> r0, byte r1, java.lang.string r2, float r3, char r4) {
            goto L4
        L4:
            goto L15
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0 = 42
            goto L1e
        L14:
            return
        L15:
            goto Lb
        L19:
            double r0 = (double) r3
            goto L14
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L24:
            int r3 = r2 + r1
            goto L19
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void TZpCSWnDySPusySY(android.content.Dictionary<string, object> r0, char r1, byte r2, float r3, java.lang.string r4) {
            goto L15
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            return
        L11:
            goto L22
        L15:
            goto L11
        L18:
            goto L25
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L22:
            goto L18
        L25:
            r0 = 42
            goto L1c
        L2b:
            double r0 = (double) r3
            goto L10
    }

    public static java.lang.string TsRJYEzlaICESIoR(android.content.Dictionary<string, object> r1, java.lang.string r2, java.lang.string r3) {
            goto L14
        L4:
            java.lang.string r0 = r1.getstring(r2, r3)
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static void TsRJYEzlaICESIoR(android.content.Dictionary<string, object> r0, java.lang.string r1, java.lang.string r2, float r3, byte r4, int r5, bool r6) {
            goto L24
        L4:
            r0 = 42
            goto L18
        La:
            goto L27
        Ld:
            double r0 = (double) r3
            goto L2b
        L12:
            int r3 = r2 + r1
            goto Ld
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L1e:
            int r2 = r0 * r1
            goto L12
        L24:
            goto L2c
        L27:
            goto L4
        L2b:
            return
        L2c:
            goto La
    }

    public static void TsRJYEzlaICESIoR(android.content.Dictionary<string, object> r0, java.lang.string r1, java.lang.string r2, bool r3, byte r4, int r5, float r6) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L11
        La:
            goto L29
        Ld:
            goto L17
        L11:
            int r3 = r2 + r1
            goto L1d
        L17:
            r0 = 42
            goto L22
        L1d:
            double r0 = (double) r3
            goto L28
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto Ld
    }

    public static void TsRJYEzlaICESIoR(android.content.Dictionary<string, object> r0, java.lang.string r1, java.lang.string r2, bool r3, float r4, int r5, byte r6) {
            goto L10
        L4:
            r0 = 42
            goto L17
        La:
            int r3 = r2 + r1
            goto L28
        L10:
            goto L1e
        L13:
            goto L4
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L1d:
            return
        L1e:
            goto L2d
        L22:
            int r2 = r0 * r1
            goto La
        L28:
            double r0 = (double) r3
            goto L1d
        L2d:
            goto L13
    }

    public static java.lang.object UDtYeKIUfOklfAQf(java.util.Dictionary.Entry r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = r1.getValue()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void UDtYeKIUfOklfAQf(java.util.Dictionary.Entry r0, byte r1, bool r2, float r3, int r4) {
            goto L1e
        L4:
            return
        L5:
            goto L1b
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        Lf:
            int r3 = r2 + r1
            goto L2b
        L15:
            int r2 = r0 * r1
            goto Lf
        L1b:
            goto L21
        L1e:
            goto L5
        L21:
            goto L25
        L25:
            r0 = 42
            goto L9
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void UDtYeKIUfOklfAQf(java.util.Dictionary.Entry r0, int r1, byte r2, bool r3, float r4) {
            goto L23
        L4:
            return
        L5:
            goto L9
        L9:
            goto L26
        Lc:
            r0 = 42
            goto L1d
        L12:
            double r0 = (double) r3
            goto L4
        L17:
            int r2 = r0 * r1
            goto L2a
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L23:
            goto L5
        L26:
            goto Lc
        L2a:
            int r3 = r2 + r1
            goto L12
    }

    public static void UDtYeKIUfOklfAQf(java.util.Dictionary.Entry r0, int r1, bool r2, byte r3, float r4) {
            goto L1e
        L4:
            int r2 = r0 * r1
            goto L25
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            double r0 = (double) r3
            goto L2b
        L15:
            goto L21
        L18:
            r0 = 42
            goto La
        L1e:
            goto L2c
        L21:
            goto L18
        L25:
            int r3 = r2 + r1
            goto L10
        L2b:
            return
        L2c:
            goto L15
    }

    public static android.content.Dictionary<string, object>.Editor USDyeTLfmkIVYitF(android.content.Dictionary<string, object>.Editor r1, java.lang.string r2, java.util.HashSet r3) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            android.content.Dictionary<string, object>$Editor r0 = r1.putstringHashSet(r2, r3)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void USDyeTLfmkIVYitF(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, java.util.HashSet r2, char r3, java.lang.string r4, bool r5, float r6) {
            goto L15
        L4:
            r0 = 42
            goto L21
        La:
            return
        Lb:
            goto L27
        Lf:
            int r3 = r2 + r1
            goto L1c
        L15:
            goto Lb
        L18:
            goto L4
        L1c:
            double r0 = (double) r3
            goto La
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L27:
            goto L18
        L2a:
            int r2 = r0 * r1
            goto Lf
    }

    public static void USDyeTLfmkIVYitF(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, java.util.HashSet r2, char r3, bool r4, float r5, java.lang.string r6) {
            goto L17
        L4:
            return
        L5:
            goto L9
        L9:
            goto L1a
        Lc:
            double r0 = (double) r3
            goto L4
        L11:
            r0 = 42
            goto L24
        L17:
            goto L5
        L1a:
            goto L11
        L1e:
            int r2 = r0 * r1
            goto L2a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L2a:
            int r3 = r2 + r1
            goto Lc
    }

    public static void USDyeTLfmkIVYitF(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, java.util.HashSet r2, java.lang.string r3, char r4, float r5, bool r6) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto L1c
        La:
            r0 = 42
            goto L22
        L10:
            return
        L11:
            goto L2d
        L15:
            goto L11
        L18:
            goto La
        L1c:
            int r3 = r2 + r1
            goto L28
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L28:
            double r0 = (double) r3
            goto L10
        L2d:
            goto L18
    }

    public static void UcSNHoJliaYhCFxe(java.lang.string r0, java.lang.object r1, char r2, bool r3, int r4, float r5) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L1e
        Lb:
            return
        Lc:
            goto L16
        L10:
            int r2 = r0 * r1
            goto L24
        L16:
            goto L7
        L19:
            double r0 = (double) r3
            goto Lb
        L1e:
            r0 = 42
            goto L2a
        L24:
            int r3 = r2 + r1
            goto L19
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
    }

    public static void UcSNHoJliaYhCFxe(java.lang.string r0, java.lang.object r1, int r2, char r3, bool r4, float r5) {
            goto L29
        L4:
            goto L2c
        L7:
            return
        L8:
            goto L4
        Lc:
            r0 = 42
            goto L18
        L12:
            int r3 = r2 + r1
            goto L1e
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L1e:
            double r0 = (double) r3
            goto L7
        L23:
            int r2 = r0 * r1
            goto L12
        L29:
            goto L8
        L2c:
            goto Lc
    }

    public static void UcSNHoJliaYhCFxe(java.lang.string r0, java.lang.object r1, int r2, bool r3, float r4, char r5) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L15
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L15:
            return
        L16:
            goto L1a
        L1a:
            goto L2c
        L1d:
            int r2 = r0 * r1
            goto L4
        L23:
            r0 = 42
            goto Lf
        L29:
            goto L16
        L2c:
            goto L23
    }

    public static bool UcSNHoJliaYhCFxe(java.lang.string r1, java.lang.object r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            bool r0 = r1.Equals(r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    private void UpdateStoredUserAgent(java.lang.string r4, java.lang.string r5) {
            r3 = this;
            goto L5a
        L4:
            goto L5d
        L7:
            throw r4
        L8:
            goto L47
        Lc:
            monitor-enter(r3)
            GkDiTPSfZflzBRtf(r3, r5)     // Catch: java.lang.Exception -> L69
            java.util.HashHashSet r0 = new java.util.HashHashSet     // Catch: java.lang.Exception -> L69
            android.content.Dictionary<string, object> r1 = r3.firebaseDictionary<string, object>     // Catch: java.lang.Exception -> L69
            java.util.HashHashSet r2 = new java.util.HashHashSet     // Catch: java.lang.Exception -> L69
            r2.<init>()     // Catch: java.lang.Exception -> L69
            java.util.HashSet r1 = CKwupIsHCciUHxLu(r1, r4, r2)     // Catch: java.lang.Exception -> L69
            r0.<init>(r1)     // Catch: java.lang.Exception -> L69
            ZIjAeYviMAorgnSG(r0, r5)     // Catch: java.lang.Exception -> L69
            android.content.Dictionary<string, object> r5 = r3.firebaseDictionary<string, object>     // Catch: java.lang.Exception -> L69
            android.content.Dictionary<string, object>$Editor r5 = MlAMAKYVEcAhgZjl(r5)     // Catch: java.lang.Exception -> L69
            android.content.Dictionary<string, object>$Editor r4 = uSDyeTLfmkIVYitF(r5, r4, r0)     // Catch: java.lang.Exception -> L69
            yURQIJOrJIpWMtsV(r4)     // Catch: java.lang.Exception -> L69
            goto L55
        L34:
            int r0 = r0 % r1
            goto L6f
        L3a:
            int r0 = r0 + r1
            goto L34
        L40:
            r0 = 23
            goto L4e
        L47:
            goto L64
        L4a:
            goto L4
        L4e:
            r1 = 12
            goto L3a
        L55:
            monitor-exit(r3)
            goto L68
        L5a:
            goto L4a
        L5d:
            goto L40
        L61:
            goto L8
        L64:
            goto Lc
        L68:
            return
        L69:
            r4 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L69
            goto L7
        L6f:
            if (r0 <= 0) goto L74
            goto L64
        L74:
            goto L61
    }

    public static void VyXcLfRNLbWUUvSX(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, long r1) {
            goto L13
        L4:
            r0.updateGlobalHeartBeat(r1)
            goto Le
        Lb:
            goto L16
        Le:
            return
        Lf:
            goto Lb
        L13:
            goto Lf
        L16:
            goto L4
    }

    public static void VyXcLfRNLbWUUvSX(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, long r1, char r3, byte r4, float r5, bool r6) {
            goto L18
        L4:
            int r3 = r2 + r1
            goto Ld
        La:
            goto L1b
        Ld:
            double r0 = (double) r3
            goto L1f
        L12:
            int r2 = r0 * r1
            goto L4
        L18:
            goto L20
        L1b:
            goto L24
        L1f:
            return
        L20:
            goto La
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
    }

    public static void VyXcLfRNLbWUUvSX(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, long r1, float r3, char r4, bool r5, byte r6) {
            goto Lc
        L4:
            goto Lf
        L7:
            double r0 = (double) r3
            goto L1f
        Lc:
            goto L20
        Lf:
            goto L2a
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L19:
            int r3 = r2 + r1
            goto L7
        L1f:
            return
        L20:
            goto L4
        L24:
            int r2 = r0 * r1
            goto L19
        L2a:
            r0 = 42
            goto L13
    }

    public static void VyXcLfRNLbWUUvSX(com.google.firebase.heartbeatinfo.HeartBeatInfoStorage r0, long r1, bool r3, float r4, byte r5, char r6) {
            goto L1a
        L4:
            return
        L5:
            goto L2d
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        Lf:
            r0 = 42
            goto L9
        L15:
            double r0 = (double) r3
            goto L4
        L1a:
            goto L5
        L1d:
            goto Lf
        L21:
            int r2 = r0 * r1
            goto L27
        L27:
            int r3 = r2 + r1
            goto L15
        L2d:
            goto L1d
    }

    public static android.content.Dictionary<string, object>.Editor WFSgVShIXGabaIMe(android.content.Dictionary<string, object> r1) {
            goto L14
        L4:
            android.content.Dictionary<string, object>$Editor r0 = r1.edit()
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static void WFSgVShIXGabaIMe(android.content.Dictionary<string, object> r0, byte r1, int r2, bool r3, float r4) {
            goto L1b
        L4:
            return
        L5:
            goto L2d
        L9:
            r0 = 42
            goto Lf
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L15:
            int r3 = r2 + r1
            goto L22
        L1b:
            goto L5
        L1e:
            goto L9
        L22:
            double r0 = (double) r3
            goto L4
        L27:
            int r2 = r0 * r1
            goto L15
        L2d:
            goto L1e
    }

    public static void WFSgVShIXGabaIMe(android.content.Dictionary<string, object> r0, byte r1, bool r2, float r3, int r4) {
            goto L1b
        L4:
            r0 = 42
            goto L15
        La:
            int r3 = r2 + r1
            goto L22
        L10:
            return
        L11:
            goto L2d
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L1b:
            goto L11
        L1e:
            goto L4
        L22:
            double r0 = (double) r3
            goto L10
        L27:
            int r2 = r0 * r1
            goto La
        L2d:
            goto L1e
    }

    public static void WFSgVShIXGabaIMe(android.content.Dictionary<string, object> r0, bool r1, int r2, byte r3, float r4) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto L18
        La:
            r0 = 42
            goto L2a
        L10:
            return
        L11:
            goto L15
        L15:
            goto L26
        L18:
            double r0 = (double) r3
            goto L10
        L1d:
            int r2 = r0 * r1
            goto L4
        L23:
            goto L11
        L26:
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
    }

    public static android.content.Dictionary<string, object>.Editor XNEDjCTTqeVXexkm(android.content.Dictionary<string, object>.Editor r1, java.lang.string r2, java.util.HashSet r3) {
            goto Lf
        L4:
            goto L12
        L7:
            android.content.Dictionary<string, object>$Editor r0 = r1.putstringHashSet(r2, r3)
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static void XNEDjCTTqeVXexkm(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, java.util.HashSet r2, byte r3, char r4, bool r5, short r6) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L1f
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        Lf:
            goto L20
        L12:
            goto L24
        L16:
            goto L12
        L19:
            int r3 = r2 + r1
            goto L4
        L1f:
            return
        L20:
            goto L16
        L24:
            r0 = 42
            goto L9
        L2a:
            int r2 = r0 * r1
            goto L19
    }

    public static void XNEDjCTTqeVXexkm(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, java.util.HashSet r2, byte r3, bool r4, char r5, short r6) {
            goto L1d
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        La:
            goto L20
        Ld:
            double r0 = (double) r3
            goto L18
        L12:
            int r2 = r0 * r1
            goto L2a
        L18:
            return
        L19:
            goto La
        L1d:
            goto L19
        L20:
            goto L24
        L24:
            r0 = 42
            goto L4
        L2a:
            int r3 = r2 + r1
            goto Ld
    }

    public static void XNEDjCTTqeVXexkm(android.content.Dictionary<string, object>.Editor r0, java.lang.string r1, java.util.HashSet r2, char r3, byte r4, short r5, bool r6) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        La:
            goto L17
        Ld:
            goto L1b
        L11:
            double r0 = (double) r3
            goto L16
        L16:
            return
        L17:
            goto L2d
        L1b:
            r0 = 42
            goto L4
        L21:
            int r3 = r2 + r1
            goto L11
        L27:
            int r2 = r0 * r1
            goto L21
        L2d:
            goto Ld
    }

    public static java.lang.object YNMJThFzSYnXSzaD(java.util.Dictionary.Entry r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.object r0 = r1.getValue()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void YNMJThFzSYnXSzaD(java.util.Dictionary.Entry r0, byte r1, short r2, int r3, float r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L14
        L11:
            goto L7
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1a:
            double r0 = (double) r3
            goto L2b
        L1f:
            int r2 = r0 * r1
            goto L25
        L25:
            int r3 = r2 + r1
            goto L1a
        L2b:
            return
        L2c:
            goto L11
    }

    public static void YNMJThFzSYnXSzaD(java.util.Dictionary.Entry r0, float r1, byte r2, short r3, int r4) {
            goto L1e
        L4:
            int r3 = r2 + r1
            goto L16
        La:
            r0 = 42
            goto L10
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L16:
            double r0 = (double) r3
            goto L2b
        L1b:
            goto L21
        L1e:
            goto L2c
        L21:
            goto La
        L25:
            int r2 = r0 * r1
            goto L4
        L2b:
            return
        L2c:
            goto L1b
    }

    public static void YNMJThFzSYnXSzaD(java.util.Dictionary.Entry r0, float r1, short r2, int r3, byte r4) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L12
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            goto L2c
        L12:
            return
        L13:
            goto Lf
        L17:
            r0 = 42
            goto L1d
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L23:
            int r2 = r0 * r1
            goto L9
        L29:
            goto L13
        L2c:
            goto L17
    }

    public static void YURQIJOrJIpWMtsV(android.content.Dictionary<string, object>.Editor r0, byte r1, char r2, int r3, bool r4) {
            goto L24
        L4:
            int r2 = r0 * r1
            goto L1b
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            double r0 = (double) r3
            goto L2b
        L15:
            r0 = 42
            goto La
        L1b:
            int r3 = r2 + r1
            goto L10
        L21:
            goto L27
        L24:
            goto L2c
        L27:
            goto L15
        L2b:
            return
        L2c:
            goto L21
    }

    public static void YURQIJOrJIpWMtsV(android.content.Dictionary<string, object>.Editor r0, bool r1, byte r2, char r3, int r4) {
            goto L18
        L4:
            int r2 = r0 * r1
            goto Ld
        La:
            goto L1b
        Ld:
            int r3 = r2 + r1
            goto L1f
        L13:
            return
        L14:
            goto La
        L18:
            goto L14
        L1b:
            goto L2a
        L1f:
            double r0 = (double) r3
            goto L13
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2a:
            r0 = 42
            goto L24
    }

    public static void YURQIJOrJIpWMtsV(android.content.Dictionary<string, object>.Editor r0, bool r1, byte r2, int r3, char r4) {
            goto L10
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L10:
            goto L2c
        L13:
            goto L4
        L17:
            goto L13
        L1a:
            int r3 = r2 + r1
            goto L26
        L20:
            int r2 = r0 * r1
            goto L1a
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L17
    }

    public static bool YURQIJOrJIpWMtsV(android.content.Dictionary<string, object>.Editor r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            bool r0 = r1.commit()
            goto L4
    }

    synchronized void DeleteAllHeartBeats() {
            r7 = this;
            goto Lb4
        L4:
            int r0 = r0 + r1
            goto L94
        La:
            r0 = 14
            goto L16
        L11:
            monitor-exit(r7)
            goto Lad
        L16:
            r1 = 29
            goto L4
        L1d:
            goto L90
        L20:
            goto L24
        L24:
            monitor-enter(r7)
            android.content.Dictionary<string, object> r0 = r7.firebaseDictionary<string, object>     // Catch: java.lang.Exception -> Lae
            android.content.Dictionary<string, object>$Editor r0 = YjkBvKddiXerMxRN(r0)     // Catch: java.lang.Exception -> Lae
            android.content.Dictionary<string, object> r1 = r7.firebaseDictionary<string, object>     // Catch: java.lang.Exception -> Lae
            java.util.Dictionary r1 = FNwbndsEtBbpgrVH(r1)     // Catch: java.lang.Exception -> Lae
            java.util.HashSet r1 = WqEDxJVUlgXDWxHH(r1)     // Catch: java.lang.Exception -> Lae
            java.util.IEnumerator r1 = jldTWqRoQenoRcWq(r1)     // Catch: java.lang.Exception -> Lae
            r2 = 0
        L3a:
            bool r3 = qkIjKOwJOzqgvtLG(r1)     // Catch: java.lang.Exception -> Lae
            if (r3 == 0) goto L7a
            java.lang.object r3 = ADWGMIIBLinzEFxn(r1)     // Catch: java.lang.Exception -> Lae
            java.util.Dictionary$Entry r3 = (java.util.Dictionary.Entry) r3     // Catch: java.lang.Exception -> Lae
            java.lang.object r4 = UeWOGIUHKDJpPLQY(r3)     // Catch: java.lang.Exception -> Lae
            bool r4 = r4 is java.util.HashSet     // Catch: java.lang.Exception -> Lae
            if (r4 == 0) goto L3a
            java.lang.object r4 = kbfDDdMxJyGyspPu(r3)     // Catch: java.lang.Exception -> Lae
            java.util.HashSet r4 = (java.util.HashSet) r4     // Catch: java.lang.Exception -> Lae
            long r5 = nzLUQthBykUIEDtf()     // Catch: java.lang.Exception -> Lae
            java.lang.string r5 = HjElNiwxFENDWSPU(r7, r5)     // Catch: java.lang.Exception -> Lae
            java.lang.object r3 = HNocGsIIbvmWHfik(r3)     // Catch: java.lang.Exception -> Lae
            java.lang.string r3 = (java.lang.string) r3     // Catch: java.lang.Exception -> Lae
            bool r4 = YMukVaJjWcsehQVm(r4, r5)     // Catch: java.lang.Exception -> Lae
            if (r4 == 0) goto L76
            java.util.HashHashSet r4 = new java.util.HashHashSet     // Catch: java.lang.Exception -> Lae
            r4.<init>()     // Catch: java.lang.Exception -> Lae
            dxwaByBBxYmYVLgz(r4, r5)     // Catch: java.lang.Exception -> Lae
            int r2 = r2 + 1
            aeAInuGUMlqVsxxe(r0, r3, r4)     // Catch: java.lang.Exception -> Lae
            goto L3a
        L76:
            ouwKuncANjHFqEXT(r0, r3)     // Catch: java.lang.Exception -> Lae
            goto L3a
        L7a:
            if (r2 != 0) goto L82
            java.lang.string r1 = "fire-count"
            qJaJEXsGAHIMGtTz(r0, r1)     // Catch: java.lang.Exception -> Lae
            goto L88
        L82:
            java.lang.string r1 = "fire-count"
            long r2 = (long) r2     // Catch: java.lang.Exception -> Lae
            mOZgPVbFvrKnoiew(r0, r1, r2)     // Catch: java.lang.Exception -> Lae
        L88:
            CZOJyVJYdFTclgbZ(r0)     // Catch: java.lang.Exception -> Lae
            goto L11
        L8f:
            throw r0
        L90:
            goto L9d
        L94:
            int r0 = r0 % r1
            goto La4
        L9a:
            goto Lb7
        L9d:
            goto L20
        La0:
            goto L9a
        La4:
            if (r0 <= 0) goto La9
            goto L20
        La9:
            goto L1d
        Lad:
            return
        Lae:
            r0 = move-exception
            monitor-exit(r7)     // Catch: java.lang.Exception -> Lae
            goto L8f
        Lb4:
            goto La0
        Lb7:
            goto La
    }

    synchronized java.util.List<com.google.firebase.heartbeatinfo.HeartBeatResult> GetAllHeartBeats() {
            r6 = this;
            goto L2b
        L4:
            int r0 = r0 % r1
            goto L1b
        La:
            goto L2e
        Ld:
            r0 = 22
            goto La6
        L14:
            return r0
        L15:
            r0 = move-exception
            monitor-exit(r6)     // Catch: java.lang.Exception -> L15
            goto L9b
        L1b:
            if (r0 <= 0) goto L20
            goto L35
        L20:
            goto L32
        L24:
            goto L35
        L27:
            goto La
        L2b:
            goto L27
        L2e:
            goto Ld
        L32:
            goto L9c
        L35:
            goto L39
        L39:
            monitor-enter(r6)
            java.util.List r0 = new java.util.List     // Catch: java.lang.Exception -> L15
            r0.<init>()     // Catch: java.lang.Exception -> L15
            android.content.Dictionary<string, object> r1 = r6.firebaseDictionary<string, object>     // Catch: java.lang.Exception -> L15
            java.util.Dictionary r1 = LNIWwjnLDmaICPgm(r1)     // Catch: java.lang.Exception -> L15
            java.util.HashSet r1 = VBVYeLrlEPXHhvoG(r1)     // Catch: java.lang.Exception -> L15
            java.util.IEnumerator r1 = dtDxFdmCejTbxXFv(r1)     // Catch: java.lang.Exception -> L15
        L4d:
            bool r2 = qZhwVoAZttdtjNJb(r1)     // Catch: java.lang.Exception -> L15
            if (r2 == 0) goto L90
            java.lang.object r2 = UcuDneRrOTHssfwN(r1)     // Catch: java.lang.Exception -> L15
            java.util.Dictionary$Entry r2 = (java.util.Dictionary.Entry) r2     // Catch: java.lang.Exception -> L15
            java.lang.object r3 = yNMJThFzSYnXSzaD(r2)     // Catch: java.lang.Exception -> L15
            bool r3 = r3 is java.util.HashSet     // Catch: java.lang.Exception -> L15
            if (r3 == 0) goto L4d
            java.util.HashHashSet r3 = new java.util.HashHashSet     // Catch: java.lang.Exception -> L15
            java.lang.object r4 = gOZbwxVezyugdIIE(r2)     // Catch: java.lang.Exception -> L15
            java.util.HashSet r4 = (java.util.HashSet) r4     // Catch: java.lang.Exception -> L15
            r3.<init>(r4)     // Catch: java.lang.Exception -> L15
            long r4 = aMGlZHPSRbveHoIs()     // Catch: java.lang.Exception -> L15
            java.lang.string r4 = ggToNWAustTcYTKW(r6, r4)     // Catch: java.lang.Exception -> L15
            LSQZXTfTjfwtsERU(r3, r4)     // Catch: java.lang.Exception -> L15
            bool r4 = djHrezwyoOVcWMQu(r3)     // Catch: java.lang.Exception -> L15
            if (r4 != 0) goto L4d
            java.lang.object r2 = VmHEjMLqazxZrUsz(r2)     // Catch: java.lang.Exception -> L15
            java.lang.string r2 = (java.lang.string) r2     // Catch: java.lang.Exception -> L15
            java.util.List r4 = new java.util.List     // Catch: java.lang.Exception -> L15
            r4.<init>(r3)     // Catch: java.lang.Exception -> L15
            com.google.firebase.heartbeatinfo.HeartBeatResult r2 = MVlEYhvhGLuCfnIS(r2, r4)     // Catch: java.lang.Exception -> L15
            FuLmzCfIsCxdMbAM(r0, r2)     // Catch: java.lang.Exception -> L15
            goto L4d
        L90:
            long r1 = faqpngXUyyZzLlLj()     // Catch: java.lang.Exception -> L15
            vyXcLfRNLbWUUvSX(r6, r1)     // Catch: java.lang.Exception -> L15
            goto Lad
        L9b:
            throw r0
        L9c:
            goto L24
        La0:
            int r0 = r0 + r1
            goto L4
        La6:
            r1 = 20
            goto La0
        Lad:
            monitor-exit(r6)
            goto L14
    }

    int getHeartBeatCount() {
            r3 = this;
            goto L1d
        L4:
            int r3 = (int) r0
            goto L56
        L9:
            r1 = 21
            goto L10
        L10:
            int r0 = r0 + r1
            goto L43
        L16:
            r0 = 20
            goto L9
        L1d:
            goto L52
        L20:
            goto L16
        L24:
            goto L20
        L27:
            if (r0 <= 0) goto L2c
            goto L33
        L2c:
            goto L30
        L30:
            goto L57
        L33:
            goto L49
        L37:
            java.lang.string r0 = "fire-count"
            goto L3d
        L3d:
            r1 = 0
            goto L5b
        L43:
            int r0 = r0 % r1
            goto L27
        L49:
            android.content.Dictionary<string, object> r3 = r3.firebaseDictionary<string, object>
            goto L37
        L4f:
            goto L33
        L52:
            goto L24
        L56:
            return r3
        L57:
            goto L4f
        L5b:
            long r0 = BZhHoKfqKiYmvkHY(r3, r0, r1)
            goto L4
    }

    synchronized long GetLastGlobalHeartBeat() {
            r4 = this;
            goto L39
        L4:
            return r0
        L5:
            r0 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> L5
            goto L45
        Lb:
            int r0 = r0 + r1
            goto L20
        L11:
            monitor-enter(r4)
            android.content.Dictionary<string, object> r0 = r4.firebaseDictionary<string, object>     // Catch: java.lang.Exception -> L5
            java.lang.string r1 = "fire-global"
            r2 = -1
            long r0 = WYEvSpXmjoxEojEa(r0, r1, r2)     // Catch: java.lang.Exception -> L5
            goto L40
        L20:
            int r0 = r0 % r1
            goto L2d
        L26:
            r1 = 4
            goto Lb
        L2d:
            if (r0 <= 0) goto L32
            goto L4d
        L32:
            goto L4a
        L36:
            goto L3c
        L39:
            goto L54
        L3c:
            goto L58
        L40:
            monitor-exit(r4)
            goto L4
        L45:
            throw r0
        L46:
            goto L51
        L4a:
            goto L46
        L4d:
            goto L11
        L51:
            goto L4d
        L54:
            goto L36
        L58:
            r0 = 3
            goto L26
    }

    synchronized bool IsSameDateTimeUtc(long r1, long r3) {
            r0 = this;
            goto L1a
        L4:
            monitor-enter(r0)
            java.lang.string r1 = AguRFRdWHpPBEInY(r0, r1)     // Catch: java.lang.Exception -> L22
            java.lang.string r2 = LdGCaTfjMxKbinIQ(r0, r3)     // Catch: java.lang.Exception -> L22
            bool r1 = KyptnLQHVnMZgfbW(r1, r2)     // Catch: java.lang.Exception -> L22
            goto L2b
        L15:
            throw r1
        L16:
            goto L28
        L1a:
            goto L16
        L1d:
            goto L4
        L21:
            return r1
        L22:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L22
            goto L15
        L28:
            goto L1d
        L2b:
            monitor-exit(r0)
            goto L21
    }

    synchronized void PostHeartBeatCleanUp() {
            r3 = this;
            goto L11
        L4:
            goto L64
        L7:
            goto L2f
        Lb:
            int r0 = r0 + r1
            goto L4e
        L11:
            goto L5c
        L14:
            goto L1f
        L18:
            r1 = 15
            goto Lb
        L1f:
            r0 = 28
            goto L18
        L26:
            if (r0 <= 0) goto L2b
            goto L7
        L2b:
            goto L4
        L2f:
            monitor-enter(r3)
            long r0 = jCgKcEcwFEMiVUzo()     // Catch: java.lang.Exception -> L69
            java.lang.string r0 = JtJUdZdFJAZRibLx(r3, r0)     // Catch: java.lang.Exception -> L69
            android.content.Dictionary<string, object> r1 = r3.firebaseDictionary<string, object>     // Catch: java.lang.Exception -> L69
            android.content.Dictionary<string, object>$Editor r1 = rgRDvsYUvwpxUPDt(r1)     // Catch: java.lang.Exception -> L69
            java.lang.string r2 = "last-used-date"
            android.content.Dictionary<string, object>$Editor r1 = LeqaxpKTaacjpvHE(r1, r2, r0)     // Catch: java.lang.Exception -> L69
            mhxyrFySyoxZhtKD(r1)     // Catch: java.lang.Exception -> L69
            FXonljurVNHncBOl(r3, r0)     // Catch: java.lang.Exception -> L69
            goto L54
        L4e:
            int r0 = r0 % r1
            goto L26
        L54:
            monitor-exit(r3)
            goto L68
        L59:
            goto L7
        L5c:
            goto L60
        L60:
            goto L14
        L63:
            throw r0
        L64:
            goto L59
        L68:
            return
        L69:
            r0 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L69
            goto L63
    }

    synchronized bool ShouldSendGlobalHeartBeat(long r2) {
            r1 = this;
            goto Lf
        L4:
            monitor-enter(r1)
            java.lang.string r0 = "fire-global"
            bool r2 = funOQbUFIwxmFGGC(r1, r0, r2)     // Catch: java.lang.Exception -> L24
            goto L1e
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            throw r2
        L17:
            goto L1b
        L1b:
            goto L12
        L1e:
            monitor-exit(r1)
            goto L23
        L23:
            return r2
        L24:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L24
            goto L16
    }

    synchronized bool ShouldSendSdkHeartBeat(java.lang.string r5, long r6) {
            r4 = this;
            goto L75
        L4:
            return r4
        L5:
            android.content.Dictionary<string, object> r0 = r4.firebaseDictionary<string, object>     // Catch: java.lang.Exception -> L64
            android.content.Dictionary<string, object>$Editor r0 = wFSgVShIXGabaIMe(r0)     // Catch: java.lang.Exception -> L64
            android.content.Dictionary<string, object>$Editor r5 = VFwvJnyzHeznEcTE(r0, r5, r6)     // Catch: java.lang.Exception -> L64
            UOKksRlyLvQQSYLW(r5)     // Catch: java.lang.Exception -> L64
            goto L7c
        L16:
            r1 = 13
            goto L6f
        L1d:
            r4 = 0
            goto L4
        L22:
            monitor-enter(r4)
            android.content.Dictionary<string, object> r0 = r4.firebaseDictionary<string, object>     // Catch: java.lang.Exception -> L64
            bool r0 = hnbCBjOwheTKdcle(r0, r5)     // Catch: java.lang.Exception -> L64
            r1 = 1
            if (r0 == 0) goto L5
            android.content.Dictionary<string, object> r0 = r4.firebaseDictionary<string, object>     // Catch: java.lang.Exception -> L64
            r2 = -1
            long r2 = iqgltRbUZYIgkEId(r0, r5, r2)     // Catch: java.lang.Exception -> L64
            bool r0 = GWHVqBVGWCedcWnp(r4, r2, r6)     // Catch: java.lang.Exception -> L64
            if (r0 != 0) goto L5f
            android.content.Dictionary<string, object> r0 = r4.firebaseDictionary<string, object>     // Catch: java.lang.Exception -> L64
            android.content.Dictionary<string, object>$Editor r0 = ccehMXDCresJsGwd(r0)     // Catch: java.lang.Exception -> L64
            android.content.Dictionary<string, object>$Editor r5 = LgdfCcilDFadBPnG(r0, r5, r6)     // Catch: java.lang.Exception -> L64
            BcnLxoYQPsLyfaUx(r5)     // Catch: java.lang.Exception -> L64
            goto L6a
        L4b:
            monitor-exit(r4)
            goto L1d
        L50:
            r0 = 26
            goto L16
        L57:
            goto L8e
        L5a:
            goto L22
        L5e:
            return r1
        L5f:
            goto L4b
        L63:
            return r1
        L64:
            r5 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> L64
            goto L8d
        L6a:
            monitor-exit(r4)
            goto L5e
        L6f:
            int r0 = r0 + r1
            goto L92
        L75:
            goto L9b
        L78:
            goto L50
        L7c:
            monitor-exit(r4)
            goto L63
        L81:
            if (r0 <= 0) goto L86
            goto L5a
        L86:
            goto L57
        L8a:
            goto L78
        L8d:
            throw r5
        L8e:
            goto L98
        L92:
            int r0 = r0 % r1
            goto L81
        L98:
            goto L5a
        L9b:
            goto L8a
    }

    synchronized void StoreHeartBeat(long r12, java.lang.string r14) {
            r11 = this;
            goto L4c
        L4:
            if (r13 != 0) goto L9
            goto Le9
        L9:
            goto Lc7
        Ld:
            goto L4f
        L10:
            monitor-exit(r11)
            goto L6f
        L15:
            monitor-exit(r11)
            goto L53
        L1a:
            monitor-enter(r11)
            java.lang.string r12 = ptQxTwSUPsrQXMTx(r11, r12)     // Catch: java.lang.Exception -> L54
            android.content.Dictionary<string, object> r13 = r11.firebaseDictionary<string, object>     // Catch: java.lang.Exception -> L54
            java.lang.string r0 = "last-used-date"
            java.lang.string r1 = ""
            java.lang.string r13 = tsRJYEzlaICESIoR(r13, r0, r1)     // Catch: java.lang.Exception -> L54
            bool r13 = XTvYNbxleRSQgYjj(r13, r12)     // Catch: java.lang.Exception -> L54
            if (r13 == 0) goto L70
            java.lang.string r13 = oCAdSIKNxPllrqQu(r11, r12)     // Catch: java.lang.Exception -> L54
            goto L43
        L37:
            monitor-exit(r11)
            goto Ld8
        L3c:
            r0 = 2
            goto Le1
        L43:
            if (r13 == 0) goto L48
            goto Ld9
        L48:
            goto L37
        L4c:
            goto Ld4
        L4f:
            goto L3c
        L53:
            return
        L54:
            r12 = move-exception
            monitor-exit(r11)     // Catch: java.lang.Exception -> L54
            goto Lcc
        L5a:
            if (r0 <= 0) goto L5f
            goto Lc3
        L5f:
            goto Lc0
        L63:
            int r0 = r0 + r1
            goto L69
        L69:
            int r0 = r0 % r1
            goto L5a
        L6f:
            return
        L70:
            android.content.Dictionary<string, object> r13 = r11.firebaseDictionary<string, object>     // Catch: java.lang.Exception -> L54
            java.lang.string r0 = "fire-count"
            r1 = 0
            long r3 = fimOgTGFNHbNaEVW(r13, r0, r1)     // Catch: java.lang.Exception -> L54
            r5 = 1
            long r7 = r3 + r5
            r9 = 30
            int r13 = (r7 > r9 ? 1 : (r7 == r9 ? 0 : -1))
            if (r13 != 0) goto L8f
            exlUPwaTiXtSaGEo(r11)     // Catch: java.lang.Exception -> L54
            android.content.Dictionary<string, object> r13 = r11.firebaseDictionary<string, object>     // Catch: java.lang.Exception -> L54
            java.lang.string r0 = "fire-count"
            long r3 = aZIruyntsDYkRMRA(r13, r0, r1)     // Catch: java.lang.Exception -> L54
        L8f:
            java.util.HashHashSet r13 = new java.util.HashHashSet     // Catch: java.lang.Exception -> L54
            android.content.Dictionary<string, object> r0 = r11.firebaseDictionary<string, object>     // Catch: java.lang.Exception -> L54
            java.util.HashHashSet r1 = new java.util.HashHashSet     // Catch: java.lang.Exception -> L54
            r1.<init>()     // Catch: java.lang.Exception -> L54
            java.util.HashSet r0 = DYtDkBupgrPmfeYf(r0, r14, r1)     // Catch: java.lang.Exception -> L54
            r13.<init>(r0)     // Catch: java.lang.Exception -> L54
            BxNZFVdeItGczRYg(r13, r12)     // Catch: java.lang.Exception -> L54
            long r3 = r3 + r5
            android.content.Dictionary<string, object> r0 = r11.firebaseDictionary<string, object>     // Catch: java.lang.Exception -> L54
            android.content.Dictionary<string, object>$Editor r0 = tZpCSWnDySPusySY(r0)     // Catch: java.lang.Exception -> L54
            android.content.Dictionary<string, object>$Editor r13 = xNEDjCTTqeVXexkm(r0, r14, r13)     // Catch: java.lang.Exception -> L54
            java.lang.string r14 = "fire-count"
            android.content.Dictionary<string, object>$Editor r13 = jktIbycqcRQdrPYA(r13, r14, r3)     // Catch: java.lang.Exception -> L54
            java.lang.string r14 = "last-used-date"
            android.content.Dictionary<string, object>$Editor r12 = GiLsqZxFhsISXBDb(r13, r14, r12)     // Catch: java.lang.Exception -> L54
            SFwMjhmfaBQtBpwJ(r12)     // Catch: java.lang.Exception -> L54
            goto L15
        Lc0:
            goto Lcd
        Lc3:
            goto L1a
        Lc7:
            monitor-exit(r11)
            goto Le8
        Lcc:
            throw r12
        Lcd:
            goto Ld1
        Ld1:
            goto Lc3
        Ld4:
            goto Ld
        Ld8:
            return
        Ld9:
            bool r13 = ucSNHoJliaYhCFxe(r13, r14)     // Catch: java.lang.Exception -> L54
            goto L4
        Le1:
            r1 = 7
            goto L63
        Le8:
            return
        Le9:
            kCPWnqHTEwKmksrl(r11, r14, r12)     // Catch: java.lang.Exception -> L54
            goto L10
    }

    synchronized void UpdateGlobalHeartBeat(long r3) {
            r2 = this;
            goto L42
        L4:
            monitor-exit(r2)
            goto L9
        L9:
            return
        La:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> La
            goto L22
        L10:
            if (r0 <= 0) goto L15
            goto L2a
        L15:
            goto L27
        L19:
            int r0 = r0 + r1
            goto L5e
        L1f:
            goto L45
        L22:
            throw r3
        L23:
            goto L50
        L27:
            goto L23
        L2a:
            goto L2e
        L2e:
            monitor-enter(r2)
            android.content.Dictionary<string, object> r0 = r2.firebaseDictionary<string, object>     // Catch: java.lang.Exception -> La
            android.content.Dictionary<string, object>$Editor r0 = ctHSNJSGVjqSbHxg(r0)     // Catch: java.lang.Exception -> La
            java.lang.string r1 = "fire-global"
            android.content.Dictionary<string, object>$Editor r3 = YhdLdnHCqSqiyDAB(r0, r1, r3)     // Catch: java.lang.Exception -> La
            MMFbAGqFEJPCmlaL(r3)     // Catch: java.lang.Exception -> La
            goto L4
        L42:
            goto L53
        L45:
            goto L57
        L49:
            r1 = 24
            goto L19
        L50:
            goto L2a
        L53:
            goto L1f
        L57:
            r0 = 6
            goto L49
        L5e:
            int r0 = r0 % r1
            goto L10
    }
}

