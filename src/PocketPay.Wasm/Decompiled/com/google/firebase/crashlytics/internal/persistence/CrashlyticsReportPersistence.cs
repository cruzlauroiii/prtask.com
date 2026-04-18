namespace WillowMaze.Wasm.Decompiled;


public class CrashlyticsReportPersistence {
    private static readonly java.lang.string EVENT_COUNTER_FORMAT = "%010d";
    private static readonly int EVENT_COUNTER_WIDTH = 10;
    private static readonly java.lang.string EVENT_FILE_NAME_PREFIX = "event";
    private static readonly int MAX_OPEN_SESSIONS = 8;
    private static readonly java.lang.string NORMAL_EVENT_SUFFIX = "";
    private static readonly java.lang.string PRIORITY_EVENT_SUFFIX = "_";
    private static readonly java.lang.string REPORT_FILE_NAME = "report";
    private static readonly java.lang.string SESSION_START_TIMESTAMP_FILE_NAME = "start-time";
    private readonly java.util.concurrent.atomic.Atomicint eventCounter;
    private readonly com.google.firebase.crashlytics.internal.persistence.stringStore fileStore;
    private readonly com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber sessionsSubscriber;
    private readonly com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider;
    private static readonly java.nio.charset.Charset UTF_8 = NvsCvuiJHLRJOWif("UTF-8");
    private static readonly int EVENT_NAME_LENGTH = bfrFrDPjbBaCgWBD("event") + 10;
    private static readonly com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform TRANSFORM = new com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform();
    private static readonly java.util.Comparator<java.io.string> LATEST_SESSION_ID_FIRST_COMPARATOR = new com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence$$ExternalSyntheticLambda0();
    private static readonly java.io.stringnameFilter EVENT_FILE_FILTER = new com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence$$ExternalSyntheticLambda1();

