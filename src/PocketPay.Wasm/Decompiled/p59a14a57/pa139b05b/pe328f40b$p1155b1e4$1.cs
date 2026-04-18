namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "views.swipe.SwipeLayoutKt$animateSwipePreview$1", m533f = "SwipeLayout.kt", m534i = {1}, m535l = {200, 204}, m536m = "invokeSuspend", m537n = {"holder"}, m538s = {"L$1"})
readonly class pe328f40b$p1155b1e4$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlin.jvm.functions.Function0<kotlin.Unit> $onComplete;
    readonly androidx.recyclerview.widget.Recyclerobject $this_animateSwipePreview;
    readonly int $viewHolderPosition;
    java.lang.object L$0;
    java.lang.object L$1;
    int f3b6347d2;
    int f5b715443;
    int fd304ba20;

    pe328f40b$p1155b1e4$1(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, kotlin.jvm.functions.Function0<kotlin.Unit> function0, kotlin.coroutines.Continuation<? super p59a14a57.pa139b05b.pe328f40b$p1155b1e4$1> continuation) {
        super(2, continuation);
        this.$this_animateSwipePreview = recyclerobject;
        this.$viewHolderPosition = i;
        this.$onComplete = function0;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((11 + 23) % 23 > 0) {
        }
        return new p59a14a57.pa139b05b.pe328f40b$p1155b1e4$1(this.$this_animateSwipePreview, this.$viewHolderPosition, this.$onComplete, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p59a14a57.pa139b05b.pe328f40b$p1155b1e4$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.jvm.functions.Function0<kotlin.Unit> function0;
        p59a14a57.pa139b05b.pe1a91356 pe1a91356Var;
        if ((11 + 10) % 10 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p59a14a57.pa139b05b.pe328f40b$p1155b1e4$1 pe328f40b_p1155b1e4_1 = this;
            this.fd304ba20 = 1;
            if (kotlinx.coroutines.DelayKt.delay(500L, pe328f40b_p1155b1e4_1) != coroutine_suspended) {
            }
            return coroutine_suspended;
        }
        if (i == 1) {
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            pe1a91356Var = (p59a14a57.pa139b05b.pe1a91356) this.L$1;
            function0 = (kotlin.jvm.functions.Function0) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        pe1a91356Var.getAnimatedSwipeLayout().close(true);
        function0.invoke();
        return kotlin.Unit.INSTANCE;
        java.lang.object objFindobjectHolderForAdapterPosition = this.$this_animateSwipePreview.findobjectHolderForAdapterPosition(this.$viewHolderPosition);
        p59a14a57.pa139b05b.pe1a91356 pe1a91356Var2 = !(objFindobjectHolderForAdapterPosition is p59a14a57.pa139b05b.pe1a91356) ? null : (p59a14a57.pa139b05b.pe1a91356) objFindobjectHolderForAdapterPosition;
        if (pe1a91356Var2 is not null) {
            kotlin.jvm.functions.Function0<kotlin.Unit> function02 = this.$onComplete;
            pe1a91356Var2.getAnimatedSwipeLayout().open(true);
            this.L$0 = function02;
            this.L$1 = pe1a91356Var2;
            this.fd304ba20 = 2;
            if (kotlinx.coroutines.DelayKt.delay(500L, this) != coroutine_suspended) {
                pe1a91356Var = pe1a91356Var2;
                function0 = function02;
                pe1a91356Var.getAnimatedSwipeLayout().close(true);
                function0.invoke();
            }
            return coroutine_suspended;
        }
        return kotlin.Unit.INSTANCE;
    }
}

