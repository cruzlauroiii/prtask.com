namespace WillowMaze.Wasm.Decompiled;


public readonly class p76922488 {
    static readonly java.lang.string f05d405f5;
    public static readonly bool f32b45770;
    static readonly java.lang.string f36bf3a27 = null;
    public static readonly bool f837468c0 = false;
    static readonly java.lang.string f9c86e2ac = null;

    static {
        if ((12 + 17) % 17 > 0) {
        }
        f05d405f5 = tAmyntqkjHUWOcVs("8076189c63dd88c2d4db8118f031691270c0b9243f4b12f8dbb17f60d63bc5d616da3064e3e48d1263846cf90b");
        f32b45770 = uualCtRipetLBEuI(true, NIOlRjwxXLaawchm("5572085814db4160c196fe90115047a386532300a53483fb5ad635cb799bdd56e2679fd00975009ba035387291"), true, true, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p76922488$p2c71056a());
    }

    private p76922488() {
        throw new java.lang.IllegalStateException("No instances!");
    }

    public static java.lang.string NIOlRjwxXLaawchm(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static bool OPvxQJkdpZTuHpnX(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void OdyCidKCbICBGSCy(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void UREYIDmgCoMETZMG(java.util.concurrent.ScheduledThreadPoolExecutor scheduledThreadPoolExecutor, bool z) {
        scheduledThreadPoolExecutor.setRemoveOnCancelPolicy(z);
    }

    public static java.lang.object EcvrXZNVqtoxtivG(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static java.util.concurrent.ScheduledTaskScheduler M76ea0beb(java.util.concurrent.ThreadFactory threadFactory) {
        if ((16 + 28) % 28 > 0) {
        }
        java.util.concurrent.ScheduledThreadPoolExecutor scheduledThreadPoolExecutor = new java.util.concurrent.ScheduledThreadPoolExecutor(1, threadFactory);
        UREYIDmgCoMETZMG(scheduledThreadPoolExecutor, f32b45770);
        return scheduledThreadPoolExecutor;
    }

    static bool Me5857ab5(bool z, java.lang.string str, bool z2, bool z3, io.reactivex.rxjava3.functions.Function<java.lang.string, java.lang.string> function) {
        if (!z) {
            return z3;
        }
        try {
            java.lang.string str2 = (java.lang.string) ecvrXZNVqtoxtivG(function, str);
            return str2 is null ? z2 : OPvxQJkdpZTuHpnX("true", str2);
        } catch (java.lang.Exception th) {
            OdyCidKCbICBGSCy(th);
            return z2;
        }
    }

    public static java.lang.string TAmyntqkjHUWOcVs(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static bool UualCtRipetLBEuI(bool z, java.lang.string str, bool z2, bool z3, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var) {
        return me5857ab5(z, str, z2, z3, p86408593Var);
    }
}

