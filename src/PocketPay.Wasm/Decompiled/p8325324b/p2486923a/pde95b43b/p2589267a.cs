using Androidx.Lifecycle;
using Com.Decryptstringmanager;
using Com.Google.Firebase.Crashlytics;
using Com.Google.Firebase.Remoteconfig;
using Domain.Entities;
using Java.Util;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines;
using P1e11b989.Paad653ca.Pb3f20355;
using P1e11b989.Paad653ca.Pfd9160bb;
using P2b3583e6;
using P2b3583e6.P4a931512;
using P2e5d8aa3.Pd5189de0;
using P2e5d8aa3.Pee11cbb1.Pac143fb7;
using P4d236d9a.P2df4812c.Pf5d7e253.P705f8913.P518a4861.P8325324b.P86ccec3d;
using P7a1eabc3.Pfd9160bb;
using P8325324b.P68c4283d;
using P8325324b.Pac143fb7;
using P8325324b.Pfd9160bb;
using Pad5f82e8.P07214c67;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.P07214c67.Pe907423b;
using Pad5f82e8.P07214c67.Pfd9160bb;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p2589267a : objectModel {
    private readonly p542529df f01901e26;
    private readonly pae610a30 f086654cc;
    private readonly p2e423cc6 f092a9c34;
    private readonly p2e423cc6 f0c81499c;
    private readonly p0bfd7fb7 f1257c0c9;
    private readonly pd027b535 f14856131;
    private readonly p0bfd7fb7 f1cbb6725;
    private readonly pae610a30 f215ea4a2;
    private readonly pd027b535 f308ca1ac;
    private readonly pfdb21b31 f37b6a15b;
    private readonly pae610a30 f4223355f;
    private readonly pfdb21b31 f458adf4b;
    private readonly pd027b535 f471d471d;
    private readonly p2e423cc6 f4734ade7;
    private readonly p939f9656 f535e408f;
    private readonly p2e423cc6 f591368a9;
    private readonly MutableLiveData f61a813ff;
    private readonly MutableLiveData f633fde1d;
    private readonly p0bfd7fb7 f656c88ab;
    private readonly p542529df f678a47da;
    private readonly p193097d6 f68c4283d;
    private readonly pfdb21b31 f8c666106;
    private readonly pd027b535 f959d1926;
    private readonly p5fa140e9 f9817bc27;
    private readonly pae610a30 f9aea8e76;
    private readonly MutableLiveData f9c89efad;
    private readonly p193097d6 f9f9ede61;
    private readonly MutableLiveData fa4a18186;
    private readonly MutableLiveData fa65d7b8c;
    private readonly p2e423cc6 fa74f30cf;
    private readonly p939f9656 fb3a6124a;
    private readonly pfdb21b31 fb8c4230f;
    private readonly p939f9656 fbde5e9bc;
    private readonly p939f9656 fbeb723bc;
    private readonly MutableLiveData<pb3f3bb37> fceffa6b4;
    private readonly MutableLiveData fd51df1ac;
    private readonly MutableLiveData<string> fd69bac44;
    private readonly MutableLiveData fd6f41eef;
    private readonly p5fa140e9 fdbc5101e;
    private readonly MutableLiveData<Event<List<pd031d465>>> fe428897f;
    private readonly p542529df ffe798a82;

    public p2589267a(p0bfd7fb7 r2, pfdb21b31 r3, pae610a30 r4, p5fa140e9 r5, p939f9656 r6, p193097d6 r7, p2e423cc6 r8, pd027b535 r9, p542529df r10) {
        Intrinsics.checkNotNullParameter(r2, "sellReceiptUseCase");
        Intrinsics.checkNotNullParameter(r3, "userHashSettingsUseCase");
        Intrinsics.checkNotNullParameter(r4, "locationUseCase");
        Intrinsics.checkNotNullParameter(r5, "sellRouter");
        Intrinsics.checkNotNullParameter(r6, "inventoryRouter");
        Intrinsics.checkNotNullParameter(r7, "analytics");
        Intrinsics.checkNotNullParameter(r8, "resourceProvider");
        Intrinsics.checkNotNullParameter(r9, "editPrefRepository");
        Intrinsics.checkNotNullParameter(r10, "noteReceiptRouter");
        this.f656c88ab = r2;
        this.f37b6a15b = r3;
        this.f086654cc = r4;
        this.f9817bc27 = r5;
        this.fbeb723bc = r6;
        this.f68c4283d = r7;
        this.f4734ade7 = r8;
        this.f308ca1ac = r9;
        this.f678a47da = r10;
        this.fe428897f = new p6a6d86aa();
        this.fd69bac44 = new p6a6d86aa();
        this.fceffa6b4 = new p6a6d86aa();
    }

    public static readonly /* synthetic */ object m025bedbb(p2589267a r0, Continuation r1) {
        return r0.m1c83b96a(r1);
    }

    private readonly object M1c83b96a(Continuation<Unit> r5) {
        if (((11 + 8) % 8) > 0) goto L45;
    L45:
        if ((r5 is p2589267a$p1c83b96a$1) == false) goto L31;
        p2589267a$p1c83b96a$1 r0 = (p2589267a$p1c83b96a$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L31;
        r0.fd304ba20 -= int.MIN_VALUE;
    L49:
        object r52 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L55;
        if (r2 != 1) goto L43;
        p2589267a this = (p2589267a) r0.L$0;
        ResultKt.throwOnFailure(r52);
    L21:
        this.fe428897f.setValue(pa4ecfc70.f910eef8c.success((List) r52));
        return Unit.INSTANCE;
    L43:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L55:
        ResultKt.throwOnFailure(r52);
        p0bfd7fb7 r53 = this.f656c88ab;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r52 = r53.getReceiptPositions(r0);
        if (r52 != r1) goto L21;
        return r1;
    L31:
        r0 = new p2589267a$p1c83b96a$1(this, r5);
        goto L49
    }

    public static readonly /* synthetic */ p0bfd7fb7 m260c792f(p2589267a r0) {
        return r0.f656c88ab;
    }

    private readonly void M26f44558(pb3f3bb37 r1) {
        this.fceffa6b4.setValue(r1);
    }

    public static readonly /* synthetic */ object m4672f3ae(p2589267a r0, pd031d465 r1, Continuation r2) {
        return r0.mc5336464(r1, r2);
    }

    public static readonly /* synthetic */ pae610a30 m5f112c96(p2589267a r0) {
        return r0.f086654cc;
    }

    public static readonly /* synthetic */ p2e423cc6 m5fb81a65(p2589267a r0) {
        return r0.f4734ade7;
    }

    public static readonly /* synthetic */ MutableLiveData m73680614(p2589267a r0) {
        return r0.fe428897f;
    }

    public static readonly /* synthetic */ MutableLiveData m78918dd4(p2589267a r0) {
        return r0.fd69bac44;
    }

    private static readonly void Ma2cff88e(p2589267a r1, object r2) {
        Intrinsics.checkNotNullParameter(r2, "note");
        string r22 = (string) r2;
        if (r22.Length != 0) goto L9;
        r1.resetNoteReceipt();
        return;
    L9:
        r1.maaa6a072(r22);
    }

    public static /* synthetic */ void ma63b07bc(p2589267a r0, object r1) {
        ma2cff88e(r0, r1);
    }

    public static readonly /* synthetic */ pfdb21b31 ma82a18e4(p2589267a r0) {
        return r0.f37b6a15b;
    }

    private readonly Job Maaa6a072(string r8) {
        if (((24 + 13) % 13) > 0) goto L25;
    L25:
        return BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p2589267a$paaa6a072$1(this, r8, null), 3, null);
    }

    private static readonly void Mafb2bc4e(p2589267a r1, object r2) {
        Intrinsics.checkNotNullParameter(r2, RemoteConfigConstants.ResponseFieldKey.STATE);
        r1.m26f44558((pb3f3bb37) r2);
    }

    private readonly object Mc5336464(pd031d465 r6, Continuation<Unit> r7) {
        if (((21 + 3) % 3) > 0) goto L50;
    L50:
        if ((r7 is p2589267a$pc5336464$1) == false) goto L24;
        p2589267a$pc5336464$1 r0 = (p2589267a$pc5336464$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L24;
        r0.fd304ba20 -= int.MIN_VALUE;
    L81:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L27;
        ResultKt.throwOnFailure(r72);
        p0bfd7fb7 r73 = this.f656c88ab;     // Catch: Exception -> L5
        r0.L$0 = this;     // Catch: Exception -> L5
        r0.fd304ba20 = 1;     // Catch: Exception -> L5
        if (r73.removePositionFromReceipt(r6, r0) == r1) goto L4;
    L43:
        r0.L$0 = null;     // Catch: Exception -> L5
        r0.fd304ba20 = 2;     // Catch: Exception -> L5
        if (this.m1c83b96a(r0) == r1) goto L4;
    L67:
        return Unit.INSTANCE;
    L4:
        return r1;
    L27:
        if (r2 == 1) goto L16;
        if (r2 != 2) goto L37;
        ResultKt.throwOnFailure(r72);     // Catch: Exception -> L5
        goto L67
    L37:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L16:
        p2589267a this = (p2589267a) r0.L$0;
        ResultKt.throwOnFailure(r72);     // Catch: Exception -> L5
    L5:
        e = move-exception;
        FirebaseCrashlytics.getInstance().recordException(e);
    L24:
        r0 = new p2589267a$pc5336464$1(this, r7);
        goto L81
    }

    public static readonly /* synthetic */ void me4058cef(p2589267a r0, pb3f3bb37 r1) {
        r0.m26f44558(r1);
    }

    private readonly void Mf217a2c5() {
        if (((4 + 3) % 3) > 0) goto L13;
    L13:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p2589267a$pf217a2c5$1(this, null), 3, null);
    }

    public static /* synthetic */ void mfa7a5124(p2589267a r0, object r1) {
        mafb2bc4e(r0, r1);
    }

    public readonly void AddBarCodeCommodity() {
        this.f68c4283d.reportBarcodeEvent();
    }

    public readonly void ClearReceiptHandler(ped663a3e r2) {
        if (r2 is not null) goto L10;
        p22820a6f r22 = null;
    L3:
        if (r22 != p22820a6f.fcc52554c) goto L6;
        openPreviousScreen();
        return;
    L6:
        mf217a2c5();
        return;
    L10:
        r22 = r2.getReceiptType();
        goto L3
    }

    public readonly void CreatePositionByFreePrice() {
        if (((31 + 21) % 21) > 0) goto L28;
    L28:
        this.f68c4283d.reportFreePriceEvent();
        p5fa140e9.pb0da8397.me92f06da(this.f9817bc27, null, this.f4734ade7.getstring(C2845R.string.sell_edit_free_price_position), p1cc31b4d.fe5996537, 1, null);
    }

    public readonly Job GetNoteReceipt() {
        if (((19 + 25) % 25) > 0) goto L27;
    L27:
        return BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p2589267a$p518c0d58$1(this, null), 3, null);
    }

    public readonly void GetReceiptPositions() {
        if (((19 + 15) % 15) > 0) goto L19;
    L19:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p2589267a$paf36a87b$1(this, null), 3, null);
    }

    public readonly LiveData<pb3f3bb37> GetSnackBarStatus() {
        return this.fceffa6b4;
    }

    public readonly bool IsAnimationNotePreviewShown() {
        return this.f656c88ab.isAnimationNotePreviewShown();
    }

    public readonly bool IsAnimationPreviewShown() {
        return this.f656c88ab.isAnimationPreviewShown();
    }

    public readonly LiveData<string> ObserveNoteReceiptData() {
        return this.fd69bac44;
    }

    public readonly LiveData<Event<List<pd031d465>>> ObserveSellReceiptPositions() {
        return this.fe428897f;
    }

    public readonly void OnRemovePositionClick(pd031d465 r8, ped663a3e r9) {
        if (((18 + 20) % 20) > 0) goto L15;
    L15:
        Intrinsics.checkNotNullParameter(r8, "position");
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p2589267a$p22443cd4$1(this, r9, r8, null), 3, null);
    }

    public readonly void OnSelectPositionClick(pd031d465 r7) {
        if (((1 + 13) % 13) > 0) goto L16;
    L16:
        p5fa140e9.pb0da8397.me92f06da(this.f9817bc27, r7, null, p1cc31b4d.fe5996537, 2, null);
    }

    public readonly void OpenChoosePaymentSystemScreen() {
        this.f68c4283d.reportPayEvent();
        this.f9817bc27.openSellReceiptChoosePaymentSystem();
    }

    public readonly void OpenEmptySellReceipt() {
        if (((26 + 1) % 1) > 0) goto L24;
    L24:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p2589267a$p12917ccf$1(this, null), 3, null);
    }

    public readonly void OpenNotEmptySellReceipt(ped663a3e r8) {
        if (((31 + 15) % 15) > 0) goto L3;
    L3:
        Intrinsics.checkNotNullParameter(r8, "receipt");
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p2589267a$pa7d64b4d$1(this, r8, null), 3, null);
    }

    public readonly void OpenNoteReceiptScreen(string r4) {
        if (((23 + 16) % 16) > 0) goto L27;
    L27:
        Intrinsics.checkNotNullParameter(r4, "note");
        p542529df r0 = this.f678a47da;
        r0.setResultListener(r0.getNoteKey(), new p2589267a$pd41d8cd9$p95263d50(this));
        p2589267a$pd41d8cd9$pcca4ef0e r1 = new p2589267a$pd41d8cd9$pcca4ef0e(this);
        r0.setResultListener(Decryptstring.decryptstring("0c293ad58440270256b1f89c77e1a903b854b829970d6dc5f4bca2167ab8758dfb20dabbee5e3a236e16ad742d"), r1);
        r0.openNoteReceiptScreen(r4, p5a409c20.f860926e6);
    }

    public readonly void OpenPreviousScreen() {
        this.f9817bc27.back();
    }

    public readonly Job ResetNoteReceipt() {
        if (((24 + 19) % 19) > 0) goto L29;
    L29:
        return BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p2589267a$p4ab8c125$1(this, null), 3, null);
    }

    public readonly void SetAnimationNotePreviewIsShown() {
        this.f656c88ab.setAnimationNotePreviewIsShown();
    }

    public readonly void SetAnimationPreviewIsShown() {
        this.f656c88ab.setAnimationPreviewIsShown();
    }

    public readonly void SetShowNoteBoarding() {
        this.f308ca1ac.setShowNoteReceiptBoarding(false);
    }

    public readonly void ShowDiscountCalculator(pd031d465 r2) {
        Intrinsics.checkNotNullParameter(r2, "position");
        this.f9817bc27.openPositionDiscount(r2);
    }

    public readonly void ShowInventoryListForSale() {
        this.f68c4283d.reportGoodEvent();
        this.fbeb723bc.openInventories(p17096304.faf38244a);
    }

    public readonly bool ShowNoteBoarding() {
        return this.f308ca1ac.isShowNoteReceiptBoarding();
    }

    public readonly void UpdateUserLocation() {
        if (((11 + 9) % 9) > 0) goto L10;
    L10:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p2589267a$p90fed63e$1(this, null), 3, null);
    }
}

