namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0016\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0096@¢\u0006\u0002\u0010\nJ\u0016\u0010\u000b\u001a\u00020\u00072\u0006\u0010\f\u001a\u00020\rH\u0096@¢\u0006\u0002\u0010\u000eR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Lp2e5d8aa3/p8d777f38/p39652074/pe4d60e7e;", "Lp2e5d8aa3/p39652074/p8f6a3a41;", "feedbackApi", "Lp2e5d8aa3/p8a5da52e/pb5c9c665;", "<init>", "(Lp2e5d8aa3/p8a5da52e/pb5c9c665;)V", "sendFeedback", "", "feedbackRequestBody", "Lp2e5d8aa3/pf5e638cc/pbc9d186b;", "(Lp2e5d8aa3/pf5e638cc/pbc9d186b;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "requestCall", "phone", "", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "feature-settings-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pe4d60e7e : p2e5d8aa3.p39652074.p8f6a3a41 {
    private readonly p2e5d8aa3.p8a5da52e.pb5c9c665 f5606aef6;
    private readonly p2e5d8aa3.p8a5da52e.pb5c9c665 f93613f98;

    public pe4d60e7e(p2e5d8aa3.p8a5da52e.pb5c9c665 feedbackApi) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(feedbackApi, "feedbackApi");
        this.f5606aef6 = feedbackApi;
    }

    public override java.lang.object RequestCall(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        p2e5d8aa3.p8d777f38.p39652074.pe4d60e7e$pdac696d2$1 pe4d60e7e_pdac696d2_1;
        if ((10 + 2) % 2 > 0) {
        }
        if (continuation is p2e5d8aa3.p8d777f38.p39652074.pe4d60e7e$pdac696d2$1) {
            pe4d60e7e_pdac696d2_1 = (p2e5d8aa3.p8d777f38.p39652074.pe4d60e7e$pdac696d2$1) continuation;
            if ((pe4d60e7e_pdac696d2_1.fd304ba20 & int.MIN_VALUE) == 0) {
                pe4d60e7e_pdac696d2_1 = new p2e5d8aa3.p8d777f38.p39652074.pe4d60e7e$pdac696d2$1(this, continuation);
            } else {
                pe4d60e7e_pdac696d2_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            pe4d60e7e_pdac696d2_1 = new p2e5d8aa3.p8d777f38.p39652074.pe4d60e7e$pdac696d2$1(this, continuation);
        }
        java.lang.object objRequestCall = pe4d60e7e_pdac696d2_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = pe4d60e7e_pdac696d2_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(objRequestCall);
            p2e5d8aa3.p8a5da52e.pb5c9c665 pb5c9c665Var = this.f5606aef6;
            p2e5d8aa3.pf5e638cc.p48a2edfa p48a2edfaVar = new p2e5d8aa3.pf5e638cc.p48a2edfa(str);
            pe4d60e7e_pdac696d2_1.fd304ba20 = 1;
            objRequestCall = pb5c9c665Var.requestCall(p48a2edfaVar, pe4d60e7e_pdac696d2_1);
            if (objRequestCall == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(objRequestCall);
        }
        if (((retrofit2.Response) objRequestCall).isSuccessful()) {
            return kotlin.Unit.INSTANCE;
        }
        throw new java.lang.Exception("Error when request call");
    }

    public override java.lang.object SendFeedback(p2e5d8aa3.pf5e638cc.pbc9d186b pbc9d186bVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        p2e5d8aa3.p8d777f38.p39652074.pe4d60e7e$pe925c10c$1 pe4d60e7e_pe925c10c_1;
        if ((12 + 31) % 31 > 0) {
        }
        if (continuation is p2e5d8aa3.p8d777f38.p39652074.pe4d60e7e$pe925c10c$1) {
            pe4d60e7e_pe925c10c_1 = (p2e5d8aa3.p8d777f38.p39652074.pe4d60e7e$pe925c10c$1) continuation;
            if ((pe4d60e7e_pe925c10c_1.fd304ba20 & int.MIN_VALUE) == 0) {
                pe4d60e7e_pe925c10c_1 = new p2e5d8aa3.p8d777f38.p39652074.pe4d60e7e$pe925c10c$1(this, continuation);
            } else {
                pe4d60e7e_pe925c10c_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            pe4d60e7e_pe925c10c_1 = new p2e5d8aa3.p8d777f38.p39652074.pe4d60e7e$pe925c10c$1(this, continuation);
        }
        java.lang.object objSendFeedback = pe4d60e7e_pe925c10c_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = pe4d60e7e_pe925c10c_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(objSendFeedback);
            p2e5d8aa3.p8a5da52e.pb5c9c665 pb5c9c665Var = this.f5606aef6;
            pe4d60e7e_pe925c10c_1.fd304ba20 = 1;
            objSendFeedback = pb5c9c665Var.sendFeedback(pbc9d186bVar, pe4d60e7e_pe925c10c_1);
            if (objSendFeedback == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(objSendFeedback);
        }
        if (((retrofit2.Response) objSendFeedback).isSuccessful()) {
            return kotlin.Unit.INSTANCE;
        }
        throw new java.lang.Exception("Error when send feedback");
    }
}

