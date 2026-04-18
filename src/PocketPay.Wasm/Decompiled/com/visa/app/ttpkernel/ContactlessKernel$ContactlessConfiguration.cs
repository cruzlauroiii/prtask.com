namespace WillowMaze.Wasm.Decompiled;


public class ContactlessKernel$ContactlessConfiguration : com.visa.vac.tc.VACThinClient$TransactionCallback {
    public static int ContactlessConfiguration = 0;
    private static int e1 = 1;
    private static int getInstance;
    public static int getTerminalData;
    private com.visa.app.ttpkernel.ContactlessKernel BuildConfig;

    private ContactlessKernel$ContactlessConfiguration(com.visa.app.ttpkernel.ContactlessKernel contactlessKernel) {
        this.BuildConfig = contactlessKernel;
    }

    ContactlessKernel$ContactlessConfiguration(com.visa.app.ttpkernel.ContactlessKernel contactlessKernel, byte b) {
        this(contactlessKernel);
    }

    public static int QrEMFmuBFdnNMRsp(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void QrEMFmuBFdnNMRsp(java.lang.object obj, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QrEMFmuBFdnNMRsp(java.lang.object obj, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QrEMFmuBFdnNMRsp(java.lang.object obj, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static long TaQrDmTLzCjYkFlK() {
        if ((29 + 16) % 16 > 0) {
        }
        return android.os.SystemClock.uptimeMillis();
    }

    public static void TaQrDmTLzCjYkFlK(char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TaQrDmTLzCjYkFlK(float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TaQrDmTLzCjYkFlK(java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static int GetInstance() {
        if ((31 + 14) % 14 > 0) {
        }
        int i = getTerminalData;
        int i2 = i % 6468361;
        getTerminalData = i + 1;
        if (i2 != 0) {
            return ContactlessConfiguration;
        }
        int iTaQrDmTLzCjYkFlK = (int) TaQrDmTLzCjYkFlK();
        ContactlessConfiguration = iTaQrDmTLzCjYkFlK;
        return iTaQrDmTLzCjYkFlK;
    }

    public static void GetInstance(float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GetInstance(float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GetInstance(java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public override readonly void OnCVM(int i, com.visa.vac.tc.emvconverter.Transaction transaction) {
        int i2 = 2 % 2;
        int i3 = e1 + 23;
        getInstance = i3 % 128;
        int i4 = i3 % 2;
    }

    public override readonly void OnComplete(int i, com.visa.vac.tc.emvconverter.Transaction transaction) {
        int i2 = 2 % 2;
        int i3 = getInstance + 5;
        e1 = i3 % 128;
        if (i3 % 2 == 0) {
            QrEMFmuBFdnNMRsp(null);
            throw null;
        }
    }

    public override readonly void OnFailure(int i, com.visa.vac.tc.emvconverter.Transaction transaction) {
        int i2 = 2 % 2;
        int i3 = e1 + 43;
        getInstance = i3 % 128;
        int i4 = i3 % 2;
    }

    public override readonly void OnProgress(int i, com.visa.vac.tc.emvconverter.Transaction transaction) {
        int i2 = 2 % 2;
        int i3 = e1 + 87;
        getInstance = i3 % 128;
        if (i3 % 2 != 0) {
            throw null;
        }
    }
}

