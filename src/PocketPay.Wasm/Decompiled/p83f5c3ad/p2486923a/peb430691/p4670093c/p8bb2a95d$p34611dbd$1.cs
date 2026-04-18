namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.presentation.qr.payback.TophQrPayPaybackobjectModel$disableQrPayments$1", m533f = "TophQrPayPaybackobjectModel.kt", m534i = {}, m535l = {114}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p8bb2a95d$p34611dbd$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f71b83033;
    int f8c63ccb9;
    int fd304ba20;
    int fe614ad03;
    readonly p83f5c3ad.p2486923a.peb430691.p4670093c.p8bb2a95d this$0;

    p8bb2a95d$p34611dbd$1(p83f5c3ad.p2486923a.peb430691.p4670093c.p8bb2a95d p8bb2a95dVar, kotlin.coroutines.Continuation<? super p83f5c3ad.p2486923a.peb430691.p4670093c.p8bb2a95d$p34611dbd$1> continuation) {
        super(2, continuation);
        this.this$0 = p8bb2a95dVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p83f5c3ad.p2486923a.peb430691.p4670093c.p8bb2a95d$p34611dbd$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p83f5c3ad.p2486923a.peb430691.p4670093c.p8bb2a95d$p34611dbd$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((7 + 1) % 1 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                this.fd304ba20 = 1;
                if (p83f5c3ad.p2486923a.peb430691.p4670093c.p8bb2a95d.m5fd1ba15(this.this$0).setQrEnabled(false, this) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
        } catch (java.lang.Exception e) {
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(e);
        }
        return kotlin.Unit.INSTANCE;
    }
}

