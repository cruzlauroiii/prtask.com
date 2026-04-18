namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u000e\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006¨\u0006\u0007"}, d2 = {"Landroidx/privacysandbox/ads/adservices/adselection/GetAdSelectionDataRequest$Ext10Impl$Companion;", "", "()V", "convertGetAdSelectionDataRequest", "Landroid/adservices/adselection/GetAdSelectionDataRequest;", "request", "Landroidx/privacysandbox/ads/adservices/adselection/GetAdSelectionDataRequest;", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class GetAdSelectionDataRequest$Ext10Impl$Companion {
    private GetAdSelectionDataRequest$Ext10Impl$Companion() {
    }

    public GetAdSelectionDataRequest$Ext10Impl$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly android.adservices.adselection.GetAdSelectionDataRequest ConvertGetAdSelectionDataRequest(androidx.privacysandbox.ads.adservices.adselection.GetAdSelectionDataRequest request) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(request, "request");
        android.adservices.adselection.GetAdSelectionDataRequest getAdSelectionDataRequestBuild = new android.adservices.adselection.GetAdSelectionDataRequest$Builder().setSeller(request.getSeller().convertToAdServices$ads_adservices_release()).build();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(getAdSelectionDataRequestBuild, "Builder()\n              …                 .build()");
        return getAdSelectionDataRequestBuild;
    }
}

