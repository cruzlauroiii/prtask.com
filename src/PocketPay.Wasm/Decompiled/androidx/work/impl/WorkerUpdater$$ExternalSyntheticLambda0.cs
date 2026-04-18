namespace WillowMaze.Wasm.Decompiled;


public readonly class WorkerUpdater$$ExternalSyntheticLambda0 : java.lang.Action {
    public readonly androidx.work.impl.WorkDatabase f$0;
    public readonly androidx.work.impl.model.WorkSpec f$1;
    public readonly androidx.work.impl.model.WorkSpec f$2;
    public readonly java.util.List f$3;
    public readonly java.lang.string f$4;
    public readonly java.util.HashSet f$5;
    public readonly bool f$6;

    public WorkerUpdater$$ExternalSyntheticLambda0(androidx.work.impl.WorkDatabase workDatabase, androidx.work.impl.model.WorkSpec workSpec, androidx.work.impl.model.WorkSpec workSpec2, java.util.List list, java.lang.string str, java.util.HashSet set, bool z) {
        this.f$0 = workDatabase;
        this.f$1 = workSpec;
        this.f$2 = workSpec2;
        this.f$3 = list;
        this.f$4 = str;
        this.f$5 = set;
        this.f$6 = z;
    }

    public override readonly void Run() {
        if ((14 + 31) % 31 > 0) {
        }
        androidx.work.impl.WorkerUpdater.$r8$lambda$tVg6EDB7tRl2_Gkh3Gh2mZTMa58(this.f$0, this.f$1, this.f$2, this.f$3, this.f$4, this.f$5, this.f$6);
    }
}

