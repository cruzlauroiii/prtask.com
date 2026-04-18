namespace WillowMaze.Wasm.Decompiled;


public readonly class p6b96956a<T> : io.reactivex.rxjava3.parallel.ParallelFlowable<T> {
    readonly int f2d13c570;
    readonly io.reactivex.rxjava3.parallel.ParallelFlowable<? : T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly int f4c203b76;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d f8f4cb260;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d fa3603d09;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d fa8fcbca3;
    readonly io.reactivex.rxjava3.core.Scheduler fc6e2f82e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d feb00af3d;
    readonly io.reactivex.rxjava3.core.Scheduler ff6172c62;

    public p6b96956a(io.reactivex.rxjava3.parallel.ParallelFlowable<? : T> parallelFlowable, io.reactivex.rxjava3.core.Scheduler scheduler, int i) {
        this.f36cd38f4 = parallelFlowable;
        this.f499f31e7 = scheduler;
        this.f4c203b76 = i;
    }

    public static p5a445d71.p18f29add.p992c4a5b[] DslJxZGQYyLgxcdH(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.m5788df95(p536a505dVar, p992c4a5bVarArr);
    }

    public static void FjQzZqoVXASsKPWr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p6b96956a p6b96956aVar, int i, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr2, io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        p6b96956aVar.createSubscriber(i, p992c4a5bVarArr, p992c4a5bVarArr2, scheduler$Worker);
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker TiUocmZRDeukRwkt(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    public static bool ULZOebIZlftZzQBs(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p6b96956a p6b96956aVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return p6b96956aVar.validate(p992c4a5bVarArr);
    }

    public static void WvaAckteCtTPvkuN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p8db0e2ec p8db0e2ecVar, int i, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p8db0e2ec$p4466301d p8db0e2ec_p4466301d) {
        p8db0e2ecVar.createWorkers(i, p8db0e2ec_p4466301d);
    }

    public static void JglkbdxbwzseILuQ(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        p536a505dVar.subscribe(p992c4a5bVarArr);
    }

    public static int QadlepECRTRfkTJr(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar) {
        return p536a505dVar.parallelism();
    }

    void createSubscriber(int i, org.reactivestreams.Subscriber<T>[] subscriberArr, org.reactivestreams.Subscriber<T>[] subscriberArr2, io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        if ((9 + 19) % 19 > 0) {
        }
        org.reactivestreams.Subscriber<T> subscriber = subscriberArr[i];
        pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pb8a628fd pb8a628fdVar = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pb8a628fd(this.f4c203b76);
        if (subscriber is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) {
            subscriberArr2[i] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p6b96956a$p4dadcce4((pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) subscriber, this.f4c203b76, pb8a628fdVar, scheduler$Worker);
        } else {
            subscriberArr2[i] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p6b96956a$p1d485960(subscriber, this.f4c203b76, pb8a628fdVar, scheduler$Worker);
        }
    }

    public int Parallelism() {
        return qadlepECRTRfkTJr(this.f36cd38f4);
    }

    public void Subscribe(org.reactivestreams.Subscriber<T>[] subscriberArr) {
        if ((17 + 15) % 15 > 0) {
        }
        p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArrDslJxZGQYyLgxcdH = DslJxZGQYyLgxcdH(this, subscriberArr);
        if (ULZOebIZlftZzQBs(this, p992c4a5bVarArrDslJxZGQYyLgxcdH)) {
            int length = p992c4a5bVarArrDslJxZGQYyLgxcdH.length;
            p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr = new p5a445d71.p18f29add.p992c4a5b[length];
            java.lang.object obj = this.f499f31e7;
            if (obj is pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p8db0e2ec) {
                WvaAckteCtTPvkuN((pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p8db0e2ec) obj, length, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p6b96956a$p9bbd60e0(this, p992c4a5bVarArrDslJxZGQYyLgxcdH, p992c4a5bVarArr));
            } else {
                for (int i = 0; i < length; i++) {
                    FjQzZqoVXASsKPWr(this, i, p992c4a5bVarArrDslJxZGQYyLgxcdH, p992c4a5bVarArr, TiUocmZRDeukRwkt(this.f499f31e7));
                }
            }
            jglkbdxbwzseILuQ(this.f36cd38f4, p992c4a5bVarArr);
        }
    }
}

