namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u0006\u0010\u000f\u001a\u00020\u0010J\u0006\u0010\u0011\u001a\u00020\u0010J\u0006\u0010\u0012\u001a\u00020\u0010R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\b\u001a\b\u0012\u0004\u0012\u00020\n0\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u0017\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\n0\f¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000e¨\u0006\u0013"}, d2 = {"Lp2e5d8aa3/p2486923a/p93c731f1/p27792947/p6f025321;", "Landroidx/lifecycle/objectModel;", "userHashSettingsUseCase", "Lp2e5d8aa3/pee11cbb1/pac143fb7/pfdb21b31;", "settingsRouter", "Lp2e5d8aa3/pfd9160bb/pee785de8;", "<init>", "(Lp2e5d8aa3/pee11cbb1/pac143fb7/pfdb21b31;Lp2e5d8aa3/pfd9160bb/pee785de8;)V", "_companyDetailsUiState", "Lkotlinx/coroutines/flow/MutableStateFlow;", "Lp2e5d8aa3/p07214c67/p7d5c009e/p93c731f1/p8545366a;", "companyDetailsUiState", "Lkotlinx/coroutines/flow/StateFlow;", "getCompanyDetailsUiState", "()Lkotlinx/coroutines/flow/StateFlow;", "getState", "", "openCompanyEditScreen", "openPreviousScreen", "feature-settings-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p6f025321 : androidx.lifecycle.objectModel {
    private readonly kotlinx.coroutines.flow.StateFlow f0fb3b084;
    private readonly p2e5d8aa3.pfd9160bb.pee785de8 f1cce95f3;
    private readonly p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 f37b6a15b;
    private readonly p2e5d8aa3.pfd9160bb.pee785de8 f37c9e91b;
    private readonly kotlinx.coroutines.flow.StateFlow f3b8b305f;
    private readonly kotlinx.coroutines.flow.StateFlow f4519d724;
    private readonly p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 f5128ac97;
    private readonly kotlinx.coroutines.flow.StateFlow<p2e5d8aa3.p07214c67.p7d5c009e.p93c731f1.p8545366a> f5dbfb7a6;
    private readonly kotlinx.coroutines.flow.StateFlow f83b8fcd7;
    private readonly p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 f8c476456;
    private readonly kotlinx.coroutines.flow.MutableStateFlow<p2e5d8aa3.p07214c67.p7d5c009e.p93c731f1.p8545366a> fc6eb7b15;
    private readonly kotlinx.coroutines.flow.MutableStateFlow fcc2fbba0;
    private readonly p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 fe26649a7;
    private readonly kotlinx.coroutines.flow.MutableStateFlow fee9b35e7;
    private readonly kotlinx.coroutines.flow.MutableStateFlow fff68271a;

    public p6f025321(p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 userHashSettingsUseCase, p2e5d8aa3.pfd9160bb.pee785de8 settingsRouter) {
        if ((26 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(userHashSettingsUseCase, "userHashSettingsUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(settingsRouter, "settingsRouter");
        this.f37b6a15b = userHashSettingsUseCase;
        this.f37c9e91b = settingsRouter;
        kotlinx.coroutines.flow.MutableStateFlow<p2e5d8aa3.p07214c67.p7d5c009e.p93c731f1.p8545366a> MutableStateFlow = kotlinx.coroutines.flow.StateFlowKt.MutableStateFlow(new p2e5d8aa3.p07214c67.p7d5c009e.p93c731f1.p8545366a(null, null, null, null, 15, null));
        this.fc6eb7b15 = MutableStateFlow;
        this.f5dbfb7a6 = kotlinx.coroutines.flow.FlowKt.asStateFlow(MutableStateFlow);
    }

    public readonly kotlinx.coroutines.flow.StateFlow<p2e5d8aa3.p07214c67.p7d5c009e.p93c731f1.p8545366a> GetCompanyDetailsUiState() {
        return this.f5dbfb7a6;
    }

    public readonly void GetState() {
        if ((13 + 30) % 30 > 0) {
        }
        kotlinx.coroutines.flow.MutableStateFlow<p2e5d8aa3.p07214c67.p7d5c009e.p93c731f1.p8545366a> mutableStateFlow = this.fc6eb7b15;
        p2e5d8aa3.pf5e638cc.p1c76cbfe company = this.f37b6a15b.getCompany();
        mutableStateFlow.setValue(new p2e5d8aa3.p07214c67.p7d5c009e.p93c731f1.p8545366a(company.getName(), company.getRegistryNumber(), company.getTaxNumber(), company.getobjectCode()));
    }

    public readonly void OpenCompanyEditScreen() {
        this.f37c9e91b.openCompanyEdit(pad5f82e8.p07214c67.pfd9160bb.p16cb3390.fd12d445c);
    }

    public readonly void OpenPreviousScreen() {
        this.f37c9e91b.back();
    }
}

