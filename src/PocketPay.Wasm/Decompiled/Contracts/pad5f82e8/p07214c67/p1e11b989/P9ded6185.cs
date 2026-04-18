namespace WillowMaze.Wasm.Decompiled;

public interface P9ded6185
{
    string GetClientEmail();
    string GetClientPhone();
    DateTime GetCreationDate();
    decimal GetCustomerChange();
    string GetEmployeeId();
    string GetErrorMessage();
    string GetExtra();
    string GetNote();
    p5a409c20 GetOperationType();
    string GetPaymentAddress();
    string GetPaymentPlace();
    p8c261c90 GetPaymentType();
    List<object> GetPayments();
    List<object> GetPositions();
    pc5f0acf1 GetQrPayInfo();
    decimal GetReceiptDiscount();
    int GetReceiptNumber();
    p22820a6f GetReceiptType();
    bool GetShouldPrintReceipt();
    pd751e33c GetStatus();
    string GetTapOnPhoneRefId();
    string GetUuid();
    void SetClientEmail(string P0);
    void SetClientPhone(string P0);
}
