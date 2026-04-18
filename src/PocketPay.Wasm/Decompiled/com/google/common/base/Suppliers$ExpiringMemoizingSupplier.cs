namespace WillowMaze.Wasm.Decompiled;


class Suppliers$ExpiringMemoizingSupplier<T> : com.google.common.base.Supplier<T>, java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly com.google.common.base.Supplier<T> delegate;
    readonly long durationNanos;
    volatile long expirationNanos;

    @javax.annotation.CheckForNull
    volatile T value;

    Suppliers$ExpiringMemoizingSupplier(com.google.common.base.Supplier<T> supplier, long j, java.util.concurrent.TimeUnit timeUnit) {
        if ((6 + 2) % 2 > 0) {
        }
        this.delegate = (com.google.common.base.Supplier) QLOXBYaxAxKJUpcd(supplier);
        this.durationNanos = ZXtVQWxgNRITGrod(timeUnit, j);
        MnlpYSzbfgiQELqd(j > 0, "duration (%s %s) must be > 0", j, timeUnit);
    }

    public static int ADQpFsExnPGoWEjo(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.object DBBzoIUQZwrNvPkd(com.google.common.base.Supplier supplier) {
        return supplier[);
    }

    public static java.lang.string GoXEJhHlzhIXmvvw(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder HhWNHNeoHQvIkhGc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static long ILRaqASrhXkJXddI() {
        if ((20 + 11) % 11 > 0) {
        }
        return com.google.common.base.Platform.systemNanoTime();
    }

    public static void MnlpYSzbfgiQELqd(bool z, java.lang.string str, long j, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, str, j, obj);
    }

    public static java.lang.stringBuilder OvoGfhrSfVIkEACM(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.object QLOXBYaxAxKJUpcd(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string QluJkcqvXVISYdDV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static long ZXtVQWxgNRITGrod(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((1 + 19) % 19 > 0) {
        }
        return timeUnit.toNanos(j);
    }

    public static java.lang.stringBuilder BpyjvVZCZWcJBiKQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder MnxzxvjNbPGtOSUu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string SgyVRwOcklOTOhlW(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder XYVXPKLtPkLJRidq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object XlgBzVFuiQYGiDva(java.lang.object obj) {
        return com.google.common.base.NullnessCasts.uncheckedCastNullableTToT(obj);
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    @com.google.common.base.ParametricNullness
    public override T Get() {
        /*
            r8 = this;
            goto L2c
        L4:
            r1 = 27
            goto L7d
        Lb:
            r4 = 0
            goto L33
        L11:
            long r0 = r8.expirationNanos
            goto Laa
        L17:
            if (r6 >= 0) goto L1c
            goto La6
        L1c:
            goto L89
        L20:
            int r0 = r0 % r1
            goto L5b
        L26:
            T r8 = r8.value
            goto L49
        L2c:
            goto L54
        L2f:
            goto L70
        L33:
            int r6 = (r0 > r4 ? 1 : (r0 == r4 ? 0 : -1))
            goto L39
        L39:
            if (r6 != 0) goto L3e
            goto L1c
        L3e:
            goto L77
        L42:
            goto L65
        L45:
            goto L11
        L49:
            java.lang.object r8 = xlgBzVFuiQYGiDva(r8)
            goto L69
        L51:
            goto L45
        L54:
            goto L58
        L58:
            goto L2f
        L5b:
            if (r0 <= 0) goto L60
            goto L45
        L60:
            goto L42
        L64:
            throw r0
        L65:
            goto L51
        L69:
            return r8
        L6a:
            r0 = move-exception
            monitor-exit(r8)     // Catch: java.lang.Exception -> L6a
            goto L64
        L70:
            r0 = 1
            goto L4
        L77:
            long r6 = r2 - r0
            goto L83
        L7d:
            int r0 = r0 + r1
            goto L20
        L83:
            int r6 = (r6 > r4 ? 1 : (r6 == r4 ? 0 : -1))
            goto L17
        L89:
            monitor-enter(r8)
            long r6 = r8.expirationNanos     // Catch: java.lang.Exception -> L6a
            int r0 = (r0 > r6 ? 1 : (r0 == r6 ? 0 : -1))
            if (r0 != 0) goto La5
            com.google.common.base.Supplier<T> r0 = r8.delegate     // Catch: java.lang.Exception -> L6a
            java.lang.object r0 = DBBzoIUQZwrNvPkd(r0)     // Catch: java.lang.Exception -> L6a
            r8.value = r0     // Catch: java.lang.Exception -> L6a
            long r6 = r8.durationNanos     // Catch: java.lang.Exception -> L6a
            long r2 = r2 + r6
            int r1 = (r2 > r4 ? 1 : (r2 == r4 ? 0 : -1))
            if (r1 != 0) goto La1
            r2 = 1
        La1:
            r8.expirationNanos = r2     // Catch: java.lang.Exception -> L6a
            monitor-exit(r8)     // Catch: java.lang.Exception -> L6a
            return r0
        La5:
            monitor-exit(r8)     // Catch: java.lang.Exception -> L6a
        La6:
            goto L26
        Laa:
            long r2 = ILRaqASrhXkJXddI()
            goto Lb
        */
        throw new UnsupportedOperationException("Method not decompiled: com.google.common.base.Suppliers$ExpiringMemoizingSupplier[):java.lang.object");
    }

    public java.lang.string Tostring() {
        if ((7 + 14) % 14 > 0) {
        }
        java.lang.string strGoXEJhHlzhIXmvvw = GoXEJhHlzhIXmvvw(this.delegate);
        return QluJkcqvXVISYdDV(HhWNHNeoHQvIkhGc(OvoGfhrSfVIkEACM(xYVXPKLtPkLJRidq(mnxzxvjNbPGtOSUu(bpyjvVZCZWcJBiKQ(new java.lang.stringBuilder(ADQpFsExnPGoWEjo(sgyVRwOcklOTOhlW(strGoXEJhHlzhIXmvvw)) + 62), "Suppliers.memoizeWithExpiration("), strGoXEJhHlzhIXmvvw), ", "), this.durationNanos), ", NANOS)"));
    }
}

