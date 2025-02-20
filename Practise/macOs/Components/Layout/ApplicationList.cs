using macOs.Applications;
using macOs.Components.Pages;

namespace macOs.Applications.AppList;

public class App
{
    public List<Application> app = [
        new(){
            ApplicationName="Finder",
            IsApplicationOpen=false,
            AppIcon="https://upload.wikimedia.org/wikipedia/en/9/98/FinderBigSur.png",
            ComponentType = typeof(Finder)
        },
        new(){
            ApplicationName="VS Code",
            IsApplicationOpen=false,
            AppIcon="https://upload.wikimedia.org/wikipedia/commons/thumb/9/9a/Visual_Studio_Code_1.35_icon.svg/2048px-Visual_Studio_Code_1.35_icon.svg.png",
            ComponentType = typeof(VsCode)
        },
        new(){
            ApplicationName="Safari",
            IsApplicationOpen=false,
            AppIcon="https://upload.wikimedia.org/wikipedia/commons/thumb/5/52/Safari_browser_logo.svg/1200px-Safari_browser_logo.svg.png",
            ComponentType = typeof(Safari)
        }
    ];
}