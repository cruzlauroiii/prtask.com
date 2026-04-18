namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u000e\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u0007H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\t"}, d2 = {"Lpad5f82e8/pac143fb7/p57cb773a/p417af4b8;", "Lpad5f82e8/pac143fb7/p57cb773a/p701d673c;", "maintenanceModeRepository", "Lp8d777f38/pb3f20355/p57cb773a/p4137a968;", "<init>", "(Lp8d777f38/pb3f20355/p57cb773a/p4137a968;)V", "isMaintenanceModeEnabledState", "Lkotlinx/coroutines/flow/Flow;", "", "common-domain-usecase_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p417af4b8 : pad5f82e8.pac143fb7.p57cb773a.p701d673c {
    private readonly p8d777f38.pb3f20355.p57cb773a.p4137a968 f28a72c29;
    private readonly p8d777f38.pb3f20355.p57cb773a.p4137a968 f6768cabf;

    public p417af4b8(p8d777f38.pb3f20355.p57cb773a.p4137a968 p4137a968Var) {
        TDmsFhZAdoXpxdch(p4137a968Var, "maintenanceModeRepository");
        this.f6768cabf = p4137a968Var;
    }

    public static void TDmsFhZAdoXpxdch(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlinx.coroutines.flow.Flow PXpWsQRHITMnqkGu(p8d777f38.pb3f20355.p57cb773a.p4137a968 p4137a968Var) {
        return p4137a968Var.isMaintenanceModeEnabledState();
    }

    public override kotlinx.coroutines.flow.Flow<java.lang.bool> IsMaintenanceModeEnabledState() {
        return pXpWsQRHITMnqkGu(this.f6768cabf);
    }
}

