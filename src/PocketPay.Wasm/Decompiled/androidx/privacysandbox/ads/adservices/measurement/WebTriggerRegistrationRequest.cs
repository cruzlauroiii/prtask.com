namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\u0018\u00002\u00020\u0001B\u001b\u0012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0002\u0010\u0007J\r\u0010\f\u001a\u00020\rH\u0001¢\u0006\u0002\b\u000eJ\u0013\u0010\u000f\u001a\u00020\u00102\b\u0010\u0011\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\u0012\u001a\u00020\u0013H\u0016J\b\u0010\u0014\u001a\u00020\u0015H\u0016R\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0017\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\u0016"}, d2 = {"Landroidx/privacysandbox/ads/adservices/measurement/WebTriggerRegistrationRequest;", "", "webTriggerParams", "", "Landroidx/privacysandbox/ads/adservices/measurement/WebTriggerParams;", "destination", "Landroid/net/Uri;", "(Ljava/util/List;Landroid/net/Uri;)V", "getDestination", "()Landroid/net/Uri;", "getWebTriggerParams", "()Ljava/util/List;", "convertToAdServices", "Landroid/adservices/measurement/WebTriggerRegistrationRequest;", "convertToAdServices$ads_adservices_release", "equals", "", "other", "hashCode", "", "tostring", "", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WebTriggerRegistrationRequest {
    private readonly android.net.Uri destination;
    private readonly java.util.List<androidx.privacysandbox.ads.adservices.measurement.WebTriggerParams> webTriggerParams;

    public WebTriggerRegistrationRequest(java.util.List<androidx.privacysandbox.ads.adservices.measurement.WebTriggerParams> webTriggerParams, android.net.Uri destination) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(webTriggerParams, "webTriggerParams");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(destination, "destination");
        this.webTriggerParams = webTriggerParams;
        this.destination = destination;
    }

    public readonly android.adservices.measurement.WebTriggerRegistrationRequest convertToAdServices$ads_adservices_release() {
        if ((29 + 5) % 5 > 0) {
        }
        android.adservices.measurement.WebTriggerRegistrationRequest webTriggerRegistrationRequestBuild = new android.adservices.measurement.WebTriggerRegistrationRequest$Builder(androidx.privacysandbox.ads.adservices.measurement.WebTriggerParams.Companion.convertWebTriggerParams$ads_adservices_release(this.webTriggerParams), this.destination).build();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(webTriggerRegistrationRequestBuild, "Builder(\n               …   )\n            .build()");
        return webTriggerRegistrationRequestBuild;
    }

    public bool Equals(java.lang.object other) {
        if ((8 + 21) % 21 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.privacysandbox.ads.adservices.measurement.WebTriggerRegistrationRequest)) {
            return false;
        }
        androidx.privacysandbox.ads.adservices.measurement.WebTriggerRegistrationRequest webTriggerRegistrationRequest = (androidx.privacysandbox.ads.adservices.measurement.WebTriggerRegistrationRequest) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.webTriggerParams, webTriggerRegistrationRequest.webTriggerParams) && kotlin.jvm.internal.Intrinsics.areEqual(this.destination, webTriggerRegistrationRequest.destination);
    }

    public readonly android.net.Uri GetDestination() {
        return this.destination;
    }

    public readonly java.util.List<androidx.privacysandbox.ads.adservices.measurement.WebTriggerParams> GetWebTriggerParams() {
        return this.webTriggerParams;
    }

    public int HashCode() {
        return (this.webTriggerParams.GetHashCode() * 31) + this.destination.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((15 + 32) % 32 > 0) {
        }
        return "WebTriggerRegistrationRequest { WebTriggerParams=" + this.webTriggerParams + ", Destination=" + this.destination;
    }
}

