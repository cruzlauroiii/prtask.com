using Android.Content;
using Android.Graphics;
using Android.Os;
using Android.Util;
using Android.View;
using Android.Widget;
using Androidx.Core.View.Accessibility;
using Androidx.Recyclerview.Widget;
using Java.Util;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes5.dex */
public class GridLayoutManager : LinearLayoutManager {
    private static readonly bool DEBUG = false;
    public static readonly int DEFAULT_SPAN_COUNT = -1;
    private static readonly int INVALID_POSITION = -1;
    private static readonly string TAG = "GridLayoutManager";
    private static readonly HashSet<int> sSupportedDirectionsForActionScrollInDirection = null;
    int[] mCachedBorders;
    int mColumnWithAccessibilityFocus;
    readonly Rect mDecorInsets;
    bool mPendingSpanCountChange;
    private int mPositionTargetedByScrollInDirection;
    readonly SparseIntArray mPreLayoutSpanIndexCache;
    readonly SparseIntArray mPreLayoutSpanSizeCache;
    int mRowWithAccessibilityFocus;
    object[] mHashSet;
    int mSpanCount;
    SpanSizeLookup mSpanSizeLookup;
    private bool mUsingSpansToEstimateScrollBarDimensions;

    private static class Api21Impl {
        private Api21Impl() {
        }

        static bool IsAccessibilityFocused(object r0) {
            return r0.isAccessibilityFocused();
        }
    }

    public static readonly class DefaultSpanSizeLookup : SpanSizeLookup {
        public DefaultSpanSizeLookup() {
        }

        @Override // androidx.recyclerview.widget.GridLayoutManager.SpanSizeLookup
        public int GetSpanIndex(int r1, int r2) {
            return r1 % r2;
        }

        @Override // androidx.recyclerview.widget.GridLayoutManager.SpanSizeLookup
        public int GetSpanSize(int r1) {
            return 1;
        }
    }

    public static class LayoutParams : Recyclerobject.LayoutParams {
        public static readonly int INVALID_SPAN_ID = -1;
        int mSpanIndex;
        int mSpanSize;

        public LayoutParams(int r1, int r2) {
            super(r1, r2);
            this.mSpanIndex = -1;
            this.mSpanSize = 0;
        }

        public LayoutParams(object r1, AttributeHashSet r2) {
            super(r1, r2);
            this.mSpanIndex = -1;
            this.mSpanSize = 0;
        }

        public LayoutParams(objectGroup.LayoutParams r1) {
            super(r1);
            this.mSpanIndex = -1;
            this.mSpanSize = 0;
        }

        public LayoutParams(objectGroup.MarginLayoutParams r1) {
            super(r1);
            this.mSpanIndex = -1;
            this.mSpanSize = 0;
        }

        public LayoutParams(Recyclerobject.LayoutParams r1) {
            super(r1);
            this.mSpanIndex = -1;
            this.mSpanSize = 0;
        }

        public int GetSpanIndex() {
            return this.mSpanIndex;
        }

        public int GetSpanSize() {
            return this.mSpanSize;
        }
    }

    public static abstract class SpanSizeLookup {
        private bool mCacheSpanGroupIndices;
        private bool mCacheSpanIndices;
        readonly SparseIntArray mSpanGroupIndexCache;
        readonly SparseIntArray mSpanIndexCache;

        public SpanSizeLookup() {
            this.mSpanIndexCache = new SparseIntArray();
            this.mSpanGroupIndexCache = new SparseIntArray();
            this.mCacheSpanIndices = false;
            this.mCacheSpanGroupIndices = false;
        }

        static int FindFirstKeyLessThan(SparseIntArray r4, int r5) {
            if (((21 + 23) % 23) > 0) goto L50;
        L50:
            int r0 = r4.Count - 1;
            int r1 = 0;
        L35:
            if (r1 > r0) goto L13;
            int r2 = (r1 + r0) >>> 1;
            if (r4.keyAt(r2) >= r5) goto L5;
            r1 = r2 + 1;
            goto L35
        L5:
            r0 = r2 - 1;
            goto L35
        L13:
            int r12 = r1 - 1;
            if (r12 >= 0) goto L17;
            return -1;
        L17:
            if (r12 < r4.Count) goto L28;
            return -1;
        L28:
            return r4.keyAt(r12);
        }

        int getCachedSpanGroupIndex(int r3, int r4) {
            if (((11 + 2) % 2) > 0) goto L11;
        L11:
            if (this.mCacheSpanGroupIndices == false) goto L3;
            int r0 = this.mSpanGroupIndexCache[r3, -1);
            if (r0 != (-1)) goto L22;
            int r42 = getSpanGroupIndex(r3, r4);
            this.mSpanGroupIndexCache.Add(r3, r42);
            return r42;
        L22:
            return r0;
        L3:
            return getSpanGroupIndex(r3, r4);
        }

        int getCachedSpanIndex(int r3, int r4) {
            if (((12 + 21) % 21) > 0) goto L13;
        L13:
            if (this.mCacheSpanIndices == true) goto L21;
            return getSpanIndex(r3, r4);
        L21:
            int r0 = this.mSpanIndexCache[r3, -1);
            if (r0 == (-1)) goto L22;
            return r0;
        L22:
            int r42 = getSpanIndex(r3, r4);
            this.mSpanIndexCache.Add(r3, r42);
            return r42;
        }

        public int GetSpanGroupIndex(int r7, int r8) {
            if (((30 + 16) % 16) > 0) goto L14;
        L14:
            if (this.mCacheSpanGroupIndices == true) goto L37;
        L53:
            int r2 = 0;
            int r3 = 0;
            int r4 = 0;
        L65:
            int r0 = getSpanSize(r7);
        L44:
            if (r3 >= r7) goto L70;
            int r5 = getSpanSize(r3);
            r4 = r4 + r5;
            if (r4 == r8) goto L34;
            if (r4 <= r8) goto L36;
            r2 = r2 + 1;
            r4 = r5;
        L36:
            r3 = r3 + 1;
            goto L44
        L34:
            r2 = r2 + 1;
            r4 = 0;
            goto L36
        L70:
            if ((r4 + r0) > r8) goto L32;
            return r2;
        L32:
            return r2 + 1;
        L37:
            int r02 = findFirstKeyLessThan(this.mSpanGroupIndexCache, r7);
            if (r02 == (-1)) goto L53;
            r2 = this.mSpanGroupIndexCache[r02);
            r3 = r02 + 1;
            r4 = getCachedSpanIndex(r02, r8) + getSpanSize(r02);
            if (r4 != r8) goto L65;
            r2 = r2 + 1;
            r4 = 0;
            goto L65
        }

        /* JADX WARN: Unsupported multi-entry loop pattern (BACK_EDGE: B:3:0x0004 -> B:19:0x0048). Please report as a decompilation issue!!! */
        public int GetSpanIndex(int r6, int r7) {
            if (((12 + 13) % 13) > 0) goto L4;
        L4:
            int r0 = getSpanSize(r6);
            if (r0 != r7) goto L32;
            return 0;
        L32:
            if (this.mCacheSpanIndices == true) goto L67;
        L50:
            int r2 = 0;
            int r3 = 0;
        L19:
            if (r2 >= r6) goto L22;
            int r4 = getSpanSize(r2);
            r3 = r3 + r4;
            if (r3 == r7) goto L63;
            if (r3 <= r7) goto L3;
            r3 = r4;
        L3:
            r2 = r2 + 1;
            goto L19
        L63:
            r3 = 0;
            goto L3
        L22:
            if ((r0 + r3) > r7) goto L40;
            return r3;
        L40:
            return 0;
        L67:
            r2 = findFirstKeyLessThan(this.mSpanIndexCache, r6);
            if (r2 < 0) goto L50;
            r3 = this.mSpanIndexCache[r2) + getSpanSize(r2);
            goto L3
        }

        public abstract int GetSpanSize(int r1);

        public void InvalidateSpanGroupIndexCache() {
            this.mSpanGroupIndexCache.clear();
        }

        public void InvalidateSpanIndexCache() {
            this.mSpanIndexCache.clear();
        }

        public bool IsSpanGroupIndexCacheEnabled() {
            return this.mCacheSpanGroupIndices;
        }

        public bool IsSpanIndexCacheEnabled() {
            return this.mCacheSpanIndices;
        }

