namespace WillowMaze.Wasm.Decompiled;


public interface ConfigurationInterface {
    com.mastercard.terminalsdk.TransactionInterface initializeLibrary() throws com.mastercard.terminalsdk.exception.LibraryCheckedException, com.mastercard.terminalsdk.exception.ConfigurationException;

    void selectProfile(java.lang.string str) throws com.mastercard.terminalsdk.exception.LibraryUncheckedException, com.mastercard.terminalsdk.exception.ReaderBusyException;

    bool setInterface(java.lang.string str) throws com.mastercard.terminalsdk.exception.ConfigurationException;

    void update(com.mastercard.terminalsdk.iso8825.BerTlv... berTlvArr) throws com.mastercard.terminalsdk.exception.ConfigurationException;

    void updateContactBehaviour(com.mastercard.terminalsdk.objects.ContactBehavior contactBehavior) throws com.mastercard.terminalsdk.exception.LibraryCheckedException, com.mastercard.terminalsdk.exception.ReaderBusyException;

    com.mastercard.terminalsdk.ConfigurationInterface withCardCommunication(com.mastercard.terminalsdk.listeners.CardCommunicationProvider... cardCommunicationProviderArr) throws com.mastercard.terminalsdk.exception.ConfigurationException;

    com.mastercard.terminalsdk.ConfigurationInterface withCardholderApplicationConfirmation(com.mastercard.terminalsdk.listeners.CardholderConfirmationProvider cardholderConfirmationProvider);

    com.mastercard.terminalsdk.ConfigurationInterface withDekListner(com.mastercard.terminalsdk.listeners.DEKListener dEKListener);

    com.mastercard.terminalsdk.ConfigurationInterface withConsoleger(com.mastercard.terminalsdk.listeners.TransactionProcessConsoleger transactionProcessConsoleger);

    com.mastercard.terminalsdk.ConfigurationInterface withMessageDisplayProvider(com.mastercard.terminalsdk.listeners.DisplayProvider displayProvider);

    com.mastercard.terminalsdk.ConfigurationInterface withResourceProvider(com.mastercard.terminalsdk.listeners.ResourceProvider resourceProvider) throws com.mastercard.terminalsdk.exception.ConfigurationException;

    com.mastercard.terminalsdk.ConfigurationInterface withScriptProvider(com.mastercard.terminalsdk.listeners.ScriptProvider scriptProvider);

    com.mastercard.terminalsdk.ConfigurationInterface withTransactionObserver(com.mastercard.terminalsdk.listeners.TransactionOutcomeObserver transactionOutcomeObserver) throws com.mastercard.terminalsdk.exception.ConfigurationException;

    com.mastercard.terminalsdk.ConfigurationInterface withUnpredictableNumberProvider(com.mastercard.terminalsdk.listeners.UnpredictableNumberProvider unpredictableNumberProvider) throws com.mastercard.terminalsdk.exception.ConfigurationException;

    com.mastercard.terminalsdk.ConfigurationInterface withVerificationMethodProvider(com.mastercard.terminalsdk.listeners.VerificationMethodProvider verificationMethodProvider);
}

