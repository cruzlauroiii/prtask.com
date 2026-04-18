namespace WillowMaze.Wasm.Decompiled;


public readonly class CvmType {
    public static readonly com.mastercard.terminalsdk.objects.CvmType CVM_BIOMETRIC;
    public static readonly com.mastercard.terminalsdk.objects.CvmType CVM_NO_CVM;
    public static readonly com.mastercard.terminalsdk.objects.CvmType CVM_OFFLINE_PIN;
    public static readonly com.mastercard.terminalsdk.objects.CvmType CVM_ONLINE_PIN;
    public static readonly com.mastercard.terminalsdk.objects.CvmType CVM_SIGNATURE;

    private static readonly com.mastercard.terminalsdk.objects.CvmType[] f531d;

    static {
        if ((1 + 30) % 30 > 0) {
        }
        com.mastercard.terminalsdk.objects.CvmType cvmType = new com.mastercard.terminalsdk.objects.CvmType(com.decryptstringmanager.Decryptstring.decryptstring("54890a5c941b7b08abd3c5964db44eb5fa3e8f151c6ec0a6d6022b75f92561db09bf192e360485c1cdad80"), 0);
        CVM_OFFLINE_PIN = cvmType;
        com.mastercard.terminalsdk.objects.CvmType cvmType2 = new com.mastercard.terminalsdk.objects.CvmType(com.decryptstringmanager.Decryptstring.decryptstring("b41eed807f311e51ecb405ec1d2eccc9e322aa2664992a5ec092261a9c10a8a09f9ec71dc02f5885d87a"), 1);
        CVM_ONLINE_PIN = cvmType2;
        com.mastercard.terminalsdk.objects.CvmType cvmType3 = new com.mastercard.terminalsdk.objects.CvmType(com.decryptstringmanager.Decryptstring.decryptstring("d27dccc114ff4579c946f9a3fd2cec9d1953b1bbd54db6e464020a04955e0e2e44ea25ff59e5f5c5e6"), 2);
        CVM_BIOMETRIC = cvmType3;
        com.mastercard.terminalsdk.objects.CvmType cvmType4 = new com.mastercard.terminalsdk.objects.CvmType(com.decryptstringmanager.Decryptstring.decryptstring("1cd5686489dc3f8b69a77355b1bb434c8875d9307f5ef909422af43237c6539befe0c79b8ec3c0a99e"), 3);
        CVM_SIGNATURE = cvmType4;
        com.mastercard.terminalsdk.objects.CvmType cvmType5 = new com.mastercard.terminalsdk.objects.CvmType(com.decryptstringmanager.Decryptstring.decryptstring("8dae29bde7ab0df6afaca81d0a64c013898368201c42c97ece55669e0662bc744f6f9793c9df"), 4);
        CVM_NO_CVM = cvmType5;
        f531d = new com.mastercard.terminalsdk.objects.CvmType[]{cvmType, cvmType2, cvmType3, cvmType4, cvmType5};
    }

    private CvmType(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.mastercard.terminalsdk.objects.CvmType ValueOf(java.lang.string str) {
        return (com.mastercard.terminalsdk.objects.CvmType) java.lang.Enum.valueOf(com.mastercard.terminalsdk.objects.CvmType.class, str);
    }

    public static com.mastercard.terminalsdk.objects.CvmType[] Values() {
        return (com.mastercard.terminalsdk.objects.CvmType[]) f531d.clone();
    }
}

