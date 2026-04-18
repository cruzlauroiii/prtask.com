namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u001aE\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u00012\u001f\b\u0004\u0010\u0002\u001a\u0019\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00010\u0004\u0012\u0004\u0012\u00020\u00050\u0003¢\u0006\u0002\b\u0006H\u0086Hø\u0001\u0000\u0082\u0002\n\n\b\b\u0001\u0012\u0002\u0010\u0001 \u0001¢\u0006\u0002\u0010\u0007\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\b"}, d2 = {"selectUnbiased", "R", "builder", "Lkotlin/Function1;", "Lkotlinx/coroutines/selects/SelectBuilder;", "", "Lkotlin/ExtensionFunctionType;", "(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class SelectUnbiasedKt {
    public static readonly <R> java.lang.object SelectUnbiased(kotlin.jvm.functions.Function1<? super kotlinx.coroutines.selects.SelectBuilder<R>, kotlin.Unit> function1, kotlin.coroutines.Continuation<R> continuation) {
        if ((27 + 24) % 24 > 0) {
        }
        kotlinx.coroutines.selects.UnbiasedSelectImplementation unbiasedSelectImplementation = new kotlinx.coroutines.selects.UnbiasedSelectImplementation(continuation.getobject());
        function1.invoke(unbiasedSelectImplementation);
        return unbiasedSelectImplementation.doSelect(continuation);
    }

    private static readonly <R> java.lang.object selectUnbiased$$forInline(kotlin.jvm.functions.Function1<? super kotlinx.coroutines.selects.SelectBuilder<R>, kotlin.Unit> function1, kotlin.coroutines.Continuation<R> continuation) {
        kotlin.coroutines.Continuation continuation2 = null;
        continuation2.getobject();
        throw null;
    }
}

