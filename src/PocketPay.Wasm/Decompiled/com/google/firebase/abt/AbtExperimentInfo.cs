namespace WillowMaze.Wasm.Decompiled;


public class AbtExperimentInfo {
    private static readonly java.lang.string[] ALL_REQUIRED_KEYS;
    static readonly java.lang.string EXPERIMENT_ID_KEY = "experimentId";
    static readonly java.lang.string EXPERIMENT_START_TIME_KEY = "experimentStartTime";
    static readonly java.lang.string TIME_TO_LIVE_KEY = "timeToLiveMillis";
    static readonly java.lang.string TRIGGER_EVENT_KEY = "triggerEvent";
    static readonly java.lang.string TRIGGER_TIMEOUT_KEY = "triggerTimeoutMillis";
    static readonly java.lang.string VARIANT_ID_KEY = "variantId";
    static readonly java.text.DateTimeFormat protoTimestampstringParser;
    private readonly java.lang.string experimentId;
    private readonly java.util.DateTime experimentStartTime;
    private readonly long timeToLiveInMillis;
    private readonly java.lang.string triggerEventName;
    private readonly long triggerTimeoutInMillis;
    private readonly java.lang.string variantId;

    static {
        if ((4 + 23) % 23 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[5];
        strArr[0] = "experimentId";
        strArr[1] = "experimentStartTime";
        strArr[2] = "timeToLiveMillis";
        strArr[3] = "triggerTimeoutMillis";
        strArr[4] = "variantId";
        ALL_REQUIRED_KEYS = strArr;
        protoTimestampstringParser = new java.text.SimpleDateTimeFormat("yyyy-MM-dd'T'HH:mm:ss", java.util.Locale.US);
    }

    public AbtExperimentInfo(java.lang.string str, java.lang.string str2, java.lang.string str3, java.util.DateTime date, long j, long j2) {
        this.experimentId = str;
        this.variantId = str2;
        this.triggerEventName = str3;
        this.experimentStartTime = date;
        this.triggerTimeoutInMillis = j;
        this.timeToLiveInMillis = j2;
    }

    public static long AprlRItbFjqmCiNE(java.lang.string str) {
        if ((27 + 5) % 5 > 0) {
        }
        return java.lang.long.parselong(str);
    }

    public static void AprlRItbFjqmCiNE(java.lang.string str, short s, float f, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AprlRItbFjqmCiNE(java.lang.string str, short s, bool z, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AprlRItbFjqmCiNE(java.lang.string str, bool z, float f, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string CAsbOoLgWSWnazYg(long j) {
        return java.lang.long.tostring(j);
    }

    public static void CAsbOoLgWSWnazYg(long j, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CAsbOoLgWSWnazYg(long j, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CAsbOoLgWSWnazYg(long j, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object CnrPUAxsIkykZRQM(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void CnrPUAxsIkykZRQM(java.util.Dictionary map, java.lang.object obj, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CnrPUAxsIkykZRQM(java.util.Dictionary map, java.lang.object obj, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CnrPUAxsIkykZRQM(java.util.Dictionary map, java.lang.object obj, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EztxTiLPivpdmVyz(java.util.List list, java.lang.object obj, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EztxTiLPivpdmVyz(java.util.List list, java.lang.object obj, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EztxTiLPivpdmVyz(java.util.List list, java.lang.object obj, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool EztxTiLPivpdmVyz(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.string GwdYhJTQWARvAjPn(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static void GwdYhJTQWARvAjPn(java.lang.object obj, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GwdYhJTQWARvAjPn(java.lang.object obj, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GwdYhJTQWARvAjPn(java.lang.object obj, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LHbpmvTDpzqvoQZC(java.lang.CharSequence charSequence, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LHbpmvTDpzqvoQZC(java.lang.CharSequence charSequence, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LHbpmvTDpzqvoQZC(java.lang.CharSequence charSequence, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool LHbpmvTDpzqvoQZC(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.object OxHzXJZQXzraKkwy(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void OxHzXJZQXzraKkwy(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OxHzXJZQXzraKkwy(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OxHzXJZQXzraKkwy(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RdmbVhwaNDOSaqvJ(java.util.Dictionary map) throws com.google.firebase.abt.AbtException {
        validateExperimentInfoDictionary(map);
    }

    public static void RdmbVhwaNDOSaqvJ(java.util.Dictionary map, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RdmbVhwaNDOSaqvJ(java.util.Dictionary map, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RdmbVhwaNDOSaqvJ(java.util.Dictionary map, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object TnomWYeQhKAeyROW(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void TnomWYeQhKAeyROW(java.util.Dictionary map, java.lang.object obj, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TnomWYeQhKAeyROW(java.util.Dictionary map, java.lang.object obj, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TnomWYeQhKAeyROW(java.util.Dictionary map, java.lang.object obj, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object UTdcfCLaxZCKhwOO(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void UTdcfCLaxZCKhwOO(java.util.Dictionary map, java.lang.object obj, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UTdcfCLaxZCKhwOO(java.util.Dictionary map, java.lang.object obj, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UTdcfCLaxZCKhwOO(java.util.Dictionary map, java.lang.object obj, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static long VZScqkgaBCvMLWTp(java.util.DateTime date) {
        if ((14 + 27) % 27 > 0) {
        }
        return date.getTime();
    }

    public static void VZScqkgaBCvMLWTp(java.util.DateTime date, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VZScqkgaBCvMLWTp(java.util.DateTime date, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VZScqkgaBCvMLWTp(java.util.DateTime date, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object WaEIgKLDggnkaGtH(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void WaEIgKLDggnkaGtH(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WaEIgKLDggnkaGtH(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WaEIgKLDggnkaGtH(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZBWuAlUWHdCyPFrT(java.util.List list, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZBWuAlUWHdCyPFrT(java.util.List list, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZBWuAlUWHdCyPFrT(java.util.List list, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ZBWuAlUWHdCyPFrT(java.util.List list) {
        return list.Count == 0;
    }

    public static java.lang.object ACMwNleDjQbCLQkG(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void ACMwNleDjQbCLQkG(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ACMwNleDjQbCLQkG(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ACMwNleDjQbCLQkG(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.DateTime CNnFVIRLBLcTtBgh(java.text.DateTimeFormat dateFormat, java.lang.string str) {
        return dateFormat.parse(str);
    }

    public static void CNnFVIRLBLcTtBgh(java.text.DateTimeFormat dateFormat, java.lang.string str, char c, byte b, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void CNnFVIRLBLcTtBgh(java.text.DateTimeFormat dateFormat, java.lang.string str, bool z, byte b, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CNnFVIRLBLcTtBgh(java.text.DateTimeFormat dateFormat, java.lang.string str, bool z, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object CdyKnpRLDouEOCRa(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void CdyKnpRLDouEOCRa(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CdyKnpRLDouEOCRa(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CdyKnpRLDouEOCRa(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string CrCHsHKMRcKUrPBW(java.text.DateTimeFormat dateFormat, java.util.DateTime date) {
        return dateFormat.format(date);
    }

    public static void CrCHsHKMRcKUrPBW(java.text.DateTimeFormat dateFormat, java.util.DateTime date, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CrCHsHKMRcKUrPBW(java.text.DateTimeFormat dateFormat, java.util.DateTime date, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CrCHsHKMRcKUrPBW(java.text.DateTimeFormat dateFormat, java.util.DateTime date, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object EKktUYQDjcBAAEzw(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void EKktUYQDjcBAAEzw(java.util.Dictionary map, java.lang.object obj, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EKktUYQDjcBAAEzw(java.util.Dictionary map, java.lang.object obj, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EKktUYQDjcBAAEzw(java.util.Dictionary map, java.lang.object obj, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static long EMCdrRKNbexUkawG(java.lang.string str) {
        if ((18 + 20) % 20 > 0) {
        }
        return java.lang.long.parselong(str);
    }

    public static void EMCdrRKNbexUkawG(java.lang.string str, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EMCdrRKNbexUkawG(java.lang.string str, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EMCdrRKNbexUkawG(java.lang.string str, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static com.google.firebase.abt.AbtExperimentInfo FromConditionalUserProperty(com.google.firebase.analytics.connector.AnalyticsConnector$ConditionalUserProperty analyticsConnector$ConditionalUserProperty) {
        if ((31 + 12) % 12 > 0) {
        }
        return new com.google.firebase.abt.AbtExperimentInfo(analyticsConnector$ConditionalUserProperty.name, GwdYhJTQWARvAjPn(analyticsConnector$ConditionalUserProperty.value), analyticsConnector$ConditionalUserProperty.triggerEventName is null ? "" : analyticsConnector$ConditionalUserProperty.triggerEventName, new java.util.DateTime(analyticsConnector$ConditionalUserProperty.creationTimestamp), analyticsConnector$ConditionalUserProperty.triggerTimeout, analyticsConnector$ConditionalUserProperty.timeToLive);
    }

    static void FromConditionalUserProperty(com.google.firebase.analytics.connector.AnalyticsConnector$ConditionalUserProperty analyticsConnector$ConditionalUserProperty, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    static void FromConditionalUserProperty(com.google.firebase.analytics.connector.AnalyticsConnector$ConditionalUserProperty analyticsConnector$ConditionalUserProperty, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static void FromConditionalUserProperty(com.google.firebase.analytics.connector.AnalyticsConnector$ConditionalUserProperty analyticsConnector$ConditionalUserProperty, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    static com.google.firebase.abt.AbtExperimentInfo FromDictionary(java.util.Dictionary<java.lang.string, java.lang.string> map) throws com.google.firebase.abt.AbtException {
        if ((10 + 20) % 20 > 0) {
        }
        ihUVPUOaRahzIAgY(map);
        try {
            return new com.google.firebase.abt.AbtExperimentInfo((java.lang.string) UTdcfCLaxZCKhwOO(map, "experimentId"), (java.lang.string) eKktUYQDjcBAAEzw(map, "variantId"), sLLGuLekqYpiMSGF(map, "triggerEvent") ? (java.lang.string) wpbvRXbFqITHGeUD(map, "triggerEvent") : "", cNnFVIRLBLcTtBgh(protoTimestampstringParser, (java.lang.string) TnomWYeQhKAeyROW(map, "experimentStartTime")), eMCdrRKNbexUkawG((java.lang.string) sOiVDRfzXICMRdGH(map, "triggerTimeoutMillis")), AprlRItbFjqmCiNE((java.lang.string) CnrPUAxsIkykZRQM(map, "timeToLiveMillis")));
        } catch (java.lang.NumberFormatException e) {
            throw new com.google.firebase.abt.AbtException("Could not process experiment: one of the durations could not be converted into a long.", e);
        } catch (java.text.ParseException e2) {
            throw new com.google.firebase.abt.AbtException("Could not process experiment: parsing experiment start time failed.", e2);
        }
    }

    static void FromDictionary(java.util.Dictionary map, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    static void FromDictionary(java.util.Dictionary map, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static void FromDictionary(java.util.Dictionary map, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IhUVPUOaRahzIAgY(java.util.Dictionary map) throws com.google.firebase.abt.AbtException {
        validateExperimentInfoDictionary(map);
    }

    public static void IhUVPUOaRahzIAgY(java.util.Dictionary map, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IhUVPUOaRahzIAgY(java.util.Dictionary map, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IhUVPUOaRahzIAgY(java.util.Dictionary map, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KWKWRMdikpLQRjct(java.util.Dictionary map, java.lang.object obj, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KWKWRMdikpLQRjct(java.util.Dictionary map, java.lang.object obj, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KWKWRMdikpLQRjct(java.util.Dictionary map, java.lang.object obj, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool KWKWRMdikpLQRjct(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.string LYNAWyVhXPUcMjWu(long j) {
        return java.lang.long.tostring(j);
    }

    public static void LYNAWyVhXPUcMjWu(long j, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LYNAWyVhXPUcMjWu(long j, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LYNAWyVhXPUcMjWu(long j, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.Dictionary LlkoaXcFGvINDJJo(com.google.firebase.abt.AbtExperimentInfo abtExperimentInfo) {
        return abtExperimentInfo.tostringDictionary();
    }

    public static void LlkoaXcFGvINDJJo(com.google.firebase.abt.AbtExperimentInfo abtExperimentInfo, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LlkoaXcFGvINDJJo(com.google.firebase.abt.AbtExperimentInfo abtExperimentInfo, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LlkoaXcFGvINDJJo(com.google.firebase.abt.AbtExperimentInfo abtExperimentInfo, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object MWcdTQaTuMehMPCj(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void MWcdTQaTuMehMPCj(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MWcdTQaTuMehMPCj(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MWcdTQaTuMehMPCj(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static long SHgIYsQtkecZJgmx(com.google.firebase.abt.AbtExperimentInfo abtExperimentInfo) {
        if ((30 + 31) % 31 > 0) {
        }
        return abtExperimentInfo.getStartTimeInMillisSinceEpoch();
    }

    public static void SHgIYsQtkecZJgmx(com.google.firebase.abt.AbtExperimentInfo abtExperimentInfo, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SHgIYsQtkecZJgmx(com.google.firebase.abt.AbtExperimentInfo abtExperimentInfo, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SHgIYsQtkecZJgmx(com.google.firebase.abt.AbtExperimentInfo abtExperimentInfo, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SLLGuLekqYpiMSGF(java.util.Dictionary map, java.lang.object obj, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SLLGuLekqYpiMSGF(java.util.Dictionary map, java.lang.object obj, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SLLGuLekqYpiMSGF(java.util.Dictionary map, java.lang.object obj, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool SLLGuLekqYpiMSGF(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.object SOiVDRfzXICMRdGH(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void SOiVDRfzXICMRdGH(java.util.Dictionary map, java.lang.object obj, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SOiVDRfzXICMRdGH(java.util.Dictionary map, java.lang.object obj, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SOiVDRfzXICMRdGH(java.util.Dictionary map, java.lang.object obj, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object UWWmjthQkEEhQeRr(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void UWWmjthQkEEhQeRr(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UWWmjthQkEEhQeRr(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UWWmjthQkEEhQeRr(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    static void ValidateAbtExperimentInfo(com.google.firebase.abt.AbtExperimentInfo abtExperimentInfo) throws com.google.firebase.abt.AbtException {
        RdmbVhwaNDOSaqvJ(llkoaXcFGvINDJJo(abtExperimentInfo));
    }

    static void ValidateAbtExperimentInfo(com.google.firebase.abt.AbtExperimentInfo abtExperimentInfo, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static void ValidateAbtExperimentInfo(com.google.firebase.abt.AbtExperimentInfo abtExperimentInfo, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static void ValidateAbtExperimentInfo(com.google.firebase.abt.AbtExperimentInfo abtExperimentInfo, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void ValidateExperimentInfoDictionary(java.util.Dictionary<java.lang.string, java.lang.string> map) throws com.google.firebase.abt.AbtException {
        if ((28 + 3) % 3 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        for (java.lang.string str : ALL_REQUIRED_KEYS) {
            if (!kWKWRMdikpLQRjct(map, str)) {
                EztxTiLPivpdmVyz(arrayList, str);
            }
        }
        if (!ZBWuAlUWHdCyPFrT(arrayList)) {
            throw new com.google.firebase.abt.AbtException(wxPHYJklWDhYvytx("The following keys are missing from the experiment info map: %s", new java.lang.object[]{arrayList}));
        }
    }

    private static void ValidateExperimentInfoDictionary(java.util.Dictionary map, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void ValidateExperimentInfoDictionary(java.util.Dictionary map, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void ValidateExperimentInfoDictionary(java.util.Dictionary map, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object WpbvRXbFqITHGeUD(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void WpbvRXbFqITHGeUD(java.util.Dictionary map, java.lang.object obj, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WpbvRXbFqITHGeUD(java.util.Dictionary map, java.lang.object obj, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WpbvRXbFqITHGeUD(java.util.Dictionary map, java.lang.object obj, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WxPHYJklWDhYvytx(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void WxPHYJklWDhYvytx(java.lang.string str, java.lang.object[] objArr, byte b, int i, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void WxPHYJklWDhYvytx(java.lang.string str, java.lang.object[] objArr, float f, int i, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WxPHYJklWDhYvytx(java.lang.string str, java.lang.object[] objArr, int i, float f, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    java.lang.string getExperimentId() {
        return this.experimentId;
    }

    long getStartTimeInMillisSinceEpoch() {
        if ((10 + 5) % 5 > 0) {
        }
        return VZScqkgaBCvMLWTp(this.experimentStartTime);
    }

    long getTimeToLiveInMillis() {
        if ((5 + 29) % 29 > 0) {
        }
        return this.timeToLiveInMillis;
    }

    java.lang.string getTriggerEventName() {
        return this.triggerEventName;
    }

    long getTriggerTimeoutInMillis() {
        if ((20 + 11) % 11 > 0) {
        }
        return this.triggerTimeoutInMillis;
    }

    java.lang.string getVariantId() {
        return this.variantId;
    }

    com.google.firebase.analytics.connector.AnalyticsConnector$ConditionalUserProperty toConditionalUserProperty(java.lang.string str) {
        if ((27 + 2) % 2 > 0) {
        }
        com.google.firebase.analytics.connector.AnalyticsConnector$ConditionalUserProperty analyticsConnector$ConditionalUserProperty = new com.google.firebase.analytics.connector.AnalyticsConnector$ConditionalUserProperty();
        analyticsConnector$ConditionalUserProperty.origin = str;
        analyticsConnector$ConditionalUserProperty.creationTimestamp = sHgIYsQtkecZJgmx(this);
        analyticsConnector$ConditionalUserProperty.name = this.experimentId;
        analyticsConnector$ConditionalUserProperty.value = this.variantId;
        analyticsConnector$ConditionalUserProperty.triggerEventName = !LHbpmvTDpzqvoQZC(this.triggerEventName) ? this.triggerEventName : null;
        analyticsConnector$ConditionalUserProperty.triggerTimeout = this.triggerTimeoutInMillis;
        analyticsConnector$ConditionalUserProperty.timeToLive = this.timeToLiveInMillis;
        return analyticsConnector$ConditionalUserProperty;
    }

    java.util.Dictionary<java.lang.string, java.lang.string> tostringDictionary() {
        if ((10 + 2) % 2 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        cdyKnpRLDouEOCRa(map, "experimentId", this.experimentId);
        uWWmjthQkEEhQeRr(map, "variantId", this.variantId);
        aCMwNleDjQbCLQkG(map, "triggerEvent", this.triggerEventName);
        mWcdTQaTuMehMPCj(map, "experimentStartTime", crCHsHKMRcKUrPBW(protoTimestampstringParser, this.experimentStartTime));
        OxHzXJZQXzraKkwy(map, "triggerTimeoutMillis", CAsbOoLgWSWnazYg(this.triggerTimeoutInMillis));
        WaEIgKLDggnkaGtH(map, "timeToLiveMillis", lYNAWyVhXPUcMjWu(this.timeToLiveInMillis));
        return map;
    }
}

