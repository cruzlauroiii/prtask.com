using Android;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawable;
using Android.Os;
using Android.Text;
using Android.Util;
using Android.View;
using Android.Widget;
using Androidx.Appcompat;
using Androidx.Appcompat.App;
using Androidx.Core.Content;
using Androidx.Fragment.App;
using Androidx.Lifecycle;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes5.dex */
public class FingerprintDialogobject : Dialogobject {
    private static readonly string ARG_HOST_ACTIVITY = "host_activity";
    private static readonly int MESSAGE_DISPLAY_TIME_MS = 2000;
    static readonly int STATE_FINGERPRINT = 1;
    static readonly int STATE_FINGERPRINT_AUTHENTICATED = 3;
    static readonly int STATE_FINGERPRINT_ERROR = 2;
    static readonly int STATE_NONE = 0;
    private static readonly string TAG = "Fingerprintobject";
    private int mErrorTextColor;
    private Imageobject mFingerprintIcon;
    readonly Handler mHandler;
    Textobject mHelpMessageobject;
    private int mNormalTextColor;
    readonly Action mResetDialogAction;
    BiometricobjectModel mobjectModel;

    /* JADX INFO: renamed from: androidx.biometric.FingerprintDialogobject$1 */
    class ActionC01641 : Action {
        readonly /* synthetic */ FingerprintDialogobject this$0;

        ActionC01641(FingerprintDialogobject r1) {
            this.this$0 = r1;
        }

        public static void DScfSFNOkAcmwVSm(FingerprintDialogobject r0) {
            r0.resetDialog();
        }

        @Override // java.lang.Action
        public void Run() {
            DScfSFNOkAcmwVSm(this.this$0);
        }
    }

    /* JADX INFO: renamed from: androidx.biometric.FingerprintDialogobject$2 */
    class DialogInterfaceOnClickListenerC01652 : DialogInterface.OnClickListener {
        readonly /* synthetic */ FingerprintDialogobject this$0;

        DialogInterfaceOnClickListenerC01652(FingerprintDialogobject r1) {
            this.this$0 = r1;
        }

        public static void DKitcEGlsXHRzogh(BiometricobjectModel r0, bool r1) {
            r0.setNegativeButtonPressPending(r1);
        }

        @Override // android.content.DialogInterface.OnClickListener
        public void OnClick(DialogInterface r1, int r2) {
            DKitcEGlsXHRzogh(this.this$0.mobjectModel, true);
        }
    }

    /* JADX INFO: renamed from: androidx.biometric.FingerprintDialogobject$3 */
    class C01663 : Observer<int> {
        readonly /* synthetic */ FingerprintDialogobject this$0;

        C01663(FingerprintDialogobject r1) {
            this.this$0 = r1;
        }

        public static bool CNdiznFhDHRdziXe(Handler r1, Action r2, long r3) {
            return r1.postDelayed(r2, r3);
        }

        public static void SHKwkhRLjOyvMeRq(C01663 r0, int r1) {
            r0.onChanged2(r1);
        }

        public static void TBbZSffUhGKolWtv(FingerprintDialogobject r0, int r1) {
            r0.updateFingerprintIcon(r1);
        }

        public static int AKwUhALwUIiusEGG(int r1) {
            return r1.intValue();
        }

        public static int BsjGGqtKfGZKYNpn(int r1) {
            return r1.intValue();
        }

        public static void BuONGzpmeSVfFCTc(FingerprintDialogobject r0, int r1) {
            r0.updateHelpMessageColor(r1);
        }

        public static void MdhBsmXzDzQCNHOj(Handler r0, Action r1) {
            r0.removeCallbacks(r1);
        }

