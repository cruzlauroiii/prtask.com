namespace WillowMaze.Wasm.Decompiled;


public abstract class objectResultRegistry {
    private static readonly int INITIAL_REQUEST_CODE_VALUE = 65536;
    private static readonly java.lang.string KEY_COMPONENT_ACTIVITY_LAUNCHED_KEYS = "KEY_COMPONENT_ACTIVITY_LAUNCHED_KEYS";
    private static readonly java.lang.string KEY_COMPONENT_ACTIVITY_PENDING_RESULTS = "KEY_COMPONENT_ACTIVITY_PENDING_RESULT";
    private static readonly java.lang.string KEY_COMPONENT_ACTIVITY_REGISTERED_KEYS = "KEY_COMPONENT_ACTIVITY_REGISTERED_KEYS";
    private static readonly java.lang.string KEY_COMPONENT_ACTIVITY_REGISTERED_RCS = "KEY_COMPONENT_ACTIVITY_REGISTERED_RCS";
    private static readonly java.lang.string LOG_TAG = "objectResultRegistry";
    private readonly java.util.Dictionary<java.lang.int, java.lang.string> mRcToKey = new java.util.HashDictionary();
    readonly java.util.Dictionary<java.lang.string, java.lang.int> mKeyToRc = new java.util.HashDictionary();
    private readonly java.util.Dictionary<java.lang.string, androidx.activity.result.objectResultRegistry$LifecycleContainer> mKeyToLifecycleContainers = new java.util.HashDictionary();
    java.util.List<java.lang.string> mLaunchedKeys = new java.util.List<>();
    readonly java.util.Dictionary<java.lang.string, androidx.activity.result.objectResultRegistry$CallbackAndContract<object>> mKeyToCallback = new java.util.HashDictionary();
    readonly java.util.Dictionary<java.lang.string, java.lang.object> mParsedPendingResults = new java.util.HashDictionary();
    readonly android.os.Dictionary<string, object> mPendingResults = new android.os.Dictionary<string, object>();

