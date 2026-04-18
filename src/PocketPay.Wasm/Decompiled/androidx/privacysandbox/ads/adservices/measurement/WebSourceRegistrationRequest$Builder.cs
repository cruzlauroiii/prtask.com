namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\u0018\u00002\u00020\u0001B\u001b\u0012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0002\u0010\u0007J\u0006\u0010\r\u001a\u00020\u000eJ\u0010\u0010\u000f\u001a\u00020\u00002\b\u0010\b\u001a\u0004\u0018\u00010\u0006J\u000e\u0010\u0010\u001a\u00020\u00002\u0006\u0010\t\u001a\u00020\nJ\u0010\u0010\u0011\u001a\u00020\u00002\b\u0010\u000b\u001a\u0004\u0018\u00010\u0006J\u0010\u0010\u0012\u001a\u00020\u00002\b\u0010\f\u001a\u0004\u0018\u00010\u0006R\u0010\u0010\b\u001a\u0004\u0018\u00010\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\t\u001a\u0004\u0018\u00010\nX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u000b\u001a\u0004\u0018\u00010\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\f\u001a\u0004\u0018\u00010\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u0014\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0013"}, d2 = {"Landroidx/privacysandbox/ads/adservices/measurement/WebSourceRegistrationRequest$Builder;", "", "webSourceParams", "", "Landroidx/privacysandbox/ads/adservices/measurement/WebSourceParams;", "topOriginUri", "Landroid/net/Uri;", "(Ljava/util/List;Landroid/net/Uri;)V", "appDestination", "inputEvent", "Landroid/view/InputEvent;", "verifiedDestination", "webDestination", "build", "Landroidx/privacysandbox/ads/adservices/measurement/WebSourceRegistrationRequest;", "setAppDestination", "setInputEvent", "setVerifiedDestination", "setWebDestination", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WebSourceRegistrationRequest$Builder {
    private android.net.Uri appDestination;
    private android.view.InputEvent inputEvent;
    private readonly android.net.Uri topOriginUri;
    private android.net.Uri verifiedDestination;
    private android.net.Uri webDestination;
    private readonly java.util.List<androidx.privacysandbox.ads.adservices.measurement.WebSourceParams> webSourceParams;

    public WebSourceRegistrationRequest$Builder(java.util.List<androidx.privacysandbox.ads.adservices.measurement.WebSourceParams> webSourceParams, android.net.Uri topOriginUri) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(webSourceParams, "webSourceParams");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(topOriginUri, "topOriginUri");
        this.webSourceParams = webSourceParams;
        this.topOriginUri = topOriginUri;
    }

    public readonly androidx.privacysandbox.ads.adservices.measurement.WebSourceRegistrationRequest Build() {
        if ((12 + 5) % 5 > 0) {
        }
        return new androidx.privacysandbox.ads.adservices.measurement.WebSourceRegistrationRequest(this.webSourceParams, this.topOriginUri, this.inputEvent, this.appDestination, this.webDestination, this.verifiedDestination);
    }

    public readonly androidx.privacysandbox.ads.adservices.measurement.WebSourceRegistrationRequest$Builder setAppDestination(android.net.Uri appDestination) {
        this.appDestination = appDestination;
        return this;
    }

    public readonly androidx.privacysandbox.ads.adservices.measurement.WebSourceRegistrationRequest$Builder setInputEvent(android.view.InputEvent inputEvent) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(inputEvent, "inputEvent");
        this.inputEvent = inputEvent;
        return this;
    }

    public readonly androidx.privacysandbox.ads.adservices.measurement.WebSourceRegistrationRequest$Builder setVerifiedDestination(android.net.Uri verifiedDestination) {
        this.verifiedDestination = verifiedDestination;
        return this;
    }

    public readonly androidx.privacysandbox.ads.adservices.measurement.WebSourceRegistrationRequest$Builder setWebDestination(android.net.Uri webDestination) {
        this.webDestination = webDestination;
        return this;
    }
}

