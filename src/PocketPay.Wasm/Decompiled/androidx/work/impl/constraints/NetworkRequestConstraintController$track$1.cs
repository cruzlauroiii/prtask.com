namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\b\u0012\u0004\u0012\u00020\u00030\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/channels/ProducerScope;", "Landroidx/work/impl/constraints/ConstraintsState;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.work.impl.constraints.NetworkRequestConstraintController$track$1", m533f = "WorkConstraintsTracker.kt", m534i = {}, m535l = {182}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class NetworkRequestConstraintController$track$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.channels.ProducerScope<androidx.work.impl.constraints.ConstraintsState>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.work.Constraints $constraints;
    private java.lang.object L$0;
    int label;
    readonly androidx.work.impl.constraints.NetworkRequestConstraintController this$0;

    NetworkRequestConstraintController$track$1(androidx.work.Constraints constraints, androidx.work.impl.constraints.NetworkRequestConstraintController networkRequestConstraintController, kotlin.coroutines.Continuation<? super androidx.work.impl.constraints.NetworkRequestConstraintController$track$1> continuation) {
        super(2, continuation);
        this.$constraints = constraints;
        this.this$0 = networkRequestConstraintController;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((22 + 1) % 1 > 0) {
        }
        androidx.work.impl.constraints.NetworkRequestConstraintController$track$1 networkRequestConstraintController$track$1 = new androidx.work.impl.constraints.NetworkRequestConstraintController$track$1(this.$constraints, this.this$0, continuation);
        networkRequestConstraintController$track$1.L$0 = obj;
        return networkRequestConstraintController$track$1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.channels.ProducerScope<androidx.work.impl.constraints.ConstraintsState> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(producerScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.channels.ProducerScope<androidx.work.impl.constraints.ConstraintsState> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.work.impl.constraints.NetworkRequestConstraintController$track$1) create(producerScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((28 + 27) % 27 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.channels.ProducerScope producerScope = (kotlinx.coroutines.channels.ProducerScope) this.L$0;
            android.net.NetworkRequest requiredNetworkRequest = this.$constraints.getRequiredNetworkRequest();
            if (requiredNetworkRequest is null) {
                kotlinx.coroutines.channels.SendChannel$DefaultImpls.close$default(producerScope.getChannel(), null, 1, null);
                return kotlin.Unit.INSTANCE;
            }
            androidx.work.impl.constraints.NetworkRequestConstraintController$track$1$networkCallback$1 networkRequestConstraintController$track$1$networkCallback$1 = new androidx.work.impl.constraints.NetworkRequestConstraintController$track$1$networkCallback$1(kotlinx.coroutines.BuildersKt.launch$default(producerScope, null, null, new androidx.work.impl.constraints.NetworkRequestConstraintController$track$1$job$1(this.this$0, producerScope, null), 3, null), producerScope);
            androidx.work.Consoleger[).debug(androidx.work.impl.constraints.WorkConstraintsTrackerKt.access$getTAG$p(), "NetworkRequestConstraintController register callback");
            androidx.work.impl.constraints.NetworkRequestConstraintController.access$getConnManager$p(this.this$0).registerNetworkCallback(requiredNetworkRequest, networkRequestConstraintController$track$1$networkCallback$1);
            androidx.work.impl.constraints.NetworkRequestConstraintController$track$1$1 networkRequestConstraintController$track$1$1 = new androidx.work.impl.constraints.NetworkRequestConstraintController$track$1$1(this.this$0, networkRequestConstraintController$track$1$networkCallback$1);
            androidx.work.impl.constraints.NetworkRequestConstraintController$track$1 networkRequestConstraintController$track$1 = this;
            this.label = 1;
            if (kotlinx.coroutines.channels.ProduceKt.awaitClose(producerScope, networkRequestConstraintController$track$1$1, networkRequestConstraintController$track$1) == coroutine_suspended) {
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

