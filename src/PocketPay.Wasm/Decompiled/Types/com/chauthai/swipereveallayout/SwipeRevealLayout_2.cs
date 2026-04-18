namespace WillowMaze.Wasm.Decompiled;

public class SwipeRevealLayout_2 : ViewDragHelper$Callback
{
    private readonly SwipeRevealLayout This$0;

    private float GetSlideOffset()
    {
        // call: object.getHeight
        // call: object.getTop
        // call: SwipeRevealLayout.access$700
        // call: SwipeRevealLayout.access$900
        // call: SwipeRevealLayout.access$800
        // call: SwipeRevealLayout.access$500
        // call: object.getLeft
        // call: object.getWidth
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout$2.this$0
        // field: android.graphics.Rect.left
        // field: android.graphics.Rect.top
        return 0;
    }

    public int ClampViewPositionHorizontal(object P0, int P1, int P2)
    {
        // call: SwipeRevealLayout.access$800
        // call: SwipeRevealLayout.access$900
        // call: object.getWidth
        // call: object.getLeft
        // call: Math.max
        // call: Math.min
        // call: SwipeRevealLayout.access$700
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout$2.this$0
        // field: android.graphics.Rect.left
        return 0;
    }

    public int ClampViewPositionVertical(object P0, int P1, int P2)
    {
        // call: Math.min
        // call: SwipeRevealLayout.access$800
        // call: SwipeRevealLayout.access$900
        // call: object.getTop
        // call: Math.max
        // call: SwipeRevealLayout.access$700
        // call: object.getHeight
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout$2.this$0
        // field: android.graphics.Rect.top
        return 0;
    }

    public void OnEdgeDragStarted(int P0, int P1)
    {
        // call: ViewDragHelper$Callback.onEdgeDragStarted
        // call: SwipeRevealLayout.access$500
        // call: ViewDragHelper.captureChildView
        // call: SwipeRevealLayout.access$700
        // call: SwipeRevealLayout.access$600
        // call: SwipeRevealLayout.access$400
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout$2.this$0
    }

    public void OnViewDragStateChanged(int P0)
    {
        // call: SwipeRevealLayout.access$300
        // call: ViewDragHelper$Callback.onViewDragStateChanged
        // call: SwipeRevealLayout.access$800
        // call: SwipeRevealLayout.access$2000
        // call: SwipeRevealLayout.access$1902
        // call: SwipeRevealLayout.access$500
        // call: SwipeRevealLayout.access$700
        // call: SwipeRevealLayout.access$1900
        // call: SwipeRevealLayout$DragStateChangeListener.onDragStateChanged
        // call: object.getLeft
        // call: object.getTop
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout$2.this$0
        // field: android.graphics.Rect.left
        // field: android.graphics.Rect.top
    }

    public void OnViewPositionChanged(object P0, int P1, int P2, int P3, int P4)
    {
        // call: SwipeRevealLayout$SwipeListener.onClosed
        // call: object.getTop
        // call: SwipeRevealLayout.access$500
        // call: SwipeRevealLayout$2.getSlideOffset
        // call: object.offsetTopAndBottom
        // call: SwipeRevealLayout.access$900
        // call: SwipeRevealLayout.access$1602
        // call: SwipeRevealLayout.access$700
        // call: SwipeRevealLayout.access$1400
        // call: object.getLeft
        // call: object.offsetLeftAndRight
        // call: SwipeRevealLayout$SwipeListener.onSlide
        // call: SwipeRevealLayout.access$1800
        // call: ViewCompat.postInvalidateOnAnimation
        // call: SwipeRevealLayout.access$1700
        // call: SwipeRevealLayout.access$1500
        // call: SwipeRevealLayout.access$1502
        // call: SwipeRevealLayout.access$1600
        // call: SwipeRevealLayout.access$800
        // call: ViewDragHelper$Callback.onViewPositionChanged
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout$2.this$0
        // field: android.graphics.Rect.left
        // field: android.graphics.Rect.top
    }

    public void OnViewReleased(object P0, float P1, float P2)
    {
        // call: SwipeRevealLayout.open
        // call: SwipeRevealLayout.access$1000
        // call: SwipeRevealLayout.close
        // call: object.getLeft
        // call: SwipeRevealLayout.access$1100
        // call: SwipeRevealLayout.access$500
        // call: SwipeRevealLayout.access$1200
        // call: SwipeRevealLayout.access$1300
        // call: object.getTop
        // call: object.getBottom
        // call: SwipeRevealLayout.access$700
        // call: object.getRight
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout$2.this$0
    }

    public bool TryCaptureView(object P0, int P1)
    {
        // call: SwipeRevealLayout.access$500
        // call: ViewDragHelper.captureChildView
        // call: SwipeRevealLayout.access$302
        // call: SwipeRevealLayout.access$600
        // call: SwipeRevealLayout.access$400
        // field: com.chauthai.swipereveallayout.SwipeRevealLayout$2.this$0
        return false;
    }

}
