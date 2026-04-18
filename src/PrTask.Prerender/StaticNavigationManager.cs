using Microsoft.AspNetCore.Components;
using PrTask.Domain.Constants;

namespace PrTask.Prerender;
public sealed class StaticNavigationManager : NavigationManager
{
    public StaticNavigationManager(string Uri)
    {
        Initialize(PrerenderConstants.BaseUrlSlash, Uri);
    }

#pragma warning disable S1186
    protected override void NavigateToCore(string Uri, bool ForceLoad)
    {
    }
#pragma warning restore S1186
}
