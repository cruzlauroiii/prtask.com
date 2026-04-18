namespace WillowMaze.Wasm.Decompiled;

public interface Pf2914733
{
    object CalibrateNfc(pd0910e67 P0, object P1);
    object GetShowedNfcCalibrationCoordinates(object P0);
    bool HasNfcFeature();
    object IsNfcCalibrated(object P0);
    bool IsNfcEnabled();
    bool IsShowNfcSpot();
    IAsyncEnumerable<object> ObserveNfcCardCommunicationStatus(pd0910e67 P0);
    object SetNfcCalibrationCoordinates(pd0910e67 P0, pb53cd12b P1, object P2);
    void SetShowNfcSpot(bool P0);
}
