namespace WillowMaze.Wasm.Decompiled;

public class UserInterfaceData : Cloneable
{
    private UserInterfaceData$UIRDStatus A;
    private int B;
    private byte[] C;
    private UserInterfaceData$ValueQualifier D;
    private UserInterfaceData$UIRDMessageID E;
    private short F;
    private byte[] G;

    private byte[] D()
    {
        // call: UserInterfaceData$ValueQualifier.getValueQualifier
        // call: UserInterfaceData$UIRDMessageID.getUIRDMessageID
        // call: ByteUtility.padData
        // call: UserInterfaceData$UIRDStatus.getUIRDStatus
        // call: System.arraycopy
        // call: ByteUtility.longToBcd
        // field: com.mastercard.terminalsdk.objects.UserInterfaceData.d
        // field: com.mastercard.terminalsdk.objects.UserInterfaceData.f
        // field: com.mastercard.terminalsdk.objects.UserInterfaceData.e
        // field: com.mastercard.terminalsdk.objects.UserInterfaceData.b
        // field: com.mastercard.terminalsdk.emv.Tag$Format.n
        // field: com.mastercard.terminalsdk.objects.UserInterfaceData.g
        // field: com.mastercard.terminalsdk.objects.UserInterfaceData.a
        // field: com.mastercard.terminalsdk.objects.UserInterfaceData.c
        return default!;
    }

    private UserInterfaceData B()
    {
        // call: object.clone
        return default!;
    }

    private object Clone()
    {
        // call: UserInterfaceData.b
        return default!;
    }

    public short GetCurrencyCode()
    {
        // field: com.mastercard.terminalsdk.objects.UserInterfaceData.f
        return 0;
    }

    public int GetHoldTime()
    {
        // field: com.mastercard.terminalsdk.objects.UserInterfaceData.b
        return 0;
    }

    public byte[] GetLangPreference()
    {
        // field: com.mastercard.terminalsdk.objects.UserInterfaceData.c
        return default!;
    }

    public UserInterfaceData$UIRDMessageID GetMessageIdentifier()
    {
        // field: com.mastercard.terminalsdk.objects.UserInterfaceData.e
        return default!;
    }

    public UserInterfaceData$UIRDStatus GetStatus()
    {
        // field: com.mastercard.terminalsdk.objects.UserInterfaceData.a
        return default!;
    }

    public string GetValue()
    {
        // call: ByteUtility.byteArrayToHexString
        // field: com.mastercard.terminalsdk.objects.UserInterfaceData.g
        return string.Empty;
    }

    public UserInterfaceData$ValueQualifier GetValueQualifier()
    {
        // field: com.mastercard.terminalsdk.objects.UserInterfaceData.d
        return default!;
    }

    public void SetCurrencyCode(short P0)
    {
        // field: com.mastercard.terminalsdk.objects.UserInterfaceData.f
    }

    public void SetHoldTime(int P0)
    {
        // field: com.mastercard.terminalsdk.objects.UserInterfaceData.b
    }

    public void SetLangPreference(byte[] P0)
    {
        // call: System.arraycopy
        // field: com.mastercard.terminalsdk.objects.UserInterfaceData.c
    }

    public void SetMessageIdentifier(UserInterfaceData$UIRDMessageID P0)
    {
        // field: com.mastercard.terminalsdk.objects.UserInterfaceData.e
    }

    public void SetStatus(UserInterfaceData$UIRDStatus P0)
    {
        // field: com.mastercard.terminalsdk.objects.UserInterfaceData.a
    }

    public void SetValue(byte[] P0)
    {
        // call: System.arraycopy
        // field: com.mastercard.terminalsdk.objects.UserInterfaceData.g
    }

    public void SetValueQualifier(UserInterfaceData$ValueQualifier P0)
    {
        // field: com.mastercard.terminalsdk.objects.UserInterfaceData.d
    }

    public string ToString()
    {
        // call: object.toString
        return string.Empty;
    }

    public BerTlv ToTlv()
    {
        // str: "b"
        // str: "cN"
        // str: ""
        // call: Field.get
        // call: q.b
        // call: Type.getMethod
        // call: Method.invoke
        // call: UserInterfaceData.d
        // call: Exception.getCause
        // call: Type.getField
        // call: Tag.<init>
        // call: BerTlv.<init>
        // call: ByteArrayWrapper.<init>
        // field: com.mastercard.terminalsdk.emv.Tag$Format.b
        // type: BerTlv
        // type: ByteArrayWrapper
        // type: Tag
        return default!;
    }

}
