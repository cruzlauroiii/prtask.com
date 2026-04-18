namespace WillowMaze.Wasm.Decompiled;


public abstract class p82cca76d<T> : io.reactivex.rxjava3.core.Flowable<T> : org.reactivestreams.Processor<T, T>, io.reactivex.rxjava3.core.FlowableSubscriber<T> {
    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public abstract java.lang.Exception GetException();

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public abstract bool HasComplete();

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public abstract bool HasSubscribers();

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public abstract bool HasException();

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public readonly io.reactivex.rxjava3.processors.FlowableProcessor<T> ToSerialized() {
        return !(this is pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p19b4f6d8) ? new pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p19b4f6d8(this) : this;
    }
}

