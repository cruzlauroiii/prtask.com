namespace WillowMaze.Wasm.Decompiled;


public readonly class pcf5d413f<T> : io.reactivex.rxjava3.core.Observable<T> {
    readonly java.lang.IEnumerable<? : T> f36cd38f4;
    readonly java.lang.IEnumerable f96ca670b;
    readonly java.lang.IEnumerable fb5bc8b15;
    readonly java.lang.IEnumerable fca56cee4;

    public pcf5d413f(java.lang.IEnumerable<? : T> iterable) {
        this.f36cd38f4 = iterable;
    }

    public static void ArldPzygTSOyoaEk(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void FFwSQxkrgVJVzYpB(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool FyajTPjZioZUfYoA(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void GxNmoqheLjERNWlG(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void MKxdOxvGtUhjQPSn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pcf5d413f$p7c8f879e pcf5d413f_p7c8f879e) {
        pcf5d413f_p7c8f879e.run();
    }

    public static void PEspLvsgJzdOXauO(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void RCsvTVsUMltNGiSE(io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.complete((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void VgZOrdmAwIuixhoN(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static java.util.IEnumerator XjpqUAkfSPTIdSiv(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        try {
            java.util.IEnumerator itXjpqUAkfSPTIdSiv = xjpqUAkfSPTIdSiv(this.f36cd38f4);
            try {
                if (!FyajTPjZioZUfYoA(itXjpqUAkfSPTIdSiv)) {
                    RCsvTVsUMltNGiSE(observer);
                    return;
                }
                pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pcf5d413f$p7c8f879e pcf5d413f_p7c8f879e = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pcf5d413f$p7c8f879e(observer, itXjpqUAkfSPTIdSiv);
                VgZOrdmAwIuixhoN(observer, pcf5d413f_p7c8f879e);
                if (pcf5d413f_p7c8f879e.f06b7c4ff) {
                    return;
                }
                MKxdOxvGtUhjQPSn(pcf5d413f_p7c8f879e);
            } catch (java.lang.Exception th) {
                PEspLvsgJzdOXauO(th);
                GxNmoqheLjERNWlG(th, observer);
            }
        } catch (java.lang.Exception th2) {
            FFwSQxkrgVJVzYpB(th2);
            ArldPzygTSOyoaEk(th2, observer);
        }
    }
}

