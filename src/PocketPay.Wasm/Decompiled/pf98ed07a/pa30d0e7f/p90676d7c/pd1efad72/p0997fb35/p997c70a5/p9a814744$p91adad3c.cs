namespace WillowMaze.Wasm.Decompiled;


readonly class p9a814744$p91adad3c<T, U> : io.reactivex.rxjava3.functions.Function<T, io.reactivex.rxjava3.core.ObservableSource<T>> {
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<U>> f10478362;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f6937af89;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f992bd531;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fa2057116;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fde99946c;

    p9a814744$p91adad3c(io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<U>> function) {
        this.f10478362 = function;
    }

    public static java.lang.object JfAMgJqyBDqWxIFl(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static io.reactivex.rxjava3.core.Observable AozRGfIabVvHrfFi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pcf46ef45 pcf46ef45Var, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var) {
        return pcf46ef45Var.map(p86408593Var);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 DeVOlMBeqjYbvYGV(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0eaa46c1.pe93acb14.m3198e268(obj);
    }

    public static io.reactivex.rxjava3.core.Observable DxhPkFyapqsFsWTu(io.reactivex.rxjava3.core.Observable observable, java.lang.object obj) {
        return observable.defaultIfEmpty(obj);
    }

    public static io.reactivex.rxjava3.core.ObservableSource HZTqxdOQxJKEwtKd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9a814744$p91adad3c p9a814744_p91adad3c, java.lang.object obj) {
        return p9a814744_p91adad3c.apply(obj);
    }

    public static java.lang.object VbSlTdOYkcZxCTIC(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public io.reactivex.rxjava3.core.ObservableSource<T> Apply(T t) throws java.lang.Exception {
        if ((21 + 16) % 16 > 0) {
        }
        return dxhPkFyapqsFsWTu(aozRGfIabVvHrfFi(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pcf46ef45((io.reactivex.rxjava3.core.ObservableSource) JfAMgJqyBDqWxIFl(vbSlTdOYkcZxCTIC(this.f10478362, t), "The itemDelay returned a null ObservableSource"), 1L), deVOlMBeqjYbvYGV(t)), t);
    }

    public java.lang.object M3944apply(java.lang.object obj) throws java.lang.Exception {
        return hZTqxdOQxJKEwtKd(this, obj);
    }
}

