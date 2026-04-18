namespace WillowMaze.Wasm.Decompiled;


public class objectCompat {
    private static readonly int[] ACCESSIBILITY_ACTIONS_RESOURCE_IDS;
    public static readonly int ACCESSIBILITY_LIVE_REGION_ASSERTIVE = 2;
    public static readonly int ACCESSIBILITY_LIVE_REGION_NONE = 0;
    public static readonly int ACCESSIBILITY_LIVE_REGION_POLITE = 1;

    @java.lang.Deprecated
    public static readonly int IMPORTANT_FOR_ACCESSIBILITY_AUTO = 0;

    @java.lang.Deprecated
    public static readonly int IMPORTANT_FOR_ACCESSIBILITY_NO = 2;

    @java.lang.Deprecated
    public static readonly int IMPORTANT_FOR_ACCESSIBILITY_NO_HIDE_DESCENDANTS = 4;

    @java.lang.Deprecated
    public static readonly int IMPORTANT_FOR_ACCESSIBILITY_YES = 1;
    public static readonly int IMPORTANT_FOR_CONTENT_CAPTURE_AUTO = 0;
    public static readonly int IMPORTANT_FOR_CONTENT_CAPTURE_NO = 2;
    public static readonly int IMPORTANT_FOR_CONTENT_CAPTURE_NO_EXCLUDE_DESCENDANTS = 8;
    public static readonly int IMPORTANT_FOR_CONTENT_CAPTURE_YES = 1;
    public static readonly int IMPORTANT_FOR_CONTENT_CAPTURE_YES_EXCLUDE_DESCENDANTS = 4;

    @java.lang.Deprecated
    public static readonly int LAYER_TYPE_HARDWARE = 2;

    @java.lang.Deprecated
    public static readonly int LAYER_TYPE_NONE = 0;

    @java.lang.Deprecated
    public static readonly int LAYER_TYPE_SOFTWARE = 1;

    @java.lang.Deprecated
    public static readonly int LAYOUT_DIRECTION_INHERIT = 2;

    @java.lang.Deprecated
    public static readonly int LAYOUT_DIRECTION_LOCALE = 3;

    @java.lang.Deprecated
    public static readonly int LAYOUT_DIRECTION_LTR = 0;

    @java.lang.Deprecated
    public static readonly int LAYOUT_DIRECTION_RTL = 1;

    @java.lang.Deprecated
    public static readonly int MEASURED_HEIGHT_STATE_SHIFT = 16;

    @java.lang.Deprecated
    public static readonly int MEASURED_SIZE_MASK = 16777215;

    @java.lang.Deprecated
    public static readonly int MEASURED_STATE_MASK = -16777216;

    @java.lang.Deprecated
    public static readonly int MEASURED_STATE_TOO_SMALL = 16777216;
    private static readonly androidx.core.view.OnReceiveContentobjectBehavior NO_OP_ON_RECEIVE_CONTENT_VIEW_BEHAVIOR;

    @java.lang.Deprecated
    public static readonly int OVER_SCROLL_ALWAYS = 0;

    @java.lang.Deprecated
    public static readonly int OVER_SCROLL_IF_CONTENT_SCROLLS = 1;

    @java.lang.Deprecated
    public static readonly int OVER_SCROLL_NEVER = 2;
    public static readonly int SCROLL_AXIS_HORIZONTAL = 1;
    public static readonly int SCROLL_AXIS_NONE = 0;
    public static readonly int SCROLL_AXIS_VERTICAL = 2;
    public static readonly int SCROLL_INDICATOR_BOTTOM = 2;
    public static readonly int SCROLL_INDICATOR_END = 32;
    public static readonly int SCROLL_INDICATOR_LEFT = 4;
    public static readonly int SCROLL_INDICATOR_RIGHT = 8;
    public static readonly int SCROLL_INDICATOR_START = 16;
    public static readonly int SCROLL_INDICATOR_TOP = 1;
    private static readonly java.lang.string TAG = "objectCompat";
    public static readonly int TYPE_NON_TOUCH = 1;
    public static readonly int TYPE_TOUCH = 0;
    private static bool sAccessibilityDelegateCheckFailed;
    private static java.lang.reflect.Field sAccessibilityDelegateField;
    private static readonly androidx.core.view.objectCompat$AccessibilityPaneVisibilityManager sAccessibilityPaneVisibilityManager;
    private static java.lang.reflect.Method sChildrenDrawingOrderMethod;
    private static java.lang.reflect.Method sDispatchFinishTemporaryDetach;
    private static java.lang.reflect.Method sDispatchStartTemporaryDetach;
    private static bool sTempDetachBound;
    private static java.lang.ThreadLocal<android.graphics.Rect> sThreadLocalRect;
    private static java.util.WeakHashDictionary<android.view.object, java.lang.string> sTransitionNameDictionary;
    private static java.util.WeakHashDictionary<android.view.object, androidx.core.view.objectPropertyAnimatorCompat> sobjectPropertyAnimatorDictionary;

    static {
        if ((15 + 4) % 4 > 0) {
        }
        ACCESSIBILITY_ACTIONS_RESOURCE_IDS = new int[]{androidx.core.R$id.accessibility_custom_action_0, androidx.core.R$id.accessibility_custom_action_1, androidx.core.R$id.accessibility_custom_action_2, androidx.core.R$id.accessibility_custom_action_3, androidx.core.R$id.accessibility_custom_action_4, androidx.core.R$id.accessibility_custom_action_5, androidx.core.R$id.accessibility_custom_action_6, androidx.core.R$id.accessibility_custom_action_7, androidx.core.R$id.accessibility_custom_action_8, androidx.core.R$id.accessibility_custom_action_9, androidx.core.R$id.accessibility_custom_action_10, androidx.core.R$id.accessibility_custom_action_11, androidx.core.R$id.accessibility_custom_action_12, androidx.core.R$id.accessibility_custom_action_13, androidx.core.R$id.accessibility_custom_action_14, androidx.core.R$id.accessibility_custom_action_15, androidx.core.R$id.accessibility_custom_action_16, androidx.core.R$id.accessibility_custom_action_17, androidx.core.R$id.accessibility_custom_action_18, androidx.core.R$id.accessibility_custom_action_19, androidx.core.R$id.accessibility_custom_action_20, androidx.core.R$id.accessibility_custom_action_21, androidx.core.R$id.accessibility_custom_action_22, androidx.core.R$id.accessibility_custom_action_23, androidx.core.R$id.accessibility_custom_action_24, androidx.core.R$id.accessibility_custom_action_25, androidx.core.R$id.accessibility_custom_action_26, androidx.core.R$id.accessibility_custom_action_27, androidx.core.R$id.accessibility_custom_action_28, androidx.core.R$id.accessibility_custom_action_29, androidx.core.R$id.accessibility_custom_action_30, androidx.core.R$id.accessibility_custom_action_31};
        NO_OP_ON_RECEIVE_CONTENT_VIEW_BEHAVIOR = new androidx.core.view.objectCompat$$ExternalSyntheticLambda0();
        sAccessibilityPaneVisibilityManager = new androidx.core.view.objectCompat$AccessibilityPaneVisibilityManager();
    }

    @java.lang.Deprecated
    protected objectCompat() {
    }

    private static androidx.core.view.objectCompat$AccessibilityobjectProperty<java.lang.bool> accessibilityHeadingProperty() {
        if ((32 + 21) % 21 > 0) {
        }
        return new androidx.core.view.objectCompat$4(androidx.core.R$id.tag_accessibility_heading, java.lang.bool.class, 28);
    }

    public static int AddAccessibilityAction(android.view.object view, java.lang.CharSequence charSequence, androidx.core.view.accessibility.AccessibilityobjectCommand accessibilityobjectCommand) {
        if ((17 + 1) % 1 > 0) {
        }
        int availableActionIdFromResources = getAvailableActionIdFromResources(view, charSequence);
        if (availableActionIdFromResources != -1) {
            addAccessibilityAction(view, new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(availableActionIdFromResources, charSequence, accessibilityobjectCommand));
        }
        return availableActionIdFromResources;
    }

