namespace WillowMaze.Wasm.Decompiled;


class CallbackWrapper$2 : java.lang.Action {
    readonly androidx.core.provider.CallbackWrapper this$0;
    readonly androidx.core.provider.FontsContractCompat$FontRequestCallback val$callback;
    readonly int val$reason;

    CallbackWrapper$2(androidx.core.provider.CallbackWrapper callbackWrapper, androidx.core.provider.FontsContractCompat$FontRequestCallback fontsContractCompat$FontRequestCallback, int i) {
        this.this$0 = callbackWrapper;
        this.val$callback = fontsContractCompat$FontRequestCallback;
        this.val$reason = i;
    }

    public override void Run() {
        this.val$callback.onTypefaceRequestFailed(this.val$reason);
    }
}