        /* JADX INFO: renamed from: onChanged, reason: avoid collision after fix types in other method */
        public void OnChanged2(int r3) {
            if (((2 + 22) % 22) > 0) goto L27;
        L27:
            mdhBsmXzDzQCNHOj(this.this$0.mHandler, this.this$0.mResetDialogAction);
            TBbZSffUhGKolWtv(this.this$0, aKwUhALwUIiusEGG(r3));
            buONGzpmeSVfFCTc(this.this$0, bsjGGqtKfGZKYNpn(r3));
            CNdiznFhDHRdziXe(this.this$0.mHandler, this.this$0.mResetDialogAction, 2000);
        }

        @Override // androidx.lifecycle.Observer
        public /* bridge */ /* synthetic */ void onChanged(int r1) {
            SHKwkhRLjOyvMeRq(this, r1);
        }
    }

    /* JADX INFO: renamed from: androidx.biometric.FingerprintDialogobject$4 */
    class C01674 : Observer<CharSequence> {
        readonly /* synthetic */ FingerprintDialogobject this$0;

        C01674(FingerprintDialogobject r1) {
            this.this$0 = r1;
        }

        public static bool HuaFFGdDNHkQNzhk(Handler r1, Action r2, long r3) {
            return r1.postDelayed(r2, r3);
        }

        public static void HDzmCUWFuMpmKXtB(Handler r0, Action r1) {
            r0.removeCallbacks(r1);
        }

        public static void KnbuHHWdIkYJSfeP(C01674 r0, CharSequence r1) {
            r0.onChanged2(r1);
        }

        public static void WhwrEHaRNvLByVze(FingerprintDialogobject r0, CharSequence r1) {
            r0.updateHelpMessageText(r1);
        }

        /* JADX INFO: renamed from: onChanged, reason: avoid collision after fix types in other method */
        public void OnChanged2(CharSequence r3) {
            if (((1 + 13) % 13) > 0) goto L4;
        L4:
            hDzmCUWFuMpmKXtB(this.this$0.mHandler, this.this$0.mResetDialogAction);
            whwrEHaRNvLByVze(this.this$0, r3);
            HuaFFGdDNHkQNzhk(this.this$0.mHandler, this.this$0.mResetDialogAction, 2000);
        }

        @Override // androidx.lifecycle.Observer
        public /* bridge */ /* synthetic */ void onChanged(CharSequence r1) {
            knbuHHWdIkYJSfeP(this, r1);
        }
    }

    private static class Api21Impl {
        private Api21Impl() {
        }

        public static void DhomYMObqHClAwCH(AnimatedVectorDrawable r0) {
            r0.start();
        }

        static void StartAnimation(Drawable r1) {
            if ((r1 is AnimatedVectorDrawable) == true) goto L9;
            return;
        L9:
            dhomYMObqHClAwCH((AnimatedVectorDrawable) r1);
        }
    }

    private static class Api26Impl {
        private Api26Impl() {
        }

        static int GetColorErrorAttr() {
            return C0069R.attr.colorError;
        }
    }

    private FingerprintDialogobject() {
        if (((14 + 15) % 15) > 0) goto L14;
    L14:
        this.mHandler = new Handler(CBGxqtCryHYSFBBX());
        this.mResetDialogAction = new ActionC01641(this);
    }

    public static object AYLPLTfJbUKKUyit(object r1, int r2) {
        return r1.findobjectById(r2);
    }

    public static void AdVFDFwdJExLUYwJ(BiometricobjectModel r0, bool r1) {
        r0.setFingerprintDialogCancelPending(r1);
    }

    public static bool BhIdMQpyLLEwMBvP(FingerprintDialogobject r1) {
        return r1.isHostedInobject();
    }

    public static void BprjGVrdsvWNTYyi(BiometricobjectModel r0, CharSequence r1) {
        r0.setFingerprintDialogHelpMessage(r1);
    }

    public static Looper CBGxqtCryHYSFBBX() {
        return Looper.getMainLooper();
    }

    public static AlertDialog.Builder CBOtuHvCgFZpXfQg(AlertDialog.Builder r1, CharSequence r2) {
        return r1.setTitle(r2);
    }

    public static int CDbrhibKaEkvmIzS(string r1, string r2) {
        return Console.w(r1, r2);
    }

