namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0010\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0016J\n\u0010\n\u001a\u0004\u0018\u00010\tH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000b"}, d2 = {"Lp776ea3bf/pac143fb7/pfc0cc2c0;", "Lp776ea3bf/pac143fb7/p77c8ffd1;", "integrationCallingAppInfoRepository", "Lp776ea3bf/pb3f20355/p8ad01aeb;", "<init>", "(Lp776ea3bf/pb3f20355/p8ad01aeb;)V", "setCallingAppInfo", "", "callingAppInfo", "Lp776ea3bf/p07214c67/p34a86ec1;", "getCallingAppInfo", "integration-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pfc0cc2c0 : p776ea3bf.pac143fb7.p77c8ffd1 {
    private readonly p776ea3bf.pb3f20355.p8ad01aeb f1bb0d3fb;
    private readonly p776ea3bf.pb3f20355.p8ad01aeb f3a944781;
    private readonly p776ea3bf.pb3f20355.p8ad01aeb fc9ab4c5f;
    private readonly p776ea3bf.pb3f20355.p8ad01aeb fcd9191ae;
    private readonly p776ea3bf.pb3f20355.p8ad01aeb fec1a1952;

    public pfc0cc2c0(p776ea3bf.pb3f20355.p8ad01aeb p8ad01aebVar) {
        iYoEUAJaPfpRVoym(p8ad01aebVar, "integrationCallingAppInfoRepository");
        this.fec1a1952 = p8ad01aebVar;
    }

    public static void DDMWfnYyrRrSmDcK(p776ea3bf.pb3f20355.p8ad01aeb p8ad01aebVar, p776ea3bf.p07214c67.p34a86ec1 p34a86ec1Var) {
        p8ad01aebVar.setCallingAppInfo(p34a86ec1Var);
    }

    public static void IYoEUAJaPfpRVoym(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void JJbSPSPrfYqRvtXu(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static p776ea3bf.p07214c67.p34a86ec1 YPnZChrkIbvDcgmW(p776ea3bf.pb3f20355.p8ad01aeb p8ad01aebVar) {
        return p8ad01aebVar.getCallingAppInfo();
    }

    public override p776ea3bf.p07214c67.p34a86ec1 GetCallingAppInfo() {
        return yPnZChrkIbvDcgmW(this.fec1a1952);
    }

    public override void SetCallingAppInfo(p776ea3bf.p07214c67.p34a86ec1 callingAppInfo) {
        jJbSPSPrfYqRvtXu(callingAppInfo, "callingAppInfo");
        DDMWfnYyrRrSmDcK(this.fec1a1952, callingAppInfo);
    }
}

