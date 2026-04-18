namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
public readonly class zzem : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable.Creator<com.google.android.gms.internal.location.zzem> CREATOR = null;
    private readonly java.util.List zza;
    private readonly android.app.Pendingobject zzb;
    private readonly java.lang.string zzc;

    static {
            goto L18
        L4:
            com.google.android.gms.internal.location.zzen r0 = new com.google.android.gms.internal.location.zzen
            goto L1f
        La:
            com.google.android.gms.internal.location.zzem.CREATOR = r0
            goto L13
        L10:
            goto L1b
        L13:
            return
        L14:
            goto L10
        L18:
            goto L14
        L1b:
            goto L4
        L1f:
            r0.<init>()
            goto La
    }

    zzem(java.util.List r1, android.app.Pendingobject r2, java.lang.string r3) {
            r0 = this;
            goto L39
        L4:
            com.google.android.gms.internal.location.zzex r1 = ibfSXLDogzChtrDr(r1)
        L8:
            goto L26
        Lc:
            if (r1 == 0) goto L11
            goto L35
        L11:
            goto L2c
        L15:
            r0.zzb = r2
            goto L1b
        L1b:
            r0.zzc = r3
            goto L21
        L21:
            return
        L22:
            goto L47
        L26:
            r0.zza = r1
            goto L15
        L2c:
            com.google.android.gms.internal.location.zzex r1 = rKqBkexEwSBMEPfk()
            goto L34
        L34:
            goto L8
        L35:
            goto L4
        L39:
            goto L22
        L3c:
            goto L40
        L40:
            r0.<init>()
            goto Lc
        L47:
            goto L3c
    }

    public static void TqpGpRyjJZEOWKak(android.os.Parcel r0, int r1, android.os.Parcelable r2, int r3, bool r4) {
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
            com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(r0, r1, r2, r3, r4)
            goto L7
    }

    public static void TqpGpRyjJZEOWKak(android.os.Parcel r0, int r1, android.os.Parcelable r2, int r3, bool r4, byte r5, java.lang.string r6, float r7, int r8) {
            goto L4
        L4:
            goto L15
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0 = 42
            goto L2a
        L14:
            return
        L15:
            goto Lb
        L19:
            int r2 = r0 * r1
            goto L24
        L1f:
            double r0 = (double) r3
            goto L14
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
    }

    public static void TqpGpRyjJZEOWKak(android.os.Parcel r0, int r1, android.os.Parcelable r2, int r3, bool r4, float r5, byte r6, java.lang.string r7, int r8) {
            goto L1a
        L4:
            return
        L5:
            goto L2d
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            int r3 = r2 + r1
            goto Lf
        L1a:
            goto L5
        L1d:
            goto L21
        L21:
            r0 = 42
            goto L9
        L27:
            int r2 = r0 * r1
            goto L14
        L2d:
            goto L1d
    }

    public static void TqpGpRyjJZEOWKak(android.os.Parcel r0, int r1, android.os.Parcelable r2, int r3, bool r4, int r5, java.lang.string r6, byte r7, float r8) {
            goto L13
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        La:
            goto L16
        Ld:
            int r2 = r0 * r1
            goto L1a
        L13:
            goto L21
        L16:
            goto L2a
        L1a:
            int r3 = r2 + r1
            goto L25
        L20:
            return
        L21:
            goto La
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            r0 = 42
            goto L4
    }

    public static void WUDLCziZwKHKcnAz(android.os.Parcel r0, int r1, java.lang.string r2, bool r3) {
            goto Le
        L4:
            com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(r0, r1, r2, r3)
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

    public static void WUDLCziZwKHKcnAz(android.os.Parcel r0, int r1, java.lang.string r2, bool r3, char r4, float r5, bool r6, java.lang.string r7) {
            goto L4
        L4:
            goto L18
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L1c
        L11:
            int r3 = r2 + r1
            goto L2b
        L17:
            return
        L18:
            goto L28
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L22:
            int r2 = r0 * r1
            goto L11
        L28:
            goto L7
        L2b:
            double r0 = (double) r3
            goto L17
    }

    public static void WUDLCziZwKHKcnAz(android.os.Parcel r0, int r1, java.lang.string r2, bool r3, java.lang.string r4, float r5, char r6, bool r7) {
            goto L23
        L4:
            goto L26
        L7:
            r0 = 42
            goto L2a
        Ld:
            int r3 = r2 + r1
            goto L18
        L13:
            return
        L14:
            goto L4
        L18:
            double r0 = (double) r3
            goto L13
        L1d:
            int r2 = r0 * r1
            goto Ld
        L23:
            goto L14
        L26:
            goto L7
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
    }

    public static void WUDLCziZwKHKcnAz(android.os.Parcel r0, int r1, java.lang.string r2, bool r3, java.lang.string r4, bool r5, char r6, float r7) {
            goto La
        L4:
            r0 = 42
            goto L22
        La:
            goto L29
        Ld:
            goto L4
        L11:
            int r2 = r0 * r1
            goto L17
        L17:
            int r3 = r2 + r1
            goto L1d
        L1d:
            double r0 = (double) r3
            goto L28
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto Ld
    }

    public static java.lang.object AhCibCIIKHtoiUNo(java.lang.object r1, java.lang.object r2) {
            goto Lf
        L4:
            java.lang.object r0 = com.google.android.gms.common.internal.Preconditions.checkNotNull(r1, r2)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static void AhCibCIIKHtoiUNo(java.lang.object r0, java.lang.object r1, float r2, java.lang.string r3, char r4, bool r5) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L20
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L14:
            int r2 = r0 * r1
            goto L2a
        L1a:
            r0 = 42
            goto Le
        L20:
            goto L26
        L23:
            goto La
        L26:
            goto L1a
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void AhCibCIIKHtoiUNo(java.lang.object r0, java.lang.object r1, float r2, bool r3, char r4, java.lang.string r5) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L1e
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            r0 = 42
            goto L23
        L16:
            return
        L17:
            goto L1b
        L1b:
            goto L2c
        L1e:
            double r0 = (double) r3
            goto L16
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L29:
            goto L17
        L2c:
            goto L10
    }

    public static void AhCibCIIKHtoiUNo(java.lang.object r0, java.lang.object r1, java.lang.string r2, char r3, float r4, bool r5) {
            goto L1d
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L1a
        Le:
            int r3 = r2 + r1
            goto L4
        L14:
            r0 = 42
            goto L2a
        L1a:
            goto L20
        L1d:
            goto La
        L20:
            goto L14
        L24:
            int r2 = r0 * r1
            goto Le
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static int ApeZKLPmCyxuNbXg(android.os.Parcel r1) {
            goto L11
        L4:
            int r0 = com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(r1)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static void ApeZKLPmCyxuNbXg(android.os.Parcel r0, char r1, bool r2, float r3, java.lang.string r4) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L1d
        L10:
            goto L26
        L13:
            goto L2a
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1d:
            double r0 = (double) r3
            goto L25
        L22:
            goto L13
        L25:
            return
        L26:
            goto L22
        L2a:
            r0 = 42
            goto L17
    }

    public static void ApeZKLPmCyxuNbXg(android.os.Parcel r0, float r1, bool r2, java.lang.string r3, char r4) {
            goto L13
        L4:
            r0 = 42
            goto L2a
        La:
            goto L16
        Ld:
            int r2 = r0 * r1
            goto L24
        L13:
            goto L20
        L16:
            goto L4
        L1a:
            double r0 = (double) r3
            goto L1f
        L1f:
            return
        L20:
            goto La
        L24:
            int r3 = r2 + r1
            goto L1a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
    }

    public static void ApeZKLPmCyxuNbXg(android.os.Parcel r0, java.lang.string r1, float r2, char r3, bool r4) {
            goto L4
        L4:
            goto L1d
        L7:
            goto L24
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L11:
            int r3 = r2 + r1
            goto L17
        L17:
            double r0 = (double) r3
            goto L1c
        L1c:
            return
        L1d:
            goto L21
        L21:
            goto L7
        L24:
            r0 = 42
            goto Lb
        L2a:
            int r2 = r0 * r1
            goto L11
    }

    public static void HVIjqwslMStFpRlq(bool r0, java.lang.object r1) {
            goto Lb
        L4:
            com.google.android.gms.common.internal.Preconditions.checkArgument(r0, r1)
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

    public static void HVIjqwslMStFpRlq(bool r0, java.lang.object r1, int r2, byte r3, float r4, bool r5) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto Le
        Le:
            goto L26
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L17:
            r0 = 42
            goto L11
        L1d:
            int r2 = r0 * r1
            goto L2a
        L23:
            goto La
        L26:
            goto L17
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void HVIjqwslMStFpRlq(bool r0, java.lang.object r1, int r2, byte r3, bool r4, float r5) {
            goto L1d
        L4:
            double r0 = (double) r3
            goto L18
        L9:
            int r2 = r0 * r1
            goto L12
        Lf:
            goto L20
        L12:
            int r3 = r2 + r1
            goto L4
        L18:
            return
        L19:
            goto Lf
        L1d:
            goto L19
        L20:
            goto L24
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
    }

    public static void HVIjqwslMStFpRlq(bool r0, java.lang.object r1, bool r2, byte r3, int r4, float r5) {
            goto L18
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            r0 = 42
            goto L2a
        L15:
            goto L1b
        L18:
            goto L26
        L1b:
            goto Lf
        L1f:
            int r2 = r0 * r1
            goto L9
        L25:
            return
        L26:
            goto L15
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
    }

    public static com.google.android.gms.internal.location.zzex IbfSXLDogzChtrDr(java.util.ICollection r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            com.google.android.gms.internal.location.zzex r0 = com.google.android.gms.internal.location.zzex.zzj(r1)
            goto L4
        L18:
            goto Lc
    }

    public static void IbfSXLDogzChtrDr(java.util.ICollection r0, char r1, bool r2, java.lang.string r3, int r4) {
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
            goto L16
        L16:
            r0 = 42
            goto L24
        L1c:
            goto L12
        L1f:
            return
        L20:
            goto L1c
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void IbfSXLDogzChtrDr(java.util.ICollection r0, int r1, java.lang.string r2, char r3, bool r4) {
            goto L23
        L4:
            goto L26
        L7:
            return
        L8:
            goto L4
        Lc:
            int r3 = r2 + r1
            goto L18
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L18:
            double r0 = (double) r3
            goto L7
        L1d:
            r0 = 42
            goto L12
        L23:
            goto L8
        L26:
            goto L1d
        L2a:
            int r2 = r0 * r1
            goto Lc
    }

    public static void IbfSXLDogzChtrDr(java.util.ICollection r0, java.lang.string r1, int r2, bool r3, char r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            goto L17
        Ld:
            goto L21
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
            goto L4
        L27:
            goto Ld
        L2a:
            int r2 = r0 * r1
            goto L1b
    }

    public static java.lang.object JgjchDoeLpwCvsqz(java.lang.object r1, java.lang.object r2) {
            goto Lc
        L4:
            java.lang.object r0 = com.google.android.gms.common.internal.Preconditions.checkNotNull(r1, r2)
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static void JgjchDoeLpwCvsqz(java.lang.object r0, java.lang.object r1, char r2, float r3, bool r4, int r5) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        La:
            r0 = 42
            goto L4
        L10:
            goto L27
        L13:
            int r3 = r2 + r1
            goto L1f
        L19:
            int r2 = r0 * r1
            goto L13
        L1f:
            double r0 = (double) r3
            goto L2b
        L24:
            goto L2c
        L27:
            goto La
        L2b:
            return
        L2c:
            goto L10
    }

    public static void JgjchDoeLpwCvsqz(java.lang.object r0, java.lang.object r1, int r2, float r3, char r4, bool r5) {
            goto L10
        L4:
            r0 = 42
            goto L2a
        La:
            int r2 = r0 * r1
            goto L1f
        L10:
            goto L18
        L13:
            goto L4
        L17:
            return
        L18:
            goto L1c
        L1c:
            goto L13
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto L17
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
    }

    public static void JgjchDoeLpwCvsqz(java.lang.object r0, java.lang.object r1, bool r2, float r3, int r4, char r5) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L11
        La:
            goto L23
        Ld:
            goto L2a
        L11:
            double r0 = (double) r3
            goto L22
        L16:
            int r2 = r0 * r1
            goto L4
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L22:
            return
        L23:
            goto L27
        L27:
            goto Ld
        L2a:
            r0 = 42
            goto L1c
    }

    public static void LaKGIoncsKwoCRyL(java.util.List r0, float r1, bool r2, short r3, java.lang.string r4) {
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
            goto L2a
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L19:
            double r0 = (double) r3
            goto L7
        L1e:
            int r3 = r2 + r1
            goto L19
        L24:
            int r2 = r0 * r1
            goto L1e
        L2a:
            r0 = 42
            goto L13
    }

    public static void LaKGIoncsKwoCRyL(java.util.List r0, short r1, java.lang.string r2, float r3, bool r4) {
            goto L23
        L4:
            r0 = 42
            goto L1d
        La:
            goto L26
        Ld:
            double r0 = (double) r3
            goto L12
        L12:
            return
        L13:
            goto La
        L17:
            int r2 = r0 * r1
            goto L2a
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L23:
            goto L13
        L26:
            goto L4
        L2a:
            int r3 = r2 + r1
            goto Ld
    }

    public static void LaKGIoncsKwoCRyL(java.util.List r0, bool r1, short r2, java.lang.string r3, float r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L23
        La:
            goto L29
        Ld:
            goto L11
        L11:
            r0 = 42
            goto L17
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L1d:
            int r2 = r0 * r1
            goto L4
        L23:
            double r0 = (double) r3
            goto L28
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto Ld
    }

    public static bool LaKGIoncsKwoCRyL(java.util.List r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            bool r0 = r1.Count == 0
            goto L4
        L18:
            goto Lc
    }

    public static com.google.android.gms.internal.location.zzex RKqBkexEwSBMEPfk() {
            goto Lf
        L4:
            com.google.android.gms.internal.location.zzex r0 = com.google.android.gms.internal.location.zzex.zzi()
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static void RKqBkexEwSBMEPfk(char r0, bool r1, byte r2, java.lang.string r3) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto L1d
        La:
            double r0 = (double) r3
            goto L12
        Lf:
            goto L26
        L12:
            return
        L13:
            goto Lf
        L17:
            r0 = 42
            goto L2a
        L1d:
            int r3 = r2 + r1
            goto La
        L23:
            goto L13
        L26:
            goto L17
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void RKqBkexEwSBMEPfk(java.lang.string r0, byte r1, char r2, bool r3) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L22
        La:
            goto L18
        Ld:
            goto L11
        L11:
            r0 = 42
            goto L27
        L17:
            return
        L18:
            goto L2d
        L1c:
            int r2 = r0 * r1
            goto L4
        L22:
            double r0 = (double) r3
            goto L17
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L2d:
            goto Ld
    }

    public static void RKqBkexEwSBMEPfk(bool r0, byte r1, java.lang.string r2, char r3) {
            goto L29
        L4:
            return
        L5:
            goto L20
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L14:
            int r2 = r0 * r1
            goto L23
        L1a:
            r0 = 42
            goto Le
        L20:
            goto L2c
        L23:
            int r3 = r2 + r1
            goto L9
        L29:
            goto L5
        L2c:
            goto L1a
    }

    public static void URZfhfSfzdVaLQzm(android.os.Parcel r0, int r1) {
            goto Le
        L4:
            goto L11
        L7:
            com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(r0, r1)
            goto L15
        Le:
            goto L16
        L11:
            goto L7
        L15:
            return
        L16:
            goto L4
    }

    public static void URZfhfSfzdVaLQzm(android.os.Parcel r0, int r1, int r2, java.lang.string r3, short r4, byte r5) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        La:
            goto L2c
        Ld:
            goto L1c
        L11:
            int r3 = r2 + r1
            goto L17
        L17:
            double r0 = (double) r3
            goto L2b
        L1c:
            r0 = 42
            goto L4
        L22:
            int r2 = r0 * r1
            goto L11
        L28:
            goto Ld
        L2b:
            return
        L2c:
            goto L28
    }

    public static void URZfhfSfzdVaLQzm(android.os.Parcel r0, int r1, int r2, short r3, java.lang.string r4, byte r5) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L16
        La:
            r0 = 42
            goto L10
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L16:
            int r3 = r2 + r1
            goto L1f
        L1c:
            goto L2c
        L1f:
            double r0 = (double) r3
            goto L24
        L24:
            return
        L25:
            goto L1c
        L29:
            goto L25
        L2c:
            goto La
    }

    public static void URZfhfSfzdVaLQzm(android.os.Parcel r0, int r1, java.lang.string r2, short r3, int r4, byte r5) {
            goto L23
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r2 = r0 * r1
            goto L2a
        Lf:
            return
        L10:
            goto L1a
        L14:
            r0 = 42
            goto L1d
        L1a:
            goto L26
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L23:
            goto L10
        L26:
            goto L14
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void YYvEJDWQfrVkDSXV(android.os.Parcel r0, int r1, java.util.List r2, bool r3) {
            goto L13
        L4:
            com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestringList(r0, r1, r2, r3)
            goto Le
        Lb:
            goto L16
        Le:
            return
        Lf:
            goto Lb
        L13:
            goto Lf
        L16:
            goto L4
    }

    public static void YYvEJDWQfrVkDSXV(android.os.Parcel r0, int r1, java.util.List r2, bool r3, float r4, int r5, bool r6, char r7) {
            goto L29
        L4:
            goto L2c
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        Ld:
            double r0 = (double) r3
            goto L1e
        L12:
            int r3 = r2 + r1
            goto Ld
        L18:
            int r2 = r0 * r1
            goto L12
        L1e:
            return
        L1f:
            goto L4
        L23:
            r0 = 42
            goto L7
        L29:
            goto L1f
        L2c:
            goto L23
    }

    public static void YYvEJDWQfrVkDSXV(android.os.Parcel r0, int r1, java.util.List r2, bool r3, float r4, bool r5, char r6, int r7) {
            goto L23
        L4:
            return
        L5:
            goto Le
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            goto L26
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L17:
            int r2 = r0 * r1
            goto L1d
        L1d:
            int r3 = r2 + r1
            goto L9
        L23:
            goto L5
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L11
    }

    public static void YYvEJDWQfrVkDSXV(android.os.Parcel r0, int r1, java.util.List r2, bool r3, bool r4, float r5, char r6, int r7) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L12
        L9:
            goto L2c
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L12:
            return
        L13:
            goto L9
        L17:
            int r3 = r2 + r1
            goto L4
        L1d:
            r0 = 42
            goto Lc
        L23:
            int r2 = r0 * r1
            goto L17
        L29:
            goto L13
        L2c:
            goto L1d
    }

    public static com.google.android.gms.internal.location.zzem Zza(java.util.List r3) {
            goto L55
        L4:
            ahCibCIIKHtoiUNo(r3, r0)
            goto L12
        Lb:
            r0 = 6
            goto L3f
        L12:
            bool r0 = laKGIoncsKwoCRyL(r3)
            goto L5c
        L1a:
            java.lang.string r1 = "Geofences must contains at least one id."
            goto L2c
        L20:
            return r0
        L21:
            goto L25
        L25:
            goto L72
        L28:
            goto L52
        L2c:
            hVIjqwslMStFpRlq(r0, r1)
            goto L4c
        L33:
            java.lang.string r2 = ""
            goto L62
        L39:
            java.lang.string r0 = "geofence can't be null."
            goto L4
        L3f:
            r1 = 19
            goto L69
        L46:
            int r0 = r0 % r1
            goto L7b
        L4c:
            com.google.android.gms.internal.location.zzem r0 = new com.google.android.gms.internal.location.zzem
            goto L76
        L52:
            goto L58
        L55:
            goto L28
        L58:
            goto Lb
        L5c:
            r0 = r0 ^ 1
            goto L1a
        L62:
            r0.<init>(r3, r1, r2)
            goto L20
        L69:
            int r0 = r0 + r1
            goto L46
        L6f:
            goto L21
        L72:
            goto L39
        L76:
            r1 = 0
            goto L33
        L7b:
            if (r0 <= 0) goto L80
            goto L72
        L80:
            goto L6f
    }

    public static void Zza(java.util.List r0, java.lang.string r1, byte r2, int r3, bool r4) {
            goto L24
        L4:
            goto L27
        L7:
            int r2 = r0 * r1
            goto L13
        Ld:
            r0 = 42
            goto L1e
        L13:
            int r3 = r2 + r1
            goto L19
        L19:
            double r0 = (double) r3
            goto L2b
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L24:
            goto L2c
        L27:
            goto Ld
        L2b:
            return
        L2c:
            goto L4
    }

    public static void Zza(java.util.List r0, java.lang.string r1, bool r2, int r3, byte r4) {
            goto L23
        L4:
            r0 = 42
            goto L2a
        La:
            double r0 = (double) r3
            goto L1e
        Lf:
            goto L26
        L12:
            int r3 = r2 + r1
            goto La
        L18:
            int r2 = r0 * r1
            goto L12
        L1e:
            return
        L1f:
            goto Lf
        L23:
            goto L1f
        L26:
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
    }

    public static void Zza(java.util.List r0, bool r1, int r2, byte r3, java.lang.string r4) {
            goto L26
        L4:
            double r0 = (double) r3
            goto L21
        L9:
            int r2 = r0 * r1
            goto Lf
        Lf:
            int r3 = r2 + r1
            goto L4
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1b:
            r0 = 42
            goto L15
        L21:
            return
        L22:
            goto L2d
        L26:
            goto L22
        L29:
            goto L1b
        L2d:
            goto L29
    }

    public static com.google.android.gms.internal.location.zzem Zzb(android.app.Pendingobject r3) {
            goto L3c
        L4:
            r0.<init>(r1, r3, r2)
            goto L12
        Lb:
            goto L65
        Le:
            goto L39
        L12:
            return r0
        L13:
            goto Lb
        L17:
            if (r0 <= 0) goto L1c
            goto L65
        L1c:
            goto L62
        L20:
            int r0 = r0 % r1
            goto L17
        L26:
            r0 = 25
            goto L4f
        L2d:
            java.lang.string r0 = "Pendingobject can not be null."
            goto L48
        L33:
            java.lang.string r2 = ""
            goto L4
        L39:
            goto L3f
        L3c:
            goto Le
        L3f:
            goto L26
        L43:
            r1 = 0
            goto L33
        L48:
            jgjchDoeLpwCvsqz(r3, r0)
            goto L56
        L4f:
            r1 = 25
            goto L5c
        L56:
            com.google.android.gms.internal.location.zzem r0 = new com.google.android.gms.internal.location.zzem
            goto L43
        L5c:
            int r0 = r0 + r1
            goto L20
        L62:
            goto L13
        L65:
            goto L2d
    }

    public static void Zzb(android.app.Pendingobject r0, byte r1, bool r2, int r3, short r4) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        La:
            return
        Lb:
            goto L15
        Lf:
            int r3 = r2 + r1
            goto L18
        L15:
            goto L2c
        L18:
            double r0 = (double) r3
            goto La
        L1d:
            int r2 = r0 * r1
            goto Lf
        L23:
            r0 = 42
            goto L4
        L29:
            goto Lb
        L2c:
            goto L23
    }

    public static void Zzb(android.app.Pendingobject r0, short r1, byte r2, bool r3, int r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L1d
        La:
            r0 = 42
            goto L23
        L10:
            return
        L11:
            goto L1a
        L15:
            double r0 = (double) r3
            goto L10
        L1a:
            goto L2c
        L1d:
            int r3 = r2 + r1
            goto L15
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L29:
            goto L11
        L2c:
            goto La
    }

    public static void Zzb(android.app.Pendingobject r0, bool r1, short r2, int r3, byte r4) {
            goto L29
        L4:
            r0 = 42
            goto Lf
        La:
            return
        Lb:
            goto L1a
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L15:
            double r0 = (double) r3
            goto La
        L1a:
            goto L2c
        L1d:
            int r2 = r0 * r1
            goto L23
        L23:
            int r3 = r2 + r1
            goto L15
        L29:
            goto Lb
        L2c:
            goto L4
    }

    @Override // android.os.Parcelable
    public readonly void WriteToParcel(android.os.Parcel r5, int r6) {
            r4 = this;
            goto L23
        L4:
            r6 = 3
            goto L10
        L9:
            goto L4d
        Lc:
            goto L1d
        L10:
            java.lang.string r4 = r4.zzc
            goto L69
        L16:
            yYvEJDWQfrVkDSXV(r5, r2, r0, r3)
            goto L77
        L1d:
            java.util.List r0 = r4.zza
            goto L61
        L23:
            goto L8a
        L26:
            goto L2a
        L2a:
            r0 = 12
            goto L5a
        L31:
            android.app.Pendingobject r2 = r4.zzb
            goto L40
        L37:
            if (r0 <= 0) goto L3c
            goto Lc
        L3c:
            goto L9
        L40:
            TqpGpRyjJZEOWKak(r5, r0, r2, r6, r3)
            goto L4
        L47:
            r3 = 0
            goto L16
        L4c:
            return
        L4d:
            goto L87
        L51:
            int r0 = r0 + r1
            goto L81
        L57:
            goto L26
        L5a:
            r1 = 30
            goto L51
        L61:
            int r1 = apeZKLPmCyxuNbXg(r5)
            goto L7c
        L69:
            WUDLCziZwKHKcnAz(r5, r6, r4, r3)
            goto L70
        L70:
            uRZfhfSfzdVaLQzm(r5, r1)
            goto L4c
        L77:
            r0 = 2
            goto L31
        L7c:
            r2 = 1
            goto L47
        L81:
            int r0 = r0 % r1
            goto L37
        L87:
            goto Lc
        L8a:
            goto L57
    }
}

