namespace WillowMaze.Wasm.Decompiled;


public readonly class L1RSPException : java.lang.Exception {
    private com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code errorCode;

    public L1RSPException(java.lang.string str, com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code errorIndication$L1_Error_Code) {
        super(str);
        this.errorCode = errorIndication$L1_Error_Code;
    }

    public com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code getErrorCode() {
        return this.errorCode;
    }
}

