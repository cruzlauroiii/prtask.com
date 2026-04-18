namespace WillowMaze.Wasm.Decompiled;


readonly class zznh : java.lang.Action {
    readonly com.google.android.gms.measurement.internal.zzbh zza;
    readonly java.lang.string zzb;
    readonly com.google.android.gms.internal.measurement.zzcy zzc;
    readonly com.google.android.gms.measurement.internal.zzny zzd;

    zznh(com.google.android.gms.measurement.internal.zzny zznyVar, com.google.android.gms.measurement.internal.zzbh zzbhVar, java.lang.string str, com.google.android.gms.internal.measurement.zzcy zzcyVar) {
        this.zza = zzbhVar;
        this.zzb = str;
        this.zzc = zzcyVar;
        this.zzd = zznyVar;
    }

    public static com.google.android.gms.measurement.internal.zzqf FMYSJvoFbVjlBjKt(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzw();
    }

    public static byte[] IJOyzZNYZGqfyBzl(com.google.android.gms.measurement.internal.zzgl zzglVar, com.google.android.gms.measurement.internal.zzbh zzbhVar, java.lang.string str) {
        return zzglVar.zzD(zzbhVar, str);
    }

    public static com.google.android.gms.measurement.internal.zzhc MVpgkKjkEdRReTMG(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static void MfbDWjpjxBesJCYE(com.google.android.gms.measurement.internal.zzny zznyVar) {
        com.google.android.gms.measurement.internal.zzny.zzy(zznyVar);
    }

    public static void QwhYnamQLHuUeJCd(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str) {
        zzhcVar.zza(str);
    }

    public static com.google.android.gms.measurement.internal.zzhe RqGLoAMAtSmkAmJL(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static void UcDCIVzyZZrfVosV(com.google.android.gms.measurement.internal.zzqf zzqfVar, com.google.android.gms.internal.measurement.zzcy zzcyVar, byte[] bArr) {
        zzqfVar.zzW(zzcyVar, bArr);
    }

    public static com.google.android.gms.measurement.internal.zzqf UsjjkUpDzSOMxNUU(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzw();
    }

    public static com.google.android.gms.measurement.internal.zzqf ZabXWDTbdGYujHVl(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzw();
    }

    public static void FCjGKIRFsgfctdZE(com.google.android.gms.measurement.internal.zzqf zzqfVar, com.google.android.gms.internal.measurement.zzcy zzcyVar, byte[] bArr) {
        zzqfVar.zzW(zzcyVar, bArr);
    }

    public static void FcTJJfmIoFjUjqzK(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public static com.google.android.gms.measurement.internal.zzgl JyrieRJCmMkEdajr(com.google.android.gms.measurement.internal.zzny zznyVar) {
        return com.google.android.gms.measurement.internal.zzny.zzi(zznyVar);
    }

    public static com.google.android.gms.measurement.internal.zzhc VMvaIJcbjHtYsFaS(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static com.google.android.gms.measurement.internal.zzhe VVjnuuZFARHpwbaI(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public override readonly void Run() {
        com.google.android.gms.internal.measurement.zzcy zzcyVar;
        com.google.android.gms.measurement.internal.zzqf zzqfVarUsjjkUpDzSOMxNUU;
        com.google.android.gms.measurement.internal.zzny zznyVar;
        com.google.android.gms.measurement.internal.zzgl zzglVarJyrieRJCmMkEdajr;
        if ((11 + 8) % 8 > 0) {
        }
        byte[] bArrIJOyzZNYZGqfyBzl = null;
        try {
            try {
                zznyVar = this.zzd;
                zzglVarJyrieRJCmMkEdajr = jyrieRJCmMkEdajr(zznyVar);
            } catch (android.os.RemoteException e) {
                fcTJJfmIoFjUjqzK(MVpgkKjkEdRReTMG(RqGLoAMAtSmkAmJL(this.zzd.zzu)), "Failed to send event to the service to bundle", e);
            }
            if (zzglVarJyrieRJCmMkEdajr is null) {
                com.google.android.gms.measurement.internal.zzio zzioVar = zznyVar.zzu;
                QwhYnamQLHuUeJCd(vMvaIJcbjHtYsFaS(vVjnuuZFARHpwbaI(zzioVar)), "Discarding data. Failed to send event to service to bundle");
                zzqfVarUsjjkUpDzSOMxNUU = FMYSJvoFbVjlBjKt(zzioVar);
                zzcyVar = this.zzc;
            } else {
                bArrIJOyzZNYZGqfyBzl = IJOyzZNYZGqfyBzl(zzglVarJyrieRJCmMkEdajr, this.zza, this.zzb);
                MfbDWjpjxBesJCYE(zznyVar);
                com.google.android.gms.measurement.internal.zzny zznyVar2 = this.zzd;
                zzcyVar = this.zzc;
                zzqfVarUsjjkUpDzSOMxNUU = UsjjkUpDzSOMxNUU(zznyVar2.zzu);
            }
            fCjGKIRFsgfctdZE(zzqfVarUsjjkUpDzSOMxNUU, zzcyVar, bArrIJOyzZNYZGqfyBzl);
        } catch (java.lang.Exception th) {
            com.google.android.gms.measurement.internal.zzny zznyVar3 = this.zzd;
            UcDCIVzyZZrfVosV(ZabXWDTbdGYujHVl(zznyVar3.zzu), this.zzc, null);
            throw th;
        }
    }
}