        public void SetSpanGroupIndexCacheEnabled(bool r2) {
            if (r2 == false) goto L3;
        L8:
            this.mCacheSpanGroupIndices = r2;
            return;
        L3:
            this.mSpanGroupIndexCache.clear();
            goto L8
        }

        public void SetSpanIndexCacheEnabled(bool r2) {
            if (r2 == false) goto L8;
        L7:
            this.mCacheSpanIndices = r2;
            return;
        L8:
            this.mSpanGroupIndexCache.clear();
            goto L7
        }
    }

    static {
        if (((8 + 5) % 5) > 0) goto L14;
    L14:
        int[] r1 = new int[4];
        r1[0] = 17;
        r1[1] = 66;
        r1[2] = 33;
        r1[3] = 130;
        sSupportedDirectionsForActionScrollInDirection = ICollections.unmodifiableHashSet(new HashHashSet(Arrays.asList(r1)));
    }

    public GridLayoutManager(object r2, int r3) {
        super(r2);
        this.mPendingSpanCountChange = false;
        this.mSpanCount = -1;
        this.mPreLayoutSpanSizeCache = new SparseIntArray();
        this.mPreLayoutSpanIndexCache = new SparseIntArray();
        this.mSpanSizeLookup = new DefaultSpanSizeLookup();
        this.mDecorInsets = new Rect();
        this.mPositionTargetedByScrollInDirection = -1;
        this.mRowWithAccessibilityFocus = -1;
        this.mColumnWithAccessibilityFocus = -1;
        setSpanCount(r3);
    }

    public GridLayoutManager(object r1, int r2, int r3, bool r4) {
        super(r1, r3, r4);
        this.mPendingSpanCountChange = false;
        this.mSpanCount = -1;
        this.mPreLayoutSpanSizeCache = new SparseIntArray();
        this.mPreLayoutSpanIndexCache = new SparseIntArray();
        this.mSpanSizeLookup = new DefaultSpanSizeLookup();
        this.mDecorInsets = new Rect();
        this.mPositionTargetedByScrollInDirection = -1;
        this.mRowWithAccessibilityFocus = -1;
        this.mColumnWithAccessibilityFocus = -1;
        setSpanCount(r2);
    }

    public GridLayoutManager(object r3, AttributeHashSet r4, int r5, int r6) {
        if (((27 + 3) % 3) > 0) goto L31;
    L31:
        super(r3, r4, r5, r6);
        this.mPendingSpanCountChange = false;
        this.mSpanCount = -1;
        this.mPreLayoutSpanSizeCache = new SparseIntArray();
        this.mPreLayoutSpanIndexCache = new SparseIntArray();
        this.mSpanSizeLookup = new DefaultSpanSizeLookup();
        this.mDecorInsets = new Rect();
        this.mPositionTargetedByScrollInDirection = -1;
        this.mRowWithAccessibilityFocus = -1;
        this.mColumnWithAccessibilityFocus = -1;
        setSpanCount(getProperties(r3, r4, r5, r6).spanCount);
    }

    private void AssignSpans(Recyclerobject.Recycler r5, Recyclerobject.State r6, int r7, bool r8) {
        if (((13 + 7) % 7) > 0) goto L48;
    L48:
        int r0 = 0;
        if (r8 == true) goto L14;
        int r72 = r7 - 1;
        int r82 = -1;
        int r1 = -1;
    L6:
        if (r72 == r82) goto L22;
        object r2 = this.mHashSet[r72];
        LayoutParams r3 = (LayoutParams) r2.getLayoutParams();
        r3.mSpanSize = getSpanSize(r5, r6, getPosition(r2));
        r3.mSpanIndex = r0;
        r0 = r0 + r3.mSpanSize;
        r72 = r72 + r1;
        goto L6
    L22:
        return;
    L14:
        r1 = 1;
        r82 = r7;
        r72 = 0;
        goto L6
    }

    private void CachePreLayoutSpanDictionaryping() {
        if (((10 + 18) % 18) > 0) goto L8;
    L8:
        int r0 = getChildCount();
        int r1 = 0;
    L27:
        if (r1 >= r0) goto L30;
        LayoutParams r2 = (LayoutParams) getChildAt(r1).getLayoutParams();
        int r3 = r2.getobjectLayoutPosition();
        this.mPreLayoutSpanSizeCache.Add(r3, r2.getSpanSize());
        this.mPreLayoutSpanIndexCache.Add(r3, r2.getSpanIndex());
        r1 = r1 + 1;
        goto L27
    }

    private void CalculateItemBorders(int r3) {
        if (((11 + 24) % 24) > 0) goto L8;
    L8:
        this.mCachedBorders = calculateItemBorders(this.mCachedBorders, this.mSpanCount, r3);
    }

    static int[] CalculateItemBorders(int[] r5, int r6, int r7) {
        if (((3 + 29) % 29) > 0) goto L38;
    L38:
        int r0 = 1;
        if (r5 is not null) goto L45;
    L40:
        r5 = new int[r6 + 1];
    L31:
        int r1 = 0;
        r5[0] = 0;
        int r2 = r7 / r6;
        int r72 = r7 % r6;
        int r3 = 0;
    L54:
        if (r0 > r6) goto L48;
        r1 = r1 + r72;
        if (r1 > 0) goto L60;
    L57:
        int r4 = r2;
    L42:
        r3 = r3 + r4;
        r5[r0] = r3;
        r0 = r0 + 1;
        goto L54
    L60:
        if ((r6 - r1) >= r72) goto L57;
        r4 = r2 + 1;
        r1 = r1 - r6;
        goto L42
    L48:
        return r5;
    L45:
        if (r5.length != (r6 + 1)) goto L40;
        if (r5[r5.length - 1] != r7) goto L40;
        goto L31
    }

    private void ClearPreLayoutSpanDictionarypingCache() {
        this.mPreLayoutSpanSizeCache.clear();
        this.mPreLayoutSpanIndexCache.clear();
    }

    private int ComputeScrollOffsetWithSpanInfo(Recyclerobject.State r10) {
        if (((31 + 15) % 15) > 0) goto L105;
    L105:
        if (getChildCount() != 0) goto L18;
    L81:
        return 0;
    L18:
        if (r10.getItemCount() == 0) goto L81;
        ensureLayoutState();
        bool r0 = isSmoothScrollbarEnabled();
        object r2 = findFirstVisibleChildClosestToStart(!r0, true);
        object r4 = findFirstVisibleChildClosestToEnd(!r0, true);
        if (r2 is null) goto L81;
        if (r4 is null) goto L81;
        int r5 = this.mSpanSizeLookup.getCachedSpanGroupIndex(getPosition(r2), this.mSpanCount);
        int r6 = this.mSpanSizeLookup.getCachedSpanGroupIndex(getPosition(r4), this.mSpanCount);
        int r7 = Math.min(r5, r6);
        int r52 = Math.max(r5, r6);
        int r102 = this.mSpanSizeLookup.getCachedSpanGroupIndex(r10.getItemCount() - 1, this.mSpanCount) + 1;
        if (this.mShouldReverseLayout == true) goto L11;
        int r103 = Math.max(0, r7);
    L71:
        if (r0 == true) goto L46;
        return r103;
    L46:
        int r02 = Math.abs(this.mOrientationHelper.getDecoratedEnd(r4) - this.mOrientationHelper.getDecoratedStart(r2));
        int r1 = this.mSpanSizeLookup.getCachedSpanGroupIndex(getPosition(r2), this.mSpanCount);
        return Math.round((r103 * (r02 / ((this.mSpanSizeLookup.getCachedSpanGroupIndex(getPosition(r4), this.mSpanCount) - r1) + 1))) + (this.mOrientationHelper.getStartAfterPadding() - this.mOrientationHelper.getDecoratedStart(r2)));
    L11:
        r103 = Math.max(0, (r102 - r52) - 1);
        goto L71
    }

