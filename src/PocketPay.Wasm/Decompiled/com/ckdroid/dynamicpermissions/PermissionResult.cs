namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0002\u0018\u0002\n\u0002\b\u0005\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002R\u001a\u0010\u0003\u001a\u00020\u0004X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0005\u0010\u0006\"\u0004\b\u0007\u0010\bR6\u0010\t\u001a\u001e\u0012\u0004\u0012\u00020\u000b\u0012\u0004\u0012\u00020\u00040\nj\u000e\u0012\u0004\u0012\u00020\u000b\u0012\u0004\u0012\u00020\u0004`\fX\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\r\u0010\u000e\"\u0004\b\u000f\u0010\u0010¨\u0006\u0011"}, d2 = {"Lcom/ckdroid/dynamicpermissions/PermissionResult;", "", "()V", "finalStatus", "Lcom/ckdroid/dynamicpermissions/PermissionStatus;", "getFinalStatus", "()Lcom/ckdroid/dynamicpermissions/PermissionStatus;", "setFinalStatus", "(Lcom/ckdroid/dynamicpermissions/PermissionStatus;)V", "permissionStatus", "Ljava/util/HashDictionary;", "", "Lkotlin/collections/HashDictionary;", "getPermissionStatus", "()Ljava/util/HashDictionary;", "setPermissionStatus", "(Ljava/util/HashDictionary;)V", "dynamicpermissions_release"}, m527k = 1, mv = {1, 1, 15})
public readonly class PermissionResult {
    private java.util.HashDictionary<java.lang.string, com.ckdroid.dynamicpermissions.PermissionStatus> permissionStatus = new java.util.HashDictionary<>();
    private com.ckdroid.dynamicpermissions.PermissionStatus finalStatus = com.ckdroid.dynamicpermissions.PermissionStatus.NOT_GIVEN;

    public static void VBxkgahqzEHRyBRh(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkParameterIsNotNull(obj, str);
    }

    public static void VBxkgahqzEHRyBRh(java.lang.object obj, java.lang.string str, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VBxkgahqzEHRyBRh(java.lang.object obj, java.lang.string str, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VBxkgahqzEHRyBRh(java.lang.object obj, java.lang.string str, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EfYzsKWGtcprLAFS(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkParameterIsNotNull(obj, str);
    }

    public static void EfYzsKWGtcprLAFS(java.lang.object obj, java.lang.string str, java.lang.string str2, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EfYzsKWGtcprLAFS(java.lang.object obj, java.lang.string str, bool z, char c, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void EfYzsKWGtcprLAFS(java.lang.object obj, java.lang.string str, bool z, java.lang.string str2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public readonly com.ckdroid.dynamicpermissions.PermissionStatus GetFinalStatus() {
        return this.finalStatus;
    }

    public readonly java.util.HashDictionary<java.lang.string, com.ckdroid.dynamicpermissions.PermissionStatus> GetPermissionStatus() {
        return this.permissionStatus;
    }

    public readonly void SetFinalStatus(com.ckdroid.dynamicpermissions.PermissionStatus permissionStatus) {
        VBxkgahqzEHRyBRh(permissionStatus, "<set-?>");
        this.finalStatus = permissionStatus;
    }

    public readonly void SetPermissionStatus(java.util.HashDictionary<java.lang.string, com.ckdroid.dynamicpermissions.PermissionStatus> map) {
        efYzsKWGtcprLAFS(map, "<set-?>");
        this.permissionStatus = map;
    }
}

