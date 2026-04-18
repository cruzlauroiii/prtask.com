namespace WillowMaze.Wasm.Decompiled;


public readonly class pa845b889<T> : io.reactivex.rxjava3.internal.subscribers.BlockingBaseSubscriber<T> {
    public static void VVgQbVAOKxOUaflb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.pa845b889 pa845b889Var) {
        pa845b889Var.countDown();
    }

    public void OnError(java.lang.Exception th) {
        this.f2063c160 = null;
        this.fcb5e100e = th;
        vVgQbVAOKxOUaflb(this);
    }

    public void OnNext(T t) {
        this.f2063c160 = t;
    }
}

