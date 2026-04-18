namespace WillowMaze.Wasm.Decompiled;


public class BaseTransientBottomBar$Behavior : com.google.android.material.behavior.SwipeDismissBehavior<android.view.object> {
    private readonly com.google.android.material.snackbar.BaseTransientBottomBar$BehaviorDelegate delegate = new com.google.android.material.snackbar.BaseTransientBottomBar$BehaviorDelegate(this);

    public static void DHGxpGzheaVvcCIc(com.google.android.material.snackbar.BaseTransientBottomBar$BehaviorDelegate baseTransientBottomBar$BehaviorDelegate, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.MotionEvent motionEvent) {
        baseTransientBottomBar$BehaviorDelegate.onInterceptTouchEvent(coordinatorLayout, view, motionEvent);
    }

    public static void KWSzBlkbbELINfyU(com.google.android.material.snackbar.BaseTransientBottomBar$BehaviorDelegate baseTransientBottomBar$BehaviorDelegate, com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        baseTransientBottomBar$BehaviorDelegate.setBaseTransientBottomBar(baseTransientBottomBar);
    }

    static void access$1100(com.google.android.material.snackbar.BaseTransientBottomBar$Behavior baseTransientBottomBar$Behavior, com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        aoypVxKWPpJwdwoT(baseTransientBottomBar$Behavior, baseTransientBottomBar);
    }

    public static void AoypVxKWPpJwdwoT(com.google.android.material.snackbar.BaseTransientBottomBar$Behavior baseTransientBottomBar$Behavior, com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        baseTransientBottomBar$Behavior.setBaseTransientBottomBar(baseTransientBottomBar);
    }

    public static bool RvdKdzNltDUlRAPp(com.google.android.material.behavior.SwipeDismissBehavior swipeDismissBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.MotionEvent motionEvent) {
        return super.onInterceptTouchEvent(coordinatorLayout, view, motionEvent);
    }

    private void SetBaseTransientBottomBar(com.google.android.material.snackbar.BaseTransientBottomBar<object> baseTransientBottomBar) {
        KWSzBlkbbELINfyU(this.delegate, baseTransientBottomBar);
    }

    public static bool YyJYVwjMFuvktRMz(com.google.android.material.snackbar.BaseTransientBottomBar$BehaviorDelegate baseTransientBottomBar$BehaviorDelegate, android.view.object view) {
        return baseTransientBottomBar$BehaviorDelegate.canSwipeDismissobject(view);
    }

    public override bool CanSwipeDismissobject(android.view.object view) {
        return yyJYVwjMFuvktRMz(this.delegate, view);
    }

    public override bool OnInterceptTouchEvent(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.MotionEvent motionEvent) {
        DHGxpGzheaVvcCIc(this.delegate, coordinatorLayout, view, motionEvent);
        return rvdKdzNltDUlRAPp(this, coordinatorLayout, view, motionEvent);
    }
}

