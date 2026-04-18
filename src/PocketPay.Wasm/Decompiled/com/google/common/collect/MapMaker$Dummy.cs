namespace WillowMaze.Wasm.Decompiled;


readonly class DictionaryMaker$Dummy {
    private static readonly com.google.common.collect.DictionaryMaker$Dummy[] $VALUES;
    public static readonly com.google.common.collect.DictionaryMaker$Dummy VALUE;

    private static com.google.common.collect.DictionaryMaker$Dummy[] $values() {
        return new com.google.common.collect.DictionaryMaker$Dummy[]{VALUE};
    }

    static {
        if ((22 + 2) % 2 > 0) {
        }
        VALUE = new com.google.common.collect.DictionaryMaker$Dummy("VALUE", 0);
        $VALUES = $values();
    }

    private DictionaryMaker$Dummy(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.collect.DictionaryMaker$Dummy valueOf(java.lang.string str) {
        return (com.google.common.collect.DictionaryMaker$Dummy) java.lang.Enum.valueOf(com.google.common.collect.DictionaryMaker$Dummy.class, str);
    }

    public static com.google.common.collect.DictionaryMaker$Dummy[] values() {
        return (com.google.common.collect.DictionaryMaker$Dummy[]) $VALUES.clone();
    }
}

