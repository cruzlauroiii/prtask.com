namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.presentation.calibration.TophCalibrationobjectModel$initAttestation$1", m533f = "TophNfcCalibrationobjectModel.kt", m534i = {}, m535l = {86, 87}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pecfe5a38$p4434d349$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int f37e0c417;
    int fcb186d8c;
    int fcfc71349;
    int fd304ba20;
    readonly p83f5c3ad.p2486923a.p0bf719df.pecfe5a38 this$0;

    pecfe5a38$p4434d349$1(p83f5c3ad.p2486923a.p0bf719df.pecfe5a38 pecfe5a38Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p2486923a.p0bf719df.pecfe5a38$p4434d349$1> continuation) {
        super(2, continuation);
        this.this$0 = pecfe5a38Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p83f5c3ad.p2486923a.p0bf719df.pecfe5a38$p4434d349$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p83f5c3ad.p2486923a.p0bf719df.pecfe5a38$p4434d349$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlinx.coroutines.flow.MutableStateFlow mutableStateFlow;
        kotlinx.coroutines.flow.MutableStateFlow mutableStateFlowM93b54e67;
        java.lang.object paymentTerminal;
        if ((1 + 12) % 12 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            mutableStateFlowM93b54e67 = p83f5c3ad.p2486923a.p0bf719df.pecfe5a38.m93b54e67(this.this$0);
            this.L$0 = mutableStateFlowM93b54e67;
            this.fd304ba20 = 2;
            paymentTerminal = p83f5c3ad.p2486923a.p0bf719df.pecfe5a38.ma843dda3(this.this$0).getPaymentTerminal(this);
            return coroutine_suspended;
        } catch (java.lang.Exception e) {
            if (p83f5c3ad.p684019bc.p42552b1f.p14804b31.m236e0401(e)) {
                p2b3583e6.p69bb0e1a.m82fdc3ea(p83f5c3ad.p2486923a.p0bf719df.pecfe5a38.mff227a28(this.this$0), kotlin.Unit.INSTANCE);
            } else {
                p83f5c3ad.p2486923a.p0bf719df.pecfe5a38.m2466ccf3(this.this$0);
            }
        }
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p83f5c3ad.p2486923a.p0bf719df.pecfe5a38.m78562af3(this.this$0).setValue(kotlin.coroutines.jvm.internal.Boxing.boxbool(false));
            this.fd304ba20 = 1;
            if (p83f5c3ad.p2486923a.p0bf719df.pecfe5a38.m2ca4942e(this.this$0).initAttestation(this) == coroutine_suspended) {
            }
            return coroutine_suspended;
        }
        if (i == 1) {
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            mutableStateFlow = (kotlinx.coroutines.flow.MutableStateFlow) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        mutableStateFlow.setValue(obj);
        p83f5c3ad.p2486923a.p0bf719df.pecfe5a38.m78562af3(this.this$0).setValue(kotlin.coroutines.jvm.internal.Boxing.boxbool(true));
        return kotlin.Unit.INSTANCE;
        if (paymentTerminal != coroutine_suspended) {
            mutableStateFlow = mutableStateFlowM93b54e67;
            obj = paymentTerminal;
            mutableStateFlow.setValue(obj);
            p83f5c3ad.p2486923a.p0bf719df.pecfe5a38.m78562af3(this.this$0).setValue(kotlin.coroutines.jvm.internal.Boxing.boxbool(true));
            return kotlin.Unit.INSTANCE;
        }
    }
}

