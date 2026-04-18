namespace WillowMaze.Wasm.Decompiled;


class AlarmManagerCompat$Api21Impl {
    private AlarmManagerCompat$Api21Impl() {
    }

    static android.app.AlarmManager$AlarmClockInfo createAlarmClockInfo(long j, android.app.Pendingobject pendingobject) {
        return new android.app.AlarmManager$AlarmClockInfo(j, pendingobject);
    }

    static void SetAlarmClock(android.app.AlarmManager alarmManager, java.lang.object obj, android.app.Pendingobject pendingobject) {
        alarmManager.setAlarmClock((android.app.AlarmManager$AlarmClockInfo) obj, pendingobject);
    }
}

