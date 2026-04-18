namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000F\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u000e\u0010\n\u001a\u00020\u000bH\u0096@¢\u0006\u0002\u0010\fJ(\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u00122\b\u0010\u0013\u001a\u0004\u0018\u00010\u0014H\u0096@¢\u0006\u0002\u0010\u0015J\u0016\u0010\u0016\u001a\u00020\u000e2\u0006\u0010\u0017\u001a\u00020\u000eH\u0096@¢\u0006\u0002\u0010\u0018J\u0016\u0010\u0019\u001a\u00020\u001a2\u0006\u0010\u0017\u001a\u00020\u000eH\u0096@¢\u0006\u0002\u0010\u0018R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001b"}, d2 = {"Lp83f5c3ad/p684019bc/p6179dbd9;", "Lp83f5c3ad/p684019bc/p43cba26b;", "paybackTapOnPhoneRepository", "Lp83f5c3ad/pb3f20355/p5b55d2ff;", "initTapOnPhoneUseCase", "Lp83f5c3ad/p684019bc/p6c37087b;", "attestationTapOnPhoneUseCase", "Lp83f5c3ad/p684019bc/p97ae8742;", "<init>", "(Lp83f5c3ad/pb3f20355/p5b55d2ff;Lp83f5c3ad/p684019bc/p6c37087b;Lp83f5c3ad/p684019bc/p97ae8742;)V", "getPaymentTerminal", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pede997b0/pf83c2a85/pd0910e67;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "initPayback", "Lp83f5c3ad/p07214c67/p0e6dda02;", "receipt", "Lpad5f82e8/p07214c67/p1e11b989/p9ded6185;", "amount", "", "rrn", "", "(Lpad5f82e8/p07214c67/p1e11b989/p9ded6185;JLjava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "startContactless", "tophPayback", "(Lp83f5c3ad/p07214c67/p0e6dda02;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "makePayback", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pf4d5b76a/p1b0ffaae;", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p6179dbd9 : p83f5c3ad.p684019bc.p43cba26b {
    private readonly p83f5c3ad.p684019bc.p6c37087b f039d57ed;
    private readonly p83f5c3ad.p684019bc.p97ae8742 f0ba8d6dd;
    private readonly p83f5c3ad.p684019bc.p6c37087b f477bdbd2;
    private readonly p83f5c3ad.pb3f20355.p5b55d2ff f4d9a9c18;
    private readonly p83f5c3ad.p684019bc.p6c37087b f520333a9;
    private readonly p83f5c3ad.pb3f20355.p5b55d2ff f6935bf55;
    private readonly p83f5c3ad.p684019bc.p6c37087b fb99742aa;
    private readonly p83f5c3ad.p684019bc.p6c37087b fc12700dd;
    private readonly p83f5c3ad.pb3f20355.p5b55d2ff fe8fcc46c;
    private readonly p83f5c3ad.p684019bc.p97ae8742 fef50e602;

    public p6179dbd9(p83f5c3ad.pb3f20355.p5b55d2ff paybackTapOnPhoneRepository, p83f5c3ad.p684019bc.p6c37087b initTapOnPhoneUseCase, p83f5c3ad.p684019bc.p97ae8742 attestationTapOnPhoneUseCase) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(paybackTapOnPhoneRepository, "paybackTapOnPhoneRepository");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(initTapOnPhoneUseCase, "initTapOnPhoneUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(attestationTapOnPhoneUseCase, "attestationTapOnPhoneUseCase");
        this.fe8fcc46c = paybackTapOnPhoneRepository;
        this.f477bdbd2 = initTapOnPhoneUseCase;
        this.fef50e602 = attestationTapOnPhoneUseCase;
    }

    public override java.lang.object GetPaymentTerminal(kotlin.coroutines.Continuation<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67> continuation) throws java.lang.Exception {
        p83f5c3ad.p684019bc.p6179dbd9$pea2326a4$1 p6179dbd9_pea2326a4_1;
        if ((23 + 1) % 1 > 0) {
        }
        if (continuation is p83f5c3ad.p684019bc.p6179dbd9$pea2326a4$1) {
            p6179dbd9_pea2326a4_1 = (p83f5c3ad.p684019bc.p6179dbd9$pea2326a4$1) continuation;
            if ((p6179dbd9_pea2326a4_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p6179dbd9_pea2326a4_1 = new p83f5c3ad.p684019bc.p6179dbd9$pea2326a4$1(this, continuation);
            } else {
                p6179dbd9_pea2326a4_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p6179dbd9_pea2326a4_1 = new p83f5c3ad.p684019bc.p6179dbd9$pea2326a4$1(this, continuation);
        }
        java.lang.object obj = p6179dbd9_pea2326a4_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p6179dbd9_pea2326a4_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p83f5c3ad.p684019bc.p6c37087b p6c37087bVar = this.f477bdbd2;
            p6179dbd9_pea2326a4_1.L$0 = this;
            p6179dbd9_pea2326a4_1.fd304ba20 = 1;
            if (p6c37087bVar.initTapOnPhone(p6179dbd9_pea2326a4_1) != coroutine_suspended) {
            }
        }
        if (i == 1) {
            this = (p83f5c3ad.p684019bc.p6179dbd9) p6179dbd9_pea2326a4_1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                if (i != 3) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
                return obj;
            }
            this = (p83f5c3ad.p684019bc.p6179dbd9) p6179dbd9_pea2326a4_1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        p83f5c3ad.pb3f20355.p5b55d2ff p5b55d2ffVar = this.fe8fcc46c;
        p6179dbd9_pea2326a4_1.L$0 = null;
        p6179dbd9_pea2326a4_1.fd304ba20 = 3;
        java.lang.object paymentTerminal = p5b55d2ffVar.getPaymentTerminal(p6179dbd9_pea2326a4_1);
        return paymentTerminal != coroutine_suspended ? paymentTerminal : coroutine_suspended;
        p83f5c3ad.p684019bc.p97ae8742 p97ae8742Var = this.fef50e602;
        p6179dbd9_pea2326a4_1.L$0 = this;
        p6179dbd9_pea2326a4_1.fd304ba20 = 2;
        if (p97ae8742Var.initAttestation(p6179dbd9_pea2326a4_1) != coroutine_suspended) {
            p83f5c3ad.pb3f20355.p5b55d2ff p5b55d2ffVar2 = this.fe8fcc46c;
            p6179dbd9_pea2326a4_1.L$0 = null;
            p6179dbd9_pea2326a4_1.fd304ba20 = 3;
            java.lang.object paymentTerminal2 = p5b55d2ffVar2.getPaymentTerminal(p6179dbd9_pea2326a4_1);
            if (paymentTerminal2 != coroutine_suspended) {
            }
        }
    }

    public override java.lang.object InitPayback(pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var, long j, java.lang.string str, kotlin.coroutines.Continuation<p83f5c3ad.p07214c67.p0e6dda02> continuation) throws java.lang.Exception {
        p83f5c3ad.p684019bc.p6179dbd9$p6d9e0861$1 p6179dbd9_p6d9e0861_1;
        if ((17 + 9) % 9 > 0) {
        }
        if (continuation is p83f5c3ad.p684019bc.p6179dbd9$p6d9e0861$1) {
            p6179dbd9_p6d9e0861_1 = (p83f5c3ad.p684019bc.p6179dbd9$p6d9e0861$1) continuation;
            if ((p6179dbd9_p6d9e0861_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p6179dbd9_p6d9e0861_1 = new p83f5c3ad.p684019bc.p6179dbd9$p6d9e0861$1(this, continuation);
            } else {
                p6179dbd9_p6d9e0861_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p6179dbd9_p6d9e0861_1 = new p83f5c3ad.p684019bc.p6179dbd9$p6d9e0861$1(this, continuation);
        }
        p83f5c3ad.p684019bc.p6179dbd9$p6d9e0861$1 p6179dbd9_p6d9e0861_12 = p6179dbd9_p6d9e0861_1;
        java.lang.object obj = p6179dbd9_p6d9e0861_12.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p6179dbd9_p6d9e0861_12.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p83f5c3ad.p684019bc.p6c37087b p6c37087bVar = this.f477bdbd2;
            p6179dbd9_p6d9e0861_12.L$0 = this;
            p6179dbd9_p6d9e0861_12.L$1 = p9ded6185Var;
            p6179dbd9_p6d9e0861_12.L$2 = str;
            p6179dbd9_p6d9e0861_12.J$0 = j;
            p6179dbd9_p6d9e0861_12.fd304ba20 = 1;
            if (p6c37087bVar.initTapOnPhone(p6179dbd9_p6d9e0861_12) != coroutine_suspended) {
            }
        }
        if (i == 1) {
            j = p6179dbd9_p6d9e0861_12.J$0;
            str = (java.lang.string) p6179dbd9_p6d9e0861_12.L$2;
            p9ded6185Var = (pad5f82e8.p07214c67.p1e11b989.p9ded6185) p6179dbd9_p6d9e0861_12.L$1;
            this = (p83f5c3ad.p684019bc.p6179dbd9) p6179dbd9_p6d9e0861_12.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                if (i != 3) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
                return obj;
            }
            long j2 = p6179dbd9_p6d9e0861_12.J$0;
            java.lang.string str2 = (java.lang.string) p6179dbd9_p6d9e0861_12.L$2;
            pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var2 = (pad5f82e8.p07214c67.p1e11b989.p9ded6185) p6179dbd9_p6d9e0861_12.L$1;
            p83f5c3ad.p684019bc.p6179dbd9 p6179dbd9Var = (p83f5c3ad.p684019bc.p6179dbd9) p6179dbd9_p6d9e0861_12.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            str = str2;
            p9ded6185Var = p9ded6185Var2;
            j = j2;
            this = p6179dbd9Var;
        }
        p83f5c3ad.pb3f20355.p5b55d2ff p5b55d2ffVar = this.fe8fcc46c;
        p6179dbd9_p6d9e0861_12.L$0 = null;
        p6179dbd9_p6d9e0861_12.L$1 = null;
        p6179dbd9_p6d9e0861_12.L$2 = null;
        p6179dbd9_p6d9e0861_12.fd304ba20 = 3;
        java.lang.object objInitPayback = p5b55d2ffVar.initPayback(p9ded6185Var, j, str, p6179dbd9_p6d9e0861_12);
        return objInitPayback != coroutine_suspended ? objInitPayback : coroutine_suspended;
        p83f5c3ad.p684019bc.p97ae8742 p97ae8742Var = this.fef50e602;
        p6179dbd9_p6d9e0861_12.L$0 = this;
        p6179dbd9_p6d9e0861_12.L$1 = p9ded6185Var;
        p6179dbd9_p6d9e0861_12.L$2 = str;
        p6179dbd9_p6d9e0861_12.J$0 = j;
        p6179dbd9_p6d9e0861_12.fd304ba20 = 2;
        if (p97ae8742Var.initAttestation(p6179dbd9_p6d9e0861_12) != coroutine_suspended) {
            p83f5c3ad.pb3f20355.p5b55d2ff p5b55d2ffVar2 = this.fe8fcc46c;
            p6179dbd9_p6d9e0861_12.L$0 = null;
            p6179dbd9_p6d9e0861_12.L$1 = null;
            p6179dbd9_p6d9e0861_12.L$2 = null;
            p6179dbd9_p6d9e0861_12.fd304ba20 = 3;
            java.lang.object objInitPayback2 = p5b55d2ffVar2.initPayback(p9ded6185Var, j, str, p6179dbd9_p6d9e0861_12);
            if (objInitPayback2 != coroutine_suspended) {
            }
        }
    }

    public override java.lang.object MakePayback(p83f5c3ad.p07214c67.p0e6dda02 p0e6dda02Var, kotlin.coroutines.Continuation<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pf4d5b76a.p1b0ffaae> continuation) throws java.lang.Exception {
        p83f5c3ad.p684019bc.p6179dbd9$p078de3ac$1 p6179dbd9_p078de3ac_1;
        p83f5c3ad.p07214c67.p0e6dda02 p0e6dda02Var2;
        p83f5c3ad.p684019bc.p6179dbd9 p6179dbd9Var;
        if ((26 + 23) % 23 > 0) {
        }
        if (continuation is p83f5c3ad.p684019bc.p6179dbd9$p078de3ac$1) {
            p6179dbd9_p078de3ac_1 = (p83f5c3ad.p684019bc.p6179dbd9$p078de3ac$1) continuation;
            if ((p6179dbd9_p078de3ac_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p6179dbd9_p078de3ac_1 = new p83f5c3ad.p684019bc.p6179dbd9$p078de3ac$1(this, continuation);
            } else {
                p6179dbd9_p078de3ac_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p6179dbd9_p078de3ac_1 = new p83f5c3ad.p684019bc.p6179dbd9$p078de3ac$1(this, continuation);
        }
        java.lang.object obj = p6179dbd9_p078de3ac_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p6179dbd9_p078de3ac_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p83f5c3ad.p684019bc.p6c37087b p6c37087bVar = this.f477bdbd2;
            p6179dbd9_p078de3ac_1.L$0 = this;
            p6179dbd9_p078de3ac_1.L$1 = p0e6dda02Var;
            p6179dbd9_p078de3ac_1.fd304ba20 = 1;
            if (p6c37087bVar.initTapOnPhone(p6179dbd9_p078de3ac_1) != coroutine_suspended) {
            }
        }
        if (i == 1) {
            p0e6dda02Var = (p83f5c3ad.p07214c67.p0e6dda02) p6179dbd9_p078de3ac_1.L$1;
            this = (p83f5c3ad.p684019bc.p6179dbd9) p6179dbd9_p078de3ac_1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                if (i != 3) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
                return obj;
            }
            p0e6dda02Var2 = (p83f5c3ad.p07214c67.p0e6dda02) p6179dbd9_p078de3ac_1.L$1;
            p6179dbd9Var = (p83f5c3ad.p684019bc.p6179dbd9) p6179dbd9_p078de3ac_1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        p83f5c3ad.pb3f20355.p5b55d2ff p5b55d2ffVar = p6179dbd9Var.fe8fcc46c;
        p6179dbd9_p078de3ac_1.L$0 = null;
        p6179dbd9_p078de3ac_1.L$1 = null;
        p6179dbd9_p078de3ac_1.fd304ba20 = 3;
        java.lang.object objMakePayback = p5b55d2ffVar.makePayback(p0e6dda02Var2, p6179dbd9_p078de3ac_1);
        return objMakePayback != coroutine_suspended ? objMakePayback : coroutine_suspended;
        p83f5c3ad.p684019bc.p97ae8742 p97ae8742Var = this.fef50e602;
        p6179dbd9_p078de3ac_1.L$0 = this;
        p6179dbd9_p078de3ac_1.L$1 = p0e6dda02Var;
        p6179dbd9_p078de3ac_1.fd304ba20 = 2;
        if (p97ae8742Var.initAttestation(p6179dbd9_p078de3ac_1) != coroutine_suspended) {
            p83f5c3ad.p07214c67.p0e6dda02 p0e6dda02Var3 = p0e6dda02Var;
            p6179dbd9Var = this;
            p0e6dda02Var2 = p0e6dda02Var3;
            p83f5c3ad.pb3f20355.p5b55d2ff p5b55d2ffVar2 = p6179dbd9Var.fe8fcc46c;
            p6179dbd9_p078de3ac_1.L$0 = null;
            p6179dbd9_p078de3ac_1.L$1 = null;
            p6179dbd9_p078de3ac_1.fd304ba20 = 3;
            java.lang.object objMakePayback2 = p5b55d2ffVar2.makePayback(p0e6dda02Var2, p6179dbd9_p078de3ac_1);
            if (objMakePayback2 != coroutine_suspended) {
            }
        }
    }

    public override java.lang.object StartContactless(p83f5c3ad.p07214c67.p0e6dda02 p0e6dda02Var, kotlin.coroutines.Continuation<p83f5c3ad.p07214c67.p0e6dda02> continuation) throws java.lang.Exception {
        p83f5c3ad.p684019bc.p6179dbd9$p99f0cdc5$1 p6179dbd9_p99f0cdc5_1;
        p83f5c3ad.p684019bc.p6179dbd9 p6179dbd9Var;
        p83f5c3ad.p07214c67.p0e6dda02 p0e6dda02Var2;
        if ((30 + 12) % 12 > 0) {
        }
        if (continuation is p83f5c3ad.p684019bc.p6179dbd9$p99f0cdc5$1) {
            p6179dbd9_p99f0cdc5_1 = (p83f5c3ad.p684019bc.p6179dbd9$p99f0cdc5$1) continuation;
            if ((p6179dbd9_p99f0cdc5_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p6179dbd9_p99f0cdc5_1 = new p83f5c3ad.p684019bc.p6179dbd9$p99f0cdc5$1(this, continuation);
            } else {
                p6179dbd9_p99f0cdc5_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p6179dbd9_p99f0cdc5_1 = new p83f5c3ad.p684019bc.p6179dbd9$p99f0cdc5$1(this, continuation);
        }
        java.lang.object obj = p6179dbd9_p99f0cdc5_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p6179dbd9_p99f0cdc5_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p83f5c3ad.p684019bc.p6c37087b p6c37087bVar = this.f477bdbd2;
            p6179dbd9_p99f0cdc5_1.L$0 = this;
            p6179dbd9_p99f0cdc5_1.L$1 = p0e6dda02Var;
            p6179dbd9_p99f0cdc5_1.fd304ba20 = 1;
            if (p6c37087bVar.initTapOnPhone(p6179dbd9_p99f0cdc5_1) != coroutine_suspended) {
            }
        }
        if (i == 1) {
            p0e6dda02Var = (p83f5c3ad.p07214c67.p0e6dda02) p6179dbd9_p99f0cdc5_1.L$1;
            this = (p83f5c3ad.p684019bc.p6179dbd9) p6179dbd9_p99f0cdc5_1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                if (i != 3) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
                return obj;
            }
            p0e6dda02Var2 = (p83f5c3ad.p07214c67.p0e6dda02) p6179dbd9_p99f0cdc5_1.L$1;
            p6179dbd9Var = (p83f5c3ad.p684019bc.p6179dbd9) p6179dbd9_p99f0cdc5_1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        p83f5c3ad.pb3f20355.p5b55d2ff p5b55d2ffVar = p6179dbd9Var.fe8fcc46c;
        p6179dbd9_p99f0cdc5_1.L$0 = null;
        p6179dbd9_p99f0cdc5_1.L$1 = null;
        p6179dbd9_p99f0cdc5_1.fd304ba20 = 3;
        java.lang.object objStartContactless = p5b55d2ffVar.startContactless(p0e6dda02Var2, p6179dbd9_p99f0cdc5_1);
        return objStartContactless != coroutine_suspended ? objStartContactless : coroutine_suspended;
        p83f5c3ad.p684019bc.p97ae8742 p97ae8742Var = this.fef50e602;
        p6179dbd9_p99f0cdc5_1.L$0 = this;
        p6179dbd9_p99f0cdc5_1.L$1 = p0e6dda02Var;
        p6179dbd9_p99f0cdc5_1.fd304ba20 = 2;
        if (p97ae8742Var.initAttestation(p6179dbd9_p99f0cdc5_1) != coroutine_suspended) {
            p83f5c3ad.p07214c67.p0e6dda02 p0e6dda02Var3 = p0e6dda02Var;
            p6179dbd9Var = this;
            p0e6dda02Var2 = p0e6dda02Var3;
            p83f5c3ad.pb3f20355.p5b55d2ff p5b55d2ffVar2 = p6179dbd9Var.fe8fcc46c;
            p6179dbd9_p99f0cdc5_1.L$0 = null;
            p6179dbd9_p99f0cdc5_1.L$1 = null;
            p6179dbd9_p99f0cdc5_1.fd304ba20 = 3;
            java.lang.object objStartContactless2 = p5b55d2ffVar2.startContactless(p0e6dda02Var2, p6179dbd9_p99f0cdc5_1);
            if (objStartContactless2 != coroutine_suspended) {
            }
        }
    }
}

