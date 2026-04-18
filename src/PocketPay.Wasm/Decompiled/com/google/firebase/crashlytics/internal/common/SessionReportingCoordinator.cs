namespace WillowMaze.Wasm.Decompiled;


public class SessionReportingCoordinator {
    private static readonly int DEFAULT_BUFFER_SIZE = 8192;
    private static readonly int EVENT_THREAD_IMPORTANCE = 4;
    private static readonly java.lang.string EVENT_TYPE_CRASH = "crash";
    private static readonly java.lang.string EVENT_TYPE_LOGGED = "error";
    private static readonly int MAX_CHAINED_EXCEPTION_DEPTH = 8;
    private readonly com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers crashlyticsWorkers;
    private readonly com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture dataCapture;
    private readonly com.google.firebase.crashlytics.internal.common.IdManager idManager;
    private readonly com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager;
    private readonly com.google.firebase.crashlytics.internal.metadata.UserMetadata reportMetadata;
    private readonly com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence reportPersistence;
    private readonly com.google.firebase.crashlytics.internal.send.DataTransportCrashlyticsReportSender reportsSender;

    public static void $r8$lambda$QF1kRPr0KNFr9oZS58J5qfeKzRk(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.android.gms.tasks.Task task, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void $r8$lambda$QF1kRPr0KNFr9oZS58J5qfeKzRk(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.android.gms.tasks.Task task, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void $r8$lambda$QF1kRPr0KNFr9oZS58J5qfeKzRk(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.android.gms.tasks.Task task, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool $r8$lambda$QF1kRPr0KNFr9oZS58J5qfeKzRk(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.android.gms.tasks.Task task) {
        return QkTgHkVNAMOdwlKq(sessionReportingCoordinator, task);
    }

    SessionReportingCoordinator(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, com.google.firebase.crashlytics.internal.send.DataTransportCrashlyticsReportSender dataTransportCrashlyticsReportSender, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, com.google.firebase.crashlytics.internal.common.IdManager idManager, com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers crashlyticsWorkers) {
        this.dataCapture = crashlyticsReportDataCapture;
        this.reportPersistence = crashlyticsReportPersistence;
        this.reportsSender = dataTransportCrashlyticsReportSender;
        this.logstringManager = logstringManager;
        this.reportMetadata = userMetadata;
        this.idManager = idManager;
        this.crashlyticsWorkers = crashlyticsWorkers;
    }

    public static java.util.Dictionary AmXFCgTqEQCfveux(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.util.Dictionary map) {
        return userMetadata.getCustomKeys(map);
    }

    public static void AmXFCgTqEQCfveux(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.util.Dictionary map, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AmXFCgTqEQCfveux(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.util.Dictionary map, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AmXFCgTqEQCfveux(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.util.Dictionary map, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AuowwQMzAJXsLcdN(com.google.android.gms.tasks.Task task, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AuowwQMzAJXsLcdN(com.google.android.gms.tasks.Task task, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AuowwQMzAJXsLcdN(com.google.android.gms.tasks.Task task, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool AuowwQMzAJXsLcdN(com.google.android.gms.tasks.Task task) {
        return task.isSuccessful();
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutsState$Builder BFAbtkPuWbfniInQ() {
        return com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutsState.builder();
    }

    public static void BFAbtkPuWbfniInQ(float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BFAbtkPuWbfniInQ(short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BFAbtkPuWbfniInQ(bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task BbLTVofdqyydxeVd(java.util.ICollection collection) {
        return com.google.android.gms.tasks.Tasks.whenAll((java.util.ICollection<? : com.google.android.gms.tasks.Task<object>>) collection);
    }

    public static void BbLTVofdqyydxeVd(java.util.ICollection collection, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BbLTVofdqyydxeVd(java.util.ICollection collection, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BbLTVofdqyydxeVd(java.util.ICollection collection, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event BmAfmdcYPIhYWsxo(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.util.Dictionary map) {
        return sessionReportingCoordinator.addConsolesCustomKeysAndEventKeysToEvent(crashlyticsReport$Session$Event, logstringManager, userMetadata, map);
    }

    public static void BmAfmdcYPIhYWsxo(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.util.Dictionary map, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BmAfmdcYPIhYWsxo(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.util.Dictionary map, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BmAfmdcYPIhYWsxo(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.util.Dictionary map, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport BpUsdGRkgAmBVQMm(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str) {
        return crashlyticsReport.withFirebaseAuthenticationToken(str);
    }

    public static void BpUsdGRkgAmBVQMm(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BpUsdGRkgAmBVQMm(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BpUsdGRkgAmBVQMm(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder BwuArcKatCONjQcw(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application) {
        return crashlyticsReport$Session$Event$Application.toBuilder();
    }

    public static void BwuArcKatCONjQcw(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BwuArcKatCONjQcw(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BwuArcKatCONjQcw(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static long CCjSDQYdOjltnjvv(android.app.ApplicationExitInfo applicationExitInfo) {
        if ((18 + 28) % 28 > 0) {
        }
        return applicationExitInfo.getTimestamp();
    }

    public static void CCjSDQYdOjltnjvv(android.app.ApplicationExitInfo applicationExitInfo, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CCjSDQYdOjltnjvv(android.app.ApplicationExitInfo applicationExitInfo, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CCjSDQYdOjltnjvv(android.app.ApplicationExitInfo applicationExitInfo, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string COMewotStGNCjVWp(java.io.string file) {
        return file.getPath();
    }

    public static void COMewotStGNCjVWp(java.io.string file, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void COMewotStGNCjVWp(java.io.string file, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void COMewotStGNCjVWp(java.io.string file, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder ClySEvqqjGQTgwOU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutsState crashlyticsReport$Session$Event$RolloutsState) {
        return crashlyticsReport$Session$Event$Builder.setRollouts(crashlyticsReport$Session$Event$RolloutsState);
    }

    public static void ClySEvqqjGQTgwOU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutsState crashlyticsReport$Session$Event$RolloutsState, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ClySEvqqjGQTgwOU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutsState crashlyticsReport$Session$Event$RolloutsState, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ClySEvqqjGQTgwOU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutsState crashlyticsReport$Session$Event$RolloutsState, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string CnaseGYJaaaTYagC(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId) {
        return crashlyticsReportWithSessionId.getSessionId();
    }

    public static void CnaseGYJaaaTYagC(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CnaseGYJaaaTYagC(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CnaseGYJaaaTYagC(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CtrdHsFsZpfsYADb(java.util.IEnumerator it, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CtrdHsFsZpfsYADb(java.util.IEnumerator it, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CtrdHsFsZpfsYADb(java.util.IEnumerator it, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool CtrdHsFsZpfsYADb(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder DfbkHGmNfqMcvQQQ() {
        return com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo.builder();
    }

    public static void DfbkHGmNfqMcvQQQ(int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DfbkHGmNfqMcvQQQ(int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DfbkHGmNfqMcvQQQ(short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder DpZfUriLqPhTJjCi(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, int i) {
        return crashlyticsReport$ApplicationExitInfo$Builder.setImportance(i);
    }

    public static void DpZfUriLqPhTJjCi(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, int i, byte b, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DpZfUriLqPhTJjCi(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, int i, int i2, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DpZfUriLqPhTJjCi(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, int i, bool z, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo ECyoDIvWxrGjEWrJ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder) {
        return crashlyticsReport$ApplicationExitInfo$Builder.build();
    }

    public static void ECyoDIvWxrGjEWrJ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ECyoDIvWxrGjEWrJ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ECyoDIvWxrGjEWrJ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId EJCZoineItZwuajR(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, java.io.string file) {
        return com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId.create(crashlyticsReport, str, file);
    }

    public static void EJCZoineItZwuajR(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, java.io.string file, float f, java.lang.string str2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EJCZoineItZwuajR(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, java.io.string file, java.lang.string str2, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EJCZoineItZwuajR(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, java.io.string file, short s, java.lang.string str2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder EOyChMLGgwFnjusb(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, int i) {
        return crashlyticsReport$ApplicationExitInfo$Builder.setReasonCode(i);
    }

    public static void EOyChMLGgwFnjusb(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, int i, byte b, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EOyChMLGgwFnjusb(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, int i, java.lang.string str, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EOyChMLGgwFnjusb(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, int i, java.lang.string str, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ERkDeXTnaqrUagYq(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence) {
        crashlyticsReportPersistence.deleteAllReports();
    }

    public static void ERkDeXTnaqrUagYq(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ERkDeXTnaqrUagYq(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ERkDeXTnaqrUagYq(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object EVMrHgesBKIKDazC(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static void EVMrHgesBKIKDazC(java.util.Dictionary$Entry map$Entry, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EVMrHgesBKIKDazC(java.util.Dictionary$Entry map$Entry, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EVMrHgesBKIKDazC(java.util.Dictionary$Entry map$Entry, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EdDARjrOYSqbJfFP(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void EdDARjrOYSqbJfFP(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EdDARjrOYSqbJfFP(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EdDARjrOYSqbJfFP(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder FIoMuyeOsOJYOqiD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void FIoMuyeOsOJYOqiD(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FIoMuyeOsOJYOqiD(java.lang.stringBuilder sb, java.lang.string str, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FIoMuyeOsOJYOqiD(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder FRKBCOyDuYxNwJjl(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, long j) {
        return crashlyticsReport$ApplicationExitInfo$Builder.setTimestamp(j);
    }

    public static void FRKBCOyDuYxNwJjl(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, long j, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FRKBCOyDuYxNwJjl(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, long j, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FRKBCOyDuYxNwJjl(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, long j, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger FupLkxoAmelNVyhR() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void FupLkxoAmelNVyhR(float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FupLkxoAmelNVyhR(java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FupLkxoAmelNVyhR(java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GdIwmcqwvNgDckBs(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        crashlyticsReportPersistence.finalizeSessionWithNativeEvent(str, crashlyticsReport$stringsPayload, crashlyticsReport$ApplicationExitInfo);
    }

    public static void GdIwmcqwvNgDckBs(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, float f, short s, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GdIwmcqwvNgDckBs(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, float f, bool z, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GdIwmcqwvNgDckBs(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, bool z, float f, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger GhEOegCHoZKaFYeT() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void GhEOegCHoZKaFYeT(byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GhEOegCHoZKaFYeT(byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GhEOegCHoZKaFYeT(short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GuuSYgdcVFOFyvdp(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void GuuSYgdcVFOFyvdp(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, char c, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GuuSYgdcVFOFyvdp(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, java.lang.string str2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GuuSYgdcVFOFyvdp(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder HKuREQBLzEZfESZb(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void HKuREQBLzEZfESZb(java.lang.stringBuilder sb, java.lang.object obj, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HKuREQBLzEZfESZb(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HKuREQBLzEZfESZb(java.lang.stringBuilder sb, java.lang.object obj, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HWvOyXDowuWKMqdC(java.util.List list, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HWvOyXDowuWKMqdC(java.util.List list, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HWvOyXDowuWKMqdC(java.util.List list, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool HWvOyXDowuWKMqdC(java.util.List list) {
        return list.Count == 0;
    }

    public static int HXQftaGphHCCBgsA(android.app.ApplicationExitInfo applicationExitInfo) {
        return applicationExitInfo.getReason();
    }

    public static void HXQftaGphHCCBgsA(android.app.ApplicationExitInfo applicationExitInfo, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HXQftaGphHCCBgsA(android.app.ApplicationExitInfo applicationExitInfo, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HXQftaGphHCCBgsA(android.app.ApplicationExitInfo applicationExitInfo, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string HeqYfdHRaVHMSHCF(java.nio.charset.Charset charset) {
        return charset.name();
    }

    public static void HeqYfdHRaVHMSHCF(java.nio.charset.Charset charset, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HeqYfdHRaVHMSHCF(java.nio.charset.Charset charset, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HeqYfdHRaVHMSHCF(java.nio.charset.Charset charset, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder HjougXhJpzrGCgjF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void HjougXhJpzrGCgjF(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HjougXhJpzrGCgjF(java.lang.stringBuilder sb, java.lang.string str, char c, int i, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HjougXhJpzrGCgjF(java.lang.stringBuilder sb, java.lang.string str, int i, byte b, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object HoUaGgTOPdNCCuju(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void HoUaGgTOPdNCCuju(java.util.IEnumerator it, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HoUaGgTOPdNCCuju(java.util.IEnumerator it, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HoUaGgTOPdNCCuju(java.util.IEnumerator it, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string HvNCXQiCCnAPhlJi(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void HvNCXQiCCnAPhlJi(java.lang.stringBuilder sb, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HvNCXQiCCnAPhlJi(java.lang.stringBuilder sb, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HvNCXQiCCnAPhlJi(java.lang.stringBuilder sb, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List IHgLrsbfgQtsjnKm(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata) {
        return userMetadata.getRolloutsState();
    }

    public static void IHgLrsbfgQtsjnKm(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IHgLrsbfgQtsjnKm(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IHgLrsbfgQtsjnKm(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IKbPZdVVVuqzToFE(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void IKbPZdVVVuqzToFE(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, java.lang.string str2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IKbPZdVVVuqzToFE(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IKbPZdVVVuqzToFE(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, java.lang.string str2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int IYTxErhxQdSpjkis(java.util.Dictionary map) {
        return map.Count;
    }

    public static void IYTxErhxQdSpjkis(java.util.Dictionary map, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IYTxErhxQdSpjkis(java.util.Dictionary map, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IYTxErhxQdSpjkis(java.util.Dictionary map, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId IZjDEDomQcpRxcum(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId) {
        return sessionReportingCoordinator.ensureHasFid(crashlyticsReportWithSessionId);
    }

    public static void IZjDEDomQcpRxcum(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IZjDEDomQcpRxcum(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IZjDEDomQcpRxcum(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder JXMPuvzPMbjxGyah(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, long j) {
        return crashlyticsReport$ApplicationExitInfo$Builder.setPss(j);
    }

    public static void JXMPuvzPMbjxGyah(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, long j, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JXMPuvzPMbjxGyah(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, long j, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JXMPuvzPMbjxGyah(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, long j, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder JxjVDFWOBQTWfkGO(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, java.lang.string str) {
        return crashlyticsReport$ApplicationExitInfo$Builder.setProcessName(str);
    }

    public static void JxjVDFWOBQTWfkGO(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, java.lang.string str, int i, float f, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void JxjVDFWOBQTWfkGO(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, java.lang.string str, int i, java.lang.string str2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JxjVDFWOBQTWfkGO(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, java.lang.string str, java.lang.string str2, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List KZeFIsZYOhsfLYOs(java.util.List list) {
        return java.util.ICollections.unmodifiableList(list);
    }

    public static void KZeFIsZYOhsfLYOs(java.util.List list, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KZeFIsZYOhsfLYOs(java.util.List list, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KZeFIsZYOhsfLYOs(java.util.List list, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KxwbgTRbJhhGGIjh(java.util.IEnumerator it, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KxwbgTRbJhhGGIjh(java.util.IEnumerator it, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KxwbgTRbJhhGGIjh(java.util.IEnumerator it, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool KxwbgTRbJhhGGIjh(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.firebase.crashlytics.internal.Consoleger KytltAAYngRZsxSp() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void KytltAAYngRZsxSp(java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KytltAAYngRZsxSp(java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KytltAAYngRZsxSp(short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LBvSnbqjQPpZZQjL(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void LBvSnbqjQPpZZQjL(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, int i, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LBvSnbqjQPpZZQjL(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, java.lang.string str2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LBvSnbqjQPpZZQjL(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, int i, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string LVxAbAvQOmQFVZyc(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute crashlyticsReport$CustomAttribute) {
        return crashlyticsReport$CustomAttribute.getKey();
    }

    public static void LVxAbAvQOmQFVZyc(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute crashlyticsReport$CustomAttribute, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LVxAbAvQOmQFVZyc(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute crashlyticsReport$CustomAttribute, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LVxAbAvQOmQFVZyc(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute crashlyticsReport$CustomAttribute, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder LaZwfYJaACnyhuWu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void LaZwfYJaACnyhuWu(java.lang.stringBuilder sb, java.lang.string str, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LaZwfYJaACnyhuWu(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LaZwfYJaACnyhuWu(java.lang.stringBuilder sb, java.lang.string str, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string LxPLfLdsTkDbkRej(android.app.ApplicationExitInfo applicationExitInfo) {
        return applicationExitInfo.tostring();
    }

    public static void LxPLfLdsTkDbkRej(android.app.ApplicationExitInfo applicationExitInfo, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LxPLfLdsTkDbkRej(android.app.ApplicationExitInfo applicationExitInfo, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LxPLfLdsTkDbkRej(android.app.ApplicationExitInfo applicationExitInfo, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task MBcFsvQBIcEopdLD(com.google.firebase.crashlytics.internal.send.DataTransportCrashlyticsReportSender dataTransportCrashlyticsReportSender, com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, bool z) {
        return dataTransportCrashlyticsReportSender.enqueueReport(crashlyticsReportWithSessionId, z);
    }

    public static void MBcFsvQBIcEopdLD(com.google.firebase.crashlytics.internal.send.DataTransportCrashlyticsReportSender dataTransportCrashlyticsReportSender, com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, bool z, float f, byte b, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void MBcFsvQBIcEopdLD(com.google.firebase.crashlytics.internal.send.DataTransportCrashlyticsReportSender dataTransportCrashlyticsReportSender, com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, bool z, int i, byte b, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void MBcFsvQBIcEopdLD(com.google.firebase.crashlytics.internal.send.DataTransportCrashlyticsReportSender dataTransportCrashlyticsReportSender, com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, bool z, int i, float f, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MOKhTHzJWtmZmVjj(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void MOKhTHzJWtmZmVjj(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, byte b, java.lang.string str2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MOKhTHzJWtmZmVjj(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MOKhTHzJWtmZmVjj(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, java.lang.string str2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string MRAccAaUBugKbtJq(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata) {
        return eventMetadata.getSessionId();
    }

    public static void MRAccAaUBugKbtJq(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MRAccAaUBugKbtJq(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MRAccAaUBugKbtJq(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application MbNMjFdMSIMMgmPp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event) {
        return crashlyticsReport$Session$Event.getApp();
    }

    public static void MbNMjFdMSIMMgmPp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MbNMjFdMSIMMgmPp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MbNMjFdMSIMMgmPp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder MfeiJOmpuPgSPRkp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void MfeiJOmpuPgSPRkp(java.lang.stringBuilder sb, java.lang.string str, float f, int i, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MfeiJOmpuPgSPRkp(java.lang.stringBuilder sb, java.lang.string str, int i, float f, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void MfeiJOmpuPgSPRkp(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute$Builder MsAxkAafetQlcZkd(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute$Builder crashlyticsReport$CustomAttribute$Builder, java.lang.string str) {
        return crashlyticsReport$CustomAttribute$Builder.setKey(str);
    }

    public static void MsAxkAafetQlcZkd(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute$Builder crashlyticsReport$CustomAttribute$Builder, java.lang.string str, float f, java.lang.string str2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MsAxkAafetQlcZkd(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute$Builder crashlyticsReport$CustomAttribute$Builder, java.lang.string str, int i, char c, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MsAxkAafetQlcZkd(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute$Builder crashlyticsReport$CustomAttribute$Builder, java.lang.string str, java.lang.string str2, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event MsAydPrVwkOkFcFT(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.util.Dictionary map) {
        return sessionReportingCoordinator.addConsolesCustomKeysAndEventKeysToEvent(crashlyticsReport$Session$Event, logstringManager, userMetadata, map);
    }

    public static void MsAydPrVwkOkFcFT(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.util.Dictionary map, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MsAydPrVwkOkFcFT(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.util.Dictionary map, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MsAydPrVwkOkFcFT(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.util.Dictionary map, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload$Builder NhVJAJQrLVkJtUpq(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload$Builder crashlyticsReport$stringsPayload$Builder, java.util.List list) {
        return crashlyticsReport$stringsPayload$Builder.setstrings(list);
    }

    public static void NhVJAJQrLVkJtUpq(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload$Builder crashlyticsReport$stringsPayload$Builder, java.util.List list, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NhVJAJQrLVkJtUpq(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload$Builder crashlyticsReport$stringsPayload$Builder, java.util.List list, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NhVJAJQrLVkJtUpq(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload$Builder crashlyticsReport$stringsPayload$Builder, java.util.List list, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NxKPosEIxVZOJpqL(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, int i2) {
        byteArrayStream.write(bArr, i, i2);
    }

    public static void NxKPosEIxVZOJpqL(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, int i2, int i3, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NxKPosEIxVZOJpqL(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, int i2, java.lang.string str, int i3, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NxKPosEIxVZOJpqL(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, int i2, short s, int i3, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string OQSVTrZaZWIwIvkQ(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager) {
        return logstringManager.getConsolestring();
    }

    public static void OQSVTrZaZWIwIvkQ(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OQSVTrZaZWIwIvkQ(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OQSVTrZaZWIwIvkQ(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport OcKEOdfsgGCKpkCC(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId) {
        return crashlyticsReportWithSessionId.getReport();
    }

    public static void OcKEOdfsgGCKpkCC(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OcKEOdfsgGCKpkCC(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OcKEOdfsgGCKpkCC(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string OyXQIDETiGWcoGCF(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId) {
        return firebaseInstallationId.getFid();
    }

    public static void OyXQIDETiGWcoGCF(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OyXQIDETiGWcoGCF(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OyXQIDETiGWcoGCF(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport QZhVlQpvjuIQLIaL(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId) {
        return crashlyticsReportWithSessionId.getReport();
    }

    public static void QZhVlQpvjuIQLIaL(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QZhVlQpvjuIQLIaL(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QZhVlQpvjuIQLIaL(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger QjApjFcqkoirfxOm() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void QjApjFcqkoirfxOm(float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QjApjFcqkoirfxOm(int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QjApjFcqkoirfxOm(java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QkTgHkVNAMOdwlKq(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.android.gms.tasks.Task task, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QkTgHkVNAMOdwlKq(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.android.gms.tasks.Task task, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QkTgHkVNAMOdwlKq(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.android.gms.tasks.Task task, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool QkTgHkVNAMOdwlKq(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.android.gms.tasks.Task task) {
        return sessionReportingCoordinator.onReportSendComplete(task);
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload$string QtqAxyHcMFVWJlIt(com.google.firebase.crashlytics.internal.common.NativeSessionstring nativeSessionstring) {
        return nativeSessionstring.asstringPayload();
    }

    public static void QtqAxyHcMFVWJlIt(com.google.firebase.crashlytics.internal.common.NativeSessionstring nativeSessionstring, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QtqAxyHcMFVWJlIt(com.google.firebase.crashlytics.internal.common.NativeSessionstring nativeSessionstring, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QtqAxyHcMFVWJlIt(com.google.firebase.crashlytics.internal.common.NativeSessionstring nativeSessionstring, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string QwbeypqWnUQJKwlo(java.io.byteArrayStream byteArrayStream, java.lang.string str) {
        return byteArrayStream.tostring(str);
    }

    public static void QwbeypqWnUQJKwlo(java.io.byteArrayStream byteArrayStream, java.lang.string str, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QwbeypqWnUQJKwlo(java.io.byteArrayStream byteArrayStream, java.lang.string str, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QwbeypqWnUQJKwlo(java.io.byteArrayStream byteArrayStream, java.lang.string str, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger QyUckUCijpihdGOV() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void QyUckUCijpihdGOV(int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QyUckUCijpihdGOV(short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QyUckUCijpihdGOV(short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutsState RIqWtuPlXpRdIsUJ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutsState$Builder crashlyticsReport$Session$Event$RolloutsState$Builder) {
        return crashlyticsReport$Session$Event$RolloutsState$Builder.build();
    }

    public static void RIqWtuPlXpRdIsUJ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutsState$Builder crashlyticsReport$Session$Event$RolloutsState$Builder, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RIqWtuPlXpRdIsUJ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutsState$Builder crashlyticsReport$Session$Event$RolloutsState$Builder, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RIqWtuPlXpRdIsUJ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutsState$Builder crashlyticsReport$Session$Event$RolloutsState$Builder, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event ROBTvpJwpVGCRkFw(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata) {
        return sessionReportingCoordinator.addRolloutsStateToEvent(crashlyticsReport$Session$Event, userMetadata);
    }

    public static void ROBTvpJwpVGCRkFw(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ROBTvpJwpVGCRkFw(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ROBTvpJwpVGCRkFw(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator RSSHqvgjeQXiNmQi(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void RSSHqvgjeQXiNmQi(java.util.List list, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RSSHqvgjeQXiNmQi(java.util.List list, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RSSHqvgjeQXiNmQi(java.util.List list, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder RbQxuiokcUwRuIAj(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, java.lang.string str) {
        return crashlyticsReport$ApplicationExitInfo$Builder.setTracestring(str);
    }

    public static void RbQxuiokcUwRuIAj(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, java.lang.string str, char c, java.lang.string str2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RbQxuiokcUwRuIAj(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, java.lang.string str, java.lang.string str2, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RbQxuiokcUwRuIAj(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, java.lang.string str, bool z, byte b, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event SJbdeYshxxykMMsL(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata) {
        return sessionReportingCoordinator.addConsolesAndCustomKeysToEvent(crashlyticsReport$Session$Event, logstringManager, userMetadata);
    }

    public static void SJbdeYshxxykMMsL(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SJbdeYshxxykMMsL(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SJbdeYshxxykMMsL(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string TEkhtsSZUmOYKclT(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute crashlyticsReport$CustomAttribute) {
        return crashlyticsReport$CustomAttribute.getKey();
    }

    public static void TEkhtsSZUmOYKclT(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute crashlyticsReport$CustomAttribute, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TEkhtsSZUmOYKclT(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute crashlyticsReport$CustomAttribute, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TEkhtsSZUmOYKclT(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute crashlyticsReport$CustomAttribute, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.HashSet TNSwGnYMcXiuntUF(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static void TNSwGnYMcXiuntUF(java.util.Dictionary map, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TNSwGnYMcXiuntUF(java.util.Dictionary map, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TNSwGnYMcXiuntUF(java.util.Dictionary map, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Exception TZteohUWDicbudcV(com.google.android.gms.tasks.Task task) {
        return task.getException();
    }

    public static void TZteohUWDicbudcV(com.google.android.gms.tasks.Task task, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TZteohUWDicbudcV(com.google.android.gms.tasks.Task task, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TZteohUWDicbudcV(com.google.android.gms.tasks.Task task, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TewFxBuwBygoTNmC(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void TewFxBuwBygoTNmC(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TewFxBuwBygoTNmC(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TewFxBuwBygoTNmC(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List TjRXmuoQpewcqakN(java.util.List list) {
        return java.util.ICollections.unmodifiableList(list);
    }

    public static void TjRXmuoQpewcqakN(java.util.List list, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TjRXmuoQpewcqakN(java.util.List list, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TjRXmuoQpewcqakN(java.util.List list, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TukVSaQJuwXKujJA(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.Exception th, java.lang.Thread thread, java.lang.string str, com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, bool z) {
        sessionReportingCoordinator.persistEvent(th, thread, str, eventMetadata, z);
    }

    public static void TukVSaQJuwXKujJA(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.Exception th, java.lang.Thread thread, java.lang.string str, com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, bool z, int i, short s, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TukVSaQJuwXKujJA(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.Exception th, java.lang.Thread thread, java.lang.string str, com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, bool z, short s, bool z2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TukVSaQJuwXKujJA(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.Exception th, java.lang.Thread thread, java.lang.string str, com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, bool z, bool z2, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.io.Stream ULGADIzUztZFDRaf(android.app.ApplicationExitInfo applicationExitInfo) {
        return applicationExitInfo.getTraceStream();
    }

    public static void ULGADIzUztZFDRaf(android.app.ApplicationExitInfo applicationExitInfo, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ULGADIzUztZFDRaf(android.app.ApplicationExitInfo applicationExitInfo, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ULGADIzUztZFDRaf(android.app.ApplicationExitInfo applicationExitInfo, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UQWYDHwCFcHkmnsD(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void UQWYDHwCFcHkmnsD(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, java.lang.string str2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UQWYDHwCFcHkmnsD(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, float f, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void UQWYDHwCFcHkmnsD(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, java.lang.string str2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VCHeJnGIpLhRKbPA(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void VCHeJnGIpLhRKbPA(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VCHeJnGIpLhRKbPA(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VCHeJnGIpLhRKbPA(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VHcqMPoPLkWNoGIX(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m359w(str);
    }

    public static void VHcqMPoPLkWNoGIX(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, char c, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VHcqMPoPLkWNoGIX(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VHcqMPoPLkWNoGIX(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console VIMnfdsPnDTYyvci(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console$Builder crashlyticsReport$Session$Event$Console$Builder) {
        return crashlyticsReport$Session$Event$Console$Builder.build();
    }

    public static void VIMnfdsPnDTYyvci(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console$Builder crashlyticsReport$Session$Event$Console$Builder, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VIMnfdsPnDTYyvci(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console$Builder crashlyticsReport$Session$Event$Console$Builder, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VIMnfdsPnDTYyvci(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console$Builder crashlyticsReport$Session$Event$Console$Builder, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WfNksarVrtXyrWWp(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        crashlyticsReportPersistence.persistReport(crashlyticsReport);
    }

    public static void WfNksarVrtXyrWWp(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WfNksarVrtXyrWWp(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WfNksarVrtXyrWWp(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WtJiRHWdPuWVSdsz(java.util.List list, java.lang.object obj, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WtJiRHWdPuWVSdsz(java.util.List list, java.lang.object obj, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WtJiRHWdPuWVSdsz(java.util.List list, java.lang.object obj, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool WtJiRHWdPuWVSdsz(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.string XPsrLaRKCajTQZTF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void XPsrLaRKCajTQZTF(java.lang.stringBuilder sb, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XPsrLaRKCajTQZTF(java.lang.stringBuilder sb, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XPsrLaRKCajTQZTF(java.lang.stringBuilder sb, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder XaEHetyjhdjyahTs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void XaEHetyjhdjyahTs(java.lang.stringBuilder sb, java.lang.string str, float f, char c, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XaEHetyjhdjyahTs(java.lang.stringBuilder sb, java.lang.string str, float f, short s, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XaEHetyjhdjyahTs(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder YEQSyZxlabNRIyyz(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application) {
        return crashlyticsReport$Session$Event$Builder.setApp(crashlyticsReport$Session$Event$Application);
    }

    public static void YEQSyZxlabNRIyyz(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YEQSyZxlabNRIyyz(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YEQSyZxlabNRIyyz(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YXxHYlSbNarbUCQN(java.util.List list, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YXxHYlSbNarbUCQN(java.util.List list, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YXxHYlSbNarbUCQN(java.util.List list, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool YXxHYlSbNarbUCQN(java.util.List list) {
        return list.Count == 0;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder ZMoasVQPgoZjYDsK(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console crashlyticsReport$Session$Event$Console) {
        return crashlyticsReport$Session$Event$Builder.setConsole(crashlyticsReport$Session$Event$Console);
    }

    public static void ZMoasVQPgoZjYDsK(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console crashlyticsReport$Session$Event$Console, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZMoasVQPgoZjYDsK(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console crashlyticsReport$Session$Event$Console, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZMoasVQPgoZjYDsK(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console crashlyticsReport$Session$Event$Console, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ZOZrcKsZTdRDewZs(android.app.ApplicationExitInfo applicationExitInfo) {
        return applicationExitInfo.getReason();
    }

    public static void ZOZrcKsZTdRDewZs(android.app.ApplicationExitInfo applicationExitInfo, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZOZrcKsZTdRDewZs(android.app.ApplicationExitInfo applicationExitInfo, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZOZrcKsZTdRDewZs(android.app.ApplicationExitInfo applicationExitInfo, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console$Builder ZSFEATqKHNeohELP(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console$Builder crashlyticsReport$Session$Event$Console$Builder, java.lang.string str) {
        return crashlyticsReport$Session$Event$Console$Builder.setContent(str);
    }

    public static void ZSFEATqKHNeohELP(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console$Builder crashlyticsReport$Session$Event$Console$Builder, java.lang.string str, float f, int i, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void ZSFEATqKHNeohELP(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console$Builder crashlyticsReport$Session$Event$Console$Builder, java.lang.string str, int i, java.lang.string str2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZSFEATqKHNeohELP(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console$Builder crashlyticsReport$Session$Event$Console$Builder, java.lang.string str, java.lang.string str2, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo ZmkKAnYfeHWWOYAo(android.app.ApplicationExitInfo applicationExitInfo) {
        return convertApplicationExitInfo(applicationExitInfo);
    }

    public static void ZmkKAnYfeHWWOYAo(android.app.ApplicationExitInfo applicationExitInfo, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZmkKAnYfeHWWOYAo(android.app.ApplicationExitInfo applicationExitInfo, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZmkKAnYfeHWWOYAo(android.app.ApplicationExitInfo applicationExitInfo, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger ACAeTWOYolDomolR() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void ACAeTWOYolDomolR(char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ACAeTWOYolDomolR(char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ACAeTWOYolDomolR(java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutsState$Builder aMduWNuIOLnbDgjn(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutsState$Builder crashlyticsReport$Session$Event$RolloutsState$Builder, java.util.List list) {
        return crashlyticsReport$Session$Event$RolloutsState$Builder.setRolloutAssignments(list);
    }

    public static void AMduWNuIOLnbDgjn(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutsState$Builder crashlyticsReport$Session$Event$RolloutsState$Builder, java.util.List list, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AMduWNuIOLnbDgjn(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutsState$Builder crashlyticsReport$Session$Event$RolloutsState$Builder, java.util.List list, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AMduWNuIOLnbDgjn(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutsState$Builder crashlyticsReport$Session$Event$RolloutsState$Builder, java.util.List list, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.Dictionary AYkvrhcAdjgRqGPg(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata) {
        return eventMetadata.getAdditionalCustomKeys();
    }

    public static void AYkvrhcAdjgRqGPg(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AYkvrhcAdjgRqGPg(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AYkvrhcAdjgRqGPg(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event addConsolesAndCustomKeysToEvent(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata) {
        return BmAfmdcYPIhYWsxo(this, crashlyticsReport$Session$Event, logstringManager, userMetadata, cYhAitgsfovTInWL());
    }

    private void AddConsolesAndCustomKeysToEvent(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void AddConsolesAndCustomKeysToEvent(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void AddConsolesAndCustomKeysToEvent(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event addConsolesCustomKeysAndEventKeysToEvent(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.util.Dictionary<java.lang.string, java.lang.string> map) {
        com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$BuilderEOWaowwZzNsWAkAB = eOWaowwZzNsWAkAB(crashlyticsReport$Session$Event);
        java.lang.string strOQSVTrZaZWIwIvkQ = OQSVTrZaZWIwIvkQ(logstringManager);
        if (strOQSVTrZaZWIwIvkQ is null) {
            VCHeJnGIpLhRKbPA(KytltAAYngRZsxSp(), "No log data to include with this event.");
        } else {
            ZMoasVQPgoZjYDsK(crashlyticsReport$Session$Event$BuilderEOWaowwZzNsWAkAB, VIMnfdsPnDTYyvci(ZSFEATqKHNeohELP(zvLjYXxxyTRDLDud(), strOQSVTrZaZWIwIvkQ)));
        }
        java.util.List listXnRqJjaZvymOMUBl = xnRqJjaZvymOMUBl(AmXFCgTqEQCfveux(userMetadata, map));
        java.util.List listPozaXEFSQkOPWceI = pozaXEFSQkOPWceI(bwDJCMrBGVSYVfeY(userMetadata));
        if (!HWvOyXDowuWKMqdC(listXnRqJjaZvymOMUBl) || !YXxHYlSbNarbUCQN(listPozaXEFSQkOPWceI)) {
            YEQSyZxlabNRIyyz(crashlyticsReport$Session$Event$BuilderEOWaowwZzNsWAkAB, uDFdhiferRLevGhp(prOidJhMNTQTHNSN(gDMgpHoNXAjeZQTp(BwuArcKatCONjQcw(MbNMjFdMSIMMgmPp(crashlyticsReport$Session$Event)), listXnRqJjaZvymOMUBl), listPozaXEFSQkOPWceI)));
        }
        return dRzkoduTTEtMlMjU(crashlyticsReport$Session$Event$BuilderEOWaowwZzNsWAkAB);
    }

    private void AddConsolesCustomKeysAndEventKeysToEvent(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.util.Dictionary map, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void AddConsolesCustomKeysAndEventKeysToEvent(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.util.Dictionary map, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void AddConsolesCustomKeysAndEventKeysToEvent(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.util.Dictionary map, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event addMetaDataToEvent(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.util.Dictionary<java.lang.string, java.lang.string> map) {
        if ((10 + 32) % 32 > 0) {
        }
        return wkIWzrwzSQYUpVwN(this, MsAydPrVwkOkFcFT(this, crashlyticsReport$Session$Event, this.logstringManager, this.reportMetadata, map), this.reportMetadata);
    }

    private void AddMetaDataToEvent(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.util.Dictionary map, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private void AddMetaDataToEvent(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.util.Dictionary map, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void AddMetaDataToEvent(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.util.Dictionary map, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event addRolloutsStateToEvent(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata) {
        java.util.List listIHgLrsbfgQtsjnKm = IHgLrsbfgQtsjnKm(userMetadata);
        if (uGyQjaIUmqUiRlIL(listIHgLrsbfgQtsjnKm)) {
            return crashlyticsReport$Session$Event;
        }
        com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$BuilderPiYUKRWQeXpBFPwd = piYUKRWQeXpBFPwd(crashlyticsReport$Session$Event);
        ClySEvqqjGQTgwOU(crashlyticsReport$Session$Event$BuilderPiYUKRWQeXpBFPwd, RIqWtuPlXpRdIsUJ(aMduWNuIOLnbDgjn(BFAbtkPuWbfniInQ(), listIHgLrsbfgQtsjnKm)));
        return ihokLnuMrIBopfLM(crashlyticsReport$Session$Event$BuilderPiYUKRWQeXpBFPwd);
    }

    private void AddRolloutsStateToEvent(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void AddRolloutsStateToEvent(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void AddRolloutsStateToEvent(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute ahMsmtlvuVYengtD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute$Builder crashlyticsReport$CustomAttribute$Builder) {
        return crashlyticsReport$CustomAttribute$Builder.build();
    }

    public static void AhMsmtlvuVYengtD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute$Builder crashlyticsReport$CustomAttribute$Builder, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AhMsmtlvuVYengtD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute$Builder crashlyticsReport$CustomAttribute$Builder, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AhMsmtlvuVYengtD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute$Builder crashlyticsReport$CustomAttribute$Builder, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event ahuGzMjzoHuzbAhp(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        return crashlyticsReportDataCapture.captureAnrEventData(crashlyticsReport$ApplicationExitInfo);
    }

    public static void AhuGzMjzoHuzbAhp(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AhuGzMjzoHuzbAhp(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AhuGzMjzoHuzbAhp(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static long AuPXzuvMgAaSrVGK(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str) {
        if ((27 + 24) % 24 > 0) {
        }
        return crashlyticsReportPersistence.getStartTimestampMillis(str);
    }

    public static void AuPXzuvMgAaSrVGK(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str, float f, byte b, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AuPXzuvMgAaSrVGK(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str, java.lang.string str2, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AuPXzuvMgAaSrVGK(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str, java.lang.string str2, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string AzysDuRGsBWDlKak(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void AzysDuRGsBWDlKak(java.lang.stringBuilder sb, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AzysDuRGsBWDlKak(java.lang.stringBuilder sb, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AzysDuRGsBWDlKak(java.lang.stringBuilder sb, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object BFIGcTvjuVYDotxx(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static void BFIGcTvjuVYDotxx(java.util.Dictionary$Entry map$Entry, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BFIGcTvjuVYDotxx(java.util.Dictionary$Entry map$Entry, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BFIGcTvjuVYDotxx(java.util.Dictionary$Entry map$Entry, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BPWlIDcmMtoBSjco(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m359w(str);
    }

    public static void BPWlIDcmMtoBSjco(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, byte b, java.lang.string str2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BPWlIDcmMtoBSjco(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, byte b, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void BPWlIDcmMtoBSjco(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BbAwmwzqermvsGMf(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.Exception th, java.lang.Thread thread, java.lang.string str, com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, bool z) {
        sessionReportingCoordinator.persistEvent(th, thread, str, eventMetadata, z);
    }

    public static void BbAwmwzqermvsGMf(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.Exception th, java.lang.Thread thread, java.lang.string str, com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, bool z, float f, byte b, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void BbAwmwzqermvsGMf(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.Exception th, java.lang.Thread thread, java.lang.string str, com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, bool z, int i, byte b, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BbAwmwzqermvsGMf(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.Exception th, java.lang.Thread thread, java.lang.string str, com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, bool z, java.lang.string str2, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger BbcnqVDkKtFMfcET() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void BbcnqVDkKtFMfcET(char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BbcnqVDkKtFMfcET(char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BbcnqVDkKtFMfcET(bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BwBQwXRdRemAoYrF(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.lang.string str, bool z) {
        crashlyticsReportPersistence.persistEvent(crashlyticsReport$Session$Event, str, z);
    }

    public static void BwBQwXRdRemAoYrF(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.lang.string str, bool z, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BwBQwXRdRemAoYrF(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.lang.string str, bool z, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BwBQwXRdRemAoYrF(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.lang.string str, bool z, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.Dictionary BwDJCMrBGVSYVfeY(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata) {
        return userMetadata.getInternalKeys();
    }

    public static void BwDJCMrBGVSYVfeY(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BwDJCMrBGVSYVfeY(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BwDJCMrBGVSYVfeY(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport CEMKiavFxucsbcVq(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str) {
        return crashlyticsReport.withFirebaseInstallationId(str);
    }

    public static void CEMKiavFxucsbcVq(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, int i, bool z, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void CEMKiavFxucsbcVq(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, java.lang.string str2, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CEMKiavFxucsbcVq(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, bool z, float f, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CEqSdfdddLRrPCNS(java.util.IEnumerator it, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CEqSdfdddLRrPCNS(java.util.IEnumerator it, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CEqSdfdddLRrPCNS(java.util.IEnumerator it, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool CEqSdfdddLRrPCNS(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.stringBuilder CKNdLQkZwpCiPUIq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void CKNdLQkZwpCiPUIq(java.lang.stringBuilder sb, java.lang.string str, float f, java.lang.string str2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CKNdLQkZwpCiPUIq(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CKNdLQkZwpCiPUIq(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.Dictionary CYhAitgsfovTInWL() {
        return java.util.Dictionary.of();
    }

    public static void CYhAitgsfovTInWL(byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CYhAitgsfovTInWL(byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CYhAitgsfovTInWL(int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CYiEtUoYkkGWKpUA(java.util.List arrayList, java.lang.object obj, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CYiEtUoYkkGWKpUA(java.util.List arrayList, java.lang.object obj, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CYiEtUoYkkGWKpUA(java.util.List arrayList, java.lang.object obj, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool CYiEtUoYkkGWKpUA(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.lang.stringBuilder CocrTFCOilmdKXAQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void CocrTFCOilmdKXAQ(java.lang.stringBuilder sb, java.lang.string str, char c, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void CocrTFCOilmdKXAQ(java.lang.stringBuilder sb, java.lang.string str, short s, java.lang.string str2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CocrTFCOilmdKXAQ(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    private static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo convertApplicationExitInfo(android.app.ApplicationExitInfo applicationExitInfo) {
        if ((9 + 3) % 3 > 0) {
        }
        java.lang.string strLpUtkDoIiDvXaYwx = null;
        try {
            java.io.Stream inputStreamULGADIzUztZFDRaf = ULGADIzUztZFDRaf(applicationExitInfo);
            if (inputStreamULGADIzUztZFDRaf is not null) {
                strLpUtkDoIiDvXaYwx = lpUtkDoIiDvXaYwx(inputStreamULGADIzUztZFDRaf);
            }
        } catch (java.io.IOException e) {
            bPWlIDcmMtoBSjco(pqaHDqRydIHNWiHw(), azysDuRGsBWDlKak(HKuREQBLzEZfESZb(XaEHetyjhdjyahTs(FIoMuyeOsOJYOqiD(new java.lang.stringBuilder("Could not get input trace in application exit info: "), LxPLfLdsTkDbkRej(applicationExitInfo)), " Error: "), e)));
        }
        return ECyoDIvWxrGjEWrJ(RbQxuiokcUwRuIAj(hLjgcIecQNgxSINb(JXMPuvzPMbjxGyah(mmSRDTeDPHpwxrYA(FRKBCOyDuYxNwJjl(EOyChMLGgwFnjusb(JxjVDFWOBQTWfkGO(DpZfUriLqPhTJjCi(DfbkHGmNfqMcvQQQ(), yISpCJQrFOvEAqaJ(applicationExitInfo)), onWTSEspelKfnDxc(applicationExitInfo)), ZOZrcKsZTdRDewZs(applicationExitInfo)), CCjSDQYdOjltnjvv(applicationExitInfo)), zADdujaPWlUyCJJW(applicationExitInfo)), nAMiqwvXaJQdLHMO(applicationExitInfo)), yWTgeBDVHQfTpthw(applicationExitInfo)), strLpUtkDoIiDvXaYwx));
    }

    private static void ConvertApplicationExitInfo(android.app.ApplicationExitInfo applicationExitInfo, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private static void ConvertApplicationExitInfo(android.app.ApplicationExitInfo applicationExitInfo, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private static void ConvertApplicationExitInfo(android.app.ApplicationExitInfo applicationExitInfo, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ConvertStreamTostring(java.io.Stream inputStream) throws java.io.IOException {
        if ((17 + 7) % 7 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        byte[] bArr = new byte[8192];
        while (true) {
            int iMuJllEAOAqSkledy = muJllEAOAqSkledy(inputStream, bArr);
            if (iMuJllEAOAqSkledy == -1) {
                return QwbeypqWnUQJKwlo(byteArrayStream, HeqYfdHRaVHMSHCF(java.nio.charset.StandardCharsets.UTF_8));
            }
            NxKPosEIxVZOJpqL(byteArrayStream, bArr, 0, iMuJllEAOAqSkledy);
        }
    }

    public static void ConvertStreamTostring(java.io.Stream inputStream, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ConvertStreamTostring(java.io.Stream inputStream, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ConvertStreamTostring(java.io.Stream inputStream, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator Create(android.content.object context, com.google.firebase.crashlytics.internal.common.IdManager idManager, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, com.google.firebase.crashlytics.internal.common.AppData appData, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber, com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers crashlyticsWorkers) {
        if ((26 + 28) % 28 > 0) {
        }
        return new com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator(new com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture(context, idManager, appData, stackTraceTrimmingStrategy, settingsProvider), new com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence(fileStore, settingsProvider, crashlyticsAppQualitySessionsSubscriber), hawURfsDldwLlegS(context, settingsProvider, onDemandCounter), logstringManager, userMetadata, idManager, crashlyticsWorkers);
    }

    public static void Create(android.content.object context, com.google.firebase.crashlytics.internal.common.IdManager idManager, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, com.google.firebase.crashlytics.internal.common.AppData appData, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber, com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers crashlyticsWorkers, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Create(android.content.object context, com.google.firebase.crashlytics.internal.common.IdManager idManager, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, com.google.firebase.crashlytics.internal.common.AppData appData, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber, com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers crashlyticsWorkers, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void Create(android.content.object context, com.google.firebase.crashlytics.internal.common.IdManager idManager, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, com.google.firebase.crashlytics.internal.common.AppData appData, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber, com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers crashlyticsWorkers, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger DHhedmFKQurxSOAw() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void DHhedmFKQurxSOAw(byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DHhedmFKQurxSOAw(java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DHhedmFKQurxSOAw(bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DResRzZgxNRXkJlO(java.lang.string str, java.lang.object obj, float f, bool z, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void DResRzZgxNRXkJlO(java.lang.string str, java.lang.object obj, java.lang.string str2, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DResRzZgxNRXkJlO(java.lang.string str, java.lang.object obj, bool z, float f, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool DResRzZgxNRXkJlO(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event dRzkoduTTEtMlMjU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder) {
        return crashlyticsReport$Session$Event$Builder.build();
    }

    public static void DRzkoduTTEtMlMjU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DRzkoduTTEtMlMjU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DRzkoduTTEtMlMjU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object EGYlWinWeikaxEHW(com.google.android.gms.tasks.Task task) {
        return task.getResult();
    }

    public static void EGYlWinWeikaxEHW(com.google.android.gms.tasks.Task task, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EGYlWinWeikaxEHW(com.google.android.gms.tasks.Task task, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EGYlWinWeikaxEHW(com.google.android.gms.tasks.Task task, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder eOWaowwZzNsWAkAB(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event) {
        return crashlyticsReport$Session$Event.toBuilder();
    }

    public static void EOWaowwZzNsWAkAB(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EOWaowwZzNsWAkAB(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EOWaowwZzNsWAkAB(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EbnSXItDliQZakLt(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th) {
        logger.m360w(str, th);
    }

    public static void EbnSXItDliQZakLt(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, float f, char c, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void EbnSXItDliQZakLt(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, float f, bool z, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void EbnSXItDliQZakLt(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, java.lang.string str2, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId EnsureHasFid(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId) {
        if ((21 + 18) % 18 > 0) {
        }
        if (vlZOKbCZeBsDHnja(fEcsMovdlUqwZBHJ(crashlyticsReportWithSessionId)) is not null && rDHUsPFXmuRMDaqt(QZhVlQpvjuIQLIaL(crashlyticsReportWithSessionId)) is not null) {
            return crashlyticsReportWithSessionId;
        }
        com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationIdYGPcbKMDANtvCVZM = yGPcbKMDANtvCVZM(this.idManager, true);
        return EJCZoineItZwuajR(BpUsdGRkgAmBVQMm(cEMKiavFxucsbcVq(OcKEOdfsgGCKpkCC(crashlyticsReportWithSessionId), OyXQIDETiGWcoGCF(firebaseInstallationIdYGPcbKMDANtvCVZM)), nHawJRdxOmYIaqKQ(firebaseInstallationIdYGPcbKMDANtvCVZM)), wxByhWwHLfsErBYv(crashlyticsReportWithSessionId), rXIHLSjVQllerHIB(crashlyticsReportWithSessionId));
    }

    private void EnsureHasFid(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void EnsureHasFid(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void EnsureHasFid(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport FEcsMovdlUqwZBHJ(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId) {
        return crashlyticsReportWithSessionId.getReport();
    }

    public static void FEcsMovdlUqwZBHJ(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FEcsMovdlUqwZBHJ(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FEcsMovdlUqwZBHJ(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object FPUsadzyPhgFZpnT(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void FPUsadzyPhgFZpnT(java.util.IEnumerator it, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FPUsadzyPhgFZpnT(java.util.IEnumerator it, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FPUsadzyPhgFZpnT(java.util.IEnumerator it, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private android.app.ApplicationExitInfo FindRelevantApplicationExitInfo(java.lang.string str, java.util.List<android.app.ApplicationExitInfo> list) {
        if ((30 + 20) % 20 > 0) {
        }
        long jAuPXzuvMgAaSrVGK = auPXzuvMgAaSrVGK(this.reportPersistence, str);
        java.util.IEnumerator itYUwhBSwHOVyYajoh = yUwhBSwHOVyYajoh(list);
        while (qySypHOFwRKJfSla(itYUwhBSwHOVyYajoh)) {
            android.app.ApplicationExitInfo applicationExitInfo = (android.app.ApplicationExitInfo) HoUaGgTOPdNCCuju(itYUwhBSwHOVyYajoh);
            if (rRcJYCudHxIKHkuu(applicationExitInfo) < jAuPXzuvMgAaSrVGK) {
                return null;
            }
            if (HXQftaGphHCCBgsA(applicationExitInfo) == 6) {
                return applicationExitInfo;
            }
        }
        return null;
    }

    private void FindRelevantApplicationExitInfo(java.lang.string str, java.util.List list, int i, byte b, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private void FindRelevantApplicationExitInfo(java.lang.string str, java.util.List list, java.lang.string str2, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void FindRelevantApplicationExitInfo(java.lang.string str, java.util.List list, java.lang.string str2, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute$Builder fwQKmfBiaNMdnJOq() {
        return com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute.builder();
    }

    public static void FwQKmfBiaNMdnJOq(byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FwQKmfBiaNMdnJOq(char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FwQKmfBiaNMdnJOq(int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator FyiDTIyPsXkKQljl(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void FyiDTIyPsXkKQljl(java.util.List list, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FyiDTIyPsXkKQljl(java.util.List list, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FyiDTIyPsXkKQljl(java.util.List list, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder gDMgpHoNXAjeZQTp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, java.util.List list) {
        return crashlyticsReport$Session$Event$Application$Builder.setCustomAttributes(list);
    }

    public static void GDMgpHoNXAjeZQTp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, java.util.List list, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GDMgpHoNXAjeZQTp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, java.util.List list, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GDMgpHoNXAjeZQTp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, java.util.List list, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private static java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute> getSortedCustomAttributes(java.util.Dictionary<java.lang.string, java.lang.string> map) {
        if ((9 + 1) % 1 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        sKxdsXDYqeQDyNdc(arrayList, IYTxErhxQdSpjkis(map));
        java.util.IEnumerator itJUlzhOFkarfvDmkx = jUlzhOFkarfvDmkx(TNSwGnYMcXiuntUF(map));
        while (cEqSdfdddLRrPCNS(itJUlzhOFkarfvDmkx)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) fPUsadzyPhgFZpnT(itJUlzhOFkarfvDmkx);
            cYiEtUoYkkGWKpUA(arrayList, ahMsmtlvuVYengtD(opmubsdtsyGaOzNd(MsAxkAafetQlcZkd(fwQKmfBiaNMdnJOq(), (java.lang.string) EVMrHgesBKIKDazC(map$Entry)), (java.lang.string) bFIGcTvjuVYDotxx(map$Entry))));
        }
        qffUifQKZIhVbhvY(arrayList, new com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator$$ExternalSyntheticLambda1());
        return KZeFIsZYOhsfLYOs(arrayList);
    }

    private static void GetSortedCustomAttributes(java.util.Dictionary map, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private static void GetSortedCustomAttributes(java.util.Dictionary map, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void GetSortedCustomAttributes(java.util.Dictionary map, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger GjNvkeGkgQyHUCMk() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void GjNvkeGkgQyHUCMk(byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GjNvkeGkgQyHUCMk(byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GjNvkeGkgQyHUCMk(int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HGmLRpovImSXUiDI(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str, long j) {
        crashlyticsReportPersistence.finalizeReports(str, j);
    }

    public static void HGmLRpovImSXUiDI(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str, long j, byte b, java.lang.string str2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HGmLRpovImSXUiDI(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str, long j, float f, byte b, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void HGmLRpovImSXUiDI(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str, long j, java.lang.string str2, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder hLjgcIecQNgxSINb(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, long j) {
        return crashlyticsReport$ApplicationExitInfo$Builder.setRss(j);
    }

    public static void HLjgcIecQNgxSINb(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, long j, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HLjgcIecQNgxSINb(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, long j, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HLjgcIecQNgxSINb(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, long j, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HNupTGxFBRgEYqTy(java.lang.string str, java.lang.object obj, byte b, java.lang.string str2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HNupTGxFBRgEYqTy(java.lang.string str, java.lang.object obj, char c, byte b, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HNupTGxFBRgEYqTy(java.lang.string str, java.lang.object obj, java.lang.string str2, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool HNupTGxFBRgEYqTy(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static com.google.firebase.crashlytics.internal.send.DataTransportCrashlyticsReportSender HawURfsDldwLlegS(android.content.object context, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter) {
        return com.google.firebase.crashlytics.internal.send.DataTransportCrashlyticsReportSender.create(context, settingsProvider, onDemandCounter);
    }

    public static void HawURfsDldwLlegS(android.content.object context, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HawURfsDldwLlegS(android.content.object context, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HawURfsDldwLlegS(android.content.object context, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object HqyxMFRKUyufvrdK(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void HqyxMFRKUyufvrdK(java.util.IEnumerator it, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HqyxMFRKUyufvrdK(java.util.IEnumerator it, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HqyxMFRKUyufvrdK(java.util.IEnumerator it, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event ihokLnuMrIBopfLM(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder) {
        return crashlyticsReport$Session$Event$Builder.build();
    }

    public static void IhokLnuMrIBopfLM(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IhokLnuMrIBopfLM(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IhokLnuMrIBopfLM(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.SortedHashSet JEhBAumjELzFCuhM(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence) {
        return crashlyticsReportPersistence.getOpenSessionIds();
    }

    public static void JEhBAumjELzFCuhM(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JEhBAumjELzFCuhM(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JEhBAumjELzFCuhM(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string JOxrDXUpFZtKOBLb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void JOxrDXUpFZtKOBLb(java.lang.stringBuilder sb, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JOxrDXUpFZtKOBLb(java.lang.stringBuilder sb, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JOxrDXUpFZtKOBLb(java.lang.stringBuilder sb, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator JUlzhOFkarfvDmkx(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void JUlzhOFkarfvDmkx(java.util.HashSet set, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JUlzhOFkarfvDmkx(java.util.HashSet set, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JUlzhOFkarfvDmkx(java.util.HashSet set, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string JsQgxPcnzFdgOdIT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void JsQgxPcnzFdgOdIT(java.lang.stringBuilder sb, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JsQgxPcnzFdgOdIT(java.lang.stringBuilder sb, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JsQgxPcnzFdgOdIT(java.lang.stringBuilder sb, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KbFonPeScKqhYnIx(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata) {
        return eventMetadata.getSessionId();
    }

    public static void KbFonPeScKqhYnIx(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KbFonPeScKqhYnIx(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KbFonPeScKqhYnIx(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event klAvQusdBpkVcDQX(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.Exception th, java.lang.Thread thread, java.lang.string str, long j, int i, int i2, bool z) {
        return crashlyticsReportDataCapture.captureEventData(th, thread, str, j, i, i2, z);
    }

    public static void KlAvQusdBpkVcDQX(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.Exception th, java.lang.Thread thread, java.lang.string str, long j, int i, int i2, bool z, short s, byte b, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KlAvQusdBpkVcDQX(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.Exception th, java.lang.Thread thread, java.lang.string str, long j, int i, int i2, bool z, short s, char c, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KlAvQusdBpkVcDQX(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.Exception th, java.lang.Thread thread, java.lang.string str, long j, int i, int i2, bool z, bool z2, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KonYmDzDpNBfosle(java.util.List arrayList, java.lang.object obj, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KonYmDzDpNBfosle(java.util.List arrayList, java.lang.object obj, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KonYmDzDpNBfosle(java.util.List arrayList, java.lang.object obj, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool KonYmDzDpNBfosle(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static com.google.android.gms.tasks.Task KozRhsuHhBKMUmez(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.util.concurrent.Executor executor, java.lang.string str) {
        return sessionReportingCoordinator.sendReports(executor, str);
    }

    public static void KozRhsuHhBKMUmez(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.util.concurrent.Executor executor, java.lang.string str, byte b, bool z, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void KozRhsuHhBKMUmez(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.util.concurrent.Executor executor, java.lang.string str, float f, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void KozRhsuHhBKMUmez(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.util.concurrent.Executor executor, java.lang.string str, java.lang.string str2, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload lAhJJyGPoaOvEgio(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload$Builder crashlyticsReport$stringsPayload$Builder) {
        return crashlyticsReport$stringsPayload$Builder.build();
    }

    public static void LAhJJyGPoaOvEgio(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload$Builder crashlyticsReport$stringsPayload$Builder, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LAhJJyGPoaOvEgio(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload$Builder crashlyticsReport$stringsPayload$Builder, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LAhJJyGPoaOvEgio(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload$Builder crashlyticsReport$stringsPayload$Builder, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    static int lambda$getSortedCustomAttributes$1(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute crashlyticsReport$CustomAttribute, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute crashlyticsReport$CustomAttribute2) {
        return omRlWdjNCaCDiitS(LVxAbAvQOmQFVZyc(crashlyticsReport$CustomAttribute), TEkhtsSZUmOYKclT(crashlyticsReport$CustomAttribute2));
    }

    static void lambda$getSortedCustomAttributes$1(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute crashlyticsReport$CustomAttribute, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute crashlyticsReport$CustomAttribute2, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    static void lambda$getSortedCustomAttributes$1(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute crashlyticsReport$CustomAttribute, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute crashlyticsReport$CustomAttribute2, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static void lambda$getSortedCustomAttributes$1(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute crashlyticsReport$CustomAttribute, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute crashlyticsReport$CustomAttribute2, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger LcuxwHbxXERUVXSq() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void LcuxwHbxXERUVXSq(float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LcuxwHbxXERUVXSq(int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LcuxwHbxXERUVXSq(java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string LpUtkDoIiDvXaYwx(java.io.Stream inputStream) {
        return convertStreamTostring(inputStream);
    }

    public static void LpUtkDoIiDvXaYwx(java.io.Stream inputStream, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LpUtkDoIiDvXaYwx(java.io.Stream inputStream, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LpUtkDoIiDvXaYwx(java.io.Stream inputStream, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder mmSRDTeDPHpwxrYA(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, int i) {
        return crashlyticsReport$ApplicationExitInfo$Builder.setPid(i);
    }

    public static void MmSRDTeDPHpwxrYA(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, int i, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MmSRDTeDPHpwxrYA(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, int i, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MmSRDTeDPHpwxrYA(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, int i, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int MuJllEAOAqSkledy(java.io.Stream inputStream, byte[] bArr) {
        return inputStream.read(bArr);
    }

    public static void MuJllEAOAqSkledy(java.io.Stream inputStream, byte[] bArr, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MuJllEAOAqSkledy(java.io.Stream inputStream, byte[] bArr, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MuJllEAOAqSkledy(java.io.Stream inputStream, byte[] bArr, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string MuiIBHSQnXoKpEGC(java.io.string file) {
        return file.getPath();
    }

    public static void MuiIBHSQnXoKpEGC(java.io.string file, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MuiIBHSQnXoKpEGC(java.io.string file, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MuiIBHSQnXoKpEGC(java.io.string file, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder MxEURZNmnnJchrKF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void MxEURZNmnnJchrKF(java.lang.stringBuilder sb, java.lang.string str, char c, short s, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MxEURZNmnnJchrKF(java.lang.stringBuilder sb, java.lang.string str, float f, char c, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void MxEURZNmnnJchrKF(java.lang.stringBuilder sb, java.lang.string str, short s, float f, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task MxdWBBJlwFcQxFVO(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable) {
        return crashlyticsWorker.submit(runnable);
    }

    public static void MxdWBBJlwFcQxFVO(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MxdWBBJlwFcQxFVO(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MxdWBBJlwFcQxFVO(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static long NAMiqwvXaJQdLHMO(android.app.ApplicationExitInfo applicationExitInfo) {
        if ((7 + 18) % 18 > 0) {
        }
        return applicationExitInfo.getPss();
    }

    public static void NAMiqwvXaJQdLHMO(android.app.ApplicationExitInfo applicationExitInfo, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NAMiqwvXaJQdLHMO(android.app.ApplicationExitInfo applicationExitInfo, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NAMiqwvXaJQdLHMO(android.app.ApplicationExitInfo applicationExitInfo, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NHawJRdxOmYIaqKQ(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId) {
        return firebaseInstallationId.getAuthToken();
    }

    public static void NHawJRdxOmYIaqKQ(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NHawJRdxOmYIaqKQ(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NHawJRdxOmYIaqKQ(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NKjFrKViDQTNKlAm(java.io.string file, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NKjFrKViDQTNKlAm(java.io.string file, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NKjFrKViDQTNKlAm(java.io.string file, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NKjFrKViDQTNKlAm(java.io.string file) {
        return file.delete();
    }

    public static java.lang.string NXnVLjKKCpjQnYhO(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId) {
        return crashlyticsReportWithSessionId.getSessionId();
    }

    public static void NXnVLjKKCpjQnYhO(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NXnVLjKKCpjQnYhO(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NXnVLjKKCpjQnYhO(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport OGsLxydUcKDyaMqe(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.string str, long j) {
        return crashlyticsReportDataCapture.captureReportData(str, j);
    }

    public static void OGsLxydUcKDyaMqe(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.string str, long j, byte b, java.lang.string str2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OGsLxydUcKDyaMqe(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.string str, long j, short s, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void OGsLxydUcKDyaMqe(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.string str, long j, short s, bool z, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OeKnfpAuChnatAHQ(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.lang.string str, bool z) {
        crashlyticsReportPersistence.persistEvent(crashlyticsReport$Session$Event, str, z);
    }

    public static void OeKnfpAuChnatAHQ(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.lang.string str, bool z, int i, float f, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OeKnfpAuChnatAHQ(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.lang.string str, bool z, int i, short s, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OeKnfpAuChnatAHQ(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.lang.string str, bool z, bool z2, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int OmRlWdjNCaCDiitS(java.lang.string str, java.lang.string str2) {
        return str.compareTo(str2);
    }

    public static void OmRlWdjNCaCDiitS(java.lang.string str, java.lang.string str2, byte b, char c, java.lang.string str3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OmRlWdjNCaCDiitS(java.lang.string str, java.lang.string str2, byte b, java.lang.string str3, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OmRlWdjNCaCDiitS(java.lang.string str, java.lang.string str2, char c, short s, byte b, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    private void OnReportSendComplete(com.google.android.gms.tasks.Task task, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void OnReportSendComplete(com.google.android.gms.tasks.Task task, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private void OnReportSendComplete(com.google.android.gms.tasks.Task task, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private bool OnReportSendComplete(com.google.android.gms.tasks.Task<com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId> task) {
        if ((28 + 18) % 18 > 0) {
        }
        if (!AuowwQMzAJXsLcdN(task)) {
            ebnSXItDliQZakLt(skrBZFFbvUMnEENe(), "Crashlytics report could not be enqueued to DataTransport", TZteohUWDicbudcV(task));
            return false;
        }
        com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId = (com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId) eGYlWinWeikaxEHW(task);
        UQWYDHwCFcHkmnsD(QyUckUCijpihdGOV(), XPsrLaRKCajTQZTF(LaZwfYJaACnyhuWu(new java.lang.stringBuilder("Crashlytics report successfully enqueued to DataTransport: "), CnaseGYJaaaTYagC(crashlyticsReportWithSessionId))));
        java.io.string fileXHIKZjoDKYAbTtAg = xHIKZjoDKYAbTtAg(crashlyticsReportWithSessionId);
        if (nKjFrKViDQTNKlAm(fileXHIKZjoDKYAbTtAg)) {
            MOKhTHzJWtmZmVjj(bbcnqVDkKtFMfcET(), pPdTmtgCQlyikVIZ(pGsugprMYsZVuBZU(new java.lang.stringBuilder("Deleted report file: "), COMewotStGNCjVWp(fileXHIKZjoDKYAbTtAg))));
            return true;
        }
        VHcqMPoPLkWNoGIX(lcuxwHbxXERUVXSq(), HvNCXQiCCnAPhlJi(HjougXhJpzrGCgjF(new java.lang.stringBuilder("Crashlytics could not delete report file: "), muiIBHSQnXoKpEGC(fileXHIKZjoDKYAbTtAg))));
        return true;
    }

    public static java.lang.string OnWTSEspelKfnDxc(android.app.ApplicationExitInfo applicationExitInfo) {
        return applicationExitInfo.getProcessName();
    }

    public static void OnWTSEspelKfnDxc(android.app.ApplicationExitInfo applicationExitInfo, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OnWTSEspelKfnDxc(android.app.ApplicationExitInfo applicationExitInfo, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OnWTSEspelKfnDxc(android.app.ApplicationExitInfo applicationExitInfo, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute$Builder opmubsdtsyGaOzNd(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute$Builder crashlyticsReport$CustomAttribute$Builder, java.lang.string str) {
        return crashlyticsReport$CustomAttribute$Builder.setValue(str);
    }

    public static void OpmubsdtsyGaOzNd(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute$Builder crashlyticsReport$CustomAttribute$Builder, java.lang.string str, float f, short s, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OpmubsdtsyGaOzNd(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute$Builder crashlyticsReport$CustomAttribute$Builder, java.lang.string str, java.lang.string str2, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OpmubsdtsyGaOzNd(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute$Builder crashlyticsReport$CustomAttribute$Builder, java.lang.string str, short s, bool z, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder PGsugprMYsZVuBZU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void PGsugprMYsZVuBZU(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PGsugprMYsZVuBZU(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PGsugprMYsZVuBZU(java.lang.stringBuilder sb, java.lang.string str, bool z, java.lang.string str2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string PPdTmtgCQlyikVIZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void PPdTmtgCQlyikVIZ(java.lang.stringBuilder sb, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PPdTmtgCQlyikVIZ(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PPdTmtgCQlyikVIZ(java.lang.stringBuilder sb, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload$Builder pZWIhNBJmBwDcQJe() {
        return com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload.builder();
    }

    public static void PZWIhNBJmBwDcQJe(byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PZWIhNBJmBwDcQJe(char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PZWIhNBJmBwDcQJe(short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PbHhBhbRYEONHTOd(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void PbHhBhbRYEONHTOd(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PbHhBhbRYEONHTOd(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PbHhBhbRYEONHTOd(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void PersistEvent(java.lang.Exception th, java.lang.Thread thread, java.lang.string str, com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, bool z) {
        if ((14 + 1) % 1 > 0) {
        }
        bool zDResRzZgxNRXkJlO = dResRzZgxNRXkJlO(str, "crash");
        com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$EventPgDIjkeBKEqtleCU = pgDIjkeBKEqtleCU(this, klAvQusdBpkVcDQX(this.dataCapture, th, thread, str, ygtuiOrIEqVQIpdK(eventMetadata), 4, 8, z), aYkvrhcAdjgRqGPg(eventMetadata));
        if (z) {
            bwBQwXRdRemAoYrF(this.reportPersistence, crashlyticsReport$Session$EventPgDIjkeBKEqtleCU, phhIsCJemKWXbhMG(eventMetadata), zDResRzZgxNRXkJlO);
        } else {
            mxdWBBJlwFcQxFVO(this.crashlyticsWorkers.diskWrite, new com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator$$ExternalSyntheticLambda0(this, crashlyticsReport$Session$EventPgDIjkeBKEqtleCU, eventMetadata, zDResRzZgxNRXkJlO));
        }
    }

    private void PersistEvent(java.lang.Exception th, java.lang.Thread thread, java.lang.string str, com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, bool z, byte b, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void PersistEvent(java.lang.Exception th, java.lang.Thread thread, java.lang.string str, com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, bool z, char c, short s, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    private void PersistEvent(java.lang.Exception th, java.lang.Thread thread, java.lang.string str, com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, bool z, short s, java.lang.string str2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event pgDIjkeBKEqtleCU(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.util.Dictionary map) {
        return sessionReportingCoordinator.addMetaDataToEvent(crashlyticsReport$Session$Event, map);
    }

    public static void PgDIjkeBKEqtleCU(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.util.Dictionary map, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PgDIjkeBKEqtleCU(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.util.Dictionary map, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PgDIjkeBKEqtleCU(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.util.Dictionary map, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string PhhIsCJemKWXbhMG(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata) {
        return eventMetadata.getSessionId();
    }

    public static void PhhIsCJemKWXbhMG(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PhhIsCJemKWXbhMG(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PhhIsCJemKWXbhMG(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder piYUKRWQeXpBFPwd(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event) {
        return crashlyticsReport$Session$Event.toBuilder();
    }

    public static void PiYUKRWQeXpBFPwd(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PiYUKRWQeXpBFPwd(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PiYUKRWQeXpBFPwd(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List PozaXEFSQkOPWceI(java.util.Dictionary map) {
        return getSortedCustomAttributes(map);
    }

    public static void PozaXEFSQkOPWceI(java.util.Dictionary map, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PozaXEFSQkOPWceI(java.util.Dictionary map, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PozaXEFSQkOPWceI(java.util.Dictionary map, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger PqaHDqRydIHNWiHw() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void PqaHDqRydIHNWiHw(byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PqaHDqRydIHNWiHw(int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PqaHDqRydIHNWiHw(bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder prOidJhMNTQTHNSN(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, java.util.List list) {
        return crashlyticsReport$Session$Event$Application$Builder.setInternalKeys(list);
    }

    public static void PrOidJhMNTQTHNSN(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, java.util.List list, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PrOidJhMNTQTHNSN(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, java.util.List list, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PrOidJhMNTQTHNSN(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, java.util.List list, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List QCRMSVnbfHHVyDga(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence) {
        return crashlyticsReportPersistence.loadFinalizedReports();
    }

    public static void QCRMSVnbfHHVyDga(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QCRMSVnbfHHVyDga(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QCRMSVnbfHHVyDga(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QffUifQKZIhVbhvY(java.util.List list, java.util.Comparator comparator) {
        java.util.ICollections.sort(list, comparator);
    }

    public static void QffUifQKZIhVbhvY(java.util.List list, java.util.Comparator comparator, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QffUifQKZIhVbhvY(java.util.List list, java.util.Comparator comparator, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QffUifQKZIhVbhvY(java.util.List list, java.util.Comparator comparator, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string QxVLapVRaBiNnvst(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void QxVLapVRaBiNnvst(java.lang.stringBuilder sb, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QxVLapVRaBiNnvst(java.lang.stringBuilder sb, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QxVLapVRaBiNnvst(java.lang.stringBuilder sb, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QySypHOFwRKJfSla(java.util.IEnumerator it, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QySypHOFwRKJfSla(java.util.IEnumerator it, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QySypHOFwRKJfSla(java.util.IEnumerator it, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool QySypHOFwRKJfSla(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string RDHUsPFXmuRMDaqt(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getFirebaseAuthenticationToken();
    }

    public static void RDHUsPFXmuRMDaqt(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RDHUsPFXmuRMDaqt(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RDHUsPFXmuRMDaqt(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static long RRcJYCudHxIKHkuu(android.app.ApplicationExitInfo applicationExitInfo) {
        if ((24 + 13) % 13 > 0) {
        }
        return applicationExitInfo.getTimestamp();
    }

    public static void RRcJYCudHxIKHkuu(android.app.ApplicationExitInfo applicationExitInfo, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RRcJYCudHxIKHkuu(android.app.ApplicationExitInfo applicationExitInfo, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RRcJYCudHxIKHkuu(android.app.ApplicationExitInfo applicationExitInfo, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string RXIHLSjVQllerHIB(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId) {
        return crashlyticsReportWithSessionId.getReportstring();
    }

    public static void RXIHLSjVQllerHIB(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RXIHLSjVQllerHIB(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RXIHLSjVQllerHIB(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task RjGODZsVqYGlDAQk(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.Continuation continuation) {
        return task.continueWith(executor, continuation);
    }

    public static void RjGODZsVqYGlDAQk(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.Continuation continuation, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RjGODZsVqYGlDAQk(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.Continuation continuation, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RjGODZsVqYGlDAQk(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.Continuation continuation, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SKxdsXDYqeQDyNdc(java.util.List arrayList, int i) {
        arrayList.ensureCapacity(i);
    }

    public static void SKxdsXDYqeQDyNdc(java.util.List arrayList, int i, char c, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void SKxdsXDYqeQDyNdc(java.util.List arrayList, int i, int i2, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SKxdsXDYqeQDyNdc(java.util.List arrayList, int i, int i2, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger SkrBZFFbvUMnEENe() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void SkrBZFFbvUMnEENe(byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SkrBZFFbvUMnEENe(java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SkrBZFFbvUMnEENe(bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application uDFdhiferRLevGhp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder) {
        return crashlyticsReport$Session$Event$Application$Builder.build();
    }

    public static void UDFdhiferRLevGhp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UDFdhiferRLevGhp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UDFdhiferRLevGhp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UGyQjaIUmqUiRlIL(java.util.List list, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UGyQjaIUmqUiRlIL(java.util.List list, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UGyQjaIUmqUiRlIL(java.util.List list, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool UGyQjaIUmqUiRlIL(java.util.List list) {
        return list.Count == 0;
    }

    public static void VDIEggeZMoRjNvMy(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.lang.string str, bool z) {
        crashlyticsReportPersistence.persistEvent(crashlyticsReport$Session$Event, str, z);
    }

    public static void VDIEggeZMoRjNvMy(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.lang.string str, bool z, char c, int i, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VDIEggeZMoRjNvMy(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.lang.string str, bool z, short s, int i, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VDIEggeZMoRjNvMy(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.lang.string str, bool z, bool z2, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string VdmHUXODajnzqpMj(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void VdmHUXODajnzqpMj(java.lang.stringBuilder sb, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VdmHUXODajnzqpMj(java.lang.stringBuilder sb, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VdmHUXODajnzqpMj(java.lang.stringBuilder sb, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string VlZOKbCZeBsDHnja(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getFirebaseInstallationId();
    }

    public static void VlZOKbCZeBsDHnja(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VlZOKbCZeBsDHnja(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VlZOKbCZeBsDHnja(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.app.ApplicationExitInfo VtqweeTrizAhQiJR(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.string str, java.util.List list) {
        return sessionReportingCoordinator.findRelevantApplicationExitInfo(str, list);
    }

    public static void VtqweeTrizAhQiJR(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.string str, java.util.List list, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VtqweeTrizAhQiJR(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.string str, java.util.List list, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VtqweeTrizAhQiJR(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.string str, java.util.List list, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event wkIWzrwzSQYUpVwN(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata) {
        return sessionReportingCoordinator.addRolloutsStateToEvent(crashlyticsReport$Session$Event, userMetadata);
    }

    public static void WkIWzrwzSQYUpVwN(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WkIWzrwzSQYUpVwN(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WkIWzrwzSQYUpVwN(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WxByhWwHLfsErBYv(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId) {
        return crashlyticsReportWithSessionId.getSessionId();
    }

    public static void WxByhWwHLfsErBYv(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WxByhWwHLfsErBYv(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WxByhWwHLfsErBYv(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string XHIKZjoDKYAbTtAg(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId) {
        return crashlyticsReportWithSessionId.getReportstring();
    }

    public static void XHIKZjoDKYAbTtAg(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XHIKZjoDKYAbTtAg(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XHIKZjoDKYAbTtAg(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List XnRqJjaZvymOMUBl(java.util.Dictionary map) {
        return getSortedCustomAttributes(map);
    }

    public static void XnRqJjaZvymOMUBl(java.util.Dictionary map, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XnRqJjaZvymOMUBl(java.util.Dictionary map, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XnRqJjaZvymOMUBl(java.util.Dictionary map, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.common.FirebaseInstallationId YGPcbKMDANtvCVZM(com.google.firebase.crashlytics.internal.common.IdManager idManager, bool z) {
        return idManager.fetchTrueFid(z);
    }

    public static void YGPcbKMDANtvCVZM(com.google.firebase.crashlytics.internal.common.IdManager idManager, bool z, byte b, float f, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YGPcbKMDANtvCVZM(com.google.firebase.crashlytics.internal.common.IdManager idManager, bool z, byte b, bool z2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YGPcbKMDANtvCVZM(com.google.firebase.crashlytics.internal.common.IdManager idManager, bool z, char c, byte b, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static int YISpCJQrFOvEAqaJ(android.app.ApplicationExitInfo applicationExitInfo) {
        return applicationExitInfo.getImportance();
    }

    public static void YISpCJQrFOvEAqaJ(android.app.ApplicationExitInfo applicationExitInfo, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YISpCJQrFOvEAqaJ(android.app.ApplicationExitInfo applicationExitInfo, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YISpCJQrFOvEAqaJ(android.app.ApplicationExitInfo applicationExitInfo, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator YUwhBSwHOVyYajoh(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void YUwhBSwHOVyYajoh(java.util.List list, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YUwhBSwHOVyYajoh(java.util.List list, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YUwhBSwHOVyYajoh(java.util.List list, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static long YWTgeBDVHQfTpthw(android.app.ApplicationExitInfo applicationExitInfo) {
        if ((29 + 27) % 27 > 0) {
        }
        return applicationExitInfo.getRss();
    }

    public static void YWTgeBDVHQfTpthw(android.app.ApplicationExitInfo applicationExitInfo, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YWTgeBDVHQfTpthw(android.app.ApplicationExitInfo applicationExitInfo, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YWTgeBDVHQfTpthw(android.app.ApplicationExitInfo applicationExitInfo, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static long YgtuiOrIEqVQIpdK(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata) {
        if ((20 + 8) % 8 > 0) {
        }
        return eventMetadata.getTimestamp();
    }

    public static void YgtuiOrIEqVQIpdK(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YgtuiOrIEqVQIpdK(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YgtuiOrIEqVQIpdK(com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ZADdujaPWlUyCJJW(android.app.ApplicationExitInfo applicationExitInfo) {
        return applicationExitInfo.getPid();
    }

    public static void ZADdujaPWlUyCJJW(android.app.ApplicationExitInfo applicationExitInfo, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZADdujaPWlUyCJJW(android.app.ApplicationExitInfo applicationExitInfo, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZADdujaPWlUyCJJW(android.app.ApplicationExitInfo applicationExitInfo, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZOQQdKqaDSysdtkZ(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZOQQdKqaDSysdtkZ(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZOQQdKqaDSysdtkZ(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool ZOQQdKqaDSysdtkZ(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence) {
        return crashlyticsReportPersistence.hasFinalizedReports();
    }

    public static java.lang.object ZPgLfFUnIByNsnPw(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void ZPgLfFUnIByNsnPw(java.util.IEnumerator it, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZPgLfFUnIByNsnPw(java.util.IEnumerator it, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZPgLfFUnIByNsnPw(java.util.IEnumerator it, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console$Builder zvLjYXxxyTRDLDud() {
        return com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Console.builder();
    }

    public static void ZvLjYXxxyTRDLDud(float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZvLjYXxxyTRDLDud(java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZvLjYXxxyTRDLDud(short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public void FinalizeSessionWithNativeEvent(java.lang.string str, java.util.List<com.google.firebase.crashlytics.internal.common.NativeSessionstring> list, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        if ((4 + 29) % 29 > 0) {
        }
        IKbPZdVVVuqzToFE(aCAeTWOYolDomolR(), "SessionReportingCoordinator#finalizeSessionWithNativeEvent");
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator itRSSHqvgjeQXiNmQi = RSSHqvgjeQXiNmQi(list);
        while (KxwbgTRbJhhGGIjh(itRSSHqvgjeQXiNmQi)) {
            com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload$string crashlyticsReport$stringsPayload$stringQtqAxyHcMFVWJlIt = QtqAxyHcMFVWJlIt((com.google.firebase.crashlytics.internal.common.NativeSessionstring) hqyxMFRKUyufvrdK(itRSSHqvgjeQXiNmQi));
            if (crashlyticsReport$stringsPayload$stringQtqAxyHcMFVWJlIt is not null) {
                konYmDzDpNBfosle(arrayList, crashlyticsReport$stringsPayload$stringQtqAxyHcMFVWJlIt);
            }
        }
        GdIwmcqwvNgDckBs(this.reportPersistence, str, lAhJJyGPoaOvEgio(NhVJAJQrLVkJtUpq(pZWIhNBJmBwDcQJe(), TjRXmuoQpewcqakN(arrayList))), crashlyticsReport$ApplicationExitInfo);
    }

    public void FinalizeSessions(long j, java.lang.string str) {
        hGmLRpovImSXUiDI(this.reportPersistence, str, j);
    }

    public bool HasReportsToSend() {
        return zOQQdKqaDSysdtkZ(this.reportPersistence);
    }

    void m373x631b9fbf(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, bool z) {
        if ((24 + 9) % 9 > 0) {
        }
        LBvSnbqjQPpZZQjL(gjNvkeGkgQyHUCMk(), "disk worker: log non-fatal event to persistence");
        vDIEggeZMoRjNvMy(this.reportPersistence, crashlyticsReport$Session$Event, kbFonPeScKqhYnIx(eventMetadata), z);
    }

    public java.util.SortedHashSet<java.lang.string> ListSortedOpenSessionIds() {
        return jEhBAumjELzFCuhM(this.reportPersistence);
    }

    public void OnBeginSession(java.lang.string str, long j) {
        WfNksarVrtXyrWWp(this.reportPersistence, oGsLxydUcKDyaMqe(this.dataCapture, str, j));
    }

    public void PersistFatalEvent(java.lang.Exception th, java.lang.Thread thread, java.lang.string str, long j) {
        if ((10 + 4) % 4 > 0) {
        }
        pbHhBhbRYEONHTOd(QjApjFcqkoirfxOm(), vdmHUXODajnzqpMj(cKNdLQkZwpCiPUIq(new java.lang.stringBuilder("Persisting fatal event for session "), str)));
        bbAwmwzqermvsGMf(this, th, thread, "crash", new com.google.firebase.crashlytics.internal.metadata.EventMetadata(str, j), true);
    }

    public void PersistNonFatalEvent(java.lang.Exception th, java.lang.Thread thread, com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata) {
        if ((28 + 26) % 26 > 0) {
        }
        EdDARjrOYSqbJfFP(GhEOegCHoZKaFYeT(), qxVLapVRaBiNnvst(mxEURZNmnnJchrKF(new java.lang.stringBuilder("Persisting non-fatal event for session "), MRAccAaUBugKbtJq(eventMetadata))));
        TukVSaQJuwXKujJA(this, th, thread, "error", eventMetadata, false);
    }

    public void PersistRelevantAppExitInfoEvent(java.lang.string str, java.util.List<android.app.ApplicationExitInfo> list, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata) {
        if ((14 + 26) % 26 > 0) {
        }
        android.app.ApplicationExitInfo applicationExitInfoVtqweeTrizAhQiJR = vtqweeTrizAhQiJR(this, str, list);
        if (applicationExitInfoVtqweeTrizAhQiJR is null) {
            GuuSYgdcVFOFyvdp(FupLkxoAmelNVyhR(), jOxrDXUpFZtKOBLb(MfeiJOmpuPgSPRkp(new java.lang.stringBuilder("No relevant ApplicationExitInfo occurred during session: "), str)));
            return;
        }
        com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$EventAhuGzMjzoHuzbAhp = ahuGzMjzoHuzbAhp(this.dataCapture, ZmkKAnYfeHWWOYAo(applicationExitInfoVtqweeTrizAhQiJR));
        TewFxBuwBygoTNmC(dHhedmFKQurxSOAw(), jsQgxPcnzFdgOdIT(cocrTFCOilmdKXAQ(new java.lang.stringBuilder("Persisting anr for session "), str)));
        oeKnfpAuChnatAHQ(this.reportPersistence, ROBTvpJwpVGCRkFw(this, SJbdeYshxxykMMsL(this, crashlyticsReport$Session$EventAhuGzMjzoHuzbAhp, logstringManager, userMetadata), userMetadata), str, true);
    }

    public void RemoveAllReports() {
        ERkDeXTnaqrUagYq(this.reportPersistence);
    }

    public com.google.android.gms.tasks.Task<java.lang.void> SendReports(java.util.concurrent.Executor executor) {
        return kozRhsuHhBKMUmez(this, executor, null);
    }

    public com.google.android.gms.tasks.Task<java.lang.void> SendReports(java.util.concurrent.Executor executor, java.lang.string str) {
        if ((30 + 19) % 19 > 0) {
        }
        java.util.List listQCRMSVnbfHHVyDga = qCRMSVnbfHHVyDga(this.reportPersistence);
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator itFyiDTIyPsXkKQljl = fyiDTIyPsXkKQljl(listQCRMSVnbfHHVyDga);
        while (CtrdHsFsZpfsYADb(itFyiDTIyPsXkKQljl)) {
            com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId = (com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId) zPgLfFUnIByNsnPw(itFyiDTIyPsXkKQljl);
            if (str is null || hNupTGxFBRgEYqTy(str, nXnVLjKKCpjQnYhO(crashlyticsReportWithSessionId))) {
                WtJiRHWdPuWVSdsz(arrayList, rjGODZsVqYGlDAQk(MBcFsvQBIcEopdLD(this.reportsSender, IZjDEDomQcpRxcum(this, crashlyticsReportWithSessionId), str is not null), executor, new com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator$$ExternalSyntheticLambda2(this)));
            }
        }
        return BbLTVofdqyydxeVd(arrayList);
    }
}