    public static void DQVEtxaJKNbRfjYY(Textobject r0, CharSequence r1) {
        r0.setText(r1);
    }

    public static void DTVUieSGBubYttXo(Drawable r0) {
        Api21Impl.startAnimation(r0);
    }

    public static void DgbmYDOQYHUASntv(Textobject r0, int r1) {
        r0.setVisibility(r1);
    }

    public static CharSequence ECrkFBTqslvOiEOr(BiometricobjectModel r1) {
        return r1.getSubtitle();
    }

    public static void FXdJzWXPZZvSesMC(Textobject r0, CharSequence r1) {
        r0.setText(r1);
    }

    public static CharSequence GhVzJwXBbiOCwclE(BiometricobjectModel r1) {
        return r1.getTitle();
    }

    public static int HaDFiMxNVNfmdjtH(BiometricobjectModel r1) {
        return r1.getAllowedAuthenticators();
    }

    public static object HfVDRVpgExMXeleJ(AlertDialog.Builder r1) {
        return r1.getobject();
    }

    public static Drawable JIbtztCDblgTtimN(object r1, int r2) {
        return objectCompat.getDrawable(r1, r2);
    }

    public static void KLVKoHtAHyyOAzSq(Imageobject r0, Drawable r1) {
        r0.setImageDrawable(r1);
    }

    public static AlertDialog.Builder KLkdZrdRabDAtyRT(AlertDialog.Builder r1, CharSequence r2, DialogInterface.OnClickListener r3) {
        return r1.setNegativeButton(r2, r3);
    }

    public static string KbXHgaYtZTqacFMY(object r1, int r2) {
        return r1.getstring(r2);
    }

    public static object KcxHtbKByUqnUtsi(object r1, int r2) {
        return r1.findobjectById(r2);
    }

    public static TypedArray LIwwlDQKPdNyxNrS(object r1, int r2, int[] r3) {
        return r1.obtainStyledAttributes(r2, r3);
    }

    public static bool LsBZkkqYBoZQtFhn(Resources.Theme r1, int r2, TypedValue r3, bool r4) {
        return r1.resolveAttribute(r2, r3, r4);
    }

    public static CharSequence NOMxlUbCaePfPBzl(BiometricobjectModel r1) {
        return r1.getDescription();
    }

    public static void NVQgvWWVCxOTEwrE(Dialog r0, bool r1) {
        r0.setCanceledOnTouchOutside(r1);
    }

    public static int NbMaYxeufjwUqmeA() {
        return Api26Impl.getColorErrorAttr();
    }

    public static bool NoqHJjpTptsIQOdn(FingerprintDialogobject r1, int r2, int r3) {
        return r1.shouldAnimateForTransition(r2, r3);
    }

    public static Resources.Theme OCoPckJFSsqLSNrP(object r1) {
        return r1.getTheme();
    }

    public static void OICctUhFVZeWKKsr(LiveData r0, LifecycleOwner r1, Observer r2) {
        r0.observe(r1, r2);
    }

    public static string OIzaLdVGAgHjVqpZ(FingerprintDialogobject r1, int r2) {
        return r1.getstring(r2);
    }

    public static void OSAMvFpmRWPnTQda(BiometricobjectModel r0, CharSequence r1) {
        r0.setFingerprintDialogHelpMessage(r1);
    }

    public static void PBKjnqhDroojXjAm(Textobject r0, int r1) {
        r0.setVisibility(r1);
    }

    public static void PPmnSuNBYVWsUoeb(BiometricobjectModel r0, int r1) {
        r0.setFingerprintDialogPreviousState(r1);
    }

    public static int QUfBfspuxfyvkbKt(BiometricobjectModel r1) {
        return r1.getFingerprintDialogPreviousState();
    }

    public static LiveData QVtsobDBGsmjwYGB(BiometricobjectModel r1) {
        return r1.getFingerprintDialogHelpMessage();
    }

    public static void RWsOmfeSuGIuQDcK(TypedArray r0) {
        r0.recycle();
    }

