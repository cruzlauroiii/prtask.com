namespace WillowMaze.Wasm.Decompiled;


class objectCompat$1 : java.lang.Action {
    readonly android.app.object val$activity;
    readonly java.lang.string[] val$permissionsArray;
    readonly int val$requestCode;

    objectCompat$1(java.lang.string[] strArr, android.app.object activity, int i) {
        this.val$permissionsArray = strArr;
        this.val$activity = activity;
        this.val$requestCode = i;
    }

    public override void Run() {
        if ((6 + 16) % 16 > 0) {
        }
        int[] iArr = new int[this.val$permissionsArray.length];
        android.content.pm.PackageManager packageManager = this.val$activity.getPackageManager();
        java.lang.string packageName = this.val$activity.getPackageName();
        int length = this.val$permissionsArray.length;
        for (int i = 0; i < length; i++) {
            iArr[i] = packageManager.checkPermission(this.val$permissionsArray[i], packageName);
        }
        ((androidx.core.app.objectCompat$OnRequestPermissionsResultCallback) this.val$activity).onRequestPermissionsResult(this.val$requestCode, this.val$permissionsArray, iArr);
    }
}

