namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class SelectBuilder$DefaultImpls {
    public static <R, P, Q> void Invoke(kotlinx.coroutines.selects.SelectBuilder<R> selectBuilder, kotlinx.coroutines.selects.SelectClause2<? super P, ? : Q> selectClause2, kotlin.jvm.functions.Function2<? super Q, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function2) {
        selectBuilder.invoke(selectClause2, null, function2);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Replaced with the same extension function", replaceWith = @kotlin.ReplaceWith(expression = "onTimeout", imports = {"kotlinx.coroutines.selects.onTimeout"}))
    public static <R> void OnTimeout(kotlinx.coroutines.selects.SelectBuilder<R> selectBuilder, long j, kotlin.jvm.functions.Function1<? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function1) {
        kotlinx.coroutines.selects.OnTimeoutKt.onTimeout(selectBuilder, j, function1);
    }
}

