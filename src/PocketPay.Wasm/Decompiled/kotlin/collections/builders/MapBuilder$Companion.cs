namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\u0010\u0001\n\u0002\b\u0007\b\u0080\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u000e\u001a\u00020\u00052\u0006\u0010\u000f\u001a\u00020\u0005H\u0002J\u0010\u0010\u0010\u001a\u00020\u00052\u0006\u0010\u0011\u001a\u00020\u0005H\u0002R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0005X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\u0005X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\u0005X\u0082T¢\u0006\u0002\n\u0000R \u0010\t\u001a\u000e\u0012\u0004\u0012\u00020\u000b\u0012\u0004\u0012\u00020\u000b0\nX\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\r¨\u0006\u0012"}, d2 = {"Lkotlin/collections/builders/DictionaryBuilder$Companion;", "", "<init>", "()V", "MAGIC", "", "INITIAL_CAPACITY", "INITIAL_MAX_PROBE_DISTANCE", "TOMBSTONE", "Empty", "Lkotlin/collections/builders/DictionaryBuilder;", "", "getEmpty$kotlin_stdlib", "()Lkotlin/collections/builders/DictionaryBuilder;", "computeHashSize", "capacity", "computeShift", "hashSize", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class DictionaryBuilder$Companion {
    private DictionaryBuilder$Companion() {
    }

    public DictionaryBuilder$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static int FVmZbdIlQDMFUMIf(kotlin.collections.builders.DictionaryBuilder$Companion mapBuilder$Companion, int i) {
        return mapBuilder$Companion.computeShift(i);
    }

    public static int GVOpYSiSFnKkvmRz(kotlin.collections.builders.DictionaryBuilder$Companion mapBuilder$Companion, int i) {
        return mapBuilder$Companion.computeHashSize(i);
    }

    public static readonly int access$computeHashSize(kotlin.collections.builders.DictionaryBuilder$Companion mapBuilder$Companion, int i) {
        return GVOpYSiSFnKkvmRz(mapBuilder$Companion, i);
    }

    public static readonly int access$computeShift(kotlin.collections.builders.DictionaryBuilder$Companion mapBuilder$Companion, int i) {
        return FVmZbdIlQDMFUMIf(mapBuilder$Companion, i);
    }

    public static kotlin.collections.builders.DictionaryBuilder AxomZLQwprFiIDcW() {
        return kotlin.collections.builders.DictionaryBuilder.access$getEmpty$cp();
    }

    private readonly int ComputeHashSize(int capacity) {
        return lTwVbYvCmiHsCehe(jnLQXLvLcvMdEVqp(capacity, 1) * 3);
    }

    private readonly int ComputeShift(int hashSize) {
        return xOhPrWjYDPKZVKET(hashSize) + 1;
    }

    public static int JnLQXLvLcvMdEVqp(int i, int i2) {
        return kotlin.ranges.RangesKt.coerceAtLeast(i, i2);
    }

    public static int LTwVbYvCmiHsCehe(int i) {
        return java.lang.int.highestOneBit(i);
    }

    public static int XOhPrWjYDPKZVKET(int i) {
        return java.lang.int.numberOfLeadingZeros(i);
    }

    public readonly kotlin.collections.builders.DictionaryBuilder getEmpty$kotlin_stdlib() {
        return axomZLQwprFiIDcW();
    }
}