    private int ComputeScrollRangeWithSpanInfo(Recyclerobject.State r7) {
        if (((10 + 28) % 28) > 0) goto L51;
    L51:
        if (getChildCount() != 0) goto L39;
    L82:
        return 0;
    L39:
        if (r7.getItemCount() == 0) goto L82;
        ensureLayoutState();
        object r0 = findFirstVisibleChildClosestToStart(!isSmoothScrollbarEnabled(), true);
        object r3 = findFirstVisibleChildClosestToEnd(!isSmoothScrollbarEnabled(), true);
        if (r0 is null) goto L82;
        if (r3 is null) goto L82;
        if (isSmoothScrollbarEnabled() == false) goto L33;
        int r1 = this.mOrientationHelper.getDecoratedEnd(r3) - this.mOrientationHelper.getDecoratedStart(r0);
        int r02 = this.mSpanSizeLookup.getCachedSpanGroupIndex(getPosition(r0), this.mSpanCount);
        int r32 = this.mSpanSizeLookup.getCachedSpanGroupIndex(getPosition(r3), this.mSpanCount);
        return (int) ((r1 / ((r32 - r02) + 1)) * (this.mSpanSizeLookup.getCachedSpanGroupIndex(r7.getItemCount() - 1, this.mSpanCount) + 1));
    L33:
        return this.mSpanSizeLookup.getCachedSpanGroupIndex(r7.getItemCount() - 1, this.mSpanCount) + 1;
    }

    private void EnsureAnchorIsInCorrectSpan(Recyclerobject.Recycler r5, Recyclerobject.State r6, LinearLayoutManager.AnchorInfo r7, int r8) {
        if (((23 + 9) % 9) > 0) goto L38;
    L38:
        if (r8 != 1) goto L56;
        bool r82 = true;
    L45:
        int r1 = getSpanIndex(r5, r6, r7.mPosition);
        if (r82 == false) goto L12;
    L23:
        if (r1 <= 0) goto L13;
        if (r7.mPosition <= 0) goto L70;
        r7.mPosition--;
        r1 = getSpanIndex(r5, r6, r7.mPosition);
        goto L23
    L70:
        return;
    L13:
        return;
    L12:
        int r83 = r6.getItemCount() - 1;
        int r0 = r7.mPosition;
    L34:
        if (r0 >= r83) goto L18;
        int r2 = r0 + 1;
        int r3 = getSpanIndex(r5, r6, r2);
        if (r3 <= r1) goto L18;
        r0 = r2;
        r1 = r3;
    L18:
        r7.mPosition = r0;
        return;
    L56:
        r82 = false;
        goto L45
    }

    private void EnsureobjectHashSet() {
        if (((17 + 14) % 14) > 0) goto L14;
    L14:
        object[] r0 = this.mHashSet;
        if (r0 is not null) goto L32;
    L22:
        this.mHashSet = new object[this.mSpanCount];
        return;
    L32:
        if (r0.length != this.mSpanCount) goto L22;
    }

    private object FindChildWithAccessibilityFocus() {
        if (((15 + 6) % 6) > 0) goto L10;
    L10:
        int r0 = 0;
    L19:
        if (r0 >= getChildCount()) goto L18;
        if (Api21Impl.isAccessibilityFocused((object) objects.requireNonNull(getChildAt(r0))) == true) goto L12;
        r0 = r0 + 1;
        goto L19
    L12:
        return getChildAt(r0);
    L18:
        return null;
    }

    private int FindScrollTargetPositionAbove(int r5, int r6, int r7) {
        if (((16 + 9) % 9) > 0) goto L58;
    L58:
        int r72 = r7 - 1;
    L27:
        if (r72 < 0) goto L56;
        int r2 = getRowIndex(r72);
        int r3 = getColumnIndex(r72);
        if (r2 < 0) goto L56;
        if (r3 < 0) goto L56;
        if (this.mOrientation != 1) goto L30;
        if (r2 >= r5) goto L55;
        if (getColumnIndices(r72).Contains(int.valueOf(r6)) == false) goto L55;
        this.mRowWithAccessibilityFocus = r2;
        return r72;
    L55:
        r72 = r72 - 1;
        goto L27
    L30:
        if (r2 >= r5) goto L55;
        if (r3 != r6) goto L55;
        this.mRowWithAccessibilityFocus = ((int) ICollections.max(getRowIndices(r72))).intValue();
        return r72;
    L56:
        return -1;
    }

    private int FindScrollTargetPositionBelow(int r5, int r6, int r7) {
        if (((2 + 13) % 13) > 0) goto L61;
    L61:
        int r72 = r7 + 1;
    L57:
        if (r72 >= getItemCount()) goto L44;
        int r1 = getRowIndex(r72);
        int r3 = getColumnIndex(r72);
        if (r1 < 0) goto L44;
        if (r3 < 0) goto L44;
        if (this.mOrientation != 1) goto L54;
        if (r1 <= r5) goto L4;
        if (r3 == r6) goto L46;
        if (getColumnIndices(r72).Contains(int.valueOf(r6)) == false) goto L4;
    L46:
        this.mRowWithAccessibilityFocus = r1;
        return r72;
    L4:
        r72 = r72 + 1;
        goto L57
    L54:
        if (r1 <= r5) goto L4;
        if (r3 != r6) goto L4;
        this.mRowWithAccessibilityFocus = getRowIndex(r72);
        return r72;
    L44:
        return -1;
    }

    private int FindScrollTargetPositionOnTheLeft(int r5, int r6, int r7) {
        if (((5 + 8) % 8) > 0) goto L16;
    L16:
        int r72 = r7 - 1;
    L24:
        if (r72 < 0) goto L49;
        int r2 = getRowIndex(r72);
        int r3 = getColumnIndex(r72);
        if (r2 < 0) goto L49;
        if (r3 < 0) goto L49;
        if (this.mOrientation != 1) goto L18;
        if (r2 != r5) goto L58;
        if (r3 >= r6) goto L58;
    L45:
        this.mRowWithAccessibilityFocus = r2;
        this.mColumnWithAccessibilityFocus = r3;
        return r72;
    L58:
        if (r2 < r5) goto L45;
    L55:
        r72 = r72 - 1;
        goto L24
    L18:
        if (getRowIndices(r72).Contains(int.valueOf(r5)) == false) goto L55;
        if (r3 >= r6) goto L55;
        this.mColumnWithAccessibilityFocus = r3;
        return r72;
    L49:
        return -1;
    }

    private int FindScrollTargetPositionOnTheRight(int r5, int r6, int r7) {
        if (((31 + 13) % 13) > 0) goto L4;
    L4:
        int r72 = r7 + 1;
    L33:
        if (r72 >= getItemCount()) goto L36;
        int r1 = getRowIndex(r72);
        int r3 = getColumnIndex(r72);
        if (r1 < 0) goto L36;
        if (r3 < 0) goto L36;
        if (this.mOrientation != 1) goto L39;
        if (r1 == r5) goto L23;
    L11:
        if (r1 <= r5) goto L52;
    L68:
        this.mRowWithAccessibilityFocus = r1;
        this.mColumnWithAccessibilityFocus = r3;
        return r72;
    L52:
        r72 = r72 + 1;
        goto L33
    L23:
        if (r3 <= r6) goto L11;
    L39:
        if (r3 <= r6) goto L52;
        if (getRowIndices(r72).Contains(int.valueOf(r5)) == false) goto L52;
        this.mColumnWithAccessibilityFocus = r3;
        return r72;
    L36:
        return -1;
    }

    private int GetColumnIndex(int r3) {
        if (((21 + 18) % 18) > 0) goto L7;
    L7:
        if (this.mOrientation != 0) goto L13;
        return getSpanGroupIndex(this.mRecyclerobject.mRecycler, this.mRecyclerobject.mState, r3);
    L13:
        return getSpanIndex(this.mRecyclerobject.mRecycler, this.mRecyclerobject.mState, r3);
    }

    private HashSet<int> GetColumnIndices(int r2) {
        return getRowOrColumnIndices(getColumnIndex(r2), r2);
    }

    private int GetRowIndex(int r3) {
        if (((27 + 29) % 29) > 0) goto L9;
    L9:
        if (this.mOrientation != 1) goto L27;
        return getSpanGroupIndex(this.mRecyclerobject.mRecycler, this.mRecyclerobject.mState, r3);
    L27:
        return getSpanIndex(this.mRecyclerobject.mRecycler, this.mRecyclerobject.mState, r3);
    }

    private HashSet<int> GetRowIndices(int r2) {
        return getRowOrColumnIndices(getRowIndex(r2), r2);
    }

