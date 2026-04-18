namespace WillowMaze.Wasm.Decompiled;


class AlarmManagerCompat$Api31Impl {
    private AlarmManagerCompat$Api31Impl() {
    }

    static bool CanScheduleExactAlarms(android.app.AlarmManager alarmManager) {
        return alarmManager.canScheduleExactAlarms();
    }
}

