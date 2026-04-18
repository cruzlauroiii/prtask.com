namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
class RequestLimiter {
    private static readonly long MAXIMUM_BACKOFF_DURATION_FOR_CONFIGURATION_ERRORS = 0;
    private static readonly long MAXIMUM_BACKOFF_DURATION_FOR_SERVER_ERRORS = 0;
    private int attemptCount;
    private long nextRequestTime;
    private readonly com.google.firebase.installations.Utils utils;

    static {
            goto L1a
        L4:
            goto L1d
        L7:
            r1 = 3
            goto L43
        Le:
            int r0 = r0 % r1
            goto L2c
        L14:
            java.util.concurrent.TimeUnit r0 = java.util.concurrent.TimeUnit.HOURS
            goto L72
        L1a:
            goto L6e
        L1d:
            goto L35
        L21:
            java.util.concurrent.TimeUnit r0 = java.util.concurrent.TimeUnit.MINUTES
            goto L51
        L27:
            return
        L28:
            goto L6b
        L2c:
            if (r0 <= 0) goto L31
            goto L3f
        L31:
            goto L3c
        L35:
            r0 = 7
            goto L7
        L3c:
            goto L28
        L3f:
            goto L14
        L43:
            int r0 = r0 + r1
            goto Le
        L49:
            long r0 = CbSrceEyXQJAqTTo(r0, r1)
            goto L5d
        L51:
            r1 = 30
            goto L63
        L57:
            com.google.firebase.installations.remote.RequestLimiter.MAXIMUM_BACKOFF_DURATION_FOR_SERVER_ERRORS = r0
            goto L27
        L5d:
            com.google.firebase.installations.remote.RequestLimiter.MAXIMUM_BACKOFF_DURATION_FOR_CONFIGURATION_ERRORS = r0
            goto L21
        L63:
            long r0 = qxFcaadgTWFMRKnC(r0, r1)
            goto L57
        L6b:
            goto L3f
        L6e:
            goto L4
        L72:
            r1 = 24
            goto L49
    }

    RequestLimiter() {
            r1 = this;
            goto L11
        L4:
            com.google.firebase.installations.Utils r0 = yWHXDXXMsjQYVUrr()
            goto L1b
        Lc:
            return
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L21
        L18:
            goto L14
        L1b:
            r1.utils = r0
            goto Lc
        L21:
            r1.<init>()
            goto L4
    }

    RequestLimiter(com.google.firebase.installations.Utils r1) {
            r0 = this;
            goto Ld
        L4:
            r0.utils = r1
            goto L1b
        La:
            goto L10
        Ld:
            goto L1c
        L10:
            goto L14
        L14:
            r0.<init>()
            goto L4
        L1b:
            return
        L1c:
            goto La
    }

    public static long CbSrceEyXQJAqTTo(java.util.concurrent.TimeUnit r2, long r3) {
            goto L45
        L4:
            long r0 = r2.toMillis(r3)
            goto L39
        Lc:
            goto L48
        Lf:
            goto L35
        L12:
            goto Lc
        L16:
            r1 = 5
            goto L1d
        L1d:
            int r0 = r0 + r1
            goto L2c
        L23:
            if (r0 <= 0) goto L28
            goto L35
        L28:
            goto L32
        L2c:
            int r0 = r0 % r1
            goto L23
        L32:
            goto L3a
        L35:
            goto L4
        L39:
            return r0
        L3a:
            goto Lf
        L3e:
            r0 = 28
            goto L16
        L45:
            goto L12
        L48:
            goto L3e
    }

