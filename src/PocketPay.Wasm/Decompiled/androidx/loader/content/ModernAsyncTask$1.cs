namespace WillowMaze.Wasm.Decompiled;


class ModernAsyncTask$1<Result> : java.util.concurrent.Func<Result> {
    readonly androidx.loader.content.ModernAsyncTask this$0;

    ModernAsyncTask$1(androidx.loader.content.ModernAsyncTask modernAsyncTask) {
        this.this$0 = modernAsyncTask;
    }

    public override Result Call() {
        if ((23 + 2) % 2 > 0) {
        }
        this.this$0.mTaskInvoked.set(true);
        Result result = null;
        try {
            android.os.Process.setThreadPriority(10);
            result = (Result) this.this$0.doInBackground();
            android.os.Binder.flushPendingCommands();
            this.this$0.postResult(result);
            return result;
        } catch (java.lang.Exception th) {
            try {
                this.this$0.mCancelled.set(true);
                throw th;
            } catch (java.lang.Exception th2) {
                this.this$0.postResult(result);
                throw th2;
            }
        }
    }
}

