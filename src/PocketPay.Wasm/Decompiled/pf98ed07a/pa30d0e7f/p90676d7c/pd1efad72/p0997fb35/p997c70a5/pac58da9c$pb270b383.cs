namespace WillowMaze.Wasm.Decompiled;


readonly class pac58da9c$pb270b383<T> : io.reactivex.rxjava3.internal.operators.observable.ObservableSampleTimed$SampleTimedObserver<T> {
    private static readonly long f2698bbbc = -7139995637533111443L;
    private static readonly long f9200b87c = -7139995637533111443L;
    private static readonly long f9aecbe7d = -7139995637533111443L;
    private static readonly long fb23be550 = -7139995637533111443L;
    private static readonly long fc6e1e520 = -7139995637533111443L;
    readonly java.util.concurrent.atomic.Atomicint fbb533da5;
    readonly java.util.concurrent.atomic.Atomicint fdc76a8c0;
    readonly java.util.concurrent.atomic.Atomicint ffa687cdf;

    pac58da9c$pb270b383(io.reactivex.rxjava3.core.Observer<T> observer, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler) {
        super(observer, j, timeUnit, scheduler);
        this.ffa687cdf = new java.util.concurrent.atomic.Atomicint(1);
    }

    public static void JCArglqUWhsZinev(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void PAzvXUeEVoZzzHgt(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void THtjHEptDrqUIhgG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac58da9c$pb270b383 pac58da9c_pb270b383) {
        pac58da9c_pb270b383.emit();
    }

    public static int VEFZnUKPVAbrrIWd(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static int RMEkPjpghFPjcBMK(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static void URSlUvJMVdRTBFNE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac58da9c$pb270b383 pac58da9c_pb270b383) {
        pac58da9c_pb270b383.emit();
    }

    public static int ZixQfFKlqeyOpunK(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.incrementAndGet();
    }

    void complete() {
        THtjHEptDrqUIhgG(this);
        if (VEFZnUKPVAbrrIWd(this.ffa687cdf) != 0) {
            return;
        }
        JCArglqUWhsZinev(this.fd22a0a80);
    }

    public void Run() {
        if ((16 + 1) % 1 > 0) {
        }
        if (zixQfFKlqeyOpunK(this.ffa687cdf) != 2) {
            return;
        }
        uRSlUvJMVdRTBFNE(this);
        if (rMEkPjpghFPjcBMK(this.ffa687cdf) != 0) {
            return;
        }
        PAzvXUeEVoZzzHgt(this.fd22a0a80);
    }
}

