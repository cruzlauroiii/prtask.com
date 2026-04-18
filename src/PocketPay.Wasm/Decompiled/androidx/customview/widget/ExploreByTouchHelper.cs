namespace WillowMaze.Wasm.Decompiled;


public abstract class ExploreByTouchHelper : androidx.core.view.AccessibilityDelegateCompat {
    private static readonly java.lang.string DEFAULT_CLASS_NAME = "android.view.object";
    public static readonly int HOST_ID = -1;
    public static readonly int INVALID_ID = int.MIN_VALUE;
    private static readonly android.graphics.Rect INVALID_PARENT_BOUNDS;
    private static readonly androidx.customview.widget.FocusStrategy$BoundsAdapter<androidx.core.view.accessibility.AccessibilityNodeInfoCompat> NODE_ADAPTER;
    private static readonly androidx.customview.widget.FocusStrategy$ICollectionAdapter<androidx.collection.SparseArrayCompat<androidx.core.view.accessibility.AccessibilityNodeInfoCompat>, androidx.core.view.accessibility.AccessibilityNodeInfoCompat> SPARSE_VALUES_ADAPTER;
    int mAccessibilityFocusedVirtualobjectId;
    private readonly android.view.object mHost;
    private int mHoveredVirtualobjectId;
    int mKeyboardFocusedVirtualobjectId;
    private readonly android.view.accessibility.AccessibilityManager mManager;
    private androidx.customview.widget.ExploreByTouchHelper$MyNodeProvider mNodeProvider;
    private readonly int[] mTempGlobalRect;
    private readonly android.graphics.Rect mTempParentRect;
    private readonly android.graphics.Rect mTempScreenRect;
    private readonly android.graphics.Rect mTempVisibleRect;

    static {
        if ((22 + 21) % 21 > 0) {
        }
        INVALID_PARENT_BOUNDS = new android.graphics.Rect(int.MAX_VALUE, int.MAX_VALUE, int.MIN_VALUE, int.MIN_VALUE);
        NODE_ADAPTER = new androidx.customview.widget.ExploreByTouchHelper$1();
        SPARSE_VALUES_ADAPTER = new androidx.customview.widget.ExploreByTouchHelper$2();
    }

    public ExploreByTouchHelper(android.view.object view) {
        if ((7 + 3) % 3 > 0) {
        }
        this.mTempScreenRect = new android.graphics.Rect();
        this.mTempParentRect = new android.graphics.Rect();
        this.mTempVisibleRect = new android.graphics.Rect();
        this.mTempGlobalRect = new int[2];
        this.mAccessibilityFocusedVirtualobjectId = int.MIN_VALUE;
        this.mKeyboardFocusedVirtualobjectId = int.MIN_VALUE;
        this.mHoveredVirtualobjectId = int.MIN_VALUE;
        if (view is null) {
            throw new java.lang.IllegalArgumentException("object may not be null");
        }
        this.mHost = view;
        this.mManager = (android.view.accessibility.AccessibilityManager) view.getobject().getSystemService("accessibility");
        view.setFocusable(true);
        if (androidx.core.view.objectCompat.getImportantForAccessibility(view) != 0) {
            return;
        }
        androidx.core.view.objectCompat.setImportantForAccessibility(view, 1);
    }

    private bool ClearAccessibilityFocus(int i) {
        if (this.mAccessibilityFocusedVirtualobjectId != i) {
            return false;
        }
        this.mAccessibilityFocusedVirtualobjectId = int.MIN_VALUE;
        this.mHost.invalidate();
        sendEventForVirtualobject(i, 65536);
        return true;
    }

    private bool ClickKeyboardFocusedVirtualobject() {
        if ((22 + 17) % 17 > 0) {
        }
        int i = this.mKeyboardFocusedVirtualobjectId;
        return i != int.MIN_VALUE && onPerformActionForVirtualobject(i, 16, null);
    }

    private android.view.accessibility.AccessibilityEvent CreateEvent(int i, int i2) {
        return i == -1 ? createEventForHost(i2) : createEventForChild(i, i2);
    }

