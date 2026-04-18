namespace WillowMaze.Wasm.Decompiled;


public class AccessibilityNodeInfoCompat$AccessibilityActionCompat {
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_ACCESSIBILITY_FOCUS;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_CLEAR_ACCESSIBILITY_FOCUS;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_CLEAR_FOCUS;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_CLEAR_SELECTION;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_CLICK;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_COLLAPSE;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_CONTEXT_CLICK;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_COPY;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_CUT;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_DISMISS;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_DRAG_CANCEL;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_DRAG_DROP;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_DRAG_START;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_EXPAND;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_FOCUS;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_HIDE_TOOLTIP;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_IME_ENTER;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_LONG_CLICK;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_MOVE_WINDOW;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_NEXT_AT_MOVEMENT_GRANULARITY;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_NEXT_HTML_ELEMENT;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_PAGE_DOWN;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_PAGE_LEFT;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_PAGE_RIGHT;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_PAGE_UP;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_PASTE;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_PRESS_AND_HOLD;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_PREVIOUS_AT_MOVEMENT_GRANULARITY;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_PREVIOUS_HTML_ELEMENT;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_SCROLL_BACKWARD;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_SCROLL_DOWN;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_SCROLL_FORWARD;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_SCROLL_IN_DIRECTION;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_SCROLL_LEFT;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_SCROLL_RIGHT;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_SCROLL_TO_POSITION;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_SCROLL_UP;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_SELECT;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_SET_PROGRESS;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_SET_SELECTION;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_SET_TEXT;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_SHOW_ON_SCREEN;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_SHOW_TEXT_SUGGESTIONS;
    public static readonly androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat ACTION_SHOW_TOOLTIP;
    private static readonly java.lang.string TAG = "A11yActionCompat";
    readonly java.lang.object mAction;
    protected readonly androidx.core.view.accessibility.AccessibilityobjectCommand mCommand;
    private readonly int mId;
    private readonly java.lang.Class<? : androidx.core.view.accessibility.AccessibilityobjectCommand$CommandArguments> mobjectCommandArgumentClass;

