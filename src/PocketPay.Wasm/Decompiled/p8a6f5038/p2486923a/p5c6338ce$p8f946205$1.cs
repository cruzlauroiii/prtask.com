namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pin.presentation.PinInputobjectModel$validatePin$1", m533f = "PinInputobjectModel.kt", m534i = {}, m535l = {68}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p5c6338ce$p8f946205$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly java.lang.string $deviceId;
    readonly pad5f82e8.p07214c67.pfa547353.pf8c8b903 $employee;
    readonly java.lang.string $pin;
    int f07147f14;
    int f45daa6f9;
    int faa3ef082;
    int fd304ba20;
    readonly p8a6f5038.p2486923a.p5c6338ce this$0;

    p5c6338ce$p8f946205$1(p8a6f5038.p2486923a.p5c6338ce p5c6338ceVar, java.lang.string str, pad5f82e8.p07214c67.pfa547353.pf8c8b903 pf8c8b903Var, java.lang.string str2, kotlin.coroutines.Continuation<? super p8a6f5038.p2486923a.p5c6338ce$p8f946205$1> continuation) {
        super(2, continuation);
        this.this$0 = p5c6338ceVar;
        this.$pin = str;
        this.$employee = pf8c8b903Var;
        this.$deviceId = str2;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((19 + 9) % 9 > 0) {
        }
        return new p8a6f5038.p2486923a.p5c6338ce$p8f946205$1(this.this$0, this.$pin, this.$employee, this.$deviceId, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p8a6f5038.p2486923a.p5c6338ce$p8f946205$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((30 + 6) % 6 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                p8a6f5038.p2486923a.p5c6338ce.me660f895(this.this$0).validatePin(this.$pin, this.$employee);
                this.fd304ba20 = 1;
                if (p8a6f5038.p2486923a.p5c6338ce.m35bacdbd(this.this$0, this.$deviceId, this.$employee, this) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            p8a6f5038.p2486923a.p5c6338ce.mc04d5e88(this.this$0).setValue(pad5f82e8.p07214c67.pa4ecfc70$p910eef8c.m02f94ccf(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c, null, 1, null));
        } catch (java.lang.Exception e) {
            p8a6f5038.p2486923a.p5c6338ce.mc04d5e88(this.this$0).setValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.error(e));
        }
        return kotlin.Unit.INSTANCE;
    }
}