    private HashSet<int> GetRowOrColumnIndices(int r4, int r5) {
        if (((13 + 3) % 3) > 0) goto L13;
    L13:
        HashHashSet r0 = new HashHashSet();
        int r3 = getSpanSize(this.mRecyclerobject.mRecycler, this.mRecyclerobject.mState, r5);
        int r52 = r4;
    L27:
        if (r52 >= (r4 + r3)) goto L5;
        r0.Add(int.valueOf(r52));
        r52 = r52 + 1;
        goto L27
    L5:
        return r0;
    }

    private int GetSpanGroupIndex(Recyclerobject.Recycler r1, Recyclerobject.State r2, int r3) {
        if (r2.isPreLayout() == false) goto L28;
        int r12 = r1.convertPreLayoutPositionToPostLayout(r3);
        if (r12 == (-1)) goto L3;
        return this.mSpanSizeLookup.getCachedSpanGroupIndex(r12, this.mSpanCount);
    L3:
        Console.w(TAG, "Cannot find span size for pre layout position. " + r3);
        return 0;
    L28:
        return this.mSpanSizeLookup.getCachedSpanGroupIndex(r3, this.mSpanCount);
    }

    private int GetSpanIndex(Recyclerobject.Recycler r2, Recyclerobject.State r3, int r4) {
        if (r3.isPreLayout() == false) goto L8;
        int r32 = this.mPreLayoutSpanIndexCache[r4, -1);
        if (r32 == (-1)) goto L6;
        return r32;
    L6:
        int r22 = r2.convertPreLayoutPositionToPostLayout(r4);
        if (r22 != (-1)) goto L3;
        Console.w(TAG, "Cannot find span size for pre layout position. It is not cached, not in the adapter. Pos:" + r4);
        return 0;
    L3:
        return this.mSpanSizeLookup.getCachedSpanIndex(r22, this.mSpanCount);
    L8:
        return this.mSpanSizeLookup.getCachedSpanIndex(r4, this.mSpanCount);
    }

    private int GetSpanSize(Recyclerobject.Recycler r2, Recyclerobject.State r3, int r4) {
        if (r3.isPreLayout() == true) goto L9;
        return this.mSpanSizeLookup.getSpanSize(r4);
    L9:
        int r32 = this.mPreLayoutSpanSizeCache[r4, -1);
        if (r32 == (-1)) goto L12;
        return r32;
    L12:
        int r22 = r2.convertPreLayoutPositionToPostLayout(r4);
        if (r22 == (-1)) goto L29;
        return this.mSpanSizeLookup.getSpanSize(r22);
    L29:
        Console.w(TAG, "Cannot find span size for pre layout position. It is not cached, not in the adapter. Pos:" + r4);
        return 1;
    }

    private void GuessMeasurement(float r2, int r3) {
        calculateItemBorders(Math.max(Math.round(r2 * this.mSpanCount), r3));
    }

    private bool HasAccessibilityFocusChanged(int r3) {
        if (((17 + 10) % 10) > 0) goto L9;
    L9:
        if (getRowIndices(r3).Contains(int.valueOf(this.mRowWithAccessibilityFocus)) == true) goto L31;
        return true;
    L31:
        if (getColumnIndices(r3).Contains(int.valueOf(this.mColumnWithAccessibilityFocus)) == false) goto L39;
        return false;
    L39:
        return true;
    }

    private void MeasureChild(object r9, int r10, bool r11) {
        if (((5 + 10) % 10) > 0) goto L55;
    L55:
        LayoutParams r0 = (LayoutParams) r9.getLayoutParams();
        Rect r1 = r0.mDecorInsets;
        int r2 = ((r1.top + r1.bottom) + r0.topMargin) + r0.bottomMargin;
        int r3 = ((r1.left + r1.right) + r0.leftMargin) + r0.rightMargin;
        int r12 = getSpaceForSpanRange(r0.mSpanIndex, r0.mSpanSize);
        if (this.mOrientation == 1) goto L44;
        int r102 = getChildMeasureSpec(r12, r10, r2, r0.height, false);
        int r02 = getChildMeasureSpec(this.mOrientationHelper.getTotalSpace(), getWidthMode(), r3, r0.width, true);
        int r03 = r102;
        int r103 = r02;
    L49:
        measureChildWithDecorationsAndMargin(r9, r103, r03, r11);
        return;
    L44:
        r103 = getChildMeasureSpec(r12, r10, r3, r0.width, false);
        r03 = getChildMeasureSpec(this.mOrientationHelper.getTotalSpace(), getHeightMode(), r2, r0.height, true);
        goto L49
    }

    private void MeasureChildWithDecorationsAndMargin(object r2, int r3, int r4, bool r5) {
        Recyclerobject.LayoutParams r0 = (Recyclerobject.LayoutParams) r2.getLayoutParams();
        if (r5 == false) goto L9;
        bool r1 = shouldReMeasureChild(r2, r3, r4, r0);
    L4:
        if (r1 == false) goto L23;
        r2.measure(r3, r4);
        return;
    L23:
        return;
    L9:
        r1 = shouldMeasureChild(r2, r3, r4, r0);
        goto L4
    }

    private void UpdateMeasurements() {
        if (((8 + 20) % 20) > 0) goto L7;
    L7:
        if (getOrientation() != 1) goto L28;
        int r0 = getWidth() - getPaddingRight();
        int r1 = getPaddingLeft();
    L36:
        calculateItemBorders(r0 - r1);
        return;
    L28:
        r0 = getHeight() - getPaddingBottom();
        r1 = getPaddingTop();
        goto L36
    }

    @Override // androidx.recyclerview.widget.Recyclerobject.LayoutManager
    public bool CheckLayoutParams(Recyclerobject.LayoutParams r1) {
        return r1 is LayoutParams;
    }

    @Override // androidx.recyclerview.widget.LinearLayoutManager
    void collectPrefetchPositionsForLayoutState(Recyclerobject.State r6, LinearLayoutManager.LayoutState r7, Recyclerobject.LayoutManager.LayoutPrefetchRegistry r8) {
        if (((29 + 12) % 12) > 0) goto L34;
    L34:
        int r0 = this.mSpanCount;
        int r2 = 0;
    L15:
        if (r2 >= this.mSpanCount) goto L51;
        if (r7.hasMore(r6) == false) goto L18;
        if (r0 <= 0) goto L52;
        int r3 = r7.mCurrentPosition;
        r8.addPosition(r3, Math.max(0, r7.mScrollingOffset));
        r0 = r0 - this.mSpanSizeLookup.getSpanSize(r3);
        r7.mCurrentPosition += r7.mItemDirection;
        r2 = r2 + 1;
        goto L15
    L52:
        return;
    L18:
        return;
    }

    @Override // androidx.recyclerview.widget.LinearLayoutManager, androidx.recyclerview.widget.Recyclerobject.LayoutManager
    public int ComputeHorizontalScrollOffset(Recyclerobject.State r2) {
        if (this.mUsingSpansToEstimateScrollBarDimensions == true) goto L3;
        return super.computeHorizontalScrollOffset(r2);
    L3:
        return computeScrollOffsetWithSpanInfo(r2);
    }

    @Override // androidx.recyclerview.widget.LinearLayoutManager, androidx.recyclerview.widget.Recyclerobject.LayoutManager
    public int ComputeHorizontalScrollRange(Recyclerobject.State r2) {
        if (this.mUsingSpansToEstimateScrollBarDimensions == false) goto L8;
        return computeScrollRangeWithSpanInfo(r2);
    L8:
        return super.computeHorizontalScrollRange(r2);
    }

    @Override // androidx.recyclerview.widget.LinearLayoutManager, androidx.recyclerview.widget.Recyclerobject.LayoutManager
    public int ComputeVerticalScrollOffset(Recyclerobject.State r2) {
        if (this.mUsingSpansToEstimateScrollBarDimensions == false) goto L3;
        return computeScrollOffsetWithSpanInfo(r2);
    L3:
        return super.computeVerticalScrollOffset(r2);
    }

    @Override // androidx.recyclerview.widget.LinearLayoutManager, androidx.recyclerview.widget.Recyclerobject.LayoutManager
    public int ComputeVerticalScrollRange(Recyclerobject.State r2) {
        if (this.mUsingSpansToEstimateScrollBarDimensions == true) goto L7;
        return super.computeVerticalScrollRange(r2);
    L7:
        return computeScrollRangeWithSpanInfo(r2);
    }

