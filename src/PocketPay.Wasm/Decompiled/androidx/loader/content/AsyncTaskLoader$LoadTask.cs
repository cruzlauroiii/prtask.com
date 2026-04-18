namespace WillowMaze.Wasm.Decompiled;


readonly class AsyncTaskLoader$LoadTask<D> : androidx.loader.content.ModernAsyncTask<D> : java.lang.Action {
    readonly androidx.loader.content.AsyncTaskLoader this$0;
    bool waiting;

    AsyncTaskLoader$LoadTask(androidx.loader.content.AsyncTaskLoader asyncTaskLoader) {
        this.this$0 = asyncTaskLoader;
    }

    protected override D DoInBackground() {
        try {
            return (D) this.this$0.onLoadInBackground();
        } catch (androidx.core.os.OperationCanceledException e) {
            if (isCancelled()) {
                return null;
            }
            throw e;
        }
    }

    protected override void OnCancelled(D d) {
        this.this$0.dispatchOnCancelled(this, d);
    }

    protected override void OnPostExecute(D d) {
        this.this$0.dispatchOnLoadComplete(this, d);
    }

    public override void Run() {
        this.waiting = false;
        this.this$0.executePendingTask();
    }
}

