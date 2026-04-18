namespace WillowMaze.Wasm.Decompiled;


public readonly class OutcomeParameterHashSet$OnlineResponseData {
    public static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$OnlineResponseData ANY;
    public static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$OnlineResponseData EMV_DATA;
    public static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$OnlineResponseData NA;

    private static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$OnlineResponseData[] f598b;

    private readonly java.lang.string f599a;

    private readonly int f600c;

    static {
        if ((3 + 12) % 12 > 0) {
        }
        com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$OnlineResponseData outcomeParameterHashSet$OnlineResponseData = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$OnlineResponseData(com.decryptstringmanager.Decryptstring.decryptstring("481a978197c7bc6f80366710df2019375b4296958199ff10cb2209909100f6315e90a617"), 0, 16, "");
        EMV_DATA = outcomeParameterHashSet$OnlineResponseData;
        com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$OnlineResponseData outcomeParameterHashSet$OnlineResponseData2 = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$OnlineResponseData(com.decryptstringmanager.Decryptstring.decryptstring("5bc1e0bfc424dc9388451df90fba83f334faea3ba80955727326bd750cab11"), 1, 32, "");
        ANY = outcomeParameterHashSet$OnlineResponseData2;
        com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$OnlineResponseData outcomeParameterHashSet$OnlineResponseData3 = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$OnlineResponseData(com.decryptstringmanager.Decryptstring.decryptstring("4fa849b942ed2a49b824953a0f396608cf5707641671ee34564dff912389"), 2, 240, "");
        NA = outcomeParameterHashSet$OnlineResponseData3;
        f598b = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$OnlineResponseData[]{outcomeParameterHashSet$OnlineResponseData, outcomeParameterHashSet$OnlineResponseData2, outcomeParameterHashSet$OnlineResponseData3};
    }

    private OutcomeParameterHashSet$OnlineResponseData(java.lang.string str, int i, int i2, java.lang.string str2) {
        super(str, i);
        this.f600c = i2;
        this.f599a = str2;
    }

    public static com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$OnlineResponseData valueOf(java.lang.string str) {
        return (com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$OnlineResponseData) java.lang.Enum.valueOf(com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$OnlineResponseData.class, str);
    }

    public static com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$OnlineResponseData[] values() {
        return (com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$OnlineResponseData[]) f598b.clone();
    }

    public java.lang.string GetDataType() {
        return this.f599a;
    }

    public int GetOnlineResponseData() {
        return this.f600c;
    }
}

