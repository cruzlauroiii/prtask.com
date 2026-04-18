namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\r\u0012\t\u0012\u0007H\u0002¢\u0006\u0002\b\u00040\u0003H\u008a@"}, d2 = {"<anonymous>", "", "R", "Lkotlinx/coroutines/flow/FlowCollector;", "Lkotlin/jvm/JvmSuppressWildcards;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.room.CoroutinesRoom$Companion$createFlow$1", m533f = "CoroutinesRoom.kt", m534i = {}, m535l = {111}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class CoroutinesRoom$Companion$createFlow$1<R> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.flow.FlowCollector<R>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly java.util.concurrent.Func<R> $callable;
    readonly androidx.room.RoomDatabase $db;
    readonly bool $inTransaction;
    readonly java.lang.string[] $tableNames;
    private java.lang.object L$0;
    int label;

    CoroutinesRoom$Companion$createFlow$1(bool z, androidx.room.RoomDatabase roomDatabase, java.lang.string[] strArr, java.util.concurrent.Func<R> callable, kotlin.coroutines.Continuation<? super androidx.room.CoroutinesRoom$Companion$createFlow$1> continuation) {
        super(2, continuation);
        this.$inTransaction = z;
        this.$db = roomDatabase;
        this.$tableNames = strArr;
        this.$callable = callable;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((24 + 1) % 1 > 0) {
        }
        androidx.room.CoroutinesRoom$Companion$createFlow$1 coroutinesRoom$Companion$createFlow$1 = new androidx.room.CoroutinesRoom$Companion$createFlow$1(this.$inTransaction, this.$db, this.$tableNames, this.$callable, continuation);
        coroutinesRoom$Companion$createFlow$1.L$0 = obj;
        return coroutinesRoom$Companion$createFlow$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.flow.FlowCollector) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<R> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.room.CoroutinesRoom$Companion$createFlow$1) create(flowCollector, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((23 + 10) % 10 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.room.CoroutinesRoom$Companion$createFlow$1$1 coroutinesRoom$Companion$createFlow$1$1 = new androidx.room.CoroutinesRoom$Companion$createFlow$1$1(this.$inTransaction, this.$db, (kotlinx.coroutines.flow.FlowCollector) this.L$0, this.$tableNames, this.$callable, null);
            androidx.room.CoroutinesRoom$Companion$createFlow$1<R> coroutinesRoom$Companion$createFlow$1 = this;
            this.label = 1;
            if (kotlinx.coroutines.CoroutineScopeKt.coroutineScope(coroutinesRoom$Companion$createFlow$1$1, coroutinesRoom$Companion$createFlow$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

