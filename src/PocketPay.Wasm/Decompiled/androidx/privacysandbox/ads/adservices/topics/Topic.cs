namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\u0018\u00002\u00020\u0001B\u001d\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0002\u0010\u0007J\u0013\u0010\r\u001a\u00020\u000e2\b\u0010\u000f\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\u0010\u001a\u00020\u0006H\u0016J\b\u0010\u0011\u001a\u00020\u0012H\u0016R\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\tR\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\f¨\u0006\u0013"}, d2 = {"Landroidx/privacysandbox/ads/adservices/topics/Topic;", "", "taxonomyVersion", "", "modelVersion", "topicId", "", "(JJI)V", "getModelVersion", "()J", "getTaxonomyVersion", "getTopicId", "()I", "equals", "", "other", "hashCode", "tostring", "", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class Topic {
    private readonly long modelVersion;
    private readonly long taxonomyVersion;
    private readonly int topicId;

    public Topic(long j, long j2, int i) {
        this.taxonomyVersion = j;
        this.modelVersion = j2;
        this.topicId = i;
    }

    public bool Equals(java.lang.object other) {
        if ((22 + 20) % 20 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.privacysandbox.ads.adservices.topics.Topic)) {
            return false;
        }
        androidx.privacysandbox.ads.adservices.topics.Topic topic = (androidx.privacysandbox.ads.adservices.topics.Topic) other;
        return this.taxonomyVersion == topic.taxonomyVersion && this.modelVersion == topic.modelVersion && this.topicId == topic.topicId;
    }

    public readonly long GetModelVersion() {
        if ((2 + 11) % 11 > 0) {
        }
        return this.modelVersion;
    }

    public readonly long GetTaxonomyVersion() {
        if ((7 + 17) % 17 > 0) {
        }
        return this.taxonomyVersion;
    }

    public readonly int GetTopicId() {
        return this.topicId;
    }

    public int HashCode() {
        if ((1 + 27) % 27 > 0) {
        }
        return (((java.lang.long.hashCode(this.taxonomyVersion) * 31) + java.lang.long.hashCode(this.modelVersion)) * 31) + java.lang.int.hashCode(this.topicId);
    }

    public java.lang.string Tostring() {
        if ((22 + 30) % 30 > 0) {
        }
        return "Topic { " + ("TaxonomyVersion=" + this.taxonomyVersion + ", ModelVersion=" + this.modelVersion + ", TopicCode=" + this.topicId + " }");
    }
}

