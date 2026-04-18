using Io.Reactivex.Rxjava3.Core;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines.Rx3;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pede997b0.Pf83c2a85;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pf4d5b76a;
using P83f5c3ad.P07214c67;
using P83f5c3ad.P20f35e63.P4670093c;
using Pad5f82e8.P07214c67.P1e11b989;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class pb6349ffb : p5b55d2ff {
    private readonly pff5fedb1 f5e0b9025;
    private readonly pff5fedb1 f696ef83d;
    private readonly pff5fedb1 f707852c7;
    private readonly p5701b2ff f7bcec348;
    private readonly p5701b2ff f7f93a8f8;
    private readonly pff5fedb1 fd88d4cee;
    private readonly pff5fedb1 fdd23082e;

    public pb6349ffb(pff5fedb1 r2, p5701b2ff r3) {
        Intrinsics.checkNotNullParameter(r2, "tophLibrary");
        Intrinsics.checkNotNullParameter(r3, "tophReceiptRepository");
        this.fd88d4cee = r2;
        this.f7f93a8f8 = r3;
    }

    @Override // p83f5c3ad.pb3f20355.p5b55d2ff
    public object GetPaymentTerminal(Continuation<pd0910e67> r1) {
        return RxAwaitKt.await(this.fd88d4cee.getTerminalProvider().getPaymentTerminal(), r1);
    }

    @Override // p83f5c3ad.pb3f20355.p5b55d2ff
    public object InitPayback(p9ded6185 r11, long r12, string r14, Continuation<p0e6dda02> r15) {
        if (((31 + 19) % 19) > 0) goto L63;
    L63:
        if ((r15 is pb6349ffb$p6d9e0861$1) == true) goto L54;
    L13:
        pb6349ffb$p6d9e0861$1 r0 = new pb6349ffb$p6d9e0861$1(this, r15);
    L17:
        pb6349ffb$p6d9e0861$1 r152 = r0;
        object r02 = r152.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r152.fd304ba20;
        if (r2 == 0) goto L143;
        if (r2 == 1) goto L56;
        if (r2 != 2) goto L118;
        long r10 = r152.J$0;
        pd0910e67 r122 = (pd0910e67) r152.L$0;
        ResultKt.throwOnFailure(r02);
        pd0910e67 r112 = r122;
        r12 = r10;
    L62:
        p1b0ffaae r142 = (p1b0ffaae) r02;
        if (r142.getTransactionInfo().getCurrentBatch() == true) goto L51;
        p20d80102.p910eef8c r102 = p20d80102.f910eef8c;
        r152.L$0 = null;
        r152.fd304ba20 = 4;
        object r103 = r102.initPayback(r112, r12, r142, r152);
        if (r103 == r1) goto L20;
        return r103;
    L20:
        return r1;
    L51:
        p643ce821.p910eef8c r104 = p643ce821.f910eef8c;
        r152.L$0 = null;
        r152.fd304ba20 = 3;
        r02 = r104.initPayback(r112, r12, r142, r152);
        if (r02 == r1) goto L20;
    L9:
        return (p0e6dda02) r02;
    L118:
        if (r2 == 3) goto L68;
        if (r2 != 4) goto L154;
        ResultKt.throwOnFailure(r02);
        return r02;
    L154:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L68:
        ResultKt.throwOnFailure(r02);
        goto L9
    L56:
        r12 = r152.J$0;
        r14 = (string) r152.L$2;
        r11 = (p9ded6185) r152.L$1;
        pb6349ffb this = (pb6349ffb) r152.L$0;
        ResultKt.throwOnFailure(r02);
    L4:
        Intrinsics.checkNotNullExpressionValue(r02, "await(...)");
        pd0910e67 r03 = (pd0910e67) r02;
        p5701b2ff r105 = this.f7f93a8f8;
        pd0910e67 r22 = r03;
        r152.L$0 = r03;
        r152.L$1 = null;
        r152.L$2 = null;
        r152.J$0 = r12;
        r152.fd304ba20 = 2;
        object r106 = r105.getTransactionFromHistory(r22, r11, r14, r152);
        if (r106 == r1) goto L20;
        r112 = r03;
        r02 = r106;
        goto L62
    L143:
        ResultKt.throwOnFailure(r02);
        Single<pd0910e67> r04 = this.fd88d4cee.getTerminalProvider().getPaymentTerminal();
        r152.L$0 = this;
        r152.L$1 = r11;
        r152.L$2 = r14;
        r152.J$0 = r12;
        r152.fd304ba20 = 1;
        r02 = RxAwaitKt.await(r04, r152);
        if (r02 == r1) goto L20;
    L54:
        r0 = (pb6349ffb$p6d9e0861$1) r15;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L13;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L17
    }

    @Override // p83f5c3ad.pb3f20355.p5b55d2ff
    public object MakePayback(p0e6dda02 r1, Continuation<p1b0ffaae> r2) {
        return r1.makePayback(r2);
    }

    @Override // p83f5c3ad.pb3f20355.p5b55d2ff
    public object StartContactless(p0e6dda02 r1, Continuation<p0e6dda02> r2) {
        return r1.startContactless(r2);
    }
}

