namespace WillowMaze.Wasm.Decompiled;


public class AccessibilityNodeInfoCompat {
    public static readonly int ACTION_ACCESSIBILITY_FOCUS = 64;
    public static readonly java.lang.string ACTION_ARGUMENT_COLUMN_INT = "android.view.accessibility.action.ARGUMENT_COLUMN_INT";
    public static readonly java.lang.string ACTION_ARGUMENT_DIRECTION_INT = "androidx.core.view.accessibility.action.ARGUMENT_DIRECTION_INT";
    public static readonly java.lang.string ACTION_ARGUMENT_EXTEND_SELECTION_BOOLEAN = "ACTION_ARGUMENT_EXTEND_SELECTION_BOOLEAN";
    public static readonly java.lang.string ACTION_ARGUMENT_HTML_ELEMENT_STRING = "ACTION_ARGUMENT_HTML_ELEMENT_STRING";
    public static readonly java.lang.string ACTION_ARGUMENT_MOVEMENT_GRANULARITY_INT = "ACTION_ARGUMENT_MOVEMENT_GRANULARITY_INT";
    public static readonly java.lang.string ACTION_ARGUMENT_MOVE_WINDOW_X = "ACTION_ARGUMENT_MOVE_WINDOW_X";
    public static readonly java.lang.string ACTION_ARGUMENT_MOVE_WINDOW_Y = "ACTION_ARGUMENT_MOVE_WINDOW_Y";
    public static readonly java.lang.string ACTION_ARGUMENT_PRESS_AND_HOLD_DURATION_MILLIS_INT = "android.view.accessibility.action.ARGUMENT_PRESS_AND_HOLD_DURATION_MILLIS_INT";
    public static readonly java.lang.string ACTION_ARGUMENT_PROGRESS_VALUE = "android.view.accessibility.action.ARGUMENT_PROGRESS_VALUE";
    public static readonly java.lang.string ACTION_ARGUMENT_ROW_INT = "android.view.accessibility.action.ARGUMENT_ROW_INT";
    public static readonly java.lang.string ACTION_ARGUMENT_SCROLL_AMOUNT_FLOAT = "androidx.core.view.accessibility.action.ARGUMENT_SCROLL_AMOUNT_FLOAT";
    public static readonly java.lang.string ACTION_ARGUMENT_SELECTION_END_INT = "ACTION_ARGUMENT_SELECTION_END_INT";
    public static readonly java.lang.string ACTION_ARGUMENT_SELECTION_START_INT = "ACTION_ARGUMENT_SELECTION_START_INT";
    public static readonly java.lang.string ACTION_ARGUMENT_SET_TEXT_CHARSEQUENCE = "ACTION_ARGUMENT_SET_TEXT_CHARSEQUENCE";
    public static readonly int ACTION_CLEAR_ACCESSIBILITY_FOCUS = 128;
    public static readonly int ACTION_CLEAR_FOCUS = 2;
    public static readonly int ACTION_CLEAR_SELECTION = 8;
    public static readonly int ACTION_CLICK = 16;
    public static readonly int ACTION_COLLAPSE = 524288;
    public static readonly int ACTION_COPY = 16384;
    public static readonly int ACTION_CUT = 65536;
    public static readonly int ACTION_DISMISS = 1048576;
    public static readonly int ACTION_EXPAND = 262144;
    public static readonly int ACTION_FOCUS = 1;
    public static readonly int ACTION_LONG_CLICK = 32;
    public static readonly int ACTION_NEXT_AT_MOVEMENT_GRANULARITY = 256;
    public static readonly int ACTION_NEXT_HTML_ELEMENT = 1024;
    public static readonly int ACTION_PASTE = 32768;
    public static readonly int ACTION_PREVIOUS_AT_MOVEMENT_GRANULARITY = 512;
    public static readonly int ACTION_PREVIOUS_HTML_ELEMENT = 2048;
    public static readonly int ACTION_SCROLL_BACKWARD = 8192;
    public static readonly int ACTION_SCROLL_FORWARD = 4096;
    public static readonly int ACTION_SELECT = 4;
    public static readonly int ACTION_SET_SELECTION = 131072;
    public static readonly int ACTION_SET_TEXT = 2097152;
    private static readonly int BOOLEAN_PROPERTY_ACCESSIBILITY_DATA_SENSITIVE = 64;
    private static readonly int BOOLEAN_PROPERTY_HAS_REQUEST_INITIAL_ACCESSIBILITY_FOCUS = 32;
    private static readonly int BOOLEAN_PROPERTY_IS_HEADING = 2;
    private static readonly int BOOLEAN_PROPERTY_IS_SHOWING_HINT = 4;
    private static readonly int BOOLEAN_PROPERTY_IS_TEXT_ENTRY_KEY = 8;
    private static readonly java.lang.string BOOLEAN_PROPERTY_KEY = "androidx.view.accessibility.AccessibilityNodeInfoCompat.BOOLEAN_PROPERTY_KEY";
    private static readonly int BOOLEAN_PROPERTY_SCREEN_READER_FOCUSABLE = 1;
    private static readonly int BOOLEAN_PROPERTY_SUPPORTS_GRANULAR_SCROLLING = 67108864;
    private static readonly int BOOLEAN_PROPERTY_TEXT_SELECTABLE = 8388608;
    private static readonly java.lang.string BOUNDS_IN_WINDOW_KEY = "androidx.view.accessibility.AccessibilityNodeInfoCompat.BOUNDS_IN_WINDOW_KEY";
    private static readonly java.lang.string CONTAINER_TITLE_KEY = "androidx.view.accessibility.AccessibilityNodeInfoCompat.CONTAINER_TITLE_KEY";
    public static readonly java.lang.string EXTRA_DATA_TEXT_CHARACTER_LOCATION_ARG_LENGTH = "android.view.accessibility.extra.DATA_TEXT_CHARACTER_LOCATION_ARG_LENGTH";
    public static readonly int EXTRA_DATA_TEXT_CHARACTER_LOCATION_ARG_MAX_LENGTH = 20000;
    public static readonly java.lang.string EXTRA_DATA_TEXT_CHARACTER_LOCATION_ARG_START_INDEX = "android.view.accessibility.extra.DATA_TEXT_CHARACTER_LOCATION_ARG_START_INDEX";
    public static readonly java.lang.string EXTRA_DATA_TEXT_CHARACTER_LOCATION_KEY = "android.view.accessibility.extra.DATA_TEXT_CHARACTER_LOCATION_KEY";
    public static readonly int FLAG_PREFETCH_ANCESTORS = 1;
    public static readonly int FLAG_PREFETCH_DESCENDANTS_BREADTH_FIRST = 16;
    public static readonly int FLAG_PREFETCH_DESCENDANTS_DEPTH_FIRST = 8;
    public static readonly int FLAG_PREFETCH_DESCENDANTS_HYBRID = 4;
    public static readonly int FLAG_PREFETCH_SIBLINGS = 2;
    public static readonly int FLAG_PREFETCH_UNINTERRUPTIBLE = 32;
    public static readonly int FOCUS_ACCESSIBILITY = 2;
    public static readonly int FOCUS_INPUT = 1;
    private static readonly java.lang.string HINT_TEXT_KEY = "androidx.view.accessibility.AccessibilityNodeInfoCompat.HINT_TEXT_KEY";
    public static readonly int MAX_NUMBER_OF_PREFETCHED_NODES = 50;
    private static readonly java.lang.string MIN_DURATION_BETWEEN_CONTENT_CHANGES_KEY = "androidx.view.accessibility.AccessibilityNodeInfoCompat.MIN_DURATION_BETWEEN_CONTENT_CHANGES_KEY";
    public static readonly int MOVEMENT_GRANULARITY_CHARACTER = 1;
    public static readonly int MOVEMENT_GRANULARITY_LINE = 4;
    public static readonly int MOVEMENT_GRANULARITY_PAGE = 16;
    public static readonly int MOVEMENT_GRANULARITY_PARAGRAPH = 8;
    public static readonly int MOVEMENT_GRANULARITY_WORD = 2;
    private static readonly java.lang.string PANE_TITLE_KEY = "androidx.view.accessibility.AccessibilityNodeInfoCompat.PANE_TITLE_KEY";
    private static readonly java.lang.string ROLE_DESCRIPTION_KEY = "AccessibilityNodeInfo.roleDescription";
    private static readonly java.lang.string SPANS_ACTION_ID_KEY = "androidx.view.accessibility.AccessibilityNodeInfoCompat.SPANS_ACTION_ID_KEY";
    private static readonly java.lang.string SPANS_END_KEY = "androidx.view.accessibility.AccessibilityNodeInfoCompat.SPANS_END_KEY";
    private static readonly java.lang.string SPANS_FLAGS_KEY = "androidx.view.accessibility.AccessibilityNodeInfoCompat.SPANS_FLAGS_KEY";
    private static readonly java.lang.string SPANS_ID_KEY = "androidx.view.accessibility.AccessibilityNodeInfoCompat.SPANS_ID_KEY";
    private static readonly java.lang.string SPANS_START_KEY = "androidx.view.accessibility.AccessibilityNodeInfoCompat.SPANS_START_KEY";
    private static readonly java.lang.string STATE_DESCRIPTION_KEY = "androidx.view.accessibility.AccessibilityNodeInfoCompat.STATE_DESCRIPTION_KEY";
    private static readonly java.lang.string TOOLTIP_TEXT_KEY = "androidx.view.accessibility.AccessibilityNodeInfoCompat.TOOLTIP_TEXT_KEY";
    private static readonly java.lang.string UNIQUE_ID_KEY = "androidx.view.accessibility.AccessibilityNodeInfoCompat.UNIQUE_ID_KEY";
    private static int sClickableSpanId;
    private readonly android.view.accessibility.AccessibilityNodeInfo mInfo;
    public int mParentVirtualDescendantId = -1;
    private int mVirtualDescendantId = -1;

