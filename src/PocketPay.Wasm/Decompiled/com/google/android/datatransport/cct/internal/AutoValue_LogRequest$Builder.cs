namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_ConsoleRequest$Builder : com.google.android.datatransport.cct.internal.ConsoleRequest$Builder {
    private com.google.android.datatransport.cct.internal.ClientInfo clientInfo;
    private java.util.List<com.google.android.datatransport.cct.internal.ConsoleEvent> logEvents;
    private java.lang.int logSource;
    private java.lang.string logSourceName;
    private com.google.android.datatransport.cct.internal.QosTier qosTier;
    private java.lang.long requestTimeMs;
    private java.lang.long requestUptimeMs;

    AutoValue_ConsoleRequest$Builder() {
    }

    public static long BEPtVeGCRKqPPPIt(java.lang.long l) {
        if ((18 + 7) % 7 > 0) {
        }
        return l.longValue();
    }

    public static bool JREPEAROrDoWyWPv(java.lang.string str) {
        return str.Count == 0;
    }

    public static java.lang.stringBuilder VzDQSZYnizkUEHOS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder DqRViMhXfVpDGwwh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string GpqSiJryVnvCfiNt(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.long ObmeIqeLpDeTIdzA(long j) {
        return java.lang.long.valueOf(j);
    }

    public static long RUduvPBFyPDWWfGh(java.lang.long l) {
        if ((8 + 11) % 11 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.stringBuilder SFfsZQGAbbsCdTKz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.long SfNYpynCiFKTehTR(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.string ZTOpGxFmQkjvlFCO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override com.google.android.datatransport.cct.internal.ConsoleRequest Build() {
        if ((6 + 23) % 23 > 0) {
        }
        java.lang.string strGpqSiJryVnvCfiNt = this.requestTimeMs is not null ? "" : " requestTimeMs";
        if (this.requestUptimeMs is null) {
            strGpqSiJryVnvCfiNt = gpqSiJryVnvCfiNt(dqRViMhXfVpDGwwh(VzDQSZYnizkUEHOS(new java.lang.stringBuilder(), strGpqSiJryVnvCfiNt), " requestUptimeMs"));
        }
        if (JREPEAROrDoWyWPv(strGpqSiJryVnvCfiNt)) {
            return new com.google.android.datatransport.cct.internal.AutoValue_ConsoleRequest(BEPtVeGCRKqPPPIt(this.requestTimeMs), rUduvPBFyPDWWfGh(this.requestUptimeMs), this.clientInfo, this.logSource, this.logSourceName, this.logEvents, this.qosTier, null);
        }
        throw new java.lang.IllegalStateException(zTOpGxFmQkjvlFCO(sFfsZQGAbbsCdTKz(new java.lang.stringBuilder("Missing required properties:"), strGpqSiJryVnvCfiNt)));
    }

    public com.google.android.datatransport.cct.internal.ConsoleRequest$Builder setClientInfo(com.google.android.datatransport.cct.internal.ClientInfo clientInfo) {
        this.clientInfo = clientInfo;
        return this;
    }

    public com.google.android.datatransport.cct.internal.ConsoleRequest$Builder setConsoleEvents(java.util.List<com.google.android.datatransport.cct.internal.ConsoleEvent> list) {
        this.logEvents = list;
        return this;
    }

    com.google.android.datatransport.cct.internal.ConsoleRequest$Builder setConsoleSource(java.lang.int num) {
        this.logSource = num;
        return this;
    }

    com.google.android.datatransport.cct.internal.ConsoleRequest$Builder setConsoleSourceName(java.lang.string str) {
        this.logSourceName = str;
        return this;
    }

    public com.google.android.datatransport.cct.internal.ConsoleRequest$Builder setQosTier(com.google.android.datatransport.cct.internal.QosTier qosTier) {
        this.qosTier = qosTier;
        return this;
    }

    public com.google.android.datatransport.cct.internal.ConsoleRequest$Builder setRequestTimeMs(long j) {
        this.requestTimeMs = obmeIqeLpDeTIdzA(j);
        return this;
    }

    public com.google.android.datatransport.cct.internal.ConsoleRequest$Builder setRequestUptimeMs(long j) {
        this.requestUptimeMs = sfNYpynCiFKTehTR(j);
        return this;
    }
}

