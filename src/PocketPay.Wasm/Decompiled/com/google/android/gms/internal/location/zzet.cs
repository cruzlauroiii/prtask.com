namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
abstract class zzet : com.google.android.gms.internal.location.zzfa {
    private readonly int zza;
    private int zzb;

    protected zzet(int r2, int r3) {
            r1 = this;
            goto L2c
        L4:
            goto L2f
        L7:
            WNLSoXDSBNYIDmyI(r3, r2, r0)
            goto L20
        Le:
            return
        Lf:
            goto L4
        L13:
            java.lang.string r0 = "index"
            goto L7
        L19:
            r1.<init>()
            goto L13
        L20:
            r1.zza = r2
            goto L26
        L26:
            r1.zzb = r3
            goto Le
        L2c:
            goto Lf
        L2f:
            goto L19
    }

    public static void DGYYqpqxqMenKtCF(com.google.android.gms.internal.location.zzet r0, float r1, int r2, short r3, bool r4) {
            goto L24
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            goto L27
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L13:
            int r2 = r0 * r1
            goto L4
        L19:
            return
        L1a:
            goto La
        L1e:
            r0 = 42
            goto Ld
        L24:
            goto L1a
        L27:
            goto L1e
        L2b:
            double r0 = (double) r3
            goto L19
    }

    public static void DGYYqpqxqMenKtCF(com.google.android.gms.internal.location.zzet r0, float r1, short r2, int r3, bool r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L25
        Lb:
            int r3 = r2 + r1
            goto L11
        L11:
            double r0 = (double) r3
            goto L2b
        L16:
            goto L7
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1f:
            int r2 = r0 * r1
            goto Lb
        L25:
            r0 = 42
            goto L19
        L2b:
            return
        L2c:
            goto L16
    }

