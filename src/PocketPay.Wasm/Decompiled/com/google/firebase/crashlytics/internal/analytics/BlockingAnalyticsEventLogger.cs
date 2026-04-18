namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
public class BlockingAnalyticsEventConsoleger : com.google.firebase.crashlytics.internal.analytics.AnalyticsEventReceiver, com.google.firebase.crashlytics.internal.analytics.AnalyticsEventConsoleger {
    static readonly java.lang.string APP_EXCEPTION_EVENT_NAME = "_ae";
    private readonly com.google.firebase.crashlytics.internal.analytics.CrashlyticsOriginAnalyticsEventConsoleger baseAnalyticsEventConsoleger;
    private bool callbackReceived;
    private java.util.concurrent.CountdownEvent eventLatch;
    private readonly java.lang.object latchLock;
    private readonly java.util.concurrent.TimeUnit timeUnit;
    private readonly int timeout;

    public BlockingAnalyticsEventConsoleger(com.google.firebase.crashlytics.internal.analytics.CrashlyticsOriginAnalyticsEventConsoleger r2, int r3, java.util.concurrent.TimeUnit r4) {
            r1 = this;
            goto L1f
        L4:
            r1.callbackReceived = r0
            goto L19
        La:
            goto L22
        Ld:
            return
        Le:
            goto La
        L12:
            r0.<init>()
            goto L3f
        L19:
            r1.baseAnalyticsEventConsoleger = r2
            goto L2c
        L1f:
            goto Le
        L22:
            goto L38
        L26:
            r1.timeUnit = r4
            goto Ld
        L2c:
            r1.timeout = r3
            goto L26
        L32:
            java.lang.object r0 = new java.lang.object
            goto L12
        L38:
            r1.<init>()
            goto L32
        L3f:
            r1.latchLock = r0
            goto L45
        L45:
            r0 = 0
            goto L4
    }

    public static com.google.firebase.crashlytics.internal.Consoleger BTTxeqMBcyHWqfCT() {
            goto L14
        L4:
            com.google.firebase.crashlytics.internal.Consoleger r0 = com.google.firebase.crashlytics.internal.Consoleger.getConsoleger()
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

    public static void BTTxeqMBcyHWqfCT(float r0, java.lang.string r1, int r2, byte r3) {
            goto L18
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L1b
        L12:
            int r3 = r2 + r1
            goto L1f
        L18:
            goto Lb
        L1b:
            goto L24
        L1f:
            double r0 = (double) r3
            goto La
        L24:
            r0 = 42
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L12
    }

    public static void BTTxeqMBcyHWqfCT(int r0, java.lang.string r1, float r2, byte r3) {
            goto L12
        L4:
            goto L15
        L7:
            int r2 = r0 * r1
            goto L24
        Ld:
            return
        Le:
            goto L4
        L12:
            goto Le
        L15:
            goto L1e
        L19:
            double r0 = (double) r3
            goto Ld
        L1e:
            r0 = 42
            goto L2a
        L24:
            int r3 = r2 + r1
            goto L19
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
    }

    public static void BTTxeqMBcyHWqfCT(java.lang.string r0, byte r1, float r2, int r3) {
            goto L19
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L26
        L10:
            goto L1c
        L13:
            r0 = 42
            goto L20
        L19:
            goto L2c
        L1c:
            goto L13
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L10
    }

    public static com.google.firebase.crashlytics.internal.Consoleger GsDtCdsDevNTaSiN() {
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
            com.google.firebase.crashlytics.internal.Consoleger r0 = com.google.firebase.crashlytics.internal.Consoleger.getConsoleger()
            goto Lb
        L18:
            goto L7
    }

    public static void GsDtCdsDevNTaSiN(byte r0, char r1, float r2, bool r3) {
            goto L29
        L4:
            r0 = 42
            goto L1d
        La:
            int r2 = r0 * r1
            goto L23
        L10:
            goto L2c
        L13:
            return
        L14:
            goto L10
        L18:
            double r0 = (double) r3
            goto L13
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L23:
            int r3 = r2 + r1
            goto L18
        L29:
            goto L14
        L2c:
            goto L4
    }

    public static void GsDtCdsDevNTaSiN(char r0, bool r1, byte r2, float r3) {
            goto L19
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L10:
            goto L1c
        L13:
            int r3 = r2 + r1
            goto L20
        L19:
            goto L26
        L1c:
            goto L4
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L10
        L2a:
            int r2 = r0 * r1
            goto L13
    }

    public static void GsDtCdsDevNTaSiN(bool r0, byte r1, float r2, char r3) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L1c
        Lb:
            return
        Lc:
            goto L27
        L10:
            int r2 = r0 * r1
            goto L2a
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L1c:
            r0 = 42
            goto L16
        L22:
            double r0 = (double) r3
            goto Lb
        L27:
            goto L7
        L2a:
            int r3 = r2 + r1
            goto L22
    }

