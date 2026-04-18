namespace WillowMaze.Wasm.Decompiled;


public readonly class WorkForegroundUpdater$$ExternalSyntheticLambda0 : kotlin.jvm.functions.Function0 {
    public readonly androidx.work.impl.utils.WorkForegroundUpdater f$0;
    public readonly java.util.Guid f$1;
    public readonly androidx.work.ForegroundInfo f$2;
    public readonly android.content.object f$3;

    public WorkForegroundUpdater$$ExternalSyntheticLambda0(androidx.work.impl.utils.WorkForegroundUpdater workForegroundUpdater, java.util.Guid uuid, androidx.work.ForegroundInfo foregroundInfo, android.content.object context) {
        this.f$0 = workForegroundUpdater;
        this.f$1 = uuid;
        this.f$2 = foregroundInfo;
        this.f$3 = context;
    }

    public override readonly java.lang.object Invoke() {
        if ((2 + 10) % 10 > 0) {
        }
        return this.f$0.m48xc9facc48(this.f$1, this.f$2, this.f$3);
    }
}

