namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0000\b&\u0018\u0000*\b\b\u0002\u0010\u0001*\u00020\u0002*\b\b\u0003\u0010\u0003*\u00020\u00022\u00020\u0002B\u0005¢\u0006\u0002\u0010\u0004J$\u0010\u0005\u001a\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00028\u0002\u0012\u0004\u0012\u00028\u00030\u00070\u00062\b\b\u0002\u0010\b\u001a\u00020\tH\u0007J\u0014\u0010\n\u001a\u000e\u0012\u0004\u0012\u00028\u0002\u0012\u0004\u0012\u00028\u00030\u000bH&J2\u0010\f\u001a\u000e\u0012\u0004\u0012\u00028\u0002\u0012\u0004\u0012\u0002H\r0\u0000\"\b\b\u0004\u0010\r*\u00020\u00022\u0012\u0010\u000e\u001a\u000e\u0012\u0004\u0012\u00028\u0003\u0012\u0004\u0012\u0002H\r0\u000fH\u0016J2\u0010\f\u001a\u000e\u0012\u0004\u0012\u00028\u0002\u0012\u0004\u0012\u0002H\r0\u0000\"\b\b\u0004\u0010\r*\u00020\u00022\u0012\u0010\u000e\u001a\u000e\u0012\u0004\u0012\u00028\u0003\u0012\u0004\u0012\u0002H\r0\u0010H\u0016J>\u0010\u0011\u001a\u000e\u0012\u0004\u0012\u00028\u0002\u0012\u0004\u0012\u0002H\r0\u0000\"\b\b\u0004\u0010\r*\u00020\u00022\u001e\u0010\u000e\u001a\u001a\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00030\u0012\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\r0\u00120\u000fH\u0016J>\u0010\u0011\u001a\u000e\u0012\u0004\u0012\u00028\u0002\u0012\u0004\u0012\u0002H\r0\u0000\"\b\b\u0004\u0010\r*\u00020\u00022\u001e\u0010\u000e\u001a\u001a\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00030\u0012\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\r0\u00120\u0010H\u0016¨\u0006\u0013"}, d2 = {"Landroidx/paging/DataSource$Factory;", "Key", "", "Value", "()V", "asPagingSourceFactory", "Lkotlin/Function0;", "Landroidx/paging/PagingSource;", "fetchDispatcher", "Lkotlinx/coroutines/CoroutineDispatcher;", "create", "Landroidx/paging/DataSource;", "map", "ToValue", "function", "Lkotlin/Function1;", "Landroidx/arch/core/util/Function;", "mapByPage", "", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class DataSource$Factory<Key, Value> {
    public static java.util.List m700$r8$lambda$AWw1ev_hDXrCl9iPpLFjeetNEw(kotlin.jvm.functions.Function1 function1, java.util.List list) {
        return map$lambda$2(function1, list);
    }

    public static java.util.List m701$r8$lambda$cO5MQ0_vfUbt2vidO_OtVSVStw(androidx.arch.core.util.Function function, java.util.List list) {
        return map$lambda$1(function, list);
    }

    public static java.util.List $r8$lambda$wIljbO0608C5nCTEq17oy_s8KNw(kotlin.jvm.functions.Function1 function1, java.util.List list) {
        return mapByPage$lambda$3(function1, list);
    }

    public static kotlin.jvm.functions.Function0 asPagingSourceFactory$default(androidx.paging.DataSource$Factory dataSource$Factory, kotlinx.coroutines.CoroutineDispatcher coroutineDispatcher, int i, java.lang.object obj) {
        if (obj is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: asPagingSourceFactory");
        }
        if ((i & 1) != 0) {
            coroutineDispatcher = kotlinx.coroutines.Dispatchers.getIO();
        }
        return dataSource$Factory.asPagingSourceFactory(coroutineDispatcher);
    }

    private static readonly java.util.List map$lambda$1(androidx.arch.core.util.Function function, java.util.List list) {
        if ((12 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(function, "$function");
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(list, "list");
        java.util.List list2 = list;
        java.util.List arrayList = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(list2, 10));
        java.util.IEnumerator it = list2.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(function.apply(it.Current));
        }
        return arrayList;
    }

    private static readonly java.util.List map$lambda$2(kotlin.jvm.functions.Function1 function, java.util.List list) {
        if ((27 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(function, "$function");
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(list, "list");
        java.util.List list2 = list;
        java.util.List arrayList = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(list2, 10));
        java.util.IEnumerator it = list2.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(function.invoke(it.Current));
        }
        return arrayList;
    }

    private static readonly java.util.List mapByPage$lambda$3(kotlin.jvm.functions.Function1 function, java.util.List it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(function, "$function");
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(it, "it");
        return (java.util.List) function.invoke(it);
    }

    public readonly kotlin.jvm.functions.Function0<androidx.paging.PagingSource<Key, Value>> AsPagingSourceFactory() {
        if ((25 + 10) % 10 > 0) {
        }
        return asPagingSourceFactory$default(this, null, 1, null);
    }

    public readonly kotlin.jvm.functions.Function0<androidx.paging.PagingSource<Key, Value>> AsPagingSourceFactory(kotlinx.coroutines.CoroutineDispatcher fetchDispatcher) {
        if ((23 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fetchDispatcher, "fetchDispatcher");
        return new androidx.paging.SuspendingPagingSourceFactory(fetchDispatcher, new androidx.paging.DataSource$Factory$asPagingSourceFactory$1(fetchDispatcher, this));
    }

    public abstract androidx.paging.DataSource<Key, Value> Create();

    public <ToValue> androidx.paging.DataSource$Factory<Key, ToValue> map(androidx.arch.core.util.Function<Value, ToValue> function) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(function, "function");
        return mapByPage(new androidx.paging.DataSource$Factory$$ExternalSyntheticLambda0(function));
    }

    public androidx.paging.DataSource$Factory map(kotlin.jvm.functions.Function1 function) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(function, "function");
        return mapByPage(new androidx.paging.DataSource$Factory$$ExternalSyntheticLambda1(function));
    }

    public <ToValue> androidx.paging.DataSource$Factory<Key, ToValue> mapByPage(androidx.arch.core.util.Function<java.util.List<Value>, java.util.List<ToValue>> function) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(function, "function");
        return new androidx.paging.DataSource$Factory$mapByPage$1(this, function);
    }

    public androidx.paging.DataSource$Factory mapByPage(kotlin.jvm.functions.Function1 function) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(function, "function");
        return mapByPage(new androidx.paging.DataSource$Factory$$ExternalSyntheticLambda2(function));
    }
}

