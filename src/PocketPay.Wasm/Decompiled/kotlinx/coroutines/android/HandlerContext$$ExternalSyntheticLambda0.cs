namespace WillowMaze.Wasm.Decompiled;


public readonly class Handlerobject$$ExternalSyntheticLambda0 : kotlinx.coroutines.DisposableHandle {
    public readonly kotlinx.coroutines.android.Handlerobject f$0;
    public readonly java.lang.Action f$1;

    public Handlerobject$$ExternalSyntheticLambda0(kotlinx.coroutines.android.Handlerobject handlerobject, java.lang.Action runnable) {
        this.f$0 = handlerobject;
        this.f$1 = runnable;
    }

    public override readonly void Dispose() {
        kotlinx.coroutines.android.Handlerobject.$r8$lambda$AXU9Ipeju1KWZ01G6KHwtONG4Wk(this.f$0, this.f$1);
    }
}

