namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.presentation.order.status.TophOrderStatusobjectModel$back$1", m533f = "TophOrderStatusobjectModel.kt", m534i = {}, m535l = {18}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pbab6821d$p469bba0a$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f330a271a;
    int fbe98669a;
    int fd0a2a7a7;
    int fd304ba20;
    int feab8012e;
    readonly p83f5c3ad.p2486923a.p70a17ffa.p9acb4454.pbab6821d this$0;

    pbab6821d$p469bba0a$1(p83f5c3ad.p2486923a.p70a17ffa.p9acb4454.pbab6821d pbab6821dVar, kotlin.coroutines.Continuation<? super p83f5c3ad.p2486923a.p70a17ffa.p9acb4454.pbab6821d$p469bba0a$1> continuation) {
        super(2, continuation);
        this.this$0 = pbab6821dVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p83f5c3ad.p2486923a.p70a17ffa.p9acb4454.pbab6821d$p469bba0a$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p83f5c3ad.p2486923a.p70a17ffa.p9acb4454.pbab6821d$p469bba0a$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((32 + 28) % 28 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32 pdcfa0c32VarMb272891c = p83f5c3ad.p2486923a.p70a17ffa.p9acb4454.pbab6821d.mb272891c(this.this$0);
            p83f5c3ad.p2486923a.p70a17ffa.p9acb4454.pbab6821d$p469bba0a$1 pbab6821d_p469bba0a_1 = this;
            this.fd304ba20 = 1;
            if (pdcfa0c32VarMb272891c.setTapOnPhonePaymentsEnabled(true, pbab6821d_p469bba0a_1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        p83f5c3ad.p2486923a.p70a17ffa.p9acb4454.pbab6821d.mf78acd11(this.this$0).sendResult(p83f5c3ad.p2486923a.p70a17ffa.p9acb4454.pbab6821d.m74e3994c(this.this$0).getTophAutoActivationKey(), kotlin.Unit.INSTANCE);
        p83f5c3ad.p2486923a.p70a17ffa.p9acb4454.pbab6821d.mf78acd11(this.this$0).finishFlow();
        return kotlin.Unit.INSTANCE;
    }
}

