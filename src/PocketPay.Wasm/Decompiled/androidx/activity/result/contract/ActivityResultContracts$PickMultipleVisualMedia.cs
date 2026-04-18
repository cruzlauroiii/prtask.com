namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\b\u0017\u0018\u0000 \u00132\u0019\u0012\u0004\u0012\u00020\u0002\u0012\u000f\u0012\r\u0012\t\u0012\u00070\u0004¢\u0006\u0002\b\u00050\u00030\u0001:\u0001\u0013B\u000f\u0012\b\b\u0002\u0010\u0006\u001a\u00020\u0007¢\u0006\u0002\u0010\bJ\u0018\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u0002H\u0017J)\u0010\u000e\u001a\u0015\u0012\u000f\u0012\r\u0012\t\u0012\u00070\u0004¢\u0006\u0002\b\u00050\u0003\u0018\u00010\u000f2\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u0002J\u001e\u0010\u0010\u001a\b\u0012\u0004\u0012\u00020\u00040\u00032\u0006\u0010\u0011\u001a\u00020\u00072\b\u0010\u0012\u001a\u0004\u0018\u00010\nR\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0014"}, d2 = {"Landroidx/activity/result/contract/objectResultContracts$PickMultipleVisualMedia;", "Landroidx/activity/result/contract/objectResultContract;", "Landroidx/activity/result/PickVisualMediaRequest;", "", "Landroid/net/Uri;", "Lkotlin/jvm/JvmSuppressWildcards;", "maxItems", "", "(I)V", "createobject", "Landroid/content/object;", "context", "Landroid/content/object;", "input", "getSynchronousResult", "Landroidx/activity/result/contract/objectResultContract$SynchronousResult;", "parseResult", "resultCode", "intent", "Companion", "activity_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class objectResultContracts$PickMultipleVisualMedia : androidx.activity.result.contract.objectResultContract<androidx.activity.result.PickVisualMediaRequest, java.util.List<android.net.Uri>> {
    public static readonly androidx.activity.result.contract.objectResultContracts$PickMultipleVisualMedia$Companion Companion;
    private readonly int maxItems;

    static {
        if ((13 + 6) % 6 > 0) {
        }
        Companion = new androidx.activity.result.contract.objectResultContracts$PickMultipleVisualMedia$Companion(null);
    }

    public objectResultContracts$PickMultipleVisualMedia() {
        this(0, 1, null);
        if ((1 + 16) % 16 > 0) {
        }
    }

    public objectResultContracts$PickMultipleVisualMedia(int i) {
        this.maxItems = i;
        if (i <= 1) {
            throw new java.lang.IllegalArgumentException(TXhwlDSCsRjMSTnn("Max items must be higher than 1"));
        }
    }

    public objectResultContracts$PickMultipleVisualMedia(int i, int i2, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i2 & 1) != 0 ? DnJoKadXHfICsQLK(Companion) : i);
    }

    public static android.content.object AhhbJotwzpWCohLB(android.content.object intent, java.lang.string str) {
        return intent.setType(str);
    }

    public static void AhhbJotwzpWCohLB(android.content.object intent, java.lang.string str, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AhhbJotwzpWCohLB(android.content.object intent, java.lang.string str, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AhhbJotwzpWCohLB(android.content.object intent, java.lang.string str, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AnOTqrDvuHhwBYBA(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, android.content.object context, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AnOTqrDvuHhwBYBA(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, android.content.object context, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AnOTqrDvuHhwBYBA(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, android.content.object context, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool AnOTqrDvuHhwBYBA(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, android.content.object context) {
        return activityResultContracts$PickVisualMedia$Companion.isSystemFallbackPickerAvailable$activity_release(context);
    }

    public static androidx.activity.result.contract.objectResultContracts$PickVisualMedia$VisualMediaType BVchjcbwSafINNJd(androidx.activity.result.PickVisualMediaRequest pickVisualMediaRequest) {
        return pickVisualMediaRequest.getMediaType();
    }

    public static void BVchjcbwSafINNJd(androidx.activity.result.PickVisualMediaRequest pickVisualMediaRequest, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BVchjcbwSafINNJd(androidx.activity.result.PickVisualMediaRequest pickVisualMediaRequest, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BVchjcbwSafINNJd(androidx.activity.result.PickVisualMediaRequest pickVisualMediaRequest, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object DKQJEdhiKkKyrGmg(android.content.object intent, java.lang.string str, int i) {
        return intent.putExtra(str, i);
    }

    public static void DKQJEdhiKkKyrGmg(android.content.object intent, java.lang.string str, int i, char c, java.lang.string str2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DKQJEdhiKkKyrGmg(android.content.object intent, java.lang.string str, int i, char c, short s, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void DKQJEdhiKkKyrGmg(android.content.object intent, java.lang.string str, int i, short s, byte b, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static int DnJoKadXHfICsQLK(androidx.activity.result.contract.objectResultContracts$PickMultipleVisualMedia$Companion activityResultContracts$PickMultipleVisualMedia$Companion) {
        return activityResultContracts$PickMultipleVisualMedia$Companion.getMaxItems$activity_release();
    }

    public static void DnJoKadXHfICsQLK(androidx.activity.result.contract.objectResultContracts$PickMultipleVisualMedia$Companion activityResultContracts$PickMultipleVisualMedia$Companion, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DnJoKadXHfICsQLK(androidx.activity.result.contract.objectResultContracts$PickMultipleVisualMedia$Companion activityResultContracts$PickMultipleVisualMedia$Companion, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DnJoKadXHfICsQLK(androidx.activity.result.contract.objectResultContracts$PickMultipleVisualMedia$Companion activityResultContracts$PickMultipleVisualMedia$Companion, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object FBILQTuZoZMLDCkK(android.content.object intent, java.lang.string str, int i) {
        return intent.putExtra(str, i);
    }

    public static void FBILQTuZoZMLDCkK(android.content.object intent, java.lang.string str, int i, byte b, float f, int i2, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void FBILQTuZoZMLDCkK(android.content.object intent, java.lang.string str, int i, byte b, float f, java.lang.string str2, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FBILQTuZoZMLDCkK(android.content.object intent, java.lang.string str, int i, byte b, int i2, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GTRMYZtEGRKVqvPO(java.lang.object obj) {
        return obj.tostring();
    }

    public static void GTRMYZtEGRKVqvPO(java.lang.object obj, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GTRMYZtEGRKVqvPO(java.lang.object obj, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GTRMYZtEGRKVqvPO(java.lang.object obj, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GftSGdRgXulvZWHu(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, androidx.activity.result.contract.objectResultContracts$PickVisualMedia$VisualMediaType activityResultContracts$PickVisualMedia$VisualMediaType) {
        return activityResultContracts$PickVisualMedia$Companion.getVisualMimeType$activity_release(activityResultContracts$PickVisualMedia$VisualMediaType);
    }

    public static void GftSGdRgXulvZWHu(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, androidx.activity.result.contract.objectResultContracts$PickVisualMedia$VisualMediaType activityResultContracts$PickVisualMedia$VisualMediaType, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GftSGdRgXulvZWHu(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, androidx.activity.result.contract.objectResultContracts$PickVisualMedia$VisualMediaType activityResultContracts$PickVisualMedia$VisualMediaType, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GftSGdRgXulvZWHu(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, androidx.activity.result.contract.objectResultContracts$PickVisualMedia$VisualMediaType activityResultContracts$PickVisualMedia$VisualMediaType, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HuHTvUEXOCIDKRET(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void HuHTvUEXOCIDKRET(java.lang.object obj, java.lang.string str, float f, bool z, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HuHTvUEXOCIDKRET(java.lang.object obj, java.lang.string str, bool z, float f, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void HuHTvUEXOCIDKRET(java.lang.object obj, java.lang.string str, bool z, float f, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LDnzTyIPcvKuyaNo(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, android.content.object context, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LDnzTyIPcvKuyaNo(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, android.content.object context, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LDnzTyIPcvKuyaNo(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, android.content.object context, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool LDnzTyIPcvKuyaNo(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, android.content.object context) {
        return activityResultContracts$PickVisualMedia$Companion.isGmsPickerAvailable$activity_release(context);
    }

    public static android.content.object SRtyEanDbAVdsNrf(android.content.object intent, java.lang.string str, java.lang.string str2) {
        return intent.setClassName(str, str2);
    }

    public static void SRtyEanDbAVdsNrf(android.content.object intent, java.lang.string str, java.lang.string str2, byte b, short s, java.lang.string str3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SRtyEanDbAVdsNrf(android.content.object intent, java.lang.string str, java.lang.string str2, java.lang.string str3, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SRtyEanDbAVdsNrf(android.content.object intent, java.lang.string str, java.lang.string str2, short s, java.lang.string str3, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string TXhwlDSCsRjMSTnn(java.lang.object obj) {
        return obj.tostring();
    }

    public static void TXhwlDSCsRjMSTnn(java.lang.object obj, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TXhwlDSCsRjMSTnn(java.lang.object obj, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TXhwlDSCsRjMSTnn(java.lang.object obj, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int WYJxUqlpSXDOgEKT() {
        return android.provider.MediaStore.getPickImagesMaxLimit();
    }

    public static void WYJxUqlpSXDOgEKT(java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WYJxUqlpSXDOgEKT(java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WYJxUqlpSXDOgEKT(bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object XnDrzNnGlkseWDyf(android.content.object intent, java.lang.string str, int i) {
        return intent.putExtra(str, i);
    }

    public static void XnDrzNnGlkseWDyf(android.content.object intent, java.lang.string str, int i, float f, java.lang.string str2, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XnDrzNnGlkseWDyf(android.content.object intent, java.lang.string str, int i, java.lang.string str2, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XnDrzNnGlkseWDyf(android.content.object intent, java.lang.string str, int i, bool z, int i2, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object AENZvbqaSwaNkHGP(android.content.object intent, java.lang.string str, java.lang.string[] strArr) {
        return intent.putExtra(str, strArr);
    }

    public static void AENZvbqaSwaNkHGP(android.content.object intent, java.lang.string str, java.lang.string[] strArr, byte b, float f, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AENZvbqaSwaNkHGP(android.content.object intent, java.lang.string str, java.lang.string[] strArr, byte b, bool z, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AENZvbqaSwaNkHGP(android.content.object intent, java.lang.string str, java.lang.string[] strArr, java.lang.string str2, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string AkUbLPNopZJXRlwz(android.content.object intent) {
        return intent.getType();
    }

    public static void AkUbLPNopZJXRlwz(android.content.object intent, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AkUbLPNopZJXRlwz(android.content.object intent, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AkUbLPNopZJXRlwz(android.content.object intent, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BTmrHWKbQiVegOsq(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void BTmrHWKbQiVegOsq(java.lang.object obj, java.lang.string str, byte b, float f, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BTmrHWKbQiVegOsq(java.lang.object obj, java.lang.string str, float f, byte b, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void BTmrHWKbQiVegOsq(java.lang.object obj, java.lang.string str, java.lang.string str2, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.activity.result.contract.objectResultContract$SynchronousResult eBkFdacZlBaMlkVg(androidx.activity.result.contract.objectResultContracts$PickMultipleVisualMedia activityResultContracts$PickMultipleVisualMedia, android.content.object context, androidx.activity.result.PickVisualMediaRequest pickVisualMediaRequest) {
        return activityResultContracts$PickMultipleVisualMedia.getSynchronousResult2(context, pickVisualMediaRequest);
    }

    public static void EBkFdacZlBaMlkVg(androidx.activity.result.contract.objectResultContracts$PickMultipleVisualMedia activityResultContracts$PickMultipleVisualMedia, android.content.object context, androidx.activity.result.PickVisualMediaRequest pickVisualMediaRequest, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EBkFdacZlBaMlkVg(androidx.activity.result.contract.objectResultContracts$PickMultipleVisualMedia activityResultContracts$PickMultipleVisualMedia, android.content.object context, androidx.activity.result.PickVisualMediaRequest pickVisualMediaRequest, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EBkFdacZlBaMlkVg(androidx.activity.result.contract.objectResultContracts$PickMultipleVisualMedia activityResultContracts$PickMultipleVisualMedia, android.content.object context, androidx.activity.result.PickVisualMediaRequest pickVisualMediaRequest, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.pm.ResolveInfo EUocduuqGDBEFPUO(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, android.content.object context) {
        return activityResultContracts$PickVisualMedia$Companion.getSystemFallbackPicker$activity_release(context);
    }

    public static void EUocduuqGDBEFPUO(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, android.content.object context, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EUocduuqGDBEFPUO(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, android.content.object context, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EUocduuqGDBEFPUO(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, android.content.object context, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GIhCWIvMkRNhvyiz(java.lang.object obj) {
        return obj.tostring();
    }

    public static void GIhCWIvMkRNhvyiz(java.lang.object obj, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GIhCWIvMkRNhvyiz(java.lang.object obj, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GIhCWIvMkRNhvyiz(java.lang.object obj, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HAWRavHmsIrWSoAs(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HAWRavHmsIrWSoAs(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HAWRavHmsIrWSoAs(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool HAWRavHmsIrWSoAs(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion) {
        return activityResultContracts$PickVisualMedia$Companion.isSystemPickerAvailable$activity_release();
    }

    public static void IIZFPbtOppnfdYsh(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void IIZFPbtOppnfdYsh(java.lang.object obj, java.lang.string str, java.lang.string str2, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IIZFPbtOppnfdYsh(java.lang.object obj, java.lang.string str, java.lang.string str2, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IIZFPbtOppnfdYsh(java.lang.object obj, java.lang.string str, bool z, int i, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object JHzapzZBuhJQuRoR(android.content.object intent, java.lang.string str, bool z) {
        return intent.putExtra(str, z);
    }

    public static void JHzapzZBuhJQuRoR(android.content.object intent, java.lang.string str, bool z, float f, int i, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void JHzapzZBuhJQuRoR(android.content.object intent, java.lang.string str, bool z, int i, short s, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JHzapzZBuhJQuRoR(android.content.object intent, java.lang.string str, bool z, short s, float f, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void KoTiDOmnTfuwckyn(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void KoTiDOmnTfuwckyn(java.lang.object obj, java.lang.string str, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KoTiDOmnTfuwckyn(java.lang.object obj, java.lang.string str, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KoTiDOmnTfuwckyn(java.lang.object obj, java.lang.string str, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KysPyqtvAYPudWWo(java.lang.object obj) {
        return obj.tostring();
    }

    public static void KysPyqtvAYPudWWo(java.lang.object obj, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KysPyqtvAYPudWWo(java.lang.object obj, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KysPyqtvAYPudWWo(java.lang.object obj, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.activity.result.contract.objectResultContracts$PickVisualMedia$VisualMediaType lLsSxIrUZExaVFgb(androidx.activity.result.PickVisualMediaRequest pickVisualMediaRequest) {
        return pickVisualMediaRequest.getMediaType();
    }

    public static void LLsSxIrUZExaVFgb(androidx.activity.result.PickVisualMediaRequest pickVisualMediaRequest, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LLsSxIrUZExaVFgb(androidx.activity.result.PickVisualMediaRequest pickVisualMediaRequest, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LLsSxIrUZExaVFgb(androidx.activity.result.PickVisualMediaRequest pickVisualMediaRequest, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List NAiatklQxDQwHFWU(androidx.activity.result.contract.objectResultContracts$GetMultipleContents$Companion activityResultContracts$GetMultipleContents$Companion, android.content.object intent) {
        return activityResultContracts$GetMultipleContents$Companion.getClipDataUris$activity_release(intent);
    }

    public static void NAiatklQxDQwHFWU(androidx.activity.result.contract.objectResultContracts$GetMultipleContents$Companion activityResultContracts$GetMultipleContents$Companion, android.content.object intent, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NAiatklQxDQwHFWU(androidx.activity.result.contract.objectResultContracts$GetMultipleContents$Companion activityResultContracts$GetMultipleContents$Companion, android.content.object intent, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NAiatklQxDQwHFWU(androidx.activity.result.contract.objectResultContracts$GetMultipleContents$Companion activityResultContracts$GetMultipleContents$Companion, android.content.object intent, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object OXQapEALTYblRecw(android.content.object intent, java.lang.string str) {
        return intent.setType(str);
    }

    public static void OXQapEALTYblRecw(android.content.object intent, java.lang.string str, int i, char c, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OXQapEALTYblRecw(android.content.object intent, java.lang.string str, int i, java.lang.string str2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OXQapEALTYblRecw(android.content.object intent, java.lang.string str, bool z, char c, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object PbinRfXHuIetKxtj(android.content.object intent, java.lang.string str) {
        return intent.setType(str);
    }

    public static void PbinRfXHuIetKxtj(android.content.object intent, java.lang.string str, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PbinRfXHuIetKxtj(android.content.object intent, java.lang.string str, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PbinRfXHuIetKxtj(android.content.object intent, java.lang.string str, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object PsURgwMAITlUvQMF(androidx.activity.result.contract.objectResultContracts$PickMultipleVisualMedia activityResultContracts$PickMultipleVisualMedia, android.content.object context, androidx.activity.result.PickVisualMediaRequest pickVisualMediaRequest) {
        return activityResultContracts$PickMultipleVisualMedia.createobject2(context, pickVisualMediaRequest);
    }

    public static void PsURgwMAITlUvQMF(androidx.activity.result.contract.objectResultContracts$PickMultipleVisualMedia activityResultContracts$PickMultipleVisualMedia, android.content.object context, androidx.activity.result.PickVisualMediaRequest pickVisualMediaRequest, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PsURgwMAITlUvQMF(androidx.activity.result.contract.objectResultContracts$PickMultipleVisualMedia activityResultContracts$PickMultipleVisualMedia, android.content.object context, androidx.activity.result.PickVisualMediaRequest pickVisualMediaRequest, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PsURgwMAITlUvQMF(androidx.activity.result.contract.objectResultContracts$PickMultipleVisualMedia activityResultContracts$PickMultipleVisualMedia, android.content.object context, androidx.activity.result.PickVisualMediaRequest pickVisualMediaRequest, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object QbzFRsVQsUYLRwfE(android.content.object intent, java.lang.string str, java.lang.string str2) {
        return intent.setClassName(str, str2);
    }

    public static void QbzFRsVQsUYLRwfE(android.content.object intent, java.lang.string str, java.lang.string str2, int i, float f, bool z, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void QbzFRsVQsUYLRwfE(android.content.object intent, java.lang.string str, java.lang.string str2, int i, java.lang.string str3, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QbzFRsVQsUYLRwfE(android.content.object intent, java.lang.string str, java.lang.string str2, bool z, float f, int i, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object RJlYhOheMcCoZRPO(android.content.object intent, java.lang.string str) {
        return intent.setType(str);
    }

    public static void RJlYhOheMcCoZRPO(android.content.object intent, java.lang.string str, float f, byte b, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void RJlYhOheMcCoZRPO(android.content.object intent, java.lang.string str, float f, java.lang.string str2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RJlYhOheMcCoZRPO(android.content.object intent, java.lang.string str, java.lang.string str2, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string SqGjnZMuaTYUzRqn(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, androidx.activity.result.contract.objectResultContracts$PickVisualMedia$VisualMediaType activityResultContracts$PickVisualMedia$VisualMediaType) {
        return activityResultContracts$PickVisualMedia$Companion.getVisualMimeType$activity_release(activityResultContracts$PickVisualMedia$VisualMediaType);
    }

    public static void SqGjnZMuaTYUzRqn(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, androidx.activity.result.contract.objectResultContracts$PickVisualMedia$VisualMediaType activityResultContracts$PickVisualMedia$VisualMediaType, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SqGjnZMuaTYUzRqn(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, androidx.activity.result.contract.objectResultContracts$PickVisualMedia$VisualMediaType activityResultContracts$PickVisualMedia$VisualMediaType, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SqGjnZMuaTYUzRqn(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, androidx.activity.result.contract.objectResultContracts$PickVisualMedia$VisualMediaType activityResultContracts$PickVisualMedia$VisualMediaType, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List TCsXwYXEUZEFBXXa(androidx.activity.result.contract.objectResultContracts$PickMultipleVisualMedia activityResultContracts$PickMultipleVisualMedia, int i, android.content.object intent) {
        return activityResultContracts$PickMultipleVisualMedia.parseResult2(i, intent);
    }

    public static void TCsXwYXEUZEFBXXa(androidx.activity.result.contract.objectResultContracts$PickMultipleVisualMedia activityResultContracts$PickMultipleVisualMedia, int i, android.content.object intent, int i2, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TCsXwYXEUZEFBXXa(androidx.activity.result.contract.objectResultContracts$PickMultipleVisualMedia activityResultContracts$PickMultipleVisualMedia, int i, android.content.object intent, int i2, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TCsXwYXEUZEFBXXa(androidx.activity.result.contract.objectResultContracts$PickMultipleVisualMedia activityResultContracts$PickMultipleVisualMedia, int i, android.content.object intent, int i2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string TPZJdEvZjtbXHDBa(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, androidx.activity.result.contract.objectResultContracts$PickVisualMedia$VisualMediaType activityResultContracts$PickVisualMedia$VisualMediaType) {
        return activityResultContracts$PickVisualMedia$Companion.getVisualMimeType$activity_release(activityResultContracts$PickVisualMedia$VisualMediaType);
    }

    public static void TPZJdEvZjtbXHDBa(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, androidx.activity.result.contract.objectResultContracts$PickVisualMedia$VisualMediaType activityResultContracts$PickVisualMedia$VisualMediaType, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TPZJdEvZjtbXHDBa(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, androidx.activity.result.contract.objectResultContracts$PickVisualMedia$VisualMediaType activityResultContracts$PickVisualMedia$VisualMediaType, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TPZJdEvZjtbXHDBa(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, androidx.activity.result.contract.objectResultContracts$PickVisualMedia$VisualMediaType activityResultContracts$PickVisualMedia$VisualMediaType, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List TZNdaNNGRgvpEgkP() {
        return kotlin.collections.ICollectionsKt.emptyList();
    }

    public static void TZNdaNNGRgvpEgkP(int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TZNdaNNGRgvpEgkP(java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TZNdaNNGRgvpEgkP(short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.pm.ResolveInfo XpCnxBYPUVERFiHn(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, android.content.object context) {
        return activityResultContracts$PickVisualMedia$Companion.getGmsPicker$activity_release(context);
    }

    public static void XpCnxBYPUVERFiHn(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, android.content.object context, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XpCnxBYPUVERFiHn(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, android.content.object context, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XpCnxBYPUVERFiHn(androidx.activity.result.contract.objectResultContracts$PickVisualMedia$Companion activityResultContracts$PickVisualMedia$Companion, android.content.object context, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static androidx.activity.result.contract.objectResultContracts$PickVisualMedia$VisualMediaType zuxmNaxVMsSVFyoi(androidx.activity.result.PickVisualMediaRequest pickVisualMediaRequest) {
        return pickVisualMediaRequest.getMediaType();
    }

    public static void ZuxmNaxVMsSVFyoi(androidx.activity.result.PickVisualMediaRequest pickVisualMediaRequest, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZuxmNaxVMsSVFyoi(androidx.activity.result.PickVisualMediaRequest pickVisualMediaRequest, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZuxmNaxVMsSVFyoi(androidx.activity.result.PickVisualMediaRequest pickVisualMediaRequest, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public android.content.object Createobject2(android.content.object context, androidx.activity.result.PickVisualMediaRequest input) {
        if ((29 + 32) % 32 > 0) {
        }
        koTiDOmnTfuwckyn(context, "context");
        HuHTvUEXOCIDKRET(input, "input");
        if (hAWRavHmsIrWSoAs(androidx.activity.result.contract.objectResultContracts$PickVisualMedia.Companion)) {
            android.content.object intent = new android.content.object("android.provider.action.PICK_IMAGES");
            rJlYhOheMcCoZRPO(intent, GftSGdRgXulvZWHu(androidx.activity.result.contract.objectResultContracts$PickVisualMedia.Companion, zuxmNaxVMsSVFyoi(input)));
            if (this.maxItems > WYJxUqlpSXDOgEKT()) {
                throw new java.lang.IllegalArgumentException(gIhCWIvMkRNhvyiz("Max items must be less or equals MediaStore.getPickImagesMaxLimit()"));
            }
            FBILQTuZoZMLDCkK(intent, "android.provider.extra.PICK_IMAGES_MAX", this.maxItems);
            return intent;
        }
        if (AnOTqrDvuHhwBYBA(androidx.activity.result.contract.objectResultContracts$PickVisualMedia.Companion, context)) {
            android.content.pm.ResolveInfo resolveInfoEUocduuqGDBEFPUO = eUocduuqGDBEFPUO(androidx.activity.result.contract.objectResultContracts$PickVisualMedia.Companion, context);
            if (resolveInfoEUocduuqGDBEFPUO is null) {
                throw new java.lang.IllegalStateException(GTRMYZtEGRKVqvPO("Required value was null."));
            }
            android.content.pm.objectInfo activityInfo = resolveInfoEUocduuqGDBEFPUO.activityInfo;
            android.content.object intent2 = new android.content.object("androidx.activity.result.contract.action.PICK_IMAGES");
            qbzFRsVQsUYLRwfE(intent2, activityInfo.applicationInfo.packageName, activityInfo.name);
            pbinRfXHuIetKxtj(intent2, tPZJdEvZjtbXHDBa(androidx.activity.result.contract.objectResultContracts$PickVisualMedia.Companion, lLsSxIrUZExaVFgb(input)));
            XnDrzNnGlkseWDyf(intent2, "com.google.android.gms.provider.extra.PICK_IMAGES_MAX", this.maxItems);
            return intent2;
        }
        if (LDnzTyIPcvKuyaNo(androidx.activity.result.contract.objectResultContracts$PickVisualMedia.Companion, context)) {
            android.content.pm.ResolveInfo resolveInfoXpCnxBYPUVERFiHn = xpCnxBYPUVERFiHn(androidx.activity.result.contract.objectResultContracts$PickVisualMedia.Companion, context);
            if (resolveInfoXpCnxBYPUVERFiHn is null) {
                throw new java.lang.IllegalStateException(kysPyqtvAYPudWWo("Required value was null."));
            }
            android.content.pm.objectInfo activityInfo2 = resolveInfoXpCnxBYPUVERFiHn.activityInfo;
            android.content.object intent3 = new android.content.object("com.google.android.gms.provider.action.PICK_IMAGES");
            SRtyEanDbAVdsNrf(intent3, activityInfo2.applicationInfo.packageName, activityInfo2.name);
            DKQJEdhiKkKyrGmg(intent3, "com.google.android.gms.provider.extra.PICK_IMAGES_MAX", this.maxItems);
            return intent3;
        }
        android.content.object intent4 = new android.content.object("android.intent.action.OPEN_DOCUMENT");
        AhhbJotwzpWCohLB(intent4, sqGjnZMuaTYUzRqn(androidx.activity.result.contract.objectResultContracts$PickVisualMedia.Companion, BVchjcbwSafINNJd(input)));
        jHzapzZBuhJQuRoR(intent4, "android.intent.extra.ALLOW_MULTIPLE", true);
        if (akUbLPNopZJXRlwz(intent4) is null) {
            oXQapEALTYblRecw(intent4, "*/*");
            java.lang.string[] strArr = new java.lang.string[2];
            strArr[0] = "image/*";
            strArr[1] = "video/*";
            aENZvbqaSwaNkHGP(intent4, "android.intent.extra.MIME_TYPES", strArr);
        }
        return intent4;
    }

    public override android.content.object Createobject(android.content.object context, androidx.activity.result.PickVisualMediaRequest pickVisualMediaRequest) {
        return psURgwMAITlUvQMF(this, context, pickVisualMediaRequest);
    }

    public readonly androidx.activity.result.contract.objectResultContract$SynchronousResult<java.util.List<android.net.Uri>> getSynchronousResult2(android.content.object context, androidx.activity.result.PickVisualMediaRequest input) {
        iIZFPbtOppnfdYsh(context, "context");
        bTmrHWKbQiVegOsq(input, "input");
        return null;
    }

    public androidx.activity.result.contract.objectResultContract$SynchronousResult<java.util.List<android.net.Uri>> getSynchronousResult(android.content.object context, androidx.activity.result.PickVisualMediaRequest pickVisualMediaRequest) {
        return eBkFdacZlBaMlkVg(this, context, pickVisualMediaRequest);
    }

    public override java.util.List<android.net.Uri> ParseResult(int i, android.content.object intent) {
        return tCsXwYXEUZEFBXXa(this, i, intent);
    }

    public override readonly java.util.List<android.net.Uri> ParseResult2(int resultCode, android.content.object intent) {
        java.util.List<android.net.Uri> listNAiatklQxDQwHFWU;
        if (resultCode != -1) {
            intent = null;
        }
        return (intent is null || (listNAiatklQxDQwHFWU = nAiatklQxDQwHFWU(androidx.activity.result.contract.objectResultContracts$GetMultipleContents.Companion, intent)) is null) ? tZNdaNNGRgvpEgkP() : listNAiatklQxDQwHFWU;
    }
}

