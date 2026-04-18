namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u000e\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006¨\u0006\u0007"}, d2 = {"Landroidx/privacysandbox/ads/adservices/adselection/ReportEventRequest$Ext10Impl$Companion;", "", "()V", "convertReportEventRequest", "Landroid/adservices/adselection/ReportEventRequest;", "request", "Landroidx/privacysandbox/ads/adservices/adselection/ReportEventRequest;", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ReportEventRequest$Ext10Impl$Companion {
    private ReportEventRequest$Ext10Impl$Companion() {
    }

    public ReportEventRequest$Ext10Impl$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly android.adservices.adselection.ReportEventRequest ConvertReportEventRequest(androidx.privacysandbox.ads.adservices.adselection.ReportEventRequest request) {
        if ((28 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(request, "request");
        android.adservices.adselection.ReportEventRequest reportEventRequestBuild = new android.adservices.adselection.ReportEventRequest$Builder(request.getAdSelectionId(), request.getEventKey(), request.getEventData(), request.getReportingDestinations()).setInputEvent(request.getInputEvent()).build();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(reportEventRequestBuild, "Builder(\n               …                 .build()");
        return reportEventRequestBuild;
    }
}

