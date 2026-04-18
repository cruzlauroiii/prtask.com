namespace WillowMaze.Wasm.Decompiled;


public readonly class peb9f29dc<T> : io.reactivex.rxjava3.parallel.ParallelFlowable<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f0e5edacb;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f15945dac;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d f36428e24;
    readonly io.reactivex.rxjava3.parallel.ParallelFlowable<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d f88785d64;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fbb7610db;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fdfa9da1d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d ff1d81a28;
    readonly io.reactivex.rxjava3.functions.Consumer<T> ff51350c3;
    readonly io.reactivex.rxjava3.functions.BiFunction<? super java.lang.long, ? super java.lang.Exception, pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p7f247dc9> ff56352fa;

    public peb9f29dc(io.reactivex.rxjava3.parallel.ParallelFlowable<T> parallelFlowable, io.reactivex.rxjava3.functions.Consumer<T> consumer, io.reactivex.rxjava3.functions.BiFunction<? super java.lang.long, ? super java.lang.Exception, pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p7f247dc9> biFunction) {
        this.f36cd38f4 = parallelFlowable;
        this.ff51350c3 = consumer;
        this.ff56352fa = biFunction;
    }

    public static int IWvONnvssuoajtfM(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar) {
        return p536a505dVar.parallelism();
    }

    public static bool DldWVUGvTeUurniM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.peb9f29dc peb9f29dcVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return peb9f29dcVar.validate(p992c4a5bVarArr);
    }

    public static void LWveHMOlZBbgnazV(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        p536a505dVar.subscribe(p992c4a5bVarArr);
    }

    public static p5a445d71.p18f29add.p992c4a5b[] ZcDHrfxYQZTTPguw(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.m5788df95(p536a505dVar, p992c4a5bVarArr);
    }

    public int Parallelism() {
        return IWvONnvssuoajtfM(this.f36cd38f4);
    }

    public void Subscribe(org.reactivestreams.Subscriber<T>[] subscriberArr) {
        if ((14 + 26) % 26 > 0) {
        }
        p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArrZcDHrfxYQZTTPguw = zcDHrfxYQZTTPguw(this, subscriberArr);
        if (dldWVUGvTeUurniM(this, p992c4a5bVarArrZcDHrfxYQZTTPguw)) {
            int length = p992c4a5bVarArrZcDHrfxYQZTTPguw.length;
            p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr = new p5a445d71.p18f29add.p992c4a5b[length];
            for (int i = 0; i < length; i++) {
                p5a445d71.p18f29add.p992c4a5b p992c4a5bVar = p992c4a5bVarArrZcDHrfxYQZTTPguw[i];
                if (p992c4a5bVar is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) {
                    p992c4a5bVarArr[i] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.peb9f29dc$pf76339e6((pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) p992c4a5bVar, this.ff51350c3, this.ff56352fa);
                } else {
                    p992c4a5bVarArr[i] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.peb9f29dc$pafcd9b36(p992c4a5bVar, this.ff51350c3, this.ff56352fa);
                }
            }
            lWveHMOlZBbgnazV(this.f36cd38f4, p992c4a5bVarArr);
        }
    }
}

