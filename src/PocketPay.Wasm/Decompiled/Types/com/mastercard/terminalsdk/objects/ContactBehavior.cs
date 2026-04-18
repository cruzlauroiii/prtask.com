namespace WillowMaze.Wasm.Decompiled;

public class ContactBehavior
{
    private bool A;
    private bool B;
    private bool C;
    private bool D;
    private ContactBehavior$CdaMode E;
    private bool F;
    private bool G;
    private bool H;
    private bool I;
    private byte J;
    private bool K;
    private bool L;
    private bool M;
    private bool N;
    private bool O;
    private bool S;

    public bool CdaModeOfOperationNeverAtGenAC1Arqc()
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.g
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.e
        // field: com.mastercard.terminalsdk.objects.ContactBehavior$CdaMode.a
        // field: com.mastercard.terminalsdk.objects.ContactBehavior$CdaMode.c
        return false;
    }

    public bool CdaModeOfOperationNeverAtGenAC2Tc()
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.f
        // field: com.mastercard.terminalsdk.objects.ContactBehavior$CdaMode.e
        // field: com.mastercard.terminalsdk.objects.ContactBehavior$CdaMode.c
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.e
        return false;
    }

    public bool DetectCdaFailureBeforeTAA()
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.h
        return false;
    }

    public bool ForcedAcceptance()
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.c
        return false;
    }

    public bool GetDefaultACProcedureBehavior()
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.n
        return false;
    }

    public byte GetForcedTransactionType()
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.j
        return 0;
    }

    public bool IsAdviceSupported()
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.m
        return false;
    }

    public bool IsCertificateRevocationSupported()
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.s
        return false;
    }

    public bool IsExceptionFileCheckSupported()
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.l
        return false;
    }

    public bool IsGetDataPTCSupported()
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.b
        return false;
    }

    public bool IsScriptLengthGreaterThan128Bytes()
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.k
        return false;
    }

    public bool ProcessDefaultActionCodesPostFirstGenAC()
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.o
        return false;
    }

    public bool ProcessDefaultActionCodesPriorToFirstGenAC()
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.i
        return false;
    }

    public bool PseIsSupported()
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.a
        return false;
    }

    public bool TransactionIsToBeForcedOnline()
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.d
        return false;
    }

    public void UpdateAdviceSupport(bool P0)
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.m
    }

    public void UpdateCdaFailureDetectionBeforeTAA(bool P0)
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.h
    }

    public void UpdateCdaModeOfOperation(ContactBehavior$CdaMode P0)
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.e
    }

    public void UpdateCertificateRevocationSupport(bool P0)
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.s
    }

    public void UpdateDefaultACProcedure(bool P0)
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.n
    }

    public void UpdateDefaultActionCodesPostFirstGenAC(bool P0)
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.o
    }

    public void UpdateDefaultActionCodesPriorToFirstGenAC(bool P0)
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.i
    }

    public void UpdateExceptionFileCheckSupport(bool P0)
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.l
    }

    public void UpdateForceAcceptanceStatus(bool P0)
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.c
    }

    public void UpdateForceOnlineCapability(bool P0)
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.d
    }

    public void UpdateForceTransactionType(byte P0)
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.j
    }

    public void UpdateGetDataPTCSupport(bool P0)
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.b
    }

    public void UpdateIssuerScriptLengthSupportGreaterThan128Bytes(bool P0)
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.k
    }

    public void UpdatePseSupport(bool P0)
    {
        // field: com.mastercard.terminalsdk.objects.ContactBehavior.a
    }

}
