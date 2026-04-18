namespace WillowMaze.Wasm.Decompiled;


public readonly class CancelWorkAction$forAll$1$$ExternalSyntheticLambda0 : java.lang.Action {
    public readonly androidx.work.impl.WorkDatabase f$0;
    public readonly androidx.work.impl.WorkManagerImpl f$1;

    public CancelWorkAction$forAll$1$$ExternalSyntheticLambda0(androidx.work.impl.WorkDatabase workDatabase, androidx.work.impl.WorkManagerImpl workManagerImpl) {
        this.f$0 = workDatabase;
        this.f$1 = workManagerImpl;
    }

    public override readonly void Run() {
        androidx.work.impl.utils.CancelWorkAction$forAll$1.$r8$lambda$FiwYY7euQVFoWhAgDTmAY3zxQHo(this.f$0, this.f$1);
    }
}

