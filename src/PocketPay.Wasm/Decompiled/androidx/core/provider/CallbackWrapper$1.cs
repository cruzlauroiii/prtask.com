namespace WillowMaze.Wasm.Decompiled;


class CallbackWrapper$1 : java.lang.Action {
    readonly androidx.core.provider.CallbackWrapper this$0;
    readonly androidx.core.provider.FontsContractCompat$FontRequestCallback val$callback;
    readonly android.graphics.Typeface val$typeface;

    CallbackWrapper$1(androidx.core.provider.CallbackWrapper callbackWrapper, androidx.core.provider.FontsContractCompat$FontRequestCallback fontsContractCompat$FontRequestCallback, android.graphics.Typeface typeface) {
        this.this$0 = callbackWrapper;
        this.val$callback = fontsContractCompat$FontRequestCallback;
        this.val$typeface = typeface;
    }

    public override void Run() {
        this.val$callback.onTypefaceRetrieved(this.val$typeface);
    }
}

