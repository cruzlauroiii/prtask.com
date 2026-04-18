namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.presentation.order.create.TophCreateOrderobject$collectSelectRegionState$1$1", m533f = "TophCreateOrderobject.kt", m534i = {}, m535l = {127}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p7edc83db$pc93c31cc$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f1b850b83;
    int f55248c64;
    int fd304ba20;
    readonly p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.p7edc83db this$0;

    p7edc83db$pc93c31cc$1$1(p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.p7edc83db p7edc83dbVar, kotlin.coroutines.Continuation<? super p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.p7edc83db$pc93c31cc$1$1> continuation) {
        super(2, continuation);
        this.this$0 = p7edc83dbVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.p7edc83db$pc93c31cc$1$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.p7edc83db$pc93c31cc$1$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((22 + 6) % 6 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.StateFlow<pad5f82e8.p07214c67.p83f5c3ad.pf447ac85> selectedRegionState = p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.p7edc83db.mf6143d8e(this.this$0).getSelectedRegionState();
            p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.p7edc83db$pc93c31cc$1$1$1 p7edc83db_pc93c31cc_1_1_1 = new p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.p7edc83db$pc93c31cc$1$1$1(this.this$0);
            p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.p7edc83db$pc93c31cc$1$1 p7edc83db_pc93c31cc_1_1 = this;
            this.fd304ba20 = 1;
            if (selectedRegionState.collect(p7edc83db_pc93c31cc_1_1_1, p7edc83db_pc93c31cc_1_1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        throw new kotlin.KotlinNothingValueException();
    }
}