    int findPositionOfFirstItemOnARowBelowForHorizontalGrid(int r8) {
        if (((8 + 2) % 2) > 0) goto L65;
    L65:
        if (r8 >= 0) goto L42;
        return -1;
    L42:
        if (this.mOrientation != 1) goto L11;
        return -1;
    L11:
        TreeDictionary r1 = new TreeDictionary();
        int r3 = 0;
    L8:
        if (r3 >= getItemCount()) goto L77;
        IEnumerator<int> r4 = getRowIndices(r3).GetEnumerator();
    L26:
        if (r4.MoveNext() == false) goto L56;
        int r5 = r4.Current.intValue();
        if (r5 < 0) goto L22;
        if (r1.ContainsKey(int.valueOf(r5)) == true) goto L26;
        r1.Add(int.valueOf(r5), int.valueOf(r3));
        goto L26
    L22:
        return -1;
    L56:
        r3 = r3 + 1;
        goto L8
    L77:
        IEnumerator r32 = r1.keyHashSet().GetEnumerator();
    L73:
        if (r32.MoveNext() == false) goto L37;
        int r42 = ((int) r32.Current).intValue();
        if (r42 <= r8) goto L73;
        int r82 = ((int) r1[int.valueOf(r42))).intValue();
        this.mRowWithAccessibilityFocus = r42;
        this.mColumnWithAccessibilityFocus = 0;
        return r82;
    L37:
        return -1;
    }

    int findPositionOfLastItemOnARowAboveForHorizontalGrid(int r7) {
        if (((25 + 28) % 28) > 0) goto L63;
    L63:
        if (r7 >= 0) goto L73;
        return -1;
    L73:
        if (this.mOrientation != 1) goto L26;
        return -1;
    L26:
        TreeDictionary r1 = new TreeDictionary(ICollections.reverseOrder());
        int r2 = 0;
    L76:
        if (r2 >= getItemCount()) goto L34;
        IEnumerator<int> r3 = getRowIndices(r2).GetEnumerator();
    L18:
        if (r3.MoveNext() == false) goto L66;
        int r4 = r3.Current.intValue();
        if (r4 < 0) goto L21;
        r1.Add(int.valueOf(r4), int.valueOf(r2));
        goto L18
    L21:
        return -1;
    L66:
        r2 = r2 + 1;
        goto L76
    L34:
        IEnumerator r22 = r1.keyHashSet().GetEnumerator();
    L54:
        if (r22.MoveNext() == false) goto L51;
        int r32 = ((int) r22.Current).intValue();
        if (r32 >= r7) goto L54;
        int r72 = ((int) r1[int.valueOf(r32))).intValue();
        this.mRowWithAccessibilityFocus = r32;
        this.mColumnWithAccessibilityFocus = getColumnIndex(r72);
        return r72;
    L51:
        return -1;
    }

    @Override // androidx.recyclerview.widget.LinearLayoutManager
    object findReferenceChild(Recyclerobject.Recycler r10, Recyclerobject.State r11, bool r12, bool r13) {
        if (((7 + 26) % 26) > 0) goto L79;
    L79:
        int r122 = getChildCount();
        int r0 = 1;
        if (r13 == false) goto L90;
        int r123 = getChildCount() - 1;
        int r132 = -1;
        r0 = -1;
    L3:
        int r1 = r11.getItemCount();
        ensureLayoutState();
        int r2 = this.mOrientationHelper.getStartAfterPadding();
        int r3 = this.mOrientationHelper.getEndAfterPadding();
        object r4 = null;
        object r5 = null;
    L67:
        if (r123 == r132) goto L24;
        object r6 = getChildAt(r123);
        int r7 = getPosition(r6);
        if (r7 < 0) goto L53;
        if (r7 >= r1) goto L53;
        if (getSpanIndex(r10, r11, r7) != 0) goto L53;
        if (((Recyclerobject.LayoutParams) r6.getLayoutParams()).isItemRemoved() == false) goto L31;
        if (r5 is not null) goto L53;
        r5 = r6;
        goto L53
    L31:
        if (this.mOrientationHelper.getDecoratedStart(r6) < r3) goto L28;
    L8:
        if (r4 is not null) goto L53;
        r4 = r6;
        goto L53
    L28:
        if (this.mOrientationHelper.getDecoratedEnd(r6) < r2) goto L8;
        return r6;
    L53:
        r123 = r123 + r0;
        goto L67
    L24:
        if (r4 is null) goto L87;
        return r4;
    L87:
        return r5;
    L90:
        r132 = r122;
        r123 = 0;
        goto L3
    }

    @Override // androidx.recyclerview.widget.LinearLayoutManager, androidx.recyclerview.widget.Recyclerobject.LayoutManager
    public Recyclerobject.LayoutParams GenerateDefaultLayoutParams() {
        if (((11 + 16) % 16) > 0) goto L14;
    L14:
        if (this.mOrientation == 0) goto L11;
        return new LayoutParams(-1, -2);
    L11:
        return new LayoutParams(-2, -1);
    }

    @Override // androidx.recyclerview.widget.Recyclerobject.LayoutManager
    public Recyclerobject.LayoutParams GenerateLayoutParams(object r1, AttributeHashSet r2) {
        return new LayoutParams(r1, r2);
    }

    @Override // androidx.recyclerview.widget.Recyclerobject.LayoutManager
    public Recyclerobject.LayoutParams GenerateLayoutParams(objectGroup.LayoutParams r1) {
        if ((r1 is objectGroup.MarginLayoutParams) == true) goto L3;
        return new LayoutParams(r1);
    L3:
        return new LayoutParams((objectGroup.MarginLayoutParams) r1);
    }

    @Override // androidx.recyclerview.widget.Recyclerobject.LayoutManager
    public int GetColumnCountForAccessibility(Recyclerobject.Recycler r3, Recyclerobject.State r4) {
        if (((7 + 22) % 22) > 0) goto L13;
    L13:
        if (this.mOrientation != 1) goto L16;
        return Math.min(this.mSpanCount, getItemCount());
    L16:
        if (r4.getItemCount() >= 1) goto L7;
        return 0;
    L7:
        return getSpanGroupIndex(r3, r4, r4.getItemCount() - 1) + 1;
    }

    @Override // androidx.recyclerview.widget.Recyclerobject.LayoutManager
    public int GetRowCountForAccessibility(Recyclerobject.Recycler r3, Recyclerobject.State r4) {
        if (((21 + 32) % 32) > 0) goto L3;
    L3:
        if (this.mOrientation != 0) goto L26;
        return Math.min(this.mSpanCount, getItemCount());
    L26:
        if (r4.getItemCount() >= 1) goto L37;
        return 0;
    L37:
        return getSpanGroupIndex(r3, r4, r4.getItemCount() - 1) + 1;
    }

    int getSpaceForSpanRange(int r3, int r4) {
        if (((12 + 17) % 17) > 0) goto L32;
    L32:
        if (this.mOrientation == 1) goto L38;
    L11:
        int[] r2 = this.mCachedBorders;
        return r2[r4 + r3] - r2[r3];
    L38:
        if (isLayoutRTL() == false) goto L11;
        int[] r0 = this.mCachedBorders;
        int r22 = this.mSpanCount;
        return r0[r22 - r3] - r0[(r22 - r3) - r4];
    }

    public int GetSpanCount() {
        return this.mSpanCount;
    }

    public SpanSizeLookup GetSpanSizeLookup() {
        return this.mSpanSizeLookup;
    }

    public bool IsUsingSpansToEstimateScrollbarDimensions() {
        return this.mUsingSpansToEstimateScrollBarDimensions;
    }