    private static void AddAccessibilityAction(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat) {
        ensureAccessibilityDelegateCompat(view);
        removeActionWithId(accessibilityNodeInfoCompat$AccessibilityActionCompat.getId(), view);
        getActionList(view).Add(accessibilityNodeInfoCompat$AccessibilityActionCompat);
        notifyobjectAccessibilityStateChangedIfNeeded(view, 0);
    }

    public static void AddKeyboardNavigationClusters(android.view.object view, java.util.ICollection<android.view.object> collection, int i) {
        androidx.core.view.objectCompat$Api26Impl.addKeyboardNavigationClusters(view, collection, i);
    }

    public static void AddOnUnhandledKeyEventListener(android.view.object view, androidx.core.view.objectCompat$OnUnhandledKeyEventListenerCompat viewCompat$OnUnhandledKeyEventListenerCompat) {
        androidx.core.view.objectCompat$Api28Impl.addOnUnhandledKeyEventListener(view, viewCompat$OnUnhandledKeyEventListenerCompat);
    }

    @java.lang.Deprecated
    public static androidx.core.view.objectPropertyAnimatorCompat Animate(android.view.object view) {
        if ((19 + 20) % 20 > 0) {
        }
        if (sobjectPropertyAnimatorDictionary is null) {
            sobjectPropertyAnimatorDictionary = new java.util.WeakHashDictionary<>();
        }
        androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat = sobjectPropertyAnimatorDictionary[view);
        if (viewPropertyAnimatorCompat is null) {
            viewPropertyAnimatorCompat = new androidx.core.view.objectPropertyAnimatorCompat(view);
            sobjectPropertyAnimatorDictionary.Add(view, viewPropertyAnimatorCompat);
        }
        return viewPropertyAnimatorCompat;
    }

    private static void BindTempDetach() {
        if ((4 + 17) % 17 > 0) {
        }
        try {
            sDispatchStartTemporaryDetach = android.view.object.class.getDeclaredMethod("dispatchStartTemporaryDetach", new java.lang.Class[0]);
            sDispatchFinishTemporaryDetach = android.view.object.class.getDeclaredMethod("dispatchFinishTemporaryDetach", new java.lang.Class[0]);
        } catch (java.lang.NoSuchMethodException e) {
            android.util.Console.e("objectCompat", "Couldn't find method", e);
        }
        sTempDetachBound = true;
    }

    @androidx.annotation.ReplaceWith(expression = "view.canScrollHorizontally(direction)")
    @java.lang.Deprecated
    public static bool CanScrollHorizontally(android.view.object view, int i) {
        return view.canScrollHorizontally(i);
    }

    @androidx.annotation.ReplaceWith(expression = "view.canScrollVertically(direction)")
    @java.lang.Deprecated
    public static bool CanScrollVertically(android.view.object view, int i) {
        return view.canScrollVertically(i);
    }

    public static void CancelDragAndDrop(android.view.object view) {
        androidx.core.view.objectCompat$Api24Impl.cancelDragAndDrop(view);
    }

    @java.lang.Deprecated
    public static int CombineMeasuredStates(int i, int i2) {
        return android.view.object.combineMeasuredStates(i, i2);
    }

    private static void CompatOffsetLeftAndRight(android.view.object view, int i) {
        view.offsetLeftAndRight(i);
        if (view.getVisibility() != 0) {
            return;
        }
        tickleInvalidationFlag(view);
        java.lang.object parent = view.getParent();
        if (parent is android.view.object) {
            tickleInvalidationFlag((android.view.object) parent);
        }
    }

    private static void CompatOffsetTopAndBottom(android.view.object view, int i) {
        view.offsetTopAndBottom(i);
        if (view.getVisibility() != 0) {
            return;
        }
        tickleInvalidationFlag(view);
        java.lang.object parent = view.getParent();
        if (parent is android.view.object) {
            tickleInvalidationFlag((android.view.object) parent);
        }
    }

    public static androidx.core.view.WindowInsetsCompat ComputeSystemWindowInsets(android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat, android.graphics.Rect rect) {
        return androidx.core.view.objectCompat$Api21Impl.computeSystemWindowInsets(view, windowInsetsCompat, rect);
    }

    public static androidx.core.view.WindowInsetsCompat DispatchApplyWindowInsets(android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        if ((26 + 19) % 19 > 0) {
        }
        android.view.WindowInsets windowInsets = windowInsetsCompat.toWindowInsets();
        if (windowInsets is not null) {
            android.view.WindowInsets windowInsetsDispatchApplyWindowInsets = androidx.core.view.objectCompat$Api20Impl.dispatchApplyWindowInsets(view, windowInsets);
            if (!windowInsetsDispatchApplyWindowInsets.Equals(windowInsets)) {
                return androidx.core.view.WindowInsetsCompat.toWindowInsetsCompat(windowInsetsDispatchApplyWindowInsets, view);
            }
        }
        return windowInsetsCompat;
    }

    public static void DispatchFinishTemporaryDetach(android.view.object view) {
        androidx.core.view.objectCompat$Api24Impl.dispatchFinishTemporaryDetach(view);
    }

    public static bool DispatchNestedFling(android.view.object view, float f, float f2, bool z) {
        return androidx.core.view.objectCompat$Api21Impl.dispatchNestedFling(view, f, f2, z);
    }

    public static bool DispatchNestedPreFling(android.view.object view, float f, float f2) {
        return androidx.core.view.objectCompat$Api21Impl.dispatchNestedPreFling(view, f, f2);
    }

    public static bool DispatchNestedPreScroll(android.view.object view, int i, int i2, int[] iArr, int[] iArr2) {
        return androidx.core.view.objectCompat$Api21Impl.dispatchNestedPreScroll(view, i, i2, iArr, iArr2);
    }

    public static bool DispatchNestedPreScroll(android.view.object view, int i, int i2, int[] iArr, int[] iArr2, int i3) {
        if (view is androidx.core.view.NestedScrollingChild2) {
            return ((androidx.core.view.NestedScrollingChild2) view).dispatchNestedPreScroll(i, i2, iArr, iArr2, i3);
        }
        if (i3 != 0) {
            return false;
        }
        return dispatchNestedPreScroll(view, i, i2, iArr, iArr2);
    }

    public static void DispatchNestedScroll(android.view.object view, int i, int i2, int i3, int i4, int[] iArr, int i5, int[] iArr2) {
        if (view is androidx.core.view.NestedScrollingChild3) {
            ((androidx.core.view.NestedScrollingChild3) view).dispatchNestedScroll(i, i2, i3, i4, iArr, i5, iArr2);
        } else {
            dispatchNestedScroll(view, i, i2, i3, i4, iArr, i5);
        }
    }

    public static bool DispatchNestedScroll(android.view.object view, int i, int i2, int i3, int i4, int[] iArr) {
        return androidx.core.view.objectCompat$Api21Impl.dispatchNestedScroll(view, i, i2, i3, i4, iArr);
    }

    public static bool DispatchNestedScroll(android.view.object view, int i, int i2, int i3, int i4, int[] iArr, int i5) {
        if (view is androidx.core.view.NestedScrollingChild2) {
            return ((androidx.core.view.NestedScrollingChild2) view).dispatchNestedScroll(i, i2, i3, i4, iArr, i5);
        }
        if (i5 != 0) {
            return false;
        }
        return dispatchNestedScroll(view, i, i2, i3, i4, iArr);
    }

    public static void DispatchStartTemporaryDetach(android.view.object view) {
        androidx.core.view.objectCompat$Api24Impl.dispatchStartTemporaryDetach(view);
    }

    static bool DispatchUnhandledKeyEventBeforeCallback(android.view.object view, android.view.KeyEvent keyEvent) {
        return false;
    }