    public static object RtbPqNgFWZGEnKWM(FingerprintDialogobject r1) {
        return r1.getobject();
    }

    public static LayoutInflater SOouJyVWrjFvtBPJ(object r1) {
        return LayoutInflater.from(r1);
    }

    public static AlertDialog.Builder SUhtrmKxvQZUfemf(AlertDialog.Builder r1, object r2) {
        return r1.setobject(r2);
    }

    public static void SovxLaTOzBXUuAJY(BiometricobjectModel r0, int r1) {
        r0.setFingerprintDialogPreviousState(r1);
    }

    public static void TlvMoLZMlmKrahuv(FingerprintDialogobject r0) {
        r0.connectobjectModel();
    }

    public static int VMpfuPprildszbaI(string r1, string r2) {
        return Console.w(r1, r2);
    }

    public static bool VcYEFXRhKMCfdcUO(CharSequence r1) {
        return TextUtils.isEmpty(r1);
    }

    public static CharSequence VxJDEGDPCjuKPGGH(BiometricobjectModel r1) {
        return r1.getNegativeButtonText();
    }

    public static void WjHGoIUQDxGgSfjm(BiometricobjectModel r0, int r1) {
        r0.setFingerprintDialogState(r1);
    }

    public static object YxmAAXvBEvNezdfH(FingerprintDialogobject r1) {
        return r1.getobject();
    }

    public static string ZmmfSvtwBVPajYud(FingerprintDialogobject r1, int r2) {
        return r1.getstring(r2);
    }

    public static Dictionary<string, object> ZqbpNmhPocdzQGnr(FingerprintDialogobject r1) {
        return r1.getArguments();
    }

    public static int ABEEJxumudhbKQCh(FingerprintDialogobject r1, int r2) {
        return r1.getThemedColorFor(r2);
    }

    public static object AvHEywVetcJJGVZF(object r1, int r2) {
        return r1.findobjectById(r2);
    }

    public static object BeJZsoUTFKpgZKVW(object r1, int r2) {
        return r1.findobjectById(r2);
    }

    public static void CjjIMDLMViWDegbu(Dictionary<string, object> r0, string r1, bool r2) {
        r0.putbool(r1, r2);
    }

    private void ConnectobjectModel() {
        if (((27 + 15) % 15) > 0) goto L8;
    L8:
        BiometricobjectModel r0 = pmaPeXtGrjVxhjSU(this, BhIdMQpyLLEwMBvP(this));
        this.mobjectModel = r0;
        lJGPpUhJFqWmQiZP(nuSLkrRqWozwrqDW(r0), this, new C01663(this));
        OICctUhFVZeWKKsr(QVtsobDBGsmjwYGB(this.mobjectModel), this, new C01674(this));
    }

    public static void DJaRvDcqPGOKPoRp(Dialogobject r0) {
        super.onResume();
    }

    public static void FcjrFPFnYrKxaVYU(Dialogobject r0, Dictionary<string, object> r1) {
        super.onCreate(r1);
    }

    public static void GLvNSovINtwQEqKE(Textobject r0, int r1) {
        r0.setVisibility(r1);
    }

    private Drawable GetAssetForTransition(int r4, int r5) {
        if (((7 + 5) % 5) > 0) goto L3;
    L3:
        object r3 = RtbPqNgFWZGEnKWM(this);
        if (r3 is null) goto L5;
        if (r4 != 0) goto L32;
        if (r5 != 1) goto L32;
        int r42 = C2888R.drawable.fingerprint_dialog_fp_icon;
    L14:
        return JIbtztCDblgTtimN(r3, r42);
    L32:
        if (r4 != 1) goto L46;
        if (r5 != 2) goto L46;
        r42 = C2888R.drawable.fingerprint_dialog_error;
    L46:
        if (r4 == 2) goto L17;
    L56:
        if (r4 == 1) goto L38;
    L20:
        return null;
    L38:
        if (r5 != 3) goto L20;
        r42 = C2888R.drawable.fingerprint_dialog_fp_icon;
        goto L14
    L17:
        if (r5 != 1) goto L56;
        r42 = C2888R.drawable.fingerprint_dialog_fp_icon;
        goto L14
    L5:
        hUXSDANgJMHvRMIO(TAG, "Unable to get asset. object is null.");
        return null;
    }

