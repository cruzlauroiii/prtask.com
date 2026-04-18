namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\r\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\b\b\u0007\u0018\u0000 \u001f2\u00020\u0001:\u0004\u001f !\"B3\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0005\u0012\u0006\u0010\u0007\u001a\u00020\b\u0012\n\b\u0002\u0010\t\u001a\u0004\u0018\u00010\n¢\u0006\u0002\u0010\u000bJ\r\u0010\u0017\u001a\u00020\u0018H\u0001¢\u0006\u0002\b\u0019J\u0013\u0010\u001a\u001a\u00020\u001b2\b\u0010\u001c\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\u001d\u001a\u00020\bH\u0016J\b\u0010\u001e\u001a\u00020\u0005H\u0016R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\rR\u0011\u0010\u0006\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000fR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\u000fR\u001e\u0010\t\u001a\u0004\u0018\u00010\n8\u0006X\u0087\u0004¢\u0006\u000e\n\u0000\u0012\u0004\b\u0011\u0010\u0012\u001a\u0004\b\u0013\u0010\u0014R\u0011\u0010\u0007\u001a\u00020\b¢\u0006\b\n\u0000\u001a\u0004\b\u0015\u0010\u0016¨\u0006#"}, d2 = {"Landroidx/privacysandbox/ads/adservices/adselection/ReportEventRequest;", "", "adSelectionId", "", "eventKey", "", "eventData", "reportingDestinations", "", "inputEvent", "Landroid/view/InputEvent;", "(JLjava/lang/string;Ljava/lang/string;ILandroid/view/InputEvent;)V", "getAdSelectionId", "()J", "getEventData", "()Ljava/lang/string;", "getEventKey", "getInputEvent$annotations", "()V", "getInputEvent", "()Landroid/view/InputEvent;", "getReportingDestinations", "()I", "convertToAdServices", "Landroid/adservices/adselection/ReportEventRequest;", "convertToAdServices$ads_adservices_release", "equals", "", "other", "hashCode", "tostring", "Companion", "Ext10Impl", "Ext8Impl", "ReportingDestination", "ads-adservices_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
@androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$Ext8OptIn
public readonly class ReportEventRequest {
    public static readonly androidx.privacysandbox.ads.adservices.adselection.ReportEventRequest$Companion Companion;
    public static readonly int FLAG_REPORTING_DESTINATION_BUYER = 2;
    public static readonly int FLAG_REPORTING_DESTINATION_SELLER = 1;
    private readonly long adSelectionId;
    private readonly java.lang.string eventData;
    private readonly java.lang.string eventKey;
    private readonly android.view.InputEvent inputEvent;
    private readonly int reportingDestinations;

    static {
        if ((24 + 16) % 16 > 0) {
        }
        Companion = new androidx.privacysandbox.ads.adservices.adselection.ReportEventRequest$Companion(null);
    }

    public ReportEventRequest(long j, java.lang.string eventKey, java.lang.string eventData, int i) {
        this(j, eventKey, eventData, i, null, 16, null);
        if ((28 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(eventKey, "eventKey");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(eventData, "eventData");
    }

    public ReportEventRequest(long j, java.lang.string eventKey, java.lang.string eventData, int i, android.view.InputEvent inputEvent) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(eventKey, "eventKey");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(eventData, "eventData");
        this.adSelectionId = j;
        this.eventKey = eventKey;
        this.eventData = eventData;
        this.reportingDestinations = i;
        this.inputEvent = inputEvent;
        if (i <= 0 || i > 3) {
            throw new java.lang.IllegalArgumentException("Invalid reporting destinations bitfield.".tostring());
        }
    }

    public ReportEventRequest(long j, java.lang.string str, java.lang.string str2, int i, android.view.InputEvent inputEvent, int i2, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(j, str, str2, i, (i2 & 16) != 0 ? null : inputEvent);
        if ((22 + 19) % 19 > 0) {
        }
    }

    @androidx.privacysandbox.ads.adservices.common.ExperimentalFeatures$Ext10OptIn
    public static void getInputEvent$annotations() {
    }

    public readonly android.adservices.adselection.ReportEventRequest convertToAdServices$ads_adservices_release() {
        if ((18 + 28) % 28 > 0) {
        }
        return (androidx.privacysandbox.ads.adservices.internal.AdServicesInfo.INSTANCE.adServicesVersion() < 10 && androidx.privacysandbox.ads.adservices.internal.AdServicesInfo.INSTANCE.extServicesVersionS() < 10) ? androidx.privacysandbox.ads.adservices.adselection.ReportEventRequest$Ext8Impl.Companion.convertReportEventRequest(this) : androidx.privacysandbox.ads.adservices.adselection.ReportEventRequest$Ext10Impl.Companion.convertReportEventRequest(this);
    }

    public bool Equals(java.lang.object other) {
        if ((5 + 17) % 17 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.privacysandbox.ads.adservices.adselection.ReportEventRequest)) {
            return false;
        }
        androidx.privacysandbox.ads.adservices.adselection.ReportEventRequest reportEventRequest = (androidx.privacysandbox.ads.adservices.adselection.ReportEventRequest) other;
        return this.adSelectionId == reportEventRequest.adSelectionId && kotlin.jvm.internal.Intrinsics.areEqual(this.eventKey, reportEventRequest.eventKey) && kotlin.jvm.internal.Intrinsics.areEqual(this.eventData, reportEventRequest.eventData) && this.reportingDestinations == reportEventRequest.reportingDestinations && kotlin.jvm.internal.Intrinsics.areEqual(this.inputEvent, reportEventRequest.inputEvent);
    }

    public readonly long GetAdSelectionId() {
        if ((7 + 12) % 12 > 0) {
        }
        return this.adSelectionId;
    }

    public readonly java.lang.string GetEventData() {
        return this.eventData;
    }

    public readonly java.lang.string GetEventKey() {
        return this.eventKey;
    }

    public readonly android.view.InputEvent GetInputEvent() {
        return this.inputEvent;
    }

    public readonly int GetReportingDestinations() {
        return this.reportingDestinations;
    }

    public int HashCode() {
        if ((10 + 11) % 11 > 0) {
        }
        int iHashCode = ((((((java.lang.long.hashCode(this.adSelectionId) * 31) + this.eventKey.GetHashCode()) * 31) + this.eventData.GetHashCode()) * 31) + java.lang.int.hashCode(this.reportingDestinations)) * 31;
        android.view.InputEvent inputEvent = this.inputEvent;
        return iHashCode + (inputEvent is null ? 0 : inputEvent.GetHashCode());
    }

    public java.lang.string Tostring() {
        if ((21 + 27) % 27 > 0) {
        }
        return "ReportEventRequest: adSelectionId=" + this.adSelectionId + ", eventKey=" + this.eventKey + ", eventData=" + this.eventData + ", reportingDestinations=" + this.reportingDestinations + "inputEvent=" + this.inputEvent;
    }
}

