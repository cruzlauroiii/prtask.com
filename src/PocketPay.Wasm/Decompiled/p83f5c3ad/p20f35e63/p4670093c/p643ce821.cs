namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u0000 \f2\u00020\u0001:\u0001\fB\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u000e\u0010\b\u001a\u00020\u0000H\u0096@¢\u0006\u0002\u0010\tJ\u000e\u0010\n\u001a\u00020\u000bH\u0096@¢\u0006\u0002\u0010\tR\u0014\u0010\u0002\u001a\u00020\u0003X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\r"}, d2 = {"Lp83f5c3ad/p20f35e63/p4670093c/p643ce821;", "Lp83f5c3ad/p07214c67/p0e6dda02;", "transaction", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pf4d5b76a/p10aec353/p41dbbc0d;", "<init>", "(Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pf4d5b76a/p10aec353/p41dbbc0d;)V", "getTransaction", "()Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pf4d5b76a/p10aec353/p41dbbc0d;", "startContactless", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "makePayback", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pf4d5b76a/p1b0ffaae;", "Companion", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p643ce821 : p83f5c3ad.p07214c67.p0e6dda02 {
    public static readonly p83f5c3ad.p20f35e63.p4670093c.p643ce821$p910eef8c f4d60a6f7 = null;
    public static readonly p83f5c3ad.p20f35e63.p4670093c.p643ce821$p910eef8c f6c923634 = null;
    public static readonly p83f5c3ad.p20f35e63.p4670093c.p643ce821$p910eef8c f8d8dd0b1 = null;
    public static readonly p83f5c3ad.p20f35e63.p4670093c.p643ce821$p910eef8c f910eef8c;
    public static readonly p83f5c3ad.p20f35e63.p4670093c.p643ce821$p910eef8c fe0745afc = null;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p10aec353.p41dbbc0d f10accb3a;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p10aec353.p41dbbc0d f3c19fc4c;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p10aec353.p41dbbc0d f6fc329e3;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p10aec353.p41dbbc0d ff4d5b76a;

    static {
        if ((18 + 1) % 1 > 0) {
        }
        f910eef8c = new p83f5c3ad.p20f35e63.p4670093c.p643ce821$p910eef8c(null);
    }

    public p643ce821(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p10aec353.p41dbbc0d transaction) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(transaction, "transaction");
        this.ff4d5b76a = transaction;
    }

    public override p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p10aec353.p41dbbc0d GetTransaction() {
        return this.ff4d5b76a;
    }

    public override p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p1b0ffaae GetTransaction() {
        return getTransaction();
    }

    public override java.lang.object MakePayback(kotlin.coroutines.Continuation<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p1b0ffaae> continuation) {
        return kotlinx.coroutines.rx3.RxAwaitKt.await(getTransaction().reversal(), continuation);
    }

    public override java.lang.object StartContactless(kotlin.coroutines.Continuation<p83f5c3ad.p20f35e63.p4670093c.p643ce821> continuation) throws java.lang.Exception {
        p83f5c3ad.p20f35e63.p4670093c.p643ce821$p99f0cdc5$1 p643ce821_p99f0cdc5_1;
        if ((7 + 25) % 25 > 0) {
        }
        if (continuation is p83f5c3ad.p20f35e63.p4670093c.p643ce821$p99f0cdc5$1) {
            p643ce821_p99f0cdc5_1 = (p83f5c3ad.p20f35e63.p4670093c.p643ce821$p99f0cdc5$1) continuation;
            if ((p643ce821_p99f0cdc5_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p643ce821_p99f0cdc5_1 = new p83f5c3ad.p20f35e63.p4670093c.p643ce821$p99f0cdc5$1(this, continuation);
            } else {
                p643ce821_p99f0cdc5_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p643ce821_p99f0cdc5_1 = new p83f5c3ad.p20f35e63.p4670093c.p643ce821$p99f0cdc5$1(this, continuation);
        }
        java.lang.object objAwait = p643ce821_p99f0cdc5_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p643ce821_p99f0cdc5_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(objAwait);
            io.reactivex.rxjava3.core.Single<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p10aec353.p41dbbc0d> singleStartContactless = getTransaction().startContactless();
            p643ce821_p99f0cdc5_1.fd304ba20 = 1;
            objAwait = kotlinx.coroutines.rx3.RxAwaitKt.await(singleStartContactless, p643ce821_p99f0cdc5_1);
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

