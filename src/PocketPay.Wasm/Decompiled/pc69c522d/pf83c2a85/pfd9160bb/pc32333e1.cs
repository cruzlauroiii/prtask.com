namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\bf\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H&J\b\u0010\u0004\u001a\u00020\u0005H&J\b\u0010\u0006\u001a\u00020\u0005H&J\b\u0010\u0007\u001a\u00020\u0003H&J\b\u0010\b\u001a\u00020\u0003H&J\b\u0010\t\u001a\u00020\u0003H&J\b\u0010\n\u001a\u00020\u0003H&J\u0012\u0010\u000b\u001a\u00020\u00032\b\u0010\f\u001a\u0004\u0018\u00010\rH&J\u0010\u0010\u000e\u001a\u00020\u00032\u0006\u0010\u000f\u001a\u00020\u0010H&J\u0010\u0010\u0011\u001a\u00020\u00032\u0006\u0010\u0012\u001a\u00020\u0013H&J\u0010\u0010\u0014\u001a\u00020\u00032\u0006\u0010\f\u001a\u00020\rH&J\u0010\u0010\u0015\u001a\u00020\u00032\u0006\u0010\f\u001a\u00020\rH&J\u0010\u0010\u0016\u001a\u00020\u00032\u0006\u0010\f\u001a\u00020\rH&J\u0010\u0010\u0017\u001a\u00020\u00032\u0006\u0010\f\u001a\u00020\rH&J\b\u0010\u0018\u001a\u00020\u0003H&¨\u0006\u0019"}, d2 = {"Lpc69c522d/pf83c2a85/pfd9160bb/pc32333e1;", "", "openComboPayment", "", "getComboPaymentScreen", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p2fc3359e;", "getComboPaybackPaymentScreen", "replaceComboPayment", "backToComboPayment", "openPaybackComboPayment", "backToPaybackComboPayment", "openSellComboCash", "payment", "Lpad5f82e8/p07214c67/p1e11b989/pad7c4a1f;", "openSellComboElectron", "paymentType", "Lpad5f82e8/p07214c67/p1e11b989/p8c261c90;", "replaceSellComboElectronProcessing", "amount", "Ljava/math/decimal;", "openPaybackComboType", "openSellCancelCombo", "openPaybackCancelCombo", "replacePaybackCancelCombo", "back", "feature-combo-payment-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pc32333e1 {
    void back();

    void backToComboPayment();

    void backToPaybackComboPayment();

    p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e getComboPaybackPaymentScreen();

    p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e getComboPaymentScreen();

    void openComboPayment();

    void openPaybackCancelCombo(pad5f82e8.p07214c67.p1e11b989.pad7c4a1f payment);

    void openPaybackComboPayment();

    void openPaybackComboType(pad5f82e8.p07214c67.p1e11b989.pad7c4a1f payment);

    void openSellCancelCombo(pad5f82e8.p07214c67.p1e11b989.pad7c4a1f payment);

    void openSellComboCash(pad5f82e8.p07214c67.p1e11b989.pad7c4a1f payment);

    void openSellComboElectron(pad5f82e8.p07214c67.p1e11b989.p8c261c90 paymentType);

    void replaceComboPayment();

    void replacePaybackCancelCombo(pad5f82e8.p07214c67.p1e11b989.pad7c4a1f payment);

    void replaceSellComboElectronProcessing(java.math.decimal amount);
}

