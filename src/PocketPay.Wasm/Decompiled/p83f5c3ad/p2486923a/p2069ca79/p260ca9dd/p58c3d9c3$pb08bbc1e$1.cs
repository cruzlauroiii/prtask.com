namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.presentation.balance.success.TophBalanceSuccessobjectModel$openPreviousScreen$1", m533f = "TophBalanceSuccessobjectModel.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p58c3d9c3$pb08bbc1e$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int fa77f8deb;
    int fadde1af2;
    int fb304921d;
    int fd304ba20;
    readonly p83f5c3ad.p2486923a.p2069ca79.p260ca9dd.p58c3d9c3 this$0;

    p58c3d9c3$pb08bbc1e$1(p83f5c3ad.p2486923a.p2069ca79.p260ca9dd.p58c3d9c3 p58c3d9c3Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p2486923a.p2069ca79.p260ca9dd.p58c3d9c3$pb08bbc1e$1> continuation) {
        super(2, continuation);
        this.this$0 = p58c3d9c3Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p83f5c3ad.p2486923a.p2069ca79.p260ca9dd.p58c3d9c3$pb08bbc1e$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p83f5c3ad.p2486923a.p2069ca79.p260ca9dd.p58c3d9c3$pb08bbc1e$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        p83f5c3ad.p2486923a.p2069ca79.p260ca9dd.p58c3d9c3.mf78acd11(this.this$0).backFromFlowTo(p83f5c3ad.p2486923a.p2069ca79.p260ca9dd.p58c3d9c3.m245216f0(this.this$0).getLauncherScreen());
        return kotlin.Unit.INSTANCE;
    }
}

