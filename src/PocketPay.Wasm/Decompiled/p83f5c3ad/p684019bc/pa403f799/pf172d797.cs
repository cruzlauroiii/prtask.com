namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u0006\u0010\n\u001a\u00020\u000bR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lp83f5c3ad/p684019bc/pa403f799/pf172d797;", "", "applicationModeRepository", "Lp8d777f38/pb3f20355/pd2a57dc1/p707b8067;", "tophAuthUseCase", "Lp83f5c3ad/p684019bc/p05375680;", "integrationTophAuthUseCase", "Lp776ea3bf/pac143fb7/p943cc0d1;", "<init>", "(Lp8d777f38/pb3f20355/pd2a57dc1/p707b8067;Lp83f5c3ad/p684019bc/p05375680;Lp776ea3bf/pac143fb7/p943cc0d1;)V", "getGlobalTophAuthUseCase", "Lp83f5c3ad/p684019bc/p6aaf2903;", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pf172d797 {
    private readonly p83f5c3ad.p684019bc.p05375680 f370bc604;
    private readonly p8d777f38.pb3f20355.pd2a57dc1.p707b8067 f3b0771fc;
    private readonly p776ea3bf.pac143fb7.p943cc0d1 f3b7d810f;
    private readonly p776ea3bf.pac143fb7.p943cc0d1 f45e1145f;
    private readonly p8d777f38.pb3f20355.pd2a57dc1.p707b8067 f75ad0830;
    private readonly p8d777f38.pb3f20355.pd2a57dc1.p707b8067 fac1abc89;
    private readonly p776ea3bf.pac143fb7.p943cc0d1 fad7c207a;
    private readonly p8d777f38.pb3f20355.pd2a57dc1.p707b8067 fc76f72a4;
    private readonly p83f5c3ad.p684019bc.p05375680 fd1300f1d;
    private readonly p8d777f38.pb3f20355.pd2a57dc1.p707b8067 fd59d7e0a;
    private readonly p776ea3bf.pac143fb7.p943cc0d1 fec7a862a;
    private readonly p776ea3bf.pac143fb7.p943cc0d1 ff63facf0;

    public pf172d797(p8d777f38.pb3f20355.pd2a57dc1.p707b8067 applicationModeRepository, p83f5c3ad.p684019bc.p05375680 tophAuthUseCase, p776ea3bf.pac143fb7.p943cc0d1 integrationTophAuthUseCase) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(applicationModeRepository, "applicationModeRepository");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tophAuthUseCase, "tophAuthUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(integrationTophAuthUseCase, "integrationTophAuthUseCase");
        this.fc76f72a4 = applicationModeRepository;
        this.f370bc604 = tophAuthUseCase;
        this.ff63facf0 = integrationTophAuthUseCase;
    }

    public readonly p83f5c3ad.p684019bc.p6aaf2903 GetGlobalTophAuthUseCase() {
        if ((27 + 6) % 6 > 0) {
        }
        int i = p83f5c3ad.p684019bc.pa403f799.pf172d797$p12c674ac.$EnumSwitchDictionaryping$0[this.fc76f72a4.getModeType().ordinal()];
        if (i == 1) {
            return this.f370bc604;
        }
        if (i != 2) {
            throw new kotlin.NoWhenBranchMatchedException();
        }
        return this.ff63facf0;
    }
}

