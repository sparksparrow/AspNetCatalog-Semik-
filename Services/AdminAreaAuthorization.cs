using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Authorization;

namespace GnomShop.Services
{
    public class AdminAreaAuthorization : IControllerModelConvention
    {
        private readonly string area;
        private readonly string policy;

        public AdminAreaAuthorization(string area, string policy)
        {
            this.area = area;
            this.policy = policy;
        }

        public void Apply(ControllerModel controller)
        {
            if (controller.Attributes.Any(x => x is AreaAttribute && (x as AreaAttribute).RouteValue.Equals(area, StringComparison.OrdinalIgnoreCase)) || controller.RouteValues.Any(y => y.Key.Equals("area", StringComparison.OrdinalIgnoreCase) && y.Value.Equals(area, StringComparison.OrdinalIgnoreCase)))
            {
                controller.Filters.Add(new AuthorizeFilter(policy));
            }
        }   
    }
}
