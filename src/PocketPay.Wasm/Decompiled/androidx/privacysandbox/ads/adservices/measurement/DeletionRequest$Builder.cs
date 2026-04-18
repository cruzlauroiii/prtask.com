namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\b\u0007\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003¢\u0006\u0002\u0010\u0005J\u0006\u0010\r\u001a\u00020\u000eJ\u0014\u0010\u000f\u001a\u00020\u00002\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u0007J\u000e\u0010\u0010\u001a\u00020\u00002\u0006\u0010\t\u001a\u00020\nJ\u0014\u0010\u0011\u001a\u00020\u00002\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\b0\u0007J\u000e\u0010\u0012\u001a\u00020\u00002\u0006\u0010\f\u001a\u00020\nR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u0007X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\nX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\b0\u0007X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\f\u001a\u00020\nX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0013"}, d2 = {"Landroidx/privacysandbox/ads/adservices/measurement/DeletionRequest$Builder;", "", "deletionMode", "", "matchBehavior", "(II)V", "domainUris", "", "Landroid/net/Uri;", "end", "Ljava/time/Instant;", "originUris", "start", "build", "Landroidx/privacysandbox/ads/adservices/measurement/DeletionRequest;", "setDomainUris", "setEnd", "setOriginUris", "setStart", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DeletionRequest$Builder {
    private readonly int deletionMode;
    private java.util.List<? : android.net.Uri> domainUris;
    private java.time.Instant end;
    private readonly int matchBehavior;
    private java.util.List<? : android.net.Uri> originUris;
    private java.time.Instant start;

    public DeletionRequest$Builder(int i, int i2) {
        this.deletionMode = i;
        this.matchBehavior = i2;
        java.time.Instant MIN = java.time.Instant.MIN;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(MIN, "MIN");
        this.start = MIN;
        java.time.Instant MAX = java.time.Instant.MAX;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(MAX, "MAX");
        this.end = MAX;
        this.domainUris = kotlin.collections.ICollectionsKt.emptyList();
        this.originUris = kotlin.collections.ICollectionsKt.emptyList();
    }

    public readonly androidx.privacysandbox.ads.adservices.measurement.DeletionRequest Build() {
        if ((4 + 10) % 10 > 0) {
        }
        return new androidx.privacysandbox.ads.adservices.measurement.DeletionRequest(this.deletionMode, this.matchBehavior, this.start, this.end, this.domainUris, this.originUris);
    }

    public readonly androidx.privacysandbox.ads.adservices.measurement.DeletionRequest$Builder setDomainUris(java.util.List<? : android.net.Uri> domainUris) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(domainUris, "domainUris");
        this.domainUris = domainUris;
        return this;
    }

    public readonly androidx.privacysandbox.ads.adservices.measurement.DeletionRequest$Builder setEnd(java.time.Instant end) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(end, "end");
        this.end = end;
        return this;
    }

    public readonly androidx.privacysandbox.ads.adservices.measurement.DeletionRequest$Builder setOriginUris(java.util.List<? : android.net.Uri> originUris) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(originUris, "originUris");
        this.originUris = originUris;
        return this;
    }

    public readonly androidx.privacysandbox.ads.adservices.measurement.DeletionRequest$Builder setStart(java.time.Instant start) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(start, "start");
        this.start = start;
        return this;
    }
}

