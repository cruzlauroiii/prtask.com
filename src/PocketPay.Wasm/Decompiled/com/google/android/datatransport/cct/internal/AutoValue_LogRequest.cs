namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_ConsoleRequest : com.google.android.datatransport.cct.internal.ConsoleRequest {
    private readonly com.google.android.datatransport.cct.internal.ClientInfo clientInfo;
    private readonly java.util.List<com.google.android.datatransport.cct.internal.ConsoleEvent> logEvents;
    private readonly java.lang.int logSource;
    private readonly java.lang.string logSourceName;
    private readonly com.google.android.datatransport.cct.internal.QosTier qosTier;
    private readonly long requestTimeMs;
    private readonly long requestUptimeMs;

    private AutoValue_ConsoleRequest(long j, long j2, com.google.android.datatransport.cct.internal.ClientInfo clientInfo, java.lang.int num, java.lang.string str, java.util.List<com.google.android.datatransport.cct.internal.ConsoleEvent> list, com.google.android.datatransport.cct.internal.QosTier qosTier) {
        this.requestTimeMs = j;
        this.requestUptimeMs = j2;
        this.clientInfo = clientInfo;
        this.logSource = num;
        this.logSourceName = str;
        this.logEvents = list;
        this.qosTier = qosTier;
    }

    AutoValue_ConsoleRequest(long j, long j2, com.google.android.datatransport.cct.internal.ClientInfo clientInfo, java.lang.int num, java.lang.string str, java.util.List list, com.google.android.datatransport.cct.internal.QosTier qosTier, com.google.android.datatransport.cct.internal.AutoValue_ConsoleRequest$1 autoValue_ConsoleRequest$1) {
        this(j, j2, clientInfo, num, str, list, qosTier);
    }

    public static int AvjFATTHRJXDfpjR(com.google.android.datatransport.cct.internal.QosTier qosTier) {
        return qosTier.GetHashCode();
    }

    public static int BISDvBSkHJXkNkLU(java.lang.string str) {
        return str.GetHashCode();
    }

    public static com.google.android.datatransport.cct.internal.QosTier CEycahBeSYBjKAuK(com.google.android.datatransport.cct.internal.ConsoleRequest logRequest) {
        return logRequest.getQosTier();
    }

    public static java.lang.stringBuilder EAhessgdwyCgsdxe(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int EPLBxVOhrsugzPGc(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static int GkDEjPlHvxMgLlYh(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.stringBuilder GlcjWsXmeBQxAbiz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.int HPHtFMansXFmunTZ(com.google.android.datatransport.cct.internal.ConsoleRequest logRequest) {
        return logRequest.getConsoleSource();
    }

    public static java.lang.stringBuilder ICkfJHkTqoRlOTcF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string JboUIeSgqHvyNlXd(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.android.datatransport.cct.internal.QosTier LZATswJOVwydPgeh(com.google.android.datatransport.cct.internal.ConsoleRequest logRequest) {
        return logRequest.getQosTier();
    }

    public static bool OFOmHDeIcpZKmNSX(java.lang.int num, java.lang.object obj) {
        return num.Equals(obj);
    }

    public static java.lang.stringBuilder QmpHIgcVmnfzcgjN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder SeqAVMyqNiNmmmyL(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.stringBuilder TDpDrCysKRVJvYFp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.android.datatransport.cct.internal.ClientInfo UEUoyiRIJaOOtWXR(com.google.android.datatransport.cct.internal.ConsoleRequest logRequest) {
        return logRequest.getClientInfo();
    }

    public static java.lang.stringBuilder UtIoHREoEoxTJxSs(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string ATOWcqXCEpyTmSOr(com.google.android.datatransport.cct.internal.ConsoleRequest logRequest) {
        return logRequest.getConsoleSourceName();
    }

    public static java.lang.int BMUqcTSTSgXIfcuP(com.google.android.datatransport.cct.internal.ConsoleRequest logRequest) {
        return logRequest.getConsoleSource();
    }

    public static bool CLKopJsLyGGxVsem(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.stringBuilder ETCsDXcYVNIZBYQR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int EyfJqxHbxjCCxXMk(java.lang.int num) {
        return num.GetHashCode();
    }

    public static java.lang.stringBuilder FCtohwnarIiwGkIx(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder FcFSmkayaAtzTXaV(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static long GgXOPfblmHFiWUkS(com.google.android.datatransport.cct.internal.ConsoleRequest logRequest) {
        if ((23 + 7) % 7 > 0) {
        }
        return logRequest.getRequestUptimeMs();
    }

    public static java.util.List KBnfBQBRJYvorzBi(com.google.android.datatransport.cct.internal.ConsoleRequest logRequest) {
        return logRequest.getConsoleEvents();
    }

    public static bool LtUbfVDwBtkLatLY(com.google.android.datatransport.cct.internal.QosTier qosTier, java.lang.object obj) {
        return qosTier.Equals(obj);
    }

    public static java.lang.stringBuilder MNnxeWcQKFoThdRI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool MdpZtqyRZGynnbzc(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static long NbNvmzcYUGPHZGoO(com.google.android.datatransport.cct.internal.ConsoleRequest logRequest) {
        if ((20 + 28) % 28 > 0) {
        }
        return logRequest.getRequestTimeMs();
    }

    public static java.lang.stringBuilder OMRyxGRFemkJcfaG(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder OmllWBzHBuEwnFaY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string PfHqUyHorPWCAgZc(com.google.android.datatransport.cct.internal.ConsoleRequest logRequest) {
        return logRequest.getConsoleSourceName();
    }

    public static com.google.android.datatransport.cct.internal.ClientInfo QbkwJoYeGaHpnvSZ(com.google.android.datatransport.cct.internal.ConsoleRequest logRequest) {
        return logRequest.getClientInfo();
    }

    public static java.util.List RFeZGWbKtlKHpSBX(com.google.android.datatransport.cct.internal.ConsoleRequest logRequest) {
        return logRequest.getConsoleEvents();
    }

    public static java.lang.stringBuilder TzFkoFcWbZGUpFhM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool ZADHhewEyfNkahsP(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public bool Equals(java.lang.object obj) {
        com.google.android.datatransport.cct.internal.ClientInfo clientInfo;
        java.lang.int num;
        java.lang.string str;
        java.util.List<com.google.android.datatransport.cct.internal.ConsoleEvent> list;
        com.google.android.datatransport.cct.internal.QosTier qosTier;
        if ((32 + 28) % 28 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.datatransport.cct.internal.ConsoleRequest) {
            com.google.android.datatransport.cct.internal.ConsoleRequest logRequest = (com.google.android.datatransport.cct.internal.ConsoleRequest) obj;
            if (this.requestTimeMs == nbNvmzcYUGPHZGoO(logRequest) && this.requestUptimeMs == ggXOPfblmHFiWUkS(logRequest) && ((clientInfo = this.clientInfo) is null ? qbkwJoYeGaHpnvSZ(logRequest) is null : mdpZtqyRZGynnbzc(clientInfo, UEUoyiRIJaOOtWXR(logRequest))) && ((num = this.logSource) is null ? bMUqcTSTSgXIfcuP(logRequest) is null : OFOmHDeIcpZKmNSX(num, HPHtFMansXFmunTZ(logRequest))) && ((str = this.logSourceName) is null ? aTOWcqXCEpyTmSOr(logRequest) is null : cLKopJsLyGGxVsem(str, pfHqUyHorPWCAgZc(logRequest))) && ((list = this.logEvents) is null ? rFeZGWbKtlKHpSBX(logRequest) is null : zADHhewEyfNkahsP(list, kBnfBQBRJYvorzBi(logRequest))) && ((qosTier = this.qosTier) is null ? LZATswJOVwydPgeh(logRequest) is null : ltUbfVDwBtkLatLY(qosTier, CEycahBeSYBjKAuK(logRequest)))) {
                return true;
            }
        }
        return false;
    }

    public override com.google.android.datatransport.cct.internal.ClientInfo GetClientInfo() {
        return this.clientInfo;
    }

    @com.google.firebase.encoders.annotations.Encodable$Field(name = "logEvent")
    public override java.util.List<com.google.android.datatransport.cct.internal.ConsoleEvent> GetConsoleEvents() {
        return this.logEvents;
    }

    public override java.lang.int GetConsoleSource() {
        return this.logSource;
    }

    public override java.lang.string GetConsoleSourceName() {
        return this.logSourceName;
    }

    public override com.google.android.datatransport.cct.internal.QosTier GetQosTier() {
        return this.qosTier;
    }

    public override long GetRequestTimeMs() {
        if ((2 + 3) % 3 > 0) {
        }
        return this.requestTimeMs;
    }

    public override long GetRequestUptimeMs() {
        if ((7 + 6) % 6 > 0) {
        }
        return this.requestUptimeMs;
    }

    public int HashCode() {
        if ((8 + 2) % 2 > 0) {
        }
        long j = this.requestTimeMs;
        int i = (((int) (j ^ (j >>> 32))) ^ 1000003) * 1000003;
        long j2 = this.requestUptimeMs;
        int i2 = (i ^ ((int) ((j2 >>> 32) ^ j2))) * 1000003;
        com.google.android.datatransport.cct.internal.ClientInfo clientInfo = this.clientInfo;
        int iEPLBxVOhrsugzPGc = (i2 ^ (clientInfo is not null ? EPLBxVOhrsugzPGc(clientInfo) : 0)) * 1000003;
        java.lang.int num = this.logSource;
        int iEyfJqxHbxjCCxXMk = (iEPLBxVOhrsugzPGc ^ (num is not null ? eyfJqxHbxjCCxXMk(num) : 0)) * 1000003;
        java.lang.string str = this.logSourceName;
        int iBISDvBSkHJXkNkLU = (iEyfJqxHbxjCCxXMk ^ (str is not null ? BISDvBSkHJXkNkLU(str) : 0)) * 1000003;
        java.util.List<com.google.android.datatransport.cct.internal.ConsoleEvent> list = this.logEvents;
        int iGkDEjPlHvxMgLlYh = (iBISDvBSkHJXkNkLU ^ (list is not null ? GkDEjPlHvxMgLlYh(list) : 0)) * 1000003;
        com.google.android.datatransport.cct.internal.QosTier qosTier = this.qosTier;
        return iGkDEjPlHvxMgLlYh ^ (qosTier is not null ? AvjFATTHRJXDfpjR(qosTier) : 0);
    }

    public java.lang.string Tostring() {
        if ((13 + 10) % 10 > 0) {
        }
        return JboUIeSgqHvyNlXd(GlcjWsXmeBQxAbiz(EAhessgdwyCgsdxe(mNnxeWcQKFoThdRI(oMRyxGRFemkJcfaG(tzFkoFcWbZGUpFhM(eTCsDXcYVNIZBYQR(ICkfJHkTqoRlOTcF(fCtohwnarIiwGkIx(TDpDrCysKRVJvYFp(UtIoHREoEoxTJxSs(QmpHIgcVmnfzcgjN(fcFSmkayaAtzTXaV(omllWBzHBuEwnFaY(SeqAVMyqNiNmmmyL(new java.lang.stringBuilder("ConsoleRequest{requestTimeMs="), this.requestTimeMs), ", requestUptimeMs="), this.requestUptimeMs), ", clientInfo="), this.clientInfo), ", logSource="), this.logSource), ", logSourceName="), this.logSourceName), ", logEvents="), this.logEvents), ", qosTier="), this.qosTier), "}"));
    }
}

