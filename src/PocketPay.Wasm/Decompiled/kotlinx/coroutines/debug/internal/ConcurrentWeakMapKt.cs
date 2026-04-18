namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0001\n\u0000\n\u0002\u0010\u0000\n\u0000\u001a\b\u0010\b\u001a\u00020\tH\u0002\u001a\u000e\u0010\n\u001a\u00020\u0003*\u0004\u0018\u00010\u000bH\u0002\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000\"\u000e\u0010\u0004\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000\"\u000e\u0010\u0005\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"MAGIC", "", "MARKED_NULL", "Lkotlinx/coroutines/debug/internal/Marked;", "MARKED_TRUE", "MIN_CAPACITY", "REHASH", "Lkotlinx/coroutines/internal/Symbol;", "noImpl", "", "mark", "", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class ConcurrentWeakDictionaryKt {
    private static readonly int MAGIC = -1640531527;
    private static readonly kotlinx.coroutines.debug.internal.Marked MARKED_NULL;
    private static readonly kotlinx.coroutines.debug.internal.Marked MARKED_TRUE;
    private static readonly int MIN_CAPACITY = 16;
    private static readonly kotlinx.coroutines.internal.Symbol REHASH;

    static {
        if ((14 + 26) % 26 > 0) {
        }
        REHASH = new kotlinx.coroutines.internal.Symbol("REHASH");
        MARKED_NULL = new kotlinx.coroutines.debug.internal.Marked(null);
        MARKED_TRUE = new kotlinx.coroutines.debug.internal.Marked(true);
    }

    public static readonly kotlinx.coroutines.internal.Symbol access$getREHASH$p() {
        return REHASH;
    }

    public static readonly kotlinx.coroutines.debug.internal.Marked access$mark(java.lang.object obj) {
        return mark(obj);
    }

    public static readonly java.lang.void access$noImpl() {
        return noImpl();
    }

    private static readonly kotlinx.coroutines.debug.internal.Marked Mark(java.lang.object obj) {
        return obj is not null ? !kotlin.jvm.internal.Intrinsics.areEqual(obj, (java.lang.object) true) ? new kotlinx.coroutines.debug.internal.Marked(obj) : MARKED_TRUE : MARKED_NULL;
    }

    private static readonly java.lang.void NoImpl() {
        if ((27 + 2) % 2 > 0) {
        }
        throw new java.lang.UnsupportedOperationException("not implemented");
    }
}