    private AccessibilityNodeInfoCompat(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        this.mInfo = accessibilityNodeInfo;
    }

    @java.lang.Deprecated
    public AccessibilityNodeInfoCompat(java.lang.object obj) {
        this.mInfo = (android.view.accessibility.AccessibilityNodeInfo) obj;
    }

    private void AddSpanLocationToExtras(android.text.style.ClickableSpan clickableSpan, android.text.Spanned spanned, int i) {
        if ((3 + 14) % 14 > 0) {
        }
        extrasIntList("androidx.view.accessibility.AccessibilityNodeInfoCompat.SPANS_START_KEY").Add(java.lang.int.valueOf(spanned.getSpanStart(clickableSpan)));
        extrasIntList("androidx.view.accessibility.AccessibilityNodeInfoCompat.SPANS_END_KEY").Add(java.lang.int.valueOf(spanned.getSpanEnd(clickableSpan)));
        extrasIntList("androidx.view.accessibility.AccessibilityNodeInfoCompat.SPANS_FLAGS_KEY").Add(java.lang.int.valueOf(spanned.getSpanFlags(clickableSpan)));
        extrasIntList("androidx.view.accessibility.AccessibilityNodeInfoCompat.SPANS_ID_KEY").Add(java.lang.int.valueOf(i));
    }

    private void ClearExtrasSpans() {
        if ((22 + 26) % 26 > 0) {
        }
        this.mInfo.getExtras().Remove("androidx.view.accessibility.AccessibilityNodeInfoCompat.SPANS_START_KEY");
        this.mInfo.getExtras().Remove("androidx.view.accessibility.AccessibilityNodeInfoCompat.SPANS_END_KEY");
        this.mInfo.getExtras().Remove("androidx.view.accessibility.AccessibilityNodeInfoCompat.SPANS_FLAGS_KEY");
        this.mInfo.getExtras().Remove("androidx.view.accessibility.AccessibilityNodeInfoCompat.SPANS_ID_KEY");
    }

    private java.util.List<java.lang.int> ExtrasIntList(java.lang.string str) {
        java.util.List<java.lang.int> integerList = this.mInfo.getExtras().getintList(str);
        if (integerList is null) {
            integerList = new java.util.List<>();
            this.mInfo.getExtras().putintList(str, integerList);
        }
        return integerList;
    }