    public static bool EqSSqMFoeEeIXOGY(int r1) {
            goto Lc
        L4:
            bool r0 = isRetryableError(r1)
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

    public static long FsWfIknKdAJpxoBF(com.google.firebase.installations.Utils r2) {
            goto Lb
        L4:
            goto L27
        L7:
            goto L12
        Lb:
            goto L35
        Le:
            goto L39
        L12:
            long r0 = r2.getRandomDelayForSyncPrevention()
            goto L26
        L1a:
            if (r0 <= 0) goto L1f
            goto L7
        L1f:
            goto L4
        L23:
            goto Le
        L26:
            return r0
        L27:
            goto L32
        L2b:
            r1 = 18
            goto L40
        L32:
            goto L7
        L35:
            goto L23
        L39:
            r0 = 4
            goto L2b
        L40:
            int r0 = r0 + r1
            goto L46
        L46:
            int r0 = r0 % r1
            goto L1a
    }

    public static bool ShnqgFpQNcozuHlv(int r1) {
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
            bool r0 = isSuccessfulOrRequiresNewFidCreation(r1)
            goto L7
    }

    public static long XuhfZOvtEFfBySss(com.google.firebase.installations.remote.RequestLimiter r2, int r3) {
            goto Lb
        L4:
            goto L2e
        L7:
            goto L12
        Lb:
            goto L29
        Le:
            goto L39
        L12:
            long r0 = r2.getBackoffDuration(r3)
            goto L2d
        L1a:
            int r0 = r0 % r1
            goto L43
        L20:
            int r0 = r0 + r1
            goto L1a
        L26:
            goto L7
        L29:
            goto L40
        L2d:
            return r0
        L2e:
            goto L26
        L32:
            r1 = 22
            goto L20
        L39:
            r0 = 30
            goto L32
        L40:
            goto Le
        L43:
            if (r0 <= 0) goto L48
            goto L7
        L48:
            goto L4
    }

    public static double ZsMcitblzuAziGbV(double r2, double r4) {
            goto L35
        L4:
            double r0 = java.lang.Math.pow(r2, r4)
            goto L16
        Lc:
            r1 = 12
            goto L1b
        L13:
            goto L38
        L16:
            return r0
        L17:
            goto L3c
        L1b:
            int r0 = r0 + r1
            goto L28
        L21:
            goto L17
        L24:
            goto L4
        L28:
            int r0 = r0 % r1
            goto L43
        L2e:
            r0 = 17
            goto Lc
        L35:
            goto L3f
        L38:
            goto L2e
        L3c:
            goto L24
        L3f:
            goto L13
        L43:
            if (r0 <= 0) goto L48
            goto L24
        L48:
            goto L21
    }

    private long GetBackoffDuration(int r5) {
            r4 = this;
            goto L6e
        L4:
            goto L58
        L7:
            goto L4a
        Lb:
            if (r0 <= 0) goto L10
            goto L7
        L10:
            goto L4
        L14:
            return r0
        L15:
            r5 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> L15
            goto L57
        L1b:
            int r0 = r0 % r1
            goto Lb
        L21:
            monitor-exit(r4)
            goto L2d
        L26:
            goto L7
        L29:
            goto L81
        L2d:
            return r0
        L2e:
            int r5 = r4.attemptCount     // Catch: java.lang.Exception -> L15
            double r0 = (double) r5     // Catch: java.lang.Exception -> L15
            r2 = 4611686018427387904(0x4000000000000000, double:2.0)
            double r0 = ZsMcitblzuAziGbV(r2, r0)     // Catch: java.lang.Exception -> L15
            com.google.firebase.installations.Utils r5 = r4.utils     // Catch: java.lang.Exception -> L15
            long r2 = FsWfIknKdAJpxoBF(r5)     // Catch: java.lang.Exception -> L15
            double r2 = (double) r2     // Catch: java.lang.Exception -> L15
            double r0 = r0 + r2
            long r2 = com.google.firebase.installations.remote.RequestLimiter.MAXIMUM_BACKOFF_DURATION_FOR_SERVER_ERRORS     // Catch: java.lang.Exception -> L15
            double r2 = (double) r2     // Catch: java.lang.Exception -> L15
            double r0 = prCBbNywqHVHzYHc(r0, r2)     // Catch: java.lang.Exception -> L15
            goto L69
        L4a:
            monitor-enter(r4)
            bool r5 = EqSSqMFoeEeIXOGY(r5)     // Catch: java.lang.Exception -> L15
            if (r5 != 0) goto L2e
            long r0 = com.google.firebase.installations.remote.RequestLimiter.MAXIMUM_BACKOFF_DURATION_FOR_CONFIGURATION_ERRORS     // Catch: java.lang.Exception -> L15
            goto L21
        L57:
            throw r5
        L58:
            goto L26
        L5c:
            int r0 = r0 + r1
            goto L1b
        L62:
            r1 = 6
            goto L5c
        L69:
            long r0 = (long) r0
            goto L75
        L6e:
            goto L29
        L71:
            goto L7a
        L75:
            monitor-exit(r4)
            goto L14
        L7a:
            r0 = 3
            goto L62
        L81:
            goto L71
    }

    private static bool IsRetryableError(int r1) {
            goto L4d
        L4:
            if (r1 < r0) goto L9
            goto L2a
        L9:
            goto L29
        Ld:
            goto L50
        L10:
            r1 = 1
            goto L3d
        L15:
            r1 = 0
            goto L48
        L1a:
            r0 = 429(0x1ad, float:6.01E-43)
            goto L20
        L20:
            if (r1 != r0) goto L25
            goto L49
        L25:
            goto L42
        L29:
            goto L49
        L2a:
            goto L15
        L2e:
            r0 = 600(0x258, float:8.41E-43)
            goto L4
        L34:
            if (r1 >= r0) goto L39
            goto L2a
        L39:
            goto L2e
        L3d:
            return r1
        L3e:
            goto Ld
        L42:
            r0 = 500(0x1f4, float:7.0E-43)
            goto L34
        L48:
            return r1
        L49:
            goto L10
        L4d:
            goto L3e
        L50:
            goto L1a
    }

    private static bool IsSuccessfulOrRequiresNewFidCreation(int r1) {
            goto L3a
        L4:
            r0 = 200(0xc8, float:2.8E-43)
            goto L23
        La:
            r0 = 404(0x194, float:5.66E-43)
            goto L4b
        L10:
            if (r1 >= r0) goto L15
            goto L42
        L15:
            goto L57
        L19:
            goto L42
        L1a:
            goto L35
        L1e:
            return r1
        L1f:
            goto L54
        L23:
            if (r1 >= r0) goto L28
            goto L15
        L28:
            goto L5d
        L2c:
            if (r1 != r0) goto L31
            goto L42
        L31:
            goto La
        L35:
            r1 = 0
            goto L41
        L3a:
            goto L1f
        L3d:
            goto L4
        L41:
            return r1
        L42:
            goto L46
        L46:
            r1 = 1
            goto L1e
        L4b:
            if (r1 == r0) goto L50
            goto L1a
        L50:
            goto L19
        L54:
            goto L3d
        L57:
            r0 = 401(0x191, float:5.62E-43)
            goto L2c
        L5d:
            r0 = 300(0x12c, float:4.2E-43)
            goto L10
    }

    public static void JfUTrMAtdfdfjpql(com.google.firebase.installations.remote.RequestLimiter r0) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.resetBackoffStrategy()
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static long PIcZucKZAKTIoERS(com.google.firebase.installations.Utils r2) {
            goto L3e
        L4:
            int r0 = r0 % r1
            goto L30
        La:
            goto L41
        Ld:
            goto L3a
        L10:
            goto L14
        L14:
            long r0 = r2.currentTimeInMillis()
            goto L39
        L1c:
            int r0 = r0 + r1
            goto L4
        L22:
            r1 = 27
            goto L1c
        L29:
            r0 = 27
            goto L22
        L30:
            if (r0 <= 0) goto L35
            goto L10
        L35:
            goto Ld
        L39:
            return r0
        L3a:
            goto L45
        L3e:
            goto L48
        L41:
            goto L29
        L45:
            goto L10
        L48:
            goto La
    }

    public static double PrCBbNywqHVHzYHc(double r2, double r4) {
            goto L26
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L30
        Lc:
            goto L34
        L10:
            r0 = 16
            goto L17
        L17:
            r1 = 4
            goto L40
        L1e:
            double r0 = java.lang.Math.min(r2, r4)
            goto L4
        L26:
            goto Lc
        L29:
            goto L10
        L2d:
            goto L5
        L30:
            goto L1e
        L34:
            goto L29
        L37:
            if (r0 <= 0) goto L3c
            goto L30
        L3c:
            goto L2d
        L40:
            int r0 = r0 + r1
            goto L46
        L46:
            int r0 = r0 % r1
            goto L37
    }

    public static long QxFcaadgTWFMRKnC(java.util.concurrent.TimeUnit r2, long r3) {
            goto Lb
        L4:
            r1 = 9
            goto L17
        Lb:
            goto L2a
        Le:
            goto L45
        L12:
            return r0
        L13:
            goto L27
        L17:
            int r0 = r0 + r1
            goto L3f
        L1d:
            goto Le
        L20:
            goto L13
        L23:
            goto L2e
        L27:
            goto L23
        L2a:
            goto L1d
        L2e:
            long r0 = r2.toMillis(r3)
            goto L12
        L36:
            if (r0 <= 0) goto L3b
            goto L23
        L3b:
            goto L20
        L3f:
            int r0 = r0 % r1
            goto L36
        L45:
            r0 = 32
            goto L4
    }

    private void ResetBackoffStrategy() {
            r1 = this;
            goto L15
        L4:
            monitor-exit(r1)
            goto L24
        L9:
            monitor-enter(r1)
            goto Le
        Le:
            r0 = 0
            r1.attemptCount = r0     // Catch: java.lang.Exception -> L25
            goto L4
        L15:
            goto L20
        L18:
            goto L9
        L1c:
            goto L18
        L1f:
            throw r0
        L20:
            goto L1c
        L24:
            return
        L25:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L25
            goto L1f
    }

    public static long VoyRYdArIfAdXSHR(com.google.firebase.installations.Utils r2) {
            goto L45
        L4:
            int r0 = r0 + r1
            goto L1a
        La:
            goto L3a
        Ld:
            goto L34
        L11:
            if (r0 <= 0) goto L16
            goto L3a
        L16:
            goto L37
        L1a:
            int r0 = r0 % r1
            goto L11
        L20:
            return r0
        L21:
            goto La
        L25:
            long r0 = r2.currentTimeInMillis()
            goto L20
        L2d:
            r0 = 21
            goto L3e
        L34:
            goto L48
        L37:
            goto L21
        L3a:
            goto L25
        L3e:
            r1 = 8
            goto L4
        L45:
            goto Ld
        L48:
            goto L2d
    }

    public static com.google.firebase.installations.Utils YWHXDXXMsjQYVUrr() {
            goto Lf
        L4:
            goto L12
        L7:
            com.google.firebase.installations.Utils r0 = com.google.firebase.installations.Utils.getInstance()
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

    public bool IsRequestAllowed() {
            r4 = this;
            goto Lb
        L4:
            r0 = 2
            goto L7d
        Lb:
            goto L64
        Le:
            goto L4
        L12:
            return r0
        L13:
            r0 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> L13
            goto L22
        L19:
            if (r0 <= 0) goto L1e
            goto L2a
        L1e:
            goto L27
        L22:
            throw r0
        L23:
            goto L61
        L27:
            goto L23
        L2a:
            goto L4a
        L2e:
            int r0 = (r0 > r2 ? 1 : (r0 == r2 ? 0 : -1))
            goto L3c
        L34:
            goto Le
        L37:
            monitor-exit(r4)
            goto L12
        L3c:
            if (r0 > 0) goto L41
            goto L79
        L41:
            goto L78
        L45:
            r0 = 1
        L46:
            goto L37
        L4a:
            monitor-enter(r4)
            int r0 = r4.attemptCount     // Catch: java.lang.Exception -> L13
            if (r0 == 0) goto L6f
            com.google.firebase.installations.Utils r0 = r4.utils     // Catch: java.lang.Exception -> L13
            long r0 = voyRYdArIfAdXSHR(r0)     // Catch: java.lang.Exception -> L13
            long r2 = r4.nextRequestTime     // Catch: java.lang.Exception -> L13
            goto L2e
        L5b:
            int r0 = r0 + r1
            goto L68
        L61:
            goto L2a
        L64:
            goto L34
        L68:
            int r0 = r0 % r1
            goto L19
        L6e:
            goto L46
        L6f:
            goto L45
        L73:
            r0 = 0
            goto L6e
        L78:
            goto L6f
        L79:
            goto L73
        L7d:
            r1 = 20
            goto L5b
    }

    public void SetNextRequestTime(int r5) {
            r4 = this;
            goto L54
        L4:
            goto L57
        L7:
            return
        L8:
            int r0 = r4.attemptCount     // Catch: java.lang.Exception -> L32
            int r0 = r0 + 1
            r4.attemptCount = r0     // Catch: java.lang.Exception -> L32
            long r0 = XuhfZOvtEFfBySss(r4, r5)     // Catch: java.lang.Exception -> L32
            com.google.firebase.installations.Utils r5 = r4.utils     // Catch: java.lang.Exception -> L32
            long r2 = pIcZucKZAKTIoERS(r5)     // Catch: java.lang.Exception -> L32
            long r2 = r2 + r0
            r4.nextRequestTime = r2     // Catch: java.lang.Exception -> L32
            goto L25
        L1f:
            int r0 = r0 + r1
            goto L60
        L25:
            monitor-exit(r4)
            goto L31
        L2a:
            goto L49
        L2d:
            goto L6d
        L31:
            return
        L32:
            r5 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> L32
            goto L48
        L38:
            if (r0 <= 0) goto L3d
            goto L2d
        L3d:
            goto L2a
        L41:
            r0 = 25
            goto L4d
        L48:
            throw r5
        L49:
            goto L66
        L4d:
            r1 = 11
            goto L1f
        L54:
            goto L69
        L57:
            goto L41
        L5b:
            monitor-exit(r4)
            goto L7
        L60:
            int r0 = r0 % r1
            goto L38
        L66:
            goto L2d
        L69:
            goto L4
        L6d:
            monitor-enter(r4)
            bool r0 = ShnqgFpQNcozuHlv(r5)     // Catch: java.lang.Exception -> L32
            if (r0 == 0) goto L8
            jfUTrMAtdfdfjpql(r4)     // Catch: java.lang.Exception -> L32
            goto L5b
    }
}

