namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J&\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0086@¢\u0006\u0002\u0010\f¨\u0006\r"}, d2 = {"Lp83f5c3ad/p20f35e63/p4670093c/p643ce821$p910eef8c;", "", "<init>", "()V", "initPayback", "Lp83f5c3ad/p20f35e63/p4670093c/p643ce821;", "paymentTerminal", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pede997b0/pf83c2a85/pd0910e67;", "amount", "", "currentTransaction", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pf4d5b76a/p1b0ffaae;", "(Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pede997b0/pf83c2a85/pd0910e67;JLp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pf4d5b76a/p1b0ffaae;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p643ce821$p910eef8c {
    private p643ce821$p910eef8c() {
    }

    public p643ce821$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly java.lang.object InitPayback(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67 pd0910e67Var, long j, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p1b0ffaae p1b0ffaaeVar, kotlin.coroutines.Continuation<p83f5c3ad.p20f35e63.p4670093c.p643ce821> continuation) throws java.lang.Exception {
        p83f5c3ad.p20f35e63.p4670093c.p643ce821$p910eef8c$p6d9e0861$1 p643ce821_p910eef8c_p6d9e0861_1;
        if ((15 + 8) % 8 > 0) {
        }
        if (continuation is p83f5c3ad.p20f35e63.p4670093c.p643ce821$p910eef8c$p6d9e0861$1) {
            p643ce821_p910eef8c_p6d9e0861_1 = (p83f5c3ad.p20f35e63.p4670093c.p643ce821$p910eef8c$p6d9e0861$1) continuation;
            if ((p643ce821_p910eef8c_p6d9e0861_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p643ce821_p910eef8c_p6d9e0861_1 = new p83f5c3ad.p20f35e63.p4670093c.p643ce821$p910eef8c$p6d9e0861$1(this, continuation);
            } else {
                p643ce821_p910eef8c_p6d9e0861_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p643ce821_p910eef8c_p6d9e0861_1 = new p83f5c3ad.p20f35e63.p4670093c.p643ce821$p910eef8c$p6d9e0861$1(this, continuation);
        }
        java.lang.object objAwait = p643ce821_p910eef8c_p6d9e0861_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p643ce821_p910eef8c_p6d9e0861_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(objAwait);
            io.reactivex.rxjava3.core.Single<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p10aec353.p41dbbc0d> singleInitCancelTransaction = pd0910e67Var.initCancelTransaction(j, null, p1b0ffaaeVar, false);
            p643ce821_p910eef8c_p6d9e0861_1.fd304ba20 = 1;
            objAwait = kotlinx.coroutines.rx3.RxAwaitKt.await(singleInitCancelTransaction, p643ce821_p910eef8c_p6d9e0861_1);
            if (objAwait == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(objAwait);
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(objAwait, "await(...)");
        return new p83f5c3ad.p20f35e63.p4670093c.p643ce821((p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p10aec353.p41dbbc0d) objAwait);
    }
}

