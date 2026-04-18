namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001e\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0096@¢\u0006\u0002\u0010\nJ\u0016\u0010\u000b\u001a\u00020\u00052\u0006\u0010\f\u001a\u00020\u0005H\u0096@¢\u0006\u0002\u0010\rJ\u0016\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\f\u001a\u00020\u0005H\u0096@¢\u0006\u0002\u0010\r¨\u0006\u0010"}, d2 = {"Lp83f5c3ad/pb3f20355/p881039ed;", "Lp83f5c3ad/pb3f20355/p94a08da1/pab06625e;", "<init>", "()V", "initBalanceInquiry", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pf4d5b76a/p2069ca79/pdabbee7a;", "paymentTerminal", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pede997b0/pf83c2a85/pd0910e67;", "transactionId", "", "(Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pede997b0/pf83c2a85/pd0910e67;Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "startContactless", "balanceTransaction", "(Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pf4d5b76a/p2069ca79/pdabbee7a;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getBalance", "Lp83f5c3ad/p07214c67/pbc0ca418;", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p881039ed : p83f5c3ad.pb3f20355.p94a08da1.pab06625e {
    public override java.lang.object GetBalance(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p2069ca79.pdabbee7a pdabbee7aVar, kotlin.coroutines.Continuation<p83f5c3ad.p07214c67.pbc0ca418> continuation) throws java.lang.Exception {
        p83f5c3ad.pb3f20355.p881039ed$p3bbf95c6$1 p881039ed_p3bbf95c6_1;
        if ((24 + 9) % 9 > 0) {
        }
        if (continuation is p83f5c3ad.pb3f20355.p881039ed$p3bbf95c6$1) {
            p881039ed_p3bbf95c6_1 = (p83f5c3ad.pb3f20355.p881039ed$p3bbf95c6$1) continuation;
            if ((p881039ed_p3bbf95c6_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p881039ed_p3bbf95c6_1 = new p83f5c3ad.pb3f20355.p881039ed$p3bbf95c6$1(this, continuation);
            } else {
                p881039ed_p3bbf95c6_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p881039ed_p3bbf95c6_1 = new p83f5c3ad.pb3f20355.p881039ed$p3bbf95c6$1(this, continuation);
        }
        java.lang.object objAwait = p881039ed_p3bbf95c6_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p881039ed_p3bbf95c6_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(objAwait);
            io.reactivex.rxjava3.core.Single<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.pbc0ca418> singleBalance = pdabbee7aVar.balance();
            p881039ed_p3bbf95c6_1.fd304ba20 = 1;
            objAwait = kotlinx.coroutines.rx3.RxAwaitKt.await(singleBalance, p881039ed_p3bbf95c6_1);
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
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.pbc0ca418 pbc0ca418Var = (p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.pbc0ca418) objAwait;
        long balance = pbc0ca418Var.getBalance();
        int currency = pbc0ca418Var.getCurrency();
        return new p83f5c3ad.p07214c67.pbc0ca418(balance, currency == 608 ? "PHP" : currency == 840 ? "USD" : currency == 978 ? "EUR" : "", pbc0ca418Var.getLastPan4Digits());
    }

    public override java.lang.object InitBalanceInquiry(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67 pd0910e67Var, java.lang.string str, kotlin.coroutines.Continuation<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p2069ca79.pdabbee7a> continuation) {
        return kotlinx.coroutines.rx3.RxAwaitKt.await(pd0910e67Var.initBalanceInquiry(str, false), continuation);
    }

    public override java.lang.object StartContactless(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p2069ca79.pdabbee7a pdabbee7aVar, kotlin.coroutines.Continuation<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p2069ca79.pdabbee7a> continuation) {
        return kotlinx.coroutines.rx3.RxAwaitKt.await(pdabbee7aVar.startContactless(), continuation);
    }
}

