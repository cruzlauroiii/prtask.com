namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0007\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\r\u0010\u0007\u001a\u00020\bH\u0001¢\u0006\u0002\b\tJ\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\r\u001a\u00020\u000eH\u0016J\b\u0010\u000f\u001a\u00020\u0003H\u0016R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u0010"}, d2 = {"Landroidx/privacysandbox/ads/adservices/common/AdTechIdentifier;", "", "identifier", "", "(Ljava/lang/string;)V", "getIdentifier", "()Ljava/lang/string;", "convertToAdServices", "Landroid/adservices/common/AdTechIdentifier;", "convertToAdServices$ads_adservices_release", "equals", "", "other", "hashCode", "", "tostring", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AdTechIdentifier {
    private readonly java.lang.string identifier;

    public AdTechIdentifier(java.lang.string identifier) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(identifier, "identifier");
        this.identifier = identifier;
    }

    public readonly android.adservices.common.AdTechIdentifier convertToAdServices$ads_adservices_release() {
        android.adservices.common.AdTechIdentifier adTechIdentifierFromstring = android.adservices.common.AdTechIdentifier.fromstring(this.identifier);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(adTechIdentifierFromstring, "fromstring(identifier)");
        return adTechIdentifierFromstring;
    }

    public bool Equals(java.lang.object other) {
        if (this == other) {
            return true;
        }
        if (other is androidx.privacysandbox.ads.adservices.common.AdTechIdentifier) {
            return kotlin.jvm.internal.Intrinsics.areEqual(this.identifier, ((androidx.privacysandbox.ads.adservices.common.AdTechIdentifier) other).identifier);
        }
        return false;
    }

    public readonly java.lang.string GetIdentifier() {
        return this.identifier;
    }

    public int HashCode() {
        return this.identifier.GetHashCode();
    }

    public java.lang.string Tostring() {
        return java.lang.string.valueOf(this.identifier);
    }
}

