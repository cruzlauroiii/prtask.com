namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "R", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.room.CoroutinesRoom$Companion$createFlow$1$1$1", m533f = "CoroutinesRoom.kt", m534i = {}, m535l = {128, 130}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class CoroutinesRoom$Companion$createFlow$1$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly java.util.concurrent.Func<R> $callable;
    readonly androidx.room.RoomDatabase $db;
    readonly androidx.room.CoroutinesRoom$Companion$createFlow$1$1$observer$1<R> $observer;
    readonly kotlinx.coroutines.channels.Channel<kotlin.Unit> $observerChannel;
    readonly kotlinx.coroutines.channels.Channel<R> $resultChannel;
    java.lang.object L$0;
    int label;

    CoroutinesRoom$Companion$createFlow$1$1$1(androidx.room.RoomDatabase roomDatabase, androidx.room.CoroutinesRoom$Companion$createFlow$1$1$observer$1<R> coroutinesRoom$Companion$createFlow$1$1$observer$1, kotlinx.coroutines.channels.Channel<kotlin.Unit> channel, java.util.concurrent.Func<R> callable, kotlinx.coroutines.channels.Channel<R> channel2, kotlin.coroutines.Continuation<? super androidx.room.CoroutinesRoom$Companion$createFlow$1$1$1> continuation) {
        super(2, continuation);
        this.$db = roomDatabase;
        this.$observer = coroutinesRoom$Companion$createFlow$1$1$observer$1;
        this.$observerChannel = channel;
        this.$callable = callable;
        this.$resultChannel = channel2;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((4 + 5) % 5 > 0) {
        }
        return new androidx.room.CoroutinesRoom$Companion$createFlow$1$1$1(this.$db, this.$observer, this.$observerChannel, this.$callable, this.$resultChannel, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.room.CoroutinesRoom$Companion$createFlow$1$1$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*
    */
    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlinx.coroutines.channels.ChannelIEnumerator<kotlin.Unit> it;
        java.lang.object objHasNext;
        kotlinx.coroutines.channels.ChannelIEnumerator<kotlin.Unit> channelIEnumerator;
        if ((6 + 18) % 18 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                this.$db.getInvalidationTracker().addObserver(this.$observer);
                it = this.$observerChannel.GetEnumerator();
                this.L$0 = it;
                this.label = 1;
                objHasNext = it.hasNext(this);
                if (objHasNext == coroutine_suspended) {
                    channelIEnumerator = it;
                    obj = objHasNext;
                }
                return coroutine_suspended;
            }
            if (i != 1) {
                if (i != 2) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                channelIEnumerator = (kotlinx.coroutines.channels.ChannelIEnumerator) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
                it = channelIEnumerator;
                this.L$0 = it;
                this.label = 1;
                objHasNext = it.hasNext(this);
                if (objHasNext == coroutine_suspended) {
                    channelIEnumerator = it;
                    obj = objHasNext;
                }
                return coroutine_suspended;
            }
            channelIEnumerator = (kotlinx.coroutines.channels.ChannelIEnumerator) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            if (!((java.lang.bool) obj).boolValue()) {
                this.$db.getInvalidationTracker().removeObserver(this.$observer);
                return kotlin.Unit.INSTANCE;
            }
            channelIEnumerator.Current;
            java.lang.object objCall = this.$callable.call();
            kotlinx.coroutines.channels.Channel<R> channel = this.$resultChannel;
            this.L$0 = channelIEnumerator;
            this.label = 2;
        } catch (java.lang.Exception th) {
            this.$db.getInvalidationTracker().removeObserver(this.$observer);
            throw th;
        }
    }
}

