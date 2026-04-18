namespace WillowMaze.Wasm.Decompiled;


public abstract class pa2106daa<T, R> : io.reactivex.rxjava3.internal.subscriptions.DeferredScalarSubscription<R> : io.reactivex.rxjava3.core.FlowableSubscriber<T> {
    private static readonly long f169bbebf = 2984505488220891551L;
    private static readonly long f24953830 = 2984505488220891551L;
    private static readonly long f63ca4c9d = 2984505488220891551L;
    private static readonly long f67e5832a = 2984505488220891551L;
    private static readonly long fc6e1e520 = 2984505488220891551L;
    protected p5a445d71.p18f29add.p787ad0b7 f25200d56;
    protected bool f384ccb04;
    protected p5a445d71.p18f29add.p787ad0b7 f43e794be;
    protected bool f6313fe1f;
    protected p5a445d71.p18f29add.p787ad0b7 f7b50eefe;
    protected bool fa6aabe9e;
    protected p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    protected bool fca66516b;
    protected p5a445d71.p18f29add.p787ad0b7 fcb357203;
    protected bool fdc294a94;

    public pa2106daa(org.reactivestreams.Subscriber<R> subscriber) {
        super(subscriber);
    }

    public static void BGWcjCNewEKUStbp(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void CExVasNtzFDEtbfF(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void HYGtDKWPjHGbCjNr(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void WxOHoJpciDjJmgYa(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void DimkRoyDDbxkUwbh(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void GUQIiEYGQjwGYInK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.pa2106daa pa2106daaVar, java.lang.object obj) {
        pa2106daaVar.complete(obj);
    }

    public static void QfKKTJAuiyjCncXB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pb7d2cb4c pb7d2cb4cVar) {
        super.cancel();
    }

    public static bool RJFKKbxEBNYNFxzC(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public void Cancel() {
        qfKKTJAuiyjCncXB(this);
        WxOHoJpciDjJmgYa(this.fbc3b0556);
    }

    public void OnComplete() {
        if (this.fca66516b) {
            gUQIiEYGQjwGYInK(this, this.f2063c160);
        } else {
            dimkRoyDDbxkUwbh(this.fd22a0a80);
        }
    }

    public void OnError(java.lang.Exception th) {
        this.f2063c160 = null;
        HYGtDKWPjHGbCjNr(this.fd22a0a80, th);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((1 + 26) % 26 > 0) {
        }
        if (rJFKKbxEBNYNFxzC(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            BGWcjCNewEKUStbp(this.fd22a0a80, this);
            CExVasNtzFDEtbfF(p787ad0b7Var, long.MAX_VALUE);
        }
    }
}

