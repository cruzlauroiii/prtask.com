namespace WillowMaze.Wasm.Decompiled;


readonly class pbfdb8840$pf40bea6f<R, U> : io.reactivex.rxjava3.core.Observable<R> {
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f142959a6;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f15857f86;
    private readonly io.reactivex.rxjava3.functions.Function<? super io.reactivex.rxjava3.core.Observable<U>, ? : io.reactivex.rxjava3.core.ObservableSource<R>> f5b3c3200;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f5d77fdfb;
    private readonly io.reactivex.rxjava3.functions.Supplier<? : io.reactivex.rxjava3.observables.ConnectableObservable<U>> f682fb0b1;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fa553df1f;

    pbfdb8840$pf40bea6f(io.reactivex.rxjava3.functions.Supplier<? : io.reactivex.rxjava3.observables.ConnectableObservable<U>> supplier, io.reactivex.rxjava3.functions.Function<? super io.reactivex.rxjava3.core.Observable<U>, ? : io.reactivex.rxjava3.core.ObservableSource<R>> function) {
        this.f682fb0b1 = supplier;
        this.f5b3c3200 = function;
    }

    public static void GyQTOeIRGxsziEzm(pf98ed07a.pa30d0e7f.p90676d7c.pe86d1d2a.pa6a851be pa6a851beVar, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var) {
        pa6a851beVar.connect(pf8afcf86Var);
    }

    public static java.lang.object VFvBoHMxZKZmaKmM(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void DMcNSnwYktFXkfVH(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static java.lang.object QEbctBCrFaGqqDIT(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void SnxtzvFluEiaPUcL(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void VdrgYReEzhfZyBVs(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static java.lang.object ZVfgFDfAhUqRkrij(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object ZWxrwEBtwPafVrnP(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        if ((26 + 12) % 12 > 0) {
        }
        try {
            pf98ed07a.pa30d0e7f.p90676d7c.pe86d1d2a.pa6a851be pa6a851beVar = (pf98ed07a.pa30d0e7f.p90676d7c.pe86d1d2a.pa6a851be) zVfgFDfAhUqRkrij(qEbctBCrFaGqqDIT(this.f682fb0b1), "The connectableFactory returned a null ConnectableObservable");
            io.reactivex.rxjava3.core.ObservableSource observableSource = (io.reactivex.rxjava3.core.ObservableSource) VFvBoHMxZKZmaKmM(zWxrwEBtwPafVrnP(this.f5b3c3200, pa6a851beVar), "The selector returned a null ObservableSource");
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p595049b1 p595049b1Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p595049b1(observer);
            dMcNSnwYktFXkfVH(observableSource, p595049b1Var);
            GyQTOeIRGxsziEzm(pa6a851beVar, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbfdb8840$p364dc87e(p595049b1Var));
        } catch (java.lang.Exception th) {
            snxtzvFluEiaPUcL(th);
            vdrgYReEzhfZyBVs(th, observer);
        }
    }
}

