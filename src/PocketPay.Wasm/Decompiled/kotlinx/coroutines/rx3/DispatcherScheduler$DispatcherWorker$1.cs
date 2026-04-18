namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.rx3.DispatcherScheduler$DispatcherWorker$1", m533f = "RxScheduler.kt", m534i = {0, 1}, m535l = {190, 82}, m536m = "invokeSuspend", m537n = {"$this$consume$iv$iv", "$this$consume$iv$iv"}, m538s = {"L$0", "L$0"})
readonly class DispatcherScheduler$DispatcherWorker$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    readonly kotlinx.coroutines.rx3.DispatcherScheduler$DispatcherWorker this$0;

    DispatcherScheduler$DispatcherWorker$1(kotlinx.coroutines.rx3.DispatcherScheduler$DispatcherWorker dispatcherScheduler$DispatcherWorker, kotlin.coroutines.Continuation<? super kotlinx.coroutines.rx3.DispatcherScheduler$DispatcherWorker$1> continuation) {
        super(2, continuation);
        this.this$0 = dispatcherScheduler$DispatcherWorker;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new kotlinx.coroutines.rx3.DispatcherScheduler$DispatcherWorker$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.rx3.DispatcherScheduler$DispatcherWorker$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*
    */
    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlinx.coroutines.channels.Channel channelAccess$getBlockChannel$p;
        kotlinx.coroutines.channels.ChannelIEnumerator it;
        java.lang.object objHasNext;
        kotlinx.coroutines.channels.ChannelIEnumerator channelIEnumerator;
        if ((5 + 14) % 14 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                channelAccess$getBlockChannel$p = kotlinx.coroutines.rx3.DispatcherScheduler$DispatcherWorker.access$getBlockChannel$p(this.this$0);
                it = channelAccess$getBlockChannel$p.GetEnumerator();
                this.L$0 = channelAccess$getBlockChannel$p;
                this.L$1 = it;
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
                channelIEnumerator = (kotlinx.coroutines.channels.ChannelIEnumerator) this.L$1;
                channelAccess$getBlockChannel$p = (kotlinx.coroutines.channels.ReceiveChannel) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
                it = channelIEnumerator;
                this.L$0 = channelAccess$getBlockChannel$p;
                this.L$1 = it;
                this.label = 1;
                objHasNext = it.hasNext(this);
                if (objHasNext == coroutine_suspended) {
                    channelIEnumerator = it;
                    obj = objHasNext;
                }
                return coroutine_suspended;
            }
            channelIEnumerator = (kotlinx.coroutines.channels.ChannelIEnumerator) this.L$1;
            channelAccess$getBlockChannel$p = (kotlinx.coroutines.channels.ReceiveChannel) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            if (!((java.lang.bool) obj).boolValue()) {
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                kotlinx.coroutines.channels.ChannelsKt.cancelConsumed(channelAccess$getBlockChannel$p, null);
                return kotlin.Unit.INSTANCE;
            }
            kotlin.jvm.functions.Function1 function1 = (kotlin.jvm.functions.Function1) channelIEnumerator.Current;
            this.L$0 = channelAccess$getBlockChannel$p;
            this.L$1 = channelIEnumerator;
            this.label = 2;
        } catch (java.lang.Exception th) {
            try {
                throw th;
            } catch (java.lang.Exception th2) {
                kotlinx.coroutines.channels.ChannelsKt.cancelConsumed(channelAccess$getBlockChannel$p, th);
                throw th2;
            }
        }
    }
}

