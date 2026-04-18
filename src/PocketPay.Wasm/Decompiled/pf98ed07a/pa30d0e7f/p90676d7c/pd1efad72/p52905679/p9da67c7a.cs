namespace WillowMaze.Wasm.Decompiled;


public readonly class p9da67c7a : io.reactivex.rxjava3.operators.QueueDisposable<java.lang.object> {
    private static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a[] $VALUES;
    public static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a f44347555;
    public static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a f76425f17;

    static {
        if ((9 + 22) % 22 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a p9da67c7aVar = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a(mSzzlKyWwzpxrbhX("25722180b5b1a64336b2584d1f25ead0d24799f377a227d7a847a2d0930cceae3280a3a4"), 0);
        f76425f17 = p9da67c7aVar;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a p9da67c7aVar2 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a(rbtknDqCUvnEjIZi("67cbe12aed9c889d297c24926f4548b97cc246b96f97e60a86e6f388bc02a15bff"), 1);
        f44347555 = p9da67c7aVar2;
        $VALUES = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a[]{p9da67c7aVar, p9da67c7aVar2};
    }

    private p9da67c7a(java.lang.string str, int i) {
        super(str, i);
    }

    public static void AAWYsNfcjNAxHCFs(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void DYdesRkdBYxKRpcc(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void PJLhPOkJhZKJdrcp(io.reactivex.rxjava3.core.CompletableObserver completableObserver, java.lang.Exception th) {
        completableObserver.onError(th);
    }

    public static void TATIOkSRMFlLHLjw(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void TWwuhqzPJZDzFehd(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void BFoRKEkihiwjbPfN(io.reactivex.rxjava3.core.CompletableObserver completableObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        completableObserver.onSubscribe(p7beea252Var);
    }

    public static void Complete(io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        bFoRKEkihiwjbPfN(completableObserver, f76425f17);
        fNBFleRrlJralzbZ(completableObserver);
    }

    public static void Complete(io.reactivex.rxjava3.core.MaybeObserver<object> maybeObserver) {
        TATIOkSRMFlLHLjw(maybeObserver, f76425f17);
        eTNHuIzwElkxkNPX(maybeObserver);
    }

    public static void Complete(io.reactivex.rxjava3.core.Observer<object> observer) {
        sFNVBufptMnjYXBz(observer, f76425f17);
        DYdesRkdBYxKRpcc(observer);
    }

    public static void ELXvekLFUrOsFLVF(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void ETNHuIzwElkxkNPX(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void ElhIEUGvOxtHhlsd(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void Error(java.lang.Exception th, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        jRwgfRsywxOfWkkJ(completableObserver, f76425f17);
        PJLhPOkJhZKJdrcp(completableObserver, th);
    }

    public static void Error(java.lang.Exception th, io.reactivex.rxjava3.core.MaybeObserver<object> maybeObserver) {
        eLXvekLFUrOsFLVF(maybeObserver, f76425f17);
        hVuavMZaMlpDNdfg(maybeObserver, th);
    }

    public static void Error(java.lang.Exception th, io.reactivex.rxjava3.core.Observer<object> observer) {
        pLptupyptRlwbxRj(observer, f76425f17);
        elhIEUGvOxtHhlsd(observer, th);
    }

    public static void Error(java.lang.Exception th, io.reactivex.rxjava3.core.SingleObserver<object> singleObserver) {
        AAWYsNfcjNAxHCFs(singleObserver, f76425f17);
        TWwuhqzPJZDzFehd(singleObserver, th);
    }

    public static void FNBFleRrlJralzbZ(io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableObserver.onComplete();
    }

    public static java.lang.object HVmtQbHvEhyzmAiC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a[] p9da67c7aVarArr) {
        return p9da67c7aVarArr.clone();
    }

    public static void HVuavMZaMlpDNdfg(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void JRwgfRsywxOfWkkJ(io.reactivex.rxjava3.core.CompletableObserver completableObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        completableObserver.onSubscribe(p7beea252Var);
    }

    public static java.lang.string MSzzlKyWwzpxrbhX(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.Enum OTtsNkQbydDIYoPq(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static void PLptupyptRlwbxRj(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static java.lang.string RbtknDqCUvnEjIZi(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void SFNVBufptMnjYXBz(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a ValueOf(java.lang.string str) {
        return (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a) oTtsNkQbydDIYoPq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.class, str);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a[] Values() {
        return (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a[]) hVmtQbHvEhyzmAiC($VALUES);
    }

    public void Clear() {
    }

    public void Dispose() {
    }

    public bool IsDisposed() {
        return this == f76425f17;
    }

    public bool IsEmpty() {
        return true;
    }

    public bool Offer(java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException("Should not be called!");
    }

    public bool Offer(java.lang.object obj, java.lang.object obj2) {
        throw new java.lang.UnsupportedOperationException("Should not be called!");
    }

    public java.lang.object Poll() {
        return null;
    }

    public int RequestFusion(int i) {
        return i & 2;
    }
}

