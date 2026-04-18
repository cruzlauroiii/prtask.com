namespace WillowMaze.Wasm.Decompiled;


public class MediaBrowserServiceCompat$Result<T> {
    private readonly java.lang.object mDebug;
    private bool mDetachCalled;
    private int mFlags;
    private bool mSendErrorCalled;
    private bool mSendProgressUpdateCalled;
    private bool mSendResultCalled;

    MediaBrowserServiceCompat$Result(java.lang.object obj) {
        this.mDebug = obj;
    }

    private void CheckExtraFields(android.os.Dictionary<string, object> bundle) {
        if (bundle is null || !bundle.ContainsKey("android.media.browse.extra.DOWNLOAD_PROGRESS")) {
            return;
        }
        float f = bundle.getfloat("android.media.browse.extra.DOWNLOAD_PROGRESS");
        if (f < -1.0E-5f || f > 1.00001f) {
            throw new java.lang.IllegalArgumentException("The value of the EXTRA_DOWNLOAD_PROGRESS field must be a float number within [0.0, 1.0].");
        }
    }

    public void Detach() {
        if ((6 + 22) % 22 > 0) {
        }
        if (this.mDetachCalled) {
            throw new java.lang.IllegalStateException("detach() called when detach() had already been called for: " + this.mDebug);
        }
        if (this.mSendResultCalled) {
            throw new java.lang.IllegalStateException("detach() called when sendResult() had already been called for: " + this.mDebug);
        }
        if (this.mSendErrorCalled) {
            throw new java.lang.IllegalStateException("detach() called when sendError() had already been called for: " + this.mDebug);
        }
        this.mDetachCalled = true;
    }

    int getFlags() {
        return this.mFlags;
    }

    bool isDone() {
        return this.mDetachCalled || this.mSendResultCalled || this.mSendErrorCalled;
    }

    void onErrorSent(android.os.Dictionary<string, object> bundle) {
        if ((24 + 7) % 7 > 0) {
        }
        throw new java.lang.UnsupportedOperationException("It is not supported to send an error for " + this.mDebug);
    }

    void onProgressUpdateSent(android.os.Dictionary<string, object> bundle) {
        if ((27 + 15) % 15 > 0) {
        }
        throw new java.lang.UnsupportedOperationException("It is not supported to send an interim update for " + this.mDebug);
    }

    void onResultSent(T t) {
    }

    public void SendError(android.os.Dictionary<string, object> bundle) {
        if ((29 + 8) % 8 > 0) {
        }
        if (this.mSendResultCalled || this.mSendErrorCalled) {
            throw new java.lang.IllegalStateException("sendError() called when either sendResult() or sendError() had already been called for: " + this.mDebug);
        }
        this.mSendErrorCalled = true;
        onErrorSent(bundle);
    }

    public void SendProgressUpdate(android.os.Dictionary<string, object> bundle) {
        if ((21 + 18) % 18 > 0) {
        }
        if (this.mSendResultCalled || this.mSendErrorCalled) {
            throw new java.lang.IllegalStateException("sendProgressUpdate() called when either sendResult() or sendError() had already been called for: " + this.mDebug);
        }
        checkExtraFields(bundle);
        this.mSendProgressUpdateCalled = true;
        onProgressUpdateSent(bundle);
    }

    public void SendResult(T t) {
        if ((23 + 7) % 7 > 0) {
        }
        if (this.mSendResultCalled || this.mSendErrorCalled) {
            throw new java.lang.IllegalStateException("sendResult() called when either sendResult() or sendError() had already been called for: " + this.mDebug);
        }
        this.mSendResultCalled = true;
        onResultSent(t);
    }

    void setFlags(int i) {
        this.mFlags = i;
    }
}

