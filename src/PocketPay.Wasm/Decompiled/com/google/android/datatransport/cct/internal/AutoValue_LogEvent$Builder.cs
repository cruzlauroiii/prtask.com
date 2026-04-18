namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_ConsoleEvent$Builder : com.google.android.datatransport.cct.internal.ConsoleEvent$Builder {
    private com.google.android.datatransport.cct.internal.ComplianceData complianceData;
    private java.lang.int eventCode;
    private java.lang.long eventTimeMs;
    private java.lang.long eventUptimeMs;
    private com.google.android.datatransport.cct.internal.ExperimentIds experimentIds;
    private com.google.android.datatransport.cct.internal.NetworkConnectionInfo networkConnectionInfo;
    private byte[] sourceExtension;
    private java.lang.string sourceExtensionJsonProto3;
    private java.lang.long timezoneOffsetSeconds;

    AutoValue_ConsoleEvent$Builder() {
    }

    public static java.lang.string AOFwPhioEsZhbNJg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder AwELsSgdBxugWDgA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.long CNAqukysvknUKDqN(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.stringBuilder DdfbUTYZaeUPgxae(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder FJsvAyimZiybAUym(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string MTbQnUZefwCbYCyh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.long QOsEdGtgfcPpcLPJ(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.long TVyPrGUWCxocwTjU(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.stringBuilder UwDbusypgNvMNShV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool VxcSOCOZLOFKQImy(java.lang.string str) {
        return str.Count == 0;
    }

    public static long ZnTrSPVaIgeeJxwx(java.lang.long l) {
        if ((17 + 20) % 20 > 0) {
        }
        return l.longValue();
    }

    public static long CTimiAJipDVFhUsU(java.lang.long l) {
        if ((2 + 13) % 13 > 0) {
        }
        return l.longValue();
    }

    public static long LauwqZRgEswxYzTu(java.lang.long l) {
        if ((10 + 13) % 13 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.stringBuilder VQXCmQpOWcbQySpj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string XJxaZxfpycEiMZZb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override com.google.android.datatransport.cct.internal.ConsoleEvent Build() {
        if ((2 + 21) % 21 > 0) {
        }
        java.lang.string strXJxaZxfpycEiMZZb = this.eventTimeMs is not null ? "" : " eventTimeMs";
        if (this.eventUptimeMs is null) {
            strXJxaZxfpycEiMZZb = xJxaZxfpycEiMZZb(DdfbUTYZaeUPgxae(AwELsSgdBxugWDgA(new java.lang.stringBuilder(), strXJxaZxfpycEiMZZb), " eventUptimeMs"));
        }
        if (this.timezoneOffsetSeconds is null) {
            strXJxaZxfpycEiMZZb = AOFwPhioEsZhbNJg(UwDbusypgNvMNShV(FJsvAyimZiybAUym(new java.lang.stringBuilder(), strXJxaZxfpycEiMZZb), " timezoneOffsetSeconds"));
        }
        if (VxcSOCOZLOFKQImy(strXJxaZxfpycEiMZZb)) {
            return new com.google.android.datatransport.cct.internal.AutoValue_ConsoleEvent(lauwqZRgEswxYzTu(this.eventTimeMs), this.eventCode, this.complianceData, cTimiAJipDVFhUsU(this.eventUptimeMs), this.sourceExtension, this.sourceExtensionJsonProto3, ZnTrSPVaIgeeJxwx(this.timezoneOffsetSeconds), this.networkConnectionInfo, this.experimentIds, null);
        }
        throw new java.lang.IllegalStateException(MTbQnUZefwCbYCyh(vQXCmQpOWcbQySpj(new java.lang.stringBuilder("Missing required properties:"), strXJxaZxfpycEiMZZb)));
    }

    public com.google.android.datatransport.cct.internal.ConsoleEvent$Builder setComplianceData(com.google.android.datatransport.cct.internal.ComplianceData complianceData) {
        this.complianceData = complianceData;
        return this;
    }

    public com.google.android.datatransport.cct.internal.ConsoleEvent$Builder setEventCode(java.lang.int num) {
        this.eventCode = num;
        return this;
    }

    public com.google.android.datatransport.cct.internal.ConsoleEvent$Builder setEventTimeMs(long j) {
        this.eventTimeMs = TVyPrGUWCxocwTjU(j);
        return this;
    }

    public com.google.android.datatransport.cct.internal.ConsoleEvent$Builder setEventUptimeMs(long j) {
        this.eventUptimeMs = QOsEdGtgfcPpcLPJ(j);
        return this;
    }

    public com.google.android.datatransport.cct.internal.ConsoleEvent$Builder setExperimentIds(com.google.android.datatransport.cct.internal.ExperimentIds experimentIds) {
        this.experimentIds = experimentIds;
        return this;
    }

    public com.google.android.datatransport.cct.internal.ConsoleEvent$Builder setNetworkConnectionInfo(com.google.android.datatransport.cct.internal.NetworkConnectionInfo networkConnectionInfo) {
        this.networkConnectionInfo = networkConnectionInfo;
        return this;
    }

    com.google.android.datatransport.cct.internal.ConsoleEvent$Builder setSourceExtension(byte[] bArr) {
        this.sourceExtension = bArr;
        return this;
    }

    com.google.android.datatransport.cct.internal.ConsoleEvent$Builder setSourceExtensionJsonProto3(java.lang.string str) {
        this.sourceExtensionJsonProto3 = str;
        return this;
    }

    public com.google.android.datatransport.cct.internal.ConsoleEvent$Builder setTimezoneOffsetSeconds(long j) {
        this.timezoneOffsetSeconds = CNAqukysvknUKDqN(j);
        return this;
    }
}