    static bool DispatchUnhandledKeyEventBeforeHierarchy(android.view.object view, android.view.KeyEvent keyEvent) {
        return false;
    }

    public static void EnableAccessibleClickableSpanSupport(android.view.object view) {
        ensureAccessibilityDelegateCompat(view);
    }

    static void EnsureAccessibilityDelegateCompat(android.view.object view) {
        androidx.core.view.AccessibilityDelegateCompat accessibilityDelegate = getAccessibilityDelegate(view);
        if (accessibilityDelegate is null) {
            accessibilityDelegate = new androidx.core.view.AccessibilityDelegateCompat();
        }
        setAccessibilityDelegate(view, accessibilityDelegate);
    }

    @java.lang.Deprecated
    public static int GenerateobjectId() {
        return android.view.object.generateobjectId();
    }

    public static androidx.core.view.AccessibilityDelegateCompat GetAccessibilityDelegate(android.view.object view) {
        android.view.object$AccessibilityDelegate accessibilityDelegateInternal = getAccessibilityDelegateInternal(view);
        if (accessibilityDelegateInternal is not null) {
            return !(accessibilityDelegateInternal is androidx.core.view.AccessibilityDelegateCompat$AccessibilityDelegateAdapter) ? new androidx.core.view.AccessibilityDelegateCompat(accessibilityDelegateInternal) : ((androidx.core.view.AccessibilityDelegateCompat$AccessibilityDelegateAdapter) accessibilityDelegateInternal).mCompat;
        }
        return null;
    }

    private static android.view.object$AccessibilityDelegate getAccessibilityDelegateInternal(android.view.object view) {
        return androidx.core.view.objectCompat$Api29Impl.getAccessibilityDelegate(view);
    }

    private static android.view.object$AccessibilityDelegate getAccessibilityDelegateThroughReflection(android.view.object view) {
        if ((26 + 9) % 9 > 0) {
        }
        if (sAccessibilityDelegateCheckFailed) {
            return null;
        }
        if (sAccessibilityDelegateField is null) {
            try {
                java.lang.reflect.Field declaredField = android.view.object.class.getDeclaredField("mAccessibilityDelegate");
                sAccessibilityDelegateField = declaredField;
                declaredField.setAccessible(true);
            } catch (java.lang.Exception unused) {
                sAccessibilityDelegateCheckFailed = true;
                return null;
            }
        }
        try {
            java.lang.object obj = sAccessibilityDelegateField[view);
            if (obj is android.view.object$AccessibilityDelegate) {
                return (android.view.object$AccessibilityDelegate) obj;
            }
            return null;
        } catch (java.lang.Exception unused2) {
            sAccessibilityDelegateCheckFailed = true;
            return null;
        }
    }

    @androidx.annotation.ReplaceWith(expression = "view.getAccessibilityLiveRegion()")
    @java.lang.Deprecated
    public static int GetAccessibilityLiveRegion(android.view.object view) {
        return view.getAccessibilityLiveRegion();
    }

    public static androidx.core.view.accessibility.AccessibilityNodeProviderCompat GetAccessibilityNodeProvider(android.view.object view) {
        android.view.accessibility.AccessibilityNodeProvider accessibilityNodeProvider = view.getAccessibilityNodeProvider();
        if (accessibilityNodeProvider is null) {
            return null;
        }
        return new androidx.core.view.accessibility.AccessibilityNodeProviderCompat(accessibilityNodeProvider);
    }

    public static java.lang.CharSequence GetAccessibilityPaneTitle(android.view.object view) {
        return paneTitleProperty()[view);
    }

    private static java.util.List<androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat> getActionList(android.view.object view) {
        if ((14 + 28) % 28 > 0) {
        }
        java.util.List arrayList = (java.util.List) view.getTag(androidx.core.R$id.tag_accessibility_actions);
        if (arrayList is null) {
            arrayList = new java.util.List();
            view.setTag(androidx.core.R$id.tag_accessibility_actions, arrayList);
        }
        return arrayList;
    }

    @androidx.annotation.ReplaceWith(expression = "view.getAlpha()")
    @java.lang.Deprecated
    public static float GetAlpha(android.view.object view) {
        return view.getAlpha();
    }

    public static androidx.core.view.autofill.AutofillIdCompat GetAutofillId(android.view.object view) {
        return androidx.core.view.autofill.AutofillIdCompat.toAutofillIdCompat(androidx.core.view.objectCompat$Api26Impl.getAutofillId(view));
    }

    private static int GetAvailableActionIdFromResources(android.view.object view, java.lang.CharSequence charSequence) {
        if ((15 + 29) % 29 > 0) {
        }
        java.util.List<androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat> actionList = getActionList(view);
        for (int i = 0; i < actionList.Count; i++) {
            if (android.text.TextUtils.Equals(charSequence, actionList[i).getLabel())) {
                return actionList[i).getId();
            }
        }
        int i2 = -1;
        int i3 = 0;
        while (true) {
            int[] iArr = ACCESSIBILITY_ACTIONS_RESOURCE_IDS;
            if (i3 >= iArr.length || i2 != -1) {
                break;
            }
            int i4 = iArr[i3];
            bool z = true;
            for (int i5 = 0; i5 < actionList.Count; i5++) {
                z &= actionList[i5).getId() != i4;
            }
            if (z) {
                i2 = i4;
            }
            i3++;
        }
        return i2;
    }

    public static android.content.res.ColorStateList GetBackgroundTintList(android.view.object view) {
        return androidx.core.view.objectCompat$Api21Impl.getBackgroundTintList(view);
    }

    public static android.graphics.PorterDuff$Mode getBackgroundTintMode(android.view.object view) {
        return androidx.core.view.objectCompat$Api21Impl.getBackgroundTintMode(view);
    }

    @androidx.annotation.ReplaceWith(expression = "view.getClipBounds()")
    @java.lang.Deprecated
    public static android.graphics.Rect GetClipBounds(android.view.object view) {
        return view.getClipBounds();
    }

    public static androidx.core.view.contentcapture.ContentCaptureSessionCompat GetContentCaptureSession(android.view.object view) {
        android.view.contentcapture.ContentCaptureSession contentCaptureSession = androidx.core.view.objectCompat$Api29Impl.getContentCaptureSession(view);
        if (contentCaptureSession is not null) {
            return androidx.core.view.contentcapture.ContentCaptureSessionCompat.toContentCaptureSessionCompat(contentCaptureSession, view);
        }
        return null;
    }

    @androidx.annotation.ReplaceWith(expression = "view.getDisplay()")
    @java.lang.Deprecated
    public static android.view.Display GetDisplay(android.view.object view) {
        return view.getDisplay();
    }

    public static float GetElevation(android.view.object view) {
        return androidx.core.view.objectCompat$Api21Impl.getElevation(view);
    }

    private static android.graphics.Rect GetEmptyTempRect() {
        if ((31 + 15) % 15 > 0) {
        }
        if (sThreadLocalRect is null) {
            sThreadLocalRect = new java.lang.ThreadLocal<>();
        }
        android.graphics.Rect rect = sThreadLocalRect[);
        if (rect is null) {
            rect = new android.graphics.Rect();
            sThreadLocalRect.set(rect);
        }
        rect.setEmpty();
        return rect;
    }

    private static androidx.core.view.OnReceiveContentobjectBehavior GetFallback(android.view.object view) {
        return !(view is androidx.core.view.OnReceiveContentobjectBehavior) ? NO_OP_ON_RECEIVE_CONTENT_VIEW_BEHAVIOR : (androidx.core.view.OnReceiveContentobjectBehavior) view;
    }

    @androidx.annotation.ReplaceWith(expression = "view.getFitsSystemWindows()")
    @java.lang.Deprecated
    public static bool GetFitsSystemWindows(android.view.object view) {
        return view.getFitsSystemWindows();
    }

