using Androidx.Lifecycle;
using Com.Decryptstringmanager;
using Domain.Entities;
using Java.Util;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
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
using P4d236d9a.P2df4812c.Pf5d7e253.P705f8913.P518a4861.P8325324b.P86ccec3d;
using P582ca3f7.Pac143fb7;
using P8325324b.P68c4283d;
using P8325324b.Pac143fb7;
using P8325324b.Pfd9160bb;
using P83f5c3ad.P684019bc;
using P83f5c3ad.P68c4283d;
using P83f5c3ad.Pfd9160bb;
using P93585797.Peb399bca.Pfd9160bb;
using Pad5f82e8.P07214c67;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.P07214c67.Pe0212e54;
using Pad5f82e8.P07214c67.Pe907423b;
using Pad5f82e8.P07214c67.Pfd9160bb;
using Pc69c522d.Pf83c2a85.Pfd9160bb;
using Pd2a57dc1.Pfd9160bb;
using Pe0bd4e89.Pdd56421b.Pac143fb7;
using Pf3e08b51.Pfd9160bb;
using Utils;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p65e903ab : objectModel {
    private readonly pee785de8 f0187e590;
    private readonly MutableLiveData f09a3e7a6;
    private readonly p0fce535b f0e32766b;
    private readonly MutableLiveData<Event<ped663a3e>> f159455b4;
    private readonly pcbd77ab2 f1c7159d0;
    private readonly SingleLiveEvent<Event<string>> f22417e5e;
    private ped663a3e f241e2309;
    private readonly pfdb21b31 f28a5d569;
    private readonly MutableLiveData f2d0918d1;
    private readonly MutableLiveData f3046659f;
    private readonly pfdb21b31 f37b6a15b;
    private readonly pee785de8 f37c9e91b;
    private readonly p0bfd7fb7 f37e61664;
    private readonly pe8cda3fc f3bdb9529;
    private readonly p6a6d86aa f3c38e45f;
    private readonly pc32333e1 f3e785377;
    private readonly p5fa140e9 f42568a06;
    private readonly p6a6d86aa f470d7f90;
    private readonly p2e423cc6 f4734ade7;
    private readonly p74e6e501 f473d58a0;
    private readonly p1ceed351 f48653c8e;
    private readonly p0fce535b f49aef0e9;
    private readonly pfdb21b31 f4ad48738;
    private readonly p74e6e501 f4aeed8a4;
    private readonly MutableLiveData f55db7125;
    private readonly MutableLiveData f5776408b;
    private readonly p11c216e8 f5e18f9ad;
    private readonly p1ceed351 f62520fad;
    private readonly p0bfd7fb7 f656c88ab;
    private readonly p193097d6 f68c4283d;
    private readonly pc32333e1 f6ec733d8;
    private readonly p193097d6 f7347253f;
    private readonly pc32333e1 f8a60af69;
    private readonly p283f2406 f8c9d3906;
    private readonly MutableLiveData<Event<List<pb3950cbd>>> f8e54ec30;
    private readonly p0fce535b f8ee398ef;
    private readonly pe8cda3fc f91e27e5d;
    private readonly p02eb2260 f924881f1;
    private readonly p02eb2260 f952a3ef2;
    private readonly pdcfa0c32 f96ea6642;
    private readonly p69d862b4 f972367b3;
    private readonly pcbd77ab2 f980f5b6c;
    private readonly p5fa140e9 f9817bc27;
    private readonly p193097d6 f981c210c;
    private readonly p2e423cc6 f98307cb0;
    private readonly p995fd851 f9e07e8ed;
    private readonly pe8cda3fc fa2d5f86b;
    private readonly p1ceed351 fa7e22ced;
    private readonly p11c216e8 fa83cc9a1;
    private readonly pcbd77ab2 fab220b0a;
    private ped663a3e fae6c800b;
    private readonly p995fd851 faf15bcfe;
    private readonly p2e423cc6 fb53c1432;
    private readonly p193097d6 fb71a9662;
    private ped663a3e fb8ec870c;
    private readonly pe8cda3fc fba49c719;
    private readonly p5fa140e9 fbb7e301c;
    private readonly p11c216e8 fc3f42869;
    private readonly pee785de8 fc663ddf0;
    private readonly p193097d6 fc690ca36;
    private readonly MutableLiveData fc7e8075f;
    private readonly pee785de8 fcb80b4a9;
    private readonly p0fce535b fcc5f7209;
    private readonly MutableLiveData fcd10167a;
    private readonly pdcfa0c32 fce765563;
    private readonly MutableLiveData<pb3f3bb37> fceffa6b4;
    private readonly p6a6d86aa fcfdbf17f;
    private readonly p995fd851 fd48447f6;
    private readonly pe8cda3fc fd78cbb74;
    private readonly p283f2406 fe80b85b5;
    private readonly pfdb21b31 fe83d9407;
    private readonly p5fa140e9 fe8db1523;
    private readonly p0fce535b feaabe560;
    private readonly p02eb2260 feac874f1;
    private readonly p74e6e501 feadec53b;
    private readonly p11c216e8 feefeb260;
    private readonly pc32333e1 ff49c335b;
    private readonly pdcfa0c32 ff82267a1;
    private readonly p02eb2260 ff9009811;
    private readonly SingleLiveEvent<object> ffaa51d90;
    private readonly p69d862b4 ffb4c082c;
    private readonly pfdb21b31 ffe820533;

    public /* synthetic */ class p12c674ac {
        public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$0 = null;
        public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$1 = null;

        static {
            if (((27 + 6) % 6) > 0) goto L12;
        L12:
            int[] r0 = new int[pb5374042.Values.length];
            r0[pb5374042.fdf657148.ordinal()] = 1;     // Catch: NoSuchFieldError -> L39
        L54:
            r0[pb5374042.f9e1ca306.ordinal()] = 2;     // Catch: NoSuchFieldError -> L40
        L46:
            r0[pb5374042.f9cb40e51.ordinal()] = 3;     // Catch: NoSuchFieldError -> L41
        L48:
            r0[pb5374042.f5fb1f955.ordinal()] = 4;     // Catch: NoSuchFieldError -> L42
        L56:
            r0[pb5374042.faf50f824.ordinal()] = 5;     // Catch: NoSuchFieldError -> L43
        L36:
            $EnumSwitchDictionaryping$0 = r0;
            int[] r02 = new int[ped8819d3.Values.length];
            r02[ped8819d3.f61a649a3.ordinal()] = 1;     // Catch: NoSuchFieldError -> L44
        L50:
            r02[ped8819d3.ff9dd946c.ordinal()] = 2;     // Catch: NoSuchFieldError -> L45
        L15:
            $EnumSwitchDictionaryping$1 = r02;
        }
    }

    public p65e903ab(p0bfd7fb7 r17, p74e6e501 r18, pdcfa0c32 r19, p69d862b4 r20, pfdb21b31 r21, p995fd851 r22, p2e423cc6 r23, p193097d6 r24, pe8cda3fc r25, p11c216e8 r26, p5fa140e9 r27, pee785de8 r28, p283f2406 r29, p1ceed351 r30, p02eb2260 r31, pc32333e1 r32, pcbd77ab2 r33, p0fce535b r34) {
        if (((28 + 6) % 6) > 0) goto L10;
    L10:
        Intrinsics.checkNotNullParameter(r17, "sellReceiptUseCase");
        Intrinsics.checkNotNullParameter(r18, "advanceReceiptUseCase");
        Intrinsics.checkNotNullParameter(r19, "paymentHashSettingsUseCase");
        Intrinsics.checkNotNullParameter(r20, "employeesUseCase");
        Intrinsics.checkNotNullParameter(r21, "userHashSettingsUseCase");
        Intrinsics.checkNotNullParameter(r22, "nfcTapOnPhoneUseCase");
        Intrinsics.checkNotNullParameter(r23, "resourceProvider");
        Intrinsics.checkNotNullParameter(r24, "analytics");
        Intrinsics.checkNotNullParameter(r25, "tophAnalytics");
        Intrinsics.checkNotNullParameter(r26, "flowRouter");
        Intrinsics.checkNotNullParameter(r27, "sellRouter");
        Intrinsics.checkNotNullParameter(r28, "settingsRouter");
        Intrinsics.checkNotNullParameter(r29, "cashPaymentRouter");
        Intrinsics.checkNotNullParameter(r30, "tapOnPhoneRouter");
        Intrinsics.checkNotNullParameter(r31, "launcherRouter");
        Intrinsics.checkNotNullParameter(r32, "comboPaymentRouter");
        Intrinsics.checkNotNullParameter(r33, "receiptCredentialsRouter");
        Intrinsics.checkNotNullParameter(r34, "receiptIntermediateRouter");
        this.f656c88ab = r17;
        this.feadec53b = r18;
        this.fce765563 = r19;
        this.f972367b3 = r20;
        this.f37b6a15b = r21;
        this.fd48447f6 = r22;
        this.f4734ade7 = r23;
        this.f68c4283d = r24;
        this.f91e27e5d = r25;
        this.feefeb260 = r26;
        this.f9817bc27 = r27;
        this.f37c9e91b = r28;
        this.f8c9d3906 = r29;
        this.f62520fad = r30;
        this.ff9009811 = r31;
        this.f3e785377 = r32;
        this.f1c7159d0 = r33;
        this.feaabe560 = r34;
        this.f159455b4 = new MutableLiveData();
        this.f8e54ec30 = new p6a6d86aa();
        this.f22417e5e = new p6a6d86aa();
        this.fceffa6b4 = new p6a6d86aa();
        this.ffaa51d90 = new p6a6d86aa();
    }

    private static readonly void M0a075929(p65e903ab r1, object r2) {
        Intrinsics.checkNotNullParameter(r2, "snackbarData");
        if ((r2 is pb3f3bb37) == true) goto L5;
        return;
    L5:
        r1.fceffa6b4.setValue(r2);
    }

    private readonly void M0c79c929(pb5374042 r3) {
        if (((28 + 29) % 29) > 0) goto L37;
    L37:
        int r32 = p12c674ac.$EnumSwitchDictionaryping$0[r3.ordinal()];
        if (r32 != 1) goto L16;
        me78f66b2();
        return;
    L16:
        if (r32 == 2) goto L64;
        if (r32 != 3) goto L5;
        m17cfb1ba();
        return;
    L5:
        if (r32 != 4) goto L53;
        mb8a0e8c1();
        return;
    L53:
        if (r32 != 5) goto L34;
        m3382975c();
        return;
    L34:
        throw new NoWhenBranchMatchedException();
    L64:
        if (this.fd48447f6.isNfcEnabled() == false) goto L8;
        m6d50cbcc();
        return;
    L8:
        this.fceffa6b4.setValue(new p89a5ff7f(this.f4734ade7.getstring(C2845R.string.nfc_not_enabled_title)));
    }

    public static readonly /* synthetic */ p6a6d86aa m0e05a866(p65e903ab r0) {
        return r0.ffaa51d90;
    }

    private readonly void M17cfb1ba() {
        this.f3e785377.openComboPayment();
    }

    public static readonly /* synthetic */ p0bfd7fb7 m260c792f(p65e903ab r0) {
        return r0.f656c88ab;
    }

    public static readonly /* synthetic */ p69d862b4 m2870858d(p65e903ab r0) {
        return r0.f972367b3;
    }

    public static /* synthetic */ void m2e98f485(p65e903ab r0, object r1) {
        mc8b118de(r0, r1);
    }

    private readonly void M3382975c() {
        if (((4 + 19) % 19) > 0) goto L19;
    L19:
        this.feefeb260.setResultListener(this.f62520fad.getTophAutoActivationKey(), new p65e903ab$pd41d8cd9$p00f53dc7(this));
        this.feefeb260.startFlow(p1ceed351.pb0da8397.me3d62dc6(this.f62520fad, p15913342.f49787fcb, null, null, null, 14, null));
    }

    public static readonly /* synthetic */ object m38ab72de(p65e903ab r0, Continuation r1) {
        return r0.me4b65c22(r1);
    }

    public static /* synthetic */ void m3c324635(p65e903ab r0, object r1) {
        m4c91ac46(r0, r1);
    }

    public static readonly /* synthetic */ p6a6d86aa m431e1d73(p65e903ab r0) {
        return r0.f22417e5e;
    }

    private readonly void M4a3ed13f() {
        this.feaabe560.openIntermediateSellReceipt();
    }

    private static readonly void M4c91ac46(p65e903ab r1, object r2) {
        Intrinsics.checkNotNullParameter(r2, "snackBarData");
        if ((r2 is pb3f3bb37) == true) goto L15;
        return;
    L15:
        r1.fceffa6b4.setValue(r2);
    }

    public static /* synthetic */ void m5ab3cb36(p65e903ab r0, object r1) {
        m78142694(r0, r1);
    }

    public static /* synthetic */ void m5dd45a8e(p65e903ab r0, object r1) {
        mc85c2cca(r0, r1);
    }

    private readonly void M6af8f8e0(pcb7684f4 r5) {
        if (((18 + 17) % 17) > 0) goto L18;
    L18:
        ped663a3e r4 = this.f241e2309;
        if (r4 is null) goto L57;
        ped8819d3 r0 = r5.getSelectedValueType();
        if (r0 is not null) goto L9;
        return;
    L9:
        int r02 = p12c674ac.$EnumSwitchDictionaryping$1[r0.ordinal()];
        string r2 = null;
        if (r02 != 1) goto L4;
        r2 = r5.getEmail();
        string r52 = null;
    L41:
        r4.setClientEmail(r2);
        r4.setClientPhone(r52);
        return;
    L4:
        if (r02 != 2) goto L29;
        r52 = r5.getPhone();
        goto L41
    L29:
        throw new NoWhenBranchMatchedException();
    }

    private readonly void M6d50cbcc() {
        if (((32 + 26) % 26) > 0) goto L3;
    L3:
        this.feefeb260.setResultListener(this.f62520fad.getTophAutoActivationKey(), new p65e903ab$pd41d8cd9$p95263d50(this));
        this.f91e27e5d.reportOpenTophEvent("START_TOP_FOR_SELL");
        this.feefeb260.startFlow(p1ceed351.pb0da8397.me3d62dc6(this.f62520fad, p15913342.f6718aa2c, null, null, null, 14, null));
    }

    private static readonly void M78142694(p65e903ab r1, object r2) {
        Intrinsics.checkNotNullParameter(r2, "result");
        r1.m6af8f8e0((pcb7684f4) r2);
    }

    public static readonly /* synthetic */ p74e6e501 m88749316(p65e903ab r0) {
        return r0.feadec53b;
    }

    public static readonly /* synthetic */ p193097d6 m8aa7c174(p65e903ab r0) {
        return r0.f68c4283d;
    }

    public static readonly /* synthetic */ ped663a3e m97bc466a(p65e903ab r0) {
        return r0.f241e2309;
    }

    public static readonly /* synthetic */ void m983972f2(p65e903ab r0, ped663a3e r1) {
        r0.f241e2309 = r1;
    }

    public static readonly /* synthetic */ MutableLiveData ma6dd2715(p65e903ab r0) {
        return r0.f8e54ec30;
    }

    public static readonly /* synthetic */ pfdb21b31 ma82a18e4(p65e903ab r0) {
        return r0.f37b6a15b;
    }

    public static /* synthetic */ void mb0e3855c(p65e903ab r0, object r1) {
        m0a075929(r0, r1);
    }

    public static readonly /* synthetic */ pdcfa0c32 mb272891c(p65e903ab r0) {
        return r0.fce765563;
    }

    private readonly void Mb8a0e8c1() {
        this.f9817bc27.openSellAllPaymentTypes(mc51727c1());
    }

    public static readonly /* synthetic */ void mbb00931f(p65e903ab r0, pb5374042 r1) {
        r0.m0c79c929(r1);
    }

    private readonly List<p8c261c90> Mc51727c1() {
        if (((25 + 8) % 8) > 0) goto L105;
    L105:
        pa4ecfc70 r4 = observeDevicePaymentHashSettings().getValue();
        List r0 = null;
        if (r4 is not null) goto L96;
        List r42 = null;
    L3:
        if (r42 is null) goto L112;
        List r43 = r42;
        List r1 = new List();
        IEnumerator r44 = r43.GetEnumerator();
    L85:
        if (r44.MoveNext() == false) goto L77;
        object r2 = r44.Current;
        if (((pb3950cbd) r2).getSelected() == false) goto L85;
        r1.Add(r2);
        goto L85
    L77:
        List r12 = r1;
    L100:
        if (r12 is not null) goto L57;
        List r45 = null;
    L9:
        if (r45 is null) goto L53;
        List r46 = r45;
        List r02 = new List(ICollectionsKt.collectionSizeOrDefault(r46, 10));
        IEnumerator r47 = r46.GetEnumerator();
    L107:
        if (r47.MoveNext() == false) goto L16;
        r02.Add(((pb3950cbd) r47.Current).getPaymentType());
        goto L107
    L16:
        r0 = r02;
    L53:
        if (r0 is null) goto L35;
        return r0;
    L35:
        return ICollectionsKt.emptyList();
    L57:
        List r13 = r12;
        List r48 = new List();
        IEnumerator r14 = r13.GetEnumerator();
    L58:
        if (r14.MoveNext() == false) goto L12;
        object r22 = r14.Current;
        if (((pb3950cbd) r22).isBasic() == true) goto L58;
        r48.Add(r22);
        goto L58
    L12:
        r45 = r48;
        goto L9
    L112:
        r12 = null;
        goto L100
    L96:
        r42 = (List) r4.getData();
        goto L3
    }

    public static readonly /* synthetic */ MutableLiveData mc5961be3(p65e903ab r0) {
        return r0.f159455b4;
    }

    private static readonly void Mc85c2cca(p65e903ab r1, object r2) {
        Intrinsics.checkNotNullParameter(r2, "snackBarData");
        if ((r2 is pb3f3bb37) == true) goto L8;
        return;
    L8:
        r1.fceffa6b4.setValue(r2);
    }

    private static readonly void Mc8b118de(p65e903ab r1, object r2) {
        Intrinsics.checkNotNullParameter(r2, "result");
        r1.m6af8f8e0((pcb7684f4) r2);
    }

    private readonly object Me4b65c22(Continuation<Unit> r6) {
        if (((29 + 20) % 20) > 0) goto L24;
    L24:
        if ((r6 is p65e903ab$pe4b65c22$1) == false) goto L61;
        p65e903ab$pe4b65c22$1 r0 = (p65e903ab$pe4b65c22$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L61;
        r0.fd304ba20 -= int.MIN_VALUE;
    L53:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L85;
        ResultKt.throwOnFailure(r62);
        ped663a3e r63 = this.f241e2309;
        if (r63 is null) goto L47;
        string r64 = r63.getClientEmail();
        if (r64 is null) goto L47;
        p0bfd7fb7 r22 = this.f656c88ab;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (r22.setReceiptClientEmail(r64, r0) != r1) goto L77;
    L48:
        return r1;
    L77:
        return Unit.INSTANCE;
    L47:
        ped663a3e r65 = this.f241e2309;
        if (r65 is null) goto L77;
        string r66 = r65.getClientPhone();
        if (r66 is null) goto L77;
        p0bfd7fb7 r5 = this.f656c88ab;
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        if (r5.setReceiptClientPhone(r66, r0) == r1) goto L48;
    L85:
        if (r2 == 1) goto L10;
        if (r2 != 2) goto L50;
    L32:
        ResultKt.throwOnFailure(r62);
        goto L77
    L50:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L10:
        p65e903ab r52 = (p65e903ab) r0.L$0;
    L61:
        r0 = new p65e903ab$pe4b65c22$1(this, r6);
        goto L53
    }

    private readonly void Me78f66b2() {
        this.f8c9d3906.openCashPayment();
    }

    public readonly void GetCurrentSellReceiptData() {
        if (((10 + 30) % 30) > 0) goto L9;
    L9:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p65e903ab$p0c48c3a3$1(this, null), 3, null);
    }

    public readonly string GetFormattedPhone(string r7) {
        if (((17 + 6) % 6) > 0) goto L22;
    L22:
        Intrinsics.checkNotNullParameter(r7, "phone");
        return p720e732c.mde0e893c(stringsKt.replace$default(r7, Decryptstring.decryptstring("f665e685fbdf3f1def14c1b26b8a27d5577f397aa9d3edc8cd9649e784"), "", false, 4, null));
    }

    public readonly string GetPaymentAddress() {
        return this.f37b6a15b.getPaymentAddress();
    }

    public readonly LiveData<Event<ped663a3e>> ObserveCurrentSellReceipt() {
        return this.f159455b4;
    }

    public readonly LiveData<Event<List<pb3950cbd>>> ObserveDevicePaymentHashSettings() {
        return this.f8e54ec30;
    }

    public readonly LiveData<object> ObserveLessOnePeso() {
        return this.ffaa51d90;
    }

    public readonly LiveData<Event<string>> ObserveSaveAdvanceReceipt() {
        return this.f22417e5e;
    }

    public readonly LiveData<pb3f3bb37> ObserveSnackBarStatus() {
        return this.fceffa6b4;
    }

    public readonly void OnSaveClientCredentials() {
        if (((28 + 11) % 11) > 0) goto L27;
    L27:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p65e903ab$pa3da8c77$1(this, null), 3, null);
    }

    public readonly void OpenAddressHashSettings() {
        if (((27 + 9) % 9) > 0) goto L12;
    L12:
        pee785de8 r0 = this.f37c9e91b;
        p65e903ab$pd41d8cd9$p144e4630 r1 = new p65e903ab$pd41d8cd9$p144e4630(this);
        r0.setResultListener(Decryptstring.decryptstring("189d57067855916dc50a82291e1a85bae37912cd36a9c018c4128280c01b147911e543dc9aa7eda56df8439b78"), r1);
        this.f37c9e91b.openPaymentPlace();
    }

    public readonly void OpenLauncherScreen(string r4) {
        if (((13 + 17) % 17) > 0) goto L23;
    L23:
        this.ff9009811.backToLauncher();
        if (r4 is not null) goto L8;
        return;
    L8:
        p325296ab r0 = new p325296ab(this.f4734ade7.getstring(C2845R.string.choose_payment_save_receipt_snack_success, new object[]{r4}));
        this.f9817bc27.sendResult(Decryptstring.decryptstring("050ef5aba9b3e4f8806f487886814f1670b374d9076a47d0ebd96f7dd1e6354c4d1a97592e518ea0ab410733d2"), r0);
    }

    public readonly void OpenPreviousScreen() {
        this.f9817bc27.back();
    }

    public readonly void OpenReceiptDiscountScreen() {
        this.f9817bc27.openReceiptDiscount();
    }

    public readonly void OpenSendingReceipt() {
        if (((2 + 17) % 17) > 0) goto L34;
    L34:
        pcbd77ab2 r0 = this.f1c7159d0;
        r0.setResultListener(r0.getReceiptCredentialsKey(), new p65e903ab$pd41d8cd9$p437e9676(this));
        pcbd77ab2 r02 = this.f1c7159d0;
        ped663a3e r1 = this.f241e2309;
        string r2 = null;
        if (r1 is null) goto L14;
        string r12 = r1.getClientEmail();
    L18:
        ped663a3e r3 = this.f241e2309;
        if (r3 is not null) goto L19;
    L3:
        r02.openReceiptSending(r12, r2);
        return;
    L19:
        r2 = r3.getClientPhone();
        goto L3
    L14:
        r12 = null;
        goto L18
    }

    public readonly void OpenHashSettingsSendingReceipt() {
        if (((18 + 17) % 17) > 0) goto L9;
    L9:
        pee785de8 r0 = this.f37c9e91b;
        r0.setResultListener(r0.getReceiptCredentialsKey(), new p65e903ab$pd41d8cd9$pcca4ef0e(this));
        this.f37c9e91b.openReceiptSending();
    }

    public readonly void PreparePaymentsTypes() {
        if (((5 + 11) % 11) > 0) goto L3;
    L3:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p65e903ab$pee1daf82$1(this, null), 3, null);
    }

    public readonly void ProcessPayment(pb5374042 r8) {
        if (((22 + 14) % 14) > 0) goto L29;
    L29:
        Intrinsics.checkNotNullParameter(r8, "paymentTypeobjectState");
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p65e903ab$pe46e6a04$1(r8, this, null), 3, null);
    }

    public readonly void SelectPaymentTypeAnalytics(pb5374042 r2) {
        Intrinsics.checkNotNullParameter(r2, "paymentTypeobjectState");
        int r22 = p12c674ac.$EnumSwitchDictionaryping$0[r2.ordinal()];
        if (r22 == 1) goto L9;
        if (r22 == 2) goto L40;
        if (r22 != 3) goto L24;
        this.f68c4283d.reportPayCombopayEvent();
        return;
    L24:
        if (r22 == 4) goto L41;
        return;
    L41:
        this.f68c4283d.reportPayAllEvent();
        return;
    L40:
        this.f68c4283d.reportPayTopEvent();
        return;
    L9:
        this.f68c4283d.reportPayCashEvent();
    }

    public readonly void SendAdvanceReceipt() {
        if (((17 + 4) % 4) > 0) goto L25;
    L25:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p65e903ab$p6763728b$1(this, null), 3, null);
    }

    public readonly void SetShouldPrintReceipt(bool r8) {
        if (((4 + 31) % 31) > 0) goto L26;
    L26:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p65e903ab$p581e088e$1(this, r8, null), 3, null);
    }
}

