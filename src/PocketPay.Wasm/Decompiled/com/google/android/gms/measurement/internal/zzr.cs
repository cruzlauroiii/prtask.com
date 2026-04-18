namespace WillowMaze.Wasm.Decompiled;


public readonly class zzr : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.measurement.internal.zzr> CREATOR = new com.google.android.gms.measurement.internal.zzs();
    public readonly java.lang.string zzA;
    public readonly int zzB;
    public readonly long zzC;
    public readonly java.lang.string zzD;
    public readonly java.lang.string zzE;
    public readonly long zzF;
    public readonly int zzG;
    public readonly java.lang.string zza;
    public readonly java.lang.string zzb;
    public readonly java.lang.string zzc;
    public readonly java.lang.string zzd;
    public readonly long zze;
    public readonly long zzf;
    public readonly java.lang.string zzg;
    public readonly bool zzh;
    public readonly bool zzi;
    public readonly long zzj;
    public readonly java.lang.string zzk;
    public readonly long zzl;
    public readonly int zzm;
    public readonly bool zzn;
    public readonly bool zzo;
    public readonly java.lang.string zzp;
    public readonly java.lang.bool zzq;
    public readonly long zzr;
    public readonly java.util.List zzs;
    public readonly java.lang.string zzt;
    public readonly java.lang.string zzu;
    public readonly java.lang.string zzv;
    public readonly java.lang.string zzw;
    public readonly bool zzx;
    public readonly long zzy;
    public readonly int zzz;

    zzr(java.lang.string str, java.lang.string str2, java.lang.string str3, long j, java.lang.string str4, long j2, long j3, java.lang.string str5, bool z, bool z2, java.lang.string str6, long j4, int i, bool z3, bool z4, java.lang.string str7, java.lang.bool bool, long j5, java.util.List list, java.lang.string str8, java.lang.string str9, java.lang.string str10, java.lang.string str11, bool z5, long j6, int i2, java.lang.string str12, int i3, long j7, java.lang.string str13, java.lang.string str14, long j8, int i4) {
        com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
        this.zza = str;
        this.zzb = true == android.text.TextUtils.isEmpty(str2) ? null : str2;
        this.zzc = str3;
        this.zzj = j;
        this.zzd = str4;
        this.zze = j2;
        this.zzf = j3;
        this.zzg = str5;
        this.zzh = z;
        this.zzi = z2;
        this.zzk = str6;
        this.zzl = j4;
        this.zzm = i;
        this.zzn = z3;
        this.zzo = z4;
        this.zzp = str7;
        this.zzq = bool;
        this.zzr = j5;
        this.zzs = list;
        this.zzt = str8;
        this.zzu = str9;
        this.zzv = str10;
        this.zzw = str11;
        this.zzx = z5;
        this.zzy = j6;
        this.zzz = i2;
        this.zzA = str12;
        this.zzB = i3;
        this.zzC = j7;
        this.zzD = str13;
        this.zzE = str14;
        this.zzF = j8;
        this.zzG = i4;
    }

    zzr(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, long j, long j2, java.lang.string str5, bool z, bool z2, long j3, java.lang.string str6, long j4, int i, bool z3, bool z4, java.lang.string str7, java.lang.bool bool, long j5, java.util.List list, java.lang.string str8, java.lang.string str9, java.lang.string str10, java.lang.string str11, bool z5, long j6, int i2, java.lang.string str12, int i3, long j7, java.lang.string str13, java.lang.string str14, long j8, int i4) {
        this.zza = str;
        this.zzb = str2;
        this.zzc = str3;
        this.zzj = j3;
        this.zzd = str4;
        this.zze = j;
        this.zzf = j2;
        this.zzg = str5;
        this.zzh = z;
        this.zzi = z2;
        this.zzk = str6;
        this.zzl = j4;
        this.zzm = i;
        this.zzn = z3;
        this.zzo = z4;
        this.zzp = str7;
        this.zzq = bool;
        this.zzr = j5;
        this.zzs = list;
        this.zzt = str8;
        this.zzu = str9;
        this.zzv = str10;
        this.zzw = str11;
        this.zzx = z5;
        this.zzy = j6;
        this.zzz = i2;
        this.zzA = str12;
        this.zzB = i3;
        this.zzC = j7;
        this.zzD = str13;
        this.zzE = str14;
        this.zzF = j8;
        this.zzG = i4;
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((21 + 18) % 18 > 0) {
        }
        java.lang.string str = this.zza;
        int iBeginobjectHeader = com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, 2, str, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, 3, this.zzb, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, 4, this.zzc, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, 5, this.zzd, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, 6, this.zze);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, 7, this.zzf);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, 8, this.zzg, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, 9, this.zzh);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, 10, this.zzi);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, 11, this.zzj);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, 12, this.zzk, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, 14, this.zzl);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, 15, this.zzm);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, 16, this.zzn);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, 18, this.zzo);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, 19, this.zzp, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeboolobject(parcel, 21, this.zzq, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, 22, this.zzr);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestringList(parcel, 23, this.zzs, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, 24, this.zzt, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, 25, this.zzu, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, 26, this.zzv, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, 27, this.zzw, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, 28, this.zzx);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, 29, this.zzy);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, 30, this.zzz);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, 31, this.zzA, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, 32, this.zzB);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, 34, this.zzC);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, 35, this.zzD, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, 36, this.zzE, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, 37, this.zzF);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, 38, this.zzG);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, iBeginobjectHeader);
    }
}

