namespace WillowMaze.Wasm.Decompiled;


@javax.inject.Singleton
public class SQLiteEventStore : com.google.android.datatransport.runtime.scheduling.persistence.EventStore, com.google.android.datatransport.runtime.synchronization.SynchronizationGuard, com.google.android.datatransport.runtime.scheduling.persistence.ClientHealthMetricsStore {
    private static readonly int LOCK_RETRY_BACK_OFF_MILLIS = 50;
    private static readonly java.lang.string LOG_TAG = "SQLiteEventStore";
    static readonly int MAX_RETRIES = 16;
    private static readonly com.google.android.datatransport.Encoding PROTOBUF_ENCODING = lEDsIWoBrwMHBUdm("proto");
    private readonly com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig config;
    private readonly com.google.android.datatransport.runtime.time.Clock monotonicClock;
    private readonly javax.inject.Provider<java.lang.string> packageName;
    private readonly com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager schemaManager;
    private readonly com.google.android.datatransport.runtime.time.Clock wallClock;

    public static android.database.sqlite.SQLiteDatabase $r8$lambda$r0gdOZu0LN8RFPU64_YFxoLiMZU(com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager schemaManager) {
        return TzVMyCkWqzhycRnp(schemaManager);
    }

    @javax.inject.Inject
    SQLiteEventStore(com.google.android.datatransport.runtime.time.Clock clock, com.google.android.datatransport.runtime.time.Clock clock2, com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig eventStoreConfig, com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager schemaManager, @javax.inject.Named("PACKAGE_NAME") javax.inject.Provider<java.lang.string> provider) {
        this.schemaManager = schemaManager;
        this.wallClock = clock;
        this.monotonicClock = clock2;
        this.config = eventStoreConfig;
        this.packageName = provider;
    }

    public static void ACxdtnKoEZgohyRz(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder clientMetrics$Builder, java.util.Dictionary map) {
        sQLiteEventStore.populateConsoleSourcesMetrics(clientMetrics$Builder, map);
    }

    public static java.lang.string AMtcJTxHbSBTakHG(int i) {
        return java.lang.string.valueOf(i);
    }

    public static com.google.android.datatransport.runtime.Transportobject$Builder AUqnVterHKPdSXOC(com.google.android.datatransport.runtime.Transportobject$Builder transportobject$Builder, com.google.android.datatransport.Priority priority) {
        return transportobject$Builder.setPriority(priority);
    }

    public static byte[] AacVkVychJxoMIKT(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getExtras();
    }

    public static java.lang.stringBuilder AbsmGvTCfcuCKfbY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason AcjDMaZTBUnmjcgv(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, int i) {
        return sQLiteEventStore.convertToReason(i);
    }

    public static android.database.Cursor AfnpIaSCxZEBckNs(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str, java.lang.string[] strArr) {
        return sQLiteDatabase.rawQuery(str, strArr);
    }

