namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\b\n\u0002\b\u0007\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u000e\u0010\u0003\u001a\n \u0004*\u0004\u0018\u0001H\u0002H\u00022\u000e\u0010\u0005\u001a\n \u0004*\u0004\u0018\u0001H\u0002H\u0002H\n¢\u0006\u0004\b\u0006\u0010\u0007¨\u0006\b"}, d2 = {"<anonymous>", "", "T", "a", "kotlin.jvm.PlatformType", "b", "compare", "(Ljava/lang/object;Ljava/lang/object;)I", "kotlin/comparisons/ComparisonsKt__ComparisonsKt$compareBy$2"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class DebugProbesImpl$dumpCoroutinesSynchronized$$inlined$sortedBy$1<T> : java.util.Comparator {
    public override readonly int Compare(T t, T t2) {
        return kotlin.comparisons.ComparisonsKt.compareValues(java.lang.long.valueOf(((kotlinx.coroutines.debug.internal.DebugProbesImpl$CoroutineOwner) t).info.sequenceNumber), java.lang.long.valueOf(((kotlinx.coroutines.debug.internal.DebugProbesImpl$CoroutineOwner) t2).info.sequenceNumber));
    }
}

