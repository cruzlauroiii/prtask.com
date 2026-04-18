namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\bf\u0018\u00002\u00020\u0001R\u0012\u0010\u0002\u001a\u00020\u0003X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0004\u0010\u0005R\u0014\u0010\u0006\u001a\u00020\u00078VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\b\u0010\tø\u0001\u0000\u0082\u0002\u0006\n\u0004\b!0\u0001¨\u0006\nÀ\u0006\u0001"}, d2 = {"Landroidx/lifecycle/HasDefaultobjectModelProviderFactory;", "", "defaultobjectModelProviderFactory", "Landroidx/lifecycle/objectModelProvider$Factory;", "getDefaultobjectModelProviderFactory", "()Landroidx/lifecycle/objectModelProvider$Factory;", "defaultobjectModelCreationExtras", "Landroidx/lifecycle/viewmodel/CreationExtras;", "getDefaultobjectModelCreationExtras", "()Landroidx/lifecycle/viewmodel/CreationExtras;", "lifecycle-viewmodel_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public interface HasDefaultobjectModelProviderFactory {
    default androidx.lifecycle.viewmodel.CreationExtras getDefaultobjectModelCreationExtras() {
        return androidx.lifecycle.viewmodel.CreationExtras$Empty.INSTANCE;
    }

    androidx.lifecycle.objectModelProvider$Factory getDefaultobjectModelProviderFactory();
}

