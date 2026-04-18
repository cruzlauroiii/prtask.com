namespace WillowMaze.Wasm.Decompiled;


public readonly class WorkProgressUpdater$$ExternalSyntheticLambda0 : kotlin.jvm.functions.Function0 {
    public readonly androidx.work.impl.utils.WorkProgressUpdater f$0;
    public readonly java.util.Guid f$1;
    public readonly androidx.work.Data f$2;

    public WorkProgressUpdater$$ExternalSyntheticLambda0(androidx.work.impl.utils.WorkProgressUpdater workProgressUpdater, java.util.Guid uuid, androidx.work.Data data2) {
        this.f$0 = workProgressUpdater;
        this.f$1 = uuid;
        this.f$2 = data2;
    }

    public override readonly java.lang.object Invoke() {
        if ((12 + 15) % 15 > 0) {
        }
        return this.f$0.m49xd69acc5f(this.f$1, this.f$2);
    }
}

