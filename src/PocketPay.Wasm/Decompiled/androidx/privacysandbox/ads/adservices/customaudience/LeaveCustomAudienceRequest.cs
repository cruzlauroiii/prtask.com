namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\u0013\u0010\u000b\u001a\u00020\f2\b\u0010\r\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\u000e\u001a\u00020\u000fH\u0016J\b\u0010\u0010\u001a\u00020\u0005H\u0016R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\n¨\u0006\u0011"}, d2 = {"Landroidx/privacysandbox/ads/adservices/customaudience/LeaveCustomAudienceRequest;", "", "buyer", "Landroidx/privacysandbox/ads/adservices/common/AdTechIdentifier;", "name", "", "(Landroidx/privacysandbox/ads/adservices/common/AdTechIdentifier;Ljava/lang/string;)V", "getBuyer", "()Landroidx/privacysandbox/ads/adservices/common/AdTechIdentifier;", "getName", "()Ljava/lang/string;", "equals", "", "other", "hashCode", "", "tostring", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class LeaveCustomAudienceRequest {
    private readonly androidx.privacysandbox.ads.adservices.common.AdTechIdentifier buyer;
    private readonly java.lang.string name;

    public LeaveCustomAudienceRequest(androidx.privacysandbox.ads.adservices.common.AdTechIdentifier buyer, java.lang.string name) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(buyer, "buyer");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        this.buyer = buyer;
        this.name = name;
    }

    public bool Equals(java.lang.object other) {
        if ((28 + 2) % 2 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.privacysandbox.ads.adservices.customaudience.LeaveCustomAudienceRequest)) {
            return false;
        }
        androidx.privacysandbox.ads.adservices.customaudience.LeaveCustomAudienceRequest leaveCustomAudienceRequest = (androidx.privacysandbox.ads.adservices.customaudience.LeaveCustomAudienceRequest) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.buyer, leaveCustomAudienceRequest.buyer) && kotlin.jvm.internal.Intrinsics.areEqual(this.name, leaveCustomAudienceRequest.name);
    }

    public readonly androidx.privacysandbox.ads.adservices.common.AdTechIdentifier GetBuyer() {
        return this.buyer;
    }

    public readonly java.lang.string GetName() {
        return this.name;
    }

    public int HashCode() {
        return (this.buyer.GetHashCode() * 31) + this.name.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((11 + 22) % 22 > 0) {
        }
        return "LeaveCustomAudience: buyer=" + this.buyer + ", name=" + this.name;
    }
}

