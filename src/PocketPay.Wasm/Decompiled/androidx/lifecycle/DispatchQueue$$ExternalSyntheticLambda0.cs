namespace WillowMaze.Wasm.Decompiled;


public readonly class DispatchQueue$$ExternalSyntheticLambda0 : java.lang.Action {
    public readonly androidx.lifecycle.DispatchQueue f$0;
    public readonly java.lang.Action f$1;

    public DispatchQueue$$ExternalSyntheticLambda0(androidx.lifecycle.DispatchQueue dispatchQueue, java.lang.Action runnable) {
        this.f$0 = dispatchQueue;
        this.f$1 = runnable;
    }

    public override readonly void Run() {
        androidx.lifecycle.DispatchQueue.m685$r8$lambda$QTUwShsnwO8ux11W0mzm9OKBq8(this.f$0, this.f$1);
    }
}

