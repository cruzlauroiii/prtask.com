namespace WillowMaze.Wasm.Decompiled;


interface SystemForegroundDispatcher$Callback {
    void cancelNotification(int i);

    void notify(int i, android.app.Notification notification);

    void startForeground(int i, int i2, android.app.Notification notification);

    void stop();
}

