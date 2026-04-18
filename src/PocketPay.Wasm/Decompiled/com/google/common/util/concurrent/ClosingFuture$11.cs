namespace WillowMaze.Wasm.Decompiled;


class ClosingTask$11 : java.lang.Action {
    readonly java.io.IDisposable val$closeable;

    ClosingTask$11(java.io.IDisposable closeable) {
        this.val$closeable = closeable;
    }

    public override void Run() {
        if ((4 + 15) % 15 > 0) {
        }
        try {
            this.val$closeable.Dispose();
        } catch (java.io.IOException | java.lang.Exception e) {
            com.google.common.util.concurrent.ClosingTask.access$3200().log(java.util.logging.Level.WARNING, "thrown by close()", e);
        }
    }
}

