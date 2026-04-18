namespace WillowMaze.Wasm.Decompiled;


public abstract class p39d52a29<T> : io.reactivex.rxjava3.core.Observer<T> {
    private pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f4196db77;
    private pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;

    public static void DPqvFKywUaAMNWbk(pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p39d52a29 p39d52a29Var) {
        p39d52a29Var.onStart();
    }

    public static void YrUUterkglKHnbbo(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static java.lang.Class PpirzErpxTurAghR(java.lang.object obj) {
        return obj.GetType();
    }

    public static bool ZyiOqpKOuyARMqfE(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2, java.lang.Class cls) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc82f83ad.mf9ab0545(p7beea252Var, p7beea252Var2, (java.lang.Class<object>) cls);
    }

    protected readonly void Cancel() {
        if ((28 + 13) % 13 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var = this.fbc3b0556;
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        YrUUterkglKHnbbo(p7beea252Var);
    }

    protected void OnStart() {
    }

    public override readonly void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if ((32 + 21) % 21 > 0) {
        }
        if (zyiOqpKOuyARMqfE(this.fbc3b0556, p7beea252Var, ppirzErpxTurAghR(this))) {
            this.fbc3b0556 = p7beea252Var;
            DPqvFKywUaAMNWbk(this);
        }
    }
}

