using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;

namespace DiplomLast.Models
{
    public static class IdentityExtensions
    {
        public static string GetDisplayName(this IIdentity identity)
        {
            if (identity == null)
            {
                throw new ArgumentNullException("identity");
            }
            var ci = identity as ClaimsIdentity;
            if (ci != null)
            {
                return ci.FindFirstValue("Name");
            }
            return null;
        }
        public static T GetUserId<T>(this IIdentity identity) where T : IConvertible
        {
            if (identity == null)
            {
                throw new ArgumentNullException("identity");
            }
            var ci = identity as ClaimsIdentity;
            if (ci != null)
            {
                var id = ci.FindFirst(ClaimTypes.NameIdentifier);
                if (id != null)
                {
                    return (T)Convert.ChangeType(id.Value, typeof(T), CultureInfo.InvariantCulture);
                }
            }
            return default(T);
        }
        public static List<string> GetUserRole(this IIdentity identity)
        {
            List<string> roles = new List<string>();
            if (identity == null)
            {
                throw new ArgumentNullException("identity");
            }
            var ci = identity as ClaimsIdentity;
            //string role = "";
            if (ci != null)
            {
                var id = ci.FindAll(ClaimsIdentity.DefaultRoleClaimType);
              //  roles.AddRange(id.);
                foreach (var item in id)
                {
                    roles.Add(item.Value);
                }
                //if (id != null)
                //    role = id.Value;
            }
            return roles;
        }
    }
}