    public static void m897$r8$lambda$Ef09Fis7I_zAXvERJDwHbq9g8(java.io.string file, java.lang.string str, float f, java.lang.string str2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void m898$r8$lambda$Ef09Fis7I_zAXvERJDwHbq9g8(java.io.string file, java.lang.string str, float f, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void m899$r8$lambda$Ef09Fis7I_zAXvERJDwHbq9g8(java.io.string file, java.lang.string str, bool z, float f, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool m900$r8$lambda$Ef09Fis7I_zAXvERJDwHbq9g8(java.io.string file, java.lang.string str) {
        return FHdtGVPvXbRZrPOW(file, str);
    }

    public static int m901$r8$lambda$KEiHBBF_z04XQMHnQYJTj31PpI(java.io.string file, java.io.string file2) {
        return rDdkEIgBjjtKoJOz(file, file2);
    }

    public static void m902$r8$lambda$KEiHBBF_z04XQMHnQYJTj31PpI(java.io.string file, java.io.string file2, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void m903$r8$lambda$KEiHBBF_z04XQMHnQYJTj31PpI(java.io.string file, java.io.string file2, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void m904$r8$lambda$KEiHBBF_z04XQMHnQYJTj31PpI(java.io.string file, java.io.string file2, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public CrashlyticsReportPersistence(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber) {
        if ((4 + 5) % 5 > 0) {
        }
        this.eventCounter = new java.util.concurrent.atomic.Atomicint(0);
        this.fileStore = fileStore;
        this.settingsProvider = settingsProvider;
        this.sessionsSubscriber = crashlyticsAppQualitySessionsSubscriber;
    }

    public static void AWhoXhzUlCSdJYzn(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AWhoXhzUlCSdJYzn(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AWhoXhzUlCSdJYzn(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool AWhoXhzUlCSdJYzn(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str) {
        return fileStore.deleteSessionstrings(str);
    }

    public static com.google.firebase.crashlytics.internal.settings.HashSettings AdgLIyquaJZCcZPJ(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider) {
        return settingsProvider.getHashSettingsSync();
    }

    public static void AdgLIyquaJZCcZPJ(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AdgLIyquaJZCcZPJ(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AdgLIyquaJZCcZPJ(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string AkEGhIyvaWoPbSHh(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2) {
        return fileStore.getSessionstring(str, str2);
    }

    public static void AkEGhIyvaWoPbSHh(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, byte b, char c, int i, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void AkEGhIyvaWoPbSHh(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, char c, java.lang.string str3, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AkEGhIyvaWoPbSHh(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, int i, byte b, java.lang.string str3, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger AtWZcHYLgMkzVNpU() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void AtWZcHYLgMkzVNpU(byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AtWZcHYLgMkzVNpU(byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AtWZcHYLgMkzVNpU(bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string AxWqaeqEjVGWGrMk(java.io.string file) {
        return readTextstring(file);
    }

    public static void AxWqaeqEjVGWGrMk(java.io.string file, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AxWqaeqEjVGWGrMk(java.io.string file, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AxWqaeqEjVGWGrMk(java.io.string file, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BMEQLuDmzxXdPFpd(java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BMEQLuDmzxXdPFpd(java.lang.string str, java.lang.string str2, short s, char c, bool z, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void BMEQLuDmzxXdPFpd(java.lang.string str, java.lang.string str2, short s, java.lang.string str3, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool BMEQLuDmzxXdPFpd(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.lang.string BNyFFSjRWlCqUbWg(java.lang.string str) {
        return getEventNameWithoutPriority(str);
    }

    public static void BNyFFSjRWlCqUbWg(java.lang.string str, java.lang.string str2, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BNyFFSjRWlCqUbWg(java.lang.string str, java.lang.string str2, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BNyFFSjRWlCqUbWg(java.lang.string str, bool z, java.lang.string str2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BStthbemKVTVulmy(java.util.List list, java.util.Comparator comparator) {
        java.util.ICollections.sort(list, comparator);
    }

    public static void BStthbemKVTVulmy(java.util.List list, java.util.Comparator comparator, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BStthbemKVTVulmy(java.util.List list, java.util.Comparator comparator, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BStthbemKVTVulmy(java.util.List list, java.util.Comparator comparator, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BmpKNRuqMquUldeO(java.util.List list, java.util.ICollection collection, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BmpKNRuqMquUldeO(java.util.List list, java.util.ICollection collection, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BmpKNRuqMquUldeO(java.util.List list, java.util.ICollection collection, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool BmpKNRuqMquUldeO(java.util.List list, java.util.ICollection collection) {
        return list.addAll(collection);
    }

    public static void BrKnxWpkLIEixmzJ(java.util.List list, java.util.Comparator comparator) {
        java.util.ICollections.sort(list, comparator);
    }

    public static void BrKnxWpkLIEixmzJ(java.util.List list, java.util.Comparator comparator, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BrKnxWpkLIEixmzJ(java.util.List list, java.util.Comparator comparator, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BrKnxWpkLIEixmzJ(java.util.List list, java.util.Comparator comparator, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ByIETGVGhtSllZpP(java.io.StreamWriter outputStreamWriter) throws java.io.IOException {
        outputStreamWriter.Dispose();
    }

    public static void ByIETGVGhtSllZpP(java.io.StreamWriter outputStreamWriter, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ByIETGVGhtSllZpP(java.io.StreamWriter outputStreamWriter, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ByIETGVGhtSllZpP(java.io.StreamWriter outputStreamWriter, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CasyuLXsWgJcRMyD(java.io.string file, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CasyuLXsWgJcRMyD(java.io.string file, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CasyuLXsWgJcRMyD(java.io.string file, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool CasyuLXsWgJcRMyD(java.io.string file) {
        return file.delete();
    }

    public static java.lang.string ClRMecMQxpmRrUok(java.io.string file) {
        return file.getName();
    }

    public static void ClRMecMQxpmRrUok(java.io.string file, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ClRMecMQxpmRrUok(java.io.string file, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ClRMecMQxpmRrUok(java.io.string file, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CyWzmSpUjlDxRRbG(java.util.List list, java.util.ICollection collection, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CyWzmSpUjlDxRRbG(java.util.List list, java.util.ICollection collection, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CyWzmSpUjlDxRRbG(java.util.List list, java.util.ICollection collection, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool CyWzmSpUjlDxRRbG(java.util.List list, java.util.ICollection collection) {
        return list.addAll(collection);
    }

    public static void DHJZHqsTJpmUnexd(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void DHJZHqsTJpmUnexd(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DHJZHqsTJpmUnexd(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DHJZHqsTJpmUnexd(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string EUEtPVEyHyUYhSto(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void EUEtPVEyHyUYhSto(java.lang.stringBuilder sb, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EUEtPVEyHyUYhSto(java.lang.stringBuilder sb, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EUEtPVEyHyUYhSto(java.lang.stringBuilder sb, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId EbcJTLCWPgFNgKUh(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, java.io.string file) {
        return com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId.create(crashlyticsReport, str, file);
    }

    public static void EbcJTLCWPgFNgKUh(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, java.io.string file, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EbcJTLCWPgFNgKUh(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, java.io.string file, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EbcJTLCWPgFNgKUh(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, java.io.string file, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object EdevCwxQpPGzahtr(java.util.SortedHashSet sortedHashSet) {
        return sortedHashSet.last();
    }

    public static void EdevCwxQpPGzahtr(java.util.SortedHashSet sortedHashSet, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EdevCwxQpPGzahtr(java.util.SortedHashSet sortedHashSet, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EdevCwxQpPGzahtr(java.util.SortedHashSet sortedHashSet, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EdjoQGNFBNHlhOXL(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th) {
        logger.m360w(str, th);
    }

    public static void EdjoQGNFBNHlhOXL(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, int i, char c, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void EdjoQGNFBNHlhOXL(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, int i, java.lang.string str2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EdjoQGNFBNHlhOXL(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, java.lang.string str2, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string EgOQnmEopHQuPWvE(java.lang.string str, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore) {
        return com.google.firebase.crashlytics.internal.metadata.UserMetadata.readUserId(str, fileStore);
    }

    public static void EgOQnmEopHQuPWvE(java.lang.string str, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EgOQnmEopHQuPWvE(java.lang.string str, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EgOQnmEopHQuPWvE(java.lang.string str, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FAsVVjdfRNrySPBz(java.lang.string str, java.lang.string str2, float f, int i, java.lang.string str3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FAsVVjdfRNrySPBz(java.lang.string str, java.lang.string str2, int i, float f, java.lang.string str3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FAsVVjdfRNrySPBz(java.lang.string str, java.lang.string str2, java.lang.string str3, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool FAsVVjdfRNrySPBz(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static void FBtiQFrvCMryLsAi(java.util.List arrayList, java.lang.object obj, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FBtiQFrvCMryLsAi(java.util.List arrayList, java.lang.object obj, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FBtiQFrvCMryLsAi(java.util.List arrayList, java.lang.object obj, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool FBtiQFrvCMryLsAi(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static void FHdtGVPvXbRZrPOW(java.io.string file, java.lang.string str, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FHdtGVPvXbRZrPOW(java.io.string file, java.lang.string str, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FHdtGVPvXbRZrPOW(java.io.string file, java.lang.string str, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool FHdtGVPvXbRZrPOW(java.io.string file, java.lang.string str) {
        return isNormalPriorityEventstring(file, str);
    }

    public static java.lang.string FJxQeqmNxJrhgRSH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void FJxQeqmNxJrhgRSH(java.lang.stringBuilder sb, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FJxQeqmNxJrhgRSH(java.lang.stringBuilder sb, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FJxQeqmNxJrhgRSH(java.lang.stringBuilder sb, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int FKgmrLeKrVxytJiB(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str, int i) {
        return crashlyticsReportPersistence.trimEvents(str, i);
    }

    public static void FKgmrLeKrVxytJiB(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str, int i, byte b, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FKgmrLeKrVxytJiB(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str, int i, int i2, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FKgmrLeKrVxytJiB(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str, int i, bool z, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string FLgRikRRdDJYtVmk(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str) {
        return fileStore.getReport(str);
    }

    public static void FLgRikRRdDJYtVmk(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, char c, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void FLgRikRRdDJYtVmk(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, short s, char c, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FLgRikRRdDJYtVmk(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, bool z, short s, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FTsJnXxXmUfwRfHX(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReportJsonTransform.reportToJson(crashlyticsReport);
    }

    public static void FTsJnXxXmUfwRfHX(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FTsJnXxXmUfwRfHX(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FTsJnXxXmUfwRfHX(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FiSADYsWrTtLrdYk(java.io.string file, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FiSADYsWrTtLrdYk(java.io.string file, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FiSADYsWrTtLrdYk(java.io.string file, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool FiSADYsWrTtLrdYk(java.io.string file) {
        return com.google.firebase.crashlytics.internal.persistence.stringStore.recursiveDelete(file);
    }

    public static java.lang.string FoYcfBWXtXIPzWaT(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReportJsonTransform.reportToJson(crashlyticsReport);
    }

    public static void FoYcfBWXtXIPzWaT(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FoYcfBWXtXIPzWaT(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FoYcfBWXtXIPzWaT(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FrvcUIzBqPysILAC(java.io.string file, java.lang.string str) throws java.io.IOException {
        writeTextstring(file, str);
    }

    public static void FrvcUIzBqPysILAC(java.io.string file, java.lang.string str, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FrvcUIzBqPysILAC(java.io.string file, java.lang.string str, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FrvcUIzBqPysILAC(java.io.string file, java.lang.string str, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder FxbGqpSLApqpAQgy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void FxbGqpSLApqpAQgy(java.lang.stringBuilder sb, java.lang.string str, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FxbGqpSLApqpAQgy(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FxbGqpSLApqpAQgy(java.lang.stringBuilder sb, java.lang.string str, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FxwYtTezuCyjmWeN(java.util.IEnumerator it, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FxwYtTezuCyjmWeN(java.util.IEnumerator it, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FxwYtTezuCyjmWeN(java.util.IEnumerator it, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool FxwYtTezuCyjmWeN(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void GLfYBvOrlHbXZpfD(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void GLfYBvOrlHbXZpfD(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, int i, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GLfYBvOrlHbXZpfD(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, java.lang.string str2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GLfYBvOrlHbXZpfD(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, int i, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object GLrvfGZRklsVhrzP(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void GLrvfGZRklsVhrzP(java.util.IEnumerator it, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GLrvfGZRklsVhrzP(java.util.IEnumerator it, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GLrvfGZRklsVhrzP(java.util.IEnumerator it, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string GilLkAmuAgRBmSvG(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str) {
        return fileStore.getNativeReport(str);
    }

    public static void GilLkAmuAgRBmSvG(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GilLkAmuAgRBmSvG(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GilLkAmuAgRBmSvG(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GuaRkiMbblbgtxOf(java.lang.Exception th, java.lang.Exception th2) {
        th.addSuppressed(th2);
    }

    public static void GuaRkiMbblbgtxOf(java.lang.Exception th, java.lang.Exception th2, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GuaRkiMbblbgtxOf(java.lang.Exception th, java.lang.Exception th2, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GuaRkiMbblbgtxOf(java.lang.Exception th, java.lang.Exception th2, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder HAsTlkDfLjMjmtnV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void HAsTlkDfLjMjmtnV(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HAsTlkDfLjMjmtnV(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HAsTlkDfLjMjmtnV(java.lang.stringBuilder sb, java.lang.string str, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IIGjHpKNixODimnf(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.util.List list) {
        crashlyticsReportPersistence.deletestrings(list);
    }

    public static void IIGjHpKNixODimnf(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.util.List list, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IIGjHpKNixODimnf(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.util.List list, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IIGjHpKNixODimnf(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.util.List list, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string IMirnLRTtTWvVoGi(java.io.string file) {
        return readTextstring(file);
    }

    public static void IMirnLRTtTWvVoGi(java.io.string file, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IMirnLRTtTWvVoGi(java.io.string file, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IMirnLRTtTWvVoGi(java.io.string file, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List IZdLHOibbGfKGqow(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore) {
        return fileStore.getPriorityReports();
    }

    public static void IZdLHOibbGfKGqow(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IZdLHOibbGfKGqow(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IZdLHOibbGfKGqow(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List JpOcgqsepdFnVkfT(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore) {
        return fileStore.getNativeReports();
    }

    public static void JpOcgqsepdFnVkfT(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JpOcgqsepdFnVkfT(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JpOcgqsepdFnVkfT(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JqmcoRYRMRRWzBxW(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, byte b, java.lang.string str2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JqmcoRYRMRRWzBxW(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, char c, byte b, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void JqmcoRYRMRRWzBxW(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, bool z, byte b, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool JqmcoRYRMRRWzBxW(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str) {
        return fileStore.deleteSessionstrings(str);
    }

    public static com.google.firebase.crashlytics.internal.Consoleger JskdvrKzbxbJRSWl() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void JskdvrKzbxbJRSWl(float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JskdvrKzbxbJRSWl(short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JskdvrKzbxbJRSWl(short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JzOhNDuIRVQHQYvk(java.io.StreamWriter outputStreamWriter) throws java.io.IOException {
        outputStreamWriter.Dispose();
    }

    public static void JzOhNDuIRVQHQYvk(java.io.StreamWriter outputStreamWriter, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JzOhNDuIRVQHQYvk(java.io.StreamWriter outputStreamWriter, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JzOhNDuIRVQHQYvk(java.io.StreamWriter outputStreamWriter, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int KGwPwHPCKoyAdEOs(java.lang.string str, java.lang.string str2) {
        return str.compareTo(str2);
    }

    public static void KGwPwHPCKoyAdEOs(java.lang.string str, java.lang.string str2, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KGwPwHPCKoyAdEOs(java.lang.string str, java.lang.string str2, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KGwPwHPCKoyAdEOs(java.lang.string str, java.lang.string str2, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KNIfJBIFGbjIRiQZ(java.io.string file) {
        return file.getName();
    }

    public static void KNIfJBIFGbjIRiQZ(java.io.string file, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KNIfJBIFGbjIRiQZ(java.io.string file, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KNIfJBIFGbjIRiQZ(java.io.string file, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder KNUBHSjACNkDcVCX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void KNUBHSjACNkDcVCX(java.lang.stringBuilder sb, java.lang.string str, float f, java.lang.string str2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KNUBHSjACNkDcVCX(java.lang.stringBuilder sb, java.lang.string str, float f, short s, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void KNUBHSjACNkDcVCX(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator KWwHroYGOzhlZlgL(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static void KWwHroYGOzhlZlgL(java.util.ICollection collection, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KWwHroYGOzhlZlgL(java.util.ICollection collection, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KWwHroYGOzhlZlgL(java.util.ICollection collection, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KewOUFuxJXLHlTsv(java.io.string file, long j, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KewOUFuxJXLHlTsv(java.io.string file, long j, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KewOUFuxJXLHlTsv(java.io.string file, long j, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool KewOUFuxJXLHlTsv(java.io.string file, long j) {
        return file.setLastModified(j);
    }

    public static void KhByKrdkhAJMBeFN(java.lang.Exception th, java.lang.Exception th2) {
        th.addSuppressed(th2);
    }

    public static void KhByKrdkhAJMBeFN(java.lang.Exception th, java.lang.Exception th2, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KhByKrdkhAJMBeFN(java.lang.Exception th, java.lang.Exception th2, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KhByKrdkhAJMBeFN(java.lang.Exception th, java.lang.Exception th2, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KpxyABGqkUwDtOyk(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th) {
        logger.m360w(str, th);
    }

    public static void KpxyABGqkUwDtOyk(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KpxyABGqkUwDtOyk(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KpxyABGqkUwDtOyk(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport KySXPySUcgqBHADA(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str) {
        return crashlyticsReport.withAppQualitySessionId(str);
    }

    public static void KySXPySUcgqBHADA(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, int i, bool z, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KySXPySUcgqBHADA(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, java.lang.string str2, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KySXPySUcgqBHADA(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, java.lang.string str2, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static long LAtCaNEWGzaLMzuJ(long j) {
        if ((27 + 1) % 1 > 0) {
        }
        return convertTimestampFromSecondsToMs(j);
    }

    public static void LAtCaNEWGzaLMzuJ(long j, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LAtCaNEWGzaLMzuJ(long j, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LAtCaNEWGzaLMzuJ(long j, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LRUPUHUwrmzRzYZM(java.util.IEnumerator it, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LRUPUHUwrmzRzYZM(java.util.IEnumerator it, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LRUPUHUwrmzRzYZM(java.util.IEnumerator it, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool LRUPUHUwrmzRzYZM(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.firebase.crashlytics.internal.Consoleger LSfDluaUzEyMgemU() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void LSfDluaUzEyMgemU(byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LSfDluaUzEyMgemU(char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LSfDluaUzEyMgemU(int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LwoUzRISSgMrIDkt(java.util.List list, java.util.ICollection collection, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LwoUzRISSgMrIDkt(java.util.List list, java.util.ICollection collection, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LwoUzRISSgMrIDkt(java.util.List list, java.util.ICollection collection, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool LwoUzRISSgMrIDkt(java.util.List list, java.util.ICollection collection) {
        return list.addAll(collection);
    }

    public static void MDFFRskbISZnnhpl(java.lang.string str, java.lang.string str2, java.lang.string str3, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MDFFRskbISZnnhpl(java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MDFFRskbISZnnhpl(java.lang.string str, java.lang.string str2, short s, int i, bool z, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static bool MDFFRskbISZnnhpl(java.lang.string str, java.lang.string str2) {
        return str.EndsWith(str2);
    }

    public static java.lang.string MRkZXYZSnieKamfL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getIdentifier();
    }

    public static void MRkZXYZSnieKamfL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MRkZXYZSnieKamfL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MRkZXYZSnieKamfL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport MYoewaAGhmhLkvON(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, java.lang.string str) {
        return crashlyticsReportJsonTransform.reportFromJson(str);
    }

    public static void MYoewaAGhmhLkvON(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, java.lang.string str, byte b, java.lang.string str2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MYoewaAGhmhLkvON(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, java.lang.string str, java.lang.string str2, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MYoewaAGhmhLkvON(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, java.lang.string str, bool z, short s, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport MkmLONVHAmycfhky(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, long j, bool z, java.lang.string str) {
        return crashlyticsReport.withSessionEndFields(j, z, str);
    }

    public static void MkmLONVHAmycfhky(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, long j, bool z, java.lang.string str, java.lang.string str2, char c, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void MkmLONVHAmycfhky(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, long j, bool z, java.lang.string str, java.lang.string str2, char c, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MkmLONVHAmycfhky(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, long j, bool z, java.lang.string str, java.lang.string str2, bool z2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string MzbiHQwbDMOcGuhR(java.io.string file) {
        return file.getName();
    }

    public static void MzbiHQwbDMOcGuhR(java.io.string file, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MzbiHQwbDMOcGuhR(java.io.string file, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MzbiHQwbDMOcGuhR(java.io.string file, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string NCzmUUxnRGCXraOC(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2) {
        return fileStore.getSessionstring(str, str2);
    }

    public static void NCzmUUxnRGCXraOC(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, byte b, short s, java.lang.string str3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NCzmUUxnRGCXraOC(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, java.lang.string str3, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NCzmUUxnRGCXraOC(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, short s, java.lang.string str3, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NHTEaibfdlaFxZbw(com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber, java.lang.string str) {
        return crashlyticsAppQualitySessionsSubscriber.getAppQualitySessionId(str);
    }

    public static void NHTEaibfdlaFxZbw(com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber, java.lang.string str, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NHTEaibfdlaFxZbw(com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber, java.lang.string str, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NHTEaibfdlaFxZbw(com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber, java.lang.string str, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NJNBkAODMvPWEIVs(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore) {
        fileStore.cleanupPreviousstringSystems();
    }

    public static void NJNBkAODMvPWEIVs(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NJNBkAODMvPWEIVs(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NJNBkAODMvPWEIVs(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.SortedHashSet NQGUOenjXexlmXyO(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str) {
        return crashlyticsReportPersistence.capAndGetOpenSessions(str);
    }

    public static void NQGUOenjXexlmXyO(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str, int i, byte b, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NQGUOenjXexlmXyO(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str, bool z, int i, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void NQGUOenjXexlmXyO(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str, bool z, java.lang.string str2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List NUQXyXrAeGxoeQwM(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore) {
        return fileStore.getReports();
    }

    public static void NUQXyXrAeGxoeQwM(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NUQXyXrAeGxoeQwM(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NUQXyXrAeGxoeQwM(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger NXyBtivjBmAMGyCO() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void NXyBtivjBmAMGyCO(byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NXyBtivjBmAMGyCO(java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NXyBtivjBmAMGyCO(bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator NaJqTBIUYTvruRwI(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void NaJqTBIUYTvruRwI(java.util.List list, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NaJqTBIUYTvruRwI(java.util.List list, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NaJqTBIUYTvruRwI(java.util.List list, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NiNwQnZpnRtgsZCy(java.io.StreamWriter outputStreamWriter, java.lang.string str) {
        outputStreamWriter.write(str);
    }

    public static void NiNwQnZpnRtgsZCy(java.io.StreamWriter outputStreamWriter, java.lang.string str, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NiNwQnZpnRtgsZCy(java.io.StreamWriter outputStreamWriter, java.lang.string str, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NiNwQnZpnRtgsZCy(java.io.StreamWriter outputStreamWriter, java.lang.string str, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.charset.Charset NvsCvuiJHLRJOWif(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    public static void NvsCvuiJHLRJOWif(java.lang.string str, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NvsCvuiJHLRJOWif(java.lang.string str, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NvsCvuiJHLRJOWif(java.lang.string str, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder OZfoLPyJLsRHvETk(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void OZfoLPyJLsRHvETk(java.lang.stringBuilder sb, java.lang.object obj, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OZfoLPyJLsRHvETk(java.lang.stringBuilder sb, java.lang.object obj, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OZfoLPyJLsRHvETk(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OoYfIAzHPeSYIcZx(java.io.stringStream fileStream) throws java.io.IOException {
        fileStream.Dispose();
    }

    public static void OoYfIAzHPeSYIcZx(java.io.stringStream fileStream, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OoYfIAzHPeSYIcZx(java.io.stringStream fileStream, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OoYfIAzHPeSYIcZx(java.io.stringStream fileStream, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PeyhlYarHZxlISqI(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th) {
        logger.m360w(str, th);
    }

    public static void PeyhlYarHZxlISqI(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PeyhlYarHZxlISqI(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PeyhlYarHZxlISqI(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List PgNzWXCRmDSKaGLY(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence) {
        return crashlyticsReportPersistence.getAllFinalizedReportstrings();
    }

    public static void PgNzWXCRmDSKaGLY(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PgNzWXCRmDSKaGLY(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PgNzWXCRmDSKaGLY(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PipRxSkaUBvLeNVI(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void PipRxSkaUBvLeNVI(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, java.lang.string str2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PipRxSkaUBvLeNVI(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, java.lang.string str2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PipRxSkaUBvLeNVI(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger PjmyXBJubALHjVRZ() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void PjmyXBJubALHjVRZ(int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PjmyXBJubALHjVRZ(int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PjmyXBJubALHjVRZ(bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List QDSShMENDBbFWQPU(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence) {
        return crashlyticsReportPersistence.getAllFinalizedReportstrings();
    }

    public static void QDSShMENDBbFWQPU(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QDSShMENDBbFWQPU(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QDSShMENDBbFWQPU(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder QExSYleTTggzEPvZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void QExSYleTTggzEPvZ(java.lang.stringBuilder sb, java.lang.string str, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QExSYleTTggzEPvZ(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QExSYleTTggzEPvZ(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QZtzxFIZoKYxTaaQ(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.io.string file, java.util.List list, long j, bool z, java.lang.string str, java.lang.string str2) {
        crashlyticsReportPersistence.synthesizeReportstring(file, list, j, z, str, str2);
    }

    public static void QZtzxFIZoKYxTaaQ(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.io.string file, java.util.List list, long j, bool z, java.lang.string str, java.lang.string str2, byte b, bool z2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QZtzxFIZoKYxTaaQ(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.io.string file, java.util.List list, long j, bool z, java.lang.string str, java.lang.string str2, int i, float f, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QZtzxFIZoKYxTaaQ(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.io.string file, java.util.List list, long j, bool z, java.lang.string str, java.lang.string str2, int i, bool z2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int QocjaxAJyhjMacpk(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void QocjaxAJyhjMacpk(int i, char c, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QocjaxAJyhjMacpk(int i, short s, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QocjaxAJyhjMacpk(int i, short s, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int QpyIdcivKWxlVkiM(java.util.List list) {
        return list.Count;
    }

    public static void QpyIdcivKWxlVkiM(java.util.List list, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QpyIdcivKWxlVkiM(java.util.List list, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QpyIdcivKWxlVkiM(java.util.List list, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string QvHknjnofNKTMVnq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void QvHknjnofNKTMVnq(java.lang.stringBuilder sb, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QvHknjnofNKTMVnq(java.lang.stringBuilder sb, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QvHknjnofNKTMVnq(java.lang.stringBuilder sb, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QyLNROxKMdHuooog(java.util.List list, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QyLNROxKMdHuooog(java.util.List list, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QyLNROxKMdHuooog(java.util.List list, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool QyLNROxKMdHuooog(java.util.List list) {
        return list.Count == 0;
    }

    public static java.io.string RBOLEBjjFgYpjmvc(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2) {
        return fileStore.getSessionstring(str, str2);
    }

    public static void RBOLEBjjFgYpjmvc(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RBOLEBjjFgYpjmvc(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RBOLEBjjFgYpjmvc(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List RMdvPNmRPARYUQLL(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore) {
        return fileStore.getNativeReports();
    }

    public static void RMdvPNmRPARYUQLL(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RMdvPNmRPARYUQLL(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RMdvPNmRPARYUQLL(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string RWtoXURKZOquMwKT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void RWtoXURKZOquMwKT(java.lang.stringBuilder sb, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RWtoXURKZOquMwKT(java.lang.stringBuilder sb, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RWtoXURKZOquMwKT(java.lang.stringBuilder sb, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List RfKYDmuUkgqxRwvu(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore) {
        return fileStore.getPriorityReports();
    }

    public static void RfKYDmuUkgqxRwvu(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RfKYDmuUkgqxRwvu(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RfKYDmuUkgqxRwvu(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport RfjEWfZMxJmpaCbn(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, java.lang.string str) {
        return crashlyticsReportJsonTransform.reportFromJson(str);
    }

    public static void RfjEWfZMxJmpaCbn(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, java.lang.string str, java.lang.string str2, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RfjEWfZMxJmpaCbn(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, java.lang.string str, short s, java.lang.string str2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RfjEWfZMxJmpaCbn(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, java.lang.string str, bool z, short s, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void RrUlEzyfSdqvjRLX(java.io.byteArrayStream byteArrayStream, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RrUlEzyfSdqvjRLX(java.io.byteArrayStream byteArrayStream, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RrUlEzyfSdqvjRLX(java.io.byteArrayStream byteArrayStream, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte[] RrUlEzyfSdqvjRLX(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.tobyteArray();
    }

    public static java.lang.object RvndjakmWtkCKeDN(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void RvndjakmWtkCKeDN(java.util.IEnumerator it, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RvndjakmWtkCKeDN(java.util.IEnumerator it, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RvndjakmWtkCKeDN(java.util.IEnumerator it, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object SAqXPWwkymNydEqN(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void SAqXPWwkymNydEqN(java.util.IEnumerator it, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SAqXPWwkymNydEqN(java.util.IEnumerator it, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SAqXPWwkymNydEqN(java.util.IEnumerator it, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string SIUIpbJmgjLmlTMN(java.lang.string str) {
        return getEventNameWithoutPriority(str);
    }

    public static void SIUIpbJmgjLmlTMN(java.lang.string str, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SIUIpbJmgjLmlTMN(java.lang.string str, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SIUIpbJmgjLmlTMN(java.lang.string str, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static long SIWNlCZYUSQzwHuH(java.io.string file) {
        if ((31 + 18) % 18 > 0) {
        }
        return file.lastModified();
    }

    public static void SIWNlCZYUSQzwHuH(java.io.string file, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SIWNlCZYUSQzwHuH(java.io.string file, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SIWNlCZYUSQzwHuH(java.io.string file, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SoVlYaNVVzEuRckl(java.util.List list, java.util.Comparator comparator) {
        java.util.ICollections.sort(list, comparator);
    }

    public static void SoVlYaNVVzEuRckl(java.util.List list, java.util.Comparator comparator, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SoVlYaNVVzEuRckl(java.util.List list, java.util.Comparator comparator, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SoVlYaNVVzEuRckl(java.util.List list, java.util.Comparator comparator, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport SpSPVuMmHtTIOaMs(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload) {
        return crashlyticsReport.withNdkPayload(crashlyticsReport$stringsPayload);
    }

    public static void SpSPVuMmHtTIOaMs(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SpSPVuMmHtTIOaMs(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SpSPVuMmHtTIOaMs(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder SufpICEgSQDQWoSD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void SufpICEgSQDQWoSD(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SufpICEgSQDQWoSD(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SufpICEgSQDQWoSD(java.lang.stringBuilder sb, java.lang.string str, short s, char c, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session SvZPiABACgbboAzQ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getSession();
    }

    public static void SvZPiABACgbboAzQ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SvZPiABACgbboAzQ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SvZPiABACgbboAzQ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SwfulNciQtprZPer(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.lang.string str, bool z) {
        crashlyticsReportPersistence.persistEvent(crashlyticsReport$Session$Event, str, z);
    }

    public static void SwfulNciQtprZPer(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.lang.string str, bool z, int i, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SwfulNciQtprZPer(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.lang.string str, bool z, java.lang.string str2, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SwfulNciQtprZPer(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.lang.string str, bool z, java.lang.string str2, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder TEFdVvWYPyxiIaxJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void TEFdVvWYPyxiIaxJ(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TEFdVvWYPyxiIaxJ(java.lang.stringBuilder sb, java.lang.string str, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TEFdVvWYPyxiIaxJ(java.lang.stringBuilder sb, java.lang.string str, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger TFXdCfjaUeuppFZp() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void TFXdCfjaUeuppFZp(byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TFXdCfjaUeuppFZp(java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TFXdCfjaUeuppFZp(short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TSmQuUMGVfxggIGP(java.util.List list) {
        java.util.ICollections.sort(list);
    }

    public static void TSmQuUMGVfxggIGP(java.util.List list, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TSmQuUMGVfxggIGP(java.util.List list, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TSmQuUMGVfxggIGP(java.util.List list, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger TqLQUjRkXHWoMmiG() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void TqLQUjRkXHWoMmiG(byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TqLQUjRkXHWoMmiG(char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TqLQUjRkXHWoMmiG(java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string TsYsiirdQrOfGQza(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static void TsYsiirdQrOfGQza(java.lang.string str, int i, int i2, char c, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void TsYsiirdQrOfGQza(java.lang.string str, int i, int i2, short s, char c, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TsYsiirdQrOfGQza(java.lang.string str, int i, int i2, bool z, java.lang.string str2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TtEeDJUKHOtGLorK(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence) {
        crashlyticsReportPersistence.capFinalizedReports();
    }

    public static void TtEeDJUKHOtGLorK(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TtEeDJUKHOtGLorK(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TtEeDJUKHOtGLorK(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int USUZwlpORyRHiTAn(java.util.SortedHashSet sortedHashSet) {
        return sortedHashSet.Count;
    }

    public static void USUZwlpORyRHiTAn(java.util.SortedHashSet sortedHashSet, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void USUZwlpORyRHiTAn(java.util.SortedHashSet sortedHashSet, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void USUZwlpORyRHiTAn(java.util.SortedHashSet sortedHashSet, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VqsUaLKKWUTANefm(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m359w(str);
    }

    public static void VqsUaLKKWUTANefm(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VqsUaLKKWUTANefm(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VqsUaLKKWUTANefm(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VwLrAVfGuawHZZpM(java.util.IEnumerator it, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VwLrAVfGuawHZZpM(java.util.IEnumerator it, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VwLrAVfGuawHZZpM(java.util.IEnumerator it, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool VwLrAVfGuawHZZpM(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void WbKgoGOnUdkkHqYx(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.util.List list) {
        crashlyticsReportPersistence.deletestrings(list);
    }

    public static void WbKgoGOnUdkkHqYx(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.util.List list, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WbKgoGOnUdkkHqYx(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.util.List list, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WbKgoGOnUdkkHqYx(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.util.List list, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XSiihMDBsGcBWCDt(java.io.stringStream fileStream) throws java.io.IOException {
        fileStream.Dispose();
    }

    public static void XSiihMDBsGcBWCDt(java.io.stringStream fileStream, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XSiihMDBsGcBWCDt(java.io.stringStream fileStream, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XSiihMDBsGcBWCDt(java.io.stringStream fileStream, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder XayQdOGtqlQNJmFv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void XayQdOGtqlQNJmFv(java.lang.stringBuilder sb, java.lang.string str, char c, int i, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XayQdOGtqlQNJmFv(java.lang.stringBuilder sb, java.lang.string str, int i, short s, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void XayQdOGtqlQNJmFv(java.lang.stringBuilder sb, java.lang.string str, short s, int i, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XbmePVDPyDnkpRQc(java.util.List list, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XbmePVDPyDnkpRQc(java.util.List list, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XbmePVDPyDnkpRQc(java.util.List list, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool XbmePVDPyDnkpRQc(java.util.List list) {
        return list.Count == 0;
    }

    public static java.lang.string XjWGqDJWjpOslbDI(java.io.string file) {
        return readTextstring(file);
    }

    public static void XjWGqDJWjpOslbDI(java.io.string file, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XjWGqDJWjpOslbDI(java.io.string file, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XjWGqDJWjpOslbDI(java.io.string file, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XmtAsnlnnzPzqnQP(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th) {
        logger.m360w(str, th);
    }

    public static void XmtAsnlnnzPzqnQP(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XmtAsnlnnzPzqnQP(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XmtAsnlnnzPzqnQP(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport YYxdTTyzxeWBVbmo(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.util.List list) {
        return crashlyticsReport.withEvents(list);
    }

    public static void YYxdTTyzxeWBVbmo(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.util.List list, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YYxdTTyzxeWBVbmo(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.util.List list, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YYxdTTyzxeWBVbmo(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.util.List list, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YnjGdkHQSNLsuyRF(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th) {
        logger.m352d(str, th);
    }

    public static void YnjGdkHQSNLsuyRF(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YnjGdkHQSNLsuyRF(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YnjGdkHQSNLsuyRF(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ZZfHZnQCgxnRarXn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ZZfHZnQCgxnRarXn(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZZfHZnQCgxnRarXn(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void ZZfHZnQCgxnRarXn(java.lang.stringBuilder sb, java.lang.string str, float f, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void ZevuxQiNuRdeOPYn(java.util.List list, java.lang.object obj, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZevuxQiNuRdeOPYn(java.util.List list, java.lang.object obj, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZevuxQiNuRdeOPYn(java.util.List list, java.lang.object obj, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ZevuxQiNuRdeOPYn(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.firebase.crashlytics.internal.Consoleger AIOBXQBLBrzdAfYx() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void AIOBXQBLBrzdAfYx(char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AIOBXQBLBrzdAfYx(int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AIOBXQBLBrzdAfYx(bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder AOfVhiNzkVskGelQ(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void AOfVhiNzkVskGelQ(java.lang.stringBuilder sb, java.lang.object obj, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AOfVhiNzkVskGelQ(java.lang.stringBuilder sb, java.lang.object obj, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AOfVhiNzkVskGelQ(java.lang.stringBuilder sb, java.lang.object obj, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator ApsGPgqikrArPKjD(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void ApsGPgqikrArPKjD(java.util.List list, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ApsGPgqikrArPKjD(java.util.List list, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ApsGPgqikrArPKjD(java.util.List list, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string BTGSQslDVmhBVVnm(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str) {
        return fileStore.getPriorityReport(str);
    }

    public static void BTGSQslDVmhBVVnm(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BTGSQslDVmhBVVnm(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BTGSQslDVmhBVVnm(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BXByHdwJSgWaKrQZ(java.io.string file, java.lang.string str) throws java.io.IOException {
        writeTextstring(file, str);
    }

    public static void BXByHdwJSgWaKrQZ(java.io.string file, java.lang.string str, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BXByHdwJSgWaKrQZ(java.io.string file, java.lang.string str, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BXByHdwJSgWaKrQZ(java.io.string file, java.lang.string str, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int BfrFrDPjbBaCgWBD(java.lang.string str) {
        return str.Length;
    }

    public static void BfrFrDPjbBaCgWBD(java.lang.string str, byte b, float f, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void BfrFrDPjbBaCgWBD(java.lang.string str, byte b, bool z, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void BfrFrDPjbBaCgWBD(java.lang.string str, bool z, java.lang.string str2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BtEtXNftQfjcHIhT(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void BtEtXNftQfjcHIhT(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, byte b, java.lang.string str2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BtEtXNftQfjcHIhT(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, float f, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BtEtXNftQfjcHIhT(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, java.lang.string str2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string CLPspMdbAJqHmBfv(java.io.string file) {
        return file.getName();
    }

    public static void CLPspMdbAJqHmBfv(java.io.string file, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CLPspMdbAJqHmBfv(java.io.string file, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CLPspMdbAJqHmBfv(java.io.string file, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private java.util.SortedHashSet<java.lang.string> CapAndGetOpenSessions(java.lang.string str) {
        if ((10 + 26) % 26 > 0) {
        }
        NJNBkAODMvPWEIVs(this.fileStore);
        java.util.SortedHashSet<java.lang.string> sortedHashSetMmXrGDpagpiqbeOP = mmXrGDpagpiqbeOP(this);
        if (str is not null) {
            kVEgIyTWUSoAhtau(sortedHashSetMmXrGDpagpiqbeOP, str);
        }
        if (cgXtHXcxpbHprRYr(sortedHashSetMmXrGDpagpiqbeOP) > 8) {
            while (USUZwlpORyRHiTAn(sortedHashSetMmXrGDpagpiqbeOP) > 8) {
                java.lang.string str2 = (java.lang.string) EdevCwxQpPGzahtr(sortedHashSetMmXrGDpagpiqbeOP);
                PipRxSkaUBvLeNVI(TqLQUjRkXHWoMmiG(), uDKJIhYpioMEUFVd(oNDmNehxWvvJtATw(new java.lang.stringBuilder("Removing session over cap: "), str2)));
                JqmcoRYRMRRWzBxW(this.fileStore, str2);
                voSpfiBLQKpnpuvR(sortedHashSetMmXrGDpagpiqbeOP, str2);
            }
        }
        return sortedHashSetMmXrGDpagpiqbeOP;
    }

    private void CapAndGetOpenSessions(java.lang.string str, byte b, short s, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    private void CapAndGetOpenSessions(java.lang.string str, java.lang.string str2, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void CapAndGetOpenSessions(java.lang.string str, short s, java.lang.string str2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private static int CapstringsCount(java.util.List<java.io.string> list, int i) {
        if ((8 + 23) % 23 > 0) {
        }
        int iQpyIdcivKWxlVkiM = QpyIdcivKWxlVkiM(list);
        java.util.IEnumerator itYWmrgNuGbGWxIKsr = yWmrgNuGbGWxIKsr(list);
        while (qOtDqdoVBzgQYuyZ(itYWmrgNuGbGWxIKsr)) {
            java.io.string file = (java.io.string) vVEbuAScuFVdVCtn(itYWmrgNuGbGWxIKsr);
            if (iQpyIdcivKWxlVkiM <= i) {
                break;
            }
            FiSADYsWrTtLrdYk(file);
            iQpyIdcivKWxlVkiM--;
        }
        return iQpyIdcivKWxlVkiM;
    }

    private static void CapstringsCount(java.util.List list, int i, float f, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    private static void CapstringsCount(java.util.List list, int i, float f, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    private static void CapstringsCount(java.util.List list, int i, short s, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void CapFinalizedReports() {
        if ((24 + 24) % 24 > 0) {
        }
        int i = rMacWmfJlvwpTcqA(this.settingsProvider).sessionData.maxCompleteSessionsCount;
        java.util.List listQDSShMENDBbFWQPU = QDSShMENDBbFWQPU(this);
        int iSicpJFyikPcSfRjJ = sicpJFyikPcSfRjJ(listQDSShMENDBbFWQPU);
        if (iSicpJFyikPcSfRjJ > i) {
            java.util.IEnumerator itVleAGuKxCFokuvSE = vleAGuKxCFokuvSE(fbYhlPPEsApZYJXf(listQDSShMENDBbFWQPU, i, iSicpJFyikPcSfRjJ));
            while (FxwYtTezuCyjmWeN(itVleAGuKxCFokuvSE)) {
                unyuEuWVCXqdIIIx((java.io.string) mPevoiTCUtdacQxO(itVleAGuKxCFokuvSE));
            }
        }
    }

    private void CapFinalizedReports(byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void CapFinalizedReports(float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void CapFinalizedReports(bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int CgXtHXcxpbHprRYr(java.util.SortedHashSet sortedHashSet) {
        return sortedHashSet.Count;
    }

    public static void CgXtHXcxpbHprRYr(java.util.SortedHashSet sortedHashSet, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CgXtHXcxpbHprRYr(java.util.SortedHashSet sortedHashSet, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CgXtHXcxpbHprRYr(java.util.SortedHashSet sortedHashSet, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private static long ConvertTimestampFromSecondsToMs(long j) {
        if ((13 + 14) % 14 > 0) {
        }
        return j * 1000;
    }

    private static void ConvertTimestampFromSecondsToMs(long j, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private static void ConvertTimestampFromSecondsToMs(long j, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private static void ConvertTimestampFromSecondsToMs(long j, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string CsoMdgcVMCaJdXAP(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static void CsoMdgcVMCaJdXAP(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CsoMdgcVMCaJdXAP(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CsoMdgcVMCaJdXAP(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object DERiMSXthGuAaoTf(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void DERiMSXthGuAaoTf(java.util.IEnumerator it, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DERiMSXthGuAaoTf(java.util.IEnumerator it, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DERiMSXthGuAaoTf(java.util.IEnumerator it, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string DNLLctRzruooqPKR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void DNLLctRzruooqPKR(java.lang.stringBuilder sb, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DNLLctRzruooqPKR(java.lang.stringBuilder sb, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DNLLctRzruooqPKR(java.lang.stringBuilder sb, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string DPIuYOKsTWvkwyko(java.io.string file) {
        return readTextstring(file);
    }

    public static void DPIuYOKsTWvkwyko(java.io.string file, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DPIuYOKsTWvkwyko(java.io.string file, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DPIuYOKsTWvkwyko(java.io.string file, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DSsoQmFVkzdSLKbv(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.util.List list) {
        crashlyticsReportPersistence.deletestrings(list);
    }

    public static void DSsoQmFVkzdSLKbv(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.util.List list, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DSsoQmFVkzdSLKbv(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.util.List list, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DSsoQmFVkzdSLKbv(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.util.List list, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void Deletestrings(java.util.List<java.io.string> list) {
        java.util.IEnumerator itNaJqTBIUYTvruRwI = NaJqTBIUYTvruRwI(list);
        while (LRUPUHUwrmzRzYZM(itNaJqTBIUYTvruRwI)) {
            oIiCQztNsUJHjzDA((java.io.string) SAqXPWwkymNydEqN(itNaJqTBIUYTvruRwI));
        }
    }

    private void Deletestrings(java.util.List list, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void Deletestrings(java.util.List list, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void Deletestrings(java.util.List list, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger DsRrQJUOuAZoqHQG() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void DsRrQJUOuAZoqHQG(byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DsRrQJUOuAZoqHQG(int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DsRrQJUOuAZoqHQG(int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DwMzcfynvkzSWFub(java.util.IEnumerator it, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DwMzcfynvkzSWFub(java.util.IEnumerator it, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DwMzcfynvkzSWFub(java.util.IEnumerator it, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool DwMzcfynvkzSWFub(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport DygCPtxrGGRXQKxw(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        return crashlyticsReport.withApplicationExitInfo(crashlyticsReport$ApplicationExitInfo);
    }

    public static void DygCPtxrGGRXQKxw(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DygCPtxrGGRXQKxw(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DygCPtxrGGRXQKxw(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ERgqnTItSZLHQqdL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ERgqnTItSZLHQqdL(java.lang.stringBuilder sb, java.lang.string str, char c, short s, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ERgqnTItSZLHQqdL(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ERgqnTItSZLHQqdL(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int EZIOAqQFwmXLGOxe(java.lang.string str, java.lang.string str2) {
        return str.compareTo(str2);
    }

    public static void EZIOAqQFwmXLGOxe(java.lang.string str, java.lang.string str2, int i, char c, java.lang.string str3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EZIOAqQFwmXLGOxe(java.lang.string str, java.lang.string str2, java.lang.string str3, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EZIOAqQFwmXLGOxe(java.lang.string str, java.lang.string str2, short s, char c, java.lang.string str3, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder EkuWfBWnKMrJNwbn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void EkuWfBWnKMrJNwbn(java.lang.stringBuilder sb, java.lang.string str, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EkuWfBWnKMrJNwbn(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EkuWfBWnKMrJNwbn(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder FURilYMIoBacjpYc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void FURilYMIoBacjpYc(java.lang.stringBuilder sb, java.lang.string str, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FURilYMIoBacjpYc(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FURilYMIoBacjpYc(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List FbYhlPPEsApZYJXf(java.util.List list, int i, int i2) {
        return list.subList(i, i2);
    }

    public static void FbYhlPPEsApZYJXf(java.util.List list, int i, int i2, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FbYhlPPEsApZYJXf(java.util.List list, int i, int i2, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FbYhlPPEsApZYJXf(java.util.List list, int i, int i2, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FxjIiOKgpInaWfCz(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str, long j) {
        crashlyticsReportPersistence.synthesizeReport(str, j);
    }

    public static void FxjIiOKgpInaWfCz(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str, long j, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FxjIiOKgpInaWfCz(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str, long j, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FxjIiOKgpInaWfCz(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.lang.string str, long j, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FznXjndHshSjNofM(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event) {
        return crashlyticsReportJsonTransform.eventToJson(crashlyticsReport$Session$Event);
    }

    public static void FznXjndHshSjNofM(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FznXjndHshSjNofM(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FznXjndHshSjNofM(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private static java.lang.string GenerateEventstringname(int i, bool z) {
        if ((13 + 16) % 16 > 0) {
        }
        return vIytkMkNZPfyDQfK(QExSYleTTggzEPvZ(FxbGqpSLApqpAQgy(new java.lang.stringBuilder("event"), csoMdgcVMCaJdXAP(java.util.Locale.US, "%010d", new java.lang.object[]{QocjaxAJyhjMacpk(i)})), !z ? "" : "_"));
    }

    private static void GenerateEventstringname(int i, bool z, float f, java.lang.string str, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    private static void GenerateEventstringname(int i, bool z, java.lang.string str, short s, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    private static void GenerateEventstringname(int i, bool z, bool z2, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private java.util.List<java.io.string> GetAllFinalizedReportstrings() {
        if ((14 + 19) % 19 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        LwoUzRISSgMrIDkt(arrayList, juxjKzcJVBNHmMon(this.fileStore));
        CyWzmSpUjlDxRRbG(arrayList, RMdvPNmRPARYUQLL(this.fileStore));
        java.util.Comparator<java.io.string> comparator = LATEST_SESSION_ID_FIRST_COMPARATOR;
        BrKnxWpkLIEixmzJ(arrayList, comparator);
        java.util.List listNUQXyXrAeGxoeQwM = NUQXyXrAeGxoeQwM(this.fileStore);
        SoVlYaNVVzEuRckl(listNUQXyXrAeGxoeQwM, comparator);
        BmpKNRuqMquUldeO(arrayList, listNUQXyXrAeGxoeQwM);
        return arrayList;
    }

    private void GetAllFinalizedReportstrings(char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetAllFinalizedReportstrings(char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void GetAllFinalizedReportstrings(java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private static java.lang.string GetEventNameWithoutPriority(java.lang.string str) {
        if ((29 + 30) % 30 > 0) {
        }
        return TsYsiirdQrOfGQza(str, 0, EVENT_NAME_LENGTH);
    }

    private static void GetEventNameWithoutPriority(java.lang.string str, char c, float f, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void GetEventNameWithoutPriority(java.lang.string str, java.lang.string str2, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private static void GetEventNameWithoutPriority(java.lang.string str, bool z, java.lang.string str2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GrTQreHjIEfGqYwI(int i, bool z) {
        return generateEventstringname(i, z);
    }

    public static void GrTQreHjIEfGqYwI(int i, bool z, float f, java.lang.string str, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GrTQreHjIEfGqYwI(int i, bool z, float f, short s, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GrTQreHjIEfGqYwI(int i, bool z, bool z2, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HCIrvnZdvOpwahri(java.util.List list, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HCIrvnZdvOpwahri(java.util.List list, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HCIrvnZdvOpwahri(java.util.List list, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool HCIrvnZdvOpwahri(java.util.List list) {
        return list.Count == 0;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger HJmJGqLsONWuCNBO() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void HJmJGqLsONWuCNBO(float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HJmJGqLsONWuCNBO(java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HJmJGqLsONWuCNBO(bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger IGfrjBDAfYhIkfyl() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void IGfrjBDAfYhIkfyl(float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IGfrjBDAfYhIkfyl(float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IGfrjBDAfYhIkfyl(int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IqtKbmHtTdpWZbaY(java.util.List list, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IqtKbmHtTdpWZbaY(java.util.List list, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IqtKbmHtTdpWZbaY(java.util.List list, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool IqtKbmHtTdpWZbaY(java.util.List list) {
        return list.Count == 0;
    }

    private static void IsHighPriorityEventstring(java.lang.string str, char c, byte b, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    private static void IsHighPriorityEventstring(java.lang.string str, char c, byte b, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private static void IsHighPriorityEventstring(java.lang.string str, java.lang.string str2, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private static bool IsHighPriorityEventstring(java.lang.string str) {
        return BMEQLuDmzxXdPFpd(str, "event") && MDFFRskbISZnnhpl(str, "_");
    }

    private static void IsNormalPriorityEventstring(java.io.string file, java.lang.string str, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void IsNormalPriorityEventstring(java.io.string file, java.lang.string str, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private static void IsNormalPriorityEventstring(java.io.string file, java.lang.string str, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private static bool IsNormalPriorityEventstring(java.io.string file, java.lang.string str) {
        return FAsVVjdfRNrySPBz(str, "event") && !yoYBCMuLmPZhSicS(str, "_");
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport JCyyWHRKTjjfgmWR(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, java.lang.string str) {
        return crashlyticsReportJsonTransform.reportFromJson(str);
    }

    public static void JCyyWHRKTjjfgmWR(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, java.lang.string str, byte b, float f, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void JCyyWHRKTjjfgmWR(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, java.lang.string str, byte b, java.lang.string str2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JCyyWHRKTjjfgmWR(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, java.lang.string str, java.lang.string str2, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event jHouPYiDUnDVyUeQ(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, java.lang.string str) {
        return crashlyticsReportJsonTransform.eventFromJson(str);
    }

    public static void JHouPYiDUnDVyUeQ(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, java.lang.string str, java.lang.string str2, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JHouPYiDUnDVyUeQ(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, java.lang.string str, java.lang.string str2, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JHouPYiDUnDVyUeQ(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, java.lang.string str, java.lang.string str2, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List JuxjKzcJVBNHmMon(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore) {
        return fileStore.getPriorityReports();
    }

    public static void JuxjKzcJVBNHmMon(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JuxjKzcJVBNHmMon(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JuxjKzcJVBNHmMon(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string JzuowupGaCrtyktW(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReportJsonTransform.reportToJson(crashlyticsReport);
    }

    public static void JzuowupGaCrtyktW(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JzuowupGaCrtyktW(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JzuowupGaCrtyktW(com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform, com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List KFKzfTcJsHIPbPjp(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore) {
        return fileStore.getNativeReports();
    }

    public static void KFKzfTcJsHIPbPjp(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KFKzfTcJsHIPbPjp(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KFKzfTcJsHIPbPjp(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List KTfHTkMIQlRpVROH(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore) {
        return fileStore.getAllOpenSessionIds();
    }

    public static void KTfHTkMIQlRpVROH(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KTfHTkMIQlRpVROH(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KTfHTkMIQlRpVROH(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KVEgIyTWUSoAhtau(java.util.SortedHashSet sortedHashSet, java.lang.object obj, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KVEgIyTWUSoAhtau(java.util.SortedHashSet sortedHashSet, java.lang.object obj, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KVEgIyTWUSoAhtau(java.util.SortedHashSet sortedHashSet, java.lang.object obj, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool KVEgIyTWUSoAhtau(java.util.SortedHashSet sortedHashSet, java.lang.object obj) {
        return sortedHashSet.Remove(obj);
    }

    public static java.util.List KqKiEwXpNxAfYxpu(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore) {
        return fileStore.getReports();
    }

    public static void KqKiEwXpNxAfYxpu(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KqKiEwXpNxAfYxpu(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KqKiEwXpNxAfYxpu(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string LCayNkdjLHiyEiHw(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2) {
        return fileStore.getSessionstring(str, str2);
    }

    public static void LCayNkdjLHiyEiHw(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, int i, bool z, java.lang.string str3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LCayNkdjLHiyEiHw(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LCayNkdjLHiyEiHw(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, bool z, java.lang.string str3, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LIRiqnEflqwYcRRo(java.lang.Exception th, java.lang.Exception th2) {
        th.addSuppressed(th2);
    }

    public static void LIRiqnEflqwYcRRo(java.lang.Exception th, java.lang.Exception th2, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LIRiqnEflqwYcRRo(java.lang.Exception th, java.lang.Exception th2, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LIRiqnEflqwYcRRo(java.lang.Exception th, java.lang.Exception th2, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator LQDoVVJiDjLoJbXF(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void LQDoVVJiDjLoJbXF(java.util.List list, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LQDoVVJiDjLoJbXF(java.util.List list, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LQDoVVJiDjLoJbXF(java.util.List list, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    static int lambda$static$0(java.io.string file, java.io.string file2) {
        return eZIOAqQFwmXLGOxe(MzbiHQwbDMOcGuhR(file2), KNIfJBIFGbjIRiQZ(file));
    }

    static void lambda$static$0(java.io.string file, java.io.string file2, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    static void lambda$static$0(java.io.string file, java.io.string file2, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static void lambda$static$0(java.io.string file, java.io.string file2, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    static void lambda$static$1(java.io.string file, java.lang.string str, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    static void lambda$static$1(java.io.string file, java.lang.string str, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    static void lambda$static$1(java.io.string file, java.lang.string str, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static bool lambda$static$1(java.io.string file, java.lang.string str) {
        return lbSDVQNHUQshqCHa(str, "event");
    }

    public static void LbSDVQNHUQshqCHa(java.lang.string str, java.lang.string str2, float f, bool z, java.lang.string str3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LbSDVQNHUQshqCHa(java.lang.string str, java.lang.string str2, bool z, byte b, java.lang.string str3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LbSDVQNHUQshqCHa(java.lang.string str, java.lang.string str2, bool z, float f, java.lang.string str3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool LbSDVQNHUQshqCHa(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static void LbeZgdfsdDSguMFS(java.util.IEnumerator it, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LbeZgdfsdDSguMFS(java.util.IEnumerator it, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LbeZgdfsdDSguMFS(java.util.IEnumerator it, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool LbeZgdfsdDSguMFS(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.List LfnAoreVwWbLLoAq(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.io.stringnameFilter filenameFilter) {
        return fileStore.getSessionstrings(str, filenameFilter);
    }

    public static void LfnAoreVwWbLLoAq(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.io.stringnameFilter filenameFilter, char c, float f, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LfnAoreVwWbLLoAq(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.io.stringnameFilter filenameFilter, char c, int i, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LfnAoreVwWbLLoAq(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.io.stringnameFilter filenameFilter, java.lang.string str2, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object MPevoiTCUtdacQxO(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void MPevoiTCUtdacQxO(java.util.IEnumerator it, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MPevoiTCUtdacQxO(java.util.IEnumerator it, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MPevoiTCUtdacQxO(java.util.IEnumerator it, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder MSluTtjMCmpzVSIv(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void MSluTtjMCmpzVSIv(java.lang.stringBuilder sb, java.lang.object obj, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MSluTtjMCmpzVSIv(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MSluTtjMCmpzVSIv(java.lang.stringBuilder sb, java.lang.object obj, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.SortedHashSet MmXrGDpagpiqbeOP(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence) {
        return crashlyticsReportPersistence.getOpenSessionIds();
    }

    public static void MmXrGDpagpiqbeOP(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MmXrGDpagpiqbeOP(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MmXrGDpagpiqbeOP(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder MtYhdOBvdFcdEqbw(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void MtYhdOBvdFcdEqbw(java.lang.stringBuilder sb, java.lang.object obj, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MtYhdOBvdFcdEqbw(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MtYhdOBvdFcdEqbw(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MtmNmrsnEXwUZIqy(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void MtmNmrsnEXwUZIqy(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, byte b, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void MtmNmrsnEXwUZIqy(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MtmNmrsnEXwUZIqy(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NbvPogTVlYafajHW(java.io.string file) {
        return file.getName();
    }

    public static void NbvPogTVlYafajHW(java.io.string file, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NbvPogTVlYafajHW(java.io.string file, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NbvPogTVlYafajHW(java.io.string file, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static int NkVLAKNONtNvTIFR(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static void NkVLAKNONtNvTIFR(java.util.concurrent.atomic.Atomicint atomicint, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NkVLAKNONtNvTIFR(java.util.concurrent.atomic.Atomicint atomicint, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NkVLAKNONtNvTIFR(java.util.concurrent.atomic.Atomicint atomicint, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger NrnGgXshbIltgkXj() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void NrnGgXshbIltgkXj(byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NrnGgXshbIltgkXj(float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NrnGgXshbIltgkXj(float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OHtQRLIysZKtmpMK(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th) {
        logger.m360w(str, th);
    }

    public static void OHtQRLIysZKtmpMK(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, java.lang.string str2, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OHtQRLIysZKtmpMK(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, java.lang.string str2, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OHtQRLIysZKtmpMK(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, bool z, int i, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void OIiCQztNsUJHjzDA(java.io.string file, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OIiCQztNsUJHjzDA(java.io.string file, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OIiCQztNsUJHjzDA(java.io.string file, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool OIiCQztNsUJHjzDA(java.io.string file) {
        return file.delete();
    }

    public static void OItPvnqMGCmYZtjo(java.lang.string str, float f, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OItPvnqMGCmYZtjo(java.lang.string str, java.lang.string str2, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OItPvnqMGCmYZtjo(java.lang.string str, short s, java.lang.string str2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool OItPvnqMGCmYZtjo(java.lang.string str) {
        return isHighPriorityEventstring(str);
    }

    public static int OMuFLQLLQmysUcYE(java.io.stringStream fileStream, byte[] bArr) {
        return fileStream.read(bArr);
    }

    public static void OMuFLQLLQmysUcYE(java.io.stringStream fileStream, byte[] bArr, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OMuFLQLLQmysUcYE(java.io.stringStream fileStream, byte[] bArr, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OMuFLQLLQmysUcYE(java.io.stringStream fileStream, byte[] bArr, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ONDmNehxWvvJtATw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ONDmNehxWvvJtATw(java.lang.stringBuilder sb, java.lang.string str, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ONDmNehxWvvJtATw(java.lang.stringBuilder sb, java.lang.string str, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ONDmNehxWvvJtATw(java.lang.stringBuilder sb, java.lang.string str, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OUVBeCUseSRHwDxz(java.io.StreamWriter outputStreamWriter) throws java.io.IOException {
        outputStreamWriter.Dispose();
    }

    public static void OUVBeCUseSRHwDxz(java.io.StreamWriter outputStreamWriter, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OUVBeCUseSRHwDxz(java.io.StreamWriter outputStreamWriter, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OUVBeCUseSRHwDxz(java.io.StreamWriter outputStreamWriter, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session ocPtPHzdJCzzHNtN(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getSession();
    }

    public static void OcPtPHzdJCzzHNtN(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OcPtPHzdJCzzHNtN(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OcPtPHzdJCzzHNtN(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private static int OldestEventstringFirst(java.io.string file, java.io.string file2) {
        return KGwPwHPCKoyAdEOs(BNyFFSjRWlCqUbWg(nbvPogTVlYafajHW(file)), SIUIpbJmgjLmlTMN(vvCcIebdikKFvjEr(file2)));
    }

    private static void OldestEventstringFirst(java.io.string file, java.io.string file2, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private static void OldestEventstringFirst(java.io.string file, java.io.string file2, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private static void OldestEventstringFirst(java.io.string file, java.io.string file2, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int PRmmqvIksyHgOgNH(java.util.List list, int i) {
        return capstringsCount(list, i);
    }

    public static void PRmmqvIksyHgOgNH(java.util.List list, int i, char c, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PRmmqvIksyHgOgNH(java.util.List list, int i, float f, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PRmmqvIksyHgOgNH(java.util.List list, int i, int i2, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string PtdIKzifxhihILGC(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void PtdIKzifxhihILGC(java.lang.stringBuilder sb, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PtdIKzifxhihILGC(java.lang.stringBuilder sb, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PtdIKzifxhihILGC(java.lang.stringBuilder sb, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder QGdCOAQpNxevWYgW(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void QGdCOAQpNxevWYgW(java.lang.stringBuilder sb, java.lang.object obj, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QGdCOAQpNxevWYgW(java.lang.stringBuilder sb, java.lang.object obj, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QGdCOAQpNxevWYgW(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QOtDqdoVBzgQYuyZ(java.util.IEnumerator it, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QOtDqdoVBzgQYuyZ(java.util.IEnumerator it, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QOtDqdoVBzgQYuyZ(java.util.IEnumerator it, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool QOtDqdoVBzgQYuyZ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport QazTIMchCJOpOMTU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str) {
        return crashlyticsReport.withAppQualitySessionId(str);
    }

    public static void QazTIMchCJOpOMTU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, char c, byte b, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QazTIMchCJOpOMTU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, short s, byte b, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QazTIMchCJOpOMTU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, short s, char c, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string QdoGOrkypAGtkiNb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void QdoGOrkypAGtkiNb(java.lang.stringBuilder sb, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QdoGOrkypAGtkiNb(java.lang.stringBuilder sb, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QdoGOrkypAGtkiNb(java.lang.stringBuilder sb, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string QoTrBznUoGkZyiwb(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2) {
        return fileStore.getSessionstring(str, str2);
    }

    public static void QoTrBznUoGkZyiwb(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QoTrBznUoGkZyiwb(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QoTrBznUoGkZyiwb(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string QqXjJIyQyuHfowBG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void QqXjJIyQyuHfowBG(java.lang.stringBuilder sb, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QqXjJIyQyuHfowBG(java.lang.stringBuilder sb, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QqXjJIyQyuHfowBG(java.lang.stringBuilder sb, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int RDdkEIgBjjtKoJOz(java.io.string file, java.io.string file2) {
        return oldestEventstringFirst(file, file2);
    }

    public static void RDdkEIgBjjtKoJOz(java.io.string file, java.io.string file2, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RDdkEIgBjjtKoJOz(java.io.string file, java.io.string file2, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RDdkEIgBjjtKoJOz(java.io.string file, java.io.string file2, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RMFCAcMXgfbxuLST(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.io.string file, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload, java.lang.string str, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        crashlyticsReportPersistence.synthesizeNativeReportstring(file, crashlyticsReport$stringsPayload, str, crashlyticsReport$ApplicationExitInfo);
    }

    public static void RMFCAcMXgfbxuLST(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.io.string file, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload, java.lang.string str, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, byte b, char c, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void RMFCAcMXgfbxuLST(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.io.string file, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload, java.lang.string str, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, int i, byte b, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void RMFCAcMXgfbxuLST(com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence crashlyticsReportPersistence, java.io.string file, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload, java.lang.string str, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, int i, char c, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.settings.HashSettings RMacWmfJlvwpTcqA(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider) {
        return settingsProvider.getHashSettingsSync();
    }

    public static void RMacWmfJlvwpTcqA(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RMacWmfJlvwpTcqA(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RMacWmfJlvwpTcqA(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder RZHvygMztfZPvakB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void RZHvygMztfZPvakB(java.lang.stringBuilder sb, java.lang.string str, float f, int i, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RZHvygMztfZPvakB(java.lang.stringBuilder sb, java.lang.string str, float f, int i, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void RZHvygMztfZPvakB(java.lang.stringBuilder sb, java.lang.string str, float f, bool z, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private static java.lang.string ReadTextstring(java.io.string file) throws java.io.IOException {
        if ((6 + 19) % 19 > 0) {
        }
        byte[] bArr = new byte[8192];
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        java.io.stringStream fileStream = new java.io.stringStream(file);
        while (true) {
            try {
                int iOMuFLQLLQmysUcYE = oMuFLQLLQmysUcYE(fileStream, bArr);
                if (iOMuFLQLLQmysUcYE <= 0) {
                    java.lang.string str = new java.lang.string(RrUlEzyfSdqvjRLX(byteArrayStream), UTF_8);
                    OoYfIAzHPeSYIcZx(fileStream);
                    return str;
                }
                zgVRBwQwrgDpOvBM(byteArrayStream, bArr, 0, iOMuFLQLLQmysUcYE);
            } catch (java.lang.Exception th) {
                try {
                    XSiihMDBsGcBWCDt(fileStream);
                } catch (java.lang.Exception th2) {
                    GuaRkiMbblbgtxOf(th, th2);
                }
                throw th;
            }
        }
    }

    private static void ReadTextstring(java.io.string file, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private static void ReadTextstring(java.io.string file, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private static void ReadTextstring(java.io.string file, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List RzgOmOjQRieRmujo(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.io.stringnameFilter filenameFilter) {
        return fileStore.getSessionstrings(str, filenameFilter);
    }

    public static void RzgOmOjQRieRmujo(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.io.stringnameFilter filenameFilter, java.lang.string str2, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RzgOmOjQRieRmujo(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.io.stringnameFilter filenameFilter, java.lang.string str2, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RzgOmOjQRieRmujo(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.io.stringnameFilter filenameFilter, java.lang.string str2, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int SicpJFyikPcSfRjJ(java.util.List list) {
        return list.Count;
    }

    public static void SicpJFyikPcSfRjJ(java.util.List list, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SicpJFyikPcSfRjJ(java.util.List list, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SicpJFyikPcSfRjJ(java.util.List list, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SnJSJdPBoOALPlKG(java.io.string file, java.lang.string str) throws java.io.IOException {
        writeTextstring(file, str);
    }

    public static void SnJSJdPBoOALPlKG(java.io.string file, java.lang.string str, java.lang.string str2, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SnJSJdPBoOALPlKG(java.io.string file, java.lang.string str, short s, bool z, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SnJSJdPBoOALPlKG(java.io.string file, java.lang.string str, bool z, short s, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string SovzmIERgPnlQLgk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void SovzmIERgPnlQLgk(java.lang.stringBuilder sb, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SovzmIERgPnlQLgk(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SovzmIERgPnlQLgk(java.lang.stringBuilder sb, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void SynthesizeNativeReportstring(java.io.string file, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload, java.lang.string str, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        if ((22 + 16) % 16 > 0) {
        }
        java.lang.string strNHTEaibfdlaFxZbw = NHTEaibfdlaFxZbw(this.sessionsSubscriber, str);
        try {
            com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform = TRANSFORM;
            FrvcUIzBqPysILAC(GilLkAmuAgRBmSvG(this.fileStore, str), jzuowupGaCrtyktW(crashlyticsReportJsonTransform, KySXPySUcgqBHADA(dygCPtxrGGRXQKxw(SpSPVuMmHtTIOaMs(MYoewaAGhmhLkvON(crashlyticsReportJsonTransform, IMirnLRTtTWvVoGi(file)), crashlyticsReport$stringsPayload), crashlyticsReport$ApplicationExitInfo), strNHTEaibfdlaFxZbw)));
        } catch (java.io.IOException e) {
            oHtQRLIysZKtmpMK(iGfrjBDAfYhIkfyl(), unBJucoyLOLvPjnj(mSluTtjMCmpzVSIv(new java.lang.stringBuilder("Could not synthesize readonly report file for "), file)), e);
        }
    }

    private void SynthesizeNativeReportstring(java.io.string file, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload, java.lang.string str, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, byte b, int i, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private void SynthesizeNativeReportstring(java.io.string file, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload, java.lang.string str, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, int i, java.lang.string str2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void SynthesizeNativeReportstring(java.io.string file, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload, java.lang.string str, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, java.lang.string str2, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void SynthesizeReport(java.lang.string str, long j) {
        bool z;
        if ((28 + 2) % 2 > 0) {
        }
        java.util.List listRzgOmOjQRieRmujo = rzgOmOjQRieRmujo(this.fileStore, str, EVENT_FILE_FILTER);
        if (hCIrvnZdvOpwahri(listRzgOmOjQRieRmujo)) {
            GLfYBvOrlHbXZpfD(LSfDluaUzEyMgemU(), qdoGOrkypAGtkiNb(XayQdOGtqlQNJmFv(rZHvygMztfZPvakB(new java.lang.stringBuilder("Session "), str), " has no events.")));
            return;
        }
        TSmQuUMGVfxggIGP(listRzgOmOjQRieRmujo);
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator itLQDoVVJiDjLoJbXF = lQDoVVJiDjLoJbXF(listRzgOmOjQRieRmujo);
        loop0: while (true) {
            z = false;
            while (true) {
                if (!lbeZgdfsdDSguMFS(itLQDoVVJiDjLoJbXF)) {
                    break loop0;
                }
                java.io.string file = (java.io.string) RvndjakmWtkCKeDN(itLQDoVVJiDjLoJbXF);
                try {
                    ZevuxQiNuRdeOPYn(arrayList, jHouPYiDUnDVyUeQ(TRANSFORM, XjWGqDJWjpOslbDI(file)));
                } catch (java.io.IOException e) {
                    PeyhlYarHZxlISqI(nrnGgXshbIltgkXj(), ptdIKzifxhihILGC(OZfoLPyJLsRHvETk(new java.lang.stringBuilder("Could not add event to report for "), file)), e);
                }
                if (z || oItPvnqMGCmYZtjo(cLPspMdbAJqHmBfv(file))) {
                    z = true;
                }
            }
        }
        if (iqtKbmHtTdpWZbaY(arrayList)) {
            VqsUaLKKWUTANefm(dsRrQJUOuAZoqHQG(), RWtoXURKZOquMwKT(SufpICEgSQDQWoSD(new java.lang.stringBuilder("Could not parse event files for session "), str)));
            return;
        }
        QZtzxFIZoKYxTaaQ(this, NCzmUUxnRGCXraOC(this.fileStore, str, "report"), arrayList, j, z, EgOQnmEopHQuPWvE(str, this.fileStore), zyjesALmohlWsnxw(this.sessionsSubscriber, str));
    }

    private void SynthesizeReport(java.lang.string str, long j, byte b, java.lang.string str2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void SynthesizeReport(java.lang.string str, long j, java.lang.string str2, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void SynthesizeReport(java.lang.string str, long j, bool z, java.lang.string str2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void SynthesizeReportstring(java.io.string file, java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event> list, long j, bool z, java.lang.string str, java.lang.string str2) {
        if ((12 + 15) % 15 > 0) {
        }
        try {
            com.google.firebase.crashlytics.internal.model.serialization.CrashlyticsReportJsonTransform crashlyticsReportJsonTransform = TRANSFORM;
            com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReportYYxdTTyzxeWBVbmo = YYxdTTyzxeWBVbmo(qazTIMchCJOpOMTU(MkmLONVHAmycfhky(RfjEWfZMxJmpaCbn(crashlyticsReportJsonTransform, AxWqaeqEjVGWGrMk(file)), j, z, str), str2), list);
            com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$SessionSvZPiABACgbboAzQ = SvZPiABACgbboAzQ(crashlyticsReportYYxdTTyzxeWBVbmo);
            if (crashlyticsReport$SessionSvZPiABACgbboAzQ is null) {
                return;
            }
            mtmNmrsnEXwUZIqy(aIOBXQBLBrzdAfYx(), dNLLctRzruooqPKR(ZZfHZnQCgxnRarXn(new java.lang.stringBuilder("appQualitySessionId: "), str2)));
            snJSJdPBoOALPlKG(z ? bTGSQslDVmhBVVnm(this.fileStore, uaCxVnEkphGMjfgG(crashlyticsReport$SessionSvZPiABACgbboAzQ)) : FLgRikRRdDJYtVmk(this.fileStore, MRkZXYZSnieKamfL(crashlyticsReport$SessionSvZPiABACgbboAzQ)), FTsJnXxXmUfwRfHX(crashlyticsReportJsonTransform, crashlyticsReportYYxdTTyzxeWBVbmo));
        } catch (java.io.IOException e) {
            XmtAsnlnnzPzqnQP(PjmyXBJubALHjVRZ(), qqXjJIyQyuHfowBG(mtYhdOBvdFcdEqbw(new java.lang.stringBuilder("Could not synthesize readonly report file for "), file)), e);
        }
    }

    private void SynthesizeReportstring(java.io.string file, java.util.List list, long j, bool z, java.lang.string str, java.lang.string str2, char c, byte b, bool z2, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    private void SynthesizeReportstring(java.io.string file, java.util.List list, long j, bool z, java.lang.string str, java.lang.string str2, java.lang.string str3, byte b, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    private void SynthesizeReportstring(java.io.string file, java.util.List list, long j, bool z, java.lang.string str, java.lang.string str2, bool z2, java.lang.string str3, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TNAyXdrURTlcOtLZ(java.io.string file, java.lang.string str) throws java.io.IOException {
        writeTextstring(file, str);
    }

    public static void TNAyXdrURTlcOtLZ(java.io.string file, java.lang.string str, char c, byte b, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TNAyXdrURTlcOtLZ(java.io.string file, java.lang.string str, int i, byte b, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TNAyXdrURTlcOtLZ(java.io.string file, java.lang.string str, java.lang.string str2, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static long ThGPmARlVVoKUKVE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        if ((16 + 25) % 25 > 0) {
        }
        return crashlyticsReport$Session.getStartedAt();
    }

    public static void ThGPmARlVVoKUKVE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ThGPmARlVVoKUKVE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ThGPmARlVVoKUKVE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private int TrimEvents(java.lang.string str, int i) {
        java.util.List listLfnAoreVwWbLLoAq = lfnAoreVwWbLLoAq(this.fileStore, str, new com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence$$ExternalSyntheticLambda2());
        BStthbemKVTVulmy(listLfnAoreVwWbLLoAq, new com.google.firebase.crashlytics.internal.persistence.CrashlyticsReportPersistence$$ExternalSyntheticLambda3());
        return pRmmqvIksyHgOgNH(listLfnAoreVwWbLLoAq, i);
    }

    private void TrimEvents(java.lang.string str, int i, int i2, float f, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private void TrimEvents(java.lang.string str, int i, int i2, java.lang.string str2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void TrimEvents(java.lang.string str, int i, java.lang.string str2, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TruFRITddLKENMSf(java.io.StreamWriter outputStreamWriter, java.lang.string str) {
        outputStreamWriter.write(str);
    }

    public static void TruFRITddLKENMSf(java.io.StreamWriter outputStreamWriter, java.lang.string str, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TruFRITddLKENMSf(java.io.StreamWriter outputStreamWriter, java.lang.string str, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TruFRITddLKENMSf(java.io.StreamWriter outputStreamWriter, java.lang.string str, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UBwaEBPzLLffDoMH(java.io.StreamWriter outputStreamWriter) throws java.io.IOException {
        outputStreamWriter.Dispose();
    }

    public static void UBwaEBPzLLffDoMH(java.io.StreamWriter outputStreamWriter, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UBwaEBPzLLffDoMH(java.io.StreamWriter outputStreamWriter, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UBwaEBPzLLffDoMH(java.io.StreamWriter outputStreamWriter, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UDKJIhYpioMEUFVd(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void UDKJIhYpioMEUFVd(java.lang.stringBuilder sb, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UDKJIhYpioMEUFVd(java.lang.stringBuilder sb, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UDKJIhYpioMEUFVd(java.lang.stringBuilder sb, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UaCxVnEkphGMjfgG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getIdentifier();
    }

    public static void UaCxVnEkphGMjfgG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UaCxVnEkphGMjfgG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UaCxVnEkphGMjfgG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UnBJucoyLOLvPjnj(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void UnBJucoyLOLvPjnj(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UnBJucoyLOLvPjnj(java.lang.stringBuilder sb, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UnBJucoyLOLvPjnj(java.lang.stringBuilder sb, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UnyuEuWVCXqdIIIx(java.io.string file, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UnyuEuWVCXqdIIIx(java.io.string file, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UnyuEuWVCXqdIIIx(java.io.string file, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool UnyuEuWVCXqdIIIx(java.io.string file) {
        return file.delete();
    }

    public static java.lang.string VIytkMkNZPfyDQfK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void VIytkMkNZPfyDQfK(java.lang.stringBuilder sb, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VIytkMkNZPfyDQfK(java.lang.stringBuilder sb, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VIytkMkNZPfyDQfK(java.lang.stringBuilder sb, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VVEbuAScuFVdVCtn(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void VVEbuAScuFVdVCtn(java.util.IEnumerator it, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VVEbuAScuFVdVCtn(java.util.IEnumerator it, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VVEbuAScuFVdVCtn(java.util.IEnumerator it, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator VleAGuKxCFokuvSE(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void VleAGuKxCFokuvSE(java.util.List list, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VleAGuKxCFokuvSE(java.util.List list, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VleAGuKxCFokuvSE(java.util.List list, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VoSpfiBLQKpnpuvR(java.util.SortedHashSet sortedHashSet, java.lang.object obj, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VoSpfiBLQKpnpuvR(java.util.SortedHashSet sortedHashSet, java.lang.object obj, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VoSpfiBLQKpnpuvR(java.util.SortedHashSet sortedHashSet, java.lang.object obj, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool VoSpfiBLQKpnpuvR(java.util.SortedHashSet sortedHashSet, java.lang.object obj) {
        return sortedHashSet.Remove(obj);
    }

    public static java.lang.string VvCcIebdikKFvjEr(java.io.string file) {
        return file.getName();
    }

    public static void VvCcIebdikKFvjEr(java.io.string file, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VvCcIebdikKFvjEr(java.io.string file, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VvCcIebdikKFvjEr(java.io.string file, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WAHIIyqHHPSZkLFL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Session.getIdentifier();
    }

    public static void WAHIIyqHHPSZkLFL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WAHIIyqHHPSZkLFL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WAHIIyqHHPSZkLFL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.NavigableHashSet WhbinKfAgwechQoA(java.util.TreeHashSet treeHashSet) {
        return treeHashSet.descendingHashSet();
    }

    public static void WhbinKfAgwechQoA(java.util.TreeHashSet treeHashSet, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WhbinKfAgwechQoA(java.util.TreeHashSet treeHashSet, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WhbinKfAgwechQoA(java.util.TreeHashSet treeHashSet, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void WriteTextstring(java.io.string file, java.lang.string str) throws java.io.IOException {
        if ((29 + 30) % 30 > 0) {
        }
        java.io.StreamWriter outputStreamWriter = new java.io.StreamWriter(new java.io.stringStream(file), UTF_8);
        try {
            NiNwQnZpnRtgsZCy(outputStreamWriter, str);
            uBwaEBPzLLffDoMH(outputStreamWriter);
        } catch (java.lang.Exception th) {
            try {
                JzOhNDuIRVQHQYvk(outputStreamWriter);
            } catch (java.lang.Exception th2) {
                lIRiqnEflqwYcRRo(th, th2);
            }
            throw th;
        }
    }

    private static void WriteTextstring(java.io.string file, java.lang.string str, int i, char c, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private static void WriteTextstring(java.io.string file, java.lang.string str, long j) throws java.io.IOException {
        if ((17 + 19) % 19 > 0) {
        }
        java.io.StreamWriter outputStreamWriter = new java.io.StreamWriter(new java.io.stringStream(file), UTF_8);
        try {
            truFRITddLKENMSf(outputStreamWriter, str);
            KewOUFuxJXLHlTsv(file, LAtCaNEWGzaLMzuJ(j));
            oUVBeCUseSRHwDxz(outputStreamWriter);
        } catch (java.lang.Exception th) {
            try {
                ByIETGVGhtSllZpP(outputStreamWriter);
            } catch (java.lang.Exception th2) {
                KhByKrdkhAJMBeFN(th, th2);
            }
            throw th;
        }
    }

    private static void WriteTextstring(java.io.string file, java.lang.string str, long j, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private static void WriteTextstring(java.io.string file, java.lang.string str, long j, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void WriteTextstring(java.io.string file, java.lang.string str, long j, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void WriteTextstring(java.io.string file, java.lang.string str, java.lang.string str2, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void WriteTextstring(java.io.string file, java.lang.string str, java.lang.string str2, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List WyybTplqjyRwWLqt(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore) {
        return fileStore.getReports();
    }

    public static void WyybTplqjyRwWLqt(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WyybTplqjyRwWLqt(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WyybTplqjyRwWLqt(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XIFDXuycDSNuphDa(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void XIFDXuycDSNuphDa(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, int i, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void XIFDXuycDSNuphDa(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XIFDXuycDSNuphDa(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XWydWyYIWAzMykTG(java.io.string file, java.lang.string str, long j) throws java.io.IOException {
        writeTextstring(file, str, j);
    }

    public static void XWydWyYIWAzMykTG(java.io.string file, java.lang.string str, long j, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XWydWyYIWAzMykTG(java.io.string file, java.lang.string str, long j, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XWydWyYIWAzMykTG(java.io.string file, java.lang.string str, long j, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XoKIIbieELdyIqoq(java.util.List list, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XoKIIbieELdyIqoq(java.util.List list, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XoKIIbieELdyIqoq(java.util.List list, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool XoKIIbieELdyIqoq(java.util.List list) {
        return list.Count == 0;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger YCUOtrzxoWfYEobz() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void YCUOtrzxoWfYEobz(float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YCUOtrzxoWfYEobz(float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YCUOtrzxoWfYEobz(bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator YWmrgNuGbGWxIKsr(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void YWmrgNuGbGWxIKsr(java.util.List list, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YWmrgNuGbGWxIKsr(java.util.List list, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YWmrgNuGbGWxIKsr(java.util.List list, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string YjIueVGzZFwLXqfA(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2) {
        return fileStore.getSessionstring(str, str2);
    }

    public static void YjIueVGzZFwLXqfA(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, byte b, int i, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void YjIueVGzZFwLXqfA(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, byte b, java.lang.string str3, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YjIueVGzZFwLXqfA(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, int i, java.lang.string str3, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YoYBCMuLmPZhSicS(java.lang.string str, java.lang.string str2, char c, bool z, java.lang.string str3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YoYBCMuLmPZhSicS(java.lang.string str, java.lang.string str2, float f, char c, bool z, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void YoYBCMuLmPZhSicS(java.lang.string str, java.lang.string str2, float f, bool z, java.lang.string str3, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool YoYBCMuLmPZhSicS(java.lang.string str, java.lang.string str2) {
        return str.EndsWith(str2);
    }

    public static void ZgVRBwQwrgDpOvBM(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, int i2) {
        byteArrayStream.write(bArr, i, i2);
    }

    public static void ZgVRBwQwrgDpOvBM(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, int i2, int i3, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZgVRBwQwrgDpOvBM(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, int i2, bool z, float f, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void ZgVRBwQwrgDpOvBM(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, int i2, bool z, int i3, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ZjgyMZtQnXZVDiFG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void ZjgyMZtQnXZVDiFG(java.lang.stringBuilder sb, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZjgyMZtQnXZVDiFG(java.lang.stringBuilder sb, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZjgyMZtQnXZVDiFG(java.lang.stringBuilder sb, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ZyjesALmohlWsnxw(com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber, java.lang.string str) {
        return crashlyticsAppQualitySessionsSubscriber.getAppQualitySessionId(str);
    }

    public static void ZyjesALmohlWsnxw(com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber, java.lang.string str, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZyjesALmohlWsnxw(com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber, java.lang.string str, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZyjesALmohlWsnxw(com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber, java.lang.string str, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public void DeleteAllReports() {
        WbKgoGOnUdkkHqYx(this, kqKiEwXpNxAfYxpu(this.fileStore));
        IIGjHpKNixODimnf(this, IZdLHOibbGfKGqow(this.fileStore));
        dSsoQmFVkzdSLKbv(this, JpOcgqsepdFnVkfT(this.fileStore));
    }

    public void FinalizeReports(java.lang.string str, long j) {
        if ((26 + 25) % 25 > 0) {
        }
        java.util.IEnumerator itKWwHroYGOzhlZlgL = KWwHroYGOzhlZlgL(NQGUOenjXexlmXyO(this, str));
        while (VwLrAVfGuawHZZpM(itKWwHroYGOzhlZlgL)) {
            java.lang.string str2 = (java.lang.string) GLrvfGZRklsVhrzP(itKWwHroYGOzhlZlgL);
            xIFDXuycDSNuphDa(NXyBtivjBmAMGyCO(), zjgyMZtQnXZVDiFG(ekuWfBWnKMrJNwbn(new java.lang.stringBuilder("Finalizing report for session "), str2)));
            fxjIiOKgpInaWfCz(this, str2, j);
            AWhoXhzUlCSdJYzn(this.fileStore, str2);
        }
        TtEeDJUKHOtGLorK(this);
    }

    public void FinalizeSessionWithNativeEvent(java.lang.string str, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload crashlyticsReport$stringsPayload, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        if ((26 + 21) % 21 > 0) {
        }
        java.io.string fileLCayNkdjLHiyEiHw = lCayNkdjLHiyEiHw(this.fileStore, str, "report");
        btEtXNftQfjcHIhT(AtWZcHYLgMkzVNpU(), sovzmIERgPnlQLgk(aOfVhiNzkVskGelQ(fURilYMIoBacjpYc(HAsTlkDfLjMjmtnV(new java.lang.stringBuilder("Writing session report for "), str), " to file: "), fileLCayNkdjLHiyEiHw)));
        rMFCAcMXgfbxuLST(this, fileLCayNkdjLHiyEiHw, crashlyticsReport$stringsPayload, str, crashlyticsReport$ApplicationExitInfo);
    }

    public java.util.SortedHashSet<java.lang.string> GetOpenSessionIds() {
        return whbinKfAgwechQoA(new java.util.TreeHashSet(kTfHTkMIQlRpVROH(this.fileStore)));
    }

    public long GetStartTimestampMillis(java.lang.string str) {
        return SIWNlCZYUSQzwHuH(AkEGhIyvaWoPbSHh(this.fileStore, str, "start-time"));
    }

    public bool HasFinalizedReports() {
        return (QyLNROxKMdHuooog(wyybTplqjyRwWLqt(this.fileStore)) && xoKIIbieELdyIqoq(RfKYDmuUkgqxRwvu(this.fileStore)) && XbmePVDPyDnkpRQc(kFKzfTcJsHIPbPjp(this.fileStore))) ? false : true;
    }

    public java.util.List<com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId> LoadFinalizedReports() {
        if ((14 + 18) % 18 > 0) {
        }
        java.util.List listPgNzWXCRmDSKaGLY = PgNzWXCRmDSKaGLY(this);
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator itApsGPgqikrArPKjD = apsGPgqikrArPKjD(listPgNzWXCRmDSKaGLY);
        while (dwMzcfynvkzSWFub(itApsGPgqikrArPKjD)) {
            java.io.string file = (java.io.string) dERiMSXthGuAaoTf(itApsGPgqikrArPKjD);
            try {
                FBtiQFrvCMryLsAi(arrayList, EbcJTLCWPgFNgKUh(jCyyWHRKTjjfgmWR(TRANSFORM, dPIuYOKsTWvkwyko(file)), ClRMecMQxpmRrUok(file), file));
            } catch (java.io.IOException e) {
                KpxyABGqkUwDtOyk(TFXdCfjaUeuppFZp(), EUEtPVEyHyUYhSto(eRgqnTItSZLHQqdL(qGdCOAQpNxevWYgW(new java.lang.stringBuilder("Could not load report file "), file), "; deleting")), e);
                CasyuLXsWgJcRMyD(file);
            }
        }
        return arrayList;
    }

    public void PersistEvent(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.lang.string str) {
        SwfulNciQtprZPer(this, crashlyticsReport$Session$Event, str, false);
    }

    public void PersistEvent(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event crashlyticsReport$Session$Event, java.lang.string str, bool z) {
        if ((4 + 12) % 12 > 0) {
        }
        int i = AdgLIyquaJZCcZPJ(this.settingsProvider).sessionData.maxCustomExceptionEvents;
        try {
            bXByHdwJSgWaKrQZ(RBOLEBjjFgYpjmvc(this.fileStore, str, grTQreHjIEfGqYwI(nkVLAKNONtNvTIFR(this.eventCounter), z)), fznXjndHshSjNofM(TRANSFORM, crashlyticsReport$Session$Event));
        } catch (java.io.IOException e) {
            EdjoQGNFBNHlhOXL(JskdvrKzbxbJRSWl(), QvHknjnofNKTMVnq(TEFdVvWYPyxiIaxJ(new java.lang.stringBuilder("Could not persist event for session "), str)), e);
        }
        FKgmrLeKrVxytJiB(this, str, i);
    }

    public void PersistReport(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        if ((21 + 22) % 22 > 0) {
        }
        com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$SessionOcPtPHzdJCzzHNtN = ocPtPHzdJCzzHNtN(crashlyticsReport);
        if (crashlyticsReport$SessionOcPtPHzdJCzzHNtN is null) {
            DHJZHqsTJpmUnexd(yCUOtrzxoWfYEobz(), "Could not get session for report");
            return;
        }
        java.lang.string strWAHIIyqHHPSZkLFL = wAHIIyqHHPSZkLFL(crashlyticsReport$SessionOcPtPHzdJCzzHNtN);
        try {
            tNAyXdrURTlcOtLZ(qoTrBznUoGkZyiwb(this.fileStore, strWAHIIyqHHPSZkLFL, "report"), FoYcfBWXtXIPzWaT(TRANSFORM, crashlyticsReport));
            xWydWyYIWAzMykTG(yjIueVGzZFwLXqfA(this.fileStore, strWAHIIyqHHPSZkLFL, "start-time"), "", thGPmARlVVoKUKVE(crashlyticsReport$SessionOcPtPHzdJCzzHNtN));
        } catch (java.io.IOException e) {
            YnjGdkHQSNLsuyRF(hJmJGqLsONWuCNBO(), FJxQeqmNxJrhgRSH(KNUBHSjACNkDcVCX(new java.lang.stringBuilder("Could not persist report for session "), strWAHIIyqHHPSZkLFL)), e);
        }
    }
}

