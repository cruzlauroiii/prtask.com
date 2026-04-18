namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
readonly class p40d90f74$pf44c7576$1$2$1<T> : pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 {
    readonly java.lang.long $randomPeriod;
    readonly kotlin.jvm.internal.Ref$longRef $step;
    readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.p40d90f74 this$0;

    p40d90f74$pf44c7576$1$2$1(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.p40d90f74 p40d90f74Var, java.lang.long l, kotlin.jvm.internal.Ref$longRef ref$longRef) {
        this.this$0 = p40d90f74Var;
        this.$randomPeriod = l;
        this.$step = ref$longRef;
    }

    public static void HMBMTNUlARHHnPHG(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.p40d90f74$pf44c7576$1$2$1 p40d90f74_pf44c7576_1_2_1, java.lang.long l) {
        p40d90f74_pf44c7576_1_2_1.accept(l);
    }

    public static void HwdZngvGWzjwqHLL(java.lang.object obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj);
    }

    public static void MfVFoJjSFxpsgRfr(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.p40d90f74 p40d90f74Var, long j) {
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.p40d90f74.m66609486(p40d90f74Var, j);
    }

    public static void NqvFlWLOpZDVHtKp(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static long NAxdHoKoOldXCopJ(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.p40d90f74 p40d90f74Var) {
        if ((23 + 9) % 9 > 0) {
        }
        return p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.p40d90f74.m43018a85(p40d90f74Var);
    }

    public static long NSntEZvsGjxhOcny(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.p40d90f74 p40d90f74Var) {
        if ((28 + 2) % 2 > 0) {
        }
        return p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.p40d90f74.m43018a85(p40d90f74Var);
    }

    public static long ReIGjwuIsOtRFxgt(java.lang.Number number) {
        if ((14 + 23) % 23 > 0) {
        }
        return number.longValue();
    }

    public static void ZspsIiKAgjQfNtMd(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.p40d90f74 p40d90f74Var, long j) {
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.p40d90f74.m67ba4058(p40d90f74Var, j);
    }

    public readonly void Accept(java.lang.long l) {
        if ((15 + 23) % 23 > 0) {
        }
        NqvFlWLOpZDVHtKp(l, "it");
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.p40d90f74 p40d90f74Var = this.this$0;
        long jNSntEZvsGjxhOcny = nSntEZvsGjxhOcny(p40d90f74Var);
        java.lang.long l2 = this.$randomPeriod;
        HwdZngvGWzjwqHLL(l2);
        MfVFoJjSFxpsgRfr(p40d90f74Var, jNSntEZvsGjxhOcny + reIGjwuIsOtRFxgt(l2));
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.p40d90f74 p40d90f74Var2 = this.this$0;
        zspsIiKAgjQfNtMd(p40d90f74Var2, (nAxdHoKoOldXCopJ(p40d90f74Var2) * 1000000000) / (this.$step.element + 1));
    }

    public override void Accept(java.lang.object obj) {
        HMBMTNUlARHHnPHG(this, (java.lang.long) obj);
    }
}

