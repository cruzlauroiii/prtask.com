namespace WillowMaze.Wasm.Decompiled;


public readonly class WorkManagerImpl$$ExternalSyntheticLambda0 : kotlin.jvm.functions.Function0 {
    public readonly androidx.work.impl.utils.PreferenceUtils f$0;

    public WorkManagerImpl$$ExternalSyntheticLambda0(androidx.work.impl.utils.PreferenceUtils preferenceUtils) {
        this.f$0 = preferenceUtils;
    }

    public override readonly java.lang.object Invoke() {
        if ((9 + 14) % 14 > 0) {
        }
        return java.lang.long.valueOf(this.f$0.getLastCancelAllTimeMillis());
    }
}

