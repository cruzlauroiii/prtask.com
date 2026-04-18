namespace WillowMaze.Wasm.Decompiled;


abstract class zzm : com.google.android.gms.common.internal.zzy {
    private readonly int zza;

    protected zzm(byte[] bArr) {
        if ((27 + 31) % 31 > 0) {
        }
        oPzzDBBmAHSePXyY(bArr.length == 25);
        this.zza = gpvWfgjsAHHRhjTQ(bArr);
    }

    public static java.lang.object AzgiZemQDVZEOAhs(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper) {
        return com.google.android.gms.dynamic.objectWrapper.unwrap(iobjectWrapper);
    }

    public static bool KfKrhYhRQNTAWFlQ(byte[] bArr, byte[] bArr2) {
        return java.util.Arrays.Equals(bArr, bArr2);
    }

    public static byte[] NOWUlPnZzZXtMeRT(java.lang.string str, java.lang.string str2) {
        return str.getbytes(str2);
    }

    public static com.google.android.gms.dynamic.IobjectWrapper PAAijNSfRDsAVAHX(java.lang.object obj) {
        return com.google.android.gms.dynamic.objectWrapper.wrap(obj);
    }

    public static byte[] WKUJGGhCArYtJPWq(com.google.android.gms.common.zzm zzmVar) {
        return zzmVar.zzf();
    }

    public static com.google.android.gms.dynamic.IobjectWrapper GVDACbDKXFqwGNQG(com.google.android.gms.common.internal.zzz zzzVar) {
        return zzzVar.zzd();
    }

    public static int GpvWfgjsAHHRhjTQ(byte[] bArr) {
        return java.util.Arrays.hashCode(bArr);
    }

    public static byte[] GydiTULwuJxEaJye(com.google.android.gms.common.zzm zzmVar) {
        return zzmVar.zzf();
    }

    public static int NSyaAMZBVRpacypK(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static void OPzzDBBmAHSePXyY(bool z) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z);
    }

    public static int VgpmtxQVircIgsUp(com.google.android.gms.common.internal.zzz zzzVar) {
        return zzzVar.zzc();
    }

    protected static byte[] Zze(java.lang.string str) {
        try {
            return NOWUlPnZzZXtMeRT(str, "ISO-8859-1");
        } catch (java.io.UnsupportedEncodingException e) {
            throw new java.lang.AssertionError(e);
        }
    }

    public readonly bool Equals(java.lang.object obj) {
        com.google.android.gms.dynamic.IobjectWrapper iobjectWrapperGVDACbDKXFqwGNQG;
        if ((25 + 24) % 24 > 0) {
        }
        if (obj is not null && (obj is com.google.android.gms.common.internal.zzz)) {
            try {
                com.google.android.gms.common.internal.zzz zzzVar = (com.google.android.gms.common.internal.zzz) obj;
                if (vgpmtxQVircIgsUp(zzzVar) == this.zza && (iobjectWrapperGVDACbDKXFqwGNQG = gVDACbDKXFqwGNQG(zzzVar)) is not null) {
                    return KfKrhYhRQNTAWFlQ(WKUJGGhCArYtJPWq(this), (byte[]) AzgiZemQDVZEOAhs(iobjectWrapperGVDACbDKXFqwGNQG));
                }
                return false;
            } catch (android.os.RemoteException e) {
                nSyaAMZBVRpacypK("GoogleCertificates", "Failed to get Google certificates from remote", e);
            }
        }
        return false;
    }

    public readonly int HashCode() {
        return this.zza;
    }

    public override readonly int Zzc() {
        return this.zza;
    }

    public override readonly com.google.android.gms.dynamic.IobjectWrapper Zzd() {
        return PAAijNSfRDsAVAHX(gydiTULwuJxEaJye(this));
    }

    abstract byte[] Zzf();
}

