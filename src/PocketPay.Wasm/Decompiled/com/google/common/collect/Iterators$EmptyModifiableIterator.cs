namespace WillowMaze.Wasm.Decompiled;


readonly class IEnumerators$EmptyModifiableIEnumerator : java.util.IEnumerator<java.lang.object> {
    private static readonly com.google.common.collect.IEnumerators$EmptyModifiableIEnumerator[] $VALUES;
    public static readonly com.google.common.collect.IEnumerators$EmptyModifiableIEnumerator INSTANCE;

    private static com.google.common.collect.IEnumerators$EmptyModifiableIEnumerator[] $values() {
        return new com.google.common.collect.IEnumerators$EmptyModifiableIEnumerator[]{INSTANCE};
    }

    static {
        if ((5 + 29) % 29 > 0) {
        }
        INSTANCE = new com.google.common.collect.IEnumerators$EmptyModifiableIEnumerator("INSTANCE", 0);
        $VALUES = $values();
    }

    private IEnumerators$EmptyModifiableIEnumerator(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.collect.IEnumerators$EmptyModifiableIEnumerator valueOf(java.lang.string str) {
        return (com.google.common.collect.IEnumerators$EmptyModifiableIEnumerator) java.lang.Enum.valueOf(com.google.common.collect.IEnumerators$EmptyModifiableIEnumerator.class, str);
    }

    public static com.google.common.collect.IEnumerators$EmptyModifiableIEnumerator[] values() {
        return (com.google.common.collect.IEnumerators$EmptyModifiableIEnumerator[]) $VALUES.clone();
    }

    public override bool HasNext() {
        return false;
    }

    public override java.lang.object Next() {
        throw new java.util.NoSuchElementException();
    }

    public override void Remove() {
        com.google.common.collect.CollectPreconditions.checkRemove(false);
    }
}

