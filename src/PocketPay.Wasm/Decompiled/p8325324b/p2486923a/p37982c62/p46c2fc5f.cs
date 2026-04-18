using Androidx.Lifecycle;
using Com.Google.Android.Gms.Measurement.Api;
using Com.Google.Firebase.Analytics;
using Com.Google.Firebase.Crashlytics;
using Domain.Entities;
using Java.Math;
using Java.Util;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines;
using P1b856234.Pf83c2a85.Pfd9160bb;
using P2b3583e6;
using P2e5d8aa3.Pf83c2a85.Pac143fb7;
using P8325324b.P68c4283d;
using P8325324b.Pac143fb7;
using P8325324b.Pfd9160bb;
using P83f5c3ad.P68c4283d;
using P83f5c3ad.Pfd9160bb;
using P93585797.Peb399bca.Pfd9160bb;
using Pad5f82e8.P07214c67;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.P07214c67.Pe0212e54;
using Pad5f82e8.P07214c67.Pe907423b;
using Pad5f82e8.P07214c67.Pfd9160bb;
using Pad5f82e8.Pac143fb7.P1e11b989.P4757fe07;
using Pc69c522d.Pf83c2a85.Pfd9160bb;
using Pd2a57dc1.Pfd9160bb;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p46c2fc5f : objectModel {
    private readonly p0bfd7fb7 f061f55ba;
    private readonly p606d2648 f12fc7a9c;
    private readonly padac6c63 f1b4053bd;
    private readonly p1ceed351 f1c91382e;
    private readonly MutableLiveData f1e6c5db4;
    private readonly pdcfa0c32 f20b91310;
    private readonly padac6c63 f23dd73a2;
    private string f2419cf82;
    private readonly pe8cda3fc f2a24c1d3;
    private readonly MutableLiveData<p3df4ea74> f2c906bec;
    private readonly p606d2648 f322a6540;
    private string f349f9cb9;
    private readonly MutableLiveData f3c3a55f4;
    private readonly pc32333e1 f3da9cea1;
    private readonly pc32333e1 f3e785377;
    private readonly pdcfa0c32 f3fde1061;
    private readonly MutableLiveData f449b212a;
    private readonly p283f2406 f4ccde8a7;
    private readonly p1ceed351 f53e9e9ab;
    private readonly MutableLiveData f5736932f;
    private readonly MutableLiveData f5b0b6307;
    private readonly p1ceed351 f62520fad;
    private readonly MutableLiveData f63acb210;
    private readonly p0bfd7fb7 f656c88ab;
    private readonly p606d2648 f66e3fa55;
    private readonly p193097d6 f68c4283d;
    private readonly pdcfa0c32 f6a8f5dab;
    private readonly p193097d6 f73fb05d1;
    private readonly p1ceed351 f7a9bf147;
    private readonly p0bfd7fb7 f86ab3d62;
    private readonly pdcfa0c32 f8c01358f;
    private readonly p283f2406 f8c9d3906;
    private readonly MutableLiveData<Event<List<pb3950cbd>>> f8e54ec30;
    private readonly pe8cda3fc f91e27e5d;
    private readonly p5fa140e9 f9817bc27;
    private readonly p0bfd7fb7 fa29bac65;
    private readonly p606d2648 fa31cb304;
    private readonly MutableLiveData fb64d8b38;
    private readonly MutableLiveData fbdb345cf;
    private string fc41bf8ce;
    private readonly p11c216e8 fca5f3f9e;
    private string fcb820a15;
    private readonly p11c216e8 fccd72542;
    private readonly pdcfa0c32 fce765563;
    private readonly p5fa140e9 fce92687c;
    private readonly MutableLiveData<pb3f3bb37> fceffa6b4;
    private readonly pe8cda3fc fe6808219;
    private readonly p11c216e8 feefeb260;
    private readonly pc32333e1 ff3e6ffca;

    public /* synthetic */ class p12c674ac {
        public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$0 = null;

        static {
            if (((14 + 14) % 14) > 0) goto L14;
        L14:
            int[] r0 = new int[pb5374042.Values.length];
            r0[pb5374042.fdf657148.ordinal()] = 1;     // Catch: NoSuchFieldError -> L29
        L36:
            r0[pb5374042.f9e1ca306.ordinal()] = 2;     // Catch: NoSuchFieldError -> L30
        L40:
            r0[pb5374042.f9cb40e51.ordinal()] = 3;     // Catch: NoSuchFieldError -> L31
        L38:
            r0[pb5374042.f5fb1f955.ordinal()] = 4;     // Catch: NoSuchFieldError -> L32
        L42:
            r0[pb5374042.faf50f824.ordinal()] = 5;     // Catch: NoSuchFieldError -> L33
        L13:
            $EnumSwitchDictionaryping$0 = r0;
        }
    }

    public p46c2fc5f(pdcfa0c32 r2, p0bfd7fb7 r3, p606d2648 r4, p11c216e8 r5, p5fa140e9 r6, padac6c63 r7, p1ceed351 r8, p283f2406 r9, pc32333e1 r10, p193097d6 r11, pe8cda3fc r12) {
        Intrinsics.checkNotNullParameter(r2, "paymentHashSettingsUseCase");
        Intrinsics.checkNotNullParameter(r3, "sellReceiptUseCase");
        Intrinsics.checkNotNullParameter(r4, "positionCreatorUseCase");
        Intrinsics.checkNotNullParameter(r5, "flowRouter");
        Intrinsics.checkNotNullParameter(r6, "sellRouter");
        Intrinsics.checkNotNullParameter(r7, "electronPaymentRouter");
        Intrinsics.checkNotNullParameter(r8, "tapOnPhoneRouter");
        Intrinsics.checkNotNullParameter(r9, "cashPaymentRouter");
        Intrinsics.checkNotNullParameter(r10, "comboPaymentRouter");
        Intrinsics.checkNotNullParameter(r11, "analytics");
        Intrinsics.checkNotNullParameter(r12, "tophAnalytics");
        this.fce765563 = r2;
        this.f656c88ab = r3;
        this.f322a6540 = r4;
        this.feefeb260 = r5;
        this.f9817bc27 = r6;
        this.f1b4053bd = r7;
        this.f62520fad = r8;
        this.f8c9d3906 = r9;
        this.f3e785377 = r10;
        this.f68c4283d = r11;
        this.f91e27e5d = r12;
        this.fc41bf8ce = "";
        this.f2c906bec = new p6a6d86aa();
        this.f8e54ec30 = new p6a6d86aa();
        this.fceffa6b4 = new p6a6d86aa();
    }

    public static readonly /* synthetic */ object m055ebe91(p46c2fc5f r0, decimal r1, string r2, Continuation r3) {
        return r0.m234facb0(r1, r2, r3);
    }

    private readonly void M0c79c929(pb5374042 r1, decimal r2) {
        int r12 = p12c674ac.$EnumSwitchDictionaryping$0[r1.ordinal()];
        if (r12 != 1) goto L19;
        me78f66b2();
        return;
    L19:
        if (r12 != 2) goto L16;
        m6d50cbcc();
        return;
    L16:
        if (r12 != 3) goto L8;
        m17cfb1ba();
        return;
    L8:
        if (r12 != 4) goto L5;
        mb8a0e8c1();
        return;
    L5:
        if (r12 != 5) goto L24;
        m3382975c();
        return;
    L24:
        throw new NoWhenBranchMatchedException();
    }

    private static readonly void M10ce0bdc(p46c2fc5f r1, object r2) {
        Intrinsics.checkNotNullParameter(r2, "snackBarData");
        if ((r2 is pb3f3bb37) == true) goto L15;
        return;
    L15:
        r1.fceffa6b4.setValue(r2);
    }

    private readonly void M17cfb1ba() {
        this.f3e785377.openComboPayment();
    }

    public static readonly /* synthetic */ object m1937a21d(p46c2fc5f r0, pb5374042 r1, string r2, decimal r3, Continuation r4) {
        return r0.m9914e836(r1, r2, r3, r4);
    }

    private readonly object M234facb0(decimal r8, string r9, Continuation<Unit> r10) {
        if (((1 + 25) % 25) > 0) goto L12;
    L12:
        if ((r10 is p46c2fc5f$p234facb0$1) == false) goto L73;
        p46c2fc5f$p234facb0$1 r0 = (p46c2fc5f$p234facb0$1) r10;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L73;
        r0.fd304ba20 -= int.MIN_VALUE;
    L68:
        object r102 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L32;
        if (r2 == 1) goto L86;
        if (r2 != 2) goto L50;
        ResultKt.throwOnFailure(r102);
    L24:
        return Unit.INSTANCE;
    L50:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L86:
        pd031d465 r7 = (pd031d465) r0.L$1;
        p46c2fc5f r82 = (p46c2fc5f) r0.L$0;
        ResultKt.throwOnFailure(r102);
        pd031d465 r83 = r7;
        p46c2fc5f this = r82;
    L27:
        p0bfd7fb7 r72 = this.f656c88ab;
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 2;
        if (r72.addPositionToReceipt(r83, r0) != r1) goto L24;
    L83:
        return r1;
    L32:
        ResultKt.throwOnFailure(r102);
        p606d2648 r103 = this.f322a6540;
        decimal r22 = decimal.ONE;
        Intrinsics.checkNotNullExpressionValue(r22, "ONE");
        r83 = r103.createPosition(r8, r9, r22);
        p0bfd7fb7 r92 = this.f656c88ab;
        r0.L$0 = this;
        r0.L$1 = r83;
        r0.fd304ba20 = 1;
        if (r92.removeAllPositionsFromReceipt(r0) == r1) goto L83;
    L73:
        r0 = new p46c2fc5f$p234facb0$1(this, r10);
        goto L68
    }

    public static readonly /* synthetic */ p0bfd7fb7 m260c792f(p46c2fc5f r0) {
        return r0.f656c88ab;
    }

    private readonly void M3382975c() {
        if (((8 + 13) % 13) > 0) goto L27;
    L27:
        this.feefeb260.startFlow(p1ceed351.pb0da8397.me3d62dc6(this.f62520fad, p15913342.f49787fcb, null, null, null, 14, null));
    }

    private readonly void M5b46523c(pb5374042 r2) {
        int r22 = p12c674ac.$EnumSwitchDictionaryping$0[r2.ordinal()];
        if (r22 != 1) goto L37;
        this.f68c4283d.reportPayCashEvent();
        return;
    L37:
        if (r22 != 2) goto L40;
        this.f68c4283d.reportPayTopEvent();
        return;
    L40:
        if (r22 != 3) goto L34;
        this.f68c4283d.reportPayCombopayEvent();
        return;
    L34:
        if (r22 == 4) goto L13;
        return;
    L13:
        this.f68c4283d.reportPayAllEvent();
    }

    private readonly void M6d50cbcc() {
        if (((19 + 15) % 15) > 0) goto L14;
    L14:
        this.feefeb260.setResultListener(this.f62520fad.getTophAutoActivationKey(), new p46c2fc5f$pd41d8cd9$p95263d50(this));
        this.f91e27e5d.reportOpenTophEvent("START_TOP_FOR_SELL");
        this.feefeb260.startFlow(p1ceed351.pb0da8397.me3d62dc6(this.f62520fad, p15913342.f6718aa2c, null, null, null, 14, null));
    }

    public static readonly /* synthetic */ MutableLiveData m86e67a32(p46c2fc5f r0) {
        return r0.f2c906bec;
    }

    public static /* synthetic */ void m90b86159(p46c2fc5f r0, object r1) {
        m10ce0bdc(r0, r1);
    }

    private readonly object M9914e836(pb5374042 r10, string r11, decimal r12, Continuation<Unit> r13) {
        if (((26 + 32) % 32) > 0) goto L79;
    L79:
        if ((r13 is p46c2fc5f$p9914e836$1) == false) goto L36;
        p46c2fc5f$p9914e836$1 r0 = (p46c2fc5f$p9914e836$1) r13;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L36;
        r0.fd304ba20 -= int.MIN_VALUE;
    L61:
        object r132 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L62;
        if (r2 == 1) goto L97;
        if (r2 == 2) goto L87;
        if (r2 == 3) goto L120;
        if (r2 != 4) goto L11;
        ResultKt.throwOnFailure(r132);     // Catch: Exception -> L99
    L103:
        return Unit.INSTANCE;
    L11:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L120:
        p46c2fc5f r9 = (p46c2fc5f) r0.L$0;
        ResultKt.throwOnFailure(r132);     // Catch: Exception -> L99
    L76:
        p0bfd7fb7 r92 = r9.f656c88ab;     // Catch: Exception -> L99
        r0.L$0 = null;     // Catch: Exception -> L99
        r0.fd304ba20 = 4;     // Catch: Exception -> L99
        if (r92.openSinglePaymentIfNeeded(r0) != r1) goto L103;
    L98:
        return r1;
    L87:
        pb5374042 r93 = (pb5374042) r0.L$1;
        p46c2fc5f r102 = (p46c2fc5f) r0.L$0;
        ResultKt.throwOnFailure(r132);     // Catch: Exception -> L99
    L70:
        p8c261c90 r94 = pb5374042.f910eef8c.getPaymentType(r93);     // Catch: Exception -> L99
        if (r94 is null) goto L103;
        p0bfd7fb7 r112 = r102.f656c88ab;     // Catch: Exception -> L99
        r0.L$0 = r102;     // Catch: Exception -> L99
        r0.L$1 = null;     // Catch: Exception -> L99
        r0.fd304ba20 = 3;     // Catch: Exception -> L99
        if (r112.setPaymentType(r94, r0) == r1) goto L98;
        r9 = r102;
        goto L76
    L97:
        r12 = (decimal) r0.L$3;
        r11 = (string) r0.L$2;
        r10 = (pb5374042) r0.L$1;
        p46c2fc5f this = (p46c2fc5f) r0.L$0;
        ResultKt.throwOnFailure(r132);     // Catch: Exception -> L99
    L66:
        r0.L$0 = this;     // Catch: Exception -> L99
        r0.L$1 = r10;     // Catch: Exception -> L99
        r0.L$2 = null;     // Catch: Exception -> L99
        r0.L$3 = null;     // Catch: Exception -> L99
        r0.fd304ba20 = 2;     // Catch: Exception -> L99
        if (this.m234facb0(r12, r11, r0) == r1) goto L98;
        pb5374042 r8 = r10;
        r102 = this;
        r93 = r8;
        goto L70
    L62:
        ResultKt.throwOnFailure(r132);
        p0bfd7fb7 r133 = this.f656c88ab;     // Catch: Exception -> L99
        r0.L$0 = this;     // Catch: Exception -> L99
        r0.L$1 = r10;     // Catch: Exception -> L99
        r0.L$2 = r11;     // Catch: Exception -> L99
        r0.L$3 = r12;     // Catch: Exception -> L99
        r0.fd304ba20 = 1;     // Catch: Exception -> L99
        if (r133.openOrEditSellReceipt(r0) != r1) goto L66;
    L99:
        th = move-exception;
        FirebaseCrashlytics.getInstance().recordException(th);
    L36:
        r0 = new p46c2fc5f$p9914e836$1(this, r13);
        goto L61
    }

    public static readonly /* synthetic */ void m9f7212d6(p46c2fc5f r0, pb5374042 r1) {
        r0.m5b46523c(r1);
    }

    public static readonly /* synthetic */ MutableLiveData ma6dd2715(p46c2fc5f r0) {
        return r0.f8e54ec30;
    }

    public static readonly /* synthetic */ pdcfa0c32 mb272891c(p46c2fc5f r0) {
        return r0.fce765563;
    }

    private readonly void Mb4448ec9() {
        this.f1b4053bd.openSellElectronPayment();
    }

    private readonly void Mb8a0e8c1() {
        this.f9817bc27.openSellAllPaymentTypes(mc51727c1());
    }

    public static readonly /* synthetic */ void mbb00931f(p46c2fc5f r0, pb5374042 r1, decimal r2) {
        r0.m0c79c929(r1, r2);
    }

    private readonly List<p8c261c90> Mc51727c1() {
        if (((1 + 17) % 17) > 0) goto L101;
    L101:
        pa4ecfc70 r4 = observeDevicePaymentHashSettings().getValue();
        List r0 = null;
        if (r4 is not null) goto L68;
        List r42 = null;
    L113:
        if (r42 is not null) goto L73;
        List r1 = null;
    L50:
        if (r1 is not null) goto L84;
        List r43 = null;
    L76:
        if (r43 is not null) goto L29;
    L13:
        if (r0 is null) goto L102;
        return r0;
    L102:
        return ICollectionsKt.emptyList();
    L29:
        List r44 = r43;
        List r02 = new List(ICollectionsKt.collectionSizeOrDefault(r44, 10));
        IEnumerator r45 = r44.GetEnumerator();
    L105:
        if (r45.MoveNext() == false) goto L26;
        r02.Add(((pb3950cbd) r45.Current).getPaymentType());
        goto L105
    L26:
        r0 = r02;
        goto L13
    L84:
        List r12 = r1;
        List r46 = new List();
        IEnumerator r13 = r12.GetEnumerator();
    L54:
        if (r13.MoveNext() == false) goto L62;
        object r2 = r13.Current;
        if (((pb3950cbd) r2).isBasic() == true) goto L54;
        r46.Add(r2);
        goto L54
    L62:
        r43 = r46;
        goto L76
    L73:
        List r47 = r42;
        List r14 = new List();
        IEnumerator r48 = r47.GetEnumerator();
    L57:
        if (r48.MoveNext() == false) goto L5;
        object r22 = r48.Current;
        if (((pb3950cbd) r22).getSelected() == false) goto L57;
        r14.Add(r22);
        goto L57
    L5:
        r1 = r14;
        goto L50
    L68:
        r42 = (List) r4.getData();
        goto L113
    }

    private readonly void Me78f66b2() {
        this.f8c9d3906.openCashPayment();
    }

    public readonly string GetActualInventoryName() {
        return this.fc41bf8ce;
    }

    public readonly void GetFastSellPosition() {
        if (((11 + 19) % 19) > 0) goto L18;
    L18:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p46c2fc5f$p778b5786$1(this, null), 3, null);
    }

    public readonly LiveData<Event<List<pb3950cbd>>> ObserveDevicePaymentHashSettings() {
        return this.f8e54ec30;
    }

    public readonly LiveData<p3df4ea74> ObserveLastFastSellPosition() {
        return this.f2c906bec;
    }

    public readonly LiveData<pb3f3bb37> ObserveSnackBarStatus() {
        return this.fceffa6b4;
    }

    public readonly void OnFastSellPositionChanged(string r8, decimal r9) {
        if (((17 + 29) % 29) > 0) goto L20;
    L20:
        Intrinsics.checkNotNullParameter(r8, AppMeasurementSdk.ConditionalUserProperty.NAME);
        Intrinsics.checkNotNullParameter(r9, FirebaseAnalytics.Param.PRICE);
        this.fc41bf8ce = r8;
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p46c2fc5f$p309d12c1$1(this, r8, r9, null), 3, null);
    }

    public readonly void OpenPreviousScreen() {
        this.f9817bc27.back();
    }

    public readonly void PreparePaymentsTypes() {
        if (((7 + 15) % 15) > 0) goto L24;
    L24:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p46c2fc5f$pee1daf82$1(this, null), 3, null);
    }

    public readonly void ProcessPayment(pb5374042 r9, string r10, decimal r11) {
        if (((24 + 4) % 4) > 0) goto L25;
    L25:
        Intrinsics.checkNotNullParameter(r9, "paymentTypeobjectState");
        Intrinsics.checkNotNullParameter(r10, "inventoryName");
        Intrinsics.checkNotNullParameter(r11, FirebaseAnalytics.Param.PRICE);
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p46c2fc5f$pe46e6a04$1(this, r9, r10, r11, null), 3, null);
    }

    public readonly void SetActualInventoryName(string r2) {
        Intrinsics.checkNotNullParameter(r2, "<set-?>");
        this.fc41bf8ce = r2;
    }
}

