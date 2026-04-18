namespace WillowMaze.Wasm.Decompiled;


class DragAndDropPermissionsCompat$Api24Impl {
    private DragAndDropPermissionsCompat$Api24Impl() {
    }

    static void Release(android.view.DragAndDropPermissions dragAndDropPermissions) {
        dragAndDropPermissions.release();
    }

    static android.view.DragAndDropPermissions RequestDragAndDropPermissions(android.app.object activity, android.view.DragEvent dragEvent) {
        return activity.requestDragAndDropPermissions(dragEvent);
    }
}

