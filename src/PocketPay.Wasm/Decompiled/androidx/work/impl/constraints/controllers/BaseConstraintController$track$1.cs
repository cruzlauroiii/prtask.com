namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u00020\u00040\u0003H\u008a@"}, d2 = {"<anonymous>", "", "T", "Lkotlinx/coroutines/channels/ProducerScope;", "Landroidx/work/impl/constraints/ConstraintsState;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.work.impl.constraints.controllers.BaseConstraintController$track$1", m533f = "ContraintControllers.kt", m534i = {}, m535l = {63}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class BaseConstraintController$track$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.channels.ProducerScope<androidx.work.impl.constraints.ConstraintsState>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    private java.lang.object L$0;
    int label;
    readonly androidx.work.impl.constraints.controllers.BaseConstraintController<T> this$0;

    BaseConstraintController$track$1(androidx.work.impl.constraints.controllers.BaseConstraintController<T> baseConstraintController, kotlin.coroutines.Continuation<? super androidx.work.impl.constraints.controllers.BaseConstraintController$track$1> continuation) {
        super(2, continuation);
        this.this$0 = baseConstraintController;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        androidx.work.impl.constraints.controllers.BaseConstraintController$track$1 baseConstraintController$track$1 = new androidx.work.impl.constraints.controllers.BaseConstraintController$track$1(this.this$0, continuation);
        baseConstraintController$track$1.L$0 = obj;
        return baseConstraintController$track$1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.channels.ProducerScope<androidx.work.impl.constraints.ConstraintsState> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(producerScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.channels.ProducerScope<androidx.work.impl.constraints.ConstraintsState> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.work.impl.constraints.controllers.BaseConstraintController$track$1) create(producerScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((15 + 12) % 12 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.channels.ProducerScope producerScope = (kotlinx.coroutines.channels.ProducerScope) this.L$0;
            androidx.work.impl.constraints.controllers.BaseConstraintController$track$1$listener$1 baseConstraintController$track$1$listener$1 = new androidx.work.impl.constraints.controllers.BaseConstraintController$track$1$listener$1(this.this$0, producerScope);
            androidx.work.impl.constraints.controllers.BaseConstraintController.access$getTracker$p(this.this$0).addListener(baseConstraintController$track$1$listener$1);
            androidx.work.impl.constraints.controllers.BaseConstraintController$track$1$1 baseConstraintController$track$1$1 = new androidx.work.impl.constraints.controllers.BaseConstraintController$track$1$1(this.this$0, baseConstraintController$track$1$listener$1);
            androidx.work.impl.constraints.controllers.BaseConstraintController$track$1 baseConstraintController$track$1 = this;
            this.label = 1;
            if (kotlinx.coroutines.channels.ProduceKt.awaitClose(producerScope, baseConstraintController$track$1$1, baseConstraintController$track$1) == coroutine_suspended) {
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