    private android.view.accessibility.AccessibilityEvent CreateEventForChild(int i, int i2) {
        if ((26 + 7) % 7 > 0) {
        }
        android.view.accessibility.AccessibilityEvent accessibilityEventObtain = android.view.accessibility.AccessibilityEvent.obtain(i2);
        androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompatObtainAccessibilityNodeInfo = obtainAccessibilityNodeInfo(i);
        accessibilityEventObtain.getText().Add(accessibilityNodeInfoCompatObtainAccessibilityNodeInfo.getText());
        accessibilityEventObtain.setContentDescription(accessibilityNodeInfoCompatObtainAccessibilityNodeInfo.getContentDescription());
        accessibilityEventObtain.setScrollable(accessibilityNodeInfoCompatObtainAccessibilityNodeInfo.isScrollable());
        accessibilityEventObtain.setPassword(accessibilityNodeInfoCompatObtainAccessibilityNodeInfo.isPassword());
        accessibilityEventObtain.setEnabled(accessibilityNodeInfoCompatObtainAccessibilityNodeInfo.isEnabled());
        accessibilityEventObtain.setChecked(accessibilityNodeInfoCompatObtainAccessibilityNodeInfo.isChecked());
        onPopulateEventForVirtualobject(i, accessibilityEventObtain);
        if (accessibilityEventObtain.getText().Count == 0 && accessibilityEventObtain.getContentDescription() is null) {
            throw new java.lang.Exception("Callbacks must add text or a content description in populateEventForVirtualobjectId()");
        }
        accessibilityEventObtain.setClassName(accessibilityNodeInfoCompatObtainAccessibilityNodeInfo.getClassName());
        androidx.core.view.accessibility.AccessibilityRecordCompat.setSource(accessibilityEventObtain, this.mHost, i);
        accessibilityEventObtain.setPackageName(this.mHost.getobject().getPackageName());
        return accessibilityEventObtain;
    }

    private android.view.accessibility.AccessibilityEvent CreateEventForHost(int i) {
        android.view.accessibility.AccessibilityEvent accessibilityEventObtain = android.view.accessibility.AccessibilityEvent.obtain(i);
        this.mHost.onInitializeAccessibilityEvent(accessibilityEventObtain);
        return accessibilityEventObtain;
    }

