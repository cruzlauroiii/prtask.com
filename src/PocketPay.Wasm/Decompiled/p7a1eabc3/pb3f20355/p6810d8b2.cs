using Com.Google.Android.Gms.Actions;
using Java.Util;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using Kotlin.Sequences;
using Kotlinx.Coroutines;
using P7a1eabc3.P07214c67.P20f35e63;
using P7a1eabc3.P07214c67.P20f35e63.Pe3932f88;
using P7a1eabc3.P07214c67.P20f35e63.Pec5cb3e6;
using P7a1eabc3.P07214c67.P2c18e486.Pe3932f88;
using P7a1eabc3.P07214c67.P2c18e486.Pec5cb3e6;
using P7a1eabc3.P07214c67.Pd77d5e50;
using P7a1eabc3.P4b9f83e1.Pe3932f88;
using P7a1eabc3.P4b9f83e1.Pec5cb3e6;
using P8d777f38.Pb3f20355.Pc1c16452;
using P8d777f38.Pb3f20355.Pfb216d9e;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes3.dex */
public readonly class p6810d8b2 : p8338e520 {
    private static readonly p910eef8c f05c3bceb = null;
    private static readonly p910eef8c f467daf3d = null;
    private static readonly p910eef8c f84b44acc = null;
    private static readonly p910eef8c f886baa64 = null;
    private static readonly p910eef8c f910eef8c = null;
    public static readonly long f9b34d953 = 600000;

    [System.Obsolete]
    public static readonly long fa6bc33a2 = 600000;
    public static readonly long fb4669f5b = 600000;
    private readonly CoroutineScope f1084354b;
    private Deferred<? : Sequence<p0ded097a>> f1e5eb9ce;
    private readonly pdd359ada f2463bd99;
    private readonly pdd359ada f25456276;
    private readonly p3458384a f28c631f6;
    private readonly pb512f696 f2e5f4eb4;
    private Deferred f3e7e8710;
    private readonly p776a1426 f4851948a;
    private Deferred f4891eb26;
    private readonly p6bc3404d f4f87fa57;
    private readonly pdd359ada f5db9a59f;
    private Deferred f5fae10e6;
    private readonly pdd359ada f646a5f58;
    private readonly p776a1426 f6518279b;
    private readonly pdd359ada f6f49c039;
    private readonly p776a1426 f7288c41b;
    private readonly p1632bb6a f78e07024;
    private readonly p6bc3404d f7dfe64b6;
    private readonly pda0b425a f88a0c5ab;
    private Deferred<? : Sequence<p15967156>> f88c888b8;
    private readonly CoroutineScope f9573df50;
    private readonly p1bac4649 f978a5d3a;
    private readonly p1bac4649 f9dd320ed;
    private readonly pda0b425a f9e187018;
    private readonly pb512f696 fa53eb5da;
    private readonly CoroutineScope fa8d2f9c7;
    private readonly CoroutineScope faea1feda;
    private readonly pb512f696 fb20f28b3;
    private readonly p776a1426 fb4db7637;
    private readonly CoroutineScope fbf555b39;
    private readonly CoroutineScope fc47858f4;
    private Deferred fc47d1566;
    private readonly p776a1426 fc9191d17;
    private readonly p1bac4649 fcb89d0af;
    private readonly pda0b425a fd783df43;
    private readonly p1bac4649 fdfdbbf78;
    private readonly pda0b425a fe1ec4def;
    private readonly p6bc3404d fe3db859e;
    private readonly p6bc3404d fee32dd0b;
    private readonly p1632bb6a fefd3df93;
    private readonly CoroutineScope ff32a83a1;
    private readonly p3458384a ff56a1523;
    private readonly p1632bb6a ff621c252;
    private readonly CoroutineScope ffb682c30;

    private static readonly class p910eef8c {
        private p910eef8c() {
        }

        public /* synthetic */ p910eef8c(DefaultConstructorMarker r1) {
            this();
        }
    }

    static {
        if (((31 + 1) % 1) > 0) goto L8;
    L8:
        f910eef8c = new p910eef8c(null);
    }

    public p6810d8b2(p1bac4649 r2, pb512f696 r3, pda0b425a r4, p1632bb6a r5, pdd359ada r6, p6bc3404d r7, p3458384a r8, p776a1426 r9) {
        Intrinsics.checkNotNullParameter(r2, "inventoryRemoteRepository");
        Intrinsics.checkNotNullParameter(r3, "inventoryDbRepository");
        Intrinsics.checkNotNullParameter(r4, "marketDataRepository");
        Intrinsics.checkNotNullParameter(r5, "commodityRemoteDictionaryper");
        Intrinsics.checkNotNullParameter(r6, "commodityGroupRemoteDictionaryper");
        Intrinsics.checkNotNullParameter(r7, "commodityDbDictionaryper");
        Intrinsics.checkNotNullParameter(r8, "commodityGroupDbDictionaryper");
        Intrinsics.checkNotNullParameter(r9, "localeRepository");
        this.fdfdbbf78 = r2;
        this.fb20f28b3 = r3;
        this.f88a0c5ab = r4;
        this.f78e07024 = r5;
        this.f5db9a59f = r6;
        this.f7dfe64b6 = r7;
        this.ff56a1523 = r8;
        this.f7288c41b = r9;
        this.f1084354b = CoroutineScopeKt.CoroutineScope(Dispatchers.getIO().plus(SupervisorKt.SupervisorJob$default(null, 1, null)));
        this.fc47858f4 = CoroutineScopeKt.CoroutineScope(Dispatchers.getIO().plus(JobKt.Job$default(null, 1, null)));
        this.ff32a83a1 = CoroutineScopeKt.CoroutineScope(Dispatchers.getIO().plus(JobKt.Job$default(null, 1, null)));
    }

    public static /* synthetic */ Unit m01f3019a(p6810d8b2 r0, Exception r1) {
        return m2545ad75(r0, r1);
    }

    private readonly void M0e020c86() {
        if (((25 + 27) % 27) > 0) goto L4;
    L4:
        JobKt.cancelChildren$default(this.fc47858f4.getCoroutineobject(), null, 1, null);
        BuildersKt.launch$default(this.fc47858f4, null, null, new p6810d8b2$p0e020c86$1(this, null), 3, null);
    }

    public static readonly /* synthetic */ Job m134a222c(p6810d8b2 r0) {
        return r0.mf6a5538c();
    }

    private readonly void M21db659d() {
        if (((21 + 3) % 3) > 0) goto L23;
    L23:
        JobKt.cancelChildren$default(this.ff32a83a1.getCoroutineobject(), null, 1, null);
        BuildersKt.launch$default(this.ff32a83a1, null, null, new p6810d8b2$p21db659d$1(this, null), 3, null);
    }

    private static readonly Unit M2545ad75(p6810d8b2 r0, Exception r1) {
        r0.m0e020c86();
        return Unit.INSTANCE;
    }

    private static readonly p0ded097a M275b4be0(p6810d8b2 r1, pb927a776 r2) {
        Intrinsics.checkNotNullParameter(r2, "commodityGroup");
        return r1.f5db9a59f.mapToCommodityGroupModel(r2);
    }

    private readonly Sequence<p0ded097a> M2da87222(List<pb927a776> r2) {
        return SequencesKt.map(SequencesKt.filter(ICollectionsKt.asSequence(r2), new p6810d8b2$pd41d8cd9$p144e4630()), new p6810d8b2$pd41d8cd9$p437e9676(this));
    }

    public static readonly /* synthetic */ Sequence m2eb62372(p6810d8b2 r0, List r1) {
        return r0.m2da87222(r1);
    }

    public static /* synthetic */ bool m2ff3a184(p6326cd18 r0) {
        return mfca1fdb2(r0);
    }

    private readonly object M35f6087e(Continuation<Unit> r6) {
        if (((21 + 24) % 24) > 0) goto L8;
    L8:
        if ((r6 is p6810d8b2$p35f6087e$1) == false) goto L15;
        p6810d8b2$p35f6087e$1 r0 = (p6810d8b2$p35f6087e$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L15;
        r0.fd304ba20 -= int.MIN_VALUE;
    L39:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L35;
        ResultKt.throwOnFailure(r62);
        Deferred<? : Sequence<p0ded097a>> r63 = this.f1e5eb9ce;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r62 = m786005c5(r63, r0);
        if (r62 == r1) goto L47;
    L73:
        Sequence<p0ded097a> r64 = (Sequence) r62;
        if (r64 is null) goto L83;
        List<pdf878ad9> r65 = this.ff56a1523.toCommodityGroupsDbEntity(r64);
        pb512f696 r22 = this.fb20f28b3;
        r0.L$0 = this;
        r0.fd304ba20 = 2;
        if (r22.saveCommodityGroups(r65, r0) == r1) goto L47;
    L34:
        this.m21db659d();
        this.f1e5eb9ce = null;
    L83:
        return Unit.INSTANCE;
    L47:
        return r1;
    L35:
        if (r2 == 1) goto L6;
        if (r2 == 2) goto L71;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L71:
        p6810d8b2 this = (p6810d8b2) r0.L$0;
        ResultKt.throwOnFailure(r62);
        goto L34
    L6:
        this = (p6810d8b2) r0.L$0;
        ResultKt.throwOnFailure(r62);
    L15:
        r0 = new p6810d8b2$p35f6087e$1(this, r6);
        goto L39
    }

    public static readonly /* synthetic */ Job m42c0fb16(p6810d8b2 r0) {
        return r0.ma4f537b1();
    }

    public static readonly /* synthetic */ object m45a7f2a1(p6810d8b2 r0, Continuation r1) {
        return r0.mfad8cb8f(r1);
    }

    public static readonly /* synthetic */ object m597a32e1(p6810d8b2 r0, Deferred r1, Continuation r2) {
        return r0.m786005c5(r1, r2);
    }

    private static readonly Unit M72d596bd(p6810d8b2 r0, Exception r1) {
        r0.m21db659d();
        return Unit.INSTANCE;
    }

    /* JADX WARN: Multi-variable type inference failed */
    private readonly <T> object M786005c5(Deferred<? : T> r2, Continuation<T> r3) {
        if (r2 is not null) goto L17;
        return null;
    L17:
        if (r2.isCancelled() == false) goto L15;
        return null;
    L15:
        return r2.await(r3);
    }

    public static readonly /* synthetic */ p1bac4649 m84ad04bd(p6810d8b2 r0) {
        return r0.fdfdbbf78;
    }

    private readonly Sequence<p15967156> M8620ef84(List<p6326cd18> r2) {
        return SequencesKt.map(SequencesKt.filter(ICollectionsKt.asSequence(r2), new p6810d8b2$pd41d8cd9$p00f53dc7()), new p6810d8b2$pd41d8cd9$p3f7145ba(this));
    }

    private static readonly bool M993ab3df(pb927a776 r1) {
        Intrinsics.checkNotNullParameter(r1, "commodityGroup");
        if (r1.getName() is not null) goto L9;
        return false;
    L9:
        return true;
    }

    private static readonly p15967156 Ma11534ba(p6810d8b2 r1, p6326cd18 r2) {
        Intrinsics.checkNotNullParameter(r2, "commodity");
        return r1.f78e07024.mapToCommodityModel(r2);
    }

    private readonly Job Ma4f537b1() {
        if (((24 + 6) % 6) > 0) goto L22;
    L22:
        Deferred<? : Sequence<p0ded097a>> r0 = this.f1e5eb9ce;
        return BuildersKt.launch$default(this.f1084354b, new p6810d8b2$pa4f537b1$pd41d8cd9$pec404527$p33626a5b$1(CoroutineExceptionHandler.Key, this, r0), null, new p6810d8b2$pa4f537b1$2(this, null), 2, null);
    }

    public static /* synthetic */ Unit mcb1c577f(p6810d8b2 r0, Exception r1) {
        return m72d596bd(r0, r1);
    }

    public static readonly /* synthetic */ void md2470313(p6810d8b2 r0, Deferred r1) {
        r0.f88c888b8 = r1;
    }

    public static readonly /* synthetic */ Sequence mda1b8581(p6810d8b2 r0, List r1) {
        return r0.m8620ef84(r1);
    }

    public static readonly /* synthetic */ object me7e4058a(p6810d8b2 r0, Continuation r1) {
        return r0.m35f6087e(r1);
    }

    public static /* synthetic */ p15967156 me8f9d720(p6810d8b2 r0, p6326cd18 r1) {
        return ma11534ba(r0, r1);
    }

    public static /* synthetic */ p0ded097a meb250b00(p6810d8b2 r0, pb927a776 r1) {
        return m275b4be0(r0, r1);
    }

    private readonly Job Mf6a5538c() {
        if (((29 + 15) % 15) > 0) goto L12;
    L12:
        Deferred<? : Sequence<p15967156>> r0 = this.f88c888b8;
        return BuildersKt.launch$default(this.f1084354b, new p6810d8b2$pf6a5538c$pd41d8cd9$pec404527$p33626a5b$1(CoroutineExceptionHandler.Key, this, r0), null, new p6810d8b2$pf6a5538c$2(this, null), 2, null);
    }

    public static readonly /* synthetic */ void mf8be56e1(p6810d8b2 r0, Deferred r1) {
        r0.f1e5eb9ce = r1;
    }

    private readonly object Mfad8cb8f(Continuation<Unit> r6) {
        if (((26 + 31) % 31) > 0) goto L48;
    L48:
        if ((r6 is p6810d8b2$pfad8cb8f$1) == true) goto L44;
    L95:
        p6810d8b2$pfad8cb8f$1 r0 = new p6810d8b2$pfad8cb8f$1(this, r6);
    L65:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L21;
        ResultKt.throwOnFailure(r62);
        Deferred<? : Sequence<p15967156>> r63 = this.f88c888b8;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r62 = m786005c5(r63, r0);
        if (r62 == r1) goto L57;
    L62:
        Sequence<p15967156> r64 = (Sequence) r62;
        if (r64 is not null) goto L46;
    L89:
        return Unit.INSTANCE;
    L46:
        List<p821c9e21> r65 = this.f7dfe64b6.toCommoditiesDbEntity(r64);
        pb512f696 r22 = this.fb20f28b3;
        r0.L$0 = this;
        r0.fd304ba20 = 2;
        if (r22.saveCommodities(r65, r0) == r1) goto L57;
    L64:
        this.m0e020c86();
        this.f88c888b8 = null;
    L57:
        return r1;
    L21:
        if (r2 == 1) goto L66;
        if (r2 != 2) goto L87;
        p6810d8b2 this = (p6810d8b2) r0.L$0;
        ResultKt.throwOnFailure(r62);
        goto L64
    L87:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L66:
        this = (p6810d8b2) r0.L$0;
        ResultKt.throwOnFailure(r62);
        goto L62
    L44:
        r0 = (p6810d8b2$pfad8cb8f$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L95;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L65
    }

    private static readonly bool Mfca1fdb2(p6326cd18 r1) {
        Intrinsics.checkNotNullParameter(r1, "commodity");
        if (r1.getName() is null) goto L13;
        return true;
    L13:
        return false;
    }

    public static /* synthetic */ bool mffbbfe65(pb927a776 r0) {
        return m993ab3df(r0);
    }

    @Override // p7a1eabc3.pb3f20355.p8338e520
    public object ClearInventories(Continuation<Unit> r6) {
        if (((12 + 20) % 20) > 0) goto L10;
    L10:
        if ((r6 is p6810d8b2$p536798aa$1) == false) goto L25;
        p6810d8b2$p536798aa$1 r0 = (p6810d8b2$p536798aa$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L25;
        r0.fd304ba20 -= int.MIN_VALUE;
    L60:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L86;
        if (r2 == 1) goto L32;
        if (r2 != 2) goto L70;
        ResultKt.throwOnFailure(r62);
    L72:
        return Unit.INSTANCE;
    L70:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L32:
        p6810d8b2 this = (p6810d8b2) r0.L$0;
        ResultKt.throwOnFailure(r62);
    L15:
        pb512f696 r5 = this.fb20f28b3;
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        if (r5.clearCommodityGroups(r0) != r1) goto L72;
    L58:
        return r1;
    L86:
        ResultKt.throwOnFailure(r62);
        pb512f696 r63 = this.fb20f28b3;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (r63.clearCommodities(r0) == r1) goto L58;
    L25:
        r0 = new p6810d8b2$p536798aa$1(this, r6);
        goto L60
    }

    @Override // p7a1eabc3.pb3f20355.p8338e520
    public object EditCommodity(p4cc9492b.pca87b160 r6, Continuation<Unit> r7) {
        if (((31 + 3) % 3) > 0) goto L66;
    L66:
        if ((r7 is p6810d8b2$p240f065d$1) == true) goto L42;
    L60:
        p6810d8b2$p240f065d$1 r0 = new p6810d8b2$p240f065d$1(this, r7);
    L54:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L10;
        if (r2 == 1) goto L77;
        if (r2 != 2) goto L35;
        ResultKt.throwOnFailure(r72);
    L91:
        return Unit.INSTANCE;
    L35:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L77:
        p6810d8b2 this = (p6810d8b2) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L18:
        p15967156 r62 = this.f78e07024.mapToCommodityModel((p6326cd18) r72);
        pb512f696 r73 = this.fb20f28b3;
        p821c9e21 r5 = this.f7dfe64b6.toCommodityDbEntity(r62);
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        if (r73.saveCommodity(r5, r0) != r1) goto L91;
    L86:
        return r1;
    L10:
        ResultKt.throwOnFailure(r72);
        p1bac4649 r74 = this.fdfdbbf78;
        p6326cd18 r63 = this.f78e07024.mapToCommodityDTO(r6);
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r72 = r74.editCommodity(r63, r0);
        if (r72 == r1) goto L86;
    L42:
        r0 = (p6810d8b2$p240f065d$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L60;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L54
    }

    @Override // p7a1eabc3.pb3f20355.p8338e520
    public object EditCommodityGroup(p0ded097a r6, Continuation<p0ded097a> r7) {
        if (((30 + 3) % 3) > 0) goto L16;
    L16:
        if ((r7 is p6810d8b2$pe74fd7cd$1) == false) goto L13;
        p6810d8b2$pe74fd7cd$1 r0 = (p6810d8b2$pe74fd7cd$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L13;
        r0.fd304ba20 -= int.MIN_VALUE;
    L86:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L27;
        if (r2 == 1) goto L77;
        if (r2 == 2) goto L50;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L50:
        p0ded097a r5 = (p0ded097a) r0.L$0;
        ResultKt.throwOnFailure(r72);
        return r5;
    L77:
        p6810d8b2 this = (p6810d8b2) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L21:
        p0ded097a r62 = this.f5db9a59f.mapToCommodityGroupModel((pb927a776) r72);
        pb512f696 r73 = this.fb20f28b3;
        pdf878ad9 r52 = this.ff56a1523.toCommodityGroupDbEntity(r62);
        r0.L$0 = r62;
        r0.fd304ba20 = 2;
        if (r73.saveCommodityGroup(r52, r0) == r1) goto L29;
        return r62;
    L29:
        return r1;
    L27:
        ResultKt.throwOnFailure(r72);
        p1bac4649 r74 = this.fdfdbbf78;
        pb927a776 r63 = this.f5db9a59f.mapToCommodityGroupDTO(r6);
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r72 = r74.editCommodityGroup(r63, r0);
        if (r72 == r1) goto L29;
    L13:
        r0 = new p6810d8b2$pe74fd7cd$1(this, r7);
        goto L86
    }

    @Override // p7a1eabc3.pb3f20355.p8338e520
    public object GetAllCommodities(Continuation<? super Sequence<p4cc9492b.pca87b160>> r10) {
        if (((19 + 21) % 21) > 0) goto L14;
    L14:
        if ((r10 is p6810d8b2$pb9d5401f$1) == false) goto L75;
        p6810d8b2$pb9d5401f$1 r0 = (p6810d8b2$pb9d5401f$1) r10;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L75;
        r0.fd304ba20 -= int.MIN_VALUE;
    L58:
        object r102 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L54;
        ResultKt.throwOnFailure(r102);
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (mfad8cb8f(r0) == r1) goto L96;
    L113:
        p6bc3404d r103 = this.f7dfe64b6;
        pb512f696 r22 = this.fb20f28b3;
        pda0b425a r7 = this.f88a0c5ab;
        r0.L$0 = this;
        r0.L$1 = r103;
        r0.L$2 = r22;
        r0.fd304ba20 = 2;
        object r4 = pda0b425a.pb0da8397.mbf9c2684(r7, null, r0, 1, null);
        if (r4 == r1) goto L96;
        p6810d8b2 r23 = this;
        pb512f696 r9 = r22;
    L101:
        string r42 = (string) r4;
        r0.L$0 = r23;
        r0.L$1 = r103;
        r0.L$2 = null;
        r0.fd304ba20 = 3;
        object r92 = r9.getCommodities(r42, r0);
        if (r92 == r1) goto L96;
        p6bc3404d r02 = r103;
        r102 = r92;
        p6bc3404d r93 = r02;
        p6810d8b2 r03 = r23;
    L28:
        return r93.toCommodities((List) r102, r03.f7288c41b.getLocaleType());
    L96:
        return r1;
    L54:
        if (r2 == 1) goto L25;
        if (r2 == 2) goto L124;
        if (r2 == 3) goto L45;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L45:
        r93 = (p6bc3404d) r0.L$1;
        r03 = (p6810d8b2) r0.L$0;
        ResultKt.throwOnFailure(r102);
        goto L28
    L124:
        r9 = (pb512f696) r0.L$2;
        p6bc3404d r24 = (p6bc3404d) r0.L$1;
        p6810d8b2 r43 = (p6810d8b2) r0.L$0;
        ResultKt.throwOnFailure(r102);
        r4 = r102;
        r103 = r24;
        r23 = r43;
        goto L101
    L25:
        p6810d8b2 this = (p6810d8b2) r0.L$0;
        ResultKt.throwOnFailure(r102);
    L75:
        r0 = new p6810d8b2$pb9d5401f$1(this, r10);
        goto L58
    }

    @Override // p7a1eabc3.pb3f20355.p8338e520
    public object GetAllCommoditiesByQuery(string r10, Continuation<? super Sequence<p4cc9492b.pca87b160>> r11) {
        if (((31 + 22) % 22) > 0) goto L81;
    L81:
        if ((r11 is p6810d8b2$pcb122795$1) == true) goto L11;
    L46:
        p6810d8b2$pcb122795$1 r0 = new p6810d8b2$pcb122795$1(this, r11);
    L133:
        object r112 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L122;
        ResultKt.throwOnFailure(r112);
        r0.L$0 = this;
        r0.L$1 = r10;
        r0.fd304ba20 = 1;
        if (mfad8cb8f(r0) == r1) goto L56;
    L90:
        p6bc3404d r113 = this.f7dfe64b6;
        pb512f696 r22 = this.fb20f28b3;
        pda0b425a r7 = this.f88a0c5ab;
        r0.L$0 = this;
        r0.L$1 = r10;
        r0.L$2 = r113;
        r0.L$3 = r22;
        r0.fd304ba20 = 2;
        object r4 = pda0b425a.pb0da8397.mbf9c2684(r7, null, r0, 1, null);
        if (r4 == r1) goto L56;
        p6810d8b2 r42 = this;
        pb512f696 r9 = r22;
        string r23 = r10;
        p6bc3404d r102 = r113;
        r112 = r4;
    L99:
        string r114 = (string) r112;
        r0.L$0 = r42;
        r0.L$1 = r102;
        r0.L$2 = null;
        r0.L$3 = null;
        r0.fd304ba20 = 3;
        r112 = r9.getCommoditiesByQuery(r114, r23, r0);
        if (r112 == r1) goto L56;
        p6bc3404d r92 = r102;
        p6810d8b2 r103 = r42;
    L92:
        return r92.toCommodities((List) r112, r103.f7288c41b.getLocaleType());
    L56:
        return r1;
    L122:
        if (r2 == 1) goto L107;
        if (r2 == 2) goto L110;
        if (r2 != 3) goto L117;
        r92 = (p6bc3404d) r0.L$1;
        r103 = (p6810d8b2) r0.L$0;
        ResultKt.throwOnFailure(r112);
        goto L92
    L117:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L110:
        r9 = (pb512f696) r0.L$3;
        r102 = (p6bc3404d) r0.L$2;
        r23 = (string) r0.L$1;
        r42 = (p6810d8b2) r0.L$0;
        ResultKt.throwOnFailure(r112);
        goto L99
    L107:
        r10 = (string) r0.L$1;
        p6810d8b2 this = (p6810d8b2) r0.L$0;
        ResultKt.throwOnFailure(r112);
        goto L90
    L11:
        r0 = (p6810d8b2$pcb122795$1) r11;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L46;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L133
    }

    @Override // p7a1eabc3.pb3f20355.p8338e520
    public object GetCommoditiesByParentId(string r10, Continuation<? super Sequence<p4cc9492b.pca87b160>> r11) {
        if (((28 + 15) % 15) > 0) goto L95;
    L95:
        if ((r11 is p6810d8b2$p72e8c0b0$1) == false) goto L129;
        p6810d8b2$p72e8c0b0$1 r0 = (p6810d8b2$p72e8c0b0$1) r11;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L129;
        r0.fd304ba20 -= int.MIN_VALUE;
    L32:
        object r112 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L52;
        ResultKt.throwOnFailure(r112);
        r0.L$0 = this;
        r0.L$1 = r10;
        r0.fd304ba20 = 1;
        if (mfad8cb8f(r0) == r1) goto L7;
    L57:
        p6bc3404d r113 = this.f7dfe64b6;
        pb512f696 r22 = this.fb20f28b3;
        pda0b425a r7 = this.f88a0c5ab;
        r0.L$0 = this;
        r0.L$1 = r10;
        r0.L$2 = r113;
        r0.L$3 = r22;
        r0.fd304ba20 = 2;
        object r4 = pda0b425a.pb0da8397.mbf9c2684(r7, null, r0, 1, null);
        if (r4 == r1) goto L7;
        p6810d8b2 r42 = this;
        pb512f696 r9 = r22;
        string r23 = r10;
        p6bc3404d r102 = r113;
        r112 = r4;
    L6:
        string r114 = (string) r112;
        r0.L$0 = r42;
        r0.L$1 = r102;
        r0.L$2 = null;
        r0.L$3 = null;
        r0.fd304ba20 = 3;
        r112 = r9.getCommoditiesByParentId(r114, r23, r0);
        if (r112 == r1) goto L7;
        p6bc3404d r92 = r102;
        p6810d8b2 r103 = r42;
    L74:
        return r92.toCommodities((List) r112, r103.f7288c41b.getLocaleType());
    L7:
        return r1;
    L52:
        if (r2 == 1) goto L16;
        if (r2 == 2) goto L39;
        if (r2 != 3) goto L19;
        r92 = (p6bc3404d) r0.L$1;
        r103 = (p6810d8b2) r0.L$0;
        ResultKt.throwOnFailure(r112);
        goto L74
    L19:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L39:
        r9 = (pb512f696) r0.L$3;
        r102 = (p6bc3404d) r0.L$2;
        r23 = (string) r0.L$1;
        r42 = (p6810d8b2) r0.L$0;
        ResultKt.throwOnFailure(r112);
        goto L6
    L16:
        r10 = (string) r0.L$1;
        p6810d8b2 this = (p6810d8b2) r0.L$0;
        ResultKt.throwOnFailure(r112);
    L129:
        r0 = new p6810d8b2$p72e8c0b0$1(this, r11);
        goto L32
    }

    @Override // p7a1eabc3.pb3f20355.p8338e520
    public object GetCommodityById(string r6, Continuation<p4cc9492b.pca87b160> r7) {
        if (((19 + 18) % 18) > 0) goto L14;
    L14:
        if ((r7 is p6810d8b2$p2edea2fd$1) == false) goto L38;
        p6810d8b2$p2edea2fd$1 r0 = (p6810d8b2$p2edea2fd$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L38;
        r0.fd304ba20 -= int.MIN_VALUE;
    L11:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L50;
        if (r2 != 1) goto L35;
        p6bc3404d r5 = (p6bc3404d) r0.L$1;
        p6810d8b2 r62 = (p6810d8b2) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L17:
        return r5.toCommodity((p081afd40) r72, r62.f7288c41b.getLocaleType());
    L35:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L50:
        ResultKt.throwOnFailure(r72);
        p6bc3404d r73 = this.f7dfe64b6;
        pb512f696 r22 = this.fb20f28b3;
        r0.L$0 = this;
        r0.L$1 = r73;
        r0.fd304ba20 = 1;
        object r63 = r22.getCommodityById(r6, r0);
        if (r63 != r1) goto L28;
        return r1;
    L28:
        r62 = this;
        r5 = r73;
        r72 = r63;
    L38:
        r0 = new p6810d8b2$p2edea2fd$1(this, r7);
        goto L11
    }

    @Override // p7a1eabc3.pb3f20355.p8338e520
    public object GetCommodityGroupById(string r5, Continuation<p0ded097a> r6) {
        if (((1 + 29) % 29) > 0) goto L15;
    L15:
        if ((r6 is p6810d8b2$pbc354f4e$1) == false) goto L55;
        p6810d8b2$pbc354f4e$1 r0 = (p6810d8b2$pbc354f4e$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L55;
        r0.fd304ba20 -= int.MIN_VALUE;
    L75:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L51;
        ResultKt.throwOnFailure(r62);
        pb512f696 r63 = this.fb20f28b3;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r62 = r63.getCommodityGroupById(r5, r0);
        if (r62 == r1) goto L9;
    L76:
        pdf878ad9 r64 = (pdf878ad9) r62;
        if (r64 is not null) goto L6;
        return null;
    L6:
        return this.ff56a1523.toCommodityGroup(r64);
    L9:
        return r1;
    L51:
        if (r2 != 1) goto L57;
        p6810d8b2 this = (p6810d8b2) r0.L$0;
        ResultKt.throwOnFailure(r62);
        goto L76
    L57:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L55:
        r0 = new p6810d8b2$pbc354f4e$1(this, r6);
        goto L75
    }

    @Override // p7a1eabc3.pb3f20355.p8338e520
    public object GetCommodityGroups(Continuation<? super Sequence<p0ded097a>> r9) {
        if (((13 + 18) % 18) > 0) goto L115;
    L115:
        if ((r9 is p6810d8b2$p80f85eae$1) == true) goto L120;
    L113:
        p6810d8b2$p80f85eae$1 r0 = new p6810d8b2$p80f85eae$1(this, r9);
    L13:
        object r92 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L55;
        if (r2 == 1) goto L22;
        if (r2 == 2) goto L71;
        if (r2 != 3) goto L23;
        p3458384a r8 = (p3458384a) r0.L$0;
        ResultKt.throwOnFailure(r92);
    L84:
        return r8.toCommodityGroups((List) r92);
    L23:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L71:
        pb512f696 r82 = (pb512f696) r0.L$1;
        p3458384a r22 = (p3458384a) r0.L$0;
        ResultKt.throwOnFailure(r92);
        object r23 = r92;
        p3458384a r93 = r22;
    L83:
        string r24 = (string) r23;
        r0.L$0 = r93;
        r0.L$1 = null;
        r0.fd304ba20 = 3;
        object r83 = r82.getCommodityGroups(r24, r0);
        if (r83 == r1) goto L53;
        p3458384a r7 = r93;
        r92 = r83;
        r8 = r7;
    L53:
        return r1;
    L22:
        p6810d8b2 this = (p6810d8b2) r0.L$0;
        ResultKt.throwOnFailure(r92);
    L78:
        r93 = this.ff56a1523;
        pb512f696 r25 = this.fb20f28b3;
        pda0b425a r84 = this.f88a0c5ab;
        r0.L$0 = r93;
        r0.L$1 = r25;
        r0.fd304ba20 = 2;
        object r85 = pda0b425a.pb0da8397.mbf9c2684(r84, null, r0, 1, null);
        if (r85 == r1) goto L53;
        r23 = r85;
        r82 = r25;
        goto L83
    L55:
        ResultKt.throwOnFailure(r92);
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (m35f6087e(r0) == r1) goto L53;
    L120:
        r0 = (p6810d8b2$p80f85eae$1) r9;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L113;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L13
    }

    @Override // p7a1eabc3.pb3f20355.p8338e520
    public object GetCommodityGroupsByParentId(string r9, Continuation<? super Sequence<p0ded097a>> r10) {
        if (((12 + 29) % 29) > 0) goto L41;
    L41:
        if ((r10 is p6810d8b2$p763320ce$1) == false) goto L55;
        p6810d8b2$p763320ce$1 r0 = (p6810d8b2$p763320ce$1) r10;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L55;
        r0.fd304ba20 -= int.MIN_VALUE;
    L3:
        object r102 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L24;
        if (r2 == 1) goto L15;
        if (r2 == 2) goto L25;
        if (r2 == 3) goto L128;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L128:
        p3458384a r8 = (p3458384a) r0.L$0;
        ResultKt.throwOnFailure(r102);
    L49:
        return r8.toCommodityGroups((List) r102);
    L25:
        pb512f696 r82 = (pb512f696) r0.L$2;
        p3458384a r92 = (p3458384a) r0.L$1;
        string r22 = (string) r0.L$0;
        ResultKt.throwOnFailure(r102);
    L53:
        string r103 = (string) r102;
        r0.L$0 = r92;
        r0.L$1 = null;
        r0.L$2 = null;
        r0.fd304ba20 = 3;
        r102 = r82.getCommodityGroupsByParentId(r103, r22, r0);
        if (r102 == r1) goto L51;
        r8 = r92;
    L51:
        return r1;
    L15:
        r9 = (string) r0.L$1;
        p6810d8b2 this = (p6810d8b2) r0.L$0;
        ResultKt.throwOnFailure(r102);
    L86:
        p3458384a r104 = this.ff56a1523;
        pb512f696 r23 = this.fb20f28b3;
        pda0b425a r83 = this.f88a0c5ab;
        r0.L$0 = r9;
        r0.L$1 = r104;
        r0.L$2 = r23;
        r0.fd304ba20 = 2;
        object r84 = pda0b425a.pb0da8397.mbf9c2684(r83, null, r0, 1, null);
        if (r84 == r1) goto L51;
        r102 = r84;
        r82 = r23;
        r22 = r9;
        r92 = r104;
        goto L53
    L24:
        ResultKt.throwOnFailure(r102);
        r0.L$0 = this;
        r0.L$1 = r9;
        r0.fd304ba20 = 1;
        if (m35f6087e(r0) == r1) goto L51;
    L55:
        r0 = new p6810d8b2$p763320ce$1(this, r10);
        goto L3
    }

    @Override // p7a1eabc3.pb3f20355.p8338e520
    public void LoadInventories() {
        if (((30 + 12) % 12) > 0) goto L16;
    L16:
        mf6a5538c().invokeOnCompletion(new p6810d8b2$pd41d8cd9$p95263d50(this));
        ma4f537b1().invokeOnCompletion(new p6810d8b2$pd41d8cd9$pcca4ef0e(this));
    }

    @Override // p7a1eabc3.pb3f20355.p8338e520
    public object RemoveCommodity(p4cc9492b.pca87b160 r6, Continuation<Unit> r7) {
        if (((7 + 22) % 22) > 0) goto L10;
    L10:
        if ((r7 is p6810d8b2$pa2221e6c$1) == false) goto L76;
        p6810d8b2$pa2221e6c$1 r0 = (p6810d8b2$pa2221e6c$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L76;
        r0.fd304ba20 -= int.MIN_VALUE;
    L14:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L78;
        ResultKt.throwOnFailure(r72);
        p1bac4649 r73 = this.fdfdbbf78;
        p6326cd18 r22 = this.f78e07024.mapToCommodityDTO(r6);
        r0.L$0 = this;
        r0.L$1 = r6;
        r0.fd304ba20 = 1;
        if (r73.removeCommodity(r22, r0) == r1) goto L58;
    L71:
        pb512f696 r5 = this.fb20f28b3;
        string r62 = r6.getId();
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 2;
        if (r5.deleteCommodity(r62, r0) == r1) goto L58;
    L50:
        return Unit.INSTANCE;
    L58:
        return r1;
    L78:
        if (r2 == 1) goto L56;
        if (r2 != 2) goto L4;
        ResultKt.throwOnFailure(r72);
        goto L50
    L4:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L56:
        r6 = (p4cc9492b.pca87b160) r0.L$1;
        p6810d8b2 this = (p6810d8b2) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L76:
        r0 = new p6810d8b2$pa2221e6c$1(this, r7);
        goto L14
    }

    @Override // p7a1eabc3.pb3f20355.p8338e520
    public object RemoveCommodityGroup(string r6, Continuation<Unit> r7) {
        if (((25 + 9) % 9) > 0) goto L3;
    L3:
        if ((r7 is p6810d8b2$pfe75008f$1) == false) goto L35;
        p6810d8b2$pfe75008f$1 r0 = (p6810d8b2$pfe75008f$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L35;
        r0.fd304ba20 -= int.MIN_VALUE;
    L60:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L41;
        if (r2 == 1) goto L46;
        if (r2 != 2) goto L71;
        ResultKt.throwOnFailure(r72);
    L15:
        return Unit.INSTANCE;
    L71:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L46:
        r6 = (string) r0.L$1;
        p6810d8b2 this = (p6810d8b2) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L27:
        pb512f696 r5 = this.fb20f28b3;
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 2;
        if (r5.clearCommodityGroup(r6, r0) != r1) goto L15;
    L85:
        return r1;
    L41:
        ResultKt.throwOnFailure(r72);
        p1bac4649 r73 = this.fdfdbbf78;
        r0.L$0 = this;
        r0.L$1 = r6;
        r0.fd304ba20 = 1;
        if (r73.removeCommodityGroup(r6, r0) == r1) goto L85;
    L35:
        r0 = new p6810d8b2$pfe75008f$1(this, r7);
        goto L60
    }

    @Override // p7a1eabc3.pb3f20355.p8338e520
    public object ReplaceCommoditiesQuantity(List<p1b7a5668> r5, Continuation<Unit> r6) {
        if (((16 + 11) % 11) > 0) goto L27;
    L27:
        pb512f696 r4 = this.fb20f28b3;
        List<p1b7a5668> r52 = r5;
        List r0 = new List(ICollectionsKt.collectionSizeOrDefault(r52, 10));
        IEnumerator<T> r53 = r52.GetEnumerator();
    L37:
        if (r53.MoveNext() == false) goto L45;
        p1b7a5668 r1 = (p1b7a5668) r53.Current;
        r0.Add(new p01a233fd(r1.getId(), r1.getQuantity()));
        goto L37
    L45:
        object r42 = r4.replaceCommoditiesQuantity(r0, r6);
        if (r42 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L32;
        return r42;
    L32:
        return Unit.INSTANCE;
    }

    @Override // p7a1eabc3.pb3f20355.p8338e520
    public object UpdateCommoditiesQuantity(List<p1b7a5668> r5, Continuation<Unit> r6) {
        if (((9 + 1) % 1) > 0) goto L17;
    L17:
        pb512f696 r4 = this.fb20f28b3;
        List<p1b7a5668> r52 = r5;
        List r0 = new List(ICollectionsKt.collectionSizeOrDefault(r52, 10));
        IEnumerator<T> r53 = r52.GetEnumerator();
    L8:
        if (r53.MoveNext() == false) goto L21;
        p1b7a5668 r1 = (p1b7a5668) r53.Current;
        r0.Add(new p01a233fd(r1.getId(), r1.getQuantity()));
        goto L8
    L21:
        object r42 = r4.updateCommoditiesQuantity(r0, r6);
        if (r42 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L28;
        return r42;
    L28:
        return Unit.INSTANCE;
    }

    @Override // p7a1eabc3.pb3f20355.p8338e520
    public object UpdateCommoditiesQuantityAndPrice(List<p4a26ac24> r6, Continuation<Unit> r7) {
        if (((15 + 11) % 11) > 0) goto L35;
    L35:
        pb512f696 r5 = this.fb20f28b3;
        List<p4a26ac24> r62 = r6;
        List r0 = new List(ICollectionsKt.collectionSizeOrDefault(r62, 10));
        IEnumerator<T> r63 = r62.GetEnumerator();
    L36:
        if (r63.MoveNext() == false) goto L5;
        p4a26ac24 r1 = (p4a26ac24) r63.Current;
        r0.Add(new pb72e6bb1(r1.getId(), r1.getQuantity(), r1.getPrice()));
        goto L36
    L5:
        object r52 = r5.updateCommoditiesQuantityAndPrice(r0, r7);
        if (r52 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L8;
        return r52;
    L8:
        return Unit.INSTANCE;
    }
}

