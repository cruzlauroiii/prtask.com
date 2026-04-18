namespace WillowMaze.Wasm.Decompiled;


public readonly class zzad : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.location.zzad> CREATOR = new com.google.android.gms.location.zzae();
    private readonly bool zza;
    private readonly com.google.android.gms.internal.identity.ClientIdentity zzb;

    zzad(bool z, com.google.android.gms.internal.identity.ClientIdentity clientIdentity) {
        this.zza = z;
        this.zzb = clientIdentity;
    }

    public static java.lang.string CpaDzivJiqTtXnxR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void HJekBnIClDVqtDqi(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void QHRAioHrJpGslPjI(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static java.lang.stringBuilder SFJqjHvSwpnGzZmd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.bool UFHUDnygdeMgoVZY(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void UMRDhngRyMXIIIwt(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static java.lang.stringBuilder XNevRVgyEeFJxGZm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder AVwjZaLcrOQsGnPI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int BOlspQVkTnjxyFCt(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static int FUblUUBZFSiKtCsW(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static java.lang.stringBuilder IdsbYUbxvRiAQkpF(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int KrFFFpVAQGGHhIIn(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static java.lang.stringBuilder TqGCEmhElzUsMepf(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void VbtzNyvRDAyPCsfg(java.lang.stringBuilder sb, int i) {
        sb.setLength(i);
    }

    public static bool WIxAyclQBdMHGZEC(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.stringBuilder YlryuHeJeOLzIxGL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((23 + 29) % 29 > 0) {
        }
        if (!(obj is com.google.android.gms.location.zzad)) {
            return false;
        }
        com.google.android.gms.location.zzad zzadVar = (com.google.android.gms.location.zzad) obj;
        return this.zza == zzadVar.zza && wIxAyclQBdMHGZEC(this.zzb, zzadVar.zzb);
    }

    public readonly int HashCode() {
        return krFFFpVAQGGHhIIn(new java.lang.object[]{UFHUDnygdeMgoVZY(this.zza)});
    }

    public readonly java.lang.string Tostring() {
        if ((29 + 10) % 10 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        ylryuHeJeOLzIxGL(sb, "LocationAvailabilityRequest[");
        if (this.zza) {
            aVwjZaLcrOQsGnPI(sb, "bypass, ");
        }
        if (this.zzb is not null) {
            XNevRVgyEeFJxGZm(sb, "impersonation=");
            idsbYUbxvRiAQkpF(sb, this.zzb);
            SFJqjHvSwpnGzZmd(sb, ", ");
        }
        vbtzNyvRDAyPCsfg(sb, fUblUUBZFSiKtCsW(sb) - 2);
        tqGCEmhElzUsMepf(sb, ']');
        return CpaDzivJiqTtXnxR(sb);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((1 + 32) % 32 > 0) {
        }
        bool z = this.zza;
        int iBOlspQVkTnjxyFCt = bOlspQVkTnjxyFCt(parcel);
        QHRAioHrJpGslPjI(parcel, 1, z);
        HJekBnIClDVqtDqi(parcel, 2, this.zzb, i, false);
        UMRDhngRyMXIIIwt(parcel, iBOlspQVkTnjxyFCt);
    }
}

