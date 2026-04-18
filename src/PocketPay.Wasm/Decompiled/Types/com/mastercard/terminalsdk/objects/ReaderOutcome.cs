namespace WillowMaze.Wasm.Decompiled;

public class ReaderOutcome
{
    private UserInterfaceData A;
    private OutcomeParameterSet B;
    private TlvList C;
    private BerTlv D;
    private DiscretionaryData E;

    public void AddAdditionalData(BerTlv P0)
    {
        // call: TlvList.addTLVtoList
        // field: com.mastercard.terminalsdk.objects.ReaderOutcome.c
    }

    public List<object> GetAdditionalInformation()
    {
        // call: TlvList.getListOfBerTlv
        // field: com.mastercard.terminalsdk.objects.ReaderOutcome.c
        return default!;
    }

    public byte[] GetAdditionalInformationBytes()
    {
        // call: TlvList.toByteArray
        // field: com.mastercard.terminalsdk.objects.ReaderOutcome.c
        return default!;
    }

    public List<object> GetDataRecordContents()
    {
        // str: "0e5487ffd050c5cff8f9e424080780927544345d72cb232866a9d11a4b"
        // call: OutcomeParameterSet.isDataRecordPresent
        // call: ByteArrayWrapper.getBytes
        // call: BerTlv.getRawBytes
        // call: TLVUtility.conditionalTlvParsing
        // call: DecryptString.decryptString
        // call: List<object>.<init>
        // field: com.mastercard.terminalsdk.objects.ReaderOutcome.d
        // field: com.mastercard.terminalsdk.objects.ReaderOutcome.b
        // field: com.mastercard.terminalsdk.objects.ContentType.TLV
        // type: List<object>
        return default!;
    }

    public BerTlv GetDataRecordTlv()
    {
        // str: "DataRecord"
        // str: "cY"
        // str: "b"
        // call: Type.getField
        // call: BerTlv.<init>
        // call: OutcomeParameterSet.isDataRecordPresent
        // call: Exception.getCause
        // call: Field.get
        // call: q.b
        // call: Type.getMethod
        // call: Method.invoke
        // call: Tag.<init>
        // field: com.mastercard.terminalsdk.objects.ReaderOutcome.d
        // field: com.mastercard.terminalsdk.emv.Tag$Format.b
        // field: com.mastercard.terminalsdk.objects.ReaderOutcome.b
        // type: BerTlv
        // type: Tag
        return default!;
    }

    public DiscretionaryData GetDiscretionaryData()
    {
        // call: DiscretionaryData.setErrorIndication
        // call: ErrorIndication.<init>
        // call: OutcomeParameterSet.isDiscretionaryDataPresent
        // call: DiscretionaryData.<init>
        // field: com.mastercard.terminalsdk.objects.ReaderOutcome.e
        // field: com.mastercard.terminalsdk.objects.ReaderOutcome.b
        // type: ErrorIndication
        // type: DiscretionaryData
        return default!;
    }

    public OutcomeParameterSet GetOutcomeParameterSet()
    {
        // field: com.mastercard.terminalsdk.objects.ReaderOutcome.b
        return default!;
    }

    public string GetTransactionSummary()
    {
        // call: OutcomeParameterSet.toString
        // field: com.mastercard.terminalsdk.objects.ReaderOutcome.b
        return string.Empty;
    }

    public UserInterfaceData GetUserInterfaceData()
    {
        // call: OutcomeParameterSet.isUIRequestedOnOutcome
        // call: UserInterfaceData.<init>
        // call: OutcomeParameterSet.isUIRequestedOnRestart
        // field: com.mastercard.terminalsdk.objects.ReaderOutcome.a
        // field: com.mastercard.terminalsdk.objects.ReaderOutcome.b
        // type: UserInterfaceData
        return default!;
    }

    public void SetDataRecord(BerTlv P0)
    {
        // field: com.mastercard.terminalsdk.objects.ReaderOutcome.d
    }

    public void SetDiscretionaryData(DiscretionaryData P0)
    {
        // field: com.mastercard.terminalsdk.objects.ReaderOutcome.e
    }

    public void SetOutcomeParameterSet(OutcomeParameterSet P0)
    {
        // field: com.mastercard.terminalsdk.objects.ReaderOutcome.b
    }

    public void SetUIRD(UserInterfaceData P0)
    {
        // field: com.mastercard.terminalsdk.objects.ReaderOutcome.a
    }

    public byte[] ToByteArray()
    {
        // call: MemoryStream.toByteArray
        // call: MemoryStream.<init>
        // call: ReaderOutcome.toTlv
        // call: List<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: BerTlv.toByteArray
        // call: MemoryStream.write
        // type: MemoryStream
        return default!;
    }

    public string ToString()
    {
        // call: object.toString
        return string.Empty;
    }

    public List<object> ToTlv()
    {
        // call: List<object>.add
        // call: OutcomeParameterSet.isDiscretionaryDataPresent
        // call: TlvList.getListOfBerTlv
        // call: DiscretionaryData.toTLV
        // call: List<object>.<init>
        // call: OutcomeParameterSet.toTlv
        // call: OutcomeParameterSet.isDataRecordPresent
        // call: List<object>.addAll
        // field: com.mastercard.terminalsdk.objects.ReaderOutcome.b
        // field: com.mastercard.terminalsdk.objects.ReaderOutcome.e
        // field: com.mastercard.terminalsdk.objects.ReaderOutcome.c
        // field: com.mastercard.terminalsdk.objects.ReaderOutcome.d
        // type: List<object>
        return default!;
    }

}
