using Microsoft.AspNetCore.Mvc.Rendering;

public static class ActiveSideBar
{
    public static string IsActive(this IHtmlHelper html, string controller = null, string action = null, string cssClass = null)
    {

        if (String.IsNullOrEmpty(cssClass))
            cssClass = "active";

        string currentAction = (string)html.ViewContext.RouteData.Values["action"];
        string currentController = (string)html.ViewContext.RouteData.Values["controller"];

        if (String.IsNullOrEmpty(controller))
            controller = currentController;

        if (String.IsNullOrEmpty(action))
            action = currentAction;

        return controller.ToLower().Split(',').Contains(currentController.ToLower()) && action.ToLower().Split(',').Contains(currentAction.ToLower()) ?
            cssClass : String.Empty;
    }

    public static string IsActiveShow(this IHtmlHelper html, string controller = null, string cssClass = null)
    {

        if (String.IsNullOrEmpty(cssClass))
            cssClass = "show";

        string currentController = (string)html.ViewContext.RouteData.Values["controller"];

        if (String.IsNullOrEmpty(controller))
            controller = currentController;


        return controller.Contains(currentController.ToLower()) ?
            cssClass : String.Empty;
    }
}
