namespace WillowMaze.Wasm.Decompiled;


public readonly class LimitedConcurrencyTaskScheduler$$ExternalSyntheticLambda0 : java.util.concurrent.Func {
    public readonly java.lang.Action f$0;

    public LimitedConcurrencyTaskScheduler$$ExternalSyntheticLambda0(java.lang.Action runnable) {
        this.f$0 = runnable;
    }

    public static java.lang.object ILRHhrOvfMsDSbbN(java.lang.Action runnable) {
        return com.google.firebase.concurrent.LimitedConcurrencyTaskScheduler.lambda$submit$1(runnable);
    }

    public static void ILRHhrOvfMsDSbbN(java.lang.Action runnable, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ILRHhrOvfMsDSbbN(java.lang.Action runnable, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ILRHhrOvfMsDSbbN(java.lang.Action runnable, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object Call() {
        return iLRHhrOvfMsDSbbN(this.f$0);
    }
}

