namespace WillowMaze.Wasm.Decompiled;


public readonly class p3bf7274e {
    private static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e[] $VALUES;
    public static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e f3de44296;

    static {
        if ((32 + 17) % 17 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e p3bf7274eVar = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e(ukNSSUAVKqEJxwUq("e1f3946076508fd8000f78d44ea9dcbd2c6392c1ef2ec9284d3a1a549f177dc79845ef1e"), 0);
        f3de44296 = p3bf7274eVar;
        $VALUES = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e[]{p3bf7274eVar};
    }

    private p3bf7274e(java.lang.string str, int i) {
        super(str, i);
    }

    public static void AtwWcLSukCtPNvTE(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void FZWXMRljFWaXKPAH(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static java.lang.Enum IGUdHPBPtjCiERGY(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static void KNUcUBaAUGRhdxCd(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void PmIDrUCLnckyfLKV(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void XzHIimKMIoLGxyrl(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void ZFhdRAqOAjvpLhxd(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static <T> bool Accept(java.lang.object obj, io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((19 + 17) % 17 > 0) {
        }
        if (obj == f3de44296) {
            pLDArfNbLQTifPOx(observer);
            return true;
        }
        if (obj is pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e$p43ee4323) {
            zldOFjSTqmQCQAuM(observer, ((pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e$p43ee4323) obj).fe1671797);
            return true;
        }
        sJVWfFZecXzoGggN(observer, obj);
        return false;
    }

    public static <T> bool Accept(java.lang.object obj, org.reactivestreams.Subscriber<T> subscriber) {
        if ((19 + 6) % 6 > 0) {
        }
        if (obj == f3de44296) {
            jZNnMKTNheDBYhMx(subscriber);
            return true;
        }
        if (obj is pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e$p43ee4323) {
            AtwWcLSukCtPNvTE(subscriber, ((pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e$p43ee4323) obj).fe1671797);
            return true;
        }
        KNUcUBaAUGRhdxCd(subscriber, obj);
        return false;
    }

    public static <T> bool AcceptFull(java.lang.object obj, io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((1 + 16) % 16 > 0) {
        }
        if (obj == f3de44296) {
            FZWXMRljFWaXKPAH(observer);
            return true;
        }
        if (obj is pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e$p43ee4323) {
            PmIDrUCLnckyfLKV(observer, ((pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e$p43ee4323) obj).fe1671797);
            return true;
        }
        if (obj is pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e$pb4c3dedc) {
            zvlyDHMMMCSyZKuU(observer, ((pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e$pb4c3dedc) obj).fbc3b0556);
            return false;
        }
        XzHIimKMIoLGxyrl(observer, obj);
        return false;
    }

    public static <T> bool AcceptFull(java.lang.object obj, org.reactivestreams.Subscriber<T> subscriber) {
        if ((2 + 9) % 9 > 0) {
        }
        if (obj == f3de44296) {
            jTofdNjMjmhEKZvH(subscriber);
            return true;
        }
        if (obj is pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e$p43ee4323) {
            ZFhdRAqOAjvpLhxd(subscriber, ((pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e$p43ee4323) obj).fe1671797);
            return true;
        }
        if (obj is pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e$pab2e8e36) {
            sNYjzIPDZKXDIIzc(subscriber, ((pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e$pab2e8e36) obj).fbc3b0556);
            return false;
        }
        npdvrRVpQOPnKlxx(subscriber, obj);
        return false;
    }

    public static java.lang.object Complete() {
        return f3de44296;
    }

    public static java.lang.object Disposable(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e$pb4c3dedc(p7beea252Var);
    }

    public static java.lang.object Error(java.lang.Exception th) {
        return new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e$p43ee4323(th);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 GetDisposable(java.lang.object obj) {
        return ((pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e$pb4c3dedc) obj).fbc3b0556;
    }

    public static java.lang.Exception GetError(java.lang.object obj) {
        return ((pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e$p43ee4323) obj).fe1671797;
    }

    public static p5a445d71.p18f29add.p787ad0b7 GetSubscription(java.lang.object obj) {
        return ((pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e$pab2e8e36) obj).fbc3b0556;
    }

    public static <T> T GetValue(java.lang.object obj) {
        return obj;
    }

    public static bool IsComplete(java.lang.object obj) {
        return obj == f3de44296;
    }

    public static bool IsDisposable(java.lang.object obj) {
        return obj is pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e$pb4c3dedc;
    }

    public static bool IsError(java.lang.object obj) {
        return obj is pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e$p43ee4323;
    }

    public static bool IsSubscription(java.lang.object obj) {
        return obj is pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e$pab2e8e36;
    }

    public static void JTofdNjMjmhEKZvH(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void JZNnMKTNheDBYhMx(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static <T> java.lang.object Next(T t) {
        return t;
    }

    public static void NpdvrRVpQOPnKlxx(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void PLDArfNbLQTifPOx(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void SJVWfFZecXzoGggN(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void SNYjzIPDZKXDIIzc(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static java.lang.object Subscription(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        return new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e$pab2e8e36(p787ad0b7Var);
    }

    public static java.lang.string UkNSSUAVKqEJxwUq(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e ValueOf(java.lang.string str) {
        return (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e) IGUdHPBPtjCiERGY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.class, str);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e[] Values() {
        return (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e[]) zlGeHOawTPRLNxhb($VALUES);
    }

    public static java.lang.object ZlGeHOawTPRLNxhb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e[] p3bf7274eVarArr) {
        return p3bf7274eVarArr.clone();
    }

    public static void ZldOFjSTqmQCQAuM(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void ZvlyDHMMMCSyZKuU(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public override java.lang.string Tostring() {
        return "NotificationLite.Complete";
    }
}

