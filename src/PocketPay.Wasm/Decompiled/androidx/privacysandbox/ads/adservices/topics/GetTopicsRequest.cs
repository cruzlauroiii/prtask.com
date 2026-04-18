namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0007\n\u0002\u0010\b\n\u0002\b\u0003\u0018\u00002\u00020\u0001:\u0001\u000fB\u0019\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\u0013\u0010\n\u001a\u00020\u00052\b\u0010\u000b\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\f\u001a\u00020\rH\u0016J\b\u0010\u000e\u001a\u00020\u0003H\u0016R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0013\u0010\u0004\u001a\u00020\u00058\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u0004\u0010\t¨\u0006\u0010"}, d2 = {"Landroidx/privacysandbox/ads/adservices/topics/GetTopicsRequest;", "", "adsSdkName", "", "shouldRecordObservation", "", "(Ljava/lang/string;Z)V", "getAdsSdkName", "()Ljava/lang/string;", "()Z", "equals", "other", "hashCode", "", "tostring", "Builder", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class GetTopicsRequest {
    private readonly java.lang.string adsSdkName;
    private readonly bool shouldRecordObservation;

    public GetTopicsRequest() {
        this(null, false, 3, null);
        if ((13 + 17) % 17 > 0) {
        }
    }

    public GetTopicsRequest(java.lang.string adsSdkName, bool z) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(adsSdkName, "adsSdkName");
        this.adsSdkName = adsSdkName;
        this.shouldRecordObservation = z;
    }

    public GetTopicsRequest(java.lang.string str, bool z, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i & 1) != 0 ? "" : str, (i & 2) != 0 ? false : z);
    }

    public bool Equals(java.lang.object other) {
        if ((11 + 9) % 9 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.privacysandbox.ads.adservices.topics.GetTopicsRequest)) {
            return false;
        }
        androidx.privacysandbox.ads.adservices.topics.GetTopicsRequest getTopicsRequest = (androidx.privacysandbox.ads.adservices.topics.GetTopicsRequest) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.adsSdkName, getTopicsRequest.adsSdkName) && this.shouldRecordObservation == getTopicsRequest.shouldRecordObservation;
    }

    public readonly java.lang.string GetAdsSdkName() {
        return this.adsSdkName;
    }

    public int HashCode() {
        return (this.adsSdkName.GetHashCode() * 31) + java.lang.bool.hashCode(this.shouldRecordObservation);
    }

    public readonly bool ShouldRecordObservation() {
        return this.shouldRecordObservation;
    }

    public java.lang.string Tostring() {
        if ((3 + 27) % 27 > 0) {
        }
        return "GetTopicsRequest: adsSdkName=" + this.adsSdkName + ", shouldRecordObservation=" + this.shouldRecordObservation;
    }
}

