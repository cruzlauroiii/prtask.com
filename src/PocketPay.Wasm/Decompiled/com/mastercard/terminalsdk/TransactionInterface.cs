namespace WillowMaze.Wasm.Decompiled;


public interface TransactionInterface {
    void abortTransaction() throws com.mastercard.terminalsdk.exception.LibraryCheckedException;

    void clean() throws com.mastercard.terminalsdk.exception.LibraryCheckedException, com.mastercard.terminalsdk.exception.ReaderBusyException;

    com.mastercard.terminalsdk.internal.C0439Q executeCommand(com.mastercard.terminalsdk.internal.AbstractC0438N abstractC0438N) throws com.mastercard.terminalsdk.exception.ReaderBusyException;

    void initiatePayment(com.mastercard.terminalsdk.listeners.PaymentDataProvider paymentDataProvider) throws com.mastercard.terminalsdk.exception.LibraryCheckedException, com.mastercard.terminalsdk.exception.ReaderBusyException;

    void proceedWithMastercardTransaction(com.mastercard.terminalsdk.listeners.PaymentDataProvider paymentDataProvider, byte[] bArr) throws com.mastercard.terminalsdk.exception.LibraryCheckedException, com.mastercard.terminalsdk.exception.ReaderBusyException;

    void readCard(java.util.List<com.mastercard.terminalsdk.emv.Tag> arrayList) throws com.mastercard.terminalsdk.exception.LibraryCheckedException, com.mastercard.terminalsdk.exception.ReaderBusyException;

    void resumeTransactionProcessing(byte[] bArr) throws com.mastercard.terminalsdk.exception.LibraryCheckedException, com.mastercard.terminalsdk.exception.ReaderBusyException;
}

