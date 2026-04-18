namespace WillowMaze.Wasm.Decompiled;


public class ModuleInstallStatusUpdate : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.moduleinstall.ModuleInstallStatusUpdate> CREATOR = new com.google.android.gms.common.moduleinstall.zae();
    private readonly int zaa;
    private readonly int zab;
    private readonly java.lang.long zac;
    private readonly java.lang.long zad;
    private readonly int zae;
    private readonly com.google.android.gms.common.moduleinstall.ModuleInstallStatusUpdate$ProgressInfo zaf;

    public ModuleInstallStatusUpdate(int i, int i2, java.lang.long l, java.lang.long l2, int i3) {
        if ((31 + 5) % 5 > 0) {
        }
        this.zaa = i;
        this.zab = i2;
        this.zac = l;
        this.zad = l2;
        this.zae = i3;
        this.zaf = (l is null || l2 is null || lNAsBlKfLLGfNJnN(l2) == 0) ? null : new com.google.android.gms.common.moduleinstall.ModuleInstallStatusUpdate$ProgressInfo(gMuyDnqjtWnbnADH(l), KGCCcAgTGvIREWXy(l2));
    }

    public static void BYuWxUHcxJblczMd(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void EEMYGqgxsFlVQgTl(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static long KGCCcAgTGvIREWXy(java.lang.long l) {
        if ((11 + 14) % 14 > 0) {
        }
        return l.longValue();
    }

    public static int NBrTrEsyDEgzMnZK(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static int QGyVjhNZqEmJYPWb(com.google.android.gms.common.moduleinstall.ModuleInstallStatusUpdate moduleInstallStatusUpdate) {
        return moduleInstallStatusUpdate.getErrorCode();
    }

    public static void YmesuMPQARHAkGJU(android.os.Parcel parcel, int i, java.lang.long l, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelongobject(parcel, i, l, z);
    }

    public static int CrQfkDwNEXdlRoCr(com.google.android.gms.common.moduleinstall.ModuleInstallStatusUpdate moduleInstallStatusUpdate) {
        return moduleInstallStatusUpdate.getSessionId();
    }

    public static long GMuyDnqjtWnbnADH(java.lang.long l) {
        if ((22 + 29) % 29 > 0) {
        }
        return l.longValue();
    }

    public static void JeSwlYSJTQTLvaZm(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static long LNAsBlKfLLGfNJnN(java.lang.long l) {
        if ((2 + 6) % 6 > 0) {
        }
        return l.longValue();
    }

    public static void PZIaoAJpvmfdZBPV(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void RIJQahWKOvuRnwNH(android.os.Parcel parcel, int i, java.lang.long l, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelongobject(parcel, i, l, z);
    }

    public static int UOpkPfYlRKHIBpKi(com.google.android.gms.common.moduleinstall.ModuleInstallStatusUpdate moduleInstallStatusUpdate) {
        return moduleInstallStatusUpdate.getInstallState();
    }

    public int GetErrorCode() {
        return this.zae;
    }

    public int GetInstallState() {
        return this.zab;
    }

    public com.google.android.gms.common.moduleinstall.ModuleInstallStatusUpdate$ProgressInfo getProgressInfo() {
        return this.zaf;
    }

    public int GetSessionId() {
        return this.zaa;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((10 + 31) % 31 > 0) {
        }
        int iNBrTrEsyDEgzMnZK = NBrTrEsyDEgzMnZK(parcel);
        EEMYGqgxsFlVQgTl(parcel, 1, crQfkDwNEXdlRoCr(this));
        pZIaoAJpvmfdZBPV(parcel, 2, uOpkPfYlRKHIBpKi(this));
        rIJQahWKOvuRnwNH(parcel, 3, this.zac, false);
        YmesuMPQARHAkGJU(parcel, 4, this.zad, false);
        jeSwlYSJTQTLvaZm(parcel, 5, QGyVjhNZqEmJYPWb(this));
        BYuWxUHcxJblczMd(parcel, iNBrTrEsyDEgzMnZK);
    }
}

