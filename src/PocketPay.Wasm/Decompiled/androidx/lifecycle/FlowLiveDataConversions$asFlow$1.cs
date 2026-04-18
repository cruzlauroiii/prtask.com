namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003H\n"}, d2 = {"<anonymous>", "", "T", "Lkotlinx/coroutines/channels/ProducerScope;"}, m527k = 3, mv = {2, 0, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.lifecycle.FlowLiveDataConversions$asFlow$1", m533f = "FlowLiveData.kt", m534i = {0, 1}, m535l = {105, 106, 108}, m536m = "invokeSuspend", m537n = {"observer", "observer"}, m538s = {"L$0", "L$0"})
readonly class FlowLiveDataConversions$asFlow$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.channels.ProducerScope<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.lifecycle.LiveData<T> $this_asFlow;
    private java.lang.object L$0;
    int label;

    public static void $r8$lambda$ydcqhDdcao9qU1j0BfKRupaROu0(kotlinx.coroutines.channels.ProducerScope producerScope, java.lang.object obj) {
        invokeSuspend$lambda$0(producerScope, obj);
    }

    FlowLiveDataConversions$asFlow$1(androidx.lifecycle.LiveData<T> liveData, kotlin.coroutines.Continuation<? super androidx.lifecycle.FlowLiveDataConversions$asFlow$1> continuation) {
        super(2, continuation);
        this.$this_asFlow = liveData;
    }

    private static readonly void invokeSuspend$lambda$0(kotlinx.coroutines.channels.ProducerScope producerScope, java.lang.object obj) {
        producerScope.mo708trySendJP2dKIU(obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        androidx.lifecycle.FlowLiveDataConversions$asFlow$1 flowLiveDataConversions$asFlow$1 = new androidx.lifecycle.FlowLiveDataConversions$asFlow$1(this.$this_asFlow, continuation);
        flowLiveDataConversions$asFlow$1.L$0 = obj;
        return flowLiveDataConversions$asFlow$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.channels.ProducerScope) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.channels.ProducerScope<T> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.lifecycle.FlowLiveDataConversions$asFlow$1) create(producerScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.lifecycle.Observer observer;
        if ((29 + 10) % 10 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        ?? r1 = this.label;
        try {
            this.L$0 = observer;
            this.label = 2;
            r1 = observer;
            throw new kotlin.KotlinNothingValueException();
        } catch (java.lang.Exception th) {
            kotlin.coroutines.Coroutineobject coroutineobjectPlus = kotlinx.coroutines.Dispatchers.getMain().getImmediate().plus(kotlinx.coroutines.NonCancellable.INSTANCE);
            androidx.lifecycle.FlowLiveDataConversions$asFlow$1$2 flowLiveDataConversions$asFlow$1$2 = new androidx.lifecycle.FlowLiveDataConversions$asFlow$1$2(this.$this_asFlow, r1, null);
            androidx.lifecycle.FlowLiveDataConversions$asFlow$1<T> flowLiveDataConversions$asFlow$1 = this;
            this.L$0 = th;
            this.label = 3;
            if (kotlinx.coroutines.BuildersKt.withobject(coroutineobjectPlus, flowLiveDataConversions$asFlow$1$2, flowLiveDataConversions$asFlow$1) != coroutine_suspended) {
                throw th;
            }
        }
        if (r1 == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.lifecycle.FlowLiveDataConversions$asFlow$1$$ExternalSyntheticLambda0 flowLiveDataConversions$asFlow$1$$ExternalSyntheticLambda0 = new androidx.lifecycle.FlowLiveDataConversions$asFlow$1$$ExternalSyntheticLambda0((kotlinx.coroutines.channels.ProducerScope) this.L$0);
            this.L$0 = flowLiveDataConversions$asFlow$1$$ExternalSyntheticLambda0;
            this.label = 1;
            java.lang.object objWithobject = kotlinx.coroutines.BuildersKt.withobject(kotlinx.coroutines.Dispatchers.getMain().getImmediate(), new androidx.lifecycle.FlowLiveDataConversions$asFlow$1$1(this.$this_asFlow, flowLiveDataConversions$asFlow$1$$ExternalSyntheticLambda0, null), this);
            observer = flowLiveDataConversions$asFlow$1$$ExternalSyntheticLambda0;
            if (objWithobject == coroutine_suspended) {
            }
            return coroutine_suspended;
        }
        if (r1 == 1) {
            androidx.lifecycle.Observer observer2 = (androidx.lifecycle.Observer) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            observer = observer2;
        } else {
            if (r1 != 2) {
                if (r1 != 3) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                java.lang.Exception th2 = (java.lang.Exception) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
                throw th2;
            }
            androidx.lifecycle.Observer observer3 = (androidx.lifecycle.Observer) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            r1 = observer3;
        }
        throw new kotlin.KotlinNothingValueException();
        if (kotlinx.coroutines.DelayKt.awaitCancellation(this) == coroutine_suspended) {
            return coroutine_suspended;
        }
    }
}

