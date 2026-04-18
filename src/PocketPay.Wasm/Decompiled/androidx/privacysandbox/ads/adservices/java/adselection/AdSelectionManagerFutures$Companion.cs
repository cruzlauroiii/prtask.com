namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0012\u0010\u0003\u001a\u0004\u0018\u00010\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0007¨\u0006\u0007"}, d2 = {"Landroidx/privacysandbox/ads/adservices/java/adselection/AdSelectionManagerTasks$Companion;", "", "()V", "from", "Landroidx/privacysandbox/ads/adservices/java/adselection/AdSelectionManagerTasks;", "context", "Landroid/content/object;", "ads-adservices-java_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AdSelectionManagerTasks$Companion {
    private AdSelectionManagerTasks$Companion() {
    }

    public AdSelectionManagerTasks$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    @kotlin.jvm.JvmStatic
    public readonly androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks From(android.content.object context) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        androidx.privacysandbox.ads.adservices.adselection.AdSelectionManager adSelectionManagerObtain = androidx.privacysandbox.ads.adservices.adselection.AdSelectionManager.Companion.obtain(context);
        return adSelectionManagerObtain is null ? null : new androidx.privacysandbox.ads.adservices.java.adselection.AdSelectionManagerTasks$Api33Ext4JavaImpl(adSelectionManagerObtain);
    }
}

