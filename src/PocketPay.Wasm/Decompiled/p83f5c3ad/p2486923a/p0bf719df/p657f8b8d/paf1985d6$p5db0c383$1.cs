namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.presentation.calibration.help.TophNfcCalibrationHelpobjectModel$getNfcCalibrated$1", m533f = "TophNfcCalibrationHelpobjectModel.kt", m534i = {}, m535l = {50}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class paf1985d6$p5db0c383$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f08083787;
    int fd304ba20;
    readonly p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.paf1985d6 this$0;

    paf1985d6$p5db0c383$1(p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.paf1985d6 paf1985d6Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.paf1985d6$p5db0c383$1> continuation) {
        super(2, continuation);
        this.this$0 = paf1985d6Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.paf1985d6$p5db0c383$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.paf1985d6$p5db0c383$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((17 + 2) % 2 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                this.fd304ba20 = 1;
                obj = p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.paf1985d6.mecf2730e(this.this$0).isNfcCalibrated(this);
                if (obj == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.paf1985d6.meb829b02(this.this$0).setValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.success(kotlin.coroutines.jvm.internal.Boxing.boxbool(((java.lang.bool) obj).boolValue())));
        } catch (java.lang.Exception e) {
            p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.paf1985d6.meb829b02(this.this$0).setValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.error(e));
        }
        return kotlin.Unit.INSTANCE;
    }
}

