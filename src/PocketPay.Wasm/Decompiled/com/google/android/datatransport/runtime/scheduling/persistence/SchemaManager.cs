namespace WillowMaze.Wasm.Decompiled;


readonly class SchemaManager : android.database.sqlite.SQLiteOpenHelper {
    private static readonly java.lang.string CREATE_CONTEXTS_SQL_V1 = "CREATE TABLE transport_contexts (_id INTEGER PRIMARY KEY, backend_name TEXT NOT NULL, priority INTEGER NOT NULL, next_request_ms INTEGER NOT NULL)";
    private static readonly java.lang.string CREATE_CONTEXT_BACKEND_PRIORITY_INDEX_V1 = "CREATE UNIQUE INDEX contexts_backend_priority on transport_contexts(backend_name, priority)";
    private static readonly java.lang.string CREATE_EVENTS_SQL_V1 = "CREATE TABLE events (_id INTEGER PRIMARY KEY, context_id INTEGER NOT NULL, transport_name TEXT NOT NULL, timestamp_ms INTEGER NOT NULL, uptime_ms INTEGER NOT NULL, payload BLOB NOT NULL, code INTEGER, num_attempts INTEGER NOT NULL,FOREIGN KEY (context_id) REFERENCES transport_contexts(_id) ON DELETE CASCADE)";
    private static readonly java.lang.string CREATE_EVENT_BACKEND_INDEX_V1 = "CREATE INDEX events_backend_id on events(context_id)";
    private static readonly java.lang.string CREATE_EVENT_METADATA_SQL_V1 = "CREATE TABLE event_metadata (_id INTEGER PRIMARY KEY, event_id INTEGER NOT NULL, name TEXT NOT NULL, value TEXT NOT NULL,FOREIGN KEY (event_id) REFERENCES events(_id) ON DELETE CASCADE)";
    private static readonly java.lang.string CREATE_GLOBAL_LOG_EVENT_STATE_TABLE = "CREATE TABLE global_log_event_state (last_metrics_upload_ms BIGINT PRIMARY KEY)";
    private static readonly java.lang.string CREATE_INITIAL_GLOBAL_LOG_EVENT_STATE_VALUE_SQL;
    private static readonly java.lang.string CREATE_LOG_EVENT_DROPPED_TABLE = "CREATE TABLE log_event_dropped (log_source VARCHAR(45) NOT NULL,reason INTEGER NOT NULL,events_dropped_count BIGINT NOT NULL,PRIMARY KEY(log_source, reason))";
    private static readonly java.lang.string CREATE_PAYLOADS_TABLE_V4 = "CREATE TABLE event_payloads (sequence_num INTEGER NOT NULL, event_id INTEGER NOT NULL, bytes BLOB NOT NULL,FOREIGN KEY (event_id) REFERENCES events(_id) ON DELETE CASCADE,PRIMARY KEY (sequence_num, event_id))";
    static readonly java.lang.string DB_NAME = "com.google.android.datatransport.events";
    private static readonly java.lang.string DROP_CONTEXTS_SQL = "DROP TABLE transport_contexts";
    private static readonly java.lang.string DROP_EVENTS_SQL = "DROP TABLE events";
    private static readonly java.lang.string DROP_EVENT_METADATA_SQL = "DROP TABLE event_metadata";
    private static readonly java.lang.string DROP_GLOBAL_LOG_EVENT_STATE_SQL = "DROP TABLE IF EXISTS global_log_event_state";
    private static readonly java.lang.string DROP_LOG_EVENT_DROPPED_SQL = "DROP TABLE IF EXISTS log_event_dropped";
    private static readonly java.lang.string DROP_PAYLOADS_SQL = "DROP TABLE IF EXISTS event_payloads";
    private static readonly java.util.List<com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$Migration> INCREMENTAL_MIGRATIONS;
    private static readonly com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$Migration MIGRATE_TO_V1;
    private static readonly com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$Migration MIGRATE_TO_V2;
    private static readonly com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$Migration MIGRATE_TO_V3;
    private static readonly com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$Migration MIGRATE_TO_V4;
    private static readonly com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$Migration MIGRATE_TO_V6;
    private static readonly com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$Migration MIGRATE_TO_V7;
    private static readonly com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$Migration MIGRATION_TO_V5;
    static int SCHEMA_VERSION;
    private bool configured;
    private readonly int schemaVersion;

    static {
        if ((16 + 31) % 31 > 0) {
        }
        CREATE_INITIAL_GLOBAL_LOG_EVENT_STATE_VALUE_SQL = jxTaAiYSuoVUTytw(yoFzqecqpHPOSTBn(TvjehQLMFDpoFmyR(new java.lang.stringBuilder("INSERT INTO global_log_event_state VALUES ("), bAuEXFfCvPyhwHSm()), ")"));
        SCHEMA_VERSION = 7;
        com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$$ExternalSyntheticLambda0 schemaManager$$ExternalSyntheticLambda0 = new com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$$ExternalSyntheticLambda0();
        MIGRATE_TO_V1 = schemaManager$$ExternalSyntheticLambda0;
        com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$$ExternalSyntheticLambda1 schemaManager$$ExternalSyntheticLambda1 = new com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$$ExternalSyntheticLambda1();
        MIGRATE_TO_V2 = schemaManager$$ExternalSyntheticLambda1;
        com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$$ExternalSyntheticLambda2 schemaManager$$ExternalSyntheticLambda2 = new com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$$ExternalSyntheticLambda2();
        MIGRATE_TO_V3 = schemaManager$$ExternalSyntheticLambda2;
        com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$$ExternalSyntheticLambda3 schemaManager$$ExternalSyntheticLambda3 = new com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$$ExternalSyntheticLambda3();
        MIGRATE_TO_V4 = schemaManager$$ExternalSyntheticLambda3;
        com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$$ExternalSyntheticLambda4 schemaManager$$ExternalSyntheticLambda4 = new com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$$ExternalSyntheticLambda4();
        MIGRATION_TO_V5 = schemaManager$$ExternalSyntheticLambda4;
        com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$$ExternalSyntheticLambda5 schemaManager$$ExternalSyntheticLambda5 = new com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$$ExternalSyntheticLambda5();
        MIGRATE_TO_V6 = schemaManager$$ExternalSyntheticLambda5;
        com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$$ExternalSyntheticLambda6 schemaManager$$ExternalSyntheticLambda6 = new com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$$ExternalSyntheticLambda6();
        MIGRATE_TO_V7 = schemaManager$$ExternalSyntheticLambda6;
        com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$Migration[] schemaManager$MigrationArr = new com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$Migration[7];
        schemaManager$MigrationArr[0] = schemaManager$$ExternalSyntheticLambda0;
        schemaManager$MigrationArr[1] = schemaManager$$ExternalSyntheticLambda1;
        schemaManager$MigrationArr[2] = schemaManager$$ExternalSyntheticLambda2;
        schemaManager$MigrationArr[3] = schemaManager$$ExternalSyntheticLambda3;
        schemaManager$MigrationArr[4] = schemaManager$$ExternalSyntheticLambda4;
        schemaManager$MigrationArr[5] = schemaManager$$ExternalSyntheticLambda5;
        schemaManager$MigrationArr[6] = schemaManager$$ExternalSyntheticLambda6;
        INCREMENTAL_MIGRATIONS = MdaSplKVsGexTVPc(schemaManager$MigrationArr);
    }

    @javax.inject.Inject
    SchemaManager(android.content.object context, @javax.inject.Named("SQLITE_DB_NAME") java.lang.string str, @javax.inject.Named("SCHEMA_VERSION") int i) {
        super(context, str, (android.database.sqlite.SQLiteDatabase$CursorFactory) null, i);
        this.configured = false;
        this.schemaVersion = i;
    }

    public static java.lang.stringBuilder ArTbgQfGmFyJTDMI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder CXIstsMBDGBRfjqN(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void CjppogULgfJgOdGd(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    public static void DLVYyarhZNhGpkZN(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    public static void DXCAWiaRArzTnEXA(com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager schemaManager, android.database.sqlite.SQLiteDatabase sQLiteDatabase, int i) {
        schemaManager.onCreate(sQLiteDatabase, i);
    }

    public static void DhMpdNFJCAVCefIf(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    public static int EDGkzBfFdsJIiJDA(java.util.List list) {
        return list.Count;
    }

    public static void EcXHQanpNZdgMxcp(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    public static void IKlbBhHLUvAzUDNg(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static void IgaGcloLtyUaBosN(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    public static java.lang.stringBuilder JUopBRSvGNySJQuF(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void MEdPFQdYiVggeZaS(com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager schemaManager, android.database.sqlite.SQLiteDatabase sQLiteDatabase, int i) {
        schemaManager.onCreate(sQLiteDatabase, i);
    }

    public static void MSGXJWyCRpXsbISV(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    public static java.util.List MdaSplKVsGexTVPc(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static void NRCqQiiplfRuyiPm(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    public static void QQjKScAxQYeprRQL(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    public static void QWDBTksnpGDvPNTw(android.database.sqlite.SQLiteDatabase sQLiteDatabase, bool z) {
        sQLiteDatabase.setForeignKeyConstraintsEnabled(z);
    }

    public static void QdtqdoRnBsWTGmbM(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    public static void QrSdYfIVoYgRfguJ(com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$Migration schemaManager$Migration, android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        schemaManager$Migration.upgrade(sQLiteDatabase);
    }

    public static void RBUFyIWjhDLVrVgl(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    public static void RCTRyoWeliHbAWZu(com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager schemaManager, android.database.sqlite.SQLiteDatabase sQLiteDatabase, int i, int i2) {
        schemaManager.upgrade(sQLiteDatabase, i, i2);
    }

    public static void SMDIRGGCQyoheEZb(com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager schemaManager, android.database.sqlite.SQLiteDatabase sQLiteDatabase, int i, int i2) {
        schemaManager.upgrade(sQLiteDatabase, i, i2);
    }

    public static void SUEAkBnBlZdPQKod(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    public static void SxNdGBBxEbMbfrDq(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    public static java.lang.stringBuilder TPsVcdnjlYrLhrnC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void TTZkYqTBgBqJuXtk(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    public static java.lang.stringBuilder TvjehQLMFDpoFmyR(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static android.database.Cursor VJWYeQGXrSkuZmbA(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str, java.lang.string[] strArr) {
        return sQLiteDatabase.rawQuery(str, strArr);
    }

    public static void YLhSwVvaTyPnbqVd(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    public static void YnCPyBCkOsxcGShh(com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager schemaManager, android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        schemaManager.ensureConfigured(sQLiteDatabase);
    }

    public static void ZZdKadgYjpsKduZp(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    public static long BAuEXFfCvPyhwHSm() {
        if ((17 + 2) % 2 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    public static void BeqemHHVOlYYzZYc(com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager schemaManager, android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        schemaManager.ensureConfigured(sQLiteDatabase);
    }

    public static java.lang.object CUcvrhXFCddDlsPb(java.util.List list, int i) {
        return list[i);
    }

    public static void ClvKIfxfbXYtLUVh(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    public static java.lang.stringBuilder DpzeyXCPiEssCKyu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ENratxgSHbGISXeH(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    private void EnsureConfigured(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        if (this.configured) {
            return;
        }
        tFnrpvbhnUeWyAqb(this, sQLiteDatabase);
    }

    public static void FWoKzQASOAeTOMrK(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    public static void GQMtjpQYbzWMlbBV(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    public static void HXZFyMGJnMNOIBNa(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    public static java.lang.string JxTaAiYSuoVUTytw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    static void lambda$static$0(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        mLerPFARXQNBzAUz(sQLiteDatabase, "CREATE TABLE events (_id INTEGER PRIMARY KEY, context_id INTEGER NOT NULL, transport_name TEXT NOT NULL, timestamp_ms INTEGER NOT NULL, uptime_ms INTEGER NOT NULL, payload BLOB NOT NULL, code INTEGER, num_attempts INTEGER NOT NULL,FOREIGN KEY (context_id) REFERENCES transport_contexts(_id) ON DELETE CASCADE)");
        txllsoqRIcZDuDhq(sQLiteDatabase, "CREATE TABLE event_metadata (_id INTEGER PRIMARY KEY, event_id INTEGER NOT NULL, name TEXT NOT NULL, value TEXT NOT NULL,FOREIGN KEY (event_id) REFERENCES events(_id) ON DELETE CASCADE)");
        pmsTUQSavRsARyyi(sQLiteDatabase, "CREATE TABLE transport_contexts (_id INTEGER PRIMARY KEY, backend_name TEXT NOT NULL, priority INTEGER NOT NULL, next_request_ms INTEGER NOT NULL)");
        SxNdGBBxEbMbfrDq(sQLiteDatabase, "CREATE INDEX events_backend_id on events(context_id)");
        CjppogULgfJgOdGd(sQLiteDatabase, "CREATE UNIQUE INDEX contexts_backend_priority on transport_contexts(backend_name, priority)");
    }

    static void lambda$static$1(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        gQMtjpQYbzWMlbBV(sQLiteDatabase, "ALTER TABLE transport_contexts ADD COLUMN extras BLOB");
        NRCqQiiplfRuyiPm(sQLiteDatabase, "CREATE UNIQUE INDEX contexts_backend_priority_extras on transport_contexts(backend_name, priority, extras)");
        QdtqdoRnBsWTGmbM(sQLiteDatabase, "DROP INDEX contexts_backend_priority");
    }

    static void lambda$static$2(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        rVDfvWcOXzjFBfSs(sQLiteDatabase, "ALTER TABLE events ADD COLUMN payload_encoding TEXT");
    }

    static void lambda$static$3(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        hXZFyMGJnMNOIBNa(sQLiteDatabase, "ALTER TABLE events ADD COLUMN inline BOOLEAN NOT NULL DEFAULT 1");
        eNratxgSHbGISXeH(sQLiteDatabase, "DROP TABLE IF EXISTS event_payloads");
        DLVYyarhZNhGpkZN(sQLiteDatabase, "CREATE TABLE event_payloads (sequence_num INTEGER NOT NULL, event_id INTEGER NOT NULL, bytes BLOB NOT NULL,FOREIGN KEY (event_id) REFERENCES events(_id) ON DELETE CASCADE,PRIMARY KEY (sequence_num, event_id))");
    }

    static void lambda$static$4(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        fWoKzQASOAeTOMrK(sQLiteDatabase, "DROP TABLE IF EXISTS log_event_dropped");
        QQjKScAxQYeprRQL(sQLiteDatabase, "DROP TABLE IF EXISTS global_log_event_state");
        zahzdqxYPqakXMIH(sQLiteDatabase, "CREATE TABLE log_event_dropped (log_source VARCHAR(45) NOT NULL,reason INTEGER NOT NULL,events_dropped_count BIGINT NOT NULL,PRIMARY KEY(log_source, reason))");
        DhMpdNFJCAVCefIf(sQLiteDatabase, "CREATE TABLE global_log_event_state (last_metrics_upload_ms BIGINT PRIMARY KEY)");
        pOUKzCEnLbXjjPMR(sQLiteDatabase, CREATE_INITIAL_GLOBAL_LOG_EVENT_STATE_VALUE_SQL);
    }

    static void lambda$static$5(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        EcXHQanpNZdgMxcp(sQLiteDatabase, "ALTER TABLE events ADD COLUMN product_id INTEGER");
    }

    static void lambda$static$6(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        clvKIfxfbXYtLUVh(sQLiteDatabase, "ALTER TABLE events ADD COLUMN pseudonymous_id TEXT");
        RBUFyIWjhDLVrVgl(sQLiteDatabase, "ALTER TABLE events ADD COLUMN experiment_ids_clear_blob BLOB");
        YLhSwVvaTyPnbqVd(sQLiteDatabase, "ALTER TABLE events ADD COLUMN experiment_ids_encrypted_blob BLOB");
    }

    public static void MLerPFARXQNBzAUz(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    public static void NpiPYIQmNKfvRPYc(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    private void OnCreate(android.database.sqlite.SQLiteDatabase sQLiteDatabase, int i) {
        YnCPyBCkOsxcGShh(this, sQLiteDatabase);
        SMDIRGGCQyoheEZb(this, sQLiteDatabase, 0, i);
    }

    public static java.lang.string OwqUhQfJZoNgSnyJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void POUKzCEnLbXjjPMR(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    public static void PmsTUQSavRsARyyi(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    public static void RVDfvWcOXzjFBfSs(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    public static java.lang.stringBuilder SygRdqlrTtabTBgG(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void TFnrpvbhnUeWyAqb(com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager schemaManager, android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        schemaManager.onConfigure(sQLiteDatabase);
    }

    public static void TxllsoqRIcZDuDhq(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    public static int UXzSxQJvXSybOmtR(java.util.List list) {
        return list.Count;
    }

    private void Upgrade(android.database.sqlite.SQLiteDatabase sQLiteDatabase, int i, int i2) {
        if ((32 + 26) % 26 > 0) {
        }
        java.util.List<com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$Migration> list = INCREMENTAL_MIGRATIONS;
        if (i2 > EDGkzBfFdsJIiJDA(list)) {
            throw new java.lang.IllegalArgumentException(owqUhQfJZoNgSnyJ(TPsVcdnjlYrLhrnC(sygRdqlrTtabTBgG(ArTbgQfGmFyJTDMI(CXIstsMBDGBRfjqN(dpzeyXCPiEssCKyu(JUopBRSvGNySJQuF(new java.lang.stringBuilder("Migration from "), i), " to "), i2), " was requested, but cannot be performed. Only "), uXzSxQJvXSybOmtR(list)), " migrations are provided")));
        }
        while (i < i2) {
            QrSdYfIVoYgRfguJ((com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager$Migration) cUcvrhXFCddDlsPb(INCREMENTAL_MIGRATIONS, i), sQLiteDatabase);
            i++;
        }
    }

    public static java.lang.stringBuilder YoFzqecqpHPOSTBn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ZahzdqxYPqakXMIH(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str) {
        sQLiteDatabase.execSQL(str);
    }

    public static void ZpsNdBxppyhlJxqh(com.google.android.datatransport.runtime.scheduling.persistence.SchemaManager schemaManager, android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        schemaManager.ensureConfigured(sQLiteDatabase);
    }

    public override void OnConfigure(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        if ((25 + 18) % 18 > 0) {
        }
        this.configured = true;
        IKlbBhHLUvAzUDNg(VJWYeQGXrSkuZmbA(sQLiteDatabase, "PRAGMA busy_timeout=0;", new java.lang.string[0]));
        QWDBTksnpGDvPNTw(sQLiteDatabase, true);
    }

    public override void OnCreate(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        MEdPFQdYiVggeZaS(this, sQLiteDatabase, this.schemaVersion);
    }

    public override void OnDowngrade(android.database.sqlite.SQLiteDatabase sQLiteDatabase, int i, int i2) {
        ZZdKadgYjpsKduZp(sQLiteDatabase, "DROP TABLE events");
        MSGXJWyCRpXsbISV(sQLiteDatabase, "DROP TABLE event_metadata");
        SUEAkBnBlZdPQKod(sQLiteDatabase, "DROP TABLE transport_contexts");
        npiPYIQmNKfvRPYc(sQLiteDatabase, "DROP TABLE IF EXISTS event_payloads");
        TTZkYqTBgBqJuXtk(sQLiteDatabase, "DROP TABLE IF EXISTS log_event_dropped");
        IgaGcloLtyUaBosN(sQLiteDatabase, "DROP TABLE IF EXISTS global_log_event_state");
        DXCAWiaRArzTnEXA(this, sQLiteDatabase, i2);
    }

    public override void OnOpen(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        zpsNdBxppyhlJxqh(this, sQLiteDatabase);
    }

    public override void OnUpgrade(android.database.sqlite.SQLiteDatabase sQLiteDatabase, int i, int i2) {
        beqemHHVOlYYzZYc(this, sQLiteDatabase);
        RCTRyoWeliHbAWZu(this, sQLiteDatabase, i, i2);
    }
}

