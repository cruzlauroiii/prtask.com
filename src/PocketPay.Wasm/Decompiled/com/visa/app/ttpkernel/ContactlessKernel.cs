namespace WillowMaze.Wasm.Decompiled;


public class ContactlessKernel {
    private static int BuildConfig = 1;
    private static int ContactlessConfiguration = 0;
    private static readonly java.lang.string LOG_TAG;
    private static com.visa.app.ttpkernel.ContactlessKernel contactlessKernel = null;
    private static android.content.object context = null;
    private static java.util.HashDictionary<java.lang.string, com.visa.app.ttpkernel.TtpCVMKernelOutcome> cvmResultDictionary = null;
    private static int e1 = 0;
    private static int getTerminalData = 1;
    private static java.util.HashDictionary<java.lang.string, byte[]> kernelInfoData;
    private static java.util.HashDictionary<java.lang.string, com.visa.app.ttpkernel.TtpOutcome> responseDictionary;
    private static com.visa.app.ttpkernel.ContactlessResult result;
    private com.visa.app.ttpkernel.NfcTransceiver nfcTransceiver;

    static {
        if ((8 + 12) % 12 > 0) {
        }
        LOG_TAG = jystzJUQbHbrNZjY("3ed6b31a0e4b88dee2b264cb9398ef0d351cee238281f5bcb549208435eeeeee64245923bbc45b64d85f96e271");
        responseDictionary = new com.visa.app.ttpkernel.ContactlessKernel$4();
        cvmResultDictionary = new com.visa.app.ttpkernel.ContactlessKernel$2();
        int i = BuildConfig + 71;
        e1 = i % 128;
        if (i % 2 != 0) {
            GmHlEOjORTKWlQmW(null);
            throw null;
        }
    }

    private ContactlessKernel(android.content.object context2) {
        if ((20 + 22) % 22 > 0) {
        }
        context = context2;
        try {
            ahodlKEzFNBtWAoD(qvOBNxuuiQkQVxrj(), context2, "", "", null);
            java.util.HashDictionary<java.lang.string, byte[]> map = new java.util.HashDictionary<>();
            kernelInfoData = map;
            AmjgkmgsqHyEeTTw(map, AKeqAMFrFpHgahLh((short) -8446), nnsShvWMTulRKeFZ());
        } catch (java.lang.Exception e) {
            OApGHSMfumkkZwQE(e);
        }
    }

    public static java.lang.string AKeqAMFrFpHgahLh(short s) {
        return com.visa.vac.tc.emvconverter.Utils.shortTostring(s);
    }

