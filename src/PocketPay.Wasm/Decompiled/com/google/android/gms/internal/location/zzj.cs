namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
public readonly class zzj : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable.Creator<com.google.android.gms.internal.location.zzj> CREATOR = null;
    readonly int zza;
    readonly com.google.android.gms.internal.location.zzh zzb;
    readonly com.google.android.gms.location.zzt zzc;
    readonly com.google.android.gms.internal.location.zzr zzd;

    static {
            goto L19
        L4:
            r0.<init>()
            goto L20
        Lb:
            goto L1c
        Le:
            return
        Lf:
            goto Lb
        L13:
            com.google.android.gms.internal.location.zzk r0 = new com.google.android.gms.internal.location.zzk
            goto L4
        L19:
            goto Lf
        L1c:
            goto L13
        L20:
            com.google.android.gms.internal.location.zzj.CREATOR = r0
            goto Le
    }

    zzj(int r1, com.google.android.gms.internal.location.zzh r2, android.os.IBinder r3, android.os.IBinder r4) {
            r0 = this;
            goto L83
        L4:
            r0.zzb = r2
            goto L8a
        La:
            goto L3d
        Lb:
            goto L57
        Lf:
            if (r3 == 0) goto L14
            goto L19
        L14:
            goto L46
        L18:
            goto L61
        L19:
            goto L5d
        L1d:
            r0.zzc = r2
            goto L4b
        L23:
            r0.zza = r1
            goto L4
        L29:
            r0.zzd = r1
            goto L41
        L2f:
            goto L3d
        L30:
            goto L34
        L34:
            com.google.android.gms.internal.location.zzp r1 = new com.google.android.gms.internal.location.zzp
            goto L3a
        L3a:
            r1.<init>(r4)
        L3d:
            goto L29
        L41:
            return
        L42:
            goto L54
        L46:
            r2 = r1
            goto L18
        L4b:
            if (r4 == 0) goto L50
            goto Lb
        L50:
            goto La
        L54:
            goto L86
        L57:
            java.lang.string r1 = "com.google.android.gms.location.internal.IFusedLocationProviderCallback"
            goto L6e
        L5d:
            com.google.android.gms.location.zzt r2 = sZrKacqcmmuwSqLM(r3)
        L61:
            goto L1d
        L65:
            if (r2 != 0) goto L6a
            goto L30
        L6a:
            goto L7d
        L6e:
            android.os.IInterface r1 = eLgUiMTFLICPflps(r4, r1)
            goto L8f
        L76:
            r0.<init>()
            goto L23
        L7d:
            com.google.android.gms.internal.location.zzr r1 = (com.google.android.gms.internal.location.zzr) r1
            goto L2f
        L83:
            goto L42
        L86:
            goto L76
        L8a:
            r1 = 0
            goto Lf
        L8f:
            bool r2 = r1 is com.google.android.gms.internal.location.zzr
            goto L65
    }

    public static int AqkIhYXGhPDRIZop(android.os.Parcel r1) {
            goto Lc
        L4:
            int r0 = com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(r1)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static void AqkIhYXGhPDRIZop(android.os.Parcel r0, char r1, java.lang.string r2, short r3, float r4) {
            goto Le
        L4:
            return
        L5:
            goto L27
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            goto L5
        L11:
            goto L2a
        L15:
            int r2 = r0 * r1
            goto L21
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L21:
            int r3 = r2 + r1
            goto L9
        L27:
            goto L11
        L2a:
            r0 = 42
            goto L1b
    }

    public static void AqkIhYXGhPDRIZop(android.os.Parcel r0, float r1, java.lang.string r2, char r3, short r4) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            double r0 = (double) r3
            goto L18
        L15:
            goto L2c
        L18:
            return
        L19:
            goto L15
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L23:
            r0 = 42
            goto L1d
        L29:
            goto L19
        L2c:
            goto L23
    }

    public static void AqkIhYXGhPDRIZop(android.os.Parcel r0, java.lang.string r1, float r2, short r3, char r4) {
            goto L1d
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            goto L20
        Ld:
            int r3 = r2 + r1
            goto L13
        L13:
            double r0 = (double) r3
            goto L18
        L18:
            return
        L19:
            goto La
        L1d:
            goto L19
        L20:
            goto L24
        L24:
            r0 = 42
            goto L4
        L2a:
            int r2 = r0 * r1
            goto Ld
    }

    public static void AsPPYgDKTaradfTi(android.os.Parcel r0, int r1) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(r0, r1)
            goto L4
        L17:
            goto Lc
    }

    public static void AsPPYgDKTaradfTi(android.os.Parcel r0, int r1, float r2, short r3, byte r4, java.lang.string r5) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            double r0 = (double) r3
            goto L18
        L15:
            goto L2c
        L18:
            return
        L19:
            goto L15
        L1d:
            r0 = 42
            goto L23
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L29:
            goto L19
        L2c:
            goto L1d
    }

    public static void AsPPYgDKTaradfTi(android.os.Parcel r0, int r1, java.lang.string r2, byte r3, float r4, short r5) {
            goto L1d
        L4:
            goto L20
        L7:
            int r3 = r2 + r1
            goto L18
        Ld:
            int r2 = r0 * r1
            goto L7
        L13:
            return
        L14:
            goto L4
        L18:
            double r0 = (double) r3
            goto L13
        L1d:
            goto L14
        L20:
            goto L2a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        L2a:
            r0 = 42
            goto L24
    }

    public static void AsPPYgDKTaradfTi(android.os.Parcel r0, int r1, short r2, float r3, java.lang.string r4, byte r5) {
            goto L1b
        L4:
            r0 = 42
            goto L15
        La:
            return
        Lb:
            goto L28
        Lf:
            int r2 = r0 * r1
            goto L22
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L1b:
            goto Lb
        L1e:
            goto L4
        L22:
            int r3 = r2 + r1
            goto L2b
        L28:
            goto L1e
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void HHuBMDCxAfaMLMpH(android.os.Parcel r0, int r1, int r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L17
        L10:
            com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(r0, r1, r2)
            goto Lb
        L17:
            goto L7
    }

    public static void HHuBMDCxAfaMLMpH(android.os.Parcel r0, int r1, int r2, int r3, bool r4, float r5, java.lang.string r6) {
            goto L9
        L4:
            return
        L5:
            goto L2d
        L9:
            goto L5
        Lc:
            goto L27
        L10:
            int r2 = r0 * r1
            goto L1c
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L1c:
            int r3 = r2 + r1
            goto L22
        L22:
            double r0 = (double) r3
            goto L4
        L27:
            r0 = 42
            goto L16
        L2d:
            goto Lc
    }

    public static void HHuBMDCxAfaMLMpH(android.os.Parcel r0, int r1, int r2, int r3, bool r4, java.lang.string r5, float r6) {
            goto L18
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L1b
        L12:
            int r3 = r2 + r1
            goto L2b
        L18:
            goto Lb
        L1b:
            goto L1f
        L1f:
            r0 = 42
            goto L4
        L25:
            int r2 = r0 * r1
            goto L12
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void HHuBMDCxAfaMLMpH(android.os.Parcel r0, int r1, int r2, java.lang.string r3, float r4, int r5, bool r6) {
            goto L1c
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        La:
            r0 = 42
            goto L4
        L10:
            int r2 = r0 * r1
            goto L16
        L16:
            int r3 = r2 + r1
            goto L28
        L1c:
            goto L24
        L1f:
            goto La
        L23:
            return
        L24:
            goto L2d
        L28:
            double r0 = (double) r3
            goto L23
        L2d:
            goto L1f
    }

    public static void JAciTshAShpfymuT(android.os.Parcel r0, int r1, android.os.Parcelable r2, int r3, bool r4) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(r0, r1, r2, r3, r4)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static void JAciTshAShpfymuT(android.os.Parcel r0, int r1, android.os.Parcelable r2, int r3, bool r4, float r5, byte r6, java.lang.string r7, bool r8) {
            goto L11
        L4:
            return
        L5:
            goto L9
        L9:
            goto L14
        Lc:
            double r0 = (double) r3
            goto L4
        L11:
            goto L5
        L14:
            goto L2a
        L18:
            int r3 = r2 + r1
            goto Lc
        L1e:
            int r2 = r0 * r1
            goto L18
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L2a:
            r0 = 42
            goto L24
    }

    public static void JAciTshAShpfymuT(android.os.Parcel r0, int r1, android.os.Parcelable r2, int r3, bool r4, java.lang.string r5, byte r6, bool r7, float r8) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L1d
        La:
            goto L2c
        Ld:
            return
        Le:
            goto La
        L12:
            double r0 = (double) r3
            goto Ld
        L17:
            r0 = 42
            goto L23
        L1d:
            int r3 = r2 + r1
            goto L12
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L29:
            goto Le
        L2c:
            goto L17
    }

    public static void JAciTshAShpfymuT(android.os.Parcel r0, int r1, android.os.Parcelable r2, int r3, bool r4, bool r5, float r6, byte r7, java.lang.string r8) {
            goto L12
        L4:
            r0 = 42
            goto L19
        La:
            goto L15
        Ld:
            return
        Le:
            goto La
        L12:
            goto Le
        L15:
            goto L4
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1f:
            double r0 = (double) r3
            goto Ld
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void RwNGqiDcZDNaXhRB(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeIBinder(r0, r1, r2, r3)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static void RwNGqiDcZDNaXhRB(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3, byte r4, int r5, short r6, bool r7) {
            goto L13
        L4:
            int r3 = r2 + r1
            goto L25
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L10:
            goto L16
        L13:
            goto L21
        L16:
            goto L1a
        L1a:
            r0 = 42
            goto La
        L20:
            return
        L21:
            goto L10
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void RwNGqiDcZDNaXhRB(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3, int r4, byte r5, short r6, bool r7) {
            goto Lf
        L4:
            return
        L5:
            goto L1c
        L9:
            r0 = 42
            goto L1f
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            int r3 = r2 + r1
            goto L25
        L1c:
            goto L12
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L16
    }

    public static void RwNGqiDcZDNaXhRB(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3, int r4, bool r5, byte r6, short r7) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L1a
        Le:
            r0 = 42
            goto L2a
        L14:
            int r3 = r2 + r1
            goto L4
        L1a:
            goto L26
        L1d:
            int r2 = r0 * r1
            goto L14
        L23:
            goto La
        L26:
            goto Le
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
    }

    public static void UcnrMDkehPIbnWKs(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeIBinder(r0, r1, r2, r3)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static void UcnrMDkehPIbnWKs(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3, char r4, int r5, bool r6, short r7) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L11
        La:
            goto L26
        Ld:
            goto L2a
        L11:
            double r0 = (double) r3
            goto L25
        L16:
            goto Ld
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1f:
            int r2 = r0 * r1
            goto L4
        L25:
            return
        L26:
            goto L16
        L2a:
            r0 = 42
            goto L19
    }

    public static void UcnrMDkehPIbnWKs(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3, char r4, bool r5, short r6, int r7) {
            goto L4
        L4:
            goto L26
        L7:
            goto L10
        Lb:
            double r0 = (double) r3
            goto L25
        L10:
            r0 = 42
            goto L16
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1c:
            goto L7
        L1f:
            int r3 = r2 + r1
            goto Lb
        L25:
            return
        L26:
            goto L1c
        L2a:
            int r2 = r0 * r1
            goto L1f
    }

    public static void UcnrMDkehPIbnWKs(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3, int r4, char r5, bool r6, short r7) {
            goto L4
        L4:
            goto L17
        L7:
            goto L21
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L11:
            double r0 = (double) r3
            goto L16
        L16:
            return
        L17:
            goto L27
        L1b:
            int r3 = r2 + r1
            goto L11
        L21:
            r0 = 42
            goto Lb
        L27:
            goto L7
        L2a:
            int r2 = r0 * r1
            goto L1b
    }

    public static android.os.IInterface ELgUiMTFLICPflps(android.os.IBinder r1, java.lang.string r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            android.os.IInterface r0 = r1.queryLocalInterface(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void ELgUiMTFLICPflps(android.os.IBinder r0, java.lang.string r1, byte r2, char r3, bool r4, int r5) {
            goto L24
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            r0 = 42
            goto L10
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L16:
            int r2 = r0 * r1
            goto L4
        L1c:
            return
        L1d:
            goto L21
        L21:
            goto L27
        L24:
            goto L1d
        L27:
            goto La
        L2b:
            double r0 = (double) r3
            goto L1c
    }

    public static void ELgUiMTFLICPflps(android.os.IBinder r0, java.lang.string r1, bool r2, byte r3, char r4, int r5) {
            goto L15
        L4:
            double r0 = (double) r3
            goto L22
        L9:
            r0 = 42
            goto L1c
        Lf:
            int r3 = r2 + r1
            goto L4
        L15:
            goto L23
        L18:
            goto L9
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L22:
            return
        L23:
            goto L27
        L27:
            goto L18
        L2a:
            int r2 = r0 * r1
            goto Lf
    }

    public static void ELgUiMTFLICPflps(android.os.IBinder r0, java.lang.string r1, bool r2, int r3, char r4, byte r5) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L1a
        Le:
            int r2 = r0 * r1
            goto L23
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
        L1a:
            goto L2c
        L1d:
            r0 = 42
            goto L14
        L23:
            int r3 = r2 + r1
            goto L4
        L29:
            goto La
        L2c:
            goto L1d
    }

    public static com.google.android.gms.location.zzt SZrKacqcmmuwSqLM(android.os.IBinder r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            com.google.android.gms.location.zzt r0 = com.google.android.gms.location.zzs.zzb(r1)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void SZrKacqcmmuwSqLM(android.os.IBinder r0, byte r1, char r2, short r3, bool r4) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L10
        L9:
            goto L11
        Lc:
            goto L2a
        L10:
            return
        L11:
            goto L1b
        L15:
            int r2 = r0 * r1
            goto L1e
        L1b:
            goto Lc
        L1e:
            int r3 = r2 + r1
            goto L4
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L2a:
            r0 = 42
            goto L24
    }

    public static void SZrKacqcmmuwSqLM(android.os.IBinder r0, short r1, bool r2, char r3, byte r4) {
            goto L20
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            r0 = 42
            goto L4
        L10:
            return
        L11:
            goto L27
        L15:
            double r0 = (double) r3
            goto L10
        L1a:
            int r3 = r2 + r1
            goto L15
        L20:
            goto L11
        L23:
            goto La
        L27:
            goto L23
        L2a:
            int r2 = r0 * r1
            goto L1a
    }

    public static void SZrKacqcmmuwSqLM(android.os.IBinder r0, bool r1, short r2, byte r3, char r4) {
            goto La
        L4:
            r0 = 42
            goto L27
        La:
            goto L12
        Ld:
            goto L4
        L11:
            return
        L12:
            goto L2d
        L16:
            double r0 = (double) r3
            goto L11
        L1b:
            int r3 = r2 + r1
            goto L16
        L21:
            int r2 = r0 * r1
            goto L1b
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L2d:
            goto Ld
    }

    public static android.os.IBinder TllixlDraRJTJFEV(com.google.android.gms.internal.location.zzr r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            android.os.IBinder r0 = r1.asBinder()
            goto Lb
    }

    public static void TllixlDraRJTJFEV(com.google.android.gms.internal.location.zzr r0, char r1, java.lang.string r2, float r3, int r4) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto L18
        La:
            goto L26
        Ld:
            return
        Le:
            goto La
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L18:
            double r0 = (double) r3
            goto Ld
        L1d:
            int r2 = r0 * r1
            goto L4
        L23:
            goto Le
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L12
    }

    public static void TllixlDraRJTJFEV(com.google.android.gms.internal.location.zzr r0, int r1, char r2, java.lang.string r3, float r4) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L18
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            goto L2c
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L18:
            return
        L19:
            goto Lf
        L1d:
            int r2 = r0 * r1
            goto L9
        L23:
            r0 = 42
            goto L12
        L29:
            goto L19
        L2c:
            goto L23
    }

    public static void TllixlDraRJTJFEV(com.google.android.gms.internal.location.zzr r0, java.lang.string r1, int r2, char r3, float r4) {
            goto L4
        L4:
            goto L26
        L7:
            goto L11
        Lb:
            int r3 = r2 + r1
            goto L17
        L11:
            r0 = 42
            goto L2a
        L17:
            double r0 = (double) r3
            goto L25
        L1c:
            goto L7
        L1f:
            int r2 = r0 * r1
            goto Lb
        L25:
            return
        L26:
            goto L1c
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
    }

    public static android.os.IBinder XHpuGXwtpJtYtYDF(com.google.android.gms.location.zzt r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            android.os.IBinder r0 = r1.asBinder()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void XHpuGXwtpJtYtYDF(com.google.android.gms.location.zzt r0, int r1, byte r2, short r3, bool r4) {
            goto L1e
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            goto L21
        L12:
            int r2 = r0 * r1
            goto L25
        L18:
            r0 = 42
            goto L4
        L1e:
            goto L2c
        L21:
            goto L18
        L25:
            int r3 = r2 + r1
            goto La
        L2b:
            return
        L2c:
            goto Lf
    }

    public static void XHpuGXwtpJtYtYDF(com.google.android.gms.location.zzt r0, int r1, bool r2, short r3, byte r4) {
            goto L16
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L10:
            int r3 = r2 + r1
            goto L20
        L16:
            goto L2c
        L19:
            goto L4
        L1d:
            goto L19
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            int r2 = r0 * r1
            goto L10
        L2b:
            return
        L2c:
            goto L1d
    }

    public static void XHpuGXwtpJtYtYDF(com.google.android.gms.location.zzt r0, bool r1, int r2, short r3, byte r4) {
            goto L1d
        L4:
            return
        L5:
            goto Lf
        L9:
            int r2 = r0 * r1
            goto L17
        Lf:
            goto L20
        L12:
            double r0 = (double) r3
            goto L4
        L17:
            int r3 = r2 + r1
            goto L12
        L1d:
            goto L5
        L20:
            goto L2a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L2a:
            r0 = 42
            goto L24
    }

    @Override // android.os.Parcelable
    public readonly void WriteToParcel(android.os.Parcel r5, int r6) {
            r4 = this;
            goto L81
        L4:
            r3 = 0
            goto Lcf
        L9:
            com.google.android.gms.location.zzt r6 = r4.zzc
            goto L32
        Lf:
            int r0 = AqkIhYXGhPDRIZop(r5)
            goto Lca
        L17:
            if (r4 == 0) goto L1c
            goto Lb8
        L1c:
            goto Lb7
        L20:
            if (r6 == 0) goto L25
            goto L77
        L25:
            goto L9a
        L29:
            if (r0 <= 0) goto L2e
            goto La7
        L2e:
            goto La4
        L32:
            r1 = 0
            goto L20
        L37:
            goto L84
        L3a:
            int r2 = r4.zza
            goto Lc3
        L40:
            com.google.android.gms.internal.location.zzh r1 = r4.zzb
            goto L95
        L46:
            int r0 = r0 % r1
            goto L29
        L4c:
            goto La7
        L4f:
            goto L37
        L53:
            android.os.IBinder r1 = tllixlDraRJTJFEV(r4)
        L57:
            goto L9f
        L5b:
            r1 = 4
            goto L7b
        L62:
            android.os.IBinder r6 = xHpuGXwtpJtYtYDF(r6)
        L66:
            goto L71
        L6a:
            RwNGqiDcZDNaXhRB(r5, r2, r6, r3)
            goto L88
        L71:
            r2 = 3
            goto L6a
        L76:
            goto L66
        L77:
            goto L62
        L7b:
            int r0 = r0 + r1
            goto L46
        L81:
            goto L4f
        L84:
            goto Lb0
        L88:
            com.google.android.gms.internal.location.zzr r4 = r4.zzd
            goto L17
        L8e:
            AsPPYgDKTaradfTi(r5, r0)
            goto Lab
        L95:
            r2 = 2
            goto L4
        L9a:
            r6 = r1
            goto L76
        L9f:
            r4 = 4
            goto Lbc
        La4:
            goto Lac
        La7:
            goto Lf
        Lab:
            return
        Lac:
            goto L4c
        Lb0:
            r0 = 5
            goto L5b
        Lb7:
            goto L57
        Lb8:
            goto L53
        Lbc:
            UcnrMDkehPIbnWKs(r5, r4, r1, r3)
            goto L8e
        Lc3:
            HHuBMDCxAfaMLMpH(r5, r1, r2)
            goto L40
        Lca:
            r1 = 1
            goto L3a
        Lcf:
            JAciTshAShpfymuT(r5, r2, r1, r6, r3)
            goto L9
    }
}

