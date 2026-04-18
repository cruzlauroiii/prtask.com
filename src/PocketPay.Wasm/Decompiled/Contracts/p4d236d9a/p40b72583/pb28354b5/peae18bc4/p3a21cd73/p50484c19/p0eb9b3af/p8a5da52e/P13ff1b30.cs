namespace WillowMaze.Wasm.Decompiled;

public interface P13ff1b30
{
    p13ff1b30 M8bab0102(pe4aff977 P0);
    Single Attestation(pde7e6782 P0);
    Single CheckQRTransactionStatus(string P0);
    Completable ConfirmActivation(pd1118808 P0);
    Single ConfirmAttestation(p24d3e0e6 P0);
    Single ConfirmQRTransaction(string P0);
    Single ConfirmTransaction(string P0);
    Single CreateActivation(p655c6d56 P0);
    Single CreateQRTransaction(long P0);
    Single CreateTransaction(pa98357e6 P0, bool P1);
    Single CreateTransaction(pe74e9107 P0, bool P1);
    Single CutOffTerminal(p5e0a66db P0);
    Completable DeleteActivation(pae34bad3 P0, string P1);
    Single DeleteTransaction(string P0);
    Completable EmailBatchTransactionsReport(peae3f7e5 P0, string P1);
    Completable EmailTransactionsReport(pc97eb9a1 P0);
    Single GetBalance(pb7ebd4a0 P0);
    Single GetBatch(string P0);
    Single GetBatchTransactions(string P0, Dictionary<string, object> P1);
    Single GetBatches(Dictionary<string, object> P0);
    Single GetCurrentBatch();
    Single GetCurrentTransaction();
    Single GetJwtPubCert();
    Single GetLinkReceipt(string P0);
    Single GetLoggingConfiguration(p18ff9a27 P0);
    Single GetNfcCalibrationCoordinates();
    Single GetSeed(int P0);
    Single GetTerminal();
    Single GetTransaction(string P0);
    Single GetTransactions(string P0);
    Single GetTransactions(Dictionary<string, object> P0);
    Single RefundQRTransaction(string P0, p541d512c P1);
    Completable RequestEmailReceipt(p3f20efdf P0, string P1);
    Completable RequestSmsReceipt(p3df806a4 P0, string P1);
    Single ReverseTransaction(p11ead5c6 P0, string P1);
    Completable SendError(p8721624f P0);
    Completable SendTransactionSignature(p0d3cf03b P0, string P1);
    Completable SetNfcCalibrationCoordinates(pb3959c0c P0);
}
