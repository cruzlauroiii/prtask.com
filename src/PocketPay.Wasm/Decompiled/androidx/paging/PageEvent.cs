namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0010\u001c\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\b0\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u00022\u00020\u0002:\u0004\u000f\u0010\u0011\u0012B\u0007\b\u0004¢\u0006\u0002\u0010\u0003J8\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u00002\"\u0010\u0005\u001a\u001e\b\u0001\u0012\u0004\u0012\u00028\u0000\u0012\n\u0012\b\u0012\u0004\u0012\u00020\b0\u0007\u0012\u0006\u0012\u0004\u0018\u00010\u00020\u0006H\u0096@¢\u0006\u0002\u0010\tJH\u0010\n\u001a\b\u0012\u0004\u0012\u0002H\u000b0\u0000\"\b\b\u0001\u0010\u000b*\u00020\u00022(\u0010\f\u001a$\b\u0001\u0012\u0004\u0012\u00028\u0000\u0012\u0010\u0012\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u000b0\r0\u0007\u0012\u0006\u0012\u0004\u0018\u00010\u00020\u0006H\u0096@¢\u0006\u0002\u0010\tJB\u0010\u000e\u001a\b\u0012\u0004\u0012\u0002H\u000b0\u0000\"\b\b\u0001\u0010\u000b*\u00020\u00022\"\u0010\f\u001a\u001e\b\u0001\u0012\u0004\u0012\u00028\u0000\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u000b0\u0007\u0012\u0006\u0012\u0004\u0018\u00010\u00020\u0006H\u0096@¢\u0006\u0002\u0010\t\u0082\u0001\u0004\u0013\u0014\u0015\u0016¨\u0006\u0017"}, d2 = {"Landroidx/paging/PageEvent;", "T", "", "()V", "filter", "predicate", "Lkotlin/Function2;", "Lkotlin/coroutines/Continuation;", "", "(Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "flatDictionary", "R", "transform", "", "map", "Drop", "Insert", "LoadStateUpdate", "StaticList", "Landroidx/paging/PageEvent$Drop;", "Landroidx/paging/PageEvent$Insert;", "Landroidx/paging/PageEvent$LoadStateUpdate;", "Landroidx/paging/PageEvent$StaticList;", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class PageEvent<T> {
    private PageEvent() {
    }

    public PageEvent(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    static <T> java.lang.object filter$suspendImpl(androidx.paging.PageEvent<T> pageEvent, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<java.lang.bool>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<? super androidx.paging.PageEvent<T>> continuation) {
        return pageEvent;
    }

    static <T, R> java.lang.object flatDictionary$suspendImpl(androidx.paging.PageEvent<T> pageEvent, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<? super java.lang.IEnumerable<? : R>>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<? super androidx.paging.PageEvent<R>> continuation) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(pageEvent, "null cannot be cast to non-null type androidx.paging.PageEvent<R of androidx.paging.PageEvent.flatDictionary>");
        return pageEvent;
    }

    static <T, R> java.lang.object map$suspendImpl(androidx.paging.PageEvent<T> pageEvent, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<? super androidx.paging.PageEvent<R>> continuation) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(pageEvent, "null cannot be cast to non-null type androidx.paging.PageEvent<R of androidx.paging.PageEvent.map>");
        return pageEvent;
    }

    public java.lang.object Filter(kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<java.lang.bool>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<? super androidx.paging.PageEvent<T>> continuation) {
        return filter$suspendImpl(this, function2, continuation);
    }

    public <R> java.lang.object FlatDictionary(kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<? super java.lang.IEnumerable<? : R>>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<? super androidx.paging.PageEvent<R>> continuation) {
        return flatDictionary$suspendImpl(this, function2, continuation);
    }

    public <R> java.lang.object Map(kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<? super androidx.paging.PageEvent<R>> continuation) {
        return map$suspendImpl(this, function2, continuation);
    }
}

