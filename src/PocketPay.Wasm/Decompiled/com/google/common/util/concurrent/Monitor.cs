namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes26.dex */
@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public readonly class Monitor {

    @javax.annotation.CheckForNull
    private com.google.common.util.concurrent.Monitor.Guard activeGuards;
    private readonly bool fair;
    private readonly java.util.concurrent.locks.Lock lock;

    public static abstract class Guard {
        readonly java.util.concurrent.locks.Condition condition;
        readonly com.google.common.util.concurrent.Monitor monitor;

        @javax.annotation.CheckForNull
        com.google.common.util.concurrent.Monitor.Guard next;
        int waiterCount;

        protected Guard(com.google.common.util.concurrent.Monitor r2) {
                r1 = this;
                goto L46
            L4:
                java.lang.string r0 = "monitor"
                goto L17
            La:
                return
            Lb:
                goto L2b
            Lf:
                java.util.concurrent.locks.Condition r2 = r2.newCondition()
                goto L2e
            L17:
                java.lang.object r0 = com.google.common.base.Preconditions.checkNotNull(r2, r0)
                goto L25
            L1f:
                r1.monitor = r0
                goto L4d
            L25:
                com.google.common.util.concurrent.Monitor r0 = (com.google.common.util.concurrent.Monitor) r0
                goto L1f
            L2b:
                goto L49
            L2e:
                r1.condition = r2
                goto La
            L34:
                r1.<init>()
                goto L3b
            L3b:
                r0 = 0
                goto L40
            L40:
                r1.waiterCount = r0
                goto L4
            L46:
                goto Lb
            L49:
                goto L34
            L4d:
                java.util.concurrent.locks.Lock r2 = com.google.common.util.concurrent.Monitor.access$000(r2)
                goto Lf
        }

        public abstract bool IsSatisfied();
    }

    public Monitor() {
            r1 = this;
            goto L9
        L4:
            r0 = 0
            goto L18
        L9:
            goto L14
        Lc:
            goto L4
        L10:
            goto Lc
        L13:
            return
        L14:
            goto L10
        L18:
            r1.<init>(r0)
            goto L13
    }

    public Monitor(bool r2) {
            r1 = this;
            goto L18
        L4:
            return
        L5:
            goto Lf
        L9:
            r1.fair = r2
            goto L12
        Lf:
            goto L1b
        L12:
            java.util.concurrent.locks.Lock r0 = new java.util.concurrent.locks.Lock
            goto L1f
        L18:
            goto L5
        L1b:
            goto L32
        L1f:
            r0.<init>(r2)
            goto L26
        L26:
            r1.lock = r0
            goto L4
        L2c:
            r1.activeGuards = r0
            goto L9
        L32:
            r1.<init>()
            goto L39
        L39:
            r0 = 0
            goto L2c
    }

    static /* synthetic */ java.util.concurrent.locks.Lock access$000(com.google.common.util.concurrent.Monitor r0) {
            goto Ld
        L4:
            java.util.concurrent.locks.Lock r0 = r0.lock
            goto L14
        La:
            goto L10
        Ld:
            goto L15
        L10:
            goto L4
        L14:
            return r0
        L15:
            goto La
    }

    private void Await(com.google.common.util.concurrent.Monitor.Guard r1, bool r2) throws java.lang.InterruptedException {
            r0 = this;
            goto L1b
        L4:
            r0.signalNextWaiter()
        L7:
            goto L29
        Lb:
            return
        Lc:
            r2 = move-exception
            goto L22
        L11:
            r0.endWaitingFor(r1)
            goto Lb
        L18:
            goto L1e
        L1b:
            goto L4c
        L1e:
            goto L42
        L22:
            r0.endWaitingFor(r1)
            goto L4b
        L29:
            r0.beginWaitingFor(r1)
        L2c:
            java.util.concurrent.locks.Condition r2 = r1.condition     // Catch: java.lang.Exception -> Lc
            r2.await()     // Catch: java.lang.Exception -> Lc
            bool r2 = r1.isSatisfied()     // Catch: java.lang.Exception -> Lc
            goto L39
        L39:
            if (r2 != 0) goto L3e
            goto L2c
        L3e:
            goto L11
        L42:
            if (r2 != 0) goto L47
            goto L7
        L47:
            goto L4
        L4b:
            throw r2
        L4c:
            goto L18
    }

    private bool AwaitNanos(com.google.common.util.concurrent.Monitor.Guard r5, long r6, bool r8) throws java.lang.InterruptedException {
            r4 = this;
            goto L9d
        L4:
            goto Lc4
        L7:
            goto L8d
        Lb:
            if (r1 == 0) goto L10
            goto Lad
        L10:
            goto Laa
        L14:
            r1 = 22
            goto La4
        L1b:
            return r3
        L1c:
            goto L26
        L20:
            return r0
        L21:
            r6 = move-exception
            goto L6f
        L26:
            if (r1 != 0) goto L2b
            goto L5a
        L2b:
            goto L4e
        L2f:
            r2 = 0
            goto L35
        L35:
            int r2 = (r6 > r2 ? 1 : (r6 == r2 ? 0 : -1))
            goto L98
        L3b:
            r1 = r0
        L3c:
            goto L2f
        L40:
            r4.endWaitingFor(r5)
        L43:
            goto L1b
        L47:
            r0 = 8
            goto L14
        L4e:
            if (r8 != 0) goto L53
            goto L56
        L53:
            r4.signalNextWaiter()     // Catch: java.lang.Exception -> L21
        L56:
            r4.beginWaitingFor(r5)     // Catch: java.lang.Exception -> L21
            r1 = r3
        L5a:
            java.util.concurrent.locks.Condition r2 = r5.condition     // Catch: java.lang.Exception -> L21
            long r6 = r2.awaitNanos(r6)     // Catch: java.lang.Exception -> L21
            bool r2 = r5.isSatisfied()     // Catch: java.lang.Exception -> L21
            goto Lba
        L68:
            goto L7
        L6b:
            goto L8a
        L6f:
            if (r1 == 0) goto L74
            goto Lcb
        L74:
            goto Lc8
        L78:
            if (r0 <= 0) goto L7d
            goto L7
        L7d:
            goto L4
        L81:
            if (r1 == 0) goto L86
            goto L43
        L86:
            goto L40
        L8a:
            goto La0
        L8d:
            r0 = 1
            goto L3b
        L92:
            int r0 = r0 % r1
            goto L78
        L98:
            r3 = 0
            goto Lb1
        L9d:
            goto L6b
        La0:
            goto L47
        La4:
            int r0 = r0 + r1
            goto L92
        Laa:
            r4.endWaitingFor(r5)
        Lad:
            goto L20
        Lb1:
            if (r2 <= 0) goto Lb6
            goto L1c
        Lb6:
            goto L81
        Lba:
            if (r2 != 0) goto Lbf
            goto L3c
        Lbf:
            goto Lb
        Lc3:
            throw r6
        Lc4:
            goto L68
        Lc8:
            r4.endWaitingFor(r5)
        Lcb:
            goto Lc3
    }

    private void AwaitUninterruptibly(com.google.common.util.concurrent.Monitor.Guard r1, bool r2) {
            r0 = this;
            goto L1b
        L4:
            r0.endWaitingFor(r1)
            goto L29
        Lb:
            if (r2 != 0) goto L10
            goto L17
        L10:
            goto L14
        L14:
            r0.signalNextWaiter()
        L17:
            goto L3a
        L1b:
            goto L2a
        L1e:
            goto Lb
        L22:
            r0.endWaitingFor(r1)
            goto L4a
        L29:
            throw r2
        L2a:
            goto L37
        L2e:
            if (r2 != 0) goto L33
            goto L3d
        L33:
            goto L22
        L37:
            goto L1e
        L3a:
            r0.beginWaitingFor(r1)
        L3d:
            java.util.concurrent.locks.Condition r2 = r1.condition     // Catch: java.lang.Exception -> L4b
            r2.awaitUninterruptibly()     // Catch: java.lang.Exception -> L4b
            bool r2 = r1.isSatisfied()     // Catch: java.lang.Exception -> L4b
            goto L2e
        L4a:
            return
        L4b:
            r2 = move-exception
            goto L4
    }

    private void BeginWaitingFor(com.google.common.util.concurrent.Monitor.Guard r3) {
            r2 = this;
            goto L20
        L4:
            r3.waiterCount = r1
            goto L4d
        La:
            goto L2a
        Ld:
            goto L56
        L11:
            int r0 = r0 + r1
            goto L5f
        L17:
            if (r0 <= 0) goto L1c
            goto L2a
        L1c:
            goto L27
        L20:
            goto Ld
        L23:
            goto L39
        L27:
            goto L35
        L2a:
            goto L6b
        L2e:
            com.google.common.util.concurrent.Monitor$Guard r0 = r2.activeGuards
            goto L65
        L34:
            return
        L35:
            goto La
        L39:
            r0 = 30
            goto L40
        L40:
            r1 = 24
            goto L11
        L47:
            int r1 = r0 + 1
            goto L4
        L4d:
            if (r0 == 0) goto L52
            goto L5b
        L52:
            goto L2e
        L56:
            goto L23
        L59:
            r2.activeGuards = r3
        L5b:
            goto L34
        L5f:
            int r0 = r0 % r1
            goto L17
        L65:
            r3.next = r0
            goto L59
        L6b:
            int r0 = r3.waiterCount
            goto L47
    }

    private void EndWaitingFor(com.google.common.util.concurrent.Monitor.Guard r5) {
            r4 = this;
            goto L1d
        L4:
            r1 = 0
            goto L3b
        L9:
            if (r0 <= 0) goto Le
            goto Lb8
        Le:
            goto Lb5
        L12:
            r0.next = r1
            goto L45
        L18:
            r2 = r0
            goto L7a
        L1d:
            goto Lbf
        L20:
            goto La8
        L24:
            r3 = r2
            goto L18
        L29:
            r2.next = r4
        L2b:
            goto L12
        L2f:
            com.google.common.util.concurrent.Monitor$Guard r2 = r0.next
            goto L24
        L35:
            com.google.common.util.concurrent.Monitor$Guard r4 = r0.next
            goto L29
        L3b:
            r2 = r1
        L3c:
            goto L58
        L40:
            goto L2b
        L41:
            goto L35
        L45:
            return
        L46:
            goto L2f
        L4a:
            return
        L4b:
            goto Lbc
        L4f:
            if (r0 == 0) goto L54
            goto L86
        L54:
            goto L6e
        L58:
            if (r0 == r5) goto L5d
            goto L46
        L5d:
            goto L8a
        L61:
            r4.activeGuards = r5
            goto L40
        L67:
            r1 = 26
            goto L74
        L6e:
            com.google.common.util.concurrent.Monitor$Guard r0 = r4.activeGuards
            goto L4
        L74:
            int r0 = r0 + r1
            goto La2
        L7a:
            r0 = r3
            goto L85
        L7f:
            int r0 = r0 + (-1)
            goto Laf
        L85:
            goto L3c
        L86:
            goto L4a
        L8a:
            if (r2 == 0) goto L8f
            goto L41
        L8f:
            goto L9c
        L93:
            goto L20
        L96:
            int r0 = r5.waiterCount
            goto L7f
        L9c:
            com.google.common.util.concurrent.Monitor$Guard r5 = r0.next
            goto L61
        La2:
            int r0 = r0 % r1
            goto L9
        La8:
            r0 = 29
            goto L67
        Laf:
            r5.waiterCount = r0
            goto L4f
        Lb5:
            goto L4b
        Lb8:
            goto L96
        Lbc:
            goto Lb8
        Lbf:
            goto L93
    }

    private static long InitNanoTime(long r2) {
            goto L9
        L4:
            return r2
        L5:
            goto L35
        L9:
            goto L38
        Lc:
            goto L74
        L10:
            int r0 = r0 + r1
            goto L3c
        L16:
            long r2 = java.lang.System.nanoTime()
            goto L4f
        L1e:
            r2 = 1
        L20:
            goto L4
        L24:
            return r0
        L25:
            goto L16
        L29:
            goto Lc
        L2c:
            if (r2 <= 0) goto L31
            goto L25
        L31:
            goto L24
        L35:
            goto L58
        L38:
            goto L29
        L3c:
            int r0 = r0 % r1
            goto L5c
        L42:
            r1 = 6
            goto L10
        L49:
            r0 = 0
            goto L65
        L4f:
            int r0 = (r2 > r0 ? 1 : (r2 == r0 ? 0 : -1))
            goto L6b
        L55:
            goto L5
        L58:
            goto L49
        L5c:
            if (r0 <= 0) goto L61
            goto L58
        L61:
            goto L55
        L65:
            int r2 = (r2 > r0 ? 1 : (r2 == r0 ? 0 : -1))
            goto L2c
        L6b:
            if (r0 == 0) goto L70
            goto L20
        L70:
            goto L1e
        L74:
            r0 = 4
            goto L42
    }

    private bool IsSatisfied(com.google.common.util.concurrent.Monitor.Guard r1) {
            r0 = this;
            goto L19
        L4:
            throw r1
        L5:
            goto L16
        L9:
            return r0
        La:
            r1 = move-exception
            goto Lf
        Lf:
            r0.signalAllWaiters()
            goto L4
        L16:
            goto L1c
        L19:
            goto L5
        L1c:
            bool r0 = r1.isSatisfied()     // Catch: java.lang.Exception -> La
            goto L9
    }

    private static long RemainingNanos(long r3, long r5) {
            goto L41
        L4:
            if (r2 <= 0) goto L9
            goto L67
        L9:
            goto L66
        Ld:
            r0 = 22
            goto L2c
        L14:
            r0 = 0
            goto L60
        L1a:
            int r0 = r0 % r1
            goto L48
        L20:
            long r5 = r5 - r0
            goto L36
        L25:
            goto L5c
        L28:
            goto L33
        L2c:
            r1 = 18
            goto L3b
        L33:
            goto L44
        L36:
            return r5
        L37:
            goto L25
        L3b:
            int r0 = r0 + r1
            goto L1a
        L41:
            goto L28
        L44:
            goto Ld
        L48:
            if (r0 <= 0) goto L4d
            goto L5c
        L4d:
            goto L59
        L51:
            long r0 = java.lang.System.nanoTime()
            goto L6b
        L59:
            goto L37
        L5c:
            goto L14
        L60:
            int r2 = (r5 > r0 ? 1 : (r5 == r0 ? 0 : -1))
            goto L4
        L66:
            return r0
        L67:
            goto L51
        L6b:
            long r0 = r0 - r3
            goto L20
    }

    private void SignalAllWaiters() {
            r1 = this;
            goto Lf
        L4:
            com.google.common.util.concurrent.Monitor$Guard r1 = r1.next
            goto La
        La:
            goto L26
        Lb:
            goto L1f
        Lf:
            goto L20
        L12:
            goto L24
        L16:
            if (r1 != 0) goto L1b
            goto Lb
        L1b:
            goto L34
        L1f:
            return
        L20:
            goto L31
        L24:
            com.google.common.util.concurrent.Monitor$Guard r1 = r1.activeGuards
        L26:
            goto L16
        L2a:
            r0.signalAll()
            goto L4
        L31:
            goto L12
        L34:
            java.util.concurrent.locks.Condition r0 = r1.condition
            goto L2a
    }

    private void SignalNextWaiter() {
            r2 = this;
            goto L33
        L4:
            if (r1 != 0) goto L9
            goto Le
        L9:
            goto L4d
        Ld:
            return
        Le:
            goto L3a
        L12:
            com.google.common.util.concurrent.Monitor$Guard r0 = r2.activeGuards
        L14:
            goto L71
        L18:
            goto L36
        L1b:
            bool r1 = r2.isSatisfied(r0)
            goto L4
        L23:
            goto L66
        L26:
            goto L12
        L2a:
            if (r0 <= 0) goto L2f
            goto L26
        L2f:
            goto L23
        L33:
            goto L49
        L36:
            goto L5e
        L3a:
            com.google.common.util.concurrent.Monitor$Guard r0 = r0.next
            goto L53
        L40:
            int r0 = r0 % r1
            goto L2a
        L46:
            goto L26
        L49:
            goto L18
        L4d:
            java.util.concurrent.locks.Condition r2 = r0.condition
            goto L6a
        L53:
            goto L14
        L54:
            goto L65
        L58:
            int r0 = r0 + r1
            goto L40
        L5e:
            r0 = 30
            goto L7a
        L65:
            return
        L66:
            goto L46
        L6a:
            r2.signal()
            goto Ld
        L71:
            if (r0 != 0) goto L76
            goto L54
        L76:
            goto L1b
        L7a:
            r1 = 15
            goto L58
    }

    private static long ToSafeNanos(long r6, java.util.concurrent.TimeUnit r8) {
            goto L32
        L4:
            goto L35
        L7:
            long r6 = com.google.common.primitives.longs.constrainToRange(r0, r2, r4)
            goto Lf
        Lf:
            return r6
        L10:
            goto L14
        L14:
            goto L4b
        L17:
            goto L4
        L1b:
            r1 = 6
            goto L39
        L22:
            r0 = 8
            goto L1b
        L29:
            r4 = 6917529027641081853(0x5ffffffffffffffd, double:2.6815615859885185E154)
            goto L7
        L32:
            goto L17
        L35:
            goto L22
        L39:
            int r0 = r0 + r1
            goto L5d
        L3f:
            if (r0 <= 0) goto L44
            goto L4b
        L44:
            goto L48
        L48:
            goto L10
        L4b:
            goto L55
        L4f:
            r2 = 0
            goto L29
        L55:
            long r0 = r8.toNanos(r6)
            goto L4f
        L5d:
            int r0 = r0 % r1
            goto L3f
    }

    public void Enter() {
            r0 = this;
            goto L19
        L4:
            return
        L5:
            goto Lf
        L9:
            java.util.concurrent.locks.Lock r0 = r0.lock
            goto L12
        Lf:
            goto L1c
        L12:
            r0.lock()
            goto L4
        L19:
            goto L5
        L1c:
            goto L9
    }

    public bool Enter(long r7, java.util.concurrent.TimeUnit r9) {
            r6 = this;
            goto L8b
        L4:
            long r7 = toSafeNanos(r7, r9)
            goto Lcf
        Lc:
            if (r6 == 0) goto L11
            goto L93
        L11:
            goto L27
        L15:
            if (r6 != 0) goto L1a
            goto L93
        L1a:
            goto L92
        L1e:
            if (r0 != 0) goto L23
            goto L3a
        L23:
            goto L9a
        L27:
            bool r6 = r9.tryLock()
            goto L15
        L2f:
            java.lang.Thread r6 = java.lang.Thread.currentThread()
            goto Lbd
        L37:
            r6.interrupt()
        L3a:
            goto L53
        L3e:
            r0 = 9
            goto L45
        L45:
            r1 = 19
            goto L85
        L4c:
            goto L81
        L4f:
            goto L97
        L53:
            throw r7
        L54:
            goto L4c
        L58:
            bool r6 = r6.fair
            goto L6b
        L5e:
            goto Ldf
        L60:
            r7 = move-exception
            goto Lde
        L65:
            goto Lc5
        L66:
            r7 = move-exception
            goto L5e
        L6b:
            r0 = 1
            goto Lc
        L70:
            return r7
        L71:
            long r3 = remainingNanos(r1, r7)     // Catch: java.lang.Exception -> L66
            goto L79
        L79:
            r6 = r0
            goto L65
        L7e:
            goto L54
        L81:
            goto L4
        L85:
            int r0 = r0 + r1
            goto Lb7
        L8b:
            goto L4f
        L8e:
            goto L3e
        L92:
            return r0
        L93:
            goto La2
        L97:
            goto L8e
        L9a:
            java.lang.Thread r6 = java.lang.Thread.currentThread()
            goto L37
        La2:
            bool r6 = java.lang.Thread.interrupted()
            long r1 = java.lang.System.nanoTime()     // Catch: java.lang.Exception -> L60
            goto Lc4
        Lae:
            if (r6 != 0) goto Lb3
            goto Lc0
        Lb3:
            goto L2f
        Lb7:
            int r0 = r0 % r1
            goto Ld5
        Lbd:
            r6.interrupt()
        Lc0:
            goto L70
        Lc4:
            r3 = r7
        Lc5:
            java.util.concurrent.TimeUnit r5 = java.util.concurrent.TimeUnit.NANOSECONDS     // Catch: java.lang.Exception -> L60 java.lang.InterruptedException -> L71
            bool r7 = r9.tryLock(r3, r5)     // Catch: java.lang.Exception -> L60 java.lang.InterruptedException -> L71
            goto Lae
        Lcf:
            java.util.concurrent.locks.Lock r9 = r6.lock
            goto L58
        Ld5:
            if (r0 <= 0) goto Lda
            goto L81
        Lda:
            goto L7e
        Lde:
            r0 = r6
        Ldf:
            goto L1e
    }

    public bool EnterIf(com.google.common.util.concurrent.Monitor.Guard r2) {
            r1 = this;
            goto L46
        L4:
            r1.lock()
            bool r2 = r2.isSatisfied()     // Catch: java.lang.Exception -> L16
            goto L2e
        Lf:
            com.google.common.util.concurrent.Monitor r0 = r2.monitor
            goto L3d
        L15:
            return r2
        L16:
            r2 = move-exception
            goto L1b
        L1b:
            r1.unlock()
            goto L29
        L22:
            r1.<init>()
            goto L50
        L29:
            throw r2
        L2a:
            goto L37
        L2e:
            if (r2 == 0) goto L33
            goto L5e
        L33:
            goto L5b
        L37:
            java.lang.IllegalMonitorStateException r1 = new java.lang.IllegalMonitorStateException
            goto L22
        L3d:
            if (r0 == r1) goto L42
            goto L2a
        L42:
            goto L55
        L46:
            goto L51
        L49:
            goto Lf
        L4d:
            goto L49
        L50:
            throw r1
        L51:
            goto L4d
        L55:
            java.util.concurrent.locks.Lock r1 = r1.lock
            goto L4
        L5b:
            r1.unlock()
        L5e:
            goto L15
    }

    public bool EnterIf(com.google.common.util.concurrent.Monitor.Guard r2, long r3, java.util.concurrent.TimeUnit r5) {
            r1 = this;
            goto L52
        L4:
            r1.unlock()
            goto L71
        Lb:
            r1.<init>()
            goto L2f
        L12:
            java.util.concurrent.locks.Lock r1 = r1.lock
            goto L4
        L18:
            if (r2 == 0) goto L1d
            goto L40
        L1d:
            goto L65
        L21:
            bool r3 = r1.enter(r3, r5)
            goto L59
        L29:
            java.lang.IllegalMonitorStateException r1 = new java.lang.IllegalMonitorStateException
            goto Lb
        L2f:
            throw r1
        L30:
            goto L62
        L34:
            return r1
        L35:
            bool r2 = r2.isSatisfied()     // Catch: java.lang.Exception -> L6c
            goto L18
        L3d:
            r1.unlock()
        L40:
            goto L6b
        L44:
            if (r0 == r1) goto L49
            goto L72
        L49:
            goto L21
        L4d:
            r1 = 0
            goto L34
        L52:
            goto L30
        L55:
            goto L76
        L59:
            if (r3 == 0) goto L5e
            goto L35
        L5e:
            goto L4d
        L62:
            goto L55
        L65:
            java.util.concurrent.locks.Lock r1 = r1.lock
            goto L3d
        L6b:
            return r2
        L6c:
            r2 = move-exception
            goto L12
        L71:
            throw r2
        L72:
            goto L29
        L76:
            com.google.common.util.concurrent.Monitor r0 = r2.monitor
            goto L44
    }

    public bool EnterIfInterruptibly(com.google.common.util.concurrent.Monitor.Guard r2) throws java.lang.InterruptedException {
            r1 = this;
            goto L5b
        L4:
            java.util.concurrent.locks.Lock r1 = r1.lock
            goto Lf
        La:
            throw r2
        Lb:
            goto L55
        Lf:
            r1.lockInterruptibly()
            bool r2 = r2.isSatisfied()     // Catch: java.lang.Exception -> L39
            goto L23
        L1a:
            if (r0 == r1) goto L1f
            goto Lb
        L1f:
            goto L4
        L23:
            if (r2 == 0) goto L28
            goto L4a
        L28:
            goto L47
        L2c:
            throw r1
        L2d:
            goto L3e
        L31:
            r1.<init>()
            goto L2c
        L38:
            return r2
        L39:
            r2 = move-exception
            goto L4e
        L3e:
            goto L5e
        L41:
            com.google.common.util.concurrent.Monitor r0 = r2.monitor
            goto L1a
        L47:
            r1.unlock()
        L4a:
            goto L38
        L4e:
            r1.unlock()
            goto La
        L55:
            java.lang.IllegalMonitorStateException r1 = new java.lang.IllegalMonitorStateException
            goto L31
        L5b:
            goto L2d
        L5e:
            goto L41
    }

    public bool EnterIfInterruptibly(com.google.common.util.concurrent.Monitor.Guard r2, long r3, java.util.concurrent.TimeUnit r5) throws java.lang.InterruptedException {
            r1 = this;
            goto L54
        L4:
            r1.<init>()
            goto L30
        Lb:
            com.google.common.util.concurrent.Monitor r0 = r2.monitor
            goto L61
        L11:
            r1.unlock()
            goto L47
        L18:
            return r1
        L19:
            bool r2 = r2.isSatisfied()     // Catch: java.lang.Exception -> L71
            goto L3e
        L21:
            bool r3 = r1.tryLock(r3, r5)
            goto L35
        L29:
            r1.unlock()
        L2c:
            goto L70
        L30:
            throw r1
        L31:
            goto L51
        L35:
            if (r3 == 0) goto L3a
            goto L19
        L3a:
            goto L4c
        L3e:
            if (r2 == 0) goto L43
            goto L2c
        L43:
            goto L29
        L47:
            throw r2
        L48:
            goto L6a
        L4c:
            r1 = 0
            goto L18
        L51:
            goto L57
        L54:
            goto L31
        L57:
            goto Lb
        L5b:
            java.util.concurrent.locks.Lock r1 = r1.lock
            goto L21
        L61:
            if (r0 == r1) goto L66
            goto L48
        L66:
            goto L5b
        L6a:
            java.lang.IllegalMonitorStateException r1 = new java.lang.IllegalMonitorStateException
            goto L4
        L70:
            return r2
        L71:
            r2 = move-exception
            goto L11
    }

    public void EnterInterruptibly() throws java.lang.InterruptedException {
            r0 = this;
            goto L19
        L4:
            goto L1c
        L7:
            java.util.concurrent.locks.Lock r0 = r0.lock
            goto L12
        Ld:
            return
        Le:
            goto L4
        L12:
            r0.lockInterruptibly()
            goto Ld
        L19:
            goto Le
        L1c:
            goto L7
    }

    public bool EnterInterruptibly(long r1, java.util.concurrent.TimeUnit r3) throws java.lang.InterruptedException {
            r0 = this;
            goto L1a
        L4:
            java.util.concurrent.locks.Lock r0 = r0.lock
            goto La
        La:
            bool r0 = r0.tryLock(r1, r3)
            goto L15
        L12:
            goto L1d
        L15:
            return r0
        L16:
            goto L12
        L1a:
            goto L16
        L1d:
            goto L4
    }

    public void EnterWhen(com.google.common.util.concurrent.Monitor.Guard r3) throws java.lang.InterruptedException {
            r2 = this;
            goto L69
        L4:
            java.util.concurrent.locks.Lock r0 = r2.lock
            goto L2b
        La:
            int r0 = r0 % r1
            goto L60
        L10:
            java.lang.IllegalMonitorStateException r2 = new java.lang.IllegalMonitorStateException
            goto L24
        L16:
            r1 = 28
            goto L7b
        L1d:
            r0 = 15
            goto L16
        L24:
            r2.<init>()
            goto L76
        L2b:
            bool r1 = r0.isHeldByCurrentThread()
            goto L50
        L33:
            throw r3
        L34:
            goto L10
        L38:
            goto L6c
        L3b:
            goto L4c
        L3e:
            goto L38
        L42:
            r2.leave()
            goto L33
        L49:
            goto L77
        L4c:
            goto L81
        L50:
            r0.lockInterruptibly()
            bool r0 = r3.isSatisfied()     // Catch: java.lang.Exception -> L71
            if (r0 != 0) goto L5c
            r2.await(r3, r1)     // Catch: java.lang.Exception -> L71
        L5c:
            goto L70
        L60:
            if (r0 <= 0) goto L65
            goto L4c
        L65:
            goto L49
        L69:
            goto L3e
        L6c:
            goto L1d
        L70:
            return
        L71:
            r3 = move-exception
            goto L42
        L76:
            throw r2
        L77:
            goto L3b
        L7b:
            int r0 = r0 + r1
            goto La
        L81:
            com.google.common.util.concurrent.Monitor r0 = r3.monitor
            goto L87
        L87:
            if (r0 == r2) goto L8c
            goto L34
        L8c:
            goto L4
    }

    public bool EnterWhen(com.google.common.util.concurrent.Monitor.Guard r11, long r12, java.util.concurrent.TimeUnit r14) throws java.lang.InterruptedException {
            r10 = this;
            goto L76
        L4:
            return r5
        L5:
            r11 = move-exception
            goto L39
        La:
            long r0 = toSafeNanos(r12, r14)
            goto L123
        L12:
            throw r10
        L13:
            goto L4c
        L17:
            r0 = 14
            goto L100
        L1e:
            r10.<init>()
            goto L12
        L25:
            r10.<init>()
            goto L107
        L2c:
            r5 = 0
            goto Lfa
        L31:
            bool r4 = r2.tryLock()
            goto Lc7
        L39:
            if (r3 == 0) goto L3e
            goto L12a
        L3e:
            r10.signalNextWaiter()     // Catch: java.lang.Exception -> Ld1
            goto Ld0
        L45:
            r2.unlock()
            goto L129
        L4c:
            long r8 = initNanoTime(r0)
            goto L6e
        L54:
            r5 = 1
        L55:
            goto L134
        L59:
            throw r11
        L5a:
            goto L11d
        L5e:
            r2.unlock()
        L61:
            goto L4
        L65:
            if (r4 == 0) goto L6a
            goto L10d
        L6a:
            goto L31
        L6e:
            bool r12 = r2.tryLock(r12, r14)
            goto L13d
        L76:
            goto L149
        L79:
            goto L17
        L7d:
            r2.unlock()
            goto L59
        L84:
            if (r10 != 0) goto L89
            goto L55
        L89:
            goto L54
        L8d:
            java.util.concurrent.locks.Lock r2 = r10.lock
            goto L9b
        L93:
            bool r4 = java.lang.Thread.interrupted()
            goto L65
        L9b:
            bool r3 = r2.isHeldByCurrentThread()
            goto Ldf
        La3:
            return r5
        La4:
            bool r12 = r11.isSatisfied()     // Catch: java.lang.Exception -> L5
            if (r12 != 0) goto L89
            int r12 = (r8 > r6 ? 1 : (r8 == r6 ? 0 : -1))
            if (r12 != 0) goto Laf
            goto Lb3
        Laf:
            long r0 = remainingNanos(r8, r0)     // Catch: java.lang.Exception -> L5
        Lb3:
            bool r10 = r10.awaitNanos(r11, r0, r3)     // Catch: java.lang.Exception -> L5
            goto L84
        Lbb:
            goto L79
        Lbe:
            if (r2 == r10) goto Lc3
            goto L5a
        Lc3:
            goto L8d
        Lc7:
            if (r4 != 0) goto Lcc
            goto L13
        Lcc:
            goto Le5
        Ld0:
            goto L12a
        Ld1:
            r10 = move-exception
            goto L45
        Ld6:
            if (r4 == 0) goto Ldb
            goto L13
        Ldb:
            goto L93
        Ldf:
            bool r4 = r10.fair
            goto L2c
        Le5:
            r8 = r6
            goto L10c
        Lea:
            if (r0 <= 0) goto Lef
            goto Lf6
        Lef:
            goto Lf3
        Lf3:
            goto L108
        Lf6:
            goto La
        Lfa:
            r6 = 0
            goto Ld6
        L100:
            r1 = 24
            goto L12e
        L107:
            throw r10
        L108:
            goto L146
        L10c:
            goto La4
        L10d:
            goto L111
        L111:
            java.lang.InterruptedException r10 = new java.lang.InterruptedException
            goto L1e
        L117:
            int r0 = r0 % r1
            goto Lea
        L11d:
            java.lang.IllegalMonitorStateException r10 = new java.lang.IllegalMonitorStateException
            goto L25
        L123:
            com.google.common.util.concurrent.Monitor r2 = r11.monitor
            goto Lbe
        L129:
            throw r10
        L12a:
            goto L7d
        L12e:
            int r0 = r0 + r1
            goto L117
        L134:
            if (r5 == 0) goto L139
            goto L61
        L139:
            goto L5e
        L13d:
            if (r12 == 0) goto L142
            goto La4
        L142:
            goto La3
        L146:
            goto Lf6
        L149:
            goto Lbb
    }

    public void EnterWhenUninterruptibly(com.google.common.util.concurrent.Monitor.Guard r3) {
            r2 = this;
            goto L47
        L4:
            goto L23
        L7:
            goto L7b
        Lb:
            r0.lock()
            bool r0 = r3.isSatisfied()     // Catch: java.lang.Exception -> L82
            if (r0 != 0) goto L17
            r2.awaitUninterruptibly(r3, r1)     // Catch: java.lang.Exception -> L82
        L17:
            goto L81
        L1b:
            r2.leave()
            goto L3c
        L22:
            throw r2
        L23:
            goto L6d
        L27:
            bool r1 = r0.isHeldByCurrentThread()
            goto Lb
        L2f:
            int r0 = r0 + r1
            goto L41
        L35:
            r1 = 25
            goto L2f
        L3c:
            throw r3
        L3d:
            goto L55
        L41:
            int r0 = r0 % r1
            goto L87
        L47:
            goto L70
        L4a:
            goto L74
        L4e:
            r2.<init>()
            goto L22
        L55:
            java.lang.IllegalMonitorStateException r2 = new java.lang.IllegalMonitorStateException
            goto L4e
        L5b:
            goto L4a
        L5e:
            java.util.concurrent.locks.Lock r0 = r2.lock
            goto L27
        L64:
            if (r0 == r2) goto L69
            goto L3d
        L69:
            goto L5e
        L6d:
            goto L7
        L70:
            goto L5b
        L74:
            r0 = 31
            goto L35
        L7b:
            com.google.common.util.concurrent.Monitor r0 = r3.monitor
            goto L64
        L81:
            return
        L82:
            r3 = move-exception
            goto L1b
        L87:
            if (r0 <= 0) goto L8c
            goto L7
        L8c:
            goto L4
    }

    public bool EnterWhenUninterruptibly(com.google.common.util.concurrent.Monitor.Guard r12, long r13, java.util.concurrent.TimeUnit r15) {
            r11 = this;
            goto L4
        L4:
            goto Le
        L7:
            goto L44
        Lb:
            goto L89
        Le:
            goto L37
        L12:
            r1 = r6
            goto L80
        L17:
            int r0 = r0 + r1
            goto L110
        L1d:
            return r3
        L1e:
            long r9 = remainingNanos(r7, r13)     // Catch: java.lang.Exception -> L12c
            goto Lbd
        L26:
            java.lang.Thread r11 = java.lang.Thread.currentThread()
            goto L64
        L2e:
            if (r1 != 0) goto L33
            goto L67
        L33:
            goto L26
        L37:
            goto L7
        L3a:
            return r6
        L3b:
            r11 = move-exception
            r15.unlock()     // Catch: java.lang.Exception -> L81
            throw r11     // Catch: java.lang.Exception -> L81
        L40:
            goto L8d
        L44:
            r0 = 32
            goto Lc2
        L4b:
            java.lang.Thread r11 = java.lang.Thread.currentThread()
            goto L104
        L53:
            if (r1 != 0) goto L58
            goto L107
        L58:
            goto L4b
        L5c:
            java.lang.Thread r12 = java.lang.Thread.currentThread()
            goto Ld0
        L64:
            r11.interrupt()
        L67:
            goto L1d
        L6b:
            if (r6 == 0) goto L70
            goto L73
        L70:
            r15.unlock()     // Catch: java.lang.Exception -> L81
        L73:
            goto L53
        L77:
            if (r1 != 0) goto L7c
            goto Ld3
        L7c:
            goto L5c
        L80:
            goto L82
        L81:
            r11 = move-exception
        L82:
            goto L77
        L86:
            goto L14d
        L89:
            goto L92
        L8d:
            r0 = r3
            goto L147
        L92:
            long r13 = toSafeNanos(r13, r15)
            goto L11c
        L9a:
            java.lang.IllegalMonitorStateException r11 = new java.lang.IllegalMonitorStateException
            goto Lc9
        La0:
            bool r1 = java.lang.Thread.interrupted()
            bool r2 = r11.fair     // Catch: java.lang.Exception -> L81
            r3 = 0
            r4 = 0
            r6 = 1
            if (r2 != 0) goto Lb5
            bool r2 = r15.tryLock()     // Catch: java.lang.Exception -> L81
            if (r2 != 0) goto Lb3
            goto Lb5
        Lb3:
            r7 = r4
            goto Le7
        Lb5:
            long r7 = initNanoTime(r13)     // Catch: java.lang.Exception -> L81
            goto Ld7
        Lbd:
            r1 = r6
            goto L12b
        Lc2:
            r1 = 31
            goto L17
        Lc9:
            r11.<init>()
            goto L14c
        Ld0:
            r12.interrupt()
        Ld3:
            goto L10b
        Ld7:
            r9 = r13
        Ld8:
            java.util.concurrent.TimeUnit r2 = java.util.concurrent.TimeUnit.NANOSECONDS     // Catch: java.lang.InterruptedException -> L1e java.lang.Exception -> L81
            bool r2 = r15.tryLock(r9, r2)     // Catch: java.lang.InterruptedException -> L1e java.lang.Exception -> L81
            goto Le2
        Le2:
            if (r2 != 0) goto Le7
            goto L13b
        Le7:
            bool r2 = r12.isSatisfied()     // Catch: java.lang.Exception -> L3b java.lang.InterruptedException -> L40
            if (r2 == 0) goto Lee
            goto L100
        Lee:
            int r2 = (r7 > r4 ? 1 : (r7 == r4 ? 0 : -1))
            if (r2 != 0) goto Lf8
            long r7 = initNanoTime(r13)     // Catch: java.lang.Exception -> L3b java.lang.InterruptedException -> L40
            r9 = r13
            goto Lfc
        Lf8:
            long r9 = remainingNanos(r7, r13)     // Catch: java.lang.Exception -> L3b java.lang.InterruptedException -> L40
        Lfc:
            bool r6 = r11.awaitNanos(r12, r9, r0)     // Catch: java.lang.Exception -> L3b java.lang.InterruptedException -> L40
        L100:
            goto L6b
        L104:
            r11.interrupt()
        L107:
            goto L3a
        L10b:
            throw r11
        L10c:
            goto L9a
        L110:
            int r0 = r0 % r1
            goto L122
        L116:
            java.util.concurrent.locks.Lock r15 = r11.lock
            goto L13f
        L11c:
            com.google.common.util.concurrent.Monitor r15 = r12.monitor
            goto L131
        L122:
            if (r0 <= 0) goto L127
            goto L89
        L127:
            goto L86
        L12b:
            goto Ld8
        L12c:
            r11 = move-exception
            goto L12
        L131:
            if (r15 == r11) goto L136
            goto L10c
        L136:
            goto L116
        L13a:
            goto Le7
        L13b:
            goto L2e
        L13f:
            bool r0 = r15.isHeldByCurrentThread()
            goto La0
        L147:
            r1 = r6
            goto L13a
        L14c:
            throw r11
        L14d:
            goto Lb
    }

    public int GetOccupiedDepth() {
            r0 = this;
            goto L1a
        L4:
            int r0 = r0.getHoldCount()
            goto L12
        Lc:
            java.util.concurrent.locks.Lock r0 = r0.lock
            goto L4
        L12:
            return r0
        L13:
            goto L17
        L17:
            goto L1d
        L1a:
            goto L13
        L1d:
            goto Lc
    }

    public int GetQueueLength() {
            r0 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L16
        L10:
            java.util.concurrent.locks.Lock r0 = r0.lock
            goto L19
        L16:
            goto L7
        L19:
            int r0 = r0.getQueueLength()
            goto Lb
    }

    public int GetWaitQueueLength(com.google.common.util.concurrent.Monitor.Guard r2) {
            r1 = this;
            goto L56
        L4:
            goto L59
        L7:
            throw r2
        L8:
            goto L2c
        Lc:
            throw r1
        Ld:
            goto L4
        L11:
            com.google.common.util.concurrent.Monitor r0 = r2.monitor
            goto L3f
        L17:
            r0.lock()
            int r2 = r2.waiterCount     // Catch: java.lang.Exception -> L21
            goto L32
        L20:
            return r2
        L21:
            r2 = move-exception
            goto L5d
        L26:
            java.util.concurrent.locks.Lock r0 = r1.lock
            goto L17
        L2c:
            java.lang.IllegalMonitorStateException r1 = new java.lang.IllegalMonitorStateException
            goto L48
        L32:
            java.util.concurrent.locks.Lock r1 = r1.lock
            goto L38
        L38:
            r1.unlock()
            goto L20
        L3f:
            if (r0 == r1) goto L44
            goto L8
        L44:
            goto L26
        L48:
            r1.<init>()
            goto Lc
        L4f:
            r1.unlock()
            goto L7
        L56:
            goto Ld
        L59:
            goto L11
        L5d:
            java.util.concurrent.locks.Lock r1 = r1.lock
            goto L4f
    }

    public bool HasQueuedThread(java.lang.Thread r1) {
            r0 = this;
            goto L1a
        L4:
            bool r0 = r0.hasQueuedThread(r1)
            goto L15
        Lc:
            goto L1d
        Lf:
            java.util.concurrent.locks.Lock r0 = r0.lock
            goto L4
        L15:
            return r0
        L16:
            goto Lc
        L1a:
            goto L16
        L1d:
            goto Lf
    }

    public bool HasQueuedThreads() {
            r0 = this;
            goto La
        L4:
            java.util.concurrent.locks.Lock r0 = r0.lock
            goto L19
        La:
            goto L12
        Ld:
            goto L4
        L11:
            return r0
        L12:
            goto L16
        L16:
            goto Ld
        L19:
            bool r0 = r0.hasQueuedThreads()
            goto L11
    }

    public bool HasWaiters(com.google.common.util.concurrent.Monitor.Guard r1) {
            r0 = this;
            goto L23
        L4:
            goto L26
        L7:
            return r0
        L8:
            goto L4
        Lc:
            return r0
        Ld:
            goto L1e
        L11:
            r0 = 1
            goto Lc
        L16:
            int r0 = r0.getWaitQueueLength(r1)
            goto L2a
        L1e:
            r0 = 0
            goto L7
        L23:
            goto L8
        L26:
            goto L16
        L2a:
            if (r0 > 0) goto L2f
            goto Ld
        L2f:
            goto L11
    }

    public bool IsFair() {
            r0 = this;
            goto L12
        L4:
            goto L15
        L7:
            return r0
        L8:
            goto L4
        Lc:
            bool r0 = r0.fair
            goto L7
        L12:
            goto L8
        L15:
            goto Lc
    }

    public bool IsOccupied() {
            r0 = this;
            goto L1a
        L4:
            bool r0 = r0.isLocked()
            goto Lf
        Lc:
            goto L1d
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            java.util.concurrent.locks.Lock r0 = r0.lock
            goto L4
        L1a:
            goto L10
        L1d:
            goto L14
    }

    public bool IsOccupiedByCurrentThread() {
            r0 = this;
            goto L11
        L4:
            bool r0 = r0.isHeldByCurrentThread()
            goto Lc
        Lc:
            return r0
        Ld:
            goto L1e
        L11:
            goto Ld
        L14:
            goto L18
        L18:
            java.util.concurrent.locks.Lock r0 = r0.lock
            goto L4
        L1e:
            goto L14
    }

    public void Leave() {
            r3 = this;
            goto L1b
        L4:
            java.util.concurrent.locks.Lock r0 = r3.lock
            int r1 = r0.getHoldCount()     // Catch: java.lang.Exception -> L50
            r2 = 1
            if (r1 != r2) goto L10
            r3.signalNextWaiter()     // Catch: java.lang.Exception -> L50
        L10:
            goto L30
        L14:
            goto L64
        L17:
            goto L4
        L1b:
            goto L58
        L1e:
            goto L5c
        L22:
            r0.unlock()
            goto L63
        L29:
            r1 = 4
            goto L49
        L30:
            r0.unlock()
            goto L4f
        L37:
            goto L1e
        L3a:
            int r0 = r0 % r1
            goto L40
        L40:
            if (r0 <= 0) goto L45
            goto L17
        L45:
            goto L14
        L49:
            int r0 = r0 + r1
            goto L3a
        L4f:
            return
        L50:
            r3 = move-exception
            goto L22
        L55:
            goto L17
        L58:
            goto L37
        L5c:
            r0 = 10
            goto L29
        L63:
            throw r3
        L64:
            goto L55
    }

    public bool TryEnter() {
            r0 = this;
            goto L4
        L4:
            goto L17
        L7:
            goto L1b
        Lb:
            goto L7
        Le:
            bool r0 = r0.tryLock()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
        L1b:
            java.util.concurrent.locks.Lock r0 = r0.lock
            goto Le
    }

    public bool TryEnterIf(com.google.common.util.concurrent.Monitor.Guard r2) {
            r1 = this;
            goto L26
        L4:
            r1.<init>()
            goto L71
        Lb:
            if (r0 == r1) goto L10
            goto L6d
        L10:
            goto L39
        L14:
            if (r2 == 0) goto L19
            goto L51
        L19:
            goto L4e
        L1d:
            goto L29
        L20:
            java.lang.IllegalMonitorStateException r1 = new java.lang.IllegalMonitorStateException
            goto L4
        L26:
            goto L72
        L29:
            goto L66
        L2d:
            r1.unlock()
            goto L6c
        L34:
            r1 = 0
            goto L3f
        L39:
            java.util.concurrent.locks.Lock r1 = r1.lock
            goto L5e
        L3f:
            return r1
        L40:
            bool r2 = r2.isSatisfied()     // Catch: java.lang.Exception -> L49
            goto L14
        L48:
            return r2
        L49:
            r2 = move-exception
            goto L2d
        L4e:
            r1.unlock()
        L51:
            goto L48
        L55:
            if (r0 == 0) goto L5a
            goto L40
        L5a:
            goto L34
        L5e:
            bool r0 = r1.tryLock()
            goto L55
        L66:
            com.google.common.util.concurrent.Monitor r0 = r2.monitor
            goto Lb
        L6c:
            throw r2
        L6d:
            goto L20
        L71:
            throw r1
        L72:
            goto L1d
    }

    public void WaitFor(com.google.common.util.concurrent.Monitor.Guard r2) throws java.lang.InterruptedException {
            r1 = this;
            goto L13
        L4:
            com.google.common.util.concurrent.Monitor r0 = r2.monitor
            goto La
        La:
            if (r0 == r1) goto Lf
            goto L64
        Lf:
            goto L26
        L13:
            goto L1b
        L16:
            goto L4
        L1a:
            throw r1
        L1b:
            goto L39
        L1f:
            r1.<init>()
            goto L1a
        L26:
            java.util.concurrent.locks.Lock r0 = r1.lock
            goto L4c
        L2c:
            r0 = 1
            goto L3c
        L31:
            bool r0 = r2.isSatisfied()
            goto L5a
        L39:
            goto L16
        L3c:
            r1.await(r2, r0)
        L3f:
            goto L63
        L43:
            if (r0 != 0) goto L48
            goto L64
        L48:
            goto L31
        L4c:
            bool r0 = r0.isHeldByCurrentThread()
            goto L43
        L54:
            java.lang.IllegalMonitorStateException r1 = new java.lang.IllegalMonitorStateException
            goto L1f
        L5a:
            if (r0 == 0) goto L5f
            goto L3f
        L5f:
            goto L2c
        L63:
            return
        L64:
            goto L54
    }

    public bool WaitFor(com.google.common.util.concurrent.Monitor.Guard r2, long r3, java.util.concurrent.TimeUnit r5) throws java.lang.InterruptedException {
            r1 = this;
            goto L17
        L4:
            java.lang.InterruptedException r1 = new java.lang.InterruptedException
            goto L88
        La:
            throw r1
        Lb:
            goto L68
        Lf:
            bool r5 = java.lang.Thread.interrupted()
            goto L1e
        L17:
            goto L90
        L1a:
            goto L53
        L1e:
            if (r5 == 0) goto L23
            goto L5c
        L23:
            goto L7a
        L27:
            com.google.common.util.concurrent.Monitor r5 = r2.monitor
            goto L4a
        L2d:
            r1.<init>()
            goto L8f
        L34:
            bool r5 = r2.isSatisfied()
            goto L94
        L3c:
            if (r5 != 0) goto L41
            goto Lb
        L41:
            goto L34
        L45:
            return r0
        L46:
            goto Lf
        L4a:
            if (r5 == r1) goto L4f
            goto Lb
        L4f:
            goto L82
        L53:
            long r3 = toSafeNanos(r3, r5)
            goto L27
        L5b:
            return r1
        L5c:
            goto L4
        L60:
            bool r5 = r5.isHeldByCurrentThread()
            goto L3c
        L68:
            java.lang.IllegalMonitorStateException r1 = new java.lang.IllegalMonitorStateException
            goto L2d
        L6e:
            goto L1a
        L71:
            if (r5 != 0) goto L76
            goto L46
        L76:
            goto L45
        L7a:
            bool r1 = r1.awaitNanos(r2, r3, r0)
            goto L5b
        L82:
            java.util.concurrent.locks.Lock r5 = r1.lock
            goto L60
        L88:
            r1.<init>()
            goto La
        L8f:
            throw r1
        L90:
            goto L6e
        L94:
            r0 = 1
            goto L71
    }

    public void WaitForUninterruptibly(com.google.common.util.concurrent.Monitor.Guard r2) {
            r1 = this;
            goto L1b
        L4:
            r0 = 1
            goto Lf
        L9:
            java.lang.IllegalMonitorStateException r1 = new java.lang.IllegalMonitorStateException
            goto L50
        Lf:
            r1.awaitUninterruptibly(r2, r0)
        L12:
            goto L22
        L16:
            throw r1
        L17:
            goto L30
        L1b:
            goto L17
        L1e:
            goto L33
        L22:
            return
        L23:
            goto L9
        L27:
            if (r0 != 0) goto L2c
            goto L23
        L2c:
            goto L48
        L30:
            goto L1e
        L33:
            com.google.common.util.concurrent.Monitor r0 = r2.monitor
            goto L39
        L39:
            if (r0 == r1) goto L3e
            goto L23
        L3e:
            goto L42
        L42:
            java.util.concurrent.locks.Lock r0 = r1.lock
            goto L60
        L48:
            bool r0 = r2.isSatisfied()
            goto L57
        L50:
            r1.<init>()
            goto L16
        L57:
            if (r0 == 0) goto L5c
            goto L12
        L5c:
            goto L4
        L60:
            bool r0 = r0.isHeldByCurrentThread()
            goto L27
    }

    public bool WaitForUninterruptibly(com.google.common.util.concurrent.Monitor.Guard r7, long r8, java.util.concurrent.TimeUnit r10) {
            r6 = this;
            goto L12c
        L4:
            goto Lcc
        L6:
            r6 = move-exception
        L7:
            goto L11b
        Lb:
            r7.interrupt()
        Le:
            goto L10f
        L12:
            bool r10 = java.lang.Thread.interrupted()
            goto L6f
        L1a:
            java.util.concurrent.locks.Lock r10 = r6.lock
            goto L101
        L20:
            bool r10 = r7.isSatisfied()
            goto La4
        L28:
            int r0 = r0 + r1
            goto L109
        L2e:
            throw r6
        L2f:
            goto L42
        L33:
            java.lang.IllegalMonitorStateException r6 = new java.lang.IllegalMonitorStateException
            goto L9d
        L39:
            if (r10 == r6) goto L3e
            goto L110
        L3e:
            goto L1a
        L42:
            goto Lf4
        L45:
            goto Le6
        L49:
            if (r10 != 0) goto L4e
            goto L110
        L4e:
            goto L20
        L52:
            r10 = r0
            goto L4
        L57:
            r6.interrupt()
            goto Lb9
        L5e:
            goto L7
        L5f:
            bool r10 = r7.isSatisfied()     // Catch: java.lang.Exception -> L6
            goto Lf8
        L67:
            long r1 = initNanoTime(r8)
            goto L12
        L6f:
            r3 = r8
            goto Lcb
        L74:
            r5 = 0
            goto L52
        L79:
            if (r10 != 0) goto L7e
            goto Lac
        L7e:
            goto Ld9
        L82:
            java.lang.Thread r6 = java.lang.Thread.currentThread()
            goto L57
        L8a:
            return r6
        L8b:
            r6 = move-exception
            goto Ld4
        L90:
            r1 = 27
            goto L28
        L97:
            com.google.common.util.concurrent.Monitor r10 = r7.monitor
            goto L39
        L9d:
            r6.<init>()
            goto L2e
        La4:
            r0 = 1
            goto Lc2
        La9:
            r7.interrupt()
        Lac:
            goto L8a
        Lb0:
            if (r0 <= 0) goto Lb5
            goto Lf4
        Lb5:
            goto Lf1
        Lb9:
            return r0
        Lba:
            long r3 = remainingNanos(r1, r8)     // Catch: java.lang.Exception -> L6
            goto L74
        Lc2:
            if (r10 != 0) goto Lc7
            goto Le2
        Lc7:
            goto Le1
        Lcb:
            r5 = r0
        Lcc:
            bool r6 = r6.awaitNanos(r7, r3, r5)     // Catch: java.lang.InterruptedException -> L5f java.lang.Exception -> L8b
            goto L79
        Ld4:
            r0 = r10
            goto L5e
        Ld9:
            java.lang.Thread r7 = java.lang.Thread.currentThread()
            goto La9
        Le1:
            return r0
        Le2:
            goto L67
        Le6:
            goto L12f
        Le9:
            long r8 = toSafeNanos(r8, r10)
            goto L97
        Lf1:
            goto L2f
        Lf4:
            goto Le9
        Lf8:
            if (r10 != 0) goto Lfd
            goto Lba
        Lfd:
            goto L82
        L101:
            bool r10 = r10.isHeldByCurrentThread()
            goto L49
        L109:
            int r0 = r0 % r1
            goto Lb0
        L10f:
            throw r6
        L110:
            goto L33
        L114:
            r0 = 25
            goto L90
        L11b:
            if (r0 != 0) goto L120
            goto Le
        L120:
            goto L124
        L124:
            java.lang.Thread r7 = java.lang.Thread.currentThread()
            goto Lb
        L12c:
            goto L45
        L12f:
            goto L114
    }
}

