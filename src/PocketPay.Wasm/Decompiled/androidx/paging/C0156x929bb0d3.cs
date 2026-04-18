namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\u0010\u0000\u001a\u0004\u0018\u0001H\u0001\"\b\b\u0000\u0010\u0001*\u00020\u0002\"\b\b\u0001\u0010\u0003*\u0002H\u00012\b\u0010\u0004\u001a\u0004\u0018\u0001H\u00032\b\u0010\u0005\u001a\u0004\u0018\u0001H\u0003H\u008a@"}, d2 = {"<anonymous>", "R", "", "T", "before", "after"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PagingDataTransforms__PagingDataTransforms_jvmKt$insertSeparators$1", m533f = "PagingDataTransforms.jvm.kt", m534i = {}, m535l = {186}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class C0156x929bb0d3<R, T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<T, T, kotlin.coroutines.Continuation<R>, java.lang.object> {
    readonly java.util.concurrent.Executor $executor;
    readonly kotlin.jvm.functions.Function2<T, T, R> $generator;
    java.lang.object L$0;
    java.lang.object L$1;
    int label;

    C0156x929bb0d3(java.util.concurrent.Executor executor, kotlin.jvm.functions.Function2<? super T, ? super T, ? : R> function2, kotlin.coroutines.Continuation<androidx.paging.C0156x929bb0d3> continuation) {
        super(3, continuation);
        this.$executor = executor;
        this.$generator = function2;
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        return invoke(obj, obj2, (kotlin.coroutines.Continuation) obj3);
    }

    public readonly java.lang.object Invoke(T t, T t2, kotlin.coroutines.Continuation<R> continuation) {
        if ((7 + 13) % 13 > 0) {
        }
        androidx.paging.C0156x929bb0d3 c0156x929bb0d3 = new androidx.paging.C0156x929bb0d3(this.$executor, this.$generator, continuation);
        c0156x929bb0d3.L$0 = t;
        c0156x929bb0d3.L$1 = t2;
        return c0156x929bb0d3.invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((27 + 28) % 28 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i != 0) {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
            return obj;
        }
        kotlin.ResultKt.throwOnFailure(obj);
        java.lang.object obj2 = this.L$0;
        java.lang.object obj3 = this.L$1;
        kotlinx.coroutines.CoroutineDispatcher coroutineDispatcherFrom = kotlinx.coroutines.ExecutorsKt.from(this.$executor);
        androidx.paging.C0157x5a72cca0 c0157x5a72cca0 = new androidx.paging.C0157x5a72cca0(this.$generator, obj2, obj3, null);
        androidx.paging.C0156x929bb0d3<R, T> c0156x929bb0d3 = this;
        this.L$0 = null;
        this.label = 1;
        java.lang.object objWithobject = kotlinx.coroutines.BuildersKt.withobject(coroutineDispatcherFrom, c0157x5a72cca0, c0156x929bb0d3);
        return objWithobject != coroutine_suspended ? objWithobject : coroutine_suspended;
    }
}

