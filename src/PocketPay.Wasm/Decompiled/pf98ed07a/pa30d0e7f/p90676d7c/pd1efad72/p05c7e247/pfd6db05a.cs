namespace WillowMaze.Wasm.Decompiled;


public readonly class pfd6db05a : java.util.concurrent.CountdownEvent : io.reactivex.rxjava3.functions.Consumer<java.lang.Exception>, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 {
    public java.lang.Exception fcb5e100e;
    public java.lang.Exception fdeb09df0;

    public pfd6db05a() {
        super(1);
    }

    public static void CJkDmbrqhphdfByK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pfd6db05a pfd6db05aVar) {
        pfd6db05aVar.countDown();
    }

    public static void PJVcPaTMxnHJDHnB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pfd6db05a pfd6db05aVar, java.lang.Exception th) {
        pfd6db05aVar.accept(th);
    }

    public static void UxYiXBpbHiXDqkQX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pfd6db05a pfd6db05aVar) {
        pfd6db05aVar.countDown();
    }

    public void Accept(java.lang.object obj) throws java.lang.Exception {
        pJVcPaTMxnHJDHnB(this, (java.lang.Exception) obj);
    }

    public void Accept(java.lang.Exception th) {
        this.fcb5e100e = th;
        CJkDmbrqhphdfByK(this);
    }

    public override void Run() {
        uxYiXBpbHiXDqkQX(this);
    }
}

