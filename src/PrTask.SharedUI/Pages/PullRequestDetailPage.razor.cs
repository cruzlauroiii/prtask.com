using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.SharedUI.Pages;
public partial class PullRequestDetailPage
{
    [Inject]
    private IJSRuntime JsRuntime { get; set; } = default!;
    [Inject]
    private IPullRequestService PullRequestService { get; set; } = default!;
    [Inject]
    private IReviewCommentService ReviewCommentService { get; set; } = default!;
    [Inject]
    private ISourceCodeService SourceCodeService { get; set; } = default!;
    [Parameter]
    public string PrId { get; set; } = string.Empty;
    private PullRequestEntity? CurrentPr { get; set; }
    private List<ReviewComment> Comments { get; set; } = [];
    private List<ReviewComment> TopLevelComments { get; set; } = [];
    private Dictionary<string, List<ReviewComment>> RepliesByParent { get; set; } = [];
    private List<(string Type, string Text)> DiffLines { get; set; } = [];
    private List<string> ChangedFiles { get; set; } = [];
    private IDictionary<string, string> OriginalFiles { get; set; } = new Dictionary<string, string>();
    private IDictionary<string, string> ModifiedFiles { get; set; } = new Dictionary<string, string>();
    private string OldFileContent { get; set; } = string.Empty;
    private string NewFileContent { get; set; } = string.Empty;
    private string SelectedFileName { get; set; } = string.Empty;
    private string DiffContent { get; set; } = string.Empty;
    private bool IsEditMode { get; set; }
    private bool IsSplitView { get; set; }
    private int InlineCommentLine { get; set; }
    private string NewCommentBody { get; set; } = string.Empty;
    private string EditableCode { get; set; } = string.Empty;
    private string StatusMessage { get; set; } = string.Empty;
    private string CurrentUserId { get; set; } = string.Empty;
    private string? ReplyCommentId { get; set; }
    private string ReplyBody { get; set; } = string.Empty;
    private string EditModeLabel => IsEditMode ? PrDetailConstants.ViewDiffLabel : PrDetailConstants.EditCodeLabel;
    private string SplitViewModeLabel => IsSplitView ? PrDetailConstants.UnifiedViewLabel : PrDetailConstants.SplitViewLabel;
    protected override async Task OnAfterRenderAsync(bool FirstRender)
    {
        if (FirstRender) { CurrentUserId = await JsRuntime.InvokeAsync<string>(JsInteropConstants.GetUserId); }
    }
    protected override async Task OnInitializedAsync()
    {
        CurrentPr = await PullRequestService.GetByIdAsync(PrId);
        Comments = [.. await ReviewCommentService.ListByPullRequestAsync(PrId)];
        GroupComments();
        if (CurrentPr is null) { return; }
        OriginalFiles = await SourceCodeService.GetFilesAsync(CurrentPr.TaskId);
        ModifiedFiles = await SourceCodeService.GetModifiedFilesAsync(CurrentPr.TaskId, PrId);
        DiffContent = await SourceCodeService.GenerateDiffAsync(CurrentPr.TaskId, PrId);
        if (!string.IsNullOrEmpty(DiffContent)) { ParseDiff(); }
        BuildFileContents();
        if (ModifiedFiles.Count > 0) { EditableCode = string.Join('\n', ModifiedFiles.Values); }
        else if (OriginalFiles.Count > 0) { EditableCode = string.Join('\n', OriginalFiles.Values); }
    }
    private void BuildFileContents()
    {
        if (ChangedFiles.Count > 0) { SelectedFileName = ChangedFiles[0]; UpdateSelectedFileContent(); }
        else if (OriginalFiles.Count > 0)
        {
            SelectedFileName = OriginalFiles.Keys.First();
            OldFileContent = OriginalFiles.Values.First();
            NewFileContent = ModifiedFiles.Count > 0 ? ModifiedFiles.Values.First() : OldFileContent;
        }
    }
    private void SelectFile(string FileName) { SelectedFileName = FileName; UpdateSelectedFileContent(); }
    private void UpdateSelectedFileContent()
    {
        OldFileContent = OriginalFiles.TryGetValue(SelectedFileName, out var OldContent) ? OldContent : string.Empty;
        NewFileContent = ModifiedFiles.TryGetValue(SelectedFileName, out var NewContent) ? NewContent : OldFileContent;
    }
    private void ParseDiff()
    {
        DiffLines.Clear(); ChangedFiles.Clear();
        foreach (var Line in DiffContent.Split('\n'))
        {
            if (Line.StartsWith(DiffConstants.DiffSpacePrefix, StringComparison.Ordinal))
            {
                var Parts = Line.Split(' ');
                if (Parts.Length > DiffConstants.HeaderPartBIndex) { ChangedFiles.Add(Parts[DiffConstants.HeaderPartBIndex].TrimStart('b', '/')); }
                continue;
            }
            if (Line.StartsWith(DiffConstants.DeletionPrefix, StringComparison.Ordinal) || Line.StartsWith(DiffConstants.AdditionPrefix, StringComparison.Ordinal)) { continue; }
            if (Line.StartsWith(DiffConstants.AdditionChar)) { DiffLines.Add((DiffConstants.LineTypeAdd, Line.Length > DiffConstants.MinLineLength ? Line[1..] : string.Empty)); }
            else if (Line.StartsWith(DiffConstants.DeletionChar)) { DiffLines.Add((DiffConstants.LineTypeDel, Line.Length > DiffConstants.MinLineLength ? Line[1..] : string.Empty)); }
            else if (Line.Length > 0) { DiffLines.Add((DiffConstants.LineTypeContext, Line.Length > DiffConstants.MinLineLength ? Line[1..] : string.Empty)); }
        }
    }
    private void ToggleEditMode() => IsEditMode = !IsEditMode;
    private void ToggleSplitView() => IsSplitView = !IsSplitView;
    private async Task SaveEditsAsync()
    {
        if (CurrentPr is null) { return; }
        var FileName = ChangedFiles.Count > 0 ? ChangedFiles[0] : DiffConstants.DefaultFileName;
        await SourceCodeService.StoreModifiedFilesAsync(CurrentPr.TaskId, PrId, new Dictionary<string, string> { [FileName] = EditableCode });
        ModifiedFiles = await SourceCodeService.GetModifiedFilesAsync(CurrentPr.TaskId, PrId);
        DiffContent = await SourceCodeService.GenerateDiffAsync(CurrentPr.TaskId, PrId);
        ParseDiff(); BuildFileContents(); IsEditMode = false; StatusMessage = PrConstants.StatusChangesSaved;
    }
    private void StartInlineComment(int LineNumber) => InlineCommentLine = LineNumber;
    private void CancelComment() { InlineCommentLine = 0; NewCommentBody = string.Empty; }
    private async Task SubmitCommentAsync()
    {
        if (string.IsNullOrWhiteSpace(NewCommentBody)) { return; }
        var FileName = ChangedFiles.Count > 0 ? ChangedFiles[0] : DiffConstants.DefaultFileName;
        await ReviewCommentService.CreateAsync(new ReviewComment { PullRequestId = PrId, AuthorId = CurrentUserId, FilePath = FileName, LineNumber = InlineCommentLine, Body = NewCommentBody });
        Comments = [.. await ReviewCommentService.ListByPullRequestAsync(PrId)];
        GroupComments(); InlineCommentLine = 0; NewCommentBody = string.Empty;
    }
    private async Task ResolveCommentAsync(string CommentId)
    {
        await ReviewCommentService.ResolveAsync(CommentId);
        Comments = [.. await ReviewCommentService.ListByPullRequestAsync(PrId)]; GroupComments();
    }
    private void GroupComments()
    {
        TopLevelComments = [.. Comments.Where(C => string.IsNullOrEmpty(C.ParentCommentId))];
        RepliesByParent = Comments.Where(C => !string.IsNullOrEmpty(C.ParentCommentId)).GroupBy(C => C.ParentCommentId!).ToDictionary(G => G.Key, G => G.ToList());
    }
    private void StartReply(string CommentId) { ReplyCommentId = CommentId; ReplyBody = string.Empty; }
    private void CancelReply() { ReplyCommentId = null; ReplyBody = string.Empty; }
    private async Task SubmitReplyAsync()
    {
        if (string.IsNullOrWhiteSpace(ReplyBody) || ReplyCommentId is null) { return; }
        var Parent = Comments.FirstOrDefault(C => C.Id == ReplyCommentId);
        await ReviewCommentService.CreateAsync(new ReviewComment { PullRequestId = PrId, AuthorId = CurrentUserId, FilePath = Parent?.FilePath ?? string.Empty, LineNumber = Parent?.LineNumber ?? 0, Body = ReplyBody, ParentCommentId = ReplyCommentId });
        Comments = [.. await ReviewCommentService.ListByPullRequestAsync(PrId)];
        GroupComments(); ReplyCommentId = null; ReplyBody = string.Empty;
    }
    private async Task ApproveCurrentPrAsync()
    {
        await PullRequestService.ApproveAsync(PrId);
        CurrentPr = await PullRequestService.GetByIdAsync(PrId); StatusMessage = PrConstants.StatusApprovedMerged;
    }
    private async Task RejectCurrentPrAsync()
    {
        await PullRequestService.RejectAsync(PrId, PrConstants.RejectionReason);
        CurrentPr = await PullRequestService.GetByIdAsync(PrId); StatusMessage = PrConstants.StatusChangesRequested;
    }
}