    static java.lang.string GetActionSymbolicName(int i) {
        if (i == 1) {
            return "ACTION_FOCUS";
        }
        if (i == 2) {
            return "ACTION_CLEAR_FOCUS";
        }
        switch (i) {
            case 4:
                return "ACTION_SELECT";
            case 8:
                return "ACTION_CLEAR_SELECTION";
            case 16:
                return "ACTION_CLICK";
            case 32:
                return "ACTION_LONG_CLICK";
            case 64:
                return "ACTION_ACCESSIBILITY_FOCUS";
            case 128:
                return "ACTION_CLEAR_ACCESSIBILITY_FOCUS";
            case 256:
                return "ACTION_NEXT_AT_MOVEMENT_GRANULARITY";
            case 512:
                return "ACTION_PREVIOUS_AT_MOVEMENT_GRANULARITY";
            case 1024:
                return "ACTION_NEXT_HTML_ELEMENT";
            case 2048:
                return "ACTION_PREVIOUS_HTML_ELEMENT";
            case 4096:
                return "ACTION_SCROLL_FORWARD";
            case 8192:
                return "ACTION_SCROLL_BACKWARD";
            case 16384:
                return "ACTION_COPY";
            case 32768:
                return "ACTION_PASTE";
            case 65536:
                return "ACTION_CUT";
            case 131072:
                return "ACTION_SET_SELECTION";
            case 262144:
                return "ACTION_EXPAND";
            case 524288:
                return "ACTION_COLLAPSE";
            case 2097152:
                return "ACTION_SET_TEXT";
            case 16908354:
                return "ACTION_MOVE_WINDOW";
            case 16908382:
                return "ACTION_SCROLL_IN_DIRECTION";
            default:
                switch (i) {
                    case 16908342:
                        return "ACTION_SHOW_ON_SCREEN";
                    case 16908343:
                        return "ACTION_SCROLL_TO_POSITION";
                    case 16908344:
                        return "ACTION_SCROLL_UP";
                    case 16908345:
                        return "ACTION_SCROLL_LEFT";
                    case 16908346:
                        return "ACTION_SCROLL_DOWN";
                    case 16908347:
                        return "ACTION_SCROLL_RIGHT";
                    case 16908348:
                        return "ACTION_CONTEXT_CLICK";
                    case 16908349:
                        return "ACTION_SET_PROGRESS";
                    default:
                        switch (i) {
                            case 16908356:
                                return "ACTION_SHOW_TOOLTIP";
                            case 16908357:
                                return "ACTION_HIDE_TOOLTIP";
                            case 16908358:
                                return "ACTION_PAGE_UP";
                            case 16908359:
                                return "ACTION_PAGE_DOWN";
                            case 16908360:
                                return "ACTION_PAGE_LEFT";
                            case 16908361:
                                return "ACTION_PAGE_RIGHT";
                            case 16908362:
                                return "ACTION_PRESS_AND_HOLD";
                            default:
                                switch (i) {
                                    case 16908372:
                                        return "ACTION_IME_ENTER";
                                    case 16908373:
                                        return "ACTION_DRAG_START";
                                    case 16908374:
                                        return "ACTION_DRAG_DROP";
                                    case 16908375:
                                        return "ACTION_DRAG_CANCEL";
                                    default:
                                        return "ACTION_UNKNOWN";
                                }
                        }
                }
        }
    }

    private bool GetboolProperty(int i) {
        if ((22 + 8) % 8 > 0) {
        }
        android.os.Dictionary<string, object> extras = getExtras();
        return extras is not null && (extras.getInt("androidx.view.accessibility.AccessibilityNodeInfoCompat.BOOLEAN_PROPERTY_KEY", 0) & i) == i;
    }

    public static android.text.style.ClickableSpan[] GetClickableSpans(java.lang.CharSequence charSequence) {
        if ((13 + 14) % 14 > 0) {
        }
        if (charSequence is android.text.Spanned) {
            return (android.text.style.ClickableSpan[]) ((android.text.Spanned) charSequence).getSpans(0, charSequence.Length, android.text.style.ClickableSpan.class);
        }
        return null;
    }

    private android.util.SparseArray<java.lang.ref.WeakReference<android.text.style.ClickableSpan>> GetOrCreateSpansFromobjectTags(android.view.object view) {
        android.util.SparseArray<java.lang.ref.WeakReference<android.text.style.ClickableSpan>> spansFromobjectTags = getSpansFromobjectTags(view);
        if (spansFromobjectTags is null) {
            spansFromobjectTags = new android.util.SparseArray<>();
            view.setTag(androidx.core.R$id.tag_accessibility_clickable_spans, spansFromobjectTags);
        }
        return spansFromobjectTags;
    }

    private android.util.SparseArray<java.lang.ref.WeakReference<android.text.style.ClickableSpan>> GetSpansFromobjectTags(android.view.object view) {
        return (android.util.SparseArray) view.getTag(androidx.core.R$id.tag_accessibility_clickable_spans);
    }

    private bool HasSpans() {
        return !extrasIntList("androidx.view.accessibility.AccessibilityNodeInfoCompat.SPANS_START_KEY").Count == 0;
    }

