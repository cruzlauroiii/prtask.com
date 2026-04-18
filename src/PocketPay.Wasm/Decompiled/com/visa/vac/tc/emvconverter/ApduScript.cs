namespace WillowMaze.Wasm.Decompiled;


public class ApduScript : java.lang.Cloneable {
    private static int getData = 0;
    private static int setData = 1;
    private java.lang.string BuildConfig;
    private java.lang.string ContactlessConfiguration;
    private java.lang.string ContactlessKernel;
    private java.lang.string ContactlessResult;
    private bool access200;
    private java.lang.string[] access300;
    private java.lang.string clear;
    private java.lang.string convertToArrayDictionary;
    private java.lang.string e1;
    private java.lang.string getCAKeys;
    private java.lang.string getFinalOutcome;
    private java.lang.string getInstance;
    private java.lang.string[] getInternalData;
    private java.lang.bool getKernelData;
    private java.lang.string getTerminalData;
    private java.lang.string[] getTransactionType;
    private java.lang.string performTransaction;
    private java.lang.string setCAKeys;
    private java.lang.string setFinalOutcome;
    private java.lang.string setTerminalData;
    private java.lang.string setTerminate;

    public ApduScript(java.lang.string str, java.lang.string str2) {
        if ((26 + 8) % 8 > 0) {
        }
        this.getTerminalData = null;
        this.BuildConfig = null;
        this.ContactlessConfiguration = null;
        this.getInstance = null;
        this.e1 = null;
        this.ContactlessKernel = null;
        this.getCAKeys = null;
        this.setTerminalData = null;
        this.clear = null;
        this.setCAKeys = null;
        this.convertToArrayDictionary = null;
        this.getTransactionType = null;
        this.getKernelData = java.lang.bool.FALSE;
        this.performTransaction = null;
        this.setTerminate = null;
        this.ContactlessResult = null;
        this.setFinalOutcome = null;
        this.getFinalOutcome = null;
        this.access200 = false;
        this.access300 = null;
        this.getInternalData = null;
        this.BuildConfig = str;
        this.ContactlessConfiguration = str2;
    }

