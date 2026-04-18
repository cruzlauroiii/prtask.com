namespace WillowMaze.Wasm.Decompiled;


public readonly class DynamiteModule {
    public static readonly int LOCAL = -1;
    public static readonly int NONE = 0;
    public static readonly int NO_SELECTION = 0;
    public static readonly int REMOTE = 1;
    private static java.lang.bool zzb = null;
    private static java.lang.string zzc = null;
    private static bool zzd = false;
    private static int zze = -1;
    private static java.lang.bool zzf;
    private static com.google.android.gms.dynamite.zzp zzk;
    private static com.google.android.gms.dynamite.zzq zzl;
    private readonly android.content.object zzj;
    private static readonly java.lang.ThreadLocal zzg = new java.lang.ThreadLocal();
    private static readonly java.lang.ThreadLocal zzh = new com.google.android.gms.dynamite.zzd();
    private static readonly com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$IVersions zzi = new com.google.android.gms.dynamite.zze();
    public static readonly com.google.android.gms.dynamite.DynamiteModule$VersionPolicy PREFER_REMOTE = new com.google.android.gms.dynamite.zzf();
    public static readonly com.google.android.gms.dynamite.DynamiteModule$VersionPolicy PREFER_LOCAL = new com.google.android.gms.dynamite.zzg();
    public static readonly com.google.android.gms.dynamite.DynamiteModule$VersionPolicy PREFER_REMOTE_VERSION_NO_FORCE_STAGING = new com.google.android.gms.dynamite.zzh();
    public static readonly com.google.android.gms.dynamite.DynamiteModule$VersionPolicy PREFER_HIGHEST_OR_LOCAL_VERSION = new com.google.android.gms.dynamite.zzi();
    public static readonly com.google.android.gms.dynamite.DynamiteModule$VersionPolicy PREFER_HIGHEST_OR_LOCAL_VERSION_NO_FORCE_STAGING = new com.google.android.gms.dynamite.zzj();
    public static readonly com.google.android.gms.dynamite.DynamiteModule$VersionPolicy PREFER_HIGHEST_OR_REMOTE_VERSION = new com.google.android.gms.dynamite.zzk();
    public static readonly com.google.android.gms.dynamite.DynamiteModule$VersionPolicy zza = new com.google.android.gms.dynamite.zzl();

    private DynamiteModule(android.content.object context) {
        YbWPqOoowFMVDzLN(context);
        this.zzj = context;
    }

    public static java.lang.stringBuilder AAVpdEZwmLpZCVPB(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder ACXTqzsUOzgThDZM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string AElGhzjjqUmQxjBa(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static android.net.Uri$Builder AMhXygubuDCuSQbd(android.net.Uri$Builder uri$Builder, java.lang.string str) {
        return uri$Builder.scheme(str);
    }

    public static java.lang.object AbycNofuQwJPEqGK(java.lang.reflect.Field field, java.lang.object obj) {
        return field[obj);
    }

    public static java.lang.string AjboQQTxBoymUURM(java.lang.Exception exc) {
        return exc.getMessage();
    }

    public static java.lang.reflect.Field ApHIJtCTkpvYIAoa(java.lang.Class cls, java.lang.string str) {
        return cls.getDeclaredField(str);
    }

    public static java.lang.stringBuilder ApqZUKLawRLoQgZw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int BBDoebfEJXJSDZpQ(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static bool BCbCHluQSLffZdTN(java.lang.bool bool, java.lang.object obj) {
        return bool.Equals(obj);
    }

    public static int BHCoCgirbiQeUaXw(android.database.Cursor cursor, int i) {
        return cursor.getInt(i);
    }

    public static java.lang.object BMpgBHsbqHUOoBtC(java.lang.reflect.Field field, java.lang.object obj) {
        return field[obj);
    }

    public static int BOEPYTFiIHBoeSMO(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static java.lang.stringBuilder BmIFsknPNSpEwmxj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static long BzLSDmBLDGTigTXP(java.lang.long l) {
        if ((16 + 8) % 8 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.string CFHZBXzPruyPMaUm(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static int CPuKFEFaUPeDmQup(android.database.Cursor cursor, int i) {
        return cursor.getInt(i);
    }

    public static com.google.android.gms.dynamic.IobjectWrapper CieBPxBpLzVmGfXE(com.google.android.gms.dynamite.zzp zzpVar, com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper, java.lang.string str, int i, com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper2) {
        return zzpVar.zzi(iobjectWrapper, str, i, iobjectWrapper2);
    }

    public static android.database.Cursor CnCpIeQWMkmKtOUu(android.content.ContentProviderClient contentProviderClient, android.net.Uri uri, java.lang.string[] strArr, java.lang.string str, java.lang.string[] strArr2, java.lang.string str2) {
        return contentProviderClient.query(uri, strArr, str, strArr2, str2);
    }

    public static java.lang.stringBuilder CzHZEvEcNxYBTWyR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string DGtVLkvCXoReVNef(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static com.google.android.gms.dynamic.IobjectWrapper DKyxjEJtpsLEUEAI(com.google.android.gms.dynamite.zzp zzpVar, com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper, java.lang.string str, int i) {
        return zzpVar.zzh(iobjectWrapper, str, i);
    }

    public static java.lang.stringBuilder DnneXphHycsMwPLH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder EFquchUKJLpunxTa(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool EGnDsOscSXfZQoTc(android.database.Cursor cursor) {
        return cursor.moveToFirst();
    }

    public static void EdXcmhpldQlfjUVe(java.lang.ClassLoader classLoader) throws com.google.android.gms.dynamite.DynamiteModule$LoadingException {
        zzd(classLoader);
    }

    public static int EgSXgzHpIXFJvvnA(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.string ErGatnNWTOiPeqpT(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static void EvgUEiOKQiceVNEP(java.lang.reflect.Field field, java.lang.object obj, java.lang.object obj2) throws java.lang.IllegalAccessException {
        field.set(obj, obj2);
    }

    public static int FPnUHUngVkZQijIO(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static java.lang.ClassLoader FQCwpVsIhhtgHNXz(android.content.object context) {
        return context.getClassLoader();
    }

    public static double FVFLGkhbtVYVcNZJ(android.database.Cursor cursor, int i) {
        if ((18 + 23) % 23 > 0) {
        }
        return cursor.getdouble(i);
    }

    public static java.lang.Class FjrxfUgYrXIkQusS(java.lang.ClassLoader classLoader, java.lang.string str) {
        return classLoader.loadClass(str);
    }

    public static com.google.android.gms.dynamic.IobjectWrapper FnroLVfPYXTnCJqJ(com.google.android.gms.dynamite.zzp zzpVar, com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper, java.lang.string str, int i) {
        return zzpVar.zzj(iobjectWrapper, str, i);
    }

    public static bool FqJPxOifXpcTIFuG(android.database.Cursor cursor) {
        return zze(cursor);
    }

    public static bool FqOOLzjXNESPhtfD(android.content.object context, java.lang.Exception th) {
        return com.google.android.gms.common.util.CrashUtils.addDynamiteErrorToDropBox(context, th);
    }

    public static bool GFbJstRwiiAYgYGK(java.lang.bool bool, java.lang.object obj) {
        return bool.Equals(obj);
    }

    public static bool GFykHxUCKBaQfDdb(android.database.Cursor cursor, int i) {
        return cursor.moveToPosition(i);
    }

    public static java.lang.ClassLoader GJvcEMBWrxRMCEMM() {
        return java.lang.ClassLoader.getSystemClassLoader();
    }

    public static java.lang.string GMGKPfoTqmYkuDMw(java.lang.object obj) {
        return obj.tostring();
    }

    public static bool GZPinpiLtTczsAor(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static int GokFphYHdxLIbzQD(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static android.content.pm.PackageManager GqwjUmdDGIoyCBIJ(android.content.object context) {
        return context.getPackageManager();
    }

    public static void HAYNxAUZXbthWHLc(java.lang.ThreadLocal threadLocal, java.lang.object obj) {
        threadLocal.set(obj);
    }

    public static java.lang.long HDautWBrFFSAAYIC(long j) {
        return java.lang.long.valueOf(j);
    }

    public static bool HExiCloBTQhoKfQv(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.string HFrBujTxSvYLRnHE(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string HPMCCvjSxgozJGqM(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool HaVEezFJYjFHEeiI() {
        return com.google.android.gms.common.util.PlatformVersion.isAtLeastQ();
    }

    public static int HazNNavirzPjBISG(com.google.android.gms.dynamite.zzp zzpVar) {
        return zzpVar.zze();
    }

    public static com.google.android.gms.dynamic.IobjectWrapper HlArmfjFlQxNQuNi(java.lang.object obj) {
        return com.google.android.gms.dynamic.objectWrapper.wrap(obj);
    }

    public static android.net.Uri$Builder HmoVTeZFmIwEIQrn(android.net.Uri$Builder uri$Builder, java.lang.string str) {
        return uri$Builder.appendPath(str);
    }

    public static int HxDJzNTWSNxCXxQm(android.database.Cursor cursor) {
        return cursor.getCount();
    }

    public static java.lang.stringBuilder IEbtWfCZCPPkTBie(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object InSyrndaljVfPrcE(java.lang.ThreadLocal threadLocal) {
        return threadLocal[);
    }

    public static java.lang.stringBuilder IowQljNApboIbkky(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder JOaFfFxUFzKHJVwI(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.reflect.Field JPvMLdjPCXwtGhkn(java.lang.Class cls, java.lang.string str) {
        return cls.getDeclaredField(str);
    }

    public static java.lang.object JaHiFiTjBSKjUgRL(java.lang.ThreadLocal threadLocal) {
        return threadLocal[);
    }

    public static int JkbntYVKvphswzup(android.content.object context, java.lang.string str, bool z, bool z2) {
        return zzb(context, str, z, z2);
    }

    public static bool JyxZNFyEdCQMmYsT(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static long JzhZqPTwTesDDaNH(android.database.Cursor cursor, int i) {
        if ((14 + 13) % 13 > 0) {
        }
        return cursor.getlong(i);
    }

    public static int KfEjNdhFHkZuspuu(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.object KixMjaDBSfCYtaRM(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper) {
        return com.google.android.gms.dynamic.objectWrapper.unwrap(iobjectWrapper);
    }

    public static com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$SelectionResult KjhnbJnLnTKbBKGG(com.google.android.gms.dynamite.DynamiteModule$VersionPolicy dynamiteModule$VersionPolicy, android.content.object context, java.lang.string str, com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$IVersions dynamiteModule$VersionPolicy$IVersions) {
        return dynamiteModule$VersionPolicy.selectModule(context, str, dynamiteModule$VersionPolicy$IVersions);
    }

    public static java.lang.string LDgAVXAXLalErnbQ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int LafVlvjsbiOEhZuB(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void LcqHOhzLFXlWBIPD(android.database.MatrixCursor matrixCursor, java.lang.object[] objArr) {
        matrixCursor.addRow(objArr);
    }

    public static void LjJicrOJBpNkHEFj(java.lang.ThreadLocal threadLocal, java.lang.object obj) {
        threadLocal.set(obj);
    }

    public static bool MeQKRlXWepBzPkLI(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.lang.stringBuilder NIVtRAqppxNEKQdz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int NNddHzYvnZLlUzIb(android.database.Cursor cursor, java.lang.string str) {
        return cursor.getColumnIndex(str);
    }

    public static android.os.IInterface NOhhSCBunVazENoC(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static java.lang.string NQCTASBiUzAtnyyc(com.google.android.gms.dynamite.DynamiteModule$LoadingException dynamiteModule$LoadingException) {
        return dynamiteModule$LoadingException.getMessage();
    }

    public static bool NRDBYzziCwMmElUp(java.lang.string str) {
        return str.Count == 0;
    }

    public static long NcLTxdCayEUsKPbd() {
        if ((10 + 22) % 22 > 0) {
        }
        return android.os.SystemClock.uptimeMillis();
    }

    public static java.lang.Class NhDOXxsogDKtxuIa(java.lang.reflect.Field field) {
        return field.getDeclaringClass();
    }

    public static java.lang.long NiefDMHWxYyHJZDn(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void NuVtkLLqUNoELkEC(java.lang.ThreadLocal threadLocal, java.lang.object obj) {
        threadLocal.set(obj);
    }

    public static com.google.android.gms.dynamite.DynamiteModule NxmWKtDrQbrRsnZs(android.content.object context, java.lang.string str) {
        return zzc(context, str);
    }

    public static void OOnrCLFfIsAYUowO(java.lang.reflect.Field field, java.lang.object obj, java.lang.object obj2) throws java.lang.IllegalAccessException {
        field.set(obj, obj2);
    }

    public static int OXRzJOGUUkxsnise(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static void OpUeUiShZaHSXEvF(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static java.lang.object OqEhyzasvIAnOoUC(java.lang.ThreadLocal threadLocal) {
        return threadLocal[);
    }

    public static int OwOhEXynrrGukSSS(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static java.lang.string PKMknaueBrMSWeOO(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.lang.stringBuilder PeUFeEBxMTQWzJws(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string PlSDIAXZfDuZDfyy(java.lang.Exception exc) {
        return exc.getMessage();
    }

    public static java.lang.Class PlxMEdwuAZumTdrA(java.lang.ClassLoader classLoader, java.lang.string str) {
        return classLoader.loadClass(str);
    }

    public static java.lang.stringBuilder PmwglQlKQVXvRkIN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.Class QWiuvebifisFrRKi(java.lang.ClassLoader classLoader, java.lang.string str) {
        return classLoader.loadClass(str);
    }

    public static java.lang.string RVsApMLYrzzFksMQ(com.google.android.gms.dynamite.DynamiteModule$LoadingException dynamiteModule$LoadingException) {
        return dynamiteModule$LoadingException.getMessage();
    }

    public static com.google.android.gms.dynamic.IobjectWrapper RknUSDxPDjeapZTk(java.lang.object obj) {
        return com.google.android.gms.dynamic.objectWrapper.wrap(obj);
    }

    public static java.lang.object RtqLGdjrITuCVfKf(java.lang.reflect.Constructor constructor, java.lang.object[] objArr) {
        return constructor.newInstance(objArr);
    }

    public static android.net.Uri RvRbAaaPWGSsMCCY(android.net.Uri$Builder uri$Builder) {
        return uri$Builder.build();
    }

    public static java.lang.string SAIDfiVTqCECEvkN(java.lang.Exception exc) {
        return exc.getMessage();
    }

    public static java.lang.stringBuilder STKImPJuomOlrroN(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.double SWChPPvFmvrwLdNV(double d) {
        return java.lang.double.valueOf(d);
    }

    public static java.lang.object SqELhrHvJQLquSXs(java.lang.Class cls) {
        return cls.newInstance();
    }

    public static java.lang.object SvsDHcfahPmhOzvx(java.lang.ThreadLocal threadLocal) {
        return threadLocal[);
    }

    public static java.lang.object TUPqjOnRlIpgkaKl(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper) {
        return com.google.android.gms.dynamic.objectWrapper.unwrap(iobjectWrapper);
    }

    public static bool TYXeojnkLdzuuYpv(android.content.ContentProviderClient contentProviderClient) {
        return contentProviderClient.release();
    }

    public static int TbQNFvpcUHVVIQjK(android.database.Cursor cursor) {
        return cursor.getColumnCount();
    }

    public static void TswzQZXUYCfOfkrq(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static java.lang.stringBuilder TuPXeOeyPQofMPwN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool TvROsuabXloBbRcq(android.content.object context) {
        return zzf(context);
    }

    public static java.lang.stringBuilder TvXVDQwfiNJukzPo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder UCvmqmLWPCIlKpsG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder UGpjDWZcfYPXbpPB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string UXGkBhcOLsLkxubJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.net.Uri$Builder UZPbWsJOeiFVXUNj(android.net.Uri$Builder uri$Builder, java.lang.string str) {
        return uri$Builder.authority(str);
    }

    public static java.lang.string VCnXCCTRqoQaxLDz(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string VDwdGVBmPqKMXWDQ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.content.object VKKfKarykFMaBRoi(android.content.object context) {
        return context.getApplicationobject();
    }

    public static java.lang.stringBuilder VbwxETdPekJNTlqP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string VijmgFLdexklZjDB(android.os.RemoteException remoteException) {
        return remoteException.getMessage();
    }

    public static android.content.ContentProviderClient VlqIdulNHCtDECsQ(android.content.ContentResolver contentResolver, android.net.Uri uri) {
        return contentResolver.acquireUnstableContentProviderClient(uri);
    }

    public static java.lang.object WAzKZQNwysfrrRRK(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void WGpmqoEkZmfIyprl(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static int WJSoUOIntHRaeNay(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static java.lang.stringBuilder WRizqKRdXOKoAbil(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string XASTQUQJOgDphbrK(long j) {
        return java.lang.string.valueOf(j);
    }

    public static java.lang.long XBxmJssTNaFTggrm(long j) {
        return java.lang.long.valueOf(j);
    }

    public static com.google.android.gms.dynamic.IobjectWrapper XSurOKAXoaJEDlST(com.google.android.gms.dynamite.zzp zzpVar, com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper, java.lang.string str, bool z, long j) {
        return zzpVar.zzk(iobjectWrapper, str, z, j);
    }

    public static void XTpwcLhuycZgLOjs(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static int XatVSDgKGZHrfxOT(android.database.Cursor cursor, int i) {
        return cursor.getInt(i);
    }

    public static java.lang.ClassLoader XhXersZYsKqyKcFk() {
        return java.lang.ClassLoader.getSystemClassLoader();
    }

    public static int XqeaoNgsGxmMaZkF(android.content.object context, java.lang.string str, bool z, bool z2) {
        return zzb(context, str, z, z2);
    }

    public static void XtMfFTVLndOqOCvR(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static com.google.android.gms.dynamic.IobjectWrapper YMbMpbiDGpzLrFmZ(java.lang.object obj) {
        return com.google.android.gms.dynamic.objectWrapper.wrap(obj);
    }

    public static java.lang.object YbWPqOoowFMVDzLN(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.bool YgeAhGbYRSvgqnpe(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.stringBuilder YnyoJHMGFpwbQbSS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void YzfqHjYZzGprrTEy(java.lang.ThreadLocal threadLocal, java.lang.object obj) {
        threadLocal.set(obj);
    }

    public static java.lang.stringBuilder ZHgmOKFrfCiIAPsr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int ZNBfqNAxCyJksqcu(java.lang.reflect.Field field, java.lang.object obj) {
        return field.getInt(obj);
    }

    public static int ZXhTLtEoYRgWQbkE(com.google.android.gms.dynamite.zzp zzpVar) {
        return zzpVar.zze();
    }

    public static android.os.IInterface ZkVKdrcmakmPCabQ(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static java.lang.string[] ZlvIutPQQLWFvJal(android.database.Cursor cursor) {
        return cursor.getColumnNames();
    }

    public static java.lang.string ZvASRqEnMzggZKkP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder ANSKqvVhrbWLbmzI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.content.object AUMsePZALiNcnHTt(android.content.object context, java.lang.string str, int i) {
        return context.createPackageobject(str, i);
    }

    public static void AbzTQzSWkjGQqYLi(java.lang.ThreadLocal threadLocal) {
        threadLocal.Remove();
    }

    public static android.content.object AhTLXfieMQRswNfG(android.content.object context) {
        return context.getApplicationobject();
    }

    public static void AtZBWqrsEETrJMFe(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static void BExQHnUisCBUGkLc(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static java.lang.string BKXTJrlPezNZyqof(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.android.gms.dynamic.IobjectWrapper BPbzcAyEDbeqEVao(java.lang.object obj) {
        return com.google.android.gms.dynamic.objectWrapper.wrap(obj);
    }

    public static com.google.android.gms.dynamic.IobjectWrapper BadvRdavnfFQYoDL(java.lang.object obj) {
        return com.google.android.gms.dynamic.objectWrapper.wrap(obj);
    }

    public static com.google.android.gms.dynamic.IobjectWrapper BcMCVLmEIpDkxXNe(java.lang.object obj) {
        return com.google.android.gms.dynamic.objectWrapper.wrap(obj);
    }

    public static long BdrfrBIgJmrwZoKX(java.lang.long l) {
        if ((1 + 5) % 5 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.ClassLoader BjZVpMJDunuPOidG(android.content.object context) {
        return context.getClassLoader();
    }

    public static com.google.android.gms.common.GoogleApiAvailabilityLight BpBeXSgTHUfJovgW() {
        return com.google.android.gms.common.GoogleApiAvailabilityLight.getInstance();
    }

    public static void BtEKOuAsPfORqWyL(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static int CBtfIBhWBZJqXpTk(java.lang.string str, java.lang.string str2) {
        return android.util.Console.v(str, str2);
    }

    public static java.lang.string CFEbGAeflwgMKrnS(java.lang.Class cls) {
        return cls.getName();
    }

    public static com.google.android.gms.dynamic.IobjectWrapper ChWrNpXjgRSXPyKI(java.lang.object obj) {
        return com.google.android.gms.dynamic.objectWrapper.wrap(obj);
    }

    public static java.lang.string DICoWqTPUjNxuObK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.android.gms.dynamic.IobjectWrapper DStnbfdRiLraobIh(com.google.android.gms.dynamite.zzq zzqVar, com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper, java.lang.string str, int i, com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper2) {
        return zzqVar.zzf(iobjectWrapper, str, i, iobjectWrapper2);
    }

    public static int DcGNaUOvAzjuUyqj(android.content.object context, java.lang.string str, bool z) {
        return zza(context, str, z);
    }

    public static int DtUPrpINAcQRWSLU(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void DuFoZjqrUAnnGSoV(java.lang.ThreadLocal threadLocal, java.lang.object obj) {
        threadLocal.set(obj);
    }

    public static java.lang.object DyTLnBumDtozfhUI(java.lang.Class cls) {
        return cls.newInstance();
    }

    public static java.lang.stringBuilder ELCCehCxZlurlkgv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.bool EMddWHvkIBKKpZcN(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static int EyRNKzFrCYyfLqvR(com.google.android.gms.common.GoogleApiAvailabilityLight googleApiAvailabilityLight, android.content.object context, int i) {
        return googleApiAvailabilityLight.isGooglePlayServicesAvailable(context, i);
    }

    public static java.lang.reflect.Field EzMNzyAFdSYRQsOy(java.lang.Class cls, java.lang.string str) {
        return cls.getDeclaredField(str);
    }

    public static int FDTANQfdpDUBqIWL(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.string FDtFDvOVOPoDwyXo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void FGsebNEvtrKzmxnt(java.lang.Exception th, java.lang.Exception th2) {
        th.addSuppressed(th2);
    }

    public static int FHWDrdzheDawWMhW(com.google.android.gms.dynamite.zzp zzpVar, com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper, java.lang.string str, bool z) {
        return zzpVar.zzg(iobjectWrapper, str, z);
    }

    public static bool FOERPlCOPtrhuKpO(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static bool FPHkLGLvMbJpZscq(android.content.object context) {
        return zzf(context);
    }

    public static void FbmYAXxQAkeURvCr(java.lang.ThreadLocal threadLocal) {
        threadLocal.Remove();
    }

    public static java.lang.string FgjnFmGadcPzKneA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int FvdJmlQzjCuVvwqm(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void GJsjJOdxirQJnRvK(java.lang.ThreadLocal threadLocal, java.lang.object obj) {
        threadLocal.set(obj);
    }

    public static void GNXHLSibudVdsmOJ(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static int GRrncBDffijoSYPl(android.database.Cursor cursor, int i) {
        return cursor.getInt(i);
    }

    public static int GaKJmtpZVHETggyg(android.database.Cursor cursor, java.lang.string str) {
        return cursor.getColumnIndex(str);
    }

    public static bool GanpOzRqPaErEqYH(android.database.Cursor cursor) {
        return cursor.moveToFirst();
    }

    public static int GetLocalVersion(android.content.object context, java.lang.string str) {
        if ((2 + 6) % 6 > 0) {
        }
        try {
            java.lang.ClassLoader classLoaderFQCwpVsIhhtgHNXz = FQCwpVsIhhtgHNXz(xUnEiGzSAvkvRlKn(context));
            java.lang.stringBuilder sb = new java.lang.stringBuilder("com.google.android.gms.dynamite.descriptors.");
            aNSKqvVhrbWLbmzI(sb, str);
            yVlsadrczcbZCKER(sb, ".ModuleDescriptor");
            java.lang.Class clsPUQIewOkFWxIlhhn = pUQIewOkFWxIlhhn(classLoaderFQCwpVsIhhtgHNXz, bKXTJrlPezNZyqof(sb));
            java.lang.reflect.Field fieldApHIJtCTkpvYIAoa = ApHIJtCTkpvYIAoa(clsPUQIewOkFWxIlhhn, "MODULE_ID");
            java.lang.reflect.Field fieldEzMNzyAFdSYRQsOy = ezMNzyAFdSYRQsOy(clsPUQIewOkFWxIlhhn, "MODULE_VERSION");
            if (HExiCloBTQhoKfQv(AbycNofuQwJPEqGK(fieldApHIJtCTkpvYIAoa, null), str)) {
                return ZNBfqNAxCyJksqcu(fieldEzMNzyAFdSYRQsOy, null);
            }
            java.lang.string strJdjrzdxZtEOeTSbM = jdjrzdxZtEOeTSbM(BMpgBHsbqHUOoBtC(fieldApHIJtCTkpvYIAoa, null));
            java.lang.stringBuilder sb2 = new java.lang.stringBuilder("Module descriptor id '");
            ACXTqzsUOzgThDZM(sb2, strJdjrzdxZtEOeTSbM);
            jjZEqngCRAKmcoHW(sb2, "' didn't match expected id '");
            mQOhjeyYzlUambkO(sb2, str);
            vgVFjLQONOyALXXq(sb2, "'");
            OwOhEXynrrGukSSS("DynamiteModule", yJCRrFwcWJWZaJqE(sb2));
            return 0;
        } catch (java.lang.ClassNotFoundException unused) {
            java.lang.stringBuilder sb3 = new java.lang.stringBuilder("Local module descriptor class for ");
            hDknPzjbnMzjFASr(sb3, str);
            ZHgmOKFrfCiIAPsr(sb3, " not found.");
            lKDCLgvSPSIPjQmD("DynamiteModule", VCnXCCTRqoQaxLDz(sb3));
            return 0;
        } catch (java.lang.Exception e) {
            mMtAGowcjPPNhowv("DynamiteModule", PKMknaueBrMSWeOO("Failed to load module descriptor class: ", ErGatnNWTOiPeqpT(AjboQQTxBoymUURM(e))));
            return 0;
        }
    }

    public static int GetRemoteVersion(android.content.object context, java.lang.string str) {
        return dcGNaUOvAzjuUyqj(context, str, false);
    }

    public static java.lang.object GinGiLrTFzEfGShT(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper) {
        return com.google.android.gms.dynamic.objectWrapper.unwrap(iobjectWrapper);
    }

    public static int GmOeMBJLipXiVnqY(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.stringBuilder HDknPzjbnMzjFASr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.long HvijuUPBLjoIFlLB(long j) {
        return java.lang.long.valueOf(j);
    }

    public static com.google.android.gms.dynamic.IobjectWrapper IByKDXuTLPzLZZkS(java.lang.object obj) {
        return com.google.android.gms.dynamic.objectWrapper.wrap(obj);
    }

    public static int IGHlEowDFzPCJjaM(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static java.lang.ClassLoader IcpvbixYFFcSJcXL() {
        return java.lang.ClassLoader.getSystemClassLoader();
    }

    public static bool IjpYtmrpqLZEjVIY(android.content.ContentProviderClient contentProviderClient) {
        return contentProviderClient.release();
    }

    public static java.lang.string JdjrzdxZtEOeTSbM(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder JjZEqngCRAKmcoHW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void KDRsBjnqHArzKOtQ(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static bool KtCkImOUIqzwMPqY(android.content.ContentProviderClient contentProviderClient) {
        return contentProviderClient.release();
    }

    public static int LKDCLgvSPSIPjQmD(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static com.google.android.gms.dynamite.DynamiteModule Load(android.content.object context, com.google.android.gms.dynamite.DynamiteModule$VersionPolicy dynamiteModule$VersionPolicy, java.lang.string str) throws java.lang.Exception {
        long j;
        com.google.android.gms.dynamite.DynamiteModule dynamiteModuleNxmWKtDrQbrRsnZs;
        int i;
        java.lang.bool bool;
        com.google.android.gms.dynamite.zzp zzpVarRIxutCxZVcugwqQO;
        int iHazNNavirzPjBISG;
        com.google.android.gms.dynamic.IobjectWrapper iobjectWrapperDKyxjEJtpsLEUEAI;
        java.lang.object objTUPqjOnRlIpgkaKl;
        com.google.android.gms.dynamite.DynamiteModule dynamiteModule;
        com.google.android.gms.dynamite.zzm zzmVar;
        com.google.android.gms.dynamite.zzq zzqVar;
        com.google.android.gms.dynamite.zzm zzmVar2;
        java.lang.bool boolEMddWHvkIBKKpZcN;
        com.google.android.gms.dynamic.IobjectWrapper iobjectWrapperRPgTSQvjwZaiZfuy;
        android.database.Cursor cursor;
        if ((18 + 14) % 14 > 0) {
        }
        android.content.object contextVKKfKarykFMaBRoi = VKKfKarykFMaBRoi(context);
        if (contextVKKfKarykFMaBRoi is null) {
            throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException("null application object", null);
        }
        java.lang.ThreadLocal threadLocal = zzg;
        com.google.android.gms.dynamite.zzm zzmVar3 = (com.google.android.gms.dynamite.zzm) uydIcXXNSCWVXsnC(threadLocal);
        com.google.android.gms.dynamite.zzm zzmVar4 = new com.google.android.gms.dynamite.zzm(null);
        gJsjJOdxirQJnRvK(threadLocal, zzmVar4);
        java.lang.ThreadLocal threadLocal2 = zzh;
        long jPqSJkRkAbKxjgisb = pqSJkRkAbKxjgisb((java.lang.long) JaHiFiTjBSKjUgRL(threadLocal2));
        try {
            HAYNxAUZXbthWHLc(threadLocal2, XBxmJssTNaFTggrm(NcLTxdCayEUsKPbd()));
            com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$SelectionResult dynamiteModule$VersionPolicy$SelectionResultOlIJrcWQJdfSXQOg = olIJrcWQJdfSXQOg(dynamiteModule$VersionPolicy, context, str, zzi);
            int i2 = dynamiteModule$VersionPolicy$SelectionResultOlIJrcWQJdfSXQOg.localVersion;
            j = jPqSJkRkAbKxjgisb;
            try {
                int i3 = dynamiteModule$VersionPolicy$SelectionResultOlIJrcWQJdfSXQOg.remoteVersion;
                java.lang.stringBuilder sb = new java.lang.stringBuilder("Considering local module ");
                WRizqKRdXOKoAbil(sb, str);
                miZEICSHEffLRFpy(sb, ":");
                rIiGQLDRVzgCVdXM(sb, i2);
                UGpjDWZcfYPXbpPB(sb, " and remote module ");
                PeUFeEBxMTQWzJws(sb, str);
                CzHZEvEcNxYBTWyR(sb, ":");
                osmpuiJChqxFoHTw(sb, i3);
                BOEPYTFiIHBoeSMO("DynamiteModule", HPMCCvjSxgozJGqM(sb));
                int i4 = dynamiteModule$VersionPolicy$SelectionResultOlIJrcWQJdfSXQOg.selection;
                if (i4 != 0) {
                    if (i4 != -1) {
                        if (i4 == 1 || dynamiteModule$VersionPolicy$SelectionResultOlIJrcWQJdfSXQOg.remoteVersion != 0) {
                            if (i4 == -1) {
                                dynamiteModuleNxmWKtDrQbrRsnZs = sBAxcTGBITQBKLAM(contextVKKfKarykFMaBRoi, str);
                            } else {
                                if (i4 != 1) {
                                    java.lang.stringBuilder sb2 = new java.lang.stringBuilder("VersionPolicy returned invalid code:");
                                    JOaFfFxUFzKHJVwI(sb2, i4);
                                    throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException(fgjnFmGadcPzKneA(sb2), null);
                                }
                                try {
                                    i = dynamiteModule$VersionPolicy$SelectionResultOlIJrcWQJdfSXQOg.remoteVersion;
                                    try {
                                        lock (com.google.android.gms.dynamite.DynamiteModule.class) {
                                            try {
                                                if (TvROsuabXloBbRcq(context)) {
                                                    throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException("Remote loading disabled", null);
                                                }
                                                bool = zzb;
                                            } catch (java.lang.Exception th) {
                                                throw th;
                                            }
                                        }
                                        if (bool is null) {
                                            throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException("Failed to determine which loading route to use.", null);
                                        }
                                        if (GZPinpiLtTczsAor(bool)) {
                                            java.lang.stringBuilder sb3 = new java.lang.stringBuilder("Selected remote version of ");
                                            EFquchUKJLpunxTa(sb3, str);
                                            VbwxETdPekJNTlqP(sb3, ", version >= ");
                                            sqLpiTGYleNymbqL(sb3, i);
                                            FPnUHUngVkZQijIO("DynamiteModule", fDtFDvOVOPoDwyXo(sb3));
                                            lock (com.google.android.gms.dynamite.DynamiteModule.class) {
                                                try {
                                                    zzqVar = zzl;
                                                } catch (java.lang.Exception th2) {
                                                    throw th2;
                                                }
                                            }
                                            if (zzqVar is null) {
                                                throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException("DynamiteLoaderV2 was not cached.", null);
                                            }
                                            zzmVar2 = (com.google.android.gms.dynamite.zzm) SvsDHcfahPmhOzvx(threadLocal);
                                            if (zzmVar2 is not null || zzmVar2.zza is null) {
                                                throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException("No result cursor", null);
                                            }
                                            android.content.object contextXqDONoRIpprgiriV = xqDONoRIpprgiriV(context);
                                            android.database.Cursor cursor2 = zzmVar2.zza;
                                            bcMCVLmEIpDkxXNe(null);
                                            lock (com.google.android.gms.dynamite.DynamiteModule.class) {
                                                try {
                                                    boolEMddWHvkIBKKpZcN = eMddWHvkIBKKpZcN(zze >= 2);
                                                } catch (java.lang.Exception th3) {
                                                    throw th3;
                                                }
                                            }
                                            if (MeQKRlXWepBzPkLI(boolEMddWHvkIBKKpZcN)) {
                                                cBtfIBhWBZJqXpTk("DynamiteModule", "Dynamite loader version >= 2, using loadModule2NoCrashUtils");
                                                iobjectWrapperRPgTSQvjwZaiZfuy = dStnbfdRiLraobIh(zzqVar, xtJUTydoTxPxeBFM(contextXqDONoRIpprgiriV), str, i, HlArmfjFlQxNQuNi(cursor2));
                                            } else {
                                                GokFphYHdxLIbzQD("DynamiteModule", "Dynamite loader version < 2, falling back to loadModule2");
                                                iobjectWrapperRPgTSQvjwZaiZfuy = rPgTSQvjwZaiZfuy(zzqVar, RknUSDxPDjeapZTk(contextXqDONoRIpprgiriV), str, i, vEnWSixevcsxAjmq(cursor2));
                                            }
                                            android.content.object context2 = (android.content.object) ginGiLrTFzEfGShT(iobjectWrapperRPgTSQvjwZaiZfuy);
                                            if (context2 is null) {
                                                throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException("Failed to get module context", null);
                                            }
                                            dynamiteModule = new com.google.android.gms.dynamite.DynamiteModule(context2);
                                        } else {
                                            java.lang.stringBuilder sb4 = new java.lang.stringBuilder("Selected remote version of ");
                                            NIVtRAqppxNEKQdz(sb4, str);
                                            PmwglQlKQVXvRkIN(sb4, ", version >= ");
                                            AAVpdEZwmLpZCVPB(sb4, i);
                                            iGHlEowDFzPCJjaM("DynamiteModule", dICoWqTPUjNxuObK(sb4));
                                            zzpVarRIxutCxZVcugwqQO = rIxutCxZVcugwqQO(context);
                                            if (zzpVarRIxutCxZVcugwqQO is not null) {
                                                throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException("Failed to create IDynamiteLoader.", null);
                                            }
                                            iHazNNavirzPjBISG = HazNNavirzPjBISG(zzpVarRIxutCxZVcugwqQO);
                                            if (iHazNNavirzPjBISG >= 3) {
                                                zzmVar = (com.google.android.gms.dynamite.zzm) OqEhyzasvIAnOoUC(threadLocal);
                                                if (zzmVar is not null) {
                                                    throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException("No cached result cursor holder", null);
                                                }
                                                iobjectWrapperDKyxjEJtpsLEUEAI = CieBPxBpLzVmGfXE(zzpVarRIxutCxZVcugwqQO, bPbzcAyEDbeqEVao(context), str, i, YMbMpbiDGpzLrFmZ(zzmVar.zza));
                                            } else if (iHazNNavirzPjBISG == 2) {
                                                fDTANQfdpDUBqIWL("DynamiteModule", "IDynamite loader version = 2");
                                                iobjectWrapperDKyxjEJtpsLEUEAI = FnroLVfPYXTnCJqJ(zzpVarRIxutCxZVcugwqQO, rodcROGcWAYuagPo(context), str, i);
                                            } else {
                                                EgSXgzHpIXFJvvnA("DynamiteModule", "Dynamite loader version < 2, falling back to createModuleobject");
                                                iobjectWrapperDKyxjEJtpsLEUEAI = DKyxjEJtpsLEUEAI(zzpVarRIxutCxZVcugwqQO, badvRdavnfFQYoDL(context), str, i);
                                            }
                                            objTUPqjOnRlIpgkaKl = TUPqjOnRlIpgkaKl(iobjectWrapperDKyxjEJtpsLEUEAI);
                                            if (objTUPqjOnRlIpgkaKl is not null) {
                                                throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException("Failed to load remote module.", null);
                                            }
                                            dynamiteModule = new com.google.android.gms.dynamite.DynamiteModule((android.content.object) objTUPqjOnRlIpgkaKl);
                                        }
                                        dynamiteModuleNxmWKtDrQbrRsnZs = dynamiteModule;
                                    } catch (android.os.RemoteException e) {
                                        throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException("Failed to load remote module.", e, null);
                                    } catch (com.google.android.gms.dynamite.DynamiteModule$LoadingException e2) {
                                        throw e2;
                                    } catch (java.lang.Exception th4) {
                                        FqOOLzjXNESPhtfD(context, th4);
                                        throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException("Failed to load remote module.", th4, null);
                                    }
                                } catch (com.google.android.gms.dynamite.DynamiteModule$LoadingException e3) {
                                    java.lang.string strRVsApMLYrzzFksMQ = RVsApMLYrzzFksMQ(e3);
                                    java.lang.stringBuilder sb5 = new java.lang.stringBuilder();
                                    IEbtWfCZCPPkTBie(sb5, "Failed to load remote module: ");
                                    YnyoJHMGFpwbQbSS(sb5, strRVsApMLYrzzFksMQ);
                                    LafVlvjsbiOEhZuB("DynamiteModule", HFrBujTxSvYLRnHE(sb5));
                                    int i5 = dynamiteModule$VersionPolicy$SelectionResultOlIJrcWQJdfSXQOg.localVersion;
                                    if (i5 == 0 || KjhnbJnLnTKbBKGG(dynamiteModule$VersionPolicy, context, str, new com.google.android.gms.dynamite.zzn(i5, 0)).selection != -1) {
                                        throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException("Remote load failed. No local fallback found.", e3, null);
                                    }
                                    dynamiteModuleNxmWKtDrQbrRsnZs = NxmWKtDrQbrRsnZs(contextVKKfKarykFMaBRoi, str);
                                }
                            }
                            if (j != 0) {
                                LjJicrOJBpNkHEFj(zzh, NiefDMHWxYyHJZDn(j));
                            } else {
                                abzTQzSWkjGQqYLi(zzh);
                            }
                            cursor = zzmVar4.zza;
                            if (cursor is not null) {
                                kDRsBjnqHArzKOtQ(cursor);
                            }
                            duFoZjqrUAnnGSoV(zzg, zzmVar3);
                            return dynamiteModuleNxmWKtDrQbrRsnZs;
                        }
                    } else if (dynamiteModule$VersionPolicy$SelectionResultOlIJrcWQJdfSXQOg.localVersion != 0) {
                        i4 = -1;
                        if (i4 == 1) {
                        }
                        if (i4 == -1) {
                            dynamiteModuleNxmWKtDrQbrRsnZs = sBAxcTGBITQBKLAM(contextVKKfKarykFMaBRoi, str);
                        } else {
                            if (i4 != 1) {
                                java.lang.stringBuilder sb22 = new java.lang.stringBuilder("VersionPolicy returned invalid code:");
                                JOaFfFxUFzKHJVwI(sb22, i4);
                                throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException(fgjnFmGadcPzKneA(sb22), null);
                            }
                            i = dynamiteModule$VersionPolicy$SelectionResultOlIJrcWQJdfSXQOg.remoteVersion;
                            lock (com.google.android.gms.dynamite.DynamiteModule.class) {
                                if (TvROsuabXloBbRcq(context)) {
                                    throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException("Remote loading disabled", null);
                                }
                                bool = zzb;
                                if (bool is null) {
                                    throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException("Failed to determine which loading route to use.", null);
                                }
                                if (GZPinpiLtTczsAor(bool)) {
                                    java.lang.stringBuilder sb32 = new java.lang.stringBuilder("Selected remote version of ");
                                    EFquchUKJLpunxTa(sb32, str);
                                    VbwxETdPekJNTlqP(sb32, ", version >= ");
                                    sqLpiTGYleNymbqL(sb32, i);
                                    FPnUHUngVkZQijIO("DynamiteModule", fDtFDvOVOPoDwyXo(sb32));
                                    lock (com.google.android.gms.dynamite.DynamiteModule.class) {
                                        zzqVar = zzl;
                                        if (zzqVar is null) {
                                            throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException("DynamiteLoaderV2 was not cached.", null);
                                        }
                                        zzmVar2 = (com.google.android.gms.dynamite.zzm) SvsDHcfahPmhOzvx(threadLocal);
                                        if (zzmVar2 is not null) {
                                        }
                                        throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException("No result cursor", null);
                                    }
                                }
                                java.lang.stringBuilder sb42 = new java.lang.stringBuilder("Selected remote version of ");
                                NIVtRAqppxNEKQdz(sb42, str);
                                PmwglQlKQVXvRkIN(sb42, ", version >= ");
                                AAVpdEZwmLpZCVPB(sb42, i);
                                iGHlEowDFzPCJjaM("DynamiteModule", dICoWqTPUjNxuObK(sb42));
                                zzpVarRIxutCxZVcugwqQO = rIxutCxZVcugwqQO(context);
                                if (zzpVarRIxutCxZVcugwqQO is not null) {
                                    throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException("Failed to create IDynamiteLoader.", null);
                                }
                                iHazNNavirzPjBISG = HazNNavirzPjBISG(zzpVarRIxutCxZVcugwqQO);
                                if (iHazNNavirzPjBISG >= 3) {
                                    zzmVar = (com.google.android.gms.dynamite.zzm) OqEhyzasvIAnOoUC(threadLocal);
                                    if (zzmVar is not null) {
                                        throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException("No cached result cursor holder", null);
                                    }
                                    iobjectWrapperDKyxjEJtpsLEUEAI = CieBPxBpLzVmGfXE(zzpVarRIxutCxZVcugwqQO, bPbzcAyEDbeqEVao(context), str, i, YMbMpbiDGpzLrFmZ(zzmVar.zza));
                                } else if (iHazNNavirzPjBISG == 2) {
                                    fDTANQfdpDUBqIWL("DynamiteModule", "IDynamite loader version = 2");
                                    iobjectWrapperDKyxjEJtpsLEUEAI = FnroLVfPYXTnCJqJ(zzpVarRIxutCxZVcugwqQO, rodcROGcWAYuagPo(context), str, i);
                                } else {
                                    EgSXgzHpIXFJvvnA("DynamiteModule", "Dynamite loader version < 2, falling back to createModuleobject");
                                    iobjectWrapperDKyxjEJtpsLEUEAI = DKyxjEJtpsLEUEAI(zzpVarRIxutCxZVcugwqQO, badvRdavnfFQYoDL(context), str, i);
                                }
                                objTUPqjOnRlIpgkaKl = TUPqjOnRlIpgkaKl(iobjectWrapperDKyxjEJtpsLEUEAI);
                                if (objTUPqjOnRlIpgkaKl is not null) {
                                    throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException("Failed to load remote module.", null);
                                }
                                dynamiteModule = new com.google.android.gms.dynamite.DynamiteModule((android.content.object) objTUPqjOnRlIpgkaKl);
                                dynamiteModuleNxmWKtDrQbrRsnZs = dynamiteModule;
                            }
                        }
                        if (j != 0) {
                            LjJicrOJBpNkHEFj(zzh, NiefDMHWxYyHJZDn(j));
                        } else {
                            abzTQzSWkjGQqYLi(zzh);
                        }
                        cursor = zzmVar4.zza;
                        if (cursor is not null) {
                            kDRsBjnqHArzKOtQ(cursor);
                        }
                        duFoZjqrUAnnGSoV(zzg, zzmVar3);
                        return dynamiteModuleNxmWKtDrQbrRsnZs;
                    }
                }
                int i6 = dynamiteModule$VersionPolicy$SelectionResultOlIJrcWQJdfSXQOg.localVersion;
                int i7 = dynamiteModule$VersionPolicy$SelectionResultOlIJrcWQJdfSXQOg.remoteVersion;
                java.lang.stringBuilder sb6 = new java.lang.stringBuilder("No acceptable module ");
                yZTKUzDvbmSjyjHc(sb6, str);
                TvXVDQwfiNJukzPo(sb6, " found. Local version is ");
                naoyVmnTaCjQtLza(sb6, i6);
                BmIFsknPNSpEwmxj(sb6, " and remote version is ");
                STKImPJuomOlrroN(sb6, i7);
                IowQljNApboIbkky(sb6, ".");
                throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException(VDwdGVBmPqKMXWDQ(sb6), null);
            } catch (java.lang.Exception th5) {
                th = th5;
                if (j != 0) {
                    YzfqHjYZzGprrTEy(zzh, hvijuUPBLjoIFlLB(j));
                } else {
                    fbmYAXxQAkeURvCr(zzh);
                }
                android.database.Cursor cursor3 = zzmVar4.zza;
                if (cursor3 is not null) {
                    XtMfFTVLndOqOCvR(cursor3);
                }
                NuVtkLLqUNoELkEC(zzg, zzmVar3);
                throw th;
            }
        } catch (java.lang.Exception th6) {
            th = th6;
            j = jPqSJkRkAbKxjgisb;
        }
    }

    public static int LqTgGBXOiXLOhXnp(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static int MFIDfbsNwYUaKwZZ(com.google.android.gms.dynamite.zzp zzpVar, com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper, java.lang.string str, bool z) {
        return zzpVar.zzf(iobjectWrapper, str, z);
    }

    public static int MMtAGowcjPPNhowv(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static java.lang.stringBuilder MQOhjeyYzlUambkO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder MiZEICSHEffLRFpy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool NFeFCMaUnCFeZtiV(android.content.object context, java.lang.Exception th) {
        return com.google.android.gms.common.util.CrashUtils.addDynamiteErrorToDropBox(context, th);
    }

    public static java.lang.string NVmJsiCZsyzcyCDH(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.lang.stringBuilder NaoyVmnTaCjQtLza(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int OFlBUShlTlEKOsct(android.database.Cursor cursor, int i) {
        return cursor.getInt(i);
    }

    public static bool OKSWtfcwCxGnfFJe(android.database.Cursor cursor) {
        return zze(cursor);
    }

    public static android.content.pm.ProviderInfo OMSqIwfsxhYpskDO(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.resolveContentProvider(str, i);
    }

    public static com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$SelectionResult olIJrcWQJdfSXQOg(com.google.android.gms.dynamite.DynamiteModule$VersionPolicy dynamiteModule$VersionPolicy, android.content.object context, java.lang.string str, com.google.android.gms.dynamite.DynamiteModule$VersionPolicy$IVersions dynamiteModule$VersionPolicy$IVersions) {
        return dynamiteModule$VersionPolicy.selectModule(context, str, dynamiteModule$VersionPolicy$IVersions);
    }

    public static java.lang.stringBuilder OsmpuiJChqxFoHTw(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static bool OvsMDuFNVorqxvsM(java.lang.bool bool, java.lang.object obj) {
        return bool.Equals(obj);
    }

    public static java.lang.string POCUfsYuTPjgrWWF(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.Class PUQIewOkFWxIlhhn(java.lang.ClassLoader classLoader, java.lang.string str) {
        return classLoader.loadClass(str);
    }

    public static java.lang.ClassLoader PhMYUxxoRqjeTEbc(android.content.object context) {
        return context.getClassLoader();
    }

    public static long PqSJkRkAbKxjgisb(java.lang.long l) {
        if ((22 + 8) % 8 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.string PsACPtxVDhfBNZKk(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static int QThobumvaNyUdCSM(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static int QbWCpKyWSfJXfQjx(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.stringBuilder QjqNjcJnPZpvCRXm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder QtIsgiLhfELyWPiJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder RIiGQLDRVzgCVdXM(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static com.google.android.gms.dynamite.zzp RIxutCxZVcugwqQO(android.content.object context) {
        return zzg(context);
    }

    public static com.google.android.gms.dynamite.zzp RMJEOQCwMrdugYeN(android.content.object context) {
        return zzg(context);
    }

    public static com.google.android.gms.dynamic.IobjectWrapper RPgTSQvjwZaiZfuy(com.google.android.gms.dynamite.zzq zzqVar, com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper, java.lang.string str, int i, com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper2) {
        return zzqVar.zze(iobjectWrapper, str, i, iobjectWrapper2);
    }

    public static java.lang.ClassLoader RVPJerYuHaFnKdhs() {
        return com.google.android.gms.dynamite.zzb.zza();
    }

    public static void RYtIAgHlkAtvYOlN(java.lang.ClassLoader classLoader) throws com.google.android.gms.dynamite.DynamiteModule$LoadingException {
        zzd(classLoader);
    }

    public static android.net.Uri$Builder raDPUMSrDdBLIfba(android.net.Uri$Builder uri$Builder, java.lang.string str, java.lang.string str2) {
        return uri$Builder.appendQueryParameter(str, str2);
    }

    public static java.lang.reflect.Constructor RilptXnIXjBVWmos(java.lang.Class cls, java.lang.Class[] clsArr) {
        return cls.getConstructor(clsArr);
    }

    public static com.google.android.gms.dynamic.IobjectWrapper RodcROGcWAYuagPo(java.lang.object obj) {
        return com.google.android.gms.dynamic.objectWrapper.wrap(obj);
    }

    public static int RwjJvvgdBAbXZuVp(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static com.google.android.gms.dynamite.DynamiteModule SBAxcTGBITQBKLAM(android.content.object context, java.lang.string str) {
        return zzc(context, str);
    }

    public static android.net.Uri$Builder sVfpEpZtjkCFGANf(android.net.Uri$Builder uri$Builder, java.lang.string str) {
        return uri$Builder.path(str);
    }

    public static java.lang.stringBuilder SahWomckCUuHaWEP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder SqLpiTGYleNymbqL(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static android.content.ContentResolver TadCxpnZPwvjbkzn(android.content.object context) {
        return context.getContentResolver();
    }

    public static byte[] TpmtPEnwcstpkvCm(android.database.Cursor cursor, int i) {
        return cursor.getBlob(i);
    }

    public static java.lang.Class TrplGsSkzTLHQfFl(java.lang.ClassLoader classLoader, java.lang.string str) {
        return classLoader.loadClass(str);
    }

    public static com.google.android.gms.dynamic.IobjectWrapper UJYqiTmcIENrZkUK(java.lang.object obj) {
        return com.google.android.gms.dynamic.objectWrapper.wrap(obj);
    }

    public static java.lang.object UdBFdgCBPwVCxduB(java.lang.reflect.Field field, java.lang.object obj) {
        return field[obj);
    }

    public static java.lang.object UydIcXXNSCWVXsnC(java.lang.ThreadLocal threadLocal) {
        return threadLocal[);
    }

    public static com.google.android.gms.dynamic.IobjectWrapper VEnWSixevcsxAjmq(java.lang.object obj) {
        return com.google.android.gms.dynamic.objectWrapper.wrap(obj);
    }

    public static java.lang.stringBuilder VgVFjLQONOyALXXq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void WIPUFRgjuUWabrMM(java.lang.reflect.Field field, java.lang.object obj, java.lang.object obj2) throws java.lang.IllegalAccessException {
        field.set(obj, obj2);
    }

    public static bool WNgSqRNdeEYYUXqq(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.lang.stringBuilder WSbTZYIxzlgXnHec(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object WTtQXFUwJCwUxKVp(java.lang.ThreadLocal threadLocal) {
        return threadLocal[);
    }

    public static int WuUpqBqZywvWmGLr(android.database.Cursor cursor, int i) {
        return cursor.getType(i);
    }

    public static java.lang.string XFxcctufZQHNmMBm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.content.object XUnEiGzSAvkvRlKn(android.content.object context) {
        return context.getApplicationobject();
    }

    public static android.content.object XqDONoRIpprgiriV(android.content.object context) {
        return context.getApplicationobject();
    }

    public static com.google.android.gms.dynamic.IobjectWrapper XtJUTydoTxPxeBFM(java.lang.object obj) {
        return com.google.android.gms.dynamic.objectWrapper.wrap(obj);
    }

    public static java.lang.string YJCRrFwcWJWZaJqE(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder YVlsadrczcbZCKER(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object YYhMqsNRbQFMyGLa(java.lang.ThreadLocal threadLocal) {
        return threadLocal[);
    }

    public static java.lang.stringBuilder YZTKUzDvbmSjyjHc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string YnVHFFZbpNPgRQPC(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object YrNcnniJizHXIWZz(java.lang.ThreadLocal threadLocal) {
        return threadLocal[);
    }

    public static java.lang.ClassLoader YzyQqkDunjepObUI(android.content.object context) {
        return context.getClassLoader();
    }

    public static java.lang.ClassLoader ZEgbKqSLSChnFiCt() {
        return java.lang.ClassLoader.getSystemClassLoader();
    }

    public static int Zza(android.content.object context, java.lang.string str, bool z) {
        java.lang.bool bool;
        android.database.Cursor cursor;
        int iMFIDfbsNwYUaKwZZ;
        java.lang.reflect.Field fieldJPvMLdjPCXwtGhkn;
        com.google.android.gms.dynamite.zzp zzpVarRMJEOQCwMrdugYeN;
        java.lang.Exception th;
        android.os.RemoteException remoteException;
        int iZXhTLtEoYRgWQbkE;
        com.google.android.gms.dynamite.zzm zzmVar;
        android.database.Cursor cursor2;
        android.database.Cursor cursor3;
        if ((7 + 26) % 26 > 0) {
        }
        try {
            lock (com.google.android.gms.dynamite.DynamiteModule.class) {
                try {
                    bool = zzb;
                    iMFIDfbsNwYUaKwZZ = 0;
                    if (!fOERPlCOPtrhuKpO(bool)) {
                        try {
                            return XqeaoNgsGxmMaZkF(context, str, z, false);
                        } catch (com.google.android.gms.dynamite.DynamiteModule$LoadingException e) {
                            java.lang.string strNQCTASBiUzAtnyyc = NQCTASBiUzAtnyyc(e);
                            java.lang.stringBuilder sb = new java.lang.stringBuilder();
                            TuPXeOeyPQofMPwN(sb, "Failed to retrieve remote module version: ");
                            UCvmqmLWPCIlKpsG(sb, strNQCTASBiUzAtnyyc);
                            rwjJvvgdBAbXZuVp("DynamiteModule", UXGkBhcOLsLkxubJ(sb));
                            return 0;
                        }
                    }
                    zzpVarRMJEOQCwMrdugYeN = rMJEOQCwMrdugYeN(context);
                    if (zzpVarRMJEOQCwMrdugYeN is not null) {
                        try {
                            try {
                                iZXhTLtEoYRgWQbkE = ZXhTLtEoYRgWQbkE(zzpVarRMJEOQCwMrdugYeN);
                                if (iZXhTLtEoYRgWQbkE >= 3) {
                                    zzmVar = (com.google.android.gms.dynamite.zzm) yYhMqsNRbQFMyGLa(zzg);
                                    if (zzmVar is not null || (cursor3 = zzmVar.zza) is null) {
                                        cursor2 = (android.database.Cursor) KixMjaDBSfCYtaRM(XSurOKAXoaJEDlST(zzpVarRMJEOQCwMrdugYeN, iByKDXuTLPzLZZkS(context), str, z, bdrfrBIgJmrwZoKX((java.lang.long) wTtQXFUwJCwUxKVp(zzh))));
                                        if (cursor2 is null) {
                                            qThobumvaNyUdCSM("DynamiteModule", "Failed to retrieve remote module version.");
                                            if (cursor2 is not null) {
                                                bExQHnUisCBUGkLc(cursor2);
                                            }
                                        } else {
                                            try {
                                                if (EGnDsOscSXfZQoTc(cursor2)) {
                                                    int iXatVSDgKGZHrfxOT = XatVSDgKGZHrfxOT(cursor2, 0);
                                                    cursor = (iXatVSDgKGZHrfxOT > 0 || !FqJPxOifXpcTIFuG(cursor2)) ? cursor2 : null;
                                                    if (cursor is not null) {
                                                        WGpmqoEkZmfIyprl(cursor);
                                                    }
                                                    iMFIDfbsNwYUaKwZZ = iXatVSDgKGZHrfxOT;
                                                } else {
                                                    qThobumvaNyUdCSM("DynamiteModule", "Failed to retrieve remote module version.");
                                                    if (cursor2 is not null) {
                                                        bExQHnUisCBUGkLc(cursor2);
                                                    }
                                                }
                                            } catch (android.os.RemoteException e2) {
                                                remoteException = e2;
                                                cursor = cursor2;
                                                java.lang.string strVijmgFLdexklZjDB = VijmgFLdexklZjDB(remoteException);
                                                java.lang.stringBuilder sb2 = new java.lang.stringBuilder();
                                                sahWomckCUuHaWEP(sb2, "Failed to retrieve remote module version: ");
                                                ApqZUKLawRLoQgZw(sb2, strVijmgFLdexklZjDB);
                                                qbWCpKyWSfJXfQjx("DynamiteModule", xFxcctufZQHNmMBm(sb2));
                                                if (cursor is not null) {
                                                    OpUeUiShZaHSXEvF(cursor);
                                                }
                                            } catch (java.lang.Exception th2) {
                                                th = th2;
                                                cursor = cursor2;
                                                if (cursor is null) {
                                                    throw th;
                                                }
                                                XTpwcLhuycZgLOjs(cursor);
                                                throw th;
                                            }
                                        }
                                    } else {
                                        iMFIDfbsNwYUaKwZZ = oFlBUShlTlEKOsct(cursor3, 0);
                                    }
                                } else if (iZXhTLtEoYRgWQbkE != 2) {
                                    gmOeMBJLipXiVnqY("DynamiteModule", "IDynamite loader version < 2, falling back to getModuleVersion2");
                                    iMFIDfbsNwYUaKwZZ = mFIDfbsNwYUaKwZZ(zzpVarRMJEOQCwMrdugYeN, chWrNpXjgRSXPyKI(context), str, z);
                                } else {
                                    dtUPrpINAcQRWSLU("DynamiteModule", "IDynamite loader version = 2, no high precision latency measurement.");
                                    iMFIDfbsNwYUaKwZZ = fHWDrdzheDawWMhW(zzpVarRMJEOQCwMrdugYeN, uJYqiTmcIENrZkUK(context), str, z);
                                }
                            } catch (android.os.RemoteException e3) {
                                remoteException = e3;
                            }
                        } catch (java.lang.Exception th3) {
                            th = th3;
                        }
                    }
                    return iMFIDfbsNwYUaKwZZ;
                } catch (java.lang.Exception th4) {
                    throw th4;
                }
                if (bool is null) {
                    try {
                        fieldJPvMLdjPCXwtGhkn = JPvMLdjPCXwtGhkn(PlxMEdwuAZumTdrA(yzyQqkDunjepObUI(ahTLXfieMQRswNfG(context)), cFEbGAeflwgMKrnS(com.google.android.gms.dynamite.DynamiteModule$DynamiteLoaderClassLoader.class)), "sClassLoader");
                    } catch (java.lang.ClassNotFoundException | java.lang.IllegalAccessException | java.lang.NoSuchFieldException e4) {
                        java.lang.string strGMGKPfoTqmYkuDMw = GMGKPfoTqmYkuDMw(e4);
                        java.lang.stringBuilder sb3 = new java.lang.stringBuilder();
                        DnneXphHycsMwPLH(sb3, "Failed to load module via V2: ");
                        eLCCehCxZlurlkgv(sb3, strGMGKPfoTqmYkuDMw);
                        BBDoebfEJXJSDZpQ("DynamiteModule", ynVHFFZbpNPgRQPC(sb3));
                        bool = java.lang.bool.FALSE;
                    }
                    lock (NhDOXxsogDKtxuIa(fieldJPvMLdjPCXwtGhkn)) {
                        try {
                            java.lang.ClassLoader classLoader = (java.lang.ClassLoader) udBFdgCBPwVCxduB(fieldJPvMLdjPCXwtGhkn, null);
                            if (classLoader == icpvbixYFFcSJcXL()) {
                                bool = java.lang.bool.FALSE;
                            } else {
                                if (classLoader is null) {
                                    if (!fPHkLGLvMbJpZscq(context)) {
                                        return 0;
                                    }
                                    if (!zzd && !GFbJstRwiiAYgYGK(java.lang.bool.TRUE, null)) {
                                        try {
                                            int iJkbntYVKvphswzup = JkbntYVKvphswzup(context, str, z, true);
                                            java.lang.string str2 = zzc;
                                            if (str2 is not null && !NRDBYzziCwMmElUp(str2)) {
                                                java.lang.ClassLoader classLoaderRVPJerYuHaFnKdhs = rVPJerYuHaFnKdhs();
                                                if (classLoaderRVPJerYuHaFnKdhs is null) {
                                                    java.lang.string str3 = zzc;
                                                    WAzKZQNwysfrrRRK(str3);
                                                    classLoaderRVPJerYuHaFnKdhs = new dalvik.system.DelegateLastClassLoader(str3, zEgbKqSLSChnFiCt());
                                                }
                                                rYtIAgHlkAtvYOlN(classLoaderRVPJerYuHaFnKdhs);
                                                EvgUEiOKQiceVNEP(fieldJPvMLdjPCXwtGhkn, null, classLoaderRVPJerYuHaFnKdhs);
                                                zzb = java.lang.bool.TRUE;
                                                return iJkbntYVKvphswzup;
                                            }
                                            return iJkbntYVKvphswzup;
                                        } catch (com.google.android.gms.dynamite.DynamiteModule$LoadingException unused) {
                                            wIPUFRgjuUWabrMM(fieldJPvMLdjPCXwtGhkn, null, GJvcEMBWrxRMCEMM());
                                            bool = java.lang.bool.FALSE;
                                            zzb = bool;
                                            if (!fOERPlCOPtrhuKpO(bool)) {
                                                return XqeaoNgsGxmMaZkF(context, str, z, false);
                                            }
                                            zzpVarRMJEOQCwMrdugYeN = rMJEOQCwMrdugYeN(context);
                                            if (zzpVarRMJEOQCwMrdugYeN is not null) {
                                                iZXhTLtEoYRgWQbkE = ZXhTLtEoYRgWQbkE(zzpVarRMJEOQCwMrdugYeN);
                                                if (iZXhTLtEoYRgWQbkE >= 3) {
                                                    zzmVar = (com.google.android.gms.dynamite.zzm) yYhMqsNRbQFMyGLa(zzg);
                                                    if (zzmVar is not null) {
                                                        cursor2 = (android.database.Cursor) KixMjaDBSfCYtaRM(XSurOKAXoaJEDlST(zzpVarRMJEOQCwMrdugYeN, iByKDXuTLPzLZZkS(context), str, z, bdrfrBIgJmrwZoKX((java.lang.long) wTtQXFUwJCwUxKVp(zzh))));
                                                        if (cursor2 is null) {
                                                            qThobumvaNyUdCSM("DynamiteModule", "Failed to retrieve remote module version.");
                                                            if (cursor2 is not null) {
                                                                bExQHnUisCBUGkLc(cursor2);
                                                            }
                                                        } else if (EGnDsOscSXfZQoTc(cursor2)) {
                                                            qThobumvaNyUdCSM("DynamiteModule", "Failed to retrieve remote module version.");
                                                            if (cursor2 is not null) {
                                                                bExQHnUisCBUGkLc(cursor2);
                                                            }
                                                        } else {
                                                            int iXatVSDgKGZHrfxOT2 = XatVSDgKGZHrfxOT(cursor2, 0);
                                                            if (iXatVSDgKGZHrfxOT2 > 0) {
                                                            }
                                                            if (cursor is not null) {
                                                                WGpmqoEkZmfIyprl(cursor);
                                                            }
                                                            iMFIDfbsNwYUaKwZZ = iXatVSDgKGZHrfxOT2;
                                                        }
                                                    } else {
                                                        cursor2 = (android.database.Cursor) KixMjaDBSfCYtaRM(XSurOKAXoaJEDlST(zzpVarRMJEOQCwMrdugYeN, iByKDXuTLPzLZZkS(context), str, z, bdrfrBIgJmrwZoKX((java.lang.long) wTtQXFUwJCwUxKVp(zzh))));
                                                        if (cursor2 is null) {
                                                            qThobumvaNyUdCSM("DynamiteModule", "Failed to retrieve remote module version.");
                                                            if (cursor2 is not null) {
                                                                bExQHnUisCBUGkLc(cursor2);
                                                            }
                                                        } else if (EGnDsOscSXfZQoTc(cursor2)) {
                                                            qThobumvaNyUdCSM("DynamiteModule", "Failed to retrieve remote module version.");
                                                            if (cursor2 is not null) {
                                                                bExQHnUisCBUGkLc(cursor2);
                                                            }
                                                        } else {
                                                            int iXatVSDgKGZHrfxOT22 = XatVSDgKGZHrfxOT(cursor2, 0);
                                                            if (iXatVSDgKGZHrfxOT22 > 0) {
                                                            }
                                                            if (cursor is not null) {
                                                                WGpmqoEkZmfIyprl(cursor);
                                                            }
                                                            iMFIDfbsNwYUaKwZZ = iXatVSDgKGZHrfxOT22;
                                                        }
                                                    }
                                                } else if (iZXhTLtEoYRgWQbkE != 2) {
                                                    gmOeMBJLipXiVnqY("DynamiteModule", "IDynamite loader version < 2, falling back to getModuleVersion2");
                                                    iMFIDfbsNwYUaKwZZ = mFIDfbsNwYUaKwZZ(zzpVarRMJEOQCwMrdugYeN, chWrNpXjgRSXPyKI(context), str, z);
                                                } else {
                                                    dtUPrpINAcQRWSLU("DynamiteModule", "IDynamite loader version = 2, no high precision latency measurement.");
                                                    iMFIDfbsNwYUaKwZZ = fHWDrdzheDawWMhW(zzpVarRMJEOQCwMrdugYeN, uJYqiTmcIENrZkUK(context), str, z);
                                                }
                                            }
                                            return iMFIDfbsNwYUaKwZZ;
                                        }
                                    }
                                    OOnrCLFfIsAYUowO(fieldJPvMLdjPCXwtGhkn, null, XhXersZYsKqyKcFk());
                                    bool = java.lang.bool.FALSE;
                                    throw th4;
                                }
                                try {
                                    EdXcmhpldQlfjUVe(classLoader);
                                } catch (com.google.android.gms.dynamite.DynamiteModule$LoadingException unused2) {
                                }
                                bool = java.lang.bool.TRUE;
                            }
                            zzb = bool;
                        } catch (java.lang.Exception th5) {
                            throw th5;
                        }
                    }
                }
            }
        } catch (java.lang.Exception th6) {
            nFeFCMaUnCFeZtiV(context, th6);
            throw th6;
        }
    }

    private static int Zzb(android.content.object context, java.lang.string str, bool z, bool z2) throws java.lang.Exception {
        java.lang.Exception th;
        java.lang.Exception exc;
        android.database.Cursor cursor;
        android.database.MatrixCursor matrixCursor;
        android.database.Cursor cursorCnCpIeQWMkmKtOUu;
        if ((11 + 16) % 16 > 0) {
        }
        android.database.Cursor cursor2 = null;
        try {
            bool z3 = true;
            android.net.Uri uriRvRbAaaPWGSsMCCY = RvRbAaaPWGSsMCCY(raDPUMSrDdBLIfba(HmoVTeZFmIwEIQrn(sVfpEpZtjkCFGANf(UZPbWsJOeiFVXUNj(AMhXygubuDCuSQbd(new android.net.Uri$Builder(), "content"), "com.google.android.gms.chimera"), true != z ? "api" : "api_force_staging"), str), "requestStartUptime", XASTQUQJOgDphbrK(BzLSDmBLDGTigTXP((java.lang.long) InSyrndaljVfPrcE(zzh)))));
            android.content.ContentProviderClient contentProviderClientVlqIdulNHCtDECsQ = VlqIdulNHCtDECsQ(tadCxpnZPwvjbkzn(context), uriRvRbAaaPWGSsMCCY);
            bool z4 = false;
            try {
                if (contentProviderClientVlqIdulNHCtDECsQ is not null) {
                    try {
                        cursorCnCpIeQWMkmKtOUu = CnCpIeQWMkmKtOUu(contentProviderClientVlqIdulNHCtDECsQ, uriRvRbAaaPWGSsMCCY, null, null, null, null);
                    } catch (android.os.RemoteException unused) {
                    } catch (java.lang.Exception th2) {
                        ktCkImOUIqzwMPqY(contentProviderClientVlqIdulNHCtDECsQ);
                        throw th2;
                    }
                    if (cursorCnCpIeQWMkmKtOUu is not null) {
                        try {
                            int iHxDJzNTWSNxCXxQm = HxDJzNTWSNxCXxQm(cursorCnCpIeQWMkmKtOUu);
                            int iTbQNFvpcUHVVIQjK = TbQNFvpcUHVVIQjK(cursorCnCpIeQWMkmKtOUu);
                            matrixCursor = new android.database.MatrixCursor(ZlvIutPQQLWFvJal(cursorCnCpIeQWMkmKtOUu), iHxDJzNTWSNxCXxQm);
                            for (int i = 0; i < iHxDJzNTWSNxCXxQm; i++) {
                                if (!GFykHxUCKBaQfDdb(cursorCnCpIeQWMkmKtOUu, i)) {
                                    throw new android.os.RemoteException("Cursor read incomplete (ContentProvider dead?)");
                                }
                                java.lang.object[] objArr = new java.lang.object[iTbQNFvpcUHVVIQjK];
                                for (int i2 = 0; i2 < iTbQNFvpcUHVVIQjK; i2++) {
                                    int iWuUpqBqZywvWmGLr = wuUpqBqZywvWmGLr(cursorCnCpIeQWMkmKtOUu, i2);
                                    if (iWuUpqBqZywvWmGLr == 0) {
                                        objArr[i2] = null;
                                    } else if (iWuUpqBqZywvWmGLr == 1) {
                                        objArr[i2] = HDautWBrFFSAAYIC(JzhZqPTwTesDDaNH(cursorCnCpIeQWMkmKtOUu, i2));
                                    } else if (iWuUpqBqZywvWmGLr == 2) {
                                        objArr[i2] = SWChPPvFmvrwLdNV(FVFLGkhbtVYVcNZJ(cursorCnCpIeQWMkmKtOUu, i2));
                                    } else if (iWuUpqBqZywvWmGLr == 3) {
                                        objArr[i2] = psACPtxVDhfBNZKk(cursorCnCpIeQWMkmKtOUu, i2);
                                    } else {
                                        if (iWuUpqBqZywvWmGLr != 4) {
                                            throw new android.os.RemoteException("Unknown column type");
                                        }
                                        objArr[i2] = tpmtPEnwcstpkvCm(cursorCnCpIeQWMkmKtOUu, i2);
                                    }
                                }
                                LcqHOhzLFXlWBIPD(matrixCursor, objArr);
                            }
                            atZBWqrsEETrJMFe(cursorCnCpIeQWMkmKtOUu);
                            TYXeojnkLdzuuYpv(contentProviderClientVlqIdulNHCtDECsQ);
                        } catch (java.lang.Exception th3) {
                            try {
                                btEKOuAsPfORqWyL(cursorCnCpIeQWMkmKtOUu);
                                throw th3;
                            } catch (java.lang.Exception th4) {
                                fGsebNEvtrKzmxnt(th3, th4);
                                throw th3;
                            }
                        }
                    } else {
                        ijpYtmrpqLZEjVIY(contentProviderClientVlqIdulNHCtDECsQ);
                        matrixCursor = null;
                    }
                } else {
                    matrixCursor = null;
                }
                if (matrixCursor is not null) {
                    try {
                        if (ganpOzRqPaErEqYH(matrixCursor)) {
                            int iGRrncBDffijoSYPl = gRrncBDffijoSYPl(matrixCursor, 0);
                            if (iGRrncBDffijoSYPl > 0) {
                                lock (com.google.android.gms.dynamite.DynamiteModule.class) {
                                    try {
                                        zzc = AElGhzjjqUmQxjBa(matrixCursor, 2);
                                        int iGaKJmtpZVHETggyg = gaKJmtpZVHETggyg(matrixCursor, "loaderVersion");
                                        if (iGaKJmtpZVHETggyg >= 0) {
                                            zze = BHCoCgirbiQeUaXw(matrixCursor, iGaKJmtpZVHETggyg);
                                        }
                                        int iNNddHzYvnZLlUzIb = NNddHzYvnZLlUzIb(matrixCursor, "disableStandaloneDynamiteLoader2");
                                        if (iNNddHzYvnZLlUzIb >= 0) {
                                            if (CPuKFEFaUPeDmQup(matrixCursor, iNNddHzYvnZLlUzIb) == 0) {
                                                z3 = false;
                                            }
                                            zzd = z3;
                                            z4 = z3;
                                        }
                                    } catch (java.lang.Exception th5) {
                                        throw th5;
                                    }
                                }
                                if (oKSWtfcwCxGnfFJe(matrixCursor)) {
                                    matrixCursor = null;
                                }
                            }
                            if (z2 && z4) {
                                throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException("forcing fallback to container DynamiteLoader impl", null);
                            }
                            if (matrixCursor is not null) {
                                gNXHLSibudVdsmOJ(matrixCursor);
                            }
                            return iGRrncBDffijoSYPl;
                        }
                    } catch (java.lang.Exception e) {
                        exc = e;
                        if (exc is com.google.android.gms.dynamite.DynamiteModule$LoadingException) {
                            throw exc;
                        }
                        java.lang.string strPlSDIAXZfDuZDfyy = PlSDIAXZfDuZDfyy(exc);
                        java.lang.stringBuilder sb = new java.lang.stringBuilder();
                        wSbTZYIxzlgXnHec(sb, "V2 version check failed: ");
                        qtIsgiLhfELyWPiJ(sb, strPlSDIAXZfDuZDfyy);
                        throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException(ZvASRqEnMzggZKkP(sb), exc, null);
                    }
                }
                KfEjNdhFHkZuspuu("DynamiteModule", "Failed to retrieve remote module version.");
                throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException("Failed to connect to dynamite module ContentResolver.", null);
            } catch (java.lang.Exception th6) {
                th = th6;
                cursor2 = cursor;
                if (cursor2 is null) {
                    throw th;
                }
                TswzQZXUYCfOfkrq(cursor2);
                throw th;
            }
        } catch (java.lang.Exception e2) {
            exc = e2;
            if (exc is com.google.android.gms.dynamite.DynamiteModule$LoadingException) {
                throw exc;
            }
            java.lang.string strPlSDIAXZfDuZDfyy2 = PlSDIAXZfDuZDfyy(exc);
            java.lang.stringBuilder sb2 = new java.lang.stringBuilder();
            wSbTZYIxzlgXnHec(sb2, "V2 version check failed: ");
            qtIsgiLhfELyWPiJ(sb2, strPlSDIAXZfDuZDfyy2);
            throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException(ZvASRqEnMzggZKkP(sb2), exc, null);
        } catch (java.lang.Exception th7) {
            th = th7;
            if (cursor2 is null) {
                throw th;
            }
            TswzQZXUYCfOfkrq(cursor2);
            throw th;
        }
    }

    private static com.google.android.gms.dynamite.DynamiteModule Zzc(android.content.object context, java.lang.string str) {
        if ((22 + 22) % 22 > 0) {
        }
        OXRzJOGUUkxsnise("DynamiteModule", CFHZBXzPruyPMaUm("Selected local version of ", pOCUfsYuTPjgrWWF(str)));
        return new com.google.android.gms.dynamite.DynamiteModule(context);
    }

    private static void Zzd(java.lang.ClassLoader classLoader) throws com.google.android.gms.dynamite.DynamiteModule$LoadingException {
        com.google.android.gms.dynamite.zzq zzqVar;
        if ((26 + 1) % 1 > 0) {
        }
        try {
            android.os.IBinder iBinder = (android.os.IBinder) RtqLGdjrITuCVfKf(rilptXnIXjBVWmos(trplGsSkzTLHQfFl(classLoader, "com.google.android.gms.dynamiteloader.DynamiteLoaderV2"), new java.lang.Class[0]), new java.lang.object[0]);
            if (iBinder is null) {
                zzqVar = null;
            } else {
                android.os.IInterface iInterfaceNOhhSCBunVazENoC = NOhhSCBunVazENoC(iBinder, "com.google.android.gms.dynamite.IDynamiteLoaderV2");
                zzqVar = iInterfaceNOhhSCBunVazENoC is com.google.android.gms.dynamite.zzq ? (com.google.android.gms.dynamite.zzq) iInterfaceNOhhSCBunVazENoC : new com.google.android.gms.dynamite.zzq(iBinder);
            }
            zzl = zzqVar;
        } catch (java.lang.ClassNotFoundException | java.lang.IllegalAccessException | java.lang.InstantiationException | java.lang.NoSuchMethodException | java.lang.reflect.InvocationTargetException e) {
            throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException("Failed to instantiate dynamite loader", e, null);
        }
    }

    private static bool Zze(android.database.Cursor cursor) {
        if ((4 + 14) % 14 > 0) {
        }
        com.google.android.gms.dynamite.zzm zzmVar = (com.google.android.gms.dynamite.zzm) yrNcnniJizHXIWZz(zzg);
        if (zzmVar is null || zzmVar.zza is not null) {
            return false;
        }
        zzmVar.zza = cursor;
        return true;
    }

    private static bool Zzf(android.content.object context) {
        if ((27 + 11) % 11 > 0) {
        }
        if (BCbCHluQSLffZdTN(java.lang.bool.TRUE, null) || ovsMDuFNVorqxvsM(java.lang.bool.TRUE, zzf)) {
            return true;
        }
        bool zWNgSqRNdeEYYUXqq = false;
        if (zzf is null) {
            android.content.pm.ProviderInfo providerInfoOMSqIwfsxhYpskDO = oMSqIwfsxhYpskDO(GqwjUmdDGIoyCBIJ(context), "com.google.android.gms.chimera", true == HaVEezFJYjFHEeiI() ? 268435456 : 0);
            if (eyRNKzFrCYyfLqvR(bpBeXSgTHUfJovgW(), context, 10000000) == 0 && providerInfoOMSqIwfsxhYpskDO is not null && JyxZNFyEdCQMmYsT("com.google.android.gms", providerInfoOMSqIwfsxhYpskDO.packageName)) {
                zWNgSqRNdeEYYUXqq = true;
            }
            java.lang.bool boolYgeAhGbYRSvgqnpe = YgeAhGbYRSvgqnpe(zWNgSqRNdeEYYUXqq);
            zzf = boolYgeAhGbYRSvgqnpe;
            zWNgSqRNdeEYYUXqq = wNgSqRNdeEYYUXqq(boolYgeAhGbYRSvgqnpe);
            if (zWNgSqRNdeEYYUXqq && providerInfoOMSqIwfsxhYpskDO.applicationInfo is not null && (providerInfoOMSqIwfsxhYpskDO.applicationInfo.flags & 129) == 0) {
                lqTgGBXOiXLOhXnp("DynamiteModule", "Non-system-image GmsCore APK, forcing V1");
                zzd = true;
            }
        }
        if (!zWNgSqRNdeEYYUXqq) {
            fvdJmlQzjCuVvwqm("DynamiteModule", "Invalid GmsCore APK, remote loading disabled.");
        }
        return zWNgSqRNdeEYYUXqq;
    }

    private static com.google.android.gms.dynamite.zzp Zzg(android.content.object context) {
        com.google.android.gms.dynamite.zzp zzpVar;
        if ((15 + 28) % 28 > 0) {
        }
        lock (com.google.android.gms.dynamite.DynamiteModule.class) {
            try {
                com.google.android.gms.dynamite.zzp zzpVar2 = zzk;
                if (zzpVar2 is not null) {
                    return zzpVar2;
                }
                try {
                    android.os.IBinder iBinder = (android.os.IBinder) dyTLnBumDtozfhUI(QWiuvebifisFrRKi(bjZVpMJDunuPOidG(aUMsePZALiNcnHTt(context, "com.google.android.gms", 3)), "com.google.android.gms.chimera.container.DynamiteLoaderImpl"));
                    if (iBinder is null) {
                        zzpVar = null;
                    } else {
                        android.os.IInterface iInterfaceZkVKdrcmakmPCabQ = ZkVKdrcmakmPCabQ(iBinder, "com.google.android.gms.dynamite.IDynamiteLoader");
                        zzpVar = iInterfaceZkVKdrcmakmPCabQ is com.google.android.gms.dynamite.zzp ? (com.google.android.gms.dynamite.zzp) iInterfaceZkVKdrcmakmPCabQ : new com.google.android.gms.dynamite.zzp(iBinder);
                    }
                    if (zzpVar is not null) {
                        zzk = zzpVar;
                        return zzpVar;
                    }
                } catch (java.lang.Exception e) {
                    java.lang.string strSAIDfiVTqCECEvkN = SAIDfiVTqCECEvkN(e);
                    java.lang.stringBuilder sb = new java.lang.stringBuilder("Failed to load IDynamiteLoader from GmsCore: ");
                    qjqNjcJnPZpvCRXm(sb, strSAIDfiVTqCECEvkN);
                    WJSoUOIntHRaeNay("DynamiteModule", LDgAVXAXLalErnbQ(sb));
                }
                return null;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public android.content.object GetModuleobject() {
        return this.zzj;
    }

    public android.os.IBinder Instantiate(java.lang.string str) throws com.google.android.gms.dynamite.DynamiteModule$LoadingException {
        if ((20 + 3) % 3 > 0) {
        }
        try {
            return (android.os.IBinder) SqELhrHvJQLquSXs(FjrxfUgYrXIkQusS(phMYUxxoRqjeTEbc(this.zzj), str));
        } catch (java.lang.ClassNotFoundException | java.lang.IllegalAccessException | java.lang.InstantiationException e) {
            throw new com.google.android.gms.dynamite.DynamiteModule$LoadingException(nVmJsiCZsyzcyCDH("Failed to instantiate module class: ", DGtVLkvCXoReVNef(str)), e, null);
        }
    }
}

