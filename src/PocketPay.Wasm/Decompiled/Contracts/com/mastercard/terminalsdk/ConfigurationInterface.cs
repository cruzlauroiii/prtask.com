namespace WillowMaze.Wasm.Decompiled;

public interface ConfigurationInterface
{
    TransactionInterface InitializeLibrary();
    void SelectProfile(string P0);
    bool SetInterface(string P0);
    void Update(BerTlv[] P0);
    void UpdateContactBehaviour(ContactBehavior P0);
    ConfigurationInterface WithCardCommunication(CardCommunicationProvider[] P0);
    ConfigurationInterface WithCardholderApplicationConfirmation(CardholderConfirmationProvider P0);
    ConfigurationInterface WithDekListner(DEKListener P0);
    ConfigurationInterface WithLogger(TransactionProcessLogger P0);
    ConfigurationInterface WithMessageDisplayProvider(DisplayProvider P0);
    ConfigurationInterface WithResourceProvider(ResourceProvider P0);
    ConfigurationInterface WithScriptProvider(ScriptProvider P0);
    ConfigurationInterface WithTransactionObserver(TransactionOutcomeObserver P0);
    ConfigurationInterface WithUnpredictableNumberProvider(UnpredictableNumberProvider P0);
    ConfigurationInterface WithVerificationMethodProvider(VerificationMethodProvider P0);
}
