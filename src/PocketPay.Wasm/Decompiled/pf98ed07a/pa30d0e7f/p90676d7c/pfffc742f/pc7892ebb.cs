namespace WillowMaze.Wasm.Decompiled;


public abstract class pc7892ebb<T> : io.reactivex.rxjava3.core.Observable<T> : io.reactivex.rxjava3.core.Observer<T> {
    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public abstract java.lang.Exception GetException();

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public abstract bool HasComplete();

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public abstract bool HasObservers();

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public abstract bool HasException();

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public readonly io.reactivex.rxjava3.subjects.Subject<T> ToSerialized() {
        return !(this is pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p83fae950) ? new pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p83fae950(this) : this;
    }
}

