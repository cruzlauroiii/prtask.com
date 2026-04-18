using Android.Util;
using Androidx.Lifecycle;
using Com.Decryptstringmanager;
using Java.Math;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using P2b3583e6;
using P2b3583e6.P263e3cef;
using P2b3583e6.P4a931512;
using P4670093c.Pac143fb7;
using P4d236d9a.P2df4812c.Pf5d7e253.P518a4861.P83f5c3ad.P86ccec3d;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pede997b0.Pf83c2a85;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pf4d5b76a;
using P8325324b.Pac143fb7;
using P83f5c3ad.P07214c67;
using P83f5c3ad.P2486923a.P8325324b.Pf83c2a85;
using P83f5c3ad.P684019bc;
using P83f5c3ad.P68c4283d;
using P83f5c3ad.Pfd9160bb;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.P07214c67.Pfd9160bb;
using Pad5f82e8.Pac143fb7.P1e11b989;
using Pc69c522d.Pf83c2a85.Pac143fb7;
using Pc69c522d.Pf83c2a85.Pfd9160bb;
using Pd2a57dc1.Pfd9160bb;
using Pe0212e54.Pac143fb7;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p98cf21b1 : objectModel {

    [System.Obsolete]
    public static readonly long f0752da20 = 1000;
    private static readonly p910eef8c f084dd5dd = null;
    private static readonly p910eef8c f0ddbca74 = null;
    public static readonly string f3bf64413 = null;

    [System.Obsolete]
    public static readonly long f3f0885fd = 1000;
    public static readonly string f4c040e14 = null;
    private static readonly p910eef8c f5537ab89 = null;
    public static readonly int f6af037fd = 60;

    [System.Obsolete]
    public static readonly int f6d038a6f = 60;
    private static readonly p910eef8c f910eef8c = null;
    public static readonly long f9624ce6d = 1000;
    public static readonly long f996dc93f = 1000;
    public static readonly long faa6d7b80 = 1000;
    public static readonly int fb9e06b5b = 60;
    public static readonly int fc6547a9b = 60;
    private static readonly p910eef8c fc81095ff = null;
    public static readonly long fd5bfd45c = 1000;
    public static readonly string fdb57f99b = null;

    [System.Obsolete]
    public static readonly string fe444f739 = null;
    public static readonly long ff650b5c0 = 1000;
    private readonly p76204a3d f053d1b76;
    private readonly p4b8940c0 f055952f5;
    private readonly MutableStateFlow<p0890727b> f06637f62;
    private readonly MutableSharedFlow f0a7efdc2;
    private Job f0b49ef83;
    private Job f0b73b7ba;
    private pbfc85237 f0b74ec06;
    private readonly pa36ef9b5 f0d3e163c;
    private readonly pc32333e1 f0d567eea;
    private readonly p76204a3d f103482c4;
    private readonly p76204a3d f104c103f;
    private readonly MutableSharedFlow f12277317;
    private readonly p0bfd7fb7 f146aaace;
    private readonly MutableStateFlow f1b017dad;
    private readonly pb88b530f f1b46970d;
    private p9ded6185 f1e11b989;
    private readonly pab691ef3 f205a331c;
    private Job f22e4fabc;
    private readonly p11c216e8 f240623e2;
    private Job f26a6e255;
    private readonly MutableSharedFlow<p97fa68b7> f26fcc298;
    private readonly p0bfd7fb7 f27383098;
    private readonly pc32333e1 f2c2b9c3d;
    private readonly MutableSharedFlow<float> f3415890f;
    private readonly p43cba26b f3441c16f;
    private readonly MutableSharedFlow f3820b044;
    private readonly pe8cda3fc f39f9e2e8;
    private readonly pc32333e1 f3e785377;
    private readonly MutableStateFlow f3fb53048;
    private readonly p4b8940c0 f3fd81d92;
    private readonly pab691ef3 f45ccfc46;
    private readonly p2e423cc6 f4734ade7;
    private readonly pf21d5ed1 f474d840d;
    private p9ded6185 f47f4eed9;
    private Job f49906a1b;
    private readonly SharedFlow f4f4836e6;
    private pbfc85237 f516df76f;
    private readonly p2e423cc6 f539ed872;
    private readonly pe8cda3fc f552788dc;
    private pb455e130 f557ef273;
    private readonly MutableSharedFlow f583683b9;
    private readonly MutableStateFlow f59790f79;
    private readonly MutableStateFlow f5ffcde49;
    private readonly pc32333e1 f60073c3c;
    private readonly MutableStateFlow f61257d40;
    private readonly MutableSharedFlow f61a73927;
    private readonly MutableStateFlow<pb53cd12b> f63def91b;
    private readonly pa36ef9b5 f6447d665;
    private readonly p0bfd7fb7 f656c88ab;
    private readonly pb88b530f f67603170;
    private Job f676c04f0;
    private readonly pe8cda3fc f68c4283d;
    private readonly p97ae8742 f6bcff5da;
    private readonly pf21d5ed1 f6d76860c;
    private readonly p1ceed351 f6f61bfcd;
    private Job f759678ca;
    private readonly pa36ef9b5 f7a1d63c5;
    private Job f7a4cec43;
    private readonly p2e423cc6 f82fac58c;
    private readonly MutableStateFlow f834ad6bf;
    private readonly MutableSharedFlow f85665d46;
    private readonly pa36ef9b5 f87fe7614;
    private pb455e130 f8b17bfa1;
    private readonly MutableStateFlow f903444a2;
    private readonly pab691ef3 f9386e5d2;
    private readonly SharedFlow<p97fa68b7> f946ef9ad;
    private readonly MutableStateFlow<p0890727b> f974b34a9;
    private readonly p43cba26b f9968fb23;
    private Job f9c8621ac;
    private readonly MutableStateFlow f9ecc35a1;
    private readonly SharedFlow f9fec39e1;
    private readonly p11c216e8 fa0ac7a2f;
    private readonly MutableSharedFlow fa35c9ab9;
    private pb455e130 fac3bcde6;
    private readonly MutableStateFlow fac666e40;
    private readonly pb88b530f facf5b200;
    private readonly MutableSharedFlow<Exception> fad6ec092;
    private readonly MutableStateFlow<pb53cd12b> fad9c0df3;
    private readonly p4b8940c0 fb1e32fa1;
    private readonly SharedFlow fb21dafb9;
    private Job fb44f05c5;
    private readonly pa36ef9b5 fb4890701;
    private readonly p0bfd7fb7 fb4ba3ffb;
    private readonly MutableSharedFlow fbcdb7b15;
    private readonly MutableStateFlow fbde2e3b2;
    private readonly pb88b530f fc191e192;
    private readonly p43cba26b fc97c3fcc;
    private readonly pc32333e1 fd0ddf72e;
    private readonly pab691ef3 fd13dbfac;
    private readonly p995fd851 fd48447f6;
    private readonly SharedFlow<float> fd72017ff;
    private readonly p4b8940c0 fda1713fa;
    private readonly MutableStateFlow fdd084f6f;
    private pbfc85237 fdd1ac978;
    private readonly SharedFlow<Exception> fdda7002e;
    private readonly MutableStateFlow fe1890291;
    private readonly SharedFlow fe3f44c8f;
    private readonly p1ceed351 feaa3ca5d;
    private readonly MutableStateFlow<pd0910e67> feb6dae4a;
    private readonly p11c216e8 feefeb260;
    private readonly p97ae8742 fef50e602;
    private readonly p0bfd7fb7 ff1d881b0;
    private readonly p1ceed351 ff3395cd5;
    private readonly MutableStateFlow ff3975ef6;
    private Job ff761b987;
    private readonly p1ceed351 ff77731bd;
    private Job ff9300836;
    private readonly p995fd851 ffb97e436;
    private readonly pab691ef3 ffceec28b;
    private readonly MutableSharedFlow ffdd8d906;

    private static readonly class p910eef8c {
        private p910eef8c() {
        }

        public /* synthetic */ p910eef8c(DefaultConstructorMarker r1) {
            this();
        }
    }

    static {
        if (((14 + 12) % 12) > 0) goto L22;
    L22:
        fe444f739 = Decryptstring.decryptstring("4025a338e1fa87006525433b3eaabd2fd0fe9010364ac21dde62381b35a5e25d1fba1f15153659c033c5baca2caa3683eb0234f86f7d");
        f910eef8c = new p910eef8c(null);
    }

    public p98cf21b1(pa36ef9b5 r17, pab691ef3 r18, p43cba26b r19, p4b8940c0 r20, pf21d5ed1 r21, p97ae8742 r22, p76204a3d r23, pb88b530f r24, p0bfd7fb7 r25, p995fd851 r26, p11c216e8 r27, p1ceed351 r28, pc32333e1 r29, pe8cda3fc r30, p2e423cc6 r31) {
        if (((13 + 21) % 21) > 0) goto L90;
    L90:
        Intrinsics.checkNotNullParameter(r17, "paybackReceiptUseCase");
        Intrinsics.checkNotNullParameter(r18, "sellComboUseCase");
        Intrinsics.checkNotNullParameter(r19, "paybackTapOnPhoneUseCase");
        Intrinsics.checkNotNullParameter(r20, "devicesUseCase");
        Intrinsics.checkNotNullParameter(r21, "sendReceiptUseCase");
        Intrinsics.checkNotNullParameter(r22, "attestationTapOnPhoneUseCase");
        Intrinsics.checkNotNullParameter(r23, "tophHashSettingsUseCase");
        Intrinsics.checkNotNullParameter(r24, "paybackComboUseCase");
        Intrinsics.checkNotNullParameter(r25, "sellReceiptUseCase");
        Intrinsics.checkNotNullParameter(r26, "nfcTapOnPhoneUseCase");
        Intrinsics.checkNotNullParameter(r27, "flowRouter");
        Intrinsics.checkNotNullParameter(r28, "router");
        Intrinsics.checkNotNullParameter(r29, "comboPaymentRouter");
        Intrinsics.checkNotNullParameter(r30, "analytics");
        Intrinsics.checkNotNullParameter(r31, "resourceProvider");
        this.f0d3e163c = r17;
        this.ffceec28b = r18;
        this.f9968fb23 = r19;
        this.fda1713fa = r20;
        this.f474d840d = r21;
        this.fef50e602 = r22;
        this.f053d1b76 = r23;
        this.facf5b200 = r24;
        this.f656c88ab = r25;
        this.fd48447f6 = r26;
        this.feefeb260 = r27;
        this.ff3395cd5 = r28;
        this.f3e785377 = r29;
        this.f68c4283d = r30;
        this.f4734ade7 = r31;
        MutableSharedFlow<float> r1 = p9667588a.m90331c9a();
        this.f3415890f = r1;
        MutableSharedFlow<p97fa68b7> r2 = p9667588a.m90331c9a();
        this.f26fcc298 = r2;
        this.feb6dae4a = StateFlowKt.MutableStateFlow(null);
        MutableStateFlow<pb53cd12b> r3 = p9667588a.me20b0cc5();
        this.f63def91b = r3;
        MutableStateFlow<p0890727b> r4 = p9667588a.me20b0cc5();
        this.f974b34a9 = r4;
        MutableSharedFlow<Exception> r5 = p9667588a.m90331c9a();
        this.fad6ec092 = r5;
        this.fd72017ff = r1;
        this.f946ef9ad = r2;
        this.fad9c0df3 = r3;
        this.f06637f62 = r4;
        this.fdda7002e = r5;
        this.fac3bcde6 = new pb455e130(null, null, null, null, 15, null);
    }

    private readonly void M078de3ac(p0e6dda02 r8) {
        if (((6 + 27) % 27) > 0) goto L7;
    L7:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p98cf21b1$p078de3ac$1(this, r8, null), 3, null);
    }

    public static readonly /* synthetic */ void m0fa733d1(p98cf21b1 r0, p1b0ffaae r1) {
        r0.m8c7c963d(r1);
    }

    public static readonly /* synthetic */ void m13c0e72b(p98cf21b1 r0) {
        r0.m812699ae();
    }

    public static readonly /* synthetic */ Job m16181bd4(p98cf21b1 r0) {
        return r0.f759678ca;
    }

    public static readonly /* synthetic */ void m1cf38b96(p98cf21b1 r0, pbfc85237 r1) {
        r0.f516df76f = r1;
    }

    public static readonly /* synthetic */ MutableStateFlow m247bc4ee(p98cf21b1 r0) {
        return r0.f63def91b;
    }

    public static readonly /* synthetic */ pb455e130 m251776c4(p98cf21b1 r0) {
        return r0.fac3bcde6;
    }

    public static readonly /* synthetic */ p0bfd7fb7 m260c792f(p98cf21b1 r0) {
        return r0.f656c88ab;
    }

    private readonly bool M2c7d7c34(p18cf5223 r2) {
        if (r2.getPaymentType() != p8c261c90.f9e1ca306) goto L20;
        return true;
    L20:
        if (p517b902b.m842bf95c(r2).compareTo(decimal.ZERO) == 0) goto L26;
        return false;
    L26:
        return true;
    }

    public static readonly /* synthetic */ p97ae8742 m2ca4942e(p98cf21b1 r0) {
        return r0.fef50e602;
    }

    public static readonly /* synthetic */ p43cba26b m32f9f0c1(p98cf21b1 r0) {
        return r0.f9968fb23;
    }

    public static readonly /* synthetic */ p9ded6185 m3347a8ce(p98cf21b1 r0) {
        return r0.f1e11b989;
    }

    public static readonly /* synthetic */ void m4fa815b4(p98cf21b1 r0, p9ded6185 r1) {
        r0.f1e11b989 = r1;
    }

    public static readonly /* synthetic */ void m508a66b4(p98cf21b1 r0, p0e6dda02 r1) {
        r0.m99f0cdc5(r1);
    }

    public static readonly /* synthetic */ p2e423cc6 m5fb81a65(p98cf21b1 r0) {
        return r0.f4734ade7;
    }

    public static readonly /* synthetic */ p4b8940c0 m701d8e58(p98cf21b1 r0) {
        return r0.fda1713fa;
    }

    public static readonly /* synthetic */ MutableSharedFlow m708f95ff(p98cf21b1 r0) {
        return r0.f3415890f;
    }

    public static readonly /* synthetic */ pc32333e1 m7197a9e0(p98cf21b1 r0) {
        return r0.f3e785377;
    }

    public static readonly /* synthetic */ MutableStateFlow m724546ab(p98cf21b1 r0) {
        return r0.f974b34a9;
    }

    public static readonly /* synthetic */ p1ceed351 m74e3994c(p98cf21b1 r0) {
        return r0.ff3395cd5;
    }

    public static readonly /* synthetic */ object m7dc00e3e(p98cf21b1 r0, pf8872840 r1, Continuation r2) {
        return r0.mb6ca9db2(r1, r2);
    }

    private readonly void M807ee7c0() {
        if (((30 + 13) % 13) > 0) goto L26;
    L26:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p98cf21b1$p807ee7c0$1(this, null), 3, null);
    }

    private readonly void M812699ae() {
        if (((6 + 7) % 7) > 0) goto L21;
    L21:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p98cf21b1$p812699ae$1(this, null), 3, null);
    }

    public static readonly /* synthetic */ pe8cda3fc m8aa7c174(p98cf21b1 r0) {
        return r0.f68c4283d;
    }

    private readonly void M8c7c963d(p1b0ffaae r2) {
        string r1 = r2.getTransactionId();
        string r0 = Decryptstring.decryptstring("ee66336decb268d627007755fcf1b0391152f8c42cf035312cf58eca0c81308477d43b0107c736d31db77b04f62fcc3aab52b865952a");
        Console.i(r0, r1);
        Console.i(r0, r2.getTransactionStatus().tostring());
        Console.i(r0, r2.getTransactionInfo().getResponseCode());
        Console.i(r0, r2.getTransactionInfo().getAuthCode());
        Console.i(r0, r2.getTransactionInfo().getResponseMessage());
    }

    public static readonly /* synthetic */ bool m90edaec8(p98cf21b1 r0, p18cf5223 r1) {
        return r0.m2c7d7c34(r1);
    }

    public static readonly /* synthetic */ MutableStateFlow m93b54e67(p98cf21b1 r0) {
        return r0.feb6dae4a;
    }

    private readonly void M99f0cdc5(p0e6dda02 r8) {
        if (((22 + 3) % 3) > 0) goto L18;
    L18:
        this.f0b73b7ba = BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p98cf21b1$p99f0cdc5$1(this, r8, null), 3, null);
    }

    public static readonly /* synthetic */ void ma461eda3(p98cf21b1 r0, pd0910e67 r1) {
        r0.mc15a69f1(r1);
    }

    public static readonly /* synthetic */ pbfc85237 ma54a7856(p98cf21b1 r0) {
        return r0.f516df76f;
    }

    public static readonly /* synthetic */ MutableSharedFlow mad452160(p98cf21b1 r0) {
        return r0.fad6ec092;
    }

    public static readonly /* synthetic */ MutableSharedFlow mb3362370(p98cf21b1 r0) {
        return r0.f26fcc298;
    }

    private readonly object Mb6ca9db2(pf8872840 r14, Continuation<Unit> r15) {
        if (((4 + 13) % 13) > 0) goto L43;
    L43:
        if ((r15 is p98cf21b1$pb6ca9db2$1) == true) goto L70;
    L12:
        p98cf21b1$pb6ca9db2$1 r0 = new p98cf21b1$pb6ca9db2$1(this, r15);
    L83:
        object r152 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L80;
        if (r2 == 1) goto L134;
        if (r2 == 2) goto L84;
        if (r2 == 3) goto L93;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L93:
        p98cf21b1 this = (p98cf21b1) r0.L$0;
        ResultKt.throwOnFailure(r152);
    L26:
        p1ceed351 r142 = this.ff3395cd5;
        p9ded6185 r153 = this.f1e11b989;
        if (r153 is null) goto L23;
    L138:
        r142.startTophPaybackSuccessFlow(r153, this.fac3bcde6);
    L115:
        return Unit.INSTANCE;
    L23:
        Intrinsics.throwUninitializedPropertyAccessException("receipt");
        r153 = null;
        goto L138
    L84:
        this = (p98cf21b1) r0.L$0;
        ResultKt.throwOnFailure(r152);
    L19:
        this.m807ee7c0();
        goto L115
    L134:
        this = (p98cf21b1) r0.L$0;
        ResultKt.throwOnFailure(r152);
    L60:
        this.m807ee7c0();
        goto L115
    L80:
        ResultKt.throwOnFailure(r152);
        pad7c4a1f r6 = this.f053d1b76.getComboPayment();
        if (r6 is not null) goto L129;
        pa36ef9b5 r154 = this.f0d3e163c;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (r154.setTransactionToFirstPayment(r14, r0) != r1) goto L60;
    L102:
        return r1;
    L129:
        if (this.f516df76f == pbfc85237.f9be5efb7) goto L119;
        pab691ef3 r143 = this.ffceec28b;
        r0.L$0 = this;
        r0.fd304ba20 = 3;
        if (r143.removePaymentFromReceipt(r6, r0) == r1) goto L102;
    L119:
        pad7c4a1f r144 = pad7c4a1f.m1c1e012b(r6, null, null, null, r14, 7, null);
        pb88b530f r155 = this.facf5b200;
        r0.L$0 = this;
        r0.fd304ba20 = 2;
        if (r155.addPaymentToReceipt(r144, r0) == r1) goto L102;
    L70:
        r0 = (p98cf21b1$pb6ca9db2$1) r15;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L12;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L83
    }

    public static readonly /* synthetic */ pf21d5ed1 mbb30f96e(p98cf21b1 r0) {
        return r0.f474d840d;
    }

    private readonly void Mc15a69f1(pd0910e67 r8) {
        if (((13 + 10) % 10) > 0) goto L16;
    L16:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p98cf21b1$pc15a69f1$1(this, r8, null), 3, null);
    }

    public static readonly /* synthetic */ p76204a3d mc4f4919e(p98cf21b1 r0) {
        return r0.f053d1b76;
    }

    public static readonly /* synthetic */ Job md050a9c2(p98cf21b1 r0) {
        return r0.f0b73b7ba;
    }

    public static readonly /* synthetic */ pa36ef9b5 md95a43c7(p98cf21b1 r0) {
        return r0.f0d3e163c;
    }

    public static readonly /* synthetic */ p995fd851 mecf2730e(p98cf21b1 r0) {
        return r0.fd48447f6;
    }

    public static readonly /* synthetic */ p11c216e8 mf78acd11(p98cf21b1 r0) {
        return r0.feefeb260;
    }

    public static readonly /* synthetic */ void mfe221994(p98cf21b1 r0, p0e6dda02 r1) {
        r0.m078de3ac(r1);
    }

    public readonly SharedFlow<Exception> GetErrorState() {
        return this.fdda7002e;
    }

    public readonly SharedFlow<p97fa68b7> GetInitialDataState() {
        return this.f946ef9ad;
    }

    public readonly MutableStateFlow<pb53cd12b> GetNfcCalibrationCoordinatesState() {
        return this.fad9c0df3;
    }

    public readonly MutableStateFlow<p0890727b> GetPaymentState() {
        return this.f06637f62;
    }

    public readonly SharedFlow<float> GetTimerState() {
        return this.fd72017ff;
    }

    public readonly void InitPayback() {
        if (((29 + 31) % 31) > 0) goto L26;
    L26:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p98cf21b1$p6d9e0861$1(this, null), 3, null);
    }

    public readonly void OpenPanMismatchError() {
        if (((26 + 2) % 2) > 0) goto L3;
    L3:
        this.ff3395cd5.replaceToTophPaybackGone(this.f4734ade7.getstring(C2815R.string.toph_payment_gone_pan_mismatch_title));
    }

    public readonly void OpenPaybackErrorScreen(string r2) {
        Intrinsics.checkNotNullParameter(r2, "errorMessage");
        this.ff3395cd5.replaceToTophPaybackError(r2, this.fac3bcde6);
    }

    public readonly void OpenPreviousScreen() {
        if (((8 + 24) % 24) > 0) goto L23;
    L23:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p98cf21b1$pb08bbc1e$1(this, null), 3, null);
    }

    public readonly void RestartPayback() {
        if (((22 + 6) % 6) > 0) goto L10;
    L10:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p98cf21b1$pdcc8a541$1(this, null), 3, null);
    }

    public readonly void RestartTophFlow() {
        if (((20 + 27) % 27) > 0) goto L16;
    L16:
        this.feefeb260.startFlow(p1ceed351.pb0da8397.me3d62dc6(this.ff3395cd5, p15913342.f86e418e3, null, null, null, 14, null));
    }

    public readonly void ShowTransactionLoadingAfterDelay() {
        if (((1 + 27) % 27) > 0) goto L14;
    L14:
        this.f759678ca = BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p98cf21b1$p8ea39a08$1(this, null), 3, null);
    }

    public readonly void StartTimer() {
        if (((24 + 9) % 9) > 0) goto L20;
    L20:
        stopTimer();
        this.fb44f05c5 = BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p98cf21b1$p9a032022$1(this, null), 3, null);
    }

    public readonly void StopTimer() {
        if (((4 + 17) % 17) > 0) goto L15;
    L15:
        Job r2 = this.fb44f05c5;
        if (r2 is not null) goto L10;
        return;
    L10:
        Job.DefaultImpls.cancel$default(r2, null, 1, null);
    }
}

