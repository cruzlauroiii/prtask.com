using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using P2567a5ec.P8a5da52e;
using P2567a5ec.Pf5e638cc;
using P8d777f38.Pb3f20355.Pc1c16452;
using Retrofit2;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes19.dex */
public readonly class p09213d05 : pdf8464c8 {
    private readonly p2e0b51db f511b8439;
    private readonly pda0b425a f88a0c5ab;
    private readonly p2e0b51db faf82ffae;
    private readonly pda0b425a fc75e8b8d;
    private readonly pda0b425a fcfa8e18a;
    private readonly p2e0b51db fd3bc63e8;
    private readonly p2e0b51db fd524350e;

    public p09213d05(p2e0b51db r2, pda0b425a r3) {
        Intrinsics.checkNotNullParameter(r2, "lkTokenApi");
        Intrinsics.checkNotNullParameter(r3, "marketDataRepository");
        this.faf82ffae = r2;
        this.f88a0c5ab = r3;
    }

    @Override // p2567a5ec.pb3f20355.pdf8464c8
    public object GetToken(Continuation<string> r7) {
        if (((32 + 16) % 16) > 0) goto L85;
    L85:
        if ((r7 is p09213d05$pe7110545$1) == true) goto L15;
    L73:
        p09213d05$pe7110545$1 r0 = new p09213d05$pe7110545$1(this, r7);
    L23:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        string r3 = null;
        if (r2 == 0) goto L77;
        if (r2 == 1) goto L103;
        if (r2 != 2) goto L51;
        ResultKt.throwOnFailure(r72);
    L66:
        Response r73 = (Response) r72;
        if (r73.isSuccessful() == false) goto L90;
        p064f49f0 r6 = (p064f49f0) r73.body();
        if (r6 is not null) goto L9;
    L107:
        if (r3 is null) goto L60;
        return r3;
    L60:
        return "";
    L9:
        r3 = r6.getAccessToken();
        goto L107
    L90:
        throw new Exception("Server Error");
    L51:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L103:
        p09213d05 this = (p09213d05) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L59:
        string r74 = (string) r72;
        p2e0b51db r62 = this.faf82ffae;
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        r72 = r62.getLKToken(r74, r0);
        if (r72 != r1) goto L66;
    L45:
        return r1;
    L77:
        ResultKt.throwOnFailure(r72);
        pda0b425a r75 = this.f88a0c5ab;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r72 = r75.getToken(r0);
        if (r72 == r1) goto L45;
    L15:
        r0 = (p09213d05$pe7110545$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L73;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L23
    }
}

