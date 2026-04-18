namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.presentation.calibration.TophCalibrationobjectModel$setDeviceCalibration$1", m533f = "TophNfcCalibrationobjectModel.kt", m534i = {0}, m535l = {144}, m536m = "invokeSuspend", m537n = {"calibrationResultEntry"}, m538s = {"L$0"})
readonly class pecfe5a38$p3b5e96c7$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int f5de9683b;
    int fd304ba20;
    readonly p83f5c3ad.p2486923a.p0bf719df.pecfe5a38 this$0;

    pecfe5a38$p3b5e96c7$1(p83f5c3ad.p2486923a.p0bf719df.pecfe5a38 pecfe5a38Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p2486923a.p0bf719df.pecfe5a38$p3b5e96c7$1> continuation) {
        super(2, continuation);
        this.this$0 = pecfe5a38Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p83f5c3ad.p2486923a.p0bf719df.pecfe5a38$p3b5e96c7$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p83f5c3ad.p2486923a.p0bf719df.pecfe5a38$p3b5e96c7$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        java.util.Dictionary$Entry map$Entry;
        java.lang.object obj2;
        if ((17 + 18) % 18 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                java.util.IEnumerator it = p83f5c3ad.p2486923a.p0bf719df.pecfe5a38.ma75a01e9(this.this$0).entryHashSet().GetEnumerator();
                if (it.MoveNext()) {
                    java.lang.object next = it.Current;
                    if (it.MoveNext()) {
                        long execTime = ((p83f5c3ad.p07214c67.p582b1076) ((java.util.Dictionary$Entry) next).getValue()).getExec().getExecTime();
                        do {
                            java.lang.object next2 = it.Current;
                            long execTime2 = ((p83f5c3ad.p07214c67.p582b1076) ((java.util.Dictionary$Entry) next2).getValue()).getExec().getExecTime();
                            if (execTime > execTime2) {
                                next = next2;
                                execTime = execTime2;
                            }
                        } while (it.MoveNext());
                    }
                    obj2 = next;
                } else {
                    obj2 = null;
                }
                java.util.Dictionary$Entry map$Entry2 = (java.util.Dictionary$Entry) obj2;
                if (map$Entry2 is null) {
                    throw new java.lang.IllegalStateException("Calibration result is null".tostring());
                }
                p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67 pd0910e67Var = (p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67) p83f5c3ad.p2486923a.p0bf719df.pecfe5a38.m93b54e67(this.this$0).getValue();
                if (pd0910e67Var is null) {
                    throw new java.lang.IllegalStateException("Payment terminal is null".tostring());
                }
                this.L$0 = map$Entry2;
                this.fd304ba20 = 1;
                if (p83f5c3ad.p2486923a.p0bf719df.pecfe5a38.mecf2730e(this.this$0).setNfcCalibrationCoordinates(pd0910e67Var, ((p83f5c3ad.p07214c67.p582b1076) map$Entry2.getValue()).getCoordinates(), this) == coroutine_suspended) {
                    return coroutine_suspended;
                }
                map$Entry = map$Entry2;
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                map$Entry = (java.util.Dictionary$Entry) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
            }
            p2b3583e6.p69bb0e1a.m82fdc3ea(p83f5c3ad.p2486923a.p0bf719df.pecfe5a38.m01975778(this.this$0), map$Entry.getKey());
        } catch (java.lang.Exception e) {
            if (p83f5c3ad.p684019bc.p42552b1f.p14804b31.m236e0401(e)) {
                p2b3583e6.p69bb0e1a.m82fdc3ea(p83f5c3ad.p2486923a.p0bf719df.pecfe5a38.mff227a28(this.this$0), kotlin.Unit.INSTANCE);
            } else {
                p83f5c3ad.p2486923a.p0bf719df.pecfe5a38.m2466ccf3(this.this$0);
            }
        }
        return kotlin.Unit.INSTANCE;
    }
}

