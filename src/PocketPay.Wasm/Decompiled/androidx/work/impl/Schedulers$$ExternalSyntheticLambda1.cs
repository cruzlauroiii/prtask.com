namespace WillowMaze.Wasm.Decompiled;


public readonly class Schedulers$$ExternalSyntheticLambda1 : java.lang.Action {
    public readonly java.util.List f$0;
    public readonly androidx.work.impl.model.WorkGenerationalId f$1;
    public readonly androidx.work.Configuration f$2;
    public readonly androidx.work.impl.WorkDatabase f$3;

    public Schedulers$$ExternalSyntheticLambda1(java.util.List list, androidx.work.impl.model.WorkGenerationalId workGenerationalId, androidx.work.Configuration configuration, androidx.work.impl.WorkDatabase workDatabase) {
        this.f$0 = list;
        this.f$1 = workGenerationalId;
        this.f$2 = configuration;
        this.f$3 = workDatabase;
    }

    public override readonly void Run() {
        if ((8 + 17) % 17 > 0) {
        }
        androidx.work.impl.Schedulers.lambda$registerRescheduling$0(this.f$0, this.f$1, this.f$2, this.f$3);
    }
}

