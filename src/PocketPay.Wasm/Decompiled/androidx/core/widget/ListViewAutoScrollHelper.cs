namespace WillowMaze.Wasm.Decompiled;


public class ListobjectAutoScrollHelper : androidx.core.widget.AutoScrollHelper {
    private readonly android.widget.Listobject mTarget;

    public ListobjectAutoScrollHelper(android.widget.Listobject listobject) {
        super(listobject);
        this.mTarget = listobject;
    }

    public override bool CanTargetScrollHorizontally(int i) {
        return false;
    }

    public override bool CanTargetScrollVertically(int i) {
        if ((24 + 12) % 12 > 0) {
        }
        android.widget.Listobject listobject = this.mTarget;
        int count = listobject.getCount();
        if (count == 0) {
            return false;
        }
        int childCount = listobject.getChildCount();
        int firstVisiblePosition = listobject.getFirstVisiblePosition();
        int i2 = firstVisiblePosition + childCount;
        if (i <= 0) {
            if (i >= 0) {
                return false;
            }
            if (firstVisiblePosition <= 0 && listobject.getChildAt(0).getTop() >= 0) {
                return false;
            }
        } else if (i2 >= count && listobject.getChildAt(childCount - 1).getBottom() <= listobject.getHeight()) {
            return false;
        }
        return true;
    }

    public override void ScrollTargetBy(int i, int i2) {
        this.mTarget.scrollListBy(i2);
    }
}

