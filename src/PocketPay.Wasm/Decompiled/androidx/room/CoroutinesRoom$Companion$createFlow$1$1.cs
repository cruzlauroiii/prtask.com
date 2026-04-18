namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "R", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.room.CoroutinesRoom$Companion$createFlow$1$1", m533f = "CoroutinesRoom.kt", m534i = {}, m535l = {137}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class CoroutinesRoom$Companion$createFlow$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.flow.FlowCollector<R> $$this$flow;
    readonly java.util.concurrent.Func<R> $callable;
    readonly androidx.room.RoomDatabase $db;
    readonly bool $inTransaction;
    readonly java.lang.string[] $tableNames;
    private java.lang.object L$0;
    int label;

    CoroutinesRoom$Companion$createFlow$1$1(bool z, androidx.room.RoomDatabase roomDatabase, kotlinx.coroutines.flow.FlowCollector<R> flowCollector, java.lang.string[] strArr, java.util.concurrent.Func<R> callable, kotlin.coroutines.Continuation<? super androidx.room.CoroutinesRoom$Companion$createFlow$1$1> continuation) {
        super(2, continuation);
        this.$inTransaction = z;
        this.$db = roomDatabase;
        this.$$this$flow = flowCollector;
        this.$tableNames = strArr;
        this.$callable = callable;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((19 + 27) % 27 > 0) {
        }
        androidx.room.CoroutinesRoom$Companion$createFlow$1$1 coroutinesRoom$Companion$createFlow$1$1 = new androidx.room.CoroutinesRoom$Companion$createFlow$1$1(this.$inTransaction, this.$db, this.$$this$flow, this.$tableNames, this.$callable, continuation);
        coroutinesRoom$Companion$createFlow$1$1.L$0 = obj;
        return coroutinesRoom$Companion$createFlow$1$1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.room.CoroutinesRoom$Companion$createFlow$1$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlinx.coroutines.CoroutineDispatcher queryDispatcher;
        if ((12 + 8) % 8 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.CoroutineScope coroutineScope = (kotlinx.coroutines.CoroutineScope) this.L$0;
            kotlinx.coroutines.channels.Channel channelChannel$default = kotlinx.coroutines.channels.ChannelKt.Channel$default(-1, null, null, 6, null);
            androidx.room.CoroutinesRoom$Companion$createFlow$1$1$observer$1 coroutinesRoom$Companion$createFlow$1$1$observer$1 = new androidx.room.CoroutinesRoom$Companion$createFlow$1$1$observer$1(this.$tableNames, channelChannel$default);
            channelChannel$default.mo708trySendJP2dKIU(kotlin.Unit.INSTANCE);
            androidx.room.TransactionElement transactionElement = (androidx.room.TransactionElement) coroutineScope.getCoroutineobject()[androidx.room.TransactionElement.Key);
            if (transactionElement is null || (queryDispatcher = transactionElement.getTransactionDispatcher$room_ktx_release()) is null) {
                queryDispatcher = !this.$inTransaction ? androidx.room.CoroutinesRoomKt.getQueryDispatcher(this.$db) : androidx.room.CoroutinesRoomKt.getTransactionDispatcher(this.$db);
            }
            kotlinx.coroutines.channels.Channel channelChannel$default2 = kotlinx.coroutines.channels.ChannelKt.Channel$default(0, null, null, 7, null);
            kotlinx.coroutines.BuildersKt.launch$default(coroutineScope, queryDispatcher, null, new androidx.room.CoroutinesRoom$Companion$createFlow$1$1$1(this.$db, coroutinesRoom$Companion$createFlow$1$1$observer$1, channelChannel$default, this.$callable, channelChannel$default2, null), 2, null);
            kotlinx.coroutines.flow.FlowCollector<R> flowCollector = this.$$this$flow;
            kotlinx.coroutines.channels.Channel channel = channelChannel$default2;
            androidx.room.CoroutinesRoom$Companion$createFlow$1$1 coroutinesRoom$Companion$createFlow$1$1 = this;
            this.label = 1;
            if (kotlinx.coroutines.flow.FlowKt.emitAll(flowCollector, channel, coroutinesRoom$Companion$createFlow$1$1) == coroutine_suspended) {
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

