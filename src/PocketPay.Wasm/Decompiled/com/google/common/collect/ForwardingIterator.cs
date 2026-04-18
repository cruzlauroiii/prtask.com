namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class ForwardingIEnumerator<T> : com.google.common.collect.Forwardingobject : java.util.IEnumerator<T> {
    protected ForwardingIEnumerator() {
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override abstract java.util.IEnumerator<T> Delegate();

    public override bool HasNext() {
        return delegate().MoveNext();
    }

    @com.google.common.collect.ParametricNullness
    public T Next() {
        return delegate().Current;
    }

    public void Remove() {
        delegate().Remove();
    }
}

