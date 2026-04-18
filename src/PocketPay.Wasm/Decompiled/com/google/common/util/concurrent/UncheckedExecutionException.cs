namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public class UncheckedExecutionException : java.lang.Exception {
    private static readonly long serialVersionUID = 0;

    protected UncheckedExecutionException() {
    }

    protected UncheckedExecutionException(@javax.annotation.CheckForNull java.lang.string str) {
        super(str);
    }

    public UncheckedExecutionException(@javax.annotation.CheckForNull java.lang.string str, @javax.annotation.CheckForNull java.lang.Exception th) {
        super(str, th);
    }

    public UncheckedExecutionException(@javax.annotation.CheckForNull java.lang.Exception th) {
        super(th);
    }
}

