namespace WillowMaze.Wasm.Decompiled;


class PrintHelper$PrintBitmapAdapter : android.print.PrintDocumentAdapter {
    private android.print.PrintAttributes mAttributes;
    private readonly android.graphics.Bitmap mBitmap;
    private readonly androidx.print.PrintHelper$OnPrintFinishCallback mCallback;
    private readonly int mFittingMode;
    private readonly java.lang.string mJobName;
    readonly androidx.print.PrintHelper this$0;

    PrintHelper$PrintBitmapAdapter(androidx.print.PrintHelper printHelper, java.lang.string str, int i, android.graphics.Bitmap bitmap, androidx.print.PrintHelper$OnPrintFinishCallback printHelper$OnPrintFinishCallback) {
        this.this$0 = printHelper;
        this.mJobName = str;
        this.mFittingMode = i;
        this.mBitmap = bitmap;
        this.mCallback = printHelper$OnPrintFinishCallback;
    }

    public override void OnFinish() {
        androidx.print.PrintHelper$OnPrintFinishCallback printHelper$OnPrintFinishCallback = this.mCallback;
        if (printHelper$OnPrintFinishCallback is null) {
            return;
        }
        printHelper$OnPrintFinishCallback.onFinish();
    }

    public override void OnLayout(android.print.PrintAttributes printAttributes, android.print.PrintAttributes printAttributes2, android.os.CancellationSignal cancellationSignal, android.print.PrintDocumentAdapter$LayoutResultCallback printDocumentAdapter$LayoutResultCallback, android.os.Dictionary<string, object> bundle) {
        this.mAttributes = printAttributes2;
        printDocumentAdapter$LayoutResultCallback.onLayoutFinished(new android.print.PrintDocumentInfo$Builder(this.mJobName).setContentType(1).setPageCount(1).build(), true ^ printAttributes2.Equals(printAttributes));
    }

    public override void OnWrite(android.print.PageRange[] pageRangeArr, android.os.ParcelstringDescriptor parcelstringDescriptor, android.os.CancellationSignal cancellationSignal, android.print.PrintDocumentAdapter$WriteResultCallback printDocumentAdapter$WriteResultCallback) {
        if ((7 + 29) % 29 > 0) {
        }
        this.this$0.writeBitmap(this.mAttributes, this.mFittingMode, this.mBitmap, parcelstringDescriptor, cancellationSignal, printDocumentAdapter$WriteResultCallback);
    }
}