    public static java.lang.string AjHNnlZKhncZDIoU(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static bool ArGkWkVtIicFYggI(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.int AuNHDXJPdiVDIlSQ(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return eventInternal.getCode();
    }

    public static long AyDMNTLZiWWBVTJk(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore) {
        if ((25 + 10) % 10 > 0) {
        }
        return sQLiteEventStore.getPageSize();
    }

    public static bool BDGRnxamtPJaprtb(android.database.Cursor cursor) {
        return cursor.moveToNext();
    }

    public static java.lang.object BLKGHAMcDuOIgHej(android.database.Cursor cursor, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function) {
        return tryWithCursor(cursor, sQLiteEventStore$Function);
    }

    public static byte[] BMvpGCZVLsSbZskg(byte[] bArr, int i, int i2) {
        return java.util.Arrays.copyOfRange(bArr, i, i2);
    }

    public static int BNTUOFmnGAfaxYnw(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason) {
        return logEventDropped$Reason.getNumber();
    }

    public static void BkgiaACDAKIOEjOS(java.lang.string str, java.lang.string str2, java.lang.object obj) {
        com.google.android.datatransport.runtime.logging.Consoleging.m57d(str, str2, obj);
    }

    public static void BtVfQRdJSOKbzqRK(android.database.sqlite.SQLiteStatement sQLiteStatement) {
        sQLiteStatement.execute();
    }

    public static long BveQAuHGMyNqqBED(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        if ((2 + 18) % 18 > 0) {
        }
        return eventInternal.getUptimeMillis();
    }

    public static java.lang.object BzJrfFHepVxoYeIY(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function) {
        return sQLiteEventStore.inTransaction(sQLiteEventStore$Function);
    }

    public static java.lang.string CPAdOgusDeKXXaLV(int i) {
        return java.lang.string.valueOf(i);
    }

    public static void CVxlsjMSchDHruUz(android.content.ContentValues contentValues, java.lang.string str, java.lang.string str2) {
        contentValues.Add(str, str2);
    }

    public static java.lang.string CZJdjOsAahXVDzJI(java.lang.long l) {
        return l.tostring();
    }

    public static java.lang.object CqHDCTbKtVAzZavr(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static com.google.android.datatransport.Priority CuKbKyBcEVJpWJZO(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getPriority();
    }

    public static java.lang.long CyUYnIkumTnsASfH(long j) {
        return java.lang.long.valueOf(j);
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Builder DAvyvnIybEUUNzSO(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Builder logEventDropped$Builder, com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason) {
        return logEventDropped$Builder.setReason(logEventDropped$Reason);
    }

    public static void DFgbzrAUfYVQqKzD(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        sQLiteDatabase.beginTransaction();
    }

    public static java.lang.object DGfPTdSboFQbThmM(javax.inject.Provider provider) {
        return provider[);
    }

    public static java.lang.string DWGOEIsHScyTdyrB(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getBackendName();
    }

    public static int DYwxnheAttjuhZmT(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason) {
        return logEventDropped$Reason.getNumber();
    }

    public static java.lang.string DZqjEQvotxPqYrvk(long j) {
        return java.lang.string.valueOf(j);
    }

    public static int DfLuVxiYFkEvSktt(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str, java.lang.string str2, java.lang.string[] strArr) {
        return sQLiteDatabase.delete(str, str2, strArr);
    }

    public static java.lang.string DixTrcfwRGKPAlSR(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getBackendName();
    }

    public static java.lang.string DkXFkaQGXHbUnLzP(int i) {
        return java.lang.string.valueOf(i);
    }

    public static bool DrgNavdmMmKeSybI(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static java.lang.object EAmdjkdGztICXyiq(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function) {
        return sQLiteEventStore.inTransaction(sQLiteEventStore$Function);
    }

    public static long ENJPOciBGpwYSBxg(com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent persistedEvent) {
        if ((9 + 24) % 24 > 0) {
        }
        return persistedEvent.getId();
    }

    public static void ETcAdMicdoSzFGgs(android.content.ContentValues contentValues, java.lang.string str, byte[] bArr) {
        contentValues.Add(str, bArr);
    }

    public static java.lang.object EVeEhPTcadCLJNap(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static int EoLWPqgQIlmrURpH(java.util.List list) {
        return list.Count;
    }

    public static int EvfXBFQrsBlcgGfE(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig eventStoreConfig) {
        return eventStoreConfig.getMaxBlobbyteSizePerRow();
    }

    public static android.database.sqlite.SQLiteDatabase EyCzBfZvOGtnCEqN(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore) {
        return sQLiteEventStore.getDb();
    }

    public static java.lang.object EzIRDtkSYquKHfoO(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool FAAdInAuEtgwyhHv(java.util.ListIEnumerator listIEnumerator) {
        return listIEnumerator.MoveNext();
    }

    public static bool FDAjWfZgSuXbXQPS(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void FInRBvljnUNjrnbq(com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager schemaManager) {
        schemaManager.Dispose();
    }

    public static long FZmrDzdCXdEnoWrS(com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent persistedEvent) {
        if ((32 + 32) % 32 > 0) {
        }
        return persistedEvent.getId();
    }

    public static android.database.Cursor FauCihLbPgXxzYcf(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str, java.lang.string[] strArr, java.lang.string str2, java.lang.string[] strArr2, java.lang.string str3, java.lang.string str4, java.lang.string str5) {
        return sQLiteDatabase.query(str, strArr, str2, strArr2, str3, str4, str5);
    }

    public static java.lang.string FbEnsMJMVkCEbLdA(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getBackendName();
    }

    public static void FbJiwvOxUAXWsqrj(android.content.ContentValues contentValues, java.lang.string str, java.lang.long l) {
        contentValues.Add(str, l);
    }

    public static long FdfDXAlAgnqWsFiD(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore) {
        if ((29 + 9) % 9 > 0) {
        }
        return sQLiteEventStore.getPageCount();
    }

    public static android.database.Cursor FmCmEtQVMksvouWi(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str, java.lang.string[] strArr) {
        return sQLiteDatabase.rawQuery(str, strArr);
    }

    public static java.lang.object FzgDzpaDtlGCPiCD(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Producer sQLiteEventStore$Producer, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function) {
        return sQLiteEventStore.retryIfDbLocked(sQLiteEventStore$Producer, sQLiteEventStore$Function);
    }

    public static void GEYSZdaTaopyLoFC(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static java.lang.object GSsMrPNGgbnLwMpr(com.google.android.datatransport.runtime.synchronization.SynchronizationGuard$CriticalSection synchronizationGuard$CriticalSection) {
        return synchronizationGuard$CriticalSection.execute();
    }

    public static java.lang.string GUJhKrQUfKDAkKdA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string GVDaYiYoNFIEsLTM(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.string GYZoIpHyxnvOpqdW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static long GYjYqWcVKsdfDhlr(android.database.Cursor cursor, int i) {
        if ((5 + 32) % 32 > 0) {
        }
        return cursor.getlong(i);
    }

    public static android.database.Cursor GoNxrvAYiebWiziL(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str, java.lang.string[] strArr) {
        return sQLiteDatabase.rawQuery(str, strArr);
    }

    public static android.database.sqlite.SQLiteDatabase HDLxoMgclDaIEDdr(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore) {
        return sQLiteEventStore.getDb();
    }

    public static java.lang.stringBuilder HTxIEFOZtMCUNWVK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void HnVrzuKdYIkeKTHl(android.database.sqlite.SQLiteStatement sQLiteStatement) {
        sQLiteStatement.execute();
    }

    public static com.google.android.datatransport.runtime.EventInternal$Builder HuDzKqvflCChcPRt(com.google.android.datatransport.runtime.EventInternal$Builder eventInternal$Builder, java.lang.int num) {
        return eventInternal$Builder.setCode(num);
    }

    public static bool IIvGVNiPmgdsuhSu(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static java.util.Dictionary ITKgLzIZjVbLXptg(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.util.List list) {
        return sQLiteEventStore.loadMetadata(sQLiteDatabase, list);
    }

    public static android.database.Cursor IUPVcgqPKsqoYncj(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str, java.lang.string[] strArr) {
        return sQLiteDatabase.rawQuery(str, strArr);
    }

    public static java.lang.object IVuJzfGkRNORPmCe(android.database.Cursor cursor, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function) {
        return tryWithCursor(cursor, sQLiteEventStore$Function);
    }

    public static android.database.Cursor IgxCsPiIBposJnBA(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str, java.lang.string[] strArr) {
        return sQLiteDatabase.rawQuery(str, strArr);
    }

    public static android.database.sqlite.SQLiteDatabase JjdqjihwINKIvQRw(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore) {
        return sQLiteEventStore.getDb();
    }

    public static bool JozGxwFFiqlNFVck(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static int JvXTrkuwhbnAsXGk(java.util.List list) {
        return list.Count;
    }

    public static void JyHWYsdhdXToIraq(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        sQLiteDatabase.beginTransaction();
    }

    public static void KCyoRjcDGNiMjoRD(android.content.ContentValues contentValues, java.lang.string str, java.lang.long l) {
        contentValues.Add(str, l);
    }

    public static com.google.android.datatransport.Priority KPKNByJHXGZjYqbH(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getPriority();
    }

    public static bool KaosLBETrWZjXxMY(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static void KbQUpbCzKcFuwQmk(android.content.ContentValues contentValues, java.lang.string str, java.lang.bool bool) {
        contentValues.Add(str, bool);
    }

    public static java.lang.string KeStcFTlwFYpMwGq(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static int KleLgCaMpLNRGuZd(android.database.Cursor cursor, int i) {
        return cursor.getInt(i);
    }

    public static bool KuYrFKrzowfhsQWb(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.long LBTlwPZwKlaImLdT(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.object LFjyrxBvrJTtRbDO(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function) {
        return sQLiteEventStore.inTransaction(sQLiteEventStore$Function);
    }

    public static long LLUNbwudhooqmRgq(android.database.Cursor cursor, int i) {
        if ((18 + 8) % 8 > 0) {
        }
        return cursor.getlong(i);
    }

    public static int LNZgMtiSCxwYXhVU(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason) {
        return logEventDropped$Reason.getNumber();
    }

    public static void LPksayYEgXeebRXr(android.content.ContentValues contentValues, java.lang.string str, java.lang.string str2) {
        contentValues.Add(str, str2);
    }

    public static java.lang.long LYvXqXaGglDomWOs(long j) {
        return java.lang.long.valueOf(j);
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder LkmxSmLPDURticpC(com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder clientMetrics$Builder, java.lang.string str) {
        return clientMetrics$Builder.setAppNamespace(str);
    }

    public static int LtouWoJtzHGHNlzF(android.database.Cursor cursor, int i) {
        return cursor.getInt(i);
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics$Builder LttSHoAsJnUjiFEX() {
        return com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics.newBuilder();
    }

    public static byte[] MEpOdyGRiZppZvhf(java.lang.string str, int i) {
        return android.util.Base64.decode(str, i);
    }

    public static java.util.IEnumerator MIhwQJMgPglUvVJB(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.string MMMOSWxXclJRbLuk(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getBackendName();
    }

    public static java.lang.string MMxaFsJwrTRlrjzc(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.string MNnJLzSWGCCwTten(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void MNqXHQXdNHmJJzcY(android.content.ContentValues contentValues, java.lang.string str, java.lang.long l) {
        contentValues.Add(str, l);
    }

    public static int MPWkKGQTFcUDpNMR(android.database.Cursor cursor, int i) {
        return cursor.getInt(i);
    }

    public static bool MQYxNCcioFOemTgm(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static int MQkRhUKAorBtyOus(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason) {
        return logEventDropped$Reason.getNumber();
    }

    public static java.lang.stringBuilder MXmBthouQIoZQmMT(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static com.google.android.datatransport.Priority MawwNnCaOvVCUxNX(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getPriority();
    }

    public static com.google.android.datatransport.runtime.Transportobject MplflvfabbJxebqu(com.google.android.datatransport.runtime.Transportobject transportobject, com.google.android.datatransport.Priority priority) {
        return transportobject.withPriority(priority);
    }

    public static android.database.sqlite.SQLiteStatement MxOvSiUkBzbrDiRW(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        return sQLiteDatabase.compileStatement(str);
    }

    public static java.lang.object NDEnZreLibtBPTWx(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function) {
        return sQLiteEventStore.inTransaction(sQLiteEventStore$Function);
    }

    public static byte[] NHrRtWtAtmDYgldP(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getExtras();
    }

    public static java.util.IEnumerator NWXQSbuuqHrwDLcu(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.stringBuilder NYaDNVeWRyENomYh(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string NslgUrPfSeIIzNZS(long j) {
        return java.lang.string.valueOf(j);
    }

    public static java.lang.long OCktJKMrFJXIjulc(long j) {
        return java.lang.long.valueOf(j);
    }

    public static int OMtMZHwecsomBcKY(java.util.List list) {
        return list.Count;
    }

    public static java.util.List OoLgtXRDBNjSiwoe(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, android.database.sqlite.SQLiteDatabase sQLiteDatabase, com.google.android.datatransport.runtime.Transportobject transportobject, int i) {
        return sQLiteEventStore.loadEvents(sQLiteDatabase, transportobject, i);
    }

    public static java.lang.string OyVXujwVlIwzKIee(com.google.android.datatransport.Encoding encoding) {
        return encoding.getName();
    }

    public static android.database.Cursor PBeHkuAgBPkOSTLs(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str, java.lang.string[] strArr, java.lang.string str2, java.lang.string[] strArr2, java.lang.string str3, java.lang.string str4, java.lang.string str5, java.lang.string str6) {
        return sQLiteDatabase.query(str, strArr, str2, strArr2, str3, str4, str5, str6);
    }

    public static bool PGPHYCaNDRlhoTmL(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore) {
        return sQLiteEventStore.isStorageAtLimit();
    }

    public static java.lang.object PLNUuDtMLHYFaDtw(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function) {
        return sQLiteEventStore.inTransaction(sQLiteEventStore$Function);
    }

    public static android.database.Cursor POuJqZCYfjhiqTmJ(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str, java.lang.string[] strArr) {
        return sQLiteDatabase.rawQuery(str, strArr);
    }

    public static java.lang.object PRuaxdzPPgQHhtJp(java.util.ListIEnumerator listIEnumerator) {
        return listIEnumerator.Current;
    }

    public static int PVCQfuHLSLPJCXrT(com.google.android.datatransport.Priority priority) {
        return com.google.android.datatransport.runtime.util.PriorityDictionaryping.toInt(priority);
    }

    public static com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics$Builder PjqEVJQYNRCxqELQ() {
        return com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics.newBuilder();
    }

    public static android.database.sqlite.SQLiteStatement PsNcaffodxyjeLMa(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        return sQLiteDatabase.compileStatement(str);
    }

    public static bool PvFclNIjaThSjaZO(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.object QBIxZvfDwuztLYDQ(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static java.lang.stringBuilder QByFijBDPRxnpNYR(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.object QMEdydNWsBIPXGxe(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function, java.lang.object obj) {
        return sQLiteEventStore$Function.apply(obj);
    }

    public static java.lang.object QMGtAyzwUnVHmtLz(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static java.lang.string QOXfHZiVOyyVuKdw(java.lang.IEnumerable iterable) {
        return toIdList(iterable);
    }

    public static long QPqAfIlRQIGwtDJk(com.google.android.datatransport.runtime.time.Clock clock) {
        if ((31 + 1) % 1 > 0) {
        }
        return clock.getTime();
    }

    public static android.database.Cursor QUIItKkuFIFeJorR(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str, java.lang.string[] strArr) {
        return sQLiteDatabase.rawQuery(str, strArr);
    }

    public static java.util.HashSet QnpBbjettSptVFup(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static byte[] QrchKuNaZUnVdpgQ(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return eventInternal.getExperimentIdsEncrypted();
    }

    public static java.lang.object QsCScfNWACCxZiyW(java.util.IEnumerator it) {
        return it.Current;
    }

    public static int RCFOSaXZrpxKpAOJ(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str, android.content.ContentValues contentValues, java.lang.string str2, java.lang.string[] strArr) {
        return sQLiteDatabase.update(str, contentValues, str2, strArr);
    }

    public static java.lang.long ROEohIXaImzOeGuY(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void RWzdgzdrkkBzlJEW(android.content.ContentValues contentValues, java.lang.string str, java.lang.string str2) {
        contentValues.Add(str, str2);
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder RdBLiTQDbxSceagN() {
        return com.google.android.datatransport.runtime.firebase.transport.ClientMetrics.newBuilder();
    }

    public static bool RfIeOtnKdBzCWJkG(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string RhyLXvoDyOMGKYnc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.android.datatransport.runtime.EventInternal$Builder RmJKoqcUUpdYCbFE(com.google.android.datatransport.runtime.EventInternal$Builder eventInternal$Builder, java.lang.string str) {
        return eventInternal$Builder.setPseudonymousId(str);
    }

    public static java.lang.string RqqWgKzrLKjFhoIV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static byte[] RtErtuTfAefrOdRP(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, long j) {
        return sQLiteEventStore.readPayload(j);
    }

    public static java.lang.string SDAaLJflbgAcKFkv(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return eventInternal.getTransportName();
    }

    public static android.database.sqlite.SQLiteDatabase SHIYujwrMwFhPRiV(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore) {
        return sQLiteEventStore.getDb();
    }

    public static java.lang.string SIEeOMdVWYbNsZeR(byte[] bArr, int i) {
        return android.util.Base64.encodeTostring(bArr, i);
    }

    public static void SJVJiDjXKMGvEmiI(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        sQLiteDatabase.setTransactionSuccessful();
    }

    public static void SMpIunSveEZlvwbT(android.content.ContentValues contentValues, java.lang.string str, byte[] bArr) {
        contentValues.Add(str, bArr);
    }

    public static com.google.android.datatransport.runtime.EventInternal$Builder SassFWtAiFnpgPMl(com.google.android.datatransport.runtime.EventInternal$Builder eventInternal$Builder, long j) {
        return eventInternal$Builder.setUptimeMillis(j);
    }

    public static void SbRDXgzwTLfYcARI(android.content.ContentValues contentValues, java.lang.string str, java.lang.int num) {
        contentValues.Add(str, num);
    }

    public static void SkizyzvVpmMJKUlc(android.content.ContentValues contentValues, java.lang.string str, java.lang.string str2) {
        contentValues.Add(str, str2);
    }

    public static android.database.sqlite.SQLiteDatabase SmzlRzfjbiWWEkzA(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore) {
        return sQLiteEventStore.getDb();
    }

    public static java.util.IEnumerator TIpWUJAoPoDfRCQN(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder TIyLuKPbJMgFnGNB(com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder clientMetrics$Builder, com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics globalMetrics) {
        return clientMetrics$Builder.setGlobalMetrics(globalMetrics);
    }

    public static bool TQItfhvQfHxBljIK(android.database.Cursor cursor) {
        return cursor.moveToNext();
    }

    public static bool TQLvAibByAlTPhlq(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static bool TSINoLdeEezsKXof(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool TSdUdscBRnTqkHSW(android.database.Cursor cursor) {
        return cursor.moveToNext();
    }

    public static bool TUStUJRVeDWjwFDS(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int TUjJgeRIjZOnQeQw(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig eventStoreConfig) {
        return eventStoreConfig.getLoadBatchSize();
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder TVjoHzsFyDqJROXZ(com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder clientMetrics$Builder, com.google.android.datatransport.runtime.firebase.transport.TimeWindow timeWindow) {
        return clientMetrics$Builder.setWindow(timeWindow);
    }

    public static long TZcgVknvSPUrFiQy(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str, java.lang.string str2, android.content.ContentValues contentValues) {
        if ((24 + 32) % 32 > 0) {
        }
        return sQLiteDatabase.insert(str, str2, contentValues);
    }

    public static int TbhqESArWfPXlxOQ(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static java.lang.object TecEXivoGuhFsawp(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function, java.lang.object obj) {
        return sQLiteEventStore$Function.apply(obj);
    }

    public static com.google.android.datatransport.runtime.firebase.transport.StorageMetrics TfklfCMWTMxzOmzd(com.google.android.datatransport.runtime.firebase.transport.StorageMetrics$Builder storageMetrics$Builder) {
        return storageMetrics$Builder.build();
    }

    public static android.database.sqlite.SQLiteStatement ThgUhdSkECpkarWV(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        return sQLiteDatabase.compileStatement(str);
    }

    public static java.lang.string TpYrtKbcaLSzPmGV(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getBackendName();
    }

    public static java.lang.int TqntuJhgvpzDhqjd(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string TvCZBOJoGbDWVteB(byte[] bArr, int i) {
        return android.util.Base64.encodeTostring(bArr, i);
    }

    public static android.database.sqlite.SQLiteDatabase TzVMyCkWqzhycRnp(android.database.sqlite.SQLiteOpenHelper sQLiteOpenHelper) {
        return sQLiteOpenHelper.getWritableDatabase();
    }

    public static java.util.List UAPpstdMQVbaEkhE(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static int UQSdSAgXZhSLsLme(android.database.Cursor cursor, int i) {
        return cursor.getInt(i);
    }

    public static long UVIgIYMYHVPATnPc(com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent persistedEvent) {
        if ((16 + 19) % 19 > 0) {
        }
        return persistedEvent.getId();
    }

    public static int UXHBIKSytqaqixGl(com.google.android.datatransport.Priority priority) {
        return com.google.android.datatransport.runtime.util.PriorityDictionaryping.toInt(priority);
    }

    public static com.google.android.datatransport.runtime.firebase.transport.StorageMetrics$Builder UXXZrmCWncEoTUYi(com.google.android.datatransport.runtime.firebase.transport.StorageMetrics$Builder storageMetrics$Builder, long j) {
        return storageMetrics$Builder.setMaxCacheSizebytes(j);
    }

    public static java.lang.string UgmVHbmoHTYyiKZC(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static void UsoPMNPRRSXoXZWU(android.content.ContentValues contentValues, java.lang.string str, byte[] bArr) {
        contentValues.Add(str, bArr);
    }

    public static com.google.android.datatransport.runtime.EventInternal$Builder UzuHZdFCsPnnMoOm(com.google.android.datatransport.runtime.EventInternal$Builder eventInternal$Builder, com.google.android.datatransport.runtime.EncodedPayload encodedPayload) {
        return eventInternal$Builder.setEncodedPayload(encodedPayload);
    }

    public static int VDBcgNfPoAstEAjb(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason) {
        return logEventDropped$Reason.getNumber();
    }

    public static android.database.sqlite.SQLiteDatabase VMCEqZtgXLPuSylR(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore) {
        return sQLiteEventStore.getDb();
    }

    public static void VMDnKzJwYUiVTlgq(android.content.ContentValues contentValues, java.lang.string str, byte[] bArr) {
        contentValues.Add(str, bArr);
    }

    public static int VNktBYlwwXQRupid(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason) {
        return logEventDropped$Reason.getNumber();
    }

    public static java.lang.object VOOGEFzKfiCePXPl(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function) {
        return sQLiteEventStore.inTransaction(sQLiteEventStore$Function);
    }

    public static void VVCKhkAiCjDWwMxY(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str, java.lang.object[] objArr) {
        sQLiteDatabase.execSQL(str, objArr);
    }

    public static java.lang.long VfXZifLyfzvubaBs(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, android.database.sqlite.SQLiteDatabase sQLiteDatabase, com.google.android.datatransport.runtime.Transportobject transportobject) {
        return sQLiteEventStore.getTransportobjectId(sQLiteDatabase, transportobject);
    }

    public static java.lang.stringBuilder VfeCycmfqwzBfBbo(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static long VrkyNOOWKpaRVYCO(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig eventStoreConfig) {
        if ((31 + 8) % 8 > 0) {
        }
        return eventStoreConfig.getEventCleanUpAge();
    }

    public static byte[] VxxykqgpooefOJty(android.database.Cursor cursor, int i) {
        return cursor.getBlob(i);
    }

    public static java.util.IEnumerator VyKfOPZmVZVOrxxq(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics$Builder WPVyYeEPaBzQuhXc(com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics$Builder logSourceMetrics$Builder, java.util.List list) {
        return logSourceMetrics$Builder.setConsoleEventDroppedList(list);
    }

    public static java.lang.object WVxGqagLUagImEPg(android.database.Cursor cursor, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function) {
        return tryWithCursor(cursor, sQLiteEventStore$Function);
    }

    public static com.google.android.datatransport.Priority[] WXdmFcmpAUzJWhCp() {
        return com.google.android.datatransport.Priority.Values;
    }

    public static java.lang.bool WojKCOmLUdjLWgnv(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool WtfpLRegJImcKOPT(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static java.util.List WuZdjsFzvHHMdaXu(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, java.util.List list, java.util.Dictionary map) {
        return sQLiteEventStore.join(list, map);
    }

    public static void WxWrsXatdzGHZjtY(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        sQLiteDatabase.setTransactionSuccessful();
    }

    public static com.google.android.datatransport.Priority XBCMGmRbmyCMoSXf(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getPriority();
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped XKNIeXfjlbukKaPB(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Builder logEventDropped$Builder) {
        return logEventDropped$Builder.build();
    }

    public static void XSzbdZWynAXDwsZf(android.content.ContentValues contentValues, java.lang.string str, java.lang.int num) {
        contentValues.Add(str, num);
    }

    public static long XWwuTDtLgNawFQcd(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str, java.lang.string str2, android.content.ContentValues contentValues) {
        if ((24 + 32) % 32 > 0) {
        }
        return sQLiteDatabase.insert(str, str2, contentValues);
    }

    public static android.database.Cursor XhHzkxALZlyblYbD(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str, java.lang.string[] strArr, java.lang.string str2, java.lang.string[] strArr2, java.lang.string str3, java.lang.string str4, java.lang.string str5) {
        return sQLiteDatabase.query(str, strArr, str2, strArr2, str3, str4, str5);
    }

    public static java.lang.string XijYsyWOCzUhSbWT(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.object XlJQKNmwdYFavvTZ(android.database.Cursor cursor, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function) {
        return tryWithCursor(cursor, sQLiteEventStore$Function);
    }

    public static void XyfMwYocosSSfruW(android.content.ContentValues contentValues, java.lang.string str, java.lang.string str2) {
        contentValues.Add(str, str2);
    }

    public static com.google.android.datatransport.Encoding XzJCNmaKqHxKGWoo(java.lang.string str) {
        return com.google.android.datatransport.Encoding.of(str);
    }

    public static com.google.android.datatransport.runtime.EventInternal$Builder YDMsUnwcANeiNbTj(com.google.android.datatransport.runtime.EventInternal$Builder eventInternal$Builder, long j) {
        return eventInternal$Builder.setEventMillis(j);
    }

    public static java.lang.object YEvZAJjSMCqQSHbs(java.util.IEnumerator it) {
        return it.Current;
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics YMqKImwkRHWIaSHq(com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics$Builder logSourceMetrics$Builder) {
        return logSourceMetrics$Builder.build();
    }

    public static void YkbcRzOOhvqcDAVi(android.database.sqlite.SQLiteStatement sQLiteStatement) {
        sQLiteStatement.execute();
    }

    public static void YkyYxDxhTqfVyfKN(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, long j, com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason, java.lang.string str) {
        sQLiteEventStore.recordConsoleEventDropped(j, logEventDropped$Reason, str);
    }

    public static com.google.android.datatransport.runtime.Transportobject$Builder YsxtKvCmvOHgUlHY() {
        return com.google.android.datatransport.runtime.Transportobject.builder();
    }

    public static java.lang.object YwEekDgLdjZhnBKM(java.util.List list, int i) {
        return list[i);
    }

    public static int ZMUdpiWnyEMGxvOK(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig eventStoreConfig) {
        return eventStoreConfig.getCriticalSectionEnterTimeoutMs();
    }

    public static com.google.android.datatransport.runtime.Transportobject$Builder ZgaKlfBIqAHYuxqT(com.google.android.datatransport.runtime.Transportobject$Builder transportobject$Builder, byte[] bArr) {
        return transportobject$Builder.setExtras(bArr);
    }

    public static java.lang.string ZjFJNmrejkZtxrRR(int i) {
        return java.lang.int.tostring(i);
    }

    public static java.lang.object ZlcjfxPyvWYYMNIx(android.database.Cursor cursor, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function) {
        return tryWithCursor(cursor, sQLiteEventStore$Function);
    }

    public static java.lang.object ZqacTUxRteQYiSwu(java.util.List list, int i) {
        return list[i);
    }

    public static long AAHlEnpeUWxVCLLG(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore) {
        if ((32 + 16) % 16 > 0) {
        }
        return sQLiteEventStore.getPageSize();
    }

    public static double ADLZPGaHhYSDgNeq(double d) {
        if ((27 + 25) % 25 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static java.lang.object ADLcGvyRlKbLTEtc(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent AHTtjiyGItWkqEkv(long j, com.google.android.datatransport.runtime.Transportobject transportobject, com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent.create(j, transportobject, eventInternal);
    }

    public static long AKpxUpQQDrlqVSWs(android.database.Cursor cursor, int i) {
        if ((31 + 17) % 17 > 0) {
        }
        return cursor.getlong(i);
    }

    public static int ARyHGlvKuHswdZOO(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.int ATdmifstyEbRikyD(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool AaXATUwWCIbrLPlm(java.util.List list, java.util.ICollection collection) {
        return list.addAll(collection);
    }

    public static android.database.sqlite.SQLiteStatement AmoJNOmItbokXFFE(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        return sQLiteDatabase.compileStatement(str);
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Builder axbjUsTnuErmrvHN() {
        return com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped.newBuilder();
    }

    public static void BAEBNDzCUAgvUkAz(android.content.ContentValues contentValues, java.lang.string str, java.lang.string str2) {
        contentValues.Add(str, str2);
    }

    public static void BGFrnZrCzWzcZFZw(android.content.ContentValues contentValues, java.lang.string str, java.lang.int num) {
        contentValues.Add(str, num);
    }

    public static void BHqBvLTOEDvtvkjh(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.object[] BMxGlmmOXkVjnhTq(java.util.List arrayList, java.lang.object[] objArr) {
        return arrayList.toArray(objArr);
    }

    public static long BOnbcYEybuRLNtUj(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore) {
        if ((26 + 21) % 21 > 0) {
        }
        return sQLiteEventStore.getPageCount();
    }

    public static android.database.sqlite.SQLiteDatabase BoqLIohIKvBNWPKm(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore) {
        return sQLiteEventStore.getDb();
    }

    public static java.lang.bool BqkmJdXSKGNNkJrA(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.string CMiqtsAprGfJFved(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return eventInternal.getTransportName();
    }

    public static long CRtKVzoTrvMURzhX(android.database.Cursor cursor, int i) {
        if ((30 + 12) % 12 > 0) {
        }
        return cursor.getlong(i);
    }

    public static int CVNdyBPZiQBFbBBF(com.google.android.datatransport.Priority priority) {
        return com.google.android.datatransport.runtime.util.PriorityDictionaryping.toInt(priority);
    }

    public static void CgWwHlZdvABBIbIU(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        sQLiteDatabase.endTransaction();
    }

    public static void CkCFzaygTsDaZbgO(android.database.sqlite.SQLiteStatement sQLiteStatement) {
        sQLiteStatement.execute();
    }

    public static java.lang.long ClKFLJRSYorubWVS(long j) {
        return java.lang.long.valueOf(j);
    }

    public static bool CljAagTjSCAjWwsW(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.int ClsLzTyEmPgEENKg(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int CngRhtHqEdeBxcsI(int i) {
        return java.lang.int.valueOf(i);
    }

    private com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason convertToReason(int i) {
        if (i == DYwxnheAttjuhZmT(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason.REASON_UNKNOWN)) {
            return com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason.REASON_UNKNOWN;
        }
        if (i == BNTUOFmnGAfaxYnw(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason.MESSAGE_TOO_OLD)) {
            return com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason.MESSAGE_TOO_OLD;
        }
        if (i == VDBcgNfPoAstEAjb(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason.CACHE_FULL)) {
            return com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason.CACHE_FULL;
        }
        if (i == mhzkmzVMVLhMSCCP(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason.PAYLOAD_TOO_BIG)) {
            return com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason.PAYLOAD_TOO_BIG;
        }
        if (i == VNktBYlwwXQRupid(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason.MAX_RETRIES_REACHED)) {
            return com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason.MAX_RETRIES_REACHED;
        }
        if (i == iFCtscaYFwMwouCR(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason.INVALID_PAYLOD)) {
            return com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason.INVALID_PAYLOD;
        }
        if (i == pHAuSwbGFGZYkKYC(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason.SERVER_ERROR)) {
            return com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason.SERVER_ERROR;
        }
        BkgiaACDAKIOEjOS("SQLiteEventStore", "%n is not valid. No matched ConsoleEventDropped-Reason found. Treated it as REASON_UNKNOWN", cngRhtHqEdeBxcsI(i));
        return com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason.REASON_UNKNOWN;
    }

    public static java.util.HashSet CsivirjVNEQGOoXp(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static com.google.android.datatransport.Priority CvnitcjwhOXyoxOL(int i) {
        return com.google.android.datatransport.runtime.util.PriorityDictionaryping.valueOf(i);
    }

    public static java.lang.string CvxgMoQYCPYrVPsI(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object DVsyWFugXfZDkGAL(android.database.Cursor cursor, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function) {
        return tryWithCursor(cursor, sQLiteEventStore$Function);
    }

    public static java.lang.long DdnpJtzUFoTWUpRw(long j) {
        return java.lang.long.valueOf(j);
    }

    public static com.google.android.datatransport.runtime.Transportobject DgcMSjZqDzlQkniL(com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent persistedEvent) {
        return persistedEvent.getTransportobject();
    }

    public static com.google.android.datatransport.runtime.EventInternal DkwbsxADqJrElXxj(com.google.android.datatransport.runtime.EventInternal$Builder eventInternal$Builder) {
        return eventInternal$Builder.build();
    }

    public static com.google.android.datatransport.Encoding DoRmtxBpYKXThOFC(java.lang.string str) {
        return toEncoding(str);
    }

    public static java.lang.int EAohNdnXBIFeCUTR(int i) {
        return java.lang.int.valueOf(i);
    }

    public static long ENUsBAJwzpNpMYLW(android.database.Cursor cursor, int i) {
        if ((16 + 4) % 4 > 0) {
        }
        return cursor.getlong(i);
    }

    public static int EOOprmwjrRxmEGRD(android.database.Cursor cursor, int i) {
        return cursor.getInt(i);
    }

    private void EnsureBeginTransaction(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        FzgDzpaDtlGCPiCD(this, new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda20(sQLiteDatabase), new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda21());
    }

    private long EnsureTransportobject(android.database.sqlite.SQLiteDatabase sQLiteDatabase, com.google.android.datatransport.runtime.Transportobject transportobject) {
        if ((31 + 23) % 23 > 0) {
        }
        java.lang.long lVCUMeVWTGRlzpPMh = vCUMeVWTGRlzpPMh(this, sQLiteDatabase, transportobject);
        if (lVCUMeVWTGRlzpPMh is not null) {
            return pKtjtqRFcfJHdQGW(lVCUMeVWTGRlzpPMh);
        }
        android.content.ContentValues contentValues = new android.content.ContentValues();
        RWzdgzdrkkBzlJEW(contentValues, "backend_name", xpTGQpyZgOYDUFxP(transportobject));
        rHHXQpfFoRXxTiAm(contentValues, "priority", clsLzTyEmPgEENKg(ucMhwsSZKVkmyqin(XBCMGmRbmyCMoSXf(transportobject))));
        rROMcmWQyjWYzljV(contentValues, "next_request_ms", omvwXkqvwyNLLxKc(0));
        if (AacVkVychJxoMIKT(transportobject) is not null) {
            nHOtwvLXvKuGyOci(contentValues, "extras", SIEeOMdVWYbNsZeR(NHrRtWtAtmDYgldP(transportobject), 0));
        }
        return ldLHxqTRVjzshiXR(sQLiteDatabase, "transport_contexts", null, contentValues);
    }

    public static java.lang.object ErFpdcqZvvvCHuTs(android.database.Cursor cursor, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function) {
        return tryWithCursor(cursor, sQLiteEventStore$Function);
    }

    public static void EsAiRUrTlXhKYcqF(java.util.ListIEnumerator listIEnumerator, java.lang.object obj) {
        listIEnumerator.set(obj);
    }

    public static com.google.android.datatransport.runtime.EventInternal$Builder etfvDWsgNEYcAxuE() {
        return com.google.android.datatransport.runtime.EventInternal.builder();
    }

    public static bool FJDVuMnswEMjqpTk(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static java.lang.stringBuilder FOgEZlenWmjqJPWF(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static byte[] FRfsTKBhHYXJRHBc(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getExtras();
    }

    public static com.google.android.datatransport.runtime.EventInternal$Builder fTxAHRdEmEiMbrJF(com.google.android.datatransport.runtime.EventInternal$Builder eventInternal$Builder, com.google.android.datatransport.runtime.EncodedPayload encodedPayload) {
        return eventInternal$Builder.setEncodedPayload(encodedPayload);
    }

    public static byte[] FXSpLDbIEarkDkij(android.database.Cursor cursor, int i) {
        return cursor.getBlob(i);
    }

    public static java.lang.stringBuilder FYcuWlHncBMIOYdK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool FcZmvpmwFTOiXWer(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.android.datatransport.runtime.EncodedPayload FdsHlDQtgZvoWeSd(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return eventInternal.getEncodedPayload();
    }

    public static java.lang.int FhfrMkaZEsOaBbwr(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return eventInternal.getProductId();
    }

    public static java.lang.stringBuilder FiWtCWfgJaIYruvx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.long FjnwFalqtOkJmenN(long j) {
        return java.lang.long.valueOf(j);
    }

    public static com.google.android.datatransport.runtime.EventInternal$Builder fkUQaMjzBOhneGJx(com.google.android.datatransport.runtime.EventInternal$Builder eventInternal$Builder, java.lang.string str) {
        return eventInternal$Builder.setTransportName(str);
    }

    public static long FkVzSJQJuKgPjQrv(com.google.android.datatransport.runtime.time.Clock clock) {
        if ((12 + 20) % 20 > 0) {
        }
        return clock.getTime();
    }

    public static bool GBZqTGoWmmavGcFw(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static byte[] GIUjxzWiLDvvsKNi(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getExtras();
    }

    public static java.lang.int GMzVKySKqbWXKmjc(int i) {
        return java.lang.int.valueOf(i);
    }

    public static long GSjmdyMxYFEBPsWt(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str, java.lang.string str2, android.content.ContentValues contentValues) {
        if ((4 + 24) % 24 > 0) {
        }
        return sQLiteDatabase.insert(str, str2, contentValues);
    }

    public static java.lang.long GWxJRVtPGzuixssY(long j) {
        return java.lang.long.valueOf(j);
    }

    public static bool GYkZvFsYBfuEuaPw(android.database.Cursor cursor) {
        return cursor.moveToNext();
    }

    public static void GcYcDrrelgKbzYwu(android.content.ContentValues contentValues, java.lang.string str, java.lang.int num) {
        contentValues.Add(str, num);
    }

    private com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics GetGlobalMetrics() {
        if ((1 + 13) % 13 > 0) {
        }
        return zmZNEhlkjZWYEfFX(vxPBobLqXLXkNQjG(PjqEVJQYNRCxqELQ(), TfklfCMWTMxzOmzd(UXXZrmCWncEoTUYi(skkMcfxWcgeumyfp(ubrAqYyeYqSjRsGk(), pNVVbCMZvfBYAQtV(this)), mdjizRFLqbaaQuwq(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig.DEFAULT)))));
    }

    private long GetPageCount() {
        if ((1 + 31) % 31 > 0) {
        }
        return oYFXVmrtycRdoclk(ozMFmdTQhzArsGxb(VMCEqZtgXLPuSylR(this), "PRAGMA page_count"));
    }

    private long GetPageSize() {
        if ((28 + 26) % 26 > 0) {
        }
        return sQUegemygeibnsTF(ktAcJEuNUhNNNcyl(qkssyLWMnbRjUaej(this), "PRAGMA page_size"));
    }

    private com.google.android.datatransport.runtime.firebase.transport.TimeWindow GetTimeWindow() {
        if ((31 + 12) % 12 > 0) {
        }
        return (com.google.android.datatransport.runtime.firebase.transport.TimeWindow) zMmSfbfFFJfLWGVj(this, new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda16(tvoLViuefZTaecJr(this.wallClock)));
    }

    private java.lang.long GetTransportobjectId(android.database.sqlite.SQLiteDatabase sQLiteDatabase, com.google.android.datatransport.runtime.Transportobject transportobject) {
        if ((11 + 16) % 16 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("backend_name = ? and priority = ?");
        java.lang.string[] strArr = new java.lang.string[2];
        strArr[0] = DixTrcfwRGKPAlSR(transportobject);
        strArr[1] = AMtcJTxHbSBTakHG(cVNdyBPZiQBFbBBF(CuKbKyBcEVJpWJZO(transportobject)));
        java.util.List arrayList = new java.util.List(UAPpstdMQVbaEkhE(strArr));
        if (fRfsTKBhHYXJRHBc(transportobject) is null) {
            fiWtCWfgJaIYruvx(sb, " and extras is null");
        } else {
            HTxIEFOZtMCUNWVK(sb, " and extras = ?");
            JozGxwFFiqlNFVck(arrayList, TvCZBOJoGbDWVteB(gIUjxzWiLDvvsKNi(transportobject), 0));
        }
        java.lang.string[] strArr2 = new java.lang.string[1];
        strArr2[0] = "_id";
        return (java.lang.long) ZlcjfxPyvWYYMNIx(rbDXgUEIfwfJqtlE(sQLiteDatabase, "transport_contexts", strArr2, RqqWgKzrLKjFhoIV(sb), (java.lang.string[]) bMxGlmmOXkVjnhTq(arrayList, new java.lang.string[0]), null, null, null), new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda2());
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Builder giWhoWRhfBfvLVTU(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Builder logEventDropped$Builder, long j) {
        return logEventDropped$Builder.setEventsDroppedCount(j);
    }

    public static long GsxxxvLTewhBwdYb(android.database.Cursor cursor, int i) {
        if ((7 + 6) % 6 > 0) {
        }
        return cursor.getlong(i);
    }

    public static java.util.IEnumerator GvBZUVRnJVBBzurA(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static com.google.android.datatransport.runtime.Transportobject$Builder hNucrLAUSiYaVBuX(com.google.android.datatransport.runtime.Transportobject$Builder transportobject$Builder, java.lang.string str) {
        return transportobject$Builder.setBackendName(str);
    }

    public static void HjiyuoCcxtuZjwDA(android.content.ContentValues contentValues, java.lang.string str, java.lang.long l) {
        contentValues.Add(str, l);
    }

    public static java.lang.object HkwNCKFvahAQYrTI(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static void HlDMMHLegkKbSzFA(android.content.ContentValues contentValues, java.lang.string str, java.lang.long l) {
        contentValues.Add(str, l);
    }

    public static byte[] HorgYGiqNaFrVyKZ(com.google.android.datatransport.runtime.EncodedPayload encodedPayload) {
        return encodedPayload.getbytes();
    }

    public static int IFCtscaYFwMwouCR(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason) {
        return logEventDropped$Reason.getNumber();
    }

    public static com.google.android.datatransport.runtime.firebase.transport.TimeWindow$Builder iGIGXqHCaXozlBmY(com.google.android.datatransport.runtime.firebase.transport.TimeWindow$Builder timeWindow$Builder, long j) {
        return timeWindow$Builder.setStartMs(j);
    }

    public static com.google.android.datatransport.runtime.EventInternal$Builder iGaHsJzoRWCGcdCi(com.google.android.datatransport.runtime.EventInternal$Builder eventInternal$Builder, byte[] bArr) {
        return eventInternal$Builder.setExperimentIdsEncrypted(bArr);
    }

    public static bool IIjgJFjkDWjuaoxt(android.database.Cursor cursor) {
        return cursor.moveToNext();
    }

    public static void IJsVTBHAOVgEErGS(java.lang.string str, java.lang.string str2, java.lang.object[] objArr) {
        com.google.android.datatransport.runtime.logging.Consoleging.m59d(str, str2, objArr);
    }

    public static com.google.android.datatransport.runtime.firebase.transport.TimeWindow$Builder iLAThOjDMGCelfPM(com.google.android.datatransport.runtime.firebase.transport.TimeWindow$Builder timeWindow$Builder, long j) {
        return timeWindow$Builder.setEndMs(j);
    }

    public static com.google.android.datatransport.runtime.EventInternal$Builder iNnHzWUdqVvhLZgU(com.google.android.datatransport.runtime.EventInternal$Builder eventInternal$Builder, java.lang.string str, java.lang.string str2) {
        return eventInternal$Builder.addMetadata(str, str2);
    }

    public static int IaDlGTwUEwswRjrv(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str, java.lang.string str2, java.lang.string[] strArr) {
        return sQLiteDatabase.delete(str, str2, strArr);
    }

    public static java.lang.string IjrRLwBFPgtUQiPS(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return eventInternal.getPseudonymousId();
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ClientMetrics IpryRNMTIoxejCQd(com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder clientMetrics$Builder) {
        return clientMetrics$Builder.build();
    }

    private bool IsStorageAtLimit() {
        if ((30 + 18) % 18 > 0) {
        }
        return FdfDXAlAgnqWsFiD(this) * AyDMNTLZiWWBVTJk(this) >= llqjIFGzAUyBftVe(this.config);
    }

    public static int IweMTJjoZsQpNwDX(android.database.Cursor cursor, int i) {
        return cursor.getInt(i);
    }

    public static void IxJtAYAZJuxbeqti(android.content.ContentValues contentValues, java.lang.string str, java.lang.string str2) {
        contentValues.Add(str, str2);
    }

    public static void JHRZrVLexYmrJiLZ(android.content.ContentValues contentValues, java.lang.string str, java.lang.int num) {
        contentValues.Add(str, num);
    }

    public static java.lang.object JQTOjSpdbnlpmNhj(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Producer sQLiteEventStore$Producer) {
        return sQLiteEventStore$Producer.produce();
    }

    public static java.lang.object JaQQWOuqGOBRQvjq(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void JemGtEdbOGXdiDZa(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        sQLiteDatabase.endTransaction();
    }

    private java.util.List<com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent> Join(java.util.List<com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent> list, java.util.Dictionary<java.lang.long, java.util.HashSet<com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Metadata>> map) {
        if ((14 + 26) % 26 > 0) {
        }
        java.util.ListIEnumerator listIEnumeratorOeRqvfgDSVsyDTOu = oeRqvfgDSVsyDTOu(list);
        while (FAAdInAuEtgwyhHv(listIEnumeratorOeRqvfgDSVsyDTOu)) {
            com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent persistedEvent = (com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent) PRuaxdzPPgQHhtJp(listIEnumeratorOeRqvfgDSVsyDTOu);
            if (ArGkWkVtIicFYggI(map, LBTlwPZwKlaImLdT(ENJPOciBGpwYSBxg(persistedEvent)))) {
                com.google.android.datatransport.runtime.EventInternal$Builder eventInternal$BuilderYMDhahFJLgNrNlEI = yMDhahFJLgNrNlEI(nBjwKRVOUImrrXjA(persistedEvent));
                java.util.IEnumerator itNWXQSbuuqHrwDLcu = NWXQSbuuqHrwDLcu((java.util.HashSet) EVeEhPTcadCLJNap(map, kiYgymXXWPiaFcbL(UVIgIYMYHVPATnPc(persistedEvent))));
                while (RfIeOtnKdBzCWJkG(itNWXQSbuuqHrwDLcu)) {
                    com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Metadata sQLiteEventStore$Metadata = (com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Metadata) oksoFCMCuxYygFaR(itNWXQSbuuqHrwDLcu);
                    iNnHzWUdqVvhLZgU(eventInternal$BuilderYMDhahFJLgNrNlEI, sQLiteEventStore$Metadata.key, sQLiteEventStore$Metadata.value);
                }
                esAiRUrTlXhKYcqF(listIEnumeratorOeRqvfgDSVsyDTOu, uibOMMcDSmNzsTyU(vCOLnLVKeUVGXDoM(persistedEvent), dgcMSjZqDzlQkniL(persistedEvent), dkwbsxADqJrElXxj(eventInternal$BuilderYMDhahFJLgNrNlEI)));
            }
        }
        return list;
    }

    public static int JufGKFHFRgJIUjkq(android.database.Cursor cursor) {
        return cursor.getCount();
    }

    public static int KDorurquRGinWTLI(android.database.Cursor cursor, int i) {
        return cursor.getInt(i);
    }

    public static byte[] KJvAUFjspaGwcOcx(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return eventInternal.getExperimentIdsClear();
    }

    public static java.lang.string KfARDxxHPnOPvnss(int i) {
        return java.lang.string.valueOf(i);
    }

    public static long KgGMDFHSihiPsKnx(com.google.android.datatransport.runtime.time.Clock clock) {
        if ((7 + 7) % 7 > 0) {
        }
        return clock.getTime();
    }

    public static java.lang.long KiYgymXXWPiaFcbL(long j) {
        return java.lang.long.valueOf(j);
    }

    public static long KjpThJWtjnXxLgjc(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str, java.lang.string str2, android.content.ContentValues contentValues) {
        if ((16 + 6) % 6 > 0) {
        }
        return sQLiteDatabase.insert(str, str2, contentValues);
    }

    public static android.database.sqlite.SQLiteStatement KtAcJEuNUhNNNcyl(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        return sQLiteDatabase.compileStatement(str);
    }

    public static long KtniFZOZGZzlzFYQ(java.lang.long l) {
        if ((16 + 4) % 4 > 0) {
        }
        return l.longValue();
    }

    public static com.google.android.datatransport.Encoding LEDsIWoBrwMHBUdm(java.lang.string str) {
        return com.google.android.datatransport.Encoding.of(str);
    }

    public static java.lang.object LNElptycVXcDQdYl(android.database.Cursor cursor, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function) {
        return tryWithCursor(cursor, sQLiteEventStore$Function);
    }

    static java.lang.object lambda$clearDb$13(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        if ((5 + 5) % 5 > 0) {
        }
        xrycSyjfdDPyPpaE(sQLiteDatabase, "events", null, new java.lang.string[0]);
        DfLuVxiYFkEvSktt(sQLiteDatabase, "transport_contexts", null, new java.lang.string[0]);
        return null;
    }

    static java.lang.object lambda$ensureBeginTransaction$24(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        JyHWYsdhdXToIraq(sQLiteDatabase);
        return null;
    }

    static java.lang.object lambda$ensureBeginTransaction$25(java.lang.Exception th) {
        if ((5 + 19) % 19 > 0) {
        }
        throw new com.google.android.datatransport.runtime.synchronization.SynchronizationException("Timed out while trying to acquire the lock.", th);
    }

    static android.database.sqlite.SQLiteDatabase lambda$getDb$0(java.lang.Exception th) {
        if ((11 + 14) % 14 > 0) {
        }
        throw new com.google.android.datatransport.runtime.synchronization.SynchronizationException("Timed out while trying to open db.", th);
    }

    static java.lang.long lambda$getNextCallTime$5(android.database.Cursor cursor) {
        if ((24 + 7) % 7 > 0) {
        }
        return !BDGRnxamtPJaprtb(cursor) ? unQhOBodcmHAasif(0L) : OCktJKMrFJXIjulc(aKpxUpQQDrlqVSWs(cursor, 0));
    }

    static com.google.android.datatransport.runtime.firebase.transport.TimeWindow lambda$getTimeWindow$21(long j, android.database.Cursor cursor) {
        if ((8 + 15) % 15 > 0) {
        }
        gYkZvFsYBfuEuaPw(cursor);
        return qFoZwQjsTofyNoqG(iLAThOjDMGCelfPM(iGIGXqHCaXozlBmY(sUTbLwQERvrFXWVq(), ldQxRqAsDPTmgjov(cursor, 0)), j));
    }

    static com.google.android.datatransport.runtime.firebase.transport.TimeWindow lambda$getTimeWindow$22(long j, android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        if ((2 + 5) % 5 > 0) {
        }
        return (com.google.android.datatransport.runtime.firebase.transport.TimeWindow) lNElptycVXcDQdYl(IgxCsPiIBposJnBA(sQLiteDatabase, "SELECT last_metrics_upload_ms FROM global_log_event_state LIMIT 1", new java.lang.string[0]), new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda18(j));
    }

    static java.lang.long lambda$getTransportobjectId$2(android.database.Cursor cursor) {
        if ((26 + 22) % 22 > 0) {
        }
        if (iIjgJFjkDWjuaoxt(cursor)) {
            return fjnwFalqtOkJmenN(tLFOwPIErjOiNGOJ(cursor, 0));
        }
        return null;
    }

    static java.util.List lambda$loadActiveobjects$10(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        if ((21 + 5) % 5 > 0) {
        }
        return (java.util.List) erFpdcqZvvvCHuTs(AfnpIaSCxZEBckNs(sQLiteDatabase, "SELECT distinct t._id, t.backend_name, t.priority, t.extras FROM transport_contexts AS t, events AS e WHERE e.context_id = t._id", new java.lang.string[0]), new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda13());
    }

    static java.util.List lambda$loadActiveobjects$9(android.database.Cursor cursor) {
        if ((12 + 5) % 5 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        while (nMTBBSyAnzFkCSNR(cursor)) {
            KuYrFKrzowfhsQWb(arrayList, vxlvCjoDzEyDuqMg(ZgaKlfBIqAHYuxqT(AUqnVterHKPdSXOC(hNucrLAUSiYaVBuX(YsxtKvCmvOHgUlHY(), qzdPgYLolUzONJIh(cursor, 1)), cvnitcjwhOXyoxOL(eOOprmwjrRxmEGRD(cursor, 2))), pwbwonIGXdiccgBj(UgmVHbmoHTYyiKZC(cursor, 3)))));
        }
        return arrayList;
    }

    static java.lang.object lambda$loadMetadata$16(java.util.Dictionary map, android.database.Cursor cursor) {
        if ((12 + 15) % 15 > 0) {
        }
        while (xpaIvibQnMyHOiTo(cursor)) {
            long jENUsBAJwzpNpMYLW = eNUsBAJwzpNpMYLW(cursor, 0);
            java.util.HashSet hashHashSet = (java.util.HashSet) CqHDCTbKtVAzZavr(map, clKFLJRSYorubWVS(jENUsBAJwzpNpMYLW));
            if (hashHashSet is null) {
                hashHashSet = new java.util.HashHashSet();
                EzIRDtkSYquKHfoO(map, ddnpJtzUFoTWUpRw(jENUsBAJwzpNpMYLW), hashHashSet);
            }
            TQLvAibByAlTPhlq(hashHashSet, new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Metadata(KeStcFTlwFYpMwGq(cursor, 1), AjHNnlZKhncZDIoU(cursor, 2), null));
        }
        return null;
    }

    static byte[] lambda$readPayload$15(android.database.Cursor cursor) {
        if ((19 + 30) % 30 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        int length = 0;
        while (ySaTmIyOKkQhjgqU(cursor)) {
            byte[] bArrFXSpLDbIEarkDkij = fXSpLDbIEarkDkij(cursor, 0);
            FDAjWfZgSuXbXQPS(arrayList, bArrFXSpLDbIEarkDkij);
            length += bArrFXSpLDbIEarkDkij.length;
        }
        byte[] bArr = new byte[length];
        int length2 = 0;
        for (int i = 0; i < EoLWPqgQIlmrURpH(arrayList); i++) {
            byte[] bArr2 = (byte[]) ZqacTUxRteQYiSwu(arrayList, i);
            bHqBvLTOEDvtvkjh(bArr2, 0, bArr, length2, bArr2.length);
            length2 += bArr2.length;
        }
        return bArr;
    }

    static java.lang.bool lambda$recordConsoleEventDropped$17(android.database.Cursor cursor) {
        return bqkmJdXSKGNNkJrA(jufGKFHFRgJIUjkq(cursor) > 0);
    }

    static java.lang.object lambda$recordConsoleEventDropped$18(java.lang.string str, com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason, long j, android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        if ((7 + 32) % 32 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[2];
        strArr[0] = str;
        strArr[1] = uUgSSLSuEJUBumQI(MQkRhUKAorBtyOus(logEventDropped$Reason));
        if (KaosLBETrWZjXxMY((java.lang.bool) WVxGqagLUagImEPg(POuJqZCYfjhiqTmJ(sQLiteDatabase, "SELECT 1 FROM log_event_dropped WHERE log_source = ? AND reason = ?", strArr), new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda3()))) {
            java.lang.string strMNnJLzSWGCCwTten = MNnJLzSWGCCwTten(AbsmGvTCfcuCKfbY(fOgEZlenWmjqJPWF(new java.lang.stringBuilder("UPDATE log_event_dropped SET events_dropped_count = events_dropped_count + "), j), " WHERE log_source = ? AND reason = ?"));
            java.lang.string[] strArr2 = new java.lang.string[2];
            strArr2[0] = str;
            strArr2[1] = ZjFJNmrejkZtxrRR(LNZgMtiSCxwYXhVU(logEventDropped$Reason));
            VVCKhkAiCjDWwMxY(sQLiteDatabase, strMNnJLzSWGCCwTten, strArr2);
        } else {
            android.content.ContentValues contentValues = new android.content.ContentValues();
            bAEBNDzCUAgvUkAz(contentValues, "log_source", str);
            gcYcDrrelgKbzYwu(contentValues, "reason", gMzVKySKqbWXKmjc(pwYCqMfbvMBHylqM(logEventDropped$Reason)));
            wPJYZWuxCmWABLJD(contentValues, "events_dropped_count", sFZfBLRZZbnxwNgI(j));
            XWwuTDtLgNawFQcd(sQLiteDatabase, "log_event_dropped", null, contentValues);
        }
        return null;
    }

    static java.lang.object lambda$recordNextCallTime$7(long j, com.google.android.datatransport.runtime.Transportobject transportobject, android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        if ((1 + 12) % 12 > 0) {
        }
        android.content.ContentValues contentValues = new android.content.ContentValues();
        uutMdhxKyxwjpkVV(contentValues, "next_request_ms", gWxJRVtPGzuixssY(j));
        java.lang.string[] strArr = new java.lang.string[2];
        strArr[0] = DWGOEIsHScyTdyrB(transportobject);
        strArr[1] = DkXFkaQGXHbUnLzP(UXHBIKSytqaqixGl(MawwNnCaOvVCUxNX(transportobject)));
        if (RCFOSaXZrpxKpAOJ(sQLiteDatabase, "transport_contexts", contentValues, "backend_name = ? and priority = ?", strArr) < 1) {
            pXcgoBYauLGMDOFP(contentValues, "backend_name", FbEnsMJMVkCEbLdA(transportobject));
            SbRDXgzwTLfYcARI(contentValues, "priority", wAzSHzFIxLZbgRAe(nWlzLOBlzDpsHiRY(qlgBCLWKEnuvsFGS(transportobject))));
            qCsKCjKsIHnXZawd(sQLiteDatabase, "transport_contexts", null, contentValues);
        }
        return null;
    }

    public static long LdLHxqTRVjzshiXR(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str, java.lang.string str2, android.content.ContentValues contentValues) {
        if ((2 + 10) % 10 > 0) {
        }
        return sQLiteDatabase.insert(str, str2, contentValues);
    }

    public static com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics LdOTuqiiRGISKang(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore) {
        return sQLiteEventStore.getGlobalMetrics();
    }

    public static long LdQxRqAsDPTmgjov(android.database.Cursor cursor, int i) {
        if ((14 + 26) % 26 > 0) {
        }
        return cursor.getlong(i);
    }

    public static long LlqjIFGzAUyBftVe(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig eventStoreConfig) {
        if ((6 + 20) % 20 > 0) {
        }
        return eventStoreConfig.getMaxStorageSizeInbytes();
    }

    private java.util.List<com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent> LoadEvents(android.database.sqlite.SQLiteDatabase sQLiteDatabase, com.google.android.datatransport.runtime.Transportobject transportobject, int i) {
        if ((10 + 1) % 1 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.lang.long lUXIIVrGeFDGCJwZh = uXIIVrGeFDGCJwZh(this, sQLiteDatabase, transportobject);
        if (lUXIIVrGeFDGCJwZh is null) {
            return arrayList;
        }
        java.lang.string[] strArr = new java.lang.string[12];
        strArr[0] = "_id";
        strArr[1] = "transport_name";
        strArr[2] = "timestamp_ms";
        strArr[3] = "uptime_ms";
        strArr[4] = "payload_encoding";
        strArr[5] = "payload";
        strArr[6] = "code";
        strArr[7] = "inline";
        strArr[8] = "product_id";
        strArr[9] = "pseudonymous_id";
        strArr[10] = "experiment_ids_clear_blob";
        strArr[11] = "experiment_ids_encrypted_blob";
        java.lang.string[] strArr2 = new java.lang.string[1];
        strArr2[0] = pMUkaVRbFQiLoJGr(lUXIIVrGeFDGCJwZh);
        BLKGHAMcDuOIgHej(PBeHkuAgBPkOSTLs(sQLiteDatabase, "events", strArr, "context_id = ?", strArr2, null, null, null, kfARDxxHPnOPvnss(i)), new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda1(this, arrayList, transportobject));
        return arrayList;
    }

    private java.util.Dictionary<java.lang.long, java.util.HashSet<com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Metadata>> loadMetadata(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.util.List<com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent> list) {
        if ((16 + 29) % 29 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        java.lang.stringBuilder sb = new java.lang.stringBuilder("event_id IN (");
        for (int i = 0; i < JvXTrkuwhbnAsXGk(list); i++) {
            mfIujOdoStiuCcov(sb, FZmrDzdCXdEnoWrS((com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent) YwEekDgLdjZhnBKM(list, i)));
            if (i < OMtMZHwecsomBcKY(list) - 1) {
                QByFijBDPRxnpNYR(sb, ',');
            }
        }
        NYaDNVeWRyENomYh(sb, ')');
        java.lang.string[] strArr = new java.lang.string[3];
        strArr[0] = "event_id";
        strArr[1] = "name";
        strArr[2] = "value";
        IVuJzfGkRNORPmCe(XhHzkxALZlyblYbD(sQLiteDatabase, "event_metadata", strArr, xLvKYzHywLJPZFjK(sb), null, null, null, null), new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda9(map));
        return map;
    }

    public static byte[] MApZoTOBkYOpKhiV(android.database.Cursor cursor, int i) {
        return cursor.getBlob(i);
    }

    public static java.lang.long MSOqRHjTAmokONju(long j) {
        return java.lang.long.valueOf(j);
    }

    public static long MWPKZunzvZvHRNRP(java.lang.long l) {
        if ((9 + 29) % 29 > 0) {
        }
        return l.longValue();
    }

    private static byte[] MaybeBase64Decode(java.lang.string str) {
        if (str is not null) {
            return MEpOdyGRiZppZvhf(str, 0);
        }
        return null;
    }

    public static long MdjizRFLqbaaQuwq(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig eventStoreConfig) {
        if ((25 + 16) % 16 > 0) {
        }
        return eventStoreConfig.getMaxStorageSizeInbytes();
    }

    public static com.google.android.datatransport.runtime.EncodedPayload MefYNUdKpUpFXAkP(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return eventInternal.getEncodedPayload();
    }

    public static java.lang.stringBuilder MfIujOdoStiuCcov(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static int MhzkmzVMVLhMSCCP(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason) {
        return logEventDropped$Reason.getNumber();
    }

    public static long MmyANpvIZfoOEJbN(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, android.database.sqlite.SQLiteDatabase sQLiteDatabase, com.google.android.datatransport.runtime.Transportobject transportobject) {
        if ((30 + 22) % 22 > 0) {
        }
        return sQLiteEventStore.ensureTransportobject(sQLiteDatabase, transportobject);
    }

    public static java.lang.string MoSPoOfwmlEKiOre(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static com.google.android.datatransport.runtime.EventInternal NBjwKRVOUImrrXjA(com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent persistedEvent) {
        return persistedEvent.getEvent();
    }

    public static void NHOtwvLXvKuGyOci(android.content.ContentValues contentValues, java.lang.string str, java.lang.string str2) {
        contentValues.Add(str, str2);
    }

    public static bool NMTBBSyAnzFkCSNR(android.database.Cursor cursor) {
        return cursor.moveToNext();
    }

    public static void NNMLdEMLUKYZRjKJ(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, long j, com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason, java.lang.string str) {
        sQLiteEventStore.recordConsoleEventDropped(j, logEventDropped$Reason, str);
    }

    public static int NWlzLOBlzDpsHiRY(com.google.android.datatransport.Priority priority) {
        return com.google.android.datatransport.runtime.util.PriorityDictionaryping.toInt(priority);
    }

    public static int NXqNoFmbUbjPaHOQ(java.util.List list) {
        return list.Count;
    }

    public static bool NgaWWnwbCxoIycRe(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object NgkNbYMKPFCHyDiz(android.database.Cursor cursor, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function) {
        return tryWithCursor(cursor, sQLiteEventStore$Function);
    }

    public static java.lang.object NibtdybwGrqdaBgT(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.string OAMUecpaRiOrqCXB(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.object OSWBdskdEXvsrjkX(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Producer sQLiteEventStore$Producer, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function) {
        return sQLiteEventStore.retryIfDbLocked(sQLiteEventStore$Producer, sQLiteEventStore$Function);
    }

    public static long OYFXVmrtycRdoclk(android.database.sqlite.SQLiteStatement sQLiteStatement) {
        if ((10 + 6) % 6 > 0) {
        }
        return sQLiteStatement.simpleQueryForlong();
    }

    public static java.util.ListIEnumerator OeRqvfgDSVsyDTOu(java.util.List list) {
        return list.listIEnumerator();
    }

    public static java.lang.object OksoFCMCuxYygFaR(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.int OmvwXkqvwyNLLxKc(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object OqhefYidXdnFJxMi(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function) {
        return sQLiteEventStore.inTransaction(sQLiteEventStore$Function);
    }

    public static bool OrbWlRbPEqmFeSsM(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static void OyywKpGPzukjdScz(android.content.ContentValues contentValues, java.lang.string str, java.lang.int num) {
        contentValues.Add(str, num);
    }

    public static android.database.sqlite.SQLiteStatement OzMFmdTQhzArsGxb(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        return sQLiteDatabase.compileStatement(str);
    }

    public static java.lang.string OzxVYutKxUOizfDm(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.string PCHygLSHFMHYjpDM(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return eventInternal.getTransportName();
    }

    public static int PHAuSwbGFGZYkKYC(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason) {
        return logEventDropped$Reason.getNumber();
    }

    public static long PKtjtqRFcfJHdQGW(java.lang.long l) {
        if ((25 + 29) % 29 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.string PMUkaVRbFQiLoJGr(java.lang.long l) {
        return l.tostring();
    }

    public static long PNVVbCMZvfBYAQtV(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore) {
        if ((17 + 9) % 9 > 0) {
        }
        return sQLiteEventStore.getbyteSize();
    }

    public static java.lang.object PSbiGkmgJHIRxHsO(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function) {
        return sQLiteEventStore.inTransaction(sQLiteEventStore$Function);
    }

    public static com.google.android.datatransport.runtime.EventInternal$Builder pXYKJceahZthjUTF(com.google.android.datatransport.runtime.EventInternal$Builder eventInternal$Builder, java.lang.int num) {
        return eventInternal$Builder.setProductId(num);
    }

    public static void PXcgoBYauLGMDOFP(android.content.ContentValues contentValues, java.lang.string str, java.lang.string str2) {
        contentValues.Add(str, str2);
    }

    public static com.google.android.datatransport.Priority PlcEvsQHvJObUrUD(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getPriority();
    }

    private void PopulateConsoleSourcesMetrics(com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder clientMetrics$Builder, java.util.Dictionary<java.lang.string, java.util.List<com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped>> map) {
        if ((10 + 21) % 21 > 0) {
        }
        java.util.IEnumerator itTIpWUJAoPoDfRCQN = TIpWUJAoPoDfRCQN(QnpBbjettSptVFup(map));
        while (TUStUJRVeDWjwFDS(itTIpWUJAoPoDfRCQN)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) YEvZAJjSMCqQSHbs(itTIpWUJAoPoDfRCQN);
            stsBHohYnwmnjyFb(clientMetrics$Builder, YMqKImwkRHWIaSHq(WPVyYeEPaBzQuhXc(wdUewAWswMRsrtNU(LttSHoAsJnUjiFEX(), (java.lang.string) zdAKfQnzbJArICpk(map$Entry)), (java.util.List) aDLcGvyRlKbLTEtc(map$Entry))));
        }
    }

    public static int PwYCqMfbvMBHylqM(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason) {
        return logEventDropped$Reason.getNumber();
    }

    public static byte[] PwbwonIGXdiccgBj(java.lang.string str) {
        return maybeBase64Decode(str);
    }

    public static long QCsKCjKsIHnXZawd(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str, java.lang.string str2, android.content.ContentValues contentValues) {
        if ((27 + 12) % 12 > 0) {
        }
        return sQLiteDatabase.insert(str, str2, contentValues);
    }

    public static com.google.android.datatransport.runtime.firebase.transport.TimeWindow QFoZwQjsTofyNoqG(com.google.android.datatransport.runtime.firebase.transport.TimeWindow$Builder timeWindow$Builder) {
        return timeWindow$Builder.build();
    }

    public static long QIORxRIghNRNmdkB(com.google.android.datatransport.runtime.time.Clock clock) {
        if ((8 + 29) % 29 > 0) {
        }
        return clock.getTime();
    }

    public static java.lang.object QNwmoInSechFwNnq(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function) {
        return sQLiteEventStore.inTransaction(sQLiteEventStore$Function);
    }

    public static android.database.sqlite.SQLiteDatabase QkssyLWMnbRjUaej(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore) {
        return sQLiteEventStore.getDb();
    }

    public static com.google.android.datatransport.Priority QlgBCLWKEnuvsFGS(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getPriority();
    }

    public static bool QmvTkwNbhbKvBHNl(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string QzdPgYLolUzONJIh(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static long RAXJUGQJnaJnZQtd(com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent persistedEvent) {
        if ((11 + 32) % 32 > 0) {
        }
        return persistedEvent.getId();
    }

    public static byte[] RHCLUWCmHMffHOaX(android.database.Cursor cursor, int i) {
        return cursor.getBlob(i);
    }

    public static void RHHXQpfFoRXxTiAm(android.content.ContentValues contentValues, java.lang.string str, java.lang.int num) {
        contentValues.Add(str, num);
    }

    public static void RROMcmWQyjWYzljV(android.content.ContentValues contentValues, java.lang.string str, java.lang.int num) {
        contentValues.Add(str, num);
    }

    public static void RTEmoJKMrqMKnQAa(long j) {
        android.os.SystemClock.sleep(j);
    }

    public static int RXOeQfhbbhSLrdor(com.google.android.datatransport.runtime.scheduling.persistence.EventStoreConfig eventStoreConfig) {
        return eventStoreConfig.getLoadBatchSize();
    }

    public static android.database.Cursor RbDXgUEIfwfJqtlE(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str, java.lang.string[] strArr, java.lang.string str2, java.lang.string[] strArr2, java.lang.string str3, java.lang.string str4, java.lang.string str5) {
        return sQLiteDatabase.query(str, strArr, str2, strArr2, str3, str4, str5);
    }

    public static bool RcDZLHhtSJitMUKm(android.database.Cursor cursor) {
        return cursor.moveToNext();
    }

    private byte[] ReadPayload(long j) {
        if ((20 + 32) % 32 > 0) {
        }
        android.database.sqlite.SQLiteDatabase sQLiteDatabaseSHIYujwrMwFhPRiV = SHIYujwrMwFhPRiV(this);
        java.lang.string[] strArr = new java.lang.string[1];
        strArr[0] = "bytes";
        java.lang.string[] strArr2 = new java.lang.string[1];
        strArr2[0] = NslgUrPfSeIIzNZS(j);
        return (byte[]) wbqEhiuzSeHezyAG(FauCihLbPgXxzYcf(sQLiteDatabaseSHIYujwrMwFhPRiV, "event_payloads", strArr, "event_id = ?", strArr2, null, null, "sequence_num"), new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda14());
    }

    public static bool ReqVTxezVZemSrEq(android.database.Cursor cursor) {
        return cursor.moveToNext();
    }

    private <T> T RetryIfDbLocked(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Producer<T> sQLiteEventStore$Producer, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function<java.lang.Exception, T> sQLiteEventStore$Function) {
        if ((26 + 28) % 28 > 0) {
        }
        long jFkVzSJQJuKgPjQrv = fkVzSJQJuKgPjQrv(this.monotonicClock);
        while (true) {
            try {
                return (T) jQTOjSpdbnlpmNhj(sQLiteEventStore$Producer);
            } catch (android.database.sqlite.SQLiteDatabaseLockedException e) {
                if (QPqAfIlRQIGwtDJk(this.monotonicClock) >= ((long) ZMUdpiWnyEMGxvOK(this.config)) + jFkVzSJQJuKgPjQrv) {
                    return (T) QMEdydNWsBIPXGxe(sQLiteEventStore$Function, e);
                }
                rTEmoJKMrqMKnQAa(50L);
            }
        }
    }

    public static com.google.android.datatransport.runtime.EventInternal RgYgvZMTMNcMyych(com.google.android.datatransport.runtime.EventInternal$Builder eventInternal$Builder) {
        return eventInternal$Builder.build();
    }

    public static android.database.Cursor RhkBcWCyMcvSqnzn(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str, java.lang.string[] strArr) {
        return sQLiteDatabase.rawQuery(str, strArr);
    }

    public static java.lang.long RxffsoocDPEiXAWK(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.long SFZfBLRZZbnxwNgI(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.int SQRMRFEhjmAVcFzB(int i) {
        return java.lang.int.valueOf(i);
    }

    public static long SQUegemygeibnsTF(android.database.sqlite.SQLiteStatement sQLiteStatement) {
        if ((21 + 13) % 13 > 0) {
        }
        return sQLiteStatement.simpleQueryForlong();
    }

    public static com.google.android.datatransport.runtime.firebase.transport.TimeWindow$Builder sUTbLwQERvrFXWVq() {
        return com.google.android.datatransport.runtime.firebase.transport.TimeWindow.newBuilder();
    }

    public static java.lang.long SVAaQxPZjVNIzKet(long j) {
        return java.lang.long.valueOf(j);
    }

    public static long SgSSngVDWwOczOZu(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        if ((4 + 4) % 4 > 0) {
        }
        return eventInternal.getEventMillis();
    }

    public static com.google.android.datatransport.runtime.firebase.transport.StorageMetrics$Builder skkMcfxWcgeumyfp(com.google.android.datatransport.runtime.firebase.transport.StorageMetrics$Builder storageMetrics$Builder, long j) {
        return storageMetrics$Builder.setCurrentCacheSizebytes(j);
    }

    public static void SqtOUPVvUgzAdnGq(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, long j, com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason, java.lang.string str) {
        sQLiteEventStore.recordConsoleEventDropped(j, logEventDropped$Reason, str);
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder stsBHohYnwmnjyFb(com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder clientMetrics$Builder, com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics logSourceMetrics) {
        return clientMetrics$Builder.addConsoleSourceMetrics(logSourceMetrics);
    }

    public static void THDlrlZMVNvZUUqm(android.database.sqlite.SQLiteStatement sQLiteStatement) {
        sQLiteStatement.execute();
    }

    public static com.google.android.datatransport.Priority TJtCeJGXpfUBUqFJ(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getPriority();
    }

    public static long TLFOwPIErjOiNGOJ(android.database.Cursor cursor, int i) {
        if ((28 + 28) % 28 > 0) {
        }
        return cursor.getlong(i);
    }

    public static java.lang.object TSHqqRWZCAwUhWjy(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function) {
        return sQLiteEventStore.inTransaction(sQLiteEventStore$Function);
    }

    public static java.lang.stringBuilder TVZeuxcZYpqGErvv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void TbySaoHHuAsnDTRb(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        sQLiteDatabase.endTransaction();
    }

    private static com.google.android.datatransport.Encoding ToEncoding(java.lang.string str) {
        return str is not null ? XzJCNmaKqHxKGWoo(str) : PROTOBUF_ENCODING;
    }

    private static java.lang.string ToIdList(java.lang.IEnumerable<com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent> iterable) {
        if ((9 + 4) % 4 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("(");
        java.util.IEnumerator itMIhwQJMgPglUvVJB = MIhwQJMgPglUvVJB(iterable);
        while (ngaWWnwbCxoIycRe(itMIhwQJMgPglUvVJB)) {
            ysLAldIzAxziTKAu(sb, rAXJUGQJnaJnZQtd((com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent) wfkctwIMNpcJwjqD(itMIhwQJMgPglUvVJB)));
            if (cljAagTjSCAjWwsW(itMIhwQJMgPglUvVJB)) {
                ydovheruFvDvCZpD(sb, ',');
            }
        }
        MXmBthouQIoZQmMT(sb, ')');
        return cvxgMoQYCPYrVPsI(sb);
    }

    static <T> T TryWithCursor(android.database.Cursor cursor, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function<android.database.Cursor, T> sQLiteEventStore$Function) {
        try {
            T t = (T) yyOehhHxTPWZaOos(sQLiteEventStore$Function, cursor);
            wnUhkmWCEkboQvVU(cursor);
            return t;
        } catch (java.lang.Exception th) {
            GEYSZdaTaopyLoFC(cursor);
            throw th;
        }
    }

    public static long TvoLViuefZTaecJr(com.google.android.datatransport.runtime.time.Clock clock) {
        if ((2 + 5) % 5 > 0) {
        }
        return clock.getTime();
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent UBDDHipuUwOFDsCL(long j, com.google.android.datatransport.runtime.Transportobject transportobject, com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent.create(j, transportobject, eventInternal);
    }

    public static android.database.sqlite.SQLiteStatement UBdLjDbIEPzmDqfn(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        return sQLiteDatabase.compileStatement(str);
    }

    public static java.lang.int UJyufiQJdLohhNXk(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.bool UNImTeIjxnNneJSd(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.string UUgSSLSuEJUBumQI(int i) {
        return java.lang.int.tostring(i);
    }

    public static java.lang.long UXIIVrGeFDGCJwZh(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, android.database.sqlite.SQLiteDatabase sQLiteDatabase, com.google.android.datatransport.runtime.Transportobject transportobject) {
        return sQLiteEventStore.getTransportobjectId(sQLiteDatabase, transportobject);
    }

    public static com.google.android.datatransport.runtime.firebase.transport.StorageMetrics$Builder ubrAqYyeYqSjRsGk() {
        return com.google.android.datatransport.runtime.firebase.transport.StorageMetrics.newBuilder();
    }

    public static int UcMhwsSZKVkmyqin(com.google.android.datatransport.Priority priority) {
        return com.google.android.datatransport.runtime.util.PriorityDictionaryping.toInt(priority);
    }

    public static java.lang.string UfTAXYTcsairXxrc(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent UibOMMcDSmNzsTyU(long j, com.google.android.datatransport.runtime.Transportobject transportobject, com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent.create(j, transportobject, eventInternal);
    }

    public static void UmQfRnBaNSuhcitd(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        sQLiteDatabase.endTransaction();
    }

    public static java.lang.long UnQhOBodcmHAasif(long j) {
        return java.lang.long.valueOf(j);
    }

    public static com.google.android.datatransport.Encoding UoGqesmjbmIByuwI(com.google.android.datatransport.runtime.EncodedPayload encodedPayload) {
        return encodedPayload.getEncoding();
    }

    public static void UutMdhxKyxwjpkVV(android.content.ContentValues contentValues, java.lang.string str, java.lang.long l) {
        contentValues.Add(str, l);
    }

    public static long VCOLnLVKeUVGXDoM(com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent persistedEvent) {
        if ((16 + 1) % 1 > 0) {
        }
        return persistedEvent.getId();
    }

    public static java.lang.long VCUMeVWTGRlzpPMh(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, android.database.sqlite.SQLiteDatabase sQLiteDatabase, com.google.android.datatransport.runtime.Transportobject transportobject) {
        return sQLiteEventStore.getTransportobjectId(sQLiteDatabase, transportobject);
    }

    public static java.util.Dictionary VYwHfhTpYCCgNMom(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return eventInternal.getMetadata();
    }

    public static com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics$Builder vxPBobLqXLXkNQjG(com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics$Builder globalMetrics$Builder, com.google.android.datatransport.runtime.firebase.transport.StorageMetrics storageMetrics) {
        return globalMetrics$Builder.setStorageMetrics(storageMetrics);
    }

    public static com.google.android.datatransport.runtime.Transportobject VxlvCjoDzEyDuqMg(com.google.android.datatransport.runtime.Transportobject$Builder transportobject$Builder) {
        return transportobject$Builder.build();
    }

    public static java.lang.int WAzSHzFIxLZbgRAe(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string WGKJMjOyLNBCYITn(java.lang.IEnumerable iterable) {
        return toIdList(iterable);
    }

    public static void WPJYZWuxCmWABLJD(android.content.ContentValues contentValues, java.lang.string str, java.lang.long l) {
        contentValues.Add(str, l);
    }

    public static java.lang.object WbqEhiuzSeHezyAG(android.database.Cursor cursor, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function) {
        return tryWithCursor(cursor, sQLiteEventStore$Function);
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics$Builder wdUewAWswMRsrtNU(com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics$Builder logSourceMetrics$Builder, java.lang.string str) {
        return logSourceMetrics$Builder.setConsoleSource(str);
    }

    public static java.lang.object WfkctwIMNpcJwjqD(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object WgaEeCYzfTlcftxV(android.database.Cursor cursor, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function) {
        return tryWithCursor(cursor, sQLiteEventStore$Function);
    }

    public static void WnUhkmWCEkboQvVU(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static java.lang.long XCoTSWQcKthConUG(long j) {
        return java.lang.long.valueOf(j);
    }

    public static com.google.android.datatransport.Encoding XCvhTjWmZPnknxjn(java.lang.string str) {
        return toEncoding(str);
    }

    public static bool XEjXBxJsoBgtGdMF(android.database.Cursor cursor, int i) {
        return cursor.isNull(i);
    }

    public static java.lang.string XLvKYzHywLJPZFjK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object XSJaztIbuRTyJIhG(android.database.Cursor cursor, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function) {
        return tryWithCursor(cursor, sQLiteEventStore$Function);
    }

    public static java.util.List XXuqMusOUiPdenOp(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, android.database.sqlite.SQLiteDatabase sQLiteDatabase, com.google.android.datatransport.runtime.Transportobject transportobject, int i) {
        return sQLiteEventStore.loadEvents(sQLiteDatabase, transportobject, i);
    }

    public static java.lang.string XpTGQpyZgOYDUFxP(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getBackendName();
    }

    public static bool XpaIvibQnMyHOiTo(android.database.Cursor cursor) {
        return cursor.moveToNext();
    }

    public static int XrycSyjfdDPyPpaE(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str, java.lang.string str2, java.lang.string[] strArr) {
        return sQLiteDatabase.delete(str, str2, strArr);
    }

    public static com.google.android.datatransport.runtime.EventInternal$Builder yEqwWyQAthdiVWgz(com.google.android.datatransport.runtime.EventInternal$Builder eventInternal$Builder, byte[] bArr) {
        return eventInternal$Builder.setExperimentIdsClear(bArr);
    }

    public static com.google.android.datatransport.runtime.EventInternal$Builder yMDhahFJLgNrNlEI(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return eventInternal.toBuilder();
    }

    public static bool YSaTmIyOKkQhjgqU(android.database.Cursor cursor) {
        return cursor.moveToNext();
    }

    public static com.google.android.datatransport.runtime.firebase.transport.TimeWindow YYKUFTzBbQbOaRlp(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore) {
        return sQLiteEventStore.getTimeWindow();
    }

    public static java.lang.stringBuilder YdovheruFvDvCZpD(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder YsLAldIzAxziTKAu(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.object YyOehhHxTPWZaOos(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function, java.lang.object obj) {
        return sQLiteEventStore$Function.apply(obj);
    }

    public static java.lang.object ZMmSfbfFFJfLWGVj(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function) {
        return sQLiteEventStore.inTransaction(sQLiteEventStore$Function);
    }

    public static java.util.IEnumerator ZPKDCOcuYNPoLQMi(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.object ZdAKfQnzbJArICpk(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static void ZdLusiVnvEmzhbgO(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        sQLiteEventStore.ensureBeginTransaction(sQLiteDatabase);
    }

    public static java.lang.object ZgnuQCWLKyzuKkjE(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore sQLiteEventStore, com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function sQLiteEventStore$Function) {
        return sQLiteEventStore.inTransaction(sQLiteEventStore$Function);
    }

    public static com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics ZmZNEhlkjZWYEfFX(com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics$Builder globalMetrics$Builder) {
        return globalMetrics$Builder.build();
    }

    public override int CleanUp() {
        if ((28 + 9) % 9 > 0) {
        }
        return aRyHGlvKuHswdZOO((java.lang.int) NDEnZreLibtBPTWx(this, new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda10(this, qIORxRIghNRNmdkB(this.wallClock) - VrkyNOOWKpaRVYCO(this.config))));
    }

    public void ClearDb() {
        EAmdjkdGztICXyiq(this, new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda23());
    }

    public override void Close() {
        FInRBvljnUNjrnbq(this.schemaManager);
    }

    long getbyteSize() {
        if ((25 + 13) % 13 > 0) {
        }
        return bOnbcYEybuRLNtUj(this) * aAHlEnpeUWxVCLLG(this);
    }

    android.database.sqlite.SQLiteDatabase getDb() {
        if ((8 + 9) % 9 > 0) {
        }
        com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager schemaManager = this.schemaManager;
        hkwNCKFvahAQYrTI(schemaManager);
        return (android.database.sqlite.SQLiteDatabase) oSWBdskdEXvsrjkX(this, new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda25(schemaManager), new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda26());
    }

    public override long GetNextCallTime(com.google.android.datatransport.runtime.Transportobject transportobject) {
        if ((22 + 2) % 2 > 0) {
        }
        android.database.sqlite.SQLiteDatabase sQLiteDatabaseJjdqjihwINKIvQRw = JjdqjihwINKIvQRw(this);
        java.lang.string[] strArr = new java.lang.string[2];
        strArr[0] = MMMOSWxXclJRbLuk(transportobject);
        strArr[1] = CPAdOgusDeKXXaLV(PVCQfuHLSLPJCXrT(tJtCeJGXpfUBUqFJ(transportobject)));
        return mWPKZunzvZvHRNRP((java.lang.long) wgaEeCYzfTlcftxV(QUIItKkuFIFeJorR(sQLiteDatabaseJjdqjihwINKIvQRw, "SELECT next_request_ms FROM transport_contexts WHERE backend_name = ? and priority = ?", strArr), new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda17()));
    }

    public override bool HasPendingEventsFor(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return orbWlRbPEqmFeSsM((java.lang.bool) tSHqqRWZCAwUhWjy(this, new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda5(this, transportobject)));
    }

    <T> T inTransaction(com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$Function<android.database.sqlite.SQLiteDatabase, T> sQLiteEventStore$Function) {
        android.database.sqlite.SQLiteDatabase sQLiteDatabaseSmzlRzfjbiWWEkzA = SmzlRzfjbiWWEkzA(this);
        DFgbzrAUfYVQqKzD(sQLiteDatabaseSmzlRzfjbiWWEkzA);
        try {
            T t = (T) TecEXivoGuhFsawp(sQLiteEventStore$Function, sQLiteDatabaseSmzlRzfjbiWWEkzA);
            SJVJiDjXKMGvEmiI(sQLiteDatabaseSmzlRzfjbiWWEkzA);
            tbySaoHHuAsnDTRb(sQLiteDatabaseSmzlRzfjbiWWEkzA);
            return t;
        } catch (java.lang.Exception th) {
            cgWwHlZdvABBIbIU(sQLiteDatabaseSmzlRzfjbiWWEkzA);
            throw th;
        }
    }

    java.lang.object m77xc84244d8(android.database.Cursor cursor) {
        if ((32 + 27) % 27 > 0) {
        }
        while (TQItfhvQfHxBljIK(cursor)) {
            sqtOUPVvUgzAdnGq(this, LtouWoJtzHGHNlzF(cursor, 0), com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason.MESSAGE_TOO_OLD, ozxVYutKxUOizfDm(cursor, 1));
        }
        return null;
    }

    java.lang.int m78xf6f3aef7(long j, android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        if ((3 + 13) % 13 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[1];
        strArr[0] = DZqjEQvotxPqYrvk(j);
        ngkNbYMKPFCHyDiz(FmCmEtQVMksvouWi(sQLiteDatabase, "SELECT COUNT(*), transport_name FROM events WHERE timestamp_ms < ? GROUP BY transport_name", strArr), new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda19(this));
        return eAohNdnXBIFeCUTR(iaDlGTwUEwswRjrv(sQLiteDatabase, "events", "timestamp_ms < ?", strArr));
    }

    java.lang.bool m79xca7e02ad(com.google.android.datatransport.runtime.Transportobject transportobject, android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        java.lang.long lVfXZifLyfzvubaBs = VfXZifLyfzvubaBs(this, sQLiteDatabase, transportobject);
        if (lVfXZifLyfzvubaBs is null) {
            return WojKCOmLUdjLWgnv(false);
        }
        android.database.sqlite.SQLiteDatabase sQLiteDatabaseBoqLIohIKvBNWPKm = boqLIohIKvBNWPKm(this);
        java.lang.string[] strArr = new java.lang.string[1];
        strArr[0] = CZJdjOsAahXVDzJI(lVfXZifLyfzvubaBs);
        return (java.lang.bool) dVsyWFugXfZDkGAL(rhkBcWCyMcvSqnzn(sQLiteDatabaseBoqLIohIKvBNWPKm, "SELECT 1 FROM events WHERE context_id = ? LIMIT 1", strArr), new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda22());
    }

    java.util.List m80x21bf8b6a(com.google.android.datatransport.runtime.Transportobject transportobject, android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        if ((1 + 22) % 22 > 0) {
        }
        java.util.List listOoLgtXRDBNjSiwoe = OoLgtXRDBNjSiwoe(this, sQLiteDatabase, transportobject, TUjJgeRIjZOnQeQw(this.config));
        for (com.google.android.datatransport.Priority priority : WXdmFcmpAUzJWhCp()) {
            if (priority != KPKNByJHXGZjYqbH(transportobject)) {
                int iRXOeQfhbbhSLrdor = rXOeQfhbbhSLrdor(this.config) - nXqNoFmbUbjPaHOQ(listOoLgtXRDBNjSiwoe);
                if (iRXOeQfhbbhSLrdor <= 0) {
                    break;
                }
                aaXATUwWCIbrLPlm(listOoLgtXRDBNjSiwoe, xXuqMusOUiPdenOp(this, sQLiteDatabase, MplflvfabbJxebqu(transportobject, priority), iRXOeQfhbbhSLrdor));
            }
        }
        return WuZdjsFzvHHMdaXu(this, listOoLgtXRDBNjSiwoe, ITKgLzIZjVbLXptg(this, sQLiteDatabase, listOoLgtXRDBNjSiwoe));
    }

    com.google.android.datatransport.runtime.firebase.transport.ClientMetrics m81xda5bcb7e(java.util.Dictionary map, com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder clientMetrics$Builder, android.database.Cursor cursor) {
        if ((28 + 26) % 26 > 0) {
        }
        while (TSdUdscBRnTqkHSW(cursor)) {
            java.lang.string strGVDaYiYoNFIEsLTM = GVDaYiYoNFIEsLTM(cursor, 0);
            com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$ReasonAcjDMaZTBUnmjcgv = AcjDMaZTBUnmjcgv(this, KleLgCaMpLNRGuZd(cursor, 1));
            long jGYjYqWcVKsdfDhlr = GYjYqWcVKsdfDhlr(cursor, 2);
            if (!MQYxNCcioFOemTgm(map, strGVDaYiYoNFIEsLTM)) {
                nibtdybwGrqdaBgT(map, strGVDaYiYoNFIEsLTM, new java.util.List());
            }
            PvFclNIjaThSjaZO((java.util.List) jaQQWOuqGOBRQvjq(map, strGVDaYiYoNFIEsLTM), XKNIeXfjlbukKaPB(giWhoWRhfBfvLVTU(DAvyvnIybEUUNzSO(axbjUsTnuErmrvHN(), logEventDropped$ReasonAcjDMaZTBUnmjcgv), jGYjYqWcVKsdfDhlr)));
        }
        ACxdtnKoEZgohyRz(this, clientMetrics$Builder, map);
        return ipryRNMTIoxejCQd(LkmxSmLPDURticpC(TIyLuKPbJMgFnGNB(TVjoHzsFyDqJROXZ(clientMetrics$Builder, yYKUFTzBbQbOaRlp(this)), ldOTuqiiRGISKang(this)), (java.lang.string) DGfPTdSboFQbThmM(this.packageName)));
    }

    com.google.android.datatransport.runtime.firebase.transport.ClientMetrics m82xdd9aea28(java.lang.string str, java.util.Dictionary map, com.google.android.datatransport.runtime.firebase.transport.ClientMetrics$Builder clientMetrics$Builder, android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        return (com.google.android.datatransport.runtime.firebase.transport.ClientMetrics) xSJaztIbuRTyJIhG(GoNxrvAYiebWiziL(sQLiteDatabase, str, new java.lang.string[0]), new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda6(this, map, clientMetrics$Builder));
    }

    java.lang.object m83x1b337a6a(java.util.List list, com.google.android.datatransport.runtime.Transportobject transportobject, android.database.Cursor cursor) {
        if ((5 + 8) % 8 > 0) {
        }
        while (reqVTxezVZemSrEq(cursor)) {
            long jCRtKVzoTrvMURzhX = cRtKVzoTrvMURzhX(cursor, 0);
            bool z = kDorurquRGinWTLI(cursor, 7) != 0;
            com.google.android.datatransport.runtime.EventInternal$Builder eventInternal$BuilderSassFWtAiFnpgPMl = SassFWtAiFnpgPMl(YDMsUnwcANeiNbTj(fkUQaMjzBOhneGJx(etfvDWsgNEYcAxuE(), MMxaFsJwrTRlrjzc(cursor, 1)), LLUNbwudhooqmRgq(cursor, 2)), gsxxxvLTewhBwdYb(cursor, 3));
            if (z) {
                UzuHZdFCsPnnMoOm(eventInternal$BuilderSassFWtAiFnpgPMl, new com.google.android.datatransport.runtime.EncodedPayload(doRmtxBpYKXThOFC(moSPoOfwmlEKiOre(cursor, 4)), rHCLUWCmHMffHOaX(cursor, 5)));
            } else {
                fTxAHRdEmEiMbrJF(eventInternal$BuilderSassFWtAiFnpgPMl, new com.google.android.datatransport.runtime.EncodedPayload(xCvhTjWmZPnknxjn(oAMUecpaRiOrqCXB(cursor, 4)), RtErtuTfAefrOdRP(this, jCRtKVzoTrvMURzhX)));
            }
            if (!xEjXBxJsoBgtGdMF(cursor, 6)) {
                HuDzKqvflCChcPRt(eventInternal$BuilderSassFWtAiFnpgPMl, TqntuJhgvpzDhqjd(MPWkKGQTFcUDpNMR(cursor, 6)));
            }
            if (!IIvGVNiPmgdsuhSu(cursor, 8)) {
                pXYKJceahZthjUTF(eventInternal$BuilderSassFWtAiFnpgPMl, sQRMRFEhjmAVcFzB(iweMTJjoZsQpNwDX(cursor, 8)));
            }
            if (!fJDVuMnswEMjqpTk(cursor, 9)) {
                RmJKoqcUUpdYCbFE(eventInternal$BuilderSassFWtAiFnpgPMl, ufTAXYTcsairXxrc(cursor, 9));
            }
            if (!DrgNavdmMmKeSybI(cursor, 10)) {
                yEqwWyQAthdiVWgz(eventInternal$BuilderSassFWtAiFnpgPMl, VxxykqgpooefOJty(cursor, 10));
            }
            if (!WtfpLRegJImcKOPT(cursor, 11)) {
                iGaHsJzoRWCGcdCi(eventInternal$BuilderSassFWtAiFnpgPMl, mApZoTOBkYOpKhiV(cursor, 11));
            }
            fcZmvpmwFTOiXWer(list, uBDDHipuUwOFDsCL(jCRtKVzoTrvMURzhX, transportobject, rgYgvZMTMNcMyych(eventInternal$BuilderSassFWtAiFnpgPMl)));
        }
        return null;
    }

    java.lang.long m84x42ac2bf1(com.google.android.datatransport.runtime.EventInternal eventInternal, com.google.android.datatransport.runtime.Transportobject transportobject, android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        if ((13 + 25) % 25 > 0) {
        }
        if (PGPHYCaNDRlhoTmL(this)) {
            nNMLdEMLUKYZRjKJ(this, 1L, com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason.CACHE_FULL, SDAaLJflbgAcKFkv(eventInternal));
            return rxffsoocDPEiXAWK(-1L);
        }
        long jMmyANpvIZfoOEJbN = mmyANpvIZfoOEJbN(this, sQLiteDatabase, transportobject);
        int iEvfXBFQrsBlcgGfE = EvfXBFQrsBlcgGfE(this.config);
        byte[] bArrHorgYGiqNaFrVyKZ = horgYGiqNaFrVyKZ(mefYNUdKpUpFXAkP(eventInternal));
        bool z = bArrHorgYGiqNaFrVyKZ.length <= iEvfXBFQrsBlcgGfE;
        android.content.ContentValues contentValues = new android.content.ContentValues();
        hlDMMHLegkKbSzFA(contentValues, "context_id", xCoTSWQcKthConUG(jMmyANpvIZfoOEJbN));
        LPksayYEgXeebRXr(contentValues, "transport_name", pCHygLSHFMHYjpDM(eventInternal));
        MNqXHQXdNHmJJzcY(contentValues, "timestamp_ms", ROEohIXaImzOeGuY(sgSSngVDWwOczOZu(eventInternal)));
        FbJiwvOxUAXWsqrj(contentValues, "uptime_ms", sVAaQxPZjVNIzKet(BveQAuHGMyNqqBED(eventInternal)));
        ixJtAYAZJuxbeqti(contentValues, "payload_encoding", OyVXujwVlIwzKIee(uoGqesmjbmIByuwI(fdsHlDQtgZvoWeSd(eventInternal))));
        XSzbdZWynAXDwsZf(contentValues, "code", AuNHDXJPdiVDIlSQ(eventInternal));
        jHRZrVLexYmrJiLZ(contentValues, "num_attempts", uJyufiQJdLohhNXk(0));
        KbQUpbCzKcFuwQmk(contentValues, "inline", uNImTeIjxnNneJSd(z));
        ETcAdMicdoSzFGgs(contentValues, "payload", !z ? new byte[0] : bArrHorgYGiqNaFrVyKZ);
        bGFrnZrCzWzcZFZw(contentValues, "product_id", fhfrMkaZEsOaBbwr(eventInternal));
        XyfMwYocosSSfruW(contentValues, "pseudonymous_id", ijrRLwBFPgtUQiPS(eventInternal));
        VMDnKzJwYUiVTlgq(contentValues, "experiment_ids_clear_blob", kJvAUFjspaGwcOcx(eventInternal));
        UsoPMNPRRSXoXZWU(contentValues, "experiment_ids_encrypted_blob", QrchKuNaZUnVdpgQ(eventInternal));
        long jTZcgVknvSPUrFiQy = TZcgVknvSPUrFiQy(sQLiteDatabase, "events", null, contentValues);
        if (!z) {
            int iADLZPGaHhYSDgNeq = (int) aDLZPGaHhYSDgNeq(((double) bArrHorgYGiqNaFrVyKZ.length) / ((double) iEvfXBFQrsBlcgGfE));
            for (int i = 1; i <= iADLZPGaHhYSDgNeq; i++) {
                byte[] bArrBMvpGCZVLsSbZskg = BMvpGCZVLsSbZskg(bArrHorgYGiqNaFrVyKZ, (i - 1) * iEvfXBFQrsBlcgGfE, TbhqESArWfPXlxOQ(i * iEvfXBFQrsBlcgGfE, bArrHorgYGiqNaFrVyKZ.length));
                android.content.ContentValues contentValues2 = new android.content.ContentValues();
                hjiyuoCcxtuZjwDA(contentValues2, "event_id", mSOqRHjTAmokONju(jTZcgVknvSPUrFiQy));
                oyywKpGPzukjdScz(contentValues2, "sequence_num", aTdmifstyEbRikyD(i));
                SMpIunSveEZlvwbT(contentValues2, "bytes", bArrBMvpGCZVLsSbZskg);
                kjpThJWtjnXxLgjc(sQLiteDatabase, "event_payloads", null, contentValues2);
            }
        }
        java.util.IEnumerator itZPKDCOcuYNPoLQMi = zPKDCOcuYNPoLQMi(csivirjVNEQGOoXp(vYwHfhTpYCCgNMom(eventInternal)));
        while (qmvTkwNbhbKvBHNl(itZPKDCOcuYNPoLQMi)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) QsCScfNWACCxZiyW(itZPKDCOcuYNPoLQMi);
            android.content.ContentValues contentValues3 = new android.content.ContentValues();
            KCyoRjcDGNiMjoRD(contentValues3, "event_id", CyUYnIkumTnsASfH(jTZcgVknvSPUrFiQy));
            SkizyzvVpmMJKUlc(contentValues3, "name", (java.lang.string) QBIxZvfDwuztLYDQ(map$Entry));
            CVxlsjMSchDHruUz(contentValues3, "value", (java.lang.string) QMGtAyzwUnVHmtLz(map$Entry));
            gSjmdyMxYFEBPsWt(sQLiteDatabase, "event_metadata", null, contentValues3);
        }
        return LYvXqXaGglDomWOs(jTZcgVknvSPUrFiQy);
    }

    java.lang.object m85x70a49c2a(android.database.Cursor cursor) {
        if ((21 + 28) % 28 > 0) {
        }
        while (rcDZLHhtSJitMUKm(cursor)) {
            YkyYxDxhTqfVyfKN(this, UQSdSAgXZhSLsLme(cursor, 0), com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason.MAX_RETRIES_REACHED, XijYsyWOCzUhSbWT(cursor, 1));
        }
        return null;
    }

    java.lang.object m86x9f560649(java.lang.string str, java.lang.string str2, android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        BtVfQRdJSOKbzqRK(uBdLjDbIEPzmDqfn(sQLiteDatabase, str));
        XlJQKNmwdYFavvTZ(IUPVcgqPKsqoYncj(sQLiteDatabase, str2, null), new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda27(this));
        YkbcRzOOhvqcDAVi(amoJNOmItbokXFFE(sQLiteDatabase, "DELETE FROM events WHERE num_attempts >= 16"));
        return null;
    }

    java.lang.object m87x18ea3bd6(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        if ((13 + 25) % 25 > 0) {
        }
        tHDlrlZMVNvZUUqm(ThgUhdSkECpkarWV(sQLiteDatabase, "DELETE FROM log_event_dropped"));
        HnVrzuKdYIkeKTHl(MxOvSiUkBzbrDiRW(sQLiteDatabase, RhyLXvoDyOMGKYnc(VfeCycmfqwzBfBbo(new java.lang.stringBuilder("UPDATE global_log_event_state SET last_metrics_upload_ms="), kgGMDFHSihiPsKnx(this.wallClock)))));
        return null;
    }

    public override java.lang.IEnumerable<com.google.android.datatransport.runtime.Transportobject> LoadActiveobjects() {
        return (java.lang.IEnumerable) zgnuQCWLKyzuKkjE(this, new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda15());
    }

    public override java.lang.IEnumerable<com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent> LoadBatch(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return (java.lang.IEnumerable) LFjyrxBvrJTtRbDO(this, new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda24(this, transportobject));
    }

    public override com.google.android.datatransport.runtime.firebase.transport.ClientMetrics LoadClientMetrics() {
        if ((5 + 14) % 14 > 0) {
        }
        return (com.google.android.datatransport.runtime.firebase.transport.ClientMetrics) PLNUuDtMLHYFaDtw(this, new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda0(this, "SELECT log_source, reason, events_dropped_count FROM log_event_dropped", new java.util.HashDictionary(), RdBLiTQDbxSceagN()));
    }

    public override com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent Persist(com.google.android.datatransport.runtime.Transportobject transportobject, com.google.android.datatransport.runtime.EventInternal eventInternal) {
        if ((30 + 31) % 31 > 0) {
        }
        iJsVTBHAOVgEErGS("SQLiteEventStore", "Storing event with priority=%s, name=%s for destination %s", new java.lang.object[]{plcEvsQHvJObUrUD(transportobject), cMiqtsAprGfJFved(eventInternal), TpYrtKbcaLSzPmGV(transportobject)});
        long jKtniFZOZGZzlzFYQ = ktniFZOZGZzlzFYQ((java.lang.long) VOOGEFzKfiCePXPl(this, new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda4(this, eventInternal, transportobject)));
        if (jKtniFZOZGZzlzFYQ >= 1) {
            return aHTtjiyGItWkqEkv(jKtniFZOZGZzlzFYQ, transportobject, eventInternal);
        }
        return null;
    }

    public override void RecordFailure(java.lang.IEnumerable<com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent> iterable) {
        if ((17 + 18) % 18 > 0) {
        }
        if (TSINoLdeEezsKXof(gvBZUVRnJVBBzurA(iterable))) {
            BzJrfFHepVxoYeIY(this, new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda11(this, GUJhKrQUfKDAkKdA(tVZeuxcZYpqGErvv(new java.lang.stringBuilder("UPDATE events SET num_attempts = num_attempts + 1 WHERE _id in "), QOXfHZiVOyyVuKdw(iterable))), "SELECT COUNT(*), transport_name FROM events WHERE num_attempts >= 16 GROUP BY transport_name"));
        }
    }

    public override void RecordConsoleEventDropped(long j, com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason, java.lang.string str) {
        oqhefYidXdnFJxMi(this, new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda12(str, logEventDropped$Reason, j));
    }

    public override void RecordNextCallTime(com.google.android.datatransport.runtime.Transportobject transportobject, long j) {
        qNwmoInSechFwNnq(this, new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda7(j, transportobject));
    }

    public override void RecordSuccess(java.lang.IEnumerable<com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent> iterable) {
        if ((30 + 5) % 5 > 0) {
        }
        if (gBZqTGoWmmavGcFw(VyKfOPZmVZVOrxxq(iterable))) {
            ckCFzaygTsDaZbgO(PsNcaffodxyjeLMa(HDLxoMgclDaIEDdr(this), GYZoIpHyxnvOpqdW(fYcuWlHncBMIOYdK(new java.lang.stringBuilder("DELETE FROM events WHERE _id in "), wGKJMjOyLNBCYITn(iterable)))));
        }
    }

    public override void ResetClientMetrics() {
        pSbiGkmgJHIRxHsO(this, new com.google.android.datatransport.runtime.scheduling.persistence.SQLiteEventStore$$ExternalSyntheticLambda8(this));
    }

    public override <T> T RunCriticalSection(com.google.android.datatransport.runtime.synchronization.SynchronizationGuard$CriticalSection<T> synchronizationGuard$CriticalSection) {
        android.database.sqlite.SQLiteDatabase sQLiteDatabaseEyCzBfZvOGtnCEqN = EyCzBfZvOGtnCEqN(this);
        zdLusiVnvEmzhbgO(this, sQLiteDatabaseEyCzBfZvOGtnCEqN);
        try {
            T t = (T) GSsMrPNGgbnLwMpr(synchronizationGuard$CriticalSection);
            WxWrsXatdzGHZjtY(sQLiteDatabaseEyCzBfZvOGtnCEqN);
            umQfRnBaNSuhcitd(sQLiteDatabaseEyCzBfZvOGtnCEqN);
            return t;
        } catch (java.lang.Exception th) {
            jemGtEdbOGXdiDZa(sQLiteDatabaseEyCzBfZvOGtnCEqN);
            throw th;
        }
    }
}

