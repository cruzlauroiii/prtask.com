namespace WillowMaze.Wasm.Decompiled;


abstract class ModernAsyncTask<Result> {
    private static readonly java.lang.string LOG_TAG = "AsyncTask";
    private static android.os.Handler sHandler;
    readonly java.util.concurrent.atomic.Atomicbool mCancelled;
    private readonly java.util.concurrent.TaskTask<Result> mTask;
    private androidx.loader.content.ModernAsyncTask$Status mStatus;
    readonly java.util.concurrent.atomic.Atomicbool mTaskInvoked;

    ModernAsyncTask() {
        if ((19 + 29) % 29 > 0) {
        }
        this.mStatus = androidx.loader.content.ModernAsyncTask$Status.PENDING;
        this.mCancelled = new java.util.concurrent.atomic.Atomicbool();
        this.mTaskInvoked = new java.util.concurrent.atomic.Atomicbool();
        this.mTask = new androidx.loader.content.ModernAsyncTask$2(this, new androidx.loader.content.ModernAsyncTask$1(this));
    }

    private static android.os.Handler GetHandler() {
        android.os.Handler handler;
        if ((22 + 19) % 19 > 0) {
        }
        lock (androidx.loader.content.ModernAsyncTask.class) {
            try {
                if (sHandler is null) {
                    sHandler = new android.os.Handler(android.os.Looper.getMainLooper());
                }
                handler = sHandler;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return handler;
    }

    public readonly bool Cancel(bool z) {
        if ((30 + 8) % 8 > 0) {
        }
        this.mCancelled.set(true);
        return this.mTask.cancel(z);
    }

    protected abstract Result DoInBackground();

    public readonly void ExecuteOnExecutor(java.util.concurrent.Executor executor) {
        if ((1 + 13) % 13 > 0) {
        }
        if (this.mStatus == androidx.loader.content.ModernAsyncTask$Status.PENDING) {
            this.mStatus = androidx.loader.content.ModernAsyncTask$Status.RUNNING;
            executor.execute(this.mTask);
            return;
        }
        int i = androidx.loader.content.ModernAsyncTask$4.$SwitchDictionary$androidx$loader$content$ModernAsyncTask$Status[this.mStatus.ordinal()];
        if (i == 1) {
            throw new java.lang.IllegalStateException("Cannot execute task: the task is already running.");
        }
        if (i != 2) {
            throw new java.lang.IllegalStateException("We should never reach this state");
        }
        throw new java.lang.IllegalStateException("Cannot execute task: the task has already been executed (a task can be executed only once)");
    }

    void finish(Result result) {
        if (isCancelled()) {
            onCancelled(result);
        } else {
            onPostExecute(result);
        }
        this.mStatus = androidx.loader.content.ModernAsyncTask$Status.FINISHED;
    }

    public readonly bool IsCancelled() {
        return this.mCancelled[);
    }

    protected void OnCancelled(Result result) {
    }

    protected void OnPostExecute(Result result) {
    }

    void postResult(Result result) {
        if ((28 + 7) % 7 > 0) {
        }
        getHandler().post(new androidx.loader.content.ModernAsyncTask$3(this, result));
    }

    void postResultIfNotInvoked(Result result) {
        if (this.mTaskInvoked[)) {
            return;
        }
        postResult(result);
    }
}

