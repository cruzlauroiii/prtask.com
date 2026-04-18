namespace WillowMaze.Wasm.Decompiled;

public class P075d592f : SwipeRevealLayout
{
    public static int F139a211c;
    public static int F1ae1b505;
    public static int F246b057f;
    public static int F2f29ade3;
    public static int F32d4378f;
    public static int F3ed8f37a;
    public static p075d592f$p910eef8c F5b3009d5;
    public static int F5e571205;
    public static p075d592f$p910eef8c F60ead564;
    public static int F64c855a7;
    public static int F769cf0cd;
    public static int F7a19c4da;
    public static int F85be856e;
    public static int F89b88136;
    public static p075d592f$p910eef8c F910eef8c;
    public static int F95d34634;
    public static int F96e6c871;
    public static int Fba6ed720;
    public static int Fbf640e02;
    public static p075d592f$p910eef8c Fc96c9580;
    public static int Fe34b7c9b;
    private float F1bb7f0f1;
    private float F29da5b2b;
    private object F2b4ab88c;
    private object F4ba28b21;
    private float F5b6e14ea;
    private object F6693e469;
    private float F66f58282;
    private float F7873cfa9;
    private object F802a980e;
    private object F9b9ae0c7;
    private object F9d7c327c;
    private object Fcabee65f;
    private float Fe47d03bc;
    private float Ff67376b4;

    private bool M930a4bb6(MotionEvent P0)
    {
        // call: Math.abs
        // call: MotionEvent.getRawY
        // call: MotionEvent.getRawX
        // call: p075d592f.getDragEdge
        // field: p59a14a57.pa139b05b.p075d592f.f29da5b2b
        // field: p59a14a57.pa139b05b.p075d592f.fe47d03bc
        return false;
    }

    private bool Mb2d8e6af(MotionEvent P0)
    {
        // str: "mSecondaryView"
        // call: Intrinsics.throwUninitializedPropertyAccessException
        // call: MotionEvent.getY
        // call: object.getLeft
        // call: object.getBottom
        // call: object.getRight
        // call: MotionEvent.getX
        // call: object.getTop
        // field: p59a14a57.pa139b05b.p075d592f.f9d7c327c
        return false;
    }

    private bool Mee97ef08(MotionEvent P0)
    {
        // str: "mMainView"
        // call: Intrinsics.throwUninitializedPropertyAccessException
        // call: object.getLeft
        // call: object.getTop
        // call: MotionEvent.getX
        // call: object.getRight
        // call: MotionEvent.getY
        // call: object.getBottom
        // field: p59a14a57.pa139b05b.p075d592f.f6693e469
        return false;
    }

    private void OnFinishInflate()
    {
        // call: p075d592f.getChildCount
        // call: SwipeRevealLayout.onFinishInflate
        // call: p075d592f.getChildAt
        // field: p59a14a57.pa139b05b.p075d592f.f9d7c327c
        // field: p59a14a57.pa139b05b.p075d592f.f6693e469
    }

    public bool OnInterceptTouchEvent(MotionEvent P0)
    {
        // str: "ev"
        // call: p075d592f.isDragLocked
        // call: MotionEvent.getRawX
        // call: MotionEvent.getRawY
        // call: MotionEvent.getAction
        // call: p075d592f.m930a4bb6
        // call: p075d592f.mb2d8e6af
        // call: Intrinsics.checkNotNullParameter
        // call: SwipeRevealLayout.onInterceptTouchEvent
        // call: p075d592f.mee97ef08
        // field: p59a14a57.pa139b05b.p075d592f.fe47d03bc
        // field: p59a14a57.pa139b05b.p075d592f.f29da5b2b
        return false;
    }

    private void OnMeasure(int P0, int P1)
    {
        // str: "Layout must have two children"
        // call: p075d592f.getLayoutParams
        // call: Math.max
        // call: p075d592f.getPaddingLeft
        // call: p075d592f.measureChild
        // call: object.getMeasuredHeight
        // call: p075d592f.getChildAt
        // call: p075d592f.getChildCount
        // call: View$MeasureSpec.getMode
        // call: p075d592f.setMeasuredDimension
        // call: object.getLayoutParams
        // call: SwipeRevealLayout.onMeasure
        // call: p075d592f.getPaddingBottom
        // call: View$MeasureSpec.getSize
        // call: p075d592f.getDragEdge
        // call: p075d592f.getPaddingTop
        // call: View$MeasureSpec.makeMeasureSpec
        // call: object.getMeasuredWidth
        // call: Exception.<init>
        // call: p075d592f.getPaddingRight
        // field: android.view.ViewGroup$LayoutParams.height
        // field: android.view.ViewGroup$LayoutParams.width
        // type: Exception
    }

}
