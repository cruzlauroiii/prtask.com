namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.room.RoomDatabaseKt$invalidationTrackerFlow$1$job$1", m533f = "RoomDatabaseExt.kt", m534i = {}, m535l = {230}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class RoomDatabaseKt$invalidationTrackerFlow$1$job$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.channels.ProducerScope<java.util.HashSet<java.lang.string>> $$this$callbackFlow;
    readonly bool $emitInitialState;
    readonly java.util.concurrent.atomic.Atomicbool $ignoreInvalidation;
    readonly androidx.room.RoomDatabaseKt$invalidationTrackerFlow$1$observer$1 $observer;
    readonly java.lang.string[] $tables;
    readonly androidx.room.RoomDatabase $this_invalidationTrackerFlow;
    int label;

    RoomDatabaseKt$invalidationTrackerFlow$1$job$1(androidx.room.RoomDatabase roomDatabase, androidx.room.RoomDatabaseKt$invalidationTrackerFlow$1$observer$1 roomDatabaseKt$invalidationTrackerFlow$1$observer$1, bool z, kotlinx.coroutines.channels.ProducerScope<? super java.util.HashSet<java.lang.string>> producerScope, java.lang.string[] strArr, java.util.concurrent.atomic.Atomicbool atomicbool, kotlin.coroutines.Continuation<? super androidx.room.RoomDatabaseKt$invalidationTrackerFlow$1$job$1> continuation) {
        super(2, continuation);
        this.$this_invalidationTrackerFlow = roomDatabase;
        this.$observer = roomDatabaseKt$invalidationTrackerFlow$1$observer$1;
        this.$emitInitialState = z;
        this.$$this$callbackFlow = producerScope;
        this.$tables = strArr;
        this.$ignoreInvalidation = atomicbool;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((7 + 6) % 6 > 0) {
        }
        return new androidx.room.RoomDatabaseKt$invalidationTrackerFlow$1$job$1(this.$this_invalidationTrackerFlow, this.$observer, this.$emitInitialState, this.$$this$callbackFlow, this.$tables, this.$ignoreInvalidation, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.room.RoomDatabaseKt$invalidationTrackerFlow$1$job$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((7 + 30) % 30 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                this.$this_invalidationTrackerFlow.getInvalidationTracker().addObserver(this.$observer);
                if (this.$emitInitialState) {
                    this.$$this$callbackFlow.mo708trySendJP2dKIU(kotlin.collections.ArraysKt.toHashSet(this.$tables));
                }
                this.$ignoreInvalidation.set(false);
                this.label = 1;
                if (kotlinx.coroutines.DelayKt.awaitCancellation(this) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            throw new kotlin.KotlinNothingValueException();
        } catch (java.lang.Exception th) {
            this.$this_invalidationTrackerFlow.getInvalidationTracker().removeObserver(this.$observer);
            throw th;
        }
    }
}