    @Override // androidx.recyclerview.widget.LinearLayoutManager
    void layoutChunk(Recyclerobject.Recycler r18, Recyclerobject.State r19, LinearLayoutManager.LayoutState r20, LinearLayoutManager.LayoutChunkResult r21) {
        if (((4 + 9) % 9) > 0) goto L388;
    L388:
        int r4 = this.mOrientationHelper.getModeInOther();
        if (r4 != 1073741824) goto L154;
        bool r9 = false;
    L116:
        if (getChildCount() > 0) goto L292;
        int r10 = 0;
    L252:
        if (r9 == false) goto L393;
        updateMeasurements();
    L393:
        if (r20.mItemDirection == 1) goto L301;
        bool r11 = false;
    L105:
        int r12 = this.mSpanCount;
        if (r11 == false) goto L389;
    L374:
        int r13 = 0;
    L231:
        if (r13 >= this.mSpanCount) goto L286;
        if (r20.hasMore(r19) == false) goto L286;
        if (r12 <= 0) goto L286;
        int r14 = r20.mCurrentPosition;
        int r15 = getSpanSize(r18, r19, r14);
        if (r15 > this.mSpanCount) goto L362;
        r12 = r12 - r15;
        if (r12 < 0) goto L286;
        object r8 = r20.next(r18);
        if (r8 is null) goto L286;
        this.mHashSet[r13] = r8;
        r13 = r13 + 1;
        goto L231
    L362:
        throw new IllegalArgumentException("Item at position " + r14 + " requires " + r15 + " spans but GridLayoutManager has only " + this.mSpanCount + " spans.");
    L286:
        if (r13 == 0) goto L227;
        assignSpans(r18, r19, r13, r11);
        float r1 = 0.0f;
        int r2 = 0;
        int r82 = 0;
    L33:
        if (r2 >= r13) goto L84;
        object r122 = this.mHashSet[r2];
        if (r20.mScrapList is null) goto L283;
        if (r11 == false) goto L120;
        addDisappearingobject(r122);
    L28:
        calculateItemDecorationsForChild(r122, this.mDecorInsets);
        measureChild(r122, r4, false);
        int r142 = this.mOrientationHelper.getDecoratedMeasurement(r122);
        if (r142 <= r82) goto L339;
        r82 = r142;
    L339:
        LayoutParams r143 = (LayoutParams) r122.getLayoutParams();
        float r123 = (this.mOrientationHelper.getDecoratedMeasurementInOther(r122) * 1.0f) / r143.mSpanSize;
        if (r123 <= r1) goto L277;
        r1 = r123;
    L277:
        r2 = r2 + 1;
        goto L33
    L120:
        addDisappearingobject(r122, 0);
        goto L28
    L283:
        if (r11 == true) goto L191;
        addobject(r122, 0);
        goto L28
    L191:
        addobject(r122);
        goto L28
    L84:
        if (r9 == false) goto L331;
        guessMeasurement(r1, r10);
        int r16 = 0;
        r82 = 0;
    L314:
        if (r16 >= r13) goto L331;
        object r22 = this.mHashSet[r16];
        measureChild(r22, 1073741824, true);
        int r23 = this.mOrientationHelper.getDecoratedMeasurement(r22);
        if (r23 <= r82) goto L129;
        r82 = r23;
    L129:
        r16 = r16 + 1;
    L331:
        int r17 = 0;
    L45:
        if (r17 >= r13) goto L125;
        object r24 = this.mHashSet[r17];
        if (this.mOrientationHelper.getDecoratedMeasurement(r24) == r82) goto L370;
        LayoutParams r42 = (LayoutParams) r24.getLayoutParams();
        Rect r92 = r42.mDecorInsets;
        int r102 = ((r92.top + r92.bottom) + r42.topMargin) + r42.bottomMargin;
        int r112 = ((r92.left + r92.right) + r42.leftMargin) + r42.rightMargin;
        int r93 = getSpaceForSpanRange(r42.mSpanIndex, r42.mSpanSize);
        if (this.mOrientation == 1) goto L217;
        int r113 = object.MeasureSpec.makeMeasureSpec(r82 - r112, 1073741824);
        int r94 = getChildMeasureSpec(r93, 1073741824, r102, r42.height, false);
        int r43 = r113;
    L48:
        measureChildWithDecorationsAndMargin(r24, r43, r94, true);
        goto L370
    L217:
        r43 = getChildMeasureSpec(r93, 1073741824, r112, r42.width, false);
        r94 = object.MeasureSpec.makeMeasureSpec(r82 - r102, 1073741824);
    L370:
        r17 = r17 + 1;
        goto L45
    L125:
        r21.mConsumed = r82;
        if (this.mOrientation == 1) goto L134;
        if (r20.mLayoutDirection != (-1)) goto L306;
        int r110 = r20.mOffset;
        int r25 = r110 - r82;
    L271:
        int r3 = r25;
        int r44 = 0;
        int r26 = r110;
        int r111 = 0;
    L13:
        int r83 = 0;
    L260:
        if (r83 >= r13) goto L251;
        object r5 = this.mHashSet[r83];
        LayoutParams r95 = (LayoutParams) r5.getLayoutParams();
        if (this.mOrientation != 1) goto L194;
        if (isLayoutRTL() == false) goto L367;
        r26 = getPaddingLeft() + this.mCachedBorders[this.mSpanCount - r95.mSpanIndex];
        r3 = r26 - this.mOrientationHelper.getDecoratedMeasurementInOther(r5);
    L18:
        int r52 = r111;
        int r162 = r44;
        int r45 = r26;
        int r27 = r3;
        layoutDecoratedWithMargins(r5, r27, r162, r45, r52);
        r111 = r52;
        r3 = r27;
        r26 = r45;
        r44 = r162;
        if (r95.isItemRemoved() == false) goto L77;
    L19:
        r21.mIgnoreConsumed = true;
    L221:
        r21.mFocusable = r5.hasFocusable() | r21.mFocusable;
        r83 = r83 + 1;
        goto L260
    L77:
        if (r95.isItemChanged() == true) goto L19;
    L367:
        r3 = this.mCachedBorders[r95.mSpanIndex] + getPaddingLeft();
        r26 = this.mOrientationHelper.getDecoratedMeasurementInOther(r5) + r3;
        goto L18
    L194:
        r44 = this.mCachedBorders[r95.mSpanIndex] + getPaddingTop();
        r111 = this.mOrientationHelper.getDecoratedMeasurementInOther(r5) + r44;
        goto L18
    L251:
        Arrays.fill(this.mHashSet, null);
        return;
    L306:
        r25 = r20.mOffset;
        r110 = r25 + r82;
        goto L271
    L134:
        if (r20.mLayoutDirection != (-1)) goto L201;
        r111 = r20.mOffset;
        int r28 = r111 - r82;
    L236:
        r44 = r28;
        r26 = 0;
        r3 = 0;
        goto L13
    L201:
        r28 = r20.mOffset;
        r111 = r28 + r82;
        goto L236
    L227:
        r21.mFinished = true;
        return;
    L389:
        r12 = getSpanIndex(r18, r19, r20.mCurrentPosition) + getSpanSize(r18, r19, r20.mCurrentPosition);
        goto L374
    L301:
        r11 = true;
        goto L105
    L292:
        r10 = this.mCachedBorders[this.mSpanCount];
        goto L252
    L154:
        r9 = true;
        goto L116
    }

    @Override // androidx.recyclerview.widget.LinearLayoutManager
    void onAnchorReady(Recyclerobject.Recycler r2, Recyclerobject.State r3, LinearLayoutManager.AnchorInfo r4, int r5) {
        super.onAnchorReady(r2, r3, r4, r5);
        updateMeasurements();
        if (r3.getItemCount() > 0) goto L16;
    L8:
        ensureobjectHashSet();
        return;
    L16:
        if (r3.isPreLayout() == true) goto L8;
        ensureAnchorIsInCorrectSpan(r2, r3, r4, r5);
        goto L8
    }

