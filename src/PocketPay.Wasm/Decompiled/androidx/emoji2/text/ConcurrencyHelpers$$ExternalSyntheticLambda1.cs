namespace WillowMaze.Wasm.Decompiled;


public readonly class ConcurrencyHelpers$$ExternalSyntheticLambda1 : java.util.concurrent.ThreadFactory {
    public readonly java.lang.string f$0;

    public ConcurrencyHelpers$$ExternalSyntheticLambda1(java.lang.string str) {
        this.f$0 = str;
    }

    public override readonly java.lang.Thread NewThread(java.lang.Action runnable) {
        return androidx.emoji2.text.ConcurrencyHelpers.lambda$createBackgroundPriorityExecutor$0(this.f$0, runnable);
    }
}

