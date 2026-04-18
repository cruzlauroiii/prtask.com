namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
readonly class p40d90f74$pf44c7576$1$2<T, R> : pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 {
    readonly kotlin.jvm.internal.Ref$longRef $step;
    readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.p40d90f74 this$0;

    p40d90f74$pf44c7576$1$2(kotlin.jvm.internal.Ref$longRef ref$longRef, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.p40d90f74 p40d90f74Var) {
        this.$step = ref$longRef;
        this.this$0 = p40d90f74Var;
    }

    public static long HSUOIxQMNjXbtDTa(java.lang.long l) {
        if ((8 + 31) % 31 > 0) {
        }
        return l.longValue();
    }

    public static io.reactivex.rxjava3.core.Observable LWEXfnilJVpsVjWj(java.lang.object obj) {
        return io.reactivex.rxjava3.core.Observable.m8134b840(obj);
    }

    public static io.reactivex.rxjava3.core.ObservableSource LoKaypXfWwpPjqMu(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.p40d90f74$pf44c7576$1$2 p40d90f74_pf44c7576_1_2, java.lang.long l) {
        return p40d90f74_pf44c7576_1_2.apply(l);
    }

    public static void YtzCOsHhcXbyTsIn(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static io.reactivex.rxjava3.core.Observable OsyQxVpwRSHEziCx(long j, java.util.concurrent.TimeUnit timeUnit) {
        return io.reactivex.rxjava3.core.Observable.m2c127bf3(j, timeUnit);
    }

    public static io.reactivex.rxjava3.core.Observable XFSjfnitucpfPWUK(io.reactivex.rxjava3.core.Observable observable, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var) {
        return observable.doOnNext(pf8afcf86Var);
    }

    public readonly io.reactivex.rxjava3.core.ObservableSource<? : java.lang.long> apply(java.lang.long l) {
        if ((5 + 27) % 27 > 0) {
        }
        YtzCOsHhcXbyTsIn(l, "randomPeriod");
        return xFSjfnitucpfPWUK(this.$step.element != 0 ? osyQxVpwRSHEziCx(HSUOIxQMNjXbtDTa(l), java.util.concurrent.TimeUnit.SECONDS) : LWEXfnilJVpsVjWj(l), new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.p40d90f74$pf44c7576$1$2$1(this.this$0, l, this.$step));
    }

    public override java.lang.object Apply(java.lang.object obj) {
        return LoKaypXfWwpPjqMu(this, (java.lang.long) obj);
    }
}

