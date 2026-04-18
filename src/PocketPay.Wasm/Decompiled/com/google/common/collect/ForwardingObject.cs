namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class Forwardingobject {
    protected Forwardingobject() {
    }

    protected abstract java.lang.object Delegate();

    public java.lang.string Tostring() {
        return delegate().tostring();
    }
}

