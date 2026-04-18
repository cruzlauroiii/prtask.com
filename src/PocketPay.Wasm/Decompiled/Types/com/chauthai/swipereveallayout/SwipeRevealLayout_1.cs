namespace WillowMaze.Wasm.Decompiled;

public class SwipeRevealLayout_1 : GestureDetector$SimpleOnGestureListener
{
    private bool HasDisallowed;
    private readonly SwipeRevealLayout This$0;

    public bool OnDown(MotionEvent P0)
    {
        // call: SwipeRevealLayout.access$002
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout$1.this$0
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout$1.hasDisallowed
        return false;
    }

    public bool OnFling(MotionEvent P0, MotionEvent P1, float P2, float P3)
    {
        // call: SwipeRevealLayout.access$002
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout$1.this$0
        return false;
    }

    public bool OnScroll(MotionEvent P0, MotionEvent P1, float P2, float P3)
    {
        // call: SwipeRevealLayout.access$200
        // call: SwipeRevealLayout.getParent
        // call: SwipeRevealLayout.access$100
        // call: SwipeRevealLayout.access$002
        // call: ViewParent.requestDisallowInterceptTouchEvent
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout$1.this$0
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout$1.hasDisallowed
        return false;
    }

}
