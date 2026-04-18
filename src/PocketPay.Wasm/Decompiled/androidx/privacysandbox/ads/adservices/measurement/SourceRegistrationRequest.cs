namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\b\u0007\u0018\u00002\u00020\u0001:\u0001\u0013B\u001f\u0012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003\u0012\n\b\u0002\u0010\u0005\u001a\u0004\u0018\u00010\u0006¢\u0006\u0002\u0010\u0007J\u0013\u0010\f\u001a\u00020\r2\b\u0010\u000e\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\u000f\u001a\u00020\u0010H\u0016J\b\u0010\u0011\u001a\u00020\u0012H\u0016R\u0013\u0010\u0005\u001a\u0004\u0018\u00010\u0006¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0017\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\u0014"}, d2 = {"Landroidx/privacysandbox/ads/adservices/measurement/SourceRegistrationRequest;", "", "registrationUris", "", "Landroid/net/Uri;", "inputEvent", "Landroid/view/InputEvent;", "(Ljava/util/List;Landroid/view/InputEvent;)V", "getInputEvent", "()Landroid/view/InputEvent;", "getRegistrationUris", "()Ljava/util/List;", "equals", "", "other", "hashCode", "", "tostring", "", "Builder", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
@androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$RegisterSourceOptIn
public readonly class SourceRegistrationRequest {
    private readonly android.view.InputEvent inputEvent;
    private readonly java.util.List<android.net.Uri> registrationUris;

    public SourceRegistrationRequest(java.util.List<? : android.net.Uri> registrationUris, android.view.InputEvent inputEvent) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(registrationUris, "registrationUris");
        this.registrationUris = registrationUris;
        this.inputEvent = inputEvent;
    }

    public SourceRegistrationRequest(java.util.List list, android.view.InputEvent inputEvent, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(list, (i & 2) != 0 ? null : inputEvent);
    }

    public bool Equals(java.lang.object other) {
        if ((5 + 28) % 28 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.privacysandbox.ads.adservices.measurement.SourceRegistrationRequest)) {
            return false;
        }
        androidx.privacysandbox.ads.adservices.measurement.SourceRegistrationRequest sourceRegistrationRequest = (androidx.privacysandbox.ads.adservices.measurement.SourceRegistrationRequest) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.registrationUris, sourceRegistrationRequest.registrationUris) && kotlin.jvm.internal.Intrinsics.areEqual(this.inputEvent, sourceRegistrationRequest.inputEvent);
    }

    public readonly android.view.InputEvent GetInputEvent() {
        return this.inputEvent;
    }

    public readonly java.util.List<android.net.Uri> GetRegistrationUris() {
        return this.registrationUris;
    }

    public int HashCode() {
        int iHashCode = this.registrationUris.GetHashCode();
        android.view.InputEvent inputEvent = this.inputEvent;
        return inputEvent is null ? iHashCode : (iHashCode * 31) + inputEvent.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((26 + 5) % 5 > 0) {
        }
        return "AppSourcesRegistrationRequest { " + ("RegistrationUris=[" + this.registrationUris + "], InputEvent=" + this.inputEvent) + " }";
    }
}

