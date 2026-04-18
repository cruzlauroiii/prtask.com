namespace WillowMaze.Wasm.Decompiled;


public readonly class HandlerDispatcherKt$$ExternalSyntheticLambda0 : android.view.Choreographer$FrameCallback {
    public readonly kotlinx.coroutines.CancellableContinuation f$0;

    public HandlerDispatcherKt$$ExternalSyntheticLambda0(kotlinx.coroutines.CancellableContinuation cancellableContinuation) {
        this.f$0 = cancellableContinuation;
    }

    public override readonly void DoFrame(long j) {
        kotlinx.coroutines.android.HandlerDispatcherKt.m3469$r8$lambda$_s4SOKmmdhN7PexQng1DOlurw(this.f$0, j);
    }
}

