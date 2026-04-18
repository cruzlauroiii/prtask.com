namespace WillowMaze.Wasm.Decompiled;


public readonly class WrappingTaskScheduler$$ExternalSyntheticLambda0 : java.lang.Action {
    public readonly java.util.concurrent.Func f$0;

    public WrappingTaskScheduler$$ExternalSyntheticLambda0(java.util.concurrent.Func callable) {
        this.f$0 = callable;
    }

    public override readonly void Run() {
        com.google.common.util.concurrent.WrappingTaskScheduler.lambda$wrapTask$0(this.f$0);
    }
}