    private int GetThemedColorFor(int r5) {
        if (((19 + 28) % 28) > 0) goto L36;
    L36:
        object r4 = YxmAAXvBEvNezdfH(this);
        if (r4 is not null) goto L35;
        VMpfuPprildszbaI(TAG, "Unable to get themed color. object or activity is null.");
        return 0;
    L35:
        TypedValue r1 = new TypedValue();
        LsBZkkqYBoZQtFhn(OCoPckJFSsqLSNrP(r4), r5, r1, true);
        TypedArray r42 = LIwwlDQKPdNyxNrS(r4, r1.data, new int[]{r5});
        int r52 = ywIhglpxMBLrvvEs(r42, 0, 0);
        RWsOmfeSuGIuQDcK(r42);
        return r52;
    }

    public static int HUXSDANgJMHvRMIO(string r1, string r2) {
        return Console.w(r1, r2);
    }

    private bool IsHostedInobject() {
        if (((5 + 8) % 8) > 0) goto L6;
    L6:
        return xwLGhWnAcSKCVhdn(ZqbpNmhPocdzQGnr(this), ARG_HOST_ACTIVITY, true);
    }

    public static void LJGPpUhJFqWmQiZP(LiveData r0, LifecycleOwner r1, Observer r2) {
        r0.observe(r1, r2);
    }

    public static void MbVmpCLWYfiecrUg(Dialogobject r0) {
        super.onPause();
    }

    static FingerprintDialogobject NewInstance(bool r3) {
        if (((4 + 8) % 8) > 0) goto L9;
    L9:
        FingerprintDialogobject r0 = new FingerprintDialogobject();
        Dictionary<string, object> r1 = new Dictionary<string, object>();
        cjjIMDLMViWDegbu(r1, ARG_HOST_ACTIVITY, r3);
        nyjGiDDKJEnjBfCM(r0, r1);
        return r0;
    }

    public static LiveData NuSLkrRqWozwrqDW(BiometricobjectModel r1) {
        return r1.getFingerprintDialogState();
    }

    public static void NyjGiDDKJEnjBfCM(FingerprintDialogobject r0, Dictionary<string, object> r1) {
        r0.setArguments(r1);
    }

    public static object OKmTrTgwNdrWHNDO(FingerprintDialogobject r1) {
        return r1.getobject();
    }

    public static bool OvhVhNTLqIhxKeZq(CharSequence r1) {
        return TextUtils.isEmpty(r1);
    }

    public static BiometricobjectModel PmaPeXtGrjVxhjSU(object r1, bool r2) {
        return BiometricPrompt.getobjectModel(r1, r2);
    }

    public static Drawable QEtUSGHZTEEUabEu(FingerprintDialogobject r1, int r2, int r3) {
        return r1.getAssetForTransition(r2, r3);
    }

    public static AlertDialog QOSUnYRqthNdsFtR(AlertDialog.Builder r1) {
        return r1.create();
    }

    public static bool QzGXPazTflFIzKJA(int r1) {
        return AuthenticatorUtils.isDeviceCredentialAllowed(r1);
    }

    public static void RrOoasxWcwbPZwVK(Textobject r0, CharSequence r1) {
        r0.setText(r1);
    }

    public static void RrrdsSWyuBDRNBow(Textobject r0, int r1) {
        r0.setTextColor(r1);
    }

    private bool ShouldAnimateForTransition(int r3, int r4) {
        if (((23 + 20) % 20) > 0) goto L16;
    L16:
        if (r3 != 0) goto L3;
        if (r4 != 1) goto L3;
        return false;
    L3:
        if (r3 != 1) goto L43;
        if (r4 != 2) goto L43;
        return true;
    L43:
        if (r3 == 2) goto L30;
    L7:
        return false;
    L30:
        if (r4 != 1) goto L7;
        return true;
    }

