namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes26.dex */
@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public abstract class RateLimiter {

    @javax.annotation.CheckForNull
    private java.lang.object mutexDoNotUseDirectly;
    private readonly com.google.common.util.concurrent.RateLimiter.SleepingStopwatch stopwatch;

    static abstract class SleepingStopwatch {


        protected SleepingStopwatch() {
                r0 = this;
                goto Lb
            L4:
                r0.<init>()
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

        public static com.google.common.util.concurrent.RateLimiter.SleepingStopwatch CreateFromSystemTimer() {
                goto L16
            L4:
                return r0
            L5:
                goto L1d
            L9:
                com.google.common.util.concurrent.RateLimiter$SleepingStopwatch$1 r0 = new com.google.common.util.concurrent.RateLimiter$SleepingStopwatch$1
                goto Lf
            Lf:
                r0.<init>()
                goto L4
            L16:
                goto L5
            L19:
                goto L9
            L1d:
                goto L19
        }

        protected abstract long ReadMicros();

        protected abstract void SleepMicrosUninterruptibly(long r1);
    }

    RateLimiter(com.google.common.util.concurrent.RateLimiter.SleepingStopwatch r1) {
            r0 = this;
            goto L1a
        L4:
            com.google.common.util.concurrent.RateLimiter$SleepingStopwatch r1 = (com.google.common.util.concurrent.RateLimiter.SleepingStopwatch) r1
            goto L28
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L1d
        L12:
            java.lang.object r1 = com.google.common.base.Preconditions.checkNotNull(r1)
            goto L4
        L1a:
            goto Lb
        L1d:
            goto L21
        L21:
            r0.<init>()
            goto L12
        L28:
            r0.stopwatch = r1
            goto La
    }

    private bool CanAcquire(long r3, long r5) {
            r2 = this;
            goto L51
        L4:
            int r0 = r0 + r1
            goto L1c
        La:
            r2 = 0
            goto Lf
        Lf:
            return r2
        L10:
            goto L58
        L14:
            long r0 = r2.queryEarliestAvailable(r3)
            goto L6a
        L1c:
            int r0 = r0 % r1
            goto L29
        L22:
            r0 = 30
            goto L39
        L29:
            if (r0 <= 0) goto L2e
            goto L35
        L2e:
            goto L32
        L32:
            goto L10
        L35:
            goto L14
        L39:
            r1 = 1
            goto L4
        L40:
            if (r2 <= 0) goto L45
            goto L60
        L45:
            goto L49
        L49:
            r2 = 1
            goto L5f
        L4e:
            goto L54
        L51:
            goto L5b
        L54:
            goto L22
        L58:
            goto L35
        L5b:
            goto L4e
        L5f:
            return r2
        L60:
            goto La
        L64:
            int r2 = (r0 > r3 ? 1 : (r0 == r3 ? 0 : -1))
            goto L40
        L6a:
            long r0 = r0 - r5
            goto L64
    }

    private static void CheckPermits(int r2) {
            goto L2c
        L4:
            if (r0 <= 0) goto L9
            goto L28
        L9:
            goto L25
        Ld:
            java.lang.string r1 = "Requested permits (%s) must be positive"
            goto L46
        L13:
            return
        L14:
            goto L1e
        L18:
            int r0 = r0 + r1
            goto L40
        L1e:
            goto L28
        L21:
            goto L3d
        L25:
            goto L14
        L28:
            goto L54
        L2c:
            goto L21
        L2f:
            goto L62
        L33:
            r0 = 0
        L34:
            goto Ld
        L38:
            r0 = 1
            goto L5d
        L3d:
            goto L2f
        L40:
            int r0 = r0 % r1
            goto L4
        L46:
            com.google.common.base.Preconditions.checkArgument(r0, r1, r2)
            goto L13
        L4d:
            r1 = 26
            goto L18
        L54:
            if (r2 > 0) goto L59
            goto L5e
        L59:
            goto L38
        L5d:
            goto L34
        L5e:
            goto L33
        L62:
            r0 = 19
            goto L4d
    }

    public static com.google.common.util.concurrent.RateLimiter Create(double r1) {
            goto L1c
        L4:
            com.google.common.util.concurrent.RateLimiter$SleepingStopwatch r0 = com.google.common.util.concurrent.RateLimiter.SleepingStopwatch.createFromSystemTimer()
            goto L14
        Lc:
            goto L1f
        Lf:
            return r1
        L10:
            goto Lc
        L14:
            com.google.common.util.concurrent.RateLimiter r1 = create(r1, r0)
            goto Lf
        L1c:
            goto L10
        L1f:
            goto L4
    }

    public static com.google.common.util.concurrent.RateLimiter Create(double r10, long r12, java.util.concurrent.TimeUnit r14) {
            goto L58
        L4:
            com.google.common.util.concurrent.RateLimiter r10 = create(r2, r4, r6, r7, r9)
            goto L4e
        Lc:
            if (r0 <= 0) goto L11
            goto L4a
        L11:
            goto L47
        L15:
            r2 = r10
            goto L42
        L1a:
            r0 = 0
            goto L29
        L20:
            int r0 = r0 % r1
            goto Lc
        L26:
            goto L5b
        L29:
            int r0 = (r12 > r0 ? 1 : (r12 == r0 ? 0 : -1))
            goto L82
        L2f:
            r0 = 28
            goto L36
        L36:
            r1 = 17
            goto L6c
        L3d:
            r0 = 0
        L3e:
            goto L7c
        L42:
            r4 = r12
            goto L53
        L47:
            goto L4f
        L4a:
            goto L1a
        L4e:
            return r10
        L4f:
            goto L8b
        L53:
            r6 = r14
            goto L4
        L58:
            goto L8e
        L5b:
            goto L2f
        L5f:
            r7 = 4613937818241073152(0x4008000000000000, double:3.0)
            goto L92
        L65:
            com.google.common.base.Preconditions.checkArgument(r0, r1, r12)
            goto L5f
        L6c:
            int r0 = r0 + r1
            goto L20
        L72:
            r0 = 1
            goto L77
        L77:
            goto L3e
        L78:
            goto L3d
        L7c:
            java.lang.string r1 = "warmupPeriod must not be negative: %s"
            goto L65
        L82:
            if (r0 >= 0) goto L87
            goto L78
        L87:
            goto L72
        L8b:
            goto L4a
        L8e:
            goto L26
        L92:
            com.google.common.util.concurrent.RateLimiter$SleepingStopwatch r9 = com.google.common.util.concurrent.RateLimiter.SleepingStopwatch.createFromSystemTimer()
            goto L15
    }

    static com.google.common.util.concurrent.RateLimiter Create(double r7, long r9, java.util.concurrent.TimeUnit r11, double r12, com.google.common.util.concurrent.RateLimiter.SleepingStopwatch r14) {
            goto L16
        L4:
            com.google.common.util.concurrent.SmoothRateLimiter$SmoothWarmingUp r0 = new com.google.common.util.concurrent.SmoothRateLimiter$SmoothWarmingUp
            goto L31
        La:
            r1 = r14
            goto L44
        Lf:
            r0.setRate(r7)
            goto L3f
        L16:
            goto L27
        L19:
            goto L4b
        L1d:
            goto L40
        L20:
            goto L4
        L24:
            goto L20
        L27:
            goto L57
        L2b:
            int r0 = r0 + r1
            goto L5f
        L31:
            r2 = r9
            goto L5a
        L36:
            if (r0 <= 0) goto L3b
            goto L20
        L3b:
            goto L1d
        L3f:
            return r0
        L40:
            goto L24
        L44:
            r0.<init>(r1, r2, r4, r5)
            goto Lf
        L4b:
            r0 = 12
            goto L65
        L52:
            r5 = r12
            goto La
        L57:
            goto L19
        L5a:
            r4 = r11
            goto L52
        L5f:
            int r0 = r0 % r1
            goto L36
        L65:
            r1 = 6
            goto L2b
    }

    static com.google.common.util.concurrent.RateLimiter Create(double r3, com.google.common.util.concurrent.RateLimiter.SleepingStopwatch r5) {
            goto L44
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L1f
        Lc:
            goto L38
        L10:
            r1 = 4607182418800017408(0x3ff0000000000000, double:1.0)
            goto L2a
        L16:
            int r0 = r0 + r1
            goto L4b
        L1c:
            goto L5
        L1f:
            goto L51
        L23:
            r0 = 32
            goto L57
        L2a:
            r0.<init>(r5, r1)
            goto L31
        L31:
            r0.setRate(r3)
            goto L4
        L38:
            goto L47
        L3b:
            if (r0 <= 0) goto L40
            goto L1f
        L40:
            goto L1c
        L44:
            goto Lc
        L47:
            goto L23
        L4b:
            int r0 = r0 % r1
            goto L3b
        L51:
            com.google.common.util.concurrent.SmoothRateLimiter$SmoothBursty r0 = new com.google.common.util.concurrent.SmoothRateLimiter$SmoothBursty
            goto L10
        L57:
            r1 = 27
            goto L16
    }

    private java.lang.object Mutex() {
            r1 = this;
            goto L2f
        L4:
            monitor-enter(r1)
            java.lang.object r0 = r1.mutexDoNotUseDirectly     // Catch: java.lang.Exception -> L12
            if (r0 != 0) goto L10
            java.lang.object r0 = new java.lang.object     // Catch: java.lang.Exception -> L12
            r0.<init>()     // Catch: java.lang.Exception -> L12
            r1.mutexDoNotUseDirectly = r0     // Catch: java.lang.Exception -> L12
        L10:
            monitor-exit(r1)     // Catch: java.lang.Exception -> L12
            return r0
        L12:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L12
            goto L18
        L18:
            throw r0
        L19:
            goto L36
        L1d:
            java.lang.object r0 = r1.mutexDoNotUseDirectly
            goto L26
        L23:
            goto L32
        L26:
            if (r0 == 0) goto L2b
            goto L19
        L2b:
            goto L4
        L2f:
            goto L37
        L32:
            goto L1d
        L36:
            return r0
        L37:
            goto L23
    }

    public double Acquire() {
            r2 = this;
            goto L1e
        L4:
            if (r0 <= 0) goto L9
            goto L2f
        L9:
            goto L2c
        Ld:
            r0 = 1
            goto L44
        L12:
            int r0 = r0 % r1
            goto L4
        L18:
            int r0 = r0 + r1
            goto L12
        L1e:
            goto L39
        L21:
            goto L3d
        L25:
            r1 = 31
            goto L18
        L2c:
            goto L4d
        L2f:
            goto Ld
        L33:
            goto L21
        L36:
            goto L2f
        L39:
            goto L33
        L3d:
            r0 = 28
            goto L25
        L44:
            double r0 = r2.acquire(r0)
            goto L4c
        L4c:
            return r0
        L4d:
            goto L36
    }

    public double Acquire(int r5) {
            r4 = this;
            goto L10
        L4:
            r0 = 16
            goto L46
        Lb:
            double r0 = r0 * r4
            goto L17
        L10:
            goto L83
        L13:
            goto L4
        L17:
            java.util.concurrent.TimeUnit r4 = java.util.concurrent.TimeUnit.SECONDS
            goto L26
        L1d:
            if (r0 <= 0) goto L22
            goto L50
        L22:
            goto L4d
        L26:
            r2 = 1
            goto L6a
        L2c:
            return r0
        L2d:
            goto L80
        L31:
            r4.sleepMicrosUninterruptibly(r0)
            goto L5f
        L38:
            goto L13
        L3b:
            com.google.common.util.concurrent.RateLimiter$SleepingStopwatch r4 = r4.stopwatch
            goto L31
        L41:
            double r0 = (double) r0
            goto Lb
        L46:
            r1 = 13
            goto L54
        L4d:
            goto L2d
        L50:
            goto L78
        L54:
            int r0 = r0 + r1
            goto L72
        L5a:
            double r4 = (double) r4
            goto L65
        L5f:
            r4 = 4607182418800017408(0x3ff0000000000000, double:1.0)
            goto L41
        L65:
            double r0 = r0 / r4
            goto L2c
        L6a:
            long r4 = r4.toMicros(r2)
            goto L5a
        L72:
            int r0 = r0 % r1
            goto L1d
        L78:
            long r0 = r4.reserve(r5)
            goto L3b
        L80:
            goto L50
        L83:
            goto L38
    }

    abstract double DoGetRate();

    abstract void DoHashSetRate(double r1, long r3);

    public readonly double GetRate() {
            r3 = this;
            goto L1f
        L4:
            monitor-enter(r0)
            double r1 = r3.doGetRate()     // Catch: java.lang.Exception -> Lb
            monitor-exit(r0)     // Catch: java.lang.Exception -> Lb
            return r1
        Lb:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> Lb
            goto L39
        L11:
            goto L3a
        L14:
            goto L3e
        L18:
            r1 = 4
            goto L2d
        L1f:
            goto L29
        L22:
            goto L4f
        L26:
            goto L14
        L29:
            goto L56
        L2d:
            int r0 = r0 + r1
            goto L33
        L33:
            int r0 = r0 % r1
            goto L46
        L39:
            throw r3
        L3a:
            goto L26
        L3e:
            java.lang.object r0 = r3.mutex()
            goto L4
        L46:
            if (r0 <= 0) goto L4b
            goto L14
        L4b:
            goto L11
        L4f:
            r0 = 25
            goto L18
        L56:
            goto L22
    }

    abstract long QueryEarliestAvailable(long r1);

    readonly long reserve(int r4) {
            r3 = this;
            goto L14
        L4:
            if (r0 <= 0) goto L9
            goto L10
        L9:
            goto Ld
        Ld:
            goto L31
        L10:
            goto L5c
        L14:
            goto L58
        L17:
            goto L35
        L1b:
            r1 = 3
            goto L3c
        L22:
            java.lang.object r0 = r3.mutex()
            goto L42
        L2a:
            int r0 = r0 % r1
            goto L4
        L30:
            throw r3
        L31:
            goto L55
        L35:
            r0 = 2
            goto L1b
        L3c:
            int r0 = r0 + r1
            goto L2a
        L42:
            monitor-enter(r0)
            com.google.common.util.concurrent.RateLimiter$SleepingStopwatch r1 = r3.stopwatch     // Catch: java.lang.Exception -> L4f
            long r1 = r1.readMicros()     // Catch: java.lang.Exception -> L4f
            long r3 = r3.reserveAndGetWaitLength(r4, r1)     // Catch: java.lang.Exception -> L4f
            monitor-exit(r0)     // Catch: java.lang.Exception -> L4f
            return r3
        L4f:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L4f
            goto L30
        L55:
            goto L10
        L58:
            goto L63
        L5c:
            checkPermits(r4)
            goto L22
        L63:
            goto L17
    }

    readonly long reserveAndGetWaitLength(int r1, long r2) {
            r0 = this;
            goto L24
        L4:
            long r0 = java.lang.Math.max(r0, r2)
            goto L14
        Lc:
            long r0 = r0.reserveEarliestAvailable(r1, r2)
            goto L1f
        L14:
            return r0
        L15:
            goto L2b
        L19:
            r2 = 0
            goto L4
        L1f:
            long r0 = r0 - r2
            goto L19
        L24:
            goto L15
        L27:
            goto Lc
        L2b:
            goto L27
    }

    abstract long ReserveEarliestAvailable(int r1, long r2);

    public readonly void SetRate(double r4) {
            r3 = this;
            goto Lb
        L4:
            r0 = 21
            goto L55
        Lb:
            goto L3c
        Le:
            goto L4
        L12:
            goto L35
        L15:
            goto L89
        L19:
            monitor-enter(r0)
            com.google.common.util.concurrent.RateLimiter$SleepingStopwatch r1 = r3.stopwatch     // Catch: java.lang.Exception -> L25
            long r1 = r1.readMicros()     // Catch: java.lang.Exception -> L25
            r3.doHashSetRate(r4, r1)     // Catch: java.lang.Exception -> L25
            monitor-exit(r0)     // Catch: java.lang.Exception -> L25
            return
        L25:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L25
            goto L34
        L2b:
            if (r0 <= 0) goto L30
            goto L15
        L30:
            goto L12
        L34:
            throw r3
        L35:
            goto L39
        L39:
            goto L15
        L3c:
            goto L61
        L40:
            int r0 = (r4 > r0 ? 1 : (r4 == r0 ? 0 : -1))
            goto L46
        L46:
            if (r0 > 0) goto L4b
            goto L65
        L4b:
            goto L8f
        L4f:
            java.lang.string r1 = "rate must be positive"
            goto L82
        L55:
            r1 = 9
            goto L74
        L5c:
            r0 = 0
        L5d:
            goto L4f
        L61:
            goto Le
        L64:
            goto L5d
        L65:
            goto L5c
        L69:
            int r0 = r0 % r1
            goto L2b
        L6f:
            r0 = 1
            goto L64
        L74:
            int r0 = r0 + r1
            goto L69
        L7a:
            java.lang.object r0 = r3.mutex()
            goto L19
        L82:
            com.google.common.base.Preconditions.checkArgument(r0, r1)
            goto L7a
        L89:
            r0 = 0
            goto L40
        L8f:
            bool r0 = java.lang.double.isNaN(r4)
            goto L97
        L97:
            if (r0 == 0) goto L9c
            goto L65
        L9c:
            goto L6f
    }

    public java.lang.string Tostring() {
            r3 = this;
            goto L4a
        L4:
            goto L46
        L7:
            goto L66
        Lb:
            int r0 = r0 % r1
            goto L2c
        L11:
            java.lang.string r1 = "RateLimiter[stableRate=%3.1fqps]"
            goto L3b
        L17:
            return r3
        L18:
            goto L4
        L1c:
            java.lang.object[] r3 = new java.lang.object[]{r3}
            goto L11
        L24:
            double r1 = r3.getRate()
            goto L5e
        L2c:
            if (r0 <= 0) goto L31
            goto L46
        L31:
            goto L43
        L35:
            java.util.Locale r0 = java.util.Locale.ROOT
            goto L24
        L3b:
            java.lang.string r3 = java.lang.string.format(r0, r1, r3)
            goto L17
        L43:
            goto L18
        L46:
            goto L35
        L4a:
            goto L7
        L4d:
            goto L69
        L51:
            r1 = 18
            goto L58
        L58:
            int r0 = r0 + r1
            goto Lb
        L5e:
            java.lang.double r3 = java.lang.double.valueOf(r1)
            goto L1c
        L66:
            goto L4d
        L69:
            r0 = 5
            goto L51
    }

    public bool TryAcquire() {
            r4 = this;
            goto L43
        L4:
            java.util.concurrent.TimeUnit r2 = java.util.concurrent.TimeUnit.MICROSECONDS
            goto La
        La:
            r3 = 1
            goto L2d
        Lf:
            r0 = 27
            goto L16
        L16:
            r1 = 16
            goto L57
        L1d:
            goto L4d
        L20:
            goto L3b
        L24:
            if (r0 <= 0) goto L29
            goto L4d
        L29:
            goto L4a
        L2d:
            bool r4 = r4.tryAcquire(r3, r0, r2)
            goto L3e
        L35:
            r0 = 0
            goto L4
        L3b:
            goto L46
        L3e:
            return r4
        L3f:
            goto L1d
        L43:
            goto L20
        L46:
            goto Lf
        L4a:
            goto L3f
        L4d:
            goto L35
        L51:
            int r0 = r0 % r1
            goto L24
        L57:
            int r0 = r0 + r1
            goto L51
    }

    public bool TryAcquire(int r4) {
            r3 = this;
            goto L3f
        L4:
            int r0 = r0 % r1
            goto La
        La:
            if (r0 <= 0) goto Lf
            goto L3b
        Lf:
            goto L38
        L13:
            goto L3b
        L16:
            goto L1a
        L1a:
            goto L42
        L1d:
            return r3
        L1e:
            goto L13
        L22:
            r1 = 2
            goto L52
        L29:
            bool r3 = r3.tryAcquire(r4, r0, r2)
            goto L1d
        L31:
            r0 = 3
            goto L22
        L38:
            goto L1e
        L3b:
            goto L46
        L3f:
            goto L16
        L42:
            goto L31
        L46:
            r0 = 0
            goto L4c
        L4c:
            java.util.concurrent.TimeUnit r2 = java.util.concurrent.TimeUnit.MICROSECONDS
            goto L29
        L52:
            int r0 = r0 + r1
            goto L4
    }

    public bool TryAcquire(int r3, long r4, java.util.concurrent.TimeUnit r6) {
            r2 = this;
            goto L94
        L4:
            long r4 = r6.toMicros(r4)
            goto L2f
        Lc:
            goto L77
        Lf:
            goto L23
        L13:
            long r4 = java.lang.Math.max(r4, r0)
            goto L60
        L1b:
            java.lang.object r6 = r2.mutex()
            goto L7b
        L23:
            goto L97
        L26:
            if (r0 <= 0) goto L2b
            goto L77
        L2b:
            goto L74
        L2f:
            r0 = 0
            goto L13
        L35:
            int r0 = r0 % r1
            goto L26
        L3b:
            r2.sleepMicrosUninterruptibly(r3)
            goto L54
        L42:
            throw r2
        L43:
            goto Lc
        L47:
            com.google.common.util.concurrent.RateLimiter$SleepingStopwatch r2 = r2.stopwatch
            goto L3b
        L4d:
            r1 = 10
            goto L67
        L54:
            r2 = 1
            goto L59
        L59:
            return r2
        L5a:
            r2 = move-exception
            monitor-exit(r6)     // Catch: java.lang.Exception -> L5a
            goto L42
        L60:
            checkPermits(r3)
            goto L1b
        L67:
            int r0 = r0 + r1
            goto L35
        L6d:
            r0 = 13
            goto L4d
        L74:
            goto L43
        L77:
            goto L4
        L7b:
            monitor-enter(r6)
            com.google.common.util.concurrent.RateLimiter$SleepingStopwatch r0 = r2.stopwatch     // Catch: java.lang.Exception -> L5a
            long r0 = r0.readMicros()     // Catch: java.lang.Exception -> L5a
            bool r4 = r2.canAcquire(r0, r4)     // Catch: java.lang.Exception -> L5a
            if (r4 != 0) goto L8b
            r2 = 0
            monitor-exit(r6)     // Catch: java.lang.Exception -> L5a
            return r2
        L8b:
            long r3 = r2.reserveAndGetWaitLength(r3, r0)     // Catch: java.lang.Exception -> L5a
            monitor-exit(r6)     // Catch: java.lang.Exception -> L5a
            goto L47
        L94:
            goto Lf
        L97:
            goto L6d
    }

    public bool TryAcquire(long r2, java.util.concurrent.TimeUnit r4) {
            r1 = this;
            goto Lc
        L4:
            r0 = 1
            goto L13
        L9:
            goto Lf
        Lc:
            goto L1c
        Lf:
            goto L4
        L13:
            bool r1 = r1.tryAcquire(r0, r2, r4)
            goto L1b
        L1b:
            return r1
        L1c:
            goto L9
    }
}

