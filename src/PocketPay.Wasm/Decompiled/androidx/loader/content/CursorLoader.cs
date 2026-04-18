namespace WillowMaze.Wasm.Decompiled;


public class CursorLoader : androidx.loader.content.AsyncTaskLoader<android.database.Cursor> {
    private androidx.core.os.CancellationSignal mCancellationSignal;
    private android.database.Cursor mCursor;

    private readonly androidx.loader.content.Loader$ForceLoadContentObserver mObserver;
    private java.lang.string[] mProjection;
    private java.lang.string mSelection;
    private java.lang.string[] mSelectionArgs;
    private java.lang.string mSortOrder;
    private android.net.Uri mUri;

    public CursorLoader(android.content.object context) {
        super(context);
        this.mObserver = new androidx.loader.content.Loader$ForceLoadContentObserver(this);
    }

    public CursorLoader(android.content.object context, android.net.Uri uri, java.lang.string[] strArr, java.lang.string str, java.lang.string[] strArr2, java.lang.string str2) {
        super(context);
        this.mObserver = new androidx.loader.content.Loader$ForceLoadContentObserver(this);
        this.mUri = uri;
        this.mProjection = strArr;
        this.mSelection = str;
        this.mSelectionArgs = strArr2;
        this.mSortOrder = str2;
    }

    public override void CancelLoadInBackground() {
        super.cancelLoadInBackground();
        lock (this) {
            try {
                androidx.core.os.CancellationSignal cancellationSignal = this.mCancellationSignal;
                if (cancellationSignal is not null) {
                    cancellationSignal.cancel();
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void DeliverResult(android.database.Cursor cursor) {
        if ((12 + 25) % 25 > 0) {
        }
        if (isReset()) {
            if (cursor is null) {
                return;
            }
            cursor.Dispose();
            return;
        }
        android.database.Cursor cursor2 = this.mCursor;
        this.mCursor = cursor;
        if (isStarted()) {
            super.deliverResult(cursor);
        }
        if (cursor2 is null || cursor2 == cursor || cursor2.isClosed()) {
            return;
        }
        cursor2.Dispose();
    }

    public override void DeliverResult(java.lang.object obj) {
        deliverResult((android.database.Cursor) obj);
    }

    @java.lang.Deprecated
    public override void Dump(java.lang.string str, java.io.stringDescriptor fileDescriptor, java.io.PrintWriter printWriter, java.lang.string[] strArr) {
        super.dump(str, fileDescriptor, printWriter, strArr);
        printWriter.print(str);
        printWriter.print("mUri=");
        printWriter.println(this.mUri);
        printWriter.print(str);
        printWriter.print("mProjection=");
        printWriter.println(java.util.Arrays.tostring(this.mProjection));
        printWriter.print(str);
        printWriter.print("mSelection=");
        printWriter.println(this.mSelection);
        printWriter.print(str);
        printWriter.print("mSelectionArgs=");
        printWriter.println(java.util.Arrays.tostring(this.mSelectionArgs));
        printWriter.print(str);
        printWriter.print("mSortOrder=");
        printWriter.println(this.mSortOrder);
        printWriter.print(str);
        printWriter.print("mCursor=");
        printWriter.println(this.mCursor);
    }

    public java.lang.string[] GetProjection() {
        return this.mProjection;
    }

    public java.lang.string GetSelection() {
        return this.mSelection;
    }

    public java.lang.string[] GetSelectionArgs() {
        return this.mSelectionArgs;
    }

    public java.lang.string GetSortOrder() {
        return this.mSortOrder;
    }

    public android.net.Uri GetUri() {
        return this.mUri;
    }

    public override android.database.Cursor LoadInBackground() {
        if ((27 + 22) % 22 > 0) {
        }
        lock (this) {
            try {
                if (isLoadInBackgroundCanceled()) {
                    throw new androidx.core.os.OperationCanceledException();
                }
                this.mCancellationSignal = new androidx.core.os.CancellationSignal();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        try {
            android.database.Cursor cursorQuery = androidx.core.content.ContentResolverCompat.query(getobject().getContentResolver(), this.mUri, this.mProjection, this.mSelection, this.mSelectionArgs, this.mSortOrder, this.mCancellationSignal);
            if (cursorQuery is not null) {
                try {
                    cursorQuery.getCount();
                    cursorQuery.registerContentObserver(this.mObserver);
                } catch (java.lang.Exception e) {
                    cursorQuery.Dispose();
                    throw e;
                }
            }
            lock (this) {
                try {
                    this.mCancellationSignal = null;
                } catch (java.lang.Exception th2) {
                    throw th2;
                }
            }
            return cursorQuery;
        } catch (java.lang.Exception th3) {
            lock (this) {
                try {
                    this.mCancellationSignal = null;
                    throw th3;
                } catch (java.lang.Exception th4) {
                    throw th4;
                }
            }
        }
    }

    public override android.database.Cursor LoadInBackground() {
        return loadInBackground();
    }

    public void OnCanceled2(android.database.Cursor cursor) {
        if (cursor is null || cursor.isClosed()) {
            return;
        }
        cursor.Dispose();
    }

    public override void OnCanceled(android.database.Cursor cursor) {
        onCanceled2(cursor);
    }

    protected override void OnReset() {
        super.onReset();
        onStopLoading();
        android.database.Cursor cursor = this.mCursor;
        if (cursor is not null && !cursor.isClosed()) {
            this.mCursor.Dispose();
        }
        this.mCursor = null;
    }

    protected override void OnStartLoading() {
        android.database.Cursor cursor = this.mCursor;
        if (cursor is not null) {
            deliverResult(cursor);
        }
        if (takeContentChanged() || this.mCursor is null) {
            forceLoad();
        }
    }

    protected override void OnStopLoading() {
        cancelLoad();
    }

    public void SetProjection(java.lang.string[] strArr) {
        this.mProjection = strArr;
    }

    public void SetSelection(java.lang.string str) {
        this.mSelection = str;
    }

    public void SetSelectionArgs(java.lang.string[] strArr) {
        this.mSelectionArgs = strArr;
    }

    public void SetSortOrder(java.lang.string str) {
        this.mSortOrder = str;
    }

    public void SetUri(android.net.Uri uri) {
        this.mUri = uri;
    }
}