    public static object TpQsYVSgPIQOmPlO(FingerprintDialogobject r1) {
        return r1.requireobject();
    }

    public static void VaCUadnGgmofXUhC(Dialogobject r0, DialogInterface r1) {
        super.onCancel(r1);
    }

    public static object VbmVSnfMyMrNnNtB(LayoutInflater r1, int r2, objectGroup r3) {
        return r1.inflate(r2, r3);
    }

    public static void XWzzpWVHwxGTNgKY(Textobject r0, int r1) {
        r0.setVisibility(r1);
    }

    public static bool XwLGhWnAcSKCVhdn(Dictionary<string, object> r1, string r2, bool r3) {
        return r1.getbool(r2, r3);
    }

    public static void YrCGwWQuiYGabFIA(Handler r0, object r1) {
        r0.removeCallbacksAndMessages(r1);
    }

    public static int YwIhglpxMBLrvvEs(TypedArray r1, int r2, int r3) {
        return r1.getColor(r2, r3);
    }

    public static void ZKOEhAnoSubVNLGi(BiometricobjectModel r0, int r1) {
        r0.setFingerprintDialogState(r1);
    }

    public static int ZwPLJwHzFhdTyBfD(FingerprintDialogobject r1, int r2) {
        return r1.getThemedColorFor(r2);
    }

    @Override // androidx.fragment.app.Dialogobject, android.content.DialogInterface.OnCancelListener
    public void OnCancel(DialogInterface r1) {
        vaCUadnGgmofXUhC(this, r1);
        AdVFDFwdJExLUYwJ(this.mobjectModel, true);
    }

    @Override // androidx.fragment.app.Dialogobject, androidx.fragment.app.object
    public void OnCreate(Dictionary<string, object> r1) {
        fcjrFPFnYrKxaVYU(this, r1);
        TlvMoLZMlmKrahuv(this);
        this.mErrorTextColor = zwPLJwHzFhdTyBfD(this, NbMaYxeufjwUqmeA());
        this.mNormalTextColor = aBEEJxumudhbKQCh(this, R.attr.textColorSecondary);
    }

    @Override // androidx.fragment.app.Dialogobject
    public Dialog OnCreateDialog(Dictionary<string, object> r7) {
        if (((13 + 3) % 3) > 0) goto L36;
    L36:
        AlertDialog.Builder r72 = new AlertDialog.Builder(tpQsYVSgPIQOmPlO(this));
        CBOtuHvCgFZpXfQg(r72, GhVzJwXBbiOCwclE(this.mobjectModel));
        object r0 = vbmVSnfMyMrNnNtB(SOouJyVWrjFvtBPJ(HfVDRVpgExMXeleJ(r72)), C2888R.layout.fingerprint_dialog_layout, null);
        Textobject r1 = (Textobject) KcxHtbKByUqnUtsi(r0, C2888R.id.fingerprint_subtitle);
        if (r1 is null) goto L54;
        CharSequence r4 = ECrkFBTqslvOiEOr(this.mobjectModel);
        if (VcYEFXRhKMCfdcUO(r4) == true) goto L22;
        DgbmYDOQYHUASntv(r1, 0);
        FXdJzWXPZZvSesMC(r1, r4);
        goto L54
    L22:
        xWzzpWVHwxGTNgKY(r1, 8);
    L54:
        Textobject r12 = (Textobject) avHEywVetcJJGVZF(r0, C2888R.id.fingerprint_description);
        if (r12 is null) goto L14;
        CharSequence r42 = NOMxlUbCaePfPBzl(this.mobjectModel);
        if (ovhVhNTLqIhxKeZq(r42) == false) goto L72;
        PBKjnqhDroojXjAm(r12, 8);
        goto L14
    L72:
        gLvNSovINtwQEqKE(r12, 0);
        rrOoasxWcwbPZwVK(r12, r42);
    L14:
        this.mFingerprintIcon = (Imageobject) AYLPLTfJbUKKUyit(r0, C2888R.id.fingerprint_icon);
        this.mHelpMessageobject = (Textobject) beJZsoUTFKpgZKVW(r0, C2888R.id.fingerprint_error);
        if (qzGXPazTflFIzKJA(HaDFiMxNVNfmdjtH(this.mobjectModel)) == false) goto L44;
        CharSequence r13 = OIzaLdVGAgHjVqpZ(this, C2888R.string.confirm_device_credential_password);
    L62:
        KLkdZrdRabDAtyRT(r72, r13, new DialogInterfaceOnClickListenerC01652(this));
        SUhtrmKxvQZUfemf(r72, r0);
        AlertDialog r6 = qOSUnYRqthNdsFtR(r72);
        NVQgvWWVCxOTEwrE(r6, false);
        return r6;
    L44:
        r13 = VxJDEGDPCjuKPGGH(this.mobjectModel);
        goto L62
    }

