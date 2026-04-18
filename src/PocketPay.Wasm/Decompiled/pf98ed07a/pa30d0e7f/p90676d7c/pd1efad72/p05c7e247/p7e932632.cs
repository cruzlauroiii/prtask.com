namespace WillowMaze.Wasm.Decompiled;


public readonly class p7e932632 : io.reactivex.rxjava3.core.FlowableSubscriber<java.lang.object>, io.reactivex.rxjava3.core.Observer<java.lang.object>, io.reactivex.rxjava3.core.MaybeObserver<java.lang.object>, io.reactivex.rxjava3.core.SingleObserver<java.lang.object>, io.reactivex.rxjava3.core.CompletableObserver, p5a445d71.p18f29add.p787ad0b7, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7e932632[] $VALUES;
    public static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7e932632 f76425f17;

    static {
        if ((32 + 30) % 30 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7e932632 p7e932632Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7e932632(NXsMIPHGxHolYUqU("17b32dccdc0852dde3fc7c91c9951191f9cbb9308bf25fd45cef4b6d99159baf9955cd90"), 0);
        f76425f17 = p7e932632Var;
        $VALUES = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7e932632[]{p7e932632Var};
    }

    private p7e932632(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.string NXsMIPHGxHolYUqU(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void WBLcjqlOqskCdxZW(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void WQTaeZmhKgQbDJiz(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static java.lang.Enum AOZeQPHhlogKEyhS(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static <T> io.reactivex.rxjava3.core.Observer<T> AsObserver() {
        return f76425f17;
    }

    public static <T> org.reactivestreams.Subscriber<T> AsSubscriber() {
        return f76425f17;
    }

    public static void NfldGMqJbMIjfqQe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static java.lang.object OKmrtdcQpSCnUeVN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7e932632[] p7e932632VarArr) {
        return p7e932632VarArr.clone();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7e932632 ValueOf(java.lang.string str) {
        return (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7e932632) aOZeQPHhlogKEyhS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7e932632.class, str);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7e932632[] Values() {
        return (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7e932632[]) oKmrtdcQpSCnUeVN($VALUES);
    }

    public override void Cancel() {
    }

    public override void Dispose() {
    }

    public override bool IsDisposed() {
        return true;
    }

    public override void OnComplete() {
    }

    public override void OnError(java.lang.Exception th) {
        WBLcjqlOqskCdxZW(th);
    }

    public override void OnNext(java.lang.object obj) {
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        nfldGMqJbMIjfqQe(p787ad0b7Var);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        WQTaeZmhKgQbDJiz(p7beea252Var);
    }

    public override void OnSuccess(java.lang.object obj) {
    }

    public override void Request(long j) {
    }
}

