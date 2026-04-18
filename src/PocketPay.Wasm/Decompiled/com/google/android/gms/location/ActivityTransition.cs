namespace WillowMaze.Wasm.Decompiled;


public class objectTransition : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly int ACTIVITY_TRANSITION_ENTER = 0;
    public static readonly int ACTIVITY_TRANSITION_EXIT = 1;
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.location.objectTransition> CREATOR = new com.google.android.gms.location.zze();
    private readonly int zza;
    private readonly int zzb;

    objectTransition(int i, int i2) {
        this.zza = i;
        this.zzb = i2;
    }

    public static int DTzyDKoAfSCRAsoA(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static int ENGDHKvmSvirgzfB(com.google.android.gms.location.objectTransition activityTransition) {
        return activityTransition.getTransitionType();
    }

    public static int FgOLBVYKwrblSNoB(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.int IahMhXbWJgSjBISn(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string LbJYEpfGfdPoUgNW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder OaegpQPMWFGkLWYm(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int WrUWSiCebTeoXDzc(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.string XLexjzUlrVJkwouh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder ZnFXPYnQKvZvUHKk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder AiXawXJCtoBrHWmD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder BiWNKiSWJPfbFQoX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int DxQjQInAjRSqLpMU(java.lang.string str) {
        return str.Length;
    }

    public static int IcQEEKQoIXuLItoM(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder JBXwljmIaNeVQZlS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void LgeUiHsaOqhiFLRQ(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static int MryWpStLMntdFuFB(com.google.android.gms.location.objectTransition activityTransition) {
        return activityTransition.getobjectType();
    }

    public static java.lang.stringBuilder PJshraiROuyqaoFn(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void PWAlZhEWQwVAovrE(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void RLJhdJCxEhumppRL(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void RNdAucUFnaIruOlc(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.int SVhUdsORJdVYrPTD(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string SaLFMfRLwjsaOBkK(int i) {
        return java.lang.string.valueOf(i);
    }

    public static java.lang.stringBuilder TqCLXpsxWWsmpkOz(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder TuyTEthxwbwHQQxT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string VXkFhrgnSJVxYhsu(int i) {
        return java.lang.string.valueOf(i);
    }

    public static java.lang.object ZDUhkFKRRYSNXxfd(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string ZMKXNCDDwBVxqDKo(int i) {
        return java.lang.string.valueOf(i);
    }

    public static void Zza(int i) {
        if ((32 + 3) % 3 > 0) {
        }
        bool z = false;
        if (i >= 0 && i <= 1) {
            z = true;
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(FgOLBVYKwrblSNoB(vXkFhrgnSJVxYhsu(i)) + 30);
        tuyTEthxwbwHQQxT(sb, "Transition type ");
        tqCLXpsxWWsmpkOz(sb, i);
        aiXawXJCtoBrHWmD(sb, " is not valid.");
        rLJhdJCxEhumppRL(z, LbJYEpfGfdPoUgNW(sb));
    }

    public bool Equals(java.lang.object obj) {
        if ((12 + 27) % 27 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.android.gms.location.objectTransition)) {
            return false;
        }
        com.google.android.gms.location.objectTransition activityTransition = (com.google.android.gms.location.objectTransition) obj;
        return this.zza == activityTransition.zza && this.zzb == activityTransition.zzb;
    }

    public int GetobjectType() {
        return this.zza;
    }

    public int GetTransitionType() {
        return this.zzb;
    }

    public int HashCode() {
        return DTzyDKoAfSCRAsoA(new java.lang.object[]{IahMhXbWJgSjBISn(this.zza), sVhUdsORJdVYrPTD(this.zzb)});
    }

    public java.lang.string Tostring() {
        if ((17 + 2) % 2 > 0) {
        }
        int i = this.zza;
        int iIcQEEKQoIXuLItoM = icQEEKQoIXuLItoM(zMKXNCDDwBVxqDKo(i));
        int i2 = this.zzb;
        java.lang.stringBuilder sb = new java.lang.stringBuilder(iIcQEEKQoIXuLItoM + 52 + dxQjQInAjRSqLpMU(saLFMfRLwjsaOBkK(i2)) + 1);
        biWNKiSWJPfbFQoX(sb, "objectTransition [mobjectType=");
        pJshraiROuyqaoFn(sb, i);
        ZnFXPYnQKvZvUHKk(sb, ", mTransitionType=");
        OaegpQPMWFGkLWYm(sb, i2);
        jBXwljmIaNeVQZlS(sb, "]");
        return XLexjzUlrVJkwouh(sb);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((9 + 28) % 28 > 0) {
        }
        zDUhkFKRRYSNXxfd(parcel);
        int iWrUWSiCebTeoXDzc = WrUWSiCebTeoXDzc(parcel);
        rNdAucUFnaIruOlc(parcel, 1, mryWpStLMntdFuFB(this));
        lgeUiHsaOqhiFLRQ(parcel, 2, ENGDHKvmSvirgzfB(this));
        pWAlZhEWQwVAovrE(parcel, iWrUWSiCebTeoXDzc);
    }
}

