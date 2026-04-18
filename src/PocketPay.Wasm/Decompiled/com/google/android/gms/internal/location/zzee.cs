namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
public readonly class zzee : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable.Creator<com.google.android.gms.internal.location.zzee> CREATOR = null;
    private readonly int zza;
    private readonly android.os.IBinder zzb;
    private readonly android.os.IBinder zzc;
    private readonly android.app.Pendingobject zzd;
    private readonly java.lang.string zze;

    static {
            goto Lf
        L4:
            return
        L5:
            goto L23
        L9:
            com.google.android.gms.internal.location.zzef r0 = new com.google.android.gms.internal.location.zzef
            goto L1c
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            com.google.android.gms.internal.location.zzee.CREATOR = r0
            goto L4
        L1c:
            r0.<init>()
            goto L16
        L23:
            goto L12
    }

    zzee(int r1, android.os.IBinder r2, android.os.IBinder r3, android.app.Pendingobject r4, java.lang.string r5) {
            r0 = this;
            goto L15
        L4:
            r0.zzb = r2
            goto Lf
        La:
            return
        Lb:
            goto L35
        Lf:
            r0.zzc = r3
            goto L22
        L15:
            goto Lb
        L18:
            goto L28
        L1c:
            r0.zze = r5
            goto La
        L22:
            r0.zzd = r4
            goto L1c
        L28:
            r0.<init>()
            goto L2f
        L2f:
            r0.zza = r1
            goto L4
        L35:
            goto L18
    }

    public static void JVKNEfNOgKmWSwsz(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3) {
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
            com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeIBinder(r0, r1, r2, r3)
            goto L4
    }

    public static void JVKNEfNOgKmWSwsz(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3, int r4, float r5, java.lang.string r6, short r7) {
            goto L29
        L4:
            goto L2c
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        Ld:
            double r0 = (double) r3
            goto L24
        L12:
            int r3 = r2 + r1
            goto Ld
        L18:
            r0 = 42
            goto L7
        L1e:
            int r2 = r0 * r1
            goto L12
        L24:
            return
        L25:
            goto L4
        L29:
            goto L25
        L2c:
            goto L18
    }

    public static void JVKNEfNOgKmWSwsz(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3, java.lang.string r4, short r5, float r6, int r7) {
            goto L23
        L4:
            r0 = 42
            goto L12
        La:
            goto L26
        Ld:
            return
        Le:
            goto La
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L18:
            double r0 = (double) r3
            goto Ld
        L1d:
            int r3 = r2 + r1
            goto L18
        L23:
            goto Le
        L26:
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L1d
    }

    public static void JVKNEfNOgKmWSwsz(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3, short r4, java.lang.string r5, int r6, float r7) {
            goto Ld
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        La:
            goto L10
        Ld:
            goto L27
        L10:
            goto L14
        L14:
            r0 = 42
            goto L4
        L1a:
            int r2 = r0 * r1
            goto L20
        L20:
            int r3 = r2 + r1
            goto L2b
        L26:
            return
        L27:
            goto La
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static int VgQPObLYKQbHvRor(android.os.Parcel r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            int r0 = com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(r1)
            goto Lb
        L18:
            goto L7
    }

    public static void VgQPObLYKQbHvRor(android.os.Parcel r0, int r1, bool r2, short r3, byte r4) {
            goto L1e
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            goto L21
        Lc:
            int r3 = r2 + r1
            goto L4
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L18:
            r0 = 42
            goto L12
        L1e:
            goto L2c
        L21:
            goto L18
        L25:
            int r2 = r0 * r1
            goto Lc
        L2b:
            return
        L2c:
            goto L9
    }

    public static void VgQPObLYKQbHvRor(android.os.Parcel r0, short r1, byte r2, bool r3, int r4) {
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
            goto L25
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L20:
            return
        L21:
            goto L4
        L25:
            r0 = 42
            goto L1a
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static void VgQPObLYKQbHvRor(android.os.Parcel r0, bool r1, short r2, byte r3, int r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L1d
        La:
            r1 = 210(0xd2, float:2.94E-43)
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
            int r3 = r2 + r1
            goto L10
        L23:
            r0 = 42
            goto La
        L29:
            goto L19
        L2c:
            goto L23
    }

    public static void JEqWYmoYbzISOESg(android.os.Parcel r0, int r1, int r2) {
            goto Le
        L4:
            com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(r0, r1, r2)
            goto L15
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L4
        L15:
            return
        L16:
            goto Lb
    }

    public static void JEqWYmoYbzISOESg(android.os.Parcel r0, int r1, int r2, byte r3, bool r4, char r5, float r6) {
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
            goto L21
        L1b:
            int r2 = r0 * r1
            goto Le
        L21:
            r0 = 42
            goto L27
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L2d:
            goto L17
    }

    public static void JEqWYmoYbzISOESg(android.os.Parcel r0, int r1, int r2, char r3, bool r4, float r5, byte r6) {
            goto Lf
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            return
        Lb:
            goto L21
        Lf:
            goto Lb
        L12:
            goto L2a
        L16:
            double r0 = (double) r3
            goto La
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L21:
            goto L12
        L24:
            int r3 = r2 + r1
            goto L16
        L2a:
            r0 = 42
            goto L1b
    }

    public static void JEqWYmoYbzISOESg(android.os.Parcel r0, int r1, int r2, float r3, byte r4, char r5, bool r6) {
            goto Lf
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L1f
        Lf:
            goto L20
        L12:
            goto L24
        L16:
            goto L12
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1f:
            return
        L20:
            goto L16
        L24:
            r0 = 42
            goto L19
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void OTMJzCtHiUUwtihl(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3) {
            goto Lb
        L4:
            com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeIBinder(r0, r1, r2, r3)
            goto L12
        Lb:
            goto L13
        Le:
            goto L4
        L12:
            return
        L13:
            goto L17
        L17:
            goto Le
    }

    public static void OTMJzCtHiUUwtihl(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3, byte r4, java.lang.string r5, bool r6, int r7) {
            goto L12
        L4:
            r0 = 42
            goto L19
        La:
            goto L15
        Ld:
            double r0 = (double) r3
            goto L2b
        L12:
            goto L2c
        L15:
            goto L4
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1f:
            int r2 = r0 * r1
            goto L25
        L25:
            int r3 = r2 + r1
            goto Ld
        L2b:
            return
        L2c:
            goto La
    }

    public static void OTMJzCtHiUUwtihl(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3, int r4, java.lang.string r5, byte r6, bool r7) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L11
        La:
            goto L18
        Ld:
            goto L2a
        L11:
            int r3 = r2 + r1
            goto L1c
        L17:
            return
        L18:
            goto L21
        L1c:
            double r0 = (double) r3
            goto L17
        L21:
            goto Ld
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2a:
            r0 = 42
            goto L24
    }

    public static void OTMJzCtHiUUwtihl(android.os.Parcel r0, int r1, android.os.IBinder r2, bool r3, java.lang.string r4, bool r5, int r6, byte r7) {
            goto L19
        L4:
            int r2 = r0 * r1
            goto L13
        La:
            goto L1c
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L13:
            int r3 = r2 + r1
            goto L20
        L19:
            goto L2c
        L1c:
            goto L25
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            r0 = 42
            goto Ld
        L2b:
            return
        L2c:
            goto La
    }

    public static void PiYGxHQakuYwxdYy(android.os.Parcel r0, int r1, android.os.Parcelable r2, int r3, bool r4) {
            goto Lb
        L4:
            com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(r0, r1, r2, r3, r4)
            goto L12
        Lb:
            goto L13
        Le:
            goto L4
        L12:
            return
        L13:
            goto L17
        L17:
            goto Le
    }

    public static void PiYGxHQakuYwxdYy(android.os.Parcel r0, int r1, android.os.Parcelable r2, int r3, bool r4, char r5, float r6, bool r7, short r8) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            return
        Lb:
            goto L27
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            goto Lb
        L18:
            goto L1c
        L1c:
            r0 = 42
            goto Lf
        L22:
            double r0 = (double) r3
            goto La
        L27:
            goto L18
        L2a:
            int r3 = r2 + r1
            goto L22
    }

    public static void PiYGxHQakuYwxdYy(android.os.Parcel r0, int r1, android.os.Parcelable r2, int r3, bool r4, float r5, bool r6, short r7, char r8) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L12
        La:
            goto L2c
        Ld:
            double r0 = (double) r3
            goto L1e
        L12:
            int r3 = r2 + r1
            goto Ld
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

    public static void PiYGxHQakuYwxdYy(android.os.Parcel r0, int r1, android.os.Parcelable r2, int r3, bool r4, bool r5, float r6, short r7, char r8) {
            goto La
        L4:
            r0 = 42
            goto L1c
        La:
            goto L29
        Ld:
            goto L4
        L11:
            double r0 = (double) r3
            goto L28
        L16:
            int r2 = r0 * r1
            goto L22
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L22:
            int r3 = r2 + r1
            goto L11
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto Ld
    }

    public static void RXTIaythPJPVMJRZ(android.os.Parcel r0, int r1) {
            goto L10
        L4:
            com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(r0, r1)
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public static void RXTIaythPJPVMJRZ(android.os.Parcel r0, int r1, byte r2, int r3, float r4, bool r5) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        La:
            return
        Lb:
            goto L15
        Lf:
            r0 = 42
            goto L4
        L15:
            goto L2c
        L18:
            int r3 = r2 + r1
            goto L24
        L1e:
            int r2 = r0 * r1
            goto L18
        L24:
            double r0 = (double) r3
            goto La
        L29:
            goto Lb
        L2c:
            goto Lf
    }

    public static void RXTIaythPJPVMJRZ(android.os.Parcel r0, int r1, byte r2, int r3, bool r4, float r5) {
            goto L18
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L1b
        L12:
            int r3 = r2 + r1
            goto L25
        L18:
            goto Lb
        L1b:
            goto L1f
        L1f:
            r0 = 42
            goto L4
        L25:
            double r0 = (double) r3
            goto La
        L2a:
            int r2 = r0 * r1
            goto L12
    }

    public static void RXTIaythPJPVMJRZ(android.os.Parcel r0, int r1, bool r2, byte r3, int r4, float r5) {
            goto L29
        L4:
            goto L2c
        L7:
            int r2 = r0 * r1
            goto Ld
        Ld:
            int r3 = r2 + r1
            goto L13
        L13:
            double r0 = (double) r3
            goto L1e
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L1e:
            return
        L1f:
            goto L4
        L23:
            r0 = 42
            goto L18
        L29:
            goto L1f
        L2c:
            goto L23
    }

    public static void SBlgvizNETFFsHkW(android.os.Parcel r0, int r1, java.lang.string r2, bool r3) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(r0, r1, r2, r3)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static void SBlgvizNETFFsHkW(android.os.Parcel r0, int r1, java.lang.string r2, bool r3, byte r4, float r5, java.lang.string r6, short r7) {
            goto L1e
        L4:
            r0 = 42
            goto Lf
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L15:
            int r3 = r2 + r1
            goto La
        L1b:
            goto L21
        L1e:
            goto L2c
        L21:
            goto L4
        L25:
            int r2 = r0 * r1
            goto L15
        L2b:
            return
        L2c:
            goto L1b
    }

    public static void SBlgvizNETFFsHkW(android.os.Parcel r0, int r1, java.lang.string r2, bool r3, float r4, java.lang.string r5, short r6, byte r7) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L10
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L20
        L1a:
            r0 = 42
            goto L23
        L20:
            goto L2c
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L29:
            goto L16
        L2c:
            goto L1a
    }

    public static void SBlgvizNETFFsHkW(android.os.Parcel r0, int r1, java.lang.string r2, bool r3, java.lang.string r4, float r5, byte r6, short r7) {
            goto L21
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        La:
            int r3 = r2 + r1
            goto L1c
        L10:
            r0 = 42
            goto L4
        L16:
            int r2 = r0 * r1
            goto La
        L1c:
            double r0 = (double) r3
            goto L28
        L21:
            goto L29
        L24:
            goto L10
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L24
    }

    public static com.google.android.gms.internal.location.zzee Zza(android.os.IInterface r6, com.google.android.gms.location.zzz r7, java.lang.string r8) {
            goto L71
        L4:
            r1 = 1
            goto L2e
        L9:
            r5 = r8
            goto L3a
        Le:
            goto L4f
        L11:
            goto L25
        L15:
            r2 = r6
            goto L4
        L1a:
            r3 = r7
            goto L9
        L1f:
            com.google.android.gms.internal.location.zzee r0 = new com.google.android.gms.internal.location.zzee
            goto L63
        L25:
            goto L74
        L28:
            int r0 = r0 % r1
            goto L53
        L2e:
            r4 = 0
            goto L1a
        L33:
            r1 = 17
            goto L41
        L3a:
            r0.<init>(r1, r2, r3, r4, r5)
            goto L6c
        L41:
            int r0 = r0 + r1
            goto L28
        L47:
            r6 = 0
        L48:
            goto L15
        L4c:
            goto L6d
        L4f:
            goto L1f
        L53:
            if (r0 <= 0) goto L58
            goto L4f
        L58:
            goto L4c
        L5c:
            r0 = 26
            goto L33
        L63:
            if (r6 == 0) goto L68
            goto L48
        L68:
            goto L47
        L6c:
            return r0
        L6d:
            goto Le
        L71:
            goto L11
        L74:
            goto L5c
    }

    public static void Zza(android.os.IInterface r0, com.google.android.gms.location.zzz r1, java.lang.string r2, float r3, bool r4, byte r5, int r6) {
            goto L19
        L4:
            r0 = 42
            goto L13
        La:
            int r3 = r2 + r1
            goto L26
        L10:
            goto L1c
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L19:
            goto L2c
        L1c:
            goto L4
        L20:
            int r2 = r0 * r1
            goto La
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L10
    }

    public static void Zza(android.os.IInterface r0, com.google.android.gms.location.zzz r1, java.lang.string r2, bool r3, float r4, int r5, byte r6) {
            goto L1e
        L4:
            goto L21
        L7:
            int r3 = r2 + r1
            goto L25
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L13:
            return
        L14:
            goto L4
        L18:
            int r2 = r0 * r1
            goto L7
        L1e:
            goto L14
        L21:
            goto L2a
        L25:
            double r0 = (double) r3
            goto L13
        L2a:
            r0 = 42
            goto Ld
    }

    public static void Zza(android.os.IInterface r0, com.google.android.gms.location.zzz r1, java.lang.string r2, bool r3, int r4, float r5, byte r6) {
            goto L1d
        L4:
            return
        L5:
            goto L14
        L9:
            int r2 = r0 * r1
            goto L17
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            goto L20
        L17:
            int r3 = r2 + r1
            goto Lf
        L1d:
            goto L5
        L20:
            goto L24
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
    }

    public static com.google.android.gms.internal.location.zzee Zzb(android.os.IInterface r6, com.google.android.gms.location.zzw r7, java.lang.string r8) {
            goto L71
        L4:
            com.google.android.gms.internal.location.zzee r0 = new com.google.android.gms.internal.location.zzee
            goto L50
        La:
            goto L47
        Ld:
            goto L4
        L11:
            goto L74
        L14:
            r4 = 0
            goto L38
        L19:
            int r0 = r0 % r1
            goto L3d
        L1f:
            r0 = 7
            goto L60
        L26:
            int r0 = r0 + r1
            goto L19
        L2c:
            goto Ld
        L2f:
            goto L11
        L33:
            r5 = r8
            goto L59
        L38:
            r3 = r7
            goto L33
        L3d:
            if (r0 <= 0) goto L42
            goto Ld
        L42:
            goto La
        L46:
            return r0
        L47:
            goto L2c
        L4b:
            r6 = 0
        L4c:
            goto L67
        L50:
            if (r6 == 0) goto L55
            goto L4c
        L55:
            goto L4b
        L59:
            r0.<init>(r1, r2, r3, r4, r5)
            goto L46
        L60:
            r1 = 6
            goto L26
        L67:
            r2 = r6
            goto L6c
        L6c:
            r1 = 2
            goto L14
        L71:
            goto L2f
        L74:
            goto L1f
    }

    public static void Zzb(android.os.IInterface r0, com.google.android.gms.location.zzw r1, java.lang.string r2, char r3, bool r4, short r5, float r6) {
            goto L23
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L10:
            goto L26
        L13:
            return
        L14:
            goto L10
        L18:
            double r0 = (double) r3
            goto L13
        L1d:
            int r2 = r0 * r1
            goto L2a
        L23:
            goto L14
        L26:
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L18
    }

    public static void Zzb(android.os.IInterface r0, com.google.android.gms.location.zzw r1, java.lang.string r2, float r3, bool r4, char r5, short r6) {
            goto Ld
        L4:
            goto L10
        L7:
            int r2 = r0 * r1
            goto L1a
        Ld:
            goto L21
        L10:
            goto L14
        L14:
            r0 = 42
            goto L25
        L1a:
            int r3 = r2 + r1
            goto L2b
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

    public static void Zzb(android.os.IInterface r0, com.google.android.gms.location.zzw r1, java.lang.string r2, short r3, bool r4, float r5, char r6) {
            goto L10
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            goto L27
        L13:
            goto L20
        L17:
            goto L13
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L20:
            r0 = 42
            goto L1a
        L26:
            return
        L27:
            goto L17
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static com.google.android.gms.internal.location.zzee Zzc(android.app.Pendingobject r6) {
            goto L5b
        L4:
            if (r0 <= 0) goto L9
            goto L1d
        L9:
            goto L1a
        Ld:
            int r0 = r0 % r1
            goto L4
        L13:
            r0.<init>(r1, r2, r3, r4, r5)
            goto L56
        L1a:
            goto L57
        L1d:
            goto L44
        L21:
            goto L1d
        L24:
            goto L67
        L28:
            int r0 = r0 + r1
            goto Ld
        L2e:
            r0 = 15
            goto L4a
        L35:
            r1 = 3
            goto L62
        L3a:
            r4 = r6
            goto L13
        L3f:
            r5 = 0
            goto L35
        L44:
            com.google.android.gms.internal.location.zzee r0 = new com.google.android.gms.internal.location.zzee
            goto L51
        L4a:
            r1 = 10
            goto L28
        L51:
            r3 = 0
            goto L3f
        L56:
            return r0
        L57:
            goto L21
        L5b:
            goto L24
        L5e:
            goto L2e
        L62:
            r2 = 0
            goto L3a
        L67:
            goto L5e
    }

    public static void Zzc(android.app.Pendingobject r0, char r1, float r2, int r3, java.lang.string r4) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L24
        Lb:
            return
        Lc:
            goto L21
        L10:
            int r2 = r0 * r1
            goto L2a
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L1c:
            double r0 = (double) r3
            goto Lb
        L21:
            goto L7
        L24:
            r0 = 42
            goto L16
        L2a:
            int r3 = r2 + r1
            goto L1c
    }

    public static void Zzc(android.app.Pendingobject r0, char r1, java.lang.string r2, float r3, int r4) {
            goto L4
        L4:
            goto L1b
        L7:
            goto L14
        Lb:
            int r3 = r2 + r1
            goto L2b
        L11:
            goto L7
        L14:
            r0 = 42
            goto L1f
        L1a:
            return
        L1b:
            goto L11
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L25:
            int r2 = r0 * r1
            goto Lb
        L2b:
            double r0 = (double) r3
            goto L1a
    }

    public static void Zzc(android.app.Pendingobject r0, java.lang.string r1, char r2, float r3, int r4) {
            goto L13
        L4:
            goto L16
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        Ld:
            r0 = 42
            goto L7
        L13:
            goto L2c
        L16:
            goto Ld
        L1a:
            int r2 = r0 * r1
            goto L25
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            int r3 = r2 + r1
            goto L20
        L2b:
            return
        L2c:
            goto L4
    }

    public static com.google.android.gms.internal.location.zzee Zzd(com.google.android.gms.internal.location.zzz r6) {
            goto L4
        L4:
            goto L66
        L7:
            goto L53
        Lb:
            r2 = 0
            goto L3b
        L10:
            r5 = 0
            goto L36
        L15:
            int r0 = r0 + r1
            goto L45
        L1b:
            r1 = 5
            goto L15
        L22:
            goto L4c
        L25:
            goto L30
        L29:
            r0.<init>(r1, r2, r3, r4, r5)
            goto L4b
        L30:
            com.google.android.gms.internal.location.zzee r0 = new com.google.android.gms.internal.location.zzee
            goto L40
        L36:
            r1 = 4
            goto Lb
        L3b:
            r3 = r6
            goto L29
        L40:
            r4 = 0
            goto L10
        L45:
            int r0 = r0 % r1
            goto L5a
        L4b:
            return r0
        L4c:
            goto L63
        L50:
            goto L7
        L53:
            r0 = 6
            goto L1b
        L5a:
            if (r0 <= 0) goto L5f
            goto L25
        L5f:
            goto L22
        L63:
            goto L25
        L66:
            goto L50
    }

    public static void Zzd(com.google.android.gms.internal.location.zzz r0, char r1, float r2, short r3, int r4) {
            goto L1e
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            double r0 = (double) r3
            goto L2b
        L15:
            goto L21
        L18:
            r0 = 42
            goto L25
        L1e:
            goto L2c
        L21:
            goto L18
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L2b:
            return
        L2c:
            goto L15
    }

    public static void Zzd(com.google.android.gms.internal.location.zzz r0, float r1, int r2, char r3, short r4) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L2a
        Lb:
            return
        Lc:
            goto L27
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L16:
            int r2 = r0 * r1
            goto L21
        L1c:
            double r0 = (double) r3
            goto Lb
        L21:
            int r3 = r2 + r1
            goto L1c
        L27:
            goto L7
        L2a:
            r0 = 42
            goto L10
    }

    public static void Zzd(com.google.android.gms.internal.location.zzz r0, int r1, float r2, short r3, char r4) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L20
        Le:
            int r3 = r2 + r1
            goto L4
        L14:
            r0 = 42
            goto L23
        L1a:
            int r2 = r0 * r1
            goto Le
        L20:
            goto L2c
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L29:
            goto La
        L2c:
            goto L14
    }

    @Override // android.os.Parcelable
    public readonly void WriteToParcel(android.os.Parcel r5, int r6) {
            r4 = this;
            goto L78
        L4:
            r0 = 4
            goto L72
        L9:
            goto L7b
        Lc:
            int r1 = VgQPObLYKQbHvRor(r5)
            goto L62
        L14:
            r0 = 1
            goto L86
        L1b:
            return
        L1c:
            goto L40
        L20:
            int r0 = r4.zza
            goto Lc
        L26:
            rXTIaythPJPVMJRZ(r5, r1)
            goto L1b
        L2d:
            r0 = 3
            goto L67
        L32:
            r6 = 6
            goto L5c
        L37:
            if (r0 <= 0) goto L3c
            goto L51
        L3c:
            goto L4e
        L40:
            goto L51
        L43:
            goto L9
        L47:
            sBlgvizNETFFsHkW(r5, r6, r4, r3)
            goto L26
        L4e:
            goto L1c
        L51:
            goto L20
        L55:
            JVKNEfNOgKmWSwsz(r5, r2, r0, r3)
            goto L2d
        L5c:
            java.lang.string r4 = r4.zze
            goto L47
        L62:
            r2 = 1
            goto L7f
        L67:
            android.os.IBinder r2 = r4.zzc
            goto L93
        L6d:
            r3 = 0
            goto L55
        L72:
            android.app.Pendingobject r2 = r4.zzd
            goto La0
        L78:
            goto L43
        L7b:
            goto L14
        L7f:
            jEqWYmoYbzISOESg(r5, r2, r0)
            goto Lac
        L86:
            r1 = 31
            goto L9a
        L8d:
            int r0 = r0 % r1
            goto L37
        L93:
            oTMJzCtHiUUwtihl(r5, r0, r2, r3)
            goto L4
        L9a:
            int r0 = r0 + r1
            goto L8d
        La0:
            piYGxHQakuYwxdYy(r5, r0, r2, r6, r3)
            goto L32
        La7:
            r2 = 2
            goto L6d
        Lac:
            android.os.IBinder r0 = r4.zzb
            goto La7
    }
}

