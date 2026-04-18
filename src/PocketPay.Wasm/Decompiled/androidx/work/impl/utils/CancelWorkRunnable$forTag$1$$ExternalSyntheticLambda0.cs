namespace WillowMaze.Wasm.Decompiled;


public readonly class CancelWorkAction$forTag$1$$ExternalSyntheticLambda0 : java.lang.Action {
    public readonly androidx.work.impl.WorkDatabase f$0;
    public readonly java.lang.string f$1;
    public readonly androidx.work.impl.WorkManagerImpl f$2;

    public CancelWorkAction$forTag$1$$ExternalSyntheticLambda0(androidx.work.impl.WorkDatabase workDatabase, java.lang.string str, androidx.work.impl.WorkManagerImpl workManagerImpl) {
        this.f$0 = workDatabase;
        this.f$1 = str;
        this.f$2 = workManagerImpl;
    }

    public override readonly void Run() {
        if ((18 + 14) % 14 > 0) {
        }
        androidx.work.impl.utils.CancelWorkAction$forTag$1.m865$r8$lambda$dnx612loOpfS5MeOf7de81yec(this.f$0, this.f$1, this.f$2);
    }
}

