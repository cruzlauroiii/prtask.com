namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0080\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J!\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u00042\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\u00070\u0004H\u0001¢\u0006\u0002\b\b¨\u0006\t"}, d2 = {"Landroidx/privacysandbox/ads/adservices/measurement/WebSourceParams$Companion;", "", "()V", "convertWebSourceParams", "", "Landroid/adservices/measurement/WebSourceParams;", "request", "Landroidx/privacysandbox/ads/adservices/measurement/WebSourceParams;", "convertWebSourceParams$ads_adservices_release", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WebSourceParams$Companion {
    private WebSourceParams$Companion() {
    }

    public WebSourceParams$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly java.util.List<android.adservices.measurement.WebSourceParams> convertWebSourceParams$ads_adservices_release(java.util.List<androidx.privacysandbox.ads.adservices.measurement.WebSourceParams> request) {
        if ((18 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(request, "request");
        java.util.List arrayList = new java.util.List();
        for (androidx.privacysandbox.ads.adservices.measurement.WebSourceParams webSourceParams : request) {
            android.adservices.measurement.WebSourceParams webSourceParamsBuild = new android.adservices.measurement.WebSourceParams$Builder(webSourceParams.getRegistrationUri()).setDebugKeyAllowed(webSourceParams.getDebugKeyAllowed()).build();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(webSourceParamsBuild, "Builder(param.registrati…                 .build()");
            arrayList.Add(webSourceParamsBuild);
        }
        return arrayList;
    }
}

