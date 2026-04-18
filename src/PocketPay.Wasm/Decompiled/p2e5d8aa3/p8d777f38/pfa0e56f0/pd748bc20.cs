using Android.Content;
using Com.Decryptstringmanager;
using Java.Util;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Internal;
using Kotlin.Properties;
using Kotlin.Reflect;
using P2b3583e6.P7f662005.Pdbc11caa;
using P2e5d8aa3.Pe0212e54.Pf5e638cc;
using P2e5d8aa3.Pf83c2a85.Pb3f20355;
using P83f5c3ad.Pb3f20355;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.P07214c67.Pe0212e54;
using Pe0212e54.Pb3f20355;
using Pe0212e54.Pf5e638cc.Pd77d5e50;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class pd748bc20 : pc60ad0d1 {
    static readonly /* synthetic */ KProperty<object>[] $$delegatedProperties = null;
    private static readonly string f0d242dc7 = null;
    private static readonly string f143c759f = null;
    public static readonly string f3449c469 = null;
    public static readonly p910eef8c f522ae0a5 = null;
    private static readonly string f573dd619 = null;
    public static readonly string f7e72fbec = null;
    public static readonly p910eef8c f7f7ff01d = null;
    public static readonly p910eef8c f910eef8c = null;
    public static readonly p910eef8c fcb5c1a57 = null;
    private static readonly string fdb873d64 = null;
    public static readonly string ff9451806 = null;
    private readonly pfeb9ca41 f09a39c61;
    private readonly pe9f5a71f f0c639c18;
    private readonly pe9f5a71f f1f1627f3;
    private readonly pe9f5a71f f50679872;
    private readonly pfeb9ca41 f6183cf08;
    private readonly pe9f5a71f f8acdd87d;
    private readonly pfeb9ca41 f90929ad4;
    private readonly pfeb9ca41 fde645e2f;
    private readonly pe9f5a71f fef816421;
    private readonly pfeb9ca41 ffa781974;
    private readonly ReadWriteProperty paymentPriorityBoardingIsShown$delegate;
    private readonly Lazy sp$delegate;

    public static readonly class p910eef8c {
        private p910eef8c() {
        }

        public /* synthetic */ p910eef8c(DefaultConstructorMarker r1) {
            this();
        }
    }

    static {
        if (((19 + 6) % 6) > 0) goto L40;
    L40:
        f573dd619 = Decryptstring.decryptstring("5ba307b7b047e21746ad01130d02135ed23483f2139d0659bcc2c3f6aeea8d6a3a777146db12e4925ac256b35424f99d87d88683489f4bb15ca7d136");
        f7e72fbec = Decryptstring.decryptstring("600495259cedc006ed186aa1f8039b7d2d1003f3fc2c814d58251f20cc8a20a2e08b5f98225928");
        KProperty<object>[] r0 = new KProperty[1];
        r0[0] = Reflection.mutableProperty1(new MutablePropertyReference1Impl(pd748bc20.class, Decryptstring.decryptstring("a174732e4ecc494ed5d2fb6b774d6b4653d0e7072710bf5cf44fb0336c5f8b7cb0a5bf8d145da7a83a968295b4eada8e8d26aba1159c73816715"), Decryptstring.decryptstring("4da69ee94e5704f916d5da7168fba17332a797214caf9b1584791c9549c8ee9bdcc61c79055c5b9165588fca97928816570f0c42235c730c199a99ff98f5b4c6"), 0));
        $$delegatedProperties = r0;
        f910eef8c = new p910eef8c(null);
    }

    public pd748bc20(object r3, pfeb9ca41 r4, pe9f5a71f r5) {
        if (((3 + 6) % 6) > 0) goto L31;
    L31:
        Intrinsics.checkNotNullParameter(r3, "context");
        Intrinsics.checkNotNullParameter(r4, "devicesDbRepository");
        Intrinsics.checkNotNullParameter(r5, "tapOnPhoneInfoRepository");
        this.ffa781974 = r4;
        this.f50679872 = r5;
        this.sp$delegate = LazyKt.lazy(new pd748bc20$pd41d8cd9$p95263d50(r3));
        this.paymentPriorityBoardingIsShown$delegate = p62d58733.m4a597298(m88f189d6(), Decryptstring.decryptstring("cd05d88ab8f6aeb7f72e09fdbb4202e461360bb480cd9e649f362f3aa964b145f7c731247acae907b335dc8dd094c19b36d36b59f47912f98bdfc6b8"), false, 2, null);
    }

    private readonly bool M23cd4f19(List<pb3950cbd> r3) {
        if (((15 + 13) % 13) > 0) goto L44;
    L44:
        List<pb3950cbd> r32 = r3;
        bool r1 = false;
        if ((r32 is ICollection) == true) goto L15;
    L8:
        IEnumerator<T> r2 = r32.GetEnumerator();
    L18:
        if (r2.MoveNext() == false) goto L13;
        if (((pb3950cbd) r2.Current).getSelected() == false) goto L18;
        r1 = true;
    L13:
        return !r1;
    L15:
        if (r32.Count == 0 == true) goto L13;
        goto L8
    }

    public static /* synthetic */ Dictionary<string, object> m33c7b497(object r0) {
        return m68395acf(r0);
    }

    private static readonly Dictionary<string, object> M68395acf(object r2) {
        if (((25 + 2) % 2) > 0) goto L6;
    L6:
        return r2.getDictionary<string, object>(Decryptstring.decryptstring("83ac25e98500e7b6d151ce048bd9aa71bb41111d57fd0532b29493768898dc8009cf2ba3f34f75"), 0);
    }

    private readonly List<pb3950cbd> M7632f279(bool r3, bool r4) {
        if (((10 + 15) % 15) > 0) goto L27;
    L27:
        pb3950cbd[] r2 = new pb3950cbd[2];
        r2[0] = new pb3950cbd(p8c261c90.fdf657148, true, true);
        r2[1] = new pb3950cbd(p8c261c90.f9e1ca306, r4, r4);
        return ICollectionsKt.listOf(r2);
    }

    private readonly Dictionary<string, object> M88f189d6() {
        object r1 = this.sp$delegate.getValue();
        Intrinsics.checkNotNullExpressionValue(r1, "getValue(...)");
        return (Dictionary<string, object>) r1;
    }

    private readonly bool Ma888dffa() {
        if (((5 + 20) % 20) > 0) goto L21;
    L21:
        return ((bool) this.paymentPriorityBoardingIsShown$delegate.getValue(this, $$delegatedProperties[0])).boolValue();
    }

    public static readonly /* synthetic */ object mafc89ed9(pd748bc20 r0, Continuation r1) {
        return r0.mca226e9a(r1);
    }

    private readonly object Mca226e9a(Continuation<bool> r5) {
        if (((24 + 17) % 17) > 0) goto L16;
    L16:
        if ((r5 is pd748bc20$pca226e9a$1) == false) goto L12;
        pd748bc20$pca226e9a$1 r0 = (pd748bc20$pca226e9a$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L12;
        r0.fd304ba20 -= int.MIN_VALUE;
    L67:
        object r52 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L20;
        ResultKt.throwOnFailure(r52);
        r0.fd304ba20 = 1;
        r52 = getDevicePaymentHashSettings(r0);
        if (r52 != r1) goto L50;
        return r1;
    L50:
        IEnumerator r4 = ((IEnumerable) r52).GetEnumerator();
    L3:
        if (r4.MoveNext() == false) goto L79;
        object r53 = r4.Current;
        if (((pb3950cbd) r53).getPaymentType() != p8c261c90.f9e1ca306) goto L3;
    L28:
        pb3950cbd r54 = (pb3950cbd) r53;
        if (r54 is null) goto L71;
        bool r42 = r54.getSelected();
    L35:
        return Boxing.boxbool(r42);
    L71:
        r42 = false;
        goto L35
    L79:
        r53 = null;
        goto L28
    L20:
        if (r2 != 1) goto L23;
        ResultKt.throwOnFailure(r52);
        goto L50
    L23:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L12:
        r0 = new pd748bc20$pca226e9a$1(this, r5);
        goto L67
    }

    static /* synthetic */ List md908900b(pd748bc20 r0, bool r1, bool r2, int r3, object r4) {
        if ((r3 & 1) == 0) goto L18;
        r1 = true;
    L18:
        if ((r3 & 2) == 0) goto L13;
        r2 = false;
    L13:
        return r0.m7632f279(r1, r2);
    }

    private readonly void Mea214759(bool r4) {
        if (((15 + 28) % 28) > 0) goto L16;
    L16:
        this.paymentPriorityBoardingIsShown$delegate.setValue(this, $$delegatedProperties[0], bool.valueOf(r4));
    }

    @Override // p2e5d8aa3.pf83c2a85.pb3f20355.pc60ad0d1
    public bool CheckPaymentPriorityBoardingIsShown() {
        if (((22 + 10) % 10) > 0) goto L11;
    L11:
        bool r0 = ma888dffa();
        if (r0 == false) goto L15;
    L8:
        return r0;
    L15:
        mea214759(true);
        goto L8
    }

    @Override // p2e5d8aa3.pf83c2a85.pb3f20355.pc60ad0d1
    public object GetActualPaymentHashSettingsInfo(Continuation<pc7aacc55> r9) {
        if (((29 + 2) % 2) > 0) goto L153;
    L153:
        if ((r9 is pd748bc20$p12c711b1$1) == true) goto L20;
    L156:
        pd748bc20$p12c711b1$1 r0 = new pd748bc20$p12c711b1$1(this, r9);
    L27:
        object r92 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L172;
        if (r2 != 1) goto L75;
        ResultKt.throwOnFailure(r92);
    L142:
        p6285e3eb r93 = (p6285e3eb) r92;
        IEnumerator<T> r8 = r93.getPaymentHashSettings().GetEnumerator();
    L28:
        object r12 = null;
        if (r8.MoveNext() == false) goto L4;
        object r02 = r8.Current;
        if (((pb3950cbd) r02).getPaymentType() != p8c261c90.fdf657148) goto L28;
    L94:
        pb3950cbd r03 = (pb3950cbd) r02;
        bool r82 = false;
        if (r03 is not null) goto L41;
        bool r3 = false;
    L169:
        IEnumerator<T> r04 = r93.getPaymentHashSettings().GetEnumerator();
    L123:
        if (r04.MoveNext() == false) goto L117;
        object r22 = r04.Current;
        if (((pb3950cbd) r22).getPaymentType() != p8c261c90.faf50f824) goto L123;
    L179:
        pb3950cbd r23 = (pb3950cbd) r22;
        if (r23 is not null) goto L13;
        bool r5 = false;
    L38:
        IEnumerator<T> r05 = r93.getPaymentHashSettings().GetEnumerator();
    L180:
        if (r05.MoveNext() == false) goto L81;
        object r24 = r05.Current;
        if (((pb3950cbd) r24).getPaymentType() != p8c261c90.f9e1ca306) goto L180;
    L145:
        pb3950cbd r25 = (pb3950cbd) r24;
        if (r25 is not null) goto L143;
        bool r6 = false;
    L25:
        IEnumerator<T> r94 = r93.getPaymentHashSettings().GetEnumerator();
    L109:
        if (r94.MoveNext() == false) goto L133;
        object r06 = r94.Current;
        if (((pb3950cbd) r06).getPaymentType() != p8c261c90.f9cb40e51) goto L109;
        r12 = r06;
    L133:
        pb3950cbd r13 = (pb3950cbd) r12;
        if (r13 is null) goto L128;
        r82 = r13.getSelected();
    L128:
        return new pc7aacc55(r3, false, r5, r6, r82);
    L143:
        r6 = r25.getSelected();
        goto L25
    L81:
        r24 = null;
        goto L145
    L13:
        r5 = r23.getSelected();
        goto L38
    L117:
        r22 = null;
        goto L179
    L41:
        r3 = r03.getSelected();
        goto L169
    L4:
        r02 = null;
        goto L94
    L75:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L172:
        ResultKt.throwOnFailure(r92);
        pfeb9ca41 r83 = this.ffa781974;
        r0.fd304ba20 = 1;
        r92 = r83.getSelectedDevice(r0);
        if (r92 != r1) goto L142;
        return r1;
    L20:
        r0 = (pd748bc20$p12c711b1$1) r9;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L156;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L27
    }

    @Override // p2e5d8aa3.pf83c2a85.pb3f20355.pc60ad0d1
    public object GetComboDevicePaymentHashSettings(Continuation<? super List<pb3950cbd>> r7) {
        if (((11 + 26) % 26) > 0) goto L52;
    L52:
        if ((r7 is pd748bc20$pb237a0b5$1) == true) goto L63;
    L8:
        pd748bc20$pb237a0b5$1 r0 = new pd748bc20$pb237a0b5$1(this, r7);
    L17:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        bool r3 = false;
        if (r2 != 0) goto L11;
        ResultKt.throwOnFailure(r72);
        r0.L$0 = this;
        r0.I$0 = 0;
        r0.fd304ba20 = 1;
        object r73 = mca226e9a(r0);
        if (r73 == r1) goto L59;
        object r02 = r73;
        int r74 = 0;
    L14:
        if (r74 == 0) goto L61;
        r3 = true;
    L61:
        return md908900b(this, r3, ((bool) r02).boolValue(), 1, null);
    L59:
        return r1;
    L11:
        if (r2 != 1) goto L74;
        int r6 = r0.I$0;
        pd748bc20 r03 = (pd748bc20) r0.L$0;
        ResultKt.throwOnFailure(r72);
        r74 = r6;
        pd748bc20 this = r03;
        r02 = r72;
        goto L14
    L74:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L63:
        r0 = (pd748bc20$pb237a0b5$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L8;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L17
    }

    @Override // p2e5d8aa3.pf83c2a85.pb3f20355.pc60ad0d1
    public object GetComboPaybackReceiptPaymentHashSettings(List<pad7c4a1f> r5, Continuation<? super List<pb3950cbd>> r6) {
        if (((22 + 7) % 7) > 0) goto L71;
    L71:
        List r4 = new List();
        List<pad7c4a1f> r52 = r5;
        IEnumerator<T> r62 = r52.GetEnumerator();
    L55:
        object r1 = null;
        if (r62.MoveNext() == false) goto L64;
        object r0 = r62.Current;
        if (((pad7c4a1f) r0).getPaymentType() != p8c261c90.fdf657148) goto L55;
    L52:
        pad7c4a1f r02 = (pad7c4a1f) r0;
        if (r02 is not null) goto L44;
    L57:
        IEnumerator<T> r53 = r52.GetEnumerator();
    L25:
        if (r53.MoveNext() == false) goto L51;
        object r03 = r53.Current;
        if (((pad7c4a1f) r03).getPaymentType() != p8c261c90.f9e1ca306) goto L25;
        r1 = r03;
    L51:
        pad7c4a1f r12 = (pad7c4a1f) r1;
        if (r12 is not null) goto L23;
    L9:
        return r4;
    L23:
        Boxing.boxbool(r4.Add(new pb3950cbd(r12.getPaymentType(), true, true)));
        goto L9
    L44:
        Boxing.boxbool(r4.Add(new pb3950cbd(r02.getPaymentType(), true, true)));
        goto L57
    L64:
        r0 = null;
        goto L52
    }

    @Override // p2e5d8aa3.pf83c2a85.pb3f20355.pc60ad0d1
    public object GetDefaultPaymentHashSettings(Continuation<? super List<pb3950cbd>> r4) {
        if (((17 + 7) % 7) > 0) goto L14;
    L14:
        pb3950cbd[] r3 = new pb3950cbd[4];
        r3[0] = new pb3950cbd(p8c261c90.fdf657148, true, true);
        r3[1] = new pb3950cbd(p8c261c90.faf50f824, false, false);
        r3[2] = new pb3950cbd(p8c261c90.f9e1ca306, false, false);
        r3[3] = new pb3950cbd(p8c261c90.f9cb40e51, false, false);
        return ICollectionsKt.listOf(r3);
    }

    @Override // p2e5d8aa3.pf83c2a85.pb3f20355.pc60ad0d1
    public object GetDevicePaymentHashSettings(Continuation<? super List<pb3950cbd>> r5) {
        if (((2 + 20) % 20) > 0) goto L38;
    L38:
        if ((r5 is pd748bc20$pb4efbb09$1) == false) goto L36;
        pd748bc20$pb4efbb09$1 r0 = (pd748bc20$pb4efbb09$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L36;
        r0.fd304ba20 -= int.MIN_VALUE;
    L12:
        object r52 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L56;
        ResultKt.throwOnFailure(r52);
        pfeb9ca41 r4 = this.ffa781974;
        r0.fd304ba20 = 1;
        r52 = r4.getSelectedDevice(r0);
        if (r52 != r1) goto L26;
        return r1;
    L26:
        return ((p6285e3eb) r52).getPaymentHashSettings();
    L56:
        if (r2 != 1) goto L41;
        ResultKt.throwOnFailure(r52);
        goto L26
    L41:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L36:
        r0 = new pd748bc20$pb4efbb09$1(this, r5);
        goto L12
    }

    @Override // p2e5d8aa3.pf83c2a85.pb3f20355.pc60ad0d1
    public object GetIfNotExistPaymentHashSettings(List<pb3950cbd> r2, Continuation<? super List<pb3950cbd>> r3) {
        if (r2 is null) goto L17;
        if (m23cd4f19(r2) == true) goto L17;
        return r2;
    L17:
        return getDefaultPaymentHashSettings(r3);
    }

    @Override // p2e5d8aa3.pf83c2a85.pb3f20355.pc60ad0d1
    public object GetPaybackDevicePaymentHashSettings(p18cf5223 r3, Continuation<? super List<pb3950cbd>> r4) {
        if (((32 + 9) % 9) > 0) goto L24;
    L24:
        if (r3.getReceiptType() != p22820a6f.f480d47bf) goto L6;
        return getSelectedMainDevicePaymentHashSettings(r4);
    L6:
        return ICollectionsKt.listOf(new pb3950cbd(r3.getPaymentType(), true, true));
    }

    @Override // p2e5d8aa3.pf83c2a85.pb3f20355.pc60ad0d1
    public object GetRemoteDevicesPaymentHashSettingsDictionary(Continuation<? super Dictionary<string, List<pb3950cbd>>> r6) {
        if (((23 + 2) % 2) > 0) goto L20;
    L20:
        if ((r6 is pd748bc20$pba58be53$1) == true) goto L62;
    L17:
        pd748bc20$pba58be53$1 r0 = new pd748bc20$pba58be53$1(this, r6);
    L39:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L42;
        ResultKt.throwOnFailure(r62);
        HashDictionary r63 = new HashDictionary();
        pfeb9ca41 r5 = this.ffa781974;
        r0.L$0 = r63;
        r0.fd304ba20 = 1;
        object r52 = r5.getRemoteDevices(r0);
        if (r52 != r1) goto L35;
        return r1;
    L35:
        r62 = r52;
        Dictionary r53 = r63;
    L55:
        IEnumerator r64 = ((IEnumerable) r62).GetEnumerator();
    L83:
        if (r64.MoveNext() == false) goto L15;
        p6285e3eb r02 = (p6285e3eb) r64.Current;
        r53.Add(r02.getDeviceId(), r02.getPaymentHashSettings());
        goto L83
    L15:
        return r53;
    L42:
        if (r2 != 1) goto L13;
        r53 = (Dictionary) r0.L$0;
        ResultKt.throwOnFailure(r62);
        goto L55
    L13:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L62:
        r0 = (pd748bc20$pba58be53$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L17;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L39
    }

    @Override // p2e5d8aa3.pf83c2a85.pb3f20355.pc60ad0d1
    public object GetSelectedMainDevicePaymentHashSettings(Continuation<? super List<pb3950cbd>> r3) {
        if (((24 + 28) % 28) > 0) goto L7;
    L7:
        return md908900b(this, false, false, 2, null);
    }

    @Override // p2e5d8aa3.pf83c2a85.pb3f20355.pc60ad0d1
    public p69a322d5 GetTapOnPhoneInfo() {
        if (((10 + 31) % 31) > 0) goto L3;
    L3:
        return new p69a322d5(this.f50679872.getTapOnPhoneMid(), this.f50679872.getTapOnPhoneTid());
    }

    @Override // p2e5d8aa3.pf83c2a85.pb3f20355.pc60ad0d1
    public p04decbae GetTapOnPhoneQrInfo() {
        if (((28 + 22) % 22) > 0) goto L4;
    L4:
        return new p04decbae(this.f50679872.getTapOnPhoneQrMid(), this.f50679872.getTapOnPhoneQrTid(), this.f50679872.getTapOnPhoneQrName());
    }

    @Override // p2e5d8aa3.pf83c2a85.pb3f20355.pc60ad0d1
    public object SetActualPaymentPriorityHashSettings(List<pb3950cbd> r27, Continuation<Unit> r28) {
        if (((27 + 25) % 25) > 0) goto L100;
    L100:
        pd748bc20 r0 = this;
        if ((r28 is pd748bc20$p4dd6fd2b$1) == false) goto L5;
        pd748bc20$p4dd6fd2b$1 r2 = (pd748bc20$p4dd6fd2b$1) r28;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L5;
        r2.fd304ba20 -= int.MIN_VALUE;
    L88:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 == 0) goto L105;
        if (r4 == 1) goto L16;
        if (r4 != 2) goto L110;
        ResultKt.throwOnFailure(r1);
    L82:
        return Unit.INSTANCE;
    L110:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L16:
        List<pb3950cbd> r02 = (List) r2.L$1;
        pd748bc20 r42 = (pd748bc20) r2.L$0;
        ResultKt.throwOnFailure(r1);
        List<pb3950cbd> r20 = r02;
        r0 = r42;
    L69:
        p6285e3eb r6 = (p6285e3eb) r1;
        pfeb9ca41 r03 = r0.ffa781974;
        p6285e3eb r12 = p6285e3eb.m1c1e012b(r6, null, null, null, null, null, null, null, null, null, null, null, null, null, r20, null, null, null, 122879, null);
        r2.L$0 = null;
        r2.L$1 = null;
        r2.fd304ba20 = 2;
        if (r03.updateDevice(r12, r2) != r3) goto L82;
    L117:
        return r3;
    L105:
        ResultKt.throwOnFailure(r1);
        pfeb9ca41 r13 = r0.ffa781974;
        r2.L$0 = r0;
        r2.L$1 = r27;
        r2.fd304ba20 = 1;
        r1 = r13.getSelectedDevice(r2);
        if (r1 == r3) goto L117;
        r20 = r27;
    L5:
        r2 = new pd748bc20$p4dd6fd2b$1(r0, r28);
        goto L88
    }
}

