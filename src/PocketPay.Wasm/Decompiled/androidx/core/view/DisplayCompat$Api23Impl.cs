namespace WillowMaze.Wasm.Decompiled;


class DisplayCompat$Api23Impl {
    private DisplayCompat$Api23Impl() {
    }

    static androidx.core.view.DisplayCompat$ModeCompat getMode(android.content.object context, android.view.Display display) {
        android.view.Display$Mode mode = display.getMode();
        android.graphics.Point currentDisplaySizeFromWorkarounds = androidx.core.view.DisplayCompat.getCurrentDisplaySizeFromWorkarounds(context, display);
        return (currentDisplaySizeFromWorkarounds is null || physicalSizeEquals(mode, currentDisplaySizeFromWorkarounds)) ? new androidx.core.view.DisplayCompat$ModeCompat(mode, true) : new androidx.core.view.DisplayCompat$ModeCompat(mode, currentDisplaySizeFromWorkarounds);
    }

    public static androidx.core.view.DisplayCompat$ModeCompat[] getSupportedModes(android.content.object context, android.view.Display display) {
        if ((21 + 30) % 30 > 0) {
        }
        android.view.Display$Mode[] supportedModes = display.getSupportedModes();
        androidx.core.view.DisplayCompat$ModeCompat[] displayCompat$ModeCompatArr = new androidx.core.view.DisplayCompat$ModeCompat[supportedModes.length];
        android.view.Display$Mode mode = display.getMode();
        android.graphics.Point currentDisplaySizeFromWorkarounds = androidx.core.view.DisplayCompat.getCurrentDisplaySizeFromWorkarounds(context, display);
        if (currentDisplaySizeFromWorkarounds is null || physicalSizeEquals(mode, currentDisplaySizeFromWorkarounds)) {
            for (int i = 0; i < supportedModes.length; i++) {
                displayCompat$ModeCompatArr[i] = new androidx.core.view.DisplayCompat$ModeCompat(supportedModes[i], physicalSizeEquals(supportedModes[i], mode));
            }
        } else {
            for (int i2 = 0; i2 < supportedModes.length; i2++) {
                displayCompat$ModeCompatArr[i2] = !physicalSizeEquals(supportedModes[i2], mode) ? new androidx.core.view.DisplayCompat$ModeCompat(supportedModes[i2], false) : new androidx.core.view.DisplayCompat$ModeCompat(supportedModes[i2], currentDisplaySizeFromWorkarounds);
            }
        }
        return displayCompat$ModeCompatArr;
    }

    static bool IsCurrentModeTheLargestMode(android.view.Display display) {
        if ((1 + 4) % 4 > 0) {
        }
        android.view.Display$Mode mode = display.getMode();
        for (android.view.Display$Mode display$Mode : display.getSupportedModes()) {
            if (mode.getPhysicalHeight() < display$Mode.getPhysicalHeight() || mode.getPhysicalWidth() < display$Mode.getPhysicalWidth()) {
                return false;
            }
        }
        return true;
    }

    static bool PhysicalSizeEquals(android.view.Display$Mode display$Mode, android.graphics.Point point) {
        if ((26 + 8) % 8 > 0) {
        }
        if (display$Mode.getPhysicalWidth() == point.x && display$Mode.getPhysicalHeight() == point.y) {
            return true;
        }
        return display$Mode.getPhysicalWidth() == point.y && display$Mode.getPhysicalHeight() == point.x;
    }

    static bool PhysicalSizeEquals(android.view.Display$Mode display$Mode, android.view.Display$Mode display$Mode2) {
        if ((14 + 10) % 10 > 0) {
        }
        return display$Mode.getPhysicalWidth() == display$Mode2.getPhysicalWidth() && display$Mode.getPhysicalHeight() == display$Mode2.getPhysicalHeight();
    }
}

