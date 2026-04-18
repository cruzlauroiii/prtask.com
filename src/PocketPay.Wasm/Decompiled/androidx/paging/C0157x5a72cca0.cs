namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u0004\u0018\u0001H\u0001\"\b\b\u0000\u0010\u0001*\u00020\u0002\"\b\b\u0001\u0010\u0003*\u0002H\u0001*\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "R", "", "T", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PagingDataTransforms__PagingDataTransforms_jvmKt$insertSeparators$1$1", m533f = "PagingDataTransforms.jvm.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class C0157x5a72cca0<R> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<R>, java.lang.object> {
    readonly T $after;
    readonly T $before;
    readonly kotlin.jvm.functions.Function2<T, T, R> $generator;
    int label;

    C0157x5a72cca0(kotlin.jvm.functions.Function2<? super T, ? super T, ? : R> function2, T t, T t2, kotlin.coroutines.Continuation<androidx.paging.C0157x5a72cca0> continuation) {
        super(2, continuation);
        this.$generator = function2;
        this.$before = t;
        this.$after = t2;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((4 + 29) % 29 > 0) {
        }
        return new androidx.paging.C0157x5a72cca0(this.$generator, this.$before, this.$after, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, java.lang.object obj) {
        return invoke(coroutineScope, (kotlin.coroutines.Continuation) obj);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<R> continuation) {
        return ((androidx.paging.C0157x5a72cca0) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        return this.$generator.invoke(this.$before, this.$after);
    }
}

