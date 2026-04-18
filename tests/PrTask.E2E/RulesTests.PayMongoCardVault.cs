using System.Net.Http.Headers;
using System.Text.Json;

namespace PrTask.E2E;

public partial class RulesTests
{
    private static async Task<JsonElement> PayMongoCreateCustomerCoreAsync(HttpClient Client,
        string FirstName, string LastName, string Email, string Phone)
    {
        var Body = JsonSerializer.Serialize(new
        {
            data = new
            {
                attributes = new
                {
                    first_name = FirstName,
                    last_name = LastName,
                    email = Email,
                    phone = Phone,
                    default_device = "email"
                }
            }
        });
        var Response = await Client.PostAsync("/v1/customers",
            new StringContent(Body, Encoding.UTF8, "application/json"));
        var ResponseBody = await Response.Content.ReadAsStringAsync();
        Assert.IsTrue(Response.IsSuccessStatusCode,
            $"CreateCustomer must return 2xx, got {(int)Response.StatusCode}: {ResponseBody}");
        return JsonElement.Parse(ResponseBody);
    }

    private static async Task<JsonElement> PayMongoRetrieveCustomerAsync(HttpClient Client, string Email)
    {
        var Response = await Client.GetAsync($"/v1/customers?email={Email}");
        var ResponseBody = await Response.Content.ReadAsStringAsync();
        Assert.IsTrue(Response.IsSuccessStatusCode,
            $"RetrieveCustomer must return 2xx, got {(int)Response.StatusCode}: {ResponseBody}");
        return JsonElement.Parse(ResponseBody);
    }

    private static async Task<JsonElement> PayMongoListCustomerMethodsAsync(HttpClient Client, string CustomerId)
    {
        var Response = await Client.GetAsync($"/v1/customers/{CustomerId}/payment_methods");
        var ResponseBody = await Response.Content.ReadAsStringAsync();
        Assert.IsTrue(Response.IsSuccessStatusCode,
            $"ListMethods must return 2xx, got {(int)Response.StatusCode}: {ResponseBody}");
        return JsonElement.Parse(ResponseBody);
    }

    [TestMethod]
    [DisplayName("PayMongo: create customer for card management")]
    public async Task PayMongoCreateCustomerAsync()
    {
        using var Client = CreatePayMongoClient();
        var UniqueEmail = $"e2e-cust-{DateTime.UtcNow:yyyyMMddHHmmssff}@prtask.com";
        var Customer = await PayMongoCreateCustomerCoreAsync(Client,
            "E2E", "TestUser", UniqueEmail, "+639171234567");

        var CustomerId = PayMongoGetId(Customer);
        Assert.IsTrue(CustomerId.StartsWith("cus_"), $"Customer ID must start with cus_, got {CustomerId}");

        var Attrs = Customer.GetProperty("data").GetProperty("attributes");
        Assert.AreEqual("E2E", Attrs.GetProperty("first_name").GetString());
        Assert.AreEqual("TestUser", Attrs.GetProperty("last_name").GetString());
        Assert.AreEqual(UniqueEmail, Attrs.GetProperty("email").GetString());
    }

    [TestMethod]
    [DisplayName("PayMongo: retrieve customer by email")]
    public async Task PayMongoRetrieveCustomerByEmailAsync()
    {
        using var Client = CreatePayMongoClient();
        var UniqueEmail = $"e2e-retrieve-{DateTime.UtcNow:yyyyMMddHHmmss}@prtask.com";

        await PayMongoCreateCustomerCoreAsync(Client, "Retrieve", "Test", UniqueEmail, "+639170001111");

        var Result = await PayMongoRetrieveCustomerAsync(Client, UniqueEmail);
        var DataArray = Result.GetProperty("data");
        Assert.IsTrue(DataArray.GetArrayLength() > 0, "Must find customer by email");

        var FoundEmail = DataArray[0].GetProperty("attributes").GetProperty("email").GetString();
        Assert.AreEqual(UniqueEmail, FoundEmail, "Found customer email must match");
    }

