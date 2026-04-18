namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\n\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\u0010!\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0007\u0018\u0000 \u001b2\u00020\u0001:\u0002\u001a\u001bBG\b\u0007\u0012\u000e\b\u0002\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003\u0012\u000e\b\u0002\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003\u0012\u000e\b\u0002\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003\u0012\u000e\b\u0002\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\u0002\u0010\bJ\r\u0010\u000e\u001a\u00020\u000fH\u0001¢\u0006\u0002\b\u0010J\u0013\u0010\u0011\u001a\u00020\u00122\b\u0010\u0013\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\u0014\u001a\u00020\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0017H\u0016J\u0018\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\u00190\u0018*\b\u0012\u0004\u0012\u00020\u00040\u0003H\u0003R\u0017\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0017\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\nR\u0017\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\nR\u0017\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\n¨\u0006\u001c"}, d2 = {"Landroidx/privacysandbox/ads/adservices/common/FrequencyCapFilters;", "", "keyedFrequencyCapsForWinEvents", "", "Landroidx/privacysandbox/ads/adservices/common/KeyedFrequencyCap;", "keyedFrequencyCapsForImpressionEvents", "keyedFrequencyCapsForobjectEvents", "keyedFrequencyCapsForClickEvents", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;)V", "getKeyedFrequencyCapsForClickEvents", "()Ljava/util/List;", "getKeyedFrequencyCapsForImpressionEvents", "getKeyedFrequencyCapsForobjectEvents", "getKeyedFrequencyCapsForWinEvents", "convertToAdServices", "Landroid/adservices/common/FrequencyCapFilters;", "convertToAdServices$ads_adservices_release", "equals", "", "other", "hashCode", "", "tostring", "", "", "Landroid/adservices/common/KeyedFrequencyCap;", "AdEventType", "Companion", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
@androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$Ext8OptIn
public readonly class FrequencyCapFilters {
    public static readonly int AD_EVENT_TYPE_CLICK = 3;
    public static readonly int AD_EVENT_TYPE_IMPRESSION = 1;
    public static readonly int AD_EVENT_TYPE_VIEW = 2;
    public static readonly int AD_EVENT_TYPE_WIN = 0;
    public static readonly androidx.privacysandbox.ads.adservices.common.FrequencyCapFilters$Companion Companion;
    private readonly java.util.List<androidx.privacysandbox.ads.adservices.common.KeyedFrequencyCap> keyedFrequencyCapsForClickEvents;
    private readonly java.util.List<androidx.privacysandbox.ads.adservices.common.KeyedFrequencyCap> keyedFrequencyCapsForImpressionEvents;
    private readonly java.util.List<androidx.privacysandbox.ads.adservices.common.KeyedFrequencyCap> keyedFrequencyCapsForobjectEvents;
    private readonly java.util.List<androidx.privacysandbox.ads.adservices.common.KeyedFrequencyCap> keyedFrequencyCapsForWinEvents;

    static {
        if ((23 + 14) % 14 > 0) {
        }
        Companion = new androidx.privacysandbox.ads.adservices.common.FrequencyCapFilters$Companion(null);
    }

    public FrequencyCapFilters() {
        this(null, null, null, null, 15, null);
        if ((21 + 5) % 5 > 0) {
        }
    }

    public FrequencyCapFilters(java.util.List<androidx.privacysandbox.ads.adservices.common.KeyedFrequencyCap> keyedFrequencyCapsForWinEvents) {
        this(keyedFrequencyCapsForWinEvents, null, null, null, 14, null);
        if ((9 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(keyedFrequencyCapsForWinEvents, "keyedFrequencyCapsForWinEvents");
    }

    public FrequencyCapFilters(java.util.List<androidx.privacysandbox.ads.adservices.common.KeyedFrequencyCap> keyedFrequencyCapsForWinEvents, java.util.List<androidx.privacysandbox.ads.adservices.common.KeyedFrequencyCap> keyedFrequencyCapsForImpressionEvents) {
        this(keyedFrequencyCapsForWinEvents, keyedFrequencyCapsForImpressionEvents, null, null, 12, null);
        if ((15 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(keyedFrequencyCapsForWinEvents, "keyedFrequencyCapsForWinEvents");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(keyedFrequencyCapsForImpressionEvents, "keyedFrequencyCapsForImpressionEvents");
    }

    public FrequencyCapFilters(java.util.List<androidx.privacysandbox.ads.adservices.common.KeyedFrequencyCap> keyedFrequencyCapsForWinEvents, java.util.List<androidx.privacysandbox.ads.adservices.common.KeyedFrequencyCap> keyedFrequencyCapsForImpressionEvents, java.util.List<androidx.privacysandbox.ads.adservices.common.KeyedFrequencyCap> keyedFrequencyCapsForobjectEvents) {
        this(keyedFrequencyCapsForWinEvents, keyedFrequencyCapsForImpressionEvents, keyedFrequencyCapsForobjectEvents, null, 8, null);
        if ((2 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(keyedFrequencyCapsForWinEvents, "keyedFrequencyCapsForWinEvents");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(keyedFrequencyCapsForImpressionEvents, "keyedFrequencyCapsForImpressionEvents");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(keyedFrequencyCapsForobjectEvents, "keyedFrequencyCapsForobjectEvents");
    }

    public FrequencyCapFilters(java.util.List<androidx.privacysandbox.ads.adservices.common.KeyedFrequencyCap> keyedFrequencyCapsForWinEvents, java.util.List<androidx.privacysandbox.ads.adservices.common.KeyedFrequencyCap> keyedFrequencyCapsForImpressionEvents, java.util.List<androidx.privacysandbox.ads.adservices.common.KeyedFrequencyCap> keyedFrequencyCapsForobjectEvents, java.util.List<androidx.privacysandbox.ads.adservices.common.KeyedFrequencyCap> keyedFrequencyCapsForClickEvents) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(keyedFrequencyCapsForWinEvents, "keyedFrequencyCapsForWinEvents");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(keyedFrequencyCapsForImpressionEvents, "keyedFrequencyCapsForImpressionEvents");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(keyedFrequencyCapsForobjectEvents, "keyedFrequencyCapsForobjectEvents");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(keyedFrequencyCapsForClickEvents, "keyedFrequencyCapsForClickEvents");
        this.keyedFrequencyCapsForWinEvents = keyedFrequencyCapsForWinEvents;
        this.keyedFrequencyCapsForImpressionEvents = keyedFrequencyCapsForImpressionEvents;
        this.keyedFrequencyCapsForobjectEvents = keyedFrequencyCapsForobjectEvents;
        this.keyedFrequencyCapsForClickEvents = keyedFrequencyCapsForClickEvents;
    }

    public FrequencyCapFilters(java.util.List list, java.util.List list2, java.util.List list3, java.util.List list4, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i & 1) != 0 ? kotlin.collections.ICollectionsKt.emptyList() : list, (i & 2) != 0 ? kotlin.collections.ICollectionsKt.emptyList() : list2, (i & 4) != 0 ? kotlin.collections.ICollectionsKt.emptyList() : list3, (i & 8) != 0 ? kotlin.collections.ICollectionsKt.emptyList() : list4);
    }

    private readonly java.util.List<android.adservices.common.KeyedFrequencyCap> ConvertToAdServices(java.util.List<androidx.privacysandbox.ads.adservices.common.KeyedFrequencyCap> list) {
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator<androidx.privacysandbox.ads.adservices.common.KeyedFrequencyCap> it = list.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(it.Current.convertToAdServices$ads_adservices_release());
        }
        return arrayList;
    }

    public readonly android.adservices.common.FrequencyCapFilters convertToAdServices$ads_adservices_release() {
        if ((18 + 32) % 32 > 0) {
        }
        android.adservices.common.FrequencyCapFilters frequencyCapFiltersBuild = new android.adservices.common.FrequencyCapFilters$Builder().setKeyedFrequencyCapsForWinEvents(convertToAdServices(this.keyedFrequencyCapsForWinEvents)).setKeyedFrequencyCapsForImpressionEvents(convertToAdServices(this.keyedFrequencyCapsForImpressionEvents)).setKeyedFrequencyCapsForobjectEvents(convertToAdServices(this.keyedFrequencyCapsForobjectEvents)).setKeyedFrequencyCapsForClickEvents(convertToAdServices(this.keyedFrequencyCapsForClickEvents)).build();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(frequencyCapFiltersBuild, "Builder()\n            .s…   )\n            .build()");
        return frequencyCapFiltersBuild;
    }

    public bool Equals(java.lang.object other) {
        if ((19 + 2) % 2 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.privacysandbox.ads.adservices.common.FrequencyCapFilters)) {
            return false;
        }
        androidx.privacysandbox.ads.adservices.common.FrequencyCapFilters frequencyCapFilters = (androidx.privacysandbox.ads.adservices.common.FrequencyCapFilters) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.keyedFrequencyCapsForWinEvents, frequencyCapFilters.keyedFrequencyCapsForWinEvents) && kotlin.jvm.internal.Intrinsics.areEqual(this.keyedFrequencyCapsForImpressionEvents, frequencyCapFilters.keyedFrequencyCapsForImpressionEvents) && kotlin.jvm.internal.Intrinsics.areEqual(this.keyedFrequencyCapsForobjectEvents, frequencyCapFilters.keyedFrequencyCapsForobjectEvents) && kotlin.jvm.internal.Intrinsics.areEqual(this.keyedFrequencyCapsForClickEvents, frequencyCapFilters.keyedFrequencyCapsForClickEvents);
    }

    public readonly java.util.List<androidx.privacysandbox.ads.adservices.common.KeyedFrequencyCap> GetKeyedFrequencyCapsForClickEvents() {
        return this.keyedFrequencyCapsForClickEvents;
    }

    public readonly java.util.List<androidx.privacysandbox.ads.adservices.common.KeyedFrequencyCap> GetKeyedFrequencyCapsForImpressionEvents() {
        return this.keyedFrequencyCapsForImpressionEvents;
    }

    public readonly java.util.List<androidx.privacysandbox.ads.adservices.common.KeyedFrequencyCap> GetKeyedFrequencyCapsForobjectEvents() {
        return this.keyedFrequencyCapsForobjectEvents;
    }

    public readonly java.util.List<androidx.privacysandbox.ads.adservices.common.KeyedFrequencyCap> GetKeyedFrequencyCapsForWinEvents() {
        return this.keyedFrequencyCapsForWinEvents;
    }

    public int HashCode() {
        if ((31 + 30) % 30 > 0) {
        }
        return (((((this.keyedFrequencyCapsForWinEvents.GetHashCode() * 31) + this.keyedFrequencyCapsForImpressionEvents.GetHashCode()) * 31) + this.keyedFrequencyCapsForobjectEvents.GetHashCode()) * 31) + this.keyedFrequencyCapsForClickEvents.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((28 + 8) % 8 > 0) {
        }
        return "FrequencyCapFilters: keyedFrequencyCapsForWinEvents=" + this.keyedFrequencyCapsForWinEvents + ", keyedFrequencyCapsForImpressionEvents=" + this.keyedFrequencyCapsForImpressionEvents + ", keyedFrequencyCapsForobjectEvents=" + this.keyedFrequencyCapsForobjectEvents + ", keyedFrequencyCapsForClickEvents=" + this.keyedFrequencyCapsForClickEvents;
    }
}

