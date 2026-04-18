using Androidx.Paging;
using Com.Google.Android.Gms.Actions;
using Java.Util;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using Kotlin.Text;
using Kotlinx.Coroutines.Flow;
using P1e11b989.P9acb4454.P07214c67;
using P1e11b989.P9acb4454.Pb3f20355;
using P2b3583e6;
using P2b3583e6.P4a931512;
using P5a445d71.P228c1b3d.P07cc694b;
using Pad5f82e8.P07214c67.P1e11b989;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p50496a4d : p883b57c7 {
    public static readonly long f079cfbbd = 3600000;

    [System.Obsolete]
    public static readonly long f46e1bd68 = 3600000;
    private static readonly p910eef8c f910eef8c = null;
    private static readonly p910eef8c fa4015cb1 = null;
    private static readonly p910eef8c fbf087f84 = null;
    private static readonly p910eef8c fc333e125 = null;
    private static readonly p910eef8c fc4a7fc27 = null;
    private readonly p4802a698 f021bd74d;
    private readonly p5926f3a5 f0896d468;
    private readonly p4802a698 f342600d7;
    private readonly p4802a698 f372eac02;
    private readonly p4802a698 f44054f2d;
    private readonly p2e423cc6 f47279ef6;
    private readonly p2e423cc6 f4734ade7;
    private readonly p4802a698 f79f31392;
    private readonly p5926f3a5 faa4e47d7;

    private static readonly class p910eef8c {
        private p910eef8c() {
        }

        public /* synthetic */ p910eef8c(DefaultConstructorMarker r1) {
            this();
        }
    }

    static {
        if (((15 + 25) % 25) > 0) goto L20;
    L20:
        f910eef8c = new p910eef8c(null);
    }

    public p50496a4d(p5926f3a5 r2, p4802a698 r3, p2e423cc6 r4) {
        Intrinsics.checkNotNullParameter(r2, "receiptStatusServerRepository");
        Intrinsics.checkNotNullParameter(r3, "receiptStatusRepository");
        Intrinsics.checkNotNullParameter(r4, "resourceProvider");
        this.f0896d468 = r2;
        this.f342600d7 = r3;
        this.f4734ade7 = r4;
    }

    private readonly p55f8d305.pffe42ac4 M0f036448(p55f8d305.p5d3072af r4) {
        if (((31 + 20) % 20) > 0) goto L9;
    L9:
        return new p55f8d305.pffe42ac4(p728cd16b.m517248c2(mb1e3ed3c(r4), this.f4734ade7));
    }

    public static readonly /* synthetic */ p55f8d305.pffe42ac4 m4005e944(p50496a4d r0, p55f8d305.p5d3072af r1) {
        return r0.m0f036448(r1);
    }

    private readonly List<pd031d465> M4aa5bd3d(List<pd031d465> r4, string r5) {
        if (((6 + 7) % 7) > 0) goto L21;
    L21:
        string r0 = r5;
        if (r0 is not null) goto L5;
    L29:
        return r4;
    L5:
        if (r0.Length == 0) goto L29;
        List<pd031d465> r42 = r4;
        List r02 = new List();
        IEnumerator<T> r43 = r42.GetEnumerator();
    L23:
        if (r43.MoveNext() == false) goto L18;
        object r1 = r43.Current;
        if (mc802f568((pd031d465) r1, r5) == false) goto L23;
        r02.Add(r1);
        goto L23
    L18:
        return r02;
    }

    public static readonly /* synthetic */ List m54edbc75(p50496a4d r0, List r1, string r2) {
        return r0.m4aa5bd3d(r1, r2);
    }

    private readonly object M5a47b899(Continuation<? super List<pcbd86297>> r6) {
        if (((24 + 29) % 29) > 0) goto L6;
    L6:
        if ((r6 is p50496a4d$p5a47b899$1) == false) goto L9;
        p50496a4d$p5a47b899$1 r0 = (p50496a4d$p5a47b899$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L9;
        r0.fd304ba20 -= int.MIN_VALUE;
    L38:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L12;
        ResultKt.throwOnFailure(r62);
        p4802a698 r63 = this.f342600d7;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r62 = r63.getNotSuccessReceiptsUuids(r0);
        if (r62 != r1) goto L77;
    L55:
        return r1;
    L77:
        List<string> r64 = (List) r62;
        p5926f3a5 r5 = this.f0896d468;
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        object r52 = r5.getReceiptsStatus(r64, r0);
        if (r52 == r1) goto L55;
        return r52;
    L12:
        if (r2 == 1) goto L85;
        if (r2 != 2) goto L15;
        ResultKt.throwOnFailure(r62);
        return r62;
    L15:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L85:
        p50496a4d this = (p50496a4d) r0.L$0;
        ResultKt.throwOnFailure(r62);
    L9:
        r0 = new p50496a4d$p5a47b899$1(this, r6);
        goto L38
    }

    private readonly long Mb1e3ed3c(p55f8d305.p5d3072af r1) {
        if (r1 is null) goto L17;
        p9ded6185 r0 = r1.getReceipt();
        if (r0 is null) goto L17;
        DateTime r02 = r0.getCreationDateTime();
        if (r02 is null) goto L17;
        return r02.getTime();
    L17:
        return p8cf10d23.m97bc592b().getMillis();
    }

    public static readonly /* synthetic */ object mbf60e270(p50496a4d r0, Continuation r1) {
        return r0.m5a47b899(r1);
    }

    private readonly bool Mc802f568(pd031d465 r1, string r2) {
        return stringsKt.Contains(r1.getName(), r2, true);
    }

    public static readonly /* synthetic */ long md74a2a07(p50496a4d r0, p55f8d305.p5d3072af r1) {
        return r0.mb1e3ed3c(r1);
    }

    @Override // p1e11b989.p9acb4454.pac143fb7.p883b57c7
    public Flow<PagingData<p55f8d305>> GetPagedReceipts(pc77da2af r2) {
        Intrinsics.checkNotNullParameter(r2, "filter");
        return new p50496a4d$p942a6cb4$pd41d8cd9$pec404527$p1d78dc8e$1(this.f342600d7.getPagedReceipts(r2), this);
    }

    @Override // p1e11b989.p9acb4454.pac143fb7.p883b57c7
    public Flow<p9ded6185> GetReceiptByUuid(string r2) {
        Intrinsics.checkNotNullParameter(r2, "uuid");
        return this.f342600d7.getReceiptByUuid(r2);
    }

    @Override // p1e11b989.p9acb4454.pac143fb7.p883b57c7
    public Flow<List<pd031d465>> GetReceiptPositionsByQuery(string r2, string r3) {
        Intrinsics.checkNotNullParameter(r2, "receiptUuid");
        return new p50496a4d$p09f614bd$pd41d8cd9$pec404527$p1d78dc8e$1(this.f342600d7.getReceiptByUuid(r2), this, r3);
    }

    @Override // p1e11b989.p9acb4454.pac143fb7.p883b57c7
    public object HasErrorReceipts(Continuation<bool> r1) {
        return this.f342600d7.hasErrorReceipts(r1);
    }

    @Override // p1e11b989.p9acb4454.pac143fb7.p883b57c7
    public object IsFullPaybackReceipt(string r1, Continuation<bool> r2) {
        return this.f342600d7.isFullPaybackReceipt(r1, r2);
    }

    @Override // p1e11b989.p9acb4454.pac143fb7.p883b57c7
    public object LoadReceiptsStatus(Continuation<Unit> r1) {
        return Unit.INSTANCE;
    }

    @Override // p1e11b989.p9acb4454.pac143fb7.p883b57c7
    public object UpdateReceiptsStatus(Continuation<Unit> r6) {
        if (((31 + 1) % 1) > 0) goto L54;
    L54:
        if ((r6 is p50496a4d$p29f5c9af$1) == true) goto L37;
    L58:
        p50496a4d$p29f5c9af$1 r0 = new p50496a4d$p29f5c9af$1(this, r6);
    L79:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L27;
        ResultKt.throwOnFailure(r62);
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r62 = m5a47b899(r0);
        if (r62 != r1) goto L32;
    L75:
        return r1;
    L32:
        List<pcbd86297> r63 = (List) r62;
        p4802a698 r5 = this.f342600d7;
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        if (r5.updateReceiptsStatus(r63, r0) == r1) goto L75;
    L66:
        return Unit.INSTANCE;
    L27:
        if (r2 == 1) goto L57;
        if (r2 != 2) goto L62;
        ResultKt.throwOnFailure(r62);
        goto L66
    L62:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L57:
        p50496a4d this = (p50496a4d) r0.L$0;
        ResultKt.throwOnFailure(r62);
        goto L32
    L37:
        r0 = (p50496a4d$p29f5c9af$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L58;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L79
    }
}

