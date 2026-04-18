using PrTask.Cdp;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static async Task FillTaskFormAsync(
        string Title,
        string Description,
        string RepoUrl,
        string Complexity,
        string BountyAmount,
        string[]? Tags = null)
    {
        await CdpHelpers.FillFieldAsync(BrowserPage, "input#Title", Title);
        await CdpHelpers.FillFieldAsync(BrowserPage, "textarea#Description", Description);
        await CdpHelpers.FillFieldAsync(BrowserPage, "input#RepoUrl", RepoUrl);
        await CdpHelpers.SelectOptionAsync(BrowserPage, "select#Complexity", Complexity);
        await CdpHelpers.FillFieldAsync(BrowserPage, "input#BountyAmount", BountyAmount);

        if (Tags is not null && Tags.Length > 0)
        {
            await CdpHelpers.FillFieldAsync(BrowserPage, "input#Tags", string.Join(", ", Tags));
        }
    }

    private static async Task FillKycFormAsync(string DocumentType, string DocumentId)
    {
        await CdpHelpers.SelectOptionAsync(BrowserPage, "select#KycDocumentType", DocumentType);
        await CdpHelpers.FillFieldAsync(BrowserPage, "input#KycDocumentId", DocumentId);
    }

    private static async Task FillPrFormAsync(string GitHubPrUrl, string? DeveloperId = null)
    {
        await CdpHelpers.FillFieldAsync(BrowserPage, "input#GitHubPrUrl, input[name='GitHubPrUrl']", GitHubPrUrl);

        if (DeveloperId is not null)
        {
            await CdpHelpers.FillFieldAsync(BrowserPage, "input#DeveloperId", DeveloperId);
        }
    }

    private static async Task FillWithdrawalFormAsync(string PayoutMethod)
    {
        await CdpHelpers.SelectOptionAsync(BrowserPage, "select#PayoutMethod", PayoutMethod);
    }

    private static async Task FillCommentFormAsync(string CommentText)
    {
        await CdpHelpers.FillFieldAsync(BrowserPage, "textarea, .comment-input, .reply-textarea", CommentText);
    }

    private static async Task FillFormFieldAsync(string Selector, string Value)
    {
        await CdpHelpers.FillFieldAsync(BrowserPage, Selector, Value);
    }

    private static async Task SelectDropdownAsync(string Selector, string Value)
    {
        await CdpHelpers.SelectOptionAsync(BrowserPage, Selector, Value);
    }
}
