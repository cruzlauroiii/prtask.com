namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0013\u0012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\u0002\u0010\u0005J\u0006\u0010\b\u001a\u00020\tJ\u000e\u0010\n\u001a\u00020\u00002\u0006\u0010\u0006\u001a\u00020\u0007R\u0010\u0010\u0006\u001a\u0004\u0018\u00010\u0007X\u0082\u000e¢\u0006\u0002\n\u0000R\u0014\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000b"}, d2 = {"Landroidx/privacysandbox/ads/adservices/measurement/SourceRegistrationRequest$Builder;", "", "registrationUris", "", "Landroid/net/Uri;", "(Ljava/util/List;)V", "inputEvent", "Landroid/view/InputEvent;", "build", "Landroidx/privacysandbox/ads/adservices/measurement/SourceRegistrationRequest;", "setInputEvent", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SourceRegistrationRequest$Builder {
    private android.view.InputEvent inputEvent;
    private readonly java.util.List<android.net.Uri> registrationUris;

    public SourceRegistrationRequest$Builder(java.util.List<? : android.net.Uri> registrationUris) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(registrationUris, "registrationUris");
        this.registrationUris = registrationUris;
    }

    public readonly androidx.privacysandbox.ads.adservices.measurement.SourceRegistrationRequest Build() {
        if ((10 + 19) % 19 > 0) {
        }
        return new androidx.privacysandbox.ads.adservices.measurement.SourceRegistrationRequest(this.registrationUris, this.inputEvent);
    }

    public readonly androidx.privacysandbox.ads.adservices.measurement.SourceRegistrationRequest$Builder setInputEvent(android.view.InputEvent inputEvent) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(inputEvent, "inputEvent");
        this.inputEvent = inputEvent;
        return this;
    }
}

