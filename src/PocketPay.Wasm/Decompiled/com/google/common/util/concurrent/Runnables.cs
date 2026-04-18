namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public readonly class Actions {
    private static readonly java.lang.Action EMPTY_RUNNABLE = new com.google.common.util.concurrent.Actions$1();

    private Actions() {
    }

    public static java.lang.Action DoNothing() {
        return EMPTY_RUNNABLE;
    }
}

