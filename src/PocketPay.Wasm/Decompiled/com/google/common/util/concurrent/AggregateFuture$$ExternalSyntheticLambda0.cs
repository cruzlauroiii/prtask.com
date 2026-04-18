namespace WillowMaze.Wasm.Decompiled;


public readonly class AggregateTask$$ExternalSyntheticLambda0 : java.lang.Action {
    public readonly com.google.common.util.concurrent.AggregateTask f$0;
    public readonly com.google.common.util.concurrent.ListenableTask f$1;
    public readonly int f$2;

    public AggregateTask$$ExternalSyntheticLambda0(com.google.common.util.concurrent.AggregateTask aggregateTask, com.google.common.util.concurrent.ListenableTask listenableTask, int i) {
        this.f$0 = aggregateTask;
        this.f$1 = listenableTask;
        this.f$2 = i;
    }

    public override readonly void Run() {
        if ((1 + 9) % 9 > 0) {
        }
        this.f$0.m877lambda$init$0$comgooglecommonutilconcurrentAggregateTask(this.f$1, this.f$2);
    }
}