    [TestMethod]
    [DisplayName("PayMongo: customer has empty payment methods initially")]
    public async Task PayMongoCustomerEmptyMethodsAsync()
    {
        using var Client = CreatePayMongoClient();
        var EmptyEmail = $"e2e-empty-{DateTime.UtcNow:yyyyMMddHHmmssff}@prtask.com";
        var Customer = await PayMongoCreateCustomerCoreAsync(Client,
            "Empty", "Methods", EmptyEmail, "+639170002222");
        var CustomerId = PayMongoGetId(Customer);

        var Methods = await PayMongoListCustomerMethodsAsync(Client, CustomerId);
        var DataArray = Methods.GetProperty("data");
        Assert.AreEqual(0, DataArray.GetArrayLength(), "New customer must have 0 payment methods");
    }

    [TestMethod]
    [DisplayName("PayMongo: card payment creates payment object")]
    public async Task PayMongoCardPaymentCreatesPaymentObjectAsync()
    {
        using var Client = CreatePayMongoClient();
        var Intent = await PayMongoCreateIntentAsync(Client, 10000, "E2E payment object");
        var IntentId = PayMongoGetId(Intent);
        var ClientKey = PayMongoGetClientKey(Intent);

        var Method = await PayMongoCreateMethodAsync(Client, TestCardVisaSuccess, 12, 2029, "123");
        var (Attached, StatusCode) = await PayMongoAttachAsync(Client, IntentId, PayMongoGetId(Method), ClientKey);
        Assert.AreEqual(200, StatusCode);
        Assert.AreEqual("succeeded", PayMongoGetStatus(Attached));

        var Payments = Attached.GetProperty("data").GetProperty("attributes").GetProperty("payments");
        Assert.IsTrue(Payments.GetArrayLength() > 0, "Succeeded intent must have payment objects");

        var PaymentId = Payments[0].GetProperty("id").GetString()!;
        Assert.IsTrue(PaymentId.StartsWith("pay_"), $"Payment ID must start with pay_, got {PaymentId}");
    }

    [TestMethod]
    [DisplayName("PayMongo: create and retrieve card payment method")]
    public async Task PayMongoCreateRetrieveMethodAsync()
    {
        using var Client = CreatePayMongoClient();
        var Method = await PayMongoCreateMethodAsync(Client, TestCardVisaSuccess, 12, 2029, "123");
        var MethodId = PayMongoGetId(Method);

        var Response = await Client.GetAsync($"/v1/payment_methods/{MethodId}");
        var ResponseBody = await Response.Content.ReadAsStringAsync();
        Assert.IsTrue(Response.IsSuccessStatusCode,
            $"RetrieveMethod must return 2xx, got {(int)Response.StatusCode}");

        var Retrieved = JsonElement.Parse(ResponseBody);
        var Details = Retrieved.GetProperty("data").GetProperty("attributes").GetProperty("details");
        Assert.AreEqual("4345", Details.GetProperty("last4").GetString(), "Last4 must be 4345 for Visa test card");
        Assert.AreEqual(12, Details.GetProperty("exp_month").GetInt32());
        Assert.AreEqual(2029, Details.GetProperty("exp_year").GetInt32());
    }

    [TestMethod]
    [DisplayName("PayMongo: Mastercard debit card payment succeeds")]
    public async Task PayMongoMastercardDebitSucceedsAsync()
    {
        using var Client = CreatePayMongoClient();
        var Intent = await PayMongoCreateIntentAsync(Client, 3000, "E2E MC debit");
        var IntentId = PayMongoGetId(Intent);
        var ClientKey = PayMongoGetClientKey(Intent);

        var Method = await PayMongoCreateMethodAsync(Client, "5455590000000009", 12, 2029, "789");
        var (Attached, StatusCode) = await PayMongoAttachAsync(Client, IntentId, PayMongoGetId(Method), ClientKey);
        Assert.AreEqual(200, StatusCode, $"MC debit attach must return 200, got {StatusCode}");
        Assert.AreEqual("succeeded", PayMongoGetStatus(Attached), "MC debit payment must succeed");
    }
}
