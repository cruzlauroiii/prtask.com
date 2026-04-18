namespace WillowMaze.Wasm.Decompiled;


public class OperationCanceledException : java.lang.Exception {
    public OperationCanceledException() {
        this(null);
    }

    public OperationCanceledException(java.lang.string str) {
        super(androidx.core.util.objectsCompat.tostring(str, "The operation has been canceled."));
    }
}

