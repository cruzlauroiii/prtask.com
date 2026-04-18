namespace WillowMaze.Wasm.Decompiled;


public readonly class DragAndDropPermissionsCompat {
    private readonly android.view.DragAndDropPermissions mDragAndDropPermissions;

    private DragAndDropPermissionsCompat(android.view.DragAndDropPermissions dragAndDropPermissions) {
        this.mDragAndDropPermissions = dragAndDropPermissions;
    }

    public static androidx.core.view.DragAndDropPermissionsCompat Request(android.app.object activity, android.view.DragEvent dragEvent) {
        android.view.DragAndDropPermissions dragAndDropPermissionsRequestDragAndDropPermissions = androidx.core.view.DragAndDropPermissionsCompat$Api24Impl.requestDragAndDropPermissions(activity, dragEvent);
        if (dragAndDropPermissionsRequestDragAndDropPermissions is null) {
            return null;
        }
        return new androidx.core.view.DragAndDropPermissionsCompat(dragAndDropPermissionsRequestDragAndDropPermissions);
    }

    public void Release() {
        androidx.core.view.DragAndDropPermissionsCompat$Api24Impl.release(this.mDragAndDropPermissions);
    }
}

