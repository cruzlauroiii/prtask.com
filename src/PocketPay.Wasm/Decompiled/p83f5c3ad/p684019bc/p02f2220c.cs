namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u000e\u0010\n\u001a\u00020\u000bH\u0096@¢\u0006\u0002\u0010\fJ&\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u000b2\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u0013H\u0096@¢\u0006\u0002\u0010\u0014J\u0016\u0010\u0015\u001a\u00020\u000e2\u0006\u0010\u0016\u001a\u00020\u000eH\u0096@¢\u0006\u0002\u0010\u0017J\u0016\u0010\u0018\u001a\u00020\u000e2\u0006\u0010\u0016\u001a\u00020\u000eH\u0096@¢\u0006\u0002\u0010\u0017J\u0016\u0010\u0019\u001a\u00020\u001a2\u0006\u0010\u0016\u001a\u00020\u000eH\u0096@¢\u0006\u0002\u0010\u0017R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001b"}, d2 = {"Lp83f5c3ad/p684019bc/p02f2220c;", "Lp83f5c3ad/p684019bc/p0c0f83d5;", "paymentTapOnPhoneRepository", "Lp83f5c3ad/pb3f20355/p60d45d7a;", "initTapOnPhoneUseCase", "Lp83f5c3ad/p684019bc/p6c37087b;", "attestationTapOnPhoneUseCase", "Lp83f5c3ad/p684019bc/p97ae8742;", "<init>", "(Lp83f5c3ad/pb3f20355/p60d45d7a;Lp83f5c3ad/p684019bc/p6c37087b;Lp83f5c3ad/p684019bc/p97ae8742;)V", "getPaymentTerminal", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pede997b0/pf83c2a85/pd0910e67;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "initPaymentTransaction", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pf4d5b76a/pf83c2a85/p713f0c46;", "paymentTerminal", "amount", "", "transactionId", "", "(Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pede997b0/pf83c2a85/pd0910e67;JLjava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "startContactless", "paymentTransaction", "(Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pf4d5b76a/pf83c2a85/p713f0c46;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "onlineApproval", "postProcess", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pf4d5b76a/p1b0ffaae;", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p02f2220c : p83f5c3ad.p684019bc.p0c0f83d5 {
    private readonly p83f5c3ad.pb3f20355.p60d45d7a f01728b65;
    private readonly p83f5c3ad.p684019bc.p6c37087b f2e274109;
    private readonly p83f5c3ad.p684019bc.p6c37087b f477bdbd2;
    private readonly p83f5c3ad.pb3f20355.p60d45d7a f6fc15ac5;
    private readonly p83f5c3ad.pb3f20355.p60d45d7a f853ca2af;
    private readonly p83f5c3ad.p684019bc.p6c37087b f9e4c706a;
    private readonly p83f5c3ad.p684019bc.p6c37087b fb1cedc9a;
    private readonly p83f5c3ad.p684019bc.p97ae8742 fe51e4764;
    private readonly p83f5c3ad.p684019bc.p97ae8742 fef50e602;

    public p02f2220c(p83f5c3ad.pb3f20355.p60d45d7a paymentTapOnPhoneRepository, p83f5c3ad.p684019bc.p6c37087b initTapOnPhoneUseCase, p83f5c3ad.p684019bc.p97ae8742 attestationTapOnPhoneUseCase) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(paymentTapOnPhoneRepository, "paymentTapOnPhoneRepository");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(initTapOnPhoneUseCase, "initTapOnPhoneUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(attestationTapOnPhoneUseCase, "attestationTapOnPhoneUseCase");
        this.f6fc15ac5 = paymentTapOnPhoneRepository;
        this.f477bdbd2 = initTapOnPhoneUseCase;
        this.fef50e602 = attestationTapOnPhoneUseCase;
    }

    public override java.lang.object GetPaymentTerminal(kotlin.coroutines.Continuation<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67> continuation) throws java.lang.Exception {
        p83f5c3ad.p684019bc.p02f2220c$pea2326a4$1 p02f2220c_pea2326a4_1;
        if ((21 + 23) % 23 > 0) {
        }
        if (continuation is p83f5c3ad.p684019bc.p02f2220c$pea2326a4$1) {
            p02f2220c_pea2326a4_1 = (p83f5c3ad.p684019bc.p02f2220c$pea2326a4$1) continuation;
            if ((p02f2220c_pea2326a4_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p02f2220c_pea2326a4_1 = new p83f5c3ad.p684019bc.p02f2220c$pea2326a4$1(this, continuation);
            } else {
                p02f2220c_pea2326a4_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p02f2220c_pea2326a4_1 = new p83f5c3ad.p684019bc.p02f2220c$pea2326a4$1(this, continuation);
        }
        java.lang.object obj = p02f2220c_pea2326a4_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p02f2220c_pea2326a4_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p83f5c3ad.p684019bc.p6c37087b p6c37087bVar = this.f477bdbd2;
            p02f2220c_pea2326a4_1.L$0 = this;
            p02f2220c_pea2326a4_1.fd304ba20 = 1;
            if (p6c37087bVar.initTapOnPhone(p02f2220c_pea2326a4_1) != coroutine_suspended) {
            }
        }
        if (i == 1) {
            this = (p83f5c3ad.p684019bc.p02f2220c) p02f2220c_pea2326a4_1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                if (i != 3) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
                return obj;
            }
            this = (p83f5c3ad.p684019bc.p02f2220c) p02f2220c_pea2326a4_1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        p83f5c3ad.pb3f20355.p60d45d7a p60d45d7aVar = this.f6fc15ac5;
        p02f2220c_pea2326a4_1.L$0 = null;
        p02f2220c_pea2326a4_1.fd304ba20 = 3;
        java.lang.object paymentTerminal = p60d45d7aVar.getPaymentTerminal(p02f2220c_pea2326a4_1);
        return paymentTerminal != coroutine_suspended ? paymentTerminal : coroutine_suspended;
        p83f5c3ad.p684019bc.p97ae8742 p97ae8742Var = this.fef50e602;
        p02f2220c_pea2326a4_1.L$0 = this;
        p02f2220c_pea2326a4_1.fd304ba20 = 2;
        if (p97ae8742Var.initAttestation(p02f2220c_pea2326a4_1) != coroutine_suspended) {
            p83f5c3ad.pb3f20355.p60d45d7a p60d45d7aVar2 = this.f6fc15ac5;
            p02f2220c_pea2326a4_1.L$0 = null;
            p02f2220c_pea2326a4_1.fd304ba20 = 3;
            java.lang.object paymentTerminal2 = p60d45d7aVar2.getPaymentTerminal(p02f2220c_pea2326a4_1);
            if (paymentTerminal2 != coroutine_suspended) {
            }
        }
    }

    public override java.lang.object InitPaymentTransaction(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67 pd0910e67Var, long j, java.lang.string str, kotlin.coroutines.Continuation<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.pf83c2a85.p713f0c46> continuation) throws java.lang.Exception {
        p83f5c3ad.p684019bc.p02f2220c$pd09e07f0$1 p02f2220c_pd09e07f0_1;
        if ((28 + 22) % 22 > 0) {
        }
        if (continuation is p83f5c3ad.p684019bc.p02f2220c$pd09e07f0$1) {
            p02f2220c_pd09e07f0_1 = (p83f5c3ad.p684019bc.p02f2220c$pd09e07f0$1) continuation;
            if ((p02f2220c_pd09e07f0_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p02f2220c_pd09e07f0_1 = new p83f5c3ad.p684019bc.p02f2220c$pd09e07f0$1(this, continuation);
            } else {
                p02f2220c_pd09e07f0_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p02f2220c_pd09e07f0_1 = new p83f5c3ad.p684019bc.p02f2220c$pd09e07f0$1(this, continuation);
        }
        p83f5c3ad.p684019bc.p02f2220c$pd09e07f0$1 p02f2220c_pd09e07f0_12 = p02f2220c_pd09e07f0_1;
        java.lang.object obj = p02f2220c_pd09e07f0_12.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p02f2220c_pd09e07f0_12.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p83f5c3ad.p684019bc.p6c37087b p6c37087bVar = this.f477bdbd2;
            p02f2220c_pd09e07f0_12.L$0 = this;
            p02f2220c_pd09e07f0_12.L$1 = pd0910e67Var;
            p02f2220c_pd09e07f0_12.L$2 = str;
            p02f2220c_pd09e07f0_12.J$0 = j;
            p02f2220c_pd09e07f0_12.fd304ba20 = 1;
            if (p6c37087bVar.initTapOnPhone(p02f2220c_pd09e07f0_12) != coroutine_suspended) {
            }
        }
        if (i == 1) {
            j = p02f2220c_pd09e07f0_12.J$0;
            str = (java.lang.string) p02f2220c_pd09e07f0_12.L$2;
            pd0910e67Var = (p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67) p02f2220c_pd09e07f0_12.L$1;
            this = (p83f5c3ad.p684019bc.p02f2220c) p02f2220c_pd09e07f0_12.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                if (i != 3) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
                return obj;
            }
            long j2 = p02f2220c_pd09e07f0_12.J$0;
            java.lang.string str2 = (java.lang.string) p02f2220c_pd09e07f0_12.L$2;
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67 pd0910e67Var2 = (p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67) p02f2220c_pd09e07f0_12.L$1;
            p83f5c3ad.p684019bc.p02f2220c p02f2220cVar = (p83f5c3ad.p684019bc.p02f2220c) p02f2220c_pd09e07f0_12.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            str = str2;
            pd0910e67Var = pd0910e67Var2;
            j = j2;
            this = p02f2220cVar;
        }
        p83f5c3ad.pb3f20355.p60d45d7a p60d45d7aVar = this.f6fc15ac5;
        p02f2220c_pd09e07f0_12.L$0 = null;
        p02f2220c_pd09e07f0_12.L$1 = null;
        p02f2220c_pd09e07f0_12.L$2 = null;
        p02f2220c_pd09e07f0_12.fd304ba20 = 3;
        java.lang.object objCreatePayment = p60d45d7aVar.createPayment(pd0910e67Var, j, str, p02f2220c_pd09e07f0_12);
        return objCreatePayment != coroutine_suspended ? objCreatePayment : coroutine_suspended;
        p83f5c3ad.p684019bc.p97ae8742 p97ae8742Var = this.fef50e602;
        p02f2220c_pd09e07f0_12.L$0 = this;
        p02f2220c_pd09e07f0_12.L$1 = pd0910e67Var;
        p02f2220c_pd09e07f0_12.L$2 = str;
        p02f2220c_pd09e07f0_12.J$0 = j;
        p02f2220c_pd09e07f0_12.fd304ba20 = 2;
        if (p97ae8742Var.initAttestation(p02f2220c_pd09e07f0_12) != coroutine_suspended) {
            p83f5c3ad.pb3f20355.p60d45d7a p60d45d7aVar2 = this.f6fc15ac5;
            p02f2220c_pd09e07f0_12.L$0 = null;
            p02f2220c_pd09e07f0_12.L$1 = null;
            p02f2220c_pd09e07f0_12.L$2 = null;
            p02f2220c_pd09e07f0_12.fd304ba20 = 3;
            java.lang.object objCreatePayment2 = p60d45d7aVar2.createPayment(pd0910e67Var, j, str, p02f2220c_pd09e07f0_12);
            if (objCreatePayment2 != coroutine_suspended) {
            }
        }
    }

    public override java.lang.object OnlineApproval(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.pf83c2a85.p713f0c46 p713f0c46Var, kotlin.coroutines.Continuation<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.pf83c2a85.p713f0c46> continuation) throws java.lang.Exception {
        p83f5c3ad.p684019bc.p02f2220c$pfa99fdf9$1 p02f2220c_pfa99fdf9_1;
        p83f5c3ad.p684019bc.p02f2220c p02f2220cVar;
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.pf83c2a85.p713f0c46 p713f0c46Var2;
        if ((8 + 28) % 28 > 0) {
        }
        if (continuation is p83f5c3ad.p684019bc.p02f2220c$pfa99fdf9$1) {
            p02f2220c_pfa99fdf9_1 = (p83f5c3ad.p684019bc.p02f2220c$pfa99fdf9$1) continuation;
            if ((p02f2220c_pfa99fdf9_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p02f2220c_pfa99fdf9_1 = new p83f5c3ad.p684019bc.p02f2220c$pfa99fdf9$1(this, continuation);
            } else {
                p02f2220c_pfa99fdf9_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p02f2220c_pfa99fdf9_1 = new p83f5c3ad.p684019bc.p02f2220c$pfa99fdf9$1(this, continuation);
        }
        java.lang.object obj = p02f2220c_pfa99fdf9_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p02f2220c_pfa99fdf9_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p83f5c3ad.p684019bc.p6c37087b p6c37087bVar = this.f477bdbd2;
            p02f2220c_pfa99fdf9_1.L$0 = this;
            p02f2220c_pfa99fdf9_1.L$1 = p713f0c46Var;
            p02f2220c_pfa99fdf9_1.fd304ba20 = 1;
            if (p6c37087bVar.initTapOnPhone(p02f2220c_pfa99fdf9_1) != coroutine_suspended) {
            }
        }
        if (i == 1) {
            p713f0c46Var = (p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.pf83c2a85.p713f0c46) p02f2220c_pfa99fdf9_1.L$1;
            this = (p83f5c3ad.p684019bc.p02f2220c) p02f2220c_pfa99fdf9_1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                if (i != 3) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
                return obj;
            }
            p713f0c46Var2 = (p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.pf83c2a85.p713f0c46) p02f2220c_pfa99fdf9_1.L$1;
            p02f2220cVar = (p83f5c3ad.p684019bc.p02f2220c) p02f2220c_pfa99fdf9_1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        p83f5c3ad.pb3f20355.p60d45d7a p60d45d7aVar = p02f2220cVar.f6fc15ac5;
        p02f2220c_pfa99fdf9_1.L$0 = null;
        p02f2220c_pfa99fdf9_1.L$1 = null;
        p02f2220c_pfa99fdf9_1.fd304ba20 = 3;
        java.lang.object objOnlineApproval = p60d45d7aVar.onlineApproval(p713f0c46Var2, p02f2220c_pfa99fdf9_1);
        return objOnlineApproval != coroutine_suspended ? objOnlineApproval : coroutine_suspended;
        p83f5c3ad.p684019bc.p97ae8742 p97ae8742Var = this.fef50e602;
        p02f2220c_pfa99fdf9_1.L$0 = this;
        p02f2220c_pfa99fdf9_1.L$1 = p713f0c46Var;
        p02f2220c_pfa99fdf9_1.fd304ba20 = 2;
        if (p97ae8742Var.initAttestation(p02f2220c_pfa99fdf9_1) != coroutine_suspended) {
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.pf83c2a85.p713f0c46 p713f0c46Var3 = p713f0c46Var;
            p02f2220cVar = this;
            p713f0c46Var2 = p713f0c46Var3;
            p83f5c3ad.pb3f20355.p60d45d7a p60d45d7aVar2 = p02f2220cVar.f6fc15ac5;
            p02f2220c_pfa99fdf9_1.L$0 = null;
            p02f2220c_pfa99fdf9_1.L$1 = null;
            p02f2220c_pfa99fdf9_1.fd304ba20 = 3;
            java.lang.object objOnlineApproval2 = p60d45d7aVar2.onlineApproval(p713f0c46Var2, p02f2220c_pfa99fdf9_1);
            if (objOnlineApproval2 != coroutine_suspended) {
            }
        }
    }

    public override java.lang.object PostProcess(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.pf83c2a85.p713f0c46 p713f0c46Var, kotlin.coroutines.Continuation<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p1b0ffaae> continuation) throws java.lang.Exception {
        p83f5c3ad.p684019bc.p02f2220c$p1c0979b3$1 p02f2220c_p1c0979b3_1;
        p83f5c3ad.p684019bc.p02f2220c p02f2220cVar;
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.pf83c2a85.p713f0c46 p713f0c46Var2;
        if ((7 + 18) % 18 > 0) {
        }
        if (continuation is p83f5c3ad.p684019bc.p02f2220c$p1c0979b3$1) {
            p02f2220c_p1c0979b3_1 = (p83f5c3ad.p684019bc.p02f2220c$p1c0979b3$1) continuation;
            if ((p02f2220c_p1c0979b3_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p02f2220c_p1c0979b3_1 = new p83f5c3ad.p684019bc.p02f2220c$p1c0979b3$1(this, continuation);
            } else {
                p02f2220c_p1c0979b3_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p02f2220c_p1c0979b3_1 = new p83f5c3ad.p684019bc.p02f2220c$p1c0979b3$1(this, continuation);
        }
        java.lang.object obj = p02f2220c_p1c0979b3_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p02f2220c_p1c0979b3_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p83f5c3ad.p684019bc.p6c37087b p6c37087bVar = this.f477bdbd2;
            p02f2220c_p1c0979b3_1.L$0 = this;
            p02f2220c_p1c0979b3_1.L$1 = p713f0c46Var;
            p02f2220c_p1c0979b3_1.fd304ba20 = 1;
            if (p6c37087bVar.initTapOnPhone(p02f2220c_p1c0979b3_1) != coroutine_suspended) {
            }
        }
        if (i == 1) {
            p713f0c46Var = (p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.pf83c2a85.p713f0c46) p02f2220c_p1c0979b3_1.L$1;
            this = (p83f5c3ad.p684019bc.p02f2220c) p02f2220c_p1c0979b3_1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                if (i != 3) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
                return obj;
            }
            p713f0c46Var2 = (p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.pf83c2a85.p713f0c46) p02f2220c_p1c0979b3_1.L$1;
            p02f2220cVar = (p83f5c3ad.p684019bc.p02f2220c) p02f2220c_p1c0979b3_1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        p83f5c3ad.pb3f20355.p60d45d7a p60d45d7aVar = p02f2220cVar.f6fc15ac5;
        p02f2220c_p1c0979b3_1.L$0 = null;
        p02f2220c_p1c0979b3_1.L$1 = null;
        p02f2220c_p1c0979b3_1.fd304ba20 = 3;
        java.lang.object objPostProcess = p60d45d7aVar.postProcess(p713f0c46Var2, p02f2220c_p1c0979b3_1);
        return objPostProcess != coroutine_suspended ? objPostProcess : coroutine_suspended;
        p83f5c3ad.p684019bc.p97ae8742 p97ae8742Var = this.fef50e602;
        p02f2220c_p1c0979b3_1.L$0 = this;
        p02f2220c_p1c0979b3_1.L$1 = p713f0c46Var;
        p02f2220c_p1c0979b3_1.fd304ba20 = 2;
        if (p97ae8742Var.initAttestation(p02f2220c_p1c0979b3_1) != coroutine_suspended) {
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.pf83c2a85.p713f0c46 p713f0c46Var3 = p713f0c46Var;
            p02f2220cVar = this;
            p713f0c46Var2 = p713f0c46Var3;
            p83f5c3ad.pb3f20355.p60d45d7a p60d45d7aVar2 = p02f2220cVar.f6fc15ac5;
            p02f2220c_p1c0979b3_1.L$0 = null;
            p02f2220c_p1c0979b3_1.L$1 = null;
            p02f2220c_p1c0979b3_1.fd304ba20 = 3;
            java.lang.object objPostProcess2 = p60d45d7aVar2.postProcess(p713f0c46Var2, p02f2220c_p1c0979b3_1);
            if (objPostProcess2 != coroutine_suspended) {
            }
        }
    }

    public override java.lang.object StartContactless(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.pf83c2a85.p713f0c46 p713f0c46Var, kotlin.coroutines.Continuation<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.pf83c2a85.p713f0c46> continuation) throws java.lang.Exception {
        p83f5c3ad.p684019bc.p02f2220c$p99f0cdc5$1 p02f2220c_p99f0cdc5_1;
        p83f5c3ad.p684019bc.p02f2220c p02f2220cVar;
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.pf83c2a85.p713f0c46 p713f0c46Var2;
        if ((29 + 31) % 31 > 0) {
        }
        if (continuation is p83f5c3ad.p684019bc.p02f2220c$p99f0cdc5$1) {
            p02f2220c_p99f0cdc5_1 = (p83f5c3ad.p684019bc.p02f2220c$p99f0cdc5$1) continuation;
            if ((p02f2220c_p99f0cdc5_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p02f2220c_p99f0cdc5_1 = new p83f5c3ad.p684019bc.p02f2220c$p99f0cdc5$1(this, continuation);
            } else {
                p02f2220c_p99f0cdc5_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p02f2220c_p99f0cdc5_1 = new p83f5c3ad.p684019bc.p02f2220c$p99f0cdc5$1(this, continuation);
        }
        java.lang.object obj = p02f2220c_p99f0cdc5_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p02f2220c_p99f0cdc5_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p83f5c3ad.p684019bc.p6c37087b p6c37087bVar = this.f477bdbd2;
            p02f2220c_p99f0cdc5_1.L$0 = this;
            p02f2220c_p99f0cdc5_1.L$1 = p713f0c46Var;
            p02f2220c_p99f0cdc5_1.fd304ba20 = 1;
            if (p6c37087bVar.initTapOnPhone(p02f2220c_p99f0cdc5_1) != coroutine_suspended) {
            }
        }
        if (i == 1) {
            p713f0c46Var = (p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.pf83c2a85.p713f0c46) p02f2220c_p99f0cdc5_1.L$1;
            this = (p83f5c3ad.p684019bc.p02f2220c) p02f2220c_p99f0cdc5_1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                if (i != 3) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
                return obj;
            }
            p713f0c46Var2 = (p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.pf83c2a85.p713f0c46) p02f2220c_p99f0cdc5_1.L$1;
            p02f2220cVar = (p83f5c3ad.p684019bc.p02f2220c) p02f2220c_p99f0cdc5_1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        p83f5c3ad.pb3f20355.p60d45d7a p60d45d7aVar = p02f2220cVar.f6fc15ac5;
        p02f2220c_p99f0cdc5_1.L$0 = null;
        p02f2220c_p99f0cdc5_1.L$1 = null;
        p02f2220c_p99f0cdc5_1.fd304ba20 = 3;
        java.lang.object objStartContactless = p60d45d7aVar.startContactless(p713f0c46Var2, p02f2220c_p99f0cdc5_1);
        return objStartContactless != coroutine_suspended ? objStartContactless : coroutine_suspended;
        p83f5c3ad.p684019bc.p97ae8742 p97ae8742Var = this.fef50e602;
        p02f2220c_p99f0cdc5_1.L$0 = this;
        p02f2220c_p99f0cdc5_1.L$1 = p713f0c46Var;
        p02f2220c_p99f0cdc5_1.fd304ba20 = 2;
        if (p97ae8742Var.initAttestation(p02f2220c_p99f0cdc5_1) != coroutine_suspended) {
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.pf83c2a85.p713f0c46 p713f0c46Var3 = p713f0c46Var;
            p02f2220cVar = this;
            p713f0c46Var2 = p713f0c46Var3;
            p83f5c3ad.pb3f20355.p60d45d7a p60d45d7aVar2 = p02f2220cVar.f6fc15ac5;
            p02f2220c_p99f0cdc5_1.L$0 = null;
            p02f2220c_p99f0cdc5_1.L$1 = null;
            p02f2220c_p99f0cdc5_1.fd304ba20 = 3;
            java.lang.object objStartContactless2 = p60d45d7aVar2.startContactless(p713f0c46Var2, p02f2220c_p99f0cdc5_1);
            if (objStartContactless2 != coroutine_suspended) {
            }
        }
    }
}

