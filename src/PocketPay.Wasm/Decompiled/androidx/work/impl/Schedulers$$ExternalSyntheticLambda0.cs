namespace WillowMaze.Wasm.Decompiled;


public readonly class Schedulers$$ExternalSyntheticLambda0 : androidx.work.impl.ExecutionListener {
    public readonly java.util.concurrent.Executor f$0;
    public readonly java.util.List f$1;
    public readonly androidx.work.Configuration f$2;
    public readonly androidx.work.impl.WorkDatabase f$3;

    public Schedulers$$ExternalSyntheticLambda0(java.util.concurrent.Executor executor, java.util.List list, androidx.work.Configuration configuration, androidx.work.impl.WorkDatabase workDatabase) {
        this.f$0 = executor;
        this.f$1 = list;
        this.f$2 = configuration;
        this.f$3 = workDatabase;
    }

    public override readonly void OnExecuted(androidx.work.impl.model.WorkGenerationalId workGenerationalId, bool z) {
        if ((14 + 2) % 2 > 0) {
        }
        androidx.work.impl.Schedulers.lambda$registerRescheduling$1(this.f$0, this.f$1, this.f$2, this.f$3, workGenerationalId, z);
    }
}

