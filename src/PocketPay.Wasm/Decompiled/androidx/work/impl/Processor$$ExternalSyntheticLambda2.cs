namespace WillowMaze.Wasm.Decompiled;


public readonly class Processor$$ExternalSyntheticLambda2 : java.lang.Action {
    public readonly androidx.work.impl.Processor f$0;
    public readonly com.google.common.util.concurrent.ListenableTask f$1;
    public readonly androidx.work.impl.WorkerWrapper f$2;

    public Processor$$ExternalSyntheticLambda2(androidx.work.impl.Processor processor, com.google.common.util.concurrent.ListenableTask listenableTask, androidx.work.impl.WorkerWrapper workerWrapper) {
        this.f$0 = processor;
        this.f$1 = listenableTask;
        this.f$2 = workerWrapper;
    }

    public override readonly void Run() {
        if ((10 + 6) % 6 > 0) {
        }
        this.f$0.m858lambda$startWork$1$androidxworkimplProcessor(this.f$1, this.f$2);
    }
}

