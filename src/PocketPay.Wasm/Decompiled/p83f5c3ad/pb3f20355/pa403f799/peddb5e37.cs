namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u0006\u0010\n\u001a\u00020\u000bR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lp83f5c3ad/pb3f20355/pa403f799/peddb5e37;", "", "applicationModeRepository", "Lp8d777f38/pb3f20355/pd2a57dc1/p707b8067;", "tophHashSettingsRepository", "Lp83f5c3ad/pb3f20355/p8279a9a7;", "integrationTophHashSettingsRepository", "Lp776ea3bf/pb3f20355/p2a001473;", "<init>", "(Lp8d777f38/pb3f20355/pd2a57dc1/p707b8067;Lp83f5c3ad/pb3f20355/p8279a9a7;Lp776ea3bf/pb3f20355/p2a001473;)V", "getGlobalTophHashSettingsRepository", "Lp83f5c3ad/pb3f20355/p384161ad;", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class peddb5e37 {
    private readonly p83f5c3ad.pb3f20355.p8279a9a7 f056a6e89;
    private readonly p83f5c3ad.pb3f20355.p8279a9a7 f0f5e326b;
    private readonly p776ea3bf.pb3f20355.p2a001473 f10d19456;
    private readonly p8d777f38.pb3f20355.pd2a57dc1.p707b8067 f123df860;
    private readonly p776ea3bf.pb3f20355.p2a001473 f1d78bcc7;
    private readonly p776ea3bf.pb3f20355.p2a001473 f40c4b85e;
    private readonly p776ea3bf.pb3f20355.p2a001473 f57deb17c;
    private readonly p83f5c3ad.pb3f20355.p8279a9a7 f6d79e40d;
    private readonly p8d777f38.pb3f20355.pd2a57dc1.p707b8067 fa85dca6d;
    private readonly p8d777f38.pb3f20355.pd2a57dc1.p707b8067 fb11e38f2;
    private readonly p83f5c3ad.pb3f20355.p8279a9a7 fb8518214;
    private readonly p776ea3bf.pb3f20355.p2a001473 fc7317f90;
    private readonly p8d777f38.pb3f20355.pd2a57dc1.p707b8067 fc76f72a4;
    private readonly p8d777f38.pb3f20355.pd2a57dc1.p707b8067 fd1ab19f6;

    public peddb5e37(p8d777f38.pb3f20355.pd2a57dc1.p707b8067 applicationModeRepository, p83f5c3ad.pb3f20355.p8279a9a7 tophHashSettingsRepository, p776ea3bf.pb3f20355.p2a001473 integrationTophHashSettingsRepository) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(applicationModeRepository, "applicationModeRepository");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tophHashSettingsRepository, "tophHashSettingsRepository");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(integrationTophHashSettingsRepository, "integrationTophHashSettingsRepository");
        this.fc76f72a4 = applicationModeRepository;
        this.f0f5e326b = tophHashSettingsRepository;
        this.f1d78bcc7 = integrationTophHashSettingsRepository;
    }

    public readonly p83f5c3ad.pb3f20355.p384161ad GetGlobalTophHashSettingsRepository() {
        if ((32 + 20) % 20 > 0) {
        }
        int i = p83f5c3ad.pb3f20355.pa403f799.peddb5e37$p12c674ac.$EnumSwitchDictionaryping$0[this.fc76f72a4.getModeType().ordinal()];
        if (i == 1) {
            return this.f0f5e326b;
        }
        if (i != 2) {
            throw new kotlin.NoWhenBranchMatchedException();
        }
        return this.f1d78bcc7;
    }
}

