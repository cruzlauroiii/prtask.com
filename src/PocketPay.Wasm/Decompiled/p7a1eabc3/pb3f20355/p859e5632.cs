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
public readonly class p859e5632 : p3bd10aa2 {
    private readonly p776a1426 f37d2fda3;
    private readonly p643c77ba f3ab9ff04;
    private readonly p4e60f922 f5b552056;
    private readonly p776a1426 f7288c41b;
    private readonly p51821801 f82d77dff;
    private readonly p51821801 fa04af84d;
    private readonly p643c77ba fb0b3f663;
    private readonly p643c77ba fbc555d91;
    private readonly p51821801 ff9aac5d0;
    private readonly p4e60f922 ffc97d360;

    public p859e5632(p643c77ba r2, p51821801 r3, p776a1426 r4, p4e60f922 r5) {
        Intrinsics.checkNotNullParameter(r2, "directoryApi");
        Intrinsics.checkNotNullParameter(r3, "inventoryDao");
        Intrinsics.checkNotNullParameter(r4, "localeRepository");
        Intrinsics.checkNotNullParameter(r5, "regionRepository");
        this.fbc555d91 = r2;
        this.ff9aac5d0 = r3;
        this.f7288c41b = r4;
        this.ffc97d360 = r5;
    }

    private readonly object M1c1e502d(Continuation<? super List<p09e6c013>> r5) {
        if (((27 + 7) % 7) > 0) goto L26;
    L26:
        if ((r5 is p859e5632$p1c1e502d$1) == false) goto L39;
        p859e5632$p1c1e502d$1 r0 = (p859e5632$p1c1e502d$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L39;
        r0.fd304ba20 -= int.MIN_VALUE;
    L16:
        object r52 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L81;
        if (r2 != 1) goto L76;
        ResultKt.throwOnFailure(r52);
    L3:
        Response r53 = (Response) r52;
        if (r53.isSuccessful() == true) goto L63;
    L4:
        throw new IllegalStateException("error while loading taxes".tostring());
    L63:
        List r4 = (List) r53.body();
        if (r4 is null) goto L4;
        return r4;
    L76:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L81:
        ResultKt.throwOnFailure(r52);
        p643c77ba r54 = this.fbc555d91;
        string r42 = this.ffc97d360.getSelectedRegion();
        r0.fd304ba20 = 1;
        r52 = r54.getTaxes(r42, r0);
        if (r52 != r1) goto L3;
        return r1;
    L39:
        r0 = new p859e5632$p1c1e502d$1(this, r5);
        goto L16
    }

    public static readonly /* synthetic */ object m64dfc900(p859e5632 r0, Continuation r1) {
        return r0.m1c1e502d(r1);
    }

    @Override // p7a1eabc3.pb3f20355.p3bd10aa2
    public object GetDefaultTax(Continuation<p4b78ac8e> r2) {
        return getTaxByCode(Decryptstring.decryptstring("9f57ed4ff3df46c7bb72c3abf542ea91bfb8e01c87c0420035154466b934e751de75"), r2);
    }

    @Override // p7a1eabc3.pb3f20355.p3bd10aa2
    public object GetTaxByCode(string r6, Continuation<p4b78ac8e> r7) {
        if (((29 + 19) % 19) > 0) goto L76;
    L76:
        if ((r7 is p859e5632$pc936e05b$1) == true) goto L31;
    L69:
        p859e5632$pc936e05b$1 r0 = new p859e5632$pc936e05b$1(this, r7);
    L55:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L61;
        if (r2 != 1) goto L74;
        pf3d67c3a r5 = (pf3d67c3a) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L38:
        pf22d65ed r73 = (pf22d65ed) r72;
        if (r73 is not null) goto L81;
        return null;
    L81:
        return r73.toTaxModel(r5);
    L74:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L61:
        ResultKt.throwOnFailure(r72);
        pf3d67c3a r74 = this.f7288c41b.getLocaleType();
        p51821801 r52 = this.ff9aac5d0;
        r0.L$0 = r74;
        r0.fd304ba20 = 1;
        object r53 = r52.getTaxByCode(r6, r0);
        if (r53 != r1) goto L64;
        return r1;
    L64:
        r72 = r53;
        r5 = r74;
        goto L38
    L31:
        r0 = (p859e5632$pc936e05b$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L69;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L55
    }

    @Override // p7a1eabc3.pb3f20355.p3bd10aa2
    public object GetTaxes(Continuation<? super List<p4b78ac8e>> r5) {
        if (((10 + 30) % 30) > 0) goto L16;
    L16:
        if ((r5 is p859e5632$pc703e065$1) == false) goto L86;
        p859e5632$pc703e065$1 r0 = (p859e5632$pc703e065$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L86;
        r0.fd304ba20 -= int.MIN_VALUE;
    L55:
        object r52 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L53;
        if (r2 != 1) goto L65;
        p859e5632 this = (p859e5632) r0.L$0;
        ResultKt.throwOnFailure(r52);
    L84:
        List r53 = (List) r52;
        pf3d67c3a r4 = this.f7288c41b.getLocaleType();
        List r54 = r53;
        List r02 = new List(ICollectionsKt.collectionSizeOrDefault(r54, 10));
        IEnumerator r55 = r54.GetEnumerator();
    L57:
        if (r55.MoveNext() == false) goto L74;
        r02.Add(((pf22d65ed) r55.Current).toTaxModel(r4));
        goto L57
    L74:
        return r02;
    L65:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L53:
        ResultKt.throwOnFailure(r52);
        p51821801 r56 = this.ff9aac5d0;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r52 = r56.getTaxes(r0);
        if (r52 != r1) goto L84;
        return r1;
    L86:
        r0 = new p859e5632$pc703e065$1(this, r5);
        goto L55
    }

    @Override // p7a1eabc3.pb3f20355.p3bd10aa2
    public object ReplaceTaxes(Continuation<Unit> r6) {
        if (((20 + 5) % 5) > 0) goto L54;
    L54:
        if ((r6 is p859e5632$p7dde0fd3$1) == false) goto L47;
        p859e5632$p7dde0fd3$1 r0 = (p859e5632$p7dde0fd3$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L47;
        r0.fd304ba20 -= int.MIN_VALUE;
    L3:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L28;
        ResultKt.throwOnFailure(r62);
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r62 = m1c1e502d(r0);
        if (r62 != r1) goto L37;
    L65:
        return r1;
    L37:
        List r63 = (List) r62;
        List r22 = new List(ICollectionsKt.collectionSizeOrDefault(r63, 10));
        IEnumerator r64 = r63.GetEnumerator();
    L15:
        if (r64.MoveNext() == false) goto L46;
        r22.Add(((p09e6c013) r64.Current).toTaxDbEntity());
        goto L15
    L46:
        List r23 = r22;
        p51821801 r5 = this.ff9aac5d0;
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        if (r5.replaceTaxes(r23, r0) == r1) goto L65;
    L95:
        return Unit.INSTANCE;
    L28:
        if (r2 == 1) goto L104;
        if (r2 != 2) goto L91;
        ResultKt.throwOnFailure(r62);
        goto L95
    L91:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L104:
        p859e5632 this = (p859e5632) r0.L$0;
        ResultKt.throwOnFailure(r62);
    L47:
        r0 = new p859e5632$p7dde0fd3$1(this, r6);
        goto L3
    }
}

