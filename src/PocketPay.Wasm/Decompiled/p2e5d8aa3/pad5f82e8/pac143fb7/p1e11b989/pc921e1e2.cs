namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0010\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0016J\n\u0010\n\u001a\u0004\u0018\u00010\tH\u0016J\u0010\u0010\u000b\u001a\u00020\u00072\u0006\u0010\f\u001a\u00020\rH\u0016J\b\u0010\u000e\u001a\u00020\rH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Lp2e5d8aa3/pad5f82e8/pac143fb7/p1e11b989/pc921e1e2;", "Lp2e5d8aa3/p1e11b989/pac143fb7/p0a4fdf59;", "localHashSettingsRepository", "Lp2e5d8aa3/pe0212e54/pb3f20355/p2d884c28;", "<init>", "(Lp2e5d8aa3/pe0212e54/pb3f20355/p2d884c28;)V", "setDefaultReceiptCredential", "", "value", "Lpad5f82e8/p07214c67/p1e11b989/pcb7684f4;", "getDefaultReceiptCredential", "setShouldPrintReceipt", "checked", "", "getShouldPrintReceiptFromLocalStorage", "feature-settings-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pc921e1e2 : p2e5d8aa3.p1e11b989.pac143fb7.p0a4fdf59 {
    private readonly p2e5d8aa3.pe0212e54.pb3f20355.p2d884c28 f177d40c6;
    private readonly p2e5d8aa3.pe0212e54.pb3f20355.p2d884c28 f2fcd523d;
    private readonly p2e5d8aa3.pe0212e54.pb3f20355.p2d884c28 fbbcec403;

    public pc921e1e2(p2e5d8aa3.pe0212e54.pb3f20355.p2d884c28 localHashSettingsRepository) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(localHashSettingsRepository, "localHashSettingsRepository");
        this.fbbcec403 = localHashSettingsRepository;
    }

    public override pad5f82e8.p07214c67.p1e11b989.pcb7684f4 GetDefaultReceiptCredential() {
        return this.fbbcec403.getDefaultReceiptCredentials();
    }

    public override bool GetShouldPrintReceiptFromLocalStorage() {
        return this.fbbcec403.getShouldPrintReceipt();
    }

    public override void SetDefaultReceiptCredential(pad5f82e8.p07214c67.p1e11b989.pcb7684f4 value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        this.fbbcec403.setDefaultReceiptCredentials(value);
    }

    public override void SetShouldPrintReceipt(bool checked) {
        this.fbbcec403.setShouldPrintReceipt(checked);
    }
}

