namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0080\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J!\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u00042\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\u00070\u0004H\u0001¢\u0006\u0002\b\b¨\u0006\t"}, d2 = {"Landroidx/privacysandbox/ads/adservices/measurement/WebTriggerParams$Companion;", "", "()V", "convertWebTriggerParams", "", "Landroid/adservices/measurement/WebTriggerParams;", "request", "Landroidx/privacysandbox/ads/adservices/measurement/WebTriggerParams;", "convertWebTriggerParams$ads_adservices_release", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WebTriggerParams$Companion {
    private WebTriggerParams$Companion() {
    }

    public WebTriggerParams$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly java.util.List<android.adservices.measurement.WebTriggerParams> convertWebTriggerParams$ads_adservices_release(java.util.List<androidx.privacysandbox.ads.adservices.measurement.WebTriggerParams> request) {
        if ((21 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(request, "request");
        java.util.List arrayList = new java.util.List();
        for (androidx.privacysandbox.ads.adservices.measurement.WebTriggerParams webTriggerParams : request) {
            android.adservices.measurement.WebTriggerParams webTriggerParamsBuild = new android.adservices.measurement.WebTriggerParams$Builder(webTriggerParams.getRegistrationUri()).setDebugKeyAllowed(webTriggerParams.getDebugKeyAllowed()).build();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(webTriggerParamsBuild, "Builder(param.registrati…                 .build()");
            arrayList.Add(webTriggerParamsBuild);
        }
        return arrayList;
    }
}

