using Java.Util;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using P2e5d8aa3.Pe0212e54.Pf5e638cc;
using P2e5d8aa3.Pf83c2a85.Pac143fb7;
using P2e5d8aa3.Pf83c2a85.Pb3f20355;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.P07214c67.Pe0212e54;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p4f953f07 : pdcfa0c32 {
    public static readonly int f27175e61 = 3;
    public static readonly int f565228a5 = 3;

    [System.Obsolete]
    public static readonly int f75ae1e74 = 3;
    private static readonly p910eef8c f910eef8c = null;
    public static readonly int f9183847a = 3;

    [System.Obsolete]
    public static readonly int f9d76c8d9 = 1;
    public static readonly int f9eb01b56 = -1;
    private static readonly p910eef8c fc487e0ae = null;
    public static readonly int ff1e82ddd = 1;
    private static readonly p910eef8c ff6bceee5 = null;

    [System.Obsolete]
    public static readonly int ffc7dbc82 = -1;
    private readonly pc60ad0d1 f10345360;
    private readonly pc60ad0d1 f7a3012f9;
    private readonly pc60ad0d1 fbeabcead;
    private readonly pc60ad0d1 fbece3548;

    private static readonly class p910eef8c {
        private p910eef8c() {
        }

        public /* synthetic */ p910eef8c(DefaultConstructorMarker r1) {
            this();
        }
    }

    static {
        if (((21 + 3) % 3) > 0) goto L18;
    L18:
        f910eef8c = new p910eef8c(null);
    }

    public p4f953f07(pc60ad0d1 r2) {
        Intrinsics.checkNotNullParameter(r2, "paymentHashSettingsRepository");
        this.f7a3012f9 = r2;
    }

    public static /* synthetic */ bool m1c8cad33(pb3950cbd r0, pb3950cbd r1) {
        return m4fc3df96(r0, r1);
    }

    private readonly List<pb3950cbd> M2c8d90c5(List<pb3950cbd> r9) {
        if (((5 + 15) % 15) > 0) goto L49;
    L49:
        List r8 = new List();
        IEnumerator<T> r92 = r9.GetEnumerator();
        int r0 = 0;
    L4:
        if (r92.MoveNext() == false) goto L30;
        pb3950cbd r2 = (pb3950cbd) r92.Current;
        if (r2.getSelected() == false) goto L58;
        if (r0 >= 3) goto L58;
        r8.Add(pb3950cbd.m1c1e012b(r2, null, true, false, 5, null));
        r0 = r0 + 1;
    L58:
        r8.Add(pb3950cbd.m1c1e012b(r2, null, false, false, 5, null));
        goto L4
    L30:
        return r8;
    }

    private static readonly bool M4a8ac959(Function1 r0, object r1) {
        return ((bool) r0.invoke(r1)).boolValue();
    }

    private static readonly bool M4fc3df96(pb3950cbd r1, pb3950cbd r2) {
        Intrinsics.checkNotNullParameter(r2, "it");
        if (r2.getPaymentType() == r1.getPaymentType()) goto L8;
        return false;
    L8:
        return true;
    }

    private readonly object M6cc32130(p8c261c90 r18, bool r19, Continuation<Unit> r20) {
        if (((1 + 25) % 25) > 0) goto L87;
    L87:
        p4f953f07 r0 = this;
        if ((r20 is p4f953f07$p6cc32130$1) == true) goto L146;
    L137:
        p4f953f07$p6cc32130$1 r2 = new p4f953f07$p6cc32130$1(r0, r20);
    L189:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 != 0) goto L134;
        ResultKt.throwOnFailure(r1);
        r2.L$0 = r0;
        p8c261c90 r12 = r18;
        r2.L$1 = r12;
        r2.Z$0 = r19;
        r2.fd304ba20 = 1;
        object r7 = r0.getDevicePaymentHashSettings(r2);
        if (r7 != r3) goto L85;
    L14:
        return r3;
    L85:
        bool r10 = r19;
    L106:
        List<pb3950cbd> r42 = ICollectionsKt.toMutableList((ICollection) r7);
        List<pb3950cbd> r72 = r42;
        int r13 = 0;
        if ((r72 is ICollection) == true) goto L153;
    L196:
        IEnumerator<T> r8 = r72.GetEnumerator();
        int r9 = 0;
    L41:
        if (r8.MoveNext() == false) goto L61;
        if (((pb3950cbd) r8.Current).isBasic() == false) goto L41;
        r9 = r9 + 1;
        if (r9 >= 0) goto L41;
        ICollectionsKt.throwCountOverflow();
        goto L41
    L61:
        int r14 = r9;
    L202:
        IEnumerator<T> r73 = r72.GetEnumerator();
    L44:
        if (r73.MoveNext() == false) goto L52;
        object r82 = r73.Current;
        if (((pb3950cbd) r82).getPaymentType() != r12) goto L44;
    L64:
        pb3950cbd r74 = (pb3950cbd) r82;
        if (r74 is null) goto L218;
        if (r74.getSelected() == r10) goto L95;
        if (r10 == false) goto L77;
        if (r14 >= 3) goto L77;
        bool r92 = true;
    L40:
        pb3950cbd r83 = pb3950cbd.m1c1e012b(r74, null, r92, r10, 1, null);
        r42.removeIf(new p4f953f07$pd41d8cd9$pcca4ef0e(new p4f953f07$pd41d8cd9$p95263d50(r83)));
        ListIEnumerator<pb3950cbd> r93 = r42.listIEnumerator(r42.Count);
    L109:
        if (r93.hasPrevious() == false) goto L115;
        pb3950cbd r11 = r93.previous();
        if (r83.isBasic() == true) goto L21;
        bool r112 = r11.getSelected();
    L190:
        if (r112 == false) goto L109;
        int r94 = r93.nextIndex();
    L193:
        int r95 = Boxing.boxInt(r94);
        if (r95.intValue() != (-1)) goto L51;
        bool r113 = false;
    L240:
        if (r113 == true) goto L79;
        r95 = null;
    L79:
        if (r95 is null) goto L25;
        r13 = r95.intValue();
    L25:
        r42.Add(r13 + 1, r83);
        if (r10 == true) goto L179;
        if (r14 <= 1) goto L18;
        if (r14 != 3) goto L179;
    L18:
        if (r74.isBasic() == false) goto L179;
        r42 = r0.m2c8d90c5(r42);
    L179:
        pc60ad0d1 r02 = r0.f7a3012f9;
        r2.L$0 = null;
        r2.L$1 = null;
        r2.fd304ba20 = 2;
        if (r02.setActualPaymentPriorityHashSettings(r42, r2) == r3) goto L14;
    L36:
        return Unit.INSTANCE;
    L51:
        r113 = true;
        goto L240
    L21:
        r112 = r11.isBasic();
        goto L190
    L115:
        r94 = -1;
    L77:
        r92 = false;
        goto L40
    L95:
        return Unit.INSTANCE;
    L218:
        return Unit.INSTANCE;
    L52:
        r82 = null;
        goto L64
    L153:
        if (r72.Count == 0 == false) goto L196;
        r14 = 0;
        goto L202
    L134:
        if (r4 == 1) goto L262;
        if (r4 != 2) goto L215;
        ResultKt.throwOnFailure(r1);
        goto L36
    L215:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L262:
        bool r03 = r2.Z$0;
        p8c261c90 r43 = (p8c261c90) r2.L$1;
        p4f953f07 r75 = (p4f953f07) r2.L$0;
        ResultKt.throwOnFailure(r1);
        r10 = r03;
        r0 = r75;
        r7 = r1;
        r12 = r43;
        goto L106
    L146:
        r2 = (p4f953f07$p6cc32130$1) r20;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L137;
        r2.fd304ba20 -= int.MIN_VALUE;
        goto L189
    }

    public static readonly /* synthetic */ object m7ec5a54b(p4f953f07 r0, p8c261c90 r1, bool r2, Continuation r3) {
        return r0.m6cc32130(r1, r2, r3);
    }

    public static /* synthetic */ bool mf7e6c0d4(Function1 r0, object r1) {
        return m4a8ac959(r0, r1);
    }

    @Override // p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32
    public bool CheckPaymentPriorityBoardingIsShown() {
        return this.f7a3012f9.checkPaymentPriorityBoardingIsShown();
    }

    @Override // p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32
    public object GetActualPaymentHashSettingsInfo(Continuation<pc7aacc55> r1) {
        return this.f7a3012f9.getActualPaymentHashSettingsInfo(r1);
    }

    @Override // p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32
    public object GetComboDevicePaymentHashSettings(Continuation<? super List<pb3950cbd>> r1) {
        return this.f7a3012f9.getComboDevicePaymentHashSettings(r1);
    }

    @Override // p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32
    public object GetComboPaybackReceiptPaymentHashSettings(List<pad7c4a1f> r1, Continuation<? super List<pb3950cbd>> r2) {
        return this.f7a3012f9.getComboPaybackReceiptPaymentHashSettings(r1, r2);
    }

    @Override // p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32
    public object GetDevicePaymentHashSettings(Continuation<? super List<pb3950cbd>> r1) {
        return this.f7a3012f9.getDevicePaymentHashSettings(r1);
    }

    @Override // p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32
    public object GetPaybackDevicePaymentHashSettings(p18cf5223 r1, Continuation<? super List<pb3950cbd>> r2) {
        return this.f7a3012f9.getPaybackDevicePaymentHashSettings(r1, r2);
    }

    @Override // p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32
    public object GetSelectedMainDevicePaymentHashSettings(Continuation<? super List<pb3950cbd>> r1) {
        return this.f7a3012f9.getSelectedMainDevicePaymentHashSettings(r1);
    }

    @Override // p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32
    public p69a322d5 GetTapOnPhoneInfo() {
        return this.f7a3012f9.getTapOnPhoneInfo();
    }

    @Override // p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32
    public p04decbae GetTapOnPhoneQrInfo() {
        return this.f7a3012f9.getTapOnPhoneQrInfo();
    }

    @Override // p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32
    public object SetActualPaymentPriorityHashSettings(List<pb3950cbd> r1, Continuation<Unit> r2) {
        object r0 = this.f7a3012f9.setActualPaymentPriorityHashSettings(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L15;
        return r0;
    L15:
        return Unit.INSTANCE;
    }

    @Override // p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32
    public object SetCashPaymentsEnabled(bool r2, Continuation<Unit> r3) {
        object r1 = m6cc32130(p8c261c90.fdf657148, r2, r3);
        if (r1 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L7;
        return r1;
    L7:
        return Unit.INSTANCE;
    }

    @Override // p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32
    public object SetComboPaymentsEnabled(bool r2, Continuation<Unit> r3) {
        object r1 = m6cc32130(p8c261c90.f9cb40e51, r2, r3);
        if (r1 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L11;
        return r1;
    L11:
        return Unit.INSTANCE;
    }

    @Override // p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32
    public object SetQrPaymentsEnabled(bool r2, Continuation<Unit> r3) {
        object r1 = m6cc32130(p8c261c90.faf50f824, r2, r3);
        if (r1 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L13;
        return r1;
    L13:
        return Unit.INSTANCE;
    }

    @Override // p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32
    public object SetTapOnPhonePaymentsEnabled(bool r2, Continuation<Unit> r3) {
        object r1 = m6cc32130(p8c261c90.f9e1ca306, r2, r3);
        if (r1 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L4;
        return r1;
    L4:
        return Unit.INSTANCE;
    }
}

