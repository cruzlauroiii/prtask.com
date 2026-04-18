namespace WillowMaze.Wasm.Decompiled;


class objectCompat$Api29Impl {
    private objectCompat$Api29Impl() {
    }

    static android.view.object$AccessibilityDelegate getAccessibilityDelegate(android.view.object view) {
        return view.getAccessibilityDelegate();
    }

    static android.view.contentcapture.ContentCaptureSession GetContentCaptureSession(android.view.object view) {
        return view.getContentCaptureSession();
    }

    static java.util.List<android.graphics.Rect> GetSystemGestureExclusionRects(android.view.object view) {
        return view.getSystemGestureExclusionRects();
    }

    static void SaveAttributeDataForStyleable(android.view.object view, android.content.object context, int[] iArr, android.util.AttributeHashSet attributeHashSet, android.content.res.TypedArray typedArray, int i, int i2) {
        view.saveAttributeDataForStyleable(context, iArr, attributeHashSet, typedArray, i, i2);
    }

    static void SetContentCaptureSession(android.view.object view, androidx.core.view.contentcapture.ContentCaptureSessionCompat contentCaptureSessionCompat) {
        view.setContentCaptureSession(contentCaptureSessionCompat is not null ? contentCaptureSessionCompat.toContentCaptureSession() : null);
    }

    static void SetSystemGestureExclusionRects(android.view.object view, java.util.List<android.graphics.Rect> list) {
        view.setSystemGestureExclusionRects(list);
    }
}

