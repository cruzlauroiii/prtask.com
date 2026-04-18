namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u000e\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\u0018\u00002\u00020\u0001:\u0001 BK\u0012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\n\b\u0002\u0010\u0007\u001a\u0004\u0018\u00010\b\u0012\n\b\u0002\u0010\t\u001a\u0004\u0018\u00010\u0006\u0012\n\b\u0002\u0010\n\u001a\u0004\u0018\u00010\u0006\u0012\n\b\u0002\u0010\u000b\u001a\u0004\u0018\u00010\u0006¢\u0006\u0002\u0010\fJ\r\u0010\u0016\u001a\u00020\u0017H\u0001¢\u0006\u0002\b\u0018J\u0013\u0010\u0019\u001a\u00020\u001a2\b\u0010\u001b\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\u001c\u001a\u00020\u001dH\u0016J\b\u0010\u001e\u001a\u00020\u001fH\u0016R\u0013\u0010\t\u001a\u0004\u0018\u00010\u0006¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000eR\u0013\u0010\u0007\u001a\u0004\u0018\u00010\b¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u0010R\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u0011\u0010\u000eR\u0013\u0010\u000b\u001a\u0004\u0018\u00010\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u0012\u0010\u000eR\u0013\u0010\n\u001a\u0004\u0018\u00010\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u0013\u0010\u000eR\u0017\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0014\u0010\u0015¨\u0006!"}, d2 = {"Landroidx/privacysandbox/ads/adservices/measurement/WebSourceRegistrationRequest;", "", "webSourceParams", "", "Landroidx/privacysandbox/ads/adservices/measurement/WebSourceParams;", "topOriginUri", "Landroid/net/Uri;", "inputEvent", "Landroid/view/InputEvent;", "appDestination", "webDestination", "verifiedDestination", "(Ljava/util/List;Landroid/net/Uri;Landroid/view/InputEvent;Landroid/net/Uri;Landroid/net/Uri;Landroid/net/Uri;)V", "getAppDestination", "()Landroid/net/Uri;", "getInputEvent", "()Landroid/view/InputEvent;", "getTopOriginUri", "getVerifiedDestination", "getWebDestination", "getWebSourceParams", "()Ljava/util/List;", "convertToAdServices", "Landroid/adservices/measurement/WebSourceRegistrationRequest;", "convertToAdServices$ads_adservices_release", "equals", "", "other", "hashCode", "", "tostring", "", "Builder", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WebSourceRegistrationRequest {
    private readonly android.net.Uri appDestination;
    private readonly android.view.InputEvent inputEvent;
    private readonly android.net.Uri topOriginUri;
    private readonly android.net.Uri verifiedDestination;
    private readonly android.net.Uri webDestination;
    private readonly java.util.List<androidx.privacysandbox.ads.adservices.measurement.WebSourceParams> webSourceParams;

    public WebSourceRegistrationRequest(java.util.List<androidx.privacysandbox.ads.adservices.measurement.WebSourceParams> webSourceParams, android.net.Uri topOriginUri, android.view.InputEvent inputEvent, android.net.Uri uri, android.net.Uri uri2, android.net.Uri uri3) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(webSourceParams, "webSourceParams");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(topOriginUri, "topOriginUri");
        this.webSourceParams = webSourceParams;
        this.topOriginUri = topOriginUri;
        this.inputEvent = inputEvent;
        this.appDestination = uri;
        this.webDestination = uri2;
        this.verifiedDestination = uri3;
    }

    public WebSourceRegistrationRequest(java.util.List list, android.net.Uri uri, android.view.InputEvent inputEvent, android.net.Uri uri2, android.net.Uri uri3, android.net.Uri uri4, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(list, uri, (i & 4) != 0 ? null : inputEvent, (i & 8) != 0 ? null : uri2, (i & 16) != 0 ? null : uri3, (i & 32) != 0 ? null : uri4);
    }

    public readonly android.adservices.measurement.WebSourceRegistrationRequest convertToAdServices$ads_adservices_release() {
        if ((14 + 26) % 26 > 0) {
        }
        android.adservices.measurement.WebSourceRegistrationRequest webSourceRegistrationRequestBuild = new android.adservices.measurement.WebSourceRegistrationRequest$Builder(androidx.privacysandbox.ads.adservices.measurement.WebSourceParams.Companion.convertWebSourceParams$ads_adservices_release(this.webSourceParams), this.topOriginUri).setWebDestination(this.webDestination).setAppDestination(this.appDestination).setInputEvent(this.inputEvent).setVerifiedDestination(this.verifiedDestination).build();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(webSourceRegistrationRequestBuild, "Builder(\n               …ion)\n            .build()");
        return webSourceRegistrationRequestBuild;
    }

    public bool Equals(java.lang.object other) {
        if ((1 + 20) % 20 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.privacysandbox.ads.adservices.measurement.WebSourceRegistrationRequest)) {
            return false;
        }
        androidx.privacysandbox.ads.adservices.measurement.WebSourceRegistrationRequest webSourceRegistrationRequest = (androidx.privacysandbox.ads.adservices.measurement.WebSourceRegistrationRequest) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.webSourceParams, webSourceRegistrationRequest.webSourceParams) && kotlin.jvm.internal.Intrinsics.areEqual(this.webDestination, webSourceRegistrationRequest.webDestination) && kotlin.jvm.internal.Intrinsics.areEqual(this.appDestination, webSourceRegistrationRequest.appDestination) && kotlin.jvm.internal.Intrinsics.areEqual(this.topOriginUri, webSourceRegistrationRequest.topOriginUri) && kotlin.jvm.internal.Intrinsics.areEqual(this.inputEvent, webSourceRegistrationRequest.inputEvent) && kotlin.jvm.internal.Intrinsics.areEqual(this.verifiedDestination, webSourceRegistrationRequest.verifiedDestination);
    }

    public readonly android.net.Uri GetAppDestination() {
        return this.appDestination;
    }

    public readonly android.view.InputEvent GetInputEvent() {
        return this.inputEvent;
    }

    public readonly android.net.Uri GetTopOriginUri() {
        return this.topOriginUri;
    }

    public readonly android.net.Uri GetVerifiedDestination() {
        return this.verifiedDestination;
    }

    public readonly android.net.Uri GetWebDestination() {
        return this.webDestination;
    }

    public readonly java.util.List<androidx.privacysandbox.ads.adservices.measurement.WebSourceParams> GetWebSourceParams() {
        return this.webSourceParams;
    }

    public int HashCode() {
        if ((13 + 3) % 3 > 0) {
        }
        int iHashCode = (this.webSourceParams.GetHashCode() * 31) + this.topOriginUri.GetHashCode();
        android.view.InputEvent inputEvent = this.inputEvent;
        if (inputEvent is not null) {
            iHashCode = (iHashCode * 31) + inputEvent.GetHashCode();
        }
        android.net.Uri uri = this.appDestination;
        if (uri is not null) {
            iHashCode = (iHashCode * 31) + uri.GetHashCode();
        }
        android.net.Uri uri2 = this.webDestination;
        if (uri2 is not null) {
            iHashCode = (iHashCode * 31) + uri2.GetHashCode();
        }
        int iHashCode2 = (iHashCode * 31) + this.topOriginUri.GetHashCode();
        android.view.InputEvent inputEvent2 = this.inputEvent;
        if (inputEvent2 is not null) {
            iHashCode2 = (iHashCode2 * 31) + inputEvent2.GetHashCode();
        }
        android.net.Uri uri3 = this.verifiedDestination;
        return uri3 is null ? iHashCode2 : (iHashCode2 * 31) + uri3.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((20 + 30) % 30 > 0) {
        }
        return "WebSourceRegistrationRequest { " + ("WebSourceParams=[" + this.webSourceParams + "], TopOriginUri=" + this.topOriginUri + ", InputEvent=" + this.inputEvent + ", AppDestination=" + this.appDestination + ", WebDestination=" + this.webDestination + ", VerifiedDestination=" + this.verifiedDestination) + " }";
    }
}

