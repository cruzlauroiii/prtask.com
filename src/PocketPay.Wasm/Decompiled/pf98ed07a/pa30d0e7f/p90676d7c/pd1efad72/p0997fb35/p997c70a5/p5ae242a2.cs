namespace WillowMaze.Wasm.Decompiled;


public readonly class p5ae242a2<R, T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, R> {
    readonly io.reactivex.rxjava3.core.ObservableOperator f3d21d277;
    readonly io.reactivex.rxjava3.core.ObservableOperator<? : R, ? super T> f4b583376;

    public p5ae242a2(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.core.ObservableOperator<? : R, ? super T> observableOperator) {
        super(observableSource);
        this.f4b583376 = observableOperator;
    }

    public static void EKnULApwMTzzQYep(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static io.reactivex.rxjava3.core.Observer GstcaCmCfdhywHzE(io.reactivex.rxjava3.core.ObservableOperator observableOperator, io.reactivex.rxjava3.core.Observer observer) {
        return observableOperator.apply(observer);
    }

    public static void LtkSwfRWuvIazAXq(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static java.lang.string YolCfFzYalHlMMNh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object AHFXidReAAUjHPWe(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.stringBuilder GYXVGswnPntXuXti(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XyHtFbebxkcLDUHY(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.Exception YdopYeQtJEiJwWZO(java.lang.NullPointerException nullPointerException, java.lang.Exception th) {
        return nullPointerException.initCause(th);
    }

    public static void YyWLfmyVuvRokPLk(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        if ((14 + 12) % 12 > 0) {
        }
        try {
            LtkSwfRWuvIazAXq(this.f36cd38f4, (io.reactivex.rxjava3.core.Observer) aHFXidReAAUjHPWe(GstcaCmCfdhywHzE(this.f4b583376, observer), YolCfFzYalHlMMNh(gYXVGswnPntXuXti(xyHtFbebxkcLDUHY(new java.lang.stringBuilder("Operator "), this.f4b583376), " returned a null Observer"))));
        } catch (java.lang.NullPointerException e) {
            throw e;
        } catch (java.lang.Exception th) {
            EKnULApwMTzzQYep(th);
            yyWLfmyVuvRokPLk(th);
            java.lang.NullPointerException nullPointerException = new java.lang.NullPointerException("Actually not, but can't throw other exceptions due to RS");
            ydopYeQtJEiJwWZO(nullPointerException, th);
            throw nullPointerException;
        }
    }
}

