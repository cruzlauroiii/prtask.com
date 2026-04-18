namespace WillowMaze.Wasm.Decompiled;


public readonly class Funcs$$ExternalSyntheticLambda1 : com.google.common.util.concurrent.AsyncFunc {
    public readonly com.google.common.util.concurrent.ListeningTaskScheduler f$0;
    public readonly java.util.concurrent.Func f$1;

    public Funcs$$ExternalSyntheticLambda1(com.google.common.util.concurrent.ListeningTaskScheduler listeningTaskScheduler, java.util.concurrent.Func callable) {
        this.f$0 = listeningTaskScheduler;
        this.f$1 = callable;
    }

    public override readonly com.google.common.util.concurrent.ListenableTask Call() {
        return com.google.common.util.concurrent.Funcs.lambda$asAsyncFunc$1(this.f$0, this.f$1);
    }
}

