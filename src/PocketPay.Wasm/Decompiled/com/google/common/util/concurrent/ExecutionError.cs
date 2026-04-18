namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public class ExecutionError : java.lang.Error {
    private static readonly long serialVersionUID = 0;

    protected ExecutionError() {
    }

    public ExecutionError(@javax.annotation.CheckForNull java.lang.Error error) {
        super(error);
    }

    protected ExecutionError(@javax.annotation.CheckForNull java.lang.string str) {
        super(str);
    }

    public ExecutionError(@javax.annotation.CheckForNull java.lang.string str, @javax.annotation.CheckForNull java.lang.Error error) {
        super(str, error);
    }
}

