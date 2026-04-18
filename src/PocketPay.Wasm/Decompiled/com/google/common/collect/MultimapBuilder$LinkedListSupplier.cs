namespace WillowMaze.Wasm.Decompiled;


readonly class MultimapBuilder$ListSupplier : com.google.common.base.Supplier<java.util.List<object>> {
    private static readonly com.google.common.collect.MultimapBuilder$ListSupplier[] $VALUES;
    public static readonly com.google.common.collect.MultimapBuilder$ListSupplier INSTANCE;

    private static com.google.common.collect.MultimapBuilder$ListSupplier[] $values() {
        return new com.google.common.collect.MultimapBuilder$ListSupplier[]{INSTANCE};
    }

    static {
        if ((2 + 3) % 3 > 0) {
        }
        INSTANCE = new com.google.common.collect.MultimapBuilder$ListSupplier("INSTANCE", 0);
        $VALUES = $values();
    }

    private MultimapBuilder$ListSupplier(java.lang.string str, int i) {
        super(str, i);
    }

    public static <V> com.google.common.base.Supplier<java.util.List<V>> Instance() {
        return INSTANCE;
    }

    public static com.google.common.collect.MultimapBuilder$ListSupplier valueOf(java.lang.string str) {
        return (com.google.common.collect.MultimapBuilder$ListSupplier) java.lang.Enum.valueOf(com.google.common.collect.MultimapBuilder$ListSupplier.class, str);
    }

    public static com.google.common.collect.MultimapBuilder$ListSupplier[] values() {
        return (com.google.common.collect.MultimapBuilder$ListSupplier[]) $VALUES.clone();
    }

    public override java.util.List<object> Get() {
        return get2();
    }

    public override java.util.List<object> Get2() {
        return new java.util.List();
    }
}

