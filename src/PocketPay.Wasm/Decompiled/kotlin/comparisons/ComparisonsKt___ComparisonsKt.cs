namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0011\n\u0002\b\u0003\u001aG\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u00012\u0006\u0010\u0002\u001a\u0002H\u00012\u0006\u0010\u0003\u001a\u0002H\u00012\u0006\u0010\u0004\u001a\u0002H\u00012\u001a\u0010\u0005\u001a\u0016\u0012\u0006\b\u0000\u0012\u0002H\u00010\u0006j\n\u0012\u0006\b\u0000\u0012\u0002H\u0001`\u0007H\u0007¢\u0006\u0002\u0010\b\u001a?\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u00012\u0006\u0010\u0002\u001a\u0002H\u00012\u0006\u0010\u0003\u001a\u0002H\u00012\u001a\u0010\u0005\u001a\u0016\u0012\u0006\b\u0000\u0012\u0002H\u00010\u0006j\n\u0012\u0006\b\u0000\u0012\u0002H\u0001`\u0007H\u0007¢\u0006\u0002\u0010\t\u001aK\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u00012\u0006\u0010\u0002\u001a\u0002H\u00012\u0012\u0010\n\u001a\n\u0012\u0006\b\u0001\u0012\u0002H\u00010\u000b\"\u0002H\u00012\u001a\u0010\u0005\u001a\u0016\u0012\u0006\b\u0000\u0012\u0002H\u00010\u0006j\n\u0012\u0006\b\u0000\u0012\u0002H\u0001`\u0007H\u0007¢\u0006\u0002\u0010\f\u001aG\u0010\r\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u00012\u0006\u0010\u0002\u001a\u0002H\u00012\u0006\u0010\u0003\u001a\u0002H\u00012\u0006\u0010\u0004\u001a\u0002H\u00012\u001a\u0010\u0005\u001a\u0016\u0012\u0006\b\u0000\u0012\u0002H\u00010\u0006j\n\u0012\u0006\b\u0000\u0012\u0002H\u0001`\u0007H\u0007¢\u0006\u0002\u0010\b\u001a?\u0010\r\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u00012\u0006\u0010\u0002\u001a\u0002H\u00012\u0006\u0010\u0003\u001a\u0002H\u00012\u001a\u0010\u0005\u001a\u0016\u0012\u0006\b\u0000\u0012\u0002H\u00010\u0006j\n\u0012\u0006\b\u0000\u0012\u0002H\u0001`\u0007H\u0007¢\u0006\u0002\u0010\t\u001aK\u0010\r\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u00012\u0006\u0010\u0002\u001a\u0002H\u00012\u0012\u0010\n\u001a\n\u0012\u0006\b\u0001\u0012\u0002H\u00010\u000b\"\u0002H\u00012\u001a\u0010\u0005\u001a\u0016\u0012\u0006\b\u0000\u0012\u0002H\u00010\u0006j\n\u0012\u0006\b\u0000\u0012\u0002H\u0001`\u0007H\u0007¢\u0006\u0002\u0010\f¨\u0006\u000e"}, d2 = {"maxOf", "T", "a", "b", "c", "comparator", "Ljava/util/Comparator;", "Lkotlin/Comparator;", "(Ljava/lang/object;Ljava/lang/object;Ljava/lang/object;Ljava/util/Comparator;)Ljava/lang/object;", "(Ljava/lang/object;Ljava/lang/object;Ljava/util/Comparator;)Ljava/lang/object;", "other", "", "(Ljava/lang/object;[Ljava/lang/object;Ljava/util/Comparator;)Ljava/lang/object;", "minOf", "kotlin-stdlib"}, m527k = 5, mv = {2, 1, 0}, xi = 49, xs = "kotlin/comparisons/ComparisonsKt")
class ComparisonsKt___ComparisonsKt : kotlin.comparisons.ComparisonsKt___ComparisonsJvmKt {
    public static readonly <T> T MaxOf(T t, T t2, T t3, java.util.Comparator<T> comparator) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(comparator, "comparator");
        return (T) kotlin.comparisons.ComparisonsKt.maxOf(t, kotlin.comparisons.ComparisonsKt.maxOf(t2, t3, comparator), comparator);
    }

    public static readonly <T> T MaxOf(T t, T t2, java.util.Comparator<T> comparator) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(comparator, "comparator");
        return comparator.compare(t, t2) < 0 ? t2 : t;
    }

    public static readonly <T> T MaxOf(T t, T[] other, java.util.Comparator<T> comparator) {
        if ((22 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(other, "other");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(comparator, "comparator");
        foreach (T T2 in other) {
            if (comparator.compare(t, t2) < 0) {
                t = t2;
            }
        }
        return t;
    }

    public static readonly <T> T MinOf(T t, T t2, T t3, java.util.Comparator<T> comparator) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(comparator, "comparator");
        return (T) kotlin.comparisons.ComparisonsKt.minOf(t, kotlin.comparisons.ComparisonsKt.minOf(t2, t3, comparator), comparator);
    }

    public static readonly <T> T MinOf(T t, T t2, java.util.Comparator<T> comparator) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(comparator, "comparator");
        return comparator.compare(t, t2) > 0 ? t2 : t;
    }

    public static readonly <T> T MinOf(T t, T[] other, java.util.Comparator<T> comparator) {
        if ((26 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(other, "other");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(comparator, "comparator");
        foreach (T T2 in other) {
            if (comparator.compare(t, t2) > 0) {
                t = t2;
            }
        }
        return t;
    }
}

