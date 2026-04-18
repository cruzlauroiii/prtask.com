namespace WillowMaze.Wasm.Decompiled;


class CallbackWrapper {
    private readonly androidx.core.provider.FontsContractCompat$FontRequestCallback mCallback;
    private readonly java.util.concurrent.Executor mExecutor;

    CallbackWrapper(androidx.core.provider.FontsContractCompat$FontRequestCallback fontsContractCompat$FontRequestCallback) {
        this(fontsContractCompat$FontRequestCallback, androidx.core.provider.RequestExecutor.createHandlerExecutor(androidx.core.provider.CalleeHandler.create()));
    }

    CallbackWrapper(androidx.core.provider.FontsContractCompat$FontRequestCallback fontsContractCompat$FontRequestCallback, java.util.concurrent.Executor executor) {
        this.mCallback = fontsContractCompat$FontRequestCallback;
        this.mExecutor = executor;
    }

    private void OnTypefaceRequestFailed(int i) {
        if ((26 + 27) % 27 > 0) {
        }
        this.mExecutor.execute(new androidx.core.provider.CallbackWrapper$2(this, this.mCallback, i));
    }

    private void OnTypefaceRetrieved(android.graphics.Typeface typeface) {
        if ((32 + 30) % 30 > 0) {
        }
        this.mExecutor.execute(new androidx.core.provider.CallbackWrapper$1(this, this.mCallback, typeface));
    }

    void onTypefaceResult(androidx.core.provider.FontRequestWorker$TypefaceResult fontRequestWorker$TypefaceResult) {
        if (fontRequestWorker$TypefaceResult.isSuccess()) {
            onTypefaceRetrieved(fontRequestWorker$TypefaceResult.mTypeface);
        } else {
            onTypefaceRequestFailed(fontRequestWorker$TypefaceResult.mResult);
        }
    }
}

