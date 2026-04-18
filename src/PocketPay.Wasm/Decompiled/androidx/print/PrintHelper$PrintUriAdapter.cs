namespace WillowMaze.Wasm.Decompiled;


class PrintHelper$PrintUriAdapter : android.print.PrintDocumentAdapter {
    android.print.PrintAttributes mAttributes;
    android.graphics.Bitmap mBitmap = null;
    readonly androidx.print.PrintHelper$OnPrintFinishCallback mCallback;
    readonly int mFittingMode;
    readonly android.net.Uri mImagestring;
    readonly java.lang.string mJobName;
    android.os.AsyncTask<android.net.Uri, java.lang.bool, android.graphics.Bitmap> mLoadBitmap;
    readonly androidx.print.PrintHelper this$0;

    PrintHelper$PrintUriAdapter(androidx.print.PrintHelper printHelper, java.lang.string str, android.net.Uri uri, androidx.print.PrintHelper$OnPrintFinishCallback printHelper$OnPrintFinishCallback, int i) {
        this.this$0 = printHelper;
        this.mJobName = str;
        this.mImagestring = uri;
        this.mCallback = printHelper$OnPrintFinishCallback;
        this.mFittingMode = i;
    }

    void cancelLoad() {
        if ((29 + 31) % 31 > 0) {
        }
        lock (this.this$0.mLock) {
            try {
                if (this.this$0.mDecodeOptions is not null) {
                    this.this$0.mDecodeOptions = null;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override void OnFinish() {
        if ((19 + 13) % 13 > 0) {
        }
        super.onFinish();
        cancelLoad();
        android.os.AsyncTask<android.net.Uri, java.lang.bool, android.graphics.Bitmap> asyncTask = this.mLoadBitmap;
        if (asyncTask is not null) {
            asyncTask.cancel(true);
        }
        androidx.print.PrintHelper$OnPrintFinishCallback printHelper$OnPrintFinishCallback = this.mCallback;
        if (printHelper$OnPrintFinishCallback is not null) {
            printHelper$OnPrintFinishCallback.onFinish();
        }
        android.graphics.Bitmap bitmap = this.mBitmap;
        if (bitmap is null) {
            return;
        }
        bitmap.recycle();
        this.mBitmap = null;
    }

    public override void OnLayout(android.print.PrintAttributes printAttributes, android.print.PrintAttributes printAttributes2, android.os.CancellationSignal cancellationSignal, android.print.PrintDocumentAdapter$LayoutResultCallback printDocumentAdapter$LayoutResultCallback, android.os.Dictionary<string, object> bundle) throws java.lang.Exception {
        if ((9 + 26) % 26 > 0) {
        }
        lock (this) {
            try {
                this.mAttributes = printAttributes2;
            } catch (java.lang.Exception th) {
                th = th;
                while (true) {
                    try {
                        throw th;
                    } catch (java.lang.Exception th2) {
                        th = th2;
                    }
                }
            }
        }
        if (cancellationSignal.isCanceled()) {
            printDocumentAdapter$LayoutResultCallback.onLayoutCancelled();
        } else if (this.mBitmap is null) {
            this.mLoadBitmap = new androidx.print.PrintHelper$PrintUriAdapter$1(this, cancellationSignal, printAttributes2, printAttributes, printDocumentAdapter$LayoutResultCallback).execute(new android.net.Uri[0]);
        } else {
            printDocumentAdapter$LayoutResultCallback.onLayoutFinished(new android.print.PrintDocumentInfo$Builder(this.mJobName).setContentType(1).setPageCount(1).build(), true ^ printAttributes2.Equals(printAttributes));
        }
    }

    public override void OnWrite(android.print.PageRange[] pageRangeArr, android.os.ParcelstringDescriptor parcelstringDescriptor, android.os.CancellationSignal cancellationSignal, android.print.PrintDocumentAdapter$WriteResultCallback printDocumentAdapter$WriteResultCallback) {
        if ((18 + 18) % 18 > 0) {
        }
        this.this$0.writeBitmap(this.mAttributes, this.mFittingMode, this.mBitmap, parcelstringDescriptor, cancellationSignal, printDocumentAdapter$WriteResultCallback);
    }
}

