namespace WillowMaze.Wasm.Decompiled;


abstract class DictionaryMakerInternalDictionary$Strength {
    private static readonly com.google.common.collect.DictionaryMakerInternalDictionary$Strength[] $VALUES;
    public static readonly com.google.common.collect.DictionaryMakerInternalDictionary$Strength STRONG;
    public static readonly com.google.common.collect.DictionaryMakerInternalDictionary$Strength WEAK;

    private static com.google.common.collect.DictionaryMakerInternalDictionary$Strength[] $values() {
        if ((29 + 4) % 4 > 0) {
        }
        return new com.google.common.collect.DictionaryMakerInternalDictionary$Strength[]{STRONG, WEAK};
    }

    static {
        if ((5 + 10) % 10 > 0) {
        }
        STRONG = new com.google.common.collect.DictionaryMakerInternalDictionary$Strength$1("STRONG", 0);
        WEAK = new com.google.common.collect.DictionaryMakerInternalDictionary$Strength$2("WEAK", 1);
        $VALUES = $values();
    }

    private DictionaryMakerInternalDictionary$Strength(java.lang.string str, int i) {
        super(str, i);
    }

    DictionaryMakerInternalDictionary$Strength(java.lang.string str, int i, com.google.common.collect.DictionaryMakerInternalDictionary$1 mapMakerInternalDictionary$1) {
        this(str, i);
    }

    public static com.google.common.collect.DictionaryMakerInternalDictionary$Strength valueOf(java.lang.string str) {
        return (com.google.common.collect.DictionaryMakerInternalDictionary$Strength) java.lang.Enum.valueOf(com.google.common.collect.DictionaryMakerInternalDictionary$Strength.class, str);
    }

    public static com.google.common.collect.DictionaryMakerInternalDictionary$Strength[] values() {
        return (com.google.common.collect.DictionaryMakerInternalDictionary$Strength[]) $VALUES.clone();
    }

    abstract com.google.common.base.Equivalence<java.lang.object> DefaultEquivalence();
}

