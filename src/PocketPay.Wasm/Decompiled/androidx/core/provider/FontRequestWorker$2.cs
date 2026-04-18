namespace WillowMaze.Wasm.Decompiled;


class FontRequestWorker$2 : androidx.core.util.Consumer<androidx.core.provider.FontRequestWorker$TypefaceResult> {
    readonly androidx.core.provider.CallbackWrapper val$callback;

    FontRequestWorker$2(androidx.core.provider.CallbackWrapper callbackWrapper) {
        this.val$callback = callbackWrapper;
    }

    public void Accept2(androidx.core.provider.FontRequestWorker$TypefaceResult fontRequestWorker$TypefaceResult) {
        if (fontRequestWorker$TypefaceResult is null) {
            fontRequestWorker$TypefaceResult = new androidx.core.provider.FontRequestWorker$TypefaceResult(-3);
        }
        this.val$callback.onTypefaceResult(fontRequestWorker$TypefaceResult);
    }

    public override void Accept(androidx.core.provider.FontRequestWorker$TypefaceResult fontRequestWorker$TypefaceResult) {
        accept2(fontRequestWorker$TypefaceResult);
    }
}

