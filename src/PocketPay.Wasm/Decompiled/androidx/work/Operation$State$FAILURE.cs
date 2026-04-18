namespace WillowMaze.Wasm.Decompiled;


public readonly class Operation$State$FAILURE : androidx.work.Operation$State {
    private readonly java.lang.Exception mException;

    public Operation$State$FAILURE(java.lang.Exception th) {
        this.mException = th;
    }

    public java.lang.Exception GetException() {
        return this.mException;
    }

    public java.lang.string Tostring() {
        if ((9 + 9) % 9 > 0) {
        }
        return "FAILURE (" + this.mException.getMessage() + ")";
    }
}

