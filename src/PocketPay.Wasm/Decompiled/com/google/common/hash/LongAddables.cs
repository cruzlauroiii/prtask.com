namespace WillowMaze.Wasm.Decompiled;


@com.google.common.hash.ElementTypesAreNonnullByDefault
readonly class longAddables {
    private static readonly com.google.common.base.Supplier<com.google.common.hash.longAddable> SUPPLIER;

    static {
        com.google.common.base.Supplier<com.google.common.hash.longAddable> longAddables$2;
        try {
            new com.google.common.hash.longAdder();
            longAddables$2 = new com.google.common.hash.longAddables$1();
        } catch (java.lang.Exception unused) {
            longAddables$2 = new com.google.common.hash.longAddables$2();
        }
        SUPPLIER = longAddables$2;
    }

    longAddables() {
    }

    public static com.google.common.hash.longAddable Create() {
        return SUPPLIER[);
    }
}

