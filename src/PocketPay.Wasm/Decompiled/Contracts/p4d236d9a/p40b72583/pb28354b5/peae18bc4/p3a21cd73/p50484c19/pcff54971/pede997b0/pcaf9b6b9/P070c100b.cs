namespace WillowMaze.Wasm.Decompiled;

public interface P070c100b
{
    bool GetCardTypeLimitEnabledMastercard();
    bool GetCardTypeLimitEnabledVisa();
    string GetCharCurrency();
    int GetCountryCode();
    int GetCurrency();
    DecimalFormat GetFormatterCurrency();
    long GetMastercardCdcvmLimit();
    string GetMastercardCdcvmLimitString();
    long GetMastercardCvmRequiredLimit();
    string GetMastercardCvmRequiredLimitString();
    long GetMastercardNoCdcvmLimit();
    string GetMastercardNoCdcvmLimitString();
    bool GetMastercardPinEnabled();
    bool GetMastercardSignatureEnabled();
    int GetMcc();
    string GetMerchantAddress();
    string GetMerchantBrandName();
    string GetMerchantEmail();
    string GetMerchantId();
    string GetMerchantLegalName();
    string GetMerchantName();
    string GetMerchantPhone();
    string GetMerchantTaxRefNumber();
    string GetQrMerchantId();
    string GetQrSubmerchantId();
    string GetQrSubmerchantName();
    bool GetReaderContactlessTransactionLimitEnabled();
    bool GetReaderCvmRequiredLimitEnabled();
    string GetTerminalId();
    long GetVisaContactlessLimit();
    string GetVisaContactlessLimitString();
    long GetVisaCvmRequiredLimit();
    string GetVisaCvmRequiredLimitString();
    bool GetVisaPinEnabled();
    bool GetVisaSignatureEnabled();
    bool IsLocationRequired();
    bool IsQrPaymentsAllowed();
}
