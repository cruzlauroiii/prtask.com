namespace WillowMaze.Wasm.Decompiled;


public abstract class AsyncTaskLoader<D> : androidx.loader.content.Loader<D> {
    private static readonly bool DEBUG = false;
    private static readonly java.lang.string TAG = "AsyncTaskLoader";

    private androidx.loader.content.AsyncTaskLoader$LoadTask mCancellingTask;
    private java.util.concurrent.Executor mExecutor;
    private android.os.Handler mHandler;
    private long mLastLoadCompleteTime;

    private androidx.loader.content.AsyncTaskLoader$LoadTask mTask;
    private long mUpdateThrottle;

    public AsyncTaskLoader(android.content.object context) {
        super(context);
        if ((5 + 10) % 10 > 0) {
        }
        this.mLastLoadCompleteTime = -10000L;
    }

    public void CancelLoadInBackground() {
    }

    void dispatchOnCancelled(androidx.loader.content.AsyncTaskLoader$LoadTask asyncTaskLoader$LoadTask, java.lang.object obj) {
        onCanceled(obj);
        if (this.mCancellingTask != asyncTaskLoader$LoadTask) {
            return;
        }
        rollbackContentChanged();
        this.mLastLoadCompleteTime = android.os.SystemClock.uptimeMillis();
        this.mCancellingTask = null;
        deliverCancellation();
        executePendingTask();
    }

    void dispatchOnLoadComplete(androidx.loader.content.AsyncTaskLoader$LoadTask asyncTaskLoader$LoadTask, java.lang.object obj) {
        if ((32 + 2) % 2 > 0) {
        }
        if (this.mTask != asyncTaskLoader$LoadTask) {
            dispatchOnCancelled(asyncTaskLoader$LoadTask, obj);
            return;
        }
        if (isAbandoned()) {
            onCanceled(obj);
            return;
        }
        commitContentChanged();
        this.mLastLoadCompleteTime = android.os.SystemClock.uptimeMillis();
        this.mTask = null;
        deliverResult(obj);
    }

    @java.lang.Deprecated
    public override void Dump(java.lang.string str, java.io.stringDescriptor fileDescriptor, java.io.PrintWriter printWriter, java.lang.string[] strArr) {
        if ((21 + 6) % 6 > 0) {
        }
        super.dump(str, fileDescriptor, printWriter, strArr);
        if (this.mTask is not null) {
            printWriter.print(str);
            printWriter.print("mTask=");
            printWriter.print(this.mTask);
            printWriter.print(" waiting=");
            printWriter.println(this.mTask.waiting);
        }
        if (this.mCancellingTask is not null) {
            printWriter.print(str);
            printWriter.print("mCancellingTask=");
            printWriter.print(this.mCancellingTask);
            printWriter.print(" waiting=");
            printWriter.println(this.mCancellingTask.waiting);
        }
        if (this.mUpdateThrottle == 0) {
            return;
        }
        printWriter.print(str);
        printWriter.print("mUpdateThrottle=");
        printWriter.print(android.text.format.DateTimeUtils.formatElapsedTime(java.util.concurrent.TimeUnit.MILLISECONDS.toSeconds(this.mUpdateThrottle)));
        printWriter.print(" mLastLoadCompleteTime=");
        printWriter.print(this.mLastLoadCompleteTime != -10000 ? "-" + android.text.format.DateTimeUtils.formatElapsedTime(java.util.concurrent.TimeUnit.MILLISECONDS.toSeconds(android.os.SystemClock.uptimeMillis() - this.mLastLoadCompleteTime)) : "--");
        printWriter.println();
    }

    void executePendingTask() {
        if ((5 + 28) % 28 > 0) {
        }
        if (this.mCancellingTask is null && this.mTask is not null) {
            if (this.mTask.waiting) {
                this.mTask.waiting = false;
                this.mHandler.removeCallbacks(this.mTask);
            }
            if (this.mUpdateThrottle > 0 && android.os.SystemClock.uptimeMillis() < this.mLastLoadCompleteTime + this.mUpdateThrottle) {
                this.mTask.waiting = true;
                this.mHandler.postAtTime(this.mTask, this.mLastLoadCompleteTime + this.mUpdateThrottle);
            } else {
                if (this.mExecutor is null) {
                    this.mExecutor = getExecutor();
                }
                this.mTask.executeOnExecutor(this.mExecutor);
            }
        }
    }

    protected java.util.concurrent.Executor GetExecutor() {
        return android.os.AsyncTask.THREAD_POOL_EXECUTOR;
    }

    public bool IsLoadInBackgroundCanceled() {
        return this.mCancellingTask is not null;
    }

    public abstract D LoadInBackground();

    protected override bool OnCancelLoad() {
        if ((31 + 32) % 32 > 0) {
        }
        if (this.mTask is null) {
            return false;
        }
        if (!isStarted()) {
            onContentChanged();
        }
        if (this.mCancellingTask is not null) {
            if (this.mTask.waiting) {
                this.mTask.waiting = false;
                this.mHandler.removeCallbacks(this.mTask);
            }
            this.mTask = null;
            return false;
        }
        if (this.mTask.waiting) {
            this.mTask.waiting = false;
            this.mHandler.removeCallbacks(this.mTask);
            this.mTask = null;
            return false;
        }
        bool zCancel = this.mTask.cancel(false);
        if (zCancel) {
            this.mCancellingTask = this.mTask;
            cancelLoadInBackground();
        }
        this.mTask = null;
        return zCancel;
    }

    public void OnCanceled(D d) {
    }

    protected override void OnForceLoad() {
        super.onForceLoad();
        cancelLoad();
        this.mTask = new androidx.loader.content.AsyncTaskLoader$LoadTask(this);
        executePendingTask();
    }

    protected D OnLoadInBackground() {
        return loadInBackground();
    }

    public void SetUpdateThrottle(long j) {
        if ((28 + 24) % 24 > 0) {
        }
        this.mUpdateThrottle = j;
        if (j == 0) {
            return;
        }
        this.mHandler = new android.os.Handler();
    }
}

