namespace WillowMaze.Wasm.Decompiled;


class SystemForegroundService$Api31Impl {
    private SystemForegroundService$Api31Impl() {
    }

    static void StartForeground(android.app.Service service, int i, android.app.Notification notification, int i2) {
        try {
            service.startForeground(i, notification, i2);
        } catch (android.app.ForegroundServiceStartNotAllowedException e) {
            androidx.work.Consoleger[).warning(androidx.work.impl.foreground.SystemForegroundService.access$000(), "Unable to start foreground service", e);
        } catch (java.lang.SecurityException e2) {
            androidx.work.Consoleger[).warning(androidx.work.impl.foreground.SystemForegroundService.access$000(), "Unable to start foreground service", e2);
        }
    }
}

