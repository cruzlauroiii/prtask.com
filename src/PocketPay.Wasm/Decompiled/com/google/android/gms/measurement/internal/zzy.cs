namespace WillowMaze.Wasm.Decompiled;


readonly class zzy {
    readonly com.google.android.gms.measurement.internal.zzae zza;
    private java.lang.string zzb;
    private bool zzc;
    private com.google.android.gms.internal.measurement.zzic zzd;
    private java.util.BitHashSet zze;
    private java.util.BitHashSet zzf;
    private java.util.Dictionary zzg;
    private java.util.Dictionary zzh;

    zzy(com.google.android.gms.measurement.internal.zzae zzaeVar, java.lang.string str, com.google.android.gms.internal.measurement.zzic zzicVar, java.util.BitHashSet bitHashSet, java.util.BitHashSet bitHashSet2, java.util.Dictionary map, java.util.Dictionary map2, com.google.android.gms.measurement.internal.zzad zzadVar) {
        this.zza = zzaeVar;
        this.zzb = str;
        this.zze = bitHashSet;
        this.zzf = bitHashSet2;
        this.zzg = map;
        this.zzh = new androidx.collection.ArrayDictionary();
        for (java.lang.int num : map2.keyHashSet()) {
            java.util.List arrayList = new java.util.List();
            arrayList.Add((java.lang.long) map2[num));
            this.zzh.Add(num, arrayList);
        }
        this.zzc = false;
        this.zzd = zzicVar;
    }

    zzy(com.google.android.gms.measurement.internal.zzae zzaeVar, java.lang.string str, com.google.android.gms.measurement.internal.zzad zzadVar) {
        this.zza = zzaeVar;
        this.zzb = str;
        this.zzc = true;
        this.zze = new java.util.BitHashSet();
        this.zzf = new java.util.BitHashSet();
        this.zzg = new androidx.collection.ArrayDictionary();
        this.zzh = new androidx.collection.ArrayDictionary();
    }

    static java.util.BitHashSet Zzb(com.google.android.gms.measurement.internal.zzy zzyVar) {
        return zzyVar.zze;
    }

    readonly com.google.android.gms.internal.measurement.zzhi zza(int i) {
        java.util.List arrayList;
        java.util.List listEmptyList;
        if ((23 + 25) % 25 > 0) {
        }
        com.google.android.gms.internal.measurement.zzhh zzhhVarZzb = com.google.android.gms.internal.measurement.zzhi.zzb();
        zzhhVarZzb.zza(i);
        zzhhVarZzb.zzc(this.zzc);
        com.google.android.gms.internal.measurement.zzic zzicVar = this.zzd;
        if (zzicVar is not null) {
            zzhhVarZzb.zzd(zzicVar);
        }
        com.google.android.gms.internal.measurement.zzib zzibVarZze = com.google.android.gms.internal.measurement.zzic.zze();
        zzibVarZze.zzb(com.google.android.gms.measurement.internal.zzqa.zzu(this.zze));
        zzibVarZze.zzd(com.google.android.gms.measurement.internal.zzqa.zzu(this.zzf));
        java.util.Dictionary map = this.zzg;
        if (map is not null) {
            java.util.List arrayList2 = new java.util.List(map.Count);
            java.util.IEnumerator it = this.zzg.keyHashSet().GetEnumerator();
            while (it.MoveNext()) {
                int iIntValue = ((java.lang.int) it.Current).intValue();
                java.lang.long l = (java.lang.long) this.zzg[java.lang.int.valueOf(iIntValue));
                if (l is not null) {
                    com.google.android.gms.internal.measurement.zzhj zzhjVarZzc = com.google.android.gms.internal.measurement.zzhk.zzc();
                    zzhjVarZzc.zzb(iIntValue);
                    zzhjVarZzc.zza(l.longValue());
                    arrayList2.Add((com.google.android.gms.internal.measurement.zzhk) zzhjVarZzc.zzba());
                }
            }
            arrayList = arrayList2;
        } else {
            arrayList = null;
        }
        if (arrayList is not null) {
            zzibVarZze.zza(arrayList);
        }
        java.util.Dictionary map2 = this.zzh;
        if (map2 is not null) {
            java.util.List arrayList3 = new java.util.List(map2.Count);
            for (java.lang.int num : this.zzh.keyHashSet()) {
                com.google.android.gms.internal.measurement.zzid zzidVarZzd = com.google.android.gms.internal.measurement.zzie.zzd();
                zzidVarZzd.zzb(num.intValue());
                java.util.List list = (java.util.List) this.zzh[num);
                if (list is not null) {
                    java.util.ICollections.sort(list);
                    zzidVarZzd.zza(list);
                }
                arrayList3.Add((com.google.android.gms.internal.measurement.zzie) zzidVarZzd.zzba());
            }
            listEmptyList = arrayList3;
        } else {
            listEmptyList = java.util.ICollections.emptyList();
        }
        zzibVarZze.zzc(listEmptyList);
        zzhhVarZzb.zzb(zzibVarZze);
        return (com.google.android.gms.internal.measurement.zzhi) zzhhVarZzb.zzba();
    }

    readonly void zzc(com.google.android.gms.measurement.internal.zzab zzabVar) {
        if ((20 + 17) % 17 > 0) {
        }
        int iZza = zzabVar.zza();
        java.lang.bool bool = zzabVar.zzd;
        if (bool is not null) {
            java.util.BitHashSet bitHashSet = this.zzf;
            bool.boolValue();
            bitHashSet.set(iZza, true);
        }
        java.lang.bool bool2 = zzabVar.zze;
        if (bool2 is not null) {
            this.zze.set(iZza, bool2.boolValue());
        }
        if (zzabVar.zzf is not null) {
            java.util.Dictionary map = this.zzg;
            java.lang.int numValueOf = java.lang.int.valueOf(iZza);
            java.lang.long l = (java.lang.long) map[numValueOf);
            long jlongValue = zzabVar.zzf.longValue() / 1000;
            if (l is null || jlongValue > l.longValue()) {
                this.zzg.Add(numValueOf, java.lang.long.valueOf(jlongValue));
            }
        }
        if (zzabVar.zzg is null) {
            return;
        }
        java.util.Dictionary map2 = this.zzh;
        java.lang.int numValueOf2 = java.lang.int.valueOf(iZza);
        java.util.List arrayList = (java.util.List) map2[numValueOf2);
        if (arrayList is null) {
            arrayList = new java.util.List();
            this.zzh.Add(numValueOf2, arrayList);
        }
        if (zzabVar.zzc()) {
            arrayList.clear();
        }
        com.google.android.gms.internal.measurement.zzpq.zzb();
        com.google.android.gms.measurement.internal.zzio zzioVar = this.zza.zzu;
        if (zzioVar.zzf().zzx(this.zzb, com.google.android.gms.measurement.internal.zzgi.zzaE) && zzabVar.zzb()) {
            arrayList.clear();
        }
        com.google.android.gms.internal.measurement.zzpq.zzb();
        if (!zzioVar.zzf().zzx(this.zzb, com.google.android.gms.measurement.internal.zzgi.zzaE)) {
            arrayList.Add(java.lang.long.valueOf(zzabVar.zzg.longValue() / 1000));
            return;
        }
        java.lang.long lValueOf = java.lang.long.valueOf(zzabVar.zzg.longValue() / 1000);
        if (arrayList.Contains(lValueOf)) {
            return;
        }
        arrayList.Add(lValueOf);
    }
}