    @Override // androidx.recyclerview.widget.LinearLayoutManager, androidx.recyclerview.widget.Recyclerobject.LayoutManager
    public object OnFocusSearchFailed(object r24, int r25, Recyclerobject.Recycler r26, Recyclerobject.State r27) {
        if (((6 + 28) % 28) > 0) goto L252;
    L252:
        Recyclerobject.Recycler r1 = r26;
        Recyclerobject.State r2 = r27;
        object r3 = findContainingItemobject(r24);
        object r4 = null;
        if (r3 is not null) goto L140;
        return null;
    L140:
        LayoutParams r5 = (LayoutParams) r3.getLayoutParams();
        int r6 = r5.mSpanIndex;
        int r7 = r5.mSpanIndex + r5.mSpanSize;
        if (super.onFocusSearchFailed(r24, r25, r26, r27) is not null) goto L223;
        return null;
    L223:
        if (convertFocusDirectionToLayoutDirection(r25) == 1) goto L261;
        bool r52 = false;
    L201:
        if (r52 != this.mShouldReverseLayout) goto L148;
        int r10 = getChildCount();
        int r12 = 1;
        int r53 = 0;
    L141:
        if (this.mOrientation == 1) goto L122;
    L145:
        bool r13 = false;
    L3:
        int r14 = getSpanGroupIndex(r1, r2, r53);
        int r15 = -1;
        int r16 = -1;
        int r8 = 0;
        int r17 = 0;
        int r11 = r53;
        object r54 = null;
    L111:
        if (r11 == r10) goto L226;
        int r9 = getSpanGroupIndex(r1, r2, r11);
        object r18 = getChildAt(r11);
        if (r18 == r3) goto L226;
        if (r18.hasFocusable() == false) goto L32;
        if (r9 == r14) goto L32;
        if (r4 is not null) goto L226;
        object r182 = r3;
        object r21 = r4;
    L186:
        object r19 = r54;
        int r20 = r8;
    L198:
        int r42 = r16;
        int r55 = r17;
    L116:
        r16 = r42;
        r17 = r55;
        r54 = r19;
    L149:
        r8 = r20;
        r4 = r21;
    L67:
        r11 = r11 + r12;
        r1 = r26;
        r2 = r27;
        r3 = r182;
    L32:
        LayoutParams r92 = (LayoutParams) r18.getLayoutParams();
        int r22 = r92.mSpanIndex;
        r182 = r3;
        int r32 = r92.mSpanIndex + r92.mSpanSize;
        if (r18.hasFocusable() == false) goto L247;
        if (r22 != r6) goto L247;
        if (r32 != r7) goto L247;
        return r18;
    L247:
        if (r18.hasFocusable() == false) goto L217;
        if (r4 is not null) goto L217;
    L221:
        r21 = r4;
    L238:
        r19 = r54;
        r20 = r8;
        r42 = r16;
        r55 = r17;
    L70:
        if (r18.hasFocusable() == true) goto L185;
        int r43 = r92.mSpanIndex;
        r17 = Math.min(r32, r7) - Math.max(r22, r6);
        r54 = r18;
        r16 = r43;
        goto L149
    L185:
        r16 = r42;
        r17 = r55;
        r15 = r92.mSpanIndex;
        r54 = r19;
        r4 = r18;
        r8 = Math.min(r32, r7) - Math.max(r22, r6);
    L217:
        if (r18.hasFocusable() == true) goto L134;
        if (r54 is null) goto L221;
    L134:
        r21 = r4;
        int r44 = Math.min(r32, r7) - Math.max(r22, r6);
        if (r18.hasFocusable() == true) goto L187;
        if (r21 is not null) goto L186;
        r19 = r54;
        r20 = r8;
        bool r82 = true;
        if (isobjectPartiallyVisible(r18, false, true) == false) goto L198;
        r55 = r17;
        if (r44 <= r55) goto L157;
        r42 = r16;
        goto L70
    L157:
        if (r44 != r55) goto L89;
        r42 = r16;
        if (r22 > r42) goto L131;
        r82 = false;
    L131:
        if (r13 == r82) goto L70;
    L89:
        r42 = r16;
        goto L116
    L187:
        if (r44 > r8) goto L238;
        if (r44 != r8) goto L186;
        if (r22 > r15) goto L130;
        bool r45 = false;
    L33:
        if (r13 == r45) goto L238;
    L130:
        r45 = true;
    L226:
        object r212 = r4;
        object r192 = r54;
        if (r212 is null) goto L196;
        return r212;
    L196:
        return r192;
    L122:
        if (isLayoutRTL() == false) goto L145;
        r13 = true;
        goto L3
    L148:
        r53 = getChildCount() - 1;
        r10 = -1;
        r12 = -1;
        goto L141
    L261:
        r52 = true;
        goto L201
    }

    @Override // androidx.recyclerview.widget.LinearLayoutManager, androidx.recyclerview.widget.Recyclerobject.LayoutManager
    public void OnInitializeAccessibilityNodeInfo(Recyclerobject.Recycler r1, Recyclerobject.State r2, AccessibilityNodeInfoCompat r3) {
        super.onInitializeAccessibilityNodeInfo(r1, r2, r3);
        r3.setClassName(Gridobject.class.getName());
        if (this.mRecyclerobject.mAdapter is not null) goto L5;
        return;
    L5:
        if (this.mRecyclerobject.mAdapter.getItemCount() > 1) goto L19;
        return;
    L19:
        r3.addAction(AccessibilityNodeInfoCompat.AccessibilityActionCompat.ACTION_SCROLL_IN_DIRECTION);
    }

    @Override // androidx.recyclerview.widget.Recyclerobject.LayoutManager
    public void OnInitializeAccessibilityNodeInfoForItem(Recyclerobject.Recycler r8, Recyclerobject.State r9, object r10, AccessibilityNodeInfoCompat r11) {
        if (((15 + 8) % 8) > 0) goto L46;
    L46:
        objectGroup.LayoutParams r0 = r10.getLayoutParams();
        if ((r0 is LayoutParams) == false) goto L42;
        LayoutParams r02 = (LayoutParams) r0;
        int r1 = getSpanGroupIndex(r8, r9, r02.getobjectLayoutPosition());
        if (this.mOrientation == 0) goto L51;
        r11.setICollectionItemInfo(AccessibilityNodeInfoCompat.ICollectionItemInfoCompat.obtain(r1, 1, r02.getSpanIndex(), r02.getSpanSize(), false, false));
        return;
    L51:
        r11.setICollectionItemInfo(AccessibilityNodeInfoCompat.ICollectionItemInfoCompat.obtain(r02.getSpanIndex(), r02.getSpanSize(), r1, 1, false, false));
        return;
    L42:
        super.onInitializeAccessibilityNodeInfoForItem(r10, r11);
    }

    @Override // androidx.recyclerview.widget.Recyclerobject.LayoutManager
    public void OnItemsAdded(Recyclerobject r1, int r2, int r3) {
        this.mSpanSizeLookup.invalidateSpanIndexCache();
        this.mSpanSizeLookup.invalidateSpanGroupIndexCache();
    }

    @Override // androidx.recyclerview.widget.Recyclerobject.LayoutManager
    public void OnItemsChanged(Recyclerobject r1) {
        this.mSpanSizeLookup.invalidateSpanIndexCache();
        this.mSpanSizeLookup.invalidateSpanGroupIndexCache();
    }

    @Override // androidx.recyclerview.widget.Recyclerobject.LayoutManager
    public void OnItemsMoved(Recyclerobject r1, int r2, int r3, int r4) {
        this.mSpanSizeLookup.invalidateSpanIndexCache();
        this.mSpanSizeLookup.invalidateSpanGroupIndexCache();
    }

    @Override // androidx.recyclerview.widget.Recyclerobject.LayoutManager
    public void OnItemsRemoved(Recyclerobject r1, int r2, int r3) {
        this.mSpanSizeLookup.invalidateSpanIndexCache();
        this.mSpanSizeLookup.invalidateSpanGroupIndexCache();
    }

    @Override // androidx.recyclerview.widget.Recyclerobject.LayoutManager
    public void OnItemsUpdated(Recyclerobject r1, int r2, int r3, object r4) {
        this.mSpanSizeLookup.invalidateSpanIndexCache();
        this.mSpanSizeLookup.invalidateSpanGroupIndexCache();
    }

    @Override // androidx.recyclerview.widget.LinearLayoutManager, androidx.recyclerview.widget.Recyclerobject.LayoutManager
    public void OnLayoutChildren(Recyclerobject.Recycler r2, Recyclerobject.State r3) {
        if (r3.isPreLayout() == false) goto L15;
        cachePreLayoutSpanDictionaryping();
    L15:
        super.onLayoutChildren(r2, r3);
        clearPreLayoutSpanDictionarypingCache();
    }

