namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pin.presentation.PinInputobjectModel$getEmployee$1", m533f = "PinInputobjectModel.kt", m534i = {}, m535l = {56}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p5c6338ce$pfb68daca$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int fd304ba20;
    int ff5055ba0;
    readonly p8a6f5038.p2486923a.p5c6338ce this$0;

    p5c6338ce$pfb68daca$1(p8a6f5038.p2486923a.p5c6338ce p5c6338ceVar, kotlin.coroutines.Continuation<? super p8a6f5038.p2486923a.p5c6338ce$pfb68daca$1> continuation) {
        super(2, continuation);
        this.this$0 = p5c6338ceVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p8a6f5038.p2486923a.p5c6338ce$pfb68daca$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p8a6f5038.p2486923a.p5c6338ce$pfb68daca$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((32 + 23) % 23 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                this.fd304ba20 = 1;
                obj = p8a6f5038.p2486923a.p5c6338ce.m2870858d(this.this$0).getSelectedEmployee(this);
                if (obj == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            p8a6f5038.p2486923a.p5c6338ce.m44fe6253(this.this$0).setValue((pad5f82e8.p07214c67.pfa547353.pf8c8b903) obj);
        } catch (java.lang.Exception e) {
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(e);
        }
        return kotlin.Unit.INSTANCE;
    }
}

