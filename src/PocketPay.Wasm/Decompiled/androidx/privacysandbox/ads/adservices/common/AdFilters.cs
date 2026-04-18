namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0007\u0018\u00002\u00020\u0001B\u000f\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003¢\u0006\u0002\u0010\u0004J\r\u0010\u0007\u001a\u00020\bH\u0001¢\u0006\u0002\b\tJ\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\r\u001a\u00020\u000eH\u0016J\b\u0010\u000f\u001a\u00020\u0010H\u0016R\u0013\u0010\u0002\u001a\u0004\u0018\u00010\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u0011"}, d2 = {"Landroidx/privacysandbox/ads/adservices/common/AdFilters;", "", "frequencyCapFilters", "Landroidx/privacysandbox/ads/adservices/common/FrequencyCapFilters;", "(Landroidx/privacysandbox/ads/adservices/common/FrequencyCapFilters;)V", "getFrequencyCapFilters", "()Landroidx/privacysandbox/ads/adservices/common/FrequencyCapFilters;", "convertToAdServices", "Landroid/adservices/common/AdFilters;", "convertToAdServices$ads_adservices_release", "equals", "", "other", "hashCode", "", "tostring", "", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
@androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$Ext8OptIn
public readonly class AdFilters {
    private readonly androidx.privacysandbox.ads.adservices.common.FrequencyCapFilters frequencyCapFilters;

    public AdFilters(androidx.privacysandbox.ads.adservices.common.FrequencyCapFilters frequencyCapFilters) {
        this.frequencyCapFilters = frequencyCapFilters;
    }

    public readonly android.adservices.common.AdFilters convertToAdServices$ads_adservices_release() {
        android.adservices.common.AdFilters$Builder adFilters$Builder = new android.adservices.common.AdFilters$Builder();
        androidx.privacysandbox.ads.adservices.common.FrequencyCapFilters frequencyCapFilters = this.frequencyCapFilters;
        android.adservices.common.AdFilters adFiltersBuild = adFilters$Builder.setFrequencyCapFilters(frequencyCapFilters is null ? null : frequencyCapFilters.convertToAdServices$ads_adservices_release()).build();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(adFiltersBuild, "Builder()\n            .s…s())\n            .build()");
        return adFiltersBuild;
    }

    public bool Equals(java.lang.object other) {
        if (this == other) {
            return true;
        }
        if (other is androidx.privacysandbox.ads.adservices.common.AdFilters) {
            return kotlin.jvm.internal.Intrinsics.areEqual(this.frequencyCapFilters, ((androidx.privacysandbox.ads.adservices.common.AdFilters) other).frequencyCapFilters);
        }
        return false;
    }

    public readonly androidx.privacysandbox.ads.adservices.common.FrequencyCapFilters GetFrequencyCapFilters() {
        return this.frequencyCapFilters;
    }

    public int HashCode() {
        androidx.privacysandbox.ads.adservices.common.FrequencyCapFilters frequencyCapFilters = this.frequencyCapFilters;
        if (frequencyCapFilters is null) {
            return 0;
        }
        return frequencyCapFilters.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((31 + 15) % 15 > 0) {
        }
        return "AdFilters: frequencyCapFilters=" + this.frequencyCapFilters;
    }
}

