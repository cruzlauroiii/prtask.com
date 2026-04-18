namespace WillowMaze.Wasm.Decompiled;

public class OutcomeParameterSet : Cloneable
{
    private OutcomeParameterSet$CVM A;
    private OutcomeParameterSet$Start B;
    private OutcomeParameterSet$OnlineResponseData C;
    private OutcomeParameterSet$Status D;
    private bool E;
    private OutcomeParameterSet$AlternateInterfacePreference F;
    private bool G;
    private bool H;
    private bool I;
    private bool J;
    private short M;
    private short O;

    private byte[] A()
    {
        // call: OutcomeParameterSet$OnlineResponseData.getOnlineResponseData
        // call: OutcomeParameterSet$Status.getStatus
        // call: OutcomeParameterSet$Start.getStart
        // call: OutcomeParameterSet$AlternateInterfacePreference.getAlternateInterfacePreference
        // call: OutcomeParameterSet$CVM.getCVM
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.c
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.o
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.a
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.e
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.d
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.i
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.j
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.h
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.f
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.b
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.g
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.m
        return default!;
    }

    private OutcomeParameterSet C()
    {
        // call: object.clone
        return default!;
    }

    private object Clone()
    {
        // call: OutcomeParameterSet.c
        return default!;
    }

    public OutcomeParameterSet$AlternateInterfacePreference GetAlternateInterfacePreference()
    {
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.f
        return default!;
    }

    public OutcomeParameterSet$CVM GetCvm()
    {
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.a
        return default!;
    }

    public int GetFieldOffRequestHoldTime()
    {
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.o
        return 0;
    }

    public OutcomeParameterSet$OnlineResponseData GetOnlineResponseData()
    {
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.c
        return default!;
    }

    public int GetRemovalTimeout()
    {
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.m
        return 0;
    }

    public OutcomeParameterSet$Start GetStart()
    {
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.b
        return default!;
    }

    public OutcomeParameterSet$Status GetStatus()
    {
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.d
        return default!;
    }

    public bool IsDataRecordPresent()
    {
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.h
        return false;
    }

    public bool IsDiscretionaryDataPresent()
    {
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.i
        return false;
    }

    public bool IsReceiptRequired()
    {
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.g
        return false;
    }

    public bool IsUIRequestedOnOutcome()
    {
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.e
        return false;
    }

    public bool IsUIRequestedOnRestart()
    {
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.j
        return false;
    }

    public void SetAlternateInterfacePreference(OutcomeParameterSet$AlternateInterfacePreference P0)
    {
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.f
    }

    public void SetCvm(OutcomeParameterSet$CVM P0)
    {
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.a
    }

    public void SetDataRecordStatus(bool P0)
    {
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.h
    }

    public void SetDiscretionaryDataStatus(bool P0)
    {
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.i
    }

    public void SetFieldOffRequestHoldTime(int P0)
    {
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.o
    }

    public void SetOnlineResponseData(OutcomeParameterSet$OnlineResponseData P0)
    {
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.c
    }

    public void SetReceiptStatus(bool P0)
    {
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.g
    }

    public void SetRemovalTimeout(int P0)
    {
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.m
    }

    public void SetStart(OutcomeParameterSet$Start P0)
    {
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.b
    }

    public void SetStatus(OutcomeParameterSet$Status P0)
    {
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.d
    }

    public void SetUIRequestedOnOutcomeStatus(bool P0)
    {
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.e
    }

    public void SetUIRequestedOnRestartStatus(bool P0)
    {
        // field: com.mastercard.terminalsdk.objects.OutcomeParameterSet.j
    }

    public string ToString()
    {
        // call: object.toString
        return string.Empty;
    }

    public BerTlv ToTlv()
    {
        // str: "b"
        // str: "cR"
        // str: ""
        // call: Exception.getCause
        // call: Field.get
        // call: q.b
        // call: Type.getMethod
        // call: Method.invoke
        // call: Type.getField
        // call: OutcomeParameterSet.a
        // call: BerTlv.<init>
        // call: Tag.<init>
        // call: ByteArrayWrapper.<init>
        // field: com.mastercard.terminalsdk.emv.Tag$Format.b
        // type: Tag
        // type: ByteArrayWrapper
        // type: BerTlv
        return default!;
    }

}
