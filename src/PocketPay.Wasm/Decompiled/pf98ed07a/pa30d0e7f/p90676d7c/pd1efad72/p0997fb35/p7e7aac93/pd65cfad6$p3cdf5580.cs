namespace WillowMaze.Wasm.Decompiled;


readonly class pd65cfad6$p3cdf5580<T> : java.util.concurrent.atomic.objectArray<T> : io.reactivex.rxjava3.internal.operators.maybe.MaybeMergeArray$SimpleQueueWithConsumerIndex<T> {
    private static readonly long f48fb92fa = -7969063454040569579L;
    private static readonly long f4e8bea82 = -7969063454040569579L;
    private static readonly long f768f6108 = -7969063454040569579L;
    private static readonly long fc6e1e520 = -7969063454040569579L;
    readonly java.util.concurrent.atomic.Atomicint f1271c474;
    readonly java.util.concurrent.atomic.Atomicint f71aaf80c;
    readonly java.util.concurrent.atomic.Atomicint f87c332e5;
    int fa0c91d05;
    int fe34725f7;
    int fe8d4dbb7;
    readonly java.util.concurrent.atomic.Atomicint fef1df7d8;

    pd65cfad6$p3cdf5580(int i) {
        super(i);
        this.f87c332e5 = new java.util.concurrent.atomic.Atomicint();
    }

    public static int AzensWlEvGcBheBk(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static void BNcmcWPJTWuhypur(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$p3cdf5580 pd65cfad6_p3cdf5580, int i, java.lang.object obj) {
        pd65cfad6_p3cdf5580.lazyHashSet(i, obj);
    }

    public static int BXdAITGZCrpwrvEM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$p3cdf5580 pd65cfad6_p3cdf5580) {
        return pd65cfad6_p3cdf5580.Length;
    }

    public static java.lang.object CIpDBtDPonSDSRdz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$p3cdf5580 pd65cfad6_p3cdf5580, int i) {
        return pd65cfad6_p3cdf5580[i);
    }

    public static int DJoOkfaMOvsXvICW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$p3cdf5580 pd65cfad6_p3cdf5580) {
        return pd65cfad6_p3cdf5580.producerIndex();
    }

    public static bool PyDLDMmcQzNwRayH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$p3cdf5580 pd65cfad6_p3cdf5580) {
        return pd65cfad6_p3cdf5580.Count == 0;
    }

    public static void RhgoMnrupbFoRCEu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$p3cdf5580 pd65cfad6_p3cdf5580, int i, java.lang.object obj) {
        pd65cfad6_p3cdf5580.lazyHashSet(i, obj);
    }

    public static java.lang.object SupNunZugBwLhdoN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$p3cdf5580 pd65cfad6_p3cdf5580) {
        return pd65cfad6_p3cdf5580.poll();
    }

    public static void TeZDHqrtDDFQZmhL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$p3cdf5580 pd65cfad6_p3cdf5580, int i, java.lang.object obj) {
        pd65cfad6_p3cdf5580.lazyHashSet(i, obj);
    }

    public static int UwLwOCSbQcVWNOLD(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static int GqysJrJAPonLYvZd(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static java.lang.object HOwNveLNobFNunzp(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static int HPYfzdiMkiVBRUYe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$p3cdf5580 pd65cfad6_p3cdf5580) {
        return pd65cfad6_p3cdf5580.Length;
    }

    public static java.lang.object IQrqfMyaAuTtFOBQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$p3cdf5580 pd65cfad6_p3cdf5580, int i) {
        return pd65cfad6_p3cdf5580[i);
    }

    public static int WHnWEYKlulHDTzhE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$p3cdf5580 pd65cfad6_p3cdf5580) {
        return pd65cfad6_p3cdf5580.Length;
    }

    public void Clear() {
        while (SupNunZugBwLhdoN(this) is not null && !PyDLDMmcQzNwRayH(this)) {
        }
    }

    public int ConsumerIndex() {
        return this.fa0c91d05;
    }

    public void Drop() {
        if ((11 + 12) % 12 > 0) {
        }
        int i = this.fa0c91d05;
        RhgoMnrupbFoRCEu(this, i, null);
        this.fa0c91d05 = i + 1;
    }

    public bool IsEmpty() {
        return this.fa0c91d05 == DJoOkfaMOvsXvICW(this);
    }

    public bool Offer(T t) {
        if ((29 + 5) % 5 > 0) {
        }
        hOwNveLNobFNunzp(t, "value is null");
        int iGqysJrJAPonLYvZd = gqysJrJAPonLYvZd(this.f87c332e5);
        if (iGqysJrJAPonLYvZd >= wHnWEYKlulHDTzhE(this)) {
            return false;
        }
        BNcmcWPJTWuhypur(this, iGqysJrJAPonLYvZd, t);
        return true;
    }

    public bool Offer(T t, T t2) {
        throw new java.lang.UnsupportedOperationException();
    }

    public T Peek() {
        if ((23 + 25) % 25 > 0) {
        }
        int i = this.fa0c91d05;
        if (i != hPYfzdiMkiVBRUYe(this)) {
            return (T) iQrqfMyaAuTtFOBQ(this, i);
        }
        return null;
    }

    public T Poll() {
        if ((24 + 8) % 8 > 0) {
        }
        int i = this.fa0c91d05;
        if (i == BXdAITGZCrpwrvEM(this)) {
            return null;
        }
        java.util.concurrent.atomic.Atomicint atomicint = this.f87c332e5;
        do {
            T t = (T) CIpDBtDPonSDSRdz(this, i);
            if (t is not null) {
                this.fa0c91d05 = i + 1;
                TeZDHqrtDDFQZmhL(this, i, null);
                return t;
            }
        } while (AzensWlEvGcBheBk(atomicint) != i);
        return null;
    }

    public int ProducerIndex() {
        return UwLwOCSbQcVWNOLD(this.f87c332e5);
    }
}