    public static void DGYYqpqxqMenKtCF(com.google.android.gms.internal.location.zzet r0, bool r1, short r2, float r3, int r4) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto L22
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            double r0 = (double) r3
            goto L2b
        L15:
            goto L2c
        L18:
            goto L1c
        L1c:
            r0 = 42
            goto La
        L22:
            int r3 = r2 + r1
            goto L10
        L28:
            goto L18
        L2b:
            return
        L2c:
            goto L28
    }

    public static bool DGYYqpqxqMenKtCF(com.google.android.gms.internal.location.zzet r1) {
            goto L14
        L4:
            bool r0 = r1.MoveNext()
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

    public static void QDFClnFvwefALVQG(com.google.android.gms.internal.location.zzet r0, float r1, short r2, char r3, bool r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L25
        Lb:
            double r0 = (double) r3
            goto L2b
        L10:
            int r3 = r2 + r1
            goto Lb
        L16:
            goto L7
        L19:
            int r2 = r0 * r1
            goto L10
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L25:
            r0 = 42
            goto L1f
        L2b:
            return
        L2c:
            goto L16
    }

    public static void QDFClnFvwefALVQG(com.google.android.gms.internal.location.zzet r0, short r1, bool r2, float r3, char r4) {
            goto La
        L4:
            r0 = 42
            goto L2a
        La:
            goto L21
        Ld:
            goto L4
        L11:
            int r2 = r0 * r1
            goto L17
        L17:
            int r3 = r2 + r1
            goto L25
        L1d:
            goto Ld
        L20:
            return
        L21:
            goto L1d
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
    }

    public static void QDFClnFvwefALVQG(com.google.android.gms.internal.location.zzet r0, bool r1, float r2, short r3, char r4) {
            goto L1b
        L4:
            int r2 = r0 * r1
            goto L10
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            int r3 = r2 + r1
            goto L22
        L16:
            return
        L17:
            goto L27
        L1b:
            goto L17
        L1e:
            goto L2a
        L22:
            double r0 = (double) r3
            goto L16
        L27:
            goto L1e
        L2a:
            r0 = 42
            goto La
    }

    public static bool QDFClnFvwefALVQG(com.google.android.gms.internal.location.zzet r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            bool r0 = r1.hasPrevious()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.object SVvVkqJxgPLywxyl(com.google.android.gms.internal.location.zzet r1, int r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.object r0 = r1.zza(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void SVvVkqJxgPLywxyl(com.google.android.gms.internal.location.zzet r0, int r1, int r2, short r3, java.lang.string r4, char r5) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto Lf
        La:
            double r0 = (double) r3
            goto L15
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            return
        L16:
            goto L20
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L20:
            goto L2c
        L23:
            r0 = 42
            goto L1a
        L29:
            goto L16
        L2c:
            goto L23
    }

    public static void SVvVkqJxgPLywxyl(com.google.android.gms.internal.location.zzet r0, int r1, java.lang.string r2, short r3, int r4, char r5) {
            goto L10
        L4:
            r0 = 42
            goto L17
        La:
            int r2 = r0 * r1
            goto L1d
        L10:
            goto L24
        L13:
            goto L4
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L1d:
            int r3 = r2 + r1
            goto L2b
        L23:
            return
        L24:
            goto L28
        L28:
            goto L13
        L2b:
            double r0 = (double) r3
            goto L23
    }

    public static void SVvVkqJxgPLywxyl(com.google.android.gms.internal.location.zzet r0, int r1, short r2, java.lang.string r3, char r4, int r5) {
            goto L20
        L4:
            double r0 = (double) r3
            goto L1b
        L9:
            int r2 = r0 * r1
            goto L2a
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L15:
            r0 = 42
            goto Lf
        L1b:
            return
        L1c:
            goto L27
        L20:
            goto L1c
        L23:
            goto L15
        L27:
            goto L23
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static int WNLSoXDSBNYIDmyI(int r1, int r2, java.lang.string r3) {
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
            int r0 = com.google.android.gms.internal.location.zzer.zzd(r1, r2, r3)
            goto L7
    }

    public static void WNLSoXDSBNYIDmyI(int r0, int r1, java.lang.string r2, int r3, float r4, java.lang.string r5, byte r6) {
            goto L7
        L4:
            goto La
        L7:
            goto L15
        La:
            goto L1e
        Le:
            int r3 = r2 + r1
            goto L19
        L14:
            return
        L15:
            goto L4
        L19:
            double r0 = (double) r3
            goto L14
        L1e:
            r0 = 42
            goto L24
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto Le
    }

    public static void WNLSoXDSBNYIDmyI(int r0, int r1, java.lang.string r2, int r3, java.lang.string r4, byte r5, float r6) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L1a
        L1a:
            goto L26
        L1d:
            r0 = 42
            goto La
        L23:
            goto L16
        L26:
            goto L1d
        L2a:
            int r3 = r2 + r1
            goto L10
    }

    public static void WNLSoXDSBNYIDmyI(int r0, int r1, java.lang.string r2, java.lang.string r3, int r4, byte r5, float r6) {
            goto L4
        L4:
            goto L11
        L7:
            goto L15
        Lb:
            double r0 = (double) r3
            goto L10
        L10:
            return
        L11:
            goto L21
        L15:
            r0 = 42
            goto L24
        L1b:
            int r3 = r2 + r1
            goto Lb
        L21:
            goto L7
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L1b
    }

    public static java.lang.object XdbRacPeHVPldjJe(com.google.android.gms.internal.location.zzet r1, int r2) {
            goto L14
        L4:
            java.lang.object r0 = r1.zza(r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static void XdbRacPeHVPldjJe(com.google.android.gms.internal.location.zzet r0, int r1, char r2, java.lang.string r3, float r4, short r5) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto Ld
        La:
            goto L26
        Ld:
            double r0 = (double) r3
            goto L18
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L18:
            return
        L19:
            goto La
        L1d:
            r0 = 42
            goto L12
        L23:
            goto L19
        L26:
            goto L1d
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void XdbRacPeHVPldjJe(com.google.android.gms.internal.location.zzet r0, int r1, char r2, java.lang.string r3, short r4, float r5) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L15
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            int r2 = r0 * r1
            goto L9
        L15:
            return
        L16:
            goto L26
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L20:
            r0 = 42
            goto L1a
        L26:
            goto L2c
        L29:
            goto L16
        L2c:
            goto L20
    }

    public static void XdbRacPeHVPldjJe(com.google.android.gms.internal.location.zzet r0, int r1, short r2, char r3, float r4, java.lang.string r5) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L18
        La:
            double r0 = (double) r3
            goto L1e
        Lf:
            goto L2c
        L12:
            r0 = 42
            goto L23
        L18:
            int r3 = r2 + r1
            goto La
        L1e:
            return
        L1f:
            goto Lf
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L29:
            goto L1f
        L2c:
            goto L12
    }

    @Override // java.util.IEnumerator, java.util.ListIEnumerator
    public readonly bool HasNext() {
            r1 = this;
            goto L10
        L4:
            goto L13
        L7:
            if (r0 < r1) goto Lc
            goto L18
        Lc:
            goto L1c
        L10:
            goto L28
        L13:
            goto L31
        L17:
            return r1
        L18:
            goto L2c
        L1c:
            r1 = 1
            goto L17
        L21:
            int r1 = r1.zza
            goto L7
        L27:
            return r1
        L28:
            goto L4
        L2c:
            r1 = 0
            goto L27
        L31:
            int r0 = r1.zzb
            goto L21
    }

    @Override // java.util.ListIEnumerator
    public readonly bool HasPrevious() {
            r0 = this;
            goto L14
        L4:
            return r0
        L5:
            goto L1b
        L9:
            int r0 = r0.zzb
            goto L23
        Lf:
            r0 = 1
            goto L4
        L14:
            goto L2d
        L17:
            goto L9
        L1b:
            r0 = 0
            goto L2c
        L20:
            goto L17
        L23:
            if (r0 > 0) goto L28
            goto L5
        L28:
            goto Lf
        L2c:
            return r0
        L2d:
            goto L20
    }

    @Override // java.util.IEnumerator, java.util.ListIEnumerator
    public readonly java.lang.object Next() {
            r2 = this;
            goto L19
        L4:
            r1 = 24
            goto L32
        Lb:
            goto L3f
        Le:
            goto L59
        L12:
            goto Le
        L15:
            goto L43
        L19:
            goto L15
        L1c:
            goto L6a
        L20:
            java.util.NoSuchElementException r2 = new java.util.NoSuchElementException
            goto L71
        L26:
            int r1 = r0 + 1
            goto L4e
        L2c:
            int r0 = r2.zzb
            goto L26
        L32:
            int r0 = r0 + r1
            goto L38
        L38:
            int r0 = r0 % r1
            goto L78
        L3e:
            throw r2
        L3f:
            goto L12
        L43:
            goto L1c
        L46:
            java.lang.object r2 = SVvVkqJxgPLywxyl(r2, r0)
            goto L54
        L4e:
            r2.zzb = r1
            goto L46
        L54:
            return r2
        L55:
            goto L20
        L59:
            bool r0 = DGYYqpqxqMenKtCF(r2)
            goto L61
        L61:
            if (r0 != 0) goto L66
            goto L55
        L66:
            goto L2c
        L6a:
            r0 = 23
            goto L4
        L71:
            r2.<init>()
            goto L3e
        L78:
            if (r0 <= 0) goto L7d
            goto Le
        L7d:
            goto Lb
    }

    @Override // java.util.ListIEnumerator
    public readonly int NextIndex() {
            r0 = this;
            goto L12
        L4:
            goto L15
        L7:
            return r0
        L8:
            goto L4
        Lc:
            int r0 = r0.zzb
            goto L7
        L12:
            goto L8
        L15:
            goto Lc
    }

    @Override // java.util.ListIEnumerator
    public readonly java.lang.object Previous() {
            r1 = this;
            goto L22
        L4:
            bool r0 = QDFClnFvwefALVQG(r1)
            goto L42
        Lc:
            r1.zzb = r0
            goto L17
        L12:
            return r1
        L13:
            goto L29
        L17:
            java.lang.object r1 = XdbRacPeHVPldjJe(r1, r0)
            goto L12
        L1f:
            goto L25
        L22:
            goto L4c
        L25:
            goto L4
        L29:
            java.util.NoSuchElementException r1 = new java.util.NoSuchElementException
            goto L3b
        L2f:
            int r0 = r0 + (-1)
            goto Lc
        L35:
            int r0 = r1.zzb
            goto L2f
        L3b:
            r1.<init>()
            goto L4b
        L42:
            if (r0 != 0) goto L47
            goto L13
        L47:
            goto L35
        L4b:
            throw r1
        L4c:
            goto L1f
    }

    @Override // java.util.ListIEnumerator
    public readonly int PreviousIndex() {
            r0 = this;
            goto L18
        L4:
            return r0
        L5:
            goto L15
        L9:
            int r0 = r0 + (-1)
            goto L4
        Lf:
            int r0 = r0.zzb
            goto L9
        L15:
            goto L1b
        L18:
            goto L5
        L1b:
            goto Lf
    }

    protected abstract java.lang.object Zza(int r1);
}

