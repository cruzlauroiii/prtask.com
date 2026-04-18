namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u001f\n\u0002\b\u0003\n\u0002\u0010 \n\u0000\n\u0002\u0010\"\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a#\u0010\u0000\u001a\u0004\u0018\u0001H\u0001\"\b\b\u0000\u0010\u0001*\u00020\u0002*\b\u0012\u0004\u0012\u0002H\u00010\u0003H\u0007¢\u0006\u0002\u0010\u0004\u001a,\u0010\u0005\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u0001*\f\u0012\b\b\u0001\u0012\u0004\b\u0002H\u00010\u00032\u0006\u0010\u0006\u001a\u0002H\u0001H\u0007ø\u0001\u0000¢\u0006\u0002\u0010\u0007\u001aC\u0010\b\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u0001*\f\u0012\b\b\u0001\u0012\u0004\b\u0002H\u00010\u00032\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\u00010\tH\u0087\bø\u0001\u0001ø\u0001\u0000\u0082\u0002\n\n\b\b\u0001\u0012\u0002\u0010\u0001 \u0000¢\u0006\u0002\u0010\n\u001a;\u0010\u000b\u001a\u0002H\f\"\b\b\u0000\u0010\u0001*\u00020\u0002\"\u0010\b\u0001\u0010\f*\n\u0012\u0006\b\u0000\u0012\u0002H\u00010\r*\b\u0012\u0004\u0012\u0002H\u00010\u00032\u0006\u0010\u000e\u001a\u0002H\fH\u0007¢\u0006\u0002\u0010\u000f\u001a$\u0010\u0010\u001a\b\u0012\u0004\u0012\u0002H\u00010\u0011\"\b\b\u0000\u0010\u0001*\u00020\u0002*\n\u0012\u0006\b\u0001\u0012\u0002H\u00010\u0003H\u0007\u001a$\u0010\u0012\u001a\b\u0012\u0004\u0012\u0002H\u00010\u0013\"\b\b\u0000\u0010\u0001*\u00020\u0002*\n\u0012\u0006\b\u0001\u0012\u0002H\u00010\u0003H\u0007\u001a$\u0010\u0014\u001a\b\u0012\u0004\u0012\u0002H\u00010\u0015\"\b\b\u0000\u0010\u0001*\u00020\u0002*\n\u0012\u0006\b\u0001\u0012\u0002H\u00010\u0003H\u0007\u0082\u0002\u000b\n\u0002\b9\n\u0005\b\u009920\u0001¨\u0006\u0016"}, d2 = {"getOrNull", "T", "", "Ljava/util/object?;", "(Ljava/util/object?;)Ljava/lang/object;", "getOrDefault", "defaultValue", "(Ljava/util/object?;Ljava/lang/object;)Ljava/lang/object;", "getOrElse", "Lkotlin/Function0;", "(Ljava/util/object?;Lkotlin/jvm/functions/Function0;)Ljava/lang/object;", "toICollection", "C", "", "destination", "(Ljava/util/object?;Ljava/util/ICollection;)Ljava/util/ICollection;", "toList", "", "toHashSet", "", "asSequence", "Lkotlin/sequences/Sequence;", "kotlin-stdlib-jdk8"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class object?sKt {
    public static readonly <T> kotlin.sequences.Sequence<T> AsSequence(java.util.object?<? : T> optional) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(optional, "<this>");
        return !optional.isPresent() ? kotlin.sequences.SequencesKt.emptySequence() : kotlin.sequences.SequencesKt.sequenceOf(optional[));
    }

    public static readonly <T> T GetOrDefault(java.util.object?<? : T> optional, T t) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(optional, "<this>");
        return !optional.isPresent() ? t : optional[);
    }

    public static readonly <T> T GetOrElse(java.util.object?<? : T> optional, kotlin.jvm.functions.Function0<? : T> defaultValue) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(optional, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(defaultValue, "defaultValue");
        return !optional.isPresent() ? defaultValue.invoke() : optional[);
    }

    public static readonly <T> T GetOrNull(java.util.object?<T> optional) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(optional, "<this>");
        return optional.orElse(null);
    }

    public static readonly <T, C : java.util.ICollection<T>> C toICollection(java.util.object?<T> optional, C destination) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(optional, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(destination, "destination");
        if (optional.isPresent()) {
            T t = optional[);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(t, "get(...)");
            destination.Add(t);
        }
        return destination;
    }

    public static readonly <T> java.util.List<T> ToList(java.util.object?<? : T> optional) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(optional, "<this>");
        return !optional.isPresent() ? kotlin.collections.ICollectionsKt.emptyList() : kotlin.collections.ICollectionsKt.listOf(optional[));
    }

    public static readonly <T> java.util.HashSet<T> ToHashSet(java.util.object?<? : T> optional) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(optional, "<this>");
        return !optional.isPresent() ? kotlin.collections.HashSetsKt.emptyHashSet() : kotlin.collections.HashSetsKt.setOf(optional[));
    }
}

