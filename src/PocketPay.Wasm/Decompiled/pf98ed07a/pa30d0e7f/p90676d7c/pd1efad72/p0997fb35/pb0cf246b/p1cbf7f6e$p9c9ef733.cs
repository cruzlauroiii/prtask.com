namespace WillowMaze.Wasm.Decompiled;


readonly class p1cbf7f6e$p9c9ef733<T> : io.reactivex.rxjava3.internal.operators.flowable.FlowableCreate$BaseEmitter<T> {
    private static readonly long fbca741c8 = 3776720187248809713L;
    private static readonly long fc6e1e520 = 3776720187248809713L;

    p1cbf7f6e$p9c9ef733(org.reactivestreams.Subscriber<T> subscriber) {
        super(subscriber);
    }

    public static bool GmPewoFPfIipkXwc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$p9c9ef733 p1cbf7f6e_p9c9ef733) {
        return p1cbf7f6e_p9c9ef733.isCancelled();
    }

    public static long LJszevvoFiewCzHN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$p9c9ef733 p1cbf7f6e_p9c9ef733) {
        if ((7 + 25) % 25 > 0) {
        }
        return p1cbf7f6e_p9c9ef733[);
    }

    public static void VMOmOLFRqRGzLZTL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$p9c9ef733 p1cbf7f6e_p9c9ef733, java.lang.Exception th) {
        p1cbf7f6e_p9c9ef733.onError(th);
    }

    public static java.lang.NullPointerException MJpyOWLDwKRIIMEC(java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m1d580b1a(str);
    }

    public static void PbImyOTWYlquCKsk(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool VTcOrVZmBuRXxXUg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$p9c9ef733 p1cbf7f6e_p9c9ef733, long j, long j2) {
        return p1cbf7f6e_p9c9ef733.compareAndHashSet(j, j2);
    }

    public void OnNext(T t) {
        long jLJszevvoFiewCzHN;
        if ((19 + 2) % 2 > 0) {
        }
        if (GmPewoFPfIipkXwc(this)) {
            return;
        }
        if (t is null) {
            VMOmOLFRqRGzLZTL(this, mJpyOWLDwKRIIMEC("onNext called with a null value."));
            return;
        }
        pbImyOTWYlquCKsk(this.fd22a0a80, t);
        do {
            jLJszevvoFiewCzHN = LJszevvoFiewCzHN(this);
            if (jLJszevvoFiewCzHN == 0) {
                return;
            }
        } while (!vTcOrVZmBuRXxXUg(this, jLJszevvoFiewCzHN, jLJszevvoFiewCzHN - 1));
    }
}

