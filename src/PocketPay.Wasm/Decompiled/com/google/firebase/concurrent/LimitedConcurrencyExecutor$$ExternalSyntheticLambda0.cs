namespace WillowMaze.Wasm.Decompiled;


public readonly class LimitedConcurrencyExecutor$$ExternalSyntheticLambda0 : java.lang.Action {
    public readonly com.google.firebase.concurrent.LimitedConcurrencyExecutor f$0;
    public readonly java.lang.Action f$1;

    public LimitedConcurrencyExecutor$$ExternalSyntheticLambda0(com.google.firebase.concurrent.LimitedConcurrencyExecutor limitedConcurrencyExecutor, java.lang.Action runnable) {
        this.f$0 = limitedConcurrencyExecutor;
        this.f$1 = runnable;
    }

    public static void EVcabOBzmTfXrFbM(com.google.firebase.concurrent.LimitedConcurrencyExecutor limitedConcurrencyExecutor, java.lang.Action runnable) {
        limitedConcurrencyExecutor.m346x96c64136(runnable);
    }

    public static void EVcabOBzmTfXrFbM(com.google.firebase.concurrent.LimitedConcurrencyExecutor limitedConcurrencyExecutor, java.lang.Action runnable, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EVcabOBzmTfXrFbM(com.google.firebase.concurrent.LimitedConcurrencyExecutor limitedConcurrencyExecutor, java.lang.Action runnable, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EVcabOBzmTfXrFbM(com.google.firebase.concurrent.LimitedConcurrencyExecutor limitedConcurrencyExecutor, java.lang.Action runnable, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Run() {
        eVcabOBzmTfXrFbM(this.f$0, this.f$1);
    }
}

