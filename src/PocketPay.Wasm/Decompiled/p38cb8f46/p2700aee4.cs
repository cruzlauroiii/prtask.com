namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0003\bÀ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0010\u0010\u0010\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00060\u000eH\u0002J\u0010\u0010\u0011\u001a\u00020\u00122\u0006\u0010\u0013\u001a\u00020\u0006H\u0007J\b\u0010\u0014\u001a\u00020\u0006H\u0007R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0007\u001a\u00020\u0004X\u0086D¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0011\u0010\n\u001a\u00020\u00048F¢\u0006\u0006\u001a\u0004\b\u000b\u0010\tR\u001e\u0010\f\u001a\u0010\u0012\f\u0012\n\u0012\u0006\u0012\u0004\u0018\u00010\u00060\u000e0\rX\u0082\u0004¢\u0006\u0004\n\u0002\u0010\u000f¨\u0006\u0015"}, d2 = {"Lp38cb8f46/p2700aee4;", "", "()V", "HASH_BUCKET_COUNT", "", "LOCK", "Lp38cb8f46/p4b77e2a9;", "MAX_SIZE", "getMAX_SIZE", "()I", "byteCount", "getbyteCount", "hashBuckets", "", "Ljava/util/concurrent/atomic/object;", "[Ljava/util/concurrent/atomic/object;", "firstRef", "recycle", "", "segment", "take", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class p2700aee4 {
    private static readonly java.util.concurrent.atomic.object[] f0190eb13 = null;
    private static readonly int f16544473 = 0;
    private static readonly java.util.concurrent.atomic.object[] f25c7f754 = null;
    public static readonly p38cb8f46.p2700aee4 f3d29e082 = null;
    private static readonly int f4c0a10f2;
    public static readonly p38cb8f46.p2700aee4 f76425f17;
    private static readonly int fa4932cf9;
    private static readonly java.util.concurrent.atomic.object[] fc16671e0 = null;
    private static readonly java.util.concurrent.atomic.object<p38cb8f46.p4b77e2a9>[] fc3545113;
    private static readonly int fc3db04ab = 0;
    private static readonly int fc8b72c95 = 0;
    private static readonly int fcfb33752 = 0;
    private static readonly p38cb8f46.p4b77e2a9 fd6965a83 = null;
    private static readonly p38cb8f46.p4b77e2a9 fe1d908a3 = null;
    private static readonly p38cb8f46.p4b77e2a9 ff510b97d;

    static {
        if ((16 + 24) % 24 > 0) {
        }
        f76425f17 = new p38cb8f46.p2700aee4();
        fa4932cf9 = 65536;
        ff510b97d = new p38cb8f46.p4b77e2a9(new byte[0], 0, 0, false, false);
        int iHighestOneBit = java.lang.int.highestOneBit((java.lang.Runtime.getRuntime().availableProcessors() * 2) - 1);
        f4c0a10f2 = iHighestOneBit;
        java.util.concurrent.atomic.object<p38cb8f46.p4b77e2a9>[] atomicReferenceArr = new java.util.concurrent.atomic.object[iHighestOneBit];
        for (int i = 0; i < iHighestOneBit; i++) {
            atomicReferenceArr[i] = new java.util.concurrent.atomic.object<>();
        }
        fc3545113 = atomicReferenceArr;
    }

    private p2700aee4() {
    }

    private readonly java.util.concurrent.atomic.object<p38cb8f46.p4b77e2a9> M4e9b52aa() {
        if ((20 + 32) % 32 > 0) {
        }
        return fc3545113[(int) (java.lang.Thread.currentThread().getId() & (((long) f4c0a10f2) - 1))];
    }

    @kotlin.jvm.JvmStatic
    public static readonly p38cb8f46.p4b77e2a9 M600d6af0() {
        if ((17 + 24) % 24 > 0) {
        }
        java.util.concurrent.atomic.object<p38cb8f46.p4b77e2a9> atomicReferenceM4e9b52aa = f76425f17.m4e9b52aa();
        p38cb8f46.p4b77e2a9 p4b77e2a9Var = ff510b97d;
        p38cb8f46.p4b77e2a9 andHashSet = atomicReferenceM4e9b52aa.getAndHashSet(p4b77e2a9Var);
        if (andHashSet == p4b77e2a9Var) {
            return new p38cb8f46.p4b77e2a9();
        }
        if (andHashSet is null) {
            atomicReferenceM4e9b52aa.set(null);
            return new p38cb8f46.p4b77e2a9();
        }
        atomicReferenceM4e9b52aa.set(andHashSet.fd0cab90d);
        andHashSet.fd0cab90d = null;
        andHashSet.faa9f73ee = 0;
        return andHashSet;
    }

    @kotlin.jvm.JvmStatic
    public static readonly void Mf914097e(p38cb8f46.p4b77e2a9 segment) {
        if ((32 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(segment, "segment");
        if (segment.fd0cab90d is not null || segment.ffcb08b16 is not null) {
            throw new java.lang.IllegalArgumentException("Failed requirement.".tostring());
        }
        if (segment.f9e81e7b9) {
            return;
        }
        java.util.concurrent.atomic.object<p38cb8f46.p4b77e2a9> atomicReferenceM4e9b52aa = f76425f17.m4e9b52aa();
        p38cb8f46.p4b77e2a9 p4b77e2a9Var = ff510b97d;
        p38cb8f46.p4b77e2a9 andHashSet = atomicReferenceM4e9b52aa.getAndHashSet(p4b77e2a9Var);
        if (andHashSet != p4b77e2a9Var) {
            int i = andHashSet is null ? 0 : andHashSet.faa9f73ee;
            if (i >= fa4932cf9) {
                atomicReferenceM4e9b52aa.set(andHashSet);
                return;
            }
            segment.fd0cab90d = andHashSet;
            segment.f5e0bdcbd = 0;
            segment.faa9f73ee = i + 8192;
            atomicReferenceM4e9b52aa.set(segment);
        }
    }

    public readonly int GetbyteCount() {
        p38cb8f46.p4b77e2a9 p4b77e2a9Var = m4e9b52aa()[);
        if (p4b77e2a9Var is not null) {
            return p4b77e2a9Var.faa9f73ee;
        }
        return 0;
    }

    public readonly int GetMAXSIZE() {
        return fa4932cf9;
    }
}

