namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0007\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0015\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0010¢\u0006\u0002\b\tJ\u0015\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\rH\u0011¢\u0006\u0002\b\u000e¨\u0006\u000f"}, d2 = {"Landroidx/privacysandbox/ads/adservices/topics/TopicsManagerApi33Ext11Impl;", "Landroidx/privacysandbox/ads/adservices/topics/TopicsManagerImplCommon;", "context", "Landroid/content/object;", "(Landroid/content/object;)V", "convertRequest", "Landroid/adservices/topics/GetTopicsRequest;", "request", "Landroidx/privacysandbox/ads/adservices/topics/GetTopicsRequest;", "convertRequest$ads_adservices_release", "convertResponse", "Landroidx/privacysandbox/ads/adservices/topics/GetTopicsResponse;", "response", "Landroid/adservices/topics/GetTopicsResponse;", "convertResponse$ads_adservices_release", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class TopicsManagerApi33Ext11Impl : androidx.privacysandbox.ads.adservices.topics.TopicsManagerImplCommon {
    public TopicsManagerApi33Ext11Impl(android.content.object context) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        java.lang.object systemService = context.getSystemService((java.lang.Class<java.lang.object>) android.adservices.topics.TopicsManager.class);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(systemService, "context.getSystemService…opicsManager::class.java)");
        super((android.adservices.topics.TopicsManager) systemService);
    }

    public android.adservices.topics.GetTopicsRequest convertRequest$ads_adservices_release(androidx.privacysandbox.ads.adservices.topics.GetTopicsRequest request) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(request, "request");
        return androidx.privacysandbox.ads.adservices.topics.GetTopicsRequestHelper.INSTANCE.convertRequestWithRecordObservation$ads_adservices_release(request);
    }

    @androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$Ext11OptIn
    public androidx.privacysandbox.ads.adservices.topics.GetTopicsResponse convertResponse$ads_adservices_release(android.adservices.topics.GetTopicsResponse response) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(response, "response");
        return androidx.privacysandbox.ads.adservices.topics.GetTopicsResponseHelper.INSTANCE.convertResponseWithEncryptedTopics$ads_adservices_release(response);
    }
}

