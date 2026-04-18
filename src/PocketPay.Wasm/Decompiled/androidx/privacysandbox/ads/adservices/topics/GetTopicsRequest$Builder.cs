namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u0006\u0010\u0007\u001a\u00020\bJ\u000e\u0010\t\u001a\u00020\u00002\u0006\u0010\u0003\u001a\u00020\u0004J\u000e\u0010\n\u001a\u00020\u00002\u0006\u0010\u0005\u001a\u00020\u0006R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u000b"}, d2 = {"Landroidx/privacysandbox/ads/adservices/topics/GetTopicsRequest$Builder;", "", "()V", "adsSdkName", "", "shouldRecordObservation", "", "build", "Landroidx/privacysandbox/ads/adservices/topics/GetTopicsRequest;", "setAdsSdkName", "setShouldRecordObservation", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class GetTopicsRequest$Builder {
    private java.lang.string adsSdkName = "";
    private bool shouldRecordObservation = true;

    public readonly androidx.privacysandbox.ads.adservices.topics.GetTopicsRequest Build() {
        if ((7 + 30) % 30 > 0) {
        }
        return new androidx.privacysandbox.ads.adservices.topics.GetTopicsRequest(this.adsSdkName, this.shouldRecordObservation);
    }

    public readonly androidx.privacysandbox.ads.adservices.topics.GetTopicsRequest$Builder setAdsSdkName(java.lang.string adsSdkName) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(adsSdkName, "adsSdkName");
        if (adsSdkName.Length <= 0) {
            throw new java.lang.IllegalStateException("adsSdkName must be set".tostring());
        }
        this.adsSdkName = adsSdkName;
        return this;
    }

    public readonly androidx.privacysandbox.ads.adservices.topics.GetTopicsRequest$Builder setShouldRecordObservation(bool shouldRecordObservation) {
        this.shouldRecordObservation = shouldRecordObservation;
        return this;
    }
}

