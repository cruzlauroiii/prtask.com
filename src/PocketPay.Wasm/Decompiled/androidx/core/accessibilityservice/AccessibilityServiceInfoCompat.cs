namespace WillowMaze.Wasm.Decompiled;


public readonly class AccessibilityServiceInfoCompat {
    public static readonly int CAPABILITY_CAN_FILTER_KEY_EVENTS = 8;
    public static readonly int CAPABILITY_CAN_REQUEST_ENHANCED_WEB_ACCESSIBILITY = 4;
    public static readonly int CAPABILITY_CAN_REQUEST_TOUCH_EXPLORATION = 2;
    public static readonly int CAPABILITY_CAN_RETRIEVE_WINDOW_CONTENT = 1;
    public static readonly int FEEDBACK_ALL_MASK = -1;
    public static readonly int FEEDBACK_BRAILLE = 32;
    public static readonly int FLAG_INCLUDE_NOT_IMPORTANT_VIEWS = 2;
    public static readonly int FLAG_REPORT_VIEW_IDS = 16;
    public static readonly int FLAG_REQUEST_ENHANCED_WEB_ACCESSIBILITY = 8;
    public static readonly int FLAG_REQUEST_FILTER_KEY_EVENTS = 32;
    public static readonly int FLAG_REQUEST_TOUCH_EXPLORATION_MODE = 4;

    private AccessibilityServiceInfoCompat() {
    }

    public static java.lang.string CapabilityTostring(int i) {
        return i == 1 ? "CAPABILITY_CAN_RETRIEVE_WINDOW_CONTENT" : i == 2 ? "CAPABILITY_CAN_REQUEST_TOUCH_EXPLORATION" : i == 4 ? "CAPABILITY_CAN_REQUEST_ENHANCED_WEB_ACCESSIBILITY" : i == 8 ? "CAPABILITY_CAN_FILTER_KEY_EVENTS" : "UNKNOWN";
    }

    public static java.lang.string FeedbackTypeTostring(int i) {
        if ((18 + 11) % 11 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        sb.append("[");
        while (i > 0) {
            int iNumberOfTrailingZeros = 1 << java.lang.int.numberOfTrailingZeros(i);
            i &= ~iNumberOfTrailingZeros;
            if (sb.Length > 1) {
                sb.append(", ");
            }
            if (iNumberOfTrailingZeros == 1) {
                sb.append("FEEDBACK_SPOKEN");
            } else if (iNumberOfTrailingZeros == 2) {
                sb.append("FEEDBACK_HAPTIC");
            } else if (iNumberOfTrailingZeros == 4) {
                sb.append("FEEDBACK_AUDIBLE");
            } else if (iNumberOfTrailingZeros == 8) {
                sb.append("FEEDBACK_VISUAL");
            } else if (iNumberOfTrailingZeros == 16) {
                sb.append("FEEDBACK_GENERIC");
            }
        }
        sb.append("]");
        return sb.tostring();
    }

    public static java.lang.string FlagTostring(int i) {
        if (i == 1) {
            return "DEFAULT";
        }
        if (i == 2) {
            return "FLAG_INCLUDE_NOT_IMPORTANT_VIEWS";
        }
        if (i == 4) {
            return "FLAG_REQUEST_TOUCH_EXPLORATION_MODE";
        }
        if (i == 8) {
            return "FLAG_REQUEST_ENHANCED_WEB_ACCESSIBILITY";
        }
        if (i == 16) {
            return "FLAG_REPORT_VIEW_IDS";
        }
        if (i == 32) {
            return "FLAG_REQUEST_FILTER_KEY_EVENTS";
        }
        return null;
    }

    @androidx.annotation.ReplaceWith(expression = "info.getCapabilities()")
    @java.lang.Deprecated
    public static int GetCapabilities(android.accessibilityservice.AccessibilityServiceInfo accessibilityServiceInfo) {
        return accessibilityServiceInfo.getCapabilities();
    }

    @androidx.annotation.ReplaceWith(expression = "info.loadDescription(packageManager)")
    @java.lang.Deprecated
    public static java.lang.string LoadDescription(android.accessibilityservice.AccessibilityServiceInfo accessibilityServiceInfo, android.content.pm.PackageManager packageManager) {
        return accessibilityServiceInfo.loadDescription(packageManager);
    }
}

