using Androidx.Lifecycle;
using Com.Decryptstringmanager;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using P2b3583e6.P4a931512;
using P4d236d9a.P2df4812c.Pf5d7e253.P705f8913.P518a4861.P7a1eabc3.P86ccec3d;
using P7a1eabc3.P07214c67.P20f35e63;
using P7a1eabc3.P68c4283d;
using P7a1eabc3.Pac143fb7;
using P7a1eabc3.Pfd9160bb;
using Pad5f82e8.P07214c67;
using Pad5f82e8.P07214c67.P7a1eabc3;
using Pad5f82e8.P07214c67.Pe907423b;
using Pad5f82e8.P07214c67.Pfd9160bb;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes3.dex */
readonly class p9c0abf93$pfffd883b$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ p4cc9492b.pca87b160 $actualInventoryItem;
    readonly /* synthetic */ p4cc9492b.pca87b160 $inventoryItem;
    int f15b46c7c;
    int fd304ba20;
    readonly /* synthetic */ p9c0abf93 this$0;

    public /* synthetic */ class p12c674ac {
        public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$0 = null;

        static {
            if (((28 + 11) % 11) > 0) goto L9;
        L9:
            int[] r0 = new int[LNGrJamUaZAsJgBI().length];
            r0[YJuktPuXNzOhPAJT(p17096304.f78d79da2)] = 1;     // Catch: NoSuchFieldError -> L25
        L24:
            $EnumSwitchDictionaryping$0 = r0;
        }

        public static p17096304[] LNGrJamUaZAsJgBI() {
            return p17096304.Values;
        }

        public static int YJuktPuXNzOhPAJT(p17096304 r1) {
            return r1.ordinal();
        }
    }

    p9c0abf93$pfffd883b$1(p9c0abf93 r1, p4cc9492b.pca87b160 r2, p4cc9492b.pca87b160 r3, Continuation<? super p9c0abf93$pfffd883b$1> r4) {
        this.this$0 = r1;
        this.$actualInventoryItem = r2;
        this.$inventoryItem = r3;
        super(2, r4);
    }

    public static p2e423cc6 AXbpFDtJFBKgMqCk(p9c0abf93 r1) {
        return p9c0abf93.m5fb81a65(r1);
    }

    public static void BoVypbwIjBXJHUZv(p271354e4 r0, string r1, string r2) {
        r0.reportCreateInventoryEvent(r1, r2);
    }

    public static string BzTrqWmJCCtaJhao(p4cc9492b.pca87b160 r1) {
        return r1.getCode();
    }

    public static p2e423cc6 EfSkAxpzfUJhxgdF(p9c0abf93 r1) {
        return p9c0abf93.m5fb81a65(r1);
    }

    public static p2e423cc6 FpsqVmmdnLattreT(p9c0abf93 r1) {
        return p9c0abf93.m5fb81a65(r1);
    }

    public static string GEaUYGxmWNDHNRxV(pa1fa2777 r1) {
        return r1.name();
    }

    public static void HYWQVjVETqlCtszQ(p271354e4 r0, string r1, string r2) {
        r0.reportEditInventoryEvent(r1, r2);
    }

    public static p17096304 HbVvUWhbtylkYjEM(p9c0abf93 r1) {
        return r1.getStartInventoryRoute();
    }

    public static string IIiIDJznHfltWevH(p4cc9492b.pca87b160 r1) {
        return r1.getCode();
    }

    public static pa4ecfc70 LRBcLrrSAAIsdfjd(pa4ecfc70.p910eef8c r1, object r2, int r3, object r4) {
        return pa4ecfc70.p910eef8c.m02f94ccf(r1, r2, r3, r4);
    }

    public static int LSMUOOggioqLkpck(p17096304 r1) {
        return r1.ordinal();
    }

    public static string LqZtMiMWwgWTTEnb(p2e423cc6 r1, int r2) {
        return r1.getstring(r2);
    }

    public static p271354e4 MfoPSNDAlaAwLKaj(p9c0abf93 r1) {
        return p9c0abf93.m8aa7c174(r1);
    }

    public static p271354e4 MgagbfHduCPaexcc(p9c0abf93 r1) {
        return p9c0abf93.m8aa7c174(r1);
    }

    public static string MliPMArVLeDnfovv(pa1fa2777 r1) {
        return r1.name();
    }

    public static object MlmwdLhPGTjQEyYn(p9c0abf93$pfffd883b$1 r1, CoroutineScope r2, Continuation r3) {
        return r1.invoke2(r2, r3);
    }

    public static void NMDdATBXQMOfLVtp(MutableLiveData r0, object r1) {
        r0.postValue(r1);
    }

    public static string NVBfSWVaCzYevYNp(object r1) {
        return string.valueOf(r1);
    }

    public static void PAwnqglbnbkIKzJF(p9c0abf93 r0) {
        p9c0abf93.m6db3d3e2(r0);
    }

    public static MutableLiveData PqENZadyfnQVqXdk(p9c0abf93 r1) {
        return p9c0abf93.m8541c3e8(r1);
    }

    public static string QATFRayEViOlpCrY(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static MutableLiveData QdddfijtNbYhcXyN(p9c0abf93 r1) {
        return p9c0abf93.m8541c3e8(r1);
    }

    public static pa1fa2777 QulHvlouzcKTRmEl(p4cc9492b.pca87b160 r1) {
        return r1.getType();
    }

    public static pa4ecfc70 RkXClitTOtFRfknT(pa4ecfc70.p910eef8c r1) {
        return r1.loading();
    }

    public static void SGDGcDIDHIGvzXgL(p271354e4 r0, string r1, string r2) {
        r0.reportCreateInventoryEvent(r1, r2);
    }

    public static void SYmVDoXRiWRrSZrQ(MutableLiveData r0, object r1) {
        r0.setValue(r1);
    }

    public static MutableLiveData TzMupUfIJtvRqcee(p9c0abf93 r1) {
        return p9c0abf93.m79e7eef2(r1);
    }

    public static string VYZCKlmjynwodbMk(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static void VmKmfAuspJdIIHLm(MutableLiveData r0, object r1) {
        r0.postValue(r1);
    }

    public static MutableLiveData WXAmAAwXjOwhKDFM(p9c0abf93 r1) {
        return p9c0abf93.m8541c3e8(r1);
    }

    public static void WmNwyagxlRElSqBM(MutableLiveData r0, object r1) {
        r0.setValue(r1);
    }

    public static p271354e4 YvWRERlNowfKwitn(p9c0abf93 r1) {
        return p9c0abf93.m8aa7c174(r1);
    }

    public static string AVNqhBFjFpWhDdQr(p2e423cc6 r1, int r2) {
        return r1.getstring(r2);
    }

    public static p6d73504b CrSFeJrdVOkgdHae(p9c0abf93 r1) {
        return p9c0abf93.m0234406d(r1);
    }

    public static pa4ecfc70 CxdlrdwQOisYWZox(pa4ecfc70.p910eef8c r1, Exception r2) {
        return r1.error(r2);
    }

    public static void EdtPUfmhhqQgALkh(p9c0abf93 r0) {
        r0.openPreviousScreen();
    }

    public static string FDBAVOlSdSJucVuQ(object r1) {
        return string.valueOf(r1);
    }

    public static MutableLiveData FcWLXlTcQpevNDWE(p9c0abf93 r1) {
        return p9c0abf93.m79e7eef2(r1);
    }

    public static pa1fa2777 FtgqIytnhIFqjWPT(p4cc9492b.pca87b160 r1) {
        return r1.getType();
    }

    public static void FwKwcoUGPYLYlXjp(MutableLiveData r0, object r1) {
        r0.postValue(r1);
    }

    public static string ILvhYOOFtqtJGssB(object r1) {
        return string.valueOf(r1);
    }

    public static void KNoofuYhUTqPnaUz(MutableLiveData r0, object r1) {
        r0.setValue(r1);
    }

    public static void KoVsLEIpdmMSYzHG(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object LGATJKmAHDDCjJdM(p9c0abf93$pfffd883b$1 r1, object r2) {
        return r1.invokeSuspend(r2);
    }

    public static string MNeqGFyZZDerGfeF(string r1) {
        return Decryptstring.decryptstring(r1);
    }

    public static object MccrswmGXUUpvJLR() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void NmFuBlkNqFFGyYXZ(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string OqMkGsxSLIVhfgHB(p2e423cc6 r1, int r2) {
        return r1.getstring(r2);
    }

    public static string OvNGaWUeErUItNjr(pa1fa2777 r1) {
        return r1.name();
    }

    public static MutableLiveData RXLGydBRBOKMnlFQ(p9c0abf93 r1) {
        return p9c0abf93.m79e7eef2(r1);
    }

    public static object SekUsujCUTmPXJJh(p9c0abf93 r1, p4cc9492b.pca87b160 r2, Continuation r3) {
        return p9c0abf93.m33548da6(r1, r2, r3);
    }

    public static void TtfoRplmfZcLdURi(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static string WBEWtUozYJPSGiKP(p2e423cc6 r1, int r2) {
        return r1.getstring(r2);
    }

    public static object WJZvsvckaaOeUaYD(p6d73504b r1, p4cc9492b.pca87b160 r2, Continuation r3) {
        return r1.editInventory(r2, r3);
    }

    public static pa1fa2777 XPulfYYofPBQeCvM(p4cc9492b.pca87b160 r1) {
        return r1.getType();
    }

    public static Continuation XQPjFhyguczweevR(p9c0abf93$pfffd883b$1 r1, object r2, Continuation r3) {
        return r1.create(r2, r3);
    }

    public static p2e423cc6 XbtMwplSpuXsPhaN(p9c0abf93 r1) {
        return p9c0abf93.m5fb81a65(r1);
    }

    public static p939f9656 YFdtLxWGFlOcFgBL(p9c0abf93 r1) {
        return p9c0abf93.m74e3994c(r1);
    }

    public static void ZTedDyqllPAfFLVd(p939f9656 r0, string r1, object r2) {
        r0.sendResult(r1, r2);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r3, Continuation<object> r4) {
        if (((5 + 17) % 17) > 0) goto L14;
    L14:
        return new p9c0abf93$pfffd883b$1(this.this$0, this.$actualInventoryItem, this.$inventoryItem, r4);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return MlmwdLhPGTjQEyYn(this, r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return lGATJKmAHDDCjJdM((p9c0abf93$pfffd883b$1) xQPjFhyguczweevR(this, r1, r2), Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r10) {
        if (((29 + 27) % 27) > 0) goto L94;
    L94:
        object r0 = mccrswmGXUUpvJLR();
        int r1 = this.fd304ba20;
        string r4 = null;
        if (r1 == 0) goto L43;
        if (r1 != 1) goto L114;
        ttfoRplmfZcLdURi(r10);     // Catch: Exception -> L34
    L90:
        fwKwcoUGPYLYlXjp(PqENZadyfnQVqXdk(this.this$0), LRBcLrrSAAIsdfjd(pa4ecfc70.f910eef8c, null, 1, null));     // Catch: Exception -> L34
        string r102 = BzTrqWmJCCtaJhao(this.$inventoryItem);     // Catch: Exception -> L34
        string r12 = QATFRayEViOlpCrY("33561e8e0b1ad2a529857834bb1ffbcc16fec480429824ad11190815e00e1e416bd4f5");
        if (r102 is null) goto L10;
        SYmVDoXRiWRrSZrQ(fcWLXlTcQpevNDWE(this.this$0), new p325296ab(aVNqhBFjFpWhDdQr(AXbpFDtJFBKgMqCk(this.this$0), C2843R.string.inventory_snack_edit_success)));     // Catch: Exception -> L34
        p271354e4 r103 = YvWRERlNowfKwitn(this.this$0);     // Catch: Exception -> L34
        pa1fa2777 r02 = xPulfYYofPBQeCvM(this.$actualInventoryItem);     // Catch: Exception -> L34
        if (r02 is null) goto L8;
        string r03 = MliPMArVLeDnfovv(r02);     // Catch: Exception -> L34
    L9:
        HYWQVjVETqlCtszQ(r103, r12, fDBAVOlSdSJucVuQ(r03));     // Catch: Exception -> L34
        edtPUfmhhqQgALkh(this.this$0);     // Catch: Exception -> L34
    L61:
        return Unit.INSTANCE;
    L8:
        r03 = null;
        goto L9
    L10:
        zTedDyqllPAfFLVd(yFdtLxWGFlOcFgBL(this.this$0), mNeqGFyZZDerGfeF("9bcdaabb6ef5143e69d94b29f5b7fe32699f249b93558f94144918092dffb0cdc1c982ec6b201e16c22ef851ad"), new p325296ab(LqZtMiMWwgWTTEnb(EfSkAxpzfUJhxgdF(this.this$0), C2843R.string.inventory_snack_commodity_add_success)));     // Catch: Exception -> L34
        p271354e4 r104 = MfoPSNDAlaAwLKaj(this.this$0);     // Catch: Exception -> L34
        pa1fa2777 r5 = QulHvlouzcKTRmEl(this.$actualInventoryItem);     // Catch: Exception -> L34
        if (r5 is null) goto L13;
        string r52 = ovNGaWUeErUItNjr(r5);     // Catch: Exception -> L34
    L14:
        BoVypbwIjBXJHUZv(r104, r12, NVBfSWVaCzYevYNp(r52));     // Catch: Exception -> L34
        p17096304 r105 = HbVvUWhbtylkYjEM(this.this$0);     // Catch: Exception -> L34
        if (r105 is not null) goto L17;
        int r106 = -1;
    L18:
        if (r106 != 1) goto L22;
        this.fd304ba20 = 2;     // Catch: Exception -> L34
        if (sekUsujCUTmPXJJh(this.this$0, this.$actualInventoryItem, this) != r0) goto L61;
    L21:
        return r0;
    L22:
        PAwnqglbnbkIKzJF(this.this$0);     // Catch: Exception -> L34
        goto L61
    L17:
        r106 = p12c674ac.$EnumSwitchDictionaryping$0[LSMUOOggioqLkpck(r105)];     // Catch: Exception -> L34
        goto L18
    L13:
        r52 = null;
        goto L14
    L114:
        if (r1 != 2) goto L125;
        koVsLEIpdmMSYzHG(r10);     // Catch: Exception -> L34
        goto L61
    L125:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L43:
        nmFuBlkNqFFGyYXZ(r10);
        VmKmfAuspJdIIHLm(QdddfijtNbYhcXyN(this.this$0), RkXClitTOtFRfknT(pa4ecfc70.f910eef8c));
        this.fd304ba20 = 1;     // Catch: Exception -> L34
        if (wJZvsvckaaOeUaYD(crSFeJrdVOkgdHae(this.this$0), this.$actualInventoryItem, this) != r0) goto L90;
    L34:
        e = move-exception;
        NMDdATBXQMOfLVtp(WXAmAAwXjOwhKDFM(this.this$0), cxdlrdwQOisYWZox(pa4ecfc70.f910eef8c, e));
        if (IIiIDJznHfltWevH(this.$inventoryItem) is not null) goto L40;
        kNoofuYhUTqPnaUz(TzMupUfIJtvRqcee(this.this$0), new p37f460dd(oqMkGsxSLIVhfgHB(FpsqVmmdnLattreT(this.this$0), C2843R.string.inventory_snack_commodity_error)));
    L107:
        p271354e4 r107 = MgagbfHduCPaexcc(this.this$0);
        pa1fa2777 r9 = ftgqIytnhIFqjWPT(this.$actualInventoryItem);
        if (r9 is null) goto L102;
        r4 = GEaUYGxmWNDHNRxV(r9);
    L102:
        SGDGcDIDHIGvzXgL(r107, VYZCKlmjynwodbMk("370f718ae986e2969f596b3b165eebeb5902ab680cb025ccbc30ba75f507d8d168"), iLvhYOOFtqtJGssB(r4));
        goto L61
    L40:
        WmNwyagxlRElSqBM(rXLGydBRBOKMnlFQ(this.this$0), new p37f460dd(wBEWtUozYJPSGiKP(xbtMwplSpuXsPhaN(this.this$0), C2843R.string.inventory_snack_edit_error)));
        goto L107
    }
}

