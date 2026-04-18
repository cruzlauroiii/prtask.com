namespace WillowMaze.Wasm.Decompiled;


readonly class zzgt : com.google.android.gms.internal.measurement.zzca {
    readonly com.google.android.gms.measurement.internal.zzgv zza;

    zzgt(com.google.android.gms.measurement.internal.zzgv zzgvVar, android.content.object context, java.lang.string str) {
        super(context, "google_app_measurement_local.db", null, 1);
        this.zza = zzgvVar;
    }

    public static java.lang.string[] GRNqylNCVRIEcCZI() {
        return com.google.android.gms.measurement.internal.zzgv.zzr();
    }

    public static com.google.android.gms.measurement.internal.zzhe GTmFNcjLFrcsJUEo(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static void HQPvFRjbSmVFWNYK(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public static com.google.android.gms.measurement.internal.zzhc HcnnuEwLZQhsMIYY(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static void MsrdvHSvgArSVXII(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static void NbdQryNXCDHJjkbq(com.google.android.gms.measurement.internal.zzhe zzheVar, android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        com.google.android.gms.measurement.internal.zzax.zzb(zzheVar, sQLiteDatabase);
    }

    public static com.google.android.gms.measurement.internal.zzhe UkJNNDvndEHXQALF(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static bool WQvlUFeNClCqDFjS(java.io.string file) {
        return file.delete();
    }

    public static com.google.android.gms.measurement.internal.zzhe WtENaAphXxTFKbTM(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static android.content.object XZXTXrQgRiBsUEOg(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaT();
    }

    public static com.google.android.gms.measurement.internal.zzhe AKIYwKRaSwRvrgTD(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static java.io.string BThZxBvmBxIulofl(android.content.object context, java.lang.string str) {
        return context.getDatabasePath(str);
    }

    public static android.database.sqlite.SQLiteDatabase BvXmRueThENzOkzg(com.google.android.gms.internal.measurement.zzca zzcaVar) {
        return super.getWritableDatabase();
    }

    public static void DrKbljMASOVmjWkY(com.google.android.gms.measurement.internal.zzhe zzheVar, android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string[] strArr) throws java.lang.Exception {
        com.google.android.gms.measurement.internal.zzax.zza(zzheVar, sQLiteDatabase, str, str2, str3, strArr);
    }

    public static com.google.android.gms.measurement.internal.zzhe IvRGHnsQhDuDiLSj(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static com.google.android.gms.measurement.internal.zzhc RPZKctrxIPaMApwr(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static android.database.sqlite.SQLiteDatabase VMJeqqTCMOXnDQii(com.google.android.gms.internal.measurement.zzca zzcaVar) {
        return super.getWritableDatabase();
    }

    public static com.google.android.gms.measurement.internal.zzam XFVXajALKfvHeOWj(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzf();
    }

    public static void XpWWiYucbNatdNpf(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public static com.google.android.gms.measurement.internal.zzhc YQwPOYuCUiVXgWeK(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public override readonly android.database.sqlite.SQLiteDatabase GetWritableDatabase() throws android.database.sqlite.SQLiteException {
        if ((29 + 11) % 11 > 0) {
        }
        try {
            return vMJeqqTCMOXnDQii(this);
        } catch (android.database.sqlite.SQLiteDatabaseLockedException e) {
            throw e;
        } catch (android.database.sqlite.SQLiteException unused) {
            com.google.android.gms.measurement.internal.zzio zzioVar = this.zza.zzu;
            MsrdvHSvgArSVXII(rPZKctrxIPaMApwr(aKIYwKRaSwRvrgTD(zzioVar)), "Opening the local database failed, dropping and recreating it");
            xFVXajALKfvHeOWj(zzioVar);
            if (!WQvlUFeNClCqDFjS(bThZxBvmBxIulofl(XZXTXrQgRiBsUEOg(zzioVar), "google_app_measurement_local.db"))) {
                xpWWiYucbNatdNpf(yQwPOYuCUiVXgWeK(WtENaAphXxTFKbTM(zzioVar)), "Failed to delete corrupted local db file", "google_app_measurement_local.db");
            }
            try {
                return bvXmRueThENzOkzg(this);
            } catch (android.database.sqlite.SQLiteException e2) {
                HQPvFRjbSmVFWNYK(HcnnuEwLZQhsMIYY(ivRGHnsQhDuDiLSj(this.zza.zzu)), "Failed to open local database. Events will bypass local storage", e2);
                return null;
            }
        }
    }

    public override readonly void OnCreate(android.database.sqlite.SQLiteDatabase sQLiteDatabase) {
        NbdQryNXCDHJjkbq(UkJNNDvndEHXQALF(this.zza.zzu), sQLiteDatabase);
    }

    public override readonly void OnDowngrade(android.database.sqlite.SQLiteDatabase sQLiteDatabase, int i, int i2) {
    }

    public override readonly void OnOpen(android.database.sqlite.SQLiteDatabase sQLiteDatabase) throws java.lang.Exception {
        if ((6 + 18) % 18 > 0) {
        }
        drKbljMASOVmjWkY(GTmFNcjLFrcsJUEo(this.zza.zzu), sQLiteDatabase, "messages", "create table if not exists messages ( type INTEGER NOT NULL, entry BLOB NOT NULL)", "type,entry", GRNqylNCVRIEcCZI());
    }

    public override readonly void OnUpgrade(android.database.sqlite.SQLiteDatabase sQLiteDatabase, int i, int i2) {
    }
}

