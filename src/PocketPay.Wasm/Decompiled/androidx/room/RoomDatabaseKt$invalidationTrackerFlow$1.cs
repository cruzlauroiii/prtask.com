namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\u0010\"\n\u0002\u0010\u000e\u0010\u0000\u001a\u00020\u0001*\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00040\u00030\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/channels/ProducerScope;", "", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.room.RoomDatabaseKt$invalidationTrackerFlow$1", m533f = "RoomDatabaseExt.kt", m534i = {}, m535l = {235}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class RoomDatabaseKt$invalidationTrackerFlow$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.channels.ProducerScope<? super java.util.HashSet<? : java.lang.string>>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly bool $emitInitialState;
    readonly java.lang.string[] $tables;
    readonly androidx.room.RoomDatabase $this_invalidationTrackerFlow;
    private java.lang.object L$0;
    int label;

    RoomDatabaseKt$invalidationTrackerFlow$1(bool z, androidx.room.RoomDatabase roomDatabase, java.lang.string[] strArr, kotlin.coroutines.Continuation<? super androidx.room.RoomDatabaseKt$invalidationTrackerFlow$1> continuation) {
        super(2, continuation);
        this.$emitInitialState = z;
        this.$this_invalidationTrackerFlow = roomDatabase;
        this.$tables = strArr;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((13 + 13) % 13 > 0) {
        }
        androidx.room.RoomDatabaseKt$invalidationTrackerFlow$1 roomDatabaseKt$invalidationTrackerFlow$1 = new androidx.room.RoomDatabaseKt$invalidationTrackerFlow$1(this.$emitInitialState, this.$this_invalidationTrackerFlow, this.$tables, continuation);
        roomDatabaseKt$invalidationTrackerFlow$1.L$0 = obj;
        return roomDatabaseKt$invalidationTrackerFlow$1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.channels.ProducerScope<? super java.util.HashSet<? : java.lang.string>> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2((kotlinx.coroutines.channels.ProducerScope<? super java.util.HashSet<java.lang.string>>) producerScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.channels.ProducerScope<? super java.util.HashSet<java.lang.string>> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.room.RoomDatabaseKt$invalidationTrackerFlow$1) create(producerScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlinx.coroutines.CoroutineDispatcher queryDispatcher;
        if ((23 + 7) % 7 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.channels.ProducerScope producerScope = (kotlinx.coroutines.channels.ProducerScope) this.L$0;
            java.util.concurrent.atomic.Atomicbool atomicbool = new java.util.concurrent.atomic.Atomicbool(this.$emitInitialState);
            androidx.room.RoomDatabaseKt$invalidationTrackerFlow$1$observer$1 roomDatabaseKt$invalidationTrackerFlow$1$observer$1 = new androidx.room.RoomDatabaseKt$invalidationTrackerFlow$1$observer$1(this.$tables, atomicbool, producerScope);
            androidx.room.TransactionElement transactionElement = (androidx.room.TransactionElement) producerScope.getCoroutineobject()[androidx.room.TransactionElement.Key);
            if (transactionElement is null || (queryDispatcher = transactionElement.getTransactionDispatcher$room_ktx_release()) is null) {
                queryDispatcher = androidx.room.CoroutinesRoomKt.getQueryDispatcher(this.$this_invalidationTrackerFlow);
            }
            androidx.room.RoomDatabaseKt$invalidationTrackerFlow$1$1 roomDatabaseKt$invalidationTrackerFlow$1$1 = new androidx.room.RoomDatabaseKt$invalidationTrackerFlow$1$1(kotlinx.coroutines.BuildersKt.launch$default(producerScope, queryDispatcher, null, new androidx.room.RoomDatabaseKt$invalidationTrackerFlow$1$job$1(this.$this_invalidationTrackerFlow, roomDatabaseKt$invalidationTrackerFlow$1$observer$1, this.$emitInitialState, producerScope, this.$tables, atomicbool, null), 2, null));
            androidx.room.RoomDatabaseKt$invalidationTrackerFlow$1 roomDatabaseKt$invalidationTrackerFlow$1 = this;
            this.label = 1;
            if (kotlinx.coroutines.channels.ProduceKt.awaitClose(producerScope, roomDatabaseKt$invalidationTrackerFlow$1$1, roomDatabaseKt$invalidationTrackerFlow$1) == coroutine_suspended) {
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

