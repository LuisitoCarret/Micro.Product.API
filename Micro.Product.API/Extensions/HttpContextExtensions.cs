using Microsoft.EntityFrameworkCore;

namespace Micro.Product.API.Extensions
{
    public static class HttpContextExtensions
    {
        public async static Task InsertParamPageHeader<T>(this HttpContext httpContext, IQueryable<T> queryable)
        {
            if (httpContext is null)
            {
                throw new ArgumentNullException(nameof(httpContext));
            }
            //contamos el total de la consulta que reciba el iqueryable
            //una vez calculado el total de registros consultados se asigna a la variable

            double total = await queryable.CountAsync();
            //asignamos a la cabecera el total de registros obtenidos
            httpContext.Response.Headers.Append("catntidad-total-registros",total.ToString());  
        }
    }
}
