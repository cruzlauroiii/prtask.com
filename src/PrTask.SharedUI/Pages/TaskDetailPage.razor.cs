using Microsoft.AspNetCore.Components.Forms;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.SharedUI.Pages;
public partial class TaskDetailPage
{
#pragma warning disable S5693
    private async Task HandleFileUploadAsync(InputFileChangeEventArgs E)
    {
        var Files = new Dictionary<string, string>();
        var SkippedType = false;
        var SkippedSize = false;
        long TotalSize = 0;
        foreach (var File in E.GetMultipleFiles(SourceCodeConstants.MaxUploadFileCount))
        {
            var Extension = Path.GetExtension(File.Name);
            if (!SourceCodeConstants.AllowedExtensions.Contains(Extension))
            {
                SkippedType = true;
                continue;
            }
            if (File.Size > SourceCodeConstants.MaxUploadFileSizeBytes)
            {
                SkippedSize = true;
                continue;
            }
            TotalSize += File.Size;
            if (TotalSize > SourceCodeConstants.MaxTotalUploadSizeBytes)
            {
                UploadStatus = SourceCodeConstants.TotalSizeTooLarge;
                return;
            }
            using var Reader = new StreamReader(File.OpenReadStream(SourceCodeConstants.MaxUploadFileSizeBytes));
            Files[File.Name] = await Reader.ReadToEndAsync();
        }
        UploadedFiles = Files;
        if (Files.Count == 0)
        {
            UploadStatus = SourceCodeConstants.NoValidFiles;
            return;
        }
        UploadStatus = string.Format(SourceCodeConstants.SelectedFilesFormat, Files.Count);
        if (SkippedType)
        {
            UploadStatus += SourceCodeConstants.WarningSeparator + SourceCodeConstants.InvalidFileType;
        }
        if (SkippedSize)
        {
            UploadStatus += SourceCodeConstants.WarningSeparator + SourceCodeConstants.FileTooLarge;
        }
    }
#pragma warning restore S5693
}
