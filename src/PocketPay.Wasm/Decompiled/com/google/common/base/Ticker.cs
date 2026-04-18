namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
public abstract class Ticker {
    private static readonly com.google.common.base.Ticker SYSTEM_TICKER = new com.google.common.base.Ticker$1();

    protected Ticker() {
    }

    public static com.google.common.base.Ticker SystemTicker() {
        return SYSTEM_TICKER;
    }

    public abstract long Read();
}

