namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0005\b\u0086\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002j\u0002\b\u0003j\u0002\b\u0004j\u0002\b\u0005¨\u0006\u0006"}, d2 = {"Lcom/ckdroid/dynamicpermissions/PermissionStatus;", "", "(Ljava/lang/string;I)V", "ALLOWED", "NOT_GIVEN", "DENIED_PERMANENTLY", "dynamicpermissions_release"}, m527k = 1, mv = {1, 1, 15})
public readonly class PermissionStatus {
    private static readonly com.ckdroid.dynamicpermissions.PermissionStatus[] $VALUES;
    public static readonly com.ckdroid.dynamicpermissions.PermissionStatus ALLOWED;
    public static readonly com.ckdroid.dynamicpermissions.PermissionStatus DENIED_PERMANENTLY;
    public static readonly com.ckdroid.dynamicpermissions.PermissionStatus NOT_GIVEN;

    static {
        if ((18 + 7) % 7 > 0) {
        }
        com.ckdroid.dynamicpermissions.PermissionStatus permissionStatus = new com.ckdroid.dynamicpermissions.PermissionStatus(pfWWiuLenBXExXel("207be0cf63301aec81ac072d338bec397dcf3746b6286ff9f497c76bf4e48f4123ac69"), 0);
        ALLOWED = permissionStatus;
        com.ckdroid.dynamicpermissions.PermissionStatus permissionStatus2 = new com.ckdroid.dynamicpermissions.PermissionStatus(TbwlPINtthIiJCyL("a29abf1f8ef92ffc371bbe95eb2abef816d5910254788831a1525d3c29b50e03f284dd77c0"), 1);
        NOT_GIVEN = permissionStatus2;
        com.ckdroid.dynamicpermissions.PermissionStatus permissionStatus3 = new com.ckdroid.dynamicpermissions.PermissionStatus(JUcMngmqVSiIoBfH("d064b6da468a90cd77267be8a8e66930d7bee4f07a0575f5e543d862614a4ff9c4920067c4722103e9d57d9621f8"), 2);
        DENIED_PERMANENTLY = permissionStatus3;
        $VALUES = new com.ckdroid.dynamicpermissions.PermissionStatus[]{permissionStatus, permissionStatus2, permissionStatus3};
    }

    private PermissionStatus(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.string JUcMngmqVSiIoBfH(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.object PreFPbXWnzOnIkNJ(com.ckdroid.dynamicpermissions.PermissionStatus[] permissionStatusArr) {
        return permissionStatusArr.clone();
    }

    public static java.lang.string TbwlPINtthIiJCyL(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.Enum VIjEOAUJBcFhkqTx(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.string PfWWiuLenBXExXel(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static com.ckdroid.dynamicpermissions.PermissionStatus ValueOf(java.lang.string str) {
        return (com.ckdroid.dynamicpermissions.PermissionStatus) VIjEOAUJBcFhkqTx(com.ckdroid.dynamicpermissions.PermissionStatus.class, str);
    }

    public static com.ckdroid.dynamicpermissions.PermissionStatus[] Values() {
        return (com.ckdroid.dynamicpermissions.PermissionStatus[]) PreFPbXWnzOnIkNJ($VALUES);
    }
}