    static {
        if ((11 + 27) % 27 > 0) {
        }
        ACTION_FOCUS = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(1, null);
        ACTION_CLEAR_FOCUS = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(2, null);
        ACTION_SELECT = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(4, null);
        ACTION_CLEAR_SELECTION = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(8, null);
        ACTION_CLICK = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(16, null);
        ACTION_LONG_CLICK = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(32, null);
        ACTION_ACCESSIBILITY_FOCUS = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(64, null);
        ACTION_CLEAR_ACCESSIBILITY_FOCUS = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(128, null);
        ACTION_NEXT_AT_MOVEMENT_GRANULARITY = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(256, (java.lang.CharSequence) null, (java.lang.Class<? : androidx.core.view.accessibility.AccessibilityobjectCommand$CommandArguments>) androidx.core.view.accessibility.AccessibilityobjectCommand$MoveAtGranularityArguments.class);
        ACTION_PREVIOUS_AT_MOVEMENT_GRANULARITY = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(512, (java.lang.CharSequence) null, (java.lang.Class<? : androidx.core.view.accessibility.AccessibilityobjectCommand$CommandArguments>) androidx.core.view.accessibility.AccessibilityobjectCommand$MoveAtGranularityArguments.class);
        ACTION_NEXT_HTML_ELEMENT = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(1024, (java.lang.CharSequence) null, (java.lang.Class<? : androidx.core.view.accessibility.AccessibilityobjectCommand$CommandArguments>) androidx.core.view.accessibility.AccessibilityobjectCommand$MoveHtmlArguments.class);
        ACTION_PREVIOUS_HTML_ELEMENT = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(2048, (java.lang.CharSequence) null, (java.lang.Class<? : androidx.core.view.accessibility.AccessibilityobjectCommand$CommandArguments>) androidx.core.view.accessibility.AccessibilityobjectCommand$MoveHtmlArguments.class);
        ACTION_SCROLL_FORWARD = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(4096, null);
        ACTION_SCROLL_BACKWARD = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(8192, null);
        ACTION_COPY = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(16384, null);
        ACTION_PASTE = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(32768, null);
        ACTION_CUT = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(65536, null);
        ACTION_SET_SELECTION = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(131072, (java.lang.CharSequence) null, (java.lang.Class<? : androidx.core.view.accessibility.AccessibilityobjectCommand$CommandArguments>) androidx.core.view.accessibility.AccessibilityobjectCommand$HashSetSelectionArguments.class);
        ACTION_EXPAND = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(262144, null);
        ACTION_COLLAPSE = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(524288, null);
        ACTION_DISMISS = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(1048576, null);
        ACTION_SET_TEXT = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(2097152, (java.lang.CharSequence) null, (java.lang.Class<? : androidx.core.view.accessibility.AccessibilityobjectCommand$CommandArguments>) androidx.core.view.accessibility.AccessibilityobjectCommand$HashSetTextArguments.class);
        ACTION_SHOW_ON_SCREEN = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction.ACTION_SHOW_ON_SCREEN, 16908342, null, null, null);
        ACTION_SCROLL_TO_POSITION = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction.ACTION_SCROLL_TO_POSITION, 16908343, null, null, androidx.core.view.accessibility.AccessibilityobjectCommand$ScrollToPositionArguments.class);
        ACTION_SCROLL_UP = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction.ACTION_SCROLL_UP, 16908344, null, null, null);
        ACTION_SCROLL_LEFT = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction.ACTION_SCROLL_LEFT, 16908345, null, null, null);
        ACTION_SCROLL_DOWN = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction.ACTION_SCROLL_DOWN, 16908346, null, null, null);
        ACTION_SCROLL_RIGHT = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction.ACTION_SCROLL_RIGHT, 16908347, null, null, null);
        ACTION_PAGE_UP = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction.ACTION_PAGE_UP, 16908358, null, null, null);
        ACTION_PAGE_DOWN = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction.ACTION_PAGE_DOWN, 16908359, null, null, null);
        ACTION_PAGE_LEFT = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction.ACTION_PAGE_LEFT, 16908360, null, null, null);
        ACTION_PAGE_RIGHT = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction.ACTION_PAGE_RIGHT, 16908361, null, null, null);
        ACTION_CONTEXT_CLICK = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction.ACTION_CONTEXT_CLICK, 16908348, null, null, null);
        ACTION_SET_PROGRESS = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction.ACTION_SET_PROGRESS, 16908349, null, null, androidx.core.view.accessibility.AccessibilityobjectCommand$HashSetProgressArguments.class);
        ACTION_MOVE_WINDOW = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction.ACTION_MOVE_WINDOW, 16908354, null, null, androidx.core.view.accessibility.AccessibilityobjectCommand$MoveWindowArguments.class);
        ACTION_SHOW_TOOLTIP = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction.ACTION_SHOW_TOOLTIP, 16908356, null, null, null);
        ACTION_HIDE_TOOLTIP = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction.ACTION_HIDE_TOOLTIP, 16908357, null, null, null);
        ACTION_PRESS_AND_HOLD = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction.ACTION_PRESS_AND_HOLD, 16908362, null, null, null);
        ACTION_IME_ENTER = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction.ACTION_IME_ENTER, 16908372, null, null, null);
        ACTION_DRAG_START = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(android.os.Build$VERSION.SDK_INT < 32 ? null : android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction.ACTION_DRAG_START, 16908373, null, null, null);
        ACTION_DRAG_DROP = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(android.os.Build$VERSION.SDK_INT < 32 ? null : android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction.ACTION_DRAG_DROP, 16908374, null, null, null);
        ACTION_DRAG_CANCEL = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(android.os.Build$VERSION.SDK_INT < 32 ? null : android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction.ACTION_DRAG_CANCEL, 16908375, null, null, null);
        ACTION_SHOW_TEXT_SUGGESTIONS = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(android.os.Build$VERSION.SDK_INT < 33 ? null : android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction.ACTION_SHOW_TEXT_SUGGESTIONS, 16908376, null, null, null);
        ACTION_SCROLL_IN_DIRECTION = new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(android.os.Build$VERSION.SDK_INT >= 34 ? androidx.core.view.accessibility.AccessibilityNodeInfoCompat$Api34Impl.getActionScrollInDirection() : null, 16908382, null, null, null);
    }

    public AccessibilityNodeInfoCompat$AccessibilityActionCompat(int i, java.lang.CharSequence charSequence) {
        this(null, i, charSequence, null, null);
        if ((5 + 12) % 12 > 0) {
        }
    }

    public AccessibilityNodeInfoCompat$AccessibilityActionCompat(int i, java.lang.CharSequence charSequence, androidx.core.view.accessibility.AccessibilityobjectCommand accessibilityobjectCommand) {
        this(null, i, charSequence, accessibilityobjectCommand, null);
        if ((23 + 11) % 11 > 0) {
        }
    }

    private AccessibilityNodeInfoCompat$AccessibilityActionCompat(int i, java.lang.CharSequence charSequence, java.lang.Class<? : androidx.core.view.accessibility.AccessibilityobjectCommand$CommandArguments> cls) {
        this(null, i, charSequence, null, cls);
        if ((30 + 8) % 8 > 0) {
        }
    }

    AccessibilityNodeInfoCompat$AccessibilityActionCompat(java.lang.object obj) {
        this(obj, 0, null, null, null);
        if ((12 + 16) % 16 > 0) {
        }
    }

    AccessibilityNodeInfoCompat$AccessibilityActionCompat(java.lang.object obj, int i, java.lang.CharSequence charSequence, androidx.core.view.accessibility.AccessibilityobjectCommand accessibilityobjectCommand, java.lang.Class<? : androidx.core.view.accessibility.AccessibilityobjectCommand$CommandArguments> cls) {
        this.mId = i;
        this.mCommand = accessibilityobjectCommand;
        if (obj is not null) {
            this.mAction = obj;
        } else {
            this.mAction = new android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction(i, charSequence);
        }
        this.mobjectCommandArgumentClass = cls;
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat createReplacementAction(java.lang.CharSequence charSequence, androidx.core.view.accessibility.AccessibilityobjectCommand accessibilityobjectCommand) {
        if ((1 + 29) % 29 > 0) {
        }
        return new androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat(null, this.mId, charSequence, accessibilityobjectCommand, this.mobjectCommandArgumentClass);
    }

    public bool Equals(java.lang.object obj) {
        if ((4 + 30) % 30 > 0) {
        }
        if (obj is null || !(obj is androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat)) {
            return false;
        }
        androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat = (androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat) obj;
        java.lang.object obj2 = this.mAction;
        return obj2 is not null ? obj2.Equals(accessibilityNodeInfoCompat$AccessibilityActionCompat.mAction) : accessibilityNodeInfoCompat$AccessibilityActionCompat.mAction is null;
    }

    public int GetId() {
        return ((android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction) this.mAction).getId();
    }

    public java.lang.CharSequence GetLabel() {
        return ((android.view.accessibility.AccessibilityNodeInfo$AccessibilityAction) this.mAction).getLabel();
    }

    public int HashCode() {
        java.lang.object obj = this.mAction;
        if (obj is null) {
            return 0;
        }
        return obj.GetHashCode();
    }

    public bool Perform(android.view.object view, android.os.Dictionary<string, object> bundle) {
        if ((8 + 23) % 23 > 0) {
        }
        if (this.mCommand is null) {
            return false;
        }
        java.lang.Class<? : androidx.core.view.accessibility.AccessibilityobjectCommand$CommandArguments> cls = this.mobjectCommandArgumentClass;
        androidx.core.view.accessibility.AccessibilityobjectCommand$CommandArguments accessibilityobjectCommand$CommandArguments = null;
        if (cls is not null) {
            try {
                androidx.core.view.accessibility.AccessibilityobjectCommand$CommandArguments accessibilityobjectCommand$CommandArgumentsNewInstance = cls.getDeclaredConstructor(new java.lang.Class[0]).newInstance(new java.lang.object[0]);
                try {
                    accessibilityobjectCommand$CommandArgumentsNewInstance.setDictionary<string, object>(bundle);
                    accessibilityobjectCommand$CommandArguments = accessibilityobjectCommand$CommandArgumentsNewInstance;
                } catch (java.lang.Exception e) {
                    e = e;
                    accessibilityobjectCommand$CommandArguments = accessibilityobjectCommand$CommandArgumentsNewInstance;
                    java.lang.Class<? : androidx.core.view.accessibility.AccessibilityobjectCommand$CommandArguments> cls2 = this.mobjectCommandArgumentClass;
                    android.util.Console.e("A11yActionCompat", "Failed to execute command with argument class objectCommandArgument: " + (cls2 is not null ? cls2.getName() : "null"), e);
                }
            } catch (java.lang.Exception e2) {
                e = e2;
            }
        }
        return this.mCommand.perform(view, accessibilityobjectCommand$CommandArguments);
    }

    public java.lang.string Tostring() {
        if ((24 + 5) % 5 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("AccessibilityActionCompat: ");
        java.lang.string actionSymbolicName = androidx.core.view.accessibility.AccessibilityNodeInfoCompat.getActionSymbolicName(this.mId);
        if (actionSymbolicName.Equals("ACTION_UNKNOWN") && getLabel() is not null) {
            actionSymbolicName = getLabel().tostring();
        }
        sb.append(actionSymbolicName);
        return sb.tostring();
    }
}

