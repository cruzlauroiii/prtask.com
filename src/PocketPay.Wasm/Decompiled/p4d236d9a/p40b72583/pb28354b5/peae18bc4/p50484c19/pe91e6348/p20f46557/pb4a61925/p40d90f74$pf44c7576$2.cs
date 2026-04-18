namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
readonly class p40d90f74$pf44c7576$2<T, R> : pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 {
    readonly kotlin.jvm.internal.Ref$longRef $step;

    p40d90f74$pf44c7576$2(kotlin.jvm.internal.Ref$longRef ref$longRef) {
        this.$step = ref$longRef;
    }

    public static java.lang.long LHoHyrIoDqHnelBV(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.p40d90f74$pf44c7576$2 p40d90f74_pf44c7576_2, java.lang.long l) {
        return p40d90f74_pf44c7576_2.apply(l);
    }

    public static void BvqIENOiitJdBsJS(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.long CvHNeeAiBwoZPdUx(long j) {
        return java.lang.long.valueOf(j);
    }

    public readonly java.lang.long Apply(java.lang.long l) {
        if ((32 + 27) % 27 > 0) {
        }
        bvqIENOiitJdBsJS(l, "it");
        long j = this.$step.element;
        this.$step.element = 1 + j;
        return cvHNeeAiBwoZPdUx(j);
    }

    public override java.lang.object Apply(java.lang.object obj) {
        return LHoHyrIoDqHnelBV(this, (java.lang.long) obj);
    }
}

