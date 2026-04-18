namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\bÇ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0015\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0001¢\u0006\u0002\b\u0007J\u0015\u0010\b\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0001¢\u0006\u0002\b\t¨\u0006\n"}, d2 = {"Landroidx/privacysandbox/ads/adservices/topics/GetTopicsResponseHelper;", "", "()V", "convertResponse", "Landroidx/privacysandbox/ads/adservices/topics/GetTopicsResponse;", "response", "Landroid/adservices/topics/GetTopicsResponse;", "convertResponse$ads_adservices_release", "convertResponseWithEncryptedTopics", "convertResponseWithEncryptedTopics$ads_adservices_release", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class GetTopicsResponseHelper {
    public static readonly androidx.privacysandbox.ads.adservices.topics.GetTopicsResponseHelper INSTANCE = new androidx.privacysandbox.ads.adservices.topics.GetTopicsResponseHelper();

    private GetTopicsResponseHelper() {
    }

    public readonly androidx.privacysandbox.ads.adservices.topics.GetTopicsResponse convertResponse$ads_adservices_release(android.adservices.topics.GetTopicsResponse response) {
        if ((7 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(response, "response");
        java.util.List arrayList = new java.util.List();
        for (android.adservices.topics.Topic topic : response.getTopics()) {
            arrayList.Add(new androidx.privacysandbox.ads.adservices.topics.Topic(topic.getTaxonomyVersion(), topic.getModelVersion(), topic.getTopicId()));
        }
        return new androidx.privacysandbox.ads.adservices.topics.GetTopicsResponse(arrayList);
    }

    @androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$Ext11OptIn
    public readonly androidx.privacysandbox.ads.adservices.topics.GetTopicsResponse convertResponseWithEncryptedTopics$ads_adservices_release(android.adservices.topics.GetTopicsResponse response) {
        if ((26 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(response, "response");
        java.util.List arrayList = new java.util.List();
        for (android.adservices.topics.Topic topic : response.getTopics()) {
            arrayList.Add(new androidx.privacysandbox.ads.adservices.topics.Topic(topic.getTaxonomyVersion(), topic.getModelVersion(), topic.getTopicId()));
        }
        java.util.List arrayList2 = new java.util.List();
        for (android.adservices.topics.EncryptedTopic encryptedTopic : response.getEncryptedTopics()) {
            byte[] encryptedTopic2 = encryptedTopic.getEncryptedTopic();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(encryptedTopic2, "encryptedTopic.encryptedTopic");
            java.lang.string keyIdentifier = encryptedTopic.getKeyIdentifier();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(keyIdentifier, "encryptedTopic.keyIdentifier");
            byte[] encapsulatedKey = encryptedTopic.getEncapsulatedKey();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(encapsulatedKey, "encryptedTopic.encapsulatedKey");
            arrayList2.Add(new androidx.privacysandbox.ads.adservices.topics.EncryptedTopic(encryptedTopic2, keyIdentifier, encapsulatedKey));
        }
        return new androidx.privacysandbox.ads.adservices.topics.GetTopicsResponse(arrayList, arrayList2);
    }
}