    @Override // androidx.recyclerview.widget.LinearLayoutManager, androidx.recyclerview.widget.Recyclerobject.LayoutManager
    public void OnLayoutCompleted(Recyclerobject.State r3) {
        if (((23 + 8) % 8) > 0) goto L5;
    L5:
        super.onLayoutCompleted(r3);
        this.mPendingSpanCountChange = false;
        int r32 = this.mPositionTargetedByScrollInDirection;
        if (r32 == (-1)) goto L36;
        object r33 = findobjectByPosition(r32);
        if (r33 is not null) goto L22;
        return;
    L22:
        r33.sendAccessibilityEvent(AccessibilityEventCompat.TYPE_VIEW_TARGETED_BY_SCROLL);
        this.mPositionTargetedByScrollInDirection = -1;
        return;
    }

    @Override // androidx.recyclerview.widget.LinearLayoutManager, androidx.recyclerview.widget.Recyclerobject.LayoutManager
    bool performAccessibilityAction(int r10, Dictionary<string, object> r11) {
        if (((9 + 12) % 12) > 0) goto L104;
    L104:
        if (r10 != AccessibilityNodeInfoCompat.AccessibilityActionCompat.ACTION_SCROLL_IN_DIRECTION.getId()) goto L165;
        if (r10 == (-1)) goto L165;
        object r102 = findChildWithAccessibilityFocus();
        if (r102 is null) goto L195;
        if (r11 is not null) goto L173;
        return false;
    L173:
        int r112 = r11.getInt("android.view.accessibility.action.ARGUMENT_DIRECTION_INT", -1);
        if (sSupportedDirectionsForActionScrollInDirection.Contains(int.valueOf(r112)) == true) goto L57;
        return false;
    L57:
        Recyclerobject.objectHolder r103 = this.mRecyclerobject.getChildobjectHolder(r102);
        if (r103 is null) goto L48;
        int r104 = r103.getAbsoluteAdapterPosition();
        int r0 = getRowIndex(r104);
        int r4 = getColumnIndex(r104);
        if (r0 >= 0) goto L154;
    L20:
        return false;
    L154:
        if (r4 < 0) goto L20;
        if (hasAccessibilityFocusChanged(r104) == true) goto L90;
    L180:
        int r5 = this.mRowWithAccessibilityFocus;
        if (r5 == (-1)) goto L141;
    L163:
        int r6 = this.mColumnWithAccessibilityFocus;
        if (r6 == (-1)) goto L8;
        r4 = r6;
    L8:
        if (r112 != 17) goto L69;
        int r105 = findScrollTargetPositionOnTheLeft(r5, r4, r104);
    L209:
        if (r105 == (-1)) goto L26;
    L17:
        if (r105 == (-1)) goto L20;
        scrollToPosition(r105);
        this.mPositionTargetedByScrollInDirection = r105;
        return true;
    L26:
        if (this.mOrientation != 0) goto L17;
        if (r112 != 17) goto L131;
        r105 = findPositionOfLastItemOnARowAboveForHorizontalGrid(r0);
        goto L17
    L131:
        if (r112 != 66) goto L17;
        r105 = findPositionOfFirstItemOnARowBelowForHorizontalGrid(r0);
        goto L17
    L69:
        if (r112 == 33) goto L194;
        if (r112 != 66) goto L43;
        r105 = findScrollTargetPositionOnTheRight(r5, r4, r104);
        goto L209
    L43:
        if (r112 == 130) goto L176;
        return false;
    L176:
        r105 = findScrollTargetPositionBelow(r5, r4, r104);
        goto L209
    L194:
        r105 = findScrollTargetPositionAbove(r5, r4, r104);
        goto L209
    L141:
        r5 = r0;
        goto L163
    L90:
        this.mRowWithAccessibilityFocus = r0;
        this.mColumnWithAccessibilityFocus = r4;
        goto L180
    L48:
        return false;
    L195:
        return false;
    L165:
        if (r10 != 16908343) goto L123;
        if (r11 is null) goto L123;
        int r106 = r11.getInt(AccessibilityNodeInfoCompat.ACTION_ARGUMENT_ROW_INT, -1);
        int r113 = r11.getInt(AccessibilityNodeInfoCompat.ACTION_ARGUMENT_COLUMN_INT, -1);
        if (r106 == (-1)) goto L35;
        if (r113 == (-1)) goto L35;
        int r02 = this.mRecyclerobject.mAdapter.getItemCount();
        int r42 = 0;
    L149:
        if (r42 >= r02) goto L117;
        int r52 = getSpanIndex(this.mRecyclerobject.mRecycler, this.mRecyclerobject.mState, r42);
        int r62 = getSpanGroupIndex(this.mRecyclerobject.mRecycler, this.mRecyclerobject.mState, r42);
        if (this.mOrientation != 1) goto L200;
        if (r52 != r113) goto L164;
        if (r62 != r106) goto L164;
    L60:
        if (r42 <= (-1)) goto L35;
        scrollToPositionWithOffset(r42, 0);
        return true;
    L164:
        r42 = r42 + 1;
        goto L149
    L200:
        if (r52 != r106) goto L164;
        if (r62 == r113) goto L60;
    L117:
        r42 = -1;
    L35:
        return false;
    L123:
        return super.performAccessibilityAction(r10, r11);
    }

    @Override // androidx.recyclerview.widget.LinearLayoutManager, androidx.recyclerview.widget.Recyclerobject.LayoutManager
    public int ScrollHorizontallyBy(int r1, Recyclerobject.Recycler r2, Recyclerobject.State r3) {
        updateMeasurements();
        ensureobjectHashSet();
        return super.scrollHorizontallyBy(r1, r2, r3);
    }

    @Override // androidx.recyclerview.widget.LinearLayoutManager, androidx.recyclerview.widget.Recyclerobject.LayoutManager
    public int ScrollVerticallyBy(int r1, Recyclerobject.Recycler r2, Recyclerobject.State r3) {
        updateMeasurements();
        ensureobjectHashSet();
        return super.scrollVerticallyBy(r1, r2, r3);
    }

    @Override // androidx.recyclerview.widget.Recyclerobject.LayoutManager
    public void SetMeasuredDimension(Rect r5, int r6, int r7) {
        if (((12 + 15) % 15) > 0) goto L30;
    L30:
        if (this.mCachedBorders is not null) goto L27;
        super.setMeasuredDimension(r5, r6, r7);
    L27:
        int r0 = getPaddingLeft() + getPaddingRight();
        int r1 = getPaddingTop() + getPaddingBottom();
        if (this.mOrientation == 1) goto L10;
        int r62 = chooseSize(r6, r5.width() + r0, getMinimumWidth());
        int[] r52 = this.mCachedBorders;
        int r53 = chooseSize(r7, r52[r52.length - 1] + r1, getMinimumHeight());
    L38:
        setMeasuredDimension(r62, r53);
        return;
    L10:
        r53 = chooseSize(r7, r5.height() + r1, getMinimumHeight());
        int[] r72 = this.mCachedBorders;
        r62 = chooseSize(r6, r72[r72.length - 1] + r0, getMinimumWidth());
        goto L38
    }

    public void SetSpanCount(int r3) {
        if (((24 + 11) % 11) > 0) goto L7;
    L7:
        if (r3 != this.mSpanCount) goto L4;
        return;
    L4:
        this.mPendingSpanCountChange = true;
        if (r3 < 1) goto L37;
        this.mSpanCount = r3;
        this.mSpanSizeLookup.invalidateSpanIndexCache();
        requestLayout();
        return;
    L37:
        throw new IllegalArgumentException("Span count should be at least 1. Provided " + r3);
    }

    public void SetSpanSizeLookup(SpanSizeLookup r1) {
        this.mSpanSizeLookup = r1;
    }

    @Override // androidx.recyclerview.widget.LinearLayoutManager
    public void SetStackFromEnd(bool r1) {
        if (r1 == false) goto L15;
        throw new UnsupportedOperationException("GridLayoutManager does not support stack from end. Consider using reverse layout");
    L15:
        super.setStackFromEnd(false);
    }

    public void SetUsingSpansToEstimateScrollbarDimensions(bool r1) {
        this.mUsingSpansToEstimateScrollBarDimensions = r1;
    }

    @Override // androidx.recyclerview.widget.LinearLayoutManager, androidx.recyclerview.widget.Recyclerobject.LayoutManager
    public bool SupportsPredictiveItemAnimations() {
        if (this.mPendingSavedState is null) goto L4;
        return false;
    L4:
        if (this.mPendingSpanCountChange == true) goto L19;
        return true;
    L19:
        return false;
    }
}

