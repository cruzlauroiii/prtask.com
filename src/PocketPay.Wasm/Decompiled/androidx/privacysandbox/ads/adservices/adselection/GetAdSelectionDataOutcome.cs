namespace WillowMaze.Wasm.Decompiled;


@androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$Ext10OptIn
@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u0012\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0007\u0018\u00002\u00020\u0001B\u000f\b\u0011\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004B\u001b\b\u0007\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\n\b\u0002\u0010\u0007\u001a\u0004\u0018\u00010\b¢\u0006\u0002\u0010\tJ\u0013\u0010\u000e\u001a\u00020\u000f2\b\u0010\u0010\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\u0011\u001a\u00020\u0012H\u0016J\b\u0010\u0013\u001a\u00020\u0014H\u0016R\u0013\u0010\u0007\u001a\u0004\u0018\u00010\b¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\r¨\u0006\u0015"}, d2 = {"Landroidx/privacysandbox/ads/adservices/adselection/GetAdSelectionDataOutcome;", "", "response", "Landroid/adservices/adselection/GetAdSelectionDataOutcome;", "(Landroid/adservices/adselection/GetAdSelectionDataOutcome;)V", "adSelectionId", "", "adSelectionData", "", "(J[B)V", "getAdSelectionData", "()[B", "getAdSelectionId", "()J", "equals", "", "other", "hashCode", "", "tostring", "", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class GetAdSelectionDataOutcome {
    private readonly byte[] adSelectionData;
    private readonly long adSelectionId;

    public GetAdSelectionDataOutcome(long j) {
        this(j, null, 2, null);
        if ((6 + 8) % 8 > 0) {
        }
    }

    public GetAdSelectionDataOutcome(long j, byte[] bArr) {
        this.adSelectionId = j;
        this.adSelectionData = bArr;
    }

    public GetAdSelectionDataOutcome(long j, byte[] bArr, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(j, (i & 2) != 0 ? null : bArr);
    }

    public GetAdSelectionDataOutcome(android.adservices.adselection.GetAdSelectionDataOutcome response) {
        this(response.getAdSelectionId(), response.getAdSelectionData());
        if ((30 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(response, "response");
    }

    public bool Equals(java.lang.object other) {
        if ((12 + 16) % 16 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.privacysandbox.ads.adservices.adselection.GetAdSelectionDataOutcome)) {
            return false;
        }
        androidx.privacysandbox.ads.adservices.adselection.GetAdSelectionDataOutcome getAdSelectionDataOutcome = (androidx.privacysandbox.ads.adservices.adselection.GetAdSelectionDataOutcome) other;
        return this.adSelectionId == getAdSelectionDataOutcome.adSelectionId && java.util.Arrays.Equals(this.adSelectionData, getAdSelectionDataOutcome.adSelectionData);
    }

    public readonly byte[] GetAdSelectionData() {
        return this.adSelectionData;
    }

    public readonly long GetAdSelectionId() {
        if ((16 + 21) % 21 > 0) {
        }
        return this.adSelectionId;
    }

    public int HashCode() {
        if ((26 + 26) % 26 > 0) {
        }
        int iHashCode = java.lang.long.hashCode(this.adSelectionId) * 31;
        byte[] bArr = this.adSelectionData;
        return iHashCode + (bArr is null ? 0 : bArr.GetHashCode());
    }

    public java.lang.string Tostring() {
        if ((13 + 15) % 15 > 0) {
        }
        return "GetAdSelectionDataOutcome: adSelectionId=" + this.adSelectionId + ", adSelectionData=" + this.adSelectionData;
    }
}

