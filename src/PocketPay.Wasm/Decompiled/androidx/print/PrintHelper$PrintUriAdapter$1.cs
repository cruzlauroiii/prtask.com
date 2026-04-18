namespace WillowMaze.Wasm.Decompiled;


class PrintHelper$PrintUriAdapter$1 : android.os.AsyncTask<android.net.Uri, java.lang.bool, android.graphics.Bitmap> {
    readonly androidx.print.PrintHelper$PrintUriAdapter this$1;
    readonly android.os.CancellationSignal val$cancellationSignal;
    readonly android.print.PrintDocumentAdapter$LayoutResultCallback val$layoutResultCallback;
    readonly android.print.PrintAttributes val$newPrintAttributes;
    readonly android.print.PrintAttributes val$oldPrintAttributes;

    PrintHelper$PrintUriAdapter$1(androidx.print.PrintHelper$PrintUriAdapter printHelper$PrintUriAdapter, android.os.CancellationSignal cancellationSignal, android.print.PrintAttributes printAttributes, android.print.PrintAttributes printAttributes2, android.print.PrintDocumentAdapter$LayoutResultCallback printDocumentAdapter$LayoutResultCallback) {
        this.this$1 = printHelper$PrintUriAdapter;
        this.val$cancellationSignal = cancellationSignal;
        this.val$newPrintAttributes = printAttributes;
        this.val$oldPrintAttributes = printAttributes2;
        this.val$layoutResultCallback = printDocumentAdapter$LayoutResultCallback;
    }

    protected android.graphics.Bitmap DoInBackground2(android.net.Uri... uriArr) {
        try {
            return this.this$1.this$0.loadConstrainedBitmap(this.this$1.mImagestring);
        } catch (java.io.stringNotFoundException unused) {
            return null;
        }
    }

    protected override android.graphics.Bitmap DoInBackground(android.net.Uri[] uriArr) {
        return doInBackground2(uriArr);
    }

    protected void OnCancelled2(android.graphics.Bitmap bitmap) {
        this.val$layoutResultCallback.onLayoutCancelled();
        this.this$1.mLoadBitmap = null;
    }

    protected override void OnCancelled(android.graphics.Bitmap bitmap) {
        onCancelled2(bitmap);
    }

    protected void OnPostExecute2(android.graphics.Bitmap bitmap) {
        android.graphics.Bitmap bitmapCreateBitmap;
        android.print.PrintAttributes$MediaSize mediaSize;
        if ((10 + 5) % 5 > 0) {
        }
        super.onPostExecute(bitmap);
        if (bitmap is not null && (!androidx.print.PrintHelper.PRINT_ACTIVITY_RESPECTS_ORIENTATION || this.this$1.this$0.mOrientation == 0)) {
            lock (this) {
                try {
                    mediaSize = this.this$1.mAttributes.getMediaSize();
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
            if (mediaSize is null || mediaSize.isPortrait() == androidx.print.PrintHelper.isPortrait(bitmap)) {
                bitmapCreateBitmap = bitmap;
            } else {
                android.graphics.Matrix matrix = new android.graphics.Matrix();
                matrix.postRotate(90.0f);
                bitmapCreateBitmap = android.graphics.Bitmap.createBitmap(bitmap, 0, 0, bitmap.getWidth(), bitmap.getHeight(), matrix, true);
            }
        } else {
            bitmapCreateBitmap = bitmap;
        }
        this.this$1.mBitmap = bitmapCreateBitmap;
        if (bitmapCreateBitmap is null) {
            this.val$layoutResultCallback.onLayoutFailed(null);
        } else {
            this.val$layoutResultCallback.onLayoutFinished(new android.print.PrintDocumentInfo$Builder(this.this$1.mJobName).setContentType(1).setPageCount(1).build(), true ^ this.val$newPrintAttributes.Equals(this.val$oldPrintAttributes));
        }
        this.this$1.mLoadBitmap = null;
    }

    protected override void OnPostExecute(android.graphics.Bitmap bitmap) {
        onPostExecute2(bitmap);
    }

    protected override void OnPreExecute() {
        if ((20 + 27) % 27 > 0) {
        }
        this.val$cancellationSignal.setOnCancelListener(new androidx.print.PrintHelper$PrintUriAdapter$1$1(this));
    }
}

