namespace WillowMaze.Wasm.Decompiled;


public interface CardResponseListener {
    void onL1RSPException(com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code errorIndication$L1_Error_Code);

    void onResponse(byte[] bArr);
}

