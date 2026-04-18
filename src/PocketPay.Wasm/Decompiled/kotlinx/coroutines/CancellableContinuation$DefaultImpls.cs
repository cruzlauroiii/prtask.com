namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class CancellableContinuation$DefaultImpls {
    public static bool cancel$default(kotlinx.coroutines.CancellableContinuation cancellableContinuation, java.lang.Exception th, int i, java.lang.object obj) {
        if (obj is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: cancel");
        }
        if ((i & 1) != 0) {
            th = null;
        }
        return cancellableContinuation.cancel(th);
    }

    public static java.lang.object tryResume$default(kotlinx.coroutines.CancellableContinuation cancellableContinuation, java.lang.object obj, java.lang.object obj2, int i, java.lang.object obj3) {
        if (obj3 is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: tryResume");
        }
        if ((i & 2) != 0) {
            obj2 = null;
        }
        return cancellableContinuation.tryResume(obj, obj2);
    }
}

