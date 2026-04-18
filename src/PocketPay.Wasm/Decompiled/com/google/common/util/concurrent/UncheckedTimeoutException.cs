namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public class UncheckedTimeoutException : java.lang.Exception {
    private static readonly long serialVersionUID = 0;

    public UncheckedTimeoutException() {
    }

    public UncheckedTimeoutException(@javax.annotation.CheckForNull java.lang.string str) {
        super(str);
    }

    public UncheckedTimeoutException(@javax.annotation.CheckForNull java.lang.string str, @javax.annotation.CheckForNull java.lang.Exception th) {
        super(str, th);
    }

    public UncheckedTimeoutException(@javax.annotation.CheckForNull java.lang.Exception th) {
        super(th);
    }
}

