using Androidx.Paging;
using Com.Google.Android.Gms.Actions;
using Java.Math;
using Java.Util;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines.Flow;
using P2b3583e6;
using P2b3583e6.P263e3cef;
using P2b3583e6.P4a931512;
using P2e5d8aa3.Pe0212e54.Pb3f20355;
using P4670093c.Pb3f20355;
using P582ca3f7.Pb3f20355;
using P5a445d71.P228c1b3d.P07cc694b;
using P7a1eabc3.P07214c67.P20f35e63;
using P8d777f38.Pb3f20355.Pd2a57dc1;
using Pad5f82e8.P07214c67;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.P07214c67.Pfa547353;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p25b01efc : pa36ef9b5 {
    private readonly p2e423cc6 f0ece2ad4;
    private readonly p6d29e2ef f221a4ea1;
    private readonly p0c2c0436 f2a53b9fe;
    private readonly p6d29e2ef f2afa56a5;
    private readonly p0c2c0436 f2d330b74;
    private readonly p2d884c28 f469db930;
    private readonly p2e423cc6 f4734ade7;
    private readonly p6d29e2ef f5228aaf9;
    private readonly p0c2c0436 f6616df07;
    private readonly p24ddebba f78129a46;
    private readonly p6d29e2ef f97e1f910;
    private readonly p24ddebba fa1d6db19;
    private readonly p2d884c28 fbbcec403;
    private readonly p2d884c28 fc822aaa6;
    private readonly p24ddebba fc8e4aeee;
    private readonly p6d29e2ef fd8c19903;
    private readonly p24ddebba fe08333a0;
    private readonly p0c2c0436 fedc5f59e;
    private readonly p24ddebba ffa7d8c2b;

    public p25b01efc(p24ddebba r2, p0c2c0436 r3, p2d884c28 r4, p6d29e2ef r5, p2e423cc6 r6) {
        Intrinsics.checkNotNullParameter(r2, "paybackReceiptRepository");
        Intrinsics.checkNotNullParameter(r3, "employeesRepository");
        Intrinsics.checkNotNullParameter(r4, "localHashSettingsRepository");
        Intrinsics.checkNotNullParameter(r5, "applicationStateRepository");
        Intrinsics.checkNotNullParameter(r6, "resourceProvider");
        this.f78129a46 = r2;
        this.fedc5f59e = r3;
        this.fbbcec403 = r4;
        this.f97e1f910 = r5;
        this.f4734ade7 = r6;
    }

    private readonly p55f8d305.pffe42ac4 M0f036448(p55f8d305.p5d3072af r4) {
        if (((13 + 6) % 6) > 0) goto L3;
    L3:
        return new p55f8d305.pffe42ac4(p728cd16b.m517248c2(mb1e3ed3c(r4), this.f4734ade7));
    }

    public static readonly /* synthetic */ p55f8d305.pffe42ac4 m4005e944(p25b01efc r0, p55f8d305.p5d3072af r1) {
        return r0.m0f036448(r1);
    }

    private readonly long Mb1e3ed3c(p55f8d305.p5d3072af r1) {
        if (r1 is null) goto L14;
        p9ded6185 r0 = r1.getReceipt();
        if (r0 is null) goto L14;
        DateTime r02 = r0.getCreationDateTime();
        if (r02 is null) goto L14;
        return r02.getTime();
    L14:
        return p8cf10d23.m97bc592b().getMillis();
    }

    private readonly pd031d465 Mc2f0e740(List<pd031d465> r2, string r3) {
        IEnumerator<T> r1 = r2.GetEnumerator();
    L3:
        if (r1.MoveNext() == false) goto L14;
        object r22 = r1.Current;
        if (Intrinsics.areEqual(((pd031d465) r22).getCommodityId(), r3) == false) goto L3;
    L18:
        return (pd031d465) r22;
    L14:
        r22 = null;
        goto L18
    }

    public static readonly /* synthetic */ long md74a2a07(p25b01efc r0, p55f8d305.p5d3072af r1) {
        return r0.mb1e3ed3c(r1);
    }

    private readonly pd031d465 Md9a5e19b(List<pd031d465> r2, string r3) {
        IEnumerator<T> r1 = r2.GetEnumerator();
    L19:
        if (r1.MoveNext() == false) goto L7;
        object r22 = r1.Current;
        if (Intrinsics.areEqual(((pd031d465) r22).getUuid(), r3) == false) goto L19;
    L14:
        return (pd031d465) r22;
    L7:
        r22 = null;
        goto L14
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object AddPositionToPayback(pd031d465 r1, Continuation<Unit> r2) {
        object r0 = this.f78129a46.addPositionToPayback(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L13;
        return r0;
    L13:
        return Unit.INSTANCE;
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object AddPositionToReceipt(pd031d465 r10, Continuation<Unit> r11) {
        if (((29 + 12) % 12) > 0) goto L44;
    L44:
        if ((r11 is p25b01efc$p234facb0$1) == false) goto L169;
        p25b01efc$p234facb0$1 r0 = (p25b01efc$p234facb0$1) r11;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L169;
        r0.fd304ba20 -= int.MIN_VALUE;
    L21:
        object r112 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L98;
        if (r2 == 1) goto L123;
        if (r2 == 2) goto L182;
        if (r2 == 3) goto L162;
        if (r2 == 4) goto L136;
        if (r2 != 5) goto L69;
        ResultKt.throwOnFailure(r112);
    L129:
        return Unit.INSTANCE;
    L69:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L136:
        ResultKt.throwOnFailure(r112);
    L99:
        return Unit.INSTANCE;
    L162:
        List<pd031d465> r9 = (List) r0.L$2;
        r10 = (pd031d465) r0.L$1;
        p25b01efc r22 = (p25b01efc) r0.L$0;
        ResultKt.throwOnFailure(r112);
    L79:
        if (r112 != p22820a6f.f480d47bf) goto L60;
        List<pd031d465> r113 = r9;
    L67:
        pd031d465 r92 = r22.getPositionWithoutMarkByNotNullCommodityId(r113, r10);
        if (r92 is null) goto L93;
        r0.L$0 = null;
        r0.L$1 = null;
        r0.L$2 = null;
        r0.fd304ba20 = 4;
        if (r22.increasePositionQuantity(r92, r10, r0) != r1) goto L99;
    L77:
        return r1;
    L93:
        r0.L$0 = null;
        r0.L$1 = null;
        r0.L$2 = null;
        r0.fd304ba20 = 5;
        if (r22.addPositionToPayback(r10, r0) == r1) goto L77;
    L60:
        throw new Exception("cannot add this position");
    L182:
        List<pd031d465> r93 = (List) r0.L$2;
        r10 = (pd031d465) r0.L$1;
        r22 = (p25b01efc) r0.L$0;
        ResultKt.throwOnFailure(r112);
    L174:
        r113 = (List) r112;
        if (r22.mc2f0e740(r93, r10.getCommodityId()) is not null) goto L67;
        r0.L$0 = r22;
        r0.L$1 = r10;
        r0.L$2 = r113;
        r0.fd304ba20 = 3;
        object r94 = r22.getPaybackReceiptType(r0);
        if (r94 == r1) goto L77;
        r112 = r94;
        r9 = r113;
        goto L79
    L123:
        r10 = (pd031d465) r0.L$1;
        p25b01efc this = (p25b01efc) r0.L$0;
        ResultKt.throwOnFailure(r112);
    L173:
        List<pd031d465> r114 = (List) r112;
        r0.L$0 = this;
        r0.L$1 = r10;
        r0.L$2 = r114;
        r0.fd304ba20 = 2;
        object r23 = this.getPaybackPositions(r0);
        if (r23 == r1) goto L77;
        r22 = this;
        r93 = r114;
        r112 = r23;
        goto L174
    L98:
        ResultKt.throwOnFailure(r112);
        r0.L$0 = this;
        r0.L$1 = r10;
        r0.fd304ba20 = 1;
        r112 = getPositionsForPaybackReceipt(r0);
        if (r112 == r1) goto L77;
    L169:
        r0 = new p25b01efc$p234facb0$1(this, r11);
        goto L21
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object CheckDuplicateReceipt(string r1, Continuation<Unit> r2) {
        object r0 = this.f78129a46.checkDuplicateReceipt(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L3;
        return r0;
    L3:
        return Unit.INSTANCE;
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object ClearPaybackPositions(Continuation<Unit> r1) {
        object r0 = this.f78129a46.clearPaybackPositions(r1);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L8;
        return r0;
    L8:
        return Unit.INSTANCE;
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object CreatePaybackReceipt(ped663a3e r9, Continuation<Unit> r10) {
        if (((9 + 23) % 23) > 0) goto L17;
    L17:
        if ((r10 is p25b01efc$p63023f38$1) == false) goto L57;
        p25b01efc$p63023f38$1 r0 = (p25b01efc$p63023f38$1) r10;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L57;
        r0.fd304ba20 -= int.MIN_VALUE;
    L47:
        p25b01efc$p63023f38$1 r6 = r0;
        object r102 = r6.fb4a88417;
        object r02 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = r6.fd304ba20;
        if (r1 == 0) goto L21;
        if (r1 == 1) goto L106;
        if (r1 != 2) goto L40;
        ResultKt.throwOnFailure(r102);
    L83:
        return Unit.INSTANCE;
    L40:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L106:
        r9 = (ped663a3e) r6.L$2;
        p24ddebba r8 = (p24ddebba) r6.L$1;
        p25b01efc r12 = (p25b01efc) r6.L$0;
        ResultKt.throwOnFailure(r102);
        p24ddebba r13 = r8;
        p25b01efc this = r12;
    L26:
        string r3 = ((pf8c8b903) r102).getId();
        string r4 = this.fbbcec403.getPaymentPlace();
        string r5 = this.fbbcec403.getPaymentAddress();
        r6.L$0 = null;
        r6.L$1 = null;
        r6.L$2 = null;
        r6.fd304ba20 = 2;
        if (r13.createPaybackReceipt(r9, r3, r4, r5, r6) != r02) goto L83;
    L104:
        return r02;
    L21:
        ResultKt.throwOnFailure(r102);
        p24ddebba r103 = this.f78129a46;
        p0c2c0436 r14 = this.fedc5f59e;
        r6.L$0 = this;
        r6.L$1 = r103;
        r6.L$2 = r9;
        r6.fd304ba20 = 1;
        object r15 = r14.getSelectedEmployee(r6);
        if (r15 == r02) goto L104;
        r13 = r103;
        r102 = r15;
    L57:
        r0 = new p25b01efc$p63023f38$1(this, r10);
        goto L47
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object GetActualPositionGuid(p4cc9492b.pca87b160 r5, Continuation<string> r6) {
        if (((6 + 5) % 5) > 0) goto L59;
    L59:
        if ((r6 is p25b01efc$pb3235f6f$1) == true) goto L27;
    L89:
        p25b01efc$pb3235f6f$1 r0 = new p25b01efc$pb3235f6f$1(this, r6);
    L77:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L25;
        if (r2 != 1) goto L67;
        r5 = (p4cc9492b.pca87b160) r0.L$0;
        ResultKt.throwOnFailure(r62);
    L86:
        IEnumerator r4 = ((IEnumerable) r62).GetEnumerator();
    L64:
        if (r4.MoveNext() == false) goto L84;
        pd031d465 r63 = (pd031d465) r4.Current;
        if (r63.getCommodityId() is null) goto L64;
        if (Intrinsics.areEqual(r63.getCommodityId(), r5.getId()) == false) goto L64;
        return r63.getUuid();
    L84:
        string r42 = Guid.randomGuid().tostring();
        Intrinsics.checkNotNullExpressionValue(r42, "tostring(...)");
        return r42;
    L67:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L25:
        ResultKt.throwOnFailure(r62);
        r0.L$0 = r5;
        r0.fd304ba20 = 1;
        r62 = getPositionsForPaybackReceipt(r0);
        if (r62 != r1) goto L86;
        return r1;
    L27:
        r0 = (p25b01efc$pb3235f6f$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L89;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L77
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object GetCurrentPaybackReceipt(Continuation<p18cf5223> r1) {
        return this.f78129a46.getCurrentPaybackReceipt(r1);
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object GetNotePaybackReceipt(Continuation<string> r1) {
        return this.f78129a46.getNotePaybackReceipt(r1);
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public Flow<PagingData<p55f8d305>> GetPagedSellReceipts() {
        if (((11 + 17) % 17) > 0) goto L16;
    L16:
        return new p25b01efc$p40c04a1c$pd41d8cd9$pec404527$p1d78dc8e$1(this.f78129a46.getPagedSellReceipts(), this);
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object GetPaybackPositions(Continuation<? super List<pd031d465>> r1) {
        return this.f78129a46.getPaybackPositions(r1);
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object GetPaybackReceiptNumber(Continuation<int> r1) {
        return this.f78129a46.getPaybackReceiptNumber(r1);
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object GetPaybackReceiptType(Continuation<p22820a6f> r1) {
        return this.f78129a46.getPaybackReceiptType(r1);
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object GetPaybackReceiptsBySellReceiptUuid(string r1, Continuation<? super List<p18cf5223>> r2) {
        return this.f78129a46.getPaybackReceiptsBySellReceiptUuid(r1, r2);
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public pd031d465 GetPositionWithoutMarkByNotNullCommodityId(List<pd031d465> r4, pd031d465 r5) {
        if (((1 + 9) % 9) > 0) goto L31;
    L31:
        Intrinsics.checkNotNullParameter(r4, "positions");
        Intrinsics.checkNotNullParameter(r5, "position");
        IEnumerator<T> r3 = r4.GetEnumerator();
    L39:
        if (r3.MoveNext() == false) goto L52;
        object r42 = r3.Current;
        pd031d465 r0 = (pd031d465) r42;
        if (r5.getCommodityId() is null) goto L39;
        if (r0.getCommodityId() is null) goto L39;
        if (Intrinsics.areEqual(r5.getCommodityId(), r0.getCommodityId()) == false) goto L39;
        if (Intrinsics.areEqual(r5.getPrice(), r0.getPrice()) == false) goto L39;
        if (Intrinsics.areEqual(r5.getPriceWithDiscount(), r0.getPriceWithDiscount()) == false) goto L39;
    L44:
        return (pd031d465) r42;
    L52:
        r42 = null;
        goto L44
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object GetPositionsForPaybackByQuery(string r1, string r2, Continuation<? super List<pd031d465>> r3) {
        return this.f78129a46.getPositionsForPaybackByQuery(r1, r2, r3);
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object GetPositionsForPaybackFromDb(string r1, Continuation<? super List<pd031d465>> r2) {
        return this.f78129a46.getPositionsForPaybackFromDb(r1, r2);
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object GetPositionsForPaybackReceipt(Continuation<? super List<pd031d465>> r1) {
        return this.f78129a46.getPositionsForPaybackReceipt(r1);
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object GetQuantityPaybackPositionByUuid(string r5, Continuation<decimal> r6) {
        if (((6 + 11) % 11) > 0) goto L63;
    L63:
        if ((r6 is p25b01efc$p1cd5d06c$1) == false) goto L83;
        p25b01efc$p1cd5d06c$1 r0 = (p25b01efc$p1cd5d06c$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L83;
        r0.fd304ba20 -= int.MIN_VALUE;
    L85:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L17;
        if (r2 == 1) goto L19;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L19:
        p25b01efc this = (p25b01efc) r0.L$1;
        r5 = (string) r0.L$0;
        ResultKt.throwOnFailure(r62);
    L53:
        pd031d465 r4 = this.md9a5e19b((List) r62, r5);
        if (r4 is not null) goto L14;
    L59:
        decimal r42 = decimal.ZERO;
        Intrinsics.checkNotNullExpressionValue(r42, "ZERO");
        return r42;
    L14:
        decimal r43 = r4.getQuantity();
        if (r43 is null) goto L59;
        return r43;
    L17:
        ResultKt.throwOnFailure(r62);
        r0.L$0 = r5;
        r0.L$1 = this;
        r0.fd304ba20 = 1;
        r62 = getPaybackPositions(r0);
        if (r62 != r1) goto L53;
        return r1;
    L83:
        r0 = new p25b01efc$p1cd5d06c$1(this, r6);
        goto L85
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object GetQuantityPositionForPaybackByUuid(string r5, Continuation<decimal> r6) {
        if (((28 + 18) % 18) > 0) goto L3;
    L3:
        if ((r6 is p25b01efc$pda47ef8a$1) == false) goto L64;
        p25b01efc$pda47ef8a$1 r0 = (p25b01efc$pda47ef8a$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L64;
        r0.fd304ba20 -= int.MIN_VALUE;
    L20:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L35;
        ResultKt.throwOnFailure(r62);
        r0.L$0 = r5;
        r0.L$1 = this;
        r0.fd304ba20 = 1;
        r62 = getPositionsForPaybackReceipt(r0);
        if (r62 != r1) goto L77;
        return r1;
    L77:
        pd031d465 r4 = this.md9a5e19b((List) r62, r5);
        if (r4 is not null) goto L31;
    L54:
        decimal r42 = decimal.ZERO;
        Intrinsics.checkNotNullExpressionValue(r42, "ZERO");
        return r42;
    L31:
        decimal r43 = r4.getQuantity();
        if (r43 is null) goto L54;
        return r43;
    L35:
        if (r2 != 1) goto L15;
        p25b01efc this = (p25b01efc) r0.L$1;
        r5 = (string) r0.L$0;
        ResultKt.throwOnFailure(r62);
        goto L77
    L15:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L64:
        r0 = new p25b01efc$pda47ef8a$1(this, r6);
        goto L20
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object GetSellReceiptForPayback(string r1, Continuation<ped663a3e> r2) {
        return this.f78129a46.getSellReceipt(r1, r2);
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object GetShouldPrintReceipt(Continuation<bool> r1) {
        return this.f78129a46.getShouldPrintReceipt(r1);
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object IncreasePositionQuantity(pd031d465 r1, pd031d465 r2, Continuation<Unit> r3) {
        object r0 = this.f78129a46.increasePositionQuantity(r1, r2, r3);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L11;
        return r0;
    L11:
        return Unit.INSTANCE;
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public bool IsAnimationNotePreviewShown() {
        bool r0 = this.f97e1f910.getAnimationPreview().getPaybackNoteReceiptAnimation();
        if (r0 is not null) goto L7;
        return false;
    L7:
        return r0.boolValue();
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public bool IsAnimationPreviewShown() {
        bool r0 = this.f97e1f910.getAnimationPreview().getPaybackPositionAnimation();
        if (r0 is not null) goto L12;
        return false;
    L12:
        return r0.boolValue();
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object OpenSinglePaymentIfNeeded(Continuation<Unit> r1) {
        object r0 = this.f78129a46.openSinglePaymentIfNeeded(r1);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L11;
        return r0;
    L11:
        return Unit.INSTANCE;
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object RemoveCurrentPaybackReceipt(Continuation<Unit> r1) {
        object r0 = this.f78129a46.removeCurrentReceipt(r1);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L7;
        return r0;
    L7:
        return Unit.INSTANCE;
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object RemovePositionFromPayback(pd031d465 r1, Continuation<Unit> r2) {
        object r0 = this.f78129a46.removePositionFromPayback(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L11;
        return r0;
    L11:
        return Unit.INSTANCE;
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object ReplacePosition(pd031d465 r1, Continuation<Unit> r2) {
        object r0 = this.f78129a46.replacePosition(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L15;
        return r0;
    L15:
        return Unit.INSTANCE;
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public void SetAnimationNotePreviewIsShown() {
        if (((26 + 12) % 12) > 0) goto L8;
    L8:
        pd4ccf9ff r1 = this.f97e1f910.getAnimationPreview();
        this.f97e1f910.setAnimationPreview(pd4ccf9ff.m1c1e012b(r1, null, null, null, null, null, true, 31, null));
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public void SetAnimationPreviewIsShown() {
        if (((28 + 13) % 13) > 0) goto L28;
    L28:
        pd4ccf9ff r1 = this.f97e1f910.getAnimationPreview();
        this.f97e1f910.setAnimationPreview(pd4ccf9ff.m1c1e012b(r1, null, true, null, null, null, null, 61, null));
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object SetNotePaybackReceipt(string r1, Continuation<Unit> r2) {
        object r0 = this.f78129a46.setNotePaybackReceipt(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L7;
        return r0;
    L7:
        return Unit.INSTANCE;
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object SetPaymentAddress(string r1, Continuation<Unit> r2) {
        object r0 = this.f78129a46.setPaymentAddress(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L3;
        return r0;
    L3:
        return Unit.INSTANCE;
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object SetPaymentPlace(string r1, Continuation<Unit> r2) {
        object r0 = this.f78129a46.setPaymentPlace(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L11;
        return r0;
    L11:
        return Unit.INSTANCE;
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object SetPaymentType(p8c261c90 r1, Continuation<Unit> r2) {
        object r0 = this.f78129a46.setPaymentType(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L5;
        return r0;
    L5:
        return Unit.INSTANCE;
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object SetReceiptClientEmail(string r1, Continuation<Unit> r2) {
        object r0 = this.f78129a46.setReceiptClientEmail(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L9;
        return r0;
    L9:
        return Unit.INSTANCE;
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object SetReceiptClientPhone(string r1, Continuation<Unit> r2) {
        object r0 = this.f78129a46.setReceiptClientPhone(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L14;
        return r0;
    L14:
        return Unit.INSTANCE;
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object SetShouldPrintReceipt(bool r1, Continuation<Unit> r2) {
        object r0 = this.f78129a46.setShouldPrintReceipt(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L12;
        return r0;
    L12:
        return Unit.INSTANCE;
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object SetTransactionToFirstPayment(pf8872840 r1, Continuation<Unit> r2) {
        object r0 = this.f78129a46.setTransactionToFirstPayment(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L7;
        return r0;
    L7:
        return Unit.INSTANCE;
    }

    @Override // p4670093c.pac143fb7.pa36ef9b5
    public object UpdateReceiptDiscount(Continuation<Unit> r6) {
        if (((23 + 9) % 9) > 0) goto L61;
    L61:
        if ((r6 is p25b01efc$p78ee09c3$1) == true) goto L79;
    L30:
        p25b01efc$p78ee09c3$1 r0 = new p25b01efc$p78ee09c3$1(this, r6);
    L33:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L42;
        ResultKt.throwOnFailure(r62);
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r62 = getCurrentPaybackReceipt(r0);
        if (r62 != r1) goto L35;
    L74:
        return r1;
    L35:
        decimal r63 = p517b902b.mb09bae89((p18cf5223) r62);
        if (r63 is null) goto L85;
        p24ddebba r5 = this.f78129a46;
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        if (r5.updateReceiptDiscount(r63, r0) == r1) goto L74;
    L85:
        return Unit.INSTANCE;
    L42:
        if (r2 == 1) goto L15;
        if (r2 != 2) goto L40;
        ResultKt.throwOnFailure(r62);
        goto L85
    L40:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L15:
        p25b01efc this = (p25b01efc) r0.L$0;
        ResultKt.throwOnFailure(r62);
        goto L35
    L79:
        r0 = (p25b01efc$p78ee09c3$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L30;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L33
    }
}

