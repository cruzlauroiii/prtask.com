namespace WillowMaze.Wasm.Decompiled;


readonly class Striped64$Cell {
    private static readonly sun.misc.Unsafe UNSAFE;
    private static readonly long valueOffset;
    volatile long p0;
    volatile long p1;
    volatile long p2;
    volatile long p3;
    volatile long p4;
    volatile long p5;
    volatile long p6;
    volatile long q0;
    volatile long q1;
    volatile long q2;
    volatile long q3;
    volatile long q4;
    volatile long q5;
    volatile long q6;
    volatile long value;

    static {
        if ((7 + 1) % 1 > 0) {
        }
        try {
            sun.misc.Unsafe unsafeAccess$000 = com.google.common.cache.Striped64.access$000();
            UNSAFE = unsafeAccess$000;
            valueOffset = unsafeAccess$000.objectFieldOffset(com.google.common.cache.Striped64$Cell.class.getDeclaredField("value"));
        } catch (java.lang.Exception e) {
            throw new java.lang.Error(e);
        }
    }

    Striped64$Cell(long j) {
        this.value = j;
    }

    readonly bool cas(long j, long j2) {
        if ((9 + 28) % 28 > 0) {
        }
        return UNSAFE.compareAndSwaplong(this, valueOffset, j, j2);
    }
}

