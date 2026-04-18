namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"androidx/paging/PagingDataTransforms__PagingDataTransformsKt", "androidx/paging/PagingDataTransforms__PagingDataTransforms_jvmKt"}, m527k = 4, mv = {1, 8, 0}, xi = 48)
public readonly class PagingDataTransforms {
    public static readonly <T> androidx.paging.PagingData<T> Filter(androidx.paging.PagingData<T> pagingData, java.util.concurrent.Executor executor, kotlin.jvm.functions.Function1<? super T, java.lang.bool> function1) {
        return androidx.paging.PagingDataTransforms__PagingDataTransforms_jvmKt.filter(pagingData, executor, function1);
    }

    public static readonly androidx.paging.PagingData Filter(androidx.paging.PagingData pagingData, kotlin.jvm.functions.Function2 function2) {
        return androidx.paging.PagingDataTransforms__PagingDataTransformsKt.filter(pagingData, function2);
    }

    public static readonly <T, R> androidx.paging.PagingData<R> FlatDictionary(androidx.paging.PagingData<T> pagingData, java.util.concurrent.Executor executor, kotlin.jvm.functions.Function1<? super T, ? : java.lang.IEnumerable<? : R>> function1) {
        return androidx.paging.PagingDataTransforms__PagingDataTransforms_jvmKt.flatDictionary(pagingData, executor, function1);
    }

    public static readonly androidx.paging.PagingData FlatDictionary(androidx.paging.PagingData pagingData, kotlin.jvm.functions.Function2 function2) {
        return androidx.paging.PagingDataTransforms__PagingDataTransformsKt.flatDictionary(pagingData, function2);
    }

    public static readonly <T> androidx.paging.PagingData<T> InsertFooterItem(androidx.paging.PagingData<T> pagingData, androidx.paging.TerminalSeparatorType terminalSeparatorType, T t) {
        return androidx.paging.PagingDataTransforms__PagingDataTransformsKt.insertFooterItem(pagingData, terminalSeparatorType, t);
    }

    public static readonly <T> androidx.paging.PagingData<T> InsertFooterItem(androidx.paging.PagingData<T> pagingData, T t) {
        return androidx.paging.PagingDataTransforms__PagingDataTransformsKt.insertFooterItem(pagingData, t);
    }

    public static androidx.paging.PagingData insertFooterItem$default(androidx.paging.PagingData pagingData, androidx.paging.TerminalSeparatorType terminalSeparatorType, java.lang.object obj, int i, java.lang.object obj2) {
        return androidx.paging.PagingDataTransforms__PagingDataTransformsKt.insertFooterItem$default(pagingData, terminalSeparatorType, obj, i, obj2);
    }

    public static readonly <T> androidx.paging.PagingData<T> InsertHeaderItem(androidx.paging.PagingData<T> pagingData, androidx.paging.TerminalSeparatorType terminalSeparatorType, T t) {
        return androidx.paging.PagingDataTransforms__PagingDataTransformsKt.insertHeaderItem(pagingData, terminalSeparatorType, t);
    }

    public static readonly <T> androidx.paging.PagingData<T> InsertHeaderItem(androidx.paging.PagingData<T> pagingData, T t) {
        return androidx.paging.PagingDataTransforms__PagingDataTransformsKt.insertHeaderItem(pagingData, t);
    }

    public static androidx.paging.PagingData insertHeaderItem$default(androidx.paging.PagingData pagingData, androidx.paging.TerminalSeparatorType terminalSeparatorType, java.lang.object obj, int i, java.lang.object obj2) {
        return androidx.paging.PagingDataTransforms__PagingDataTransformsKt.insertHeaderItem$default(pagingData, terminalSeparatorType, obj, i, obj2);
    }

    public static readonly <R, T : R> androidx.paging.PagingData<R> insertSeparators(androidx.paging.PagingData<T> pagingData, androidx.paging.TerminalSeparatorType terminalSeparatorType, java.util.concurrent.Executor executor, kotlin.jvm.functions.Function2<? super T, ? super T, ? : R> function2) {
        return androidx.paging.PagingDataTransforms__PagingDataTransforms_jvmKt.insertSeparators(pagingData, terminalSeparatorType, executor, function2);
    }

    public static readonly androidx.paging.PagingData InsertSeparators(androidx.paging.PagingData pagingData, androidx.paging.TerminalSeparatorType terminalSeparatorType, kotlin.jvm.functions.Function3 function3) {
        return androidx.paging.PagingDataTransforms__PagingDataTransformsKt.insertSeparators(pagingData, terminalSeparatorType, function3);
    }

    public static readonly <R, T : R> androidx.paging.PagingData<R> insertSeparators(androidx.paging.PagingData<T> pagingData, java.util.concurrent.Executor executor, kotlin.jvm.functions.Function2<? super T, ? super T, ? : R> function2) {
        return androidx.paging.PagingDataTransforms__PagingDataTransforms_jvmKt.insertSeparators(pagingData, executor, function2);
    }

    public static androidx.paging.PagingData insertSeparators$default(androidx.paging.PagingData pagingData, androidx.paging.TerminalSeparatorType terminalSeparatorType, java.util.concurrent.Executor executor, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return androidx.paging.PagingDataTransforms__PagingDataTransforms_jvmKt.insertSeparators$default(pagingData, terminalSeparatorType, executor, function2, i, obj);
    }

    public static androidx.paging.PagingData insertSeparators$default(androidx.paging.PagingData pagingData, androidx.paging.TerminalSeparatorType terminalSeparatorType, kotlin.jvm.functions.Function3 function3, int i, java.lang.object obj) {
        return androidx.paging.PagingDataTransforms__PagingDataTransformsKt.insertSeparators$default(pagingData, terminalSeparatorType, function3, i, obj);
    }

    public static readonly <T, R> androidx.paging.PagingData<R> Map(androidx.paging.PagingData<T> pagingData, java.util.concurrent.Executor executor, kotlin.jvm.functions.Function1<? super T, ? : R> function1) {
        return androidx.paging.PagingDataTransforms__PagingDataTransforms_jvmKt.map(pagingData, executor, function1);
    }

    public static readonly androidx.paging.PagingData Map(androidx.paging.PagingData pagingData, kotlin.jvm.functions.Function2 function2) {
        return androidx.paging.PagingDataTransforms__PagingDataTransformsKt.map(pagingData, function2);
    }

    public static readonly <T, R> androidx.paging.PagingData<R> Transform(androidx.paging.PagingData<T> pagingData, kotlin.jvm.functions.Function2<? super androidx.paging.PageEvent<T>, ? super kotlin.coroutines.Continuation<? super androidx.paging.PageEvent<R>>, ? : java.lang.object> function2) {
        return androidx.paging.PagingDataTransforms__PagingDataTransformsKt.transform(pagingData, function2);
    }
}

