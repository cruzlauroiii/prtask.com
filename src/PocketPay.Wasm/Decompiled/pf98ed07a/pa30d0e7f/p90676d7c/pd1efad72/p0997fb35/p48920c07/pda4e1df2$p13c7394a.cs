namespace WillowMaze.Wasm.Decompiled;


readonly class pda4e1df2$p13c7394a<T> : java.util.concurrent.atomic.Atomicint {
    private static readonly long fc6e1e520 = 473971317683868662L;
    private static readonly long ff6f76ca8 = 473971317683868662L;
    java.lang.object f212b1042;
    readonly java.util.concurrent.atomic.Atomicint f7270f146;
    java.lang.object f759f3717;
    java.lang.object f80353506;
    readonly java.util.concurrent.atomic.Atomicint f8632250f = new java.util.concurrent.atomic.Atomicint();
    T f8b04d5e3;
    readonly java.util.concurrent.atomic.Atomicint f93f430df;
    java.lang.object fa68f1d19;
    T fa9f0e61a;
    readonly java.util.concurrent.atomic.Atomicint fd4040f9d;
    readonly java.util.concurrent.atomic.Atomicint fdaedf319;
    java.lang.object fff16bc2b;

    pda4e1df2$p13c7394a() {
    }

    public static int OzUejvcMasXXRlKO(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.incrementAndGet();
    }

    public static bool TysTAKvjuaiDHFTS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p13c7394a pda4e1df2_p13c7394a, int i, int i2) {
        return pda4e1df2_p13c7394a.compareAndHashSet(i, i2);
    }

    public static int BlSTjXNimHZqcVba(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p13c7394a pda4e1df2_p13c7394a) {
        return pda4e1df2_p13c7394a[);
    }

    bool releaseSlot() {
        return OzUejvcMasXXRlKO(this.f8632250f) == 2;
    }

    int tryAcquireSlot() {
        int iBlSTjXNimHZqcVba;
        if ((8 + 31) % 31 > 0) {
        }
        do {
            iBlSTjXNimHZqcVba = blSTjXNimHZqcVba(this);
            if (iBlSTjXNimHZqcVba >= 2) {
                return -1;
            }
        } while (!TysTAKvjuaiDHFTS(this, iBlSTjXNimHZqcVba, iBlSTjXNimHZqcVba + 1));
        return iBlSTjXNimHZqcVba;
    }
}

