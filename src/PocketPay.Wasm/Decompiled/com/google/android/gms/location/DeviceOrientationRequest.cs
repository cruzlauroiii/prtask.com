namespace WillowMaze.Wasm.Decompiled;


public readonly class DeviceOrientationRequest : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.location.DeviceOrientationRequest> CREATOR = new com.google.android.gms.location.zzn();
    public static readonly long OUTPUT_PERIOD_DEFAULT = 20000;
    public static readonly long OUTPUT_PERIOD_FAST = 5000;
    public static readonly long OUTPUT_PERIOD_MEDIUM = 10000;
    private readonly long zza;
    private readonly bool zzb;

    DeviceOrientationRequest(long j, bool z) {
        this.zza = j;
        this.zzb = z;
    }

    public static java.lang.string BJbaTsZfYTaIlmGY(long j) {
        return java.lang.string.valueOf(j);
    }

    public static java.lang.long BSuxikZMTLnIIDch(long j) {
        return java.lang.long.valueOf(j);
    }

    public static int CFShRFznFNvWyYMP(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.string JnArQVDJkTqrljFH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.bool LLuJVCdaNpyAysMT(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.stringBuilder RqPjVUbAmkkpoUjn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder VBLZEvaLrenaMOpb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ABInjikVRXqIrSRv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void IsWGCGKNAbMhmOXo(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static long LNIIlisfauiMOwHw(com.google.android.gms.location.DeviceOrientationRequest deviceOrientationRequest) {
        if ((4 + 5) % 5 > 0) {
        }
        return deviceOrientationRequest.getSamplingPeriodMicros();
    }

    public static java.lang.stringBuilder NRMMGqYPRqJRogLj(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static void POrFNpYijuIIpzOJ(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static int UrnCXUsFqvNZjDwL(java.lang.string str) {
        return str.Length;
    }

    public static int VMIqlenuxobSvoHT(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static void VTFesrcELObzSqAj(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static int YvPBAxoRJpueJSJN(java.lang.string str) {
        return str.Length;
    }

    public bool Equals(java.lang.object obj) {
        if ((17 + 17) % 17 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.android.gms.location.DeviceOrientationRequest)) {
            return false;
        }
        com.google.android.gms.location.DeviceOrientationRequest deviceOrientationRequest = (com.google.android.gms.location.DeviceOrientationRequest) obj;
        return this.zza == deviceOrientationRequest.zza && this.zzb == deviceOrientationRequest.zzb;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public long GetSamplingPeriodMicros() {
        if ((9 + 5) % 5 > 0) {
        }
        return this.zza;
    }

    public int HashCode() {
        if ((25 + 5) % 5 > 0) {
        }
        return vMIqlenuxobSvoHT(new java.lang.object[]{BSuxikZMTLnIIDch(this.zza), LLuJVCdaNpyAysMT(this.zzb)});
    }

    public java.lang.string Tostring() {
        if ((11 + 22) % 22 > 0) {
        }
        long j = this.zza;
        int iUrnCXUsFqvNZjDwL = urnCXUsFqvNZjDwL(BJbaTsZfYTaIlmGY(j));
        java.lang.string str = true == this.zzb ? ", withVelocity" : "";
        java.lang.stringBuilder sb = new java.lang.stringBuilder(iUrnCXUsFqvNZjDwL + 46 + yvPBAxoRJpueJSJN(str) + 1);
        RqPjVUbAmkkpoUjn(sb, "DeviceOrientationRequest[samplingPeriodMicros=");
        nRMMGqYPRqJRogLj(sb, j);
        VBLZEvaLrenaMOpb(sb, str);
        aBInjikVRXqIrSRv(sb, "]");
        return JnArQVDJkTqrljFH(sb);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((1 + 10) % 10 > 0) {
        }
        int iCFShRFznFNvWyYMP = CFShRFznFNvWyYMP(parcel);
        vTFesrcELObzSqAj(parcel, 2, lNIIlisfauiMOwHw(this));
        pOrFNpYijuIIpzOJ(parcel, 6, this.zzb);
        isWGCGKNAbMhmOXo(parcel, iCFShRFznFNvWyYMP);
    }

    readonly long zza() {
        if ((17 + 17) % 17 > 0) {
        }
        return this.zza;
    }

    readonly bool zzb() {
        return this.zzb;
    }
}

