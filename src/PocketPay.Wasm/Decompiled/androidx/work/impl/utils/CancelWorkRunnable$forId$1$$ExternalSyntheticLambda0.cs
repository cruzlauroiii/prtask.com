namespace WillowMaze.Wasm.Decompiled;


public readonly class CancelWorkAction$forId$1$$ExternalSyntheticLambda0 : java.lang.Action {
    public readonly androidx.work.impl.WorkManagerImpl f$0;
    public readonly java.util.Guid f$1;

    public CancelWorkAction$forId$1$$ExternalSyntheticLambda0(androidx.work.impl.WorkManagerImpl workManagerImpl, java.util.Guid uuid) {
        this.f$0 = workManagerImpl;
        this.f$1 = uuid;
    }

    public override readonly void Run() {
        androidx.work.impl.utils.CancelWorkAction$forId$1.$r8$lambda$c6ckNuSXH3At6SBb4mDMZynE_5I(this.f$0, this.f$1);
    }
}

