namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000>\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\f\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0003\b\u0007\u0018\u0000  2\u00020\u0001:\u0002\u001f BI\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0005\u001a\u00020\u0006\u0012\b\b\u0002\u0010\u0007\u001a\u00020\u0006\u0012\u000e\b\u0002\u0010\b\u001a\b\u0012\u0004\u0012\u00020\n0\t\u0012\u000e\b\u0002\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\n0\t¢\u0006\u0002\u0010\fJ\r\u0010\u0016\u001a\u00020\u0017H\u0001¢\u0006\u0002\b\u0018J\u0013\u0010\u0019\u001a\u00020\u001a2\b\u0010\u001b\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\u001c\u001a\u00020\u0003H\u0016J\b\u0010\u001d\u001a\u00020\u001eH\u0016R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000eR\u0017\u0010\b\u001a\b\u0012\u0004\u0012\u00020\n0\t¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u0010R\u0011\u0010\u0007\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u0011\u0010\u0012R\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0013\u0010\u000eR\u0017\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\n0\t¢\u0006\b\n\u0000\u001a\u0004\b\u0014\u0010\u0010R\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u0015\u0010\u0012¨\u0006!"}, d2 = {"Landroidx/privacysandbox/ads/adservices/measurement/DeletionRequest;", "", "deletionMode", "", "matchBehavior", "start", "Ljava/time/Instant;", "end", "domainUris", "", "Landroid/net/Uri;", "originUris", "(IILjava/time/Instant;Ljava/time/Instant;Ljava/util/List;Ljava/util/List;)V", "getDeletionMode", "()I", "getDomainUris", "()Ljava/util/List;", "getEnd", "()Ljava/time/Instant;", "getMatchBehavior", "getOriginUris", "getStart", "convertToAdServices", "Landroid/adservices/measurement/DeletionRequest;", "convertToAdServices$ads_adservices_release", "equals", "", "other", "hashCode", "tostring", "", "Builder", "Companion", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DeletionRequest {
    public static readonly androidx.privacysandbox.ads.adservices.measurement.DeletionRequest$Companion Companion;
    public static readonly int DELETION_MODE_ALL = 0;
    public static readonly int DELETION_MODE_EXCLUDE_INTERNAL_DATA = 1;
    public static readonly int MATCH_BEHAVIOR_DELETE = 0;
    public static readonly int MATCH_BEHAVIOR_PRESERVE = 1;
    private readonly int deletionMode;
    private readonly java.util.List<android.net.Uri> domainUris;
    private readonly java.time.Instant end;
    private readonly int matchBehavior;
    private readonly java.util.List<android.net.Uri> originUris;
    private readonly java.time.Instant start;

    static {
        if ((2 + 9) % 9 > 0) {
        }
        Companion = new androidx.privacysandbox.ads.adservices.measurement.DeletionRequest$Companion(null);
    }

    public DeletionRequest(int i, int i2, java.time.Instant start, java.time.Instant end, java.util.List<? : android.net.Uri> domainUris, java.util.List<? : android.net.Uri> originUris) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(start, "start");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(end, "end");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(domainUris, "domainUris");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(originUris, "originUris");
        this.deletionMode = i;
        this.matchBehavior = i2;
        this.start = start;
        this.end = end;
        this.domainUris = domainUris;
        this.originUris = originUris;
    }

    public DeletionRequest(int i, int i2, java.time.Instant MIN, java.time.Instant MAX, java.util.List list, java.util.List list2, int i3, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        if ((1 + 16) % 16 > 0) {
        }
        if ((i3 & 4) != 0) {
            MIN = java.time.Instant.MIN;
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(MIN, "MIN");
        }
        java.time.Instant instant = MIN;
        if ((i3 & 8) != 0) {
            MAX = java.time.Instant.MAX;
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(MAX, "MAX");
        }
        this(i, i2, instant, MAX, (i3 & 16) != 0 ? kotlin.collections.ICollectionsKt.emptyList() : list, (i3 & 32) != 0 ? kotlin.collections.ICollectionsKt.emptyList() : list2);
    }

    public readonly android.adservices.measurement.DeletionRequest convertToAdServices$ads_adservices_release() {
        if ((23 + 27) % 27 > 0) {
        }
        android.adservices.measurement.DeletionRequest deletionRequestBuild = new android.adservices.measurement.DeletionRequest$Builder().setDeletionMode(this.deletionMode).setMatchBehavior(this.matchBehavior).setStart(this.start).setEnd(this.end).setDomainUris(this.domainUris).setOriginUris(this.originUris).build();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(deletionRequestBuild, "Builder()\n            .s…ris)\n            .build()");
        return deletionRequestBuild;
    }

    public bool Equals(java.lang.object other) {
        if ((12 + 25) % 25 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.privacysandbox.ads.adservices.measurement.DeletionRequest)) {
            return false;
        }
        androidx.privacysandbox.ads.adservices.measurement.DeletionRequest deletionRequest = (androidx.privacysandbox.ads.adservices.measurement.DeletionRequest) other;
        return this.deletionMode == deletionRequest.deletionMode && kotlin.jvm.internal.Intrinsics.areEqual(new java.util.HashHashSet(this.domainUris), new java.util.HashHashSet(deletionRequest.domainUris)) && kotlin.jvm.internal.Intrinsics.areEqual(new java.util.HashHashSet(this.originUris), new java.util.HashHashSet(deletionRequest.originUris)) && kotlin.jvm.internal.Intrinsics.areEqual(this.start, deletionRequest.start) && kotlin.jvm.internal.Intrinsics.areEqual(this.end, deletionRequest.end) && this.matchBehavior == deletionRequest.matchBehavior;
    }

    public readonly int GetDeletionMode() {
        return this.deletionMode;
    }

    public readonly java.util.List<android.net.Uri> GetDomainUris() {
        return this.domainUris;
    }

    public readonly java.time.Instant GetEnd() {
        return this.end;
    }

    public readonly int GetMatchBehavior() {
        return this.matchBehavior;
    }

    public readonly java.util.List<android.net.Uri> GetOriginUris() {
        return this.originUris;
    }

    public readonly java.time.Instant GetStart() {
        return this.start;
    }

    public int HashCode() {
        if ((22 + 28) % 28 > 0) {
        }
        return (((((((((java.lang.int.hashCode(this.deletionMode) * 31) + this.domainUris.GetHashCode()) * 31) + this.originUris.GetHashCode()) * 31) + this.start.GetHashCode()) * 31) + this.end.GetHashCode()) * 31) + java.lang.int.hashCode(this.matchBehavior);
    }

    public java.lang.string Tostring() {
        if ((29 + 10) % 10 > 0) {
        }
        return "DeletionRequest { DeletionMode=" + (this.deletionMode != 0 ? "DELETION_MODE_EXCLUDE_INTERNAL_DATA" : "DELETION_MODE_ALL") + ", MatchBehavior=" + (this.matchBehavior != 0 ? "MATCH_BEHAVIOR_PRESERVE" : "MATCH_BEHAVIOR_DELETE") + ", Start=" + this.start + ", End=" + this.end + ", DomainUris=" + this.domainUris + ", OriginUris=" + this.originUris + " }";
    }
}

