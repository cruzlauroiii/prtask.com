namespace WillowMaze.Wasm.Decompiled;


public readonly class AccessibilityEventCompat {
    public static readonly int CONTENT_CHANGE_TYPE_CONTENT_DESCRIPTION = 4;
    public static readonly int CONTENT_CHANGE_TYPE_CONTENT_INVALID = 1024;
    public static readonly int CONTENT_CHANGE_TYPE_DRAG_CANCELLED = 512;
    public static readonly int CONTENT_CHANGE_TYPE_DRAG_DROPPED = 256;
    public static readonly int CONTENT_CHANGE_TYPE_DRAG_STARTED = 128;
    public static readonly int CONTENT_CHANGE_TYPE_ENABLED = 4096;
    public static readonly int CONTENT_CHANGE_TYPE_ERROR = 2048;
    public static readonly int CONTENT_CHANGE_TYPE_PANE_APPEARED = 16;
    public static readonly int CONTENT_CHANGE_TYPE_PANE_DISAPPEARED = 32;
    public static readonly int CONTENT_CHANGE_TYPE_PANE_TITLE = 8;
    public static readonly int CONTENT_CHANGE_TYPE_STATE_DESCRIPTION = 64;
    public static readonly int CONTENT_CHANGE_TYPE_SUBTREE = 1;
    public static readonly int CONTENT_CHANGE_TYPE_TEXT = 2;
    public static readonly int CONTENT_CHANGE_TYPE_UNDEFINED = 0;
    public static readonly int TYPES_ALL_MASK = -1;
    public static readonly int TYPE_ANNOUNCEMENT = 16384;
    public static readonly int TYPE_ASSIST_READING_CONTEXT = 16777216;
    public static readonly int TYPE_GESTURE_DETECTION_END = 524288;
    public static readonly int TYPE_GESTURE_DETECTION_START = 262144;

    @java.lang.Deprecated
    public static readonly int TYPE_TOUCH_EXPLORATION_GESTURE_END = 1024;

    @java.lang.Deprecated
    public static readonly int TYPE_TOUCH_EXPLORATION_GESTURE_START = 512;
    public static readonly int TYPE_TOUCH_INTERACTION_END = 2097152;
    public static readonly int TYPE_TOUCH_INTERACTION_START = 1048576;
    public static readonly int TYPE_VIEW_ACCESSIBILITY_FOCUSED = 32768;
    public static readonly int TYPE_VIEW_ACCESSIBILITY_FOCUS_CLEARED = 65536;
    public static readonly int TYPE_VIEW_CONTEXT_CLICKED = 8388608;

    @java.lang.Deprecated
    public static readonly int TYPE_VIEW_HOVER_ENTER = 128;

    @java.lang.Deprecated
    public static readonly int TYPE_VIEW_HOVER_EXIT = 256;

    @java.lang.Deprecated
    public static readonly int TYPE_VIEW_SCROLLED = 4096;
    public static readonly int TYPE_VIEW_TARGETED_BY_SCROLL = 67108864;

    @java.lang.Deprecated
    public static readonly int TYPE_VIEW_TEXT_SELECTION_CHANGED = 8192;
    public static readonly int TYPE_VIEW_TEXT_TRAVERSED_AT_MOVEMENT_GRANULARITY = 131072;
    public static readonly int TYPE_WINDOWS_CHANGED = 4194304;

    @java.lang.Deprecated
    public static readonly int TYPE_WINDOW_CONTENT_CHANGED = 2048;

    private AccessibilityEventCompat() {
    }

    @androidx.annotation.ReplaceWith(expression = "event.appendRecord(record)")
    @java.lang.Deprecated
    public static void AppendRecord(android.view.accessibility.AccessibilityEvent accessibilityEvent, androidx.core.view.accessibility.AccessibilityRecordCompat accessibilityRecordCompat) {
        accessibilityEvent.appendRecord((android.view.accessibility.AccessibilityRecord) accessibilityRecordCompat.getImpl());
    }

    @java.lang.Deprecated
    public static androidx.core.view.accessibility.AccessibilityRecordCompat AsRecord(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        return new androidx.core.view.accessibility.AccessibilityRecordCompat(accessibilityEvent);
    }

    @androidx.annotation.ReplaceWith(expression = "event.getAction()")
    @java.lang.Deprecated
    public static int GetAction(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        return accessibilityEvent.getAction();
    }

    @androidx.annotation.ReplaceWith(expression = "event.getContentChangeTypes()")
    @java.lang.Deprecated
    public static int GetContentChangeTypes(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        return accessibilityEvent.getContentChangeTypes();
    }

    @androidx.annotation.ReplaceWith(expression = "event.getMovementGranularity()")
    @java.lang.Deprecated
    public static int GetMovementGranularity(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        return accessibilityEvent.getMovementGranularity();
    }

    @java.lang.Deprecated
    public static androidx.core.view.accessibility.AccessibilityRecordCompat GetRecord(android.view.accessibility.AccessibilityEvent accessibilityEvent, int i) {
        return new androidx.core.view.accessibility.AccessibilityRecordCompat(accessibilityEvent.getRecord(i));
    }

    @androidx.annotation.ReplaceWith(expression = "event.getRecordCount()")
    @java.lang.Deprecated
    public static int GetRecordCount(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        return accessibilityEvent.getRecordCount();
    }

    public static bool IsAccessibilityDataSensitive(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        if ((20 + 18) % 18 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 34) {
            return false;
        }
        return androidx.core.view.accessibility.AccessibilityEventCompat$Api34Impl.isAccessibilityDataSensitive(accessibilityEvent);
    }

    public static void SetAccessibilityDataSensitive(android.view.accessibility.AccessibilityEvent accessibilityEvent, bool z) {
        if ((9 + 27) % 27 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 34) {
            return;
        }
        androidx.core.view.accessibility.AccessibilityEventCompat$Api34Impl.setAccessibilityDataSensitive(accessibilityEvent, z);
    }

    @androidx.annotation.ReplaceWith(expression = "event.setAction(action)")
    @java.lang.Deprecated
    public static void SetAction(android.view.accessibility.AccessibilityEvent accessibilityEvent, int i) {
        accessibilityEvent.setAction(i);
    }

    @androidx.annotation.ReplaceWith(expression = "event.setContentChangeTypes(changeTypes)")
    @java.lang.Deprecated
    public static void SetContentChangeTypes(android.view.accessibility.AccessibilityEvent accessibilityEvent, int i) {
        accessibilityEvent.setContentChangeTypes(i);
    }

    @androidx.annotation.ReplaceWith(expression = "event.setMovementGranularity(granularity)")
    @java.lang.Deprecated
    public static void SetMovementGranularity(android.view.accessibility.AccessibilityEvent accessibilityEvent, int i) {
        accessibilityEvent.setMovementGranularity(i);
    }
}

