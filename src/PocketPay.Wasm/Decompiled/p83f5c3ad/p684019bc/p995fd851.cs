namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0004\bf\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H&J\u0010\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0003H&J\b\u0010\u0007\u001a\u00020\u0003H&J\b\u0010\b\u001a\u00020\u0003H&J\u0016\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u000b0\n2\u0006\u0010\f\u001a\u00020\rH&J\u0016\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\rH¦@¢\u0006\u0002\u0010\u0011J\u000e\u0010\u0012\u001a\u00020\u0003H¦@¢\u0006\u0002\u0010\u0013J\u0010\u0010\u0014\u001a\u0004\u0018\u00010\u0015H¦@¢\u0006\u0002\u0010\u0013J\u001e\u0010\u0016\u001a\u00020\u00052\u0006\u0010\u0010\u001a\u00020\r2\u0006\u0010\u0017\u001a\u00020\u0015H¦@¢\u0006\u0002\u0010\u0018¨\u0006\u0019"}, d2 = {"Lp83f5c3ad/p684019bc/p995fd851;", "", "isShowNfcSpot", "", "setShowNfcSpot", "", "isShow", "hasNfcFeature", "isNfcEnabled", "observeNfcCardCommunicationStatus", "Lkotlinx/coroutines/flow/Flow;", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b3583e6/pc2c30812/pcaf97d07/p2484c164;", "paymentTerminal", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pede997b0/pf83c2a85/pd0910e67;", "calibrateNfc", "Lp83f5c3ad/p07214c67/pe6ff918f;", "terminal", "(Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pede997b0/pf83c2a85/pd0910e67;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "isNfcCalibrated", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getShowedNfcCalibrationCoordinates", "Lp83f5c3ad/p07214c67/pb53cd12b;", "setNfcCalibrationCoordinates", "coordinates", "(Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pcff54971/pede997b0/pf83c2a85/pd0910e67;Lp83f5c3ad/p07214c67/pb53cd12b;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "feature-toph-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p995fd851 {
    java.lang.object calibrateNfc(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67 pd0910e67Var, kotlin.coroutines.Continuation<p83f5c3ad.p07214c67.pe6ff918f> continuation);

    java.lang.object getShowedNfcCalibrationCoordinates(kotlin.coroutines.Continuation<p83f5c3ad.p07214c67.pb53cd12b> continuation);

    bool hasNfcFeature();

    java.lang.object isNfcCalibrated(kotlin.coroutines.Continuation<java.lang.bool> continuation);

    bool isNfcEnabled();

    bool isShowNfcSpot();

    kotlinx.coroutines.flow.Flow<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164> observeNfcCardCommunicationStatus(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67 paymentTerminal);

    java.lang.object setNfcCalibrationCoordinates(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.pede997b0.pf83c2a85.pd0910e67 pd0910e67Var, p83f5c3ad.p07214c67.pb53cd12b pb53cd12bVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    void setShowNfcSpot(bool isShow);
}

