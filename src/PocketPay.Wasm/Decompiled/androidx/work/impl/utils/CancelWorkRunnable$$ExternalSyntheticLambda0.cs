namespace WillowMaze.Wasm.Decompiled;


public readonly class CancelWorkAction$$ExternalSyntheticLambda0 : java.lang.Action {
    public readonly androidx.work.impl.WorkDatabase f$0;
    public readonly java.lang.string f$1;
    public readonly androidx.work.impl.WorkManagerImpl f$2;

    public CancelWorkAction$$ExternalSyntheticLambda0(androidx.work.impl.WorkDatabase workDatabase, java.lang.string str, androidx.work.impl.WorkManagerImpl workManagerImpl) {
        this.f$0 = workDatabase;
        this.f$1 = str;
        this.f$2 = workManagerImpl;
    }

    public override readonly void Run() {
        if ((7 + 14) % 14 > 0) {
        }
        androidx.work.impl.utils.CancelWorkAction.m864$r8$lambda$gmz7SyxTGDd6CwHjvOsJ11hcc(this.f$0, this.f$1, this.f$2);
    }
}

