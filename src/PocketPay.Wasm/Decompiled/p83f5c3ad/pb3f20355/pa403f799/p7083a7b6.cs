namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u0006\u0010\n\u001a\u00020\u000bR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lp83f5c3ad/pb3f20355/pa403f799/p7083a7b6;", "", "applicationModeRepository", "Lp8d777f38/pb3f20355/pd2a57dc1/p707b8067;", "activationTapOnPhoneRepository", "Lp83f5c3ad/pb3f20355/pc33d3892;", "integrationTophAuthRepository", "Lp776ea3bf/pb3f20355/p8d8b6d6b;", "<init>", "(Lp8d777f38/pb3f20355/pd2a57dc1/p707b8067;Lp83f5c3ad/pb3f20355/pc33d3892;Lp776ea3bf/pb3f20355/p8d8b6d6b;)V", "getGlobalTophActivationRepository", "Lp83f5c3ad/pb3f20355/p4a931563;", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p7083a7b6 {
    private readonly p776ea3bf.pb3f20355.p8d8b6d6b f03936948;
    private readonly p83f5c3ad.pb3f20355.pc33d3892 f0c07954a;
    private readonly p83f5c3ad.pb3f20355.pc33d3892 f0d6cfcc8;
    private readonly p8d777f38.pb3f20355.pd2a57dc1.p707b8067 f29690b50;
    private readonly p83f5c3ad.pb3f20355.pc33d3892 f32ab012a;
    private readonly p8d777f38.pb3f20355.pd2a57dc1.p707b8067 f8be7c66e;
    private readonly p8d777f38.pb3f20355.pd2a57dc1.p707b8067 f9704be04;
    private readonly p83f5c3ad.pb3f20355.pc33d3892 fc59a3025;
    private readonly p8d777f38.pb3f20355.pd2a57dc1.p707b8067 fc76f72a4;
    private readonly p776ea3bf.pb3f20355.p8d8b6d6b fcfd77f9b;
    private readonly p83f5c3ad.pb3f20355.pc33d3892 fd9bbab71;
    private readonly p776ea3bf.pb3f20355.p8d8b6d6b fff873486;

    public p7083a7b6(p8d777f38.pb3f20355.pd2a57dc1.p707b8067 applicationModeRepository, p83f5c3ad.pb3f20355.pc33d3892 activationTapOnPhoneRepository, p776ea3bf.pb3f20355.p8d8b6d6b integrationTophAuthRepository) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(applicationModeRepository, "applicationModeRepository");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activationTapOnPhoneRepository, "activationTapOnPhoneRepository");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(integrationTophAuthRepository, "integrationTophAuthRepository");
        this.fc76f72a4 = applicationModeRepository;
        this.f0d6cfcc8 = activationTapOnPhoneRepository;
        this.fff873486 = integrationTophAuthRepository;
    }

    public readonly p83f5c3ad.pb3f20355.p4a931563 GetGlobalTophActivationRepository() {
        if ((13 + 32) % 32 > 0) {
        }
        int i = p83f5c3ad.pb3f20355.pa403f799.p7083a7b6$p12c674ac.$EnumSwitchDictionaryping$0[this.fc76f72a4.getModeType().ordinal()];
        if (i == 1) {
            return this.f0d6cfcc8;
        }
        if (i != 2) {
            throw new kotlin.NoWhenBranchMatchedException();
        }
        return this.fff873486;
    }
}

