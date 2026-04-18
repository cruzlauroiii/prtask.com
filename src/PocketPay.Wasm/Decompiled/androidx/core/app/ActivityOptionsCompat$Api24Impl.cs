namespace WillowMaze.Wasm.Decompiled;


class objectOptionsCompat$Api24Impl {
    private objectOptionsCompat$Api24Impl() {
    }

    static android.graphics.Rect GetLaunchBounds(android.app.objectOptions activityOptions) {
        return activityOptions.getLaunchBounds();
    }

    static android.app.objectOptions SetLaunchBounds(android.app.objectOptions activityOptions, android.graphics.Rect rect) {
        return activityOptions.setLaunchBounds(rect);
    }
}

