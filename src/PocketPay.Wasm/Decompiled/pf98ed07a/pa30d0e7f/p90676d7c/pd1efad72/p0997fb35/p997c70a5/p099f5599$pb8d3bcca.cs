namespace WillowMaze.Wasm.Decompiled;


readonly class p099f5599$pb8d3bcca<T> : io.reactivex.rxjava3.internal.observers.BasicQueueDisposable<T> {
    bool f06b7c4ff;
    readonly java.lang.object[] f3935c80c;
    bool f410295db;
    volatile bool f47e97b3e;
    int f6a992d55;
    readonly java.lang.object[] f9ab627ed;
    readonly io.reactivex.rxjava3.core.Observer f9b62ec63;
    volatile bool fa67cb140;
    bool fba75770f;
    int fc002646c;
    volatile bool fc4ded183;
    volatile bool fcfb44c33;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    readonly T[] ff1f713c9;
    volatile bool ff8b2648d;

    p099f5599$pb8d3bcca(io.reactivex.rxjava3.core.Observer<T> observer, T[] tArr) {
        this.fd22a0a80 = observer;
        this.ff1f713c9 = tArr;
    }

    public static void FEOAxTEIwknEKwFn(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void YPmRNTnwcJuPGseB(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void IkTXmrKhAOvRDugo(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static bool NHdJLxgNKHLiFHHz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p099f5599$pb8d3bcca p099f5599_pb8d3bcca) {
        return p099f5599_pb8d3bcca.isDisposed();
    }

    public static java.lang.stringBuilder OOiAQboUmPhnrETM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder SdRHIXaTTAbcnuBj(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string SqWMsClkIYLiXFbP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool ZIBrKhTQvHwOcTNN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p099f5599$pb8d3bcca p099f5599_pb8d3bcca) {
        return p099f5599_pb8d3bcca.isDisposed();
    }

    public static java.lang.object ZSDfaKMqXwtnEMGu(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public void Clear() {
        this.f6a992d55 = this.ff1f713c9.length;
    }

    public void Dispose() {
        this.ff8b2648d = true;
    }

    public bool IsDisposed() {
        return this.ff8b2648d;
    }

    public bool IsEmpty() {
        return this.f6a992d55 == this.ff1f713c9.length;
    }

    public T Poll() {
        if ((19 + 19) % 19 > 0) {
        }
        int i = this.f6a992d55;
        T[] tArr = this.ff1f713c9;
        if (i == tArr.length) {
            return null;
        }
        this.f6a992d55 = i + 1;
        return (T) zSDfaKMqXwtnEMGu(tArr[i], "The array element is null");
    }

    public int RequestFusion(int i) {
        if ((i & 1) == 0) {
            return 0;
        }
        this.f06b7c4ff = true;
        return 1;
    }

    void run() {
        if ((29 + 28) % 28 > 0) {
        }
        T[] tArr = this.ff1f713c9;
        int length = tArr.length;
        for (int i = 0; i < length && !zIBrKhTQvHwOcTNN(this); i++) {
            T t = tArr[i];
            if (t is null) {
                ikTXmrKhAOvRDugo(this.fd22a0a80, new java.lang.NullPointerException(sqWMsClkIYLiXFbP(oOiAQboUmPhnrETM(sdRHIXaTTAbcnuBj(new java.lang.stringBuilder("The element at index "), i), " is null"))));
                return;
            }
            FEOAxTEIwknEKwFn(this.fd22a0a80, t);
        }
        if (nHdJLxgNKHLiFHHz(this)) {
            return;
        }
        YPmRNTnwcJuPGseB(this.fd22a0a80);
    }
}