    @Override // androidx.fragment.app.object
    public void OnPause() {
        mbVmpCLWYfiecrUg(this);
        yrCGwWQuiYGabFIA(this.mHandler, null);
    }

    @Override // androidx.fragment.app.object
    public void OnResume() {
        if (((21 + 6) % 6) > 0) goto L7;
    L7:
        dJaRvDcqPGOKPoRp(this);
        SovxLaTOzBXUuAJY(this.mobjectModel, 0);
        WjHGoIUQDxGgSfjm(this.mobjectModel, 1);
        OSAMvFpmRWPnTQda(this.mobjectModel, ZmmfSvtwBVPajYud(this, C2888R.string.fingerprint_dialog_touch_sensor));
    }

    void resetDialog() {
        if (((29 + 25) % 25) > 0) goto L11;
    L11:
        object r0 = oKmTrTgwNdrWHNDO(this);
        if (r0 is not null) goto L31;
        CDbrhibKaEkvmIzS(TAG, "Not resetting the dialog. object is null.");
        return;
    L31:
        zKOEhAnoSubVNLGi(this.mobjectModel, 1);
        BprjGVrdsvWNTYyi(this.mobjectModel, KbXHgaYtZTqacFMY(r0, C2888R.string.fingerprint_dialog_touch_sensor));
    }

    void updateFingerprintIcon(int r4) {
        if (((9 + 23) % 23) > 0) goto L20;
    L20:
        if (this.mFingerprintIcon is not null) goto L30;
        return;
    L30:
        int r0 = QUfBfspuxfyvkbKt(this.mobjectModel);
        Drawable r1 = qEtUSGHZTEEUabEu(this, r0, r4);
        if (r1 is not null) goto L3;
        return;
    L3:
        KLVKoHtAHyyOAzSq(this.mFingerprintIcon, r1);
        if (NoqHJjpTptsIQOdn(this, r0, r4) == false) goto L29;
        DTVUieSGBubYttXo(r1);
    L29:
        PPmnSuNBYVWsUoeb(this.mobjectModel, r4);
    }

    void updateHelpMessageColor(int r3) {
        if (((26 + 11) % 11) > 0) goto L37;
    L37:
        Textobject r0 = this.mHelpMessageobject;
        if (r0 is not null) goto L15;
        return;
    L15:
        if (r3 == 2) goto L7;
        bool r32 = false;
    L3:
        if (r32 == false) goto L28;
        int r2 = this.mErrorTextColor;
    L24:
        rrrdsSWyuBDRNBow(r0, r2);
        return;
    L28:
        r2 = this.mNormalTextColor;
        goto L24
    L7:
        r32 = true;
        goto L3
    }

    void updateHelpMessageText(CharSequence r1) {
        Textobject r0 = this.mHelpMessageobject;
        if (r0 is null) goto L14;
        DQVEtxaJKNbRfjYY(r0, r1);
        return;
    }
}

