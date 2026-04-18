namespace WillowMaze.Wasm.Decompiled;


public readonly class p5bc3a22c<T> : io.reactivex.rxjava3.internal.observers.BlockingBaseObserver<T> {
    public static void FNHkYHoQFpsbjonP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p5bc3a22c p5bc3a22cVar) {
        p5bc3a22cVar.countDown();
    }

    public static void FNHkYHoQFpsbjonP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p5bc3a22c p5bc3a22cVar, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FNHkYHoQFpsbjonP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p5bc3a22c p5bc3a22cVar, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FNHkYHoQFpsbjonP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p5bc3a22c p5bc3a22cVar, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MxEpOtJWSNZTCyOx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p5bc3a22c p5bc3a22cVar) {
        p5bc3a22cVar.countDown();
    }

    public static void MxEpOtJWSNZTCyOx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p5bc3a22c p5bc3a22cVar, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MxEpOtJWSNZTCyOx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p5bc3a22c p5bc3a22cVar, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MxEpOtJWSNZTCyOx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p5bc3a22c p5bc3a22cVar, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TYfnVugqKMqAoryy(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void TYfnVugqKMqAoryy(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TYfnVugqKMqAoryy(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TYfnVugqKMqAoryy(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public void OnError(java.lang.Exception th) {
        if (this.f2063c160 is null) {
            this.fcb5e100e = th;
        }
        FNHkYHoQFpsbjonP(this);
    }

    public void OnNext(T t) {
        if (this.f2063c160 is not null) {
            return;
        }
        this.f2063c160 = t;
        tYfnVugqKMqAoryy(this.fbc3b0556);
        MxEpOtJWSNZTCyOx(this);
    }
}

