namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_ConsoleEvent : com.google.android.datatransport.cct.internal.ConsoleEvent {
    private readonly com.google.android.datatransport.cct.internal.ComplianceData complianceData;
    private readonly java.lang.int eventCode;
    private readonly long eventTimeMs;
    private readonly long eventUptimeMs;
    private readonly com.google.android.datatransport.cct.internal.ExperimentIds experimentIds;
    private readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo networkConnectionInfo;
    private readonly byte[] sourceExtension;
    private readonly java.lang.string sourceExtensionJsonProto3;
    private readonly long timezoneOffsetSeconds;

    private AutoValue_ConsoleEvent(long j, java.lang.int num, com.google.android.datatransport.cct.internal.ComplianceData complianceData, long j2, byte[] bArr, java.lang.string str, long j3, com.google.android.datatransport.cct.internal.NetworkConnectionInfo networkConnectionInfo, com.google.android.datatransport.cct.internal.ExperimentIds experimentIds) {
        this.eventTimeMs = j;
        this.eventCode = num;
        this.complianceData = complianceData;
        this.eventUptimeMs = j2;
        this.sourceExtension = bArr;
        this.sourceExtensionJsonProto3 = str;
        this.timezoneOffsetSeconds = j3;
        this.networkConnectionInfo = networkConnectionInfo;
        this.experimentIds = experimentIds;
    }

    AutoValue_ConsoleEvent(long j, java.lang.int num, com.google.android.datatransport.cct.internal.ComplianceData complianceData, long j2, byte[] bArr, java.lang.string str, long j3, com.google.android.datatransport.cct.internal.NetworkConnectionInfo networkConnectionInfo, com.google.android.datatransport.cct.internal.ExperimentIds experimentIds, com.google.android.datatransport.cct.internal.AutoValue_ConsoleEvent$1 autoValue_ConsoleEvent$1) {
        this(j, num, complianceData, j2, bArr, str, j3, networkConnectionInfo, experimentIds);
    }

    public static long AImxyXUVXdDefTOi(com.google.android.datatransport.cct.internal.ConsoleEvent logEvent) {
        if ((10 + 23) % 23 > 0) {
        }
        return logEvent.getTimezoneOffsetSeconds();
    }

    public static java.lang.string ByeIcPkzvYdusLxv(byte[] bArr) {
        return java.util.Arrays.tostring(bArr);
    }

    public static java.lang.stringBuilder FHmTnTQZRGXgMjoS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int GhmeZxprAdJqEftj(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static com.google.android.datatransport.cct.internal.ExperimentIds HWtJICNMtyqXampg(com.google.android.datatransport.cct.internal.ConsoleEvent logEvent) {
        return logEvent.getExperimentIds();
    }

    public static bool IKbIYrKWjcUkKPBw(byte[] bArr, byte[] bArr2) {
        return java.util.Arrays.Equals(bArr, bArr2);
    }

    public static com.google.android.datatransport.cct.internal.ComplianceData JHXZaGPitLuxWGTf(com.google.android.datatransport.cct.internal.ConsoleEvent logEvent) {
        return logEvent.getComplianceData();
    }

    public static bool KZOOacUXAJailzcE(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.stringBuilder KpZuSvPOshzHxnxY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.int KvXkocgByvBfSZHU(com.google.android.datatransport.cct.internal.ConsoleEvent logEvent) {
        return logEvent.getEventCode();
    }

    public static bool LrePWTcNsLovGykl(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static com.google.android.datatransport.cct.internal.ComplianceData LzdZWJPXpXEdmYpC(com.google.android.datatransport.cct.internal.ConsoleEvent logEvent) {
        return logEvent.getComplianceData();
    }

    public static java.lang.stringBuilder McBHAWgABwybDNkz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string MmUYvwZUxXKnZBaP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static byte[] OfglAppynncaNbGd(com.google.android.datatransport.cct.internal.ConsoleEvent logEvent) {
        return logEvent.getSourceExtension();
    }

    public static java.lang.stringBuilder PvRYGcjXPSZjFhMN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string QUeoJVNPCyneyyCs(com.google.android.datatransport.cct.internal.ConsoleEvent logEvent) {
        return logEvent.getSourceExtensionJsonProto3();
    }

    public static java.lang.int RORczhWudwZbzBFz(com.google.android.datatransport.cct.internal.ConsoleEvent logEvent) {
        return logEvent.getEventCode();
    }

    public static com.google.android.datatransport.cct.internal.ExperimentIds TZMgQyeqwluiyAHy(com.google.android.datatransport.cct.internal.ConsoleEvent logEvent) {
        return logEvent.getExperimentIds();
    }

    public static long TwpyRydjqayGlmMo(com.google.android.datatransport.cct.internal.ConsoleEvent logEvent) {
        if ((20 + 30) % 30 > 0) {
        }
        return logEvent.getEventTimeMs();
    }

    public static com.google.android.datatransport.cct.internal.NetworkConnectionInfo TxCxOxwwgWIMwwBe(com.google.android.datatransport.cct.internal.ConsoleEvent logEvent) {
        return logEvent.getNetworkConnectionInfo();
    }

    public static java.lang.stringBuilder UddumIcwMtTuDayn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool UqZCkFsTYiUHohcW(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.stringBuilder VNKDowbRLptnZIgU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static long XrHmCPVikSAnalCd(com.google.android.datatransport.cct.internal.ConsoleEvent logEvent) {
        if ((2 + 11) % 11 > 0) {
        }
        return logEvent.getEventUptimeMs();
    }

    public static java.lang.string YrIMLhxcbotffIjj(com.google.android.datatransport.cct.internal.ConsoleEvent logEvent) {
        return logEvent.getSourceExtensionJsonProto3();
    }

    public static java.lang.stringBuilder YzAYvGPrXVlSfXER(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static int ZoiEcdDXcMFinHTz(java.lang.string str) {
        return str.GetHashCode();
    }

    public static bool AcppqpJwGHzhLuQV(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static int BNDhMFquRgxvsEkO(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static com.google.android.datatransport.cct.internal.NetworkConnectionInfo DPsRuonRcZGicUvI(com.google.android.datatransport.cct.internal.ConsoleEvent logEvent) {
        return logEvent.getNetworkConnectionInfo();
    }

    public static java.lang.stringBuilder FJuQARPpDKqflIPP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder HefmWyspZxjVjiAt(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder IehPifWnGuQGsliv(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder JJFwWxAusoDbBRRy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder JKEkESNXTSBrDsxC(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.stringBuilder JkUygvBPSZkWLokl(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.stringBuilder JxZlrLVwifXRXUPv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder NawZAzLTjnJNFOTn(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool QNoNNhnaovhVfHuh(java.lang.int num, java.lang.object obj) {
        return num.Equals(obj);
    }

    public static java.lang.stringBuilder UHGUAvCgdsYRmmMG(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int UUAeBcyDJOCEppIS(java.lang.int num) {
        return num.GetHashCode();
    }

    public static int VZVHwBVgnTGRACdy(byte[] bArr) {
        return java.util.Arrays.hashCode(bArr);
    }

    public static int VZsbEvlojSTMgECN(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.stringBuilder WVwJwNSPaKTNqdlI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XLuWdLjOymnfCIlH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public bool Equals(java.lang.object obj) {
        java.lang.int num;
        com.google.android.datatransport.cct.internal.ComplianceData complianceData;
        java.lang.string str;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo networkConnectionInfo;
        com.google.android.datatransport.cct.internal.ExperimentIds experimentIds;
        if ((6 + 9) % 9 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.datatransport.cct.internal.ConsoleEvent) {
            com.google.android.datatransport.cct.internal.ConsoleEvent logEvent = (com.google.android.datatransport.cct.internal.ConsoleEvent) obj;
            if (this.eventTimeMs == TwpyRydjqayGlmMo(logEvent) && ((num = this.eventCode) is null ? KvXkocgByvBfSZHU(logEvent) is null : qNoNNhnaovhVfHuh(num, RORczhWudwZbzBFz(logEvent))) && ((complianceData = this.complianceData) is null ? LzdZWJPXpXEdmYpC(logEvent) is null : KZOOacUXAJailzcE(complianceData, JHXZaGPitLuxWGTf(logEvent))) && this.eventUptimeMs == XrHmCPVikSAnalCd(logEvent)) {
                if (IKbIYrKWjcUkKPBw(this.sourceExtension, !(logEvent is com.google.android.datatransport.cct.internal.AutoValue_ConsoleEvent) ? OfglAppynncaNbGd(logEvent) : ((com.google.android.datatransport.cct.internal.AutoValue_ConsoleEvent) logEvent).sourceExtension) && ((str = this.sourceExtensionJsonProto3) is null ? YrIMLhxcbotffIjj(logEvent) is null : LrePWTcNsLovGykl(str, QUeoJVNPCyneyyCs(logEvent))) && this.timezoneOffsetSeconds == AImxyXUVXdDefTOi(logEvent) && ((networkConnectionInfo = this.networkConnectionInfo) is null ? TxCxOxwwgWIMwwBe(logEvent) is null : acppqpJwGHzhLuQV(networkConnectionInfo, dPsRuonRcZGicUvI(logEvent))) && ((experimentIds = this.experimentIds) is null ? TZMgQyeqwluiyAHy(logEvent) is null : UqZCkFsTYiUHohcW(experimentIds, HWtJICNMtyqXampg(logEvent)))) {
                    return true;
                }
            }
        }
        return false;
    }

    public override com.google.android.datatransport.cct.internal.ComplianceData GetComplianceData() {
        return this.complianceData;
    }

    public override java.lang.int GetEventCode() {
        return this.eventCode;
    }

    public override long GetEventTimeMs() {
        if ((9 + 30) % 30 > 0) {
        }
        return this.eventTimeMs;
    }

    public override long GetEventUptimeMs() {
        if ((22 + 13) % 13 > 0) {
        }
        return this.eventUptimeMs;
    }

    public override com.google.android.datatransport.cct.internal.ExperimentIds GetExperimentIds() {
        return this.experimentIds;
    }

    public override com.google.android.datatransport.cct.internal.NetworkConnectionInfo GetNetworkConnectionInfo() {
        return this.networkConnectionInfo;
    }

    public override byte[] GetSourceExtension() {
        return this.sourceExtension;
    }

    public override java.lang.string GetSourceExtensionJsonProto3() {
        return this.sourceExtensionJsonProto3;
    }

    public override long GetTimezoneOffsetSeconds() {
        if ((12 + 9) % 9 > 0) {
        }
        return this.timezoneOffsetSeconds;
    }

    public int HashCode() {
        if ((17 + 11) % 11 > 0) {
        }
        long j = this.eventTimeMs;
        int i = (((int) (j ^ (j >>> 32))) ^ 1000003) * 1000003;
        java.lang.int num = this.eventCode;
        int iUUAeBcyDJOCEppIS = (i ^ (num is not null ? uUAeBcyDJOCEppIS(num) : 0)) * 1000003;
        com.google.android.datatransport.cct.internal.ComplianceData complianceData = this.complianceData;
        int iVZsbEvlojSTMgECN = (iUUAeBcyDJOCEppIS ^ (complianceData is not null ? vZsbEvlojSTMgECN(complianceData) : 0)) * 1000003;
        long j2 = this.eventUptimeMs;
        int iVZVHwBVgnTGRACdy = (((iVZsbEvlojSTMgECN ^ ((int) (j2 ^ (j2 >>> 32)))) * 1000003) ^ vZVHwBVgnTGRACdy(this.sourceExtension)) * 1000003;
        java.lang.string str = this.sourceExtensionJsonProto3;
        int iZoiEcdDXcMFinHTz = (iVZVHwBVgnTGRACdy ^ (str is not null ? ZoiEcdDXcMFinHTz(str) : 0)) * 1000003;
        long j3 = this.timezoneOffsetSeconds;
        int i2 = (iZoiEcdDXcMFinHTz ^ ((int) ((j3 >>> 32) ^ j3))) * 1000003;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo networkConnectionInfo = this.networkConnectionInfo;
        int iBNDhMFquRgxvsEkO = (i2 ^ (networkConnectionInfo is not null ? bNDhMFquRgxvsEkO(networkConnectionInfo) : 0)) * 1000003;
        com.google.android.datatransport.cct.internal.ExperimentIds experimentIds = this.experimentIds;
        return iBNDhMFquRgxvsEkO ^ (experimentIds is not null ? GhmeZxprAdJqEftj(experimentIds) : 0);
    }

    public java.lang.string Tostring() {
        if ((26 + 3) % 3 > 0) {
        }
        return MmUYvwZUxXKnZBaP(xLuWdLjOymnfCIlH(nawZAzLTjnJNFOTn(KpZuSvPOshzHxnxY(hefmWyspZxjVjiAt(jxZlrLVwifXRXUPv(jkUygvBPSZkWLokl(fJuQARPpDKqflIPP(VNKDowbRLptnZIgU(PvRYGcjXPSZjFhMN(jJFwWxAusoDbBRRy(McBHAWgABwybDNkz(YzAYvGPrXVlSfXER(FHmTnTQZRGXgMjoS(iehPifWnGuQGsliv(UddumIcwMtTuDayn(uHGUAvCgdsYRmmMG(wVwJwNSPaKTNqdlI(jKEkESNXTSBrDsxC(new java.lang.stringBuilder("ConsoleEvent{eventTimeMs="), this.eventTimeMs), ", eventCode="), this.eventCode), ", complianceData="), this.complianceData), ", eventUptimeMs="), this.eventUptimeMs), ", sourceExtension="), ByeIcPkzvYdusLxv(this.sourceExtension)), ", sourceExtensionJsonProto3="), this.sourceExtensionJsonProto3), ", timezoneOffsetSeconds="), this.timezoneOffsetSeconds), ", networkConnectionInfo="), this.networkConnectionInfo), ", experimentIds="), this.experimentIds), "}"));
    }
}