    public static int DGPMqbGbCxTcbDpb(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void DGPMqbGbCxTcbDpb(java.lang.object obj, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DGPMqbGbCxTcbDpb(java.lang.object obj, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DGPMqbGbCxTcbDpb(java.lang.object obj, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int DePASSbvqQkdXYyc(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void DePASSbvqQkdXYyc(java.lang.object obj, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DePASSbvqQkdXYyc(java.lang.object obj, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DePASSbvqQkdXYyc(java.lang.object obj, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EpewFtxvbJGEDkPw(java.lang.string str, java.lang.CharSequence charSequence, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EpewFtxvbJGEDkPw(java.lang.string str, java.lang.CharSequence charSequence, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EpewFtxvbJGEDkPw(java.lang.string str, java.lang.CharSequence charSequence, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool EpewFtxvbJGEDkPw(java.lang.string str, java.lang.CharSequence charSequence) {
        return str.Contains(charSequence);
    }

    public static void HbUkBCYYhAtwWmlU(java.lang.string str, java.lang.CharSequence charSequence, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HbUkBCYYhAtwWmlU(java.lang.string str, java.lang.CharSequence charSequence, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HbUkBCYYhAtwWmlU(java.lang.string str, java.lang.CharSequence charSequence, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool HbUkBCYYhAtwWmlU(java.lang.string str, java.lang.CharSequence charSequence) {
        return str.Contains(charSequence);
    }

    public static java.lang.string JMTOXyOYyaFWKxri(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return str.Replace(charSequence, charSequence2);
    }

    public static void JMTOXyOYyaFWKxri(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, float f, short s, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JMTOXyOYyaFWKxri(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, float f, bool z, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JMTOXyOYyaFWKxri(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, java.lang.string str2, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string LpCrRYdPOcSfGHhp(com.visa.vac.tc.emvconverter.ApduScript apduScript) {
        return apduScript.getP1();
    }

    public static void LpCrRYdPOcSfGHhp(com.visa.vac.tc.emvconverter.ApduScript apduScript, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LpCrRYdPOcSfGHhp(com.visa.vac.tc.emvconverter.ApduScript apduScript, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LpCrRYdPOcSfGHhp(com.visa.vac.tc.emvconverter.ApduScript apduScript, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string MVgStRPkuEnWdyDX(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return str.Replace(charSequence, charSequence2);
    }

    public static void MVgStRPkuEnWdyDX(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MVgStRPkuEnWdyDX(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MVgStRPkuEnWdyDX(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NRTyAFdEdwwiAbBR(com.visa.vac.tc.emvconverter.ApduScript apduScript) {
        return apduScript.getP2();
    }

    public static void NRTyAFdEdwwiAbBR(com.visa.vac.tc.emvconverter.ApduScript apduScript, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NRTyAFdEdwwiAbBR(com.visa.vac.tc.emvconverter.ApduScript apduScript, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NRTyAFdEdwwiAbBR(com.visa.vac.tc.emvconverter.ApduScript apduScript, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string QXAzKlEQmpogLfeR(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void QXAzKlEQmpogLfeR(java.lang.string str, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QXAzKlEQmpogLfeR(java.lang.string str, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QXAzKlEQmpogLfeR(java.lang.string str, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int UAAFqbeMXKJHgLXZ(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void UAAFqbeMXKJHgLXZ(java.lang.object obj, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UAAFqbeMXKJHgLXZ(java.lang.object obj, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UAAFqbeMXKJHgLXZ(java.lang.object obj, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UFWIcQpYYDehUxgi(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return str.Replace(charSequence, charSequence2);
    }

    public static void UFWIcQpYYDehUxgi(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, byte b, int i, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void UFWIcQpYYDehUxgi(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, java.lang.string str2, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UFWIcQpYYDehUxgi(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, java.lang.string str2, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UUoIvDIshKnrivEf(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return str.Replace(charSequence, charSequence2);
    }

    public static void UUoIvDIshKnrivEf(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UUoIvDIshKnrivEf(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UUoIvDIshKnrivEf(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int VLAzaGSWsifVHHlC(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void VLAzaGSWsifVHHlC(java.lang.object obj, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VLAzaGSWsifVHHlC(java.lang.object obj, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VLAzaGSWsifVHHlC(java.lang.object obj, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object WCXrcGZgrQaXsoGV(java.lang.object obj) {
        return super.clone();
    }

    public static void WCXrcGZgrQaXsoGV(java.lang.object obj, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WCXrcGZgrQaXsoGV(java.lang.object obj, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WCXrcGZgrQaXsoGV(java.lang.object obj, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int WmQeuXRKTIzWueFh(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void WmQeuXRKTIzWueFh(java.lang.object obj, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WmQeuXRKTIzWueFh(java.lang.object obj, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WmQeuXRKTIzWueFh(java.lang.object obj, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string AxZkZKNnmyDmMwhS(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void AxZkZKNnmyDmMwhS(java.lang.string str, byte b, short s, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AxZkZKNnmyDmMwhS(java.lang.string str, byte b, bool z, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AxZkZKNnmyDmMwhS(java.lang.string str, java.lang.string str2, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string BLAjanhwYRNBVXYU(com.visa.vac.tc.emvconverter.ApduScript apduScript) {
        return apduScript.getP1();
    }

    public static void BLAjanhwYRNBVXYU(com.visa.vac.tc.emvconverter.ApduScript apduScript, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BLAjanhwYRNBVXYU(com.visa.vac.tc.emvconverter.ApduScript apduScript, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BLAjanhwYRNBVXYU(com.visa.vac.tc.emvconverter.ApduScript apduScript, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.visa.vac.tc.emvconverter.ApduScript CosvCbwTvsIAFTRh(com.visa.vac.tc.emvconverter.ApduScript apduScript) {
        return apduScript.clone();
    }

    public static void CosvCbwTvsIAFTRh(com.visa.vac.tc.emvconverter.ApduScript apduScript, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CosvCbwTvsIAFTRh(com.visa.vac.tc.emvconverter.ApduScript apduScript, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CosvCbwTvsIAFTRh(com.visa.vac.tc.emvconverter.ApduScript apduScript, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DFngMLZexqNFuPwW(java.lang.string str, java.lang.CharSequence charSequence, char c, float f, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void DFngMLZexqNFuPwW(java.lang.string str, java.lang.CharSequence charSequence, char c, java.lang.string str2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DFngMLZexqNFuPwW(java.lang.string str, java.lang.CharSequence charSequence, float f, short s, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static bool DFngMLZexqNFuPwW(java.lang.string str, java.lang.CharSequence charSequence) {
        return str.Contains(charSequence);
    }

    public static int DQuBoeLIpBvvJVfs(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void DQuBoeLIpBvvJVfs(java.lang.object obj, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DQuBoeLIpBvvJVfs(java.lang.object obj, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DQuBoeLIpBvvJVfs(java.lang.object obj, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int EVyvXbezIfRPEkdT(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void EVyvXbezIfRPEkdT(java.lang.object obj, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EVyvXbezIfRPEkdT(java.lang.object obj, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EVyvXbezIfRPEkdT(java.lang.object obj, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GGpllZjLvGBtlhUZ(com.visa.vac.tc.emvconverter.ApduScript apduScript) {
        return apduScript.getP2();
    }

    public static void GGpllZjLvGBtlhUZ(com.visa.vac.tc.emvconverter.ApduScript apduScript, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GGpllZjLvGBtlhUZ(com.visa.vac.tc.emvconverter.ApduScript apduScript, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GGpllZjLvGBtlhUZ(com.visa.vac.tc.emvconverter.ApduScript apduScript, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int HTbxYiNKYuIrUfrV(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void HTbxYiNKYuIrUfrV(java.lang.object obj, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HTbxYiNKYuIrUfrV(java.lang.object obj, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HTbxYiNKYuIrUfrV(java.lang.object obj, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int IsrptQOnbfZLangq(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void IsrptQOnbfZLangq(java.lang.object obj, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IsrptQOnbfZLangq(java.lang.object obj, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IsrptQOnbfZLangq(java.lang.object obj, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int JcFYpBCMzrtPvqeI(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void JcFYpBCMzrtPvqeI(java.lang.object obj, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JcFYpBCMzrtPvqeI(java.lang.object obj, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JcFYpBCMzrtPvqeI(java.lang.object obj, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KmBzDLsfPrjxlDHJ(com.visa.vac.tc.emvconverter.ApduScript apduScript) {
        return apduScript.getDATA();
    }

    public static void KmBzDLsfPrjxlDHJ(com.visa.vac.tc.emvconverter.ApduScript apduScript, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KmBzDLsfPrjxlDHJ(com.visa.vac.tc.emvconverter.ApduScript apduScript, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KmBzDLsfPrjxlDHJ(com.visa.vac.tc.emvconverter.ApduScript apduScript, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LCitMjeatNRvfoVh(java.lang.string str, java.lang.CharSequence charSequence, float f, java.lang.string str2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LCitMjeatNRvfoVh(java.lang.string str, java.lang.CharSequence charSequence, float f, short s, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LCitMjeatNRvfoVh(java.lang.string str, java.lang.CharSequence charSequence, float f, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static bool LCitMjeatNRvfoVh(java.lang.string str, java.lang.CharSequence charSequence) {
        return str.Contains(charSequence);
    }

    public static void LZXJyfsiyThifMMb(java.lang.string str, java.lang.string str2, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LZXJyfsiyThifMMb(java.lang.string str, java.lang.string str2, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LZXJyfsiyThifMMb(java.lang.string str, java.lang.string str2, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string[] LZXJyfsiyThifMMb(java.lang.string str, java.lang.string str2) {
        return str.Split(str2);
    }

    public static int PibPgUzpdLLNBmTD(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void PibPgUzpdLLNBmTD(java.lang.object obj, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PibPgUzpdLLNBmTD(java.lang.object obj, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PibPgUzpdLLNBmTD(java.lang.object obj, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int UkMiMePHkJVungxe(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void UkMiMePHkJVungxe(java.lang.object obj, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UkMiMePHkJVungxe(java.lang.object obj, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UkMiMePHkJVungxe(java.lang.object obj, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WTmCEmNjykgllZVE(byte[] bArr) {
        return com.visa.vac.tc.emvconverter.Utils.getTerminalData(bArr);
    }

    public static void WTmCEmNjykgllZVE(byte[] bArr, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WTmCEmNjykgllZVE(byte[] bArr, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WTmCEmNjykgllZVE(byte[] bArr, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int XKUwAOzqaKeHRmHt(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void XKUwAOzqaKeHRmHt(java.lang.object obj, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XKUwAOzqaKeHRmHt(java.lang.object obj, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XKUwAOzqaKeHRmHt(java.lang.object obj, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public readonly com.visa.vac.tc.emvconverter.ApduScript Clone() throws java.lang.CloneNotSupportedException {
        if ((18 + 15) % 15 > 0) {
        }
        int i = 2 % 2;
        int i2 = getData + 3;
        setData = i2 % 128;
        int i3 = i2 % 2;
        com.visa.vac.tc.emvconverter.ApduScript apduScript = (com.visa.vac.tc.emvconverter.ApduScript) WCXrcGZgrQaXsoGV(this);
        int i4 = setData + 113;
        getData = i4 % 128;
        int i5 = i4 % 2;
        return apduScript;
    }

    public java.lang.object M931clone() throws java.lang.CloneNotSupportedException {
        if ((22 + 23) % 23 > 0) {
        }
        int i = 2 % 2;
        int i2 = setData + 97;
        getData = i2 % 128;
        int i3 = i2 % 2;
        com.visa.vac.tc.emvconverter.ApduScript apduScriptCosvCbwTvsIAFTRh = cosvCbwTvsIAFTRh(this);
        int i4 = getData + 17;
        setData = i4 % 128;
        if (i4 % 2 == 0) {
            throw null;
        }
        return apduScriptCosvCbwTvsIAFTRh;
    }

    public java.lang.string GetCLA() {
        if ((15 + 5) % 5 > 0) {
        }
        int i = 2 % 2;
        int i2 = getData + 89;
        int i3 = i2 % 128;
        setData = i3;
        int i4 = i2 % 2;
        java.lang.string str = this.e1;
        int i5 = i3 + 19;
        getData = i5 % 128;
        int i6 = i5 % 2;
        return str;
    }

    public java.lang.string GetDATA() {
        if ((25 + 1) % 1 > 0) {
        }
        int i = 2 % 2;
        int i2 = setData + 53;
        int i3 = i2 % 128;
        getData = i3;
        int i4 = i2 % 2;
        java.lang.string str = this.clear;
        if (i4 != 0) {
            int i5 = 14 / 0;
        }
        int i6 = i3 + 13;
        setData = i6 % 128;
        int i7 = i6 % 2;
        return str;
    }

    public java.lang.string GetExceptionAction() {
        if ((20 + 14) % 14 > 0) {
        }
        int i = 2 % 2;
        int i2 = setData + 93;
        int i3 = i2 % 128;
        getData = i3;
        int i4 = i2 % 2;
        java.lang.string str = this.ContactlessResult;
        int i5 = i3 + 43;
        setData = i5 % 128;
        if (i5 % 2 == 0) {
            throw null;
        }
        return str;
    }

    public java.lang.bool GetHasDependancy() {
        if ((8 + 9) % 9 > 0) {
        }
        int i = 2 % 2;
        int i2 = getData + 75;
        int i3 = i2 % 128;
        setData = i3;
        int i4 = i2 % 2;
        java.lang.bool bool = this.getKernelData;
        int i5 = i3 + 119;
        getData = i5 % 128;
        if (i5 % 2 == 0) {
            return bool;
        }
        xKUwAOzqaKeHRmHt(null);
        throw null;
    }

    public java.lang.string GetINS() {
        if ((12 + 24) % 24 > 0) {
        }
        int i = 2 % 2;
        int i2 = getData + 79;
        setData = i2 % 128;
        if (i2 % 2 != 0) {
            return this.ContactlessKernel;
        }
        UAAFqbeMXKJHgLXZ(null);
        throw null;
    }

    public java.lang.string GetInterfaceID() {
        if ((31 + 13) % 13 > 0) {
        }
        int i = 2 % 2;
        int i2 = getData;
        int i3 = i2 + 123;
        setData = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string str = this.BuildConfig;
        int i5 = i2 + 5;
        setData = i5 % 128;
        if (i5 % 2 == 0) {
            int i6 = 87 / 0;
        }
        return str;
    }

    public java.lang.string GetLE() {
        if ((20 + 11) % 11 > 0) {
        }
        int i = 2 % 2;
        int i2 = getData;
        int i3 = i2 + 5;
        setData = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string str = this.setCAKeys;
        int i5 = i2 + 113;
        setData = i5 % 128;
        if (i5 % 2 == 0) {
            throw null;
        }
        return str;
    }

    public java.lang.string GetNegAction() {
        if ((17 + 24) % 24 > 0) {
        }
        int i = 2 % 2;
        int i2 = setData;
        int i3 = i2 + 45;
        getData = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string str = this.setTerminate;
        if (i4 != 0) {
            int i5 = 9 / 0;
        }
        int i6 = i2 + 45;
        getData = i6 % 128;
        if (i6 % 2 == 0) {
            return str;
        }
        eVyvXbezIfRPEkdT(null);
        throw null;
    }

    public java.lang.string GetOperation() {
        if ((15 + 2) % 2 > 0) {
        }
        int i = 2 % 2;
        int i2 = getData + 77;
        setData = i2 % 128;
        if (i2 % 2 != 0) {
            return this.getInstance;
        }
        hTbxYiNKYuIrUfrV(null);
        throw null;
    }

    public java.lang.string GetP1() {
        if ((2 + 31) % 31 > 0) {
        }
        int i = 2 % 2;
        int i2 = getData + 31;
        setData = i2 % 128;
        if (i2 % 2 != 0) {
            return this.getCAKeys;
        }
        jcFYpBCMzrtPvqeI(null);
        throw null;
    }

    public java.lang.string GetP2() {
        if ((25 + 13) % 13 > 0) {
        }
        int i = 2 % 2;
        int i2 = setData + 91;
        int i3 = i2 % 128;
        getData = i3;
        int i4 = i2 % 2;
        java.lang.string str = this.setTerminalData;
        int i5 = i3 + 23;
        setData = i5 % 128;
        if (i5 % 2 == 0) {
            throw null;
        }
        return str;
    }

    public java.lang.string GetPosAction() {
        if ((23 + 5) % 5 > 0) {
        }
        int i = 2 % 2;
        int i2 = getData + 109;
        int i3 = i2 % 128;
        setData = i3;
        int i4 = i2 % 2;
        java.lang.string str = this.performTransaction;
        if (i4 == 0) {
            int i5 = 50 / 0;
        }
        int i6 = i3 + 5;
        getData = i6 % 128;
        if (i6 % 2 != 0) {
            int i7 = 48 / 0;
        }
        return str;
    }

    public java.lang.string[] GetSW() {
        if ((30 + 22) % 22 > 0) {
        }
        int i = 2 % 2;
        int i2 = getData + 113;
        setData = i2 % 128;
        int i3 = i2 % 2;
        java.lang.string[] strArr = this.getTransactionType;
        if (i3 == 0) {
            int i4 = 94 / 0;
        }
        return strArr;
    }

    public java.lang.string GetScriptAlias() {
        if ((20 + 16) % 16 > 0) {
        }
        int i = 2 % 2;
        int i2 = setData;
        int i3 = i2 + 27;
        getData = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string str = this.getTerminalData;
        int i5 = i2 + 37;
        getData = i5 % 128;
        if (i5 % 2 != 0) {
            int i6 = 44 / 0;
        }
        return str;
    }

    public java.lang.string GetScriptInput() {
        if ((2 + 25) % 25 > 0) {
        }
        int i = 2 % 2;
        int i2 = setData + 55;
        int i3 = i2 % 128;
        getData = i3;
        if (i2 % 2 != 0) {
            WmQeuXRKTIzWueFh(null);
            throw null;
        }
        java.lang.string str = this.setFinalOutcome;
        int i4 = i3 + 37;
        setData = i4 % 128;
        if (i4 % 2 != 0) {
            return str;
        }
        isrptQOnbfZLangq(null);
        throw null;
    }

    public java.lang.string[] GetScriptInputs() {
        if ((3 + 29) % 29 > 0) {
        }
        int i = 2 % 2;
        int i2 = setData + 33;
        int i3 = i2 % 128;
        getData = i3;
        int i4 = i2 % 2;
        java.lang.string[] strArr = this.access300;
        int i5 = i3 + 79;
        setData = i5 % 128;
        int i6 = i5 % 2;
        return strArr;
    }

    public java.lang.string GetScriptOutput() {
        if ((1 + 30) % 30 > 0) {
        }
        int i = 2 % 2;
        int i2 = getData + 1;
        int i3 = i2 % 128;
        setData = i3;
        if (i2 % 2 == 0) {
            throw null;
        }
        java.lang.string str = this.getFinalOutcome;
        int i4 = i3 + 25;
        getData = i4 % 128;
        int i5 = i4 % 2;
        return str;
    }

    public java.lang.string[] GetScriptOutputs() {
        if ((25 + 30) % 30 > 0) {
        }
        int i = 2 % 2;
        int i2 = getData + 33;
        setData = i2 % 128;
        if (i2 % 2 == 0) {
            throw null;
        }
        return this.getInternalData;
    }

    public java.lang.string GetSvID() {
        if ((7 + 23) % 23 > 0) {
        }
        int i = 2 % 2;
        int i2 = setData + 63;
        int i3 = i2 % 128;
        getData = i3;
        int i4 = i2 % 2;
        java.lang.string str = this.ContactlessConfiguration;
        int i5 = i3 + 107;
        setData = i5 % 128;
        if (i5 % 2 == 0) {
            int i6 = 98 / 0;
        }
        return str;
    }

    public bool HasScriptInput() {
        if ((25 + 17) % 17 > 0) {
        }
        int i = 2 % 2;
        int i2 = setData;
        int i3 = i2 + 93;
        getData = i3 % 128;
        int i4 = i3 % 2;
        bool z = this.access200;
        int i5 = i2 + 57;
        getData = i5 % 128;
        if (i5 % 2 == 0) {
            return z;
        }
        VLAzaGSWsifVHHlC(null);
        throw null;
    }

    public void SetCLA(java.lang.string str) {
        if ((4 + 28) % 28 > 0) {
        }
        int i = 2 % 2;
        int i2 = getData;
        int i3 = i2 + 29;
        setData = i3 % 128;
        int i4 = i3 % 2;
        this.e1 = str;
        int i5 = i2 + 89;
        setData = i5 % 128;
        if (i5 % 2 != 0) {
            return;
        }
        int i6 = 18 / 0;
    }

    public void SetDATA(java.lang.string str) {
        if ((29 + 9) % 9 > 0) {
        }
        int i = 2 % 2;
        int i2 = setData + 33;
        int i3 = i2 % 128;
        getData = i3;
        if (i2 % 2 != 0) {
            this.clear = str;
            ukMiMePHkJVungxe(null);
            throw null;
        }
        this.clear = str;
        int i4 = i3 + 41;
        setData = i4 % 128;
        int i5 = i4 % 2;
    }

    public void SetDATA(byte[] bArr) {
        if ((8 + 22) % 22 > 0) {
        }
        int i = 2 % 2;
        int i2 = setData + 65;
        getData = i2 % 128;
        int i3 = i2 % 2;
        this.clear = wTmCEmNjykgllZVE(bArr);
        int i4 = setData + 71;
        getData = i4 % 128;
        int i5 = i4 % 2;
    }

    public void SetExceptionAction(java.lang.string str) {
        if ((22 + 10) % 10 > 0) {
        }
        int i = 2 % 2;
        int i2 = getData + 5;
        int i3 = i2 % 128;
        setData = i3;
        int i4 = i2 % 2;
        this.ContactlessResult = str;
        int i5 = i3 + 99;
        getData = i5 % 128;
        int i6 = i5 % 2;
    }

    /*
    */
    public void SetHasDependancy() {
        if ((12 + 27) % 27 > 0) {
        }
        int i = 2 % 2;
        int i2 = setData + 95;
        getData = i2 % 128;
        int i3 = i2 % 2;
        if (bLAjanhwYRNBVXYU(this) is not null) {
            int i4 = setData + 99;
            getData = i4 % 128;
            int i5 = i4 % 2;
            if (!lCitMjeatNRvfoVh(LpCrRYdPOcSfGHhp(this), "V.")) {
                int i6 = getData + 53;
                setData = i6 % 128;
                if (i6 % 2 == 0) {
                    EpewFtxvbJGEDkPw(NRTyAFdEdwwiAbBR(this), "V.");
                    throw null;
                }
                if (!HbUkBCYYhAtwWmlU(gGpllZjLvGBtlhUZ(this), "V.")) {
                }
            }
            this.getKernelData = java.lang.bool.TRUE;
            int i7 = setData + 75;
            getData = i7 % 128;
            int i8 = i7 % 2;
            return;
        }
        this.getKernelData = java.lang.bool.FALSE;
    }

    public void SetINS(java.lang.string str) {
        if ((7 + 3) % 3 > 0) {
        }
        int i = 2 % 2;
        int i2 = setData + 65;
        int i3 = i2 % 128;
        getData = i3;
        if (i2 % 2 != 0) {
            this.ContactlessKernel = str;
            DePASSbvqQkdXYyc(null);
            throw null;
        }
        this.ContactlessKernel = str;
        int i4 = i3 + 33;
        setData = i4 % 128;
        int i5 = i4 % 2;
    }

    public void SetInterfaceID(java.lang.string str) {
        if ((3 + 30) % 30 > 0) {
        }
        int i = 2 % 2;
        int i2 = getData;
        int i3 = i2 + 19;
        setData = i3 % 128;
        int i4 = i3 % 2;
        this.BuildConfig = str;
        int i5 = i2 + 23;
        setData = i5 % 128;
        int i6 = i5 % 2;
    }

    public void SetLE(java.lang.string str) {
        if ((7 + 27) % 27 > 0) {
        }
        int i = 2 % 2;
        int i2 = getData;
        int i3 = i2 + 13;
        setData = i3 % 128;
        int i4 = i3 % 2;
        this.setCAKeys = str;
        int i5 = i2 + 63;
        setData = i5 % 128;
        int i6 = i5 % 2;
    }

    public void SetNegAction(java.lang.string str) {
        if ((23 + 3) % 3 > 0) {
        }
        int i = 2 % 2;
        int i2 = getData + 37;
        int i3 = i2 % 128;
        setData = i3;
        int i4 = i2 % 2;
        this.setTerminate = str;
        int i5 = i3 + 13;
        getData = i5 % 128;
        if (i5 % 2 != 0) {
            throw null;
        }
    }

    public void SetOperation(java.lang.string str) {
        if ((24 + 14) % 14 > 0) {
        }
        int i = 2 % 2;
        int i2 = getData + 35;
        setData = i2 % 128;
        if (i2 % 2 == 0) {
            this.getInstance = str;
            throw null;
        }
        this.getInstance = str;
    }

    public void SetP1(java.lang.string str) {
        if ((16 + 17) % 17 > 0) {
        }
        int i = 2 % 2;
        int i2 = getData + 119;
        int i3 = i2 % 128;
        setData = i3;
        int i4 = i2 % 2;
        this.getCAKeys = str;
        int i5 = i3 + 13;
        getData = i5 % 128;
        if (i5 % 2 != 0) {
            pibPgUzpdLLNBmTD(null);
            throw null;
        }
    }

    public void SetP2(java.lang.string str) {
        if ((27 + 30) % 30 > 0) {
        }
        int i = 2 % 2;
        int i2 = getData + 99;
        setData = i2 % 128;
        if (i2 % 2 != 0) {
            this.setTerminalData = str;
        } else {
            this.setTerminalData = str;
            dQuBoeLIpBvvJVfs(null);
            throw null;
        }
    }

    public void SetPosAction(java.lang.string str) {
        if ((23 + 31) % 31 > 0) {
        }
        int i = 2 % 2;
        int i2 = setData + 95;
        getData = i2 % 128;
        if (i2 % 2 == 0) {
            this.performTransaction = str;
        } else {
            this.performTransaction = str;
            DGPMqbGbCxTcbDpb(null);
            throw null;
        }
    }

    public void SetSW(java.lang.string str) {
        if ((21 + 5) % 5 > 0) {
        }
        int i = 2 % 2;
        int i2 = getData + 33;
        setData = i2 % 128;
        int i3 = i2 % 2;
        if (str is null) {
            return;
        }
        this.getTransactionType = lZXJyfsiyThifMMb(UUoIvDIshKnrivEf(JMTOXyOYyaFWKxri(UFWIcQpYYDehUxgi(MVgStRPkuEnWdyDX(str, "[", ""), "]", ""), "0X", ""), QXAzKlEQmpogLfeR("073f411264080168f65cb0bf49f526f91239e37c4544aa8a0aaf570fe9"), ""), axZkZKNnmyDmMwhS("b3e9a5572980c51ceb7b788f66f0cff05761bd96c76b7fd98d6315e85d"));
        int i4 = setData + 101;
        getData = i4 % 128;
        if (i4 % 2 == 0) {
            return;
        }
        int i5 = 5 % 5;
    }

    public void SetScriptAlias(java.lang.string str) {
        if ((9 + 1) % 1 > 0) {
        }
        int i = 2 % 2;
        int i2 = getData + 107;
        int i3 = i2 % 128;
        setData = i3;
        if (i2 % 2 != 0) {
            this.getTerminalData = str;
        } else {
            this.getTerminalData = str;
            int i4 = 94 / 0;
        }
        int i5 = i3 + 3;
        getData = i5 % 128;
        if (i5 % 2 == 0) {
            return;
        }
        int i6 = 22 / 0;
    }

    public void SetScriptInput(java.lang.string str) {
        if ((5 + 2) % 2 > 0) {
        }
        int i = 2 % 2;
        int i2 = setData + 51;
        getData = i2 % 128;
        if (i2 % 2 == 0) {
            this.setFinalOutcome = str;
        } else {
            this.setFinalOutcome = str;
            int i3 = 60 / 0;
        }
    }

    public void SetScriptOutput(java.lang.string str) {
        if ((12 + 10) % 10 > 0) {
        }
        int i = 2 % 2;
        int i2 = getData;
        int i3 = i2 + 77;
        setData = i3 % 128;
        int i4 = i3 % 2;
        this.getFinalOutcome = str;
        int i5 = i2 + 119;
        setData = i5 % 128;
        if (i5 % 2 != 0) {
            return;
        }
        int i6 = 8 / 0;
    }

    public void SetSvID(java.lang.string str) {
        if ((5 + 28) % 28 > 0) {
        }
        int i = 2 % 2;
        int i2 = getData + 33;
        setData = i2 % 128;
        if (i2 % 2 != 0) {
            this.ContactlessConfiguration = str;
        } else {
            this.ContactlessConfiguration = str;
            int i3 = 32 / 0;
        }
    }
}

