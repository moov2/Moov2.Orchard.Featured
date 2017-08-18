﻿using Orchard.Mvc.Routes;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
namespace Moov2.Orchard.Featured
{
    public class Routes : IRouteProvider
    {
        public void GetRoutes(ICollection<RouteDescriptor> routes)
        {
            foreach (RouteDescriptor routeDescriptor in GetRoutes())
            {
                routes.Add(routeDescriptor);
            }
        }

        public IEnumerable<RouteDescriptor> GetRoutes()
        {
            return new[] {
                new RouteDescriptor {
                    Priority = 5,
                    Route = new Route(
                        "Admin/Featured/Toggle/{id}",
                        new RouteValueDictionary {
                            {"area", "Moov2.Orchard.Featured"},
                            {"controller", "Home"},
                            {"action", "Toggle"}
                        },
                        new RouteValueDictionary(),
                        new RouteValueDictionary {
                            {"area", "Moov2.Orchard.Featured"}
                        },
                        new MvcRouteHandler())
                },
            };
        }
    }
}