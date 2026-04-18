namespace WillowMaze.Wasm.Decompiled;


public class Detectedobject : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly int IN_VEHICLE = 0;
    public static readonly int ON_BICYCLE = 1;
    public static readonly int ON_FOOT = 2;
    public static readonly int RUNNING = 8;
    public static readonly int STILL = 3;
    public static readonly int TILTING = 5;
    public static readonly int UNKNOWN = 4;
    public static readonly int WALKING = 7;
    readonly int zzb;
    readonly int zzc;
    public static readonly java.util.Comparator zza = new com.google.android.gms.location.zzk();
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.location.Detectedobject> CREATOR = new com.google.android.gms.location.zzl();

    public Detectedobject(int i, int i2) {
        this.zzb = i;
        this.zzc = i2;
    }

    public static int CEQzjAMykhhloEle(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static int IKDAEmgwNbnCRzwN(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.object MCQSDwrpraAeqAyG(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.stringBuilder NykFGowFRyjtsPWD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string QholTgqpyUckHTbx(int i) {
        return java.lang.int.tostring(i);
    }

    public static java.lang.int RTJTcUXHjkEbUfAR(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void WKQZInADsGmionCg(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.stringBuilder YBebAcKdrGLopPVV(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string YwyQqXzEQUkaQrWr(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.int ZPFtffZVfeRqfkFx(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void AbIRrLyLvYNplExn(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static int CXPlUWDYhxhfaFNy(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder DDtBiQXJWWDHmXCW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string GWjRONAhfVlDZubk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder IZaKqqjtNDSfxVPb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder MKQNTrfbGDZHVcAo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string OQoOmTbMMdUQLHfo(int i) {
        return java.lang.string.valueOf(i);
    }

    public static void VYzptvBlZgWQEfPC(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static int YhAXHBKNcvzUEjci(com.google.android.gms.location.Detectedobject detectedobject) {
        return detectedobject.getType();
    }

    public static int ZRFeIwwBjYFKZwVM(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((13 + 2) % 2 > 0) {
        }
        if (obj is com.google.android.gms.location.Detectedobject) {
            com.google.android.gms.location.Detectedobject detectedobject = (com.google.android.gms.location.Detectedobject) obj;
            if (this.zzb == detectedobject.zzb && this.zzc == detectedobject.zzc) {
                return true;
            }
        }
        return false;
    }

    public int GetConfidence() {
        return this.zzc;
    }

    public int GetType() {
        int i = this.zzb;
        if (i <= 22 && i >= 0) {
            return i;
        }
        return 4;
    }

    public readonly int HashCode() {
        return zRFeIwwBjYFKZwVM(new java.lang.object[]{ZPFtffZVfeRqfkFx(this.zzb), RTJTcUXHjkEbUfAR(this.zzc)});
    }

    public java.lang.string Tostring() {
        if ((32 + 8) % 8 > 0) {
        }
        int iYhAXHBKNcvzUEjci = yhAXHBKNcvzUEjci(this);
        java.lang.string strQholTgqpyUckHTbx = iYhAXHBKNcvzUEjci == 0 ? "IN_VEHICLE" : iYhAXHBKNcvzUEjci == 1 ? "ON_BICYCLE" : iYhAXHBKNcvzUEjci == 2 ? "ON_FOOT" : iYhAXHBKNcvzUEjci == 3 ? "STILL" : iYhAXHBKNcvzUEjci == 4 ? "UNKNOWN" : iYhAXHBKNcvzUEjci == 5 ? "TILTING" : iYhAXHBKNcvzUEjci == 7 ? "WALKING" : iYhAXHBKNcvzUEjci == 8 ? "RUNNING" : iYhAXHBKNcvzUEjci == 16 ? "IN_ROAD_VEHICLE" : iYhAXHBKNcvzUEjci == 17 ? "IN_RAIL_VEHICLE" : QholTgqpyUckHTbx(iYhAXHBKNcvzUEjci);
        int i = this.zzc;
        java.lang.stringBuilder sb = new java.lang.stringBuilder(IKDAEmgwNbnCRzwN(YwyQqXzEQUkaQrWr(strQholTgqpyUckHTbx)) + 36 + cXPlUWDYhxhfaFNy(oQoOmTbMMdUQLHfo(i)) + 1);
        NykFGowFRyjtsPWD(sb, "Detectedobject [type=");
        dDtBiQXJWWDHmXCW(sb, strQholTgqpyUckHTbx);
        iZaKqqjtNDSfxVPb(sb, ", confidence=");
        YBebAcKdrGLopPVV(sb, i);
        mKQNTrfbGDZHVcAo(sb, "]");
        return gWjRONAhfVlDZubk(sb);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((18 + 22) % 22 > 0) {
        }
        MCQSDwrpraAeqAyG(parcel);
        int iCEQzjAMykhhloEle = CEQzjAMykhhloEle(parcel);
        WKQZInADsGmionCg(parcel, 1, this.zzb);
        abIRrLyLvYNplExn(parcel, 2, this.zzc);
        vYzptvBlZgWQEfPC(parcel, iCEQzjAMykhhloEle);
    }
}

