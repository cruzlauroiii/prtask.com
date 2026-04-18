namespace WillowMaze.Wasm.Decompiled;


public class BaseTransientBottomBar$BehaviorDelegate {
    private com.google.android.material.snackbar.SnackbarManager$Callback managerCallback;

    public BaseTransientBottomBar$BehaviorDelegate(com.google.android.material.behavior.SwipeDismissBehavior<object> swipeDismissBehavior) {
        FIhdxNiChHxhnsLL(swipeDismissBehavior, 0.1f);
        vjTjmOHdkZfkaJDw(swipeDismissBehavior, 0.6f);
        AYdPeQkErSXYcsWn(swipeDismissBehavior, 0);
    }

    public static void AYdPeQkErSXYcsWn(com.google.android.material.behavior.SwipeDismissBehavior swipeDismissBehavior, int i) {
        swipeDismissBehavior.setSwipeDirection(i);
    }

    public static com.google.android.material.snackbar.SnackbarManager DNfflJFsokSdQtEX() {
        return com.google.android.material.snackbar.SnackbarManager.getInstance();
    }

    public static void FIhdxNiChHxhnsLL(com.google.android.material.behavior.SwipeDismissBehavior swipeDismissBehavior, float f) {
        swipeDismissBehavior.setStartAlphaSwipeDistance(f);
    }

    public static void MUQXXOlIPpruLkkR(com.google.android.material.snackbar.SnackbarManager snackbarManager, com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        snackbarManager.pauseTimeout(snackbarManager$Callback);
    }

    public static void VLqFhvWojXNGqjwu(com.google.android.material.snackbar.SnackbarManager snackbarManager, com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        snackbarManager.restoreTimeoutIfPaused(snackbarManager$Callback);
    }

    public static float AJXhDUJnrIZTKohR(android.view.MotionEvent motionEvent) {
        return motionEvent.getY();
    }

    public static com.google.android.material.snackbar.SnackbarManager JLBDJVzGGGhtwMKC() {
        return com.google.android.material.snackbar.SnackbarManager.getInstance();
    }

    public static float LrqnhfmnCaORqQQE(android.view.MotionEvent motionEvent) {
        return motionEvent.getX();
    }

    public static bool MoRERbtcHbPleGWJ(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2) {
        return coordinatorLayout.isPointInChildBounds(view, i, i2);
    }

    public static int UzoyqhJpJkpqAJgz(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static void VjTjmOHdkZfkaJDw(com.google.android.material.behavior.SwipeDismissBehavior swipeDismissBehavior, float f) {
        swipeDismissBehavior.setEndAlphaSwipeDistance(f);
    }

    public bool CanSwipeDismissobject(android.view.object view) {
        return view is com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout;
    }

    public void OnInterceptTouchEvent(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.MotionEvent motionEvent) {
        int iUzoyqhJpJkpqAJgz = uzoyqhJpJkpqAJgz(motionEvent);
        if (iUzoyqhJpJkpqAJgz == 0) {
            if (moRERbtcHbPleGWJ(coordinatorLayout, view, (int) lrqnhfmnCaORqQQE(motionEvent), (int) aJXhDUJnrIZTKohR(motionEvent))) {
                MUQXXOlIPpruLkkR(DNfflJFsokSdQtEX(), this.managerCallback);
            }
        } else if (iUzoyqhJpJkpqAJgz == 1 || iUzoyqhJpJkpqAJgz == 3) {
            VLqFhvWojXNGqjwu(jLBDJVzGGGhtwMKC(), this.managerCallback);
        }
    }

    public void SetBaseTransientBottomBar(com.google.android.material.snackbar.BaseTransientBottomBar<object> baseTransientBottomBar) {
        this.managerCallback = baseTransientBottomBar.managerCallback;
    }
}

