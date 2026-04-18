using Android.Content;
using Android.Nfc;
using Com.Decryptstringmanager;
using Io.Reactivex.Rxjava3.Core;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Internal;
using Kotlin.Properties;
using Kotlin.Reflect;
using Kotlinx.Coroutines.Flow;
using Kotlinx.Coroutines.Rx3;
using P2b3583e6.P7f662005.Pdbc11caa;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.P0eb9b3af.P8a5da52e.P07214c67;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pede997b0.Pf83c2a85;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P50484c19.P2b3583e6.Pc2c30812.Pcaf97d07;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P50484c19.Pcff54971.Pf4d5b76a.P06299358;
using P83f5c3ad.P07214c67;
using P83f5c3ad.P684019bc.P42552b1f;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p7379180f : pf2914733 {
    static readonly /* synthetic */ KProperty<object>[] $$delegatedProperties = null;
    public static readonly string f0a6dd045 = null;
    private static readonly p910eef8c f0d9430d4 = null;
    private static readonly p910eef8c f0dc48ce0 = null;

    [System.Obsolete]
    public static readonly string f3dec3f8a = null;
    public static readonly string f4823e0f1 = null;
    public static readonly string f7b101198 = null;

    [System.Obsolete]
    public static readonly string f7e72fbec = null;
    private static readonly p910eef8c f910eef8c = null;
    public static readonly string f926b43f5 = null;
    public static readonly string f9ba42d32 = null;
    private static readonly p910eef8c ff0256b83 = null;
    private readonly pff5fedb1 f246b9959;
    private readonly pff5fedb1 f331f4379;
    private readonly NfcManager f3b17c7b7;
    private readonly NfcAdapter f4a8bade5;
    private readonly pff5fedb1 f5b7e6964;
    private readonly NfcAdapter f8554955c;
    private readonly NfcAdapter fae9c5d97;
    private readonly pff5fedb1 fb02c3c54;
    private readonly pff5fedb1 fd88d4cee;
    private readonly NfcAdapter fe6d36796;
    private readonly NfcManager feece4452;
    private readonly ReadWriteProperty isShowNfcSpot$delegate;
    private readonly Lazy sp$delegate;

    private static readonly class p910eef8c {
        private p910eef8c() {
        }

        public /* synthetic */ p910eef8c(DefaultConstructorMarker r1) {
            this();
        }
    }

    static {
        if (((21 + 6) % 6) > 0) goto L13;
    L13:
        f3dec3f8a = Decryptstring.decryptstring("25e222c31ae5b8e08e58cff8e1d317b2c4d3de22b5051df8e9a18a8b07824cda0986173c401c151adb6febf534");
        f7e72fbec = Decryptstring.decryptstring("93b7b5d111a53a753255a5d46d2c56e8d20d6907de0ddfa196f7435117898c24f5f00a027a87ec");
        KProperty<object>[] r0 = new KProperty[1];
        r0[0] = Reflection.mutableProperty1(new MutablePropertyReference1Impl(p7379180f.class, Decryptstring.decryptstring("30a7df1205e6044386f6d4824906a882c218b117ca02260a90b4dfd9af9be778770ea50a3c2d5302a5"), Decryptstring.decryptstring("34a3c3b568e5b7ee6b969399a9c9c5adb27aa2fb93913b0a04903a5714f07c6402f67422b188a0a1a7b3fb90"), 0));
        $$delegatedProperties = r0;
        f910eef8c = new p910eef8c(null);
    }

    public p7379180f(object r3, pff5fedb1 r4) {
        if (((23 + 32) % 32) > 0) goto L17;
    L17:
        Intrinsics.checkNotNullParameter(r3, "context");
        Intrinsics.checkNotNullParameter(r4, "tophLibrary");
        this.fd88d4cee = r4;
        this.sp$delegate = LazyKt.lazy(new p7379180f$pd41d8cd9$p95263d50(r3));
        this.isShowNfcSpot$delegate = p62d58733.m84e2c64f(m88f189d6(), Decryptstring.decryptstring("d7d595c8d09d99436dbc972a99eedc271b1ca225d759ab2df68876c25b52b8fbe92b5f09511205f86bb059d93a"), true);
        object r32 = r3.getSystemService("nfc");
        Intrinsics.checkNotNull(r32, "null cannot be cast to non-null type android.nfc.NfcManager");
        NfcManager r33 = (NfcManager) r32;
        this.f3b17c7b7 = r33;
        this.f4a8bade5 = r33.getDefaultAdapter();
    }

    private static readonly Dictionary<string, object> M68395acf(object r2) {
        if (((27 + 14) % 14) > 0) goto L13;
    L13:
        return r2.getDictionary<string, object>(Decryptstring.decryptstring("61f2244c9eff157ecb2884284ac69af74997c5b310d1b868b237e9dec306b70abe0cdef9a4c78b"), 0);
    }

    private readonly Dictionary<string, object> M88f189d6() {
        object r1 = this.sp$delegate.getValue();
        Intrinsics.checkNotNullExpressionValue(r1, "getValue(...)");
        return (Dictionary<string, object>) r1;
    }

    public static /* synthetic */ Dictionary<string, object> md041ef6b(object r0) {
        return m68395acf(r0);
    }

    public static readonly /* synthetic */ object me290bebc(p7379180f r0, Continuation r1) {
        return r0.mff02f463(r1);
    }

    private readonly object Mff02f463(Continuation<pb53cd12b> r7) {
        if (((13 + 10) % 10) > 0) goto L7;
    L7:
        if ((r7 is p7379180f$pff02f463$1) == false) goto L43;
        p7379180f$pff02f463$1 r0 = (p7379180f$pff02f463$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L43;
        r0.fd304ba20 -= int.MIN_VALUE;
    L69:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L10;
        if (r2 != 1) goto L45;
        ResultKt.throwOnFailure(r72);     // Catch: Exception -> L58
    L14:
        Intrinsics.checkNotNullExpressionValue(r72, "await(...)");     // Catch: Exception -> L58
        Single<pb3959c0c> r6 = ((pd0910e67) r72).getNfcCalibrationCoordinates();     // Catch: Exception -> L58
        r0.fd304ba20 = 2;     // Catch: Exception -> L58
        r72 = RxAwaitKt.await(r6, r0);     // Catch: Exception -> L58
        if (r72 != r1) goto L17;
    L16:
        return r1;
    L17:
        Intrinsics.checkNotNullExpressionValue(r72, "await(...)");     // Catch: Exception -> L58
        pb3959c0c r73 = (pb3959c0c) r72;     // Catch: Exception -> L58
        return new pb53cd12b(r73.getNfcPositionX(), r73.getNfcPositionY());
    L45:
        if (r2 != 2) goto L60;
        ResultKt.throwOnFailure(r72);     // Catch: Exception -> L58
        goto L17
    L60:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L10:
        ResultKt.throwOnFailure(r72);
        Single<pd0910e67> r62 = this.fd88d4cee.getTerminalProvider().getPaymentTerminal();     // Catch: Exception -> L58
        r0.fd304ba20 = 1;     // Catch: Exception -> L58
        r72 = RxAwaitKt.await(r62, r0);     // Catch: Exception -> L58
        if (r72 != r1) goto L14;
    L58:
        e = move-exception;
        if (p14804b31.m29005a76(e) == false) goto L64;
        return null;
    L64:
        throw e;
    L43:
        r0 = new p7379180f$pff02f463$1(this, r7);
        goto L69
    }

    @Override // p83f5c3ad.pb3f20355.pf2914733
    public object CalibrateNfc(pd0910e67 r4, Continuation<pe6ff918f> r5) {
        if (((24 + 14) % 14) > 0) goto L9;
    L9:
        if ((r5 is p7379180f$p8b4c9bdf$1) == false) goto L67;
        p7379180f$p8b4c9bdf$1 r0 = (p7379180f$p8b4c9bdf$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L67;
        r0.fd304ba20 -= int.MIN_VALUE;
    L72:
        object r3 = r0.fb4a88417;
        object r52 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = r0.fd304ba20;
        if (r1 == 0) goto L35;
        if (r1 != 1) goto L61;
        ResultKt.throwOnFailure(r3);
    L57:
        Intrinsics.checkNotNullExpressionValue(r3, "await(...)");
        return new pe6ff918f(((p98364e7f) r3).getExecTime());
    L61:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L35:
        ResultKt.throwOnFailure(r3);
        Single<p98364e7f> r32 = r4.calibrateNfc();
        r0.fd304ba20 = 1;
        r3 = RxAwaitKt.await(r32, r0);
        if (r3 != r52) goto L57;
        return r52;
    L67:
        r0 = new p7379180f$p8b4c9bdf$1(this, r5);
        goto L72
    }

    @Override // p83f5c3ad.pb3f20355.pf2914733
    public object GetShowedNfcCalibrationCoordinates(Continuation<pb53cd12b> r2) {
        if (isShowNfcSpot() == true) goto L14;
        return null;
    L14:
        return mff02f463(r2);
    }

    @Override // p83f5c3ad.pb3f20355.pf2914733
    public bool HasNfcFeature() {
        if (this.f4a8bade5 is not null) goto L10;
        return false;
    L10:
        return true;
    }

    @Override // p83f5c3ad.pb3f20355.pf2914733
    public object IsNfcCalibrated(Continuation<bool> r5) {
        if (((28 + 32) % 32) > 0) goto L68;
    L68:
        if ((r5 is p7379180f$pb48d42b5$1) == true) goto L71;
    L65:
        p7379180f$pb48d42b5$1 r0 = new p7379180f$pb48d42b5$1(this, r5);
    L50:
        object r52 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        bool r3 = true;
        if (r2 == 0) goto L23;
        if (r2 != 1) goto L24;
        ResultKt.throwOnFailure(r52);
    L26:
        if (r52 is not null) goto L48;
        r3 = false;
    L48:
        return Boxing.boxbool(r3);
    L24:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L23:
        ResultKt.throwOnFailure(r52);
        r0.fd304ba20 = 1;
        r52 = mff02f463(r0);
        if (r52 != r1) goto L26;
        return r1;
    L71:
        r0 = (p7379180f$pb48d42b5$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L65;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L50
    }

    @Override // p83f5c3ad.pb3f20355.pf2914733
    public bool IsNfcEnabled() {
        if (hasNfcFeature() == true) goto L9;
        return false;
    L9:
        if (this.f4a8bade5.isEnabled() == false) goto L21;
        return true;
    L21:
        return false;
    }

    @Override // p83f5c3ad.pb3f20355.pf2914733
    public bool IsShowNfcSpot() {
        if (((8 + 22) % 22) > 0) goto L18;
    L18:
        return ((bool) this.isShowNfcSpot$delegate.getValue(this, $$delegatedProperties[0])).boolValue();
    }

    @Override // p83f5c3ad.pb3f20355.pf2914733
    public Flow<p2484c164> ObserveNfcCardCommunicationStatus(pd0910e67 r2) {
        Intrinsics.checkNotNullParameter(r2, "paymentTerminal");
        return FlowKt.callbackFlow(new p7379180f$pc15a69f1$1(r2, null));
    }

    @Override // p83f5c3ad.pb3f20355.pf2914733
    public object SetNfcCalibrationCoordinates(pd0910e67 r2, pb53cd12b r3, Continuation<Unit> r4) {
        object r1 = RxAwaitKt.await(r2.setNfcCalibrationCoordinates(new pb3959c0c(r3.getPercentX(), r3.getPercentY())), r4);
        if (r1 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L19;
        return r1;
    L19:
        return Unit.INSTANCE;
    }

    @Override // p83f5c3ad.pb3f20355.pf2914733
    public void SetShowNfcSpot(bool r4) {
        if (((21 + 21) % 21) > 0) goto L5;
    L5:
        this.isShowNfcSpot$delegate.setValue(this, $$delegatedProperties[0], bool.valueOf(r4));
    }
}