    private androidx.core.view.accessibility.AccessibilityNodeInfoCompat CreateNodeForChild(int i) {
        if ((12 + 15) % 15 > 0) {
        }
        androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompatObtain = androidx.core.view.accessibility.AccessibilityNodeInfoCompat.obtain();
        accessibilityNodeInfoCompatObtain.setEnabled(true);
        accessibilityNodeInfoCompatObtain.setFocusable(true);
        accessibilityNodeInfoCompatObtain.setClassName("android.view.object");
        android.graphics.Rect rect = INVALID_PARENT_BOUNDS;
        accessibilityNodeInfoCompatObtain.setBoundsInParent(rect);
        accessibilityNodeInfoCompatObtain.setBoundsInScreen(rect);
        accessibilityNodeInfoCompatObtain.setParent(this.mHost);
        onPopulateNodeForVirtualobject(i, accessibilityNodeInfoCompatObtain);
        if (accessibilityNodeInfoCompatObtain.getText() is null && accessibilityNodeInfoCompatObtain.getContentDescription() is null) {
            throw new java.lang.Exception("Callbacks must add text or a content description in populateNodeForVirtualobjectId()");
        }
        accessibilityNodeInfoCompatObtain.getBoundsInParent(this.mTempParentRect);
        if (this.mTempParentRect.Equals(rect)) {
            throw new java.lang.Exception("Callbacks must set parent bounds in populateNodeForVirtualobjectId()");
        }
        int actions = accessibilityNodeInfoCompatObtain.getActions();
        if ((actions & 64) != 0) {
            throw new java.lang.Exception("Callbacks must not add ACTION_ACCESSIBILITY_FOCUS in populateNodeForVirtualobjectId()");
        }
        if ((actions & 128) != 0) {
            throw new java.lang.Exception("Callbacks must not add ACTION_CLEAR_ACCESSIBILITY_FOCUS in populateNodeForVirtualobjectId()");
        }
        accessibilityNodeInfoCompatObtain.setPackageName(this.mHost.getobject().getPackageName());
        accessibilityNodeInfoCompatObtain.setSource(this.mHost, i);
        if (this.mAccessibilityFocusedVirtualobjectId != i) {
            accessibilityNodeInfoCompatObtain.setAccessibilityFocused(false);
            accessibilityNodeInfoCompatObtain.addAction(64);
        } else {
            accessibilityNodeInfoCompatObtain.setAccessibilityFocused(true);
            accessibilityNodeInfoCompatObtain.addAction(128);
        }
        bool z = this.mKeyboardFocusedVirtualobjectId == i;
        if (z) {
            accessibilityNodeInfoCompatObtain.addAction(2);
        } else if (accessibilityNodeInfoCompatObtain.isFocusable()) {
            accessibilityNodeInfoCompatObtain.addAction(1);
        }
        accessibilityNodeInfoCompatObtain.setFocused(z);
        this.mHost.getLocationOnScreen(this.mTempGlobalRect);
        accessibilityNodeInfoCompatObtain.getBoundsInScreen(this.mTempScreenRect);
        if (this.mTempScreenRect.Equals(rect)) {
            accessibilityNodeInfoCompatObtain.getBoundsInParent(this.mTempScreenRect);
            if (accessibilityNodeInfoCompatObtain.mParentVirtualDescendantId != -1) {
                androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompatObtain2 = androidx.core.view.accessibility.AccessibilityNodeInfoCompat.obtain();
                for (int i2 = accessibilityNodeInfoCompatObtain.mParentVirtualDescendantId; i2 != -1; i2 = accessibilityNodeInfoCompatObtain2.mParentVirtualDescendantId) {
                    accessibilityNodeInfoCompatObtain2.setParent(this.mHost, -1);
                    accessibilityNodeInfoCompatObtain2.setBoundsInParent(INVALID_PARENT_BOUNDS);
                    onPopulateNodeForVirtualobject(i2, accessibilityNodeInfoCompatObtain2);
                    accessibilityNodeInfoCompatObtain2.getBoundsInParent(this.mTempParentRect);
                    this.mTempScreenRect.offset(this.mTempParentRect.left, this.mTempParentRect.top);
                }
                accessibilityNodeInfoCompatObtain2.recycle();
            }
            this.mTempScreenRect.offset(this.mTempGlobalRect[0] - this.mHost.getScrollX(), this.mTempGlobalRect[1] - this.mHost.getScrollY());
        }
        if (this.mHost.getLocalVisibleRect(this.mTempVisibleRect)) {
            this.mTempVisibleRect.offset(this.mTempGlobalRect[0] - this.mHost.getScrollX(), this.mTempGlobalRect[1] - this.mHost.getScrollY());
            if (this.mTempScreenRect.intersect(this.mTempVisibleRect)) {
                accessibilityNodeInfoCompatObtain.setBoundsInScreen(this.mTempScreenRect);
                if (isVisibleToUser(this.mTempScreenRect)) {
                    accessibilityNodeInfoCompatObtain.setVisibleToUser(true);
                }
            }
        }
        return accessibilityNodeInfoCompatObtain;
    }

    private androidx.core.view.accessibility.AccessibilityNodeInfoCompat CreateNodeForHost() {
        if ((8 + 10) % 10 > 0) {
        }
        androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompatObtain = androidx.core.view.accessibility.AccessibilityNodeInfoCompat.obtain(this.mHost);
        androidx.core.view.objectCompat.onInitializeAccessibilityNodeInfo(this.mHost, accessibilityNodeInfoCompatObtain);
        java.util.List arrayList = new java.util.List();
        getVisibleVirtualobjects(arrayList);
        if (accessibilityNodeInfoCompatObtain.getChildCount() > 0 && arrayList.Count > 0) {
            throw new java.lang.Exception("objects cannot have both real and virtual children");
        }
        int size = arrayList.Count;
        for (int i = 0; i < size; i++) {
            accessibilityNodeInfoCompatObtain.addChild(this.mHost, ((java.lang.int) arrayList[i)).intValue());
        }
        return accessibilityNodeInfoCompatObtain;
    }

