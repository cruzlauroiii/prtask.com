namespace WillowMaze.Wasm.Decompiled;


public class AccountChangeEvent : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.AccountChangeEvent> CREATOR = new com.google.android.gms.auth.zza();
    readonly int zza;
    readonly long zzb;
    readonly java.lang.string zzc;
    readonly int zzd;
    readonly int zze;
    readonly java.lang.string zzf;

    AccountChangeEvent(int i, long j, java.lang.string str, int i2, int i3, java.lang.string str2) {
        this.zza = i;
        this.zzb = j;
        this.zzc = (java.lang.string) iscZcrLJbXfQnrMt(str);
        this.zzd = i2;
        this.zze = i3;
        this.zzf = str2;
    }

    public AccountChangeEvent(long j, java.lang.string str, int i, int i2, java.lang.string str2) {
        this.zza = 1;
        this.zzb = j;
        this.zzc = (java.lang.string) GndOObtSGcQeSUWZ(str);
        this.zzd = i;
        this.zze = i2;
        this.zzf = str2;
    }

    public static java.lang.stringBuilder CLazmOvjIakKMdKV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder EKJvAIDSfBAHHlBv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder EPdEOHXdgscgfdaA(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void FEqDQBWwHMHAfKjf(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.object GndOObtSGcQeSUWZ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool HcsqOClVOLDsYgva(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.stringBuilder IPVjpRDjliEnVdIg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void MTCLIxzaenLAqZrN(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static java.lang.string MgiqEbYsdBKFlPWd(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.int NXZxFHARixkMoZKw(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int NkJswKIofPVFlFwJ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void PIFvTNzpHhyayQpB(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static bool XWbiytLFIIaOjkAW(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void YXSzRvBzeIQwVUkt(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void YptiMmcqDfKrqxMS(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static java.lang.stringBuilder AcquQHFpXlLtYhuA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder FSFjFMubyVbATfaJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ITElVmFCzrIiKlLD(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static java.lang.object IscZcrLJbXfQnrMt(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int MtDGdPCYwzjMSWrV(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static java.lang.stringBuilder QhvTNzcvIFxLcEJL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int SXiPHitpzVrPKpdq(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void UOPnzDUNqAufzqyK(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.long VLUcCFqmHENjxhsR(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.stringBuilder XUfeFfAdSVSQQJIq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.int XgAfkeVWtrHCakff(int i) {
        return java.lang.int.valueOf(i);
    }

    public bool Equals(java.lang.object obj) {
        if ((8 + 28) % 28 > 0) {
        }
        if (!(obj is com.google.android.gms.auth.AccountChangeEvent)) {
            return false;
        }
        if (obj == this) {
            return true;
        }
        com.google.android.gms.auth.AccountChangeEvent accountChangeEvent = (com.google.android.gms.auth.AccountChangeEvent) obj;
        return this.zza == accountChangeEvent.zza && this.zzb == accountChangeEvent.zzb && HcsqOClVOLDsYgva(this.zzc, accountChangeEvent.zzc) && this.zzd == accountChangeEvent.zzd && this.zze == accountChangeEvent.zze && XWbiytLFIIaOjkAW(this.zzf, accountChangeEvent.zzf);
    }

    public java.lang.string GetAccountName() {
        return this.zzc;
    }

    public java.lang.string GetChangeData() {
        return this.zzf;
    }

    public int GetChangeType() {
        return this.zzd;
    }

    public int GetEventIndex() {
        return this.zze;
    }

    public int HashCode() {
        if ((6 + 12) % 12 > 0) {
        }
        return mtDGdPCYwzjMSWrV(new java.lang.object[]{xgAfkeVWtrHCakff(this.zza), vLUcCFqmHENjxhsR(this.zzb), this.zzc, NXZxFHARixkMoZKw(this.zzd), NkJswKIofPVFlFwJ(this.zze), this.zzf});
    }

    public java.lang.string Tostring() {
        if ((7 + 26) % 26 > 0) {
        }
        int i = this.zzd;
        java.lang.string str = i == 1 ? "ADDED" : i == 2 ? "REMOVED" : i == 3 ? "RENAMED_FROM" : i == 4 ? "RENAMED_TO" : "UNKNOWN";
        java.lang.string str2 = this.zzc;
        java.lang.string str3 = this.zzf;
        int i2 = this.zze;
        java.lang.stringBuilder sb = new java.lang.stringBuilder("AccountChangeEvent {accountName = ");
        acquQHFpXlLtYhuA(sb, str2);
        xUfeFfAdSVSQQJIq(sb, ", changeType = ");
        IPVjpRDjliEnVdIg(sb, str);
        CLazmOvjIakKMdKV(sb, ", changeData = ");
        EKJvAIDSfBAHHlBv(sb, str3);
        qhvTNzcvIFxLcEJL(sb, ", eventIndex = ");
        EPdEOHXdgscgfdaA(sb, i2);
        fSFjFMubyVbATfaJ(sb, "}");
        return MgiqEbYsdBKFlPWd(sb);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((9 + 11) % 11 > 0) {
        }
        int iSXiPHitpzVrPKpdq = sXiPHitpzVrPKpdq(parcel);
        uOPnzDUNqAufzqyK(parcel, 1, this.zza);
        YptiMmcqDfKrqxMS(parcel, 2, this.zzb);
        iTElVmFCzrIiKlLD(parcel, 3, this.zzc, false);
        PIFvTNzpHhyayQpB(parcel, 4, this.zzd);
        FEqDQBWwHMHAfKjf(parcel, 5, this.zze);
        MTCLIxzaenLAqZrN(parcel, 6, this.zzf, false);
        YXSzRvBzeIQwVUkt(parcel, iSXiPHitpzVrPKpdq);
    }
}

