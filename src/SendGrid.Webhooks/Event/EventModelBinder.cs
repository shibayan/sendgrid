using System;
using System.Web.Mvc;

namespace SendGrid.WebHooks.Event
{
    public class EventModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            throw new NotImplementedException();
        }
    }
}
