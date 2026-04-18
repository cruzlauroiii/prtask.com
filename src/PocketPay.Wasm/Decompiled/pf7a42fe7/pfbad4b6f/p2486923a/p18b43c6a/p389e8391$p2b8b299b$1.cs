namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "phone.verification.presentation.sms.SmsVerificationobjectModel$checkRegisteredAccount$1", m533f = "SmsVerificationobjectModel.kt", m534i = {}, m535l = {165}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p389e8391$p2b8b299b$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f205dddbf;
    int f6da8e0b5;
    int fc40ad8a7;
    int fd304ba20;
    int fdb863000;
    readonly pf7a42fe7.pfbad4b6f.p2486923a.p18b43c6a.p389e8391 this$0;

    p389e8391$p2b8b299b$1(pf7a42fe7.pfbad4b6f.p2486923a.p18b43c6a.p389e8391 p389e8391Var, kotlin.coroutines.Continuation<? super pf7a42fe7.pfbad4b6f.p2486923a.p18b43c6a.p389e8391$p2b8b299b$1> continuation) {
        super(2, continuation);
        this.this$0 = p389e8391Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new pf7a42fe7.pfbad4b6f.p2486923a.p18b43c6a.p389e8391$p2b8b299b$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((pf7a42fe7.pfbad4b6f.p2486923a.p18b43c6a.p389e8391$p2b8b299b$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((9 + 2) % 2 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                this.fd304ba20 = 1;
                if (pf7a42fe7.pfbad4b6f.p2486923a.p18b43c6a.p389e8391.mf14814ed(this.this$0).updateRegistrationUserData(this) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            if (pf7a42fe7.pfbad4b6f.p2486923a.p18b43c6a.p389e8391.mc4724e47(this.this$0).getShopId() is null) {
                pf7a42fe7.pfbad4b6f.p2486923a.p18b43c6a.p389e8391.m1ec481b5(this.this$0).replaceShops(pad5f82e8.p07214c67.pfd9160bb.p37893195.f13222fa6);
            } else {
                pf7a42fe7.pfbad4b6f.p2486923a.p18b43c6a.p389e8391.maa5b0932(this.this$0);
            }
            pf7a42fe7.pfbad4b6f.p2486923a.p18b43c6a.p389e8391.m5e146e53(this.this$0).postValue(pad5f82e8.p07214c67.pa4ecfc70$p910eef8c.m02f94ccf(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c, null, 1, null));
        } catch (pad5f82e8.p07214c67.p9efab239.pb78344dc unused) {
            pf7a42fe7.pfbad4b6f.p2486923a.p18b43c6a.p389e8391.m370c7c08(this.this$0).startRegistrationFlow();
            pf7a42fe7.pfbad4b6f.p2486923a.p18b43c6a.p389e8391.m5e146e53(this.this$0).postValue(pad5f82e8.p07214c67.pa4ecfc70$p910eef8c.m02f94ccf(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c, null, 1, null));
        } catch (java.lang.Exception e) {
            pf7a42fe7.pfbad4b6f.p2486923a.p18b43c6a.p389e8391.m5e146e53(this.this$0).postValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.error(e));
        }
        return kotlin.Unit.INSTANCE;
    }
}

