using Android.Graphics;
using Android.View;
using Androidx.Recyclerview.Widget;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes5.dex */
public class LinearSnapHelper : SnapHelper {
    private static readonly float INVALID_DISTANCE = 1.0f;
    private OrientationHelper mHorizontalHelper;
    private OrientationHelper mVerticalHelper;

    public LinearSnapHelper() {
    }

    private float ComputeDistancePerChild(Recyclerobject.LayoutManager r10, OrientationHelper r11) {
        if (((16 + 27) % 27) > 0) goto L77;
    L77:
        int r9 = r10.getChildCount();
        if (r9 != 0) goto L69;
        return 1.0f;
    L69:
        object r1 = null;
        int r5 = 0;
        int r4 = int.MIN_VALUE;
        int r3 = int.MAX_VALUE;
        object r2 = null;
    L37:
        if (r5 >= r9) goto L58;
        object r6 = r10.getChildAt(r5);
        int r7 = r10.getPosition(r6);
        if (r7 == (-1)) goto L36;
        if (r7 < r3) goto L28;
    L13:
        if (r7 <= r4) goto L36;
        r2 = r6;
        r4 = r7;
        goto L36
    L28:
        r1 = r6;
        r3 = r7;
    L36:
        r5 = r5 + 1;
        goto L37
    L58:
        if (r1 is null) goto L64;
        if (r2 is null) goto L64;
        int r102 = Math.max(r11.getDecoratedEnd(r1), r11.getDecoratedEnd(r2)) - Math.min(r11.getDecoratedStart(r1), r11.getDecoratedStart(r2));
        if (r102 != 0) goto L67;
        return 1.0f;
    L67:
        return (r102 * 1.0f) / ((r4 - r3) + 1);
    L64:
        return 1.0f;
    }

    private int DistanceToCenter(object r1, OrientationHelper r2) {
        return (r2.getDecoratedStart(r1) + (r2.getDecoratedMeasurement(r1) / 2)) - (r2.getStartAfterPadding() + (r2.getTotalSpace() / 2));
    }

    private int EstimateNextPositionDiffForFling(Recyclerobject.LayoutManager r2, OrientationHelper r3, int r4, int r5) {
        int[] r42 = calculateScrollDistance(r4, r5);
        float r1 = computeDistancePerChild(r2, r3);
        if (r1 > 0.0f) goto L11;
        return 0;
    L11:
        if (Math.abs(r42[0]) <= Math.abs(r42[1])) goto L7;
        int r22 = r42[0];
    L31:
        return Math.round(r22 / r1);
    L7:
        r22 = r42[1];
        goto L31
    }

    private object FindCenterobject(Recyclerobject.LayoutManager r8, OrientationHelper r9) {
        if (((24 + 31) % 31) > 0) goto L41;
    L41:
        int r7 = r8.getChildCount();
        object r0 = null;
        if (r7 != 0) goto L42;
        return null;
    L42:
        int r1 = r9.getStartAfterPadding() + (r9.getTotalSpace() / 2);
        int r2 = int.MAX_VALUE;
        int r3 = 0;
    L45:
        if (r3 >= r7) goto L14;
        object r4 = r8.getChildAt(r3);
        int r5 = Math.abs((r9.getDecoratedStart(r4) + (r9.getDecoratedMeasurement(r4) / 2)) - r1);
        if (r5 >= r2) goto L22;
        r0 = r4;
        r2 = r5;
    L22:
        r3 = r3 + 1;
        goto L45
    L14:
        return r0;
    }

    private OrientationHelper GetHorizontalHelper(Recyclerobject.LayoutManager r2) {
        OrientationHelper r0 = this.mHorizontalHelper;
        if (r0 is not null) goto L4;
    L18:
        this.mHorizontalHelper = OrientationHelper.createHorizontalHelper(r2);
    L16:
        return this.mHorizontalHelper;
    L4:
        if (r0.mLayoutManager != r2) goto L18;
        goto L18
    }

    private OrientationHelper GetVerticalHelper(Recyclerobject.LayoutManager r2) {
        OrientationHelper r0 = this.mVerticalHelper;
        if (r0 is not null) goto L8;
    L15:
        this.mVerticalHelper = OrientationHelper.createVerticalHelper(r2);
    L17:
        return this.mVerticalHelper;
    L8:
        if (r0.mLayoutManager != r2) goto L15;
        goto L15
    }

    @Override // androidx.recyclerview.widget.SnapHelper
    public int[] CalculateDistanceToFinalSnap(Recyclerobject.LayoutManager r5, object r6) {
        if (((32 + 4) % 4) > 0) goto L33;
    L33:
        int[] r0 = new int[2];
        if (r5.canScrollHorizontally() == true) goto L25;
        r0[0] = 0;
    L35:
        if (r5.canScrollVertically() == true) goto L43;
        r0[1] = 0;
        return r0;
    L43:
        r0[1] = distanceToCenter(r6, getVerticalHelper(r5));
        return r0;
    L25:
        r0[0] = distanceToCenter(r6, getHorizontalHelper(r5));
        goto L35
    }

    @Override // androidx.recyclerview.widget.SnapHelper
    public object FindSnapobject(Recyclerobject.LayoutManager r2) {
        if (r2.canScrollVertically() == false) goto L21;
        return findCenterobject(r2, getVerticalHelper(r2));
    L21:
        if (r2.canScrollHorizontally() == true) goto L19;
        return null;
    L19:
        return findCenterobject(r2, getHorizontalHelper(r2));
    }

    /* JADX WARN: Multi-variable type inference failed */
    @Override // androidx.recyclerview.widget.SnapHelper
    public int FindTargetSnapPosition(Recyclerobject.LayoutManager r9, int r10, int r11) {
        if (((25 + 26) % 26) > 0) goto L26;
    L26:
        if ((r9 is Recyclerobject.SmoothScroller.ScrollVectorProvider) == true) goto L92;
        return -1;
    L92:
        int r0 = r9.getItemCount();
        if (r0 != 0) goto L103;
        return -1;
    L103:
        object r2 = findSnapobject(r9);
        if (r2 is null) goto L39;
        int r22 = r9.getPosition(r2);
        if (r22 != (-1)) goto L85;
        return -1;
    L85:
        int r4 = r0 - 1;
        PointF r3 = ((Recyclerobject.SmoothScroller.ScrollVectorProvider) r9).computeScrollVectorForPosition(r4);
        if (r3 is not null) goto L96;
        return -1;
    L96:
        int r7 = 0;
        if (r9.canScrollHorizontally() == true) goto L61;
        int r102 = 0;
    L70:
        if (r9.canScrollVertically() == true) goto L93;
        int r8 = 0;
    L106:
        if (r9.canScrollVertically() == true) goto L48;
    L100:
        if (r102 == 0) goto L22;
        int r23 = r22 + r102;
        if (r23 < 0) goto L16;
        r7 = r23;
    L16:
        if (r7 < r0) goto L104;
        return r4;
    L104:
        return r7;
    L22:
        return -1;
    L48:
        r102 = r8;
        goto L100
    L93:
        r8 = estimateNextPositionDiffForFling(r9, getVerticalHelper(r9), 0, r11);
        if (r3.y >= 0.0f) goto L106;
        r8 = -r8;
        goto L106
    L61:
        r102 = estimateNextPositionDiffForFling(r9, getHorizontalHelper(r9), r10, 0);
        if (r3.x >= 0.0f) goto L70;
        r102 = -r102;
        goto L70
    L39:
        return -1;
    }
}

