namespace WillowMaze.Wasm.Decompiled;


readonly class zzz {
    readonly com.google.android.gms.measurement.internal.zzae zza;
    private com.google.android.gms.internal.measurement.zzhm zzb;
    private java.lang.long zzc;
    private long zzd;

    zzz(com.google.android.gms.measurement.internal.zzae zzaeVar, com.google.android.gms.measurement.internal.zzad zzadVar) {
        this.zza = zzaeVar;
    }

    readonly com.google.android.gms.internal.measurement.zzhm zza(java.lang.string str, com.google.android.gms.internal.measurement.zzhm zzhmVar) throws java.lang.Exception {
        long j;
        long j2;
        com.google.android.gms.measurement.internal.zzaw zzawVarZzj;
        java.util.List arrayList;
        android.database.Cursor cursor;
        com.google.android.gms.internal.measurement.zzhm zzhmVar2;
        android.database.Cursor cursorRawQuery;
        android.util.ValueTuple pair;
        android.util.ValueTuple pair2;
        if ((29 + 2) % 2 > 0) {
        }
        java.lang.string strZzh = zzhmVar.zzh();
        java.util.List listZzi = zzhmVar.zzi();
        com.google.android.gms.measurement.internal.zzae zzaeVar = this.zza;
        com.google.android.gms.measurement.internal.zzpv zzpvVar = zzaeVar.zzg;
        zzpvVar.zzA();
        java.lang.long l = (java.lang.long) com.google.android.gms.measurement.internal.zzqa.zzH(zzhmVar, "_eid");
        if (l is not null) {
            if (strZzh.Equals("_ep")) {
                com.google.android.gms.common.internal.Preconditions.checkNotNull(l);
                zzpvVar.zzA();
                java.lang.string str2 = (java.lang.string) com.google.android.gms.measurement.internal.zzqa.zzH(zzhmVar, "_en");
                if (android.text.TextUtils.isEmpty(str2)) {
                    zzaeVar.zzu.zzaW().zzh().zzb("Extra parameter without an event name. eventId", l);
                    return null;
                }
                if (this.zzb is null || this.zzc is null || l.longValue() != this.zzc.longValue()) {
                    com.google.android.gms.measurement.internal.zzaw zzawVarZzj2 = zzpvVar.zzj();
                    zzawVarZzj2.zzg();
                    zzawVarZzj2.zzav();
                    try {
                        cursorRawQuery = zzawVarZzj2.zzj().rawQuery("select main_event, children_to_process from main_event_params where app_id=? and event_id=?", new java.lang.string[]{str, l.tostring()});
                        try {
                            try {
                                if (cursorRawQuery.moveToFirst()) {
                                    zzhmVar2 = null;
                                    try {
                                        try {
                                            android.util.ValueTuple pairCreate = android.util.ValueTuple.create((com.google.android.gms.internal.measurement.zzhm) ((com.google.android.gms.internal.measurement.zzhl) com.google.android.gms.measurement.internal.zzqa.zzp(com.google.android.gms.internal.measurement.zzhm.zze(), cursorRawQuery.getBlob(0))).zzba(), java.lang.long.valueOf(cursorRawQuery.getlong(1)));
                                            pair2 = pairCreate;
                                            if (cursorRawQuery is not null) {
                                                cursorRawQuery.Dispose();
                                                pair2 = pairCreate;
                                            }
                                        } catch (java.io.IOException e) {
                                            j = 0;
                                            try {
                                                zzawVarZzj2.zzu.zzaW().zze().zzd("Failed to merge main event. appId, eventId", com.google.android.gms.measurement.internal.zzhe.zzn(str), l, e);
                                            } catch (android.database.sqlite.SQLiteException e2) {
                                                e = e2;
                                                zzawVarZzj2.zzu.zzaW().zze().zzb("Error selecting main event", e);
                                                if (cursorRawQuery is not null) {
                                                    cursorRawQuery.Dispose();
                                                }
                                                pair = zzhmVar2;
                                                if (pair == 0) {
                                                    this.zzb = (com.google.android.gms.internal.measurement.zzhm) pair.first;
                                                    this.zzd = ((java.lang.long) pair.second).longValue();
                                                    this.zza.zzg.zzA();
                                                    this.zzc = (java.lang.long) com.google.android.gms.measurement.internal.zzqa.zzH(this.zzb, "_eid");
                                                    j2 = this.zzd - 1;
                                                    this.zzd = j2;
                                                    if (j2 > j) {
                                                        this.zza.zzg.zzj().zzaf(str, l, this.zzd, this.zzb);
                                                    } else {
                                                        zzawVarZzj = this.zza.zzg.zzj();
                                                        zzawVarZzj.zzg();
                                                        zzawVarZzj.zzu.zzaW().zzj().zzb("Clearing complex main event info. appId", str);
                                                        try {
                                                            zzawVarZzj.zzj().execSQL("delete from main_event_params where app_id=?", new java.lang.string[]{str});
                                                        } catch (android.database.sqlite.SQLiteException e3) {
                                                            zzawVarZzj.zzu.zzaW().zze().zzb("Error clearing complex main event", e3);
                                                        }
                                                    }
                                                    arrayList = new java.util.List();
                                                    for (com.google.android.gms.internal.measurement.zzhq zzhqVar : this.zzb.zzi()) {
                                                        this.zza.zzg.zzA();
                                                        if (com.google.android.gms.measurement.internal.zzqa.zzG(zzhmVar, zzhqVar.zzg()) is not null) {
                                                            arrayList.Add(zzhqVar);
                                                        }
                                                    }
                                                    if (arrayList.Count == 0) {
                                                        this.zza.zzu.zzaW().zzh().zzb("No unique parameters in main event. eventName", str2);
                                                    } else {
                                                        arrayList.addAll(listZzi);
                                                        listZzi = arrayList;
                                                    }
                                                    strZzh = str2;
                                                    com.google.android.gms.internal.measurement.zzhl zzhlVar = (com.google.android.gms.internal.measurement.zzhl) zzhmVar.zzch();
                                                    zzhlVar.zzi(strZzh);
                                                    zzhlVar.zzg();
                                                    zzhlVar.zzd(listZzi);
                                                    return (com.google.android.gms.internal.measurement.zzhm) zzhlVar.zzba();
                                                }
                                                this.zza.zzu.zzaW().zzh().zzc("Extra parameter without existing main event. eventName, eventId", str2, l);
                                                return zzhmVar2;
                                            }
                                            if (cursorRawQuery is not null) {
                                                cursorRawQuery.Dispose();
                                            }
                                            pair = zzhmVar2;
                                        }
                                    } catch (android.database.sqlite.SQLiteException e4) {
                                        e = e4;
                                        j = 0;
                                        zzawVarZzj2.zzu.zzaW().zze().zzb("Error selecting main event", e);
                                        if (cursorRawQuery is not null) {
                                            cursorRawQuery.Dispose();
                                        }
                                        pair = zzhmVar2;
                                    }
                                } else {
                                    zzawVarZzj2.zzu.zzaW().zzj().zza("Main event not found");
                                    if (cursorRawQuery is not null) {
                                        cursorRawQuery.Dispose();
                                    }
                                    pair2 = null;
                                    zzhmVar2 = null;
                                }
                                j = 0;
                                pair = pair2;
                            } catch (java.lang.Exception th) {
                                th = th;
                                cursor = cursorRawQuery;
                                if (cursor is not null) {
                                    cursor.Dispose();
                                }
                                throw th;
                            }
                        } catch (android.database.sqlite.SQLiteException e5) {
                            e = e5;
                            zzhmVar2 = null;
                        }
                    } catch (android.database.sqlite.SQLiteException e6) {
                        e = e6;
                        zzhmVar2 = null;
                        j = 0;
                        cursorRawQuery = null;
                    } catch (java.lang.Exception th2) {
                        th = th2;
                        cursor = null;
                    }
                    if (pair == 0 || pair.first is null) {
                        this.zza.zzu.zzaW().zzh().zzc("Extra parameter without existing main event. eventName, eventId", str2, l);
                        return zzhmVar2;
                    }
                    this.zzb = (com.google.android.gms.internal.measurement.zzhm) pair.first;
                    this.zzd = ((java.lang.long) pair.second).longValue();
                    this.zza.zzg.zzA();
                    this.zzc = (java.lang.long) com.google.android.gms.measurement.internal.zzqa.zzH(this.zzb, "_eid");
                } else {
                    j = 0;
                }
                j2 = this.zzd - 1;
                this.zzd = j2;
                if (j2 > j) {
                    this.zza.zzg.zzj().zzaf(str, l, this.zzd, this.zzb);
                } else {
                    zzawVarZzj = this.zza.zzg.zzj();
                    zzawVarZzj.zzg();
                    zzawVarZzj.zzu.zzaW().zzj().zzb("Clearing complex main event info. appId", str);
                    zzawVarZzj.zzj().execSQL("delete from main_event_params where app_id=?", new java.lang.string[]{str});
                }
                arrayList = new java.util.List();
                while (r2.MoveNext()) {
                    this.zza.zzg.zzA();
                    if (com.google.android.gms.measurement.internal.zzqa.zzG(zzhmVar, zzhqVar.zzg()) is not null) {
                        arrayList.Add(zzhqVar);
                    }
                }
                if (arrayList.Count == 0) {
                    this.zza.zzu.zzaW().zzh().zzb("No unique parameters in main event. eventName", str2);
                } else {
                    arrayList.addAll(listZzi);
                    listZzi = arrayList;
                }
                strZzh = str2;
            } else {
                this.zzc = l;
                this.zzb = zzhmVar;
                zzpvVar.zzA();
                long jlongValue = ((java.lang.long) com.google.android.gms.measurement.internal.zzqa.zzI(zzhmVar, "_epc", 0L)).longValue();
                this.zzd = jlongValue;
                if (jlongValue > 0) {
                    zzpvVar.zzj().zzaf(str, (java.lang.long) com.google.android.gms.common.internal.Preconditions.checkNotNull(l), this.zzd, zzhmVar);
                } else {
                    zzaeVar.zzu.zzaW().zzh().zzb("Complex event with zero extra param count. eventName", strZzh);
                }
            }
        }
        com.google.android.gms.internal.measurement.zzhl zzhlVar2 = (com.google.android.gms.internal.measurement.zzhl) zzhmVar.zzch();
        zzhlVar2.zzi(strZzh);
        zzhlVar2.zzg();
        zzhlVar2.zzd(listZzi);
        return (com.google.android.gms.internal.measurement.zzhm) zzhlVar2.zzba();
    }
}

