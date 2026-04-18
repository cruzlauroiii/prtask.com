namespace WillowMaze.Wasm.Decompiled;


public readonly class pd08e44b9<T> : io.reactivex.rxjava3.core.SingleObserver<T> {
    readonly java.util.concurrent.atomic.object f30b69a05;
    readonly java.util.concurrent.atomic.object f9d699093;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> fd0e45878;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.SingleObserver ff0872f50;

    public pd08e44b9(java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> atomicReference, io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        this.fd0e45878 = atomicReference;
        this.fd22a0a80 = singleObserver;
    }

    public static void MQYHkdhnMGqpDndx(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void MQYHkdhnMGqpDndx(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MQYHkdhnMGqpDndx(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MQYHkdhnMGqpDndx(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XHbTZfoHzmWwEmnQ(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XHbTZfoHzmWwEmnQ(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XHbTZfoHzmWwEmnQ(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool XHbTZfoHzmWwEmnQ(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static void XTQBQKNgnfsscojn(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void XTQBQKNgnfsscojn(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XTQBQKNgnfsscojn(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XTQBQKNgnfsscojn(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public override void OnError(java.lang.Exception th) {
        xTQBQKNgnfsscojn(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        XHbTZfoHzmWwEmnQ(this.fd0e45878, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        MQYHkdhnMGqpDndx(this.fd22a0a80, t);
    }
}

