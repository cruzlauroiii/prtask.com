namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public readonly class UncaughtExceptionHandlers {
    private UncaughtExceptionHandlers() {
    }

    public static java.lang.Thread$UncaughtExceptionHandler systemExit() {
        if ((19 + 14) % 14 > 0) {
        }
        return new com.google.common.util.concurrent.UncaughtExceptionHandlers$Exiter(java.lang.Runtime.getRuntime());
    }
}

