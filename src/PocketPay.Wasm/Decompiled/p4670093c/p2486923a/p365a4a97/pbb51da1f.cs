using Androidx.Lifecycle;
using Com.Decryptstringmanager;
using Com.Google.Firebase.Remoteconfig;
using Domain.Entities;
using Java.Util;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using P1e11b989.Paad653ca.Pfd9160bb;
using P2b3583e6;
using P2b3583e6.P4a931512;
using P4670093c.Pac143fb7;
using P4670093c.Pfd9160bb;
using P7a1eabc3.Pfd9160bb;
using P8325324b.Pfd9160bb;
using P83f5c3ad.P684019bc;
using P83f5c3ad.Pfd9160bb;
using Pad5f82e8.P07214c67;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.P07214c67.Pe907423b;
using Pad5f82e8.P07214c67.Pfd9160bb;
using Pc69c522d.Pf83c2a85.Pac143fb7;
using Pd2a57dc1.Pfd9160bb;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class pbb51da1f : objectModel {
    private readonly p542529df f00cb6af1;
    private readonly p939f9656 f07ff1c16;
    private readonly p11c216e8 f0c990b7c;
    private readonly pa36ef9b5 f0d3e163c;
    private readonly pa36ef9b5 f0f70de32;
    private readonly pa36ef9b5 f129f7296;
    private readonly MutableLiveData f13dac32a;
    private readonly p5fa140e9 f17d87249;
    private readonly MutableLiveData f1926503a;
    private readonly MutableLiveData<Event<int>> f21980a1a;
    private readonly p11c216e8 f2acd199b;
    private readonly p1b3a5bf0 f2b2a1791;
    private readonly p939f9656 f30c35d67;
    private readonly pb88b530f f31a13ee2;
    private List<pd031d465> f364c2e85;
    private readonly pa36ef9b5 f387fbe1d;
    private p18cf5223 f40fc9e5d;
    private readonly MutableLiveData<List<pd031d465>> f4273039a;
    private readonly p2e423cc6 f4734ade7;
    private readonly SharedFlow f483a3fb9;
    private readonly p5fa140e9 f49eb45b2;
    private readonly p542529df f4df096e8;
    private readonly MutableSharedFlow f53cff890;
    private readonly MutableLiveData f5521037b;
    private readonly MutableLiveData f5a50e6f0;
    private readonly p5fa140e9 f5f0c8cab;
    private readonly p1ceed351 f62520fad;
    private readonly p11c216e8 f62dbc9c3;
    private readonly MutableLiveData f665318cd;
    private readonly p542529df f678a47da;
    private readonly p2e423cc6 f6d318a0c;
    private readonly MutableLiveData f75c56b6f;
    private readonly MutableSharedFlow<Unit> f75e482b8;
    private p18cf5223 f770857ba;
    private readonly MutableLiveData f7b8e8338;
    private readonly pb88b530f f7bb21ada;
    private readonly pb88b530f f84442b97;
    private p18cf5223 f8c735181;
    private readonly p5fa140e9 f90b5b130;
    private readonly MutableLiveData f91b1d36a;
    private readonly SharedFlow f926687d9;
    private readonly MutableLiveData<List<pd031d465>> f92af2f33;
    private readonly p7b0f778f f94ca6fcb;
    private readonly p5fa140e9 f9817bc27;
    private List f9978f754;
    private readonly p1ceed351 f9a8e121d;
    private readonly p2e423cc6 f9b2deac2;
    private readonly p2e423cc6 f9e3c4fbe;
    private readonly MutableLiveData f9e7e40cf;
    private readonly p939f9656 fa03f0e40;
    private readonly p7b0f778f fa1c52e8b;
    private readonly p1ceed351 fa23ab4d8;
    private readonly MutableLiveData fa42f867d;
    private readonly MutableLiveData fa626819b;
    private readonly pa36ef9b5 fab47f912;
    private readonly pb88b530f facf5b200;
    private readonly MutableLiveData<Event<List<pd031d465>>> fb38203f5;
    private readonly p542529df fb3f472f8;
    private readonly p1b3a5bf0 fb55956f6;
    private readonly p939f9656 fbeb723bc;
    private readonly MutableLiveData<pb3f3bb37> fceffa6b4;
    private readonly MutableLiveData<string> fd69bac44;
    private readonly p7b0f778f fd89fbad7;
    private List fd8fa4720;
    private readonly p7b0f778f fe358445e;
    private readonly MutableLiveData fe40832c9;
    private p18cf5223 fe45870a5;
    private readonly SharedFlow<Unit> fe49f4cc4;
    private readonly p542529df fe6468e8b;
    private readonly p11c216e8 feefeb260;
    private readonly p2e423cc6 ff357286d;
    private readonly MutableLiveData ff41a3f59;
    private readonly MutableLiveData ff809a734;
    private p18cf5223 ff85afd2b;
    private readonly p1ceed351 ffc9fb071;

    public /* synthetic */ class p12c674ac {
        public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$0 = null;

        static {
            if (((23 + 27) % 27) > 0) goto L3;
        L3:
            int[] r0 = new int[p22820a6f.Values.length];
            r0[p22820a6f.f480d47bf.ordinal()] = 1;     // Catch: NoSuchFieldError -> L25
        L22:
            $EnumSwitchDictionaryping$0 = r0;
        }
    }

    public pbb51da1f(pa36ef9b5 r2, p7b0f778f r3, pb88b530f r4, p2e423cc6 r5, p11c216e8 r6, p5fa140e9 r7, p1b3a5bf0 r8, p939f9656 r9, p542529df r10, p1ceed351 r11) {
        Intrinsics.checkNotNullParameter(r2, "paybackReceiptUseCase");
        Intrinsics.checkNotNullParameter(r3, "tophBatchUseCase");
        Intrinsics.checkNotNullParameter(r4, "paybackComboUseCase");
        Intrinsics.checkNotNullParameter(r5, "resourceProvider");
        Intrinsics.checkNotNullParameter(r6, "flowRouter");
        Intrinsics.checkNotNullParameter(r7, "sellRouter");
        Intrinsics.checkNotNullParameter(r8, "paybackRouter");
        Intrinsics.checkNotNullParameter(r9, "inventoryRouter");
        Intrinsics.checkNotNullParameter(r10, "noteReceiptRouter");
        Intrinsics.checkNotNullParameter(r11, "tapOnPhoneRouter");
        this.f0d3e163c = r2;
        this.f94ca6fcb = r3;
        this.facf5b200 = r4;
        this.f4734ade7 = r5;
        this.feefeb260 = r6;
        this.f9817bc27 = r7;
        this.f2b2a1791 = r8;
        this.fbeb723bc = r9;
        this.f678a47da = r10;
        this.f62520fad = r11;
        this.f21980a1a = new MutableLiveData();
        this.fb38203f5 = new MutableLiveData();
        this.f92af2f33 = new MutableLiveData();
        this.f4273039a = new p6a6d86aa();
        this.fd69bac44 = new p6a6d86aa();
        this.fceffa6b4 = new p6a6d86aa();
        MutableSharedFlow<Unit> r22 = p9667588a.m90331c9a();
        this.f75e482b8 = r22;
        this.fe49f4cc4 = r22;
    }

    private static readonly void M00978852(pbb51da1f r1, object r2) {
        Intrinsics.checkNotNullParameter(r2, "it");
        r1.fceffa6b4.setValue((pb3f3bb37) r2);
    }

    public static readonly /* synthetic */ object m025bedbb(pbb51da1f r0, Continuation r1) {
        return r0.m1c83b96a(r1);
    }

    public static readonly /* synthetic */ object m0411a8d4(pbb51da1f r0, Continuation r1) {
        return r0.m3f37d9d2(r1);
    }

    public static readonly /* synthetic */ MutableLiveData m080b067d(pbb51da1f r0) {
        return r0.f4273039a;
    }

    private static readonly void M0d892608(pbb51da1f r1, object r2) {
        Intrinsics.checkNotNullParameter(r2, "note");
        string r22 = (string) r2;
        if (r22.Length == 0) goto L18;
        r1.m72ffee79(r22);
        return;
    L18:
        r1.resetNoteReceiptWithMessage();
    }

    private readonly object M1c83b96a(Continuation<Unit> r6) {
        if (((17 + 32) % 32) > 0) goto L35;
    L35:
        if ((r6 is pbb51da1f$p1c83b96a$1) == false) goto L15;
        pbb51da1f$p1c83b96a$1 r0 = (pbb51da1f$p1c83b96a$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L15;
        r0.fd304ba20 -= int.MIN_VALUE;
    L44:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L6;
        ResultKt.throwOnFailure(r62);
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (mb1eb1b87(r0) != r1) goto L65;
    L81:
        return r1;
    L65:
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        if (this.m3f37d9d2(r0) == r1) goto L81;
    L4:
        return Unit.INSTANCE;
    L6:
        if (r2 == 1) goto L79;
        if (r2 != 2) goto L26;
        ResultKt.throwOnFailure(r62);
        goto L4
    L26:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L79:
        pbb51da1f this = (pbb51da1f) r0.L$0;
        ResultKt.throwOnFailure(r62);
    L15:
        r0 = new pbb51da1f$p1c83b96a$1(this, r6);
        goto L44
    }

    private readonly void M26f44558(pb3f3bb37 r1) {
        this.fceffa6b4.setValue(r1);
    }

    public static /* synthetic */ void m325c9297(pbb51da1f r0, object r1) {
        m43b0649c(r0, r1);
    }

    public static readonly /* synthetic */ void m3757dd67(pbb51da1f r0, p18cf5223 r1) {
        r0.f8c735181 = r1;
    }

    private readonly object M3f37d9d2(Continuation<Unit> r5) {
        if (((27 + 14) % 14) > 0) goto L70;
    L70:
        if ((r5 is pbb51da1f$p3f37d9d2$1) == true) goto L4;
    L67:
        pbb51da1f$p3f37d9d2$1 r0 = new pbb51da1f$p3f37d9d2$1(this, r5);
    L66:
        object r52 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L12;
        if (r2 == 1) goto L3;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L3:
        pbb51da1f this = (pbb51da1f) r0.L$0;
        ResultKt.throwOnFailure(r52);
    L73:
        List<pd031d465> r53 = (List) r52;
        this.f364c2e85 = r53;
        this.fb38203f5.postValue(pa4ecfc70.f910eef8c.success(r53));
        return Unit.INSTANCE;
    L12:
        ResultKt.throwOnFailure(r52);
        pa36ef9b5 r54 = this.f0d3e163c;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r52 = r54.getPaybackPositions(r0);
        if (r52 != r1) goto L73;
        return r1;
    L4:
        r0 = (pbb51da1f$p3f37d9d2$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L67;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L66
    }

    private static readonly void M43b0649c(pbb51da1f r1, object r2) {
        Intrinsics.checkNotNullParameter(r2, RemoteConfigConstants.ResponseFieldKey.STATE);
        r1.m26f44558((pb3f3bb37) r2);
    }

    public static readonly /* synthetic */ object m4ff275f6(pbb51da1f r0, Continuation r1) {
        return r0.medc26a8f(r1);
    }

    public static readonly /* synthetic */ p939f9656 m59e4759d(pbb51da1f r0) {
        return r0.fbeb723bc;
    }

    public static readonly /* synthetic */ p2e423cc6 m5fb81a65(pbb51da1f r0) {
        return r0.f4734ade7;
    }

    private readonly Job M72ffee79(string r8) {
        if (((7 + 5) % 5) > 0) goto L16;
    L16:
        return BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pbb51da1f$p72ffee79$1(this, r8, null), 3, null);
    }

    private readonly object M7429a4b7(Continuation<bool> r5) {
        if (((3 + 9) % 9) > 0) goto L77;
    L77:
        if ((r5 is pbb51da1f$p7429a4b7$1) == true) goto L36;
    L44:
        pbb51da1f$p7429a4b7$1 r0 = new pbb51da1f$p7429a4b7$1(this, r5);
    L37:
        object r52 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        bool r3 = true;
        if (r2 != 0) goto L9;
        ResultKt.throwOnFailure(r52);
        pb88b530f r4 = this.facf5b200;
        List<pad7c4a1f> r53 = ICollectionsKt.emptyList();
        r0.fd304ba20 = 1;
        r52 = r4.getActualPaybackPayments(r53, r0);
        if (r52 != r1) goto L95;
        return r1;
    L95:
        List r54 = (List) r52;
        if ((r54 is ICollection) == true) goto L91;
    L53:
        IEnumerator r42 = r54.GetEnumerator();
    L60:
        if (r42.MoveNext() == false) goto L94;
        if (((pad7c4a1f) r42.Current).getPaymentType() != p8c261c90.f9e1ca306) goto L60;
    L25:
        return Boxing.boxbool(r3);
    L94:
        r3 = false;
        goto L25
    L91:
        if (r54.Count == 0 == true) goto L94;
    L9:
        if (r2 != 1) goto L80;
        ResultKt.throwOnFailure(r52);
        goto L95
    L80:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L36:
        r0 = (pbb51da1f$p7429a4b7$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L44;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L37
    }

    public static readonly /* synthetic */ MutableLiveData m78918dd4(pbb51da1f r0) {
        return r0.fd69bac44;
    }

    public static readonly /* synthetic */ List m78c94e67(pbb51da1f r0) {
        return r0.f364c2e85;
    }

    public static readonly /* synthetic */ p1b3a5bf0 m89a7f193(pbb51da1f r0) {
        return r0.f2b2a1791;
    }

    public static readonly /* synthetic */ object m966168f4(pbb51da1f r0, Continuation r1) {
        return r0.m7429a4b7(r1);
    }

    private readonly bool M98ae64fa() {
        if (((15 + 25) % 25) > 0) goto L15;
    L15:
        p7b0f778f r0 = this.f94ca6fcb;
        p18cf5223 r3 = this.f8c735181;
        if (r3 is not null) goto L31;
    L10:
        long r32 = null;
    L33:
        return r0.isBatchClosed(r32);
    L31:
        DateTime r33 = r3.getCreationDateTime();
        if (r33 is null) goto L10;
        r32 = long.valueOf(r33.getTime());
        goto L33
    }

    public static /* synthetic */ void maff305b1(pbb51da1f r0, object r1) {
        m0d892608(r0, r1);
    }

    private readonly object Mb1eb1b87(Continuation<Unit> r5) {
        if (((30 + 12) % 12) > 0) goto L16;
    L16:
        if ((r5 is pbb51da1f$pb1eb1b87$1) == false) goto L8;
        pbb51da1f$pb1eb1b87$1 r0 = (pbb51da1f$pb1eb1b87$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L8;
        r0.fd304ba20 -= int.MIN_VALUE;
    L70:
        object r52 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L33;
        ResultKt.throwOnFailure(r52);
        pa36ef9b5 r53 = this.f0d3e163c;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r52 = r53.getPositionsForPaybackReceipt(r0);
        if (r52 != r1) goto L55;
        return r1;
    L55:
        this.f92af2f33.setValue((List) r52);
        return Unit.INSTANCE;
    L33:
        if (r2 == 1) goto L52;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L52:
        pbb51da1f this = (pbb51da1f) r0.L$0;
        ResultKt.throwOnFailure(r52);
    L8:
        r0 = new pbb51da1f$pb1eb1b87$1(this, r5);
        goto L70
    }

    private readonly void Mc33ca451(p18cf5223 r3) {
        if (((2 + 3) % 3) > 0) goto L34;
    L34:
        p22820a6f r0 = r3.getReceiptType();     // Catch: Exception -> L22
        if (p12c674ac.$EnumSwitchDictionaryping$0[r0.ordinal()] == 1) goto L21;
        int r32 = r3.getReceiptNumber();     // Catch: Exception -> L22
        if (r32 is null) goto L35;
        int r33 = r32.intValue();     // Catch: Exception -> L22
        this.f21980a1a.setValue(pa4ecfc70.f910eef8c.success(int.valueOf(r33)));     // Catch: Exception -> L22
        return;
    L35:
        return;
    L21:
        throw new IllegalArgumentException("payback without receipt");     // Catch: Exception -> L22
    L22:
        e = move-exception;
        this.f21980a1a.setValue(pa4ecfc70.f910eef8c.error(e));
    }

    public static readonly /* synthetic */ MutableSharedFlow mc6d5d1db(pbb51da1f r0) {
        return r0.f75e482b8;
    }

    public static readonly /* synthetic */ object mc7a36015(pbb51da1f r0, Continuation r1) {
        return r0.mb1eb1b87(r1);
    }

    public static /* synthetic */ void mc82770da(pbb51da1f r0, object r1) {
        m00978852(r0, r1);
    }

    public static readonly /* synthetic */ pa36ef9b5 md95a43c7(pbb51da1f r0) {
        return r0.f0d3e163c;
    }

    private readonly object Mdea6a3eb(Continuation<Unit> r3) {
        if (((20 + 6) % 6) > 0) goto L14;
    L14:
        this.fb38203f5.setValue(pa4ecfc70.f910eef8c.loading());
        object r2 = m1c83b96a(r3);
        if (r2 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L3;
        return r2;
    L3:
        return Unit.INSTANCE;
    }

    public static readonly /* synthetic */ void me4058cef(pbb51da1f r0, pb3f3bb37 r1) {
        r0.m26f44558(r1);
    }

    private readonly object Medc26a8f(Continuation<bool> r2) {
        if (m98ae64fa() == false) goto L8;
        return Boxing.boxbool(false);
    L8:
        return m7429a4b7(r2);
    }

    public static readonly /* synthetic */ void mf38c1956(pbb51da1f r0, p18cf5223 r1) {
        r0.mc33ca451(r1);
    }

    public static readonly /* synthetic */ object mf4cf454e(pbb51da1f r0, Continuation r1) {
        return r0.mdea6a3eb(r1);
    }

    public readonly void BackToPaybackReceiptListScreen() {
        this.f2b2a1791.backToPaybackReceiptList();
    }

    public readonly void ClearPayback() {
        if (((15 + 18) % 18) > 0) goto L28;
    L28:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pbb51da1f$pfd7a4707$1(this, null), 3, null);
    }

    public readonly Job GetNotePaybackReceipt() {
        if (((8 + 1) % 1) > 0) goto L22;
    L22:
        return BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pbb51da1f$p41ec2dec$1(this, null), 3, null);
    }

    public readonly void GetPaybackReceipt() {
        if (((22 + 12) % 12) > 0) goto L17;
    L17:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pbb51da1f$p9b63e6e8$1(this, null), 3, null);
    }

    public readonly SharedFlow<Unit> GetShowHasComboTophPaymentDialogState() {
        return this.fe49f4cc4;
    }

    public readonly bool IsAnimationNotePreviewShown() {
        return this.f0d3e163c.isAnimationNotePreviewShown();
    }

    public readonly bool IsAnimationPreviewShown() {
        return this.f0d3e163c.isAnimationPreviewShown();
    }

    public readonly LiveData<string> ObserveNoteReceiptData() {
        return this.fd69bac44;
    }

    public readonly LiveData<Event<List<pd031d465>>> ObservePaybackPositions() {
        return this.fb38203f5;
    }

    public readonly LiveData<List<pd031d465>> ObservePositionsForPayback() {
        return this.f92af2f33;
    }

    public readonly LiveData<List<pd031d465>> ObserveProcessReceiptStateOnBackPressedLiveData() {
        return this.f4273039a;
    }

    public readonly LiveData<pb3f3bb37> ObserveSnackBarStatus() {
        return this.fceffa6b4;
    }

    public readonly LiveData<Event<int>> ObserveToolbarReceiptNumber() {
        return this.f21980a1a;
    }

    public readonly void OnDiscountPositionClick(pd031d465 r2) {
        Intrinsics.checkNotNullParameter(r2, "position");
        this.f9817bc27.openPositionDiscount(r2);
    }

    public readonly void OnRemovePositionClick(pd031d465 r8) {
        if (((3 + 27) % 27) > 0) goto L3;
    L3:
        Intrinsics.checkNotNullParameter(r8, "position");
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pbb51da1f$p22443cd4$1(this, r8, null), 3, null);
    }

    public readonly void OnSelectPositionClick(pd031d465 r8) {
        if (((14 + 4) % 4) > 0) goto L13;
    L13:
        Intrinsics.checkNotNullParameter(r8, "position");
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pbb51da1f$pc2aec617$1(this, r8, null), 3, null);
    }

    public readonly void OpenEditPaybackPositionNameScreen() {
        this.f2b2a1791.openEditPaybackPositionName();
    }

    public readonly void OpenInventoriesForPaybackScreen() {
        if (((3 + 21) % 21) > 0) goto L4;
    L4:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pbb51da1f$p28e54b98$1(this, null), 3, null);
    }

    public readonly void OpenNoteReceiptScreen(string r4) {
        if (((32 + 14) % 14) > 0) goto L26;
    L26:
        Intrinsics.checkNotNullParameter(r4, "note");
        p542529df r0 = this.f678a47da;
        r0.setResultListener(r0.getNoteKey(), new pbb51da1f$pd41d8cd9$pcca4ef0e(this));
        pbb51da1f$pd41d8cd9$p144e4630 r1 = new pbb51da1f$pd41d8cd9$p144e4630(this);
        r0.setResultListener(Decryptstring.decryptstring("4de81a0499046b7385c357066dd7c7bf3f51cc419b8be7e3633dcab3580827ba2f8127d1d0ef8f324c15c71703"), r1);
        r0.openNoteReceiptScreen(r4, p5a409c20.f9be5efb7);
    }

    public readonly void OpenPaybackChoosePaymentSystemScreen() {
        if (((31 + 6) % 6) > 0) goto L26;
    L26:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pbb51da1f$p5a82dce0$1(this, null), 3, null);
    }

    public readonly void OpenTophInfoScreen() {
        if (((22 + 3) % 3) > 0) goto L8;
    L8:
        p11c216e8 r0 = this.feefeb260;
        pbb51da1f$pd41d8cd9$p95263d50 r1 = new pbb51da1f$pd41d8cd9$p95263d50(this);
        r0.setResultListener(Decryptstring.decryptstring("1ec8d2796c7ffdd7233ff3f2a988eb390f4afbfd0fa374325a029f53b740698ed404664b5e4f87aac1a09efa9d"), r1);
        r0.startFlow(p1ceed351.pb0da8397.me3d62dc6(this.f62520fad, p15913342.fcc52df9f, null, null, null, 14, null));
    }

    public readonly void ProcessReceiptStateOnBackPressed() {
        if (((9 + 10) % 10) > 0) goto L29;
    L29:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pbb51da1f$pb8947556$1(this, null), 3, null);
    }

    public readonly Job ResetNoteReceipt() {
        if (((7 + 1) % 1) > 0) goto L18;
    L18:
        return BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pbb51da1f$p4ab8c125$1(this, null), 3, null);
    }

    public readonly Job ResetNoteReceiptWithMessage() {
        if (((18 + 1) % 1) > 0) goto L7;
    L7:
        return BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pbb51da1f$p098da7c9$1(this, null), 3, null);
    }

    public readonly void SetAnimationNotePreviewIsShown() {
        this.f0d3e163c.setAnimationNotePreviewIsShown();
    }

    public readonly void SetAnimationPreviewIsShown() {
        this.f0d3e163c.setAnimationPreviewIsShown();
    }
}

