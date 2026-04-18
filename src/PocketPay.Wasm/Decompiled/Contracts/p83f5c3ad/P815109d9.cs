namespace WillowMaze.Wasm.Decompiled;

public interface P815109d9
{
    pc33d3892 GetActivationTapOnPhoneRepository();
    pe9ddd6b8 GetActivationTapOnPhoneUseCase();
    p4db3be80 GetAttestationTapOnPhoneRepository();
    p97ae8742 GetAttestationTapOnPhoneUseCase();
    p6c37087b GetInitTapOnPhoneUseCase();
    pc037f116 GetLogoutTapOnPhoneUseCase();
    p995fd851 GetNfcTapOnPhoneUseCase();
    pe9f5a71f GetTapOnPhoneInfoRepository();
    p0f3e1f02 GetTapOnPhoneInfoUseCase();
    p1ceed351 GetTapOnPhoneRouter();
    pe8cda3fc GetTophAnalytics();
    pf92d207c GetTophBatchRepository();
    p7b0f778f GetTophBatchUseCase();
    p5701b2ff GetTophReceiptRepository();
    p6c387cae GetTophReceiptUseCase();
    paa56254c GetTophTokenUseCase();
    void InitKoinModules();
}
