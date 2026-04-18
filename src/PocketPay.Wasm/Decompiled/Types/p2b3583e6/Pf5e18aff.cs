namespace WillowMaze.Wasm.Decompiled;

public class Pf5e18aff
{
    private static float F29ceefa3;
    private static long F3e9187c1;
    private static float F44e150d2;
    private static long F4dff4177;
    private static float F50804394;
    private static long F5863ad0c;
    private static float F6301fab0;
    private static long F8b472df1;
    private static long Fb4e98636;
    private static float Ff8ce05ae;

    public static float M0d172be3(float P0, object P1)
    {
        // str: "context"
        // call: object.getResources
        // call: Intrinsics.checkNotNullParameter
        // call: Resources.getDisplayMetrics
        // field: android.util.DisplayMetrics.density
        return 0;
    }

    public static int M179f7616(int P0, object P1)
    {
        // str: "context"
        // call: Intrinsics.checkNotNullParameter
        // call: Resources.getDisplayMetrics
        // call: object.getResources
        // field: android.util.DisplayMetrics.densityDpi
        return 0;
    }

    public static void M1a1e7b55(EditText P0, int P1)
    {
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: EditText.getBackground
        // call: Drawable.setColorFilter
        // field: android.graphics.PorterDuff$Mode.SRC_IN
    }

    public static void M1a1e7b55(ImageView P0, int P1)
    {
        // str: "<this>"
        // str: "wrap(...)"
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.checkNotNullExpressionValue
        // call: ImageView.getDrawable
        // call: DrawableCompat.wrap
        // call: DrawableCompat.setTint
        // call: ImageView.setImageDrawable
    }

    public static void M1a1e7b55(TextInputEditText P0, int P1)
    {
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: Drawable.setColorFilter
        // call: TextInputEditText.getBackground
        // field: android.graphics.PorterDuff$Mode.SRC_IN
    }

    public static p7c1cb072 M1d5ea209(Fragment P0, Func<object, object> P1)
    {
        // str: "from(...)"
        // str: "inflater"
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: PopupWindow.<init>
        // call: LayoutInflater.from
        // call: Intrinsics.checkNotNullExpressionValue
        // call: Fragment.requireContext
        // call: ViewBinding.getRoot
        // call: p7c1cb072.<init>
        // call: Func<object, object>.invoke
        // type: PopupWindow
        // type: p7c1cb072
        return default!;
    }

    public static void M1e0e453d(object P0, long P1, long P2, int P3, object P4)
    {
        // call: pf5e18aff.ma5db1a0c
    }

    public static void M2fa6d087(object P0, long P1, Func<object, object> P2, int P3, object P4)
    {
        // call: pf5e18aff.m6513f520
    }

    private static bool M31886cbf(Func<object> P0, object P1, MotionEvent P2)
    {
        // call: MotionEvent.getAction
        // call: Func<object>.invoke
        return false;
    }

    public static void M31f92f3f(object P0, CharSequence P1)
    {
        // str: "<this>"
        // str: "text"
        // call: Intrinsics.checkNotNullParameter
        // call: DecryptString.decryptString
        // call: ClipData.newPlainText
        // call: object.getString
        // call: ContextCompat.getSystemService
        // call: ClipboardManager.setPrimaryClip
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p2b3583e6.R$string.copied_text_label
        // type: ClipboardManager
    }

    public static TypedValue M32d4d4a8(object P0, int P1)
    {
        // str: "<this>"
        // call: TypedValue.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: Resources$Theme.resolveAttribute
        // call: object.getTheme
        // type: TypedValue
        return default!;
    }

    public static int M48570a62(Fragment P0)
    {
        // str: "<this>"
        // call: object.getWindowVisibleDisplayFrame
        // call: FragmentActivity.getWindow
        // call: Fragment.getActivity
        // call: Rect.<init>
        // call: Window.getDecorView
        // call: Intrinsics.checkNotNullParameter
        // field: android.graphics.Rect.top
        // type: Rect
        return 0;
    }

    public static void M6513f520(object P0, long P1, Func<object, object> P2)
    {
        // str: "onClick"
        // str: "<this>"
        // call: pf5e18aff$pd41d8cd9$p95263d50.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: object.setOnClickListener
        // type: pf5e18aff$pd41d8cd9$p95263d50
    }

    public static bool M7faaf36d(Func<object> P0, object P1, MotionEvent P2)
    {
        // call: pf5e18aff.m31886cbf
        return false;
    }

    public static void M810625f4(object P0, long P1, int P2, int P3, object P4)
    {
        // call: pf5e18aff.mfee57815
    }

    public static void M9af2f1e5(DialogFragment P0)
    {
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: Dialog.getWindow
        // call: Resources.getSystem
        // call: Resources.getDisplayMetrics
        // call: Window.setLayout
        // call: Rect.width
        // call: Rect.<init>
        // call: DialogFragment.getDialog
        // field: android.util.DisplayMetrics.widthPixels
        // field: android.util.DisplayMetrics.heightPixels
        // type: Rect
    }

    public static int Ma0c761c9(int P0, object P1)
    {
        // str: "context"
        // call: Resources.getDisplayMetrics
        // call: object.getResources
        // call: Intrinsics.checkNotNullParameter
        // field: android.util.DisplayMetrics.densityDpi
        return 0;
    }

    public static void Ma5db1a0c(object P0, long P1, long P2)
    {
        // str: "<this>"
        // call: ViewPropertyAnimator.setListener
        // call: object.animate
        // call: ViewPropertyAnimator.setDuration
        // call: object.setAlpha
        // call: ViewPropertyAnimator.setStartDelay
        // call: ViewPropertyAnimator.alpha
        // call: object.setVisibility
        // call: Intrinsics.checkNotNullParameter
    }

    private static void Ma9725164(long P0, Func<object, object> P1, object P2)
    {
        // call: pc77ce85b.lock
        // call: Func<object, object>.invoke
        // call: pc77ce85b.isLocked
        // call: Intrinsics.checkNotNull
        // field: p2b3583e6.pc77ce85b.f76425f17
    }

    public static int Mab7e61bf(object P0, int P1)
    {
        // str: "<this>"
        // call: ContextCompat.getColor
        // call: Intrinsics.checkNotNullParameter
        // call: object.getContext
        return 0;
    }

    public static void Mae4c9b0e(EditText P0, Func<object> P1)
    {
        // str: "<this>"
        // str: "onClick"
        // call: EditText.setOnTouchListener
        // call: Intrinsics.checkNotNullParameter
        // call: pf5e18aff$pd41d8cd9$pcca4ef0e.<init>
        // type: pf5e18aff$pd41d8cd9$pcca4ef0e
    }

    public static void Mbed9ddc0(long P0, Func<object, object> P1, object P2)
    {
        // call: pf5e18aff.ma9725164
    }

    public static float Me1a67667(float P0)
    {
        // call: Resources.getSystem
        // call: Resources.getDisplayMetrics
        // field: android.util.DisplayMetrics.density
        return 0;
    }

    public static void Me7ef8044(TextView P0, int P1)
    {
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: Drawable.setTint
        // call: TextView.getCompoundDrawables
    }

    public static void Mfee57815(object P0, long P1, int P2)
    {
        // str: "vibrator"
        // str: "<this>"
        // call: VibrationEffect.createOneShot
        // call: Vibrator.hasVibrator
        // call: Intrinsics.checkNotNullParameter
        // call: Vibrator.vibrate
        // call: object.getSystemService
    }

}
