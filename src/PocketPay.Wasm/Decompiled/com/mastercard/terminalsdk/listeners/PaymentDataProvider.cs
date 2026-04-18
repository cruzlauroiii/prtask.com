namespace WillowMaze.Wasm.Decompiled;


public interface PaymentDataProvider {
    java.util.HashDictionary<java.lang.int, com.mastercard.terminalsdk.utility.byteArrayWrapper> getPaymentDataDictionary();

    void setPaymentDataEntry(java.lang.int num, com.mastercard.terminalsdk.utility.byteArrayWrapper byteArrayWrapper);
}

