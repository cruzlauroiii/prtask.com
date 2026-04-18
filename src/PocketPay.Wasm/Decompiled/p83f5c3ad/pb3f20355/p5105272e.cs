namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010\u0012\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\b\u0010\n\u001a\u00020\u000bH\u0016J\u000e\u0010\f\u001a\u00020\rH\u0096@¢\u0006\u0002\u0010\u000eJ\u0016\u0010\u000f\u001a\u00020\r2\u0006\u0010\u0010\u001a\u00020\u0011H\u0096@¢\u0006\u0002\u0010\u0012R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\b\u001a\u0004\u0018\u00010\tX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0013"}, d2 = {"Lp83f5c3ad/pb3f20355/p5105272e;", "Lp83f5c3ad/pb3f20355/p4db3be80;", "tophLibrary", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pff5fedb1;", "tokenRepository", "Lp8d777f38/pb3f20355/pd9ae119c/pfa2012fc;", "<init>", "(Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pff5fedb1;Lp8d777f38/pb3f20355/pd9ae119c/pfa2012fc;)V", "attestation", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pfa087a97/p2adcc29d;", "checkAttested", "", "initAttestation", "", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "confirmAttestation", "appCodebytes", "", "([BLkotlin/coroutines/Continuation;)Ljava/lang/object;", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p5105272e : p83f5c3ad.pb3f20355.p4db3be80 {
    private readonly p8d777f38.pb3f20355.pd9ae119c.pfa2012fc f0560c323;
    private readonly p8d777f38.pb3f20355.pd9ae119c.pfa2012fc f35a467da;
    private readonly p8d777f38.pb3f20355.pd9ae119c.pfa2012fc f496a5ac6;
    private readonly p8d777f38.pb3f20355.pd9ae119c.pfa2012fc f6f9723b6;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pff5fedb1 f760cf68d;
    private p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pfa087a97.p2adcc29d f7cf52b22;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pff5fedb1 fd4ad7af6;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pff5fedb1 fd88d4cee;
    private p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pfa087a97.p2adcc29d fe465e111;
    private readonly p8d777f38.pb3f20355.pd9ae119c.pfa2012fc ff2720038;
    private p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pfa087a97.p2adcc29d ffa087a97;

    public p5105272e(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pff5fedb1 tophLibrary, p8d777f38.pb3f20355.pd9ae119c.pfa2012fc tokenRepository) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tophLibrary, "tophLibrary");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tokenRepository, "tokenRepository");
        this.fd88d4cee = tophLibrary;
        this.f496a5ac6 = tokenRepository;
    }

    public override bool CheckAttested() {
        return this.fd88d4cee.getSecurityProvider().getActivationManager().getActivation().getAttestationManager().isAttested();
    }

    public override java.lang.object ConfirmAttestation(byte[] bArr, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        p83f5c3ad.pb3f20355.p5105272e$pbb97d0dd$1 p5105272e_pbb97d0dd_1;
        p83f5c3ad.pb3f20355.p5105272e p5105272eVar;
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pfa087a97.p2adcc29d p2adcc29dVar;
        p83f5c3ad.pb3f20355.p5105272e p5105272eVar2;
        if ((6 + 4) % 4 > 0) {
        }
        if (continuation is p83f5c3ad.pb3f20355.p5105272e$pbb97d0dd$1) {
            p5105272e_pbb97d0dd_1 = (p83f5c3ad.pb3f20355.p5105272e$pbb97d0dd$1) continuation;
            if ((p5105272e_pbb97d0dd_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p5105272e_pbb97d0dd_1 = new p83f5c3ad.pb3f20355.p5105272e$pbb97d0dd$1(this, continuation);
            } else {
                p5105272e_pbb97d0dd_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p5105272e_pbb97d0dd_1 = new p83f5c3ad.pb3f20355.p5105272e$pbb97d0dd$1(this, continuation);
        }
        java.lang.object obj = p5105272e_pbb97d0dd_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p5105272e_pbb97d0dd_1.fd304ba20;
        if (i != 0) {
            if (i == 1) {
                p2adcc29dVar = (p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pfa087a97.p2adcc29d) p5105272e_pbb97d0dd_1.L$2;
                bArr = (byte[]) p5105272e_pbb97d0dd_1.L$1;
                p5105272eVar = (p83f5c3ad.pb3f20355.p5105272e) p5105272e_pbb97d0dd_1.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
            } else {
                if (i != 2) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                p5105272eVar2 = (p83f5c3ad.pb3f20355.p5105272e) p5105272e_pbb97d0dd_1.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
            }
            if (p5105272eVar2.fd88d4cee.getTerminalProvider().getPaymentTerminal() is not null) {
                return kotlin.Unit.INSTANCE;
            }
            throw new p83f5c3ad.p684019bc.p42552b1f.p95583da5();
        }
        kotlin.ResultKt.throwOnFailure(obj);
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pfa087a97.p2adcc29d p2adcc29dVar2 = this.ffa087a97;
        if (p2adcc29dVar2 is not null) {
            p8d777f38.pb3f20355.pd9ae119c.pfa2012fc pfa2012fcVar = this.f496a5ac6;
            p5105272e_pbb97d0dd_1.L$0 = this;
            p5105272e_pbb97d0dd_1.L$1 = bArr;
            p5105272e_pbb97d0dd_1.L$2 = p2adcc29dVar2;
            p5105272e_pbb97d0dd_1.fd304ba20 = 1;
            java.lang.object fcmToken = pfa2012fcVar.getFcmToken(p5105272e_pbb97d0dd_1);
            if (fcmToken != coroutine_suspended) {
                p5105272eVar = this;
                p2adcc29dVar = p2adcc29dVar2;
                obj = fcmToken;
            }
            return coroutine_suspended;
        }
        throw new p83f5c3ad.p684019bc.p42552b1f.p95583da5();
        io.reactivex.rxjava3.core.Completable completableConfirmAttestation = p2adcc29dVar.confirmAttestation(bArr, (java.lang.string) obj);
        p5105272e_pbb97d0dd_1.L$0 = p5105272eVar;
        p5105272e_pbb97d0dd_1.L$1 = null;
        p5105272e_pbb97d0dd_1.L$2 = null;
        p5105272e_pbb97d0dd_1.fd304ba20 = 2;
        if (kotlinx.coroutines.rx3.RxAwaitKt.await(completableConfirmAttestation, p5105272e_pbb97d0dd_1) != coroutine_suspended) {
            p5105272eVar2 = p5105272eVar;
            if (p5105272eVar2.fd88d4cee.getTerminalProvider().getPaymentTerminal() is not null) {
                return kotlin.Unit.INSTANCE;
            }
            throw new p83f5c3ad.p684019bc.p42552b1f.p95583da5();
        }
        return coroutine_suspended;
    }

    public override java.lang.object InitAttestation(kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        p83f5c3ad.pb3f20355.p5105272e$p4434d349$1 p5105272e_p4434d349_1;
        if ((12 + 5) % 5 > 0) {
        }
        if (continuation is p83f5c3ad.pb3f20355.p5105272e$p4434d349$1) {
            p5105272e_p4434d349_1 = (p83f5c3ad.pb3f20355.p5105272e$p4434d349$1) continuation;
            if ((p5105272e_p4434d349_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p5105272e_p4434d349_1 = new p83f5c3ad.pb3f20355.p5105272e$p4434d349$1(this, continuation);
            } else {
                p5105272e_p4434d349_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p5105272e_p4434d349_1 = new p83f5c3ad.pb3f20355.p5105272e$p4434d349$1(this, continuation);
        }
        java.lang.object objAwait = p5105272e_p4434d349_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p5105272e_p4434d349_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(objAwait);
            io.reactivex.rxjava3.core.Single<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pfa087a97.p2adcc29d> singlePerformAttestation = this.fd88d4cee.getSecurityProvider().getActivationManager().getActivation().getAttestationManager().performAttestation();
            p5105272e_p4434d349_1.L$0 = this;
            p5105272e_p4434d349_1.fd304ba20 = 1;
            objAwait = kotlinx.coroutines.rx3.RxAwaitKt.await(singlePerformAttestation, p5105272e_p4434d349_1);
            if (objAwait == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            this = (p83f5c3ad.pb3f20355.p5105272e) p5105272e_p4434d349_1.L$0;
            kotlin.ResultKt.throwOnFailure(objAwait);
        }
        this.ffa087a97 = (p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pfa087a97.p2adcc29d) objAwait;
        return kotlin.Unit.INSTANCE;
    }
}

