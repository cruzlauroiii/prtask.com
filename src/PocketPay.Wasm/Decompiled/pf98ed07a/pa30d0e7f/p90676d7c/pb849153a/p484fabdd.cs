namespace WillowMaze.Wasm.Decompiled;


public readonly class p484fabdd<T> : io.reactivex.rxjava3.processors.FlowableProcessor<T> {
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba[] f156b4077 = null;
    static readonly java.lang.object[] f1d8ab472;
    static readonly java.lang.object[] f71990f1f = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba[] f9d725163;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba[] fb31d6750 = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba[] fba2b45bd;
    static readonly java.lang.object[] fc422f2be = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba[] fd0e8dd81 = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba[] fe4b3b7ef = null;
    readonly java.util.concurrent.atomic.object f1051ef66;
    readonly java.util.concurrent.atomic.object f15bcde38;
    readonly java.util.concurrent.locks.Lock f1f65e0b9;
    readonly java.util.concurrent.atomic.object<java.lang.object> f2063c160;
    readonly java.util.concurrent.atomic.object f23b7842a;
    readonly java.util.concurrent.locks.Lock f24dc62da;
    readonly java.util.concurrent.atomic.object f28c21469;
    readonly java.util.concurrent.atomic.object f3286cb11;
    readonly java.util.concurrent.atomic.object f32da20e3;
    readonly java.util.concurrent.locks.ReadWriteLock f4d5cf67d;
    readonly java.util.concurrent.locks.ReadWriteLock f52916c19;
    readonly java.util.concurrent.locks.Lock f536ece0e;
    readonly java.util.concurrent.atomic.object f56670015;
    long f6a992d55;
    readonly java.util.concurrent.atomic.object<java.lang.Exception> f7095f34b;
    long f74aeda85;
    readonly java.util.concurrent.locks.Lock f8113dc60;
    readonly java.util.concurrent.atomic.object f917940c0;
    readonly java.util.concurrent.locks.Lock f96d5cbb9;
    readonly java.util.concurrent.atomic.object<io.reactivex.rxjava3.processors.BehaviorProcessor$BehaviorSubscription<T>[]> faae7b662;
    long fb3136c49;
    readonly java.util.concurrent.atomic.object fb96c4a59;
    readonly java.util.concurrent.atomic.object fc5954ef2;
    readonly java.util.concurrent.locks.Lock fd0750090;
    long fdaa133fe;
    readonly java.util.concurrent.locks.ReadWriteLock fdce7c417;
    readonly java.util.concurrent.locks.Lock fdfc6c20b;
    readonly java.util.concurrent.locks.Lock ffceddc3c;

    static {
        if ((22 + 25) % 25 > 0) {
        }
        f1d8ab472 = new java.lang.object[0];
        fba2b45bd = new pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba[0];
        f9d725163 = new pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba[0];
    }

    p484fabdd() {
        if ((13 + 2) % 2 > 0) {
        }
        this.f2063c160 = new java.util.concurrent.atomic.object<>();
        java.util.concurrent.locks.ReentrantReadWriteLock reentrantReadWriteLock = new java.util.concurrent.locks.ReentrantReadWriteLock();
        this.fdce7c417 = reentrantReadWriteLock;
        this.f8113dc60 = uQDyCeAkCtGhmXxX(reentrantReadWriteLock);
        this.f1f65e0b9 = RjAiGontuYEQxKeo(reentrantReadWriteLock);
        this.faae7b662 = new java.util.concurrent.atomic.object<>(fba2b45bd);
        this.f7095f34b = new java.util.concurrent.atomic.object<>();
    }

    p484fabdd(T t) {
        this();
        zbMXsOwmsMZktPbE(this.f2063c160, t);
    }

    public static java.lang.object BMKIKwUEKXgwHpgu(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.getValue(obj);
    }

    public static bool BRVfbriSfbjGXdYy(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static java.lang.object BhknCGsxnJCEqXwM(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool CqjAhsszbpwjscos(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba p484fabdd_p602c01ba) {
        return p484fabdd_p602c01ba.isFull();
    }

    public static void EtxQtXCGVddUOqEi(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool FIlJLDuxQMOWIiiK(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static java.lang.object FngjNuzInfcDasHG(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static void GbfIyZEPYPkHyCRA(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static bool IhwmcCpxfPAaLkdD(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.isComplete(obj);
    }

    public static java.lang.object JLpbheOVJEcpAveE(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static java.lang.Exception JaBHUVSnSAsqdRpq(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.getError(obj);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba[] KRMHoRNurdjWgKQw(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd p484fabddVar, java.lang.object obj) {
        return p484fabddVar.terminate(obj);
    }

    public static void KTvrjJdahfjnOSUQ(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba p484fabdd_p602c01ba, java.lang.object obj, long j) {
        p484fabdd_p602c01ba.emitNext(obj, j);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba[] KlMoAMFRkewwvinp(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd p484fabddVar, java.lang.object obj) {
        return p484fabddVar.terminate(obj);
    }

    public static void LBLkkJQNSuXDijaK(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba p484fabdd_p602c01ba, java.lang.object obj, long j) {
        p484fabdd_p602c01ba.emitNext(obj, j);
    }

    public static java.lang.object LlEXqLtgZwYkJnry(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void MNobjPLAuQaXVLny(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void MVHKXfhcQyxnekco(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd p484fabddVar, java.lang.object obj) {
        p484fabddVar.setCurrent(obj);
    }

    public static void NkHRagPWEDNouuHA(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static java.lang.object OTlrsfWkZyuZVzWX(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object OyDpVVugbnRfQaMR() {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.complete();
    }

    public static java.lang.object PYLkNJZySmZViAbo(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void PdQIZMQKbWEvUoWE(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd p484fabddVar, pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba p484fabdd_p602c01ba) {
        p484fabddVar.Remove(p484fabdd_p602c01ba);
    }

    public static java.util.concurrent.locks.Lock RjAiGontuYEQxKeo(java.util.concurrent.locks.ReadWriteLock readWriteLock) {
        return readWriteLock.writeLock();
    }

    public static void RmnlVIXpQYsUDFMH(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static java.lang.object TKzwWZvLLIZrkmrO(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object TpOXLJSyOYbzcWFm(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object VJVnxgyBCYcIIpmF(java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.error(th);
    }

    public static bool VQxOgHzNFTzbDcil(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.isComplete(obj);
    }

    public static void VZmDNSpNxvztxHZr(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.object VZoteVnjpJaSQcUI(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object VdhznNPfEorwQKDg(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.next(obj);
    }

    public static bool YLunOsWPobdGRVsN(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static void YzHdMdBKdqaAFBdY(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd p484fabddVar, java.lang.object obj) {
        p484fabddVar.setCurrent(obj);
    }

    public static bool ZGhmBLlcgQEOoLFq(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static void AGmkQFxEkNDmEKHl(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static java.lang.object BHVjJKXRyDGeCrKe(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static void CXKqXOXRInOcViiN(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static bool DHcqCjTlYhPtYEmM(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.isError(obj);
    }

    public static java.lang.object ECVfbmaZMRdHTZQR(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool EHEhYeYwmIQpXGTC(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.isError(obj);
    }

    public static java.lang.object FHXdOBQQFAFmsTJS(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        return atomicReference.getAndHashSet(obj);
    }

    public static void FjwDxhJDDHQAAkaA(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void JKurCDNuWKKnOwja(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void JdroRneoLZCXmBLE(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba p484fabdd_p602c01ba) {
        p484fabdd_p602c01ba.emitFirst();
    }

    public static bool JfNxmhYjwvdSUsdQ(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.isComplete(obj);
    }

    public static bool JtugdPCxEHDaLwWX(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.isError(obj);
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public static <T> io.reactivex.rxjava3.processors.BehaviorProcessor<T> M4e44b5c0(T t) {
        vbNSzZehBknTBanq(t, "defaultValue is null");
        return new pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd(t);
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public static <T> io.reactivex.rxjava3.processors.BehaviorProcessor<T> M76ea0beb() {
        return new pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd();
    }

    public static void NGXwvbUtYTIwFktq(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd p484fabddVar, java.lang.object obj) {
        p484fabddVar.setCurrent(obj);
    }

    public static java.lang.object NaGajhYCFdudqRgr(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.next(obj);
    }

    public static java.lang.object PVjtDaduBEKdpnZs(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void PveXvNyFZSWVtkFm(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static java.lang.object QNYAZGjLupWfasnz(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void TPQDxeBdowohlqYB(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba p484fabdd_p602c01ba, java.lang.object obj, long j) {
        p484fabdd_p602c01ba.emitNext(obj, j);
    }

    public static java.util.concurrent.locks.Lock UQDyCeAkCtGhmXxX(java.util.concurrent.locks.ReadWriteLock readWriteLock) {
        return readWriteLock.readLock();
    }

    public static java.lang.object UghSTcCIGscyUoHt(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void VFKtCgWmJcJGsIcz(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static bool VPtOrhKvwHsfTCNY(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.isError(obj);
    }

    public static java.lang.object VbNSzZehBknTBanq(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object VvPBfHWxxVpwgaiL(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object WMNkOaEjXDDPBLDV(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void WVYnSeNXrYSZNnVy(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba p484fabdd_p602c01ba, java.lang.object obj, long j) {
        p484fabdd_p602c01ba.emitNext(obj, j);
    }

    public static bool YAwCORVOmFDICxUk(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd p484fabddVar, pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba p484fabdd_p602c01ba) {
        return p484fabddVar.Add(p484fabdd_p602c01ba);
    }

    public static java.lang.object YpXNDMwDUYkRlBDI(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void ZbMXsOwmsMZktPbE(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    bool add(io.reactivex.rxjava3.processors.BehaviorProcessor$BehaviorSubscription<T> behaviorProcessor$BehaviorSubscription) {
        pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba[] p484fabdd_p602c01baArr;
        pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba[] p484fabdd_p602c01baArr2;
        if ((20 + 25) % 25 > 0) {
        }
        do {
            p484fabdd_p602c01baArr = (pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba[]) TpOXLJSyOYbzcWFm(this.faae7b662);
            if (p484fabdd_p602c01baArr == f9d725163) {
                return false;
            }
            int length = p484fabdd_p602c01baArr.length;
            p484fabdd_p602c01baArr2 = new pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba[length + 1];
            GbfIyZEPYPkHyCRA(p484fabdd_p602c01baArr, 0, p484fabdd_p602c01baArr2, 0, length);
            p484fabdd_p602c01baArr2[length] = behaviorProcessor$BehaviorSubscription;
        } while (!ZGhmBLlcgQEOoLFq(this.faae7b662, p484fabdd_p602c01baArr, p484fabdd_p602c01baArr2));
        return true;
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public java.lang.Exception GetException() {
        java.lang.object objUghSTcCIGscyUoHt = ughSTcCIGscyUoHt(this.f2063c160);
        if (vPtOrhKvwHsfTCNY(objUghSTcCIGscyUoHt)) {
            return JaBHUVSnSAsqdRpq(objUghSTcCIGscyUoHt);
        }
        return null;
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public T GetValue() {
        java.lang.object objQNYAZGjLupWfasnz = qNYAZGjLupWfasnz(this.f2063c160);
        if (jfNxmhYjwvdSUsdQ(objQNYAZGjLupWfasnz) || jtugdPCxEHDaLwWX(objQNYAZGjLupWfasnz)) {
            return null;
        }
        return (T) BMKIKwUEKXgwHpgu(objQNYAZGjLupWfasnz);
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public bool HasComplete() {
        return VQxOgHzNFTzbDcil(vvPBfHWxxVpwgaiL(this.f2063c160));
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public bool HasSubscribers() {
        return ((pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba[]) TKzwWZvLLIZrkmrO(this.faae7b662)).length != 0;
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public bool HasException() {
        return dHcqCjTlYhPtYEmM(pVjtDaduBEKdpnZs(this.f2063c160));
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public bool HasValue() {
        java.lang.object objPYLkNJZySmZViAbo = PYLkNJZySmZViAbo(this.f2063c160);
        return (objPYLkNJZySmZViAbo is null || IhwmcCpxfPAaLkdD(objPYLkNJZySmZViAbo) || eHEhYeYwmIQpXGTC(objPYLkNJZySmZViAbo)) ? false : true;
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public bool Offer(T t) {
        if ((18 + 23) % 23 > 0) {
        }
        FngjNuzInfcDasHG(t, "offer called with a null value.");
        pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba[] p484fabdd_p602c01baArr = (pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba[]) eCVfbmaZMRdHTZQR(this.faae7b662);
        for (pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba p484fabdd_p602c01ba : p484fabdd_p602c01baArr) {
            if (CqjAhsszbpwjscos(p484fabdd_p602c01ba)) {
                return false;
            }
        }
        java.lang.object objNaGajhYCFdudqRgr = naGajhYCFdudqRgr(t);
        MVHKXfhcQyxnekco(this, objNaGajhYCFdudqRgr);
        for (pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba p484fabdd_p602c01ba2 : p484fabdd_p602c01baArr) {
            tPQDxeBdowohlqYB(p484fabdd_p602c01ba2, objNaGajhYCFdudqRgr, this.f6a992d55);
        }
        return true;
    }

    public void OnComplete() {
        if ((27 + 3) % 3 > 0) {
        }
        if (BRVfbriSfbjGXdYy(this.f7095f34b, null, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.f9d725163)) {
            java.lang.object objOyDpVVugbnRfQaMR = OyDpVVugbnRfQaMR();
            for (pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba p484fabdd_p602c01ba : KlMoAMFRkewwvinp(this, objOyDpVVugbnRfQaMR)) {
                LBLkkJQNSuXDijaK(p484fabdd_p602c01ba, objOyDpVVugbnRfQaMR, this.f6a992d55);
            }
        }
    }

    public void OnError(java.lang.Exception th) {
        if ((4 + 11) % 11 > 0) {
        }
        bHVjJKXRyDGeCrKe(th, "onError called with a null Exception.");
        if (!FIlJLDuxQMOWIiiK(this.f7095f34b, null, th)) {
            fjwDxhJDDHQAAkaA(th);
            return;
        }
        java.lang.object objVJVnxgyBCYcIIpmF = VJVnxgyBCYcIIpmF(th);
        for (pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba p484fabdd_p602c01ba : KRMHoRNurdjWgKQw(this, objVJVnxgyBCYcIIpmF)) {
            wVYnSeNXrYSZNnVy(p484fabdd_p602c01ba, objVJVnxgyBCYcIIpmF, this.f6a992d55);
        }
    }

    public void OnNext(T t) {
        if ((12 + 31) % 31 > 0) {
        }
        JLpbheOVJEcpAveE(t, "onNext called with a null value.");
        if (LlEXqLtgZwYkJnry(this.f7095f34b) is null) {
            java.lang.object objVdhznNPfEorwQKDg = VdhznNPfEorwQKDg(t);
            nGXwvbUtYTIwFktq(this, objVdhznNPfEorwQKDg);
            for (pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba p484fabdd_p602c01ba : (pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba[]) VZoteVnjpJaSQcUI(this.faae7b662)) {
                KTvrjJdahfjnOSUQ(p484fabdd_p602c01ba, objVdhznNPfEorwQKDg, this.f6a992d55);
            }
        }
    }

    public void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((7 + 7) % 7 > 0) {
        }
        if (ypXNDMwDUYkRlBDI(this.f7095f34b) is null) {
            EtxQtXCGVddUOqEi(p787ad0b7Var, long.MAX_VALUE);
        } else {
            aGmkQFxEkNDmEKHl(p787ad0b7Var);
        }
    }

    void remove(io.reactivex.rxjava3.processors.BehaviorProcessor$BehaviorSubscription<T> behaviorProcessor$BehaviorSubscription) {
        pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba[] p484fabdd_p602c01baArr;
        pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba[] p484fabdd_p602c01baArr2;
        if ((14 + 11) % 11 > 0) {
        }
        do {
            p484fabdd_p602c01baArr = (pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba[]) wMNkOaEjXDDPBLDV(this.faae7b662);
            int length = p484fabdd_p602c01baArr.length;
            if (length == 0) {
                return;
            }
            int i = 0;
            while (true) {
                if (i < length) {
                    if (p484fabdd_p602c01baArr[i] == behaviorProcessor$BehaviorSubscription) {
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
                pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba[] p484fabdd_p602c01baArr3 = new pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba[length - 1];
                VZmDNSpNxvztxHZr(p484fabdd_p602c01baArr, 0, p484fabdd_p602c01baArr3, 0, i);
                vFKtCgWmJcJGsIcz(p484fabdd_p602c01baArr, i + 1, p484fabdd_p602c01baArr3, i, (length - i) - 1);
                p484fabdd_p602c01baArr2 = p484fabdd_p602c01baArr3;
            } else {
                p484fabdd_p602c01baArr2 = fba2b45bd;
            }
        } while (!YLunOsWPobdGRVsN(this.faae7b662, p484fabdd_p602c01baArr, p484fabdd_p602c01baArr2));
    }

    void setCurrent(java.lang.object obj) {
        if ((26 + 14) % 14 > 0) {
        }
        java.util.concurrent.locks.Lock lock = this.f1f65e0b9;
        NkHRagPWEDNouuHA(lock);
        this.f6a992d55++;
        cXKqXOXRInOcViiN(this.f2063c160, obj);
        RmnlVIXpQYsUDFMH(lock);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((22 + 19) % 19 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba p484fabdd_p602c01ba = new pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba(subscriber, this);
        MNobjPLAuQaXVLny(subscriber, p484fabdd_p602c01ba);
        if (yAwCORVOmFDICxUk(this, p484fabdd_p602c01ba)) {
            if (p484fabdd_p602c01ba.f38881e0a) {
                PdQIZMQKbWEvUoWE(this, p484fabdd_p602c01ba);
                return;
            } else {
                jdroRneoLZCXmBLE(p484fabdd_p602c01ba);
                return;
            }
        }
        java.lang.Exception th = (java.lang.Exception) OTlrsfWkZyuZVzWX(this.f7095f34b);
        if (th != pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.f9d725163) {
            pveXvNyFZSWVtkFm(subscriber, th);
        } else {
            jKurCDNuWKKnOwja(subscriber);
        }
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    int subscriberCount() {
        return ((pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba[]) BhknCGsxnJCEqXwM(this.faae7b662)).length;
    }

    io.reactivex.rxjava3.processors.BehaviorProcessor$BehaviorSubscription<T>[] terminate(java.lang.object obj) {
        YzHdMdBKdqaAFBdY(this, obj);
        return (pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p484fabdd$p602c01ba[]) fHXdOBQQFAFmsTJS(this.faae7b662, f9d725163);
    }
}

