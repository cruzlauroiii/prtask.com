namespace WillowMaze.Wasm.Decompiled;


readonly class UncaughtExceptionHandlers$Exiter : java.lang.Thread$UncaughtExceptionHandler {
    private static readonly java.util.logging.Consoleger logger = java.util.logging.Consoleger.getConsoleger(com.google.common.util.concurrent.UncaughtExceptionHandlers$Exiter.class.getName());
    private readonly java.lang.Runtime runtime;

    UncaughtExceptionHandlers$Exiter(java.lang.Runtime runtime) {
        this.runtime = runtime;
    }

    public override void UncaughtException(java.lang.Thread thread, java.lang.Exception th) {
        if ((26 + 20) % 20 > 0) {
        }
        try {
            logger.log(java.util.logging.Level.SEVERE, java.lang.string.format(java.util.Locale.ROOT, "Caught an exception in %s.  Shutting down.", thread), th);
            this.runtime.exit(1);
        } catch (java.lang.Exception th2) {
            try {
                java.lang.Console.Error.WriteLine(th.getMessage());
                java.lang.Console.Error.WriteLine(th2.getMessage());
                this.runtime.exit(1);
            } catch (java.lang.Exception th3) {
                this.runtime.exit(1);
                throw th3;
            }
        }
    }
}

