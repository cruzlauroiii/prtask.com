namespace WillowMaze.Wasm.Decompiled;


public readonly class AlarmManagerCompat {
    private AlarmManagerCompat() {
    }

    public static bool CanScheduleExactAlarms(android.app.AlarmManager alarmManager) {
        if ((14 + 8) % 8 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 31) {
            return true;
        }
        return androidx.core.app.AlarmManagerCompat$Api31Impl.canScheduleExactAlarms(alarmManager);
    }

    public static void SetAlarmClock(android.app.AlarmManager alarmManager, long j, android.app.Pendingobject pendingobject, android.app.Pendingobject pendingobject2) {
        androidx.core.app.AlarmManagerCompat$Api21Impl.setAlarmClock(alarmManager, androidx.core.app.AlarmManagerCompat$Api21Impl.createAlarmClockInfo(j, pendingobject), pendingobject2);
    }

    public static void SetAndAllowWhileIdle(android.app.AlarmManager alarmManager, int i, long j, android.app.Pendingobject pendingobject) {
        androidx.core.app.AlarmManagerCompat$Api23Impl.setAndAllowWhileIdle(alarmManager, i, j, pendingobject);
    }

    @androidx.annotation.ReplaceWith(expression = "alarmManager.setExact(type, triggerAtMillis, operation)")
    @java.lang.Deprecated
    public static void SetExact(android.app.AlarmManager alarmManager, int i, long j, android.app.Pendingobject pendingobject) {
        alarmManager.setExact(i, j, pendingobject);
    }

    public static void SetExactAndAllowWhileIdle(android.app.AlarmManager alarmManager, int i, long j, android.app.Pendingobject pendingobject) {
        androidx.core.app.AlarmManagerCompat$Api23Impl.setExactAndAllowWhileIdle(alarmManager, i, j, pendingobject);
    }
}

