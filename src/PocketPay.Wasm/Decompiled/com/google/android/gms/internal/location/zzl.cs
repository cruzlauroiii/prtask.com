namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
public readonly class zzl : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : com.google.android.gms.common.api.Result {
    public static readonly android.os.Parcelable.Creator<com.google.android.gms.internal.location.zzl> CREATOR = null;
    public static readonly com.google.android.gms.internal.location.zzl zza = null;
    private readonly com.google.android.gms.common.api.Status zzb;

    static {
            goto L5d
        L4:
            com.google.android.gms.internal.location.zzm r0 = new com.google.android.gms.internal.location.zzm
            goto L26
        La:
            goto L4a
        Ld:
            goto L64
        L11:
            r0.<init>(r1)
            goto L6a
        L18:
            goto Ld
        L1b:
            goto L54
        L1f:
            r1 = 28
            goto L3d
        L26:
            r0.<init>()
            goto L57
        L2d:
            r0 = 11
            goto L1f
        L34:
            if (r0 <= 0) goto L39
            goto Ld
        L39:
            goto La
        L3d:
            int r0 = r0 + r1
            goto L4e
        L43:
            com.google.android.gms.common.api.Status r1 = com.google.android.gms.common.api.Status.RESULT_SUCCESS
            goto L11
        L49:
            return
        L4a:
            goto L18
        L4e:
            int r0 = r0 % r1
            goto L34
        L54:
            goto L60
        L57:
            com.google.android.gms.internal.location.zzl.CREATOR = r0
            goto L49
        L5d:
            goto L1b
        L60:
            goto L2d
        L64:
            com.google.android.gms.internal.location.zzl r0 = new com.google.android.gms.internal.location.zzl
            goto L43
        L6a:
            com.google.android.gms.internal.location.zzl.zza = r0
            goto L4
    }

    public zzl(com.google.android.gms.common.api.Status r1) {
            r0 = this;
            goto Le
        L4:
            goto L11
        L7:
            r0.<init>()
            goto L15
        Le:
            goto L1c
        L11:
            goto L7
        L15:
            r0.zzb = r1
            goto L1b
        L1b:
            return
        L1c:
            goto L4
    }

    public static int QBBdEQzNdbmyfWvD(android.os.Parcel r1) {
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

    public static void QBBdEQzNdbmyfWvD(android.os.Parcel r0, char r1, java.lang.string r2, int r3, short r4) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L15
        Lf:
            r0 = 42
            goto L23
        L15:
            return
        L16:
            goto L1a
        L1a:
            goto L2c
        L1d:
            int r2 = r0 * r1
            goto L4
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L29:
            goto L16
        L2c:
            goto Lf
    }

    public static void QBBdEQzNdbmyfWvD(android.os.Parcel r0, int r1, char r2, short r3, java.lang.string r4) {
            goto L13
        L4:
            int r2 = r0 * r1
            goto Ld
        La:
            goto L16
        Ld:
            int r3 = r2 + r1
            goto L2b
        L13:
            goto L27
        L16:
            goto L1a
        L1a:
            r0 = 42
            goto L20
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L26:
            return
        L27:
            goto La
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void QBBdEQzNdbmyfWvD(android.os.Parcel r0, short r1, int r2, char r3, java.lang.string r4) {
            goto L9
        L4:
            return
        L5:
            goto L21
        L9:
            goto L5
        Lc:
            goto L2a
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L16:
            int r3 = r2 + r1
            goto L1c
        L1c:
            double r0 = (double) r3
            goto L4
        L21:
            goto Lc
        L24:
            int r2 = r0 * r1
            goto L16
        L2a:
            r0 = 42
            goto L10
    }

    public static void DMjakqdiSgmdnNQr(android.os.Parcel r0, int r1, android.os.Parcelable r2, int r3, bool r4) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(r0, r1, r2, r3, r4)
            goto Lb
    }

    public static void DMjakqdiSgmdnNQr(android.os.Parcel r0, int r1, android.os.Parcelable r2, int r3, bool r4, int r5, byte r6, java.lang.string r7, float r8) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            goto L2c
        L12:
            goto L25
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L1c:
            int r2 = r0 * r1
            goto L9
        L22:
            goto L12
        L25:
            r0 = 42
            goto L16
        L2b:
            return
        L2c:
            goto L22
    }

    public static void DMjakqdiSgmdnNQr(android.os.Parcel r0, int r1, android.os.Parcelable r2, int r3, bool r4, int r5, float r6, java.lang.string r7, byte r8) {
            goto L23
        L4:
            goto L26
        L7:
            r0 = 42
            goto L12
        Ld:
            return
        Le:
            goto L4
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L18:
            double r0 = (double) r3
            goto Ld
        L1d:
            int r2 = r0 * r1
            goto L2a
        L23:
            goto Le
        L26:
            goto L7
        L2a:
            int r3 = r2 + r1
            goto L18
    }

    public static void DMjakqdiSgmdnNQr(android.os.Parcel r0, int r1, android.os.Parcelable r2, int r3, bool r4, java.lang.string r5, int r6, float r7, byte r8) {
            goto L14
        L4:
            int r2 = r0 * r1
            goto L1b
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L2d
        L14:
            goto L10
        L17:
            goto L21
        L1b:
            int r3 = r2 + r1
            goto La
        L21:
            r0 = 42
            goto L27
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2d:
            goto L17
    }

    public static void TnzpbliWcenhdXZy(android.os.Parcel r0, int r1) {
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

    public static void TnzpbliWcenhdXZy(android.os.Parcel r0, int r1, byte r2, short r3, int r4, bool r5) {
            goto L4
        L4:
            goto L1e
        L7:
            goto L22
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L11:
            int r3 = r2 + r1
            goto L2b
        L17:
            int r2 = r0 * r1
            goto L11
        L1d:
            return
        L1e:
            goto L28
        L22:
            r0 = 42
            goto Lb
        L28:
            goto L7
        L2b:
            double r0 = (double) r3
            goto L1d
    }

    public static void TnzpbliWcenhdXZy(android.os.Parcel r0, int r1, int r2, byte r3, bool r4, short r5) {
            goto L26
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r2 = r0 * r1
            goto L20
        Lf:
            return
        L10:
            goto L2d
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1a:
            r0 = 42
            goto L14
        L20:
            int r3 = r2 + r1
            goto L4
        L26:
            goto L10
        L29:
            goto L1a
        L2d:
            goto L29
    }

    public static void TnzpbliWcenhdXZy(android.os.Parcel r0, int r1, bool r2, int r3, byte r4, short r5) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L12
        L9:
            goto L26
        Lc:
            int r2 = r0 * r1
            goto L1d
        L12:
            return
        L13:
            goto L9
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
        L1d:
            int r3 = r2 + r1
            goto L4
        L23:
            goto L13
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L17
    }

    @Override // com.google.android.gms.common.api.Result
    public readonly com.google.android.gms.common.api.Status GetStatus() {
            r0 = this;
            goto L12
        L4:
            com.google.android.gms.common.api.Status r0 = r0.zzb
            goto La
        La:
            return r0
        Lb:
            goto Lf
        Lf:
            goto L15
        L12:
            goto Lb
        L15:
            goto L4
    }

    @Override // android.os.Parcelable
    public readonly void WriteToParcel(android.os.Parcel r4, int r5) {
            r3 = this;
            goto L55
        L4:
            goto L48
        L7:
            goto L22
        Lb:
            goto L58
        Le:
            int r0 = r0 % r1
            goto L4c
        L14:
            tnzpbliWcenhdXZy(r4, r0)
            goto L47
        L1b:
            goto L7
        L1e:
            goto Lb
        L22:
            int r0 = QBBdEQzNdbmyfWvD(r4)
            goto L41
        L2a:
            r1 = 0
            goto L2f
        L2f:
            r2 = 1
            goto L34
        L34:
            dMjakqdiSgmdnNQr(r4, r2, r3, r5, r1)
            goto L14
        L3b:
            int r0 = r0 + r1
            goto Le
        L41:
            com.google.android.gms.common.api.Status r3 = r3.zzb
            goto L2a
        L47:
            return
        L48:
            goto L1b
        L4c:
            if (r0 <= 0) goto L51
            goto L7
        L51:
            goto L4
        L55:
            goto L1e
        L58:
            goto L63
        L5c:
            r1 = 14
            goto L3b
        L63:
            r0 = 2
            goto L5c
    }
}

