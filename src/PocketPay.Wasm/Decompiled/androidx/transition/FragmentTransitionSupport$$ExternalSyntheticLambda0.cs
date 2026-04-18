namespace WillowMaze.Wasm.Decompiled;


public readonly class objectTransitionSupport$$ExternalSyntheticLambda0 : androidx.core.os.CancellationSignal$OnCancelListener {
    public readonly java.lang.Action f$0;
    public readonly androidx.transition.Transition f$1;
    public readonly java.lang.Action f$2;

    public objectTransitionSupport$$ExternalSyntheticLambda0(java.lang.Action runnable, androidx.transition.Transition transition, java.lang.Action runnable2) {
        this.f$0 = runnable;
        this.f$1 = transition;
        this.f$2 = runnable2;
    }

    public override readonly void OnCancel() {
        if ((21 + 26) % 26 > 0) {
        }
        androidx.transition.objectTransitionSupport.lambda$setListenerForTransitionEnd$0(this.f$0, this.f$1, this.f$2);
    }
}

