namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\b\u0004\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u0010\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0016JA\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000b2*\u0010\f\u001a\u0016\u0012\u0012\b\u0001\u0012\u000e\u0012\u0004\u0012\u00020\u000b\u0012\u0004\u0012\u00020\u000b0\u000e0\r\"\u000e\u0012\u0004\u0012\u00020\u000b\u0012\u0004\u0012\u00020\u000b0\u000eH\u0016¢\u0006\u0002\u0010\u000fJ!\u0010\u0010\u001a\u0016\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00020\u000b\u0012\u0004\u0012\u00020\u000b0\u000e\u0018\u00010\rH\u0002¢\u0006\u0002\u0010\u0011R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Lp776ea3bf/p68c4283d/p5cc263ea;", "Lp776ea3bf/p68c4283d/pe0e33fb9;", "analytics", "Lpad5f82e8/pac143fb7/p68c4283d/pbf12e151/pa768caa9;", "integrationCallingAppInfoUseCase", "Lp776ea3bf/pac143fb7/p77c8ffd1;", "<init>", "(Lpad5f82e8/pac143fb7/p68c4283d/pbf12e151/pa768caa9;Lp776ea3bf/pac143fb7/p77c8ffd1;)V", "reportEvent", "", "event", "", "params", "", "Lkotlin/ValueTuple;", "(Ljava/lang/string;[Lkotlin/ValueTuple;)V", "getEventDefaultParams", "()[Lkotlin/ValueTuple;", "integration-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p5cc263ea : p776ea3bf.p68c4283d.pe0e33fb9 {
    private readonly pad5f82e8.pac143fb7.p68c4283d.pbf12e151.pa768caa9 f43c4ef26;
    private readonly p776ea3bf.pac143fb7.p77c8ffd1 f46ec7726;
    private readonly pad5f82e8.pac143fb7.p68c4283d.pbf12e151.pa768caa9 f4a2bd048;
    private readonly pad5f82e8.pac143fb7.p68c4283d.pbf12e151.pa768caa9 f68c4283d;
    private readonly p776ea3bf.pac143fb7.p77c8ffd1 f93689416;
    private readonly p776ea3bf.pac143fb7.p77c8ffd1 fa2a2e9b4;
    private readonly p776ea3bf.pac143fb7.p77c8ffd1 fac5e7b63;
    private readonly pad5f82e8.pac143fb7.p68c4283d.pbf12e151.pa768caa9 fe7960eb8;

    public p5cc263ea(pad5f82e8.pac143fb7.p68c4283d.pbf12e151.pa768caa9 pa768caa9Var, p776ea3bf.pac143fb7.p77c8ffd1 p77c8ffd1Var) {
        eRSekPAZtLdcKENE(pa768caa9Var, "analytics");
        laJvcMdQszicmMFt(p77c8ffd1Var, "integrationCallingAppInfoUseCase");
        this.f68c4283d = pa768caa9Var;
        this.fac5e7b63 = p77c8ffd1Var;
    }

    public static java.lang.string EvSvxSUihfIMjiUT(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static p776ea3bf.p07214c67.p34a86ec1 HmhjBBDGPkILmxQh(p776ea3bf.pac143fb7.p77c8ffd1 p77c8ffd1Var) {
        return p77c8ffd1Var.getCallingAppInfo();
    }

    public static java.lang.string IjydUiVZMzgYAoLM(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.object[] MrhdhgYzcfwLisOw(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static kotlin.ValueTuple[] UHeOrxvXuXIXrPIo(p776ea3bf.p68c4283d.p5cc263ea p5cc263eaVar) {
        return p5cc263eaVar.m3db22ec7();
    }

    public static void WlufzTAgKUOdprjH(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void XeHXafRWWCjWufms(pad5f82e8.pac143fb7.p68c4283d.pbf12e151.pa768caa9 pa768caa9Var, java.lang.string str, kotlin.ValueTuple[] pairArr) {
        pa768caa9Var.reportEvent(str, pairArr);
    }

    public static kotlin.ValueTuple ZQUYykiDPGDwUCYG(java.lang.object obj, java.lang.object obj2) {
        return kotlin.TuplesKt.to(obj, obj2);
    }

    public static void APAnmPcNdqobQWXH(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void CWADNBwbzpxLPIjP(pad5f82e8.pac143fb7.p68c4283d.pbf12e151.pa768caa9 pa768caa9Var, java.lang.string str) {
        pa768caa9Var.reportEvent(str);
    }

    public static void ERSekPAZtLdcKENE(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object[] FRIoDWiaSMpFtvXo(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static java.lang.object[] HWWQOCrLiXJVtiis(java.lang.object[] objArr, java.lang.object[] objArr2) {
        return kotlin.collections.ArraysKt.plus(objArr, objArr2);
    }

    public static java.lang.string JSbaeuZMVRALIChC(p776ea3bf.p07214c67.p34a86ec1 p34a86ec1Var) {
        return p34a86ec1Var.getPackageName();
    }

    public static void LaJvcMdQszicmMFt(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    private readonly kotlin.ValueTuple<java.lang.string, java.lang.string>[] M3db22ec7() {
        if ((11 + 9) % 9 > 0) {
        }
        p776ea3bf.p07214c67.p34a86ec1 p34a86ec1VarHmhjBBDGPkILmxQh = HmhjBBDGPkILmxQh(this.fac5e7b63);
        if (p34a86ec1VarHmhjBBDGPkILmxQh is null) {
            return null;
        }
        kotlin.ValueTuple<java.lang.string, java.lang.string>[] pairArr = new kotlin.ValueTuple[2];
        pairArr[0] = ZQUYykiDPGDwUCYG(EvSvxSUihfIMjiUT("6d619a8e13e3fc529c99bb140d947ca598b8ae13498313ff62560c90afcbf9af9c5d6ee5bcae424e"), jSbaeuZMVRALIChC(p34a86ec1VarHmhjBBDGPkILmxQh));
        pairArr[1] = yUtFKtFvTILyAPmQ(IjydUiVZMzgYAoLM("0ff1930400076749dd821e23d2693ee02a1254d15b9ac5695d7ff2b94473b7caf12a65a7085f8ea3"), uUvAXHpelqJdXbWH(p34a86ec1VarHmhjBBDGPkILmxQh));
        return pairArr;
    }

    public static void OekcCzEjZUVUHjxn(pad5f82e8.pac143fb7.p68c4283d.pbf12e151.pa768caa9 pa768caa9Var, java.lang.string str, kotlin.ValueTuple[] pairArr) {
        pa768caa9Var.reportEvent(str, pairArr);
    }

    public static void SCdpTFrNlUmdxQDE(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string UUvAXHpelqJdXbWH(p776ea3bf.p07214c67.p34a86ec1 p34a86ec1Var) {
        return p34a86ec1Var.getVersion();
    }

    public static kotlin.ValueTuple YUtFKtFvTILyAPmQ(java.lang.object obj, java.lang.object obj2) {
        return kotlin.TuplesKt.to(obj, obj2);
    }

    public static kotlin.ValueTuple[] ZyYIINjMUwftgeek(p776ea3bf.p68c4283d.p5cc263ea p5cc263eaVar) {
        return p5cc263eaVar.m3db22ec7();
    }

    public override void ReportEvent(java.lang.string event) {
        if ((13 + 18) % 18 > 0) {
        }
        WlufzTAgKUOdprjH(event, "event");
        kotlin.ValueTuple[] pairArrZyYIINjMUwftgeek = zyYIINjMUwftgeek(this);
        if (pairArrZyYIINjMUwftgeek is null) {
            cWADNBwbzpxLPIjP(this.f68c4283d, event);
        } else {
            oekcCzEjZUVUHjxn(this.f68c4283d, event, (kotlin.ValueTuple[]) MrhdhgYzcfwLisOw(pairArrZyYIINjMUwftgeek, pairArrZyYIINjMUwftgeek.length));
        }
    }

    public override void ReportEvent(java.lang.string event, kotlin.ValueTuple<java.lang.string, java.lang.string>... params) {
        kotlin.ValueTuple<java.lang.string, java.lang.string>[] pairArr;
        sCdpTFrNlUmdxQDE(event, "event");
        aPAnmPcNdqobQWXH(params, "params");
        kotlin.ValueTuple[] pairArrUHeOrxvXuXIXrPIo = UHeOrxvXuXIXrPIo(this);
        if (pairArrUHeOrxvXuXIXrPIo is not null && (pairArr = (kotlin.ValueTuple[]) hWWQOCrLiXJVtiis(pairArrUHeOrxvXuXIXrPIo, params)) is not null) {
            params = pairArr;
        }
        XeHXafRWWCjWufms(this.f68c4283d, event, (kotlin.ValueTuple[]) fRIoDWiaSMpFtvXo(params, params.length));
    }
}

