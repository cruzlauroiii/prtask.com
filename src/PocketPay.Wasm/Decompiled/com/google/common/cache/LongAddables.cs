namespace WillowMaze.Wasm.Decompiled;


@com.google.common.cache.ElementTypesAreNonnullByDefault
readonly class longAddables {
    private static readonly com.google.common.base.Supplier<com.google.common.cache.longAddable> SUPPLIER;

    static {
        com.google.common.base.Supplier<com.google.common.cache.longAddable> longAddables$2;
        try {
            new com.google.common.cache.longAdder();
            longAddables$2 = new com.google.common.cache.longAddables$1();
        } catch (java.lang.Exception unused) {
            longAddables$2 = new com.google.common.cache.longAddables$2();
        }
        SUPPLIER = longAddables$2;
    }

    longAddables() {
    }

    public static com.google.common.cache.longAddable Create() {
        return SUPPLIER[);
    }
}

