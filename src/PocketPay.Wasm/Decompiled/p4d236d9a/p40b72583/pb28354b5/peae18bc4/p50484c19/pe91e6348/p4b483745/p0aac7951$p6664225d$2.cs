namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
readonly class p0aac7951$p6664225d$2<T1, T2> : pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 {
    public static readonly com.psr.top.sdk.kernel.security.playIntegrity.PlayIntegrityApiImpl$playIntegrityAttestation$2<T1, T2> f76425f17 = new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p4b483745.p0aac7951$p6664225d$2();
    public static readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p4b483745.p0aac7951$p6664225d$2 f77458d69 = null;

    p0aac7951$p6664225d$2() {
    }

    public static void BFQTftIEgDhIEgED(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int CjZVbKnGRwxNHUgF(java.lang.int num) {
        return num.intValue();
    }

    public static void XYqbbmHWKzMWZprN(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool XfvuXhUJuwfxsDvP(java.lang.Exception th) {
        return p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.p7ce1c91c.m1803ab56(th);
    }

    public static bool DmmAeQPJhJPXkAIb(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p4b483745.p0aac7951$p6664225d$2 p0aac7951_p6664225d_2, java.lang.int num, java.lang.Exception th) {
        return p0aac7951_p6664225d_2.test(num, th);
    }

    public readonly bool Test(java.lang.int num, java.lang.Exception th) {
        XYqbbmHWKzMWZprN(num, "times");
        BFQTftIEgDhIEgED(th, "throwable");
        return XfvuXhUJuwfxsDvP(th) && CjZVbKnGRwxNHUgF(num) < 5;
    }

    public override bool Test(java.lang.object obj, java.lang.object obj2) {
        return dmmAeQPJhJPXkAIb(this, (java.lang.int) obj, (java.lang.Exception) obj2);
    }
}

