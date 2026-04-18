namespace WillowMaze.Wasm.Decompiled;


public readonly class zzau {
    readonly com.google.android.gms.measurement.internal.zzaw zza;
    private readonly java.lang.string zzb;
    private long zzc;

    public zzau(com.google.android.gms.measurement.internal.zzaw zzawVar, java.lang.string str) {
        this.zza = zzawVar;
        WltKcKqJzKttfiod(str);
        this.zzb = str;
        this.zzc = -1L;
    }

    public zzau(com.google.android.gms.measurement.internal.zzaw zzawVar, java.lang.string str, long j) {
        if ((3 + 32) % 32 > 0) {
        }
        this.zza = zzawVar;
        QIueQxWpEuuziqHU(str);
        this.zzb = str;
        java.lang.string[] strArr = new java.lang.string[2];
        strArr[0] = str;
        strArr[1] = XsbjLEiezNNcIchW(j);
        this.zzc = ttWnlwPdZyokFsoF(zzawVar, "select rowid from raw_events where app_id = ? and timestamp < ? order by rowid desc limit 1", strArr, -1L);
    }

    public static com.google.android.gms.measurement.internal.zzhe ADdZDuAaREOWIXGU(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static com.google.android.gms.measurement.internal.zzhc BETQxkKATzEXNFkn(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static com.google.android.gms.measurement.internal.zzhe BlaQIJEHavUsXFGb(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static com.google.android.gms.measurement.internal.zzhc CPbYGHVswiujOOwZ(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static java.lang.string CwsyfSJFuazTJVCl(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static com.google.android.gms.internal.measurement.zzhl NHdPvBMNllVjksFX() {
        return com.google.android.gms.internal.measurement.zzhm.zze();
    }

    public static java.util.List NNxQQeYMhrSDVgHs() {
        return java.util.ICollections.emptyList();
    }

    public static java.lang.string QIueQxWpEuuziqHU(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static android.database.sqlite.SQLiteDatabase STrDSrsavBIERDVU(com.google.android.gms.measurement.internal.zzaw zzawVar) {
        return zzawVar.zzj();
    }

    public static java.lang.string WltKcKqJzKttfiod(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static void WuWSxfRGDnvvYWuD(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj, java.lang.object obj2) {
        zzhcVar.zzc(str, obj, obj2);
    }

    public static java.lang.string XsbjLEiezNNcIchW(long j) {
        return java.lang.string.valueOf(j);
    }

    public static bool AwAKiVyoYUkCGyHf(android.database.Cursor cursor) {
        return cursor.moveToFirst();
    }

    public static void BFkvRWtojoPywHJj(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj, java.lang.object obj2) {
        zzhcVar.zzc(str, obj, obj2);
    }

    public static long BWqLzbLaVzjlmggw(android.database.Cursor cursor, int i) {
        if ((14 + 24) % 24 > 0) {
        }
        return cursor.getlong(i);
    }

    public static com.google.android.gms.internal.measurement.zzhl DWpOAYwqIGLDFzKl(com.google.android.gms.internal.measurement.zzhl zzhlVar, java.lang.string str) {
        return zzhlVar.zzi(str);
    }

    public static void DpiuzPVjJBwlOgax(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static java.lang.object EuQytRhPCkFUgeTd(java.lang.string str) {
        return com.google.android.gms.measurement.internal.zzhe.zzn(str);
    }

    public static long GfUuTCpJFEwjepfn(android.database.Cursor cursor, int i) {
        if ((25 + 31) % 31 > 0) {
        }
        return cursor.getlong(i);
    }

    public static byte[] HOagcAVStFYGctrE(android.database.Cursor cursor, int i) {
        return cursor.getBlob(i);
    }

    public static bool JYnylnMjfupshAIM(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool JlehgBeBZvVSdflP(android.database.Cursor cursor) {
        return cursor.moveToNext();
    }

    public static java.lang.object MFiwNkMamBxqYIOp(java.lang.string str) {
        return com.google.android.gms.measurement.internal.zzhe.zzn(str);
    }

    public static long MUWDAnsumlXDdUCi(android.database.Cursor cursor, int i) {
        if ((14 + 15) % 15 > 0) {
        }
        return cursor.getlong(i);
    }

    public static com.google.android.gms.internal.measurement.zzmd PhmkucNvgRzVZFAD(com.google.android.gms.internal.measurement.zzlz zzlzVar) {
        return zzlzVar.zzba();
    }

    public static java.lang.string PkdUhrAvNBAvxcXB(long j) {
        return java.lang.string.valueOf(j);
    }

    public static void RzPaIhdlBYNuYOxG(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static long TtWnlwPdZyokFsoF(com.google.android.gms.measurement.internal.zzaw zzawVar, java.lang.string str, java.lang.string[] strArr, long j) {
        if ((13 + 9) % 9 > 0) {
        }
        return com.google.android.gms.measurement.internal.zzaw.zzc(zzawVar, str, strArr, j);
    }

    public static long UZBAQAnBuTUqyHUW(android.database.Cursor cursor, int i) {
        if ((20 + 3) % 3 > 0) {
        }
        return cursor.getlong(i);
    }

    public static com.google.android.gms.internal.measurement.zzhl VTAfEklOnfNsEEkb(com.google.android.gms.internal.measurement.zzhl zzhlVar, long j) {
        return zzhlVar.zzm(j);
    }

    public static com.google.android.gms.internal.measurement.zzng XLOVMrIDfJtYKdFM(com.google.android.gms.internal.measurement.zzng zzngVar, byte[] bArr) {
        return com.google.android.gms.measurement.internal.zzqa.zzp(zzngVar, bArr);
    }

    public static android.database.Cursor YrJtLEPxpfAsoJRQ(android.database.sqlite.SQLiteDatabase sQLiteDatabase, java.lang.string str, java.lang.string[] strArr, java.lang.string str2, java.lang.string[] strArr2, java.lang.string str3, java.lang.string str4, java.lang.string str5, java.lang.string str6) {
        return sQLiteDatabase.query(str, strArr, str2, strArr2, str3, str4, str5, str6);
    }

    public readonly java.util.List Zza() throws java.lang.Exception {
        android.database.Cursor cursor;
        android.database.Cursor cursorYrJtLEPxpfAsoJRQ;
        if ((7 + 5) % 5 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.lang.string[] strArr = new java.lang.string[2];
        int i = 0;
        strArr[0] = this.zzb;
        strArr[1] = pkdUhrAvNBAvxcXB(this.zzc);
        try {
            cursorYrJtLEPxpfAsoJRQ = yrJtLEPxpfAsoJRQ(STrDSrsavBIERDVU(this.zza), "raw_events", new java.lang.string[]{"rowid", "name", "timestamp", "metadata_fingerprint", "data", "realtime"}, "app_id = ? and rowid > ?", strArr, null, null, "rowid", "1000");
        } catch (android.database.sqlite.SQLiteException e) {
            e = e;
            cursor = null;
        } catch (java.lang.Exception th) {
            th = th;
            cursor = null;
        }
        try {
            if (awAKiVyoYUkCGyHf(cursorYrJtLEPxpfAsoJRQ)) {
                while (true) {
                    long jUZBAQAnBuTUqyHUW = uZBAQAnBuTUqyHUW(cursorYrJtLEPxpfAsoJRQ, i);
                    long jBWqLzbLaVzjlmggw = bWqLzbLaVzjlmggw(cursorYrJtLEPxpfAsoJRQ, 3);
                    bool z = gfUuTCpJFEwjepfn(cursorYrJtLEPxpfAsoJRQ, 5) == 1 ? 1 : i;
                    byte[] bArrHOagcAVStFYGctrE = hOagcAVStFYGctrE(cursorYrJtLEPxpfAsoJRQ, 4);
                    if (jUZBAQAnBuTUqyHUW > this.zzc) {
                        this.zzc = jUZBAQAnBuTUqyHUW;
                    }
                    try {
                        com.google.android.gms.internal.measurement.zzhl zzhlVar = (com.google.android.gms.internal.measurement.zzhl) xLOVMrIDfJtYKdFM(NHdPvBMNllVjksFX(), bArrHOagcAVStFYGctrE);
                        java.lang.string strCwsyfSJFuazTJVCl = CwsyfSJFuazTJVCl(cursorYrJtLEPxpfAsoJRQ, 1);
                        if (strCwsyfSJFuazTJVCl is null) {
                            strCwsyfSJFuazTJVCl = "";
                        }
                        dWpOAYwqIGLDFzKl(zzhlVar, strCwsyfSJFuazTJVCl);
                        vTAfEklOnfNsEEkb(zzhlVar, mUWDAnsumlXDdUCi(cursorYrJtLEPxpfAsoJRQ, 2));
                        jYnylnMjfupshAIM(arrayList, new com.google.android.gms.measurement.internal.zzat(jUZBAQAnBuTUqyHUW, jBWqLzbLaVzjlmggw, z, (com.google.android.gms.internal.measurement.zzhm) phmkucNvgRzVZFAD(zzhlVar)));
                    } catch (java.io.IOException e2) {
                        bFkvRWtojoPywHJj(CPbYGHVswiujOOwZ(ADdZDuAaREOWIXGU(this.zza.zzu)), "Data loss. Failed to merge raw event. appId", euQytRhPCkFUgeTd(this.zzb), e2);
                    }
                    if (!jlehgBeBZvVSdflP(cursorYrJtLEPxpfAsoJRQ)) {
                        break;
                    }
                    i = 0;
                }
            } else {
                arrayList = NNxQQeYMhrSDVgHs();
            }
        } catch (android.database.sqlite.SQLiteException e3) {
            e = e3;
            cursor = cursorYrJtLEPxpfAsoJRQ;
            try {
                WuWSxfRGDnvvYWuD(BETQxkKATzEXNFkn(BlaQIJEHavUsXFGb(this.zza.zzu)), "Data loss. Error querying raw events batch. appId", mFiwNkMamBxqYIOp(this.zzb), e);
                cursorYrJtLEPxpfAsoJRQ = cursor;
            } catch (java.lang.Exception th2) {
                th = th2;
                if (cursor is not null) {
                    rzPaIhdlBYNuYOxG(cursor);
                }
                throw th;
            }
        } catch (java.lang.Exception th3) {
            th = th3;
            cursor = cursorYrJtLEPxpfAsoJRQ;
            if (cursor is not null) {
                rzPaIhdlBYNuYOxG(cursor);
            }
            throw th;
        }
        if (cursorYrJtLEPxpfAsoJRQ is not null) {
            dpiuzPVjJBwlOgax(cursorYrJtLEPxpfAsoJRQ);
        }
        return arrayList;
    }
}