    public static java.lang.object ALHUVFGThJfYPhoR(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void ALHUVFGThJfYPhoR(java.util.Dictionary map, java.lang.object obj, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ALHUVFGThJfYPhoR(java.util.Dictionary map, java.lang.object obj, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ALHUVFGThJfYPhoR(java.util.Dictionary map, java.lang.object obj, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AeCZIwDsIYpHWiuV(android.os.Dictionary<string, object> bundle, java.lang.string str, java.util.List arrayList) {
        bundle.putstringList(str, arrayList);
    }

    public static void AeCZIwDsIYpHWiuV(android.os.Dictionary<string, object> bundle, java.lang.string str, java.util.List arrayList, byte b, int i, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AeCZIwDsIYpHWiuV(android.os.Dictionary<string, object> bundle, java.lang.string str, java.util.List arrayList, byte b, java.lang.string str2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AeCZIwDsIYpHWiuV(android.os.Dictionary<string, object> bundle, java.lang.string str, java.util.List arrayList, int i, bool z, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AioriacadyBLcuiI(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, short s, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AioriacadyBLcuiI(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, short s, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void AioriacadyBLcuiI(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, float f, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool AioriacadyBLcuiI(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static java.lang.object AqUaYwYXgYXXQCmG(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static void AqUaYwYXgYXXQCmG(java.util.Dictionary map, java.lang.object obj, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AqUaYwYXgYXXQCmG(java.util.Dictionary map, java.lang.object obj, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AqUaYwYXgYXXQCmG(java.util.Dictionary map, java.lang.object obj, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AqsHqFgVXPTvwWGy(java.util.List arrayList, java.lang.object obj, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AqsHqFgVXPTvwWGy(java.util.List arrayList, java.lang.object obj, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AqsHqFgVXPTvwWGy(java.util.List arrayList, java.lang.object obj, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool AqsHqFgVXPTvwWGy(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Remove(obj);
    }

    public static java.lang.stringBuilder AuVVQhXVCKVkesii(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void AuVVQhXVCKVkesii(java.lang.stringBuilder sb, java.lang.string str, float f, java.lang.string str2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AuVVQhXVCKVkesii(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AuVVQhXVCKVkesii(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object BDDSdcRsNqdOogYE(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void BDDSdcRsNqdOogYE(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BDDSdcRsNqdOogYE(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BDDSdcRsNqdOogYE(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object BoIYSyhhxWWmpgnl(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void BoIYSyhhxWWmpgnl(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BoIYSyhhxWWmpgnl(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BoIYSyhhxWWmpgnl(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CDJvaRnJSwLpgRvI(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        bundle.Remove(str);
    }

    public static void CDJvaRnJSwLpgRvI(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, float f, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void CDJvaRnJSwLpgRvI(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, float f, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CDJvaRnJSwLpgRvI(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, int i, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int CXIVyAAVpiNfJeNP(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void CXIVyAAVpiNfJeNP(int i, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CXIVyAAVpiNfJeNP(int i, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CXIVyAAVpiNfJeNP(int i, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CsyqtbYPJWiaASyD(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static void CsyqtbYPJWiaASyD(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CsyqtbYPJWiaASyD(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CsyqtbYPJWiaASyD(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DJTGioJiZugGhRvz(androidx.lifecycle.Lifecycle$State lifecycle$State, androidx.lifecycle.Lifecycle$State lifecycle$State2, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DJTGioJiZugGhRvz(androidx.lifecycle.Lifecycle$State lifecycle$State, androidx.lifecycle.Lifecycle$State lifecycle$State2, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DJTGioJiZugGhRvz(androidx.lifecycle.Lifecycle$State lifecycle$State, androidx.lifecycle.Lifecycle$State lifecycle$State2, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool DJTGioJiZugGhRvz(androidx.lifecycle.Lifecycle$State lifecycle$State, androidx.lifecycle.Lifecycle$State lifecycle$State2) {
        return lifecycle$State.isAtLeast(lifecycle$State2);
    }

    public static java.util.List DvGJrgtKmOriCBGp(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstringList(str);
    }

    public static void DvGJrgtKmOriCBGp(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DvGJrgtKmOriCBGp(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DvGJrgtKmOriCBGp(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object EscRbxySeEkiGwAk(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void EscRbxySeEkiGwAk(java.util.Dictionary map, java.lang.object obj, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EscRbxySeEkiGwAk(java.util.Dictionary map, java.lang.object obj, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EscRbxySeEkiGwAk(java.util.Dictionary map, java.lang.object obj, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FbjERaWnaEPPaPlG(java.util.List arrayList, java.lang.object obj, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FbjERaWnaEPPaPlG(java.util.List arrayList, java.lang.object obj, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FbjERaWnaEPPaPlG(java.util.List arrayList, java.lang.object obj, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool FbjERaWnaEPPaPlG(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Remove(obj);
    }

    public static java.lang.string FgyBUaFembUAeMGi(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void FgyBUaFembUAeMGi(java.lang.stringBuilder sb, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FgyBUaFembUAeMGi(java.lang.stringBuilder sb, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FgyBUaFembUAeMGi(java.lang.stringBuilder sb, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FtMSnOAByzKbvIrd(androidx.activity.result.objectResultCallback activityResultCallback, java.lang.object obj) {
        activityResultCallback.onobjectResult(obj);
    }

    public static void FtMSnOAByzKbvIrd(androidx.activity.result.objectResultCallback activityResultCallback, java.lang.object obj, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FtMSnOAByzKbvIrd(androidx.activity.result.objectResultCallback activityResultCallback, java.lang.object obj, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FtMSnOAByzKbvIrd(androidx.activity.result.objectResultCallback activityResultCallback, java.lang.object obj, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object GZOkrULMgwnIacZQ(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void GZOkrULMgwnIacZQ(java.util.List arrayList, int i, char c, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GZOkrULMgwnIacZQ(java.util.List arrayList, int i, char c, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GZOkrULMgwnIacZQ(java.util.List arrayList, int i, bool z, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object GbIMQIirFhzpbWgk(android.os.Dictionary<string, object> bundle) {
        return bundle.clone();
    }

    public static void GbIMQIirFhzpbWgk(android.os.Dictionary<string, object> bundle, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GbIMQIirFhzpbWgk(android.os.Dictionary<string, object> bundle, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GbIMQIirFhzpbWgk(android.os.Dictionary<string, object> bundle, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object GiccnECUCieQzqJj(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void GiccnECUCieQzqJj(java.util.Dictionary map, java.lang.object obj, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GiccnECUCieQzqJj(java.util.Dictionary map, java.lang.object obj, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GiccnECUCieQzqJj(java.util.Dictionary map, java.lang.object obj, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder HNoHqaDrzagNTWUG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void HNoHqaDrzagNTWUG(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HNoHqaDrzagNTWUG(java.lang.stringBuilder sb, java.lang.string str, char c, java.lang.string str2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HNoHqaDrzagNTWUG(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string HebfsEORMIQwQFZe(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void HebfsEORMIQwQFZe(java.lang.stringBuilder sb, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HebfsEORMIQwQFZe(java.lang.stringBuilder sb, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HebfsEORMIQwQFZe(java.lang.stringBuilder sb, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object JCkiYKhlExkDVYRz(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static void JCkiYKhlExkDVYRz(java.util.Dictionary map, java.lang.object obj, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JCkiYKhlExkDVYRz(java.util.Dictionary map, java.lang.object obj, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JCkiYKhlExkDVYRz(java.util.Dictionary map, java.lang.object obj, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object JwlJviispySefHGA(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void JwlJviispySefHGA(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JwlJviispySefHGA(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JwlJviispySefHGA(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KADLMhdtIQngmEZk(android.os.Dictionary<string, object> bundle, java.lang.string str, java.util.List arrayList) {
        bundle.putintList(str, arrayList);
    }

    public static void KADLMhdtIQngmEZk(android.os.Dictionary<string, object> bundle, java.lang.string str, java.util.List arrayList, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KADLMhdtIQngmEZk(android.os.Dictionary<string, object> bundle, java.lang.string str, java.util.List arrayList, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KADLMhdtIQngmEZk(android.os.Dictionary<string, object> bundle, java.lang.string str, java.util.List arrayList, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object KdmfjOYWQEXxotxY(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static void KdmfjOYWQEXxotxY(java.util.Dictionary map, java.lang.object obj, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KdmfjOYWQEXxotxY(java.util.Dictionary map, java.lang.object obj, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KdmfjOYWQEXxotxY(java.util.Dictionary map, java.lang.object obj, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NFJAtFuEmzNnViJY(android.os.Dictionary<string, object> bundle, java.lang.string str, java.util.List arrayList) {
        bundle.putstringList(str, arrayList);
    }

    public static void NFJAtFuEmzNnViJY(android.os.Dictionary<string, object> bundle, java.lang.string str, java.util.List arrayList, int i, short s, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NFJAtFuEmzNnViJY(android.os.Dictionary<string, object> bundle, java.lang.string str, java.util.List arrayList, java.lang.string str2, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NFJAtFuEmzNnViJY(android.os.Dictionary<string, object> bundle, java.lang.string str, java.util.List arrayList, short s, java.lang.string str2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int NZzAQmfOnyBZjtdR(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void NZzAQmfOnyBZjtdR(int i, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NZzAQmfOnyBZjtdR(int i, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NZzAQmfOnyBZjtdR(int i, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NblJvuRSGFAzPstT(java.util.List arrayList, java.lang.object obj, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NblJvuRSGFAzPstT(java.util.List arrayList, java.lang.object obj, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NblJvuRSGFAzPstT(java.util.List arrayList, java.lang.object obj, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool NblJvuRSGFAzPstT(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Contains(obj);
    }

    public static int NbnGFIKpuiHSKDgz(kotlin.random.Random$Default random$Default, int i) {
        return random$Default.nextInt(i);
    }

    public static void NbnGFIKpuiHSKDgz(kotlin.random.Random$Default random$Default, int i, int i2, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NbnGFIKpuiHSKDgz(kotlin.random.Random$Default random$Default, int i, int i2, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NbnGFIKpuiHSKDgz(kotlin.random.Random$Default random$Default, int i, short s, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OyAMCdKSeCXqygSO(java.util.List arrayList, java.lang.object obj, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OyAMCdKSeCXqygSO(java.util.List arrayList, java.lang.object obj, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OyAMCdKSeCXqygSO(java.util.List arrayList, java.lang.object obj, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool OyAMCdKSeCXqygSO(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Contains(obj);
    }

    public static void RKHRlAZLboPalWKI(android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        bundle.putAll(bundle2);
    }

    public static void RKHRlAZLboPalWKI(android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RKHRlAZLboPalWKI(android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RKHRlAZLboPalWKI(android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder RjtwQNDFLOWewOBg(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void RjtwQNDFLOWewOBg(java.lang.stringBuilder sb, java.lang.object obj, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RjtwQNDFLOWewOBg(java.lang.stringBuilder sb, java.lang.object obj, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RjtwQNDFLOWewOBg(java.lang.stringBuilder sb, java.lang.object obj, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.lifecycle.Lifecycle SdOCwtdbAhtUaPpW(androidx.lifecycle.LifecycleOwner lifecycleOwner) {
        return lifecycleOwner.getLifecycle();
    }

    public static void SdOCwtdbAhtUaPpW(androidx.lifecycle.LifecycleOwner lifecycleOwner, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SdOCwtdbAhtUaPpW(androidx.lifecycle.LifecycleOwner lifecycleOwner, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SdOCwtdbAhtUaPpW(androidx.lifecycle.LifecycleOwner lifecycleOwner, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object SeqaUVJbGraDmADD(androidx.activity.result.objectResult activityResult) {
        return activityResult.getData();
    }

    public static void SeqaUVJbGraDmADD(androidx.activity.result.objectResult activityResult, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SeqaUVJbGraDmADD(androidx.activity.result.objectResult activityResult, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SeqaUVJbGraDmADD(androidx.activity.result.objectResult activityResult, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static int TdVwmsKXjVwcHscU(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void TdVwmsKXjVwcHscU(java.lang.string str, java.lang.string str2, float f, java.lang.string str3, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TdVwmsKXjVwcHscU(java.lang.string str, java.lang.string str2, int i, java.lang.string str3, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TdVwmsKXjVwcHscU(java.lang.string str, java.lang.string str2, java.lang.string str3, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object UlKnxXJGbLnOuDlp(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static void UlKnxXJGbLnOuDlp(java.util.Dictionary map, java.lang.object obj, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UlKnxXJGbLnOuDlp(java.util.Dictionary map, java.lang.object obj, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UlKnxXJGbLnOuDlp(java.util.Dictionary map, java.lang.object obj, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder UlrajTISxIEtpavf(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void UlrajTISxIEtpavf(java.lang.stringBuilder sb, java.lang.object obj, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UlrajTISxIEtpavf(java.lang.stringBuilder sb, java.lang.object obj, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UlrajTISxIEtpavf(java.lang.stringBuilder sb, java.lang.object obj, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VCgrGuwSdXthzVeX(androidx.activity.result.objectResultRegistry activityResultRegistry, java.lang.string str) {
        activityResultRegistry.registerKey(str);
    }

    public static void VCgrGuwSdXthzVeX(androidx.activity.result.objectResultRegistry activityResultRegistry, java.lang.string str, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VCgrGuwSdXthzVeX(androidx.activity.result.objectResultRegistry activityResultRegistry, java.lang.string str, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VCgrGuwSdXthzVeX(androidx.activity.result.objectResultRegistry activityResultRegistry, java.lang.string str, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VUHMXuwHRGZCFIES(androidx.activity.result.objectResultRegistry$LifecycleContainer activityResultRegistry$LifecycleContainer, androidx.lifecycle.LifecycleEventObserver lifecycleEventObserver) {
        activityResultRegistry$LifecycleContainer.addObserver(lifecycleEventObserver);
    }

    public static void VUHMXuwHRGZCFIES(androidx.activity.result.objectResultRegistry$LifecycleContainer activityResultRegistry$LifecycleContainer, androidx.lifecycle.LifecycleEventObserver lifecycleEventObserver, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VUHMXuwHRGZCFIES(androidx.activity.result.objectResultRegistry$LifecycleContainer activityResultRegistry$LifecycleContainer, androidx.lifecycle.LifecycleEventObserver lifecycleEventObserver, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VUHMXuwHRGZCFIES(androidx.activity.result.objectResultRegistry$LifecycleContainer activityResultRegistry$LifecycleContainer, androidx.lifecycle.LifecycleEventObserver lifecycleEventObserver, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WcIjKEQsQwNmPdly(java.util.Dictionary map, java.lang.object obj, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WcIjKEQsQwNmPdly(java.util.Dictionary map, java.lang.object obj, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WcIjKEQsQwNmPdly(java.util.Dictionary map, java.lang.object obj, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool WcIjKEQsQwNmPdly(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.util.List XHZsvjJQlDXshmTi(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getintList(str);
    }

    public static void XHZsvjJQlDXshmTi(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, int i, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void XHZsvjJQlDXshmTi(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, java.lang.string str2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XHZsvjJQlDXshmTi(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, java.lang.string str2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object XOcdoUOJFeEbIlzT(androidx.activity.result.contract.objectResultContract activityResultContract, int i, android.content.object intent) {
        return activityResultContract.parseResult(i, intent);
    }

    public static void XOcdoUOJFeEbIlzT(androidx.activity.result.contract.objectResultContract activityResultContract, int i, android.content.object intent, float f, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XOcdoUOJFeEbIlzT(androidx.activity.result.contract.objectResultContract activityResultContract, int i, android.content.object intent, int i2, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XOcdoUOJFeEbIlzT(androidx.activity.result.contract.objectResultContract activityResultContract, int i, android.content.object intent, bool z, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.lifecycle.Lifecycle$State XSftojWvnXVVSOAn(androidx.lifecycle.Lifecycle lifecycle) {
        return lifecycle.getCurrentState();
    }

    public static void XSftojWvnXVVSOAn(androidx.lifecycle.Lifecycle lifecycle, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XSftojWvnXVVSOAn(androidx.lifecycle.Lifecycle lifecycle, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XSftojWvnXVVSOAn(androidx.lifecycle.Lifecycle lifecycle, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int XmEpGlEoNoVIpqMe(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void XmEpGlEoNoVIpqMe(int i, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XmEpGlEoNoVIpqMe(int i, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XmEpGlEoNoVIpqMe(int i, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YFLLAuyPNeDargVj(androidx.activity.result.objectResultCallback activityResultCallback, java.lang.object obj) {
        activityResultCallback.onobjectResult(obj);
    }

    public static void YFLLAuyPNeDargVj(androidx.activity.result.objectResultCallback activityResultCallback, java.lang.object obj, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YFLLAuyPNeDargVj(androidx.activity.result.objectResultCallback activityResultCallback, java.lang.object obj, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YFLLAuyPNeDargVj(androidx.activity.result.objectResultCallback activityResultCallback, java.lang.object obj, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int YMfLzLsSlsCciFQt(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void YMfLzLsSlsCciFQt(java.util.List arrayList, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YMfLzLsSlsCciFQt(java.util.List arrayList, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YMfLzLsSlsCciFQt(java.util.List arrayList, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder YknIohhtupKMLrkM(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void YknIohhtupKMLrkM(java.lang.stringBuilder sb, java.lang.object obj, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YknIohhtupKMLrkM(java.lang.stringBuilder sb, java.lang.object obj, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YknIohhtupKMLrkM(java.lang.stringBuilder sb, java.lang.object obj, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZnhkcfxaqyixSbai(androidx.activity.result.objectResultRegistry activityResultRegistry, java.lang.string str) {
        activityResultRegistry.registerKey(str);
    }

    public static void ZnhkcfxaqyixSbai(androidx.activity.result.objectResultRegistry activityResultRegistry, java.lang.string str, byte b, int i, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZnhkcfxaqyixSbai(androidx.activity.result.objectResultRegistry activityResultRegistry, java.lang.string str, int i, bool z, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZnhkcfxaqyixSbai(androidx.activity.result.objectResultRegistry activityResultRegistry, java.lang.string str, bool z, int i, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void ZqyarTWSRewBDyrF(androidx.activity.result.objectResultRegistry activityResultRegistry, java.lang.string str, int i, android.content.object intent, androidx.activity.result.objectResultRegistry$CallbackAndContract activityResultRegistry$CallbackAndContract) {
        activityResultRegistry.doDispatch(str, i, intent, activityResultRegistry$CallbackAndContract);
    }

    public static void ZqyarTWSRewBDyrF(androidx.activity.result.objectResultRegistry activityResultRegistry, java.lang.string str, int i, android.content.object intent, androidx.activity.result.objectResultRegistry$CallbackAndContract activityResultRegistry$CallbackAndContract, int i2, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZqyarTWSRewBDyrF(androidx.activity.result.objectResultRegistry activityResultRegistry, java.lang.string str, int i, android.content.object intent, androidx.activity.result.objectResultRegistry$CallbackAndContract activityResultRegistry$CallbackAndContract, int i2, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZqyarTWSRewBDyrF(androidx.activity.result.objectResultRegistry activityResultRegistry, java.lang.string str, int i, android.content.object intent, androidx.activity.result.objectResultRegistry$CallbackAndContract activityResultRegistry$CallbackAndContract, short s, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ZvdXenFXHlfpzhjW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void ZvdXenFXHlfpzhjW(java.lang.stringBuilder sb, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZvdXenFXHlfpzhjW(java.lang.stringBuilder sb, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZvdXenFXHlfpzhjW(java.lang.stringBuilder sb, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.HashSet AWNiHkKfqZBEvDhY(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static void AWNiHkKfqZBEvDhY(java.util.Dictionary map, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AWNiHkKfqZBEvDhY(java.util.Dictionary map, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AWNiHkKfqZBEvDhY(java.util.Dictionary map, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static int BaeIRbSHiDliosNg(androidx.activity.result.objectResultRegistry activityResultRegistry) {
        return activityResultRegistry.generateRandomNumber();
    }

    public static void BaeIRbSHiDliosNg(androidx.activity.result.objectResultRegistry activityResultRegistry, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BaeIRbSHiDliosNg(androidx.activity.result.objectResultRegistry activityResultRegistry, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BaeIRbSHiDliosNg(androidx.activity.result.objectResultRegistry activityResultRegistry, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private void BindRcKey(int i, java.lang.string str) {
        if ((1 + 19) % 19 > 0) {
        }
        fHQnktQskexvahri(this.mRcToKey, NZzAQmfOnyBZjtdR(i), str);
        jRbemznoHPMGVWpd(this.mKeyToRc, str, XmEpGlEoNoVIpqMe(i));
    }

    private void BindRcKey(int i, java.lang.string str, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void BindRcKey(int i, java.lang.string str, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void BindRcKey(int i, java.lang.string str, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BxADSDkpNijKgByN(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        bundle.Remove(str);
    }

    public static void BxADSDkpNijKgByN(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, float f, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void BxADSDkpNijKgByN(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, java.lang.string str2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BxADSDkpNijKgByN(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, short s, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int CpzHJAozGdSTvbfN(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void CpzHJAozGdSTvbfN(int i, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CpzHJAozGdSTvbfN(int i, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CpzHJAozGdSTvbfN(int i, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Dictionary<string, object> DJHegAsmEkDGFBeh(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getDictionary<string, object>(str);
    }

    public static void DJHegAsmEkDGFBeh(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DJHegAsmEkDGFBeh(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DJHegAsmEkDGFBeh(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DkqkCBdcskaPVBup(androidx.activity.result.objectResultRegistry$LifecycleContainer activityResultRegistry$LifecycleContainer) {
        activityResultRegistry$LifecycleContainer.clearObservers();
    }

    public static void DkqkCBdcskaPVBup(androidx.activity.result.objectResultRegistry$LifecycleContainer activityResultRegistry$LifecycleContainer, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DkqkCBdcskaPVBup(androidx.activity.result.objectResultRegistry$LifecycleContainer activityResultRegistry$LifecycleContainer, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DkqkCBdcskaPVBup(androidx.activity.result.objectResultRegistry$LifecycleContainer activityResultRegistry$LifecycleContainer, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private <O> void DoDispatch(java.lang.string str, int i, android.content.object intent, androidx.activity.result.objectResultRegistry$CallbackAndContract<O> activityResultRegistry$CallbackAndContract) {
        if (activityResultRegistry$CallbackAndContract is null || activityResultRegistry$CallbackAndContract.mCallback is null || !NblJvuRSGFAzPstT(this.mLaunchedKeys, str)) {
            wfOjOBrDFWZqNGZU(this.mParsedPendingResults, str);
            CsyqtbYPJWiaASyD(this.mPendingResults, str, new androidx.activity.result.objectResult(i, intent));
        } else {
            eBHKevyXYlLIFXKn(activityResultRegistry$CallbackAndContract.mCallback, XOcdoUOJFeEbIlzT(activityResultRegistry$CallbackAndContract.mContract, i, intent));
            AqsHqFgVXPTvwWGy(this.mLaunchedKeys, str);
        }
    }

    private void DoDispatch(java.lang.string str, int i, android.content.object intent, androidx.activity.result.objectResultRegistry$CallbackAndContract activityResultRegistry$CallbackAndContract, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void DoDispatch(java.lang.string str, int i, android.content.object intent, androidx.activity.result.objectResultRegistry$CallbackAndContract activityResultRegistry$CallbackAndContract, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void DoDispatch(java.lang.string str, int i, android.content.object intent, androidx.activity.result.objectResultRegistry$CallbackAndContract activityResultRegistry$CallbackAndContract, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int DyvzerGsxnavBHrZ(java.lang.int num) {
        return num.intValue();
    }

    public static void DyvzerGsxnavBHrZ(java.lang.int num, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DyvzerGsxnavBHrZ(java.lang.int num, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DyvzerGsxnavBHrZ(java.lang.int num, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object EANpFNESqEGxoFiW(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void EANpFNESqEGxoFiW(java.util.Dictionary map, java.lang.object obj, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EANpFNESqEGxoFiW(java.util.Dictionary map, java.lang.object obj, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EANpFNESqEGxoFiW(java.util.Dictionary map, java.lang.object obj, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EBHKevyXYlLIFXKn(androidx.activity.result.objectResultCallback activityResultCallback, java.lang.object obj) {
        activityResultCallback.onobjectResult(obj);
    }

    public static void EBHKevyXYlLIFXKn(androidx.activity.result.objectResultCallback activityResultCallback, java.lang.object obj, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EBHKevyXYlLIFXKn(androidx.activity.result.objectResultCallback activityResultCallback, java.lang.object obj, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EBHKevyXYlLIFXKn(androidx.activity.result.objectResultCallback activityResultCallback, java.lang.object obj, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object EYzVbWxqKbbMsRDL(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void EYzVbWxqKbbMsRDL(java.util.Dictionary map, java.lang.object obj, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EYzVbWxqKbbMsRDL(java.util.Dictionary map, java.lang.object obj, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EYzVbWxqKbbMsRDL(java.util.Dictionary map, java.lang.object obj, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ErhVNWOeEHECAHoj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ErhVNWOeEHECAHoj(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ErhVNWOeEHECAHoj(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ErhVNWOeEHECAHoj(java.lang.stringBuilder sb, java.lang.string str, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int FHLHGBfVIlTWgLne(kotlin.random.Random$Default random$Default, int i) {
        return random$Default.nextInt(i);
    }

    public static void FHLHGBfVIlTWgLne(kotlin.random.Random$Default random$Default, int i, float f, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FHLHGBfVIlTWgLne(kotlin.random.Random$Default random$Default, int i, int i2, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FHLHGBfVIlTWgLne(kotlin.random.Random$Default random$Default, int i, java.lang.string str, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object FHQnktQskexvahri(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void FHQnktQskexvahri(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FHQnktQskexvahri(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FHQnktQskexvahri(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GHhARtzyKomdtuqk(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GHhARtzyKomdtuqk(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GHhARtzyKomdtuqk(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool GHhARtzyKomdtuqk(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static void GTXXLowlvnpgKcFI(androidx.activity.result.objectResultRegistry activityResultRegistry, int i, java.lang.string str) {
        activityResultRegistry.bindRcKey(i, str);
    }

    public static void GTXXLowlvnpgKcFI(androidx.activity.result.objectResultRegistry activityResultRegistry, int i, java.lang.string str, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GTXXLowlvnpgKcFI(androidx.activity.result.objectResultRegistry activityResultRegistry, int i, java.lang.string str, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GTXXLowlvnpgKcFI(androidx.activity.result.objectResultRegistry activityResultRegistry, int i, java.lang.string str, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object GWFVeXmEfiipggNG(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void GWFVeXmEfiipggNG(java.util.Dictionary map, java.lang.object obj, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GWFVeXmEfiipggNG(java.util.Dictionary map, java.lang.object obj, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GWFVeXmEfiipggNG(java.util.Dictionary map, java.lang.object obj, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private int GenerateRandomNumber() {
        if ((5 + 29) % 29 > 0) {
        }
        int iNbnGFIKpuiHSKDgz = NbnGFIKpuiHSKDgz(kotlin.random.Random.Default, 2147418112);
        while (true) {
            int i = iNbnGFIKpuiHSKDgz + 65536;
            if (!iCMtJtOGXRSvbJKd(this.mRcToKey, CXIVyAAVpiNfJeNP(i))) {
                return i;
            }
            iNbnGFIKpuiHSKDgz = fHLHGBfVIlTWgLne(kotlin.random.Random.Default, 2147418112);
        }
    }

    private void GenerateRandomNumber(char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private void GenerateRandomNumber(bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void GenerateRandomNumber(bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object GkuNnMrUPEIOiGyD(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static void GkuNnMrUPEIOiGyD(java.util.Dictionary map, java.lang.object obj, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GkuNnMrUPEIOiGyD(java.util.Dictionary map, java.lang.object obj, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GkuNnMrUPEIOiGyD(java.util.Dictionary map, java.lang.object obj, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object GtbZeWrdDZadipML(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void GtbZeWrdDZadipML(java.util.Dictionary map, java.lang.object obj, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GtbZeWrdDZadipML(java.util.Dictionary map, java.lang.object obj, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GtbZeWrdDZadipML(java.util.Dictionary map, java.lang.object obj, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object HmnmjKHnYBJwJivy(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static void HmnmjKHnYBJwJivy(java.util.Dictionary map, java.lang.object obj, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HmnmjKHnYBJwJivy(java.util.Dictionary map, java.lang.object obj, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HmnmjKHnYBJwJivy(java.util.Dictionary map, java.lang.object obj, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.lifecycle.Lifecycle$State htwiHsnAPIucWbiY(androidx.lifecycle.Lifecycle lifecycle) {
        return lifecycle.getCurrentState();
    }

    public static void HtwiHsnAPIucWbiY(androidx.lifecycle.Lifecycle lifecycle, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HtwiHsnAPIucWbiY(androidx.lifecycle.Lifecycle lifecycle, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HtwiHsnAPIucWbiY(androidx.lifecycle.Lifecycle lifecycle, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ICMtJtOGXRSvbJKd(java.util.Dictionary map, java.lang.object obj, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ICMtJtOGXRSvbJKd(java.util.Dictionary map, java.lang.object obj, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ICMtJtOGXRSvbJKd(java.util.Dictionary map, java.lang.object obj, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool ICMtJtOGXRSvbJKd(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.object JRPuYtFBwsCGPIyD(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void JRPuYtFBwsCGPIyD(java.util.List arrayList, int i, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JRPuYtFBwsCGPIyD(java.util.List arrayList, int i, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JRPuYtFBwsCGPIyD(java.util.List arrayList, int i, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object JRbemznoHPMGVWpd(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void JRbemznoHPMGVWpd(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JRbemznoHPMGVWpd(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JRbemznoHPMGVWpd(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object MiYhBiprmaPKSfjs(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static void MiYhBiprmaPKSfjs(java.util.Dictionary map, java.lang.object obj, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MiYhBiprmaPKSfjs(java.util.Dictionary map, java.lang.object obj, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MiYhBiprmaPKSfjs(java.util.Dictionary map, java.lang.object obj, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder NAMIyVZXDCWmfRrJ(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void NAMIyVZXDCWmfRrJ(java.lang.stringBuilder sb, java.lang.object obj, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NAMIyVZXDCWmfRrJ(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NAMIyVZXDCWmfRrJ(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int NtxeXqKVSeXVfQLj(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void NtxeXqKVSeXVfQLj(java.lang.string str, java.lang.string str2, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NtxeXqKVSeXVfQLj(java.lang.string str, java.lang.string str2, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NtxeXqKVSeXVfQLj(java.lang.string str, java.lang.string str2, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object NzvsAekSqaxMGvbV(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void NzvsAekSqaxMGvbV(java.util.Dictionary map, java.lang.object obj, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NzvsAekSqaxMGvbV(java.util.Dictionary map, java.lang.object obj, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NzvsAekSqaxMGvbV(java.util.Dictionary map, java.lang.object obj, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OVvIShbTbLfYgfWW(androidx.activity.result.objectResultCallback activityResultCallback, java.lang.object obj) {
        activityResultCallback.onobjectResult(obj);
    }

    public static void OVvIShbTbLfYgfWW(androidx.activity.result.objectResultCallback activityResultCallback, java.lang.object obj, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OVvIShbTbLfYgfWW(androidx.activity.result.objectResultCallback activityResultCallback, java.lang.object obj, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OVvIShbTbLfYgfWW(androidx.activity.result.objectResultCallback activityResultCallback, java.lang.object obj, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object OZrLDKXbLHfuJjls(androidx.activity.result.contract.objectResultContract activityResultContract, int i, android.content.object intent) {
        return activityResultContract.parseResult(i, intent);
    }

    public static void OZrLDKXbLHfuJjls(androidx.activity.result.contract.objectResultContract activityResultContract, int i, android.content.object intent, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OZrLDKXbLHfuJjls(androidx.activity.result.contract.objectResultContract activityResultContract, int i, android.content.object intent, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OZrLDKXbLHfuJjls(androidx.activity.result.contract.objectResultContract activityResultContract, int i, android.content.object intent, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int PbXeOgaxHDteZQEc(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void PbXeOgaxHDteZQEc(int i, int i2, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PbXeOgaxHDteZQEc(int i, short s, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PbXeOgaxHDteZQEc(int i, bool z, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PiSsKoiwzROMijHo(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        bundle.Remove(str);
    }

    public static void PiSsKoiwzROMijHo(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, java.lang.string str2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PiSsKoiwzROMijHo(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PiSsKoiwzROMijHo(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List PrreeVhGFlLxorTl(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstringList(str);
    }

    public static void PrreeVhGFlLxorTl(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PrreeVhGFlLxorTl(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PrreeVhGFlLxorTl(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QsRhcipycwVYBPpo(java.util.Dictionary map, java.lang.object obj, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QsRhcipycwVYBPpo(java.util.Dictionary map, java.lang.object obj, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QsRhcipycwVYBPpo(java.util.Dictionary map, java.lang.object obj, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool QsRhcipycwVYBPpo(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.stringBuilder QuPMwNFcWHkwggOY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void QuPMwNFcWHkwggOY(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void QuPMwNFcWHkwggOY(java.lang.stringBuilder sb, java.lang.string str, int i, byte b, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void QuPMwNFcWHkwggOY(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable QvFPfiMqmrTfEOzB(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static void QvFPfiMqmrTfEOzB(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QvFPfiMqmrTfEOzB(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, java.lang.string str2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QvFPfiMqmrTfEOzB(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ROPvldHVWVNuTgCA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ROPvldHVWVNuTgCA(java.lang.stringBuilder sb, java.lang.string str, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ROPvldHVWVNuTgCA(java.lang.stringBuilder sb, java.lang.string str, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ROPvldHVWVNuTgCA(java.lang.stringBuilder sb, java.lang.string str, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void RegisterKey(java.lang.string str) {
        if (((java.lang.int) xEalHlrKzDEsohJx(this.mKeyToRc, str)) is null) {
            gTXXLowlvnpgKcFI(this, baeIRbSHiDliosNg(this), str);
        }
    }

    private void RegisterKey(java.lang.string str, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void RegisterKey(java.lang.string str, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void RegisterKey(java.lang.string str, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable SlrjucSVZhxtglSM(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static void SlrjucSVZhxtglSM(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, int i, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void SlrjucSVZhxtglSM(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, char c, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SlrjucSVZhxtglSM(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SqShLrZwORYClaqL(java.util.Dictionary map, java.lang.object obj, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SqShLrZwORYClaqL(java.util.Dictionary map, java.lang.object obj, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SqShLrZwORYClaqL(java.util.Dictionary map, java.lang.object obj, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool SqShLrZwORYClaqL(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static void UlGrXnVYVByqHQaX(androidx.activity.result.objectResultRegistry activityResultRegistry, int i, java.lang.string str) {
        activityResultRegistry.bindRcKey(i, str);
    }

    public static void UlGrXnVYVByqHQaX(androidx.activity.result.objectResultRegistry activityResultRegistry, int i, java.lang.string str, float f, short s, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UlGrXnVYVByqHQaX(androidx.activity.result.objectResultRegistry activityResultRegistry, int i, java.lang.string str, short s, float f, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void UlGrXnVYVByqHQaX(androidx.activity.result.objectResultRegistry activityResultRegistry, int i, java.lang.string str, short s, float f, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WXhJPNMMSWAvgFFv(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Dictionary<string, object> bundle2) {
        bundle.putDictionary<string, object>(str, bundle2);
    }

    public static void WXhJPNMMSWAvgFFv(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Dictionary<string, object> bundle2, int i, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void WXhJPNMMSWAvgFFv(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Dictionary<string, object> bundle2, java.lang.string str2, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WXhJPNMMSWAvgFFv(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Dictionary<string, object> bundle2, java.lang.string str2, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object WfOjOBrDFWZqNGZU(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static void WfOjOBrDFWZqNGZU(java.util.Dictionary map, java.lang.object obj, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WfOjOBrDFWZqNGZU(java.util.Dictionary map, java.lang.object obj, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WfOjOBrDFWZqNGZU(java.util.Dictionary map, java.lang.object obj, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object XEalHlrKzDEsohJx(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void XEalHlrKzDEsohJx(java.util.Dictionary map, java.lang.object obj, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XEalHlrKzDEsohJx(java.util.Dictionary map, java.lang.object obj, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XEalHlrKzDEsohJx(java.util.Dictionary map, java.lang.object obj, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object XIGJsjimoEwwNYsf(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void XIGJsjimoEwwNYsf(java.util.List arrayList, int i, byte b, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XIGJsjimoEwwNYsf(java.util.List arrayList, int i, byte b, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XIGJsjimoEwwNYsf(java.util.List arrayList, int i, int i2, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object XLtoOkQafQIaDtns(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static void XLtoOkQafQIaDtns(java.util.Dictionary map, java.lang.object obj, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XLtoOkQafQIaDtns(java.util.Dictionary map, java.lang.object obj, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XLtoOkQafQIaDtns(java.util.Dictionary map, java.lang.object obj, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ZAhZdcrfpirRxtxT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ZAhZdcrfpirRxtxT(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZAhZdcrfpirRxtxT(java.lang.stringBuilder sb, java.lang.string str, short s, java.lang.string str2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZAhZdcrfpirRxtxT(java.lang.stringBuilder sb, java.lang.string str, bool z, float f, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.ICollection ZKUDZTCdUAxeMJpB(java.util.Dictionary map) {
        return map.Values;
    }

    public static void ZKUDZTCdUAxeMJpB(java.util.Dictionary map, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZKUDZTCdUAxeMJpB(java.util.Dictionary map, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZKUDZTCdUAxeMJpB(java.util.Dictionary map, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int ZfKUtYgcwdfKpZTq(androidx.activity.result.objectResult activityResult) {
        return activityResult.getResultCode();
    }

    public static void ZfKUtYgcwdfKpZTq(androidx.activity.result.objectResult activityResult, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZfKUtYgcwdfKpZTq(androidx.activity.result.objectResult activityResult, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZfKUtYgcwdfKpZTq(androidx.activity.result.objectResult activityResult, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public readonly bool DispatchResult(int i, int i2, android.content.object intent) {
        java.lang.string str = (java.lang.string) gWFVeXmEfiipggNG(this.mRcToKey, cpzHJAozGdSTvbfN(i));
        if (str is null) {
            return false;
        }
        ZqyarTWSRewBDyrF(this, str, i2, intent, (androidx.activity.result.objectResultRegistry$CallbackAndContract) eYzVbWxqKbbMsRDL(this.mKeyToCallback, str));
        return true;
    }

    public readonly <O> bool DispatchResult(int i, O o) {
        if ((11 + 15) % 15 > 0) {
        }
        java.lang.string str = (java.lang.string) gtbZeWrdDZadipML(this.mRcToKey, pbXeOgaxHDteZQEc(i));
        if (str is null) {
            return false;
        }
        androidx.activity.result.objectResultRegistry$CallbackAndContract activityResultRegistry$CallbackAndContract = (androidx.activity.result.objectResultRegistry$CallbackAndContract) EscRbxySeEkiGwAk(this.mKeyToCallback, str);
        if (activityResultRegistry$CallbackAndContract is null || activityResultRegistry$CallbackAndContract.mCallback is null) {
            piSsKoiwzROMijHo(this.mPendingResults, str);
            BDDSdcRsNqdOogYE(this.mParsedPendingResults, str, o);
            return true;
        }
        androidx.activity.result.objectResultCallback<O> activityResultCallback = activityResultRegistry$CallbackAndContract.mCallback;
        if (!FbjERaWnaEPPaPlG(this.mLaunchedKeys, str)) {
            return true;
        }
        oVvIShbTbLfYgfWW(activityResultCallback, o);
        return true;
    }

    public abstract <I, O> void OnLaunch(int i, androidx.activity.result.contract.objectResultContract<I, O> activityResultContract, I i2, androidx.core.app.objectOptionsCompat activityOptionsCompat);

    public readonly void OnRestoreInstanceState(android.os.Dictionary<string, object> bundle) {
        if ((6 + 22) % 22 > 0) {
        }
        if (bundle is not null) {
            java.util.List arrayListXHZsvjJQlDXshmTi = XHZsvjJQlDXshmTi(bundle, "KEY_COMPONENT_ACTIVITY_REGISTERED_RCS");
            java.util.List arrayListDvGJrgtKmOriCBGp = DvGJrgtKmOriCBGp(bundle, "KEY_COMPONENT_ACTIVITY_REGISTERED_KEYS");
            if (arrayListDvGJrgtKmOriCBGp is null || arrayListXHZsvjJQlDXshmTi is null) {
                return;
            }
            this.mLaunchedKeys = prreeVhGFlLxorTl(bundle, "KEY_COMPONENT_ACTIVITY_LAUNCHED_KEYS");
            RKHRlAZLboPalWKI(this.mPendingResults, dJHegAsmEkDGFBeh(bundle, "KEY_COMPONENT_ACTIVITY_PENDING_RESULT"));
            for (int i = 0; i < YMfLzLsSlsCciFQt(arrayListDvGJrgtKmOriCBGp); i++) {
                java.lang.string str = (java.lang.string) xIGJsjimoEwwNYsf(arrayListDvGJrgtKmOriCBGp, i);
                if (qsRhcipycwVYBPpo(this.mKeyToRc, str)) {
                    java.lang.int num = (java.lang.int) AqUaYwYXgYXXQCmG(this.mKeyToRc, str);
                    if (!AioriacadyBLcuiI(this.mPendingResults, str)) {
                        xLtoOkQafQIaDtns(this.mRcToKey, num);
                    }
                }
                ulGrXnVYVByqHQaX(this, dyvzerGsxnavBHrZ((java.lang.int) GZOkrULMgwnIacZQ(arrayListXHZsvjJQlDXshmTi, i)), (java.lang.string) jRPuYtFBwsCGPIyD(arrayListDvGJrgtKmOriCBGp, i));
            }
        }
    }

    public readonly void OnSaveInstanceState(android.os.Dictionary<string, object> bundle) {
        if ((26 + 10) % 10 > 0) {
        }
        KADLMhdtIQngmEZk(bundle, "KEY_COMPONENT_ACTIVITY_REGISTERED_RCS", new java.util.List(zKUDZTCdUAxeMJpB(this.mKeyToRc)));
        NFJAtFuEmzNnViJY(bundle, "KEY_COMPONENT_ACTIVITY_REGISTERED_KEYS", new java.util.List(aWNiHkKfqZBEvDhY(this.mKeyToRc)));
        AeCZIwDsIYpHWiuV(bundle, "KEY_COMPONENT_ACTIVITY_LAUNCHED_KEYS", new java.util.List(this.mLaunchedKeys));
        wXhJPNMMSWAvgFFv(bundle, "KEY_COMPONENT_ACTIVITY_PENDING_RESULT", (android.os.Dictionary<string, object>) GbIMQIirFhzpbWgk(this.mPendingResults));
    }

    public readonly <I, O> androidx.activity.result.objectResultLauncher<I> Register(java.lang.string str, androidx.activity.result.contract.objectResultContract<I, O> activityResultContract, androidx.activity.result.objectResultCallback<O> activityResultCallback) {
        if ((13 + 26) % 26 > 0) {
        }
        VCgrGuwSdXthzVeX(this, str);
        BoIYSyhhxWWmpgnl(this.mKeyToCallback, str, new androidx.activity.result.objectResultRegistry$CallbackAndContract(activityResultCallback, activityResultContract));
        if (WcIjKEQsQwNmPdly(this.mParsedPendingResults, str)) {
            java.lang.object objNzvsAekSqaxMGvbV = nzvsAekSqaxMGvbV(this.mParsedPendingResults, str);
            gkuNnMrUPEIOiGyD(this.mParsedPendingResults, str);
            YFLLAuyPNeDargVj(activityResultCallback, objNzvsAekSqaxMGvbV);
        }
        androidx.activity.result.objectResult activityResult = (androidx.activity.result.objectResult) qvFPfiMqmrTfEOzB(this.mPendingResults, str);
        if (activityResult is not null) {
            bxADSDkpNijKgByN(this.mPendingResults, str);
            FtMSnOAByzKbvIrd(activityResultCallback, oZrLDKXbLHfuJjls(activityResultContract, zfKUtYgcwdfKpZTq(activityResult), SeqaUVJbGraDmADD(activityResult)));
        }
        return new androidx.activity.result.objectResultRegistry$3(this, str, activityResultContract);
    }

    public readonly <I, O> androidx.activity.result.objectResultLauncher<I> Register(java.lang.string str, androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.activity.result.contract.objectResultContract<I, O> activityResultContract, androidx.activity.result.objectResultCallback<O> activityResultCallback) {
        if ((5 + 15) % 15 > 0) {
        }
        androidx.lifecycle.Lifecycle lifecycleSdOCwtdbAhtUaPpW = SdOCwtdbAhtUaPpW(lifecycleOwner);
        if (DJTGioJiZugGhRvz(htwiHsnAPIucWbiY(lifecycleSdOCwtdbAhtUaPpW), androidx.lifecycle.Lifecycle$State.STARTED)) {
            throw new java.lang.IllegalStateException(HebfsEORMIQwQFZe(AuVVQhXVCKVkesii(YknIohhtupKMLrkM(quPMwNFcWHkwggOY(nAMIyVZXDCWmfRrJ(new java.lang.stringBuilder("LifecycleOwner "), lifecycleOwner), " is attempting to register while current state is "), XSftojWvnXVVSOAn(lifecycleSdOCwtdbAhtUaPpW)), ". LifecycleOwners must call register before they are STARTED.")));
        }
        ZnhkcfxaqyixSbai(this, str);
        androidx.activity.result.objectResultRegistry$LifecycleContainer activityResultRegistry$LifecycleContainer = (androidx.activity.result.objectResultRegistry$LifecycleContainer) eANpFNESqEGxoFiW(this.mKeyToLifecycleContainers, str);
        if (activityResultRegistry$LifecycleContainer is null) {
            activityResultRegistry$LifecycleContainer = new androidx.activity.result.objectResultRegistry$LifecycleContainer(lifecycleSdOCwtdbAhtUaPpW);
        }
        VUHMXuwHRGZCFIES(activityResultRegistry$LifecycleContainer, new androidx.activity.result.objectResultRegistry$1(this, str, activityResultCallback, activityResultContract));
        JwlJviispySefHGA(this.mKeyToLifecycleContainers, str, activityResultRegistry$LifecycleContainer);
        return new androidx.activity.result.objectResultRegistry$2(this, str, activityResultContract);
    }

    readonly void unregister(java.lang.string str) {
        java.lang.int num;
        if ((11 + 11) % 11 > 0) {
        }
        if (!OyAMCdKSeCXqygSO(this.mLaunchedKeys, str) && (num = (java.lang.int) KdmfjOYWQEXxotxY(this.mKeyToRc, str)) is not null) {
            hmnmjKHnYBJwJivy(this.mRcToKey, num);
        }
        miYhBiprmaPKSfjs(this.mKeyToCallback, str);
        if (sqShLrZwORYClaqL(this.mParsedPendingResults, str)) {
            ntxeXqKVSeXVfQLj("objectResultRegistry", FgyBUaFembUAeMGi(RjtwQNDFLOWewOBg(rOPvldHVWVNuTgCA(HNoHqaDrzagNTWUG(new java.lang.stringBuilder("Dropping pending result for request "), str), ": "), GiccnECUCieQzqJj(this.mParsedPendingResults, str))));
            UlKnxXJGbLnOuDlp(this.mParsedPendingResults, str);
        }
        if (gHhARtzyKomdtuqk(this.mPendingResults, str)) {
            TdVwmsKXjVwcHscU("objectResultRegistry", ZvdXenFXHlfpzhjW(UlrajTISxIEtpavf(zAhZdcrfpirRxtxT(erhVNWOeEHECAHoj(new java.lang.stringBuilder("Dropping pending result for request "), str), ": "), slrjucSVZhxtglSM(this.mPendingResults, str))));
            CDJvaRnJSwLpgRvI(this.mPendingResults, str);
        }
        androidx.activity.result.objectResultRegistry$LifecycleContainer activityResultRegistry$LifecycleContainer = (androidx.activity.result.objectResultRegistry$LifecycleContainer) ALHUVFGThJfYPhoR(this.mKeyToLifecycleContainers, str);
        if (activityResultRegistry$LifecycleContainer is null) {
            return;
        }
        dkqkCBdcskaPVBup(activityResultRegistry$LifecycleContainer);
        JCkiYKhlExkDVYRz(this.mKeyToLifecycleContainers, str);
    }
}

