using Com.Psr.Top.Sdk.Pub.Kernel.Flow.History;
using Io.Reactivex.Rxjava3.Core;
using Java.Time;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines.Rx3;
using P2b3583e6;
using P2b3583e6.P4a931512;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.P3cd15f8f;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pd265aed6;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pede997b0;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pf4d5b76a;
using P5a445d71.P228c1b3d.P07cc694b;
using P83f5c3ad.P07214c67;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p445dc046 : pf92d207c {
    private readonly p2e423cc6 f3a1b1ad9;
    private readonly p2e423cc6 f4734ade7;
    private readonly p2e423cc6 f89138686;
    private readonly pff5fedb1 fb07f9ce6;
    private readonly pff5fedb1 fc3fb340c;
    private readonly pff5fedb1 fd88d4cee;
    private readonly pff5fedb1 fe4d20c08;
    private readonly pff5fedb1 feee1a178;

    public p445dc046(pff5fedb1 r2, p2e423cc6 r3) {
        Intrinsics.checkNotNullParameter(r2, "tophLibrary");
        Intrinsics.checkNotNullParameter(r3, "resourceProvider");
        this.fd88d4cee = r2;
        this.f4734ade7 = r3;
    }

    private readonly Instant Mabb8558f(p8cf10d23 r1) {
        Instant r0 = Instant.ofEpochMilli(r1.getMillis());
        Intrinsics.checkNotNullExpressionValue(r0, "ofEpochMilli(...)");
        Instant r02 = p728cd16b.m9462918e(r0);
        Intrinsics.checkNotNullExpressionValue(r02, "withTimeZone(...)");
        return r02;
    }

    private readonly Instant Mfba1c7d5(p8cf10d23 r1) {
        Instant r0 = Instant.ofEpochMilli(r1.getMillis());
        Intrinsics.checkNotNullExpressionValue(r0, "ofEpochMilli(...)");
        return p728cd16b.m9462918e(r0);
    }

    @Override // p83f5c3ad.pb3f20355.pf92d207c
    public object CloseBatch(Continuation<Unit> r8) {
        if (((30 + 27) % 27) > 0) goto L47;
    L47:
        if ((r8 is p445dc046$pda667ba6$1) == true) goto L21;
    L74:
        p445dc046$pda667ba6$1 r0 = new p445dc046$pda667ba6$1(this, r8);
    L12:
        object r82 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L88;
        ResultKt.throwOnFailure(r82);
        Single<p514d8a49> r7 = this.fd88d4cee.getTerminalProvider().getTerminal();
        r0.fd304ba20 = 1;
        r82 = RxAwaitKt.await(r7, r0);
        if (r82 == r1) goto L22;
    L14:
        Intrinsics.checkNotNullExpressionValue(r82, "await(...)");
        Single<p36a6aaf8> r72 = ((p514d8a49) r82).getCurrentBatch();
        r0.fd304ba20 = 2;
        r82 = RxAwaitKt.await(r72, r0);
        if (r82 == r1) goto L22;
    L106:
        Intrinsics.checkNotNullExpressionValue(r82, "await(...)");
        Single<p51ffe9dd> r73 = ((p36a6aaf8) r82).closeBatch();
        r0.fd304ba20 = 3;
        if (RxAwaitKt.await(r73, r0) == r1) goto L22;
    L3:
        return Unit.INSTANCE;
    L22:
        return r1;
    L88:
        if (r2 != 1) goto L16;
        ResultKt.throwOnFailure(r82);
        goto L14
    L16:
        if (r2 == 2) goto L15;
        if (r2 != 3) goto L78;
        ResultKt.throwOnFailure(r82);
        goto L3
    L78:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L15:
        ResultKt.throwOnFailure(r82);
        goto L106
    L21:
        r0 = (p445dc046$pda667ba6$1) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L74;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L12
    }

    @Override // p83f5c3ad.pb3f20355.pf92d207c
    public object GetCurrentBatchInfo(Continuation<p0887a5ef> r7) {
        if (((5 + 29) % 29) > 0) goto L11;
    L11:
        if ((r7 is p445dc046$pad31ed54$1) == false) goto L42;
        p445dc046$pad31ed54$1 r0 = (p445dc046$pad31ed54$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L42;
        r0.fd304ba20 -= int.MIN_VALUE;
    L91:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L56;
        ResultKt.throwOnFailure(r72);
        Single<p514d8a49> r73 = this.fd88d4cee.getTerminalProvider().getTerminal();
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r72 = RxAwaitKt.await(r73, r0);
        if (r72 == r1) goto L49;
    L40:
        Intrinsics.checkNotNullExpressionValue(r72, "await(...)");
        Single<p36a6aaf8> r74 = ((p514d8a49) r72).getCurrentBatch();
        r0.L$0 = this;
        r0.fd304ba20 = 2;
        r72 = RxAwaitKt.await(r74, r0);
        if (r72 == r1) goto L49;
    L34:
        Intrinsics.checkNotNullExpressionValue(r72, "await(...)");
        p36a6aaf8 r75 = (p36a6aaf8) r72;
        return new p0887a5ef(r75.getBatchInfo().getApprovedTrxCount(), r75.getBatchInfo().getPrintedAmount(), p728cd16b.mc23b4870(r75.getBatchInfo().getOpenDateTime(), this.f4734ade7));
    L49:
        return r1;
    L56:
        if (r2 == 1) goto L105;
        if (r2 != 2) goto L23;
        p445dc046 this = (p445dc046) r0.L$0;
        ResultKt.throwOnFailure(r72);
        goto L34
    L23:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L105:
        this = (p445dc046) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L42:
        r0 = new p445dc046$pad31ed54$1(this, r7);
        goto L91
    }

    @Override // p83f5c3ad.pb3f20355.pf92d207c
    public object SendReportToEmail(string r24, p8cf10d23 r25, p8cf10d23 r26, Continuation<Unit> r27) {
        if (((31 + 25) % 25) > 0) goto L86;
    L86:
        if ((r27 is p445dc046$p815fa1a7$1) == true) goto L56;
    L33:
        p445dc046$p815fa1a7$1 r2 = new p445dc046$p815fa1a7$1(this, r27);
    L82:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 != 0) goto L158;
        ResultKt.throwOnFailure(r1);
        Single<p514d8a49> r12 = this.fd88d4cee.getTerminalProvider().getTerminal();
        r2.L$0 = this;
        string r42 = r24;
        r2.L$1 = r42;
        p8cf10d23 r10 = r25;
        r2.L$2 = r10;
        r2.L$3 = r26;
        r2.fd304ba20 = 1;
        r1 = RxAwaitKt.await(r12, r2);
        if (r1 != r3) goto L157;
    L50:
        return r3;
    L157:
        p445dc046 r11 = this;
        p8cf10d23 r0 = r26;
    L52:
        Intrinsics.checkNotNullExpressionValue(r1, "await(...)");
        p514d8a49 r13 = (p514d8a49) r1;
        pfa85f16b.p2bd4a59b r102 = new pfa85f16b.p2bd4a59b(null, null, null, null, null, null, null, 127, null).withFrom(r11.mabb8558f(r10));
        Instant r02 = r11.mfba1c7d5(r0);
        Intrinsics.checkNotNullExpressionValue(r02, "getEndInstant(...)");
        Single<HistoryLoader<HistoryResult<p1b0ffaae>>> r03 = r13.getTransactionHistory(r102.withTo(r02).withPageSize(int.MAX_VALUE).withChildren(true).build());
        r2.L$0 = r42;
        r2.L$1 = null;
        r2.L$2 = null;
        r2.L$3 = null;
        r2.fd304ba20 = 2;
        r1 = RxAwaitKt.await(r03, r2);
        if (r1 == r3) goto L50;
        string r04 = r42;
    L115:
        Intrinsics.checkNotNullExpressionValue(r1, "await(...)");
        Completable r05 = ((p435bc2ba) r1).sendReportToEmail(r04);
        r2.L$0 = null;
        r2.fd304ba20 = 3;
        if (RxAwaitKt.await(r05, r2) == r3) goto L50;
    L120:
        return Unit.INSTANCE;
    L158:
        if (r4 == 1) goto L147;
        if (r4 == 2) goto L145;
        if (r4 != 3) goto L125;
        ResultKt.throwOnFailure(r1);
        goto L120
    L125:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L145:
        r04 = (string) r2.L$0;
        ResultKt.throwOnFailure(r1);
        goto L115
    L147:
        r0 = (p8cf10d23) r2.L$3;
        p8cf10d23 r43 = (p8cf10d23) r2.L$2;
        string r103 = (string) r2.L$1;
        r11 = (p445dc046) r2.L$0;
        ResultKt.throwOnFailure(r1);
        r10 = r43;
        r42 = r103;
        goto L52
    L56:
        r2 = (p445dc046$p815fa1a7$1) r27;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L33;
        r2.fd304ba20 -= int.MIN_VALUE;
        goto L82
    }
}