    public static java.lang.string QOgFwjXAQPTzIZVR(java.lang.stringBuilder r1) {
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
            java.lang.string r0 = r1.tostring()
            goto Lb
    }

    public static void QOgFwjXAQPTzIZVR(java.lang.stringBuilder r0, byte r1, int r2, java.lang.string r3, float r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L1f
        La:
            goto L1b
        Ld:
            goto L25
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L17:
            goto Ld
        L1a:
            return
        L1b:
            goto L17
        L1f:
            int r3 = r2 + r1
            goto L2b
        L25:
            r0 = 42
            goto L11
        L2b:
            double r0 = (double) r3
            goto L1a
    }

    public static void QOgFwjXAQPTzIZVR(java.lang.stringBuilder r0, float r1, java.lang.string r2, int r3, byte r4) {
            goto L1a
        L4:
            int r2 = r0 * r1
            goto Lf
        La:
            double r0 = (double) r3
            goto L15
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            return
        L16:
            goto L21
        L1a:
            goto L16
        L1d:
            goto L24
        L21:
            goto L1d
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void QOgFwjXAQPTzIZVR(java.lang.stringBuilder r0, int r1, java.lang.string r2, float r3, byte r4) {
            goto L1b
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            int r2 = r0 * r1
            goto Lf
        Lf:
            int r3 = r2 + r1
            goto L4
        L15:
            r0 = 42
            goto L2a
        L1b:
            goto L26
        L1e:
            goto L15
        L22:
            goto L1e
        L25:
            return
        L26:
            goto L22
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
    }

    public static void RrGSUWBdMZsdCfcE(java.util.concurrent.CountdownEvent r0, long r1, java.util.concurrent.TimeUnit r3, java.lang.string r4, float r5, short r6, byte r7) {
            goto L21
        L4:
            r0 = 42
            goto L10
        La:
            int r3 = r2 + r1
            goto L1c
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L16:
            int r2 = r0 * r1
            goto La
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

    public static void RrGSUWBdMZsdCfcE(java.util.concurrent.CountdownEvent r0, long r1, java.util.concurrent.TimeUnit r3, short r4, byte r5, float r6, java.lang.string r7) {
            goto Lf
        L4:
            return
        L5:
            goto L27
        L9:
            r0 = 42
            goto L1c
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            int r3 = r2 + r1
            goto L22
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L22:
            double r0 = (double) r3
            goto L4
        L27:
            goto L12
        L2a:
            int r2 = r0 * r1
            goto L16
    }

    public static void RrGSUWBdMZsdCfcE(java.util.concurrent.CountdownEvent r0, long r1, java.util.concurrent.TimeUnit r3, short r4, byte r5, java.lang.string r6, float r7) {
            goto L17
        L4:
            goto L1a
        L7:
            double r0 = (double) r3
            goto L12
        Lc:
            int r3 = r2 + r1
            goto L7
        L12:
            return
        L13:
            goto L4
        L17:
            goto L13
        L1a:
            goto L24
        L1e:
            int r2 = r0 * r1
            goto Lc
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
    }

    public static bool RrGSUWBdMZsdCfcE(java.util.concurrent.CountdownEvent r1, long r2, java.util.concurrent.TimeUnit r4) {
            goto Lf
        L4:
            goto L12
        L7:
            bool r0 = r1.await(r2, r4)
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

    public static java.lang.stringBuilder TvHASaqXUJmtbRDC(java.lang.stringBuilder r1, java.lang.object r2) {
            goto Lc
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
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

    public static void TvHASaqXUJmtbRDC(java.lang.stringBuilder r0, java.lang.object r1, byte r2, short r3, int r4, java.lang.string r5) {
            goto L16
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L10:
            int r2 = r0 * r1
            goto L1d
        L16:
            goto L29
        L19:
            goto L4
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
            goto L19
    }

    public static void TvHASaqXUJmtbRDC(java.lang.stringBuilder r0, java.lang.object r1, int r2, short r3, java.lang.string r4, byte r5) {
            goto L19
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        La:
            goto L1c
        Ld:
            r0 = 42
            goto L4
        L13:
            int r2 = r0 * r1
            goto L2a
        L19:
            goto L21
        L1c:
            goto Ld
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

    public static void TvHASaqXUJmtbRDC(java.lang.stringBuilder r0, java.lang.object r1, java.lang.string r2, short r3, byte r4, int r5) {
            goto Le
        L4:
            return
        L5:
            goto L15
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            goto L5
        L11:
            goto L1e
        L15:
            goto L11
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L1e:
            r0 = 42
            goto L18
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L9
    }

    public static void TynbewhwOcDhnJik(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1) {
            goto L10
        L4:
            r0.m357v(r1)
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

    public static void TynbewhwOcDhnJik(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, byte r2, bool r3, int r4, float r5) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L1e
        La:
            r0 = 42
            goto L13
        L10:
            goto L2c
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L19:
            double r0 = (double) r3
            goto L24
        L1e:
            int r3 = r2 + r1
            goto L19
        L24:
            return
        L25:
            goto L10
        L29:
            goto L25
        L2c:
            goto La
    }

    public static void TynbewhwOcDhnJik(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, float r2, byte r3, int r4, bool r5) {
            goto L4
        L4:
            goto L26
        L7:
            goto L1a
        Lb:
            int r2 = r0 * r1
            goto L11
        L11:
            int r3 = r2 + r1
            goto L20
        L17:
            goto L7
        L1a:
            r0 = 42
            goto L2a
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L17
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
    }

    public static void TynbewhwOcDhnJik(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, bool r2, byte r3, float r4, int r5) {
            goto L21
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        La:
            r0 = 42
            goto L4
        L10:
            double r0 = (double) r3
            goto L28
        L15:
            int r3 = r2 + r1
            goto L10
        L1b:
            int r2 = r0 * r1
            goto L15
        L21:
            goto L29
        L24:
            goto La
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L24
    }

    public static com.google.firebase.crashlytics.internal.Consoleger AqSxQNqxYjYiAzdt() {
            goto Lf
        L4:
            goto L12
        L7:
            com.google.firebase.crashlytics.internal.Consoleger r0 = com.google.firebase.crashlytics.internal.Consoleger.getConsoleger()
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

    public static void AqSxQNqxYjYiAzdt(float r0, byte r1, java.lang.string r2, short r3) {
            goto L26
        L4:
            int r2 = r0 * r1
            goto L10
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            int r3 = r2 + r1
            goto L1b
        L16:
            return
        L17:
            goto L2d
        L1b:
            double r0 = (double) r3
            goto L16
        L20:
            r0 = 42
            goto La
        L26:
            goto L17
        L29:
            goto L20
        L2d:
            goto L29
    }

    public static void AqSxQNqxYjYiAzdt(float r0, java.lang.string r1, short r2, byte r3) {
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
            goto L14
        L14:
            goto L26
        L17:
            r0 = 42
            goto L2a
        L1d:
            int r2 = r0 * r1
            goto L4
        L23:
            goto L10
        L26:
            goto L17
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
    }

    public static void AqSxQNqxYjYiAzdt(java.lang.string r0, short r1, float r2, byte r3) {
            goto L1b
        L4:
            r0 = 42
            goto Lf
        La:
            return
        Lb:
            goto L27
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L15:
            int r2 = r0 * r1
            goto L2a
        L1b:
            goto Lb
        L1e:
            goto L4
        L22:
            double r0 = (double) r3
            goto La
        L27:
            goto L1e
        L2a:
            int r3 = r2 + r1
            goto L22
    }

    public static java.lang.stringBuilder DJhBwZWWPggoouzb(java.lang.stringBuilder r1, java.lang.string r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
    }

    public static void DJhBwZWWPggoouzb(java.lang.stringBuilder r0, java.lang.string r1, byte r2, float r3, bool r4, int r5) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            goto L26
        L12:
            goto L1f
        L16:
            goto L12
        L19:
            int r2 = r0 * r1
            goto L9
        L1f:
            r0 = 42
            goto L2a
        L25:
            return
        L26:
            goto L16
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
    }

    public static void DJhBwZWWPggoouzb(java.lang.stringBuilder r0, java.lang.string r1, float r2, int r3, byte r4, bool r5) {
            goto L10
        L4:
            r0 = 42
            goto L1c
        La:
            int r3 = r2 + r1
            goto L17
        L10:
            goto L26
        L13:
            goto L4
        L17:
            double r0 = (double) r3
            goto L25
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
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

    public static void DJhBwZWWPggoouzb(java.lang.stringBuilder r0, java.lang.string r1, bool r2, byte r3, int r4, float r5) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L25
        La:
            goto L15
        Ld:
            goto L19
        L11:
            goto Ld
        L14:
            return
        L15:
            goto L11
        L19:
            r0 = 42
            goto L1f
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L14
    }

    public static void GQrSqFCpQUSKEtVq(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1) {
            goto Lb
        L4:
            r0.m359w(r1)
            goto L15
        Lb:
            goto L16
        Le:
            goto L4
        L12:
            goto Le
        L15:
            return
        L16:
            goto L12
    }

    public static void GQrSqFCpQUSKEtVq(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, char r2, java.lang.string r3, bool r4, short r5) {
            goto L29
        L4:
            double r0 = (double) r3
            goto Lc
        L9:
            goto L2c
        Lc:
            return
        Ld:
            goto L9
        L11:
            int r3 = r2 + r1
            goto L4
        L17:
            r0 = 42
            goto L1d
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L23:
            int r2 = r0 * r1
            goto L11
        L29:
            goto Ld
        L2c:
            goto L17
    }

    public static void GQrSqFCpQUSKEtVq(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, char r2, bool r3, short r4, java.lang.string r5) {
            goto L29
        L4:
            goto L2c
        L7:
            double r0 = (double) r3
            goto L1e
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L12:
            r0 = 42
            goto Lc
        L18:
            int r2 = r0 * r1
            goto L23
        L1e:
            return
        L1f:
            goto L4
        L23:
            int r3 = r2 + r1
            goto L7
        L29:
            goto L1f
        L2c:
            goto L12
    }

    public static void GQrSqFCpQUSKEtVq(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, java.lang.string r2, bool r3, short r4, char r5) {
            goto L1e
        L4:
            return
        L5:
            goto Lf
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        Lf:
            goto L21
        L12:
            r0 = 42
            goto L9
        L18:
            int r3 = r2 + r1
            goto L25
        L1e:
            goto L5
        L21:
            goto L12
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L18
    }

    public static void NOeNusHHiRYAzNnr(java.util.concurrent.CountdownEvent r0) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.countDown()
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static void NOeNusHHiRYAzNnr(java.util.concurrent.CountdownEvent r0, float r1, short r2, bool r3, int r4) {
            goto L15
        L4:
            return
        L5:
            goto L2d
        L9:
            int r3 = r2 + r1
            goto L1c
        Lf:
            int r2 = r0 * r1
            goto L9
        L15:
            goto L5
        L18:
            goto L27
        L1c:
            double r0 = (double) r3
            goto L4
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L27:
            r0 = 42
            goto L21
        L2d:
            goto L18
    }

    public static void NOeNusHHiRYAzNnr(java.util.concurrent.CountdownEvent r0, float r1, bool r2, int r3, short r4) {
            goto L19
        L4:
            int r3 = r2 + r1
            goto L25
        La:
            r0 = 42
            goto L10
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L16:
            goto L1c
        L19:
            goto L21
        L1c:
            goto La
        L20:
            return
        L21:
            goto L16
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void NOeNusHHiRYAzNnr(java.util.concurrent.CountdownEvent r0, short r1, float r2, bool r3, int r4) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L2a
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            int r2 = r0 * r1
            goto L19
        L19:
            int r3 = r2 + r1
            goto L1f
        L1f:
            double r0 = (double) r3
            goto Lb
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L2a:
            r0 = 42
            goto L24
    }

    public static com.google.firebase.crashlytics.internal.Consoleger NZQZrUWIBNjiQcyS() {
            goto L11
        L4:
            com.google.firebase.crashlytics.internal.Consoleger r0 = com.google.firebase.crashlytics.internal.Consoleger.getConsoleger()
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

    public static void NZQZrUWIBNjiQcyS(java.lang.string r0, short r1, float r2, bool r3) {
            goto L26
        L4:
            r0 = 42
            goto Lf
        La:
            return
        Lb:
            goto L2d
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L15:
            double r0 = (double) r3
            goto La
        L1a:
            int r3 = r2 + r1
            goto L15
        L20:
            int r2 = r0 * r1
            goto L1a
        L26:
            goto Lb
        L29:
            goto L4
        L2d:
            goto L29
    }

    public static void NZQZrUWIBNjiQcyS(short r0, java.lang.string r1, bool r2, float r3) {
            goto L18
        L4:
            int r3 = r2 + r1
            goto L1f
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L1b
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L18:
            goto Lb
        L1b:
            goto L2a
        L1f:
            double r0 = (double) r3
            goto La
        L24:
            int r2 = r0 * r1
            goto L4
        L2a:
            r0 = 42
            goto L12
    }

    public static void NZQZrUWIBNjiQcyS(bool r0, java.lang.string r1, float r2, short r3) {
            goto L29
        L4:
            goto L2c
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        Ld:
            int r2 = r0 * r1
            goto L18
        L13:
            return
        L14:
            goto L4
        L18:
            int r3 = r2 + r1
            goto L1e
        L1e:
            double r0 = (double) r3
            goto L13
        L23:
            r0 = 42
            goto L7
        L29:
            goto L14
        L2c:
            goto L23
    }

    public static java.lang.stringBuilder OwgIGYZsqSMfVqCp(java.lang.stringBuilder r1, java.lang.string r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Le
    }

    public static void OwgIGYZsqSMfVqCp(java.lang.stringBuilder r0, java.lang.string r1, char r2, float r3, java.lang.string r4, int r5) {
            goto L18
        L4:
            goto L1b
        L7:
            int r3 = r2 + r1
            goto L2b
        Ld:
            return
        Le:
            goto L4
        L12:
            r0 = 42
            goto L1f
        L18:
            goto Le
        L1b:
            goto L12
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L25:
            int r2 = r0 * r1
            goto L7
        L2b:
            double r0 = (double) r3
            goto Ld
    }

    public static void OwgIGYZsqSMfVqCp(java.lang.stringBuilder r0, java.lang.string r1, char r2, java.lang.string r3, int r4, float r5) {
            goto L24
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            r0 = 42
            goto L12
        Lf:
            goto L27
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L18:
            int r2 = r0 * r1
            goto L1e
        L1e:
            int r3 = r2 + r1
            goto L4
        L24:
            goto L2c
        L27:
            goto L9
        L2b:
            return
        L2c:
            goto Lf
    }

    public static void OwgIGYZsqSMfVqCp(java.lang.stringBuilder r0, java.lang.string r1, java.lang.string r2, char r3, int r4, float r5) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L28
        La:
            goto L18
        Ld:
            goto L11
        L11:
            r0 = 42
            goto L22
        L17:
            return
        L18:
            goto L2d
        L1c:
            int r2 = r0 * r1
            goto L4
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L28:
            double r0 = (double) r3
            goto L17
        L2d:
            goto Ld
    }

    public static void PWPAyidTZswtnQkW(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1) {
            goto Lc
        L4:
            return
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            r0.m357v(r1)
            goto L4
    }

    public static void PWPAyidTZswtnQkW(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, java.lang.string r2, short r3, char r4, bool r5) {
            goto Ld
        L4:
            int r3 = r2 + r1
            goto L14
        La:
            goto L10
        Ld:
            goto L2c
        L10:
            goto L25
        L14:
            double r0 = (double) r3
            goto L2b
        L19:
            int r2 = r0 * r1
            goto L4
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L25:
            r0 = 42
            goto L1f
        L2b:
            return
        L2c:
            goto La
    }

    public static void PWPAyidTZswtnQkW(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, short r2, bool r3, char r4, java.lang.string r5) {
            goto Lf
        L4:
            int r3 = r2 + r1
            goto L19
        La:
            return
        Lb:
            goto L16
        Lf:
            goto Lb
        L12:
            goto L24
        L16:
            goto L12
        L19:
            double r0 = (double) r3
            goto La
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

    public static void PWPAyidTZswtnQkW(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, bool r2, char r3, short r4, java.lang.string r5) {
            goto L1d
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
            goto L20
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L1d:
            goto La
        L20:
            goto L2a
        L24:
            int r2 = r0 * r1
            goto Le
        L2a:
            r0 = 42
            goto L17
    }

    public static void QxxpLcUxtKOZBqmd(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1) {
            goto L10
        L4:
            r0.m353e(r1)
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

    public static void QxxpLcUxtKOZBqmd(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, char r2, short r3, float r4, bool r5) {
            goto L7
        L4:
            goto La
        L7:
            goto L26
        La:
            goto L13
        Le:
            double r0 = (double) r3
            goto L25
        L13:
            r0 = 42
            goto L19
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1f:
            int r2 = r0 * r1
            goto L2a
        L25:
            return
        L26:
            goto L4
        L2a:
            int r3 = r2 + r1
            goto Le
    }

    public static void QxxpLcUxtKOZBqmd(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, float r2, char r3, short r4, bool r5) {
            goto L26
        L4:
            int r2 = r0 * r1
            goto L15
        La:
            r0 = 42
            goto L1b
        L10:
            double r0 = (double) r3
            goto L21
        L15:
            int r3 = r2 + r1
            goto L10
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L21:
            return
        L22:
            goto L2d
        L26:
            goto L22
        L29:
            goto La
        L2d:
            goto L29
    }

    public static void QxxpLcUxtKOZBqmd(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, short r2, char r3, bool r4, float r5) {
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
            int r2 = r0 * r1
            goto L2a
        L17:
            r0 = 42
            goto L24
        L1d:
            goto Ld
        L20:
            goto L17
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L2a:
            int r3 = r2 + r1
            goto L7
    }

    public static void QzpFFKDJchRKkFXG(com.google.firebase.crashlytics.internal.analytics.CrashlyticsOriginAnalyticsEventConsoleger r0, java.lang.string r1, android.os.Dictionary<string, object> r2) {
            goto L10
        L4:
            r0.logEvent(r1, r2)
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

    public static void QzpFFKDJchRKkFXG(com.google.firebase.crashlytics.internal.analytics.CrashlyticsOriginAnalyticsEventConsoleger r0, java.lang.string r1, android.os.Dictionary<string, object> r2, int r3, java.lang.string r4, byte r5, bool r6) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L16
        L10:
            r0 = 42
            goto L4
        L16:
            int r3 = r2 + r1
            goto L21
        L1c:
            return
        L1d:
            goto L26
        L21:
            double r0 = (double) r3
            goto L1c
        L26:
            goto L2c
        L29:
            goto L1d
        L2c:
            goto L10
    }

    public static void QzpFFKDJchRKkFXG(com.google.firebase.crashlytics.internal.analytics.CrashlyticsOriginAnalyticsEventConsoleger r0, java.lang.string r1, android.os.Dictionary<string, object> r2, java.lang.string r3, byte r4, int r5, bool r6) {
            goto L1b
        L4:
            int r3 = r2 + r1
            goto L22
        La:
            return
        Lb:
            goto L27
        Lf:
            r0 = 42
            goto L2a
        L15:
            int r2 = r0 * r1
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
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
    }

    public static void QzpFFKDJchRKkFXG(com.google.firebase.crashlytics.internal.analytics.CrashlyticsOriginAnalyticsEventConsoleger r0, java.lang.string r1, android.os.Dictionary<string, object> r2, bool r3, byte r4, int r5, java.lang.string r6) {
            goto L10
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L10:
            goto L18
        L13:
            goto L4
        L17:
            return
        L18:
            goto L1c
        L1c:
            goto L13
        L1f:
            double r0 = (double) r3
            goto L17
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    public static void WUmjftfSGaYXKDmX(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1) {
            goto L13
        L4:
            goto L16
        L7:
            r0.m357v(r1)
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    public static void WUmjftfSGaYXKDmX(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, short r2, char r3, int r4, bool r5) {
            goto L17
        L4:
            double r0 = (double) r3
            goto L12
        L9:
            r0 = 42
            goto L2a
        Lf:
            goto L1a
        L12:
            return
        L13:
            goto Lf
        L17:
            goto L13
        L1a:
            goto L9
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

    public static void WUmjftfSGaYXKDmX(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, bool r2, char r3, int r4, short r5) {
            goto L12
        L4:
            return
        L5:
            goto Lf
        L9:
            r0 = 42
            goto L2a
        Lf:
            goto L15
        L12:
            goto L5
        L15:
            goto L9
        L19:
            int r3 = r2 + r1
            goto L1f
        L1f:
            double r0 = (double) r3
            goto L4
        L24:
            int r2 = r0 * r1
            goto L19
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void WUmjftfSGaYXKDmX(com.google.firebase.crashlytics.internal.Consoleger r0, java.lang.string r1, bool r2, short r3, char r4, int r5) {
            goto L24
        L4:
            int r2 = r0 * r1
            goto Lf
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1b:
            goto L27
        L1e:
            r0 = 42
            goto L15
        L24:
            goto L2c
        L27:
            goto L1e
        L2b:
            return
        L2c:
            goto L1b
    }

    public static void XMhNvJSIbcylmmwf(java.lang.string r0, java.lang.object r1, byte r2, char r3, bool r4, java.lang.string r5) {
            goto L15
        L4:
            double r0 = (double) r3
            goto L28
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L15:
            goto L29
        L18:
            goto L22
        L1c:
            int r2 = r0 * r1
            goto L9
        L22:
            r0 = 42
            goto Lf
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L18
    }

    public static void XMhNvJSIbcylmmwf(java.lang.string r0, java.lang.object r1, char r2, byte r3, bool r4, java.lang.string r5) {
            goto L16
        L4:
            int r2 = r0 * r1
            goto L10
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            int r3 = r2 + r1
            goto L1d
        L16:
            goto L2c
        L19:
            goto L22
        L1d:
            double r0 = (double) r3
            goto L2b
        L22:
            r0 = 42
            goto La
        L28:
            goto L19
        L2b:
            return
        L2c:
            goto L28
    }

    public static void XMhNvJSIbcylmmwf(java.lang.string r0, java.lang.object r1, char r2, bool r3, java.lang.string r4, byte r5) {
            goto L1d
        L4:
            return
        L5:
            goto L9
        L9:
            goto L20
        Lc:
            double r0 = (double) r3
            goto L4
        L11:
            r0 = 42
            goto L17
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L1d:
            goto L5
        L20:
            goto L11
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto Lc
    }

    public static bool XMhNvJSIbcylmmwf(java.lang.string r1, java.lang.object r2) {
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

    public static com.google.firebase.crashlytics.internal.Consoleger ZmXUnUyaybNzUdvR() {
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
            com.google.firebase.crashlytics.internal.Consoleger r0 = com.google.firebase.crashlytics.internal.Consoleger.getConsoleger()
            goto Le
    }

    public static void ZmXUnUyaybNzUdvR(int r0, short r1, bool r2, java.lang.string r3) {
            goto L26
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        La:
            r0 = 42
            goto L4
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L2d
        L1a:
            int r2 = r0 * r1
            goto L20
        L20:
            int r3 = r2 + r1
            goto L10
        L26:
            goto L16
        L29:
            goto La
        L2d:
            goto L29
    }

    public static void ZmXUnUyaybNzUdvR(int r0, bool r1, short r2, java.lang.string r3) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L1e
        La:
            r0 = 42
            goto L23
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
            double r0 = (double) r3
            goto L19
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L29:
            goto L1a
        L2c:
            goto La
    }

    public static void ZmXUnUyaybNzUdvR(java.lang.string r0, short r1, bool r2, int r3) {
            goto L12
        L4:
            goto L15
        L7:
            return
        L8:
            goto L4
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L12:
            goto L8
        L15:
            goto L1f
        L19:
            int r2 = r0 * r1
            goto L25
        L1f:
            r0 = 42
            goto Lc
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L7
    }

    bool isCallbackReceived() {
            r0 = this;
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
            bool r0 = r0.callbackReceived
            goto Le
    }

    @Override // com.google.firebase.crashlytics.internal.analytics.AnalyticsEventConsoleger
    public void LogEvent(java.lang.string r6, android.os.Dictionary<string, object> r7) {
            r5 = this;
            goto L4
        L4:
            goto Le
        L7:
            goto Laa
        Lb:
            goto L2a
        Le:
            goto L33
        L12:
            goto L1c
        L13:
            com.google.firebase.crashlytics.internal.Consoleger r6 = nZQZrUWIBNjiQcyS()     // Catch: java.lang.Exception -> L21
            java.lang.string r7 = "Interrupted while awaiting app exception callback from Analytics listener."
            qxxpLcUxtKOZBqmd(r6, r7)     // Catch: java.lang.Exception -> L21
        L1c:
            r6 = 0
            r5.eventLatch = r6     // Catch: java.lang.Exception -> L21
            monitor-exit(r1)     // Catch: java.lang.Exception -> L21
            return
        L21:
            r5 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L21
            goto L2e
        L27:
            goto L2f
        L2a:
            goto Lb1
        L2e:
            throw r5
        L2f:
            goto Lb
        L33:
            goto L7
        L36:
            r1 = 16
            goto Lbd
        L3d:
            monitor-enter(r1)
            com.google.firebase.crashlytics.internal.Consoleger r2 = GsDtCdsDevNTaSiN()     // Catch: java.lang.Exception -> L21
            java.lang.stringBuilder r3 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L21
            r3.<init>(r0)     // Catch: java.lang.Exception -> L21
            java.lang.stringBuilder r0 = owgIGYZsqSMfVqCp(r3, r6)     // Catch: java.lang.Exception -> L21
            java.lang.string r3 = " to Firebase Analytics with params "
            java.lang.stringBuilder r0 = dJhBwZWWPggoouzb(r0, r3)     // Catch: java.lang.Exception -> L21
            java.lang.stringBuilder r0 = TvHASaqXUJmtbRDC(r0, r7)     // Catch: java.lang.Exception -> L21
            java.lang.string r0 = QOgFwjXAQPTzIZVR(r0)     // Catch: java.lang.Exception -> L21
            pWPAyidTZswtnQkW(r2, r0)     // Catch: java.lang.Exception -> L21
            java.util.concurrent.CountdownEvent r0 = new java.util.concurrent.CountdownEvent     // Catch: java.lang.Exception -> L21
            r2 = 1
            r0.<init>(r2)     // Catch: java.lang.Exception -> L21
            r5.eventLatch = r0     // Catch: java.lang.Exception -> L21
            r0 = 0
            r5.callbackReceived = r0     // Catch: java.lang.Exception -> L21
            com.google.firebase.crashlytics.internal.analytics.CrashlyticsOriginAnalyticsEventConsoleger r0 = r5.baseAnalyticsEventConsoleger     // Catch: java.lang.Exception -> L21
            qzpFFKDJchRKkFXG(r0, r6, r7)     // Catch: java.lang.Exception -> L21
            com.google.firebase.crashlytics.internal.Consoleger r6 = aqSxQNqxYjYiAzdt()     // Catch: java.lang.Exception -> L21
            java.lang.string r7 = "Awaiting app exception callback from Analytics..."
            TynbewhwOcDhnJik(r6, r7)     // Catch: java.lang.Exception -> L21
            java.util.concurrent.CountdownEvent r6 = r5.eventLatch     // Catch: java.lang.InterruptedException -> L13 java.lang.Exception -> L21
            int r7 = r5.timeout     // Catch: java.lang.InterruptedException -> L13 java.lang.Exception -> L21
            long r3 = (long) r7     // Catch: java.lang.InterruptedException -> L13 java.lang.Exception -> L21
            java.util.concurrent.TimeUnit r7 = r5.timeUnit     // Catch: java.lang.InterruptedException -> L13 java.lang.Exception -> L21
            bool r6 = RrGSUWBdMZsdCfcE(r6, r3, r7)     // Catch: java.lang.InterruptedException -> L13 java.lang.Exception -> L21
            if (r6 == 0) goto L8e
            r5.callbackReceived = r2     // Catch: java.lang.InterruptedException -> L13 java.lang.Exception -> L21
            com.google.firebase.crashlytics.internal.Consoleger r6 = BTTxeqMBcyHWqfCT()     // Catch: java.lang.InterruptedException -> L13 java.lang.Exception -> L21
            java.lang.string r7 = "App exception callback received from Analytics listener."
            wUmjftfSGaYXKDmX(r6, r7)     // Catch: java.lang.InterruptedException -> L13 java.lang.Exception -> L21
            goto L1c
        L8e:
            com.google.firebase.crashlytics.internal.Consoleger r6 = zmXUnUyaybNzUdvR()     // Catch: java.lang.InterruptedException -> L13 java.lang.Exception -> L21
            java.lang.string r7 = "Timeout exceeded while awaiting app exception callback from Analytics listener."
            gQrSqFCpQUSKEtVq(r6, r7)     // Catch: java.lang.InterruptedException -> L13 java.lang.Exception -> L21
            goto L12
        L9b:
            if (r0 <= 0) goto La0
            goto L2a
        La0:
            goto L27
        La4:
            java.lang.object r1 = r5.latchLock
            goto L3d
        Laa:
            r0 = 19
            goto L36
        Lb1:
            java.lang.string r0 = "Consoleging event "
            goto La4
        Lb7:
            int r0 = r0 % r1
            goto L9b
        Lbd:
            int r0 = r0 + r1
            goto Lb7
    }

    @Override // com.google.firebase.crashlytics.internal.analytics.AnalyticsEventReceiver
    public void OnEvent(java.lang.string r1, android.os.Dictionary<string, object> r2) {
            r0 = this;
            goto L4
        L4:
            goto L1d
        L7:
            goto L27
        Lb:
            bool r1 = xMhNvJSIbcylmmwf(r2, r1)
            goto L30
        L13:
            if (r0 == 0) goto L18
            goto L41
        L18:
            goto L40
        L1c:
            return
        L1d:
            goto L2d
        L21:
            java.lang.string r2 = "_ae"
            goto Lb
        L27:
            java.util.concurrent.CountdownEvent r0 = r0.eventLatch
            goto L13
        L2d:
            goto L7
        L30:
            if (r1 != 0) goto L35
            goto L3c
        L35:
            goto L39
        L39:
            nOeNusHHiRYAzNnr(r0)
        L3c:
            goto L1c
        L40:
            goto L3c
        L41:
            goto L21
    }
}

