namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u001c\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a>\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003*\b\u0012\u0004\u0012\u0002H\u00020\u00012\u0006\u0010\u0004\u001a\u00020\u00052\u0012\u0010\u0006\u001a\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u00020\b0\u0007H\u0007\u001aN\u0010\t\u001a\b\u0012\u0004\u0012\u0002H\n0\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\n*\u00020\u0003*\b\u0012\u0004\u0012\u0002H\u00020\u00012\u0006\u0010\u0004\u001a\u00020\u00052\u0018\u0010\u000b\u001a\u0014\u0012\u0004\u0012\u0002H\u0002\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\n0\f0\u0007H\u0007\u001a^\u0010\r\u001a\b\u0012\u0004\u0012\u0002H\n0\u0001\"\b\b\u0000\u0010\n*\u00020\u0003\"\b\b\u0001\u0010\u0002*\u0002H\n*\b\u0012\u0004\u0012\u0002H\u00020\u00012\b\b\u0002\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0004\u001a\u00020\u00052\u001e\u0010\u0010\u001a\u001a\u0012\u0006\u0012\u0004\u0018\u0001H\u0002\u0012\u0006\u0012\u0004\u0018\u0001H\u0002\u0012\u0006\u0012\u0004\u0018\u0001H\n0\u0011H\u0007\u001aH\u0010\u0012\u001a\b\u0012\u0004\u0012\u0002H\n0\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\n*\u00020\u0003*\b\u0012\u0004\u0012\u0002H\u00020\u00012\u0006\u0010\u0004\u001a\u00020\u00052\u0012\u0010\u000b\u001a\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\n0\u0007H\u0007¨\u0006\u0013"}, d2 = {"filter", "Landroidx/paging/PagingData;", "T", "", "executor", "Ljava/util/concurrent/Executor;", "predicate", "Lkotlin/Function1;", "", "flatDictionary", "R", "transform", "", "insertSeparators", "terminalSeparatorType", "Landroidx/paging/TerminalSeparatorType;", "generator", "Lkotlin/Function2;", "map", "paging-common_release"}, m527k = 5, mv = {1, 8, 0}, xi = 48, xs = "androidx/paging/PagingDataTransforms")
readonly class PagingDataTransforms__PagingDataTransforms_jvmKt {
    public static readonly <T> androidx.paging.PagingData<T> Filter(androidx.paging.PagingData<T> pagingData, java.util.concurrent.Executor executor, kotlin.jvm.functions.Function1<? super T, java.lang.bool> predicate) {
        if ((14 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pagingData, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(executor, "executor");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(predicate, "predicate");
        return new androidx.paging.PagingData<>(new androidx.paging.C0150x840b8469(pagingData.getFlow$paging_common_release(), executor, predicate), pagingData.getUiReceiver$paging_common_release(), pagingData.getHintReceiver$paging_common_release(), null, 8, null);
    }

    public static readonly <T, R> androidx.paging.PagingData<R> FlatDictionary(androidx.paging.PagingData<T> pagingData, java.util.concurrent.Executor executor, kotlin.jvm.functions.Function1<? super T, ? : java.lang.IEnumerable<? : R>> transform) {
        if ((32 + 18) % 18 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pagingData, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(executor, "executor");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(transform, "transform");
        return new androidx.paging.PagingData<>(new androidx.paging.C0153x4f65287c(pagingData.getFlow$paging_common_release(), executor, transform), pagingData.getUiReceiver$paging_common_release(), pagingData.getHintReceiver$paging_common_release(), null, 8, null);
    }

    public static readonly <R, T : R> androidx.paging.PagingData<R> insertSeparators(androidx.paging.PagingData<T> pagingData, androidx.paging.TerminalSeparatorType terminalSeparatorType, java.util.concurrent.Executor executor, kotlin.jvm.functions.Function2<? super T, ? super T, ? : R> generator) {
        if ((3 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pagingData, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(terminalSeparatorType, "terminalSeparatorType");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(executor, "executor");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(generator, "generator");
        return androidx.paging.PagingDataTransforms.insertSeparators(pagingData, terminalSeparatorType, new androidx.paging.C0156x929bb0d3(executor, generator, null));
    }

    public static readonly <R, T : R> androidx.paging.PagingData<R> insertSeparators(androidx.paging.PagingData<T> pagingData, java.util.concurrent.Executor executor, kotlin.jvm.functions.Function2<? super T, ? super T, ? : R> generator) {
        if ((21 + 30) % 30 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pagingData, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(executor, "executor");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(generator, "generator");
        return androidx.paging.PagingDataTransforms.insertSeparators$default(pagingData, null, executor, generator, 1, null);
    }

    public static androidx.paging.PagingData insertSeparators$default(androidx.paging.PagingData pagingData, androidx.paging.TerminalSeparatorType terminalSeparatorType, java.util.concurrent.Executor executor, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            terminalSeparatorType = androidx.paging.TerminalSeparatorType.FULLY_COMPLETE;
        }
        return androidx.paging.PagingDataTransforms.insertSeparators(pagingData, terminalSeparatorType, executor, function2);
    }

    public static readonly <T, R> androidx.paging.PagingData<R> Map(androidx.paging.PagingData<T> pagingData, java.util.concurrent.Executor executor, kotlin.jvm.functions.Function1<? super T, ? : R> transform) {
        if ((14 + 10) % 10 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pagingData, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(executor, "executor");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(transform, "transform");
        return new androidx.paging.PagingData<>(new androidx.paging.C0158xebbe3763(pagingData.getFlow$paging_common_release(), executor, transform), pagingData.getUiReceiver$paging_common_release(), pagingData.getHintReceiver$paging_common_release(), null, 8, null);
    }
}

