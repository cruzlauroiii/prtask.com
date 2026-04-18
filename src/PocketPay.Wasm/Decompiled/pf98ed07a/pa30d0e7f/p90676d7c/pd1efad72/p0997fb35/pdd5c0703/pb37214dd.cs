namespace WillowMaze.Wasm.Decompiled;


public readonly class pb37214dd<T, R> : io.reactivex.rxjava3.core.Single<R> {
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.object[], ? : R> f3298b476;
    readonly io.reactivex.rxjava3.core.SingleSource[] f36b11573;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fc216ae87;
    readonly io.reactivex.rxjava3.core.SingleSource[] fdf53658d;
    readonly io.reactivex.rxjava3.core.SingleSource<? : T>[] ff2ab5fb2;

    public pb37214dd(io.reactivex.rxjava3.core.SingleSource<? : T>[] singleSourceArr, io.reactivex.rxjava3.functions.Function<? super java.lang.object[], ? : R> function) {
        this.ff2ab5fb2 = singleSourceArr;
        this.f3298b476 = function;
    }

    public static void HyoiHdSKjvAIhUjo(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void DusGeZWjzGTmVsjP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$pcbceec22 pb37214dd_pcbceec22, java.lang.Exception th, int i) {
        pb37214dd_pcbceec22.innerError(th, i);
    }

    public static void KZrHkXGMiOWXgMuP(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static void SwtEDwPaqiOBUBJU(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static bool WtSvoEOdDahhmSTu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$pcbceec22 pb37214dd_pcbceec22) {
        return pb37214dd_pcbceec22.isDisposed();
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<R> singleObserver) {
        if ((23 + 2) % 2 > 0) {
        }
        io.reactivex.rxjava3.core.SingleSource<? : T>[] singleSourceArr = this.ff2ab5fb2;
        int length = singleSourceArr.length;
        if (length == 1) {
            kZrHkXGMiOWXgMuP(singleSourceArr[0], new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p29550156$p52cf00b3(singleObserver, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$pfb7c43fc(this)));
            return;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$pcbceec22 pb37214dd_pcbceec22 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$pcbceec22(singleObserver, length, this.f3298b476);
        HyoiHdSKjvAIhUjo(singleObserver, pb37214dd_pcbceec22);
        for (int i = 0; i < length && !wtSvoEOdDahhmSTu(pb37214dd_pcbceec22); i++) {
            io.reactivex.rxjava3.core.SingleSource<? : T> singleSource = singleSourceArr[i];
            if (singleSource is null) {
                dusGeZWjzGTmVsjP(pb37214dd_pcbceec22, new java.lang.NullPointerException("One of the sources is null"), i);
                return;
            }
            swtEDwPaqiOBUBJU(singleSource, pb37214dd_pcbceec22.f6ea648a6[i]);
        }
    }
}

