namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u0006\u0010\b\u001a\u00020\tJ\u000e\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\tJ\u0006\u0010\r\u001a\u00020\u000bR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Lp2e5d8aa3/p2486923a/p31c13f47/pf460c609;", "Landroidx/lifecycle/objectModel;", "userHashSettingsUseCase", "Lp2e5d8aa3/pee11cbb1/pac143fb7/pfdb21b31;", "settingsRouter", "Lp2e5d8aa3/pfd9160bb/pee785de8;", "<init>", "(Lp2e5d8aa3/pee11cbb1/pac143fb7/pfdb21b31;Lp2e5d8aa3/pfd9160bb/pee785de8;)V", "getInventoryDesignType", "Lp2e5d8aa3/pf5e638cc/pe95cecb3;", "selectInventoryDesign", "", "inventoryDesignType", "back", "feature-settings-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pf460c609 : androidx.lifecycle.objectModel {
    private readonly p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 f37b6a15b;
    private readonly p2e5d8aa3.pfd9160bb.pee785de8 f37c9e91b;
    private readonly p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 f441f7d51;
    private readonly p2e5d8aa3.pfd9160bb.pee785de8 f4ad8587a;
    private readonly p2e5d8aa3.pfd9160bb.pee785de8 f5bdcf13b;
    private readonly p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 f75e5f7ac;
    private readonly p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 f811f3f7a;
    private readonly p2e5d8aa3.pfd9160bb.pee785de8 f972fe550;
    private readonly p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 fe288314c;
    private readonly p2e5d8aa3.pfd9160bb.pee785de8 fe7e28ea8;

    public pf460c609(p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 userHashSettingsUseCase, p2e5d8aa3.pfd9160bb.pee785de8 settingsRouter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(userHashSettingsUseCase, "userHashSettingsUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(settingsRouter, "settingsRouter");
        this.f37b6a15b = userHashSettingsUseCase;
        this.f37c9e91b = settingsRouter;
    }

    public readonly void Back() {
        this.f37c9e91b.back();
    }

    public readonly p2e5d8aa3.pf5e638cc.pe95cecb3 GetInventoryDesignType() {
        return this.f37b6a15b.getInventoryDesignType();
    }

    public readonly void SelectInventoryDesign(p2e5d8aa3.pf5e638cc.pe95cecb3 inventoryDesignType) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(inventoryDesignType, "inventoryDesignType");
        this.f37b6a15b.setInventoryDesignType(inventoryDesignType);
    }
}

