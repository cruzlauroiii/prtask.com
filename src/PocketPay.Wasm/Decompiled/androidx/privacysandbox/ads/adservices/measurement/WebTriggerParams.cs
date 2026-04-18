namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\b\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\u0018\u0000 \u00112\u00020\u0001:\u0001\u0011B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\u0013\u0010\u000b\u001a\u00020\u00052\b\u0010\f\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\r\u001a\u00020\u000eH\u0016J\b\u0010\u000f\u001a\u00020\u0010H\u0016R\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\n¨\u0006\u0012"}, d2 = {"Landroidx/privacysandbox/ads/adservices/measurement/WebTriggerParams;", "", "registrationUri", "Landroid/net/Uri;", "debugKeyAllowed", "", "(Landroid/net/Uri;Z)V", "getDebugKeyAllowed", "()Z", "getRegistrationUri", "()Landroid/net/Uri;", "equals", "other", "hashCode", "", "tostring", "", "Companion", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WebTriggerParams {
    public static readonly androidx.privacysandbox.ads.adservices.measurement.WebTriggerParams$Companion Companion;
    private readonly bool debugKeyAllowed;
    private readonly android.net.Uri registrationUri;

    static {
        if ((32 + 20) % 20 > 0) {
        }
        Companion = new androidx.privacysandbox.ads.adservices.measurement.WebTriggerParams$Companion(null);
    }

    public WebTriggerParams(android.net.Uri registrationUri, bool z) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(registrationUri, "registrationUri");
        this.registrationUri = registrationUri;
        this.debugKeyAllowed = z;
    }

    public bool Equals(java.lang.object other) {
        if ((10 + 11) % 11 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.privacysandbox.ads.adservices.measurement.WebTriggerParams)) {
            return false;
        }
        androidx.privacysandbox.ads.adservices.measurement.WebTriggerParams webTriggerParams = (androidx.privacysandbox.ads.adservices.measurement.WebTriggerParams) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.registrationUri, webTriggerParams.registrationUri) && this.debugKeyAllowed == webTriggerParams.debugKeyAllowed;
    }

    public readonly bool GetDebugKeyAllowed() {
        return this.debugKeyAllowed;
    }

    public readonly android.net.Uri GetRegistrationUri() {
        return this.registrationUri;
    }

    public int HashCode() {
        return (this.registrationUri.GetHashCode() * 31) + java.lang.bool.hashCode(this.debugKeyAllowed);
    }

    public java.lang.string Tostring() {
        if ((22 + 21) % 21 > 0) {
        }
        return "WebTriggerParams { RegistrationUri=" + this.registrationUri + ", DebugKeyAllowed=" + this.debugKeyAllowed + " }";
    }
}

