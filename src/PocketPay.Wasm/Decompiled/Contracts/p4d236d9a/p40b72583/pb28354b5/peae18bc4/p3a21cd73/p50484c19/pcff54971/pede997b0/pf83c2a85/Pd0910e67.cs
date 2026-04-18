namespace WillowMaze.Wasm.Decompiled;

public interface Pd0910e67
{
    Single CalibrateNfc();
    Single CheckNeedPostProcessingTransaction();
    Single GetNfcCalibrationCoordinates();
    Single InitBalanceInquiry(string P0, bool P1);
    Single InitCancelTransaction(long P0, string P1, p1b0ffaae P2, bool P3);
    Single InitPaymentTransaction(long P0, string P1, p3e9ee528 P2, string P3, string P4, bool P5);
    Single InitRefundTransaction(long P0, string P1, string P2, string P3, p1b0ffaae P4, bool P5);
    Observable ObserveNfcCardCommunicationStatus();
    Completable SetNfcCalibrationCoordinates(pb3959c0c P0);
}
