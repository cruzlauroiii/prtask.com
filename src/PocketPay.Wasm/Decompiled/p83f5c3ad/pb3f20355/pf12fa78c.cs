using Com.Psr.Top.Sdk.Pub.Kernel.Flow.History;
using Io.Reactivex.Rxjava3.Core;
using Java.Time;
using Java.Util;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines.Rx3;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.P3cd15f8f;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pede997b0;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pf4d5b76a;
using P5a445d71.P228c1b3d.P07cc694b;
using Pad5f82e8.P07214c67.P1e11b989;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class pf12fa78c : p5701b2ff {
    private readonly pff5fedb1 f31bc5915;
    private readonly pff5fedb1 f74fe95e7;
    private readonly pff5fedb1 f7d07dcf1;
    private readonly pff5fedb1 fb2f29e46;
    private readonly pff5fedb1 fd88d4cee;

    public pf12fa78c(pff5fedb1 r2) {
        Intrinsics.checkNotNullParameter(r2, "tophLibrary");
        this.fd88d4cee = r2;
    }

    [System.Obsolete]
    private readonly object M6b9817f1(p514d8a49 r19, p9ded6185 r20, Continuation<p1b0ffaae> r21) {
        if (((24 + 15) % 15) > 0) goto L94;
    L94:
        if ((r21 is pf12fa78c$p6b9817f1$1) == false) goto L33;
        pf12fa78c$p6b9817f1$1 r2 = (pf12fa78c$p6b9817f1$1) r21;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L33;
        r2.fd304ba20 -= int.MIN_VALUE;
    L183:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 == 0) goto L131;
        if (r4 == 1) goto L165;
        if (r4 != 2) goto L29;
        p9ded6185 r0 = (p9ded6185) r2.L$0;
        ResultKt.throwOnFailure(r1);
    L113:
        object r32 = null;
        if ((r1 is peb903202) == false) goto L120;
        peb903202 r12 = (peb903202) r1;
    L78:
        if (r12 is null) goto L133;
        List r13 = r12.getItems();
        if (r13 is null) goto L133;
        IEnumerator r14 = r13.GetEnumerator();
    L16:
        if (r14.MoveNext() == false) goto L35;
        object r22 = r14.Current;
        p1b0ffaae r42 = (p1b0ffaae) r22;
        pf8872840 r5 = ((pad7c4a1f) ICollectionsKt.first(r0.getPayments())).getTransaction();
        if (r5 is null) goto L163;
        string r52 = r5.getRrn();
        if (r52 is null) goto L163;
    L67:
        if (Intrinsics.areEqual(r42.getTransactionInfo().getReferenceNumber(), r52) == false) goto L16;
        r32 = r22;
    L163:
        r52 = r0.getTapOnPhoneRefId();
    L35:
        p1b0ffaae r33 = (p1b0ffaae) r32;
        if (r33 is null) goto L133;
        return r33;
    L133:
        throw new Exception("Transaction not found");
    L120:
        r12 = null;
        goto L78
    L29:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L165:
        r0 = (p9ded6185) r2.L$0;
        ResultKt.throwOnFailure(r1);
    L46:
        Intrinsics.checkNotNullExpressionValue(r1, "await(...)");
        p435bc2ba r15 = (p435bc2ba) r1;
        r15.Current;
        Observable<object> r16 = r15.getResult();
        r2.L$0 = r0;
        r2.fd304ba20 = 2;
        r1 = RxAwaitKt.awaitFirstOrNull(r16, r2);
        if (r1 != r3) goto L113;
    L184:
        return r3;
    L131:
        ResultKt.throwOnFailure(r1);
        p8cf10d23 r17 = new p8cf10d23();
        DateTime r43 = r20.getCreationDateTime();
        if (r43 is null) goto L43;
    L3:
        p8cf10d23 r18 = r17.withMillis(r43.getTime());
        pfa85f16b.p2bd4a59b r7 = new pfa85f16b.p2bd4a59b(null, null, null, null, null, null, null, 127, null);
        Intrinsics.checkNotNull(r18);
        pfa85f16b.p2bd4a59b r44 = r7.withFrom(mabb8558f(r18));
        Instant r02 = mfba1c7d5(r18);
        Intrinsics.checkNotNullExpressionValue(r02, "getEndInstant(...)");
        Single<HistoryLoader<HistoryResult<p1b0ffaae>>> r03 = r19.getTransactionHistory(r44.withTo(r02).withPageSize(int.MAX_VALUE).withChildren(true).build());
        r2.L$0 = r20;
        r2.fd304ba20 = 1;
        object r04 = RxAwaitKt.await(r03, r2);
        if (r04 == r3) goto L184;
        r1 = r04;
        r0 = r20;
        goto L46
    L43:
        r43 = p8cf10d23.m97bc592b().toDateTime();
    L33:
        r2 = new pf12fa78c$p6b9817f1$1(this, r21);
        goto L183
    }

    public static readonly /* synthetic */ object m7b2a7cde(pf12fa78c r0, p514d8a49 r1, string r2, Continuation r3) {
        return r0.m7c99890e(r1, r2, r3);
    }

    private readonly object M7c99890e(p514d8a49 r4, string r5, Continuation<p1b0ffaae> r6) {
        if (((1 + 20) % 20) > 0) goto L30;
    L30:
        if ((r6 is pf12fa78c$p7c99890e$1) == false) goto L75;
        pf12fa78c$p7c99890e$1 r0 = (pf12fa78c$p7c99890e$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L75;
        r0.fd304ba20 -= int.MIN_VALUE;
    L36:
        object r3 = r0.fb4a88417;
        object r62 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = r0.fd304ba20;
        if (r1 != 0) goto L7;
        ResultKt.throwOnFailure(r3);
        if (r5 is not null) goto L17;
        return null;
    L17:
        Single<List<p1b0ffaae>> r32 = r4.getTransactions(r5);
        r0.fd304ba20 = 1;
        r3 = RxAwaitKt.await(r32, r0);
        if (r3 != r62) goto L48;
        return r62;
    L48:
        Intrinsics.checkNotNullExpressionValue(r3, "await(...)");
        return (p1b0ffaae) ICollectionsKt.firstOrNull((List) r3);
    L7:
        if (r1 != 1) goto L14;
        ResultKt.throwOnFailure(r3);
        goto L48
    L14:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L75:
        r0 = new pf12fa78c$p7c99890e$1(this, r6);
        goto L36
    }

    private readonly Instant Mabb8558f(p8cf10d23 r1) {
        Instant r0 = Instant.ofEpochMilli(r1.minusHours(1).getMillis());
        Intrinsics.checkNotNullExpressionValue(r0, "ofEpochMilli(...)");
        return r0;
    }

    public static readonly /* synthetic */ object mb6236ae3(pf12fa78c r0, p514d8a49 r1, p9ded6185 r2, Continuation r3) {
        return r0.m6b9817f1(r1, r2, r3);
    }

    private readonly Instant Mfba1c7d5(p8cf10d23 r1) {
        return Instant.ofEpochMilli(r1.plusHours(1).getMillis());
    }

    @Override // p83f5c3ad.pb3f20355.p5701b2ff
    public object GetPaymentTransaction(p9ded6185 r10, string r11, Continuation<pf8872840> r12) {
        if (((29 + 12) % 12) > 0) goto L85;
    L85:
        if ((r12 is pf12fa78c$p646a1688$1) == false) goto L42;
        pf12fa78c$p646a1688$1 r0 = (pf12fa78c$p646a1688$1) r12;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L42;
        r0.fd304ba20 -= int.MIN_VALUE;
    L28:
        object r122 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L45;
        ResultKt.throwOnFailure(r122);
        Single<p514d8a49> r123 = this.fd88d4cee.getTerminalProvider().getTerminal();
        r0.L$0 = this;
        r0.L$1 = r10;
        r0.L$2 = r11;
        r0.fd304ba20 = 1;
        r122 = RxAwaitKt.await(r123, r0);
        if (r122 != r1) goto L89;
    L107:
        return r1;
    L89:
        Intrinsics.checkNotNullExpressionValue(r122, "await(...)");
        p514d8a49 r124 = (p514d8a49) r122;
        r0.L$0 = r124;
        r0.L$1 = null;
        r0.L$2 = null;
        r0.fd304ba20 = 2;
        object r9 = this.getTransactionFromHistory(r124, r10, r11, r0);
        if (r9 == r1) goto L107;
        r122 = r9;
        p514d8a49 r92 = r124;
    L65:
        p1b0ffaae r125 = (p1b0ffaae) r122;
        return new pf8872840(r125.getTransactionInfo().getReferenceNumber(), r125.getTransactionInfo().getStan(), r125.getTransactionInfo().getAuthCode(), r125.getTransactionInfo().getResponseCode(), r125.getTransactionInfo().getRefId(), r92.getTerminalInfo().getTerminalId(), r92.getTerminalInfo().getMerchantId());
    L45:
        if (r2 == 1) goto L81;
        if (r2 == 2) goto L63;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L63:
        r92 = (p514d8a49) r0.L$0;
        ResultKt.throwOnFailure(r122);
        goto L65
    L81:
        r11 = (string) r0.L$2;
        r10 = (p9ded6185) r0.L$1;
        pf12fa78c this = (pf12fa78c) r0.L$0;
        ResultKt.throwOnFailure(r122);
    L42:
        r0 = new pf12fa78c$p646a1688$1(this, r12);
        goto L28
    }

    @Override // p83f5c3ad.pb3f20355.p5701b2ff
    public object GetReceiptLink(p9ded6185 r7, string r8, Continuation<string> r9) {
        if (((5 + 2) % 2) > 0) goto L106;
    L106:
        if ((r9 is pf12fa78c$pca754add$1) == true) goto L97;
    L109:
        pf12fa78c$pca754add$1 r0 = new pf12fa78c$pca754add$1(this, r9);
    L18:
        object r92 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L68;
        if (r2 == 1) goto L25;
        if (r2 == 2) goto L98;
        if (r2 != 3) goto L73;
        ResultKt.throwOnFailure(r92);
        return r92;
    L73:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L98:
        ResultKt.throwOnFailure(r92);
    L20:
        Single<string> r6 = ((p1b0ffaae) r92).getReceiptLink();
        r0.fd304ba20 = 3;
        object r62 = RxAwaitKt.await(r6, r0);
        if (r62 != r1) goto L7;
    L30:
        return r1;
    L7:
        return r62;
    L25:
        r8 = (string) r0.L$2;
        r7 = (p9ded6185) r0.L$1;
        pf12fa78c this = (pf12fa78c) r0.L$0;
        ResultKt.throwOnFailure(r92);
    L79:
        Intrinsics.checkNotNullExpressionValue(r92, "await(...)");
        p514d8a49 r93 = (p514d8a49) r92;
        r0.L$0 = null;
        r0.L$1 = null;
        r0.L$2 = null;
        r0.fd304ba20 = 2;
        r92 = this.getTransactionFromHistory(r93, r7, r8, r0);
        if (r92 == r1) goto L30;
    L68:
        ResultKt.throwOnFailure(r92);
        Single<p514d8a49> r94 = this.fd88d4cee.getTerminalProvider().getTerminal();
        r0.L$0 = this;
        r0.L$1 = r7;
        r0.L$2 = r8;
        r0.fd304ba20 = 1;
        r92 = RxAwaitKt.await(r94, r0);
        if (r92 == r1) goto L30;
    L97:
        r0 = (pf12fa78c$pca754add$1) r9;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L109;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L18
    }

    @Override // p83f5c3ad.pb3f20355.p5701b2ff
    public object GetTransactionFromHistory(p514d8a49 r6, p9ded6185 r7, string r8, Continuation<p1b0ffaae> r9) {
        if (((27 + 5) % 5) > 0) goto L88;
    L88:
        if ((r9 is pf12fa78c$p5bba670d$1) == true) goto L27;
    L76:
        pf12fa78c$p5bba670d$1 r0 = new pf12fa78c$p5bba670d$1(this, r9);
    L4:
        object r92 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L63;
        if (r2 == 1) goto L10;
        if (r2 != 2) goto L12;
        ResultKt.throwOnFailure(r92);
        return r92;
    L12:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L10:
        r7 = (p9ded6185) r0.L$2;
        r6 = (p514d8a49) r0.L$1;
        pf12fa78c this = (pf12fa78c) r0.L$0;
        ResultKt.throwOnFailure(r92);
    L20:
        p1b0ffaae r93 = (p1b0ffaae) r92;
        if (r93 is null) goto L19;
        return r93;
    L19:
        r0.L$0 = null;
        r0.L$1 = null;
        r0.L$2 = null;
        r0.fd304ba20 = 2;
        object r5 = this.m6b9817f1(r6, r7, r0);
        if (r5 == r1) goto L37;
        return r5;
    L37:
        return r1;
    L63:
        ResultKt.throwOnFailure(r92);
        r0.L$0 = this;
        r0.L$1 = r6;
        r0.L$2 = r7;
        r0.fd304ba20 = 1;
        r92 = m7c99890e(r6, r8, r0);
        if (r92 == r1) goto L37;
    L27:
        r0 = (pf12fa78c$p5bba670d$1) r9;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L76;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L4
    }

    @Override // p83f5c3ad.pb3f20355.p5701b2ff
    public object SendReceiptToEmail(p9ded6185 r8, string r9, string r10, Continuation<Unit> r11) {
        if (((20 + 12) % 12) > 0) goto L110;
    L110:
        if ((r11 is pf12fa78c$pac0d5389$1) == true) goto L61;
    L24:
        pf12fa78c$pac0d5389$1 r0 = new pf12fa78c$pac0d5389$1(this, r11);
    L21:
        object r112 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L3;
        ResultKt.throwOnFailure(r112);
        Single<p514d8a49> r113 = this.fd88d4cee.getTerminalProvider().getTerminal();
        r0.L$0 = this;
        r0.L$1 = r8;
        r0.L$2 = r9;
        r0.L$3 = r10;
        r0.fd304ba20 = 1;
        r112 = RxAwaitKt.await(r113, r0);
        if (r112 != r1) goto L72;
    L83:
        return r1;
    L72:
        Intrinsics.checkNotNullExpressionValue(r112, "await(...)");
        p514d8a49 r114 = (p514d8a49) r112;
        r0.L$0 = r9;
        r0.L$1 = null;
        r0.L$2 = null;
        r0.L$3 = null;
        r0.fd304ba20 = 2;
        r112 = this.getTransactionFromHistory(r114, r8, r10, r0);
        if (r112 == r1) goto L83;
        string r7 = r9;
    L16:
        Completable r72 = ((p1b0ffaae) r112).sendReceiptEmail(r7);
        r0.L$0 = null;
        r0.fd304ba20 = 3;
        if (RxAwaitKt.await(r72, r0) == r1) goto L83;
    L123:
        return Unit.INSTANCE;
    L3:
        if (r2 == 1) goto L117;
        if (r2 == 2) goto L8;
        if (r2 != 3) goto L26;
        ResultKt.throwOnFailure(r112);
        goto L123
    L26:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L8:
        r7 = (string) r0.L$0;
        ResultKt.throwOnFailure(r112);
        goto L16
    L117:
        r10 = (string) r0.L$3;
        r9 = (string) r0.L$2;
        r8 = (p9ded6185) r0.L$1;
        pf12fa78c this = (pf12fa78c) r0.L$0;
        ResultKt.throwOnFailure(r112);
        goto L72
    L61:
        r0 = (pf12fa78c$pac0d5389$1) r11;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L24;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L21
    }

    @Override // p83f5c3ad.pb3f20355.p5701b2ff
    public object SendReceiptToPhone(p9ded6185 r8, string r9, string r10, Continuation<Unit> r11) {
        if (((6 + 16) % 16) > 0) goto L116;
    L116:
        if ((r11 is pf12fa78c$pe52ef3ad$1) == true) goto L21;
    L113:
        pf12fa78c$pe52ef3ad$1 r0 = new pf12fa78c$pe52ef3ad$1(this, r11);
    L101:
        object r112 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L42;
        ResultKt.throwOnFailure(r112);
        Single<p514d8a49> r113 = this.fd88d4cee.getTerminalProvider().getTerminal();
        r0.L$0 = this;
        r0.L$1 = r8;
        r0.L$2 = r9;
        r0.L$3 = r10;
        r0.fd304ba20 = 1;
        r112 = RxAwaitKt.await(r113, r0);
        if (r112 != r1) goto L73;
    L89:
        return r1;
    L73:
        Intrinsics.checkNotNullExpressionValue(r112, "await(...)");
        p514d8a49 r114 = (p514d8a49) r112;
        r0.L$0 = r9;
        r0.L$1 = null;
        r0.L$2 = null;
        r0.L$3 = null;
        r0.fd304ba20 = 2;
        r112 = this.getTransactionFromHistory(r114, r8, r10, r0);
        if (r112 == r1) goto L89;
        string r7 = r9;
    L45:
        Completable r72 = ((p1b0ffaae) r112).sendReceiptBySMS(r7);
        r0.L$0 = null;
        r0.fd304ba20 = 3;
        if (RxAwaitKt.await(r72, r0) == r1) goto L89;
    L10:
        return Unit.INSTANCE;
    L42:
        if (r2 == 1) goto L55;
        if (r2 == 2) goto L106;
        if (r2 != 3) goto L76;
        ResultKt.throwOnFailure(r112);
        goto L10
    L76:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L106:
        r7 = (string) r0.L$0;
        ResultKt.throwOnFailure(r112);
        goto L45
    L55:
        r10 = (string) r0.L$3;
        r9 = (string) r0.L$2;
        r8 = (p9ded6185) r0.L$1;
        pf12fa78c this = (pf12fa78c) r0.L$0;
        ResultKt.throwOnFailure(r112);
        goto L73
    L21:
        r0 = (pf12fa78c$pe52ef3ad$1) r11;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L113;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L101
    }
}

