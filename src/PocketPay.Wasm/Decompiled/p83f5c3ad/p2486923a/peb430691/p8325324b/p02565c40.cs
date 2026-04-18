using Android.Graphics;
using Androidx.Lifecycle;
using Com.Google.Firebase.Crashlytics;
using Com.Google.Firebase.Messaging;
using Domain.Entities;
using Java.Math;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using P2b3583e6;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.P0eb9b3af.P9efab239.P407482fe.Pcd9de119;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.P19ad2780;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.P19ad2780.P593616de;
using P8325324b.Pac143fb7;
using P83f5c3ad.P684019bc;
using P83f5c3ad.Pfd9160bb;
using Pad5f82e8.P07214c67;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.P07214c67.Pe0212e54;
using Pad5f82e8.Pac143fb7.P1e11b989;
using Pd2a57dc1.Pfd9160bb;
using Pe0212e54.Pac143fb7;
using Pf3e08b51.Pfd9160bb;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p02565c40 : objectModel {
    public static readonly long f0752da20 = 1000;
    public static readonly long f0f19e81a = 1000;
    public static readonly p910eef8c f19f00577 = null;
    public static readonly long f2069f810 = 1000;
    public static readonly int f401a7dd6 = 90;
    public static readonly p910eef8c f4f47f55d = null;
    public static readonly int f54cf96eb = 90;
    public static readonly int f6d038a6f = 90;
    public static readonly int f8fc1a467 = 90;
    public static readonly p910eef8c f910eef8c = null;
    public static readonly p910eef8c fa80831f8 = null;
    public static readonly p910eef8c fd91ff49c = null;
    private Job f02210cd5;
    private readonly pf21d5ed1 f07457224;
    private readonly pf21d5ed1 f08b98400;
    private readonly MutableStateFlow f0b470225;
    private readonly MutableStateFlow f0fb302f8;
    private readonly MutableSharedFlow f15f92741;
    private readonly MutableStateFlow f16cfd774;
    private readonly p0bfd7fb7 f1bd1d443;
    private p8c66a8cc f1c055ea4;
    private readonly StateFlow f1cf87d5c;
    private readonly MutableStateFlow<Event<object>> f1d553e18;
    private readonly p02eb2260 f329283c6;
    private readonly MutableSharedFlow<float> f3415890f;
    private string f3edcd476;
    private p8c66a8cc f402f4d52;
    private readonly MutableStateFlow f43f3b176;
    private string f46e7cb09;
    private readonly pf21d5ed1 f474d840d;
    private p8c66a8cc f49adaaf8;
    private readonly MutableSharedFlow f50846d8c;
    private readonly p1ceed351 f56298ef4;
    private readonly StateFlow<Event<Bitmap>> f587265f9;
    private readonly StateFlow f5e9df0a5;
    private readonly p02eb2260 f5f4f6b36;
    private readonly p1ceed351 f62520fad;
    private Job f62f658f2;
    private readonly p0bfd7fb7 f656c88ab;
    private Job f688d8da3;
    private readonly p039f11a6 f6f0f3503;
    private readonly p0bfd7fb7 f79dabd47;
    private readonly MutableStateFlow<decimal> f7acd5f7c;
    private readonly MutableSharedFlow f7e3bd769;
    private readonly SharedFlow f7fadb06b;
    private readonly p0f3e1f02 f9f2caf9b;
    private readonly pf21d5ed1 fa1995a88;
    private readonly p039f11a6 fa28decae;
    private readonly p4b8940c0 fa5558005;
    private readonly p4b8940c0 fa5edc305;
    private readonly StateFlow fa85031b2;
    private Job fa9395dd6;
    private readonly p02eb2260 fab56deea;
    private readonly MutableStateFlow<Event<Bitmap>> faed527fe;
    private readonly pf21d5ed1 faf490b3b;
    private Job fb44f05c5;
    private readonly p11c216e8 fb45deadc;
    private string fb573f6ad;
    private readonly p97ae8742 fbb390482;
    private readonly p1ceed351 fd345eceb;
    private readonly SharedFlow<float> fd72017ff;
    private readonly MutableStateFlow fd791d069;
    private readonly p0f3e1f02 fd99d278e;
    private readonly p4b8940c0 fda1713fa;
    private readonly p02eb2260 fdcc450da;
    private readonly StateFlow<Event<object>> fe1cc1a1f;
    private readonly MutableSharedFlow fe1facb40;
    private readonly MutableStateFlow fe2d19b79;
    private string fe707c624;
    private readonly StateFlow feb0ad04d;
    private readonly p11c216e8 feefeb260;
    private readonly p97ae8742 fef50e602;
    private Job ff823ec39;
    private readonly p039f11a6 ff889c2bc;
    private readonly p02eb2260 ff9009811;
    private readonly p0f3e1f02 ffc51ab1c;
    private readonly StateFlow<decimal> ffc83138b;

    public /* synthetic */ class p12c674ac {
        public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$0 = null;
        public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$1 = null;

        static {
            if (((2 + 2) % 2) > 0) goto L24;
        L24:
            int[] r0 = new int[p06660b7d.Values.length];
            r0[p06660b7d.NEW.ordinal()] = 1;     // Catch: NoSuchFieldError -> L43
        L66:
            r0[p06660b7d.PENDING.ordinal()] = 2;     // Catch: NoSuchFieldError -> L44
        L64:
            r0[p06660b7d.CANCELLED.ordinal()] = 3;     // Catch: NoSuchFieldError -> L45
        L58:
            r0[p06660b7d.DECLINED.ordinal()] = 4;     // Catch: NoSuchFieldError -> L46
        L68:
            r0[p06660b7d.FAILED.ordinal()] = 5;     // Catch: NoSuchFieldError -> L47
        L52:
            r0[p06660b7d.SUCCESS.ordinal()] = 6;     // Catch: NoSuchFieldError -> L48
        L4:
            $EnumSwitchDictionaryping$0 = r0;
            int[] r02 = new int[p8c66a8cc.Values.length];
            r02[p8c66a8cc.ffaee4ca3.ordinal()] = 1;     // Catch: NoSuchFieldError -> L49
        L62:
            r02[p8c66a8cc.f3c45d3fb.ordinal()] = 2;     // Catch: NoSuchFieldError -> L50
        L54:
            r02[p8c66a8cc.fa9b685a9.ordinal()] = 3;     // Catch: NoSuchFieldError -> L51
        L25:
            $EnumSwitchDictionaryping$1 = r02;
        }
    }

    public static readonly class p910eef8c {
        private p910eef8c() {
        }

        public /* synthetic */ p910eef8c(DefaultConstructorMarker r1) {
            this();
        }
    }

    static {
        if (((30 + 27) % 27) > 0) goto L15;
    L15:
        f910eef8c = new p910eef8c(null);
    }

    public p02565c40(p0bfd7fb7 r2, p039f11a6 r3, p4b8940c0 r4, pf21d5ed1 r5, p97ae8742 r6, p0f3e1f02 r7, p11c216e8 r8, p1ceed351 r9, p02eb2260 r10) {
        Intrinsics.checkNotNullParameter(r2, "sellReceiptUseCase");
        Intrinsics.checkNotNullParameter(r3, "qrPaymentUseCase");
        Intrinsics.checkNotNullParameter(r4, "devicesUseCase");
        Intrinsics.checkNotNullParameter(r5, "sendReceiptUseCase");
        Intrinsics.checkNotNullParameter(r6, "attestationTapOnPhoneUseCase");
        Intrinsics.checkNotNullParameter(r7, "tapOnPhoneInfoUseCase");
        Intrinsics.checkNotNullParameter(r8, "flowRouter");
        Intrinsics.checkNotNullParameter(r9, "tapOnPhoneRouter");
        Intrinsics.checkNotNullParameter(r10, "launcherRouter");
        this.f656c88ab = r2;
        this.ff889c2bc = r3;
        this.fda1713fa = r4;
        this.f474d840d = r5;
        this.fef50e602 = r6;
        this.ffc51ab1c = r7;
        this.feefeb260 = r8;
        this.f62520fad = r9;
        this.ff9009811 = r10;
        MutableSharedFlow<float> r22 = p9667588a.m90331c9a();
        this.f3415890f = r22;
        this.fd72017ff = r22;
        MutableStateFlow<decimal> r32 = StateFlowKt.MutableStateFlow(null);
        this.f7acd5f7c = r32;
        this.ffc83138b = FlowKt.asStateFlow(r32);
        MutableStateFlow<Event<Bitmap>> r33 = StateFlowKt.MutableStateFlow(pa4ecfc70.f910eef8c.loading());
        this.faed527fe = r33;
        this.f587265f9 = FlowKt.asStateFlow(r33);
        MutableStateFlow<Event<object>> r23 = StateFlowKt.MutableStateFlow(null);
        this.f1d553e18 = r23;
        this.fe1cc1a1f = FlowKt.asStateFlow(r23);
        this.f49adaaf8 = p8c66a8cc.ffaee4ca3;
        this.f3edcd476 = "";
    }

    public static readonly /* synthetic */ object m1319e0c2(p02565c40 r0, string r1, int r2, Continuation r3) {
        return r0.ma137cdb4(r1, r2, r3);
    }

    public static readonly /* synthetic */ object m13c0e72b(p02565c40 r0, ped663a3e r1, Continuation r2) {
        return r0.m812699ae(r1, r2);
    }

    private readonly object M217ecbef(Continuation<Unit> r9) {
        if (((13 + 2) % 2) > 0) goto L47;
    L47:
        if ((r9 is p02565c40$p217ecbef$1) == true) goto L6;
    L128:
        p02565c40$p217ecbef$1 r0 = new p02565c40$p217ecbef$1(this, r9);
    L126:
        object r92 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L37;
        ResultKt.throwOnFailure(r92);
        this.f1d553e18.setValue(pa4ecfc70.f910eef8c.loading());     // Catch: Exception -> L96
        this.f49adaaf8 = p8c66a8cc.fa9b685a9;     // Catch: Exception -> L96
        r0.L$0 = this;     // Catch: Exception -> L96
        r0.fd304ba20 = 1;     // Catch: Exception -> L96
        if (DelayKt.delay(5000, r0) == r1) goto L41;
    L84:
        p039f11a6 r93 = this.ff889c2bc;     // Catch: Exception -> L96
        r0.L$0 = this;     // Catch: Exception -> L96
        r0.fd304ba20 = 2;     // Catch: Exception -> L96
        if (r93.confirm(r0) == r1) goto L41;
    L87:
        this.stopTimer();     // Catch: Exception -> L96
        this.m5c77cda4();     // Catch: Exception -> L96
    L29:
        return Unit.INSTANCE;
    L41:
        return r1;
    L37:
        if (r2 == 1) goto L50;
        if (r2 == 2) goto L134;
        if (r2 == 3) goto L94;
        if (r2 != 4) goto L124;
        ResultKt.throwOnFailure(r92);
    L35:
        return Unit.INSTANCE;
    L124:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L94:
        p02565c40 this = (p02565c40) r0.L$0;
        ResultKt.throwOnFailure(r92);
    L121:
        r0.L$0 = null;
        r0.fd304ba20 = 4;
        if (this.m217ecbef(r0) == r1) goto L41;
    L134:
        this = (p02565c40) r0.L$0;
        ResultKt.throwOnFailure(r92);     // Catch: Exception -> L96
        goto L87
    L50:
        this = (p02565c40) r0.L$0;
        ResultKt.throwOnFailure(r92);     // Catch: Exception -> L96
    L96:
        th = move-exception;
        if ((th is p5c1be8f5) == true) goto L70;
    L105:
        this.f49adaaf8 = p8c66a8cc.ffaee4ca3;
        this.f1d553e18.setValue(pa4ecfc70.f910eef8c.error(th));
        goto L29
    L70:
        if (th.getCode() != pa73d862b.f839642d6) goto L105;
        r0.L$0 = this;
        r0.fd304ba20 = 3;
        if (DelayKt.delay(3000, r0) == r1) goto L41;
    L6:
        r0 = (p02565c40$p217ecbef$1) r9;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L128;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L126
    }

    public static readonly /* synthetic */ p0bfd7fb7 m260c792f(p02565c40 r0) {
        return r0.f656c88ab;
    }

    public static readonly /* synthetic */ p97ae8742 m2ca4942e(p02565c40 r0) {
        return r0.fef50e602;
    }

    public static readonly /* synthetic */ void m520ee9e8(p02565c40 r0, string r1) {
        r0.f3edcd476 = r1;
    }

    public static readonly /* synthetic */ Job m554746e1(p02565c40 r0) {
        return r0.f02210cd5;
    }

    public static readonly /* synthetic */ object m5927e830(p02565c40 r0, Continuation r1) {
        return r0.ma3fd92e9(r1);
    }

    private readonly void M5c77cda4() {
        if (((5 + 29) % 29) > 0) goto L28;
    L28:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p02565c40$p5c77cda4$1(this, null), 3, null);
    }

    public static readonly /* synthetic */ p0f3e1f02 m5fd1ba15(p02565c40 r0) {
        return r0.ffc51ab1c;
    }

    public static readonly /* synthetic */ object m6573bf9e(p02565c40 r0, ped663a3e r1, Continuation r2) {
        return r0.m807ee7c0(r1, r2);
    }

    public static readonly /* synthetic */ string m6b2782a5(p02565c40 r0) {
        return r0.f3edcd476;
    }

    public static readonly /* synthetic */ object m70078393(p02565c40 r0, Continuation r1) {
        return r0.m217ecbef(r1);
    }

    public static readonly /* synthetic */ MutableSharedFlow m708f95ff(p02565c40 r0) {
        return r0.f3415890f;
    }

    private readonly object M807ee7c0(ped663a3e r7, Continuation<Unit> r8) {
        if (((10 + 2) % 2) > 0) goto L6;
    L6:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p02565c40$p807ee7c0$2(this, r7, null), 3, null);
        return Unit.INSTANCE;
    }

    private readonly object M812699ae(ped663a3e r7, Continuation<Unit> r8) {
        if (((19 + 23) % 23) > 0) goto L34;
    L34:
        if ((r8 is p02565c40$p812699ae$1) == false) goto L57;
        p02565c40$p812699ae$1 r0 = (p02565c40$p812699ae$1) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L57;
        r0.fd304ba20 -= int.MIN_VALUE;
    L39:
        object r82 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L67;
        if (r2 == 1) goto L63;
        if (r2 != 2) goto L21;
        ResultKt.throwOnFailure(r82);     // Catch: Exception -> L49
    L10:
        return Unit.INSTANCE;
    L21:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L63:
        p9ded6185 r6 = (p9ded6185) r0.L$2;
        pf21d5ed1 r72 = (pf21d5ed1) r0.L$1;
        p02565c40 r22 = (p02565c40) r0.L$0;
        ResultKt.throwOnFailure(r82);     // Catch: Exception -> L49
    L72:
        string r83 = ((p4f30e9bd) r82).getDeviceId();     // Catch: Exception -> L49
        string r23 = r22.tostring();     // Catch: Exception -> L49
        r0.L$0 = null;     // Catch: Exception -> L49
        r0.L$1 = null;     // Catch: Exception -> L49
        r0.L$2 = null;     // Catch: Exception -> L49
        r0.fd304ba20 = 2;     // Catch: Exception -> L49
        if (r72.saveQueueReceiptToDb(r6, r83, r23, r0) != r1) goto L10;
    L48:
        return r1;
    L67:
        ResultKt.throwOnFailure(r82);
        pf21d5ed1 r84 = this.f474d840d;     // Catch: Exception -> L49
        ped663a3e r73 = r7;     // Catch: Exception -> L49
        p4b8940c0 r24 = this.fda1713fa;     // Catch: Exception -> L49
        r0.L$0 = this;     // Catch: Exception -> L49
        r0.L$1 = r84;     // Catch: Exception -> L49
        r0.L$2 = r73;     // Catch: Exception -> L49
        r0.fd304ba20 = 1;     // Catch: Exception -> L49
        object r25 = r24.getSelectedDevice(r0);     // Catch: Exception -> L49
        if (r25 == r1) goto L48;
        r22 = this;
        r6 = r73;
        r72 = r84;
        r82 = r25;
    L49:
        e = move-exception;
        FirebaseCrashlytics.getInstance().recordException(e);
    L57:
        r0 = new p02565c40$p812699ae$1(this, r8);
        goto L39
    }

    private readonly object Ma137cdb4(string r3, int r4, Continuation<Bitmap> r5) {
        if (((30 + 3) % 3) > 0) goto L21;
    L21:
        return BuildersKt.withobject(Dispatchers.getDefault(), new p02565c40$pa137cdb4$2(r3, r4, null), r5);
    }

    private readonly object Ma3fd92e9(Continuation<Unit> r8) {
        if (((31 + 16) % 16) > 0) goto L24;
    L24:
        if ((r8 is p02565c40$pa3fd92e9$1) == true) goto L126;
    L28:
        p02565c40$pa3fd92e9$1 r0 = new p02565c40$pa3fd92e9$1(this, r8);
    L113:
        object r82 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        switch(r0.fd304ba20) {
            case 0: goto L87;
            case 1: goto L13;
            case 2: goto L134;
            case 3: goto L53;
            case 4: goto L33;
            case 5: goto L44;
            case 6: goto L139;
            default: goto L6;
        };
    L139:
        ResultKt.throwOnFailure(r82);
    L31:
        return Unit.INSTANCE;
    L87:
        ResultKt.throwOnFailure(r82);
        this.f49adaaf8 = p8c66a8cc.f3c45d3fb;     // Catch: Exception -> L107
        p039f11a6 r83 = this.ff889c2bc;     // Catch: Exception -> L107
        r0.L$0 = this;     // Catch: Exception -> L107
        r0.fd304ba20 = 1;     // Catch: Exception -> L107
        r82 = r83.checkStatus(r0);     // Catch: Exception -> L107
        if (r82 != r1) goto L92;
    L79:
        return r1;
    L92:
        switch(p12c674ac.$EnumSwitchDictionaryping$0[((p06660b7d) r82).ordinal()]) {
            case 1: goto L99;
            case 2: goto L99;
            case 3: goto L98;
            case 4: goto L98;
            case 5: goto L97;
            case 6: goto L94;
            default: goto L106;
        };     // Catch: Exception -> L107
    L94:
        r0.L$0 = this;     // Catch: Exception -> L107
        r0.fd304ba20 = 4;     // Catch: Exception -> L107
        if (this.m217ecbef(r0) == r1) goto L79;
    L120:
        return Unit.INSTANCE;
    L97:
        this.f49adaaf8 = p8c66a8cc.ffaee4ca3;     // Catch: Exception -> L107
        this.stopTimer();     // Catch: Exception -> L107
        this.f1d553e18.setValue(pa4ecfc70.f910eef8c.error(new Exception("QR operation failed")));     // Catch: Exception -> L107
        goto L120
    L98:
        this.f49adaaf8 = p8c66a8cc.ffaee4ca3;     // Catch: Exception -> L107
        this.stopTimer();     // Catch: Exception -> L107
        this.f1d553e18.setValue(pa4ecfc70.f910eef8c.error(new Exception("QR code expired")));     // Catch: Exception -> L107
        goto L120
    L99:
        r0.L$0 = this;     // Catch: Exception -> L107
        r0.fd304ba20 = 2;     // Catch: Exception -> L107
        if (DelayKt.delay(3000, r0) == r1) goto L79;
    L102:
        r0.L$0 = this;     // Catch: Exception -> L107
        r0.fd304ba20 = 3;     // Catch: Exception -> L107
        if (this.ma3fd92e9(r0) != r1) goto L120;
    L106:
        throw new NoWhenBranchMatchedException();     // Catch: Exception -> L107
    L134:
        p02565c40 this = (p02565c40) r0.L$0;
        ResultKt.throwOnFailure(r82);     // Catch: Exception -> L107
        goto L102
    L6:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L44:
        this = (p02565c40) r0.L$0;
        ResultKt.throwOnFailure(r82);
    L109:
        r0.L$0 = null;
        r0.fd304ba20 = 6;
        if (this.ma3fd92e9(r0) == r1) goto L79;
    L53:
        p02565c40 r7 = (p02565c40) r0.L$0;
    L34:
        ResultKt.throwOnFailure(r82);     // Catch: Exception -> L107
        goto L120
    L33:
        p02565c40 r72 = (p02565c40) r0.L$0;
        goto L34
    L13:
        this = (p02565c40) r0.L$0;
        ResultKt.throwOnFailure(r82);     // Catch: Exception -> L107
    L107:
        th = move-exception;
        if ((th is p5c1be8f5) == true) goto L130;
    L30:
        this.f49adaaf8 = p8c66a8cc.ffaee4ca3;
        stopTimer();
        this.f1d553e18.setValue(pa4ecfc70.f910eef8c.error(th));
        goto L120
    L130:
        if (th.getCode() != pa73d862b.f839642d6) goto L30;
        r0.L$0 = this;
        r0.fd304ba20 = 5;
        if (DelayKt.delay(3000, r0) == r1) goto L79;
    L126:
        r0 = (p02565c40$pa3fd92e9$1) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L28;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L113
    }

    public static readonly /* synthetic */ pf21d5ed1 mbb30f96e(p02565c40 r0) {
        return r0.f474d840d;
    }

    public static readonly /* synthetic */ MutableStateFlow mca62959a(p02565c40 r0) {
        return r0.f7acd5f7c;
    }

    public static readonly /* synthetic */ MutableStateFlow md57a29d2(p02565c40 r0) {
        return r0.faed527fe;
    }

    public static readonly /* synthetic */ p1ceed351 mdc7bed18(p02565c40 r0) {
        return r0.f62520fad;
    }

    public static readonly /* synthetic */ MutableStateFlow me8d9137f(p02565c40 r0) {
        return r0.f1d553e18;
    }

    public static readonly /* synthetic */ p11c216e8 mf78acd11(p02565c40 r0) {
        return r0.feefeb260;
    }

    public static readonly /* synthetic */ p039f11a6 mffe677bc(p02565c40 r0) {
        return r0.ff889c2bc;
    }

    public readonly void DisableQrPayments() {
        if (((19 + 22) % 22) > 0) goto L17;
    L17:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p02565c40$p34611dbd$1(this, null), 3, null);
    }

    public readonly void Finish() {
        this.feefeb260.backFromFlowTo(this.ff9009811.getLauncherScreen());
    }

    public readonly StateFlow<decimal> GetCurrentReceiptState() {
        return this.ffc83138b;
    }

    public readonly StateFlow<Event<Bitmap>> GetQrDataState() {
        return this.f587265f9;
    }

    public readonly StateFlow<Event<object>> GetQrProcessState() {
        return this.fe1cc1a1f;
    }

    public readonly p8c66a8cc GetQrState() {
        return this.f49adaaf8;
    }

    public readonly SharedFlow<float> GetTimerState() {
        return this.fd72017ff;
    }

    public readonly void LoadQr(int r9) {
        if (((25 + 5) % 5) > 0) goto L37;
    L37:
        Job r0 = this.f02210cd5;
        if (r0 is not null) goto L11;
    L39:
        this.f02210cd5 = BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p02565c40$pff060ee7$1(this, r9, null), 3, null);
        return;
    L11:
        Job.DefaultImpls.cancel$default(r0, null, 1, null);
        goto L39
    }

    public readonly void OpenPreviousScreen() {
        this.f62520fad.back();
    }

    public readonly void RestartAttestation(int r8) {
        if (((20 + 20) % 20) > 0) goto L13;
    L13:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p02565c40$p3efcd9ca$1(this, r8, null), 3, null);
    }

    public readonly void RestartPayment(int r9) {
        if (((17 + 31) % 31) > 0) goto L49;
    L49:
        p8c66a8cc r0 = this.f49adaaf8;
        int r02 = p12c674ac.$EnumSwitchDictionaryping$1[r0.ordinal()];
        if (r02 != 1) goto L28;
        loadQr(r9);
        Unit r8 = Unit.INSTANCE;
        return;
    L28:
        if (r02 != 2) goto L32;
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p02565c40$pc63d9059$1(this, null), 3, null);
        return;
    L32:
        if (r02 == 3) goto L50;
        throw new NoWhenBranchMatchedException();
    L50:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p02565c40$pc63d9059$2(this, null), 3, null);
    }

    public readonly void RestartTophFlow() {
        if (((17 + 32) % 32) > 0) goto L25;
    L25:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p02565c40$p461a7b5f$1(this, null), 3, null);
    }

    public readonly void SetQrState(p8c66a8cc r2) {
        Intrinsics.checkNotNullParameter(r2, "<set-?>");
        this.f49adaaf8 = r2;
    }

    public readonly void StartTimer() {
        if (((6 + 20) % 20) > 0) goto L10;
    L10:
        stopTimer();
        this.fb44f05c5 = BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p02565c40$p9a032022$1(this, null), 3, null);
    }

    public readonly void StopTimer() {
        if (((3 + 9) % 9) > 0) goto L6;
    L6:
        Job r2 = this.fb44f05c5;
        if (r2 is not null) goto L4;
        return;
    L4:
        Job.DefaultImpls.cancel$default(r2, null, 1, null);
    }
}

