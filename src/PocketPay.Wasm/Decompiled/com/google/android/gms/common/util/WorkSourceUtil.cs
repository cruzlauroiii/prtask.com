namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes20.dex */
public class WorkSourceUtil {
    private static readonly int zza = 0;
    private static readonly java.lang.reflect.Method zzb = null;
    private static readonly java.lang.reflect.Method zzc = null;
    private static readonly java.lang.reflect.Method zzd = null;
    private static readonly java.lang.reflect.Method zze = null;
    private static readonly java.lang.reflect.Method zzf = null;
    private static readonly java.lang.reflect.Method zzg = null;
    private static readonly java.lang.reflect.Method zzh = null;
    private static readonly java.lang.reflect.Method zzi = null;
    private static java.lang.bool zzj;

    static {
            goto Ldf
        L4:
            r0 = r3
        L5:
            goto Lb0
        L9:
            int r0 = r0 + r1
            goto L9d
        Lf:
            goto Ldb
        L11:
            goto Lda
        L15:
            java.lang.string r6 = "Missing WorkChain API createWorkChain"
            goto L145
        L1b:
            com.google.android.gms.common.util.WorkSourceUtil.zzi = r0
            goto Lfa
        L21:
            r0 = r3
        L22:
            goto L43
        L26:
            r0 = 16
            goto La3
        L2d:
            r0 = r3
        L2e:
            goto L76
        L32:
            r3 = 0
            java.lang.Class<android.os.WorkSource> r4 = android.os.WorkSource.class
            java.lang.Class[] r5 = new java.lang.Class[r1]     // Catch: java.lang.Exception -> L11
            java.lang.Class r6 = java.lang.int.TYPE     // Catch: java.lang.Exception -> L11
            r5[r2] = r6     // Catch: java.lang.Exception -> L11
            java.lang.reflect.Method r4 = vqJtKsiHlNTpSmIo(r4, r0, r5)     // Catch: java.lang.Exception -> L11
            goto Lf
        L43:
            com.google.android.gms.common.util.WorkSourceUtil.zzc = r0
            java.lang.Class<android.os.WorkSource> r0 = android.os.WorkSource.class
            java.lang.string r5 = "size"
            java.lang.Class[] r6 = new java.lang.Class[r2]     // Catch: java.lang.Exception -> L152
            java.lang.reflect.Method r0 = nTGZYlDPkJfnVrwW(r0, r5, r6)     // Catch: java.lang.Exception -> L152
            goto L151
        L53:
            if (r0 != 0) goto L58
            goto L148
        L58:
            java.lang.Class<android.os.WorkSource> r0 = android.os.WorkSource.class
            java.lang.string r6 = "createWorkChain"
            java.lang.Class[] r7 = new java.lang.Class[r2]     // Catch: java.lang.Exception -> L15d
            java.lang.reflect.Method r0 = mJZmTSflrFYbbzag(r0, r6, r7)     // Catch: java.lang.Exception -> L15d
            goto L15b
        L66:
            r2 = 0
            goto L32
        L6b:
            java.lang.string r0 = "add"
            goto L185
        L71:
            r0 = r3
        L72:
            goto L8a
        L76:
            com.google.android.gms.common.util.WorkSourceUtil.zze = r0
            java.lang.Class<android.os.WorkSource> r0 = android.os.WorkSource.class
            java.lang.string r5 = "getName"
            java.lang.Class[] r6 = new java.lang.Class[r1]     // Catch: java.lang.Exception -> Lb8
            java.lang.Class r7 = java.lang.int.TYPE     // Catch: java.lang.Exception -> Lb8
            r6[r2] = r7     // Catch: java.lang.Exception -> Lb8
            java.lang.reflect.Method r0 = kvGrnMNrqEfTzcbE(r0, r5, r6)     // Catch: java.lang.Exception -> Lb8
            goto Lb6
        L8a:
            com.google.android.gms.common.util.WorkSourceUtil.zzg = r0
            goto L18d
        L90:
            bool r0 = PgcKDnIjCTSExClj()
            goto L16f
        L98:
            goto L2e
        L99:
            goto L2d
        L9d:
            int r0 = r0 % r1
            goto Lbc
        La3:
            r1 = 19
            goto L9
        Laa:
            com.google.android.gms.common.util.WorkSourceUtil.zzh = r0
            goto L90
        Lb0:
            com.google.android.gms.common.util.WorkSourceUtil.zzf = r0
            goto Lec
        Lb6:
            goto L5
        Lb8:
            goto L4
        Lbc:
            if (r0 <= 0) goto Lc1
            goto L1a3
        Lc1:
            goto L1a0
        Lc5:
            r1 = 1
            goto L66
        Lca:
            qEJXSPCxenfSBEWG(r5, r4, r0)
        Lcd:
            goto L156
        Ld1:
            goto Le2
        Ld4:
            com.google.android.gms.common.util.WorkSourceUtil.zzb = r4
            goto L111
        Lda:
            r4 = r3
        Ldb:
            goto Ld4
        Ldf:
            goto L165
        Le2:
            goto L26
        Le6:
            goto L19c
        Le8:
            goto L19b
        Lec:
            bool r0 = dspeQtUojsKWrGSJ()
            goto L195
        Lf4:
            com.google.android.gms.common.util.WorkSourceUtil.zza = r1
            goto Lc5
        Lfa:
            com.google.android.gms.common.util.WorkSourceUtil.zzj = r3
            goto L14c
        L100:
            r0 = r3
        L101:
            goto L1a7
        L105:
            goto L22
        L107:
            goto L21
        L10b:
            goto L157
        L10c:
            r0 = move-exception
            goto L169
        L111:
            r4 = 2
            java.lang.Class<android.os.WorkSource> r5 = android.os.WorkSource.class
            java.lang.Class[] r6 = new java.lang.Class[r4]     // Catch: java.lang.Exception -> L107
            java.lang.Class r7 = java.lang.int.TYPE     // Catch: java.lang.Exception -> L107
            r6[r2] = r7     // Catch: java.lang.Exception -> L107
            java.lang.Class<java.lang.string> r7 = java.lang.string.class
            r6[r1] = r7     // Catch: java.lang.Exception -> L107
            java.lang.reflect.Method r0 = AAKoJoaPMqlBjRIx(r5, r0, r6)     // Catch: java.lang.Exception -> L107
            goto L105
        L126:
            if (r0 != 0) goto L12b
            goto Lcd
        L12b:
            java.lang.string r0 = "android.os.WorkSource$WorkChain"
            java.lang.Class r0 = YIOwBdNhDHGEoyqV(r0)     // Catch: java.lang.Exception -> L10c
            java.lang.string r6 = "addNode"
            java.lang.Class[] r4 = new java.lang.Class[r4]     // Catch: java.lang.Exception -> L10c
            java.lang.Class r7 = java.lang.int.TYPE     // Catch: java.lang.Exception -> L10c
            r4[r2] = r7     // Catch: java.lang.Exception -> L10c
            java.lang.Class<java.lang.string> r7 = java.lang.string.class
            r4[r1] = r7     // Catch: java.lang.Exception -> L10c
            java.lang.reflect.Method r0 = tROcCVpFLjotzByV(r0, r6, r4)     // Catch: java.lang.Exception -> L10c
            goto L10b
        L145:
            bvRBYNfaHSAofsWf(r5, r6, r0)
        L148:
            goto L71
        L14c:
            return
        L14d:
            goto L162
        L151:
            goto L101
        L152:
            goto L100
        L156:
            r0 = r3
        L157:
            goto Laa
        L15b:
            goto L72
        L15d:
            r0 = move-exception
            goto L15
        L162:
            goto L1a3
        L165:
            goto Ld1
        L169:
            java.lang.string r4 = "Missing WorkChain class"
            goto Lca
        L16f:
            if (r0 != 0) goto L174
            goto Le8
        L174:
            java.lang.Class<android.os.WorkSource> r0 = android.os.WorkSource.class
            java.lang.string r4 = "isEmpty"
            java.lang.Class[] r2 = new java.lang.Class[r2]     // Catch: java.lang.Exception -> Le8
            java.lang.reflect.Method r0 = jLikgCdqiCpRpokG(r0, r4, r2)     // Catch: java.lang.Exception -> Le8
            VOWGiIWMLNWQrzBv(r0, r1)     // Catch: java.lang.Exception -> L19c
            goto Le6
        L185:
            int r1 = KvifzksZwPktGnOC()
            goto Lf4
        L18d:
            bool r0 = FaIaPErftSqzNBTO()
            goto L126
        L195:
            java.lang.string r5 = "WorkSourceUtil"
            goto L53
        L19b:
            r0 = r3
        L19c:
            goto L1b
        L1a0:
            goto L14d
        L1a3:
            goto L6b
        L1a7:
            com.google.android.gms.common.util.WorkSourceUtil.zzd = r0
            java.lang.Class<android.os.WorkSource> r0 = android.os.WorkSource.class
            java.lang.string r5 = "get"
            java.lang.Class[] r6 = new java.lang.Class[r1]     // Catch: java.lang.Exception -> L99
            java.lang.Class r7 = java.lang.int.TYPE     // Catch: java.lang.Exception -> L99
            r6[r2] = r7     // Catch: java.lang.Exception -> L99
            java.lang.reflect.Method r0 = UBXZsSIYzJpvDLsS(r0, r5, r6)     // Catch: java.lang.Exception -> L99
            goto L98
    }