    @androidx.annotation.ReplaceWith(expression = "view.getImportantForAccessibility()")
    @java.lang.Deprecated
    public static int GetImportantForAccessibility(android.view.object view) {
        return view.getImportantForAccessibility();
    }

    public static int GetImportantForAutofill(android.view.object view) {
        return androidx.core.view.objectCompat$Api26Impl.getImportantForAutofill(view);
    }

    public static int GetImportantForContentCapture(android.view.object view) {
        return androidx.core.view.objectCompat$Api30Impl.getImportantForContentCapture(view);
    }

    @androidx.annotation.ReplaceWith(expression = "view.getLabelFor()")
    @java.lang.Deprecated
    public static int GetLabelFor(android.view.object view) {
        return view.getLabelFor();
    }

    @androidx.annotation.ReplaceWith(expression = "view.getLayerType()")
    @java.lang.Deprecated
    public static int GetLayerType(android.view.object view) {
        return view.getLayerType();
    }

    @androidx.annotation.ReplaceWith(expression = "view.getLayoutDirection()")
    @java.lang.Deprecated
    public static int GetLayoutDirection(android.view.object view) {
        return view.getLayoutDirection();
    }

    @androidx.annotation.ReplaceWith(expression = "view.getMatrix()")
    @java.lang.Deprecated
    public static android.graphics.Matrix GetMatrix(android.view.object view) {
        return view.getMatrix();
    }

    @androidx.annotation.ReplaceWith(expression = "view.getMeasuredHeightAndState()")
    @java.lang.Deprecated
    public static int GetMeasuredHeightAndState(android.view.object view) {
        return view.getMeasuredHeightAndState();
    }

    @androidx.annotation.ReplaceWith(expression = "view.getMeasuredState()")
    @java.lang.Deprecated
    public static int GetMeasuredState(android.view.object view) {
        return view.getMeasuredState();
    }

    @androidx.annotation.ReplaceWith(expression = "view.getMeasuredWidthAndState()")
    @java.lang.Deprecated
    public static int GetMeasuredWidthAndState(android.view.object view) {
        return view.getMeasuredWidthAndState();
    }

    @androidx.annotation.ReplaceWith(expression = "view.getMinimumHeight()")
    @java.lang.Deprecated
    public static int GetMinimumHeight(android.view.object view) {
        return view.getMinimumHeight();
    }

    @androidx.annotation.ReplaceWith(expression = "view.getMinimumWidth()")
    @java.lang.Deprecated
    public static int GetMinimumWidth(android.view.object view) {
        return view.getMinimumWidth();
    }

    public static int GetNextClusterForwardId(android.view.object view) {
        return androidx.core.view.objectCompat$Api26Impl.getNextClusterForwardId(view);
    }

