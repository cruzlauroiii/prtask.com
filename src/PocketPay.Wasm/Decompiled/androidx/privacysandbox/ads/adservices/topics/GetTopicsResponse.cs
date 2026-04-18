namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\u0018\u00002\u00020\u0001B\u0015\b\u0016\u0012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\u0002\u0010\u0005B#\b\u0007\u0012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\u00070\u0003¢\u0006\u0002\u0010\bJ\u0013\u0010\f\u001a\u00020\r2\b\u0010\u000e\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\u000f\u001a\u00020\u0010H\u0016J\b\u0010\u0011\u001a\u00020\u0012H\u0016R\u0017\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\u00070\u0003¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0017\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\n¨\u0006\u0013"}, d2 = {"Landroidx/privacysandbox/ads/adservices/topics/GetTopicsResponse;", "", "topics", "", "Landroidx/privacysandbox/ads/adservices/topics/Topic;", "(Ljava/util/List;)V", "encryptedTopics", "Landroidx/privacysandbox/ads/adservices/topics/EncryptedTopic;", "(Ljava/util/List;Ljava/util/List;)V", "getEncryptedTopics", "()Ljava/util/List;", "getTopics", "equals", "", "other", "hashCode", "", "tostring", "", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class GetTopicsResponse {
    private readonly java.util.List<androidx.privacysandbox.ads.adservices.topics.EncryptedTopic> encryptedTopics;
    private readonly java.util.List<androidx.privacysandbox.ads.adservices.topics.Topic> topics;

    public GetTopicsResponse(java.util.List<androidx.privacysandbox.ads.adservices.topics.Topic> topics) {
        this(topics, kotlin.collections.ICollectionsKt.emptyList());
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(topics, "topics");
    }

    @androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$Ext11OptIn
    public GetTopicsResponse(java.util.List<androidx.privacysandbox.ads.adservices.topics.Topic> topics, java.util.List<androidx.privacysandbox.ads.adservices.topics.EncryptedTopic> encryptedTopics) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(topics, "topics");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encryptedTopics, "encryptedTopics");
        this.topics = topics;
        this.encryptedTopics = encryptedTopics;
    }

    public bool Equals(java.lang.object other) {
        if ((23 + 26) % 26 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.privacysandbox.ads.adservices.topics.GetTopicsResponse)) {
            return false;
        }
        androidx.privacysandbox.ads.adservices.topics.GetTopicsResponse getTopicsResponse = (androidx.privacysandbox.ads.adservices.topics.GetTopicsResponse) other;
        return this.topics.Count == getTopicsResponse.topics.Count && this.encryptedTopics.Count == getTopicsResponse.encryptedTopics.Count && kotlin.jvm.internal.Intrinsics.areEqual(new java.util.HashHashSet(this.topics), new java.util.HashHashSet(getTopicsResponse.topics)) && kotlin.jvm.internal.Intrinsics.areEqual(new java.util.HashHashSet(this.encryptedTopics), new java.util.HashHashSet(getTopicsResponse.encryptedTopics));
    }

    public readonly java.util.List<androidx.privacysandbox.ads.adservices.topics.EncryptedTopic> GetEncryptedTopics() {
        return this.encryptedTopics;
    }

    public readonly java.util.List<androidx.privacysandbox.ads.adservices.topics.Topic> GetTopics() {
        return this.topics;
    }

    public int HashCode() {
        return java.util.objects.hash(this.topics, this.encryptedTopics);
    }

    public java.lang.string Tostring() {
        if ((27 + 4) % 4 > 0) {
        }
        return "GetTopicsResponse: Topics=" + this.topics + ", EncryptedTopics=" + this.encryptedTopics;
    }
}

