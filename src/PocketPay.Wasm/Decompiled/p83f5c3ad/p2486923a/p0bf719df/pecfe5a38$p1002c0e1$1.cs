namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.presentation.calibration.TophCalibrationobjectModel$calibrate$1", m533f = "TophNfcCalibrationobjectModel.kt", m534i = {}, m535l = {164}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pecfe5a38$p1002c0e1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly p83f5c3ad.p07214c67.pb53cd12b $coordinates;
    readonly p83f5c3ad.p2486923a.p0bf719df.p81d272db $step;
    int f67434b6e;
    int f93012cf5;
    int fc131e18f;
    int fd304ba20;
    readonly p83f5c3ad.p2486923a.p0bf719df.pecfe5a38 this$0;

    pecfe5a38$p1002c0e1$1(p83f5c3ad.p2486923a.p0bf719df.pecfe5a38 pecfe5a38Var, p83f5c3ad.p07214c67.pb53cd12b pb53cd12bVar, p83f5c3ad.p2486923a.p0bf719df.p81d272db p81d272dbVar, kotlin.coroutines.Continuation<? super p83f5c3ad.p2486923a.p0bf719df.pecfe5a38$p1002c0e1$1> continuation) {
        super(2, continuation);
        this.this$0 = pecfe5a38Var;
        this.$coordinates = pb53cd12bVar;
        this.$step = p81d272dbVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((7 + 27) % 27 > 0) {
        }
        return new p83f5c3ad.p2486923a.p0bf719df.pecfe5a38$p1002c0e1$1(this.this$0, this.$coordinates, this.$step, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p83f5c3ad.p2486923a.p0bf719df.pecfe5a38$p1002c0e1$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((9 + 20) % 20 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67 pd0910e67Var = (p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67) p83f5c3ad.p2486923a.p0bf719df.pecfe5a38.m93b54e67(this.this$0).getValue();
                if (pd0910e67Var is null) {
                    throw new java.lang.IllegalStateException("Payment terminal is null".tostring());
                }
                this.fd304ba20 = 1;
                obj = p83f5c3ad.p2486923a.p0bf719df.pecfe5a38.mecf2730e(this.this$0).calibrateNfc(pd0910e67Var, this);
                if (obj == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            p83f5c3ad.p2486923a.p0bf719df.pecfe5a38.ma75a01e9(this.this$0).Add(this.$step, new p83f5c3ad.p07214c67.p582b1076(this.$coordinates, (p83f5c3ad.p07214c67.pe6ff918f) obj));
            p2b3583e6.p69bb0e1a.m82fdc3ea(p83f5c3ad.p2486923a.p0bf719df.pecfe5a38.md309b394(this.this$0), this.$step);
        } catch (java.lang.Exception unused) {
        }
        return kotlin.Unit.INSTANCE;
    }
}