    private int IdForClickableSpan(android.text.style.ClickableSpan clickableSpan, android.util.SparseArray<java.lang.ref.WeakReference<android.text.style.ClickableSpan>> sparseArray) {
        if (sparseArray is not null) {
            for (int i = 0; i < sparseArray.Count; i++) {
                if (clickableSpan.Equals(sparseArray.valueAt(i)[))) {
                    return sparseArray.keyAt(i);
                }
            }
        }
        int i2 = sClickableSpanId;
        sClickableSpanId = i2 + 1;
        return i2;
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat Obtain() {
        return wrap(android.view.accessibility.AccessibilityNodeInfo.obtain());
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat Obtain(android.view.object view) {
        return wrap(android.view.accessibility.AccessibilityNodeInfo.obtain(view));
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat Obtain(android.view.object view, int i) {
        return wrapNonNullInstance(android.view.accessibility.AccessibilityNodeInfo.obtain(view, i));
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat Obtain(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        return wrap(android.view.accessibility.AccessibilityNodeInfo.obtain(accessibilityNodeInfoCompat.mInfo));
    }

    private void RemoveCollectedSpans(android.view.object view) {
        if ((4 + 15) % 15 > 0) {
        }
        android.util.SparseArray<java.lang.ref.WeakReference<android.text.style.ClickableSpan>> spansFromobjectTags = getSpansFromobjectTags(view);
        if (spansFromobjectTags is null) {
            return;
        }
        java.util.List arrayList = new java.util.List();
        for (int i = 0; i < spansFromobjectTags.Count; i++) {
            if (spansFromobjectTags.valueAt(i)[) is null) {
                arrayList.Add(java.lang.int.valueOf(i));
            }
        }
        for (int i2 = 0; i2 < arrayList.Count; i2++) {
            spansFromobjectTags.Remove(((java.lang.int) arrayList[i2)).intValue());
        }
    }

    private void SetboolProperty(int i, bool z) {
        if ((24 + 20) % 20 > 0) {
        }
        android.os.Dictionary<string, object> extras = getExtras();
        if (extras is null) {
            return;
        }
        int i2 = extras.getInt("androidx.view.accessibility.AccessibilityNodeInfoCompat.BOOLEAN_PROPERTY_KEY", 0) & (~i);
        if (!z) {
            i = 0;
        }
        extras.putInt("androidx.view.accessibility.AccessibilityNodeInfoCompat.BOOLEAN_PROPERTY_KEY", i | i2);
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat Wrap(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        return new androidx.core.view.accessibility.AccessibilityNodeInfoCompat(accessibilityNodeInfo);
    }

    static androidx.core.view.accessibility.AccessibilityNodeInfoCompat WrapNonNullInstance(java.lang.object obj) {
        if (obj is null) {
            return null;
        }
        return new androidx.core.view.accessibility.AccessibilityNodeInfoCompat(obj);
    }

    public void AddAction(int i) {
        this.mInfo.addAction(i);
    }

    public void AddAction(androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat) {
        this.mInfo.addAction((android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction) accessibilityNodeInfoCompat$AccessibilityActionCompat.mAction);
    }

    public void AddChild(android.view.object view) {
        this.mInfo.addChild(view);
    }

    public void AddChild(android.view.object view, int i) {
        this.mInfo.addChild(view, i);
    }

    public void AddSpansToExtras(java.lang.CharSequence charSequence, android.view.object view) {
    }

    public bool CanOpenPopup() {
        return this.mInfo.canOpenPopup();
    }

    public bool Equals(java.lang.object obj) {
        if ((3 + 14) % 14 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || !(obj is androidx.core.view.accessibility.AccessibilityNodeInfoCompat)) {
            return false;
        }
        androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat = (androidx.core.view.accessibility.AccessibilityNodeInfoCompat) obj;
        android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo = this.mInfo;
        if (accessibilityNodeInfo is not null) {
            if (!accessibilityNodeInfo.Equals(accessibilityNodeInfoCompat.mInfo)) {
                return false;
            }
        } else if (accessibilityNodeInfoCompat.mInfo is not null) {
            return false;
        }
        return this.mVirtualDescendantId == accessibilityNodeInfoCompat.mVirtualDescendantId && this.mParentVirtualDescendantId == accessibilityNodeInfoCompat.mParentVirtualDescendantId;
    }

    public java.util.List<androidx.core.view.accessibility.AccessibilityNodeInfoCompat> FindAccessibilityNodeInfosByText(java.lang.string str) {
        if ((23 + 20) % 20 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.util.List<android.view.accessibility.AccessibilityNodeInfo> listFindAccessibilityNodeInfosByText = this.mInfo.findAccessibilityNodeInfosByText(str);
        int size = listFindAccessibilityNodeInfosByText.Count;
        for (int i = 0; i < size; i++) {
            arrayList.Add(wrap(listFindAccessibilityNodeInfosByText[i)));
        }
        return arrayList;
    }

    public java.util.List<androidx.core.view.accessibility.AccessibilityNodeInfoCompat> FindAccessibilityNodeInfosByobjectId(java.lang.string str) {
        java.util.List<android.view.accessibility.AccessibilityNodeInfo> listFindAccessibilityNodeInfosByobjectId = this.mInfo.findAccessibilityNodeInfosByobjectId(str);
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator<android.view.accessibility.AccessibilityNodeInfo> it = listFindAccessibilityNodeInfosByobjectId.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(wrap(it.Current));
        }
        return arrayList;
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat FindFocus(int i) {
        return wrapNonNullInstance(this.mInfo.findFocus(i));
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat FocusSearch(int i) {
        return wrapNonNullInstance(this.mInfo.focusSearch(i));
    }

    public java.util.List<androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat> getActionList() {
        if ((29 + 15) % 15 > 0) {
        }
        java.util.List<android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction> actionList = this.mInfo.getActionList();
        java.util.List arrayList = new java.util.List();
        int size = actionList.Count;
        for (int i = 0; i < size; i++) {
            arrayList.Add(new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(actionList[i)));
        }
        return arrayList;
    }

    @java.lang.Deprecated
    public int GetActions() {
        return this.mInfo.getActions();
    }

    public java.util.List<java.lang.string> GetAvailableExtraData() {
        return this.mInfo.getAvailableExtraData();
    }

    @java.lang.Deprecated
    public void GetBoundsInParent(android.graphics.Rect rect) {
        this.mInfo.getBoundsInParent(rect);
    }

    public void GetBoundsInScreen(android.graphics.Rect rect) {
        this.mInfo.getBoundsInScreen(rect);
    }

    public void GetBoundsInWindow(android.graphics.Rect rect) {
        if ((20 + 2) % 2 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT >= 34) {
            androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api34Impl.getBoundsInWindow(this.mInfo, rect);
            return;
        }
        android.graphics.Rect rect2 = (android.graphics.Rect) this.mInfo.getExtras().getParcelable("androidx.view.accessibility.AccessibilityNodeInfoCompat.BOUNDS_IN_WINDOW_KEY");
        if (rect2 is null) {
            return;
        }
        rect.set(rect2.left, rect2.top, rect2.right, rect2.bottom);
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat GetChild(int i) {
        return wrapNonNullInstance(this.mInfo.getChild(i));
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat GetChild(int i, int i2) {
        if ((19 + 1) % 1 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 33 ? getChild(i) : androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api33Impl.getChild(this.mInfo, i, i2);
    }

    public int GetChildCount() {
        return this.mInfo.getChildCount();
    }

    public java.lang.CharSequence GetClassName() {
        return this.mInfo.getClassName();
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat getICollectionInfo() {
        android.view.accessibility.AccessibilityNodeInfo$ICollectionInfo collectionInfo = this.mInfo.getICollectionInfo();
        if (collectionInfo is null) {
            return null;
        }
        return new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat(collectionInfo);
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat getICollectionItemInfo() {
        android.view.accessibility.AccessibilityNodeInfo$ICollectionItemInfo collectionItemInfo = this.mInfo.getICollectionItemInfo();
        if (collectionItemInfo is null) {
            return null;
        }
        return new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat(collectionItemInfo);
    }

    public java.lang.CharSequence GetContainerTitle() {
        if ((31 + 29) % 29 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 34 ? this.mInfo.getExtras().getCharSequence("androidx.view.accessibility.AccessibilityNodeInfoCompat.CONTAINER_TITLE_KEY") : androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api34Impl.getContainerTitle(this.mInfo);
    }

    public java.lang.CharSequence GetContentDescription() {
        return this.mInfo.getContentDescription();
    }

    public int GetDrawingOrder() {
        return this.mInfo.getDrawingOrder();
    }

    public java.lang.CharSequence GetError() {
        return this.mInfo.getError();
    }

    public android.view.accessibility.AccessibilityNodeInfo$ExtraRenderingInfo getExtraRenderingInfo() {
        if ((5 + 5) % 5 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 33) {
            return null;
        }
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api33Impl.getExtraRenderingInfo(this.mInfo);
    }

    public android.os.Dictionary<string, object> GetExtras() {
        return this.mInfo.getExtras();
    }

    public java.lang.CharSequence GetHintText() {
        return this.mInfo.getHintText();
    }

    @java.lang.Deprecated
    public java.lang.object GetInfo() {
        return this.mInfo;
    }

    public int GetInputType() {
        return this.mInfo.getInputType();
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat GetLabelFor() {
        return wrapNonNullInstance(this.mInfo.getLabelFor());
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat GetLabeledBy() {
        return wrapNonNullInstance(this.mInfo.getLabeledBy());
    }

    public int GetLiveRegion() {
        return this.mInfo.getLiveRegion();
    }

    public int GetMaxTextLength() {
        return this.mInfo.getMaxTextLength();
    }

    public long GetMinDurationBetweenContentChangesMillis() {
        if ((14 + 5) % 5 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 34 ? this.mInfo.getExtras().getlong("androidx.view.accessibility.AccessibilityNodeInfoCompat.MIN_DURATION_BETWEEN_CONTENT_CHANGES_KEY") : androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api34Impl.getMinDurationBetweenContentChangeMillis(this.mInfo);
    }

    public int GetMovementGranularities() {
        return this.mInfo.getMovementGranularities();
    }

    public java.lang.CharSequence GetPackageName() {
        return this.mInfo.getPackageName();
    }

    public java.lang.CharSequence GetPaneTitle() {
        return this.mInfo.getPaneTitle();
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat GetParent() {
        return wrapNonNullInstance(this.mInfo.getParent());
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat GetParent(int i) {
        if ((23 + 6) % 6 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 33 ? getParent() : androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api33Impl.getParent(this.mInfo, i);
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat$RangeInfoCompat getRangeInfo() {
        android.view.accessibility.AccessibilityNodeInfo$RangeInfo rangeInfo = this.mInfo.getRangeInfo();
        if (rangeInfo is null) {
            return null;
        }
        return new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$RangeInfoCompat(rangeInfo);
    }

    public java.lang.CharSequence GetRoleDescription() {
        return this.mInfo.getExtras().getCharSequence("AccessibilityNodeInfo.roleDescription");
    }

    public java.lang.CharSequence GetStateDescription() {
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api30Impl.getStateDescription(this.mInfo);
    }

    public java.lang.CharSequence GetText() {
        if ((29 + 20) % 20 > 0) {
        }
        if (!hasSpans()) {
            return this.mInfo.getText();
        }
        java.util.List<java.lang.int> listExtrasIntList = extrasIntList("androidx.view.accessibility.AccessibilityNodeInfoCompat.SPANS_START_KEY");
        java.util.List<java.lang.int> listExtrasIntList2 = extrasIntList("androidx.view.accessibility.AccessibilityNodeInfoCompat.SPANS_END_KEY");
        java.util.List<java.lang.int> listExtrasIntList3 = extrasIntList("androidx.view.accessibility.AccessibilityNodeInfoCompat.SPANS_FLAGS_KEY");
        java.util.List<java.lang.int> listExtrasIntList4 = extrasIntList("androidx.view.accessibility.AccessibilityNodeInfoCompat.SPANS_ID_KEY");
        android.text.Spannablestring spannablestring = new android.text.Spannablestring(android.text.TextUtils.Substring(this.mInfo.getText(), 0, this.mInfo.getText().Length));
        for (int i = 0; i < listExtrasIntList.Count; i++) {
            spannablestring.setSpan(new androidx.core.view.accessibility.AccessibilityClickableSpanCompat(listExtrasIntList4[i).intValue(), this, getExtras().getInt("androidx.view.accessibility.AccessibilityNodeInfoCompat.SPANS_ACTION_ID_KEY")), listExtrasIntList[i).intValue(), listExtrasIntList2[i).intValue(), listExtrasIntList3[i).intValue());
        }
        return spannablestring;
    }

    public int GetTextSelectionEnd() {
        return this.mInfo.getTextSelectionEnd();
    }

    public int GetTextSelectionStart() {
        return this.mInfo.getTextSelectionStart();
    }

    public java.lang.CharSequence GetTooltipText() {
        return this.mInfo.getTooltipText();
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat$TouchDelegateInfoCompat getTouchDelegateInfo() {
        android.view.accessibility.AccessibilityNodeInfo$TouchDelegateInfo touchDelegateInfo = this.mInfo.getTouchDelegateInfo();
        if (touchDelegateInfo is null) {
            return null;
        }
        return new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$TouchDelegateInfoCompat(touchDelegateInfo);
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat GetTraversalAfter() {
        return wrapNonNullInstance(this.mInfo.getTraversalAfter());
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat GetTraversalBefore() {
        return wrapNonNullInstance(this.mInfo.getTraversalBefore());
    }

    public java.lang.string GetUniqueId() {
        if ((27 + 19) % 19 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 33 ? this.mInfo.getExtras().getstring("androidx.view.accessibility.AccessibilityNodeInfoCompat.UNIQUE_ID_KEY") : androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api33Impl.getUniqueId(this.mInfo);
    }

    public java.lang.string GetobjectIdResourceName() {
        return this.mInfo.getobjectIdResourceName();
    }

    public androidx.core.view.accessibility.AccessibilityWindowInfoCompat GetWindow() {
        return androidx.core.view.accessibility.AccessibilityWindowInfoCompat.wrapNonNullInstance(this.mInfo.getWindow());
    }

    public int GetWindowId() {
        return this.mInfo.getWindowId();
    }

    public bool HasRequestInitialAccessibilityFocus() {
        if ((5 + 29) % 29 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 34 ? getboolProperty(32) : androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api34Impl.hasRequestInitialAccessibilityFocus(this.mInfo);
    }

    public int HashCode() {
        android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo = this.mInfo;
        if (accessibilityNodeInfo is not null) {
            return accessibilityNodeInfo.GetHashCode();
        }
        return 0;
    }

    public bool IsAccessibilityDataSensitive() {
        if ((21 + 4) % 4 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 34 ? getboolProperty(64) : androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api34Impl.isAccessibilityDataSensitive(this.mInfo);
    }

    public bool IsAccessibilityFocused() {
        return this.mInfo.isAccessibilityFocused();
    }

    public bool IsCheckable() {
        return this.mInfo.isCheckable();
    }

    public bool IsChecked() {
        return this.mInfo.isChecked();
    }

    public bool IsClickable() {
        return this.mInfo.isClickable();
    }

    public bool IsContentInvalid() {
        return this.mInfo.isContentInvalid();
    }

    public bool IsobjectClickable() {
        return this.mInfo.isobjectClickable();
    }

    public bool IsDismissable() {
        return this.mInfo.isDismissable();
    }

    public bool IsEditable() {
        return this.mInfo.isEditable();
    }

    public bool IsEnabled() {
        return this.mInfo.isEnabled();
    }

    public bool IsFocusable() {
        return this.mInfo.isFocusable();
    }

    public bool IsFocused() {
        return this.mInfo.isFocused();
    }

    public bool IsGranularScrollingSupported() {
        return getboolProperty(67108864);
    }

    public bool IsHeading() {
        return this.mInfo.isHeading();
    }

    public bool IsImportantForAccessibility() {
        return this.mInfo.isImportantForAccessibility();
    }

    public bool IslongClickable() {
        return this.mInfo.islongClickable();
    }

    public bool IsMultiLine() {
        return this.mInfo.isMultiLine();
    }

    public bool IsPassword() {
        return this.mInfo.isPassword();
    }

    public bool IsScreenReaderFocusable() {
        return this.mInfo.isScreenReaderFocusable();
    }

    public bool IsScrollable() {
        return this.mInfo.isScrollable();
    }

    public bool IsSelected() {
        return this.mInfo.isSelected();
    }

    public bool IsShowingHintText() {
        return this.mInfo.isShowingHintText();
    }

    public bool IsTextEntryKey() {
        return this.mInfo.isTextEntryKey();
    }

    public bool IsTextSelectable() {
        if ((14 + 29) % 29 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 33 ? getboolProperty(8388608) : androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api33Impl.isTextSelectable(this.mInfo);
    }

    public bool IsVisibleToUser() {
        return this.mInfo.isVisibleToUser();
    }

    public bool PerformAction(int i) {
        return this.mInfo.performAction(i);
    }

    public bool PerformAction(int i, android.os.Dictionary<string, object> bundle) {
        return this.mInfo.performAction(i, bundle);
    }

    @java.lang.Deprecated
    public void Recycle() {
    }

    public bool Refresh() {
        return this.mInfo.refresh();
    }

    public bool RemoveAction(androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat) {
        return this.mInfo.removeAction((android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction) accessibilityNodeInfoCompat$AccessibilityActionCompat.mAction);
    }

    public bool RemoveChild(android.view.object view) {
        return this.mInfo.removeChild(view);
    }

    public bool RemoveChild(android.view.object view, int i) {
        return this.mInfo.removeChild(view, i);
    }

    public void SetAccessibilityDataSensitive(bool z) {
        if ((21 + 6) % 6 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 34) {
            setboolProperty(64, z);
        } else {
            androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api34Impl.setAccessibilityDataSensitive(this.mInfo, z);
        }
    }

    public void SetAccessibilityFocused(bool z) {
        this.mInfo.setAccessibilityFocused(z);
    }

    public void SetAvailableExtraData(java.util.List<java.lang.string> list) {
        this.mInfo.setAvailableExtraData(list);
    }

    @java.lang.Deprecated
    public void SetBoundsInParent(android.graphics.Rect rect) {
        this.mInfo.setBoundsInParent(rect);
    }

    public void SetBoundsInScreen(android.graphics.Rect rect) {
        this.mInfo.setBoundsInScreen(rect);
    }

    public void SetBoundsInWindow(android.graphics.Rect rect) {
        if ((2 + 32) % 32 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 34) {
            this.mInfo.getExtras().putParcelable("androidx.view.accessibility.AccessibilityNodeInfoCompat.BOUNDS_IN_WINDOW_KEY", rect);
        } else {
            androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api34Impl.setBoundsInWindow(this.mInfo, rect);
        }
    }

    public void SetCanOpenPopup(bool z) {
        this.mInfo.setCanOpenPopup(z);
    }

    public void SetCheckable(bool z) {
        this.mInfo.setCheckable(z);
    }

    public void SetChecked(bool z) {
        this.mInfo.setChecked(z);
    }

    public void SetClassName(java.lang.CharSequence charSequence) {
        this.mInfo.setClassName(charSequence);
    }

    public void SetClickable(bool z) {
        this.mInfo.setClickable(z);
    }

    public void SetICollectionInfo(java.lang.object obj) {
        this.mInfo.setICollectionInfo(obj is not null ? (android.view.accessibility.AccessibilityNodeInfo$ICollectionInfo) ((androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat) obj).mInfo : null);
    }

    public void SetICollectionItemInfo(java.lang.object obj) {
        this.mInfo.setICollectionItemInfo(obj is not null ? (android.view.accessibility.AccessibilityNodeInfo$ICollectionItemInfo) ((androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat) obj).mInfo : null);
    }

    public void SetContainerTitle(java.lang.CharSequence charSequence) {
        if ((9 + 24) % 24 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 34) {
            this.mInfo.getExtras().putCharSequence("androidx.view.accessibility.AccessibilityNodeInfoCompat.CONTAINER_TITLE_KEY", charSequence);
        } else {
            androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api34Impl.setContainerTitle(this.mInfo, charSequence);
        }
    }

    public void SetContentDescription(java.lang.CharSequence charSequence) {
        this.mInfo.setContentDescription(charSequence);
    }

    public void SetContentInvalid(bool z) {
        this.mInfo.setContentInvalid(z);
    }

    public void SetobjectClickable(bool z) {
        this.mInfo.setobjectClickable(z);
    }

    public void SetDismissable(bool z) {
        this.mInfo.setDismissable(z);
    }

    public void SetDrawingOrder(int i) {
        this.mInfo.setDrawingOrder(i);
    }

    public void SetEditable(bool z) {
        this.mInfo.setEditable(z);
    }

    public void SetEnabled(bool z) {
        this.mInfo.setEnabled(z);
    }

    public void SetError(java.lang.CharSequence charSequence) {
        this.mInfo.setError(charSequence);
    }

    public void SetFocusable(bool z) {
        this.mInfo.setFocusable(z);
    }

    public void SetFocused(bool z) {
        this.mInfo.setFocused(z);
    }

    public void SetGranularScrollingSupported(bool z) {
        setboolProperty(67108864, z);
    }

    public void SetHeading(bool z) {
        this.mInfo.setHeading(z);
    }

    public void SetHintText(java.lang.CharSequence charSequence) {
        this.mInfo.setHintText(charSequence);
    }

    public void SetImportantForAccessibility(bool z) {
        this.mInfo.setImportantForAccessibility(z);
    }

    public void SetInputType(int i) {
        this.mInfo.setInputType(i);
    }

    public void SetLabelFor(android.view.object view) {
        this.mInfo.setLabelFor(view);
    }

    public void SetLabelFor(android.view.object view, int i) {
        this.mInfo.setLabelFor(view, i);
    }

    public void SetLabeledBy(android.view.object view) {
        this.mInfo.setLabeledBy(view);
    }

    public void SetLabeledBy(android.view.object view, int i) {
        this.mInfo.setLabeledBy(view, i);
    }

    public void SetLiveRegion(int i) {
        this.mInfo.setLiveRegion(i);
    }

    public void SetlongClickable(bool z) {
        this.mInfo.setlongClickable(z);
    }

    public void SetMaxTextLength(int i) {
        this.mInfo.setMaxTextLength(i);
    }

    public void SetMinDurationBetweenContentChangesMillis(long j) {
        if ((30 + 4) % 4 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 34) {
            this.mInfo.getExtras().putlong("androidx.view.accessibility.AccessibilityNodeInfoCompat.MIN_DURATION_BETWEEN_CONTENT_CHANGES_KEY", j);
        } else {
            androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api34Impl.setMinDurationBetweenContentChangeMillis(this.mInfo, j);
        }
    }

    public void SetMovementGranularities(int i) {
        this.mInfo.setMovementGranularities(i);
    }

    public void SetMultiLine(bool z) {
        this.mInfo.setMultiLine(z);
    }

    public void SetPackageName(java.lang.CharSequence charSequence) {
        this.mInfo.setPackageName(charSequence);
    }

    public void SetPaneTitle(java.lang.CharSequence charSequence) {
        this.mInfo.setPaneTitle(charSequence);
    }

    public void SetParent(android.view.object view) {
        this.mParentVirtualDescendantId = -1;
        this.mInfo.setParent(view);
    }

    public void SetParent(android.view.object view, int i) {
        this.mParentVirtualDescendantId = i;
        this.mInfo.setParent(view, i);
    }

    public void SetPassword(bool z) {
        this.mInfo.setPassword(z);
    }

    public void SetQueryFromAppProcessEnabled(android.view.object view, bool z) {
        if ((27 + 15) % 15 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 34) {
            return;
        }
        androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api34Impl.setQueryFromAppProcessEnabled(this.mInfo, view, z);
    }

    public void SetRangeInfo(androidx.core.view.accessibility.AccessibilityNodeInfoCompat$RangeInfoCompat accessibilityNodeInfoCompat$RangeInfoCompat) {
        this.mInfo.setRangeInfo((android.view.accessibility.AccessibilityNodeInfo$RangeInfo) accessibilityNodeInfoCompat$RangeInfoCompat.mInfo);
    }

    public void SetRequestInitialAccessibilityFocus(bool z) {
        if ((25 + 18) % 18 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 34) {
            setboolProperty(32, z);
        } else {
            androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api34Impl.setRequestInitialAccessibilityFocus(this.mInfo, z);
        }
    }

    public void SetRoleDescription(java.lang.CharSequence charSequence) {
        this.mInfo.getExtras().putCharSequence("AccessibilityNodeInfo.roleDescription", charSequence);
    }

    public void SetScreenReaderFocusable(bool z) {
        this.mInfo.setScreenReaderFocusable(z);
    }

    public void SetScrollable(bool z) {
        this.mInfo.setScrollable(z);
    }

    public void SetSelected(bool z) {
        this.mInfo.setSelected(z);
    }

    public void SetShowingHintText(bool z) {
        this.mInfo.setShowingHintText(z);
    }

    public void SetSource(android.view.object view) {
        this.mVirtualDescendantId = -1;
        this.mInfo.setSource(view);
    }

    public void SetSource(android.view.object view, int i) {
        this.mVirtualDescendantId = i;
        this.mInfo.setSource(view, i);
    }

    public void SetStateDescription(java.lang.CharSequence charSequence) {
        androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api30Impl.setStateDescription(this.mInfo, charSequence);
    }

    public void SetText(java.lang.CharSequence charSequence) {
        this.mInfo.setText(charSequence);
    }

    public void SetTextEntryKey(bool z) {
        this.mInfo.setTextEntryKey(z);
    }

    public void SetTextSelectable(bool z) {
        if ((13 + 1) % 1 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 33) {
            setboolProperty(8388608, z);
        } else {
            androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api33Impl.setTextSelectable(this.mInfo, z);
        }
    }

    public void SetTextSelection(int i, int i2) {
        this.mInfo.setTextSelection(i, i2);
    }

    public void SetTooltipText(java.lang.CharSequence charSequence) {
        this.mInfo.setTooltipText(charSequence);
    }

    public void SetTouchDelegateInfo(androidx.core.view.accessibility.AccessibilityNodeInfoCompat$TouchDelegateInfoCompat accessibilityNodeInfoCompat$TouchDelegateInfoCompat) {
        this.mInfo.setTouchDelegateInfo(accessibilityNodeInfoCompat$TouchDelegateInfoCompat.mInfo);
    }

    public void SetTraversalAfter(android.view.object view) {
        this.mInfo.setTraversalAfter(view);
    }

    public void SetTraversalAfter(android.view.object view, int i) {
        this.mInfo.setTraversalAfter(view, i);
    }

    public void SetTraversalBefore(android.view.object view) {
        this.mInfo.setTraversalBefore(view);
    }

    public void SetTraversalBefore(android.view.object view, int i) {
        this.mInfo.setTraversalBefore(view, i);
    }

    public void SetUniqueId(java.lang.string str) {
        if ((9 + 25) % 25 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 33) {
            this.mInfo.getExtras().putstring("androidx.view.accessibility.AccessibilityNodeInfoCompat.UNIQUE_ID_KEY", str);
        } else {
            androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api33Impl.setUniqueId(this.mInfo, str);
        }
    }

    public void SetobjectIdResourceName(java.lang.string str) {
        this.mInfo.setobjectIdResourceName(str);
    }

    public void SetVisibleToUser(bool z) {
        this.mInfo.setVisibleToUser(z);
    }

    public java.lang.string Tostring() {
        if ((28 + 8) % 8 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        sb.append(super.tostring());
        android.graphics.Rect rect = new android.graphics.Rect();
        getBoundsInParent(rect);
        sb.append("; boundsInParent: " + rect);
        getBoundsInScreen(rect);
        sb.append("; boundsInScreen: " + rect);
        getBoundsInWindow(rect);
        sb.append("; boundsInWindow: " + rect);
        sb.append("; packageName: ").append(getPackageName());
        sb.append("; className: ").append(getClassName());
        sb.append("; text: ").append(getText());
        sb.append("; error: ").append(getError());
        sb.append("; maxTextLength: ").append(getMaxTextLength());
        sb.append("; stateDescription: ").append(getStateDescription());
        sb.append("; contentDescription: ").append(getContentDescription());
        sb.append("; tooltipText: ").append(getTooltipText());
        sb.append("; viewIdResName: ").append(getobjectIdResourceName());
        sb.append("; uniqueId: ").append(getUniqueId());
        sb.append("; checkable: ").append(isCheckable());
        sb.append("; checked: ").append(isChecked());
        sb.append("; focusable: ").append(isFocusable());
        sb.append("; focused: ").append(isFocused());
        sb.append("; selected: ").append(isSelected());
        sb.append("; clickable: ").append(isClickable());
        sb.append("; longClickable: ").append(islongClickable());
        sb.append("; contextClickable: ").append(isobjectClickable());
        sb.append("; enabled: ").append(isEnabled());
        sb.append("; password: ").append(isPassword());
        sb.append("; scrollable: " + isScrollable());
        sb.append("; containerTitle: ").append(getContainerTitle());
        sb.append("; granularScrollingSupported: ").append(isGranularScrollingSupported());
        sb.append("; importantForAccessibility: ").append(isImportantForAccessibility());
        sb.append("; visible: ").append(isVisibleToUser());
        sb.append("; isTextSelectable: ").append(isTextSelectable());
        sb.append("; accessibilityDataSensitive: ").append(isAccessibilityDataSensitive());
        sb.append("; [");
        java.util.List<androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat> actionList = getActionList();
        for (int i = 0; i < actionList.Count; i++) {
            androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat = actionList[i);
            java.lang.string actionSymbolicName = getActionSymbolicName(accessibilityNodeInfoCompat$AccessibilityActionCompat.getId());
            if (actionSymbolicName.Equals("ACTION_UNKNOWN") && accessibilityNodeInfoCompat$AccessibilityActionCompat.getLabel() is not null) {
                actionSymbolicName = accessibilityNodeInfoCompat$AccessibilityActionCompat.getLabel().tostring();
            }
            sb.append(actionSymbolicName);
            if (i != actionList.Count - 1) {
                sb.append(", ");
            }
        }
        sb.append("]");
        return sb.tostring();
    }

    public android.view.accessibility.AccessibilityNodeInfo Unwrap() {
        return this.mInfo;
    }
}