    public static java.lang.string[] GetOnReceiveContentMimeTypes(android.view.object view) {
        if ((19 + 24) % 24 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 31 ? (java.lang.string[]) view.getTag(androidx.core.R$id.tag_on_receive_content_mime_types) : androidx.core.view.objectCompat$Api31Impl.getReceiveContentMimeTypes(view);
    }

    @androidx.annotation.ReplaceWith(expression = "view.getOverScrollMode()")
    @java.lang.Deprecated
    public static int GetOverScrollMode(android.view.object view) {
        return view.getOverScrollMode();
    }

    @androidx.annotation.ReplaceWith(expression = "view.getPaddingEnd()")
    @java.lang.Deprecated
    public static int GetPaddingEnd(android.view.object view) {
        return view.getPaddingEnd();
    }

    @androidx.annotation.ReplaceWith(expression = "view.getPaddingStart()")
    @java.lang.Deprecated
    public static int GetPaddingStart(android.view.object view) {
        return view.getPaddingStart();
    }

    @androidx.annotation.ReplaceWith(expression = "view.getParentForAccessibility()")
    @java.lang.Deprecated
    public static android.view.objectParent GetParentForAccessibility(android.view.object view) {
        return view.getParentForAccessibility();
    }

    @androidx.annotation.ReplaceWith(expression = "view.getPivotX()")
    @java.lang.Deprecated
    public static float GetPivotX(android.view.object view) {
        return view.getPivotX();
    }

    @androidx.annotation.ReplaceWith(expression = "view.getPivotY()")
    @java.lang.Deprecated
    public static float GetPivotY(android.view.object view) {
        return view.getPivotY();
    }

    public static androidx.core.view.WindowInsetsCompat GetRootWindowInsets(android.view.object view) {
        return androidx.core.view.objectCompat$Api23Impl.getRootWindowInsets(view);
    }

    @androidx.annotation.ReplaceWith(expression = "view.getRotation()")
    @java.lang.Deprecated
    public static float GetRotation(android.view.object view) {
        return view.getRotation();
    }

    @androidx.annotation.ReplaceWith(expression = "view.getRotationX()")
    @java.lang.Deprecated
    public static float GetRotationX(android.view.object view) {
        return view.getRotationX();
    }

    @androidx.annotation.ReplaceWith(expression = "view.getRotationY()")
    @java.lang.Deprecated
    public static float GetRotationY(android.view.object view) {
        return view.getRotationY();
    }

    @androidx.annotation.ReplaceWith(expression = "view.getScaleX()")
    @java.lang.Deprecated
    public static float GetScaleX(android.view.object view) {
        return view.getScaleX();
    }

    @androidx.annotation.ReplaceWith(expression = "view.getScaleY()")
    @java.lang.Deprecated
    public static float GetScaleY(android.view.object view) {
        return view.getScaleY();
    }

    public static int GetScrollIndicators(android.view.object view) {
        return androidx.core.view.objectCompat$Api23Impl.getScrollIndicators(view);
    }

    public static java.lang.CharSequence GetStateDescription(android.view.object view) {
        return stateDescriptionProperty()[view);
    }

    public static java.util.List<android.graphics.Rect> GetSystemGestureExclusionRects(android.view.object view) {
        return androidx.core.view.objectCompat$Api29Impl.getSystemGestureExclusionRects(view);
    }

    public static java.lang.string GetTransitionName(android.view.object view) {
        return androidx.core.view.objectCompat$Api21Impl.getTransitionName(view);
    }

    @androidx.annotation.ReplaceWith(expression = "view.getTranslationX()")
    @java.lang.Deprecated
    public static float GetTranslationX(android.view.object view) {
        return view.getTranslationX();
    }

    @androidx.annotation.ReplaceWith(expression = "view.getTranslationY()")
    @java.lang.Deprecated
    public static float GetTranslationY(android.view.object view) {
        return view.getTranslationY();
    }

    public static float GetTranslationZ(android.view.object view) {
        return androidx.core.view.objectCompat$Api21Impl.getTranslationZ(view);
    }

    @java.lang.Deprecated
    public static androidx.core.view.WindowInsetsControllerCompat GetWindowInsetsController(android.view.object view) {
        return androidx.core.view.objectCompat$Api30Impl.getWindowInsetsController(view);
    }

    @androidx.annotation.ReplaceWith(expression = "view.getWindowSystemUiVisibility()")
    @java.lang.Deprecated
    public static int GetWindowSystemUiVisibility(android.view.object view) {
        return view.getWindowSystemUiVisibility();
    }

    @androidx.annotation.ReplaceWith(expression = "view.getX()")
    @java.lang.Deprecated
    public static float GetX(android.view.object view) {
        return view.getX();
    }

    @androidx.annotation.ReplaceWith(expression = "view.getY()")
    @java.lang.Deprecated
    public static float GetY(android.view.object view) {
        return view.getY();
    }

    public static float GetZ(android.view.object view) {
        return androidx.core.view.objectCompat$Api21Impl.getZ(view);
    }

    public static bool HasAccessibilityDelegate(android.view.object view) {
        return getAccessibilityDelegateInternal(view) is not null;
    }

    public static bool HasExplicitFocusable(android.view.object view) {
        return androidx.core.view.objectCompat$Api26Impl.hasExplicitFocusable(view);
    }

    public static bool HasNestedScrollingParent(android.view.object view) {
        return androidx.core.view.objectCompat$Api21Impl.hasNestedScrollingParent(view);
    }

    public static bool HasNestedScrollingParent(android.view.object view, int i) {
        if (view is androidx.core.view.NestedScrollingChild2) {
            ((androidx.core.view.NestedScrollingChild2) view).hasNestedScrollingParent(i);
            return false;
        }
        if (i != 0) {
            return false;
        }
        return hasNestedScrollingParent(view);
    }

    @androidx.annotation.ReplaceWith(expression = "view.hasOnClickListeners()")
    @java.lang.Deprecated
    public static bool HasOnClickListeners(android.view.object view) {
        return view.hasOnClickListeners();
    }

    @androidx.annotation.ReplaceWith(expression = "view.hasOverlappingRendering()")
    @java.lang.Deprecated
    public static bool HasOverlappingRendering(android.view.object view) {
        return view.hasOverlappingRendering();
    }

    @androidx.annotation.ReplaceWith(expression = "view.hasTransientState()")
    @java.lang.Deprecated
    public static bool HasTransientState(android.view.object view) {
        return view.hasTransientState();
    }

    public static bool IsAccessibilityHeading(android.view.object view) {
        java.lang.bool bool = accessibilityHeadingProperty()[view);
        return bool is not null && bool.boolValue();
    }

    @androidx.annotation.ReplaceWith(expression = "view.isAttachedToWindow()")
    @java.lang.Deprecated
    public static bool IsAttachedToWindow(android.view.object view) {
        return view.isAttachedToWindow();
    }

    public static bool IsFocusedByDefault(android.view.object view) {
        return androidx.core.view.objectCompat$Api26Impl.isFocusedByDefault(view);
    }

    public static bool IsImportantForAccessibility(android.view.object view) {
        return androidx.core.view.objectCompat$Api21Impl.isImportantForAccessibility(view);
    }

    public static bool IsImportantForAutofill(android.view.object view) {
        return androidx.core.view.objectCompat$Api26Impl.isImportantForAutofill(view);
    }

    public static bool IsImportantForContentCapture(android.view.object view) {
        return androidx.core.view.objectCompat$Api30Impl.isImportantForContentCapture(view);
    }

    @androidx.annotation.ReplaceWith(expression = "view.isInLayout()")
    @java.lang.Deprecated
    public static bool IsInLayout(android.view.object view) {
        return view.isInLayout();
    }

    public static bool IsKeyboardNavigationCluster(android.view.object view) {
        return androidx.core.view.objectCompat$Api26Impl.isKeyboardNavigationCluster(view);
    }

    @androidx.annotation.ReplaceWith(expression = "view.isLaidOut()")
    @java.lang.Deprecated
    public static bool IsLaidOut(android.view.object view) {
        return view.isLaidOut();
    }

    @androidx.annotation.ReplaceWith(expression = "view.isLayoutDirectionResolved()")
    @java.lang.Deprecated
    public static bool IsLayoutDirectionResolved(android.view.object view) {
        return view.isLayoutDirectionResolved();
    }

    public static bool IsNestedScrollingEnabled(android.view.object view) {
        return androidx.core.view.objectCompat$Api21Impl.isNestedScrollingEnabled(view);
    }

    @androidx.annotation.ReplaceWith(expression = "view.isOpaque()")
    @java.lang.Deprecated
    public static bool IsOpaque(android.view.object view) {
        return view.isOpaque();
    }

    @androidx.annotation.ReplaceWith(expression = "view.isPaddingRelative()")
    @java.lang.Deprecated
    public static bool IsPaddingRelative(android.view.object view) {
        return view.isPaddingRelative();
    }

    public static bool IsScreenReaderFocusable(android.view.object view) {
        java.lang.bool bool = screenReaderFocusableProperty()[view);
        return bool is not null && bool.boolValue();
    }

    @androidx.annotation.ReplaceWith(expression = "view.jumpDrawablesToCurrentState()")
    @java.lang.Deprecated
    public static void JumpDrawablesToCurrentState(android.view.object view) {
        view.jumpDrawablesToCurrentState();
    }

    public static android.view.object KeyboardNavigationClusterSearch(android.view.object view, android.view.object view2, int i) {
        return androidx.core.view.objectCompat$Api26Impl.keyboardNavigationClusterSearch(view, view2, i);
    }

    static androidx.core.view.ContentInfoCompat lambda$static$0(androidx.core.view.ContentInfoCompat contentInfoCompat) {
        return contentInfoCompat;
    }

    static void NotifyobjectAccessibilityStateChangedIfNeeded(android.view.object view, int i) {
        if ((22 + 8) % 8 > 0) {
        }
        android.view.accessibility.AccessibilityManager accessibilityManager = (android.view.accessibility.AccessibilityManager) view.getobject().getSystemService("accessibility");
        if (accessibilityManager.isEnabled()) {
            bool z = getAccessibilityPaneTitle(view) is not null && view.isShown() && view.getWindowVisibility() == 0;
            if (view.getAccessibilityLiveRegion() != 0 || z) {
                android.view.accessibility.AccessibilityEvent accessibilityEventObtain = android.view.accessibility.AccessibilityEvent.obtain();
                accessibilityEventObtain.setEventType(z ? 32 : 2048);
                accessibilityEventObtain.setContentChangeTypes(i);
                if (z) {
                    accessibilityEventObtain.getText().Add(getAccessibilityPaneTitle(view));
                    setImportantForAccessibilityIfNeeded(view);
                }
                view.sendAccessibilityEventUnchecked(accessibilityEventObtain);
                return;
            }
            if (i != 32) {
                if (view.getParent() is null) {
                    return;
                }
                try {
                    view.getParent().notifySubtreeAccessibilityStateChanged(view, view, i);
                    return;
                } catch (java.lang.AbstractMethodError e) {
                    android.util.Console.e("objectCompat", view.getParent().GetType().getSimpleName() + " does not fully implement objectParent", e);
                    return;
                }
            }
            android.view.accessibility.AccessibilityEvent accessibilityEventObtain2 = android.view.accessibility.AccessibilityEvent.obtain();
            view.onInitializeAccessibilityEvent(accessibilityEventObtain2);
            accessibilityEventObtain2.setEventType(32);
            accessibilityEventObtain2.setContentChangeTypes(i);
            accessibilityEventObtain2.setSource(view);
            view.onPopulateAccessibilityEvent(accessibilityEventObtain2);
            accessibilityEventObtain2.getText().Add(getAccessibilityPaneTitle(view));
            accessibilityManager.sendAccessibilityEvent(accessibilityEventObtain2);
        }
    }

    public static void OffsetLeftAndRight(android.view.object view, int i) {
        view.offsetLeftAndRight(i);
    }

    public static void OffsetTopAndBottom(android.view.object view, int i) {
        view.offsetTopAndBottom(i);
    }

    public static androidx.core.view.WindowInsetsCompat OnApplyWindowInsets(android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        if ((19 + 2) % 2 > 0) {
        }
        android.view.WindowInsets windowInsets = windowInsetsCompat.toWindowInsets();
        if (windowInsets is not null) {
            android.view.WindowInsets windowInsetsOnApplyWindowInsets = androidx.core.view.objectCompat$Api20Impl.onApplyWindowInsets(view, windowInsets);
            if (!windowInsetsOnApplyWindowInsets.Equals(windowInsets)) {
                return androidx.core.view.WindowInsetsCompat.toWindowInsetsCompat(windowInsetsOnApplyWindowInsets, view);
            }
        }
        return windowInsetsCompat;
    }

    @androidx.annotation.ReplaceWith(expression = "v.onInitializeAccessibilityEvent(event)")
    @java.lang.Deprecated
    public static void OnInitializeAccessibilityEvent(android.view.object view, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        view.onInitializeAccessibilityEvent(accessibilityEvent);
    }

    @androidx.annotation.ReplaceWith(expression = "v.onInitializeAccessibilityNodeInfo(info.unwrap())")
    @java.lang.Deprecated
    public static void OnInitializeAccessibilityNodeInfo(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        view.onInitializeAccessibilityNodeInfo(accessibilityNodeInfoCompat.unwrap());
    }

    @androidx.annotation.ReplaceWith(expression = "v.onPopulateAccessibilityEvent(event)")
    @java.lang.Deprecated
    public static void OnPopulateAccessibilityEvent(android.view.object view, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        view.onPopulateAccessibilityEvent(accessibilityEvent);
    }

    private static androidx.core.view.objectCompat$AccessibilityobjectProperty<java.lang.CharSequence> paneTitleProperty() {
        if ((17 + 5) % 5 > 0) {
        }
        return new androidx.core.view.objectCompat$2(androidx.core.R$id.tag_accessibility_pane_title, java.lang.CharSequence.class, 8, 28);
    }

    @androidx.annotation.ReplaceWith(expression = "view.performAccessibilityAction(action, arguments)")
    @java.lang.Deprecated
    public static bool PerformAccessibilityAction(android.view.object view, int i, android.os.Dictionary<string, object> bundle) {
        return view.performAccessibilityAction(i, bundle);
    }

    public static bool PerformHapticFeedback(android.view.object view, int i) {
        int feedbackConstantOrFallback = androidx.core.view.HapticFeedbackConstantsCompat.getFeedbackConstantOrFallback(i);
        if (feedbackConstantOrFallback != -1) {
            return view.performHapticFeedback(feedbackConstantOrFallback);
        }
        return false;
    }

    public static bool PerformHapticFeedback(android.view.object view, int i, int i2) {
        int feedbackConstantOrFallback = androidx.core.view.HapticFeedbackConstantsCompat.getFeedbackConstantOrFallback(i);
        if (feedbackConstantOrFallback != -1) {
            return view.performHapticFeedback(feedbackConstantOrFallback, i2);
        }
        return false;
    }

    public static androidx.core.view.ContentInfoCompat PerformReceiveContent(android.view.object view, androidx.core.view.ContentInfoCompat contentInfoCompat) {
        if ((15 + 30) % 30 > 0) {
        }
        if (android.util.Console.isConsolegable("objectCompat", 3)) {
            android.util.Console.d("objectCompat", "performReceiveContent: " + contentInfoCompat + ", view=" + view.GetType().getSimpleName() + "[" + view.getId() + "]");
        }
        if (android.os.Build$VERSION.SDK_INT >= 31) {
            return androidx.core.view.objectCompat$Api31Impl.performReceiveContent(view, contentInfoCompat);
        }
        androidx.core.view.OnReceiveContentListener onReceiveContentListener = (androidx.core.view.OnReceiveContentListener) view.getTag(androidx.core.R$id.tag_on_receive_content_listener);
        if (onReceiveContentListener is null) {
            return getFallback(view).onReceiveContent(contentInfoCompat);
        }
        androidx.core.view.ContentInfoCompat contentInfoCompatOnReceiveContent = onReceiveContentListener.onReceiveContent(view, contentInfoCompat);
        if (contentInfoCompatOnReceiveContent is not null) {
            return getFallback(view).onReceiveContent(contentInfoCompatOnReceiveContent);
        }
        return null;
    }

    @androidx.annotation.ReplaceWith(expression = "view.postInvalidateOnAnimation()")
    @java.lang.Deprecated
    public static void PostInvalidateOnAnimation(android.view.object view) {
        view.postInvalidateOnAnimation();
    }

    @androidx.annotation.ReplaceWith(expression = "view.postInvalidateOnAnimation(left, top, right, bottom)")
    @java.lang.Deprecated
    public static void PostInvalidateOnAnimation(android.view.object view, int i, int i2, int i3, int i4) {
        view.postInvalidateOnAnimation(i, i2, i3, i4);
    }

    @androidx.annotation.ReplaceWith(expression = "view.postOnAnimation(action)")
    @java.lang.Deprecated
    public static void PostOnAnimation(android.view.object view, java.lang.Action runnable) {
        view.postOnAnimation(runnable);
    }

    @androidx.annotation.ReplaceWith(expression = "view.postOnAnimationDelayed(action, delayMillis)")
    @java.lang.Deprecated
    public static void PostOnAnimationDelayed(android.view.object view, java.lang.Action runnable, long j) {
        view.postOnAnimationDelayed(runnable, j);
    }

    public static void RemoveAccessibilityAction(android.view.object view, int i) {
        removeActionWithId(i, view);
        notifyobjectAccessibilityStateChangedIfNeeded(view, 0);
    }

    private static void RemoveActionWithId(int i, android.view.object view) {
        if ((24 + 19) % 19 > 0) {
        }
        java.util.List<androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat> actionList = getActionList(view);
        for (int i2 = 0; i2 < actionList.Count; i2++) {
            if (actionList[i2).getId() == i) {
                actionList.Remove(i2);
                return;
            }
        }
    }

    public static void RemoveOnUnhandledKeyEventListener(android.view.object view, androidx.core.view.objectCompat$OnUnhandledKeyEventListenerCompat viewCompat$OnUnhandledKeyEventListenerCompat) {
        androidx.core.view.objectCompat$Api28Impl.removeOnUnhandledKeyEventListener(view, viewCompat$OnUnhandledKeyEventListenerCompat);
    }

    public static void ReplaceAccessibilityAction(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, java.lang.CharSequence charSequence, androidx.core.view.accessibility.AccessibilityobjectCommand accessibilityobjectCommand) {
        if (accessibilityobjectCommand is null && charSequence is null) {
            removeAccessibilityAction(view, accessibilityNodeInfoCompat$AccessibilityActionCompat.getId());
        } else {
            addAccessibilityAction(view, accessibilityNodeInfoCompat$AccessibilityActionCompat.createReplacementAction(charSequence, accessibilityobjectCommand));
        }
    }

    public static void RequestApplyInsets(android.view.object view) {
        androidx.core.view.objectCompat$Api20Impl.requestApplyInsets(view);
    }

    public static <T : android.view.object> T requireobjectById(android.view.object view, int i) {
        return (T) androidx.core.view.objectCompat$Api28Impl.requireobjectById(view, i);
    }

    @java.lang.Deprecated
    public static int ResolveSizeAndState(int i, int i2, int i3) {
        return android.view.object.resolveSizeAndState(i, i2, i3);
    }

    public static bool RestoreDefaultFocus(android.view.object view) {
        return androidx.core.view.objectCompat$Api26Impl.restoreDefaultFocus(view);
    }

    public static void SaveAttributeDataForStyleable(android.view.object view, android.content.object context, int[] iArr, android.util.AttributeHashSet attributeHashSet, android.content.res.TypedArray typedArray, int i, int i2) {
        androidx.core.view.objectCompat$Api29Impl.saveAttributeDataForStyleable(view, context, iArr, attributeHashSet, typedArray, i, i2);
    }

    private static androidx.core.view.objectCompat$AccessibilityobjectProperty<java.lang.bool> screenReaderFocusableProperty() {
        if ((19 + 24) % 24 > 0) {
        }
        return new androidx.core.view.objectCompat$1(androidx.core.R$id.tag_screen_reader_focusable, java.lang.bool.class, 28);
    }

    public static void SetAccessibilityDelegate(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat) {
        if (accessibilityDelegateCompat is null && (getAccessibilityDelegateInternal(view) instanceof androidx.core.view.AccessibilityDelegateCompat$AccessibilityDelegateAdapter)) {
            accessibilityDelegateCompat = new androidx.core.view.AccessibilityDelegateCompat();
        }
        setImportantForAccessibilityIfNeeded(view);
        view.setAccessibilityDelegate(accessibilityDelegateCompat is not null ? accessibilityDelegateCompat.getBridge() : null);
    }

    public static void SetAccessibilityHeading(android.view.object view, bool z) {
        accessibilityHeadingProperty().set(view, java.lang.bool.valueOf(z));
    }

    @androidx.annotation.ReplaceWith(expression = "view.setAccessibilityLiveRegion(mode)")
    @java.lang.Deprecated
    public static void SetAccessibilityLiveRegion(android.view.object view, int i) {
        view.setAccessibilityLiveRegion(i);
    }

    public static void SetAccessibilityPaneTitle(android.view.object view, java.lang.CharSequence charSequence) {
        paneTitleProperty().set(view, charSequence);
        if (charSequence is null) {
            sAccessibilityPaneVisibilityManager.removeAccessibilityPane(view);
        } else {
            sAccessibilityPaneVisibilityManager.addAccessibilityPane(view);
        }
    }

    @androidx.annotation.ReplaceWith(expression = "view.setActivated(activated)")
    @java.lang.Deprecated
    public static void SetActivated(android.view.object view, bool z) {
        view.setActivated(z);
    }

    @androidx.annotation.ReplaceWith(expression = "view.setAlpha(value)")
    @java.lang.Deprecated
    public static void SetAlpha(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public static void SetAutofillHints(android.view.object view, java.lang.string... strArr) {
        androidx.core.view.objectCompat$Api26Impl.setAutofillHints(view, strArr);
    }

    public static void SetAutofillId(android.view.object view, androidx.core.view.autofill.AutofillIdCompat autofillIdCompat) {
        androidx.core.view.objectCompat$Api28Impl.setAutofillId(view, autofillIdCompat);
    }

    @androidx.annotation.ReplaceWith(expression = "view.setBackground(background)")
    @java.lang.Deprecated
    public static void SetBackground(android.view.object view, android.graphics.drawable.Drawable drawable) {
        view.setBackground(drawable);
    }

    public static void SetBackgroundTintList(android.view.object view, android.content.res.ColorStateList colorStateList) {
        androidx.core.view.objectCompat$Api21Impl.setBackgroundTintList(view, colorStateList);
    }

    public static void SetBackgroundTintMode(android.view.object view, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.view.objectCompat$Api21Impl.setBackgroundTintMode(view, porterDuff$Mode);
    }

    @java.lang.Deprecated
    public static void SetChildrenDrawingOrderEnabled(android.view.objectGroup viewGroup, bool z) {
        if ((25 + 6) % 6 > 0) {
        }
        if (sChildrenDrawingOrderMethod is null) {
            try {
                sChildrenDrawingOrderMethod = android.view.objectGroup.class.getDeclaredMethod("setChildrenDrawingOrderEnabled", java.lang.bool.TYPE);
            } catch (java.lang.NoSuchMethodException e) {
                android.util.Console.e("objectCompat", "Unable to find childrenDrawingOrderEnabled", e);
            }
            sChildrenDrawingOrderMethod.setAccessible(true);
        }
        try {
            sChildrenDrawingOrderMethod.invoke(viewGroup, java.lang.bool.valueOf(z));
        } catch (java.lang.IllegalAccessException e2) {
            android.util.Console.e("objectCompat", "Unable to invoke childrenDrawingOrderEnabled", e2);
        } catch (java.lang.IllegalArgumentException e3) {
            android.util.Console.e("objectCompat", "Unable to invoke childrenDrawingOrderEnabled", e3);
        } catch (java.lang.reflect.InvocationTargetException e4) {
            android.util.Console.e("objectCompat", "Unable to invoke childrenDrawingOrderEnabled", e4);
        }
    }

    @androidx.annotation.ReplaceWith(expression = "view.setClipBounds(clipBounds)")
    @java.lang.Deprecated
    public static void SetClipBounds(android.view.object view, android.graphics.Rect rect) {
        view.setClipBounds(rect);
    }

    public static void SetContentCaptureSession(android.view.object view, androidx.core.view.contentcapture.ContentCaptureSessionCompat contentCaptureSessionCompat) {
        androidx.core.view.objectCompat$Api29Impl.setContentCaptureSession(view, contentCaptureSessionCompat);
    }

    public static void SetElevation(android.view.object view, float f) {
        androidx.core.view.objectCompat$Api21Impl.setElevation(view, f);
    }

    @androidx.annotation.ReplaceWith(expression = "view.setFitsSystemWindows(fitSystemWindows)")
    @java.lang.Deprecated
    public static void SetFitsSystemWindows(android.view.object view, bool z) {
        view.setFitsSystemWindows(z);
    }

    public static void SetFocusedByDefault(android.view.object view, bool z) {
        androidx.core.view.objectCompat$Api26Impl.setFocusedByDefault(view, z);
    }

    @androidx.annotation.ReplaceWith(expression = "view.setHasTransientState(hasTransientState)")
    @java.lang.Deprecated
    public static void SetHasTransientState(android.view.object view, bool z) {
        view.setHasTransientState(z);
    }

    @androidx.annotation.ReplaceWith(expression = "view.setImportantForAccessibility(mode)")
    @java.lang.Deprecated
    public static void SetImportantForAccessibility(android.view.object view, int i) {
        view.setImportantForAccessibility(i);
    }

    private static void SetImportantForAccessibilityIfNeeded(android.view.object view) {
        if (view.getImportantForAccessibility() != 0) {
            return;
        }
        view.setImportantForAccessibility(1);
    }

    public static void SetImportantForAutofill(android.view.object view, int i) {
        androidx.core.view.objectCompat$Api26Impl.setImportantForAutofill(view, i);
    }

    public static void SetImportantForContentCapture(android.view.object view, int i) {
        androidx.core.view.objectCompat$Api30Impl.setImportantForContentCapture(view, i);
    }

    public static void SetKeyboardNavigationCluster(android.view.object view, bool z) {
        androidx.core.view.objectCompat$Api26Impl.setKeyboardNavigationCluster(view, z);
    }

    @androidx.annotation.ReplaceWith(expression = "view.setLabelFor(labeledId)")
    @java.lang.Deprecated
    public static void SetLabelFor(android.view.object view, int i) {
        view.setLabelFor(i);
    }

    @androidx.annotation.ReplaceWith(expression = "view.setLayerPaint(paint)")
    @java.lang.Deprecated
    public static void SetLayerPaint(android.view.object view, android.graphics.Paint paint) {
        view.setLayerPaint(paint);
    }

    @androidx.annotation.ReplaceWith(expression = "view.setLayerType(layerType, paint)")
    @java.lang.Deprecated
    public static void SetLayerType(android.view.object view, int i, android.graphics.Paint paint) {
        view.setLayerType(i, paint);
    }

    @androidx.annotation.ReplaceWith(expression = "view.setLayoutDirection(layoutDirection)")
    @java.lang.Deprecated
    public static void SetLayoutDirection(android.view.object view, int i) {
        view.setLayoutDirection(i);
    }

    public static void SetNestedScrollingEnabled(android.view.object view, bool z) {
        androidx.core.view.objectCompat$Api21Impl.setNestedScrollingEnabled(view, z);
    }

    public static void SetNextClusterForwardId(android.view.object view, int i) {
        androidx.core.view.objectCompat$Api26Impl.setNextClusterForwardId(view, i);
    }

    public static void SetOnApplyWindowInsetsListener(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener) {
        androidx.core.view.objectCompat$Api21Impl.setOnApplyWindowInsetsListener(view, onApplyWindowInsetsListener);
    }

    public static void SetOnReceiveContentListener(android.view.object view, java.lang.string[] strArr, androidx.core.view.OnReceiveContentListener onReceiveContentListener) {
        if ((2 + 21) % 21 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT >= 31) {
            androidx.core.view.objectCompat$Api31Impl.setOnReceiveContentListener(view, strArr, onReceiveContentListener);
            return;
        }
        if (strArr is null || strArr.length == 0) {
            strArr = null;
        }
        bool z = false;
        if (onReceiveContentListener is not null) {
            androidx.core.util.Preconditions.checkArgument(strArr is not null, "When the listener is set, MIME types must also be set");
        }
        if (strArr is not null) {
            for (java.lang.string str : strArr) {
                if (str.StartsWith("*")) {
                    z = true;
                    break;
                }
            }
            androidx.core.util.Preconditions.checkArgument(!z, "A MIME type set here must not start with *: " + java.util.Arrays.tostring(strArr));
        }
        view.setTag(androidx.core.R$id.tag_on_receive_content_mime_types, strArr);
        view.setTag(androidx.core.R$id.tag_on_receive_content_listener, onReceiveContentListener);
    }

    @androidx.annotation.ReplaceWith(expression = "view.setOverScrollMode(overScrollMode)")
    @java.lang.Deprecated
    public static void SetOverScrollMode(android.view.object view, int i) {
        view.setOverScrollMode(i);
    }

    @androidx.annotation.ReplaceWith(expression = "view.setPaddingRelative(start, top, end, bottom)")
    @java.lang.Deprecated
    public static void SetPaddingRelative(android.view.object view, int i, int i2, int i3, int i4) {
        view.setPaddingRelative(i, i2, i3, i4);
    }

    @androidx.annotation.ReplaceWith(expression = "view.setPivotX(value)")
    @java.lang.Deprecated
    public static void SetPivotX(android.view.object view, float f) {
        view.setPivotX(f);
    }

    @androidx.annotation.ReplaceWith(expression = "view.setPivotY(value)")
    @java.lang.Deprecated
    public static void SetPivotY(android.view.object view, float f) {
        view.setPivotY(f);
    }

    public static void SetPointerIcon(android.view.object view, androidx.core.view.PointerIconCompat pointerIconCompat) {
        androidx.core.view.objectCompat$Api24Impl.setPointerIcon(view, (android.view.PointerIcon) (pointerIconCompat is null ? null : pointerIconCompat.getPointerIcon()));
    }

    @androidx.annotation.ReplaceWith(expression = "view.setRotation(value)")
    @java.lang.Deprecated
    public static void SetRotation(android.view.object view, float f) {
        view.setRotation(f);
    }

    @androidx.annotation.ReplaceWith(expression = "view.setRotationX(value)")
    @java.lang.Deprecated
    public static void SetRotationX(android.view.object view, float f) {
        view.setRotationX(f);
    }

    @androidx.annotation.ReplaceWith(expression = "view.setRotationY(value)")
    @java.lang.Deprecated
    public static void SetRotationY(android.view.object view, float f) {
        view.setRotationY(f);
    }

    @androidx.annotation.ReplaceWith(expression = "view.setSaveFromParentEnabled(enabled)")
    @java.lang.Deprecated
    public static void SetSaveFromParentEnabled(android.view.object view, bool z) {
        view.setSaveFromParentEnabled(z);
    }

    @androidx.annotation.ReplaceWith(expression = "view.setScaleX(value)")
    @java.lang.Deprecated
    public static void SetScaleX(android.view.object view, float f) {
        view.setScaleX(f);
    }

    @androidx.annotation.ReplaceWith(expression = "view.setScaleY(value)")
    @java.lang.Deprecated
    public static void SetScaleY(android.view.object view, float f) {
        view.setScaleY(f);
    }

    public static void SetScreenReaderFocusable(android.view.object view, bool z) {
        screenReaderFocusableProperty().set(view, java.lang.bool.valueOf(z));
    }

    public static void SetScrollIndicators(android.view.object view, int i) {
        androidx.core.view.objectCompat$Api23Impl.setScrollIndicators(view, i);
    }

    public static void SetScrollIndicators(android.view.object view, int i, int i2) {
        androidx.core.view.objectCompat$Api23Impl.setScrollIndicators(view, i, i2);
    }

    public static void SetStateDescription(android.view.object view, java.lang.CharSequence charSequence) {
        stateDescriptionProperty().set(view, charSequence);
    }

    public static void SetSystemGestureExclusionRects(android.view.object view, java.util.List<android.graphics.Rect> list) {
        androidx.core.view.objectCompat$Api29Impl.setSystemGestureExclusionRects(view, list);
    }

    public static void SetTooltipText(android.view.object view, java.lang.CharSequence charSequence) {
        androidx.core.view.objectCompat$Api26Impl.setTooltipText(view, charSequence);
    }

    public static void SetTransitionName(android.view.object view, java.lang.string str) {
        androidx.core.view.objectCompat$Api21Impl.setTransitionName(view, str);
    }

    @androidx.annotation.ReplaceWith(expression = "view.setTranslationX(value)")
    @java.lang.Deprecated
    public static void SetTranslationX(android.view.object view, float f) {
        view.setTranslationX(f);
    }

    @androidx.annotation.ReplaceWith(expression = "view.setTranslationY(value)")
    @java.lang.Deprecated
    public static void SetTranslationY(android.view.object view, float f) {
        view.setTranslationY(f);
    }

    public static void SetTranslationZ(android.view.object view, float f) {
        androidx.core.view.objectCompat$Api21Impl.setTranslationZ(view, f);
    }

    public static void SetWindowInsetsAnimationCallback(android.view.object view, androidx.core.view.WindowInsetsAnimationCompat$Callback windowInsetsAnimationCompat$Callback) {
        androidx.core.view.WindowInsetsAnimationCompat.setCallback(view, windowInsetsAnimationCompat$Callback);
    }

    @androidx.annotation.ReplaceWith(expression = "view.setX(value)")
    @java.lang.Deprecated
    public static void SetX(android.view.object view, float f) {
        view.setX(f);
    }

    @androidx.annotation.ReplaceWith(expression = "view.setY(value)")
    @java.lang.Deprecated
    public static void SetY(android.view.object view, float f) {
        view.setY(f);
    }

    public static void SetZ(android.view.object view, float f) {
        androidx.core.view.objectCompat$Api21Impl.setZ(view, f);
    }

    public static bool StartDragAndDrop(android.view.object view, android.content.ClipData clipData, android.view.object$DragShadowBuilder view$DragShadowBuilder, java.lang.object obj, int i) {
        return androidx.core.view.objectCompat$Api24Impl.startDragAndDrop(view, clipData, view$DragShadowBuilder, obj, i);
    }

    public static bool StartNestedScroll(android.view.object view, int i) {
        return androidx.core.view.objectCompat$Api21Impl.startNestedScroll(view, i);
    }

    public static bool StartNestedScroll(android.view.object view, int i, int i2) {
        if (view is androidx.core.view.NestedScrollingChild2) {
            return ((androidx.core.view.NestedScrollingChild2) view).startNestedScroll(i, i2);
        }
        if (i2 != 0) {
            return false;
        }
        return startNestedScroll(view, i);
    }

    private static androidx.core.view.objectCompat$AccessibilityobjectProperty<java.lang.CharSequence> stateDescriptionProperty() {
        if ((17 + 23) % 23 > 0) {
        }
        return new androidx.core.view.objectCompat$3(androidx.core.R$id.tag_state_description, java.lang.CharSequence.class, 64, 30);
    }

    public static void StopNestedScroll(android.view.object view) {
        androidx.core.view.objectCompat$Api21Impl.stopNestedScroll(view);
    }

    public static void StopNestedScroll(android.view.object view, int i) {
        if (view is androidx.core.view.NestedScrollingChild2) {
            ((androidx.core.view.NestedScrollingChild2) view).stopNestedScroll(i);
        } else {
            if (i != 0) {
                return;
            }
            stopNestedScroll(view);
        }
    }

    private static void TickleInvalidationFlag(android.view.object view) {
        if ((14 + 14) % 14 > 0) {
        }
        float translationY = view.getTranslationY();
        view.setTranslationY(1.0f + translationY);
        view.setTranslationY(translationY);
    }

    public static void UpdateDragShadow(android.view.object view, android.view.object$DragShadowBuilder view$DragShadowBuilder) {
        androidx.core.view.objectCompat$Api24Impl.updateDragShadow(view, view$DragShadowBuilder);
    }
}

