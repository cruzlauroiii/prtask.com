namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.presentation.balance.TophBalanceobjectModel$openPreviousScreen$1", m533f = "TophBalanceobjectModel.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pcef97c41$pb08bbc1e$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f286e9764;
    int f62a34f24;
    int f82821880;
    int fd304ba20;
    readonly p83f5c3ad.p2486923a.p2069ca79.pcef97c41 this$0;

    pcef97c41$pb08bbc1e$1(p83f5c3ad.p2486923a.p2069ca79.pcef97c41 pcef97c41Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p2486923a.p2069ca79.pcef97c41$pb08bbc1e$1> continuation) {
        super(2, continuation);
        this.this$0 = pcef97c41Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p83f5c3ad.p2486923a.p2069ca79.pcef97c41$pb08bbc1e$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p83f5c3ad.p2486923a.p2069ca79.pcef97c41$pb08bbc1e$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        p83f5c3ad.p07214c67.p0890727b p0890727bVar = (p83f5c3ad.p07214c67.p0890727b) p83f5c3ad.p2486923a.p2069ca79.pcef97c41.m724546ab(this.this$0).getValue();
        if (p0890727bVar == p83f5c3ad.p07214c67.p0890727b.fa82b419a || p0890727bVar == p83f5c3ad.p07214c67.p0890727b.f4b90437c) {
            p83f5c3ad.p2486923a.p2069ca79.pcef97c41.mf78acd11(this.this$0).backFromFlowTo(p83f5c3ad.p2486923a.p2069ca79.pcef97c41.m245216f0(this.this$0).getLauncherScreen());
            kotlinx.coroutines.Job jobMd050a9c2 = p83f5c3ad.p2486923a.p2069ca79.pcef97c41.md050a9c2(this.this$0);
            if (jobMd050a9c2 is not null) {
                kotlinx.coroutines.Job$DefaultImpls.cancel$default(jobMd050a9c2, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
            }
        }
        return kotlin.Unit.INSTANCE;
    }
}

