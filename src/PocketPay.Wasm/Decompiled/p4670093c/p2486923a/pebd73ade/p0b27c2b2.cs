using Androidx.Lifecycle;
using Com.Decryptstringmanager;
using Java.Util;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using Kotlin.Text;
using Kotlinx.Coroutines;
using P1e11b989.P438fa616.Pfd9160bb;
using P1e11b989.Pd3ed68f7.Pfd9160bb;
using P2b3583e6;
using P2b3583e6.P4a931512;
using P2b3583e6.Pf7a42fe7;
using P2e5d8aa3.Pee11cbb1.Pac143fb7;
using P2e5d8aa3.Pf83c2a85.Pac143fb7;
using P2e5d8aa3.Pfd9160bb;
using P4670093c.P07214c67;
using P4670093c.Pac143fb7;
using P4670093c.Pfd9160bb;
using P83f5c3ad.P684019bc;
using P83f5c3ad.P68c4283d;
using P83f5c3ad.Pfd9160bb;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.P07214c67.Pe0212e54;
using Pad5f82e8.P07214c67.Pe907423b;
using Pad5f82e8.P07214c67.Pfd9160bb;
using Pad5f82e8.Pac143fb7.P01faf383;
using Pc69c522d.Pf83c2a85.Pfd9160bb;
using Pd2a57dc1.Pfd9160bb;
using Pe0212e54.Pac143fb7;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p0b27c2b2 : objectModel {
    private readonly pfdb21b31 f014ff98c;
    private readonly p995fd851 f0a45aac9;
    private readonly pa36ef9b5 f0d3e163c;
    private readonly pdcfa0c32 f1b2283c4;
    private readonly pcbd77ab2 f1c7159d0;
    private readonly pcbd77ab2 f2408d71f;
    private readonly MutableLiveData f264f2db7;
    private p18cf5223 f27797d5b;
    private readonly p8907e230 f2856f6c9;
    private readonly p1b3a5bf0 f2b2a1791;
    private readonly p4b8940c0 f2caee680;
    private readonly p995fd851 f2dc9ae45;
    private readonly MutableLiveData f2dcd56bd;
    private readonly pee785de8 f358af76b;
    private readonly pfdb21b31 f37b6a15b;
    private readonly pee785de8 f37c9e91b;
    private readonly pc32333e1 f3ddcd2cc;
    private readonly pc32333e1 f3e785377;
    private readonly pc32333e1 f40648157;
    private readonly p4b8940c0 f43c8f73a;
    private readonly p11c216e8 f46312db1;
    private readonly p2e423cc6 f4734ade7;
    private readonly pe8cda3fc f492334f0;
    private readonly pc32333e1 f4c6cf4e4;
    private readonly p2e423cc6 f4eb90208;
    private readonly MutableLiveData f5122644f;
    private p18cf5223 f5406ab3b;
    private readonly pe8cda3fc f57e31ce7;
    private readonly pee785de8 f5d2d9ffe;
    private p18cf5223 f5d967de8;
    private readonly pe8cda3fc f5e58e308;
    private readonly MutableLiveData f5f03694f;
    private readonly p1ceed351 f62520fad;
    private readonly p1b3a5bf0 f65bb51d6;
    private readonly p995fd851 f6795ffa5;
    private readonly pc32333e1 f6b54ed8e;
    private readonly MutableLiveData f6cf1d4cf;
    private readonly p4b8940c0 f750f6c54;
    private readonly pdcfa0c32 f76faca0c;
    private readonly p8907e230 f79482adf;
    private readonly p1ceed351 f7b725b0e;
    private readonly MutableLiveData f80d5f9c8;
    private readonly pcbd77ab2 f819db8dd;
    private readonly pdcfa0c32 f841a20c4;
    private readonly p1b3a5bf0 f86076b52;
    private readonly p1ceed351 f8a4da4c9;
    private readonly MutableLiveData f8b4809ec;
    private readonly MutableLiveData<List<pb3950cbd>> f8e54ec30;
    private readonly pcbd77ab2 f8f0471ca;
    private readonly pe8cda3fc f91e27e5d;
    private readonly pee785de8 fa0aaa7fd;
    private readonly p11c216e8 fa0cff2e4;
    private readonly MutableLiveData fa29dbe7d;
    private readonly p0fce535b fa2eb2d98;
    private readonly p8907e230 fa32ba8de;
    private readonly p2e423cc6 fa54644e2;
    private readonly p995fd851 fa6f36ee5;
    private readonly MutableLiveData fa80090cb;
    private readonly p8907e230 fa86d9a4b;
    private readonly MutableLiveData fb24e1c88;
    private p18cf5223 fba3d0b7d;
    private readonly MutableLiveData<p068d0b80> fc18a89a3;
    private p18cf5223 fc847bd37;
    private readonly p8907e230 fc9ccdda3;
    private readonly p4b8940c0 fcd8f01bc;
    private readonly pdcfa0c32 fce765563;
    private readonly pfdb21b31 fd0666c3c;
    private readonly p11c216e8 fd3f9d820;
    private readonly p995fd851 fd48447f6;
    private readonly pa36ef9b5 fd7246c57;
    private readonly p4b8940c0 fda1713fa;
    private readonly MutableLiveData<p29395c74> fdd1e0075;
    private readonly p1ceed351 fe4d1cd5f;
    private readonly p11c216e8 fe69201ed;
    private readonly p0fce535b feaabe560;
    private readonly p11c216e8 feefeb260;
    private readonly pee785de8 ff36e84be;
    private readonly MutableLiveData<pb3f3bb37> ffb8bfbeb;

    public /* synthetic */ class p12c674ac {
        public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$0 = null;

        static {
            if (((18 + 25) % 25) > 0) goto L13;
        L13:
            int[] r0 = new int[ped8819d3.Values.length];
            r0[ped8819d3.f61a649a3.ordinal()] = 1;     // Catch: NoSuchFieldError -> L26
        L28:
            r0[ped8819d3.ff9dd946c.ordinal()] = 2;     // Catch: NoSuchFieldError -> L27
        L5:
            $EnumSwitchDictionaryping$0 = r0;
        }
    }

    public p0b27c2b2(pa36ef9b5 r17, pdcfa0c32 r18, pfdb21b31 r19, p4b8940c0 r20, p8907e230 r21, p995fd851 r22, p2e423cc6 r23, p11c216e8 r24, p1b3a5bf0 r25, pee785de8 r26, p1ceed351 r27, pc32333e1 r28, pe8cda3fc r29, pcbd77ab2 r30, p0fce535b r31) {
        if (((8 + 12) % 12) > 0) goto L39;
    L39:
        Intrinsics.checkNotNullParameter(r17, "paybackReceiptUseCase");
        Intrinsics.checkNotNullParameter(r18, "paymentHashSettingsUseCase");
        Intrinsics.checkNotNullParameter(r19, "userHashSettingsUseCase");
        Intrinsics.checkNotNullParameter(r20, "devicesUseCase");
        Intrinsics.checkNotNullParameter(r21, "vpnUseCase");
        Intrinsics.checkNotNullParameter(r22, "nfcTapOnPhoneUseCase");
        Intrinsics.checkNotNullParameter(r23, "resourceProvider");
        Intrinsics.checkNotNullParameter(r24, "flowRouter");
        Intrinsics.checkNotNullParameter(r25, "paybackRouter");
        Intrinsics.checkNotNullParameter(r26, "settingsRouter");
        Intrinsics.checkNotNullParameter(r27, "tapOnPhoneRouter");
        Intrinsics.checkNotNullParameter(r28, "comboPaymentRouter");
        Intrinsics.checkNotNullParameter(r29, "tophAnalytics");
        Intrinsics.checkNotNullParameter(r30, "receiptCredentialsRouter");
        Intrinsics.checkNotNullParameter(r31, "receiptIntermediateRouter");
        this.f0d3e163c = r17;
        this.fce765563 = r18;
        this.f37b6a15b = r19;
        this.fda1713fa = r20;
        this.fc9ccdda3 = r21;
        this.fd48447f6 = r22;
        this.f4734ade7 = r23;
        this.feefeb260 = r24;
        this.f2b2a1791 = r25;
        this.f37c9e91b = r26;
        this.f62520fad = r27;
        this.f3e785377 = r28;
        this.f91e27e5d = r29;
        this.f1c7159d0 = r30;
        this.feaabe560 = r31;
        this.fdd1e0075 = new MutableLiveData();
        this.fc18a89a3 = new p6a6d86aa();
        this.f8e54ec30 = new MutableLiveData();
        this.ffb8bfbeb = new p6a6d86aa();
    }

    public static readonly /* synthetic */ object m0b1aca54(p0b27c2b2 r0, Continuation r1) {
        return r0.m8320701a(r1);
    }

    public static /* synthetic */ void m11bc5426(p0b27c2b2 r0, object r1) {
        mf48ae4bb(r0, r1);
    }

    public static /* synthetic */ void m3335ee04(p0b27c2b2 r0, object r1) {
        m6410c402(r0, r1);
    }

    public static readonly /* synthetic */ MutableLiveData m3bfa0695(p0b27c2b2 r0) {
        return r0.ffb8bfbeb;
    }

    public static readonly /* synthetic */ void m4e83ebcf(p0b27c2b2 r0) {
        r0.m9e34415c();
    }

    public static readonly /* synthetic */ void m54c2e04a(p0b27c2b2 r0) {
        r0.madc6e75c();
    }

    private readonly string M5bf3cbd5(p18cf5223 r2) {
        string r0 = r2.getClientEmail();
        if (r0 is not null) goto L7;
        string r22 = r2.getClientPhone();
        if (r22 is not null) goto L14;
        return null;
    L14:
        return mcedd7783(r22);
    L7:
        return r0;
    }

    public static readonly /* synthetic */ void m5c81bd4c(p0b27c2b2 r0, p18cf5223 r1) {
        r0.f27797d5b = r1;
    }

    public static readonly /* synthetic */ p2e423cc6 m5fb81a65(p0b27c2b2 r0) {
        return r0.f4734ade7;
    }

    private static readonly void M6410c402(p0b27c2b2 r1, object r2) {
        Intrinsics.checkNotNullParameter(r2, "result");
        r1.m6af8f8e0((pcb7684f4) r2);
    }

    private readonly void M6af8f8e0(pcb7684f4 r5) {
        if (((29 + 27) % 27) > 0) goto L50;
    L50:
        p18cf5223 r4 = this.f27797d5b;
        if (r4 is null) goto L57;
        ped8819d3 r0 = r5.getSelectedValueType();
        if (r0 is not null) goto L49;
        return;
    L49:
        int r02 = p12c674ac.$EnumSwitchDictionaryping$0[r0.ordinal()];
        string r2 = null;
        if (r02 != 1) goto L25;
        r2 = r5.getEmail();
        string r52 = null;
    L53:
        r4.setClientEmail(r2);
        r4.setClientPhone(r52);
        return;
    L25:
        if (r02 != 2) goto L4;
        r52 = r5.getPhone();
        goto L53
    L4:
        throw new NoWhenBranchMatchedException();
    }

    public static readonly /* synthetic */ void m6f326ea1(p0b27c2b2 r0) {
        r0.mdd5069dd();
    }

    public static readonly /* synthetic */ string m7b3f260e(p0b27c2b2 r0, p18cf5223 r1) {
        return r0.m5bf3cbd5(r1);
    }

    private readonly object M8320701a(Continuation<p18cf5223> r32) {
        if (((6 + 28) % 28) > 0) goto L109;
    L109:
        p0b27c2b2 r0 = this;
        if ((r32 is p0b27c2b2$p8320701a$1) == false) goto L115;
        p0b27c2b2$p8320701a$1 r2 = (p0b27c2b2$p8320701a$1) r32;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L115;
        r2.fd304ba20 -= int.MIN_VALUE;
    L99:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 == 0) goto L26;
        if (r4 != 1) goto L87;
        r0 = (p0b27c2b2) r2.L$0;
        ResultKt.throwOnFailure(r1);
    L94:
        p18cf5223 r22 = (p18cf5223) r1;
        p18cf5223 r12 = r0.f27797d5b;
        if (r12 is null) goto L5;
        string r33 = null;
        if (r12 is not null) goto L81;
        string r8 = null;
    L51:
        p18cf5223 r02 = r0.f27797d5b;
        if (r02 is null) goto L106;
        r33 = r02.getClientPhone();
    L106:
        return p18cf5223.m1c1e012b(r22, null, null, null, null, null, r8, r33, null, null, false, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 67108767, null);
    L81:
        r8 = r12.getClientEmail();
        goto L51
    L5:
        return r22;
    L87:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L26:
        ResultKt.throwOnFailure(r1);
        pa36ef9b5 r13 = r0.f0d3e163c;
        r2.L$0 = r0;
        r2.fd304ba20 = 1;
        r1 = r13.getCurrentPaybackReceipt(r2);
        if (r1 != r3) goto L94;
        return r3;
    L115:
        r2 = new p0b27c2b2$p8320701a$1(r0, r32);
        goto L99
    }

    private readonly void M872227a9() {
        if (((10 + 12) % 12) > 0) goto L13;
    L13:
        this.feefeb260.setResultListener(this.f62520fad.getTophAutoActivationKey(), new p0b27c2b2$pd41d8cd9$p144e4630(this));
        this.feefeb260.startFlow(p1ceed351.pb0da8397.me3d62dc6(this.f62520fad, p15913342.fa711e884, null, null, null, 14, null));
    }

    public static /* synthetic */ void m88b45a1c(p0b27c2b2 r0, object r1) {
        mc533f6a4(r0, r1);
    }

    public static readonly /* synthetic */ void m94376a9c(p0b27c2b2 r0, p18cf5223 r1) {
        r0.mee1daf82(r1);
    }

    public static readonly /* synthetic */ p18cf5223 m948ee0b8(p0b27c2b2 r0) {
        return r0.f27797d5b;
    }

    private readonly void M9e34415c() {
        if (((22 + 14) % 14) > 0) goto L33;
    L33:
        this.feefeb260.setResultListener(this.f62520fad.getTophAutoActivationKey(), new p0b27c2b2$pd41d8cd9$p95263d50(this));
        this.f91e27e5d.reportOpenTophEvent("START_TOP_FOR_PAYBACK");
        this.feefeb260.startFlow(p1ceed351.pb0da8397.me3d62dc6(this.f62520fad, p15913342.f86e418e3, null, null, null, 14, null));
    }

    public static readonly /* synthetic */ MutableLiveData ma6dd2715(p0b27c2b2 r0) {
        return r0.f8e54ec30;
    }

    public static readonly /* synthetic */ pfdb21b31 ma82a18e4(p0b27c2b2 r0) {
        return r0.f37b6a15b;
    }

    private readonly void Madc6e75c() {
        this.f3e785377.openPaybackComboPayment();
    }

    public static readonly /* synthetic */ void mb116795c(p0b27c2b2 r0) {
        r0.m872227a9();
    }

    private static readonly void Mb22560fd(p0b27c2b2 r1, object r2) {
        Intrinsics.checkNotNullParameter(r2, "snackbarData");
        if ((r2 is pb3f3bb37) == true) goto L12;
        return;
    L12:
        r1.ffb8bfbeb.setValue(r2);
    }

    public static readonly /* synthetic */ pdcfa0c32 mb272891c(p0b27c2b2 r0) {
        return r0.fce765563;
    }

    private readonly object Mb35f541c(pb5374042 r3, Continuation<Unit> r4) {
        if (((3 + 19) % 19) > 0) goto L4;
    L4:
        p18cf5223 r0 = this.f27797d5b;
        if (r0 is not null) goto L5;
        p22820a6f r02 = null;
    L39:
        if (r02 == p22820a6f.f480d47bf) goto L42;
    L28:
        return Unit.INSTANCE;
    L42:
        p8c261c90 r32 = pb5374042.f910eef8c.getPaymentType(r3);
        if (r32 is null) goto L28;
        object r2 = this.f0d3e163c.setPaymentType(r32, r4);
        if (r2 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L13;
        return r2;
    L13:
        return Unit.INSTANCE;
    L5:
        r02 = r0.getReceiptType();
        goto L39
    }

    private static readonly void Mc533f6a4(p0b27c2b2 r1, object r2) {
        Intrinsics.checkNotNullParameter(r2, "snackbarData");
        if ((r2 is pb3f3bb37) == true) goto L14;
        return;
    L14:
        r1.ffb8bfbeb.setValue(r2);
    }

    public static readonly /* synthetic */ object mcb5dfeca(p0b27c2b2 r0, Continuation r1) {
        return r0.mcea05811(r1);
    }

    private readonly object Mcea05811(Continuation<Unit> r6) {
        if (((6 + 13) % 13) > 0) goto L55;
    L55:
        if ((r6 is p0b27c2b2$pcea05811$1) == true) goto L58;
    L90:
        p0b27c2b2$pcea05811$1 r0 = new p0b27c2b2$pcea05811$1(this, r6);
    L75:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L25;
        if (r2 == 1) goto L79;
        if (r2 != 2) goto L64;
    L77:
        ResultKt.throwOnFailure(r62);
    L40:
        return Unit.INSTANCE;
    L64:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L79:
        p0b27c2b2 r5 = (p0b27c2b2) r0.L$0;
        goto L77
    L25:
        ResultKt.throwOnFailure(r62);
        p18cf5223 r63 = this.f27797d5b;
        if (r63 is null) goto L98;
        string r64 = r63.getClientEmail();
        if (r64 is null) goto L98;
        pa36ef9b5 r22 = this.f0d3e163c;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (r22.setReceiptClientEmail(r64, r0) != r1) goto L40;
    L92:
        return r1;
    L98:
        p18cf5223 r65 = this.f27797d5b;
        if (r65 is null) goto L40;
        string r66 = r65.getClientPhone();
        if (r66 is null) goto L40;
        pa36ef9b5 r52 = this.f0d3e163c;
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        if (r52.setReceiptClientPhone(r66, r0) == r1) goto L92;
    L58:
        r0 = (p0b27c2b2$pcea05811$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L90;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L75
    }

    private readonly string Mcedd7783(string r7) {
        if (((21 + 24) % 24) > 0) goto L22;
    L22:
        return p720e732c.mde0e893c(stringsKt.replace$default(r7, Decryptstring.decryptstring("abc73f16dba66ed8551634098c22b7a50bff815818e6e44850db14d0f0"), "", false, 4, null));
    }

    public static readonly /* synthetic */ MutableLiveData md2ef6b93(p0b27c2b2 r0) {
        return r0.fdd1e0075;
    }

    public static readonly /* synthetic */ pa36ef9b5 md95a43c7(p0b27c2b2 r0) {
        return r0.f0d3e163c;
    }

    public static readonly /* synthetic */ object mdc77543b(p0b27c2b2 r0, pb5374042 r1, Continuation r2) {
        return r0.mb35f541c(r1, r2);
    }

    private readonly void Mdd5069dd() {
        this.feaabe560.openIntermediatePaybackReceipt();
    }

    public static /* synthetic */ void me4e4e35f(p0b27c2b2 r0, object r1) {
        mf4d2e3f9(r0, r1);
    }

    public static readonly /* synthetic */ p995fd851 mecf2730e(p0b27c2b2 r0) {
        return r0.fd48447f6;
    }

    private readonly void Mee1daf82(p18cf5223 r8) {
        if (((28 + 21) % 21) > 0) goto L24;
    L24:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p0b27c2b2$pee1daf82$1(this, r8, null), 3, null);
    }

    public static /* synthetic */ void mf25c6395(p0b27c2b2 r0, object r1) {
        mb22560fd(r0, r1);
    }

    private static readonly void Mf48ae4bb(p0b27c2b2 r1, object r2) {
        Intrinsics.checkNotNullParameter(r2, "snackbarData");
        if ((r2 is pb3f3bb37) == true) goto L11;
        return;
    L11:
        r1.ffb8bfbeb.setValue(r2);
    }

    private static readonly void Mf4d2e3f9(p0b27c2b2 r1, object r2) {
        Intrinsics.checkNotNullParameter(r2, "result");
        r1.m6af8f8e0((pcb7684f4) r2);
    }

    public static readonly /* synthetic */ MutableLiveData mf5835c6d(p0b27c2b2 r0) {
        return r0.fc18a89a3;
    }

    public readonly void Back() {
        if (((25 + 3) % 3) > 0) goto L17;
    L17:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p0b27c2b2$p469bba0a$1(this, null), 3, null);
    }

    public readonly string GetPaymentAddress() {
        return this.f37b6a15b.getPaymentAddress();
    }

    public readonly LiveData<pb3f3bb37> GetSnackbarStatus() {
        return this.ffb8bfbeb;
    }

    public readonly bool HasVpn() {
        return this.fc9ccdda3.hasVpn();
    }

    public readonly void InitReceiptInfo() {
        if (((21 + 18) % 18) > 0) goto L5;
    L5:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p0b27c2b2$p290884f0$1(this, null), 3, null);
    }

    public readonly LiveData<List<pb3950cbd>> ObserveDevicePaymentHashSettings() {
        return this.f8e54ec30;
    }

    public readonly LiveData<p068d0b80> ObserveReceiptInfoLiveData() {
        return this.fc18a89a3;
    }

    public readonly LiveData<p29395c74> ObserveShowAddressAndCredentials() {
        return this.fdd1e0075;
    }

    public readonly void OpenAddressHashSettings() {
        if (((5 + 2) % 2) > 0) goto L8;
    L8:
        pee785de8 r0 = this.f37c9e91b;
        p0b27c2b2$pd41d8cd9$p00f53dc7 r1 = new p0b27c2b2$pd41d8cd9$p00f53dc7(this);
        r0.setResultListener(Decryptstring.decryptstring("ed29fdca6917dee296109a82f206e1bf547533fc34526bf3537bb9d5efabbdf70aef26c0a9cee06e2516dc8f8d"), r1);
        this.f37c9e91b.openPaymentPlace();
    }

    public readonly void OpenPreviousScreen() {
        this.f2b2a1791.back();
    }

    public readonly void OpenSendingReceipt() {
        if (((28 + 24) % 24) > 0) goto L3;
    L3:
        pcbd77ab2 r0 = this.f1c7159d0;
        r0.setResultListener(r0.getReceiptCredentialsKey(), new p0b27c2b2$pd41d8cd9$p437e9676(this));
        pcbd77ab2 r02 = this.f1c7159d0;
        p18cf5223 r1 = this.f27797d5b;
        string r2 = null;
        if (r1 is null) goto L29;
        string r12 = r1.getClientEmail();
    L8:
        p18cf5223 r3 = this.f27797d5b;
        if (r3 is not null) goto L5;
    L24:
        r02.openReceiptSending(r12, r2);
        return;
    L5:
        r2 = r3.getClientPhone();
        goto L24
    L29:
        r12 = null;
        goto L8
    }

    public readonly void OpenHashSettingsSendingReceipt() {
        if (((20 + 16) % 16) > 0) goto L22;
    L22:
        pee785de8 r0 = this.f37c9e91b;
        r0.setResultListener(r0.getReceiptCredentialsKey(), new p0b27c2b2$pd41d8cd9$pcca4ef0e(this));
        this.f37c9e91b.openReceiptSending();
    }

    public readonly void ProcessPayment(pb5374042 r8) {
        if (((7 + 30) % 30) > 0) goto L31;
    L31:
        Intrinsics.checkNotNullParameter(r8, "paymentTypeobjectState");
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p0b27c2b2$pe46e6a04$1(this, r8, null), 3, null);
    }

    public readonly void SelectPaymentSystem(Function0<Unit> r9, Function0<Unit> r10, Function0<Unit> r11) {
        if (((14 + 29) % 29) > 0) goto L41;
    L41:
        Intrinsics.checkNotNullParameter(r9, "onSuccess");
        Intrinsics.checkNotNullParameter(r10, "onCredentialNotValid");
        Intrinsics.checkNotNullParameter(r11, "onAddressNotValid");
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p0b27c2b2$p1039754b$1(this, r9, r11, r10, null), 3, null);
    }

    public readonly void SetShouldPrintReceipt(bool r8) {
        if (((2 + 19) % 19) > 0) goto L27;
    L27:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p0b27c2b2$p581e088e$1(this, r8, null), 3, null);
    }
}

