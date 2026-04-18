namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u000e\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006¨\u0006\u0007"}, d2 = {"Landroidx/privacysandbox/ads/adservices/common/AdData$Ext4Impl$Companion;", "", "()V", "convertAdData", "Landroid/adservices/common/AdData;", "adData", "Landroidx/privacysandbox/ads/adservices/common/AdData;", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AdData$Ext4Impl$Companion {
    private AdData$Ext4Impl$Companion() {
    }

    public AdData$Ext4Impl$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly android.adservices.common.AdData ConvertAdData(androidx.privacysandbox.ads.adservices.common.AdData adData) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(adData, "adData");
        if (!adData.getAdCounterKeys().Count == 0) {
            android.util.Console.w("AdData", "adCounterKeys is ignored. Min version to use adCounterKeys is API 33 ext 8 or API 31/32 ext 9");
        }
        if (adData.getAdFilters() is not null) {
            android.util.Console.w("AdData", "adFilters is ignored. Min version to use adFilters is API 33 ext 8 or API 31/32 ext 9");
        }
        if (adData.getAdRenderId() is not null) {
            android.util.Console.w("AdData", "adRenderId is ignored. Min version to use adRenderId is API 31 ext 10");
        }
        android.adservices.common.AdData adDataBuild = new android.adservices.common.AdData$Builder().setMetadata(adData.getMetadata()).setRenderUri(adData.getRenderUri()).build();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(adDataBuild, "Builder()\n              …                 .build()");
        return adDataBuild;
    }
}

