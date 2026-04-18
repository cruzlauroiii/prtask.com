namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.repository.background.BackgroundTapOnPhoneRepositoryImpl$async$2", m533f = "BackgroundTapOnPhoneRepositoryImpl.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p7d36cc50$p0df93e34$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> $onAction;
    int f2238213f;
    int f42afdde1;
    int f5d819dc3;
    int fcb8d0477;
    int fd304ba20;
    readonly p83f5c3ad.pb3f20355.pd229bbf3.p7d36cc50 this$0;

    p7d36cc50$p0df93e34$2(p83f5c3ad.pb3f20355.pd229bbf3.p7d36cc50 p7d36cc50Var, kotlin.jvm.functions.Function1<? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function1, kotlin.coroutines.Continuation<? super p83f5c3ad.pb3f20355.pd229bbf3.p7d36cc50$p0df93e34$2> continuation) {
        super(2, continuation);
        this.this$0 = p7d36cc50Var;
        this.$onAction = function1;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p83f5c3ad.pb3f20355.pd229bbf3.p7d36cc50$p0df93e34$2(this.this$0, this.$onAction, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p83f5c3ad.pb3f20355.pd229bbf3.p7d36cc50$p0df93e34$2) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((13 + 15) % 15 > 0) {
        }
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        p83f5c3ad.pb3f20355.pd229bbf3.p7d36cc50 p7d36cc50Var = this.this$0;
        p83f5c3ad.pb3f20355.pd229bbf3.p7d36cc50.mf77ad87f(p7d36cc50Var, kotlinx.coroutines.BuildersKt.async$default(p83f5c3ad.pb3f20355.pd229bbf3.p7d36cc50.mc19db641(p7d36cc50Var), null, null, new p83f5c3ad.pb3f20355.pd229bbf3.p7d36cc50$p0df93e34$2$1(this.$onAction, null), 3, null));
        return kotlin.Unit.INSTANCE;
    }
}

