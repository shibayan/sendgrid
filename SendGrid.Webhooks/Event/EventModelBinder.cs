using System;
using System.Web.Mvc;

namespace SendGrid.Webhooks.Event
{
    public class EventModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            throw new NotImplementedException();
        }
    }
}