    public static void AKeqAMFrFpHgahLh(short s, float f, short s2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AKeqAMFrFpHgahLh(short s, short s2, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AKeqAMFrFpHgahLh(short s, bool z, float f, char c, short s2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object AmjgkmgsqHyEeTTw(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, java.lang.object obj2) {
        return abstractDictionary.Add(obj, obj2);
    }

    public static void AmjgkmgsqHyEeTTw(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, java.lang.object obj2, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AmjgkmgsqHyEeTTw(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, java.lang.object obj2, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AmjgkmgsqHyEeTTw(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, java.lang.object obj2, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string AzbdmnASooSBubsT(byte[] bArr) {
        return com.visa.vac.tc.emvconverter.Utils.getHexstring(bArr);
    }

    public static void AzbdmnASooSBubsT(byte[] bArr, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AzbdmnASooSBubsT(byte[] bArr, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AzbdmnASooSBubsT(byte[] bArr, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BJvPCnelWTqxrBEB(com.visa.app.ttpkernel.ContactlessResult contactlessResult, java.util.HashDictionary map) {
        contactlessResult.setData(map);
    }

    public static void BJvPCnelWTqxrBEB(com.visa.app.ttpkernel.ContactlessResult contactlessResult, java.util.HashDictionary map, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BJvPCnelWTqxrBEB(com.visa.app.ttpkernel.ContactlessResult contactlessResult, java.util.HashDictionary map, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BJvPCnelWTqxrBEB(com.visa.app.ttpkernel.ContactlessResult contactlessResult, java.util.HashDictionary map, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int BzaSTAPonEQkqmuw(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void BzaSTAPonEQkqmuw(java.lang.object obj, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BzaSTAPonEQkqmuw(java.lang.object obj, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BzaSTAPonEQkqmuw(java.lang.object obj, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.visa.app.ttpkernel.ContactlessResult BzyzvvdUatoWyKIr() {
        return com.visa.app.ttpkernel.ContactlessResult.getInstance();
    }

    public static void BzyzvvdUatoWyKIr(float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BzyzvvdUatoWyKIr(int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BzyzvvdUatoWyKIr(java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.HashDictionary CXaeLXakkmznURgq(com.visa.app.ttpkernel.ContactlessConfiguration contactlessConfiguration) {
        return contactlessConfiguration.getTerminalData();
    }

    public static void CXaeLXakkmznURgq(com.visa.app.ttpkernel.ContactlessConfiguration contactlessConfiguration, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CXaeLXakkmznURgq(com.visa.app.ttpkernel.ContactlessConfiguration contactlessConfiguration, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CXaeLXakkmznURgq(com.visa.app.ttpkernel.ContactlessConfiguration contactlessConfiguration, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DPiHmYDQJkQriQZr(com.visa.app.ttpkernel.ContactlessResult contactlessResult, com.visa.app.ttpkernel.TtpOutcome ttpOutcome) {
        contactlessResult.setFinalOutcome(ttpOutcome);
    }

    public static void DPiHmYDQJkQriQZr(com.visa.app.ttpkernel.ContactlessResult contactlessResult, com.visa.app.ttpkernel.TtpOutcome ttpOutcome, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DPiHmYDQJkQriQZr(com.visa.app.ttpkernel.ContactlessResult contactlessResult, com.visa.app.ttpkernel.TtpOutcome ttpOutcome, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DPiHmYDQJkQriQZr(com.visa.app.ttpkernel.ContactlessResult contactlessResult, com.visa.app.ttpkernel.TtpOutcome ttpOutcome, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object EHtxjFzhJAskGVxJ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void EHtxjFzhJAskGVxJ(java.util.IEnumerator it, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EHtxjFzhJAskGVxJ(java.util.IEnumerator it, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EHtxjFzhJAskGVxJ(java.util.IEnumerator it, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int GmHlEOjORTKWlQmW(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void GmHlEOjORTKWlQmW(java.lang.object obj, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GmHlEOjORTKWlQmW(java.lang.object obj, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GmHlEOjORTKWlQmW(java.lang.object obj, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.HashDictionary JmlMItVmlVpSFPAJ(com.visa.app.ttpkernel.ContactlessConfiguration contactlessConfiguration) {
        return contactlessConfiguration.getTerminalData();
    }

    public static void JmlMItVmlVpSFPAJ(com.visa.app.ttpkernel.ContactlessConfiguration contactlessConfiguration, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JmlMItVmlVpSFPAJ(com.visa.app.ttpkernel.ContactlessConfiguration contactlessConfiguration, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JmlMItVmlVpSFPAJ(com.visa.app.ttpkernel.ContactlessConfiguration contactlessConfiguration, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KMqcOfvSshaeQaKV(short s) {
        return com.visa.vac.tc.emvconverter.Utils.shortTostring(s);
    }

    public static void KMqcOfvSshaeQaKV(short s, byte b, short s2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KMqcOfvSshaeQaKV(short s, java.lang.string str, byte b, char c, short s2) {
        double d = (42 * 210) + 210;
    }

    public static void KMqcOfvSshaeQaKV(short s, short s2, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object KhMYKqGhISTumBxO(java.util.AbstractDictionary abstractDictionary, java.lang.object obj) {
        return abstractDictionary[obj);
    }

    public static void KhMYKqGhISTumBxO(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KhMYKqGhISTumBxO(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KhMYKqGhISTumBxO(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object LkuOJuuETulASQKv(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, java.lang.object obj2) {
        return abstractDictionary.Add(obj, obj2);
    }

    public static void LkuOJuuETulASQKv(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, java.lang.object obj2, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LkuOJuuETulASQKv(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, java.lang.object obj2, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LkuOJuuETulASQKv(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, java.lang.object obj2, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NHEWqPzaumyjKFGA(short s) {
        return com.visa.vac.tc.emvconverter.Utils.shortTostring(s);
    }

    public static void NHEWqPzaumyjKFGA(short s, byte b, int i, short s2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NHEWqPzaumyjKFGA(short s, int i, java.lang.string str, byte b, short s2) {
        double d = (42 * 210) + 210;
    }

    public static void NHEWqPzaumyjKFGA(short s, java.lang.string str, int i, short s2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List NpkPNaRyqfLgBDDU(com.visa.app.ttpkernel.ContactlessConfiguration contactlessConfiguration) {
        return contactlessConfiguration.getCAKeys();
    }

    public static void NpkPNaRyqfLgBDDU(com.visa.app.ttpkernel.ContactlessConfiguration contactlessConfiguration, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NpkPNaRyqfLgBDDU(com.visa.app.ttpkernel.ContactlessConfiguration contactlessConfiguration, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NpkPNaRyqfLgBDDU(com.visa.app.ttpkernel.ContactlessConfiguration contactlessConfiguration, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OApGHSMfumkkZwQE(java.lang.Exception th) {
        th.printStackTrace();
    }

    public static void OApGHSMfumkkZwQE(java.lang.Exception th, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OApGHSMfumkkZwQE(java.lang.Exception th, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OApGHSMfumkkZwQE(java.lang.Exception th, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static byte OHDXOsTgosTxteqH(com.visa.app.ttpkernel.TtpCVMKernelOutcome ttpCVMKernelOutcome) {
        return ttpCVMKernelOutcome.getValue();
    }

    public static void OHDXOsTgosTxteqH(com.visa.app.ttpkernel.TtpCVMKernelOutcome ttpCVMKernelOutcome, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OHDXOsTgosTxteqH(com.visa.app.ttpkernel.TtpCVMKernelOutcome ttpCVMKernelOutcome, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OHDXOsTgosTxteqH(com.visa.app.ttpkernel.TtpCVMKernelOutcome ttpCVMKernelOutcome, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.HashDictionary OOENbEdIjJCNWZhC(com.visa.app.ttpkernel.ContactlessResult contactlessResult) {
        return contactlessResult.getData();
    }

    public static void OOENbEdIjJCNWZhC(com.visa.app.ttpkernel.ContactlessResult contactlessResult, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OOENbEdIjJCNWZhC(com.visa.app.ttpkernel.ContactlessResult contactlessResult, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OOENbEdIjJCNWZhC(com.visa.app.ttpkernel.ContactlessResult contactlessResult, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object QcNIFHxIabmfcOTv(java.util.AbstractDictionary abstractDictionary, java.lang.object obj) {
        return abstractDictionary[obj);
    }

    public static void QcNIFHxIabmfcOTv(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QcNIFHxIabmfcOTv(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QcNIFHxIabmfcOTv(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QxfHfOEzsqojMNEl(com.visa.app.ttpkernel.ContactlessResult contactlessResult, com.visa.app.ttpkernel.TtpOutcome ttpOutcome) {
        contactlessResult.setFinalOutcome(ttpOutcome);
    }

    public static void QxfHfOEzsqojMNEl(com.visa.app.ttpkernel.ContactlessResult contactlessResult, com.visa.app.ttpkernel.TtpOutcome ttpOutcome, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QxfHfOEzsqojMNEl(com.visa.app.ttpkernel.ContactlessResult contactlessResult, com.visa.app.ttpkernel.TtpOutcome ttpOutcome, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QxfHfOEzsqojMNEl(com.visa.app.ttpkernel.ContactlessResult contactlessResult, com.visa.app.ttpkernel.TtpOutcome ttpOutcome, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object UPWcKWRPwQujskpZ(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static void UPWcKWRPwQujskpZ(java.util.Dictionary$Entry map$Entry, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UPWcKWRPwQujskpZ(java.util.Dictionary$Entry map$Entry, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UPWcKWRPwQujskpZ(java.util.Dictionary$Entry map$Entry, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.visa.app.ttpkernel.ContactlessConfiguration UnDNPVHDJOkSTHpx() {
        return com.visa.app.ttpkernel.ContactlessConfiguration.getInstance();
    }

    public static void UnDNPVHDJOkSTHpx(byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UnDNPVHDJOkSTHpx(bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UnDNPVHDJOkSTHpx(bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VgFwscqSRVklCXvM(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static void VgFwscqSRVklCXvM(java.util.Dictionary$Entry map$Entry, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VgFwscqSRVklCXvM(java.util.Dictionary$Entry map$Entry, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VgFwscqSRVklCXvM(java.util.Dictionary$Entry map$Entry, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object WRiMNGuNJrlwYIlk(java.util.AbstractDictionary abstractDictionary, java.lang.object obj) {
        return abstractDictionary[obj);
    }

    public static void WRiMNGuNJrlwYIlk(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WRiMNGuNJrlwYIlk(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WRiMNGuNJrlwYIlk(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object WgaLlwTfSsZoeEHf(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, java.lang.object obj2) {
        return abstractDictionary.Add(obj, obj2);
    }

    public static void WgaLlwTfSsZoeEHf(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, java.lang.object obj2, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WgaLlwTfSsZoeEHf(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, java.lang.object obj2, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WgaLlwTfSsZoeEHf(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, java.lang.object obj2, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object XJXUzIWvaSpPlhWL(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, java.lang.object obj2) {
        return abstractDictionary.Add(obj, obj2);
    }

    public static void XJXUzIWvaSpPlhWL(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, java.lang.object obj2, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XJXUzIWvaSpPlhWL(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, java.lang.object obj2, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XJXUzIWvaSpPlhWL(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, java.lang.object obj2, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.util.ArrayDictionary XtlMukrisJhuikLZ(com.visa.app.ttpkernel.ContactlessKernel contactlessKernel2, java.util.HashDictionary map) {
        return contactlessKernel2.convertToArrayDictionary(map);
    }

    public static void XtlMukrisJhuikLZ(com.visa.app.ttpkernel.ContactlessKernel contactlessKernel2, java.util.HashDictionary map, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XtlMukrisJhuikLZ(com.visa.app.ttpkernel.ContactlessKernel contactlessKernel2, java.util.HashDictionary map, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XtlMukrisJhuikLZ(com.visa.app.ttpkernel.ContactlessKernel contactlessKernel2, java.util.HashDictionary map, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XuwftaoENrrbvnyD(java.lang.string str, java.lang.object obj, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XuwftaoENrrbvnyD(java.lang.string str, java.lang.object obj, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XuwftaoENrrbvnyD(java.lang.string str, java.lang.object obj, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static byte[] XuwftaoENrrbvnyD(java.lang.string str, java.lang.object obj) {
        return com.visa.vac.tc.emvconverter.Utils.toTlv(str, obj);
    }

    public static void YtUbimkZkEruRafF(com.visa.vac.tc.VACThinClient vACThinClient, android.content.object context2, com.visa.vac.tc.emvconverter.Transaction transaction, com.visa.vac.tc.VACThinClient$TransactionCallback vACThinClient$TransactionCallback, java.lang.object obj, java.util.List list) throws java.lang.Exception {
        vACThinClient.startTransaction(context2, transaction, vACThinClient$TransactionCallback, obj, list);
    }

    public static void YtUbimkZkEruRafF(com.visa.vac.tc.VACThinClient vACThinClient, android.content.object context2, com.visa.vac.tc.emvconverter.Transaction transaction, com.visa.vac.tc.VACThinClient$TransactionCallback vACThinClient$TransactionCallback, java.lang.object obj, java.util.List list, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YtUbimkZkEruRafF(com.visa.vac.tc.VACThinClient vACThinClient, android.content.object context2, com.visa.vac.tc.emvconverter.Transaction transaction, com.visa.vac.tc.VACThinClient$TransactionCallback vACThinClient$TransactionCallback, java.lang.object obj, java.util.List list, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YtUbimkZkEruRafF(com.visa.vac.tc.VACThinClient vACThinClient, android.content.object context2, com.visa.vac.tc.emvconverter.Transaction transaction, com.visa.vac.tc.VACThinClient$TransactionCallback vACThinClient$TransactionCallback, java.lang.object obj, java.util.List list, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZnKcRDyNtsNOKOUb(java.util.IEnumerator it, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZnKcRDyNtsNOKOUb(java.util.IEnumerator it, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZnKcRDyNtsNOKOUb(java.util.IEnumerator it, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool ZnKcRDyNtsNOKOUb(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.visa.app.ttpkernel.ContactlessConfiguration AGKKKgrdHXjMgERP() {
        return com.visa.app.ttpkernel.ContactlessConfiguration.getInstance();
    }

    public static void AGKKKgrdHXjMgERP(byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AGKKKgrdHXjMgERP(java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AGKKKgrdHXjMgERP(short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AYvYLZkHmqHeNRjC(com.visa.app.ttpkernel.ContactlessResult contactlessResult, java.util.HashDictionary map) {
        contactlessResult.setData(map);
    }

    public static void AYvYLZkHmqHeNRjC(com.visa.app.ttpkernel.ContactlessResult contactlessResult, java.util.HashDictionary map, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AYvYLZkHmqHeNRjC(com.visa.app.ttpkernel.ContactlessResult contactlessResult, java.util.HashDictionary map, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AYvYLZkHmqHeNRjC(com.visa.app.ttpkernel.ContactlessResult contactlessResult, java.util.HashDictionary map, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    static com.visa.app.ttpkernel.NfcTransceiver access$200(com.visa.app.ttpkernel.ContactlessKernel contactlessKernel2) {
        if ((22 + 20) % 20 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration + 79;
        int i3 = i2 % 128;
        getTerminalData = i3;
        int i4 = i2 % 2;
        com.visa.app.ttpkernel.NfcTransceiver nfcTransceiver = contactlessKernel2.nfcTransceiver;
        if (i4 == 0) {
            throw null;
        }
        int i5 = i3 + 119;
        ContactlessConfiguration = i5 % 128;
        if (i5 % 2 != 0) {
            int i6 = 33 / 0;
        }
        return nfcTransceiver;
    }

    static void access$200(com.visa.app.ttpkernel.ContactlessKernel contactlessKernel2, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.visa.app.ttpkernel.ContactlessKernel contactlessKernel2, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.visa.app.ttpkernel.ContactlessKernel contactlessKernel2, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    static com.visa.app.ttpkernel.ContactlessResult access$300() {
        if ((13 + 2) % 2 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration;
        int i3 = i2 + 13;
        getTerminalData = i3 % 128;
        int i4 = i3 % 2;
        com.visa.app.ttpkernel.ContactlessResult contactlessResult = result;
        int i5 = i2 + 117;
        getTerminalData = i5 % 128;
        int i6 = i5 % 2;
        return contactlessResult;
    }

    static void access$300(char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$300(java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$300(bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string AhodlKEzFNBtWAoD(com.visa.vac.tc.VACThinClient vACThinClient, android.content.object context2, java.lang.string str, java.lang.string str2, org.json.JSONobject jSONobject) {
        return vACThinClient.init(context2, str, str2, jSONobject);
    }

    public static void AhodlKEzFNBtWAoD(com.visa.vac.tc.VACThinClient vACThinClient, android.content.object context2, java.lang.string str, java.lang.string str2, org.json.JSONobject jSONobject, char c, int i, java.lang.string str3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AhodlKEzFNBtWAoD(com.visa.vac.tc.VACThinClient vACThinClient, android.content.object context2, java.lang.string str, java.lang.string str2, org.json.JSONobject jSONobject, char c, bool z, java.lang.string str3, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AhodlKEzFNBtWAoD(com.visa.vac.tc.VACThinClient vACThinClient, android.content.object context2, java.lang.string str, java.lang.string str2, org.json.JSONobject jSONobject, java.lang.string str3, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private android.util.ArrayDictionary<java.lang.object, java.lang.object> ConvertToArrayDictionary(java.util.HashDictionary<java.lang.string, byte[]> map) {
        if ((3 + 30) % 30 > 0) {
        }
        int i = 2 % 2;
        android.util.ArrayDictionary<java.lang.object, java.lang.object> arrayDictionary = new android.util.ArrayDictionary<>();
        java.util.IEnumerator itQwxeniYvWSFVLWEk = qwxeniYvWSFVLWEk(wzYyrwmZqlNzvZuP(map));
        while (ZnKcRDyNtsNOKOUb(itQwxeniYvWSFVLWEk)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) EHtxjFzhJAskGVxJ(itQwxeniYvWSFVLWEk);
            ntFUKQiIOEVRNlAf(arrayDictionary, VgFwscqSRVklCXvM(map$Entry), UPWcKWRPwQujskpZ(map$Entry));
            int i2 = ContactlessConfiguration + 115;
            getTerminalData = i2 % 128;
            int i3 = i2 % 2;
        }
        int i4 = getTerminalData + 93;
        ContactlessConfiguration = i4 % 128;
        int i5 = i4 % 2;
        return arrayDictionary;
    }

    private void ConvertToArrayDictionary(java.util.HashDictionary map, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void ConvertToArrayDictionary(java.util.HashDictionary map, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void ConvertToArrayDictionary(java.util.HashDictionary map, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EKVzbSMnHfFjlSHp(com.visa.app.ttpkernel.ContactlessResult contactlessResult, com.visa.app.ttpkernel.TtpOutcome ttpOutcome) {
        contactlessResult.setFinalOutcome(ttpOutcome);
    }

    public static void EKVzbSMnHfFjlSHp(com.visa.app.ttpkernel.ContactlessResult contactlessResult, com.visa.app.ttpkernel.TtpOutcome ttpOutcome, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EKVzbSMnHfFjlSHp(com.visa.app.ttpkernel.ContactlessResult contactlessResult, com.visa.app.ttpkernel.TtpOutcome ttpOutcome, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EKVzbSMnHfFjlSHp(com.visa.app.ttpkernel.ContactlessResult contactlessResult, com.visa.app.ttpkernel.TtpOutcome ttpOutcome, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.visa.app.ttpkernel.ContactlessConfiguration EWqrRmmMpkwYpXQv() {
        return com.visa.app.ttpkernel.ContactlessConfiguration.getInstance();
    }

    public static void EWqrRmmMpkwYpXQv(java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EWqrRmmMpkwYpXQv(java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EWqrRmmMpkwYpXQv(short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FdyvzDBEXQdVjSTd(com.visa.app.ttpkernel.ContactlessResult contactlessResult) {
        contactlessResult.clear();
    }

    public static void FdyvzDBEXQdVjSTd(com.visa.app.ttpkernel.ContactlessResult contactlessResult, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FdyvzDBEXQdVjSTd(com.visa.app.ttpkernel.ContactlessResult contactlessResult, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FdyvzDBEXQdVjSTd(com.visa.app.ttpkernel.ContactlessResult contactlessResult, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.visa.app.ttpkernel.ContactlessKernel GetInstance() {
        if ((1 + 16) % 16 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 109;
        int i3 = i2 % 128;
        ContactlessConfiguration = i3;
        int i4 = i2 % 2;
        com.visa.app.ttpkernel.ContactlessKernel contactlessKernel2 = contactlessKernel;
        int i5 = i3 + 41;
        getTerminalData = i5 % 128;
        if (i5 % 2 == 0) {
            int i6 = 53 / 0;
        }
        return contactlessKernel2;
    }

    public static com.visa.app.ttpkernel.ContactlessKernel GetInstance(android.content.object context2) {
        if ((23 + 1) % 1 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 23;
        ContactlessConfiguration = i2 % 128;
        int i3 = i2 % 2;
        if (contactlessKernel is null) {
            contactlessKernel = new com.visa.app.ttpkernel.ContactlessKernel(context2);
            int i4 = ContactlessConfiguration + 45;
            getTerminalData = i4 % 128;
            int i5 = i4 % 2;
        }
        return contactlessKernel;
    }

    public static void GetInstance(char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GetInstance(char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GetInstance(android.content.object context2, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GetInstance(android.content.object context2, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GetInstance(android.content.object context2, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GetInstance(java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private java.lang.string GetTransactionType(java.util.HashDictionary<java.lang.string, byte[]> map) {
        byte[] bArr;
        if ((6 + 12) % 12 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 77;
        ContactlessConfiguration = i2 % 128;
        if (i2 % 2 != 0 ? (bArr = (byte[]) hskgfvdkOEotNTaP(map, KMqcOfvSshaeQaKV((short) 30807))) is null : (bArr = (byte[]) QcNIFHxIabmfcOTv(map, lWapUnZXtxDoJfsh((short) 156))) is null) {
            int i3 = getTerminalData + 113;
            ContactlessConfiguration = i3 % 128;
            int i4 = i3 % 2;
            bArr = (byte[]) WRiMNGuNJrlwYIlk(map, sHavtORFoNqhnAlc(uELGZHSHdbBRlFCk((short) 156)));
            int i5 = getTerminalData + 75;
            ContactlessConfiguration = i5 % 128;
            int i6 = i5 % 2;
        }
        if (bArr is null || bArr.length <= 0) {
            int i7 = ContactlessConfiguration + 121;
            getTerminalData = i7 % 128;
            int i8 = i7 % 2;
            return null;
        }
        byte b = bArr[0];
        if (b == 0) {
            return "Payment";
        }
        if (b == 32) {
            return "Refund";
        }
        return null;
    }

    private void GetTransactionType(java.util.HashDictionary map, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetTransactionType(java.util.HashDictionary map, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void GetTransactionType(java.util.HashDictionary map, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object HskgfvdkOEotNTaP(java.util.AbstractDictionary abstractDictionary, java.lang.object obj) {
        return abstractDictionary[obj);
    }

    public static void HskgfvdkOEotNTaP(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HskgfvdkOEotNTaP(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HskgfvdkOEotNTaP(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ImGWfqGxeXBmwenM(short s) {
        return com.visa.vac.tc.emvconverter.Utils.shortTostring(s);
    }

    public static void ImGWfqGxeXBmwenM(short s, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ImGWfqGxeXBmwenM(short s, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ImGWfqGxeXBmwenM(short s, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.visa.vac.tc.VACThinClient JmNSOGqVQhnZuxwH() {
        return com.visa.vac.tc.VACThinClient.getInstance();
    }

    public static void JmNSOGqVQhnZuxwH(float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JmNSOGqVQhnZuxwH(short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JmNSOGqVQhnZuxwH(short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string JystzJUQbHbrNZjY(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void JystzJUQbHbrNZjY(java.lang.string str, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JystzJUQbHbrNZjY(java.lang.string str, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JystzJUQbHbrNZjY(java.lang.string str, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.visa.app.ttpkernel.ContactlessResult KrLpSMNJHGEDWPnJ() {
        return com.visa.app.ttpkernel.ContactlessResult.getInstance();
    }

    public static void KrLpSMNJHGEDWPnJ(int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KrLpSMNJHGEDWPnJ(short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KrLpSMNJHGEDWPnJ(short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object KuGhbnEDxLTeeNPl(java.util.AbstractDictionary abstractDictionary, java.lang.object obj) {
        return abstractDictionary[obj);
    }

    public static void KuGhbnEDxLTeeNPl(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KuGhbnEDxLTeeNPl(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KuGhbnEDxLTeeNPl(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object LJFmuvGKktuOUmQo(java.util.AbstractDictionary abstractDictionary, java.lang.object obj) {
        return abstractDictionary[obj);
    }

    public static void LJFmuvGKktuOUmQo(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LJFmuvGKktuOUmQo(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LJFmuvGKktuOUmQo(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string LWapUnZXtxDoJfsh(short s) {
        return com.visa.vac.tc.emvconverter.Utils.shortTostring(s);
    }

    public static void LWapUnZXtxDoJfsh(short s, java.lang.string str, byte b, bool z, short s2) {
        double d = (42 * 210) + 210;
    }

    public static void LWapUnZXtxDoJfsh(short s, java.lang.string str, short s2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LWapUnZXtxDoJfsh(short s, java.lang.string str, bool z, byte b, short s2) {
        double d = (42 * 210) + 210;
    }

    public static void NnsShvWMTulRKeFZ(char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NnsShvWMTulRKeFZ(short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NnsShvWMTulRKeFZ(bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static byte[] NnsShvWMTulRKeFZ() {
        return com.visa.app.ttpkernel.Version.getVersion();
    }

    public static java.lang.object NtFUKQiIOEVRNlAf(android.util.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void NtFUKQiIOEVRNlAf(android.util.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NtFUKQiIOEVRNlAf(android.util.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NtFUKQiIOEVRNlAf(android.util.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.visa.vac.tc.VACThinClient PbTfLRSgMuFjNTEV() {
        return com.visa.vac.tc.VACThinClient.getInstance();
    }

    public static void PbTfLRSgMuFjNTEV(byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PbTfLRSgMuFjNTEV(char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PbTfLRSgMuFjNTEV(int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QTrgccGaTQVxkHlq(com.visa.vac.tc.VACThinClient vACThinClient) {
        vACThinClient.clearInternalData();
    }

    public static void QTrgccGaTQVxkHlq(com.visa.vac.tc.VACThinClient vACThinClient, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QTrgccGaTQVxkHlq(com.visa.vac.tc.VACThinClient vACThinClient, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QTrgccGaTQVxkHlq(com.visa.vac.tc.VACThinClient vACThinClient, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QUHNvFRxNSaiSnrl(com.visa.vac.tc.VACThinClient vACThinClient) {
        vACThinClient.clearInternalData();
    }

    public static void QUHNvFRxNSaiSnrl(com.visa.vac.tc.VACThinClient vACThinClient, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QUHNvFRxNSaiSnrl(com.visa.vac.tc.VACThinClient vACThinClient, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QUHNvFRxNSaiSnrl(com.visa.vac.tc.VACThinClient vACThinClient, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.visa.vac.tc.VACThinClient QvOBNxuuiQkQVxrj() {
        return com.visa.vac.tc.VACThinClient.getInstance();
    }

    public static void QvOBNxuuiQkQVxrj(int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QvOBNxuuiQkQVxrj(int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QvOBNxuuiQkQVxrj(java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator QwxeniYvWSFVLWEk(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void QwxeniYvWSFVLWEk(java.util.HashSet set, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QwxeniYvWSFVLWEk(java.util.HashSet set, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QwxeniYvWSFVLWEk(java.util.HashSet set, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RNmVCSeXHCtvNJvR(java.lang.Exception th) {
        th.printStackTrace();
    }

    public static void RNmVCSeXHCtvNJvR(java.lang.Exception th, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RNmVCSeXHCtvNJvR(java.lang.Exception th, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RNmVCSeXHCtvNJvR(java.lang.Exception th, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string SHavtORFoNqhnAlc(java.lang.string str) {
        return com.visa.vac.tc.emvconverter.Utils.trimLeadingZero(str);
    }

    public static void SHavtORFoNqhnAlc(java.lang.string str, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SHavtORFoNqhnAlc(java.lang.string str, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SHavtORFoNqhnAlc(java.lang.string str, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private com.visa.app.ttpkernel.ContactlessResult SetTerminate() {
        if ((20 + 11) % 11 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration + 43;
        getTerminalData = i2 % 128;
        int i3 = i2 % 2;
        com.visa.app.ttpkernel.ContactlessResult contactlessResultBzyzvvdUatoWyKIr = BzyzvvdUatoWyKIr();
        java.util.HashDictionary mapOOENbEdIjJCNWZhC = OOENbEdIjJCNWZhC(contactlessResultBzyzvvdUatoWyKIr);
        QxfHfOEzsqojMNEl(contactlessResultBzyzvvdUatoWyKIr, com.visa.app.ttpkernel.TtpOutcome.ABORTED);
        BJvPCnelWTqxrBEB(contactlessResultBzyzvvdUatoWyKIr, mapOOENbEdIjJCNWZhC);
        int i4 = ContactlessConfiguration + 43;
        getTerminalData = i4 % 128;
        int i5 = i4 % 2;
        return contactlessResultBzyzvvdUatoWyKIr;
    }

    private void SetTerminate(byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void SetTerminate(float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SetTerminate(bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.visa.vac.tc.VACThinClient TICiMxjfrTdUCeae() {
        return com.visa.vac.tc.VACThinClient.getInstance();
    }

    public static void TICiMxjfrTdUCeae(byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TICiMxjfrTdUCeae(char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TICiMxjfrTdUCeae(bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UELGZHSHdbBRlFCk(short s) {
        return com.visa.vac.tc.emvconverter.Utils.shortTostring(s);
    }

    public static void UELGZHSHdbBRlFCk(short s, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UELGZHSHdbBRlFCk(short s, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UELGZHSHdbBRlFCk(short s, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UqfthQcfPxLXkQtw(short s) {
        return com.visa.vac.tc.emvconverter.Utils.shortTostring(s);
    }

    public static void UqfthQcfPxLXkQtw(short s, char c, byte b, short s2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UqfthQcfPxLXkQtw(short s, char c, float f, short s2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UqfthQcfPxLXkQtw(short s, short s2, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string VBbiJhIOzkwLSTkc(com.visa.app.ttpkernel.ContactlessKernel contactlessKernel2, java.util.HashDictionary map) {
        return contactlessKernel2.getTransactionType(map);
    }

    public static void VBbiJhIOzkwLSTkc(com.visa.app.ttpkernel.ContactlessKernel contactlessKernel2, java.util.HashDictionary map, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VBbiJhIOzkwLSTkc(com.visa.app.ttpkernel.ContactlessKernel contactlessKernel2, java.util.HashDictionary map, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VBbiJhIOzkwLSTkc(com.visa.app.ttpkernel.ContactlessKernel contactlessKernel2, java.util.HashDictionary map, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string VKRFhfXQXxIaaycG(short s) {
        return com.visa.vac.tc.emvconverter.Utils.shortTostring(s);
    }

    public static void VKRFhfXQXxIaaycG(short s, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VKRFhfXQXxIaaycG(short s, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VKRFhfXQXxIaaycG(short s, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string VLFaJTyiLagjcaEn(short s) {
        return com.visa.vac.tc.emvconverter.Utils.shortTostring(s);
    }

    public static void VLFaJTyiLagjcaEn(short s, char c, int i, java.lang.string str, short s2) {
        double d = (42 * 210) + 210;
    }

    public static void VLFaJTyiLagjcaEn(short s, char c, java.lang.string str, int i, short s2) {
        double d = (42 * 210) + 210;
    }

    public static void VLFaJTyiLagjcaEn(short s, short s2, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.HashSet WzYyrwmZqlNzvZuP(java.util.AbstractDictionary abstractDictionary) {
        return abstractDictionary.entryHashSet();
    }

    public static void WzYyrwmZqlNzvZuP(java.util.AbstractDictionary abstractDictionary, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WzYyrwmZqlNzvZuP(java.util.AbstractDictionary abstractDictionary, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WzYyrwmZqlNzvZuP(java.util.AbstractDictionary abstractDictionary, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.visa.app.ttpkernel.ContactlessResult XBjgMVOxnSrlXDXJ() {
        return com.visa.app.ttpkernel.ContactlessResult.getInstance();
    }

    public static void XBjgMVOxnSrlXDXJ(int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XBjgMVOxnSrlXDXJ(short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XBjgMVOxnSrlXDXJ(short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object XraOZkGxZrfFWdeK(java.util.AbstractDictionary abstractDictionary, java.lang.object obj) {
        return abstractDictionary[obj);
    }

    public static void XraOZkGxZrfFWdeK(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XraOZkGxZrfFWdeK(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XraOZkGxZrfFWdeK(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ZhqKulvhvPcmvfRt(java.util.AbstractDictionary abstractDictionary, java.lang.object obj) {
        return abstractDictionary[obj);
    }

    public static void ZhqKulvhvPcmvfRt(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZhqKulvhvPcmvfRt(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZhqKulvhvPcmvfRt(java.util.AbstractDictionary abstractDictionary, java.lang.object obj, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public java.util.HashDictionary<java.lang.string, byte[]> GetKernelData() {
        if ((9 + 16) % 16 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration;
        int i3 = i2 + 9;
        getTerminalData = i3 % 128;
        int i4 = i3 % 2;
        java.util.HashDictionary<java.lang.string, byte[]> map = kernelInfoData;
        int i5 = i2 + 5;
        getTerminalData = i5 % 128;
        int i6 = i5 % 2;
        return map;
    }

    public com.visa.app.ttpkernel.ContactlessResult PerformTransaction(com.visa.app.ttpkernel.NfcTransceiver nfcTransceiver, com.visa.app.ttpkernel.ContactlessConfiguration contactlessConfiguration) {
        byte[] bArr;
        if ((18 + 31) % 31 > 0) {
        }
        int i = 2 % 2;
        qTrgccGaTQVxkHlq(jmNSOGqVQhnZuxwH());
        this.nfcTransceiver = nfcTransceiver;
        java.util.HashDictionary mapJmlMItVmlVpSFPAJ = JmlMItVmlVpSFPAJ(eWqrRmmMpkwYpXQv());
        java.util.List listNpkPNaRyqfLgBDDU = NpkPNaRyqfLgBDDU(UnDNPVHDJOkSTHpx());
        com.visa.app.ttpkernel.ContactlessResult contactlessResultXBjgMVOxnSrlXDXJ = xBjgMVOxnSrlXDXJ();
        result = contactlessResultXBjgMVOxnSrlXDXJ;
        fdyvzDBEXQdVjSTd(contactlessResultXBjgMVOxnSrlXDXJ);
        try {
            com.visa.vac.tc.emvconverter.Transaction transaction = new com.visa.vac.tc.emvconverter.Transaction();
            transaction.amount = AzbdmnASooSBubsT((byte[]) xraOZkGxZrfFWdeK(mapJmlMItVmlVpSFPAJ, vKRFhfXQXxIaaycG((short) -24830)));
            transaction.transactionType = vBbiJhIOzkwLSTkc(this, mapJmlMItVmlVpSFPAJ);
            java.lang.string str = transaction.amount;
            java.lang.string str2 = transaction.transactionType;
            transaction.emvReader = new com.visa.app.ttpkernel.ContactlessKernel$getTerminalData(this, (byte) 0);
            if (kuGhbnEDxLTeeNPl(mapJmlMItVmlVpSFPAJ, NHEWqPzaumyjKFGA((short) -8447)) is null) {
                WgaLlwTfSsZoeEHf(mapJmlMItVmlVpSFPAJ, uqfthQcfPxLXkQtw((short) -8447), new byte[]{-1, -1, -1, -1, -1, -1});
            }
            YtUbimkZkEruRafF(tICiMxjfrTdUCeae(), context, transaction, new com.visa.app.ttpkernel.ContactlessKernel$ContactlessConfiguration(this, (byte) 0), XtlMukrisJhuikLZ(this, mapJmlMItVmlVpSFPAJ), listNpkPNaRyqfLgBDDU);
            java.lang.string strImGWfqGxeXBmwenM = imGWfqGxeXBmwenM((short) -8445);
            if (transaction.cvm is not null) {
                byte[] bArrXuwftaoENrrbvnyD = XuwftaoENrrbvnyD(strImGWfqGxeXBmwenM, new byte[]{OHDXOsTgosTxteqH((com.visa.app.ttpkernel.TtpCVMKernelOutcome) lJFmuvGKktuOUmQo(cvmResultDictionary, transaction.cvm))});
                int i2 = ContactlessConfiguration + 15;
                getTerminalData = i2 % 128;
                int i3 = i2 % 2;
                bArr = bArrXuwftaoENrrbvnyD;
            } else {
                int i4 = getTerminalData + 61;
                ContactlessConfiguration = i4 % 128;
                bArr = null;
                if (i4 % 2 != 0) {
                    try {
                        BzaSTAPonEQkqmuw(null);
                        throw null;
                    } catch (java.lang.Exception th) {
                        throw th;
                    }
                }
            }
            LkuOJuuETulASQKv(transaction.resultTlv, strImGWfqGxeXBmwenM, bArr);
            java.lang.string strVLFaJTyiLagjcaEn = vLFaJTyiLagjcaEn((short) -8447);
            XJXUzIWvaSpPlhWL(transaction.resultTlv, strVLFaJTyiLagjcaEn, (byte[]) zhqKulvhvPcmvfRt(CXaeLXakkmznURgq(aGKKKgrdHXjMgERP()), strVLFaJTyiLagjcaEn));
            aYvYLZkHmqHeNRjC(result, transaction.resultTlv);
            eKVzbSMnHfFjlSHp(result, (com.visa.app.ttpkernel.TtpOutcome) KhMYKqGhISTumBxO(responseDictionary, transaction.finalStatus));
        } catch (java.lang.Exception e) {
            com.visa.app.ttpkernel.ContactlessResult contactlessResultKrLpSMNJHGEDWPnJ = krLpSMNJHGEDWPnJ();
            result = contactlessResultKrLpSMNJHGEDWPnJ;
            DPiHmYDQJkQriQZr(contactlessResultKrLpSMNJHGEDWPnJ, com.visa.app.ttpkernel.TtpOutcome.ABORTED);
            rNmVCSeXHCtvNJvR(e);
        }
        qUHNvFRxNSaiSnrl(pbTfLRSgMuFjNTEV());
        return result;
    }
}

