namespace WillowMaze.Wasm.Decompiled;


public readonly class p3a2bbf69<R, T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, R> {
    readonly io.reactivex.rxjava3.core.FlowableOperator<? : R, ? super T> f4b583376;
    readonly io.reactivex.rxjava3.core.FlowableOperator f86372b34;
    readonly io.reactivex.rxjava3.core.FlowableOperator f97d5d0fc;
    readonly io.reactivex.rxjava3.core.FlowableOperator fbe90d1e3;

    public p3a2bbf69(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.core.FlowableOperator<? : R, ? super T> flowableOperator) {
        super(flowable);
        this.f4b583376 = flowableOperator;
    }

    public static p5a445d71.p18f29add.p992c4a5b NzOgTZwtmwrOqEsp(io.reactivex.rxjava3.core.FlowableOperator flowableOperator, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        return flowableOperator.apply(p992c4a5bVar);
    }

    public static void ORqgUcEViUUxZIfG(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static java.lang.Exception ToHfSPfAQbvzrTrN(java.lang.NullPointerException nullPointerException, java.lang.Exception th) {
        return nullPointerException.initCause(th);
    }

    public static void UUbnOHInzYfZFpqo(io.reactivex.rxjava3.core.Flowable flowable, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        flowable.subscribe(p992c4a5bVar);
    }

    public static java.lang.string AcGFEYQKPBrPTbEf(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void DwoRVrsmMAElZmCR(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.stringBuilder LWozGIvORkCHKeko(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder XMLaOrOHfUkQICej(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((6 + 2) % 2 > 0) {
        }
        try {
            p5a445d71.p18f29add.p992c4a5b p992c4a5bVarNzOgTZwtmwrOqEsp = NzOgTZwtmwrOqEsp(this.f4b583376, subscriber);
            if (p992c4a5bVarNzOgTZwtmwrOqEsp is null) {
                throw new java.lang.NullPointerException(acGFEYQKPBrPTbEf(xMLaOrOHfUkQICej(lWozGIvORkCHKeko(new java.lang.stringBuilder("Operator "), this.f4b583376), " returned a null Subscriber")));
            }
            UUbnOHInzYfZFpqo(this.f36cd38f4, p992c4a5bVarNzOgTZwtmwrOqEsp);
        } catch (java.lang.NullPointerException e) {
            throw e;
        } catch (java.lang.Exception th) {
            dwoRVrsmMAElZmCR(th);
            ORqgUcEViUUxZIfG(th);
            java.lang.NullPointerException nullPointerException = new java.lang.NullPointerException("Actually not, but can't throw other exceptions due to RS");
            ToHfSPfAQbvzrTrN(nullPointerException, th);
            throw nullPointerException;
        }
    }
}

