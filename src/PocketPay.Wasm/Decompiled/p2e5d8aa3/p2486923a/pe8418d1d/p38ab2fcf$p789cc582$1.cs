namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "settings.presentation.verify.HashSettingsVerifyobjectModel$getVerifyCode$1", m533f = "HashSettingsVerifyobjectModel.kt", m534i = {}, m535l = {25}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p38ab2fcf$p789cc582$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f03ab205f;
    int f4341f51d;
    int fbd23dcec;
    int fd304ba20;
    readonly p2e5d8aa3.p2486923a.pe8418d1d.p38ab2fcf this$0;

    p38ab2fcf$p789cc582$1(p2e5d8aa3.p2486923a.pe8418d1d.p38ab2fcf p38ab2fcfVar, kotlin.coroutines.Continuation<? super p2e5d8aa3.p2486923a.pe8418d1d.p38ab2fcf$p789cc582$1> continuation) {
        super(2, continuation);
        this.this$0 = p38ab2fcfVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p2e5d8aa3.p2486923a.pe8418d1d.p38ab2fcf$p789cc582$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p2e5d8aa3.p2486923a.pe8418d1d.p38ab2fcf$p789cc582$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((5 + 19) % 19 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                p2e5d8aa3.p2486923a.pe8418d1d.p38ab2fcf.m67b98dd3(this.this$0).setValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.loading());
                this.fd304ba20 = 1;
                obj = p2e5d8aa3.p2486923a.pe8418d1d.p38ab2fcf.med27d92d(this.this$0).getVerifyCode(this);
                if (obj == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            p2e5d8aa3.p2486923a.pe8418d1d.p38ab2fcf.m67b98dd3(this.this$0).setValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.success((java.lang.string) obj));
        } catch (java.lang.Exception e) {
            p2e5d8aa3.p2486923a.pe8418d1d.p38ab2fcf.m67b98dd3(this.this$0).setValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.error(e));
        }
        return kotlin.Unit.INSTANCE;
    }
}

