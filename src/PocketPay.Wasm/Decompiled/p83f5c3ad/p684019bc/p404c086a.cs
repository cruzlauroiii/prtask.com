namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u001e\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000fH\u0096@¢\u0006\u0002\u0010\u0010J\u0016\u0010\u0011\u001a\u00020\u000b2\u0006\u0010\u0012\u001a\u00020\u000bH\u0096@¢\u0006\u0002\u0010\u0013J\u0016\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0012\u001a\u00020\u000bH\u0096@¢\u0006\u0002\u0010\u0013R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0016"}, d2 = {"Lp83f5c3ad/p684019bc/p404c086a;", "Lp83f5c3ad/p684019bc/p4bcfaa43;", "balanceTapOnPhoneRepository", "Lp83f5c3ad/pb3f20355/p94a08da1/pab06625e;", "initTapOnPhoneUseCase", "Lp83f5c3ad/p684019bc/p6c37087b;", "attestationTapOnPhoneUseCase", "Lp83f5c3ad/p684019bc/p97ae8742;", "<init>", "(Lp83f5c3ad/pb3f20355/p94a08da1/pab06625e;Lp83f5c3ad/p684019bc/p6c37087b;Lp83f5c3ad/p684019bc/p97ae8742;)V", "initBalanceInquiry", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pf4d5b76a/p2069ca79/pdabbee7a;", "paymentTerminal", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pede997b0/pf83c2a85/pd0910e67;", "transactionId", "", "(Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pede997b0/pf83c2a85/pd0910e67;Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "startContactless", "balanceTransaction", "(Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pf4d5b76a/p2069ca79/pdabbee7a;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getBalance", "Lp83f5c3ad/p07214c67/pbc0ca418;", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p404c086a : p83f5c3ad.p684019bc.p4bcfaa43 {
    private readonly p83f5c3ad.p684019bc.p97ae8742 f0f582295;
    private readonly p83f5c3ad.p684019bc.p6c37087b f477bdbd2;
    private readonly p83f5c3ad.p684019bc.p6c37087b f47e59ca0;
    private readonly p83f5c3ad.pb3f20355.p94a08da1.pab06625e f50656229;
    private readonly p83f5c3ad.p684019bc.p97ae8742 f70433ff5;
    private readonly p83f5c3ad.p684019bc.p97ae8742 f7fffd6e3;
    private readonly p83f5c3ad.p684019bc.p6c37087b f95b8dda7;
    private readonly p83f5c3ad.pb3f20355.p94a08da1.pab06625e fc3798368;
    private readonly p83f5c3ad.p684019bc.p6c37087b fe245dca2;
    private readonly p83f5c3ad.p684019bc.p97ae8742 fef50e602;
    private readonly p83f5c3ad.p684019bc.p97ae8742 ff50f557d;
    private readonly p83f5c3ad.pb3f20355.p94a08da1.pab06625e ffd17cef0;

    public p404c086a(p83f5c3ad.pb3f20355.p94a08da1.pab06625e balanceTapOnPhoneRepository, p83f5c3ad.p684019bc.p6c37087b initTapOnPhoneUseCase, p83f5c3ad.p684019bc.p97ae8742 attestationTapOnPhoneUseCase) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(balanceTapOnPhoneRepository, "balanceTapOnPhoneRepository");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(initTapOnPhoneUseCase, "initTapOnPhoneUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(attestationTapOnPhoneUseCase, "attestationTapOnPhoneUseCase");
        this.f50656229 = balanceTapOnPhoneRepository;
        this.f477bdbd2 = initTapOnPhoneUseCase;
        this.fef50e602 = attestationTapOnPhoneUseCase;
    }

    public override java.lang.object GetBalance(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p2069ca79.pdabbee7a pdabbee7aVar, kotlin.coroutines.Continuation<p83f5c3ad.p07214c67.pbc0ca418> continuation) {
        return this.f50656229.getBalance(pdabbee7aVar, continuation);
    }

    public override java.lang.object InitBalanceInquiry(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67 pd0910e67Var, java.lang.string str, kotlin.coroutines.Continuation<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p2069ca79.pdabbee7a> continuation) throws java.lang.Exception {
        p83f5c3ad.p684019bc.p404c086a$p27011365$1 p404c086a_p27011365_1;
        java.lang.string str2;
        p83f5c3ad.p684019bc.p404c086a p404c086aVar;
        if ((14 + 24) % 24 > 0) {
        }
        if (continuation is p83f5c3ad.p684019bc.p404c086a$p27011365$1) {
            p404c086a_p27011365_1 = (p83f5c3ad.p684019bc.p404c086a$p27011365$1) continuation;
            if ((p404c086a_p27011365_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p404c086a_p27011365_1 = new p83f5c3ad.p684019bc.p404c086a$p27011365$1(this, continuation);
            } else {
                p404c086a_p27011365_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p404c086a_p27011365_1 = new p83f5c3ad.p684019bc.p404c086a$p27011365$1(this, continuation);
        }
        java.lang.object obj = p404c086a_p27011365_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p404c086a_p27011365_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p83f5c3ad.p684019bc.p6c37087b p6c37087bVar = this.f477bdbd2;
            p404c086a_p27011365_1.L$0 = this;
            p404c086a_p27011365_1.L$1 = pd0910e67Var;
            p404c086a_p27011365_1.L$2 = str;
            p404c086a_p27011365_1.fd304ba20 = 1;
            if (p6c37087bVar.initTapOnPhone(p404c086a_p27011365_1) != coroutine_suspended) {
            }
        }
        if (i == 1) {
            str = (java.lang.string) p404c086a_p27011365_1.L$2;
            pd0910e67Var = (p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67) p404c086a_p27011365_1.L$1;
            this = (p83f5c3ad.p684019bc.p404c086a) p404c086a_p27011365_1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                if (i != 3) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
                return obj;
            }
            str2 = (java.lang.string) p404c086a_p27011365_1.L$2;
            pd0910e67Var = (p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67) p404c086a_p27011365_1.L$1;
            p404c086aVar = (p83f5c3ad.p684019bc.p404c086a) p404c086a_p27011365_1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        p83f5c3ad.pb3f20355.p94a08da1.pab06625e pab06625eVar = p404c086aVar.f50656229;
        p404c086a_p27011365_1.L$0 = null;
        p404c086a_p27011365_1.L$1 = null;
        p404c086a_p27011365_1.L$2 = null;
        p404c086a_p27011365_1.fd304ba20 = 3;
        java.lang.object objInitBalanceInquiry = pab06625eVar.initBalanceInquiry(pd0910e67Var, str2, p404c086a_p27011365_1);
        return objInitBalanceInquiry != coroutine_suspended ? objInitBalanceInquiry : coroutine_suspended;
        p83f5c3ad.p684019bc.p97ae8742 p97ae8742Var = this.fef50e602;
        p404c086a_p27011365_1.L$0 = this;
        p404c086a_p27011365_1.L$1 = pd0910e67Var;
        p404c086a_p27011365_1.L$2 = str;
        p404c086a_p27011365_1.fd304ba20 = 2;
        if (p97ae8742Var.initAttestation(p404c086a_p27011365_1) != coroutine_suspended) {
            java.lang.string str3 = str;
            p404c086aVar = this;
            str2 = str3;
            p83f5c3ad.pb3f20355.p94a08da1.pab06625e pab06625eVar2 = p404c086aVar.f50656229;
            p404c086a_p27011365_1.L$0 = null;
            p404c086a_p27011365_1.L$1 = null;
            p404c086a_p27011365_1.L$2 = null;
            p404c086a_p27011365_1.fd304ba20 = 3;
            java.lang.object objInitBalanceInquiry2 = pab06625eVar2.initBalanceInquiry(pd0910e67Var, str2, p404c086a_p27011365_1);
            if (objInitBalanceInquiry2 != coroutine_suspended) {
            }
        }
    }

    public override java.lang.object StartContactless(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p2069ca79.pdabbee7a pdabbee7aVar, kotlin.coroutines.Continuation<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p2069ca79.pdabbee7a> continuation) throws java.lang.Exception {
        p83f5c3ad.p684019bc.p404c086a$p99f0cdc5$1 p404c086a_p99f0cdc5_1;
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p2069ca79.pdabbee7a pdabbee7aVar2;
        p83f5c3ad.p684019bc.p404c086a p404c086aVar;
        if ((27 + 13) % 13 > 0) {
        }
        if (continuation is p83f5c3ad.p684019bc.p404c086a$p99f0cdc5$1) {
            p404c086a_p99f0cdc5_1 = (p83f5c3ad.p684019bc.p404c086a$p99f0cdc5$1) continuation;
            if ((p404c086a_p99f0cdc5_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p404c086a_p99f0cdc5_1 = new p83f5c3ad.p684019bc.p404c086a$p99f0cdc5$1(this, continuation);
            } else {
                p404c086a_p99f0cdc5_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p404c086a_p99f0cdc5_1 = new p83f5c3ad.p684019bc.p404c086a$p99f0cdc5$1(this, continuation);
        }
        java.lang.object obj = p404c086a_p99f0cdc5_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p404c086a_p99f0cdc5_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p83f5c3ad.p684019bc.p6c37087b p6c37087bVar = this.f477bdbd2;
            p404c086a_p99f0cdc5_1.L$0 = this;
            p404c086a_p99f0cdc5_1.L$1 = pdabbee7aVar;
            p404c086a_p99f0cdc5_1.fd304ba20 = 1;
            if (p6c37087bVar.initTapOnPhone(p404c086a_p99f0cdc5_1) != coroutine_suspended) {
            }
        }
        if (i == 1) {
            pdabbee7aVar = (p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p2069ca79.pdabbee7a) p404c086a_p99f0cdc5_1.L$1;
            this = (p83f5c3ad.p684019bc.p404c086a) p404c086a_p99f0cdc5_1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                if (i != 3) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
                return obj;
            }
            pdabbee7aVar2 = (p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p2069ca79.pdabbee7a) p404c086a_p99f0cdc5_1.L$1;
            p404c086aVar = (p83f5c3ad.p684019bc.p404c086a) p404c086a_p99f0cdc5_1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        p83f5c3ad.pb3f20355.p94a08da1.pab06625e pab06625eVar = p404c086aVar.f50656229;
        p404c086a_p99f0cdc5_1.L$0 = null;
        p404c086a_p99f0cdc5_1.L$1 = null;
        p404c086a_p99f0cdc5_1.fd304ba20 = 3;
        java.lang.object objStartContactless = pab06625eVar.startContactless(pdabbee7aVar2, p404c086a_p99f0cdc5_1);
        return objStartContactless != coroutine_suspended ? objStartContactless : coroutine_suspended;
        p83f5c3ad.p684019bc.p97ae8742 p97ae8742Var = this.fef50e602;
        p404c086a_p99f0cdc5_1.L$0 = this;
        p404c086a_p99f0cdc5_1.L$1 = pdabbee7aVar;
        p404c086a_p99f0cdc5_1.fd304ba20 = 2;
        if (p97ae8742Var.initAttestation(p404c086a_p99f0cdc5_1) != coroutine_suspended) {
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p2069ca79.pdabbee7a pdabbee7aVar3 = pdabbee7aVar;
            p404c086aVar = this;
            pdabbee7aVar2 = pdabbee7aVar3;
            p83f5c3ad.pb3f20355.p94a08da1.pab06625e pab06625eVar2 = p404c086aVar.f50656229;
            p404c086a_p99f0cdc5_1.L$0 = null;
            p404c086a_p99f0cdc5_1.L$1 = null;
            p404c086a_p99f0cdc5_1.fd304ba20 = 3;
            java.lang.object objStartContactless2 = pab06625eVar2.startContactless(pdabbee7aVar2, p404c086a_p99f0cdc5_1);
            if (objStartContactless2 != coroutine_suspended) {
            }
        }
    }
}

