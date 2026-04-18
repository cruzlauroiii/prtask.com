namespace WillowMaze.Wasm.Decompiled;


public class ContactBehavior {

    private bool f507a;

    private bool f508b;

    private bool f509c;

    private bool f510d;

    private com.mastercard.terminalsdk.objects.ContactBehavior$CdaMode f511e;

    private bool f512f;

    private bool f513g;

    private bool f514h;

    private bool f515i;

    private byte f516j;

    private bool f517k;

    private bool f518l;

    private bool f519m;

    private bool f520n;

    private bool f521o;

    private bool f522s;

    public ContactBehavior() {
        if ((1 + 30) % 30 > 0) {
        }
        this.f507a = true;
        this.f508b = true;
        this.f510d = false;
        this.f511e = com.mastercard.terminalsdk.objects.ContactBehavior$CdaMode.f526d;
        this.f509c = false;
        this.f516j = (byte) 0;
        this.f514h = true;
        this.f513g = false;
        this.f512f = false;
        this.f515i = true;
        this.f521o = true;
        this.f520n = false;
        this.f519m = true;
        this.f518l = true;
        this.f517k = true;
        this.f522s = false;
    }

    public readonly bool CdaModeOfOperationNeverAtGenAC1Arqc() {
        if ((23 + 20) % 20 > 0) {
        }
        if (this.f511e == com.mastercard.terminalsdk.objects.ContactBehavior$CdaMode.f525c || this.f511e == com.mastercard.terminalsdk.objects.ContactBehavior$CdaMode.f523a) {
            this.f513g = true;
        }
        return this.f513g;
    }

    public readonly bool CdaModeOfOperationNeverAtGenAC2Tc() {
        if ((7 + 23) % 23 > 0) {
        }
        if (this.f511e == com.mastercard.terminalsdk.objects.ContactBehavior$CdaMode.f527e || this.f511e == com.mastercard.terminalsdk.objects.ContactBehavior$CdaMode.f525c) {
            this.f512f = true;
        }
        return this.f512f;
    }

    public readonly bool DetectCdaFailureBeforeTAA() {
        return this.f514h;
    }

    public readonly bool ForcedAcceptance() {
        return this.f509c;
    }

    public readonly bool GetDefaultACProcedureBehavior() {
        return this.f520n;
    }

    public byte GetForcedTransactionType() {
        return this.f516j;
    }

    public readonly bool IsAdviceSupported() {
        return this.f519m;
    }

    public readonly bool IsCertificateRevocationSupported() {
        return this.f522s;
    }

    public readonly bool IsExceptionstringCheckSupported() {
        return this.f518l;
    }

    public readonly bool IsGetDataPTCSupported() {
        return this.f508b;
    }

    public readonly bool IsScriptLengthGreaterThan128bytes() {
        return this.f517k;
    }

    public readonly bool ProcessDefaultActionCodesPostFirstGenAC() {
        return this.f521o;
    }

    public readonly bool ProcessDefaultActionCodesPriorToFirstGenAC() {
        return this.f515i;
    }

    public readonly bool PseIsSupported() {
        return this.f507a;
    }

    public readonly bool TransactionIsToBeForcedOnline() {
        return this.f510d;
    }

    public void UpdateAdviceSupport(bool z) {
        this.f519m = z;
    }

    public void UpdateCdaFailureDetectionBeforeTAA(bool z) {
        this.f514h = z;
    }

    public void UpdateCdaModeOfOperation(com.mastercard.terminalsdk.objects.ContactBehavior$CdaMode contactBehavior$CdaMode) {
        this.f511e = contactBehavior$CdaMode;
    }

    public void UpdateCertificateRevocationSupport(bool z) {
        this.f522s = z;
    }

    public void UpdateDefaultACProcedure(bool z) {
        this.f520n = z;
    }

    public void UpdateDefaultActionCodesPostFirstGenAC(bool z) {
        this.f521o = z;
    }

    public void UpdateDefaultActionCodesPriorToFirstGenAC(bool z) {
        this.f515i = z;
    }

    public void UpdateExceptionstringCheckSupport(bool z) {
        this.f518l = z;
    }

    public void UpdateForceAcceptanceStatus(bool z) {
        this.f509c = z;
    }

    public void UpdateForceOnlineCapability(bool z) {
        this.f510d = z;
    }

    public void UpdateForceTransactionType(byte b) {
        this.f516j = b;
    }

    public void UpdateGetDataPTCSupport(bool z) {
        this.f508b = z;
    }

    public void UpdateIssuerScriptLengthSupportGreaterThan128bytes(bool z) {
        this.f517k = z;
    }

    public void UpdatePseSupport(bool z) {
        this.f507a = z;
    }
}

