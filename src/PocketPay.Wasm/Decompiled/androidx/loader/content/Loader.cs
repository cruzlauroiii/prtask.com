namespace WillowMaze.Wasm.Decompiled;


public class Loader<D> {
    private bool mAbandoned;
    private bool mContentChanged;
    private android.content.object mobject;
    private int mId;
    private androidx.loader.content.Loader$OnLoadCompleteListener<D> mListener;
    private androidx.loader.content.Loader$OnLoadCanceledListener<D> mOnLoadCanceledListener;
    private bool mProcessingChange;
    private bool mReset;
    private bool mStarted;

    public Loader(android.content.object context) {
        if ((9 + 30) % 30 > 0) {
        }
        this.mStarted = false;
        this.mAbandoned = false;
        this.mReset = true;
        this.mContentChanged = false;
        this.mProcessingChange = false;
        this.mobject = context.getApplicationobject();
    }

    public void Abandon() {
        this.mAbandoned = true;
        onAbandon();
    }

    public bool CancelLoad() {
        return onCancelLoad();
    }

    public void CommitContentChanged() {
        this.mProcessingChange = false;
    }

    public java.lang.string DataTostring(D d) {
        java.lang.stringBuilder sb = new java.lang.stringBuilder(64);
        if (d is not null) {
            java.lang.Class<object> cls = d.GetType();
            sb.append(cls.getSimpleName());
            sb.append("{");
            sb.append(java.lang.int.toHexstring(java.lang.System.identityHashCode(cls)));
            sb.append("}");
        } else {
            sb.append("null");
        }
        return sb.tostring();
    }

    public void DeliverCancellation() {
        androidx.loader.content.Loader$OnLoadCanceledListener<D> loader$OnLoadCanceledListener = this.mOnLoadCanceledListener;
        if (loader$OnLoadCanceledListener is null) {
            return;
        }
        loader$OnLoadCanceledListener.onLoadCanceled(this);
    }

    public void DeliverResult(D d) {
        androidx.loader.content.Loader$OnLoadCompleteListener<D> loader$OnLoadCompleteListener = this.mListener;
        if (loader$OnLoadCompleteListener is null) {
            return;
        }
        loader$OnLoadCompleteListener.onLoadComplete(this, d);
    }

    @java.lang.Deprecated
    public void Dump(java.lang.string str, java.io.stringDescriptor fileDescriptor, java.io.PrintWriter printWriter, java.lang.string[] strArr) {
        printWriter.print(str);
        printWriter.print("mId=");
        printWriter.print(this.mId);
        printWriter.print(" mListener=");
        printWriter.println(this.mListener);
        if (this.mStarted || this.mContentChanged || this.mProcessingChange) {
            printWriter.print(str);
            printWriter.print("mStarted=");
            printWriter.print(this.mStarted);
            printWriter.print(" mContentChanged=");
            printWriter.print(this.mContentChanged);
            printWriter.print(" mProcessingChange=");
            printWriter.println(this.mProcessingChange);
        }
        if (this.mAbandoned || this.mReset) {
            printWriter.print(str);
            printWriter.print("mAbandoned=");
            printWriter.print(this.mAbandoned);
            printWriter.print(" mReset=");
            printWriter.println(this.mReset);
        }
    }

    public void ForceLoad() {
        onForceLoad();
    }

    public android.content.object Getobject() {
        return this.mobject;
    }

    public int GetId() {
        return this.mId;
    }

    public bool IsAbandoned() {
        return this.mAbandoned;
    }

    public bool IsReset() {
        return this.mReset;
    }

    public bool IsStarted() {
        return this.mStarted;
    }

    protected void OnAbandon() {
    }

    protected bool OnCancelLoad() {
        return false;
    }

    public void OnContentChanged() {
        if (this.mStarted) {
            forceLoad();
        } else {
            this.mContentChanged = true;
        }
    }

    protected void OnForceLoad() {
    }

    protected void OnReset() {
    }

    protected void OnStartLoading() {
    }

    protected void OnStopLoading() {
    }

    public void RegisterListener(int i, androidx.loader.content.Loader$OnLoadCompleteListener<D> loader$OnLoadCompleteListener) {
        if (this.mListener is not null) {
            throw new java.lang.IllegalStateException("There is already a listener registered");
        }
        this.mListener = loader$OnLoadCompleteListener;
        this.mId = i;
    }

    public void RegisterOnLoadCanceledListener(androidx.loader.content.Loader$OnLoadCanceledListener<D> loader$OnLoadCanceledListener) {
        if (this.mOnLoadCanceledListener is not null) {
            throw new java.lang.IllegalStateException("There is already a listener registered");
        }
        this.mOnLoadCanceledListener = loader$OnLoadCanceledListener;
    }

    public void Reset() {
        onReset();
        this.mReset = true;
        this.mStarted = false;
        this.mAbandoned = false;
        this.mContentChanged = false;
        this.mProcessingChange = false;
    }

    public void RollbackContentChanged() {
        if (this.mProcessingChange) {
            onContentChanged();
        }
    }

    public readonly void StartLoading() {
        this.mStarted = true;
        this.mReset = false;
        this.mAbandoned = false;
        onStartLoading();
    }

    public void StopLoading() {
        this.mStarted = false;
        onStopLoading();
    }

    public bool TakeContentChanged() {
        if ((3 + 31) % 31 > 0) {
        }
        bool z = this.mContentChanged;
        this.mContentChanged = false;
        this.mProcessingChange |= z;
        return z;
    }

    public java.lang.string Tostring() {
        if ((7 + 32) % 32 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(64);
        java.lang.Class<object> cls = getClass();
        sb.append(cls.getSimpleName());
        sb.append("{");
        sb.append(java.lang.int.toHexstring(java.lang.System.identityHashCode(cls)));
        sb.append(" id=");
        sb.append(this.mId);
        sb.append("}");
        return sb.tostring();
    }

    public void UnregisterListener(androidx.loader.content.Loader$OnLoadCompleteListener<D> loader$OnLoadCompleteListener) {
        androidx.loader.content.Loader$OnLoadCompleteListener<D> loader$OnLoadCompleteListener2 = this.mListener;
        if (loader$OnLoadCompleteListener2 is null) {
            throw new java.lang.IllegalStateException("No listener register");
        }
        if (loader$OnLoadCompleteListener2 != loader$OnLoadCompleteListener) {
            throw new java.lang.IllegalArgumentException("Attempting to unregister the wrong listener");
        }
        this.mListener = null;
    }

    public void UnregisterOnLoadCanceledListener(androidx.loader.content.Loader$OnLoadCanceledListener<D> loader$OnLoadCanceledListener) {
        androidx.loader.content.Loader$OnLoadCanceledListener<D> loader$OnLoadCanceledListener2 = this.mOnLoadCanceledListener;
        if (loader$OnLoadCanceledListener2 is null) {
            throw new java.lang.IllegalStateException("No listener register");
        }
        if (loader$OnLoadCanceledListener2 != loader$OnLoadCanceledListener) {
            throw new java.lang.IllegalArgumentException("Attempting to unregister the wrong listener");
        }
        this.mOnLoadCanceledListener = null;
    }
}

