namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
@java.lang.Deprecated
public readonly class zzei : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable.Creator<com.google.android.gms.internal.location.zzei> CREATOR = null;
    private readonly int zza;
    private readonly com.google.android.gms.internal.location.zzeg zzb;
    private readonly com.google.android.gms.location.zzz zzc;
    private readonly com.google.android.gms.location.zzw zzd;
    private readonly android.app.Pendingobject zze;
    private readonly com.google.android.gms.internal.location.zzr zzf;
    private readonly java.lang.string zzg;

    static {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto L1a
        Le:
            r0.<init>()
            goto L20
        L15:
            return
        L16:
            goto L4
        L1a:
            com.google.android.gms.internal.location.zzej r0 = new com.google.android.gms.internal.location.zzej
            goto Le
        L20:
            com.google.android.gms.internal.location.zzei.CREATOR = r0
            goto L15
    }

    zzei(int r1, com.google.android.gms.internal.location.zzeg r2, android.os.IBinder r3, android.os.IBinder r4, android.app.Pendingobject r5, android.os.IBinder r6, java.lang.string r7) {
            r0 = this;
            goto L9e
        L4:
            r0.zze = r5
            goto L1e
        La:
            r0.zzc = r2
            goto L4
        L10:
            com.google.android.gms.location.zzz r2 = ZIyjtmOkSdyHHkAf(r3)
            goto L99
        L18:
            goto La6
        L1a:
            goto La5
        L1e:
            if (r4 != 0) goto L23
            goto L1a
        L23:
            goto L3a
        L27:
            r1.<init>(r6)
        L2a:
            goto L7a
        L2e:
            bool r2 = r1 is com.google.android.gms.internal.location.zzr
            goto L42
        L34:
            r0.zzd = r2
            goto L71
        L3a:
            com.google.android.gms.location.zzw r2 = NxxGkLVPiqznSYcD(r4)
            goto L18
        L42:
            if (r2 != 0) goto L47
            goto L6d
        L47:
            goto L93
        L4b:
            java.lang.string r1 = "com.google.android.gms.location.internal.IFusedLocationProviderCallback"
            goto L80
        L51:
            r0.zzb = r2
            goto Lb1
        L57:
            com.google.android.gms.internal.location.zzp r1 = new com.google.android.gms.internal.location.zzp
            goto L27
        L5d:
            r0.zzg = r7
            goto Lb6
        L63:
            if (r3 != 0) goto L68
            goto L9a
        L68:
            goto L10
        L6c:
            goto L2a
        L6d:
            goto L57
        L71:
            if (r6 != 0) goto L76
            goto L2a
        L76:
            goto L4b
        L7a:
            r0.zzf = r1
            goto L5d
        L80:
            android.os.IInterface r1 = CDeRrkjwscMsLfzv(r6, r1)
            goto L2e
        L88:
            r2 = r1
        L89:
            goto La
        L8d:
            r0.zza = r1
            goto L51
        L93:
            com.google.android.gms.internal.location.zzr r1 = (com.google.android.gms.internal.location.zzr) r1
            goto L6c
        L99:
            goto L89
        L9a:
            goto L88
        L9e:
            goto Lb7
        La1:
            goto Laa
        La5:
            r2 = r1
        La6:
            goto L34
        Laa:
            r0.<init>()
            goto L8d
        Lb1:
            r1 = 0
            goto L63
        Lb6:
            return
        Lb7:
            goto Lbb
        Lbb:
            goto La1
    }

    public static void BqyIzrawEhPsgOZx(android.os.Parcel r0, int r1) {
            goto Lc
        L4:
            return
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(r0, r1)
            goto L4
    }

    public static void BqyIzrawEhPsgOZx(android.os.Parcel r0, int r1, char r2, float r3, bool r4, java.lang.string r5) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L1d
        La:
            goto L29
        Ld:
            goto L22
        L11:
            int r2 = r0 * r1
            goto L4
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L1d:
            double r0 = (double) r3
            goto L28
        L22:
            r0 = 42
            goto L17
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto Ld
    }

    public static void BqyIzrawEhPsgOZx(android.os.Parcel r0, int r1, float r2, java.lang.string r3, bool r4, char r5) {
            goto Ld
        L4:
            goto L10
        L7:
            int r3 = r2 + r1
            goto L25
        Ld:
            goto L21
        L10:
            goto L1a
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1a:
            r0 = 42
            goto L14
        L20:
            return
        L21:
            goto L4
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            int r2 = r0 * r1
            goto L7
    }

    public static void BqyIzrawEhPsgOZx(android.os.Parcel r0, int r1, bool r2, char r3, java.lang.string r4, float r5) {
            goto L9
        L4:
            return
        L5:
            goto L2d
        L9:
            goto L5
        Lc:
            goto L21
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L16:
            double r0 = (double) r3
            goto L4
        L1b:
            int r3 = r2 + r1
            goto L16
        L21:
            r0 = 42
            goto L10
        L27:
            int r2 = r0 * r1
            goto L1b
        L2d:
            goto Lc
    }

    public static int BrBfLGAkcsdljOzz(android.os.Parcel r1) {
            goto L14
        L4:
            int r0 = com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(r1)
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static void BrBfLGAkcsdljOzz(android.os.Parcel r0, byte r1, float r2, java.lang.string r3, bool r4) {
            goto L19
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L20
        L10:
            goto L1c
        L13:
            r0 = 42
            goto L4
        L19:
            goto L2c
        L1c:
            goto L13
        L20:
            int r3 = r2 + r1
            goto L26
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L10
    }

    public static void BrBfLGAkcsdljOzz(android.os.Parcel r0, byte r1, java.lang.string r2, float r3, bool r4) {
            goto L1a
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r2 = r0 * r1
            goto L14
        Lf:
            return
        L10:
            goto L2d
        L14:
            int r3 = r2 + r1
            goto L4
        L1a:
            goto L10
        L1d:
            goto L27
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L27:
            r0 = 42
            goto L21
        L2d:
            goto L1d
    }

    public static void BrBfLGAkcsdljOzz(android.os.Parcel r0, bool r1, float r2, byte r3, java.lang.string r4) {
            goto L24
        L4:
            goto L27
        L7:
            return
        L8:
            goto L4
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L12:
            r0 = 42
            goto Lc
        L18:
            int r2 = r0 * r1
            goto L1e
        L1e:
            int r3 = r2 + r1
            goto L2b
        L24:
            goto L8
        L27:
            goto L12
        L2b:
            double r0 = (double) r3
            goto L7
    }

    public static android.os.IInterface CDeRrkjwscMsLfzv(android.os.IBinder r1, java.lang.string r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            android.os.IInterface r0 = r1.queryLocalInterface(r2)
            goto L4
    }

    public static void CDeRrkjwscMsLfzv(android.os.IBinder r0, java.lang.string r1, char r2, java.lang.string r3, short r4, float r5) {
            goto L1e
        L4:
            goto L21
        L7:
            return
        L8:
            goto L4
        Lc:
            int r2 = r0 * r1
            goto L12
        L12:
            int r3 = r2 + r1
            goto L2b
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
        L1e:
            goto L8
        L21:
            goto L25
        L25:
            r0 = 42
            goto L18
        L2b:
            double r0 = (double) r3
            goto L7
    }

    public static void CDeRrkjwscMsLfzv(android.os.IBinder r0, java.lang.string r1, java.lang.string r2, char r3, float r4, short r5) {
            goto L1e
        L4:
            int r3 = r2 + r1
            goto L19
        La:
            r0 = 42
            goto L10
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L16:
            goto L21
        L19:
            double r0 = (double) r3
            goto L2b
        L1e:
            goto L2c
        L21:
            goto La
        L25:
            int r2 = r0 * r1
            goto L4
        L2b:
            return
        L2c:
            goto L16
    }

    public static void CDeRrkjwscMsLfzv(android.os.IBinder r0, java.lang.string r1, short r2, float r3, char r4, java.lang.string r5) {
            goto L4
        L4:
            goto L26
        L7:
            goto L1f
        Lb:
            int r3 = r2 + r1
            goto L17
        L11:
            int r2 = r0 * r1
            goto Lb
        L17:
            double r0 = (double) r3
            goto L25
        L1c:
            goto L7
        L1f:
            r0 = 42
            goto L2a
        L25:
            return
        L26:
            goto L1c
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
    }

    public static void ExJoaFpHgCaCauIx(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeIBinder(r0, r1, r2, r3)
            goto Le
    }

    public static void ExJoaFpHgCaCauIx(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3, byte r4, java.lang.string r5, float r6, int r7) {
            goto La
        L4:
            r0 = 42
            goto L1b
        La:
            goto L17
        Ld:
            goto L4
        L11:
            double r0 = (double) r3
            goto L16
        L16:
            return
        L17:
            goto L27
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L21:
            int r3 = r2 + r1
            goto L11
        L27:
            goto Ld
        L2a:
            int r2 = r0 * r1
            goto L21
    }

    public static void ExJoaFpHgCaCauIx(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3, byte r4, java.lang.string r5, int r6, float r7) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L19
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        Lf:
            goto L1a
        L12:
            goto L24
        L16:
            goto L12
        L19:
            return
        L1a:
            goto L16
        L1e:
            int r3 = r2 + r1
            goto L4
        L24:
            r0 = 42
            goto L9
        L2a:
            int r2 = r0 * r1
            goto L1e
    }

    public static void ExJoaFpHgCaCauIx(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3, float r4, java.lang.string r5, int r6, byte r7) {
            goto L1b
        L4:
            return
        L5:
            goto L2d
        L9:
            r0 = 42
            goto L15
        Lf:
            int r3 = r2 + r1
            goto L28
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L1b:
            goto L5
        L1e:
            goto L9
        L22:
            int r2 = r0 * r1
            goto Lf
        L28:
            double r0 = (double) r3
            goto L4
        L2d:
            goto L1e
    }

    public static void NXguFHFTReDGSYFE(android.os.Parcel r0, int r1, android.os.Parcelable r2, int r3, bool r4) {
            goto L13
        L4:
            goto L16
        L7:
            com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(r0, r1, r2, r3, r4)
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    public static void NXguFHFTReDGSYFE(android.os.Parcel r0, int r1, android.os.Parcelable r2, int r3, bool r4, char r5, bool r6, int r7, java.lang.string r8) {
            goto L11
        L4:
            return
        L5:
            goto Le
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            goto L14
        L11:
            goto L5
        L14:
            goto L24
        L18:
            int r3 = r2 + r1
            goto L9
        L1e:
            int r2 = r0 * r1
            goto L18
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
    }

    public static void NXguFHFTReDGSYFE(android.os.Parcel r0, int r1, android.os.Parcelable r2, int r3, bool r4, java.lang.string r5, int r6, bool r7, char r8) {
            goto L4
        L4:
            goto L29
        L7:
            goto L16
        Lb:
            double r0 = (double) r3
            goto L28
        L10:
            int r2 = r0 * r1
            goto L1c
        L16:
            r0 = 42
            goto L22
        L1c:
            int r3 = r2 + r1
            goto Lb
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L7
    }

    public static void NXguFHFTReDGSYFE(android.os.Parcel r0, int r1, android.os.Parcelable r2, int r3, bool r4, bool r5, char r6, int r7, java.lang.string r8) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        La:
            return
        Lb:
            goto L20
        Lf:
            r0 = 42
            goto L4
        L15:
            int r3 = r2 + r1
            goto L1b
        L1b:
            double r0 = (double) r3
            goto La
        L20:
            goto L2c
        L23:
            int r2 = r0 * r1
            goto L15
        L29:
            goto Lb
        L2c:
            goto Lf
    }

    public static com.google.android.gms.location.zzw NxxGkLVPiqznSYcD(android.os.IBinder r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            com.google.android.gms.location.zzw r0 = com.google.android.gms.location.zzv.zzb(r1)
            goto Le
    }

    public static void NxxGkLVPiqznSYcD(android.os.IBinder r0, float r1, byte r2, bool r3, short r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L21
        L10:
            r0 = 42
            goto L16
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1c:
            return
        L1d:
            goto L26
        L21:
            double r0 = (double) r3
            goto L1c
        L26:
            goto L2c
        L29:
            goto L1d
        L2c:
            goto L10
    }

    public static void NxxGkLVPiqznSYcD(android.os.IBinder r0, short r1, byte r2, float r3, bool r4) {
            goto L13
        L4:
            goto L16
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        Ld:
            int r3 = r2 + r1
            goto L1a
        L13:
            goto L26
        L16:
            goto L1f
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            r0 = 42
            goto L7
        L25:
            return
        L26:
            goto L4
        L2a:
            int r2 = r0 * r1
            goto Ld
    }

    public static void NxxGkLVPiqznSYcD(android.os.IBinder r0, short r1, byte r2, bool r3, float r4) {
            goto L15
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            return
        Lb:
            goto L1c
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L15:
            goto Lb
        L18:
            goto L25
        L1c:
            goto L18
        L1f:
            int r2 = r0 * r1
            goto L4
        L25:
            r0 = 42
            goto Lf
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void SPzWFNehGhEbNJzj(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeIBinder(r0, r1, r2, r3)
            goto L7
    }

    public static void SPzWFNehGhEbNJzj(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3, byte r4, bool r5, int r6, java.lang.string r7) {
            goto Le
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L27
        Le:
            goto La
        L11:
            goto L21
        L15:
            int r2 = r0 * r1
            goto L1b
        L1b:
            int r3 = r2 + r1
            goto L4
        L21:
            r0 = 42
            goto L2a
        L27:
            goto L11
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
    }

    public static void SPzWFNehGhEbNJzj(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3, byte r4, bool r5, java.lang.string r6, int r7) {
            goto L15
        L4:
            return
        L5:
            goto L2d
        L9:
            int r3 = r2 + r1
            goto L28
        Lf:
            int r2 = r0 * r1
            goto L9
        L15:
            goto L5
        L18:
            goto L22
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L22:
            r0 = 42
            goto L1c
        L28:
            double r0 = (double) r3
            goto L4
        L2d:
            goto L18
    }

    public static void SPzWFNehGhEbNJzj(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3, int r4, byte r5, bool r6, java.lang.string r7) {
            goto L13
        L4:
            goto L16
        L7:
            int r2 = r0 * r1
            goto Ld
        Ld:
            int r3 = r2 + r1
            goto L2b
        L13:
            goto L21
        L16:
            goto L1a
        L1a:
            r0 = 42
            goto L25
        L20:
            return
        L21:
            goto L4
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static com.google.android.gms.location.zzz ZIyjtmOkSdyHHkAf(android.os.IBinder r1) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            com.google.android.gms.location.zzz r0 = com.google.android.gms.location.zzy.zzb(r1)
            goto L4
    }

    public static void ZIyjtmOkSdyHHkAf(android.os.IBinder r0, byte r1, bool r2, float r3, short r4) {
            goto L23
        L4:
            return
        L5:
            goto Lf
        L9:
            int r3 = r2 + r1
            goto L18
        Lf:
            goto L26
        L12:
            int r2 = r0 * r1
            goto L9
        L18:
            double r0 = (double) r3
            goto L4
        L1d:
            r0 = 42
            goto L2a
        L23:
            goto L5
        L26:
            goto L1d
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
    }

    public static void ZIyjtmOkSdyHHkAf(android.os.IBinder r0, float r1, bool r2, short r3, byte r4) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L22
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            goto L23
        L12:
            goto L1c
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1c:
            r0 = 42
            goto L16
        L22:
            return
        L23:
            goto L27
        L27:
            goto L12
        L2a:
            int r2 = r0 * r1
            goto L9
    }

    public static void ZIyjtmOkSdyHHkAf(android.os.IBinder r0, bool r1, byte r2, float r3, short r4) {
            goto Ld
        L4:
            goto L10
        L7:
            int r2 = r0 * r1
            goto L24
        Ld:
            goto L15
        L10:
            goto L19
        L14:
            return
        L15:
            goto L4
        L19:
            r0 = 42
            goto L2a
        L1f:
            double r0 = (double) r3
            goto L14
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
    }

    public static android.os.IBinder BCDPRJUjDtOalSKx(com.google.android.gms.location.zzw r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            android.os.IBinder r0 = r1.asBinder()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void BCDPRJUjDtOalSKx(com.google.android.gms.location.zzw r0, int r1, java.lang.string r2, bool r3, short r4) {
            goto L20
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L10:
            double r0 = (double) r3
            goto L1b
        L15:
            r0 = 42
            goto La
        L1b:
            return
        L1c:
            goto L2d
        L20:
            goto L1c
        L23:
            goto L15
        L27:
            int r2 = r0 * r1
            goto L4
        L2d:
            goto L23
    }

    public static void BCDPRJUjDtOalSKx(com.google.android.gms.location.zzw r0, short r1, int r2, bool r3, java.lang.string r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L22
        La:
            goto L12
        Ld:
            goto L16
        L11:
            return
        L12:
            goto L2d
        L16:
            r0 = 42
            goto L1c
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L22:
            double r0 = (double) r3
            goto L11
        L27:
            int r2 = r0 * r1
            goto L4
        L2d:
            goto Ld
    }

    public static void BCDPRJUjDtOalSKx(com.google.android.gms.location.zzw r0, bool r1, int r2, java.lang.string r3, short r4) {
            goto L4
        L4:
            goto L1e
        L7:
            goto L2a
        Lb:
            int r3 = r2 + r1
            goto L22
        L11:
            int r2 = r0 * r1
            goto Lb
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L1d:
            return
        L1e:
            goto L27
        L22:
            double r0 = (double) r3
            goto L1d
        L27:
            goto L7
        L2a:
            r0 = 42
            goto L17
    }

    public static void DIMhecsmNcCnJNdT(android.os.Parcel r0, int r1, int r2) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(r0, r1, r2)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static void DIMhecsmNcCnJNdT(android.os.Parcel r0, int r1, int r2, char r3, float r4, bool r5, short r6) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L16
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            r0 = 42
            goto La
        L16:
            int r3 = r2 + r1
            goto L21
        L1c:
            return
        L1d:
            goto L26
        L21:
            double r0 = (double) r3
            goto L1c
        L26:
            goto L2c
        L29:
            goto L1d
        L2c:
            goto L10
    }

    public static void DIMhecsmNcCnJNdT(android.os.Parcel r0, int r1, int r2, short r3, char r4, bool r5, float r6) {
            goto L1e
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            return
        Lb:
            goto L1b
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            r0 = 42
            goto Lf
        L1b:
            goto L21
        L1e:
            goto Lb
        L21:
            goto L15
        L25:
            double r0 = (double) r3
            goto La
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void DIMhecsmNcCnJNdT(android.os.Parcel r0, int r1, int r2, bool r3, short r4, float r5, char r6) {
            goto L1a
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L27
        Le:
            int r2 = r0 * r1
            goto L14
        L14:
            int r3 = r2 + r1
            goto L4
        L1a:
            goto La
        L1d:
            goto L21
        L21:
            r0 = 42
            goto L2a
        L27:
            goto L1d
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
    }

    public static void DaVLykHqVfoXaeDM(android.os.Parcel r0, int r1, java.lang.string r2, bool r3) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(r0, r1, r2, r3)
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static void DaVLykHqVfoXaeDM(android.os.Parcel r0, int r1, java.lang.string r2, bool r3, float r4, char r5, bool r6, byte r7) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto Ld
        La:
            goto L2c
        Ld:
            int r3 = r2 + r1
            goto L13
        L13:
            double r0 = (double) r3
            goto L1e
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1e:
            return
        L1f:
            goto La
        L23:
            r0 = 42
            goto L18
        L29:
            goto L1f
        L2c:
            goto L23
    }

    public static void DaVLykHqVfoXaeDM(android.os.Parcel r0, int r1, java.lang.string r2, bool r3, float r4, bool r5, char r6, byte r7) {
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        La:
            return
        Lb:
            goto L22
        Lf:
            int r2 = r0 * r1
            goto L2a
        L15:
            goto Lb
        L18:
            goto L1c
        L1c:
            r0 = 42
            goto L4
        L22:
            goto L18
        L25:
            double r0 = (double) r3
            goto La
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void DaVLykHqVfoXaeDM(android.os.Parcel r0, int r1, java.lang.string r2, bool r3, bool r4, char r5, float r6, byte r7) {
            goto L24
        L4:
            goto L27
        L7:
            int r2 = r0 * r1
            goto L13
        Ld:
            r0 = 42
            goto L19
        L13:
            int r3 = r2 + r1
            goto L1f
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L1f:
            double r0 = (double) r3
            goto L2b
        L24:
            goto L2c
        L27:
            goto Ld
        L2b:
            return
        L2c:
            goto L4
    }

    public static void ERAdhmIlPKobzxnG(android.os.Parcel r0, int r1, android.os.Parcelable r2, int r3, bool r4) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(r0, r1, r2, r3, r4)
            goto L4
    }

    public static void ERAdhmIlPKobzxnG(android.os.Parcel r0, int r1, android.os.Parcelable r2, int r3, bool r4, char r5, float r6, java.lang.string r7, short r8) {
            goto L15
        L4:
            return
        L5:
            goto L2d
        L9:
            r0 = 42
            goto Lf
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L15:
            goto L5
        L18:
            goto L9
        L1c:
            int r3 = r2 + r1
            goto L22
        L22:
            double r0 = (double) r3
            goto L4
        L27:
            int r2 = r0 * r1
            goto L1c
        L2d:
            goto L18
    }

    public static void ERAdhmIlPKobzxnG(android.os.Parcel r0, int r1, android.os.Parcelable r2, int r3, bool r4, char r5, float r6, short r7, java.lang.string r8) {
            goto Ld
        L4:
            goto L10
        L7:
            int r2 = r0 * r1
            goto L24
        Ld:
            goto L15
        L10:
            goto L1e
        L14:
            return
        L15:
            goto L4
        L19:
            double r0 = (double) r3
            goto L14
        L1e:
            r0 = 42
            goto L2a
        L24:
            int r3 = r2 + r1
            goto L19
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
    }

    public static void ERAdhmIlPKobzxnG(android.os.Parcel r0, int r1, android.os.Parcelable r2, int r3, bool r4, java.lang.string r5, short r6, char r7, float r8) {
            goto L14
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L2d
        Le:
            int r3 = r2 + r1
            goto L4
        L14:
            goto La
        L17:
            goto L27
        L1b:
            int r2 = r0 * r1
            goto Le
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L27:
            r0 = 42
            goto L21
        L2d:
            goto L17
    }

    public static void OMxsZsNuXdbgmFXs(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeIBinder(r0, r1, r2, r3)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static void OMxsZsNuXdbgmFXs(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3, float r4, byte r5, bool r6, int r7) {
            goto L13
        L4:
            int r3 = r2 + r1
            goto L20
        La:
            goto L16
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L13:
            goto L26
        L16:
            goto L2a
        L1a:
            int r2 = r0 * r1
            goto L4
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto La
        L2a:
            r0 = 42
            goto Ld
    }

    public static void OMxsZsNuXdbgmFXs(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3, bool r4, byte r5, float r6, int r7) {
            goto L1b
        L4:
            r0 = 42
            goto L15
        La:
            double r0 = (double) r3
            goto L25
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1b:
            goto L26
        L1e:
            goto L4
        L22:
            goto L1e
        L25:
            return
        L26:
            goto L22
        L2a:
            int r2 = r0 * r1
            goto Lf
    }

    public static void OMxsZsNuXdbgmFXs(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3, bool r4, float r5, byte r6, int r7) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            double r0 = (double) r3
            goto L25
        L15:
            goto L26
        L18:
            goto L1c
        L1c:
            r0 = 42
            goto La
        L22:
            goto L18
        L25:
            return
        L26:
            goto L22
        L2a:
            int r3 = r2 + r1
            goto L10
    }

    public static android.os.IBinder WpIPwafnsQhCVZxT(com.google.android.gms.internal.location.zzr r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            android.os.IBinder r0 = r1.asBinder()
            goto L7
    }

    public static void WpIPwafnsQhCVZxT(com.google.android.gms.internal.location.zzr r0, int r1, java.lang.string r2, short r3, float r4) {
            goto L24
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            r0 = 42
            goto L10
        L1c:
            return
        L1d:
            goto L21
        L21:
            goto L27
        L24:
            goto L1d
        L27:
            goto L16
        L2b:
            double r0 = (double) r3
            goto L1c
    }

    public static void WpIPwafnsQhCVZxT(com.google.android.gms.internal.location.zzr r0, int r1, short r2, java.lang.string r3, float r4) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L15
        La:
            r0 = 42
            goto L1a
        L10:
            return
        L11:
            goto L26
        L15:
            double r0 = (double) r3
            goto L10
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L20:
            int r2 = r0 * r1
            goto L4
        L26:
            goto L2c
        L29:
            goto L11
        L2c:
            goto La
    }

    public static void WpIPwafnsQhCVZxT(com.google.android.gms.internal.location.zzr r0, java.lang.string r1, short r2, float r3, int r4) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L1b
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        Lf:
            r0 = 42
            goto L9
        L15:
            int r3 = r2 + r1
            goto L4
        L1b:
            return
        L1c:
            goto L20
        L20:
            goto L2c
        L23:
            int r2 = r0 * r1
            goto L15
        L29:
            goto L1c
        L2c:
            goto Lf
    }

    public static android.os.IBinder XAnXQtTFTxoUsqWQ(com.google.android.gms.location.zzz r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            android.os.IBinder r0 = r1.asBinder()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void XAnXQtTFTxoUsqWQ(com.google.android.gms.location.zzz r0, java.lang.string r1, short r2, int r3, char r4) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L1f
        La:
            r0 = 42
            goto L19
        L10:
            int r2 = r0 * r1
            goto L4
        L16:
            goto L2c
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L1f:
            double r0 = (double) r3
            goto L24
        L24:
            return
        L25:
            goto L16
        L29:
            goto L25
        L2c:
            goto La
    }

    public static void XAnXQtTFTxoUsqWQ(com.google.android.gms.location.zzz r0, short r1, char r2, int r3, java.lang.string r4) {
            goto L4
        L4:
            goto L1d
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L27
        L11:
            int r2 = r0 * r1
            goto L21
        L17:
            double r0 = (double) r3
            goto L1c
        L1c:
            return
        L1d:
            goto L2d
        L21:
            int r3 = r2 + r1
            goto L17
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L2d:
            goto L7
    }

    public static void XAnXQtTFTxoUsqWQ(com.google.android.gms.location.zzz r0, short r1, int r2, char r3, java.lang.string r4) {
            goto L13
        L4:
            goto L16
        L7:
            int r2 = r0 * r1
            goto Ld
        Ld:
            int r3 = r2 + r1
            goto L25
        L13:
            goto L1b
        L16:
            goto L2a
        L1a:
            return
        L1b:
            goto L4
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L25:
            double r0 = (double) r3
            goto L1a
        L2a:
            r0 = 42
            goto L1f
    }

    @Override // android.os.Parcelable
    public readonly void WriteToParcel(android.os.Parcel r6, int r7) {
            r5 = this;
            goto L7c
        L4:
            int r0 = r0 % r1
            goto Ldb
        La:
            android.os.IBinder r7 = bCDPRJUjDtOalSKx(r7)
        Le:
            goto Lba
        L12:
            java.lang.string r5 = r5.zzg
            goto L101
        L18:
            if (r0 == 0) goto L1d
            goto Lb6
        L1d:
            goto Ld6
        L21:
            goto L7f
        L24:
            r2 = 2
            goto L108
        L29:
            eRAdhmIlPKobzxnG(r6, r2, r0, r7, r3)
            goto L5f
        L30:
            r0 = 26
            goto Lf1
        L37:
            oMxsZsNuXdbgmFXs(r6, r4, r0, r3)
            goto La9
        L3e:
            goto Le
        L3f:
            goto La
        L43:
            int r1 = BrBfLGAkcsdljOzz(r6)
            goto Ld1
        L4b:
            android.os.IBinder r2 = wpIPwafnsQhCVZxT(r7)
        L4f:
            goto L72
        L53:
            com.google.android.gms.location.zzw r7 = r5.zzd
            goto Lf8
        L59:
            com.google.android.gms.internal.location.zzr r7 = r5.zzf
            goto L10d
        L5f:
            com.google.android.gms.location.zzz r0 = r5.zzc
            goto L9e
        L65:
            android.os.IBinder r0 = xAnXQtTFTxoUsqWQ(r0)
        L69:
            goto L6d
        L6d:
            r4 = 3
            goto L37
        L72:
            r7 = 6
            goto L83
        L77:
            return
        L78:
            goto Lc4
        L7c:
            goto Lc7
        L7f:
            goto L30
        L83:
            SPzWFNehGhEbNJzj(r6, r7, r2, r3)
            goto Lcb
        L8a:
            BqyIzrawEhPsgOZx(r6, r1)
            goto L77
        L91:
            int r0 = r5.zza
            goto L43
        L97:
            NXguFHFTReDGSYFE(r6, r0, r4, r7, r3)
            goto L53
        L9e:
            r2 = 0
            goto L18
        La3:
            android.app.Pendingobject r4 = r5.zze
            goto L97
        La9:
            r0 = 4
            goto La3
        Lae:
            ExJoaFpHgCaCauIx(r6, r0, r7, r3)
            goto L59
        Lb5:
            goto L69
        Lb6:
            goto L65
        Lba:
            r0 = 5
            goto Lae
        Lbf:
            r7 = r2
            goto L3e
        Lc4:
            goto Led
        Lc7:
            goto L21
        Lcb:
            r7 = 8
            goto L12
        Ld1:
            r2 = 1
            goto L122
        Ld6:
            r0 = r2
            goto Lb5
        Ldb:
            if (r0 <= 0) goto Le0
            goto Led
        Le0:
            goto Lea
        Le4:
            int r0 = r0 + r1
            goto L4
        Lea:
            goto L78
        Led:
            goto L91
        Lf1:
            r1 = 13
            goto Le4
        Lf8:
            if (r7 == 0) goto Lfd
            goto L3f
        Lfd:
            goto Lbf
        L101:
            daVLykHqVfoXaeDM(r6, r7, r5, r3)
            goto L8a
        L108:
            r3 = 0
            goto L29
        L10d:
            if (r7 == 0) goto L112
            goto L11e
        L112:
            goto L11c
        L116:
            com.google.android.gms.internal.location.zzeg r0 = r5.zzb
            goto L24
        L11c:
            goto L4f
        L11e:
            goto L4b
        L122:
            dIMhecsmNcCnJNdT(r6, r2, r0)
            goto L116
    }
}