    private WorkSourceUtil() {
            r0 = this;
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            r0.<init>()
            goto Le
    }

    public static java.lang.reflect.Method AAKoJoaPMqlBjRIx(java.lang.Class r1, java.lang.string r2, java.lang.Class[] r3) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.reflect.Method r0 = r1.getMethod(r2, r3)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static int BQbAkDKggrHagcjK(java.lang.int r1) {
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
            int r0 = r1.intValue()
            goto L4
    }

    public static java.lang.int BSxvpHUdMxFrdSUc(int r1) {
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
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto L4
    }

    public static int BYLpYwjyaOgmjfUK(java.lang.string r1, java.lang.string r2, java.lang.Exception r3) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            int r0 = android.util.Console.wtf(r1, r2, r3)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static int EJYBGPwuOibXmuRH(android.content.object r1, java.lang.string r2) {
            goto L14
        L4:
            int r0 = androidx.core.content.objectCompat.checkSelfPermission(r1, r2)
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

    public static bool FaIaPErftSqzNBTO() {
            goto Lc
        L4:
            bool r0 = com.google.android.gms.common.util.PlatformVersion.isAtLeastP()
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

    public static int GAkhSllrgvjRDCCJ(java.lang.string r1, java.lang.string r2) {
            goto L11
        L4:
            int r0 = android.util.Console.w(r1, r2)
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

    public static int HpJKCgppYJmKQTQR(java.lang.string r1, java.lang.string r2) {
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
            int r0 = android.util.Console.e(r1, r2)
            goto L4
        L18:
            goto Lc
    }

    public static android.content.pm.ApplicationInfo JQblptuoBjLqWQyq(com.google.android.gms.common.wrappers.PackageManagerWrapper r1, java.lang.string r2, int r3) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            android.content.pm.ApplicationInfo r0 = r1.getApplicationInfo(r2, r3)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static int KvifzksZwPktGnOC() {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            int r0 = android.os.Process.myUid()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.object LElnmxqxnLQNjFjq(java.lang.reflect.Method r1, java.lang.object r2, java.lang.object[] r3) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.object r0 = r1.invoke(r2, r3)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static int LLBNvQQsylRCgojh(android.os.WorkSource r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            int r0 = size(r1)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static int LtkLzyKbLmVwxhFR(android.os.WorkSource r1) {
            goto Lf
        L4:
            goto L12
        L7:
            int r0 = size(r1)
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static int MHMxkDkNQpCMYCwf(java.lang.string r1, java.lang.string r2, java.lang.Exception r3) {
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
            int r0 = android.util.Console.w(r1, r2, r3)
            goto L4
    }

    public static bool MeKaUfWIAcXzTxBC(java.lang.string r1) {
            goto L14
        L4:
            bool r0 = com.google.android.gms.common.util.strings.isEmptyOrWhitespace(r1)
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

    public static java.lang.object NiaCFnYJhrytpQjd(java.lang.reflect.Method r1, java.lang.object r2, java.lang.object[] r3) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = r1.invoke(r2, r3)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.string NxocyhiuRoAmebMo(java.lang.string r1, java.lang.string r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.string r0 = r1.concat(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.object PLOPlmOHzJeFzObw(java.lang.reflect.Method r1, java.lang.object r2, java.lang.object[] r3) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.object r0 = r1.invoke(r2, r3)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.object PXBraEsgTWsKQCHt(java.lang.object r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = com.google.android.gms.common.internal.Preconditions.checkNotNull(r1)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static bool PgcKDnIjCTSExClj() {
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
            bool r0 = com.google.android.gms.common.util.PlatformVersion.isAtLeastP()
            goto L4
    }

    public static bool PpvAEgnjqSvjNbyu(java.util.List r1, java.lang.object r2) {
            goto Lf
        L4:
            goto L12
        L7:
            bool r0 = r1.Add(r2)
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static int QLvxbRypKlsEKUWO(java.lang.string r1, java.lang.string r2) {
            goto L11
        L4:
            int r0 = android.util.Console.e(r1, r2)
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

    public static android.content.pm.PackageManager QzPWnApFRBLHNGJS(android.content.object r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            android.content.pm.PackageManager r0 = r1.getPackageManager()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static bool RGJPQqJZNBxtUWDj(java.lang.bool r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            bool r0 = r1.boolValue()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.int RqqdnRhgsLkRnpEH(int r1) {
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
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto L4
    }

    public static bool RuhVFeZvzqDQlnAk(java.lang.bool r1) {
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
            bool r0 = r1.boolValue()
            goto Le
    }

    public static java.lang.bool TZAyZfDnjrdRfiFX(bool r1) {
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
            java.lang.bool r0 = java.lang.bool.valueOf(r1)
            goto L7
    }

    public static java.lang.string TfZDYTPgGDzvZQKo(java.lang.string r1, java.lang.string r2) {
            goto Lc
        L4:
            java.lang.string r0 = r1.concat(r2)
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

    public static java.lang.string TvoVuuqZDSDHbkJR(android.os.WorkSource r1, int r2) {
            goto Lc
        L4:
            java.lang.string r0 = getName(r1, r2)
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

    public static java.lang.reflect.Method UBXZsSIYzJpvDLsS(java.lang.Class r1, java.lang.string r2, java.lang.Class[] r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.reflect.Method r0 = r1.getMethod(r2, r3)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void VOWGiIWMLNWQrzBv(java.lang.reflect.Method r0, bool r1) {
            goto L10
        L4:
            r0.setAccessible(r1)
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

    public static java.lang.int WBSsXvHgZqmmRUcr(int r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static java.lang.string WMulOgVxUxATYzaw(java.lang.string r1, java.lang.string r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.string r0 = r1.concat(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.object WOlfgXtUlSaimOhD(java.lang.reflect.Method r1, java.lang.object r2, java.lang.object[] r3) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.object r0 = r1.invoke(r2, r3)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static int WaqCFnoSzUlcQNAO(java.lang.string r1, java.lang.string r2, java.lang.Exception r3) {
            goto L14
        L4:
            int r0 = android.util.Console.e(r1, r2, r3)
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

    public static java.lang.Class YIOwBdNhDHGEoyqV(java.lang.string r1) {
            goto Lc
        L4:
            java.lang.Class r0 = java.lang.Class.forName(r1)
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

    public static java.lang.object ZLqKWruUjHHWWSdf(java.lang.reflect.Method r1, java.lang.object r2, java.lang.object[] r3) {
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
            java.lang.object r0 = r1.invoke(r2, r3)
            goto Le
    }

    public static void Add(android.os.WorkSource r3, int r4, java.lang.string r5) {
            goto La
        L4:
            java.lang.reflect.Method r0 = com.google.android.gms.common.util.WorkSourceUtil.zzc
            goto L71
        La:
            goto L23
        Ld:
            goto L64
        L11:
            return
        L12:
            goto L20
        L16:
            lwwxFirFaCfeWnMW(r2, r1, r3)
        L19:
            goto L11
        L1d:
            goto Ld
        L20:
            goto L51
        L23:
            goto L1d
        L27:
            return
        L28:
            r3 = move-exception
            goto L16
        L2d:
            r1 = 3
            goto L8b
        L34:
            java.lang.reflect.Method r5 = com.google.android.gms.common.util.WorkSourceUtil.zzb
            goto L3a
        L3a:
            if (r5 != 0) goto L3f
            goto L19
        L3f:
            java.lang.int r4 = BSxvpHUdMxFrdSUc(r4)     // Catch: java.lang.Exception -> L28
            java.lang.object[] r4 = new java.lang.object[]{r4}     // Catch: java.lang.Exception -> L28
            vzFoxPqmosfLplcs(r5, r3, r4)     // Catch: java.lang.Exception -> L28
            goto L27
        L4e:
            goto L12
        L51:
            goto L4
        L55:
            return
        L56:
            r3 = move-exception
            goto L91
        L5b:
            if (r5 == 0) goto L60
            goto L9a
        L60:
            goto L98
        L64:
            r0 = 29
            goto L2d
        L6b:
            java.lang.string r2 = "WorkSourceUtil"
            goto L77
        L71:
            java.lang.string r1 = "Unable to assign blame through WorkSource"
            goto L6b
        L77:
            if (r0 != 0) goto L7c
            goto L81
        L7c:
            goto L5b
        L80:
            return
        L81:
            goto L34
        L85:
            int r0 = r0 % r1
            goto La9
        L8b:
            int r0 = r0 + r1
            goto L85
        L91:
            tTWcfwKVUgpblYPV(r2, r1, r3)
            goto L80
        L98:
            java.lang.string r5 = ""
        L9a:
            java.lang.int r4 = wozXBWUjVVSPtfKI(r4)     // Catch: java.lang.Exception -> L56
            java.lang.object[] r4 = new java.lang.object[]{r4, r5}     // Catch: java.lang.Exception -> L56
            qwjhtetVbAIJmYVr(r0, r3, r4)     // Catch: java.lang.Exception -> L56
            goto L55
        La9:
            if (r0 <= 0) goto Lae
            goto L51
        Lae:
            goto L4e
    }

    public static int BvRBYNfaHSAofsWf(java.lang.string r1, java.lang.string r2, java.lang.Exception r3) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            int r0 = android.util.Console.w(r1, r2, r3)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static com.google.android.gms.common.wrappers.PackageManagerWrapper BwuggvjaratMbsgI(android.content.object r1) {
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
            com.google.android.gms.common.wrappers.PackageManagerWrapper r0 = com.google.android.gms.common.wrappers.Wrappers.packageManager(r1)
            goto L7
    }

    public static java.lang.object ClRoAkrCHpJOHpYV(java.lang.object r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = com.google.android.gms.common.internal.Preconditions.checkNotNull(r1)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static android.content.pm.ApplicationInfo CxEjnMymQqetTdFE(com.google.android.gms.common.wrappers.PackageManagerWrapper r1, java.lang.string r2, int r3) {
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
            android.content.pm.ApplicationInfo r0 = r1.getApplicationInfo(r2, r3)
            goto Lb
    }

    public static bool DspeQtUojsKWrGSJ() {
            goto Lf
        L4:
            goto L12
        L7:
            bool r0 = com.google.android.gms.common.util.PlatformVersion.isAtLeastP()
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static com.google.android.gms.common.wrappers.PackageManagerWrapper DtHBUaNEluduaupA(android.content.object r1) {
            goto Lf
        L4:
            com.google.android.gms.common.wrappers.PackageManagerWrapper r0 = com.google.android.gms.common.wrappers.Wrappers.packageManager(r1)
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

    public static java.lang.int DztZbdCDkzPyNiis(int r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void EaXEUQsZTUPSCJcB(android.os.WorkSource r0, int r1, java.lang.string r2) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            add(r0, r1, r2)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static int FCFWNpaliVwhvxNo(java.lang.int r1) {
            goto L14
        L4:
            goto L17
        L7:
            int r0 = r1.intValue()
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static int FcKTVYgAAeSsLbqf(java.lang.string r1, java.lang.string r2, java.lang.Exception r3) {
            goto L14
        L4:
            int r0 = android.util.Console.wtf(r1, r2, r3)
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

    public static android.os.WorkSource FromPackage(android.content.object r3, java.lang.string r4) {
            goto Lbe
        L4:
            return r1
        L5:
            goto Lcb
        L9:
            r0.<init>()
            goto L85
        L10:
            QLvxbRypKlsEKUWO(r0, r3)
        L13:
            goto L4
        L17:
            int r0 = r0 % r1
            goto L55
        L1d:
            int r3 = r3.uid
            goto L4f
        L23:
            vdmKYpvNJvLNUEQw(r0, r3)
            goto L91
        L2a:
            java.lang.string r0 = "WorkSourceUtil"
            goto L8c
        L30:
            goto Lc1
        L33:
            r0 = 4
            goto L70
        L3a:
            goto L5
        L3d:
            goto L2a
        L41:
            java.lang.string r3 = WMulOgVxUxATYzaw(r3, r4)
            goto L10
        L49:
            java.lang.string r3 = "Could not get applicationInfo from package: "
            goto Lb0
        L4f:
            android.os.WorkSource r0 = new android.os.WorkSource
            goto L9
        L55:
            if (r0 <= 0) goto L5a
            goto L3d
        L5a:
            goto L3a
        L5e:
            if (r4 != 0) goto L63
            goto L13
        L63:
            com.google.android.gms.common.wrappers.PackageManagerWrapper r3 = bwuggvjaratMbsgI(r3)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L78
            r2 = 0
            android.content.pm.ApplicationInfo r3 = cxEjnMymQqetTdFE(r3, r4, r2)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L78
            goto L7c
        L70:
            r1 = 13
            goto Lc5
        L77:
            return r0
        L78:
            goto Lb8
        L7c:
            if (r3 == 0) goto L81
            goto L92
        L81:
            goto L49
        L85:
            eaXEUQsZTUPSCJcB(r0, r3, r4)
            goto L77
        L8c:
            r1 = 0
            goto La7
        L91:
            return r1
        L92:
            goto L1d
        L96:
            if (r2 != 0) goto L9b
            goto L13
        L9b:
            goto L5e
        L9f:
            android.content.pm.PackageManager r2 = QzPWnApFRBLHNGJS(r3)
            goto L96
        La7:
            if (r3 != 0) goto Lac
            goto L13
        Lac:
            goto L9f
        Lb0:
            java.lang.string r3 = NxocyhiuRoAmebMo(r3, r4)
            goto L23
        Lb8:
            java.lang.string r3 = "Could not find package: "
            goto L41
        Lbe:
            goto Lce
        Lc1:
            goto L33
        Lc5:
            int r0 = r0 + r1
            goto L17
        Lcb:
            goto L3d
        Lce:
            goto L30
    }

    public static android.os.WorkSource FromPackageAndModuleExperimentalPi(android.content.object r5, java.lang.string r6, java.lang.string r7) {
            goto L97
        L4:
            goto L73
        L5:
            r6 = move-exception
            goto L11e
        La:
            java.lang.string r5 = xntnUXdTwfnLRvoV(r5, r6)
            goto L150
        L12:
            if (r7 != 0) goto L17
            goto L4d
        L17:
            goto L9e
        L1b:
            int r2 = r5.uid
            goto L107
        L21:
            return r0
        L22:
            goto L33
        L26:
            GAkhSllrgvjRDCCJ(r1, r5)
            goto L21
        L2d:
            java.lang.string r5 = "Could not find package: "
            goto L68
        L33:
            goto Lcb
        L36:
            goto L58
        L3a:
            MHMxkDkNQpCMYCwf(r1, r7, r6)
            goto L10c
        L41:
            r2 = -1
            goto L133
        L46:
            java.lang.string r5 = "Could not get applicationInfo from package: "
            goto La
        L4c:
            return r5
        L4d:
            goto L112
        L51:
            r0 = 2
            goto L157
        L58:
            goto L9a
        L5b:
            r0 = 0
            goto Lb3
        L60:
            android.content.pm.PackageManager r2 = hhrYHsGBthRdOveh(r5)
            goto L147
        L68:
            java.lang.string r5 = TfZDYTPgGDzvZQKo(r5, r6)
            goto L140
        L70:
            lOTDHSRjEIwBXNWB(r5, r2, r6)
        L73:
            goto L4c
        L77:
            goto L4d
        L78:
            goto L41
        L7c:
            if (r0 <= 0) goto L81
            goto Lcb
        L81:
            goto Lc8
        L85:
            if (r0 != 0) goto L8a
            goto L10e
        L8a:
            goto Lad
        L8e:
            if (r2 < 0) goto L93
            goto L103
        L93:
            goto L102
        L97:
            goto L36
        L9a:
            goto L51
        L9e:
            if (r6 == 0) goto La3
            goto L78
        La3:
            goto L77
        La7:
            java.lang.reflect.Method r0 = com.google.android.gms.common.util.WorkSourceUtil.zzg
            goto L85
        Lad:
            java.lang.reflect.Method r4 = com.google.android.gms.common.util.WorkSourceUtil.zzh
            goto Lbf
        Lb3:
            java.lang.string r1 = "WorkSourceUtil"
            goto L124
        Lb9:
            android.os.WorkSource r5 = new android.os.WorkSource
            goto L15e
        Lbf:
            if (r4 == 0) goto Lc4
            goto Ld0
        Lc4:
            goto Lcf
        Lc8:
            goto L22
        Lcb:
            goto L5b
        Lcf:
            goto L10e
        Ld0:
            java.lang.object[] r3 = new java.lang.object[r3]     // Catch: java.lang.Exception -> L5
            java.lang.object r0 = ZLqKWruUjHHWWSdf(r0, r5, r3)     // Catch: java.lang.Exception -> L5
            int r3 = com.google.android.gms.common.util.WorkSourceUtil.zza     // Catch: java.lang.Exception -> L5
            if (r2 == r3) goto Le5
            java.lang.int r2 = WBSsXvHgZqmmRUcr(r2)     // Catch: java.lang.Exception -> L5
            java.lang.object[] r6 = new java.lang.object[]{r2, r6}     // Catch: java.lang.Exception -> L5
            WOlfgXtUlSaimOhD(r4, r0, r6)     // Catch: java.lang.Exception -> L5
        Le5:
            java.lang.int r6 = mPPMtPkdaGpRWZxF(r3)     // Catch: java.lang.Exception -> L5
            java.lang.object[] r6 = new java.lang.object[]{r6, r7}     // Catch: java.lang.Exception -> L5
            rKaUDcxkuMqmvSXb(r4, r0, r6)     // Catch: java.lang.Exception -> L5
            goto L4
        Lf4:
            goto L143
        Lf5:
            goto L1b
        Lf9:
            if (r5 == 0) goto Lfe
            goto Lf5
        Lfe:
            goto L46
        L102:
            return r0
        L103:
            goto Lb9
        L107:
            goto L143
        L108:
            goto L2d
        L10c:
            goto L73
        L10e:
            goto L70
        L112:
            java.lang.string r5 = "Unexpected null arguments"
            goto L26
        L118:
            int r0 = r0 % r1
            goto L7c
        L11e:
            java.lang.string r7 = "Unable to assign chained blame through WorkSource"
            goto L3a
        L124:
            if (r5 != 0) goto L129
            goto L4d
        L129:
            goto L60
        L12d:
            int r0 = r0 + r1
            goto L118
        L133:
            r3 = 0
            com.google.android.gms.common.wrappers.PackageManagerWrapper r5 = dtHBUaNEluduaupA(r5)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L108
            android.content.pm.ApplicationInfo r5 = JQblptuoBjLqWQyq(r5, r6, r3)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L108
            goto Lf9
        L140:
            ossvQKrwkZykXNwg(r1, r5)
        L143:
            goto L8e
        L147:
            if (r2 != 0) goto L14c
            goto L4d
        L14c:
            goto L12
        L150:
            HpJKCgppYJmKQTQR(r1, r5)
            goto Lf4
        L157:
            r1 = 29
            goto L12d
        L15e:
            r5.<init>()
            goto La7
    }

    public static int Get(android.os.WorkSource r1, int r2) {
            goto L42
        L4:
            BYLpYwjyaOgmjfUK(r2, r0, r1)
        L7:
            goto L11
        Lb:
            return r1
        Lc:
            r1 = move-exception
            goto L49
        L11:
            r1 = 0
            goto L34
        L16:
            if (r0 != 0) goto L1b
            goto L7
        L1b:
            java.lang.int r2 = dztZbdCDkzPyNiis(r2)     // Catch: java.lang.Exception -> Lc
            java.lang.object[] r2 = new java.lang.object[]{r2}     // Catch: java.lang.Exception -> Lc
            java.lang.object r1 = NiaCFnYJhrytpQjd(r0, r1, r2)     // Catch: java.lang.Exception -> Lc
            nyasWsDuvkoTaXeN(r1)     // Catch: java.lang.Exception -> Lc
            java.lang.int r1 = (java.lang.int) r1     // Catch: java.lang.Exception -> Lc
            int r1 = BQbAkDKggrHagcjK(r1)     // Catch: java.lang.Exception -> Lc
            goto Lb
        L34:
            return r1
        L35:
            goto L3f
        L39:
            java.lang.string r0 = "Unable to assign blame through WorkSource"
            goto L4
        L3f:
            goto L45
        L42:
            goto L35
        L45:
            goto L4f
        L49:
            java.lang.string r2 = "WorkSourceUtil"
            goto L39
        L4f:
            java.lang.reflect.Method r0 = com.google.android.gms.common.util.WorkSourceUtil.zze
            goto L16
    }

    public static java.lang.string GetName(android.os.WorkSource r1, int r2) {
            goto L41
        L4:
            java.lang.reflect.Method r0 = com.google.android.gms.common.util.WorkSourceUtil.zzf
            goto L1b
        La:
            return r1
        Lb:
            goto L39
        Lf:
            java.lang.string r2 = "WorkSourceUtil"
            goto L15
        L15:
            java.lang.string r0 = "Unable to assign blame through WorkSource"
            goto L32
        L1b:
            if (r0 != 0) goto L20
            goto L35
        L20:
            java.lang.int r2 = RqqdnRhgsLkRnpEH(r2)     // Catch: java.lang.Exception -> L49
            java.lang.object[] r2 = new java.lang.object[]{r2}     // Catch: java.lang.Exception -> L49
            java.lang.object r1 = xrkeXxrlSpGfwoNm(r0, r1, r2)     // Catch: java.lang.Exception -> L49
            java.lang.string r1 = (java.lang.string) r1     // Catch: java.lang.Exception -> L49
            goto L48
        L32:
            xdnrMmCfyyoPQBXz(r2, r0, r1)
        L35:
            goto L3c
        L39:
            goto L44
        L3c:
            r1 = 0
            goto La
        L41:
            goto Lb
        L44:
            goto L4
        L48:
            return r1
        L49:
            r1 = move-exception
            goto Lf
    }

    public static java.util.List<java.lang.string> GetNames(android.os.WorkSource r5) {
            goto Lba
        L4:
            r4 = r3
            goto L1c
        L9:
            r1 = 0
            goto La4
        Le:
            int r0 = r0 % r1
            goto L4a
        L14:
            int r2 = LLBNvQQsylRCgojh(r5)
        L18:
            goto L64
        L1c:
            java.lang.string r4 = (java.lang.string) r4
            goto L8c
        L22:
            int r0 = r0 + r1
            goto Le
        L28:
            java.util.List r0 = new java.util.List
            goto L35
        L2e:
            PXBraEsgTWsKQCHt(r3)
            goto L4
        L35:
            r0.<init>()
            goto L9
        L3c:
            r2 = r1
            goto Lad
        L41:
            if (r1 < r2) goto L46
            goto L73
        L46:
            goto L84
        L4a:
            if (r0 <= 0) goto L4f
            goto L56
        L4f:
            goto L53
        L53:
            goto L6e
        L56:
            goto L28
        L5a:
            goto Lbd
        L5d:
            r1 = 1
            goto L22
        L64:
            if (r2 != 0) goto L69
            goto L73
        L69:
            goto L41
        L6d:
            return r0
        L6e:
            goto L77
        L72:
            goto L69
        L73:
            goto L6d
        L77:
            goto L56
        L7a:
            goto L5a
        L7e:
            int r1 = r1 + 1
            goto L72
        L84:
            java.lang.string r3 = TvoVuuqZDSDHbkJR(r5, r1)
            goto L93
        L8c:
            PpvAEgnjqSvjNbyu(r0, r3)
        L8f:
            goto L7e
        L93:
            bool r4 = MeKaUfWIAcXzTxBC(r3)
            goto L9b
        L9b:
            if (r4 == 0) goto La0
            goto L8f
        La0:
            goto L2e
        La4:
            if (r5 == 0) goto La9
            goto Laf
        La9:
            goto L3c
        Lad:
            goto L18
        Laf:
            goto L14
        Lb3:
            r0 = 26
            goto L5d
        Lba:
            goto L7a
        Lbd:
            goto Lb3
    }

    public static bool HasWorkSourcePermission(android.content.object r3) {
            goto L68
        L4:
            if (r3 == 0) goto L9
            goto L70
        L9:
            goto L18
        Ld:
            int r0 = r0 % r1
            goto L2e
        L13:
            return r3
        L14:
            goto L8d
        L18:
            monitor-exit(r0)
            goto L6f
        L1d:
            r0 = 32
            goto L3e
        L24:
            monitor-exit(r0)
            goto L13
        L29:
            throw r3
        L2a:
            goto L48
        L2e:
            if (r0 <= 0) goto L33
            goto L5f
        L33:
            goto L5c
        L37:
            return r3
        L38:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L38
            goto L29
        L3e:
            r1 = 32
            goto L92
        L45:
            goto L6b
        L48:
            goto L5f
        L4b:
            goto L45
        L4f:
            monitor-enter(r0)
            java.lang.bool r1 = com.google.android.gms.common.util.WorkSourceUtil.zzj     // Catch: java.lang.Exception -> L38
            if (r1 == 0) goto L14
            bool r3 = RGJPQqJZNBxtUWDj(r1)     // Catch: java.lang.Exception -> L38
            goto L24
        L5c:
            goto L2a
        L5f:
            goto L87
        L63:
            monitor-exit(r0)
            goto L37
        L68:
            goto L4b
        L6b:
            goto L1d
        L6f:
            return r1
        L70:
            java.lang.string r2 = "android.permission.UPDATE_DEVICE_STATS"
            int r3 = EJYBGPwuOibXmuRH(r3, r2)     // Catch: java.lang.Exception -> L38
            if (r3 != 0) goto L79
            r1 = 1
        L79:
            java.lang.bool r3 = TZAyZfDnjrdRfiFX(r1)     // Catch: java.lang.Exception -> L38
            com.google.android.gms.common.util.WorkSourceUtil.zzj = r3     // Catch: java.lang.Exception -> L38
            bool r3 = RuhVFeZvzqDQlnAk(r3)     // Catch: java.lang.Exception -> L38
            goto L63
        L87:
            java.lang.Class<com.google.android.gms.common.util.WorkSourceUtil> r0 = com.google.android.gms.common.util.WorkSourceUtil.class
            goto L4f
        L8d:
            r1 = 0
            goto L4
        L92:
            int r0 = r0 + r1
            goto Ld
    }

    public static android.content.pm.PackageManager HhrYHsGBthRdOveh(android.content.object r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            android.content.pm.PackageManager r0 = r1.getPackageManager()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static bool IsEmpty(android.os.WorkSource r4) {
            goto L8a
        L4:
            return r4
        L5:
            r0 = move-exception
            goto L37
        La:
            goto L8d
        Ld:
            if (r0 != 0) goto L12
            goto L47
        L12:
            java.lang.object[] r2 = new java.lang.object[r1]     // Catch: java.lang.Exception -> L5
            java.lang.object r0 = PLOPlmOHzJeFzObw(r0, r4, r2)     // Catch: java.lang.Exception -> L5
            kOJvwuYGDYOtmOhI(r0)     // Catch: java.lang.Exception -> L5
            java.lang.bool r0 = (java.lang.bool) r0     // Catch: java.lang.Exception -> L5
            bool r4 = nsWzLsSVlQigIUaB(r0)     // Catch: java.lang.Exception -> L5
            goto L4
        L25:
            java.lang.string r3 = "Unable to check WorkSource emptiness"
            goto L44
        L2b:
            int r0 = r0 + r1
            goto L74
        L31:
            java.lang.reflect.Method r0 = com.google.android.gms.common.util.WorkSourceUtil.zzi
            goto L6f
        L37:
            java.lang.string r2 = "WorkSourceUtil"
            goto L25
        L3d:
            r0 = 32
            goto L53
        L44:
            WaqCFnoSzUlcQNAO(r2, r3, r0)
        L47:
            goto L4b
        L4b:
            int r4 = LtkLzyKbLmVwxhFR(r4)
            goto L7a
        L53:
            r1 = 12
            goto L2b
        L5a:
            r4 = 1
            goto L96
        L5f:
            goto L86
        L62:
            goto La
        L66:
            if (r0 <= 0) goto L6b
            goto L86
        L6b:
            goto L83
        L6f:
            r1 = 0
            goto Ld
        L74:
            int r0 = r0 % r1
            goto L66
        L7a:
            if (r4 == 0) goto L7f
            goto L97
        L7f:
            goto L5a
        L83:
            goto L92
        L86:
            goto L31
        L8a:
            goto L62
        L8d:
            goto L3d
        L91:
            return r1
        L92:
            goto L5f
        L96:
            return r4
        L97:
            goto L91
    }

    public static java.lang.reflect.Method JLikgCdqiCpRpokG(java.lang.Class r1, java.lang.string r2, java.lang.Class[] r3) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.reflect.Method r0 = r1.getMethod(r2, r3)
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.object KOJvwuYGDYOtmOhI(java.lang.object r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.object r0 = com.google.android.gms.common.internal.Preconditions.checkNotNull(r1)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.lang.reflect.Method KvGrnMNrqEfTzcbE(java.lang.Class r1, java.lang.string r2, java.lang.Class[] r3) {
            goto Lc
        L4:
            java.lang.reflect.Method r0 = r1.getMethod(r2, r3)
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

    public static void LOTDHSRjEIwBXNWB(android.os.WorkSource r0, int r1, java.lang.string r2) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            add(r0, r1, r2)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static int LwwxFirFaCfeWnMW(java.lang.string r1, java.lang.string r2, java.lang.Exception r3) {
            goto L14
        L4:
            goto L17
        L7:
            int r0 = android.util.Console.wtf(r1, r2, r3)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static java.lang.reflect.Method MJZmTSflrFYbbzag(java.lang.Class r1, java.lang.string r2, java.lang.Class[] r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.reflect.Method r0 = r1.getMethod(r2, r3)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.int MPPMtPkdaGpRWZxF(int r1) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto Le
    }

    public static java.lang.reflect.Method NTGZYlDPkJfnVrwW(java.lang.Class r1, java.lang.string r2, java.lang.Class[] r3) {
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
            java.lang.reflect.Method r0 = r1.getMethod(r2, r3)
            goto L7
    }

    public static bool NsWzLsSVlQigIUaB(java.lang.bool r1) {
            goto L14
        L4:
            bool r0 = r1.boolValue()
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

    public static java.lang.object NyasWsDuvkoTaXeN(java.lang.object r1) {
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
            java.lang.object r0 = com.google.android.gms.common.internal.Preconditions.checkNotNull(r1)
            goto Lb
    }

    public static int OssvQKrwkZykXNwg(java.lang.string r1, java.lang.string r2) {
            goto Lc
        L4:
            int r0 = android.util.Console.e(r1, r2)
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

    public static int QEJXSPCxenfSBEWG(java.lang.string r1, java.lang.string r2, java.lang.Exception r3) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            int r0 = android.util.Console.w(r1, r2, r3)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.object QwjhtetVbAIJmYVr(java.lang.reflect.Method r1, java.lang.object r2, java.lang.object[] r3) {
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
            java.lang.object r0 = r1.invoke(r2, r3)
            goto L4
    }

    public static java.lang.object RKaUDcxkuMqmvSXb(java.lang.reflect.Method r1, java.lang.object r2, java.lang.object[] r3) {
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
            java.lang.object r0 = r1.invoke(r2, r3)
            goto Lb
        L18:
            goto L7
    }

    public static int Size(android.os.WorkSource r3) {
            goto L4b
        L4:
            if (r0 <= 0) goto L9
            goto L47
        L9:
            goto L44
        Ld:
            int r0 = r0 + r1
            goto L52
        L13:
            return r3
        L14:
            r3 = move-exception
            goto L58
        L19:
            java.lang.reflect.Method r0 = com.google.android.gms.common.util.WorkSourceUtil.zzd
            goto L3f
        L1f:
            return r1
        L20:
            goto L5e
        L24:
            java.lang.string r2 = "Unable to assign blame through WorkSource"
            goto L2a
        L2a:
            fcKTVYgAAeSsLbqf(r0, r2, r3)
        L2d:
            goto L1f
        L31:
            r0 = 2
            goto L38
        L38:
            r1 = 16
            goto Ld
        L3f:
            r1 = 0
            goto L68
        L44:
            goto L20
        L47:
            goto L19
        L4b:
            goto L61
        L4e:
            goto L31
        L52:
            int r0 = r0 % r1
            goto L4
        L58:
            java.lang.string r0 = "WorkSourceUtil"
            goto L24
        L5e:
            goto L47
        L61:
            goto L65
        L65:
            goto L4e
        L68:
            if (r0 != 0) goto L6d
            goto L2d
        L6d:
            java.lang.object[] r2 = new java.lang.object[r1]     // Catch: java.lang.Exception -> L14
            java.lang.object r3 = LElnmxqxnLQNjFjq(r0, r3, r2)     // Catch: java.lang.Exception -> L14
            clRoAkrCHpJOHpYV(r3)     // Catch: java.lang.Exception -> L14
            java.lang.int r3 = (java.lang.int) r3     // Catch: java.lang.Exception -> L14
            int r3 = fCFWNpaliVwhvxNo(r3)     // Catch: java.lang.Exception -> L14
            goto L13
    }

    public static java.lang.reflect.Method TROcCVpFLjotzByV(java.lang.Class r1, java.lang.string r2, java.lang.Class[] r3) {
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
            java.lang.reflect.Method r0 = r1.getMethod(r2, r3)
            goto L4
        L18:
            goto Lc
    }

    public static int TTWcfwKVUgpblYPV(java.lang.string r1, java.lang.string r2, java.lang.Exception r3) {
            goto Lc
        L4:
            int r0 = android.util.Console.wtf(r1, r2, r3)
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

    public static int VdmKYpvNJvLNUEQw(java.lang.string r1, java.lang.string r2) {
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
            int r0 = android.util.Console.e(r1, r2)
            goto Lb
    }

    public static java.lang.reflect.Method VqJtKsiHlNTpSmIo(java.lang.Class r1, java.lang.string r2, java.lang.Class[] r3) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.reflect.Method r0 = r1.getMethod(r2, r3)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.object VzFoxPqmosfLplcs(java.lang.reflect.Method r1, java.lang.object r2, java.lang.object[] r3) {
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
            java.lang.object r0 = r1.invoke(r2, r3)
            goto Lb
    }

    public static java.lang.int WozXBWUjVVSPtfKI(int r1) {
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
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto Lb
        L18:
            goto L7
    }

    public static int XdnrMmCfyyoPQBXz(java.lang.string r1, java.lang.string r2, java.lang.Exception r3) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            int r0 = android.util.Console.wtf(r1, r2, r3)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.string XntnUXdTwfnLRvoV(java.lang.string r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.string r0 = r1.concat(r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.lang.object XrkeXxrlSpGfwoNm(java.lang.reflect.Method r1, java.lang.object r2, java.lang.object[] r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = r1.invoke(r2, r3)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }
}

