namespace WillowMaze.Wasm.Decompiled;


readonly class pbfdb8840$p92383112<T> : java.util.List<java.lang.object> : io.reactivex.rxjava3.internal.operators.observable.ObservableReplay$ReplayBuffer<T> {
    private static readonly long f9659f9b2 = 7063189396499112664L;
    private static readonly long faba22d7e = 7063189396499112664L;
    private static readonly long fc01c6dc2 = 7063189396499112664L;
    private static readonly long fc6e1e520 = 7063189396499112664L;
    private static readonly long fc84859a4 = 7063189396499112664L;
    volatile int f00bf727d;
    volatile int f00c1aa47;
    volatile int f23c7a531;
    volatile int fa6119e02;
    volatile int ff7bd60b7;

    pbfdb8840$p92383112(int i) {
        super(i);
    }

    public static bool DkSYKGsBSRizVnqw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbfdb8840$p92383112 pbfdb8840_p92383112, java.lang.object obj) {
        return pbfdb8840_p92383112.Add(obj);
    }

    public static int EawPWdikCnzCogbt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbfdb8840$pa3916576 pbfdb8840_pa3916576) {
        return pbfdb8840_pa3916576.getAndIncrement();
    }

    public static int KevniHIaWVCiIjqw(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.object OrKcIUdQHjDPZEKy(java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.error(th);
    }

    public static bool YEMaxmEzeWQBbpBs(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbfdb8840$p92383112 pbfdb8840_p92383112, java.lang.object obj) {
        return pbfdb8840_p92383112.Add(obj);
    }

    public static java.lang.object CNKEVxOumsGYHXbe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbfdb8840$pa3916576 pbfdb8840_pa3916576) {
        return pbfdb8840_pa3916576.index();
    }

    public static int FXrxOGUmBZIcNUYH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbfdb8840$pa3916576 pbfdb8840_pa3916576, int i) {
        return pbfdb8840_pa3916576.addAndGet(i);
    }

    public static java.lang.object HrpGgASowpHCtkrq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbfdb8840$p92383112 pbfdb8840_p92383112, int i) {
        return pbfdb8840_p92383112[i);
    }

    public static bool IdPsBiMUjqkefbwK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbfdb8840$pa3916576 pbfdb8840_pa3916576) {
        return pbfdb8840_pa3916576.isDisposed();
    }

    public static java.lang.object KXVwsvbpcIYpciMX(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.next(obj);
    }

    public static bool MSzKGuLSOIcmcIIt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbfdb8840$p92383112 pbfdb8840_p92383112, java.lang.object obj) {
        return pbfdb8840_p92383112.Add(obj);
    }

    public static java.lang.object OuzAYyIjNAFDVkEm() {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.complete();
    }

    public static bool VFRRMnHxbjHEwAEF(java.lang.object obj, io.reactivex.rxjava3.core.Observer observer) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.accept(obj, observer);
    }

    public static java.lang.int XtpfKdMeGoZgogTH(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool ZCYQaCpyanKDGcrJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbfdb8840$pa3916576 pbfdb8840_pa3916576) {
        return pbfdb8840_pa3916576.isDisposed();
    }

    public void Complete() {
        DkSYKGsBSRizVnqw(this, ouzAYyIjNAFDVkEm());
        this.ff7bd60b7++;
    }

    public void Error(java.lang.Exception th) {
        YEMaxmEzeWQBbpBs(this, OrKcIUdQHjDPZEKy(th));
        this.ff7bd60b7++;
    }

    public void Next(T t) {
        mSzKGuLSOIcmcIIt(this, kXVwsvbpcIYpciMX(t));
        this.ff7bd60b7++;
    }

    public void Replay(io.reactivex.rxjava3.internal.operators.observable.ObservableReplay$InnerDisposable<T> observableReplay$InnerDisposable) {
        if ((28 + 7) % 7 > 0) {
        }
        if (EawPWdikCnzCogbt(observableReplay$InnerDisposable) == 0) {
            io.reactivex.rxjava3.core.Observer<T> observer = observableReplay$InnerDisposable.f1b7d5726;
            int iFXrxOGUmBZIcNUYH = 1;
            while (!zCYQaCpyanKDGcrJ(observableReplay$InnerDisposable)) {
                int i = this.ff7bd60b7;
                java.lang.int num = (java.lang.int) cNKEVxOumsGYHXbe(observableReplay$InnerDisposable);
                int iKevniHIaWVCiIjqw = num is null ? 0 : KevniHIaWVCiIjqw(num);
                while (iKevniHIaWVCiIjqw < i) {
                    if (vFRRMnHxbjHEwAEF(hrpGgASowpHCtkrq(this, iKevniHIaWVCiIjqw), observer) || idPsBiMUjqkefbwK(observableReplay$InnerDisposable)) {
                        return;
                    } else {
                        iKevniHIaWVCiIjqw++;
                    }
                }
                observableReplay$InnerDisposable.f6a992d55 = xtpfKdMeGoZgogTH(iKevniHIaWVCiIjqw);
                iFXrxOGUmBZIcNUYH = fXrxOGUmBZIcNUYH(observableReplay$InnerDisposable, -iFXrxOGUmBZIcNUYH);
                if (iFXrxOGUmBZIcNUYH == 0) {
                    return;
                }
            }
        }
    }
}