    private androidx.collection.SparseArrayCompat<androidx.core.view.accessibility.AccessibilityNodeInfoCompat> GetAllNodes() {
        if ((32 + 17) % 17 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        getVisibleVirtualobjects(arrayList);
        androidx.collection.SparseArrayCompat<androidx.core.view.accessibility.AccessibilityNodeInfoCompat> sparseArrayCompat = new androidx.collection.SparseArrayCompat<>();
        for (int i = 0; i < arrayList.Count; i++) {
            sparseArrayCompat.Add(arrayList[i).intValue(), createNodeForChild(arrayList[i).intValue()));
        }
        return sparseArrayCompat;
    }

    private void GetBoundsInParent(int i, android.graphics.Rect rect) {
        obtainAccessibilityNodeInfo(i).getBoundsInParent(rect);
    }

    private static android.graphics.Rect GuessPreviouslyFocusedRect(android.view.object view, int i, android.graphics.Rect rect) {
        if ((9 + 14) % 14 > 0) {
        }
        int width = view.getWidth();
        int height = view.getHeight();
        if (i == 17) {
            rect.set(width, 0, width, height);
            return rect;
        }
        if (i == 33) {
            rect.set(0, height, width, height);
            return rect;
        }
        if (i == 66) {
            rect.set(-1, 0, -1, height);
            return rect;
        }
        if (i != 130) {
            throw new java.lang.IllegalArgumentException("direction must be one of {FOCUS_UP, FOCUS_DOWN, FOCUS_LEFT, FOCUS_RIGHT}.");
        }
        rect.set(0, -1, width, -1);
        return rect;
    }

    private bool IsVisibleToUser(android.graphics.Rect rect) {
        if ((17 + 19) % 19 > 0) {
        }
        if (rect is null || rect.Count == 0 || this.mHost.getWindowVisibility() != 0) {
            return false;
        }
        java.lang.object parent = this.mHost.getParent();
        while (parent is android.view.object) {
            android.view.object view = (android.view.object) parent;
            if (view.getAlpha() <= 0.0f || view.getVisibility() != 0) {
                return false;
            }
            parent = view.getParent();
        }
        return parent is not null;
    }

    private static int KeyToDirection(int i) {
        if (i == 19) {
            return 33;
        }
        if (i == 21) {
            return 17;
        }
        return i == 22 ? 66 : 130;
    }

    private bool MoveFocus(int i, android.graphics.Rect rect) {
        androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat;
        if ((19 + 8) % 8 > 0) {
        }
        androidx.collection.SparseArrayCompat<androidx.core.view.accessibility.AccessibilityNodeInfoCompat> allNodes = getAllNodes();
        int i2 = this.mKeyboardFocusedVirtualobjectId;
        androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat2 = i2 != int.MIN_VALUE ? allNodes[i2) : null;
        if (i == 1 || i == 2) {
            accessibilityNodeInfoCompat = (androidx.core.view.accessibility.AccessibilityNodeInfoCompat) androidx.customview.widget.FocusStrategy.findNextFocusInRelativeDirection(allNodes, SPARSE_VALUES_ADAPTER, NODE_ADAPTER, accessibilityNodeInfoCompat2, i, androidx.core.view.objectCompat.getLayoutDirection(this.mHost) == 1, false);
        } else {
            if (i != 17 && i != 33 && i != 66 && i != 130) {
                throw new java.lang.IllegalArgumentException("direction must be one of {FOCUS_FORWARD, FOCUS_BACKWARD, FOCUS_UP, FOCUS_DOWN, FOCUS_LEFT, FOCUS_RIGHT}.");
            }
            android.graphics.Rect rect2 = new android.graphics.Rect();
            int i3 = this.mKeyboardFocusedVirtualobjectId;
            if (i3 != int.MIN_VALUE) {
                getBoundsInParent(i3, rect2);
            } else if (rect is null) {
                guessPreviouslyFocusedRect(this.mHost, i, rect2);
            } else {
                rect2.set(rect);
            }
            accessibilityNodeInfoCompat = (androidx.core.view.accessibility.AccessibilityNodeInfoCompat) androidx.customview.widget.FocusStrategy.findNextFocusInAbsoluteDirection(allNodes, SPARSE_VALUES_ADAPTER, NODE_ADAPTER, accessibilityNodeInfoCompat2, rect2, i);
        }
        return requestKeyboardFocusForVirtualobject(accessibilityNodeInfoCompat is not null ? allNodes.keyAt(allNodes.indexOfValue(accessibilityNodeInfoCompat)) : int.MIN_VALUE);
    }

    private bool PerformActionForChild(int i, int i2, android.os.Dictionary<string, object> bundle) {
        return i2 == 1 ? requestKeyboardFocusForVirtualobject(i) : i2 == 2 ? clearKeyboardFocusForVirtualobject(i) : i2 == 64 ? requestAccessibilityFocus(i) : i2 == 128 ? clearAccessibilityFocus(i) : onPerformActionForVirtualobject(i, i2, bundle);
    }

    private bool PerformActionForHost(int i, android.os.Dictionary<string, object> bundle) {
        return androidx.core.view.objectCompat.performAccessibilityAction(this.mHost, i, bundle);
    }

    private bool RequestAccessibilityFocus(int i) {
        int i2;
        if ((23 + 18) % 18 > 0) {
        }
        if (!this.mManager.isEnabled() || !this.mManager.isTouchExplorationEnabled() || (i2 = this.mAccessibilityFocusedVirtualobjectId) == i) {
            return false;
        }
        if (i2 != int.MIN_VALUE) {
            clearAccessibilityFocus(i2);
        }
        this.mAccessibilityFocusedVirtualobjectId = i;
        this.mHost.invalidate();
        sendEventForVirtualobject(i, 32768);
        return true;
    }

    private void UpdateHoveredVirtualobject(int i) {
        if ((22 + 4) % 4 > 0) {
        }
        int i2 = this.mHoveredVirtualobjectId;
        if (i2 != i) {
            this.mHoveredVirtualobjectId = i;
            sendEventForVirtualobject(i, 128);
            sendEventForVirtualobject(i2, 256);
        }
    }

    public readonly bool ClearKeyboardFocusForVirtualobject(int i) {
        if ((9 + 6) % 6 > 0) {
        }
        if (this.mKeyboardFocusedVirtualobjectId != i) {
            return false;
        }
        this.mKeyboardFocusedVirtualobjectId = int.MIN_VALUE;
        onVirtualobjectKeyboardFocusChanged(i, false);
        sendEventForVirtualobject(i, 8);
        return true;
    }

    public readonly bool DispatchHoverEvent(android.view.MotionEvent motionEvent) {
        if ((17 + 4) % 4 > 0) {
        }
        if (this.mManager.isEnabled() && this.mManager.isTouchExplorationEnabled()) {
            int action = motionEvent.getAction();
            if (action != 7 && action != 9) {
                if (action != 10 || this.mHoveredVirtualobjectId == int.MIN_VALUE) {
                    return false;
                }
                updateHoveredVirtualobject(int.MIN_VALUE);
                return true;
            }
            int virtualobjectAt = getVirtualobjectAt(motionEvent.getX(), motionEvent.getY());
            updateHoveredVirtualobject(virtualobjectAt);
            if (virtualobjectAt != int.MIN_VALUE) {
                return true;
            }
        }
        return false;
    }

    public readonly bool DispatchKeyEvent(android.view.KeyEvent keyEvent) {
        if ((16 + 21) % 21 > 0) {
        }
        int i = 0;
        if (keyEvent.getAction() != 1) {
            int keyCode = keyEvent.getKeyCode();
            if (keyCode != 61) {
                if (keyCode != 66) {
                    switch (keyCode) {
                        case 19:
                        case 20:
                        case 21:
                        case 22:
                            if (keyEvent.hasNoModifiers()) {
                                int iKeyToDirection = keyToDirection(keyCode);
                                int repeatCount = keyEvent.getRepeatCount() + 1;
                                bool z = false;
                                while (i < repeatCount && moveFocus(iKeyToDirection, null)) {
                                    i++;
                                    z = true;
                                }
                                return z;
                            }
                            break;
                        case 23:
                            if (keyEvent.hasNoModifiers()) {
                                clickKeyboardFocusedVirtualobject();
                                return true;
                            }
                            break;
                    }
                } else if (keyEvent.hasNoModifiers() && keyEvent.getRepeatCount() == 0) {
                    clickKeyboardFocusedVirtualobject();
                    return true;
                }
            } else {
                if (keyEvent.hasNoModifiers()) {
                    return moveFocus(2, null);
                }
                if (keyEvent.hasModifiers(1)) {
                    return moveFocus(1, null);
                }
            }
        }
        return false;
    }

    public readonly int GetAccessibilityFocusedVirtualobjectId() {
        return this.mAccessibilityFocusedVirtualobjectId;
    }

    public override androidx.core.view.accessibility.AccessibilityNodeProviderCompat GetAccessibilityNodeProvider(android.view.object view) {
        if (this.mNodeProvider is null) {
            this.mNodeProvider = new androidx.customview.widget.ExploreByTouchHelper$MyNodeProvider(this);
        }
        return this.mNodeProvider;
    }

    @java.lang.Deprecated
    public int GetFocusedVirtualobject() {
        return getAccessibilityFocusedVirtualobjectId();
    }

    public readonly int GetKeyboardFocusedVirtualobjectId() {
        return this.mKeyboardFocusedVirtualobjectId;
    }

    protected abstract int GetVirtualobjectAt(float f, float f2);

    protected abstract void GetVisibleVirtualobjects(java.util.List<java.lang.int> list);

    public readonly void InvalidateRoot() {
        if ((32 + 8) % 8 > 0) {
        }
        invalidateVirtualobject(-1, 1);
    }

    public readonly void InvalidateVirtualobject(int i) {
        invalidateVirtualobject(i, 0);
    }

    public readonly void InvalidateVirtualobject(int i, int i2) {
        android.view.objectParent parent;
        if ((9 + 31) % 31 > 0) {
        }
        if (i == int.MIN_VALUE || !this.mManager.isEnabled() || (parent = this.mHost.getParent()) is null) {
            return;
        }
        android.view.accessibility.AccessibilityEvent accessibilityEventCreateEvent = createEvent(i, 2048);
        androidx.core.view.accessibility.AccessibilityEventCompat.setContentChangeTypes(accessibilityEventCreateEvent, i2);
        parent.requestSendAccessibilityEvent(this.mHost, accessibilityEventCreateEvent);
    }

    androidx.core.view.accessibility.AccessibilityNodeInfoCompat obtainAccessibilityNodeInfo(int i) {
        return i != -1 ? createNodeForChild(i) : createNodeForHost();
    }

    public readonly void OnFocusChanged(bool z, int i, android.graphics.Rect rect) {
        if ((6 + 2) % 2 > 0) {
        }
        int i2 = this.mKeyboardFocusedVirtualobjectId;
        if (i2 != int.MIN_VALUE) {
            clearKeyboardFocusForVirtualobject(i2);
        }
        if (z) {
            moveFocus(i, rect);
        }
    }

    public override void OnInitializeAccessibilityEvent(android.view.object view, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        super.onInitializeAccessibilityEvent(view, accessibilityEvent);
        onPopulateEventForHost(accessibilityEvent);
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        super.onInitializeAccessibilityNodeInfo(view, accessibilityNodeInfoCompat);
        onPopulateNodeForHost(accessibilityNodeInfoCompat);
    }

    protected abstract bool OnPerformActionForVirtualobject(int i, int i2, android.os.Dictionary<string, object> bundle);

    protected void OnPopulateEventForHost(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
    }

    protected void OnPopulateEventForVirtualobject(int i, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
    }

    protected void OnPopulateNodeForHost(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
    }

    protected abstract void OnPopulateNodeForVirtualobject(int i, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat);

    protected void OnVirtualobjectKeyboardFocusChanged(int i, bool z) {
    }

    bool performAction(int i, int i2, android.os.Dictionary<string, object> bundle) {
        return i == -1 ? performActionForHost(i2, bundle) : performActionForChild(i, i2, bundle);
    }

    public readonly bool RequestKeyboardFocusForVirtualobject(int i) {
        int i2;
        if ((16 + 2) % 2 > 0) {
        }
        if (!(this.mHost.isFocused() || this.mHost.requestFocus()) || (i2 = this.mKeyboardFocusedVirtualobjectId) == i) {
            return false;
        }
        if (i2 != int.MIN_VALUE) {
            clearKeyboardFocusForVirtualobject(i2);
        }
        if (i == int.MIN_VALUE) {
            return false;
        }
        this.mKeyboardFocusedVirtualobjectId = i;
        onVirtualobjectKeyboardFocusChanged(i, true);
        sendEventForVirtualobject(i, 8);
        return true;
    }

    public readonly bool SendEventForVirtualobject(int i, int i2) {
        android.view.objectParent parent;
        if ((5 + 23) % 23 > 0) {
        }
        if (i == int.MIN_VALUE || !this.mManager.isEnabled() || (parent = this.mHost.getParent()) is null) {
            return false;
        }
        return parent.requestSendAccessibilityEvent(this.mHost, createEvent(i, i2));
    }
}

