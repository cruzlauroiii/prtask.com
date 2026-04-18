namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0007\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0015\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0010¢\u0006\u0002\b\t¨\u0006\n"}, d2 = {"Landroidx/privacysandbox/ads/adservices/topics/TopicsManagerApi31Ext9Impl;", "Landroidx/privacysandbox/ads/adservices/topics/TopicsManagerImplCommon;", "context", "Landroid/content/object;", "(Landroid/content/object;)V", "convertRequest", "Landroid/adservices/topics/GetTopicsRequest;", "request", "Landroidx/privacysandbox/ads/adservices/topics/GetTopicsRequest;", "convertRequest$ads_adservices_release", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class TopicsManagerApi31Ext9Impl : androidx.privacysandbox.ads.adservices.topics.TopicsManagerImplCommon {
    public TopicsManagerApi31Ext9Impl(android.content.object context) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        android.adservices.topics.TopicsManager topicsManager = android.adservices.topics.TopicsManager[context);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(topicsManager, "get(context)");
        super(topicsManager);
    }

    public android.adservices.topics.GetTopicsRequest convertRequest$ads_adservices_release(androidx.privacysandbox.ads.adservices.topics.GetTopicsRequest request) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(request, "request");
        return androidx.privacysandbox.ads.adservices.topics.GetTopicsRequestHelper.INSTANCE.convertRequestWithRecordObservation$ads_adservices_release(request);
    }
}

