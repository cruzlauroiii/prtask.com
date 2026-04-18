using Com.Decryptstringmanager;
using Java.Util;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using P7a1eabc3.Pf0719ea8;
using P8d777f38.P8a5da52e;
using P8d777f38.Pb3f20355.P960db2ed;
using P8d777f38.Pb3f20355.Pfb216d9e;
using Pad5f82e8.P07214c67.P7a1eabc3;
using Pad5f82e8.P07214c67.Pd77d5e50;
using Pad5f82e8.P07214c67.Pfb216d9e;
using Retrofit2;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes19.dex */
public readonly class p28f1bfa1 : pc6ec09ca {
    private readonly p4e60f922 f0eab0288;
    private readonly p776a1426 f11fa3ead;
    private readonly p776a1426 f19539707;
    private readonly p643c77ba f2ba4d9b1;
    private readonly p776a1426 f7288c41b;
    private readonly p4e60f922 f8005e5d3;
    private readonly p4e60f922 f9745454e;
    private readonly p51821801 f9951dd46;
    private readonly p4e60f922 fb3d6c4ba;
    private readonly p643c77ba fbc555d91;
    private readonly p776a1426 fca46b555;
    private readonly p51821801 fe41a6881;
    private readonly p643c77ba fea2ed871;
    private readonly p51821801 ff9aac5d0;
    private readonly p4e60f922 ffc97d360;

    public p28f1bfa1(p643c77ba r2, p51821801 r3, p776a1426 r4, p4e60f922 r5) {
        Intrinsics.checkNotNullParameter(r2, "directoryApi");
        Intrinsics.checkNotNullParameter(r3, "inventoryDao");
        Intrinsics.checkNotNullParameter(r4, "localeRepository");
        Intrinsics.checkNotNullParameter(r5, "regionRepository");
        this.fbc555d91 = r2;
        this.ff9aac5d0 = r3;
        this.f7288c41b = r4;
        this.ffc97d360 = r5;
    }

    public static readonly /* synthetic */ object m5c801a53(p28f1bfa1 r0, Continuation r1) {
        return r0.m95db2393(r1);
    }

    private readonly object M95db2393(Continuation<? super List<p41e5b820>> r5) {
        if (((26 + 28) % 28) > 0) goto L16;
    L16:
        if ((r5 is p28f1bfa1$p95db2393$1) == false) goto L79;
        p28f1bfa1$p95db2393$1 r0 = (p28f1bfa1$p95db2393$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L79;
        r0.fd304ba20 -= int.MIN_VALUE;
    L58:
        object r52 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L21;
        if (r2 != 1) goto L30;
        ResultKt.throwOnFailure(r52);
    L75:
        Response r53 = (Response) r52;
        if (r53.isSuccessful() == false) goto L32;
        List r4 = (List) r53.body();
        if (r4 is null) goto L32;
        return r4;
    L32:
        throw new IllegalStateException("error while loading measures".tostring());
    L30:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L21:
        ResultKt.throwOnFailure(r52);
        p643c77ba r54 = this.fbc555d91;
        string r42 = this.ffc97d360.getSelectedRegion();
        r0.fd304ba20 = 1;
        r52 = r54.getMeasures(r42, r0);
        if (r52 != r1) goto L75;
        return r1;
    L79:
        r0 = new p28f1bfa1$p95db2393$1(this, r5);
        goto L58
    }

    @Override // p7a1eabc3.pb3f20355.pc6ec09ca
    public object GetDefaultMeasure(Continuation<p0cbbe032> r6) {
        if (((26 + 28) % 28) > 0) goto L4;
    L4:
        if ((r6 is p28f1bfa1$pb448df54$1) == false) goto L35;
        p28f1bfa1$pb448df54$1 r0 = (p28f1bfa1$pb448df54$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L35;
        r0.fd304ba20 -= int.MIN_VALUE;
    L70:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L57;
        if (r2 != 1) goto L80;
        pf3d67c3a r5 = (pf3d67c3a) r0.L$0;
        ResultKt.throwOnFailure(r62);
    L3:
        peaf39066 r63 = (peaf39066) r62;
        if (r63 is not null) goto L24;
        return null;
    L24:
        return r63.toMeasureModel(r5);
    L80:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L57:
        ResultKt.throwOnFailure(r62);
        pf3d67c3a r64 = this.f7288c41b.getLocaleType();
        p51821801 r52 = this.ff9aac5d0;
        r0.L$0 = r64;
        r0.fd304ba20 = 1;
        object r53 = r52.getMeasureByCode(Decryptstring.decryptstring("6d2e6983a25d5877688c29e35cf3e3a572423b759e4cffc7f7c2a2e36f19"), r0);
        if (r53 != r1) goto L82;
        return r1;
    L82:
        r62 = r53;
        r5 = r64;
    L35:
        r0 = new p28f1bfa1$pb448df54$1(this, r6);
        goto L70
    }

    @Override // p7a1eabc3.pb3f20355.pc6ec09ca
    public object GetMeasures(Continuation<? super List<p0cbbe032>> r5) {
        if (((6 + 10) % 10) > 0) goto L51;
    L51:
        if ((r5 is p28f1bfa1$p86fa6691$1) == false) goto L22;
        p28f1bfa1$p86fa6691$1 r0 = (p28f1bfa1$p86fa6691$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L22;
        r0.fd304ba20 -= int.MIN_VALUE;
    L16:
        object r52 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L11;
        ResultKt.throwOnFailure(r52);
        p51821801 r53 = this.ff9aac5d0;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r52 = r53.getMeasures(r0);
        if (r52 != r1) goto L80;
        return r1;
    L80:
        List r54 = (List) r52;
        pf3d67c3a r4 = this.f7288c41b.getLocaleType();
        List r55 = r54;
        List r02 = new List(ICollectionsKt.collectionSizeOrDefault(r55, 10));
        IEnumerator r56 = r55.GetEnumerator();
    L19:
        if (r56.MoveNext() == false) goto L4;
        r02.Add(((peaf39066) r56.Current).toMeasureModel(r4));
        goto L19
    L4:
        return r02;
    L11:
        if (r2 != 1) goto L78;
        p28f1bfa1 this = (p28f1bfa1) r0.L$0;
        ResultKt.throwOnFailure(r52);
        goto L80
    L78:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L22:
        r0 = new p28f1bfa1$p86fa6691$1(this, r5);
        goto L16
    }

    @Override // p7a1eabc3.pb3f20355.pc6ec09ca
    public object ReplaceMeasures(Continuation<Unit> r6) {
        if (((2 + 29) % 29) > 0) goto L83;
    L83:
        if ((r6 is p28f1bfa1$pb34f48c2$1) == true) goto L13;
    L63:
        p28f1bfa1$pb34f48c2$1 r0 = new p28f1bfa1$pb34f48c2$1(this, r6);
    L90:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L80;
        ResultKt.throwOnFailure(r62);
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r62 = m95db2393(r0);
        if (r62 != r1) goto L28;
    L73:
        return r1;
    L28:
        List r63 = (List) r62;
        List r22 = new List(ICollectionsKt.collectionSizeOrDefault(r63, 10));
        IEnumerator r64 = r63.GetEnumerator();
    L98:
        if (r64.MoveNext() == false) goto L91;
        r22.Add(((p41e5b820) r64.Current).toMeasureDbEntity());
        goto L98
    L91:
        List r23 = r22;
        p51821801 r5 = this.ff9aac5d0;
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        if (r5.replaceMeasures(r23, r0) == r1) goto L73;
    L39:
        return Unit.INSTANCE;
    L80:
        if (r2 == 1) goto L87;
        if (r2 != 2) goto L104;
        ResultKt.throwOnFailure(r62);
        goto L39
    L104:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L87:
        p28f1bfa1 this = (p28f1bfa1) r0.L$0;
        ResultKt.throwOnFailure(r62);
        goto L28
    L13:
        r0 = (p28f1bfa1$pb34f48c2$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L63;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L90
    }
}

