namespace WillowMaze.Wasm.Decompiled;


readonly class p93865d37$p026ea0cd<T> : java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f304ad509 = 7224554242710036740L;
    private static readonly long f398a514e = 7224554242710036740L;
    private static readonly long f4ac755ef = 7224554242710036740L;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916[] f5e14808f = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916[] f5fad17c2 = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916[] f813c5910 = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916[] f86dfe5ab = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916[] f9d725163;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916[] fba2b45bd;
    private static readonly long fc6e1e520 = 7224554242710036740L;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916[] fe355856e = null;
    private static readonly long ffa9bbf04 = 7224554242710036740L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p244f52bf f07f2d795;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p244f52bf f27449ce0;
    long f393dae50;
    readonly java.util.concurrent.atomic.Atomicint f3e020748;
    readonly java.util.concurrent.atomic.object<io.reactivex.rxjava3.internal.operators.flowable.FlowableReplay$ReplaySubscriber<T>> f43b5c917;
    readonly java.util.concurrent.atomic.object f46a3938a;
    bool f49c7656b;
    readonly java.util.concurrent.atomic.Atomicbool f636a9771;
    bool f6b2ded51;
    long f73ec2e13;
    bool f7a185399;
    readonly java.util.concurrent.atomic.object f7cdaa5d8;
    readonly io.reactivex.rxjava3.internal.operators.flowable.FlowableReplay$ReplayBuffer<T> f7f2db423;
    readonly java.util.concurrent.atomic.Atomicbool f8f1c76fb;
    bool fa9e21024;
    readonly java.util.concurrent.atomic.object fbab0798f;
    bool fcc210636;
    readonly java.util.concurrent.atomic.object fd4d88f90;
    long fe038aef2;
    readonly java.util.concurrent.atomic.Atomicbool ff4e3caf5;
    readonly java.util.concurrent.atomic.object ffcb8fddd;
    readonly java.util.concurrent.atomic.Atomicint fd10af457 = new java.util.concurrent.atomic.Atomicint();
    readonly java.util.concurrent.atomic.object<io.reactivex.rxjava3.internal.operators.flowable.FlowableReplay$InnerSubscription<T>[]> faae7b662 = new java.util.concurrent.atomic.object<>(fba2b45bd);
    readonly java.util.concurrent.atomic.Atomicbool f8255aadd = new java.util.concurrent.atomic.Atomicbool();

    static {
        if ((16 + 5) % 5 > 0) {
        }
        fba2b45bd = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916[0];
        f9d725163 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916[0];
    }

    p93865d37$p026ea0cd(io.reactivex.rxjava3.internal.operators.flowable.FlowableReplay$ReplayBuffer<T> flowableReplay$ReplayBuffer, java.util.concurrent.atomic.object<io.reactivex.rxjava3.internal.operators.flowable.FlowableReplay$ReplaySubscriber<T>> atomicReference) {
        this.f7f2db423 = flowableReplay$ReplayBuffer;
        this.f43b5c917 = atomicReference;
    }

    public static java.lang.object AyRqefDhCbOUJGtK(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        return atomicReference.getAndHashSet(obj);
    }

    public static bool FcLrMAbPRpJAKMMG(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static void JKHDcxrULPciESwp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p244f52bf p93865d37_p244f52bf, java.lang.Exception th) {
        p93865d37_p244f52bf.error(th);
    }

    public static bool JzpmIwcaGWgnXibb(java.util.concurrent.atomic.object atomicReference, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.setOnce(atomicReference, p787ad0b7Var);
    }

    public static void KbTEQTQsecloHYwN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p244f52bf p93865d37_p244f52bf, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916 p93865d37_pf25af916) {
        p93865d37_p244f52bf.replay(p93865d37_pf25af916);
    }

    public static void LSUDBtBbFxwCOOxb(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.set(obj);
    }

    public static java.lang.object MxAYlPIGyQlTcDOd(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void OsywZPGfJcZeddfY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p026ea0cd p93865d37_p026ea0cd) {
        p93865d37_p026ea0cd.manageRequests();
    }

    public static java.lang.object PqvYZYyfLTnBqKKi(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void RNCQmXqVBrfPxtaT(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static long RPbHtfjazRcnlnQy(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((1 + 16) % 16 > 0) {
        }
        return atomiclong[);
    }

    public static java.lang.object UTUNiGIoRwHJRuET(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool WPdZwKvYmlnJNkzZ(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static bool ZQuquQQFzeqLnaGa(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static void ZcdsdDCIvZeQvHth(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void BIosvlEDxhkAVgwn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p244f52bf p93865d37_p244f52bf, java.lang.object obj) {
        p93865d37_p244f52bf.next(obj);
    }

    public static bool CwCbIodTqcXEgjQH(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static int DLZOJnWCByWEcnHd(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static void DUvNtLEjKOheiooV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p244f52bf p93865d37_p244f52bf, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916 p93865d37_pf25af916) {
        p93865d37_p244f52bf.replay(p93865d37_pf25af916);
    }

    public static void HWQAVtjlirUWIvBj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p244f52bf p93865d37_p244f52bf, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916 p93865d37_pf25af916) {
        p93865d37_p244f52bf.replay(p93865d37_pf25af916);
    }

    public static long IBEZgHxAFXZXwRpx(long j, long j2) {
        if ((22 + 10) % 10 > 0) {
        }
        return java.lang.Math.max(j, j2);
    }

    public static void IpHBPrGCraTbYNMb(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static java.lang.object MWDIZzxsfZsUwfHM(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void MnCwSClFncXbOtio(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p244f52bf p93865d37_p244f52bf) {
        p93865d37_p244f52bf.complete();
    }

    public static int ONYVzAWykXieDDSt(java.util.concurrent.atomic.Atomicint atomicint, int i) {
        return atomicint.addAndGet(i);
    }

    public static void OZcUWWkAjhWXifdD(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static bool PFbykUZkRkGSSRja(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p026ea0cd p93865d37_p026ea0cd) {
        return p93865d37_p026ea0cd.isDisposed();
    }

    public static bool PsPTFvgwEuhKmAHJ(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static java.lang.object RoHPJKqzdufZwDUn(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object UIqFTXiUvTKdsGQk(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        return atomicReference.getAndHashSet(obj);
    }

    public static void UfzdFJIUfrKEHLBr(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.object WNMktDvaKnyZbXOa(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void XJBFCkszEVukdmkN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p244f52bf p93865d37_p244f52bf, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916 p93865d37_pf25af916) {
        p93865d37_p244f52bf.replay(p93865d37_pf25af916);
    }

    public static java.lang.object YuHtTejpUouykTKx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p026ea0cd p93865d37_p026ea0cd) {
        return p93865d37_p026ea0cd[);
    }

    bool add(io.reactivex.rxjava3.internal.operators.flowable.FlowableReplay$InnerSubscription<T> flowableReplay$InnerSubscription) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916[] p93865d37_pf25af916Arr;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916[] p93865d37_pf25af916Arr2;
        if ((14 + 3) % 3 > 0) {
        }
        do {
            p93865d37_pf25af916Arr = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916[]) PqvYZYyfLTnBqKKi(this.faae7b662);
            if (p93865d37_pf25af916Arr == f9d725163) {
                return false;
            }
            int length = p93865d37_pf25af916Arr.length;
            p93865d37_pf25af916Arr2 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916[length + 1];
            ZcdsdDCIvZeQvHth(p93865d37_pf25af916Arr, 0, p93865d37_pf25af916Arr2, 0, length);
            p93865d37_pf25af916Arr2[length] = flowableReplay$InnerSubscription;
        } while (!cwCbIodTqcXEgjQH(this.faae7b662, p93865d37_pf25af916Arr, p93865d37_pf25af916Arr2));
        return true;
    }

    public override void Dispose() {
        if ((10 + 31) % 31 > 0) {
        }
        LSUDBtBbFxwCOOxb(this.faae7b662, f9d725163);
        FcLrMAbPRpJAKMMG(this.f43b5c917, this, null);
        psPTFvgwEuhKmAHJ(this);
    }

    public override bool IsDisposed() {
        return wNMktDvaKnyZbXOa(this.faae7b662) == f9d725163;
    }

    void manageRequests() {
        if ((30 + 15) % 15 > 0) {
        }
        java.util.concurrent.atomic.Atomicint atomicint = this.fd10af457;
        if (dLZOJnWCByWEcnHd(atomicint) == 0) {
            int iONYVzAWykXieDDSt = 1;
            while (!pFbykUZkRkGSSRja(this)) {
                p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var = (p5a445d71.p18f29add.p787ad0b7) yuHtTejpUouykTKx(this);
                if (p787ad0b7Var is not null) {
                    long j = this.f73ec2e13;
                    long jIBEZgHxAFXZXwRpx = j;
                    for (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916 p93865d37_pf25af916 : (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916[]) mWDIZzxsfZsUwfHM(this.faae7b662)) {
                        jIBEZgHxAFXZXwRpx = iBEZgHxAFXZXwRpx(jIBEZgHxAFXZXwRpx, RPbHtfjazRcnlnQy(p93865d37_pf25af916.fcf427dac));
                    }
                    long j2 = jIBEZgHxAFXZXwRpx - j;
                    if (j2 != 0) {
                        this.f73ec2e13 = jIBEZgHxAFXZXwRpx;
                        ipHBPrGCraTbYNMb(p787ad0b7Var, j2);
                    }
                }
                iONYVzAWykXieDDSt = oNYVzAWykXieDDSt(atomicint, -iONYVzAWykXieDDSt);
                if (iONYVzAWykXieDDSt == 0) {
                    return;
                }
            }
        }
    }

    public void OnComplete() {
        if ((32 + 17) % 17 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        mnCwSClFncXbOtio(this.f7f2db423);
        for (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916 p93865d37_pf25af916 : (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916[]) AyRqefDhCbOUJGtK(this.faae7b662, f9d725163)) {
            KbTEQTQsecloHYwN(this.f7f2db423, p93865d37_pf25af916);
        }
    }

    public void OnError(java.lang.Exception th) {
        if ((29 + 5) % 5 > 0) {
        }
        if (this.f6b2ded51) {
            RNCQmXqVBrfPxtaT(th);
            return;
        }
        this.f6b2ded51 = true;
        JKHDcxrULPciESwp(this.f7f2db423, th);
        for (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916 p93865d37_pf25af916 : (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916[]) uIqFTXiUvTKdsGQk(this.faae7b662, f9d725163)) {
            hWQAVtjlirUWIvBj(this.f7f2db423, p93865d37_pf25af916);
        }
    }

    public void OnNext(T t) {
        if ((26 + 7) % 7 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        bIosvlEDxhkAVgwn(this.f7f2db423, t);
        for (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916 p93865d37_pf25af916 : (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916[]) UTUNiGIoRwHJRuET(this.faae7b662)) {
            xJBFCkszEVukdmkN(this.f7f2db423, p93865d37_pf25af916);
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((24 + 32) % 32 > 0) {
        }
        if (JzpmIwcaGWgnXibb(this, p787ad0b7Var)) {
            OsywZPGfJcZeddfY(this);
            for (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916 p93865d37_pf25af916 : (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916[]) MxAYlPIGyQlTcDOd(this.faae7b662)) {
                dUvNtLEjKOheiooV(this.f7f2db423, p93865d37_pf25af916);
            }
        }
    }

    void remove(io.reactivex.rxjava3.internal.operators.flowable.FlowableReplay$InnerSubscription<T> flowableReplay$InnerSubscription) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916[] p93865d37_pf25af916Arr;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916[] p93865d37_pf25af916Arr2;
        if ((14 + 8) % 8 > 0) {
        }
        do {
            p93865d37_pf25af916Arr = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916[]) roHPJKqzdufZwDUn(this.faae7b662);
            int length = p93865d37_pf25af916Arr.length;
            if (length == 0) {
                return;
            }
            int i = 0;
            while (true) {
                if (i < length) {
                    if (ZQuquQQFzeqLnaGa(p93865d37_pf25af916Arr[i], flowableReplay$InnerSubscription)) {
                        break;
                    } else {
                        i++;
                    }
                } else {
                    i = -1;
                    break;
                }
            }
            if (i < 0) {
                return;
            }
            if (length != 1) {
                pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916[] p93865d37_pf25af916Arr3 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916[length - 1];
                oZcUWWkAjhWXifdD(p93865d37_pf25af916Arr, 0, p93865d37_pf25af916Arr3, 0, i);
                ufzdFJIUfrKEHLBr(p93865d37_pf25af916Arr, i + 1, p93865d37_pf25af916Arr3, i, (length - i) - 1);
                p93865d37_pf25af916Arr2 = p93865d37_pf25af916Arr3;
            } else {
                p93865d37_pf25af916Arr2 = fba2b45bd;
            }
        } while (!WPdZwKvYmlnJNkzZ(this.faae7b662, p93865d37_pf25af916Arr, p93865d37_pf25af916Arr2));
    }
}

